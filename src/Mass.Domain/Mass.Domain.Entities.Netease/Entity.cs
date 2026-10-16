using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Mass.Domain.Value;

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
			//IL_0017: Expected VT, but got Obj
			if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
			{
			}
			return (T?)this;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key != null)
			{
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Entity()
	{
		//IL_001a: Expected I4, but got Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		((BoolValue)/*Error near IL_001a: Stack underflow*/).Value = (byte)(int)this != 0;
	}
}
