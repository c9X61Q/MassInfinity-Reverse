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
using System.Text;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using System.Threading;
using System.Threading.Tasks;
using ABI.Microsoft.UI.Composition;
using ABI.Microsoft.UI.Xaml;
using ABI.Microsoft.UI.Xaml.Controls;
using ABI.System.Collections;
using ABI.System.Collections.Generic;
using ABI.System.Collections.Specialized;
using ABI.System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.WinUI.Animations;
using Mass.Application.Services;
using Mass.Domain.Desktop.Entities.Game;
using Mass.Domain.Desktop.Entities.NetGame;
using Mass.Domain.Desktop.Entities.RentalGame;
using Mass.Domain.Desktop.Interfaces;
using Mass.Domain.Entities.Mass;
using Mass.Domain.Value;
using Mass.Game.Launcher.Java;
using Mass.Game.Proxy;
using Mass.WinUI.Enums;
using Mass.WinUI.Helpers;
using Mass.WinUI.Mass_WinUI_XamlTypeInfo;
using Mass.WinUI.Models.Messages;
using Mass.WinUI.ViewModels;
using Matrix.Core.Java;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Media;
using Microsoft.Windows.Foundation.UndockedRegFreeWinRTCS;
using WinRT;
using WinRT.Mass_WinUIGenericHelpers;
using WinRT.Mass_WinUIVtableClasses;

namespace Mass.WinUI.Models;

[WinRTExposedType(typeof(Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
public class DesktopGameModel : ObservableObject, ICloneable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddCharacter_003Ed__79 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<(bool isSuccess, bool needRetry)> _003C_003Et__builder;

		public string name;

		public DesktopGameModel _003C_003E4__this;

		public bool growl;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<EntityGameCharacter> _003C_003Eu__2;

		internal static object RunSynchronizer;

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
		internal static bool DecorateExpandableWrapper()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectHiddenProcessor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00萀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778955, new IntPtr(2737336594876L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00蔀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0989: Expected Obj, but got I4
			//IL_0989: Expected Obj, but got Ref
			//IL_0992: Expected Obj, but got I4
			//IL_095f: Expected Obj, but got Ref
			//IL_004e: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got Ref
			//IL_0119: Expected Obj, but got Ref
			//IL_011e: Expected Obj, but got I4
			//IL_012f: Expected Obj, but got I4
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Expected Obj, but got Unknown
			//IL_0140: Expected Obj, but got I
			//IL_0164: Expected I4, but got Obj
			//IL_08ad: Expected Obj, but got VT
			//IL_02dd: Expected Obj, but got Ref
			//IL_048e: Expected Obj, but got Ref
			//IL_04d2: Expected Obj, but got Ref
			//IL_0674: Expected Obj, but got Ref
			//IL_04a0: Expected Obj, but got Ref
			//IL_0365: Expected I, but got Obj
			//IL_036b: Expected Obj, but got Ref
			//IL_0376: Expected I, but got Obj
			//IL_03e8: Expected Obj, but got I4
			//IL_03ed: Expected Obj, but got I4
			//IL_03ed: Expected Obj, but got Ref
			//IL_0593: Expected Obj, but got I4
			//IL_0598: Expected Obj, but got I4
			//IL_0598: Expected Obj, but got Ref
			//IL_056a: Expected Obj, but got I4
			//IL_056f: Expected Obj, but got I4
			//IL_056f: Expected Obj, but got Ref
			//IL_025b: Expected Obj, but got Ref
			//IL_0657: Expected Obj, but got I4
			//IL_065c: Expected Obj, but got I4
			//IL_065c: Expected Obj, but got Ref
			//IL_02b2: Expected Obj, but got Ref
			//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fb: Expected Obj, but got Ref
			//IL_0468: Expected Obj, but got Ref
			//IL_0234: Expected Obj, but got Ref
			//IL_0239: Expected Obj, but got I4
			//IL_0535: Expected Obj, but got I4
			//IL_053a: Expected Obj, but got I4
			//IL_053a: Expected Obj, but got Ref
			//IL_0302: Expected Obj, but got Ref
			//IL_0211: Expected Obj, but got I4
			//IL_0216: Expected Obj, but got Ref
			//IL_021f: Expected Obj, but got I4
			//IL_032f: Expected Obj, but got Ref
			//IL_050b: Expected Obj, but got Ref
			//IL_050b: Unknown result type (might be due to invalid IL or missing references)
			//IL_05aa: Expected Obj, but got Ref
			//IL_0290: Expected I, but got Obj
			//IL_0296: Expected Obj, but got Ref
			//IL_029b: Expected I4, but got Obj
			//IL_029b: Expected I, but got Obj
			//IL_02a0: Expected Obj, but got I4
			//IL_0437: Expected I, but got Obj
			//IL_043d: Invalid comparison between Unknown and I4
			//IL_05cf: Expected Obj, but got Ref
			//IL_040e: Expected Obj, but got Ref
			//IL_041a: Expected Obj, but got I4
			//IL_054c: Expected Obj, but got Ref
			//IL_0207: Expected I4, but got Obj
			//IL_0975->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0980->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0128->IL0088: Incompatible stack heights: 2 vs 1
			//IL_0145->IL0088: Incompatible stack heights: 2 vs 1
			//IL_08b7->IL0088: Incompatible stack heights: 2 vs 1
			//IL_0150->IL0088: Incompatible stack heights: 2 vs 1
			//IL_02e9->IL0172: Incompatible stack types: I4 vs Obj
			//IL_049a->IL0172: Incompatible stack types: I4 vs Obj
			//IL_04e8->IL0172: Incompatible stack types: I4 vs Obj
			//IL_016e->IL0172: Incompatible stack types: I4 vs Obj
			//IL_04f3->IL0172: Incompatible stack types: I4 vs Obj
			//IL_03b2->IL0172: Incompatible stack types: I4 vs Obj
			//IL_0688->IL0172: Incompatible stack heights: 2 vs 1
			//IL_04b2->IL0172: Incompatible stack heights: 2 vs 1
			//IL_038a->IL0172: Incompatible stack heights: 2 vs 1
			//IL_03f7->IL0172: Incompatible stack types: I4 vs Obj
			//IL_05a2->IL0172: Incompatible stack types: I4 vs Obj
			//IL_0583->IL0172: Incompatible stack types: I4 vs Obj
			//IL_0666->IL0172: Incompatible stack types: I4 vs Obj
			//IL_02cc->IL0172: Incompatible stack types: I4 vs Obj
			//IL_0633->IL0461: Incompatible stack heights: 1 vs 0
			//IL_0505->IL0172: Incompatible stack types: I4 vs Obj
			//IL_047d->IL0172: Incompatible stack types: I4 vs Obj
			//IL_0243->IL0172: Incompatible stack heights: 2 vs 1
			//IL_0254->IL0172: Incompatible stack heights: 2 vs 1
			//IL_0544->IL0172: Incompatible stack types: I4 vs Obj
			//IL_031e->IL0172: Incompatible stack heights: 2 vs 1
			//IL_034b->IL0172: Incompatible stack types: I4 vs Obj
			//IL_0525->IL0172: Incompatible stack types: I4 vs Obj
			//IL_03d8->IL0172: Incompatible stack heights: 2 vs 1
			//IL_05be->IL0172: Incompatible stack types: I4 vs Obj
			//IL_02ac->IL0172: Incompatible stack types: I4 vs Obj
			//IL_05df->IL0172: Incompatible stack types: I4 vs Obj
			//IL_0430->IL0172: Incompatible stack heights: 5 vs 1
			//IL_0556->IL0172: Incompatible stack types: I4 vs Obj
			//IL_03bd->IL0172: Incompatible stack types: I4 vs Obj
			//IL_0693->IL0172: Incompatible stack heights: 2 vs 1
			//IL_0395->IL0172: Incompatible stack heights: 2 vs 1
			//IL_058e->IL0172: Incompatible stack types: I4 vs Obj
			//IL_0274->IL0172: Incompatible stack types: I4 vs Obj
			//IL_02d7->IL0172: Incompatible stack types: I4 vs Obj
			//IL_0647->IL0172: Incompatible stack heights: 2 vs 1
			//IL_0488->IL0172: Incompatible stack types: I4 vs Obj
			//IL_0329->IL0172: Incompatible stack heights: 2 vs 1
			//IL_0356->IL0172: Incompatible stack types: I4 vs Obj
			//IL_0530->IL0172: Incompatible stack types: I4 vs Obj
			//IL_03e3->IL0172: Incompatible stack heights: 2 vs 1
			//IL_05c9->IL0172: Incompatible stack types: I4 vs Obj
			//IL_0456->IL0172: Incompatible stack types: I4 vs Obj
			//IL_027f->IL0172: Incompatible stack types: I4 vs Obj
			//IL_0652->IL0172: Incompatible stack heights: 2 vs 1
			//IL_0461->IL0172: Incompatible stack types: I4 vs Obj
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 4;
			while (true)
			{
				object obj = awaiter;
				while (true)
				{
					int num;
					switch ((int)obj)
					{
					case 4:
						awaiter = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
						obj = 3;
						continue;
					case 5:
						_ = ref IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
						/*Error near IL_0062: Member reference must be method, but was: Field*/;
					default:
						if ((nuint)(nint)awaiter <= (nuint)2u)
						{
							num = 8;
							goto IL_0088;
						}
						goto IL_087b;
					case 3:
						awaiter = __KnownINotifyPropertyChangingArgs.IsLoading;
						obj = 0;
						if (__KnownINotifyPropertyChangingArgs.Ordering == null)
						{
							obj = 0;
						}
						continue;
					case 2:
						return;
					case 1:
						break;
						IL_0109:
						IEnumerator_object._002Ecctor();
						((XamlUserType)IEnumerator_object.DecorateAutomatableAttribute()).BoxType<TimeSpan>(IReadOnlyList_System_IDisposable.ReflectConnectedAttribute);
						_ = 5;
						goto IL_0088;
						IL_0088:
						while (true)
						{
							switch (num)
							{
							case 5:
							case 8:
								num = 0;
								if (IList_object._initialized != 0)
								{
									num = 3;
								}
								continue;
							case 7:
								break;
							case 1:
								_ = 0;
								awaiter = (nint)new MarshalInterface<INotifyPropertyChanged>((INotifyPropertyChanged)0);
								_ = 2;
								if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
								{
									_ = 2;
								}
								continue;
							case 3:
							{
								object obj2;
								switch ((int)awaiter)
								{
								default:
									obj2 = 30;
									goto IL_0172;
								case 0:
									awaiter = _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner.CheckOperationalModule;
									obj2 = 13;
									goto IL_0172;
								case 1:
									goto IL_0488;
								case 2:
									goto IL_04cc;
									IL_0172:
									while (true)
									{
										switch ((int)obj2)
										{
										case 24:
											awaiter = 1;
											IEnumerable_System_IDisposable._initialized = 1;
											awaiter = 28;
											obj2 = awaiter;
											continue;
										case 19:
										case 33:
										{
											uint num2 = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1((nint)/*Error near IL_0229: Stack underflow*/, (uint*)/*Error near IL_0229: Stack underflow*/);
											IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
											Interlocked.CompareExchange(ref *(Func<InfoBarDelegate>*)/*Error near IL_0239: Stack underflow*/, (Func<InfoBarDelegate>)num2, (Func<InfoBarDelegate>)IEnumerable_object.ReflectSetAttribute);
											_ = 4;
											continue;
										}
										case 20:
											IEnumerableMethods<INotifyPropertyChanged>.Abi_First_0((IntPtr)(nint)(&awaiter));
											_ = 33;
											continue;
										case 11:
											if (MarshalInterface<IEnumerator<INotifyPropertyChanged>>.FromManaged((IEnumerator<INotifyPropertyChanged>)(&awaiter)) == (IntPtr)0)
											{
												obj2 = 8;
												if (Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute != null)
												{
													obj2 = 9;
												}
												continue;
											}
											goto case 27;
										case 29:
										{
											bool flag = IEnumerable_System_ComponentModel_INotifyPropertyChanged.DecorateSeparatedAttribute();
											IListMethods<object>.Abi_SetAt_4((IntPtr)awaiter, (uint)(int)MarshalInspectable<object>.FromAbi((IntPtr)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectMonoAttribute()), Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute);
											IListMethods<object>.Abi_InsertAt_5((IntPtr)/*Error near IL_02a0: Stack underflow*/, (uint)/*Error near IL_02a0: Stack underflow*/, (object)flag);
											awaiter = (object)/*Error near IL_02a2: Stack underflow*/;
											obj2 = 10;
											continue;
										}
										case 13:
											Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute = (object)default(IReadOnlyListMethods<>);
											obj2 = 7;
											if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.ReflectLiteralAttribute == null)
											{
												obj2 = 0;
											}
											continue;
										case 17:
											break;
										case 22:
											_ = ref _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout;
											((AsyncTaskMethodBuilder*)(&awaiter))->Start(ref Unsafe.As<_003CAddCharacter_003Ed__79, AccountViewModel._003CLoginDesktop_003Ed__87>(ref this));
											_ = 34;
											if (__KnownINotifyPropertyChangingArgs.Notes != null)
											{
												_ = 27;
											}
											continue;
										case 25:
											Unsafe.As<PropertyChangingEventArgs, AsyncTaskMethodBuilder>(ref __KnownINotifyPropertyChangingArgs.UserId).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<(bool, string)>*)(&awaiter), ref Unsafe.As<_003CAddCharacter_003Ed__79, AccountViewModel._003CEditAccount_003Ed__22>(ref this));
											obj2 = 6;
											if (__KnownINotifyPropertyChangingArgs.LoginAt == null)
											{
												obj2 = 0;
											}
											continue;
										case 4:
											IEnumerator_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_HasCurrent_1((nint)(int)IReadOnlyListMethods<IDisposable>.Abi_GetMany_3((IntPtr)/*Error near IL_0370: Stack underflow*/, IEnumerator_System_ComponentModel_INotifyPropertyChanged.Do_Abi_MoveNext_2((nint)__KnownINotifyPropertyChangingArgs.Name, (byte*)(int)IEnumerator_System_ComponentModel_INotifyPropertyChanged.Init()), ref *(IDisposable[]*)__KnownINotifyPropertyChangingArgs.CharacterName), (byte*)unchecked((nint)null));
											_ = 1;
											if (__KnownINotifyPropertyChangingArgs.CanProxy == null)
											{
												_ = 1;
											}
											continue;
										default:
											awaiter = new IReadOnlyListMethods<object, nint>((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_039c: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_039c: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)1, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)null);
											obj2 = 8;
											if (__KnownINotifyPropertyChangingArgs.MaxPlayers != null)
											{
												obj2 = 8;
											}
											continue;
										case 27:
											IReadOnlyListMethods<object>.Abi_GetMany_3((IntPtr)/*Error near IL_03c4: Stack underflow*/, (uint)/*Error near IL_03c4: Stack underflow*/, ref *(object[]*)(&awaiter));
											_ = 0;
											if (__KnownINotifyPropertyChangingArgs.Version == null)
											{
												_ = 0;
											}
											continue;
										case 5:
											awaiter = -1;
											__KnownINotifyPropertyChangingArgs.ImageUrl = (PropertyChangingEventArgs)(-1);
											obj2 = 27;
											continue;
										case 32:
											IReadOnlyList_System_IDisposable._002Ecctor();
											IEnumeratorMethods<IDisposable>.Abi_get_HasCurrent_1((IntPtr)(IReadOnlyList_System_IDisposable.StoreAttribute() ? 1 : 0));
											_ = __KnownINotifyPropertyChangingArgs.Summary;
											awaiter = IEnumerableMethods<object>.Abi_First_0((IntPtr)(IEnumerableMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)MarshalInterface<IEnumerator<IDisposable>>.FromManaged((IEnumerator<IDisposable>)IReadOnlyList_object.Init())) ? 1 : 0));
											_ = 15;
											continue;
										case 30:
											((Func<Type, string>)/*Error near IL_043c: Stack underflow*/)._002Ector((object)/*Error near IL_043c: Stack underflow*/, (nint)(int)IReadOnlyList_object.Do_Abi_get_Size_1((nint)/*Error near IL_0437: Stack underflow*/, (uint*)(nint)awaiter));
											if ((int)/*Error near IL_0442: Stack underflow*/ == 8)
											{
												obj2 = 29;
												if (__KnownINotifyPropertyChangingArgs.OperationText != null)
												{
													obj2 = 28;
												}
												continue;
											}
											goto case 32;
										case 18:
											ComWrappersSupport.RegisterTypeComInterfaceEntriesLookup((Func<Type, ComWrappers.ComInterfaceEntry[]>)(&awaiter));
											obj2 = 13;
											if (__KnownINotifyPropertyChangingArgs.CanDelete == null)
											{
												obj2 = 19;
											}
											continue;
										case 3:
											goto IL_0488;
										case 2:
											_ = ref __KnownINotifyPropertyChangingArgs.OrderId;
											((AsyncTaskMethodBuilder*)(&awaiter))->Start(ref Unsafe.As<_003CAddCharacter_003Ed__79, ChatViewModel._003CSend_003Ed__9>(ref this));
											_ = 14;
											continue;
										case 10:
											_ = ref awaiter;
											/*Error near IL_04b4: Member reference must be method, but was: Field*/;
										case 23:
											goto IL_04cc;
										case 16:
											__KnownINotifyPropertyChangingArgs.PayUrl = (PropertyChangingEventArgs)awaiter;
											obj2 = 22;
											continue;
										case 26:
											__KnownINotifyPropertyChangingArgs.Image = (PropertyChangingEventArgs)default(IMessengerExtensions);
											obj2 = 5;
											if (__KnownINotifyPropertyChangingArgs.TotalCoins == null)
											{
												obj2 = 0;
											}
											continue;
										case 21:
											awaiter = -1;
											__KnownINotifyPropertyChangingArgs.TotalPoints = (PropertyChangingEventArgs)(-1);
											obj2 = 18;
											continue;
										case 35:
											__KnownINotifyPropertyChangingArgs.Amount = (PropertyChangingEventArgs)awaiter;
											obj2 = 25;
											continue;
										case 34:
											return;
										case 9:
											awaiter = 2;
											__KnownINotifyPropertyChangingArgs.CreatedAt = (PropertyChangingEventArgs)2;
											obj2 = 14;
											if (__KnownINotifyPropertyChangingArgs.DesktopAccounts != null)
											{
												obj2 = 35;
											}
											continue;
										case 7:
											awaiter = -1;
											__KnownINotifyPropertyChangingArgs.MobileAccounts = (PropertyChangingEventArgs)(-1);
											obj2 = 20;
											continue;
										case 28:
											__KnownINotifyPropertyChangingArgs.SelectedAccounts = (PropertyChangingEventArgs)awaiter;
											obj2 = 2;
											if (__KnownINotifyPropertyChangingArgs.SelectedIndex != null)
											{
												obj2 = 1;
											}
											continue;
										case 31:
											Unsafe.As<PropertyChangingEventArgs, DateTime?>(ref __KnownINotifyPropertyChangingArgs.Input4399Username) = null;
											obj2 = 21;
											continue;
										case 6:
											return;
										case 14:
											return;
										case 15:
											_ = ref awaiter;
											if (IReadOnlyListMethods<IDisposable>.AbiToProjectionVftablePtr == (IntPtr)0)
											{
												_ = 24;
												if (__KnownINotifyPropertyChangingArgs.VerifyCodeDelayText != null)
												{
													_ = 21;
												}
												continue;
											}
											goto case 18;
										case 12:
											awaiter = 0;
											__KnownINotifyPropertyChangingArgs.InfoBarMessage = (PropertyChangingEventArgs)0;
											obj2 = 16;
											continue;
										case 1:
											((Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails)awaiter).GetExposedInterfaces();
											awaiter = (nint)IUIElementOverridesMethods.IID;
											_ = 4;
											if (__KnownINotifyPropertyChangingArgs.Step != null)
											{
												_ = 11;
											}
											continue;
										case 8:
											goto end_IL_0026;
										}
										break;
									}
									goto case 0;
									IL_04cc:
									awaiter = __KnownINotifyPropertyChangingArgs.OrderAt;
									obj2 = 11;
									if (__KnownINotifyPropertyChangingArgs.Number != null)
									{
										obj2 = 26;
									}
									goto IL_0172;
									IL_0488:
									awaiter = __KnownINotifyPropertyChangingArgs.Id;
									obj2 = 31;
									goto IL_0172;
								}
							}
							default:
								goto IL_087b;
							case 6:
								_ = 0;
								awaiter = new ReadOnlySpan<char>(0);
								_ = 4;
								continue;
							case 2:
							case 4:
								goto end_IL_0026;
							}
							break;
						}
						goto IL_0109;
						IL_087b:
						((Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails)/*Error near IL_0880: Stack underflow*/)._002Ector();
						if ((int)/*Error near IL_0885: Stack underflow*/ == 0)
						{
							num = 1;
							if (__KnownINotifyPropertyChangingArgs.Balance != null)
							{
								num = 0;
							}
							goto IL_0088;
						}
						goto IL_0109;
					}
					break;
					continue;
					end_IL_0026:
					break;
				}
				__KnownINotifyPropertyChangingArgs.CanSelect = (PropertyChangingEventArgs)(-2);
				awaiter = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00蘀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778952, new IntPtr(2737336575116L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00蜀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00蠀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778953, new IntPtr(2737336586556L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00褀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778966, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00言()
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
		private unsafe sealed void _FF00_FF00_FF00謀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00谀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778967, new IntPtr(2737336582396L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddRandomCharacter_003Ed__78 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public DesktopGameModel _003C_003E4__this;

		private nint _003Ci_003E5__2;

		private object _003CcharacterName_003E5__3;

		private TaskAwaiter<(bool isSuccess, bool needRetry)> _003C_003Eu__1;

		internal static object DefineRole;

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
		internal static bool ReflectGenericConverter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectRandomVerifier()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00礀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778964, new IntPtr(2737336590716L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00稀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0586: Expected Obj, but got Ref
			//IL_05b5: Expected Obj, but got I4
			//IL_05b5: Expected Obj, but got Ref
			//IL_054d: Expected Obj, but got Ref
			//IL_0574: Expected Obj, but got Ref
			//IL_01bc: Expected Obj, but got I4
			//IL_01bc: Expected Obj, but got Ref
			//IL_005f: Expected Obj, but got I
			//IL_0471: Expected Obj, but got Ref
			//IL_0321: Expected Obj, but got Ref
			//IL_0418: Expected Obj, but got Ref
			//IL_0423: Expected Obj, but got I4
			//IL_0425: Expected Obj, but got I
			//IL_0379: Expected Obj, but got Ref
			//IL_03ee: Expected Obj, but got I4
			//IL_03f1: Expected Obj, but got I4
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Expected Obj, but got Unknown
			//IL_01d0: Expected Obj, but got Ref
			//IL_022a: Expected Obj, but got I4
			//IL_022f: Expected Obj, but got I4
			//IL_022f: Expected Obj, but got Ref
			//IL_03d1: Expected Obj, but got Ref
			//IL_017f: Expected Obj, but got Ref
			//IL_0256: Expected Obj, but got Ref
			//IL_0126: Expected I, but got Obj
			//IL_0145: Expected I4, but got Obj
			//IL_015a: Expected Obj, but got I
			//IL_00fe: Expected Obj, but got I4
			//IL_0103: Expected Obj, but got Ref
			//IL_0292: Expected Obj, but got I4
			//IL_01e0: Expected Obj, but got Ref
			//IL_044a: Expected Obj, but got Ref
			//IL_05a1->IL0026: Incompatible stack heights: 4 vs 1
			//IL_05c9->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0563->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0580->IL0026: Incompatible stack types: I4 vs Obj
			//IL_05ac->IL0026: Incompatible stack heights: 4 vs 1
			//IL_05d4->IL0026: Incompatible stack types: I4 vs Obj
			//IL_056e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0439->IL0073: Incompatible stack heights: 4 vs 1
			//IL_015f->IL0073: Incompatible stack heights: 6 vs 1
			//IL_0444->IL0073: Incompatible stack heights: 4 vs 1
			//IL_016a->IL0073: Incompatible stack heights: 6 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 5;
			object obj = awaiter;
			while (true)
			{
				int num;
				switch ((int)obj)
				{
				case 3:
					if (awaiter == null)
					{
						num = 13;
						if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute != null)
						{
							num = 21;
						}
						goto IL_0073;
					}
					goto IL_01b5;
				case 4:
					awaiter = __KnownINotifyPropertyChangingArgs.PayUrl;
					obj = 3;
					if (__KnownINotifyPropertyChangingArgs.DisplayName != null)
					{
						obj = 3;
					}
					continue;
				case 5:
					awaiter = __KnownINotifyPropertyChangingArgs.JoinedAt;
					obj = 4;
					continue;
				default:
					_ = ref __KnownINotifyPropertyChangingArgs.TotalCoins;
					_ = INotifyPropertyChangedMethods.IID;
					_ = 0;
					if (__KnownINotifyPropertyChangingArgs.CreatedAt == null)
					{
						_ = 1;
					}
					continue;
				case 1:
					return;
				case 2:
					break;
					IL_01b5:
					IEnumerable_object.ReflectSetAttribute = 0;
					num = 19;
					goto IL_0073;
					IL_0073:
					while (true)
					{
						switch (num)
						{
						case 20:
							awaiter = -1;
							IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized = -1;
							num = 8;
							continue;
						case 7:
							return;
						case 18:
							IEnumerator_object.Do_Abi_get_Current_0((nint)/*Error near IL_012b: Stack underflow*/, (nint*)(int)IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_0126: Stack underflow*/, (uint)/*Error near IL_0126: Stack underflow*/, (nint)/*Error near IL_0126: Stack underflow*/, (uint*)(nint)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute));
							_ = IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized;
							IEnumerator_object._002Ecctor();
							IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)(IEnumerator_object.DecorateAutomatableAttribute() ? 1 : 0), (uint)(int)(object)(DependencyObject)5);
							_ = null;
							IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init();
							_ = 11;
							if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
							{
								_ = 7;
							}
							continue;
						case 15:
						case 19:
							if (IEnumerable_System_IDisposable._initialized < 5)
							{
								num = 30;
								continue;
							}
							goto case 12;
						case 28:
							if (awaiter != null)
							{
								num = 2;
								if (IEnumerable_object._initialized == 0)
								{
									num = 24;
								}
								continue;
							}
							goto default;
						case 27:
							break;
						case 9:
							GlobalVtableLookup.CreateAttribute = awaiter + 1;
							num = 15;
							continue;
						case 24:
							awaiter = Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute;
							num = 6;
							if (Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute == null)
							{
								num = 6;
							}
							continue;
						case 13:
							awaiter = 0;
							Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute = 0;
							num = 9;
							if (Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute == null)
							{
								num = 16;
							}
							continue;
						case 16:
							Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute = awaiter;
							num = 8;
							if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute == null)
							{
								num = 14;
							}
							continue;
						case 25:
							awaiter = null;
							num = 17;
							continue;
						case 22:
						case 30:
							_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.ReflectLiteralAttribute = IList_object.Do_Abi_InsertAt_5((nint)/*Error near IL_028d: Stack underflow*/, (uint)/*Error near IL_028d: Stack underflow*/, (nint)(int)IList_object.Do_Abi_SetAt_4((nint)/*Error near IL_0288: Stack underflow*/, (uint)/*Error near IL_0288: Stack underflow*/, (nint)Unsafe.AsPointer(ref this)));
							num = 4;
							if ((int)_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout != 0)
							{
								num = 3;
							}
							continue;
						case 10:
							if (IListMethods<object>.Abi_get_Size_1((IntPtr)(nint)(&awaiter)) != 0)
							{
								num = 23;
								if (__KnownINotifyPropertyChangingArgs.Notes == null)
								{
									num = 13;
								}
								continue;
							}
							goto case 13;
						case 12:
						{
							uint num2 = IList_object.Do_Abi_get_Size_1((nint)/*Error near IL_02e1: Stack underflow*/, (uint*)/*Error near IL_02e1: Stack underflow*/);
							IList_object._002Ecctor();
							((AsyncTaskMethodBuilder*)/*Error near IL_02ec: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<string>*)num2, ref *(AccountViewModel._003CExportAccounts_003Ed__26*)5);
							num = 18;
							continue;
						}
						case 2:
						case 3:
							__KnownINotifyPropertyChangingArgs.IsMyself = null;
							num = 26;
							if (__KnownINotifyPropertyChangingArgs.CharacterName == null)
							{
								num = 22;
							}
							continue;
						case 5:
						case 21:
							awaiter = __KnownINotifyPropertyChangingArgs.IsSkeleton;
							num = 1;
							if (__KnownINotifyPropertyChangingArgs.ShowMaxPlayer == null)
							{
								num = 1;
							}
							continue;
						case 11:
							awaiter = null;
							num = 29;
							if (__KnownINotifyPropertyChangingArgs.MaxPlayers == null)
							{
								num = 24;
							}
							continue;
						case 14:
							Unsafe.As<PropertyChangingEventArgs, AsyncTaskMethodBuilder>(ref __KnownINotifyPropertyChangingArgs.Author).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<string>*)(&awaiter), ref Unsafe.As<_003CAddRandomCharacter_003Ed__78, AccountViewModel._003CLoginMobile_003Ed__88>(ref this));
							num = 7;
							continue;
						case 8:
						case 23:
						{
							bool flag = IEnumeratorMethods<IDisposable, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, nint*, int>)/*Error near IL_03ea: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)/*Error near IL_03ea: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)/*Error near IL_03ea: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, uint*, int>)(&awaiter));
							awaiter = flag;
							awaiter = flag;
							num = 6;
							if (__KnownINotifyPropertyChangingArgs.IsLiked == null)
							{
								num = 28;
							}
							continue;
						}
						case 4:
							_ = __KnownINotifyPropertyChangingArgs.Summary;
							_ = 0;
							awaiter = (nint)MarshalInterface<IEnumerator<IDisposable>>.FromManaged((IEnumerator<IDisposable>)IReadOnlyList_object.Init());
							_ = 10;
							if (__KnownINotifyPropertyChangingArgs.Executor != null)
							{
								_ = 10;
							}
							continue;
						case 26:
							awaiter = __KnownINotifyPropertyChangingArgs.LaunchTime;
							num = 9;
							if (__KnownINotifyPropertyChangingArgs.StateText == null)
							{
								num = 2;
							}
							continue;
						case 1:
							__KnownINotifyPropertyChangingArgs.OperationText = null;
							num = 20;
							continue;
						default:
							if (awaiter != null)
							{
								num = 2;
								continue;
							}
							goto case 25;
						case 6:
						case 17:
						case 29:
							goto end_IL_0026;
						}
						break;
					}
					goto IL_01b5;
					end_IL_0026:
					break;
				}
				__KnownINotifyPropertyChangingArgs.Quantity = (PropertyChangingEventArgs)(-2);
				obj = 0;
				if (__KnownINotifyPropertyChangingArgs.MobileAccounts == null)
				{
					obj = 0;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00笀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778965, new IntPtr(2737336604236L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00簀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00紀()
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
		internal unsafe static object _FF00_FF00_FF00縀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778962, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00缀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00耀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778963, new IntPtr(2737336594876L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CFastStart_003Ed__80 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopGameModel _003C_003E4__this;

		private object _003C_003E8__1;

		private TaskAwaiter<string?> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private static object ReflectCustomAnnotation;

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
		internal static bool EncodeSolver()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ExcludeTester()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00漀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778960, new IntPtr(2737336594876L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00瀀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0047: Expected I4, but got Obj
			//IL_0079: Expected Obj, but got Ref
			//IL_0052: Expected Obj, but got Ref
			//IL_0054: Expected Obj, but got I
			//IL_00c8: Expected Obj, but got Ref
			//IL_00a2: Expected Obj, but got Ref
			//IL_008b: Expected Obj, but got Ref
			//IL_0090: Expected Obj, but got Ref
			//IL_00e3: Expected Obj, but got I4
			//IL_0515: Expected Obj, but got Ref
			//IL_0171: Expected I4, but got Obj
			//IL_03fe: Expected Obj, but got Ref
			//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0459: Expected Obj, but got Ref
			//IL_045b: Expected Obj, but got I
			//IL_031e: Expected Obj, but got Ref
			//IL_04f0: Expected Obj, but got Ref
			//IL_023d: Expected I, but got Obj
			//IL_0242: Expected Obj, but got I4
			//IL_0242: Expected I4, but got Obj
			//IL_0280: Expected I4, but got Obj
			//IL_0286: Expected Obj, but got Ref
			//IL_037d: Expected Obj, but got Ref
			//IL_0386: Expected Obj, but got I4
			//IL_04c3: Expected Obj, but got Ref
			//IL_0366: Expected Obj, but got I4
			//IL_036b: Expected Obj, but got I4
			//IL_036b: Expected Obj, but got Ref
			//IL_03a5: Expected Obj, but got Ref
			//IL_03ad: Expected Obj, but got Ref
			//IL_03ad: Expected Obj, but got Ref
			//IL_054c: Expected Obj, but got I4
			//IL_0551: Expected Obj, but got I4
			//IL_0551: Expected Obj, but got Ref
			//IL_04ac: Expected Obj, but got I4
			//IL_04b1: Expected Obj, but got I4
			//IL_04b1: Expected Obj, but got Ref
			//IL_0390: Expected Obj, but got I4
			//IL_0395: Expected Obj, but got I4
			//IL_0395: Expected Obj, but got Ref
			//IL_01b0: Expected I, but got Obj
			//IL_04d3: Expected Obj, but got Ref
			//IL_02d7: Expected Obj, but got Ref
			//IL_0429: Expected Obj, but got Ref
			//IL_03d2: Expected Obj, but got Ref
			//IL_0085->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00d2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00b6->IL0026: Incompatible stack types: I4 vs Obj
			//IL_009a->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0073->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00c1->IL0026: Incompatible stack types: I4 vs Obj
			//IL_052b->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_01f6->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_0536->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_0201->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_0418->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_046f->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_0334->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_0504->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_0547->IL00ec: Incompatible stack heights: 3 vs 1
			//IL_024e->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_02a6->IL00ec: Incompatible stack heights: 2 vs 1
			//IL_04cd->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_0375->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_03c1->IL00ec: Incompatible stack heights: 3 vs 1
			//IL_055b->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_04bb->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_039f->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_01cf->IL00ec: Incompatible stack heights: 3 vs 1
			//IL_049c->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_04e5->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_02e7->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_03ed->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_0423->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_047a->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_033f->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_050f->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_026e->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_02c6->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_03cc->IL00ec: Incompatible stack heights: 3 vs 1
			//IL_021f->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_01da->IL00ec: Incompatible stack heights: 3 vs 1
			//IL_04a7->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_0447->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_03f8->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_0279->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_02d1->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_022a->IL00ec: Incompatible stack types: I4 vs Obj
			//IL_0452->IL00ec: Incompatible stack types: I4 vs Obj
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 1;
			object obj = awaiter;
			while (true)
			{
				object obj2;
				switch ((int)obj)
				{
				case 1:
					awaiter = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
					obj = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj = 0;
					}
					break;
				default:
					awaiter = IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute;
					obj = 3;
					break;
				case 6:
					MarshalInspectable<object>.FromAbiArray((object)Unsafe.AsPointer(ref IList_object._initialized));
					_ = 4;
					break;
				case 5:
					IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized = -2;
					obj = 2;
					if (IReadOnlyList_System_IDisposable._initialized != 0)
					{
						obj = 2;
					}
					break;
				case 2:
					IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = null;
					obj = 6;
					break;
				case 3:
					if (awaiter == null)
					{
						awaiter = 31;
						goto IL_00e8;
					}
					goto IL_01da;
				case 4:
					return;
					IL_01da:
					if ((nint)awaiter != 1)
					{
						obj2 = 5;
						if (Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute != null)
						{
							obj2 = 3;
						}
						goto IL_00ec;
					}
					goto IL_050f;
					IL_050f:
					awaiter = __KnownINotifyPropertyChangingArgs.Image;
					obj2 = 1;
					if (__KnownINotifyPropertyChangingArgs.JoinedAt != null)
					{
						obj2 = 1;
					}
					goto IL_00ec;
					IL_00ec:
					while (true)
					{
						switch ((int)obj2)
						{
						case 22:
							MarshalInterface<INotifyPropertyChanged>.CopyManagedArray((INotifyPropertyChanged[])/*Error near IL_01b5: Stack underflow*/, (IntPtr)(int)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1((nint)(int)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3((nint)/*Error near IL_01a9: Stack underflow*/, (uint)/*Error near IL_01a9: Stack underflow*/, (uint)/*Error near IL_01a9: Stack underflow*/, (nint)/*Error near IL_01a9: Stack underflow*/, (uint*)(int)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_IndexOf_2((nint)/*Error near IL_01a4: Stack underflow*/, (nint)/*Error near IL_01a4: Stack underflow*/, (uint*)/*Error near IL_01a4: Stack underflow*/, (byte*)IEnumerator_System_IDisposable._initialized)), (uint*)(nint)awaiter));
							_ = null;
							IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.MoveAttribute();
							_ = 23;
							if (Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute != null)
							{
								_ = 14;
							}
							continue;
						case 18:
							goto IL_01da;
						case 21:
							IEnumerable_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
							if ((int)/*Error near IL_020b: Stack underflow*/ == 0)
							{
								obj2 = 0;
								if (Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute != null)
								{
									obj2 = 0;
								}
								continue;
							}
							goto case 22;
						case 7:
							IListMethods<object>.Abi_InsertAt_5((IntPtr)/*Error near IL_0242: Stack underflow*/, (uint)(int)awaiter, (object)IList_object.Do_Abi_GetAt_0((nint)awaiter, IList_object.Initialized ? 1u : 0u, (nint*)(int)IList_object.Init()));
							awaiter = (object)/*Error near IL_0244: Stack underflow*/;
							obj2 = 10;
							continue;
						case 10:
							IListMethods<object>.Abi_RemoveAt_6((IntPtr)/*Error near IL_0255: Stack underflow*/, (uint)(&awaiter));
							if ((int)/*Error near IL_025a: Stack underflow*/ == 0)
							{
								obj2 = 20;
								if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.Instance != null)
								{
									obj2 = 10;
								}
								continue;
							}
							goto case 6;
						case 8:
						{
							uint _itemsSize = IList_object.Do_Abi_RemoveAt_6((nint)/*Error near IL_0280: Stack underflow*/, (uint)(int)awaiter);
							((AsyncTaskMethodBuilder*)_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner.CheckOperationalModule)->Start(ref *(AccountViewModel._003CLoginMobile_003Ed__88*)new IListMethods<object>((IntPtr)(nint)(delegate* unmanaged[Stdcall]<nint, uint>)(&IList_object.Do_Abi_RemoveAtEnd_8)));
							IList_object.Do_Abi_ReplaceAll_11((nint)/*Error near IL_029c: Stack underflow*/, _itemsSize, (nint)1);
							_ = 7;
							continue;
						}
						case 14:
							if (IEnumeratorMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)/*Error near IL_02ad: Stack underflow*/, ref *(INotifyPropertyChanged[]*)(&awaiter)) != 0)
							{
								obj2 = 24;
								if (__KnownINotifyPropertyChangingArgs.CreateAt != null)
								{
									obj2 = 5;
								}
								continue;
							}
							goto case 19;
						case 27:
							__KnownINotifyPropertyChangingArgs.LoginAt = null;
							obj2 = 13;
							continue;
						case 2:
							return;
						case 28:
							return;
						case 4:
						case 31:
							awaiter = __KnownINotifyPropertyChangingArgs.IsMyself;
							obj2 = 27;
							if (__KnownINotifyPropertyChangingArgs.CharacterName == null)
							{
								obj2 = 16;
							}
							continue;
						case 13:
							awaiter = -1;
							__KnownINotifyPropertyChangingArgs.Content = (PropertyChangingEventArgs)(-1);
							obj2 = 3;
							continue;
						case 9:
							goto IL_0375;
						case 20:
							awaiter = 1;
							__KnownINotifyPropertyChangingArgs.IsSkeleton = (PropertyChangingEventArgs)1;
							obj2 = 11;
							continue;
						case 15:
							_ = ref __KnownINotifyPropertyChangingArgs.CanProxy;
							IMessengerExtensions.Send<SessionChangedMessage>((IMessenger)(object)(&awaiter), (SessionChangedMessage)Unsafe.AsPointer(ref this));
							_ = 27;
							if (__KnownINotifyPropertyChangingArgs.MaxPlayers == null)
							{
								_ = 28;
							}
							continue;
						case 30:
							__KnownINotifyPropertyChangingArgs.Description = (PropertyChangingEventArgs)awaiter;
							obj2 = 29;
							if (__KnownINotifyPropertyChangingArgs.ImageUrl != null)
							{
								obj2 = 29;
							}
							continue;
						case 1:
							__KnownINotifyPropertyChangingArgs.Characters = (PropertyChangingEventArgs)default(IContentControlOverridesMethods);
							obj2 = 14;
							if (__KnownINotifyPropertyChangingArgs.Summary == null)
							{
								obj2 = 17;
							}
							continue;
						case 29:
							if (__KnownINotifyPropertyChangingArgs.SourceImage == null)
							{
								obj2 = 4;
								if (__KnownINotifyPropertyChangingArgs.Executor != null)
								{
									obj2 = 16;
								}
								continue;
							}
							goto case 8;
						case 3:
						case 24:
							awaiter = (nint)MarshalInterface<IEnumerator<object>>.FromManaged((IEnumerator<object>)(&awaiter));
							obj2 = 30;
							if (__KnownINotifyPropertyChangingArgs.StateText == null)
							{
								obj2 = 10;
							}
							continue;
						case 23:
						{
							object obj3 = awaiter;
							ComWrappersSupport.RegisterTypeComInterfaceEntriesLookup((Func<Type, ComWrappers.ComInterfaceEntry[]>)(object)IReadOnlyList_object.DecorateControllableAttribute());
							awaiter = obj3;
							obj2 = 6;
							if (__KnownINotifyPropertyChangingArgs.CanDelete == null)
							{
								obj2 = 14;
							}
							continue;
						}
						case 19:
							awaiter = 0;
							__KnownINotifyPropertyChangingArgs.Id = (PropertyChangingEventArgs)0;
							obj2 = 9;
							continue;
						case 11:
							__KnownINotifyPropertyChangingArgs.OrderId = (PropertyChangingEventArgs)awaiter;
							obj2 = 25;
							continue;
						case 25:
							Unsafe.As<PropertyChangingEventArgs, AsyncTaskMethodBuilder>(ref __KnownINotifyPropertyChangingArgs.Price).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CFastStart_003Ed__80, ChatViewModel._003CSend_003Ed__9>(ref this));
							obj2 = 2;
							continue;
						case 5:
							__KnownINotifyPropertyChangingArgs.PayAt = (PropertyChangingEventArgs)new IEnumerator_System_IDisposable();
							obj2 = 21;
							if (__KnownINotifyPropertyChangingArgs.PayUrl == null)
							{
								obj2 = 14;
							}
							continue;
						case 26:
							goto IL_050f;
						case 6:
							_ = ref awaiter;
							_ = INotifyCollectionChangedMethods.AbiToProjectionVftablePtr;
							_ = 12;
							continue;
						case 17:
							awaiter = -1;
							__KnownINotifyPropertyChangingArgs.TotalPoints = (PropertyChangingEventArgs)(-1);
							obj2 = 6;
							continue;
						}
						break;
					}
					goto case 5;
					IL_0375:
					__KnownINotifyPropertyChangingArgs.IsSelected = (PropertyChangingEventArgs)awaiter;
					awaiter = 15;
					goto IL_00e8;
					IL_00e8:
					obj2 = awaiter;
					goto IL_00ec;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00焀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778961, new IntPtr(2737336594876L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00爀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00猀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778974, new IntPtr(2737336590716L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00琀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778975, new IntPtr(2737336596956L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00甀()
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
		private unsafe sealed void _FF00_FF00_FF00瘀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00眀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778972, new IntPtr(2737336591756L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLaunchGame_003Ed__82 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopGameModel _003C_003E4__this;

		public SectionValue gameValue;

		public SectionValue proxyValue;

		private object _003CgameId_003E5__2;

		private object _003Cname_003E5__3;

		private TaskAwaiter<JavaGame> _003C_003Eu__1;

		private TaskAwaiter<(bool IsConfirmed, string Text)> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		internal static object DecorateMixedCommand;

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
		internal static bool DecorateFlexibleConsumer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PresentDecryptor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00昀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778973, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00最()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_004b: Expected I4, but got Obj
			//IL_00a4: Expected Obj, but got Ref
			//IL_0efa: Expected Obj, but got Ref
			//IL_007d: Expected Obj, but got Ref
			//IL_007f: Expected Obj, but got I
			//IL_0069: Expected Obj, but got Ref
			//IL_0072: Expected Obj, but got I4
			//IL_0058: Expected Obj, but got Ref
			//IL_0f22: Expected Obj, but got Ref
			//IL_0add: Expected Obj, but got Ref
			//IL_0cc5: Expected Obj, but got Ref
			//IL_0ccb: Expected Obj, but got Ref
			//IL_0cd0: Expected VT, but got Obj
			//IL_0b23: Expected Obj, but got I4
			//IL_0b28: Expected Obj, but got I4
			//IL_0b28: Expected Obj, but got Ref
			//IL_027a: Expected Obj, but got Ref
			//IL_0dfa: Expected I4, but got Obj
			//IL_0dfa: Expected Obj, but got Ref
			//IL_0e04: Expected Obj, but got I4
			//IL_0d55: Expected Obj, but got I4
			//IL_0c7c: Expected Obj, but got I4
			//IL_0bbd: Expected Obj, but got Ref
			//IL_0d2c: Expected I4, but got Obj
			//IL_0d31: Expected VT, but got I4
			//IL_0d0b: Expected I4, but got Obj
			//IL_0d0b: Expected Obj, but got Ref
			//IL_0d1e: Expected Obj, but got I4
			//IL_0d95: Expected Obj, but got Ref
			//IL_0d9d: Expected Obj, but got Ref
			//IL_0b4f: Expected Obj, but got Ref
			//IL_0b58: Expected Obj, but got I4
			//IL_0b7f: Expected Obj, but got I4
			//IL_018e: Expected Obj, but got I4
			//IL_0193: Expected Obj, but got I4
			//IL_0193: Expected Obj, but got Ref
			//IL_0dd6: Expected I4, but got Obj
			//IL_01ab: Expected Obj, but got I4
			//IL_01ce: Expected Obj, but got Ref
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_0262: Unknown result type (might be due to invalid IL or missing references)
			//IL_0264: Invalid comparison between Unknown and I4
			//IL_0b01: Expected Obj, but got I4
			//IL_0b0a: Expected Obj, but got I4
			//IL_0298: Expected I4, but got Obj
			//IL_0dae: Expected I4, but got Obj
			//IL_0952: Expected Obj, but got Ref
			//IL_06a7: Expected Obj, but got Ref
			//IL_040c: Expected Obj, but got Ref
			//IL_040e: Expected Obj, but got VT
			//IL_041d: Expected Obj, but got I4
			//IL_0dbc: Expected Obj, but got I4
			//IL_0184: Expected I4, but got Obj
			//IL_0879: Expected Obj, but got I4
			//IL_087e: Expected Obj, but got I4
			//IL_087e: Expected Obj, but got Ref
			//IL_09fe: Expected Obj, but got Ref
			//IL_0813: Expected Obj, but got Ref
			//IL_081b: Expected Obj, but got Ref
			//IL_081b: Expected Obj, but got Ref
			//IL_05c2: Expected I4, but got Obj
			//IL_05cc: Expected I, but got Obj
			//IL_05e0: Expected Obj, but got I4
			//IL_0840: Expected Obj, but got Ref
			//IL_0433: Expected Obj, but got Ref
			//IL_08cb: Expected Obj, but got I4
			//IL_08d0: Expected Obj, but got I4
			//IL_08d0: Expected Obj, but got Ref
			//IL_0598: Expected Obj, but got Ref
			//IL_059e: Expected Obj, but got Ref
			//IL_05a3: Expected I, but got Obj
			//IL_05a5: Expected Obj, but got I4
			//IL_05ae: Expected Obj, but got I4
			//IL_08a2: Expected Obj, but got I4
			//IL_08a7: Expected Obj, but got I4
			//IL_08a7: Expected Obj, but got Ref
			//IL_03b4: Expected I, but got Obj
			//IL_03b9: Expected Obj, but got I4
			//IL_07e3: Expected Obj, but got Ref
			//IL_07e9: Expected Obj, but got Ref
			//IL_07f1: Expected Obj, but got Ref
			//IL_07f7: Expected Obj, but got Ref
			//IL_0803: Expected Obj, but got Ref
			//IL_04cb: Expected Obj, but got I4
			//IL_04d0: Expected Obj, but got I4
			//IL_04d0: Expected Obj, but got Ref
			//IL_03df: Expected Obj, but got I4
			//IL_03e4: Expected Obj, but got I4
			//IL_03e4: Expected Obj, but got Ref
			//IL_0942: Expected Obj, but got Ref
			//IL_06ff: Expected Obj, but got Ref
			//IL_0707: Expected Obj, but got Ref
			//IL_05f8: Expected Obj, but got I4
			//IL_05fe: Expected Obj, but got Ref
			//IL_0604: Expected Obj, but got Ref
			//IL_060a: Expected Obj, but got Ref
			//IL_060f: Expected I, but got Obj
			//IL_060f: Expected I, but got Obj
			//IL_0620: Expected Obj, but got I
			//IL_097e: Expected Obj, but got I4
			//IL_0981: Expected Obj, but got I4
			//IL_09c7: Expected VT, but got Ref
			//IL_09c9: Expected Obj, but got I4
			//IL_03f4: Expected Obj, but got Ref
			//IL_078d: Expected Obj, but got Ref
			//IL_0460: Expected Obj, but got Ref
			//IL_053d: Expected Obj, but got I4
			//IL_047e: Expected Obj, but got I4
			//IL_0483: Expected Obj, but got I4
			//IL_0483: Expected Obj, but got Ref
			//IL_00b3->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0f10->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0093->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0062->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0f36->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0f1b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_009e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00d0->IL00df: Incompatible stack types: I4 vs Obj
			//IL_0f41->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0af3->IL00df: Incompatible stack types: I4 vs Obj
			//IL_0df2->IL00df: Incompatible stack types: I4 vs Obj
			//IL_00db->IL00df: Incompatible stack types: I4 vs Obj
			//IL_0afe->IL00df: Incompatible stack types: I4 vs Obj
			//IL_0cd5->IL0dc1: Incompatible stack heights: 1 vs 0
			//IL_0b3c->IL00df: Incompatible stack types: I4 vs Obj
			//IL_0c4e->IL0273: Incompatible stack heights: 1 vs 0
			//IL_0284->IL00df: Incompatible stack heights: 2 vs 1
			//IL_0e18->IL00df: Incompatible stack types: I4 vs Obj
			//IL_0d6a->IL00df: Incompatible stack heights: 2 vs 1
			//IL_0c90->IL00df: Incompatible stack types: I4 vs Obj
			//IL_0bcc->IL00df: Incompatible stack heights: 2 vs 1
			//IL_0c37->IL00df: Incompatible stack heights: 2 vs 1
			//IL_0c0a->IL00df: Incompatible stack types: I4 vs Obj
			//IL_0d3b->IL00df: Incompatible stack types: I4 vs Obj
			//IL_0da7->IL00df: Incompatible stack heights: 4 vs 1
			//IL_0b93->IL00df: Incompatible stack types: I4 vs Obj
			//IL_019d->IL00df: Incompatible stack types: I4 vs Obj
			//IL_021c->IL00df: Incompatible stack heights: 4 vs 1
			//IL_0de0->IL00df: Incompatible stack types: I4 vs Obj
			//IL_01b5->IL00df: Incompatible stack heights: 4 vs 1
			//IL_0d8f->IL00df: Incompatible stack types: I4 vs Obj
			//IL_01de->IL00df: Incompatible stack types: I4 vs Obj
			//IL_0b7c->IL00df: Incompatible stack heights: 2 vs 1
			//IL_0cdf->IL00df: Incompatible stack heights: 2 vs 1
			//IL_0b47->IL00df: Incompatible stack types: I4 vs Obj
			//IL_0c62->IL00df: Incompatible stack heights: 2 vs 1
			//IL_0e23->IL00df: Incompatible stack types: I4 vs Obj
			//IL_0d75->IL00df: Incompatible stack heights: 2 vs 1
			//IL_0c9b->IL00df: Incompatible stack types: I4 vs Obj
			//IL_025f->IL00df: Incompatible stack types: I4 vs Obj
			//IL_0c42->IL00df: Incompatible stack heights: 2 vs 1
			//IL_0c15->IL00df: Incompatible stack types: I4 vs Obj
			//IL_0b9e->IL00df: Incompatible stack types: I4 vs Obj
			//IL_01ef->IL00df: Incompatible stack types: I4 vs Obj
			//IL_0227->IL00df: Incompatible stack heights: 4 vs 1
			//IL_0273->IL00df: Incompatible stack types: I4 vs Obj
			//IL_0c6d->IL00df: Incompatible stack heights: 2 vs 1
			//IL_082f->IL02a6: Incompatible stack heights: 3 vs 1
			//IL_071d->IL08c6: Incompatible stack heights: 1 vs 0
			//IL_080d->IL02a6: Incompatible stack heights: 7 vs 1
			//IL_0733->IL05b3: Incompatible stack heights: 1 vs 0
			//IL_0711->IL02a6: Incompatible stack heights: 4 vs 1
			//IL_062a->IL02a6: Incompatible stack heights: 5 vs 1
			//IL_0406->IL02a6: Incompatible stack heights: 2 vs 1
			//IL_0553->IL02a6: Incompatible stack heights: 2 vs 1
			//IL_077c->IL02a6: Incompatible stack heights: 6 vs 1
			//IL_0636->IL0973: Incompatible stack heights: 1 vs 0
			//IL_083a->IL02a6: Incompatible stack heights: 3 vs 1
			//IL_0727->IL02a6: Incompatible stack heights: 2 vs 1
			//IL_02a6->IL02a6: Incompatible stack heights: 4 vs 1
			//IL_0747->IL02a6: Incompatible stack heights: 2 vs 1
			//IL_055e->IL02a6: Incompatible stack heights: 2 vs 1
			//IL_0787->IL02a6: Incompatible stack heights: 6 vs 1
			//IL_064a->IL02a6: Incompatible stack heights: 2 vs 1
			//IL_0752->IL02a6: Incompatible stack heights: 2 vs 1
			//IL_0655->IL02a6: Incompatible stack heights: 2 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					object obj3;
					switch ((int)obj2)
					{
					case 6:
						IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = -2;
						obj2 = 3;
						continue;
					case 3:
						break;
					case 2:
						obj = IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized;
						obj2 = 0;
						if (IList_object._initialized == 0)
						{
							obj2 = 1;
						}
						continue;
					default:
						IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)(nint)Unsafe.AsPointer(ref IList_object.PatchAttribute));
						_ = 4;
						continue;
					case 5:
						if ((nuint)(nint)obj <= (nuint)2u)
						{
							obj3 = 1;
							if (IReadOnlyList_System_IDisposable._initialized == 0)
							{
								obj3 = 8;
							}
							goto IL_00df;
						}
						goto IL_0de0;
					case 4:
						return;
					case 1:
						obj = __KnownINotifyPropertyChangedArgs.InputEmail;
						obj2 = 5;
						if (__KnownINotifyPropertyChangedArgs.Input4399Password == null)
						{
							obj2 = 0;
						}
						continue;
					case 7:
						{
							__KnownINotifyPropertyChangedArgs.Input163Password = null;
							obj2 = 0;
							if (__KnownINotifyPropertyChangedArgs.InputMobile != null)
							{
								obj2 = 0;
							}
							continue;
						}
						IL_0ad7:
						obj = __KnownINotifyPropertyChangingArgs.SelectedProductGroup;
						obj3 = 13;
						if (__KnownINotifyPropertyChangingArgs.TopUps == null)
						{
							obj3 = 33;
						}
						goto IL_00df;
						IL_00df:
						while (true)
						{
							switch ((int)obj3)
							{
							case 2:
							case 15:
							case 21:
							case 23:
							case 37:
								break;
							case 24:
								obj = -1;
								IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = -1;
								obj3 = 4;
								continue;
							case 30:
								MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Initialized);
								_ = 9;
								continue;
							case 33:
								IEnumerator_System_IDisposable._initialized = unchecked((nint)default(ButtonBase));
								obj3 = 24;
								continue;
							case 5:
							case 22:
								if (obj == null)
								{
									obj3 = 27;
									continue;
								}
								goto case 7;
							case 25:
								IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Size_1((nint)/*Error near IL_01f9: Stack underflow*/, (uint*)IEnumerable_System_IDisposable._initialized);
								IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
								IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.MoveAttribute();
								IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.CheckSymbolicAttribute();
								_ = 14;
								if (Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails.ReflectVisibleAttribute == null)
								{
									_ = 14;
								}
								continue;
							case 12:
								if (!IEnumerable_System_ComponentModel_INotifyPropertyChanged.DecorateSeparatedAttribute())
								{
									obj3 = 23;
									continue;
								}
								goto case 39;
							case 35:
								if (obj - 2 <= 1)
								{
									obj3 = 20;
									continue;
								}
								goto case 36;
							case 4:
								MarshalInterface<IReadOnlyList<object>>.FromManaged((IReadOnlyList<object>)(&obj));
								_ = 2;
								continue;
							case 38:
							{
								int num;
								switch ((int)obj)
								{
								default:
									num = 46;
									goto IL_02a6;
								case 2:
									goto IL_0406;
								case 1:
									goto IL_06a1;
								case 0:
									goto IL_094c;
									IL_02a6:
									while (true)
									{
										switch (num)
										{
										case 37:
										case 43:
											break;
										case 48:
											obj = MarshalInspectable<object>.FromAbi((IntPtr)(nint)(&obj));
											num = 16;
											continue;
										case 29:
											if (!IListMethods<object>.Abi_IndexOf_3((IntPtr)/*Error near IL_039e: Stack underflow*/, (object)/*Error near IL_039e: Stack underflow*/, ref *(uint*)(&obj)))
											{
												num = 19;
												continue;
											}
											goto case 48;
										case 6:
										case 20:
										{
											uint num3 = IList_object.Do_Abi_GetAt_0((nint)/*Error near IL_03b4: Stack underflow*/, (uint)/*Error near IL_03b4: Stack underflow*/, (nint*)(nint)obj);
											obj = ((((object)num3) is IReadOnlyListMethods<, >) ? ((object)num3) : null);
											num = 5;
											if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute != null)
											{
												num = 31;
											}
											continue;
										}
										case 25:
											obj = -1;
											_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.Instance = (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0)(-1);
											num = 38;
											continue;
										case 41:
											_ = ref _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.ReflectLiteralAttribute;
											((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CLaunchGame_003Ed__82, AccountViewModel._003CLoginRandom_003Ed__85>(ref this));
											_ = 26;
											continue;
										case 3:
											goto IL_0406;
										case 12:
											__KnownINotifyPropertyChangingArgs.Notes = null;
											num = 11;
											if (__KnownINotifyPropertyChangingArgs.CreateAt == null)
											{
												num = 49;
											}
											continue;
										case 45:
											__KnownINotifyPropertyChangingArgs.LoginAt = (PropertyChangingEventArgs)obj;
											num = 28;
											continue;
										case 44:
											return;
										case 49:
											obj = -1;
											__KnownINotifyPropertyChangingArgs.Name = (PropertyChangingEventArgs)(-1);
											num = 13;
											if (__KnownINotifyPropertyChangingArgs.Message != null)
											{
												num = 48;
											}
											continue;
										case 22:
											obj = -1;
											__KnownINotifyPropertyChangingArgs.IsSelected = (PropertyChangingEventArgs)(-1);
											num = 40;
											continue;
										case 46:
										{
											byte b = IReadOnlyList_System_IDisposable.Init();
											obj = ((((object)b) is IAnimationObjectMethods) ? ((object)b) : null);
											_ = 2;
											if (__KnownINotifyPropertyChangingArgs.Version != null)
											{
												_ = 15;
											}
											continue;
										}
										case 26:
											return;
										case 18:
											IReadOnlyList_System_IDisposable.Do_Abi_get_Size_1((nint)/*Error near IL_0590: Stack underflow*/, (uint*)/*Error near IL_0590: Stack underflow*/);
											_ = __KnownINotifyPropertyChangingArgs.Characters;
											obj = IEnumeratorMethods<IDisposable>.Abi_get_HasCurrent_1((IntPtr)__KnownINotifyPropertyChangingArgs.BackgroundImageUrl);
											obj = 9;
											continue;
										case 8:
										{
											uint num2 = IReadOnlyList_object.Do_Abi_get_Size_1((nint)/*Error near IL_05d1: Stack underflow*/, (uint*)(int)IReadOnlyList_object.Do_Abi_GetMany_3((nint)/*Error near IL_05cc: Stack underflow*/, (uint)/*Error near IL_05cc: Stack underflow*/, (uint)/*Error near IL_05cc: Stack underflow*/, (nint)(int)IReadOnlyList_object.Do_Abi_GetAt_0((nint)/*Error near IL_05c2: Stack underflow*/, (uint)(int)__KnownINotifyPropertyChangingArgs.Summary, (nint*)(int)IReadOnlyList_object.Init()), (uint*)(nint)__KnownINotifyPropertyChangingArgs.Title));
											IReadOnlyList_object._002Ecctor();
											((Func<Type, ComWrappers.ComInterfaceEntry[]>)/*Error near IL_05e0: Stack underflow*/)._002Ector((object)num2, (nint)(IReadOnlyList_object.ReflectSimpleAttribute() ? 1 : 0));
											obj = (object)/*Error near IL_05e2: Stack underflow*/;
											num = 51;
											continue;
										}
										case 33:
											new string((string?)IEnumerator_System_IDisposable.Initialized, (string?)obj);
											_ = __KnownINotifyPropertyChangingArgs.CanDelete;
											IEnumerator_System_IDisposable.Do_Abi_get_HasCurrent_1((nint)__KnownINotifyPropertyChangingArgs.Id, (byte*)(nint)__KnownINotifyPropertyChangingArgs.OrderId);
											IEnumerator_System_IDisposable._002Ecctor();
											_ = IEnumerableMethods<object>.IID;
											obj = (nint)IEnumerableMethods<object>.AbiToProjectionVftablePtr;
											_ = 11;
											continue;
										case 51:
											_ = ref obj;
											if ((int)IListMethods.IID == 0)
											{
												_ = 0;
												if (__KnownINotifyPropertyChangingArgs.Image == null)
												{
													_ = 0;
												}
												continue;
											}
											goto case 38;
										case 31:
											if (obj == null)
											{
												num = 25;
												if (__KnownINotifyPropertyChangingArgs.JoinedAt == null)
												{
													num = 34;
												}
												continue;
											}
											goto case 24;
										case 36:
											if (obj == null)
											{
												num = 17;
												if (__KnownINotifyPropertyChangingArgs.TotalPoints == null)
												{
													num = 15;
												}
												continue;
											}
											goto case 18;
										case 30:
											goto IL_06a1;
										case 24:
											obj = null;
											num = 17;
											if (__KnownINotifyPropertyChangingArgs.MobileAccounts == null)
											{
												num = 23;
											}
											continue;
										case 28:
											_ = ref __KnownINotifyPropertyChangingArgs.SelectedAccounts;
											_ = ref obj;
											((IEnumerable<DesktopGameModel>)Unsafe.AsPointer(ref this)).ToList();
											_ = 44;
											continue;
										case 11:
											_ = ref obj;
											if ((int)IEnumeratorMethods<INotifyPropertyChanged>.IID != 0)
											{
												_ = 47;
												continue;
											}
											goto case 13;
										case 23:
											if (IEnumeratorMethods<INotifyPropertyChanged>.AbiToProjectionVftablePtr == (IntPtr)0)
											{
												_ = 1;
												if (__KnownINotifyPropertyChangingArgs.InputCookie == null)
												{
													_ = 1;
												}
												continue;
											}
											goto case 8;
										case 17:
										case 50:
											_ = __KnownINotifyPropertyChangingArgs.Input4399Password;
											Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.DecorateGeneralAttribute();
											Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.NewAttribute();
											_ = null;
											((Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails)null).GetExposedInterfaces();
											_ = 5;
											if (__KnownINotifyPropertyChangingArgs.VerifyCodeDelayText == null)
											{
												_ = 43;
											}
											continue;
										case 42:
											__KnownINotifyPropertyChangingArgs.InfoBarMessage = null;
											num = 22;
											if (__KnownINotifyPropertyChangingArgs.IsDragging == null)
											{
												num = 22;
											}
											continue;
										case 15:
											if (obj == null)
											{
												num = 6;
												if (__KnownINotifyPropertyChangingArgs.SelectedFileName == null)
												{
													num = 4;
												}
												continue;
											}
											goto case 33;
										case 1:
										case 21:
											((Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails)/*Error near IL_07dd: Stack underflow*/)._002Ector();
											_ = __KnownINotifyPropertyChangingArgs.ParsedCount;
											_ = __KnownINotifyPropertyChangingArgs.ImportedCount;
											_ = __KnownINotifyPropertyChangingArgs.SkippedCount;
											_ = __KnownINotifyPropertyChangingArgs.ParsedAccounts;
											_ = IFrameworkElementOverridesMethods.AbiToProjectionVftablePtr;
											obj = (nint)IControlOverridesMethods.IID;
											_ = 29;
											continue;
										case 4:
											_ = ref __KnownINotifyPropertyChangingArgs.SelectedGame;
											((IEnumerable<EntityNetGameItem>)(&obj)).Where((Func<EntityNetGameItem, bool>)Unsafe.AsPointer(ref this));
											_ = 0;
											if (__KnownINotifyPropertyChangingArgs.LanGamesEmptyText != null)
											{
												_ = 5;
											}
											continue;
										case 10:
											__KnownINotifyPropertyChangingArgs.NetGames = null;
											num = 25;
											continue;
										default:
											obj = 1;
											__KnownINotifyPropertyChangingArgs.LikeNetGamesEmptyText = (PropertyChangingEventArgs)1;
											num = 2;
											if (__KnownINotifyPropertyChangingArgs.RentalGamesEmptyText != null)
											{
												num = 0;
											}
											continue;
										case 19:
											obj = 2;
											__KnownINotifyPropertyChangingArgs.Skins = (PropertyChangingEventArgs)2;
											num = 45;
											if (__KnownINotifyPropertyChangingArgs.CurrentSkinPage != null)
											{
												num = 35;
											}
											continue;
										case 13:
											obj = 0;
											__KnownINotifyPropertyChangingArgs.SkinAllSelected = (PropertyChangingEventArgs)0;
											num = 27;
											continue;
										case 34:
										case 35:
											((Mass_WinUI_Controls_AddAccountDialogWinRTTypeDetails)obj)._002Ector();
											obj = (object)/*isinst with value type is only supported in some contexts*/;
											num = 36;
											continue;
										case 5:
											return;
										case 27:
											__KnownINotifyPropertyChangingArgs.LastSearchText = (PropertyChangingEventArgs)obj;
											num = 4;
											continue;
										case 7:
											goto IL_094c;
										case 38:
										{
											int length = ((ReadOnlySpan<char>*)(&obj))->Length;
											obj = length;
											obj = length;
											num = 52;
											continue;
										}
										case 52:
											if (obj == null)
											{
												num = 37;
												if (__KnownINotifyPropertyChangingArgs.NativeProtocolExpirationTimeText != null)
												{
													num = 21;
												}
												continue;
											}
											goto case 32;
										case 40:
										case 47:
											obj = MemoryExtensions.IndexOf<T>((ReadOnlySpan<T>)/*Error near IL_09c7: Stack underflow*/, (T)(&obj));
											num = 39;
											continue;
										case 32:
											obj = obj;
											num = 21;
											if (__KnownINotifyPropertyChangingArgs.Instances == null)
											{
												num = 4;
											}
											continue;
										case 2:
											__KnownINotifyPropertyChangingArgs.InputUsername = (PropertyChangingEventArgs)obj;
											num = 1;
											if (__KnownINotifyPropertyChangingArgs.InputInviteCode == null)
											{
												num = 41;
											}
											continue;
										case 9:
										case 14:
										case 16:
										case 39:
											goto IL_0d23;
										}
										break;
									}
									break;
									IL_094c:
									obj = __KnownINotifyPropertyChangingArgs.SearchVisibility;
									num = 31;
									if (__KnownINotifyPropertyChangingArgs.AllResources != null)
									{
										num = 42;
									}
									goto IL_02a6;
									IL_0406:
									obj = _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout;
									num = 7;
									if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator == null)
									{
										num = 12;
									}
									goto IL_02a6;
									IL_06a1:
									obj = __KnownINotifyPropertyChangingArgs.Amount;
									num = 10;
									if (__KnownINotifyPropertyChangingArgs.Quantity == null)
									{
										num = 4;
									}
									goto IL_02a6;
								}
								break;
							}
							case 29:
								goto IL_0ad7;
							case 36:
								obj = 0;
								obj = 22;
								goto IL_00db;
							case 1:
								obj = 3;
								__KnownINotifyPropertyChangingArgs.TopUpGroups = (PropertyChangingEventArgs)3;
								obj3 = 19;
								if (__KnownINotifyPropertyChangingArgs.SelectedTopUpGroup == null)
								{
									obj3 = 13;
								}
								continue;
							case 19:
								__KnownINotifyPropertyChangingArgs.TopUpItems = (PropertyChangingEventArgs)obj;
								obj = 18;
								goto IL_00db;
							case 34:
								((App)/*Error near IL_0b6c: Stack underflow*/).Window = ((App)(object)__KnownINotifyPropertyChangingArgs.PayMethods).Window;
								_ = ((App)null).RootElement;
								_ = 21;
								continue;
							case 20:
								obj = 1;
								obj3 = 0;
								if (__KnownINotifyPropertyChangingArgs.CanRedeem == null)
								{
									obj3 = 5;
								}
								continue;
							case 10:
							case 26:
								((App)/*Error near IL_0bb2: Stack underflow*/).SetAppRequestBackdrop((EnumBackdropType)/*Error near IL_0bb2: Stack underflow*/);
								((App)/*Error near IL_0bb7: Stack underflow*/).ShowMainWindow();
								((IEnumerable<int>)/*Error near IL_0bc2: Stack underflow*/).Select((Func<int, MobileGameModel>)(object)__KnownINotifyPropertyChangingArgs.Customers);
								_ = 31;
								continue;
							case 11:
								return;
							case 14:
								((App)/*Error near IL_0bef: Stack underflow*/).OnLaunched((LaunchActivatedEventArgs)/*Error near IL_0bef: Stack underflow*/);
								((App)/*Error near IL_0bf4: Stack underflow*/).AppClosing((byte)/*Error near IL_0bf4: Stack underflow*/ != 0, (AppWindow)/*Error near IL_0bf4: Stack underflow*/, (AppWindowClosingEventArgs)/*Error near IL_0bf4: Stack underflow*/);
								obj = (object)/*Error near IL_0bf6: Stack underflow*/;
								obj3 = 35;
								if (__KnownINotifyPropertyChangedArgs.Username == null)
								{
									obj3 = 7;
								}
								continue;
							case 13:
							case 27:
								((App)/*Error near IL_0c1c: Stack underflow*/).GetXamlType((Type)obj);
								obj = MassIrcService.Instance;
								_ = 2;
								if (__KnownINotifyPropertyChangedArgs.IsMyself == null)
								{
									_ = 3;
								}
								continue;
							case 3:
								_ = ref obj;
								if (MassService.Instance == null)
								{
									_ = 1;
									if (__KnownINotifyPropertyChangedArgs.Content == null)
									{
										_ = 1;
									}
									continue;
								}
								goto case 4;
							case 9:
								((App._003CLogout_003Ed__15*)/*Error near IL_0c72: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_0c72: Stack underflow*/);
								((AsyncVoidMethodBuilder*)/*Error near IL_0c7c: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)App._003CLogout_003Ed__15.ReplaceModel());
								obj3 = 16;
								if (__KnownINotifyPropertyChangedArgs.OnlinePlayers != null)
								{
									obj3 = 25;
								}
								continue;
							default:
								_ = __KnownINotifyPropertyChangedArgs.Description;
								if ((object)Type.GetTypeFromHandle((RuntimeTypeHandle)__KnownINotifyPropertyChangedArgs.Version) == null)
								{
									_ = 26;
									continue;
								}
								goto case 28;
							case 17:
								((MainContent.IMainContent_Bindings)Unsafe.AsPointer(ref this)).DisconnectUnloadedObject((int)obj);
								((Window)/*Error near IL_0d10: Stack underflow*/)._002Ector();
								__KnownINotifyPropertyChangedArgs.PreviewImage = (PropertyChangedEventArgs)/*Error near IL_0d15: Stack underflow*/;
								obj = 6;
								goto IL_00db;
							case 16:
								goto IL_0d23;
							case 7:
								((OverlappedPresenter)/*Error near IL_0d40: Stack underflow*/).IsMaximizable = (byte)/*Error near IL_0d40: Stack underflow*/ != 0;
								_ = ((AppWindow)typeof(MobileGameModel).TypeHandle).TitleBar;
								((IEnumerable<EntityMassReferralCustomer>)1).Select((Func<EntityMassReferralCustomer, ReferralCustomerModel>)(object)new MainContent.MainContent_obj1_Bindings());
								_ = 15;
								if (__KnownINotifyPropertyChangedArgs.Type == null)
								{
									_ = 13;
								}
								continue;
							case 8:
							case 31:
								obj3 = 38;
								continue;
							case 18:
								_ = ref __KnownINotifyPropertyChangedArgs.CanDelete;
								_ = ref obj;
								CastExtensions.As<Button>((object)Unsafe.AsPointer(ref this));
								_ = 11;
								continue;
							case 39:
								((MainContent.MainContent_obj1_Bindings)/*Error near IL_0dae: Stack underflow*/).DisconnectUnloadedObject((int)obj);
								if ((int)/*Error near IL_0db3: Stack underflow*/ == 0)
								{
									obj = 34;
									goto IL_00db;
								}
								goto case 17;
							case 28:
								((MainContent.MainContent_obj1_Bindings)/*Error near IL_0dcb: Stack underflow*/).Activated((object)/*Error near IL_0dcb: Stack underflow*/, (WindowActivatedEventArgs)(object)__KnownINotifyPropertyChangedArgs.Price);
								((MainContent.MainContent_obj1_Bindings)/*Error near IL_0dd0: Stack underflow*/).Loading((FrameworkElement)/*Error near IL_0dd0: Stack underflow*/, (object)/*Error near IL_0dd0: Stack underflow*/);
								((MainContent.MainContent_obj1_Bindings)/*Error near IL_0dd6: Stack underflow*/).Update_((object)/*Error near IL_0dd6: Stack underflow*/, (uint)(int)null);
								obj3 = 37;
								continue;
							case 32:
								goto IL_0de0;
							case 6:
								{
									((MainContent.MainContent_obj1_Bindings)/*Error near IL_0dfa: Stack underflow*/).Update_HamburgerView((object)Unsafe.AsPointer(ref this), (uint)(int)obj);
									__KnownINotifyPropertyChangedArgs.Image = (PropertyChangedEventArgs)MainContent.MainContent_obj1_Bindings.ParseDictionary();
									obj3 = 0;
									if (__KnownINotifyPropertyChangedArgs.JoinedAt == null)
									{
										obj3 = 0;
									}
									continue;
								}
								IL_00db:
								obj3 = obj;
								continue;
								IL_0d23:
								((OverlappedPresenter)/*Error near IL_0d31: Stack underflow*/).PreferredMinimumWidth = (int?)(object)((MainContent.IMainContent_BindingsScopeConnector)obj).ContainsElement((int)obj);
								obj3 = 30;
								continue;
							}
							break;
						}
						goto case 6;
						IL_0de0:
						if ((nint)obj != 3)
						{
							obj3 = 12;
							goto IL_00df;
						}
						goto IL_0ad7;
					}
					break;
				}
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = null;
				obj = 7;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00栀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778970, new IntPtr(2737336605276L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00椀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00樀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778971, new IntPtr(2737336600076L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00欀()
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
		internal unsafe static object _FF00_FF00_FF00氀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778968, new IntPtr(2737336606316L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00洀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00渀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778969, new IntPtr(2737336596956L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLaunchShadowClient_003Ed__83 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ShadowJavaGameType type;

		public DesktopGameModel _003C_003E4__this;

		public SectionValue sectionValue;

		private TaskAwaiter<ShadowJavaGame> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		internal static object CombineError;

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
		internal static bool StartCache()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectPortableEmitter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00帀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779302, new IntPtr(2737336587596L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00开()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0075: Expected Obj, but got Ref
			//IL_0080: Expected Obj, but got I4
			//IL_004e: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got I
			//IL_00a3: Expected Obj, but got Ref
			//IL_008b: Expected Obj, but got Ref
			//IL_0090: Expected Obj, but got Ref
			//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_08cf: Invalid comparison between Unknown and I4
			//IL_0acb: Expected Obj, but got Ref
			//IL_0ad6: Expected Obj, but got I4
			//IL_0afc: Expected Obj, but got Ref
			//IL_06ed: Expected I, but got Obj
			//IL_091f: Expected Obj, but got I4
			//IL_0924: Expected Obj, but got I4
			//IL_0924: Expected Obj, but got Ref
			//IL_0808: Expected Obj, but got Ref
			//IL_02f1: Expected I, but got Obj
			//IL_074a: Expected Obj, but got Ref
			//IL_08f9: Expected Obj, but got Ref
			//IL_01bc: Expected Obj, but got Ref
			//IL_0959: Expected Obj, but got I4
			//IL_095e: Expected Obj, but got I4
			//IL_095e: Expected Obj, but got Ref
			//IL_01ed: Expected Obj, but got I4
			//IL_096e: Expected Obj, but got Ref
			//IL_09be: Expected Obj, but got Ref
			//IL_09c6: Expected Obj, but got Ref
			//IL_09c6: Expected Obj, but got Ref
			//IL_02af: Expected I, but got Obj
			//IL_02b1: Expected Obj, but got I4
			//IL_0299: Expected I4, but got Obj
			//IL_0242: Expected Obj, but got I4
			//IL_07fd: Expected Obj, but got I4
			//IL_0a24: Expected Obj, but got I4
			//IL_0a2d: Expected Obj, but got I4
			//IL_0448: Expected Obj, but got Ref
			//IL_01a0: Expected I4, but got Obj
			//IL_047a: Expected Obj, but got I4
			//IL_03c5: Expected Obj, but got Ref
			//IL_03d0: Expected Obj, but got I4
			//IL_057d: Expected Obj, but got Ref
			//IL_03b5: Expected Obj, but got Ref
			//IL_04a0: Expected Obj, but got I4
			//IL_05d9: Expected Obj, but got I4
			//IL_05de: Expected Obj, but got I4
			//IL_05de: Expected Obj, but got Ref
			//IL_0467: Expected I4, but got Obj
			//IL_041b: Expected Obj, but got Ref
			//IL_04b5: Expected Obj, but got Ref
			//IL_04bc: Expected I, but got Obj
			//IL_04bc: Expected I, but got Obj
			//IL_04c7: Expected Obj, but got Ref
			//IL_04cc: Expected I, but got Obj
			//IL_04d3: Expected Obj, but got I4
			//IL_03dc: Expected Obj, but got I4
			//IL_05b9: Expected I, but got Obj
			//IL_05b9: Expected I, but got Obj
			//IL_05b9: Expected I4, but got Obj
			//IL_05c0: Expected I, but got Obj
			//IL_0402: Expected Obj, but got Ref
			//IL_04fb: Expected I, but got Obj
			//IL_04fb: Expected I4, but got Obj
			//IL_0553: Expected Obj, but got I4
			//IL_0558: Expected Obj, but got I4
			//IL_0558: Expected Obj, but got Ref
			//IL_0399: Expected Obj, but got Ref
			//IL_03a3: Expected I, but got Obj
			//IL_0410: Expected Obj, but got I4
			//IL_038e: Expected I4, but got Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ad->IL0026: Incompatible stack types: I4 vs Obj
			//IL_009a->IL0026: Incompatible stack heights: 2 vs 1
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0790->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_00bf->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_09f2->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_087b->IL00c3: Incompatible stack heights: 3 vs 1
			//IL_07e2->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0b06->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_070c->IL00c3: Incompatible stack heights: 4 vs 1
			//IL_092e->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_02f6->IL06e3: Incompatible stack heights: 1 vs 0
			//IL_0764->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0ac5->IL00c3: Incompatible stack heights: 5 vs 1
			//IL_090f->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0968->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0af4->IL00c3: Incompatible stack heights: 3 vs 1
			//IL_0897->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0201->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0a66->IL00c3: Incompatible stack heights: 7 vs 1
			//IL_0982->IL00c3: Incompatible stack heights: 3 vs 1
			//IL_01b6->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0b1e->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_02de->IL0a71: Incompatible stack heights: 1 vs 0
			//IL_09d0->IL00c3: Incompatible stack heights: 3 vs 1
			//IL_0847->IL00c3: Incompatible stack heights: 2 vs 1
			//IL_02c5->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0256->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0802->IL00bf: Incompatible stack heights: 2 vs 0
			//IL_08e8->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_09fd->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0b5c->IL0b73: Incompatible stack heights: 1 vs 3
			//IL_0886->IL00c3: Incompatible stack heights: 3 vs 1
			//IL_0277->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_07ed->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0717->IL00c3: Incompatible stack heights: 4 vs 1
			//IL_0818->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0300->IL00c3: Incompatible stack heights: 2 vs 1
			//IL_076f->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0785->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_091a->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_01d6->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0454->IL0325: Incompatible stack types: I4 vs Obj
			//IL_0321->IL0325: Incompatible stack types: I4 vs Obj
			//IL_020c->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0a71->IL00c3: Incompatible stack heights: 7 vs 1
			//IL_0b3c->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_09ad->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_02e8->IL00c3: Incompatible stack heights: 2 vs 1
			//IL_0852->IL00c3: Incompatible stack heights: 2 vs 1
			//IL_02d0->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_02a3->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0261->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0949->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_08f3->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_01e1->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0b47->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_09b8->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0954->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0b91->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_048e->IL0325: Incompatible stack types: I4 vs Obj
			//IL_058d->IL0325: Incompatible stack types: I4 vs Obj
			//IL_03bf->IL0325: Incompatible stack types: I4 vs Obj
			//IL_04aa->IL0325: Incompatible stack types: I4 vs Obj
			//IL_05f2->IL0325: Incompatible stack types: I4 vs Obj
			//IL_0437->IL0325: Incompatible stack heights: 2 vs 1
			//IL_04e7->IL0325: Incompatible stack types: I4 vs Obj
			//IL_03f0->IL0325: Incompatible stack types: I4 vs Obj
			//IL_05d4->IL0325: Incompatible stack types: I4 vs Obj
			//IL_053f->IL0325: Incompatible stack types: I4 vs Obj
			//IL_063e->IL0325: Incompatible stack types: I4 vs Obj
			//IL_050a->IL0325: Incompatible stack heights: 2 vs 1
			//IL_056c->IL0325: Incompatible stack types: I4 vs Obj
			//IL_03ad->IL0325: Incompatible stack heights: 2 vs 1
			//IL_0b9c->IL00c3: Incompatible stack types: I4 vs Obj
			//IL_0499->IL0325: Incompatible stack types: I4 vs Obj
			//IL_05fd->IL0325: Incompatible stack types: I4 vs Obj
			//IL_0471->IL0325: Incompatible stack types: I4 vs Obj
			//IL_0442->IL0325: Incompatible stack heights: 2 vs 1
			//IL_04f2->IL0325: Incompatible stack types: I4 vs Obj
			//IL_03fb->IL0325: Incompatible stack types: I4 vs Obj
			//IL_0577->IL0325: Incompatible stack types: I4 vs Obj
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
					object obj3;
					switch ((int)obj2)
					{
					case 1:
						obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
						obj2 = 0;
						if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
						{
							obj2 = 0;
						}
						continue;
					default:
						goto end_IL_0026;
					case 5:
						MarshalInspectable<object>.FromAbiArray((object)Unsafe.AsPointer(ref IList_object._initialized));
						_ = 3;
						continue;
					case 3:
						return;
					case 2:
						break;
					case 4:
						{
							if (obj != null)
							{
								obj3 = 37;
								goto IL_00c3;
							}
							goto IL_0785;
						}
						IL_0785:
						obj3 = 27;
						goto IL_00c3;
						IL_00c3:
						while (true)
						{
							object obj4;
							switch ((int)obj3)
							{
							case 21:
								return;
							case 2:
							case 10:
							case 30:
							case 32:
							case 36:
							case 52:
								break;
							case 38:
								IEnumerator_object._002Ecctor();
								obj = (object)/*Error near IL_01ac: Stack underflow*/;
								obj3 = 41;
								continue;
							case 23:
								if (IReadOnlyList_System_IDisposable._initialized != 1)
								{
									obj3 = 3;
									if (IReadOnlyList_object._initialized == 0)
									{
										obj3 = 1;
									}
									continue;
								}
								goto case 39;
							case 28:
								obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_01eb: Stack underflow*/, (uint)/*Error near IL_01eb: Stack underflow*/, (nint*)(int)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init());
								obj3 = 0;
								if (IEnumerable_System_IDisposable._initialized == 0)
								{
									obj3 = 0;
								}
								continue;
							case 48:
								obj = 1;
								obj3 = 10;
								if (GlobalVtableLookup.CreateAttribute != null)
								{
									obj3 = 11;
								}
								continue;
							case 5:
								if (IEnumerableMethods<INotifyPropertyChanged>.Abi_First_0((IntPtr)(nint)(&obj)) == null)
								{
									obj3 = 24;
									continue;
								}
								goto case 49;
							case 47:
								switch ((int)obj)
								{
								case 1:
									break;
								default:
									goto IL_0299;
								case 2:
									goto IL_07c7;
								case 0:
									goto IL_0886;
								}
								goto case 38;
							case 34:
							case 46:
								obj = IListMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_02af: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_02af: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)/*Error near IL_02af: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_02af: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_02af: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_02af: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int>)/*Error near IL_02af: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, int>)/*Error near IL_02af: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)/*Error near IL_02af: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)/*Error near IL_02af: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)obj, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, int>)(int)IEnumerable_System_ComponentModel_INotifyPropertyChanged.Init());
								obj3 = 5;
								if (Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute == null)
								{
									obj3 = 5;
								}
								continue;
							case 43:
								if (MarshalInterface<IReadOnlyList<object>>.FromManaged((IReadOnlyList<object>)obj) == (IntPtr)0)
								{
									_ = 31;
									continue;
								}
								goto case 42;
							case 16:
								if (MarshalInspectable<object>.FromAbi((IntPtr)obj) == null)
								{
									_ = 12;
									continue;
								}
								goto case 9;
							case 27:
								if (obj != null)
								{
									obj4 = 14;
									goto IL_0325;
								}
								goto IL_0442;
							case 9:
								IEnumerable_object.Do_Abi_First_0((nint)/*Error near IL_06ed: Stack underflow*/, (nint*)(nint)__KnownINotifyPropertyChangingArgs.Amount);
								IEnumerable_object._002Ecctor();
								_ = null;
								IEnumerable_object.SaveAttribute();
								_ = 18;
								if (__KnownINotifyPropertyChangingArgs.SelectedAccounts != null)
								{
									_ = 36;
								}
								continue;
							case 18:
								__KnownINotifyPropertyChangingArgs.CurrentDisplayPage = null;
								obj3 = 12;
								if (__KnownINotifyPropertyChangingArgs.InputEmail == null)
								{
									obj3 = 13;
								}
								continue;
							case 19:
								if (((Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails)obj).GetExposedInterfaces() != null)
								{
									obj3 = 53;
									continue;
								}
								goto case 20;
							case 12:
							case 31:
								goto end_IL_00c3;
							case 6:
								goto IL_07c7;
							case 49:
								_ = ref obj;
								_ = IEnumerableMethods<IDisposable>.AbiToProjectionVftablePtr;
								obj = 30;
								goto IL_00bf;
							case 15:
								if ((nint)__KnownINotifyPropertyChangingArgs.InfoBarMessage == 2)
								{
									obj3 = 19;
									continue;
								}
								goto case 42;
							case 45:
								_ = IEnumeratorMethods<IDisposable>.AbiToProjectionVftablePtr;
								_ = typeof(DesktopViewModel._003CStartProxy_003Ed__2).TypeHandle;
								((AsyncTaskMethodBuilder*)IUIElementOverridesMethods.AbiToProjectionVftablePtr)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)1, ref *(DesktopViewModel._003CLaunchGame_003Ed__3*)new Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails());
								_ = 10;
								if (__KnownINotifyPropertyChangingArgs.ParsedCount != null)
								{
									_ = 10;
								}
								continue;
							case 4:
								((Mass_WinUI_Pages_MobileWinRTTypeDetails)(object)((Mass_WinUI_Pages_MobileWinRTTypeDetails)(object)__KnownINotifyPropertyChangingArgs.ImportedCount).GetExposedInterfaces())._002Ector();
								_ = null;
								Mass_WinUI_Pages_MobileWinRTTypeDetails.InsertAttribute();
								_ = 52;
								if (__KnownINotifyPropertyChangingArgs.SelectedGame != null)
								{
									_ = 38;
								}
								continue;
							case 26:
								goto IL_0886;
							default:
								if (obj - 2 <= 1)
								{
									obj3 = 48;
									if (__KnownINotifyPropertyChangingArgs.LikeNetGames != null)
									{
										obj3 = 45;
									}
									continue;
								}
								goto case 50;
							case 22:
								obj = __KnownINotifyPropertyChangingArgs.FourLikeNetGames;
								obj3 = 47;
								if (__KnownINotifyPropertyChangingArgs.LikeNetGamesEmptyText == null)
								{
									obj3 = 27;
								}
								continue;
							case 13:
								obj = -1;
								__KnownINotifyPropertyChangingArgs.RentalGames = (PropertyChangingEventArgs)(-1);
								obj3 = 49;
								continue;
							case 11:
							case 51:
								if (obj == null)
								{
									obj3 = 23;
									if (__KnownINotifyPropertyChangingArgs.Skins != null)
									{
										obj3 = 34;
									}
									continue;
								}
								goto case 45;
							case 24:
								obj = 1;
								__KnownINotifyPropertyChangingArgs.SkinEmptyText = (PropertyChangingEventArgs)1;
								obj3 = 8;
								continue;
							case 14:
							case 35:
								_ = (object)(Thickness)__KnownINotifyPropertyChangingArgs.CurrentSkinPage;
								Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.DecorateFlexibleAttribute();
								_ = 29;
								continue;
							case 37:
								if ((nint)obj != 1)
								{
									obj3 = 33;
									if (__KnownINotifyPropertyChangingArgs.PagesOfSkins == null)
									{
										obj3 = 10;
									}
									continue;
								}
								goto case 7;
							case 44:
								_ = ref __KnownINotifyPropertyChangingArgs.HasSkins;
								((IEnumerable<string>)(&obj)).Select((Func<string, GameResourceModel>)Unsafe.AsPointer(ref this));
								_ = 21;
								continue;
							case 1:
							case 53:
								((Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails)(object)((Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails)obj).GetExposedInterfaces())._002Ector();
								obj = (object)/*Error near IL_09de: Stack underflow*/;
								obj3 = 16;
								if (__KnownINotifyPropertyChangingArgs.CoreResources != null)
								{
									obj3 = 0;
								}
								continue;
							case 50:
								obj = 0;
								obj = 51;
								goto IL_00bf;
							case 17:
							case 29:
							case 40:
							case 41:
								_ = __KnownINotifyPropertyChangingArgs.SelectedItem;
								Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.CheckJoinedAttribute();
								_ = __KnownINotifyPropertyChangingArgs.ExpirationTimeText;
								_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0._002Ecctor();
								_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.CheckScalableAttribute();
								_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.CheckModularTransaction();
								_ = 11;
								if (__KnownINotifyPropertyChangingArgs.InputUsername != null)
								{
									_ = 28;
								}
								continue;
							case 42:
								/*Error near IL_0a71: Member reference must be method, but was: Field*/;
							case 20:
								_ = __KnownINotifyPropertyChangingArgs.CanMobileMenuInvoke;
								_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner.AssetHandler();
								_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner.DeleteStruct();
								_ = null;
								_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities._002Ecctor();
								_ = 32;
								continue;
							case 7:
								obj = __KnownINotifyPropertyChangingArgs.CanSelect;
								obj = 18;
								goto IL_00bf;
							case 25:
								goto IL_0adb;
							case 8:
								__KnownINotifyPropertyChangingArgs.CurrentPage = (PropertyChangingEventArgs)obj;
								obj3 = 44;
								continue;
							case 39:
							{
								object systemBackdrop = obj;
								__KnownINotifyPropertyChangedArgs._002Ecctor();
								((Window)/*Error near IL_0b12: Stack underflow*/).SystemBackdrop = (SystemBackdrop)systemBackdrop;
								obj = (object)/*Error near IL_0b14: Stack underflow*/;
								obj3 = 15;
								continue;
							}
							case 33:
								if (__KnownINotifyPropertyChangedArgs.StopAttribute() == null)
								{
									obj3 = 2;
									if (__KnownINotifyPropertyChangingArgs.SelectedProductGroup == null)
									{
										obj3 = 2;
									}
									continue;
								}
								goto case 23;
							case 3:
								{
									((AppWindow)/*Error near IL_0b4c: Stack underflow*/).ShowOnceWithRequestedStartupState();
									PropertyChangingEventArgs topUpGroups;
									PropertyChangingEventArgs codePagesEncodingProvider;
									if (__KnownINotifyPropertyChangingArgs.TopUps == null)
									{
										topUpGroups = __KnownINotifyPropertyChangingArgs.TopUpGroups;
										codePagesEncodingProvider = (__KnownINotifyPropertyChangingArgs.TopUpItems = (PropertyChangingEventArgs)(object)new CodePagesEncodingProvider());
									}
									((AsyncTaskMethodBuilder*)(delegate*<bool>)(&AutoInitialize.CheckConcreteViewer))->Start(ref *(MobileViewModel._003CStartProxy_003Ed__7*)codePagesEncodingProvider);
									if (topUpGroups != null)
									{
										obj3 = 4;
										if (__KnownINotifyPropertyChangingArgs.Order == null)
										{
											obj3 = 2;
										}
										continue;
									}
									goto case 39;
								}
								IL_0442:
								obj = __KnownINotifyPropertyChangingArgs.Username;
								obj4 = 3;
								goto IL_0325;
								IL_0325:
								while (true)
								{
									switch ((int)obj4)
									{
									case 6:
										return;
									case 23:
									case 24:
										IList_object.Do_Abi_GetView_2((nint)/*Error near IL_03a3: Stack underflow*/, (nint*)(nint)(object)(MarshalInspectable<>)Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute);
										_ = 16;
										continue;
									case 7:
										Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMetaDataProviderWinRTTypeDetails.ReflectPortableAttribute = obj;
										obj4 = 13;
										continue;
									case 2:
										obj = Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute;
										obj = 10;
										goto IL_0321;
									case 15:
										obj = IList_object.Do_Abi_InsertAt_5((nint)/*Error near IL_03da: Stack underflow*/, (uint)/*Error near IL_03da: Stack underflow*/, (nint)/*Error near IL_03da: Stack underflow*/);
										obj4 = 5;
										if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner.CheckOperationalModule == null)
										{
											obj4 = 3;
										}
										continue;
									case 18:
										IListMethods<object>.Abi_ReplaceAll_11((IntPtr)/*Error near IL_0402: Stack underflow*/, (object[])(&obj));
										if ((int)/*Error near IL_0407: Stack underflow*/ != 0)
										{
											obj = 17;
											goto IL_0321;
										}
										goto case 22;
									case 13:
										_ = ref _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_hasTimeout;
										((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CLaunchShadowClient_003Ed__83, AccountViewModel._003CLoginMobile_003Ed__88>(ref this));
										_ = 2;
										if (__KnownINotifyPropertyChangingArgs.UserId != null)
										{
											_ = 6;
										}
										continue;
									case 1:
										break;
									case 10:
										switch ((int)obj)
										{
										case 1:
											break;
										default:
											goto IL_0467;
										case 0:
											goto IL_0499;
										case 2:
											goto IL_052e;
										}
										goto case 15;
									default:
										obj = IEnumeratorMethods<INotifyPropertyChanged>.Abi_get_HasCurrent_1((IntPtr)(nint)(&obj));
										obj4 = 0;
										if (__KnownINotifyPropertyChangingArgs.Name != null)
										{
											obj4 = 20;
										}
										continue;
									case 8:
										goto IL_0499;
									case 14:
										obj = IReadOnlyListMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_04d1: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_04d1: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)(int)IEnumerator_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_HasCurrent_1((nint)(int)IEnumerator_System_ComponentModel_INotifyPropertyChanged.Do_Abi_MoveNext_2((nint)/*Error near IL_04af: Stack underflow*/, (byte*)/*Error near IL_04af: Stack underflow*/), (byte*)(int)IEnumerator_System_ComponentModel_INotifyPropertyChanged.Do_Abi_get_Current_0((nint)__KnownINotifyPropertyChangingArgs.CharacterName, (nint*)(nint)obj)), (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(int)IReadOnlyListMethods<IDisposable>.Abi_get_Size_1((IntPtr)__KnownINotifyPropertyChangingArgs.IsSkeleton));
										obj4 = 5;
										if (__KnownINotifyPropertyChangingArgs.MaxPlayers == null)
										{
											obj4 = 18;
										}
										continue;
									case 21:
										IReadOnlyListMethods<object>.Abi_get_Size_1((IntPtr)(int)IReadOnlyList_System_IDisposable.Do_Abi_GetAt_0((nint)/*Error near IL_04fb: Stack underflow*/, (uint)(int)obj, (nint*)(nint)obj));
										_ = 11;
										continue;
									case 19:
										goto IL_052e;
									case 22:
										obj = 0;
										__KnownINotifyPropertyChangingArgs.BackgroundImageUrl = (PropertyChangingEventArgs)0;
										obj4 = 6;
										if (__KnownINotifyPropertyChangingArgs.Summary != null)
										{
											obj4 = 7;
										}
										continue;
									case 3:
										__KnownINotifyPropertyChangingArgs.PreviewImage = null;
										obj4 = 9;
										continue;
									case 4:
									case 5:
									case 12:
									case 16:
										((Func<Type, string>)/*Error near IL_05c5: Stack underflow*/)._002Ector((object)/*Error near IL_05c5: Stack underflow*/, (nint)(int)IReadOnlyList_object.Do_Abi_get_Size_1((nint)(int)IReadOnlyList_object.Do_Abi_GetMany_3((nint)/*Error near IL_05b9: Stack underflow*/, (uint)/*Error near IL_05b9: Stack underflow*/, (uint)(int)obj, (nint)__KnownINotifyPropertyChangingArgs.Title, (uint*)(nint)obj), (uint*)(nint)obj));
										ComWrappersSupport.RegisterTypeRuntimeClassNameLookup((Func<Type, string>)/*Error near IL_05ca: Stack underflow*/);
										obj4 = 21;
										continue;
									case 9:
										obj = -1;
										__KnownINotifyPropertyChangingArgs.OperationText = (PropertyChangingEventArgs)(-1);
										obj4 = 0;
										if (__KnownINotifyPropertyChangingArgs.Type != null)
										{
											obj4 = 0;
										}
										continue;
									case 20:
										obj = obj;
										obj4 = 2;
										continue;
									case 11:
										goto IL_0adb;
										IL_052e:
										IReadOnlyList_System_IDisposable._002Ecctor();
										obj = (object)/*Error near IL_0535: Stack underflow*/;
										obj4 = 4;
										continue;
										IL_0499:
										obj = IEnumerator_System_ComponentModel_INotifyPropertyChanged.Init();
										obj4 = 12;
										continue;
										IL_0467:
										obj4 = 23;
										continue;
										IL_0321:
										obj4 = obj;
										continue;
									}
									break;
								}
								goto IL_0442;
								IL_0adb:
								_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateIsolatedServer();
								__KnownINotifyPropertyChangingArgs._002Ecctor();
								_ = WeakReferenceMessenger.Default;
								_ = 22;
								continue;
								IL_00bf:
								obj3 = obj;
								continue;
								IL_0886:
								((Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails)/*Error near IL_088b: Stack underflow*/)._002Ector();
								obj = (object)/*Error near IL_088d: Stack underflow*/;
								obj3 = 17;
								continue;
								IL_07c7:
								obj = Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.NewAttribute();
								obj3 = 2;
								if (__KnownINotifyPropertyChangingArgs.InputVerifyCode != null)
								{
									obj3 = 40;
								}
								continue;
								IL_0299:
								obj3 = 14;
								continue;
							}
							goto end_IL_0026_2;
							continue;
							end_IL_00c3:
							break;
						}
						goto IL_0785;
						end_IL_0026_2:
						break;
					}
					IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized = -2;
					obj2 = 5;
					continue;
					end_IL_0026:
					break;
				}
				obj = IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute;
				obj = 4;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00怀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779303, new IntPtr(2737336577196L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00愀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00戀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779300, new IntPtr(2737336585516L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00挀()
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
		private unsafe sealed void _FF00_FF00_FF00搀(object P_0)
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
	private struct _003CLoadDetailsAsync_003Ed__76 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopGameModel _003C_003E4__this;

		private TaskAwaiter<EntityNetGameDetails> _003C_003Eu__1;

		private static object CheckBasicRunner;

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
		internal static bool DecorateReadableClient()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckRemoteListener()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00儀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779301, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00刀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779298, new IntPtr(2737336588636L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00匀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779299, new IntPtr(2737336584476L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00吀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779296, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00唀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779297, new IntPtr(2737336587596L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00嘀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779310, new IntPtr(2737336592796L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00圀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779311, new IntPtr(2737336576156L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00堀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779308, new IntPtr(2737336594876L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00夀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779309, new IntPtr(2737336582396L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00娀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779306, new IntPtr(2737336582396L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COpenGameResourceFolder_003Ed__84 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopGameModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object CreateMap;

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
		internal unsafe static bool ReflectJoinedFinalizer()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779305, new IntPtr(2737336606316L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object DecorateLiteralAggregator()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779318, new IntPtr(2737336590716L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00䨀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779319, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00䬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779316, new IntPtr(2737336590716L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00䰀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779317, new IntPtr(2737336585516L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00䴀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779314, new IntPtr(2737336582396L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00一()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779315, new IntPtr(2737336591756L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00伀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779312, new IntPtr(2737336595916L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00倀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779313, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRefreshCharactersAsync_003Ed__77 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopGameModel _003C_003E4__this;

		private object _003C_003E8__1;

		private TaskAwaiter<EntityRentalGameCharacter[]> _003C_003Eu__1;

		private TaskAwaiter<EntityGameCharacter[]> _003C_003Eu__2;

		private static object ReflectScalableTag;

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
		internal unsafe static bool CheckModularEngine()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779324, new IntPtr(2737336587596L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object ReflectGroupedCompiler()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779325, new IntPtr(2737336574076L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00䈀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779322, new IntPtr(2737336585516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00䌀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779323, new IntPtr(2737336592796L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00䐀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779320, new IntPtr(2737336601116L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00䔀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779321, new IntPtr(2737336601116L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00䘀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779270, new IntPtr(2737336587596L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00䜀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779271, new IntPtr(2737336578236L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00䠀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779268, new IntPtr(2737336592796L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00䤀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779269, new IntPtr(2737336602156L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStartProxy_003Ed__81 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopGameModel _003C_003E4__this;

		public SectionValue sectionValue;

		private object _003CgameId_003E5__2;

		private object _003Cname_003E5__3;

		private TaskAwaiter<GameProxy> _003C_003Eu__1;

		private TaskAwaiter<(bool IsConfirmed, string Text)> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private static object CheckDic;

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
		internal unsafe static bool CancelObject()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779264, new IntPtr(2737336575116L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object DecorateAutomatableStub()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779265, new IntPtr(2737336583436L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00㔀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779278, new IntPtr(2737336604236L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00㘀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779279, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00㜀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779276, new IntPtr(2737336574076L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00㠀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779277, new IntPtr(2737336577196L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00㤀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779274, new IntPtr(2737336574076L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00㨀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779275, new IntPtr(2737336581356L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00㬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779272, new IntPtr(2737336591756L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00㰀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779273, new IntPtr(2737336587596L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00㴀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779286, new IntPtr(2737336574076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	private static object DecorateGenericMapper;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsSkeleton
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_EF00() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00쐀(value ? ((byte)1) : ((byte)0));
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool CanProxy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_0E00() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00씀(value ? ((byte)1) : ((byte)0));
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	public bool ShowMaxPlayer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_EC00() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_FF00က(value ? ((byte)1) : ((byte)0));
		}
	}

	public bool IsRentalGame
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00촀() != 0;
		}
	}

	public bool HasRentalPassword
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_E700() != 0;
		}
	}

	public bool ShowPlayerCount => true;

	public string PlayerCountText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)this._FF00_FF00_FF00_FF00_FFFD();
		}
	}

	public bool HasRentalMinLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00ᤀ() != 0;
		}
	}

	public string RentalMinLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_0B00();
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_2100();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_F100(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int OnlinePlayers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_FF00_FF00_FF00_FF00ሀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_F600((uint)value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	public int MaxPlayers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_FF00_FF00_FF00_FF00_0A00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_FFFD((uint)value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string Author
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00츀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			this._FF00_FF00_FF00_FF00_FFFD((object)value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00팀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00준(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public string Version
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_E100();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_E900(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	public string ImageUrl
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00ἀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_FF00ᨀ(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public ObservableCollection<DesktopGameCharacterModel> Characters
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00Ā();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00쬀(value);
		}
	}

	public DesktopGameCharacterModel? SelectedCharacter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (DesktopGameCharacterModel?)_FF00_FF00_FF00_FF00_FF00_1400();
		}
	}

	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public string BackgroundImageUrl
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_0700();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			this._FF00_FF00_FF00_FF00_FFFD((object)value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	public bool IsLiked
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return this._FF00_FF00_FF00_FF00_FFFD() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_FF00ᴀ(value ? ((byte)1) : ((byte)0));
		}
	}

	public IDesktopGame Game
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (IDesktopGame)_FF00_FF00_FF00_FF00_E400();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00切(value);
		}
	}

	public bool IsShadowGame
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00ﴀ() != 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe DesktopGameModel(IDesktopGame? game = null)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected I, but got Obj
		//IL_0050: Expected I, but got Obj
		//IL_0050: Expected I4, but got Obj
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_0062: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I4
		//IL_00c9: Expected I, but got Obj
		//IL_0087: Expected I4, but got Obj
		//IL_0089: Expected Obj, but got I
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Invalid comparison between Unknown and I4
		//IL_00aa: Expected Obj, but got I4
		//IL_00ec: Expected I4, but got Obj
		//IL_00ec: Expected I, but got Obj
		//IL_00f9: Expected I, but got Obj
		//IL_013f: Expected Obj, but got I4
		//IL_01bd: Expected I4, but got Obj
		//IL_01eb: Expected I, but got Obj
		//IL_0201: Expected I, but got Obj
		//IL_0241: Expected Obj, but got I4
		//IL_0246: Expected I4, but got Obj
		//IL_0251: Expected Obj, but got I4
		//IL_026d: Expected I, but got Obj
		//IL_005d->IL005d: Incompatible stack heights: 2 vs 1
		//IL_00ec->IL00ec: Incompatible stack heights: 1 vs 2
		//IL_00f4->IL00f4: Incompatible stack heights: 1 vs 2
		//IL_0112->IL0117: Incompatible stack types: I4 vs Obj
		//IL_015d->IL015d: Incompatible stack types: I vs Obj
		//IL_0165->IL0165: Incompatible stack heights: 1 vs 2
		//IL_018d->IL018d: Incompatible stack types: I vs Obj
		//IL_0195->IL0195: Incompatible stack heights: 1 vs 2
		//IL_01c2->IL01c2: Incompatible stack heights: 0 vs 2
		//IL_01ca->IL01ca: Incompatible stack heights: 1 vs 2
		//IL_01f0->IL01f1: Incompatible stack heights: 2 vs 1
		//IL_024c->IL024c: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)game;
		IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized = ((IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute == null) ? 1 : 0);
		object reflectConfigurableAttribute = IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute;
		bool flag;
		if (reflectConfigurableAttribute != null)
		{
			((ValueTuple<int, nint>*)/*Error near IL_0050: Stack underflow*/)->_002Ector((int)this, (nint)reflectConfigurableAttribute);
			flag = (int)/*Error near IL_0054: Stack underflow*/ != 9;
		}
		else
		{
			_ = 0;
		}
		IList_object.PatchAttribute = flag;
		reflectConfigurableAttribute = IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized;
		IReadOnlyList_System_IDisposable._initialized = (nint)((reflectConfigurableAttribute == null || (object)(nint)MarshalInspectable<object>.FromManaged((object)/*Error near IL_0087: Stack underflow*/, (byte)(int)reflectConfigurableAttribute != 0) - 8 > 1) ? ((object)0) : ((object)1));
		object reflectConnectedAttribute = IReadOnlyList_System_IDisposable.ReflectConnectedAttribute;
		if (reflectConnectedAttribute == null)
		{
		}
		else
		{
			IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)this, (uint)(int)reflectConnectedAttribute);
		}
		if (null == null)
		{
		}
		IEnumerator_System_IDisposable._initialized = unchecked((nint)null);
		object reflectTransferableAttribute = IEnumerator_System_IDisposable.ReflectTransferableAttribute;
		IEnumerable_System_IDisposable.CombineAttribute = ((reflectTransferableAttribute != null) ? MarshalInterface<INotifyPropertyChanged>.FromAbiArray(reflectTransferableAttribute) : ((object)0));
		nint initialized = IEnumerable_object._initialized;
		GlobalVtableLookup.CreateAttribute = ((initialized != 0) ? IReadOnlyListMethods<INotifyPropertyChanged>.Abi_get_Size_1((IntPtr)initialized) : 0);
		object reflectDividedAttribute = Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute;
		object obj = ((reflectDividedAttribute == null) ? null : ((object)(nint)MarshalInterface<IEnumerator<INotifyPropertyChanged>>.FromManaged((IEnumerator<INotifyPropertyChanged>)reflectDividedAttribute)));
		if (obj == null)
		{
		}
		Mass_WinUI_Controls_MobileGameCardWinRTTypeDetails.UpdateAttribute = obj;
		object testAttribute = Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute;
		object obj2 = ((testAttribute != null) ? ((object)(nint)MarshalInterface<IReadOnlyList<object>>.FromManaged((IReadOnlyList<object>)testAttribute)) : null);
		if (obj2 == null)
		{
		}
		Mass_WinUI_Controls_DragDropOverlayWinRTTypeDetails.DecorateRandomAttribute = obj2;
		object checkConvertibleAttribute = Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlMemberWinRTTypeDetails.CheckConvertibleAttribute;
		if (checkConvertibleAttribute == null)
		{
		}
		else
		{
			IListMethods<object>.Abi_InsertAt_5((IntPtr)/*Error near IL_01bd: Stack underflow*/, (uint)(int)this, checkConvertibleAttribute);
			IListMethods<object>.Abi_RemoveAt_6((IntPtr)/*Error near IL_01c2: Stack underflow*/, (uint)/*Error near IL_01c2: Stack underflow*/);
		}
		if (null == null)
		{
		}
		_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.Instance = null;
		if (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.ReflectLiteralAttribute != null)
		{
			IList_object.Do_Abi_RemoveAtEnd_8((nint)_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.RunnerFactory.Runner.CheckOperationalModule);
		}
		_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator = this;
		__KnownINotifyPropertyChangingArgs.UserId = (PropertyChangingEventArgs)new IEnumeratorMethods<INotifyPropertyChanged>((IntPtr)this);
		IList_object._002Ecctor();
		__KnownINotifyPropertyChangingArgs.CreateAt = (PropertyChangingEventArgs)(object)this;
		uint num;
		if (__KnownINotifyPropertyChangingArgs.LoginAt != null)
		{
			num = IReadOnlyListMethods<IDisposable>.Abi_GetMany_3((IntPtr)/*Error near IL_0246: Stack underflow*/, (uint)(int)this, ref *(IReadOnlyListMethods<IDisposable>.Abi_IndexOf_2((IntPtr)(IEnumerator_System_ComponentModel_INotifyPropertyChanged.Initialized ? 1 : 0), (IDisposable)IEnumerator_System_ComponentModel_INotifyPropertyChanged.Init(), ref *(uint*)__KnownINotifyPropertyChangingArgs.Message) ? ((IDisposable[]*)1) : ((IDisposable[]*)null)));
		}
		else
		{
			_ = 0;
		}
		__KnownINotifyPropertyChangingArgs.IsSelected = (PropertyChangingEventArgs)num;
		__KnownINotifyPropertyChangingArgs.CanProxy = __KnownINotifyPropertyChangingArgs.IsSkeleton;
		IReadOnlyListMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_026d: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_026d: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_026d: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)this);
		int num2 = 0;
		if (__KnownINotifyPropertyChangingArgs.MaxPlayers != null)
		{
			num2 = 0;
		}
		switch (num2)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Clone()
	{
		return _FF00_FF00_FF00_FF00픀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return (string)_FF00_FF00_FF00_FF00_E200();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoadDetailsAsync_003Ed__76))]
	public Task LoadDetailsAsync()
	{
		return (Task)_FF00_FF00_FF00_FF00_F300();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefreshCharactersAsync_003Ed__77))]
	public Task RefreshCharactersAsync()
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00_2300();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddRandomCharacter_003Ed__78))]
	public Task<string?> AddRandomCharacter()
	{
		return _FF00_FF00_FF00_FF00숀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddCharacter_003Ed__79))]
	public Task<(bool isSuccess, bool needRetry)> AddCharacter(string name, bool growl = true)
	{
		return _FF00_FF00_FF00_FF00턀(name, growl ? ((byte)1) : ((byte)0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CFastStart_003Ed__80))]
	public Task FastStart()
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00_0D00();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CStartProxy_003Ed__81))]
	public Task StartProxy(SectionValue? sectionValue)
	{
		return (Task)_FF00_FF00_FF00_FF00윀(sectionValue);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLaunchGame_003Ed__82))]
	public Task LaunchGame(SectionValue gameValue, SectionValue? proxyValue)
	{
		return (Task)_FF00_FF00_FF00_FF00_F800(gameValue, proxyValue);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLaunchShadowClient_003Ed__83))]
	public Task LaunchShadowClient(SectionValue? sectionValue, ShadowJavaGameType type = (ShadowJavaGameType)0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (Task)_FF00_FF00_FF00_FF00_FF00ᜀ(sectionValue, type);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COpenGameResourceFolder_003Ed__84))]
	public Task OpenGameResourceFolder()
	{
		return (Task)_FF00_FF00_FF00_FF00_EA00();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object GetImageUrl(object game)
	{
		return _FF00_FF00_FF00_FF00_FF00_0300(game);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnIsLikedChanged(byte value)
	{
		_FF00_FF00_FF00_FF00_FE00(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FillStruct()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DesktopGameModel ReflectCustomRequester()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00뼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778890, new IntPtr(2737336200092L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00쀀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00섀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778891, new IntPtr(2737336200092L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<string> _FF00_FF00_FF00_FF00숀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18520, 1790778888, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778888, new IntPtr(2737336200092L), 15);
		}
		return (Task<string>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<string> _FF00_FF00_FF00_FF00쌀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778889, new IntPtr(2737336211532L), 15))(null, 0, new IntPtr(0L));
		return (Task<string>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00쐀(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_0099: Expected I, but got Obj
		//IL_0084: Expected I, but got Obj
		//IL_00aa: Expected Obj, but got I4
		//IL_00b9: Expected Obj, but got I
		//IL_00a3->IL0026: Incompatible stack heights: 3 vs 1
		//IL_008e->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00be->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c9->IL0026: Incompatible stack types: I4 vs Obj
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
				ExceptionHelpers.GetHRForException((Exception)/*Error near IL_0049: Stack underflow*/);
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_0050: Member reference must be method, but was: Field*/;
			case 1:
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)IList_object.PatchAttribute);
				_ = 3;
				break;
			default:
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute);
				_ = 4;
				break;
			case 3:
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
	internal unsafe void _FF00_FF00_FF00_FF00씀(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00c4: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got I
		//IL_0053: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_00d8->IL0026: Incompatible stack heights: 3 vs 1
		//IL_008d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0067->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00e3->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00b9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0098->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0026: Incompatible stack heights: 2 vs 1
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
			case 5:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 4;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					_ = 4;
				}
				break;
			case 4:
				IList_object._initialized = (int)P_0;
				obj2 = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				return;
			case 2:
				return;
			case 3:
				if (IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00aa: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)MarshalInspectable<object>.FromManaged((object)/*Error near IL_009e: Stack underflow*/, (byte)/*Error near IL_009e: Stack underflow*/ != 0), (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)IReadOnlyList_System_IDisposable._initialized, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(int)P_0))
				{
					obj2 = 2;
					break;
				}
				goto case 5;
			default:
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
				_ = 0;
				if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00였(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778902, new IntPtr(2737336201132L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00윀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18525, 1790778903, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778903, new IntPtr(2737336201132L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00저(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778900, new IntPtr(2737336202172L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00준(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0079: Expected I, but got Obj
		//IL_0079: Expected I4, but got Obj
		//IL_00d2: Expected Obj, but got I
		//IL_00e1: Expected Obj, but got I
		//IL_004f: Expected I, but got Obj
		//IL_00b8: Expected I, but got Obj
		//IL_0083->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e6->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f1->IL0026: Incompatible stack heights: 3 vs 1
		//IL_006e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c7->IL0026: Incompatible stack types: I4 vs Obj
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
			case 3:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
				obj2 = 2;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					obj2 = 2;
				}
				break;
			default:
				((ValueTuple<int, nint>*)/*Error near IL_0079: Stack underflow*/)->_002Ector((int)this, (nint)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute);
				obj2 = 3;
				break;
			case 4:
				return;
			case 5:
				if (IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00b8: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)MarshalInspectable<object>.FromManaged((object)/*Error near IL_00ac: Stack underflow*/, (byte)/*Error near IL_00ac: Stack underflow*/ != 0), (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)IReadOnlyList_System_IDisposable._initialized, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)P_0))
				{
					obj2 = 4;
					break;
				}
				goto default;
			case 2:
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
				_ = 1;
				if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
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
	internal unsafe void _FF00_FF00_FF00_FF00쬀(ObservableCollection<DesktopGameCharacterModel> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_004f: Expected I, but got Obj
		//IL_0058: Expected Obj, but got I4
		//IL_0098: Expected I4, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got I
		//IL_009d->IL005d: Incompatible stack heights: 1 vs 0
		//IL_00e1->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00b1->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00bc->IL0026: Incompatible stack heights: 2 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				case 5:
					_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
					/*Error near IL_0063: Member reference must be method, but was: Field*/;
				case 2:
					MarshalInspectable<object>.FromAbiArray((object)/*Error near IL_008c: Stack underflow*/);
					if (MarshalInspectable<object>.FromManaged((object)IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized, (byte)(int)P_0 != 0) != (IntPtr)0)
					{
						_ = 1;
						if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
						{
							_ = 1;
						}
						continue;
					}
					goto case 5;
				case 1:
					return;
				case 4:
					return;
				case 3:
					MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
					_ = 4;
					continue;
				}
				break;
			}
			IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00찀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778901, new IntPtr(2737336202172L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00촀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001f: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized is Application) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00츀()
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
	internal unsafe object _FF00_FF00_FF00_FF00케()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778898, new IntPtr(2737336202172L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<(bool, bool)> _FF00_FF00_FF00_FF00퀀(object P_0, byte P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778899, new IntPtr(2737336202172L), 15))(null, 0, new IntPtr(0L));
		return (Task<(bool, bool)>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<(bool, bool)> _FF00_FF00_FF00_FF00턀(object P_0, byte P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_0091: Expected Obj, but got I4
		//IL_0091: Expected Obj, but got Ref
		//IL_00c2: Expected Obj, but got Ref
		//IL_00d1: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got Ref
		//IL_00e8: Expected Obj, but got Ref
		//IL_00ef: Expected Obj, but got Ref
		//IL_00ef: Expected Obj, but got Ref
		//IL_006a: Expected I, but got Obj
		//IL_006a: Expected Obj, but got Ref
		//IL_0053: Expected Obj, but got Ref
		//IL_0058: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got Ref
		//IL_00ba: Expected Obj, but got I4
		//IL_009b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ad->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f9->IL0026: Incompatible stack heights: 2 vs 1
		//IL_007e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0062->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0089->IL0026: Incompatible stack types: I4 vs Obj
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
			case 5:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = ExceptionHelpers.GetHRForException((Exception)(&obj));
				obj2 = 4;
				break;
			case 4:
				IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)this;
				obj2 = 1;
				if (IList_object._initialized != 0)
				{
					obj2 = 0;
				}
				break;
			default:
				IList_object.PatchAttribute = P_1;
				obj2 = 2;
				break;
			case 2:
				IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized = -1;
				obj2 = 3;
				break;
			case 6:
				return (Task<(bool, bool)>)IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)(nint)Unsafe.AsPointer(ref IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute));
			case 1:
				IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = P_0;
				obj2 = 0;
				if (IReadOnlyList_object.ReflectLogicalAttribute != null)
				{
					obj2 = 0;
				}
				break;
			case 3:
				((XamlUserType)Unsafe.AsPointer(ref IEnumerator_System_IDisposable._initialized)).BoxType<int>((object)(&obj));
				_ = 6;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00툀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778896, new IntPtr(2737336211532L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00팀()
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
	internal unsafe object _FF00_FF00_FF00_FF00퐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778897, new IntPtr(2737336202172L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed object _FF00_FF00_FF00_FF00픀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I4
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ExceptionHelpers.GetHRForException((Exception)(object)this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00휀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778910, new IntPtr(2737336202172L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18542, 1790778911, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778911, new IntPtr(2737336211532L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_0085: Expected I, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_004f: Expected I, but got Obj
		//IL_0099->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00bf->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a4->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00ca->IL0026: Incompatible stack types: I4 vs Obj
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
				return;
			case 3:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 2;
				break;
			case 4:
				/*Error near IL_0059: Member reference must be method, but was: Field*/;
			case 0:
				return;
			case 1:
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)IList_object.PatchAttribute);
				_ = 0;
				if (IReadOnlyList_System_IDisposable._initialized == 0)
				{
					_ = 0;
				}
				break;
			case 2:
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
	internal unsafe void _FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778908, new IntPtr(2737336202172L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_0075: Expected I, but got Obj
		//IL_004f: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_00a5: Expected I, but got Obj
		//IL_00e3: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I
		//IL_0089->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00e8->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0094->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00be->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f3->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00c9->IL0026: Incompatible stack types: I4 vs Obj
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
			case 2:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 0;
				}
				break;
			default:
				IList_object._initialized = (nint)P_0;
				obj2 = 2;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					obj2 = 4;
				}
				break;
			case 3:
				if (IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00a5: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)MarshalInspectable<object>.FromManaged((object)/*Error near IL_0099: Stack underflow*/, (byte)/*Error near IL_0099: Stack underflow*/ != 0), (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)IReadOnlyList_System_IDisposable._initialized, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)P_0))
				{
					return;
				}
				obj2 = 0;
				if (IReadOnlyList_object.ReflectLogicalAttribute == null)
				{
					obj2 = 2;
				}
				break;
			case 4:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00d4: Stack underflow*/, (INotifyPropertyChanged)this, ref *(uint*)IEnumerator_System_IDisposable._initialized);
				_ = 1;
				if (IEnumerable_System_IDisposable.CombineAttribute != null)
				{
					_ = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778909, new IntPtr(2737336202172L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778906, new IntPtr(2737336202172L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FFFD(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00c0: Expected Obj, but got I4
		//IL_00cf: Expected Obj, but got I
		//IL_00ae: Expected I4, but got Obj
		//IL_00ae: Expected I, but got Obj
		//IL_004f: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_00d4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b8->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0084->IL00b8: Incompatible stack heights: 1 vs 0
		//IL_00df->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0098->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a3->IL0026: Incompatible stack heights: 2 vs 1
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
			case 2:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 0;
				}
				break;
			case 3:
				*((int, nint)*)(nint)/*Error near IL_0073: Stack underflow*/ = ((int)/*Error near IL_0073: Stack underflow*/, (nint)/*Error near IL_0073: Stack underflow*/);
				_ = IList_object.PatchAttribute;
				if (IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)(int)P_0) == null)
				{
					_ = 1;
					if (IReadOnlyList_System_IDisposable._initialized != 0)
					{
						_ = 2;
					}
					break;
				}
				return;
			case 1:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)this, (uint)(int)IReadOnlyList_System_IDisposable.ReflectConnectedAttribute);
				_ = 4;
				break;
			case 4:
				return;
			default:
				IReadOnlyList_object.ReflectLogicalAttribute = P_0;
				obj2 = 1;
				if (IEnumerator_System_IDisposable.ReflectTransferableAttribute != null)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_E000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778907, new IntPtr(2737336208412L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_E100()
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
	internal unsafe object _FF00_FF00_FF00_FF00_E200()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return _003CModule_003E.CheckAccessibleAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_E300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778904, new IntPtr(2737336202172L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_E400()
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
	internal unsafe object _FF00_FF00_FF00_FF00_E500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778905, new IntPtr(2737336209452L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_E600()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778982, new IntPtr(2737336202172L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_E700()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0067->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0098->IL0026: Incompatible stack types: I4 vs Obj
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
				return (byte)ExceptionHelpers.GetHRForException((Exception)obj);
			case 2:
				obj = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute as ValueType;
				obj2 = 1;
				if (IList_object._initialized != 0)
				{
					obj2 = 1;
				}
				break;
			case 1:
				if (obj == null)
				{
					return 0;
				}
				obj2 = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_E800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778983, new IntPtr(2737336208412L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_E900(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00b2: Expected I, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I
		//IL_0053: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_00bc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a0->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00d2->IL0081: Incompatible stack heights: 2 vs 0
		//IL_0067->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00ab->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00dc->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0072->IL0026: Incompatible stack heights: 2 vs 1
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
				return;
			case 5:
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 0;
				}
				break;
			case 3:
				return;
			case 2:
				MarshalInspectable<object>.FromAbiArray((object)IList_object._initialized);
				_ = 1;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
				{
					_ = 1;
				}
				break;
			case 1:
				IReadOnlyList_System_IDisposable._initialized = (nint)P_0;
				obj2 = 5;
				break;
			case 4:
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00c1: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00c1: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_00c1: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)/*Error near IL_00c1: Stack underflow*/);
				_ = IReadOnlyList_object._initialized;
				if (MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)P_0) != (IntPtr)0)
				{
					_ = 3;
					break;
				}
				goto case 2;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_EA00()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18560, 1790778980, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778980, new IntPtr(2737336202172L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_EB00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778981, new IntPtr(2737336203212L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_EC00()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_ED00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778978, new IntPtr(2737336208412L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_EE00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778979, new IntPtr(2737336203212L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_EF00()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_F000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778976, new IntPtr(2737336203212L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_F100(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0053: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I
		//IL_009d: Expected I, but got Obj
		//IL_0067->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00fb->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00d2->IL00dc: Incompatible stack heights: 2 vs 0
		//IL_00b1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0106->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00dc->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00bc->IL0026: Incompatible stack types: I4 vs Obj
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
				_ = 2;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 5;
				}
				continue;
			case 2:
				return;
			case 4:
				IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
				obj2 = 0;
				if (IReadOnlyList_System_IDisposable._initialized != 0)
				{
					obj2 = 0;
				}
				continue;
			case 3:
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00c1: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00c1: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_00c1: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)/*Error near IL_00c1: Stack underflow*/);
				_ = IReadOnlyList_object._initialized;
				if (MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)P_0) != (IntPtr)0)
				{
					_ = 2;
					continue;
				}
				break;
			case 1:
				break;
			case 5:
				return;
			}
			IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00e7: Stack underflow*/, (INotifyPropertyChanged)this, ref *(uint*)IEnumerator_System_IDisposable._initialized);
			_ = 4;
			if (IEnumerable_System_IDisposable.CombineAttribute != null)
			{
				_ = 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_F200(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778977, new IntPtr(2737336206332L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_F300()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18569, 1790778990, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778990, new IntPtr(2737336203212L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_F400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778991, new IntPtr(2737336204252L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_F500(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778988, new IntPtr(2737336204252L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_F600(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00c2: Expected I4, but got Obj
		//IL_00c2: Expected I, but got Obj
		//IL_00ac: Expected I, but got Obj
		//IL_00e8: Expected Obj, but got I4
		//IL_00f7: Expected Obj, but got I
		//IL_00d6->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00b6->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00fc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e1->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0107->IL0026: Incompatible stack types: I4 vs Obj
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
				ExceptionHelpers.GetHRForException((Exception)/*Error near IL_004d: Stack underflow*/);
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_0054: Member reference must be method, but was: Field*/;
			case 1:
				return;
			case 4:
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute);
				_ = 5;
				break;
			case 0:
				return;
			case 3:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)this, (uint)(int)IReadOnlyList_System_IDisposable.ReflectConnectedAttribute);
				_ = 0;
				if (IEnumerator_System_IDisposable._initialized != 0)
				{
					_ = 0;
				}
				break;
			case 5:
				IEnumerator_System_IDisposable.ReflectTransferableAttribute = P_0;
				obj2 = 2;
				if (IEnumerable_System_IDisposable.CombineAttribute == null)
				{
					obj2 = 3;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_F700(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778989, new IntPtr(2737336204252L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_F800(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005a: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18574, 1790778986, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 3, 1790778986, new IntPtr(2737336204252L), 15);
		}
		return ((delegate*<object, object, object, object>)obj)(this, P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00豈(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778987, new IntPtr(2737336205292L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00切(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected I, but got Obj
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
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
			case 0:
				return;
			case 1:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
				obj2 = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00ﬀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778984, new IntPtr(2737336205292L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00ﴀ()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0074: Expected I, but got Obj
		//IL_0079: Expected Obj, but got I4
		//IL_007a: Expected I4, but got Obj
		//IL_006f->IL006f: Incompatible stack heights: 0 vs 1
		//IL_0059->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
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
			{
				nint initialized = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
				if (initialized == 0)
				{
					obj2 = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj2 = 0;
					}
					continue;
				}
				/*Error near IL_006f: Stack underflow*/((object[])/*Error near IL_006f: Stack underflow*/, initialized);
				break;
			}
			default:
				break;
			}
			break;
		}
		return (byte)(int)MarshalInspectable<object>.FromAbiArray((object)IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_0074: Stack underflow*/, (uint)/*Error near IL_0074: Stack underflow*/, (nint)/*Error near IL_0074: Stack underflow*/, (uint*)unchecked((nint)null)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FE00(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00cc: Expected I, but got Obj
		//IL_00d6: Expected Obj, but got I4
		//IL_006d: Expected Obj, but got I4
		//IL_0072: Expected I, but got Obj
		//IL_00ac: Expected Obj, but got I
		//IL_00ea->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00f5->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0086->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0091->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0106->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00bc->IL0026: Incompatible stack types: I4 vs Obj
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
			case 0:
				return;
			case 3:
			{
				_003CModule_003E obj3 = _003CModule_003E.CheckAccessibleAttribute();
				((Action<object[], nint>)IEnumerator_object.Initialized)((object[])(object)this, (int)IEnumerator_object.Init());
				((ValueTuple<int, nint>*)/*Error near IL_0072: Stack underflow*/)->_002Ector((int)/*Error near IL_0072: Stack underflow*/, (nint)obj3);
				obj2 = 1;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					obj2 = 1;
				}
				break;
			}
			case 1:
				return;
			case 5:
				IEnumerator_object._002Ecctor();
				if (this != null)
				{
					obj2 = 2;
					if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
					{
						obj2 = 4;
					}
					break;
				}
				if (P_0 == 0)
				{
					obj2 = 3;
					break;
				}
				goto case 2;
			case 2:
				MarshalInterface<INotifyPropertyChanged>.FromAbiArray((object)IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00d1: Stack underflow*/, (INotifyPropertyChanged)/*Error near IL_00d1: Stack underflow*/, ref *(uint*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)(IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Initialized ? 1 : 0), (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init(), (nint*)(nint)this)));
				_ = 0;
				if (IEnumerable_object._initialized == 0)
				{
					_ = 0;
				}
				break;
			case 4:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<DesktopGameCharacterModel> _FF00_FF00_FF00_FF00_FF00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778985, new IntPtr(2737336205292L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<DesktopGameCharacterModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<DesktopGameCharacterModel> _FF00_FF00_FF00_FF00_FF00Ā()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<DesktopGameCharacterModel>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<DesktopGameCharacterModel> _FF00_FF00_FF00_FF00_FF00Ȁ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778998, new IntPtr(2737336205292L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<DesktopGameCharacterModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_0300(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18584, 1790778999, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778999, new IntPtr(2737336205292L), 15);
		}
		return ((delegate*<object, object>)obj)(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00Ѐ()
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
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00Ԁ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778996, new IntPtr(2737336206332L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_0600()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778997, new IntPtr(2737336206332L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_0700()
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
	internal unsafe object _FF00_FF00_FF00_FF00_FF00ࠀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778994, new IntPtr(2737336206332L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_0900()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778995, new IntPtr(2737336206332L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_0A00()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_0B00()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18592, 1790778992, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778992, new IntPtr(2737336206332L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_0C00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778993, new IntPtr(2737336208412L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_0D00()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18594, 1790779006, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779006, new IntPtr(2737336208412L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_0E00()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00ༀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779007, new IntPtr(2737336209452L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00က(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00d2: Expected Obj, but got I4
		//IL_00b3: Expected I, but got Obj
		//IL_00bc: Expected Obj, but got I4
		//IL_0053: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_00e6: Expected Obj, but got I
		//IL_00d7->IL0048: Incompatible stack heights: 2 vs 0
		//IL_0084->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c1->IL0022: Incompatible stack heights: 2 vs 0
		//IL_0067->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00eb->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0072->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00f6->IL0026: Incompatible stack heights: 3 vs 1
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
				default:
					return;
				case 5:
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
					_ = 2;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
					{
						_ = 0;
					}
					continue;
				case 0:
					return;
				case 3:
					return;
				case 2:
					IList_object._initialized = (int)P_0;
					obj2 = 4;
					continue;
				case 4:
					break;
				case 1:
					IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00c6: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00c6: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_00c6: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)/*Error near IL_00c6: Stack underflow*/);
					_ = IReadOnlyList_object._initialized;
					if (MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)P_0) != (IntPtr)0)
					{
						_ = 0;
						if (IEnumerator_System_IDisposable.ReflectTransferableAttribute != null)
						{
							_ = 0;
						}
						continue;
					}
					goto case 5;
				}
				break;
			}
			IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute);
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00ᄀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779004, new IntPtr(2737336209452L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00ሀ()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00ጀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779005, new IntPtr(2737336209452L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_1400()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18601, 1790779002, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779002, new IntPtr(2737336209452L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00ᔀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779003, new IntPtr(2737336578236L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00ᘀ(object P_0, ShadowJavaGameType P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779000, new IntPtr(2737336593836L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00ᜀ(object P_0, ShadowJavaGameType P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_00a6: Expected Obj, but got Ref
		//IL_00ad: Expected Obj, but got Ref
		//IL_00bc: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got Ref
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected I, but got Unknown
		//IL_0054: Expected Obj, but got Ref
		//IL_005d: Expected Obj, but got I4
		//IL_00d4: Expected Obj, but got Ref
		//IL_010c: Expected Obj, but got Ref
		//IL_0112: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got Ref
		//IL_00c1->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0105->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0074->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00cc->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00f3->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					break;
				case 6:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = P_0;
					obj2 = 3;
					continue;
				case 2:
					_ = ref obj;
					/*Error near IL_0076: Member reference must be method, but was: Field*/;
				default:
					_ = ref IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized;
					CastExtensions.As<ImplicitAnimationSet>((object)(&obj));
					_ = 5;
					if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
					{
						_ = 5;
					}
					continue;
				case 4:
					IReadOnlyList_object._initialized = -1;
					obj2 = 0;
					if (IEnumerator_System_IDisposable._initialized != 0)
					{
						obj2 = 0;
					}
					continue;
				case 1:
					IEnumerator_System_IDisposable.ReflectTransferableAttribute = this;
					obj2 = 6;
					continue;
				case 5:
					return IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)/*Error near IL_0111: Stack underflow*/, (uint)/*Error near IL_0111: Stack underflow*/, ref Unsafe.As<nint, INotifyPropertyChanged[]>(ref IEnumerable_System_IDisposable._initialized));
				}
				break;
			}
			IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_1;
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00ᤀ()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_007b: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I4
		//IL_0086: Expected I4, but got Obj
		//IL_00bb: Expected I4, but got Obj
		//IL_0093: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got I
		//IL_00d1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00dc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_011d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0069->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0128->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0102->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0074->IL0026: Incompatible stack types: I4 vs Obj
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
			case 5:
				if (ExceptionHelpers.GetHRForException((Exception)obj) > 0)
				{
					obj2 = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto IL_0086;
			default:
				/*Error near IL_007b: Stack underflow*/((object[])/*Error near IL_007b: Stack underflow*/, (nint)obj);
				return (byte)(int)MarshalInspectable<object>.FromAbiArray((object)IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_0080: Stack underflow*/, (uint)/*Error near IL_0080: Stack underflow*/, (nint)/*Error near IL_0080: Stack underflow*/, (uint*)/*Error near IL_0080: Stack underflow*/));
			case 3:
				obj = IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized as Enum;
				obj2 = 2;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
				{
					obj2 = 0;
				}
				break;
			case 1:
				obj = IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)/*Error near IL_00bb: Stack underflow*/, (uint)(int)obj);
				obj2 = 4;
				if (IEnumerator_System_IDisposable._initialized != 0)
				{
					obj2 = 1;
				}
				break;
			case 4:
				if (obj != null)
				{
					obj2 = 4;
					if (IEnumerable_System_IDisposable._initialized == 0)
					{
						obj2 = 5;
					}
					break;
				}
				goto IL_0086;
			case 2:
				{
					if (obj != null)
					{
						obj2 = 1;
						if (IEnumerable_object._initialized == 0)
						{
							obj2 = 0;
						}
						break;
					}
					goto IL_0086;
				}
				IL_0086:
				return 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00ᨀ(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00e2: Expected Obj, but got I
		//IL_00b2: Expected I, but got Obj
		//IL_0088: Expected I, but got Obj
		//IL_00f6: Expected Obj, but got I
		//IL_00c6->IL0026: Incompatible stack heights: 3 vs 1
		//IL_009c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0081->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00fb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d1->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00a7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0106->IL0026: Incompatible stack types: I4 vs Obj
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
			case 0:
				return;
			case 4:
				/*Error near IL_0077: Stack underflow*/((object[])(object)this, IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized);
				obj2 = 5;
				break;
			case 3:
				IList_object._initialized = (nint)P_0;
				obj2 = 2;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 4;
				}
				break;
			case 2:
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute);
				_ = 3;
				if (IReadOnlyList_object._initialized == 0)
				{
					_ = 1;
				}
				break;
			case 1:
				if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2(MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)/*Error near IL_00d6: Stack underflow*/), (INotifyPropertyChanged)IEnumerator_System_IDisposable._initialized, ref *(uint*)P_0))
				{
					obj2 = 0;
					if (IEnumerable_System_IDisposable.CombineAttribute == null)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 2;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_1B00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779001, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00ᰀ(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778950, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00ᴀ(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_0083: Expected Obj, but got I4
		//IL_00c8: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I
		//IL_00b2: Expected I, but got Obj
		//IL_00fd: Expected I, but got Obj
		//IL_0097: Expected Obj, but got I
		//IL_0067->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0088->IL00bd: Incompatible stack heights: 1 vs 0
		//IL_00dc->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00bc->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0111->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0072->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009c->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00e7->IL0026: Incompatible stack heights: 3 vs 1
		//IL_011c->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a7->IL0026: Incompatible stack heights: 2 vs 1
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
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					obj2 = 5;
				}
				break;
			case 2:
				/*Error near IL_0077: Stack underflow*/((object[])/*Error near IL_0077: Stack underflow*/, (nint)/*Error near IL_0077: Stack underflow*/);
				_ = IList_object._initialized;
				if (MarshalInspectable<object>.FromAbiArray((object)P_0) != null)
				{
					_ = 1;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
					{
						_ = 1;
					}
					break;
				}
				goto case 3;
			case 4:
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00b2: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00b2: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)IReadOnlyList_System_IDisposable._initialized);
				_ = 6;
				break;
			case 1:
				return;
			case 6:
				return;
			case 3:
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
				_ = 0;
				if (IEnumerator_System_IDisposable.ReflectTransferableAttribute != null)
				{
					_ = 0;
				}
				break;
			case 5:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetMany_3((nint)/*Error near IL_00fd: Stack underflow*/, (uint)/*Error near IL_00fd: Stack underflow*/, (uint)/*Error near IL_00fd: Stack underflow*/, (nint)this, (uint*)(int)P_0);
				_ = 2;
				if (IEnumerable_object._initialized == 0)
				{
					_ = 4;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00Ḁ(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778951, new IntPtr(2737336605276L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00ἀ()
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
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_2000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778948, new IntPtr(2737336604236L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_2100()
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
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_2200()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778949, new IntPtr(2737336587596L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_2300()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18616, 1790778946, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778946, new IntPtr(2737336593836L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_2400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778947, new IntPtr(2737336575116L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
