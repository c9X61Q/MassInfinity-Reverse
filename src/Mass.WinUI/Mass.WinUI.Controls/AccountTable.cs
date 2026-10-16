using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.WinUI.Models;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Markup;
using WinRT;
using WinRT.Mass_WinUIVtableClasses;

namespace Mass.WinUI.Controls;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails))]
public sealed class AccountTable : UserControl, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private interface IAccountTable_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IAccountTable_BindingsScopeConnector
	{
		WeakReference Parent { get; set; }

		bool ContainsElement(int connectionId);

		void RegisterForElementConnection(int connectionId, IComponentConnector connector);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private static class XamlBindingSetters
	{
		internal static object CheckSimpleCache;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe static void Set_WinUI_TableView_TableView_ItemsSource(object obj, object value, object targetNullValue)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783911, new IntPtr(2737336577196L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static bool ReflectControllableUser()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783908, new IntPtr(2737336596956L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static XamlBindingSetters ReflectTransferableInitializer()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783909, new IntPtr(2737336586556L), 15))(null, 0, new IntPtr(0L));
			return (XamlBindingSetters)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00대()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783906, new IntPtr(2737336591756L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00됀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783907, new IntPtr(2737336595916L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00딀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783904, new IntPtr(2737336585516L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static void _FF00똀(object P_0, object P_1, object P_2)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783905, new IntPtr(2737336585516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static void _FF00뜀(object P_0, object P_1, object P_2)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783918, new IntPtr(2737336590716L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static void _FF00렀(object P_0, object P_1, object P_2)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783919, new IntPtr(2737336590716L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[WinRTExposedType(typeof(Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails))]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.Markup.IComponentConnector")]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private class AccountTable_obj1_Bindings : IComponentConnector, IAccountTable_Bindings
	{
		[DebuggerNonUserCode]
		[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
		private class AccountTable_obj1_BindingsTracking
		{
			private WeakReference<AccountTable_obj1_Bindings> weakRefToBindingObj;

			private long tokenDPC_ItemsSource;

			private ObservableCollection<AccountModel> cache_ItemsSource;

			private static object JoinAdapter;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public unsafe AccountTable_obj1_BindingsTracking(AccountTable_obj1_Bindings obj)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783973, new IntPtr(2737336592796L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public unsafe AccountTable_obj1_Bindings TryGetBindingObject()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783885, new IntPtr(2737336605276L), 15))(null, 0, new IntPtr(0L));
				return (AccountTable_obj1_Bindings)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public unsafe void ReleaseAllListeners()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783882, new IntPtr(2737336599036L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public unsafe void DependencyPropertyChanged_ItemsSource(DependencyObject sender, DependencyProperty prop)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783883, new IntPtr(2737336601116L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public unsafe void UpdateChildListeners_(AccountTable obj)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783880, new IntPtr(2737336584476L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public unsafe void PropertyChanged_ItemsSource(object sender, PropertyChangedEventArgs e)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783881, new IntPtr(2737336582396L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public unsafe void CollectionChanged_ItemsSource(object sender, NotifyCollectionChangedEventArgs e)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783894, new IntPtr(2737336582396L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public unsafe void UpdateChildListeners_ItemsSource(ObservableCollection<AccountModel> obj)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783895, new IntPtr(2737336595916L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static bool DecorateLocalSynchronizer()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783892, new IntPtr(2737336575116L), 15))(null, 0, new IntPtr(0L));
				return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static AccountTable_obj1_BindingsTracking DecorateSymbolicEditor()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783893, new IntPtr(2737336594876L), 15))(null, 0, new IntPtr(0L));
				return (AccountTable_obj1_BindingsTracking)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00退(ObservableCollection<AccountModel> P_0)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783890, new IntPtr(2737336576156L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00鄀(ObservableCollection<AccountModel> P_0)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783891, new IntPtr(2737336595916L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static object _FF00鈀()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783888, new IntPtr(2737336592796L), 15))(null, 0, new IntPtr(0L));
				return (object)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00錀(object P_0, object P_1)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783889, new IntPtr(2737336594876L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00鐀(object P_0, object P_1)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783902, new IntPtr(2737336587596L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe object _FF00销()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783903, new IntPtr(2737336594876L), 15))(null, 0, new IntPtr(0L));
				return (object)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe object _FF00阀()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783900, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
				return (object)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00需(object P_0)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783901, new IntPtr(2737336585516L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00頀(object P_0, object P_1)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783898, new IntPtr(2737336597996L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00餀(object P_0, object P_1)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783899, new IntPtr(2737336604236L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00騀(object P_0, object P_1)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783896, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00鬀()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783897, new IntPtr(2737336588636L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00鰀(object P_0, object P_1)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783974, new IntPtr(2737336584476L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe void _FF00鴀(object P_0, object P_1)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783975, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static byte _FF00鸀()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783972, new IntPtr(2737336587596L), 15))(null, 0, new IntPtr(0L));
				return (byte)/*Error near IL_0033: Stack underflow*/;
			}
		}

		private object dataRoot;

		private nint initialized;

		private object obj5;

		private object bindingsTracking;

		internal static object FlushController;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe AccountTable_obj1_Bindings()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783884, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe void Connect(int connectionId, object target)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783916, new IntPtr(2737336577196L), 15))(null, 0, new IntPtr(0L));
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
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783917, new IntPtr(2737336584476L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe void Update()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783914, new IntPtr(2737336590716L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe void StopTracking()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783915, new IntPtr(2737336605276L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe void DisconnectUnloadedObject(int connectionId)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783912, new IntPtr(2737336605276L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe bool SetDataRoot(object newDataRoot)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783913, new IntPtr(2737336582396L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe void Activated(object obj, WindowActivatedEventArgs data)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783926, new IntPtr(2737336600076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe void Loading(FrameworkElement src, object data)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783927, new IntPtr(2737336604236L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void Update_(object obj, uint phase)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783924, new IntPtr(2737336580316L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void Update_ItemsSource(ObservableCollection<AccountModel> obj, uint phase)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783925, new IntPtr(2737336591756L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static bool DecorateSortedTransformer()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783922, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static AccountTable_obj1_Bindings DecorateCombinedMap()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783923, new IntPtr(2737336585516L), 15))(null, 0, new IntPtr(0L));
			return (AccountTable_obj1_Bindings)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00鼀(object P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783920, new IntPtr(2737336597996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00ꀀ(object P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783921, new IntPtr(2737336604236L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00ꄀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783934, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00ꈀ(uint P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783935, new IntPtr(2737336588636L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00ꌀ(uint P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783932, new IntPtr(2737336575116L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe byte _FF00ꐀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783933, new IntPtr(2737336578236L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe byte _FF00ꔀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783930, new IntPtr(2737336576156L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe byte _FF00ꘀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783931, new IntPtr(2737336582396L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_A700()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783928, new IntPtr(2737336582396L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00ꠀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783929, new IntPtr(2737336576156L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00꤀(uint P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783878, new IntPtr(2737336594876L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00ꨀ(uint P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783879, new IntPtr(2737336604236L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed void _FF00_AB00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783876, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00가()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783877, new IntPtr(2737336597996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00관()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783874, new IntPtr(2737336574076L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00글(object P_0, uint P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783875, new IntPtr(2737336575116L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00꼀(object P_0, uint P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783872, new IntPtr(2737336577196L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00뀀(ObservableCollection<AccountModel> P_0, uint P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783873, new IntPtr(2737336595916L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00넀(object P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783886, new IntPtr(2737336600076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00눀(object P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783887, new IntPtr(2737336574076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	public static readonly DependencyProperty ItemsSourceProperty;

	public static readonly DependencyProperty ParentDataContextProperty;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object Root;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object SelectionBarShow;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object SelectionBarHide;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object SelectionBar;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object TableViewControl;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object SelectionCountText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object ClearSelectionButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private nint _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object Bindings;

	internal static AccountTable CheckEditableRole;

	public unsafe ObservableCollection<AccountModel>? ItemsSource
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783615, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
			return (ObservableCollection<AccountModel>?)/*Error near IL_0033: Stack underflow*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783612, new IntPtr(2737336597996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	public unsafe object ParentDataContext
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783613, new IntPtr(2737336584476L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783610, new IntPtr(2737336575116L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe AccountTable()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783910, new IntPtr(2737336587596L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void OnSelectionChanged(object sender, object e)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783611, new IntPtr(2737336600076L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void OnLoaded(object sender, object e)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783608, new IntPtr(2737336586556L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void OnActionButtonTapped(object sender, object e)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783609, new IntPtr(2737336591756L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	public unsafe void InitializeComponent()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783558, new IntPtr(2737336600076L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	[DebuggerNonUserCode]
	public unsafe void Connect(int connectionId, object target)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783559, new IntPtr(2737336582396L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	public unsafe IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783556, new IntPtr(2737336591756L), 15))(null, 0, new IntPtr(0L));
		return (IComponentConnector)/*Error near IL_0033: Stack underflow*/;
	}

	static AccountTable()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0023: Expected I4, but got Obj
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_0065->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00ae->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0070->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00b9->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				ParentDataContextProperty = DependencyProperty.Register((string)ZYXDNGuarder._FF00_FF00_FF00글(), typeof(object), typeof(AccountTable), new PropertyMetadata((object)null));
				obj2 = 2;
				if (_003CModule_003E_007Bcdc0cbc7_002D464a_002D4cb5_002D949f_002Deb12b1e2047b_007D.m_1f9c47eae2c64b22a37472c24214705c.m_4346a9d2c8454e0ba1d11196b1426ac6 == 0)
				{
					obj2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				ItemsSourceProperty = DependencyProperty.Register((string)ZYXDNGuarder._FF00_AB00(), typeof(ObservableCollection<AccountModel>), typeof(AccountTable), new PropertyMetadata((object)null));
				obj2 = 0;
				if (_003CModule_003E_007Bcdc0cbc7_002D464a_002D4cb5_002D949f_002Deb12b1e2047b_007D.m_1f9c47eae2c64b22a37472c24214705c.m_2e840b5c744242128d9a82c4216f213d == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static bool ReflectLogicalCollection()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783555, new IntPtr(2737336587596L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static AccountTable DecodeEvent()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783552, new IntPtr(2737336595916L), 15))(null, 0, new IntPtr(0L));
		return (AccountTable)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00砀(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783553, new IntPtr(2737336592796L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00礀(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783566, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00稀(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783567, new IntPtr(2737336599036L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00笀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783564, new IntPtr(2737336577196L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00紀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783565, new IntPtr(2737336574076L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00縀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783562, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<AccountModel> _FF00_FF00_FF00_FF00_FF00_FF00_FF00缀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783563, new IntPtr(2737336604236L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<AccountModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<AccountModel> _FF00_FF00_FF00_FF00_FF00_FF00_FF00耀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783560, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<AccountModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00脀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783561, new IntPtr(2737336588636L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00舀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783574, new IntPtr(2737336596956L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00茀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783575, new IntPtr(2737336599036L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00萀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783572, new IntPtr(2737336581356L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00蔀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783573, new IntPtr(2737336585516L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00蘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783570, new IntPtr(2737336596956L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00蜀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783571, new IntPtr(2737336584476L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00蠀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783568, new IntPtr(2737336590716L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00褀(ObservableCollection<AccountModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783569, new IntPtr(2737336605276L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00言()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783582, new IntPtr(2737336605276L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00謀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783583, new IntPtr(2737336602156L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed object _FF00_FF00_FF00_FF00_FF00_FF00_FF00谀(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783580, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00贀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783581, new IntPtr(2737336599036L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00踀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783578, new IntPtr(2737336577196L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00輀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783579, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00退(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783576, new IntPtr(2737336588636L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00鄀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790783577, new IntPtr(2737336586556L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
