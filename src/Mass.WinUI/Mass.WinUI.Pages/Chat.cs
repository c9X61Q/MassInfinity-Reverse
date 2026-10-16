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
		internal static object _FF00_FF00_FF00_FF00笀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
		internal static byte _FF00_FF00_FF00_FF00縀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void _FF00_FF00_FF00_FF00缀(object P_0, object P_1, object P_2)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0065->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0077->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0082->IL0019: Incompatible stack types: I4 vs Obj
			//IL_004d->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0094->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0058->IL0019: Incompatible stack types: I4 vs Obj
			//IL_009f->IL0019: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
						if (false)
						{
							obj2 = 1;
						}
						break;
					}
					goto default;
				default:
					_ = 2;
					break;
				case 1:
					P_1 = P_2;
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				case 5:
					if (P_1 != null)
					{
						if (4 == 0)
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
		public Chat_obj1_Bindings()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
			{
			}
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
		internal sealed void _FF00_FF00_FF00_FF00昀(uint P_0, object P_1)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002a: Expected I4, but got Obj
			//IL_0040->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_005f->IL0019: Incompatible stack heights: 0 vs 1
			//IL_006a->IL0019: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (2 == 0)
					{
						_ = 1;
					}
					break;
				case 1:
					if (P_0 != 9)
					{
						return;
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
		internal unsafe sealed void _FF00_FF00_FF00_FF00最(uint P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778870, new IntPtr(2737336193852L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _FF00_FF00_FF00_FF00栀(object P_0, object P_1)
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00椀(object P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778871, new IntPtr(2737336163692L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal sealed void _FF00_FF00_FF00_FF00樀()
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
			object obj = 2;
			while (true)
			{
				switch ((int)obj)
				{
				default:
					return;
				case 0:
					return;
				case 2:
					_ = int.MinValue;
					if (true)
					{
						_ = 0;
					}
					break;
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
		internal unsafe sealed void _FF00_FF00_FF00_FF00欀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778868, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00氀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00_FF00_FF00_FF00洀(object P_0, uint P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778869, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _FF00_FF00_FF00_FF00渀(object P_0, uint P_1)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0032: Expected I4, but got Obj
			//IL_006a->IL0097: Incompatible stack heights: 1 vs 0
			//IL_0057->IL0019: Incompatible stack heights: 3 vs 1
			//IL_008c->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0074->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0062->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0097->IL0019: Incompatible stack types: I4 vs Obj
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
					return;
				case 1:
					return;
				case 4:
					if (false)
					{
						_ = 0;
					}
					break;
				case 3:
					if (null != null)
					{
						_ = 2;
						break;
					}
					return;
				case 2:
					if ((P_1 & 0x80000001u) == 0)
					{
						if (true)
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
		internal void _FF00_FF00_FF00_FF00瀀(object P_0, object P_1)
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal byte _FF00_FF00_FF00_FF00焀(object P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002e: Expected I4, but got Obj
			//IL_006f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0054->IL0019: Incompatible stack heights: 0 vs 1
			//IL_007a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_005f->IL0019: Incompatible stack types: I4 vs Obj
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
					if (P_0 == null)
					{
						if (1 == 0)
						{
							obj2 = 1;
						}
						break;
					}
					goto case 3;
				case 3:
					if (false)
					{
						_ = 0;
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
		internal static byte _FF00_FF00_FF00_FF00猀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00琀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778864, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal sealed void _FF00_FF00_FF00_FF00甀(uint P_0)
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			throw /*Error near IL_000a: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00_FF00_FF00_FF00瘀(uint P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778865, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _FF00_FF00_FF00_FF00眀(object P_0, uint P_1)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002a: Expected I4, but got Obj
			//IL_0064->IL0019: Incompatible stack heights: 3 vs 1
			//IL_006f->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0047->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0052->IL0019: Incompatible stack types: I4 vs Obj
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
					if ((P_1 & 0x80000001u) != 0)
					{
						if (true)
						{
							obj2 = 1;
						}
						break;
					}
					return;
				case 0:
					return;
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
		private unsafe void _FF00_FF00_FF00_FF00砀(object P_0, uint P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778878, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal sealed void _FF00_FF00_FF00_FF00礀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002e: Expected I4, but got Obj
			//IL_007a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0046->IL0019: Incompatible stack heights: 0 vs 1
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
				case 2:
					if (this != null)
					{
						if (false)
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
	public Chat()
	{
		//IL_002d: Expected I4, but got Obj
		//IL_0013->IL001c: Incompatible stack types: I4 vs Obj
		//IL_005a->IL001c: Incompatible stack heights: 3 vs 2
		//IL_0065->IL001c: Incompatible stack heights: 3 vs 2
		//IL_004b->IL001c: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		Chat chat = (Chat)2;
		while (true)
		{
			switch ((int)chat)
			{
			default:
				return;
			case 2:
				chat = this;
				if (1 == 0)
				{
					chat = (Chat)1;
				}
				break;
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
	private void _FF00_FF00_FF00ꔀ(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0042: Expected I4, but got Obj
		//IL_00d5: Expected Obj, but got I4
		//IL_00eb->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0088->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00b9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00da->IL0015: Incompatible stack heights: 2 vs 0
		//IL_009d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00f6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006f->IL0079: Incompatible stack heights: 1 vs 0
		//IL_00a8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0079->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (null == null)
					{
						_ = 4;
						continue;
					}
					goto case 8;
				case 8:
					_ = null;
					_ = 6;
					continue;
				case 2:
					break;
				default:
					if (obj == null)
					{
						return;
					}
					obj2 = 7;
					continue;
				case 1:
					return;
				case 5:
					obj = this;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				}
				if ((nint)P_1 == 13)
				{
					break;
				}
				if (false)
				{
					obj2 = 1;
				}
			}
			_ = 1;
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
	internal static byte _FF00_FF00_FF00_A700()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
	internal static object _FF00_FF00_FF00ꨀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_AB00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778862, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00관()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0063->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0090->IL0019: Incompatible stack heights: 3 vs 1
		//IL_009b->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0073->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_007e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0055->IL0019: Incompatible stack types: I4 vs Obj
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
				if (this != null)
				{
					if (2 != 0)
					{
						obj2 = 3;
					}
					break;
				}
				_ = 1;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			default:
				obj = (object)/*Error near IL_0059: Stack underflow*/;
				obj2 = 2;
				break;
			case 3:
				return;
			case 1:
				return;
			case 2:
				_ = 0;
				if (1 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed object _FF00_FF00_FF00글(uint P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0070: Expected Obj, but got I4
		//IL_0075->IL0015: Incompatible stack heights: 4 vs 0
		//IL_0045->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0088->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0050->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0093->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (false)
					{
						obj2 = 1;
					}
					continue;
				case 1:
					if (P_0 == 1)
					{
						if (0 == 0)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 3;
				}
				break;
			}
			obj = P_1;
			obj = obj;
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
	internal sealed void _FF00_FF00_FF00넀(uint P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_004a: Expected I4, but got Obj
		//IL_007a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00c2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00cd->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0062->IL0019: Incompatible stack heights: 0 vs 1
		//IL_010c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0095->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0137->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0117->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (true)
					{
						obj2 = 10;
					}
					break;
				}
				goto case 7;
			default:
				_ = 1;
				_ = 3;
				break;
			case 7:
				if (0 == 0)
				{
					_ = 4;
				}
				break;
			case 9:
				if (1 == 0)
				{
					_ = 0;
				}
				break;
			case 2:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 3:
				return;
			case 6:
				if (P_0 != 2)
				{
					if (5 != 0)
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
