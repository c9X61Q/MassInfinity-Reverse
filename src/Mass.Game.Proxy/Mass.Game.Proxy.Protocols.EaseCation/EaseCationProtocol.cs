using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Mass.Application.Event;
using Mass.Common.Extensions;
using Mass.Game.Proxy.Minecraft.Events;
using Mass.Game.Proxy.Minecraft.Events.Play;
using Mass.Game.Proxy.Packets.Play;
using Mass.Game.Proxy.Protocols.FakeForge;
using Serilog;

namespace Mass.Game.Proxy.Protocols.EaseCation;

public class EaseCationProtocol : FakeForgeProtocol
{
	[CompilerGenerated]
	private static readonly object Logger__BackingField;

	internal static EaseCationProtocol ReflectAlphabeticVerifier;

	private static ILogger Logger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe EaseCationProtocol()
	{
		//IL_0018: Expected Obj, but got I4
		//IL_001f: Expected VT, but got Obj
		//IL_001f: Expected VT, but got Obj
		//IL_002d: Expected I4, but got Obj
		//IL_002d: Expected Obj, but got Ref
		//IL_0032: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got Ref
		//IL_0041: Expected Obj, but got I4
		//IL_0040: Expected native int or pointer, but got Obj
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 2;
		EqualityComparer<_00210> equalityComparer = (EqualityComparer<_00210>)new EqualityComparer<_00210>((_00210?)this, (_00210?)obj);
		((AsyncTaskMethodBuilder*)equalityComparer)->Start(ref *(GameProxy._003CListenAsync_003Ed__69*)obj);
		((EventBus)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Register((Action<EventPluginChanged>)(object)equalityComparer, (int)equalityComparer);
		obj = (object)/*Error near IL_002f: Stack underflow*/;
		obj = 0;
		Unsafe.Write((void*)(nint)string.Format((IFormatProvider?)/*Error near IL_003b: Stack underflow*/, (string)(&obj), (object?[])obj), (object)_003C_003Ef__AnonymousType0<>.ReflectActiveCalc());
		obj++;
		_ = ref obj;
		/*Error near IL_004b: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public override void OnServerPluginMessage(EventServerPluginMessage @event)
	{
		_FF00_FF00_E200(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public override void OnClientPluginMessage(EventClientPluginMessage @event)
	{
		_FF00_FF00팀(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public override void OnJoinGame(EventPacket<ClientboundJoinGamePacket> @event)
	{
		this._FF00_FF00_FFFD(@event);
	}

	static EaseCationProtocol()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_001f: Expected I4, but got Obj
		//IL_004d->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0058->IL0012: Incompatible stack types: I4 vs Obj
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
				Logger__BackingField = Log.Logger.Category((string)ZYXDNGuarder._FF00_FF00_E400());
				obj2 = 0;
				if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_1870dc50b57945d3a2b67238de02678b != 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckEditableAnnotation()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EaseCationProtocol ReflectLogicalComparator()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00케()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778991, new IntPtr(2737368301708L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00_FF00퀀()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00툀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778990, new IntPtr(2737368305868L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00팀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003d: Expected VT, but got Ref
		//IL_004d: Expected Obj, but got I4
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		switch ((int)obj)
		{
		case 1:
			((_003C_003Ef__AnonymousType0<>)/*Error near IL_003d: Stack underflow*/)._002Ector((_003Caction_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
			((_003C_003Ef__AnonymousType0<>)/*Error near IL_0042: Stack underflow*/).Equals((object)/*Error near IL_0042: Stack underflow*/);
			((_003C_003Ef__AnonymousType0<>)((_003C_003Ef__AnonymousType0<>)P_0).GetHashCode()).ToString();
			_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
			_003C_003Ef__AnonymousType0<>.ReflectJoinedTree();
			/*Error near IL_0058: Member reference must be method, but was: Field*/;
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00퐀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778985, new IntPtr(2737368307948L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00픀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778984, new IntPtr(2737368317308L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00혀()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00휀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778987, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FFFD(EventPacket<ClientboundJoinGamePacket> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778986, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FFFD(EventPacket<ClientboundJoinGamePacket> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003e: Expected VT, but got Obj
		//IL_003e: Expected Obj, but got Ref
		//IL_0048: Expected Obj, but got I4
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		switch ((int)obj)
		{
		case 1:
			((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Caction_003Ej__TPar)this);
			((_003C_003Ef__AnonymousType0<>)(object)((object)((_003C_003Ef__AnonymousType0<>)/*Error near IL_0043: Stack underflow*/).Equals((object)/*Error near IL_0043: Stack underflow*/)).ToString()).ToString();
			/*Error near IL_004d: Member reference must be method, but was: Field*/;
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FFFD()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778981, new IntPtr(2737368326668L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_E100(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778980, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_E200(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003d: Expected VT, but got Ref
		//IL_004d: Expected Obj, but got I4
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		switch ((int)obj)
		{
		case 1:
			((_003C_003Ef__AnonymousType0<>)/*Error near IL_003d: Stack underflow*/)._002Ector((_003Caction_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
			((_003C_003Ef__AnonymousType0<>)/*Error near IL_0042: Stack underflow*/).Equals((object)/*Error near IL_0042: Stack underflow*/);
			((_003C_003Ef__AnonymousType0<>)((_003C_003Ef__AnonymousType0<>)P_0).GetHashCode()).ToString();
			_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
			_003C_003Ef__AnonymousType0<>.ReflectJoinedTree();
			/*Error near IL_0058: Member reference must be method, but was: Field*/;
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_E300(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778983, new IntPtr(2737368302748L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
