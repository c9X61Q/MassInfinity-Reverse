using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Mass.Domain.Desktop.ValueObjects;

namespace Mass.Domain.Desktop.Entities;

public class EntityAuthenticationUpdate
{
	internal static EntityAuthenticationUpdate CheckJoinedGateway;

	[JsonPropertyName("entity_id")]
	public ulong EntityId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00鰀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00頀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EntityAuthenticationUpdate()
	{
		Unsafe.As<int, object>(ref EnumGameClientType.value__)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		/*Error near IL_0015: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RestartNode()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EntityAuthenticationUpdate DecorateScalableFactory()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00销()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778612, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00阀()
	{
		Unsafe.As<int, object>(ref EnumGameClientType.value__)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ((nint)2 == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00需(ulong P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778613, new IntPtr(2737337521084L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00頀(ulong P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected I4, but got I8
		//IL_003a: Expected native int or pointer, but got Obj
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		Unsafe.As<int, object>(ref EnumGameClientType.value__)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				EnumGameClientType.cpp = (EnumGameClientType)P_0;
				obj2 = 0;
				if (EnumGameType.None == (EnumGameType)0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00餀(ulong P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778610, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00騀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778611, new IntPtr(2737337521084L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00鬀()
	{
		//IL_001a: Expected Obj, but got I4
		Unsafe.As<int, object>(ref EnumGameClientType.value__)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return EnumGameClientType.cpp;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ulong _FF00_FF00_FF00_FF00_FF00_FF00鰀()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		//IL_001b: Expected I8, but got I4
		Unsafe.As<int, object>(ref EnumGameClientType.value__)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return 2uL;
	}
}
