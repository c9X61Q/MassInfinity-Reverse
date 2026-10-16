using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Mass.Domain.Value;

namespace Mass.Domain.Entities.Netease.Opt;

public class EntityOpt
{
	internal static EntityOpt DecorateOperationalFinalizer;

	[JsonPropertyName("regex")]
	public required EntityOptRegex Regex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (EntityOptRegex)_FF00_FF00鐀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00鄀(value);
		}
	}

	[JsonPropertyName("settings")]
	public required EntityOptSettings Settings
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (EntityOptSettings)_FF00_FF00踀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00言(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe EntityOpt()
	{
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		_ = ((KeyValuePair<string, object>*)this)->Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool InstantiateError()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EntityOpt ReflectIdentifiableTag()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00褀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778398, new IntPtr(2737337558524L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00言(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
				BoolValueAttribute.DecorateIdentifiableAggregator = P_0;
				obj2 = 0;
				if (((ConfigValue)ConfigValue.Id__BackingField).Key__BackingField != null)
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
	internal unsafe void _FF00_FF00謀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778397, new IntPtr(2737337553324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00谀()
	{
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return BoolValueAttribute.DecorateIdentifiableAggregator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00贀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778396, new IntPtr(2737337561644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00踀()
	{
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return BoolValueAttribute.DecorateIdentifiableAggregator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00輀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778395, new IntPtr(2737337562684L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00退(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778394, new IntPtr(2737337561644L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00鄀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				BoolValueAttribute.DecorateIdentifiableAggregator = P_0;
				obj2 = 0;
				if (((ConfigValue)ConfigValue.Id__BackingField).Key__BackingField == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00鈀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778393, new IntPtr(2737337556444L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00錀()
	{
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return (BoolValueAttribute.DecorateIdentifiableAggregator == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00鐀()
	{
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return BoolValueAttribute.DecorateIdentifiableAggregator;
	}
}
