using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using ABI.Microsoft.UI.Composition;
using ABI.Microsoft.UI.Xaml;
using ABI.Microsoft.UI.Xaml.Controls;
using ABI.Microsoft.UI.Xaml.Markup;
using ABI.System.Collections;
using ABI.System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using Mass.Application.Desktop;
using Mass.Domain.Desktop.Entities.NetGame;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Domain.Entities.Mass;
using Mass.WinUI.Helpers;
using Mass.WinUI.Models;
using Microsoft.UI.Xaml.Controls;
using Serilog;
using WinRT;
using WinRT.Mass_WinUIGenericHelpers;
using WinRT.Mass_WinUIVtableClasses;

namespace Mass.WinUI.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails))]
public class PaymentViewModel : ObservableObject, IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRedeemCode_003Ed__97 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PaymentViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object DisableCreator;

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
		internal static bool ReplaceManager()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LoadEngine()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00팀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778391, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00퐀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0051: Expected Obj, but got Ref
			//IL_0073: Expected Obj, but got Ref
			//IL_0075: Expected Obj, but got I
			//IL_0061: Expected Obj, but got Ref
			//IL_009a: Expected Obj, but got Ref
			//IL_03f3: Expected I, but got Obj
			//IL_03fa: Expected Obj, but got I4
			//IL_014f: Expected Obj, but got I
			//IL_0210: Expected I, but got Obj
			//IL_0215: Expected Obj, but got I
			//IL_0217: Expected Obj, but got I4
			//IL_0276: Expected Obj, but got I4
			//IL_027b: Expected Obj, but got I4
			//IL_027b: Expected Obj, but got Ref
			//IL_02fe: Expected Obj, but got Ref
			//IL_0252: Expected Obj, but got Ref
			//IL_023b: Expected Obj, but got I4
			//IL_0240: Expected Obj, but got I4
			//IL_0240: Expected Obj, but got Ref
			//IL_02e8: Expected Obj, but got Ref
			//IL_028b: Expected Obj, but got Ref
			//IL_005b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0089->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00b3->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0094->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00be->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0129->IL00d4: Incompatible stack heights: 4 vs 1
			//IL_0134->IL00d4: Incompatible stack heights: 4 vs 1
			//IL_01f9->IL0175: Incompatible stack heights: 2 vs 1
			//IL_02a7->IL0175: Incompatible stack heights: 2 vs 1
			//IL_02e2->IL0175: Incompatible stack heights: 6 vs 1
			//IL_0204->IL0175: Incompatible stack heights: 2 vs 1
			//IL_02b2->IL0175: Incompatible stack heights: 2 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				case 1:
					return;
				default:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = -2;
					obj2 = 5;
					break;
				case 4:
					obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
					obj2 = 3;
					break;
				case 3:
					obj = IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized;
					obj2 = 1;
					if (IList_object._initialized == 0)
					{
						obj2 = 2;
					}
					break;
				case 5:
					IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)(nint)Unsafe.AsPointer(ref IList_object.PatchAttribute));
					_ = 1;
					if (IReadOnlyList_System_IDisposable._initialized != 0)
					{
						_ = 0;
					}
					break;
				case 2:
					{
						if (obj == null)
						{
							num = 3;
							goto IL_00d4;
						}
						goto IL_03ec;
					}
					IL_03ec:
					obj = IEnumeratorMethods<IDisposable>.Abi_GetMany_3((IntPtr)/*Error near IL_03f8: Stack underflow*/, ref *(IDisposable[]*)IReadOnlyList_System_IDisposable.Do_Abi_get_Size_1((nint)/*Error near IL_03f3: Stack underflow*/, (uint*)(nint)obj));
					num = 0;
					if (__KnownINotifyPropertyChangingArgs.IsLiked == null)
					{
						num = 0;
					}
					goto IL_00d4;
					IL_00d4:
					while (true)
					{
						int num2;
						switch (num)
						{
						case 1:
						case 6:
							break;
						case 5:
							_ = IReadOnlyList_System_IDisposable.ReflectConnectedAttribute;
							IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)(IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Initialized ? 1 : 0), (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init(), (nint*)2);
							_ = 0;
							if (IEnumerable_System_IDisposable._initialized != 0)
							{
								_ = 1;
							}
							continue;
						default:
							if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)/*Error near IL_013b: Stack underflow*/, (uint)/*Error near IL_013b: Stack underflow*/, ref *(INotifyPropertyChanged[]*)obj) != 0)
							{
								num = 3;
								if (IEnumerable_object.ReflectSetAttribute != null)
								{
									num = 5;
								}
								continue;
							}
							goto case 3;
						case 4:
							if (obj == null)
							{
								num2 = 5;
								goto IL_0175;
							}
							goto IL_0204;
						case 2:
							goto IL_03ec;
						case 3:
						case 7:
							{
								num = 1;
								if (__KnownINotifyPropertyChangingArgs.PreviewImage == null)
								{
									num = 4;
								}
								continue;
							}
							IL_0204:
							obj = IListMethods<object>.Abi_IndexOf_3((IntPtr)/*Error near IL_0215: Stack underflow*/, (object)(nint)MarshalInterface<IReadOnlyList<object>>.FromManaged((IReadOnlyList<object>)/*Error near IL_0209: Stack underflow*/), ref *(uint*)MarshalInspectable<object>.FromAbi((IntPtr)obj));
							num2 = 0;
							if (Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute == null)
							{
								num2 = 0;
							}
							goto IL_0175;
							IL_0175:
							while (true)
							{
								switch (num2)
								{
								case 8:
									return;
								case 12:
									break;
								default:
									if (!IEnumerableMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(&obj)))
									{
										num2 = 1;
										if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute == null)
										{
											num2 = 1;
										}
										continue;
									}
									goto case 6;
								case 6:
									IListMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_01e5: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_01e5: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)/*Error near IL_01e5: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_01e5: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_01e5: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_01e5: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int>)/*Error near IL_01e5: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, int>)/*Error near IL_01e5: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)/*Error near IL_01e5: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)/*Error near IL_01e5: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)/*Error near IL_01e5: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, int>)(&obj));
									_ = 11;
									if (Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute == null)
									{
										_ = 11;
									}
									continue;
								case 10:
									goto IL_0204;
								case 4:
									obj = -1;
									Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute = -1;
									num2 = 6;
									continue;
								case 3:
									Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute = obj;
									num2 = 7;
									if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.ReflectLiteralAttribute == null)
									{
										num2 = 9;
									}
									continue;
								case 1:
									obj = 0;
									_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner.CheckOperationalModule = 0;
									num2 = 3;
									continue;
								case 9:
									_ = ref _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout;
									((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CRedeemCode_003Ed__97, AccountViewModel._003CLoginDesktop_003Ed__87>(ref this));
									_ = 8;
									if (__KnownINotifyPropertyChangingArgs.Notes == null)
									{
										_ = 8;
									}
									continue;
								case 11:
									_ = __KnownINotifyPropertyChangingArgs.UserId;
									IList_object._002Ecctor();
									IList_object.AttachAttribute();
									_ = 1;
									IList_object.ReflectScopeAttribute();
									_ = 12;
									continue;
								case 7:
									Unsafe.As<PropertyChangingEventArgs, ComWrappers.ComInterfaceEntry>(ref __KnownINotifyPropertyChangingArgs.Name) = default;
									num2 = 4;
									continue;
								case 2:
								case 5:
									obj = __KnownINotifyPropertyChangingArgs.Message;
									num2 = 7;
									continue;
								}
								break;
							}
							break;
						}
						break;
					}
					goto default;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00픀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778388, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00혀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778389, new IntPtr(2737336183452L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00휀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778386, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FFFD()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FFFD(object P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0054: Expected Obj, but got I
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
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
				case 0:
					return;
				case 1:
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)(nint)Unsafe.AsPointer(ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized), ref *(object[]*)P_0);
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FFFD(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778387, new IntPtr(2737336185532L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRedeemProduct_003Ed__96 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ProductModel productModel;

		public PaymentViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object CheckIntegratedStub;

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
		internal static bool MoveEvaluator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckSymbolicTask()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00준()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778384, new IntPtr(2737336188652L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00쨀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0417: Expected Obj, but got Ref
			//IL_0453: Expected Obj, but got Ref
			//IL_047c: Expected Obj, but got I4
			//IL_047c: Expected Obj, but got Ref
			//IL_0485: Expected Obj, but got I4
			//IL_0429: Expected Obj, but got Ref
			//IL_042e: Expected Obj, but got Ref
			//IL_0055: Expected Obj, but got I4
			//IL_006f: Expected I4, but got Obj
			//IL_0084: Expected Obj, but got I
			//IL_0107: Expected Obj, but got Ref
			//IL_010e: Expected Obj, but got I4
			//IL_00ab: Expected Obj, but got I
			//IL_0203: Expected Obj, but got Ref
			//IL_022a: Expected Obj, but got Ref
			//IL_0124: Expected I4, but got Obj
			//IL_0130: Expected Obj, but got I4
			//IL_013f: Expected Obj, but got I
			//IL_026f: Expected I4, but got Obj
			//IL_026f: Expected I, but got Obj
			//IL_0289: Expected Obj, but got I4
			//IL_01ba: Expected Obj, but got Ref
			//IL_0154: Expected Obj, but got I4
			//IL_0159: Expected Obj, but got Ref
			//IL_029e: Expected Obj, but got I4
			//IL_02a3: Expected Obj, but got I4
			//IL_02a3: Expected Obj, but got Ref
			//IL_0244: Expected Obj, but got Ref
			//IL_0423->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0469->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0442->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0474->IL0026: Incompatible stack types: I4 vs Obj
			//IL_044d->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0089->IL005e: Incompatible stack types: I4 vs Obj
			//IL_0094->IL005e: Incompatible stack types: I4 vs Obj
			//IL_023c->IL00bf: Incompatible stack heights: 2 vs 1
			//IL_028e->IL00bf: Incompatible stack heights: 3 vs 1
			//IL_0299->IL00bf: Incompatible stack heights: 3 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					case 5:
					{
						obj = 2;
						object obj3 = obj;
						while (true)
						{
							int num;
							switch ((int)obj3)
							{
							case 2:
								obj3 = 0;
								if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute == null)
								{
									obj3 = 0;
								}
								continue;
							default:
								if (obj == null)
								{
									num = 0;
									if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
									{
										num = 2;
									}
									goto IL_00bf;
								}
								goto IL_0101;
							case 1:
								break;
								IL_00bf:
								while (true)
								{
									switch (num)
									{
									case 4:
										break;
									case 7:
										obj = IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_012e: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_012e: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_012e: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(IEnumeratorMethods<object>.Abi_get_HasCurrent_1(MarshalInspectable<object>.FromManaged(IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)/*Error near IL_011d: Stack underflow*/), (byte)(int)obj != 0)) ? 1 : 0));
										num = 10;
										if (IReadOnlyList_object.ReflectLogicalAttribute != null)
										{
											num = 5;
										}
										continue;
									case 11:
										obj = -1;
										IEnumerator_System_IDisposable._initialized = -1;
										num = 6;
										if (IEnumerable_System_IDisposable._initialized == 0)
										{
											num = 3;
										}
										continue;
									case 10:
										if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)/*Error near IL_017f: Stack underflow*/, (uint)/*Error near IL_017f: Stack underflow*/, ref *(INotifyPropertyChanged[]*)(&obj)) == 0)
										{
											num = 12;
											continue;
										}
										goto case 6;
									case 6:
										MarshalInterface<INotifyPropertyChanged>.CopyManagedArray((INotifyPropertyChanged[])/*Error near IL_0195: Stack underflow*/, (IntPtr)(nint)(&obj));
										num = 1;
										if (GlobalVtableLookup.CreateAttribute != null)
										{
											num = 8;
										}
										continue;
									case 9:
										Unsafe.As<object, uint>(ref Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute) = default;
										num = 11;
										continue;
									case 5:
										return;
									default:
										obj = Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute;
										num = 5;
										if (Mass_WinUI_AppWinRTTypeDetails.CheckHiddenAttribute != null)
										{
											num = 9;
										}
										continue;
									case 3:
										_ = ref Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute;
										((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CRedeemProduct_003Ed__96, AccountViewModel._003CImportAccounts_003Ed__28>(ref this));
										_ = 5;
										continue;
									case 13:
										Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute = obj;
										num = 0;
										if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute == null)
										{
											num = 3;
										}
										continue;
									case 8:
										IList_object.Do_Abi_Append_7((nint)/*Error near IL_0274: Stack underflow*/, (nint)(int)IList_object.Do_Abi_RemoveAt_6((nint)obj, (uint)(int)_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.Instance));
										IList_object.Do_Abi_RemoveAtEnd_8((nint)1);
										_ = 1;
										if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator == null)
										{
											_ = 1;
										}
										continue;
									case 12:
										obj = 0;
										__KnownINotifyPropertyChangingArgs.Notes = (PropertyChangingEventArgs)0;
										num = 13;
										continue;
									case 1:
										goto end_IL_005e;
									}
									break;
								}
								goto IL_0101;
								IL_0101:
								obj = IEnumerator_object.Do_Abi_get_Current_0((nint)/*Error near IL_010c: Stack underflow*/, (nint*)IList_object._initialized);
								num = 7;
								goto IL_00bf;
								end_IL_005e:
								break;
							}
							break;
						}
						break;
					}
					default:
						obj = __KnownINotifyPropertyChangingArgs.Summary;
						obj2 = 5;
						continue;
					case 3:
						MarshalInterface<IEnumerator<IDisposable>>.FromManaged((IEnumerator<IDisposable>)Unsafe.AsPointer(ref __KnownINotifyPropertyChangingArgs.PreviewImage));
						_ = 1;
						if (__KnownINotifyPropertyChangingArgs.Executor != null)
						{
							_ = 4;
						}
						continue;
					case 1:
						obj = __KnownINotifyPropertyChangingArgs.LaunchTime;
						obj2 = 0;
						if (__KnownINotifyPropertyChangingArgs.StateText != null)
						{
							obj2 = 0;
						}
						continue;
					case 2:
						break;
					case 4:
						return;
					}
					break;
				}
				__KnownINotifyPropertyChangingArgs.OperationText = (PropertyChangingEventArgs)(-2);
				obj = 3;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00쬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778385, new IntPtr(2737336183452L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00찀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00촀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778398, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00츀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778399, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00케()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00퀀(object P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0054: Expected Obj, but got I
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
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
				case 0:
					return;
				case 1:
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)(nint)Unsafe.AsPointer(ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized), ref *(object[]*)P_0);
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00턀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778396, new IntPtr(2737336188652L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRefreshHistoryOrder_003Ed__94 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HistoryOrderModel order;

		public PaymentViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object ReflectConfigurableViewer;

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
		internal static bool CheckSeparatedCalculator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectMonoDictionary()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00뼀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778397, new IntPtr(2737336188652L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00쀀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_009c: Expected Obj, but got Ref
			//IL_00b0: Expected Obj, but got I
			//IL_004e: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got I
			//IL_06b8: Expected Obj, but got Ref
			//IL_0077: Expected Obj, but got I4
			//IL_0077: Expected Obj, but got Ref
			//IL_0086: Expected Obj, but got I
			//IL_0137: Expected Obj, but got I
			//IL_0110: Expected Obj, but got I
			//IL_0507: Expected Obj, but got Ref
			//IL_0512: Expected Obj, but got I4
			//IL_02c8: Expected Obj, but got Ref
			//IL_02ca: Expected Obj, but got I4
			//IL_02d3: Expected Obj, but got I4
			//IL_018e: Expected Obj, but got I
			//IL_0417: Expected I4, but got Obj
			//IL_01d7: Expected I4, but got Obj
			//IL_0477: Expected I, but got Obj
			//IL_0482: Expected I, but got Obj
			//IL_0557: Expected Obj, but got Ref
			//IL_04b8: Expected Obj, but got I4
			//IL_04bd: Expected Obj, but got I4
			//IL_04bd: Expected Obj, but got Ref
			//IL_04f1: Expected Obj, but got Ref
			//IL_0427: Expected Obj, but got Ref
			//IL_042c: Expected I, but got Obj
			//IL_0438: Expected Obj, but got I4
			//IL_04a9: Expected Obj, but got Ref
			//IL_051c: Expected Obj, but got I4
			//IL_0521: Expected Obj, but got I4
			//IL_0521: Expected Obj, but got Ref
			//IL_0202: Expected Obj, but got I4
			//IL_02b0: Expected Obj, but got Ref
			//IL_023b: Expected Obj, but got Ref
			//IL_0277: Expected Obj, but got Ref
			//IL_0226: Expected Obj, but got I4
			//IL_022b: Expected Obj, but got I4
			//IL_022b: Expected Obj, but got Ref
			//IL_01ec: Expected Obj, but got I4
			//IL_029b: Expected Obj, but got I4
			//IL_02a0: Expected Obj, but got I4
			//IL_02a0: Expected Obj, but got Ref
			//IL_00b5->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_06ce->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00c0->IL0026: Incompatible stack heights: 2 vs 1
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_06d9->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0096->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0625->IL00d6: Incompatible stack heights: 4 vs 1
			//IL_03d3->IL03e2: Incompatible stack types: I4 vs Obj
			//IL_0193->IL01a2: Incompatible stack types: I4 vs Obj
			//IL_03de->IL03e2: Incompatible stack types: I4 vs Obj
			//IL_019e->IL01a2: Incompatible stack types: I4 vs Obj
			//IL_0496->IL03e2: Incompatible stack heights: 2 vs 1
			//IL_0569->IL03e2: Incompatible stack heights: 2 vs 1
			//IL_04c7->IL03e2: Incompatible stack types: I4 vs Obj
			//IL_0501->IL03e2: Incompatible stack types: I4 vs Obj
			//IL_044c->IL03e2: Incompatible stack types: I4 vs Obj
			//IL_04b3->IL03e2: Incompatible stack types: I4 vs Obj
			//IL_052b->IL03e2: Incompatible stack types: I4 vs Obj
			//IL_0216->IL01a2: Incompatible stack types: I4 vs Obj
			//IL_02c2->IL01a2: Incompatible stack heights: 2 vs 1
			//IL_024b->IL01a2: Incompatible stack types: I4 vs Obj
			//IL_028b->IL01a2: Incompatible stack types: I4 vs Obj
			//IL_0235->IL01a2: Incompatible stack types: I4 vs Obj
			//IL_01f1->IL019e: Incompatible stack heights: 1 vs 0
			//IL_02aa->IL01a2: Incompatible stack types: I4 vs Obj
			//IL_04a1->IL03e2: Incompatible stack heights: 2 vs 1
			//IL_046d->IL03e2: Incompatible stack types: I4 vs Obj
			//IL_0457->IL03e2: Incompatible stack types: I4 vs Obj
			//IL_0221->IL01a2: Incompatible stack types: I4 vs Obj
			//IL_0296->IL01a2: Incompatible stack types: I4 vs Obj
			//IL_02ee->IL01a2: Incompatible stack types: I4 vs Obj
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				case 2:
					obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
					obj2 = 5;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj2 = 3;
					}
					break;
				case 4:
					IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute = -2;
					obj2 = 0;
					if (IList_object.PatchAttribute != null)
					{
						obj2 = 0;
					}
					break;
				default:
					MarshalInspectable<object>.FromManaged((object)/*Error near IL_00a1: Stack underflow*/, (byte)Unsafe.AsPointer(ref IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized) != 0);
					_ = 1;
					if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute != null)
					{
						_ = 0;
					}
					break;
				case 5:
					if (obj == null)
					{
						num = 2;
						goto IL_00d6;
					}
					goto IL_0120;
				case 3:
					obj = __KnownINotifyPropertyChangingArgs.VerifyCodeDelayText;
					obj2 = 2;
					if (__KnownINotifyPropertyChangingArgs.InfoBarSeverity != null)
					{
						obj2 = 0;
					}
					break;
				case 1:
					return;
					IL_00d6:
					while (true)
					{
						object obj4;
						object obj3;
						switch (num)
						{
						case 6:
							break;
						default:
							num = 1;
							if (IReadOnlyList_object.ReflectLogicalAttribute != null)
							{
								num = 1;
							}
							continue;
						case 5:
							goto IL_0120;
						case 4:
							goto IL_0147;
						case 3:
							if ((nint)obj != 1)
							{
								obj4 = 0;
								if (IEnumerable_object.ReflectSetAttribute != null)
								{
									obj4 = 0;
								}
								goto IL_01a2;
							}
							goto IL_02c2;
						case 1:
							if (obj != null)
							{
								obj3 = 8;
								if (__KnownINotifyPropertyChangingArgs.MaxPlayers == null)
								{
									obj3 = 6;
								}
								goto IL_03e2;
							}
							goto IL_0501;
						case 7:
							goto IL_060e;
							IL_019e:
							obj4 = obj;
							goto IL_01a2;
							IL_01a2:
							while (true)
							{
								switch ((int)obj4)
								{
								case 6:
								case 9:
									break;
								default:
									obj = IListMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_0200: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_0200: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)/*Error near IL_0200: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_0200: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_0200: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_0200: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int>)/*Error near IL_0200: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, int>)/*Error near IL_0200: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)/*Error near IL_0200: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)/*Error near IL_0200: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)/*Error near IL_0200: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, int>)MarshalInterface<IEnumerator<INotifyPropertyChanged>>.FromManaged(IEnumerableMethods<INotifyPropertyChanged>.Abi_First_0((IntPtr)/*Error near IL_01f6: Stack underflow*/)));
									obj4 = 8;
									if (Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute == null)
									{
										obj4 = 3;
									}
									continue;
								case 5:
									obj = 1;
									Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute = 1;
									obj4 = 4;
									continue;
								case 2:
									Unsafe.As<object, ValueTuple<, >>(ref Mass_WinUI_AppWinRTTypeDetails.CheckHiddenAttribute) = default;
									obj4 = 7;
									continue;
								case 3:
									return;
								case 4:
									Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute = obj;
									obj4 = 1;
									if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.Instance == null)
									{
										obj4 = 1;
									}
									continue;
								case 7:
									obj = -1;
									_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.ReflectLiteralAttribute = -1;
									obj4 = 6;
									continue;
								case 1:
									_ = ref _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner.CheckOperationalModule;
									((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CRefreshHistoryOrder_003Ed__94, AccountViewModel._003CLoginBedrock_003Ed__86>(ref this));
									_ = 3;
									continue;
								case 10:
									goto IL_02c2;
								case 8:
									if (IEnumeratorMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, nint*, int>)/*Error near IL_02df: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)/*Error near IL_02df: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)/*Error near IL_02df: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, uint*, int>)(&obj)))
									{
										obj4 = 9;
										continue;
									}
									goto case 5;
								case 11:
									goto IL_060e;
								}
								break;
							}
							IEnumerableMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(&obj));
							obj = 11;
							goto IL_019e;
							IL_0501:
							obj = __KnownINotifyPropertyChangingArgs.OrderId;
							obj = 5;
							obj3 = obj;
							goto IL_03e2;
							IL_03e2:
							while (true)
							{
								switch ((int)obj3)
								{
								case 8:
									obj = IEnumeratorMethods<IDisposable>.Abi_GetMany_3((IntPtr)/*Error near IL_0436: Stack underflow*/, ref *(IEnumeratorMethods<IDisposable>.Abi_MoveNext_2((IntPtr)(int)IReadOnlyList_System_IDisposable.Do_Abi_GetMany_3((nint)/*Error near IL_042c: Stack underflow*/, (uint)/*Error near IL_042c: Stack underflow*/, (uint)/*Error near IL_042c: Stack underflow*/, (nint)(int)IReadOnlyListMethods<object>.Abi_GetMany_3((IntPtr)/*Error near IL_0421: Stack underflow*/, (uint)/*Error near IL_0421: Stack underflow*/, ref *(object[]*)/*Error near IL_0421: Stack underflow*/), (uint*)(nint)__KnownINotifyPropertyChangingArgs.Description)) ? ((IDisposable[]*)1) : ((IDisposable[]*)null)));
									obj3 = 5;
									if (__KnownINotifyPropertyChangingArgs.IsLiked == null)
									{
										obj3 = 6;
									}
									continue;
								case 6:
									if (!IEnumerableMethods<IDisposable, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(&obj)))
									{
										obj3 = 10;
										continue;
									}
									goto case 11;
								case 1:
									IReadOnlyList_object.Do_Abi_GetMany_3((nint)/*Error near IL_0482: Stack underflow*/, (uint)/*Error near IL_0482: Stack underflow*/, (uint)/*Error near IL_0482: Stack underflow*/, (nint)(int)IReadOnlyList_object.Do_Abi_IndexOf_2((nint)/*Error near IL_047c: Stack underflow*/, (nint)/*Error near IL_047c: Stack underflow*/, (uint*)/*Error near IL_047c: Stack underflow*/, (byte*)(int)IReadOnlyList_object.Do_Abi_GetAt_0((nint)/*Error near IL_0477: Stack underflow*/, (uint)/*Error near IL_0477: Stack underflow*/, (nint*)(nint)__KnownINotifyPropertyChangingArgs.PreviewImage)), (uint*)unchecked((nint)null));
									_ = 0;
									if (__KnownINotifyPropertyChangingArgs.State != null)
									{
										_ = 0;
									}
									continue;
								case 9:
									__KnownINotifyPropertyChangingArgs.StateText = (PropertyChangingEventArgs)obj;
									obj3 = 2;
									continue;
								case 4:
									obj = -1;
									__KnownINotifyPropertyChangingArgs.OperationText = (PropertyChangingEventArgs)(-1);
									obj3 = 11;
									continue;
								case 7:
									return;
								case 5:
									__KnownINotifyPropertyChangingArgs.CanDelete = null;
									obj3 = 4;
									continue;
								case 3:
									goto IL_0501;
								case 10:
									obj = 0;
									__KnownINotifyPropertyChangingArgs.Price = (PropertyChangingEventArgs)0;
									obj3 = 9;
									continue;
								case 11:
									_ = ref obj;
									/*Error near IL_052d: Member reference must be method, but was: Field*/;
								case 2:
									_ = ref __KnownINotifyPropertyChangingArgs.Number;
									((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CRefreshHistoryOrder_003Ed__94, DesktopViewModel._003CLaunchGame_003Ed__3>(ref this));
									_ = 7;
									continue;
								}
								break;
							}
							goto IL_0147;
							IL_060e:
							GlobalVtableLookup.LookupRuntimeClassName(obj);
							_ = null;
							_ = IEnumeratorMethods<INotifyPropertyChanged>.AbiToProjectionVftablePtr;
							_ = 6;
							continue;
							IL_02c2:
							obj = _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_hasTimeout;
							obj = 2;
							goto IL_019e;
						}
						break;
					}
					goto case 4;
					IL_0120:
					if ((nint)obj != 1)
					{
						num = 0;
						if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
						{
							num = 0;
						}
						goto IL_00d6;
					}
					goto IL_0147;
					IL_0147:
					num = 3;
					goto IL_00d6;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00섀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778394, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00숀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00쌀()
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
		internal unsafe static object _FF00_FF00_FF00_FF00쐀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778395, new IntPtr(2737336185532L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00씀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778392, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00였(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00윀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778393, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRefreshHistoryOrderCollection_003Ed__95 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PaymentViewModel _003C_003E4__this;

		private TaskAwaiter<List<EntityMassHistoryOrder>> _003C_003Eu__1;

		internal static object ReflectOrderedMonitor;

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
		internal static bool ReflectVisualSynchronizer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AddDictionary()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00똀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778470, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00뜀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0055: Expected Obj, but got I4
			//IL_0471: Expected Obj, but got Ref
			//IL_044a: Expected Obj, but got Ref
			//IL_043a: Expected Obj, but got I4
			//IL_043a: Expected Obj, but got Ref
			//IL_040d: Expected Obj, but got Ref
			//IL_006f: Expected I4, but got Obj
			//IL_0114: Expected I, but got Obj
			//IL_00e1: Expected Obj, but got I4
			//IL_00e6: Expected Obj, but got I4
			//IL_00e6: Expected Obj, but got Ref
			//IL_00f5: Expected Obj, but got I
			//IL_01fb: Expected Obj, but got Ref
			//IL_0135: Expected Obj, but got Ref
			//IL_01e5: Expected Obj, but got Ref
			//IL_0149: Expected I, but got Obj
			//IL_0149: Expected Obj, but got Ref
			//IL_016f: Expected Obj, but got Ref
			//IL_0171: Expected Obj, but got I
			//IL_0180: Expected Obj, but got I
			//IL_00cd: Expected Obj, but got I4
			//IL_00d2: Expected Obj, but got Ref
			//IL_0257: Expected I4, but got Obj
			//IL_0242: Expected Obj, but got I
			//IL_0242: Expected I4, but got Obj
			//IL_0242: Expected I, but got Obj
			//IL_0487->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0460->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0444->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0426->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0492->IL0026: Incompatible stack types: I4 vs Obj
			//IL_046b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0431->IL0026: Incompatible stack heights: 2 vs 1
			//IL_035a->IL005e: Incompatible stack types: I4 vs Obj
			//IL_0365->IL005e: Incompatible stack types: I4 vs Obj
			//IL_0217->IL008a: Incompatible stack heights: 2 vs 1
			//IL_0222->IL008a: Incompatible stack heights: 2 vs 1
			//IL_026b->IL008a: Incompatible stack heights: 2 vs 1
			//IL_0248->IL0248: Incompatible stack heights: 2 vs 3
			//IL_0276->IL008a: Incompatible stack heights: 2 vs 1
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
				{
					obj = 2;
					object obj3 = obj;
					while (true)
					{
						int num;
						switch ((int)obj3)
						{
						case 1:
							if (obj == null)
							{
								num = 2;
								goto IL_008a;
							}
							goto IL_0105;
						case 2:
							{
								obj3 = 1;
								if (__KnownINotifyPropertyChangingArgs.MaxPlayers != null)
								{
									obj3 = 1;
								}
								continue;
							}
							IL_0105:
							*((int, nint)*)(nint)/*Error near IL_010a: Stack underflow*/ = ((int)/*Error near IL_010a: Stack underflow*/, (nint)/*Error near IL_010a: Stack underflow*/);
							obj = IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)MarshalInspectable<object>.FromAbiArray((object)/*Error near IL_010f: Stack underflow*/));
							num = 8;
							goto IL_008a;
							IL_008a:
							while (true)
							{
								switch (num)
								{
								case 11:
									obj = -1;
									IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = -1;
									num = 9;
									continue;
								default:
									obj = 0;
									IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = 0;
									num = 5;
									if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
									{
										num = 2;
									}
									continue;
								case 7:
									break;
								case 2:
								case 3:
									obj = IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute;
									num = 4;
									continue;
								case 5:
									IReadOnlyList_System_IDisposable._initialized = (nint)obj;
									num = 1;
									if (IReadOnlyList_object._initialized != 0)
									{
										num = 0;
									}
									continue;
								case 9:
									obj = (nint)MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)(&obj));
									num = 12;
									if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
									{
										num = 11;
									}
									continue;
								case 6:
									return;
								case 8:
									MarshalInterface<INotifyPropertyChanged>.CopyManagedArray((INotifyPropertyChanged[])/*Error near IL_01bb: Stack underflow*/, (IntPtr)(nint)(&obj));
									if ((int)/*Error near IL_01c0: Stack underflow*/ == 0)
									{
										num = 0;
										if (GlobalVtableLookup.CreateAttribute == null)
										{
											num = 0;
										}
										continue;
									}
									goto case 9;
								case 4:
									Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute = null;
									num = 11;
									continue;
								case 1:
									_ = ref Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute;
									((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CRefreshHistoryOrderCollection_003Ed__95, AccountViewModel._003CEditAccount_003Ed__22>(ref this));
									_ = 6;
									if (Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute == null)
									{
										_ = 4;
									}
									continue;
								case 12:
								{
									object obj4 = obj;
									object obj5 = obj;
									object checkHiddenAttribute = Mass_WinUI_AppWinRTTypeDetails.CheckHiddenAttribute;
									if (checkHiddenAttribute == null)
									{
										Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute = new IListMethods<object>((IntPtr)obj5, (uint)(int)Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute, (object)(delegate* unmanaged[Stdcall]<nint, uint, nint*, uint>)(&IList_object.Do_Abi_GetAt_0));
									}
									((ILogger)obj4).Warning<string>((string)obj5, (string)checkHiddenAttribute);
									IList_object.Do_Abi_RemoveAt_6((nint)/*Error near IL_0257: Stack underflow*/, (uint)(int)new IListMethods<object>((IntPtr)/*Error near IL_0252: Stack underflow*/));
									_ = 1;
									if ((int)_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout != 0)
									{
										_ = 10;
									}
									continue;
								}
								case 10:
									goto end_IL_005e;
								}
								break;
							}
							goto IL_0105;
							end_IL_005e:
							break;
						}
						break;
					}
					goto case 3;
				}
				case 5:
					IEnumerableMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)Unsafe.AsPointer(ref __KnownINotifyPropertyChangingArgs.SourceImage));
					_ = 2;
					if (__KnownINotifyPropertyChangingArgs.LaunchTime != null)
					{
						_ = 4;
					}
					break;
				case 4:
					return;
				case 3:
					__KnownINotifyPropertyChangingArgs.State = (PropertyChangingEventArgs)(-2);
					obj2 = 5;
					break;
				case 2:
					obj = __KnownINotifyPropertyChangingArgs.StateText;
					obj2 = 1;
					if (__KnownINotifyPropertyChangingArgs.CloseText == null)
					{
						obj2 = 1;
					}
					break;
				case 1:
					obj = __KnownINotifyPropertyChangingArgs.Type;
					obj2 = 0;
					if (__KnownINotifyPropertyChangingArgs.Id != null)
					{
						obj2 = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00렀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778471, new IntPtr(2737336183452L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00뤀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00먀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778468, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00묀()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00밀(object P_0)
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
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRefreshShopCollection_003Ed__93 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PaymentViewModel _003C_003E4__this;

		private TaskAwaiter<EntityMassShop> _003C_003Eu__1;

		internal static object ReflectStaticSystem;

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
		internal static bool DecorateDynamicRole()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckConcreteCollection()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00가()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778469, new IntPtr(2737336163692L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00관()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_007a: Expected Obj, but got Ref
			//IL_004e: Expected Obj, but got Ref
			//IL_0062: Expected Obj, but got I
			//IL_008a: Expected Obj, but got Ref
			//IL_009b: Expected Obj, but got I
			//IL_00b1: Expected Obj, but got Ref
			//IL_00b3: Expected Obj, but got I
			//IL_063a: Expected Obj, but got Ref
			//IL_035d: Expected Obj, but got I4
			//IL_0362: Expected Obj, but got I4
			//IL_0362: Expected Obj, but got Ref
			//IL_04d4: Expected I, but got Obj
			//IL_05ca: Expected Obj, but got Ref
			//IL_04b7: Expected Obj, but got Ref
			//IL_04bf: Expected Obj, but got Ref
			//IL_04bf: Expected Obj, but got Ref
			//IL_04c8: Expected Obj, but got I4
			//IL_02df: Expected Obj, but got Ref
			//IL_026e: Expected I, but got Obj
			//IL_030d: Expected Obj, but got I4
			//IL_0314: Expected Obj, but got I4
			//IL_0325: Expected I, but got Obj
			//IL_0339: Expected Obj, but got I4
			//IL_0289: Unknown result type (might be due to invalid IL or missing references)
			//IL_0290: Expected Obj, but got Unknown
			//IL_03a1: Expected I, but got Obj
			//IL_03a8: Expected I, but got Obj
			//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ef: Expected Obj, but got Unknown
			//IL_04ac: Expected Obj, but got I4
			//IL_04f8: Expected Obj, but got I4
			//IL_02b4: Expected Obj, but got I4
			//IL_02b9: Expected Obj, but got I4
			//IL_02b9: Expected Obj, but got Ref
			//IL_0214: Expected I, but got Obj
			//IL_0220: Expected I, but got Obj
			//IL_0739: Unknown result type (might be due to invalid IL or missing references)
			//IL_0743: Expected Obj, but got Unknown
			//IL_059c: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a3: Expected Obj, but got Unknown
			//IL_0592: Expected Obj, but got I
			//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ce: Expected Obj, but got Unknown
			//IL_0433: Unknown result type (might be due to invalid IL or missing references)
			//IL_0436: Expected Obj, but got Unknown
			//IL_0477: Expected Obj, but got Ref
			//IL_0702: Expected I4, but got Obj
			//IL_070c: Expected I4, but got Obj
			//IL_070c: Expected Obj, but got I4
			//IL_03f6: Expected I4, but got Obj
			//IL_03f6: Expected I, but got Obj
			//IL_046c: Expected Obj, but got I4
			//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f0: Expected Obj, but got Unknown
			//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07db: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e1: Expected Obj, but got Unknown
			//IL_0792: Unknown result type (might be due to invalid IL or missing references)
			//IL_0797: Unknown result type (might be due to invalid IL or missing references)
			//IL_079d: Expected Obj, but got Unknown
			//IL_082f: Expected Obj, but got Ref
			//IL_07a2: Expected Obj, but got Unknown
			//IL_07a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ac: Expected Obj, but got Unknown
			//IL_0084->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0067->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00a0->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00c7->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0072->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00ab->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00d2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0531->IL0147: Incompatible stack heights: 5 vs 1
			//IL_06f4->IL0147: Incompatible stack heights: 4 vs 1
			//IL_03bc->IL0147: Incompatible stack heights: 2 vs 1
			//IL_04b1->IL0143: Incompatible stack heights: 0 vs 2
			//IL_067d->IL0147: Incompatible stack heights: 4 vs 1
			//IL_0398->IL0147: Incompatible stack heights: 5 vs 1
			//IL_0234->IL0147: Incompatible stack heights: 4 vs 1
			//IL_074d->IL0147: Incompatible stack heights: 4 vs 1
			//IL_059c->IL0147: Incompatible stack heights: 2 vs 1
			//IL_072a->IL0147: Incompatible stack heights: 3 vs 1
			//IL_025c->IL0147: Incompatible stack heights: 3 vs 1
			//IL_0471->IL0143: Incompatible stack heights: 1 vs 2
			//IL_0147->IL0147: Incompatible stack heights: 3 vs 1
			//IL_07e1->IL07e1: Incompatible stack heights: 4 vs 2
			//IL_076d->IL0147: Incompatible stack heights: 5 vs 1
			//IL_075e->IL075e: Incompatible stack heights: 2 vs 3
			//IL_03c7->IL0147: Incompatible stack heights: 2 vs 1
			//IL_0688->IL0147: Incompatible stack heights: 4 vs 1
			//IL_023f->IL0147: Incompatible stack heights: 4 vs 1
			//IL_0735->IL0147: Incompatible stack heights: 3 vs 1
			//IL_0267->IL0147: Incompatible stack heights: 3 vs 1
			//IL_0786->IL079d: Incompatible stack heights: 4 vs 6
			//IL_07b6->IL0147: Incompatible stack heights: 8 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 2:
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)/*Error near IL_0053: Stack underflow*/, ref Unsafe.As<nint, object[]>(ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized));
					_ = 5;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						_ = 4;
					}
					break;
				default:
					IList_object._initialized = -2;
					obj2 = 2;
					break;
				case 3:
					obj = IList_object.PatchAttribute;
					obj2 = 1;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
					{
						obj2 = 1;
					}
					break;
				case 4:
					obj = IReadOnlyList_System_IDisposable._initialized;
					obj2 = 0;
					if (IReadOnlyList_object._initialized == 0)
					{
						obj2 = 3;
					}
					break;
				case 5:
					return;
				case 1:
				{
					int num = 1;
					if (IEnumerator_System_IDisposable._initialized != 0)
					{
						num = 1;
					}
					while (true)
					{
						int num2;
						ref Guid iID;
						PropertyChangingEventArgs skinOwnedSelected;
						switch (num)
						{
						case 1:
							num = 2;
							if (IEnumerable_System_IDisposable._initialized != 0)
							{
								num = 1;
							}
							continue;
						case 2:
							{
								if (obj != null)
								{
									num2 = 11;
									goto IL_0147;
								}
								goto IL_0634;
							}
							IL_07fa:
							iID = IXamlTypeMethods.IID;
							skinOwnedSelected = __KnownINotifyPropertyChangingArgs.SkinOwnedSelected;
							if (skinOwnedSelected == null)
							{
								_ = __KnownINotifyPropertyChangingArgs.SelectedSkin;
								__ldftn(Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails._002Ector);
								/*Error near IL_081f: Member reference must be method, but was: Field*/;
							}
							((IEnumerable<GameResourceModel>)(nint)iID).Concat((IEnumerable<GameResourceModel>)skinOwnedSelected);
							/*Error near IL_082f: Member reference must be method, but was: Field*/;
							IL_0634:
							obj = __KnownINotifyPropertyChangingArgs.CreatedAt;
							num2 = 35;
							if (__KnownINotifyPropertyChangingArgs.DesktopAccounts == null)
							{
								num2 = 39;
							}
							goto IL_0147;
							IL_0147:
							while (true)
							{
								switch (num2)
								{
								case 12:
									break;
								case 23:
									return;
								case 7:
								case 31:
									IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1((nint)/*Error near IL_0214: Stack underflow*/, (uint*)(nint)obj);
									IReadOnlyListMethods<INotifyPropertyChanged>.Abi_get_Size_1((IntPtr)new IReadOnlyList_System_ComponentModel_INotifyPropertyChanged());
									_ = 16;
									if (Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute == null)
									{
										_ = 22;
									}
									continue;
								case 41:
									MarshalInterface<IEnumerator<INotifyPropertyChanged>>.FromManaged((IEnumerator<INotifyPropertyChanged>)obj);
									_ = 1;
									if (Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute == null)
									{
										_ = 5;
									}
									continue;
								case 10:
									obj = IListMethods<object>.Abi_GetView_2((IntPtr)obj);
									num2 = 25;
									continue;
								case 20:
									obj = (nint)new MarshalInterface<IReadOnlyList<object>>((IReadOnlyList<object>)/*Error near IL_028e: Stack underflow*/);
									num2 = 32;
									if (Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute != null)
									{
										num2 = 36;
									}
									continue;
								case 29:
									obj = 0;
									Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute = 0;
									num2 = 2;
									if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute != null)
									{
										num2 = 0;
									}
									continue;
								case 8:
									IListMethods<object>.Abi_Append_7((IntPtr)/*Error near IL_02df: Stack underflow*/, (object)(&obj));
									if ((int)/*Error near IL_02e4: Stack underflow*/ != 0)
									{
										num2 = 9;
										if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.ReflectLiteralAttribute == null)
										{
											num2 = 7;
										}
										continue;
									}
									goto case 29;
								case 11:
									IListMethods<object>.Abi_ReplaceAll_11((IntPtr)/*Error near IL_030d: Stack underflow*/, (object[])IListMethods<object>.Abi_GetMany_10((IntPtr)/*Error near IL_0308: Stack underflow*/, (uint)/*Error near IL_0308: Stack underflow*/, ref *(object[]*)/*Error near IL_0308: Stack underflow*/));
									obj = IListMethods<object>.Abi_get_Size_1((IntPtr)/*Error near IL_0312: Stack underflow*/);
									num2 = 8;
									continue;
								case 16:
									obj = new IList_object((nint)/*Error near IL_032a: Stack underflow*/, (uint)/*Error near IL_032a: Stack underflow*/, (nint)(IEnumeratorMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, nint*, int>)/*Error near IL_0325: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)/*Error near IL_0325: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)/*Error near IL_0325: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, uint*, int>)obj) ? 1 : 0));
									num2 = 13;
									continue;
								case 17:
									obj = 0;
									num2 = 15;
									if (__KnownINotifyPropertyChangingArgs.Username != null)
									{
										num2 = 13;
									}
									continue;
								default:
									obj = -1;
									__KnownINotifyPropertyChangingArgs.CreateAt = (PropertyChangingEventArgs)(-1);
									num2 = 35;
									continue;
								case 28:
									IList_object.ReflectScopeAttribute();
									MarshalInterface<IDisposable>.FromManaged((IDisposable)new IEnumerator_System_ComponentModel_INotifyPropertyChanged());
									_ = 37;
									continue;
								case 21:
									IReadOnlyListMethods<IDisposable>.Abi_IndexOf_2((IntPtr)obj, MarshalInterface<IDisposable>.FromAbi((IntPtr)obj), ref *(uint*)obj);
									_ = 18;
									if (__KnownINotifyPropertyChangingArgs.IsSelected != null)
									{
										_ = 31;
									}
									continue;
								case 36:
									obj = new MarshalInterface<IDisposable>((object)/*Error near IL_03cc: Stack underflow*/);
									num2 = 1;
									if (__KnownINotifyPropertyChangingArgs.ShowMaxPlayer != null)
									{
										num2 = 1;
									}
									continue;
								case 43:
									if (!IReadOnlyListMethods<object>.Abi_IndexOf_2((IntPtr)/*Error near IL_03fd: Stack underflow*/, IReadOnlyListMethods<object>.Abi_GetAt_0((IntPtr)obj, (uint)(int)obj), ref *(uint*)(&obj)))
									{
										num2 = 30;
										if (__KnownINotifyPropertyChangingArgs.Description != null)
										{
											num2 = 44;
										}
										continue;
									}
									goto case 28;
								case 37:
									obj++;
									num2 = 21;
									if (__KnownINotifyPropertyChangingArgs.ImageUrl == null)
									{
										num2 = 27;
									}
									continue;
								case 44:
									IEnumeratorMethods<IDisposable>.Abi_GetMany_3((IntPtr)/*Error near IL_045c: Stack underflow*/, ref *(IDisposable[]*)obj);
									obj = new IReadOnlyList_System_IDisposable();
									obj = 41;
									continue;
								case 39:
									__KnownINotifyPropertyChangingArgs.IsLiked = null;
									num2 = 0;
									if (__KnownINotifyPropertyChangingArgs.SourceImage != null)
									{
										num2 = 0;
									}
									continue;
								case 24:
									obj = new IEnumerableMethods<object, nint>((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)/*Error near IL_04a1: Stack underflow*/);
									obj = 10;
									continue;
								case 3:
									_ = ref __KnownINotifyPropertyChangingArgs.Executor;
									((IEnumerable<string>)(&obj)).FirstOrDefault((Func<string, bool>)Unsafe.AsPointer(ref this));
									obj = 23;
									continue;
								case 1:
									((Func<Type, string>)/*Error near IL_04d4: Stack underflow*/)._002Ector((object)/*Error near IL_04d4: Stack underflow*/, (nint)obj);
									obj = (object)/*Error near IL_04d6: Stack underflow*/;
									num2 = 17;
									if (__KnownINotifyPropertyChangingArgs.OperationText != null)
									{
										num2 = 13;
									}
									continue;
								case 25:
									obj = 0;
									num2 = 46;
									if (__KnownINotifyPropertyChangingArgs.Type == null)
									{
										num2 = 23;
									}
									continue;
								case 5:
									obj.ToString();
									_ = IReadOnlyListMethods<object>.IID;
									_ = 28;
									continue;
								case 38:
								case 46:
									if ((nint)obj >= ((Array)obj).Length)
									{
										num2 = 22;
										if (__KnownINotifyPropertyChangingArgs.Price != null)
										{
											num2 = 26;
										}
										continue;
									}
									goto case 30;
								case 14:
									/*Error near IL_056e: Member reference must be method, but was: Field*/;
								case 9:
								case 35:
									_ = ref obj;
									obj = (nint)IEnumerableMethods<object>.AbiToProjectionVftablePtr;
									_ = 19;
									continue;
								case 34:
									obj = new IListMethods();
									num2 = 24;
									if (__KnownINotifyPropertyChangingArgs.Image == null)
									{
										num2 = 6;
									}
									continue;
								case 2:
									__KnownINotifyPropertyChangingArgs.DisplayName = (PropertyChangingEventArgs)obj;
									num2 = 3;
									if (__KnownINotifyPropertyChangingArgs.TotalCoins != null)
									{
										num2 = 3;
									}
									continue;
								case 22:
									obj++;
									num2 = 38;
									continue;
								case 30:
									obj = ((object[])obj)[obj];
									num2 = 14;
									if (__KnownINotifyPropertyChangingArgs.Amount != null)
									{
										num2 = 3;
									}
									continue;
								case 15:
								case 27:
									if ((nint)obj < ((Array)obj).Length)
									{
										num2 = 32;
										continue;
									}
									goto case 33;
								case 18:
									goto end_IL_0147;
								case 26:
									new IReadOnlyListMethods<INotifyPropertyChanged>();
									GlobalVtableLookup.InitializeGlobalVtableLookup();
									_ = 4;
									if (__KnownINotifyPropertyChangingArgs.SelectedIndex == null)
									{
										_ = 2;
									}
									continue;
								case 32:
								case 45:
									obj = ((object[])obj)[obj];
									num2 = 43;
									continue;
								case 13:
									_ = IEnumeratorMethods<object>.AbiToProjectionVftablePtr;
									_ = 21;
									continue;
								case 40:
									((IEnumerable<EnumGameVersion>)((ObservableObject)/*Error near IL_0702: Stack underflow*/).SetProperty<int>(ref *(int*)obj, (int)obj, (string)(object)Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.NewAttribute())).Contains((EnumGameVersion)(int)new Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails());
									((Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails)new IEnumeratorMethods<IDisposable>()).GetExposedInterfaces();
									_ = 3;
									if (__KnownINotifyPropertyChangingArgs.IsDragging != null)
									{
										_ = 6;
									}
									continue;
								case 33:
									((Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails)new IAnimationObjectMethods()).GetExposedInterfaces();
									_ = 40;
									continue;
								case 19:
									if ((nint)IVisualElementMethods.IID == 0)
									{
									}
									Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.DecorateOperationalAttribute();
									_ = 42;
									continue;
								case 42:
								{
									_ = IVisualElement2Methods.AbiToProjectionVftablePtr;
									IControlOverridesMethods val;
									if (__KnownINotifyPropertyChangingArgs.ParsedAccounts == null)
									{
										_ = __KnownINotifyPropertyChangingArgs.ParseErrorMessage;
										_ = (delegate*<Mass_WinUI_Pages_MobileWinRTTypeDetails>)(&Mass_WinUI_Pages_MobileWinRTTypeDetails.CheckInterruptibleAttribute);
										val = (IControlOverridesMethods)(nint)new IControlOverridesMethods();
										__KnownINotifyPropertyChangingArgs.HasSelectedGame = (PropertyChangingEventArgs)val;
									}
									((IEnumerable<EntityNetGameItem>)val).ToArray();
									((Mass_WinUI_AppWinRTTypeDetails)new IComponentConnectorMethods()).GetExposedInterfaces();
									_ = 34;
									continue;
								}
								case 4:
								{
									object obj3 = obj;
									obj._002Ector();
									PropertyChangingEventArgs fourLikeNetGames = __KnownINotifyPropertyChangingArgs.FourLikeNetGames;
									if (fourLikeNetGames == null)
									{
										_ = __KnownINotifyPropertyChangingArgs.NetGamesEmptyText;
										__ldftn(Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.GetExposedInterfaces);
										__KnownINotifyPropertyChangingArgs.RentalGamesEmptyText = (PropertyChangingEventArgs)(nint)new IApplicationOverridesMethods();
									}
									((ILogger)/*Error near IL_07e6: Stack underflow*/).Debug<string>((string)obj3, (string)(object)fourLikeNetGames);
									((Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails)new IXamlMemberMethods())._002Ector();
									num2 = 20;
									continue;
								}
								case 6:
									goto IL_07fa;
								}
								goto end_IL_00fa;
								continue;
								end_IL_0147:
								break;
							}
							goto IL_0634;
							end_IL_00fa:
							break;
						}
						break;
					}
					goto default;
				}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00글()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778466, new IntPtr(2737336182412L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00꼀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00뀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778467, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00넀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778464, new IntPtr(2737336157452L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00눀()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00대(object P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0054: Expected Obj, but got I
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
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
				case 0:
					return;
				case 1:
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)(nint)Unsafe.AsPointer(ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized), ref *(object[]*)P_0);
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00됀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778465, new IntPtr(2737336185532L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CTopUp_003Ed__92 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TopUpArgs args;

		public PaymentViewModel _003C_003E4__this;

		private TaskAwaiter<EntityMassOrder> _003C_003Eu__1;

		internal static object DefineSystem;

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
		internal static bool DecorateAlphabeticChooser()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckEditableSolver()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00ꈀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778478, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00ꌀ()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0075: Expected Obj, but got Ref
			//IL_0086: Expected Obj, but got I
			//IL_060b: Expected Obj, but got Ref
			//IL_05f6: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got Ref
			//IL_01de: Expected Obj, but got Ref
			//IL_01e5: Expected Obj, but got I4
			//IL_01ca: Expected Obj, but got I4
			//IL_01d3: Expected Obj, but got I4
			//IL_0535: Expected Obj, but got I4
			//IL_01a3: Expected I, but got Obj
			//IL_01b7: Expected Obj, but got I4
			//IL_0178: Expected Obj, but got I
			//IL_040c: Expected Obj, but got Ref
			//IL_010a: Expected Obj, but got I
			//IL_00ee: Expected I4, but got Obj
			//IL_03a0: Expected Obj, but got Ref
			//IL_0304: Expected I, but got Obj
			//IL_02a6: Expected I, but got Obj
			//IL_02a6: Expected I, but got Obj
			//IL_02ae: Expected I4, but got Obj
			//IL_02ae: Expected I, but got Obj
			//IL_02b3: Expected I, but got Obj
			//IL_02b3: Expected I4, but got Obj
			//IL_03d0: Expected I, but got Obj
			//IL_03d0: Expected I, but got Obj
			//IL_03dc: Expected I, but got Obj
			//IL_02cf: Expected I, but got Obj
			//IL_0374: Expected Obj, but got Ref
			//IL_0379: Expected I, but got Obj
			//IL_037f: Expected Obj, but got Ref
			//IL_0384: Expected I, but got Obj
			//IL_0389: Expected Obj, but got I4
			//IL_038e: Expected I, but got Obj
			//IL_0390: Expected Obj, but got I4
			//IL_0341: Expected Obj, but got Ref
			//IL_0420: Expected Obj, but got Ref
			//IL_0456: Expected I, but got Obj
			//IL_0356: Expected Obj, but got I4
			//IL_035b: Expected Obj, but got I4
			//IL_035b: Expected Obj, but got Ref
			//IL_0364: Expected Obj, but got I4
			//IL_03b7: Expected Obj, but got I4
			//IL_03bc: Expected Obj, but got I4
			//IL_03bc: Expected Obj, but got Ref
			//IL_028e: Expected Obj, but got I4
			//IL_028e: Expected I, but got Obj
			//IL_0278: Expected I4, but got Obj
			//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0621->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0605->IL0026: Incompatible stack heights: 3 vs 1
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0096->IL0026: Incompatible stack types: I4 vs Obj
			//IL_062c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01f9->IL00ad: Incompatible stack types: I4 vs Obj
			//IL_00a9->IL00ad: Incompatible stack heights: 1 vs 2
			//IL_00ee->IL01d8: Incompatible stack heights: 1 vs 0
			//IL_0204->IL00ad: Incompatible stack types: I4 vs Obj
			//IL_01c7->IL00ad: Incompatible stack types: I4 vs Obj
			//IL_0549->IL00ad: Incompatible stack types: I4 vs Obj
			//IL_01bc->IL00a9: Incompatible stack heights: 4 vs 1
			//IL_017d->IL00ad: Incompatible stack types: I4 vs Obj
			//IL_0418->IL022f: Incompatible stack types: I4 vs Obj
			//IL_0220->IL022f: Incompatible stack types: I4 vs Obj
			//IL_0532->IL00ad: Incompatible stack types: I4 vs Obj
			//IL_010f->IL00ad: Incompatible stack types: I4 vs Obj
			//IL_0554->IL00ad: Incompatible stack types: I4 vs Obj
			//IL_0188->IL00ad: Incompatible stack types: I4 vs Obj
			//IL_022b->IL022f: Incompatible stack types: I4 vs Obj
			//IL_011a->IL00ad: Incompatible stack types: I4 vs Obj
			//IL_03b2->IL022f: Incompatible stack types: I4 vs Obj
			//IL_033b->IL022f: Incompatible stack types: I4 vs Obj
			//IL_0309->IL0351: Incompatible stack heights: 0 vs 1
			//IL_02c7->IL022f: Incompatible stack types: I4 vs Obj
			//IL_02c7->IL022f: Incompatible stack types: I4 vs Obj
			//IL_03fb->IL022f: Incompatible stack heights: 4 vs 2
			//IL_02d9->IL022f: Incompatible stack heights: 3 vs 2
			//IL_039a->IL022f: Incompatible stack heights: 1 vs 2
			//IL_0351->IL022f: Incompatible stack types: I4 vs Obj
			//IL_0434->IL022f: Incompatible stack types: I4 vs Obj
			//IL_0460->IL022f: Incompatible stack heights: 3 vs 2
			//IL_03c6->IL022f: Incompatible stack types: I4 vs Obj
			//IL_0465->IL0563: Incompatible stack heights: 0 vs 1
			//IL_029d->IL022f: Incompatible stack heights: 1 vs 2
			//IL_031d->IL022f: Incompatible stack heights: 1 vs 2
			//IL_0406->IL022f: Incompatible stack heights: 4 vs 2
			//IL_043f->IL022f: Incompatible stack types: I4 vs Obj
			//IL_0328->IL022f: Incompatible stack heights: 1 vs 2
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 1;
			object obj = awaiter;
			while (true)
			{
				object obj2;
				object obj4;
				switch ((int)obj)
				{
				case 4:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = -2;
					obj = 2;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj = 2;
					}
					break;
				default:
					awaiter = IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute;
					obj = 5;
					if (IList_object.PatchAttribute == null)
					{
						obj = 0;
					}
					break;
				case 3:
					return;
				case 5:
					if (awaiter == null)
					{
						_ = 11;
						goto IL_00ad;
					}
					goto IL_01d8;
				case 2:
					_ = ref __KnownINotifyPropertyChangingArgs.CreatedAt;
					_ = IListMethods<object>.AbiToProjectionVftablePtr;
					_ = 3;
					break;
				case 1:
					{
						awaiter = __KnownINotifyPropertyChangingArgs.DesktopAccounts;
						obj = 0;
						if (__KnownINotifyPropertyChangingArgs.SelectedAccounts != null)
						{
							obj = 0;
						}
						break;
					}
					IL_00ad:
					while (true)
					{
						object obj3;
						switch ((int)obj2)
						{
						case 2:
						case 6:
							break;
						case 8:
							if ((nint)awaiter <= 0)
							{
								obj2 = 0;
								if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
								{
									obj2 = 1;
								}
								continue;
							}
							goto case 5;
						default:
							if (awaiter != null)
							{
								obj2 = 14;
								if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
								{
									obj2 = 6;
								}
								continue;
							}
							goto case 10;
						case 14:
							IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1((nint)awaiter, (uint*)IEnumerable_System_IDisposable._initialized);
							IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
							_ = 2;
							IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.MoveAttribute();
							awaiter = 2;
							goto IL_00a9;
						case 10:
						case 11:
							obj2 = 4;
							continue;
						case 1:
						case 3:
							awaiter = 1;
							awaiter = 7;
							goto IL_00a9;
						case 9:
							goto IL_01d8;
						case 4:
							if (awaiter != null)
							{
								obj3 = 6;
								if (Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute == null)
								{
									obj3 = 8;
								}
								goto IL_022f;
							}
							goto IL_0406;
						case 5:
							if ((nint)awaiter <= 500)
							{
								obj2 = 13;
								continue;
							}
							goto case 1;
						case 12:
						case 13:
							{
								awaiter = 0;
								obj2 = 0;
								if (__KnownINotifyPropertyChangingArgs.Number == null)
								{
									obj2 = 0;
								}
								continue;
							}
							IL_00a9:
							obj2 = awaiter;
							continue;
							IL_0406:
							awaiter = __KnownINotifyPropertyChangingArgs.PreviewImage;
							obj3 = 9;
							goto IL_022f;
							IL_022f:
							while (true)
							{
								switch ((int)obj3)
								{
								case 14:
									break;
								case 16:
									return;
								case 15:
									((AsyncTaskMethodBuilder*)obj4)->Start(ref *(IListMethods<object>.Abi_IndexOf_3((IntPtr)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectMonoAttribute(), (object)IList_object.Initialized, ref *(uint*)awaiter) ? ((AccountViewModel._003CImportAccounts_003Ed__28*)1) : ((AccountViewModel._003CImportAccounts_003Ed__28*)null)));
									_ = 14;
									continue;
								case 5:
								{
									IList_object list_object = (IList_object)new IList_object((nint)awaiter, (nint*)(nint)awaiter);
									IListMethods<object>.Abi_RemoveAt_6((IntPtr)list_object, (uint)(int)awaiter);
									uint num = IList_object.Do_Abi_RemoveAt_6((nint)/*Error near IL_02bd: Stack underflow*/, IList_object.Do_Abi_InsertAt_5((nint)/*Error near IL_02b8: Stack underflow*/, (uint)/*Error near IL_02b8: Stack underflow*/, (nint)(int)IList_object.Do_Abi_SetAt_4((nint)/*Error near IL_02b3: Stack underflow*/, (uint)(int)obj4, (nint)list_object)));
									obj3 = 11;
									obj4 = num;
									continue;
								}
								case 7:
									IList_object.Do_Abi_Append_7((nint)awaiter, (nint)1);
									_ = 6;
									continue;
								case 3:
									if (IEnumeratorMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, nint*, int>)/*Error near IL_0304: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)/*Error near IL_0304: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)obj4, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, uint*, int>)(&awaiter)))
									{
										_ = 0;
										if (__KnownINotifyPropertyChangingArgs.UserId == null)
										{
											_ = 0;
										}
										continue;
									}
									goto case 12;
								default:
									awaiter = IEnumeratorMethods<INotifyPropertyChanged>.Abi_get_Current_0((IntPtr)(nint)(&awaiter));
									obj3 = 5;
									continue;
								case 9:
									__KnownINotifyPropertyChangingArgs.CreateAt = null;
									obj3 = 13;
									continue;
								case 12:
									awaiter = 0;
									__KnownINotifyPropertyChangingArgs.Name = (PropertyChangingEventArgs)0;
									awaiter = 10;
									obj3 = awaiter;
									continue;
								case 8:
									awaiter = IReadOnlyListMethods<IDisposable>.Abi_get_Size_1((IntPtr)MarshalInterface<IDisposable>.FromAbiArray((object)IEnumerator_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_HasCurrent_1((nint)(int)IEnumerator_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3((nint)/*Error near IL_0379: Stack underflow*/, (uint)/*Error near IL_0379: Stack underflow*/, (nint)MarshalInterface<IDisposable>.FromManaged((IDisposable)obj4), (uint*)(nint)__KnownINotifyPropertyChangingArgs.Message), (byte*)(nint)__KnownINotifyPropertyChangingArgs.Content)));
									_ = 3;
									continue;
								case 1:
									Unsafe.As<PropertyChangingEventArgs, AsyncTaskMethodBuilder>(ref __KnownINotifyPropertyChangingArgs.ShowMaxPlayer).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<DesktopSession>*)(&awaiter), ref Unsafe.As<_003CTopUp_003Ed__92, AccountViewModel._003CLoginHistoryAccount_003Ed__24>(ref this));
									obj3 = 16;
									continue;
								case 13:
									awaiter = -1;
									__KnownINotifyPropertyChangingArgs.MaxPlayers = (PropertyChangingEventArgs)(-1);
									obj3 = 2;
									continue;
								case 6:
									IEnumeratorMethods<IDisposable>.Abi_GetMany_3((IntPtr)(int)IReadOnlyList_System_IDisposable.Do_Abi_GetMany_3((nint)/*Error near IL_03d5: Stack underflow*/, (uint)/*Error near IL_03d5: Stack underflow*/, (uint)/*Error near IL_03d5: Stack underflow*/, (nint)/*Error near IL_03d5: Stack underflow*/, (uint*)(int)IReadOnlyList_System_IDisposable.Do_Abi_IndexOf_2((nint)/*Error near IL_03d0: Stack underflow*/, (nint)/*Error near IL_03d0: Stack underflow*/, (uint*)(nint)obj4, (byte*)(nint)__KnownINotifyPropertyChangingArgs.Author)), ref *(IEnumeratorMethods<IDisposable>.Abi_MoveNext_2((IntPtr)awaiter) ? ((IDisposable[]*)1) : ((IDisposable[]*)null)));
									_ = null;
									IReadOnlyList_System_IDisposable.StoreAttribute();
									_ = 15;
									if (__KnownINotifyPropertyChangingArgs.Summary == null)
									{
										_ = 1;
									}
									continue;
								case 4:
									goto IL_0406;
								case 10:
									__KnownINotifyPropertyChangingArgs.SourceImage = (PropertyChangingEventArgs)awaiter;
									obj3 = 1;
									if (__KnownINotifyPropertyChangingArgs.Executor != null)
									{
										obj3 = 1;
									}
									continue;
								case 11:
									IReadOnlyList_object.Do_Abi_get_Size_1((nint)awaiter, (uint*)(-1));
									_ = 7;
									continue;
								}
								break;
							}
							break;
						}
						break;
					}
					goto case 4;
					IL_01d8:
					obj4 = GlobalVtableLookup.CreateAttribute;
					awaiter = IEnumerable_System_ComponentModel_INotifyPropertyChanged.Initialized;
					obj2 = 4;
					if (Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute != null)
					{
						obj2 = 8;
					}
					goto IL_00ad;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00ꐀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778479, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00ꔀ()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00ꘀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778476, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_A700()
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
		internal unsafe static object _FF00_FF00_FF00_FF00ꠀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778477, new IntPtr(2737336157452L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00꤀(object P_0)
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0054: Expected Obj, but got I
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
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
				case 0:
					return;
				case 1:
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)(nint)Unsafe.AsPointer(ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized), ref *(object[]*)P_0);
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00ꨀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778474, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[CompilerGenerated]
	private Func<InfoBarDelegate>? m_GetInfoBar;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<TopUpArgs>? topUpCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? refreshShopCollectionCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<HistoryOrderModel>? refreshHistoryOrderCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? refreshHistoryOrderCollectionCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<ProductModel>? redeemProductCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? redeemCodeCommand;

	private static object UpdateDic;

	public bool IsRunning
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return this._FF00_FF00_FFFD() != 0;
		}
	}

	public bool CanSelect
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_2900() != 0;
		}
	}

	public bool ShowTabs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00눀() != 0;
		}
	}

	[NotifyPropertyChangedFor("ShowTabs")]
	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsLoading
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_EF00() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_E300(value ? ((byte)1) : ((byte)0));
		}
	}

	[NotifyPropertyChangedFor("CanSelect")]
	[NotifyPropertyChangedFor("ShowTabs")]
	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool Ordering
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_2F00() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00切(value ? ((byte)1) : ((byte)0));
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int Balance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_FF00딀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_0300((uint)value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[NotifyPropertyChangedFor("HasShopDescription")]
	public string ShopDescription
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00ﰀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00케(value);
		}
	}

	public bool HasShopDescription
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_2500() != 0;
		}
	}

	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public string Code
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_0900();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FE00(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public int SelectedIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)this._FF00_FF00_FFFD();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00됀((uint)value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int CurrentPage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_FF00저();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00ᔀ((uint)value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public double CustomCoinAmount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_EC00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00ጀ(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	public ObservableCollection<ProductModel> Products
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00쌀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			this._FF00_FF00_FFFD(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public ObservableCollection<ProductGroupModel> ProductGroups
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_2200();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00촀(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[NotifyPropertyChangedFor("SelectedProductGroup")]
	public int SelectedProductGroupIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_FF00_FF00㐀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_F300((uint)value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int SelectedTopUpTabIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_FF00_F700();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00묀((uint)value);
		}
	}

	public ProductGroupModel? SelectedProductGroup
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (ProductGroupModel?)_FF00_FF00뼀();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public ObservableCollection<TopUpModel> TopUps
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00픀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_F100(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public ObservableCollection<TopUpGroupModel> TopUpGroups
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00쬀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_E700(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[NotifyPropertyChangedFor("SelectedTopUpGroup")]
	[ObservableProperty]
	public int SelectedTopUpGroupIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_FF00_FF00_2600();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_0C00((uint)value);
		}
	}

	public TopUpGroupModel? SelectedTopUpGroup
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (TopUpGroupModel?)_FF00_FF00_FF00Ȁ();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public ObservableCollection<object> TopUpItems
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00휀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00렀(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public ObservableCollection<PayMethodModel> PayMethods
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00ᤀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00툀(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	public ObservableCollection<HistoryOrderModel> Orders
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00쐀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00ἀ(value);
		}
	}

	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public OrderModel Order
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (OrderModel)_FF00_FF00_E200();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_EA00(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand<TopUpArgs> TopUpCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_F800();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand RefreshShopCollectionCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00_FF00턀();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<HistoryOrderModel> RefreshHistoryOrderCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00뤀();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand RefreshHistoryOrderCollectionCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00_FF00_FF00_0700();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand<ProductModel> RedeemProductCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00㜀();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand RedeemCodeCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00_FF00쀀();
		}
	}

	public event Func<InfoBarDelegate>? GetInfoBar
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			_FF00_FF00_FF00_2800(value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			_FF00_FF00_FF00Ⰰ(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PaymentViewModel()
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
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitConv(Conv inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2307
		//    at ICSharpCode.Decompiler.IL.Conv.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2298
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildArgumentList(ExpectedTargetDetails expectedTargetDetails, ResolveResult target, IMethod method, Int32 firstParamIndex, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, Boolean writtenAsAssignment) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1070
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(OpCode callOpCode, IMethod method, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, IType constrainedTo) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 461
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(CallInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 255
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitCall(Call inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2530
		//    at ICSharpCode.Decompiler.IL.Call.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2192
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Default(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 93
		//    at ICSharpCode.Decompiler.IL.ILVisitor`1.VisitCall(Call inst) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 7663
		//    at ICSharpCode.Decompiler.IL.Call.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2188
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
		//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertSwitchSectionBody(SwitchSection astSection, ILInstruction bodyInst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 334
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.TranslateSwitch(BlockContainer switchContainer, SwitchInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 280
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
	private void UpdateSelect(object? sender, object e)
	{
		_FF00_FF00_FF00က(sender, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		_FF00_FF00_FF00ᰀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update(object user)
	{
		_FF00_FF00_FF00_3100(user);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CTopUp_003Ed__92))]
	private object TopUp(object args)
	{
		return _FF00_FF00_F500(args);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefreshShopCollection_003Ed__93))]
	[RelayCommand]
	private object RefreshShopCollection()
	{
		return _FF00_FF00_FF00_2300();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefreshHistoryOrder_003Ed__94))]
	[RelayCommand]
	private object RefreshHistoryOrder(object order)
	{
		return _FF00_FF00_FF00_3200(order);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefreshHistoryOrderCollection_003Ed__95))]
	[RelayCommand]
	private object RefreshHistoryOrderCollection()
	{
		return _FF00_FF00_FF00Ā();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedeemProduct_003Ed__96))]
	[RelayCommand]
	private object RedeemProduct(object productModel)
	{
		return _FF00_FF00였(productModel);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CRedeemCode_003Ed__97))]
	private object RedeemCode()
	{
		return _FF00_FF00뜀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InfoBar(object text, InfoBarSeverity severity = (InfoBarSeverity)0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_FF00_FF00_E000(text, severity);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnSelectedIndexChanged(uint value)
	{
		_FF00_FF00_E500(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnProductGroupsChanged(ObservableCollection<ProductGroupModel> value)
	{
		_FF00_FF00_FF00_1B00(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnTopUpGroupsChanged(ObservableCollection<TopUpGroupModel> value)
	{
		_FF00_FF00봀(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckConfigurableEngine()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PaymentViewModel DecorateSeparatedCompiler()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00넀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778567, new IntPtr(2737336170972L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00눀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0068: Expected I, but got Obj
		//IL_0057->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0062->IL0026: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			case 1:
				if (_003CModule_003E.CheckAccessibleAttribute() == null)
				{
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						_ = 0;
					}
					break;
				}
				return 0;
			default:
				return (IEnumerator_object.Do_Abi_MoveNext_2((nint)/*Error near IL_0068: Stack underflow*/, (byte*)(nint)this) == 0) ? ((byte)1) : ((byte)0);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00대(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778564, new IntPtr(2737336167852L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00됀(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_008e: Expected Obj, but got I
		//IL_0079: Expected I, but got Obj
		//IL_00b2: Expected Obj, but got I
		//IL_0098->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0083->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0067->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d8->IL0083: Incompatible stack heights: 2 vs 0
		//IL_00b7->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0072->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ec->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00c2->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00f7->IL0026: Incompatible stack heights: 3 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 3:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (int)P_0;
				obj2 = 2;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					obj2 = 2;
				}
				break;
			case 2:
				IEnumerator_object.Do_Abi_MoveNext_2((nint)this, (byte*)(int)P_0);
				_ = 6;
				break;
			case 1:
				MarshalInspectable<object>.FromAbiArray((object)IList_object._initialized);
				_ = 3;
				break;
			case 6:
				MarshalInspectable<object>.FromManaged((object)this, (byte)IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0);
				_ = 0;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
				{
					_ = 0;
				}
				break;
			case 5:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)/*Error near IL_00c7: Stack underflow*/, (uint)/*Error near IL_00c7: Stack underflow*/);
				_ = IReadOnlyList_object.ReflectLogicalAttribute;
				if (MarshalInterface<INotifyPropertyChanged>.FromAbi((IntPtr)(int)P_0) != null)
				{
					_ = 4;
					if (IEnumerable_System_IDisposable._initialized != 0)
					{
						_ = 4;
					}
					break;
				}
				goto case 1;
			case 0:
				return;
			case 4:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00딀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00똀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778565, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00뜀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17999, 1790778562, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778562, new IntPtr(2737336186572L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00렀(ObservableCollection<object> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00c4: Expected Obj, but got I
		//IL_0089: Expected I, but got Obj
		//IL_00ce->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00b9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00a8->IL0026: Incompatible stack heights: 3 vs 1
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
			case 0:
				return;
			case 1:
				return;
			case 2:
				ExceptionHelpers.GetHRForException((Exception)/*Error near IL_004e: Stack underflow*/);
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_0055: Member reference must be method, but was: Field*/;
			case 5:
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)IList_object.PatchAttribute);
				_ = 0;
				if (IReadOnlyList_System_IDisposable._initialized != 0)
				{
					_ = 0;
				}
				break;
			case 4:
				IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = P_0;
				obj2 = 5;
				break;
			case 3:
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
				_ = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<HistoryOrderModel> _FF00_FF00뤀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18001, 1790778563, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778563, new IntPtr(2737336181372L), 15);
		}
		return (IAsyncRelayCommand<HistoryOrderModel>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<HistoryOrderModel> _FF00_FF00먀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778560, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<HistoryOrderModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00묀(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0089: Expected I, but got Obj
		//IL_0089: Expected I4, but got Obj
		//IL_00cd: Expected Obj, but got I
		//IL_0069->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00dd->IL0026: Incompatible stack types: I4 vs Obj
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
			case 1:
				return;
			case 0:
				return;
			case 3:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (int)P_0;
				obj2 = 5;
				break;
			case 4:
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_006f: Member reference must be method, but was: Field*/;
			case 5:
				((ValueTuple<int, nint>*)/*Error near IL_0089: Stack underflow*/)->_002Ector((int)this, (nint)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute);
				obj2 = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				if (IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00b9: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)MarshalInspectable<object>.FromManaged((object)/*Error near IL_00ad: Stack underflow*/, (byte)/*Error near IL_00ad: Stack underflow*/ != 0), (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)IReadOnlyList_System_IDisposable._initialized, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(int)P_0))
				{
					obj2 = 1;
					if (IReadOnlyList_object.ReflectLogicalAttribute != null)
					{
						obj2 = 1;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00밀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778561, new IntPtr(2737336158492L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00봀(ObservableCollection<TopUpGroupModel> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0054->IL0026: Incompatible stack heights: 4 vs 1
		//IL_005f->IL0026: Incompatible stack heights: 4 vs 1
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
			case 0:
				return;
			case 1:
				_ = 0;
				_003CModule_003E.CheckAccessibleAttribute();
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00븀(ObservableCollection<TopUpGroupModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778574, new IntPtr(2737336180332L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00뼀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18007, 1790778575, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778575, new IntPtr(2737336170972L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00쀀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18008, 1790778572, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778572, new IntPtr(2737336167852L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00섀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778573, new IntPtr(2737336172012L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<ProductModel> _FF00_FF00숀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778570, new IntPtr(2737336180332L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<ProductModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<ProductModel> _FF00_FF00쌀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<ProductModel>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<HistoryOrderModel> _FF00_FF00쐀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<HistoryOrderModel>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00씀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778571, new IntPtr(2737336176172L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00였(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18014, 1790778568, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778568, new IntPtr(2737336168892L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00윀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778569, new IntPtr(2737336182412L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00저()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00준()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778582, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<TopUpGroupModel> _FF00_FF00쨀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778583, new IntPtr(2737336157452L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<TopUpGroupModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<TopUpGroupModel> _FF00_FF00쬀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<TopUpGroupModel>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00찀(ObservableCollection<ProductGroupModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778580, new IntPtr(2737336180332L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00촀(ObservableCollection<ProductGroupModel> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0097: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I
		//IL_00b2: Expected I, but got Obj
		//IL_00f8->IL0026: Incompatible stack heights: 2 vs 1
		//IL_009c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00dc->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00bc->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e7->IL0026: Incompatible stack heights: 3 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				ExceptionHelpers.GetHRForException((Exception)/*Error near IL_0051: Stack underflow*/);
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_0058: Member reference must be method, but was: Field*/;
			case 2:
				IList_object.PatchAttribute = P_0;
				obj2 = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
				{
					obj2 = 0;
				}
				break;
			case 6:
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00b2: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00b2: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)IReadOnlyList_System_IDisposable._initialized);
				_ = 2;
				break;
			case 1:
				return;
			case 3:
				return;
			case 5:
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
				_ = 1;
				if (IEnumerator_System_IDisposable.ReflectTransferableAttribute != null)
				{
					_ = 1;
				}
				break;
			default:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3((nint)/*Error near IL_00ee: Stack underflow*/, (uint)/*Error near IL_00ee: Stack underflow*/, (uint)/*Error near IL_00ee: Stack underflow*/, (nint)this, (uint*)(nint)P_0);
				_ = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00츀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778581, new IntPtr(2737336163692L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00케(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_009c: Expected I, but got Obj
		//IL_011b: Expected I, but got Obj
		//IL_0057: Expected I, but got Obj
		//IL_0066: Expected Obj, but got I
		//IL_00cb: Expected I, but got Obj
		//IL_0100: Expected Obj, but got I
		//IL_008b->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00a1->IL0125: Incompatible stack heights: 2 vs 0
		//IL_0125->IL0026: Incompatible stack heights: 3 vs 1
		//IL_006b->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00df->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0105->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b5->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0076->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00ea->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0110->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c0->IL0026: Incompatible stack heights: 3 vs 1
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
			case 4:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 6;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					_ = 5;
				}
				break;
			default:
				MarshalInspectable<object>.FromAbiArray((object)IList_object._initialized);
				_ = 4;
				break;
			case 1:
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)/*Error near IL_0090: Stack underflow*/);
				_ = IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute;
				if (!IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)P_0))
				{
					_ = 0;
					if (IReadOnlyList_object._initialized == 0)
					{
						_ = 0;
					}
					break;
				}
				return;
			case 5:
				MarshalInterface<INotifyPropertyChanged>.FromAbi((IntPtr)IReadOnlyList_object.ReflectLogicalAttribute);
				_ = 3;
				if (IEnumerable_System_IDisposable._initialized == 0)
				{
					_ = 3;
				}
				break;
			case 6:
				IEnumerable_System_IDisposable.CombineAttribute = P_0;
				obj2 = 2;
				if (IEnumerable_object.ReflectSetAttribute == null)
				{
					obj2 = 2;
				}
				break;
			case 2:
				IEnumerableMethods<INotifyPropertyChanged>.Abi_First_0((IntPtr)GlobalVtableLookup.CreateAttribute);
				_ = 5;
				break;
			case 3:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00퀀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778578, new IntPtr(2737336180332L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00턀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18025, 1790778579, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778579, new IntPtr(2737336154332L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00툀(ObservableCollection<PayMethodModel> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_004f: Expected I, but got Obj
		//IL_0058: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I
		//IL_0098: Expected I, but got Obj
		//IL_00d8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005d->IL0022: Incompatible stack heights: 1 vs 0
		//IL_007c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009d->IL00bc: Incompatible stack heights: 2 vs 0
		//IL_00e3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0087->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b1->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00bc->IL0026: Incompatible stack heights: 3 vs 1
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
				case 1:
					break;
				case 3:
					/*Error near IL_0068: Stack underflow*/((object[])(object)this, IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized);
					obj2 = 0;
					if (IList_object.PatchAttribute == null)
					{
						obj2 = 0;
					}
					continue;
				case 4:
					IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)/*Error near IL_008c: Stack underflow*/);
					_ = IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute;
					if (!IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)P_0))
					{
						_ = 3;
						if (IReadOnlyList_object._initialized != 0)
						{
							_ = 1;
						}
						continue;
					}
					return;
				case 2:
					return;
				default:
					IReadOnlyList_object.ReflectLogicalAttribute = P_0;
					obj2 = 1;
					if (IEnumerator_System_IDisposable.ReflectTransferableAttribute != null)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
			}
			IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00팀(ObservableCollection<PayMethodModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778576, new IntPtr(2737336172012L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<TopUpModel> _FF00_FF00퐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778577, new IntPtr(2737336179292L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<TopUpModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<TopUpModel> _FF00_FF00픀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<TopUpModel>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<TopUpModel> _FF00_FF00혀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778590, new IntPtr(2737336172012L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<TopUpModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<object> _FF00_FF00휀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<object>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FFFD()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778591, new IntPtr(2737336182412L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778588, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FFFD()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0047: Expected I, but got Obj
		//IL_007f: Expected I, but got Obj
		//IL_0071: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I4
		//IL_0077: Expected I4, but got Obj
		//IL_005b: Expected Obj, but got I
		//IL_0098: Expected Obj, but got I
		//IL_0060->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a8->IL0026: Incompatible stack types: I4 vs Obj
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
				if (IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)_003CModule_003E.CheckAccessibleAttribute()) == 0)
				{
					obj2 = 1;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						obj2 = 2;
					}
					break;
				}
				goto IL_0077;
			case 2:
				return (byte)(int)MarshalInspectable<object>.FromAbiArray((object)IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_0071: Stack underflow*/, (uint)/*Error near IL_0071: Stack underflow*/, (nint)/*Error near IL_0071: Stack underflow*/, (uint*)(nint)this));
			case 1:
				{
					if (MarshalInspectable<object>.FromManaged((object)/*Error near IL_0084: Stack underflow*/, (byte)IEnumerator_object.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_007f: Stack underflow*/, (byte*)(nint)this) != 0) == (IntPtr)0)
					{
						obj2 = 0;
						if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
						{
							obj2 = 0;
						}
						break;
					}
					goto IL_0077;
				}
				IL_0077:
				return 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778589, new IntPtr(2737336172012L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FFFD(ObservableCollection<ProductModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778586, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FFFD(ObservableCollection<ProductModel> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00c0: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I
		//IL_0050: Expected I, but got Obj
		//IL_0091: Expected I4, but got Obj
		//IL_0091: Expected Obj, but got I
		//IL_0061: Expected I, but got Obj
		//IL_00a5: Expected Obj, but got I
		//IL_00d4->IL0026: Incompatible stack heights: 3 vs 1
		//IL_005a->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0096->IL0044: Incompatible stack heights: 1 vs 0
		//IL_0075->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00df->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00aa->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0080->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b5->IL0026: Incompatible stack heights: 2 vs 1
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
			case 1:
				return;
			case 2:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 4;
				break;
			case 4:
				IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
				obj2 = 0;
				if (IList_object._initialized != 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				MarshalInspectable<object>.FromAbiArray((object)/*Error near IL_0085: Stack underflow*/);
				if (MarshalInspectable<object>.FromManaged((object)IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized, (byte)(int)P_0 != 0) != (IntPtr)0)
				{
					return;
				}
				_ = 2;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute != null)
				{
					_ = 1;
				}
				break;
			default:
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
				_ = 1;
				if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FFFD(ObservableCollection<ProductModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778587, new IntPtr(2737336182412L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_E000(object P_0, InfoBarSeverity P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected I, but got Unknown
		//IL_0076: Expected I, but got Obj
		//IL_008a->IL0026: Incompatible stack heights: 2 vs 1
		//IL_005d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0095->IL0026: Incompatible stack heights: 2 vs 1
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
					obj2 = 1;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj2 = 0;
					}
					break;
				}
				/*Error near IL_006f: Stack underflow*/((object[])/*Error near IL_006f: Stack underflow*/, initialized);
				IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_0076: Stack underflow*/, (uint)/*Error near IL_0076: Stack underflow*/, (nint)P_0, (uint*)(nint)P_1);
				_ = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					_ = 0;
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
	private unsafe void _FF00_FF00_E100(object P_0, InfoBarSeverity P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778584, new IntPtr(2737336158492L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_E200()
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
	internal unsafe void _FF00_FF00_E300(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_004b: Expected I4, but got Obj
		//IL_005c: Expected I, but got Obj
		//IL_006b: Expected Obj, but got I
		//IL_00f6: Expected I4, but got Obj
		//IL_00c6: Expected Obj, but got I
		//IL_00eb->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0070->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0100->IL0026: Incompatible stack heights: 2 vs 1
		//IL_011f->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0096->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00cb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007b->IL0026: Incompatible stack heights: 2 vs 1
		//IL_012a->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00a1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d6->IL0026: Incompatible stack types: I4 vs Obj
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
			case 1:
				return;
			case 4:
				return;
			case 3:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 6;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					_ = 0;
				}
				break;
			case 7:
				IList_object._initialized = (int)P_0;
				obj2 = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				if (IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00b2: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)MarshalInspectable<object>.FromManaged((object)/*Error near IL_00a6: Stack underflow*/, (byte)/*Error near IL_00a6: Stack underflow*/ != 0), (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)IReadOnlyList_System_IDisposable._initialized, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(int)P_0))
				{
					obj2 = 1;
					if (IReadOnlyList_object.ReflectLogicalAttribute != null)
					{
						obj2 = 1;
					}
					break;
				}
				goto case 3;
			default:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00e1: Stack underflow*/, (INotifyPropertyChanged)this, ref *(uint*)IEnumerator_System_IDisposable._initialized);
				_ = 5;
				break;
			case 5:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)/*Error near IL_00f6: Stack underflow*/, (uint)(int)this, ref *(INotifyPropertyChanged[]*)IEnumerable_System_IDisposable._initialized);
				_ = 4;
				break;
			case 6:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_get_Size_1((IntPtr)IEnumerable_object._initialized);
				_ = 5;
				if (Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute == null)
				{
					_ = 7;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_E400(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778585, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_E500(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0053->IL0026: Incompatible stack heights: 4 vs 1
		//IL_005e->IL0026: Incompatible stack heights: 4 vs 1
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
				_003CModule_003E.CheckAccessibleAttribute();
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
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
	private unsafe void _FF00_FF00_E600(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778406, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_E700(ObservableCollection<TopUpGroupModel> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_008d: Expected I, but got Obj
		//IL_00ec: Expected Obj, but got I
		//IL_00b7: Expected I4, but got Obj
		//IL_00b7: Expected I, but got Obj
		//IL_0117->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00a1->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00f1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00cb->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0122->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00ac->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00fc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d6->IL0026: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 6;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 0:
				return;
			case 5:
				return;
			case 6:
				ExceptionHelpers.GetHRForException((Exception)/*Error near IL_0052: Stack underflow*/);
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_0059: Member reference must be method, but was: Field*/;
			case 2:
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)IList_object.PatchAttribute);
				_ = 3;
				if (IReadOnlyList_System_IDisposable._initialized == 0)
				{
					_ = 0;
				}
				break;
			case 4:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)this, (uint)(int)IReadOnlyList_System_IDisposable.ReflectConnectedAttribute);
				_ = 0;
				if (IEnumerator_System_IDisposable._initialized == 0)
				{
					_ = 0;
				}
				break;
			case 3:
				IEnumerator_System_IDisposable.ReflectTransferableAttribute = P_0;
				obj2 = 0;
				if (IEnumerable_System_IDisposable.CombineAttribute == null)
				{
					obj2 = 1;
				}
				break;
			case 1:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
				_ = 4;
				if (GlobalVtableLookup.CreateAttribute == null)
				{
					_ = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_E800(ObservableCollection<TopUpGroupModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778407, new IntPtr(2737336183452L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_E900(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778404, new IntPtr(2737336172012L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_EA00(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_0085: Expected I, but got Obj
		//IL_00af: Expected I4, but got Obj
		//IL_00af: Expected I, but got Obj
		//IL_00ca->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0099->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00b9->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a4->IL0026: Incompatible stack heights: 3 vs 1
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
				return;
			case 2:
				ExceptionHelpers.GetHRForException((Exception)/*Error near IL_004a: Stack underflow*/);
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_0051: Member reference must be method, but was: Field*/;
			case 1:
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)IList_object.PatchAttribute);
				_ = 0;
				if (IReadOnlyList_System_IDisposable._initialized == 0)
				{
					_ = 0;
				}
				break;
			case 4:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)this, (uint)(int)IReadOnlyList_System_IDisposable.ReflectConnectedAttribute);
				_ = 3;
				break;
			default:
				IReadOnlyList_object.ReflectLogicalAttribute = P_0;
				obj2 = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_EB00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778405, new IntPtr(2737336172012L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe double _FF00_FF00_EC00()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected F8, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe double _FF00_FF00_ED00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778402, new IntPtr(2737336173052L), 15))(null, 0, new IntPtr(0L));
		return (double)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_EE00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778403, new IntPtr(2737336173052L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_EF00()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_F000(ObservableCollection<TopUpModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778400, new IntPtr(2737336173052L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_F100(ObservableCollection<TopUpModel> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_006f: Expected I4, but got Obj
		//IL_00a5: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I
		//IL_0083->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00aa->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d4->IL0026: Incompatible stack heights: 3 vs 1
		//IL_008e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00df->IL0026: Incompatible stack heights: 3 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				ExceptionHelpers.GetHRForException((Exception)/*Error near IL_0049: Stack underflow*/);
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_0050: Member reference must be method, but was: Field*/;
			default:
				((ValueTuple<int, nint>*)/*Error near IL_006f: Stack underflow*/)->_002Ector((int)this, (nint)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute);
				obj2 = 2;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					obj2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute = P_0;
				obj2 = 0;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
				{
					obj2 = 0;
				}
				break;
			case 3:
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
				_ = 1;
				if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_F200(ObservableCollection<TopUpModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778401, new IntPtr(2737336177212L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_F300(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_0057: Expected I, but got Obj
		//IL_008c: Expected I, but got Obj
		//IL_00b3: Expected Obj, but got I4
		//IL_00c2: Expected Obj, but got I
		//IL_00f2: Expected I4, but got Obj
		//IL_00fb: Expected Obj, but got I4
		//IL_0061->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a0->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00e7->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00c7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0100->IL0022: Incompatible stack heights: 1 vs 0
		//IL_00ab->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00d2->IL0026: Incompatible stack types: I4 vs Obj
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
				switch ((int)obj2)
				{
				default:
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
					_ = 6;
					continue;
				case 3:
					/*Error near IL_0061: Member reference must be method, but was: Field*/;
				case 1:
					IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)IList_object.PatchAttribute);
					_ = 0;
					if (IReadOnlyList_System_IDisposable._initialized != 0)
					{
						_ = 0;
					}
					continue;
				case 6:
					return;
				case 4:
					IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = P_0;
					obj2 = 1;
					if (IReadOnlyList_object.ReflectLogicalAttribute == null)
					{
						obj2 = 1;
					}
					continue;
				case 2:
					IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00dd: Stack underflow*/, (INotifyPropertyChanged)this, ref *(uint*)IEnumerator_System_IDisposable._initialized);
					_ = 5;
					continue;
				case 5:
					break;
				}
				break;
			}
			IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)/*Error near IL_00f2: Stack underflow*/, (uint)(int)this, ref *(INotifyPropertyChanged[]*)IEnumerable_System_IDisposable._initialized);
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_F400(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778414, new IntPtr(2737336182412L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_F500(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18061, 1790778415, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778415, new IntPtr(2737336184492L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_F600(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778412, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_F700()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<TopUpArgs> _FF00_FF00_F800()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18064, 1790778413, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778413, new IntPtr(2737336187612L), 15);
		}
		return (IAsyncRelayCommand<TopUpArgs>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<TopUpArgs> _FF00_FF00豈()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778410, new IntPtr(2737336157452L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<TopUpArgs>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00切(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0053: Expected I4, but got Obj
		//IL_0063: Expected I, but got Obj
		//IL_0072: Expected Obj, but got I
		//IL_0128: Expected I, but got Obj
		//IL_00fd: Expected I4, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I4
		//IL_0077->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0132->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0107->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00e7->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0097->IL0026: Incompatible stack heights: 3 vs 1
		//IL_011d->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00ad->IL0058: Incompatible stack heights: 2 vs 0
		//IL_00c8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0082->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00f2->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00b7->IL0026: Incompatible stack heights: 3 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 8;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 1;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 1;
				}
				break;
			case 5:
				MarshalInspectable<object>.FromAbiArray((object)IList_object._initialized);
				_ = 4;
				break;
			case 8:
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)/*Error near IL_009c: Stack underflow*/);
				_ = IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute;
				if (IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)(int)P_0))
				{
					_ = 7;
					break;
				}
				goto default;
			case 9:
				IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = P_0;
				obj2 = 5;
				break;
			case 4:
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
				_ = 6;
				if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
				{
					_ = 3;
				}
				break;
			case 2:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)/*Error near IL_00fd: Stack underflow*/, (uint)(int)this, ref *(INotifyPropertyChanged[]*)IEnumerable_System_IDisposable._initialized);
				_ = 9;
				break;
			case 3:
				return;
			case 7:
				return;
			case 6:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_get_Size_1((IntPtr)IEnumerable_object._initialized);
				_ = 3;
				break;
			case 1:
				IEnumerableMethods<INotifyPropertyChanged>.Abi_First_0((IntPtr)GlobalVtableLookup.CreateAttribute);
				_ = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00ﬀ(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778411, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00ﰀ()
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
	internal unsafe void _FF00_FF00ﴀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778408, new IntPtr(2737336180332L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FE00(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00e3: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I
		//IL_00aa: Expected I, but got Obj
		//IL_00b9: Expected Obj, but got I
		//IL_00e8->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0094->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00be->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00f3->IL0026: Incompatible stack heights: 2 vs 1
		//IL_009f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c9->IL0026: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				ExceptionHelpers.GetHRForException((Exception)/*Error near IL_0049: Stack underflow*/);
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_0050: Member reference must be method, but was: Field*/;
			case 1:
				IList_object.PatchAttribute = P_0;
				obj2 = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
				{
					obj2 = 0;
				}
				break;
			case 3:
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00aa: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00aa: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)IReadOnlyList_System_IDisposable._initialized);
				_ = 1;
				if (IReadOnlyList_object.ReflectLogicalAttribute == null)
				{
					_ = 1;
				}
				break;
			default:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00d4: Stack underflow*/, (INotifyPropertyChanged)this, ref *(uint*)IEnumerator_System_IDisposable._initialized);
				_ = 2;
				if (IEnumerable_System_IDisposable.CombineAttribute != null)
				{
					_ = 1;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778409, new IntPtr(2737336158492L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00Ā()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18072, 1790778422, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778422, new IntPtr(2737336158492L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00Ȁ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18073, 1790778423, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778423, new IntPtr(2737336155372L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_0300(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00a4: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got I
		//IL_00b8: Expected Obj, but got I
		//IL_0059->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a9->IL0059: Incompatible stack heights: 1 vs 0
		//IL_00dd->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00bd->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00c8->IL0026: Incompatible stack heights: 2 vs 1
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
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (int)P_0;
				obj2 = 4;
				break;
			case 3:
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_005f: Member reference must be method, but was: Field*/;
			case 1:
				return;
			case 5:
				return;
			case 2:
				MarshalInspectable<object>.FromAbiArray((object)/*Error near IL_0098: Stack underflow*/);
				if (MarshalInspectable<object>.FromManaged((object)IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized, (byte)P_0 != 0) != (IntPtr)0)
				{
					_ = 1;
					if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
					{
						_ = 1;
					}
					break;
				}
				goto case 3;
			case 4:
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
				_ = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00Ѐ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778420, new IntPtr(2737336172012L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00Ԁ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778421, new IntPtr(2737336172012L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_0600()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_0700()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18078, 1790778418, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778418, new IntPtr(2737336172012L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00ࠀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778419, new IntPtr(2737336173052L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_0900()
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
	internal unsafe object _FF00_FF00_FF00_0A00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778416, new IntPtr(2737336173052L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_0B00(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778417, new IntPtr(2737336182412L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_0C00(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_011c: Expected I, but got Obj
		//IL_007c: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I4
		//IL_00f2: Expected I4, but got Obj
		//IL_0101: Expected Obj, but got I
		//IL_0057: Expected I, but got Obj
		//IL_00d7: Expected Obj, but got I
		//IL_0126->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0081->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c8->IL0061: Incompatible stack heights: 2 vs 0
		//IL_0106->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0061->IL0026: Incompatible stack heights: 2 vs 1
		//IL_008c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00dc->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0111->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00b2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e7->IL0026: Incompatible stack heights: 3 vs 1
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
			case 6:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 4;
				break;
			case 1:
				return;
			case 2:
				/*Error near IL_006d: Stack underflow*/((object[])(object)this, IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized);
				obj2 = 0;
				if (IList_object.PatchAttribute != null)
				{
					obj2 = 0;
				}
				break;
			case 5:
				IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized = (int)P_0;
				obj2 = 6;
				if (IReadOnlyList_System_IDisposable._initialized == 0)
				{
					obj2 = 6;
				}
				break;
			case 3:
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00b7: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00b7: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_00b7: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)/*Error near IL_00b7: Stack underflow*/);
				_ = IReadOnlyList_object._initialized;
				if (MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)P_0) != (IntPtr)0)
				{
					return;
				}
				_ = 1;
				if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
				{
					_ = 2;
				}
				break;
			case 4:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)/*Error near IL_00f2: Stack underflow*/, (uint)(int)this, ref *(INotifyPropertyChanged[]*)IEnumerable_System_IDisposable._initialized);
				_ = 1;
				if (IEnumerable_object.ReflectSetAttribute == null)
				{
					_ = 1;
				}
				break;
			default:
				IEnumerableMethods<INotifyPropertyChanged>.Abi_First_0((IntPtr)GlobalVtableLookup.CreateAttribute);
				_ = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_0D00(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778430, new IntPtr(2737336163692L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_0E00(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_0097: Expected I, but got Obj
		//IL_00c3: Expected I, but got Obj
		//IL_0086->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00c8->IL0069: Incompatible stack heights: 1 vs 0
		//IL_00ad->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0091->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00dc->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00b8->IL00b8: Incompatible stack types: I4 vs Obj
		//IL_00e7->IL0026: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			object obj3;
			switch ((int)obj2)
			{
			case 2:
				return;
			case 1:
				return;
			default:
				_ = -2;
				IEnumerator_object.Init();
				_ = 2;
				if (IList_object._initialized != 0)
				{
					_ = 1;
				}
				continue;
			case 4:
			{
				uint num = IEnumerator_object.Do_Abi_get_Current_0((nint)/*Error near IL_0097: Stack underflow*/, (nint*)(nint)this);
				if (num == 0)
				{
					obj2 = 3;
					continue;
				}
				obj3 = IEnumerator_object.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_00b8: Stack underflow*/, (byte*)(int)num);
				break;
			}
			case 3:
				obj3 = null;
				break;
			}
			IEnumerator_object._002Ecctor();
			if (IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)P_1))
			{
				break;
			}
			_ = 0;
			if (IReadOnlyList_object._initialized != 0)
			{
				_ = 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00ༀ(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778431, new IntPtr(2737336185532L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00က(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_004c: Expected I, but got Obj
		//IL_0086: Expected I, but got Obj
		//IL_009a: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I
		//IL_0056->IL0026: Incompatible stack heights: 2 vs 1
		//IL_009f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0075->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00aa->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0080->IL0026: Incompatible stack types: I4 vs Obj
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
			case 0:
				return;
			case 1:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)_003CModule_003E.CheckAccessibleAttribute());
				_ = 3;
				break;
			case 3:
				/*Error near IL_0061: Stack underflow*/((object[])(object)this, (int)IEnumerator_object.Init());
				obj2 = 0;
				if (IList_object.PatchAttribute == null)
				{
					obj2 = 0;
				}
				break;
			case 2:
				MarshalInspectable<object>.FromManaged((object)/*Error near IL_008b: Stack underflow*/, (byte)IEnumerator_object.Do_Abi_get_HasCurrent_1((nint)/*Error near IL_0086: Stack underflow*/, (byte*)(nint)this) != 0);
				_ = 1;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute != null)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00ᄀ(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778428, new IntPtr(2737336173052L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00ሀ(double P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778429, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00ጀ(double P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00c0: Expected Obj, but got I
		//IL_0080: Expected Obj, but got F8
		//IL_00a4: Expected Obj, but got I
		//IL_00ca->IL0026: Incompatible stack heights: 3 vs 1
		//IL_008a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a9->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00b4->IL0026: Incompatible stack heights: 2 vs 1
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
				ExceptionHelpers.GetHRForException((Exception)/*Error near IL_0049: Stack underflow*/);
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_0050: Member reference must be method, but was: Field*/;
			case 3:
				IList_object.PatchAttribute = P_0;
				obj2 = 4;
				break;
			case 4:
				MarshalInspectable<object>.FromManaged((object)this, (byte)IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0);
				_ = 1;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
				{
					_ = 2;
				}
				break;
			case 2:
				return;
			default:
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
				_ = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_1400(double P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778426, new IntPtr(2737336176172L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00ᔀ(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00f7: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I4
		//IL_00a9: Expected Obj, but got I
		//IL_00fc->IL0026: Incompatible stack heights: 2 vs 1
		//IL_008e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ae->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0107->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00b9->IL0026: Incompatible stack heights: 2 vs 1
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
				return;
			case 3:
				ExceptionHelpers.GetHRForException((Exception)/*Error near IL_004d: Stack underflow*/);
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_0054: Member reference must be method, but was: Field*/;
			case 4:
				IList_object.PatchAttribute = P_0;
				obj2 = 5;
				break;
			case 0:
				return;
			case 2:
				return;
			case 5:
				MarshalInspectable<object>.FromManaged((object)this, (byte)IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0);
				_ = 0;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
				{
					_ = 0;
				}
				break;
			case 1:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00e8: Stack underflow*/, (INotifyPropertyChanged)this, ref *(uint*)IEnumerator_System_IDisposable._initialized);
				_ = 4;
				if (IEnumerable_System_IDisposable.CombineAttribute == null)
				{
					_ = 3;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00ᘀ()
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
	internal unsafe static object _FF00_FF00_FF00ᜀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778427, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<PayMethodModel> _FF00_FF00_FF00_1800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778424, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<PayMethodModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<PayMethodModel> _FF00_FF00_FF00ᤀ()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<PayMethodModel>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<PayMethodModel> _FF00_FF00_FF00ᨀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778425, new IntPtr(2737336157452L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<PayMethodModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_1B00(ObservableCollection<ProductGroupModel> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0053->IL0026: Incompatible stack heights: 4 vs 1
		//IL_005e->IL0026: Incompatible stack heights: 4 vs 1
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
				_ = 0;
				_003CModule_003E.CheckAccessibleAttribute();
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
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
	internal sealed void _FF00_FF00_FF00ᰀ()
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
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Default(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 93
		//    at ICSharpCode.Decompiler.IL.ILVisitor`1.VisitLdFtn(LdFtn inst) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 7747
		//    at ICSharpCode.Decompiler.IL.LdFtn.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 3171
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
		//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertSwitchSectionBody(SwitchSection astSection, ILInstruction bodyInst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 334
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.TranslateSwitch(BlockContainer switchContainer, SwitchInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 280
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1334
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
	internal unsafe sealed void _FF00_FF00_FF00ᴀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778374, new IntPtr(2737336188652L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00Ḁ(ObservableCollection<HistoryOrderModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778375, new IntPtr(2737336182412L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00ἀ(ObservableCollection<HistoryOrderModel> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0053: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_0084: Expected I, but got Obj
		//IL_009e: Expected I, but got Obj
		//IL_00be: Expected Obj, but got I
		//IL_0067->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0089->IL0093: Incompatible stack heights: 1 vs 0
		//IL_00a8->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00c3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0093->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00ce->IL0026: Incompatible stack types: I4 vs Obj
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
				return;
			case 1:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			case 2:
				return;
			case 3:
				*((int, nint)*)(nint)/*Error near IL_0078: Stack underflow*/ = ((int)/*Error near IL_0078: Stack underflow*/, (nint)/*Error near IL_0078: Stack underflow*/);
				_ = IList_object.PatchAttribute;
				if (IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)P_0) != null)
				{
					_ = 2;
					break;
				}
				goto case 4;
			case 4:
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute);
				_ = 5;
				break;
			case 5:
				IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = P_0;
				obj2 = 1;
				if (IReadOnlyList_object.ReflectLogicalAttribute != null)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_2000(ObservableCollection<HistoryOrderModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778372, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<ProductGroupModel> _FF00_FF00_FF00_2100()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778373, new IntPtr(2737336157452L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<ProductGroupModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<ProductGroupModel> _FF00_FF00_FF00_2200()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<ProductGroupModel>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_2300()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18106, 1790778370, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778370, new IntPtr(2737336179292L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_2400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778371, new IntPtr(2737336173052L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_2500()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001f: Expected I, but got Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)_003CModule_003E.CheckAccessibleAttribute()) == 0) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_2600()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_2700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778368, new IntPtr(2737336185532L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_2800(Func<InfoBarDelegate> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got VT
		//IL_0087: Expected Obj, but got I
		//IL_00b2->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0069->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ce->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008c->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00d9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0097->IL0026: Incompatible stack heights: 2 vs 1
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
				if (obj == obj)
				{
					obj2 = 5;
					break;
				}
				goto case 1;
			case 1:
				obj = obj;
				obj2 = 4;
				break;
			case 4:
				obj = ((int, nint))(object)ExceptionHelpers.GetHRForException((Exception)(object)P_0);
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					_ = 0;
				}
				break;
			default:
				_ = ref IList_object._initialized;
				obj = CastExtensions.As<MainContent>(obj);
				_ = 3;
				break;
			case 2:
				obj = IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized;
				obj2 = 1;
				if (IReadOnlyList_System_IDisposable._initialized == 0)
				{
					obj2 = 1;
				}
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_2900()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0072: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0096->IL0026: Incompatible stack types: I4 vs Obj
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
				return (IEnumerator_object.Init() == 0) ? ((byte)1) : ((byte)0);
			case 1:
				return 0;
			case 2:
				if (IEnumerator_object.Do_Abi_MoveNext_2((nint)/*Error near IL_0072: Stack underflow*/, (byte*)(nint)this) != 0)
				{
					obj2 = 1;
					if (IList_object.PatchAttribute != null)
					{
						obj2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_2A00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778369, new IntPtr(2737336182412L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_2B00(Func<InfoBarDelegate> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778382, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00Ⰰ(Func<InfoBarDelegate> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_0069: Expected Obj, but got I
		//IL_00de: Expected I, but got Obj
		//IL_00de: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I4
		//IL_00d6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0095->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006e->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00ef->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00bd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0079->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00c8->IL0026: Incompatible stack types: I4 vs Obj
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
				return;
			case 4:
				_ = ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
				obj = CastExtensions.As<Frame>(obj);
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 0;
				}
				break;
			case 2:
				obj = IList_object._initialized;
				obj2 = 1;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 1;
				}
				break;
			default:
				if (obj == obj)
				{
					obj2 = 3;
					if (IReadOnlyList_System_IDisposable._initialized != 0)
					{
						obj2 = 3;
					}
					break;
				}
				goto case 1;
			case 1:
				obj = obj;
				obj2 = 5;
				break;
			case 5:
				obj = (IListMethods<object>)(object)IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00de: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00de: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)obj, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)P_0);
				obj2 = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00ⴀ(Func<InfoBarDelegate> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778383, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_2E00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778380, new IntPtr(2737336185532L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_2F00()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_3000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778381, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_3100(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0053: Expected Obj, but got I
		//IL_0058->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0063->IL0026: Incompatible stack heights: 4 vs 1
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
				ExceptionHelpers.GetHRForException((Exception)P_0);
				_ = IEnumerator_object.Initialized;
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
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
	private unsafe object _FF00_FF00_FF00_3200(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18121, 1790778378, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778378, new IntPtr(2737336176172L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_3300(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778379, new IntPtr(2737336173052L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00㐀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00㔀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778376, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<ProductModel> _FF00_FF00_FF00㘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778377, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<ProductModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<ProductModel> _FF00_FF00_FF00㜀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18126, 1790778390, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778390, new IntPtr(2737336173052L), 15);
		}
		return (IAsyncRelayCommand<ProductModel>)((delegate*<object, object>)obj)(this);
	}
}
