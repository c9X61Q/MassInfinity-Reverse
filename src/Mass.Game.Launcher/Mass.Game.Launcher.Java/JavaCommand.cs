using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Mass.Application.Desktop;
using Mass.Common.Extensions;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Domain.Value;
using Mass.Game.Launcher.Entities.Fever;
using Mass.Game.Launcher.Entities.Java;
using Mass.Game.Launcher.Models;
using Mass.Game.Launcher.Paths;
using Mass.Game.Launcher.Values;
using Org.BouncyCastle.Crypto.Engines;
using RestSharp;
using Serilog;

namespace Mass.Game.Launcher.Java;

public class JavaCommand
{
	[CompilerGenerated]
	private static readonly object Logger__BackingField;

	internal static JavaCommand DecorateAdjustableSingleton;

	private static ILogger Logger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	private MinecraftPath BaseMinecraft
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (MinecraftPath)_FF00_FF00똀();
		}
	}

	private MinecraftPath Minecraft
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (MinecraftPath)_FF00_FF00툀();
		}
	}

	private EnumGameVersion Version
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_E700();
		}
	}

	private EnumGameType Type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00츀();
		}
	}

	private string VersionName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FFFD();
		}
	}

	private string GameId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_EA00();
		}
	}

	private string Uuid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00퐀();
		}
	}

	private string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00밀();
		}
	}

	private int MaxMemory
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00ሀ();
		}
	}

	private string Address
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_E300();
		}
	}

	private int Port
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00였();
		}
	}

	private DesktopSession Session
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DesktopSession)_FF00_FF00_FFFD();
		}
	}

	private int SocketPort
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00퀀();
		}
	}

	private int RpcPort
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00㐀();
		}
	}

	private bool IsFilter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FFFD() != 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe JavaCommand(object session, object baseMinecraft, object minecraft, EnumGameType type, EnumGameVersion version, uint socketPort, uint rpcPort, object gameId, object address, uint port, object name, uint maxMemory, byte isFilter)
	{
		//IL_001a: Expected VT, but got Obj
		//IL_00b3: Expected native int or pointer, but got Obj
		//IL_008c: Expected native int or pointer, but got Obj
		//IL_01a0: Expected native int or pointer, but got Obj
		//IL_007f: Expected VT, but got I4
		//IL_007a: Expected native int or pointer, but got Obj
		//IL_00e1: Expected Obj, but got I4
		//IL_00dc: Expected native int or pointer, but got Obj
		//IL_00ea: Expected Obj, but got I4
		//IL_0144: Expected native int or pointer, but got Obj
		//IL_0168: Expected native int or pointer, but got Obj
		//IL_0133: Expected Obj, but got I4
		//IL_012e: Expected native int or pointer, but got Obj
		//IL_013c: Expected Obj, but got I4
		//IL_00cf: Expected Obj, but got VT
		//IL_015b: Expected VT, but got Obj
		//IL_0156: Expected native int or pointer, but got Obj
		//IL_0179: Expected native int or pointer, but got Obj
		//IL_0188: Expected native int or pointer, but got Obj
		//IL_01b7: Expected Obj, but got I4
		//IL_01de: Expected Obj, but got I4
		//IL_01e7: Expected Obj, but got I4
		//IL_0102: Expected Obj, but got I4
		//IL_0107: Expected Ref, but got VT
		//IL_0116: Expected native int or pointer, but got Obj
		//IL_0072: Expected I4, but got Obj
		//IL_0024->IL002d: Incompatible stack types: I4 vs Obj
		//IL_00c2->IL002d: Incompatible stack types: I4 vs Obj
		//IL_00a5->IL002d: Incompatible stack types: I4 vs Obj
		//IL_01af->IL002d: Incompatible stack types: I4 vs Obj
		//IL_0089->IL002d: Incompatible stack types: I4 vs Obj
		//IL_0153->IL002d: Incompatible stack types: I4 vs Obj
		//IL_0177->IL002d: Incompatible stack types: I4 vs Obj
		//IL_01fd->IL002d: Incompatible stack types: I4 vs Obj
		//IL_00d9->IL002d: Incompatible stack heights: 2 vs 1
		//IL_0165->IL002d: Incompatible stack types: I4 vs Obj
		//IL_0192->IL002d: Incompatible stack types: I4 vs Obj
		//IL_01cb->IL002d: Incompatible stack types: I4 vs Obj
		//IL_0120->IL002d: Incompatible stack types: I4 vs Obj
		//IL_00b0->IL002d: Incompatible stack types: I4 vs Obj
		//IL_019d->IL002d: Incompatible stack types: I4 vs Obj
		//IL_01d6->IL002d: Incompatible stack types: I4 vs Obj
		//IL_012b->IL002d: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((ILogger)/*Error near IL_001a: Stack underflow*/).Debug<_0021_00210>((string)/*Error near IL_001a: Stack underflow*/, (_0021_00210)this);
		object obj = 7;
		while (true)
		{
			object obj2;
			switch ((int)obj)
			{
			case 3:
				Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Et__builder, (AsyncTaskMethodBuilder)socketPort);
				obj = 5;
				break;
			case 1:
				Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E4__this, name);
				obj = 2;
				if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton == null)
				{
					obj = 8;
				}
				break;
			default:
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003E1__state = (int)version;
				obj = 9;
				break;
			case 9:
				Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(int)version)->listener, (TcpListener)AsyncTaskMethodBuilder.Create());
				_ = 6;
				break;
			case 4:
				Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003E4__this, (Authenticator)port);
				obj2 = 3;
				goto IL_0029;
			case 15:
				((AsyncTaskMethodBuilder*)name)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)this, ref *(TStateMachine*)((Task)(Authenticator.ReflectMonoObject() ? ((TaskAwaiter*)1) : ((TaskAwaiter*)null))->IsCompleted).GetAwaiter());
				Unsafe.Write(&((Authenticator._003CReceiveAsync_003Ed__9*)(nint)/*Error near IL_010c: Stack underflow*/)->_003C_003E4__this, this);
				obj = 1;
				if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9.client)->_003C_003Eu__1 != 0)
				{
					obj = 1;
				}
				break;
			case 8:
				Unsafe.Write(&Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain, (object)maxMemory);
				obj2 = 11;
				goto IL_0029;
			case 5:
				((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->_003C_003E1__state = (int)rpcPort;
				obj = 14;
				break;
			case 11:
				Unsafe.Write(&((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->_003C_003Et__builder, (AsyncTaskMethodBuilder)address);
				obj = 4;
				break;
			case 6:
				Unsafe.Write(&((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->client, gameId);
				obj = 15;
				break;
			case 12:
				Unsafe.Write(&((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->_003C_003E4__this, minecraft);
				obj = 13;
				if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003Cstream_003E5__2)->_003C_003Eu__1 == 0)
				{
					obj = 1;
				}
				break;
			case 10:
				return;
			case 2:
				Unsafe.Write(&Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway, baseMinecraft);
				obj = 12;
				break;
			case 13:
				((FeverInstaller)this)._003CfeverVersion_003EP = type;
				obj = 0;
				if (((FeverInstaller)FeverInstaller._003CappId_003EP)._003CappVersion_003EP == null)
				{
					obj = 0;
				}
				break;
			case 14:
				FeverInstaller.McBedrock__BackingField = isFilter;
				obj2 = 10;
				goto IL_0029;
			case 7:
				{
					((FeverInstaller)this).Client__BackingField = session;
					obj = 2;
					break;
				}
				IL_0029:
				obj = obj2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string Build(DesktopSession session, MinecraftPath baseMinecraft, MinecraftPath minecraft, EnumGameType type, EnumGameVersion version, int socketPort, int rpcPort, string gameId, string address, int port, string name, int maxMemory, bool isFilter)
	{
		return (string)_FF00_FF00_E100(session, baseMinecraft, minecraft, type, version, (uint)socketPort, (uint)rpcPort, gameId, address, (uint)port, name, (uint)maxMemory, isFilter ? ((byte)1) : ((byte)0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object BuildCommand()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 222, 1790778846, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778846, new IntPtr(2737337564764L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddNativePath(object sb)
	{
		_FF00_FF00_FF00_3100(sb);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object Escape(object path)
	{
		return _FF00_FF00_FF00_2B00(path);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object GetUserPropertiesEx()
	{
		return _FF00_FF00_FFFD();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object GetUserProperties()
	{
		return _FF00_FF00먀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe List<string> BuildJars(Dictionary<string, JsonElement> cfg)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 227, 1790778845, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778845, new IntPtr(2737337563724L), 15);
		}
		return (List<string>)((delegate*<object, object, object>)obj)(this, cfg);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object BuildCommandNew(Dictionary<string, JsonElement> json, List<string> jars)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005a: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 228, 1790778844, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 3, 1790778844, new IntPtr(2737337565804L), 15);
		}
		return ((delegate*<object, object, object, object>)obj)(this, json, jars);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object ReplaceLibraryPath(object args, object option)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005a: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 229, 1790778843, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 3, 1790778843, new IntPtr(2737337567884L), 15);
		}
		return ((delegate*<object, object, object, object>)obj)(this, args, option);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object ReplaceClassPath(object args, object option)
	{
		return _FF00_FF00휀(args, option);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object BuildCommandOld(Dictionary<string, JsonElement> json, List<string> jars)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005a: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 231, 1790778842, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 3, 1790778842, new IntPtr(2737337546044L), 15);
		}
		return ((delegate*<object, object, object, object>)obj)(this, json, jars);
	}

	static JavaCommand()
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
				Logger__BackingField = Log.Logger.Category((string)ZYXDNGuarder._FF00_FF00_FF00ⴀ());
				obj2 = 0;
				if (_003CModule_003E_007B8336717d_002D71de_002D47ce_002Dbc69_002D4d75223ebc5e_007D.m_d836f3f9b6194f49a23d85cb66f28ddf.m_a082f2d9e1f54c18abb19f7d6732fc8f == 0)
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
	internal static bool WriteTracker()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static JavaCommand FilterFinalizer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00딀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778841, new IntPtr(2737337535644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00똀()
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
	private unsafe object _FF00_FF00뜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778840, new IntPtr(2737337535644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00먀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4491, 1790778839, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778839, new IntPtr(2737337535644L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00묀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778838, new IntPtr(2737337568924L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00밀()
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
	private unsafe object _FF00_FF00봀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778837, new IntPtr(2737337568924L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00븀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778836, new IntPtr(2737337568924L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00뼀()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00쌀()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0093: Expected I4, but got Obj
		//IL_01cd: Expected Obj, but got I4
		//IL_0198: Expected native int or pointer, but got Obj
		//IL_01a2: Expected Ref, but got VT
		//IL_014f: Expected Obj, but got I4
		//IL_0159: Expected native int or pointer, but got Obj
		//IL_0369: Expected native int or pointer, but got Obj
		//IL_0278: Expected native int or pointer, but got Obj
		//IL_01e4: Expected Ref, but got VT
		//IL_0132: Expected native int or pointer, but got Obj
		//IL_02df->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0163->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0373->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0221->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0350->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0304->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02ad->IL0026: Incompatible stack types: I4 vs Obj
		//IL_031a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0257->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0237->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0282->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01f0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01b1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_016e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_010d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0206->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0330->IL0026: Incompatible stack types: I4 vs Obj
		//IL_037e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_035b->IL0026: Incompatible stack heights: 3 vs 1
		//IL_013c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ec->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02c9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02b8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0262->IL0026: Incompatible stack types: I4 vs Obj
		//IL_028d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0147->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f7->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 10;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 23:
				if ((nint)obj != 1021000)
				{
					obj2 = 14;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)Authenticator._003CListenAsync_003Ed__7._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj2 = 6;
					}
					break;
				}
				goto default;
			case 13:
				((Authenticator)/*Error near IL_00c8: Stack underflow*/).StartListening((int)/*Error near IL_00c8: Stack underflow*/);
				throw new TcpListener();
			case 15:
			case 18:
				if ((nuint)(nint)obj <= (nuint)1021000u)
				{
					obj2 = 6;
					break;
				}
				goto case 2;
			case 22:
				if ((nint)obj != 1014003)
				{
					obj2 = 1;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this != null)
					{
						obj2 = 1;
					}
					break;
				}
				goto default;
			case 12:
				obj = Authenticator.ReflectMonoObject();
				_ = 16;
				if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state == 0)
				{
					_ = 3;
				}
				break;
			case 10:
			{
				((AsyncTaskMethodBuilder*)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CListenAsync_003Ed__7.ObserveTracker())->_003C_003Eu__1)->SetResult();
				if (this == null)
				{
					obj2 = 9;
					break;
				}
				((Authenticator._003CReceiveAsync_003Ed__9*)this)->MoveNext();
				TaskAwaiter<TcpClient> awaiter = ((Task<TcpClient>)(object)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)/*Error near IL_01d9: Stack underflow*/)._003C_003E4__this).GetAwaiter();
				((AsyncTaskMethodBuilder*)/*Error near IL_01e4: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityFeverManifestInfo>*)/*Error near IL_01e4: Stack underflow*/, ref *(FeverInstaller._003CInstallAsync_003Ed__11*)awaiter);
				obj = (object)/*Error near IL_01e6: Stack underflow*/;
				obj2 = 24;
				break;
			}
			case 11:
				return obj;
			case 9:
				throw new AsyncTaskMethodBuilder((IAsyncStateMachine)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateGenericStruct());
			case 16:
				if ((nuint)(nint)obj > (nuint)1018000u)
				{
					obj2 = 18;
					break;
				}
				goto case 17;
			case 20:
				((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)/*Error near IL_020b: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_020b: Stack underflow*/);
				Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.DecorateFlexibleProfiler();
				((IEnumerable<byte>)obj).ToArray();
				_ = 11;
				break;
			case 7:
				if ((nint)obj != 1018000)
				{
					obj2 = 3;
					break;
				}
				goto default;
			case 6:
				if ((nint)obj != 1020000)
				{
					obj2 = 19;
					if (((FeverInstaller)FeverInstaller.McBedrock__BackingField).Client__BackingField == null)
					{
						obj2 = 23;
					}
					break;
				}
				goto default;
			case 8:
				if ((nint)obj != 1013002)
				{
					obj2 = 22;
					if (((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)FeverInstaller.ReflectVisualArgument)->_003C_003E1__state == 0)
					{
						obj2 = 7;
					}
					break;
				}
				goto default;
			case 4:
				if ((nint)obj == 1021010)
				{
					obj2 = 0;
					if (((FeverInstaller._003CFeverRequest_003Ed__15<>)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003Et__builder)._003C_003E4__this != null)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 1;
			case 24:
				if (obj == null)
				{
					obj2 = 13;
					break;
				}
				obj = ((Authenticator)this).ListenAuthenticationConnectAsync(obj);
				obj2 = 12;
				if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder != 0)
				{
					obj2 = 8;
				}
				break;
			default:
				obj = ((FeverInstaller)obj).GetFeverManifestInfoAsync(obj);
				_ = 25;
				break;
			case 2:
				if ((nint)obj != 1021008)
				{
					obj2 = 4;
					break;
				}
				goto default;
			case 5:
				if ((nint)obj != 1016000)
				{
					obj2 = 7;
					break;
				}
				goto default;
			case 17:
				if ((nuint)(nint)obj <= (nuint)1014003u)
				{
					obj2 = 8;
					break;
				}
				goto case 5;
			case 1:
			case 3:
			case 14:
			case 21:
				obj = ((FeverInstaller)obj).GetFeverAppVersionAsync();
				_ = 19;
				if ((int)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					_ = 7;
				}
				break;
			case 19:
			case 25:
				obj = obj;
				obj2 = 20;
				if ((int)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E4__this)->_003C_003Eu__1 == 0)
				{
					obj2 = 11;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00쐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778835, new IntPtr(2737337568924L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe uint _FF00_FF00씀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778834, new IntPtr(2737337568924L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe uint _FF00_FF00였()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00윀()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00저(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4505, 1790778833, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778833, new IntPtr(2737337568924L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00쨀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778832, new IntPtr(2737337536684L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00쬀(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0067: Expected I4, but got Obj
		//IL_011f: Expected Obj, but got I4
		//IL_0188: Expected native int or pointer, but got Obj
		//IL_00ed: Expected Obj, but got I4
		//IL_0233: Expected Obj, but got I4
		//IL_0235: Expected Obj, but got VT
		//IL_0083: Expected Obj, but got I4
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_0075: Expected VT, but got Obj
		//IL_0075: Expected Obj, but got I4
		//IL_00b8: Expected native int or pointer, but got Obj
		//IL_0155: Expected native int or pointer, but got Obj
		//IL_0133->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0192->IL0026: Incompatible stack types: I4 vs Obj
		//IL_021f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0101->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0249->IL0026: Incompatible stack heights: 3 vs 1
		//IL_008f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ea->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01e0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01fa->IL0026: Incompatible stack types: I4 vs Obj
		//IL_013e->IL0026: Incompatible stack heights: 3 vs 1
		//IL_019d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_022a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0254->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00a4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_015f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0205->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00cd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_016a->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 13:
				((ILogger)/*Error near IL_0075: Stack underflow*/).Debug<_0021_00210>((string)32, (_0021_00210)obj);
				return (object)/*Error near IL_0076: Stack underflow*/;
			case 6:
				((Func<Task>)((object[])obj)[obj])._002Ector((object)61, (nint)0);
				obj = (object)/*Error near IL_0085: Stack underflow*/;
				obj2 = 3;
				break;
			case 7:
			case 8:
				if ((nint)obj >= ((Array)obj).Length)
				{
					obj2 = 13;
					break;
				}
				goto case 6;
			case 3:
				if (((Array)obj).Length == 2)
				{
					obj2 = 14;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
					{
						obj2 = 10;
					}
					break;
				}
				goto case 10;
			case 9:
				((object[])obj)[((Authenticator)obj).ListenAuthenticationConnectAsync(obj)] = ((AsyncTaskMethodBuilder*)obj)->Task;
				obj2 = 12;
				break;
			case 4:
				obj = 0;
				obj2 = 8;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener != null)
				{
					obj2 = 8;
				}
				break;
			default:
				((Authenticator)/*Error near IL_0111: Stack underflow*/).HandleAuthentication((string)/*Error near IL_0111: Stack underflow*/);
				obj = (Authenticator.ReflectMonoObject() ? ((TaskAwaiter*)1) : ((TaskAwaiter*)null))->IsCompleted;
				_ = 9;
				if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder != 0)
				{
					_ = 3;
				}
				break;
			case 11:
			{
				object obj3 = obj;
				((TaskAwaiter*)P_1)->GetResult();
				if (obj3 != null)
				{
					obj2 = 3;
					if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9.client)->_003C_003Eu__1 != 0)
					{
						obj2 = 10;
					}
					break;
				}
				goto case 2;
			}
			case 1:
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)/*Error near IL_0170: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)this);
				((AsyncTaskMethodBuilder*)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)/*Error near IL_0175: Stack underflow*/)._003C_003E1__state)->SetStateMachine((IAsyncStateMachine)obj);
				obj = (object)/*Error near IL_017e: Stack underflow*/;
				obj2 = 0;
				if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.client)->_003C_003E4__this == null)
				{
					obj2 = 0;
				}
				break;
			case 10:
			case 12:
				obj++;
				obj2 = 7;
				break;
			case 14:
				obj = ((object[])obj)[0];
				obj2 = 8;
				if (((FeverInstaller)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway)._003CfeverVersion_003EP == null)
				{
					obj2 = 11;
				}
				break;
			case 2:
				obj = ((object[])obj)[1];
				obj2 = 1;
				if (((FeverInstaller)FeverInstaller._003CappId_003EP)._003CappVersion_003EP == null)
				{
					obj2 = 0;
				}
				break;
			case 5:
				_ = 32;
				obj = ((Task<string>)1).GetAwaiter();
				_ = 4;
				if (FeverInstaller.ReflectVisualArgument != null)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00찀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778831, new IntPtr(2737337536684L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe EnumGameType _FF00_FF00촀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778830, new IntPtr(2737337536684L), 15))(null, 0, new IntPtr(0L));
		return (EnumGameType)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe EnumGameType _FF00_FF00츀()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (EnumGameType)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe EnumGameType _FF00_FF00케()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778829, new IntPtr(2737337536684L), 15))(null, 0, new IntPtr(0L));
		return (EnumGameType)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe uint _FF00_FF00퀀()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00턀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778828, new IntPtr(2737337536684L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00툀()
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
	private unsafe object _FF00_FF00팀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778827, new IntPtr(2737337538764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00퐀()
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
	private unsafe object _FF00_FF00픀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778826, new IntPtr(2737337536684L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00휀(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005a: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4520, 1790778825, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 3, 1790778825, new IntPtr(2737337536684L), 15);
		}
		return ((delegate*<object, object, object, object>)obj)(this, P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FFFD()
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
	private unsafe byte _FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778824, new IntPtr(2737337569964L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe byte _FF00_FF00_FFFD()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe byte _FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778823, new IntPtr(2737337569964L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FFFD()
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
	private unsafe object _FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778822, new IntPtr(2737337539804L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FFFD()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4528, 1790778821, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778821, new IntPtr(2737337569964L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_E000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778820, new IntPtr(2737337571004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_E100(object P_0, object P_1, object P_2, EnumGameType P_3, EnumGameVersion P_4, uint P_5, uint P_6, object P_7, object P_8, uint P_9, object P_10, uint P_11, byte P_12)
	{
		//IL_0034: Expected Obj, but got I4
		//IL_0035: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((Authenticator)P_12).Listener = new Authenticator();
		return P_11;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_E200(object P_0, object P_1, object P_2, EnumGameType P_3, EnumGameVersion P_4, uint P_5, uint P_6, object P_7, object P_8, uint P_9, object P_10, uint P_11, byte P_12)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778819, new IntPtr(2737337571004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_E300()
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
	private unsafe object _FF00_FF00_E400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778818, new IntPtr(2737337571004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_E500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778817, new IntPtr(2737337571004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_E600()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe EnumGameVersion _FF00_FF00_E700()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (EnumGameVersion)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe EnumGameVersion _FF00_FF00_E800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778816, new IntPtr(2737337571004L), 15))(null, 0, new IntPtr(0L));
		return (EnumGameVersion)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_E900()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778879, new IntPtr(2737337538764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_EA00()
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
	private unsafe object _FF00_FF00_EB00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778878, new IntPtr(2737337571004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00ༀ(Dictionary<string, JsonElement> P_0, List<string> P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778877, new IntPtr(2737337571004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00က(Dictionary<string, JsonElement> P_0, List<string> P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_009d: Expected Obj, but got I4
		//IL_00a4: Expected Ref, but got VT
		//IL_00ae: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got Ref
		//IL_010f: Expected I4, but got Obj
		//IL_010f: Expected Obj, but got Ref
		//IL_010f: Expected Obj, but got I4
		//IL_0117: Expected Obj, but got Ref
		//IL_0123: Expected Obj, but got Ref
		//IL_0128: Expected I4, but got Obj
		//IL_0153: Expected Ref, but got VT
		//IL_0178: Expected Obj, but got Ref
		//IL_0178: Expected Ref, but got VT
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Obj, but got I4
		//IL_0206: Expected Obj, but got I4
		//IL_0235: Expected Obj, but got I4
		//IL_023a: Expected I4, but got Obj
		//IL_0256: Expected Obj, but got I4
		//IL_0283: Expected Obj, but got I4
		//IL_02a1: Expected Obj, but got I4
		//IL_02cc: Expected Obj, but got I4
		//IL_02f5: Expected Ref, but got VT
		//IL_0305: Expected Obj, but got I4
		//IL_030a: Expected Obj, but got I
		//IL_0324: Expected Obj, but got I4
		//IL_032f: Expected I4, but got Obj
		//IL_032f: Expected Obj, but got I4
		//IL_035a: Expected Obj, but got I4
		//IL_0369: Expected Obj, but got I4
		//IL_01d3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0060->IL0026: Incompatible stack heights: 3 vs 1
		//IL_01de->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006b->IL0026: Incompatible stack heights: 3 vs 1
		//IL_037f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0364->IL0364: Incompatible stack heights: 1 vs 2
		//IL_038a->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
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
				_ = ((Authenticator)stateMachine).Listener;
				_ = 0;
				if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
				{
					_ = 0;
				}
				break;
			case 3:
			{
				GC.SuppressFinalize(((Authenticator)(object)((AsyncTaskMethodBuilder*)((Authenticator)/*Error near IL_0075: Stack underflow*/).ListenAuthenticationConnectAsync((object)new TcpListener()))->Task).ReceiveAuthenticationDataAsync((object)this));
				((IAsyncStateMachine)((Authenticator)/*Error near IL_008a: Stack underflow*/).HandleAuthentication((string)/*Error near IL_008a: Stack underflow*/)).MoveNext();
				(((TaskAwaiter*)stateMachine)->IsCompleted ? ((AsyncTaskMethodBuilder*)1) : ((AsyncTaskMethodBuilder*)null))->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)((Task)32).GetAwaiter(), ref *(TStateMachine*)stateMachine);
				((ILogger)/*Error near IL_00ae: Stack underflow*/).Error((Exception)/*Error near IL_00ae: Stack underflow*/, (string)Authenticator._003CListenAsync_003Ed__7.DecorateExpandableParser());
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)this)->MoveNext();
				((AsyncTaskMethodBuilder*)/*Error near IL_00b9: Stack underflow*/)->SetResult();
				((AsyncTaskMethodBuilder*)/*Error near IL_00c3: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateGenericStruct());
				((Authenticator._003CReceiveAsync_003Ed__9*)this)->MoveNext();
				Task<TcpClient> task = ((TcpListener)/*Error near IL_00ce: Stack underflow*/).AcceptTcpClientAsync();
				TcpClient result = (Authenticator._003CReceiveAsync_003Ed__9.ReflectAdvancedEnumerator() ? ((TaskAwaiter<TcpClient>*)1) : ((TaskAwaiter<TcpClient>*)null))->GetResult();
				((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)this)->MoveNext();
				((FeverInstaller)/*Error near IL_00f3: Stack underflow*/)._002Ector((string)(object)((Encoding)(object)task).GetBytes((string)(object)result), (string)(object)((TcpClient)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.DecorateFlexibleProfiler()).GetStream(), (string)(object)this);
				((TcpClient)/*Error near IL_00f8: Stack underflow*/).Close();
				string result2 = ((TaskAwaiter<string>*)4)->GetResult();
				((FeverInstaller)(&stateMachine)).Dispose();
				((Stream)0).Write((byte[])(&stateMachine), 77, (int)result2);
				((AsyncTaskMethodBuilder*)/*Error near IL_011c: Stack underflow*/)->Start(ref *(Rpc._003CListenAsync_003Ed__34*)((FeverInstaller)(&stateMachine)).GetFeverManifestAsync((object)this));
				((RestClientOptions)/*Error near IL_0128: Stack underflow*/).AutomaticDecompression = (DecompressionMethods)((FeverInstaller)(&stateMachine)).GetFeverAppVersionAsync();
				_ = ref stateMachine;
				FeverInstaller._002Ecctor();
				((RestClient)this).Dispose();
				((AsyncTaskMethodBuilder<EntityFeverManifest>*)(&stateMachine))->Start<TStateMachine>(ref *(TStateMachine*)FeverInstaller.CheckStaticProgram());
				((FeverInstaller._003CFeverRequest_003Ed__15<>*)(&stateMachine))->SetStateMachine((IAsyncStateMachine)this);
				_ = ((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)AsyncTaskMethodBuilder<EntityFeverManifestInfo>.Create())->Task;
				((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(&stateMachine))->MoveNext();
				AsyncTaskMethodBuilder<EntityFeverAppVersion>.Create();
				_ = ref stateMachine;
				((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)this)->Start<TStateMachine>(ref *(FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.AnalyzeHandler() ? ((TStateMachine*)1) : ((TStateMachine*)null)));
				((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)AsyncTaskMethodBuilder<_0021_00210>.Create())->SetStateMachine((IAsyncStateMachine)(&stateMachine));
				/*Error near IL_0178: Member reference must be method, but was: Field*/;
			}
			default:
				/*Error near IL_01ac: Member reference must be method, but was: Field*/;
			case 2:
				((FeverInstaller._003CInstallAsync_003Ed__11*)P_0)->MoveNext();
				stateMachine = JsonSerializer.Serialize((EntityUserPropertiesEx)/*Error near IL_01bd: Stack underflow*/, (JsonSerializerOptions?)/*Error near IL_01bd: Stack underflow*/);
				obj = 0;
				if (FeverInstaller._003CInstallAsync_003Ed__11.ReflectAccessibleWatcher != null)
				{
					obj = 1;
				}
				break;
			case 1:
			{
				bool isCompleted = ((TaskAwaiter<RestResponse<EntityFeverResponse<_00210>>>*)(&stateMachine))->IsCompleted;
				if (!isCompleted)
				{
					((Rpc)/*Error near IL_01f5: Stack underflow*/).ProcessId = (isCompleted ? 1 : 0);
					throw new RestClientExtensions((IRestClient)/*Error near IL_01fa: Stack underflow*/, (RestRequest)/*Error near IL_01fa: Stack underflow*/, (CancellationToken)/*Error near IL_01fa: Stack underflow*/);
				}
				stateMachine = ((IEnumerable<FileInfo>)isCompleted).MaxBy((Func<FileInfo, DateTime>)((Rpc)(object)P_0).NeedCha);
				((AsyncTaskMethodBuilder<_00210>*)/*Error near IL_020f: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_020f: Stack underflow*/, ref *(TStateMachine*)(&stateMachine));
				if ((int)/*Error near IL_020f: Stack underflow*/ == 0)
				{
					((Rpc)/*Error near IL_021f: Stack underflow*/).UseCha = (byte)/*Error near IL_021f: Stack underflow*/ != 0;
					throw new AsyncTaskMethodBuilder<_00210>((IAsyncStateMachine)/*Error near IL_0224: Stack underflow*/);
				}
				Dictionary<ushort, Func<RpcCallBack, Task>> callbacks = ((Rpc)/*Error near IL_022a: Stack underflow*/).Callbacks;
				((Rpc)/*Error near IL_023a: Stack underflow*/).StartListen((int)((Rpc)/*Error near IL_0235: Stack underflow*/).RemoteCallBackAsync((object)((TaskAwaiter<EntityFeverApp>*)callbacks)->IsCompleted));
				((Rpc)this).Dispose();
				((Rpc)/*Error near IL_024a: Stack underflow*/).Writer = (BinaryWriter?)Rpc._003CListenAsync_003Ed__34.DecorateIterableWriter;
				((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)/*Error near IL_024f: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_024f: Stack underflow*/);
				stateMachine = ((TaskAwaiter<RestResponse<EntityFeverManifest>>*)/*Error near IL_0254: Stack underflow*/)->IsCompleted;
				((Rpc)this).Listener = ((Rpc)stateMachine).Listener;
				stateMachine = (object)/*Error near IL_0265: Stack underflow*/;
				stateMachine = ((Rpc)this).ListenControlConnectAsync(((Rpc)stateMachine).ListenAsync());
				Task oldValue = ((Rpc)this).SyncChaChaAsync((RpcCallBack)stateMachine);
				stateMachine = Rpc.PopVisitor();
				object obj2 = stateMachine;
				((Rpc._003CListenAsync_003Ed__34*)Rpc.CheckConnectedDecider())->MoveNext();
				stateMachine = obj2;
				((Rpc._003CListenAsync_003Ed__34*)this)->SetStateMachine((IAsyncStateMachine)stateMachine);
				stateMachine = Rpc._003CListenAsync_003Ed__34.CheckIntegratedDic();
				object obj3 = stateMachine;
				((Rpc._003CListenControlConnectAsync_003Ed__35*)Rpc._003CListenAsync_003Ed__34.CheckLocalObject())->MoveNext();
				stateMachine = obj3;
				((Rpc._003CListenControlConnectAsync_003Ed__35*)this)->SetStateMachine((IAsyncStateMachine)stateMachine);
				stateMachine = ((string)/*Error near IL_02bc: Stack underflow*/).Replace((string)(object)oldValue, (string?)(object)this);
				object stateMachine2 = stateMachine;
				stateMachine = ((TaskAwaiter<EntityFeverManifestInfo>*)Rpc._003CListenControlConnectAsync_003Ed__35.DecorateSeparatedSummarizer())->IsCompleted;
				((Rpc._003CReceiveAsync_003Ed__28*)/*Error near IL_02d1: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)stateMachine2);
				bool flag = Rpc._003CReceiveAsync_003Ed__28.DecorateOrderedTemplate();
				((Rpc._003CRemoteCallBackAsync_003Ed__21*)this)->SetStateMachine((IAsyncStateMachine)((CppGameValue)Rpc._003CReceiveAsync_003Ed__28.ReflectVisualAuditor()).SkinPath__BackingField);
				((Rpc._003CSyncChaChaAsync_003Ed__38*)((Task<EntityFeverManifest>)(object)(flag ? ((TaskAwaiter<EntityFeverManifest>*)1) : ((TaskAwaiter<EntityFeverManifest>*)null))->GetResult()).GetAwaiter())->MoveNext();
				((Rpc._003CSyncChaChaAsync_003Ed__38*)/*Error near IL_02fa: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_02fa: Stack underflow*/);
				((CppGameValue)(object)Enumerable.ToArray<TSource>((IEnumerable<TSource>)Enumerable.Concat<TSource>((IEnumerable<TSource>)this, (IEnumerable<TSource>)(object)((CppGameValue)((JavaGameValue)Rpc._003CSyncChaChaAsync_003Ed__38.DecorateConnectedMapper()).SaveOptions__BackingField).SkinPath)))._002Ector();
				((GameValue)((GameValue)(object)((Delegate)CppGameValue.ReflectEditableRecord()).Method).MaxConcurrency).MaxConcurrency = (int)this;
				((Dictionary<ushort, Func<RpcCallBack, Task>>)/*Error near IL_0334: Stack underflow*/)[(ushort)/*Error near IL_0334: Stack underflow*/] = (Func<RpcCallBack, Task>)(object)this;
				List<ConfigValue> mobileValue = GameValue.GetMobileValue((string)/*Error near IL_0339: Stack underflow*/);
				((GameValue)this)._002Ector();
				ushort count;
				if ((nuint)(nint)mobileValue < (nuint)1018000u)
				{
					count = ((BinaryReader)GameValue.CheckControllablePolicy()).ReadUInt16();
				}
				else
				{
					_ = ((JavaGameValue)/*Error near IL_0364: Stack underflow*/).MaxMemory;
				}
				stateMachine = Enumerable.Take<TSource>((IEnumerable<TSource>)32, (int)count);
				obj = 1;
				if (((ComponentPath)(object)ComponentPath.ComponentMd5).ComponentCache == null)
				{
					obj = 3;
				}
				break;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00ᄀ(Dictionary<string, JsonElement> P_0, List<string> P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778876, new IntPtr(2737337571004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe uint _FF00_FF00_FF00ሀ()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe uint _FF00_FF00_FF00ጀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778875, new IntPtr(2737337571004L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_2300(Dictionary<string, JsonElement> P_0, List<string> P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0057: Expected I4, but got Obj
		//IL_032c: Expected native int or pointer, but got Obj
		//IL_0065: Expected VT, but got Obj
		//IL_008f: Expected Obj, but got VT
		//IL_00e1: Expected Obj, but got I4
		//IL_00fa: Expected I4, but got Obj
		//IL_00fa: Expected I4, but got Obj
		//IL_00fa: Expected Obj, but got Ref
		//IL_00fa: Expected Obj, but got VT
		//IL_0106: Expected Obj, but got Ref
		//IL_0106: Expected Obj, but got Ref
		//IL_0118: Expected I4, but got Obj
		//IL_0124: Expected Obj, but got Ref
		//IL_0130: Expected Obj, but got Ref
		//IL_02f4: Expected Obj, but got Ref
		//IL_02a8: Expected I4, but got Obj
		//IL_02ba: Expected Obj, but got I4
		//IL_02cd: Expected Obj, but got I4
		//IL_02d8: Expected native int or pointer, but got Obj
		//IL_03e8: Expected Obj, but got VT
		//IL_03f8: Expected I4, but got Obj
		//IL_0408: Expected I4, but got Obj
		//IL_0408: Expected Obj, but got I4
		//IL_041e: Expected VT, but got Obj
		//IL_041e: Expected VT, but got I4
		//IL_041e: Expected Obj, but got I4
		//IL_042e: Expected I4, but got Obj
		//IL_043e: Expected I4, but got Obj
		//IL_0443: Expected I4, but got Obj
		//IL_0443: Expected Obj, but got I4
		//IL_0449: Expected VT, but got I4
		//IL_045e: Expected Obj, but got I4
		//IL_0463: Expected Obj, but got I4
		//IL_0468: Expected Obj, but got I4
		//IL_0305: Expected native int or pointer, but got Obj
		//IL_01d1: Expected Obj, but got VT
		//IL_01db: Expected native int or pointer, but got Obj
		//IL_0184: Expected native int or pointer, but got Obj
		//IL_01a1: Expected native int or pointer, but got Obj
		//IL_01b2: Expected Ref, but got VT
		//IL_01c3: Expected Obj, but got I4
		//IL_0336->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0140->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03a8->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0381->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0360->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02e2->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0341->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0484->IL0026: Incompatible stack types: I4 vs Obj
		//IL_030f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03b3->IL0026: Incompatible stack heights: 2 vs 1
		//IL_038c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02ed->IL0026: Incompatible stack heights: 2 vs 1
		//IL_018e->IL0154: Incompatible stack heights: 1 vs 2
		//IL_031a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0169->IL01c8: Incompatible stack heights: 1 vs 0
		//IL_0169->IL016e: Incompatible stack heights: 1 vs 0
		//IL_0199->IL0154: Incompatible stack heights: 1 vs 2
		//IL_0154->IL0154: Incompatible stack heights: 3 vs 2
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object awaiter = 6;
		object obj = awaiter;
		while (true)
		{
			switch ((int)obj)
			{
			case 3:
			{
				((ILogger)/*Error near IL_0065: Stack underflow*/).Debug<_0021_00210>((string)awaiter, (_0021_00210)awaiter);
				((Authenticator)/*Error near IL_006a: Stack underflow*/).Listener = (TcpListener?)/*Error near IL_006a: Stack underflow*/;
				((AsyncTaskMethodBuilder*)Task.Run((Func<Task?>)/*Error near IL_006f: Stack underflow*/))->Start<TStateMachine>(ref *(TStateMachine*)((Authenticator)this).ListenAsync());
				object obj2 = ((Authenticator)/*Error near IL_007f: Stack underflow*/).ReceiveAsync((object)/*Error near IL_007f: Stack underflow*/);
				AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
				((Authenticator)this).Dispose();
				((TcpListener)asyncTaskMethodBuilder).Dispose();
				bool isCompleted = (Authenticator.ReflectMonoObject() ? ((TaskAwaiter*)1) : ((TaskAwaiter*)null))->IsCompleted;
				((Authenticator._003CListenAsync_003Ed__7*)this)->MoveNext();
				((AsyncTaskMethodBuilder*)/*Error near IL_00a4: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)obj2, ref *(isCompleted ? ((TStateMachine*)1) : ((TStateMachine*)null)));
				((TaskAwaiter*)4)->GetResult();
				((AsyncTaskMethodBuilder*)(&awaiter))->SetException((Exception)Authenticator._003CListenAsync_003Ed__7.ObserveTracker());
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&awaiter))->SetStateMachine((IAsyncStateMachine)this);
				((AsyncTaskMethodBuilder<EntityFeverManifest>*)null)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<RestResponse<EntityFeverManifest>>*)(&awaiter), ref *(FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)77);
				bool isCompleted2 = ((TaskAwaiter<TcpClient>*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.ReflectRandomReporter())->IsCompleted;
				((Authenticator._003CReceiveAsync_003Ed__9*)(&awaiter))->SetStateMachine((IAsyncStateMachine)this);
				TaskAwaiter<TcpClient> awaiter2 = ((Task<TcpClient>)isCompleted2).GetAwaiter();
				object obj3 = Authenticator._003CReceiveAsync_003Ed__9.DecorateConvertibleParameter();
				Encoding uTF = Encoding.UTF8;
				((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(&awaiter))->SetStateMachine((IAsyncStateMachine)this);
				((FeverInstaller)/*Error near IL_0106: Stack underflow*/)._002Ector((string)(&awaiter), (string)(object)((TcpClient)(object)((Encoding)awaiter2).GetString((byte[])(&awaiter), (int)obj3, (int)uTF)).GetStream(), (string)(&awaiter));
				((TcpClient)/*Error near IL_010b: Stack underflow*/).Close();
				((Stream)/*Error near IL_011d: Stack underflow*/).Write((byte[])/*Error near IL_011d: Stack underflow*/, (int)/*Error near IL_011d: Stack underflow*/, ((Stream)/*Error near IL_0118: Stack underflow*/).Read((byte[])/*Error near IL_0118: Stack underflow*/, (int)(&awaiter), (int)((FeverInstaller)this).Client));
				((RestClientOptions)((FeverInstaller)/*Error near IL_0124: Stack underflow*/).GetFeverManifestAsync((object)(&awaiter)))._002Ector();
				((RestClientOptions)/*Error near IL_0130: Stack underflow*/).UserAgent = (string)(&awaiter);
				((RestClientOptions)/*Error near IL_0135: Stack underflow*/).AutomaticDecompression = (DecompressionMethods)/*Error near IL_0135: Stack underflow*/;
				obj = 8;
				continue;
			}
			default:
				while (true)
				{
					((RestClient)/*Error near IL_0175: Stack underflow*/)._002Ector((RestClientOptions)/*Error near IL_0175: Stack underflow*/, (ConfigureHeaders)/*Error near IL_0175: Stack underflow*/, (ConfigureSerialization)/*Error near IL_0175: Stack underflow*/, (byte)(&awaiter) != 0);
					if ((int)/*Error near IL_017a: Stack underflow*/ == 0)
					{
						_ = 0;
						if ((int)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E4__this)->_003C_003Eu__1 == 0)
						{
							_ = 0;
						}
						goto IL_0154;
					}
					goto IL_01c8;
					IL_01c8:
					_ = ref awaiter;
					awaiter = AsyncTaskMethodBuilder<EntityFeverAppVersion>.Create();
					int num = 1;
					if (((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReflectReporter)->_003C_003E1__state == 0)
					{
						num = 1;
					}
					goto IL_0154;
					IL_0154:
					while (true)
					{
						switch (num)
						{
						case 3:
							break;
						case 1:
						{
							object obj4 = awaiter;
							((FeverInstaller._003CFeverRequest_003Ed__15<>*)this)->MoveNext();
							_ = ((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)obj4)->_003C_003E1__state;
							((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)AsyncTaskMethodBuilder<EntityFeverManifestInfo>.Create())->Task)->Start<TStateMachine>(ref *(TStateMachine*)59);
							awaiter = 3;
							continue;
						}
						case 2:
							goto IL_01c8;
						default:
							goto end_IL_016e;
						}
						break;
					}
					continue;
					end_IL_016e:
					break;
				}
				goto case 10;
			case 6:
				new AsyncTaskMethodBuilder<_0021_00210>();
				FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.DecorateGroupedVisitor();
				/*Error near IL_025d: Member reference must be method, but was: Field*/;
			case 10:
				((Rpc)/*Error near IL_02a8: Stack underflow*/)._002Ector((ILogger)/*Error near IL_02a8: Stack underflow*/, (byte)(int)awaiter != 0);
				((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)/*Error near IL_02ad: Stack underflow*/)->SetResult((EntityFeverAppVersion)/*Error near IL_02ad: Stack underflow*/);
				((Rpc)/*Error near IL_02b3: Stack underflow*/).SendMessage((BinaryWriter)/*Error near IL_02b3: Stack underflow*/, (object[])(object)P_0);
				awaiter = ((TaskAwaiter<EntityFeverApp>*)/*Error near IL_02b8: Stack underflow*/)->IsCompleted;
				((RestRequest)/*Error near IL_02c1: Stack underflow*/)._002Ector((string)/*Error near IL_02c1: Stack underflow*/, (Method)(ref awaiter));
				RestRequestExtensions.AddQueryParameter((RestRequest)/*Error near IL_02c6: Stack underflow*/, (string)/*Error near IL_02c6: Stack underflow*/, (string)/*Error near IL_02c6: Stack underflow*/, (byte)/*Error near IL_02c6: Stack underflow*/ != 0);
				((Task<EntityFeverApp>)32).GetAwaiter();
				_ = 4;
				if (((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)Rpc._003CListenAsync_003Ed__34.DecorateIterableWriter)->_003C_003E1__state != 0)
				{
					_ = 9;
				}
				continue;
			case 4:
				((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)/*Error near IL_02f4: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)(&awaiter));
				if ((int)/*Error near IL_02f4: Stack underflow*/ == 0)
				{
					obj = 0;
					if (((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)Rpc._003CListenControlConnectAsync_003Ed__35.listener)->_003C_003E4__this != null)
					{
						obj = 2;
					}
					continue;
				}
				break;
			case 1:
				((AsyncTaskMethodBuilder<EntityFeverManifest>*)/*Error near IL_0320: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_0320: Stack underflow*/, ref *(TStateMachine*)P_1);
				awaiter = (object)/*Error near IL_0322: Stack underflow*/;
				obj = 0;
				if (((Rpc._003CReceiveAsync_003Ed__28*)(nint)Rpc._003CListenControlConnectAsync_003Ed__35.ReflectSymbolicDecorator)->_003C_003E1__state != 0)
				{
					obj = 0;
				}
				continue;
			case 8:
				((AsyncTaskMethodBuilder<EntityFeverManifest>*)/*Error near IL_0348: Stack underflow*/)->SetException((Exception)awaiter);
				return (object)/*Error near IL_0349: Stack underflow*/;
			case 9:
				((AsyncTaskMethodBuilder*)P_0)->Start(ref *(Rpc.PopVisitor() ? ((JavaGame._003CPrepareServerResourceAsync_003Ed__36*)1) : ((JavaGame._003CPrepareServerResourceAsync_003Ed__36*)null)));
				awaiter = (object)/*Error near IL_0356: Stack underflow*/;
				obj = 4;
				continue;
			case 7:
				((Rpc._003CListenAsync_003Ed__34*)awaiter)->MoveNext();
				((TaskAwaiter<EntityFeverManifestInfo>*)/*Error near IL_036c: Stack underflow*/)->GetResult();
				obj = 1;
				if (((Rpc._003CRemoteCallBackAsync_003Ed__21)Rpc._003CRemoteCallBackAsync_003Ed__21._003C_003Et__builder)._003C_003E4__this == null)
				{
					obj = 1;
				}
				continue;
			case 5:
				((Rpc._003CListenControlConnectAsync_003Ed__35*)awaiter)->MoveNext();
				_ = 5;
				if (Rpc._003CRemoteCallBackAsync_003Ed__21.MeasureCalc == null)
				{
					_ = 7;
				}
				continue;
			case 2:
				break;
			}
			((Rpc._003CReceiveAsync_003Ed__28*)/*Error near IL_03b9: Stack underflow*/)->MoveNext();
			((Rpc._003CReceiveAsync_003Ed__28*)/*Error near IL_03bf: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)this);
			((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)/*Error near IL_03c4: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_03c4: Stack underflow*/);
			((Rpc._003CRemoteCallBackAsync_003Ed__21*)Rpc._003CReceiveAsync_003Ed__28.ReflectVisualAuditor())->MoveNext();
			((Rpc._003CRemoteCallBackAsync_003Ed__21*)/*Error near IL_03d4: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)this);
			nint num2 = ((GameValue)/*Error near IL_03d9: Stack underflow*/).MaxConcurrency__BackingField;
			((Dictionary<ushort, Func<RpcCallBack, Task>>)((Task<EntityFeverAppVersion>)Rpc._003CRemoteCallBackAsync_003Ed__21.ConvertFilter()).GetAwaiter())._002Ector();
			bool flag = Rpc._003CSyncChaChaAsync_003Ed__38.DecorateConnectedMapper();
			((CppGameValue)this).SkinPath = (string)(object)BitConverter.GetBytes((ushort)(int)Rpc._003CSyncChaChaAsync_003Ed__38.CheckAlphabeticPolicy());
			((Salsa20Engine)/*Error near IL_0408: Stack underflow*/).ProcessBytes((byte[])/*Error near IL_0408: Stack underflow*/, (int)/*Error near IL_0408: Stack underflow*/, (int)num2, (byte[])flag, (int)CppGameValue.Get((SectionValue)(object)this));
			((ILogger)/*Error near IL_041e: Stack underflow*/).Debug<_0021_00210, _0021_00211>((string)CppGameValue.ReflectEditableRecord(), (_0021_00210)32, (_0021_00211)((MemberInfo)(object)CppGameValue.CheckLogicalContext()).Name);
			short num3 = BitConverter.ToInt16((byte[])(object)GameValue.GetDesktopValue((string)/*Error near IL_0423: Stack underflow*/, (EnumGameVersion)/*Error near IL_0423: Stack underflow*/), (int)GameValue.GetMobileValue((string)(object)this));
			((JavaGameValue)GameValue.CheckControllablePolicy()).MaxMemory = (int)Enumerable.Skip<TSource>((IEnumerable<TSource>)this, (int)GameValue.TrackDecorator());
			((ILogger)/*Error near IL_0449: Stack underflow*/).Error<_0021_00210>((string)/*Error near IL_0449: Stack underflow*/, (_0021_00210)num3);
			((JavaGameValue)/*Error near IL_0453: Stack underflow*/).ReconnectDelay = ((JavaGameValue)/*Error near IL_044e: Stack underflow*/).ReconnectDelay;
			((BinaryWriter)/*Error near IL_0468: Stack underflow*/)._002Ector((Stream)((JavaGameValue)((ComponentPath)((JavaGameValue)this).SaveOptions).IsResourcePack).SetChinese);
			((JavaGameValue)/*Error near IL_0472: Stack underflow*/).SetGuiScale = ((TcpClient)/*Error near IL_046d: Stack underflow*/).Connected;
			((ILogger)/*Error near IL_0478: Stack underflow*/).Error<_0021_00210>((Exception)/*Error near IL_0478: Stack underflow*/, (string)/*Error near IL_0478: Stack underflow*/, (_0021_00210)/*Error near IL_0478: Stack underflow*/);
			awaiter = (object)/*Error near IL_047a: Stack underflow*/;
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_2400(Dictionary<string, JsonElement> P_0, List<string> P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778874, new IntPtr(2737337571004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe List<string> _FF00_FF00_FF00_2800(Dictionary<string, JsonElement> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004f: Expected I4, but got Obj
		//IL_005b: Expected VT, but got Ref
		//IL_005c: Invalid comparison between Unknown and I4
		//IL_0379: Expected native int or pointer, but got Obj
		//IL_0383: Expected Ref, but got VT
		//IL_03e1: Expected native int or pointer, but got Obj
		//IL_0146: Expected Obj, but got Ref
		//IL_0152: Expected native int or pointer, but got Obj
		//IL_02ba: Expected native int or pointer, but got Obj
		//IL_023d: Expected Obj, but got I4
		//IL_0257: Expected Obj, but got I4
		//IL_027a: Expected Obj, but got VT
		//IL_028b: Expected Obj, but got Ref
		//IL_0292: Expected I4, but got Obj
		//IL_01ad: Expected Obj, but got I4
		//IL_020a: Expected native int or pointer, but got Obj
		//IL_02ed: Expected Obj, but got I4
		//IL_0397->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0091->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0075->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03a2->IL0026: Incompatible stack heights: 2 vs 1
		//IL_03eb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0080->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03f6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0284->IL00bd: Incompatible stack heights: 3 vs 1
		//IL_00bd->IL00bd: Incompatible stack heights: 5 vs 1
		//IL_02ed->IL02ed: Incompatible stack heights: 2 vs 1
		//IL_0130->IL00bd: Incompatible stack heights: 2 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
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
				((ILogger)/*Error near IL_005b: Stack underflow*/).Debug<_0021_00210>((string)/*Error near IL_005b: Stack underflow*/, (_0021_00210)(&stateMachine));
				if ((int)/*Error near IL_0061: Stack underflow*/ == 2)
				{
					_ = ref stateMachine;
					/*Error near IL_03b4: Member reference must be method, but was: Field*/;
				}
				obj = 0;
				if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
				{
					obj = 1;
				}
				break;
			case 6:
				stateMachine = new TcpListener();
				obj = 5;
				break;
			case 7:
				return (List<string>)stateMachine;
			case 8:
				while (true)
				{
					IL_018b:
					((AsyncTaskMethodBuilder*)/*Error near IL_0192: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_0192: Stack underflow*/, ref *(TStateMachine*)(&stateMachine));
					int num;
					if ((int)/*Error near IL_0197: Stack underflow*/ == 0)
					{
						num = 13;
						goto IL_00bd;
					}
					goto IL_013f;
					IL_00bd:
					while (true)
					{
						switch (num)
						{
						case 8:
							if (stateMachine == null)
							{
								num = 15;
								continue;
							}
							goto case 9;
						case 11:
							_ = ref stateMachine;
							if ((int)AsyncTaskMethodBuilder.Create() == 0)
							{
								_ = 10;
								continue;
							}
							((RestClientOptions)58).UserAgent = (string)0;
							goto IL_02ed;
						case 4:
							break;
						case 12:
						case 14:
						case 15:
							goto IL_018b;
						case 7:
							((ILogger)/*Error near IL_01ad: Stack underflow*/).Error((Exception)stateMachine, (string)Authenticator._003CListenAsync_003Ed__7.DecorateExpandableParser());
							if ((int)/*Error near IL_01b2: Stack underflow*/ != 0)
							{
								num = 14;
								if (Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain == null)
								{
									num = 3;
								}
								continue;
							}
							goto case 1;
						case 3:
							stateMachine = ((object[])stateMachine)[2];
							num = 7;
							if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								num = 0;
							}
							continue;
						case 9:
							if (((Array)stateMachine).Length >= 3)
							{
								num = 0;
								if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.client)->_003C_003E4__this != null)
								{
									num = 0;
								}
								continue;
							}
							goto IL_018b;
						case 1:
							Authenticator._003CReceiveAsync_003Ed__9.ReflectAdvancedEnumerator();
							Authenticator._003CReceiveAsync_003Ed__9.DecorateConvertibleParameter();
							stateMachine = Encoding.UTF8;
							stateMachine = 5;
							continue;
						case 5:
						{
							byte[] array = new byte[5];
							((object[])0)[(object)this] = ((FeverInstaller)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.DecorateFlexibleProfiler())._003CappVersion_003EP;
							((object[])(object)array)[1] = stateMachine;
							((object[])(object)array)[2] = ((object[])stateMachine)[1];
							((object[])(object)array)[3] = ((object[])stateMachine)[2];
							((object[])(object)array)[4] = stateMachine;
							((TcpClient)((Task<string>)(object)array).GetAwaiter()).Close();
							_ = 12;
							continue;
						}
						case 6:
							if (((Stream)/*Error near IL_0292: Stack underflow*/).Read((byte[])/*Error near IL_0292: Stack underflow*/, (int)((FeverInstaller)(&stateMachine)).Client, (int)(&stateMachine)) != 0)
							{
								num = 11;
								continue;
							}
							goto IL_018b;
						default:
							((Stream)/*Error near IL_02ae: Stack underflow*/).Write((byte[])((object[])stateMachine)[0], 46, 92);
							stateMachine = (object)/*Error near IL_02b0: Stack underflow*/;
							num = 2;
							if (((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003E4__this)->request != null)
							{
								num = 2;
							}
							continue;
						case 2:
							stateMachine = ((object[])stateMachine)[1];
							num = 3;
							continue;
						case 10:
							goto IL_02ed;
						case 13:
							goto end_IL_018b;
							IL_02ed:
							stateMachine = null;
							num = 3;
							if ((int)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								num = 8;
							}
							continue;
						}
						break;
					}
					goto IL_013f;
					IL_013f:
					GC.SuppressFinalize((object)(&stateMachine));
					stateMachine = (object)/*Error near IL_0148: Stack underflow*/;
					num = 4;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						num = 6;
					}
					goto IL_00bd;
					continue;
					end_IL_018b:
					break;
				}
				goto case 3;
			case 3:
			{
				object obj2 = stateMachine;
				((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)this)->MoveNext();
				_ = ((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)obj2)->_003C_003Eu__1)->Task;
				_ = 7;
				if ((int)((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13._003C_003E1__state)->_003C_003Et__builder != 0)
				{
					_ = 3;
				}
				break;
			}
			case 1:
			case 4:
				((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)/*Error near IL_03a7: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_03a7: Stack underflow*/);
				FeverInstaller._003CGetFeverManifestAsync_003Ed__12.SearchChain();
				/*Error near IL_03ac: Member reference must be method, but was: Field*/;
			case 5:
				((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)/*Error near IL_03cb: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)P_0);
				if (((AsyncTaskMethodBuilder<_0021_00210>*)(&stateMachine))->Task == null)
				{
					obj = 2;
					if ((int)((FeverInstaller._003CInstallAsync_003Ed__11*)(nint)FeverInstaller._003CInstallAsync_003Ed__11._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj = 4;
					}
					break;
				}
				goto default;
			case 2:
				_ = ref stateMachine;
				/*Error near IL_041c: Member reference must be method, but was: Field*/;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_2B00(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4603, 1790778873, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778873, new IntPtr(2737337571004L), 15);
		}
		return ((delegate*<object, object>)obj)(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00Ⰰ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778872, new IntPtr(2737337538764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_3000(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778871, new IntPtr(2737337538764L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_3100(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0045: Expected VT, but got I4
		//IL_0045: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got Ref
		//IL_004c: Expected Obj, but got I4
		//IL_0059: Expected native int or pointer, but got Obj
		//IL_0063: Expected Obj, but got Ref
		//IL_006f: Expected Obj, but got Ref
		//IL_0074: Expected Obj, but got VT
		//IL_0097: Expected Obj, but got I4
		//IL_0097: Expected Obj, but got Ref
		//IL_009e: Expected Obj, but got Ref
		//IL_00b8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c3->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object awaiter = 1;
		object obj = awaiter;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 0:
				return;
			case 1:
			{
				((ILogger*)(&awaiter))->Debug<_0021_00210>((string)41, (_0021_00210)2);
				((Authenticator)0).Listener = (TcpListener?)(&awaiter);
				Task task = Task.Run((Func<Task?>)P_0);
				object obj2 = ((Authenticator)(&awaiter)).ReceiveAsync(Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton);
				AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
				((Authenticator)(&awaiter)).Dispose();
				((TcpListener)asyncTaskMethodBuilder).Dispose();
				((Authenticator._003CListenAsync_003Ed__7*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->MoveNext();
				((AsyncTaskMethodBuilder*)obj2)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)(&awaiter), ref *(TStateMachine*)this);
				((ILogger)task).Error((Exception)(&awaiter), (string)Authenticator._003CListenAsync_003Ed__7.DecorateExpandableParser());
				((AsyncTaskMethodBuilder*)/*Error near IL_009e: Stack underflow*/)->SetException((Exception)(&awaiter));
				((AsyncTaskMethodBuilder*)/*Error near IL_00a3: Stack underflow*/)->SetResult();
				obj = 0;
				if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					obj = 0;
				}
				break;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_3200(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778870, new IntPtr(2737337538764L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe uint _FF00_FF00_FF00_3300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778869, new IntPtr(2737337538764L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe uint _FF00_FF00_FF00㐀()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe uint _FF00_FF00_FF00㔀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778868, new IntPtr(2737337538764L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}
}
