using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Mass.Application.Plugin.Core;

public class PluginHandleManager
{
	private readonly Dictionary<string, PluginHandle> _loaded;

	internal static PluginHandleManager LeadNotifier;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Load(string path)
	{
		_FF00ꌀ(path);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Unload(string path)
	{
		_FF00鼀(path);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PluginHandleManager()
	{
		//IL_003a: Expected I4, but got Obj
		//IL_0028->IL0031: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		PluginHandleManager pluginHandleManager = this;
		if (0 == 0)
		{
			pluginHandleManager = (PluginHandleManager)0;
		}
		switch ((int)pluginHandleManager)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateAccessibleSystem()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PluginHandleManager ReflectIsolatedRole()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00鴀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778829, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00鸀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00鼀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0089->IL0037: Incompatible stack heights: 2 vs 0
		//IL_006e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0095->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0052->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a0->IL0019: Incompatible stack heights: 2 vs 1
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
				return;
			case 2:
				obj2 = obj;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			case 1:
				return;
			case 3:
				if (&obj == null)
				{
					return;
				}
				if (2 == 0)
				{
					_ = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ꀀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778828, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00ꄀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00ꈀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778867, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00ꌀ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00a2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007e->IL0059: Incompatible stack heights: 1 vs 0
		//IL_004d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_006a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0058->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0075->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0095->IL0019: Incompatible stack types: I4 vs Obj
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
				return;
			case 5:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			case 4:
				return;
			case 2:
				obj = P_0;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			case 3:
				obj2 = this;
				if (P_0 != null)
				{
					return;
				}
				if (2 != 0)
				{
					obj2 = 2;
				}
				break;
			case 1:
				_ = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ꐀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778866, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
