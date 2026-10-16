using System.CodeDom.Compiler;
using System.Reflection;
using System.Runtime.CompilerServices;

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
			public Runner()
			{
				if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
				{
				}
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
				//IL_0010: Expected Obj, but got I4
				//IL_0062: Expected I4, but got Obj
				//IL_0189: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00eb: Invalid comparison between Unknown and Ref
				//IL_015b: Expected Obj, but got I4
				//IL_012c: Invalid comparison between Obj and Ref
				//IL_01cc: Expected Obj, but got I4
				//IL_01a3: Invalid comparison between Obj and Ref
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_006f: Expected Obj, but got Unknown
				//IL_0165->IL0019: Incompatible stack types: I4 vs Obj
				//IL_008a->IL0019: Incompatible stack heights: 2 vs 1
				//IL_00c6->IL0019: Incompatible stack types: I4 vs Obj
				//IL_01d6->IL0019: Incompatible stack heights: 3 vs 1
				//IL_011a->IL0019: Incompatible stack heights: 2 vs 1
				//IL_00d9->IL0019: Incompatible stack heights: 2 vs 1
				//IL_0149->IL0019: Incompatible stack types: I4 vs Obj
				//IL_0079->IL0019: Incompatible stack heights: 2 vs 1
				//IL_019c->IL0019: Incompatible stack heights: 2 vs 1
				//IL_0179->IL0019: Incompatible stack heights: 0 vs 1
				//IL_00fc->IL0019: Incompatible stack heights: 0 vs 1
				//IL_013b->IL0019: Incompatible stack types: I4 vs Obj
				//IL_0125->IL0019: Incompatible stack heights: 2 vs 1
				//IL_00e4->IL0019: Incompatible stack heights: 2 vs 1
				//IL_01b4->IL0019: Incompatible stack heights: 0 vs 1
				//IL_0184->IL0019: Incompatible stack types: I4 vs Obj
				//IL_0107->IL0019: Incompatible stack types: I4 vs Obj
				//IL_01bf->IL0019: Incompatible stack types: I4 vs Obj
				if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
						obj = obj;
						_ = 4;
						break;
					case 6:
						obj += obj;
						obj2 = 3;
						break;
					case 10:
						return 0;
					default:
						_ = ref P_0;
						if (9 == 0)
						{
							_ = 10;
						}
						break;
					case 3:
						if (Unsafe.IsAddressLessThan(ref *(byte*)(obj + 1), ref *(byte*)(&obj)))
						{
							if (1 == 0)
							{
								obj2 = 1;
							}
							break;
						}
						goto default;
					case 13:
						_ = obj + obj;
						if (6 == 0)
						{
							_ = 12;
						}
						break;
					case 7:
					case 9:
						if (Unsafe.IsAddressLessThan(ref *(byte*)obj, ref Unsafe.As<object, byte>(ref Unsafe.SubtractByteOffset(ref obj, 1))))
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
							if (0 == 0)
							{
								obj2 = 0;
							}
							break;
						}
						goto case 6;
					case 1:
						_ = ref obj;
						if (*(ushort*)(nint)(obj + 1) == 0)
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
						if (!Unsafe.IsAddressGreaterThan(ref *(byte*)obj, ref Unsafe.As<ReadOnlySpan<char>, byte>(ref Unsafe.SubtractByteOffset(ref P_0, 2))))
						{
							if (4 == 0)
							{
								obj2 = 5;
							}
							break;
						}
						goto default;
					case 8:
					case 11:
						_ = ref obj;
						obj = 167;
						_ = 2;
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
			internal static object _FF00_FF00_FF00_FF00_FF00_FF00_E300()
			{
				if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
				{
				}
				return (object)/*Error near IL_0009: Stack underflow*/;
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
				//IL_0010: Expected Obj, but got I4
				//IL_004a: Expected I4, but got Obj
				//IL_00b6: Expected Obj, but got I4
				//IL_006f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0072: Expected Obj, but got Unknown
				//IL_0154: Expected Obj, but got I4
				//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
				//IL_010f->IL0019: Incompatible stack heights: 4 vs 1
				//IL_00bb->IL0015: Incompatible stack heights: 1 vs 0
				//IL_005f->IL0019: Incompatible stack heights: 0 vs 1
				//IL_00de->IL0019: Incompatible stack heights: 0 vs 1
				//IL_009b->IL0019: Incompatible stack heights: 2 vs 1
				//IL_0129->IL006a: Incompatible stack heights: 1 vs 0
				//IL_011a->IL0019: Incompatible stack heights: 4 vs 1
				//IL_0159->IL0015: Incompatible stack heights: 1 vs 0
				//IL_006a->IL0019: Incompatible stack types: I4 vs Ref
				//IL_00e9->IL0019: Incompatible stack types: I4 vs Ref
				//IL_00ce->IL0019: Incompatible stack types: I4 vs Ref
				//IL_00a6->IL0019: Incompatible stack heights: 2 vs 1
				//IL_0089->IL0019: Incompatible stack types: I4 vs Ref
				//IL_0140->IL0019: Incompatible stack types: I4 vs Ref
				if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
				{
				}
				object obj = 4;
				while (true)
				{
					ref object reference = ref *(object*)obj;
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 3u:
							obj = obj;
							if (2 != 0)
							{
								reference = ref *(object*)2;
							}
							continue;
						case 6u:
						case 7u:
							return 0;
						case 10u:
							return 1;
						case 8u:
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 2u:
							_ = ref P_0;
							obj = obj;
							obj = 5;
							break;
						case 5u:
							if ((nuint)(&obj) < (nuint)2u)
							{
								reference = ref *(object*)6;
								continue;
							}
							goto case 9u;
						case 4u:
							obj = this;
							if (0 == 0)
							{
								reference = ref *(object*)3;
							}
							continue;
						default:
							_ = 0;
							if (6 != 0)
							{
								_ = 10;
							}
							continue;
						case 9u:
							reference = ref obj;
							if (*(ushort*)null == 167)
							{
								if (true)
								{
									reference = ref *(object*)1;
								}
								continue;
							}
							goto case 6u;
						case 1u:
							reference = ref obj;
							if (*(ushort*)1 != 0)
							{
								obj += 2;
								if (8 == 0)
								{
									reference = ref *(object*)2;
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
			internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_E700()
			{
				//IL_0009: Invalid comparison between Unknown and Obj
				if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
				{
				}
				return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
				//IL_0010: Expected Obj, but got I4
				//IL_004a: Expected I4, but got Obj
				//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_0054: Invalid comparison between Obj and Ref
				//IL_00e3->IL004f: Incompatible stack heights: 1 vs 0
				//IL_0106->IL0019: Incompatible stack heights: 2 vs 1
				//IL_00d0->IL0019: Incompatible stack heights: 2 vs 1
				//IL_00a7->IL00db: Incompatible stack heights: 1 vs 0
				//IL_009f->IL0019: Incompatible stack types: I4 vs Obj
				//IL_00db->IL0019: Incompatible stack heights: 2 vs 1
				//IL_0063->IL0019: Incompatible stack types: I4 vs Obj
				//IL_00fa->IL0019: Incompatible stack types: I4 vs Obj
				//IL_00be->IL0019: Incompatible stack types: I4 vs Obj
				if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
				{
				}
				object obj = 6;
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 9:
						if (Unsafe.AreSame(ref *(byte*)this, ref *(byte*)(&P_0)))
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
						if ((int)/*Error near IL_0095: Stack underflow*/ == 0)
						{
							obj2 = 4;
							continue;
						}
						break;
					case 4:
					case 6:
					case 8:
						obj2 = this;
						if ((int)P_0 == 0)
						{
							if (9 == 0)
							{
								obj2 = 10;
							}
							continue;
						}
						goto case 2;
					case 5:
						_ = this + 1;
						if (0 == 0)
						{
							_ = 0;
						}
						continue;
					case 2:
						obj2 = this;
						if ((int)P_0 != 0)
						{
							if (1 == 0)
							{
								obj2 = 1;
							}
							continue;
						}
						goto case 9;
					case 3:
						break;
					}
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
		public RunnerFactory()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775359, new IntPtr(2737323020556L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected object _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
	private _003CRegexGenerator_g_003EF913B518315CAC4435BB177D208F0E66F2B48B47DD3BAE12B2F89258425FEDE89__MinecraftFormatRegex_0()
	{
		//IL_0012: Expected Obj, but got I4
		//IL_0041: Expected I4, but got Obj
		//IL_0053->IL0020: Incompatible stack heights: 4 vs 2
		//IL_0061->IL0020: Incompatible stack heights: 3 vs 2
		//IL_0089->IL0020: Incompatible stack heights: 1 vs 2
		//IL_00a1->IL0020: Incompatible stack heights: 4 vs 2
		//IL_00bb->IL0020: Incompatible stack types: I4 vs Obj
		//IL_007b->IL0020: Incompatible stack types: I4 vs Obj
		//IL_0094->IL0020: Incompatible stack heights: 1 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
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
				_ = 5;
				break;
			case 3:
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			case 4:
				if (false)
				{
					_ = 0;
				}
				break;
			case 5:
				_ = 1;
				_ = 6;
				break;
			default:
				obj2 = this;
				if (2 != 0)
				{
					obj2 = 0;
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
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00휀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775345, new IntPtr(2737323015356L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775358, new IntPtr(2737323034076L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}
}
