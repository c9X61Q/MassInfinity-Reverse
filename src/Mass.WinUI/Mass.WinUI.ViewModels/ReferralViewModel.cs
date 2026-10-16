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
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using ABI.Microsoft.UI.Xaml;
using ABI.Microsoft.UI.Xaml.Controls;
using ABI.Microsoft.UI.Xaml.Markup;
using ABI.System.Collections;
using ABI.System.Collections.Generic;
using ABI.System.Collections.Specialized;
using ABI.System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.WinUI.Controls;
using Mass.Domain.Desktop.Entities.LanGame;
using Mass.Domain.Entities.Mass;
using Mass.WinUI.Helpers;
using Mass.WinUI.Mass_WinUI_XamlTypeInfo;
using Mass.WinUI.Models;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media.Animation;
using WinRT;
using WinRT.Mass_WinUIGenericHelpers;
using WinRT.Mass_WinUIVtableClasses;

namespace Mass.WinUI.ViewModels;

[WinRTExposedType(typeof(Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
public class ReferralViewModel : ObservableObject, IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRedeemPoints_003Ed__52 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ReferralViewModel _003C_003E4__this;

		public string productCode;

		private object _003Cresult_003E5__2;

		private object _003CfileName_003E5__3;

		private TaskAwaiter<EntityMassReferralVoucher> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		internal static object CombineDecryptor;

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
		internal static bool DecorateTransformableInitializer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateSequentialPublisher()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00需()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778814, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00頀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_08c1: Expected Obj, but got Ref
			//IL_004e: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got I
			//IL_08af: Expected Obj, but got Ref
			//IL_0077: Expected Obj, but got I4
			//IL_0077: Expected Obj, but got Ref
			//IL_0086: Expected Obj, but got I
			//IL_00df: Expected Obj, but got I
			//IL_0163: Expected I4, but got Obj
			//IL_0126: Expected I, but got Obj
			//IL_0313: Expected Obj, but got Ref
			//IL_040a: Expected Obj, but got Ref
			//IL_060f: Expected Obj, but got Ref
			//IL_04e8: Expected Obj, but got I
			//IL_0384: Expected Obj, but got Ref
			//IL_0267: Expected Obj, but got I4
			//IL_0277: Expected Obj, but got I4
			//IL_0285: Expected Obj, but got I4
			//IL_0296: Expected Obj, but got I4
			//IL_029d: Expected I, but got Obj
			//IL_02a9: Expected Obj, but got Ref
			//IL_02b4: Expected Obj, but got Ref
			//IL_02b9: Expected I, but got Obj
			//IL_02bf: Expected Obj, but got Ref
			//IL_02c4: Expected I, but got Obj
			//IL_02d3: Expected I, but got Obj
			//IL_02d3: Expected I, but got Obj
			//IL_074b: Expected Obj, but got I4
			//IL_0750: Expected Obj, but got I4
			//IL_0750: Expected Obj, but got Ref
			//IL_0458: Expected Obj, but got Ref
			//IL_05d8: Expected Obj, but got Ref
			//IL_05ac: Expected Obj, but got Ref
			//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ff: Expected Obj, but got Ref
			//IL_03df: Expected Obj, but got Ref
			//IL_0358: Expected Obj, but got Ref
			//IL_0597: Expected Obj, but got I4
			//IL_059c: Expected Obj, but got I4
			//IL_059c: Expected Obj, but got Ref
			//IL_0684: Expected Obj, but got Ref
			//IL_0621: Expected Obj, but got Ref
			//IL_0621: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e9: Expected Obj, but got I4
			//IL_02ee: Expected Obj, but got I4
			//IL_02ee: Expected Obj, but got Ref
			//IL_0433: Expected Obj, but got Ref
			//IL_0722: Expected Obj, but got I4
			//IL_0727: Expected Obj, but got I4
			//IL_0727: Expected Obj, but got Ref
			//IL_0341: Expected I, but got Obj
			//IL_0341: Expected I, but got Obj
			//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0704: Expected Obj, but got Ref
			//IL_0583: Expected Obj, but got I4
			//IL_0588: Expected Obj, but got I4
			//IL_0588: Expected Obj, but got Ref
			//IL_06d9: Expected Obj, but got Ref
			//IL_06ad: Expected Obj, but got Ref
			//IL_0525: Expected Obj, but got Ref
			//IL_03ae: Expected Obj, but got Ref
			//IL_03b3: Expected I, but got Obj
			//IL_03ba: Expected Obj, but got I
			//IL_0636: Expected Obj, but got I4
			//IL_063b: Expected Obj, but got I4
			//IL_063b: Expected Obj, but got Ref
			//IL_08d0->IL0026: Incompatible stack heights: 3 vs 1
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_08bb->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0096->IL0026: Incompatible stack types: I4 vs Obj
			//IL_011f->IL00ad: Incompatible stack heights: 7 vs 1
			//IL_04d4->IL0186: Incompatible stack heights: 3 vs 1
			//IL_04f2->IL0186: Incompatible stack heights: 2 vs 1
			//IL_0474->IL0186: Incompatible stack heights: 2 vs 1
			//IL_04fe->IL0228: Incompatible stack heights: 1 vs 0
			//IL_0243->IL0186: Incompatible stack heights: 2 vs 1
			//IL_071d->IL0186: Incompatible stack heights: 7 vs 1
			//IL_049a->IL02e4: Incompatible stack heights: 1 vs 0
			//IL_0550->IL057e: Incompatible stack heights: 1 vs 0
			//IL_06c2->IL0186: Incompatible stack heights: 8 vs 1
			//IL_03ce->IL0186: Incompatible stack heights: 2 vs 1
			//IL_04df->IL0186: Incompatible stack heights: 3 vs 1
			//IL_047f->IL0186: Incompatible stack heights: 2 vs 1
			//IL_0512->IL0186: Incompatible stack heights: 2 vs 1
			//IL_024e->IL0186: Incompatible stack heights: 2 vs 1
			//IL_04ae->IL0186: Incompatible stack heights: 2 vs 1
			//IL_055a->IL0186: Incompatible stack heights: 2 vs 1
			//IL_03d9->IL0186: Incompatible stack heights: 2 vs 1
			//IL_051d->IL0186: Incompatible stack heights: 2 vs 1
			//IL_04b9->IL0186: Incompatible stack heights: 2 vs 1
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 3;
			object obj = awaiter;
			while (true)
			{
				int num;
				switch ((int)obj)
				{
				case 2:
					awaiter = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
					obj = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj = 0;
					}
					break;
				case 4:
					IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute = -2;
					obj = 1;
					if (IList_object.PatchAttribute == null)
					{
						obj = 1;
					}
					break;
				default:
					if ((nuint)(nint)awaiter > (nuint)2u)
					{
						num = 4;
						goto IL_00ad;
					}
					goto IL_00cf;
				case 3:
					awaiter = __KnownINotifyPropertyChangingArgs.CanDesktopMenuInvoke;
					obj = 2;
					break;
				case 1:
					_ = ref __KnownINotifyPropertyChangingArgs.CanMobileMenuInvoke;
					_ = AppContext.BaseDirectory;
					_ = 5;
					break;
				case 5:
					return;
					IL_00cf:
					num = 0;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
					{
						num = 1;
					}
					goto IL_00ad;
					IL_00ad:
					while (true)
					{
						switch (num)
						{
						case 3:
						case 5:
							break;
						case 2:
							goto IL_00cf;
						default:
							_ = IReadOnlyList_System_IDisposable._initialized;
							IEnumerator_object.LoadAttribute();
							_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Initialized;
							_ = 2;
							IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Init();
							_ = 3;
							continue;
						case 4:
							if ((int)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_0126: Stack underflow*/, (uint)/*Error near IL_0126: Stack underflow*/, (nint*)(nint)awaiter) < 200)
							{
								num = 0;
								if (IEnumerable_System_IDisposable._initialized != 0)
								{
									num = 0;
								}
								continue;
							}
							goto IL_00cf;
						case 1:
						{
							int num2;
							switch ((int)awaiter)
							{
							default:
								num2 = 36;
								if (IEnumerable_object._initialized != 0)
								{
									num2 = 4;
								}
								goto IL_0186;
							case 0:
								awaiter = __KnownINotifyPropertyChangingArgs.Content;
								num2 = 14;
								if (__KnownINotifyPropertyChangingArgs.IsSkeleton == null)
								{
									num2 = 14;
								}
								goto IL_0186;
							case 1:
								goto IL_0404;
							case 2:
								goto IL_0609;
								IL_0186:
								while (true)
								{
									switch (num2)
									{
									case 8:
										break;
									case 18:
										IReadOnlyListMethods<INotifyPropertyChanged>.Abi_get_Size_1((IntPtr)(nint)(&awaiter));
										_ = 2;
										if (Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute != null)
										{
											_ = 9;
										}
										continue;
									case 3:
									{
										bool flag = IListMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_0258: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_0258: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)/*Error near IL_0258: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_0258: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_0258: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, nint, int>)/*Error near IL_0258: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int>)/*Error near IL_0258: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, int>)/*Error near IL_0258: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)/*Error near IL_0258: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int>)/*Error near IL_0258: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)/*Error near IL_0258: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, int>)MarshalInterface<IEnumerator<INotifyPropertyChanged>>.FromManaged((IEnumerator<INotifyPropertyChanged>)/*Error near IL_0253: Stack underflow*/));
										IEnumerable_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
										IntPtr intPtr = MarshalInterface<IReadOnlyList<object>>.FromManaged((IReadOnlyList<object>)IEnumerable_System_ComponentModel_INotifyPropertyChanged.DecorateSeparatedAttribute());
										MarshalInspectable<object>.FromAbi(intPtr);
										awaiter = new IListMethods<object>((IntPtr)(nint)Unsafe.AsPointer(ref this), (object)11, ref *(uint*)1);
										IListMethods<object>.Abi_InsertAt_5((IntPtr)/*Error near IL_0285: Stack underflow*/, (uint)/*Error near IL_0285: Stack underflow*/, (object)IList_object.Do_Abi_GetAt_0((nint)(flag ? 1 : 0), (uint)(nint)intPtr, (nint*)(&awaiter)));
										IListMethods<object>.Abi_RemoveAt_6((IntPtr)/*Error near IL_028c: Stack underflow*/, (uint)(&awaiter));
										IListMethods<object>.Abi_ReplaceAll_11((IntPtr)(int)IListMethods<object>.Abi_GetMany_10((IntPtr)/*Error near IL_02a2: Stack underflow*/, (uint)/*Error near IL_02a2: Stack underflow*/, ref *(object[]*)IList_object.Do_Abi_RemoveAt_6((nint)JsonSerializer.Deserialize<object>((string)/*Error near IL_0296: Stack underflow*/, (JsonSerializerOptions?)IList_object.Do_Abi_SetAt_4((nint)/*Error near IL_0291: Stack underflow*/, (uint)/*Error near IL_0291: Stack underflow*/, (nint)/*Error near IL_0291: Stack underflow*/)), (uint)(&awaiter))), (object[])(&awaiter));
										_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_hasTimeout = (byte)/*Error near IL_02ae: Stack underflow*/ != 0;
										bool flag2 = IEnumeratorMethods<INotifyPropertyChanged>.Abi_MoveNext_2((IntPtr)_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.DecorateGroupedGenerator);
										INotifyPropertyChanged notifyPropertyChanged = IEnumeratorMethods<INotifyPropertyChanged>.Abi_get_Current_0((IntPtr)__KnownINotifyPropertyChangingArgs.UserId);
										awaiter = null;
										awaiter = IReadOnlyListMethods<IDisposable>.Abi_GetAt_0((IntPtr)/*Error near IL_02d8: Stack underflow*/, IReadOnlyListMethods<IDisposable, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_02d3: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)(flag2 ? 1 : 0), (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)notifyPropertyChanged, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)awaiter) ? 1u : 0u);
										num2 = 27;
										continue;
									}
									case 21:
										awaiter = 1;
										__KnownINotifyPropertyChangingArgs.IsMyself = (PropertyChangingEventArgs)1;
										num2 = 29;
										if (__KnownINotifyPropertyChangingArgs.CharacterName != null)
										{
											num2 = 35;
										}
										continue;
									case 26:
										goto end_IL_0186;
									case 24:
										awaiter = IReadOnlyListMethods<object>.Abi_GetAt_0((IntPtr)/*Error near IL_0346: Stack underflow*/, IReadOnlyListMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_0341: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)awaiter, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)(IEnumerator_System_ComponentModel_INotifyPropertyChanged.DecorateDynamicAttribute() ? 1 : 0), (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)null) ? 1u : 0u);
										num2 = 13;
										continue;
									case 14:
										__KnownINotifyPropertyChangingArgs.MaxPlayers = null;
										num2 = 37;
										if (__KnownINotifyPropertyChangingArgs.Version != null)
										{
											num2 = 25;
										}
										continue;
									case 2:
										__KnownINotifyPropertyChangingArgs.ImageUrl = null;
										num2 = 0;
										if (__KnownINotifyPropertyChangingArgs.BackgroundImageUrl == null)
										{
											num2 = 8;
										}
										continue;
									case 36:
										IEnumeratorMethods<IDisposable>.Abi_get_HasCurrent_1((IntPtr)/*Error near IL_03a8: Stack underflow*/);
										awaiter = (nint)MarshalInterface<IEnumerator<IDisposable>>.FromManaged(IEnumerableMethods<IDisposable>.Abi_First_0((IntPtr)__KnownINotifyPropertyChangingArgs.Summary));
										_ = 18;
										if (__KnownINotifyPropertyChangingArgs.Executor != null)
										{
											_ = 28;
										}
										continue;
									case 12:
										Unsafe.As<PropertyChangingEventArgs, AsyncTaskMethodBuilder>(ref __KnownINotifyPropertyChangingArgs.LaunchTime).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<string[]>*)(&awaiter), ref Unsafe.As<_003CRedeemPoints_003Ed__52, ImportAccountViewModel._003CParseFile_003Ed__48>(ref this));
										num2 = 7;
										continue;
									case 6:
										goto IL_0404;
									case 22:
										__KnownINotifyPropertyChangingArgs.Type = (PropertyChangingEventArgs)awaiter;
										num2 = 5;
										if (__KnownINotifyPropertyChangingArgs.Id == null)
										{
											num2 = 2;
										}
										continue;
									case 5:
										_ = ref __KnownINotifyPropertyChangingArgs.OrderId;
										((AsyncTaskMethodBuilder*)(&awaiter))->Start(ref Unsafe.As<_003CRedeemPoints_003Ed__52, ChatViewModel._003CSend_003Ed__9>(ref this));
										_ = 17;
										if (__KnownINotifyPropertyChangingArgs.OrderAt != null)
										{
											_ = 8;
										}
										continue;
									case 7:
										return;
									case 27:
										_ = ref awaiter;
										if (IEnumerableMethods<object>.AbiToProjectionVftablePtr != (IntPtr)0)
										{
											_ = 8;
											if (__KnownINotifyPropertyChangingArgs.PayUrl == null)
											{
												_ = 29;
											}
											continue;
										}
										goto case 21;
									default:
										_ = ref awaiter;
										_ = IEnumerableMethods.IID;
										_ = 4;
										if (__KnownINotifyPropertyChangingArgs.JoinedAt != null)
										{
											_ = 25;
										}
										continue;
									case 1:
									case 33:
										_ = ref awaiter;
										awaiter = (nint)INotifyCollectionChangedMethods.AbiToProjectionVftablePtr;
										_ = 11;
										continue;
									case 13:
										_ = ref awaiter;
										if ((int)INotifyPropertyChangedMethods.IID == 0)
										{
											_ = 4;
											if (__KnownINotifyPropertyChangingArgs.CreatedAt == null)
											{
												_ = 4;
											}
											continue;
										}
										goto case 18;
									case 35:
										__KnownINotifyPropertyChangingArgs.Quantity = (PropertyChangingEventArgs)awaiter;
										num2 = 10;
										if (__KnownINotifyPropertyChangingArgs.MobileAccounts == null)
										{
											num2 = 12;
										}
										continue;
									case 28:
										_ = ref awaiter;
										if ((int)IEnumerableMethods<INotifyPropertyChanged>.IID != 0)
										{
											_ = 33;
											continue;
										}
										goto case 30;
									case 17:
										return;
									case 30:
										awaiter = 0;
										__KnownINotifyPropertyChangingArgs.Input4399Username = (PropertyChangingEventArgs)0;
										num2 = 31;
										continue;
									case 15:
										awaiter = -1;
										__KnownINotifyPropertyChangingArgs.InputEmail = (PropertyChangingEventArgs)(-1);
										num2 = 18;
										continue;
									case 10:
										__KnownINotifyPropertyChangingArgs.InputCookie = (PropertyChangingEventArgs)default(XmlnsDefinition);
										num2 = 15;
										if (__KnownINotifyPropertyChangingArgs.InputMobilePassword == null)
										{
											num2 = 5;
										}
										continue;
									case 9:
										__KnownINotifyPropertyChangingArgs.InputMobile = null;
										num2 = 0;
										if (__KnownINotifyPropertyChangingArgs.VerifyCodeDelayText != null)
										{
											num2 = 2;
										}
										continue;
									case 11:
										__KnownINotifyPropertyChangingArgs.InfoBarMessage = (PropertyChangingEventArgs)awaiter;
										num2 = 3;
										continue;
									case 20:
										goto IL_0609;
									case 19:
										__KnownINotifyPropertyChangingArgs.InfoBarIsOpen = (PropertyChangingEventArgs)default(NavigationView);
										num2 = 23;
										continue;
									case 37:
										awaiter = -1;
										__KnownINotifyPropertyChangingArgs.Step = (PropertyChangingEventArgs)(-1);
										num2 = 1;
										if (__KnownINotifyPropertyChangingArgs.HasSelectedFile == null)
										{
											num2 = 1;
										}
										continue;
									case 16:
										Unsafe.As<PropertyChangingEventArgs, AsyncTaskMethodBuilder>(ref __KnownINotifyPropertyChangingArgs.SkippedCount).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityLanGameRoom[]>*)(&awaiter), ref Unsafe.As<_003CRedeemPoints_003Ed__52, DesktopViewModel._003CRefreshLanGame_003Ed__46>(ref this));
										num2 = 34;
										continue;
									case 32:
										_ = __KnownINotifyPropertyChangingArgs.ParseErrorMessage;
										((Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails)(object)Mass_WinUI_Pages_MobileWinRTTypeDetails.CheckInterruptibleAttribute()).GetExposedInterfaces();
										_ = __KnownINotifyPropertyChangingArgs.HasSelectedGame;
										_ = IContentControlOverridesMethods.AbiToProjectionVftablePtr;
										_ = 1;
										Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.CheckExpandableAttribute();
										_ = 24;
										continue;
									case 34:
										return;
									case 31:
										__KnownINotifyPropertyChangingArgs.NetGames = (PropertyChangingEventArgs)awaiter;
										num2 = 16;
										if (__KnownINotifyPropertyChangingArgs.FourLikeNetGames == null)
										{
											num2 = 1;
										}
										continue;
									case 25:
										new IPageOverridesMethods();
										_ = __KnownINotifyPropertyChangingArgs.LikeNetGamesEmptyText;
										_ = IApplicationOverridesMethods.AbiToProjectionVftablePtr;
										_ = IXamlMetadataProviderMethods.IID;
										_ = IXamlMetadataProviderMethods.AbiToProjectionVftablePtr;
										_ = 32;
										continue;
									case 23:
										awaiter = -1;
										__KnownINotifyPropertyChangingArgs.SkinEmptyText = (PropertyChangingEventArgs)(-1);
										num2 = 0;
										if (__KnownINotifyPropertyChangingArgs.SkinAllSelected != null)
										{
											num2 = 0;
										}
										continue;
									case 4:
										awaiter = 2;
										__KnownINotifyPropertyChangingArgs.SkinOwnedSelected = (PropertyChangingEventArgs)2;
										num2 = 22;
										if (__KnownINotifyPropertyChangingArgs.PagesOfSkins == null)
										{
											num2 = 14;
										}
										continue;
									}
									goto end_IL_0152;
									continue;
									end_IL_0186:
									break;
								}
								goto case 0;
								IL_0609:
								awaiter = __KnownINotifyPropertyChangingArgs.InfoBarSeverity;
								num2 = 10;
								goto IL_0186;
								IL_0404:
								awaiter = __KnownINotifyPropertyChangingArgs.StateText;
								num2 = 19;
								if (__KnownINotifyPropertyChangingArgs.CloseText != null)
								{
									num2 = 15;
								}
								goto IL_0186;
								end_IL_0152:
								break;
							}
							break;
						}
						}
						break;
					}
					goto case 4;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00餀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778815, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00騀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778812, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00鬀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00鰀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778813, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00鴀()
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
		private unsafe sealed void _FF00_FF00_FF00_FF00鸀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00鼀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778810, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRedeemSelf_003Ed__51 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string productCode;

		public ReferralViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object ArrangeUser;

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
		internal static bool ReflectEfficientMap()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateAttachedVisitor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00謀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778811, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00谀()
		{
			//IL_0011: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0063: Expected Obj, but got I4
			//IL_0063: Expected Obj, but got Ref
			//IL_0072: Expected Obj, but got I
			//IL_009a: Expected Obj, but got Ref
			//IL_004e: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got I
			//IL_0088: Expected Obj, but got Ref
			//IL_008a: Expected Obj, but got I
			//IL_041f: Expected Obj, but got Ref
			//IL_02bd: Expected Obj, but got Ref
			//IL_03f2: Expected Obj, but got Ref
			//IL_039b: Expected Obj, but got Ref
			//IL_0209: Expected Obj, but got Ref
			//IL_0209: Unknown result type (might be due to invalid IL or missing references)
			//IL_035d: Expected Obj, but got I4
			//IL_0362: Expected Obj, but got I4
			//IL_0362: Expected Obj, but got Ref
			//IL_021f: Expected Obj, but got Ref
			//IL_0231: Expected Obj, but got Ref
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_0240: Expected Obj, but got I4
			//IL_01da: Expected Obj, but got I4
			//IL_0298: Expected Obj, but got Ref
			//IL_01ab: Expected Obj, but got I4
			//IL_01b0: Expected Obj, but got Ref
			//IL_03b0: Expected Obj, but got Ref
			//IL_03b5: Expected I, but got Obj
			//IL_03b5: Expected I, but got Obj
			//IL_0349: Expected Obj, but got Ref
			//IL_027d: Expected Obj, but got I4
			//IL_0282: Expected Obj, but got I4
			//IL_0282: Expected Obj, but got Ref
			//IL_028b: Expected Obj, but got I4
			//IL_0252: Expected I, but got Obj
			//IL_0197: Expected Obj, but got I4
			//IL_019c: Expected Obj, but got I4
			//IL_019c: Expected Obj, but got Ref
			//IL_018d: Expected I4, but got Obj
			//IL_0077->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00b3->IL0026: Incompatible stack heights: 2 vs 1
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0094->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0082->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00be->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0435->IL0128: Incompatible stack types: I4 vs Obj
			//IL_0119->IL0128: Incompatible stack types: I4 vs Obj
			//IL_0440->IL0128: Incompatible stack types: I4 vs Obj
			//IL_0124->IL0128: Incompatible stack types: I4 vs Obj
			//IL_02d9->IL0128: Incompatible stack heights: 2 vs 1
			//IL_02ff->IL0128: Incompatible stack heights: 2 vs 1
			//IL_040e->IL0128: Incompatible stack types: I4 vs Obj
			//IL_03a5->IL0128: Incompatible stack types: I4 vs Obj
			//IL_03ec->IL0128: Incompatible stack heights: 2 vs 1
			//IL_0219->IL0128: Incompatible stack types: I4 vs Obj
			//IL_036c->IL0128: Incompatible stack types: I4 vs Obj
			//IL_022b->IL0128: Incompatible stack types: I4 vs Obj
			//IL_01df->IL0124: Incompatible stack heights: 5 vs 0
			//IL_02ac->IL0128: Incompatible stack types: I4 vs Obj
			//IL_01ba->IL0128: Incompatible stack types: I4 vs Obj
			//IL_03d0->IL0128: Incompatible stack types: I4 vs Obj
			//IL_026d->IL0128: Incompatible stack types: I4 vs Obj
			//IL_01a6->IL0128: Incompatible stack types: I4 vs Obj
			//IL_02e4->IL0128: Incompatible stack heights: 2 vs 1
			//IL_0342->IL0128: Incompatible stack types: I4 vs Obj
			//IL_030a->IL0128: Incompatible stack heights: 2 vs 1
			//IL_0419->IL0128: Incompatible stack types: I4 vs Obj
			//IL_02b7->IL0128: Incompatible stack types: I4 vs Obj
			//IL_03db->IL0128: Incompatible stack types: I4 vs Obj
			//IL_0358->IL0128: Incompatible stack types: I4 vs Obj
			//IL_0388->IL0128: Incompatible stack types: I4 vs Obj
			//IL_0278->IL0128: Incompatible stack types: I4 vs Obj
			//IL_0393->IL0128: Incompatible stack types: I4 vs Obj
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
				case 3:
					awaiter = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
					obj = 2;
					break;
				case 5:
					return;
				default:
					IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = -2;
					obj = 1;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
					{
						obj = 1;
					}
					break;
				case 4:
					awaiter = IList_object._initialized;
					obj = 3;
					break;
				case 1:
					IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)(nint)Unsafe.AsPointer(ref IList_object.PatchAttribute));
					_ = 1;
					if (IReadOnlyList_System_IDisposable._initialized == 0)
					{
						_ = 5;
					}
					break;
				case 2:
				{
					_ = 1;
					int num = 1;
					if (IReadOnlyList_object._initialized == 0)
					{
						num = 1;
					}
					while (true)
					{
						object obj2;
						switch (num)
						{
						case 2:
							break;
						default:
							if (awaiter != null)
							{
								obj2 = 21;
								if (IEnumerator_System_IDisposable._initialized == 0)
								{
									obj2 = 1;
								}
								goto IL_0128;
							}
							goto IL_0419;
						case 1:
							{
								num = 0;
								if (__KnownINotifyPropertyChangingArgs.Price == null)
								{
									num = 0;
								}
								continue;
							}
							IL_0128:
							while (true)
							{
								switch ((int)obj2)
								{
								case 15:
									return;
								case 19:
									return;
								case 4:
									break;
								case 23:
									awaiter = 1;
									IEnumerator_System_IDisposable.ReflectTransferableAttribute = 1;
									obj2 = 13;
									continue;
								case 14:
									awaiter = 0;
									IEnumerable_System_IDisposable._initialized = 0;
									obj2 = 6;
									continue;
								case 12:
									_ = IEnumerable_System_IDisposable.CombineAttribute;
									IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
									IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.MoveAttribute();
									_ = 1;
									IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.CheckSymbolicAttribute();
									awaiter = 22;
									goto IL_0124;
								case 8:
									Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute = (object)default(ExceptionHelpers);
									obj2 = 9;
									continue;
								case 10:
									awaiter = Mass_WinUI_Pages_MobileWinRTTypeDetails.TestAttribute;
									obj2 = 8;
									continue;
								case 11:
									Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute = (object)default(Marshaler<>);
									awaiter = 18;
									goto IL_0124;
								case 22:
									IListMethods<object>.Abi_SetAt_4((IntPtr)awaiter, (uint)IList_object.Init(), (object)null);
									IListMethods<object>.Abi_InsertAt_5((IntPtr)/*Error near IL_0257: Stack underflow*/, (uint)/*Error near IL_0257: Stack underflow*/, (object)/*Error near IL_0257: Stack underflow*/);
									awaiter = (object)/*Error near IL_0259: Stack underflow*/;
									obj2 = 17;
									if (Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails.SetAttribute == null)
									{
										obj2 = 3;
									}
									continue;
								case 18:
									awaiter = -1;
									_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.Instance = (_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0)(-1);
									awaiter = 7;
									goto IL_0124;
								case 13:
									_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0.ReflectLiteralAttribute = awaiter;
									obj2 = 0;
									if ((int)_003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_defaultTimeout == 0)
									{
										obj2 = 0;
									}
									continue;
								default:
									_ = ref _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__Utilities.s_hasTimeout;
									((AsyncTaskMethodBuilder*)(&awaiter))->Start(ref Unsafe.As<_003CRedeemSelf_003Ed__51, AccountViewModel._003CLoginMobile_003Ed__88>(ref this));
									_ = 16;
									if (__KnownINotifyPropertyChangingArgs.UserId == null)
									{
										_ = 19;
									}
									continue;
								case 2:
								case 3:
									IEnumeratorMethods<INotifyPropertyChanged>.Abi_get_Current_0((IntPtr)(nint)(&awaiter));
									_ = 1;
									if (__KnownINotifyPropertyChangingArgs.LoginAt != null)
									{
										_ = 4;
									}
									continue;
								case 1:
									if (IReadOnlyListMethods<IDisposable>.Abi_GetAt_0((IntPtr)/*Error near IL_0333: Stack underflow*/, (uint)(&awaiter)) == null)
									{
										obj2 = 14;
										continue;
									}
									goto case 7;
								case 17:
									if (MarshalInterface<IDisposable>.FromManaged((IDisposable)(&awaiter)) != (IntPtr)0)
									{
										obj2 = 2;
										continue;
									}
									goto case 23;
								case 9:
									awaiter = -1;
									__KnownINotifyPropertyChangingArgs.Message = (PropertyChangingEventArgs)(-1);
									obj2 = 3;
									continue;
								case 21:
									if ((nint)awaiter != 1)
									{
										obj2 = 16;
										if (__KnownINotifyPropertyChangingArgs.Content == null)
										{
											obj2 = 11;
										}
										continue;
									}
									goto case 10;
								case 6:
									__KnownINotifyPropertyChangingArgs.IsSelected = (PropertyChangingEventArgs)awaiter;
									obj2 = 5;
									continue;
								case 16:
									awaiter = IReadOnlyListMethods<object>.Abi_GetAt_0((IntPtr)/*Error near IL_03ba: Stack underflow*/, IReadOnlyListMethods<object, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_03b5: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_03b5: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)MarshalInterface<IDisposable>.FromAbiArray((object)/*Error near IL_03aa: Stack underflow*/), (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)__KnownINotifyPropertyChangingArgs.CanProxy) ? 1u : 0u);
									obj2 = 1;
									if (__KnownINotifyPropertyChangingArgs.Author == null)
									{
										obj2 = 1;
									}
									continue;
								case 7:
									IReadOnlyListMethods<object>.Abi_get_Size_1((IntPtr)(nint)(&awaiter));
									_ = 12;
									continue;
								case 5:
									Unsafe.As<PropertyChangingEventArgs, AsyncTaskMethodBuilder>(ref __KnownINotifyPropertyChangingArgs.Version).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CRedeemSelf_003Ed__51, AccountViewModel._003CLoginRandom_003Ed__85>(ref this));
									obj2 = 15;
									if (__KnownINotifyPropertyChangingArgs.BackgroundImageUrl == null)
									{
										obj2 = 9;
									}
									continue;
								case 20:
									goto end_IL_0128;
									IL_0124:
									obj2 = awaiter;
									continue;
								}
								goto end_IL_00e7;
								continue;
								end_IL_0128:
								break;
							}
							goto IL_0419;
							IL_0419:
							awaiter = __KnownINotifyPropertyChangingArgs.IsLiked;
							obj2 = 1;
							if (__KnownINotifyPropertyChangingArgs.PreviewImage == null)
							{
								obj2 = 11;
							}
							goto IL_0128;
							end_IL_00e7:
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
		internal unsafe static byte _FF00_FF00_FF00_FF00贀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778808, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00踀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00輀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778809, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00退()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778758, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00鄀()
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
		internal unsafe static object _FF00_FF00_FF00_FF00鈀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778759, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00錀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778756, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00鐀(object P_0)
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
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRefresh_003Ed__47 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ReferralViewModel _003C_003E4__this;

		private TaskAwaiter<List<EntityMassReferralProduct>> _003C_003Eu__1;

		private TaskAwaiter<EntityMassReferralInfo> _003C_003Eu__2;

		private static object CreateTransformer;

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
		internal static bool ControlMap()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateDetailedDriver()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00舀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778757, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00茀()
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
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildArgumentList(ExpectedTargetDetails expectedTargetDetails, ResolveResult target, IMethod method, Int32 firstParamIndex, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, Boolean writtenAsAssignment) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1070
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(OpCode callOpCode, IMethod method, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, IType constrainedTo) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 461
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(CallInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 255
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitNewObj(NewObj inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 538
			//    at ICSharpCode.Decompiler.IL.NewObj.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4578
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitStObj(StObj inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 3219
			//    at ICSharpCode.Decompiler.IL.StObj.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4386
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitStObj(StObj inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 140
			//    at ICSharpCode.Decompiler.IL.StObj.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4382
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
			//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitIfInstruction(IfInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 162
			//    at ICSharpCode.Decompiler.IL.IfInstruction.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 1440
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
		internal unsafe static byte _FF00_FF00_FF00_FF00萀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778754, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00蔀()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00蘀()
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
		internal unsafe static object _FF00_FF00_FF00_FF00蜀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778755, new IntPtr(2737336163692L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00蠀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00褀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778752, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[CompilerGenerated]
	private Func<InfoBarDelegate>? m_GetInfoBar;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? refreshCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private RelayCommand<string>? copyTextCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? copyInviteCodeCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? copyInviteUrlCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<string>? redeemSelfCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<string>? redeemPointsCommand;

	internal static ReferralViewModel TestArgument;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	public string Username
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00瀀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00䈀(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	public int UserId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_FF00_FF00䨀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00簀((uint)value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string InviteCode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00爀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00䠀(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string InviteUrl
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00琀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00蔀(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	[NotifyPropertyChangedFor("CanRedeem")]
	public int TotalPoints
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_FF00_FF00縀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00崀((uint)value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int CustomerCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_FF00_FF00嬀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00䔀((uint)value);
		}
	}

	public bool CanRedeem
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00㨀() != 0;
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	public bool IsLoading
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00渀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00一(value ? ((byte)1) : ((byte)0));
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int SelectedIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_FF00_FF00耀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00怀((uint)value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public ObservableCollection<ReferralEarningModel> Earnings
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00蘀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00儀(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public ObservableCollection<ReferralCustomerModel> Customers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00㤀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00戀(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public ObservableCollection<ReferralRedeemOption> RedeemOptions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00搀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00氀(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand RefreshCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)_FF00_FF00_FF00樀();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand<string> CopyTextCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00吀();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IRelayCommand CopyInviteCodeCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IRelayCommand)_FF00_FF00_FF00䘀();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand CopyInviteUrlCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IRelayCommand)_FF00_FF00_FF00䜀();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<string> RedeemSelfCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00㰀();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand<string> RedeemPointsCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00䴀();
		}
	}

	public event Func<InfoBarDelegate>? GetInfoBar
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			_FF00_FF00_FF00㼀(value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			_FF00_FF00_FF00茀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe ReferralViewModel()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_004a: Expected I4, but got Obj
		//IL_004f: Expected I, but got Obj
		//IL_005a: Expected I, but got Obj
		//IL_005f: Expected I, but got Obj
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected I, but got Unknown
		//IL_0089: Expected Obj, but got I
		//IL_016e: Expected I, but got Obj
		//IL_00d0: Expected I, but got Obj
		//IL_012f: Expected Obj, but got I4
		//IL_015d: Expected I4, but got Obj
		//IL_016e: Expected I, but got Obj
		//IL_00d0: Expected I, but got Obj
		//IL_0120: Expected I, but got Obj
		//IL_008e->IL00a2: Incompatible stack types: I4 vs Obj
		//IL_0099->IL00a2: Incompatible stack types: I4 vs Obj
		//IL_010f->IL00a2: Incompatible stack heights: 3 vs 2
		//IL_00e4->IL00a2: Incompatible stack heights: 4 vs 2
		//IL_0126->IL00ef: Incompatible stack heights: 0 vs 1
		//IL_011a->IL00a2: Incompatible stack heights: 3 vs 2
		//IL_00ef->IL00a2: Incompatible stack heights: 4 vs 2
		//IL_00a2->IL00a2: Incompatible stack heights: 1 vs 2
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute = this;
		IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute = this;
		IList_object.PatchAttribute = this;
		IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized = 1;
		IReadOnlyList_System_IDisposable._initialized = new MarshalInspectable<object>((object)/*Error near IL_004a: Stack underflow*/, (byte)(int)this != 0);
		IReadOnlyList_object._initialized = (new IReadOnlyListMethods<INotifyPropertyChanged, nint>((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_005a: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_005a: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)/*Error near IL_005a: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)this) ? ((nint)1) : ((nint)0));
		IEnumerator_System_IDisposable._initialized = (nint)new MarshalInterface<INotifyPropertyChanged>((INotifyPropertyChanged)this);
		bool flag = IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_007a: Stack underflow*/, (INotifyPropertyChanged)/*Error near IL_007a: Stack underflow*/, ref *(uint*)this);
		int num = 0;
		ReferralViewModel referralViewModel = (ReferralViewModel)flag;
		if (IEnumerable_System_IDisposable.CombineAttribute != null)
		{
			num = 0;
			referralViewModel = (ReferralViewModel)flag;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_get_Size_1((IntPtr)null);
				_ = 1;
				if (Mass_WinUI_Controls_PaymentDialogWinRTTypeDetails.ReflectDividedAttribute == null)
				{
					_ = 0;
				}
				break;
			case 3:
				MarshalInterface<IEnumerator<INotifyPropertyChanged>>.FromManaged((IEnumerator<INotifyPropertyChanged>)this);
				IEnumerable_System_ComponentModel_INotifyPropertyChanged._002Ecctor();
				_ = 4;
				if (Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails.DecorateCustomizableAttribute == null)
				{
					_ = 0;
				}
				break;
			case 1:
				return;
			case 5:
				if (MarshalInspectable<object>.FromAbi((IntPtr)referralViewModel) == null)
				{
					object obj = 2;
					break;
				}
				goto case 3;
			default:
				IListMethods<object>.Abi_RemoveAt_6((IntPtr)/*Error near IL_015d: Stack underflow*/, (uint)(int)referralViewModel);
				referralViewModel = this;
				IListMethods<object>.Abi_Clear_9((IntPtr)new IListMethods<object>((IntPtr)(nint)(delegate* unmanaged[Stdcall]<nint, uint, nint, uint>)(&IList_object.Do_Abi_SetAt_4)));
				num = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefresh_003Ed__47))]
	[RelayCommand]
	private object Refresh()
	{
		return _FF00_FF00_FF00昀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	private void CopyText(object text)
	{
		_FF00_FF00_FF00嘀(text);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	private void CopyInviteCode()
	{
		_FF00_FF00_FF00䰀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	private void CopyInviteUrl()
	{
		_FF00_FF00_FF00眀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedeemSelf_003Ed__51))]
	[RelayCommand]
	private object RedeemSelf(object productCode)
	{
		return _FF00_FF00_FF00最(productCode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CRedeemPoints_003Ed__52))]
	private object RedeemPoints(object productCode)
	{
		return _FF00_FF00_FF00圀(productCode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnUserChanged(object user)
	{
		_FF00_FF00_FF00匀(user);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InfoBar(object text, InfoBarSeverity severity = (InfoBarSeverity)0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_FF00_FF00_FF00䌀(text, severity);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		_FF00_FF00_FF00㸀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectOrderedPredicate()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ReferralViewModel ReflectVisualStub()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<ReferralCustomerModel> _FF00_FF00_FF00㠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778447, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<ReferralCustomerModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<ReferralCustomerModel> _FF00_FF00_FF00㤀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<ReferralCustomerModel>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00㨀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ((nint)_003CModule_003E.CheckAccessibleAttribute() >= 200) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<string> _FF00_FF00_FF00㬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778444, new IntPtr(2737336180332L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<string>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<string> _FF00_FF00_FF00㰀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18131, 1790778445, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778445, new IntPtr(2737336188652L), 15);
		}
		return (IAsyncRelayCommand<string>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00㴀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778442, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00㸀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0073: Expected Obj, but got I
		//IL_0078: Expected I, but got Obj
		//IL_0057->IL0026: Incompatible stack heights: 2 vs 1
		//IL_008c->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0062->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0097->IL0026: Incompatible stack heights: 3 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			case 2:
				return;
			default:
				ExceptionHelpers.GetHRForException((Exception)(object)this);
				_ = 2;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					_ = 2;
				}
				break;
			case 1:
				/*Error near IL_0067: Stack underflow*/((object[])/*Error near IL_0067: Stack underflow*/, (nint)/*Error near IL_0067: Stack underflow*/);
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)new MarshalInspectable<object>((object)(delegate* unmanaged[Stdcall]<nint, uint, nint, uint*, uint>)(&IEnumerator_object.Do_Abi_GetMany_3)));
				_ = 0;
				if (IReadOnlyList_System_IDisposable._initialized != 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00㼀(Func<InfoBarDelegate> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0078: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_00dd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ba->IL0026: Incompatible stack heights: 2 vs 1
		//IL_010e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0065->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0097->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c5->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0119->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
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
				if (obj == obj)
				{
					obj2 = 0;
					if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute != null)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 2;
			case 3:
				obj = IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized;
				obj2 = 2;
				if (IList_object._initialized == 0)
				{
					obj2 = 0;
				}
				break;
			case 4:
				obj = (IEnumerableMethods<INotifyPropertyChanged, nint>)(object)MarshalInspectable<object>.FromAbiArray((object)P_0);
				_ = 5;
				if (IReadOnlyList_System_IDisposable._initialized == 0)
				{
					_ = 1;
				}
				break;
			case 2:
				obj = obj;
				obj2 = 0;
				if (IReadOnlyList_object._initialized == 0)
				{
					obj2 = 4;
				}
				break;
			case 0:
				return;
			case 5:
				_ = ref IReadOnlyList_object.ReflectLogicalAttribute;
				obj = ((XamlUserType)obj).BoxType<EasingMode>(obj);
				_ = 0;
				if (IEnumerable_System_IDisposable._initialized != 0)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00䀀(Func<InfoBarDelegate> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778443, new IntPtr(2737336189692L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00䄀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778440, new IntPtr(2737336182412L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00䈀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_004b: Expected I, but got Obj
		//IL_009f: Expected I, but got Obj
		//IL_0075: Expected I, but got Obj
		//IL_0075: Expected I4, but got Obj
		//IL_00cf: Expected Obj, but got I
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b3->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0089->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00be->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0094->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00de->IL0026: Incompatible stack types: I4 vs Obj
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
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
				obj2 = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					obj2 = 1;
				}
				break;
			case 2:
				((ValueTuple<int, nint>*)/*Error near IL_0075: Stack underflow*/)->_002Ector((int)this, (nint)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute);
				obj2 = 0;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute);
				_ = 0;
				if (IReadOnlyList_object._initialized != 0)
				{
					_ = 4;
				}
				break;
			case 3:
				if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2(MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)/*Error near IL_00c3: Stack underflow*/), (INotifyPropertyChanged)IEnumerator_System_IDisposable._initialized, ref *(uint*)P_0))
				{
					return;
				}
				obj2 = 2;
				break;
			case 4:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00䌀(object P_0, InfoBarSeverity P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected I, but got Unknown
		//IL_007b: Expected I, but got Obj
		//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_009a->IL0026: Incompatible stack heights: 2 vs 1
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
			case 2:
				return;
			case 1:
			{
				nint initialized = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
				if (initialized == 0)
				{
					obj2 = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj2 = 0;
					}
					break;
				}
				/*Error near IL_0074: Stack underflow*/((object[])/*Error near IL_0074: Stack underflow*/, initialized);
				IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_007b: Stack underflow*/, (uint)/*Error near IL_007b: Stack underflow*/, (nint)P_0, (uint*)(nint)P_1);
				_ = 2;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					_ = 2;
				}
				break;
			}
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00䐀(object P_0, InfoBarSeverity P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778441, new IntPtr(2737336189692L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00䔀(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00d7: Expected Obj, but got I
		//IL_00c2: Expected I, but got Obj
		//IL_00a3: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I4
		//IL_00e1->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00cc->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a8->IL00cc: Incompatible stack heights: 1 vs 0
		//IL_0087->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b6->IL0022: Incompatible stack heights: 1 vs 0
		//IL_0092->IL0026: Incompatible stack types: I4 vs Obj
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
				case 2:
					return;
				case 4:
					IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized = (int)P_0;
					obj2 = 1;
					if (IList_object._initialized != 0)
					{
						obj2 = 0;
					}
					continue;
				case 3:
					MarshalInspectable<object>.FromAbiArray((object)/*Error near IL_0097: Stack underflow*/);
					if (MarshalInspectable<object>.FromManaged((object)IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized, (byte)P_0 != 0) == (IntPtr)0)
					{
						break;
					}
					goto end_IL_0026;
				case 5:
					return;
				case 1:
					IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00c2: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00c2: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)this, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)IReadOnlyList_System_IDisposable._initialized);
					_ = 5;
					continue;
				}
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
				_ = 4;
				continue;
				end_IL_0026:
				break;
			}
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00䘀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18141, 1790778454, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778454, new IntPtr(2737336180332L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00䜀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18142, 1790778455, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778455, new IntPtr(2737336182412L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00䠀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00b3: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got I
		//IL_004f: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_007f: Expected I, but got Obj
		//IL_00d8->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0084->IL00b8: Incompatible stack heights: 1 vs 0
		//IL_00e3->IL0026: Incompatible stack heights: 3 vs 1
		//IL_006e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0098->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a3->IL0026: Incompatible stack heights: 2 vs 1
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
				default:
					return;
				case 3:
					IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
					_ = 0;
					if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
					{
						_ = 1;
					}
					continue;
				case 4:
					*((int, nint)*)(nint)/*Error near IL_0073: Stack underflow*/ = ((int)/*Error near IL_0073: Stack underflow*/, (nint)/*Error near IL_0073: Stack underflow*/);
					_ = IList_object.PatchAttribute;
					if (IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)P_0) == null)
					{
						_ = 2;
						if (IReadOnlyList_System_IDisposable._initialized != 0)
						{
							_ = 3;
						}
						continue;
					}
					return;
				case 1:
					break;
				case 0:
					return;
				case 2:
					MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
					_ = 0;
					if (IEnumerator_System_IDisposable.ReflectTransferableAttribute != null)
					{
						_ = 0;
					}
					continue;
				}
				break;
			}
			IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = P_0;
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00䤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778452, new IntPtr(2737336177212L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00䨀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00䬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778453, new IntPtr(2737336175132L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00䰀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0061: Expected Obj, but got I
		//IL_0083: Expected I, but got Obj
		//IL_0088: Expected I, but got Obj
		//IL_0088: Expected I, but got Obj
		//IL_0097: Expected Obj, but got I
		//IL_0066->IL0026: Incompatible stack heights: 5 vs 1
		//IL_009c->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0071->IL0026: Incompatible stack heights: 5 vs 1
		//IL_00a7->IL0026: Incompatible stack heights: 2 vs 1
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
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
				_ = IEnumerator_object.Initialized;
				IEnumerator_object.Do_Abi_MoveNext_2((nint)(int)IEnumerator_object.Init(), (byte*)1);
				_ = 1;
				if (IList_object.PatchAttribute != null)
				{
					_ = 2;
				}
				break;
			case 2:
				return;
			case 1:
			{
				object val = new IEnumeratorMethods<object>((IntPtr)/*Error near IL_0077: Stack underflow*/);
				IEnumerator_object._002Ecctor();
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_0088: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)val, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)val, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)this) ? 1 : 0));
				_ = 0;
				if (IReadOnlyList_object.ReflectLogicalAttribute == null)
				{
					_ = 0;
				}
				break;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<string> _FF00_FF00_FF00䴀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18148, 1790778450, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778450, new IntPtr(2737336175132L), 15);
		}
		return (IAsyncRelayCommand<string>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00一(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0077: Expected I, but got Obj
		//IL_0077: Expected I4, but got Obj
		//IL_00c1: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got I
		//IL_00b0: Expected I, but got Obj
		//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ba->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0096->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e0->IL0026: Incompatible stack types: I4 vs Obj
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
				ExceptionHelpers.GetHRForException((Exception)/*Error near IL_004d: Stack underflow*/);
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
				/*Error near IL_0054: Member reference must be method, but was: Field*/;
			default:
				((ValueTuple<int, nint>*)/*Error near IL_0077: Stack underflow*/)->_002Ector((int)this, (nint)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute);
				obj2 = 1;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					obj2 = 0;
				}
				break;
			case 4:
				return;
			case 3:
				IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute);
				_ = 2;
				break;
			case 2:
				IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = P_0;
				obj2 = 0;
				if (IReadOnlyList_object.ReflectLogicalAttribute != null)
				{
					obj2 = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00伀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778451, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00倀(ObservableCollection<ReferralEarningModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778448, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00儀(ObservableCollection<ReferralEarningModel> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00e3: Expected Obj, but got I
		//IL_00b3: Expected I, but got Obj
		//IL_0062: Expected I, but got Obj
		//IL_0071: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I
		//IL_00c7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0076->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a1->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00fc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0081->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00ac->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0107->IL0026: Incompatible stack types: I4 vs Obj
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
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized);
				_ = 2;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute != null)
				{
					_ = 2;
				}
				break;
			case 2:
				return;
			case 5:
				MarshalInspectable<object>.FromAbiArray((object)IList_object._initialized);
				_ = 3;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute != null)
				{
					_ = 3;
				}
				break;
			case 3:
				IReadOnlyList_System_IDisposable._initialized = (nint)P_0;
				obj2 = 4;
				if (IReadOnlyList_object._initialized != 0)
				{
					obj2 = 4;
				}
				break;
			case 1:
				if (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2(MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)/*Error near IL_00d7: Stack underflow*/), (INotifyPropertyChanged)IEnumerator_System_IDisposable._initialized, ref *(uint*)P_0))
				{
					obj2 = 0;
					if (IEnumerable_System_IDisposable.CombineAttribute != null)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00刀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778449, new IntPtr(2737336189692L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00匀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_006e: Expected I4, but got Obj
		//IL_0082: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I
		//IL_0087->IL0026: Incompatible stack heights: 2 vs 1
		//IL_005c->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0092->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0067->IL0026: Incompatible stack heights: 4 vs 1
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
			case 2:
				ExceptionHelpers.GetHRForException((Exception)P_0);
				_ = IEnumerator_object.Initialized;
				_ = 1;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
				{
					_ = 1;
				}
				break;
			case 1:
				((ValueTuple<int, nint>*)/*Error near IL_006e: Stack underflow*/)->_002Ector((int)this, (nint)P_0);
				IEnumerator_object.Do_Abi_get_Current_0((nint)/*Error near IL_0073: Stack underflow*/, (nint*)/*Error near IL_0073: Stack underflow*/);
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
	internal unsafe IRelayCommand<string> _FF00_FF00_FF00吀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18155, 1790778462, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778462, new IntPtr(2737336183452L), 15);
		}
		return (IRelayCommand<string>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IRelayCommand<string> _FF00_FF00_FF00唀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778463, new IntPtr(2737336177212L), 15))(null, 0, new IntPtr(0L));
		return (IRelayCommand<string>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00嘀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0078: Expected I, but got Obj
		//IL_0078: Expected I, but got Obj
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected I, but got Unknown
		//IL_0097->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00a2->IL0026: Incompatible stack heights: 4 vs 1
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
				IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)new ExceptionHelpers((Exception)/*Error near IL_0041: Stack underflow*/), ref *(object[]*)P_0);
				/*Error near IL_0048: Member reference must be method, but was: Field*/;
			case 2:
				return;
			}
			IEnumerator_object.Do_Abi_get_HasCurrent_1((nint)this, (byte*)(nint)IList_object.PatchAttribute);
			IEnumerator_object._002Ecctor();
			_ = 1;
			IEnumerator_object.DecorateAutomatableAttribute();
			_ = 0;
			if (IReadOnlyList_object._initialized == 0)
			{
				_ = 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00圀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18158, 1790778460, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778460, new IntPtr(2737336177212L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00堀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778461, new IntPtr(2737336185532L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00夀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00娀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778458, new IntPtr(2737336157452L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00嬀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00尀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778459, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00崀(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_004b: Expected I4, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_010d: Expected I, but got Obj
		//IL_011e: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got I4
		//IL_00ba: Expected I4, but got Obj
		//IL_00ba: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I4
		//IL_00a4->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0117->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0102->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00c8->IL0022: Incompatible stack heights: 1 vs 0
		//IL_00af->IL0026: Incompatible stack heights: 3 vs 1
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				case 5:
					ExceptionHelpers.GetHRForException((Exception)/*Error near IL_0055: Stack underflow*/);
					_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
					/*Error near IL_005c: Member reference must be method, but was: Field*/;
				default:
					IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)IList_object.PatchAttribute);
					_ = 0;
					if (IReadOnlyList_System_IDisposable._initialized == 0)
					{
						_ = 1;
					}
					continue;
				case 7:
					IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetAt_0((IntPtr)this, (uint)(int)IReadOnlyList_System_IDisposable.ReflectConnectedAttribute);
					obj = 6;
					break;
				case 4:
					return;
				case 6:
					return;
				case 3:
					MarshalInterface<INotifyPropertyChanged>.FromAbiArray(IEnumerator_System_IDisposable.ReflectTransferableAttribute);
					_ = 7;
					continue;
				case 1:
					MarshalInterface<INotifyPropertyChanged>.CopyManagedArray((INotifyPropertyChanged[])(object)this, (IntPtr)IEnumerable_System_IDisposable.CombineAttribute);
					obj2 = 2;
					continue;
				case 2:
					IEnumerable_object.ReflectSetAttribute = P_0;
					obj = 3;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00帀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778456, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00开(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778457, new IntPtr(2737336185532L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00怀(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_0075: Expected I, but got Obj
		//IL_0075: Expected I4, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_00e9->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0089->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f4->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0094->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00bf->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ca->IL0026: Incompatible stack types: I4 vs Obj
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
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (int)P_0;
				obj2 = 0;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				((ValueTuple<int, nint>*)/*Error near IL_0075: Stack underflow*/)->_002Ector((int)this, (nint)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute);
				obj2 = 2;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					obj2 = 4;
				}
				break;
			case 3:
				return;
			case 2:
				if (IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00a6: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)MarshalInspectable<object>.FromManaged((object)/*Error near IL_009a: Stack underflow*/, (byte)/*Error near IL_009a: Stack underflow*/ != 0), (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)IReadOnlyList_System_IDisposable._initialized, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(int)P_0))
				{
					return;
				}
				obj2 = 1;
				if (IReadOnlyList_object.ReflectLogicalAttribute == null)
				{
					obj2 = 1;
				}
				break;
			default:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00d5: Stack underflow*/, (INotifyPropertyChanged)this, ref *(uint*)IEnumerator_System_IDisposable._initialized);
				_ = 3;
				if (IEnumerable_System_IDisposable.CombineAttribute == null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00愀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778790, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00戀(ObservableCollection<ReferralCustomerModel> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00c4: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got I
		//IL_0065: Expected I, but got Obj
		//IL_004f: Expected I, but got Obj
		//IL_0058: Expected Obj, but got I4
		//IL_0095: Expected I4, but got Obj
		//IL_0095: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_00d8->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0079->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005d->IL0022: Incompatible stack heights: 1 vs 0
		//IL_009a->IL005d: Incompatible stack heights: 1 vs 0
		//IL_00e3->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0084->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ae->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00b9->IL0026: Incompatible stack heights: 2 vs 1
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
				case 3:
					break;
				case 1:
					return;
				case 2:
					IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
					obj2 = 0;
					if (IList_object._initialized != 0)
					{
						obj2 = 0;
					}
					continue;
				case 4:
					MarshalInspectable<object>.FromAbiArray((object)/*Error near IL_0089: Stack underflow*/);
					if (MarshalInspectable<object>.FromManaged((object)IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized, (byte)(int)P_0 != 0) != (IntPtr)0)
					{
						return;
					}
					_ = 1;
					if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
					{
						_ = 3;
					}
					continue;
				default:
					MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
					_ = 1;
					if (IEnumerator_System_IDisposable.ReflectTransferableAttribute == null)
					{
						_ = 1;
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
	internal unsafe void _FF00_FF00_FF00挀(ObservableCollection<ReferralCustomerModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778791, new IntPtr(2737336189692L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<ReferralRedeemOption> _FF00_FF00_FF00搀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<ReferralRedeemOption>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<ReferralRedeemOption> _FF00_FF00_FF00攀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778788, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<ReferralRedeemOption>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00昀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18173, 1790778789, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778789, new IntPtr(2737336185532L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00最(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18174, 1790778786, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778786, new IntPtr(2737336189692L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00栀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778787, new IntPtr(2737336157452L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00椀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778784, new IntPtr(2737336157452L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00樀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 18177, 1790778785, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778785, new IntPtr(2737336157452L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00欀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778798, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00氀(ObservableCollection<ReferralRedeemOption> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00cd: Expected Obj, but got I4
		//IL_0073: Expected I, but got Obj
		//IL_0073: Expected I4, but got Obj
		//IL_009d: Expected I, but got Obj
		//IL_0087->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b1->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0092->IL0026: Incompatible stack types: I4 vs Obj
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
				case 4:
					ExceptionHelpers.GetHRForException((Exception)/*Error near IL_0049: Stack underflow*/);
					_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute;
					/*Error near IL_0050: Member reference must be method, but was: Field*/;
				case 2:
					((ValueTuple<int, nint>*)/*Error near IL_0073: Stack underflow*/)->_002Ector((int)this, (nint)IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute);
					obj2 = 1;
					if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
					{
						obj2 = 1;
					}
					continue;
				case 3:
					IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute);
					_ = 0;
					if (IReadOnlyList_object._initialized == 0)
					{
						_ = 0;
					}
					continue;
				case 1:
					return;
				}
				break;
			}
			IReadOnlyList_object.ReflectLogicalAttribute = P_0;
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00洀(ObservableCollection<ReferralRedeemOption> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778799, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00渀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00漀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778796, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00瀀()
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
	internal unsafe object _FF00_FF00_FF00焀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778797, new IntPtr(2737336165772L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00爀()
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
	internal unsafe object _FF00_FF00_FF00猀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778794, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00琀()
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
	internal unsafe object _FF00_FF00_FF00甀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778795, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00瘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778792, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00眀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0061: Expected Obj, but got I
		//IL_0083: Expected I, but got Obj
		//IL_0088: Expected I, but got Obj
		//IL_0088: Expected I, but got Obj
		//IL_0097: Expected Obj, but got I
		//IL_0066->IL0026: Incompatible stack heights: 5 vs 1
		//IL_009c->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0071->IL0026: Incompatible stack heights: 5 vs 1
		//IL_00a7->IL0026: Incompatible stack heights: 2 vs 1
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
			case 1:
				_ = IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
				_ = IEnumerator_object.Initialized;
				IEnumerator_object.Do_Abi_MoveNext_2((nint)(int)IEnumerator_object.Init(), (byte*)1);
				_ = 0;
				if (IList_object.PatchAttribute == null)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			case 2:
			{
				object val = new IEnumeratorMethods<object>((IntPtr)/*Error near IL_0077: Stack underflow*/);
				IEnumerator_object._002Ecctor();
				IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_0088: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)val, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)val, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)(IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)this) ? 1 : 0));
				_ = 1;
				if (IReadOnlyList_object.ReflectLogicalAttribute != null)
				{
					_ = 1;
				}
				break;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00砀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778793, new IntPtr(2737336194892L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00礀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778806, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00稀()
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
	internal unsafe static object _FF00_FF00_FF00笀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778807, new IntPtr(2737336191772L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00簀(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0097: Expected I, but got Obj
		//IL_00be: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I
		//IL_00f2->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00ab->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00d2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b6->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00dd->IL0026: Incompatible stack types: I4 vs Obj
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
			case 3:
				return;
			case 4:
				/*Error near IL_006c: Member reference must be method, but was: Field*/;
			case 1:
				IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)IList_object.PatchAttribute);
				_ = 2;
				if (IReadOnlyList_System_IDisposable._initialized == 0)
				{
					_ = 5;
				}
				break;
			case 5:
				return;
			case 2:
				IReadOnlyList_System_IDisposable.ReflectConnectedAttribute = P_0;
				obj2 = 0;
				if (IReadOnlyList_object.ReflectLogicalAttribute != null)
				{
					obj2 = 1;
				}
				break;
			default:
				IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_00e8: Stack underflow*/, (INotifyPropertyChanged)this, ref *(uint*)IEnumerator_System_IDisposable._initialized);
				_ = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00紀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778804, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00縀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00缀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778805, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00耀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (uint)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00脀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778802, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00舀(Func<InfoBarDelegate> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778803, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00茀(Func<InfoBarDelegate> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_005b: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I
		//IL_0060->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0087->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ac->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00c7->IL0026: Incompatible stack heights: 3 vs 1
		//IL_006b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ef->IL0026: Incompatible stack types: I4 vs Obj
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
				obj = obj;
				obj2 = 4;
				if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute != null)
				{
					obj2 = 0;
				}
				break;
			case 2:
				obj = IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized;
				obj2 = 1;
				if (IList_object._initialized != 0)
				{
					obj2 = 1;
				}
				break;
			case 0:
				return;
			case 4:
				obj = (IEnumerableMethods<INotifyPropertyChanged, nint>)(object)MarshalInspectable<object>.FromAbiArray((object)P_0);
				_ = 5;
				break;
			case 5:
				_ = ref IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute;
				obj = CastExtensions.As<Segmented>(obj);
				_ = 3;
				break;
			case 3:
				if (obj == obj)
				{
					obj2 = 0;
					if (IReadOnlyList_object._initialized == 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00萀(Func<InfoBarDelegate> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778800, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00蔀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00bf: Expected Obj, but got I
		//IL_0066: Expected I, but got Obj
		//IL_0066: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_004b: Expected I, but got Obj
		//IL_00a4: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I
		//IL_00c9->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0055->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a9->IL0026: Incompatible stack heights: 2 vs 1
		//IL_007f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b4->IL0026: Incompatible stack heights: 2 vs 1
		//IL_008a->IL0026: Incompatible stack types: I4 vs Obj
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
			case 3:
				IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized = (nint)P_0;
				obj2 = 4;
				break;
			case 2:
				((Action<object[], nint>)IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)/*Error near IL_005a: Stack underflow*/, ref *(object[]*)/*Error near IL_005a: Stack underflow*/))((object[])IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized, (nint)P_0);
				if ((int)/*Error near IL_006b: Stack underflow*/ != 0)
				{
					return;
				}
				obj2 = 0;
				if (IList_object.PatchAttribute == null)
				{
					obj2 = 1;
				}
				break;
			case 4:
				MarshalInspectable<object>.FromManaged((object)this, (byte)IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized != 0);
				_ = 0;
				if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute != null)
				{
					_ = 0;
				}
				break;
			case 1:
				MarshalInterface<INotifyPropertyChanged>.FromManaged((INotifyPropertyChanged)IReadOnlyList_object._initialized);
				_ = 3;
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<ReferralEarningModel> _FF00_FF00_FF00蘀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<ReferralEarningModel>)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<ReferralEarningModel> _FF00_FF00_FF00蜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778801, new IntPtr(2737336190732L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<ReferralEarningModel>)/*Error near IL_0033: Stack underflow*/;
	}
}
