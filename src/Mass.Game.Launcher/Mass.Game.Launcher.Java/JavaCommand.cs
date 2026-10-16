using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Mass.Application.Desktop;
using Mass.Common.Extensions;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Game.Launcher.Paths;
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
	private JavaCommand(object session, object baseMinecraft, object minecraft, EnumGameType type, EnumGameVersion version, uint socketPort, uint rpcPort, object gameId, object address, uint port, object name, uint maxMemory, byte isFilter)
	{
		//IL_00b9: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I4
		//IL_016a: Expected Obj, but got I4
		//IL_009d->IL001c: Incompatible stack heights: 4 vs 2
		//IL_0084->IL001c: Incompatible stack heights: 3 vs 2
		//IL_0142->IL001c: Incompatible stack heights: 4 vs 2
		//IL_0074->IL001c: Incompatible stack heights: 4 vs 2
		//IL_00fe->IL001c: Incompatible stack heights: 4 vs 2
		//IL_011a->IL001c: Incompatible stack heights: 4 vs 2
		//IL_017c->IL001c: Incompatible stack heights: 4 vs 2
		//IL_00ac->IL001c: Incompatible stack heights: 4 vs 2
		//IL_010c->IL001c: Incompatible stack heights: 4 vs 2
		//IL_0129->IL001c: Incompatible stack heights: 3 vs 2
		//IL_0152->IL001c: Incompatible stack heights: 3 vs 2
		//IL_00d3->IL001c: Incompatible stack heights: 4 vs 2
		//IL_008f->IL001c: Incompatible stack heights: 3 vs 2
		//IL_001c->IL001c: Incompatible stack heights: 4 vs 2
		//IL_0134->IL001c: Incompatible stack heights: 3 vs 2
		//IL_015d->IL001c: Incompatible stack heights: 3 vs 2
		//IL_00de->IL001c: Incompatible stack heights: 4 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		while (true)
		{
			JavaCommand javaCommand;
			int num;
			switch (7)
			{
			case 3:
				_ = 5;
				break;
			case 1:
				if (2 == 0)
				{
					_ = 8;
				}
				break;
			default:
				_ = 9;
				break;
			case 9:
				_ = 6;
				break;
			case 4:
			{
				javaCommand = this;
				num = (int)port;
				object obj = 3;
				break;
			}
			case 15:
				if (true)
				{
					_ = 1;
				}
				break;
			case 8:
			{
				javaCommand = this;
				num = (int)maxMemory;
				object obj = 11;
				break;
			}
			case 5:
				_ = 14;
				break;
			case 11:
				_ = 4;
				break;
			case 6:
				_ = 15;
				break;
			case 12:
				if (13 == 0)
				{
					_ = 1;
				}
				break;
			case 10:
				return;
			case 2:
				_ = 12;
				break;
			case 13:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 14:
			{
				javaCommand = this;
				num = isFilter;
				object obj = 10;
				break;
			}
			case 7:
				_ = 2;
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
	private object _FF00_FF00똀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
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
	private object _FF00_FF00밀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
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
	internal static byte _FF00_FF00뼀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00쌀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0086: Expected I4, but got Obj
		//IL_024e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0126->IL0019: Incompatible stack heights: 0 vs 1
		//IL_02ce->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01ac->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02b3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0273->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0220->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0289->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01da->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01c2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01fd->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0187->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0160->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0131->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_019d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_029f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02d9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02be->IL0019: Incompatible stack heights: 2 vs 1
		//IL_010b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00a3->IL0019: Incompatible stack heights: 0 vs 1
		//IL_023c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_022b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01e5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0208->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0116->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ae->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ce->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (14 == 0)
					{
						obj2 = 6;
					}
					break;
				}
				goto default;
			case 13:
				throw /*Error near IL_00b1: Stack underflow*/;
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
					if (true)
					{
						obj2 = 1;
					}
					break;
				}
				goto default;
			case 12:
				obj = this;
				if (16 == 0)
				{
					obj2 = 3;
				}
				break;
			case 10:
				if (this == null)
				{
					obj2 = 9;
					break;
				}
				obj = this;
				obj2 = 24;
				break;
			case 11:
				return obj;
			case 9:
				throw /*Error near IL_0175: Stack underflow*/;
			case 16:
				if ((nuint)(nint)obj > (nuint)1018000u)
				{
					obj2 = 18;
					break;
				}
				goto case 17;
			case 20:
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
					if (19 == 0)
					{
						obj2 = 23;
					}
					break;
				}
				goto default;
			case 8:
				if ((nint)obj != 1013002)
				{
					if (22 == 0)
					{
						obj2 = 7;
					}
					break;
				}
				goto default;
			case 4:
				if ((nint)obj == 1021010)
				{
					if (false)
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
				obj2 = this;
				obj = obj;
				if (12 != 0)
				{
					obj2 = 8;
				}
				break;
			default:
				obj = obj;
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
				obj = obj;
				if (19 == 0)
				{
					_ = 7;
				}
				break;
			case 19:
			case 25:
				obj = obj;
				if (20 == 0)
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
	private uint _FF00_FF00였()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00_FF00윀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
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
	private object _FF00_FF00쬀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_005a: Expected I4, but got Obj
		//IL_00c8: Expected Obj, but got I4
		//IL_01b8: Expected Obj, but got I4
		//IL_0070: Expected Obj, but got I4
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_00f2->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01a6->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00d4->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01c4->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00c5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0106->IL0194: Incompatible stack heights: 1 vs 0
		//IL_0177->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0189->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00fd->IL0019: Incompatible stack types: I4 vs Obj
		//IL_013c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01b1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a5->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00df->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01cf->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0194->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_011d->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 13:
				_ = 32;
				return obj;
			case 6:
				_ = ((object[])obj)[obj];
				_ = 61;
				obj = 0;
				_ = 3;
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
					if (14 != 0)
					{
						obj2 = 10;
					}
					break;
				}
				goto case 10;
			case 9:
				((object[])obj)[obj] = obj;
				_ = 12;
				break;
			case 4:
				obj = 0;
				if (8 != 0)
				{
					obj2 = 8;
				}
				break;
			default:
				obj = obj;
				if (9 != 0)
				{
					obj2 = 3;
				}
				break;
			case 11:
				obj2 = obj;
				if (P_1 != null)
				{
					if (3 != 0)
					{
						obj2 = 10;
					}
					break;
				}
				goto case 2;
			case 1:
				obj2 = this;
				obj = obj;
				if (0 == 0)
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
				if (8 == 0)
				{
					obj2 = 11;
				}
				break;
			case 2:
				obj = ((object[])obj)[1];
				if (1 == 0)
				{
					obj2 = 0;
				}
				break;
			case 5:
				_ = 32;
				obj = 1;
				if (4 != 0)
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
	private EnumGameType _FF00_FF00츀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (EnumGameType)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe EnumGameType _FF00_FF00케()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778829, new IntPtr(2737337536684L), 15))(null, 0, new IntPtr(0L));
		return (EnumGameType)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private uint _FF00_FF00퀀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00턀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778828, new IntPtr(2737337536684L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00툀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00팀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778827, new IntPtr(2737337538764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00퐀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
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
	private object _FF00_FF00_FFFD()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe byte _FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778824, new IntPtr(2737337569964L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte _FF00_FF00_FFFD()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe byte _FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778823, new IntPtr(2737337569964L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FFFD()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
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
	internal static object _FF00_FF00_E100(object P_0, object P_1, object P_2, EnumGameType P_3, EnumGameVersion P_4, uint P_5, uint P_6, object P_7, object P_8, uint P_9, object P_10, uint P_11, byte P_12)
	{
		//IL_0020: Expected Obj, but got I4
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return P_12;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_E200(object P_0, object P_1, object P_2, EnumGameType P_3, EnumGameVersion P_4, uint P_5, uint P_6, object P_7, object P_8, uint P_9, object P_10, uint P_11, byte P_12)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778819, new IntPtr(2737337571004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_E300()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
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
	internal static object _FF00_FF00_E600()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private EnumGameVersion _FF00_FF00_E700()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (EnumGameVersion)(int)this;
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
	private object _FF00_FF00_EA00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
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
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_00ae: Expected Obj, but got Ref
		//IL_0186: Expected Obj, but got I4
		//IL_00da->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00ba->IL0019: Incompatible stack heights: 25 vs 1
		//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00e5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c5->IL0019: Incompatible stack heights: 25 vs 1
		//IL_0052->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0192->IL0019: Incompatible stack heights: 12 vs 1
		//IL_0183->IL0183: Incompatible stack heights: 12 vs 13
		//IL_019d->IL0019: Incompatible stack heights: 12 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 3:
				_ = 32;
				_ = 0;
				_ = ref obj;
				_ = 77;
				_ = 4;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				obj = (object)(&obj);
				if (4 == 0)
				{
					_ = 4;
				}
				break;
			default:
				return obj;
			case 2:
				obj = P_0;
				if (false)
				{
					obj2 = 1;
				}
				break;
			case 1:
				if (&obj == null)
				{
					throw ref obj;
				}
				obj = P_0;
				if (&obj == null)
				{
					throw ref obj;
				}
				obj = this;
				obj = obj;
				obj = obj;
				obj = obj;
				obj = obj;
				obj = obj;
				obj = obj;
				obj = obj;
				obj = obj;
				if ((nuint)(nint)this < (nuint)1018000u)
				{
				}
				obj = 32;
				if (1 == 0)
				{
					_ = 3;
				}
				break;
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
	private uint _FF00_FF00_FF00ሀ()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
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
		//IL_0010: Expected Obj, but got I4
		//IL_004a: Expected I4, but got Obj
		//IL_0110: Expected Obj, but got Ref
		//IL_0106: Expected Obj, but got I4
		//IL_01e4->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00a3->IL0019: Incompatible stack heights: 23 vs 1
		//IL_01bc->IL023a: Incompatible stack heights: 1 vs 0
		//IL_022e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_018b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0213->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0202->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01a8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01ef->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0276->IL0019: Incompatible stack heights: 8 vs 1
		//IL_01c9->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0239->IL0019: Incompatible stack heights: 2 vs 1
		//IL_021e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01b3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01d4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0127->IL00b7: Incompatible stack heights: 1 vs 0
		//IL_00f0->IL00b7: Incompatible stack heights: 1 vs 0
		//IL_00b7->IL00b7: Incompatible stack heights: 4 vs 0
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 6;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				_ = 0;
				_ = ref obj;
				_ = 77;
				_ = 4;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = 8;
				continue;
			default:
				while (true)
				{
					if (&obj == null)
					{
						if (0 == 0)
						{
							_ = 0;
						}
						goto IL_00b7;
					}
					goto IL_010b;
					IL_010b:
					obj = (object)(&obj);
					if (1 == 0)
					{
						_ = 1;
					}
					goto IL_00b7;
					IL_00b7:
					while (true)
					{
						switch ((int)/*Error near IL_00cc: Stack underflow*/)
						{
						case 3:
							break;
						case 1:
							_ = 59;
							obj = 3;
							continue;
						case 2:
							goto IL_010b;
						default:
							goto end_IL_00d1;
						}
						break;
					}
					continue;
					end_IL_00d1:
					break;
				}
				goto case 10;
			case 6:
				obj = this;
				obj2 = 5;
				continue;
			case 10:
				obj = P_0;
				_ = ref obj;
				_ = 32;
				if (4 != 0)
				{
					_ = 9;
				}
				continue;
			case 4:
				if (&obj == null)
				{
					if (false)
					{
						obj2 = 2;
					}
					continue;
				}
				break;
			case 1:
				obj = P_1;
				if (false)
				{
					obj2 = 0;
				}
				continue;
			case 8:
				return obj;
			case 9:
				obj = P_0;
				obj2 = 4;
				continue;
			case 7:
				if (1 == 0)
				{
					obj2 = 1;
				}
				continue;
			case 5:
				if (5 == 0)
				{
					_ = 7;
				}
				continue;
			case 2:
				break;
			}
			_ = 32;
			obj = this;
			_ = 3;
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
		//IL_0010: Expected Obj, but got I4
		//IL_0042: Expected I4, but got Obj
		//IL_0329: Expected Obj, but got Ref
		//IL_02dd: Expected Obj, but got Ref
		//IL_011b: Expected Obj, but got Ref
		//IL_0223: Expected Obj, but got I4
		//IL_01d0: Expected Obj, but got I4
		//IL_0335->IL0019: Incompatible stack heights: 0 vs 1
		//IL_02c9->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02f1->IL0047: Incompatible stack heights: 1 vs 0
		//IL_0074->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02e7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0340->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02d4->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0067->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0308->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0160->IL0098: Incompatible stack heights: 1 vs 0
		//IL_0132->IL0098: Incompatible stack heights: 1 vs 0
		//IL_022f->IL0098: Incompatible stack heights: 2 vs 0
		//IL_024a->IL0098: Incompatible stack heights: 1 vs 0
		//IL_0203->IL0098: Incompatible stack heights: 3 vs 0
		//IL_020e->IL014e: Incompatible stack heights: 1 vs 0
		//IL_023a->IL0098: Incompatible stack heights: 2 vs 0
		//IL_0098->IL0098: Incompatible stack heights: 2 vs 0
		//IL_019d->IL0098: Incompatible stack heights: 1 vs 0
		//IL_0218->IL0098: Incompatible stack heights: 2 vs 0
		//IL_00f3->IL0098: Incompatible stack heights: 1 vs 0
		//IL_0254->IL0254: Incompatible stack heights: 3 vs 1
		//IL_0107->IL0098: Incompatible stack heights: 1 vs 0
		//IL_0180->IL0098: Incompatible stack heights: 1 vs 0
		//IL_01be->IL0098: Incompatible stack heights: 1 vs 0
		//IL_026d->IL0098: Incompatible stack heights: 1 vs 0
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 6;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				if (&obj != (object*)2)
				{
					if (0 == 0)
					{
						obj2 = 1;
					}
				}
				else
				{
					obj = (object)(&obj);
					obj2 = 2;
				}
				break;
			case 6:
				obj = (object)/*Error near IL_006a: Stack underflow*/;
				obj2 = 5;
				break;
			case 7:
				return (List<string>)obj;
			case 8:
				while (true)
				{
					IL_014e:
					if (&obj == null)
					{
						_ = 13;
						goto IL_0098;
					}
					goto IL_0116;
					IL_0098:
					while (true)
					{
						switch ((int)/*Error near IL_00dd: Stack underflow*/)
						{
						case 8:
							if (obj == null)
							{
								_ = 15;
								continue;
							}
							goto case 9;
						case 11:
							if (&obj == null)
							{
								_ = 10;
								continue;
							}
							_ = 58;
							_ = 0;
							goto IL_0254;
						case 4:
							break;
						case 12:
						case 14:
						case 15:
							goto IL_014e;
						case 7:
							if (obj != null)
							{
								if (14 == 0)
								{
									_ = 3;
								}
								continue;
							}
							goto case 1;
						case 3:
							obj = ((object[])obj)[2];
							if (7 == 0)
							{
								_ = 0;
							}
							continue;
						case 9:
							if (((Array)obj).Length >= 3)
							{
								if (false)
								{
									_ = 0;
								}
								continue;
							}
							goto IL_014e;
						case 1:
							obj = obj;
							obj = 5;
							continue;
						case 5:
							((object[])5)[0] = this;
							((object[])5)[1] = obj;
							((object[])5)[2] = ((object[])obj)[1];
							((object[])5)[3] = ((object[])obj)[2];
							((object[])5)[4] = obj;
							_ = 12;
							continue;
						case 6:
							_ = ref obj;
							if (&obj != null)
							{
								_ = 11;
								continue;
							}
							goto IL_014e;
						default:
							_ = ((object[])obj)[0];
							_ = 46;
							obj = 92;
							if (2 != 0)
							{
								_ = 2;
							}
							continue;
						case 2:
							obj = ((object[])obj)[1];
							_ = 3;
							continue;
						case 10:
							goto IL_0254;
						case 13:
							goto end_IL_014e;
							IL_0254:
							obj = null;
							if (3 == 0)
							{
								_ = 8;
							}
							continue;
						}
						break;
					}
					goto IL_0116;
					IL_0116:
					obj = (object)(&obj);
					if (4 == 0)
					{
						_ = 6;
					}
					goto IL_0098;
					continue;
					end_IL_014e:
					break;
				}
				goto case 3;
			case 3:
				if (7 != 0)
				{
					_ = 3;
				}
				break;
			case 1:
			case 4:
				throw /*Error near IL_02d8: Stack underflow*/;
			case 5:
				obj2 = P_0;
				if (&obj == null)
				{
					if (2 == 0)
					{
						obj2 = 4;
					}
					break;
				}
				goto default;
			case 2:
				obj = (object)(&obj);
				if (8 == 0)
				{
					obj2 = 0;
				}
				break;
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
	private void _FF00_FF00_FF00_3100(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_005f->IL0019: Incompatible stack heights: 12 vs 1
		//IL_006a->IL0019: Incompatible stack heights: 12 vs 1
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
				_ = 0;
				_ = ref obj;
				_ = 41;
				_ = 2;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
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
	private uint _FF00_FF00_FF00㐀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe uint _FF00_FF00_FF00㔀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778868, new IntPtr(2737337538764L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}
}
