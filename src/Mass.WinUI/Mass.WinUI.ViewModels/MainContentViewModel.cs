using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using ABI.System;
using ABI.System.Collections;
using ABI.System.Collections.Generic;
using ABI.System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using Mass.WinUI.Mass_WinUI_XamlTypeInfo;
using Mass.WinUI.Models;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.Xaml.Interactivity;
using WinRT;
using WinRT.Mass_WinUIGenericHelpers;
using WinRT.Mass_WinUIVtableClasses;
using Windows.Foundation;
using Windows.Storage;

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
	public unsafe MainContentViewModel()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_0025: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		//IL_0046: Expected I, but got Obj
		//IL_00cd: Expected I4, but got Obj
		//IL_00cd: Expected I, but got Obj
		//IL_00d2: Expected Obj, but got I4
		//IL_0096: Expected I, but got Obj
		//IL_0096: Expected I, but got Obj
		//IL_00dc->IL006e: Incompatible stack heights: 2 vs 1
		//IL_00af->IL006e: Incompatible stack heights: 2 vs 1
		//IL_00ba->IL006e: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = _003CModule_003E.CheckAccessibleAttribute() != null;
		IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute = (int)IEnumerator_object.Init() != unchecked((nint)null);
		*((int, nint)*)(nint)/*Error near IL_0046: Stack underflow*/ = ((int)/*Error near IL_0046: Stack underflow*/, (nint)this);
		int num = 1;
		if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				((XamlUserType)/*Error near IL_009b: Stack underflow*/).BoxType<TimeSpan>((object)new IReadOnlyListMethods<INotifyPropertyChanged, nint>((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)MarshalInspectable<object>.FromManaged((object)/*Error near IL_0089: Stack underflow*/, (byte)/*Error near IL_0089: Stack underflow*/ != 0), (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(delegate*<bool>)(&IEnumerator_object.DecorateAutomatableAttribute)));
				_ = 0;
				if (IEnumerator_System_IDisposable._initialized == 0)
				{
					_ = 0;
				}
				break;
			case 2:
				return;
			default:
				((XamlUserType)IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00c0: Stack underflow*/, (INotifyPropertyChanged)/*Error near IL_00c0: Stack underflow*/, ref *(uint*)/*Error near IL_00c0: Stack underflow*/)).BoxType<double>(new IReadOnlyListMethods<INotifyPropertyChanged>((IntPtr)this, (uint)(int)this, ref *(INotifyPropertyChanged[]*)(delegate* unmanaged[Stdcall]<nint, uint, uint, nint, uint*, uint>)(&IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3)));
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
	internal unsafe byte _FF00_FF00倀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
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
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_0072: Expected Obj, but got Ref
		//IL_0079: Expected Obj, but got Ref
		//IL_00b7: Expected Obj, but got Ref
		//IL_008b: Expected Obj, but got Ref
		//IL_0090: Expected I, but got Obj
		//IL_004c: Expected Obj, but got Ref
		//IL_0083->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00c1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0060->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00af->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006b->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = -1;
				obj2 = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				_ = ref IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute;
				CastExtensions.As<InvokeCommandAction>((object)(&obj));
				_ = 4;
				break;
			case 4:
				return;
			case 2:
				IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)MarshalInspectable<object>.FromAbiArray((object)(&obj));
				obj2 = 1;
				if (IReadOnlyList_System_IDisposable._initialized != 0)
				{
					obj2 = 1;
				}
				break;
			case 1:
				IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = this;
				obj2 = 3;
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
	internal unsafe byte _FF00_FF00圀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00堀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778189, new IntPtr(2737336155372L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00夀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00娀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778186, new IntPtr(2737336161612L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00嬀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001a: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
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
	internal unsafe void _FF00_FF00帀(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0087: Expected Obj, but got I
		//IL_00ce: Expected Obj, but got I4
		//IL_00bd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ac->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00d3->IL006d: Incompatible stack heights: 2 vs 0
		//IL_0097->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00dd->IL0026: Incompatible stack heights: 3 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				/*Error near IL_0078: Stack underflow*/((object[])(object)this, IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized);
				obj2 = 0;
				if (IList_object.PatchAttribute == null)
				{
					obj2 = 0;
				}
				break;
			case 3:
				MarshalInspectable<object>.FromManaged((object)this, (byte)IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0);
				_ = 2;
				break;
			default:
				IReadOnlyList_System_IDisposable._initialized = (int)P_0;
				obj2 = 3;
				break;
			case 5:
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00c2: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00c2: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_00c2: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)/*Error near IL_00c2: Stack underflow*/);
				_ = IReadOnlyList_object._initialized;
				if (MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)P_0) != (IntPtr)0)
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
	private unsafe void _FF00_FF00愀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0075: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_0086: Expected I, but got Obj
		//IL_00c8: Expected I, but got Obj
		//IL_00d2: Expected Obj, but got VT
		//IL_00d8: Expected I4, but got Obj
		//IL_00e8: Expected Obj, but got I
		//IL_00a3: Expected I, but got Obj
		//IL_00a3: Expected I, but got Obj
		//IL_00a3: Expected I, but got Obj
		//IL_00b2: Expected Obj, but got I
		//IL_0050: Expected I, but got Obj
		//IL_0090->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00ed->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b7->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0117->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c2->IL0026: Incompatible stack heights: 2 vs 1
		//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0122->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				IEnumerator_object.Do_Abi_MoveNext_2((nint)/*Error near IL_0075: Stack underflow*/, (byte*)(nint)this);
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)new MarshalInspectable<object>((object)(delegate* unmanaged[Stdcall]<nint, uint, nint, uint*, uint>)(&IEnumerator_object.Do_Abi_GetMany_3)));
				_ = 3;
				break;
			case 5:
				return;
			case 4:
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00a3: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)P_0, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)this, new IEnumeratorMethods<object>((IntPtr)(nint)(delegate*<void>)(&IEnumerator_object._002Ecctor)) ? ((delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)1) : ((delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)null));
				_ = 0;
				if (IReadOnlyList_object.ReflectLogicalAttribute == null)
				{
					_ = 0;
				}
				break;
			case 3:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)(int)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_00c8: Stack underflow*/, (uint)/*Error near IL_00c8: Stack underflow*/, (nint*)(nint)this), (uint)(int)MarshalInterface<INotifyPropertyChanged>.FromAbiArray((object)typeof(Mass_WinUI_Pages_MobileWinRTTypeDetails).TypeHandle), ref *(INotifyPropertyChanged[]*)null);
				obj2 = 0;
				if (IEnumerable_object.ReflectSetAttribute != null)
				{
					obj2 = 5;
				}
				break;
			case 2:
				if (GlobalVtableLookup.CreateAttribute == null)
				{
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
					obj2 = 4;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj2 = 3;
					}
				}
				else
				{
					obj2 = 1;
					if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute != null)
					{
						obj2 = 1;
					}
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00搀(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0113: Expected I4, but got Obj
		//IL_04c7: Expected Obj, but got I4
		//IL_06cc: Expected Obj, but got I
		//IL_036f: Expected Obj, but got I4
		//IL_036f: Expected I4, but got Obj
		//IL_0345: Expected I, but got Obj
		//IL_02bd: Expected I, but got Obj
		//IL_0315: Expected I, but got Obj
		//IL_05a2: Expected Obj, but got I4
		//IL_0506: Expected I4, but got VT
		//IL_04db: Expected I, but got VT
		//IL_0295: Expected I, but got VT
		//IL_065e: Expected I, but got Obj
		//IL_01de: Expected I, but got Obj
		//IL_01de: Expected I4, but got Obj
		//IL_0551: Expected I, but got Obj
		//IL_0553: Expected Obj, but got I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected I4, but got Unknown
		//IL_06b9: Expected Obj, but got VT
		//IL_03ee: Expected I4, but got Obj
		//IL_03f0: Expected Obj, but got I4
		//IL_05ee: Expected I, but got VT
		//IL_0684: Expected Obj, but got I4
		//IL_015c: Expected Obj, but got I
		//IL_03ad: Expected I, but got Obj
		//IL_03b9: Expected I, but got Obj
		//IL_044d: Expected I, but got VT
		//IL_0458: Expected Obj, but got I4
		//IL_0720: Expected Obj, but got I
		//IL_04b1: Expected I, but got Obj
		//IL_013f: Expected Obj, but got I4
		//IL_0781: Expected Obj, but got VT
		//IL_0791: Unknown result type (might be due to invalid IL or missing references)
		//IL_0798: Expected Obj, but got Unknown
		//IL_07b9: Expected Obj, but got I4
		//IL_04d1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06e0->IL0026: Incompatible stack heights: 2 vs 1
		//IL_075f->IL05c0: Incompatible stack heights: 2 vs 0
		//IL_034a->IL05e4: Incompatible stack heights: 1 vs 0
		//IL_05a7->IL04d1: Incompatible stack heights: 1 vs 0
		//IL_051c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04f1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02ab->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0668->IL024a: Incompatible stack heights: 1 vs 0
		//IL_0567->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06c3->IL0026: Incompatible stack heights: 2 vs 1
		//IL_028b->IL0026: Incompatible stack heights: 6 vs 1
		//IL_03fa->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0604->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02fa->IL0026: Incompatible stack heights: 2 vs 1
		//IL_017f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06eb->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0769->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0388->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0354->IL0026: Incompatible stack heights: 2 vs 1
		//IL_02db->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0161->IL0026: Incompatible stack types: I4 vs Obj
		//IL_032e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05b1->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0527->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04fc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0237->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02b6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01d6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0672->IL0026: Incompatible stack heights: 2 vs 1
		//IL_049e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01b3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0734->IL0026: Incompatible stack heights: 2 vs 1
		//IL_04bd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01f7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0572->IL0026: Incompatible stack types: I4 vs Obj
		//IL_019f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0708->IL0026: Incompatible stack types: I4 vs Obj
		//IL_060f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0393->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02e6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_016c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03c8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0339->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04a9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_073f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0202->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0713->IL0026: Incompatible stack types: I4 vs Obj
		//IL_07be->IL0022: Incompatible stack heights: 7 vs 0
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
						goto IL_026c;
					case 4:
						goto IL_02e6;
					case 0:
						goto IL_03e6;
					case 3:
						goto IL_04bd;
					case 2:
						goto IL_074e;
					}
					obj = 15;
					break;
				case 13:
					if ((nint)obj != 72)
					{
						obj2 = 41;
						if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute != null)
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
					goto IL_026c;
				case 33:
					if (IEnumerator_object.Init() != 0)
					{
						obj2 = 35;
						continue;
					}
					return;
				case 28:
				case 46:
					if (IEnumerator_object.Do_Abi_MoveNext_2((nint)/*Error near IL_01c7: Stack underflow*/, (byte*)/*Error near IL_01c7: Stack underflow*/) == 0)
					{
						obj2 = 10;
						continue;
					}
					obj = IEnumeratorMethods<INotifyPropertyChanged>.Abi_get_Current_0((IntPtr)typeof(MainWindow._003C_003Ec__DisplayClass0_0).TypeHandle);
					obj = 21;
					break;
				case 38:
					*((int, nint)*)(nint)/*Error near IL_01de: Stack underflow*/ = ((int)obj, unchecked((nint)null));
					if ((int)/*Error near IL_01e3: Stack underflow*/ != 0)
					{
						obj2 = 52;
						if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
						{
							obj2 = 20;
						}
					}
					else
					{
						obj = MarshalInterface<IDisposable>.FromAbi((IntPtr)obj);
						obj2 = 49;
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
					goto IL_026c;
				case 25:
				case 41:
					obj = MarshalInterface<INotifyPropertyChanged>.FromAbi((IntPtr)typeof(Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails).TypeHandle);
					obj2 = 26;
					if (IEnumerable_System_IDisposable._initialized == 0)
					{
						obj2 = 16;
					}
					continue;
				case 12:
					MarshalInterface<INotifyPropertyChanged>.CopyManagedArray((INotifyPropertyChanged[])/*Error near IL_02c2: Stack underflow*/, (IntPtr)(int)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1((nint)/*Error near IL_02bd: Stack underflow*/, (uint*)(nint)obj));
					if ((int)/*Error near IL_02c7: Stack underflow*/ == 0)
					{
						goto IL_026c;
					}
					obj2 = 33;
					if (GlobalVtableLookup.CreateAttribute == null)
					{
						obj2 = 36;
					}
					continue;
				case 57:
					goto IL_02e6;
				case 17:
					if (!IListMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_0315: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_0315: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)/*Error near IL_0315: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_0315: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_0315: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_0315: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int>)/*Error near IL_0315: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, int>)/*Error near IL_0315: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)/*Error near IL_0315: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)/*Error near IL_0315: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)obj, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, int>)(int)IEnumerable_System_ComponentModel_INotifyPropertyChanged.Init()))
					{
						obj2 = 2;
						if (Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute != null)
						{
							obj2 = 29;
						}
						continue;
					}
					goto case 33;
				case 11:
					if (MarshalInspectable<object>.FromAbi((IntPtr)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectMonoAttribute()) == null)
					{
						_ = 53;
						continue;
					}
					goto case 55;
				case 9:
					IListMethods<object>.Abi_SetAt_4((IntPtr)/*Error near IL_036f: Stack underflow*/, (uint)(int)obj, (object)IList_object.Init());
					if ((int)/*Error near IL_0374: Stack underflow*/ != 0)
					{
						obj2 = 21;
						if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute == null)
						{
							obj2 = 41;
						}
						continue;
					}
					goto IL_026c;
				case 7:
					return;
				case 14:
				case 21:
				case 26:
				case 34:
				case 37:
				case 42:
				case 50:
					IListMethods<object>.Abi_RemoveAtEnd_8((IntPtr)(int)IList_object.Do_Abi_SetAt_4((nint)/*Error near IL_03ad: Stack underflow*/, (uint)/*Error near IL_03ad: Stack underflow*/, (nint)this));
					IListMethods<object>.Abi_Clear_9((IntPtr)obj);
					if ((int)/*Error near IL_03be: Stack underflow*/ != 0)
					{
						obj2 = 45;
						continue;
					}
					GlobalVtableLookup.InitializeGlobalVtableLookup();
					obj = obj;
					_ = IEnumerableMethods<INotifyPropertyChanged>.AbiToProjectionVftablePtr;
					obj = IEnumeratorMethods<INotifyPropertyChanged>.IID;
					GlobalVtableLookup.DecorateDetachedAttribute();
					if ((nint)GlobalVtableLookup.DecorateDetailedAttribute() == 1)
					{
						obj = (nint)new IDisposableMethods();
					}
					else
					{
						obj = new IEnumeratorMethods<object>();
					}
					_ = IEnumeratorMethods<object>.AbiToProjectionVftablePtr;
					obj = 30;
					break;
				case 54:
					goto IL_03e6;
				case 10:
					return;
				case 32:
					if ((nint)obj != 83)
					{
						obj2 = 0;
						if (__KnownINotifyPropertyChangingArgs.IsMyself == null)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 31;
				case 52:
					return;
				case 1:
					goto IL_04bd;
				case 23:
					MarshalInterface<IDisposable>.CopyManagedArray((IDisposable[])/*Error near IL_04db: Stack underflow*/, (IntPtr)typeof(XamlSystemBaseType).TypeHandle);
					obj = (object)/*Error near IL_04dd: Stack underflow*/;
					obj2 = 14;
					if (__KnownINotifyPropertyChangingArgs.CanProxy != null)
					{
						obj2 = 2;
					}
					continue;
				case 20:
				case 36:
					obj = IReadOnlyListMethods<object>.Abi_GetAt_0((IntPtr)/*Error near IL_0506: Stack underflow*/, (uint)(int)typeof(AddToDictionary).TypeHandle);
					obj2 = 0;
					if (__KnownINotifyPropertyChangingArgs.Author != null)
					{
						obj2 = 50;
					}
					continue;
				case 39:
					obj = IEnumeratorMethods<IDisposable>.Abi_MoveNext_2((IntPtr)P_1);
					obj2 = 38;
					if (__KnownINotifyPropertyChangingArgs.BackgroundImageUrl == null)
					{
						obj2 = 0;
					}
					continue;
				case 19:
					if (MarshalInterface<IEnumerator<IDisposable>>.FromManaged((IEnumerator<IDisposable>)IReadOnlyList_object.Init()) == (IntPtr)0)
					{
						_ = 16;
						continue;
					}
					goto case 23;
				case 55:
					((Func<Type, string>)/*Error near IL_05ee: Stack underflow*/)._002Ector((object)/*Error near IL_05ee: Stack underflow*/, (nint)typeof(AccountViewModel._003CLoginByHistory_003Ed__25).TypeHandle);
					obj = (object)/*Error near IL_05f0: Stack underflow*/;
					obj2 = 42;
					if (__KnownINotifyPropertyChangingArgs.OperationText != null)
					{
						obj2 = 12;
					}
					continue;
				case 31:
					IEnumerator_System_IDisposable.Do_Abi_get_Current_0((nint)/*Error near IL_065e: Stack underflow*/, (nint*)(nint)obj);
					if (IReadOnlyListMethods<object>.AbiToProjectionVftablePtr == (IntPtr)0)
					{
						goto IL_026c;
					}
					_ = 22;
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
					_ = typeof(ImportAccountViewModel._003C_003Ec__DisplayClass47_0).TypeHandle;
					obj = IListMethods.IID;
					_ = 37;
					continue;
				case 4:
					obj = (nint)IListMethods.AbiToProjectionVftablePtr;
					_ = 40;
					if (__KnownINotifyPropertyChangingArgs.DisplayName == null)
					{
						_ = 32;
					}
					continue;
				case 51:
					if ((nint)obj != 73)
					{
						obj2 = 32;
						if (__KnownINotifyPropertyChangingArgs.TotalCoins == null)
						{
							obj2 = 24;
						}
						continue;
					}
					goto case 11;
				case 27:
					return;
				case 35:
					_ = typeof(ChatViewModel._003CSend_003Ed__9).TypeHandle;
					obj = (nint)INotifyPropertyChangedMethods.AbiToProjectionVftablePtr;
					_ = 34;
					if (__KnownINotifyPropertyChangingArgs.Quantity != null)
					{
						_ = 22;
					}
					continue;
				case 8:
					goto IL_074e;
				case 45:
					return;
					IL_02e6:
					obj = IEnumerableMethods<INotifyPropertyChanged>.Abi_First_0((IntPtr)0);
					_ = 51;
					continue;
					IL_074e:
					IEnumerable_object.SaveAttribute();
					if (IReadOnlyListMethods<INotifyPropertyChanged>.AbiToProjectionVftablePtr == (IntPtr)0)
					{
						goto IL_026c;
					}
					_ = 46;
					continue;
					IL_026c:
					_ = IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute;
					IEnumerator_object.DecorateAutomatableAttribute();
					IEnumerator_object.LoadAttribute();
					_ = null;
					_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Initialized;
					_ = 7;
					continue;
					IL_04bd:
					obj = IReadOnlyListMethods<IDisposable>.Abi_IndexOf_2((IntPtr)/*Error near IL_04c5: Stack underflow*/, (IDisposable)obj, ref *(uint*)null);
					obj2 = 6;
					continue;
					IL_03e6:
					obj = IListMethods<object>.Abi_GetMany_10((IntPtr)/*Error near IL_03ee: Stack underflow*/, (uint)(int)obj, ref *(object[]*)null);
					obj2 = 3;
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
	private unsafe void _FF00_FF00昀(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_012b: Expected I4, but got Obj
		//IL_03c9: Expected Obj, but got I4
		//IL_044f: Expected I, but got Obj
		//IL_01e5: Expected I4, but got Obj
		//IL_01f3: Expected Obj, but got I4
		//IL_061b: Expected I, but got Obj
		//IL_0620: Expected Obj, but got I4
		//IL_062b: Expected Obj, but got I4
		//IL_05d0: Expected Obj, but got I4
		//IL_02b9: Expected I, but got Obj
		//IL_0369: Expected Obj, but got I4
		//IL_04dd: Expected I4, but got Obj
		//IL_0358: Expected Obj, but got I4
		//IL_04a4: Expected Obj, but got I4
		//IL_0504: Expected I, but got Obj
		//IL_0509: Expected I, but got Obj
		//IL_02e7: Expected Obj, but got I
		//IL_01d8: Expected Obj, but got I4
		//IL_0680: Expected I, but got Obj
		//IL_0699: Expected Obj, but got VT
		//IL_06c9: Expected Obj, but got I4
		//IL_054e: Expected Obj, but got I4
		//IL_02a1: Expected Obj, but got I
		//IL_03d5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0606->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0459->IL0026: Incompatible stack heights: 3 vs 1
		//IL_059c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0722->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0333->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03f9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01f8->IL0022: Incompatible stack heights: 1 vs 0
		//IL_040c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_038f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0539->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05e4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0141->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02be->IL0553: Incompatible stack heights: 1 vs 0
		//IL_0740->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0373->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04f1->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0362->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04b8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_051d->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0751->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0705->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02f1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01c3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_072d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0311->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04d4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_033e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0777->IL0026: Incompatible stack types: I4 vs Obj
		//IL_046a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0422->IL0026: Incompatible stack types: I4 vs Obj
		//IL_039a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_018e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06a3->IL0026: Incompatible stack heights: 4 vs 1
		//IL_05ef->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02c8->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0669->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04fc->IL0026: Incompatible stack heights: 2 vs 1
		//IL_02de->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04c3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0528->IL0026: Incompatible stack heights: 2 vs 1
		//IL_02a6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06b4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03e6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_031c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0782->IL0026: Incompatible stack types: I4 vs Obj
		//IL_078d->IL078d: Incompatible stack heights: 2 vs 1
		//IL_07a1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0674->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02b1->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 33;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 39:
					obj = _003CModule_003E.CheckAccessibleAttribute();
					obj2 = 48;
					continue;
				case 35:
					if (obj is IReadOnlyList_System_IDisposable)
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
					if (obj is IEnumerable_System_IDisposable)
					{
						obj = 14;
						break;
					}
					goto case 19;
				case 16:
				case 27:
					IEnumeratorMethods<object>.Abi_get_HasCurrent_1(MarshalInspectable<object>.FromManaged(obj, (byte)(int)P_1 != 0));
					obj = 4;
					break;
				case 58:
					if (!(obj is Mass_WinUI_AppWinRTTypeDetails))
					{
						obj2 = 23;
						if (IEnumerable_object.ReflectSetAttribute == null)
						{
							obj2 = 23;
						}
						continue;
					}
					goto case 39;
				case 42:
					if (IEnumerableMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)null))
					{
						_ = 3;
						continue;
					}
					return;
				case 51:
					if (obj is Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails)
					{
						obj2 = 18;
						continue;
					}
					goto case 58;
				case 21:
					return;
				case 7:
					obj = (nint)MarshalInterface<IEnumerator<INotifyPropertyChanged>>.FromManaged((IEnumerator<INotifyPropertyChanged>)P_1);
					obj2 = 35;
					continue;
				case 19:
					if (!(obj is _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0))
					{
						obj2 = 5;
						if (Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute == null)
						{
							obj2 = 13;
						}
						continue;
					}
					goto case 47;
				case 13:
				case 24:
					obj = null;
					obj2 = 15;
					if (Mass_WinUI_AppWinRTTypeDetails.CheckHiddenAttribute != null)
					{
						obj2 = 63;
					}
					continue;
				case 14:
				case 50:
					obj = IList_object.Init();
					obj2 = 26;
					continue;
				case 47:
					obj = IList_object.Do_Abi_GetAt_0((nint)/*Error near IL_0367: Stack underflow*/, (uint)/*Error near IL_0367: Stack underflow*/, (nint*)/*Error near IL_0367: Stack underflow*/);
					obj2 = 62;
					continue;
				case 32:
					IListMethods<object>.Abi_InsertAt_5((IntPtr)/*Error near IL_0379: Stack underflow*/, (uint)/*Error near IL_0379: Stack underflow*/, P_1);
					obj = (object)/*Error near IL_037b: Stack underflow*/;
					obj2 = 17;
					if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute == null)
					{
						obj2 = 30;
					}
					continue;
				default:
					obj = IListMethods<object>.Abi_GetMany_10((IntPtr)/*Error near IL_03c4: Stack underflow*/, (uint)/*Error near IL_03c4: Stack underflow*/, ref *(object[]*)P_1) as MainContent.IMainContent_BindingsScopeConnector;
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
					obj = obj as MainContent.XamlBindingSetters;
					obj2 = 29;
					continue;
				case 30:
					obj = obj as MainContent.MainContent_obj1_Bindings;
					obj2 = 61;
					continue;
				case 31:
					if (!(obj is MainWindow))
					{
						obj2 = 55;
						continue;
					}
					goto case 60;
				case 5:
					IEnumeratorMethods<INotifyPropertyChanged>.Abi_get_HasCurrent_1((IntPtr)obj);
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
					obj = IEnumerator_System_ComponentModel_INotifyPropertyChanged.Init();
					obj2 = 3;
					if (__KnownINotifyPropertyChangingArgs.CharacterName != null)
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
					IReadOnlyListMethods<IDisposable>.Abi_GetMany_3((IntPtr)/*Error near IL_04dd: Stack underflow*/, (uint)(int)obj, ref *(IDisposable[]*)obj);
					_ = 6;
					if (__KnownINotifyPropertyChangingArgs.IsSkeleton == null)
					{
						_ = 17;
					}
					continue;
				case 2:
				case 53:
					IReadOnlyListMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_0509: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_0509: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)obj, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(int)IReadOnlyListMethods<IDisposable>.Abi_get_Size_1((IntPtr)P_1));
					_ = 11;
					if (__KnownINotifyPropertyChangingArgs.MaxPlayers == null)
					{
						_ = 2;
					}
					continue;
				case 33:
					obj = new IReadOnlyList_System_IDisposable((nint)/*Error near IL_052d: Stack underflow*/, (uint)/*Error near IL_052d: Stack underflow*/, (nint*)/*Error near IL_052d: Stack underflow*/);
					obj2 = 32;
					continue;
				case 55:
					if (obj is Getter)
					{
						obj = 56;
						break;
					}
					goto case 51;
				case 6:
					return;
				case 9:
				case 18:
					IReadOnlyList_System_IDisposable._002Ecctor();
					obj = (object)/*Error near IL_0592: Stack underflow*/;
					obj2 = 22;
					continue;
				case 38:
				case 54:
					obj = IReadOnlyList_System_IDisposable.StoreAttribute();
					obj2 = 12;
					if (__KnownINotifyPropertyChangingArgs.Summary != null)
					{
						obj2 = 34;
					}
					continue;
				case 3:
					_ = __KnownINotifyPropertyChangingArgs.PreviewImage;
					MarshalInterface<IEnumerator<IDisposable>>.FromManaged((IEnumerator<IDisposable>)obj);
					_ = 6;
					continue;
				case 36:
				case 46:
				{
					bool flag = IEnumerableMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)P_1);
					obj = ((((object)flag) is AccountViewModel._003CLoginBedrock_003Ed__86) ? ((object)flag) : null);
					obj = 20;
					break;
				}
				case 45:
					if (obj != null)
					{
						obj2 = 3;
						if (__KnownINotifyPropertyChangingArgs.State == null)
						{
							obj2 = 46;
						}
						continue;
					}
					goto case 12;
				case 1:
					return;
				case 37:
					((Func<Type, ComWrappers.ComInterfaceEntry[]>)/*Error near IL_0680: Stack underflow*/)._002Ector((object)/*Error near IL_0680: Stack underflow*/, (nint)__KnownINotifyPropertyChangingArgs.StateText);
					((IEnumerable<AccountModel>)/*Error near IL_0685: Stack underflow*/).ToList();
					_ = (delegate*<byte>)(&IEnumerator_System_IDisposable.Init);
					obj = WindowsRuntimeSystemExtensions.GetAwaiter<StorageFile>((IAsyncOperation<StorageFile>)(object)new object());
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
					if (__KnownINotifyPropertyChangingArgs.OrderId == null)
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
					__KnownINotifyPropertyChangingArgs.OrderAt = (PropertyChangingEventArgs)obj;
					obj2 = 43;
					continue;
				case 12:
					obj = obj as ImportAccountViewModel._003C_003Ec__DisplayClass47_0;
					obj2 = 6;
					if (__KnownINotifyPropertyChangingArgs.PayUrl == null)
					{
						obj2 = 8;
					}
					continue;
				case 44:
					obj = ((obj is ImportAccountViewModel._003CParseFile_003Ed__48) ? obj : null);
					obj2 = 45;
					continue;
				case 60:
					IEnumerable_System_IDisposable._002Ecctor();
					obj = (object)/*Error near IL_0747: Stack underflow*/;
					obj2 = 57;
					continue;
				case 4:
				case 11:
				case 15:
				case 17:
				case 28:
				case 41:
					if (__KnownINotifyPropertyChangingArgs.JoinedAt == null)
					{
						obj2 = 40;
						if (__KnownINotifyPropertyChangingArgs.TotalPoints != null)
						{
							obj2 = 22;
						}
						continue;
					}
					_ = INotifyPropertyChangedMethods.AbiToProjectionVftablePtr;
					goto IL_078d;
				case 40:
					{
						goto IL_078d;
					}
					IL_078d:
					if (!(null is LaunchActivatedEventArgs))
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
	internal unsafe void _FF00_FF00椀(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_004f: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I4
		//IL_00b9: Expected Obj, but got I
		//IL_0099: Expected I, but got Obj
		//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00be->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a3->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0084->IL00c9: Incompatible stack heights: 1 vs 0
		//IL_006e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00c9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008e->IL0026: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					_ = 0;
				}
				break;
			case 4:
				*((int, nint)*)(nint)/*Error near IL_0073: Stack underflow*/ = ((int)/*Error near IL_0073: Stack underflow*/, (nint)/*Error near IL_0073: Stack underflow*/);
				_ = IList_object.PatchAttribute;
				if (IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)(int)P_0) == null)
				{
					_ = 3;
					break;
				}
				return;
			case 3:
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute);
				_ = 2;
				break;
			case 2:
				IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = P_0;
				obj2 = 1;
				if (IReadOnlyList_object.ReflectLogicalAttribute == null)
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
	private unsafe void _FF00_FF00欀(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_007b: Expected I4, but got Obj
		//IL_0240: Expected I, but got Obj
		//IL_0249: Expected I, but got Obj
		//IL_0250: Expected I4, but got Obj
		//IL_0250: Expected I, but got Obj
		//IL_0255: Expected Obj, but got I4
		//IL_0255: Expected I, but got Obj
		//IL_0265: Expected Obj, but got I4
		//IL_0120: Expected I4, but got Obj
		//IL_0120: Expected I, but got Obj
		//IL_0199: Expected I, but got VT
		//IL_00f2: Expected I, but got Obj
		//IL_016c: Expected Obj, but got I4
		//IL_008c: Expected Ref, but got VT
		//IL_008c: Expected I, but got Obj
		//IL_0216: Expected Obj, but got I4
		//IL_028b: Expected I, but got Obj
		//IL_00db: Expected Obj, but got I
		//IL_01f1: Expected Obj, but got VT
		//IL_02c1: Expected I, but got Obj
		//IL_02c8: Expected I, but got Obj
		//IL_02c8: Expected I, but got Obj
		//IL_02c8: Expected I, but got Obj
		//IL_02cd: Expected I, but got Obj
		//IL_02a5: Expected I, but got Obj
		//IL_02a7: Expected Obj, but got I4
		//IL_0299: Expected Obj, but got I4
		//IL_00a7: Expected I, but got Obj
		//IL_00a7: Expected I, but got Obj
		//IL_026a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0135->IL0026: Incompatible stack heights: 2 vs 1
		//IL_01a3->IL023a: Incompatible stack heights: 1 vs 0
		//IL_0108->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0182->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01e4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02e2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0275->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0140->IL0026: Incompatible stack heights: 2 vs 1
		//IL_01ad->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0113->IL0026: Incompatible stack types: I4 vs Obj
		//IL_018d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02b1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_022f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0151->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00eb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0205->IL0026: Incompatible stack heights: 2 vs 1
		//IL_02ed->IL0026: Incompatible stack types: I4 vs Obj
		//IL_023a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b6->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)obj, ref *(object[]*)typeof(IEnumerable_System_ComponentModel_INotifyPropertyChanged).TypeHandle);
					/*Error near IL_008c: Member reference must be method, but was: Field*/;
				case 6:
					return;
				case 3:
					return;
				default:
					if (obj != null)
					{
						obj2 = 3;
						if (IList_object.PatchAttribute == null)
						{
							obj2 = 12;
						}
						continue;
					}
					return;
				case 12:
					obj = IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)obj);
					obj2 = 1;
					if (IReadOnlyList_System_IDisposable._initialized == 0)
					{
						obj2 = 1;
					}
					continue;
				case 7:
					IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)IEnumerator_object.LoadAttribute(), (uint)(int)obj);
					_ = 6;
					if (IEnumerator_System_IDisposable._initialized == 0)
					{
						_ = 6;
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
				{
					bool flag = IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_0167: Stack underflow*/, (INotifyPropertyChanged)/*Error near IL_0167: Stack underflow*/, ref *(uint*)obj);
					obj = ((((object)flag) is void) ? ((object)flag) : null);
					obj2 = 0;
					if (IEnumerable_object._initialized == 0)
					{
						obj2 = 0;
					}
					continue;
				}
				case 9:
					if (IEnumerableMethods<INotifyPropertyChanged>.Abi_First_0((IntPtr)(IEnumerableMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)typeof(Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails).TypeHandle) ? 1 : 0)) == null)
					{
						_ = 2;
						continue;
					}
					goto case 4;
				case 5:
					return;
				case 19:
					IEnumerable_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
					obj = P_1;
					obj2 = 18;
					continue;
				case 10:
					return;
				case 1:
				{
					object obj4 = obj;
					if (MarshalInspectable<object>.FromAbi(MarshalInterface<IReadOnlyList<object>>.FromManaged((IReadOnlyList<object>)typeof(_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner).TypeHandle)) == null)
					{
						if (IEnumerator_object.Do_Abi_MoveNext_2((nint)obj4, (byte*)(nint)P_1) != 0)
						{
							obj2 = 14;
							continue;
						}
						break;
					}
					_ = 7;
					continue;
				}
				case 15:
					IListMethods<object>.Abi_InsertAt_5((IntPtr)/*Error near IL_0216: Stack underflow*/, (uint)/*Error near IL_0216: Stack underflow*/, (object)IList_object.Do_Abi_GetAt_0((nint)/*Error near IL_0211: Stack underflow*/, (uint)/*Error near IL_0211: Stack underflow*/, (nint*)(IListMethods<object>.Abi_IndexOf_3((IntPtr)/*Error near IL_020c: Stack underflow*/, (object)/*Error near IL_020c: Stack underflow*/, ref *(uint*)obj) ? 1 : 0)));
					if ((int)/*Error near IL_021b: Stack underflow*/ == 0)
					{
						obj2 = 7;
						if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute == null)
						{
							obj2 = 11;
						}
					}
					else
					{
						obj = IList_object.Do_Abi_get_Size_1((nint)/*Error near IL_02a5: Stack underflow*/, (uint*)(nint)this);
						obj2 = 16;
					}
					continue;
				case 4:
				{
					IList_object.Do_Abi_InsertAt_5((nint)/*Error near IL_0240: Stack underflow*/, (uint)/*Error near IL_0240: Stack underflow*/, (nint)this);
					object obj3 = obj;
					IListMethods<object> val = (IListMethods<object>)new IListMethods<object>((IntPtr)obj);
					IListMethods<object>.Abi_ReplaceAll_11((IntPtr)obj3, (object[])IListMethods<object>.Abi_GetMany_10((IntPtr)val, (uint)(int)val, ref *(object[]*)1));
					obj2 = 8;
					if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator != null)
					{
						obj2 = 7;
					}
					continue;
				}
				case 17:
					return;
				case 18:
					if (!IEnumeratorMethods<INotifyPropertyChanged>.Abi_MoveNext_2((IntPtr)obj))
					{
						goto end_IL_0026;
					}
					goto case 15;
				case 11:
					return;
				case 8:
					return;
				case 2:
					break;
				}
				IList_object._002Ecctor();
				object obj5 = obj;
				IEnumeratorMethods<INotifyPropertyChanged> val2 = (IEnumeratorMethods<INotifyPropertyChanged>)new IEnumeratorMethods<INotifyPropertyChanged>((IntPtr)obj);
				IReadOnlyListMethods<IDisposable>.Abi_GetAt_0((IntPtr)this, IReadOnlyListMethods<IDisposable, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)obj5, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)val2, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)val2, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)2) ? 1u : 0u);
				obj2 = 5;
				if (__KnownINotifyPropertyChangingArgs.Message == null)
				{
					obj2 = 3;
				}
				continue;
				end_IL_0026:
				break;
			}
			obj = 17;
		}
	}
}
