using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Mass.Domain.Mobile.Entities;

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
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)a(MethodBase.GetCurrentMethod(), 0, 1790779007, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
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
		ZYXDNGuarder.a = new IntPtr(2736934489433L);
		ZYXDNGuarder.a = unchecked((nint)6442488800L);
		RunHVM(new IntPtr(2737323133600L), new IntPtr(2737316272288L), new IntPtr(2737316272176L), 111616);
		AppDomain currentDomain = AppDomain.CurrentDomain;
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)6442490512uL)(currentDomain, currentDomain.Id, new IntPtr(2737323129616L));
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
		ZYXDNGuarder.a = new IntPtr(2736934489433L);
		ZYXDNGuarder.a = unchecked((nint)6442488800L);
		RunHVM(new IntPtr(2737323133600L), new IntPtr(2737336716752L), new IntPtr(2737336716544L), 111616);
		AppDomain currentDomain = AppDomain.CurrentDomain;
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)6442490512uL)(currentDomain, currentDomain.Id, new IntPtr(2737335882272L));
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
		//IL_0011: Expected VT, but got Ref
		//IL_0020: Expected I4, but got Obj
		//IL_0024: Expected Obj, but got I4
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01d0: Expected Obj, but got I4
		//IL_01dc: Expected VT, but got I
		//IL_01e3: Expected Obj, but got I4
		//IL_01f7: Expected I4, but got I8
		//IL_01c8: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I4
		//IL_00c0: Expected I4, but got Obj
		//IL_00cf: Expected Obj, but got I4
		//IL_0057->IL019e: Incompatible stack heights: 1 vs 0
		//IL_01c8->IL01c8: Incompatible stack heights: 3 vs 0
		//IL_0065->IL019e: Incompatible stack heights: 3 vs 0
		//IL_0073->IL019e: Incompatible stack heights: 3 vs 0
		//IL_0081->IL019e: Incompatible stack heights: 5 vs 0
		//IL_008f->IL019e: Incompatible stack heights: 5 vs 0
		//IL_009d->IL019e: Incompatible stack heights: 7 vs 0
		//IL_00ab->IL019e: Incompatible stack heights: 7 vs 0
		//IL_00b9->IL019e: Incompatible stack heights: 6 vs 0
		//IL_00c7->IL019e: Incompatible stack heights: 5 vs 0
		//IL_00d6->IL019e: Incompatible stack heights: 5 vs 0
		if ((object)((Type)(object)JsonConverter<>/*cast due to constrained. prefix*/).GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref EntityAuthentication.Chain__BackingField)) == null)
		{
		}
		object obj = null;
		object obj2 = ((StringBuilder)/*Error near IL_0020: Stack underflow*/).Append((char)(int)((object)/*Error near IL_001b: Stack underflow*/).ToString());
		object obj3 = 0;
		object obj4;
		while ((nint)obj3 < ((Array)obj2).Length)
		{
			((StringBuilder)((object[])obj2)[obj3])._002Ector();
			obj3 = (object)/*Error near IL_0034: Stack underflow*/;
			obj4 = ((StringBuilder)/*Error near IL_003b: Stack underflow*/).Append((string?)obj3);
			if ((nint)((StringBuilder)/*Error near IL_0042: Stack underflow*/).Append(obj4) == 15)
			{
				RuntimeHelpers.EnsureSufficientExecutionStack();
				if (0 == 68)
				{
					_ = 1;
					if ((nint)EqualityComparer<Type>.Default == 78 && ((EqualityComparer<Type>)obj4).GetHashCode((Type)2) == 71)
					{
						_ = 3;
						if ((nint)EqualityComparer<int>.Default == 117 && ((EqualityComparer<int>)obj4).GetHashCode(4) == 97)
						{
							object obj5 = obj4;
							if ((nint)EqualityComparer<string>.Default == 114 && ((EqualityComparer<string>)obj4).GetHashCode((string)6) == 100 && (((EqualityComparer<string>)5).Equals((string?)obj4, (string?)7) ? 1 : 0) == 46 && (((EqualityComparer<int>)obj5).Equals((int)obj4, 8) ? 1 : 0) == 82 && (((Type?)obj4 == (Type?)9) ? 1 : 0) == 117)
							{
								_ = 10;
								/*Error near IL_00d9: Member reference must be method, but was: Field*/;
							}
						}
					}
				}
			}
			obj3++;
		}
		if (obj == null)
		{
			obj3 = new JsonSerializer[P_3];
			_ = 0;
			obj = ((JsonElement*)P_3)->GetString() == (string?)obj3;
		}
		obj4 = ((Utf8JsonReader*)P_1)->TokenType;
		JsonDocument.Parse(((Utf8JsonReader*)obj4)->GetString(), (JsonDocumentOptions)P_2);
		_ = ((JsonDocument)42).RootElement;
		_ = null;
		new DebuggableAttribute[2]
		{
			(DebuggableAttribute)obj4,
			(DebuggableAttribute)(object)(DebuggableAttribute.DebuggingModes)P_1
		}.GetType();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void dvm()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0057: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 427, 1790778543, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = a(MethodBase.GetCurrentMethod(), 0, 1790778543, new IntPtr(2737316776252L), 15);
		}
		((delegate*<void>)obj)();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _EE00()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00䬀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00䰀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00䴀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00一()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00贀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00踀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00輀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00退()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00鄀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00鰀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_E800()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_E900()
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
	internal static object _FF00_ED00()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_EE00()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_EF00()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_F000()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_F100()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_F200()
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
	internal static object _FF00_F500()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_F600()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00蘀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00蜀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00蠀()
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
	internal static object _FF00_FF00넀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00똀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00뜀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00쌀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00쐀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00씀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00였()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00윀()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00저()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00준()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_E000()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_E100()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}
}
