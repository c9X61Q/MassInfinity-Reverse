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
using System.Threading.Tasks;
using ABI.System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.WinUI.Animations;
using Mass.WinUI.Mass_WinUI_XamlTypeInfo;
using Mass.WinUI.Models;
using Microsoft.UI.Xaml;
using Microsoft.Xaml.Interactivity;
using WinRT;
using WinRT.Mass_WinUIGenericHelpers;
using WinRT.Mass_WinUIVtableClasses;
using Windows.Storage;

namespace Mass.WinUI.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails))]
public class ImportAccountViewModel : ObservableObject, IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CParseFile_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ImportAccountViewModel _003C_003E4__this;

		private TaskAwaiter<string[]> _003C_003Eu__1;

		internal static object ConvertHandler;

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
		internal static bool RateStruct()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QueryReporter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00嬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777699, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00尀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0060: Expected Obj, but got Ref
			//IL_00b1: Expected Obj, but got Ref
			//IL_00b3: Expected Obj, but got I
			//IL_008a: Expected Obj, but got Ref
			//IL_009b: Expected Obj, but got I
			//IL_0050: Expected Obj, but got Ref
			//IL_0532: Expected Obj, but got I4
			//IL_029e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Expected I, but got Obj
			//IL_02b2: Expected Obj, but got I4
			//IL_010b: Expected I4, but got Obj
			//IL_03b4: Expected Obj, but got Ref
			//IL_037b: Expected I, but got Obj
			//IL_02c1: Expected Obj, but got I4
			//IL_02c6: Expected Obj, but got I4
			//IL_02c6: Expected Obj, but got Ref
			//IL_01d1: Expected Obj, but got Ref
			//IL_01b8: Expected I, but got Obj
			//IL_0271: Expected Obj, but got I4
			//IL_0276: Expected Obj, but got I4
			//IL_0276: Expected Obj, but got Ref
			//IL_0231: Expected Obj, but got Ref
			//IL_030e: Expected Obj, but got Ref
			//IL_01c6: Expected Obj, but got I4
			//IL_0267: Expected Obj, but got I4
			//IL_0454: Expected Obj, but got I4
			//IL_0439: Expected Obj, but got I
			//IL_0434: Unknown result type (might be due to invalid IL or missing references)
			//IL_0439: Unknown result type (might be due to invalid IL or missing references)
			//IL_043f: Expected Obj, but got Unknown
			//IL_017f: Expected I4, but got Obj
			//IL_00eb->IL00fa: Incompatible stack types: I4 vs Obj
			//IL_00c7->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00a0->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00f6->IL00fa: Incompatible stack types: I4 vs Obj
			//IL_00d2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ab->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02bc->IL0126: Incompatible stack types: I4 vs Obj
			//IL_0122->IL0126: Incompatible stack types: I4 vs Obj
			//IL_03d0->IL0126: Incompatible stack types: I4 vs Obj
			//IL_0372->IL0126: Incompatible stack heights: 3 vs 1
			//IL_01a6->IL0126: Incompatible stack heights: 2 vs 1
			//IL_0306->IL0126: Incompatible stack heights: 4 vs 1
			//IL_0220->IL0126: Incompatible stack heights: 6 vs 1
			//IL_038a->IL0126: Incompatible stack heights: 4 vs 1
			//IL_02d0->IL0126: Incompatible stack types: I4 vs Obj
			//IL_01eb->IL0126: Incompatible stack types: I4 vs Obj
			//IL_028a->IL0126: Incompatible stack types: I4 vs Obj
			//IL_0247->IL0126: Incompatible stack types: I4 vs Obj
			//IL_0322->IL0126: Incompatible stack types: I4 vs Obj
			//IL_0413->IL0413: Incompatible stack heights: 3 vs 2
			//IL_03db->IL0126: Incompatible stack types: I4 vs Obj
			//IL_01b1->IL0126: Incompatible stack heights: 2 vs 1
			//IL_022b->IL0126: Incompatible stack heights: 6 vs 1
			//IL_01f6->IL0126: Incompatible stack types: I4 vs Obj
			//IL_0295->IL0126: Incompatible stack types: I4 vs Obj
			//IL_0252->IL0126: Incompatible stack types: I4 vs Obj
			//IL_032d->IL0126: Incompatible stack types: I4 vs Obj
			//IL_043f->IL043f: Incompatible stack heights: 3 vs 2
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 4;
			object obj = awaiter;
			while (true)
			{
				switch ((int)obj)
				{
				case 5:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = -2;
					obj = 2;
					break;
				case 2:
					_ = ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
					/*Error near IL_0060: Member reference must be method, but was: Field*/;
				case 4:
					awaiter = IList_object.PatchAttribute;
					obj = 2;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
					{
						obj = 3;
					}
					break;
				case 3:
					awaiter = IReadOnlyList_System_IDisposable._initialized;
					obj = 0;
					if (IReadOnlyList_object._initialized == 0)
					{
						obj = 0;
					}
					break;
				case 1:
					return;
				default:
				{
					object obj2 = 1;
					if (IEnumerator_System_IDisposable._initialized != 0)
					{
						obj2 = 0;
					}
					while (true)
					{
						object obj3;
						bool s_hasTimeout;
						switch ((int)obj2)
						{
						case 2:
							if (awaiter == null)
							{
								obj3 = 4;
								goto IL_0126;
							}
							goto IL_0295;
						case 1:
							goto IL_0528;
							IL_0126:
							while (true)
							{
								switch ((int)obj3)
								{
								case 7:
								case 19:
									break;
								case 8:
									return;
								case 6:
									IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3((nint)/*Error near IL_0192: Stack underflow*/, (uint)/*Error near IL_0192: Stack underflow*/, (uint)/*Error near IL_0192: Stack underflow*/, (nint)/*Error near IL_0192: Stack underflow*/, (uint*)(IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_018d: Stack underflow*/, (INotifyPropertyChanged)awaiter, ref *(uint*)awaiter) ? 1 : 0));
									_ = 8;
									if (IEnumerable_object._initialized == 0)
									{
										_ = 10;
									}
									continue;
								case 15:
									if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_get_Size_1((IntPtr)awaiter) != 0)
									{
										awaiter = 3;
										goto IL_0122;
									}
									goto case 11;
								case 14:
									GlobalVtableLookup.CreateAttribute = null;
									obj3 = 17;
									if (Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute != null)
									{
										obj3 = 3;
									}
									continue;
								case 11:
									_ = Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute;
									IEnumerable_System_ComponentModel_INotifyPropertyChanged.DecorateSeparatedAttribute();
									IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectMonoAttribute();
									_ = IList_object.Initialized;
									_ = 19;
									if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute != null)
									{
										_ = 15;
									}
									continue;
								case 4:
								case 18:
									awaiter = Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails.DecorateSegmentedAttribute;
									obj3 = 14;
									if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute == null)
									{
										obj3 = 0;
									}
									continue;
								case 16:
									IListMethods<object>.Abi_RemoveAtEnd_8((IntPtr)(nint)(&awaiter));
									if ((int)/*Error near IL_025e: Stack underflow*/ != 0)
									{
										awaiter = 9;
										goto IL_0122;
									}
									goto case 13;
								case 17:
									awaiter = -1;
									_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.ReflectLiteralAttribute = -1;
									obj3 = 0;
									if ((int)_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout == 0)
									{
										obj3 = 0;
									}
									continue;
								case 2:
									goto end_IL_0126;
								case 13:
									awaiter = 0;
									__KnownINotifyPropertyChangingArgs.Username = (PropertyChangingEventArgs)0;
									obj3 = 20;
									continue;
								case 10:
									_ = 1;
									_ = IEnumerator_System_ComponentModel_INotifyPropertyChanged.Initialized;
									_ = 7;
									continue;
								case 20:
									__KnownINotifyPropertyChangingArgs.IsMyself = (PropertyChangingEventArgs)awaiter;
									obj3 = 1;
									if (__KnownINotifyPropertyChangingArgs.CharacterName != null)
									{
										obj3 = 1;
									}
									continue;
								case 3:
								case 5:
									_ = null;
									IEnumerator_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
									_ = 12;
									continue;
								case 12:
									new IReadOnlyListMethods<IDisposable>((IntPtr)awaiter);
									IEnumerator_System_ComponentModel_INotifyPropertyChanged.DecorateConcreteAttribute();
									_ = 6;
									continue;
								case 1:
									Unsafe.As<PropertyChangingEventArgs, AsyncTaskMethodBuilder>(ref __KnownINotifyPropertyChangingArgs.Author).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<string>*)(&awaiter), ref Unsafe.As<_003CParseFile_003Ed__48, AccountViewModel._003CLoginMobile_003Ed__88>(ref this));
									obj3 = 8;
									if (__KnownINotifyPropertyChangingArgs.ImageUrl == null)
									{
										obj3 = 1;
									}
									continue;
								default:
									{
										uint num = IEnumeratorMethods<IDisposable>.Abi_GetMany_3((IntPtr)/*Error near IL_03f5: Stack underflow*/, ref *(IDisposable[]*)(&awaiter));
										PropertyChangingEventArgs backgroundImageUrl = __KnownINotifyPropertyChangingArgs.BackgroundImageUrl;
										if (backgroundImageUrl == null)
										{
											_ = null;
											__KnownINotifyPropertyChangingArgs.PreviewImage = (PropertyChangingEventArgs)new IEnumerableMethods<IDisposable, nint>((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(delegate*<IReadOnlyList_System_IDisposable>)(&IReadOnlyList_System_IDisposable.VerifyAttribute));
										}
										((AsyncTaskMethodBuilder*)num)->Start(ref *(_003CPrimaryAsync_003Ed__46*)backgroundImageUrl);
										List<NeteaseAccount> list = ((IEnumerable<NeteaseAccount>)/*Error near IL_041d: Stack underflow*/).ToList();
										PropertyChangingEventArgs executor = __KnownINotifyPropertyChangingArgs.Executor;
										if (executor == null)
										{
											_ = __KnownINotifyPropertyChangingArgs.LaunchTime;
											__KnownINotifyPropertyChangingArgs.OperationText = (PropertyChangingEventArgs)new ComWrappersSupport((Func<Type, string>)(delegate*<void>)(&IReadOnlyList_object._002Ecctor));
										}
										((AsyncTaskMethodBuilder*)/*Error near IL_0449: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)list, ref *(_003CPrimaryAsync_003Ed__46*)((IEnumerable<AccountModel>)executor).ToList());
										awaiter = (object)/*Error near IL_044b: Stack underflow*/;
										awaiter = 15;
										goto IL_0122;
									}
									IL_0122:
									obj3 = awaiter;
									continue;
								}
								goto end_IL_00fa;
								continue;
								end_IL_0126:
								break;
							}
							goto IL_0295;
							IL_0295:
							s_hasTimeout = _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_hasTimeout;
							awaiter = (object)default(IListMethods<>);
							awaiter = IEnumeratorMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)(s_hasTimeout ? 1 : 0), ref *(IEnumeratorMethods<INotifyPropertyChanged>.Abi_MoveNext_2((IntPtr)awaiter) ? ((INotifyPropertyChanged[]*)1) : ((INotifyPropertyChanged[]*)null)));
							obj3 = 16;
							goto IL_0126;
							end_IL_00fa:
							break;
						}
						break;
						IL_0528:
						awaiter = 2;
						obj2 = awaiter;
					}
					goto case 5;
				}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00崀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777696, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00帀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00开()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777697, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00怀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777710, new IntPtr(2737335739276L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00愀()
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00戀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777711, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00挀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777708, new IntPtr(2737335739276L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00搀(object P_0)
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
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPrimaryAsync_003Ed__46 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ImportAccountViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object ReflectAlphabeticCollection;

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
		internal static bool CheckEditableProfile()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckLogicalChooser()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00刀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777709, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00匀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_03ac: Expected Obj, but got Ref
			//IL_0370: Expected Obj, but got Ref
			//IL_0397: Expected Obj, but got Ref
			//IL_034a: Expected Obj, but got I4
			//IL_034a: Expected Obj, but got Ref
			//IL_0059: Expected Obj, but got I4
			//IL_027c: Expected Obj, but got Ref
			//IL_027c: Expected I4, but got Obj
			//IL_00e2: Expected Obj, but got Ref
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0245: Expected Obj, but got Ref
			//IL_014e: Expected I4, but got Obj
			//IL_014e: Expected I, but got Obj
			//IL_00f9: Expected Obj, but got Ref
			//IL_0109: Expected Obj, but got Ref
			//IL_0111: Expected Obj, but got Ref
			//IL_01ad: Expected Obj, but got Ref
			//IL_01af: Expected Obj, but got I
			//IL_012f: Expected Obj, but got I4
			//IL_0134: Expected Obj, but got Ref
			//IL_013d: Expected Obj, but got I4
			//IL_0198: Expected Obj, but got I4
			//IL_019d: Expected Obj, but got I4
			//IL_019d: Expected Obj, but got Ref
			//IL_01fc: Expected I, but got Obj
			//IL_01fc: Expected I, but got Obj
			//IL_03b8->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0386->IL0026: Incompatible stack types: I4 vs Obj
			//IL_03a6->IL0026: Incompatible stack heights: 2 vs 1
			//IL_035e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0391->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0369->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00af->IL00b4: Incompatible stack heights: 1 vs 0
			//IL_0062->IL0062: Incompatible stack heights: 1 vs 2
			//IL_0281->IL00f2: Incompatible stack heights: 0 vs 1
			//IL_0103->IL0062: Incompatible stack heights: 3 vs 2
			//IL_011b->IL0062: Incompatible stack heights: 5 vs 2
			//IL_0142->IL005e: Incompatible stack heights: 1 vs 0
			//IL_0210->IL0062: Incompatible stack types: I4 vs Obj
			//IL_028b->IL0062: Incompatible stack heights: 1 vs 2
			//IL_021b->IL0062: Incompatible stack types: I4 vs Obj
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			object obj2 = obj;
			while (true)
			{
				int num;
				object obj3;
				switch ((int)obj2)
				{
				case 5:
					if (obj == null)
					{
						obj = 10;
						goto IL_0062;
					}
					goto IL_00b4;
				case 4:
					goto IL_0342;
				case 3:
					return;
				case 1:
					obj = __KnownINotifyPropertyChangingArgs.Name;
					obj2 = 0;
					if (__KnownINotifyPropertyChangingArgs.Message == null)
					{
						obj2 = 0;
					}
					break;
				case 2:
					IReadOnlyListMethods<IDisposable>.Abi_GetMany_3((IntPtr)/*Error near IL_039c: Stack underflow*/, (uint)/*Error near IL_039c: Stack underflow*/, ref Unsafe.As<PropertyChangingEventArgs, IDisposable[]>(ref __KnownINotifyPropertyChangingArgs.CharacterName));
					_ = 3;
					break;
				default:
					{
						obj = __KnownINotifyPropertyChangingArgs.IsSelected;
						obj2 = 5;
						break;
					}
					IL_0342:
					__KnownINotifyPropertyChangingArgs.Username = (PropertyChangingEventArgs)(-2);
					obj2 = 2;
					if (__KnownINotifyPropertyChangingArgs.LoginAt == null)
					{
						obj2 = 1;
					}
					break;
					IL_0062:
					while (true)
					{
						switch (num)
						{
						case 12:
							break;
						case 3:
							IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute = (object)default(Window);
							num = 15;
							continue;
						case 8:
							MarshalInspectable<object>.FromAbiArray((object)(&obj));
							_ = 5;
							continue;
						case 9:
							_ = ref IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized;
							_ = ref obj;
							CastExtensions.As<ImplicitAnimationSet>((object)Unsafe.AsPointer(ref this));
							_ = 17;
							continue;
						case 14:
							obj = 0;
							IReadOnlyList_System_IDisposable._initialized = 0;
							obj = 4;
							continue;
						case 7:
							obj = IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)obj, (uint)(int)IEnumerator_object.LoadAttribute());
							num = 1;
							if (IEnumerator_System_IDisposable._initialized == 0)
							{
								num = 1;
							}
							continue;
						case 17:
							return;
						case 15:
							obj = -1;
							IEnumerable_System_IDisposable.CombineAttribute = -1;
							num = 8;
							continue;
						case 10:
						case 13:
							obj = IEnumerable_object._initialized;
							num = 3;
							if (GlobalVtableLookup.CreateAttribute == null)
							{
								num = 0;
							}
							continue;
						case 6:
							if ((nint)obj != 1)
							{
								num = 11;
								if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute == null)
								{
									num = 7;
								}
								continue;
							}
							goto case 16;
						case 16:
						{
							uint num2 = IEnumerable_System_ComponentModel_INotifyPropertyChanged.Do_Abi_First_0((nint)obj3, (nint*)(nint)obj);
							num = 1;
							obj3 = num2;
							if (Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute == null)
							{
								num = 2;
								obj3 = num2;
							}
							continue;
						}
						case 4:
							Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute = obj;
							num = 5;
							if (Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute == null)
							{
								num = 9;
							}
							continue;
						default:
							if (obj != null)
							{
								num = 6;
								continue;
							}
							goto case 7;
						case 1:
							IListMethods<object>.Abi_SetAt_4((IntPtr)/*Error near IL_027c: Stack underflow*/, (uint)(int)obj3, (object)(&obj));
							if ((int)/*Error near IL_0281: Stack underflow*/ == 0)
							{
								_ = 14;
								continue;
							}
							goto case 8;
						case 2:
						case 5:
						case 11:
							goto IL_0342;
						}
						break;
					}
					goto IL_00b4;
					IL_00b4:
					obj3 = obj;
					obj = _003CModule_003E.CheckAccessibleAttribute();
					num = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						num = 0;
					}
					goto IL_0062;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00吀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777706, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00唀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00嘀()
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00圀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777707, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00堀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00夀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777704, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSelectFile_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ImportAccountViewModel _003C_003E4__this;

		private TaskAwaiter<StorageFile> _003C_003Eu__1;

		internal static object ReflectSimpleSolver;

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
		internal static bool WatchProfiler()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectTransferableTracer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00䤀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777705, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00䨀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_02df: Expected Obj, but got Ref
			//IL_0342: Expected Obj, but got Ref
			//IL_0330: Expected Obj, but got Ref
			//IL_030b: Expected Obj, but got I4
			//IL_030b: Expected Obj, but got Ref
			//IL_0240: Expected Obj, but got Ref
			//IL_00cd: Expected Obj, but got Ref
			//IL_00d5: Expected Obj, but got Ref
			//IL_01ee: Expected Obj, but got I4
			//IL_01f3: Expected Obj, but got I4
			//IL_01f3: Expected Obj, but got Ref
			//IL_01af: Expected I4, but got Obj
			//IL_01af: Expected I, but got Obj
			//IL_00ff: Expected I, but got Obj
			//IL_0109: Expected I4, but got Obj
			//IL_0113: Expected I4, but got Obj
			//IL_0113: Expected I, but got Obj
			//IL_011a: Expected Obj, but got I4
			//IL_012c: Expected Obj, but got I4
			//IL_00a8: Expected I, but got Obj
			//IL_00a8: Expected Obj, but got Ref
			//IL_0153: Expected Obj, but got Ref
			//IL_0177: Expected Obj, but got I4
			//IL_017c: Expected Obj, but got I4
			//IL_017c: Expected Obj, but got Ref
			//IL_0219: Expected Obj, but got Ref
			//IL_01c5: Expected Obj, but got Ref
			//IL_02f8->IL0026: Incompatible stack heights: 2 vs 1
			//IL_034e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_033c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_031f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0303->IL0026: Incompatible stack heights: 2 vs 1
			//IL_032a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00e9->IL005e: Incompatible stack heights: 4 vs 1
			//IL_01be->IL005e: Incompatible stack heights: 3 vs 1
			//IL_00f4->IL005e: Incompatible stack heights: 4 vs 1
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
				case 5:
					if (obj != null)
					{
						num = 6;
						goto IL_005e;
					}
					goto IL_023a;
				default:
					IReadOnlyListMethods<IDisposable>.Abi_GetAt_0((IntPtr)/*Error near IL_02e4: Stack underflow*/, (uint)Unsafe.AsPointer(ref __KnownINotifyPropertyChangingArgs.LoginAt));
					_ = 1;
					if (__KnownINotifyPropertyChangingArgs.Message == null)
					{
						_ = 0;
					}
					break;
				case 4:
					goto IL_0303;
				case 3:
					obj = __KnownINotifyPropertyChangingArgs.IsSkeleton;
					obj2 = 2;
					break;
				case 2:
					obj = __KnownINotifyPropertyChangingArgs.CanProxy;
					obj2 = 5;
					break;
				case 1:
					return;
					IL_005e:
					while (true)
					{
						switch (num)
						{
						case 7:
							IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)obj;
							num = 0;
							if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
							{
								num = 2;
							}
							continue;
						case 2:
							_ = ref IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute;
							_ = ref obj;
							CastExtensions.As<InvokeCommandAction>((object)Unsafe.AsPointer(ref this));
							_ = 1;
							if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
							{
								_ = 1;
							}
							continue;
						case 6:
						{
							MarshalInspectable<object> val = (MarshalInspectable<object>)(nint)new MarshalInspectable<object>((object)/*Error near IL_00f9: Stack underflow*/, (byte)/*Error near IL_00f9: Stack underflow*/ != 0);
							obj = IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_0118: Stack underflow*/, (INotifyPropertyChanged)/*Error near IL_0118: Stack underflow*/, ref *(uint*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)val, (uint)(int)IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)(IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)val) ? 1 : 0), (uint)(int)IEnumerator_object.LoadAttribute()), (nint*)(int)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init()));
							obj = ((XamlUserType)/*Error near IL_012c: Stack underflow*/).BoxType<double>((object)IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)/*Error near IL_0127: Stack underflow*/, (uint)/*Error near IL_011a: Stack underflow*/, ref *(INotifyPropertyChanged[]*)MarshalInterface<INotifyPropertyChanged>.FromAbiArray(obj)));
							num = 13;
							if (GlobalVtableLookup.CreateAttribute != null)
							{
								num = 11;
							}
							continue;
						}
						case 10:
							Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute = null;
							num = 4;
							continue;
						case 1:
							return;
						case 11:
							obj = 0;
							Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute = 0;
							num = 7;
							continue;
						default:
							if (obj == null)
							{
								num = 3;
								continue;
							}
							goto case 5;
						case 5:
							IListMethods<object>.Abi_GetAt_0((IntPtr)obj, (uint)(int)obj);
							IEnumerable_System_ComponentModel_INotifyPropertyChanged.DecorateSeparatedAttribute();
							_ = 9;
							continue;
						case 13:
							if (MarshalInterface<IReadOnlyList<object>>.FromManaged((IReadOnlyList<object>)(&obj)) == (IntPtr)0)
							{
								num = 11;
								if (Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute == null)
								{
									num = 2;
								}
								continue;
							}
							goto case 12;
						case 4:
							obj = -1;
							Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute = -1;
							num = 12;
							if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute != null)
							{
								num = 4;
							}
							continue;
						case 12:
							IListMethods<object>.Abi_Append_7((IntPtr)/*Error near IL_0219: Stack underflow*/, (object)(&obj));
							obj = (object)/*Error near IL_021b: Stack underflow*/;
							num = 0;
							if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.ReflectLiteralAttribute != null)
							{
								num = 0;
							}
							continue;
						case 8:
							break;
						case 3:
						case 9:
							goto IL_0303;
						}
						break;
					}
					goto IL_023a;
					IL_0303:
					__KnownINotifyPropertyChangingArgs.CharacterName = (PropertyChangingEventArgs)(-2);
					obj2 = 0;
					if (__KnownINotifyPropertyChangingArgs.IsSelected == null)
					{
						obj2 = 0;
					}
					break;
					IL_023a:
					obj = _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner.CheckOperationalModule;
					num = 10;
					goto IL_005e;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00䬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777718, new IntPtr(2737335738236L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00䰀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777719, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00䴀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00一()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777716, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00伀()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00倀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00儀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777717, new IntPtr(2737335708076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	private object _filePath;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? selectFileCommand;

	private static object DecorateAdjustableRecord;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsDragging
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 脀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			ꠀ(value ? ((byte)1) : ((byte)0));
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public ImportStep Step
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 鴀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			需(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string SelectedFileName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)鐀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			대(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool HasSelectedFile
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return ꈀ() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			眀(value ? ((byte)1) : ((byte)0));
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int ParsedCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)退();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			褀((uint)value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int ImportedCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)蜀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			礀((uint)value);
		}
	}

	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public int SkippedCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)鰀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			ꨀ((uint)value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public ObservableCollection<AccountModel> ParsedAccounts
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 鼀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			蠀(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? ParseErrorMessage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string?)蔀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			錀(value);
		}
	}

	public bool IsStepSelectFile
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 谀() != 0;
		}
	}

	public bool IsStepPreview
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 舀() != 0;
		}
	}

	public bool IsStepDone
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 猀() != 0;
		}
	}

	public bool IsPrimaryButtonEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 笀() != 0;
		}
	}

	public string Title
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)簀();
		}
	}

	public string PrimaryButtonText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)謀();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand SelectFileCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)ꘀ();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe ImportAccountViewModel()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_0032: Expected I, but got Obj
		//IL_0037: Expected Obj, but got VT
		//IL_0042: Expected I, but got Obj
		//IL_00bc: Expected I4, but got Obj
		//IL_00bc: Expected I, but got Obj
		//IL_008c: Expected I, but got Obj
		//IL_00a0: Expected Obj, but got I
		//IL_00a5->IL006a: Incompatible stack heights: 4 vs 2
		//IL_00b0->IL006a: Incompatible stack heights: 4 vs 2
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = this;
		IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute = this;
		IList_object.PatchAttribute = ((int)/*Error near IL_0032: Stack underflow*/, (nint)this);
		object obj = IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)this);
		int num = 1;
		if (IReadOnlyList_System_IDisposable._initialized != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				new IReadOnlyListMethods<INotifyPropertyChanged>((IntPtr)this, (uint)(delegate*<IEnumerator_object>)(&IEnumerator_object.LoadAttribute));
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init();
				_ = 0;
				if (IEnumerator_System_IDisposable.ReflectTransferableAttribute != null)
				{
					_ = 0;
				}
				break;
			default:
				obj = new IReadOnlyListMethods<INotifyPropertyChanged>((IntPtr)obj, (uint)(int)this, ref *(INotifyPropertyChanged[]*)(delegate* unmanaged[Stdcall]<nint, uint, uint, nint, uint*, uint>)(&IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3));
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
				num = 2;
				if (GlobalVtableLookup.CreateAttribute != null)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		甀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSelectFile_003Ed__45))]
	[RelayCommand]
	private object SelectFile()
	{
		return 鬀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPrimaryAsync_003Ed__46))]
	public Task PrimaryAsync()
	{
		return (Task)贀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DoImport()
	{
		가();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CParseFile_003Ed__48))]
	private object ParseFile()
	{
		return ꐀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DragStatusChanged(byte isDragging)
	{
		ꄀ(isDragging);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadFile(object path)
	{
		넀(path);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FilesDropped(object files)
	{
		딀(files);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnStepChanged(ImportStep value)
	{
		꼀(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnHasSelectedFileChanged(byte value)
	{
		縀(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckGenericContext()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ImportAccountViewModel VerifyMonitor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object 瀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777650, new IntPtr(2737335708076L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object 焀()
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
	internal unsafe byte 爀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777651, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte 猀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ((nint)_003CModule_003E.CheckAccessibleAttribute() == 2) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte 琀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777648, new IntPtr(2737335735116L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void 甀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_004d: Expected I, but got Obj
		//IL_0092: Expected I, but got Obj
		//IL_008c->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0066->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00a6->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0071->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00b1->IL0026: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				new IEnumeratorMethods<object>((IntPtr)this, ref *(object[]*)(delegate*<_003CModule_003E>)(&_003CModule_003E.CheckAccessibleAttribute));
				IEnumerator_object.Init();
				_ = 0;
				if (IList_object._initialized == 0)
				{
					_ = 1;
				}
				break;
			case 1:
				new IEnumeratorMethods<object>((IntPtr)(nint)(delegate* unmanaged[Stdcall]<nint, nint*, uint>)(&IEnumerator_object.Do_Abi_get_Current_0));
				IEnumerator_object._002Ecctor();
				_ = 3;
				break;
			case 3:
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)this);
				_ = 0;
				if (IReadOnlyList_object._initialized == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 瘀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777649, new IntPtr(2737335729916L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 眀(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_00c1: Expected I, but got Obj
		//IL_0097: Expected Obj, but got I4
		//IL_00a6: Expected Obj, but got I
		//IL_00e6->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0107->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00cb->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00ab->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f1->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00b6->IL0026: Incompatible stack types: I4 vs Obj
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
			case 2:
				ExceptionHelpers.GetHRForException((Exception)/*Error near IL_0051: Stack underflow*/);
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_0058: Member reference must be method, but was: Field*/;
			case 1:
				return;
			case 6:
				IList_object.PatchAttribute = P_0;
				obj2 = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
				{
					obj2 = 0;
				}
				break;
			case 5:
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00c1: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00c1: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)IReadOnlyList_System_IDisposable._initialized);
				_ = 3;
				break;
			default:
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Initialized;
				_ = 0;
				if (IEnumerator_System_IDisposable._initialized == 0)
				{
					_ = 5;
				}
				break;
			case 3:
				return;
			case 4:
				MarshalInterface<INotifyPropertyChanged>.FromAbiArray(IEnumerator_System_IDisposable.ReflectTransferableAttribute);
				_ = 6;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 砀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777662, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 礀(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_007a: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I
		//IL_00d0: Expected Obj, but got I
		//IL_004f: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_00b4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008e->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00bf->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0099->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00df->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006e->IL0026: Incompatible stack heights: 2 vs 1
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
			case 4:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			case 2:
				MarshalInspectable<object>.FromAbiArray((object)IList_object._initialized);
				_ = 1;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
				{
					_ = 1;
				}
				break;
			case 1:
				IReadOnlyList_System_IDisposable._initialized = (int)P_0;
				obj2 = 3;
				if (IReadOnlyList_object._initialized != 0)
				{
					obj2 = 4;
				}
				break;
			case 3:
				if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2(MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)/*Error near IL_00c4: Stack underflow*/), (INotifyPropertyChanged)IEnumerator_System_IDisposable._initialized, ref *(uint*)P_0))
				{
					return;
				}
				obj2 = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 稀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777663, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte 笀()
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
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						_ = 0;
					}
					break;
				}
				return 1;
			default:
				return (byte)IEnumerator_object.Do_Abi_MoveNext_2((nint)/*Error near IL_0068: Stack underflow*/, (byte*)(nint)this);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 簀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17430, 1790777660, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777660, new IntPtr(2737335727836L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 紀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777661, new IntPtr(2737335728876L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 縀(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0044: Expected I, but got Obj
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
			case 0:
				return;
			case 1:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)_003CModule_003E.CheckAccessibleAttribute());
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
	private unsafe void 缀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777658, new IntPtr(2737335728876L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte 耀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777659, new IntPtr(2737335729916L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte 脀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte 舀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ((nint)_003CModule_003E.CheckAccessibleAttribute() == 1) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte 茀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777656, new IntPtr(2737335728876L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 萀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777657, new IntPtr(2737335702876L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 蔀()
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
	internal unsafe uint 蘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777606, new IntPtr(2737335728876L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint 蜀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 蠀(ObservableCollection<AccountModel> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_004b: Expected I, but got Obj
		//IL_0075: Expected I, but got Obj
		//IL_0075: Expected I4, but got Obj
		//IL_008b: Expected I, but got Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009f->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00c0->IL007f: Incompatible stack heights: 2 vs 0
		//IL_006a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00aa->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00ca->IL0026: Incompatible stack heights: 3 vs 1
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
			default:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
				obj2 = 1;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 1;
				}
				break;
			case 1:
				((ValueTuple<int, nint>*)/*Error near IL_0075: Stack underflow*/)->_002Ector((int)this, (nint)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute);
				obj2 = 2;
				break;
			case 2:
				return;
			case 3:
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)IList_object.PatchAttribute);
				_ = 0;
				if (IReadOnlyList_System_IDisposable._initialized == 0)
				{
					_ = 0;
				}
				break;
			case 4:
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00af: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00af: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_00af: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)/*Error near IL_00af: Stack underflow*/);
				_ = IReadOnlyList_object._initialized;
				if (MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)P_0) != (IntPtr)0)
				{
					return;
				}
				_ = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 褀(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_0099: Expected I, but got Obj
		//IL_00aa: Expected Obj, but got I4
		//IL_00b9: Expected Obj, but got I
		//IL_006f: Expected I, but got Obj
		//IL_006f: Expected I4, but got Obj
		//IL_00a3->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00be->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0083->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008e->IL0026: Incompatible stack types: I4 vs Obj
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
			case 3:
				ExceptionHelpers.GetHRForException((Exception)/*Error near IL_0049: Stack underflow*/);
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_0050: Member reference must be method, but was: Field*/;
			case 2:
				((ValueTuple<int, nint>*)/*Error near IL_006f: Stack underflow*/)->_002Ector((int)this, (nint)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute);
				obj2 = 1;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					obj2 = 1;
				}
				break;
			default:
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute);
				_ = 4;
				break;
			case 1:
				IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = P_0;
				obj2 = 0;
				if (IReadOnlyList_object.ReflectLogicalAttribute == null)
				{
					obj2 = 0;
				}
				break;
			case 4:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 言(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777607, new IntPtr(2737335728876L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 謀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17445, 1790777604, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777604, new IntPtr(2737335728876L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte 谀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (_003CModule_003E.CheckAccessibleAttribute() == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 贀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17447, 1790777605, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777605, new IntPtr(2737335735116L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 踀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777602, new IntPtr(2737335702876L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint 輀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777603, new IntPtr(2737335702876L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint 退()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint 鄀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777600, new IntPtr(2737335729916L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 鈀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777601, new IntPtr(2737335702876L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 錀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00aa: Expected I, but got Obj
		//IL_00b9: Expected Obj, but got I
		//IL_004b: Expected I, but got Obj
		//IL_008f: Expected Obj, but got I
		//IL_00be->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00de->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0080->IL00de: Incompatible stack heights: 1 vs 0
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c9->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0094->IL0026: Incompatible stack heights: 2 vs 1
		//IL_006a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009f->IL0026: Incompatible stack heights: 2 vs 1
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
			case 4:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
				obj2 = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				/*Error near IL_006f: Stack underflow*/((object[])/*Error near IL_006f: Stack underflow*/, (nint)/*Error near IL_006f: Stack underflow*/);
				_ = IList_object._initialized;
				if (MarshalInspectable<object>.FromAbiArray(P_0) == null)
				{
					_ = 1;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
					{
						_ = 1;
					}
					break;
				}
				return;
			default:
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00aa: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00aa: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)IReadOnlyList_System_IDisposable._initialized);
				_ = 3;
				if (IReadOnlyList_object.ReflectLogicalAttribute != null)
				{
					_ = 2;
				}
				break;
			case 1:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00d4: Stack underflow*/, (INotifyPropertyChanged)this, ref *(uint*)IEnumerator_System_IDisposable._initialized);
				_ = 4;
				break;
			case 3:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 鐀()
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
	internal unsafe object 销()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777614, new IntPtr(2737335702876L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 阀(ImportStep P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777615, new IntPtr(2737335729916L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 需(ImportStep P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_009a: Expected Obj, but got I4
		//IL_00a9: Expected Obj, but got I
		//IL_0074: Expected I, but got Obj
		//IL_0074: Expected I4, but got Obj
		//IL_00d5: Expected I, but got Obj
		//IL_00ae->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0088->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ca->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00e9->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00b9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0093->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f4->IL0026: Incompatible stack heights: 3 vs 1
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
			case 0:
				return;
			case 3:
				ExceptionHelpers.GetHRForException((Exception)/*Error near IL_004e: Stack underflow*/);
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_0055: Member reference must be method, but was: Field*/;
			case 2:
				((ValueTuple<int, nint>*)/*Error near IL_0074: Stack underflow*/)->_002Ector((int)this, (nint)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute);
				obj2 = 1;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute = P_0;
				obj2 = 1;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute != null)
				{
					obj2 = 4;
				}
				break;
			case 4:
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Initialized;
				_ = 5;
				break;
			case 5:
				MarshalInterface<INotifyPropertyChanged>.FromAbi((IntPtr)IReadOnlyList_object.ReflectLogicalAttribute);
				_ = 0;
				if (IEnumerable_System_IDisposable._initialized != 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte 頀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777612, new IntPtr(2737335729916L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte 餀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte 騀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777613, new IntPtr(2737335729916L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object 鬀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17461, 1790777610, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777610, new IntPtr(2737335729916L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint 鰀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ImportStep 鴀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ImportStep)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ImportStep 鸀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777611, new IntPtr(2737335702876L), 15))(null, 0, new IntPtr(0L));
		return (ImportStep)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<AccountModel> 鼀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<AccountModel>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<AccountModel> ꀀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777608, new IntPtr(2737335708076L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<AccountModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void ꄀ(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0056: Expected I4, but got Obj
		//IL_005b: Expected I, but got VT
		//IL_006a: Expected Obj, but got I
		//IL_006f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_007a->IL0026: Incompatible stack heights: 2 vs 1
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
				IEnumerator_object.Do_Abi_get_Current_0(__return_value__: (nint*)(nint)((int)new _003CModule_003E
				{
					JoinAttribute = this,
					_initialized = (int)P_0
				}, (nint)(delegate* unmanaged[Stdcall]<nint, byte*, uint>)(&IEnumerator_object.Do_Abi_MoveNext_2)), thisPtr: (nint)/*Error near IL_005b: Stack underflow*/);
				_ = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
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
	internal unsafe byte ꈀ()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object ꌀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777609, new IntPtr(2737335702876L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object ꐀ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17470, 1790777622, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777622, new IntPtr(2737335702876L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object ꔀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777623, new IntPtr(2737335736156L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object ꘀ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17472, 1790777620, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777620, new IntPtr(2737335736156L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _A700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777621, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void ꠀ(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_0075: Expected I, but got Obj
		//IL_0075: Expected I4, but got Obj
		//IL_00ba: Expected Obj, but got I4
		//IL_009f: Expected I, but got Obj
		//IL_00ce: Expected Obj, but got I
		//IL_0089->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00bf->IL00de: Incompatible stack heights: 2 vs 0
		//IL_00a9->IL0026: Incompatible stack heights: 3 vs 1
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0094->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d3->IL0026: Incompatible stack heights: 3 vs 1
		//IL_006a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00de->IL0026: Incompatible stack heights: 3 vs 1
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
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (int)P_0;
				obj2 = 1;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 2;
				}
				break;
			default:
				((ValueTuple<int, nint>*)/*Error near IL_0075: Stack underflow*/)->_002Ector((int)this, (nint)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute);
				obj2 = 4;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute);
				_ = 3;
				break;
			case 1:
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00ae: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00ae: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_00ae: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)/*Error near IL_00ae: Stack underflow*/);
				_ = IReadOnlyList_object._initialized;
				if (MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)P_0) == (IntPtr)0)
				{
					_ = 0;
					if (IEnumerator_System_IDisposable.ReflectTransferableAttribute != null)
					{
						_ = 0;
					}
					break;
				}
				return;
			case 3:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _꤀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777618, new IntPtr(2737335740316L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void ꨀ(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_007e: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I
		//IL_00e1: Expected Obj, but got I
		//IL_0092->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00bc->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00e6->IL0026: Incompatible stack heights: 3 vs 1
		//IL_009d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c7->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00f1->IL0026: Incompatible stack heights: 3 vs 1
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
			case 2:
				return;
			case 1:
				IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute = P_0;
				obj2 = 4;
				if (IList_object.PatchAttribute == null)
				{
					obj2 = 2;
				}
				break;
			case 4:
				MarshalInspectable<object>.FromManaged((object)this, (byte)IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0);
				_ = 0;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
				{
					_ = 0;
				}
				break;
			case 5:
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
				_ = 0;
				if (IEnumerator_System_IDisposable.ReflectTransferableAttribute != null)
				{
					_ = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _AB00(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777619, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void 가()
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
	private unsafe void 관()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777616, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 글(ImportStep P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777617, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 꼀(ImportStep P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_007c: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I4
		//IL_0090: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_0100: Expected I, but got Obj
		//IL_00d1: Expected I, but got Obj
		//IL_0057: Expected I, but got Obj
		//IL_0066: Expected Obj, but got I
		//IL_00e6: Expected I, but got Obj
		//IL_0095->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00bf->IL0026: Incompatible stack heights: 2 vs 1
		//IL_010a->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00e0->IL0026: Incompatible stack heights: 2 vs 1
		//IL_006b->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00f5->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a0->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00ca->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0076->IL0026: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 6;
		while (true)
		{
			switch ((int)obj)
			{
			case 5:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)_003CModule_003E.CheckAccessibleAttribute());
				_ = 1;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					_ = 1;
				}
				break;
			default:
				MarshalInspectable<object>.FromAbiArray((object)IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_007c: Stack underflow*/, (uint)/*Error near IL_007c: Stack underflow*/, (nint)/*Error near IL_007c: Stack underflow*/, (uint*)(nint)this));
				_ = 4;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
				{
					_ = 1;
				}
				break;
			case 1:
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00ab: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00ab: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(IEnumerator_object.DecorateAutomatableAttribute() ? 1 : 0));
				_ = 0;
				if (IReadOnlyList_object.ReflectLogicalAttribute != null)
				{
					_ = 0;
				}
				break;
			case 3:
				return;
			case 4:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00d6: Stack underflow*/, (INotifyPropertyChanged)/*Error near IL_00d6: Stack underflow*/, ref *(uint*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_00d1: Stack underflow*/, (uint)/*Error near IL_00d1: Stack underflow*/, (nint*)(nint)this));
				_ = 2;
				break;
			case 6:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)/*Error near IL_00eb: Stack underflow*/, (uint)/*Error near IL_00eb: Stack underflow*/, ref *(INotifyPropertyChanged[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3((nint)/*Error near IL_00e6: Stack underflow*/, (uint)/*Error near IL_00e6: Stack underflow*/, (uint)/*Error near IL_00e6: Stack underflow*/, (nint)/*Error near IL_00e6: Stack underflow*/, (uint*)(nint)this));
				_ = 5;
				break;
			case 2:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_get_Size_1((IntPtr)this);
				_ = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 뀀(ImportStep P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777630, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 넀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00be: Expected I, but got Obj
		//IL_00be: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0098: Expected I, but got Obj
		//IL_0098: Expected I, but got Obj
		//IL_005f->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00d7->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0085->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ac->IL0026: Incompatible stack heights: 2 vs 1
		//IL_006a->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00e2->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0090->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b7->IL0026: Incompatible stack heights: 2 vs 1
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
				_ = 1;
				_003CModule_003E.CheckAccessibleAttribute();
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					_ = 4;
				}
				break;
			case 3:
				IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute = P_0;
				obj2 = 0;
				if (IList_object.PatchAttribute != null)
				{
					obj2 = 0;
				}
				break;
			case 0:
				return;
			case 4:
				IEnumerator_object.Do_Abi_get_HasCurrent_1((nint)this, (byte*)unchecked((nint)null));
				_ = 3;
				if (IReadOnlyList_System_IDisposable._initialized != 0)
				{
					_ = 0;
				}
				break;
			case 2:
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00be: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00be: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)P_0);
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Initialized;
				_ = 1;
				if (IEnumerator_System_IDisposable._initialized != 0)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 눀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777631, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 대(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_009e: Expected I, but got Obj
		//IL_0053: Expected I, but got Obj
		//IL_00e2: Expected Obj, but got I
		//IL_00d3->IL0048: Incompatible stack heights: 2 vs 0
		//IL_0072->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005d->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00e7->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00bd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f2->IL0026: Incompatible stack heights: 3 vs 1
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
				return;
			case 5:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 3;
				break;
			case 2:
				/*Error near IL_0068: Stack underflow*/((object[])(object)this, IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized);
				obj2 = 4;
				break;
			case 0:
				return;
			case 4:
				return;
			case 3:
				IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
				obj2 = 1;
				if (IReadOnlyList_System_IDisposable._initialized != 0)
				{
					obj2 = 2;
				}
				break;
			case 1:
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00c2: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00c2: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_00c2: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)/*Error near IL_00c2: Stack underflow*/);
				_ = IReadOnlyList_object._initialized;
				if (MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)P_0) != (IntPtr)0)
				{
					_ = 0;
					if (IEnumerator_System_IDisposable.ReflectTransferableAttribute != null)
					{
						_ = 0;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 됀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777628, new IntPtr(2737335737196L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 딀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_0083: Expected Obj, but got I4
		//IL_010e: Expected Obj, but got I
		//IL_0113: Expected I, but got Obj
		//IL_0103: Expected I, but got Obj
		//IL_0109: Expected I, but got Obj
		//IL_0067->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d1->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00a8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_011d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0109->IL0109: Incompatible stack heights: 2 vs 3
		//IL_00b3->IL0026: Incompatible stack types: I4 vs Obj
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
				case 1:
					obj = new _003CModule_003E();
					obj2 = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj2 = 0;
					}
					continue;
				case 3:
					if (IList_object._initialized != 0)
					{
						obj2 = 2;
						if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
						{
							obj2 = 1;
						}
						continue;
					}
					return;
				case 5:
					return;
				case 4:
					return;
				case 2:
					new IEnumeratorMethods<object>((IntPtr)(nint)(delegate*<void>)(&IEnumerator_object._002Ecctor));
					IEnumerator_object.LoadAttribute();
					_ = 5;
					continue;
				case 6:
				{
					object obj3 = obj;
					nint initialized = IReadOnlyList_object._initialized;
					if (initialized == 0)
					{
						IEnumerable_System_IDisposable._initialized = (new IReadOnlyListMethods<INotifyPropertyChanged>((IntPtr)P_0, (INotifyPropertyChanged)IReadOnlyList_object.ReflectLogicalAttribute, ref *(uint*)(delegate* unmanaged[Stdcall]<nint, uint, nint*, uint>)(&IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0)) ? ((nint)1) : ((nint)0));
					}
					IEnumerable_object._initialized = (nint)((XamlUserType)P_0).BoxType<DateTime>((object)initialized);
					obj2 = 3;
					continue;
				}
				}
				break;
			}
			IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute = this;
			obj = 6;
		}
	}
}
