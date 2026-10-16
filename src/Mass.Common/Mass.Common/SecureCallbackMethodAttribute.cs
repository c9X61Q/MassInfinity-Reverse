using System;
using System.Runtime.CompilerServices;

namespace Mass.Common;

public sealed class SecureCallbackMethodAttribute : Attribute
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SecureCallbackMethodAttribute()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}
}
