using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Microsoft.Windows.ApplicationModel.WindowsAppRuntime.Common;

internal class AutoInitialize
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[ModuleInitializer]
	internal static void InitializeWindowsAppSDK()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AutoInitialize()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00_FF00錀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775325, new IntPtr(2737323022636L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_FF00_FF00_FF00_FF00鐀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}
}
