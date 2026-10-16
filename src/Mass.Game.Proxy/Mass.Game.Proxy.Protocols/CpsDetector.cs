using System;
using System.Buffers;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using DotNetty.Transport.Bootstrapping;
using DotNetty.Transport.Channels;
using Mass.Domain.Desktop.ValueObjects;

namespace Mass.Game.Proxy.Protocols;

public class CpsDetector
{
	private readonly object _lock;

	private readonly Queue<long> _leftClicks;

	private readonly Queue<long> _rightClicks;

	private double _lastLeftCps;

	private double _lastRightCps;

	[CompilerGenerated]
	private Action<double, double>? m_OnCpsChange;

	private static object DecompressList;

	public event Action<double, double>? OnCpsChange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			_FF00_FF00_FF00_FF00_FF00_FF00Ḁ(value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			_FF00_FF00_FF00_FF00_FF00_FF00ጀ(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LeftClick()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_2100();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RightClick()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00ᔀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnTick()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_1B00();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe CpsDetector()
	{
		//IL_001a: Expected VT, but got Obj
		//IL_001a: Expected VT, but got Ref
		//IL_001f: Expected VT, but got Obj
		//IL_002f: Expected VT, but got Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_001f: Stack underflow*/)._003Cuser_id_003Ei__Field = (_003Cuser_id_003Ej__TPar)new EqualityComparer<_00210>((_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00210?)this);
		((_003C_003Ef__AnonymousType2<, , , >)this)._003Curl_003Ei__Field = (_003Curl_003Ej__TPar)new object();
		/*Error near IL_0035: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateSortedCommand()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CpsDetector ReflectCombinedConsumer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00ሀ(Action<double, double> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778789, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00ጀ(Action<double, double> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00d1: Expected I4, but got Obj
		//IL_00d1: Expected Obj, but got Ref
		//IL_005b: Expected Obj, but got VT
		//IL_00e7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0060->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0104->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0088->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0093->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 3:
				obj = obj;
				obj2 = 5;
				if ((int)((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field)._003Cuser_id_003Ei__Field != 0)
				{
					obj2 = 4;
				}
				break;
			case 2:
				if (obj == obj)
				{
					obj2 = 0;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field != 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 3;
			case 5:
				/*Error near IL_0096: Member reference must be method, but was: Field*/;
			case 0:
				return;
			case 1:
				obj = ((AbstractBootstrap<ServerBootstrap, IServerChannel>)(object)Unsafe.AsPointer(ref ((_003C_003Ef__AnonymousType3<, >)this)._003Centry_003Ei__Field)).Option<int>((ChannelOption<int>)obj, (int)obj);
				obj2 = 2;
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance != null)
				{
					obj2 = 1;
				}
				break;
			case 4:
				obj = _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectLocalTemplate;
				obj2 = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_1400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778788, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00ᔀ()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0160: Expected Obj, but got I4
		//IL_0048: Expected Obj, but got VT
		//IL_0057: Expected Obj, but got VT
		//IL_0072: Expected Obj, but got Ref
		//IL_0072: Expected Obj, but got Ref
		//IL_0081: Expected Obj, but got VT
		//IL_0174->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_017f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0067->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00db->IL0067: Incompatible stack heights: 0 vs 1
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				obj = ((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
				{
					obj2 = 0;
				}
				break;
			case 2:
				return;
			case 3:
			{
				string.Format((IFormatProvider?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (string)obj, (object?[])(&obj));
				int num = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 1:
					return;
				}
				_ = ((_003C_003Ef__AnonymousType2<, , , >)this)._003Cuser_id_003Ei__Field;
				/*Error near IL_00ad: Member reference must be method, but was: Field*/;
			}
			default:
				obj = 0;
				obj2 = 3;
				if (((EntitySocks5Account)EntitySocks5Account.Username__BackingField).Password__BackingField != null)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00ᘀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778791, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00ᜀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778790, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_1800()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00ᤀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778785, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00ᨀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778784, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_1B00()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_03ba: Expected Obj, but got I4
		//IL_0048: Expected Obj, but got VT
		//IL_0057: Expected Obj, but got VT
		//IL_0072: Expected Obj, but got Ref
		//IL_0072: Expected Obj, but got Ref
		//IL_0132: Expected Obj, but got F8
		//IL_0147: Expected VT, but got Obj
		//IL_024e: Expected VT, but got Obj
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_0266: Expected Obj, but got I
		//IL_0215: Expected Obj, but got I4
		//IL_016e: Expected Obj, but got VT
		//IL_02a1: Expected I4, but got Obj
		//IL_02a4: Expected Obj, but got F8
		//IL_02f4: Expected VT, but got Obj
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected VT, but got Obj
		//IL_02c5: Invalid comparison between I4 and F8
		//IL_030a: Expected Obj, but got I4
		//IL_03ce->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03d9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0067->IL0026: Incompatible stack types: I4 vs Obj
		//IL_013c->IL0080: Incompatible stack heights: 3 vs 2
		//IL_014d->IL0124: Incompatible stack heights: 0 vs 1
		//IL_026b->IL0080: Incompatible stack heights: 1 vs 2
		//IL_021a->IL0080: Incompatible stack heights: 1 vs 2
		//IL_02ae->IL0080: Incompatible stack heights: 1 vs 2
		//IL_0337->IL0067: Incompatible stack heights: 0 vs 1
		//IL_031f->IL0067: Incompatible stack heights: 0 vs 1
		//IL_02ca->IL017e: Incompatible stack heights: 0 vs 1
		//IL_0157->IL0080: Incompatible stack heights: 1 vs 2
		//IL_0276->IL0080: Incompatible stack heights: 1 vs 2
		//IL_0225->IL0080: Incompatible stack heights: 1 vs 2
		//IL_02de->IL0080: Incompatible stack heights: 1 vs 2
		//IL_0332->IL0080: Incompatible stack heights: 5 vs 2
		//IL_02e9->IL0080: Incompatible stack heights: 1 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				obj = ((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 0;
				}
				break;
			case 3:
				return;
			case 2:
			{
				string text = string.Format((IFormatProvider?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (string)obj, (object?[])(&obj));
				int num = 2;
				while (true)
				{
					switch (num)
					{
					case 10:
						return;
					case 11:
						return;
					case 15:
						_ = obj - ((_003C_003Ef__AnonymousType2<, , , >)this)._003Cpayload_003Ei__Field;
						/*Error near IL_00db: Member reference must be method, but was: Field*/;
					case 17:
						if ((int)((_003C_003Ef__AnonymousType3<, >)this)._003Centry_003Ei__Field == 0)
						{
							num = 11;
							break;
						}
						AppContext.GetData((string)obj);
						_ = 10;
						break;
					default:
						_ = ((_003C_003Ef__AnonymousType3<, >)this)._003Csid_003Ei__Field;
						obj = (double)EqualityComparer<_00211>.Default;
						_ = 8;
						break;
					case 1:
					case 13:
						if (((EqualityComparer<_00211>)(object)text).GetHashCode((_00211)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance) > 0)
						{
							_ = 14;
							break;
						}
						goto default;
					case 5:
						_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.StoreConverter = obj;
						num = 6;
						if (!_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_hasTimeout)
						{
							num = 17;
						}
						break;
					case 3:
						_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_ascii_68FF03FEFFFF87FEFFFF07 = (SearchValues<char>)obj;
						num = 3;
						if (((EntitySocks5Account)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.GuideMap).Username__BackingField == null)
						{
							num = 5;
						}
						break;
					case 9:
					case 12:
						_ = ((EntitySocks5)this).Address__BackingField;
						/*Error near IL_01cf: Member reference must be method, but was: Field*/;
					case 6:
						_ = ((EntitySocks5)this).Account__BackingField;
						/*Error near IL_01ea: Member reference must be method, but was: Field*/;
					case 4:
						((Regex)((EntityLaunchGameProxy)this).Session__BackingField)._002Ector();
						_ = 0;
						if (((EntityLaunchGameProxy)EntityLaunchGameProxy.GameType__BackingField).GameVersion__BackingField == EnumGameVersion.None)
						{
							_ = 1;
						}
						break;
					case 2:
						Regex.ValidateMatchTimeout((TimeSpan)text);
						obj = /*Error near IL_0255: Stack underflow*/- 1000;
						_ = 10;
						if (((EntityLaunchGameProxy)EntityLaunchGameProxy.ServerPort__BackingField).Socks5__BackingField == null)
						{
							_ = 12;
						}
						break;
					case 7:
						_ = ((EntityLaunchGameProxy)this).Value__BackingField;
						/*Error near IL_027c: Member reference must be method, but was: Field*/;
					case 8:
						obj = (double)((ReadOnlySpan<char>*)text)->Slice((int)EntityLaunchGameProxy.ReflectAlphabeticProcessor);
						_ = 16;
						break;
					case 16:
						if (!((double)MemoryExtensions.IndexOfAnyExcept<T>((ReadOnlySpan<T>)text, (SearchValues<T>)(obj - GameProxy.Logger__BackingField)) > 0.01))
						{
							_ = 1;
							if (GameProxy.OnlineClients == null)
							{
								_ = 15;
							}
							break;
						}
						goto case 3;
					case 14:
					{
						SearchValues<char> searchValues = SearchValues.Create((ReadOnlySpan<char>)((GameProxy)this).Name__BackingField);
						if (Unsafe.As<SearchValues<char>, UIntPtr>(ref searchValues) >= Unsafe.As<object, UIntPtr>(ref obj))
						{
							num = 0;
							if (((GameProxy)GameProxy.GameType__BackingField).GameId__BackingField == null)
							{
								num = 0;
							}
							break;
						}
						goto case 4;
					}
					}
				}
			}
			default:
				obj = 0;
				obj2 = 2;
				if ((object)((GameProxy)GameProxy.Section__BackingField).Socks5 == null)
				{
					obj2 = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00ᰀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778787, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00ᴀ()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00Ḁ(Action<double, double> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_008b: Expected Obj, but got Ref
		//IL_0092: Expected Obj, but got VT
		//IL_00a1: Expected Obj, but got VT
		//IL_0050: Expected Obj, but got VT
		//IL_005f: Expected Obj, but got VT
		//IL_00e3: Expected VT, but got Obj
		//IL_00e3: Expected Obj, but got Ref
		//IL_00a6->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00c9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b1->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00d4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0104->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0083->IL0026: Incompatible stack types: I4 vs Obj
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
				obj = ((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
				obj2 = 1;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
				{
					obj2 = 1;
				}
				break;
			case 3:
				return;
			case 5:
				if (obj == obj)
				{
					obj2 = 3;
					break;
				}
				goto case 1;
			default:
				obj = (_00212)string.Format((IFormatProvider?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (string)obj, (object?[])(object)P_0);
				_ = 1;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Ccontext_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
				{
					_ = 4;
				}
				break;
			case 1:
				obj = obj;
				obj2 = 0;
				if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field != 0)
				{
					obj2 = 0;
				}
				break;
			case 4:
				obj = ((AbstractBootstrap<ServerBootstrap, IServerChannel>)(object)Unsafe.AsPointer(ref ((_003C_003Ef__AnonymousType3<, >)this)._003Csid_003Ei__Field)).Option<TimeSpan>((ChannelOption<TimeSpan>)obj, (TimeSpan)obj);
				obj2 = 5;
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectLocalTemplate == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00ἀ(Action<double, double> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778786, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_2000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778813, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_2100()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_004a: Expected VT, but got Ref
		//IL_004a: Expected VT, but got Obj
		//IL_004a: Expected Obj, but got Ref
		//IL_0059: Expected Obj, but got VT
		//IL_014b: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I4
		//IL_015f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0187->IL0026: Incompatible stack types: I4 vs Obj
		//IL_016a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0192->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b3->IL016a: Incompatible stack heights: 0 vs 1
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				obj = 0;
				obj2 = 0;
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_ascii_68FF03FEFFFF87FEFFFF07 == null)
				{
					obj2 = 0;
				}
				continue;
			case 3:
				return;
			case 2:
				obj = _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.GuideMap;
				obj2 = 1;
				if (((EntitySocks5Account)EntitySocks5Account.Username__BackingField).Password__BackingField != null)
				{
					obj2 = 1;
				}
				continue;
			}
			((EqualityComparer<_00210>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals((_00210?)obj, (_00210?)(&obj));
			int num = 1;
			if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
			{
				num = 1;
			}
			switch (num)
			{
			case 1:
				_ = ((_003C_003Ef__AnonymousType2<, , , >)this)._003Curl_003Ei__Field;
				/*Error near IL_0085: Member reference must be method, but was: Field*/;
			case 0:
				break;
			}
			return;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_2200()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778812, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
