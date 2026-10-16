using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Mass.Application.Desktop;
using Mass.Common.Extensions;
using Mass.Domain.Desktop.ValueObjects;
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
		private sealed void _F400(object P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (0 == 0)
					{
						_ = 0;
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
		internal static object _F600()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_06a4: Expected Obj, but got Ref
			//IL_06bf: Expected Obj, but got Ref
			//IL_0127: Expected Obj, but got I4
			//IL_03a7: Expected Obj, but got Ref
			//IL_034b: Expected Obj, but got I4
			//IL_04dc: Expected Obj, but got Ref
			//IL_03f6: Expected Obj, but got Ref
			//IL_038b: Expected Obj, but got I4
			//IL_0405: Expected Obj, but got I4
			//IL_043f: Expected Obj, but got I4
			//IL_0687->IL0019: Incompatible stack heights: 2 vs 1
			//IL_06a0->IL0019: Incompatible stack heights: 3 vs 1
			//IL_06b0->IL0019: Incompatible stack heights: 0 vs 1
			//IL_06cb->IL0019: Incompatible stack heights: 0 vs 1
			//IL_06e5->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0692->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0052->IL0056: Incompatible stack types: I4 vs Ref
			//IL_06bb->IL0019: Incompatible stack types: I4 vs Obj
			//IL_06d6->IL0019: Incompatible stack types: I4 vs Obj
			//IL_06f0->IL0019: Incompatible stack heights: 2 vs 1
			//IL_008b->IL009f: Incompatible stack heights: 0 vs 1
			//IL_00ae->IL0056: Incompatible stack heights: 3 vs 1
			//IL_0056->IL0056: Incompatible stack types: Obj vs Ref
			//IL_0184->IL0056: Incompatible stack heights: 0 vs 1
			//IL_015b->IL0056: Incompatible stack heights: 2 vs 1
			//IL_00bd->IL0056: Incompatible stack heights: 0 vs 1
			//IL_0109->IL0056: Incompatible stack heights: 0 vs 1
			//IL_00e9->IL0056: Incompatible stack types: I4 vs Ref
			//IL_01a4->IL01b3: Incompatible stack heights: 0 vs 1
			//IL_018f->IL0056: Incompatible stack types: I4 vs Ref
			//IL_0166->IL0056: Incompatible stack heights: 2 vs 1
			//IL_00c8->IL0056: Incompatible stack types: I4 vs Ref
			//IL_0114->IL0056: Incompatible stack types: I4 vs Ref
			//IL_022f->IL01b3: Incompatible stack types: I4 vs Ref
			//IL_01af->IL01b3: Incompatible stack types: I4 vs Ref
			//IL_01dc->IL01b3: Incompatible stack types: I4 vs Ref
			//IL_01f9->IL01b3: Incompatible stack heights: 5 vs 1
			//IL_0204->IL01b3: Incompatible stack heights: 5 vs 1
			//IL_024e->IL0252: Incompatible stack heights: 1 vs 0
			//IL_03be->IL0252: Incompatible stack heights: 1 vs 0
			//IL_0346->IL0252: Incompatible stack heights: 1 vs 0
			//IL_0386->IL0252: Incompatible stack heights: 3 vs 0
			//IL_02fd->IL0252: Incompatible stack heights: 2 vs 0
			//IL_0469->IL0252: Incompatible stack heights: 3 vs 0
			//IL_0356->IL0252: Incompatible stack heights: 3 vs 0
			//IL_0481->IL0252: Incompatible stack heights: 2 vs 0
			//IL_02e5->IL0252: Incompatible stack heights: 1 vs 0
			//IL_0327->IL0252: Incompatible stack heights: 3 vs 0
			//IL_04e6->IL0252: Incompatible stack heights: 1 vs 0
			//IL_036d->IL0252: Incompatible stack heights: 2 vs 0
			//IL_0400->IL0252: Incompatible stack heights: 1 vs 0
			//IL_0398->IL0252: Incompatible stack heights: 2 vs 0
			//IL_042f->IL0252: Incompatible stack heights: 3 vs 0
			//IL_03cd->IL0252: Incompatible stack heights: 1 vs 0
			//IL_0412->IL0252: Incompatible stack heights: 2 vs 0
			//IL_044c->IL0252: Incompatible stack heights: 2 vs 0
			//IL_03f2->IL0252: Incompatible stack heights: 1 vs 0
			//IL_0493->IL0252: Incompatible stack heights: 1 vs 0
			//IL_0474->IL0252: Incompatible stack heights: 3 vs 0
			//IL_02f0->IL0252: Incompatible stack heights: 1 vs 0
			//IL_02d6->IL0252: Incompatible stack heights: 1 vs 0
			//IL_0378->IL0252: Incompatible stack heights: 2 vs 0
			//IL_03a3->IL0252: Incompatible stack heights: 2 vs 0
			//IL_043a->IL0252: Incompatible stack heights: 3 vs 0
			//IL_03d8->IL0252: Incompatible stack heights: 1 vs 0
			//IL_041d->IL0252: Incompatible stack heights: 2 vs 0
			//IL_0457->IL0252: Incompatible stack heights: 2 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			object obj2 = obj;
			while (true)
			{
				ref _003CHandleAuthentication_003Ed__9 reference;
				switch ((int)obj2)
				{
				case 1:
					if ((nuint)(nint)obj <= (nuint)1u)
					{
						reference = ref *(_003CHandleAuthentication_003Ed__9*)4;
						goto IL_0056;
					}
					goto IL_0114;
				case 3:
					return;
				default:
					if (3 == 0)
					{
						_ = 2;
					}
					break;
				case 2:
					goto IL_0692;
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					if (true)
					{
						obj2 = 0;
					}
					break;
				case 5:
					obj = (object)Unsafe.AsPointer(ref this);
					if (4 == 0)
					{
						obj2 = 0;
					}
					break;
				case 6:
					{
						_ = null;
						if (0 == 0)
						{
							_ = 0;
						}
						break;
					}
					IL_0114:
					if ((nint)obj == 9)
					{
						obj = 9;
						reference = ref *(_003CHandleAuthentication_003Ed__9*)obj;
						goto IL_0056;
					}
					goto IL_00c8;
					IL_009f:
					_ = 5;
					goto IL_0056;
					IL_00c8:
					reference = ref this;
					if (5 != 0)
					{
						if (3 == 0)
						{
							reference = ref *(_003CHandleAuthentication_003Ed__9*)null;
						}
						goto IL_0056;
					}
					goto IL_009f;
					IL_0056:
					while (true)
					{
						ref _003CHandleAuthentication_003Ed__9 reference2;
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 11u:
							break;
						case 9u:
							obj = (object)/*Error near IL_00b1: Stack underflow*/;
							if (false)
							{
								reference = ref *(_003CHandleAuthentication_003Ed__9*)1;
							}
							continue;
						case 6u:
							goto IL_00c8;
						case 4u:
						case 10u:
							if (0 == 0)
							{
								reference = ref *(_003CHandleAuthentication_003Ed__9*)null;
							}
							continue;
						case 2u:
							goto IL_0114;
						case 3u:
						case 7u:
							if (10 == 0)
							{
								_ = 6;
							}
							continue;
						case 5u:
							obj = (object)/*Error near IL_0178: Stack underflow*/;
							if (8 != 0)
							{
								reference = ref *(_003CHandleAuthentication_003Ed__9*)1;
							}
							continue;
						default:
							if ((nuint)(nint)obj <= (nuint)1u)
							{
								if (false)
								{
									reference2 = ref *(_003CHandleAuthentication_003Ed__9*)null;
								}
								goto IL_01b3;
							}
							goto IL_0213;
						case 1u:
						case 8u:
							goto IL_0692;
							IL_03a3:
							obj = (object)Unsafe.AsPointer(ref this);
							if (9 != 0)
							{
								_ = 5;
							}
							goto IL_0252;
							IL_0213:
							reference2 = ref this;
							if (2 != 0)
							{
								reference2 = ref *(_003CHandleAuthentication_003Ed__9*)2;
							}
							goto IL_01b3;
							IL_01b3:
							while (true)
							{
								switch ((uint)Unsafe.AsPointer(ref reference2))
								{
								default:
									reference2 = ref *(_003CHandleAuthentication_003Ed__9*)3;
									continue;
								case 2u:
									if (true)
									{
										_ = 1;
									}
									continue;
								case 4u:
									break;
								case 3u:
									goto IL_022f;
								}
								break;
							}
							goto IL_0213;
							IL_022f:
							if (obj == null)
							{
								if (2 != 0)
								{
									_ = 3;
								}
								goto IL_0252;
							}
							goto IL_0327;
							IL_0252:
							while (true)
							{
								switch ((int)/*Error near IL_02bf: Stack underflow*/)
								{
								case 12:
									if (&obj != null)
									{
										_ = 20;
										continue;
									}
									goto case 25;
								case 9:
									if (7 == 0)
									{
										_ = 4;
									}
									continue;
								case 1:
								case 20:
									_ = ref obj;
									_ = 15;
									continue;
								case 11:
									_ = 5;
									continue;
								case 14:
									break;
								case 7:
									obj = -1;
									_ = 23;
									continue;
								case 15:
									obj = obj;
									if (1 == 0)
									{
										_ = 4;
									}
									continue;
								default:
									_ = 22;
									continue;
								case 18:
									obj = -1;
									if (true)
									{
										_ = 1;
									}
									continue;
								case 6:
									goto IL_03a3;
								case 10:
								case 23:
									_ = ref obj;
									if (true)
									{
										_ = 2;
									}
									continue;
								case 2:
									obj = (object)/*Error near IL_03db: Stack underflow*/;
									if (13 != 0)
									{
										_ = 21;
									}
									continue;
								case 3:
								case 16:
									obj = (object)Unsafe.AsPointer(ref this);
									_ = 8;
									continue;
								case 24:
									obj = 1;
									if (11 == 0)
									{
										_ = 2;
									}
									continue;
								case 22:
									_ = ref obj;
									if (6 != 0)
									{
										_ = 19;
									}
									continue;
								case 25:
									obj = 0;
									if (false)
									{
										_ = 0;
									}
									continue;
								case 5:
									_ = ref obj;
									if (17 == 0)
									{
										_ = 17;
									}
									continue;
								case 8:
									_ = 18;
									continue;
								case 4:
									if (&obj != null)
									{
										_ = 10;
										continue;
									}
									goto case 24;
								case 17:
									return;
								case 19:
									return;
								case 13:
									obj = (object)Unsafe.AsPointer(ref this);
									_ = 12;
									continue;
								case 21:
									goto IL_0692;
								}
								break;
							}
							goto IL_0327;
							IL_0327:
							if ((nint)obj != 1)
							{
								if (2 == 0)
								{
									_ = 13;
								}
								goto IL_0252;
							}
							goto IL_03a3;
						}
						break;
					}
					goto IL_009f;
					IL_0692:
					_ = -2;
					_ = 6;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte ﴀ()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
	public JavaAuthenticator(DesktopSession session, EnumGameType type, string gameId, string gameVersion, string modHashList)
	{
		//IL_005d: Expected I4, but got Obj
		//IL_004b->IL0054: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		JavaAuthenticator javaAuthenticator = this;
		if (0 == 0)
		{
			javaAuthenticator = (JavaAuthenticator)0;
		}
		switch ((int)javaAuthenticator)
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
	private static object _FF00_FF00관()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00글()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778411, new IntPtr(2737337546044L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00꼀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
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
	internal static byte _FF00_FF00대()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00됀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778407, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}
}
