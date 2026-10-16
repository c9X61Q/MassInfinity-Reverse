using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.Application.Event;
using Mass.Game.Proxy.Minecraft.Events.Play;
using Mass.Game.Proxy.Protocols.FakeForge;

namespace Mass.Game.Proxy.Protocols.Aely;

public class AelyProtocol : FakeForgeProtocol
{
	private static object DecorateResponsiveStrategy;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AelyProtocol()
	{
		//IL_004b: Expected I4, but got Obj
		//IL_0039->IL0042: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		AelyProtocol aelyProtocol = this;
		if (0 == 0)
		{
			aelyProtocol = (AelyProtocol)0;
		}
		switch ((int)aelyProtocol)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public override void OnServerPluginMessage(EventServerPluginMessage @event)
	{
		_FF00_FF00_FF00Ѐ(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PresentMapper()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AelyProtocol DecorateCombinedConfig()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00ﬀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778946, new IntPtr(2737368306908L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00ﰀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00ﴀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778973, new IntPtr(2737368321468L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FE00()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778972, new IntPtr(2737368318348L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00Ѐ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003e: Expected I4, but got Obj
		//IL_004f: Expected Obj, but got I4
		//IL_0054->IL0015: Incompatible stack heights: 2 vs 0
		//IL_00a3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00fb->IL00ff: Incompatible stack heights: 1 vs 0
		//IL_0066->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0084->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00d2->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0125->IL00ff: Incompatible stack heights: 1 vs 0
		//IL_0071->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00dd->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0130->IL00ff: Incompatible stack heights: 1 vs 0
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
				default:
					return;
				case 5:
					break;
				case 7:
					return;
				case 0:
					return;
				case 4:
					if (P_0 == null)
					{
						obj = P_0;
						if (2 == 0)
						{
							obj2 = 2;
						}
					}
					else if (false)
					{
						obj2 = 0;
					}
					continue;
				case 2:
					if (obj == null)
					{
						obj2 = 6;
						continue;
					}
					return;
				case 1:
					return;
				case 6:
					obj = obj;
					if (2 == 0)
					{
						obj2 = 3;
					}
					continue;
				case 3:
					obj = obj;
					if (1 == 0)
					{
						_ = 0;
					}
					while (true)
					{
						switch ((int)/*Error near IL_010c: Stack underflow*/)
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
				break;
			}
			obj = 4;
		}
	}
}
