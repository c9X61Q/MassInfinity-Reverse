using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Mass.Domain.Value;

namespace Mass.Domain.Entities.Netease;

public class Entities<T> : EntityResponse
{
	private static object RestartCollector;

	[JsonPropertyName("entities")]
	public T[] Data
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
			{
			}
			return (T[])(object)this;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_004f->IL0026: Incompatible stack heights: 3 vs 1
			//IL_005a->IL0026: Incompatible stack heights: 3 vs 1
			if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
			{
			}
			object obj = 1;
			while (true)
			{
				switch ((int)obj)
				{
				default:
					return;
				case 1:
					_ = 0;
					if (((ConfigValue)ConfigValue.Id__BackingField).Key__BackingField != null)
					{
						_ = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[JsonPropertyName("total")]
	public int Total
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			//IL_0017: Expected I4, but got Obj
			if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
			{
			}
			return (int)this;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0050->IL0026: Incompatible stack heights: 3 vs 1
			//IL_005b->IL0026: Incompatible stack heights: 3 vs 1
			if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
			{
			}
			object obj = 1;
			while (true)
			{
				switch ((int)obj)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_ = 0;
					if (((ConfigValue)ConfigValue.Id__BackingField).Key__BackingField != null)
					{
						_ = 0;
					}
					break;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Entities()
	{
		//IL_0035: Expected Obj, but got I4
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		((MemberInfo)(object)this).GetCustomAttribute<IntegerValueAttribute>();
		BoolValue.DecorateOperationalTracker();
		int num = 0;
		if (((ConfigValue)ConfigValue.Icon__BackingField).DisplayName__BackingField != null)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateDividedBridge()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CheckGeneralCommand()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}
}
