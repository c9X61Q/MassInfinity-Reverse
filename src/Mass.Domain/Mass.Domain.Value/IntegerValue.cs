using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Mass.Domain.Value;

public class IntegerValue : ConfigValue
{
	internal static IntegerValue? DecorateBasicGateway;

	public string? Unit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string?)_FF00_FF00_FF00ꐀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00鴀(value);
		}
	}

	public int Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00鼀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00ꄀ((uint)value);
		}
	}

	public int Min
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00ꈀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00꤀((uint)value);
		}
	}

	public int Max
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00餀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00鬀((uint)value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IntegerValue()
	{
		//IL_001a: Expected I4, but got Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		((BoolValue)/*Error near IL_001a: Stack underflow*/).Value = (byte)(int)this != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckReadableProfiler()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntegerValue? SetSingleton()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00頀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778610, new IntPtr(2737337565804L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00餀()
	{
		//IL_001b: Expected I4, but got Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return (uint)(int)BoolValueAttribute.DecorateIdentifiableAggregator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00騀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778609, new IntPtr(2737337538764L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00鬀(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected Obj, but got I4
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
	internal unsafe void _FF00_FF00_FF00鰀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778608, new IntPtr(2737337556444L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00鴀(object? P_0)
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
	internal unsafe void _FF00_FF00_FF00鸀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778607, new IntPtr(2737337536684L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00鼀()
	{
		//IL_001b: Expected I4, but got Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return (uint)(int)BoolValueAttribute.DecorateIdentifiableAggregator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00ꀀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778606, new IntPtr(2737337535644L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00ꄀ(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected Obj, but got I4
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
				if (((ConfigValue)ConfigValue.Id__BackingField).Key__BackingField == null)
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
	internal uint _FF00_FF00_FF00ꈀ()
	{
		//IL_001b: Expected I4, but got Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return (uint)(int)BoolValueAttribute.DecorateIdentifiableAggregator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00ꌀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778605, new IntPtr(2737337536684L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object? _FF00_FF00_FF00ꐀ()
	{
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return BoolValueAttribute.DecorateIdentifiableAggregator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object? _FF00_FF00_FF00ꔀ()
	{
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return BoolValueAttribute.DecorateIdentifiableAggregator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00ꘀ()
	{
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return (BoolValueAttribute.DecorateIdentifiableAggregator == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_A700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778604, new IntPtr(2737337560604L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00ꠀ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778603, new IntPtr(2737337550204L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00꤀(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected Obj, but got I4
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
				if (((ConfigValue)ConfigValue.Id__BackingField).Key__BackingField == null)
				{
					obj2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}
}
