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
using System.Threading.Tasks;
using ABI.System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using Mass.WinUI.Mass_WinUI_XamlTypeInfo;
using Mass.WinUI.Models;
using Microsoft.UI.Xaml.Controls;
using WinRT;
using WinRT.Mass_WinUIGenericHelpers;
using WinRT.Mass_WinUIVtableClasses;

namespace Mass.WinUI.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails))]
public class InstanceViewModel : ObservableObject
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COperation_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public GameInstanceModel instance;

		private TaskAwaiter _003C_003Eu__1;

		internal static object DecorateExtendedDic;

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
		internal static bool CheckVisibleObject()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckCentralDecorator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00帀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778130, new IntPtr(2737335815772L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00开()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_003f: Expected I4, but got Obj
			//IL_02bd: Expected Obj, but got Ref
			//IL_0298: Expected VT, but got I4
			//IL_0298: Expected Obj, but got Ref
			//IL_02a8: Expected Obj, but got Ref
			//IL_01cd: Expected Obj, but got Ref
			//IL_005c: Expected Obj, but got I
			//IL_00b0: Expected Obj, but got Ref
			//IL_018b: Expected Obj, but got I4
			//IL_0190: Expected Obj, but got I4
			//IL_0190: Expected Obj, but got Ref
			//IL_0156: Expected Obj, but got Ref
			//IL_0165: Expected Obj, but got I
			//IL_011b: Expected Obj, but got I4
			//IL_0120: Expected Obj, but got Ref
			//IL_01b5: Expected Obj, but got Ref
			//IL_00db: Expected Obj, but got Ref
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Expected Obj, but got I
			//IL_02d3->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02a2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02b7->IL0026: Incompatible stack heights: 2 vs 1
			//IL_02de->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01c7->IL0070: Incompatible stack heights: 2 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				case 3:
					return;
				default:
					if (obj != null)
					{
						num = 1;
						if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute == null)
						{
							num = 1;
						}
						goto IL_0070;
					}
					goto IL_01c7;
				case 2:
					goto IL_0290;
				case 4:
					IEnumeratorMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, nint*, int>)/*Error near IL_02ad: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)/*Error near IL_02ad: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)/*Error near IL_02ad: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, uint*, int>)Unsafe.AsPointer(ref _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_hasTimeout));
					_ = 3;
					break;
				case 1:
					{
						obj = __KnownINotifyPropertyChangingArgs.Notes;
						obj2 = 0;
						if (__KnownINotifyPropertyChangingArgs.Username == null)
						{
							obj2 = 0;
						}
						break;
					}
					IL_01c7:
					obj = Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute;
					num = 3;
					if (Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute == null)
					{
						num = 9;
					}
					goto IL_0070;
					IL_0290:
					_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout = (TimeSpan)(-2);
					obj2 = 4;
					break;
					IL_0070:
					while (true)
					{
						switch (num)
						{
						case 10:
							return;
						case 1:
							((ValueTuple<int, nint>*)/*Error near IL_00ba: Stack underflow*/)->_002Ector((int)/*Error near IL_00ba: Stack underflow*/, (nint)(int)IEnumerator_object.Do_Abi_MoveNext_2((nint)/*Error near IL_00b5: Stack underflow*/, (byte*)IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized));
							obj = (object)/*Error near IL_00bc: Stack underflow*/;
							num = 3;
							continue;
						case 9:
							IList_object.PatchAttribute = (object)default(ObservableObject);
							num = 2;
							continue;
						case 3:
							if (MarshalInspectable<object>.FromManaged((object)/*Error near IL_00f2: Stack underflow*/, (byte)(&obj) != 0) != (IntPtr)0)
							{
								num = 0;
								if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
								{
									num = 0;
								}
								continue;
							}
							goto case 6;
						case 6:
							obj = 0;
							IReadOnlyList_object._initialized = 0;
							num = 5;
							if (IEnumerator_System_IDisposable._initialized == 0)
							{
								num = 5;
							}
							continue;
						case 5:
							IEnumerator_System_IDisposable.ReflectTransferableAttribute = obj;
							num = 0;
							if (IEnumerable_System_IDisposable.CombineAttribute != null)
							{
								num = 8;
							}
							continue;
						default:
							MarshalInterface<INotifyPropertyChanged>.CopyManagedArray((INotifyPropertyChanged[])/*Error near IL_017c: Stack underflow*/, (IntPtr)(nint)(&obj));
							num = 11;
							continue;
						case 2:
							obj = -1;
							IEnumerable_object.ReflectSetAttribute = -1;
							num = 4;
							if (Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute == null)
							{
								num = 4;
							}
							continue;
						case 8:
							_ = ref Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute;
							((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003COperation_003Ed__11, AccountViewModel._003CCreateAccount_003Ed__21>(ref this));
							_ = 10;
							continue;
						case 7:
							break;
						case 11:
							goto IL_0290;
						}
						break;
					}
					goto IL_01c7;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00怀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778131, new IntPtr(2737335815772L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00愀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00戀()
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00挀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778128, new IntPtr(2737335803292L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00搀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00攀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778129, new IntPtr(2737335815772L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	private List<GameInstanceModel> _allInstances;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<GameInstanceModel>? operationCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private RelayCommand<GameInstanceModel>? closeInstanceCommand;

	internal static InstanceViewModel ReflectActiveCommand;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int SelectedCategoryIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_FF00_2800();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_1B00((uint)value);
		}
	}

	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public ObservableCollection<GameInstanceModel> Instances
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_2F00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_2A00(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand<GameInstanceModel> OperationCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_3100();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IRelayCommand<GameInstanceModel> CloseInstanceCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_2200();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe InstanceViewModel()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = new ExceptionHelpers((Exception)(object)this);
		/*Error near IL_0025: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RefreshCollection()
	{
		_FF00_FF00_2100();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyFilter()
	{
		_FF00_FF00_2400();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COperation_003Ed__11))]
	[RelayCommand]
	public Task Operation(GameInstanceModel instance)
	{
		return (Task)_FF00_FF00_2E00(instance);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	public void CloseInstance(GameInstanceModel instance)
	{
		_FF00_FF00_2B00(instance);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnSelectedCategoryIndexChanged(uint value)
	{
		_FF00_FF00Ḁ(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ControlCache()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static InstanceViewModel CalcUser()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00ᨀ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778115, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_1B00(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_0068: Expected Obj, but got I4
		//IL_008c: Expected Obj, but got I
		//IL_005c: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I4
		//IL_0072->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0091->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ec->IL00ac: Incompatible stack heights: 2 vs 0
		//IL_0061->IL0022: Incompatible stack heights: 3 vs 0
		//IL_00cb->IL0026: Incompatible stack heights: 2 vs 1
		//IL_009c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00fa->IL0022: Incompatible stack heights: 2 vs 0
		//IL_00d6->IL0026: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 5:
					_003CModule_003E.CheckAccessibleAttribute();
					obj = 2;
					break;
				default:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = P_0;
					obj2 = 5;
					continue;
				case 2:
					/*Error near IL_007d: Stack underflow*/((object[])(object)this, IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized);
					obj2 = 1;
					if (IList_object.PatchAttribute == null)
					{
						obj2 = 1;
					}
					continue;
				case 3:
					return;
				case 1:
					return;
				case 6:
					MarshalInspectable<object>.FromManaged((object)this, (byte)IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0);
					_ = 0;
					if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
					{
						_ = 0;
					}
					continue;
				case 4:
					IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)/*Error near IL_00db: Stack underflow*/, (uint)/*Error near IL_00db: Stack underflow*/);
					_ = IReadOnlyList_object.ReflectLogicalAttribute;
					if (MarshalInterface<INotifyPropertyChanged>.FromAbi((IntPtr)(int)P_0) != null)
					{
						obj = 3;
						break;
					}
					goto case 6;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00ᰀ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778112, new IntPtr(2737335803292L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00ᴀ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778113, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00Ḁ(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		_003CModule_003E.CheckAccessibleAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00ἀ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778126, new IntPtr(2737335803292L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_2000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778127, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_2100()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0068: Expected I, but got Obj
		//IL_008f: Expected I, but got Obj
		//IL_00b5: Expected I, but got Obj
		//IL_00bb: Expected I, but got Obj
		//IL_0057->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0062->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0078->IL008f: Incompatible stack types: I vs Obj
		//IL_00a4->IL00bb: Incompatible stack heights: 2 vs 1
		//IL_00de->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e9->IL0026: Incompatible stack types: I4 vs Obj
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
			case 2:
				return;
			default:
				_003CModule_003E.CheckAccessibleAttribute();
				_ = 2;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					_ = 0;
				}
				break;
			case 1:
			{
				/*Error near IL_0068: Stack underflow*/((object[])/*Error near IL_0068: Stack underflow*/, (nint)this);
				nint initialized = IList_object._initialized;
				MarshalInspectable<object> val;
				if (initialized != 0)
				{
					val = (MarshalInspectable<object>)(object)initialized;
				}
				else
				{
					val = (MarshalInspectable<object>)(nint)new MarshalInspectable<object>(IList_object.PatchAttribute, (byte)(delegate* unmanaged[Stdcall]<nint, byte*, uint>)(&IEnumerator_object.Do_Abi_get_HasCurrent_1) != 0);
					IReadOnlyList_System_IDisposable._initialized = (nint)val;
				}
				Grid val2 = CastExtensions.As<Grid>((object)val);
				IReadOnlyListMethods<INotifyPropertyChanged> val3;
				if (IReadOnlyList_object._initialized == 0)
				{
					val3 = (IReadOnlyListMethods<INotifyPropertyChanged>)new IReadOnlyListMethods<INotifyPropertyChanged>((IntPtr)val2, (INotifyPropertyChanged)IReadOnlyList_object.ReflectLogicalAttribute, ref *(uint*)(delegate* unmanaged[Stdcall]<nint, uint, nint*, uint>)(&IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0));
					IEnumerable_System_IDisposable._initialized = (nint)val3;
				}
				IEnumerable_object.ReflectSetAttribute = ((XamlUserType)/*Error near IL_00c5: Stack underflow*/).BoxType<double>(((XamlUserType)/*Error near IL_00c0: Stack underflow*/).BoxType<DateTime>((object)val3));
				obj2 = 0;
				if (Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute != null)
				{
					obj2 = 0;
				}
				break;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IRelayCommand<GameInstanceModel> _FF00_FF00_2200()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17850, 1790778124, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778124, new IntPtr(2737335806412L), 15);
		}
		return (IRelayCommand<GameInstanceModel>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_2300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778125, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_2400()
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.ArgumentNullException: Value cannot be null. (Parameter 'source')
		//    at System.Linq.ThrowHelper.ThrowArgumentNullException(ExceptionArgument argument)
		//    at System.Linq.Enumerable.Skip[TSource](IEnumerable`1 source, Int32 count)
		//    at ICSharpCode.Decompiler.CSharp.ArgumentList.GetArgumentResolveResultsDirect(Int32 skipCount) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 124
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Probe() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 493
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Run() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 438
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.ForMethodReference(ExpressionBuilder expressionBuilder, IMethod method, IType targetType, TranslatedExpression target, Boolean requireTarget, ExpectedTargetDetails expectedTargetDetails, Boolean isExtensionMethodReference, Boolean castTargetUpFront) in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 131
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.DisambiguateDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1718
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1648
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildMethodReference(IMethod method, Boolean isVirtual) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1639
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitLdFtn(LdFtn inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 5058
		//    at ICSharpCode.Decompiler.IL.LdFtn.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 3175
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitConv(Conv inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2307
		//    at ICSharpCode.Decompiler.IL.Conv.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2298
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildArgumentList(ExpectedTargetDetails expectedTargetDetails, ResolveResult target, IMethod method, Int32 firstParamIndex, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, Boolean writtenAsAssignment) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1070
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(OpCode callOpCode, IMethod method, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, IType constrainedTo) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 461
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(CallInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 255
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitNewObj(NewObj inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 538
		//    at ICSharpCode.Decompiler.IL.NewObj.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4578
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitStObj(StObj inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 3219
		//    at ICSharpCode.Decompiler.IL.StObj.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4386
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitStLoc(StLoc inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 855
		//    at ICSharpCode.Decompiler.IL.StLoc.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2590
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitStLoc(StLoc inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 129
		//    at ICSharpCode.Decompiler.IL.StLoc.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2586
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
		//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitIfInstruction(IfInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 162
		//    at ICSharpCode.Decompiler.IL.IfInstruction.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 1440
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.TranslateSwitch(BlockContainer switchContainer, SwitchInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 307
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1334
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertLoop(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1354
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1325
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1338
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertAsBlock(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 87
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2435
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_2500()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_2600()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778122, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_2700()
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
	internal unsafe uint _FF00_FF00_2800()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_2900()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778123, new IntPtr(2737335818892L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_2A00(ObservableCollection<GameInstanceModel> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0053: Expected I, but got Obj
		//IL_009e: Expected I, but got Obj
		//IL_0064: Expected I, but got Obj
		//IL_00e2: Expected Obj, but got I
		//IL_005d->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00d3->IL0048: Incompatible stack heights: 2 vs 0
		//IL_00b2->IL0026: Incompatible stack heights: 3 vs 1
		//IL_006e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e7->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00bd->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00f2->IL0026: Incompatible stack heights: 3 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 5;
				break;
			case 5:
				IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
				obj2 = 4;
				break;
			case 1:
				return;
			case 2:
				return;
			case 4:
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)IList_object.PatchAttribute);
				_ = 1;
				if (IReadOnlyList_System_IDisposable._initialized == 0)
				{
					_ = 0;
				}
				break;
			case 3:
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00c2: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00c2: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_00c2: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)/*Error near IL_00c2: Stack underflow*/);
				_ = IReadOnlyList_object._initialized;
				if (MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)P_0) != (IntPtr)0)
				{
					_ = 1;
					if (IEnumerator_System_IDisposable.ReflectTransferableAttribute != null)
					{
						_ = 2;
					}
					break;
				}
				goto default;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_2B00(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0068: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0083->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0056->IL0026: Incompatible stack heights: 3 vs 1
		//IL_008e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0061->IL0026: Incompatible stack heights: 3 vs 1
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
			case 1:
				_003CModule_003E.CheckAccessibleAttribute();
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					_ = 0;
				}
				break;
			case 2:
				return;
			default:
				((ValueTuple<int, nint>*)/*Error near IL_006e: Stack underflow*/)->_002Ector((int)IEnumerator_object.Do_Abi_MoveNext_2((nint)/*Error near IL_0068: Stack underflow*/, (byte*)(nint)this), (nint)P_0);
				obj2 = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00Ⰰ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778120, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00ⴀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778121, new IntPtr(2737335818892L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_2E00(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17862, 1790778134, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778134, new IntPtr(2737335814732L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<GameInstanceModel> _FF00_FF00_2F00()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<GameInstanceModel>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<GameInstanceModel> _FF00_FF00_3000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778135, new IntPtr(2737335815772L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<GameInstanceModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<GameInstanceModel> _FF00_FF00_3100()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17865, 1790778132, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778132, new IntPtr(2737335802252L), 15);
		}
		return (IAsyncRelayCommand<GameInstanceModel>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<GameInstanceModel> _FF00_FF00_3200()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778133, new IntPtr(2737335815772L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<GameInstanceModel>)/*Error near IL_0033: Stack underflow*/;
	}
}
