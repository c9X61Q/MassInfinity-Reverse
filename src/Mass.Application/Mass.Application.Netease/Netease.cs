using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Mass.Application.Netease;

public static class Netease
{
	[CompilerGenerated]
	private static readonly object Names__BackingField;

	[CompilerGenerated]
	private static readonly object Items__BackingField;

	[CompilerGenerated]
	private static readonly object Adjectives__BackingField;

	[CompilerGenerated]
	private static readonly object Prefixes__BackingField;

	[CompilerGenerated]
	private static readonly object Verbs__BackingField;

	public static readonly ConcurrentDictionary<uint, string> AccountIdDic;

	public static readonly ConcurrentDictionary<string, NeteaseSession> Sessions;

	internal static Netease CheckLocalSolver;

	private static string[] Names
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	private static string[] Items
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	private static string[] Adjectives
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	private static string[] Prefixes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	private static string[] Verbs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	private static string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	private static string Item
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	private static string Adjective
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	private static string Prefix
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	private static string Verb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static string GetRandomName()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0057: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 401, 1790778869, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778869, new IntPtr(2737337503404L), 15);
		}
		return (string)((delegate*<object>)obj)();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool HasSession(string userId)
	{
		return _FF00_FF00_FF00ﴀ(userId) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static NeteaseSession GetSession(string userId)
	{
		return (NeteaseSession)_FF00_FF00_FF00_F500(userId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveSession(string userId)
	{
		_FF00_FF00_FF00ﬀ(userId);
	}

	static Netease()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_00b5: Expected Obj, but got I4
		//IL_006b: Expected Obj, but got I4
		//IL_0058->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00e0->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0107->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0097->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0123->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00eb->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00a2->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 7;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					Adjectives__BackingField = ((string)ZYXDNGuarder._FF00_FF00_FF00_FF00ࠀ()).Split('.', StringSplitOptions.None);
					obj2 = 5;
					continue;
				case 2:
					Sessions = new ConcurrentDictionary<string, NeteaseSession>();
					obj = 3;
					break;
				case 3:
					return;
				case 6:
					Items__BackingField = ((string)ZYXDNGuarder._FF00_FF00_FF00_FF00_0900()).Split('.', StringSplitOptions.None);
					obj2 = 0;
					if (_003CModule_003E_007Bc547b36a_002Df832_002D4783_002Dbff4_002D35ff9bad7e58_007D.m_a6edc9c6177f4d1d9742e13736eb3634.m_86d8b59a53e14a7bb637955ded78afd1 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 1:
					AccountIdDic = new ConcurrentDictionary<uint, string>();
					obj = 2;
					break;
				case 4:
					Verbs__BackingField = ((string)ZYXDNGuarder._FF00_FF00_FF00_FF00_0A00()).Split('.', StringSplitOptions.None);
					obj2 = 1;
					if (_003CModule_003E_007Bc547b36a_002Df832_002D4783_002Dbff4_002D35ff9bad7e58_007D.m_a6edc9c6177f4d1d9742e13736eb3634.m_b98b8c7ea03c4809a1590868030ba3d6 != 0)
					{
						obj2 = 1;
					}
					continue;
				case 5:
					Prefixes__BackingField = ((string)ZYXDNGuarder._FF00_FF00_FF00_FF00_0B00()).Split('.', StringSplitOptions.None);
					obj2 = 4;
					continue;
				case 7:
					Names__BackingField = ((string)ZYXDNGuarder._FF00_FF00_FF00_FF00_0C00()).Split('.', StringSplitOptions.None);
					obj2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateSymbolicTester()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Netease StopChain()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_F400(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778868, new IntPtr(2737337471164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_F500(object P_0)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_F600(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778875, new IntPtr(2737337471164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_F700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778874, new IntPtr(2737337471164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00_FF00_FF00_F800()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00豈()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778873, new IntPtr(2737337471164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00切(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778872, new IntPtr(2737337471164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_FF00_FF00ﬀ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
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
				return;
			case 0:
				return;
			case 1:
				obj2 = P_0;
				_ = ref obj;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00ﰀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778879, new IntPtr(2737337471164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00ﴀ(object P_0)
	{
		//IL_000b: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FE00()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0057: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1792, 1790778878, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778878, new IntPtr(2737337475324L), 15);
		}
		return ((delegate*<object>)obj)();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778877, new IntPtr(2737337476364L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00Ā()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0057: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1794, 1790778876, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778876, new IntPtr(2737337471164L), 15);
		}
		return ((delegate*<object>)obj)();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00Ȁ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778851, new IntPtr(2737337504444L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_0300()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00Ѐ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778850, new IntPtr(2737337504444L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00_FF00_FF00_FF00Ԁ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_0600()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778849, new IntPtr(2737337504444L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_0700()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0057: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1800, 1790778848, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778848, new IntPtr(2737337504444L), 15);
		}
		return ((delegate*<object>)obj)();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00_FF00_FF00_FF00_0D00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_0E00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778855, new IntPtr(2737337472204L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00ༀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778854, new IntPtr(2737337476364L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00_FF00_FF00_FF00က()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00ሀ()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_008a: Expected I4, but got Obj
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected I4, but got Unknown
		//IL_0190: Expected Obj, but got I4
		//IL_01d5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_019c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_02c8->IL0019: Incompatible stack heights: 0 vs 1
		//IL_014f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00d5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_017f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_02f2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0273->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01b9->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0260->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0240->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0251->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0230->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01a7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02d3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_015a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_018a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_027e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01c4->IL0019: Incompatible stack types: I4 vs Obj
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
				return obj;
			case 2:
				obj = (object)/*Error near IL_00ba: Stack underflow*/;
				obj2 = 11;
				break;
			case 12:
				goto IL_00c4;
			case 9:
				goto IL_013e;
			case 15:
				goto IL_016d;
			case 4:
				obj = 12;
				if (3 == 0)
				{
					obj2 = 1;
				}
				break;
			case 22:
				goto IL_01a7;
			case 1:
				goto IL_01c4;
			case 3:
				switch (obj - 1)
				{
				case 10:
					break;
				case 2:
					goto IL_00c4;
				case 6:
					goto IL_013e;
				case 7:
					goto IL_016d;
				case 8:
					goto IL_01a7;
				case 1:
					goto IL_01c4;
				default:
					goto IL_0226;
				case 0:
					goto IL_0230;
				case 3:
					goto IL_0240;
				case 5:
					goto IL_0251;
				case 4:
					goto IL_0260;
				case 9:
					goto IL_02b6;
				}
				goto case 2;
			case 25:
				goto IL_0230;
			case 26:
				goto IL_0240;
			case 23:
				goto IL_0251;
			case 20:
				goto IL_0260;
			case 6:
				goto IL_02b6;
			case 7:
			case 19:
				{
					obj = (object)/*Error near IL_02e8: Stack underflow*/;
					obj2 = 16;
					break;
				}
				IL_02b6:
				obj = (object)/*Error near IL_02bc: Stack underflow*/;
				if (3 == 0)
				{
					obj2 = 5;
				}
				break;
				IL_0260:
				obj = (object)/*Error near IL_0267: Stack underflow*/;
				if (7 == 0)
				{
					obj2 = 13;
				}
				break;
				IL_013e:
				obj = (object)/*Error near IL_0143: Stack underflow*/;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
				IL_0251:
				obj = (object)/*Error near IL_0256: Stack underflow*/;
				obj2 = 24;
				break;
				IL_0240:
				obj = (object)/*Error near IL_0247: Stack underflow*/;
				obj2 = 10;
				break;
				IL_0230:
				obj = (object)/*Error near IL_0236: Stack underflow*/;
				obj2 = 18;
				break;
				IL_0226:
				obj2 = 7;
				break;
				IL_01c4:
				obj = (object)/*Error near IL_01cb: Stack underflow*/;
				obj2 = 8;
				break;
				IL_01a7:
				obj = (object)/*Error near IL_01ad: Stack underflow*/;
				if (17 == 0)
				{
					obj2 = 8;
				}
				break;
				IL_00c4:
				obj = (object)/*Error near IL_00cb: Stack underflow*/;
				obj2 = 14;
				break;
				IL_016d:
				obj = (object)/*Error near IL_0173: Stack underflow*/;
				if (21 != 0)
				{
					obj2 = 5;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00ጀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_1400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778853, new IntPtr(2737337472204L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00ᔀ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0057: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1814, 1790778852, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778852, new IntPtr(2737337472204L), 15);
		}
		return ((delegate*<object>)obj)();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00ᘀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778859, new IntPtr(2737337505484L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00_FF00_FF00_FF00ᜀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_1800()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0057: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1817, 1790778858, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778858, new IntPtr(2737337505484L), 15);
		}
		return ((delegate*<object>)obj)();
	}
}
