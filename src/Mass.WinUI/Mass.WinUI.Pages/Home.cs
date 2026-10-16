using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Markup;
using Microsoft.Web.WebView2.Core;
using WinRT;
using WinRT.Mass_WinUIVtableClasses;

namespace Mass.WinUI.Pages;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mass_WinUI_Pages_MobileWinRTTypeDetails))]
public sealed class Home : Page, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadWebView2_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Home _003C_003E4__this;

		private TaskAwaiter<CoreWebView2Environment> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<string> _003C_003Eu__3;

		private static object CheckSegmentedConsumer;

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
		internal static bool DecorateCommonStrategy()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateAdaptableSorter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_3300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778634, new IntPtr(2737336163692L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00㐀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_05fd: Expected Obj, but got Ref
			//IL_00c7: Expected I4, but got Obj
			//IL_0279: Expected Obj, but got Ref
			//IL_020e: Expected Obj, but got Ref
			//IL_01ad: Expected Obj, but got Ref
			//IL_0413: Expected Obj, but got I4
			//IL_036a: Expected Obj, but got Ref
			//IL_02e9: Expected Obj, but got I4
			//IL_03bf: Expected Obj, but got I4
			//IL_03a2: Expected Obj, but got I4
			//IL_01d9: Expected Obj, but got I4
			//IL_01e3: Expected Obj, but got I4
			//IL_03f7: Expected Obj, but got Ref
			//IL_042d: Expected Obj, but got I4
			//IL_047f: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0617->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0049->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0607->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0622->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0081->IL0085: Incompatible stack heights: 1 vs 0
			//IL_00b3->IL0085: Incompatible stack heights: 1 vs 0
			//IL_0283->IL00e2: Incompatible stack types: I4 vs Ref
			//IL_021a->IL00e2: Incompatible stack heights: 0 vs 1
			//IL_01b7->IL00e2: Incompatible stack types: I4 vs Ref
			//IL_00d3->IL00e2: Incompatible stack heights: 0 vs 1
			//IL_0225->IL00e2: Incompatible stack types: I4 vs Ref
			//IL_00de->IL00e2: Incompatible stack types: I4 vs Ref
			//IL_0195->IL00e2: Incompatible stack heights: 2 vs 1
			//IL_041e->IL00e2: Incompatible stack heights: 3 vs 1
			//IL_0376->IL00e2: Incompatible stack heights: 0 vs 1
			//IL_01fb->IL00e2: Incompatible stack heights: 2 vs 1
			//IL_02af->IL00e2: Incompatible stack heights: 6 vs 1
			//IL_045b->IL00e2: Incompatible stack heights: 2 vs 1
			//IL_0357->IL00e2: Incompatible stack heights: 4 vs 1
			//IL_033a->IL00e2: Incompatible stack heights: 4 vs 1
			//IL_02f6->IL00e2: Incompatible stack heights: 2 vs 1
			//IL_0347->IL00e2: Incompatible stack heights: 2 vs 1
			//IL_0239->IL00e2: Incompatible stack heights: 2 vs 1
			//IL_01c5->IL00e2: Incompatible stack types: I4 vs Ref
			//IL_02c9->IL00e2: Incompatible stack types: I4 vs Ref
			//IL_03cc->IL00e2: Incompatible stack heights: 2 vs 1
			//IL_03af->IL00e2: Incompatible stack heights: 2 vs 1
			//IL_03e7->IL00e2: Incompatible stack heights: 2 vs 1
			//IL_02d9->IL00e2: Incompatible stack heights: 2 vs 1
			//IL_0403->IL00e2: Incompatible stack heights: 0 vs 1
			//IL_0365->IL00e2: Incompatible stack heights: 3 vs 1
			//IL_0432->IL00de: Incompatible stack heights: 3 vs 2
			//IL_048c->IL00e2: Incompatible stack heights: 2 vs 1
			//IL_0381->IL00e2: Incompatible stack types: I4 vs Ref
			//IL_0256->IL00e2: Incompatible stack types: I4 vs Ref
			//IL_02ba->IL00e2: Incompatible stack heights: 6 vs 1
			//IL_026a->IL00e2: Incompatible stack heights: 0 vs 1
			//IL_031b->IL00e2: Incompatible stack types: I4 vs Ref
			//IL_04b5->IL00e2: Incompatible stack types: Obj vs Ref
			//IL_0301->IL00e2: Incompatible stack heights: 2 vs 1
			//IL_044c->IL00e2: Incompatible stack types: I4 vs Ref
			//IL_0244->IL00e2: Incompatible stack heights: 2 vs 1
			//IL_03d7->IL00e2: Incompatible stack heights: 2 vs 1
			//IL_03ba->IL00e2: Incompatible stack heights: 2 vs 1
			//IL_03f2->IL00e2: Incompatible stack heights: 2 vs 1
			//IL_00e2->IL00e2: Incompatible stack heights: 3 vs 1
			//IL_04d4->IL00e2: Incompatible stack heights: 2 vs 1
			//IL_01a9->IL00e2: Incompatible stack types: I4 vs Ref
			//IL_02e4->IL00e2: Incompatible stack heights: 2 vs 1
			//IL_040e->IL00e2: Incompatible stack types: I4 vs Ref
			//IL_046f->IL00e2: Incompatible stack heights: 0 vs 1
			//IL_0497->IL00e2: Incompatible stack heights: 2 vs 1
			//IL_0275->IL00e2: Incompatible stack types: I4 vs Ref
			//IL_04c0->IL00e2: Incompatible stack types: I4 vs Ref
			//IL_04df->IL00e2: Incompatible stack heights: 2 vs 1
			//IL_047a->IL00e2: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			ref _003CLoadWebView2_003Ed__2 reference = ref *(_003CLoadWebView2_003Ed__2*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 3u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CLoadWebView2_003Ed__2*)5;
					continue;
				case 1u:
					return;
				case 2u:
					reference = ref this;
					if (1 == 0)
					{
						reference = ref *(_003CLoadWebView2_003Ed__2*)1;
					}
					continue;
				case 5u:
					_ = 2;
					if (1 == 0)
					{
						_ = 1;
					}
					while (true)
					{
						switch ((int)/*Error near IL_0096: Stack underflow*/)
						{
						case 1:
							if (2 != 0)
							{
								_ = 0;
							}
							continue;
						case 2:
						{
							ref byte reference2;
							switch ((int)obj)
							{
							default:
								if (5 != 0)
								{
									reference2 = ref *(byte*)18;
								}
								goto IL_00e2;
							case 2:
								obj = (object)Unsafe.AsPointer(ref this);
								reference2 = ref *(byte*)9;
								goto IL_00e2;
							case 1:
								goto IL_020a;
							case 0:
								goto IL_0275;
								IL_00e2:
								while (true)
								{
									switch ((uint)Unsafe.AsPointer(ref reference2))
									{
									case 7u:
										return;
									case 13u:
										return;
									case 38u:
										return;
									default:
										_ = 37;
										continue;
									case 31u:
										break;
									case 25u:
										goto end_IL_00e2;
									case 18u:
										obj = (object)/*Error near IL_01bb: Stack underflow*/;
										reference2 = ref *(byte*)36;
										continue;
									case 30u:
										obj = 0;
										obj = 27;
										continue;
									case 3u:
										obj = obj;
										_ = 8;
										continue;
									case 28u:
										goto IL_020a;
									case 17u:
										if (23 == 0)
										{
											_ = 13;
										}
										continue;
									case 4u:
										if (&obj != null)
										{
											reference2 = ref *(byte*)22;
											continue;
										}
										goto case 24u;
									case 8u:
										if (&obj == null)
										{
											if (11 == 0)
											{
												reference2 = ref *(byte*)14;
											}
											continue;
										}
										goto case 16u;
									case 29u:
										goto IL_0275;
									case 5u:
										_ = 3;
										_ = 3;
										if (3 != 0)
										{
											_ = 3;
										}
										continue;
									case 23u:
										obj = (object)/*Error near IL_02bf: Stack underflow*/;
										reference2 = ref *(byte*)4;
										continue;
									case 32u:
										if (25 == 0)
										{
											_ = 35;
										}
										continue;
									case 14u:
										obj = 1;
										if (32 == 0)
										{
											_ = 26;
										}
										continue;
									case 9u:
										reference2 = ref Unsafe.As<_003CLoadWebView2_003Ed__2, byte>(ref this);
										if (true)
										{
											reference2 = ref *(byte*)1;
										}
										continue;
									case 12u:
										_ = ref obj;
										_ = 7;
										continue;
									case 15u:
										_ = 26;
										continue;
									case 11u:
										_ = ref obj;
										_ = 38;
										continue;
									case 34u:
										_ = 12;
										continue;
									case 2u:
									case 22u:
										obj = (object)(&obj);
										if (31 != 0)
										{
											reference2 = ref *(byte*)17;
										}
										continue;
									case 26u:
										obj = -1;
										if (33 != 0)
										{
											_ = 21;
										}
										continue;
									case 24u:
										obj = 2;
										if (34 == 0)
										{
											_ = 5;
										}
										continue;
									case 27u:
										if (11 == 0)
										{
											_ = 4;
										}
										continue;
									case 21u:
									case 33u:
										obj = (object)(&obj);
										if (3 == 0)
										{
											reference2 = ref *(byte*)5;
										}
										continue;
									case 1u:
										obj = -1;
										_ = 2;
										continue;
									case 35u:
										_ = ref obj;
										obj = 13;
										continue;
									case 16u:
										reference2 = ref *(byte*)(&obj);
										if (10 != 0)
										{
											reference2 = ref *(byte*)1;
										}
										continue;
									case 6u:
										_ = 17;
										continue;
									case 36u:
										if (&obj != null)
										{
											if (21 == 0)
											{
												reference2 = ref *(byte*)12;
											}
											continue;
										}
										goto case 30u;
									case 37u:
										obj = -1;
										if (5 != 0)
										{
											_ = 16;
										}
										continue;
									case 10u:
										reference2 = ref *(byte*)(obj ?? ((object)/*Error near IL_04a6: Stack underflow*/));
										if (6 == 0)
										{
											reference2 = ref *(byte*)6;
										}
										continue;
									case 19u:
									case 20u:
										goto end_IL_00b6;
									}
									if (obj == null)
									{
										reference2 = ref *(byte*)19;
									}
									else if (20 != 0)
									{
										_ = 7;
									}
									continue;
									end_IL_00e2:
									break;
								}
								goto case 2;
								IL_0275:
								obj = (object)Unsafe.AsPointer(ref this);
								reference2 = ref *(byte*)15;
								goto IL_00e2;
								IL_020a:
								obj = (object)Unsafe.AsPointer(ref this);
								if (0 == 0)
								{
									reference2 = ref *(byte*)null;
								}
								goto IL_00e2;
								end_IL_00b6:
								break;
							}
							break;
						}
						}
						break;
					}
					break;
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CLoadWebView2_003Ed__2*)3;
					continue;
				}
				_ = -2;
				if (false)
				{
					_ = 2;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00㔀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778635, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00㘀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00㜀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00㠀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778632, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00㤀(object P_0)
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
	}

	private object? _webView2;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private object WebViewGrid;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	private nint _contentLoaded;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? loadWebView2Command;

	private static object DecorateSequentialTracer;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand LoadWebView2Command
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00_FF00_FF00_E900();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Home()
	{
		//IL_004a: Expected I4, but got Obj
		//IL_0020->IL0029: Incompatible stack types: I4 vs Obj
		//IL_0079->IL0029: Incompatible stack heights: 2 vs 1
		//IL_00b2->IL0029: Incompatible stack heights: 3 vs 1
		//IL_005f->IL0029: Incompatible stack heights: 2 vs 1
		//IL_00a2->IL0029: Incompatible stack heights: 2 vs 1
		//IL_00cc->IL0029: Incompatible stack types: I4 vs Obj
		//IL_0084->IL0029: Incompatible stack heights: 2 vs 1
		//IL_006a->IL0029: Incompatible stack heights: 2 vs 1
		//IL_0095->IL0029: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		Home home = this;
		if (2 == 0)
		{
			home = (Home)3;
		}
		while (true)
		{
			switch ((int)home)
			{
			case 2:
				_ = null;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			default:
				_ = 1;
				if (1 == 0)
				{
					_ = 1;
				}
				break;
			case 5:
				if ((int)/*Error near IL_008b: Stack underflow*/ == 0)
				{
					return;
				}
				home = (Home)4;
				break;
			case 6:
				return;
			case 3:
				_ = 2;
				break;
			case 1:
				_ = 5;
				break;
			case 4:
				home = (Home)6;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CLoadWebView2_003Ed__2))]
	private object LoadWebView2()
	{
		return _FF00_FF00_FF00_E700();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPreferredColorScheme(ElementTheme theme)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_FF00_FF00_FF00_EE00(theme);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	public void InitializeComponent()
	{
		_FF00_FF00_FF00_F100();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	public void Connect(int connectionId, object target)
	{
		_FF00_FF00_FF00_ED00((uint)connectionId, target);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateSetResolver()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Home CheckEfficientDecryptor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_E500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778629, new IntPtr(2737336192812L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_E600()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_E700()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18302, 1790778626, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778626, new IntPtr(2737336191772L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_E800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778627, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_E900()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18304, 1790778624, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778624, new IntPtr(2737336192812L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_EA00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778625, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_EB00()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_EC00(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778638, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_ED00(uint P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_007c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0042->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0087->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0061->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006c->IL0019: Incompatible stack types: I4 vs Obj
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
			case 3:
				_ = 1;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			case 2:
				if (P_0 == 2)
				{
					if (true)
					{
						obj2 = 1;
					}
					break;
				}
				goto case 3;
			case 1:
				if (3 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_EE00(ElementTheme P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0052: Expected I4, but got Obj
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Invalid comparison between Unknown and I4
		//IL_0087: Expected Obj, but got I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Invalid comparison between Unknown and I4
		//IL_00a7: Expected Obj, but got I4
		//IL_015d: Expected Obj, but got I4
		//IL_00ee: Expected Obj, but got I4
		//IL_0117->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0091->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00fa->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00c4->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0122->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00eb->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0145->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0105->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00cf->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0075->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0150->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 11;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 6:
					if ((int)P_0 != 2)
					{
						if (9 == 0)
						{
							obj2 = 2;
						}
						continue;
					}
					goto case 12;
				case 2:
					obj = 1;
					obj2 = 4;
					continue;
				case 7:
				case 9:
					obj = 0;
					obj2 = 8;
					continue;
				default:
					if ((int)P_0 != 1)
					{
						if (1 == 0)
						{
							obj2 = 6;
						}
						continue;
					}
					goto case 2;
				case 4:
				case 5:
				case 8:
					if (3 == 0)
					{
						_ = 3;
					}
					continue;
				case 12:
					obj = 2;
					if (2 == 0)
					{
						obj2 = 5;
					}
					continue;
				case 1:
					obj = obj;
					if (false)
					{
						obj2 = 0;
					}
					continue;
				case 3:
					return;
				case 10:
					if (obj == null)
					{
						return;
					}
					if (1 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 11:
					break;
				}
				break;
			}
			obj = this;
			obj = 10;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_F000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778639, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_F100()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0075->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0059->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0092->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0080->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0064->IL0019: Incompatible stack heights: 2 vs 1
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
				obj = (object)/*Error near IL_003f: Stack underflow*/;
				obj2 = 4;
				break;
			case 5:
				return;
			case 2:
				_ = 1;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 4:
				_ = 0;
				if (true)
				{
					_ = 1;
				}
				break;
			case 1:
				return;
			case 3:
				if (this != null)
				{
					return;
				}
				obj2 = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_F500(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778636, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_F600(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0056: Expected I4, but got Obj
		//IL_00fa: Expected Obj, but got I4
		//IL_012e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0098->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c7->IL0019: Incompatible stack heights: 0 vs 1
		//IL_015b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_007a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00d2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0166->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ac->IL0019: Incompatible stack heights: 0 vs 1
		//IL_010e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0141->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0120->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0085->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_014c->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 10;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 5:
					return;
				case 12:
					obj = (object)/*Error near IL_006e: Stack underflow*/;
					if (2 != 0)
					{
						obj2 = 1;
					}
					continue;
				case 1:
				case 2:
				case 4:
					_ = 5;
					continue;
				case 8:
					if ((nint)obj != 1)
					{
						if (11 != 0)
						{
							obj2 = 6;
						}
						continue;
					}
					break;
				case 6:
					obj = this;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 3:
				case 13:
					goto end_IL_0019;
				case 9:
					return;
				case 11:
					if ((nint)obj != 2)
					{
						obj2 = 13;
						continue;
					}
					goto case 12;
				default:
					obj = P_1;
					obj2 = 8;
					continue;
				case 10:
					if (this != null)
					{
						_ = 6;
					}
					else if (9 == 0)
					{
						obj2 = 7;
					}
					continue;
				case 7:
					break;
				}
				obj = (object)/*Error near IL_014f: Stack underflow*/;
				if (1 == 0)
				{
					obj2 = 0;
				}
				continue;
				end_IL_0019:
				break;
			}
			obj = (object)/*Error near IL_00f1: Stack underflow*/;
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_F700(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778637, new IntPtr(2737336163692L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
