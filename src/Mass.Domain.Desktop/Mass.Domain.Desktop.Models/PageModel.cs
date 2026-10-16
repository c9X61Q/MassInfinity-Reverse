using System;
using System.Runtime.CompilerServices;
using Mass.Domain.Desktop.ValueObjects;

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
			Unsafe.As<int, object>(ref EnumGameClientType.value__)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (T[])(object)this;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_004f->IL0026: Incompatible stack heights: 3 vs 1
			//IL_005a->IL0026: Incompatible stack heights: 3 vs 1
			Unsafe.As<int, object>(ref EnumGameClientType.value__)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					_ = 0;
					if (EnumGameType.None == (EnumGameType)0)
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
			//IL_0017: Expected I4, but got Obj
			Unsafe.As<int, object>(ref EnumGameClientType.value__)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (int)this;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0050->IL0026: Incompatible stack heights: 3 vs 1
			//IL_005b->IL0026: Incompatible stack heights: 3 vs 1
			Unsafe.As<int, object>(ref EnumGameClientType.value__)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					_ = 0;
					if (EnumGameType.None == (EnumGameType)0)
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
		Unsafe.As<int, object>(ref EnumGameClientType.value__)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		/*Error near IL_0015: Member reference must be method, but was: Field*/;
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
