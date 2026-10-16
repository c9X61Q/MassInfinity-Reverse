using System;
using System.Runtime.CompilerServices;

namespace Mass.Common;

public sealed class NonSecureAttribute : Attribute
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NonSecureAttribute()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}
}
