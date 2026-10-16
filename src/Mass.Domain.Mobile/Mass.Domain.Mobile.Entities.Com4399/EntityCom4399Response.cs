using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace Mass.Domain.Mobile.Entities.Com4399;

public class EntityCom4399Response<T>
{
	private static object? CheckSetController;

	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	[JsonPropertyName("code")]
	public unsafe int Code
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778908, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
			return (int)/*Error near IL_0033: Stack underflow*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778909, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[JsonPropertyName("message")]
	public unsafe string Message
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778906, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
			return (string)/*Error near IL_0033: Stack underflow*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778907, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[JsonPropertyName("result")]
	public unsafe T? Result
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778904, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
			return (T?)/*Error near IL_0033: Stack underflow*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778905, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe EntityCom4399Response()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778900, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectEfficientFinder()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object? CheckAttachedAllocator()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}
}
