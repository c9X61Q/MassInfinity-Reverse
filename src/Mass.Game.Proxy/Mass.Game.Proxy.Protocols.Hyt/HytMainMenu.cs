using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
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
			//IL_0042: Expected I4, but got Obj
			//IL_0030->IL0039: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			Menu menu = this;
			if (false)
			{
				menu = (Menu)0;
			}
			switch ((int)menu)
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00턀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
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
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00茀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778769, new IntPtr(2737367931724L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00萀(object P_0, Action<GermPacket> P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_005e: Expected I4, but got Obj
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_010e: Invalid comparison between Unknown and Obj
		//IL_00f3: Expected Obj, but got I4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got I4
		//IL_01b6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0155->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0073->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ff->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0139->IL0019: Incompatible stack heights: 0 vs 1
		//IL_017d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00e5->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01a2->IL0019: Incompatible stack heights: 3 vs 1
		//IL_008f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0193->IL0015: Incompatible stack heights: 2 vs 0
		//IL_00cb->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01da->IL0019: Incompatible stack heights: 5 vs 1
		//IL_0160->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_011f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_010a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0144->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b1->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00f0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00d6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_012a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00bc->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 9;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 2:
					if (6 == 0)
					{
						_ = 0;
					}
					continue;
				case 11:
					if (12 == 0)
					{
						_ = 13;
					}
					continue;
				case 7:
					if (/*Error near IL_00a5: Stack underflow*/ != obj - 1)
					{
						if (0 == 0)
						{
							obj2 = 1;
						}
						continue;
					}
					goto default;
				case 14:
					obj = (object)/*Error near IL_00bf: Stack underflow*/;
					if (1 == 0)
					{
						obj2 = 10;
					}
					continue;
				case 9:
					obj = (object)/*Error near IL_00d9: Stack underflow*/;
					if (8 != 0)
					{
						obj2 = 5;
					}
					continue;
				case 5:
					obj = 0;
					if (3 != 0)
					{
						obj2 = 3;
					}
					continue;
				case 3:
				case 4:
					if (Unsafe.As<_003F, UIntPtr>(ref /*Error near IL_0113: Stack underflow*/) >= Unsafe.As<object, UIntPtr>(ref obj))
					{
						if (12 == 0)
						{
							obj2 = 3;
						}
						continue;
					}
					goto case 14;
				case 6:
					obj = (object)/*Error near IL_012d: Stack underflow*/;
					if (5 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 1:
					if (false)
					{
						obj2 = 0;
					}
					continue;
				case 8:
					_ = 2;
					continue;
				case 13:
					break;
				case 10:
					_ = 11;
					continue;
				case 12:
					return obj;
				default:
					obj++;
					obj2 = 4;
					continue;
				case 15:
					_ = 7;
					continue;
				}
				break;
			}
			obj = 15;
		}
	}
}
