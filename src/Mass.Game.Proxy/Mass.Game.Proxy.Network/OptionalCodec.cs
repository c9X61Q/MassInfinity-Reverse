using System;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;

namespace Mass.Game.Proxy.Network;

public static class OptionalCodec
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Optional<T> ReadOptional<T>(this IByteBuffer buffer, Func<IByteBuffer, T> reader)
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IByteBuffer WriteOptional<T>(this IByteBuffer buffer, Optional<T> optional, Action<T> writer)
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}
}
