using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mass.Game.Launcher.Paths;

namespace Mass.Game.Launcher.Java;

public static class JavaCrashAnalyzer
{
	internal static JavaCrashAnalyzer DecorateMixedChain;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string Analyze(MinecraftPath mcPath, IReadOnlyList<string> recentLog, int exitCode)
	{
		return (string)_EF00(mcPath, recentLog, (uint)exitCode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object ReadRecentLog(IReadOnlyList<string> lines)
	{
		return 儀(lines);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object? ReadLatestCrashReport(object mcPath)
	{
		return 頀(mcPath);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object? ReadLatestHsErr(object mcPath)
	{
		return 唀(mcPath);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object? ReadNewestFile(object dir, object pattern)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 240, 1790778867, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778867, new IntPtr(2737337538764L), 15);
		}
		return ((delegate*<object, object, object>)obj)(dir, pattern);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static (CrashReason, string) Classify(object logMc, object? logCrash, object? logHs, uint exitCode)
	{
		return 倀(logMc, logCrash, logHs, exitCode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static (CrashReason, string)? AnalyzeExitCode(uint exitCode)
	{
		return 搀(exitCode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static (CrashReason, string)? AnalyzeCrit1(object logMc, object? logCrash, object? logHs)
	{
		return 錀(logMc, logCrash, logHs);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static (CrashReason, string)? AnalyzeCrit2(object logMc, object? logCrash)
	{
		return 픀(logMc, logCrash);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static (CrashReason, string)? AnalyzeCrit3(object logMc, object? logCrash)
	{
		return _FFFD(logMc, logCrash);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte IsMixin(object log, [Out] nint modName)
	{
		return _EC00(log, modName);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object ExtractAfter(object s, object marker)
	{
		return 턀(s, marker);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object ExtractBetween(object s, object start, object end)
	{
		return _E100(s, start, end);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object ExtractDuplicateMod(object logMc)
	{
		return 昀(logMc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object BuildMessage(CrashReason reason, object detail)
	{
		return 케(reason, detail);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object BuildWindowsExitCodeMessage(object detail, object cause)
	{
		return 鴀(detail, cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckFlexibleEnumerator()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static JavaCrashAnalyzer DecorateSegmentedParameter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static (CrashReason, string) 伀(object P_0, object P_1, object P_2, uint P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778866, new IntPtr(2737337572044L), 15))(null, 0, new IntPtr(0L));
		return ((CrashReason, string))/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static (CrashReason, string) 倀(object P_0, object P_1, object P_2, uint P_3)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0052: Expected I4, but got Obj
		//IL_0189: Expected VT, but got Ref
		//IL_005b: Expected VT, but got I4
		//IL_00c0: Expected VT, but got Ref
		//IL_00ee: Expected VT, but got Ref
		//IL_010e: Expected VT, but got Ref
		//IL_00c4: Expected Obj, but got I4
		//IL_005f: Expected VT, but got I4
		//IL_007e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0198->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00d0->IL0019: Incompatible stack heights: 0 vs 1
		//IL_015b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00b1->IL0019: Incompatible stack heights: 0 vs 1
		//IL_017a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0092->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0120->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00db->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0166->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00bc->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0185->IL0019: Incompatible stack types: I4 vs Obj
		//IL_010a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_012b->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 10;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 6:
				return ((CrashReason, string))1;
			case 3:
				return ((CrashReason, string))0;
			case 10:
				obj = P_2;
				_ = 9;
				break;
			case 9:
				if (&obj != null)
				{
					if (11 != 0)
					{
						obj2 = 10;
					}
					break;
				}
				obj2 = P_0;
				obj = P_1;
				if (8 != 0)
				{
					obj2 = 8;
				}
				break;
			case 5:
				if (&obj == null)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 12;
			case 7:
				return ((CrashReason, string))(&obj);
			case 11:
				return ((CrashReason, string))(&obj);
			case 12:
				return ((CrashReason, string))(&obj);
			default:
				if (P_2 == null)
				{
					if (1 == 0)
					{
						obj2 = 3;
					}
					break;
				}
				goto case 6;
			case 2:
				if (&obj == null)
				{
					obj = P_3;
					if (5 != 0)
					{
						obj2 = 0;
					}
				}
				else if (7 == 0)
				{
					obj2 = 2;
				}
				break;
			case 8:
				if (&obj == null)
				{
					if (1 == 0)
					{
						obj2 = 1;
					}
					break;
				}
				goto case 4;
			case 4:
				return ((CrashReason, string))(&obj);
			case 1:
				obj = P_1;
				_ = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object 儀(IReadOnlyList<string> P_0)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_ = 10;
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object 刀(IReadOnlyList<string> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778865, new IntPtr(2737337539804L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object 吀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778864, new IntPtr(2737337572044L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object 唀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 3880, 1790778863, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778863, new IntPtr(2737337572044L), 15);
		}
		return ((delegate*<object, object>)obj)(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static (CrashReason, string)? 搀(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0122: Expected I4, but got Obj
		//IL_01a7: Expected Obj, but got I4
		//IL_0486: Expected Obj, but got I4
		//IL_0322: Expected Obj, but got I4
		//IL_0468: Expected Obj, but got I4
		//IL_0497: Expected Obj, but got I4
		//IL_056e: Expected Obj, but got I4
		//IL_0577: Expected Obj, but got I4
		//IL_0311: Expected Obj, but got Ref
		//IL_02ed: Expected Obj, but got I4
		//IL_02fe: Expected Obj, but got I4
		//IL_04bd: Expected Obj, but got I4
		//IL_055d: Expected Obj, but got I4
		//IL_05b4: Expected Obj, but got I4
		//IL_041b: Expected Obj, but got I4
		//IL_012e: Expected Obj, but got I4
		//IL_013b: Expected VT, but got Obj
		//IL_036b: Expected Obj, but got I4
		//IL_01f4: Expected Obj, but got I4
		//IL_026e: Expected Obj, but got I4
		//IL_03a5: Expected Obj, but got I4
		//IL_0186: Expected Obj, but got I4
		//IL_01b1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0490->IL0019: Incompatible stack types: I4 vs Obj
		//IL_032e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0474->IL0019: Incompatible stack heights: 0 vs 1
		//IL_04a1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_031b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02f7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0308->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04c7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0567->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05be->IL0019: Incompatible stack types: I4 vs Obj
		//IL_015d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0427->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0138->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0377->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0209->IL0019: Incompatible stack heights: 0 vs 1
		//IL_025a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0339->IL0019: Incompatible stack types: I4 vs Obj
		//IL_047f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05d5->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0229->IL0019: Incompatible stack types: I4 vs Obj
		//IL_064c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0685->IL0019: Incompatible stack heights: 0 vs 1
		//IL_050f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02ac->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05f5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03d0->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0432->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0663->IL0019: Incompatible stack heights: 0 vs 1
		//IL_04b6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0150->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0414->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03f0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0382->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01a0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0297->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04e0->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0214->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0172->IL0019: Incompatible stack types: I4 vs Obj
		//IL_060c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05e0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0690->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03db->IL0019: Incompatible stack types: I4 vs Obj
		//IL_066e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04eb->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 20;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 41:
					obj = 30;
					obj2 = 5;
					continue;
				case 5:
				case 10:
				case 13:
				case 14:
				case 16:
				case 22:
				case 29:
				case 40:
				case 42:
				case 47:
				case 51:
				case 52:
				case 58:
				case 60:
				case 61:
				case 63:
					return ((CrashReason, string)?)obj;
				case 48:
					if (P_0 != 3221226356u)
					{
						obj2 = 34;
						continue;
					}
					goto case 9;
				case 8:
				case 17:
				case 18:
				case 28:
				case 30:
				case 36:
				case 43:
				case 44:
					_ = ref obj;
					_ = 59;
					continue;
				case 39:
				case 62:
					if (P_0 != 3221225786u)
					{
						obj2 = 4;
						continue;
					}
					goto case 54;
				case 37:
					if (P_0 != 3221225595u)
					{
						obj = 43;
						break;
					}
					goto case 6;
				case 55:
					if (P_0 != 3221225477u)
					{
						obj2 = 28;
						continue;
					}
					goto default;
				default:
					obj = 23;
					obj2 = 22;
					continue;
				case 4:
					if (P_0 != 3221225794u)
					{
						obj = 17;
						break;
					}
					goto case 2;
				case 59:
					obj = obj;
					if (26 == 0)
					{
						obj2 = 42;
					}
					continue;
				case 12:
					if (P_0 != 3221225622u)
					{
						obj2 = 30;
						continue;
					}
					goto case 35;
				case 1:
					if (P_0 != 3221225478u)
					{
						obj2 = 31;
						continue;
					}
					goto case 38;
				case 7:
					if (P_0 != 3221225501u)
					{
						obj = 37;
						break;
					}
					goto case 3;
				case 56:
					if ((int)P_0 > -1073741511)
					{
						obj2 = 39;
						continue;
					}
					goto case 45;
				case 32:
					if (P_0 != 3221225785u)
					{
						obj2 = 18;
						continue;
					}
					goto case 26;
				case 24:
					obj = 34;
					obj2 = 13;
					continue;
				case 25:
					obj = 29;
					obj2 = 52;
					continue;
				case 23:
					_ = 12;
					obj = (object)(&P_0);
					_ = 16;
					continue;
				case 3:
					obj = 22;
					if (13 == 0)
					{
						obj2 = 40;
					}
					continue;
				case 54:
					obj = 35;
					if (63 != 0)
					{
						obj2 = 35;
					}
					continue;
				case 20:
					if ((int)P_0 <= -1073741674)
					{
						obj = 19;
						break;
					}
					goto case 50;
				case 34:
					if (P_0 != 3221226505u)
					{
						if (44 != 0)
						{
							obj2 = 17;
						}
						continue;
					}
					goto case 25;
				case 50:
					if ((int)P_0 <= -1073741502)
					{
						obj2 = 56;
						continue;
					}
					goto case 49;
				case 49:
					if ((int)P_0 > -1073740791)
					{
						obj2 = 53;
						continue;
					}
					goto case 48;
				case 38:
					obj = 33;
					if (7 == 0)
					{
						obj2 = 14;
					}
					continue;
				case 6:
					obj = 24;
					if (10 == 0)
					{
						obj2 = 3;
					}
					continue;
				case 2:
					obj = 27;
					obj2 = 58;
					continue;
				case 9:
					obj = 28;
					obj2 = 47;
					continue;
				case 46:
					if (P_0 != 2147483651u)
					{
						obj2 = 55;
						continue;
					}
					goto case 24;
				case 26:
					obj = 26;
					obj2 = 61;
					continue;
				case 57:
					if (P_0 - 23333 <= 1)
					{
						if (16 == 0)
						{
							obj2 = 23;
						}
						continue;
					}
					goto case 8;
				case 31:
					if (P_0 != 3221225495u)
					{
						obj2 = 8;
						continue;
					}
					goto case 27;
				case 27:
					obj = 32;
					obj2 = 29;
					continue;
				case 21:
					obj = 25;
					obj = 60;
					break;
				case 35:
					obj = 31;
					obj2 = 51;
					continue;
				case 11:
					if (P_0 != 3221225620u)
					{
						if (5 == 0)
						{
							obj2 = 12;
						}
						continue;
					}
					goto case 41;
				case 33:
					if ((int)P_0 <= -1073741701)
					{
						obj2 = 7;
						continue;
					}
					goto case 11;
				case 53:
				case 64:
					if ((uint)((int)P_0 - -23334) > 1u)
					{
						obj2 = 57;
						continue;
					}
					goto case 23;
				case 15:
					if ((int)P_0 <= -1073741819)
					{
						obj2 = 46;
						continue;
					}
					goto case 1;
				case 45:
					if (P_0 != 3221225781u)
					{
						if (29 != 0)
						{
							obj2 = 32;
						}
						continue;
					}
					goto case 21;
				case 19:
					if ((int)P_0 <= -1073741801)
					{
						if (9 == 0)
						{
							obj2 = 15;
						}
						continue;
					}
					goto case 33;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object 昀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 3897, 1790778862, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778862, new IntPtr(2737337539804L), 15);
		}
		return ((delegate*<object, object>)obj)(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object 最(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778861, new IntPtr(2737337582444L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte 栀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte 椀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778860, new IntPtr(2737337579324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static (CrashReason, string)? 錀(object P_0, object P_1, object P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_012a: Expected I4, but got Obj
		//IL_02e2: Expected VT, but got I4
		//IL_071c: Expected VT, but got Obj
		//IL_069b: Expected VT, but got I4
		//IL_0467: Expected VT, but got Obj
		//IL_0169: Expected VT, but got Obj
		//IL_02cb: Expected VT, but got I4
		//IL_0446: Expected VT, but got I4
		//IL_0393: Expected VT, but got Obj
		//IL_02a1: Expected VT, but got I4
		//IL_0389: Expected VT, but got Obj
		//IL_04cb: Expected VT, but got I4
		//IL_0260: Expected VT, but got I4
		//IL_0489: Expected VT, but got I4
		//IL_0608: Expected VT, but got I4
		//IL_0658: Expected VT, but got I4
		//IL_0319: Expected VT, but got Obj
		//IL_05a7: Expected VT, but got Obj
		//IL_0633: Expected VT, but got I4
		//IL_03b7: Expected VT, but got I4
		//IL_0752: Expected VT, but got I4
		//IL_06dc: Expected VT, but got Obj
		//IL_019e: Expected VT, but got I4
		//IL_01f7: Expected VT, but got I4
		//IL_0788: Expected VT, but got I4
		//IL_0539: Expected VT, but got I4
		//IL_03db: Expected VT, but got I4
		//IL_035d: Expected Obj, but got I4
		//IL_0239: Expected Obj, but got I4
		//IL_01bc: Expected Obj, but got I4
		//IL_06ac: Expected Obj, but got I4
		//IL_03ec: Expected Obj, but got I4
		//IL_0619: Expected Obj, but got I4
		//IL_0598->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0403->IL0019: Incompatible stack types: I4 vs Obj
		//IL_068b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0415->IL0019: Incompatible stack types: I4 vs Obj
		//IL_06d5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_057b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0386->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0702->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0228->IL0019: Incompatible stack types: I4 vs Obj
		//IL_074d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04fe->IL0019: Incompatible stack heights: 0 vs 1
		//IL_07ca->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01e7->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01d3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_034c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0603->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0783->IL0019: Incompatible stack types: I4 vs Obj
		//IL_06c3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0374->IL0019: Incompatible stack types: I4 vs Obj
		//IL_018d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0696->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0647->IL0019: Incompatible stack heights: 0 vs 1
		//IL_02dd->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01ab->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0274->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0586->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04df->IL0019: Incompatible stack heights: 0 vs 1
		//IL_02f6->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0479->IL0019: Incompatible stack heights: 0 vs 1
		//IL_020b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_070d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05b9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0766->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0509->IL0019: Incompatible stack types: I4 vs Obj
		//IL_049d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_07d5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_06ee->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01f2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02b3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_079a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_066c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_054d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0730->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0198->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03cb->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0652->IL0019: Incompatible stack types: I4 vs Obj
		//IL_027f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04ea->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0301->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0179->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0484->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0216->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0771->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0458->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04a8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03a7->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0677->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0558->IL0019: Incompatible stack types: I4 vs Obj
		//IL_073b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03d6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_032b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03b2->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 6;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 8:
					_ = 19;
					_ = 10;
					return ((CrashReason, string)?)((object[])0)[0];
				case 63:
					if (P_0 != null)
					{
						if (0 == 0)
						{
							obj2 = 10;
						}
						continue;
					}
					goto default;
				case 52:
					return ((CrashReason, string)?)(object)10;
				case 26:
					if (P_0 != null)
					{
						obj = 30;
						break;
					}
					goto IL_02e2;
				case 43:
					if (P_0 != null)
					{
						obj2 = 18;
						continue;
					}
					if (P_0 != null)
					{
						obj2 = 49;
						continue;
					}
					goto case 45;
				case 42:
					if (P_0 != null)
					{
						if (50 == 0)
						{
							obj2 = 18;
						}
						continue;
					}
					if (P_0 == null)
					{
						if (P_0 == null)
						{
							if (P_0 == null)
							{
								obj2 = 56;
								continue;
							}
							goto case 4;
						}
						if (18 != 0)
						{
							obj2 = 39;
						}
						continue;
					}
					obj2 = 15;
					continue;
				case 60:
					return ((CrashReason, string)?)(object)5;
				case 30:
					if (P_0 != null)
					{
						obj2 = 2;
						continue;
					}
					goto IL_02e2;
				case 19:
					if (P_2 == null)
					{
						obj = 24;
						break;
					}
					goto case 1;
				case 1:
				case 33:
					return ((CrashReason, string)?)(object)11;
				case 20:
					if (P_2 != null)
					{
						if (41 != 0)
						{
							obj2 = 38;
						}
						continue;
					}
					goto IL_019e;
				case 18:
					return ((CrashReason, string)?)(object)13;
				case 12:
					return ((CrashReason, string)?)(object)7;
				case 17:
					if (P_0 == null)
					{
						obj2 = 9;
						continue;
					}
					goto case 62;
				case 2:
					return ((CrashReason, string)?)(object)2;
				case 39:
					_ = 15;
					return ((CrashReason, string)?)P_0;
				case 45:
					if (P_0 != null)
					{
						obj2 = 32;
						continue;
					}
					goto case 61;
				case 6:
					if (P_0 != null)
					{
						obj = 5;
						break;
					}
					if (P_0 == null)
					{
						obj = 58;
						break;
					}
					goto case 38;
				case 61:
					if (P_0 != null)
					{
						obj2 = 54;
						continue;
					}
					goto case 42;
				case 28:
					if (P_0 == null)
					{
						if (P_0 != null)
						{
							if (26 == 0)
							{
								obj2 = 35;
							}
							continue;
						}
						if (P_0 == null)
						{
							obj = 17;
							break;
						}
						goto case 12;
					}
					obj2 = 60;
					continue;
				case 22:
					return ((CrashReason, string)?)obj;
				case 15:
					_ = 16;
					return ((CrashReason, string)?)P_0;
				case 47:
					return ((CrashReason, string)?)(object)2;
				case 66:
					return ((CrashReason, string)?)(object)2;
				case 16:
				case 53:
					if (P_0 == null)
					{
						obj = 43;
						break;
					}
					goto case 18;
				case 3:
					if (P_0 != null)
					{
						obj2 = 53;
						continue;
					}
					goto case 66;
				case 14:
					if (P_0 == null)
					{
						obj2 = 51;
						continue;
					}
					goto case 38;
				case 13:
					return ((CrashReason, string)?)(object)9;
				case 7:
					_ = 19;
					_ = 10;
					return ((CrashReason, string)?)((object[])0)[0];
				case 27:
					if (P_1 != null)
					{
						if (2 != 0)
						{
							obj2 = 21;
						}
						continue;
					}
					goto IL_0169;
				case 34:
					return ((CrashReason, string)?)(object)8;
				case 23:
					return ((CrashReason, string)?)(object)7;
				case 25:
					if (P_1 == null)
					{
						if (16 == 0)
						{
							obj2 = 31;
						}
						continue;
					}
					goto case 40;
				case 37:
					if (P_0 != null)
					{
						if (65 != 0)
						{
							obj2 = 1;
						}
						continue;
					}
					goto case 63;
				case 10:
				case 64:
				case 65:
					return ((CrashReason, string)?)(object)4;
				case 55:
					if (P_0 == null)
					{
						if (28 == 0)
						{
							obj2 = 2;
						}
						continue;
					}
					goto case 60;
				case 24:
					if (P_2 != null)
					{
						if (false)
						{
							obj2 = 1;
						}
						continue;
					}
					goto case 57;
				default:
					if (P_0 == null)
					{
						obj2 = 55;
						continue;
					}
					goto case 10;
				case 40:
					_ = 18;
					_ = 10;
					return ((CrashReason, string)?)((object[])0)[0];
				case 31:
					if (P_1 != null)
					{
						obj2 = 8;
						continue;
					}
					goto IL_0169;
				case 57:
					if (P_2 == null)
					{
						obj2 = 20;
						continue;
					}
					goto case 1;
				case 35:
					return ((CrashReason, string)?)(object)6;
				case 44:
					return ((CrashReason, string)?)(object)21;
				case 11:
					if (P_1 == null)
					{
						if (P_1 == null)
						{
							if (25 == 0)
							{
								obj2 = 6;
							}
							continue;
						}
						goto case 23;
					}
					if (20 == 0)
					{
						obj2 = 47;
					}
					continue;
				case 38:
					return ((CrashReason, string)?)(object)20;
				case 51:
					if (P_0 == null)
					{
						if (37 == 0)
						{
							obj2 = 37;
						}
						continue;
					}
					goto case 10;
				case 9:
					if (P_0 == null)
					{
						if (13 != 0)
						{
							obj2 = 46;
						}
						continue;
					}
					goto case 62;
				case 5:
					return ((CrashReason, string)?)(object)3;
				case 59:
					if (P_2 != null)
					{
						obj2 = 19;
						continue;
					}
					goto case 20;
				case 21:
					if (P_1 == null)
					{
						obj2 = 11;
						continue;
					}
					goto case 44;
				case 32:
				case 49:
				case 50:
				case 54:
					_ = 14;
					return ((CrashReason, string)?)P_0;
				case 29:
					if (P_2 == null)
					{
						if (36 == 0)
						{
							obj2 = 2;
						}
						continue;
					}
					goto case 48;
				case 4:
					_ = 18;
					_ = 10;
					return ((CrashReason, string)?)((object[])0)[0];
				case 56:
					if (P_0 == null)
					{
						if (9 == 0)
						{
							obj2 = 27;
						}
						continue;
					}
					goto case 7;
				case 36:
					if (P_2 != null)
					{
						obj2 = 48;
						continue;
					}
					if (P_2 != null)
					{
						if (59 != 0)
						{
							obj2 = 7;
						}
						continue;
					}
					goto case 20;
				case 48:
					return ((CrashReason, string)?)(object)2;
				case 58:
					if (P_0 == null)
					{
						obj2 = 14;
						continue;
					}
					goto case 38;
				case 62:
					return ((CrashReason, string)?)(object)2;
				case 46:
					if (P_0 == null)
					{
						obj2 = 26;
						continue;
					}
					goto case 2;
				case 41:
					{
						if (P_2 == null)
						{
							if (P_2 == null)
							{
								if (P_2 != null)
								{
									obj2 = 52;
									continue;
								}
								goto IL_019e;
							}
							if (13 == 0)
							{
								obj2 = 6;
							}
							continue;
						}
						if (34 == 0)
						{
							obj2 = 27;
						}
						continue;
					}
					IL_0169:
					if (P_2 != null)
					{
						obj2 = 29;
						continue;
					}
					goto IL_019e;
					IL_02e2:
					if (P_0 == null)
					{
						if (16 != 0)
						{
							obj2 = 4;
						}
						continue;
					}
					goto case 3;
					IL_019e:
					_ = ref obj;
					_ = 22;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static (CrashReason, string)? 鐀(object P_0, object P_1, object P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778859, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return ((CrashReason, string)?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object 需(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778858, new IntPtr(2737337573084L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object 頀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 3947, 1790778857, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778857, new IntPtr(2737337575164L), 15);
		}
		return ((delegate*<object, object>)obj)(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object 餀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778856, new IntPtr(2737337587644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object 鴀(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 3952, 1790778855, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778855, new IntPtr(2737337589724L), 15);
		}
		return ((delegate*<object, object, object>)obj)(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object 鸀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778854, new IntPtr(2737337573084L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 鼀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object 케(CrashReason P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_016e: Expected I4, but got Obj
		//IL_06ac: Expected Obj, but got I4
		//IL_029c: Expected Obj, but got I4
		//IL_056e: Expected Obj, but got I4
		//IL_055d: Expected Obj, but got I4
		//IL_020b: Expected Obj, but got I4
		//IL_0618: Expected Obj, but got I4
		//IL_0288: Expected Obj, but got I4
		//IL_05db: Expected Obj, but got I4
		//IL_038e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0180->IL0019: Incompatible stack types: I4 vs Obj
		//IL_030b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0358->IL0019: Incompatible stack heights: 0 vs 1
		//IL_031b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_071b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_06fe->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0473->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0192->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0748->IL0019: Incompatible stack heights: 0 vs 1
		//IL_032b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0542->IL0019: Incompatible stack heights: 0 vs 1
		//IL_039e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03b0->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0264->IL0019: Incompatible stack heights: 0 vs 1
		//IL_027c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_059f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_064a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0671->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01d9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0853->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03c8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0485->IL0019: Incompatible stack heights: 0 vs 1
		//IL_05cd->IL0019: Incompatible stack heights: 0 vs 1
		//IL_02ca->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04cd->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0215->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01ea->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0762->IL0019: Incompatible stack heights: 0 vs 1
		//IL_05e5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0236->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0363->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0726->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0608->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0709->IL0019: Incompatible stack types: I4 vs Obj
		//IL_019d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0753->IL0019: Incompatible stack types: I4 vs Obj
		//IL_054d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03bb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_086b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_087a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_026f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0655->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04b1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_081f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0226->IL0019: Incompatible stack types: I4 vs Obj
		//IL_085f->IL085f: Incompatible stack heights: 0 vs 1
		//IL_05f6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0490->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05d8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_076d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0885->IL0019: Incompatible stack types: I4 vs Obj
		//IL_082a->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 55;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 2:
				case 51:
					obj = (object)/*Error near IL_0176: Stack underflow*/;
					obj2 = 52;
					continue;
				case 13:
					obj = obj;
					if (35 == 0)
					{
						obj2 = 76;
					}
					continue;
				case 47:
					goto IL_01c8;
				case 75:
					goto IL_01d9;
				case 69:
					obj = 1;
					obj2 = 49;
					continue;
				case 41:
				case 49:
					if (obj == null)
					{
						obj2 = 27;
						continue;
					}
					goto case 27;
				case 82:
					goto IL_0226;
				case 29:
					goto IL_0252;
				case 34:
					goto IL_026f;
				case 78:
					goto IL_027c;
				case 26:
					goto IL_028d;
				case 64:
					goto IL_02bd;
				case 3:
					goto IL_02fb;
				case 6:
					goto IL_030b;
				case 19:
					goto IL_031b;
				case 4:
					goto IL_0349;
				case 1:
					goto IL_0381;
				case 23:
					goto IL_038e;
				case 24:
					goto IL_039e;
				case 56:
					goto IL_03bb;
				case 25:
					goto case 54;
				case 11:
					goto IL_0466;
				case 59:
					goto IL_0473;
				case 39:
					goto IL_049f;
				case 65:
					goto IL_04c0;
				case 20:
					goto IL_0530;
				case 66:
					goto IL_054d;
				case 38:
					goto IL_0562;
				case 35:
					goto IL_058f;
				case 63:
					goto IL_05bb;
				case 8:
				case 81:
					obj = 0;
					obj2 = 41;
					continue;
				case 55:
					if (P_1 != null)
					{
						obj2 = 54;
						continue;
					}
					goto case 25;
				case 9:
					if (P_1 == null)
					{
						obj2 = 8;
						continue;
					}
					goto case 69;
				case 71:
					goto IL_0608;
				case 36:
					goto IL_063b;
				case 45:
					goto IL_0664;
				case 14:
					goto IL_06a0;
				case 10:
					goto IL_06eb;
				case 7:
					goto IL_0709;
				case 18:
					goto IL_0735;
				case 80:
					goto IL_0753;
				default:
					return obj;
				case 40:
					switch (P_0)
					{
					case CrashReason.WindowsIntegerDivideByZero:
						break;
					case CrashReason.ModMissingDep:
						goto IL_01c8;
					case CrashReason.ModConflict:
						goto IL_01d9;
					case CrashReason.WindowsDllNotFound:
						goto IL_0226;
					case CrashReason.WindowsIllegalInstruction:
						goto IL_0252;
					case CrashReason.JavaVersionIncompat:
						goto IL_026f;
					case CrashReason.GpuDriverAmdCrash:
						goto IL_027c;
					case CrashReason.WindowsEntryPointNotFound:
						goto IL_028d;
					case CrashReason.HsErrCrash:
						goto IL_02bd;
					case CrashReason.WindowsDllInitializationFailed:
						goto IL_02fb;
					case CrashReason.WindowsOutOfMemory:
						goto IL_030b;
					case CrashReason.WindowsInvalidImageFormat:
						goto IL_031b;
					case CrashReason.ManualDebugCrash:
						goto IL_0349;
					case CrashReason.GameCoreVerificationLibraryCrash:
						goto IL_0381;
					case CrashReason.WindowsBreakpoint:
						goto IL_038e;
					case CrashReason.WindowsAccessViolation:
						goto IL_039e;
					case CrashReason.OutOfMemory:
						goto IL_03bb;
					case CrashReason.GpuDriverNvidiaCrash:
						goto IL_0466;
					case CrashReason.WindowsStackBufferOverrun:
						goto IL_0473;
					case CrashReason.NativeComponentLoadFailed:
						goto IL_049f;
					case CrashReason.GpuDriverIntelCrash:
						goto IL_04c0;
					case CrashReason.WindowsPrivilegedInstruction:
						goto IL_0530;
					case CrashReason.ModConfigError:
						goto IL_054d;
					case CrashReason.JavaVersionTooHigh:
						goto IL_0562;
					case CrashReason.WindowsControlC:
						goto IL_058f;
					case CrashReason.WindowsInPageError:
						goto IL_05bb;
					case CrashReason.ModCrash:
						goto IL_0608;
					case CrashReason.OpenGLNotSupported:
						goto IL_063b;
					case CrashReason.JvmArgError:
						goto IL_0664;
					case CrashReason.OpenJ9:
						goto IL_06a0;
					case CrashReason.ModDuplicate:
						goto IL_06eb;
					case CrashReason.WindowsHeapCorruption:
						goto IL_0709;
					case CrashReason.ModMixinFailed:
						goto IL_0735;
					case CrashReason.PixelFormatError:
						goto IL_0753;
					default:
						goto IL_0813;
					case CrashReason.ModExtracted:
						goto IL_0846;
					}
					goto case 13;
				case 48:
					goto IL_0846;
				case 54:
					obj = P_1;
					obj2 = 40;
					continue;
				case 27:
					{
						obj = (object)/*Error near IL_086e: Stack underflow*/;
						if (22 == 0)
						{
							obj2 = 5;
						}
						continue;
					}
					IL_0846:
					obj = (object)/*Error near IL_0849: Stack underflow*/;
					obj2 = 61;
					continue;
					IL_0813:
					if (25 != 0)
					{
						obj2 = 51;
					}
					continue;
					IL_02fb:
					obj = obj;
					obj2 = 79;
					continue;
					IL_0753:
					obj = (object)/*Error near IL_0756: Stack underflow*/;
					if (53 == 0)
					{
						obj2 = 74;
					}
					continue;
					IL_02bd:
					obj = (object)/*Error near IL_02c0: Stack underflow*/;
					obj2 = 31;
					continue;
					IL_0735:
					obj = obj;
					if (12 == 0)
					{
						obj2 = 46;
					}
					continue;
					IL_028d:
					obj = obj;
					obj = 73;
					break;
					IL_0709:
					obj = obj;
					if (72 == 0)
					{
						obj2 = 37;
					}
					continue;
					IL_027c:
					obj = (object)/*Error near IL_027f: Stack underflow*/;
					obj = 43;
					break;
					IL_06eb:
					obj = obj;
					if (83 == 0)
					{
						obj2 = 29;
					}
					continue;
					IL_026f:
					obj = (object)/*Error near IL_0272: Stack underflow*/;
					obj2 = 21;
					continue;
					IL_06a0:
					obj = (object)/*Error near IL_06a3: Stack underflow*/;
					obj = 28;
					break;
					IL_0664:
					obj = (object)/*Error near IL_0667: Stack underflow*/;
					obj2 = 62;
					continue;
					IL_063b:
					obj = (object)/*Error near IL_063e: Stack underflow*/;
					if (9 == 0)
					{
						obj2 = 58;
					}
					continue;
					IL_0252:
					obj = obj;
					if (17 == 0)
					{
						obj2 = 4;
					}
					continue;
					IL_0608:
					obj = obj;
					obj = 60;
					break;
					IL_01c8:
					obj = obj;
					obj2 = 30;
					continue;
					IL_0226:
					obj = obj;
					obj2 = 68;
					continue;
					IL_05bb:
					obj = obj;
					if (15 != 0)
					{
						obj2 = 5;
					}
					continue;
					IL_058f:
					obj = obj;
					obj2 = 70;
					continue;
					IL_0562:
					obj = (object)/*Error near IL_0565: Stack underflow*/;
					obj = 53;
					break;
					IL_054d:
					obj = obj;
					obj = 42;
					break;
					IL_0530:
					obj = obj;
					if (12 == 0)
					{
						obj2 = 4;
					}
					continue;
					IL_04c0:
					obj = (object)/*Error near IL_04c3: Stack underflow*/;
					obj2 = 33;
					continue;
					IL_049f:
					if (P_1 == null)
					{
						obj2 = 9;
						continue;
					}
					goto case 69;
					IL_0473:
					obj = obj;
					if (4 == 0)
					{
						obj2 = 5;
					}
					continue;
					IL_0466:
					obj = (object)/*Error near IL_0469: Stack underflow*/;
					obj2 = 44;
					continue;
					IL_03bb:
					obj = (object)/*Error near IL_03be: Stack underflow*/;
					obj2 = 57;
					continue;
					IL_039e:
					obj = obj;
					if (false)
					{
						obj2 = 0;
					}
					continue;
					IL_038e:
					obj = obj;
					obj2 = 16;
					continue;
					IL_0381:
					obj = (object)/*Error near IL_0384: Stack underflow*/;
					obj2 = 50;
					continue;
					IL_0349:
					obj = (object)/*Error near IL_034c: Stack underflow*/;
					if (31 == 0)
					{
						obj2 = 37;
					}
					continue;
					IL_01d9:
					obj = obj;
					obj2 = 67;
					continue;
					IL_031b:
					obj = obj;
					obj2 = 77;
					continue;
					IL_030b:
					obj = obj;
					obj2 = 32;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object 퀀(CrashReason P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778853, new IntPtr(2737337582444L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object 턀(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4004, 1790778852, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778852, new IntPtr(2737337573084L), 15);
		}
		return ((delegate*<object, object, object>)obj)(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static (CrashReason, string)? 픀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_00ac: Expected VT, but got Obj
		//IL_0049: Expected VT, but got Obj
		//IL_00a4: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I4
		//IL_00c0: Expected VT, but got I4
		//IL_00e4: Expected VT, but got I4
		//IL_0068->IL00e4: Incompatible stack heights: 0 vs 1
		//IL_0092->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00bb->IL00bd: Incompatible stack heights: 2 vs 1
		//IL_00c6->IL007f: Incompatible stack heights: 1 vs 0
		//IL_00a9->IL0015: Incompatible stack heights: 1 vs 0
		//IL_00df->IL00e1: Incompatible stack heights: 2 vs 1
		//IL_0058->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00fa->IL0015: Incompatible stack heights: 1 vs 0
		//IL_00d0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0063->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				case 3:
					_ = 18;
					return ((CrashReason, string)?)P_0;
				case 1:
					if (&obj != null)
					{
						_ = 6;
						continue;
					}
					goto case 2;
				case 5:
					if (&obj != null)
					{
						obj = 4;
						break;
					}
					if (P_1 == null)
					{
						_ = 2;
						continue;
					}
					goto case 1;
				default:
					return ((CrashReason, string)?)obj;
				case 4:
					if (obj != null)
					{
					}
					return ((CrashReason, string)?)(object)17;
				case 6:
					if (obj != null)
					{
					}
					return ((CrashReason, string)?)(object)17;
				case 2:
					if (P_0 == null)
					{
						_ = ref obj;
						if (0 == 0)
						{
							_ = 0;
						}
						continue;
					}
					obj = 3;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static (CrashReason, string)? 혀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778851, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return ((CrashReason, string)?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static (CrashReason, string)? _FFFD(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778850, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return ((CrashReason, string)?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static (CrashReason, string)? _FFFD(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0046: Expected I4, but got Obj
		//IL_0107: Expected VT, but got Obj
		//IL_0083: Expected VT, but got Obj
		//IL_00cb: Expected VT, but got I4
		//IL_005a: Expected VT, but got Obj
		//IL_00c0: Expected Obj, but got I4
		//IL_0118: Expected Obj, but got I4
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_00af->IL0019: Incompatible stack types: I4 vs Ref
		//IL_009d->IL0019: Incompatible stack types: I4 vs Ref
		//IL_006e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00dd->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0079->IL0019: Incompatible stack types: I4 vs Ref
		//IL_00e8->IL0019: Incompatible stack types: I4 vs Ref
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 9;
		while (true)
		{
			ref object reference = ref *(object*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 5u:
					_ = 18;
					_ = 10;
					return ((CrashReason, string)?)((object[])0)[0];
				case 8u:
					if (P_0 != null)
					{
						if (0 == 0)
						{
							reference = ref *(object*)3;
						}
						continue;
					}
					if (P_1 == null)
					{
						if (4 == 0)
						{
							reference = ref *(object*)1;
						}
						continue;
					}
					goto default;
				case 2u:
					_ = 18;
					return ((CrashReason, string)?)P_1;
				case 4u:
				case 7u:
					reference = ref obj;
					if (0 == 0)
					{
						reference = ref *(object*)1;
					}
					continue;
				case 9u:
					if (P_0 == null)
					{
						reference = ref *(object*)8;
						continue;
					}
					goto case 5u;
				default:
					if (P_1 != null)
					{
						obj = 6;
						break;
					}
					goto case 4u;
				case 3u:
					return ((CrashReason, string)?)(object)15;
				case 1u:
					return ((CrashReason, string)?)obj;
				case 6u:
					if (P_1 == null)
					{
						obj = 7;
						break;
					}
					goto case 2u;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static (CrashReason, string)? _FFFD(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778849, new IntPtr(2737337582444L), 15))(null, 0, new IntPtr(0L));
		return ((CrashReason, string)?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _E000(object P_0, object P_1, object P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778848, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _E100(object P_0, object P_1, object P_2)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005a: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4020, 1790778783, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 3, 1790778783, new IntPtr(2737337595964L), 15);
		}
		return ((delegate*<object, object, object, object>)obj)(P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static byte _EC00(object P_0, nint P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0066: Expected I4, but got Obj
		//IL_0174: Expected Obj, but got I4
		//IL_007b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0132->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0187->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00fe->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00ae->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0086->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0158->IL0019: Incompatible stack heights: 0 vs 1
		//IL_009c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01cd->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01b9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_019c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0144->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c2->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0109->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0163->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01d8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01a7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00cd->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				case 3:
					Unsafe.Write((void*)P_1, obj);
					if (2 != 0)
					{
						obj2 = 2;
					}
					break;
				case 2:
					return 1;
				case 7:
					if (P_0 != null)
					{
						obj2 = 6;
						break;
					}
					goto case 1;
				case 1:
					if (P_0 != null)
					{
						obj2 = 9;
						break;
					}
					goto default;
				case 17:
					if (obj != null)
					{
						return 1;
					}
					if (1 == 0)
					{
						obj2 = 3;
					}
					break;
				case 16:
					return 0;
				case 6:
				case 9:
				case 12:
					obj = P_0;
					if (5 == 0)
					{
						obj2 = 11;
					}
					break;
				case 5:
					Unsafe.Write((void*)P_1, null);
					obj2 = 4;
					break;
				case 15:
					if (P_0 == null)
					{
						obj2 = 16;
						break;
					}
					goto case 6;
				case 4:
					if (P_0 != null)
					{
						if (12 == 0)
						{
							obj2 = 9;
						}
						break;
					}
					goto case 7;
				default:
					if (P_0 == null)
					{
						goto end_IL_0019;
					}
					goto case 6;
				case 8:
					Unsafe.Write((void*)P_1, obj);
					obj2 = 13;
					break;
				case 13:
					return 1;
				case 14:
					obj = P_0;
					if (17 != 0)
					{
						obj2 = 14;
					}
					break;
				case 11:
					if (obj != null)
					{
						obj2 = 14;
						break;
					}
					goto case 8;
				case 10:
					if (P_0 == null)
					{
						if (13 == 0)
						{
							obj2 = 15;
						}
						break;
					}
					goto case 6;
				}
				continue;
				end_IL_0019:
				break;
			}
			obj = 10;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static byte _ED00(object P_0, nint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778782, new IntPtr(2737337574124L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _EE00(object P_0, IReadOnlyList<string> P_1, uint P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778781, new IntPtr(2737337582444L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _EF00(object P_0, IReadOnlyList<string> P_1, uint P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0045: Expected Obj, but got I4
		//IL_0048: Expected Obj, but got I4
		//IL_0054->IL0019: Incompatible stack heights: 3 vs 1
		//IL_005f->IL0019: Incompatible stack heights: 3 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return obj;
			case 1:
				obj = P_0;
				obj = P_0;
				obj = P_2;
				obj = P_2;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _F000(object P_0, IReadOnlyList<string> P_1, uint P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778780, new IntPtr(2737337583484L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _F100(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778779, new IntPtr(2737337590764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _F200(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0087->IL0044: Incompatible stack heights: 0 vs 1
		//IL_00a5->IL0044: Incompatible stack heights: 0 vs 1
		//IL_011b->IL0044: Incompatible stack heights: 0 vs 1
		//IL_010c->IL0044: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		int num;
		object obj3;
		switch ((int)obj)
		{
		case 1:
			{
				if (P_0 == null)
				{
					num = 3;
					goto IL_0044;
				}
				goto IL_00ce;
			}
			IL_0044:
			while (true)
			{
				object obj2;
				switch (num)
				{
				case 4:
					obj2 = obj;
					goto IL_010d;
				case 3:
					obj = null;
					if (0 == 0)
					{
						num = 0;
					}
					continue;
				case 2:
					if (obj == null)
					{
						if (true)
						{
							num = 1;
						}
						continue;
					}
					goto case 4;
				case 6:
					goto end_IL_0044;
				case 1:
					{
						obj2 = null;
						goto IL_010d;
					}
					IL_010d:
					obj = obj2;
					if (5 == 0)
					{
						num = 4;
					}
					continue;
				}
				goto end_IL_0019;
				continue;
				end_IL_0044:
				break;
			}
			goto IL_00ce;
			IL_00ce:
			obj3 = P_1 ?? P_0;
			if (obj3 == null)
			{
				obj3 = P_0;
			}
			if (obj3 == null)
			{
				obj3 = P_0;
			}
			obj = obj3;
			_ = 2;
			goto IL_0044;
			end_IL_0019:
			break;
		}
		return obj;
	}
}
