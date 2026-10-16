using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using Mass.Application.Event;
using Mass.Game.Proxy.Minecraft.Events.Play;
using Mass.Game.Proxy.Protocols.FakeForge;

namespace Mass.Game.Proxy.Protocols.Aely;

public class AelyProtocol : FakeForgeProtocol
{
	private static object DecorateResponsiveStrategy;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe AelyProtocol()
	{
		//IL_001a: Expected VT, but got Obj
		//IL_001a: Expected VT, but got Ref
		//IL_0025: Expected Obj, but got I4
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		EqualityComparer<_00210> equalityComparer = (EqualityComparer<_00210>)new EqualityComparer<_00210>((_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00210?)this);
		((_003C_003Ef__AnonymousType0<>)(object)((object)((_003C_003Ef__AnonymousType0<>)(object)equalityComparer).Equals((object)equalityComparer)).ToString()).ToString();
		/*Error near IL_002b: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public override void OnServerPluginMessage(EventServerPluginMessage @event)
	{
		_FF00_FF00_FF00Ѐ(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PresentMapper()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AelyProtocol DecorateCombinedConfig()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00ﬀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778946, new IntPtr(2737368306908L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00ﰀ()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00ﴀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778973, new IntPtr(2737368321468L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FE00()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778972, new IntPtr(2737368318348L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00Ѐ(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004b: Expected I4, but got Obj
		//IL_00c4: Expected Obj, but got VT
		//IL_00c9: Expected VT, but got Ref
		//IL_0057: Expected VT, but got Obj
		//IL_0060: Expected Obj, but got I4
		//IL_0109: Expected VT, but got Obj
		//IL_0109: Expected Obj, but got Ref
		//IL_010b: Expected Obj, but got I4
		//IL_011a: Expected Obj, but got VT
		//IL_00ce->IL00fc: Incompatible stack heights: 0 vs 1
		//IL_00d8->IL0026: Incompatible stack heights: 1 vs 2
		//IL_011f->IL0026: Incompatible stack heights: 1 vs 2
		//IL_012a->IL0026: Incompatible stack heights: 1 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 5;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					return;
				case 5:
					break;
				case 7:
					return;
				case 0:
					return;
				case 4:
					/*Error near IL_008f: Member reference must be method, but was: Field*/;
				case 2:
					if (!((EqualityComparer<_00212>)/*Error near IL_00c9: Stack underflow*/).Equals((_00212?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00212?)((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType1<, , >)obj).uuid).user_id))
					{
						_ = 6;
						continue;
					}
					return;
				case 1:
					return;
				case 6:
					obj = ((EqualityComparer<_00212>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).GetHashCode((_00212)((_003C_003Ef__AnonymousType1<, , >)obj).ToString());
					_ = 2;
					if (!_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_hasTimeout)
					{
						_ = 3;
					}
					continue;
				case 3:
					/*Error near IL_012e: Member reference must be method, but was: Field*/;
				}
				break;
			}
			((_003C_003Ef__AnonymousType0<>)(object)this)._002Ector((_003Caction_003Ej__TPar)P_0);
			obj = 4;
		}
	}
}
