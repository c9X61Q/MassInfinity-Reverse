using System.Runtime.CompilerServices;

namespace Mass.Game.Proxy.Network;

public class Filterable<T>
{
	public readonly T Value;

	public readonly Optional<T> Optional;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Filterable(T value, Optional<T> optional)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}
}
