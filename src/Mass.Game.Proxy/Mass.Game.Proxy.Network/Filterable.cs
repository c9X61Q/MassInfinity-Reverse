using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Mass.Game.Proxy.Network;

public class Filterable<T>
{
	public readonly T Value;

	public readonly Optional<T> Optional;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Filterable(T value, Optional<T> optional)
	{
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<T>)(object)Regex).Default == null)
		{
		}
		base.ToString();
	}
}
