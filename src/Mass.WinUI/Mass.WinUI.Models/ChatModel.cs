using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using ABI.System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using WinRT;
using WinRT.Mass_WinUIGenericHelpers;
using WinRT.Mass_WinUIVtableClasses;

namespace Mass.WinUI.Models;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails))]
public class ChatModel : ObservableObject
{
	internal static ChatModel CheckOperationalArgument;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00輀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00鄀(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public bool IsMyself
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00销() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00褀(value ? ((byte)1) : ((byte)0));
		}
	}

	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public string Message
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00踀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00谀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe ChatModel()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		ExceptionHelpers.GetHRForException((Exception)(object)this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckVirtualSummarizer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ChatModel DecorateIdentifiableProgram()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00蠀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778927, new IntPtr(2737336206332L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00褀(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00c0: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I
		//IL_004f: Expected I, but got Obj
		//IL_0096: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I
		//IL_00d4->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00aa->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00df->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00b5->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 4;
				break;
			case 3:
				/*Error near IL_0059: Member reference must be method, but was: Field*/;
			case 1:
				return;
			case 4:
				IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute = P_0;
				obj2 = 0;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
				{
					obj2 = 0;
				}
				break;
			default:
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
				_ = 1;
				if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00言(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778924, new IntPtr(2737336200092L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00謀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778925, new IntPtr(2737336198012L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00谀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0053: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_007a: Expected I, but got Obj
		//IL_00a4: Expected I, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_00c4->IL0099: Incompatible stack heights: 2 vs 0
		//IL_0067->IL0026: Incompatible stack heights: 2 vs 1
		//IL_008e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ae->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00d8->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0072->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0099->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e3->IL0026: Incompatible stack heights: 3 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
			case 3:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 1;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 2;
				}
				break;
			case 0:
				return;
			case 2:
				return;
			case 4:
				IList_object._initialized = (nint)P_0;
				obj2 = 3;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					obj2 = 3;
				}
				break;
			case 5:
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute);
				_ = 4;
				break;
			case 1:
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00b3: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00b3: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_00b3: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)/*Error near IL_00b3: Stack underflow*/);
				_ = IReadOnlyList_object._initialized;
				if (MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)P_0) != (IntPtr)0)
				{
					_ = 0;
					if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
					{
						_ = 0;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00贀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778922, new IntPtr(2737336206332L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00踀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00輀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00退()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778923, new IntPtr(2737336198012L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00鄀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00a6: Expected I, but got Obj
		//IL_0075: Expected I, but got Obj
		//IL_0075: Expected I4, but got Obj
		//IL_004b: Expected I, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_00df->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0089->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00bf->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0094->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ca->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
				obj2 = 2;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					obj2 = 2;
				}
				break;
			case 2:
				((ValueTuple<int, nint>*)/*Error near IL_0075: Stack underflow*/)->_002Ector((int)this, (nint)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute);
				obj2 = 3;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 2;
				}
				break;
			case 3:
				return;
			case 1:
				if (IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00a6: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)MarshalInspectable<object>.FromManaged((object)/*Error near IL_009a: Stack underflow*/, (byte)/*Error near IL_009a: Stack underflow*/ != 0), (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)IReadOnlyList_System_IDisposable._initialized, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)P_0))
				{
					return;
				}
				obj2 = 0;
				if (IReadOnlyList_object.ReflectLogicalAttribute == null)
				{
					obj2 = 0;
				}
				break;
			default:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00d5: Stack underflow*/, (INotifyPropertyChanged)this, ref *(uint*)IEnumerator_System_IDisposable._initialized);
				_ = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00鈀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778920, new IntPtr(2737336208412L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00錀()
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
	internal unsafe static object _FF00_FF00_FF00_FF00鐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778921, new IntPtr(2737336201132L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00销()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00阀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}
}
