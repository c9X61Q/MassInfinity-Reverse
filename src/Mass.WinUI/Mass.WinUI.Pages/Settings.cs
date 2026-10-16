using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using System.Threading;
using ABI.Microsoft.UI.Composition;
using ABI.Microsoft.UI.Xaml;
using ABI.Microsoft.UI.Xaml.Controls;
using ABI.System.Collections;
using ABI.System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.WinUI.Animations;
using CommunityToolkit.WinUI.Controls;
using Mass.Application.Desktop;
using Mass.Domain.Desktop.Entities.NetGame;
using Mass.WinUI.Controls;
using Mass.WinUI.Helpers;
using Mass.WinUI.Mass_WinUI_XamlTypeInfo;
using Mass.WinUI.Models;
using Mass.WinUI.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.Xaml.Interactivity;
using WinRT;
using WinRT.Mass_WinUIGenericHelpers;
using WinRT.Mass_WinUIVtableClasses;

namespace Mass.WinUI.Pages;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mass_WinUI_Pages_MobileWinRTTypeDetails))]
public sealed class Settings : Page, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private interface ISettings_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface ISettings_BindingsScopeConnector
	{
		WeakReference Parent { get; set; }

		bool ContainsElement(int connectionId);

		void RegisterForElementConnection(int connectionId, IComponentConnector connector);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private static class XamlBindingSetters
	{
		internal static object ReceiveClient;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Set_Microsoft_UI_Xaml_Controls_Control_IsEnabled(object obj, bool value)
		{
			_FF00_FF00_FF00_FF00_3000(obj, value ? ((byte)1) : ((byte)0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DecorateScalableAggregator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static XamlBindingSetters CallTracker()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00Ⰰ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778729, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00ⴀ()
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_2E00()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static void _FF00_FF00_FF00_FF00_2F00(object P_0, byte P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778742, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static void _FF00_FF00_FF00_FF00_3000(object P_0, byte P_1)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0040: Expected Obj, but got I4
			//IL_0054->IL0026: Incompatible stack heights: 3 vs 1
			//IL_005f->IL0026: Incompatible stack heights: 3 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					ExceptionHelpers.GetHRForException((Exception)P_1);
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static void _FF00_FF00_FF00_FF00_3100(object P_0, byte P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778743, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[WinRTExposedType(typeof(Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails))]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.Markup.IComponentConnector")]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private class Settings_obj1_Bindings : IComponentConnector, ISettings_Bindings
	{
		private delegate void InvokeFunctionDelegate(int phase);

		[DebuggerNonUserCode]
		[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
		private class Settings_obj1_BindingsTracking
		{
			private WeakReference<Settings_obj1_Bindings> weakRefToBindingObj;

			private object cache_UseGlobalProxy;

			private long tokenDPC_UseGlobalProxy_IsOn;

			private object cache_UseGlobalProxyAuth;

			private long tokenDPC_UseGlobalProxyAuth_IsOn;

			internal static object CompressReporter;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public unsafe Settings_obj1_BindingsTracking(Settings_obj1_Bindings obj)
			{
				//IL_0011: Expected Obj, but got Ref
				//IL_005b: Expected I, but got Obj
				//IL_0060: Expected I, but got Obj
				//IL_0060: Expected Obj, but got I4
				//IL_0074->IL0042: Incompatible stack heights: 1 vs 2
				//IL_007f->IL0042: Incompatible stack heights: 1 vs 2
				((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
				if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
				{
				}
				int hRForException = ExceptionHelpers.GetHRForException((Exception)(object)this);
				int num = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						return;
					}
					IList_object._initialized = (nint)new Action<object[], nint>((object[])(object)this, (nint)obj);
					_ = 1;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						_ = 1;
					}
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Settings_obj1_Bindings TryGetBindingObject()
			{
				return (Settings_obj1_Bindings)_FF00_FF00_FF00ﴀ();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ReleaseAllListeners()
			{
				_FF00_FF00_FF00_F200();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void DependencyPropertyChanged_UseGlobalProxy_IsOn(DependencyObject sender, DependencyProperty prop)
			{
				_FF00_FF00_FF00_F500(sender, prop);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void UpdateChildListeners_UseGlobalProxy(ToggleSwitch obj)
			{
				_FF00_FF00_FF00_F800(obj);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void DependencyPropertyChanged_UseGlobalProxyAuth_IsOn(DependencyObject sender, DependencyProperty prop)
			{
				_FF00_FF00_FF00_F000(sender, prop);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void UpdateChildListeners_UseGlobalProxyAuth(ToggleSwitch obj)
			{
				_FF00_FF00_FF00_F700(obj);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool DecorateCustomizableContainer()
			{
				throw new Exception("Error, DNGuard Runtime library not loaded!");
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static Settings_obj1_BindingsTracking RemoveEnumerator()
			{
				throw new Exception("Error, DNGuard Runtime library not loaded!");
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00_FF00_FF00_EF00(object P_0, object P_1)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778688, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00_FF00_FF00_F000(object P_0, object P_1)
			{
				//IL_0011: Expected Obj, but got Ref
				//IL_001d: Expected Obj, but got I4
				//IL_004f: Expected I4, but got Obj
				//IL_00bd: Expected I, but got Obj
				//IL_010c: Expected Obj, but got I
				//IL_0125: Expected I4, but got Obj
				//IL_0125: Expected I, but got Obj
				//IL_00a5: Expected Obj, but got I
				//IL_00dc: Expected Obj, but got I4
				//IL_00c2->IL011c: Incompatible stack heights: 1 vs 0
				//IL_0083->IL0026: Incompatible stack heights: 2 vs 1
				//IL_0111->IL0026: Incompatible stack heights: 3 vs 1
				//IL_0139->IL0026: Incompatible stack heights: 4 vs 1
				//IL_00aa->IL0026: Incompatible stack types: I4 vs Obj
				//IL_00cc->IL0026: Incompatible stack heights: 2 vs 1
				//IL_008e->IL0026: Incompatible stack heights: 2 vs 1
				//IL_011c->IL0026: Incompatible stack heights: 3 vs 1
				//IL_00b5->IL0026: Incompatible stack types: I4 vs Obj
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
						case 6:
							return;
						case 2:
							obj = _003CModule_003E.CheckAccessibleAttribute();
							_ = 1;
							if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
							{
								_ = 1;
							}
							continue;
						case 8:
							obj = ((P_0 is UserControl) ? P_0 : null);
							obj2 = 0;
							if (IList_object.PatchAttribute == null)
							{
								obj2 = 0;
							}
							continue;
						default:
							if (IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)null) == null)
							{
								_ = 3;
								continue;
							}
							break;
						case 1:
							if (obj == null)
							{
								goto end_IL_0026;
							}
							goto case 8;
						case 4:
							return;
						case 3:
						case 5:
							_ = 1073741824;
							IEnumerator_object._002Ecctor();
							_ = 4;
							if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
							{
								_ = 4;
							}
							continue;
						case 7:
							break;
						}
						IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)obj, (uint)(int)obj);
						_ = 1073741824;
						IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init();
						_ = 5;
						continue;
						end_IL_0026:
						break;
					}
					obj = 6;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00_FF00_FF00_F100()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778689, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00_FF00_FF00_F200()
			{
				//IL_0011: Expected Obj, but got Ref
				//IL_001d: Expected Obj, but got I4
				//IL_0037: Expected I4, but got Obj
				//IL_006a: Expected I, but got Obj
				//IL_006a: Expected I, but got Obj
				//IL_0079: Expected Obj, but got I
				//IL_0057->IL0026: Incompatible stack heights: 4 vs 1
				//IL_007e->IL0026: Incompatible stack heights: 2 vs 1
				//IL_0062->IL0026: Incompatible stack heights: 4 vs 1
				//IL_0089->IL0026: Incompatible stack heights: 2 vs 1
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
						_ = null;
						_003CModule_003E.CheckAccessibleAttribute();
						_ = 0;
						if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
						{
							_ = 0;
						}
						break;
					case 0:
						return;
					case 2:
						IEnumerator_object.Do_Abi_MoveNext_2((nint)this, (byte*)unchecked((nint)null));
						_ = 0;
						if (IList_object.PatchAttribute != null)
						{
							_ = 1;
						}
						break;
					}
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static byte _FF00_FF00_FF00_F300()
			{
				//IL_0011: Expected Obj, but got Ref
				((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
				if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
				{
				}
				return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static byte _FF00_FF00_FF00_F400()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778702, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
				return (byte)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00_FF00_FF00_F500(object P_0, object P_1)
			{
				//IL_0011: Expected Obj, but got Ref
				//IL_001d: Expected Obj, but got I4
				//IL_004b: Expected I4, but got Obj
				//IL_0122: Expected Obj, but got I
				//IL_00bf: Expected I, but got Obj
				//IL_00c1: Expected Obj, but got I4
				//IL_00d0: Expected Obj, but got I
				//IL_00a5: Expected I, but got Obj
				//IL_0127->IL0026: Incompatible stack heights: 4 vs 1
				//IL_006c->IL009c: Incompatible stack heights: 1 vs 0
				//IL_00fc->IL0026: Incompatible stack types: I4 vs Obj
				//IL_00d5->IL0026: Incompatible stack types: I4 vs Obj
				//IL_00b9->IL0026: Incompatible stack heights: 2 vs 1
				//IL_0132->IL0026: Incompatible stack heights: 4 vs 1
				//IL_0080->IL0026: Incompatible stack heights: 2 vs 1
				//IL_0107->IL0026: Incompatible stack types: I4 vs Obj
				//IL_009c->IL0026: Incompatible stack types: I4 vs Obj
				//IL_00e0->IL0026: Incompatible stack types: I4 vs Obj
				//IL_008b->IL0026: Incompatible stack heights: 2 vs 1
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
					case 3:
						if (ExceptionHelpers.GetHRForException((Exception)null) == 0)
						{
							_ = 0;
							if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
							{
								_ = 0;
							}
							break;
						}
						goto case 7;
					case 5:
						if (obj == null)
						{
							return;
						}
						obj2 = 4;
						break;
					case 7:
						/*Error near IL_00a5: Stack underflow*/((object[])obj, (nint)obj);
						IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_00af: Stack underflow*/, (uint)/*Error near IL_00af: Stack underflow*/, (nint)/*Error near IL_00af: Stack underflow*/, (uint*)1073741824);
						_ = 2;
						break;
					case 6:
						obj = IEnumerator_object.Do_Abi_get_Current_0((nint)/*Error near IL_00bf: Stack underflow*/, (nint*)(nint)this);
						obj2 = 5;
						if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
						{
							obj2 = 5;
						}
						break;
					case 4:
						obj = ((P_0 is Page) ? P_0 : null);
						obj2 = 3;
						if (IReadOnlyList_object._initialized == 0)
						{
							obj2 = 3;
						}
						break;
					default:
						_ = 1073741824;
						IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init();
						_ = 1;
						if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
						{
							_ = 0;
						}
						break;
					case 1:
						return;
					}
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00_FF00_FF00_F600(object P_0, object P_1)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778703, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void _FF00_FF00_FF00_F700(object P_0)
			{
				// ILSpy could not decompile this. Please report the exception below,
				// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
				// System.ArgumentNullException: Value cannot be null. (Parameter 'source')
				//    at System.Linq.ThrowHelper.ThrowArgumentNullException(ExceptionArgument argument)
				//    at System.Linq.Enumerable.Skip[TSource](IEnumerable`1 source, Int32 count)
				//    at ICSharpCode.Decompiler.CSharp.ArgumentList.GetArgumentResolveResultsDirect(Int32 skipCount) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 124
				//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Probe() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 493
				//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Run() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 438
				//    at ICSharpCode.Decompiler.CSharp.Disambiguator.ForMethodReference(ExpressionBuilder expressionBuilder, IMethod method, IType targetType, TranslatedExpression target, Boolean requireTarget, ExpectedTargetDetails expectedTargetDetails, Boolean isExtensionMethodReference, Boolean castTargetUpFront) in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 131
				//    at ICSharpCode.Decompiler.CSharp.CallBuilder.DisambiguateDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1718
				//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1648
				//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildMethodReference(IMethod method, Boolean isVirtual) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1639
				//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitLdFtn(LdFtn inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 5058
				//    at ICSharpCode.Decompiler.IL.LdFtn.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 3175
				//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
				//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitConv(Conv inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2307
				//    at ICSharpCode.Decompiler.IL.Conv.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2298
				//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
				//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildArgumentList(ExpectedTargetDetails expectedTargetDetails, ResolveResult target, IMethod method, Int32 firstParamIndex, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, Boolean writtenAsAssignment) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1070
				//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(OpCode callOpCode, IMethod method, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, IType constrainedTo) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 461
				//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(CallInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 255
				//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitNewObj(NewObj inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 538
				//    at ICSharpCode.Decompiler.IL.NewObj.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4578
				//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
				//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitConv(Conv inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2307
				//    at ICSharpCode.Decompiler.IL.Conv.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2298
				//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
				//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildArgumentList(ExpectedTargetDetails expectedTargetDetails, ResolveResult target, IMethod method, Int32 firstParamIndex, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, Boolean writtenAsAssignment) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1070
				//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(OpCode callOpCode, IMethod method, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, IType constrainedTo) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 461
				//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(CallInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 255
				//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitCallVirt(CallVirt inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2535
				//    at ICSharpCode.Decompiler.IL.CallVirt.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2215
				//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
				//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitStObj(StObj inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 3219
				//    at ICSharpCode.Decompiler.IL.StObj.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4386
				//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
				//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitStObj(StObj inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 140
				//    at ICSharpCode.Decompiler.IL.StObj.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4382
				//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
				//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
				//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
				//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
				//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertSwitchSectionBody(SwitchSection astSection, ILInstruction bodyInst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 334
				//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.TranslateSwitch(BlockContainer switchContainer, SwitchInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 280
				//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1334
				//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
				//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
				//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
				//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
				//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertLoop(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1354
				//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1325
				//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
				//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
				//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
				//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
				//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1338
				//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
				//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
				//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertAsBlock(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 87
				//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2435
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00_FF00_FF00_F800(object P_0)
			{
				//IL_0011: Expected Obj, but got Ref
				//IL_001d: Expected Obj, but got I4
				//IL_004b: Expected I4, but got Obj
				//IL_0057: Expected I, but got Obj
				//IL_013a: Expected I, but got Obj
				//IL_0146: Expected I, but got Obj
				//IL_0146: Expected I, but got Obj
				//IL_0146: Expected I, but got Obj
				//IL_014b: Expected I4, but got Obj
				//IL_0068: Expected I, but got Obj
				//IL_00c9: Expected I, but got Obj
				//IL_0098: Expected Obj, but got I
				//IL_00df: Expected I, but got Obj
				//IL_0114: Expected I, but got Obj
				//IL_007c: Expected Obj, but got I
				//IL_00ac: Expected Obj, but got I
				//IL_0061->IL0026: Incompatible stack types: I4 vs Obj
				//IL_0164->IL0026: Incompatible stack types: I4 vs Obj
				//IL_009d->IL00bc: Incompatible stack heights: 1 vs 0
				//IL_00f3->IL0026: Incompatible stack types: I4 vs Obj
				//IL_0128->IL0026: Incompatible stack types: I4 vs Obj
				//IL_016f->IL0026: Incompatible stack types: I4 vs Obj
				//IL_0081->IL0026: Incompatible stack types: I4 vs Obj
				//IL_00d8->IL0026: Incompatible stack types: I4 vs Obj
				//IL_00b1->IL0026: Incompatible stack heights: 2 vs 1
				//IL_00fe->IL0026: Incompatible stack types: I4 vs Obj
				//IL_0133->IL0026: Incompatible stack types: I4 vs Obj
				//IL_008c->IL0026: Incompatible stack types: I4 vs Obj
				//IL_00bc->IL0026: Incompatible stack heights: 2 vs 1
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
					default:
						IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
						obj2 = 2;
						break;
					case 3:
						if (IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)P_0, ref *(object[]*)null) == 0)
						{
							return;
						}
						obj2 = 0;
						if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
						{
							obj2 = 0;
						}
						break;
					case 5:
						if (MarshalInspectable<object>.FromAbiArray((object)IList_object._initialized) != null)
						{
							_ = 4;
							if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
							{
								_ = 2;
							}
							break;
						}
						return;
					case 1:
						return;
					case 4:
						if (IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00c9: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00c9: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)IReadOnlyList_System_IDisposable._initialized, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)null))
						{
							obj2 = 7;
							break;
						}
						goto case 3;
					case 6:
						IReadOnlyList_object._initialized = unchecked((nint)null);
						obj2 = 3;
						if (IEnumerator_System_IDisposable._initialized == 0)
						{
							obj2 = 0;
						}
						break;
					case 7:
						MarshalInterface<INotifyPropertyChanged>.CopyManagedArray(MarshalInterface<INotifyPropertyChanged>.FromAbiArray(IEnumerator_System_IDisposable.ReflectTransferableAttribute), (IntPtr)IEnumerable_System_IDisposable.CombineAttribute);
						obj2 = 0;
						if (GlobalVtableLookup.CreateAttribute != null)
						{
							obj2 = 6;
						}
						break;
					case 2:
						Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute = IListMethods<object>.Abi_GetAt_0((IntPtr)/*Error near IL_014b: Stack underflow*/, (uint)(new IListMethods<object, nint>((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_0146: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_0146: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)/*Error near IL_0146: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_0146: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_0146: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_0146: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int>)/*Error near IL_0146: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, int>)/*Error near IL_0146: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, int>)IEnumerableMethods<INotifyPropertyChanged>.Abi_First_0((IntPtr)P_0), (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, int>)(delegate*<byte>)(&IEnumerable_System_ComponentModel_INotifyPropertyChanged.Init)) ? 1 : 0));
						obj2 = 1;
						if (Mass_WinUI_AppWinRTTypeDetails.CheckHiddenAttribute == null)
						{
							obj2 = 1;
						}
						break;
					}
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00_FF00_FF00豈(object P_0)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778700, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static object _FF00_FF00_FF00切()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778701, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
				return (object)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static object _FF00_FF00_FF00ﬀ()
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
			internal unsafe static object _FF00_FF00_FF00ﰀ()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778698, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
				return (object)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe object _FF00_FF00_FF00ﴀ()
			{
				//IL_0029: Expected Obj, but got I
				//IL_0058: Expected I, but got Obj
				//IL_0051: Expected Obj, but got I
				nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 8124, 1790778699, 0, 0);
				object obj = num;
				if (num == 0)
				{
					obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778699, new IntPtr(2737336194892L), 15);
				}
				return ((delegate*<object, object>)obj)(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe object _FF00_FF00_FF00_FE00()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778696, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
				return (object)/*Error near IL_0033: Stack underflow*/;
			}
		}

		private object dataRoot;

		private nint initialized;

		private object obj3;

		private object obj4;

		private object obj5;

		private object obj6;

		private object obj7;

		private object bindingsTracking;

		private Dictionary<string, InvokeFunctionDelegate> PendingFunctionBindings;

		internal static object DecorateGroupedEngine;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe Settings_obj1_Bindings()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected Obj, but got Unknown
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = new ExceptionHelpers((Exception)(object)this);
			/*Error near IL_0025: Member reference must be method, but was: Field*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Connect(int connectionId, object target)
		{
			_FF00_FF00_FF00_FF00_2900((uint)connectionId, target);
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
			_FF00_FF00_FF00_FF00ࠀ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			_FF00_FF00_FF00_FF00_1B00();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopTracking()
		{
			_FF00_FF00_FF00_FF00ᄀ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisconnectUnloadedObject(int connectionId)
		{
			_FF00_FF00_FF00_FF00_2600((uint)connectionId);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SetDataRoot(object newDataRoot)
		{
			return _FF00_FF00_FF00_FF00ᔀ(newDataRoot) != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Activated(object obj, WindowActivatedEventArgs data)
		{
			_FF00_FF00_FF00_FF00_2000(obj, data);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Loading(FrameworkElement src, object data)
		{
			_FF00_FF00_FF00_FF00ᤀ(src, data);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte TryGet_UseGlobalProxy_IsOn([Out] nint val)
		{
			return _FF00_FF00_FF00_FF00_1400(val);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte TryGet_UseGlobalProxy([Out] nint val)
		{
			return _FF00_FF00_FF00_FF00_2200(val);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte TryGet_([Out] nint val)
		{
			return _FF00_FF00_FF00_FF00က(val);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte TryGet_UseGlobalProxyAuth_IsOn([Out] nint val)
		{
			return _FF00_FF00_FF00_FF00_2A00(val);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte TryGet_UseGlobalProxyAuth([Out] nint val)
		{
			return _FF00_FF00_FF00_FF00_0C00(val);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Invoke_M_IsProxyAuthEnabled_3303245800(uint phase)
		{
			_FF00_FF00_FF00_FF00Ḁ(phase);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CompleteUpdate(uint phase)
		{
			_FF00_FF00_FF00_FF00_0B00(phase);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update_(object obj, uint phase)
		{
			_FF00_FF00_FF00_FF00Ԁ(obj, phase);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update_UseGlobalProxy(object obj, uint phase)
		{
			_FF00_FF00_FF00_FF00_2400(obj, phase);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update_UseGlobalProxy_IsOn(byte obj, uint phase)
		{
			_FF00_FF00_FF00_FF00ᜀ(obj, phase);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update_UseGlobalProxyAuth(object obj, uint phase)
		{
			_FF00_FF00_FF00_FF00_0E00(obj, phase);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update_UseGlobalProxyAuth_IsOn(byte obj, uint phase)
		{
			_FF00_FF00_FF00_FF00Ā(obj, phase);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update_M_IsProxyAuthEnabled_3303245800(uint phase)
		{
			_FF00_FF00_FF00_FF00_0700(phase);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CollectAggregator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Settings_obj1_Bindings CheckIsolatedEvaluator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00_FF00_FF00_FF00(byte P_0, uint P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778740, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00_FF00_FF00_FF00Ā(byte P_0, uint P_1)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0053->IL0026: Incompatible stack heights: 4 vs 1
			//IL_005e->IL0026: Incompatible stack heights: 4 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					_003CModule_003E.CheckAccessibleAttribute();
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
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
		private unsafe void _FF00_FF00_FF00_FF00Ȁ(byte P_0, uint P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778741, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_0300()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00Ѐ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778738, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00_FF00_FF00_FF00Ԁ(object P_0, uint P_1)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_004b: Expected I4, but got Obj
			//IL_007d: Expected I, but got Obj
			//IL_0109: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_00ed->IL0026: Incompatible stack heights: 5 vs 1
			//IL_0087->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0126->IL00ab: Incompatible stack heights: 1 vs 0
			//IL_010e->IL0026: Incompatible stack heights: 5 vs 1
			//IL_006b->IL0026: Incompatible stack heights: 4 vs 1
			//IL_00cb->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0130->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0119->IL0026: Incompatible stack heights: 5 vs 1
			//IL_0076->IL0026: Incompatible stack heights: 4 vs 1
			//IL_00d6->IL0026: Incompatible stack types: I4 vs Obj
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
				case 7:
					_003CModule_003E.CheckAccessibleAttribute();
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						_ = 1;
					}
					break;
				case 2:
					IEnumerator_object.Do_Abi_MoveNext_2((nint)this, (byte*)(int)P_1);
					_ = 7;
					break;
				case 3:
					if ((P_1 & 0xC0000001u) != 0)
					{
						obj2 = 0;
						if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
						{
							obj2 = 0;
						}
						break;
					}
					goto case 4;
				default:
					_ = IReadOnlyList_System_IDisposable._initialized;
					IEnumerator_object.LoadAttribute();
					_ = 6;
					break;
				case 6:
					_ = IReadOnlyList_object._initialized;
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init();
					_ = 2;
					if (IEnumerator_System_IDisposable.ReflectTransferableAttribute != null)
					{
						_ = 1;
					}
					break;
				case 1:
					return;
				case 5:
					if (MarshalInterface<INotifyPropertyChanged>.FromAbiArray((object)null) == null)
					{
						_ = 4;
						break;
					}
					goto case 3;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00_FF00_FF00_FF00_0700(uint P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_003f: Expected I4, but got Obj
			//IL_005c: Expected I, but got Obj
			//IL_0061: Expected I, but got Obj
			//IL_006a: Expected Obj, but got I4
			//IL_00be: Expected Obj, but got I
			//IL_00e9: Expected Obj, but got I
			//IL_00c3->IL0026: Incompatible stack heights: 6 vs 1
			//IL_00ee->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ce->IL0026: Incompatible stack heights: 6 vs 1
			//IL_00f9->IL0026: Incompatible stack types: I4 vs Obj
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
					default:
						return;
					case 0:
						return;
					case 1:
						return;
					case 3:
						break;
					case 4:
						_ = IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute;
						IEnumerator_object.DecorateAutomatableAttribute();
						_ = (delegate*<IEnumerator_object>)(&IEnumerator_object.LoadAttribute);
						MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)new IReadOnlyList_System_ComponentModel_INotifyPropertyChanged());
						_ = 0;
						if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
						{
							_ = 0;
						}
						continue;
					case 2:
						if ((P_0 & 0xC0000001u) == 0)
						{
							obj2 = 0;
							if (IEnumerable_System_IDisposable.CombineAttribute == null)
							{
								obj2 = 1;
							}
							continue;
						}
						break;
					}
					break;
				}
				((ValueTuple<int, nint>*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized)->_002Ector(IEnumerator_object.Initialized ? 1 : 0, (nint)new IEnumerator_object((nint)this, (byte*)(delegate*<byte>)(&IEnumerator_object.Init)));
				obj = 4;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00_FF00_FF00_FF00ࠀ()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0037: Expected I4, but got Obj
			//IL_007c: Expected Obj, but got I
			//IL_0057->IL0026: Incompatible stack heights: 3 vs 1
			//IL_0062->IL0026: Incompatible stack heights: 3 vs 1
			//IL_0081->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008c->IL0026: Incompatible stack types: I4 vs Obj
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
					_003CModule_003E.CheckAccessibleAttribute();
					_ = 2;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						_ = 2;
					}
					break;
				case 1:
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
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
		internal unsafe sealed void _FF00_FF00_FF00_FF00_0900()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778739, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00_FF00_FF00_FF00_0A00(uint P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778736, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00_FF00_FF00_FF00_0B00(uint P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0037: Expected I4, but got Obj
			//IL_0142: Expected I, but got Obj
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Expected Obj, but got Unknown
			//IL_0167->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0172->IL0026: Incompatible stack types: I4 vs Obj
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
					IEnumerable_object.ReflectSetAttribute = new MarshalInterface<INotifyPropertyChanged>((INotifyPropertyChanged[])IEnumerable_System_IDisposable.CombineAttribute, (IntPtr)this);
					obj = IEnumerableMethods<INotifyPropertyChanged>.Abi_First_0((IntPtr)(IEnumerableMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)/*Error near IL_014c: Stack underflow*/) ? 1 : 0));
					obj2 = 0;
					if (Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute != null)
					{
						obj2 = 0;
					}
					continue;
				}
				while (IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)(nint)(&obj)) == null)
				{
					int num = 2;
					if (IReadOnlyList_System_IDisposable._initialized == 0)
					{
						num = 2;
					}
					switch (num)
					{
					case 1:
						continue;
					case 2:
						return;
					}
					break;
				}
				_ = ref obj;
				/*Error near IL_007d: Member reference must be method, but was: Field*/;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe byte _FF00_FF00_FF00_FF00_0C00(nint P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_003f: Expected I4, but got Obj
			//IL_00c4: Expected I, but got Obj
			//IL_0098: Expected I, but got Obj
			//IL_0071: Expected Obj, but got I
			//IL_0058: Expected Obj, but got I
			//IL_00ac: Expected Obj, but got I
			//IL_009d->IL0046: Incompatible stack heights: 0 vs 1
			//IL_0085->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005d->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00dd->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00b1->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0090->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0068->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00e8->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00bc->IL0026: Incompatible stack types: I4 vs Obj
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
				case 1:
					return 1;
				case 4:
					Unsafe.Write((void*)P_0, (object)IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized);
					obj2 = 0;
					if (IList_object._initialized == 0)
					{
						obj2 = 1;
					}
					break;
				case 3:
					if (IEnumerator_object.Do_Abi_get_Current_0((nint)this, (nint*)(&obj)) != 0)
					{
						obj2 = 2;
						if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
						{
							obj2 = 2;
						}
						break;
					}
					goto IL_0046;
				case 2:
					if (IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)null))
					{
						_ = 1;
						if (IReadOnlyList_object._initialized == 0)
						{
							_ = 4;
						}
						break;
					}
					goto IL_0046;
				default:
					{
						return 0;
					}
					IL_0046:
					Unsafe.Write((void*)P_0, null);
					_ = 0;
					if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe byte _FF00_FF00_FF00_FF00_0D00(nint P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778737, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00_FF00_FF00_FF00_0E00(object P_0, uint P_1)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_00d0: Expected I, but got Obj
			//IL_008f: Expected I, but got Obj
			//IL_009e: Expected Obj, but got I
			//IL_00b5: Expected I, but got Obj
			//IL_00c4: Expected Obj, but got I4
			//IL_0063: Expected Obj, but got I
			//IL_00d5->IL0082: Incompatible stack heights: 1 vs 0
			//IL_00a3->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00c9->IL0022: Incompatible stack heights: 3 vs 0
			//IL_00e9->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00ae->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00f4->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0073->IL0026: Incompatible stack types: I4 vs Obj
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 2:
						if ((P_1 & 0xC0000001u) == 0)
						{
							obj2 = 5;
							if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute != null)
							{
								obj2 = 1;
							}
							continue;
						}
						break;
					case 5:
						return;
					case 4:
						return;
					case 1:
						IEnumerator_object.Do_Abi_MoveNext_2(IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized, (byte*)(nint)P_0);
						_ = 0;
						if (IList_object.PatchAttribute == null)
						{
							_ = 0;
						}
						continue;
					case 3:
						break;
					default:
						if (!IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)null))
						{
							return;
						}
						_ = 2;
						if (IReadOnlyList_object._initialized != 0)
						{
							_ = 1;
						}
						continue;
					}
					break;
				}
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)P_0);
				IEnumerator_object._002Ecctor();
				obj = 4;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00_FF00_FF00_FF00ༀ(object P_0, uint P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778750, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe byte _FF00_FF00_FF00_FF00က(nint P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0040: Expected Obj, but got I
			//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
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
					Unsafe.Write((void*)P_0, (object)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
					obj2 = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj2 = 0;
					}
					break;
				default:
					return 1;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00_FF00_FF00_FF00ᄀ()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0037: Expected I4, but got Obj
			//IL_0057: Expected Obj, but got I
			//IL_0082->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005c->IL0026: Incompatible stack heights: 3 vs 1
			//IL_008d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0067->IL0026: Incompatible stack heights: 3 vs 1
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
					_ = IEnumerator_object.Initialized;
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
					{
						_ = 0;
					}
					break;
				default:
					IList_object._initialized = 0;
					obj2 = 1;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj2 = 2;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00_FF00_FF00_FF00ሀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778751, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe byte _FF00_FF00_FF00_FF00ጀ(nint P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778748, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe byte _FF00_FF00_FF00_FF00_1400(nint P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_00c8: Expected I, but got Obj
			//IL_007c: Expected Obj, but got I4
			//IL_00b6->IL0081: Incompatible stack heights: 1 vs 0
			//IL_00c0->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00e1->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ec->IL0026: Incompatible stack types: I4 vs Obj
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 3:
						return 0;
					case 1:
						return 1;
					case 2:
						break;
					default:
						/*Error near IL_0084: Member reference must be method, but was: Field*/;
					case 4:
						if (MarshalInspectable<object>.FromAbiArray((object)null) == null)
						{
							_ = 2;
							continue;
						}
						goto default;
					case 5:
						if (IEnumerator_object.Do_Abi_get_HasCurrent_1((nint)this, (byte*)(&obj)) != 0)
						{
							obj2 = 4;
							if (IReadOnlyList_System_IDisposable._initialized == 0)
							{
								obj2 = 1;
							}
							continue;
						}
						break;
					}
					break;
				}
				*(sbyte*)P_0 = 0;
				obj = 3;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe byte _FF00_FF00_FF00_FF00ᔀ(object P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_003f: Expected I4, but got Obj
			//IL_007d: Expected Obj, but got I
			//IL_00ac: Expected Obj, but got I
			//IL_0082->IL0026: Incompatible stack heights: 3 vs 1
			//IL_00b1->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008d->IL0026: Incompatible stack heights: 3 vs 1
			//IL_00bc->IL0026: Incompatible stack types: I4 vs Obj
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
					if (P_0 == null)
					{
						obj2 = 4;
						continue;
					}
					break;
				case 1:
					_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
					_ = IEnumerator_object.Initialized;
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
					{
						_ = 0;
					}
					continue;
				case 2:
					return 1;
				case 4:
					return 0;
				case 3:
					break;
				}
				IList_object.PatchAttribute = CastExtensions.As<InvokeCommandAction>(P_0);
				obj2 = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
				{
					obj2 = 2;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00_FF00_FF00_FF00ᘀ(byte P_0, uint P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778749, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00_FF00_FF00_FF00ᜀ(byte P_0, uint P_1)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0063: Expected Obj, but got I
			//IL_00e7: Expected I4, but got Obj
			//IL_008e: Expected Obj, but got I
			//IL_00d0->IL0026: Incompatible stack heights: 4 vs 1
			//IL_0068->IL0026: Incompatible stack heights: 4 vs 1
			//IL_00b4->IL0026: Incompatible stack heights: 3 vs 1
			//IL_00fb->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0093->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00db->IL0026: Incompatible stack heights: 4 vs 1
			//IL_0073->IL0026: Incompatible stack heights: 4 vs 1
			//IL_0106->IL0026: Incompatible stack heights: 2 vs 1
			//IL_009e->IL0026: Incompatible stack types: I4 vs Obj
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
					_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
					_ = IEnumerator_object.Initialized;
					_ = 3;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						_ = 5;
					}
					continue;
				case 3:
					_ = IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized;
					IEnumerator_object._002Ecctor();
					_ = 4;
					continue;
				case 4:
					return;
				case 1:
					IEnumerator_object.DecorateAutomatableAttribute();
					_ = 0;
					if (IReadOnlyList_object._initialized == 0)
					{
						_ = 0;
					}
					continue;
				case 5:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_00e7: Stack underflow*/, (uint)(int)IReadOnlyList_object.ReflectLogicalAttribute, (nint*)(int)P_0);
					_ = 3;
					if (IEnumerable_System_IDisposable._initialized != 0)
					{
						_ = 3;
					}
					continue;
				}
				if ((P_1 & 0xC0000001u) == 0)
				{
					return;
				}
				obj2 = 1;
				if (IList_object.PatchAttribute == null)
				{
					obj2 = 2;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00_1800(object P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778746, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00ᤀ(object P_0, object P_1)
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			_003CModule_003E.CheckAccessibleAttribute();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00ᨀ(object P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778747, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00_FF00_FF00_FF00_1B00()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0037: Expected I4, but got Obj
			//IL_0073: Expected I, but got Obj
			//IL_0073: Expected I4, but got Obj
			//IL_0057->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0087->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0062->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0092->IL0026: Incompatible stack heights: 2 vs 1
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
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = 1;
					obj2 = 2;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj2 = 2;
					}
					break;
				case 1:
					IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_0073: Stack underflow*/, (uint)(int)this, (nint)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute, (uint*)int.MinValue);
					_ = 0;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						_ = 0;
					}
					break;
				case 2:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00_FF00_FF00_FF00ᰀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778744, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00_FF00_FF00_FF00ᴀ(uint P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778745, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00_FF00_FF00_FF00Ḁ(uint P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_004f: Expected I4, but got Obj
			//IL_0109: Expected Obj, but got I
			//IL_0135: Expected Obj, but got I
			//IL_00ca: Expected I, but got Obj
			//IL_0093: Expected Obj, but got I4
			//IL_010e->IL0026: Incompatible stack heights: 3 vs 1
			//IL_013a->IL0026: Incompatible stack heights: 4 vs 1
			//IL_0077->IL00c1: Incompatible stack heights: 2 vs 0
			//IL_0119->IL0026: Incompatible stack heights: 3 vs 1
			//IL_0145->IL0026: Incompatible stack heights: 4 vs 1
			//IL_0081->IL0026: Incompatible stack heights: 3 vs 1
			//IL_006a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_009d->IL0026: Incompatible stack heights: 4 vs 1
			//IL_00d9->IL0026: Incompatible stack types: I4 vs Obj
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 7;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 8:
					if ((P_0 & 0xC0000001u) == 0)
					{
						obj2 = 4;
						continue;
					}
					break;
				case 7:
					_ = ref obj;
					if (_003CModule_003E.CheckAccessibleAttribute() != null)
					{
						_ = 6;
						continue;
					}
					return;
				case 5:
					return;
				case 3:
					return;
				case 6:
					if (IEnumerator_object.Do_Abi_get_Current_0((nint)this, (nint*)(&obj)) == 0)
					{
						obj2 = 5;
						continue;
					}
					_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
					obj = IEnumerator_object.Init();
					_ = 8;
					continue;
				case 4:
					return;
				case 1:
					return;
				default:
					_ = IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized;
					IEnumerator_object._002Ecctor();
					_ = 1;
					if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute != null)
					{
						_ = 1;
					}
					continue;
				case 2:
					break;
				}
				_ = IReadOnlyList_object._initialized;
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init();
				_ = 0;
				if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
				{
					_ = 0;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00_FF00_FF00_FF00ἀ(uint P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778694, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00_2000(object P_0, object P_1)
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			_003CModule_003E.CheckAccessibleAttribute();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00_2100(object P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778695, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe byte _FF00_FF00_FF00_FF00_2200(nint P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0047: Expected I4, but got Obj
			//IL_00f5: Expected Obj, but got I
			//IL_006d: Expected I, but got Obj
			//IL_007b: Expected Obj, but got I4
			//IL_00b8: Expected Obj, but got I
			//IL_0109->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005b->IL0065: Incompatible stack heights: 2 vs 0
			//IL_0114->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00bd->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0065->IL0026: Incompatible stack heights: 3 vs 1
			//IL_00c8->IL0026: Incompatible stack types: I4 vs Obj
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 6;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 4:
						return 0;
					case 6:
						_ = ref obj;
						if (_003CModule_003E.CheckAccessibleAttribute() == null)
						{
							_ = 5;
							continue;
						}
						goto case 1;
					case 1:
						if (IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)obj, ref *(object[]*)null) != 0)
						{
							break;
						}
						goto end_IL_0026;
					case 2:
						return 1;
					case 3:
					case 5:
						Unsafe.Write((void*)P_0, null);
						obj2 = 4;
						if (IList_object.PatchAttribute == null)
						{
							obj2 = 1;
						}
						continue;
					}
					Unsafe.Write((void*)P_0, (object)IReadOnlyList_System_IDisposable._initialized);
					obj2 = 2;
					if (IReadOnlyList_object._initialized == 0)
					{
						obj2 = 2;
					}
					continue;
					end_IL_0026:
					break;
				}
				obj = 3;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe byte _FF00_FF00_FF00_FF00_2300(nint P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778692, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00_FF00_FF00_FF00_2400(object P_0, uint P_1)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0047: Expected I4, but got Obj
			//IL_008d: Expected I, but got Obj
			//IL_0058->IL00d8: Incompatible stack heights: 1 vs 0
			//IL_00d8->IL0026: Incompatible stack heights: 4 vs 1
			//IL_00a7->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00ee->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0062->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00b2->IL0026: Incompatible stack heights: 2 vs 1
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
				case 2:
					if (ExceptionHelpers.GetHRForException((Exception)null) == 0)
					{
						_ = 6;
						break;
					}
					goto case 1;
				case 6:
					return;
				case 5:
					/*Error near IL_008d: Stack underflow*/((object[])(object)this, (nint)P_0);
					IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_0093: Stack underflow*/, (uint)/*Error near IL_0093: Stack underflow*/, (nint)/*Error near IL_0093: Stack underflow*/, (uint*)(int)P_1);
					_ = 0;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						_ = 0;
					}
					break;
				case 4:
					return;
				case 0:
					return;
				case 3:
					_ = IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute;
					IEnumerator_object.DecorateAutomatableAttribute();
					_ = 2;
					break;
				case 1:
					if ((P_1 & 0xC0000001u) == 0)
					{
						obj2 = 4;
						break;
					}
					goto case 5;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00_FF00_FF00_FF00_2500(uint P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778693, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00_FF00_FF00_FF00_2600(uint P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			throw new IEnumeratorMethods<object>((IntPtr)/*Error near IL_001e: Stack underflow*/, ref *(object[]*)_003CModule_003E.CheckAccessibleAttribute());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_2700()
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
		internal unsafe static object _FF00_FF00_FF00_FF00_2800()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778690, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00_FF00_FF00_FF00_2900(uint P_0, object P_1)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0047: Expected I4, but got Obj
			//IL_0068: Expected Obj, but got I
			//IL_0119: Expected Obj, but got I
			//IL_00ab: Expected Obj, but got I
			//IL_00e0: Expected Obj, but got I4
			//IL_008f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00fd->IL0026: Incompatible stack types: I4 vs Obj
			//IL_011e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00b0->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0078->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0129->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00bb->IL0026: Incompatible stack types: I4 vs Obj
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
					default:
						return;
					case 4:
						return;
					case 2:
						return;
					case 0:
						return;
					case 3:
						switch (P_0)
						{
						case 4u:
							((AsyncVoidMethodBuilder*)/*Error near IL_0054: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)this, ref *(App._003CLogout_003Ed__15*)P_1);
							IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = (object)/*Error near IL_0059: Stack underflow*/;
							obj2 = 0;
							if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
							{
								obj2 = 1;
							}
							goto end_IL_0026;
						case 3u:
							IList_object.PatchAttribute = CastExtensions.As<InvokeCommandAction>(P_1);
							obj2 = 4;
							goto end_IL_0026;
						case 7u:
							IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute = CastExtensions.As<NotificationPanel>(P_1);
							obj2 = 2;
							if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute != null)
							{
								obj2 = 6;
							}
							goto end_IL_0026;
						case 5u:
							IReadOnlyList_object.ReflectLogicalAttribute = ((XamlUserType)this).BoxType<TimeSpan>(P_1);
							obj2 = 5;
							goto end_IL_0026;
						case 6u:
							IEnumerator_System_IDisposable.ReflectTransferableAttribute = ((XamlUserType)this).BoxType<EasingMode>(P_1);
							obj2 = 0;
							if (IEnumerable_System_IDisposable.CombineAttribute == null)
							{
								obj2 = 0;
							}
							goto end_IL_0026;
						}
						obj = 2;
						goto end_IL_0026_2;
					case 6:
						return;
					case 1:
						return;
					case 5:
						return;
						end_IL_0026:
						break;
					}
					continue;
					end_IL_0026_2:
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe byte _FF00_FF00_FF00_FF00_2A00(nint P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0047: Expected I4, but got Obj
			//IL_007b: Expected Obj, but got I
			//IL_00c5: Expected Obj, but got I
			//IL_00eb: Expected Obj, but got I4
			//IL_0059->IL0063: Incompatible stack heights: 1 vs 0
			//IL_0080->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00e2->IL004c: Incompatible stack heights: 2 vs 0
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ca->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00f0->IL0022: Incompatible stack heights: 2 vs 0
			//IL_00d5->IL0026: Incompatible stack types: I4 vs Obj
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if (ExceptionHelpers.GetHRForException((Exception)null) == 0)
						{
							_ = 6;
							continue;
						}
						goto case 2;
					case 2:
						*(sbyte*)(nint)/*Error near IL_006c: Stack underflow*/ = (sbyte)IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)P_0, ref *(object[]*)obj);
						obj2 = 0;
						if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
						{
							obj2 = 1;
						}
						continue;
					case 3:
						return 0;
					case 1:
						return 1;
					case 4:
					case 6:
						*(sbyte*)P_0 = 0;
						obj2 = 3;
						if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
						{
							obj2 = 2;
						}
						continue;
					case 5:
						_ = ref obj;
						if (!IEnumerator_object.DecorateAutomatableAttribute())
						{
							break;
						}
						goto default;
					}
					break;
				}
				obj = 4;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe byte _FF00_FF00_FF00_FF00_2B00(nint P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778691, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRepairShadowGameButton_Click_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private object _003Cpath_003E5__2;

		private TaskAwaiter<ContentDialogResult> _003C_003Eu__1;

		private static object ViewFinder;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EncryptAllocator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectSetMap()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00봀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779040, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00븀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_004f: Expected I, but got Obj
			//IL_004f: Expected Obj, but got Ref
			//IL_06d6: Expected Obj, but got I4
			//IL_06d6: Expected Obj, but got Ref
			//IL_0074: Expected Obj, but got Ref
			//IL_06fc: Expected Obj, but got Ref
			//IL_05eb: Expected Obj, but got Ref
			//IL_05db: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e6: Expected Obj, but got Unknown
			//IL_01cb: Expected I, but got Obj
			//IL_01cb: Expected Obj, but got Ref
			//IL_0218: Expected Obj, but got Ref
			//IL_0596: Expected Obj, but got Ref
			//IL_0168: Expected Obj, but got I4
			//IL_016d: Expected Obj, but got I4
			//IL_016d: Expected Obj, but got Ref
			//IL_017c: Expected Obj, but got I
			//IL_0473: Unknown result type (might be due to invalid IL or missing references)
			//IL_0478: Unknown result type (might be due to invalid IL or missing references)
			//IL_0483: Expected I, but got Obj
			//IL_0483: Expected I, but got Unknown
			//IL_0488: Expected I, but got Unknown
			//IL_01ff: Expected Obj, but got I4
			//IL_0204: Expected Obj, but got I4
			//IL_0204: Expected Obj, but got Ref
			//IL_020d: Expected Obj, but got I4
			//IL_0443: Expected Obj, but got Ref
			//IL_03bc: Expected Obj, but got I4
			//IL_0142: Expected Obj, but got Ref
			//IL_014a: Expected Obj, but got Ref
			//IL_014a: Expected Obj, but got Ref
			//IL_03e1: Expected Obj, but got Ref
			//IL_03e6: Expected I, but got Obj
			//IL_0295: Expected I, but got Obj
			//IL_02a4: Expected I, but got Obj
			//IL_02bd: Expected Obj, but got VT
			//IL_0117: Expected I4, but got Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			//IL_06ea->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0712->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_06f5->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0098->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00aa->IL00ae: Incompatible stack types: I4 vs Obj
			//IL_071d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_05e6->IL05e6: Incompatible stack heights: 4 vs 2
			//IL_0473->IL00ae: Incompatible stack heights: 6 vs 1
			//IL_0604->IL00ae: Incompatible stack types: I4 vs Obj
			//IL_01d5->IL00ae: Incompatible stack types: I4 vs Obj
			//IL_022e->IL00ae: Incompatible stack types: I4 vs Obj
			//IL_05a0->IL03db: Incompatible stack heights: 1 vs 0
			//IL_0585->IL00ae: Incompatible stack heights: 3 vs 1
			//IL_0181->IL00ae: Incompatible stack types: I4 vs Obj
			//IL_052e->IL011c: Incompatible stack heights: 1 vs 0
			//IL_0453->IL00ae: Incompatible stack types: I4 vs Obj
			//IL_03d0->IL00ae: Incompatible stack types: I4 vs Obj
			//IL_0154->IL00ae: Incompatible stack heights: 3 vs 1
			//IL_0131->IL00ae: Incompatible stack types: I4 vs Obj
			//IL_060f->IL00ae: Incompatible stack types: I4 vs Obj
			//IL_0239->IL00ae: Incompatible stack types: I4 vs Obj
			//IL_05b4->IL00ae: Incompatible stack heights: 2 vs 1
			//IL_024e->IL0252: Incompatible stack heights: 1 vs 2
			//IL_0590->IL00ae: Incompatible stack heights: 3 vs 1
			//IL_018c->IL00ae: Incompatible stack types: I4 vs Obj
			//IL_0542->IL00ae: Incompatible stack heights: 2 vs 1
			//IL_03db->IL00ae: Incompatible stack types: I4 vs Obj
			//IL_01eb->IL00ae: Incompatible stack types: I4 vs Obj
			//IL_013c->IL00ae: Incompatible stack types: I4 vs Obj
			//IL_03f5->IL00ae: Incompatible stack types: I4 vs Obj
			//IL_05bf->IL00ae: Incompatible stack heights: 2 vs 1
			//IL_0267->IL028b: Incompatible stack heights: 1 vs 0
			//IL_054d->IL00ae: Incompatible stack heights: 2 vs 1
			//IL_028b->IL0252: Incompatible stack heights: 7 vs 2
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				ref Guid iID;
				PropertyChangingEventArgs parseErrorMessage;
				switch ((int)obj2)
				{
				default:
					return;
				case 1:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = unchecked((nint)null);
					obj2 = 1;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj2 = 3;
					}
					break;
				case 3:
					*((int, nint)*)(nint)/*Error near IL_0079: Stack underflow*/ = ((int)/*Error near IL_0079: Stack underflow*/, (nint)Unsafe.AsPointer(ref IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute));
					obj2 = 0;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj2 = 0;
					}
					break;
				case 4:
					if (obj == null)
					{
						obj3 = 6;
						goto IL_00ae;
					}
					goto IL_05bf;
				case 2:
					goto IL_06ce;
				case 0:
					return;
				case 5:
					{
						obj = __KnownINotifyPropertyChangingArgs.SelectedPageOfSkin;
						obj2 = 3;
						if (__KnownINotifyPropertyChangingArgs.LastSearchText != null)
						{
							obj2 = 4;
						}
						break;
					}
					IL_0453:
					_ = __KnownINotifyPropertyChangingArgs.LaunchTime;
					IReadOnlyList_object._002Ecctor();
					IReadOnlyList_object.ReflectSimpleAttribute();
					_ = null;
					_ = null;
					IReadOnlyList_object.DecorateControllableAttribute();
					_ = 5;
					goto IL_00ae;
					IL_05bf:
					iID = IFrameworkElementOverridesMethods.IID;
					parseErrorMessage = __KnownINotifyPropertyChangingArgs.ParseErrorMessage;
					if (parseErrorMessage == null)
					{
						_ = __KnownINotifyPropertyChangingArgs.InputText;
						__ldftn(Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.GetExposedInterfaces);
						__KnownINotifyPropertyChangingArgs.LanGames = (PropertyChangingEventArgs)new IContentControlOverridesMethods();
					}
					if (((IEnumerable<EntityNetGameItem>)(nint)iID).Select((Func<EntityNetGameItem, DesktopGameModel>)(object)parseErrorMessage) == null)
					{
						obj3 = 1;
						if (__KnownINotifyPropertyChangingArgs.LikeNetGames == null)
						{
							obj3 = 0;
						}
						goto IL_00ae;
					}
					goto IL_0453;
					IL_06ce:
					__KnownINotifyPropertyChangingArgs.SelectedSkin = (PropertyChangingEventArgs)(-2);
					obj2 = 1;
					if (__KnownINotifyPropertyChangingArgs.HasSkins != null)
					{
						obj2 = 1;
					}
					break;
					IL_00ae:
					while (true)
					{
						int num;
						switch ((int)obj3)
						{
						case 23:
							obj3 = 6;
							if (IReadOnlyList_System_IDisposable._initialized != 0)
							{
								obj3 = 7;
							}
							continue;
						case 17:
							_ = ref IReadOnlyList_System_IDisposable.ReflectConnectedAttribute;
							((XamlUserType)(&obj)).BoxType<TimeSpan>((object)Unsafe.AsPointer(ref this));
							_ = 21;
							continue;
						case 21:
							return;
						case 9:
							obj = 0;
							IReadOnlyList_object.ReflectLogicalAttribute = 0;
							obj3 = 0;
							if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
							{
								obj3 = 0;
							}
							continue;
						default:
							IEnumerable_object._initialized = (nint)obj;
							obj3 = 17;
							continue;
						case 19:
							if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_get_Size_1((IntPtr)(nint)(&obj)) == 0)
							{
								obj3 = 9;
								continue;
							}
							goto case 13;
						case 14:
							obj = -1;
							GlobalVtableLookup.CreateAttribute = -1;
							obj = 13;
							obj3 = obj;
							continue;
						case 3:
						case 6:
							obj = Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute;
							obj3 = 6;
							if (Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute != null)
							{
								obj3 = 15;
							}
							continue;
						case 7:
							if (IListMethods<object>.Abi_GetAt_0((IntPtr)/*Error near IL_023f: Stack underflow*/, (uint)/*Error near IL_023f: Stack underflow*/) == null)
							{
								_ = 3;
								goto IL_0252;
							}
							goto IL_028b;
						case 1:
						case 16:
							__KnownINotifyPropertyChangingArgs.Description = (PropertyChangingEventArgs)IReadOnlyListMethods<object>.Abi_GetMany_3((IntPtr)/*Error near IL_03b7: Stack underflow*/, (uint)/*Error near IL_03b7: Stack underflow*/, ref Unsafe.As<_003CRepairShadowGameButton_Click_003Ed__4, object[]>(ref this));
							obj3 = 2;
							if (__KnownINotifyPropertyChangingArgs.ImageUrl != null)
							{
								obj3 = 4;
							}
							continue;
						case 24:
							if (IEnumeratorMethods<IDisposable>.Abi_get_Current_0((IntPtr)__KnownINotifyPropertyChangingArgs.Characters) == null)
							{
								obj3 = 8;
								continue;
							}
							goto case 10;
						case 15:
							__KnownINotifyPropertyChangingArgs.Title = null;
							obj3 = 14;
							continue;
						case 12:
							break;
						case 10:
						{
							ComWrappersSupport val = (ComWrappersSupport)new ComWrappersSupport((Func<Type, ComWrappers.ComInterfaceEntry[]>)/*Error near IL_0478: Stack underflow*/);
							IEnumerator_System_IDisposable.Do_Abi_GetMany_3((nint)/*Error near IL_0488: Stack underflow*/, (uint)/*Error near IL_0488: Stack underflow*/, (nint)val, (uint*)(int)IEnumerator_System_IDisposable.Do_Abi_MoveNext_2((nint)val, (byte*)(nint)__KnownINotifyPropertyChangingArgs.Type));
							/*Error near IL_0488: Member reference must be method, but was: Field*/;
						}
						case 13:
							_ = ref obj;
							if (IReadOnlyListMethods<IDisposable>.AbiToProjectionVftablePtr != (IntPtr)1)
							{
								_ = 1;
								if (__KnownINotifyPropertyChangingArgs.VerifyCodeDelayText == null)
								{
									_ = 2;
								}
								continue;
							}
							goto case 23;
						case 8:
						case 20:
							((Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails)(object)((Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails)(object)__KnownINotifyPropertyChangingArgs.InfoBarMessage).GetExposedInterfaces())._002Ector();
							_ = null;
							Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.SortAttribute();
							_ = 11;
							if (__KnownINotifyPropertyChangingArgs.SelectedFileName != null)
							{
								_ = 8;
							}
							continue;
						case 4:
							_ = __KnownINotifyPropertyChangingArgs.HasSelectedFile;
							if (IVisualElementMethods.AbiToProjectionVftablePtr != (IntPtr)0)
							{
								_ = 18;
								if (__KnownINotifyPropertyChangingArgs.SkippedCount != null)
								{
									_ = 20;
								}
								continue;
							}
							goto case 24;
						case 18:
							goto IL_05bf;
						case 2:
						case 5:
						case 11:
						case 22:
							goto IL_06ce;
							IL_028b:
							IList_object.Do_Abi_Append_7((nint)/*Error near IL_02ae: Stack underflow*/, (nint)(int)IList_object.Do_Abi_RemoveAt_6((nint)/*Error near IL_02a9: Stack underflow*/, IList_object.Do_Abi_InsertAt_5((nint)/*Error near IL_02a4: Stack underflow*/, IList_object.Do_Abi_IndexOf_3((nint)/*Error near IL_029a: Stack underflow*/, (nint)/*Error near IL_029a: Stack underflow*/, (uint*)/*Error near IL_029a: Stack underflow*/, (byte*)(int)IList_object.Do_Abi_GetView_2((nint)/*Error near IL_0295: Stack underflow*/, (nint*)(nint)Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute)), (nint)Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute)));
							num = 0;
							if (!_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_hasTimeout)
							{
								num = 0;
							}
							goto IL_0252;
							IL_0252:
							while (true)
							{
								switch (num)
								{
								case 3:
									_ = Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute;
									IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectMonoAttribute();
									_ = IList_object.Initialized;
									_ = null;
									IList_object.Init();
									_ = 2;
									continue;
								case 1:
									break;
								default:
									goto IL_06ce;
								}
								break;
							}
							goto IL_028b;
						}
						break;
					}
					goto IL_0453;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00뼀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779041, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00쀀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00섀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779054, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00숀()
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
		private unsafe sealed void _FF00_FF00_FF00쌀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779055, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00쐀(object P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0054: Expected Obj, but got I
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)(nint)Unsafe.AsPointer(ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized), ref *(object[]*)P_0);
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00씀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779052, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	private nint _refreshingComboBoxes;

	private static readonly object LanguageTags;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object UseGlobalProxy;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object ProxyPassword;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object ProxyUsername;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object UseGlobalProxyAuth;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object ProxyPort;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object ProxyAddress;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object UseCachedCredentials;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object SelectPage;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object CloseLoginWindow;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object LoginType;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object CharacterSelectMode;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object RandomNameType;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object SetRandomNickname;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object NotificationSound;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object Backdrop;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object Theme;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object Language;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object BlockIrcMessages;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object AutoNavigateToInstanceAfterLaunch;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object AutoLogin;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private nint _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object Bindings;

	internal static Settings DecorateStatelessElement;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Settings()
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.ArgumentNullException: Value cannot be null. (Parameter 'source')
		//    at System.Linq.ThrowHelper.ThrowArgumentNullException(ExceptionArgument argument)
		//    at System.Linq.Enumerable.Skip[TSource](IEnumerable`1 source, Int32 count)
		//    at ICSharpCode.Decompiler.CSharp.ArgumentList.GetArgumentResolveResultsDirect(Int32 skipCount) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 124
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Probe() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 493
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Run() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 438
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.ForMethodReference(ExpressionBuilder expressionBuilder, IMethod method, IType targetType, TranslatedExpression target, Boolean requireTarget, ExpectedTargetDetails expectedTargetDetails, Boolean isExtensionMethodReference, Boolean castTargetUpFront) in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 131
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.DisambiguateDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1718
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1648
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildMethodReference(IMethod method, Boolean isVirtual) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1639
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitLdFtn(LdFtn inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 5058
		//    at ICSharpCode.Decompiler.IL.LdFtn.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 3175
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitConv(Conv inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2307
		//    at ICSharpCode.Decompiler.IL.Conv.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2298
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildArgumentList(ExpectedTargetDetails expectedTargetDetails, ResolveResult target, IMethod method, Int32 firstParamIndex, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, Boolean writtenAsAssignment) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1070
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(OpCode callOpCode, IMethod method, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, IType constrainedTo) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 461
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(CallInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 255
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitNewObj(NewObj inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 538
		//    at ICSharpCode.Decompiler.IL.NewObj.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4578
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitConv(Conv inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2307
		//    at ICSharpCode.Decompiler.IL.Conv.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2298
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildArgumentList(ExpectedTargetDetails expectedTargetDetails, ResolveResult target, IMethod method, Int32 firstParamIndex, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, Boolean writtenAsAssignment) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1070
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(OpCode callOpCode, IMethod method, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, IType constrainedTo) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 461
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(CallInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 255
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitCall(Call inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2530
		//    at ICSharpCode.Decompiler.IL.Call.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2192
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Default(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 93
		//    at ICSharpCode.Decompiler.IL.ILVisitor`1.VisitCall(Call inst) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 7663
		//    at ICSharpCode.Decompiler.IL.Call.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2188
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
		//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertSwitchSectionBody(SwitchSection astSection, ILInstruction bodyInst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 334
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.TranslateSwitch(BlockContainer switchContainer, SwitchInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 280
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1334
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertLoop(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1354
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1325
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1338
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertAsBlock(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 87
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2435
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RefreshEnumComboBoxes()
	{
		_FF00_FF00_FF00_FF00㔀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LogoutButton_Click(object sender, object e)
	{
		_FF00_FF00_FF00_FF00_3200(sender, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRepairShadowGameButton_Click_003Ed__4))]
	private void RepairShadowGameButton_Click(object sender, object e)
	{
		_FF00_FF00_FF00_FF00ἀ(sender, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BindEnum<T>(ComboBox comboBox, string name, Action<T>? onChanged = null)
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BindLanguage(object comboBox)
	{
		_FF00_FF00_FF00_FF00㐀(comboBox);
	}

	private bool IsProxyAuthEnabled(bool useProxy, bool useAuth)
	{
		return useProxy & useAuth;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BindText(object textBox, object name)
	{
		_FF00_FF00_FF00_FF00_2F00(textBox, name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BindNumberBox(object numberBox, object name, uint defaultValue)
	{
		_FF00_FF00_FF00_FF00_2A00(numberBox, name, defaultValue);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BindPasswordBox(object passwordBox, object name)
	{
		_FF00_FF00_FF00_FF00㠀(passwordBox, name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BindBool(object toggleSwitch, object name, Action<bool>? onChanged = null)
	{
		_FF00_FF00_FF00_FF00㰀(toggleSwitch, name, onChanged);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateBlockIrc(byte value)
	{
		_FF00_FF00_FF00_FF00_3300(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		_FF00_FF00_FF00_FF00_3100();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		_FF00_FF00_FF00_FF00㼀((uint)connectionId, target);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		return (IComponentConnector)_FF00_FF00_FF00_FF00㸀((uint)connectionId, target);
	}

	static Settings()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_001f: Expected I4, but got Obj
		//IL_0054->IL0012: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				LanguageTags = new string[2]
				{
					(string)ZYXDNGuarder._FF00_FF00_FF00_FF00ᰀ(),
					(string)ZYXDNGuarder._FF00_FF00_FF00_FF00ᴀ()
				};
				obj2 = 0;
				if (_003CModule_003E_007Bcdc0cbc7_002D464a_002D4cb5_002D949f_002Deb12b1e2047b_007D.m_1f9c47eae2c64b22a37472c24214705c.m_09a204e11c2b40fe85f9fcaa861f322a == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MatchTracker()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Settings AssembleFinalizer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00Ḁ(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778724, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00ἀ(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_00a1: Expected Obj, but got Ref
		//IL_0047: Expected Obj, but got Ref
		//IL_004c: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I
		//IL_0073: Expected Obj, but got Ref
		//IL_007a: Expected Obj, but got Ref
		//IL_0089: Expected Obj, but got I
		//IL_00b5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0060->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008e->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00c0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0099->IL0026: Incompatible stack heights: 3 vs 1
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
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = ExceptionHelpers.GetHRForException((Exception)(&obj));
				obj2 = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					obj2 = 0;
				}
				break;
			case 2:
				return;
			case 3:
				_ = ref IList_object._initialized;
				CastExtensions.As<MainContent>((object)(&obj));
				_ = 1;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
				{
					_ = 2;
				}
				break;
			default:
				IReadOnlyList_System_IDisposable._initialized = -1;
				obj2 = 3;
				if (IReadOnlyList_object._initialized == 0)
				{
					obj2 = 3;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_2000(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778725, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_2100()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778722, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_2200()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_2300(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778723, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_2400(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		_003CModule_003E.CheckAccessibleAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_2500(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778720, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00_2600(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778721, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00_2700(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_007d: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I4
		//IL_0094: Expected I, but got Obj
		//IL_0082->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005b->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00aa->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0066->IL0026: Incompatible stack heights: 3 vs 1
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
			default:
				return;
			case 2:
				ExceptionHelpers.GetHRForException((Exception)(-1));
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					_ = 1;
				}
				break;
			case 1:
				/*Error near IL_006e: Stack underflow*/((object[])P_0, (nint)obj);
				obj2 = 0;
				if (IList_object.PatchAttribute != null)
				{
					obj2 = 0;
				}
				break;
			case 0:
				return;
			case 3:
				obj = IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)P_0);
				obj2 = 2;
				if (IReadOnlyList_System_IDisposable._initialized == 0)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00_2800(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778734, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_2A00(object P_0, object P_1, uint P_2)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.ArgumentNullException: Value cannot be null. (Parameter 'source')
		//    at System.Linq.ThrowHelper.ThrowArgumentNullException(ExceptionArgument argument)
		//    at System.Linq.Enumerable.Skip[TSource](IEnumerable`1 source, Int32 count)
		//    at ICSharpCode.Decompiler.CSharp.ArgumentList.GetArgumentResolveResultsDirect(Int32 skipCount) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 124
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Probe() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 493
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Run() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 438
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.ForMethodReference(ExpressionBuilder expressionBuilder, IMethod method, IType targetType, TranslatedExpression target, Boolean requireTarget, ExpectedTargetDetails expectedTargetDetails, Boolean isExtensionMethodReference, Boolean castTargetUpFront) in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 131
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.DisambiguateDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1718
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1648
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildMethodReference(IMethod method, Boolean isVirtual) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1639
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitLdFtn(LdFtn inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 5058
		//    at ICSharpCode.Decompiler.IL.LdFtn.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 3175
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitConv(Conv inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2307
		//    at ICSharpCode.Decompiler.IL.Conv.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2298
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildArgumentList(ExpectedTargetDetails expectedTargetDetails, ResolveResult target, IMethod method, Int32 firstParamIndex, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, Boolean writtenAsAssignment) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1070
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(OpCode callOpCode, IMethod method, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, IType constrainedTo) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 461
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(CallInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 255
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitNewObj(NewObj inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 538
		//    at ICSharpCode.Decompiler.IL.NewObj.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4578
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitConv(Conv inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2307
		//    at ICSharpCode.Decompiler.IL.Conv.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2298
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildArgumentList(ExpectedTargetDetails expectedTargetDetails, ResolveResult target, IMethod method, Int32 firstParamIndex, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, Boolean writtenAsAssignment) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1070
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(OpCode callOpCode, IMethod method, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, IType constrainedTo) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 461
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(CallInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 255
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitCallVirt(CallVirt inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2535
		//    at ICSharpCode.Decompiler.IL.CallVirt.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2215
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Default(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 93
		//    at ICSharpCode.Decompiler.IL.ILVisitor`1.VisitCallVirt(CallVirt inst) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 7667
		//    at ICSharpCode.Decompiler.IL.CallVirt.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2211
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
		//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertSwitchSectionBody(SwitchSection astSection, ILInstruction bodyInst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 334
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.TranslateSwitch(BlockContainer switchContainer, SwitchInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 280
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1334
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertLoop(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1354
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1325
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1338
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertAsBlock(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 87
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2435
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_2B00()
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
	private unsafe void _FF00_FF00_FF00_FF00_2E00(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778735, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_2F00(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_004f: Expected I4, but got Obj
		//IL_008e: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I4
		//IL_00ef: Expected Obj, but got I
		//IL_00ae: Expected I, but got VT
		//IL_00b4: Expected I, but got Obj
		//IL_00b4: Expected I, but got Obj
		//IL_014f: Expected I, but got Obj
		//IL_0154: Expected I, but got Obj
		//IL_0187: Expected I, but got Obj
		//IL_0187: Expected I, but got Obj
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected I, but got Unknown
		//IL_01a7: Expected Obj, but got I4
		//IL_00a1->IL0022: Incompatible stack heights: 2 vs 0
		//IL_00f4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0130->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00cd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0168->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0115->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ff->IL0026: Incompatible stack types: I4 vs Obj
		//IL_013b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0173->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0199->IL0199: Incompatible stack heights: 0 vs 1
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
				default:
					IEnumerator_object.Do_Abi_MoveNext_2((nint)/*Error near IL_0082: Stack underflow*/, (byte*)(int)IEnumerator_object.Init());
					CastExtensions.As<NotificationPanel>((object)MarshalInspectable<object>.FromAbiArray((object)IList_object._initialized));
					obj = 8;
					break;
				case 6:
					return;
				case 5:
					IReadOnlyList_object._initialized = (IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00b4: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)obj, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)(IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)typeof(IEnumerable_object).TypeHandle) ? 1 : 0), (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)P_1) ? 1 : 0);
					obj2 = 0;
					if (IEnumerator_System_IDisposable._initialized == 0)
					{
						obj2 = 1;
					}
					continue;
				case 2:
					IEnumerator_System_IDisposable.ReflectTransferableAttribute = P_0;
					obj2 = 5;
					if (IEnumerable_System_IDisposable.CombineAttribute == null)
					{
						obj2 = 5;
					}
					continue;
				case 1:
					if (IEnumerable_object._initialized != 0)
					{
						obj2 = 4;
						continue;
					}
					goto default;
				case 3:
					obj = new IReadOnlyList_System_ComponentModel_INotifyPropertyChanged();
					obj2 = 2;
					if (Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute == null)
					{
						obj2 = 2;
					}
					continue;
				case 7:
					_ = Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute;
					IListMethods<object>.Abi_GetView_2((IntPtr)new IListMethods<object>((IntPtr)obj, (uint)(delegate* unmanaged[Stdcall]<nint, nint*, uint>)(&IEnumerable_System_ComponentModel_INotifyPropertyChanged.Do_Abi_First_0)));
					_ = 3;
					if (Mass_WinUI_AppWinRTTypeDetails.CheckHiddenAttribute != null)
					{
						_ = 6;
					}
					continue;
				case 8:
					return;
				case 4:
				{
					IListMethods<object>.Abi_RemoveAt_6((IntPtr)/*Error near IL_018c: Stack underflow*/, IList_object.Do_Abi_GetView_2((nint)Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute, (nint*)(nint)Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute));
					IReadOnlyListMethods<> val = (IReadOnlyListMethods<>)/*Error near IL_018d: Stack underflow*/;
					if ((int)val == 0)
					{
					}
					IListMethods<object>.Abi_Clear_9((IntPtr)val);
					obj = 7;
					break;
				}
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_3100()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0067: Expected I, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I4
		//IL_0071->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0091->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ca->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d5->IL0026: Incompatible stack types: I4 vs Obj
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
				case 1:
					break;
				default:
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)obj, ref *(object[]*)null);
					_ = 3;
					continue;
				case 5:
					obj = new Action<object[], nint>((object[])/*Error near IL_007b: Stack underflow*/, (nint)(int)IEnumerator_object.Init());
					obj2 = 0;
					if (IList_object.PatchAttribute != null)
					{
						obj2 = 0;
					}
					continue;
				case 2:
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						return;
					}
					obj2 = 1;
					if (IReadOnlyList_System_IDisposable._initialized == 0)
					{
						obj2 = 0;
					}
					continue;
				case 3:
					return;
				}
				break;
			}
			IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = 1;
			obj = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_3200(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_004f: Expected I4, but got Obj
		//IL_00d6: Expected I, but got Obj
		//IL_00e2: Expected I, but got Obj
		//IL_00e2: Expected I, but got Obj
		//IL_006f: Expected Obj, but got I
		//IL_01a9: Expected Obj, but got VT
		//IL_010c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0158->IL0026: Incompatible stack heights: 6 vs 1
		//IL_00ec->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0098->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00c1->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0117->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0163->IL0026: Incompatible stack heights: 6 vs 1
		//IL_012d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a3->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00cc->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0179->IL0190: Incompatible stack heights: 1 vs 2
		//IL_0074->IL0026: Incompatible stack heights: 4 vs 1
		//IL_01ae->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007f->IL0026: Incompatible stack heights: 4 vs 1
		//IL_01b9->IL0026: Incompatible stack types: I4 vs Obj
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
			case 8:
				return;
			case 6:
				IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_0084: Stack underflow*/, (uint)/*Error near IL_0084: Stack underflow*/, (nint)/*Error near IL_0084: Stack underflow*/, (uint*)/*Error near IL_0084: Stack underflow*/);
				_ = 2;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					_ = 7;
				}
				break;
			case 7:
				IEnumerator_object._002Ecctor();
				IEnumerator_object.DecorateAutomatableAttribute();
				_ = 5;
				if (IReadOnlyList_object._initialized != 0)
				{
					_ = 0;
				}
				break;
			case 3:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3((nint)/*Error near IL_00e2: Stack underflow*/, (uint)/*Error near IL_00e2: Stack underflow*/, IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_IndexOf_2((nint)/*Error near IL_00db: Stack underflow*/, (nint)/*Error near IL_00db: Stack underflow*/, (uint*)/*Error near IL_00db: Stack underflow*/, (byte*)(int)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_00d6: Stack underflow*/, (uint)/*Error near IL_00d6: Stack underflow*/, (nint*)(nint)IReadOnlyList_object.ReflectLogicalAttribute)), unchecked((nint)null), (uint*)unchecked((nint)null));
				_ = 2;
				break;
			default:
				MarshalInterface<INotifyPropertyChanged>.CopyManagedArray((INotifyPropertyChanged[])IEnumerable_System_IDisposable.CombineAttribute, (IntPtr)0);
				obj2 = 6;
				if (GlobalVtableLookup.CreateAttribute == null)
				{
					obj2 = 3;
				}
				break;
			case 4:
			{
				if ((nint)MarshalInterface<IEnumerator<INotifyPropertyChanged>>.FromManaged((IEnumerator<INotifyPropertyChanged>)/*Error near IL_011d: Stack underflow*/) > 0)
				{
					obj2 = 3;
					break;
				}
				IListMethods<object>.Abi_SetAt_4((IntPtr)/*Error near IL_0169: Stack underflow*/, (uint)/*Error near IL_0169: Stack underflow*/, (object)/*Error near IL_0169: Stack underflow*/);
				object reflectPortableAttribute;
				object val;
				if (Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute == null)
				{
					reflectPortableAttribute = Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute;
					val = (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.ReflectLiteralAttribute = new IListMethods<object>((IntPtr)(nint)(delegate* unmanaged[Stdcall]<nint, uint, nint, uint>)(&IList_object.Do_Abi_SetAt_4)));
				}
				((AsyncTaskMethodBuilder*)reflectPortableAttribute)->Start(ref *(AccountViewModel._003CLoginRandom_003Ed__85*)val);
				if ((int)/*Error near IL_019a: Stack underflow*/ == 0)
				{
					_003CModule_003E.CheckAccessibleAttribute();
					_ = 0;
					_ = IEnumerator_object.Initialized;
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						_ = 0;
					}
				}
				else
				{
					obj2 = 1;
					if (!_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_hasTimeout)
					{
						obj2 = 1;
					}
				}
				break;
			}
			case 5:
				return;
			case 1:
				_ = Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute;
				IEnumerable_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
				IEnumerable_System_ComponentModel_INotifyPropertyChanged.DecorateSeparatedAttribute();
				_ = null;
				_ = null;
				IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectMonoAttribute();
				_ = 0;
				if (Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute == null)
				{
					_ = 8;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_3300(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_007e: Expected Obj, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected I, but got Unknown
		//IL_005d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0083->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ef->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00fa->IL0026: Incompatible stack heights: 3 vs 1
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
			case 1:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (int)P_0;
				obj2 = 3;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 3;
				}
				break;
			case 2:
				obj = new IEnumerator_object((nint)/*Error near IL_006d: Stack underflow*/, (byte*)/*Error near IL_006d: Stack underflow*/);
				obj2 = 0;
				if (IList_object.PatchAttribute == null)
				{
					obj2 = 1;
				}
				break;
			case 3:
			{
				object obj3 = IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)/*Error near IL_0093: Stack underflow*/);
				object instance = IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute ?? (IReadOnlyList_object.ReflectLogicalAttribute = new IReadOnlyListMethods<INotifyPropertyChanged>((IntPtr)IReadOnlyList_System_IDisposable._initialized, (uint)(delegate*<IEnumerator_object>)(&IEnumerator_object.LoadAttribute)));
				((XamlUserType)/*Error near IL_00c9: Stack underflow*/).BoxType<EasingType>(((XamlUserType)/*Error near IL_00c4: Stack underflow*/).BoxType<int>(((XamlUserType)obj3).BoxType<EasingMode>(instance)));
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_get_Size_1((IntPtr)new MarshalInterface<INotifyPropertyChanged>((INotifyPropertyChanged[])obj, (IntPtr)(nint)(delegate* unmanaged[Stdcall]<nint, uint*, uint>)(&IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1)));
				_ = 0;
				if (Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute != null)
				{
					_ = 0;
				}
				break;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00㐀(object P_0)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.ArgumentNullException: Value cannot be null. (Parameter 'source')
		//    at System.Linq.ThrowHelper.ThrowArgumentNullException(ExceptionArgument argument)
		//    at System.Linq.Enumerable.Skip[TSource](IEnumerable`1 source, Int32 count)
		//    at ICSharpCode.Decompiler.CSharp.ArgumentList.GetArgumentResolveResultsDirect(Int32 skipCount) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 124
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Probe() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 493
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Run() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 438
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.ForMethodReference(ExpressionBuilder expressionBuilder, IMethod method, IType targetType, TranslatedExpression target, Boolean requireTarget, ExpectedTargetDetails expectedTargetDetails, Boolean isExtensionMethodReference, Boolean castTargetUpFront) in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 131
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.DisambiguateDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1718
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1648
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildMethodReference(IMethod method, Boolean isVirtual) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1639
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitLdFtn(LdFtn inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 5058
		//    at ICSharpCode.Decompiler.IL.LdFtn.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 3175
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Default(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 93
		//    at ICSharpCode.Decompiler.IL.ILVisitor`1.VisitLdFtn(LdFtn inst) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 7747
		//    at ICSharpCode.Decompiler.IL.LdFtn.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 3171
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
		//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertSwitchSectionBody(SwitchSection astSection, ILInstruction bodyInst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 334
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.TranslateSwitch(BlockContainer switchContainer, SwitchInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 280
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1334
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertLoop(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1354
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1325
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1338
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertAsBlock(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 87
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2435
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00㔀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0057: Expected I4, but got Obj
		//IL_0146: Expected I, but got Obj
		//IL_008d: Expected I, but got Obj
		//IL_00f2: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I
		//IL_00e1: Expected I, but got Obj
		//IL_019b: Expected I, but got Obj
		//IL_00a2: Expected I, but got Obj
		//IL_015a->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0097->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0106->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00eb->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00d6->IL0026: Incompatible stack heights: 3 vs 1
		//IL_01a5->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0130->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0077->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0184->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00b6->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0165->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0111->IL0026: Incompatible stack types: I4 vs Obj
		//IL_013b->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0082->IL0026: Incompatible stack types: I4 vs Obj
		//IL_018f->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00c1->IL0026: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 8;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 8:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = 1;
				obj2 = 7;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					obj2 = 3;
				}
				break;
			case 1:
				IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_008d: Stack underflow*/, (uint)/*Error near IL_008d: Stack underflow*/, (nint)/*Error near IL_008d: Stack underflow*/, (uint*)(nint)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute);
				_ = 2;
				break;
			case 10:
				IEnumerator_object.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_00a2: Stack underflow*/, (byte*)(nint)IList_object.PatchAttribute);
				_ = 0;
				if (IReadOnlyList_System_IDisposable._initialized == 0)
				{
					_ = 0;
				}
				break;
			case 5:
				_ = IReadOnlyList_System_IDisposable.ReflectConnectedAttribute;
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Initialized;
				_ = 9;
				break;
			case 4:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_00e1: Stack underflow*/, (uint)/*Error near IL_00e1: Stack underflow*/, (nint*)(nint)IReadOnlyList_object.ReflectLogicalAttribute);
				_ = 5;
				break;
			case 2:
				IEnumerator_System_IDisposable.ReflectTransferableAttribute = 0;
				obj2 = 3;
				if (IEnumerable_System_IDisposable.CombineAttribute == null)
				{
					obj2 = 3;
				}
				break;
			case 7:
				_ = IEnumerable_object._initialized;
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.MoveAttribute();
				_ = 6;
				if (Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute == null)
				{
					_ = 0;
				}
				break;
			default:
				IEnumerable_System_ComponentModel_INotifyPropertyChanged.Do_Abi_First_0((nint)/*Error near IL_0146: Stack underflow*/, (nint*)(nint)Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute);
				_ = 1;
				if (Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute == null)
				{
					_ = 1;
				}
				break;
			case 9:
				_ = Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute;
				_ = IList_object.Initialized;
				_ = 10;
				if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute == null)
				{
					_ = 7;
				}
				break;
			case 3:
				return;
			case 6:
				IList_object.Do_Abi_IndexOf_3((nint)/*Error near IL_019b: Stack underflow*/, (nint)/*Error near IL_019b: Stack underflow*/, (uint*)/*Error near IL_019b: Stack underflow*/, (byte*)(nint)Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute);
				_ = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00㘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778732, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00㠀(object P_0, object P_1)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.ArgumentNullException: Value cannot be null. (Parameter 'source')
		//    at System.Linq.ThrowHelper.ThrowArgumentNullException(ExceptionArgument argument)
		//    at System.Linq.Enumerable.Skip[TSource](IEnumerable`1 source, Int32 count)
		//    at ICSharpCode.Decompiler.CSharp.ArgumentList.GetArgumentResolveResultsDirect(Int32 skipCount) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 124
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Probe() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 493
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Run() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 438
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.ForMethodReference(ExpressionBuilder expressionBuilder, IMethod method, IType targetType, TranslatedExpression target, Boolean requireTarget, ExpectedTargetDetails expectedTargetDetails, Boolean isExtensionMethodReference, Boolean castTargetUpFront) in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 131
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.DisambiguateDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1718
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1648
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildMethodReference(IMethod method, Boolean isVirtual) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1639
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitLdFtn(LdFtn inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 5058
		//    at ICSharpCode.Decompiler.IL.LdFtn.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 3175
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Default(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 93
		//    at ICSharpCode.Decompiler.IL.ILVisitor`1.VisitLdFtn(LdFtn inst) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 7747
		//    at ICSharpCode.Decompiler.IL.LdFtn.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 3171
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
		//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertSwitchSectionBody(SwitchSection astSection, ILInstruction bodyInst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 334
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.TranslateSwitch(BlockContainer switchContainer, SwitchInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 280
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1334
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertLoop(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1354
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1325
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1338
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertAsBlock(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 87
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2435
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00㤀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778733, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00㬀(object P_0, object P_1, Action<bool> P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778730, new IntPtr(2737336163692L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00㰀(object P_0, object P_1, Action<bool> P_2)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0057: Expected I4, but got Obj
		//IL_01ba: Expected I, but got Obj
		//IL_00cb: Expected Obj, but got I4
		//IL_0066: Expected Ref, but got VT
		//IL_0068: Expected Obj, but got I4
		//IL_0192: Expected I4, but got Obj
		//IL_0192: Expected I, but got Obj
		//IL_00fe: Expected I, but got Obj
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected I, but got Unknown
		//IL_01c4->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00df->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0072->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0159->IL0026: Incompatible stack types: I4 vs Obj
		//IL_013d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01a1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ea->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0093->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0121->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0164->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_012c->IL0026: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 7;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				obj = IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)/*Error near IL_0066: Stack underflow*/, ref *(object[]*)typeof(IEnumerable_System_ComponentModel_INotifyPropertyChanged).TypeHandle);
				obj2 = 9;
				break;
			case 5:
				return;
			case 2:
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					obj2 = 3;
					if (IList_object._initialized != 0)
					{
						obj2 = 2;
					}
					break;
				}
				goto case 1;
			case 10:
				IList_object.PatchAttribute = P_0;
				obj2 = 4;
				break;
			case 1:
			{
				uint num = IEnumerator_object.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_00b5: Stack underflow*/, (byte*)/*Error near IL_00b5: Stack underflow*/);
				IEnumerator_object._002Ecctor();
				((XamlUserType)/*Error near IL_00cb: Stack underflow*/).BoxType<TimeSpan>((object)IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00c6: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00c6: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)(int)num, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)IReadOnlyList_System_IDisposable._initialized));
				_ = 8;
				if (IEnumerator_System_IDisposable._initialized == 0)
				{
					_ = 8;
				}
				break;
			}
			case 8:
				return;
			case 3:
				MarshalInterface<INotifyPropertyChanged>.CopyManagedArray((INotifyPropertyChanged[])/*Error near IL_0103: Stack underflow*/, (IntPtr)(int)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1((nint)IEnumerator_System_IDisposable.ReflectTransferableAttribute, (uint*)IEnumerable_System_IDisposable._initialized));
				IEnumerableMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(IEnumeratorMethods<, >)(object)/*Error near IL_0104: Stack underflow*/);
				_ = 0;
				if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute != null)
				{
					_ = 0;
				}
				break;
			case 7:
				obj = new IEnumerable_System_ComponentModel_INotifyPropertyChanged((nint)/*Error near IL_0131: Stack underflow*/, (nint*)/*Error near IL_0131: Stack underflow*/);
				obj2 = 6;
				break;
			case 6:
				Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute = P_2;
				obj2 = 10;
				if (Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute == null)
				{
					obj2 = 8;
				}
				break;
			case 9:
				IListMethods<object>.Abi_SetAt_4((IntPtr)obj, (uint)(int)obj, P_1);
				Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute = (object)/*Error near IL_0197: Stack underflow*/;
				obj2 = 2;
				break;
			default:
				_ = Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute;
				IListMethods<object>.Abi_Clear_9((IntPtr)new IListMethods<object>((IntPtr)(nint)(delegate* unmanaged[Stdcall]<nint, uint, nint, uint>)(&IList_object.Do_Abi_SetAt_4)));
				_ = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00㴀(object P_0, object P_1, Action<bool> P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778731, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed object _FF00_FF00_FF00_FF00㸀(uint P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0071: Expected I, but got Obj
		//IL_007f: Expected I, but got Obj
		//IL_007f: Expected I, but got Obj
		//IL_009a: Expected I, but got Obj
		//IL_0056: Expected Obj, but got I
		//IL_00a4->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00bb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0066->IL0026: Incompatible stack types: I4 vs Obj
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
				if (P_0 == 1)
				{
					obj2 = 0;
					if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute != null)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
			default:
				obj = new IEnumerator_object((nint)/*Error near IL_0071: Stack underflow*/, (byte*)(nint)(ValueType)P_1);
				obj = obj;
				IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_007f: Stack underflow*/, (uint)/*Error near IL_007f: Stack underflow*/, (nint)obj, (uint*)(nint)this);
				IList_object.PatchAttribute = obj;
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1(new MarshalInspectable<object>(obj, (byte)(delegate* unmanaged[Stdcall]<nint, byte*, uint>)(&IEnumerator_object.Do_Abi_get_HasCurrent_1) != 0));
				_ = 3;
				continue;
			case 2:
				obj = null;
				obj2 = 1;
				if (IReadOnlyList_object._initialized == 0)
				{
					obj2 = 0;
				}
				continue;
			case 3:
				break;
			}
			break;
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00㼀(uint P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_00e7: Expected I4, but got Obj
		//IL_055c: Expected Obj, but got I4
		//IL_0132: Expected Obj, but got I
		//IL_0254: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I
		//IL_019e: Expected Obj, but got I
		//IL_015d: Expected Obj, but got I
		//IL_0324: Expected Obj, but got I4
		//IL_05e1: Expected Obj, but got I4
		//IL_066f: Expected Obj, but got I4
		//IL_01dd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0217->IL0026: Incompatible stack types: I4 vs Obj
		//IL_043a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0530->IL0026: Incompatible stack types: I4 vs Obj
		//IL_045b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03df->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0242->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0183->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03af->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0561->IL0022: Incompatible stack heights: 5 vs 0
		//IL_060b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0137->IL0026: Incompatible stack types: I4 vs Obj
		//IL_025e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_041a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_064f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01a3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0162->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04ae->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05e6->IL0022: Incompatible stack heights: 4 vs 0
		//IL_0404->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01e8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0222->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0445->IL0026: Incompatible stack types: I4 vs Obj
		//IL_053b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_024d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03ba->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0142->IL0026: Incompatible stack types: I4 vs Obj
		//IL_065a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0117->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01ae->IL0026: Incompatible stack types: I4 vs Obj
		//IL_016d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04b9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02f5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0300->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 43;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 28:
					((AsyncVoidMethodBuilder*)/*Error near IL_00f3: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)this, ref *(App._003CLogout_003Ed__15*)P_1);
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = (object)/*Error near IL_00f8: Stack underflow*/;
					obj2 = 1;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						obj2 = 14;
					}
					continue;
				case 18:
					goto IL_0117;
				case 30:
					goto IL_0142;
				case 10:
					goto IL_016d;
				case 29:
					goto IL_0183;
				default:
					goto IL_01bd;
				case 1:
					goto IL_01f7;
				case 9:
					goto IL_0222;
				case 4:
				case 7:
				case 8:
				case 11:
				case 13:
				case 14:
				case 15:
				case 19:
				case 23:
				case 24:
				case 25:
				case 26:
				case 27:
				case 32:
				case 33:
				case 34:
				case 36:
				case 37:
				case 39:
				case 40:
				case 42:
				case 44:
				case 45:
					goto IL_024d;
				case 43:
					switch (P_0)
					{
					case 9u:
						break;
					case 13u:
						goto IL_0117;
					case 26u:
						goto IL_0142;
					case 28u:
						goto IL_016d;
					case 2u:
						goto IL_0183;
					case 25u:
						goto IL_01bd;
					case 12u:
						goto IL_01f7;
					case 21u:
						goto IL_0222;
					case 3u:
					case 4u:
					case 5u:
					case 6u:
					case 7u:
						goto IL_024d;
					default:
						goto IL_02e1;
					case 11u:
						goto IL_030f;
					case 19u:
						goto IL_038f;
					case 18u:
						goto IL_03c9;
					case 15u:
						goto IL_03ee;
					case 20u:
						goto IL_0404;
					case 10u:
						goto IL_041a;
					case 17u:
						goto IL_0445;
					case 22u:
						goto IL_048e;
					case 8u:
						goto IL_0510;
					case 27u:
						goto IL_053c;
					case 24u:
						goto IL_05c1;
					case 16u:
						goto IL_05f5;
					case 14u:
						goto IL_062f;
					case 23u:
						goto IL_065a;
					}
					goto case 28;
				case 31:
					goto IL_030f;
				case 12:
					goto IL_038f;
				case 6:
					goto IL_03c9;
				case 46:
					goto IL_03ee;
				case 20:
					goto IL_0404;
				case 2:
					goto IL_041a;
				case 5:
					goto IL_0445;
				case 35:
					goto IL_048e;
				case 3:
					goto IL_0510;
				case 21:
					return;
				case 16:
					goto IL_053c;
				case 38:
					goto IL_05c1;
				case 17:
					goto IL_05f5;
				case 22:
					goto IL_062f;
				case 41:
					goto IL_065a;
					IL_065a:
					((AsyncTaskMethodBuilder*)this)->Start(ref *(DesktopViewModel._003CRefreshLanGame_003Ed__46*)P_1);
					__KnownINotifyPropertyChangingArgs.DesktopAccounts = (PropertyChangingEventArgs)/*Error near IL_0666: Stack underflow*/;
					obj = 8;
					break;
					IL_062f:
					((AsyncTaskMethodBuilder*)this)->Start(ref *(DesktopViewModel._003CLaunchHeadlessShadowClient_003Ed__9*)P_1);
					__KnownINotifyPropertyChangingArgs.TotalPoints = (PropertyChangingEventArgs)/*Error near IL_063b: Stack underflow*/;
					obj2 = 2;
					if (__KnownINotifyPropertyChangingArgs.CreatedAt == null)
					{
						obj2 = 24;
					}
					continue;
					IL_0142:
					IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = CastExtensions.As<Segmented>(P_1);
					obj2 = 4;
					if (IReadOnlyList_object.ReflectLogicalAttribute == null)
					{
						obj2 = 25;
					}
					continue;
					IL_05f5:
					((AsyncTaskMethodBuilder*)this)->Start(ref *(DesktopViewModel._003CLaunchGame_003Ed__3*)P_1);
					__KnownINotifyPropertyChangingArgs.Image = (PropertyChangingEventArgs)/*Error near IL_0601: Stack underflow*/;
					obj2 = 26;
					continue;
					IL_05c1:
					((AsyncTaskMethodBuilder*)/*Error near IL_05c7: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)/*Error near IL_05c7: Stack underflow*/, ref *(ChatViewModel._003CSend_003Ed__9*)P_1);
					_ = (delegate*<bool>)(&IEnumerator_System_IDisposable.DecompressAttribute);
					new IEnumerableMethods<object>();
					_ = IListMethods.IID;
					obj = 44;
					break;
					IL_053c:
					((IEnumerable<AccountModel>)P_1).ToList();
					_ = (delegate*<byte>)(&IEnumerator_System_IDisposable.Init);
					new object();
					_ = IReadOnlyListMethods<object>.IID;
					obj = 45;
					break;
					IL_0510:
					__KnownINotifyPropertyChangingArgs.State = (PropertyChangingEventArgs)(object)((IEnumerable<string>)(object)this).FirstOrDefault((Func<string, bool>)P_1);
					obj2 = 11;
					if (__KnownINotifyPropertyChangingArgs.OperationText != null)
					{
						obj2 = 34;
					}
					continue;
					IL_01bd:
					Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute = Interlocked.CompareExchange(ref *(Func<InfoBarDelegate>*)/*Error near IL_01c4: Stack underflow*/, (Func<InfoBarDelegate>)(object)this, (Func<InfoBarDelegate>)P_1);
					obj2 = 39;
					if (Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute == null)
					{
						obj2 = 29;
					}
					continue;
					IL_048e:
					((AsyncTaskMethodBuilder*)/*Error near IL_0495: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)this, ref *(AccountViewModel._003CLogoutAccount_003Ed__23*)P_1);
					__KnownINotifyPropertyChangingArgs.BackgroundImageUrl = (PropertyChangingEventArgs)/*Error near IL_049a: Stack underflow*/;
					obj2 = 5;
					if (__KnownINotifyPropertyChangingArgs.Summary == null)
					{
						obj2 = 7;
					}
					continue;
					IL_0445:
					((AsyncTaskMethodBuilder*)/*Error near IL_044c: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)this, ref *(AccountViewModel._003CLoginHistoryAccount_003Ed__24*)P_1);
					__KnownINotifyPropertyChangingArgs.Description = (PropertyChangingEventArgs)/*Error near IL_0451: Stack underflow*/;
					obj2 = 13;
					continue;
					IL_041a:
					((AsyncTaskMethodBuilder*)/*Error near IL_0421: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<DesktopSession>*)this, ref *(AccountViewModel._003CLoginDesktop_003Ed__87*)P_1);
					__KnownINotifyPropertyChangingArgs.ShowMaxPlayer = (PropertyChangingEventArgs)/*Error near IL_0426: Stack underflow*/;
					obj2 = 40;
					if (__KnownINotifyPropertyChangingArgs.MaxPlayers == null)
					{
						obj2 = 25;
					}
					continue;
					IL_0183:
					IEnumerable_System_IDisposable.CombineAttribute = ((XamlUserType)this).BoxType<EasingType>(P_1);
					obj2 = 23;
					if (IEnumerable_object.ReflectSetAttribute == null)
					{
						obj2 = 12;
					}
					continue;
					IL_0404:
					((AsyncTaskMethodBuilder*)/*Error near IL_040b: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<ContentDialogResult>*)this, ref *(AccountViewModel._003CLoginByHistory_003Ed__25*)P_1);
					__KnownINotifyPropertyChangingArgs.IsSkeleton = (PropertyChangingEventArgs)/*Error near IL_0410: Stack underflow*/;
					obj2 = 11;
					continue;
					IL_03ee:
					((AsyncTaskMethodBuilder*)/*Error near IL_03f5: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<string>*)this, ref *(AccountViewModel._003CLoginBedrock_003Ed__86*)P_1);
					__KnownINotifyPropertyChangingArgs.Content = (PropertyChangingEventArgs)/*Error near IL_03fa: Stack underflow*/;
					obj2 = 37;
					continue;
					IL_03c9:
					((AsyncTaskMethodBuilder*)/*Error near IL_03d0: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)this, ref *(AccountViewModel._003CImportAccounts_003Ed__28*)P_1);
					__KnownINotifyPropertyChangingArgs.Message = (PropertyChangingEventArgs)/*Error near IL_03d5: Stack underflow*/;
					obj2 = 27;
					continue;
					IL_038f:
					((AsyncTaskMethodBuilder*)/*Error near IL_0396: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<(bool, string)>*)this, ref *(AccountViewModel._003CEditAccount_003Ed__22*)P_1);
					__KnownINotifyPropertyChangingArgs.CreateAt = (PropertyChangingEventArgs)/*Error near IL_039b: Stack underflow*/;
					obj2 = 11;
					if (__KnownINotifyPropertyChangingArgs.Name == null)
					{
						obj2 = 33;
					}
					continue;
					IL_0117:
					IList_object.PatchAttribute = CastExtensions.As<InvokeCommandAction>(P_1);
					obj2 = 4;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
					{
						obj2 = 4;
					}
					continue;
					IL_030f:
					((AsyncTaskMethodBuilder*)this)->Start(ref *(AccountViewModel._003CLoginRandom_003Ed__85*)P_1);
					_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout = (TimeSpan)/*Error near IL_031b: Stack underflow*/;
					obj = 15;
					break;
					IL_02e1:
					obj2 = 42;
					if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.ReflectLiteralAttribute == null)
					{
						obj2 = 2;
					}
					continue;
					IL_01f7:
					((AsyncTaskMethodBuilder*)this)->Start(ref *(AccountViewModel._003CEditAccount_003Ed__22*)P_1);
					Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute = (object)/*Error near IL_0203: Stack underflow*/;
					obj2 = 32;
					if (Mass_WinUI_AppWinRTTypeDetails.CheckHiddenAttribute != null)
					{
						obj2 = 14;
					}
					continue;
					IL_024d:
					Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute = 1;
					obj2 = 21;
					continue;
					IL_0222:
					((AsyncTaskMethodBuilder*)this)->Start(ref *(AccountViewModel._003CExportAccounts_003Ed__26*)P_1);
					Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute = (object)/*Error near IL_022e: Stack underflow*/;
					obj2 = 16;
					if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute != null)
					{
						obj2 = 36;
					}
					continue;
					IL_016d:
					IEnumerator_System_IDisposable.ReflectTransferableAttribute = ((XamlUserType)this).BoxType<EasingMode>(P_1);
					obj2 = 19;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00䀀(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778728, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
