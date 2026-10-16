using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.Game.Launcher.Cpp;

namespace Mass.Game.Launcher.Paths;

public class CppGamePath : GamePath
{
	public readonly string BedrockLauncherFile;

	public readonly string BedrockLauncher;

	public readonly string BedrockHash;

	public readonly string Bedrock;

	public readonly string GameZip;

	public readonly string BePackCache;

	public readonly string BeMain;

	public readonly string AppData;

	public readonly string GameRuntime;

	public readonly string ConfigFile;

	public readonly string ErrorLog;

	private static object CheckDetachedBridge;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CppGamePath(EntityLaunchCppGame args)
	{
		//IL_0012: Expected Obj, but got I4
		//IL_0055: Expected I4, but got Obj
		//IL_00c5->IL0020: Incompatible stack heights: 4 vs 2
		//IL_00a5->IL0020: Incompatible stack heights: 4 vs 2
		//IL_00f3->IL0020: Incompatible stack heights: 3 vs 2
		//IL_0130->IL0020: Incompatible stack heights: 3 vs 2
		//IL_00d6->IL0020: Incompatible stack heights: 3 vs 2
		//IL_0151->IL0020: Incompatible stack heights: 5 vs 2
		//IL_0089->IL0020: Incompatible stack heights: 3 vs 2
		//IL_010e->IL0020: Incompatible stack heights: 4 vs 2
		//IL_011e->IL0020: Incompatible stack heights: 4 vs 2
		//IL_006c->IL0020: Incompatible stack heights: 3 vs 2
		//IL_00b5->IL0020: Incompatible stack heights: 4 vs 2
		//IL_00fe->IL0020: Incompatible stack heights: 3 vs 2
		//IL_013b->IL0020: Incompatible stack heights: 3 vs 2
		//IL_00e1->IL0020: Incompatible stack heights: 3 vs 2
		//IL_015c->IL0020: Incompatible stack heights: 5 vs 2
		//IL_0094->IL0020: Incompatible stack heights: 3 vs 2
		//IL_0077->IL0020: Incompatible stack heights: 3 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		while (true)
		{
			switch ((int)obj)
			{
			case 10:
				if (true)
				{
					_ = 0;
				}
				break;
			case 7:
				if (4 == 0)
				{
					_ = 11;
				}
				break;
			case 4:
				return;
			case 1:
				_ = 2;
				break;
			case 11:
				_ = 4;
				break;
			default:
				_ = 10;
				break;
			case 5:
				_ = 26;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 2:
				if (2 == 0)
				{
					_ = 3;
				}
				break;
			case 8:
				_ = 9;
				break;
			case 9:
				_ = 6;
				break;
			case 3:
				if (8 != 0)
				{
					_ = 6;
				}
				break;
			case 6:
				if (7 == 0)
				{
					_ = 5;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectDetailedCommand()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CppGamePath DecorateDividedConsumer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00簀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778382, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00紀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00蜀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00蠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778381, new IntPtr(2737337545004L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}
}
