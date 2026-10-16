using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Mass.Domain.Desktop.Converters;

public class SingleOrArrayConverter<T> : JsonConverter<List<T>>
{
	private static object CheckTransformableModule;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe override List<T> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions? options)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778225, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (List<T>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe override void Write(Utf8JsonWriter writer, List<T> value, JsonSerializerOptions options)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776462, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe SingleOrArrayConverter()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776461, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ResumeProgram()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ArrangeTemplate()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}
}
