using System;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.Application.Mobile;
using Mass.Application.Models;
using Mass.Bedrock.Proxy.Network.RakNet;
using Mass.Common.Extensions;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Domain.Mobile.Entities.Game;
using Serilog;

namespace Mass.Bedrock.Proxy;

public class BedrockProxy : GameInstance
{
	[CompilerGenerated]
	private static readonly object Logger__BackingField;

	public readonly string Name;

	public readonly string GameId;

	public readonly EnumGameType GameType;

	public readonly string ServerAddress;

	public readonly int ServerPort;

	public readonly MobileSession Session;

	public readonly EntityPatchInfo PatchInfo;

	private static object CloneProxy;

	public static ILogger Logger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	private RakNetServer? Listener
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RakNetServer?)_FF00_FF00_FF00_FF00_FF00혀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FFFD((object)value);
		}
	}

	public IPEndPoint[] EndPoints
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (IPEndPoint[])_FF00_FF00_FF00_FF00_FF00윀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00저(value);
		}
	}

	public int EndPointIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00_FF00_FF00찀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00뼀((uint)value);
		}
	}

	public int ProxyPort
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00_FF00_FF00퐀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00준((uint)value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BedrockProxy(EntityLaunchBedrockProxy args)
	{
		//IL_0072: Expected I4, but got Obj
		//IL_0060->IL0069: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		BedrockProxy bedrockProxy = this;
		if (0 == 0)
		{
			bedrockProxy = (BedrockProxy)0;
		}
		switch ((int)bedrockProxy)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartListen(int port)
	{
		_FF00_FF00_FF00_FF00_FF00븀((uint)port);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ParseDns()
	{
		_FF00_FF00_FF00_FF00_FF00먀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnConnected(object session)
	{
		_FF00_FF00_FF00_FF00_FF00쬀(session);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Dispose()
	{
		_FF00_FF00_FF00_FF00_FF00쌀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterEvents()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	static BedrockProxy()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_001f: Expected I4, but got Obj
		//IL_004c->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0057->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
				Logger__BackingField = Log.Logger.Category((string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FFFD());
				obj2 = 0;
				if (_003CModule_003E_007B516b6972_002D90a8_002D4ed4_002Da9b8_002D9c8a3a89ca13_007D.m_1d065322f6cc4334a6da9cd60aaa535f.m_729ba98beaf24ba292a9d304087a1e1d == 0)
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
	internal static bool DecorateExternalMatcher()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static BedrockProxy ReflectOperationalReg()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00뤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778458, new IntPtr(2737337520044L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00먀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_008b->IL00ce: Incompatible stack heights: 1 vs 0
		//IL_00c3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00e4->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0095->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ce->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a9->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0076->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00b4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0081->IL0019: Incompatible stack heights: 3 vs 1
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
				throw /*Error near IL_005e: Stack underflow*/;
			case 4:
				return;
			case 5:
				if (2 == 0)
				{
					_ = 3;
				}
				continue;
			default:
				if (&obj == null)
				{
					_ = 5;
					continue;
				}
				break;
			case 3:
				if (((Array)(object)this).Length != 0)
				{
					return;
				}
				if (2 == 0)
				{
					obj2 = 2;
				}
				continue;
			case 1:
				_ = 0;
				if (0 == 0)
				{
					_ = 0;
				}
				continue;
			case 6:
				break;
			}
			_ = 1;
			((object[])0)[obj] = this;
			_ = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00븀(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_00b2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0080->IL0019: Incompatible stack heights: 3 vs 1
		//IL_004f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0099->IL0019: Incompatible stack heights: 4 vs 1
		//IL_00c4->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0073->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a4->IL0019: Incompatible stack heights: 4 vs 1
		//IL_00cf->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				obj2 = P_0;
				if (0 != 0)
				{
					obj2 = 1;
				}
				break;
			case 2:
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 5;
				}
				break;
			case 3:
				_ = 2;
				break;
			case 5:
				if (6 != 0)
				{
					_ = 5;
				}
				break;
			case 1:
				return;
			default:
				_ = 4;
				break;
			case 6:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00뼀(uint P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00쀀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778459, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00섀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778460, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00숀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00쌀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0060->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0049->IL0019: Incompatible stack heights: 0 vs 1
		//IL_007d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0054->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = this;
				if (obj2 == null)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
				}
				else if (2 != 0)
				{
					obj2 = 2;
				}
				break;
			default:
				_ = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00_FF00쐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778461, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_FF00_FF00_FF00_FF00씀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
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
				obj2 = 0;
				if (0 != 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00_FF00였()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778462, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00윀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00저(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0045->IL0019: Incompatible stack heights: 2 vs 1
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
				if (false)
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
	internal void _FF00_FF00_FF00_FF00_FF00준(uint P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00쨀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778463, new IntPtr(2737337525244L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_FF00쬀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0041->IL0019: Incompatible stack heights: 3 vs 1
		//IL_004c->IL0019: Incompatible stack heights: 3 vs 1
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
				_ = ((object[])(object)this)[(object)this];
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00_FF00_FF00찀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00촀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778464, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00츀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778465, new IntPtr(2737337524204L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00케()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00퀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778466, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00턀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778467, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00툀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00팀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778468, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00_FF00_FF00퐀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00픀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778469, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FF00_FF00_FF00혀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00휀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778470, new IntPtr(2737337529404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778471, new IntPtr(2737337531484L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0045->IL0019: Incompatible stack heights: 2 vs 1
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778472, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
