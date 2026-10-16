using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;

namespace Mass.Domain.Mobile.Entities.SAuth;

public class EntitySAuthRealName
{
	private static object ReplaceList;

	[JsonPropertyName("realname_type")]
	public int RealNameType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00㴀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00㨀((uint)value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe EntitySAuthRealName()
	{
		//IL_0011: Expected VT, but got Ref
		//IL_001b: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		((EntityAuthenticationDto)this).ClientKey__BackingField = 2;
		((StringBuilder)/*Error near IL_0026: Stack underflow*/).Append((char)(int)this);
		int num = 0;
		if (((EntityAuthenticationDto)EntityAuthenticationDto.EngineVersion__BackingField).NeteaseSid__BackingField != null)
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
	internal static bool ReflectScheduledSubscriber()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EntitySAuthRealName ReflectFilteredLogger()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00㤀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778424, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00㨀(uint P_0)
	{
		//IL_0011: Expected VT, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected Obj, but got I4
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
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
				((EntityAuthenticationDto)this).ClientKey__BackingField = P_0;
				obj2 = 0;
				if (((EntityAuthenticationDto)EntityAuthenticationDto.DisplayName__BackingField).EngineVersion__BackingField == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00㬀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778425, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00㰀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778422, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00㴀()
	{
		//IL_0011: Expected VT, but got Ref
		//IL_001b: Expected I4, but got Obj
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return (uint)(int)((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00㸀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778423, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00㼀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return (EntityAuthenticationDto.ClientKey__BackingField == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00䀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778420, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00䄀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return EntityAuthenticationDto.ClientKey__BackingField;
	}
}
