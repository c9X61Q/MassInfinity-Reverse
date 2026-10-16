using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DotNetty.Transport.Channels;
using Mass.Application.Desktop;
using Mass.Application.Models;
using Mass.Common.Extensions;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Domain.Value;
using Mass.Game.Proxy.Minecraft;
using Serilog;

namespace Mass.Game.Proxy;

public class GameProxy : GameInstance
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CListenAsync_003Ed__69 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public GameProxy _003C_003E4__this;

		public int port;

		private TaskAwaiter<IChannel> _003C_003Eu__1;

		private static object CheckCentralResponder;

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
		internal static bool CheckStatelessStream()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LoadDecorator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_2300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778707, new IntPtr(2737367929644L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_2400()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_2500()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778706, new IntPtr(2737367927564L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_2600()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_2700()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778797, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00Ⰰ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778796, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00ⴀ()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_004c: Expected Obj, but got Ref
			//IL_03f6: Expected Obj, but got Ref
			//IL_03ff: Expected Obj, but got I4
			//IL_01bf: Expected Obj, but got Ref
			//IL_0277: Expected Obj, but got I4
			//IL_014f: Expected Obj, but got I4
			//IL_01e9: Expected Obj, but got Ref
			//IL_0255: Expected Obj, but got Ref
			//IL_011a: Expected Obj, but got I4
			//IL_0362: Expected Obj, but got I4
			//IL_0412->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0048->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0058->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0075->IL0079: Incompatible stack heights: 1 vs 0
			//IL_0063->IL0019: Incompatible stack types: I4 vs Obj
			//IL_01d6->IL0079: Incompatible stack heights: 1 vs 0
			//IL_0282->IL0079: Incompatible stack heights: 3 vs 0
			//IL_015c->IL0079: Incompatible stack heights: 2 vs 0
			//IL_01f3->IL0079: Incompatible stack heights: 1 vs 0
			//IL_0178->IL0079: Incompatible stack heights: 2 vs 0
			//IL_012e->IL0079: Incompatible stack heights: 3 vs 0
			//IL_014a->IL0079: Incompatible stack heights: 2 vs 0
			//IL_029a->IL0079: Incompatible stack heights: 5 vs 0
			//IL_0315->IL0079: Incompatible stack heights: 3 vs 0
			//IL_01e4->IL0079: Incompatible stack heights: 3 vs 0
			//IL_013d->IL0079: Incompatible stack heights: 2 vs 0
			//IL_025f->IL0079: Incompatible stack heights: 11 vs 0
			//IL_0167->IL0079: Incompatible stack heights: 2 vs 0
			//IL_033f->IL0079: Incompatible stack heights: 2 vs 0
			//IL_0183->IL0079: Incompatible stack heights: 2 vs 0
			//IL_0320->IL0079: Incompatible stack heights: 3 vs 0
			//IL_0079->IL0079: Incompatible stack heights: 1 vs 0
			//IL_0367->IL0075: Incompatible stack heights: 1 vs 0
			//IL_02d8->IL0079: Incompatible stack heights: 1 vs 0
			//IL_010c->IL0079: Incompatible stack heights: 1 vs 0
			//IL_02b9->IL0079: Incompatible stack heights: 1 vs 0
			//IL_0212->IL0079: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					case 3:
						_ = 2;
						continue;
					case 4:
						obj = (object)Unsafe.AsPointer(ref this);
						if (1 == 0)
						{
							obj2 = 1;
						}
						continue;
					case 1:
						if (obj != null)
						{
							_ = 24;
							goto IL_0079;
						}
						goto IL_01bb;
					case 5:
						goto end_IL_0019;
					case 2:
						return;
						IL_01bb:
						obj = (object)Unsafe.AsPointer(ref this);
						if (0 == 0)
						{
							_ = 10;
						}
						goto IL_0079;
						IL_0079:
						while (true)
						{
							switch ((int)/*Error near IL_00e2: Stack underflow*/)
							{
							case 19:
								if ((nuint)(nint)obj <= (nuint)1008009u)
								{
									if (2 == 0)
									{
										_ = 5;
									}
									continue;
								}
								goto default;
							case 18:
								obj = 16;
								continue;
							case 9:
								_ = 19;
								continue;
							case 16:
							case 23:
								_ = 12;
								continue;
							case 10:
								_ = 3;
								continue;
							case 3:
								obj = -1;
								if (2 != 0)
								{
									_ = 6;
								}
								continue;
							case 8:
								if (9 != 0)
								{
									_ = 5;
								}
								continue;
							case 7:
								break;
							case 15:
								_ = 14;
								continue;
							case 6:
								obj = (object)(&obj);
								_ = 8;
								continue;
							case 24:
								if (obj == null)
								{
									if (2 != 0)
									{
										_ = 0;
									}
									continue;
								}
								goto end_IL_0019_2;
							case 2:
							case 17:
								_ = 1;
								_ = 1;
								_ = 1048576;
								_ = 1048576;
								_ = 1048576;
								_ = 10.0;
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 22;
								continue;
							case 21:
								return;
							case 1:
								obj = 0;
								_ = 15;
								continue;
							case 11:
							case 20:
								_ = 2000;
								_ = 13;
								continue;
							case 22:
								if (&obj == null)
								{
									if (1 == 0)
									{
										_ = 1;
									}
									continue;
								}
								goto case 6;
							case 13:
								if (obj != null)
								{
									if (13 == 0)
									{
										_ = 23;
									}
									continue;
								}
								goto case 18;
							case 14:
								_ = ref obj;
								if (12 == 0)
								{
									_ = 21;
								}
								continue;
							case 5:
								obj = obj;
								_ = 20;
								continue;
							default:
								obj = obj;
								obj = 11;
								continue;
							case 4:
							case 12:
								goto end_IL_0019_2;
							}
							break;
						}
						goto IL_01bb;
						end_IL_0019_2:
						break;
					}
					_ = -2;
					_ = 3;
					continue;
					end_IL_0019:
					break;
				}
				obj = (object)Unsafe.AsPointer(ref this);
				obj = 4;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_2E00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778799, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_2F00(object P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
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
				case 1:
					if (0 == 0)
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

	[CompilerGenerated]
	private static readonly object Logger__BackingField;

	private object? _pinger;

	[CompilerGenerated]
	private Action<GameProxy>? m_ConnectionChanged;

	public static readonly ConcurrentDictionary<int, Mass.Game.Proxy.Minecraft.Minecraft> OnlineClients;

	public EntitySocks5? Socks5;

	public bool IsGame;

	public bool BlockIrcMessages;

	private object? _channel;

	private object? _connection;

	internal static GameProxy ReflectSimpleVerifier;

	public static ILogger Logger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00_FF00ᤀ();
		}
	}

	public DesktopSession Session
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DesktopSession)_FF00_FF00_FF00_FF00_FF00_FF00_FF00_2400();
		}
	}

	public EnumGameType GameType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00ﰀ();
		}
	}

	public string GameId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00_EA00();
		}
	}

	public EnumGameVersion GameVersion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2100();
		}
	}

	public string ModHashList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00_FF00_0600();
		}
	}

	public string ServerAddress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00_FF00Ȁ();
		}
	}

	public int ServerPort
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00_FF00_FF00_FF00_FF00_2B00();
		}
	}

	public string? TransferServerAddress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string?)_FF00_FF00_FF00_FF00_FF00_FF00_FF00ᔀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00ᄀ(value);
		}
	}

	public int TransferServerPort
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00_FF00_FF00_FF00_FF00ἀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00_2000((uint)value);
		}
	}

	public SectionValue? Section
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SectionValue?)_FF00_FF00_FF00_FF00_FF00_FF00_FF00ࠀ();
		}
	}

	private IEventLoopGroup WorkerGroup
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (IEventLoopGroup)_FF00_FF00_FF00_FF00_FF00_FF00_FF00Ⰰ();
		}
	}

	private IEventLoopGroup AcceptorGroup
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (IEventLoopGroup)_FF00_FF00_FF00_FF00_FF00_FF00_FF00ᜀ();
		}
	}

	public string? DisplayAddress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string?)_FF00_FF00_FF00_FF00_FF00_FF00_FE00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_F000(value);
		}
	}

	public string? ProxyAddress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string?)_FF00_FF00_FF00_FF00_FF00_FF00_FF00Ḁ();
		}
	}

	public int ProxyPort
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00_FF00_FF00_FF00_FF00_0300();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00_0D00((uint)value);
		}
	}

	public Connection? Connection
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (Connection?)_FF00_FF00_FF00_FF00_FF00_FF00_FF00_0E00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00_2700(value);
		}
	}

	public event Action<GameProxy>? ConnectionChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00_2600(value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00_2A00(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameProxy(EntityLaunchGameProxy args)
	{
		//IL_00b8: Expected I4, but got Obj
		//IL_00a6->IL00af: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		GameProxy gameProxy = this;
		if (0 == 0)
		{
			gameProxy = (GameProxy)0;
		}
		switch ((int)gameProxy)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CListenAsync_003Ed__69))]
	public Task ListenAsync(int port)
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00_FF00_FF00_1B00((uint)port);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterEvents()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Dispose()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00_2300();
	}

	static GameProxy()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0023: Expected I4, but got Obj
		//IL_007a->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0051->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0085->IL0012: Incompatible stack types: I4 vs Obj
		//IL_005c->IL0012: Incompatible stack types: I4 vs Obj
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
			case 2:
				Logger__BackingField = Log.Logger.Category((string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_E800());
				obj2 = 1;
				if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_3369da80e85f42fda57cd6db7d7b31f1 != 0)
				{
					obj2 = 1;
				}
				break;
			case 1:
				OnlineClients = new ConcurrentDictionary<int, Mass.Game.Proxy.Minecraft.Minecraft>();
				obj2 = 0;
				if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_19d536ad208d4346b895990d78db913f == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ExcludeAuditor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GameProxy CheckTransferableComparator()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_E900()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778703, new IntPtr(2737367923404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_EA00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_EB00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778702, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_EC00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778697, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_FF00_FF00_ED00(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0060->IL0019: Incompatible stack heights: 7 vs 1
		//IL_006b->IL0019: Incompatible stack heights: 7 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj = P_0;
				_ = 0;
				_ = 1;
				_ = 1;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_EE00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778696, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_EF00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778699, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_F000(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
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
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_F100()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_F200()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778698, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_FF00_FF00_FF00_FF00_FF00ﬀ()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_006a: Expected I4, but got Obj
		//IL_0180: Expected Obj, but got I4
		//IL_0108: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I4
		//IL_009a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ab->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0196->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0146->IL0019: Incompatible stack types: I4 vs Obj
		//IL_011a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0174->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0080->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01b0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0129->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00f1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0164->IL0015: Incompatible stack heights: 1 vs 0
		//IL_01ff->IL0205: Incompatible stack heights: 0 vs 2
		//IL_00b6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01a1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00df->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0151->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01e7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01d9->IL01d9: Incompatible stack heights: 2 vs 0
		//IL_0134->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01cb->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01bf->IL01bf: Incompatible stack heights: 2 vs 0
		//IL_00fc->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0213->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01f2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_021e->IL0019: Incompatible stack heights: 3 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				case 11:
					obj2 = 1;
					if (18 != 0)
					{
						obj2 = 0;
					}
					continue;
				default:
					_ = 0;
					_ = 5;
					continue;
				case 2:
					obj2 = 0;
					if (14 == 0)
					{
						obj2 = 10;
					}
					continue;
				case 3:
					obj2 = 10;
					continue;
				case 5:
					obj2 = 0;
					if (13 != 0)
					{
						obj2 = 5;
					}
					continue;
				case 17:
					obj2 = 0;
					if (16 != 0)
					{
						obj2 = 3;
					}
					continue;
				case 15:
					obj = 7;
					break;
				case 7:
					obj2 = 3;
					continue;
				case 14:
					if (14 != 0)
					{
						obj2 = 15;
					}
					continue;
				case 6:
					obj2 = 0;
					if (12 == 0)
					{
						obj2 = 5;
					}
					continue;
				case 18:
					_ = 0;
					obj = 4;
					break;
				case 9:
					_ = 0;
					_ = 6;
					continue;
				case 10:
					obj = 8;
					break;
				case 4:
					obj2 = 0;
					if (0 != 0)
					{
						obj2 = 0;
					}
					continue;
				case 13:
					_ = 0;
					_ = 2;
					continue;
				case 8:
					return;
				case 16:
					if ((int)/*Error near IL_01b3: Stack underflow*/ == 0)
					{
						_ = null;
					}
					_ = 0;
					_ = 9;
					continue;
				case 12:
					if ((int)/*Error near IL_01cd: Stack underflow*/ == 0)
					{
						_ = null;
					}
					obj2 = 0;
					if (1 != 0)
					{
						obj2 = 0;
					}
					continue;
				case 1:
					if ((int)/*Error near IL_01f4: Stack underflow*/ == 0)
					{
						_ = null;
					}
					_ = 0;
					if (7 != 0)
					{
						_ = 11;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal EnumGameType _FF00_FF00_FF00_FF00_FF00_FF00ﰀ()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (EnumGameType)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe EnumGameType _FF00_FF00_FF00_FF00_FF00_FF00ﴀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778693, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
		return (EnumGameType)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FE00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778692, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ā()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778695, new IntPtr(2737367929644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ȁ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0300()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ѐ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778694, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ԁ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778689, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0600()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778688, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ࠀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0900()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778691, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0A00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0B00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778690, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0C00(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778717, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0D00(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
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
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0E00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ༀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778716, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00က(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778719, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᄀ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
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
				if (false)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ሀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778718, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00ጀ()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_1400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778713, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᔀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᘀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778712, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᜀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_1800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778715, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᤀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᨀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778714, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_1B00(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_006b: Expected Obj, but got Ref
		//IL_00b1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0096->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0049->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00bc->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0066->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0086->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a1->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 5:
				_ = ref obj;
				_ = 4;
				break;
			case 2:
				_ = ref obj;
				_ = ref obj;
				if (false)
				{
					_ = 0;
				}
				break;
			default:
				return (object)(&obj);
			case 3:
				_ = ref obj;
				_ = -1;
				if (2 == 0)
				{
					_ = 0;
				}
				break;
			case 4:
				_ = ref obj;
				if (0 == 0)
				{
					_ = 1;
				}
				break;
			case 1:
				_ = ref obj;
				if (2 == 0)
				{
					_ = 3;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᰀ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778709, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ḁ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 10501, 1790778708, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778708, new IntPtr(2737367921324L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00_FF00_FF00_FF00_FF00ἀ()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2000(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
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
	internal EnumGameVersion _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2100()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (EnumGameVersion)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2300()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0042: Expected I4, but got Obj
		//IL_0053: Expected Obj, but got I4
		//IL_0058->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0071->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0100->IL0019: Incompatible stack heights: 0 vs 1
		//IL_009a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00b8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0084->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_010b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ed->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 7;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 4:
					obj2 = this;
					if (true)
					{
						obj2 = 1;
					}
					continue;
				case 7:
					if (this == null)
					{
						obj2 = 6;
					}
					else
					{
						_ = 8;
					}
					continue;
				case 1:
					return;
				case 2:
				case 5:
					if (this == null)
					{
						if (true)
						{
							obj2 = 3;
						}
					}
					else if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 6:
				case 8:
					obj2 = this;
					if (obj2 == null)
					{
						obj2 = 2;
					}
					else if (0 == 0)
					{
						obj2 = 5;
					}
					continue;
				}
				break;
			}
			_ = 0;
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2400()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778711, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2600(Action<GameProxy> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_006b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0087->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0050->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0076->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c3->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				obj = obj;
				if (5 == 0)
				{
					_ = 4;
				}
				break;
			default:
				obj = obj;
				if (3 != 0)
				{
					obj2 = 3;
				}
				break;
			case 4:
				return;
			case 1:
				obj = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				obj2 = obj;
				obj = P_0;
				if (0 == 0)
				{
					obj2 = 2;
				}
				break;
			case 5:
				if (obj == obj)
				{
					obj2 = 4;
					break;
				}
				goto default;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2700(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0095->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0066->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0084->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0051->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0071->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				if (0 == 0)
				{
					_ = 1;
				}
				break;
			case 2:
				if (this == null)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
				}
				else
				{
					_ = 4;
				}
				break;
			case 1:
				return;
			case 3:
				if (this != P_0)
				{
					obj2 = 2;
					break;
				}
				goto default;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2800(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778710, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2900(Action<GameProxy> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778705, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2A00(Action<GameProxy> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00b7->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0087->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00c2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0074->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00a7->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj = this;
				if (true)
				{
					obj2 = 1;
				}
				continue;
			case 3:
				obj2 = obj;
				obj = P_0;
				if (5 == 0)
				{
					obj2 = 4;
				}
				continue;
			case 5:
				obj = obj;
				_ = 4;
				continue;
			case 4:
				if (obj == obj)
				{
					if (false)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
			case 1:
				break;
			case 0:
				return;
			}
			obj = obj;
			if (3 != 0)
			{
				obj2 = 3;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2B00()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ⰰ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ⴀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778704, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
