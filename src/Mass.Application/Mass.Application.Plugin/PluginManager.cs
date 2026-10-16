using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Mass.Application.Plugin;

public class PluginManager
{
	public static readonly PluginManager Instance = new PluginManager();

	private readonly List<IPlugin> _loaded;

	private static object DecorateRemoteDispatcher;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Load(List<IPlugin> plugins)
	{
		_FF00_FF00_FF00_E600(plugins);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Unload(List<IPlugin> plugins)
	{
		_FF00_FF00_FF00_E400(plugins);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Load(IPlugin plugin)
	{
		_FF00_FF00_FF00_E300(plugin);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Unload(IPlugin plugin)
	{
		_FF00_FF00_FF00_E200(plugin);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PluginManager()
	{
		_ = ref _003C_003Ef__AnonymousType0<, , , , >._003Cusername_003Ei__Field;
		/*Error near IL_0006: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectActiveSingleton()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PluginManager DecorateJoinedParser()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_E100(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778819, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_E200(object P_0)
	{
		_ = ref _003C_003Ef__AnonymousType0<, , , , >._003Cusername_003Ei__Field;
		/*Error near IL_0006: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_E300(object P_0)
	{
		_ = ref _003C_003Ef__AnonymousType0<, , , , >._003Cusername_003Ei__Field;
		/*Error near IL_0006: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_E400(List<IPlugin> P_0)
	{
		_ = ref _003C_003Ef__AnonymousType0<, , , , >._003Cusername_003Ei__Field;
		/*Error near IL_0006: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_E500(List<IPlugin> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778818, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_E600(List<IPlugin> P_0)
	{
		_ = ref _003C_003Ef__AnonymousType0<, , , , >._003Cusername_003Ei__Field;
		/*Error near IL_0006: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_E700(List<IPlugin> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778817, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_E800()
	{
		_ = ref _003C_003Ef__AnonymousType0<, , , , >._003Cusername_003Ei__Field;
		/*Error near IL_0006: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_E900()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778816, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_EA00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778823, new IntPtr(2737337475324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_EB00()
	{
		_ = ref _003C_003Ef__AnonymousType0<, , , , >._003Cusername_003Ei__Field;
		/*Error near IL_0006: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_EC00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778822, new IntPtr(2737337470124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
