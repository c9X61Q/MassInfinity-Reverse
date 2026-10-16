using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Mass.Domain.Mobile.Entities.Game;
using Mass.Domain.Mobile.Interfaces;

namespace Mass.Domain.Mobile.Entities.SAuth;

public class EntitySAuth
{
	private static object DecorateDetailedSender;

	[JsonIgnore]
	public virtual EntityPatchInfo PatchInfo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (EntityPatchInfo)_FF00洀();
		}
	}

	[JsonPropertyName("access_token")]
	public string AccessToken
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00謀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00帀(value);
		}
	}

	[JsonPropertyName("app_channel")]
	public string AppChannel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00鈀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00眀(value);
		}
	}

	[JsonPropertyName("client_login_sn")]
	public string ClientLoginSn
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00瘀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00礀(value);
		}
	}

	[JsonPropertyName("gameid")]
	public string GameId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00猀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00砀(value);
		}
	}

	[JsonPropertyName("get_access_token")]
	public string GetAccessToken
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00樀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00栀(value);
		}
	}

	[JsonPropertyName("ip")]
	public string Ip
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00搀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00耀(value);
		}
	}

	[JsonPropertyName("login_channel")]
	public string LoginChannel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00茀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00漀(value);
		}
	}

	[JsonPropertyName("platform")]
	public string Platform
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00怀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00氀(value);
		}
	}

	[JsonPropertyName("sdk_version")]
	public string SdkVersion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00蔀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00蘀(value);
		}
	}

	[JsonPropertyName("sdkuid")]
	public string SdkUserId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00頀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00鐀(value);
		}
	}

	[JsonPropertyName("sessionid")]
	public string SessionId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00挀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00阀(value);
		}
	}

	[JsonPropertyName("udid")]
	public string UniqueDeviceId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00戀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00昀(value);
		}
	}

	[JsonPropertyName("deviceid")]
	public string DeviceId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00褀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00爀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe EntitySAuth()
	{
		//IL_0011: Expected VT, but got Ref
		//IL_0046: Expected I4, but got Obj
		//IL_0077: Expected I, but got Obj
		//IL_00ce: Expected VT, but got Obj
		//IL_00dd: Expected Obj, but got I
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		((IMobileGame)/*Error near IL_001a: Stack underflow*/).EntityId = (string)(object)this;
		((EntityAuthenticationDto)/*Error near IL_001f: Stack underflow*/).DisplayName__BackingField = (object)/*Error near IL_001f: Stack underflow*/;
		((EntityAuthenticationDto)/*Error near IL_002b: Stack underflow*/).NeteaseSid__BackingField = this;
		((IMobileGame)/*Error near IL_0036: Stack underflow*/).Description = (string)(object)this;
		((EntityAuthenticationDto)/*Error near IL_003b: Stack underflow*/).PatchVersion__BackingField = (object)/*Error near IL_003b: Stack underflow*/;
		((IMobileGame)/*Error near IL_0046: Stack underflow*/).PlayerCount = (int)this;
		EntityAuthenticationDto.CheckConcreteState = (object)/*Error near IL_004b: Stack underflow*/;
		((IMobileGame)/*Error near IL_0056: Stack underflow*/).ImageUrl = (string)(object)this;
		((EntityLinkServer)/*Error near IL_005b: Stack underflow*/).IspEnabled__BackingField = (nint)/*Error near IL_005b: Stack underflow*/;
		((EntityAuthentication)/*Error near IL_0066: Stack underflow*/).Chain = (List<string>)(object)this;
		((EntityLinkServer)/*Error near IL_006b: Stack underflow*/).ServerType__BackingField = (object)/*Error near IL_006b: Stack underflow*/;
		((EntityLinkServer)/*Error near IL_0077: Stack underflow*/).Port__BackingField = (nint)this;
		((EntityLoginOtpDto)/*Error near IL_0087: Stack underflow*/).Json__BackingField = ((EntityAuthenticationDto)this).Bit;
		((EntityPeAuthenticationDetail)/*Error near IL_0093: Stack underflow*/).AppChannel__BackingField = this;
		((EntityPeAuthenticationDetail)/*Error near IL_009f: Stack underflow*/).CoreNum__BackingField = this;
		((EntityPeAuthenticationDetail)/*Error near IL_00ab: Stack underflow*/).CpuHz__BackingField = this;
		((EntityPeAuthenticationDetail)/*Error near IL_00b7: Stack underflow*/).DeviceHeight__BackingField = this;
		((EntityPeAuthenticationDetail)/*Error near IL_00c3: Stack underflow*/).DeviceWidth__BackingField = this;
		JsonDocument.Parse((string)/*Error near IL_00ce: Stack underflow*/, (JsonDocumentOptions)this);
		int num = 0;
		if (((EntityPeAuthenticationDetail)EntityPeAuthenticationDetail.Emulator__BackingField).FirstUniqueDeviceId__BackingField != null)
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
	internal static bool DecorateDividedWorker()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EntitySAuth ExecuteProgram()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00崀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778560, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00帀(object P_0)
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
	internal unsafe object _FF00开()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778561, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00怀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00愀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778590, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00戀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00挀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00搀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00攀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778591, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00昀(object P_0)
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
	internal unsafe void _FF00最(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778588, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00栀(object P_0)
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
	internal unsafe void _FF00椀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778589, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00樀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00欀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778586, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00氀(object P_0)
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
	internal unsafe object _FF00洀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		((IMobileGame)/*Error near IL_0019: Stack underflow*/).EntityId = (string)/*Error near IL_0019: Stack underflow*/;
		return (object)/*Error near IL_001a: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00渀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778587, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00漀(object P_0)
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
	internal unsafe void _FF00瀀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778584, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00焀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778585, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00爀(object P_0)
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
	internal unsafe object _FF00猀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00琀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778582, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00甀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778583, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00瘀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00眀(object P_0)
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
	internal unsafe void _FF00砀(object P_0)
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
	internal unsafe void _FF00礀(object P_0)
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
	internal unsafe void _FF00稀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778580, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00笀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778581, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00簀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return (EntityAuthenticationDto.ClientKey__BackingField == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00紀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778578, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00縀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return EntityAuthenticationDto.ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00缀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778579, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00耀(object P_0)
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
	internal unsafe void _FF00脀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778576, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00舀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778577, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00茀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00萀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778414, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00蔀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00蘀(object P_0)
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
	internal unsafe void _FF00蜀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778415, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00蠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778412, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00褀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00言()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778413, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00謀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00谀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778410, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00鈀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00錀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778411, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00鐀(object P_0)
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
	internal unsafe void _FF00销(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778408, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00阀(object P_0)
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
	internal unsafe void _FF00需(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778409, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00頀()
	{
		//IL_0011: Expected VT, but got Ref
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		return ((EntityAuthenticationDto)this).ClientKey__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00餀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778406, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
