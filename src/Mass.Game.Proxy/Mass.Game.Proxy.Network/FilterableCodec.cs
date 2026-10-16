using System;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;

namespace Mass.Game.Proxy.Network;

public static class FilterableCodec
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Filterable<T> ReadFilterable<T>(this IByteBuffer buffer, Func<IByteBuffer, T> reader)
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IByteBuffer WriteFilterable<T>(this IByteBuffer buffer, Filterable<T> filterable, Action<T> writer)
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}
}
