using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mass.Domain.Value;

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
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)a(MethodBase.GetCurrentMethod(), 0, 1790779215, new IntPtr(2737337543964L), 15))(null, 0, new IntPtr(0L));
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
		ZYXDNGuarder.a = new IntPtr(2736934490297L);
		ZYXDNGuarder.a = unchecked((nint)6442488800L);
		RunHVM(new IntPtr(2737323133600L), new IntPtr(2737316271520L), new IntPtr(2737316271440L), 111616);
		AppDomain currentDomain = AppDomain.CurrentDomain;
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)6442490512uL)(currentDomain, currentDomain.Id, new IntPtr(2737323130576L));
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
		ZYXDNGuarder.a = new IntPtr(2736934490297L);
		ZYXDNGuarder.a = unchecked((nint)6442488800L);
		RunHVM(new IntPtr(2737323133600L), new IntPtr(2737335528704L), new IntPtr(2737335529072L), 111616);
		AppDomain currentDomain = AppDomain.CurrentDomain;
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)6442490512uL)(currentDomain, currentDomain.Id, new IntPtr(2737335884512L));
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
	internal unsafe static void RunHVM(nint P_0, nint P_1, nint P_2, int P_3)
	{
		//IL_0021: Expected Obj, but got I4
		//IL_0024: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got VT
		//IL_0042: Expected I, but got Obj
		//IL_0044: Invalid comparison between Unknown and I4
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_0050: Expected Obj, but got I4
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_01cf: Expected Obj, but got I
		//IL_01dc: Expected Obj, but got I
		//IL_01e3: Expected VT, but got I4
		//IL_01f7: Expected Obj, but got I8
		//IL_01c1: Expected Obj, but got I4
		//IL_0060: Invalid comparison between Unknown and I4
		//IL_006c: Expected Obj, but got I4
		//IL_006e: Invalid comparison between VT and I4
		//IL_007a: Expected Obj, but got I4
		//IL_007c: Invalid comparison between Unknown and I4
		//IL_0088: Expected Obj, but got I4
		//IL_0098: Invalid comparison between Unknown and I4
		//IL_00a4: Expected Obj, but got I4
		//IL_00b4: Invalid comparison between Unknown and I4
		//IL_00c0: Expected Obj, but got I4
		//IL_00cf: Expected Obj, but got I4
		//IL_00d1: Invalid comparison between Unknown and I4
		//IL_00de: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I4
		//IL_00fc: Expected VT, but got I4
		//IL_010b: Expected Obj, but got I4
		//IL_011a: Expected Obj, but got I4
		//IL_0128: Expected I4, but got Obj
		//IL_00e5->IL019e: Incompatible stack heights: 1 vs 0
		//IL_00f4->IL019e: Incompatible stack heights: 2 vs 0
		//IL_0103->IL019e: Incompatible stack heights: 3 vs 0
		//IL_0112->IL019e: Incompatible stack heights: 3 vs 0
		//IL_0121->IL019e: Incompatible stack heights: 4 vs 0
		//IL_012f->IL019e: Incompatible stack heights: 3 vs 0
		//IL_0138->IL019e: Incompatible stack heights: 3 vs 0
		//IL_0145->IL019e: Incompatible stack heights: 3 vs 0
		//IL_014f->IL019e: Incompatible stack heights: 3 vs 0
		//IL_0159->IL019e: Incompatible stack heights: 3 vs 0
		//IL_0166->IL019e: Incompatible stack heights: 3 vs 0
		//IL_0173->IL019e: Incompatible stack heights: 3 vs 0
		//IL_0180->IL019e: Incompatible stack heights: 3 vs 0
		//IL_018d->IL019e: Incompatible stack heights: 3 vs 0
		//IL_0197->IL019e: Incompatible stack heights: 3 vs 0
		//IL_019e->IL01ae: Incompatible stack heights: 3 vs 0
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		object obj = null;
		object obj2 = ((Dictionary<string, object>.Enumerator*)((KeyValuePair<string, object>*)/*Error near IL_001b: Stack underflow*/)->Value)->MoveNext();
		object obj3 = 0;
		object obj4;
		while ((nint)obj3 < ((Array)obj2).Length)
		{
			((IDisposable)((object[])obj2)[obj3]).Dispose();
			obj3 = (object)/*Error near IL_0034: Stack underflow*/;
			obj4 = ((Dictionary<string, object>)obj3).GetEnumerator();
			((Action<ConfigValue>)/*Error near IL_0042: Stack underflow*/)._002Ector((object)/*Error near IL_0042: Stack underflow*/, (nint)obj4);
			if ((int)/*Error near IL_0049: Stack underflow*/ == 15)
			{
				((List<ConfigValue>)obj4).ForEach((Action<ConfigValue>)0);
				if ((int)/*Error near IL_0057: Stack underflow*/ == 68)
				{
					((Func<ConfigValue, bool>)/*Error near IL_005e: Stack underflow*/)._002Ector(obj4, (nint)1);
					if ((int)/*Error near IL_0065: Stack underflow*/ == 78 && Enumerable.FirstOrDefault<TSource>((IEnumerable<TSource>)obj4, (Func<TSource, bool>)2) == (TSource?)(object)71)
					{
						((List<ConfigValue>)obj4).Add((ConfigValue)3);
						if ((int)/*Error near IL_0081: Stack underflow*/ == 117)
						{
							object obj5 = obj4;
							((List<ConfigValue>)4)._002Ector();
							if ((nint)obj5 == 97)
							{
								((Func<ConfigValue, List<ConfigValue>>)/*Error near IL_0096: Stack underflow*/)._002Ector(obj4, (nint)5);
								if ((int)/*Error near IL_009d: Stack underflow*/ == 114 && (nint)Enumerable.Select<TSource, TResult>((IEnumerable<TSource>)obj4, (Func<TSource, TResult>)6) == 100)
								{
									((Func<List<ConfigValue>, IEnumerable<ConfigValue>>)/*Error near IL_00b2: Stack underflow*/)._002Ector(obj4, (nint)7);
									if ((int)/*Error near IL_00b9: Stack underflow*/ == 46 && (nint)Enumerable.SelectMany<TSource, TResult>((IEnumerable<TSource>)obj4, (Func<TSource, IEnumerable<TResult>>)8) == 82)
									{
										((List<ConfigValue>)obj4).AddRange((IEnumerable<ConfigValue>)9);
										if ((int)/*Error near IL_00d6: Stack underflow*/ == 117 && (nint)CustomAttributeExtensions.GetCustomAttribute<T>((MemberInfo)10) == 110 && (nint)((PropertyInfo)11).PropertyType == 116 && (nint)Type.GetTypeFromHandle((RuntimeTypeHandle)12) == 105 && (((Type?)obj4 == (Type?)13) ? 1 : 0) == 109)
										{
											object obj6 = obj4;
											if ((nint)Enumerable.ToList<TSource>((IEnumerable<TSource>)14) == 101)
											{
												obj3 = ((Type)obj6).GetProperties((BindingFlags)obj3);
												if (obj3 != null && ((Array)obj3).Length == 8 && ((byte[])obj3)[0] == 208 && ((byte[])obj3)[1] == 90 && ((byte[])obj3)[2] == 39 && ((byte[])obj3)[3] == 211 && ((byte[])obj3)[4] == 237 && ((byte[])obj3)[5] == 158 && ((byte[])obj3)[6] == 178 && ((byte[])obj3)[7] == 90)
												{
													obj = ((object[])obj2)[obj3];
													break;
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			obj3++;
		}
		if (obj == null)
		{
			obj3 = new RuntimeTypeHandle[P_3];
			_ = 0;
			P_3.GetType();
			/*Error near IL_01c2: Member reference must be method, but was: Field*/;
		}
		object obj7 = obj;
		((object)P_1)._002Ector();
		obj4 = obj7;
		bool flag = (string?)/*Error near IL_01d6: Stack underflow*/ == (string?)obj4;
		((List<string>)P_2)._002Ector();
		(flag ? ((DefaultInterpolatedStringHandler*)1) : ((DefaultInterpolatedStringHandler*)null))->AppendFormatted<T>((T)42);
		((DefaultInterpolatedStringHandler*)null)->AppendFormatted((string?)(object)new EqualityComparer<>[2]
		{
			(EqualityComparer<>)obj4,
			(EqualityComparer<>)P_1
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void dvm()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0057: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 572, 1790778558, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = a(MethodBase.GetCurrentMethod(), 0, 1790778558, new IntPtr(2737316777292L), 15);
		}
		((delegate*<void>)obj)();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00簀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00紀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00縀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00缀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00ꠀ()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00꤀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00ꨀ()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_AB00()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00가()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00관()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00글()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00꼀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00뀀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_E100()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_E200()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_E300()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_E400()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_E500()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_EA00()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_EB00()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_EC00()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_ED00()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00䔀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00대()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00촀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00츀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00케()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00퀀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}
}
