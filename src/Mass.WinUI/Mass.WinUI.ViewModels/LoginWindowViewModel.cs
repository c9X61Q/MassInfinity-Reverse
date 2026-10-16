using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mass.Domain.Entities.Mass;
using WinRT;
using WinRT.Mass_WinUIVtableClasses;

namespace Mass.WinUI.ViewModels;

[WinRTExposedType(typeof(Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
public class LoginWindowViewModel : ObservableObject
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInit_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public LoginWindowViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private nint _003C_003E7__wrap1;

		private TaskAwaiter<EntityMassVersion> _003C_003Eu__2;

		private static object? CheckStatelessArgument;

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
		internal static bool MatchDefinition()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? ReflectFilteredProgram()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00圀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778217, new IntPtr(2737336177212L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00堀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0f8d: Expected Obj, but got Ref
			//IL_0fa8: Expected Obj, but got Ref
			//IL_006e: Expected I4, but got Obj
			//IL_05fe: Expected Obj, but got Ref
			//IL_08c2: Expected Obj, but got Ref
			//IL_0077: Expected Obj, but got I4
			//IL_0874: Expected Obj, but got I4
			//IL_0939: Expected Obj, but got I4
			//IL_08de: Expected Obj, but got I4
			//IL_0ecb: Expected Obj, but got I4
			//IL_09b8: Expected Obj, but got Ref
			//IL_0e10: Expected Obj, but got I4
			//IL_08b9: Expected Obj, but got I4
			//IL_08f7: Expected Obj, but got I4
			//IL_091b: Expected Obj, but got I4
			//IL_0e64: Expected Obj, but got I4
			//IL_0831: Expected Obj, but got I4
			//IL_026c: Expected Obj, but got Ref
			//IL_0728: Expected Obj, but got Ref
			//IL_04e5: Expected Obj, but got Ref
			//IL_0ad6: Expected Obj, but got Ref
			//IL_02ea: Expected Obj, but got I4
			//IL_01fc: Expected Obj, but got I4
			//IL_06a0: Expected Obj, but got I4
			//IL_06bd: Expected Obj, but got I4
			//IL_0492: Expected Obj, but got I4
			//IL_051f: Expected Obj, but got I4
			//IL_0b24: Expected Obj, but got Ref
			//IL_0c13: Expected Obj, but got I4
			//IL_0c1d: Expected Obj, but got I4
			//IL_0aba: Expected Obj, but got I4
			//IL_0b97: Expected Obj, but got I4
			//IL_0b40: Expected Obj, but got I4
			//IL_0b7b: Expected Obj, but got Ref
			//IL_06f6: Expected Obj, but got I4
			//IL_046e: Expected Obj, but got I4
			//IL_0f99->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0fb4->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0fce->IL0019: Incompatible stack heights: 3 vs 1
			//IL_004a->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0fa4->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0fbf->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0608->IL0080: Incompatible stack types: I4 vs Ref
			//IL_0edd->IL0080: Incompatible stack heights: 0 vs 1
			//IL_085b->IL0080: Incompatible stack heights: 0 vs 1
			//IL_08ce->IL0080: Incompatible stack heights: 0 vs 1
			//IL_018c->IL0080: Incompatible stack heights: 0 vs 1
			//IL_0843->IL0080: Incompatible stack heights: 0 vs 1
			//IL_0ee8->IL0080: Incompatible stack types: I4 vs Ref
			//IL_0866->IL0080: Incompatible stack types: I4 vs Ref
			//IL_08d9->IL0080: Incompatible stack types: I4 vs Ref
			//IL_0197->IL0080: Incompatible stack types: I4 vs Ref
			//IL_084e->IL0080: Incompatible stack types: I4 vs Ref
			//IL_0080->IL0080: Incompatible stack types: Obj vs Ref
			//IL_09dc->IL0080: Incompatible stack types: I4 vs Ref
			//IL_0e0b->IL0080: Incompatible stack heights: 3 vs 1
			//IL_0934->IL0080: Incompatible stack types: I4 vs Ref
			//IL_096e->IL0080: Incompatible stack heights: 0 vs 1
			//IL_017f->IL0080: Incompatible stack heights: 2 vs 1
			//IL_0eb4->IL0080: Incompatible stack heights: 0 vs 1
			//IL_0944->IL0080: Incompatible stack heights: 3 vs 1
			//IL_08e9->IL0080: Incompatible stack heights: 3 vs 1
			//IL_09c4->IL0080: Incompatible stack heights: 0 vs 1
			//IL_0f09->IL0080: Incompatible stack heights: 0 vs 1
			//IL_0391->IL0080: Incompatible stack heights: 2 vs 1
			//IL_0ef8->IL0080: Incompatible stack heights: 4 vs 1
			//IL_0617->IL0080: Incompatible stack heights: 0 vs 1
			//IL_0888->IL0080: Incompatible stack heights: 0 vs 1
			//IL_0e1b->IL0080: Incompatible stack heights: 3 vs 1
			//IL_0e55->IL0080: Incompatible stack heights: 3 vs 1
			//IL_05ef->IL0080: Incompatible stack heights: 0 vs 1
			//IL_0e47->IL0080: Incompatible stack types: I4 vs Ref
			//IL_0926->IL0080: Incompatible stack heights: 3 vs 1
			//IL_0e69->IL007c: Incompatible stack heights: 3 vs 0
			//IL_0836->IL007c: Incompatible stack heights: 1 vs 0
			//IL_090b->IL0080: Incompatible stack heights: 0 vs 1
			//IL_03e3->IL0080: Incompatible stack heights: 0 vs 1
			//IL_0954->IL0080: Incompatible stack heights: 2 vs 1
			//IL_09a9->IL0080: Incompatible stack heights: 0 vs 1
			//IL_08ad->IL0080: Incompatible stack types: I4 vs Ref
			//IL_0e92->IL0080: Incompatible stack types: I4 vs Ref
			//IL_01aa->IL01ae: Incompatible stack heights: 1 vs 0
			//IL_0979->IL0080: Incompatible stack types: I4 vs Ref
			//IL_04ef->IL0405: Incompatible stack types: I4 vs Ref
			//IL_0401->IL0405: Incompatible stack types: I4 vs Ref
			//IL_0ebf->IL0080: Incompatible stack types: I4 vs Ref
			//IL_09cf->IL0080: Incompatible stack types: I4 vs Ref
			//IL_0f14->IL0080: Incompatible stack types: I4 vs Ref
			//IL_039c->IL0080: Incompatible stack heights: 2 vs 1
			//IL_0622->IL0080: Incompatible stack types: I4 vs Ref
			//IL_05df->IL0080: Incompatible stack types: I4 vs Ref
			//IL_0893->IL0080: Incompatible stack types: I4 vs Ref
			//IL_05fa->IL0080: Incompatible stack types: I4 vs Ref
			//IL_09ef->IL09f3: Incompatible stack heights: 1 vs 0
			//IL_0636->IL0080: Incompatible stack heights: 0 vs 1
			//IL_0e2f->IL0080: Incompatible stack heights: 0 vs 1
			//IL_0916->IL0080: Incompatible stack types: I4 vs Ref
			//IL_03ee->IL0080: Incompatible stack types: I4 vs Ref
			//IL_095f->IL0080: Incompatible stack heights: 2 vs 1
			//IL_09b4->IL0080: Incompatible stack types: I4 vs Ref
			//IL_0283->IL01ae: Incompatible stack heights: 1 vs 0
			//IL_073f->IL0665: Incompatible stack heights: 1 vs 0
			//IL_0661->IL0665: Incompatible stack heights: 1 vs 0
			//IL_0aed->IL09f3: Incompatible stack heights: 1 vs 0
			//IL_0641->IL0080: Incompatible stack types: I4 vs Ref
			//IL_0e3a->IL0080: Incompatible stack types: I4 vs Ref
			//IL_02da->IL01ae: Incompatible stack heights: 1 vs 0
			//IL_025d->IL01ae: Incompatible stack heights: 3 vs 0
			//IL_02f5->IL01ae: Incompatible stack heights: 3 vs 0
			//IL_0209->IL01ae: Incompatible stack heights: 2 vs 0
			//IL_01f7->IL01ae: Incompatible stack heights: 1 vs 0
			//IL_02c0->IL01ae: Incompatible stack heights: 1 vs 0
			//IL_0240->IL01ae: Incompatible stack heights: 2 vs 0
			//IL_070a->IL0665: Incompatible stack heights: 1 vs 0
			//IL_0776->IL0665: Incompatible stack heights: 3 vs 0
			//IL_06e5->IL0665: Incompatible stack heights: 4 vs 0
			//IL_074e->IL0665: Incompatible stack heights: 1 vs 0
			//IL_06ad->IL0665: Incompatible stack heights: 2 vs 0
			//IL_0768->IL0665: Incompatible stack heights: 1 vs 0
			//IL_06ca->IL0665: Incompatible stack heights: 2 vs 0
			//IL_049f->IL0405: Incompatible stack heights: 2 vs 1
			//IL_052c->IL0405: Incompatible stack heights: 2 vs 1
			//IL_0545->IL0405: Incompatible stack heights: 3 vs 1
			//IL_0452->IL0405: Incompatible stack heights: 0 vs 1
			//IL_04d6->IL0405: Incompatible stack heights: 3 vs 1
			//IL_0aff->IL09f3: Incompatible stack heights: 3 vs 0
			//IL_0bcb->IL09f3: Incompatible stack heights: 2 vs 0
			//IL_0aaa->IL09f3: Incompatible stack heights: 1 vs 0
			//IL_0a61->IL09f3: Incompatible stack heights: 2 vs 0
			//IL_0c28->IL09f3: Incompatible stack heights: 3 vs 0
			//IL_0ac7->IL09f3: Incompatible stack heights: 2 vs 0
			//IL_0ba4->IL09f3: Incompatible stack heights: 2 vs 0
			//IL_0b4b->IL09f3: Incompatible stack heights: 3 vs 0
			//IL_0a7e->IL09f3: Incompatible stack heights: 3 vs 0
			//IL_0b58->IL09f3: Incompatible stack heights: 2 vs 0
			//IL_02e5->IL01ae: Incompatible stack heights: 1 vs 0
			//IL_0268->IL01ae: Incompatible stack heights: 3 vs 0
			//IL_02b1->IL01ae: Incompatible stack heights: 1 vs 0
			//IL_0214->IL01ae: Incompatible stack heights: 2 vs 0
			//IL_02cb->IL01ae: Incompatible stack heights: 1 vs 0
			//IL_024b->IL01ae: Incompatible stack heights: 2 vs 0
			//IL_0715->IL0665: Incompatible stack heights: 1 vs 0
			//IL_0759->IL0665: Incompatible stack heights: 1 vs 0
			//IL_06b8->IL0665: Incompatible stack heights: 2 vs 0
			//IL_06d5->IL0665: Incompatible stack heights: 2 vs 0
			//IL_04aa->IL0405: Incompatible stack heights: 2 vs 1
			//IL_0537->IL0405: Incompatible stack heights: 2 vs 1
			//IL_04c4->IL0405: Incompatible stack types: I4 vs Ref
			//IL_045d->IL0405: Incompatible stack types: I4 vs Ref
			//IL_04e1->IL0405: Incompatible stack heights: 3 vs 1
			//IL_048d->IL0405: Incompatible stack types: I4 vs Ref
			//IL_0b0a->IL09f3: Incompatible stack heights: 3 vs 0
			//IL_0b3b->IL09f3: Incompatible stack heights: 1 vs 0
			//IL_09f3->IL09f3: Incompatible stack heights: 3 vs 0
			//IL_0ab5->IL09f3: Incompatible stack heights: 1 vs 0
			//IL_0a6c->IL09f3: Incompatible stack heights: 2 vs 0
			//IL_0ad2->IL09f3: Incompatible stack heights: 2 vs 0
			//IL_0be7->IL09f3: Incompatible stack heights: 1 vs 0
			//IL_0baf->IL09f3: Incompatible stack heights: 2 vs 0
			//IL_0a89->IL09f3: Incompatible stack heights: 3 vs 0
			//IL_0a9b->IL09f3: Incompatible stack heights: 1 vs 0
			//IL_0b92->IL09f3: Incompatible stack heights: 1 vs 0
			//IL_0665->IL0665: Incompatible stack heights: 1 vs 0
			//IL_0405->IL0405: Incompatible stack types: Obj vs Ref
			//IL_0c06->IL09f3: Incompatible stack heights: 1 vs 0
			//IL_0b77->IL09f3: Incompatible stack heights: 1 vs 0
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
					return;
				case 4:
					_ = -2;
					_ = 3;
					break;
				case 2:
				{
					ref _003CInit_003Ed__14 reference;
					switch ((int)obj)
					{
					default:
						obj = 44;
						goto IL_007c;
					case 5:
						if (8 == 0)
						{
							reference = ref *(_003CInit_003Ed__14*)9;
						}
						goto IL_0080;
					case 0:
						goto IL_05fa;
					case 6:
						goto IL_0836;
					case 2:
					case 3:
						goto IL_084e;
					case 4:
						goto IL_08be;
					case 1:
						goto IL_0ed0;
						IL_007c:
						reference = ref *(_003CInit_003Ed__14*)obj;
						goto IL_0080;
						IL_0080:
						while (true)
						{
							ref byte reference2;
							switch ((uint)Unsafe.AsPointer(ref reference))
							{
							case 45u:
								return;
							case 50u:
								return;
							case 2u:
							case 35u:
							case 36u:
								break;
							case 14u:
							case 15u:
								_ = ref obj;
								_ = 16;
								continue;
							case 28u:
								goto end_IL_0080;
							case 9u:
								if ((nint)obj != 5)
								{
									_ = 6;
									goto IL_01ae;
								}
								goto IL_0268;
							case 23u:
								if (28 == 0)
								{
									_ = 42;
								}
								continue;
							case 48u:
								if (7 == 0)
								{
									reference = ref *(_003CInit_003Ed__14*)2;
								}
								continue;
							case 13u:
								if ((nint)obj != 1)
								{
									reference2 = ref *(byte*)7;
									goto IL_0405;
								}
								goto IL_04e1;
							case 26u:
								if ((nint)obj == 1)
								{
									reference = ref *(_003CInit_003Ed__14*)10;
									continue;
								}
								goto case 17u;
							case 34u:
								obj = (object)/*Error near IL_05e3: Stack underflow*/;
								if (true)
								{
									reference = ref *(_003CInit_003Ed__14*)1;
								}
								continue;
							case 29u:
								goto IL_05fa;
							case 25u:
								if (33 == 0)
								{
									reference = ref *(_003CInit_003Ed__14*)18;
								}
								continue;
							case 44u:
								if (obj != null)
								{
									if (28 == 0)
									{
										reference = ref *(_003CInit_003Ed__14*)39;
									}
									continue;
								}
								goto case 25u;
							case 12u:
								if ((nint)obj != 6)
								{
									if (1 == 0)
									{
										_ = 8;
									}
									goto IL_0665;
								}
								goto IL_0724;
							default:
								_ = ref obj;
								obj = 4;
								goto IL_007c;
							case 32u:
								goto IL_0836;
							case 3u:
								goto IL_084e;
							case 16u:
								obj = obj;
								obj = 2;
								goto IL_007c;
							case 27u:
								goto IL_0879;
							case 6u:
								reference = ref this;
								if (26 == 0)
								{
									reference = ref *(_003CInit_003Ed__14*)30;
								}
								continue;
							case 33u:
								obj = 34;
								goto IL_007c;
							case 38u:
								goto IL_08be;
							case 19u:
								obj = 0;
								_ = 31;
								continue;
							case 39u:
								obj = obj;
								obj = 36;
								goto IL_007c;
							case 47u:
								if (22 != 0)
								{
									reference = ref *(_003CInit_003Ed__14*)12;
								}
								continue;
							case 40u:
								obj = -1;
								_ = 43;
								continue;
							case 10u:
								obj = (object)/*Error near IL_092a: Stack underflow*/;
								reference = ref *(_003CInit_003Ed__14*)46;
								continue;
							case 18u:
								obj = 4;
								_ = 23;
								continue;
							case 49u:
								_ = 1;
								if (32 != 0)
								{
									_ = 47;
								}
								continue;
							case 11u:
								if (25 == 0)
								{
									reference = ref *(_003CInit_003Ed__14*)32;
								}
								continue;
							case 1u:
								if (&obj != null)
								{
									if (0 == 0)
									{
										reference = ref *(_003CInit_003Ed__14*)null;
									}
									continue;
								}
								goto case 19u;
							case 21u:
								obj = (object)Unsafe.AsPointer(ref this);
								if (26 != 0)
								{
									reference = ref *(_003CInit_003Ed__14*)4;
								}
								continue;
							case 5u:
								goto IL_09cf;
							case 41u:
								if ((nint)obj != 2)
								{
									_ = 15;
									goto IL_09f3;
								}
								goto IL_0ad2;
							case 7u:
								_ = 0;
								_ = 3;
								continue;
							case 30u:
								obj = -1;
								_ = 14;
								continue;
							case 46u:
								if (&obj != null)
								{
									if (0 == 0)
									{
										reference = ref *(_003CInit_003Ed__14*)15;
									}
									continue;
								}
								goto case 18u;
							case 37u:
								reference = ref *(_003CInit_003Ed__14*)28;
								continue;
							case 31u:
								_ = 24;
								continue;
							case 42u:
								_ = ref obj;
								obj = 45;
								goto IL_007c;
							case 8u:
								reference = ref this;
								if (40 != 0)
								{
									reference = ref *(_003CInit_003Ed__14*)10;
								}
								continue;
							case 17u:
								if (35 == 0)
								{
									reference = ref *(_003CInit_003Ed__14*)37;
								}
								continue;
							case 20u:
								goto IL_0ebf;
							case 4u:
								goto IL_0ed0;
							case 24u:
								_ = ref obj;
								_ = 50;
								continue;
							case 22u:
								{
									obj = obj;
									if (34 != 0)
									{
										reference = ref *(_003CInit_003Ed__14*)35;
									}
									continue;
								}
								IL_0ad2:
								obj = (object)Unsafe.AsPointer(ref this);
								if (18 == 0)
								{
									_ = 3;
								}
								goto IL_09f3;
								IL_09f3:
								while (true)
								{
									switch ((int)/*Error near IL_0a4c: Stack underflow*/)
									{
									case 6:
										return;
									case 19:
										return;
									case 10:
										break;
									case 5:
										if (false)
										{
											_ = 0;
										}
										continue;
									case 14:
										_ = ref obj;
										if (1 == 0)
										{
											_ = 6;
										}
										continue;
									case 15:
										if ((nint)obj != 3)
										{
											_ = 11;
											continue;
										}
										goto case 16;
									case 4:
										_ = ref obj;
										if (10 == 0)
										{
											_ = 1;
										}
										continue;
									case 9:
										obj = 3;
										if (5 == 0)
										{
											_ = 5;
										}
										continue;
									case 8:
										goto IL_0ad2;
									default:
										_ = ref obj;
										if (19 == 0)
										{
											_ = 7;
										}
										continue;
									case 2:
										obj = (object)(&obj);
										if (17 != 0)
										{
											_ = 14;
										}
										continue;
									case 13:
										obj = -1;
										_ = 2;
										continue;
									case 18:
										_ = 13;
										continue;
									case 20:
										if (&obj == null)
										{
											if (7 == 0)
											{
												_ = 3;
											}
											continue;
										}
										goto case 2;
									case 16:
										obj = (object)Unsafe.AsPointer(ref this);
										if (true)
										{
											_ = 0;
										}
										continue;
									case 12:
										obj = -1;
										if (4 == 0)
										{
											_ = 4;
										}
										continue;
									case 1:
										_ = 12;
										continue;
									case 11:
										obj = (object)/*Error near IL_0bd0: Stack underflow*/;
										if (20 == 0)
										{
											_ = 2;
										}
										continue;
									case 17:
										if (&obj == null)
										{
											if (9 != 0)
											{
												_ = 9;
											}
											continue;
										}
										goto case 4;
									case 3:
										obj = 14;
										continue;
									case 7:
										obj = 2;
										_ = 3;
										continue;
									}
									break;
								}
								goto case 21u;
								IL_01ae:
								while (true)
								{
									switch ((int)/*Error near IL_01e3: Stack underflow*/)
									{
									case 11:
										return;
									case 6:
										obj = (object)/*Error near IL_01ed: Stack underflow*/;
										_ = 2;
										continue;
									case 5:
										obj = -1;
										if (0 == 0)
										{
											_ = 0;
										}
										continue;
									case 9:
										if (1 == 0)
										{
											_ = 1;
										}
										continue;
									case 1:
										_ = ref obj;
										if (11 != 0)
										{
											_ = 1;
										}
										continue;
									case 10:
										break;
									case 2:
										if (&obj != null)
										{
											_ = 4;
											continue;
										}
										goto case 3;
									case 8:
										if (5 == 0)
										{
											_ = 5;
										}
										continue;
									default:
										_ = ref obj;
										if (5 == 0)
										{
											_ = 7;
										}
										continue;
									case 3:
										obj = 5;
										_ = 9;
										continue;
									case 7:
										goto IL_0879;
									}
									break;
								}
								goto IL_0268;
								IL_0879:
								if (11 == 0)
								{
									reference = ref *(_003CInit_003Ed__14*)5;
								}
								continue;
								IL_0268:
								obj = (object)Unsafe.AsPointer(ref this);
								if (8 == 0)
								{
									_ = 1;
								}
								goto IL_01ae;
								IL_04e1:
								obj = (object)Unsafe.AsPointer(ref this);
								reference2 = ref *(byte*)9;
								goto IL_0405;
								IL_0405:
								while (true)
								{
									switch ((uint)Unsafe.AsPointer(ref reference2))
									{
									case 2u:
										return;
									case 7u:
										obj = (object)/*Error near IL_0446: Stack underflow*/;
										if (4 != 0)
										{
											reference2 = ref *(byte*)5;
										}
										continue;
									case 5u:
										if (&obj != null)
										{
											obj = 10;
											reference2 = ref *(byte*)obj;
											continue;
										}
										goto default;
									case 9u:
										reference2 = ref Unsafe.As<_003CInit_003Ed__14, byte>(ref this);
										if (1 == 0)
										{
											reference2 = ref *(byte*)null;
										}
										continue;
									default:
										obj = 1;
										if (4 != 0)
										{
											_ = 0;
										}
										continue;
									case 6u:
									case 10u:
										reference2 = ref *(byte*)(&obj);
										if (3 == 0)
										{
											reference2 = ref *(byte*)2;
										}
										continue;
									case 8u:
										_ = ref obj;
										if (false)
										{
											_ = 2;
										}
										continue;
									case 11u:
										break;
									case 1u:
										obj = -1;
										if (4 != 0)
										{
											_ = 6;
										}
										continue;
									case 4u:
										_ = 8;
										continue;
									case 3u:
										goto IL_0ebf;
									}
									break;
								}
								goto IL_04e1;
								IL_0724:
								obj = (object)Unsafe.AsPointer(ref this);
								if (0 == 0)
								{
									_ = 0;
								}
								goto IL_0665;
								IL_0ebf:
								obj = 48;
								goto IL_007c;
								IL_0665:
								while (true)
								{
									switch ((int)/*Error near IL_0696: Stack underflow*/)
									{
									case 7:
										return;
									case 6:
										obj = 6;
										if (1 == 0)
										{
											_ = 1;
										}
										continue;
									case 9:
										obj = -1;
										if (4 != 0)
										{
											_ = 4;
										}
										continue;
									case 3:
										_ = ref obj;
										_ = 7;
										continue;
									case 2:
										if (&obj == null)
										{
											obj = 6;
											continue;
										}
										goto case 4;
									default:
										if (9 != 0)
										{
											_ = 7;
										}
										continue;
									case 10:
										break;
									case 4:
										_ = ref obj;
										if (5 == 0)
										{
											_ = 2;
										}
										continue;
									case 8:
										obj = (object)/*Error near IL_075e: Stack underflow*/;
										_ = 2;
										continue;
									case 1:
										_ = 3;
										continue;
									case 5:
										goto IL_09cf;
									}
									break;
								}
								goto IL_0724;
								IL_09cf:
								reference = ref *(_003CInit_003Ed__14*)49;
								continue;
							}
							goto end_IL_004d;
							continue;
							end_IL_0080:
							break;
						}
						goto case 5;
						IL_0ed0:
						if (13 == 0)
						{
							reference = ref *(_003CInit_003Ed__14*)10;
						}
						goto IL_0080;
						IL_0836:
						if (3 == 0)
						{
							reference = ref *(_003CInit_003Ed__14*)12;
						}
						goto IL_0080;
						IL_08be:
						obj = (object)Unsafe.AsPointer(ref this);
						if (6 == 0)
						{
							reference = ref *(_003CInit_003Ed__14*)null;
						}
						goto IL_0080;
						IL_05fa:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(_003CInit_003Ed__14*)8;
						goto IL_0080;
						IL_084e:
						if (6 == 0)
						{
							reference = ref *(_003CInit_003Ed__14*)41;
						}
						goto IL_0080;
						end_IL_004d:
						break;
					}
					goto case 4;
				}
				default:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 != 0)
					{
						obj2 = 0;
					}
					break;
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				case 3:
					_ = 5;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00夀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778230, new IntPtr(2737336176172L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00娀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00嬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778231, new IntPtr(2737336169932L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? _FF00_FF00_FF00_FF00_FF00尀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object?)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00崀(object? P_0)
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

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInitialize_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public LoginWindowViewModel _003C_003E4__this;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private static object? CheckAutomatedTemplate;

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
		internal static bool ReflectPassiveAuditor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? ReflectExternalDecider()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00㼀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778228, new IntPtr(2737336151212L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00䀀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_005b: Expected Obj, but got Ref
			//IL_006a: Expected Obj, but got Ref
			//IL_01b6: Expected Obj, but got Ref
			//IL_018c: Expected Obj, but got Ref
			//IL_01a8: Expected Obj, but got Ref
			//IL_0212: Expected Obj, but got Ref
			//IL_01d2: Expected Obj, but got I4
			//IL_01dc: Expected Obj, but got I4
			//IL_015d: Expected Obj, but got I4
			//IL_01e6: Expected Obj, but got I4
			//IL_02b9: Expected Obj, but got I4
			//IL_02ff: Expected Obj, but got I4
			//IL_004c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0084->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0065->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0074->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0057->IL0019: Incompatible stack heights: 2 vs 1
			//IL_008f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00ae->IL00b2: Incompatible stack heights: 1 vs 0
			//IL_01cd->IL00b2: Incompatible stack heights: 1 vs 0
			//IL_02f0->IL00b2: Incompatible stack heights: 1 vs 0
			//IL_0321->IL00b2: Incompatible stack heights: 2 vs 0
			//IL_0314->IL00b2: Incompatible stack heights: 1 vs 0
			//IL_01b2->IL00b2: Incompatible stack heights: 1 vs 0
			//IL_022e->IL00b2: Incompatible stack heights: 3 vs 0
			//IL_021c->IL00b2: Incompatible stack heights: 1 vs 0
			//IL_016a->IL00b2: Incompatible stack heights: 2 vs 0
			//IL_0145->IL00b2: Incompatible stack heights: 3 vs 0
			//IL_01f1->IL00b2: Incompatible stack heights: 3 vs 0
			//IL_02c6->IL00b2: Incompatible stack heights: 2 vs 0
			//IL_0270->IL00b2: Incompatible stack heights: 2 vs 0
			//IL_02a2->IL00b2: Incompatible stack heights: 1 vs 0
			//IL_0304->IL00ae: Incompatible stack heights: 3 vs 2
			//IL_0263->IL00b2: Incompatible stack heights: 3 vs 0
			//IL_01a3->IL00b2: Incompatible stack heights: 1 vs 0
			//IL_0239->IL00b2: Incompatible stack heights: 3 vs 0
			//IL_00b2->IL00b2: Incompatible stack heights: 3 vs 0
			//IL_0175->IL00b2: Incompatible stack heights: 2 vs 0
			//IL_0158->IL00b2: Incompatible stack heights: 1 vs 0
			//IL_02d1->IL00b2: Incompatible stack heights: 2 vs 0
			//IL_02b4->IL00b2: Incompatible stack heights: 1 vs 0
			//IL_0340->IL00b2: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					if (0 == 0)
					{
						_ = 2;
					}
					continue;
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 5;
					continue;
				case 2:
					return;
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 3;
					continue;
				case 1:
					break;
				case 5:
					{
						if (obj == null)
						{
							if (25 != 0)
							{
								_ = 19;
							}
							goto IL_00b2;
						}
						goto IL_02d1;
					}
					IL_00b2:
					while (true)
					{
						switch ((int)/*Error near IL_0123: Stack underflow*/)
						{
						case 8:
							return;
						case 24:
							return;
						case 6:
						case 18:
							break;
						case 12:
							_ = 7;
							continue;
						case 13:
							if (obj != null)
							{
								_ = 4;
								continue;
							}
							goto case 20;
						case 11:
							obj = 1;
							if (12 == 0)
							{
								_ = 12;
							}
							continue;
						case 1:
						case 25:
							obj = (object)Unsafe.AsPointer(ref this);
							if (19 != 0)
							{
								_ = 5;
							}
							continue;
						case 3:
							obj = (object)(&obj);
							_ = 6;
							continue;
						case 14:
							goto end_IL_00b2;
						case 10:
							obj = 0;
							obj = 22;
							continue;
						case 15:
							obj = -1;
							_ = 3;
							continue;
						case 5:
						case 9:
							obj = (object)(&obj);
							_ = 18;
							continue;
						case 7:
							_ = ref obj;
							if (24 != 0)
							{
								_ = 16;
							}
							continue;
						case 22:
							_ = 21;
							continue;
						case 19:
							_ = 15;
							continue;
						case 20:
							obj = obj;
							_ = 26;
							continue;
						case 26:
							if (&obj == null)
							{
								_ = 10;
								continue;
							}
							goto case 3;
						case 17:
							obj = -1;
							if (9 == 0)
							{
								_ = 0;
							}
							continue;
						case 23:
							goto IL_02d1;
						case 21:
							_ = ref obj;
							obj = 8;
							continue;
						case 2:
						case 4:
							obj = obj;
							_ = 16;
							continue;
						default:
							_ = 17;
							continue;
						case 16:
							if (&obj != null)
							{
								if (5 != 0)
								{
									_ = 4;
								}
								continue;
							}
							goto case 11;
						}
						goto end_IL_0019;
						continue;
						end_IL_00b2:
						break;
					}
					goto IL_01b2;
					IL_02d1:
					if ((nint)obj != 1)
					{
						if (13 == 0)
						{
							_ = 0;
						}
						goto IL_00b2;
					}
					goto IL_01b2;
					IL_01b2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						_ = 0;
					}
					goto IL_00b2;
					end_IL_0019:
					break;
				}
				_ = -2;
				if (false)
				{
					_ = 0;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00䄀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778229, new IntPtr(2737336164732L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00䈀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00䌀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778226, new IntPtr(2737336157452L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00䐀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778227, new IntPtr(2737336161612L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? _FF00_FF00_FF00_FF00_FF00䔀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object?)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00䘀(object? P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00䜀(object? P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778224, new IntPtr(2737336155372L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSecurity_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string method;

		public LoginWindowViewModel _003C_003E4__this;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private static object? CheckOperationalList;

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
		internal static bool CheckVirtualRecord()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? DecorateIdentifiableContext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00㠀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778225, new IntPtr(2737336179292L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00㤀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0a75: Expected Obj, but got Ref
			//IL_0a90: Expected Obj, but got Ref
			//IL_0053: Expected I4, but got Obj
			//IL_085b: Expected Obj, but got Ref
			//IL_063b: Expected Obj, but got I4
			//IL_0655: Expected Obj, but got I4
			//IL_03fe: Expected Obj, but got Ref
			//IL_08d9: Expected Obj, but got Ref
			//IL_08e2: Expected Obj, but got I4
			//IL_088b: Expected Obj, but got I4
			//IL_02ca: Expected Obj, but got Ref
			//IL_020f: Expected Obj, but got I4
			//IL_0773: Expected Obj, but got Ref
			//IL_0476: Expected Obj, but got Ref
			//IL_0367: Expected Obj, but got I4
			//IL_0305: Expected Obj, but got I4
			//IL_06db: Expected Obj, but got I4
			//IL_070d: Expected Obj, but got I4
			//IL_04f8: Expected Obj, but got I4
			//IL_0522: Expected Obj, but got I4
			//IL_0ac5->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0ab4->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0a81->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0a9c->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0ad0->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0a8c->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0aa7->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0865->IL0061: Incompatible stack types: I4 vs Ref
			//IL_05d2->IL0061: Incompatible stack types: I4 vs Ref
			//IL_01a4->IL0061: Incompatible stack types: I4 vs Ref
			//IL_0959->IL0061: Incompatible stack heights: 0 vs 1
			//IL_005d->IL0061: Incompatible stack types: I4 vs Ref
			//IL_0964->IL0061: Incompatible stack types: I4 vs Ref
			//IL_01e1->IL0061: Incompatible stack heights: 3 vs 1
			//IL_0650->IL0061: Incompatible stack heights: 2 vs 1
			//IL_041a->IL0061: Incompatible stack heights: 0 vs 1
			//IL_0199->IL0061: Incompatible stack types: I4 vs Ref
			//IL_014b->IL0061: Incompatible stack heights: 2 vs 1
			//IL_0165->IL0061: Incompatible stack heights: 0 vs 1
			//IL_0660->IL0061: Incompatible stack heights: 3 vs 1
			//IL_05dd->IL0061: Incompatible stack types: I4 vs Ref
			//IL_05ef->IL0061: Incompatible stack types: Obj vs Ref
			//IL_0930->IL0061: Incompatible stack types: Obj vs Ref
			//IL_0875->IL0061: Incompatible stack types: I4 vs Ref
			//IL_0980->IL0061: Incompatible stack types: I4 vs Ref
			//IL_0408->IL0061: Incompatible stack types: I4 vs Ref
			//IL_0974->IL0061: Incompatible stack heights: 2 vs 1
			//IL_08e7->IL005d: Incompatible stack heights: 0 vs 1
			//IL_0898->IL0061: Incompatible stack heights: 2 vs 1
			//IL_013b->IL0061: Incompatible stack heights: 2 vs 1
			//IL_08b3->IL0061: Incompatible stack heights: 3 vs 1
			//IL_01c4->IL0061: Incompatible stack heights: 0 vs 1
			//IL_01ec->IL0061: Incompatible stack heights: 3 vs 1
			//IL_0061->IL0061: Incompatible stack heights: 2 vs 1
			//IL_01b5->IL0061: Incompatible stack types: I4 vs Ref
			//IL_0241->IL0245: Incompatible stack heights: 1 vs 0
			//IL_0425->IL0061: Incompatible stack types: I4 vs Ref
			//IL_0156->IL0061: Incompatible stack heights: 2 vs 1
			//IL_0170->IL0061: Incompatible stack types: I4 vs Ref
			//IL_022e->IL0061: Incompatible stack types: I4 vs Ref
			//IL_09e6->IL0061: Incompatible stack heights: 2 vs 1
			//IL_05fa->IL0061: Incompatible stack types: I4 vs Ref
			//IL_0214->IL005d: Incompatible stack heights: 0 vs 1
			//IL_093b->IL0061: Incompatible stack types: I4 vs Ref
			//IL_077d->IL06a0: Incompatible stack types: I4 vs Ref
			//IL_0691->IL06a0: Incompatible stack heights: 0 vs 1
			//IL_08c4->IL0061: Incompatible stack types: I4 vs Ref
			//IL_094c->IL0061: Incompatible stack types: I4 vs Ref
			//IL_08a3->IL0061: Incompatible stack heights: 2 vs 1
			//IL_01fe->IL0061: Incompatible stack types: I4 vs Ref
			//IL_0857->IL0061: Incompatible stack types: I4 vs Ref
			//IL_0903->IL0061: Incompatible stack types: I4 vs Ref
			//IL_0480->IL043c: Incompatible stack types: I4 vs Ref
			//IL_0438->IL043c: Incompatible stack types: I4 vs Ref
			//IL_062d->IL0061: Incompatible stack types: I4 vs Ref
			//IL_01cf->IL0061: Incompatible stack types: I4 vs Ref
			//IL_0886->IL0061: Incompatible stack types: I4 vs Ref
			//IL_02e1->IL0245: Incompatible stack heights: 1 vs 0
			//IL_069c->IL06a0: Incompatible stack types: I4 vs Ref
			//IL_029a->IL0245: Incompatible stack heights: 2 vs 0
			//IL_0348->IL0245: Incompatible stack heights: 1 vs 0
			//IL_0372->IL0245: Incompatible stack heights: 3 vs 0
			//IL_0312->IL0245: Incompatible stack heights: 2 vs 0
			//IL_028d->IL0245: Incompatible stack heights: 3 vs 0
			//IL_02c6->IL0245: Incompatible stack heights: 4 vs 0
			//IL_06fd->IL06a0: Incompatible stack types: Obj vs Ref
			//IL_0750->IL06a0: Incompatible stack heights: 3 vs 1
			//IL_0737->IL06a0: Incompatible stack heights: 3 vs 1
			//IL_06e6->IL06a0: Incompatible stack heights: 3 vs 1
			//IL_076f->IL06a0: Incompatible stack heights: 2 vs 1
			//IL_071a->IL06a0: Incompatible stack heights: 2 vs 1
			//IL_04a4->IL043c: Incompatible stack heights: 3 vs 1
			//IL_0545->IL043c: Incompatible stack heights: 3 vs 1
			//IL_0505->IL043c: Incompatible stack heights: 2 vs 1
			//IL_051d->IL043c: Incompatible stack heights: 2 vs 1
			//IL_04f3->IL043c: Incompatible stack heights: 3 vs 1
			//IL_052d->IL043c: Incompatible stack heights: 3 vs 1
			//IL_02b6->IL0245: Incompatible stack heights: 1 vs 0
			//IL_0353->IL0245: Incompatible stack heights: 1 vs 0
			//IL_031d->IL0245: Incompatible stack heights: 2 vs 0
			//IL_0708->IL06a0: Incompatible stack types: I4 vs Ref
			//IL_0742->IL06a0: Incompatible stack heights: 3 vs 1
			//IL_0762->IL06a0: Incompatible stack types: I4 vs Ref
			//IL_0725->IL06a0: Incompatible stack heights: 2 vs 1
			//IL_0797->IL06a0: Incompatible stack types: I4 vs Ref
			//IL_04e5->IL043c: Incompatible stack types: I4 vs Ref
			//IL_04af->IL043c: Incompatible stack heights: 3 vs 1
			//IL_0510->IL043c: Incompatible stack heights: 2 vs 1
			//IL_0492->IL043c: Incompatible stack types: I4 vs Ref
			//IL_09cc->IL0061: Incompatible stack heights: 0 vs 1
			//IL_0300->IL0245: Incompatible stack heights: 1 vs 0
			//IL_09d7->IL0061: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 5:
				{
					ref _003CSecurity_003Ed__10 reference;
					switch ((int)obj)
					{
					default:
						reference = ref *(_003CSecurity_003Ed__10*)40;
						goto IL_0061;
					case 2:
						reference = ref *(_003CSecurity_003Ed__10*)21;
						goto IL_0061;
					case 1:
						goto IL_05c7;
					case 0:
						goto IL_0857;
					case 3:
						goto IL_094c;
						IL_0061:
						while (true)
						{
							ref object reference3;
							ref _003CSecurity_003Ed__10 reference2;
							switch ((uint)Unsafe.AsPointer(ref reference))
							{
							case 39u:
								_ = 10;
								continue;
							case 9u:
								if (false)
								{
									_ = 0;
								}
								continue;
							case 10u:
								if (14 == 0)
								{
									reference = ref *(_003CSecurity_003Ed__10*)14;
								}
								continue;
							case 8u:
								reference = ref *(_003CSecurity_003Ed__10*)18;
								continue;
							case 44u:
								break;
							case 2u:
								if (obj != null)
								{
									reference = ref *(_003CSecurity_003Ed__10*)25;
									continue;
								}
								goto case 15u;
							case 46u:
								if (27 != 0)
								{
									reference = ref *(_003CSecurity_003Ed__10*)41;
								}
								continue;
							default:
								_ = ref obj;
								if (3 != 0)
								{
									_ = 3;
								}
								continue;
							case 34u:
								if (&obj != null)
								{
									reference = ref *(_003CSecurity_003Ed__10*)26;
									continue;
								}
								goto case 33u;
							case 17u:
							case 26u:
								if (&obj != null)
								{
									obj = 29;
									continue;
								}
								goto end_IL_003e;
							case 12u:
								reference = ref this;
								if (1 == 0)
								{
									reference = ref *(_003CSecurity_003Ed__10*)11;
								}
								continue;
							case 4u:
								if ((nint)obj != 3)
								{
									_ = 2;
									goto IL_0245;
								}
								goto IL_02c6;
							case 23u:
							case 29u:
								obj = (object)Unsafe.AsPointer(ref this);
								reference = ref *(_003CSecurity_003Ed__10*)28;
								continue;
							case 7u:
								obj = obj;
								if (47 == 0)
								{
									reference = ref *(_003CSecurity_003Ed__10*)1;
								}
								continue;
							case 42u:
								if ((nint)obj != 1)
								{
									reference3 = ref *(object*)5;
									goto IL_043c;
								}
								goto IL_0472;
							case 36u:
								goto IL_05c7;
							case 13u:
								reference = ref *(_003CSecurity_003Ed__10*)22;
								continue;
							case 16u:
								reference = ref *(_003CSecurity_003Ed__10*)obj;
								if (30 != 0)
								{
									reference = ref *(_003CSecurity_003Ed__10*)36;
								}
								continue;
							case 45u:
								if (obj == null)
								{
									reference = ref *(_003CSecurity_003Ed__10*)31;
									continue;
								}
								goto case 7u;
							case 1u:
								obj = 13;
								continue;
							case 6u:
								_ = 44;
								continue;
							case 11u:
								obj = -1;
								_ = 17;
								continue;
							case 21u:
								if ((nint)obj != 2)
								{
									if (true)
									{
										reference2 = ref *(_003CSecurity_003Ed__10*)null;
									}
									goto IL_06a0;
								}
								goto IL_076f;
							case 37u:
								if (obj != null)
								{
									reference = ref *(_003CSecurity_003Ed__10*)43;
									continue;
								}
								goto case 32u;
							case 5u:
								goto IL_0857;
							case 20u:
								obj = obj;
								reference = ref *(_003CSecurity_003Ed__10*)34;
								continue;
							case 47u:
								if (obj != null)
								{
									reference = ref *(_003CSecurity_003Ed__10*)30;
									continue;
								}
								goto case 37u;
							case 33u:
								obj = 0;
								if (1 == 0)
								{
									_ = 9;
								}
								continue;
							case 41u:
								_ = null;
								_ = null;
								_ = 38;
								continue;
							case 31u:
								if (obj == null)
								{
									reference = ref *(_003CSecurity_003Ed__10*)46;
									continue;
								}
								goto case 7u;
							case 28u:
								obj = (object)Unsafe.AsPointer(ref this);
								obj = 45;
								continue;
							case 40u:
								reference = ref this;
								if (8 == 0)
								{
									reference = ref *(_003CSecurity_003Ed__10*)20;
								}
								continue;
							case 3u:
								return;
							case 18u:
								reference = ref *(_003CSecurity_003Ed__10*)obj;
								if (1 == 0)
								{
									reference = ref *(_003CSecurity_003Ed__10*)1;
								}
								continue;
							case 32u:
								if (obj != null)
								{
									reference = ref *(_003CSecurity_003Ed__10*)16;
									continue;
								}
								goto case 6u;
							case 14u:
								goto IL_094c;
							case 27u:
								goto IL_0964;
							case 22u:
								reference = ref *(_003CSecurity_003Ed__10*)35;
								continue;
							case 30u:
							case 43u:
								if (obj == null)
								{
								}
								if (obj == null)
								{
								}
								if (2 == 0)
								{
									reference = ref *(_003CSecurity_003Ed__10*)2;
								}
								continue;
							case 15u:
							case 25u:
								_ = null;
								_ = 19;
								continue;
							case 19u:
							case 24u:
							case 35u:
							case 38u:
								goto end_IL_003e;
								IL_02c6:
								obj = (object)Unsafe.AsPointer(ref this);
								if (3 != 0)
								{
									_ = 3;
								}
								goto IL_0245;
								IL_0245:
								while (true)
								{
									switch ((int)/*Error near IL_027a: Stack underflow*/)
									{
									case 9:
										break;
									case 10:
										_ = 11;
										continue;
									default:
										_ = ref obj;
										_ = 9;
										continue;
									case 2:
										obj = (object)/*Error near IL_029f: Stack underflow*/;
										if (0 == 0)
										{
											_ = 7;
										}
										continue;
									case 11:
										_ = ref obj;
										_ = 8;
										continue;
									case 1:
										goto IL_02c6;
									case 7:
										if (&obj != null)
										{
											if (2 == 0)
											{
												_ = 4;
											}
											continue;
										}
										goto case 5;
									case 6:
										obj = -1;
										if (0 == 0)
										{
											_ = 0;
										}
										continue;
									case 8:
										return;
									case 3:
										if (6 == 0)
										{
											_ = 5;
										}
										continue;
									case 5:
										obj = 3;
										_ = 10;
										continue;
									}
									break;
								}
								goto case 8u;
								IL_076f:
								obj = (object)Unsafe.AsPointer(ref this);
								reference2 = ref *(_003CSecurity_003Ed__10*)10;
								goto IL_06a0;
								IL_06a0:
								while (true)
								{
									switch ((uint)Unsafe.AsPointer(ref reference2))
									{
									case 2u:
										break;
									case 6u:
										obj = -1;
										_ = 7;
										continue;
									case 1u:
									{
										object obj3 = obj;
										obj = obj;
										reference2 = ref *(_003CSecurity_003Ed__10*)obj3;
										if (8 != 0)
										{
											reference2 = ref *(_003CSecurity_003Ed__10*)5;
										}
										continue;
									}
									case 9u:
										obj = 2;
										if (3 != 0)
										{
											_ = 3;
										}
										continue;
									case 5u:
										_ = ref obj;
										if (3 == 0)
										{
											_ = 4;
										}
										continue;
									case 3u:
										_ = 5;
										continue;
									case 8u:
										if (&obj == null)
										{
											reference2 = ref *(_003CSecurity_003Ed__10*)9;
											continue;
										}
										goto case 7u;
									case 7u:
										_ = ref obj;
										_ = 2;
										continue;
									default:
										goto IL_076f;
									case 10u:
										reference2 = ref this;
										if (5 == 0)
										{
											reference2 = ref *(_003CSecurity_003Ed__10*)6;
										}
										continue;
									case 4u:
										return;
									}
									break;
								}
								goto case 39u;
								IL_0472:
								obj = (object)Unsafe.AsPointer(ref this);
								reference3 = ref *(object*)7;
								goto IL_043c;
								IL_043c:
								while (true)
								{
									switch ((uint)Unsafe.AsPointer(ref reference3))
									{
									default:
										return;
									case 4u:
										break;
									case 10u:
										if (&obj == null)
										{
											reference3 = ref *(object*)9;
											continue;
										}
										goto case 1u;
									case 3u:
										_ = ref obj;
										if (0 == 0)
										{
											_ = 0;
										}
										continue;
									case 0u:
										return;
									case 1u:
										reference3 = ref obj;
										if (0 == 0)
										{
											reference3 = ref *(object*)2;
										}
										continue;
									case 8u:
										_ = 3;
										continue;
									case 6u:
										obj = -1;
										if (1 == 0)
										{
											_ = 1;
										}
										continue;
									case 7u:
										_ = 6;
										continue;
									case 9u:
										obj = 1;
										_ = 8;
										continue;
									case 5u:
										obj = obj;
										_ = 10;
										continue;
									case 2u:
										goto IL_0964;
									}
									break;
								}
								goto IL_0472;
								IL_0964:
								_ = 6;
								continue;
							}
							break;
						}
						goto case 2;
						IL_094c:
						if (4 != 0)
						{
							reference = ref *(_003CSecurity_003Ed__10*)4;
						}
						goto IL_0061;
						IL_0857:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(_003CSecurity_003Ed__10*)12;
						goto IL_0061;
						IL_05c7:
						reference = ref *(_003CSecurity_003Ed__10*)42;
						goto IL_0061;
						end_IL_003e:
						break;
					}
					break;
				}
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						obj2 = 5;
					}
					continue;
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					if (3 != 0)
					{
						obj2 = 2;
					}
					continue;
				case 1:
					_ = 2;
					continue;
				case 2:
					return;
				}
				_ = -2;
				if (1 == 0)
				{
					_ = 1;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00㨀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778238, new IntPtr(2737336162652L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00㬀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object? _FF00_FF00_FF00_FF00_FF00㰀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778239, new IntPtr(2737336166812L), 15))(null, 0, new IntPtr(0L));
			return (object?)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object? _FF00_FF00_FF00_FF00_FF00㴀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object?)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00㸀(object? P_0)
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
					if (false)
					{
						_ = 0;
					}
					break;
				}
			}
		}
	}

	private nint _initialized;

	private readonly Task<bool> _initializeTask;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<string>? securityCommand;

	private static object? CheckScalableSorter;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	public string? InputUsername
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string?)_FF00_FF00䴀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00㜀(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	public string? InputPassword
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string?)_FF00_FF00㐀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00䔀(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	public string? InputInviteCode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string?)_FF00_FF00䀀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00㨀(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<string> SecurityCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00䬀();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LoginWindowViewModel()
	{
		//IL_0066: Expected I4, but got Obj
		//IL_0020->IL0029: Incompatible stack types: I4 vs Obj
		//IL_015c->IL0029: Incompatible stack types: I4 vs Obj
		//IL_016b->IL0029: Incompatible stack heights: 2 vs 1
		//IL_00e8->IL0029: Incompatible stack heights: 3 vs 1
		//IL_0128->IL0029: Incompatible stack heights: 2 vs 1
		//IL_0097->IL0029: Incompatible stack heights: 2 vs 1
		//IL_0143->IL0029: Incompatible stack heights: 0 vs 1
		//IL_0086->IL0029: Incompatible stack types: I4 vs Obj
		//IL_00fc->IL0029: Incompatible stack heights: 0 vs 1
		//IL_019c->IL0029: Incompatible stack types: I4 vs Obj
		//IL_0133->IL0029: Incompatible stack heights: 2 vs 1
		//IL_00a2->IL0029: Incompatible stack heights: 2 vs 1
		//IL_014e->IL0029: Incompatible stack types: I4 vs Obj
		//IL_0118->IL0029: Incompatible stack types: I4 vs Obj
		//IL_017f->IL0029: Incompatible stack heights: 0 vs 1
		//IL_0107->IL0029: Incompatible stack types: I4 vs Obj
		//IL_018a->IL0029: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		LoginWindowViewModel loginWindowViewModel = this;
		if (11 == 0)
		{
			loginWindowViewModel = (LoginWindowViewModel)7;
		}
		object obj = default;
		while (true)
		{
			switch ((int)loginWindowViewModel)
			{
			case 1:
				loginWindowViewModel = this;
				if (5 == 0)
				{
					loginWindowViewModel = (LoginWindowViewModel)7;
				}
				break;
			case 2:
				return;
			case 7:
				return;
			case 10:
				if (9 == 0)
				{
					_ = 2;
				}
				break;
			case 8:
				_ = 10;
				break;
			case 3:
				if (obj != null)
				{
					return;
				}
				if (true)
				{
					loginWindowViewModel = (LoginWindowViewModel)1;
				}
				break;
			case 12:
				if ((int)/*Error near IL_010e: Stack underflow*/ == 0)
				{
					return;
				}
				loginWindowViewModel = (LoginWindowViewModel)13;
				break;
			case 4:
			case 9:
				if (1 == 0)
				{
					_ = 12;
				}
				break;
			case 11:
				obj = (object)/*Error near IL_0137: Stack underflow*/;
				if (false)
				{
					loginWindowViewModel = (LoginWindowViewModel)0;
				}
				break;
			default:
				obj = (object)/*Error near IL_0152: Stack underflow*/;
				loginWindowViewModel = (LoginWindowViewModel)5;
				break;
			case 6:
				_ = 8;
				break;
			case 13:
				if (obj != null)
				{
					if (2 == 0)
					{
						loginWindowViewModel = (LoginWindowViewModel)1;
					}
					break;
				}
				goto case 3;
			case 5:
				if (obj != null)
				{
					loginWindowViewModel = (LoginWindowViewModel)4;
					break;
				}
				goto case 6;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CSecurity_003Ed__10))]
	private object Security(object method)
	{
		return _FF00_FF00㴀(method);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInitialize_003Ed__13))]
	private Task<bool> Initialize()
	{
		return _FF00_FF00䠀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInit_003Ed__14))]
	private Task<bool> Init()
	{
		return _FF00_FF00䘀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DirectPublisher()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LoginWindowViewModel? NewTransformer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _FF00_FF00_3300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778138, new IntPtr(2737335815772L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object? _FF00_FF00㐀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _FF00_FF00㔀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778139, new IntPtr(2737335818892L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00㘀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778136, new IntPtr(2737335803292L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00㜀(object? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0044->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0083->IL005e: Incompatible stack heights: 1 vs 0
		//IL_006e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0079->IL0019: Incompatible stack heights: 2 vs 1
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
				_ = 4;
				break;
			case 1:
				obj2 = this;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 0:
				return;
			case 4:
				if (1 == 0)
				{
					_ = 0;
				}
				break;
			case 3:
				if (P_0 != null)
				{
					return;
				}
				_ = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00㠀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778137, new IntPtr(2737335803292L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00㤀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00㨀(object? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_009c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0041->IL0058: Incompatible stack heights: 1 vs 0
		//IL_00a7->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0073->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0058->IL0019: Incompatible stack types: I4 vs Obj
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
			case 3:
				obj2 = this;
				if (P_0 == null)
				{
					if (2 == 0)
					{
						obj2 = 2;
					}
					break;
				}
				return;
			case 0:
				return;
			case 4:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				if (false)
				{
					_ = 4;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00㬀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778214, new IntPtr(2737335803292L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? _FF00_FF00㰀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778215, new IntPtr(2737335815772L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? _FF00_FF00㴀(object? P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17877, 1790778212, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778212, new IntPtr(2737335803292L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object? _FF00_FF00㸀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778213, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _FF00_FF00㼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778210, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object? _FF00_FF00䀀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object? _FF00_FF00䄀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778211, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object? _FF00_FF00䈀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object?)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object? _FF00_FF00䌀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778208, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00䐀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778209, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00䔀(object? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_009f: Expected Obj, but got I4
		//IL_00a4->IL0015: Incompatible stack heights: 1 vs 0
		//IL_0088->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006f->IL004b: Incompatible stack heights: 1 vs 0
		//IL_0093->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0079->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0065->IL0019: Incompatible stack types: I4 vs Obj
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
				case 2:
					return;
				case 4:
					return;
				case 5:
					obj2 = this;
					if (true)
					{
						obj2 = 1;
					}
					continue;
				case 3:
					if (P_0 != null)
					{
						_ = 2;
						continue;
					}
					goto case 5;
				case 1:
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
				}
				break;
			}
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<bool>? _FF00_FF00䘀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17886, 1790778222, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778222, new IntPtr(2737335815772L), 15);
		}
		return (Task<bool>?)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<bool>? _FF00_FF00䜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778223, new IntPtr(2737335818892L), 15))(null, 0, new IntPtr(0L));
		return (Task<bool>?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<bool>? _FF00_FF00䠀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17888, 1790778220, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778220, new IntPtr(2737335809532L), 15);
		}
		return (Task<bool>?)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<string?>? _FF00_FF00䨀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778221, new IntPtr(2737335818892L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<string?>?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<string?>? _FF00_FF00䬀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17891, 1790778218, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778218, new IntPtr(2737335818892L), 15);
		}
		return (IAsyncRelayCommand<string?>?)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<string?>? _FF00_FF00䰀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778219, new IntPtr(2737336180332L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<string?>?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object? _FF00_FF00䴀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _FF00_FF00一()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778216, new IntPtr(2737336155372L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}
}
