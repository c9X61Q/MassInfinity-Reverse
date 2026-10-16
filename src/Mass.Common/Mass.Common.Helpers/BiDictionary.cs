using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Mass.Common.Helpers;

public class BiDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
{
	private readonly Dictionary<TKey, TValue> _forward;

	private readonly Dictionary<TValue, TKey> _reverse;

	internal static object ExecuteViewer;

	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_000b: Expected I4, but got Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (int)this;
		}
	}

	public IEnumerable<TKey> Keys
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (IEnumerable<TKey>)this;
		}
	}

	public IEnumerable<TValue> Values
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (IEnumerable<TValue>)this;
		}
	}

	public TValue this[TKey key]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (TValue)key;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
			{
			}
		}
	}

	public TKey this[TValue valueParam]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (TKey)valueParam;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
			{
			}
		}
	}

	public BiDictionary<TValue, TKey> InverseView
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (BiDictionary<TValue, TKey>)(object)this;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(TKey key, TValue value)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = default;
		if ((int)key != 0)
		{
			_ = ref obj;
			_ = 20;
			_ = 1;
			_ = ref obj;
			_ = ref obj;
			throw ref obj;
		}
		if ((int)value != 0)
		{
			_ = ref obj;
			_ = 22;
			_ = 1;
			_ = ref obj;
			_ = ref obj;
			throw ref obj;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryAdd(TKey key, TValue value)
	{
		//IL_0019->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		if ((int)key != 0 || (int)value != 0)
		{
			return false;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe void Set(TKey key, TValue value)
	{
		//IL_0017->IL0017: Incompatible stack heights: 3 vs 2
		//IL_0027->IL0027: Incompatible stack heights: 5 vs 4
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = default;
		if (&obj != null)
		{
		}
		if (&obj == null)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe bool TryGetValue(TKey key, out TValue value)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)Unsafe.AsPointer(ref value) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe bool TryGetKey(TValue value, out TKey key)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)Unsafe.AsPointer(ref key) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe TValue? GetValueOrDefault(TKey key, TValue? defaultValue = default(TValue?))
	{
		//IL_0016: Expected VT, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = default;
		if (&obj == null)
		{
			return defaultValue;
		}
		return (TValue?)obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe TKey? GetKeyOrDefault(TValue value, TKey? defaultKey = default(TKey?))
	{
		//IL_0016: Expected VT, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = default;
		if (&obj == null)
		{
			return defaultKey;
		}
		return (TKey?)obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsKey(TKey key)
	{
		//IL_000c: Expected I4, but got VT
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)key != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsValue(TValue value)
	{
		//IL_000c: Expected I4, but got VT
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)value != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe bool RemoveByKey(TKey key)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = default;
		if (&obj == null)
		{
			return false;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe bool RemoveByValue(TValue value)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = default;
		if (&obj == null)
		{
			return false;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0063->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 2:
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (IEnumerator<KeyValuePair<TKey, TValue>>)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (IEnumerator)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BiDictionary(Dictionary<TKey, TValue> fwd, Dictionary<TValue, TKey> rev)
	{
		//IL_004a: Expected I4, but got Obj
		//IL_0030->IL0039: Incompatible stack types: I4 vs Obj
		//IL_0078->IL0039: Incompatible stack heights: 4 vs 3
		//IL_005e->IL0039: Incompatible stack heights: 4 vs 3
		//IL_0083->IL0039: Incompatible stack heights: 4 vs 3
		//IL_0069->IL0039: Incompatible stack heights: 4 vs 3
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		BiDictionary<TKey, TValue> biDictionary = this;
		if (false)
		{
			biDictionary = (BiDictionary<TKey, TValue>)0;
		}
		while (true)
		{
			switch ((int)biDictionary)
			{
			case 1:
				if (2 != 0)
				{
					_ = 2;
				}
				break;
			default:
				if (1 == 0)
				{
					_ = 1;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BiDictionary()
	{
		//IL_0042: Expected I4, but got Obj
		//IL_0030->IL0039: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		BiDictionary<TKey, TValue> biDictionary = this;
		if (0 == 0)
		{
			biDictionary = (BiDictionary<TKey, TValue>)0;
		}
		switch ((int)biDictionary)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DetachCalculator()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CheckAccessibleSolver()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}
}
