using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

namespace Mass.WinUI.Pages;

public abstract class CharacterPageBase : Page
{
	private nint _isImageAnimationHooked;

	private static object ObserveList;

	protected abstract Image HeroImage { get; }

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnNavigatedTo(NavigationEventArgs e)
	{
		_FF00_FF00_FF00鼀(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnHeroImageLoaded(object sender, object e)
	{
		_FF00_FF00_FF00阀(sender, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
	{
		_FF00_FF00_FF00鴀(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnNavigatedFrom(NavigationEventArgs e)
	{
		_FF00_FF00_FF00ꈀ(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected CharacterPageBase()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateConnectedDictionary()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CharacterPageBase WriteContext()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00销(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778778, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00阀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0067->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0072->IL0019: Incompatible stack types: I4 vs Obj
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
			case 0:
				return;
			case 2:
				if ((int)/*Error near IL_0033: Stack underflow*/ == 0)
				{
					if (1 == 0)
					{
						obj2 = 1;
					}
				}
				else if (false)
				{
					obj2 = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00需(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778779, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00頀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00餀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778776, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00騀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00鬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778777, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _FF00_FF00_FF00鴀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0061->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0047->IL0019: Incompatible stack heights: 0 vs 1
		//IL_006c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0052->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				if (0 == 0)
				{
					_ = 0;
				}
				continue;
			case 3:
				return;
			case 2:
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 3;
				}
				continue;
			}
			if ((nint)P_0 == 1)
			{
				if (2 == 0)
				{
					obj2 = 1;
				}
				continue;
			}
			return;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe void _FF00_FF00_FF00鸀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778854, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _FF00_FF00_FF00鼀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0057->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0048->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0086->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0062->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0073->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0091->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				_ = 3;
				continue;
			default:
				_ = 1;
				if (0 == 0)
				{
					_ = 1;
				}
				continue;
			case 3:
				if (this != null)
				{
					obj2 = 2;
					continue;
				}
				break;
			case 1:
				return;
			case 2:
				return;
			case 5:
				break;
			}
			if (0 == 0)
			{
				_ = 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe void _FF00_FF00_FF00ꀀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778855, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe void _FF00_FF00_FF00ꄀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778852, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _FF00_FF00_FF00ꈀ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0082->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0068->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a0->IL0019: Incompatible stack heights: 0 vs 1
		//IL_008d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0058->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0073->IL0019: Incompatible stack heights: 2 vs 1
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
			case 2:
				if (1 == 0)
				{
					_ = 3;
				}
				break;
			case 4:
				return;
			case 5:
				return;
			case 3:
				_ = 0;
				if (5 == 0)
				{
					_ = 2;
				}
				break;
			case 1:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			default:
				if (this == null)
				{
					if (4 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe void _FF00_FF00_FF00ꌀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778853, new IntPtr(2737336193852L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
