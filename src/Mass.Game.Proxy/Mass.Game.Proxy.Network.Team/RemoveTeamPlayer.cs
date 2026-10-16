using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using DotNetty.Buffers;
using Mass.Application.Event;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft.Events;

namespace Mass.Game.Proxy.Network.Team;

public class RemoveTeamPlayer : TeamActionBase
{
	private static object DecompressRequester;

	public HashSet<string> Players
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00鸀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00阀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RemoveTeamPlayer(EnumProtocolVersion version)
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
		_FF00_FF00_FF00鴀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(IByteBuffer buffer)
	{
		_FF00_FF00_FF00頀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectSegmentedTree()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RemoveTeamPlayer ReflectCommonFilter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00錀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776603, new IntPtr(2737368318348L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00鐀()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00销(HashSet<string> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776602, new IntPtr(2737368331868L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00阀(HashSet<string> P_0)
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
	internal unsafe void _FF00_FF00_FF00需(HashSet<string> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776597, new IntPtr(2737368328748L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00頀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0063: Expected I4, but got Obj
		//IL_019d: Expected Obj, but got I4
		//IL_01a7: Expected Obj, but got I4
		//IL_00fa: Expected Obj, but got I4
		//IL_0109: Expected Obj, but got VT
		//IL_0126: Expected Obj, but got I4
		//IL_015d: Invalid comparison between VT and I4
		//IL_0097: Expected Obj, but got Ref
		//IL_00a8: Expected Obj, but got VT
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_018e: Expected Obj, but got I4
		//IL_0171: Expected Obj, but got I4
		//IL_01ac->IL0022: Incompatible stack heights: 2 vs 1
		//IL_010e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01bd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0131->IL0026: Incompatible stack heights: 4 vs 2
		//IL_00ad->IL0026: Incompatible stack heights: 1 vs 2
		//IL_01d7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0119->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0176->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b8->IL0026: Incompatible stack heights: 1 vs 2
		//IL_01e2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0181->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 8;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 8:
					((EventBus)/*Error near IL_0097: Stack underflow*/).Register((Action<EventMinecraft>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), ((_003C_003Ef__AnonymousType0<>)(object)this).GetHashCode());
					obj = (object)/*Error near IL_0099: Stack underflow*/;
					_ = 7;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field == 0)
					{
						_ = 1;
					}
					continue;
				case 6:
					_ = ((Array)obj).Length;
					/*Error near IL_00bd: Member reference must be method, but was: Field*/;
				case 1:
				case 12:
					if ((nint)obj >= ((Array)obj).Length)
					{
						obj2 = 3;
						continue;
					}
					goto case 4;
				case 2:
					obj = 0;
					obj2 = 1;
					if (_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument != null)
					{
						obj2 = 1;
					}
					continue;
				case 5:
					((_003C_003Ef__AnonymousType1<, , >)32767).GetHashCode();
					_ = 9;
					continue;
				case 3:
					return;
				case 7:
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_defaultTimeout > (object)5)
					{
						obj2 = 13;
						if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_ascii_68FF03FEFFFF87FEFFFF07 != null)
						{
							obj2 = 13;
						}
						continue;
					}
					goto case 6;
				case 10:
				case 11:
					obj = obj;
					obj = 2;
					break;
				default:
					_ = ((_003C_003Ef__AnonymousType2<, , , >)((Array)obj).Length).context;
					obj = 10;
					break;
				case 4:
					obj = ((object[])obj)[obj];
					obj2 = 5;
					continue;
				case 9:
					obj++;
					obj2 = 12;
					if (((EntitySocks5Account)EntitySocks5Account.Username__BackingField).Password__BackingField == null)
					{
						obj2 = 6;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00餀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776596, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00騀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776599, new IntPtr(2737368310028L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00鬀()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00鰀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776598, new IntPtr(2737368305868L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00鴀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0053: Expected I4, but got Obj
		//IL_00f2: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got Ref
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_0068: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I4
		//IL_0112: Invalid comparison between VT and I4
		//IL_015d: Expected Obj, but got I4
		//IL_016c: Expected Obj, but got VT
		//IL_015b: Expected VT, but got Obj
		//IL_015b: Expected Obj, but got Ref
		//IL_00fc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0171->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0121->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_017c->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00ef->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 8;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				case 2:
					return;
				case 4:
					goto end_IL_0026;
				default:
					((_003C_003Ef__AnonymousType0<>)(object)this).GetHashCode();
					((_003C_003Ef__AnonymousType0<>)32767).ToString();
					/*Error near IL_00a2: Member reference must be method, but was: Field*/;
				case 6:
				case 9:
					if (Unsafe.As<object, UIntPtr>(ref obj) >= Unsafe.As<object, UIntPtr>(ref obj))
					{
						return;
					}
					obj2 = 0;
					if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field != 0)
					{
						obj2 = 0;
					}
					continue;
				case 1:
					obj = 0;
					obj2 = 6;
					continue;
				case 8:
					if (((_003C_003Ef__AnonymousType3<, >)(object)this)._003Csid_003Ei__Field <= (object)5)
					{
						obj2 = 7;
						continue;
					}
					goto case 3;
				case 3:
					num = (((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals(P_0) ? 1 : 0);
					break;
				case 7:
					num = ((EqualityComparer<_00212>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).GetHashCode((_00212)P_0);
					break;
				}
				obj = num;
				_ = 0;
				if (!_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_hasTimeout)
				{
					_ = 1;
				}
				continue;
				end_IL_0026:
				break;
			}
			obj++;
			obj = 9;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal HashSet<string> _FF00_FF00_FF00鸀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (HashSet<string>)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe HashSet<string> _FF00_FF00_FF00鼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776593, new IntPtr(2737368318348L), 15))(null, 0, new IntPtr(0L));
		return (HashSet<string>)/*Error near IL_0033: Stack underflow*/;
	}
}
