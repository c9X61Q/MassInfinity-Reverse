using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using DotNetty.Codecs;

namespace Mass.Game.Proxy;

public record EntitySocks5
{
	[CompilerGenerated]
	protected virtual Type EqualityContract
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (Type)_FF00_FF00_FF00_FF00_FF00_FF00ꀀ();
		}
	}

	public string Address
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00頀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00_FF00蜀(value);
		}
	}

	public int Port
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00_FF00_FF00_FF00耀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00_FF00騀((uint)value);
		}
	}

	public EntitySocks5Account? Account
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (EntitySocks5Account?)_FF00_FF00_FF00_FF00_FF00_FF00鄀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00_FF00退(value);
		}
	}

	[CompilerGenerated]
	private readonly object Address__BackingField;

	[CompilerGenerated]
	private readonly nint Port__BackingField;

	private static object DecorateDynamicModule;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe EntitySocks5(string Address, int Port, EntitySocks5Account? Account = null)
	{
		//IL_001b: Expected VT, but got Obj
		//IL_0027: Expected VT, but got I4
		//IL_003e: Expected Obj, but got Ref
		//IL_004d: Expected Obj, but got VT
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)Address;
		((_003C_003Ef__AnonymousType1<, , >)this)._003Cuser_id_003Ei__Field = (_003Cuser_id_003Ej__TPar)Port;
		_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter = Account;
		string.Format((IFormatProvider?)/*Error near IL_003e: Stack underflow*/, (string)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (object?[])(object)this);
		int num = 0;
		if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field != 0)
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
	public unsafe static EntitySocks5? Parse(string? format)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 78, 1790778653, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778653, new IntPtr(2737367920284L), 15);
		}
		return (EntitySocks5?)((delegate*<object, object>)obj)(format);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public override string ToString()
	{
		return (string)_FF00_FF00_FF00_FF00_FF00_FF00鴀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	protected virtual bool PrintMembers(StringBuilder builder)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00謀(builder) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public override int GetHashCode()
	{
		return (int)_FF00_FF00_FF00_FF00_FF00_FF00鸀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public virtual bool Equals(EntitySocks5? other)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00鐀(other) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	protected unsafe EntitySocks5(EntitySocks5 original)
	{
		//IL_001a: Expected VT, but got Obj
		//IL_001a: Expected VT, but got Ref
		//IL_0023: Expected Obj, but got I4
		//IL_0046: Expected I4, but got Obj
		//IL_0058: Expected Obj, but got VT
		//IL_007d: Expected Obj, but got VT
		//IL_0099: Expected VT, but got Obj
		//IL_00a8: Expected Obj, but got VT
		//IL_0062->IL0031: Incompatible stack types: I4 vs Obj
		//IL_0082->IL0031: Incompatible stack types: I4 vs Obj
		//IL_00ad->IL0031: Incompatible stack types: I4 vs Obj
		//IL_008d->IL0031: Incompatible stack types: I4 vs Obj
		//IL_00b8->IL0031: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((EqualityComparer<_00210>)/*Error near IL_001a: Stack underflow*/).Equals((_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00210?)this);
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				return;
			default:
				_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter = ((_003C_003Ef__AnonymousType1<, , >)(object)original)._003Cuser_id_003Ei__Field;
				obj2 = 3;
				break;
			case 2:
				((_003C_003Ef__AnonymousType2<, , , >)this)._003Cpayload_003Ei__Field = (_003Cpayload_003Ej__TPar)((_003C_003Ef__AnonymousType2<, , , >)(object)original)._003Curl_003Ei__Field;
				obj2 = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Ccontext_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				((_003C_003Ef__AnonymousType3<, >)this)._003Centry_003Ei__Field = (_003Centry_003Ej__TPar)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic;
				obj2 = 1;
				if (_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument == null)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public unsafe void Deconstruct(out string Address, out int Port, out EntitySocks5Account? Account)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00舀((nint)Unsafe.AsPointer(ref Address), (nint)Unsafe.AsPointer(ref Port), (nint)Unsafe.AsPointer(ref Account));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectConcreteEvent()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EntitySocks5 DecorateConnectedWrapper()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00缀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778652, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00_FF00_FF00_FF00耀()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (uint)(int)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00脀(nint P_0, nint P_1, nint P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778655, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00舀(nint P_0, nint P_1, nint P_2)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_005a: Expected Obj, but got I
		//IL_005b: Expected Obj, but got I4
		//IL_0081: Expected native int or pointer, but got Obj
		//IL_0091: Expected Obj, but got VT
		//IL_0047: Expected VT, but got Obj
		//IL_0047: Expected Obj, but got I
		//IL_0048: Expected Obj, but got Ref
		//IL_006f->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0096->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0052->IL0026: Incompatible stack heights: 1 vs 2
		//IL_007a->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00a1->IL0026: Incompatible stack heights: 3 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 3;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 3:
				((_003C_003Ef__AnonymousType0<>)P_0)._002Ector((_003Caction_003Ej__TPar)this);
				Unsafe.Write((void*)(nint)/*Error near IL_0048: Stack underflow*/, (object)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
				_ = 2;
				break;
			case 0:
				return;
			case 1:
				Unsafe.As<_003Caction_003Ej__TPar, object>(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field) = ((_003C_003Ef__AnonymousType0<>)P_2).Equals(this);
				_ = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field != 0)
				{
					_ = 0;
				}
				break;
			case 2:
				*(int*)(nint)this = (_003C_003Ef__AnonymousType0<>.ReflectActiveCalc() ? 1 : 0);
				_ = 1;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Ccontext_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00茀(nint P_0, nint P_1, nint P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778654, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00萀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778649, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00蔀(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0055: Expected Obj, but got VT
		//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0065->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				if (P_0 == null)
				{
					obj2 = 0;
					if ((int)((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field)._003Cuser_id_003Ei__Field != 0)
					{
						obj2 = 1;
					}
					break;
				}
				goto default;
			default:
				return _003C_003Ef__AnonymousType0<>.ReflectActiveCalc() ? ((byte)1) : ((byte)0);
			case 1:
				return 0;
			case 3:
				if (P_0 == P_1)
				{
					return 1;
				}
				obj2 = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00蘀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778648, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00蜀(object P_0)
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
	protected unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00謀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004b: Expected I4, but got Obj
		//IL_0102: Expected Obj, but got VT
		//IL_0126: Expected VT, but got Obj
		//IL_0126: Expected VT, but got Obj
		//IL_0126: Expected VT, but got Ref
		//IL_00b2: Expected VT, but got Ref
		//IL_0057: Expected VT, but got Obj
		//IL_005c: Expected VT, but got Ref
		//IL_00d9: Expected VT, but got I4
		//IL_0140->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00bd->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00ce->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0071->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00ee->IL0026: Incompatible stack heights: 1 vs 2
		//IL_014b->IL0026: Incompatible stack heights: 1 vs 2
		//IL_007c->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00f9->IL0026: Incompatible stack heights: 1 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 6:
				((_003C_003Ef__AnonymousType0<>)(*(ByteToMessageDecoder*)P_0)/*cast due to constrained. prefix*/)._002Ector((_003Caction_003Ej__TPar)this);
				((EqualityComparer<_00210>)(*(ByteToMessageDecoder*)/*Error near IL_005c: Stack underflow*/)/*cast due to constrained. prefix*/).GetHashCode((_00210)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
				_ = 2;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
				{
					_ = 7;
				}
				break;
			case 5:
				((_003C_003Ef__AnonymousType0<>)ByteToMessageDecoder/*cast due to constrained. prefix*/).ReflectActiveCalc();
				/*Error near IL_0082: Member reference must be method, but was: Field*/;
			case 3:
			{
				_003Cuser_id_003Ej__TPar user_id = ((_003C_003Ef__AnonymousType1<, , >)(*(ByteToMessageDecoder*)P_0)).user_id;
				((EqualityComparer<_00212>)(*(ByteToMessageDecoder*)/*Error near IL_00b2: Stack underflow*/)/*cast due to constrained. prefix*/).Equals((_00212?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00212?)user_id);
				_ = 6;
				break;
			}
			case 1:
				return 1;
			case 4:
				_ = ((EqualityComparer<_00211>)ByteToMessageDecoder).Default;
				_ = 3;
				break;
			case 7:
			{
				int hashCode = ((_003C_003Ef__AnonymousType1<, , >)(*(ByteToMessageDecoder*)P_0)/*cast due to constrained. prefix*/).GetHashCode();
				((EqualityComparer<_00211>)Unsafe.As<_003Caction_003Ej__TPar, ByteToMessageDecoder>(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)/*cast due to constrained. prefix*/).GetHashCode((_00211)hashCode);
				_ = 0;
				if ((int)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_defaultTimeout != 0)
				{
					_ = 0;
				}
				break;
			}
			default:
				obj = ((_003C_003Ef__AnonymousType2<, , , >)this).url;
				_ = ref obj;
				/*Error near IL_0104: Member reference must be method, but was: Field*/;
			case 2:
				((_003C_003Ef__AnonymousType2<, , , >)(*(ByteToMessageDecoder*)/*Error near IL_0126: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((_003Curl_003Ej__TPar)/*Error near IL_0126: Stack underflow*/, (_003Cpayload_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_003Ccontext_003Ej__TPar)P_0, (_003Cuser_id_003Ej__TPar)this);
				((EqualityComparer<_00213>)(*(ByteToMessageDecoder*)/*Error near IL_012b: Stack underflow*/)/*cast due to constrained. prefix*/).Equals((_00213?)/*Error near IL_012b: Stack underflow*/, (_00213?)/*Error near IL_012b: Stack underflow*/);
				_ = 1;
				if (((EntitySocks5)EntitySocks5.Address__BackingField).Port__BackingField == 0)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00谀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778651, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00贀(object P_0, object P_1)
	{
		//IL_001b: Expected VT, but got Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType0<>)P_0)._002Ector((_003Caction_003Ej__TPar)P_1);
		return (Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field) == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00踀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778650, new IntPtr(2737367928604L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00輀()
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00退(object P_0)
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
	internal object _FF00_FF00_FF00_FF00_FF00_FF00鄀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00鈀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778645, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00錀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778644, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00鐀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004b: Expected I4, but got Obj
		//IL_00f9: Expected VT, but got Ref
		//IL_0055: Expected VT, but got Ref
		//IL_0066: Expected Obj, but got VT
		//IL_0066: Expected Obj, but got I4
		//IL_00cb: Expected VT, but got Obj
		//IL_00cb: Expected VT, but got Ref
		//IL_007a: Expected Obj, but got VT
		//IL_006b->IL013e: Incompatible stack heights: 0 vs 1
		//IL_00d5->IL00f4: Incompatible stack heights: 0 vs 1
		//IL_007f->IL0026: Incompatible stack heights: 1 vs 2
		//IL_013e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e9->IL0026: Incompatible stack heights: 1 vs 2
		//IL_008a->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00f4->IL0026: Incompatible stack heights: 1 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 6;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				if (string.Format((IFormatProvider?)((EqualityComparer<_00210>)/*Error near IL_0055: Stack underflow*/).Equals((_00210?)/*Error near IL_0055: Stack underflow*/, (_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)), (string)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuser_id_003Ei__Field, (object?[])_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter) == null)
				{
					_ = 0;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field == 0)
					{
						_ = 0;
					}
					break;
				}
				goto case 3;
			case 6:
				if (this == P_0)
				{
					return 1;
				}
				obj2 = 5;
				break;
			case 7:
				((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_00cb: Stack underflow*/)._002Ector((_003Cname_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_003Cuuid_003Ej__TPar)((_003C_003Ef__AnonymousType1<, , >)(object)this).user_id, (_003Cuser_id_003Ej__TPar)P_0);
				if (EqualityComparer<_00211>.Default == null)
				{
					_ = 1;
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectLocalTemplate != null)
					{
						_ = 4;
					}
					break;
				}
				goto case 1;
			case 1:
				((EqualityComparer<_00212>)/*Error near IL_00f9: Stack underflow*/).GetHashCode((_00212)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
				_ = _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_defaultTimeout;
				_ = _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_hasTimeout;
				/*Error near IL_0105: Member reference must be method, but was: Field*/;
			case 5:
				if (P_0 != null)
				{
					obj2 = 7;
					break;
				}
				goto default;
			case 3:
				_ = EqualityComparer<_00213>.Default;
				_ = EntitySocks5Account.AttachElement;
				_ = ((EntitySocks5)P_0).Address__BackingField;
				/*Error near IL_014f: Member reference must be method, but was: Field*/;
			default:
				return 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00销()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00阀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778647, new IntPtr(2737367929644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00需(object P_0)
	{
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType0<>)(object)this).Equals((object)(P_0 as _003C_003Ef__AnonymousType2<, , , >)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00頀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00餀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778646, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00騀(uint P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00鬀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778641, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00鴀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 10373, 1790778640, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778640, new IntPtr(2737367899484L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00鸀()
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
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00鼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778643, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe object _FF00_FF00_FF00_FF00_FF00_FF00ꀀ()
	{
		//IL_001e: Expected Obj, but got Ref
		//IL_001f: Expected Obj, but got I4
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((EqualityComparer<_00210>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).GetHashCode((_00210)typeof(_003C_003Ef__AnonymousType2<, , , >).TypeHandle);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00ꄀ()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00ꐀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778642, new IntPtr(2737367924444L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00ꔀ(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0083: Expected I4, but got Obj
		//IL_022a: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got VT
		//IL_00db: Expected Obj, but got VT
		//IL_017b: Expected VT, but got I4
		//IL_017b: Expected Obj, but got I4
		//IL_017d: Expected Obj, but got I4
		//IL_0186: Expected Obj, but got I4
		//IL_02fe: Expected Obj, but got I
		//IL_02a4: Expected VT, but got Ref
		//IL_0131: Expected Obj, but got VT
		//IL_0214->IL0026: Incompatible stack types: I4 vs Obj
		//IL_019b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0234->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0224->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0241->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e0->IL0026: Incompatible stack heights: 4 vs 2
		//IL_018b->IL0022: Incompatible stack heights: 2 vs 1
		//IL_0303->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0165->IL0026: Incompatible stack heights: 4 vs 2
		//IL_032a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0136->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02bc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_025c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00eb->IL0026: Incompatible stack heights: 4 vs 2
		//IL_030e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0170->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0335->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0141->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0267->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 2;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 8:
				case 10:
					if (((Array)obj).Length == 2)
					{
						obj2 = 14;
						break;
					}
					goto case 19;
				case 12:
					obj = ((object[])obj)[0];
					obj2 = 3;
					if ((int)((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field)._003Cuser_id_003Ei__Field != 0)
					{
						obj2 = 4;
					}
					break;
				case 21:
					obj = new { };
					_ = 8;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field == 0)
					{
						_ = 4;
					}
					break;
				case 20:
					_ = ((object[])obj)[1];
					_ = 58;
					_ = 0;
					/*Error near IL_00f2: Member reference must be method, but was: Field*/;
				case 7:
					if (((Array)obj).Length == 2)
					{
						obj2 = 6;
						if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType3<, >._003Centry_003Ei__Field)._003Csid_003Ei__Field != 0)
						{
							obj2 = 12;
						}
						break;
					}
					goto case 19;
				case 5:
					_ = ((object[])obj)[1];
					_ = ref obj;
					if (EqualityComparer<_00211>.Default == null)
					{
						_ = 2;
						if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectLocalTemplate == null)
						{
							_ = 17;
						}
						break;
					}
					return new { };
				case 1:
					return null;
				case 4:
					obj = ((object[])obj)[1];
					obj2 = 21;
					break;
				case 3:
				case 16:
					obj = null;
					obj2 = 18;
					break;
				case 14:
					obj = ((object[])obj)[0];
					obj2 = 5;
					break;
				case 9:
					obj = ((Array)obj).Length;
					obj2 = 6;
					break;
				case 15:
					obj = null;
					obj2 = 9;
					break;
				case 18:
					if (obj == null)
					{
						obj2 = 10;
						if (((EntitySocks5)EntitySocks5Account.AttachElement).Address__BackingField != null)
						{
							obj2 = 1;
						}
						break;
					}
					goto case 7;
				default:
					_ = ((object[])obj)[0];
					_ = 58;
					_ = 0;
					/*Error near IL_026e: Member reference must be method, but was: Field*/;
				case 17:
					_ = ((object[])obj)[1];
					_003C_003Ef__AnonymousType2<, , , >.CheckAccessibleObject();
					/*Error near IL_0288: Member reference must be method, but was: Field*/;
				case 19:
					((_003C_003Ef__AnonymousType3<, >)/*Error near IL_02a4: Stack underflow*/)._002Ector((_003Centry_003Ej__TPar)/*Error near IL_02a4: Stack underflow*/, (_003Csid_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
					/*Error near IL_02a4: Member reference must be method, but was: Field*/;
				case 11:
					if ((nint)obj != 2)
					{
						obj2 = 19;
						break;
					}
					goto default;
				case 13:
					_ = ((object[])obj)[0];
					_ = 58;
					_ = 0;
					/*Error near IL_02c3: Member reference must be method, but was: Field*/;
				case 2:
					if (P_0 != null)
					{
						goto end_IL_0026;
					}
					obj2 = 1;
					if (((EntityLaunchGameProxy)EntityLaunchGameProxy.ServerPort__BackingField).Socks5__BackingField == null)
					{
						obj2 = 0;
					}
					break;
				case 6:
					if ((nint)obj != 1)
					{
						obj2 = 11;
						if (((EntityLaunchGameProxy)EntityLaunchGameProxy.Value__BackingField).IsGame__BackingField != 0)
						{
							obj2 = 5;
						}
						break;
					}
					goto case 13;
				}
				continue;
				end_IL_0026:
				break;
			}
			obj = ((EqualityComparer<_00212>)64).GetHashCode((_00212)0);
			obj = 15;
		}
	}
}
