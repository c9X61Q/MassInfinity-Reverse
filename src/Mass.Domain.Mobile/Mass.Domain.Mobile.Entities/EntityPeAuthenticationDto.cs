using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using Mass.Domain.Converters;
using Mass.Domain.Mobile.Entities.SAuth;
using Mass.Domain.Mobile.Interfaces;

namespace Mass.Domain.Mobile.Entities;

public class EntityPeAuthenticationDto
{
	internal static EntityPeAuthenticationDto EncryptValidator;

	[JsonPropertyName("engine_version")]
	public required string EngineVersion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00꼀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00넀(value);
		}
	}

	[JsonPropertyName("extra_param")]
	public string ExtraParam
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00밀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00ꨀ(value);
		}
	}

	[JsonPropertyName("message")]
	public required string Message
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00ꐀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00鬀(value);
		}
	}

	[JsonPropertyName("patch_version")]
	public required string PatchVersion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00렀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00관(value);
		}
	}

	[JsonPropertyName("pay_channel")]
	public string PayChannel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00뜀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00눀(value);
		}
	}

	[JsonConverter(typeof(NestedJsonConverter<EntityPeAuthenticationDetail>))]
	[JsonPropertyName("sa_data")]
	public required EntityPeAuthenticationDetail SaData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (EntityPeAuthenticationDetail)_FF00鸀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00됀(value);
		}
	}

	[JsonPropertyName("sauth_json")]
	public required EntitySAuth SAuth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (EntitySAuth)_FF00먀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00ꌀ(value);
		}
	}

	[JsonPropertyName("seed")]
	public required string Seed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00ꘀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00딀(value);
		}
	}

	[JsonPropertyName("sign")]
	public required string Sign
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00ꠀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00ꄀ(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe EntityPeAuthenticationDto()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		((IMobileGame)/*Error near IL_001a: Stack underflow*/).EntityId = (string)(object)this;
		((EntityAuthenticationDto)/*Error near IL_001f: Stack underflow*/).DisplayName__BackingField = (object)/*Error near IL_001f: Stack underflow*/;
		((EntityAuthenticationDto)/*Error near IL_002b: Stack underflow*/).NeteaseSid__BackingField = this;
		((StringBuilder)/*Error near IL_0036: Stack underflow*/).Append((object?)this);
		int num = 0;
		if (((EntityAuthenticationDto)EntityAuthenticationDto.PatchVersion__BackingField).UserId__BackingField != 0)
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
	internal static bool CheckSetEncryptor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EntityPeAuthenticationDto DecorateEfficientController()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00騀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778623, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00鬀(object P_0)
	{
		//IL_0011: Expected VT, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
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
			case 1:
				((EntityAuthenticationDto)this).ClientKey__BackingField = P_0;
				obj2 = 0;
				if (((EntityAuthenticationDto)EntityAuthenticationDto.DisplayName__BackingField).EngineVersion__BackingField == null)
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
	internal unsafe object _FF00鴀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778620, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00鸀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00鼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778621, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ꀀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778618, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ꄀ(object P_0)
	{
		//IL_0011: Expected VT, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
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
			case 1:
				((EntityAuthenticationDto)this).ClientKey__BackingField = P_0;
				obj2 = 0;
				if (((EntityAuthenticationDto)EntityAuthenticationDto.DisplayName__BackingField).EngineVersion__BackingField == null)
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
	internal unsafe void _FF00ꈀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778619, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ꌀ(object P_0)
	{
		//IL_0011: Expected VT, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
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
				if (((EntityAuthenticationDto)EntityAuthenticationDto.DisplayName__BackingField).EngineVersion__BackingField != null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00ꐀ()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00ꔀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778616, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00ꘀ()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_A700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778617, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00ꠀ()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00꤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778614, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ꨀ(object P_0)
	{
		//IL_0011: Expected VT, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
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
			case 1:
				((EntityAuthenticationDto)this).ClientKey__BackingField = P_0;
				obj2 = 0;
				if (((EntityAuthenticationDto)EntityAuthenticationDto.DisplayName__BackingField).EngineVersion__BackingField != null)
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
	internal unsafe void _FF00_AB00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778615, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00가(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778612, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00관(object P_0)
	{
		//IL_0011: Expected VT, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
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
	internal unsafe object _FF00글()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778613, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00꼀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00뀀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778610, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00넀(object P_0)
	{
		//IL_0011: Expected VT, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
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
	internal unsafe void _FF00눀(object P_0)
	{
		//IL_0011: Expected VT, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
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
			case 1:
				((EntityAuthenticationDto)this).ClientKey__BackingField = P_0;
				obj2 = 0;
				if (((EntityAuthenticationDto)EntityAuthenticationDto.DisplayName__BackingField).EngineVersion__BackingField == null)
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
	internal unsafe void _FF00대(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778611, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00됀(object P_0)
	{
		//IL_0011: Expected VT, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
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
			case 1:
				((EntityAuthenticationDto)this).ClientKey__BackingField = P_0;
				obj2 = 0;
				if (((EntityAuthenticationDto)EntityAuthenticationDto.DisplayName__BackingField).EngineVersion__BackingField == null)
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
	internal unsafe void _FF00딀(object P_0)
	{
		//IL_0011: Expected VT, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
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
			case 1:
				((EntityAuthenticationDto)this).ClientKey__BackingField = P_0;
				obj2 = 0;
				if (((EntityAuthenticationDto)EntityAuthenticationDto.DisplayName__BackingField).EngineVersion__BackingField == null)
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
	internal unsafe void _FF00똀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778608, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00뜀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00렀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00뤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778609, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00먀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00묀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778574, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00밀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00봀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return EntityAuthenticationDto.ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00븀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778575, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00뼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778572, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00쀀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return (EntityAuthenticationDto.ClientKey__BackingField == null) ? ((byte)1) : ((byte)0);
	}
}
