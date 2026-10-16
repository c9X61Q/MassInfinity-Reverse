using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WinRT.Mass_WinUIGenericHelpers;

internal static class IReadOnlyList_object
{
	private static readonly nint _initialized = (int)Init();

	private static object ReflectLogicalAttribute;

	internal static bool Initialized
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte Init()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_GetAt_0(nint thisPtr, uint index, nint* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00ꘀ(thisPtr, index, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_IndexOf_2(nint thisPtr, nint value, uint* index, byte* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00관(thisPtr, value, index, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_GetMany_3(nint thisPtr, uint startIndex, uint __itemsSize, nint items, uint* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00ꐀ(thisPtr, startIndex, __itemsSize, items, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_get_Size_1(nint thisPtr, uint* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00_AB00(thisPtr, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectSimpleAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IReadOnlyList_object DecorateControllableAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00鼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775445, new IntPtr(2737316783532L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte _FF00_FF00_FF00_FF00_FF00_FF00ꀀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)/*Error near IL_000d: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00ꄀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00ꈀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775442, new IntPtr(2737316771052L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00ꌀ(nint P_0, uint P_1, uint P_2, nint P_3, uint* P_4)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775443, new IntPtr(2737316775212L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00ꐀ(nint P_0, uint P_1, uint P_2, nint P_3, uint* P_4)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0138: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got Ref
		//IL_00aa: Expected I4, but got Obj
		//IL_0142->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0047->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0061->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0052->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b6->IL008f: Incompatible stack heights: 1 vs 2
		//IL_00d2->IL008f: Incompatible stack heights: 3 vs 2
		//IL_00c1->IL008f: Incompatible stack heights: 1 vs 2
		//IL_00dd->IL008f: Incompatible stack heights: 3 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				*P_4 = 0u;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				obj = 0;
				if (2 == 0)
				{
					obj2 = 1;
				}
				break;
			case 4:
			{
				int num = (int)P_1;
				obj = (object)(&obj);
				if (true)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					default:
						*P_4 = (uint)(int)obj;
						if (true)
						{
							_ = 2;
						}
						continue;
					case 1:
						if (0 == 0)
						{
							_ = 0;
						}
						continue;
					case 2:
						break;
					}
					break;
				}
				goto case 1;
			}
			case 1:
				return 0u;
			default:
				obj = P_3;
				_ = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00ꔀ(nint P_0, uint P_1, uint P_2, nint P_3, uint* P_4)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775440, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00ꘀ(nint P_0, uint P_1, nint* P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0053: Expected Obj, but got I4
		//IL_0085: Expected native int or pointer, but got Obj
		//IL_00ff->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0042->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004d->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				obj = null;
				if (false)
				{
					obj2 = 1;
				}
				break;
			case 3:
			{
				nint num = P_0;
				obj = P_1;
				if (0 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch ((int)num)
					{
					default:
						num = (nint)P_2;
						*(IntPtr*)(nint)obj = (IntPtr)1;
						if (1 == 0)
						{
							num = 1;
						}
						continue;
					case 1:
						break;
					}
					break;
				}
				goto default;
			}
			default:
				return 0u;
			case 1:
				*P_2 = 0;
				obj2 = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_A700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775441, new IntPtr(2737316772092L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00ꠀ()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00꤀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00ꨀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775454, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00_AB00(nint P_0, uint* P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0071: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I4
		//IL_00a2: Expected I4, but got Obj
		//IL_0047->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0061->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0088->IL008c: Incompatible stack heights: 1 vs 0
		//IL_0052->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b9->IL008c: Incompatible stack heights: 1 vs 0
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
				return 0u;
			case 2:
				*P_1 = 0u;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				obj = 0;
				if (true)
				{
					obj2 = 2;
				}
				break;
			default:
				obj = P_0;
				if (false)
				{
					_ = 0;
				}
				while (true)
				{
					switch ((int)/*Error near IL_0099: Stack underflow*/)
					{
					case 1:
						break;
					default:
						*P_1 = (uint)(int)obj;
						if (1 == 0)
						{
							_ = 1;
						}
						continue;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00가(nint P_0, uint* P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775455, new IntPtr(2737316781452L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00관(nint P_0, nint P_1, uint* P_2, byte* P_3)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_004b: Expected Obj, but got I4
		//IL_006b: Expected Obj, but got Ref
		//IL_010e: Expected Obj, but got I4
		//IL_00b2: Expected I4, but got Obj
		//IL_0048->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0057->IL0019: Incompatible stack heights: 0 vs 1
		//IL_011a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0132->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0062->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0125->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a3->IL0079: Incompatible stack heights: 2 vs 3
		//IL_00be->IL0079: Incompatible stack heights: 2 vs 3
		//IL_00ae->IL0079: Incompatible stack heights: 2 vs 3
		//IL_00c9->IL0079: Incompatible stack heights: 2 vs 3
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
				*P_2 = 0u;
				obj2 = 5;
				continue;
			case 1:
				obj = 0;
				if (false)
				{
					obj2 = 0;
				}
				continue;
			case 2:
				obj = (object)(&obj);
				while (true)
				{
					switch (2)
					{
					case 1:
						*P_3 = ((obj != null) ? ((byte)1) : ((byte)0));
						if (0 == 0)
						{
							_ = 0;
						}
						continue;
					case 2:
						*P_2 = (uint)(int)obj;
						if (0 == 0)
						{
							_ = 1;
						}
						continue;
					}
					break;
				}
				break;
			case 4:
				obj = 0;
				if (false)
				{
					obj2 = 2;
				}
				continue;
			case 5:
				*P_3 = 0;
				obj2 = 4;
				continue;
			case 3:
				break;
			}
			break;
		}
		return 0u;
	}
}
