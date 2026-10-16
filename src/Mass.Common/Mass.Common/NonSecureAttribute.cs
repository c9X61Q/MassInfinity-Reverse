using System;
using System.Runtime.CompilerServices;
using Mass.Common.Models;

namespace Mass.Common;

public sealed class NonSecureAttribute : Attribute
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NonSecureAttribute()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		/*Error near IL_0015: Member reference must be method, but was: Field*/;
	}
}
