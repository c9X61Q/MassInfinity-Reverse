using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Markup;
using WinRT;
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
		internal static object _FF00_FF00_FF00_FF00_FF00笀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
		internal static byte _FF00_FF00_FF00_FF00_FF00縀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00缀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775371, new IntPtr(2737323016396L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void _FF00_FF00_FF00_FF00_FF00耀(object P_0, object P_1, object P_2)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0032: Expected I4, but got Obj
			//IL_0080->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
			//IL_009e->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0063->IL0019: Incompatible stack heights: 0 vs 1
			//IL_008b->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0051->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00a9->IL0019: Incompatible stack types: I4 vs Obj
			//IL_006e->IL0019: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 3:
					if (3 == 0)
					{
						_ = 4;
					}
					break;
				case 1:
					if (P_1 == null)
					{
						if (0 == 0)
						{
							obj2 = 0;
						}
						break;
					}
					goto case 3;
				case 2:
					P_1 = P_2;
					if (1 == 0)
					{
						obj2 = 3;
					}
					break;
				case 4:
					return;
				default:
					if (P_2 != null)
					{
						if (2 == 0)
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
		public MainContent_obj1_Bindings()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
			{
			}
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
		internal sealed void _FF00_FF00_FF00_FF00_FF00栀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002a: Expected I4, but got Obj
			//IL_005f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0045->IL0019: Incompatible stack heights: 3 vs 1
			//IL_006a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0050->IL0019: Incompatible stack heights: 3 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			while (true)
			{
				switch ((int)obj)
				{
				case 2:
					return;
				case 1:
					_ = int.MinValue;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
				default:
					_ = 1;
					if (2 == 0)
					{
						_ = 1;
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
		private void _FF00_FF00_FF00_FF00_FF00樀(object P_0, uint P_1)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002a: Expected I4, but got Obj
			//IL_0064->IL0019: Incompatible stack heights: 3 vs 1
			//IL_006f->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0048->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0053->IL0019: Incompatible stack types: I4 vs Obj
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
				case 0:
					return;
				case 2:
					if ((P_1 & 0x80000001u) == 0)
					{
						return;
					}
					if (1 == 0)
					{
						obj2 = 0;
					}
					break;
				case 1:
					_ = null;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal sealed void _FF00_FF00_FF00_FF00_FF00欀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002a: Expected I4, but got Obj
			//IL_0067->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0043->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004e->IL0019: Incompatible stack types: I4 vs Obj
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
				case 0:
					return;
				case 2:
					if (this != null)
					{
						return;
					}
					if (1 == 0)
					{
						obj2 = 1;
					}
					break;
				case 1:
					obj2 = this;
					if (0 == 0)
					{
						obj2 = 0;
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
		internal static object _FF00_FF00_FF00_FF00_FF00洀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00_FF00渀(object P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775380, new IntPtr(2737323035116L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _FF00_FF00_FF00_FF00_FF00漀(object P_0, object P_1)
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00_FF00瀀(object P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775381, new IntPtr(2737323039276L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _FF00_FF00_FF00_FF00_FF00焀(object P_0, object P_1)
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
			{
			}
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
		internal sealed void _FF00_FF00_FF00_FF00_FF00琀(uint P_0, object P_1)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002a: Expected I4, but got Obj
			//IL_005d->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0068->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0042->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004d->IL0019: Incompatible stack types: I4 vs Obj
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
					if (P_0 == 3)
					{
						if (false)
						{
							obj2 = 1;
						}
						break;
					}
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
		private void _FF00_FF00_FF00_FF00_FF00甀(object P_0, uint P_1)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_009b->IL0019: Incompatible stack heights: 4 vs 1
			//IL_0075->IL003b: Incompatible stack heights: 1 vs 0
			//IL_0051->IL0019: Incompatible stack types: I4 vs Obj
			//IL_008c->IL0019: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					obj2 = P_0;
					if (null == null)
					{
						if (2 == 0)
						{
							obj2 = 2;
						}
						continue;
					}
					goto default;
				case 1:
					break;
				case 2:
					return;
				case 5:
					return;
				}
				_ = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00瘀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe byte _FF00_FF00_FF00_FF00_FF00眀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775376, new IntPtr(2737323039276L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal byte _FF00_FF00_FF00_FF00_FF00砀(object P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002a: Expected I4, but got Obj
			//IL_003f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0060->IL0019: Incompatible stack heights: 0 vs 1
			//IL_006b->IL0019: Incompatible stack types: I4 vs Obj
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
					if (1 == 0)
					{
						_ = 2;
					}
					break;
				case 2:
					return 1;
				case 1:
					if (P_0 == null)
					{
						return 0;
					}
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal sealed void _FF00_FF00_FF00_FF00_FF00礀(uint P_0)
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			throw /*Error near IL_000a: Stack underflow*/;
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
	public MainContent()
	{
		//IL_0036: Expected I4, but got Obj
		//IL_0020->IL0029: Incompatible stack types: I4 vs Obj
		//IL_0054->IL0029: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		MainContent mainContent = this;
		if (0 == 0)
		{
			mainContent = (MainContent)0;
		}
		while (true)
		{
			switch ((int)mainContent)
			{
			case 1:
				return;
			}
			mainContent = this;
			if (true)
			{
				mainContent = (MainContent)1;
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00伀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0068->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0079->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00b0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0084->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00bb->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0059->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				if (this == null)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				return;
			case 2:
				_ = 0;
				_ = 3;
				break;
			case 3:
				return;
			case 4:
				obj = (object)/*Error near IL_006d: Stack underflow*/;
				if (true)
				{
					obj2 = 2;
				}
				break;
			case 5:
				return;
			default:
				_ = 1;
				if (4 == 0)
				{
					_ = 2;
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
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00刀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
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
	internal sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00唀(uint P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0072: Expected I4, but got Obj
		//IL_0147->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01c2->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01eb->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00cf->IL0019: Incompatible stack heights: 3 vs 1
		//IL_018c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00f0->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0171->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01b4->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01d2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0085->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0152->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0197->IL0019: Incompatible stack heights: 2 vs 1
		//IL_012c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_017c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01dd->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0137->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 15;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 20:
				_ = 17;
				continue;
			case 10:
				goto IL_00c1;
			case 13:
				goto IL_00e2;
			case 15:
				switch (P_0)
				{
				case 11u:
					break;
				case 7u:
					goto IL_00c1;
				case 4u:
					goto IL_00e2;
				default:
					goto IL_0120;
				case 8u:
					goto IL_0137;
				case 9u:
					goto IL_0161;
				case 5u:
					goto IL_017c;
				case 3u:
					goto IL_01a7;
				case 2u:
					goto IL_01b4;
				case 10u:
					goto IL_01c2;
				case 6u:
					goto end_IL_0019;
				}
				goto case 20;
			case 3:
				goto IL_0137;
			case 16:
				goto IL_0161;
			case 12:
				goto IL_017c;
			case 5:
				return;
			default:
				goto IL_01a7;
			case 4:
				goto IL_01b4;
			case 18:
				goto IL_01c2;
			case 7:
				break;
				IL_01c2:
				if (8 == 0)
				{
					_ = 2;
				}
				continue;
				IL_0120:
				if (4 == 0)
				{
					obj2 = 14;
				}
				continue;
				IL_01b4:
				_ = 2;
				continue;
				IL_01a7:
				_ = 1;
				_ = 5;
				continue;
				IL_017c:
				if (0 == 0)
				{
					_ = 0;
				}
				continue;
				IL_00e2:
				_ = 9;
				continue;
				IL_0161:
				if (true)
				{
					_ = 0;
				}
				continue;
				IL_00c1:
				_ = 11;
				continue;
				IL_0137:
				if (2 == 0)
				{
					_ = 6;
				}
				continue;
				end_IL_0019:
				break;
			}
			_ = 19;
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
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00圀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed object _FF00_FF00_FF00_FF00_FF00_FF00_FF00堀(uint P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0042->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0070->IL0019: Incompatible stack heights: 4 vs 1
		//IL_008f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007b->IL0019: Incompatible stack heights: 4 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 3:
				obj = P_1;
				obj = obj;
				if (2 == 0)
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
