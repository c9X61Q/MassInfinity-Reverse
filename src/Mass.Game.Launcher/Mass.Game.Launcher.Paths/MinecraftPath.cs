using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.Domain.Desktop.ValueObjects;

namespace Mass.Game.Launcher.Paths;

public class MinecraftPath
{
	public readonly string Root;

	public readonly string Versions;

	public readonly string Version;

	public readonly string VersionDat;

	public readonly string VersionJson;

	public readonly string VersionJar;

	public readonly string Natives;

	public readonly string GameAuthenticationDll;

	public readonly string Runtime;

	public readonly string Mods;

	public readonly string ModSettings;

	public readonly string WordV;

	public readonly string Libraries;

	public readonly string Assets;

	public readonly string Options;

	public readonly string OptionsShaders;

	internal static MinecraftPath CheckFilteredListener;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MinecraftPath(string mcPath, EnumGameVersion version)
	{
		//IL_013a: Expected Obj, but got I4
		//IL_00f0: Expected Obj, but got I4
		//IL_0109: Expected Obj, but got I4
		//IL_018b->IL001c: Incompatible stack heights: 3 vs 2
		//IL_01c8->IL001c: Incompatible stack heights: 4 vs 2
		//IL_016e->IL001c: Incompatible stack heights: 3 vs 2
		//IL_0120->IL001c: Incompatible stack heights: 3 vs 2
		//IL_00ec->IL001c: Incompatible stack heights: 5 vs 2
		//IL_014c->IL001c: Incompatible stack heights: 4 vs 2
		//IL_007f->IL001c: Incompatible stack heights: 4 vs 2
		//IL_015c->IL001c: Incompatible stack heights: 4 vs 2
		//IL_01e4->IL001c: Incompatible stack heights: 5 vs 2
		//IL_00ce->IL001c: Incompatible stack heights: 3 vs 2
		//IL_00b1->IL001c: Incompatible stack heights: 4 vs 2
		//IL_0091->IL001c: Incompatible stack heights: 3 vs 2
		//IL_01a8->IL001c: Incompatible stack heights: 3 vs 2
		//IL_0196->IL001c: Incompatible stack heights: 3 vs 2
		//IL_01d3->IL001c: Incompatible stack heights: 4 vs 2
		//IL_001c->IL001c: Incompatible stack heights: 4 vs 2
		//IL_0179->IL001c: Incompatible stack heights: 3 vs 2
		//IL_012b->IL001c: Incompatible stack heights: 3 vs 2
		//IL_00d9->IL001c: Incompatible stack heights: 3 vs 2
		//IL_00bc->IL001c: Incompatible stack heights: 4 vs 2
		//IL_009c->IL001c: Incompatible stack heights: 3 vs 2
		//IL_01b3->IL001c: Incompatible stack heights: 3 vs 2
		//IL_0207->IL001c: Incompatible stack heights: 3 vs 2
		//IL_0212->IL001c: Incompatible stack heights: 3 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		int num = 3;
		while (true)
		{
			MinecraftPath minecraftPath;
			MinecraftPath minecraftPath2;
			switch (num)
			{
			case 4:
				return;
			case 9:
				_ = 10;
				break;
			case 16:
				if (12 != 0)
				{
					_ = 6;
				}
				break;
			case 14:
				if (true)
				{
					_ = 0;
				}
				break;
			case 13:
				if (5 != 0)
				{
					_ = 0;
				}
				break;
			case 7:
				_ = 14;
				break;
			case 3:
			{
				object obj = version;
				num = 8;
				break;
			}
			case 15:
			{
				minecraftPath = this;
				minecraftPath2 = this;
				object obj = 17;
				break;
			}
			case 6:
				if (3 != 0)
				{
					_ = 4;
				}
				break;
			case 2:
			{
				minecraftPath = this;
				minecraftPath2 = this;
				object obj = 13;
				break;
			}
			case 8:
				_ = 2;
				break;
			case 10:
				_ = 16;
				break;
			case 5:
				if (5 == 0)
				{
					_ = 9;
				}
				break;
			default:
				if (15 == 0)
				{
					_ = 8;
				}
				break;
			case 17:
				if (6 == 0)
				{
					_ = 6;
				}
				break;
			case 1:
				if (6 == 0)
				{
					_ = 11;
				}
				break;
			case 12:
				_ = 7;
				break;
			case 11:
				if (version <= EnumGameVersion.V_1_20)
				{
				}
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return (string)_FF00Ⰰ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectAutomatedTracker()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MinecraftPath CheckPassiveFinalizer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_2B00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778373, new IntPtr(2737337539804L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00Ⰰ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00ⴀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778372, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_2E00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_2F00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778371, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00㴀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}
}
