using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using System.Threading;
using Mass.Application.Event;
using Mass.Common.Extensions;
using Mass.Game.Proxy.Minecraft.Events;
using Mass.Game.Proxy.Minecraft.Events.Play;
using Mass.Game.Proxy.Minecraft.Protocol;
using Mass.Game.Proxy.Protocols.Heypixel;
using Mass.Game.Proxy.Protocols.Heypixel.AntiCheat;
using Serilog;

namespace Mass.Game.Proxy.Protocols.EastLand;

public class EastLandProtocol : Protocol
{
	[CompilerGenerated]
	private static readonly object Logger__BackingField;

	private static object DecorateDynamicProcessor;

	private static ILogger Logger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	public byte[]? ClientKey
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (byte[]?)_FF00_FF00렀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00숀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public void OnServerPluginMessage(EventServerPluginMessage @event)
	{
		_FF00_FF00븀(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object Decrypt(object key, object data)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005a: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 820, 1790778906, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 3, 1790778906, new IntPtr(2737367950444L), 15);
		}
		return ((delegate*<object, object, object, object>)obj)(this, key, data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static byte[] Decompress(byte[] bytes)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 821, 1790778901, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778901, new IntPtr(2737367951484L), 15);
		}
		return (byte[])((delegate*<object, object>)obj)(bytes);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public void OnClientPluginMessage(EventClientPluginMessage @event)
	{
		_FF00_FF00찀(@event);
	}

	[SubscribeEvent]
	public static void OnConnectServer(EventConnectServer @event)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe EastLandProtocol()
	{
		//IL_001a: Expected VT, but got Obj
		//IL_001a: Expected Obj, but got Ref
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Caction_003Ej__TPar)this);
	}

	static EastLandProtocol()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_001f: Expected I4, but got Obj
		//IL_004c->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0057->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
				Logger__BackingField = Log.Logger.Category((string)ZYXDNGuarder._FF00_FF00똀());
				obj2 = 0;
				if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_e28d6b3bc6ae415aa8c9a8c33ac158d7 != 0)
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
	internal static bool PopArgument()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EastLandProtocol DefineSummarizer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00뜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778900, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00렀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00봀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778903, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00븀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_0051: Expected VT, but got Ref
		//IL_0062: Expected Obj, but got I4
		//IL_0289: Expected Obj, but got Ref
		//IL_0292: Expected Obj, but got I4
		//IL_02b7: Expected VT, but got Obj
		//IL_02b7: Expected VT, but got I4
		//IL_0077: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got VT
		//IL_0270: Expected VT, but got Obj
		//IL_0270: Expected Obj, but got Ref
		//IL_0275: Expected Obj, but got I4
		//IL_02cb: Expected Obj, but got I4
		//IL_00d5: Expected Obj, but got VT
		//IL_00da: Expected VT, but got Ref
		//IL_00e0: Expected Obj, but got I4
		//IL_00e5: Expected VT, but got I4
		//IL_00ea: Expected Obj, but got I4
		//IL_006c->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0297->IL0022: Incompatible stack heights: 0 vs 1
		//IL_02bc->IL0268: Incompatible stack heights: 2 vs 1
		//IL_0281->IL0026: Incompatible stack heights: 1 vs 2
		//IL_02d0->IL0026: Incompatible stack heights: 3 vs 2
		//IL_02db->IL0026: Incompatible stack heights: 3 vs 2
		//IL_00fe->IL009a: Incompatible stack heights: 2 vs 3
		//IL_0150->IL009a: Incompatible stack heights: 5 vs 3
		//IL_01a3->IL02db: Incompatible stack heights: 0 vs 1
		//IL_0109->IL009a: Incompatible stack heights: 2 vs 3
		//IL_015b->IL009a: Incompatible stack heights: 5 vs 3
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 3;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					return;
				case 2:
					((_003C_003Ef__AnonymousType0<>)/*Error near IL_0051: Stack underflow*/)._002Ector((_003Caction_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
					((EventBus)/*Error near IL_0062: Stack underflow*/).Register((Action<EventMinecraft>)((_003C_003Ef__AnonymousType0<>)/*Error near IL_0056: Stack underflow*/).Equals((object)/*Error near IL_0056: Stack underflow*/), ((_003C_003Ef__AnonymousType0<>)obj).GetHashCode());
					_ = 4;
					continue;
				case 5:
				{
					object obj3 = obj;
					obj = _003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
					int num = 1;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Ccontext_003Ei__Field)._003Cuser_id_003Ei__Field != 0)
					{
						num = 2;
					}
					while (true)
					{
						switch (num)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							Interlocked.CompareExchange(ref *(Action<double, double>*)/*Error near IL_00ea: Stack underflow*/, (Action<double, double>)/*Error near IL_00ea: Stack underflow*/, (Action<double, double>)((EqualityComparer<_00211>)/*Error near IL_00e5: Stack underflow*/).Equals((_00211?)/*Error near IL_00e5: Stack underflow*/, (_00211?)((_003C_003Ef__AnonymousType1<, , >)((EqualityComparer<_00212>)/*Error near IL_00da: Stack underflow*/).Equals((_00212?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00212?)((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType1<, , >)obj3).uuid).user_id)).Equals(this)));
							_ = 0;
							if ((int)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_defaultTimeout == 0)
							{
								_ = 4;
							}
							continue;
						case 2:
							if ((int)((_003C_003Ef__AnonymousType2<, , , >)obj).url != 0)
							{
								num = 0;
								if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.GuideMap == null)
								{
									num = 0;
								}
								continue;
							}
							break;
						case 3:
							_ = ((_003C_003Ef__AnonymousType2<, , , >)obj).user_id;
							_ = 1;
							if (EntitySocks5Account.AttachElement == null)
							{
								_ = 0;
							}
							continue;
						case 5:
							break;
						case 4:
							return;
						}
						break;
					}
					_ = ref EntitySocks5.Address__BackingField;
					_ = 16;
					/*Error near IL_0163: Member reference must be method, but was: Field*/;
				}
				case 6:
					return;
				case 1:
					((RegexRunner)((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).TryFindNextPossibleStartingPosition((ReadOnlySpan<char>)obj))._002Ector();
					obj = (object)/*Error near IL_0277: Stack underflow*/;
					_ = 5;
					continue;
				case 3:
					break;
				case 4:
					if ((TimeSpan)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.VerifyVerifier() != (TimeSpan)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.DecorateCustomNode())
					{
						return;
					}
					_ = 0;
					if (((GameProxy)GameProxy.GameVersion__BackingField).ModHashList__BackingField == null)
					{
						_ = 1;
					}
					continue;
				case 0:
					return;
				}
				break;
			}
			((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)P_0)._002Ector();
			obj = (object)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field);
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00뼀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778902, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00쀀()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00섀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778897, new IntPtr(2737368306908L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00숀(object P_0)
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
	internal unsafe void _FF00_FF00쌀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778896, new IntPtr(2737368315228L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00쐀()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00씀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778899, new IntPtr(2737368314188L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00_FF00였()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00윀(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_006b: Expected Obj, but got Ref
		//IL_007a: Expected Obj, but got VT
		//IL_0041: Expected VT, but got Ref
		//IL_0043: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got VT
		//IL_0101: Expected VT, but got I4
		//IL_0101: Expected VT, but got I4
		//IL_0103: Expected Obj, but got I4
		//IL_00e4: Expected Obj, but got VT
		//IL_0057->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0062->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00e9->IL008e: Incompatible stack heights: 3 vs 2
		//IL_00f4->IL008e: Incompatible stack heights: 3 vs 2
		//IL_0139->IL021e: Incompatible stack heights: 0 vs 1
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				obj = ((EqualityComparer<_00210>)/*Error near IL_0041: Stack underflow*/).Equals((_00210?)/*Error near IL_0041: Stack underflow*/, (_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
				_ = 1;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					_ = 1;
				}
				continue;
			case 1:
			{
				string.Format((IFormatProvider?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (string)obj, (object?[])P_0);
				int num = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field != 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					default:
						_ = 2;
						/*Error near IL_00ab: Member reference must be method, but was: Field*/;
					case 2:
						_ = 2;
						/*Error near IL_00bd: Member reference must be method, but was: Field*/;
					case 3:
						obj = EqualityComparer<_00212>.Default;
						_ = 1;
						if (_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument != null)
						{
							_ = 1;
						}
						continue;
					case 1:
						break;
					}
					break;
				}
				obj = ((EqualityComparer<_00211>)P_1).Equals((_00211?)0, (_00211?)((Array)P_1).Length);
				int num2 = 0;
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.StoreConverter == null)
				{
					num2 = 0;
				}
				switch (num2)
				{
				}
				break;
			}
			}
			break;
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00저(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778898, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00쬀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778989, new IntPtr(2737368318348L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00찀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0280: Expected VT, but got Ref
		//IL_0285: Expected VT, but got I4
		//IL_0052: Expected VT, but got Obj
		//IL_0052: Expected Obj, but got Ref
		//IL_0063: Expected Obj, but got VT
		//IL_024a: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got VT
		//IL_0152: Expected VT, but got Obj
		//IL_0152: Expected VT, but got I4
		//IL_00d9: Expected VT, but got Obj
		//IL_00da: Invalid comparison between Unknown and I4
		//IL_029b->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0270->IL0026: Incompatible stack types: I4 vs Obj
		//IL_027b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0254->IL0026: Incompatible stack heights: 4 vs 2
		//IL_02c5->IL0026: Incompatible stack heights: 3 vs 2
		//IL_02d0->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0119->IL0077: Incompatible stack heights: 4 vs 1
		//IL_00c7->IL0077: Incompatible stack heights: 5 vs 1
		//IL_0166->IL0077: Incompatible stack heights: 2 vs 1
		//IL_0176->IL0048: Incompatible stack heights: 0 vs 1
		//IL_00d2->IL0077: Incompatible stack heights: 5 vs 1
		//IL_0171->IL0077: Incompatible stack heights: 2 vs 1
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 0:
				return;
			case 4:
			{
				((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Caction_003Ej__TPar)obj);
				obj = (object)/*Error near IL_0054: Stack underflow*/;
				int num = 2;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					num = 4;
				}
				while (true)
				{
					switch (num)
					{
					case 5:
						return;
					case 1:
						((_003C_003Ef__AnonymousType0<>)(object)this).ToString();
						_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
						obj = ((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType0<>.ReflectJoinedTree()).name;
						_ = 1;
						if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field != 0)
						{
							_ = 3;
						}
						break;
					case 4:
						((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_00d9: Stack underflow*/)._002Ector((_003Cname_003Ej__TPar)/*Error near IL_00d9: Stack underflow*/, (_003Cuuid_003Ej__TPar)/*Error near IL_00d9: Stack underflow*/, (_003Cuser_id_003Ej__TPar)obj);
						if ((int)/*Error near IL_00df: Stack underflow*/ != 1)
						{
							return;
						}
						num = 1;
						if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance == null)
						{
							num = 1;
						}
						break;
					default:
						((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_0103: Stack underflow*/).ToString();
						_003C_003Ef__AnonymousType1<, , >.ReflectScalableStack();
						((IEnumerable<byte>)obj).ToArray();
						_ = 2;
						break;
					case 3:
						/*Error near IL_0119: Member reference must be method, but was: Field*/;
					case 2:
						((EqualityComparer<_00213>)P_0).Equals((_00213?)1, (_00213?)new EqualityComparer<_00213>());
						_ = 1;
						if (((EntitySocks5)EntitySocks5.Address__BackingField).Port__BackingField != 0)
						{
							_ = 5;
						}
						break;
					}
				}
			}
			case 5:
				return;
			case 2:
				obj = ((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory)P_0).CreateInstance();
				obj2 = 1;
				if (((GameProxy)GameProxy.Logger__BackingField)._pinger != null)
				{
					obj2 = 0;
				}
				break;
			case 1:
			{
				byte b = ((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)/*Error near IL_0285: Stack underflow*/).TryMatchAtCurrentPosition((ReadOnlySpan<char>)((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)/*Error near IL_0280: Stack underflow*/).TryFindNextPossibleStartingPosition((ReadOnlySpan<char>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)));
				((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)obj)._002Ector();
				((AsyncTaskMethodBuilder<HeypixelRequestDto>*)/*Error near IL_0291: Stack underflow*/)->Start(ref *(MassServiceExtensions._003CGetHeypixelAntiCheat_003Ed__2*)b);
				_ = 3;
				break;
			}
			case 3:
			{
				_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner name = _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.DecorateCustomNode();
				_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities._002Ecctor();
				if (AppContext.GetData((string)(object)name) == null)
				{
					obj = (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectSymbolicAuditor() ? ((ReadOnlySpan<char>*)1) : ((ReadOnlySpan<char>*)null))->Length;
					_ = 4;
					break;
				}
				_ = 5;
				if (((GameProxy)GameProxy.ModHashList__BackingField).ServerAddress__BackingField != null)
				{
					_ = 1;
				}
				break;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00촀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778988, new IntPtr(2737368314188L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00츀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0070: Expected Obj, but got I4
		//IL_0070: Expected Obj, but got Ref
		//IL_0081: Expected Obj, but got VT
		//IL_0043: Expected VT, but got I4
		//IL_0043: Expected VT, but got Obj
		//IL_0054: Expected Obj, but got VT
		//IL_0059->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				obj = new EqualityComparer<_00210>((_00210?)P_0, (_00210?)0);
				obj2 = 1;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
				{
					obj2 = 1;
				}
				break;
			default:
				return obj;
			case 1:
			{
				obj = new string((IFormatProvider?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (string)obj, (object?[])0);
				int num = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field == 0)
				{
					num = 0;
				}
				switch (num)
				{
				default:
					/*Error near IL_00a4: Member reference must be method, but was: Field*/;
				}
			}
			}
		}
	}
}
