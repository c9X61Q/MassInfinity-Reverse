using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.Domain.Desktop.ValueObjects;

namespace Mass.Game.Launcher.Java.Option;

public class JavaGameOptionKey
{
	public readonly string ResourcePacks;

	public readonly string Language;

	public readonly string WindowWidth;

	public readonly string WindowHeight;

	public readonly string GuiScale;

	public readonly string AutoJump;

	public readonly string Narrator;

	public readonly string OnboardAccessibility;

	internal static JavaGameOptionKey ReflectSymbolicWriter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JavaGameOptionKey(EnumGameVersion version)
	{
		//IL_0072: Expected I4, but got Obj
		//IL_0060->IL0069: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		JavaGameOptionKey javaGameOptionKey = this;
		if (0 == 0)
		{
			javaGameOptionKey = (JavaGameOptionKey)0;
		}
		switch ((int)javaGameOptionKey)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateConfigurableDic()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static JavaGameOptionKey ReflectSeparatedObject()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00漀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779293, new IntPtr(2737367907804L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00瀀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00礀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00稀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779292, new IntPtr(2737367895324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}
}
