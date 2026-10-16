using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using ABI.System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using Mass.Common.Extensions;
using Mass.WinUI.Enums;
using Mass.WinUI.Mass_WinUI_XamlTypeInfo;
using Mass.WinUI.ViewModels;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Markup;
using Serilog;
using WinRT;
using WinRT.Mass_WinUIGenericHelpers;
using WinRT.Mass_WinUIVtableClasses;
using WinUI.TableView;

namespace Mass.WinUI;

[WinRTExposedType(typeof(Mass_WinUI_AppWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IApplicationOverrides")]
public class App : Application, IXamlMetadataProvider
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLogout_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public App _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object DecorateIsolatedCreator;

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
		internal static bool ReplaceModel()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LoadCreator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00舀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775421, new IntPtr(2737323011196L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00茀()
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00萀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775418, new IntPtr(2737323012236L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00蔀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775419, new IntPtr(2737323012236L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00蘀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00蜀(object P_0)
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
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00褀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0050: Expected Obj, but got Ref
			//IL_009c: Expected Obj, but got Ref
			//IL_00b0: Expected Obj, but got I
			//IL_03d5: Expected Obj, but got Ref
			//IL_0075: Expected Obj, but got Ref
			//IL_0086: Expected Obj, but got I
			//IL_00d7: Expected Obj, but got I
			//IL_01d2: Expected Obj, but got Ref
			//IL_02bb: Expected I, but got Obj
			//IL_02bd: Expected Obj, but got I4
			//IL_0229: Expected Obj, but got Ref
			//IL_0229: Expected I4, but got Obj
			//IL_0144: Expected I, but got Obj
			//IL_0144: Expected I4, but got Obj
			//IL_014e: Expected Obj, but got I4
			//IL_0272: Expected Obj, but got Ref
			//IL_015d: Expected Obj, but got I4
			//IL_0162: Expected Obj, but got I4
			//IL_0162: Expected Obj, but got Ref
			//IL_0283: Expected I, but got Obj
			//IL_0181: Expected Obj, but got Ref
			//IL_0181: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Expected Obj, but got Ref
			//IL_01bd: Expected Obj, but got I4
			//IL_01c2: Expected Obj, but got I4
			//IL_01c2: Expected Obj, but got Ref
			//IL_02e2: Expected Obj, but got Ref
			//IL_030d: Expected I, but got Obj
			//IL_030d: Expected I, but got Obj
			//IL_020e: Expected Obj, but got I4
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00b5->IL0026: Incompatible stack heights: 2 vs 1
			//IL_03eb->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00c0->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00dc->IL00eb: Incompatible stack heights: 1 vs 2
			//IL_03f6->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0096->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0138->IL02c7: Incompatible stack heights: 1 vs 0
			//IL_00e7->IL00eb: Incompatible stack heights: 1 vs 2
			//IL_01ee->IL00eb: Incompatible stack heights: 3 vs 2
			//IL_02c7->IL00eb: Incompatible stack heights: 1 vs 2
			//IL_023d->IL00eb: Incompatible stack heights: 1 vs 2
			//IL_02a1->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0205->IL0306: Incompatible stack heights: 2 vs 1
			//IL_0317->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_01f9->IL00eb: Incompatible stack heights: 3 vs 2
			//IL_0248->IL00eb: Incompatible stack heights: 1 vs 2
			//IL_02ac->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_00eb->IL00eb: Incompatible stack heights: 3 vs 2
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				int num;
				switch ((int)obj2)
				{
				default:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = -2;
					obj2 = 2;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj2 = 2;
					}
					break;
				case 5:
					obj = IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute;
					obj2 = 1;
					if (IList_object.PatchAttribute == null)
					{
						obj2 = 4;
					}
					break;
				case 2:
					MarshalInspectable<object>.FromManaged((object)/*Error near IL_00a1: Stack underflow*/, (byte)Unsafe.AsPointer(ref IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized) != 0);
					_ = 1;
					if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute != null)
					{
						_ = 1;
					}
					break;
				case 3:
					if (obj == null)
					{
						_ = 0;
						if (IReadOnlyList_object.ReflectLogicalAttribute == null)
						{
							_ = 0;
						}
						goto IL_00eb;
					}
					goto IL_02c7;
				case 1:
					return;
				case 4:
					{
						obj = __KnownINotifyPropertyChangingArgs.BackgroundImageUrl;
						obj2 = 3;
						if (__KnownINotifyPropertyChangingArgs.Summary != null)
						{
							obj2 = 3;
						}
						break;
					}
					IL_02c7:
					obj3 = IReadOnlyListMethods<IDisposable>.Abi_GetAt_0((IntPtr)/*Error near IL_02d1: Stack underflow*/, IReadOnlyListMethods<IDisposable, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_02cc: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_02cc: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_02cc: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)/*Error near IL_02cc: Stack underflow*/) ? 1u : 0u);
					num = 4;
					goto IL_00eb;
					IL_00eb:
					while (true)
					{
						switch (num)
						{
						case 1:
							break;
						case 6:
							obj3 = MarshalInterface<INotifyPropertyChanged>.FromAbiArray((object)IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_0149: Stack underflow*/, (INotifyPropertyChanged)/*Error near IL_0149: Stack underflow*/, ref *(uint*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_0144: Stack underflow*/, (uint)(int)obj3, (nint*)(nint)obj)));
							num = 17;
							continue;
						case 8:
							obj = -1;
							IEnumerable_System_IDisposable.CombineAttribute = -1;
							num = 5;
							continue;
						case 10:
							IEnumerable_object._initialized = unchecked((nint)default(IEnumeratorMethods<, >));
							num = 8;
							continue;
						case 14:
							GlobalVtableLookup.CreateAttribute = obj;
							num = 1;
							if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute == null)
							{
								num = 3;
							}
							continue;
						case 15:
							obj = 0;
							Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute = 0;
							num = 14;
							continue;
						case 3:
							_ = ref Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute;
							((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CLogout_003Ed__15, AccountViewModel._003CLogoutAccount_003Ed__23>(ref this));
							_ = 5;
							if (Mass_WinUI_AppWinRTTypeDetails.CheckHiddenAttribute == null)
							{
								_ = 11;
							}
							continue;
						case 13:
							if (IList_object.Init() != 0)
							{
								obj = 6;
								continue;
							}
							goto case 17;
						case 2:
						case 5:
							IListMethods<object>.Abi_SetAt_4((IntPtr)/*Error near IL_0229: Stack underflow*/, (uint)(int)obj3, (object)(&obj));
							_ = 4;
							if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute == null)
							{
								_ = 13;
							}
							continue;
						case 11:
							return;
						default:
							obj = _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.ReflectLiteralAttribute;
							num = 10;
							continue;
						case 9:
						{
							uint num2 = IListMethods<object>.Abi_get_Size_1((IntPtr)(int)IList_object.Do_Abi_RemoveAtEnd_8((nint)(int)IList_object.Do_Abi_Append_7((nint)/*Error near IL_0283: Stack underflow*/, (nint)obj3)));
							num = 1;
							obj3 = num2;
							if (__KnownINotifyPropertyChangingArgs.Notes == null)
							{
								num = 1;
								obj3 = num2;
							}
							continue;
						}
						case 4:
							obj = IEnumeratorMethods<INotifyPropertyChanged>.Abi_get_HasCurrent_1((IntPtr)IEnumeratorMethods<INotifyPropertyChanged>.Abi_get_Current_0((IntPtr)(int)IEnumeratorMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)/*Error near IL_02b1: Stack underflow*/, ref *(INotifyPropertyChanged[]*)obj3)));
							_ = 16;
							continue;
						case 12:
							goto IL_02c7;
						case 16:
							if (MarshalInterface<IDisposable>.FromManaged((IDisposable)(&obj)) != (IntPtr)0)
							{
								num = 1;
								if (__KnownINotifyPropertyChangingArgs.CharacterName != null)
								{
									num = 2;
								}
								continue;
							}
							goto case 15;
						case 17:
						{
							uint num3 = IEnumerator_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Current_0((nint)obj3, (nint*)(nint)obj);
							num = 9;
							obj3 = num3;
							continue;
						}
						}
						break;
					}
					goto default;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00言()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775416, new IntPtr(2737323012236L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[CompilerGenerated]
	private static readonly object Logger__BackingField;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private nint _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object __appProvider;

	internal static App CheckAlphabeticDictionary;

	public static ILogger Logger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	public static App Current
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	public Window? Window
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (Window?)_FF00_FF00_FF00_FF00_FF00_FF00_FF00_2500();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00_2700(value);
		}
	}

	public FrameworkElement RootElement
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (FrameworkElement)_FF00_FF00_FF00_FF00_FF00_FF00_FF00Ⰰ();
		}
	}

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	private XamlMetaDataProvider _AppProvider
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (XamlMetaDataProvider)_FF00_FF00_FF00_FF00_FF00_FF00_FF00㼀();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe App()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_005f: Expected I, but got Obj
		//IL_006f: Expected I, but got Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		int num = ExceptionHelpers.GetHRForException((Exception)(object)this);
		int num2 = 1;
		if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
		{
			num2 = 1;
		}
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				num = (int)IEnumerator_object.Do_Abi_MoveNext_2((nint)num, (byte*)(nint)this);
				num2 = 2;
				break;
			case 1:
				num = (int)IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_006f: Stack underflow*/, (uint)/*Error near IL_006f: Stack underflow*/, (nint)num, (uint*)(nint)this);
				num2 = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAppRequestTheme(ElementTheme theme)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00䬀(theme);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAppRequestBackdrop(EnumBackdropType backdrop)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00_2900(backdrop);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowMainWindow()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00㰀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLogout_003Ed__15))]
	public void Logout()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00䔀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowLoginWindow()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00_2200();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnLaunched(LaunchActivatedEventArgs args)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00䐀(args);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AppClosing(bool closedByDirectWnd, AppWindow sender, AppWindowClosingEventArgs args)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00ᰀ(closedByDirectWnd ? ((byte)1) : ((byte)0), sender, args);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	public void InitializeComponent()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00䤀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	public IXamlType GetXamlType(Type type)
	{
		return (IXamlType)_FF00_FF00_FF00_FF00_FF00_FF00_FF00㠀(type);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	public IXamlType GetXamlType(string fullName)
	{
		return (IXamlType)_FF00_FF00_FF00_FF00_FF00_FF00_FF00䄀(fullName);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	public XmlnsDefinition[] GetXmlnsDefinitions()
	{
		return (XmlnsDefinition[])_FF00_FF00_FF00_FF00_FF00_FF00_FF00_2800();
	}

	static App()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_001f: Expected I4, but got Obj
		//IL_004d->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0058->IL0012: Incompatible stack types: I4 vs Obj
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
				Logger__BackingField = Log.Logger.Category((string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00_3300());
				obj2 = 0;
				if (_003CModule_003E_007Bcdc0cbc7_002D464a_002D4cb5_002D949f_002Deb12b1e2047b_007D.m_1f9c47eae2c64b22a37472c24214705c.m_a253804388724eda9f4f9477c2c3568a == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckEditableMonitor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static App CheckLogicalSynchronizer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_1B00(byte P_0, object P_1, object P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775398, new IntPtr(2737323034076L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᰀ(byte P_0, object P_1, object P_2)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00fd: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_0102->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00dc->IL0026: Incompatible stack heights: 2 vs 1
		//IL_010d->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00b7->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0062->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e7->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00c2->IL0026: Incompatible stack heights: 2 vs 1
		//IL_006d->IL0026: Incompatible stack types: I4 vs Obj
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
				if (P_0 != 0)
				{
					obj2 = 3;
					if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute == null)
					{
						obj2 = 1;
					}
					break;
				}
				MarshalInspectable<object>.FromManaged((object)/*Error near IL_00a3: Stack underflow*/, (byte)IEnumerator_object.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_009e: Stack underflow*/, (byte*)(int)IEnumerator_object.Do_Abi_get_Current_0((nint)/*Error near IL_0099: Stack underflow*/, (nint*)/*Error near IL_0099: Stack underflow*/)) != 0);
				_ = 0;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute != null)
				{
					_ = 1;
				}
				break;
			default:
				_ = 1;
				/*Error near IL_006f: Member reference must be method, but was: Field*/;
			case 3:
				return;
			case 5:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)/*Error near IL_00c8: Stack underflow*/, 0u);
				_ = 2;
				if (IEnumerator_System_IDisposable._initialized != 0)
				{
					_ = 2;
				}
				break;
			case 2:
				return;
			case 1:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00ee: Stack underflow*/, (INotifyPropertyChanged)/*Error near IL_00ee: Stack underflow*/, ref *(uint*)P_1);
				_ = 0;
				if (IEnumerable_System_IDisposable.CombineAttribute == null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᴀ(byte P_0, object P_1, object P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775399, new IntPtr(2737323040316L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ḁ()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001a: Expected Obj, but got I4
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IList_object)(object)ExceptionHelpers.GetHRForException((Exception)/*Error near IL_0019: Stack underflow*/);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ἀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775396, new IntPtr(2737323034076L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2100()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775397, new IntPtr(2737323012236L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2200()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00a8: Expected I4, but got Obj
		//IL_0074: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_00bd: Expected I, but got Obj
		//IL_00bd: Expected I4, but got Obj
		//IL_004f: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_00b2->IL0026: Incompatible stack heights: 2 vs 1
		//IL_008d->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00d1->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0098->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00dc->IL0026: Incompatible stack heights: 2 vs 1
		//IL_006e->IL0026: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		while (true)
		{
			switch ((int)obj)
			{
			case 4:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)_003CModule_003E.CheckAccessibleAttribute());
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 0;
				}
				break;
			case 1:
				IEnumerator_object.Do_Abi_get_Current_0((nint)/*Error near IL_0079: Stack underflow*/, (nint*)(int)IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_0074: Stack underflow*/, (uint)/*Error near IL_0074: Stack underflow*/, (nint)/*Error near IL_0074: Stack underflow*/, (uint*)(nint)this));
				_ = 4;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
				{
					_ = 1;
				}
				break;
			case 3:
				return;
			default:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)(IEnumerator_object.DecorateAutomatableAttribute() ? 1 : 0), (uint)(int)IEnumerator_object.LoadAttribute());
				_ = 3;
				break;
			case 2:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_00bd: Stack underflow*/, (uint)(int)this, (nint*)new IReadOnlyList_System_ComponentModel_INotifyPropertyChanged());
				_ = 1;
				if (IEnumerable_System_IDisposable._initialized == 0)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775394, new IntPtr(2737323040316L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775395, new IntPtr(2737323014316L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2500()
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
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2600(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775392, new IntPtr(2737323039276L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2700(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected I, but got Obj
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
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
			case 1:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
				obj2 = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
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
	internal unsafe sealed object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2800()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_0020: Expected Obj, but got I4
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		_003CModule_003E.CheckAccessibleAttribute();
		return IEnumerator_object.Initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2900(EnumBackdropType P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0075: Expected I, but got Obj
		//IL_007a: Expected I4, but got Obj
		//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
		//IL_006e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_008e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0099->IL0026: Incompatible stack types: I4 vs Obj
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
			case 2:
				return;
			case 1:
			{
				_003CModule_003E obj3 = _003CModule_003E.CheckAccessibleAttribute();
				if (obj3 == null)
				{
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						_ = 0;
					}
					break;
				}
				*(ValueTuple<int, nint>*)(nint)/*Error near IL_007a: Stack underflow*/ = ((int)this, (int)IEnumerator_object.Do_Abi_MoveNext_2((nint)obj3, (byte*)(int)P_0));
				obj2 = 2;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 0;
				}
				break;
			}
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2A00(EnumBackdropType P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775393, new IntPtr(2737323040316L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ⰰ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17095, 1790775406, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790775406, new IntPtr(2737323034076L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ⴀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775407, new IntPtr(2737323015356L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2E00()
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
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2F00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775404, new IntPtr(2737323015356L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_3000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775405, new IntPtr(2737323019516L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_3100()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_3200()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775402, new IntPtr(2737323015356L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775403, new IntPtr(2737323035116L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㔀()
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
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775400, new IntPtr(2737323024716L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㜀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775401, new IntPtr(2737323018476L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㠀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_0021: Expected Obj, but got I4
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		_003CModule_003E.CheckAccessibleAttribute();
		return IEnumerator_object.Initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㤀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775414, new IntPtr(2737323012236L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00㰀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_005b: Expected I4, but got Obj
		//IL_012e: Expected Obj, but got I4
		//IL_00e5: Expected I, but got Obj
		//IL_00ef: Expected Obj, but got I4
		//IL_00ff: Expected I, but got Obj
		//IL_010d: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I
		//IL_01a4: Expected I4, but got Obj
		//IL_0144->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0168->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00f9->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0112->IL0022: Incompatible stack heights: 1 vs 0
		//IL_0094->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0075->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00b8->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00d4->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0123->IL0026: Incompatible stack types: I4 vs Obj
		//IL_014f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_009f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00df->IL0026: Incompatible stack heights: 3 vs 1
		//IL_018f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_019a->IL0026: Incompatible stack heights: 2 vs 1
		//IL_01b3->IL0026: Incompatible stack types: I4 vs Obj
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
				case 4:
				case 8:
					new _003CModule_003E();
					_ = IEnumerator_object.Initialized;
					_ = 6;
					continue;
				case 7:
					/*Error near IL_0080: Stack underflow*/((object[])(object)this, (int)IEnumerator_object.Init());
					obj2 = 2;
					if (IList_object.PatchAttribute == null)
					{
						obj2 = 2;
					}
					continue;
				case 10:
				{
					uint num2 = IEnumerator_object.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_00a4: Stack underflow*/, (byte*)/*Error near IL_00a4: Stack underflow*/);
					IEnumerator_object._002Ecctor();
					IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)(int)num2);
					_ = 9;
					continue;
				}
				case 3:
					return;
				case 11:
					IEnumerator_object.LoadAttribute();
					_ = 9;
					if (IReadOnlyList_object.ReflectLogicalAttribute == null)
					{
						_ = 10;
					}
					continue;
				case 5:
					MarshalInterface<INotifyPropertyChanged>.FromAbiArray((object)IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00ea: Stack underflow*/, (INotifyPropertyChanged)/*Error near IL_00ea: Stack underflow*/, ref *(uint*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_00e5: Stack underflow*/, (uint)/*Error near IL_00e5: Stack underflow*/, (nint*)(nint)this)));
					_ = 7;
					continue;
				case 6:
					break;
				default:
				{
					if (obj != null)
					{
						obj2 = 11;
						continue;
					}
					IEnumerable_System_ComponentModel_INotifyPropertyChanged enumerable_System_ComponentModel_INotifyPropertyChanged = IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectMonoAttribute();
					if (enumerable_System_ComponentModel_INotifyPropertyChanged == null)
					{
						_ = 4;
						if (Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute != null)
						{
							_ = 3;
						}
					}
					else
					{
						IListMethods<object>.Abi_SetAt_4((IntPtr)/*Error near IL_01a4: Stack underflow*/, (uint)(int)this, (object)enumerable_System_ComponentModel_INotifyPropertyChanged);
						IListMethods<object>.Abi_InsertAt_5((IntPtr)/*Error near IL_01a9: Stack underflow*/, (uint)/*Error near IL_01a9: Stack underflow*/, (object)/*Error near IL_01a9: Stack underflow*/);
						obj2 = 8;
					}
					continue;
				}
				case 1:
					obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.MoveAttribute() as Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails;
					_ = 0;
					if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute != null)
					{
						_ = 0;
					}
					continue;
				case 2:
				{
					uint num = IEnumerable_System_ComponentModel_INotifyPropertyChanged.Do_Abi_First_0((nint)/*Error near IL_0154: Stack underflow*/, (nint*)/*Error near IL_0154: Stack underflow*/);
					IEnumerable_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
					IListMethods<object>.Abi_GetView_2((IntPtr)(int)num);
					_ = 3;
					continue;
				}
				case 9:
					return;
				}
				break;
			}
			IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1((nint)/*Error near IL_00ff: Stack underflow*/, (uint*)(nint)this);
			IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
			obj = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00㴀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775415, new IntPtr(2737323025756L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㸀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775412, new IntPtr(2737323015356L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㼀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17114, 1790775413, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790775413, new IntPtr(2737323037196L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00䀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775410, new IntPtr(2737323012236L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed object _FF00_FF00_FF00_FF00_FF00_FF00_FF00䄀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_0021: Expected Obj, but got I4
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		_003CModule_003E.CheckAccessibleAttribute();
		return IEnumerator_object.Initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed object _FF00_FF00_FF00_FF00_FF00_FF00_FF00䈀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775411, new IntPtr(2737323018476L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00䌀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775408, new IntPtr(2737323013276L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00䐀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0053: Expected I4, but got Obj
		//IL_0102: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I
		//IL_00d9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0116->IL0026: Incompatible stack heights: 2 vs 1
		//IL_007b->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00f3->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0094->IL0026: Incompatible stack heights: 2 vs 1
		//IL_006c->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0130->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00ae->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00be->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00e4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0121->IL0026: Incompatible stack heights: 2 vs 1
		//IL_009f->IL0026: Incompatible stack heights: 2 vs 1
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
			case 5:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)/*Error near IL_0062: Stack underflow*/, ref *(object[]*)ExceptionHelpers.GetHRForException((Exception)/*Error near IL_005d: Stack underflow*/));
				_ = 4;
				break;
			case 2:
				IEnumerator_object.Init();
				_ = 7;
				break;
			case 4:
				IEnumerator_object.Do_Abi_MoveNext_2((nint)/*Error near IL_0080: Stack underflow*/, (byte*)/*Error near IL_0080: Stack underflow*/);
				_ = 0;
				if (IList_object.PatchAttribute != null)
				{
					_ = 0;
				}
				break;
			case 7:
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)/*Error near IL_00a4: Stack underflow*/);
				_ = 3;
				break;
			case 8:
				IEnumerator_object._002Ecctor();
				_ = 9;
				break;
			case 9:
				return;
			default:
				IEnumerator_object.DecorateAutomatableAttribute();
				obj2 = 0;
				if (IReadOnlyList_object._initialized == 0)
				{
					obj2 = 1;
				}
				break;
			case 3:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init();
				_ = 8;
				break;
			case 1:
				MarshalInterface<INotifyPropertyChanged>.FromAbiArray((object)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_IndexOf_2((nint)/*Error near IL_00fd: Stack underflow*/, (nint)/*Error near IL_00fd: Stack underflow*/, (uint*)/*Error near IL_00fd: Stack underflow*/, (byte*)(int)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_00f8: Stack underflow*/, (uint)/*Error near IL_00f8: Stack underflow*/, (nint*)/*Error near IL_00f8: Stack underflow*/)));
				_ = 4;
				if (IEnumerable_object._initialized != 0)
				{
					_ = 6;
				}
				break;
			case 6:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_get_Size_1((IntPtr)/*Error near IL_0126: Stack underflow*/);
				_ = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00䔀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00c4: Expected Obj, but got Ref
		//IL_00cb: Expected Obj, but got Ref
		//IL_00cb: Expected Obj, but got Ref
		//IL_00da: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I4
		//IL_009e: Expected Obj, but got Ref
		//IL_00ad: Expected Obj, but got I
		//IL_0077: Expected I, but got Obj
		//IL_0077: Expected Obj, but got Ref
		//IL_004b: Expected Obj, but got Ref
		//IL_0050: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I
		//IL_00df->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00b2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ea->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00bd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0096->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
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
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = ExceptionHelpers.GetHRForException((Exception)(&obj));
				obj2 = 3;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					obj2 = 0;
				}
				break;
			case 3:
				IList_object._initialized = (nint)this;
				obj2 = 1;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 1;
				}
				break;
			case 1:
				IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute = -1;
				obj2 = 0;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute != null)
				{
					obj2 = 0;
				}
				break;
			default:
				((XamlUserType)Unsafe.AsPointer(ref IReadOnlyList_object._initialized)).BoxType<SortDirection>((object)(&obj));
				_ = 0;
				if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
				{
					_ = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00䘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775409, new IntPtr(2737323015356L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00䠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775422, new IntPtr(2737323035116L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00䤀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_009c: Expected Obj, but got I
		//IL_0056->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00be->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ac->IL0026: Incompatible stack types: I4 vs Obj
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
				ExceptionHelpers.GetHRForException((Exception)obj);
				_ = 4;
				break;
			case 3:
				_ = IEnumerator_object.Initialized;
				/*Error near IL_005b: Member reference must be method, but was: Field*/;
			case 4:
				return;
			case 2:
				if (IList_object.PatchAttribute != null)
				{
					obj2 = 1;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
					{
						obj2 = 0;
					}
				}
				else
				{
					IReadOnlyList_System_IDisposable._initialized = 1;
					obj2 = 3;
				}
				break;
			case 1:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00䨀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775423, new IntPtr(2737323035116L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00䬀(ElementTheme P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0053: Expected I4, but got Obj
		//IL_00d8: Expected Obj, but got I
		//IL_012c: Expected I, but got Obj
		//IL_012c: Expected I, but got Obj
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_0113: Expected Obj, but got I
		//IL_00c1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00fb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00dd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0136->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0118->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0151->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0123->IL0026: Incompatible stack heights: 3 vs 1
		//IL_015c->IL0026: Incompatible stack types: I4 vs Obj
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
			case 9:
				return;
			case 7:
				return;
			case 5:
				if (obj == null)
				{
					obj2 = 9;
					break;
				}
				goto case 1;
			case 6:
				/*Error near IL_008e: Member reference must be method, but was: Field*/;
			case 1:
			{
				object[] array = MarshalInspectable<object>.FromAbiArray(obj);
				obj = ((array is ObservableObject) ? array : null);
				obj2 = 2;
				break;
			}
			case 4:
				IEnumerator_object._002Ecctor();
				obj = this;
				obj2 = 3;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
				{
					obj2 = 3;
				}
				break;
			case 3:
				obj = obj as Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails;
				obj2 = 5;
				break;
			case 0:
				return;
			case 8:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3((nint)/*Error near IL_012c: Stack underflow*/, (uint)/*Error near IL_012c: Stack underflow*/, (uint)/*Error near IL_012c: Stack underflow*/, (nint)obj, (uint*)(nint)obj);
				_ = 6;
				break;
			case 2:
				if (obj != null)
				{
					MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)P_0);
					_ = 8;
					if (IEnumerator_System_IDisposable.ReflectTransferableAttribute != null)
					{
						_ = 7;
					}
				}
				else
				{
					obj2 = 0;
					if (IEnumerable_object._initialized == 0)
					{
						obj2 = 0;
					}
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00䰀(ElementTheme P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775420, new IntPtr(2737323013276L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
