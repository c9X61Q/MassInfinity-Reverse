using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using System.Threading;
using System.Threading.Tasks;
using ABI.Microsoft.UI.Composition;
using ABI.Microsoft.UI.Xaml;
using ABI.Microsoft.UI.Xaml.Controls;
using ABI.Microsoft.UI.Xaml.Markup;
using ABI.System;
using ABI.System.Collections;
using ABI.System.Collections.Generic;
using ABI.System.Collections.Specialized;
using ABI.System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.WinUI.Animations;
using CommunityToolkit.WinUI.Behaviors;
using CommunityToolkit.WinUI.Controls;
using CommunityToolkit.WinUI.Controls.SegmentedRns.CommunityToolkit_WinUI_Controls_Segmented_XamlTypeInfo;
using CommunityToolkit.WinUI.Converters;
using CommunityToolkit.WinUI.Media;
using DevWinUI;
using FluentIcons.Common;
using FluentIcons.WinUI;
using Mass.Application.Desktop.Extensions;
using Mass.Application.Desktop.Models;
using Mass.Application.Event;
using Mass.Application.Services;
using Mass.Common.Localization;
using Mass.Domain.Desktop.Entities.Mods;
using Mass.Domain.Desktop.Models;
using Mass.Domain.Entities.Mass;
using Mass.Domain.Mobile.Interfaces;
using Mass.Domain.ValueObjects;
using Mass.Game.Proxy;
using Mass.WinUI;
using Mass.WinUI.Mass_WinUI_XamlTypeInfo;
using Mass.WinUI.Models;
using Mass.WinUI.ViewModels;
using Matrix.Core;
using Matrix.Core.Events;
using Matrix.Core.Extensions;
using Matrix.Core.Java;
using Microsoft.UI.Composition;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.Windows.ApplicationModel.WindowsAppRuntime.Common;
using Microsoft.Windows.Foundation.UndockedRegFreeWinRTCS;
using Microsoft.Xaml.Interactivity;
using Serilog;
using WinRT.Mass_WinUIVtableClasses;
using WinUI.TableView;
using Windows.ApplicationModel.Core;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;

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
	internal unsafe static void _FF00_FF00_FF00_FF00_FF00_EC00()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0048: Expected I, but got Obj
		//IL_007d: Expected I4, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_0091->IL0026: Incompatible stack heights: 2 vs 1
		//IL_009c->IL0026: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 1:
				new IEnumeratorMethods<object>((IntPtr)null, ref *(object[]*)(delegate*<_003CModule_003E>)(&_003CModule_003E.CheckAccessibleAttribute));
				/*Error near IL_0048: Member reference must be method, but was: Field*/;
			case 2:
				MarshalInspectable<object>.FromManaged((object)null, (byte)(int)new IEnumeratorMethods<object>((IntPtr)(nint)(delegate* unmanaged[Stdcall]<nint, nint*, uint>)(&IEnumerator_object.Do_Abi_get_Current_0)) != 0);
				_ = 1;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute != null)
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
	internal unsafe static void _FF00_FF00_FF00_FF00_FF00_ED00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775541, new IntPtr(2737316781452L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_3100(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_01a3: Expected I4, but got Obj
		//IL_047e: Expected I, but got Obj
		//IL_020b: Expected I, but got Obj
		//IL_0559: Expected Obj, but got I4
		//IL_0af9: Expected VT, but got I4
		//IL_082f: Expected Obj, but got I4
		//IL_0595: Expected Obj, but got I4
		//IL_03c8: Expected I, but got Obj
		//IL_04ea: Expected I, but got Obj
		//IL_03e3: Expected I, but got Obj
		//IL_0253: Expected I4, but got Obj
		//IL_0253: Expected I, but got Obj
		//IL_0433: Expected Obj, but got I4
		//IL_0449: Expected I, but got Obj
		//IL_032b: Expected Obj, but got I4
		//IL_0288: Expected I, but got Obj
		//IL_028d: Expected Obj, but got I4
		//IL_057b: Expected I, but got Obj
		//IL_0398: Expected I, but got Obj
		//IL_0505: Expected I, but got Obj
		//IL_0614: Expected I, but got Obj
		//IL_0a32: Expected I4, but got Obj
		//IL_0367: Expected Obj, but got I4
		//IL_0367: Expected I4, but got Obj
		//IL_0a70: Expected VT, but got Obj
		//IL_05e9: Expected Obj, but got I4
		//IL_0418: Expected I, but got Obj
		//IL_04bf: Expected I4, but got Obj
		//IL_04bf: Expected I, but got Obj
		//IL_021e: Expected I, but got Obj
		//IL_037d: Expected I, but got Obj
		//IL_048c: Expected Obj, but got I4
		//IL_088e: Expected Obj, but got I4
		//IL_027c: Expected Obj, but got I4
		//IL_0560: Expected I, but got Obj
		//IL_054e: Expected Obj, but got I4
		//IL_0b52: Expected Obj, but got I4
		//IL_0337: Expected I, but got Obj
		//IL_0c74: Expected Obj, but got I4
		//IL_0a40: Expected Obj, but got I4
		//IL_02ed: Expected Obj, but got I4
		//IL_0a21: Expected Obj, but got I4
		//IL_0885->IL0c00: Incompatible stack heights: 2 vs 0
		//IL_0217->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0273->IL035b: Incompatible stack heights: 1 vs 0
		//IL_0709->IL08a2: Incompatible stack heights: 2 vs 0
		//IL_0438->IL09aa: Incompatible stack heights: 1 vs 0
		//IL_0795->IL058f: Incompatible stack heights: 2 vs 0
		//IL_080a->IL0a69: Incompatible stack heights: 2 vs 0
		//IL_07d4->IL0c79: Incompatible stack heights: 2 vs 0
		//IL_0691->IL0b99: Incompatible stack heights: 2 vs 0
		//IL_0661->IL03dc: Incompatible stack heights: 2 vs 0
		//IL_0545->IL058f: Incompatible stack heights: 1 vs 0
		//IL_07ef->IL0a01: Incompatible stack heights: 1 vs 0
		//IL_052a->IL058f: Incompatible stack heights: 1 vs 0
		//IL_0baa->IL0442: Incompatible stack heights: 2 vs 0
		//IL_08e9->IL0829: Incompatible stack heights: 2 vs 0
		//IL_06ac->IL058f: Incompatible stack heights: 2 vs 0
		//IL_05ee->IL084a: Incompatible stack heights: 1 vs 0
		//IL_02e4->IL0427: Incompatible stack heights: 1 vs 0
		//IL_077a->IL0b38: Incompatible stack heights: 1 vs 0
		//IL_095b->IL058f: Incompatible stack heights: 1 vs 0
		//IL_0893->IL0022: Incompatible stack heights: 2 vs 0
		//IL_0b12->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03dc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04fe->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0cc4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0401->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0262->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0281->IL0022: Incompatible stack heights: 1 vs 0
		//IL_0ae2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0713->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0442->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0c25->IL0026: Incompatible stack types: I4 vs Obj
		//IL_079f->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0c5a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0a01->IL0026: Incompatible stack types: I4 vs Obj
		//IL_081e->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0b38->IL0026: Incompatible stack types: I4 vs Obj
		//IL_07de->IL0026: Incompatible stack heights: 3 vs 1
		//IL_069b->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0675->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0467->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0553->IL0022: Incompatible stack heights: 1 vs 0
		//IL_0c9e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_029c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_058f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03b6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_07f9->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0534->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0519->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0bbe->IL0026: Incompatible stack heights: 3 vs 1
		//IL_08f3->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0376->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06b6->IL0026: Incompatible stack heights: 3 vs 1
		//IL_08b9->IL0553: Incompatible stack heights: 4 vs 0
		//IL_0769->IL0026: Incompatible stack heights: 3 vs 1
		//IL_01f6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0865->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0a8e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0602->IL0026: Incompatible stack heights: 2 vs 1
		//IL_02f2->IL0022: Incompatible stack heights: 1 vs 0
		//IL_0427->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0784->IL0026: Incompatible stack heights: 2 vs 1
		//IL_04d8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_096f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_023c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0391->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0b1d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_040c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0aed->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0c30->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0829->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0574->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0680->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0472->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0ca9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03c1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0350->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0bc9->IL0026: Incompatible stack heights: 3 vs 1
		//IL_084a->IL0026: Incompatible stack heights: 3 vs 1
		//IL_05b0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_08cd->IL0026: Incompatible stack heights: 5 vs 1
		//IL_0a99->IL0026: Incompatible stack types: I4 vs Obj
		//IL_060d->IL0026: Incompatible stack heights: 2 vs 1
		//IL_04e3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_097a->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0247->IL0026: Incompatible stack types: I4 vs Obj
		//IL_035b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_08d8->IL0026: Incompatible stack heights: 5 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					/*Error near IL_01e7: Stack underflow*/((object[])obj, (int)IEnumerator_object.Init());
					if ((int)/*Error near IL_01ec: Stack underflow*/ == 0)
					{
						obj2 = 7;
						continue;
					}
					goto case 9;
				case 3:
					((ValueTuple<int, nint>*)/*Error near IL_020b: Stack underflow*/)->_002Ector((int)/*Error near IL_020b: Stack underflow*/, (nint)P_0);
					obj = (object)/*Error near IL_020d: Stack underflow*/;
					obj2 = 2;
					continue;
				case 92:
					if (IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)(int)IEnumerator_object.Do_Abi_get_Current_0((nint)/*Error near IL_021e: Stack underflow*/, (nint*)(nint)obj)) != null)
					{
						obj2 = 5;
						if (IReadOnlyList_System_IDisposable._initialized == 0)
						{
							obj2 = 44;
						}
						continue;
					}
					goto case 19;
				case 19:
					if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)obj, (uint)(int)IEnumerator_object.LoadAttribute()) != null)
					{
						obj2 = 67;
						continue;
					}
					goto case 28;
				case 21:
					if (MarshalInterface<INotifyPropertyChanged>.FromAbi((IntPtr)(int)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init()) != null)
					{
						obj = 54;
						break;
					}
					goto case 72;
				case 51:
					if (MarshalInterface<INotifyPropertyChanged>.FromAbiArray((object)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_IndexOf_2((nint)/*Error near IL_0288: Stack underflow*/, (nint)/*Error near IL_0288: Stack underflow*/, (uint*)/*Error near IL_0288: Stack underflow*/, (byte*)(nint)obj)) != null)
					{
						obj2 = 70;
						continue;
					}
					goto case 37;
				case 84:
					if (IEnumerableMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.MoveAttribute() ? 1 : 0)))
					{
						obj = 32;
						break;
					}
					goto case 26;
				case 48:
					return IEnumerable_System_ComponentModel_INotifyPropertyChanged.Do_Abi_First_0((nint)/*Error near IL_032a: Stack underflow*/, (nint*)/*Error near IL_032a: Stack underflow*/);
				case 58:
				{
					object obj5 = obj;
					IEnumerable_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
					if (IListMethods<object>.Abi_GetView_2((IntPtr)obj5) != null)
					{
						obj2 = 18;
						if (Mass_WinUI_AppWinRTTypeDetails.CheckHiddenAttribute == null)
						{
							obj2 = 79;
						}
						continue;
					}
					goto case 55;
				}
				case 72:
					IListMethods<object>.Abi_SetAt_4((IntPtr)/*Error near IL_0367: Stack underflow*/, (uint)(int)obj, (object)IList_object.Init());
					if ((int)/*Error near IL_036c: Stack underflow*/ == 0)
					{
						obj2 = 91;
						continue;
					}
					goto case 9;
				case 93:
					IListMethods<object>.Abi_RemoveAt_6((IntPtr)/*Error near IL_0382: Stack underflow*/, IList_object.Do_Abi_GetView_2((nint)/*Error near IL_037d: Stack underflow*/, (nint*)(nint)obj));
					if ((int)/*Error near IL_0387: Stack underflow*/ != 0)
					{
						obj2 = 33;
						continue;
					}
					goto case 34;
				case 55:
					IListMethods<object>.Abi_RemoveAtEnd_8((IntPtr)(int)IList_object.Do_Abi_SetAt_4((nint)/*Error near IL_0398: Stack underflow*/, (uint)/*Error near IL_0398: Stack underflow*/, (nint)obj));
					if ((int)/*Error near IL_03a2: Stack underflow*/ == 0)
					{
						obj2 = 47;
						if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner.CheckOperationalModule == null)
						{
							obj2 = 56;
						}
						continue;
					}
					goto case 23;
				case 11:
					if (IListMethods<object>.Abi_get_Size_1((IntPtr)(int)IList_object.Do_Abi_RemoveAtEnd_8((nint)obj)) != 0)
					{
						obj2 = 81;
						continue;
					}
					goto case 30;
				case 18:
					if (IEnumeratorMethods<INotifyPropertyChanged>.Abi_MoveNext_2((IntPtr)(int)IList_object.Do_Abi_GetMany_10((nint)/*Error near IL_03e3: Stack underflow*/, (uint)/*Error near IL_03e3: Stack underflow*/, (uint)/*Error near IL_03e3: Stack underflow*/, (nint)/*Error near IL_03e3: Stack underflow*/, (uint*)(nint)obj)))
					{
						obj2 = 0;
						if (__KnownINotifyPropertyChangingArgs.Username != null)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 59;
				case 85:
					if (!IReadOnlyListMethods<IDisposable, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_0418: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_0418: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)obj, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(IList_object.AttachAttribute() ? 1 : 0)))
					{
						obj2 = 69;
						continue;
					}
					goto case 9;
				case 26:
					if (MarshalInterface<IDisposable>.FromManaged((IDisposable)IEnumerator_System_ComponentModel_INotifyPropertyChanged.Initialized) == (IntPtr)0)
					{
						_ = 93;
						continue;
					}
					goto default;
				case 45:
					if (IReadOnlyListMethods<IDisposable>.Abi_IndexOf_2((IntPtr)/*Error near IL_044e: Stack underflow*/, (IDisposable)/*Error near IL_044e: Stack underflow*/, ref *(uint*)IEnumerator_System_ComponentModel_INotifyPropertyChanged.Do_Abi_MoveNext_2((nint)/*Error near IL_0449: Stack underflow*/, (byte*)(nint)obj)))
					{
						obj2 = 24;
						if (__KnownINotifyPropertyChangingArgs.IsSelected != null)
						{
							obj2 = 64;
						}
						continue;
					}
					goto case 83;
				case 1:
				{
					object obj4 = obj;
					IEnumerator_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
					if (IReadOnlyListMethods<IDisposable>.Abi_get_Size_1((IntPtr)obj4) != 0)
					{
						obj = 10;
						break;
					}
					goto case 35;
				}
				case 90:
					if (IReadOnlyListMethods<object>.Abi_GetAt_0((IntPtr)obj, (uint)(int)IEnumerator_System_ComponentModel_INotifyPropertyChanged.DecorateConcreteAttribute()) == null)
					{
						obj2 = 16;
						if (__KnownINotifyPropertyChangingArgs.Author == null)
						{
							obj2 = 6;
						}
						continue;
					}
					goto case 9;
				case 12:
					if (!IEnumeratorMethods<IDisposable, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, nint*, int>)/*Error near IL_04ef: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)/*Error near IL_04ef: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)/*Error near IL_04ef: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, uint*, int>)(int)IReadOnlyList_System_IDisposable.Do_Abi_IndexOf_2((nint)/*Error near IL_04ea: Stack underflow*/, (nint)/*Error near IL_04ea: Stack underflow*/, (uint*)/*Error near IL_04ea: Stack underflow*/, (byte*)(nint)obj)))
					{
						obj2 = 43;
						continue;
					}
					goto default;
				case 60:
					if (IEnumeratorMethods<IDisposable>.Abi_GetMany_3((IntPtr)/*Error near IL_050a: Stack underflow*/, ref *(IDisposable[]*)IReadOnlyList_System_IDisposable.Do_Abi_get_Size_1((nint)/*Error near IL_0505: Stack underflow*/, (uint*)(nint)obj)) == 0)
					{
						obj2 = 51;
						continue;
					}
					goto case 9;
				case 57:
					if (!IEnumeratorMethods<IDisposable>.Abi_get_HasCurrent_1((IntPtr)(IReadOnlyList_System_IDisposable.StoreAttribute() ? 1 : 0)))
					{
						_ = 92;
						continue;
					}
					goto case 9;
				case 46:
					if (IEnumerableMethods<IDisposable>.Abi_First_0((IntPtr)(IReadOnlyList_object.Initialized ? 1 : 0)) == null)
					{
						obj = 22;
						break;
					}
					goto case 9;
				case 4:
					return IReadOnlyList_object.Do_Abi_GetAt_0((nint)/*Error near IL_0558: Stack underflow*/, (uint)/*Error near IL_0558: Stack underflow*/, (nint*)/*Error near IL_0558: Stack underflow*/);
				case 39:
					if (IEnumerableMethods<object>.Abi_First_0((IntPtr)(int)IReadOnlyList_object.Do_Abi_IndexOf_2((nint)/*Error near IL_0560: Stack underflow*/, (nint)/*Error near IL_0560: Stack underflow*/, (uint*)/*Error near IL_0560: Stack underflow*/, (byte*)(nint)obj)) == null)
					{
						obj2 = 58;
						continue;
					}
					goto case 48;
				case 53:
					((Func<Type, string>)/*Error near IL_0580: Stack underflow*/)._002Ector((object)/*Error near IL_0580: Stack underflow*/, (nint)(int)IReadOnlyList_object.Do_Abi_get_Size_1((nint)/*Error near IL_057b: Stack underflow*/, (uint*)(nint)obj));
					if ((int)/*Error near IL_0585: Stack underflow*/ == 0)
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
					return IReadOnlyList_object.ReflectSimpleAttribute();
				case 68:
				{
					object obj6 = obj;
					ComWrappersSupport.RegisterTypeComInterfaceEntriesLookup((Func<Type, ComWrappers.ComInterfaceEntry[]>)(object)IReadOnlyList_object.DecorateControllableAttribute());
					if (obj6 != null)
					{
						obj2 = 66;
						continue;
					}
					goto case 25;
				}
				case 83:
					if (((object)IEnumerator_System_IDisposable.Init()).ToString() != null)
					{
						_ = 86;
						if (__KnownINotifyPropertyChangingArgs.OrderId == null)
						{
							_ = 29;
						}
						continue;
					}
					goto case 78;
				case 65:
					IEnumerator_System_IDisposable.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_0614: Stack underflow*/, (byte*)(nint)obj);
					/*Error near IL_0614: Member reference must be method, but was: Field*/;
				case 43:
					_ = IEnumerable_System_IDisposable.Initialized;
					if (IListMethods.AbiToProjectionVftablePtr != (IntPtr)0)
					{
						_ = 77;
						if (__KnownINotifyPropertyChangingArgs.DisplayName == null)
						{
							_ = 4;
						}
						continue;
					}
					goto case 18;
				case 41:
					IEnumerable_System_IDisposable.CheckTransformableAttribute();
					if (INotifyCollectionChangedMethods.AbiToProjectionVftablePtr != (IntPtr)0)
					{
						_ = 62;
						continue;
					}
					goto case 61;
				case 73:
					_ = IEnumerable_object.Initialized;
					if (INotifyPropertyChangedMethods.AbiToProjectionVftablePtr == (IntPtr)0)
					{
						_ = 75;
						continue;
					}
					goto case 9;
				case 25:
					IEnumerable_object.SaveAttribute();
					if (IReadOnlyListMethods<INotifyPropertyChanged>.AbiToProjectionVftablePtr == (IntPtr)0)
					{
						_ = 74;
						continue;
					}
					goto case 5;
				case 17:
					InitializeGlobalVtableLookup();
					return (object)/*Error near IL_0719: Stack underflow*/;
				case 74:
					DecorateDetachedAttribute();
					if ((int)IDisposableMethods.IID != 0)
					{
						_ = 5;
						continue;
					}
					Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateInternalAttribute();
					if ((nint)IComponentConnectorMethods.IID == 0)
					{
						_ = 23;
						if (__KnownINotifyPropertyChangingArgs.LikeNetGames == null)
						{
							_ = 39;
						}
						continue;
					}
					goto case 4;
				case 87:
					((Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails)obj).GetExposedInterfaces();
					if ((int)IEnumeratorMethods<object>.IID != 0)
					{
						_ = 29;
						continue;
					}
					goto case 49;
				case 28:
					Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.DecorateGeneralAttribute();
					if ((int)IReadOnlyListMethods<IDisposable>.IID == 0)
					{
						_ = 21;
						continue;
					}
					goto case 9;
				case 38:
					Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.CheckCentralAttribute();
					if ((int)IEnumeratorMethods<IDisposable>.IID != 0)
					{
						_ = 42;
						continue;
					}
					goto case 50;
				case 56:
					((Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails)obj).GetExposedInterfaces();
					if ((nint)IUIElementOverridesMethods.IID == 0)
					{
						_ = 31;
						continue;
					}
					goto case 23;
				case 35:
					Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.SortAttribute();
					if ((nint)IAnimationObjectMethods.IID != 0)
					{
						_ = 23;
						if (__KnownINotifyPropertyChangingArgs.HasSelectedFile == null)
						{
							_ = 88;
						}
						continue;
					}
					goto case 82;
				case 8:
					return Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.OpenAttribute();
				case 63:
					Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.DecorateOperationalAttribute();
					if (IVisualElement2Methods.AbiToProjectionVftablePtr == (IntPtr)0)
					{
						return null;
					}
					_ = 17;
					continue;
				case 78:
					((Mass_WinUI_Pages_MobileWinRTTypeDetails)obj)._002Ector();
					if (IFrameworkElementOverridesMethods.AbiToProjectionVftablePtr == (IntPtr)0)
					{
						obj2 = 90;
						continue;
					}
					goto case 9;
				case 2:
					Mass_WinUI_Pages_MobileWinRTTypeDetails.CheckInterruptibleAttribute();
					if (IControlOverridesMethods.AbiToProjectionVftablePtr != (IntPtr)0)
					{
						obj = 14;
						break;
					}
					goto case 27;
				case 5:
				case 66:
					((Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails)/*Error near IL_08a7: Stack underflow*/)._002Ector();
					return (object)/*Error near IL_08a8: Stack underflow*/;
				case 71:
					Mass_WinUI_AppWinRTTypeDetails.DecorateAdjustableAttribute();
					if (IPageOverridesMethods.AbiToProjectionVftablePtr == (IntPtr)0)
					{
						_ = 63;
						continue;
					}
					goto case 8;
				case 91:
					((Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails)obj).GetExposedInterfaces();
					if (IXamlMemberMethods.AbiToProjectionVftablePtr == (IntPtr)0)
					{
						_ = 38;
						if (__KnownINotifyPropertyChangingArgs.SkinOwnedSelected != null)
						{
							_ = 25;
						}
						continue;
					}
					goto case 9;
				case 15:
					((Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails)obj).GetExposedInterfaces();
					/*Error near IL_0981: Member reference must be method, but was: Field*/;
				default:
					return ((Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails)/*Error near IL_09af: Stack underflow*/).GetExposedInterfaces();
				case 89:
					Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.DecorateReadableAttribute();
					/*Error near IL_09d2: Member reference must be method, but was: Field*/;
				case 34:
					((Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails)obj)._002Ector();
					((RegexRunner)/*Error near IL_09f2: Stack underflow*/).CheckTimeout();
					if ((int)/*Error near IL_09f7: Stack underflow*/ != 0)
					{
						obj2 = 24;
						continue;
					}
					goto case 12;
				case 23:
				case 79:
					return Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.CheckJoinedAttribute();
				case 31:
					((_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0)obj)._002Ector();
					if (!char.IsAsciiLetterOrDigit((char)/*Error near IL_0a13: Stack underflow*/))
					{
						obj = 71;
						break;
					}
					goto case 8;
				case 69:
					((RegexRunner)/*Error near IL_0a32: Stack underflow*/).Capture((int)/*Error near IL_0a32: Stack underflow*/, (int)obj, _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.CheckScalableAttribute() ? 1 : 0);
					if ((int)/*Error near IL_0a37: Stack underflow*/ != 0)
					{
						obj = 47;
						break;
					}
					goto case 46;
				case 82:
					((_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner)/*Error near IL_0a70: Stack underflow*/).Scan((ReadOnlySpan<char>)obj);
					if ((TimeSpan)/*Error near IL_0a75: Stack underflow*/ != (TimeSpan)/*Error near IL_0a75: Stack underflow*/)
					{
						obj2 = 6;
						if (__KnownINotifyPropertyChangingArgs.CanMobileMenuInvoke == null)
						{
							obj2 = 76;
						}
						continue;
					}
					goto case 73;
				case 22:
				{
					object obj3 = obj;
					_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities._002Ecctor();
					if (((Window)obj3).Content != null)
					{
						obj2 = 80;
						if (__KnownINotifyPropertyChangingArgs.HasShopDescription == null)
						{
							obj2 = 33;
						}
						continue;
					}
					goto case 65;
				}
				case 7:
					if ((int)IMessengerExtensions.Send<_0021_00210>((IMessenger)obj, (_0021_00210)__KnownINotifyPropertyChangingArgs.CheckIterableInspector()) == 0)
					{
						obj2 = 34;
						if (__KnownINotifyPropertyChangingArgs.Products != null)
						{
							obj2 = 68;
						}
						continue;
					}
					goto case 9;
				case 37:
					((ILogger)obj).Debug((string)(object)__KnownINotifyPropertyChangedArgs.StopAttribute());
					if ((int)/*Error near IL_0b2e: Stack underflow*/ == 0)
					{
						obj2 = 87;
						continue;
					}
					goto case 9;
				case 49:
					((Microsoft.Windows.ApplicationModel.WindowsAppRuntime.Common.AutoInitialize)obj)._002Ector();
					((AppWindow)/*Error near IL_0b44: Stack underflow*/).ShowOnceWithRequestedStartupState();
					if ((int)/*Error near IL_0b49: Stack underflow*/ == 0)
					{
						obj = 15;
						break;
					}
					goto case 9;
				case 61:
					Microsoft.Windows.Foundation.UndockedRegFreeWinRTCS.AutoInitialize.CheckConcreteViewer();
					if (CodePagesEncodingProvider.Instance != null)
					{
						_ = 1;
						if (__KnownINotifyPropertyChangingArgs.PayMethods == null)
						{
							_ = 13;
						}
						continue;
					}
					goto case 45;
				case 27:
					((ILogger)/*Error near IL_0c0c: Stack underflow*/).Warning((string)(object)((App)obj).RootElement);
					if ((int)/*Error near IL_0c11: Stack underflow*/ != 0)
					{
						obj2 = 11;
						if (__KnownINotifyPropertyChangingArgs.CustomerCount == null)
						{
							obj2 = 40;
						}
						continue;
					}
					goto case 84;
				case 30:
					((App)obj).ShowMainWindow();
					if (Log.Logger == null)
					{
						obj2 = 85;
						continue;
					}
					goto case 9;
				case 59:
					((App)obj).ShowLoginWindow();
					((IAsyncStateMachine)/*Error near IL_0c66: Stack underflow*/).MoveNext();
					if ((int)/*Error near IL_0c6b: Stack underflow*/ != 0)
					{
						obj = 20;
						break;
					}
					goto case 89;
				case 50:
					((App)/*Error near IL_0c80: Stack underflow*/).AppClosing((byte)/*Error near IL_0c80: Stack underflow*/ != 0, (AppWindow)/*Error near IL_0c80: Stack underflow*/, (AppWindowClosingEventArgs)obj);
					((AsyncVoidMethodBuilder*)/*Error near IL_0c85: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_0c85: Stack underflow*/, ref *(TStateMachine*)/*Error near IL_0c85: Stack underflow*/);
					if ((int)/*Error near IL_0c8a: Stack underflow*/ == 0)
					{
						obj2 = 1;
						if (__KnownINotifyPropertyChangedArgs.CreateAt == null)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 9;
				case 16:
					if (((MassIrcService)(object)((App)/*Error near IL_0cb0: Stack underflow*/).GetXamlType((string)obj)).DisconnectAsync() == null)
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
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00㐀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00㔀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775536, new IntPtr(2737316781452L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00㘀()
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
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00㜀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775537, new IntPtr(2737316781452L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00㠀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0207: Expected I4, but got Obj
		//IL_1224: Expected Obj, but got Ref
		//IL_1224: Expected Obj, but got I4
		//IL_122c: Expected VT, but got Ref
		//IL_1266: Expected VT, but got Ref
		//IL_1266: Expected Obj, but got I4
		//IL_126e: Expected VT, but got Ref
		//IL_126e: Expected Obj, but got Unknown
		//IL_1271: Unknown result type (might be due to invalid IL or missing references)
		//IL_1287: Expected Obj, but got Ref
		//IL_1287: Expected Obj, but got I4
		//IL_128f: Expected Obj, but got Ref
		//IL_128f: Expected Obj, but got Unknown
		//IL_1292: Unknown result type (might be due to invalid IL or missing references)
		//IL_129b: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1337: Unknown result type (might be due to invalid IL or missing references)
		//IL_1341: Unknown result type (might be due to invalid IL or missing references)
		//IL_1359: Unknown result type (might be due to invalid IL or missing references)
		//IL_135f: Expected Obj, but got I4
		//IL_0cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc4: Expected Obj, but got Ref
		//IL_0ccc: Expected Obj, but got Ref
		//IL_0ccf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce5: Expected Obj, but got Ref
		//IL_0ced: Expected Obj, but got Ref
		//IL_0cf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d27: Expected Obj, but got Ref
		//IL_0d2f: Expected Obj, but got Ref
		//IL_0d32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db3: Expected Obj, but got Ref
		//IL_0dbb: Expected VT, but got Obj
		//IL_178e: Unknown result type (might be due to invalid IL or missing references)
		//IL_179e: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_17af: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_17cd: Expected Obj, but got I4
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected I, but got Obj
		//IL_03ac: Expected Obj, but got I4
		//IL_02f2: Expected I, but got Obj
		//IL_0218: Expected I, but got Obj
		//IL_0410: Expected Obj, but got Ref
		//IL_0418: Expected VT, but got Obj
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected Obj, but got I4
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected I, but got Obj
		//IL_0452: Expected I, but got Obj
		//IL_0452: Expected I, but got Obj
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected Obj, but got Ref
		//IL_0494: Expected Obj, but got Ref
		//IL_049c: Expected I4, but got Obj
		//IL_049d: Expected Obj, but got I4
		//IL_0263: Expected I, but got Obj
		//IL_0aa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ade: Expected Obj, but got Ref
		//IL_0ae1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b23: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e1: Expected Obj, but got Ref
		//IL_09e1: Expected I4, but got Obj
		//IL_09e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a02: Expected Obj, but got Ref
		//IL_0a05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3c: Expected Obj, but got Ref
		//IL_0a44: Expected Obj, but got I4
		//IL_0a44: Expected Obj, but got I4
		//IL_0a47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6e: Expected Obj, but got I4
		//IL_032c: Expected I, but got Obj
		//IL_032e: Expected Obj, but got I4
		//IL_035c: Expected Obj, but got I4
		//IL_0283: Expected I, but got Obj
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_078a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0793: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c1: Expected Obj, but got Ref
		//IL_07c9: Expected Obj, but got Ref
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ea: Expected Obj, but got Ref
		//IL_07ea: Expected Obj, but got I4
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eaf: Expected Obj, but got Ref
		//IL_0eaf: Expected Obj, but got I4
		//IL_0eb7: Expected Obj, but got Ref
		//IL_0ebf: Expected VT, but got Obj
		//IL_02d2: Expected I, but got Obj
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0618: Expected Obj, but got I
		//IL_15cf: Expected Obj, but got I4
		//IL_084e: Unknown result type (might be due to invalid IL or missing references)
		//IL_085b: Expected Obj, but got Ref
		//IL_085b: Expected Obj, but got I4
		//IL_085e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0866: Unknown result type (might be due to invalid IL or missing references)
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_087c: Expected Obj, but got Ref
		//IL_0884: Expected VT, but got Ref
		//IL_0887: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2f: Expected Obj, but got I4
		//IL_1670: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ae: Expected VT, but got Obj
		//IL_16f0: Expected I4, but got Obj
		//IL_1743: Expected F8, but got Ref
		//IL_174b: Expected F8, but got Ref
		//IL_1753: Expected VT, but got Obj
		//IL_1754: Expected Obj, but got I4
		//IL_1106: Expected Obj, but got Ref
		//IL_110e: Expected Obj, but got Ref
		//IL_1127: Expected F8, but got Ref
		//IL_112f: Expected Obj, but got Ref
		//IL_0dc8: Expected VT, but got Obj
		//IL_09bd: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got I
		//IL_1455: Expected native int or pointer, but got Obj
		//IL_136b: Expected I4, but got Obj
		//IL_152f: Expected Obj, but got I4
		//IL_05ca: Expected Obj, but got I4
		//IL_0297: Expected Obj, but got I
		//IL_1826: Expected Obj, but got I4
		//IL_0894: Expected I4, but got Obj
		//IL_04a9: Expected Obj, but got I4
		//IL_1152: Expected Obj, but got I4
		//IL_097d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04ec->IL0026: Incompatible stack types: I4 vs Obj
		//IL_150a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_14c5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_107a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_13ca->IL0026: Incompatible stack types: I4 vs Obj
		//IL_11ee->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0fac->IL0026: Incompatible stack types: I4 vs Obj
		//IL_140a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_024c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0e15->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0e98->IL0026: Incompatible stack types: I4 vs Obj
		//IL_1095->IL0026: Incompatible stack types: I4 vs Obj
		//IL_1046->IL0026: Incompatible stack types: I4 vs Obj
		//IL_154e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_102c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_1569->IL0026: Incompatible stack types: I4 vs Obj
		//IL_025c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05b0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0531->IL0e98: Incompatible stack heights: 2 vs 0
		//IL_05c1->IL0f8c: Incompatible stack heights: 2 vs 0
		//IL_08e9->IL11b4: Incompatible stack heights: 1 vs 0
		//IL_0342->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0fe1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04fc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0f9c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0f19->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0958->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05a0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_13ba->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0326->IL0026: Incompatible stack types: I4 vs Obj
		//IL_14d5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_15d4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0555->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0f81->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0988->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0b69->IL0026: Incompatible stack types: I4 vs Obj
		//IL_117c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_1515->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0c83->IL0026: Incompatible stack types: I4 vs Obj
		//IL_1085->IL0026: Incompatible stack types: I4 vs Obj
		//IL_13ef->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0c68->IL0026: Incompatible stack types: I4 vs Obj
		//IL_11cf->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0e20->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0bce->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03c5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_030b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_1615->IL0026: Incompatible stack types: I4 vs Obj
		//IL_09a3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0395->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0231->IL0026: Incompatible stack types: I4 vs Obj
		//IL_163a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_1051->IL0026: Incompatible stack types: I4 vs Obj
		//IL_1559->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0fc7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_145f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_15ba->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0585->IL0026: Incompatible stack heights: 3 vs 1
		//IL_14f0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_1850->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0277->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0bb3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0918->IL0026: Incompatible stack types: I4 vs Obj
		//IL_053b->IL0026: Incompatible stack heights: 3 vs 1
		//IL_05cf->IL0022: Incompatible stack heights: 2 vs 0
		//IL_10d4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_08f3->IL0026: Incompatible stack heights: 2 vs 1
		//IL_034d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_093e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_1584->IL0026: Incompatible stack types: I4 vs Obj
		//IL_029c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0cad->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0fec->IL0026: Incompatible stack types: I4 vs Obj
		//IL_159f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_08d8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_10ef->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0f49->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0be9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0f24->IL0026: Incompatible stack types: I4 vs Obj
		//IL_1011->IL0026: Incompatible stack types: I4 vs Obj
		//IL_15fa->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0963->IL0026: Incompatible stack types: I4 vs Obj
		//IL_14aa->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02e6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_15df->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0e59->IL0026: Incompatible stack types: I4 vs Obj
		//IL_139f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0560->IL0026: Incompatible stack types: I4 vs Obj
		//IL_1485->IL0026: Incompatible stack types: I4 vs Obj
		//IL_142f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04ae->IL10b9: Incompatible stack heights: 1 vs 0
		//IL_0f8c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0b74->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0839->IL0026: Incompatible stack types: I4 vs Obj
		//IL_1187->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0dd7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_13fa->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03d0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_1779->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0316->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03a0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_023c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_1645->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0a93->IL0026: Incompatible stack types: I4 vs Obj
		//IL_146a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_137a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0590->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0edb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_185b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0923->IL0026: Incompatible stack types: I4 vs Obj
		//IL_063d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02a7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0f54->IL0026: Incompatible stack types: I4 vs Obj
		//IL_101c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_14b5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_08b2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0b44->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0e64->IL0026: Incompatible stack types: I4 vs Obj
		//IL_13aa->IL0026: Incompatible stack types: I4 vs Obj
		//IL_143a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04c2->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0844->IL0026: Incompatible stack types: I4 vs Obj
		//IL_17e8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_1784->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0a9e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0648->IL0026: Incompatible stack types: I4 vs Obj
		//IL_08bd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04cd->IL0026: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object value = 73;
		while (true)
		{
			object obj = value;
			while (true)
			{
				switch ((int)obj)
				{
				case 43:
					if (IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)value, ref *(object[]*)_003CModule_003E.CheckAccessibleAttribute()) != 0)
					{
						obj = 13;
						if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
						{
							obj = 23;
						}
						continue;
					}
					goto case 65;
				case 25:
					IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_0241: Stack underflow*/, (uint)/*Error near IL_0241: Stack underflow*/, (nint)/*Error near IL_0241: Stack underflow*/, (uint*)/*Error near IL_0241: Stack underflow*/);
					obj = 63;
					continue;
				case 58:
					IEnumerator_object.Do_Abi_get_Current_0((nint)/*Error near IL_0251: Stack underflow*/, (nint*)/*Error near IL_0251: Stack underflow*/);
					obj = 4;
					continue;
				case 62:
					if (MarshalInspectable<object>.FromManaged((object)/*Error near IL_0268: Stack underflow*/, (byte)IEnumerator_object.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_0263: Stack underflow*/, (byte*)(nint)value) != 0) == (IntPtr)0)
					{
						obj = 83;
						continue;
					}
					goto case 48;
				case 77:
					if (!IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_0283: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_0283: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)value, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(IEnumerator_object.DecorateAutomatableAttribute() ? 1 : 0)))
					{
						obj = 54;
						if (IReadOnlyList_object.ReflectLogicalAttribute != null)
						{
							obj = 113;
						}
						continue;
					}
					goto case 20;
				case 100:
					if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)/*Error near IL_02d7: Stack underflow*/, (uint)/*Error near IL_02d7: Stack underflow*/, ref *(INotifyPropertyChanged[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3((nint)/*Error near IL_02d2: Stack underflow*/, (uint)/*Error near IL_02d2: Stack underflow*/, (uint)/*Error near IL_02d2: Stack underflow*/, (nint)/*Error near IL_02d2: Stack underflow*/, (uint*)(nint)value)) == 0)
					{
						obj = 21;
						continue;
					}
					goto case 6;
				case 35:
				{
					object obj3 = value;
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
					if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_get_Size_1((IntPtr)obj3) != 0)
					{
						obj = 24;
						if (Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute == null)
						{
							obj = 12;
						}
						continue;
					}
					((XamlTypeInfoProvider)value).StaticInitializer_230_ReferralViewModel();
					((TableView)/*Error near IL_1760: Stack underflow*/).HeadersVisibility = (TableViewHeadersVisibility)/*Error near IL_1760: Stack underflow*/;
					if ((int)/*Error near IL_1765: Stack underflow*/ != 0)
					{
						obj = 0;
						if (((DesktopViewModel)DesktopViewModel.SkinEmptyText__BackingField).SkinAllSelected__BackingField == 0)
						{
							obj = 0;
						}
						continue;
					}
					((XamlTypeInfoProvider)value).StaticInitializer_248_EnumUpdateMethod();
					((TableView)/*Error near IL_17d9: Stack underflow*/).CanReorderColumns = (byte)/*Error near IL_17d9: Stack underflow*/ != 0;
					if ((int)/*Error near IL_17de: Stack underflow*/ == 0)
					{
						obj = 97;
						continue;
					}
					goto case 109;
				}
				case 31:
				case 98:
				case 104:
					IEnumerable_System_ComponentModel_INotifyPropertyChanged.Init();
					obj = 30;
					continue;
				case 73:
					value = IListMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_032c: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_032c: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)/*Error near IL_032c: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_032c: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_032c: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_032c: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int>)/*Error near IL_032c: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, int>)/*Error near IL_032c: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)/*Error near IL_032c: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)/*Error near IL_032c: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)/*Error near IL_032c: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, int>)P_0);
					obj = 72;
					if (Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute == null)
					{
						obj = 28;
					}
					continue;
				case 75:
					IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectMonoAttribute();
					value = 94;
					break;
				case 42:
					if (!IListMethods<object>.Abi_IndexOf_3((IntPtr)/*Error near IL_037c: Stack underflow*/, value, ref *(IList_object.Initialized ? ((uint*)1) : ((uint*)null))))
					{
						obj = 9;
						if (Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute != null)
						{
							obj = 2;
						}
						continue;
					}
					goto case 3;
				case 33:
					IListMethods<object>.Abi_Append_7((IntPtr)/*Error near IL_03ac: Stack underflow*/, (object)IList_object.Do_Abi_IndexOf_3((nint)/*Error near IL_03a7: Stack underflow*/, (nint)/*Error near IL_03a7: Stack underflow*/, (uint*)/*Error near IL_03a7: Stack underflow*/, (byte*)(nint)value));
					if ((int)/*Error near IL_03b1: Stack underflow*/ != 0)
					{
						obj = 67;
						if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.ReflectLiteralAttribute != null)
						{
							obj = 115;
						}
						continue;
					}
					goto case 38;
				case 46:
				{
					IEnumerableMethods<>[] array4 = new IEnumerableMethods<>[6];
					value = null;
					((Func<, >[])IListMethods<object>.Abi_get_Size_1((IntPtr)(nint)(&value)))[IEnumeratorMethods<INotifyPropertyChanged>.Abi_MoveNext_2((IntPtr)(nint)(&value)) ? 1u : 0u] = (Func<, >)value;
					value = null;
					((Guid[])IReadOnlyListMethods<IDisposable, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)null, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)null, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)1, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(&value)))[(nint)MarshalInterface<IDisposable>.FromManaged((IDisposable)(&value))] = (Guid)value;
					value = (object)default(IListMethods);
					MarshalInterface<IDisposable>.CopyManagedArray((IDisposable[])2, (IntPtr)(nint)(&value));
					array4[IReadOnlyListMethods<IDisposable>.Abi_get_Size_1((IntPtr)(nint)(&value))] = (IEnumerableMethods<>)value;
					value = null;
					bool flag = IEnumeratorMethods<IDisposable, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, nint*, int>)array4, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)array4, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)(int)IReadOnlyListMethods<object>.Abi_GetMany_3((IntPtr)array4, 3u, ref *(object[]*)(&value)), (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, uint*, int>)(&value));
					((IControlOverridesMethods[])/*Error near IL_045a: Stack underflow*/)[flag ? 1u : 0u] = (IControlOverridesMethods)value;
					/*Error near IL_045a: Stack underflow*/;
					value = (object)default(IContentControlOverridesMethods);
					((IXamlMetadataProviderMethods[])IEnumeratorMethods<IDisposable>.Abi_get_HasCurrent_1((IntPtr)(nint)(&value)))[(object)IEnumerableMethods<IDisposable>.Abi_First_0((IntPtr)(nint)(&value))] = (IXamlMetadataProviderMethods)value;
					value = (object)default(IXamlMemberMethods);
					IntPtr intPtr = MarshalInterface<IEnumerator<object>>.FromManaged((IEnumerator<object>)(&value));
					ComWrappersSupport.RegisterTypeRuntimeClassNameLookup((Func<Type, string>)(&value));
					((char[])5)[(nint)intPtr] = (char)(int)value;
					return 4;
				}
				case 113:
					if (((object)IEnumerator_System_IDisposable.Init()).ToString() != null)
					{
						_ = 34;
						if (__KnownINotifyPropertyChangingArgs.OrderId != null)
						{
							_ = 60;
						}
						continue;
					}
					goto case 71;
				case 4:
					IEnumerator_System_IDisposable.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_04e1: Stack underflow*/, (byte*)/*Error near IL_04e1: Stack underflow*/);
					obj = 78;
					continue;
				case 84:
					IEnumerator_System_IDisposable._002Ecctor();
					obj = 114;
					continue;
				case 69:
					_ = IEnumerable_System_IDisposable.Initialized;
					if (IListMethods.AbiToProjectionVftablePtr == (IntPtr)0)
					{
						_ = 59;
						continue;
					}
					goto case 89;
				case 109:
					IEnumerable_System_IDisposable.Do_Abi_First_0((nint)/*Error near IL_0540: Stack underflow*/, (nint*)/*Error near IL_0540: Stack underflow*/);
					obj = 105;
					if (__KnownINotifyPropertyChangingArgs.JoinedAt == null)
					{
						obj = 57;
					}
					continue;
				case 57:
				{
					object obj2 = value;
					IEnumerable_System_IDisposable enumerable_System_IDisposable = IEnumerable_System_IDisposable.ReflectSequentialAttribute();
					if ((int)INotifyPropertyChangedMethods.IID != 0)
					{
						_ = 98;
						if (__KnownINotifyPropertyChangingArgs.CreatedAt != null)
						{
							_ = 97;
						}
						continue;
					}
					((XamlTypeInfoProvider)value).StaticInitializer_112_AddAccountDialog();
					((TableViewColumn)obj2).CanSort = (byte)(int)enumerable_System_IDisposable != 0;
					if ((int)/*Error near IL_1370: Stack underflow*/ == 0)
					{
						obj = 61;
						continue;
					}
					goto case 3;
				}
				case 94:
					IEnumerable_object._002Ecctor();
					obj = 7;
					continue;
				case 67:
					IEnumerable_object.SaveAttribute();
					obj = 84;
					continue;
				case 70:
					IEnumerable_object.DecorateAttachedAttribute();
					if ((int)IEnumerableMethods<INotifyPropertyChanged>.IID == 0)
					{
						value = 79;
						break;
					}
					goto case 3;
				case 101:
				{
					_ = new LocalizationManager[2];
					_ = 0;
					value = null;
					_ = ref value;
					_ = IEnumeratorMethods<INotifyPropertyChanged>.AbiToProjectionVftablePtr;
					((Log[])(ref value))[(nint)IDisposableMethods.AbiToProjectionVftablePtr] = (Log)value;
					_ = 1;
					value = null;
					_ = ref value;
					IntPtr abiToProjectionVftablePtr = IReadOnlyListMethods<IDisposable>.AbiToProjectionVftablePtr;
					((Task[])(ref value))[(nint)IEnumerableMethods<IDisposable>.AbiToProjectionVftablePtr] = (Task)value;
					return (nint)abiToProjectionVftablePtr;
				}
				case 28:
					_ = new CastExtensions[7];
					_ = 0;
					value = (object)default(IComponentConnector);
					_ = ref value;
					_ = IVisualElement2Methods.IID;
					((XamlBindingHelper[])(ref value))[ref *(byte*)IFrameworkElementOverridesMethods.IID] = (XamlBindingHelper)value;
					_ = 1;
					value = null;
					_ = ref value;
					_ = IContentControlOverridesMethods.IID;
					((OverlappedPresenter[])(ref value))[ref *(byte*)IComponentConnectorMethods.IID] = (OverlappedPresenter)value;
					_ = 2;
					value = (object)default(AppWindowPresenter);
					_ = ref value;
					_ = IPageOverridesMethods.AbiToProjectionVftablePtr;
					((DispatcherQueueHandler[])(ref value))[(nint)IApplicationOverridesMethods.AbiToProjectionVftablePtr] = (DispatcherQueueHandler)value;
					_ = 3;
					value = (object)default(DispatcherQueuePriority);
					_ = ref value;
					_ = IXamlMemberMethods.AbiToProjectionVftablePtr;
					((VerticalAlignment[])(ref value))[(nint)IXamlTypeMethods.AbiToProjectionVftablePtr] = (VerticalAlignment)value;
					_ = 4;
					value = (object)default(Visibility);
					_ = ref value;
					/*Error near IL_06ed: Member reference must be method, but was: Field*/;
				case 78:
				{
					_ = new OpacityMaskView[6];
					_ = 0;
					value = (object)default(DoubleToObjectConverter);
					_ = ref value;
					string baseDirectory = AppContext.BaseDirectory;
					((NumberBoxSpinButtonPlacementMode[])(ref value))[(object)Application.Current] = (NumberBoxSpinButtonPlacementMode)value;
					value = null;
					((FrameworkElement)WeakReferenceMessenger.Default).RequestedTheme = (ElementTheme)(ref value);
					((RedirectVisualView[])1)[ref *(byte*)(&value)] = (RedirectVisualView)value;
					value = (object)default(ListViewSelectionMode);
					AppWindow appWindow = ((Window*)(&value))->AppWindow;
					((AppWindow*)(&value))->Destroy();
					((UniformGridLayoutItemsJustification[])2)[(object)appWindow] = (UniformGridLayoutItemsJustification)value;
					value = (object)default(ContainerVisual);
					Encoding.RegisterProvider((EncodingProvider)(&value));
					LocalizationManager.SetCulture((string)(&value));
					((EasingMode[])(object)baseDirectory)[3] = (EasingMode)value;
					value = (object)default(ListView);
					Environment.Exit((int)(&value));
					((Uri)4)._002Ector((string)(&value));
					((TableViewHeadersVisibility[])(object)baseDirectory)[(object)baseDirectory] = (TableViewHeadersVisibility)value;
					value = (object)default(UniformGridLayoutItemsStretch);
					((AsyncVoidMethodBuilder*)(&value))->SetResult();
					((TaskAwaiter*)(&value))->GetResult();
					((ContentPresenter[])(object)baseDirectory)[5] = (ContentPresenter)value;
					return baseDirectory;
				}
				case 2:
					if ((int)((Task)(object)((App)value).GetXmlnsDefinitions()).GetAwaiter() == 0)
					{
						obj = 69;
						if (__KnownINotifyPropertyChangedArgs.CharacterName != null)
						{
							obj = 16;
						}
						continue;
					}
					goto case 89;
				case 105:
				{
					LayoutTransformControl[] array7 = new LayoutTransformControl[2];
					value = (object)default(IKeyFrame<>);
					((IAsyncStateMachine)0).SetStateMachine((IAsyncStateMachine)(&value));
					value = (object)new UserControl();
					array7[(object)array7] = (LayoutTransformControl)value;
					_003F val7 = /*Error near IL_086b: Stack underflow*/;
					value = (object)default(EmptyObjectToObjectConverter);
					((FrameworkElement)1).Loading += (TypedEventHandler<FrameworkElement, object>)(object)(&value);
					((SettingsCard[])val7)[(object)Type.GetTypeFromHandle((RuntimeTypeHandle)(&value))] = (SettingsCard)value;
					return (object)/*Error near IL_088d: Stack underflow*/;
				}
				case 97:
					((MainContent.IMainContent_Bindings)/*Error near IL_0894: Stack underflow*/).DisconnectUnloadedObject((int)value);
					((Window)/*Error near IL_0899: Stack underflow*/)._002Ector();
					if ((int)/*Error near IL_089e: Stack underflow*/ == 0)
					{
						obj = 1;
						if (__KnownINotifyPropertyChangedArgs.SourceImage == null)
						{
							obj = 0;
						}
						continue;
					}
					goto case 54;
				case 82:
					((MainContent.IMainContent_BindingsScopeConnector)/*Error near IL_08c4: Stack underflow*/).RegisterForElementConnection((int)/*Error near IL_08c4: Stack underflow*/, (IComponentConnector)value);
					((OverlappedPresenter)/*Error near IL_08c9: Stack underflow*/).IsMaximizable = (byte)/*Error near IL_08c9: Stack underflow*/ != 0;
					if ((int)/*Error near IL_08ce: Stack underflow*/ != 0)
					{
						obj = 37;
						continue;
					}
					goto case 85;
				case 72:
					if (((AppWindow)MainContent.XamlBindingSetters.CheckVisualCalculator()).TitleBar != null)
					{
						_ = 41;
						continue;
					}
					goto case 29;
				case 65:
					((MainContent.MainContent_obj1_Bindings)value)._002Ector();
					((FrameworkElement)/*Error near IL_08ff: Stack underflow*/).ActualThemeChanged += (TypedEventHandler<FrameworkElement, object>)/*Error near IL_08ff: Stack underflow*/;
					if ((int)/*Error near IL_0904: Stack underflow*/ == 0)
					{
						obj = 4;
						if (__KnownINotifyPropertyChangedArgs.Type == null)
						{
							obj = 99;
						}
						continue;
					}
					goto case 6;
				case 74:
					((MainContent.MainContent_obj1_Bindings)value).Update();
					((OverlappedPresenter)/*Error near IL_092f: Stack underflow*/).IsResizable = (byte)/*Error near IL_092f: Stack underflow*/ != 0;
					if ((int)/*Error near IL_0934: Stack underflow*/ == 0)
					{
						((Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails)value)._002Ector();
						if (IUIElementOverridesMethods.AbiToProjectionVftablePtr != (IntPtr)0)
						{
							obj = 102;
							if (__KnownINotifyPropertyChangingArgs.SelectedFileName != null)
							{
								obj = 102;
							}
							continue;
						}
						((XamlTypeInfoProvider)value).StaticInitializer_19_NullToObjectConverter();
						((Animation<string, Vector3>)/*Error near IL_1144: Stack underflow*/).KeyFrames = (IList<IKeyFrame<Vector3>>)/*Error near IL_1144: Stack underflow*/;
						if ((int)/*Error near IL_1149: Stack underflow*/ == 0)
						{
							return null;
						}
						value = 96;
						break;
					}
					obj = 101;
					continue;
				case 93:
					((MainContent.MainContent_obj1_Bindings)/*Error near IL_0943: Stack underflow*/).DisconnectUnloadedObject((int)/*Error near IL_0943: Stack underflow*/);
					obj = 67;
					if (__KnownINotifyPropertyChangedArgs.Paid == null)
					{
						obj = 12;
					}
					continue;
				default:
					((MainContent.MainContent_obj1_Bindings)/*Error near IL_0968: Stack underflow*/).Loading((FrameworkElement)/*Error near IL_0968: Stack underflow*/, (object)/*Error near IL_0968: Stack underflow*/);
					obj = 6;
					if (__KnownINotifyPropertyChangedArgs.Number != null)
					{
						obj = 16;
					}
					continue;
				case 38:
					((FrameworkElement)value).Margin = (Thickness)MainContent.MainContent_obj1_Bindings.ParseDictionary();
					if ((int)/*Error near IL_0999: Stack underflow*/ != 0)
					{
						obj = 14;
						continue;
					}
					goto case 42;
				case 21:
					((MainWindow)value)._002Ector();
					((FrameworkElement)/*Error near IL_09af: Stack underflow*/).VerticalAlignment = (VerticalAlignment)/*Error near IL_09af: Stack underflow*/;
					if ((int)/*Error near IL_09b4: Stack underflow*/ != 0)
					{
						value = 34;
						break;
					}
					goto case 43;
				case 68:
				{
					TableViewTextColumn[] array3 = new TableViewTextColumn[5];
					value = (object)default(InfoBarTemplateSettings);
					((AppWindowTitleBar)0).PreferredTheme = (TitleBarTheme)(ref value);
					((UIElementCollection)array3).Insert((int)array3, (UIElement)(object)(&value));
					((TableViewConditionalCellStyle[])/*Error near IL_09e9: Stack underflow*/)[/*Error near IL_09e9: Stack underflow*/] = (TableViewConditionalCellStyle)value;
					/*Error near IL_09e9: Stack underflow*/;
					_ = 1;
					value = (object)default(BoolNegationConverter);
					DispatcherQueue forCurrentThread = DispatcherQueue.GetForCurrentThread();
					SynchronizationContext.SetSynchronizationContext((SynchronizationContext?)(&value));
					((SortDescription[])(ref value))[(object)forCurrentThread] = (SortDescription)value;
					value = (object)default(PagerControlButtonVisibility);
					((TextBox[])((IXamlType*)(&value))->IsConstructible)[(object)((IXamlType*)(&value))->UnderlyingType] = (TextBox)value;
					value = (object)default(CompositionObject);
					((InfoBadge[])2)[((Dictionary<string, IXamlMember>)3).TryGetValue((string)string.IsNullOrEmpty((string?)(&value)), out *(IXamlMember*)(&value)) ? 1u : 0u] = (InfoBadge)value;
					value = (object)default(Brush);
					value = (object)new BoolToVisibilityConverter();
					value = (object)new BoolNegationConverter();
					((ProgressRing[])2)[4] = (ProgressRing)value;
					return 2;
				}
				case 50:
					((EmptyObjectToObjectConverter)((XamlMetaDataProvider)/*Error near IL_0a75: Stack underflow*/).GetXamlType((Type)value))._002Ector();
					if ((int)/*Error near IL_0a7f: Stack underflow*/ == 0)
					{
						obj = 73;
						if (__KnownINotifyPropertyChangedArgs.LanGames != null)
						{
							obj = 74;
						}
						continue;
					}
					goto case 101;
				case 63:
				{
					NavigationViewTemplateSettings[] array = new NavigationViewTemplateSettings[4];
					value = (object)default(TableViewSelectionUnit);
					value = (object)new ImplicitAnimationSet();
					value = (object)new OpacityAnimation();
					array[0] = (NavigationViewTemplateSettings)value;
					value = (object)default(Case);
					value = (object)new TableViewTextColumn();
					((ObservableCollection<AccountModel>)(&value))._002Ector();
					array[1] = (NavigationViewTemplateSettings)value;
					value = (object)default(VirtualizingLayout);
					value = (object)new Case();
					value = (object)(array[2] = (NavigationViewTemplateSettings)new SegmentedItem());
					value = (object)default(StretchChild);
					value = (object)new NavigationViewItemPresenterTemplateSettings();
					value = (object)new ItemsRepeater();
					array[3] = (NavigationViewTemplateSettings)value;
					return array;
				}
				case 99:
					((FluentIcon)((XamlTypeInfoProvider)value).Activate_24_ImplicitAnimationSet())._002Ector();
					if ((int)/*Error near IL_0b3a: Stack underflow*/ != 0)
					{
						obj = 48;
						continue;
					}
					goto case 64;
				case 1:
					((ProgressRing)((XamlTypeInfoProvider)value).Activate_42_OpacityAnimation())._002Ector();
					if ((int)/*Error near IL_0b55: Stack underflow*/ == 0)
					{
						obj = 12;
						if (__KnownINotifyPropertyChangedArgs.InputUsername == null)
						{
							obj = 50;
						}
						continue;
					}
					goto case 54;
				case 64:
					((BehaviorCollection)((XamlTypeInfoProvider)value).Activate_94_AccountTable())._002Ector();
					if ((int)/*Error near IL_0ba9: Stack underflow*/ == 0)
					{
						obj = 92;
						continue;
					}
					goto case 48;
				case 32:
					((ActionCollection)((XamlTypeInfoProvider)value).Activate_97_Collection())._002Ector();
					if ((int)/*Error near IL_0bc4: Stack underflow*/ == 0)
					{
						obj = 5;
						continue;
					}
					goto case 3;
				case 88:
					((ObservableCollection<ProductModel>)((XamlTypeInfoProvider)value).Activate_102_CaseCollection())._002Ector();
					if ((int)/*Error near IL_0bdf: Stack underflow*/ == 0)
					{
						obj = 107;
						continue;
					}
					goto case 3;
				case 26:
					((ObservableCollection<TopUpModel>)((XamlTypeInfoProvider)value).Activate_114_AppNavigationViewItem())._002Ector();
					if ((int)/*Error near IL_0c5e: Stack underflow*/ == 0)
					{
						obj = 57;
						continue;
					}
					goto case 31;
				case 9:
					((ObservableCollection<TopUpGroupModel>)((XamlTypeInfoProvider)value).Activate_118_InfoBadge())._002Ector();
					if ((int)/*Error near IL_0c79: Stack underflow*/ != 0)
					{
						obj = 17;
						continue;
					}
					goto case 47;
				case 79:
					((ObservableCollection<object>)((XamlTypeInfoProvider)value).Activate_122_NavigationViewItemPresenter())._002Ector();
					if ((int)/*Error near IL_0ca3: Stack underflow*/ == 0)
					{
						obj = 95;
						continue;
					}
					goto case 3;
				case 11:
				{
					Implicit[] array8 = new Implicit[8];
					value = (object)default(Transform);
					((Collection<PayMethodModel>)(&value))._002Ector();
					((Collection<HistoryOrderModel>)(&value))._002Ector();
					array8[0] = (Implicit)value;
					value = (object)default(XamlCompositionEffectBrushBase);
					((ObservableCollection<ReferralEarningModel>)(&value))._002Ector();
					((ObservableCollection<ReferralCustomerModel>)(&value))._002Ector();
					array8[1] = (Implicit)value;
					value = (object)default(ItemContainer);
					value = (object)new PersonPicture();
					value = (object)new TitleBar();
					array8[2] = (Implicit)value;
					value = (object)default(IconSize);
					((List<AccountModel>)(&value))._002Ector();
					((ObservableCollection<ChatModel>)(&value))._002Ector();
					array8[3] = (Implicit)value;
					value = (object)default(DataTemplate);
					value = (object)new CompositionShadow();
					value = (object)new CaseCollection();
					array8[4] = (Implicit)value;
					value = (object)default(ScrollingScrollMode);
					value = (object)new ItemContainer();
					value = (object)new PagerControlTemplateSettings();
					array8[5] = (Implicit)value;
					value = null;
					value = (object)new TokenItem();
					value = (object)new SettingsCard();
					array8[6] = (Implicit)value;
					value = (object)default(XamlMetaDataProvider);
					value = (object)new ViewportBehavior();
					((Collection<GameInstanceModel>)(&value))._002Ector();
					array8[7] = (Implicit)value;
					return array8;
				}
				case 13:
					RuntimeHelpers.RunClassConstructor((RuntimeTypeHandle)((XamlTypeInfoProvider)value).Activate_234_ObservableCollection());
					if ((int)/*Error near IL_0dcd: Stack underflow*/ != 0)
					{
						obj = 31;
						continue;
					}
					goto case 52;
				case 30:
					((XamlTypeInfoProvider)/*Error near IL_0e00: Stack underflow*/).Activate_239_ReferralRedeemOption();
					obj = 8;
					if (MainWindow._003C_003Ec__DisplayClass0_0.CheckConnectedSystem != null)
					{
						obj = 7;
					}
					continue;
				case 106:
					((XamlTypeInfoProvider)/*Error near IL_0e25: Stack underflow*/).Activate_246_ReferralDialog();
					value = 58;
					break;
				case 107:
					((ICollection<FilterDescription>)/*Error near IL_0e40: Stack underflow*/).Add((FilterDescription)((XamlTypeInfoProvider)value).Activate_247_UpdateMethodDialog());
					if ((int)/*Error near IL_0e45: Stack underflow*/ == 0)
					{
						obj = 2;
						if (Sessions.DesktopUser__BackingField != null)
						{
							obj = 1;
						}
						continue;
					}
					goto case 3;
				case 44:
					((XamlTypeInfoProvider)/*Error near IL_0e8d: Stack underflow*/).Activate_255_MicaBackdrop();
					obj = 11;
					continue;
				case 89:
				{
					AsyncRelayCommand<>[] array2 = new AsyncRelayCommand<>[1];
					value = null;
					((ICollection<PayMethodModel>)0).Add((PayMethodModel)(&value));
					((ICollection<ReferralEarningModel>)(object)array2).Add((ReferralEarningModel)(&value));
					((AsyncTaskMethodBuilder[])/*Error near IL_0ebf: Stack underflow*/)[(object)array2] = (AsyncTaskMethodBuilder)value;
					return (object)/*Error near IL_0ec0: Stack underflow*/;
				}
				case 48:
				case 90:
					((XamlTypeInfoProvider)/*Error near IL_0f04: Stack underflow*/).Activate_284_ScrollPresenter();
					obj = 12;
					if (XamlTypeInfoProvider._003C_003Ec.CombineTracer != null)
					{
						obj = 2;
					}
					continue;
				case 86:
					((XamlMetaDataProvider)((XamlTypeInfoProvider)value).Activate_296_CaseCollection())._002Ector();
					if ((int)/*Error near IL_0f35: Stack underflow*/ == 0)
					{
						obj = 76;
						if (((XamlUserType)XamlSystemBaseType.DecorateCentralVisitor)._provider == null)
						{
							obj = 51;
						}
						continue;
					}
					goto case 48;
				case 114:
					((XamlTypeInfoProvider)/*Error near IL_0f6c: Stack underflow*/).Activate_301_SelectorBarItem();
					obj = 55;
					if (((XamlUserType)XamlUserType._boxedType)._isArray == 0)
					{
						obj = 14;
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
					((XamlTypeInfoProvider)/*Error near IL_0f91: Stack underflow*/).Activate_306_PagerControlTemplateSettings();
					obj = 106;
					continue;
				case 18:
					((XamlTypeInfoProvider)/*Error near IL_0fa1: Stack underflow*/).Activate_307_WrapPanel();
					obj = 45;
					continue;
				case 52:
					if (((IXamlMetadataProvider)/*Error near IL_0fb8: Stack underflow*/).GetXamlType((string)((XamlTypeInfoProvider)value).Activate_310_WrapLayout()) != null)
					{
						obj = 104;
						continue;
					}
					goto case 26;
				case 80:
					((XamlTypeInfoProvider)/*Error near IL_0fcc: Stack underflow*/).Activate_312_TokenItem();
					obj = 44;
					if (((XamlUserType)XamlUserType._itemTypeName)._keyTypeName == null)
					{
						obj = 36;
					}
					continue;
				case 91:
					if ((int)((Thickness)((XamlTypeInfoProvider)value).Activate_319_SettingsCard()).Left == 0)
					{
						obj = 23;
						if (((XamlUserType)XamlUserType.Activator__BackingField).StaticInitializer__BackingField != null)
						{
							obj = 66;
						}
						continue;
					}
					goto case 24;
				case 54:
					((XamlTypeInfoProvider)/*Error near IL_1021: Stack underflow*/).Activate_326_ViewportBehavior();
					obj = 15;
					continue;
				case 49:
					((XamlTypeInfoProvider)/*Error near IL_1031: Stack underflow*/).Activate_329_DesktopCharacters();
					obj = 32;
					if (((XamlUserType)XamlUserType.CreateFromStringMethod__BackingField).BoxInstance__BackingField == null)
					{
						obj = 46;
					}
					continue;
				case 10:
					((XamlTypeInfoProvider)/*Error near IL_1065: Stack underflow*/).Activate_332_InstanceViewModel();
					obj = 28;
					if (((XamlMember)XamlMember._provider)._name != null)
					{
						obj = 75;
					}
					continue;
				case 45:
					((XamlTypeInfoProvider)/*Error near IL_108a: Stack underflow*/).Activate_339_Instance();
					obj = 28;
					continue;
				case 71:
					if (((EmptyObjectToObjectConverter)((XamlTypeInfoProvider)value).Activate_342_SettingsExpander()).EmptyValue == null)
					{
						obj = 111;
						continue;
					}
					goto case 6;
				case 83:
					if (((DoubleToObjectConverter)((XamlTypeInfoProvider)value).Activate_344_TreeViewNode()).TrueValue == null)
					{
						obj = 112;
						continue;
					}
					goto case 48;
				case 118:
				{
					StackPanel[] array6 = new StackPanel[2];
					value = null;
					((DoubleToObjectConverter)0).FalseValue = (object)(&value);
					((DoubleToObjectConverter)array6).NullValue = (object)(&value);
					((ContextNetGameExtensions[])/*Error near IL_1116: Stack underflow*/)[(object)array6] = (ContextNetGameExtensions)value;
					_003F val6 = /*Error near IL_1116: Stack underflow*/;
					value = null;
					((DoubleToObjectConverter)1).LessThan = (nint)(&value);
					((NullToObjectConverter)val6).NullValue = (object)(&value);
					((PageModel<>[])/*Error near IL_1137: Stack underflow*/)[/*Error near IL_1137: Stack underflow*/] = (PageModel<>)value;
					return (object)/*Error near IL_1138: Stack underflow*/;
				}
				case 5:
					((XamlTypeInfoProvider)value).StaticInitializer_21_BoolToBrushConverter();
					((Animation)/*Error near IL_1163: Stack underflow*/).EasingMode = (EasingMode?)/*Error near IL_1163: Stack underflow*/;
					if ((int)/*Error near IL_1168: Stack underflow*/ != 0)
					{
						obj = 116;
						if (((AccountViewModel)AccountViewModel.VerifyCodeDelayText__BackingField).InfoBarMessage__BackingField == null)
						{
							obj = 9;
						}
						continue;
					}
					goto case 33;
				case 29:
					((XamlTypeInfoProvider)value).StaticInitializer_26_OffsetAnimation();
					((Animation<string, Vector3>)/*Error near IL_11c0: Stack underflow*/).To = (string)/*Error near IL_11c0: Stack underflow*/;
					if ((int)/*Error near IL_11c5: Stack underflow*/ == 0)
					{
						obj = 36;
						continue;
					}
					goto case 20;
				case 15:
					((XamlTypeInfoProvider)/*Error near IL_11e3: Stack underflow*/).StaticInitializer_28_Animation();
					obj = 103;
					continue;
				case 7:
				{
					FileSystemEventArgs[] array5 = new FileSystemEventArgs[10];
					value = null;
					((ImplicitAnimation<string, Vector3>)0).ImplicitTarget = (string)(&value);
					((Animation)array5).Delay = (TimeSpan?)(object)(&value);
					((FileNotFoundException[])/*Error near IL_1234: Stack underflow*/)[(object)array5] = (FileNotFoundException)value;
					_003F val = /*Error near IL_1234: Stack underflow*/;
					value = null;
					((Animation)1).Repeat = (RepeatOption)(ref value);
					((Animation)val).DelayBehavior = (AnimationDelayBehavior)(ref value);
					((EntityGameModsHash[])/*Error near IL_1255: Stack underflow*/)[/*Error near IL_1255: Stack underflow*/] = (EntityGameModsHash)value;
					_003F val2 = /*Error near IL_1255: Stack underflow*/;
					value = null;
					((Animation<double?, double>)2).From = (double?)(object)(&value);
					((Animation<double?, double>)val2).To = (double?)(object)(&value);
					((ShadowJavaGame[])/*Error near IL_1276: Stack underflow*/)[/*Error near IL_1276: Stack underflow*/] = (ShadowJavaGame)value;
					_003F val3 = /*Error near IL_1276: Stack underflow*/;
					*(AsyncTaskMethodBuilder<>*)(&value) = default;
					Implicit.SetShowAnimations((UIElement)(object)3, (ImplicitAnimationSet)(object)(&value));
					Implicit.SetHideAnimations((UIElement)val3, (ImplicitAnimationSet)(object)(&value));
					((NavigationViewItemInvokedEventArgs[])/*Error near IL_1297: Stack underflow*/)[/*Error near IL_1297: Stack underflow*/] = (NavigationViewItemInvokedEventArgs)value;
					_003F val4 = /*Error near IL_1297: Stack underflow*/;
					value = (object)default(NavigationEventArgs);
					((TableView)4).SelectionUnit = (TableViewSelectionUnit)(ref value);
					((TableView)val4).AutoGenerateColumns = (byte)(&value) != 0;
					((SlideNavigationTransitionEffect[])/*Error near IL_12b8: Stack underflow*/)[/*Error near IL_12b8: Stack underflow*/] = (SlideNavigationTransitionEffect)value;
					_003F val5 = /*Error near IL_12b8: Stack underflow*/;
					value = null;
					((TableView)5).GridLinesVisibility = (TableViewGridLinesVisibility)(ref value);
					((TableView)val5).IsReadOnly = (byte)(&value) != 0;
					((EntityMassTopUp[])/*Error near IL_12d9: Stack underflow*/)[/*Error near IL_12d9: Stack underflow*/] = (EntityMassTopUp)value;
					/*Error near IL_12d9: Stack underflow*/;
					_ = 6;
					value = null;
					((Clipboard[])((TableViewColumn*)(&value))->Header)[((TableViewColumn*)(&value))->Width] = (Clipboard)value;
					_ = 7;
					value = null;
					((DirectoryInfo[])((TableViewColumn*)(&value))->MaxWidth)[((TableViewColumn*)(&value))->ActualWidth] = (DirectoryInfo)value;
					value = null;
					((ConnectedAnimationService[])((TableViewColumn*)(&value))->IsReadOnly)[(object)((TableViewColumn*)(&value))->HeaderStyle] = (ConnectedAnimationService)value;
					value = (object)default(ConnectedAnimation);
					((TableViewColumn)((TableViewColumn*)(&value))->HeaderControl).Visibility = (Visibility)(ref value);
					((KeyRoutedEventArgs[])8)[9] = (KeyRoutedEventArgs)value;
					return 8;
				}
				case 108:
					((XamlTypeInfoProvider)value).StaticInitializer_115_NavigationViewItem();
					((TableViewColumn)/*Error near IL_1386: Stack underflow*/).CanFilter = (byte)/*Error near IL_1386: Stack underflow*/ != 0;
					if ((int)/*Error near IL_138b: Stack underflow*/ == 0)
					{
						obj = 91;
						if ((int)((AccountViewModel._003CLoginHistoryAccount_003Ed__24*)AccountViewModel._003CLoginHistoryAccount_003Ed__24._003C_003E1__state)->_003C_003Et__builder != 0)
						{
							obj = 87;
						}
						continue;
					}
					goto case 24;
				case 96:
					((XamlTypeInfoProvider)/*Error near IL_13af: Stack underflow*/).StaticInitializer_120_IList();
					obj = 18;
					continue;
				case 12:
					((XamlTypeInfoProvider)/*Error near IL_13bf: Stack underflow*/).StaticInitializer_121_AppNavigationViewItemPresenter();
					obj = 80;
					continue;
				case 19:
					((XamlTypeInfoProvider)value).StaticInitializer_122_NavigationViewItemPresenter();
					((TableViewColumn)/*Error near IL_13d6: Stack underflow*/).ConditionalCellStyles = (IList<TableViewConditionalCellStyle>)/*Error near IL_13d6: Stack underflow*/;
					if ((int)/*Error near IL_13db: Stack underflow*/ == 0)
					{
						obj = 13;
						if (AccountViewModel._003CLoginHistoryAccount_003Ed__24.FilterModule != null)
						{
							obj = 4;
						}
						continue;
					}
					goto case 48;
				case 24:
				case 117:
					((XamlTypeInfoProvider)/*Error near IL_13ff: Stack underflow*/).StaticInitializer_127_IconVariant();
					obj = 93;
					continue;
				case 112:
					((XamlTypeInfoProvider)value).StaticInitializer_128_ItemsRepeater();
					if (!((TableViewColumn)/*Error near IL_1416: Stack underflow*/).IsAutoGenerated)
					{
						obj = 19;
						if (((AccountViewModel._003CLoginMobile_003Ed__88*)(int)AccountViewModel._003CLoginMobile_003Ed__88.type)->_003Ccookies_003E5__2 != null)
						{
							obj = 0;
						}
						continue;
					}
					goto case 48;
				case 53:
					((XamlTypeInfoProvider)value).StaticInitializer_133_StackLayout();
					((TableViewColumn)/*Error near IL_1446: Stack underflow*/).SortDirection = (SortDirection?)/*Error near IL_1446: Stack underflow*/;
					if ((int)/*Error near IL_144b: Stack underflow*/ != 0)
					{
						obj = 2;
						if (((AccountViewModel._003CLoginRandom_003Ed__85*)(nint)AccountViewModel._003CLoginMobile_003Ed__88.DecorateConvertibleConverter)->_003C_003E1__state == 0)
						{
							obj = 3;
						}
						continue;
					}
					goto case 82;
				case 111:
					((XamlTypeInfoProvider)value).StaticInitializer_137_DesktopGameCard();
					if (((TableViewColumn)/*Error near IL_1476: Stack underflow*/).ClipboardContentBinding == null)
					{
						obj = 100;
						continue;
					}
					goto case 6;
				case 95:
					((XamlTypeInfoProvider)value).StaticInitializer_141_MobileGameCard();
					if (((TableViewColumn)/*Error near IL_1491: Stack underflow*/).SortMemberPath != null)
					{
						obj = 14;
						if ((int)((AccountViewModel._003CLogoutAccount_003Ed__23*)AccountViewModel._003CLogoutAccount_003Ed__23._003C_003E1__state)->_003C_003Et__builder == 0)
						{
							obj = 22;
						}
						continue;
					}
					goto case 88;
				case 8:
					((XamlTypeInfoProvider)/*Error near IL_14ba: Stack underflow*/).StaticInitializer_145_UIElementExtensions();
					obj = 10;
					continue;
				case 102:
					((XamlTypeInfoProvider)/*Error near IL_14ca: Stack underflow*/).StaticInitializer_146_FluentIcon();
					obj = 118;
					continue;
				case 59:
					((XamlTypeInfoProvider)value).StaticInitializer_147_Icon();
					if (((SortDescription)/*Error near IL_14e1: Stack underflow*/).PropertyName == null)
					{
						((ICollection<SelectorBarItem>)/*Error near IL_0ecc: Stack underflow*/).Add((SelectorBarItem)((XamlTypeInfoProvider)value).Activate_270_ObservableCollection());
						if ((int)/*Error near IL_0ed1: Stack underflow*/ != 0)
						{
							obj = 117;
							continue;
						}
						goto case 108;
					}
					obj = 89;
					continue;
				case 6:
				case 23:
				case 34:
				case 60:
					((XamlTypeInfoProvider)/*Error near IL_14f5: Stack underflow*/).StaticInitializer_149_AttachedCardShadow();
					obj = 17;
					if (((AccountViewModel._003CRegisterRandom4399_003Ed__84)AccountViewModel._003CRegisterRandom4399_003Ed__84._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj = 25;
					}
					continue;
				case 66:
					((XamlTypeInfoProvider)value).StaticInitializer_152_ProgressRing();
					if (((FilterDescription)/*Error near IL_1521: Stack underflow*/).PropertyName == null)
					{
						value = 56;
						break;
					}
					goto case 24;
				case 20:
				case 41:
				case 51:
					((XamlTypeInfoProvider)/*Error near IL_1539: Stack underflow*/).StaticInitializer_154_NumberBox();
					obj = 2;
					if (((AccountViewModel._003CSendVerifyCode_003Ed__78)AccountViewModel._003CSendVerifyCode_003Ed__78._003C_003Et__builder)._003C_003E4__this != null)
					{
						obj = 49;
					}
					continue;
				case 55:
					((XamlTypeInfoProvider)/*Error near IL_155e: Stack underflow*/).StaticInitializer_157_INumberFormatter2();
					obj = 110;
					continue;
				case 76:
					((XamlTypeInfoProvider)value).StaticInitializer_160_GameProxyDialog();
					if (((TableView)/*Error near IL_1575: Stack underflow*/).ConditionalCellStyles == null)
					{
						obj = 62;
						continue;
					}
					goto case 48;
				case 81:
					((XamlTypeInfoProvider)value).StaticInitializer_162_ObservableCollection();
					if (!((TableView)/*Error near IL_1590: Stack underflow*/).ShowFilterItemsCount)
					{
						obj = 35;
						continue;
					}
					goto case 24;
				case 56:
					((XamlTypeInfoProvider)value).StaticInitializer_164_GameResourceModel();
					if (((TableView)/*Error near IL_15ab: Stack underflow*/).FilterHandler == null)
					{
						obj = 81;
						continue;
					}
					goto case 24;
				case 103:
					((XamlTypeInfoProvider)/*Error near IL_15bf: Stack underflow*/).StaticInitializer_166_IAsyncRelayCommand();
					obj = 29;
					if (((ImportAccountViewModel)ImportAccountViewModel.Step__BackingField).SelectedFileName__BackingField != null)
					{
						obj = 68;
					}
					continue;
				case 92:
					((XamlTypeInfoProvider)value).StaticInitializer_169_NavigationViewBackButtonVisible();
					((TableView)/*Error near IL_15eb: Stack underflow*/).HeaderRowHeight = (double)/*Error near IL_15eb: Stack underflow*/;
					if ((int)/*Error near IL_15f0: Stack underflow*/ == 0)
					{
						obj = 86;
						continue;
					}
					goto case 48;
				case 36:
					((XamlTypeInfoProvider)value).StaticInitializer_173_NavigationViewOverflowLabelMode();
					((TableView)/*Error near IL_1606: Stack underflow*/).HeaderRowMaxHeight = (double)/*Error near IL_1606: Stack underflow*/;
					if ((int)/*Error near IL_160b: Stack underflow*/ != 0)
					{
						obj = 20;
						continue;
					}
					goto case 77;
				case 47:
					((XamlTypeInfoProvider)value).StaticInitializer_175_NavigationViewShoulderNavigationEnabled();
					((TableView)/*Error near IL_1621: Stack underflow*/).HeaderRowMinHeight = (double)/*Error near IL_1621: Stack underflow*/;
					if ((int)/*Error near IL_1626: Stack underflow*/ != 0)
					{
						obj = 39;
						if (((ImportAccountViewModel)ImportAccountViewModel.ParseErrorMessage__BackingField).selectFileCommand == null)
						{
							obj = 13;
						}
						continue;
					}
					goto case 53;
				case 110:
					_ = new DateTimeOffset[8];
					_ = 0;
					value = null;
					((SessionContext<, >[])((TableView*)(&value))->RowMinHeight)[((TableView*)(&value))->ShowExportOptions ? 1u : 0u] = (SessionContext<, >)value;
					_ = 1;
					value = (object)default(SessionExtensions);
					((EntitySocks5[])((TableView*)(&value))->CanResizeColumns)[((TableView*)(&value))->CanSortColumns ? 1u : 0u] = (EntitySocks5)value;
					_ = 2;
					value = null;
					((JsonDocumentOptions[])((TableView*)(&value))->MinColumnWidth)[((TableView*)(&value))->MaxColumnWidth] = (JsonDocumentOptions)value;
					_ = 3;
					value = null;
					((IMobileGame[])((TableView*)(&value))->VerticalGridLinesStrokeThickness)[((TableView*)(&value))->HorizontalGridLinesStrokeThickness] = (IMobileGame)value;
					_ = 4;
					value = null;
					((DateTimeStyles[])(object)((TableView*)(&value))->HorizontalGridLinesStroke)[(object)((TableView*)(&value))->AlternateRowBackground] = (DateTimeStyles)value;
					value = null;
					((EventIrcSystemMessage[])(object)((TableView*)(&value))->RowContextFlyout)[(object)((TableView*)(&value))->CellContextFlyout] = (EventIrcSystemMessage)value;
					value = null;
					((EntityMassHtml[])(object)((TableView*)(&value))->CellStyle)[((TableView*)(&value))->VerticalOffset] = (EntityMassHtml)value;
					*(EnumMassContentType*)(&value) = default;
					((TableView)7).RowHeaderWidth = (nint)(&value);
					((TableView)6).RowHeaderMinWidth = (nint)(&value);
					((FORMATETC[])5)[6] = (FORMATETC)value;
					return 5;
				case 16:
					_ = new Connection[2];
					_ = 0;
					value = (object)default(HeypixelController);
					((UnhandledExceptionEventHandler[])((TableView*)(&value))->FrozenColumnCount)[((TableView*)(&value))->RowDetailsVisibilityMode] = (UnhandledExceptionEventHandler)value;
					value = (object)default(UnhandledErrorDetectedEventArgs);
					((EventConnectionConnect[])(object)((TableView*)(&value))->RowDetailsTemplateSelector)[((TableView*)(&value))->AreRowDetailsFrozen ? 1u : 0u] = (EventConnectionConnect)value;
					return 1;
				case 85:
					((XamlTypeInfoProvider)value).StaticInitializer_252_TitleBarTemplateSettings();
					((TableViewBoundColumn)/*Error near IL_1818: Stack underflow*/).ElementStyle = (Style)/*Error near IL_1818: Stack underflow*/;
					if ((int)/*Error near IL_181d: Stack underflow*/ != 0)
					{
						value = 27;
						break;
					}
					goto case 70;
				case 61:
					((XamlTypeInfoProvider)value).StaticInitializer_254_MainContent();
					((TableViewBoundColumn)/*Error near IL_1837: Stack underflow*/).EditingElementStyle = (Style)/*Error near IL_1837: Stack underflow*/;
					if ((int)/*Error near IL_183c: Stack underflow*/ != 0)
					{
						obj = 40;
						if (((DesktopViewModel)DesktopViewModel.refreshLanGameCommand).refreshNetGamesCommand != null)
						{
							obj = 2;
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
