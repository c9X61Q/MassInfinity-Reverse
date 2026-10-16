using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using DotNetty.Buffers;
using Mass.Application.Event;
using Mass.Game.Proxy.Enums;

namespace Mass.Game.Proxy.Network.Team;

public class AddTeamPlayer : TeamActionBase
{
	private static object DecorateExpandableStream;

	public HashSet<string> Players
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00开();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00圀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AddTeamPlayer(EnumProtocolVersion version)
	{
		//IL_001b: Expected VT, but got I4
		//IL_0026: Expected VT, but got Obj
		//IL_002b: Expected Obj, but got Ref
		//IL_0045: Expected Obj, but got VT
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)version;
		_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter = new EqualityComparer<_00210>((_00210)this);
		((_003C_003Ef__AnonymousType0<>)(object)this).ToString();
		int num = 0;
		if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field == 0)
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
	public override void Read(IByteBuffer buffer)
	{
		_FF00_FF00_FF00尀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(IByteBuffer buffer)
	{
		_FF00_FF00_FF00夀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PopTemplate()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AddTeamPlayer DecorateAdjustableController()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00吀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776634, new IntPtr(2737368331868L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00唀()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00嘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776629, new IntPtr(2737368310028L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00圀(HashSet<string> P_0)
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
	internal unsafe void _FF00_FF00_FF00堀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776628, new IntPtr(2737368306908L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00夀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0067: Expected I4, but got Obj
		//IL_00f0: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got Ref
		//IL_00b1: Expected Obj, but got VT
		//IL_0137: Expected Obj, but got I4
		//IL_008a: Expected VT, but got I4
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_0105->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0193->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b6->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0141->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0095->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01ae->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0110->IL0026: Incompatible stack heights: 3 vs 2
		//IL_019e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_017b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0157->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c1->IL0026: Incompatible stack heights: 1 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 8;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 5:
			case 13:
				obj = ((object[])obj)[obj];
				obj2 = 12;
				break;
			case 12:
				((_003C_003Ef__AnonymousType0<>)obj)._002Ector((_003Caction_003Ej__TPar)32767);
				obj2 = 14;
				break;
			case 8:
				((EventBus)/*Error near IL_00a0: Stack underflow*/).Register((Action<EventPluginChanged>)/*Error near IL_00a0: Stack underflow*/, ((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals(this) ? 1 : 0);
				obj = (object)/*Error near IL_00a2: Stack underflow*/;
				_ = 7;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field == 0)
				{
					_ = 2;
				}
				break;
			case 10:
				_ = ((Array)obj).Length;
				/*Error near IL_00c6: Member reference must be method, but was: Field*/;
			case 3:
				return;
			default:
				_ = ((_003C_003Ef__AnonymousType1<, , >)((Array)obj).Length).name;
				_ = 1;
				if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field == 0)
				{
					_ = 1;
				}
				break;
			case 9:
				obj = 0;
				obj2 = 6;
				break;
			case 7:
				if ((nint)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance > 5)
				{
					obj2 = 4;
					break;
				}
				goto case 10;
			case 2:
			case 6:
				if ((nint)obj >= ((Array)obj).Length)
				{
					return;
				}
				obj2 = 5;
				break;
			case 1:
			case 11:
				obj = obj;
				obj2 = 9;
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.StoreConverter != null)
				{
					obj2 = 5;
				}
				break;
			case 14:
				obj++;
				obj2 = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00娀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776631, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00嬀()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00尀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0053: Expected I4, but got Obj
		//IL_005e: Expected VT, but got Obj
		//IL_005e: Expected Obj, but got Ref
		//IL_0069: Expected Obj, but got I4
		//IL_006e: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got VT
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_0095: Invalid comparison between VT and I4
		//IL_00f3: Expected Obj, but got I4
		//IL_0102: Expected Obj, but got VT
		//IL_015d: Expected Obj, but got VT
		//IL_016c: Expected Obj, but got VT
		//IL_015b: Expected VT, but got Obj
		//IL_015b: Expected Obj, but got Ref
		//IL_0083->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0122->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0107->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0171->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008e->IL0026: Incompatible stack heights: 1 vs 2
		//IL_015b->IL015b: Incompatible stack heights: 1 vs 2
		//IL_00a4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0112->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_017c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ef->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 6;
		object obj2 = obj;
		while (true)
		{
			_003Cname_003Ej__TPar name;
			switch ((int)obj2)
			{
			case 2:
			case 3:
				((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Caction_003Ej__TPar)this);
				((object)((_003C_003Ef__AnonymousType0<>)P_0).Equals((object)32767)).ToString();
				_ = 4;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field != 0)
				{
					_ = 4;
				}
				continue;
			case 6:
				if (((_003C_003Ef__AnonymousType2<, , , >)(object)this)._003Ccontext_003Ei__Field <= (object)5)
				{
					obj2 = 5;
					continue;
				}
				goto case 1;
			case 1:
				name = ((_003C_003Ef__AnonymousType1<, , >)P_0).name;
				break;
			default:
				if (Unsafe.As<object, UIntPtr>(ref obj) < Unsafe.As<object, UIntPtr>(ref obj))
				{
					obj2 = 0;
					if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field == 0)
					{
						obj2 = 3;
					}
					continue;
				}
				return;
			case 8:
				return;
			case 7:
				obj = 0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument == null)
				{
					obj2 = 0;
				}
				continue;
			case 4:
				obj++;
				obj2 = 9;
				continue;
			case 5:
				((EqualityComparer<_00212>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).GetHashCode((_00212)P_0);
				break;
			}
			obj = name;
			obj2 = 7;
			if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_hasTimeout)
			{
				obj2 = 5;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00崀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776630, new IntPtr(2737368319388L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe HashSet<string> _FF00_FF00_FF00帀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776625, new IntPtr(2737368331868L), 15))(null, 0, new IntPtr(0L));
		return (HashSet<string>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal HashSet<string> _FF00_FF00_FF00开()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (HashSet<string>)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe HashSet<string> _FF00_FF00_FF00怀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776624, new IntPtr(2737368319388L), 15))(null, 0, new IntPtr(0L));
		return (HashSet<string>)/*Error near IL_0033: Stack underflow*/;
	}
}
