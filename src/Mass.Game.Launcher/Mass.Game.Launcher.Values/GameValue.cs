using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Domain.Value;

namespace Mass.Game.Launcher.Values;

public class GameValue
{
	private static object CheckSimpleMapper;

	[IntegerValue(1, 16, 8, "线程")]
	[ConfigValue(ValueIcon.DataUsage, "max-concurrency", "最大下载线程", "设置启动游戏时同时执行的最大下载任务数量，影响下载速度和网络占用.")]
	public int MaxConcurrency
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00䴀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00倀((uint)value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<ConfigValue> GetDesktopValue(string gameId, EnumGameVersion version)
	{
		return _FF00䘀(gameId, version);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<ConfigValue> GetMobileValue(string gameId)
	{
		return _FF00䬀(gameId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameValue()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckControllablePolicy()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GameValue TrackDecorator()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static List<ConfigValue> _FF00䔀(object P_0, EnumGameVersion P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778485, new IntPtr(2737337545004L), 15))(null, 0, new IntPtr(0L));
		return (List<ConfigValue>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static List<ConfigValue> _FF00䘀(object P_0, EnumGameVersion P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003e: Expected I4, but got Obj
		//IL_0055: Expected Obj, but got I4
		//IL_00c8: Expected Obj, but got I4
		//IL_0061->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00d2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00ba->IL0019: Incompatible stack heights: 0 vs 1
		//IL_006c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e5->IL0019: Incompatible stack heights: 0 vs 1
		//IL_009d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00f0->IL0019: Incompatible stack types: I4 vs Obj
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
				obj = 1;
				if (1 == 0)
				{
					obj2 = 3;
				}
				break;
			default:
				if (P_1 == EnumGameVersion.V_RTX)
				{
					if (2 != 0)
					{
						obj2 = 1;
					}
					break;
				}
				goto case 5;
			case 4:
				throw /*Error near IL_009f: Stack underflow*/;
			case 7:
				return (List<ConfigValue>)/*Error near IL_00a3: Stack underflow*/;
			case 1:
				if (P_1 != EnumGameVersion.V_CPP)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 2;
			case 5:
				obj = 0;
				obj2 = 6;
				break;
			case 3:
			case 6:
				if (obj == null)
				{
					if (7 == 0)
					{
						obj2 = 6;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00䜀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00䠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778484, new IntPtr(2737337562684L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00䤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778483, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00䨀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static List<ConfigValue> _FF00䬀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4125, 1790778482, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778482, new IntPtr(2737337554364L), 15);
		}
		return (List<ConfigValue>)((delegate*<object, object>)obj)(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static List<ConfigValue> _FF00䰀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778481, new IntPtr(2737337562684L), 15))(null, 0, new IntPtr(0L));
		return (List<ConfigValue>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00䴀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00一()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778480, new IntPtr(2737337551244L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00伀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778479, new IntPtr(2737337562684L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00倀(uint P_0)
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
	internal unsafe void _FF00儀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778478, new IntPtr(2737337545004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
