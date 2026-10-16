using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace WinRT.Mass_WinUIGenericHelpers;

internal static class GlobalVtableLookup
{
	internal static object CreateAttribute;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[ModuleInitializer]
	internal static void InitializeGlobalVtableLookup()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object LookupVtableEntries(object type)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 95, 1790775542, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790775542, new IntPtr(2737316780412L), 15);
		}
		return ((delegate*<object, object>)obj)(type);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object LookupRuntimeClassName(object type)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 96, 1790775543, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790775543, new IntPtr(2737316770012L), 15);
		}
		return ((delegate*<object, object>)obj)(type);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateDetachedAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GlobalVtableLookup DecorateDetailedAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00_FF00_EB00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775540, new IntPtr(2737316771052L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_FF00_FF00_FF00_FF00_EC00()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_004a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0065->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
			case 1:
				obj2 = null;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 2:
				obj2 = null;
				if (true)
				{
					obj2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00_FF00_ED00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775541, new IntPtr(2737316781452L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00_FF00_FF00_FF00_FF00_FF00_3100(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0196: Expected I4, but got Obj
		//IL_03b7: Expected Obj, but got I4
		//IL_06b1: Expected Obj, but got I4
		//IL_023b: Expected Obj, but got I4
		//IL_0449: Expected Obj, but got I4
		//IL_08a9: Expected Obj, but got I4
		//IL_098b: Expected Obj, but got I4
		//IL_07e7: Expected Obj, but got I4
		//IL_0294: Expected Obj, but got I4
		//IL_07d0: Expected Obj, but got I4
		//IL_01f6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0879->IL0019: Incompatible stack heights: 0 vs 1
		//IL_033f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0411->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0776->IL0019: Incompatible stack heights: 0 vs 1
		//IL_09c3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0354->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0229->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0859->IL0019: Incompatible stack heights: 0 vs 1
		//IL_059e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0385->IL0019: Incompatible stack types: I4 vs Obj
		//IL_094c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0606->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0979->IL0019: Incompatible stack types: I4 vs Obj
		//IL_07bc->IL0019: Incompatible stack types: I4 vs Obj
		//IL_065d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0897->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0635->IL0019: Incompatible stack types: I4 vs Obj
		//IL_053e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0520->IL0019: Incompatible stack heights: 0 vs 1
		//IL_039a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_09a5->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0253->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0476->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0321->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0648->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0437->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0424->IL0019: Incompatible stack types: I4 vs Obj
		//IL_08fd->IL0019: Incompatible stack heights: 0 vs 1
		//IL_04ed->IL0019: Incompatible stack heights: 0 vs 1
		//IL_06fa->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02f9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0551->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05e0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01d9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0690->IL0019: Incompatible stack types: I4 vs Obj
		//IL_081d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_04cd->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0372->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05f3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_07a9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03f3->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0756->IL0019: Incompatible stack heights: 0 vs 1
		//IL_020b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_030c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0884->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0781->IL0019: Incompatible stack types: I4 vs Obj
		//IL_035f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0864->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0957->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0668->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0463->IL0019: Incompatible stack types: I4 vs Obj
		//IL_052b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03a5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_09b0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_032c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02db->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0908->IL0019: Incompatible stack types: I4 vs Obj
		//IL_067d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04f8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_048b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_06dc->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0828->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04d8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0796->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03fe->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0761->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0216->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02e6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_06e7->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				case 75:
					if (obj == null)
					{
						obj2 = 7;
						continue;
					}
					goto case 9;
				case 3:
					obj = P_0;
					obj2 = 2;
					continue;
				case 92:
					if (obj != null)
					{
						if (5 == 0)
						{
							obj2 = 44;
						}
						continue;
					}
					goto case 19;
				case 19:
					if (obj != null)
					{
						obj2 = 67;
						continue;
					}
					goto case 28;
				case 21:
					if (obj != null)
					{
						obj = 54;
						break;
					}
					goto case 72;
				case 51:
					if (obj != null)
					{
						obj2 = 70;
						continue;
					}
					goto case 37;
				case 84:
					if (obj != null)
					{
						obj = 32;
						break;
					}
					goto case 26;
				case 48:
					return (object)/*Error near IL_02c6: Stack underflow*/;
				case 58:
					if (obj != null)
					{
						if (18 == 0)
						{
							obj2 = 79;
						}
						continue;
					}
					goto case 55;
				case 72:
					if (obj == null)
					{
						obj2 = 91;
						continue;
					}
					goto case 9;
				case 93:
					if (obj != null)
					{
						obj2 = 33;
						continue;
					}
					goto case 34;
				case 55:
					if (obj == null)
					{
						if (47 == 0)
						{
							obj2 = 56;
						}
						continue;
					}
					goto case 23;
				case 11:
					if (obj != null)
					{
						obj2 = 81;
						continue;
					}
					goto case 30;
				case 18:
					if (obj != null)
					{
						if (false)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 59;
				case 85:
					if (obj == null)
					{
						obj2 = 69;
						continue;
					}
					goto case 9;
				case 26:
					if (obj == null)
					{
						obj2 = 93;
						continue;
					}
					goto default;
				case 45:
					if (obj != null)
					{
						if (24 != 0)
						{
							obj2 = 64;
						}
						continue;
					}
					goto case 83;
				case 1:
					if (obj != null)
					{
						obj = 10;
						break;
					}
					goto case 35;
				case 90:
					if (obj == null)
					{
						if (16 == 0)
						{
							obj2 = 6;
						}
						continue;
					}
					goto case 9;
				case 12:
					if (obj == null)
					{
						obj2 = 43;
						continue;
					}
					goto default;
				case 60:
					if (obj == null)
					{
						obj2 = 51;
						continue;
					}
					goto case 9;
				case 57:
					if (obj == null)
					{
						obj2 = 92;
						continue;
					}
					goto case 9;
				case 46:
					if (obj == null)
					{
						obj = 22;
						break;
					}
					goto case 9;
				case 4:
					return (object)/*Error near IL_0450: Stack underflow*/;
				case 39:
					if (obj == null)
					{
						obj2 = 58;
						continue;
					}
					goto case 48;
				case 53:
					if (obj == null)
					{
						obj2 = 57;
						continue;
					}
					goto case 9;
				case 9:
				case 10:
				case 13:
				case 29:
				case 36:
				case 42:
				case 44:
				case 47:
				case 52:
				case 54:
				case 62:
				case 64:
				case 67:
				case 70:
				case 76:
				case 80:
				case 81:
				case 86:
				case 88:
					return (object)/*Error near IL_0478: Stack underflow*/;
				case 68:
					if (obj != null)
					{
						obj2 = 66;
						continue;
					}
					goto case 25;
				case 83:
					if (obj != null)
					{
						if (86 == 0)
						{
							obj2 = 29;
						}
						continue;
					}
					goto case 78;
				case 65:
					if (obj != null)
					{
						if (22 == 0)
						{
							obj2 = 36;
						}
						continue;
					}
					goto case 53;
				case 43:
					if (obj != null)
					{
						if (77 == 0)
						{
							obj2 = 4;
						}
						continue;
					}
					goto case 18;
				case 41:
					if (obj != null)
					{
						obj2 = 62;
						continue;
					}
					goto case 61;
				case 73:
					if (obj == null)
					{
						obj2 = 75;
						continue;
					}
					goto case 9;
				case 25:
					if (obj == null)
					{
						obj2 = 74;
						continue;
					}
					goto case 5;
				case 17:
					return (object)/*Error near IL_05a0: Stack underflow*/;
				case 74:
					if (obj != null)
					{
						obj2 = 5;
						continue;
					}
					if (obj == null)
					{
						if (23 == 0)
						{
							obj2 = 39;
						}
						continue;
					}
					goto case 4;
				case 87:
					if (obj != null)
					{
						obj2 = 29;
						continue;
					}
					goto case 49;
				case 28:
					if (obj == null)
					{
						obj2 = 21;
						continue;
					}
					goto case 9;
				case 38:
					if (obj != null)
					{
						obj2 = 42;
						continue;
					}
					goto case 50;
				case 56:
					if (obj == null)
					{
						obj2 = 31;
						continue;
					}
					goto case 23;
				case 35:
					if (obj != null)
					{
						if (23 == 0)
						{
							obj2 = 88;
						}
						continue;
					}
					goto case 82;
				case 8:
					return (object)/*Error near IL_066a: Stack underflow*/;
				case 63:
					if (obj == null)
					{
						return null;
					}
					obj2 = 17;
					continue;
				case 78:
					if (obj == null)
					{
						obj2 = 90;
						continue;
					}
					goto case 9;
				case 2:
					if (obj != null)
					{
						obj = 14;
						break;
					}
					goto case 27;
				case 5:
				case 66:
					return (object)/*Error near IL_06c7: Stack underflow*/;
				case 71:
					if (obj == null)
					{
						obj2 = 63;
						continue;
					}
					goto case 8;
				case 91:
					if (obj == null)
					{
						if (38 != 0)
						{
							obj2 = 25;
						}
						continue;
					}
					goto case 9;
				case 15:
					if (obj == null)
					{
						if (4 == 0)
						{
							obj2 = 11;
						}
						continue;
					}
					goto case 9;
				default:
					return (object)/*Error near IL_0783: Stack underflow*/;
				case 89:
					if (obj == null)
					{
						if (obj != null)
						{
							obj2 = 52;
							continue;
						}
						goto case 41;
					}
					obj2 = 6;
					continue;
				case 34:
					if (obj != null)
					{
						obj2 = 24;
						continue;
					}
					goto case 12;
				case 23:
				case 79:
					return (object)/*Error near IL_07be: Stack underflow*/;
				case 31:
					if (obj == null)
					{
						obj = 71;
						break;
					}
					goto case 8;
				case 69:
					if (obj != null)
					{
						obj = 47;
						break;
					}
					goto case 46;
				case 82:
					if (obj != null)
					{
						if (6 == 0)
						{
							obj2 = 76;
						}
						continue;
					}
					goto case 73;
				case 22:
					if (obj != null)
					{
						if (80 == 0)
						{
							obj2 = 33;
						}
						continue;
					}
					goto case 65;
				case 7:
					if (obj == null)
					{
						if (34 != 0)
						{
							obj2 = 68;
						}
						continue;
					}
					goto case 9;
				case 37:
					if (obj == null)
					{
						obj2 = 87;
						continue;
					}
					goto case 9;
				case 49:
					if (obj == null)
					{
						obj = 15;
						break;
					}
					goto case 9;
				case 61:
					if (obj != null)
					{
						if (1 == 0)
						{
							obj2 = 13;
						}
						continue;
					}
					goto case 45;
				case 27:
					if (obj != null)
					{
						if (11 == 0)
						{
							obj2 = 40;
						}
						continue;
					}
					goto case 84;
				case 30:
					if (obj == null)
					{
						obj2 = 85;
						continue;
					}
					goto case 9;
				case 59:
					if (obj != null)
					{
						obj = 20;
						break;
					}
					goto case 89;
				case 50:
					if (obj == null)
					{
						if (1 == 0)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 9;
				case 16:
					if (obj == null)
					{
						obj2 = 60;
						continue;
					}
					goto case 9;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_3200(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775538, new IntPtr(2737316781452L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_3300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775539, new IntPtr(2737316771052L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00㐀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00㔀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775536, new IntPtr(2737316781452L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00㘀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00㜀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775537, new IntPtr(2737316781452L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00_FF00_FF00_FF00_FF00_FF00㠀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_01fa: Expected I4, but got Obj
		//IL_02eb: Expected Obj, but got I4
		//IL_097a: Expected Obj, but got I4
		//IL_06bd: Expected Obj, but got I4
		//IL_0e25: Expected Obj, but got I4
		//IL_047b: Expected Obj, but got I4
		//IL_0fee: Expected Obj, but got I4
		//IL_0ba2: Expected Obj, but got I4
		//IL_068d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_03dd->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0e08->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0ddb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0b14->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0d30->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0c22->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0a86->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0d5c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_022b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0964->IL0019: Incompatible stack heights: 0 vs 1
		//IL_09c7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0b2b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0aec->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0e38->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0ade->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0e4f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0237->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0469->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02d5->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0aa7->IL0019: Incompatible stack heights: 0 vs 1
		//IL_03e9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0a7a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0a17->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0674->IL0019: Incompatible stack heights: 0 vs 1
		//IL_045d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0d24->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02c5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0de7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0e96->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0426->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0a63->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0698->IL0019: Incompatible stack types: I4 vs Obj
		//IL_07a0->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0bbc->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0e13->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0882->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0b1f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0d45->IL0019: Incompatible stack heights: 0 vs 1
		//IL_086f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0c07->IL0019: Incompatible stack types: I4 vs Obj
		//IL_096f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_07ed->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0334->IL0019: Incompatible stack heights: 0 vs 1
		//IL_02ae->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0ec7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_06ab->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0314->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0214->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0edc->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0af7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0e43->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0a99->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0d91->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0e88->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0446->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0dfa->IL0019: Incompatible stack types: I4 vs Obj
		//IL_1008->IL0019: Incompatible stack heights: 0 vs 1
		//IL_024a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_07da->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0648->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0418->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0b5a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0633->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02e0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0666->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0e62->IL0019: Incompatible stack types: I4 vs Obj
		//IL_025f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_08a4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0ab2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0e75->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0620->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0b6d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0a37->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0800->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0a22->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0ac7->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0eb4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_067f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0dc4->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0299->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0ea1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0994->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0d0d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0431->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0daf->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0d71->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0a6e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_07ab->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05bf->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0bc7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_093a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0d50->IL0019: Incompatible stack types: I4 vs Obj
		//IL_033f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0f7f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_02b9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_031f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_021f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0ee7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_072a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0d9c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0cf8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0451->IL0019: Incompatible stack types: I4 vs Obj
		//IL_09ed->IL0019: Incompatible stack types: I4 vs Obj
		//IL_1013->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0653->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04b8->IL0019: Incompatible stack heights: 0 vs 1
		//IL_026a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0a42->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0ad2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0dcf->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0602->IL0019: Incompatible stack heights: 0 vs 1
		//IL_078b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_099f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0d18->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0d7c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03b7->IL0019: Incompatible stack heights: 0 vs 1
		//IL_05ca->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0fc0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0f8a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0735->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04c3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_060d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03c2->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 73;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 43:
					if (obj != null)
					{
						if (13 != 0)
						{
							obj2 = 23;
						}
						continue;
					}
					goto case 65;
				case 25:
					obj2 = 63;
					continue;
				case 58:
					obj2 = 4;
					continue;
				case 62:
					if (obj == null)
					{
						obj2 = 83;
						continue;
					}
					goto case 48;
				case 77:
					if (obj == null)
					{
						if (54 != 0)
						{
							obj2 = 113;
						}
						continue;
					}
					goto case 20;
				case 100:
					if (obj == null)
					{
						obj2 = 21;
						continue;
					}
					goto case 6;
				case 35:
					if (obj != null)
					{
						if (24 == 0)
						{
							obj2 = 12;
						}
						continue;
					}
					if (obj != null)
					{
						if (0 == 0)
						{
							obj2 = 0;
						}
						continue;
					}
					if (obj == null)
					{
						obj2 = 97;
						continue;
					}
					goto case 109;
				case 31:
				case 98:
				case 104:
					obj2 = 30;
					continue;
				case 73:
					obj = P_0;
					if (72 == 0)
					{
						obj2 = 28;
					}
					continue;
				case 75:
					obj = 94;
					break;
				case 42:
					if (obj == null)
					{
						if (9 != 0)
						{
							obj2 = 2;
						}
						continue;
					}
					goto case 3;
				case 33:
					if (obj != null)
					{
						if (67 != 0)
						{
							obj2 = 115;
						}
						continue;
					}
					goto case 38;
				case 46:
					_ = 6;
					_ = 0;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 1;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 2;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 3;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 4;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 5;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					return obj;
				case 113:
					if (obj != null)
					{
						if (34 != 0)
						{
							obj2 = 60;
						}
						continue;
					}
					goto case 71;
				case 4:
					obj2 = 78;
					continue;
				case 84:
					obj2 = 114;
					continue;
				case 69:
					if (obj == null)
					{
						obj2 = 59;
						continue;
					}
					goto case 89;
				case 109:
					if (105 == 0)
					{
						obj2 = 57;
					}
					continue;
				case 57:
					if (obj != null)
					{
						if (98 != 0)
						{
							obj2 = 97;
						}
						continue;
					}
					if (obj == null)
					{
						obj2 = 61;
						continue;
					}
					goto case 3;
				case 94:
					obj2 = 7;
					continue;
				case 67:
					obj2 = 84;
					continue;
				case 70:
					if (obj == null)
					{
						obj = 79;
						break;
					}
					goto case 3;
				case 101:
					_ = 2;
					_ = 0;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 1;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					return obj;
				case 28:
					_ = 7;
					_ = 0;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 1;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 2;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 3;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 4;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 5;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 6;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					return obj;
				case 78:
					_ = 6;
					_ = 0;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 1;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 2;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 3;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 4;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 5;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					return obj;
				case 2:
					if (obj == null)
					{
						if (69 != 0)
						{
							obj2 = 16;
						}
						continue;
					}
					goto case 89;
				case 105:
					_ = 2;
					_ = 0;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 1;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					return obj;
				case 97:
					if (obj == null)
					{
						if (1 == 0)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 54;
				case 82:
					if (obj != null)
					{
						obj2 = 37;
						continue;
					}
					goto case 85;
				case 72:
					if (obj != null)
					{
						obj2 = 41;
						continue;
					}
					goto case 29;
				case 65:
					if (obj == null)
					{
						if (4 == 0)
						{
							obj2 = 99;
						}
						continue;
					}
					goto case 6;
				case 74:
					if (obj == null)
					{
						if (obj != null)
						{
							if (102 != 0)
							{
								obj2 = 102;
							}
							continue;
						}
						if (obj == null)
						{
							return null;
						}
						obj = 96;
						break;
					}
					obj2 = 101;
					continue;
				case 93:
					if (67 == 0)
					{
						obj2 = 12;
					}
					continue;
				default:
					if (6 != 0)
					{
						obj2 = 16;
					}
					continue;
				case 38:
					if (obj != null)
					{
						obj2 = 14;
						continue;
					}
					goto case 42;
				case 21:
					if (obj != null)
					{
						obj = 34;
						break;
					}
					goto case 43;
				case 68:
					_ = 5;
					_ = 0;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 1;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 2;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 3;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 4;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					return obj;
				case 50:
					if (obj == null)
					{
						if (73 != 0)
						{
							obj2 = 74;
						}
						continue;
					}
					goto case 101;
				case 63:
					_ = 4;
					_ = 0;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 1;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 2;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 3;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					return obj;
				case 99:
					if (obj != null)
					{
						obj2 = 48;
						continue;
					}
					goto case 64;
				case 1:
					if (obj == null)
					{
						if (12 == 0)
						{
							obj2 = 50;
						}
						continue;
					}
					goto case 54;
				case 64:
					if (obj == null)
					{
						obj2 = 92;
						continue;
					}
					goto case 48;
				case 32:
					if (obj == null)
					{
						obj2 = 5;
						continue;
					}
					goto case 3;
				case 88:
					if (obj == null)
					{
						obj2 = 107;
						continue;
					}
					goto case 3;
				case 26:
					if (obj == null)
					{
						obj2 = 57;
						continue;
					}
					goto case 31;
				case 9:
					if (obj != null)
					{
						obj2 = 17;
						continue;
					}
					goto case 47;
				case 79:
					if (obj == null)
					{
						obj2 = 95;
						continue;
					}
					goto case 3;
				case 11:
					_ = 8;
					_ = 0;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 1;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 2;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 3;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 4;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 5;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 6;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 7;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					return obj;
				case 13:
					if (obj != null)
					{
						obj2 = 31;
						continue;
					}
					goto case 52;
				case 30:
					if (8 != 0)
					{
						obj2 = 7;
					}
					continue;
				case 106:
					obj = 58;
					break;
				case 107:
					if (obj == null)
					{
						if (2 != 0)
						{
							obj2 = 1;
						}
						continue;
					}
					goto case 3;
				case 44:
					obj2 = 11;
					continue;
				case 89:
					_ = 1;
					_ = 0;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					return obj;
				case 48:
				case 90:
					if (12 != 0)
					{
						obj2 = 2;
					}
					continue;
				case 86:
					if (obj == null)
					{
						if (76 == 0)
						{
							obj2 = 51;
						}
						continue;
					}
					goto case 48;
				case 114:
					if (55 == 0)
					{
						obj2 = 14;
					}
					continue;
				case 3:
				case 14:
				case 17:
				case 22:
				case 27:
				case 37:
				case 39:
				case 40:
				case 87:
				case 115:
				case 116:
					obj2 = 106;
					continue;
				case 18:
					obj2 = 45;
					continue;
				case 52:
					if (obj != null)
					{
						obj2 = 104;
						continue;
					}
					goto case 26;
				case 80:
					if (44 == 0)
					{
						obj2 = 36;
					}
					continue;
				case 91:
					if (obj == null)
					{
						if (23 != 0)
						{
							obj2 = 66;
						}
						continue;
					}
					goto case 24;
				case 54:
					obj2 = 15;
					continue;
				case 49:
					if (32 == 0)
					{
						obj2 = 46;
					}
					continue;
				case 10:
					if (28 != 0)
					{
						obj2 = 75;
					}
					continue;
				case 45:
					obj2 = 28;
					continue;
				case 71:
					if (obj == null)
					{
						obj2 = 111;
						continue;
					}
					goto case 6;
				case 83:
					if (obj == null)
					{
						obj2 = 112;
						continue;
					}
					goto case 48;
				case 118:
					_ = 2;
					_ = 0;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 1;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					return obj;
				case 5:
					if (obj != null)
					{
						if (116 == 0)
						{
							obj2 = 9;
						}
						continue;
					}
					goto case 33;
				case 29:
					if (obj == null)
					{
						obj2 = 36;
						continue;
					}
					goto case 20;
				case 15:
					obj2 = 103;
					continue;
				case 7:
					_ = 10;
					_ = 0;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 1;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 2;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 3;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 4;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 5;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 6;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 7;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 8;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 9;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					return obj;
				case 108:
					if (obj == null)
					{
						if (91 != 0)
						{
							obj2 = 87;
						}
						continue;
					}
					goto case 24;
				case 96:
					obj2 = 18;
					continue;
				case 12:
					obj2 = 80;
					continue;
				case 19:
					if (obj == null)
					{
						if (13 != 0)
						{
							obj2 = 4;
						}
						continue;
					}
					goto case 48;
				case 24:
				case 117:
					obj2 = 93;
					continue;
				case 112:
					if (obj == null)
					{
						if (19 != 0)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 48;
				case 53:
					if (obj != null)
					{
						if (2 == 0)
						{
							obj2 = 3;
						}
						continue;
					}
					goto case 82;
				case 111:
					if (obj == null)
					{
						obj2 = 100;
						continue;
					}
					goto case 6;
				case 95:
					if (obj != null)
					{
						if (14 == 0)
						{
							obj2 = 22;
						}
						continue;
					}
					goto case 88;
				case 8:
					obj2 = 10;
					continue;
				case 102:
					obj2 = 118;
					continue;
				case 59:
					if (obj == null)
					{
						if (obj != null)
						{
							obj2 = 117;
							continue;
						}
						goto case 108;
					}
					obj2 = 89;
					continue;
				case 6:
				case 23:
				case 34:
				case 60:
					if (17 == 0)
					{
						obj2 = 25;
					}
					continue;
				case 66:
					if (obj == null)
					{
						obj = 56;
						break;
					}
					goto case 24;
				case 20:
				case 41:
				case 51:
					if (2 != 0)
					{
						obj2 = 49;
					}
					continue;
				case 55:
					obj2 = 110;
					continue;
				case 76:
					if (obj == null)
					{
						obj2 = 62;
						continue;
					}
					goto case 48;
				case 81:
					if (obj == null)
					{
						obj2 = 35;
						continue;
					}
					goto case 24;
				case 56:
					if (obj == null)
					{
						obj2 = 81;
						continue;
					}
					goto case 24;
				case 103:
					if (29 != 0)
					{
						obj2 = 68;
					}
					continue;
				case 92:
					if (obj == null)
					{
						obj2 = 86;
						continue;
					}
					goto case 48;
				case 36:
					if (obj != null)
					{
						obj2 = 20;
						continue;
					}
					goto case 77;
				case 47:
					if (obj != null)
					{
						if (39 == 0)
						{
							obj2 = 13;
						}
						continue;
					}
					goto case 53;
				case 110:
					_ = 8;
					_ = 0;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 1;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 2;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 3;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 4;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 5;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 6;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 7;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					return obj;
				case 16:
					_ = 2;
					_ = 0;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					_ = 1;
					_ = ref obj;
					_ = ref obj;
					_ = ref obj;
					return obj;
				case 85:
					if (obj != null)
					{
						obj = 27;
						break;
					}
					goto case 70;
				case 61:
					if (obj != null)
					{
						if (40 != 0)
						{
							obj2 = 2;
						}
						continue;
					}
					goto case 32;
				}
				break;
			}
		}
	}
}
