using System;
using System.Runtime.CompilerServices;

namespace Mass.Domain.Desktop.Models;

public class PageModel<T>
{
	internal static object ReflectStatelessBridge;

	public T[] Items
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
					if (0 == 0)
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

	public int TotalPage
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
					if (0 == 0)
					{
						_ = 0;
					}
					break;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PageModel()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MatchEnumerator()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AssembleParameter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}
}
