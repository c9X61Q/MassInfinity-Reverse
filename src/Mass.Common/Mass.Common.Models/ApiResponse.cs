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
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		/*Error near IL_0015: Member reference must be method, but was: Field*/;
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
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return new SecureCallbackMethodAttribute();
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
	[CompilerGenerated]
	private T? Data__BackingField;

	public T? Data
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			//IL_0017: Expected VT, but got Obj
			((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (T?)this;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ != 0)
			{
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ApiResponse<T> SetData(T data)
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		/*Error near IL_0016: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ApiResponse()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		/*Error near IL_0015: Member reference must be method, but was: Field*/;
	}
}
