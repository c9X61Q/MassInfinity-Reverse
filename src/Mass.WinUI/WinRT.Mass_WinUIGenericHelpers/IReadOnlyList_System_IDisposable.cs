using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WinRT.Mass_WinUIGenericHelpers;

internal static class IReadOnlyList_System_IDisposable
{
	private static readonly nint _initialized = (int)Init();

	private static object ReflectConnectedAttribute;

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
		return _FF00_FF00_FF00_FF00_FF00_FF00销(thisPtr, index, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_IndexOf_2(nint thisPtr, nint value, uint* index, byte* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00鸀(thisPtr, value, index, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_GetMany_3(nint thisPtr, uint startIndex, uint __itemsSize, nint items, uint* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00鈀(thisPtr, startIndex, __itemsSize, items, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_get_Size_1(nint thisPtr, uint* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00鴀(thisPtr, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool StoreAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IReadOnlyList_System_IDisposable VerifyAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00踀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775436, new IntPtr(2737316783532L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte _FF00_FF00_FF00_FF00_FF00_FF00輀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)/*Error near IL_000d: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00退()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775437, new IntPtr(2737316783532L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00鄀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00鈀(nint P_0, uint P_1, uint P_2, nint P_3, uint* P_4)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_003f: Expected Obj, but got Ref
		//IL_0137: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got I
		//IL_0090: Expected I4, but got Obj
		//IL_0124->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0143->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0109->IL0019: Incompatible stack types: I4 vs Obj
		//IL_012f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_014e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0114->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009c->IL005a: Incompatible stack heights: 1 vs 2
		//IL_0080->IL005a: Incompatible stack heights: 3 vs 2
		//IL_00a7->IL005a: Incompatible stack heights: 1 vs 2
		//IL_008b->IL005a: Incompatible stack heights: 3 vs 2
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
			{
				int num = (int)P_1;
				obj = (object)(&obj);
				if (2 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 2:
						if (false)
						{
							_ = 0;
						}
						continue;
					default:
						*P_4 = (uint)(int)obj;
						if (true)
						{
							_ = 0;
						}
						continue;
					case 1:
						break;
					}
					break;
				}
				goto case 1;
			}
			case 4:
				obj = P_3;
				obj2 = P_2;
				if (0 != 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				*P_4 = 0u;
				if (false)
				{
					obj2 = 4;
				}
				break;
			case 1:
				return 0u;
			case 3:
				obj = 0;
				if (0 == 0)
				{
					obj2 = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00錀(nint P_0, uint P_1, uint P_2, nint P_3, uint* P_4)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775434, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00鐀(nint P_0, uint P_1, nint* P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775435, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00销(nint P_0, uint P_1, nint* P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0039: Expected Obj, but got I4
		//IL_006b: Expected I, but got Obj
		//IL_00d4->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00f3->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00df->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00fe->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0077->IL0054: Incompatible stack heights: 0 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
			{
				nint num = P_0;
				obj = P_1;
				if (false)
				{
					num = 0;
				}
				while (true)
				{
					switch ((int)num)
					{
					default:
						*P_2 = (nint)obj;
						if (0 == 0)
						{
							num = 1;
						}
						continue;
					case 1:
						break;
					}
					break;
				}
				goto case 3;
			}
			default:
				*P_2 = 0;
				if (true)
				{
					obj2 = 2;
				}
				break;
			case 3:
				return 0u;
			case 1:
				obj = null;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00阀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775432, new IntPtr(2737316775212L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00需()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00頀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775433, new IntPtr(2737316773132L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00餀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775446, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00騀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00鬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775447, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00鰀(nint P_0, uint* P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775444, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00鴀(nint P_0, uint* P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0038: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I4
		//IL_0069: Expected I4, but got Obj
		//IL_00de->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00fd->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004f->IL0053: Incompatible stack heights: 1 vs 0
		//IL_00e9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0108->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0080->IL0053: Incompatible stack heights: 1 vs 0
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				obj = P_0;
				if (1 == 0)
				{
					_ = 0;
				}
				while (true)
				{
					switch ((int)/*Error near IL_0060: Stack underflow*/)
					{
					case 1:
						*P_1 = (uint)(int)obj;
						if (0 == 0)
						{
							_ = 0;
						}
						continue;
					}
					break;
				}
				goto case 3;
			case 1:
				*P_1 = 0u;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				return 0u;
			case 2:
				obj = 0;
				if (0 == 0)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00鸀(nint P_0, nint P_1, uint* P_2, byte* P_3)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0065: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got Ref
		//IL_00eb: Expected I4, but got Obj
		//IL_0071->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0090->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0057->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0048->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0062->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00f7->IL00bf: Incompatible stack heights: 1 vs 2
		//IL_0102->IL00bf: Incompatible stack heights: 1 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				obj = 0;
				obj2 = 3;
				break;
			case 3:
				*P_2 = 0u;
				if (false)
				{
					obj2 = 1;
				}
				break;
			default:
				obj = 0;
				if (5 != 0)
				{
					obj2 = 4;
				}
				break;
			case 2:
				return 0u;
			case 1:
				*P_3 = 0;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 5:
			{
				nint num = P_1;
				obj = (object)(&obj);
				if (true)
				{
					num = 1;
				}
				while (true)
				{
					switch ((int)num)
					{
					case 2:
						break;
					default:
						*P_3 = ((obj != null) ? ((byte)1) : ((byte)0));
						num = 2;
						continue;
					case 1:
						*P_2 = (uint)(int)obj;
						if (0 == 0)
						{
							_ = 0;
						}
						continue;
					}
					break;
				}
				goto case 2;
			}
			}
		}
	}
}
