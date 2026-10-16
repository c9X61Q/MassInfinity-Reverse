using System;
using System.Buffers;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using DotNetty.Transport.Channels;
using Mass.Application.Desktop;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Domain.Value;

namespace Mass.Game.Proxy;

public record EntityLaunchGameProxy
{
	[CompilerGenerated]
	protected virtual Type EqualityContract
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (Type)_FF00_FF00_FF00_FF00_FF00_FF00䜀();
		}
	}

	public DesktopSession Session
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DesktopSession)_FF00_FF00_FF00_FF00_FF00_FF00椀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_3100(value);
		}
	}

	public string GameId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00㐀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00_FF00一(value);
		}
	}

	public EnumGameType GameType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00倀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00_FF00怀(value);
		}
	}

	public EnumGameVersion GameVersion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00堀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00_FF00笀(value);
		}
	}

	public string ModHashList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00㠀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00_FF00愀(value);
		}
	}

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00䴀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00_FF00㬀(value);
		}
	}

	public string ServerAddress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00䀀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00_FF00嘀(value);
		}
	}

	public int ServerPort
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00_FF00_FF00_FF00㜀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00_FF00䤀((uint)value);
		}
	}

	public EntitySocks5? Socks5
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (EntitySocks5?)_FF00_FF00_FF00_FF00_FF00_FF00䘀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00挀(value);
		}
	}

	public SectionValue? Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SectionValue?)_FF00_FF00_FF00_FF00_FF00_FF00娀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00㴀(value);
		}
	}

	public bool IsGame
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00礀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00搀(value ? ((byte)1) : ((byte)0));
		}
	}

	[CompilerGenerated]
	private readonly object Session__BackingField;

	[CompilerGenerated]
	private readonly object GameId__BackingField;

	[CompilerGenerated]
	private readonly EnumGameType GameType__BackingField;

	[CompilerGenerated]
	private readonly object ModHashList__BackingField;

	[CompilerGenerated]
	private readonly object Name__BackingField;

	[CompilerGenerated]
	private readonly nint ServerPort__BackingField;

	[CompilerGenerated]
	private object? Socks5__BackingField;

	internal static EntityLaunchGameProxy ReflectAlphabeticProcessor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EntityLaunchGameProxy(DesktopSession Session, string GameId, EnumGameType GameType, EnumGameVersion GameVersion, string ModHashList, string Name, string ServerAddress, int ServerPort)
	{
		//IL_001b: Expected VT, but got Obj
		//IL_0027: Expected VT, but got Obj
		//IL_0033: Expected Obj, but got I4
		//IL_0040: Expected VT, but got I4
		//IL_004d: Expected VT, but got Obj
		//IL_005a: Expected VT, but got Obj
		//IL_0067: Expected VT, but got Obj
		//IL_0074: Expected Obj, but got I4
		//IL_008e: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)Session;
		((_003C_003Ef__AnonymousType1<, , >)this)._003Cuser_id_003Ei__Field = (_003Cuser_id_003Ej__TPar)GameId;
		_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter = GameType;
		((_003C_003Ef__AnonymousType2<, , , >)this)._003Curl_003Ei__Field = (_003Curl_003Ej__TPar)GameVersion;
		((_003C_003Ef__AnonymousType2<, , , >)this)._003Cpayload_003Ei__Field = (_003Cpayload_003Ej__TPar)ModHashList;
		((_003C_003Ef__AnonymousType2<, , , >)this)._003Ccontext_003Ei__Field = (_003Ccontext_003Ej__TPar)Name;
		((_003C_003Ef__AnonymousType2<, , , >)this)._003Cuser_id_003Ei__Field = (_003Cuser_id_003Ej__TPar)ServerAddress;
		_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic = ServerPort;
		_ = EqualityComparer<_00212>.Default;
		int num = 0;
		if (_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument != null)
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
	[CompilerGenerated]
	public override string ToString()
	{
		return (string)_FF00_FF00_FF00_FF00_FF00_FF00䐀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	protected virtual bool PrintMembers(StringBuilder builder)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00砀(builder) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public override int GetHashCode()
	{
		return (int)_FF00_FF00_FF00_FF00_FF00_FF00㔀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public virtual bool Equals(EntityLaunchGameProxy? other)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00吀(other) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	protected unsafe EntityLaunchGameProxy(EntityLaunchGameProxy original)
	{
		//IL_001a: Expected VT, but got Obj
		//IL_001a: Expected VT, but got Ref
		//IL_0029: Expected Obj, but got VT
		//IL_00b3: Expected VT, but got Obj
		//IL_0097: Expected Obj, but got VT
		//IL_0154: Expected I, but got Obj
		//IL_00e8: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got VT
		//IL_00f9: Expected VT, but got Obj
		//IL_010f: Expected Obj, but got I4
		//IL_0143: Expected Obj, but got I4
		//IL_0077: Expected I4, but got Obj
		//IL_002e->IL0042: Incompatible stack types: I4 vs Obj
		//IL_0039->IL0042: Incompatible stack types: I4 vs Obj
		//IL_00bd->IL0042: Incompatible stack types: I4 vs Obj
		//IL_009c->IL0042: Incompatible stack types: I4 vs Obj
		//IL_01b6->IL0042: Incompatible stack types: I4 vs Obj
		//IL_015e->IL0042: Incompatible stack types: I4 vs Obj
		//IL_017e->IL0042: Incompatible stack types: I4 vs Obj
		//IL_00d3->IL0042: Incompatible stack types: I4 vs Obj
		//IL_0103->IL0042: Incompatible stack types: I4 vs Obj
		//IL_0123->IL0042: Incompatible stack types: I4 vs Obj
		//IL_01a0->IL0042: Incompatible stack types: I4 vs Obj
		//IL_00a7->IL0042: Incompatible stack types: I4 vs Obj
		//IL_0189->IL0042: Incompatible stack types: I4 vs Obj
		//IL_012e->IL0042: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((EqualityComparer<_00210>)/*Error near IL_001a: Stack underflow*/).Equals((_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00210?)this);
		object obj = 7;
		if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
		{
			obj = 9;
		}
		while (true)
		{
			object obj2;
			switch ((int)obj)
			{
			default:
				return;
			case 2:
				((_003C_003Ef__AnonymousType2<, , , >)this)._003Cpayload_003Ei__Field = (_003Cpayload_003Ej__TPar)((_003C_003Ef__AnonymousType2<, , , >)(object)original)._003Curl_003Ei__Field;
				obj = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Ccontext_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
				{
					obj = 0;
				}
				break;
			case 1:
				((_003C_003Ef__AnonymousType3<, >)this)._003Centry_003Ei__Field = (_003Centry_003Ej__TPar)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic;
				obj = 3;
				break;
			case 7:
				_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument = ((_003C_003Ef__AnonymousType3<, >)(object)original)._003Csid_003Ei__Field;
				obj = 2;
				break;
			case 6:
				_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectLocalTemplate = _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance;
				obj2 = 7;
				goto IL_003e;
			case 8:
				_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_defaultTimeout = (TimeSpan)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.StoreConverter;
				obj = 10;
				break;
			case 9:
				_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_ascii_68FF03FEFFFF87FEFFFF07 = (SearchValues<char>)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_hasTimeout;
				obj = 1;
				if (((EntitySocks5Account)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.GuideMap).Username__BackingField != null)
				{
					obj = 1;
				}
				break;
			case 11:
				EntitySocks5Account.AttachElement = ((EntitySocks5Account)(object)original).Password__BackingField;
				obj2 = 5;
				goto IL_003e;
			case 4:
				((EntitySocks5)this).Port__BackingField = (nint)((EntitySocks5)(object)original).Address__BackingField;
				obj = 8;
				break;
			case 5:
				EntitySocks5.DecorateDynamicModule = ((EntitySocks5)(object)original).Account__BackingField;
				obj = 2;
				if (((EntityLaunchGameProxy)EntityLaunchGameProxy.Session__BackingField).GameId__BackingField == null)
				{
					obj = 4;
				}
				break;
			case 0:
				return;
			case 10:
				GameVersion = (EnumGameVersion)original.GameType__BackingField;
				obj = 6;
				break;
			case 3:
				{
					Name__BackingField = original.ModHashList__BackingField;
					obj = 11;
					break;
				}
				IL_003e:
				obj = obj2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public unsafe void Deconstruct(out DesktopSession Session, out string GameId, out EnumGameType GameType, out EnumGameVersion GameVersion, out string ModHashList, out string Name, out string ServerAddress, out int ServerPort)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00昀((nint)Unsafe.AsPointer(ref Session), (nint)Unsafe.AsPointer(ref GameId), (nint)Unsafe.AsPointer(ref GameType), (nint)Unsafe.AsPointer(ref GameVersion), (nint)Unsafe.AsPointer(ref ModHashList), (nint)Unsafe.AsPointer(ref Name), (nint)Unsafe.AsPointer(ref ServerAddress), (nint)Unsafe.AsPointer(ref ServerPort));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckEditableContainer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EntityLaunchGameProxy DecorateLogicalConverter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_3000(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778733, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_3100(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got Obj
		//IL_004f: Expected Obj, but got VT
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
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
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_3200(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778732, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_3300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778735, new IntPtr(2737367923404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00㐀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00㔀()
	{
		//IL_0019: Expected VT, but got Ref
		//IL_001f: Expected Obj, but got I4
		//IL_0024: Expected Obj, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		string.Format((IFormatProvider?)/*Error near IL_002f: Stack underflow*/, (string)/*Error near IL_002f: Stack underflow*/, (object?[])(((object)((_003C_003Ef__AnonymousType0<>)((EqualityComparer<_00210>)/*Error near IL_0019: Stack underflow*/).Equals((_00210?)/*Error near IL_0019: Stack underflow*/, (_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))).Equals(this)).ToString() * -1521134295));
		_ = ((_003C_003Ef__AnonymousType2<, , , >)this)._003Cpayload_003Ei__Field;
		/*Error near IL_0035: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00㘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778734, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00_FF00_FF00_FF00㜀()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (uint)(int)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00㠀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00㤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778729, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00㨀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778728, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00㬀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got Obj
		//IL_004e: Expected Obj, but got VT
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
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
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00㰀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778731, new IntPtr(2737367928604L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00㴀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got Obj
		//IL_004e: Expected Obj, but got VT
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
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
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00㸀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778730, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00㼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778725, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00䀀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00䄀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778724, new IntPtr(2737367928604L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00䌀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778727, new IntPtr(2737367925484L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00䐀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 10284, 1790778726, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778726, new IntPtr(2737367925484L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00䔀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778721, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00䘀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe object _FF00_FF00_FF00_FF00_FF00_FF00䜀()
	{
		//IL_001e: Expected Obj, but got Ref
		//IL_001f: Expected Obj, but got I4
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((EqualityComparer<_00210>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).GetHashCode((_00210)typeof(_003C_003Ef__AnonymousType2<, , , >).TypeHandle);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00䠀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778720, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00䤀(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got I4
		//IL_004e: Expected Obj, but got VT
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
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
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00䨀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778723, new IntPtr(2737367924444L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00䬀()
	{
		//IL_001a: Expected VT, but got Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return new
		{
			action = (_003Caction_003Ej__TPar)this
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00䰀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778722, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00䴀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00一(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got Obj
		//IL_004f: Expected Obj, but got VT
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
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
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00伀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778749, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal EnumGameType _FF00_FF00_FF00_FF00_FF00_FF00倀()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (EnumGameType)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00儀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778748, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00刀(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0051: Expected Obj, but got VT
		//IL_0083: Expected Obj, but got VT
		//IL_0056->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0088->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0061->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0093->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				if (P_0 == null)
				{
					return 0;
				}
				obj2 = 2;
				if ((int)((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
				{
					obj2 = 1;
				}
				break;
			case 2:
				return (byte)((_003C_003Ef__AnonymousType0<>)P_1).GetHashCode();
			case 1:
				if (P_0 == P_1)
				{
					return 1;
				}
				obj2 = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field != 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00匀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778751, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00吀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0067: Expected I4, but got Obj
		//IL_00f0: Expected VT, but got Ref
		//IL_0071: Expected VT, but got Ref
		//IL_0082: Expected Obj, but got VT
		//IL_0082: Expected Obj, but got I4
		//IL_0247: Expected VT, but got Ref
		//IL_020d: Expected Obj, but got Ref
		//IL_0270: Expected Obj, but got Ref
		//IL_0090: Expected Obj, but got I4
		//IL_0266: Expected Obj, but got I4
		//IL_025d->IL01f4: Incompatible stack heights: 1 vs 0
		//IL_0223->IL01f4: Incompatible stack heights: 2 vs 0
		//IL_0286->IL01f4: Incompatible stack heights: 2 vs 0
		//IL_01d3->IL01f4: Incompatible stack heights: 1 vs 0
		//IL_01fe->IL01f4: Incompatible stack heights: 1 vs 0
		//IL_0095->IL0022: Incompatible stack heights: 0 vs 1
		//IL_026b->IL0022: Incompatible stack types: I4 vs Ref
		//IL_0237->IL0026: Incompatible stack heights: 3 vs 2
		//IL_029a->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0208->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0242->IL0026: Incompatible stack heights: 3 vs 2
		//IL_02a5->IL0026: Incompatible stack heights: 3 vs 2
		ref readonly _003Caction_003Ej__TPar reference = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 13;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 5:
					if (string.Format((IFormatProvider?)((EqualityComparer<_00210>)/*Error near IL_0071: Stack underflow*/).Equals((_00210?)/*Error near IL_0071: Stack underflow*/, (_00210?)Unsafe.AsPointer(ref reference)), (string)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuser_id_003Ei__Field, (object?[])_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter) != null)
					{
						obj = 2;
						break;
					}
					goto case 11;
				case 3:
					_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
					_003C_003Ef__AnonymousType0<>.ReflectJoinedTree();
					/*Error near IL_00a1: Member reference must be method, but was: Field*/;
				case 13:
					if (this != P_0)
					{
						obj2 = 12;
						continue;
					}
					return 1;
				case 10:
					/*Error near IL_00c6: Member reference must be method, but was: Field*/;
				case 4:
					((EqualityComparer<_00211>)/*Error near IL_00f0: Stack underflow*/).Equals((_00211?)/*Error near IL_00f0: Stack underflow*/, (_00211?)Unsafe.AsPointer(ref reference));
					_ = _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectLocalTemplate;
					_ = _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.StoreConverter;
					/*Error near IL_00fc: Member reference must be method, but was: Field*/;
				case 1:
					/*Error near IL_0110: Member reference must be method, but was: Field*/;
				default:
					_ = EqualityComparer<_00213>.Default;
					_ = EntitySocks5Account.AttachElement;
					_ = ((EntitySocks5)P_0).Address__BackingField;
					/*Error near IL_0146: Member reference must be method, but was: Field*/;
				case 7:
					/*Error near IL_015a: Member reference must be method, but was: Field*/;
				case 14:
					/*Error near IL_0194: Member reference must be method, but was: Field*/;
				case 2:
					/*Error near IL_01dd: Member reference must be method, but was: Field*/;
				case 11:
					return 0;
				case 12:
					if (P_0 != null)
					{
						obj2 = 3;
						continue;
					}
					goto case 11;
				case 8:
					MemoryExtensions.IndexOfAnyExcept<T>((ReadOnlySpan<T>)/*Error near IL_020d: Stack underflow*/, (SearchValues<T>)Unsafe.AsPointer(ref reference));
					_ = ((GameProxy)this).ConnectionChanged;
					if ((int)(ReadOnlySpan<char>)(string?)(object)GameProxy.OnlineClients != 0)
					{
						_ = 0;
						if (((GameProxy)GameProxy.Session__BackingField).GameType__BackingField == 0)
						{
							_ = 0;
						}
						continue;
					}
					goto case 11;
				case 6:
				{
					bool flag = (TimeSpan)/*Error near IL_0247: Stack underflow*/ != (TimeSpan)Unsafe.AsPointer(ref reference);
					EnumGameVersion enumGameVersion = ((GameProxy)this).GameVersion__BackingField;
					((StringBuilder)((GameProxy)P_0).ModHashList__BackingField)._002Ector();
					if (enumGameVersion != EnumGameVersion.None)
					{
						obj = 5;
						reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
						break;
					}
					goto case 11;
				}
				case 9:
				{
					((StringBuilder)/*Error near IL_0270: Stack underflow*/).Append((string?)Unsafe.AsPointer(ref reference));
					_ = ((GameProxy)this).TransferServerAddress__BackingField;
					nint num = ((GameProxy)P_0).TransferServerPort__BackingField;
					RuntimeHelpers.EnsureSufficientExecutionStack();
					if (num != 0)
					{
						_ = 2;
						if (!((GameProxy)(object)GameProxy.Socks5).IsGame)
						{
							_ = 7;
						}
						continue;
					}
					goto case 11;
				}
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00唀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778750, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00嘀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got Obj
		//IL_004e: Expected Obj, but got VT
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
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
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00圀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778745, new IntPtr(2737367923404L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal EnumGameVersion _FF00_FF00_FF00_FF00_FF00_FF00堀()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (EnumGameVersion)(int)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe EnumGameVersion _FF00_FF00_FF00_FF00_FF00_FF00夀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778744, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (EnumGameVersion)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00娀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00嬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778747, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00尀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778746, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00崀()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00帀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778741, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00开(EnumGameType P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778740, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00怀(EnumGameType P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got I4
		//IL_004e: Expected Obj, but got VT
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
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
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00愀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got Obj
		//IL_004e: Expected Obj, but got VT
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
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
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00戀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778743, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00挀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got Obj
		//IL_004f: Expected Obj, but got VT
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
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
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00搀(byte P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got I4
		//IL_004f: Expected Obj, but got VT
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
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
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00攀()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00昀(nint P_0, nint P_1, nint P_2, nint P_3, nint P_4, nint P_5, nint P_6, nint P_7)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004f: Expected I4, but got Obj
		//IL_0094: Expected Obj, but got VT
		//IL_010e: Expected Obj, but got I4
		//IL_010d: Expected native int or pointer, but got Obj
		//IL_011d: Expected Obj, but got VT
		//IL_00d3: Expected VT, but got Obj
		//IL_00d3: Expected VT, but got I
		//IL_00d3: Expected VT, but got Ref
		//IL_005d: Expected VT, but got Obj
		//IL_005d: Expected Obj, but got I
		//IL_005e: Expected Obj, but got Ref
		//IL_006d: Expected Obj, but got VT
		//IL_0136: Expected Obj, but got VT
		//IL_00fc: Expected I4, but got Obj
		//IL_0149: Expected I4, but got VT
		//IL_00ad: Expected Obj, but got VT
		//IL_0099->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0122->IL0026: Incompatible stack heights: 3 vs 2
		//IL_00e8->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0072->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0140->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0106->IL0026: Incompatible stack types: I4 vs Obj
		//IL_015d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_012d->IL0026: Incompatible stack heights: 3 vs 2
		//IL_00f3->IL0026: Incompatible stack heights: 1 vs 2
		//IL_007d->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0168->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00cc->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				return;
			case 4:
				((_003C_003Ef__AnonymousType0<>)P_5)._002Ector((_003Caction_003Ej__TPar)this);
				Unsafe.Write((void*)(nint)/*Error near IL_005e: Stack underflow*/, (object)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
				_ = 8;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					_ = 1;
				}
				break;
			default:
				Unsafe.Write((void*)P_1, ((_003C_003Ef__AnonymousType0<>)this).ToString());
				obj2 = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field != 0)
				{
					obj2 = 2;
				}
				break;
			case 8:
				Unsafe.Write((void*)P_6, (object)((_003C_003Ef__AnonymousType1<, , >)this).name);
				obj2 = 5;
				if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field == 0)
				{
					obj2 = 6;
				}
				break;
			case 2:
				((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_00d3: Stack underflow*/)._002Ector((_003Cname_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_003Cuuid_003Ej__TPar)P_2, (_003Cuser_id_003Ej__TPar)this);
				*(_003F*)(nint)/*Error near IL_00d4: Stack underflow*/ = /*Error near IL_00d4: Stack underflow*/;
				_ = 1;
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance != null)
				{
					_ = 7;
				}
				break;
			case 6:
				*(int*)P_7 = (int)((_003C_003Ef__AnonymousType1<, , >)this).ToString();
				obj2 = 3;
				break;
			case 1:
				Unsafe.Write((void*)(nint)this, (object)_003C_003Ef__AnonymousType1<, , >.ReflectScalableStack());
				_ = 0;
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_hasTimeout)
				{
					_ = 0;
				}
				break;
			case 5:
				Unsafe.Write((void*)P_4, (object)((_003C_003Ef__AnonymousType2<, , , >)this).payload);
				obj2 = 4;
				break;
			case 7:
				*(int*)P_3 = (int)((_003C_003Ef__AnonymousType2<, , , >)this).context;
				obj2 = 1;
				if (((EntitySocks5Account)EntitySocks5Account.Username__BackingField).Password__BackingField != null)
				{
					obj2 = 5;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00最(nint P_0, nint P_1, nint P_2, nint P_3, nint P_4, nint P_5, nint P_6, nint P_7)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778742, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00栀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778737, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00椀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00樀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778736, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00欀(object P_0, object P_1)
	{
		//IL_001b: Expected VT, but got Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType0<>)P_0)._002Ector((_003Caction_003Ej__TPar)P_1);
		return (Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field) == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00氀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778739, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00砀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_008b: Expected I4, but got Obj
		//IL_0167: Expected Obj, but got I4
		//IL_0105: Expected VT, but got I4
		//IL_0105: Expected VT, but got Ref
		//IL_030c: Expected Obj, but got I4
		//IL_0097: Expected VT, but got Obj
		//IL_009c: Expected VT, but got Ref
		//IL_023b: Expected Obj, but got Ref
		//IL_011b: Expected VT, but got Obj
		//IL_011b: Expected Obj, but got Ref
		//IL_02f8: Expected Obj, but got I4
		//IL_02f8: Expected Obj, but got Ref
		//IL_0278: Expected Obj, but got I4
		//IL_0285: Expected VT, but got Ref
		//IL_0285: Expected VT, but got Obj
		//IL_028a: Expected Obj, but got I4
		//IL_0254: Expected Obj, but got I4
		//IL_00c7: Expected Obj, but got I4
		//IL_02b5: Expected I4, but got Obj
		//IL_00b3: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got Ref
		//IL_025f: Expected VT, but got Obj
		//IL_0264: Expected Obj, but got I4
		//IL_0371: Expected Obj, but got Ref
		//IL_0346: Expected I4, but got Obj
		//IL_0346: Expected Obj, but got Ref
		//IL_0351: Expected native int or pointer, but got Obj
		//IL_0178: Expected VT, but got I4
		//IL_0178: Expected Obj, but got Ref
		//IL_01e5: Expected VT, but got Obj
		//IL_01f5: Expected Obj, but got I
		//IL_016c->IL0022: Incompatible stack heights: 2 vs 1
		//IL_0110->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0329->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00a7->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0246->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0126->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0303->IL0026: Incompatible stack heights: 1 vs 2
		//IL_029f->IL0026: Incompatible stack heights: 3 vs 2
		//IL_02e1->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0259->IL0022: Incompatible stack heights: 0 vs 1
		//IL_02c0->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00be->IL0026: Incompatible stack heights: 1 vs 2
		//IL_026f->IL0026: Incompatible stack heights: 1 vs 2
		//IL_037c->IL0026: Incompatible stack heights: 1 vs 2
		//IL_035b->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0183->IL0026: Incompatible stack heights: 1 vs 2
		//IL_01fa->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02aa->IL0026: Incompatible stack heights: 3 vs 2
		//IL_02ec->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0366->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0205->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 12;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 3:
					((_003C_003Ef__AnonymousType0<>)P_0)._002Ector((_003Caction_003Ej__TPar)this);
					((EqualityComparer<_00210>)/*Error near IL_009c: Stack underflow*/).GetHashCode((_00210)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
					_ = 18;
					continue;
				case 15:
					((string)(object)Enum/*cast due to constrained. prefix*/).Format((IFormatProvider?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (string)P_0, (object?[])((_003C_003Ef__AnonymousType0<>)(object)(*(Enum*)this)/*cast due to constrained. prefix*/).GetHashCode());
					_ = 16;
					continue;
				case 13:
					obj = _003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
					_ = ref obj;
					/*Error near IL_00c9: Member reference must be method, but was: Field*/;
				case 1:
					((EqualityComparer<_00211>)/*Error near IL_0105: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00211?)((_003C_003Ef__AnonymousType1<, , >)P_0).Equals((object)this));
					_ = 22;
					continue;
				case 5:
					((EqualityComparer<_00212>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).GetHashCode((_00212)((_003C_003Ef__AnonymousType1<, , >)P_0).ToString());
					_ = 3;
					continue;
				case 22:
					_003C_003Ef__AnonymousType1<, , >.ReflectModularWriter();
					/*Error near IL_012c: Member reference must be method, but was: Field*/;
				case 10:
					_ = ((_003C_003Ef__AnonymousType2<, , , >)P_0).payload;
					/*Error near IL_0142: Member reference must be method, but was: Field*/;
				default:
					_ = ((_003C_003Ef__AnonymousType2<, , , >)P_0).user_id;
					_ = EqualityComparer<_00213>.Default;
					obj = 13;
					break;
				case 21:
					((EqualityComparer<_00213>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).GetHashCode((_00213)((_003C_003Ef__AnonymousType2<, , , >)P_0).Equals((object)this));
					_ = 14;
					continue;
				case 8:
					((_003C_003Ef__AnonymousType2<, , , >)P_0).ToString();
					/*Error near IL_0189: Member reference must be method, but was: Field*/;
				case 17:
					_ = ((_003C_003Ef__AnonymousType3<, >)(object)(*(Enum*)P_0)).sid;
					/*Error near IL_01b4: Member reference must be method, but was: Field*/;
				case 23:
					Regex.ValidateMatchTimeout((TimeSpan)((_003C_003Ef__AnonymousType3<, >)this).ToString());
					obj2 = 0;
					if (((EntityLaunchGameProxy)EntityLaunchGameProxy.ServerPort__BackingField).Socks5__BackingField != null)
					{
						obj2 = 17;
					}
					continue;
				case 11:
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0._002Ecctor();
					/*Error near IL_020b: Member reference must be method, but was: Field*/;
				case 4:
					((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory)P_0)._002Ector();
					MemoryExtensions.IndexOfAnyExcept<T>((ReadOnlySpan<T>)/*Error near IL_023b: Stack underflow*/, (SearchValues<T>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
					_ = 15;
					continue;
				case 12:
					((RegexRunner)/*Error near IL_024b: Stack underflow*/).Capture((int)/*Error near IL_024b: Stack underflow*/, (int)/*Error near IL_024b: Stack underflow*/, (int)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
					obj = 11;
					break;
				case 16:
					_ = (ReadOnlySpan<char>)(string?)((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)(object)Unsafe.As<_003Caction_003Ej__TPar, Enum>(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)/*cast due to constrained. prefix*/).TryMatchAtCurrentPosition((ReadOnlySpan<char>)P_0);
					_ = 6;
					continue;
				case 7:
					obj = _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.VerifyVerifier();
					AppContext.GetData((string)((TimeSpan)this != (TimeSpan)(&obj)));
					_ = 0;
					if (((GameProxy)GameProxy.ModHashList__BackingField).ServerAddress__BackingField == null)
					{
						_ = 0;
					}
					continue;
				case 14:
				{
					Type equalityContract2 = ((EntitySocks5Account)(object)(*(Enum*)P_0)).EqualityContract;
					((StringBuilder)(object)Unsafe.As<_003Caction_003Ej__TPar, Enum>(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)/*cast due to constrained. prefix*/).Append((char)(int)equalityContract2);
					_ = 7;
					continue;
				}
				case 9:
					((EntitySocks5Account)P_0).Username = (string)(object)this;
					RuntimeHelpers.EnsureSufficientExecutionStack();
					_ = 8;
					if (((GameProxy)(object)GameProxy.Socks5).IsGame)
					{
						_ = 5;
					}
					continue;
				case 6:
					((EqualityComparer<string>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).GetHashCode((string)((EntitySocks5Account)P_0).PrintMembers((StringBuilder)(object)this));
					_ = 10;
					continue;
				case 2:
					obj = (EntitySocks5Account?)P_0 == (EntitySocks5Account?)(object)this;
					int.TryParse((string?)/*Error near IL_031e: Stack underflow*/, out *(int*)((string)(object)(*(GC*)/*Error near IL_0319: Stack underflow*/)/*cast due to constrained. prefix*/).Split((char)(ushort)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (StringSplitOptions)(int)(&obj)));
					_ = 19;
					continue;
				case 19:
					return 1;
				case 20:
					obj = ((EntitySocks5Account)(object)(*(Enum*)this)/*cast due to constrained. prefix*/)._003CClone_003E_0024();
					((EqualityComparer<int>)(&obj)).GetHashCode((int)((EqualityComparer<int>)IChannelHandler).Default);
					_ = 3;
					if (((GameProxy._003CListenAsync_003Ed__69*)(nint)GameProxy._003C_003EO._003C2_003E__OnConnectServer)->_003C_003E1__state == 0)
					{
						_ = 4;
					}
					continue;
				case 18:
				{
					Type equalityContract = ((EntitySocks5)(object)(*(Enum*)P_0)).EqualityContract;
					((EqualityComparer<EntitySocks5Account>)(object)(*(Enum*)/*Error near IL_0371: Stack underflow*/)/*cast due to constrained. prefix*/).Equals((EntitySocks5Account?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (EntitySocks5Account?)(object)equalityContract);
					_ = 23;
					continue;
				}
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00礀()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (byte)(int)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00稀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778738, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00笀(EnumGameVersion P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got I4
		//IL_004e: Expected Obj, but got VT
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
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
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00簀(EnumGameVersion P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778701, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00紀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778700, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00縀(object P_0)
	{
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType0<>)(object)this).Equals((object)(P_0 as _003C_003Ef__AnonymousType2<, , , >)) ? ((byte)1) : ((byte)0);
	}
}
