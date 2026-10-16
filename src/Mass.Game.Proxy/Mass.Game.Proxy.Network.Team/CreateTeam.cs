using System;
using System.Buffers;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using DotNetty.Buffers;
using DotNetty.Transport.Bootstrapping;
using DotNetty.Transport.Channels;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft.Events;
using Mass.Game.Proxy.Network.Nbt;
using Mass.Game.Proxy.Protocols;
using Mass.Game.Proxy.Protocols.Hyt;
using Mass.Game.Proxy.Protocols.OhMyGod;
using Mass.Game.Proxy.Protocols.Orange;

namespace Mass.Game.Proxy.Network.Team;

public class CreateTeam : TeamActionBase
{
	internal static CreateTeam DecorateGenericFinder;

	public string DisplayName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00樀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00萀(value);
		}
	}

	public string Prefix
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00猀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00紀(value);
		}
	}

	public string Suffix
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00戀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00氀(value);
		}
	}

	public byte FriendlyFire
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00谀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00栀(value);
		}
	}

	public HashSet<string> Players
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00瀀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00琀(value);
		}
	}

	public string NameTagVisibility
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00鄀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00縀(value);
		}
	}

	public int Color
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00輀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00舀((uint)value);
		}
	}

	public string CollisionRule
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00眀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00搀(value);
		}
	}

	public NbtTag? NbtDisplayName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (NbtTag?)_FF00_FF00_FF00蜀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00焀(value);
		}
	}

	public NbtTag? NbtPrefix
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (NbtTag?)_FF00_FF00_FF00笀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00蔀(value);
		}
	}

	public NbtTag? NbtSuffix
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (NbtTag?)_FF00_FF00_FF00最();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00渀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CreateTeam(EnumProtocolVersion version)
	{
		//IL_001b: Expected VT, but got I4
		//IL_0027: Expected Obj, but got Ref
		//IL_0033: Expected VT, but got Obj
		//IL_003f: Expected VT, but got Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)version;
		_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter = this;
		((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_0033: Stack underflow*/)._003Cpayload_003Ei__Field = (_003Cpayload_003Ej__TPar)this;
		((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_003f: Stack underflow*/)._003Cuser_id_003Ei__Field = (_003Cuser_id_003Ej__TPar)this;
		/*Error near IL_0045: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Read(IByteBuffer buffer)
	{
		_FF00_FF00_FF00贀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(IByteBuffer buffer)
	{
		_FF00_FF00_FF00言(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VerifyList()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CreateTeam ReflectCustomQueue()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00愀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776627, new IntPtr(2737368305868L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00戀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00挀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776626, new IntPtr(2737368316268L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00搀(object P_0)
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
				((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
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
	internal unsafe void _FF00_FF00_FF00攀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776589, new IntPtr(2737368314188L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00昀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776588, new IntPtr(2737368307948L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00最()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00栀(byte P_0)
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
				((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
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
	internal unsafe object _FF00_FF00_FF00椀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776591, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00樀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00欀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776590, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00氀(object P_0)
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
				((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
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
	internal unsafe void _FF00_FF00_FF00洀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776585, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00渀(object P_0)
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
				((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
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
	internal unsafe void _FF00_FF00_FF00漀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776584, new IntPtr(2737368328748L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal HashSet<string> _FF00_FF00_FF00瀀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (HashSet<string>)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00焀(object P_0)
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
				((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
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
	internal unsafe void _FF00_FF00_FF00爀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776587, new IntPtr(2737368310028L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00猀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00琀(HashSet<string> P_0)
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
				((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
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
	internal unsafe void _FF00_FF00_FF00甀(HashSet<string> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776586, new IntPtr(2737368307948L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00瘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776581, new IntPtr(2737368307948L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00眀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00砀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776580, new IntPtr(2737368308988L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00礀()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00稀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776583, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00笀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00簀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776582, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00紀(object P_0)
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
				((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
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
	internal void _FF00_FF00_FF00縀(object P_0)
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
				((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
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
	internal unsafe void _FF00_FF00_FF00缀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776577, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00耀()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00脀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776576, new IntPtr(2737368318348L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00舀(uint P_0)
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
				((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
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
	internal unsafe void _FF00_FF00_FF00茀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776579, new IntPtr(2737368325628L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00萀(object P_0)
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
				((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
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
	internal void _FF00_FF00_FF00蔀(object P_0)
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
				((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
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
	internal unsafe void _FF00_FF00_FF00蘀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776578, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00蜀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00蠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776605, new IntPtr(2737368325628L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00褀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776604, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00言(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0117: Expected I4, but got Obj
		//IL_03ed: Expected Obj, but got I4
		//IL_05e2: Expected Obj, but got I4
		//IL_0189: Expected Obj, but got I4
		//IL_0571: Expected native int or pointer, but got Obj
		//IL_0799: Expected Obj, but got I4
		//IL_017a: Expected Obj, but got I4
		//IL_061c: Expected Obj, but got I4
		//IL_061c: Expected Obj, but got I4
		//IL_046f: Expected Obj, but got Ref
		//IL_0236: Expected VT, but got I4
		//IL_0236: Expected VT, but got Obj
		//IL_0236: Expected VT, but got Ref
		//IL_0123: Expected VT, but got Obj
		//IL_012d: Expected Obj, but got I4
		//IL_012d: Expected Obj, but got Ref
		//IL_0137: Expected Obj, but got I4
		//IL_01af: Expected VT, but got Obj
		//IL_01af: Expected VT, but got Ref
		//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Expected Obj, but got Unknown
		//IL_07df: Expected I4, but got Obj
		//IL_01e9: Expected Obj, but got I4
		//IL_03b1: Expected VT, but got Obj
		//IL_044a: Expected Obj, but got I4
		//IL_076c: Expected Obj, but got I4
		//IL_04fe: Expected Obj, but got I4
		//IL_02c0: Expected VT, but got Obj
		//IL_02c0: Expected VT, but got Obj
		//IL_02c0: Expected Obj, but got Ref
		//IL_02ca: Expected Obj, but got I4
		//IL_049d: Expected Obj, but got I4
		//IL_06d6: Expected Obj, but got I4
		//IL_0424: Expected Obj, but got Ref
		//IL_042e: Expected Obj, but got I4
		//IL_0649: Expected Obj, but got I4
		//IL_013f: Expected Obj, but got I4
		//IL_0418: Expected Obj, but got I4
		//IL_021a: Expected Obj, but got I4
		//IL_0153: Expected Obj, but got I4
		//IL_0483: Expected Obj, but got I4
		//IL_0389->IL0026: Incompatible stack heights: 5 vs 2
		//IL_03f2->IL0026: Incompatible stack heights: 3 vs 2
		//IL_05ed->IL0026: Incompatible stack heights: 4 vs 2
		//IL_019e->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0590->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06ba->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06ba->IL0026: Incompatible stack types: I4 vs Ref
		//IL_07a4->IL0026: Incompatible stack heights: 4 vs 2
		//IL_017f->IL0022: Incompatible stack heights: 4 vs 1
		//IL_0627->IL0026: Incompatible stack types: I4 vs Obj
		//IL_054b->IL0026: Incompatible stack heights: 3 vs 2
		//IL_024b->IL0026: Incompatible stack heights: 1 vs 2
		//IL_013c->IL0022: Incompatible stack heights: 0 vs 1
		//IL_02b9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01ca->IL0026: Incompatible stack heights: 1 vs 2
		//IL_07b4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_07ef->IL0026: Incompatible stack heights: 1 vs 2
		//IL_01ee->IL0022: Incompatible stack heights: 3 vs 1
		//IL_03c6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_045f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0781->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0513->IL0026: Incompatible stack heights: 1 vs 2
		//IL_02df->IL0026: Incompatible stack heights: 1 vs 2
		//IL_04a8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0725->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06e1->IL0026: Incompatible stack heights: 4 vs 2
		//IL_033a->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0439->IL0026: Incompatible stack heights: 1 vs 2
		//IL_065e->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0149->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0638->IL0026: Incompatible stack types: I4 vs Obj
		//IL_041d->IL0022: Incompatible stack heights: 5 vs 1
		//IL_0225->IL0026: Incompatible stack heights: 4 vs 2
		//IL_015e->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0488->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03fd->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0534->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0750->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06fd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01a9->IL0026: Incompatible stack heights: 3 vs 2
		//IL_059b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0689->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06c5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06c5->IL0026: Incompatible stack types: I4 vs Ref
		//IL_0256->IL0026: Incompatible stack heights: 1 vs 2
		//IL_01d5->IL0026: Incompatible stack heights: 1 vs 2
		//IL_03d1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_046a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_078c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0350->IL0026: Incompatible stack types: I4 vs Obj
		//IL_051e->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0372->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02ea->IL0026: Incompatible stack heights: 1 vs 2
		//IL_04c5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0730->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02ff->IL0026: Incompatible stack types: I4 vs Obj
		//IL_039f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0669->IL0026: Incompatible stack heights: 3 vs 2
		//IL_05c6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02a7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0493->IL0026: Incompatible stack types: I4 vs Obj
		//IL_075b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0708->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0694->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04d0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05d1->IL0026: Incompatible stack types: I4 vs Obj
		ref readonly _003Caction_003Ej__TPar reference = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 22;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 20:
					((_003C_003Ef__AnonymousType0<>)P_0)._002Ector((_003Caction_003Ej__TPar)this);
					((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref reference)).Equals(32767);
					obj = 42;
					break;
				case 47:
					obj = 0;
					obj2 = 50;
					continue;
				case 58:
					((_003C_003Ef__AnonymousType0<>)((Array)obj).Length).GetHashCode();
					_ = 43;
					continue;
				case 14:
					((_003C_003Ef__AnonymousType0<>)(object)this).ToString();
					_ = ((_003C_003Ef__AnonymousType2<, , , >)(object)this)._003Cpayload_003Ei__Field;
					_003C_003Ef__AnonymousType0<>.ReflectJoinedTree();
					obj = 10;
					break;
				case 9:
					_ = ((_003C_003Ef__AnonymousType1<, , >)((Array)obj).Length).name;
					_ = 29;
					if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field == 0)
					{
						_ = 14;
					}
					continue;
				case 22:
					((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_01af: Stack underflow*/)._002Ector((_003Cname_003Ej__TPar)/*Error near IL_01af: Stack underflow*/, (_003Cuuid_003Ej__TPar)Unsafe.AsPointer(ref reference), (_003Cuser_id_003Ej__TPar)this);
					obj = ((AbstractBootstrap<ServerBootstrap, IServerChannel>)/*Error near IL_01b4: Stack underflow*/).Option<TimeSpan>((ChannelOption<TimeSpan>)/*Error near IL_01b4: Stack underflow*/, (TimeSpan)/*Error near IL_01b4: Stack underflow*/);
					_ = 21;
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectLocalTemplate != null)
					{
						_ = 8;
					}
					continue;
				case 26:
					_ = ((Array)obj).Length;
					_003C_003Ef__AnonymousType1<, , >.ReflectScalableStack();
					obj = 38;
					break;
				case 7:
					_003C_003Ef__AnonymousType1<, , >.ReflectModularWriter();
					/*Error near IL_01f5: Member reference must be method, but was: Field*/;
				case 55:
					_ = ((_003C_003Ef__AnonymousType2<, , , >)(object)this).payload;
					_ = ((_003C_003Ef__AnonymousType2<, , , >)32767).context;
					_ = 20;
					continue;
				case 19:
					((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_0236: Stack underflow*/)._002Ector((_003Curl_003Ej__TPar)Unsafe.AsPointer(ref reference), (_003Cpayload_003Ej__TPar)P_0, (_003Ccontext_003Ej__TPar)((_003C_003Ef__AnonymousType2<, , , >)(object)this).user_id, (_003Cuser_id_003Ej__TPar)32767);
					_ = 12;
					if (((EntitySocks5)EntitySocks5Account.AttachElement).Address__BackingField == null)
					{
						_ = 2;
					}
					continue;
				case 25:
					((_003C_003Ef__AnonymousType2<, , , >)(object)this).ToString();
					/*Error near IL_025d: Member reference must be method, but was: Field*/;
				case 49:
				case 57:
					if ((nint)obj != 757)
					{
						obj2 = 11;
						continue;
					}
					goto case 15;
				case 21:
					obj = ((EntityLaunchGameProxy)(object)this).GameId__BackingField;
					obj2 = 32;
					continue;
				case 35:
					((_003C_003Ef__AnonymousType3<, >)Unsafe.AsPointer(ref reference))._002Ector((_003Centry_003Ej__TPar)P_0, (_003Csid_003Ej__TPar)this);
					((_003C_003Ef__AnonymousType3<, >)/*Error near IL_02ca: Stack underflow*/).Equals((object)32767);
					_ = 24;
					if (((EntityLaunchGameProxy)EntityLaunchGameProxy.ModHashList__BackingField).Name__BackingField != null)
					{
						_ = 16;
					}
					continue;
				case 41:
				case 50:
					if ((nint)obj < ((Array)obj).Length)
					{
						obj2 = 27;
						continue;
					}
					return;
				case 42:
					((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0)(object)this)._002Ector();
					((RegexRunner)P_0).CheckTimeout();
					_ = 39;
					continue;
				case 32:
					if ((nint)obj > 340)
					{
						obj2 = 49;
						continue;
					}
					goto case 8;
				case 34:
					if ((nint)obj != 47)
					{
						obj2 = 44;
						continue;
					}
					goto case 6;
				case 1:
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectSymbolicAuditor();
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.DecorateConfigurableDecider();
					_ = 19;
					continue;
				case 44:
					if ((nint)obj != 340)
					{
						obj2 = 52;
						continue;
					}
					goto case 6;
				case 28:
					((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory)(object)this).CreateInstance()).Scan((ReadOnlySpan<char>)GameProxy.Logger__BackingField);
					obj2 = 7;
					if (GameProxy.OnlineClients != null)
					{
						obj2 = 1;
					}
					continue;
				case 2:
					((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)(object)this)._002Ector();
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.VerifyVerifier();
					_ = 6;
					if (((GameProxy)GameProxy.GameType__BackingField).GameId__BackingField != null)
					{
						_ = 14;
					}
					continue;
				case 53:
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.InstantiateVisitor();
					_ = 32767;
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.PatchWatcher();
					obj = 18;
					break;
				case 45:
					((EntitySocks5Account)Unsafe.AsPointer(ref reference))._002Ector((string)P_0, (string)(object)this);
					_ = ((EntitySocks5Account)32767).EqualityContract;
					_ = 53;
					continue;
				case 30:
					((EntitySocks5Account)(object)((EntitySocks5Account)(object)this).Username).Username = (string)32767;
					obj2 = 1;
					if ((object)((GameProxy)GameProxy.Section__BackingField).Socks5 == null)
					{
						obj2 = 1;
					}
					continue;
				case 16:
				case 51:
				case 52:
					throw new EqualityComparer<Type>((Type)Unsafe.AsPointer(ref reference));
				default:
					obj = obj;
					obj2 = 26;
					if (((GameProxy)GameProxy.BlockIrcMessages).WorkerGroup__BackingField == null)
					{
						obj2 = 47;
					}
					continue;
				case 36:
					_ = (EntitySocks5Account?)P_0 == (EntitySocks5Account?)((Array)obj).Length;
					obj2 = 54;
					continue;
				case 37:
					if ((nint)obj != 47)
					{
						obj2 = 3;
						if (((GameProxy)GameProxy._channel).DisplayAddress__BackingField != null)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 35;
				case 33:
					((FormatException)P_0)._002Ector((string?)((Array)obj).Length);
					_ = 0;
					if (GameProxy._003C_003EO._003C1_003E__OnConnectServer == null)
					{
						_ = 0;
					}
					continue;
				case 3:
					if ((nint)obj != 340)
					{
						obj2 = 17;
						continue;
					}
					goto case 45;
				case 18:
					((EqualityComparer<EntitySocks5Account>)(object)this).GetHashCode(EntitySocks5Account.RunWriter());
					_ = 58;
					continue;
				case 10:
					((EntitySocks5)(object)((EntitySocks5)(object)this).EqualityContract).Address = (string)(object)((GameProxy._003CListenAsync_003Ed__69*)(nint)this)->_003C_003E4__this;
					obj2 = 26;
					if (GameProxy._003CListenAsync_003Ed__69.CheckCentralResponder == null)
					{
						obj2 = 24;
					}
					continue;
				case 56:
					if ((nint)obj != 5)
					{
						obj2 = 37;
						if (((CpsDetector)CpsDetector._lock)._leftClicks == null)
						{
							obj2 = 25;
						}
						continue;
					}
					goto case 33;
				case 6:
					EntitySocks5.Parse((string?)(object)this);
					((EntitySocks5)32767).ToString();
					_ = 55;
					continue;
				case 15:
					_ = (EntitySocks5?)((EntitySocks5)P_0).PrintMembers((StringBuilder)(object)this) != (EntitySocks5?)32767;
					obj2 = 25;
					continue;
				case 27:
				case 48:
					obj = ((object[])obj)[obj];
					obj2 = 13;
					continue;
				case 46:
					_ = (EntitySocks5?)P_0 == (EntitySocks5?)(object)this;
					((EntitySocks5)32767).GetHashCode();
					_ = 30;
					if (((OhMyGodHwid)OhMyGodEncryption.DecorateEfficientEmitter).Hwid__BackingField != null)
					{
						_ = 22;
					}
					continue;
				case 11:
					if ((nint)obj != 763)
					{
						obj2 = 5;
						if (OhMyGodHwid.ControlProcessor == null)
						{
							obj2 = 5;
						}
						continue;
					}
					goto case 15;
				case 12:
					((EntitySocks5)/*Error near IL_069b: Stack underflow*/).Deconstruct(out Unsafe.As<_003Caction_003Ej__TPar, string>(ref reference), out *(int*)P_0, out *(EntitySocks5Account?*)this);
					EntitySocks5.ReflectConcreteEvent();
					obj2 = 9;
					reference = ref *(_003Caction_003Ej__TPar*)32767;
					if (((OhMyGodProtocol)(object)OhMyGodHwid._003C_003EO._003C2_003E__GenerateRandomDiskStoreInfo)._hwid != null)
					{
						obj2 = 1;
						reference = ref *(_003Caction_003Ej__TPar*)32767;
					}
					continue;
				case 40:
					_ = ((EntityLaunchGameProxy)(object)this).EqualityContract;
					_ = ((EntityLaunchGameProxy)32767).Session;
					_ = 2;
					continue;
				case 8:
					if ((nint)obj != 5)
					{
						obj2 = 7;
						if (HytMainMenu.CheckCentralTransmitter == null)
						{
							obj2 = 34;
						}
						continue;
					}
					goto case 6;
				case 4:
					return;
				case 39:
					obj = ((HytMainMenu.Menu)(object)this).Name;
					obj2 = 56;
					if (HytMainMenu.Menu.CustomizeTemplate == null)
					{
						obj2 = 40;
					}
					continue;
				case 5:
					if ((nint)obj != 766)
					{
						obj2 = 51;
						if (((HytMainMenu._003C_003Ec__DisplayClass2_0)(object)HytMainMenu._003C_003Ec__DisplayClass2_0.minecraft).sendGermPacket == null)
						{
							obj2 = 10;
						}
						continue;
					}
					goto case 28;
				case 31:
					((EntityLaunchGameProxy)(object)((EntityLaunchGameProxy)(object)this).ModHashList).ModHashList = (string)32767;
					obj2 = 40;
					if (HytMainMenu._003C_003Ec__DisplayClass2_1.RunMapper == null)
					{
						obj2 = 33;
					}
					continue;
				case 13:
					_ = ((EntityLaunchGameProxy)32767).ServerAddress;
					_ = 23;
					continue;
				case 23:
					obj++;
					obj2 = 41;
					continue;
				case 24:
					((EntityLaunchGameProxy)P_0).ServerPort = (int)this;
					((Action<EventMinecraft>)/*Error near IL_07e4: Stack underflow*/)._002Ector((object)/*Error near IL_07e4: Stack underflow*/, (nint)Unsafe.AsPointer(ref reference));
					_ = 36;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00謀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776607, new IntPtr(2737368305868L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00谀()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (byte)(int)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00贀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0107: Expected I4, but got Obj
		//IL_06c6: Expected Obj, but got Ref
		//IL_0414: Expected Obj, but got I4
		//IL_0120: Expected VT, but got Ref
		//IL_060f: Expected Obj, but got I4
		//IL_0381: Expected VT, but got Obj
		//IL_0386: Expected VT, but got I4
		//IL_0386: Expected Obj, but got Ref
		//IL_06d6: Expected I4, but got Obj
		//IL_06d6: Expected Obj, but got Ref
		//IL_069c: Expected Obj, but got I4
		//IL_059f: Expected I4, but got Obj
		//IL_05a4: Expected Obj, but got I4
		//IL_05a4: Expected Obj, but got Ref
		//IL_057a: Expected Obj, but got I4
		//IL_0274: Expected Obj, but got I4
		//IL_0279: Expected Obj, but got I4
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0634: Expected Obj, but got Unknown
		//IL_0512: Expected I4, but got Obj
		//IL_0512: Expected Obj, but got Ref
		//IL_0521: Expected native int or pointer, but got Obj
		//IL_05d9: Expected Obj, but got I4
		//IL_05de: Expected Obj, but got I4
		//IL_0199: Expected Obj, but got I4
		//IL_019e: Expected VT, but got Obj
		//IL_019e: Expected VT, but got Obj
		//IL_019e: Expected Obj, but got Ref
		//IL_039c: Expected VT, but got I4
		//IL_03a1: Expected Obj, but got I4
		//IL_0491: Expected Obj, but got I4
		//IL_0496: Expected Obj, but got I4
		//IL_06ee: Expected Obj, but got I4
		//IL_0645: Expected I4, but got Obj
		//IL_0645: Expected I4, but got Obj
		//IL_0645: Expected Obj, but got Ref
		//IL_05ba: Expected Obj, but got I4
		//IL_05c8: Expected Obj, but got I4
		//IL_04b2: Expected Obj, but got I4
		//IL_02b9: Expected VT, but got Obj
		//IL_02b9: Expected VT, but got Ref
		//IL_02ca: Expected Obj, but got I4
		//IL_0451: Expected Obj, but got Ref
		//IL_0453: Expected Obj, but got I4
		//IL_045c: Expected Obj, but got I4
		//IL_0236: Expected Obj, but got I4
		//IL_073f: Expected Obj, but got VT
		//IL_012d: Expected Obj, but got I4
		//IL_0132: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got VT
		//IL_06d0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06d0->IL0026: Incompatible stack types: I4 vs Ref
		//IL_042d->IL0026: Incompatible stack heights: 3 vs 2
		//IL_035c->IL0026: Incompatible stack heights: 6 vs 2
		//IL_018d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02a8->IL0026: Incompatible stack heights: 7 vs 2
		//IL_0623->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0685->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0390->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0390->IL0026: Incompatible stack types: I4 vs Ref
		//IL_06e2->IL0026: Incompatible stack heights: 1 vs 2
		//IL_033c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06ab->IL0026: Incompatible stack heights: 3 vs 2
		//IL_05ae->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0589->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0283->IL0026: Incompatible stack heights: 5 vs 2
		//IL_063e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_052b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_052b->IL0026: Incompatible stack types: Obj vs Ref
		//IL_05f2->IL0026: Incompatible stack heights: 3 vs 2
		//IL_01b2->IL0026: Incompatible stack heights: 1 vs 2
		//IL_03b5->IL0026: Incompatible stack heights: 3 vs 2
		//IL_017b->IL0026: Incompatible stack heights: 6 vs 2
		//IL_04a0->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0707->IL0026: Incompatible stack heights: 3 vs 2
		//IL_065e->IL0026: Incompatible stack heights: 3 vs 2
		//IL_01cf->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05cd->IL0022: Incompatible stack heights: 4 vs 1
		//IL_03fc->IL0026: Incompatible stack heights: 7 vs 2
		//IL_04c6->IL0026: Incompatible stack heights: 4 vs 2
		//IL_02cf->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0461->IL0022: Incompatible stack heights: 0 vs 1
		//IL_0438->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0367->IL0026: Incompatible stack heights: 6 vs 2
		//IL_024a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_050b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02b3->IL0026: Incompatible stack heights: 7 vs 2
		//IL_0558->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0724->IL0026: Incompatible stack types: I4 vs Obj
		//IL_062e->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0690->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0744->IL0026: Incompatible stack types: I4 vs Obj
		//IL_022d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0309->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0146->IL0026: Incompatible stack heights: 4 vs 2
		//IL_056e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0536->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0536->IL0026: Incompatible stack types: Obj vs Ref
		//IL_044b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05fd->IL0026: Incompatible stack heights: 3 vs 2
		//IL_01bd->IL0026: Incompatible stack heights: 1 vs 2
		//IL_03d6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03c0->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0712->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0669->IL0026: Incompatible stack heights: 3 vs 2
		//IL_021b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0268->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0407->IL0026: Incompatible stack heights: 7 vs 2
		//IL_04d1->IL0026: Incompatible stack heights: 4 vs 2
		//IL_02da->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0255->IL0026: Incompatible stack types: I4 vs Obj
		//IL_074f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0314->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0151->IL0026: Incompatible stack heights: 4 vs 2
		ref readonly _003Caction_003Ej__TPar reference = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 7;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 4:
				case 30:
					throw new EqualityComparer<_00210>((_00210?)/*Error near IL_0120: Stack underflow*/, (_00210?)Unsafe.AsPointer(ref reference));
				case 41:
					_ = 32767;
					_ = ((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType0<>.ReflectJoinedTree()).name;
					_ = 26;
					continue;
				case 7:
					obj = _003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic;
					obj2 = 6;
					continue;
				case 38:
					((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref reference))._002Ector((_003Cname_003Ej__TPar)this, (_003Cuuid_003Ej__TPar)P_0, ((_003C_003Ef__AnonymousType1<, , >)32767).user_id);
					_ = 2;
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance != null)
					{
						_ = 2;
					}
					continue;
				case 46:
					obj = ((_003C_003Ef__AnonymousType1<, , >)P_0).ToString();
					obj2 = 20;
					continue;
				case 9:
				case 10:
					_003C_003Ef__AnonymousType1<, , >.ReflectScalableStack();
					_ = 32767;
					_003C_003Ef__AnonymousType1<, , >.ReflectModularWriter();
					/*Error near IL_01e0: Member reference must be method, but was: Field*/;
				case 48:
					if ((nint)obj != 763)
					{
						obj2 = 16;
						continue;
					}
					goto IL_0121;
				case 18:
					if ((nint)obj != 5)
					{
						obj2 = 11;
						continue;
					}
					goto case 54;
				case 5:
				case 23:
				case 36:
					/*Error near IL_022d: Member reference must be method, but was: Field*/;
				case 3:
				case 13:
				case 20:
				case 25:
				case 45:
					obj = 0;
					obj2 = 51;
					if (EntitySocks5Account.AttachElement == null)
					{
						obj2 = 49;
					}
					continue;
				case 49:
				case 51:
					if (Unsafe.As<object, UIntPtr>(ref obj) < Unsafe.As<object, UIntPtr>(ref obj))
					{
						obj2 = 10;
						continue;
					}
					return;
				case 31:
					((_003C_003Ef__AnonymousType2<, , , >)((_003C_003Ef__AnonymousType2<, , , >)32767).GetHashCode()).ToString();
					_ = 28;
					continue;
				case 8:
					_ = 32767;
					_003C_003Ef__AnonymousType2<, , , >.CheckAccessibleObject();
					_003C_003Ef__AnonymousType2<, , , >.DisableDecryptor();
					_ = 38;
					if (((EntityLaunchGameProxy)EntityLaunchGameProxy.Session__BackingField).GameId__BackingField != null)
					{
						_ = 12;
					}
					continue;
				case 53:
					((_003C_003Ef__AnonymousType3<, >)/*Error near IL_02b9: Stack underflow*/)._002Ector((_003Centry_003Ej__TPar)Unsafe.AsPointer(ref reference), (_003Csid_003Ej__TPar)P_0);
					obj = (object)/*Error near IL_02bb: Stack underflow*/;
					_ = 36;
					if (((EntityLaunchGameProxy)EntityLaunchGameProxy.GameVersion__BackingField).ModHashList__BackingField != null)
					{
						_ = 45;
					}
					continue;
				case 19:
					if ((nint)obj != 340)
					{
						obj2 = 14;
						if (((EntityLaunchGameProxy)EntityLaunchGameProxy.Name__BackingField).ServerAddress__BackingField != null)
						{
							obj2 = 30;
						}
						continue;
					}
					goto case 40;
				case 32:
					/*Error near IL_0316: Member reference must be method, but was: Field*/;
				case 24:
					obj = ((EntityLaunchGameProxy)(object)this).Value__BackingField;
					obj2 = 18;
					continue;
				case 2:
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectSymbolicAuditor();
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.DecorateConfigurableDecider();
					_ = 32;
					if (GameProxy.Logger__BackingField == null)
					{
						_ = 43;
					}
					continue;
				case 17:
				{
					byte b = ((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)Unsafe.AsPointer(ref reference)).TryFindNextPossibleStartingPosition((ReadOnlySpan<char>)MemoryExtensions.IndexOfAnyExcept<T>((ReadOnlySpan<T>)this, (SearchValues<T>)P_0));
					obj2 = 15;
					reference = ref *(_003Caction_003Ej__TPar*)b;
					continue;
				}
				case 40:
					((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)P_0).TryMatchAtCurrentPosition((ReadOnlySpan<char>)32767))._002Ector();
					_ = 25;
					if (((GameProxy)GameProxy.Session__BackingField).GameType__BackingField != 0)
					{
						_ = 31;
					}
					continue;
				case 39:
					if ((nint)obj != 340)
					{
						obj2 = 36;
						continue;
					}
					goto case 29;
				case 50:
					_ = ((GameProxy)(object)this).GameId__BackingField;
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.InstantiateVisitor();
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.PatchWatcher();
					_ = 46;
					if (((GameProxy)GameProxy.ServerAddress__BackingField).ServerPort__BackingField != 0)
					{
						_ = 20;
					}
					continue;
				case 22:
					return;
				case 1:
					((EntitySocks5Account)P_0).Username = ((EntitySocks5Account)32767).Username;
					_ = 21;
					if ((object)((GameProxy)GameProxy.Section__BackingField).Socks5 == null)
					{
						_ = 9;
					}
					continue;
				case 35:
					if ((nint)obj != 47)
					{
						obj2 = 39;
						continue;
					}
					goto case 29;
				case 54:
					obj = ((EqualityComparer<Type>)Unsafe.AsPointer(ref reference)).GetHashCode((Type)P_0);
					obj = 25;
					break;
				case 42:
					((EntitySocks5Account)((EntitySocks5Account?)P_0 == (EntitySocks5Account?)32767)).GetHashCode();
					_ = 44;
					continue;
				case 52:
					((EntitySocks5Account)((EntitySocks5Account)P_0).Equals((EntitySocks5Account?)((GameProxy)(object)this).DisplayAddress__BackingField))._003CClone_003E_0024();
					_ = 0;
					if (GameProxy._003C_003EO._003C0_003E__PluginChanged != null)
					{
						_ = 0;
					}
					continue;
				case 6:
					if ((nint)obj <= 340)
					{
						obj2 = 12;
						continue;
					}
					goto case 27;
				case 34:
				{
					((EntitySocks5)/*Error near IL_0512: Stack underflow*/)._002Ector((string)Unsafe.AsPointer(ref reference), (int)this, (EntitySocks5Account?)P_0);
					Type equalityContract = ((EntitySocks5)/*Error near IL_0517: Stack underflow*/).EqualityContract;
					obj2 = 1;
					reference = ref *(_003Caction_003Ej__TPar*)equalityContract;
					if (((GameProxy._003CListenAsync_003Ed__69*)(nint)GameProxy._003CListenAsync_003Ed__69._003C_003E4__this)->port != 0)
					{
						obj2 = 14;
						reference = ref *(_003Caction_003Ej__TPar*)equalityContract;
					}
					continue;
				}
				case 11:
					if ((nint)obj != 47)
					{
						obj2 = 19;
						continue;
					}
					goto case 47;
				case 27:
					if ((nint)obj != 757)
					{
						obj2 = 48;
						continue;
					}
					goto IL_0121;
				case 29:
					((EntitySocks5)P_0).Port = ((EntitySocks5)32767).Port;
					_ = 37;
					continue;
				case 28:
					((EntitySocks5)Unsafe.AsPointer(ref reference)).Account = (EntitySocks5Account?)((EqualityComparer<EnumGameType>)(object)this).GetHashCode((EnumGameType)P_0);
					_ = 53;
					continue;
				case 47:
					EntitySocks5.Parse((string?)32767).ToString();
					obj = 17;
					break;
				case 37:
					_ = (EntitySocks5?)(object)this != (EntitySocks5?)((EntitySocks5)P_0).PrintMembers((StringBuilder)32767);
					_ = 16;
					if (OrangeProtocol.StartMapper != null)
					{
						_ = 42;
					}
					continue;
				case 14:
					((EntitySocks5)((EntitySocks5)P_0).Equals((EntitySocks5?)OhMyGodEncryption.DecorateEfficientEmitter))._003CClone_003E_0024();
					_ = 50;
					if (OhMyGodHwid._003C_003EO._003C0_003E__GenerateRandomMac == null)
					{
						_ = 36;
					}
					continue;
				case 33:
					obj++;
					obj2 = 49;
					continue;
				case 44:
					((EqualityComparer<EnumGameVersion>)Unsafe.AsPointer(ref reference)).Equals((EnumGameVersion)(int)this, (EnumGameVersion)(int)P_0);
					EntitySocks5.DecorateConnectedWrapper();
					_ = 24;
					if (((OhMyGodProtocol)OhMyGodProtocol._hwid)._data == null)
					{
						_ = 9;
					}
					continue;
				case 15:
					obj = ((EntityLaunchGameProxy)P_0).Session;
					obj2 = 13;
					if (HytMainMenu.CheckCentralTransmitter == null)
					{
						obj2 = 0;
					}
					continue;
				case 26:
					((EntityLaunchGameProxy)P_0).GameId = (string)32767;
					_ = ((EntityLaunchGameProxy)(object)this).GameType;
					_ = 34;
					continue;
				default:
				{
					((DefaultInterpolatedStringHandler*)this)->AppendLiteral((string)P_0);
					EnumGameVersion gameVersion = ((EntityLaunchGameProxy)Unsafe.AsPointer(ref reference)).GameVersion;
					obj2 = 41;
					reference = ref *(_003Caction_003Ej__TPar*)(uint)gameVersion;
					continue;
				}
				case 21:
					((EntityLaunchGameProxy)Unsafe.AsPointer(ref reference)).GameVersion = (EnumGameVersion)(int)P_0;
					obj = (object)/*Error near IL_06d8: Stack underflow*/;
					_ = 3;
					continue;
				case 43:
					((EntityLaunchGameProxy)P_0).ModHashList = ((EntityLaunchGameProxy)32767).ModHashList;
					_ = 1;
					if (HytMainMenu._003C_003Ec__DisplayClass2_1.RunMapper == null)
					{
						_ = 1;
					}
					continue;
				case 12:
					if ((nint)obj != 5)
					{
						obj2 = 35;
						continue;
					}
					goto case 29;
				case 16:
					{
						if ((nint)obj != 766)
						{
							obj2 = 5;
							if (((HytMainMenu._003C_003Ec__DisplayClass2_2)HytMainMenu._003C_003Ec__DisplayClass2_2.kvp).CS_0024_003C_003E8__locals2 == null)
							{
								obj2 = 4;
							}
							continue;
						}
						goto case 52;
					}
					IL_0121:
					((_003C_003Ef__AnonymousType0<>)((_003C_003Ef__AnonymousType0<>)P_0).Equals((object)32767)).GetHashCode();
					_ = 32;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field == 0)
					{
						_ = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00踀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776606, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00輀()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (uint)(int)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00退()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776601, new IntPtr(2737368306908L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00鄀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00鈀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776600, new IntPtr(2737368329788L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
