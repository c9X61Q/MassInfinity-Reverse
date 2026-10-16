using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Mass.Common.Localization;

public static class LocalizationManager
{
	[CompilerGenerated]
	private static object Culture__BackingField = CultureInfo.CurrentUICulture;

	[CompilerGenerated]
	private static Action<CultureInfo>? m_CultureChanged;

	private static object ReflectAdaptableSingleton;

	public static CultureInfo Culture
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			_FF00爀(value);
		}
	}

	public static event Action<CultureInfo>? CultureChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			_FF00猀(value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			_FF00礀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetCulture(CultureInfo culture)
	{
		_FF00渀(culture);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetCulture(string languageTag)
	{
		_FF00漀(languageTag);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EncryptConnection()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LocalizationManager ReflectBasicState()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00椀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778469, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00樀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00欀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778468, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00氀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778471, new IntPtr(2737337523164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00洀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00渀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0060->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0091->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0054->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ab->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				obj2 = P_0;
				if (2 == 0)
				{
					obj2 = 2;
				}
				break;
			default:
				_ = 3;
				break;
			case 4:
				return;
			case 1:
				obj2 = P_0;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 2:
				if ((int)/*Error near IL_007b: Stack underflow*/ == 0)
				{
					obj2 = 5;
					break;
				}
				obj2 = P_0;
				if (1 == 0)
				{
					obj2 = 4;
				}
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00漀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0045->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = P_0;
				if (0 == 0)
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
	internal unsafe static void _FF00瀀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778470, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void _FF00焀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778473, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void _FF00爀(object P_0)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00猀(Action<CultureInfo> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_006a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00b6->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00a7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0088->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0075->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c1->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				obj2 = obj;
				obj = obj;
				if (2 != 0)
				{
					obj2 = 1;
				}
				break;
			case 4:
				obj = obj;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				if (obj == obj)
				{
					obj2 = 3;
					break;
				}
				goto case 4;
			case 3:
				return;
			default:
				obj2 = obj;
				obj = P_0;
				if (0 == 0)
				{
					obj2 = 1;
				}
				break;
			case 5:
				obj = (object)/*Error near IL_00aa: Stack underflow*/;
				if (0 == 0)
				{
					obj2 = 4;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00琀(Action<CultureInfo> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778472, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00甀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778475, new IntPtr(2737337520044L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00瘀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00眀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778474, new IntPtr(2737337519004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00砀(Action<CultureInfo> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778477, new IntPtr(2737337520044L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00礀(Action<CultureInfo> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0066->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00c1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0090->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0071->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0055->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ae->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				obj = (object)/*Error near IL_003e: Stack underflow*/;
				if (2 != 0)
				{
					obj2 = 1;
				}
				break;
			case 4:
				return;
			case 2:
				obj = obj;
				if (3 == 0)
				{
					obj2 = 5;
				}
				break;
			case 1:
				obj2 = obj;
				obj = obj;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 5:
				obj2 = obj;
				obj = P_0;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			default:
				if (obj == obj)
				{
					obj2 = 4;
					break;
				}
				goto case 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00稀(Action<CultureInfo> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778476, new IntPtr(2737337532524L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
