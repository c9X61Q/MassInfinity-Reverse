using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Mass.Common.Helpers;

public class ReverseOrderedSetJsonConverter<T> : JsonConverter<ReverseOrderedSet<T>>
{
	private static object ObserveConsumer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe override ReverseOrderedSet<T> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778771, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		return (ReverseOrderedSet<T>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe override void Write(Utf8JsonWriter writer, ReverseOrderedSet<T> value, JsonSerializerOptions options)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778770, new IntPtr(2737337521084L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe ReverseOrderedSetJsonConverter()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778775, new IntPtr(2737337521084L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectAdjustableAggregator()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WriteSorter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}
}
