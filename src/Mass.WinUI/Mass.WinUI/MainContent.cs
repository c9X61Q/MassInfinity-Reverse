using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using ABI.System.Collections.Generic;
using CommunityToolkit.WinUI.Controls;
using Mass.WinUI.Controls;
using Mass.WinUI.Mass_WinUI_XamlTypeInfo;
using Mass.WinUI.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.Xaml.Interactivity;
using WinRT;
using WinRT.Mass_WinUIGenericHelpers;
using WinRT.Mass_WinUIVtableClasses;

namespace Mass.WinUI;

[WinRTExposedType(typeof(Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class MainContent : UserControl, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private interface IMainContent_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IMainContent_BindingsScopeConnector
	{
		WeakReference Parent { get; set; }

		bool ContainsElement(int connectionId);

		void RegisterForElementConnection(int connectionId, IComponentConnector connector);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private static class XamlBindingSetters
	{
		internal static object PatchAdapter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Set_Microsoft_Xaml_Interactivity_InvokeCommandAction_CommandParameter(object obj, object value, object targetNullValue)
		{
			_FF00_FF00_FF00_FF00_FF00耀(obj, value, targetNullValue);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CheckVisualCalculator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static XamlBindingSetters ReflectScopeDictionary()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00稀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775372, new IntPtr(2737323016396L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00笀()
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00簀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775373, new IntPtr(2737323035116L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00紀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775370, new IntPtr(2737323035116L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00縀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00缀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775371, new IntPtr(2737323016396L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static void _FF00_FF00_FF00_FF00_FF00耀(object P_0, object P_1, object P_2)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_003f: Expected I4, but got Obj
			//IL_0099: Expected I, but got VT
			//IL_009f: Expected I4, but got Obj
			//IL_00a1: Expected Obj, but got I
			//IL_00b0: Expected Obj, but got I
			//IL_00d6: Expected Obj, but got I
			//IL_00b5->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005f->IL0026: Incompatible stack heights: 3 vs 1
			//IL_00db->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0084->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00c0->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006a->IL0026: Incompatible stack heights: 3 vs 1
			//IL_00e6->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008f->IL0026: Incompatible stack types: I4 vs Obj
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
				case 3:
					ExceptionHelpers.GetHRForException((Exception)P_1);
					_ = 3;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						_ = 4;
					}
					break;
				case 1:
					if (P_1 == null)
					{
						obj2 = 0;
						if (IList_object._initialized == 0)
						{
							obj2 = 0;
						}
						break;
					}
					goto case 3;
				case 2:
					P_1 = (nint)MarshalInspectable<object>.FromManaged(IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)typeof(MulticastDelegate).TypeHandle), (byte)(int)P_2 != 0);
					obj2 = 1;
					if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
					{
						obj2 = 3;
					}
					break;
				case 4:
					return;
				default:
					if (P_2 != null)
					{
						obj2 = 2;
						if (IReadOnlyList_object.ReflectLogicalAttribute == null)
						{
							obj2 = 2;
						}
						break;
					}
					goto case 3;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static void _FF00_FF00_FF00_FF00_FF00脀(object P_0, object P_1, object P_2)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775368, new IntPtr(2737323017436L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[WinRTExposedType(typeof(Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails))]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.Markup.IComponentConnector")]
	private class MainContent_obj1_Bindings : IComponentConnector, IMainContent_Bindings
	{
		private object dataRoot;

		private nint initialized;

		private object obj3;

		private static object ReflectStaticMonitor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe MainContent_obj1_Bindings()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			ExceptionHelpers.GetHRForException((Exception)(object)this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Connect(int connectionId, object target)
		{
			_FF00_FF00_FF00_FF00_FF00琀((uint)connectionId, target);
		}

		[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
		[DebuggerNonUserCode]
		public IComponentConnector GetBindingConnector(int connectionId, object target)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize()
		{
			_FF00_FF00_FF00_FF00_FF00欀();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			_FF00_FF00_FF00_FF00_FF00栀();
		}

		public void StopTracking()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisconnectUnloadedObject(int connectionId)
		{
			_FF00_FF00_FF00_FF00_FF00礀((uint)connectionId);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SetDataRoot(object newDataRoot)
		{
			return _FF00_FF00_FF00_FF00_FF00砀(newDataRoot) != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Activated(object obj, WindowActivatedEventArgs data)
		{
			_FF00_FF00_FF00_FF00_FF00漀(obj, data);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Loading(FrameworkElement src, object data)
		{
			_FF00_FF00_FF00_FF00_FF00焀(src, data);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update_(object obj, uint phase)
		{
			_FF00_FF00_FF00_FF00_FF00甀(obj, phase);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update_HamburgerView(object obj, uint phase)
		{
			_FF00_FF00_FF00_FF00_FF00樀(obj, phase);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ParseDictionary()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MainContent_obj1_Bindings DecorateConcreteEditor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00最()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775369, new IntPtr(2737323010156L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00栀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0037: Expected I4, but got Obj
			//IL_005d: Expected Obj, but got I
			//IL_0088->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0062->IL0026: Incompatible stack heights: 5 vs 1
			//IL_0093->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006d->IL0026: Incompatible stack heights: 5 vs 1
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
				case 2:
					return;
				case 1:
					_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
					_ = int.MinValue;
					_ = IEnumerator_object.Initialized;
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						_ = 0;
					}
					break;
				default:
					IList_object._initialized = 1;
					obj2 = 2;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj2 = 1;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00_FF00_FF00_FF00_FF00椀(object P_0, uint P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775382, new IntPtr(2737323039276L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00_FF00_FF00_FF00_FF00樀(object P_0, uint P_1)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0037: Expected I4, but got Obj
			//IL_0075: Expected I, but got Obj
			//IL_0075: Expected I, but got Obj
			//IL_0084: Expected Obj, but got I
			//IL_0058: Expected Obj, but got I
			//IL_0089->IL0026: Incompatible stack heights: 3 vs 1
			//IL_0094->IL0026: Incompatible stack heights: 3 vs 1
			//IL_005d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
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
				default:
					return;
				case 0:
					return;
				case 2:
					if ((P_1 & 0x80000001u) == 0)
					{
						return;
					}
					obj2 = 1;
					if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute == null)
					{
						obj2 = 0;
					}
					break;
				case 1:
					_ = IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized;
					IEnumerator_object.Do_Abi_MoveNext_2((nint)P_0, (byte*)unchecked((nint)null));
					_ = 0;
					if (IList_object.PatchAttribute == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00欀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0037: Expected I4, but got Obj
			//IL_006d: Expected I, but got Obj
			//IL_007c: Expected Obj, but got I
			//IL_0081->IL0026: Incompatible stack heights: 2 vs 1
			//IL_008c->IL0026: Incompatible stack heights: 2 vs 1
			//IL_005c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0067->IL0026: Incompatible stack types: I4 vs Obj
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
				default:
					return;
				case 0:
					return;
				case 2:
					if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						return;
					}
					obj2 = 1;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj2 = 1;
					}
					break;
				case 1:
					IEnumerator_object.Do_Abi_MoveNext_2((nint)/*Error near IL_006d: Stack underflow*/, (byte*)(nint)this);
					_ = 0;
					if (IList_object.PatchAttribute == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00氀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775383, new IntPtr(2737323035116L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00洀()
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
		internal unsafe void _FF00_FF00_FF00_FF00_FF00渀(object P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775380, new IntPtr(2737323035116L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00_FF00漀(object P_0, object P_1)
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			_003CModule_003E.CheckAccessibleAttribute();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00_FF00瀀(object P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775381, new IntPtr(2737323039276L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00_FF00焀(object P_0, object P_1)
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			_003CModule_003E.CheckAccessibleAttribute();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00_FF00爀(object P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775378, new IntPtr(2737323040316L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00猀(uint P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775379, new IntPtr(2737323012236L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00琀(uint P_0, object P_1)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0037: Expected I4, but got Obj
			//IL_007d: Expected Obj, but got I
			//IL_0052: Expected Obj, but got I
			//IL_0082->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0057->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0062->IL0026: Incompatible stack types: I4 vs Obj
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
				default:
					return;
				case 2:
					if (P_0 != 3)
					{
						return;
					}
					obj2 = 0;
					if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute != null)
					{
						obj2 = 1;
					}
					break;
				case 1:
					IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute = CastExtensions.As<AppNavigationViewItem>(P_1);
					obj2 = 0;
					if (IList_object.PatchAttribute != null)
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
		private unsafe void _FF00_FF00_FF00_FF00_FF00甀(object P_0, uint P_1)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_00ba: Expected I, but got Obj
			//IL_00c4->IL0026: Incompatible stack heights: 3 vs 1
			//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
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
				default:
					if ((P_1 & 0x80000001u) == 0)
					{
						obj2 = 4;
						continue;
					}
					break;
				case 4:
					return;
				case 3:
					_ = null;
					/*Error near IL_0084: Member reference must be method, but was: Field*/;
				case 1:
					break;
				case 2:
					return;
				case 5:
					return;
				}
				IEnumerator_object.Do_Abi_get_HasCurrent_1((nint)IList_object.PatchAttribute, (byte*)(int)P_1);
				_ = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00瘀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe byte _FF00_FF00_FF00_FF00_FF00眀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775376, new IntPtr(2737323039276L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe byte _FF00_FF00_FF00_FF00_FF00砀(object P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0037: Expected I4, but got Obj
			//IL_0057: Expected Obj, but got I
			//IL_0080: Expected Obj, but got I
			//IL_005c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0067->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0085->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0090->IL0026: Incompatible stack types: I4 vs Obj
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
					((AsyncVoidMethodBuilder*)/*Error near IL_0043: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)this, ref *(App._003CLogout_003Ed__15*)P_0);
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = (object)/*Error near IL_0048: Stack underflow*/;
					obj2 = 1;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						obj2 = 2;
					}
					break;
				case 2:
					return 1;
				case 1:
					if (P_0 == null)
					{
						return 0;
					}
					obj2 = 0;
					if (IList_object.PatchAttribute == null)
					{
						obj2 = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00礀(uint P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			throw new IEnumeratorMethods<object>((IntPtr)/*Error near IL_001e: Stack underflow*/, ref *(object[]*)_003CModule_003E.CheckAccessibleAttribute());
		}
	}

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object HamburgerView;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object Home;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object Desktop;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object Mobile;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object Account;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object Instance;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object Chat;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object Settings;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object AppFrame;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private nint _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object Bindings;

	private static object DecorateSimpleEditor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe MainContent()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_005a: Expected I, but got Obj
		//IL_0069: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		int num = ExceptionHelpers.GetHRForException((Exception)(object)this);
		int num2 = 0;
		if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
		{
			num2 = 0;
		}
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			}
			num = (int)IEnumerator_object.Do_Abi_MoveNext_2((nint)num, (byte*)(nint)this);
			num2 = 1;
			if (IList_object.PatchAttribute != null)
			{
				num2 = 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00伀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	public void Connect(int connectionId, object target)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00唀((uint)connectionId, target);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		return (IComponentConnector)_FF00_FF00_FF00_FF00_FF00_FF00_FF00堀((uint)connectionId, target);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateControllableSystem()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MainContent ReflectTransferableRole()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00一()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775365, new IntPtr(2737323035116L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00伀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0090: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I
		//IL_0085->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0067->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00fc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0026: Incompatible stack types: I4 vs Obj
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
			case 1:
				if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					return;
				}
				obj2 = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				base((object[])obj, 0);
				obj2 = 3;
				break;
			case 3:
				return;
			case 4:
				obj = new MarshalInspectable<object>((object)IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_008b: Stack underflow*/, (uint)/*Error near IL_008b: Stack underflow*/, (nint)/*Error near IL_008b: Stack underflow*/, (uint*)/*Error near IL_008b: Stack underflow*/));
				obj2 = 1;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
				{
					obj2 = 2;
				}
				break;
			case 5:
				return;
			default:
				IReadOnlyList_object._initialized = 1;
				obj2 = 4;
				if (IEnumerator_System_IDisposable._initialized == 0)
				{
					obj2 = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00倀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775362, new IntPtr(2737323024716L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00儀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775363, new IntPtr(2737323028876L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00刀()
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
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00匀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775360, new IntPtr(2737323022636L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00吀(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775361, new IntPtr(2737323024716L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00唀(uint P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_007f: Expected I4, but got Obj
		//IL_017f: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I
		//IL_020b: Expected Obj, but got I4
		//IL_0154: Expected Obj, but got I
		//IL_0184->IL0026: Incompatible stack types: I4 vs Obj
		//IL_022b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_026c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ec->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01e9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0115->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01be->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0215->IL0026: Incompatible stack types: I4 vs Obj
		//IL_024b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_018f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01f4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0159->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01c9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0256->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0164->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 15;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 20:
				((AsyncVoidMethodBuilder*)/*Error near IL_008b: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)this, ref *(App._003CLogout_003Ed__15*)P_1);
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = (object)/*Error near IL_0090: Stack underflow*/;
				obj2 = 17;
				continue;
			case 10:
				goto IL_00d6;
			case 13:
				goto IL_00ff;
			case 15:
				switch (P_0)
				{
				case 11u:
					break;
				case 7u:
					goto IL_00d6;
				case 4u:
					goto IL_00ff;
				default:
					goto IL_0145;
				case 8u:
					goto IL_0164;
				case 9u:
					goto IL_019e;
				case 5u:
					goto IL_01c9;
				case 3u:
					goto IL_0204;
				case 2u:
					goto IL_0215;
				case 10u:
					goto IL_022b;
				case 6u:
					goto end_IL_0026;
				}
				goto case 20;
			case 3:
				goto IL_0164;
			case 16:
				goto IL_019e;
			case 12:
				goto IL_01c9;
			case 5:
				return;
			default:
				goto IL_0204;
			case 4:
				goto IL_0215;
			case 18:
				goto IL_022b;
			case 7:
				break;
				IL_022b:
				((AsyncTaskMethodBuilder*)this)->Start(ref *(AccountViewModel._003CLogoutAccount_003Ed__23*)P_1);
				Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute = (object)/*Error near IL_0237: Stack underflow*/;
				obj2 = 8;
				if (Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute == null)
				{
					obj2 = 2;
				}
				continue;
				IL_0145:
				obj2 = 4;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
				{
					obj2 = 14;
				}
				continue;
				IL_0215:
				((AsyncTaskMethodBuilder*)this)->Start(ref *(AccountViewModel._003CCreateAccount_003Ed__21*)P_1);
				Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute = (object)/*Error near IL_0221: Stack underflow*/;
				obj2 = 2;
				continue;
				IL_0204:
				Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute = 1;
				obj2 = 5;
				continue;
				IL_01c9:
				IEnumerable_object.ReflectSetAttribute = ((XamlUserType)this).BoxType<double>(P_1);
				obj2 = 0;
				if (Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute == null)
				{
					obj2 = 0;
				}
				continue;
				IL_00ff:
				IList_object.PatchAttribute = CastExtensions.As<InvokeCommandAction>(P_1);
				obj2 = 9;
				continue;
				IL_019e:
				IEnumerator_System_IDisposable.ReflectTransferableAttribute = ((XamlUserType)this).BoxType<EasingMode>(P_1);
				obj2 = 1;
				if (IEnumerable_System_IDisposable.CombineAttribute != null)
				{
					obj2 = 0;
				}
				continue;
				IL_00d6:
				IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute = CastExtensions.As<AppNavigationViewItem>(P_1);
				obj2 = 11;
				continue;
				IL_0164:
				IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = CastExtensions.As<Segmented>(P_1);
				obj2 = 2;
				if (IReadOnlyList_object.ReflectLogicalAttribute == null)
				{
					obj2 = 6;
				}
				continue;
				end_IL_0026:
				break;
			}
			((AsyncTaskMethodBuilder*)this)->Start(ref *(AccountViewModel._003CImportAccounts_003Ed__28*)P_1);
			Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute = (object)/*Error near IL_0262: Stack underflow*/;
			obj2 = 19;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00嘀(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775374, new IntPtr(2737323039276L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00圀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed object _FF00_FF00_FF00_FF00_FF00_FF00_FF00堀(uint P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0052: Expected Obj, but got I
		//IL_006d: Expected I, but got Obj
		//IL_007b: Expected I, but got Obj
		//IL_007b: Expected I, but got Obj
		//IL_0096: Expected I, but got Obj
		//IL_0057->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00aa->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00c9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0062->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b5->IL0026: Incompatible stack heights: 2 vs 1
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
			case 1:
				obj = null;
				obj2 = 0;
				if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute != null)
				{
					obj2 = 0;
				}
				break;
			case 3:
				obj = new IEnumerator_object((nint)/*Error near IL_006d: Stack underflow*/, (byte*)(nint)(ValueType)P_1);
				obj = obj;
				IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_007b: Stack underflow*/, (uint)/*Error near IL_007b: Stack underflow*/, (nint)obj, (uint*)(nint)this);
				IList_object.PatchAttribute = obj;
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1(new MarshalInspectable<object>(obj, (byte)(delegate* unmanaged[Stdcall]<nint, byte*, uint>)(&IEnumerator_object.Do_Abi_get_HasCurrent_1) != 0));
				_ = 2;
				if (IReadOnlyList_object._initialized == 0)
				{
					_ = 0;
				}
				break;
			case 2:
				return obj;
			default:
				if (P_0 == 1)
				{
					obj2 = 3;
					break;
				}
				goto case 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed object _FF00_FF00_FF00_FF00_FF00_FF00_FF00夀(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775375, new IntPtr(2737323039276L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
