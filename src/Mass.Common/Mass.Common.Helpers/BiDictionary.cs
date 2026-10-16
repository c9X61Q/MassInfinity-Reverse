using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Mass.Common.Models;

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
			//IL_001b: Expected VT, but got Obj
			((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			((ApiResponse<TKey>)/*Error near IL_001b: Stack underflow*/).Data = (TKey?)this;
			return (int)/*Error near IL_001c: Stack underflow*/;
		}
	}

	public IEnumerable<TKey> Keys
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_001b: Expected VT, but got Obj
			((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			((ApiResponse<TKey>)/*Error near IL_001b: Stack underflow*/).Data = (TKey?)this;
			return (IEnumerable<TKey>)/*Error near IL_001c: Stack underflow*/;
		}
	}

	public IEnumerable<TValue> Values
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_001b: Expected VT, but got Obj
			((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			((ApiResponse<TKey>)/*Error near IL_001b: Stack underflow*/).Data = (TKey?)this;
			return (IEnumerable<TValue>)/*Error near IL_001c: Stack underflow*/;
		}
	}

	public TValue this[TKey key]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			((ApiResponse<TKey>)(object)this).Data = key;
			return (TValue)/*Error near IL_001d: Stack underflow*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			/*Error near IL_0017: Member reference must be method, but was: Field*/;
		}
	}

	public TKey this[TValue valueParam]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			((ApiResponse<TKey>)(object)this).Data = (TKey?)valueParam;
			return (TKey)/*Error near IL_001d: Stack underflow*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			/*Error near IL_0017: Member reference must be method, but was: Field*/;
		}
	}

	public BiDictionary<TValue, TKey> InverseView
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (BiDictionary<TValue, TKey>)(object)new ApiResponseBase<ApiResponse<TKey>>();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe void Add(TKey key, TValue value)
	{
		//IL_002b: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got Ref
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((ApiResponse<TKey>)(object)this).Data = key;
		if ((int)/*Error near IL_0021: Stack underflow*/ != 0)
		{
			object obj = default;
			_ = ref obj;
			_ = 20;
			((ApiResponseBase<ApiResponse<TKey>>)1)._002Ector();
			((NonDVMAttribute)(&obj))._002Ector();
			/*Error near IL_0032: Member reference must be method, but was: Field*/;
		}
		/*Error near IL_004f: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryAdd(TKey key, TValue value)
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((ApiResponse<TKey>)(object)this).Data = key;
		if ((int)/*Error near IL_0021: Stack underflow*/ == 0)
		{
			/*Error near IL_0024: Member reference must be method, but was: Field*/;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe void Set(TKey key, TValue value)
	{
		//IL_001e: Expected VT, but got Ref
		//IL_001e: Expected Obj, but got VT
		//IL_0036: Expected Obj, but got VT
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = default;
		((ApiResponse<TKey>)key).Data = (TKey?)(&obj);
		if (this != null)
		{
			/*Error near IL_0026: Member reference must be method, but was: Field*/;
		}
		((ApiResponseBase<TKey>)value).Code = (int)(&obj);
		if (this != null)
		{
			/*Error near IL_003e: Member reference must be method, but was: Field*/;
		}
		/*Error near IL_0048: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe bool TryGetValue(TKey key, out TValue value)
	{
		//IL_001d: Expected VT, but got Ref
		//IL_001d: Expected Obj, but got VT
		//IL_001e: Expected I4, but got Obj
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((ApiResponse<TKey>)key).Data = (TKey?)Unsafe.AsPointer(ref value);
		return (byte)(int)this != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe bool TryGetKey(TValue value, out TKey key)
	{
		//IL_001d: Expected VT, but got Ref
		//IL_001d: Expected Obj, but got VT
		//IL_001e: Expected I4, but got Obj
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((ApiResponse<TKey>)value).Data = (TKey?)Unsafe.AsPointer(ref key);
		return (byte)(int)this != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe TValue? GetValueOrDefault(TKey key, TValue? defaultValue = default(TValue?))
	{
		//IL_001e: Expected VT, but got Ref
		//IL_001e: Expected Obj, but got VT
		//IL_0027: Expected VT, but got Obj
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = default;
		((ApiResponse<TKey>)key).Data = (TKey?)(&obj);
		if (this == null)
		{
			return defaultValue;
		}
		return (TValue?)obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe TKey? GetKeyOrDefault(TValue value, TKey? defaultKey = default(TKey?))
	{
		//IL_001e: Expected VT, but got Ref
		//IL_001e: Expected Obj, but got VT
		//IL_0027: Expected VT, but got Obj
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = default;
		((ApiResponse<TKey>)value).Data = (TKey?)(&obj);
		if (this == null)
		{
			return defaultKey;
		}
		return (TKey?)obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsKey(TKey key)
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((ApiResponse<TKey>)(object)this).Data = key;
		return (byte)/*Error near IL_001d: Stack underflow*/ != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsValue(TValue value)
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((ApiResponse<TKey>)(object)this).Data = (TKey?)value;
		return (byte)/*Error near IL_001d: Stack underflow*/ != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe bool RemoveByKey(TKey key)
	{
		//IL_001e: Expected VT, but got Ref
		//IL_001e: Expected Obj, but got VT
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = default;
		((ApiResponse<TKey>)key).Data = (TKey?)(&obj);
		if (this == null)
		{
			return false;
		}
		/*Error near IL_0028: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe bool RemoveByValue(TValue value)
	{
		//IL_001e: Expected VT, but got Ref
		//IL_001e: Expected Obj, but got VT
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = default;
		((ApiResponse<TKey>)value).Data = (TKey?)(&obj);
		if (this == null)
		{
			return false;
		}
		/*Error near IL_0028: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0069: Expected I4, but got Obj
		//IL_0043: Expected VT, but got Obj
		//IL_007d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0057->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0088->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0062->IL0026: Incompatible stack types: I4 vs Obj
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				((ApiResponse<TKey>)/*Error near IL_0043: Stack underflow*/).Data = (TKey?)this;
				obj2 = 1;
				if (((ApiResponseBase<>._003CThen_003Ed__10)ApiResponseBase<>._003CThen_003Ed__10._003C_003Et__builder).task == null)
				{
					obj2 = 0;
				}
				break;
			case 1:
				((ApiResponseBase<TKey>)/*Error near IL_0069: Stack underflow*/).Code = (int)this;
				obj2 = 0;
				if (((ErrorResponse)ErrorResponse.Type__BackingField).Title__BackingField == null)
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
		//IL_001b: Expected VT, but got Obj
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((ApiResponse<TKey>)/*Error near IL_001b: Stack underflow*/).Data = (TKey?)this;
		return (IEnumerator<KeyValuePair<TKey, TValue>>)(object)(TKey)/*Error near IL_0020: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		/*Error near IL_0015: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BiDictionary(Dictionary<TKey, TValue> fwd, Dictionary<TValue, TKey> rev)
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		/*Error near IL_0015: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BiDictionary()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		/*Error near IL_0015: Member reference must be method, but was: Field*/;
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
