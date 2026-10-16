using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace Mass.Domain.Entities.Netease;

public class Entities<T> : EntityResponse
{
	private static object RestartCollector;

	[JsonPropertyName("entities")]
	public T[] Data
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (T[])(object)this;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0045->IL0019: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			while (true)
			{
				switch ((int)obj)
				{
				default:
					return;
				case 1:
					if (false)
					{
						_ = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[JsonPropertyName("total")]
	public int Total
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			//IL_000a: Expected I4, but got Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (int)this;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			while (true)
			{
				switch ((int)obj)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					if (false)
					{
						_ = 0;
					}
					break;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Entities()
	{
		//IL_003a: Expected I4, but got Obj
		//IL_0028->IL0031: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		Entities<T> entities = this;
		if (false)
		{
			entities = (Entities<T>)0;
		}
		switch ((int)entities)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateDividedBridge()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CheckGeneralCommand()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}
}
