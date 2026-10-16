using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.Domain.Desktop.ValueObjects;

namespace Mass.Game.Launcher.Java;

public class JavaLog
{
	public readonly string Disconnect;

	internal static JavaLog DecorateActiveEncryptor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JavaLog(EnumGameVersion version)
	{
		//IL_00db: Expected I4, but got Obj
		//IL_00c9->IL00d2: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		switch (version)
		{
		case EnumGameVersion.V_1_7_10:
		case EnumGameVersion.V_1_8_9:
		case EnumGameVersion.V_1_12_2:
		{
			object obj = (object)/*Error near IL_007e: Stack underflow*/;
			break;
		}
		case EnumGameVersion.V_1_18:
		case EnumGameVersion.V_1_20:
		{
			object obj = (object)/*Error near IL_0090: Stack underflow*/;
			break;
		}
		default:
		{
			object obj = (object)/*Error near IL_00a2: Stack underflow*/;
			break;
		}
		}
		JavaLog javaLog = this;
		if (false)
		{
			javaLog = (JavaLog)0;
		}
		switch ((int)javaLog)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SearchStruct()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static JavaLog DecorateLiteralFinder()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00紀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779108, new IntPtr(2737337592844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00縀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00舀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00茀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779107, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}
}
