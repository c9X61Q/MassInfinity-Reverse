using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml.Controls;
using WinRT;
using WinRT.Mass_WinUIVtableClasses;

namespace Mass.WinUI.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails))]
public class MainContentViewModel : ObservableObject
{
	private object? _navigationView;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private RelayCommand<NavigationView>? navigationViewLoadedCommand;

	internal static MainContentViewModel DecorateAccessibleServer;

	private Frame? Frame
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (Frame?)_FF00_FF00匀();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	public bool CanDesktopMenuInvoke
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00圀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00帀(value ? ((byte)1) : ((byte)0));
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	public bool CanMobileMenuInvoke
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00倀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00椀(value ? ((byte)1) : ((byte)0));
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IRelayCommand<NavigationView> NavigationViewLoadedCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00刀();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MainContentViewModel()
	{
		//IL_0056: Expected I4, but got Obj
		//IL_003c->IL0045: Incompatible stack types: I4 vs Obj
		//IL_0089->IL0045: Incompatible stack heights: 5 vs 3
		//IL_006d->IL0045: Incompatible stack heights: 4 vs 3
		//IL_0078->IL0045: Incompatible stack heights: 4 vs 3
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_ = this != null;
		_ = this != null;
		MainContentViewModel mainContentViewModel = this;
		if (1 == 0)
		{
			mainContentViewModel = (MainContentViewModel)1;
		}
		while (true)
		{
			switch ((int)mainContentViewModel)
			{
			case 1:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 2:
				return;
			default:
				_ = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	private void NavigationViewLoaded(object view)
	{
		_FF00_FF00愀(view);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FrameNavigated(object sender, object e)
	{
		_FF00_FF00昀(sender, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ViewItemInvoked(object sender, object args)
	{
		_FF00_FF00搀(sender, args);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectIsolatedProject()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MainContentViewModel ReflectAutomatableInspector()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00伀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778179, new IntPtr(2737336170972L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00倀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IRelayCommand<NavigationView> _FF00_FF00儀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778176, new IntPtr(2737336169932L), 15))(null, 0, new IntPtr(0L));
		return (IRelayCommand<NavigationView>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IRelayCommand<NavigationView> _FF00_FF00刀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17898, 1790778177, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778177, new IntPtr(2737336159532L), 15);
		}
		return (IRelayCommand<NavigationView>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00匀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17899, 1790778190, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778190, new IntPtr(2737336152252L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00吀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778191, new IntPtr(2737336166812L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00唀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_0062->IL0019: Incompatible stack heights: 3 vs 1
		//IL_008c->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007e->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0052->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		ref object reference = ref *(object*)obj;
		while (true)
		{
			switch ((uint)Unsafe.AsPointer(ref reference))
			{
			case 3u:
				_ = ref obj;
				_ = -1;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			default:
				_ = ref obj;
				_ = ref obj;
				_ = 4;
				break;
			case 4u:
				return;
			case 2u:
				reference = ref obj;
				if (true)
				{
					reference = ref *(object*)1;
				}
				break;
			case 1u:
				_ = ref obj;
				_ = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00嘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778188, new IntPtr(2737336177212L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00圀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00堀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778189, new IntPtr(2737336155372L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00夀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00娀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778186, new IntPtr(2737336161612L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00嬀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00尀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778187, new IntPtr(2737336154332L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00崀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778184, new IntPtr(2737336173052L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00帀(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_008c->IL0019: Incompatible stack heights: 3 vs 1
		//IL_007f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0096->IL0058: Incompatible stack heights: 1 vs 0
		//IL_0072->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a0->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				return;
			case 2:
				return;
			case 1:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				_ = 2;
				break;
			default:
				_ = 3;
				break;
			case 5:
				if (P_0 != 0)
				{
					_ = 4;
					break;
				}
				goto case 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00开(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778185, new IntPtr(2737336176172L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00怀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778198, new IntPtr(2737336155372L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00愀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0066->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0078->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b4->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00a1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0083->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0056->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00bf->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				return;
			default:
				_ = 3;
				break;
			case 5:
				return;
			case 4:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 3:
				obj2 = this;
				_ = null;
				if (false)
				{
					obj2 = 5;
				}
				break;
			case 2:
				if (this == null)
				{
					if (4 != 0)
					{
						_ = 3;
					}
				}
				else if (true)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00搀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0106: Expected I4, but got Obj
		//IL_0402: Expected Obj, but got I4
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected I4, but got Unknown
		//IL_035b: Expected Obj, but got I4
		//IL_0293: Expected Obj, but got I4
		//IL_054b: Expected Obj, but got I4
		//IL_03ab: Expected Obj, but got I4
		//IL_0132: Expected Obj, but got I4
		//IL_0624: Expected Obj, but got I4
		//IL_040c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_058b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0437->IL0019: Incompatible stack heights: 0 vs 1
		//IL_041c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0262->IL0019: Incompatible stack heights: 0 vs 1
		//IL_046e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_057a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0252->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0365->IL0019: Incompatible stack heights: 2 vs 1
		//IL_04e3->IL0019: Incompatible stack heights: 0 vs 1
		//IL_029d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_016a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0596->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05f4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0303->IL0019: Incompatible stack heights: 0 vs 1
		//IL_02df->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0282->IL0019: Incompatible stack heights: 0 vs 1
		//IL_014c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_02c1->IL0019: Incompatible stack heights: 0 vs 1
		//IL_04a8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0442->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0427->IL0019: Incompatible stack types: I4 vs Obj
		//IL_020e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_026d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01b9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0539->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03e1->IL0019: Incompatible stack heights: 0 vs 1
		//IL_019a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05c7->IL0019: Incompatible stack heights: 0 vs 1
		//IL_03fc->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0479->IL0019: Incompatible stack types: I4 vs Obj
		//IL_018a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05ab->IL0019: Incompatible stack heights: 0 vs 1
		//IL_04ee->IL0019: Incompatible stack types: I4 vs Obj
		//IL_030e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_028d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0157->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0337->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02cc->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03ec->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05d2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01d9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05b6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0629->IL0015: Incompatible stack heights: 2 vs 0
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 39;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 30:
					return;
				case 40:
					switch (obj - 4)
					{
					case 1:
						goto IL_0243;
					case 4:
						goto IL_028d;
					case 0:
						goto IL_0355;
					case 3:
						goto IL_03fc;
					case 2:
						goto IL_05e1;
					}
					obj = 15;
					break;
				case 13:
					if ((nint)obj != 72)
					{
						if (41 != 0)
						{
							obj2 = 44;
						}
						continue;
					}
					goto case 19;
				case 3:
					if ((nint)obj != 67)
					{
						obj2 = 13;
						continue;
					}
					goto case 9;
				case 49:
					if (obj != null)
					{
						obj2 = 4;
						continue;
					}
					goto IL_0243;
				case 33:
					if ((int)/*Error near IL_0190: Stack underflow*/ != 0)
					{
						obj2 = 35;
						continue;
					}
					return;
				case 28:
				case 46:
					if ((int)/*Error near IL_01af: Stack underflow*/ == 0)
					{
						obj2 = 10;
						continue;
					}
					obj = (object)/*Error near IL_03a2: Stack underflow*/;
					obj = 21;
					break;
				case 38:
					obj2 = obj;
					if (null != null)
					{
						if (52 == 0)
						{
							obj2 = 20;
						}
					}
					else
					{
						obj = obj;
						_ = 49;
					}
					continue;
				case 24:
					if ((nint)obj != 68)
					{
						obj2 = 5;
						continue;
					}
					goto case 17;
				default:
					goto IL_0243;
				case 25:
				case 41:
					obj = (object)/*Error near IL_0256: Stack underflow*/;
					if (26 == 0)
					{
						obj2 = 16;
					}
					continue;
				case 12:
					if (obj == null)
					{
						goto IL_0243;
					}
					if (33 == 0)
					{
						obj2 = 36;
					}
					continue;
				case 57:
					goto IL_028d;
				case 17:
					if (obj == null)
					{
						if (2 != 0)
						{
							obj2 = 29;
						}
						continue;
					}
					goto case 33;
				case 11:
					if (obj == null)
					{
						obj2 = 53;
						continue;
					}
					goto case 55;
				case 9:
					if (obj != null)
					{
						if (21 == 0)
						{
							obj2 = 41;
						}
						continue;
					}
					goto IL_0243;
				case 7:
					return;
				case 14:
				case 21:
				case 26:
				case 34:
				case 37:
				case 42:
				case 50:
					if (obj != null)
					{
						_ = 45;
						continue;
					}
					obj = obj;
					obj = P_1;
					if ((nint)this == 1)
					{
						obj = this;
					}
					else
					{
						obj = this;
					}
					obj = 30;
					break;
				case 54:
					goto IL_0355;
				case 10:
					return;
				case 32:
					if ((nint)obj != 83)
					{
						if (0 == 0)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 31;
				case 52:
					return;
				case 1:
					goto IL_03fc;
				case 23:
					obj = (object)/*Error near IL_0410: Stack underflow*/;
					if (14 != 0)
					{
						obj2 = 2;
					}
					continue;
				case 20:
				case 36:
					obj = (object)/*Error near IL_042b: Stack underflow*/;
					if (false)
					{
						obj2 = 50;
					}
					continue;
				case 39:
					obj = P_1;
					if (38 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 19:
					if (obj == null)
					{
						obj2 = 16;
						continue;
					}
					goto case 23;
				case 55:
					obj = (object)/*Error near IL_04d7: Stack underflow*/;
					if (42 != 0)
					{
						obj2 = 12;
					}
					continue;
				case 31:
					if (obj == null)
					{
						goto IL_0243;
					}
					obj2 = 22;
					continue;
				case 6:
					if ((nint)obj != 65)
					{
						obj = 24;
						break;
					}
					goto case 12;
				case 22:
				case 43:
					obj = (object)/*Error near IL_0570: Stack underflow*/;
					obj2 = 37;
					continue;
				case 4:
					obj = obj;
					if (40 == 0)
					{
						obj2 = 32;
					}
					continue;
				case 51:
					if ((nint)obj != 73)
					{
						if (32 == 0)
						{
							obj2 = 24;
						}
						continue;
					}
					goto case 11;
				case 27:
					return;
				case 35:
					obj = (object)/*Error near IL_05bb: Stack underflow*/;
					if (34 != 0)
					{
						obj2 = 22;
					}
					continue;
				case 8:
					goto IL_05e1;
				case 45:
					return;
					IL_028d:
					obj = 0;
					_ = 51;
					continue;
					IL_05e1:
					if (obj == null)
					{
						goto IL_0243;
					}
					obj2 = 46;
					continue;
					IL_0243:
					_ = null;
					_ = 7;
					continue;
					IL_03fc:
					obj = 0;
					_ = 6;
					continue;
					IL_0355:
					obj = 0;
					_ = 3;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00攀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778199, new IntPtr(2737336153292L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00昀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_011e: Expected I4, but got Obj
		//IL_01c2: Expected Obj, but got I4
		//IL_051a: Expected Obj, but got I4
		//IL_01af: Expected Obj, but got I4
		//IL_0593: Expected Obj, but got I4
		//IL_0465: Expected Obj, but got I4
		//IL_033c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04fd->IL0019: Incompatible stack heights: 3 vs 1
		//IL_03a8->IL0019: Incompatible stack heights: 3 vs 1
		//IL_04a7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05d4->IL0019: Incompatible stack heights: 0 vs 1
		//IL_02be->IL0019: Incompatible stack heights: 0 vs 1
		//IL_035c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01c7->IL0015: Incompatible stack heights: 2 vs 0
		//IL_036b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0306->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0454->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04e3->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0130->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0265->IL046a: Incompatible stack heights: 1 vs 0
		//IL_05ee->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02f6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0420->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02e9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03f3->IL0019: Incompatible stack heights: 0 vs 1
		//IL_043c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_05fb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05c3->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0290->IL0019: Incompatible stack types: I4 vs Obj
		//IL_019e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05df->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02a4->IL0019: Incompatible stack heights: 0 vs 1
		//IL_040f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02c9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0615->IL0019: Incompatible stack heights: 0 vs 1
		//IL_03b9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_037d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0311->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0171->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0571->IL0019: Incompatible stack heights: 2 vs 1
		//IL_04ee->IL0019: Incompatible stack types: I4 vs Obj
		//IL_026f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0550->IL0019: Incompatible stack heights: 0 vs 1
		//IL_042b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0281->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03fe->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0447->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0251->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0582->IL0019: Incompatible stack types: I4 vs Obj
		//IL_034d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02af->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0620->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0637->IL0019: Incompatible stack types: I4 vs Obj
		//IL_055b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_025c->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 33;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				case 39:
					obj = (object)/*Error near IL_0126: Stack underflow*/;
					obj2 = 48;
					continue;
				case 35:
					if (obj != null)
					{
						obj2 = 54;
						continue;
					}
					goto case 31;
				case 8:
					if (obj == null)
					{
						obj2 = 41;
						continue;
					}
					goto default;
				case 23:
					if (obj != null)
					{
						obj = 14;
						break;
					}
					goto case 19;
				case 16:
				case 27:
					obj = 4;
					break;
				case 58:
					if (obj == null)
					{
						if (23 == 0)
						{
							obj2 = 23;
						}
						continue;
					}
					goto case 39;
				case 42:
					if (null != null)
					{
						_ = 3;
						continue;
					}
					return;
				case 51:
					if (obj != null)
					{
						obj2 = 18;
						continue;
					}
					goto case 58;
				case 21:
					return;
				case 7:
					obj = P_1;
					obj2 = 35;
					continue;
				case 19:
					if (obj == null)
					{
						if (5 == 0)
						{
							obj2 = 13;
						}
						continue;
					}
					goto case 47;
				case 13:
				case 24:
					obj = null;
					if (15 != 0)
					{
						obj2 = 63;
					}
					continue;
				case 14:
				case 50:
					obj = (object)/*Error near IL_02df: Stack underflow*/;
					obj2 = 26;
					continue;
				case 47:
					obj = (object)/*Error near IL_02ec: Stack underflow*/;
					obj2 = 62;
					continue;
				case 32:
					obj = P_1;
					if (17 == 0)
					{
						obj2 = 30;
					}
					continue;
				default:
					obj = P_1;
					obj2 = 59;
					continue;
				case 61:
					if (obj != null)
					{
						obj2 = 16;
						continue;
					}
					goto case 25;
				case 25:
					obj = obj;
					obj2 = 29;
					continue;
				case 30:
					obj = obj;
					obj2 = 61;
					continue;
				case 31:
					if (obj == null)
					{
						obj2 = 55;
						continue;
					}
					goto case 60;
				case 5:
					_ = 28;
					continue;
				case 29:
					if (obj != null)
					{
						obj2 = 2;
						continue;
					}
					goto case 44;
				case 52:
				case 56:
					obj = (object)/*Error near IL_03e7: Stack underflow*/;
					if (3 != 0)
					{
						obj2 = 10;
					}
					continue;
				case 20:
					if (obj == null)
					{
						obj2 = 15;
						continue;
					}
					goto case 49;
				case 49:
					if (6 == 0)
					{
						_ = 17;
					}
					continue;
				case 2:
				case 53:
					if (11 == 0)
					{
						_ = 2;
					}
					continue;
				case 33:
					obj = (object)/*Error near IL_044a: Stack underflow*/;
					obj2 = 32;
					continue;
				case 55:
					if (obj != null)
					{
						obj = 56;
						break;
					}
					goto case 51;
				case 6:
					return;
				case 9:
				case 18:
					obj = (object)/*Error near IL_049d: Stack underflow*/;
					obj2 = 22;
					continue;
				case 38:
				case 54:
					obj = (object)/*Error near IL_04d7: Stack underflow*/;
					if (12 != 0)
					{
						obj2 = 34;
					}
					continue;
				case 3:
					_ = 6;
					continue;
				case 36:
				case 46:
					obj = P_1;
					obj = 20;
					break;
				case 45:
					if (obj != null)
					{
						if (3 == 0)
						{
							obj2 = 46;
						}
						continue;
					}
					goto case 12;
				case 1:
					return;
				case 37:
					obj = obj;
					_ = 42;
					continue;
				case 59:
					if (obj != null)
					{
						obj2 = 5;
						continue;
					}
					goto case 4;
				case 43:
					if (obj == null)
					{
						return;
					}
					obj = 37;
					break;
				case 10:
				case 22:
				case 26:
				case 34:
				case 48:
				case 57:
				case 62:
				case 63:
					_ = 43;
					continue;
				case 12:
					obj = obj;
					if (6 == 0)
					{
						obj2 = 8;
					}
					continue;
				case 44:
					obj = obj;
					obj2 = 45;
					continue;
				case 60:
					obj = (object)/*Error near IL_05f1: Stack underflow*/;
					obj2 = 57;
					continue;
				case 4:
				case 11:
				case 15:
				case 17:
				case 28:
				case 41:
					obj3 = this;
					if (obj3 != null)
					{
						goto IL_0627;
					}
					if (40 != 0)
					{
						obj2 = 22;
					}
					continue;
				case 40:
					{
						obj3 = null;
						goto IL_0627;
					}
					IL_0627:
					if (obj3 == null)
					{
						return;
					}
					obj2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00最(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778196, new IntPtr(2737336180332L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00栀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778197, new IntPtr(2737336148092L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00椀(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0081->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0072->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005b->IL008c: Incompatible stack heights: 1 vs 0
		//IL_0051->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0065->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
			case 1:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 4:
				if (P_0 == 0)
				{
					_ = 3;
					break;
				}
				return;
			case 3:
				_ = 2;
				break;
			case 2:
				if (1 == 0)
				{
					_ = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00欀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_006e: Expected I4, but got Obj
		//IL_01f4: Expected Obj, but got I4
		//IL_01c9->IL0019: Incompatible stack heights: 4 vs 1
		//IL_00d7->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0131->IL0019: Incompatible stack heights: 0 vs 1
		//IL_017b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00bb->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0221->IL0019: Incompatible stack heights: 4 vs 1
		//IL_01d4->IL0019: Incompatible stack heights: 4 vs 1
		//IL_00ff->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0150->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_013c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0087->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0208->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01a6->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0110->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0190->IL0019: Incompatible stack types: I4 vs Obj
		//IL_022c->IL0019: Incompatible stack heights: 4 vs 1
		//IL_01b1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0099->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 19;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 14:
					if (obj == null)
					{
						obj2 = 9;
						continue;
					}
					goto case 4;
				case 6:
					return;
				case 3:
					return;
				default:
					if (obj != null)
					{
						if (3 == 0)
						{
							obj2 = 12;
						}
						continue;
					}
					return;
				case 12:
					obj = obj;
					if (1 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 7:
					obj2 = this;
					if (6 == 0)
					{
						obj2 = 6;
					}
					continue;
				case 16:
					if (obj == null)
					{
						obj2 = 3;
						continue;
					}
					goto case 13;
				case 13:
					obj = obj;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 9:
					if (obj == null)
					{
						obj2 = 2;
						continue;
					}
					goto case 4;
				case 5:
					return;
				case 19:
					obj = P_1;
					obj2 = 18;
					continue;
				case 10:
					return;
				case 1:
					if (obj == null)
					{
						if (P_1 != null)
						{
							obj2 = 14;
							continue;
						}
						break;
					}
					obj2 = 7;
					continue;
				case 15:
					if (obj == null)
					{
						if (7 == 0)
						{
							obj2 = 11;
						}
					}
					else
					{
						obj = this;
						obj2 = 16;
					}
					continue;
				case 4:
					_ = 1;
					if (8 != 0)
					{
						_ = 7;
					}
					continue;
				case 17:
					return;
				case 18:
					if (obj == null)
					{
						goto end_IL_0019;
					}
					goto case 15;
				case 11:
					return;
				case 8:
					return;
				case 2:
					break;
				}
				_ = 2;
				if (5 == 0)
				{
					_ = 3;
				}
				continue;
				end_IL_0019:
				break;
			}
			obj = 17;
		}
	}
}
