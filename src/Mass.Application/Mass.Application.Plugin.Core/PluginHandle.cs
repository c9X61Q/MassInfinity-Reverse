using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Mass.Application.Plugin.Core;

public class PluginHandle
{
	private object? _assembly;

	private readonly object _context;

	private static object ReceiveRecommender;

	public List<IPlugin> Instances
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00ꨀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			_FF00꼀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PluginHandle(string path)
	{
		//IL_0043: Expected I4, but got Obj
		//IL_0031->IL003a: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		PluginHandle pluginHandle = this;
		if (0 == 0)
		{
			pluginHandle = (PluginHandle)0;
		}
		switch ((int)pluginHandle)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Load()
	{
		_FF00가();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Unload()
	{
		_FF00넀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MonitorAnalyzer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PluginHandle DecorateModularSynchronizer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00ꔀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778821, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00ꘀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_A700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778820, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00ꠀ()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00꤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778827, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<IPlugin> _FF00ꨀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (List<IPlugin>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<IPlugin> _FF00_AB00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778826, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
		return (List<IPlugin>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00가()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_006b: Expected Obj, but got I4
		//IL_00a1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00bc->IL0019: Incompatible stack heights: 3 vs 1
		//IL_005a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ac->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ee->IL0019: Incompatible stack heights: 3 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					return;
				case 4:
					obj2 = this;
					if (1 == 0)
					{
						obj2 = 1;
					}
					break;
				case 1:
					return;
				case 3:
					if (this != null)
					{
						return;
					}
					goto end_IL_0019;
				case 6:
					_ = 1;
					if (4 == 0)
					{
						_ = 4;
					}
					break;
				case 0:
					return;
				case 2:
					_ = 5;
					break;
				case 5:
				{
					PluginHandle pluginHandle = this ?? this;
					if (pluginHandle == null)
					{
						pluginHandle = this;
					}
					_ = 6;
					break;
				}
				}
				continue;
				end_IL_0019:
				break;
			}
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00관()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778825, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00글(List<IPlugin> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778824, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00꼀(List<IPlugin> P_0)
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
	internal unsafe void _FF00뀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778831, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00넀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003e: Expected I4, but got Obj
		//IL_00ae->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ba->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0095->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0077->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0088->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00db->IL0019: Incompatible stack heights: 2 vs 1
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
				obj2 = this;
				if (2 == 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				_ = null;
				if (false)
				{
					_ = 4;
				}
				break;
			case 6:
				if (this == null)
				{
					obj2 = 5;
					break;
				}
				_ = 0;
				if (false)
				{
					_ = 0;
				}
				break;
			case 7:
				if (1 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				_ = 3;
				break;
			case 4:
				return;
			case 2:
				obj2 = 7;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00눀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778830, new IntPtr(2737337475324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
