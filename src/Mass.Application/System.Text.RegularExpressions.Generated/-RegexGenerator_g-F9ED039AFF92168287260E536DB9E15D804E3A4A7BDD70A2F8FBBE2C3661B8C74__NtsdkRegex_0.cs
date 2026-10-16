using System.CodeDom.Compiler;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Text.RegularExpressions.Generated;

[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.13.2707")]
internal sealed class _003CRegexGenerator_g_003EF9ED039AFF92168287260E536DB9E15D804E3A4A7BDD70A2F8FBBE2C3661B8C74__NtsdkRegex_0 : Regex
{
	private sealed class RunnerFactory : RegexRunnerFactory
	{
		private sealed class Runner : RegexRunner
		{
			private static object CheckEditableDic;

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Scan(ReadOnlySpan<char> inputSpan)
			{
				_FF00_FF00_FF00_2800(inputSpan);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private byte TryFindNextPossibleStartingPosition(ReadOnlySpan<char> inputSpan)
			{
				return _FF00_FF00_FF00_2E00(inputSpan);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private byte TryMatchAtCurrentPosition(ReadOnlySpan<char> inputSpan)
			{
				return _FF00_FF00_FF00_2700(inputSpan);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Runner()
			{
				if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool PlanConfig()
			{
				throw new Exception("Error, DNGuard Runtime library not loaded!");
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static Runner DecorateSimpleDecorator()
			{
				throw new Exception("Error, DNGuard Runtime library not loaded!");
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private unsafe byte _FF00_FF00_FF00_2600(ReadOnlySpan<char> P_0)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778389, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
				return (byte)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private unsafe byte _FF00_FF00_FF00_2700(ReadOnlySpan<char> P_0)
			{
				//IL_0010: Expected Obj, but got I4
				//IL_0092: Expected I4, but got Obj
				//IL_0158: Expected Obj, but got I4
				//IL_0223: Expected Obj, but got I4
				//IL_0293: Unknown result type (might be due to invalid IL or missing references)
				//IL_0296: Expected Obj, but got Unknown
				//IL_01ea: Expected Obj, but got I4
				//IL_023c: Expected Obj, but got I4
				//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c3: Expected Obj, but got Unknown
				//IL_0112: Unknown result type (might be due to invalid IL or missing references)
				//IL_0115: Expected Obj, but got Unknown
				//IL_0239->IL0019: Incompatible stack heights: 2 vs 1
				//IL_0256->IL0019: Incompatible stack heights: 0 vs 1
				//IL_00fc->IL0019: Incompatible stack heights: 3 vs 1
				//IL_012f->IL0019: Incompatible stack heights: 0 vs 1
				//IL_020b->IL0019: Incompatible stack heights: 0 vs 1
				//IL_01fb->IL0019: Incompatible stack heights: 2 vs 1
				//IL_010d->IL0019: Incompatible stack heights: 2 vs 1
				//IL_02a0->IL0019: Incompatible stack types: I4 vs Obj
				//IL_01ef->IL0015: Incompatible stack heights: 1 vs 0
				//IL_0246->IL0019: Incompatible stack types: I4 vs Obj
				//IL_0170->IL0019: Incompatible stack heights: 0 vs 1
				//IL_00a8->IL0019: Incompatible stack heights: 5 vs 1
				//IL_014b->IL0019: Incompatible stack heights: 2 vs 1
				//IL_00b9->IL0019: Incompatible stack heights: 2 vs 1
				//IL_01be->IL0019: Incompatible stack types: I4 vs Obj
				//IL_0261->IL0019: Incompatible stack types: I4 vs Obj
				//IL_018f->IL0019: Incompatible stack heights: 0 vs 1
				//IL_013a->IL0019: Incompatible stack types: I4 vs Obj
				//IL_0216->IL0019: Incompatible stack types: I4 vs Obj
				//IL_00e3->IL0019: Incompatible stack heights: 0 vs 1
				//IL_02b4->IL0019: Incompatible stack heights: 0 vs 1
				//IL_0276->IL0019: Incompatible stack heights: 0 vs 1
				//IL_00cd->IL0019: Incompatible stack types: I4 vs Obj
				//IL_01ae->IL0019: Incompatible stack types: I4 vs Obj
				//IL_011f->IL0019: Incompatible stack types: I4 vs Obj
				//IL_017b->IL0019: Incompatible stack types: I4 vs Obj
				//IL_019a->IL0019: Incompatible stack types: I4 vs Obj
				//IL_00ee->IL0019: Incompatible stack types: I4 vs Obj
				//IL_02bf->IL0019: Incompatible stack types: I4 vs Obj
				//IL_0281->IL0019: Incompatible stack types: I4 vs Obj
				if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
				{
				}
				object obj = 8;
				while (true)
				{
					object obj2 = obj;
					while (true)
					{
						switch ((int)obj2)
						{
						case 26:
							_ = 0;
							_ = 17;
							continue;
						case 28:
							_ = ref P_0;
							obj = obj;
							_ = 25;
							continue;
						case 17:
							return 1;
						case 2:
							return 0;
						case 10:
						case 16:
							if (obj == null)
							{
								if (2 != 0)
								{
									obj2 = 19;
								}
								continue;
							}
							goto case 15;
						case 6:
							_ = 26;
							continue;
						case 13:
							_ = ref P_0;
							obj = obj;
							_ = 3;
							continue;
						case 23:
							return 0;
						case 24:
							obj++;
							obj2 = 28;
							continue;
						case 7:
							obj = obj;
							if (21 != 0)
							{
								obj2 = 11;
							}
							continue;
						case 27:
							_ = ref P_0;
							obj = obj;
							_ = 5;
							continue;
						case 3:
							obj = obj;
							obj = 16;
							break;
						case 25:
							obj = obj;
							if (9 != 0)
							{
								obj2 = 12;
							}
							continue;
						case 5:
							if (&obj == null)
							{
								if (14 == 0)
								{
									obj2 = 24;
								}
								continue;
							}
							goto case 23;
						case 18:
							if (obj == null)
							{
								obj2 = 2;
								continue;
							}
							obj += 6;
							obj2 = 13;
							continue;
						default:
							if ((int)/*Error near IL_01b4: Stack underflow*/ != 0)
							{
								obj2 = 9;
								continue;
							}
							goto case 4;
						case 20:
							_ = ref P_0;
							obj = obj;
							obj = 18;
							break;
						case 9:
							_ = 4;
							continue;
						case 8:
							obj = this;
							if (7 == 0)
							{
								obj2 = 3;
							}
							continue;
						case 11:
							obj = obj;
							obj = 10;
							break;
						case 1:
							_ = ref P_0;
							obj = obj;
							_ = 11;
							continue;
						case 21:
							obj = 0;
							obj2 = 20;
							continue;
						case 4:
							obj = obj;
							if (23 == 0)
							{
								obj2 = 27;
							}
							continue;
						case 22:
							return 0;
						case 14:
							obj += obj;
							if (1 == 0)
							{
								obj2 = 0;
							}
							continue;
						case 15:
							obj += 8;
							obj2 = 6;
							continue;
						case 12:
							if ((nint)obj >= 0)
							{
								if (14 != 0)
								{
									obj2 = 12;
								}
								continue;
							}
							goto case 22;
						}
						break;
					}
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected unsafe void _FF00_FF00_FF00_2800(ReadOnlySpan<char> P_0)
			{
				//IL_0010: Expected Obj, but got I4
				//IL_0042: Expected I4, but got Obj
				//IL_006a: Invalid comparison between Obj and Ref
				//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
				//IL_0053->IL0019: Incompatible stack heights: 2 vs 1
				//IL_009f->IL0096: Incompatible stack heights: 1 vs 0
				//IL_005b->IL0097: Incompatible stack heights: 1 vs 0
				//IL_00c6->IL0019: Incompatible stack heights: 3 vs 1
				//IL_0079->IL0019: Incompatible stack types: I4 vs Obj
				//IL_008b->IL0019: Incompatible stack heights: 0 vs 1
				//IL_0065->IL0019: Incompatible stack heights: 2 vs 1
				//IL_00b6->IL0019: Incompatible stack types: I4 vs Obj
				//IL_0096->IL0019: Incompatible stack types: I4 vs Obj
				if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
				{
				}
				object obj = 8;
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 1:
						_ = 6;
						continue;
					case 6:
					case 8:
						if ((int)P_0 == 0)
						{
							_ = 4;
							continue;
						}
						goto case 2;
					default:
						if (Unsafe.AreSame(ref *(byte*)this, ref *(byte*)(&P_0)))
						{
							obj2 = 3;
							continue;
						}
						break;
					case 5:
						if ((int)/*Error near IL_007f: Stack underflow*/ != 0)
						{
							if (true)
							{
								obj2 = 0;
							}
							continue;
						}
						goto case 6;
					case 3:
						return;
					case 4:
						return;
					case 2:
						obj2 = this;
						if ((int)P_0 != 0)
						{
							return;
						}
						if (false)
						{
							obj2 = 0;
						}
						continue;
					case 7:
						break;
					}
					_ = this + 1;
					_ = 5;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected unsafe void _FF00_FF00_FF00_2900(ReadOnlySpan<char> P_0)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778388, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static byte _FF00_FF00_FF00_2A00()
			{
				//IL_0009: Invalid comparison between Unknown and Obj
				if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
				{
				}
				return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static byte _FF00_FF00_FF00_2B00()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778395, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
				return (byte)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object _FF00_FF00_FF00Ⰰ()
			{
				if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
				{
				}
				return (object)/*Error near IL_0009: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static object _FF00_FF00_FF00ⴀ()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778394, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
				return (object)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private unsafe byte _FF00_FF00_FF00_2E00(ReadOnlySpan<char> P_0)
			{
				//IL_0010: Expected Obj, but got I4
				//IL_003e: Expected I4, but got Obj
				//IL_00d5: Invalid comparison between Obj and Ref
				//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
				//IL_0081->IL0019: Incompatible stack heights: 0 vs 1
				//IL_00f5->IL0019: Incompatible stack heights: 3 vs 1
				//IL_00e4->IL0019: Incompatible stack types: I4 vs Ref
				//IL_008c->IL0019: Incompatible stack types: I4 vs Ref
				//IL_00a1->IL0019: Incompatible stack heights: 2 vs 1
				//IL_0055->IL0019: Incompatible stack types: I4 vs Ref
				//IL_00cd->IL0019: Incompatible stack types: I4 vs Ref
				//IL_00ac->IL0019: Incompatible stack heights: 2 vs 1
				if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
				{
				}
				object obj = 1;
				ref ReadOnlySpan<char> reference = ref *(ReadOnlySpan<char>*)obj;
				while (true)
				{
					switch ((uint)Unsafe.AsPointer(ref reference))
					{
					case 2u:
						if ((nint)obj >= 0)
						{
							reference = ref *(ReadOnlySpan<char>*)6;
							break;
						}
						goto case 7u;
					case 1u:
						obj = this;
						if (false)
						{
							reference = ref *(ReadOnlySpan<char>*)null;
						}
						break;
					case 4u:
						return 0;
					case 5u:
						return 1;
					case 7u:
						_ = ref P_0;
						if (4 == 0)
						{
							_ = 4;
						}
						break;
					case 3u:
						reference = ref P_0;
						obj = obj;
						if (2 != 0)
						{
							reference = ref *(ReadOnlySpan<char>*)null;
						}
						break;
					default:
						if (Unsafe.IsAddressGreaterThan(ref *(byte*)obj, ref Unsafe.As<ReadOnlySpan<char>, byte>(ref Unsafe.SubtractByteOffset(ref P_0, 14))))
						{
							reference = ref *(ReadOnlySpan<char>*)7;
							break;
						}
						goto case 3u;
					case 6u:
						_ = obj + obj;
						_ = 5;
						break;
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override RegexRunner CreateInstance()
		{
			return (RegexRunner)_FF00_FF00_FF00_2200();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RunnerFactory()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected unsafe object _FF00_FF00_FF00_2100()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778391, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected object _FF00_FF00_FF00_2200()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected unsafe object _FF00_FF00_FF00_2300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778390, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	internal static readonly _003CRegexGenerator_g_003EF9ED039AFF92168287260E536DB9E15D804E3A4A7BDD70A2F8FBBE2C3661B8C74__NtsdkRegex_0 Instance = new _003CRegexGenerator_g_003EF9ED039AFF92168287260E536DB9E15D804E3A4A7BDD70A2F8FBBE2C3661B8C74__NtsdkRegex_0();

	internal static object TestEvent;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private _003CRegexGenerator_g_003EF9ED039AFF92168287260E536DB9E15D804E3A4A7BDD70A2F8FBBE2C3661B8C74__NtsdkRegex_0()
	{
		//IL_003d: Expected I4, but got Obj
		//IL_0013->IL001c: Incompatible stack types: I4 vs Obj
		//IL_0094->IL001c: Incompatible stack heights: 3 vs 2
		//IL_0083->IL001c: Incompatible stack heights: 3 vs 2
		//IL_00c7->IL001c: Incompatible stack heights: 1 vs 2
		//IL_0051->IL001c: Incompatible stack heights: 3 vs 2
		//IL_00b9->IL001c: Incompatible stack types: I4 vs Obj
		//IL_009f->IL001c: Incompatible stack heights: 3 vs 2
		//IL_00d2->IL001c: Incompatible stack heights: 1 vs 2
		//IL_005c->IL001c: Incompatible stack heights: 3 vs 2
		//IL_0076->IL001c: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_003CRegexGenerator_g_003EF9ED039AFF92168287260E536DB9E15D804E3A4A7BDD70A2F8FBBE2C3661B8C74__NtsdkRegex_0 obj = (_003CRegexGenerator_g_003EF9ED039AFF92168287260E536DB9E15D804E3A4A7BDD70A2F8FBBE2C3661B8C74__NtsdkRegex_0)3;
		while (true)
		{
			switch ((int)obj)
			{
			case 5:
				_ = 1;
				if (1 == 0)
				{
					_ = 1;
				}
				break;
			case 6:
				obj = this;
				if (true)
				{
					obj = (_003CRegexGenerator_g_003EF9ED039AFF92168287260E536DB9E15D804E3A4A7BDD70A2F8FBBE2C3661B8C74__NtsdkRegex_0)5;
				}
				break;
			case 3:
				_ = 2;
				break;
			case 1:
				return;
			case 2:
				_ = 16;
				if (4 == 0)
				{
					_ = 2;
				}
				break;
			default:
				obj = this;
				if (true)
				{
					obj = (_003CRegexGenerator_g_003EF9ED039AFF92168287260E536DB9E15D804E3A4A7BDD70A2F8FBBE2C3661B8C74__NtsdkRegex_0)6;
				}
				break;
			case 4:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool InsertWrapper()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static _003CRegexGenerator_g_003EF9ED039AFF92168287260E536DB9E15D804E3A4A7BDD70A2F8FBBE2C3661B8C74__NtsdkRegex_0 InterruptProcessor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00ᴀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778385, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00Ḁ()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00ἀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778384, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_2000()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}
}
