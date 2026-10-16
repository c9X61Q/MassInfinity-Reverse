using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using ABI.System.Collections.Generic;
using Mass.WinUI.ViewModels;
using WinRT;
using WinRT.Mass_WinUIGenericHelpers;
using WinRT.Mass_WinUIVtableClasses;

namespace System.Text.RegularExpressions.Generated;

[SkipLocalsInit]
[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.13.2707")]
internal sealed class _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0 : Regex
{
	private sealed class RunnerFactory : RegexRunnerFactory
	{
		private sealed class Runner : RegexRunner
		{
			private static object CheckOperationalModule;

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Scan(ReadOnlySpan<char> inputSpan)
			{
				_FF00_FF00_FF00_FF00_FF00_FF00_E900(inputSpan);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private byte TryFindNextPossibleStartingPosition(ReadOnlySpan<char> inputSpan)
			{
				return _FF00_FF00_FF00_FF00_FF00_FF00_E000(inputSpan);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private byte TryMatchAtCurrentPosition(ReadOnlySpan<char> inputSpan)
			{
				return _FF00_FF00_FF00_FF00_FF00_FF00_E500(inputSpan);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public unsafe Runner()
			{
				//IL_0011: Expected Obj, but got Ref
				((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
				if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
				{
				}
				ExceptionHelpers.GetHRForException((Exception)(object)this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool AssetHandler()
			{
				throw new Exception("Error, DNGuard Runtime library not loaded!");
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static Runner DeleteStruct()
			{
				throw new Exception("Error, DNGuard Runtime library not loaded!");
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FFFD(ReadOnlySpan<char> P_0)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775357, new IntPtr(2737323021596L), 15))(null, 0, new IntPtr(0L));
				return (byte)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_E000(ReadOnlySpan<char> P_0)
			{
				//IL_0011: Expected Obj, but got Ref
				//IL_001d: Expected Obj, but got I4
				//IL_006f: Expected I4, but got Obj
				//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d4: Expected I, but got Unknown
				//IL_010c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0114: Expected Obj, but got Unknown
				//IL_0114: Invalid comparison between Unknown and I
				//IL_0198: Expected Obj, but got I4
				//IL_0091: Expected Obj, but got I4
				//IL_0169: Invalid comparison between Unknown and I4
				//IL_0221: Expected I4, but got Obj
				//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f4: Invalid comparison between Obj and Unknown
				//IL_0079: Unknown result type (might be due to invalid IL or missing references)
				//IL_007c: Expected Obj, but got Unknown
				//IL_0128: Expected Obj, but got I
				//IL_01a2->IL0026: Incompatible stack types: I4 vs Obj
				//IL_009b->IL0026: Incompatible stack heights: 2 vs 1
				//IL_00df->IL0026: Incompatible stack types: I4 vs Obj
				//IL_0237->IL0026: Incompatible stack types: I4 vs Obj
				//IL_0153->IL0026: Incompatible stack heights: 3 vs 1
				//IL_00fe->IL0026: Incompatible stack types: I4 vs Obj
				//IL_0186->IL0026: Incompatible stack types: I4 vs Obj
				//IL_0086->IL0026: Incompatible stack heights: 2 vs 1
				//IL_01e9->IL0026: Incompatible stack heights: 2 vs 1
				//IL_01be->IL0026: Incompatible stack types: I4 vs Obj
				//IL_012d->IL0026: Incompatible stack types: I4 vs Obj
				//IL_0178->IL0026: Incompatible stack types: I4 vs Obj
				//IL_015e->IL0026: Incompatible stack heights: 3 vs 1
				//IL_0109->IL0026: Incompatible stack types: I4 vs Obj
				//IL_020d->IL0026: Incompatible stack types: I4 vs Obj
				//IL_01c9->IL0026: Incompatible stack types: I4 vs Obj
				//IL_0138->IL0026: Incompatible stack types: I4 vs Obj
				//IL_0218->IL0026: Incompatible stack types: I4 vs Obj
				((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
				if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
				{
				}
				object obj = 16;
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 12:
						return 1;
					case 5:
						_ = ref P_0;
						obj = ExceptionHelpers.GetHRForException((Exception)obj);
						_ = 4;
						break;
					case 6:
						obj += obj;
						obj2 = 3;
						break;
					case 10:
						return 0;
					default:
						/*Error near IL_00e9: Stack underflow*/((object[])(object)this, (nint)(&P_0));
						obj2 = 9;
						if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
						{
							obj2 = 10;
						}
						break;
					case 3:
						if ((nint)/*Error near IL_0119: Stack underflow*/ < (nint)MarshalInspectable<object>.FromManaged((object)(obj + 1), (byte)(&obj) != 0))
						{
							obj2 = 1;
							if (IReadOnlyList_System_IDisposable.ReflectConnectedAttribute == null)
							{
								obj2 = 1;
							}
							break;
						}
						goto default;
					case 13:
						_ = obj + obj;
						_ = 6;
						if (IEnumerator_System_IDisposable._initialized == 0)
						{
							_ = 12;
						}
						break;
					case 7:
					case 9:
						if ((int)/*Error near IL_016e: Stack underflow*/ < (IReadOnlyListMethods<INotifyPropertyChanged>.Abi_IndexOf_2((IntPtr)/*Error near IL_0167: Stack underflow*/, (INotifyPropertyChanged)obj, ref *(uint*)(&obj)) ? 1 : 0) - 1)
						{
							obj2 = 8;
							break;
						}
						goto default;
					case 16:
						obj = this;
						obj2 = 15;
						break;
					case 4:
						obj = 0;
						obj2 = 7;
						break;
					case 2:
						if ((nint)obj < 0)
						{
							obj2 = 0;
							if (IEnumerable_object._initialized == 0)
							{
								obj2 = 0;
							}
							break;
						}
						goto case 6;
					case 1:
						_ = ref obj;
						if (!IEnumerableMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(int)(*(ushort*)(int)IReadOnlyListMethods<INotifyPropertyChanged>.Abi_get_Size_1((IntPtr)(obj + 1)))))
						{
							obj++;
							_ = 9;
						}
						else
						{
							_ = 13;
						}
						break;
					case 15:
						if (Unsafe.As<object, UIntPtr>(ref obj) <= Unsafe.As<object, UIntPtr>(ref (object)(IEnumerableMethods<INotifyPropertyChanged>.Abi_First_0((IntPtr)(nint)(&P_0)) - 2)))
						{
							obj2 = 4;
							if (Mass_WinUI_Controls_AccountTable_AccountTable_obj1_BindingsWinRTTypeDetails.ReflectScheduledAttribute == null)
							{
								obj2 = 5;
							}
							break;
						}
						goto default;
					case 8:
					case 11:
						((AsyncTaskMethodBuilder*)IListMethods<object>.Abi_GetAt_0((IntPtr)(nint)(&obj), (uint)(int)obj))->Start(ref *(AccountViewModel._003CLogoutAccount_003Ed__23*)167);
						obj = (object)/*Error near IL_022d: Stack underflow*/;
						obj2 = 2;
						break;
					}
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_E100(ReadOnlySpan<char> P_0)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775354, new IntPtr(2737323013276L), 15))(null, 0, new IntPtr(0L));
				return (byte)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_E200()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775355, new IntPtr(2737323010156L), 15))(null, 0, new IntPtr(0L));
				return (object)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_E300()
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
			internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_E400()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775352, new IntPtr(2737323012236L), 15))(null, 0, new IntPtr(0L));
				return (object)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_E500(ReadOnlySpan<char> P_0)
			{
				//IL_0011: Expected Obj, but got Ref
				//IL_001d: Expected Obj, but got I4
				//IL_0057: Expected I4, but got Obj
				//IL_013c: Expected I, but got Obj
				//IL_00d4: Expected I4, but got Obj
				//IL_00d4: Expected Obj, but got Ref
				//IL_00d6: Expected Obj, but got I
				//IL_00df: Expected Obj, but got I4
				//IL_006f: Expected Obj, but got I
				//IL_010e: Expected Obj, but got I
				//IL_0084: Unknown result type (might be due to invalid IL or missing references)
				//IL_0087: Expected Obj, but got Unknown
				//IL_0096: Expected Obj, but got I
				//IL_01a9: Expected Obj, but got I4
				//IL_017d: Expected Obj, but got I
				//IL_0150->IL0026: Incompatible stack heights: 5 vs 1
				//IL_0074->IL0026: Incompatible stack types: I4 vs Obj
				//IL_0113->IL0026: Incompatible stack types: I4 vs Obj
				//IL_00c0->IL0026: Incompatible stack heights: 3 vs 1
				//IL_015b->IL0026: Incompatible stack heights: 5 vs 1
				//IL_009b->IL0026: Incompatible stack heights: 2 vs 1
				//IL_01ae->IL0022: Incompatible stack heights: 1 vs 0
				//IL_007f->IL0026: Incompatible stack types: I4 vs Obj
				//IL_011e->IL0026: Incompatible stack types: I4 vs Obj
				//IL_00fb->IL0026: Incompatible stack types: I4 vs Obj
				//IL_00cb->IL0026: Incompatible stack heights: 3 vs 1
				//IL_0182->IL0026: Incompatible stack types: I4 vs Obj
				//IL_00a6->IL0026: Incompatible stack heights: 2 vs 1
				//IL_018d->IL0026: Incompatible stack types: I4 vs Obj
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
							obj = obj;
							obj2 = 2;
							if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute != null)
							{
								obj2 = 2;
							}
							continue;
						case 6:
						case 7:
							return 0;
						case 10:
							return 1;
						case 8:
							_ = 0;
							if (IEnumerator_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
							{
								_ = 0;
							}
							continue;
						case 2:
							obj = (nint)MarshalInspectable<object>.FromManaged((object)(&P_0), (byte)(int)obj != 0);
							obj = 5;
							break;
						case 5:
							if ((IEnumeratorMethods<object>.Abi_get_HasCurrent_1((IntPtr)(nint)(&obj)) ? 1u : 0u) < 2u)
							{
								obj2 = 6;
								continue;
							}
							goto case 9;
						case 4:
							obj = this;
							obj2 = 0;
							if (IReadOnlyList_object.ReflectLogicalAttribute == null)
							{
								obj2 = 3;
							}
							continue;
						default:
							_ = 0;
							MarshalInterface<INotifyPropertyChanged>.FromAbi((IntPtr)obj);
							_ = 6;
							if (IEnumerable_System_IDisposable._initialized != 0)
							{
								_ = 10;
							}
							continue;
						case 9:
							if (*(ushort*)(int)IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)/*Error near IL_0163: Stack underflow*/, (uint)(&obj), ref *(INotifyPropertyChanged[]*)null) == 167)
							{
								obj2 = 1;
								if (IEnumerable_object.ReflectSetAttribute != null)
								{
									obj2 = 1;
								}
								continue;
							}
							goto case 6;
						case 1:
							_ = ref obj;
							if (IEnumerableMethods<INotifyPropertyChanged>.Abi_First_0((IntPtr)(int)(*(ushort*)(IEnumerableMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)1) ? 1 : 0))) != null)
							{
								obj += 2;
								_ = 8;
								if (IEnumerable_System_ComponentModel_INotifyPropertyChanged.ReflectConfigurableAttribute == null)
								{
									_ = 2;
								}
								continue;
							}
							obj = 7;
							break;
						}
						break;
					}
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_E600()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775353, new IntPtr(2737323026796L), 15))(null, 0, new IntPtr(0L));
				return (byte)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_E700()
			{
				//IL_0011: Expected Obj, but got Ref
				((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
				if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
				{
				}
				return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_E800()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775302, new IntPtr(2737323035116L), 15))(null, 0, new IntPtr(0L));
				return (byte)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_E900(ReadOnlySpan<char> P_0)
			{
				//IL_0011: Expected Obj, but got Ref
				//IL_001d: Expected Obj, but got I4
				//IL_0057: Expected I4, but got Obj
				//IL_0113: Expected I, but got VT
				//IL_0113: Expected I4, but got Obj
				//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fc: Expected Obj, but got I
				//IL_00c3: Expected I, but got VT
				//IL_00c3: Expected I, but got Obj
				//IL_0065: Expected I, but got Obj
				//IL_0065: Invalid comparison between Unknown and I4
				//IL_00d7: Expected Obj, but got I
				//IL_0147->IL0026: Incompatible stack heights: 2 vs 1
				//IL_0101->IL0026: Incompatible stack heights: 3 vs 1
				//IL_00bc->IL0026: Incompatible stack types: I4 vs Obj
				//IL_012c->IL0026: Incompatible stack types: I4 vs Obj
				//IL_010c->IL0026: Incompatible stack heights: 3 vs 1
				//IL_00dc->IL0026: Incompatible stack types: I4 vs Obj
				//IL_0074->IL0026: Incompatible stack types: I4 vs Obj
				//IL_0137->IL0026: Incompatible stack types: I4 vs Obj
				//IL_00e7->IL0026: Incompatible stack types: I4 vs Obj
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
					case 9:
						if ((int)/*Error near IL_006a: Stack underflow*/ == (int)IEnumeratorMethods<object>.Abi_GetMany_3((IntPtr)this, ref *(object[]*)(&P_0)))
						{
							obj2 = 7;
							continue;
						}
						goto case 5;
					case 10:
						return;
					case 1:
						return;
					case 7:
						return;
					default:
						if (IList_object._initialized == 0)
						{
							obj2 = 4;
							continue;
						}
						break;
					case 4:
					case 6:
					case 8:
						if (IEnumerator_object.Do_Abi_get_Current_0((nint)this, (nint*)(nint)P_0) == 0)
						{
							obj2 = 9;
							if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
							{
								obj2 = 10;
							}
							continue;
						}
						goto case 2;
					case 5:
						_ = this + 1;
						_ = 0;
						if (IReadOnlyList_object.ReflectLogicalAttribute == null)
						{
							_ = 0;
						}
						continue;
					case 2:
						if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.Do_Abi_GetAt_0((nint)/*Error near IL_0113: Stack underflow*/, (uint)(int)this, (nint*)(nint)P_0) != 0)
						{
							obj2 = 1;
							if (IEnumerable_System_IDisposable._initialized == 0)
							{
								obj2 = 1;
							}
							continue;
						}
						goto case 9;
					case 3:
						break;
					}
					IReadOnlyListMethods<INotifyPropertyChanged>.Abi_GetMany_3((IntPtr)/*Error near IL_013d: Stack underflow*/, (uint)/*Error near IL_013d: Stack underflow*/, ref *(INotifyPropertyChanged[]*)this);
					_ = 8;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_EA00(ReadOnlySpan<char> P_0)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775303, new IntPtr(2737323013276L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override RegexRunner CreateInstance()
		{
			return (RegexRunner)_FF00_FF00_FF00_FF00_FF00_FF00_FFFD();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe RunnerFactory()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			ExceptionHelpers.GetHRForException((Exception)(object)this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775359, new IntPtr(2737323020556L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0011: Expected Obj, but got Ref
			((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return new _003CModule_003E();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775356, new IntPtr(2737323012236L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	internal static readonly _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0 Instance = new _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0();

	internal static object ReflectLiteralAttribute;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_0023: Expected Obj, but got I4
		//IL_0052: Expected I4, but got Obj
		//IL_007c: Expected I, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I
		//IL_00ed->IL0031: Incompatible stack heights: 4 vs 2
		//IL_0064->IL0031: Incompatible stack heights: 4 vs 2
		//IL_0076->IL0031: Incompatible stack heights: 4 vs 2
		//IL_0091->IL0031: Incompatible stack types: I4 vs Obj
		//IL_00ba->IL0031: Incompatible stack types: I4 vs Obj
		//IL_00d2->IL0031: Incompatible stack heights: 4 vs 2
		//IL_00f8->IL0031: Incompatible stack heights: 4 vs 2
		//IL_009c->IL0031: Incompatible stack types: I4 vs Obj
		//IL_00c5->IL0031: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		int num = ExceptionHelpers.GetHRForException((Exception)(object)this);
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				_ = 0;
				_ = 4;
				break;
			case 6:
				return;
			case 2:
				new IEnumerator_object();
				_ = 5;
				break;
			case 3:
				num = (int)IEnumerator_object.Do_Abi_GetMany_3((nint)/*Error near IL_007c: Stack underflow*/, (uint)/*Error near IL_007c: Stack underflow*/, (nint)num, (uint*)(nint)this);
				obj2 = 1;
				if (IEnumerator_System_ComponentModel_INotifyPropertyChanged.RunAttribute == null)
				{
					obj2 = 1;
				}
				break;
			case 4:
				num = (IReadOnlyListMethods<INotifyPropertyChanged, nint>.InitCcw((delegate* unmanaged[Stdcall]<IntPtr, uint, nint*, int>)/*Error near IL_00a6: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, uint*, int>)/*Error near IL_00a6: Stack underflow*/, (delegate* unmanaged[Stdcall]<IntPtr, nint, uint*, byte*, int>)num, (delegate* unmanaged[Stdcall]<IntPtr, uint, int, IntPtr, uint*, int>)IReadOnlyList_System_IDisposable._initialized) ? 1 : 0);
				obj2 = 0;
				if (IReadOnlyList_object.ReflectLogicalAttribute != null)
				{
					obj2 = 0;
				}
				break;
			case 5:
				_ = 1;
				_ = 6;
				break;
			default:
				_ = IEnumerator_System_IDisposable.ReflectTransferableAttribute;
				_ = 2;
				if (IEnumerable_object._initialized != 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckScalableAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0 CheckModularTransaction()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00혀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775344, new IntPtr(2737323026796L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00휀()
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
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775345, new IntPtr(2737323015356L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775358, new IntPtr(2737323034076L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}
}
