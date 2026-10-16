using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;

namespace Mass.Game.Proxy.Network;

public static class PrefixedArray
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<T> ReadPrefixedArray<T>(this IByteBuffer buffer, Func<IByteBuffer, T> reader)
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IByteBuffer WritePrefixedArray<T>(this IByteBuffer buffer, List<T> list, Action<T> writer)
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}
}
