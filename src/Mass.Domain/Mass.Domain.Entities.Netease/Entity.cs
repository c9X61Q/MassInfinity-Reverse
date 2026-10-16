using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace Mass.Domain.Entities.Netease;

public class Entity<T> : EntityResponse
{
	[JsonPropertyName("entity")]
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
	public Entity()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}
}
