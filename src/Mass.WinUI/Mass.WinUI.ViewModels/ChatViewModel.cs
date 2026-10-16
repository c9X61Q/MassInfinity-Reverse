using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using ABI.System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using Mass.WinUI.Models;
using Microsoft.UI.Xaml.Controls;
using WinRT;
using WinRT.Mass_WinUIGenericHelpers;
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
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_004e: Expected Obj, but got Ref
			//IL_0062: Expected Obj, but got I
			//IL_0078: Expected Obj, but got Ref
			//IL_007a: Expected Obj, but got I
			//IL_009f: Expected Obj, but got Ref
			//IL_00aa: Expected Obj, but got I4
			//IL_00b8: Expected Obj, but got Ref
			//IL_03d9: Expected Obj, but got I4
			//IL_040d: Expected I, but got Obj
			//IL_040d: Expected I4, but got Obj
			//IL_0418: Expected I, but got Obj
			//IL_0202: Expected Obj, but got Ref
			//IL_01a9: Expected Obj, but got I4
			//IL_01ae: Expected Obj, but got I4
			//IL_01ae: Expected Obj, but got Ref
			//IL_01bd: Expected Obj, but got I
			//IL_0277: Expected Obj, but got I4
			//IL_027c: Expected Obj, but got I4
			//IL_027c: Expected Obj, but got Ref
			//IL_01d2: Expected I, but got Obj
			//IL_01d9: Expected I, but got Obj
			//IL_01e0: Expected Obj, but got I
			//IL_02b7: Expected Obj, but got Ref
			//IL_01f2: Expected Obj, but got Ref
			//IL_024d: Expected Obj, but got Ref
			//IL_024d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067->IL0026: Incompatible stack heights: 2 vs 1
			//IL_008e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00cc->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0072->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00f3->IL0102: Incompatible stack heights: 1 vs 2
			//IL_0099->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00d7->IL0026: Incompatible stack types: I4 vs Obj
			//IL_012f->IL03d0: Incompatible stack heights: 1 vs 0
			//IL_00fe->IL0102: Incompatible stack heights: 1 vs 2
			//IL_0422->IL0102: Incompatible stack types: I4 vs Obj
			//IL_03d0->IL0102: Incompatible stack heights: 3 vs 2
			//IL_0292->IL02c9: Incompatible stack heights: 0 vs 1
			//IL_02e4->IL016e: Incompatible stack heights: 3 vs 2
			//IL_01ea->IL016e: Incompatible stack types: I4 vs Obj
			//IL_02f4->IL03be: Incompatible stack heights: 0 vs 1
			//IL_02c9->IL016e: Incompatible stack heights: 3 vs 2
			//IL_02a6->IL016e: Incompatible stack heights: 1 vs 2
			//IL_02ef->IL016e: Incompatible stack heights: 3 vs 2
			//IL_02b1->IL016e: Incompatible stack heights: 1 vs 2
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
					object obj3;
					int num;
					switch ((int)obj2)
					{
					default:
						IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)/*Error near IL_0053: Stack underflow*/, ref Unsafe.As<nint, object[]>(ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized));
						_ = 4;
						if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
						{
							_ = 4;
						}
						continue;
					case 2:
						obj = IList_object._initialized;
						obj2 = 1;
						if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
						{
							obj2 = 1;
						}
						continue;
					case 3:
						goto end_IL_0026;
					case 4:
						return;
					case 5:
						break;
					case 1:
						{
							if (obj == null)
							{
								_ = 1;
								if (IEnumerator_System_IDisposable._initialized == 0)
								{
									_ = 8;
								}
								goto IL_0102;
							}
							goto IL_03d0;
						}
						IL_03d0:
						obj3 = obj;
						obj = IReadOnlyList_System_IDisposable.StoreAttribute();
						num = 6;
						goto IL_0102;
						IL_0102:
						while (true)
						{
							int num2;
							switch (num)
							{
							case 2:
							case 4:
								break;
							case 9:
								if (obj != null)
								{
									num2 = 4;
									goto IL_016e;
								}
								goto IL_01fc;
							case 1:
								goto IL_03be;
							case 7:
								goto end_IL_0102;
							case 3:
							case 5:
							case 8:
								num = 9;
								if (__KnownINotifyPropertyChangingArgs.Summary == null)
								{
									num = 9;
								}
								continue;
							default:
							{
								uint num3 = IReadOnlyList_object.Do_Abi_GetMany_3((nint)/*Error near IL_0418: Stack underflow*/, (uint)/*Error near IL_0418: Stack underflow*/, (uint)/*Error near IL_0418: Stack underflow*/, (nint)(int)IReadOnlyList_object.Do_Abi_IndexOf_2((nint)/*Error near IL_0412: Stack underflow*/, (nint)/*Error near IL_0412: Stack underflow*/, (uint*)/*Error near IL_0412: Stack underflow*/, (byte*)(int)IReadOnlyList_object.Do_Abi_GetAt_0((nint)/*Error near IL_040d: Stack underflow*/, (uint)(int)obj3, (nint*)(nint)__KnownINotifyPropertyChangingArgs.PreviewImage)), (uint*)unchecked((nint)null));
								num = 2;
								obj3 = num3;
								continue;
							}
							case 6:
								{
									if (MarshalInterface<IEnumerator<object>>.FromManaged((IEnumerator<object>)obj) == (IntPtr)0)
									{
										num = 0;
										if (__KnownINotifyPropertyChangingArgs.StateText == null)
										{
											num = 3;
										}
										continue;
									}
									goto default;
								}
								IL_016e:
								while (true)
								{
									switch (num2)
									{
									case 10:
										return;
									default:
										obj = 0;
										IEnumerable_System_IDisposable.CombineAttribute = 0;
										num2 = 8;
										if (IEnumerable_object.ReflectSetAttribute == null)
										{
											num2 = 1;
										}
										continue;
									case 4:
									{
										bool flag = IEnumerableMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)obj3);
										obj = (nint)MarshalInterface<IEnumerator<INotifyPropertyChanged>>.FromManaged(IEnumerableMethods<INotifyPropertyChanged>.Abi_First_0((IntPtr)obj));
										num2 = 2;
										obj3 = flag;
										continue;
									}
									case 8:
										Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute = obj;
										num2 = 7;
										continue;
									case 6:
										break;
									case 9:
										Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute = (object)default(IReadOnlyListMethods<, >);
										num2 = 1;
										if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute != null)
										{
											num2 = 1;
										}
										continue;
									case 1:
										obj = -1;
										_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.Instance = (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0)(-1);
										num2 = 3;
										continue;
									case 2:
										IListMethods<object>.Abi_Clear_9((IntPtr)(nint)(&obj));
										if (obj3 == null)
										{
											_ = 0;
											if ((int)_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout == 0)
											{
												_ = 0;
											}
											continue;
										}
										goto case 3;
									case 7:
										_ = ref _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_hasTimeout;
										((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CSend_003Ed__9, AccountViewModel._003CLoginMobile_003Ed__88>(ref this));
										_ = 10;
										continue;
									case 3:
										IEnumeratorMethods<INotifyPropertyChanged>.Abi_MoveNext_2((IntPtr)(nint)(&obj));
										_ = 5;
										if (__KnownINotifyPropertyChangingArgs.Username == null)
										{
											_ = 2;
										}
										continue;
									case 5:
										goto IL_03be;
									}
									break;
								}
								goto IL_01fc;
								IL_01fc:
								obj = Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute;
								num2 = 8;
								if (Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute != null)
								{
									num2 = 9;
								}
								goto IL_016e;
								IL_03be:
								IReadOnlyList_System_IDisposable._002Ecctor();
								_ = 4;
								continue;
							}
							goto end_IL_0026_2;
							continue;
							end_IL_0102:
							break;
						}
						goto IL_03d0;
						end_IL_0026_2:
						break;
					}
					IReadOnlyList_System_IDisposable._initialized = -2;
					obj2 = 0;
					if (IReadOnlyList_object._initialized != 0)
					{
						obj2 = 0;
					}
					continue;
					end_IL_0026:
					break;
				}
				obj = IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute;
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00䈀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00䔀()
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00䘀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778021, new IntPtr(2737335740316L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00䜀(object P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0053: Expected Obj, but got I
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
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
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)(nint)Unsafe.AsPointer(ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized), ref *(object[]*)P_0);
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
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
	public unsafe ChatViewModel()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = this;
		/*Error near IL_0021: Member reference must be method, but was: Field*/;
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
	private unsafe void 뜀(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		_003CModule_003E.CheckAccessibleAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 렀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777672, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte 뤀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
	private unsafe void 밀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_007e: Expected I, but got Obj
		//IL_007e: Expected I4, but got F8
		//IL_0093: Expected Obj, but got I
		//IL_0098->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
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
			case 2:
			{
				nint initialized = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
				if (initialized == 0)
				{
					obj2 = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj2 = 1;
					}
					break;
				}
				((ValueTuple<int, nint>*)initialized)->_002Ector(0, (nint)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute);
				MarshalInspectable<object>.FromAbiArray((object)/*Error near IL_0083: Stack underflow*/);
				obj2 = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
				{
					obj2 = 0;
				}
				break;
			}
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
	internal unsafe static object 뼀()
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
	internal unsafe object 쀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777685, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 섀()
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
	internal unsafe ObservableCollection<ChatModel> 숀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001a: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<ChatModel>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
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
	internal unsafe void 씀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00c8: Expected I, but got Obj
		//IL_0053: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I
		//IL_010c: Expected Obj, but got I
		//IL_00dc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0067->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00b6->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00e7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0111->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00c1->IL0026: Incompatible stack heights: 2 vs 1
		//IL_011c->IL0026: Incompatible stack types: I4 vs Obj
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
			case 3:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 0;
				}
				break;
			case 1:
				return;
			case 5:
				return;
			case 4:
				MarshalInspectable<object>.FromManaged((object)this, (byte)IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0);
				_ = 5;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute != null)
				{
					_ = 0;
				}
				break;
			default:
				IReadOnlyList_object._initialized = (nint)P_0;
				obj2 = 4;
				if (IEnumerator_System_IDisposable._initialized == 0)
				{
					obj2 = 4;
				}
				break;
			case 2:
				if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)(IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00ec: Stack underflow*/, (INotifyPropertyChanged)/*Error near IL_00ec: Stack underflow*/, ref *(uint*)/*Error near IL_00ec: Stack underflow*/) ? 1 : 0), (uint)IEnumerable_System_IDisposable._initialized, ref *(INotifyPropertyChanged[]*)P_0) != 0)
				{
					obj2 = 0;
					if (IEnumerable_object.ReflectSetAttribute == null)
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
	private unsafe void 케(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_0056->IL0026: Incompatible stack heights: 3 vs 1
		//IL_007c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0061->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0087->IL0026: Incompatible stack types: I4 vs Obj
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
				_003CModule_003E.CheckAccessibleAttribute();
				_ = 1;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					_ = 2;
				}
				break;
			case 1:
				IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute = P_0;
				obj2 = 0;
				if (IList_object.PatchAttribute == null)
				{
					obj2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}
}
