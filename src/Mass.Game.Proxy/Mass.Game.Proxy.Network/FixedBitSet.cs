using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using Mass.Application.Event;
using Mass.Game.Proxy.Minecraft.Events;

namespace Mass.Game.Proxy.Network;

public class FixedBitSet
{
	private readonly object _data;

	internal static FixedBitSet ReflectConcreteComparator;

	public int Length
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00_FF00瘀();
		}
	}

	public int ByteLength
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_FF00_FF00_FF00稀();
		}
	}

	public ReadOnlyMemory<byte> Data
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00栀();
		}
	}

	public bool this[int index]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00眀((uint)index) != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00爀((uint)index, value ? ((byte)1) : ((byte)0));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe FixedBitSet(int bitLength)
	{
		//IL_001a: Expected VT, but got Obj
		//IL_001a: Expected VT, but got Ref
		//IL_0029: Expected Obj, but got VT
		//IL_00a3: Expected Obj, but got I4
		//IL_00b0: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got VT
		//IL_009e->IL0042: Incompatible stack heights: 3 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		bool flag = ((EqualityComparer<_00210>)/*Error near IL_001a: Stack underflow*/).Equals((_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00210?)this);
		int num = 0;
		if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 3:
				_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic = new JsonConverter<>[_003C_003Ef__AnonymousType0<>.ReflectJoinedTree()];
				_ = 2;
				continue;
			case 1:
				throw new EqualityComparer<_00212>((_00212?)/*Error near IL_00a8: Stack underflow*/, (_00212?)((_003C_003Ef__AnonymousType1<, , >)flag).user_id);
			}
			if (bitLength <= 0)
			{
				num = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field != 0)
				{
					num = 1;
				}
			}
			else
			{
				_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument = bitLength;
				num = 3;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe FixedBitSet(byte[] data, int bitLength)
	{
		//IL_001a: Expected VT, but got Obj
		//IL_001a: Expected VT, but got Ref
		//IL_0092: Expected Obj, but got I4
		//IL_0097: Expected Obj, but got VT
		//IL_0130: Expected VT, but got I4
		//IL_0064: Expected Obj, but got I4
		//IL_007d: Expected Obj, but got VT
		//IL_00ff: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I4
		//IL_013f: Expected Obj, but got I4
		//IL_0052: Expected I4, but got Obj
		//IL_0024->IL002d: Incompatible stack types: I4 vs Obj
		//IL_0082->IL002d: Incompatible stack heights: 1 vs 2
		//IL_015f->IL002d: Incompatible stack types: I4 vs Obj
		//IL_008d->IL002d: Incompatible stack heights: 1 vs 2
		//IL_011f->IL002d: Incompatible stack types: I4 vs Obj
		//IL_014e->IL002d: Incompatible stack types: I4 vs Obj
		//IL_012a->IL002d: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		bool flag = ((EqualityComparer<_00210>)/*Error near IL_001a: Stack underflow*/).Equals((_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00210?)this);
		object obj = 4;
		while (true)
		{
			switch ((int)obj)
			{
			case 5:
				((EventBus)flag).Register((Action<EventPluginChanged>)(object)this, ((_003C_003Ef__AnonymousType0<>)(object)data).Equals((object)this) ? 1 : 0);
				((EventBus)/*Error near IL_0069: Stack underflow*/).Register((Action<EventMinecraft>)/*Error near IL_0069: Stack underflow*/, (int)/*Error near IL_0069: Stack underflow*/);
				((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_006e: Stack underflow*/)._003Cpayload_003Ei__Field = (_003Cpayload_003Ej__TPar)/*Error near IL_006e: Stack underflow*/;
				_ = 1;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Ccontext_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
				{
					_ = 0;
				}
				break;
			default:
				throw new EqualityComparer<_00212>((_00212?)/*Error near IL_009c: Stack underflow*/, (_00212?)((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType1<, , >)flag).uuid).user_id);
			case 3:
				_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument = bitLength;
				obj = 5;
				break;
			case 6:
				_ = ((_003C_003Ef__AnonymousType2<, , , >)flag).url;
				/*Error near IL_00ff: Member reference must be method, but was: Field*/;
			case 7:
				if (data == null)
				{
					obj = 2;
					if (((EntitySocks5Account)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.GuideMap).Username__BackingField == null)
					{
						obj = 0;
					}
					break;
				}
				if (data.Length >= ((_003C_003Ef__AnonymousType2<, , , >)bitLength).GetHashCode())
				{
					obj = 3;
					break;
				}
				goto default;
			case 1:
				return;
			case 2:
				((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_0130: Stack underflow*/)._002Ector((_003Curl_003Ej__TPar)/*Error near IL_0130: Stack underflow*/, (_003Cpayload_003Ej__TPar)/*Error near IL_0130: Stack underflow*/, (_003Ccontext_003Ej__TPar)/*Error near IL_0130: Stack underflow*/, (_003Cuser_id_003Ej__TPar)flag);
				throw new EqualityComparer<_00213>((_00213?)/*Error near IL_0135: Stack underflow*/, (_00213?)/*Error near IL_0135: Stack underflow*/);
			case 4:
				if (bitLength > 0)
				{
					obj = 7;
					break;
				}
				goto case 6;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return (string)_FF00_FF00_FF00_FF00怀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] ToArray()
	{
		return (byte[])_FF00_FF00_FF00_FF00漀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int FixedBitSetLength(int bitLength)
	{
		return (int)_FF00_FF00_FF00_FF00挀((uint)bitLength);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QueryPredictor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FixedBitSet SolveInterpreter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00开()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778050, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00怀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 7762, 1790778077, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778077, new IntPtr(2737368312108L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00愀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778076, new IntPtr(2737368314188L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_FF00戀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778079, new IntPtr(2737368326668L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint _FF00_FF00_FF00_FF00挀(uint P_0)
	{
		return (uint)((int)(P_0 + 7) / 8);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_FF00搀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778078, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ReadOnlyMemory<byte> _FF00_FF00_FF00_FF00栀()
	{
		//IL_001f: Expected Obj, but got Ref
		//IL_0020: Expected VT, but got I4
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (ReadOnlyMemory<byte>)((EqualityComparer<_00210>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).GetHashCode((_00210)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00椀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778073, new IntPtr(2737368322508L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00樀()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00欀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778072, new IntPtr(2737368306908L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00氀(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0041: Expected VT, but got Ref
		//IL_0047: Expected Obj, but got Ref
		//IL_0048: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got VT
		//IL_0078->IL003c: Incompatible stack heights: 3 vs 1
		//IL_008c->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0097->IL0026: Incompatible stack heights: 4 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			case 2:
				((_003C_003Ef__AnonymousType0<>)/*Error near IL_0041: Stack underflow*/)._002Ector((_003Caction_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
				return (object)/*Error near IL_0042: Stack underflow*/;
			default:
				return ((_003C_003Ef__AnonymousType0<>)/*Error near IL_0047: Stack underflow*/).Equals((object)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
			case 1:
				if (_003C_003Ef__AnonymousType0<>.ReflectActiveCalc())
				{
					_ = 0;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Ccontext_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
					{
						_ = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00洀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778075, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00渀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778074, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00漀()
	{
		//IL_001f: Expected Ref, but got VT
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		Unsafe.As<_003Caction_003Ej__TPar, AsyncTaskMethodBuilder>(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field).Start(ref *(GameProxy._003CListenAsync_003Ed__69*)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field);
		return (object)/*Error near IL_0020: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00瀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778069, new IntPtr(2737368325628L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00爀(uint P_0, byte P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004f: Expected I4, but got Obj
		//IL_0157: Invalid comparison between I4 and VT
		//IL_0059: Expected VT, but got Ref
		//IL_00e7: Expected Obj, but got I4
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got VT
		//IL_0098: Expected Obj, but got VT
		//IL_0064: Expected Obj, but got I4
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0078->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0166->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0121->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0106->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0196->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0083->IL0026: Incompatible stack types: I4 vs Obj
		//IL_012c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01a1->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				((_003C_003Ef__AnonymousType0<>)/*Error near IL_0059: Stack underflow*/)._002Ector((_003Caction_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
				throw new EqualityComparer<_00210>((_00210)/*Error near IL_005e: Stack underflow*/);
			default:
				if (P_1 == 0)
				{
					obj2 = 8;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field == 0)
					{
						obj2 = 8;
					}
					break;
				}
				goto case 7;
			case 7:
			{
				ref Attribute reference2 = ref ((Attribute[])((_003C_003Ef__AnonymousType2<, , , >)this)._003Cuser_id_003Ei__Field)[obj];
				Unsafe.As<Attribute, byte>(ref reference2) = (byte)(Unsafe.As<Attribute, byte>(ref reference2) | (byte)(1 << (int)obj));
				obj2 = 2;
				if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType3<, >._003Centry_003Ei__Field)._003Csid_003Ei__Field != 0)
				{
					obj2 = 6;
				}
				break;
			}
			case 3:
				return;
			case 5:
				obj = (int)P_0 % 8;
				obj2 = 0;
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance == null)
				{
					obj2 = 0;
				}
				break;
			case 2:
				if ((int)P_0 >= 0)
				{
					obj2 = 1;
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.StoreConverter != null)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 4;
			case 1:
				if (Unsafe.As<object, UIntPtr>(ref (object)P_0) >= Unsafe.As<_003Cpayload_003Ej__TPar, UIntPtr>(ref ((_003C_003Ef__AnonymousType2<, , , >)this).payload))
				{
					obj2 = 4;
					break;
				}
				obj = (int)P_0 / 8;
				obj2 = 4;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field != 0)
				{
					obj2 = 5;
				}
				break;
			case 6:
				return;
			case 8:
			{
				ref void reference = ref ((void[])_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.GuideMap)[obj];
				Unsafe.As<void, byte>(ref reference) = (byte)(Unsafe.As<void, byte>(ref reference) & (byte)(~(1 << (int)obj)));
				obj2 = 3;
				if (EntitySocks5Account.AttachElement == null)
				{
					obj2 = 0;
				}
				break;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00猀(uint P_0, byte P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778068, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00琀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778071, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00甀()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00_FF00瘀()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (uint)(int)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00眀(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_004f: Expected VT, but got Obj
		//IL_004f: Expected Obj, but got I4
		//IL_004f: Invalid comparison between Unknown and Ref
		//IL_00b6: Expected Obj, but got I4
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got VT
		//IL_00eb: Expected Obj, but got VT
		//IL_00c0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b1->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0068->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00f0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0073->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00fb->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				((_003C_003Ef__AnonymousType0<>)P_0)._002Ector((_003Caction_003Ej__TPar)this);
				if (!Unsafe.IsAddressLessThan(ref *(byte*)/*Error near IL_0054: Stack underflow*/, ref Unsafe.As<_003Caction_003Ej__TPar, byte>(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)))
				{
					_ = 0;
					if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
					{
						_ = 0;
					}
				}
				else
				{
					obj = (int)P_0 / 8;
					_ = 2;
				}
				break;
			default:
				_003C_003Ef__AnonymousType0<>.ReflectJoinedTree();
				/*Error near IL_009c: Member reference must be method, but was: Field*/;
			case 2:
				obj = (int)P_0 % 8;
				obj2 = 3;
				break;
			case 3:
				return ((((byte[])_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)[obj] & (1 << (int)obj)) != 0) ? ((byte)1) : ((byte)0);
			case 5:
				if ((int)P_0 < 0)
				{
					obj2 = 4;
					if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType3<, >._003Centry_003Ei__Field)._003Csid_003Ei__Field != 0)
					{
						obj2 = 2;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00砀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778070, new IntPtr(2737368301708L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00礀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778065, new IntPtr(2737368319388L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00稀()
	{
		//IL_001a: Expected VT, but got Obj
		//IL_001a: Expected Obj, but got Ref
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Caction_003Ej__TPar)this);
		return ((_003C_003Ef__AnonymousType0<>)/*Error near IL_001f: Stack underflow*/).Equals((object)/*Error near IL_001f: Stack underflow*/) ? 1u : 0u;
	}
}
