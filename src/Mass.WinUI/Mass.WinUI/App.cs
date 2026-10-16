using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mass.Common.Extensions;
using Mass.WinUI.Enums;
using Mass.WinUI.Mass_WinUI_XamlTypeInfo;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Markup;
using Serilog;
using WinRT;
using WinRT.Mass_WinUIVtableClasses;

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
		internal static object _FF00_FF00_FF00_FF00_FF00茀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00蘀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00蜀(object P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00褀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_02dd: Expected Obj, but got Ref
			//IL_005a: Expected Obj, but got Ref
			//IL_01e2: Expected Obj, but got Ref
			//IL_0114: Expected Obj, but got I4
			//IL_015b: Expected Obj, but got I4
			//IL_0194: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_02e9->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0066->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0056->IL0019: Incompatible stack heights: 2 vs 1
			//IL_008b->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0221->IL00ae: Incompatible stack types: I4 vs Ref
			//IL_009f->IL00ae: Incompatible stack heights: 0 vs 1
			//IL_02f4->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0071->IL0019: Incompatible stack types: I4 vs Ref
			//IL_00aa->IL00ae: Incompatible stack types: I4 vs Ref
			//IL_0178->IL00ae: Incompatible stack heights: 3 vs 1
			//IL_0215->IL00ae: Incompatible stack types: I4 vs Ref
			//IL_010f->IL00ae: Incompatible stack heights: 2 vs 1
			//IL_01ec->IL00ae: Incompatible stack types: I4 vs Ref
			//IL_011f->IL00ae: Incompatible stack heights: 3 vs 1
			//IL_01fb->IL00ae: Incompatible stack heights: 0 vs 1
			//IL_013b->IL00ae: Incompatible stack heights: 2 vs 1
			//IL_014b->IL00ae: Incompatible stack heights: 2 vs 1
			//IL_0166->IL00ae: Incompatible stack heights: 3 vs 1
			//IL_024d->IL00ae: Incompatible stack heights: 2 vs 1
			//IL_0183->IL00ae: Incompatible stack heights: 3 vs 1
			//IL_01c2->IL00ae: Incompatible stack types: I4 vs Ref
			//IL_0206->IL00ae: Incompatible stack types: I4 vs Ref
			//IL_0156->IL00ae: Incompatible stack heights: 2 vs 1
			//IL_0235->IL00ae: Incompatible stack heights: 0 vs 1
			//IL_00ae->IL00ae: Incompatible stack types: Obj vs Ref
			//IL_0240->IL00ae: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			ref _003CLogout_003Ed__15 reference = ref *(_003CLogout_003Ed__15*)obj;
			while (true)
			{
				ref object reference2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					_ = -2;
					if (2 == 0)
					{
						_ = 2;
					}
					break;
				case 5u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						reference = ref *(_003CLogout_003Ed__15*)4;
					}
					break;
				case 2u:
					reference = ref this;
					if (true)
					{
						reference = ref *(_003CLogout_003Ed__15*)1;
					}
					break;
				case 3u:
					if (obj == null)
					{
						if (0 == 0)
						{
							reference2 = ref *(object*)null;
						}
						goto IL_00ae;
					}
					goto IL_0215;
				case 1u:
					return;
				case 4u:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (3 != 0)
						{
							reference = ref *(_003CLogout_003Ed__15*)3;
						}
						break;
					}
					IL_0215:
					reference2 = ref *(object*)4;
					goto IL_00ae;
					IL_00ae:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference2))
						{
						case 1u:
							break;
						case 6u:
							_ = 17;
							continue;
						case 8u:
							obj = -1;
							_ = 5;
							continue;
						case 10u:
							_ = 8;
							continue;
						case 14u:
							if (1 == 0)
							{
								_ = 3;
							}
							continue;
						case 15u:
							obj = 0;
							_ = 14;
							continue;
						case 3u:
							_ = ref obj;
							if (5 == 0)
							{
								_ = 11;
							}
							continue;
						case 13u:
							if (obj != null)
							{
								obj = 6;
								reference2 = ref *(object*)obj;
								continue;
							}
							goto case 17u;
						case 2u:
						case 5u:
							reference2 = ref obj;
							if (4 == 0)
							{
								reference2 = ref *(object*)13;
							}
							continue;
						case 11u:
							return;
						default:
							obj = (object)Unsafe.AsPointer(ref this);
							reference2 = ref *(object*)10;
							continue;
						case 9u:
							if (1 == 0)
							{
								reference2 = ref *(object*)1;
							}
							continue;
						case 4u:
							obj = (object)/*Error near IL_020b: Stack underflow*/;
							reference2 = ref *(object*)16;
							continue;
						case 12u:
							goto IL_0215;
						case 16u:
							if (&obj != null)
							{
								if (true)
								{
									reference2 = ref *(object*)2;
								}
								continue;
							}
							goto case 15u;
						case 17u:
							_ = 9;
							continue;
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
	public App()
	{
		//IL_003a: Expected I4, but got Obj
		//IL_0020->IL0029: Incompatible stack types: I4 vs Obj
		//IL_004c->IL0029: Incompatible stack heights: 2 vs 1
		//IL_0065->IL0029: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		App app = this;
		if (true)
		{
			app = (App)1;
		}
		while (true)
		{
			switch ((int)app)
			{
			case 2:
				return;
			default:
				_ = 2;
				break;
			case 1:
				app = this;
				if (0 == 0)
				{
					app = (App)0;
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᰀ(byte P_0, object P_1, object P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0067->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0082->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00a6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0058->IL0019: Incompatible stack types: I4 vs Obj
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
				if (P_0 != 0)
				{
					if (3 == 0)
					{
						obj2 = 1;
					}
				}
				else if (false)
				{
					obj2 = 1;
				}
				break;
			default:
				_ = 1;
				if (5 != 0)
				{
					_ = 0;
				}
				break;
			case 3:
				return;
			case 5:
				obj2 = 0;
				if (2 != 0)
				{
					obj2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				obj2 = P_1;
				if (0 == 0)
				{
					obj2 = 0;
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
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ḁ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_000a: Stack underflow*/;
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
	private void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2200()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0079->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0093->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0051->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				obj2 = this;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 1:
				obj2 = this;
				if (4 == 0)
				{
					obj2 = 1;
				}
				break;
			case 3:
				return;
			default:
				obj2 = 3;
				break;
			case 2:
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
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2500()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2600(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775392, new IntPtr(2737323039276L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2700(object P_0)
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
	internal sealed object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2800()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2900(EnumBackdropType P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_004a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0055->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0065->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0070->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				if (this == null)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
				}
				else if (2 == 0)
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
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2E00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
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
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_3100()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㔀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
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
	internal sealed object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㠀(object P_0)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㤀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775414, new IntPtr(2737323012236L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00㰀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_004e: Expected I4, but got Obj
		//IL_00bc: Expected Obj, but got I4
		//IL_00e3->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00fb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c1->IL0015: Incompatible stack heights: 1 vs 0
		//IL_0060->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0087->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ee->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0116->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0121->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0132->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					_ = 6;
					continue;
				case 7:
					obj2 = this;
					if (2 == 0)
					{
						obj2 = 2;
					}
					continue;
				case 10:
					obj2 = 9;
					continue;
				case 3:
					return;
				case 11:
					obj2 = obj;
					if (9 == 0)
					{
						obj2 = 10;
					}
					continue;
				case 5:
					_ = 7;
					continue;
				case 6:
					break;
				default:
					if (obj != null)
					{
						obj2 = 11;
					}
					else if (this == null)
					{
						if (4 != 0)
						{
							obj2 = 3;
						}
					}
					else
					{
						_ = 8;
					}
					continue;
				case 1:
					obj = this;
					if (false)
					{
						obj2 = 0;
					}
					continue;
				case 2:
					obj2 = 3;
					continue;
				case 9:
					return;
				}
				break;
			}
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
	internal sealed object _FF00_FF00_FF00_FF00_FF00_FF00_FF00䄀(object P_0)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return P_0;
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
	protected void _FF00_FF00_FF00_FF00_FF00_FF00_FF00䐀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0046: Expected I4, but got Obj
		//IL_00a0->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00c5->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0062->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0057->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00db->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0085->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0091->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ab->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007a->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 5:
				obj2 = 4;
				break;
			case 2:
				obj2 = 7;
				break;
			case 4:
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 7:
				obj2 = 3;
				break;
			case 8:
				_ = 9;
				break;
			case 9:
				return;
			default:
				if (0 == 0)
				{
					obj2 = 1;
				}
				break;
			case 3:
				obj2 = 8;
				break;
			case 1:
				if (4 != 0)
				{
					obj2 = 6;
				}
				break;
			case 6:
				obj2 = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00䔀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_009a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0062->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0088->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0052->IL0019: Incompatible stack types: I4 vs Ref
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		ref object reference = ref *(object*)obj;
		while (true)
		{
			switch ((uint)Unsafe.AsPointer(ref reference))
			{
			case 4u:
				reference = ref obj;
				if (3 == 0)
				{
					reference = ref *(object*)null;
				}
				break;
			case 3u:
				_ = ref obj;
				if (1 == 0)
				{
					_ = 1;
				}
				break;
			case 1u:
				_ = ref obj;
				_ = -1;
				if (false)
				{
					_ = 0;
				}
				break;
			default:
				_ = ref obj;
				_ = ref obj;
				if (0 == 0)
				{
					_ = 2;
				}
				break;
			case 2u:
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00䤀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0045->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0055->IL0019: Incompatible stack heights: 0 vs 1
		//IL_008d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0074->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0060->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007f->IL0019: Incompatible stack types: I4 vs Obj
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
				_ = 4;
				break;
			case 3:
				obj = (object)/*Error near IL_0049: Stack underflow*/;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 4:
				return;
			case 2:
				if (this != null)
				{
					if (true)
					{
						obj2 = 0;
					}
				}
				else
				{
					_ = 1;
					_ = 3;
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00䬀(ElementTheme P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0046: Expected I4, but got Obj
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a8->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0088->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ed->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00d3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0100->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00b3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0079->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00de->IL0019: Incompatible stack heights: 2 vs 1
		//IL_010b->IL0019: Incompatible stack types: I4 vs Obj
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
				obj2 = 7;
				break;
			case 1:
				obj = obj;
				obj2 = 2;
				break;
			case 4:
				obj = this;
				if (3 == 0)
				{
					obj2 = 3;
				}
				break;
			case 3:
				obj = obj;
				obj2 = 5;
				break;
			case 0:
				return;
			case 8:
				_ = 6;
				break;
			case 2:
				if (obj != null)
				{
					if (8 != 0)
					{
						_ = 7;
					}
				}
				else if (0 == 0)
				{
					obj2 = 0;
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
