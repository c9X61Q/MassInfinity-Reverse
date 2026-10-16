using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;

namespace Mass.Game.Proxy.Network;

public static class Map
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<TKey, TValue> ReadMap<TKey, TValue>(this IByteBuffer buffer, Func<IByteBuffer, TKey> keyReader, Func<IByteBuffer, TValue> valueReader) where TKey : notnull
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IByteBuffer WriteMap<TKey, TValue>(this IByteBuffer buffer, Dictionary<TKey, TValue> dictionary, Action<TKey> keyWriter, Action<TValue> valueWriter) where TKey : notnull
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}
}
