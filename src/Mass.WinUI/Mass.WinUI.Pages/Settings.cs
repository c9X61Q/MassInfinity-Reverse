using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Markup;
using WinRT;
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
		internal static object _FF00_FF00_FF00_FF00ⴀ()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_2E00()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static void _FF00_FF00_FF00_FF00_2F00(object P_0, byte P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778742, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void _FF00_FF00_FF00_FF00_3000(object P_0, byte P_1)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
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
			public Settings_obj1_BindingsTracking(Settings_obj1_Bindings obj)
			{
				//IL_0036: Expected I4, but got Obj
				//IL_0020->IL0029: Incompatible stack types: I4 vs Obj
				//IL_004b->IL0029: Incompatible stack heights: 2 vs 1
				//IL_0056->IL0029: Incompatible stack heights: 2 vs 1
				if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
				{
				}
				Settings_obj1_BindingsTracking settings_obj1_BindingsTracking = this;
				if (0 == 0)
				{
					settings_obj1_BindingsTracking = (Settings_obj1_BindingsTracking)0;
				}
				while (true)
				{
					switch ((int)settings_obj1_BindingsTracking)
					{
					case 1:
						return;
					}
					if (1 == 0)
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
			internal void _FF00_FF00_FF00_F000(object P_0, object P_1)
			{
				//IL_0010: Expected Obj, but got I4
				//IL_0042: Expected I4, but got Obj
				//IL_00b3: Expected Obj, but got I4
				//IL_0099->IL00e7: Incompatible stack heights: 1 vs 0
				//IL_006a->IL0019: Incompatible stack heights: 0 vs 1
				//IL_00dc->IL0019: Incompatible stack heights: 2 vs 1
				//IL_00fc->IL0019: Incompatible stack heights: 4 vs 1
				//IL_0085->IL0019: Incompatible stack heights: 0 vs 1
				//IL_00a3->IL0019: Incompatible stack heights: 2 vs 1
				//IL_0075->IL0019: Incompatible stack types: I4 vs Obj
				//IL_00e7->IL0019: Incompatible stack heights: 2 vs 1
				//IL_0090->IL0019: Incompatible stack types: I4 vs Obj
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
						case 6:
							return;
						case 2:
							obj = this;
							if (1 == 0)
							{
								obj2 = 1;
							}
							continue;
						case 8:
							obj = P_0;
							if (0 == 0)
							{
								obj2 = 0;
							}
							continue;
						default:
							if (null == null)
							{
								_ = 3;
								continue;
							}
							break;
						case 1:
							if (obj == null)
							{
								goto end_IL_0019;
							}
							goto case 8;
						case 4:
							return;
						case 3:
						case 5:
							_ = 1073741824;
							if (4 == 0)
							{
								_ = 4;
							}
							continue;
						case 7:
							break;
						}
						_ = 1073741824;
						_ = 5;
						continue;
						end_IL_0019:
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
			internal void _FF00_FF00_FF00_F200()
			{
				//IL_0010: Expected Obj, but got I4
				//IL_002a: Expected I4, but got Obj
				//IL_003e->IL0019: Incompatible stack heights: 2 vs 1
				//IL_0059->IL0019: Incompatible stack heights: 2 vs 1
				//IL_0049->IL0019: Incompatible stack heights: 2 vs 1
				//IL_0064->IL0019: Incompatible stack heights: 2 vs 1
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
					case 1:
						_ = null;
						if (0 == 0)
						{
							_ = 0;
						}
						break;
					case 0:
						return;
					case 2:
						_ = null;
						if (false)
						{
							_ = 1;
						}
						break;
					}
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static byte _FF00_FF00_FF00_F300()
			{
				//IL_0009: Invalid comparison between Unknown and Obj
				if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
				{
				}
				return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static byte _FF00_FF00_FF00_F400()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778702, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
				return (byte)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void _FF00_FF00_FF00_F500(object P_0, object P_1)
			{
				//IL_0010: Expected Obj, but got I4
				//IL_003e: Expected I4, but got Obj
				//IL_00e2->IL0019: Incompatible stack heights: 2 vs 1
				//IL_005b->IL0083: Incompatible stack heights: 1 vs 0
				//IL_00c3->IL0019: Incompatible stack heights: 0 vs 1
				//IL_00a8->IL0019: Incompatible stack heights: 0 vs 1
				//IL_0098->IL0019: Incompatible stack heights: 4 vs 1
				//IL_00ed->IL0019: Incompatible stack heights: 2 vs 1
				//IL_00ce->IL0019: Incompatible stack types: I4 vs Obj
				//IL_0083->IL0019: Incompatible stack types: I4 vs Obj
				//IL_00b3->IL0019: Incompatible stack types: I4 vs Obj
				//IL_0072->IL0019: Incompatible stack types: I4 vs Obj
				if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
				{
				}
				object obj = 6;
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 3:
						obj2 = obj;
						if (null == null)
						{
							if (0 == 0)
							{
								obj2 = 0;
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
						_ = 1073741824;
						_ = 2;
						break;
					case 6:
						obj = this;
						if (5 != 0)
						{
							obj2 = 5;
						}
						break;
					case 4:
						obj = P_0;
						if (3 == 0)
						{
							obj2 = 3;
						}
						break;
					default:
						_ = 1073741824;
						if (1 == 0)
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
				//IL_0010: Expected Obj, but got I4
				//IL_0042: Expected I4, but got Obj
				//IL_00a7->IL0073: Incompatible stack heights: 1 vs 0
				//IL_009f->IL0019: Incompatible stack heights: 4 vs 1
				//IL_0073->IL0019: Incompatible stack heights: 3 vs 1
				//IL_00ee->IL0019: Incompatible stack heights: 2 vs 1
				//IL_0082->IL0019: Incompatible stack heights: 2 vs 1
				//IL_0102->IL009f: Incompatible stack heights: 1 vs 0
				//IL_00c7->IL00de: Incompatible stack heights: 1 vs 0
				//IL_00f9->IL0019: Incompatible stack heights: 2 vs 1
				//IL_008d->IL0019: Incompatible stack heights: 2 vs 1
				//IL_010c->IL0019: Incompatible stack heights: 2 vs 1
				//IL_00be->IL0019: Incompatible stack types: I4 vs Obj
				//IL_00de->IL0019: Incompatible stack types: I4 vs Obj
				if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
				{
				}
				object obj = 8;
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 2:
						return;
					case 4:
						_ = 5;
						break;
					case 6:
						if (0 == 0)
						{
							_ = 1;
						}
						break;
					case 1:
						_ = 3;
						break;
					default:
						obj2 = P_0;
						if (null == null)
						{
							if (2 == 0)
							{
								obj2 = 0;
							}
							break;
						}
						goto case 6;
					case 8:
						obj2 = P_0;
						if (this != null)
						{
							if (7 == 0)
							{
								obj2 = 5;
							}
							break;
						}
						return;
					case 3:
						return;
					case 5:
						_ = null;
						if (false)
						{
							_ = 0;
						}
						break;
					case 7:
						if (null != null)
						{
							_ = 4;
							break;
						}
						goto default;
					}
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void _FF00_FF00_FF00_F800(object P_0)
			{
				//IL_0010: Expected Obj, but got I4
				//IL_003e: Expected I4, but got Obj
				//IL_0050->IL0019: Incompatible stack heights: 3 vs 1
				//IL_00ee->IL0019: Incompatible stack heights: 3 vs 1
				//IL_0058->IL008f: Incompatible stack heights: 1 vs 0
				//IL_0099->IL0050: Incompatible stack heights: 1 vs 0
				//IL_0078->IL008f: Incompatible stack heights: 1 vs 0
				//IL_00b2->IL0019: Incompatible stack heights: 2 vs 1
				//IL_00cf->IL0019: Incompatible stack heights: 2 vs 1
				//IL_00f9->IL0019: Incompatible stack heights: 3 vs 1
				//IL_00a3->IL0019: Incompatible stack heights: 2 vs 1
				//IL_00bd->IL0019: Incompatible stack heights: 2 vs 1
				//IL_00da->IL0019: Incompatible stack heights: 2 vs 1
				//IL_006f->IL0019: Incompatible stack types: I4 vs Obj
				//IL_008f->IL0019: Incompatible stack types: I4 vs Obj
				if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
				{
				}
				object obj = 5;
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						_ = 2;
						break;
					case 3:
						obj2 = P_0;
						if (null != null)
						{
							if (false)
							{
								obj2 = 0;
							}
							break;
						}
						return;
					case 5:
						obj2 = P_0;
						if (this != null)
						{
							if (4 == 0)
							{
								obj2 = 2;
							}
							break;
						}
						return;
					case 1:
						return;
					case 4:
						if (null != null)
						{
							_ = 7;
							break;
						}
						goto case 3;
					case 6:
						_ = null;
						if (3 == 0)
						{
							_ = 0;
						}
						break;
					case 7:
						if (false)
						{
							_ = 6;
						}
						break;
					case 2:
						if (1 == 0)
						{
							_ = 1;
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
			internal static object _FF00_FF00_FF00ﬀ()
			{
				if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
				{
				}
				return (object)/*Error near IL_0009: Stack underflow*/;
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
		public Settings_obj1_Bindings()
		{
			//IL_003e: Expected I4, but got Obj
			//IL_0028->IL0031: Incompatible stack types: I4 vs Obj
			//IL_0053->IL0031: Incompatible stack heights: 3 vs 2
			//IL_005e->IL0031: Incompatible stack heights: 3 vs 2
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			Settings_obj1_Bindings settings_obj1_Bindings = this;
			if (false)
			{
				settings_obj1_Bindings = (Settings_obj1_Bindings)1;
			}
			while (true)
			{
				switch ((int)settings_obj1_Bindings)
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
		private void _FF00_FF00_FF00_FF00Ā(byte P_0, uint P_1)
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
		private unsafe void _FF00_FF00_FF00_FF00Ȁ(byte P_0, uint P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778741, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_0300()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00Ѐ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778738, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _FF00_FF00_FF00_FF00Ԁ(object P_0, uint P_1)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_003e: Expected I4, but got Obj
			//IL_00b8->IL0019: Incompatible stack heights: 4 vs 1
			//IL_006a->IL0019: Incompatible stack heights: 3 vs 1
			//IL_00dd->IL0086: Incompatible stack heights: 1 vs 0
			//IL_00c9->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0052->IL0019: Incompatible stack heights: 2 vs 1
			//IL_009e->IL0019: Incompatible stack heights: 0 vs 1
			//IL_00e7->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00d4->IL0019: Incompatible stack heights: 3 vs 1
			//IL_005d->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00a9->IL0019: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (false)
					{
						_ = 1;
					}
					break;
				case 2:
					_ = 7;
					break;
				case 3:
					if ((P_1 & 0xC0000001u) != 0)
					{
						if (false)
						{
							obj2 = 0;
						}
						break;
					}
					goto case 4;
				default:
					_ = 6;
					break;
				case 6:
					if (2 != 0)
					{
						_ = 1;
					}
					break;
				case 1:
					return;
				case 5:
					if (null == null)
					{
						_ = 4;
						break;
					}
					goto case 3;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _FF00_FF00_FF00_FF00_0700(uint P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0032: Expected I4, but got Obj
			//IL_0048: Expected Obj, but got I4
			//IL_004d->IL0015: Incompatible stack heights: 2 vs 0
			//IL_007c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_009f->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0087->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00aa->IL0019: Incompatible stack types: I4 vs Obj
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
					default:
						return;
					case 0:
						return;
					case 1:
						return;
					case 3:
						break;
					case 4:
						if (0 == 0)
						{
							_ = 0;
						}
						continue;
					case 2:
						if ((P_0 & 0xC0000001u) == 0)
						{
							if (0 == 0)
							{
								obj2 = 1;
							}
							continue;
						}
						break;
					}
					break;
				}
				obj = 4;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal sealed void _FF00_FF00_FF00_FF00ࠀ()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002a: Expected I4, but got Obj
			//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
			//IL_005c->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0067->IL0019: Incompatible stack types: I4 vs Obj
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
					obj2 = this;
					if (2 != 0)
					{
						obj2 = 2;
					}
					break;
				case 1:
					if (this != null)
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
			//IL_0010: Expected Obj, but got I4
			//IL_002a: Expected I4, but got Obj
			//IL_010c->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0096->IL0050: Incompatible stack heights: 0 vs 2
			//IL_0061->IL0066: Incompatible stack heights: 1 vs 0
			//IL_0061->IL0082: Incompatible stack heights: 1 vs 0
			//IL_00a1->IL0050: Incompatible stack heights: 1 vs 2
			//IL_0066->IL0066: Incompatible stack heights: 1 vs 0
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
				case 1:
					obj2 = this;
					obj = this;
					if (false)
					{
						obj2 = 0;
					}
					continue;
				}
				while (true)
				{
					if (&obj == null)
					{
						if (2 == 0)
						{
							_ = 2;
						}
						goto IL_0050;
					}
					goto IL_0066;
					IL_0066:
					_ = ref obj;
					int num = (int)P_0;
					if (true)
					{
						num = 1;
					}
					goto IL_0050;
					IL_0050:
					switch (num)
					{
					case 1:
						continue;
					case 2:
						return;
					}
					goto IL_0066;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe byte _FF00_FF00_FF00_FF00_0C00(nint P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0032: Expected I4, but got Obj
			//IL_0064->IL0019: Incompatible stack heights: 0 vs 1
			//IL_006f->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0053->IL0019: Incompatible stack types: I4 vs Obj
			//IL_00af->IL0019: Incompatible stack types: I4 vs Obj
			//IL_008f->IL0019: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					Unsafe.Write((void*)P_0, obj);
					if (0 == 0)
					{
						obj2 = 1;
					}
					break;
				case 3:
					obj2 = this;
					if (&obj != null)
					{
						if (2 == 0)
						{
							obj2 = 2;
						}
						break;
					}
					goto IL_0039;
				case 2:
					obj2 = obj;
					if (null != null)
					{
						if (1 == 0)
						{
							obj2 = 4;
						}
						break;
					}
					goto IL_0039;
				default:
					{
						return 0;
					}
					IL_0039:
					Unsafe.Write((void*)P_0, null);
					if (0 == 0)
					{
						obj2 = 0;
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
		private void _FF00_FF00_FF00_FF00_0E00(object P_0, uint P_1)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0097: Expected Obj, but got I4
			//IL_00a4->IL006d: Incompatible stack heights: 1 vs 0
			//IL_007e->IL0019: Incompatible stack heights: 2 vs 1
			//IL_009c->IL0015: Incompatible stack heights: 3 vs 0
			//IL_0089->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0053->IL0019: Incompatible stack heights: 0 vs 1
			//IL_00bb->IL0019: Incompatible stack types: I4 vs Obj
			//IL_005e->IL0019: Incompatible stack types: I4 vs Obj
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
					case 2:
						if ((P_1 & 0xC0000001u) == 0)
						{
							if (5 != 0)
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
						if (0 == 0)
						{
							_ = 0;
						}
						continue;
					case 3:
						break;
					default:
						obj2 = P_0;
						if (null == null)
						{
							return;
						}
						if (2 != 0)
						{
							obj2 = 1;
						}
						continue;
					}
					break;
				}
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
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0046->IL0019: Incompatible stack types: I4 vs Obj
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
					Unsafe.Write((void*)P_0, this);
					if (false)
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
		internal sealed void _FF00_FF00_FF00_FF00ᄀ()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002a: Expected I4, but got Obj
			//IL_0059->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004a->IL0019: Incompatible stack types: I4 vs Obj
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
				case 1:
					obj2 = this;
					if (false)
					{
						obj2 = 0;
					}
					break;
				default:
					_ = 0;
					if (true)
					{
						_ = 2;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0071: Expected I4, but got Obj
			//IL_0067: Expected Obj, but got I4
			//IL_007d->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0091->IL006c: Incompatible stack heights: 1 vs 0
			//IL_00a4->IL005b: Incompatible stack heights: 1 vs 0
			//IL_0088->IL0019: Incompatible stack types: I4 vs Obj
			//IL_009b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00bb->IL0019: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
						*(sbyte*)P_0 = (sbyte)(int)obj;
						if (true)
						{
							obj2 = 1;
						}
						continue;
					case 4:
						if (null == null)
						{
							_ = 2;
							continue;
						}
						goto default;
					case 5:
						obj2 = this;
						if (&obj != null)
						{
							if (4 == 0)
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
		internal byte _FF00_FF00_FF00_FF00ᔀ(object P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0032: Expected I4, but got Obj
			//IL_0084->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0070->IL0019: Incompatible stack types: I4 vs Obj
			//IL_008f->IL0019: Incompatible stack heights: 2 vs 1
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
					if (P_0 == null)
					{
						obj2 = 4;
						continue;
					}
					break;
				case 1:
					obj2 = this;
					if (false)
					{
						obj2 = 0;
					}
					continue;
				case 2:
					return 1;
				case 4:
					return 0;
				case 3:
					break;
				}
				if (0 == 0)
				{
					_ = 2;
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
		private void _FF00_FF00_FF00_FF00ᜀ(byte P_0, uint P_1)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0097->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0087->IL0019: Incompatible stack heights: 3 vs 1
			//IL_00b2->IL0019: Incompatible stack heights: 2 vs 1
			//IL_006e->IL0019: Incompatible stack heights: 0 vs 1
			//IL_00a2->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0056->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00bd->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0079->IL0019: Incompatible stack types: I4 vs Obj
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
					if (3 == 0)
					{
						_ = 5;
					}
					continue;
				case 3:
					_ = 4;
					continue;
				case 4:
					return;
				case 1:
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
				case 5:
					if (3 != 0)
					{
						_ = 3;
					}
					continue;
				}
				if ((P_1 & 0xC0000001u) != 0)
				{
					if (1 == 0)
					{
						obj2 = 2;
					}
					continue;
				}
				return;
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
		internal void _FF00_FF00_FF00_FF00ᤀ(object P_0, object P_1)
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00ᨀ(object P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778747, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal sealed void _FF00_FF00_FF00_FF00_1B00()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002a: Expected I4, but got Obj
			//IL_003e->IL0019: Incompatible stack heights: 2 vs 1
			//IL_005e->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0049->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0069->IL0019: Incompatible stack heights: 3 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			while (true)
			{
				switch ((int)obj)
				{
				default:
					_ = 1;
					if (2 == 0)
					{
						_ = 2;
					}
					break;
				case 1:
					_ = int.MinValue;
					if (0 == 0)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0042: Expected I4, but got Obj
			//IL_00d9->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00f5->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0066->IL00a0: Incompatible stack heights: 1 vs 0
			//IL_00e4->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0100->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0070->IL0019: Incompatible stack heights: 2 vs 1
			//IL_005d->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0084->IL0019: Incompatible stack heights: 4 vs 1
			//IL_00b4->IL0019: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (&obj != null)
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
					if (&obj != null)
					{
						obj = obj;
						_ = 8;
					}
					else
					{
						_ = 5;
					}
					continue;
				case 4:
					return;
				case 1:
					return;
				default:
					if (true)
					{
						_ = 1;
					}
					continue;
				case 2:
					break;
				}
				if (0 == 0)
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
		internal void _FF00_FF00_FF00_FF00_2000(object P_0, object P_1)
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
			{
			}
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
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_0066: Expected Obj, but got I4
			//IL_00d0->IL0019: Incompatible stack heights: 0 vs 1
			//IL_005d->IL00bf: Incompatible stack heights: 1 vs 0
			//IL_004a->IL0054: Incompatible stack heights: 1 vs 0
			//IL_00db->IL0019: Incompatible stack types: I4 vs Obj
			//IL_006b->IL0015: Incompatible stack heights: 1 vs 0
			//IL_0098->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0054->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00a3->IL0019: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
						if (&obj == null)
						{
							_ = 5;
							continue;
						}
						goto case 1;
					case 1:
						if (null != null)
						{
							break;
						}
						goto end_IL_0019;
					case 2:
						return 1;
					case 3:
					case 5:
						Unsafe.Write((void*)P_0, null);
						if (4 == 0)
						{
							obj2 = 1;
						}
						continue;
					}
					Unsafe.Write((void*)P_0, obj);
					if (2 == 0)
					{
						obj2 = 2;
					}
					continue;
					end_IL_0019:
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
		private void _FF00_FF00_FF00_FF00_2400(object P_0, uint P_1)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_0047->IL00a7: Incompatible stack heights: 1 vs 0
			//IL_00a7->IL0019: Incompatible stack heights: 3 vs 1
			//IL_007e->IL0019: Incompatible stack heights: 3 vs 1
			//IL_00bd->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0051->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0089->IL0019: Incompatible stack heights: 3 vs 1
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
				case 2:
					if (null == null)
					{
						_ = 6;
						break;
					}
					goto case 1;
				case 6:
					return;
				case 5:
					if (0 == 0)
					{
						_ = 0;
					}
					break;
				case 4:
					return;
				case 0:
					return;
				case 3:
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
		internal sealed void _FF00_FF00_FF00_FF00_2600(uint P_0)
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			throw /*Error near IL_000a: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_2700()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_2800()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778690, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal sealed void _FF00_FF00_FF00_FF00_2900(uint P_0, object P_1)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_00ab: Expected Obj, but got I4
			//IL_006a->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0050->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00c0->IL0019: Incompatible stack heights: 3 vs 1
			//IL_00d1->IL0019: Incompatible stack heights: 2 vs 1
			//IL_007b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_005b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00dc->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0086->IL0019: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
							if (0 == 0)
							{
								_ = 1;
							}
							goto end_IL_0019;
						case 3u:
							_ = 4;
							goto end_IL_0019;
						case 7u:
							if (2 != 0)
							{
								_ = 6;
							}
							goto end_IL_0019;
						case 5u:
							_ = 5;
							goto end_IL_0019;
						case 6u:
							if (0 == 0)
							{
								_ = 0;
							}
							goto end_IL_0019;
						}
						obj = 2;
						goto end_IL_0019_2;
					case 6:
						return;
					case 1:
						return;
					case 5:
						return;
						end_IL_0019:
						break;
					}
					continue;
					end_IL_0019_2:
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe byte _FF00_FF00_FF00_FF00_2A00(nint P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_0057: Expected I4, but got Obj
			//IL_00ba: Expected Obj, but got I4
			//IL_0048->IL0052: Incompatible stack heights: 1 vs 0
			//IL_0063->IL0019: Incompatible stack heights: 0 vs 1
			//IL_00b1->IL003f: Incompatible stack heights: 1 vs 0
			//IL_0052->IL0019: Incompatible stack heights: 2 vs 1
			//IL_006e->IL0019: Incompatible stack types: I4 vs Obj
			//IL_009d->IL0019: Incompatible stack heights: 0 vs 1
			//IL_00bf->IL0015: Incompatible stack heights: 1 vs 0
			//IL_00a8->IL0019: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
						if (null == null)
						{
							_ = 6;
							continue;
						}
						goto case 2;
					case 2:
						*(sbyte*)P_0 = (sbyte)(int)obj;
						if (0 == 0)
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
						if (3 != 0)
						{
							obj2 = 2;
						}
						continue;
					case 5:
						if (&obj == null)
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_04d3: Expected Obj, but got Ref
			//IL_01bd: Expected Obj, but got Ref
			//IL_012f: Expected Obj, but got I4
			//IL_0357: Unknown result type (might be due to invalid IL or missing references)
			//IL_0359: Unknown result type (might be due to invalid IL or missing references)
			//IL_037d: Expected Obj, but got I4
			//IL_01aa: Expected Obj, but got I4
			//IL_01b4: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_004a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_04c3->IL0019: Incompatible stack heights: 2 vs 1
			//IL_04df->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0055->IL0019: Incompatible stack heights: 2 vs 1
			//IL_04ce->IL0019: Incompatible stack heights: 2 vs 1
			//IL_006f->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0081->IL0085: Incompatible stack types: I4 vs Ref
			//IL_04ea->IL0019: Incompatible stack types: I4 vs Ref
			//IL_03ff->IL03ff: Incompatible stack heights: 1 vs 0
			//IL_0351->IL0085: Incompatible stack heights: 3 vs 1
			//IL_0411->IL0085: Incompatible stack heights: 0 vs 1
			//IL_0184->IL0085: Incompatible stack heights: 3 vs 1
			//IL_01c9->IL0085: Incompatible stack heights: 0 vs 1
			//IL_03c7->IL0085: Incompatible stack types: Obj vs Ref
			//IL_013c->IL0085: Incompatible stack heights: 2 vs 1
			//IL_0387->IL0085: Incompatible stack heights: 12 vs 1
			//IL_0341->IL0085: Incompatible stack heights: 2 vs 1
			//IL_011b->IL0085: Incompatible stack heights: 4 vs 1
			//IL_0100->IL0085: Incompatible stack heights: 0 vs 1
			//IL_041c->IL0085: Incompatible stack types: I4 vs Ref
			//IL_01d4->IL0085: Incompatible stack types: I4 vs Ref
			//IL_03e6->IL0085: Incompatible stack heights: 0 vs 1
			//IL_01e5->IL01e9: Incompatible stack heights: 1 vs 0
			//IL_03d2->IL0085: Incompatible stack types: I4 vs Ref
			//IL_0147->IL0085: Incompatible stack heights: 2 vs 1
			//IL_039c->IL0085: Incompatible stack heights: 0 vs 1
			//IL_0085->IL0085: Incompatible stack heights: 3 vs 1
			//IL_02ea->IL0085: Incompatible stack types: I4 vs Ref
			//IL_0196->IL0085: Incompatible stack types: I4 vs Ref
			//IL_010b->IL0085: Incompatible stack types: I4 vs Ref
			//IL_02fc->IL0085: Incompatible stack types: I4 vs Ref
			//IL_03f1->IL0085: Incompatible stack types: I4 vs Ref
			//IL_0230->IL01e9: Incompatible stack heights: 1 vs 0
			//IL_03a7->IL0085: Incompatible stack types: I4 vs Ref
			//IL_0212->IL01e9: Incompatible stack heights: 2 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			ref _003CRepairShadowGameButton_Click_003Ed__4 reference = ref *(_003CRepairShadowGameButton_Click_003Ed__4*)obj;
			while (true)
			{
				ref _003CRepairShadowGameButton_Click_003Ed__4 reference2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					return;
				case 1u:
					_ = null;
					if (true)
					{
						_ = 3;
					}
					break;
				case 3u:
					reference = ref this;
					if (0 == 0)
					{
						reference = ref *(_003CRepairShadowGameButton_Click_003Ed__4*)null;
					}
					break;
				case 4u:
					if (obj == null)
					{
						reference2 = ref *(_003CRepairShadowGameButton_Click_003Ed__4*)6;
						goto IL_0085;
					}
					goto IL_03f1;
				case 2u:
					goto IL_04b3;
				case 0u:
					return;
				case 5u:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (3 != 0)
						{
							reference = ref *(_003CRepairShadowGameButton_Click_003Ed__4*)4;
						}
						break;
					}
					IL_0341:
					_ = null;
					_ = null;
					_ = 5;
					goto IL_0085;
					IL_03f1:
					if ((int)/*Error near IL_03f3: Stack underflow*/ == 0)
					{
						/*Error near IL_03fd: Stack underflow*/;
					}
					if ((int)/*Error near IL_0405: Stack underflow*/ == 0)
					{
						if (1 == 0)
						{
							reference2 = ref *(_003CRepairShadowGameButton_Click_003Ed__4*)null;
						}
						goto IL_0085;
					}
					goto IL_0341;
					IL_04b3:
					_ = -2;
					if (true)
					{
						_ = 1;
					}
					break;
					IL_0085:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference2))
						{
						case 23u:
							if (6 != 0)
							{
								reference2 = ref *(_003CRepairShadowGameButton_Click_003Ed__4*)7;
							}
							continue;
						case 17u:
							_ = ref obj;
							_ = 21;
							continue;
						case 21u:
							return;
						case 9u:
							obj = 0;
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						default:
							_ = 17;
							continue;
						case 19u:
							if (&obj == null)
							{
								reference2 = ref *(_003CRepairShadowGameButton_Click_003Ed__4*)9;
								continue;
							}
							goto case 13u;
						case 14u:
							obj = -1;
							obj = 13;
							continue;
						case 3u:
						case 6u:
							obj = (object)Unsafe.AsPointer(ref this);
							if (6 != 0)
							{
								reference2 = ref *(_003CRepairShadowGameButton_Click_003Ed__4*)15;
							}
							continue;
						case 7u:
							if ((int)/*Error near IL_01db: Stack underflow*/ == 0)
							{
								_ = 3;
								goto IL_01e9;
							}
							goto IL_0212;
						case 1u:
						case 16u:
							reference2 = ref this;
							if (2 != 0)
							{
								reference2 = ref *(_003CRepairShadowGameButton_Click_003Ed__4*)4;
							}
							continue;
						case 24u:
							if (Unsafe.AsPointer(ref this) == null)
							{
								reference2 = ref *(_003CRepairShadowGameButton_Click_003Ed__4*)8;
								continue;
							}
							goto case 10u;
						case 15u:
							_ = 14;
							continue;
						case 12u:
							break;
						case 10u:
							/*Error near IL_0352: Stack underflow*/;
							_ = 2;
							obj = 1;
							_ = 19;
							continue;
						case 13u:
							if (&obj != (object*)1)
							{
								if (1 == 0)
								{
									reference2 = ref *(_003CRepairShadowGameButton_Click_003Ed__4*)2;
								}
								continue;
							}
							goto case 23u;
						case 8u:
						case 20u:
							reference2 = ref *(_003CRepairShadowGameButton_Click_003Ed__4*)null;
							if (11 != 0)
							{
								reference2 = ref *(_003CRepairShadowGameButton_Click_003Ed__4*)8;
							}
							continue;
						case 4u:
							if (Unsafe.AsPointer(ref this) != null)
							{
								if (18 != 0)
								{
									reference2 = ref *(_003CRepairShadowGameButton_Click_003Ed__4*)20;
								}
								continue;
							}
							goto case 24u;
						case 18u:
							goto IL_03f1;
						case 2u:
						case 5u:
						case 11u:
						case 22u:
							goto IL_04b3;
							IL_0212:
							if (0 == 0)
							{
								_ = 0;
							}
							goto IL_01e9;
							IL_01e9:
							while (true)
							{
								switch ((int)/*Error near IL_01fe: Stack underflow*/)
								{
								case 3:
									_ = null;
									_ = 2;
									continue;
								case 1:
									break;
								default:
									goto IL_04b3;
								}
								break;
							}
							goto IL_0212;
						}
						break;
					}
					goto IL_0341;
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
		internal static byte _FF00_FF00_FF00쀀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00섀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779054, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00숀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00쌀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779055, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00쐀(object P_0)
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
					if (0 == 0)
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
		//IL_0255->IL001c: Incompatible stack heights: 4 vs 2
		//IL_00dc->IL001c: Incompatible stack heights: 5 vs 2
		//IL_0095->IL001c: Incompatible stack heights: 3 vs 2
		//IL_012a->IL001c: Incompatible stack heights: 4 vs 2
		//IL_01a1->IL001c: Incompatible stack heights: 4 vs 2
		//IL_00b2->IL001c: Incompatible stack heights: 5 vs 2
		//IL_00cc->IL001c: Incompatible stack heights: 3 vs 2
		//IL_0234->IL001c: Incompatible stack heights: 4 vs 2
		//IL_01ce->IL001c: Incompatible stack heights: 4 vs 2
		//IL_014b->IL001c: Incompatible stack heights: 4 vs 2
		//IL_00ee->IL001c: Incompatible stack heights: 4 vs 2
		//IL_01bc->IL001c: Incompatible stack heights: 5 vs 2
		//IL_0243->IL001c: Incompatible stack heights: 4 vs 2
		//IL_0168->IL001c: Incompatible stack heights: 4 vs 2
		//IL_0209->IL001c: Incompatible stack heights: 5 vs 2
		//IL_0184->IL001c: Incompatible stack heights: 3 vs 2
		//IL_01f9->IL001c: Incompatible stack heights: 5 vs 2
		//IL_01e9->IL001c: Incompatible stack heights: 5 vs 2
		//IL_0272->IL001c: Incompatible stack heights: 4 vs 2
		//IL_021a->IL001c: Incompatible stack heights: 3 vs 2
		//IL_00be->IL001c: Incompatible stack heights: 3 vs 2
		//IL_028f->IL001c: Incompatible stack heights: 4 vs 2
		//IL_010d->IL001c: Incompatible stack heights: 3 vs 2
		//IL_0260->IL001c: Incompatible stack heights: 4 vs 2
		//IL_00a0->IL001c: Incompatible stack heights: 3 vs 2
		//IL_0135->IL001c: Incompatible stack heights: 4 vs 2
		//IL_01ac->IL001c: Incompatible stack heights: 4 vs 2
		//IL_01d9->IL001c: Incompatible stack heights: 4 vs 2
		//IL_0156->IL001c: Incompatible stack heights: 4 vs 2
		//IL_00f9->IL001c: Incompatible stack heights: 4 vs 2
		//IL_0173->IL001c: Incompatible stack heights: 4 vs 2
		//IL_018f->IL001c: Incompatible stack heights: 3 vs 2
		//IL_027d->IL001c: Incompatible stack heights: 4 vs 2
		//IL_0225->IL001c: Incompatible stack heights: 3 vs 2
		//IL_0118->IL001c: Incompatible stack heights: 3 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		while (true)
		{
			switch (21)
			{
			case 2:
				_ = 1;
				if (16 == 0)
				{
					_ = 13;
				}
				break;
			case 5:
				_ = 4;
				break;
			case 21:
				_ = 22;
				break;
			case 6:
				_ = 2;
				break;
			case 1:
				_ = null;
				_ = 20;
				break;
			case 10:
				_ = null;
				if (true)
				{
					_ = 14;
				}
				break;
			case 23:
				if (10 != 0)
				{
					_ = 9;
				}
				break;
			case 3:
				_ = null;
				if (19 == 0)
				{
					_ = 19;
				}
				break;
			case 9:
				_ = 1080;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 13:
				_ = null;
				if (5 != 0)
				{
					_ = 4;
				}
				break;
			case 16:
				return;
			case 15:
				if (1 == 0)
				{
					_ = 1;
				}
				break;
			case 4:
				_ = null;
				if (15 != 0)
				{
					_ = 11;
				}
				break;
			case 11:
				_ = null;
				_ = 17;
				break;
			case 8:
				_ = null;
				if (4 == 0)
				{
					_ = 11;
				}
				break;
			case 18:
				_ = null;
				_ = 3;
				break;
			case 17:
				_ = null;
				_ = 13;
				break;
			case 14:
				_ = null;
				_ = 18;
				break;
			case 20:
				if (9 != 0)
				{
					_ = 6;
				}
				break;
			case 7:
				_ = 6;
				break;
			case 12:
				_ = 7;
				break;
			default:
				_ = null;
				if (12 != 0)
				{
					_ = 7;
				}
				break;
			case 19:
				_ = null;
				if (6 != 0)
				{
					_ = 8;
				}
				break;
			case 22:
				_ = 23;
				break;
			}
		}
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
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_007c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0061->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0087->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004e->IL0019: Incompatible stack types: I4 vs Ref
		//IL_006c->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		ref object reference = ref *(object*)obj;
		while (true)
		{
			switch ((uint)Unsafe.AsPointer(ref reference))
			{
			case 1u:
				reference = ref obj;
				if (0 == 0)
				{
					reference = ref *(object*)null;
				}
				break;
			case 2u:
				return;
			case 3u:
				_ = ref obj;
				_ = ref obj;
				if (1 == 0)
				{
					_ = 2;
				}
				break;
			default:
				_ = ref obj;
				_ = -1;
				if (3 == 0)
				{
					_ = 3;
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
	internal static byte _FF00_FF00_FF00_FF00_2200()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_2300(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778723, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_2400(object P_0)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
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
	internal static void _FF00_FF00_FF00_FF00_2700(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_005d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0042->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0079->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0068->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0084->IL0019: Incompatible stack types: I4 vs Obj
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
			case 2:
				_ = -1;
				if (false)
				{
					_ = 1;
				}
				break;
			case 1:
				if (false)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			case 3:
				obj = P_0;
				if (2 == 0)
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
		//IL_0010: Expected Obj, but got I4
		//IL_0042: Expected I4, but got Obj
		//IL_0066->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00f0->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0095->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b7->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0058->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00a7->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00fb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0084->IL0019: Incompatible stack heights: 4 vs 1
		//IL_00d6->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00c2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00e1->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 5:
				_ = 3;
				break;
			default:
				_ = 4;
				break;
			case 7:
				return;
			case 2:
				_ = 7;
				break;
			case 6:
				_ = 8;
				break;
			case 4:
				if (5 == 0)
				{
					_ = 3;
				}
				break;
			case 3:
				if (obj != null)
				{
					obj = obj;
					_ = ref obj;
					_ = (double)obj;
					_ = 6;
				}
				else if (0 == 0)
				{
					obj2 = 2;
				}
				break;
			case 1:
				obj = (object)/*Error near IL_00e4: Stack underflow*/;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_2B00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_2E00(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778735, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_2F00(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0042: Expected I4, but got Obj
		//IL_0073: Expected Obj, but got I4
		//IL_0119: Expected Obj, but got I4
		//IL_0078->IL0015: Incompatible stack heights: 1 vs 0
		//IL_00a7->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00d3->IL0019: Incompatible stack heights: 0 vs 1
		//IL_008c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00f2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00de->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0097->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00fd->IL0019: Incompatible stack heights: 2 vs 1
		//IL_011e->IL0015: Incompatible stack heights: 2 vs 0
		//IL_010f->IL010f: Incompatible stack heights: 1 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					obj = 8;
					break;
				case 6:
					return;
				case 5:
					if (0 == 0)
					{
						_ = 1;
					}
					continue;
				case 2:
					if (5 == 0)
					{
						_ = 5;
					}
					continue;
				case 1:
					if (obj != null)
					{
						obj2 = 4;
						continue;
					}
					goto default;
				case 3:
					obj = (object)/*Error near IL_00c7: Stack underflow*/;
					if (2 == 0)
					{
						obj2 = 2;
					}
					continue;
				case 7:
					if (3 != 0)
					{
						_ = 6;
					}
					continue;
				case 8:
					return;
				case 4:
					if (obj == null)
					{
					}
					obj = 7;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_3100()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0048: Expected Obj, but got I4
		//IL_005c->IL0019: Incompatible stack heights: 4 vs 1
		//IL_006c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004d->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0099->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0077->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a4->IL0019: Incompatible stack types: I4 vs Obj
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
				case 1:
					break;
				default:
					_ = 0;
					_ = 3;
					continue;
				case 5:
					obj = (object)/*Error near IL_0060: Stack underflow*/;
					if (false)
					{
						obj2 = 0;
					}
					continue;
				case 2:
					if (this != null)
					{
						return;
					}
					if (1 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 3:
					return;
				}
				break;
			}
			_ = 1;
			obj = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_3200(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0042: Expected I4, but got Obj
		//IL_00c1: Invalid comparison between Unknown and I4
		//IL_00b3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00e3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a3->IL0019: Incompatible stack heights: 3 vs 1
		//IL_006f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0088->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00be->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ee->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00d0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0093->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00fc->IL0102: Incompatible stack heights: 0 vs 1
		//IL_0057->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0114->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0062->IL0019: Incompatible stack types: I4 vs Obj
		//IL_011f->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				if (2 == 0)
				{
					obj2 = 7;
				}
				break;
			case 7:
				if (5 != 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				_ = null;
				_ = null;
				_ = 2;
				break;
			default:
				_ = 0;
				if (6 == 0)
				{
					_ = 3;
				}
				break;
			case 4:
			{
				if ((int)/*Error near IL_00c6: Stack underflow*/ > 0)
				{
					obj2 = 3;
					break;
				}
				_003F val;
				if ((int)/*Error near IL_00f1: Stack underflow*/ == 0)
				{
					val = /*Error near IL_0100: Stack underflow*/;
				}
				if ((int)val == 0)
				{
					obj2 = 0;
					if (0 == 0)
					{
						obj2 = 0;
					}
				}
				else if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			}
			case 5:
				return;
			case 1:
				_ = null;
				_ = null;
				if (0 == 0)
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
	private void _FF00_FF00_FF00_FF00_3300(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0044->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0069->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0076->IL007c: Incompatible stack heights: 0 vs 1
		//IL_0090->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009b->IL0019: Incompatible stack heights: 2 vs 1
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
			case 1:
				if (3 == 0)
				{
					_ = 3;
				}
				break;
			case 2:
				obj = (object)/*Error near IL_0052: Stack underflow*/;
				if (0 == 0)
				{
					obj2 = 1;
				}
				break;
			case 3:
				if ((int)/*Error near IL_006b: Stack underflow*/ == 0)
				{
					/*Error near IL_007a: Stack underflow*/;
				}
				if (false)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00㐀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_007b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0060->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00a6->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0051->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0096->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c8->IL00ca: Incompatible stack types: I4 vs Obj
		//IL_00d5->IL0019: Incompatible stack heights: 3 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 5:
				_ = 4;
				break;
			case 2:
				obj = (object)/*Error near IL_0054: Stack underflow*/;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			default:
				obj = obj;
				obj2 = 6;
				break;
			case 1:
				if (3 != 0)
				{
					_ = 3;
				}
				break;
			case 3:
				obj = (object)/*Error near IL_009a: Stack underflow*/;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 4:
				return;
			case 6:
				_ = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00㔀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_004a: Expected I4, but got Obj
		//IL_0076->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b9->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00aa->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0120->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00f8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c4->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00de->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0069->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0112->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0090->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 8;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 8:
				_ = 1;
				if (7 != 0)
				{
					_ = 3;
				}
				break;
			case 1:
				_ = 2;
				break;
			case 10:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 5:
				_ = 9;
				break;
			case 4:
				_ = 5;
				break;
			case 2:
				_ = 0;
				if (3 == 0)
				{
					_ = 3;
				}
				break;
			case 7:
				obj2 = this;
				if (6 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			case 9:
				obj2 = this;
				if (10 == 0)
				{
					obj2 = 7;
				}
				break;
			case 3:
				return;
			case 6:
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
		//IL_0010: Expected Obj, but got I4
		//IL_0042: Expected I4, but got Obj
		//IL_0067->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0074->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0059->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00b5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00d4->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00c0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0092->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00df->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00f4->IL00f6: Incompatible stack heights: 2 vs 1
		//IL_010e->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				_ = 6;
				break;
			case 2:
				_ = 5;
				break;
			case 3:
				obj = (object)/*Error near IL_006a: Stack underflow*/;
				obj2 = 2;
				break;
			case 8:
				obj2 = obj;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			case 6:
				return;
			case 5:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			default:
				if (obj != null)
				{
					if (4 != 0)
					{
						obj2 = 7;
					}
					break;
				}
				goto case 8;
			case 1:
				return;
			case 7:
				obj2 = obj;
				if (obj != null)
				{
				}
				if (3 == 0)
				{
					obj2 = 4;
				}
				break;
			}
		}
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
	private void _FF00_FF00_FF00_FF00㰀(object P_0, object P_1, Action<bool> P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_004a: Expected I4, but got Obj
		//IL_0132->IL0019: Incompatible stack heights: 3 vs 1
		//IL_005d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00d8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0120->IL0019: Incompatible stack heights: 4 vs 1
		//IL_008b->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00a9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00c0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00f3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00cb->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 7;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				obj = (object)/*Error near IL_0053: Stack underflow*/;
				obj2 = 9;
				break;
			case 5:
				return;
			case 2:
				if (obj != null)
				{
					if (3 != 0)
					{
						obj2 = 2;
					}
					break;
				}
				goto case 1;
			case 10:
				_ = 4;
				break;
			case 1:
				obj2 = obj;
				if (8 == 0)
				{
					obj2 = 8;
				}
				break;
			case 8:
				return;
			case 3:
				if (false)
				{
					_ = 0;
				}
				break;
			case 7:
				obj = (object)/*Error near IL_00ce: Stack underflow*/;
				obj2 = 6;
				break;
			case 6:
				if (10 == 0)
				{
					_ = 8;
				}
				break;
			case 9:
				_ = 2;
				break;
			default:
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
	internal sealed object _FF00_FF00_FF00_FF00㸀(uint P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0072->IL0019: Incompatible stack heights: 5 vs 1
		//IL_0081->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0046->IL0019: Incompatible stack heights: 0 vs 1
		//IL_008c->IL0019: Incompatible stack types: I4 vs Obj
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
			case 1:
				if (P_0 == 1)
				{
					if (false)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
			default:
				obj = P_1;
				obj = obj;
				_ = 3;
				continue;
			case 2:
				obj = null;
				if (1 == 0)
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
	internal sealed void _FF00_FF00_FF00_FF00㼀(uint P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_00da: Expected I4, but got Obj
		//IL_042a: Expected Obj, but got I4
		//IL_028b: Expected Obj, but got I4
		//IL_0496: Expected Obj, but got I4
		//IL_04fc: Expected Obj, but got I4
		//IL_0178->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01a2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0359->IL0019: Incompatible stack heights: 2 vs 1
		//IL_040f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0372->IL0019: Incompatible stack heights: 3 vs 1
		//IL_031e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01bd->IL0019: Incompatible stack heights: 2 vs 1
		//IL_013e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_02f6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_042f->IL0015: Incompatible stack heights: 2 vs 0
		//IL_04b8->IL0019: Incompatible stack heights: 3 vs 1
		//IL_010a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01d5->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0349->IL0019: Incompatible stack heights: 3 vs 1
		//IL_04e4->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ef->IL0019: Incompatible stack heights: 2 vs 1
		//IL_014e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0125->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0290->IL0015: Incompatible stack heights: 2 vs 0
		//IL_03ad->IL0019: Incompatible stack heights: 2 vs 1
		//IL_049b->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0501->IL0015: Incompatible stack heights: 2 vs 0
		//IL_033b->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0183->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01ad->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0364->IL0019: Incompatible stack heights: 2 vs 1
		//IL_041a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01c8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0301->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0115->IL0019: Incompatible stack heights: 2 vs 1
		//IL_04ef->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00fa->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0159->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0130->IL0019: Incompatible stack heights: 2 vs 1
		//IL_03b8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0264->IL0019: Incompatible stack heights: 0 vs 1
		//IL_026f->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (1 == 0)
					{
						_ = 14;
					}
					continue;
				case 18:
					goto IL_00fa;
				case 30:
					goto IL_0115;
				case 10:
					goto IL_0130;
				case 29:
					goto IL_013e;
				default:
					goto IL_0168;
				case 1:
					goto IL_0192;
				case 9:
					goto IL_01ad;
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
					goto IL_01c8;
				case 43:
					switch (P_0)
					{
					case 9u:
						break;
					case 13u:
						goto IL_00fa;
					case 26u:
						goto IL_0115;
					case 28u:
						goto IL_0130;
					case 2u:
						goto IL_013e;
					case 25u:
						goto IL_0168;
					case 12u:
						goto IL_0192;
					case 21u:
						goto IL_01ad;
					case 3u:
					case 4u:
					case 5u:
					case 6u:
					case 7u:
						goto IL_01c8;
					default:
						goto IL_0258;
					case 11u:
						goto IL_027e;
					case 19u:
						goto IL_02e6;
					case 18u:
						goto IL_0310;
					case 15u:
						goto IL_032d;
					case 20u:
						goto IL_033b;
					case 10u:
						goto IL_0349;
					case 17u:
						goto IL_0364;
					case 22u:
						goto IL_039d;
					case 8u:
						goto IL_03ff;
					case 27u:
						goto IL_041b;
					case 24u:
						goto IL_0487;
					case 16u:
						goto IL_04aa;
					case 14u:
						goto IL_04d4;
					case 23u:
						goto IL_04ef;
					}
					goto case 28;
				case 31:
					goto IL_027e;
				case 12:
					goto IL_02e6;
				case 6:
					goto IL_0310;
				case 46:
					goto IL_032d;
				case 20:
					goto IL_033b;
				case 2:
					goto IL_0349;
				case 5:
					goto IL_0364;
				case 35:
					goto IL_039d;
				case 3:
					goto IL_03ff;
				case 21:
					return;
				case 16:
					goto IL_041b;
				case 38:
					goto IL_0487;
				case 17:
					goto IL_04aa;
				case 22:
					goto IL_04d4;
				case 41:
					goto IL_04ef;
					IL_04ef:
					obj = 8;
					break;
					IL_04d4:
					if (2 == 0)
					{
						_ = 24;
					}
					continue;
					IL_0115:
					if (4 == 0)
					{
						_ = 25;
					}
					continue;
					IL_04aa:
					_ = 26;
					continue;
					IL_0487:
					obj = 44;
					break;
					IL_041b:
					obj = 45;
					break;
					IL_03ff:
					if (11 != 0)
					{
						_ = 34;
					}
					continue;
					IL_0168:
					if (39 == 0)
					{
						_ = 29;
					}
					continue;
					IL_039d:
					if (5 == 0)
					{
						_ = 7;
					}
					continue;
					IL_0364:
					_ = 13;
					continue;
					IL_0349:
					if (40 == 0)
					{
						_ = 25;
					}
					continue;
					IL_013e:
					if (23 == 0)
					{
						_ = 12;
					}
					continue;
					IL_033b:
					_ = 11;
					continue;
					IL_032d:
					_ = 37;
					continue;
					IL_0310:
					_ = 27;
					continue;
					IL_02e6:
					if (11 == 0)
					{
						_ = 33;
					}
					continue;
					IL_00fa:
					if (4 == 0)
					{
						_ = 4;
					}
					continue;
					IL_027e:
					obj = 15;
					break;
					IL_0258:
					if (42 == 0)
					{
						obj2 = 2;
					}
					continue;
					IL_0192:
					if (32 != 0)
					{
						_ = 14;
					}
					continue;
					IL_01c8:
					_ = 1;
					_ = 21;
					continue;
					IL_01ad:
					if (16 != 0)
					{
						_ = 36;
					}
					continue;
					IL_0130:
					_ = 19;
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
