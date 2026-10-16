using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.Domain.Desktop.Entities.Mods;
using Mass.Game.Launcher.Java;

namespace Mass.Game.Launcher.Paths;

public class ServerModPath : GamePath
{
	public readonly string Resource;

	public readonly string ResourceMd5;

	public readonly string Mods;

	public readonly MinecraftPath Minecraft;

	public readonly EntitySubItemDownload Item;

	internal static ServerModPath DecorateExternalAggregator;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ServerModPath(EntityLaunchJavaGame args, string gameBase, EntityItemDownload download, EntitySubItemDownload subItem)
	{
		//IL_0046: Expected I4, but got Obj
		//IL_0020->IL0029: Incompatible stack types: I4 vs Obj
		//IL_00ac->IL0029: Incompatible stack heights: 3 vs 1
		//IL_007b->IL0029: Incompatible stack heights: 4 vs 1
		//IL_008c->IL0029: Incompatible stack heights: 2 vs 1
		//IL_00c8->IL0029: Incompatible stack heights: 4 vs 1
		//IL_005d->IL0029: Incompatible stack heights: 3 vs 1
		//IL_00b7->IL0029: Incompatible stack heights: 3 vs 1
		//IL_0097->IL0029: Incompatible stack heights: 2 vs 1
		//IL_0068->IL0029: Incompatible stack heights: 3 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		ServerModPath serverModPath = this;
		if (false)
		{
			serverModPath = (ServerModPath)5;
		}
		while (true)
		{
			switch ((int)serverModPath)
			{
			case 5:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 2:
				_ = 3;
				break;
			case 1:
				return;
			case 3:
				if (0 == 0)
				{
					_ = 1;
				}
				break;
			default:
				if (4 == 0)
				{
					_ = 3;
				}
				break;
			case 4:
				_ = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AdaptCommand()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerModPath CheckVirtualDefinition()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_A700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778370, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00ꠀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00꤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778369, new IntPtr(2737337545004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00ꨀ()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}
}
