using System;
using System.Buffers;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Network.Component.Chat;
using Mass.Game.Proxy.Protocols.Germ;

namespace Mass.Game.Proxy.Protocols.Hyt;

public static class HytMainMenu
{
	private class Menu : Dictionary<string, string>
	{
		public object Name;

		public object Description;

		private static object CustomizeTemplate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Menu(string name, string description)
		{
			//IL_001b: Expected VT, but got Obj
			//IL_0027: Expected VT, but got Obj
			//IL_0041: Expected Obj, but got VT
			_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)name;
			((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuser_id_003Ei__Field = (_003Cuser_id_003Ej__TPar)description;
			base.ToString();
			int num = 0;
			if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field != 0)
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
		internal static bool ReflectOperationalSender()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Menu DecorateVirtualWorker()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00케()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778768, new IntPtr(2737367931724L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00퀀()
		{
			//IL_001a: Invalid comparison between VT and Obj
			_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00턀()
		{
			//IL_001a: Expected Obj, but got VT
			_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00툀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778771, new IntPtr(2737367931724L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	private static readonly List<Menu> MainMenu;

	internal static HytMainMenu CheckCentralTransmitter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static TextComponent GetMainMenu(Mass.Game.Proxy.Minecraft.Minecraft minecraft, Action<GermPacket> sendGermPacket)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 200, 1790778772, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778772, new IntPtr(2737367945244L), 15);
		}
		return (TextComponent)((delegate*<object, object, object>)obj)(minecraft, sendGermPacket);
	}

	static HytMainMenu()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_001f: Expected I4, but got Obj
		//IL_02b1->IL0012: Incompatible stack types: I4 vs Obj
		//IL_02bc->IL0012: Incompatible stack types: I4 vs Obj
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
				MainMenu = new List<Menu>
				{
					new Menu((string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00蔀(), (string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00蘀())
					{
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00蜀(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00蠀()
						},
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00褀(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00言()
						},
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00謀(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00谀()
						},
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00贀(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00踀()
						},
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00輀(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00退()
						},
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00鄀(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00鈀()
						}
					},
					new Menu((string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00錀(), (string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00鐀())
					{
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00销(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00阀()
						},
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00需(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00頀()
						}
					},
					new Menu((string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00餀(), (string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00騀())
					{
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00鬀(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00鰀()
						},
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00鴀(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00鸀()
						},
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00鼀(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00ꀀ()
						},
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00ꄀ(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00ꈀ()
						},
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00ꌀ(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00ꐀ()
						}
					},
					new Menu((string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00ꔀ(), (string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00ꘀ())
					{
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00_A700(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00ꠀ()
						},
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00꤀(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00ꨀ()
						},
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00_AB00(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00가()
						},
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00관(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00글()
						},
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00꼀(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00뀀()
						},
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00넀(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00눀()
						}
					},
					new Menu((string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00대(), (string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00됀())
					{
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00딀(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00똀()
						},
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00뜀(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00렀()
						},
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00뤀(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00먀()
						},
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00묀(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00밀()
						},
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00봀(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00븀()
						},
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00뼀(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00쀀()
						}
					},
					new Menu((string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00섀(), (string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00숀())
					{
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00쌀(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00쐀()
						},
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00씀(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00였()
						},
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00윀(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00저()
						},
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00준(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00쨀()
						},
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00쬀(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00찀()
						},
						{
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00촀(),
							(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00츀()
						}
					}
				};
				obj2 = 0;
				if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_826e9b781c3246e39cc6170886dd6c67 != 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectStatelessRecommender()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HytMainMenu DecorateScheduledAnalyzer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00缀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778775, new IntPtr(2737367936924L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00耀()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00脀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778774, new IntPtr(2737367931724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00舀()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00茀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778769, new IntPtr(2737367931724L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00萀(object P_0, Action<GermPacket> P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_006b: Expected I4, but got Obj
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got Unknown
		//IL_01c1: Expected Obj, but got VT
		//IL_01d1: Expected Obj, but got I4
		//IL_0078: Expected VT, but got Obj
		//IL_0087: Expected Obj, but got VT
		//IL_0140: Expected Obj, but got I4
		//IL_0194: Expected Obj, but got Ref
		//IL_012d: Expected Obj, but got VT
		//IL_00a0: Expected VT, but got Obj
		//IL_00af: Expected Obj, but got VT
		//IL_0243: Expected Obj, but got I4
		//IL_00f6: Expected Obj, but got Ref
		//IL_026b: Expected VT, but got Obj
		//IL_0270: Expected VT, but got I4
		//IL_0275: Expected VT, but got I4
		//IL_0275: Expected Obj, but got Ref
		//IL_0297: Expected Obj, but got I4
		//IL_02a4: Expected Obj, but got I
		//IL_0253->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01d6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0170->IL00f1: Incompatible stack heights: 2 vs 1
		//IL_0154->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01aa->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0202->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0132->IL0026: Incompatible stack types: I4 vs Obj
		//IL_023b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010c->IL0026: Incompatible stack heights: 1 vs 2
		//IL_02b4->IL0026: Incompatible stack heights: 6 vs 2
		//IL_01e1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0097->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0184->IL0026: Incompatible stack heights: 3 vs 2
		//IL_015f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01b5->IL0026: Incompatible stack heights: 1 vs 2
		//IL_013d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00bf->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0117->IL0026: Incompatible stack heights: 1 vs 2
		//IL_018f->IL0026: Incompatible stack heights: 3 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 9;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				((_003C_003Ef__AnonymousType1<, , >)obj)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_1;
				obj2 = 6;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 0;
				}
				break;
			case 11:
				((_003C_003Ef__AnonymousType2<, , , >)obj)._003Curl_003Ei__Field = (_003Curl_003Ej__TPar)obj;
				obj2 = 12;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field == 0)
				{
					obj2 = 13;
				}
				break;
			case 7:
				_ = _003C_003Ef__AnonymousType2<, , , >._003Cuser_id_003Ei__Field;
				/*Error near IL_00c6: Member reference must be method, but was: Field*/;
			case 14:
				obj = new
				{
					value = (object)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)
				};
				_ = 1;
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectLocalTemplate == null)
				{
					_ = 10;
				}
				break;
			case 9:
				obj = new { };
				obj2 = 8;
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_hasTimeout)
				{
					obj2 = 5;
				}
				break;
			case 5:
				obj = 0;
				obj2 = 3;
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.GuideMap != null)
				{
					obj2 = 3;
				}
				break;
			case 3:
			case 4:
			{
				object obj3 = EntitySocks5Account.Username__BackingField;
				EqualityComparer<_00213> equalityComparer = EqualityComparer<_00213>.Default;
				if (Unsafe.As<object, UIntPtr>(ref obj3) >= Unsafe.As<EqualityComparer<_00213>, UIntPtr>(ref equalityComparer))
				{
					_ = 12;
					if (((EntitySocks5)EntitySocks5Account.AttachElement).Address__BackingField == null)
					{
						_ = 3;
					}
					break;
				}
				goto case 14;
			}
			case 6:
				obj = ((_003C_003Ef__AnonymousType2<, , , >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).ToString();
				_ = 5;
				if (EntitySocks5.DecorateDynamicModule == null)
				{
					_ = 1;
				}
				break;
			case 1:
				_ = ((_003C_003Ef__AnonymousType3<, >)((_003C_003Ef__AnonymousType3<, >)obj).entry).sid;
				obj2 = 0;
				if (((EntityLaunchGameProxy)EntityLaunchGameProxy.GameType__BackingField).GameVersion__BackingField != EnumGameVersion.None)
				{
					obj2 = 0;
				}
				break;
			case 8:
				((EntityLaunchGameProxy)obj).ModHashList__BackingField = P_0;
				obj2 = 2;
				break;
			case 13:
				_ = EntityLaunchGameProxy.Name__BackingField;
				_ = ((EntityLaunchGameProxy)obj).ServerAddress__BackingField;
				/*Error near IL_0210: Member reference must be method, but was: Field*/;
			case 10:
				((EntityLaunchGameProxy)obj).Value__BackingField = obj;
				obj2 = 11;
				break;
			case 12:
				return _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectSymbolicAuditor();
			default:
				obj++;
				obj2 = 4;
				break;
			case 15:
				((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).TryMatchAtCurrentPosition((ReadOnlySpan<char>)((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)obj).TryFindNextPossibleStartingPosition((ReadOnlySpan<char>)MemoryExtensions.IndexOfAnyExcept<T>((ReadOnlySpan<T>)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.DecorateConfigurableDecider(), (SearchValues<T>)GameProxy.Logger__BackingField)));
				_ = ((GameProxy)((GameProxy)obj).Name__BackingField).Session__BackingField;
				_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.DecorateCustomNode();
				_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities._002Ecctor();
				_ = ((GameProxy)((GameProxy)obj).GameVersion__BackingField).ModHashList__BackingField;
				_ = ((EntitySocks5Account)(object)new StringBuilder((string?)__ldftn(EntitySocks5Account._002Ector))).Username;
				_ = 7;
				break;
			}
		}
	}
}
