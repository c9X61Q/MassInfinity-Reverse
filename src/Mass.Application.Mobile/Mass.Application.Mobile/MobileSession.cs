using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Mass.Application.Desktop;
using Mass.Application.Desktop.Models;
using Mass.Domain.Desktop.Entities;
using Mass.Domain.Desktop.Entities.NetGame;
using Mass.Domain.Desktop.Entities.RentalGame;
using Mass.Domain.Desktop.Entities.Skin;
using Mass.Domain.Entities.Netease;
using Mass.Domain.Mobile.Entities.Game;
using Mass.Domain.Mobile.Entities.NetGame;
using Mass.Domain.Mobile.Entities.RentalGame;
using RestSharp;

namespace Mass.Application.Mobile;

public class MobileSession : DesktopSession
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem, long> _003C_003E9__15_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe _003C_003Ec()
		{
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			AsyncTaskMethodBuilder.Create();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe long _003CGetNetGamesAsync_003Eb__15_0(Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem x)
		{
			//IL_001b: Expected I8, but got VT
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (long)AsyncTaskMethodBuilder.Create();
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public string gameId;

		internal static _003C_003Ec__DisplayClass19_0 CheckRemoteExplorer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe _003C_003Ec__DisplayClass19_0()
		{
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			AsyncTaskMethodBuilder.Create();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetNetGame_003Eb__0(Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem n)
		{
			return Ⰰ(n) != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DecorateActiveAuthenticator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static _003C_003Ec__DisplayClass19_0 CountSharer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _2500()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778395, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _2600()
		{
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return _003C_003Ec._003C_003E9;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _2700()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778394, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _2800()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778393, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _2900()
		{
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (_003C_003Ec._003C_003E9 == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _2A00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778392, new IntPtr(2737336618796L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe byte _2B00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778399, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe byte Ⰰ(object P_0)
		{
			//IL_0026: Expected I4, but got VT
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			AsyncTaskMethodBuilder.Create();
			_ = _003C_003Ec._003C_003E9__15_0;
			return (byte)(int)AsyncTaskMethodBuilder<_0021_00210>.Create();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe byte ⴀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778398, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CEntitiesRequestAsync_003Ed__9<T> : IAsyncStateMachine where T : notnull
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T[]> _003C_003Et__builder;

		public MobileSession _003C_003E4__this;

		public string url;

		public object body;

		public bool checkCode;

		private TaskAwaiter<Entities<T>> _003C_003Eu__1;

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

		internal static bool PeekTransaction()
		{
			return true;
		}

		internal static object DecorateModularConfig()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CEntityRequestAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MobileSession _003C_003E4__this;

		public string url;

		public object body;

		public bool checkCode;

		private TaskAwaiter<object> _003C_003Eu__1;

		private static object CheckGroupedEmitter;

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
		internal static bool CheckAccessibleRunner()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DisableAuditor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _2E00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778397, new IntPtr(2737336620876L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _2F00()
		{
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return _003C_003Ec._003C_003E9;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _3000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778396, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _3100()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778403, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _3200()
		{
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (_003C_003Ec._003C_003E9 == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _3300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778402, new IntPtr(2737336636476L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 㐀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0330: Expected Obj, but got VT
			//IL_031a: Expected Obj, but got I4
			//IL_0323: Expected Obj, but got I4
			//IL_0342: Expected Obj, but got I4
			//IL_01aa: Expected Obj, but got I4
			//IL_01af: Expected Obj, but got I4
			//IL_01b8: Expected Obj, but got I4
			//IL_01cb: Expected Obj, but got Ref
			//IL_01cb: Expected Obj, but got Ref
			//IL_01d4: Expected Obj, but got I4
			//IL_0156: Expected Obj, but got I4
			//IL_015b: Expected Obj, but got I4
			//IL_00cd: Expected Obj, but got Ref
			//IL_0202: Expected I4, but got Obj
			//IL_0097: Expected I4, but got Obj
			//IL_0307->IL0026: Incompatible stack types: I4 vs Obj
			//IL_033a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0356->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0312->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0361->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0122->IL005e: Incompatible stack types: I4 vs Obj
			//IL_005a->IL005e: Incompatible stack heights: 1 vs 2
			//IL_0097->IL00ee: Incompatible stack heights: 1 vs 0
			//IL_012d->IL005e: Incompatible stack types: I4 vs Obj
			//IL_01d9->IL005a: Incompatible stack heights: 3 vs 1
			//IL_019a->IL005e: Incompatible stack types: I4 vs Obj
			//IL_016f->IL005e: Incompatible stack types: I4 vs Obj
			//IL_00a8->IL01a5: Incompatible stack heights: 2 vs 1
			//IL_00e3->IL005e: Incompatible stack types: I4 vs Obj
			//IL_0216->IL005e: Incompatible stack types: I4 vs Obj
			//IL_01a5->IL005e: Incompatible stack types: I4 vs Obj
			//IL_017a->IL005e: Incompatible stack types: I4 vs Obj
			//IL_00bc->IL005e: Incompatible stack heights: 3 vs 2
			//IL_00ee->IL005e: Incompatible stack types: I4 vs Obj
			//IL_0221->IL005e: Incompatible stack types: I4 vs Obj
			//IL_00c7->IL005e: Incompatible stack heights: 3 vs 2
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					MobileSession mobileSession;
					object obj3;
					switch ((int)obj2)
					{
					case 5:
						if (obj == null)
						{
							_ = 8;
							goto IL_005e;
						}
						goto IL_00ee;
					case 1:
						return;
					default:
						((AsyncTaskMethodBuilder<EntityRentalGameAddress>*)/*Error near IL_02f3: Stack underflow*/)->Start<TStateMachine>(ref Unsafe.As<MobileSession, TStateMachine>(ref ((_003CGetNetGameDetailsAsync_003Ed__20)this)._003C_003E4__this));
						obj2 = 1;
						if (_003CGetNetGameDetailsAsync_003Ed__20.AttachWrapper == null)
						{
							obj2 = 1;
						}
						continue;
					case 3:
						goto end_IL_0026;
					case 2:
						obj = ((_003CGetNetGamesAsync_003Ed__15)this)._003C_003Et__builder;
						obj2 = 5;
						continue;
					case 4:
						break;
						IL_00ee:
						mobileSession = ((_003CEntitiesRequestAsync_003Ed__9<>)this)._003C_003E4__this;
						((AsyncTaskMethodBuilder<EntityGameResourceInfo[]>*)((_003CEntitiesRequestAsync_003Ed__9<>)this).url)->Start(ref *(_003CGetGameResourceInfos_003Ed__22*)((_003CEntitiesRequestAsync_003Ed__9<>)this).body);
						obj = ((AsyncTaskMethodBuilder<_0021_00210>*)mobileSession)->Task;
						obj3 = 9;
						if ((int)((_003CEntityRequestAsync_003Ed__7*)_003CEntityRequestAsync_003Ed__7._003C_003E1__state)->_003C_003Et__builder == 0)
						{
							obj3 = 0;
						}
						goto IL_005e;
						IL_005e:
						while (true)
						{
							switch ((int)obj3)
							{
							case 9:
								_ = ref obj;
								if ((int)AsyncTaskMethodBuilder.Create() != 0)
								{
									_ = 7;
									if (((_003C_003Ec__DisplayClass19_0)(object)_003C_003Ec._003C_003E9__15_0).gameId == null)
									{
										_ = 5;
									}
									continue;
								}
								goto default;
							case 8:
							case 10:
								obj = _003C_003Ec__DisplayClass19_0.CheckRemoteExplorer;
								obj3 = 2;
								if ((int)((_003CEntitiesRequestAsync_003Ed__9<>*)_003CEntitiesRequestAsync_003Ed__9<>._003C_003E1__state)->_003C_003Et__builder != 0)
								{
									obj3 = 0;
								}
								continue;
							case 5:
								break;
							case 6:
								obj = -1;
								body = -1;
								obj3 = 11;
								if ((int)((_003CEntityRequestAsync_003Ed__7*)(_003CEntityRequestAsync_003Ed__7.checkCode ? 1 : 0))->_003C_003Eu__1 != 0)
								{
									obj3 = 7;
								}
								continue;
							case 2:
								Unsafe.As<object, _003CEntityRequestAsync_003Ed__8<_00210>>(ref CheckGroupedEmitter) = default;
								obj3 = 6;
								if (((_003CEntityRequestAsync_003Ed__8<>)_003CEntityRequestAsync_003Ed__8<>._003C_003Et__builder)._003C_003E4__this != null)
								{
									obj3 = 0;
								}
								continue;
							default:
								obj = 0;
								((_003CEntityRequestAsync_003Ed__8<>)this).url = (string)0;
								obj = 12;
								goto IL_005a;
							case 1:
								_ = ref ((_003CEntityRequestAsync_003Ed__8<>)this).body;
								((IEnumerable<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem>)(&obj)).OrderBy((Func<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem, long>)Unsafe.AsPointer(ref this));
								obj = 4;
								goto IL_005a;
							case 7:
							case 11:
								_ = ref obj;
								/*Error near IL_01ea: Member reference must be method, but was: Field*/;
							case 12:
								((_003CGetGameResourceInfos_003Ed__22)this)._003C_003E1__state = (int)obj;
								obj3 = 1;
								if (((_003CGetGameResourceInfos_003Ed__22)_003CGetGameResourceInfos_003Ed__22._003C_003Et__builder)._003C_003E4__this != null)
								{
									obj3 = 1;
								}
								continue;
							case 4:
								return;
							case 3:
								goto end_IL_0026_2;
								IL_005a:
								obj3 = obj;
								continue;
							}
							break;
						}
						goto IL_00ee;
						end_IL_0026_2:
						break;
					}
					((_003CGetNetGamesAsync_003Ed__15)this)._003C_003E4__this = (MobileSession)(-2);
					obj2 = 0;
					if (_003CGetNetGamesAsync_003Ed__15.DecorateDynamicSingleton != null)
					{
						obj2 = 0;
					}
					continue;
					end_IL_0026:
					break;
				}
				obj = ((_003CGetNetGamesAsync_003Ed__15)this)._003C_003E1__state;
				obj = 2;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 㔀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778401, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 㘀(object P_0)
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
					_ = ref _003C_003Ec._003C_003E9;
					_ = ((AsyncTaskMethodBuilder*)P_0)->Task;
					_ = 0;
					if (_003C_003Ec__DisplayClass19_0.CheckRemoteExplorer != null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 㜀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778400, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CEntityRequestAsync_003Ed__8<T> : IAsyncStateMachine where T : notnull
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public MobileSession _003C_003E4__this;

		public string url;

		public object body;

		public bool checkCode;

		private TaskAwaiter<Entity<T>> _003C_003Eu__1;

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

		internal static bool LoadList()
		{
			return true;
		}

		internal static object JoinRecord()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetGameResourceInfos_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityGameResourceInfo[]> _003C_003Et__builder;

		public MobileSession _003C_003E4__this;

		public string gameId;

		private TaskAwaiter<EntityGameResourceInfo[]> _003C_003Eu__1;

		internal static object DecorateLocalAggregator;

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
		internal static bool DecorateSymbolicTag()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckConfigurableDefinition()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 㠀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778407, new IntPtr(2737336620876L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 㤀()
		{
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return _003C_003Ec._003C_003E9;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 㨀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778406, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 㬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778405, new IntPtr(2737336618796L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 㰀()
		{
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (_003C_003Ec._003C_003E9 == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 㴀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778404, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 㼀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0314: Expected Obj, but got VT
			//IL_031e: Expected native int or pointer, but got Obj
			//IL_0150: Expected native int or pointer, but got Obj
			//IL_009d: Expected Obj, but got I4
			//IL_00a2: Expected Obj, but got I4
			//IL_00a2: Expected Obj, but got Ref
			//IL_011f: Expected VT, but got Obj
			//IL_01f7: Expected Obj, but got I4
			//IL_01fc: Expected VT, but got I4
			//IL_0206: Expected native int or pointer, but got Obj
			//IL_00b2: Expected Obj, but got Ref
			//IL_00c2: Expected native int or pointer, but got Obj
			//IL_00e5: Expected Obj, but got Ref
			//IL_00e5: Expected Obj, but got Ref
			//IL_030c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02ef->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0328->IL0026: Incompatible stack types: I4 vs Obj
			//IL_034a->IL0026: Incompatible stack heights: 3 vs 1
			//IL_02fa->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0333->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ef->IL005e: Incompatible stack heights: 3 vs 1
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
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
				default:
					if (obj != null)
					{
						num = 3;
						goto IL_005e;
					}
					goto IL_013e;
				case 2:
					return;
				case 3:
					obj = ((_003CGetNetGameDetailsAsync_003Ed__20)this).gameId;
					obj2 = 0;
					if (_003CGetNetGameDetailsAsync_003Ed__20.AttachWrapper != null)
					{
						obj2 = 0;
					}
					break;
				case 1:
					goto IL_02fa;
				case 4:
					obj = ((_003CGetNetGamesAsync_003Ed__15)this)._003C_003Et__builder;
					obj2 = 3;
					if ((int)((_003CGetNetGamesAsync_003Ed__15*)(nint)_003CGetNetGamesAsync_003Ed__15._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj2 = 3;
					}
					break;
				case 5:
					{
						_ = ref _003CGetNetGamesAsync_003Ed__15.DecorateDynamicSingleton;
						_ = ((AsyncTaskMethodBuilder<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails>*)obj)->Task;
						_ = 2;
						break;
					}
					IL_013e:
					obj = ((_003CEntityRequestAsync_003Ed__7)this)._003C_003E4__this;
					num = 8;
					if (((_003CEntityRequestAsync_003Ed__7*)(nint)_003CEntityRequestAsync_003Ed__7.url)->body == null)
					{
						num = 8;
					}
					goto IL_005e;
					IL_02fa:
					((_003CGetNetGamesAsync_003Ed__15)this)._003C_003E1__state = -2;
					obj2 = 5;
					break;
					IL_005e:
					while (true)
					{
						switch (num)
						{
						default:
							obj = -1;
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(-1);
							num = 5;
							continue;
						case 8:
							Unsafe.As<Func<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem, long>, _003CRequestAsync_003Ed__11<_0021_00210>>(ref _003C_003Ec._003C_003E9__15_0) = default;
							num = 0;
							if (((_003CEntitiesRequestAsync_003Ed__9<>*)(nint)_003C_003Ec__DisplayClass19_0.CheckRemoteExplorer)->_003C_003E1__state != 0)
							{
								num = 0;
							}
							continue;
						case 10:
							_ = ref ((_003CEntitiesRequestAsync_003Ed__9<>)this)._003C_003Et__builder;
							((IEnumerable<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem>)(&obj)).FirstOrDefault((Func<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem, bool>)Unsafe.AsPointer(ref this));
							_ = 11;
							continue;
						case 1:
						case 5:
							_ = ref obj;
							/*Error near IL_00f1: Member reference must be method, but was: Field*/;
						case 6:
							((_003CEntitiesRequestAsync_003Ed__9<>)this)._003C_003Eu__1 = (TaskAwaiter<Entities<T>>)obj;
							num = 10;
							if ((int)((_003CEntityRequestAsync_003Ed__7*)_003CEntityRequestAsync_003Ed__7._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								num = 10;
							}
							continue;
						case 2:
							break;
						case 4:
							_ = ref obj;
							/*Error near IL_0167: Member reference must be method, but was: Field*/;
						case 11:
							return;
						case 3:
							_003C_003Ec._002Ecctor();
							/*Error near IL_01bb: Member reference must be method, but was: Field*/;
						case 7:
							obj = 0;
							_003C_003Et__builder = (AsyncTaskMethodBuilder<EntityGameResourceInfo[]>)0;
							num = 0;
							if (((_003CGetGameResourceInfos_003Ed__22*)(nint)_003CGetGameResourceInfos_003Ed__22._003C_003E4__this)->gameId != null)
							{
								num = 6;
							}
							continue;
						case 9:
							goto IL_02fa;
						}
						break;
					}
					goto IL_013e;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 䀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778411, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 䄀(object P_0)
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
					_ = ref _003C_003Ec._003C_003E9;
					_ = ((AsyncTaskMethodBuilder*)P_0)->Task;
					_ = 0;
					if (_003C_003Ec__DisplayClass19_0.CheckRemoteExplorer == null)
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
	private struct _003CGetNetGameAddressAsync_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityNetGameAddress> _003C_003Et__builder;

		public MobileSession _003C_003E4__this;

		public string gameId;

		private TaskAwaiter<EntityNetGameAddress> _003C_003Eu__1;

		internal static object GuideRequester;

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
		internal static bool CheckMonoRecommender()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PatchEvent()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 䈀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778410, new IntPtr(2737336620876L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 䌀()
		{
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return _003C_003Ec._003C_003E9;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 䐀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778409, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 䔀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778408, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 䘀()
		{
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (_003C_003Ec._003C_003E9 == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 䜀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778415, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 䤀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778414, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 䨀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0051: Expected Obj, but got I4
			//IL_0051: Expected Obj, but got Ref
			//IL_0061: Expected Obj, but got Ref
			//IL_01d6: Expected Obj, but got VT
			//IL_019b: Expected Obj, but got Ref
			//IL_019b: Expected Obj, but got Ref
			//IL_01a5: Expected native int or pointer, but got Obj
			//IL_01f6: Expected native int or pointer, but got Obj
			//IL_01bf: Expected Obj, but got I4
			//IL_0100: Expected Obj, but got I4
			//IL_0105: Expected Obj, but got I4
			//IL_010f: Expected native int or pointer, but got Obj
			//IL_016e: Expected VT, but got Obj
			//IL_0178: Expected native int or pointer, but got Obj
			//IL_005b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0077->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ab->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0082->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01af->IL00c1: Incompatible stack heights: 2 vs 1
			//IL_01ba->IL00c1: Incompatible stack heights: 2 vs 1
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
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
				case 5:
					return;
				case 1:
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(-2);
					obj2 = 2;
					break;
				case 3:
					obj = _003C_003Ec._003C_003E9__15_0;
					obj2 = 0;
					if (_003C_003Ec__DisplayClass19_0.CheckRemoteExplorer != null)
					{
						obj2 = 0;
					}
					break;
				case 2:
					_ = ref ((_003CEntitiesRequestAsync_003Ed__9<>)this)._003C_003E1__state;
					/*Error near IL_008a: Member reference must be method, but was: Field*/;
				case 4:
					obj = ((_003CEntitiesRequestAsync_003Ed__9<>)this)._003C_003E4__this;
					obj2 = 3;
					break;
				default:
					{
						if (obj != null)
						{
							num = 6;
							goto IL_00c1;
						}
						goto IL_01ce;
					}
					IL_01ce:
					obj = ((_003CEntityRequestAsync_003Ed__8<>)this)._003C_003Eu__1;
					num = 2;
					goto IL_00c1;
					IL_00c1:
					while (true)
					{
						switch (num)
						{
						default:
							return;
						case 0:
							return;
						case 5:
							break;
						case 7:
							obj = 0;
							((_003CEntitiesRequestAsync_003Ed__9<>)this).url = (string)0;
							num = 3;
							if (!((_003CEntitiesRequestAsync_003Ed__9<>*)(nint)_003CEntitiesRequestAsync_003Ed__9<>.body)->checkCode)
							{
								num = 10;
							}
							continue;
						case 4:
						case 11:
							obj = ((AsyncTaskMethodBuilder<_0021_00210>*)(&obj))->Task;
							num = 5;
							continue;
						case 6:
							((MobileSession)obj).GetNetGamesAsync();
							/*Error near IL_013e: Member reference must be method, but was: Field*/;
						case 10:
							((_003CEntityRequestAsync_003Ed__7)this)._003C_003Eu__1 = (TaskAwaiter<object>)obj;
							num = 1;
							if (((_003CEntityRequestAsync_003Ed__8<>*)(nint)_003CEntityRequestAsync_003Ed__7.CheckGroupedEmitter)->_003C_003E1__state != 0)
							{
								num = 1;
							}
							continue;
						case 1:
							((MobileSession)/*Error near IL_019b: Stack underflow*/).EntityRequestAsync<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails>((string)Unsafe.AsPointer(ref ((_003CEntityRequestAsync_003Ed__8<>)this)._003C_003Et__builder), (object)(&obj), (byte)Unsafe.AsPointer(ref this) != 0);
							_ = 0;
							if (((_003CEntityRequestAsync_003Ed__8<>*)(nint)_003CEntityRequestAsync_003Ed__8<>.url)->body == null)
							{
								_ = 0;
							}
							continue;
						case 3:
							obj = -1;
							((_003CEntityRequestAsync_003Ed__8<>)this).checkCode = true;
							num = 4;
							continue;
						case 8:
							goto IL_01ce;
						case 2:
							Unsafe.As<int, TaskAwaiter<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails>>(ref ((_003CGetGameResourceInfos_003Ed__22)this)._003C_003E1__state) = default;
							num = 3;
							if (((_003CGetGameResourceInfos_003Ed__22*)(nint)_003CGetGameResourceInfos_003Ed__22._003C_003E4__this)->gameId == null)
							{
								num = 3;
							}
							continue;
						case 9:
							_ = ref obj;
							/*Error near IL_020d: Member reference must be method, but was: Field*/;
						}
						break;
					}
					goto case 1;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 䬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778413, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 䰀(object P_0)
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
					_ = ref _003C_003Ec._003C_003E9;
					_ = ((AsyncTaskMethodBuilder*)P_0)->Task;
					_ = 0;
					if (_003C_003Ec__DisplayClass19_0.CheckRemoteExplorer == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 䴀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778412, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetNetGameDetailsAsync_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails> _003C_003Et__builder;

		public MobileSession _003C_003E4__this;

		public string gameId;

		private TaskAwaiter<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails> _003C_003Eu__1;

		private static object AttachWrapper;

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
		internal static bool DecorateScopeNotifier()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectStaticDispatcher()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 一()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778419, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 伀()
		{
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return _003C_003Ec._003C_003E9;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 倀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778418, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 儀()
		{
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (_003C_003Ec._003C_003E9 == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 匀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0316: Expected Obj, but got VT
			//IL_02ef: Expected Obj, but got VT
			//IL_02f9: Expected native int or pointer, but got Obj
			//IL_02b0: Expected Obj, but got I4
			//IL_0141: Expected Obj, but got VT
			//IL_0113: Expected Obj, but got I4
			//IL_0118: Expected Obj, but got I4
			//IL_01a4: Expected Obj, but got I4
			//IL_00b5: Expected Obj, but got Ref
			//IL_00bf: Expected native int or pointer, but got Obj
			//IL_0172: Expected native int or pointer, but got Obj
			//IL_0195: Expected Obj, but got Ref
			//IL_0195: Expected Obj, but got Ref
			//IL_02e6->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0320->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0303->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02c4->IL0026: Incompatible stack types: I4 vs Obj
			//IL_030e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02cf->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0155->IL0073: Incompatible stack heights: 2 vs 1
			//IL_019f->IL0073: Incompatible stack heights: 2 vs 1
			//IL_0160->IL0073: Incompatible stack heights: 2 vs 1
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 5:
					if (obj == null)
					{
						int num = 5;
						if (_003C_003Ec._003C_003E9__15_0 != null)
						{
							num = 5;
						}
						while (true)
						{
							switch (num)
							{
							case 7:
								((_003C_003Ec__DisplayClass19_0)Unsafe.AsPointer(ref this)).gameId = (string)obj;
								num = 2;
								if (((_003CEntitiesRequestAsync_003Ed__9<>*)(nint)_003C_003Ec__DisplayClass19_0.CheckRemoteExplorer)->_003C_003E1__state != 0)
								{
									num = 10;
								}
								continue;
							case 11:
								_ = ref obj;
								/*Error near IL_00d6: Member reference must be method, but was: Field*/;
							case 6:
								return;
							case 3:
								obj = 0;
								((_003CEntitiesRequestAsync_003Ed__9<>)this).body = 0;
								num = 7;
								continue;
							case 1:
								Unsafe.As<bool, AsyncTaskMethodBuilder<EntityGameResourceInfo[]>>(ref ((_003CEntitiesRequestAsync_003Ed__9<>)this).checkCode) = default;
								num = 4;
								continue;
							case 2:
								_ = ref obj;
								obj = AsyncTaskMethodBuilder<_0021_00210[]>.Create();
								_ = 0;
								if (((_003CEntityRequestAsync_003Ed__7)_003CEntityRequestAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
								{
									_ = 0;
								}
								continue;
							case 5:
							case 9:
								obj = ((_003CEntityRequestAsync_003Ed__7)this).url;
								num = 1;
								if (!((_003CEntityRequestAsync_003Ed__7*)(nint)_003CEntityRequestAsync_003Ed__7.body)->checkCode)
								{
									num = 0;
								}
								continue;
							case 10:
								((MobileSession)/*Error near IL_0195: Stack underflow*/).EntityRequestAsync<EntityNetGameAddress>((string)Unsafe.AsPointer(ref ((_003CEntityRequestAsync_003Ed__7)this)._003C_003Eu__1), (object)(&obj), (byte)Unsafe.AsPointer(ref this) != 0);
								_ = 6;
								continue;
							case 4:
								obj = -1;
								((_003CEntityRequestAsync_003Ed__8<>)this)._003C_003E1__state = -1;
								num = 2;
								continue;
							case 8:
								break;
							default:
								goto IL_02a8;
							}
							break;
						}
					}
					ReflectAttachedEncryptor();
					/*Error near IL_01ba: Member reference must be method, but was: Field*/;
				case 4:
					goto IL_02a8;
				default:
					Unsafe.As<MobileSession, AsyncTaskMethodBuilder<EntityRentalGameAddress>>(ref _003C_003E4__this).Start<TStateMachine>(ref *(TStateMachine*)obj);
					obj2 = 3;
					break;
				case 3:
					return;
				case 2:
					obj = _003C_003Eu__1;
					obj2 = 1;
					if (((_003CGetNetGamesAsync_003Ed__15*)(nint)AttachWrapper)->_003C_003E1__state == 0)
					{
						obj2 = 1;
					}
					break;
				case 1:
					{
						obj = ((_003CGetNetGamesAsync_003Ed__15)this)._003C_003Et__builder;
						obj2 = 5;
						break;
					}
					IL_02a8:
					_003CGetNetGameAddressAsync_003Ed__21.GuideRequester = -2;
					obj2 = 0;
					if ((int)((_003CGetNetGameDetailsAsync_003Ed__20*)_003CGetNetGameDetailsAsync_003Ed__20._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj2 = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 吀(object P_0)
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
					_ = ref _003C_003Ec._003C_003E9;
					_ = ((AsyncTaskMethodBuilder*)P_0)->Task;
					_ = 0;
					if (_003C_003Ec__DisplayClass19_0.CheckRemoteExplorer == null)
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
	private struct _003CGetNetGamesAsync_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem[]> _003C_003Et__builder;

		public MobileSession _003C_003E4__this;

		private TaskAwaiter<EntityNetGames> _003C_003Eu__1;

		internal static object DecorateDynamicSingleton;

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
		internal static bool ReflectConcreteParser()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateConnectedState()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 唀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778417, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 嘀()
		{
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return _003C_003Ec._003C_003E9;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 圀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778416, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 堀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778423, new IntPtr(2737336636476L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 夀()
		{
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (_003C_003Ec._003C_003E9 == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 娀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778422, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 尀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0076: Expected Obj, but got Ref
			//IL_004f: Expected Obj, but got Ref
			//IL_03f7: Expected Obj, but got I4
			//IL_00fb: Expected Obj, but got VT
			//IL_02b7: Expected native int or pointer, but got Obj
			//IL_01d7: Expected native int or pointer, but got Obj
			//IL_01de: Expected Obj, but got VT
			//IL_01e8: Expected native int or pointer, but got Obj
			//IL_0194: Expected native int or pointer, but got Obj
			//IL_015f: Expected VT, but got Obj
			//IL_01c2: Expected Obj, but got I4
			//IL_01d0: Expected Obj, but got I4
			//IL_025e: Expected native int or pointer, but got Obj
			//IL_026e: Expected Obj, but got I4
			//IL_0124: Expected Obj, but got I4
			//IL_0129: Expected Obj, but got I4
			//IL_028b: Expected native int or pointer, but got Obj
			//IL_02a7: Expected Obj, but got Ref
			//IL_01a8: Expected native int or pointer, but got Obj
			//IL_02e8: Expected Ref, but got VT
			//IL_02ed: Expected Ref, but got VT
			//IL_02f2: Expected VT, but got Obj
			//IL_02fc: Expected native int or pointer, but got Obj
			//IL_00ee: Expected I4, but got Obj
			//IL_03e4->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0065->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0401->IL0026: Incompatible stack types: I4 vs Obj
			//IL_03ef->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0105->IL00a1: Incompatible stack types: I4 vs Obj
			//IL_009d->IL00a1: Incompatible stack types: I4 vs Obj
			//IL_01f2->IL00a1: Incompatible stack types: I4 vs Obj
			//IL_0169->IL00a1: Incompatible stack types: I4 vs Obj
			//IL_0133->IL00a1: Incompatible stack types: I4 vs Obj
			//IL_0295->IL00a1: Incompatible stack types: I4 vs Obj
			//IL_0192->IL00a1: Incompatible stack types: I4 vs Obj
			//IL_02b3->IL00a1: Incompatible stack types: I4 vs Obj
			//IL_02cc->IL02e3: Incompatible stack heights: 3 vs 5
			//IL_01fd->IL00a1: Incompatible stack types: I4 vs Obj
			//IL_01b2->IL00a1: Incompatible stack types: I4 vs Obj
			//IL_02a0->IL00a1: Incompatible stack types: I4 vs Obj
			//IL_0306->IL00a1: Incompatible stack types: I4 vs Obj
			//IL_01bd->IL00a1: Incompatible stack types: I4 vs Obj
			//IL_0311->IL00a1: Incompatible stack types: I4 vs Obj
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
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
				case 5:
					return;
				case 2:
					awaiter = _003C_003Ec._003C_003E9;
					obj = 4;
					if (((_003C_003Ec__DisplayClass19_0)(object)_003C_003Ec._003C_003E9__15_0).gameId == null)
					{
						obj = 1;
					}
					break;
				default:
					_ = ref _003C_003Ec__DisplayClass19_0.CheckRemoteExplorer;
					/*Error near IL_0078: Member reference must be method, but was: Field*/;
				case 4:
					if (awaiter != null)
					{
						obj2 = 3;
						goto IL_00a1;
					}
					goto IL_00f3;
				case 1:
					goto IL_03c8;
				case 3:
					{
						awaiter = ((_003CGetRentalGamesAsync_003Ed__17)this).offset;
						obj = 2;
						break;
					}
					IL_00f3:
					awaiter = ((_003CEntitiesRequestAsync_003Ed__9<>)this)._003C_003Et__builder;
					obj2 = 14;
					goto IL_00a1;
					IL_00a1:
					while (true)
					{
						switch ((int)obj2)
						{
						default:
							return;
						case 0:
							return;
						case 15:
							break;
						case 7:
							_ = ref awaiter;
							/*Error near IL_0107: Member reference must be method, but was: Field*/;
						case 11:
							awaiter = 0;
							((_003CEntitiesRequestAsync_003Ed__9<>)this).url = (string)0;
							obj2 = 4;
							continue;
						case 4:
							((_003CEntitiesRequestAsync_003Ed__9<>)this)._003C_003Eu__1 = (TaskAwaiter<Entities<T>>)awaiter;
							obj2 = 13;
							continue;
						case 14:
							Unsafe.As<int, AsyncTaskMethodBuilder<_00210[]>>(ref ((_003CEntityRequestAsync_003Ed__7)this)._003C_003E1__state) = default;
							obj2 = 9;
							continue;
						case 3:
							if (((_003CEntityRequestAsync_003Ed__7*)(nint)awaiter)->_003C_003E4__this == null)
							{
								obj2 = 12;
								if (((_003CEntityRequestAsync_003Ed__7*)(nint)_003CEntityRequestAsync_003Ed__7.url)->body == null)
								{
									obj2 = 3;
								}
								continue;
							}
							goto case 10;
						case 9:
							awaiter = -1;
							((_003CEntityRequestAsync_003Ed__7)this).checkCode = true;
							awaiter = 16;
							goto IL_009d;
						case 2:
							awaiter = ((_003CEntityRequestAsync_003Ed__7*)(nint)awaiter)->_003C_003Eu__1;
							obj2 = 8;
							if (((_003CEntityRequestAsync_003Ed__8<>*)(nint)_003CEntityRequestAsync_003Ed__7.CheckGroupedEmitter)->_003C_003E1__state != 0)
							{
								obj2 = 7;
							}
							continue;
						case 5:
						case 12:
							ReflectAttachedEncryptor();
							/*Error near IL_0213: Member reference must be method, but was: Field*/;
						case 6:
							/*Error near IL_0233: Member reference must be method, but was: Field*/;
						case 10:
							awaiter = ((_003CGetGameResourceInfos_003Ed__22*)(nint)awaiter)->_003C_003E4__this;
							awaiter = 17;
							goto IL_009d;
						case 13:
							Unsafe.As<string, AsyncTaskMethodBuilder<_00210>>(ref ((_003CGetGameResourceInfos_003Ed__22)this).gameId).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<_00210>*)(&awaiter), ref Unsafe.As<_003CGetNetGamesAsync_003Ed__15, _003CRequestAsync_003Ed__10<_00210>>(ref this));
							obj2 = 0;
							if (((_003CGetNetGameAddressAsync_003Ed__21*)(nint)_003CGetGameResourceInfos_003Ed__22.DecorateLocalAggregator)->_003C_003E1__state != 0)
							{
								obj2 = 0;
							}
							continue;
						case 16:
							((NotSupportedException)/*Error near IL_02a7: Stack underflow*/)._002Ector((string?)(&awaiter));
							awaiter = (object)/*Error near IL_02a9: Stack underflow*/;
							obj2 = 6;
							continue;
						case 1:
						{
							object obj3 = awaiter;
							MobileSession mobileSession = ((_003CGetNetGameAddressAsync_003Ed__21*)(nint)awaiter)->_003C_003E4__this;
							TaskAwaiter<EntityNetGameAddress> taskAwaiter;
							AsyncTaskMethodBuilder<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails> asyncTaskMethodBuilder;
							if (_003CGetNetGameAddressAsync_003Ed__21.gameId == null)
							{
								taskAwaiter = _003CGetNetGameAddressAsync_003Ed__21._003C_003Eu__1;
								asyncTaskMethodBuilder = (_003CGetNetGameDetailsAsync_003Ed__20._003C_003Et__builder = (AsyncTaskMethodBuilder<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails>)new AsyncTaskMethodBuilder<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]>());
							}
							((AsyncTaskMethodBuilder<MobileSession>*)__ldftn(_003CEntityRequestAsync_003Ed__8<>.SetStateMachine))->Start(ref *(NeteaseMobile._003CLoginAsync_003Ed__14*)asyncTaskMethodBuilder);
							((AsyncTaskMethodBuilder<EntityAuthenticationOtp>*)mobileSession)->Start(ref *(NeteaseMobile._003CPeAuthenticationAsync_003Ed__15*)taskAwaiter);
							Unsafe.Write(&((_003CGetNetGameDetailsAsync_003Ed__20*)(nint)/*Error near IL_02f2: Stack underflow*/)->_003C_003Eu__1, (TaskAwaiter<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails>)obj3);
							obj2 = 0;
							if (((_003CGetNetGamesAsync_003Ed__15*)(nint)_003CGetNetGameDetailsAsync_003Ed__20.AttachWrapper)->_003C_003E1__state != 0)
							{
								obj2 = 2;
							}
							continue;
						}
						case 8:
						case 17:
							goto IL_03c8;
							IL_009d:
							obj2 = awaiter;
							continue;
						}
						break;
					}
					goto IL_00f3;
					IL_03c8:
					((_003CGetRentalGamesAsync_003Ed__17)this)._003C_003E1__state = -2;
					obj = 0;
					if (((_003CGetRentalGamesAsync_003Ed__17)_003CGetRentalGamesAsync_003Ed__17._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 崀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778421, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 帀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778420, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 开(object P_0)
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
					_ = ref _003C_003Ec._003C_003E9;
					_ = ((AsyncTaskMethodBuilder*)P_0)->Task;
					_ = 0;
					if (_003C_003Ec__DisplayClass19_0.CheckRemoteExplorer == null)
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
	private struct _003CGetRentalGameAddressAsync_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityRentalGameAddress> _003C_003Et__builder;

		public MobileSession _003C_003E4__this;

		public string gameId;

		public string password;

		private TaskAwaiter<EntityRentalGameAddress> _003C_003Eu__1;

		internal static object StoreComparator;

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
		internal static bool VerifyBridge()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckLogicalReporter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 怀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778427, new IntPtr(2737336618796L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 愀()
		{
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return _003C_003Ec._003C_003E9;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 戀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778426, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 挀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778425, new IntPtr(2737336618796L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 搀()
		{
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (_003C_003Ec._003C_003E9 == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 攀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778424, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 最()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778431, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 栀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_004e: Expected Obj, but got Ref
			//IL_0343: Expected Obj, but got VT
			//IL_034d: Expected native int or pointer, but got Obj
			//IL_02ef: Expected Obj, but got I4
			//IL_0326: Expected native int or pointer, but got Obj
			//IL_01ce: Expected Obj, but got VT
			//IL_01d8: Expected native int or pointer, but got Obj
			//IL_01b3: Expected Obj, but got I4
			//IL_01c1: Expected Obj, but got I4
			//IL_010d: Expected native int or pointer, but got Obj
			//IL_00c4: Expected Obj, but got I4
			//IL_00c9: Expected Obj, but got I4
			//IL_00c9: Expected Obj, but got Ref
			//IL_0174: Expected native int or pointer, but got Obj
			//IL_00ba: Expected I4, but got Obj
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0357->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0303->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0330->IL0026: Incompatible stack heights: 4 vs 1
			//IL_0362->IL0026: Incompatible stack types: I4 vs Obj
			//IL_030e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_033b->IL0026: Incompatible stack heights: 4 vs 1
			//IL_01e2->IL0085: Incompatible stack types: I4 vs Obj
			//IL_0076->IL0085: Incompatible stack types: I4 vs Obj
			//IL_01ed->IL0085: Incompatible stack types: I4 vs Obj
			//IL_0081->IL0085: Incompatible stack types: I4 vs Obj
			//IL_01ae->IL0085: Incompatible stack types: I4 vs Obj
			//IL_0117->IL0085: Incompatible stack types: I4 vs Obj
			//IL_00d3->IL0085: Incompatible stack types: I4 vs Obj
			//IL_017e->IL0085: Incompatible stack types: I4 vs Obj
			//IL_0151->IL0085: Incompatible stack types: I4 vs Obj
			//IL_0122->IL0085: Incompatible stack types: I4 vs Obj
			//IL_0189->IL0085: Incompatible stack types: I4 vs Obj
			//IL_015c->IL0085: Incompatible stack types: I4 vs Obj
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
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
				default:
					awaiter = _003C_003Ec._003C_003E9;
					obj = 5;
					break;
				case 5:
					if (awaiter != null)
					{
						obj2 = 1;
						if (((_003C_003Ec__DisplayClass19_0)(object)_003C_003Ec._003C_003E9__15_0).gameId == null)
						{
							obj2 = 1;
						}
						goto IL_0085;
					}
					goto IL_01c6;
				case 2:
					goto IL_02e7;
				case 4:
					return;
				case 3:
					_ = ref ((_003CGetNetGamesAsync_003Ed__15)this)._003C_003E4__this;
					AsyncTaskMethodBuilder<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails>.Create();
					_ = 4;
					if (((_003CGetRentalGameAddressAsync_003Ed__18*)(nint)_003CGetNetGamesAsync_003Ed__15.DecorateDynamicSingleton)->_003C_003E1__state != 0)
					{
						_ = 1;
					}
					break;
				case 1:
					{
						awaiter = _003C_003Et__builder;
						obj = 0;
						if (((_003CGetRentalGameAddressAsync_003Ed__18*)(nint)_003CGetRentalGameAddressAsync_003Ed__18._003C_003E4__this)->gameId != null)
						{
							obj = 0;
						}
						break;
					}
					IL_01c6:
					awaiter = ((_003CEntityRequestAsync_003Ed__8<>)this)._003C_003Et__builder;
					obj2 = 6;
					if (((_003CEntityRequestAsync_003Ed__8<>*)(nint)_003CEntityRequestAsync_003Ed__8<>._003C_003E4__this)->url != null)
					{
						obj2 = 3;
					}
					goto IL_0085;
					IL_0085:
					while (true)
					{
						switch ((int)obj2)
						{
						case 8:
							awaiter = -1;
							_003C_003Ec__DisplayClass19_0.CheckRemoteExplorer = (_003C_003Ec__DisplayClass19_0)(-1);
							obj2 = 11;
							continue;
						default:
							_ = ref awaiter;
							/*Error near IL_00d5: Member reference must be method, but was: Field*/;
						case 7:
							((_003CEntitiesRequestAsync_003Ed__9<>)this).url = (string)awaiter;
							obj2 = 9;
							if (!((_003CEntitiesRequestAsync_003Ed__9<>*)(nint)_003CEntitiesRequestAsync_003Ed__9<>.body)->checkCode)
							{
								obj2 = 8;
							}
							continue;
						case 3:
							if (((AsyncTaskMethodBuilder<_0021_00210>*)(&awaiter))->Task != null)
							{
								obj2 = 0;
								if ((int)((_003CEntityRequestAsync_003Ed__7*)_003CEntityRequestAsync_003Ed__7._003C_003E1__state)->_003C_003Et__builder == 0)
								{
									obj2 = 0;
								}
								continue;
							}
							goto case 4;
						case 9:
							Unsafe.As<MobileSession, AsyncTaskMethodBuilder<_00210>>(ref ((_003CEntityRequestAsync_003Ed__7)this)._003C_003E4__this).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<Entity<_00210>>*)(&awaiter), ref Unsafe.As<_003CGetRentalGameAddressAsync_003Ed__18, _003CEntityRequestAsync_003Ed__8<_00210>>(ref this));
							obj2 = 1;
							if (((_003CEntityRequestAsync_003Ed__7*)(nint)_003CEntityRequestAsync_003Ed__7.body)->checkCode)
							{
								obj2 = 2;
							}
							continue;
						case 2:
							return;
						case 6:
							Unsafe.As<TaskAwaiter<object>, TaskAwaiter<Entity<_00210>>>(ref ((_003CEntityRequestAsync_003Ed__7)this)._003C_003Eu__1) = default;
							obj2 = 8;
							continue;
						case 4:
							awaiter = 0;
							((_003CEntityRequestAsync_003Ed__8<>)this)._003C_003E1__state = 0;
							awaiter = 7;
							obj2 = awaiter;
							continue;
						case 5:
							break;
						case 1:
							((_003C_003Ec)/*Error near IL_01f4: Stack underflow*/)._003CGetNetGamesAsync_003Eb__15_0((Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem)awaiter);
							/*Error near IL_01f4: Member reference must be method, but was: Field*/;
						case 10:
							goto IL_02e7;
						}
						break;
					}
					goto IL_01c6;
					IL_02e7:
					_003CGetNetGameDetailsAsync_003Ed__20.AttachWrapper = -2;
					obj = 0;
					if ((int)((_003CGetNetGamesAsync_003Ed__15*)_003CGetNetGamesAsync_003Ed__15._003C_003E1__state)->_003C_003Et__builder != 0)
					{
						obj = 3;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 椀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778430, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 樀(object P_0)
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
					_ = ref _003C_003Ec._003C_003E9;
					_ = ((AsyncTaskMethodBuilder*)P_0)->Task;
					_ = 0;
					if (_003C_003Ec__DisplayClass19_0.CheckRemoteExplorer == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 欀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778429, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetRentalGamesAsync_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> _003C_003Et__builder;

		public MobileSession _003C_003E4__this;

		public int offset;

		private TaskAwaiter<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> _003C_003Eu__1;

		internal static object EncodeConsumer;

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
		internal static bool DecorateControllableEnumerator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TrackSorter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 氀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778428, new IntPtr(2737336636476L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 洀()
		{
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return _003C_003Ec._003C_003E9;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 渀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778435, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 漀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778434, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 瀀()
		{
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (_003C_003Ec._003C_003E9 == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 焀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778433, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 猀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0311: Expected Obj, but got VT
			//IL_031b: Expected native int or pointer, but got Obj
			//IL_02ea: Expected Obj, but got I4
			//IL_0338: Expected VT, but got I4
			//IL_0141: Expected Obj, but got I4
			//IL_017d: Expected Obj, but got I4
			//IL_01a9: Expected I4, but got Obj
			//IL_016e: Expected Obj, but got Ref
			//IL_016e: Expected Obj, but got Ref
			//IL_0099: Expected Obj, but got I4
			//IL_009e: Expected Obj, but got I4
			//IL_009e: Expected Obj, but got Ref
			//IL_0325->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02fe->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0342->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02d6->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0330->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0309->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02e1->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0178->IL005e: Incompatible stack heights: 2 vs 1
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
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
				case 4:
					if (obj != null)
					{
						num = 6;
						goto IL_005e;
					}
					goto IL_0139;
				case 5:
					Unsafe.As<MobileSession, AsyncTaskMethodBuilder<EntityRentalGameAddress>>(ref ((_003CGetNetGameDetailsAsync_003Ed__20)this)._003C_003E4__this).Start<TStateMachine>(ref *(TStateMachine*)obj);
					obj2 = 2;
					if (_003CGetNetGameDetailsAsync_003Ed__20.AttachWrapper == null)
					{
						obj2 = 2;
					}
					continue;
				case 2:
					return;
				case 1:
					obj = ((_003CGetNetGamesAsync_003Ed__15)this)._003C_003E1__state;
					obj2 = 0;
					if (((_003CGetNetGamesAsync_003Ed__15)_003CGetNetGamesAsync_003Ed__15._003C_003Et__builder)._003C_003E4__this != null)
					{
						obj2 = 0;
					}
					continue;
				default:
					obj = ((_003CGetNetGamesAsync_003Ed__15)this)._003C_003Eu__1;
					obj2 = 1;
					if (((_003CGetRentalGameAddressAsync_003Ed__18*)(nint)_003CGetNetGamesAsync_003Ed__15.DecorateDynamicSingleton)->_003C_003E1__state != 0)
					{
						obj2 = 4;
					}
					continue;
				case 3:
					break;
					IL_005e:
					while (true)
					{
						switch (num)
						{
						case 9:
							obj = 0;
							_003C_003Ec._003C_003E9 = (_003C_003Ec)0;
							num = 2;
							continue;
						case 10:
							return;
						case 4:
							_ = ref obj;
							/*Error near IL_00ce: Member reference must be method, but was: Field*/;
						case 8:
							_ = ref obj;
							/*Error near IL_00f9: Member reference must be method, but was: Field*/;
						case 3:
							Unsafe.As<string, AsyncTaskMethodBuilder<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails>>(ref ((_003CEntitiesRequestAsync_003Ed__9<>)this).url) = default;
							num = 0;
							if ((int)((_003CEntitiesRequestAsync_003Ed__9<>*)(_003CEntitiesRequestAsync_003Ed__9<>.checkCode ? 1 : 0))->_003C_003Eu__1 == 0)
							{
								num = 0;
							}
							continue;
						case 1:
							break;
						case 7:
							((MobileSession)/*Error near IL_016e: Stack underflow*/).RequestAsync<Entity<_00210>>((string)Unsafe.AsPointer(ref ((_003CEntityRequestAsync_003Ed__7)this).url), (object)(&obj), (byte)Unsafe.AsPointer(ref this) != 0);
							_ = 10;
							continue;
						default:
							obj = -1;
							((_003CEntityRequestAsync_003Ed__7)this).checkCode = true;
							num = 8;
							if (_003CEntityRequestAsync_003Ed__7.CheckGroupedEmitter == null)
							{
								num = 1;
							}
							continue;
						case 2:
							((_003CEntityRequestAsync_003Ed__8<>)this)._003C_003E1__state = (int)obj;
							num = 7;
							continue;
						case 6:
							ReflectAttachedEncryptor();
							/*Error near IL_01ba: Member reference must be method, but was: Field*/;
						case 5:
							goto end_IL_0026;
						}
						break;
					}
					goto IL_0139;
					IL_0139:
					obj = ((_003CEntityRequestAsync_003Ed__7)this)._003C_003E1__state;
					num = 3;
					if (((_003CEntityRequestAsync_003Ed__7)_003CEntityRequestAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						num = 2;
					}
					goto IL_005e;
					end_IL_0026:
					break;
				}
				((_003CGetRentalGameAddressAsync_003Ed__18)this)._003C_003Et__builder = (AsyncTaskMethodBuilder<EntityRentalGameAddress>)(-2);
				obj2 = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 琀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778432, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 甀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778439, new IntPtr(2737336636476L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 瘀(object P_0)
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
					_ = ref _003C_003Ec._003C_003E9;
					_ = ((AsyncTaskMethodBuilder*)P_0)->Task;
					_ = 0;
					if (_003C_003Ec__DisplayClass19_0.CheckRemoteExplorer == null)
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
	private struct _003CRequestAsync_003Ed__10<T> : IAsyncStateMachine where T : notnull, EntityResponse
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public MobileSession _003C_003E4__this;

		public string url;

		public object body;

		public bool checkCode;

		private TaskAwaiter<T> _003C_003Eu__1;

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

		internal static bool DecorateSortedProfiler()
		{
			return true;
		}

		internal static object DecorateCombinedFactory()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRequestAsync_003Ed__11<T> : IAsyncStateMachine where T : notnull, EntityResponse
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public string url;

		public string body;

		public MobileSession _003C_003E4__this;

		public bool checkCode;

		private TaskAwaiter<RestResponse<T>> _003C_003Eu__1;

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

		internal static bool DecorateSequentialResponder()
		{
			return true;
		}

		internal static object DecorateSetStream()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSearchRentalGamesAsync_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> _003C_003Et__builder;

		public MobileSession _003C_003E4__this;

		public int offset;

		public string keyword;

		private TaskAwaiter<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> _003C_003Eu__1;

		private static object DecorateEfficientEncryptor;

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
		internal static bool CloseAggregator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CreateTag()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 簀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778438, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 紀()
		{
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return _003C_003Ec._003C_003E9;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 縀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778437, new IntPtr(2737336636476L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 缀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778436, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 耀()
		{
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (_003C_003Ec._003C_003E9 == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 舀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_02e5: Expected Obj, but got I4
			//IL_02ef: Expected native int or pointer, but got Obj
			//IL_00ee: Expected Obj, but got I4
			//IL_00f3: Expected VT, but got I4
			//IL_00fd: Expected native int or pointer, but got Obj
			//IL_00c8: Expected Obj, but got I4
			//IL_00cd: Expected Obj, but got I4
			//IL_00cd: Expected Obj, but got Ref
			//IL_00df: Expected I4, but got Obj
			//IL_00b7: Expected Obj, but got Ref
			//IL_0343->IL0026: Incompatible stack heights: 4 vs 1
			//IL_0321->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02d2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02f9->IL0026: Incompatible stack types: I4 vs Obj
			//IL_032c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02dd->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0304->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0134->IL0073: Incompatible stack heights: 2 vs 1
			//IL_013f->IL0073: Incompatible stack heights: 2 vs 1
			((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
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
					if (obj == null)
					{
						int num = 0;
						if (_003C_003Ec._003C_003E9__15_0 == null)
						{
							num = 0;
						}
						while (true)
						{
							switch (num)
							{
							default:
								obj = ((_003C_003Ec__DisplayClass19_0)Unsafe.AsPointer(ref this)).gameId;
								num = 5;
								continue;
							case 6:
								obj = -1;
								_003C_003Ec__DisplayClass19_0.CheckRemoteExplorer = (_003C_003Ec__DisplayClass19_0)(-1);
								num = 7;
								continue;
							case 9:
								((_003CEntitiesRequestAsync_003Ed__9<>)this)._003C_003E1__state = (int)obj;
								num = 3;
								continue;
							case 1:
								obj = 0;
								((_003CEntitiesRequestAsync_003Ed__9<>)this)._003C_003Et__builder = (AsyncTaskMethodBuilder<T[]>)0;
								num = 9;
								if (((_003CEntitiesRequestAsync_003Ed__9<>*)(nint)_003CEntitiesRequestAsync_003Ed__9<>._003C_003E4__this)->url == null)
								{
									num = 8;
								}
								continue;
							case 3:
								_ = ref ((_003CEntitiesRequestAsync_003Ed__9<>)this).body;
								((AsyncTaskMethodBuilder<EntityGameResourceInfo[]>*)(&obj))->Start(ref Unsafe.As<_003CSearchRentalGamesAsync_003Ed__16, _003CGetGameResourceInfos_003Ed__22>(ref this));
								_ = 12;
								if (((_003CEntityRequestAsync_003Ed__7)_003CEntitiesRequestAsync_003Ed__9<>._003C_003Eu__1)._003C_003E1__state != 0)
								{
									_ = 5;
								}
								continue;
							case 12:
								return;
							case 5:
								Unsafe.As<bool, @null>(ref ((_003CEntityRequestAsync_003Ed__7)this).checkCode) = null;
								num = 6;
								continue;
							case 11:
								break;
							case 2:
								_ = ref obj;
								/*Error near IL_01e9: Member reference must be method, but was: Field*/;
							case 7:
							case 8:
								_ = ref obj;
								/*Error near IL_0203: Member reference must be method, but was: Field*/;
							case 4:
								goto IL_02dd;
							}
							break;
						}
					}
					((MobileSession)/*Error near IL_01b3: Stack underflow*/).GetGameResourceInfos((string)obj);
					new AsyncTaskMethodBuilder<_0021_00210[]>();
					_ = ((_003CEntityRequestAsync_003Ed__8<>)this)._003C_003Et__builder;
					/*Error near IL_01bf: Member reference must be method, but was: Field*/;
				case 3:
					obj = _003CGetNetGameAddressAsync_003Ed__21.GuideRequester;
					obj2 = 2;
					if ((int)((_003CGetNetGameDetailsAsync_003Ed__20*)_003CGetNetGameDetailsAsync_003Ed__20._003C_003E1__state)->_003C_003Et__builder != 0)
					{
						obj2 = 2;
					}
					break;
				case 4:
					goto IL_02dd;
				case 5:
					return;
				case 2:
					obj = _003CGetNetGameDetailsAsync_003Ed__20.AttachWrapper;
					obj2 = 0;
					if ((int)((_003CGetNetGamesAsync_003Ed__15*)_003CGetNetGamesAsync_003Ed__15._003C_003E1__state)->_003C_003Et__builder != 0)
					{
						obj2 = 0;
					}
					break;
				case 1:
					{
						_ = ref ((_003CGetNetGamesAsync_003Ed__15)this)._003C_003E4__this;
						AsyncTaskMethodBuilder<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails>.Create();
						_ = 5;
						break;
					}
					IL_02dd:
					((_003CGetNetGameDetailsAsync_003Ed__20)this)._003C_003E4__this = (MobileSession)(-2);
					obj2 = 1;
					if ((int)((_003CGetNetGameDetailsAsync_003Ed__20*)(nint)_003CGetNetGameDetailsAsync_003Ed__20.gameId)->_003C_003Eu__1 == 0)
					{
						obj2 = 1;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 茀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778443, new IntPtr(2737336636476L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 萀(object P_0)
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
					_ = ref _003C_003Ec._003C_003E9;
					_ = ((AsyncTaskMethodBuilder*)P_0)->Task;
					_ = 0;
					if (_003C_003Ec__DisplayClass19_0.CheckRemoteExplorer != null)
					{
						_ = 0;
					}
					break;
				}
			}
		}
	}

	[CompilerGenerated]
	private readonly object PatchInfo__BackingField;

	private object? _netGames;

	private static object ConcatFilter;

	public required EntityPatchInfo PatchInfo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (EntityPatchInfo)Ԁ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			Ḁ(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe MobileSession(string userId, string token, bool startHeartbeat = true)
	{
		((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		AsyncTaskMethodBuilder.Create();
		int num = 0;
		if (((_003C_003Ec__DisplayClass19_0)(object)_003C_003Ec._003C_003E9__15_0).gameId == null)
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
	public override void Dispose()
	{
		ᘀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CEntityRequestAsync_003Ed__7))]
	private object EntityRequestAsync(object url, object body, byte checkCode = 1)
	{
		return ጀ(url, body, checkCode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CEntityRequestAsync_003Ed__8<>))]
	private Task<T> EntityRequestAsync<T>(string url, object body, bool checkCode = true)
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CEntitiesRequestAsync_003Ed__9<>))]
	private Task<T[]> EntitiesRequestAsync<T>(string url, object body, bool checkCode = true)
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRequestAsync_003Ed__10<>))]
	private Task<T> RequestAsync<T>(string url, object body, bool checkCode = true) where T : EntityResponse
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRequestAsync_003Ed__11<>))]
	private Task<T> RequestAsync<T>(string url, string body, bool checkCode) where T : EntityResponse
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task InterLoginStartAsync()
	{
		return (Task)_0A00();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task InterStartAsync(string gameId)
	{
		return (Task)ࠀ(gameId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task<EntitySkinSetting[]> SetSkinAsync(string itemId)
	{
		return _0300(itemId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetNetGamesAsync_003Ed__15))]
	public new Task<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem[]> GetNetGamesAsync()
	{
		return _2400();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSearchRentalGamesAsync_003Ed__16))]
	public Task<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> SearchRentalGamesAsync(string keyword, int offset = 0)
	{
		return ᄀ(keyword, (uint)offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetRentalGamesAsync_003Ed__17))]
	public Task<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> GetRentalGamesAsync(int offset = 0)
	{
		return _0C00((uint)offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetRentalGameAddressAsync_003Ed__18))]
	public new Task<EntityRentalGameAddress> GetRentalGameAddressAsync(string gameId, string? password = null)
	{
		return _0E00(gameId, password);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public new SessionContext<MobileSession, Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem> GetNetGame(string gameId)
	{
		return _2200(gameId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetNetGameDetailsAsync_003Ed__20))]
	public new Task<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails> GetNetGameDetailsAsync(string gameId)
	{
		return _1B00(gameId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetNetGameAddressAsync_003Ed__21))]
	public new Task<EntityNetGameAddress> GetNetGameAddressAsync(string gameId)
	{
		return ༀ(gameId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetGameResourceInfos_003Ed__22))]
	public Task<EntityGameResourceInfo[]> GetGameResourceInfos(string gameId)
	{
		return _1800(gameId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateEfficientStream()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MobileSession ReflectAttachedEncryptor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntitySkinSetting[]> Ȁ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778369, new IntPtr(2737336620876L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntitySkinSetting[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntitySkinSetting[]> _0300(object P_0)
	{
		((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((MobileSession)/*Error near IL_0019: Stack underflow*/).Ԁ();
		throw new AsyncTaskMethodBuilder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntitySkinSetting[]> Ѐ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778368, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntitySkinSetting[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object Ԁ()
	{
		((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return _003C_003Ec._003C_003E9;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _0600()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778375, new IntPtr(2737336634396L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _0700(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778374, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object ࠀ(object P_0)
	{
		//IL_001a: Expected Obj, but got VT
		((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _0900(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778373, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _0A00()
	{
		//IL_001a: Expected Obj, but got VT
		((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> _0B00(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778372, new IntPtr(2737336634396L), 15))(null, 0, new IntPtr(0L));
		return (Task<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> _0C00(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0050: Expected Obj, but got Ref
		//IL_0091: Expected native int or pointer, but got Obj
		//IL_006f: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got Ref
		//IL_00d9: Expected VT, but got I4
		//IL_00e3: Expected native int or pointer, but got Obj
		//IL_0061: Expected Obj, but got Ref
		//IL_0067: Expected Obj, but got VT
		//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0079->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ed->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f8->IL0026: Incompatible stack types: I4 vs Obj
		((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
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
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)this;
				obj = 3;
				break;
			case 5:
				_ = ref _003C_003Ec._003C_003E9__15_0;
				return (Task<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]>)AsyncTaskMethodBuilder<_0021_00210>.Create();
			case 3:
				_003C_003Ec__DisplayClass19_0.CheckRemoteExplorer = (_003C_003Ec__DisplayClass19_0)P_0;
				obj = 4;
				break;
			case 2:
				((AsyncTaskMethodBuilder<EntityRentalGameAddress>*)(&((_003CEntitiesRequestAsync_003Ed__9<>*)(&stateMachine))->_003C_003E1__state))->Start(ref *(_003CGetRentalGameAddressAsync_003Ed__18*)(&stateMachine));
				obj = 2;
				if (((_003CEntitiesRequestAsync_003Ed__9<>*)(nint)_003CEntitiesRequestAsync_003Ed__9<>._003C_003E4__this)->url == null)
				{
					obj = 5;
				}
				break;
			case 1:
				_ = ref stateMachine;
				/*Error near IL_00a8: Member reference must be method, but was: Field*/;
			case 4:
				((_003CEntityRequestAsync_003Ed__7*)(&stateMachine))->_003C_003Et__builder = (AsyncTaskMethodBuilder)(-1);
				obj = 2;
				if (((_003CEntityRequestAsync_003Ed__7*)(nint)_003CEntityRequestAsync_003Ed__7._003C_003E4__this)->url == null)
				{
					obj = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityRentalGameAddress> _0D00(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778379, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityRentalGameAddress>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityRentalGameAddress> _0E00(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005a: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 222, 1790778378, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 3, 1790778378, new IntPtr(2737336628156L), 15);
		}
		return (Task<EntityRentalGameAddress>)((delegate*<object, object, object, object>)obj)(this, P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityNetGameAddress> ༀ(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 223, 1790778377, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778377, new IntPtr(2737336633356L), 15);
		}
		return (Task<EntityNetGameAddress>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> က(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778376, new IntPtr(2737336616716L), 15))(null, 0, new IntPtr(0L));
		return (Task<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> ᄀ(object P_0, uint P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_0053: Expected Obj, but got Ref
		//IL_00b0: Expected Obj, but got I4
		//IL_0089: Expected VT, but got Obj
		//IL_0093: Expected native int or pointer, but got Obj
		//IL_00f9: Expected native int or pointer, but got Obj
		//IL_0065: Expected Obj, but got VT
		//IL_0065: Expected Obj, but got Ref
		//IL_00ba->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00dc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0081->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0103->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010e->IL0026: Incompatible stack types: I4 vs Obj
		((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 6;
		object obj = stateMachine;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return (Task<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]>)Unsafe.As<_003C_003Ec, AsyncTaskMethodBuilder>(ref _003C_003Ec._003C_003E9).Task;
			case 6:
				_003C_003Ec__DisplayClass19_0.CheckRemoteExplorer = (_003C_003Ec__DisplayClass19_0)AsyncTaskMethodBuilder<_0021_00210>.Create();
				obj = 5;
				break;
			case 4:
				((_003CEntitiesRequestAsync_003Ed__9<>*)(&stateMachine))->_003C_003E1__state = -1;
				obj = 2;
				break;
			case 3:
				((_003CEntitiesRequestAsync_003Ed__9<>*)(&stateMachine))->_003C_003Et__builder = (AsyncTaskMethodBuilder<T[]>)P_0;
				obj = 1;
				if (((_003CEntitiesRequestAsync_003Ed__9<>*)(nint)_003CEntitiesRequestAsync_003Ed__9<>._003C_003E4__this)->url != null)
				{
					obj = 1;
				}
				break;
			case 1:
				((_003CEntitiesRequestAsync_003Ed__9<>*)(&stateMachine))->body = P_1;
				obj = 4;
				break;
			case 2:
				((AsyncTaskMethodBuilder<_00210[]>*)/*Error near IL_00c8: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<Entities<_00210>>*)(&((_003CEntitiesRequestAsync_003Ed__9<>*)(&stateMachine))->checkCode), ref *(_003CEntitiesRequestAsync_003Ed__9<_00210>*)(&stateMachine));
				obj = 0;
				if ((int)((_003CEntityRequestAsync_003Ed__7*)_003CEntityRequestAsync_003Ed__7._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					obj = 0;
				}
				break;
			case 5:
				((_003CEntityRequestAsync_003Ed__7*)(&stateMachine))->_003C_003E4__this = this;
				obj = 3;
				if (((_003CEntityRequestAsync_003Ed__7*)(nint)_003CEntityRequestAsync_003Ed__7.url)->body == null)
				{
					obj = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object ሀ(object P_0, object P_1, byte P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778383, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object ጀ(object P_0, object P_1, byte P_2)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004b: Expected I4, but got Obj
		//IL_00e5: Expected I4, but got Obj
		//IL_00ee: Expected Obj, but got I4
		//IL_00fb: Expected VT, but got I4
		//IL_0105: Expected native int or pointer, but got Obj
		//IL_0058: Expected Obj, but got Ref
		//IL_00b6: Expected native int or pointer, but got Obj
		//IL_007e: Expected Obj, but got Ref
		//IL_00d3: Expected VT, but got I4
		//IL_010f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0099->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00dd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_011a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0077->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00cb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a4->IL0026: Incompatible stack types: I4 vs Obj
		((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
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
				case 3:
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)this;
					obj = 5;
					if (((_003C_003Ec__DisplayClass19_0)(object)_003C_003Ec._003C_003E9__15_0).gameId == null)
					{
						obj = 1;
					}
					continue;
				case 6:
					Unsafe.As<_003C_003Ec__DisplayClass19_0, AsyncTaskMethodBuilder<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]>>(ref _003C_003Ec__DisplayClass19_0.CheckRemoteExplorer).Start(ref *(_003CGetRentalGamesAsync_003Ed__17*)(&stateMachine));
					obj = 0;
					if (((_003CEntitiesRequestAsync_003Ed__9<>)_003CEntitiesRequestAsync_003Ed__9<>._003C_003Et__builder)._003C_003E4__this != null)
					{
						obj = 1;
					}
					continue;
				case 5:
					((_003CEntitiesRequestAsync_003Ed__9<>*)(&stateMachine))->url = (string)P_0;
					obj = 0;
					if (((_003CEntitiesRequestAsync_003Ed__9<>*)(nint)_003CEntitiesRequestAsync_003Ed__9<>.body)->checkCode)
					{
						obj = 0;
					}
					continue;
				case 7:
					((_003CEntitiesRequestAsync_003Ed__9<>*)(&stateMachine))->_003C_003Eu__1 = (TaskAwaiter<Entities<T>>)(-1);
					obj = 6;
					continue;
				case 2:
					((_003CEntityRequestAsync_003Ed__7*)(&stateMachine))->_003C_003Et__builder = (AsyncTaskMethodBuilder)P_2;
					obj = 7;
					if (((_003CEntityRequestAsync_003Ed__7*)(nint)_003CEntityRequestAsync_003Ed__7._003C_003E4__this)->url != null)
					{
						obj = 7;
					}
					continue;
				case 4:
					_ = ref stateMachine;
					/*Error near IL_011c: Member reference must be method, but was: Field*/;
				case 1:
					_ = ref ((_003CEntityRequestAsync_003Ed__8<>*)(&stateMachine))->_003C_003E1__state;
					/*Error near IL_014c: Member reference must be method, but was: Field*/;
				}
				break;
			}
			((_003CEntityRequestAsync_003Ed__7*)(&stateMachine))->_003C_003E1__state = (int)P_1;
			stateMachine = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _1400(object P_0, object P_1, byte P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778382, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object ᔀ()
	{
		((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return _003C_003Ec._003C_003E9;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void ᘀ()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
		((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
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
				_003C_003Ec._003C_003E9 = null;
				obj2 = 0;
				if (((_003C_003Ec__DisplayClass19_0)(object)_003C_003Ec._003C_003E9__15_0).gameId != null)
				{
					obj2 = 0;
				}
				break;
			default:
				/*Error near IL_0064: Member reference must be method, but was: Field*/;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void ᜀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778381, new IntPtr(2737336634396L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityGameResourceInfo[]> _1800(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 232, 1790778380, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778380, new IntPtr(2737336634396L), 15);
		}
		return (Task<EntityGameResourceInfo[]>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte ᤀ()
	{
		((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (_003C_003Ec._003C_003E9 == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails> ᨀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778387, new IntPtr(2737336635436L), 15))(null, 0, new IntPtr(0L));
		return (Task<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails> _1B00(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 235, 1790778386, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778386, new IntPtr(2737336635436L), 15);
		}
		return (Task<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails> ᰀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778385, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
		return (Task<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void ᴀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778384, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void Ḁ(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		((AsyncTaskMethodBuilder)(*(object*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref MobileSession.PatchInfo__BackingField));
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
				_003C_003Ec._003C_003E9 = (_003C_003Ec)P_0;
				obj2 = 0;
				if (((_003C_003Ec__DisplayClass19_0)(object)_003C_003Ec._003C_003E9__15_0).gameId == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void ἀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778391, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe SessionContext<MobileSession, Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem> _2200(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 242, 1790778390, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778390, new IntPtr(2737336630236L), 15);
		}
		return (SessionContext<MobileSession, Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe SessionContext<MobileSession, Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem> _2300(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778389, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
		return (SessionContext<MobileSession, Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem[]> _2400()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 244, 1790778388, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778388, new IntPtr(2737336616716L), 15);
		}
		return (Task<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem[]>)((delegate*<object, object>)obj)(this);
	}
}
