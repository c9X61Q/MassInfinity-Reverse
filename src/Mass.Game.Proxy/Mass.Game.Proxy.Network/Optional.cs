using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

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
			//IL_0017: Expected I4, but got Obj
			_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
			if (((EqualityComparer<T>)(object)Regex).Default == null)
			{
			}
			return (byte)(int)this != 0;
		}
	}

	public unsafe T Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_001a: Expected VT, but got Obj
			//IL_001a: Expected VT, but got Ref
			//IL_002c: Expected VT, but got Obj
			//IL_0029: Expected VT, but got Obj
			if (((EqualityComparer<T>)(object)Regex).Default == null)
			{
			}
			if (((EqualityComparer<T>)/*Error near IL_001a: Stack underflow*/).Equals((T?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (T?)this))
			{
				return (T)this;
			}
			return (T)null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Optional()
	{
		//IL_001a: Expected VT, but got Obj
		//IL_001a: Expected VT, but got Ref
		//IL_0068: Expected native int or pointer, but got Obj
		//IL_007d: Expected Obj, but got VT
		//IL_005a->IL002d: Incompatible stack heights: 4 vs 2
		//IL_0065->IL002d: Incompatible stack heights: 4 vs 2
		if (((EqualityComparer<T>)(object)Regex).Default == null)
		{
		}
		((EqualityComparer<T>)/*Error near IL_001a: Stack underflow*/).Equals((T?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (T?)this);
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				_ = 0;
				_ = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
				{
					_ = 0;
				}
				break;
			case 1:
				return;
			default:
				Unsafe.Write((void*)(nint)this, null);
				num = 1;
				if (_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic == null)
				{
					num = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Optional(T value)
	{
		//IL_001a: Expected VT, but got Obj
		//IL_001a: Expected VT, but got Ref
		if (((EqualityComparer<T>)(object)Regex).Default == null)
		{
		}
		((EqualityComparer<T>)/*Error near IL_001a: Stack underflow*/).Equals((T?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (T?)this);
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
