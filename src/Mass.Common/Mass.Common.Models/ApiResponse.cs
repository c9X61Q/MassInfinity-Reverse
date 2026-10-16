using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Mass.Common.Models;

public class ApiResponse : ApiResponseBase<ApiResponse>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ApiResponse Create()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ApiResponse<T> Create<T>()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ApiResponse()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00昀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778483, new IntPtr(2737337528364L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00最()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00栀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778482, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
public class ApiResponse<T> : ApiResponseBase<ApiResponse<T>>
{
	public T? Data
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			//IL_000a: Expected VT, but got Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (T?)this;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
			{
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ApiResponse<T> SetData(T data)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ApiResponse()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}
}
