using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal sealed class ZYXDNGuarder
{
	internal delegate nint d(object P_0, int P_1, int P_2, nint P_3, int P_4);

	internal static bool a;

	internal static nint a;

	internal static nint a;

	internal static int a;

	internal static object a;

	internal static object a;

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.Synchronized)]
	internal unsafe static string CheckString(int P_0, int P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)a(MethodBase.GetCurrentMethod(), 0, 1790778883, new IntPtr(2737337521084L), 15))(null, 0, new IntPtr(0L));
		return (string)/*Error near IL_0033: Stack underflow*/;
	}

	internal static string CheckString(int P_0, int P_1)
	{
		return ZYXDNGuarder.CheckString(P_0, P_1);
	}

	static ZYXDNGuarder()
	{
		ZYXDNGuarder.a = new Hashtable();
		ZYXDNGuarder.a = false;
		ZYXDNGuarder.a = 0;
	}

	[DllImport("Mass.Runtime.dll", EntryPoint = "VMRuntime")]
	private static extern bool CheckRuntime(int P_0);

	[DllImport("Mass.Runtime64.dll", EntryPoint = "VMRuntime")]
	private static extern bool CheckRuntime64(int P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static bool RunHVM()
	{
		//IL_0002: Expected Obj, but got I4
		//IL_0023: Expected I, but got I8
		//IL_007e: Expected I, but got I8
		//IL_0085: Expected Obj, but got I4
		//IL_008c: Expected I4, but got Obj
		object obj = 1;
		ZYXDNGuarder.a = new IntPtr(2736934507497L);
		ZYXDNGuarder.a = unchecked((nint)6442488800L);
		RunHVM(new IntPtr(2737323133600L), new IntPtr(2737317520736L), new IntPtr(2737316271536L), 111616);
		AppDomain currentDomain = AppDomain.CurrentDomain;
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)6442490512uL)(currentDomain, currentDomain.Id, new IntPtr(2737323129808L));
		dvm();
		obj = 1;
		return (byte)(int)obj != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static bool RunHVM()
	{
		//IL_0002: Expected Obj, but got I4
		//IL_0023: Expected I, but got I8
		//IL_007e: Expected I, but got I8
		//IL_0085: Expected Obj, but got I4
		//IL_008c: Expected I4, but got Obj
		object obj = 1;
		ZYXDNGuarder.a = new IntPtr(2736934507497L);
		ZYXDNGuarder.a = unchecked((nint)6442488800L);
		RunHVM(new IntPtr(2737323133600L), new IntPtr(2737336714144L), new IntPtr(2737336714160L), 111616);
		AppDomain currentDomain = AppDomain.CurrentDomain;
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)6442490512uL)(currentDomain, currentDomain.Id, new IntPtr(2737335877584L));
		dvm();
		obj = 1;
		return (byte)(int)obj != 0;
	}

	internal static void Startup()
	{
		if (!ZYXDNGuarder.a)
		{
			ZYXDNGuarder.a = ZYXDNGuarder.RunHVM();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunHVM(nint P_0, nint P_1, nint P_2, int P_3)
	{
		//IL_000f: Expected Obj, but got I4
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_015f: Expected Obj, but got I
		//IL_0173: Expected Obj, but got I8
		//IL_0153: Expected Obj, but got I4
		//IL_0032->IL013d: Incompatible stack heights: 1 vs 0
		//IL_015b->IL015b: Incompatible stack heights: 4 vs 0
		//IL_003c->IL013d: Incompatible stack heights: 2 vs 0
		//IL_0046->IL013d: Incompatible stack heights: 3 vs 0
		//IL_0050->IL013d: Incompatible stack heights: 4 vs 0
		//IL_005a->IL013d: Incompatible stack heights: 5 vs 0
		//IL_0064->IL013d: Incompatible stack heights: 6 vs 0
		//IL_006e->IL013d: Incompatible stack heights: 7 vs 0
		//IL_0078->IL013d: Incompatible stack heights: 8 vs 0
		//IL_0082->IL013d: Incompatible stack heights: 9 vs 0
		//IL_008d->IL013d: Incompatible stack heights: 10 vs 0
		//IL_0098->IL013d: Incompatible stack heights: 11 vs 0
		//IL_00a3->IL013d: Incompatible stack heights: 12 vs 0
		//IL_00ae->IL013d: Incompatible stack heights: 13 vs 0
		//IL_00b9->IL013d: Incompatible stack heights: 14 vs 0
		//IL_00c4->IL013d: Incompatible stack heights: 15 vs 0
		//IL_00ce->IL013d: Incompatible stack heights: 15 vs 0
		//IL_00d7->IL013d: Incompatible stack heights: 15 vs 0
		//IL_00e4->IL013d: Incompatible stack heights: 15 vs 0
		//IL_00ee->IL013d: Incompatible stack heights: 15 vs 0
		//IL_00f8->IL013d: Incompatible stack heights: 15 vs 0
		//IL_0105->IL013d: Incompatible stack heights: 15 vs 0
		//IL_0112->IL013d: Incompatible stack heights: 15 vs 0
		//IL_011f->IL013d: Incompatible stack heights: 15 vs 0
		//IL_012c->IL013d: Incompatible stack heights: 15 vs 0
		//IL_0136->IL013d: Incompatible stack heights: 15 vs 0
		//IL_013d->IL014d: Incompatible stack heights: 15 vs 0
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = null;
		object obj2 = (object)/*Error near IL_000c: Stack underflow*/;
		object obj3 = 0;
		object obj4;
		while ((nint)obj3 < ((Array)obj2).Length)
		{
			obj3 = ((object[])obj2)[obj3];
			obj4 = obj3;
			if ((nint)obj4 == 15 && 0 == 68 && 1 == 78 && 2 == 71 && 3 == 117 && 4 == 97 && 5 == 114 && 6 == 100 && 7 == 46 && 8 == 82 && 9 == 117 && 10 == 110 && 11 == 116 && 12 == 105 && 13 == 109 && 14 == 101)
			{
				obj3 = obj3;
				if (obj3 != null && ((Array)obj3).Length == 8 && ((byte[])obj3)[0] == 208 && ((byte[])obj3)[1] == 90 && ((byte[])obj3)[2] == 39 && ((byte[])obj3)[3] == 211 && ((byte[])obj3)[4] == 237 && ((byte[])obj3)[5] == 158 && ((byte[])obj3)[6] == 178 && ((byte[])obj3)[7] == 90)
				{
					obj = ((object[])obj2)[obj3];
					break;
				}
			}
			obj3++;
		}
		if (obj == null)
		{
			obj3 = P_3;
			_ = 0;
			obj = obj3;
		}
		obj4 = P_1;
		_ = 42;
		_ = null;
		((object[])2)[0] = obj4;
		((object[])2)[1] = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void dvm()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0057: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 361, 1790778480, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = a(MethodBase.GetCurrentMethod(), 0, 1790778480, new IntPtr(2737317100188L), 15);
		}
		((delegate*<void>)obj)();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _0A00()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ᜀ()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 儀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 刀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 唀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 嘀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 圀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 堀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 挀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 椀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 樀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 欀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 瀀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 관()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 렀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 뤀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 먀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 묀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 븀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 뼀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 쀀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 섀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 숀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FFFD()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FFFD()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FFFD()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FFFD()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00ᄀ()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00ሀ()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00ጀ()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_1400()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00ᔀ()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00ᘀ()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00ᜀ()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_1800()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00ᤀ()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00ἀ()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_2500()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_2600()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00㤀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00崀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00帀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00戀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00蔀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00言()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00謀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00谀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00贀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00鄀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00阀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00鰀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00鸀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00ꀀ()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00ꐀ()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00뀀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00윀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00촀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00팀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_EA00()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_EB00()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_EC00()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_F300()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_F400()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_F800()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00豈()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}
}
