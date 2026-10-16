using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mass.WinUI.Models;
using Microsoft.UI.Xaml.Controls;
using WinRT;
using WinRT.Mass_WinUIVtableClasses;

namespace Mass.WinUI.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails))]
public class ChatViewModel : ObservableObject
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSend_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ChatViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object DecorateResponsiveResolver;

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
		internal static bool DecorateSortedDecryptor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateCombinedError()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00㼀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777689, new IntPtr(2737335740316L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00䀀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0059: Expected Obj, but got Ref
			//IL_0074: Expected Obj, but got Ref
			//IL_007d: Expected Obj, but got I4
			//IL_019b: Expected Obj, but got Ref
			//IL_0160: Expected Obj, but got I4
			//IL_01ed: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0065->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0093->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0055->IL0019: Incompatible stack types: I4 vs Ref
			//IL_00b2->IL00c1: Incompatible stack heights: 0 vs 1
			//IL_0070->IL0019: Incompatible stack types: I4 vs Ref
			//IL_009e->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0314->IL00c1: Incompatible stack heights: 2 vs 1
			//IL_02de->IL00c1: Incompatible stack heights: 2 vs 1
			//IL_02fa->IL00c1: Incompatible stack heights: 0 vs 1
			//IL_0328->IL00c1: Incompatible stack heights: 0 vs 1
			//IL_0121->IL0125: Incompatible stack heights: 1 vs 0
			//IL_01b2->IL0125: Incompatible stack heights: 1 vs 0
			//IL_016d->IL0125: Incompatible stack heights: 2 vs 0
			//IL_01f8->IL0125: Incompatible stack heights: 3 vs 0
			//IL_0236->IL0125: Incompatible stack heights: 1 vs 0
			//IL_0189->IL0125: Incompatible stack heights: 1 vs 0
			//IL_0227->IL0125: Incompatible stack heights: 4 vs 0
			//IL_0197->IL0125: Incompatible stack heights: 3 vs 0
			//IL_01dd->IL0125: Incompatible stack heights: 1 vs 0
			//IL_0178->IL0125: Incompatible stack heights: 2 vs 0
			//IL_0241->IL0125: Incompatible stack heights: 1 vs 0
			//IL_01e8->IL0125: Incompatible stack heights: 1 vs 0
			//IL_0217->IL0125: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			while (true)
			{
				ref _003CSend_003Ed__9 reference = ref *(_003CSend_003Ed__9*)obj;
				while (true)
				{
					int num;
					switch ((uint)Unsafe.AsPointer(ref reference))
					{
					default:
						reference = ref this;
						if (4 == 0)
						{
							reference = ref *(_003CSend_003Ed__9*)4;
						}
						continue;
					case 2u:
						obj = (object)Unsafe.AsPointer(ref this);
						if (1 == 0)
						{
							reference = ref *(_003CSend_003Ed__9*)1;
						}
						continue;
					case 3u:
						goto end_IL_0019;
					case 4u:
						return;
					case 5u:
						break;
					case 1u:
						{
							if (obj == null)
							{
								if (1 == 0)
								{
									num = 8;
								}
								goto IL_00c1;
							}
							goto IL_02de;
						}
						IL_02de:
						obj = obj;
						num = 6;
						goto IL_00c1;
						IL_00c1:
						while (true)
						{
							switch (num)
							{
							case 2:
							case 4:
								break;
							case 9:
								if (obj != null)
								{
									_ = 4;
									goto IL_0125;
								}
								goto IL_0197;
							case 1:
								goto IL_02d0;
							case 7:
								goto end_IL_00c1;
							case 3:
							case 5:
							case 8:
								if (9 == 0)
								{
									num = 9;
								}
								continue;
							default:
								_ = null;
								_ = 2;
								continue;
							case 6:
								{
									if (obj == null)
									{
										if (0 == 0)
										{
											num = 3;
										}
										continue;
									}
									goto default;
								}
								IL_0125:
								while (true)
								{
									switch ((int)/*Error near IL_0156: Stack underflow*/)
									{
									case 10:
										return;
									default:
										obj = 0;
										if (8 == 0)
										{
											_ = 1;
										}
										continue;
									case 4:
										obj = obj;
										_ = 2;
										continue;
									case 8:
										_ = 7;
										continue;
									case 6:
										break;
									case 9:
										if (true)
										{
											_ = 1;
										}
										continue;
									case 1:
										obj = -1;
										_ = 3;
										continue;
									case 2:
										if (&obj == null)
										{
											if (0 == 0)
											{
												_ = 0;
											}
											continue;
										}
										goto case 3;
									case 7:
										_ = ref obj;
										_ = 10;
										continue;
									case 3:
										_ = ref obj;
										if (5 == 0)
										{
											_ = 2;
										}
										continue;
									case 5:
										goto IL_02d0;
									}
									break;
								}
								goto IL_0197;
								IL_0197:
								obj = (object)Unsafe.AsPointer(ref this);
								if (8 != 0)
								{
									_ = 9;
								}
								goto IL_0125;
								IL_02d0:
								_ = 4;
								continue;
							}
							goto end_IL_0019_2;
							continue;
							end_IL_00c1:
							break;
						}
						goto IL_02de;
						end_IL_0019_2:
						break;
					}
					_ = -2;
					if (false)
					{
						_ = 0;
					}
					continue;
					end_IL_0019:
					break;
				}
				obj = (object)Unsafe.AsPointer(ref this);
				obj = 2;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00䄀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778022, new IntPtr(2737335740316L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00䈀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00䌀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778023, new IntPtr(2737335740316L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00䐀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778020, new IntPtr(2737335740316L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00䔀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00䘀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778021, new IntPtr(2737335740316L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00䜀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00䠀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778018, new IntPtr(2737335708076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	private object? _scroller;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private RelayCommand<ScrollView>? scrollViewerLoadedCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? sendCommand;

	private static object CheckCustomPolicy;

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public string InputText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)섀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			씀(value);
		}
	}

	public ObservableCollection<ChatModel> ChatModels
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 숀();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand<ScrollView> ScrollViewerLoadedCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 촀();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand SendCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)저();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ChatViewModel()
	{
		//IL_003e: Expected I4, but got Obj
		//IL_0028->IL0031: Incompatible stack types: I4 vs Obj
		//IL_0055->IL0031: Incompatible stack heights: 3 vs 2
		//IL_0060->IL0031: Incompatible stack heights: 3 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		ChatViewModel chatViewModel = this;
		if (0 == 0)
		{
			chatViewModel = (ChatViewModel)1;
		}
		while (true)
		{
			switch ((int)chatViewModel)
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
	[RelayCommand]
	private void ScrollViewerLoaded(object e)
	{
		케(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSend_003Ed__9))]
	[RelayCommand]
	private object Send()
	{
		return 쬀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ScrollToEnd()
	{
		밀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EncodeEditor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ChatViewModel ExcludeSystem()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 똀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777675, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void 뜀(object P_0, object P_1)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 렀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777672, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte 뤀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte 먀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777673, new IntPtr(2737335738236L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 묀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777686, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void 밀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_006b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0044->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0076->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004f->IL0019: Incompatible stack types: I4 vs Obj
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
				if (this == null)
				{
					if (false)
					{
						obj2 = 1;
					}
					break;
				}
				_ = 0.0;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			case 1:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 봀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777687, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object 븀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777684, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 뼀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 쀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777685, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object 섀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ObservableCollection<ChatModel> 숀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<ChatModel>)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<ChatModel> 쌀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777682, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<ChatModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 쐀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777683, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 씀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_009b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b0->IL003b: Incompatible stack heights: 1 vs 0
		//IL_00a6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0055->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c7->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				obj2 = this;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 1:
				return;
			case 5:
				return;
			case 4:
				obj2 = this;
				if (5 != 0)
				{
					obj2 = 0;
				}
				break;
			default:
				if (4 == 0)
				{
					_ = 4;
				}
				break;
			case 2:
				obj2 = this;
				if (P_0 != null)
				{
					if (0 == 0)
					{
						obj2 = 1;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 였(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777680, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 윀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777681, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 저()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17506, 1790777694, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777694, new IntPtr(2737335737196L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 준()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777695, new IntPtr(2737335738236L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object 쨀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777692, new IntPtr(2737335738236L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object 쬀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17509, 1790777693, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777693, new IntPtr(2737335738236L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IRelayCommand<ScrollView> 찀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777690, new IntPtr(2737335739276L), 15))(null, 0, new IntPtr(0L));
		return (IRelayCommand<ScrollView>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IRelayCommand<ScrollView> 촀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17511, 1790777691, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777691, new IntPtr(2737335739276L), 15);
		}
		return (IRelayCommand<ScrollView>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IRelayCommand<ScrollView> 츀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777688, new IntPtr(2737335740316L), 15))(null, 0, new IntPtr(0L));
		return (IRelayCommand<ScrollView>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void 케(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0057->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0048->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0062->IL0019: Incompatible stack heights: 2 vs 1
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
				if (0 == 0)
				{
					_ = 0;
				}
				continue;
			case 2:
				return;
			}
			obj2 = this;
			if (1 == 0)
			{
				obj2 = 2;
			}
		}
	}
}
