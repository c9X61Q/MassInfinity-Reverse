using System;
using System.Runtime.CompilerServices;

namespace Mass.Common;

public sealed class NonHVMProxyAttribute : Attribute
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NonHVMProxyAttribute()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}
}
