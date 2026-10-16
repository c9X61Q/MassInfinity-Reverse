using System;
using System.Runtime.CompilerServices;

namespace Mass.Game.Proxy.Network;

public class Optional<T>
{
	private readonly T _value;

	private static readonly Optional<T> E = new Optional<T>();

	internal static object CheckSortedClient;

	public bool HasValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			//IL_000a: Expected I4, but got Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (byte)(int)this != 0;
		}
	}

	public T Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0016: Expected VT, but got Obj
			//IL_0013: Expected VT, but got Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			if (this == null)
			{
				object obj = default;
				_ = ref obj;
				return (T)obj;
			}
			return (T)this;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Optional()
	{
		//IL_002d: Expected I4, but got Obj
		//IL_0013->IL001c: Incompatible stack types: I4 vs Obj
		//IL_0041->IL001c: Incompatible stack heights: 3 vs 2
		//IL_0067->IL001c: Incompatible stack types: I4 vs Obj
		//IL_004c->IL001c: Incompatible stack heights: 3 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		Optional<T> optional = (Optional<T>)2;
		while (true)
		{
			switch ((int)optional)
			{
			case 2:
				_ = 0;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 1:
				return;
			default:
				optional = this;
				if (1 == 0)
				{
					optional = (Optional<T>)1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Optional(T value)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_ = 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Optional<T> Of(T value)
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Optional<T> Empty()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateCombinedListener()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ViewFormatter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}
}
