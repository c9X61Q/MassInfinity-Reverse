using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.WinUI.Localization;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Markup;
using WinRT;
using WinRT.Mass_WinUIVtableClasses;

namespace Mass.WinUI.Controls;

[WinRTExposedType(typeof(Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class DragDropOverlay : UserControl, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private interface IDragDropOverlay_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IDragDropOverlay_BindingsScopeConnector
	{
		WeakReference Parent { get; set; }

		bool ContainsElement(int connectionId);

		void RegisterForElementConnection(int connectionId, IComponentConnector connector);
	}

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	private static class XamlBindingSetters
	{
		private static object DecorateIdentifiableEvent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe static void Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(object obj, object value, object targetNullValue)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784075, new IntPtr(2737336584476L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static bool ReflectInterruptibleWrapper()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784072, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static XamlBindingSetters ReflectCustomizableProcessor()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784073, new IntPtr(2737336587596L), 15))(null, 0, new IntPtr(0L));
			return (XamlBindingSetters)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00刀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784086, new IntPtr(2737336595916L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00匀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784087, new IntPtr(2737336592796L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00吀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784084, new IntPtr(2737336600076L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00唀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784085, new IntPtr(2737336600076L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00嘀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784082, new IntPtr(2737336576156L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static void _FF00圀(object P_0, object P_1, object P_2)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784083, new IntPtr(2737336595916L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static void _FF00堀(object P_0, object P_1, object P_2)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784080, new IntPtr(2737336597996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[DebuggerNonUserCode]
	[WinRTExposedType(typeof(Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails))]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.Markup.IComponentConnector")]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private class DragDropOverlay_obj1_Bindings : IComponentConnector, IDragDropOverlay_Bindings
	{
		[DebuggerNonUserCode]
		[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
		private class DragDropOverlay_obj1_BindingsTracking
		{
			private WeakReference<DragDropOverlay_obj1_Bindings> weakRefToBindingObj;

			private long tokenDPC_Title;

			private long tokenDPC_Subtitle;

			internal static object ReflectOrderedProfile;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public unsafe DragDropOverlay_obj1_BindingsTracking(DragDropOverlay_obj1_Bindings obj)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784407, new IntPtr(2737336594876L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public unsafe DragDropOverlay_obj1_Bindings TryGetBindingObject()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784443, new IntPtr(2737336582396L), 15))(null, 0, new IntPtr(0L));
				return (DragDropOverlay_obj1_Bindings)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public unsafe void ReleaseAllListeners()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784440, new IntPtr(2737336588636L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public unsafe void DependencyPropertyChanged_Title(DependencyObject sender, DependencyProperty prop)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784441, new IntPtr(2737336575116L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public unsafe void DependencyPropertyChanged_Subtitle(DependencyObject sender, DependencyProperty prop)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784390, new IntPtr(2737336577196L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public unsafe void UpdateChildListeners_(DragDropOverlay obj)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784391, new IntPtr(2737336595916L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static bool DecorateVisualChooser()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784388, new IntPtr(2737336599036L), 15))(null, 0, new IntPtr(0L));
				return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static DragDropOverlay_obj1_BindingsTracking ReflectScopeSolver()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784389, new IntPtr(2737336597996L), 15))(null, 0, new IntPtr(0L));
				return (DragDropOverlay_obj1_BindingsTracking)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00ⴀ(object P_0, object P_1)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784386, new IntPtr(2737336600076L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00_2E00(object P_0, object P_1)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784387, new IntPtr(2737336588636L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00_2F00(object P_0, object P_1)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784384, new IntPtr(2737336583436L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00_3000(object P_0, object P_1)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784385, new IntPtr(2737336606316L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00_3100(object P_0, object P_1)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784398, new IntPtr(2737336583436L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static byte _FF00_3200()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784399, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
				return (byte)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static byte _FF00_3300()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784396, new IntPtr(2737336602156L), 15))(null, 0, new IntPtr(0L));
				return (byte)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static object _FF00㐀()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784397, new IntPtr(2737336587596L), 15))(null, 0, new IntPtr(0L));
				return (object)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00㔀(object P_0)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784394, new IntPtr(2737336576156L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00㘀(object P_0)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784395, new IntPtr(2737336602156L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe object _FF00㜀()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784392, new IntPtr(2737336599036L), 15))(null, 0, new IntPtr(0L));
				return (object)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe object _FF00㠀()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784393, new IntPtr(2737336582396L), 15))(null, 0, new IntPtr(0L));
				return (object)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00㤀()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784406, new IntPtr(2737336602156L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}
		}

		private object dataRoot;

		private nint initialized;

		private object obj5;

		private object obj6;

		private object bindingsTracking;

		private static object CheckInternalContainer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe DragDropOverlay_obj1_Bindings()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784442, new IntPtr(2737336580316L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe void Connect(int connectionId, object target)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784081, new IntPtr(2737336580316L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
		public IComponentConnector GetBindingConnector(int connectionId, object target)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe void Initialize()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784094, new IntPtr(2737336596956L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe void Update()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784095, new IntPtr(2737336599036L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe void StopTracking()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784092, new IntPtr(2737336581356L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe void DisconnectUnloadedObject(int connectionId)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784093, new IntPtr(2737336581356L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe bool SetDataRoot(object newDataRoot)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784090, new IntPtr(2737336588636L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe void Activated(object obj, WindowActivatedEventArgs data)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784091, new IntPtr(2737336576156L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe void Loading(FrameworkElement src, object data)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784088, new IntPtr(2737336602156L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void Update_(object obj, uint phase)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784089, new IntPtr(2737336599036L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void Update_Title(object obj, uint phase)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784422, new IntPtr(2737336582396L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void Update_Subtitle(object obj, uint phase)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784423, new IntPtr(2737336602156L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static bool ParseRole()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784420, new IntPtr(2737336574076L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static DragDropOverlay_obj1_Bindings DecorateHiddenVerifier()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784421, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
			return (DragDropOverlay_obj1_Bindings)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00㨀(object P_0, uint P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784418, new IntPtr(2737336604236L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00㬀(object P_0, uint P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784419, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00㰀(object P_0, uint P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784416, new IntPtr(2737336588636L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00㴀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784417, new IntPtr(2737336596956L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00㸀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784430, new IntPtr(2737336599036L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00㼀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784431, new IntPtr(2737336581356L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00䀀(object P_0, uint P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784428, new IntPtr(2737336581356L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00䄀(object P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784429, new IntPtr(2737336588636L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00䈀(object P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784426, new IntPtr(2737336606316L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00䌀(object P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784427, new IntPtr(2737336583436L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00䐀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784424, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00䔀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784425, new IntPtr(2737336602156L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00䘀(uint P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784438, new IntPtr(2737336587596L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00䜀(object P_0, uint P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784439, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00䠀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784436, new IntPtr(2737336597996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe byte _FF00䤀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784437, new IntPtr(2737336605276L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe byte _FF00䨀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784434, new IntPtr(2737336580316L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00䬀(object P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784435, new IntPtr(2737336602156L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00䰀(object P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784432, new IntPtr(2737336583436L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00䴀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784433, new IntPtr(2737336592796L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00一()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784446, new IntPtr(2737336606316L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00伀(uint P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784447, new IntPtr(2737336590716L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00倀(uint P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784444, new IntPtr(2737336606316L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00儀(uint P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784445, new IntPtr(2737336590716L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	public static readonly DependencyProperty TitleProperty;

	public static readonly DependencyProperty SubtitleProperty;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object FadeInStoryboard;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object FadeOutStoryboard;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object Root;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private nint _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object Bindings;

	internal static DragDropOverlay CheckDetailedMap;

	public unsafe string Title
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784106, new IntPtr(2737336594876L), 15))(null, 0, new IntPtr(0L));
			return (string)/*Error near IL_0033: Stack underflow*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784107, new IntPtr(2737336602156L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	public unsafe string Subtitle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784104, new IntPtr(2737336577196L), 15))(null, 0, new IntPtr(0L));
			return (string)/*Error near IL_0033: Stack underflow*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784105, new IntPtr(2737336596956L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe DragDropOverlay()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784074, new IntPtr(2737336605276L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe void Show()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784118, new IntPtr(2737336591756L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe void Hide(Action? onCompleted = null)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784119, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	public unsafe void InitializeComponent()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784116, new IntPtr(2737336585516L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	public unsafe void Connect(int connectionId, object target)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784117, new IntPtr(2737336597996L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	public unsafe IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784114, new IntPtr(2737336604236L), 15))(null, 0, new IntPtr(0L));
		return (IComponentConnector)/*Error near IL_0033: Stack underflow*/;
	}

	static DragDropOverlay()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0023: Expected I4, but got Obj
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_00bf->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0073->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00ca->IL0012: Incompatible stack types: I4 vs Obj
		//IL_007e->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 2:
				TitleProperty = DependencyProperty.Register((string)ZYXDNGuarder._FF00_FF00_0C00(), typeof(string), typeof(DragDropOverlay), new PropertyMetadata((object)LocalizationSource.Instance[(string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_FF00䰀()]));
				obj2 = 0;
				if (_003CModule_003E_007Bcdc0cbc7_002D464a_002D4cb5_002D949f_002Deb12b1e2047b_007D.m_1f9c47eae2c64b22a37472c24214705c.m_5cb36ac04afd46faa722ed922546add2 == 0)
				{
					obj2 = 1;
				}
				break;
			case 1:
				SubtitleProperty = DependencyProperty.Register((string)ZYXDNGuarder._FF00_FF00_2600(), typeof(string), typeof(DragDropOverlay), new PropertyMetadata((object)string.Empty));
				obj2 = 0;
				if (_003CModule_003E_007Bcdc0cbc7_002D464a_002D4cb5_002D949f_002Deb12b1e2047b_007D.m_1f9c47eae2c64b22a37472c24214705c.m_c7ec143f63a94e57926f097c297e5ebf == 0)
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
	internal unsafe static bool MonitorEmitter()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784115, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static DragDropOverlay ReflectGeneralWatcher()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784112, new IntPtr(2737336588636L), 15))(null, 0, new IntPtr(0L));
		return (DragDropOverlay)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_EA00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784113, new IntPtr(2737336584476L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_EB00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784126, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_EC00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784127, new IntPtr(2737336587596L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_ED00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784124, new IntPtr(2737336583436L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_EE00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784125, new IntPtr(2737336604236L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_EF00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784122, new IntPtr(2737336583436L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F000(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784123, new IntPtr(2737336591756L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F200()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784120, new IntPtr(2737336594876L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784121, new IntPtr(2737336599036L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784070, new IntPtr(2737336580316L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784071, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F600()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784068, new IntPtr(2737336604236L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784069, new IntPtr(2737336582396L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F800(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784066, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed object _FF00_FF00_FF00_FF00_FF00_FF00_FF00豈(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784067, new IntPtr(2737336591756L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed object _FF00_FF00_FF00_FF00_FF00_FF00_FF00切(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784064, new IntPtr(2737336584476L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ﬀ(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784065, new IntPtr(2737336604236L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ﰀ(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784078, new IntPtr(2737336585516L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ﴀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784079, new IntPtr(2737336596956L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FE00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784076, new IntPtr(2737336584476L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_FF00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790784077, new IntPtr(2737336590716L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
