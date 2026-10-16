using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Mass.Domain.Mobile.Entities.SAuth;
using Mass.Domain.Mobile.Interfaces;

namespace Mass.Domain.Mobile.Entities;

public class EntityPeAuthenticationDetail
{
	[CompilerGenerated]
	private object AppChannel__BackingField;

	[CompilerGenerated]
	private object CoreNum__BackingField;

	[CompilerGenerated]
	private object CpuHz__BackingField;

	[CompilerGenerated]
	private object DeviceHeight__BackingField;

	[CompilerGenerated]
	private object DeviceWidth__BackingField;

	[CompilerGenerated]
	private nint Emulator__BackingField;

	[CompilerGenerated]
	private nint IsGuest__BackingField;

	[CompilerGenerated]
	private object MacAddress__BackingField;

	[CompilerGenerated]
	private object OsName__BackingField;

	[CompilerGenerated]
	private object OsVersion__BackingField;

	internal static EntityPeAuthenticationDetail CheckSortedFactory;

	[JsonPropertyName("app_channel")]
	public required string AppChannel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_2900();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			this._FF00_FFFD((object)value);
		}
	}

	[JsonPropertyName("app_ver")]
	public required string AppVersion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00츀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_2200(value);
		}
	}

	[JsonPropertyName("core_num")]
	public string CoreNum
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_2600();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			this._FF00_FFFD((object)value);
		}
	}

	[JsonPropertyName("cpu_digit")]
	public string CpuDigit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_E200();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00혀(value);
		}
	}

	[JsonPropertyName("cpu_hz")]
	public string CpuHz
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00ᔀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00퐀(value);
		}
	}

	[JsonPropertyName("cpu_name")]
	public string CpuName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_2E00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00팀(value);
		}
	}

	[JsonPropertyName("device_height")]
	public string DeviceHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)this._FF00_FFFD();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00ᰀ(value);
		}
	}

	[JsonPropertyName("device_model")]
	public string DeviceModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00숀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00쌀(value);
		}
	}

	[JsonPropertyName("device_width")]
	public string DeviceWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00ጀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_F700(value);
		}
	}

	[JsonPropertyName("disk")]
	public string Disk
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_0300();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FE00(value);
		}
	}

	[JsonPropertyName("emulator")]
	public int Emulator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_2A00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_0C00((uint)value);
		}
	}

	[JsonPropertyName("first_udid")]
	public required string FirstUniqueDeviceId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00쨀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_2300(value);
		}
	}

	[JsonPropertyName("is_guest")]
	public int IsGuest
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00豈();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00쬀((uint)value);
		}
	}

	[JsonPropertyName("launcher_type")]
	public string LauncherType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00ༀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00Ԁ(value);
		}
	}

	[JsonPropertyName("mac_addr")]
	public string MacAddress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00ἀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_0D00(value);
		}
	}

	[JsonPropertyName("network")]
	public string Network
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)this._FF00_FFFD();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_E000(value);
		}
	}

	[JsonPropertyName("os_name")]
	public string OsName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00턀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_E700(value);
		}
	}

	[JsonPropertyName("os_ver")]
	public string OsVersion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00쐀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00Ā(value);
		}
	}

	[JsonPropertyName("ram")]
	public string Ram
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00케();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_1800(value);
		}
	}

	[JsonPropertyName("rom")]
	public string Rom
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00였();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00ﴀ(value);
		}
	}

	[JsonPropertyName("root")]
	public bool Root
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00ᨀ() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00ﰀ(value ? ((byte)1) : ((byte)0));
		}
	}

	[JsonPropertyName("sdk_ver")]
	public required string SdkVersion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00저();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_E400(value);
		}
	}

	[JsonPropertyName("start_type")]
	public string StartType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_0700();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00ᘀ(value);
		}
	}

	[JsonPropertyName("udid")]
	public required string UniqueDeviceId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00ᄀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_2500(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe EntityPeAuthenticationDetail()
	{
		//IL_0011: Expected VT, but got Ref
		//IL_004a: Expected I4, but got Obj
		//IL_00eb: Expected I, but got Obj
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		((IMobileGame)/*Error near IL_001a: Stack underflow*/).EntityId = (string)(object)this;
		((EntityAuthenticationDto)/*Error near IL_001f: Stack underflow*/).DisplayName__BackingField = (object)/*Error near IL_001f: Stack underflow*/;
		((IMobileGame)/*Error near IL_002a: Stack underflow*/).Name = (string)(object)this;
		((EntityAuthenticationDto)/*Error near IL_002f: Stack underflow*/).NeteaseSid__BackingField = (object)/*Error near IL_002f: Stack underflow*/;
		((IMobileGame)/*Error near IL_003a: Stack underflow*/).Description = (string)(object)this;
		((EntityAuthenticationDto)/*Error near IL_003f: Stack underflow*/).PatchVersion__BackingField = (object)/*Error near IL_003f: Stack underflow*/;
		((IMobileGame)/*Error near IL_004a: Stack underflow*/).PlayerCount = (int)this;
		EntityAuthenticationDto.CheckConcreteState = (object)/*Error near IL_004f: Stack underflow*/;
		((IMobileGame)/*Error near IL_005a: Stack underflow*/).ImageUrl = (string)(object)this;
		((EntityLinkServer)/*Error near IL_005f: Stack underflow*/).IspEnabled__BackingField = (nint)/*Error near IL_005f: Stack underflow*/;
		((EntityAuthentication)/*Error near IL_006a: Stack underflow*/).Chain = (List<string>)(object)this;
		((EntityLinkServer)/*Error near IL_006f: Stack underflow*/).ServerType__BackingField = (object)/*Error near IL_006f: Stack underflow*/;
		((EntityLinkServer)this).Port__BackingField = (EntityAuthentication.CheckStaticSingleton() ? 1 : 0);
		((EntityLoginOtpDto)/*Error near IL_008b: Stack underflow*/).Json__BackingField = this;
		((EntityPeAuthenticationDetail)/*Error near IL_009b: Stack underflow*/).AppChannel__BackingField = ((EntityAuthenticationDto)this).ClientKey;
		((EntityPeAuthenticationDetail)/*Error near IL_00ab: Stack underflow*/).CoreNum__BackingField = ((EntityAuthenticationDto)this).DisplayName;
		((EntityPeAuthenticationDetail)/*Error near IL_00bb: Stack underflow*/).CpuHz__BackingField = ((EntityAuthenticationDto)this).EngineVersion;
		((EntityPeAuthenticationDetail)/*Error near IL_00cb: Stack underflow*/).DeviceHeight__BackingField = ((EntityAuthenticationDto)this).NeteaseSid;
		((EntityPeAuthenticationDetail)/*Error near IL_00db: Stack underflow*/).DeviceWidth__BackingField = ((EntityAuthenticationDto)this).OsName;
		((EntityPeAuthenticationDetail)/*Error near IL_00eb: Stack underflow*/).Emulator__BackingField = (nint)((EntityAuthenticationDto)this).PatchVersion;
		((EntityPeAuthenticationDetail)/*Error near IL_00fb: Stack underflow*/).IsGuest__BackingField = (int)((EntityAuthenticationDto)this).UserId;
		((EntityAuthenticationDto)this)._002Ector();
		((EntityPeAuthenticationDetail)/*Error near IL_010b: Stack underflow*/).MacAddress__BackingField = (object)/*Error near IL_010b: Stack underflow*/;
		((JsonConverter<EntitySAuth>)this)._002Ector();
		int num = 0;
		if (((EntityPeAuthenticationDetail)EntityPeAuthenticationDetail.OsName__BackingField).OsVersion__BackingField != null)
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
	internal static bool ReflectCombinedCompressor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EntityPeAuthenticationDetail DecorateTransformableResponder()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00섀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778507, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00숀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00쌀(object P_0)
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
	internal unsafe object _FF00쐀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00씀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778504, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00였()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00윀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778505, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00저()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00준()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778502, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00쨀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00쬀(uint P_0)
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
	internal unsafe void _FF00찀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778503, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00촀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778500, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00츀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00케()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00퀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778501, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00턀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00툀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778498, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00팀(object P_0)
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
	internal unsafe void _FF00퐀(object P_0)
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
	internal unsafe void _FF00픀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778499, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00혀(object P_0)
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
	internal unsafe void _FF00휀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778496, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FFFD()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778497, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FFFD()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778526, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FFFD(object P_0)
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
	internal unsafe void _FF00_FFFD(object P_0)
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
	internal unsafe void _FF00_FFFD(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778527, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FFFD(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778524, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_E000(object P_0)
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
	internal unsafe void _FF00_E100(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778525, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_E200()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_E300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778522, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_E400(object P_0)
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
	internal unsafe void _FF00_E500(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778523, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_E600(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778520, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_E700(object P_0)
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
	internal unsafe void _FF00_F700(object P_0)
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
	internal unsafe uint _FF00_F800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778521, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00豈()
	{
		//IL_0011: Expected VT, but got Ref
		//IL_001b: Expected I4, but got Obj
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return (uint)(int)((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00切()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778518, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ﬀ(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778519, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ﰀ(byte P_0)
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
	internal unsafe void _FF00ﴀ(object P_0)
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
	internal unsafe void _FF00_FE00(object P_0)
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
	internal unsafe void _FF00_FF00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778516, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00Ā(object P_0)
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
	internal unsafe object _FF00_FF00Ȁ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778517, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_0300()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00Ѐ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778514, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00Ԁ(object P_0)
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
	internal unsafe void _FF00_FF00_0600(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778515, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_0700()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00ࠀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778512, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_0900()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return EntityAuthenticationDto.ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_0A00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778513, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_0B00(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778606, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_0C00(uint P_0)
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
	internal unsafe void _FF00_FF00_0D00(object P_0)
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
	internal unsafe void _FF00_FF00_0E00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778607, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00ༀ()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00က()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778604, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00ᄀ()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00ሀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778605, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00ጀ()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_1400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778602, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00ᔀ()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00ᘀ(object P_0)
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
	internal unsafe void _FF00_FF00ᜀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778603, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_1800(object P_0)
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
	internal unsafe void _FF00_FF00ᤀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778600, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00ᨀ()
	{
		//IL_0011: Expected VT, but got Ref
		//IL_001b: Expected I4, but got Obj
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return (byte)(int)((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_1B00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778601, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00ᰀ(object P_0)
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
	internal unsafe void _FF00_FF00ᴀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778598, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00Ḁ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778599, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00ἀ()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_2000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778596, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_2100(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778597, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_2200(object P_0)
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
	internal unsafe void _FF00_FF00_2300(object P_0)
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
	internal unsafe void _FF00_FF00_2400(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778594, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_2500(object P_0)
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
	internal unsafe object _FF00_FF00_2600()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_2700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778595, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_2800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778592, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_2900()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_2A00()
	{
		//IL_0011: Expected VT, but got Ref
		//IL_001b: Expected I4, but got Obj
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return (uint)(int)((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_2B00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778593, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00Ⰰ()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return (EntityAuthenticationDto.ClientKey__BackingField == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00ⴀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778622, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_2E00()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}
}
