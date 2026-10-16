using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Mass.Domain.Value;

[AttributeUsage(AttributeTargets.Property)]
public class FloatValueAttribute : Attribute
{
	private static object? DecorateCommonChain;

	public float MinValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_2300();
		}
	}

	public float MaxValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_2000();
		}
	}

	public float DefaultValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00ᰀ();
		}
	}

	public string? Unit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string?)_FF00_FF00_FF00_2400();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FloatValueAttribute(float minValue, float maxValue, float defaultValue, string? unit = null)
	{
		//IL_0053: Expected I4, but got Obj
		//IL_0041->IL004a: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		FloatValueAttribute floatValueAttribute = this;
		if (0 == 0)
		{
			floatValueAttribute = (FloatValueAttribute)0;
		}
		switch ((int)floatValueAttribute)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectAdaptableEnumerator()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FloatValueAttribute? ReflectPortableParameter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe float _FF00_FF00_FF00_1B00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778616, new IntPtr(2737337550204L), 15))(null, 0, new IntPtr(0L));
		return (float)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal float _FF00_FF00_FF00ᰀ()
	{
		//IL_000a: Expected F4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (float)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe float _FF00_FF00_FF00ᴀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778615, new IntPtr(2737337561644L), 15))(null, 0, new IntPtr(0L));
		return (float)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object? _FF00_FF00_FF00Ḁ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object?)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe float _FF00_FF00_FF00ἀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778614, new IntPtr(2737337539804L), 15))(null, 0, new IntPtr(0L));
		return (float)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal float _FF00_FF00_FF00_2000()
	{
		//IL_000a: Expected F4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (float)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe float _FF00_FF00_FF00_2100()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778613, new IntPtr(2737337541884L), 15))(null, 0, new IntPtr(0L));
		return (float)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe float _FF00_FF00_FF00_2200()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778612, new IntPtr(2737337556444L), 15))(null, 0, new IntPtr(0L));
		return (float)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal float _FF00_FF00_FF00_2300()
	{
		//IL_000a: Expected F4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (float)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object? _FF00_FF00_FF00_2400()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_2500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778611, new IntPtr(2737337556444L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_2600()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}
}
