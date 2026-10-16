using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Game.Launcher.Java;

namespace Mass.Game.Launcher.Paths;

public class JavaGamePath : GamePath
{
	public readonly string Java;

	public readonly string JavaUrl;

	public readonly string JavaTarget;

	public readonly string JavaZip;

	public readonly string JavaExe;

	public readonly string GameBase;

	public readonly string GameBaseComponents;

	public readonly string GameBaseMd5;

	public readonly MinecraftPath BaseMinecraft;

	public readonly string GameVersionMd5;

	public readonly string GameCoreLibs;

	public readonly string GameCoreLibMd5;

	public readonly string GameRuntime;

	public readonly string GameRuntimeMd5;

	public readonly string Custom;

	public readonly string CustomOptions;

	public readonly string GameCustom;

	public readonly MinecraftPath Minecraft;

	internal static JavaGamePath ReflectCentralEmitter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JavaGamePath(EntityLaunchJavaGame args)
	{
		//IL_008a: Expected I4, but got Obj
		//IL_0146: Expected Obj, but got I4
		//IL_0132: Expected Obj, but got I4
		//IL_0020->IL0029: Incompatible stack types: I4 vs Obj
		//IL_00f9->IL0029: Incompatible stack heights: 4 vs 1
		//IL_016d->IL0029: Incompatible stack heights: 2 vs 1
		//IL_015b->IL0029: Incompatible stack heights: 3 vs 1
		//IL_01ab->IL0029: Incompatible stack heights: 10 vs 1
		//IL_01ed->IL0029: Incompatible stack heights: 2 vs 1
		//IL_01bd->IL0029: Incompatible stack heights: 2 vs 1
		//IL_00a2->IL0029: Incompatible stack heights: 3 vs 1
		//IL_018b->IL0029: Incompatible stack heights: 4 vs 1
		//IL_023b->IL0029: Incompatible stack heights: 4 vs 1
		//IL_0250->IL0029: Incompatible stack heights: 4 vs 1
		//IL_0116->IL0029: Incompatible stack heights: 4 vs 1
		//IL_00d8->IL0029: Incompatible stack heights: 3 vs 1
		//IL_01db->IL0029: Incompatible stack heights: 4 vs 1
		//IL_00c3->IL0029: Incompatible stack types: I4 vs Obj
		//IL_0104->IL0029: Incompatible stack heights: 4 vs 1
		//IL_025d->IL0029: Incompatible stack types: I4 vs Obj
		//IL_0178->IL0029: Incompatible stack heights: 2 vs 1
		//IL_0029->IL0029: Incompatible stack heights: 3 vs 1
		//IL_01f8->IL0029: Incompatible stack heights: 2 vs 1
		//IL_01c8->IL0029: Incompatible stack heights: 2 vs 1
		//IL_00ad->IL0029: Incompatible stack heights: 3 vs 1
		//IL_00e3->IL0029: Incompatible stack heights: 3 vs 1
		//IL_0228->IL0029: Incompatible stack types: I4 vs Obj
		//IL_02df->IL0029: Incompatible stack heights: 4 vs 1
		//IL_02af->IL0029: Incompatible stack heights: 2 vs 1
		//IL_02ba->IL0029: Incompatible stack heights: 2 vs 1
		//IL_028b->IL0029: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		JavaGamePath javaGamePath = this;
		if (0 == 0)
		{
			javaGamePath = (JavaGamePath)0;
		}
		object obj = default;
		while (true)
		{
			JavaGamePath javaGamePath2;
			JavaGamePath javaGamePath3;
			switch ((int)javaGamePath)
			{
			case 11:
				if (8 == 0)
				{
					_ = 19;
				}
				break;
			default:
				if ((nuint)(nint)args <= (nuint)1016000u)
				{
					javaGamePath = (JavaGamePath)2;
					break;
				}
				if ((nuint)(nint)args <= (nuint)1020000u)
				{
					goto case 2;
				}
				javaGamePath = (JavaGamePath)14;
				break;
			case 21:
				if (1 == 0)
				{
					_ = 1;
				}
				break;
			case 1:
				if (false)
				{
					_ = 7;
				}
				break;
			case 20:
				_ = 0;
				_ = 22;
				break;
			case 6:
				return;
			case 19:
				javaGamePath2 = this;
				javaGamePath3 = this;
				obj = 3;
				break;
			case 7:
				javaGamePath2 = this;
				javaGamePath3 = this;
				obj = 12;
				break;
			case 4:
				_ = 15;
				break;
			case 3:
				if (8 == 0)
				{
					_ = 4;
				}
				break;
			case 12:
				_ = 4;
				break;
			case 5:
				_ = ref obj;
				_ = 5;
				_ = 1;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = 13;
				break;
			case 10:
				if (18 == 0)
				{
					_ = 12;
				}
				break;
			case 22:
				_ = 5;
				break;
			case 8:
				if (20 == 0)
				{
					_ = 14;
				}
				break;
			case 13:
				_ = 21;
				break;
			case 15:
				_ = 9;
				break;
			case 2:
			case 14:
			case 16:
				obj = (object)/*Error near IL_0253: Stack underflow*/;
				javaGamePath = (JavaGamePath)10;
				break;
			case 18:
				javaGamePath = this;
				if (obj != null)
				{
				}
				if (17 == 0)
				{
					javaGamePath = (JavaGamePath)17;
				}
				break;
			case 17:
				if (obj == null)
				{
				}
				if (8 == 0)
				{
					_ = 11;
				}
				break;
			case 9:
				_ = 6;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object GetGameVersionNameLower(EnumGameVersion version)
	{
		return _FF00_FF00贀(version);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object GetMd5FileName(EnumGameVersion version, object suffix = "")
	{
		return _FF00_FF00退(version, suffix);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckStatelessRunner()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static JavaGamePath DecorateScheduledClient()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00褀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778378, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00言()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00謀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778377, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00谀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00_FF00贀(EnumGameVersion P_0)
	{
		//IL_000b: Expected Obj, but got I4
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00踀(EnumGameVersion P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778376, new IntPtr(2737337545004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00輀(EnumGameVersion P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778375, new IntPtr(2737337535644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00_FF00退(EnumGameVersion P_0, object P_1)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00鄀(EnumGameVersion P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778374, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
