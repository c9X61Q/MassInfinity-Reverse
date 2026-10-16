using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using ABI.System.Collections.Generic;
using CommunityToolkit.WinUI.Animations;
using Mass.WinUI.Controls;
using Mass.WinUI.Mass_WinUI_XamlTypeInfo;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Markup;
using WinRT;
using WinRT.Mass_WinUIGenericHelpers;
using WinRT.Mass_WinUIVtableClasses;
using WinUI.TableView;

namespace Mass.WinUI.Pages;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mass_WinUI_Pages_MobileWinRTTypeDetails))]
public class Chat : Page, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private interface IChat_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IChat_BindingsScopeConnector
	{
		WeakReference Parent { get; set; }

		bool ContainsElement(int connectionId);

		void RegisterForElementConnection(int connectionId, IComponentConnector connector);
	}

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	private static class XamlBindingSetters
	{
		private static object DecorateScheduledProgram;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Set_Microsoft_Xaml_Interactivity_InvokeCommandAction_CommandParameter(object obj, object value, object targetNullValue)
		{
			_FF00_FF00_FF00_FF00缀(obj, value, targetNullValue);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SortArgument()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static XamlBindingSetters DecorateAutomatedAuditor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00稀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778858, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00笀()
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
		internal unsafe static object _FF00_FF00_FF00_FF00簀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778859, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00紀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778856, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00縀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static void _FF00_FF00_FF00_FF00缀(object P_0, object P_1, object P_2)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0088: Expected I, but got VT
			//IL_009f: Expected Obj, but got I
			//IL_005d: Expected Obj, but got I
			//IL_00c4: Expected Obj, but got I
			//IL_00a4->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00af->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0062->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00c9->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00d4->IL0026: Incompatible stack types: I4 vs Obj
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
				case 3:
					if (P_2 != null)
					{
						obj2 = 0;
						if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute != null)
						{
							obj2 = 1;
						}
						break;
					}
					goto default;
				default:
					/*Error near IL_006f: Member reference must be method, but was: Field*/;
				case 1:
					*((int, nint)*)(nint)/*Error near IL_0088: Stack underflow*/ = ((int)/*Error near IL_0088: Stack underflow*/, (nint)typeof(UserControl).TypeHandle);
					P_1 = MarshalInspectable<object>.FromAbiArray(P_2);
					obj2 = 0;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
					{
						obj2 = 0;
					}
					break;
				case 5:
					if (P_1 != null)
					{
						obj2 = 4;
						if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
						{
							obj2 = 0;
						}
						break;
					}
					goto case 3;
				case 2:
					return;
				}
			}
		}
	}

	[DebuggerNonUserCode]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.Markup.IComponentConnector")]
	[WinRTExposedType(typeof(Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails))]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private class Chat_obj1_Bindings : IComponentConnector, IChat_Bindings
	{
		private object dataRoot;

		private nint initialized;

		private object obj9;

		private static object ReflectPassiveDecider;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe Chat_obj1_Bindings()
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
			_FF00_FF00_FF00_FF00昀((uint)connectionId, target);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
		public IComponentConnector GetBindingConnector(int connectionId, object target)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize()
		{
			_FF00_FF00_FF00_FF00礀();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			_FF00_FF00_FF00_FF00樀();
		}

		public void StopTracking()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisconnectUnloadedObject(int connectionId)
		{
			_FF00_FF00_FF00_FF00甀((uint)connectionId);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SetDataRoot(object newDataRoot)
		{
			return _FF00_FF00_FF00_FF00焀(newDataRoot) != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Activated(object obj, WindowActivatedEventArgs data)
		{
			_FF00_FF00_FF00_FF00瀀(obj, data);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Loading(FrameworkElement src, object data)
		{
			_FF00_FF00_FF00_FF00栀(src, data);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update_(object obj, uint phase)
		{
			_FF00_FF00_FF00_FF00渀(obj, phase);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update_Scroller(object obj, uint phase)
		{
			_FF00_FF00_FF00_FF00眀(obj, phase);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DecorateExternalList()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Chat_obj1_Bindings DecorateOperationalRecord()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00_FF00_FF00_FF00攀(uint P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778857, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00_FF00_FF00_FF00昀(uint P_0, object P_1)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0037: Expected I4, but got Obj
			//IL_0058: Expected Obj, but got I
			//IL_007f: Expected Obj, but got I
			//IL_005d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0084->IL0026: Incompatible stack types: I4 vs Obj
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
				case 2:
					return;
				default:
					((AsyncVoidMethodBuilder*)/*Error near IL_0044: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)this, ref *(App._003CLogout_003Ed__15*)P_1);
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = (object)/*Error near IL_0049: Stack underflow*/;
					obj2 = 2;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						obj2 = 1;
					}
					break;
				case 1:
					if (P_0 != 9)
					{
						return;
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
		internal unsafe sealed void _FF00_FF00_FF00_FF00最(uint P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778870, new IntPtr(2737336193852L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00栀(object P_0, object P_1)
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			_003CModule_003E.CheckAccessibleAttribute();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00椀(object P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778871, new IntPtr(2737336163692L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00_FF00_FF00_FF00樀()
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
					_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
					_ = int.MinValue;
					_ = IEnumerator_object.Initialized;
					_ = 1;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
					{
						_ = 0;
					}
					break;
				case 1:
					IList_object._initialized = 1;
					obj2 = 0;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj2 = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00_FF00_FF00_FF00欀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778868, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00氀()
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
		private unsafe void _FF00_FF00_FF00_FF00洀(object P_0, uint P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778869, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00_FF00_FF00_FF00渀(object P_0, uint P_1)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_003f: Expected I4, but got Obj
			//IL_0086: Expected I, but got Obj
			//IL_0086: Expected I4, but got Obj
			//IL_006f: Expected Obj, but got I
			//IL_0074->IL0026: Incompatible stack heights: 5 vs 1
			//IL_00b5->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0095->IL0026: Incompatible stack types: I4 vs Obj
			//IL_007f->IL0026: Incompatible stack heights: 5 vs 1
			//IL_00c0->IL0026: Incompatible stack types: I4 vs Obj
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
					return;
				case 1:
					return;
				case 4:
					_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
					_ = IEnumerator_object.Initialized;
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
					{
						_ = 0;
					}
					break;
				case 3:
					*((int, nint)*)(nint)/*Error near IL_0086: Stack underflow*/ = ((int)P_0, unchecked((nint)null));
					if ((int)/*Error near IL_008b: Stack underflow*/ == 0)
					{
						return;
					}
					obj2 = 2;
					break;
				case 2:
					if ((P_1 & 0x80000001u) == 0)
					{
						obj2 = 1;
						if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
						{
							obj2 = 0;
						}
						break;
					}
					goto case 4;
				case 0:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00漀(object P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778866, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00瀀(object P_0, object P_1)
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			_003CModule_003E.CheckAccessibleAttribute();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe byte _FF00_FF00_FF00_FF00焀(object P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_003b: Expected I4, but got Obj
			//IL_008f: Expected Obj, but got I
			//IL_0064: Expected Obj, but got I
			//IL_0094->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0069->IL0026: Incompatible stack types: I4 vs Obj
			//IL_009f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0074->IL0026: Incompatible stack types: I4 vs Obj
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
				case 2:
					if (P_0 == null)
					{
						obj2 = 1;
						if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute == null)
						{
							obj2 = 1;
						}
						break;
					}
					goto case 3;
				case 3:
					IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute = CastExtensions.As<AppNavigationViewItem>(P_0);
					obj2 = 0;
					if (IList_object.PatchAttribute != null)
					{
						obj2 = 0;
					}
					break;
				default:
					return 1;
				case 1:
					return 0;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe byte _FF00_FF00_FF00_FF00爀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778867, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00猀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00琀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778864, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00_FF00_FF00_FF00甀(uint P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			throw new IEnumeratorMethods<object>((IntPtr)/*Error near IL_001e: Stack underflow*/, ref *(object[]*)_003CModule_003E.CheckAccessibleAttribute());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00_FF00_FF00_FF00瘀(uint P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778865, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00_FF00_FF00_FF00眀(object P_0, uint P_1)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0037: Expected I4, but got Obj
			//IL_0075: Expected I, but got Obj
			//IL_0075: Expected I, but got Obj
			//IL_0084: Expected Obj, but got I
			//IL_0057: Expected Obj, but got I
			//IL_0089->IL0026: Incompatible stack heights: 3 vs 1
			//IL_0094->IL0026: Incompatible stack heights: 3 vs 1
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
				case 2:
					if ((P_1 & 0x80000001u) == 0)
					{
						return;
					}
					obj2 = 1;
					if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute != null)
					{
						obj2 = 1;
					}
					break;
				case 0:
					return;
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
		private unsafe void _FF00_FF00_FF00_FF00砀(object P_0, uint P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778878, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00_FF00_FF00_FF00礀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_003b: Expected I4, but got Obj
			//IL_0095: Expected I, but got Obj
			//IL_009f->IL0026: Incompatible stack heights: 2 vs 1
			//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006a->IL0026: Incompatible stack types: I4 vs Obj
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
				case 2:
					if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj2 = 0;
						if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
						{
							obj2 = 1;
						}
						continue;
					}
					break;
				case 1:
					return;
				case 3:
					return;
				}
				IEnumerator_object.Do_Abi_get_Current_0((nint)/*Error near IL_0095: Stack underflow*/, (nint*)(nint)this);
				_ = 3;
			}
		}
	}

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object ShowTransitions;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object Scroller;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private nint _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object Bindings;

	private static object CheckEditableSynchronizer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe Chat()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_006f: Expected I4, but got Obj
		//IL_0058: Expected Obj, but got I
		//IL_0083->IL002d: Incompatible stack heights: 1 vs 2
		//IL_005d->IL002d: Incompatible stack heights: 4 vs 2
		//IL_008e->IL002d: Incompatible stack heights: 1 vs 2
		//IL_0068->IL002d: Incompatible stack heights: 4 vs 2
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		int hRForException = ExceptionHelpers.GetHRForException((Exception)(object)this);
		while (true)
		{
			switch (2)
			{
			default:
				return;
			case 2:
				_ = IEnumerator_object.Initialized;
				_ = 1;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					_ = 1;
				}
				break;
			case 1:
				*(ValueTuple<int, nint>*)hRForException = ((int)this, 1);
				_ = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
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
	private void MessageInputKeyDown(object sender, object e)
	{
		_FF00_FF00_FF00ꔀ(sender, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	public void InitializeComponent()
	{
		_FF00_FF00_FF00관();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	public void Connect(int connectionId, object target)
	{
		_FF00_FF00_FF00넀((uint)connectionId, target);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		return (IComponentConnector)_FF00_FF00_FF00글((uint)connectionId, target);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectLogicalEditor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Chat CheckSimpleSystem()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00ꐀ(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778850, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00ꔀ(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_004f: Expected I4, but got Obj
		//IL_00b3: Expected I, but got Obj
		//IL_0115: Expected I4, but got Obj
		//IL_012b: Expected Obj, but got I
		//IL_009d: Expected I, but got Obj
		//IL_0101: Expected I, but got Obj
		//IL_010a: Expected Obj, but got I4
		//IL_0087: Expected I, but got Obj
		//IL_0087: Expected Obj, but got I4
		//IL_0130->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ad->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00ea->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010f->IL0022: Incompatible stack heights: 1 vs 0
		//IL_00ce->IL0026: Incompatible stack types: I4 vs Obj
		//IL_013b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0096->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 4:
					return;
				case 6:
					return;
				case 3:
					return;
				case 7:
					obj((object[])IEnumerator_object.Init(), unchecked((nint)null));
					if ((int)/*Error near IL_008c: Stack underflow*/ == 0)
					{
						obj2 = 4;
						break;
					}
					goto case 8;
				case 8:
					IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_009d: Stack underflow*/, (uint)/*Error near IL_009d: Stack underflow*/, (nint)/*Error near IL_009d: Stack underflow*/, (uint*)(nint)obj);
					MarshalInspectable<object>.FromAbiArray((object)null);
					_ = 6;
					break;
				case 2:
					if ((nint)IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)P_1) == 13)
					{
						goto end_IL_0026;
					}
					obj2 = 0;
					if (IReadOnlyList_System_IDisposable._initialized != 0)
					{
						obj2 = 1;
					}
					break;
				default:
					if (obj == null)
					{
						return;
					}
					obj2 = 7;
					break;
				case 1:
					return;
				case 5:
					obj = IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)/*Error near IL_0115: Stack underflow*/, (uint)(int)this) as Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails;
					obj2 = 0;
					if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
					{
						obj2 = 0;
					}
					break;
				}
				continue;
				end_IL_0026:
				break;
			}
			IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_0101: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_0101: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)P_1, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)1);
			obj = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00ꘀ(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778851, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_A700()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00ꠀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778848, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00꤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778849, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00ꨀ()
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
	internal unsafe static object _FF00_FF00_FF00_AB00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778862, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00관()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_007a: Expected Obj, but got VT
		//IL_008c: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I
		//IL_0084->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c9->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00d4->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00a0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ab->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006e->IL0026: Incompatible stack types: I4 vs Obj
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
			case 4:
				if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					obj2 = 2;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj2 = 3;
					}
					break;
				}
				IList_object.PatchAttribute = 1;
				obj2 = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
				{
					obj2 = 0;
				}
				break;
			default:
				obj = ((int)/*Error near IL_0078: Stack underflow*/, (int)IEnumerator_object.Do_Abi_MoveNext_2((nint)/*Error near IL_0073: Stack underflow*/, (byte*)/*Error near IL_0073: Stack underflow*/));
				obj2 = 2;
				break;
			case 3:
				return;
			case 1:
				return;
			case 2:
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)0);
				_ = 1;
				if (IReadOnlyList_object._initialized == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed object _FF00_FF00_FF00글(uint P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0070: Expected I, but got Obj
		//IL_007e: Expected I, but got Obj
		//IL_007e: Expected I, but got Obj
		//IL_0099: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got I
		//IL_00a7->IL0022: Incompatible stack heights: 1 vs 0
		//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0065->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00cd->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 3:
					return obj;
				case 2:
					obj = null;
					obj2 = 0;
					if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute != null)
					{
						obj2 = 1;
					}
					continue;
				case 1:
					if (P_0 == 1)
					{
						obj2 = 0;
						if (IReadOnlyList_object._initialized == 0)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 3;
				}
				break;
			}
			obj = new IEnumerator_object((nint)/*Error near IL_0070: Stack underflow*/, (byte*)(nint)(ValueType)P_1);
			obj = obj;
			IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_007e: Stack underflow*/, (uint)/*Error near IL_007e: Stack underflow*/, (nint)obj, (uint*)(nint)this);
			IList_object.PatchAttribute = obj;
			IEnumeratorMethods<object>.Abi_get_HasCurrent_1(new MarshalInspectable<object>(obj, (byte)(delegate* unmanaged[Stdcall]<nint, byte*, uint>)(&IEnumerator_object.Do_Abi_get_HasCurrent_1) != 0));
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed object _FF00_FF00_FF00꼀(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778863, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00뀀(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778860, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00넀(uint P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0057: Expected I4, but got Obj
		//IL_00fb: Expected I, but got Obj
		//IL_009f: Expected I, but got Obj
		//IL_00ca: Expected I, but got Obj
		//IL_0072: Expected Obj, but got I
		//IL_0093->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0114->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00b3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00de->IL0026: Incompatible stack types: I4 vs Obj
		//IL_011f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0077->IL0026: Incompatible stack types: I4 vs Obj
		//IL_016e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00be->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0199->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0082->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0179->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 6;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 5:
				if (P_0 != 7)
				{
					obj2 = 1;
					if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute != null)
					{
						obj2 = 10;
					}
					break;
				}
				goto case 7;
			default:
				IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized = 1;
				obj2 = 3;
				break;
			case 7:
				IList_object._initialized = (nint)CastExtensions.As<NavigationView>(P_1);
				obj2 = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 4;
				}
				break;
			case 9:
				IReadOnlyList_System_IDisposable._initialized = (nint)CastExtensions.As<ImplicitAnimationSet>(P_1);
				obj2 = 1;
				if (IReadOnlyList_object._initialized == 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				MarshalInterface<INotifyPropertyChanged>.FromAbiArray((object)new IReadOnlyListMethods<INotifyPropertyChanged>((IntPtr)((XamlUserType)/*Error near IL_00ef: Stack underflow*/).BoxType<SortDirection>(P_1), (INotifyPropertyChanged)this, ref *(uint*)(delegate* unmanaged[Stdcall]<nint, uint, nint*, uint>)(&IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0)));
				_ = 0;
				if (IEnumerable_object._initialized == 0)
				{
					_ = 0;
				}
				break;
			case 3:
				return;
			case 6:
				if (P_0 != 2)
				{
					obj2 = 5;
					if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute != null)
					{
						obj2 = 5;
					}
					break;
				}
				goto case 9;
			case 10:
				if (P_0 != 8)
				{
					obj2 = 8;
					break;
				}
				goto case 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00눀(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778861, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
