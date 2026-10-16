using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mass.Application.Models;
using Mass.Domain.Desktop.Interfaces;
using WinRT;
using WinRT.Mass_WinUIVtableClasses;

namespace Mass.WinUI.Models;

[WinRTExposedType(typeof(Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
public class DesktopGameCharacterModel : ObservableObject, IDisposable
{
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? selectCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? selectUserCommand;

	internal static DesktopGameCharacterModel ReflectExpandableList;

	private GameInstance? GameInstance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (GameInstance?)_FF00_FF00_FF00_FF00騀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00대(value);
		}
	}

	private IDesktopGameCharacter Character
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (IDesktopGameCharacter)_FF00_FF00_FF00_FF00_AB00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00鴀(value);
		}
	}

	private DesktopGameModel Game
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DesktopGameModel)_FF00_FF00_FF00_FF00ꌀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00鸀(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string CharacterName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00꤀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_A700(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? Content
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string?)_FF00_FF00_FF00_FF00가();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00관(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public DateTimeOffset CreateAt
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00됀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00뤀(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	public bool IsSelected
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00꼀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00頀(value ? ((byte)1) : ((byte)0));
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand SelectCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IRelayCommand)_FF00_FF00_FF00_FF00똀();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand SelectUserCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IRelayCommand)_FF00_FF00_FF00_FF00ꐀ();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DesktopGameCharacterModel(DesktopGameModel game, IDesktopGameCharacter character)
	{
		//IL_008e: Expected I4, but got Obj
		//IL_0109: Expected Obj, but got I4
		//IL_00f8: Expected Obj, but got I4
		//IL_0028->IL0031: Incompatible stack types: I4 vs Obj
		//IL_0220->IL0031: Incompatible stack heights: 4 vs 2
		//IL_025c->IL0031: Incompatible stack heights: 1 vs 2
		//IL_0230->IL0031: Incompatible stack types: I4 vs Obj
		//IL_01c6->IL0031: Incompatible stack heights: 4 vs 2
		//IL_0276->IL0031: Incompatible stack types: I4 vs Obj
		//IL_014e->IL0031: Incompatible stack heights: 3 vs 2
		//IL_00e0->IL0031: Incompatible stack heights: 1 vs 2
		//IL_0241->IL0031: Incompatible stack heights: 1 vs 2
		//IL_018f->IL0031: Incompatible stack heights: 4 vs 2
		//IL_00a6->IL0031: Incompatible stack heights: 3 vs 2
		//IL_016a->IL0031: Incompatible stack types: I4 vs Obj
		//IL_0267->IL0031: Incompatible stack heights: 1 vs 2
		//IL_0213->IL0031: Incompatible stack heights: 4 vs 2
		//IL_013d->IL0031: Incompatible stack types: I4 vs Obj
		//IL_0159->IL0031: Incompatible stack heights: 3 vs 2
		//IL_00eb->IL0031: Incompatible stack heights: 1 vs 2
		//IL_0031->IL0031: Incompatible stack heights: 4 vs 2
		//IL_0121->IL0031: Incompatible stack heights: 1 vs 2
		//IL_024c->IL0031: Incompatible stack heights: 1 vs 2
		//IL_01f7->IL0031: Incompatible stack heights: 3 vs 2
		//IL_00c4->IL0031: Incompatible stack heights: 1 vs 2
		//IL_019a->IL0031: Incompatible stack heights: 4 vs 2
		//IL_01ad->IL0031: Incompatible stack heights: 3 vs 2
		//IL_01d9->IL0031: Incompatible stack heights: 1 vs 2
		//IL_00b1->IL0031: Incompatible stack heights: 3 vs 2
		//IL_012c->IL0031: Incompatible stack heights: 1 vs 2
		//IL_0202->IL0031: Incompatible stack heights: 3 vs 2
		//IL_00cf->IL0031: Incompatible stack heights: 1 vs 2
		//IL_01b8->IL0031: Incompatible stack heights: 3 vs 2
		//IL_01e4->IL0031: Incompatible stack heights: 1 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		DesktopGameCharacterModel desktopGameCharacterModel = this;
		if (false)
		{
			desktopGameCharacterModel = (DesktopGameCharacterModel)0;
		}
		object obj = default;
		while (true)
		{
			DesktopGameCharacterModel desktopGameCharacterModel2;
			object obj2;
			switch ((int)desktopGameCharacterModel)
			{
			case 16:
				return;
			case 1:
				if (11 == 0)
				{
					_ = 8;
				}
				break;
			case 17:
				if (obj == null)
				{
					if (12 == 0)
					{
						_ = 2;
					}
				}
				else if (7 != 0)
				{
					_ = 0;
				}
				break;
			case 12:
				obj = obj;
				if (4 != 0)
				{
					_ = 0;
				}
				break;
			case 20:
				desktopGameCharacterModel2 = this;
				obj2 = this;
				obj = 3;
				break;
			case 13:
				desktopGameCharacterModel2 = this;
				obj2 = character;
				obj = 6;
				break;
			case 14:
				if (obj != null)
				{
					if (0 == 0)
					{
						_ = 1;
					}
					break;
				}
				goto case 5;
			case 4:
				if (obj == null)
				{
					desktopGameCharacterModel = (DesktopGameCharacterModel)8;
				}
				else
				{
					_ = 21;
				}
				break;
			case 10:
				if (13 == 0)
				{
					_ = 18;
				}
				break;
			case 2:
				if (this == null)
				{
					return;
				}
				desktopGameCharacterModel = (DesktopGameCharacterModel)20;
				break;
			case 18:
				if (2 == 0)
				{
					_ = 2;
				}
				break;
			case 8:
				return;
			case 6:
				_ = 10;
				break;
			case 19:
				if (obj != null)
				{
					if (12 == 0)
					{
						_ = 16;
					}
				}
				else if (7 != 0)
				{
					_ = 9;
				}
				break;
			case 11:
				return;
			case 7:
				return;
			default:
				_ = 13;
				break;
			case 21:
				return;
			case 5:
				obj = obj;
				desktopGameCharacterModel = (DesktopGameCharacterModel)17;
				break;
			case 15:
				obj = obj;
				if (19 != 0)
				{
					_ = 19;
				}
				break;
			case 3:
				obj = this;
				if (1 == 0)
				{
					_ = 15;
				}
				break;
			case 9:
				obj = obj;
				desktopGameCharacterModel = (DesktopGameCharacterModel)14;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		_FF00_FF00_FF00_FF00넀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	public void Select()
	{
		_FF00_FF00_FF00_FF00ꄀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	public void SelectUser()
	{
		_FF00_FF00_FF00_FF00ꈀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RefreshContent(object instance)
	{
		_FF00_FF00_FF00_FF00븀(instance);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectHiddenRecord()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DesktopGameCharacterModel QueryState()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00需(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778934, new IntPtr(2737336198012L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00頀(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0080->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0041->IL0072: Incompatible stack heights: 1 vs 0
		//IL_008f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0072->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0058->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				obj2 = this;
				if (P_0 == 0)
				{
					if (1 == 0)
					{
						obj2 = 1;
					}
					break;
				}
				return;
			default:
				obj2 = this;
				if (4 == 0)
				{
					obj2 = 3;
				}
				break;
			case 4:
				return;
			case 1:
				_ = 3;
				break;
			case 3:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00餀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778935, new IntPtr(2737336208412L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FF00_FF00騀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00鬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778932, new IntPtr(2737336198012L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00鰀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778933, new IntPtr(2737336198012L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00鴀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
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
			case 0:
				return;
			case 1:
				if (false)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00鸀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0045->IL0019: Incompatible stack heights: 2 vs 1
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00鼀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778930, new IntPtr(2737336198012L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00ꀀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778931, new IntPtr(2737336198012L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00ꄀ()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0045->IL0019: Incompatible stack heights: 2 vs 1
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
				_ = 1;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00ꈀ()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
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
			case 0:
				return;
			case 1:
				_ = 1;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FF00_FF00ꌀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00ꐀ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18490, 1790778928, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778928, new IntPtr(2737336198012L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00ꔀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778929, new IntPtr(2737336199052L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00ꘀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778942, new IntPtr(2737336199052L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_A700(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0048->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0053->IL0079: Incompatible stack heights: 1 vs 0
		//IL_0086->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0095->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006a->IL0019: Incompatible stack types: I4 vs Obj
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
				_ = 5;
				break;
			case 1:
				return;
			case 5:
				return;
			case 2:
				obj2 = this;
				if (P_0 != null)
				{
					if (0 == 0)
					{
						obj2 = 1;
					}
					break;
				}
				goto case 3;
			case 3:
				_ = 4;
				break;
			case 4:
				if (false)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00ꠀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778943, new IntPtr(2737336199052L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00꤀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00ꨀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778940, new IntPtr(2737336202172L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FF00_FF00_AB00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00가()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00관(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0041->IL007f: Incompatible stack heights: 1 vs 0
		//IL_007f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_009a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0058->IL0019: Incompatible stack types: I4 vs Obj
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
			case 2:
				obj2 = this;
				if (P_0 == null)
				{
					if (0 == 0)
					{
						obj2 = 1;
					}
					break;
				}
				return;
			case 3:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 4:
				_ = 3;
				break;
			case 0:
				return;
			case 1:
				obj2 = this;
				if (4 == 0)
				{
					obj2 = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00글()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778941, new IntPtr(2737336209452L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00꼀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00뀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778938, new IntPtr(2737336199052L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00넀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_007a: Expected I4, but got Obj
		//IL_00d7: Expected Obj, but got I4
		//IL_019a: Expected Obj, but got I4
		//IL_00ab->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0142->IL0019: Incompatible stack types: I4 vs Obj
		//IL_015d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0117->IL0019: Incompatible stack types: I4 vs Obj
		//IL_018b->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0108->IL0019: Incompatible stack heights: 3 vs 1
		//IL_019f->IL0015: Incompatible stack heights: 2 vs 0
		//IL_014e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01c2->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0223->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0210->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01d5->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0170->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00be->IL0019: Incompatible stack heights: 0 vs 1
		//IL_022e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01e0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_017b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c9->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 10;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 3:
					obj = this;
					obj2 = 4;
					continue;
				case 16:
					if (obj != null)
					{
						if (true)
						{
							obj2 = 1;
						}
						continue;
					}
					goto case 8;
				case 13:
					obj = obj;
					obj = 6;
					break;
				case 14:
				case 17:
					_ = 2;
					continue;
				case 8:
					obj = obj;
					obj2 = 7;
					continue;
				case 4:
					obj = obj;
					obj2 = 16;
					continue;
				default:
					_ = 15;
					continue;
				case 5:
					obj = obj;
					obj2 = 11;
					continue;
				case 11:
					if (obj != null)
					{
						if (11 == 0)
						{
							obj2 = 14;
						}
						continue;
					}
					goto case 13;
				case 1:
				case 12:
					_ = 18;
					continue;
				case 20:
					obj = 19;
					break;
				case 22:
					_ = 21;
					continue;
				case 10:
					if (this == null)
					{
						if (7 == 0)
						{
							obj2 = 9;
						}
						continue;
					}
					goto case 3;
				case 15:
					return;
				case 7:
					if (obj == null)
					{
						obj2 = 5;
						continue;
					}
					goto case 20;
				case 6:
					if (obj == null)
					{
						if (false)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 22;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00눀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778939, new IntPtr(2737336205292L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00대(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
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
			case 0:
				return;
			case 1:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal DateTimeOffset _FF00_FF00_FF00_FF00됀()
	{
		//IL_000a: Expected VT, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (DateTimeOffset)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe DateTimeOffset _FF00_FF00_FF00_FF00딀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778936, new IntPtr(2737336208412L), 15))(null, 0, new IntPtr(0L));
		return (DateTimeOffset)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00똀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18508, 1790778937, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778937, new IntPtr(2737336199052L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00뜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778886, new IntPtr(2737336200092L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00렀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00뤀(DateTimeOffset P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0079->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0045->IL0079: Incompatible stack heights: 1 vs 0
		//IL_0093->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ad->IL0019: Incompatible stack types: I4 vs Obj
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
				if ((int)P_0 != 0)
				{
					_ = 3;
					break;
				}
				goto case 2;
			case 1:
				return;
			case 3:
				return;
			default:
				_ = 5;
				break;
			case 2:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 5:
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00먀(DateTimeOffset P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778887, new IntPtr(2737336200092L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00묀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00밀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778884, new IntPtr(2737336200092L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00봀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778885, new IntPtr(2737336200092L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00븀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0041->IL0019: Incompatible stack heights: 4 vs 1
		//IL_004c->IL0019: Incompatible stack heights: 4 vs 1
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
				/*Error near IL_002c: Stack underflow*/;
				if (0 == 0)
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
