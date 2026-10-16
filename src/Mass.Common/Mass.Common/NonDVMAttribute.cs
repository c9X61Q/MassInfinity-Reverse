using System;
using System.Runtime.CompilerServices;

namespace Mass.Common;

public sealed class NonDVMAttribute : Attribute
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NonDVMAttribute()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}
}
