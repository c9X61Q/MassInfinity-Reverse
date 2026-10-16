using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Markup;
using WinRT;
using WinRT.Mass_WinUIVtableClasses;

namespace Mass.WinUI;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Markup.IComponentConnector")]
[WinRTExposedType(typeof(Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails))]
public sealed class MainWindow : Window, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object LoginOverlay;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object ShowTransitions;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object HideTransitions;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object LoginNotificationPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object LoginSegmented;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private nint _contentLoaded;

	private static object ReflectResponsiveCollection;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MainWindow()
	{
		//IL_008a: Expected I4, but got Obj
		//IL_017e: Expected Obj, but got I4
		//IL_00d5: Expected Obj, but got I4
		//IL_021d: Expected Obj, but got I4
		//IL_016c: Expected Obj, but got I4
		//IL_01ba: Expected Obj, but got I4
		//IL_01ee: Expected Obj, but got I4
		//IL_0028->IL0031: Incompatible stack types: I4 vs Obj
		//IL_01d1->IL0031: Incompatible stack heights: 2 vs 1
		//IL_0183->IL002d: Incompatible stack types: I4 vs Obj
		//IL_00da->IL002d: Incompatible stack heights: 1 vs 2
		//IL_0203->IL0031: Incompatible stack heights: 2 vs 1
		//IL_010a->IL0031: Incompatible stack heights: 0 vs 1
		//IL_00ef->IL0031: Incompatible stack heights: 2 vs 1
		//IL_0124->IL0031: Incompatible stack heights: 3 vs 1
		//IL_0191->IL0031: Incompatible stack heights: 3 vs 1
		//IL_013f->IL0031: Incompatible stack types: I4 vs Obj
		//IL_01bf->IL002d: Incompatible stack types: I4 vs Obj
		//IL_0150->IL0031: Incompatible stack heights: 2 vs 1
		//IL_01f3->IL002d: Incompatible stack types: I4 vs Obj
		//IL_00ab->IL0031: Incompatible stack heights: 2 vs 1
		//IL_009e->IL0031: Incompatible stack heights: 3 vs 1
		//IL_0132->IL0031: Incompatible stack heights: 3 vs 1
		//IL_01dc->IL0031: Incompatible stack heights: 2 vs 1
		//IL_0031->IL0031: Incompatible stack heights: 3 vs 1
		//IL_020e->IL0031: Incompatible stack heights: 2 vs 1
		//IL_00bf->IL0031: Incompatible stack heights: 0 vs 1
		//IL_0115->IL0031: Incompatible stack types: I4 vs Obj
		//IL_00fa->IL0031: Incompatible stack heights: 2 vs 1
		//IL_01ae->IL0031: Incompatible stack types: I4 vs Obj
		//IL_015b->IL0031: Incompatible stack heights: 2 vs 1
		//IL_023d->IL0031: Incompatible stack types: I4 vs Obj
		//IL_00ca->IL0031: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = (object)/*Error near IL_000a: Stack underflow*/;
		object obj2 = this;
		if (4 == 0)
		{
			obj2 = 9;
		}
		while (true)
		{
			object obj3;
			object obj4;
			switch ((int)obj2)
			{
			default:
				return;
			case 19:
				_ = 6;
				break;
			case 17:
				_ = 10;
				break;
			case 5:
				if (obj != null)
				{
					if (14 != 0)
					{
						obj2 = 5;
					}
					break;
				}
				goto case 17;
			case 3:
				obj = 13;
				break;
			case 7:
				_ = 1150;
				if (0 == 0)
				{
					_ = 16;
				}
				break;
			case 6:
				obj = this;
				if (true)
				{
					obj2 = 0;
				}
				break;
			case 8:
				_ = 11;
				break;
			case 20:
				_ = 1;
				_ = 2;
				break;
			case 12:
				obj = (object)/*Error near IL_0135: Stack underflow*/;
				obj2 = 7;
				break;
			case 15:
				_ = 1;
				if (19 == 0)
				{
					_ = 9;
				}
				break;
			case 11:
				obj3 = obj;
				obj4 = obj;
				obj = 17;
				break;
			case 2:
				obj3 = obj;
				obj = 15;
				obj4 = 1;
				break;
			case 9:
				_ = 3;
				break;
			case 14:
				obj2 = obj;
				if (8 == 0)
				{
					obj2 = 2;
				}
				break;
			case 13:
				obj3 = this;
				obj = 12;
				obj4 = 1;
				break;
			case 1:
				if (5 == 0)
				{
					_ = 3;
				}
				break;
			case 16:
				obj3 = obj;
				obj = 4;
				obj4 = 680;
				break;
			case 4:
				_ = 1;
				if (5 != 0)
				{
					_ = 20;
				}
				break;
			case 10:
				obj3 = this;
				obj4 = this;
				obj = 18;
				break;
			case 0:
				return;
			case 18:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SwitchToMainMode()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00嬀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateTitleBarPreferredTheme(FrameworkElement fe)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00挀(fe);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AppWindowClosing(object sender, object args)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00椀(sender, args);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00怀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00栀((uint)connectionId, target);
	}

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PlayAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MainWindow ReflectCombinedChooser()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00娀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775714, new IntPtr(2737323040316L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00嬀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0042: Expected I4, but got Obj
		//IL_00fc->IL0019: Incompatible stack heights: 3 vs 1
		//IL_010a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00e3->IL0019: Incompatible stack heights: 10 vs 1
		//IL_011a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0079->IL0019: Incompatible stack heights: 3 vs 1
		//IL_008c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0068->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ee->IL0019: Incompatible stack heights: 10 vs 1
		//IL_0125->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0097->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 5:
				_ = -10;
				if (1 == 0)
				{
					_ = 1;
				}
				break;
			case 8:
				return;
			default:
				_ = 6;
				break;
			case 4:
				if ((int)/*Error near IL_0080: Stack underflow*/ == 0)
				{
					return;
				}
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 6:
				_ = 0.0;
				_ = 0.0;
				_ = 16.0;
				_ = 16.0;
				_ = 2;
				_ = 2;
				if (7 != 0)
				{
					_ = 7;
				}
				break;
			case 2:
				_ = 4;
				break;
			case 1:
				return;
			case 3:
				obj = (object)/*Error near IL_0100: Stack underflow*/;
				obj2 = 2;
				break;
			case 7:
				_ = 1;
				if (5 != 0)
				{
					_ = 3;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00尀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775715, new IntPtr(2737323020556L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00崀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00开()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775712, new IntPtr(2737323019516L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00怀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0078->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0092->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0083->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0068->IL0019: Incompatible stack heights: 2 vs 1
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
				if (this != null)
				{
					return;
				}
				obj2 = 2;
				break;
			case 5:
				return;
			case 4:
				return;
			case 2:
				_ = 1;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			default:
				obj = (object)/*Error near IL_006c: Stack underflow*/;
				if (true)
				{
					obj2 = 1;
				}
				break;
			case 1:
				_ = 0;
				_ = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00愀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775713, new IntPtr(2737323035116L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00戀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775726, new IntPtr(2737323036156L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00挀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_004e: Expected I4, but got Obj
		//IL_0140: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I4
		//IL_00a6: Expected Obj, but got I4
		//IL_0116->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0081->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_014c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00cc->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00b2->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0121->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0068->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00fa->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0157->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00bd->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0073->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0105->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				return;
			case 4:
				if ((nint)obj != 2)
				{
					if (9 == 0)
					{
						obj2 = 7;
					}
					continue;
				}
				goto case 7;
			case 2:
				obj = P_0;
				obj2 = 5;
				continue;
			case 3:
				obj = this;
				obj2 = 2;
				continue;
			case 9:
			case 11:
				obj = 1;
				if (0 == 0)
				{
					obj2 = 0;
				}
				continue;
			case 7:
				obj = 3;
				if (1 == 0)
				{
					obj2 = 10;
				}
				continue;
			case 5:
				if ((nint)obj != 1)
				{
					if (4 == 0)
					{
						obj2 = 1;
					}
					continue;
				}
				break;
			default:
				if (true)
				{
					_ = 0;
				}
				continue;
			case 6:
				break;
			}
			obj = 2;
			if (8 != 0)
			{
				obj2 = 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00搀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775727, new IntPtr(2737323026796L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00攀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00昀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775724, new IntPtr(2737323013276L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00最(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775725, new IntPtr(2737323035116L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00栀(uint P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0052: Expected I4, but got Obj
		//IL_00ce->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0147->IL0019: Incompatible stack heights: 3 vs 1
		//IL_009e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_012e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0085->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00dc->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0113->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0139->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0090->IL0019: Incompatible stack heights: 2 vs 1
		//IL_011e->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 9:
				if (0 == 0)
				{
					_ = 0;
				}
				continue;
			case 5:
				goto IL_0090;
			case 3:
				goto IL_00c0;
			case 10:
				goto IL_00ce;
			case 2:
				switch (P_0)
				{
				case 5u:
					break;
				case 3u:
					goto IL_0090;
				case 6u:
					goto IL_00c0;
				case 2u:
					goto IL_00ce;
				default:
					goto IL_0107;
				case 4u:
					goto end_IL_0019;
				}
				goto case 9;
			case 6:
				return;
			default:
				_ = 1;
				if (6 == 0)
				{
					_ = 4;
				}
				continue;
			case 4:
				break;
				IL_0090:
				_ = 8;
				continue;
				IL_0107:
				if (1 == 0)
				{
					obj2 = 0;
				}
				continue;
				IL_00ce:
				_ = 11;
				continue;
				IL_00c0:
				_ = 7;
				continue;
				end_IL_0019:
				break;
			}
			_ = 12;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_FF00_FF00_FF00椀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003c->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0047->IL0019: Incompatible stack heights: 3 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 1:
				_ = 0;
				if (false)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}
}
