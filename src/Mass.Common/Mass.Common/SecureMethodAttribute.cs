using System;
using System.Runtime.CompilerServices;

namespace Mass.Common;

public sealed class SecureMethodAttribute : Attribute
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SecureMethodAttribute()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}
}
