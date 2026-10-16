using System;
using System.Buffers;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using Mass.Application.Event;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Game.Proxy.Minecraft.Events.Play;
using Mass.Game.Proxy.Protocols.FakeForge;
using Mass.Game.Proxy.Protocols.Hyt;

namespace Mass.Game.Proxy.Protocols.OhMyGod;

public class OhMyGodProtocol : FakeForgeProtocol
{
	private object _hwid;

	private object? _data;

	private static object CheckGeneralAggregator;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe OhMyGodProtocol()
	{
		//IL_001a: Expected VT, but got Obj
		//IL_001f: Expected VT, but got Obj
		//IL_001f: Expected Obj, but got Ref
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._003Cuser_id_003Ei__Field = (_003Cuser_id_003Ej__TPar)new
		{
			action = (_003Caction_003Ej__TPar)this
		};
		((_003C_003Ef__AnonymousType0<>)(object)new object()).ToString();
		/*Error near IL_0030: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnGermPacket(object packet)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00甀(packet);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public override void OnServerPluginMessage(EventServerPluginMessage @event)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00礀(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SendGermPacket(object packet)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00漀(packet);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectExtendedTag()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static OhMyGodProtocol CheckVisibleDefinition()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00渀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778783, new IntPtr(2737367945244L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00漀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got Obj
		//IL_003f: Expected Obj, but got Ref
		//IL_0049: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got VT
		//IL_0068->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0073->IL0026: Incompatible stack heights: 4 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Caction_003Ej__TPar)this);
				((object)((_003C_003Ef__AnonymousType0<>)/*Error near IL_0044: Stack underflow*/).Equals((object)/*Error near IL_0044: Stack underflow*/)).ToString();
				((_003C_003Ef__AnonymousType0<>)P_0).ToString();
				_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
				_ = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Ccontext_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00瀀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778782, new IntPtr(2737367941084L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00琀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778777, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00甀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0077: Expected I4, but got Obj
		//IL_0084: Expected VT, but got Obj
		//IL_0089: Expected Obj, but got Ref
		//IL_008e: Expected Obj, but got I4
		//IL_0093: Expected Obj, but got I4
		//IL_00ee: Expected VT, but got Obj
		//IL_00ee: Expected Obj, but got Ref
		//IL_00f3: Expected VT, but got I4
		//IL_0102: Expected Obj, but got I4
		//IL_029c: Expected VT, but got Ref
		//IL_00c4: Expected Obj, but got Ref
		//IL_02b2: Expected VT, but got I4
		//IL_02b2: Expected Obj, but got Ref
		//IL_01cc: Expected Obj, but got VT
		//IL_01d3: Expected Obj, but got I4
		//IL_01dc: Expected Obj, but got I4
		//IL_01a5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0230->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0107->IL0026: Incompatible stack heights: 1 vs 2
		//IL_02a7->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0142->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c9->IL0230: Incompatible stack heights: 0 vs 1
		//IL_01f2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01b0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02b2->IL02b2: Incompatible stack heights: 1 vs 2
		//IL_0213->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0162->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0178->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0256->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02be->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0189->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0112->IL0026: Incompatible stack heights: 1 vs 2
		//IL_014d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00dd->IL0026: Incompatible stack heights: 1 vs 2
		//IL_021e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0261->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e8->IL0026: Incompatible stack heights: 1 vs 2
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
				case 8:
					((_003C_003Ef__AnonymousType0<>)(object)this)._002Ector((_003Caction_003Ej__TPar)obj);
					string.Format((IFormatProvider?)/*Error near IL_0093: Stack underflow*/, (string)/*Error near IL_0093: Stack underflow*/, (object?[])((_003C_003Ef__AnonymousType0<>)((_003C_003Ef__AnonymousType0<>)/*Error near IL_0089: Stack underflow*/).Equals((object)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))).GetHashCode());
					_ = ((_003C_003Ef__AnonymousType2<, , , >)(object)this)._003Cpayload_003Ei__Field;
					_003C_003Ef__AnonymousType0<>.ReflectJoinedTree();
					/*Error near IL_009e: Member reference must be method, but was: Field*/;
				case 9:
					return;
				default:
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_defaultTimeout = (TimeSpan)((EqualityComparer<_00212>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).GetHashCode((_00212)this);
					_ = 1;
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_ascii_68FF03FEFFFF87FEFFFF07 != null)
					{
						_ = 1;
					}
					continue;
				case 1:
				case 5:
				{
					object guideMap = _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.GuideMap;
					if (guideMap == null)
					{
						obj2 = 12;
						if (((EntitySocks5Account)EntitySocks5Account.Username__BackingField).Password__BackingField == null)
						{
							obj2 = 11;
						}
					}
					else
					{
						((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory)obj)._002Ector();
						MemoryExtensions.IndexOfAnyExcept<T>((ReadOnlySpan<T>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (SearchValues<T>)guideMap);
						_ = 7;
					}
					continue;
				}
				case 6:
					if (!(P_0 is HytMainMenu._003C_003Ec__DisplayClass2_0))
					{
						obj2 = 9;
						continue;
					}
					goto end_IL_0026;
				case 7:
				case 12:
					if (((_003C_003Ef__AnonymousType2<, , , >)obj).GetHashCode() != 0)
					{
						obj2 = 4;
						continue;
					}
					return;
				case 14:
					if (obj == null)
					{
						obj2 = 16;
						continue;
					}
					goto case 13;
				case 3:
					obj = P_0 as HytMainMenu._003C_003Ec__DisplayClass2_2;
					obj2 = 2;
					if (EntitySocks5.DecorateDynamicModule == null)
					{
						obj2 = 2;
					}
					continue;
				case 15:
					return;
				case 16:
					return;
				case 18:
					return;
				case 2:
					if (obj != null)
					{
						if (!((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals(obj))
						{
							_ = 5;
							if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectLocalTemplate == null)
							{
								_ = 2;
							}
							continue;
						}
						goto case 10;
					}
					obj2 = 6;
					continue;
				case 4:
				{
					EnumGameVersion enumGameVersion = ((EntityLaunchGameProxy)(object)this).GameVersion__BackingField;
					if (enumGameVersion == EnumGameVersion.None)
					{
						obj2 = 11;
						if (((EntityLaunchGameProxy)EntityLaunchGameProxy.ModHashList__BackingField).Name__BackingField != null)
						{
							obj2 = 10;
						}
						continue;
					}
					((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).TryFindNextPossibleStartingPosition((ReadOnlySpan<char>)enumGameVersion);
					break;
				}
				case 13:
					_003C_003Ef__AnonymousType3<, >.LoadCache();
					_ = 18;
					continue;
				case 10:
					if (((EntityLaunchGameProxy)(object)this).ServerPort__BackingField == 0)
					{
						obj2 = 0;
						if (((EntityLaunchGameProxy)EntityLaunchGameProxy.Socks5__BackingField).Value__BackingField == null)
						{
							obj2 = 0;
						}
						continue;
					}
					/*Error near IL_0266: Member reference must be method, but was: Field*/;
				case 11:
					break;
				}
				obj = null;
				obj2 = 14;
				continue;
				end_IL_0026:
				break;
			}
			obj = ((EntityLaunchGameProxy)((EntityLaunchGameProxy)((_003C_003Ef__AnonymousType3<, >)(object)this).entry).GameId__BackingField).GameType__BackingField;
			obj = 8;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00瘀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778776, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00礀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00c2: Expected Obj, but got Ref
		//IL_00c7: Expected VT, but got I4
		//IL_004b: Expected VT, but got Obj
		//IL_004b: Expected VT, but got Ref
		//IL_0094: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got VT
		//IL_0270: Expected Obj, but got I4
		//IL_01b5: Expected Obj, but got VT
		//IL_01c4: Expected Obj, but got I4
		//IL_0232: Expected VT, but got I4
		//IL_0290: Expected Obj, but got VT
		//IL_0290: Expected VT, but got Obj
		//IL_0208: Expected Obj, but got I4
		//IL_0080->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0064->IL0026: Incompatible stack heights: 1 vs 2
		//IL_01d9->IL0044: Incompatible stack heights: 0 vs 1
		//IL_0128->IL01d4: Incompatible stack heights: 0 vs 1
		//IL_006f->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00ef->IL00ef: Incompatible stack heights: 2 vs 1
		//IL_027a->IL0044: Incompatible stack heights: 0 vs 1
		//IL_0188->IL00ef: Incompatible stack heights: 4 vs 1
		//IL_02b4->IL0044: Incompatible stack heights: 0 vs 1
		//IL_02a4->IL00ef: Incompatible stack heights: 2 vs 1
		//IL_020d->IL00eb: Incompatible stack heights: 0 vs 1
		//IL_02af->IL00ef: Incompatible stack heights: 2 vs 1
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				return;
			case 2:
			{
				if (((EqualityComparer<_00210>)/*Error near IL_004b: Stack underflow*/).Equals((_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00210?)P_0))
				{
					_ = 1;
					if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
					{
						_ = 0;
					}
					continue;
				}
				bool flag = _003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
				obj = _003C_003Ef__AnonymousType0<>.ReflectJoinedTree();
				_ = ((_003C_003Ef__AnonymousType1<, , >)flag).name;
				/*Error near IL_0094: Member reference must be method, but was: Field*/;
			}
			case 3:
				((_003C_003Ef__AnonymousType0<>)P_0).ToString();
				_ = 2;
				continue;
			case 1:
				return;
			}
			int num;
			if (((EqualityComparer<_00211>)/*Error near IL_00c7: Stack underflow*/).Equals((_00211?)/*Error near IL_00c7: Stack underflow*/, (_00211?)((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals(obj)))
			{
				num = 1;
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.StoreConverter != null)
				{
					num = 1;
				}
				goto IL_00ef;
			}
			goto IL_0256;
			IL_0256:
			if ((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectSymbolicAuditor() ? ((ReadOnlySpan<char>*)1) : ((ReadOnlySpan<char>*)null))->Length == 0)
			{
				return;
			}
			obj = 12;
			goto IL_00ef;
			IL_00ef:
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 4:
					return;
				case 10:
					return;
				case 6:
				case 12:
					_ = ((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.ReflectModularWriter()).url;
					/*Error near IL_0138: Member reference must be method, but was: Field*/;
				case 3:
					_003C_003Ef__AnonymousType2<, , , >.CheckAccessibleObject();
					_ = 9;
					continue;
				case 1:
				case 5:
					obj = ((_003C_003Ef__AnonymousType3<, >)obj).sid;
					num = 8;
					if (((EntityLaunchGameProxy)EntityLaunchGameProxy.GameType__BackingField).GameVersion__BackingField == EnumGameVersion.None)
					{
						num = 8;
					}
					continue;
				case 8:
					if (obj == null)
					{
						obj = 2;
						continue;
					}
					goto case 3;
				case 2:
				case 9:
					new Regex((TimeSpan)1);
					/*Error near IL_0232: Member reference must be method, but was: Field*/;
				case 7:
					break;
				case 11:
					MemoryExtensions.IndexOfAny<T>((ReadOnlySpan<T>)P_0, (SearchValues<T>)new ReadOnlySpan<char>(1));
					_ = 10;
					if (((GameProxy)GameProxy._pinger).ConnectionChanged == null)
					{
						_ = 8;
					}
					continue;
				}
				break;
			}
			goto IL_0256;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00稀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778779, new IntPtr(2737367941084L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00笀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778778, new IntPtr(2737367931724L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00簀()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00紀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778773, new IntPtr(2737367940044L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00縀()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}
}
