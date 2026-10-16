using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WinRT.Mass_WinUIGenericHelpers;

internal static class IEnumerator_System_ComponentModel_INotifyPropertyChanged
{
	private static readonly nint _initialized = (int)Init();

	internal static object RunAttribute;

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
	private unsafe static uint Do_Abi_MoveNext_2(nint thisPtr, byte* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00蘀(thisPtr, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_GetMany_3(nint thisPtr, uint __itemsSize, nint items, uint* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00谀(thisPtr, __itemsSize, items, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_get_Current_0(nint thisPtr, nint* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00茀(thisPtr, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_get_HasCurrent_1(nint thisPtr, byte* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00言(thisPtr, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateDynamicAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IEnumerator_System_ComponentModel_INotifyPropertyChanged DecorateConcreteAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00縀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775428, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte _FF00_FF00_FF00_FF00_FF00_FF00缀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)/*Error near IL_000d: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00耀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00脀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775429, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00舀(nint P_0, nint* P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775426, new IntPtr(2737316783532L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00茀(nint P_0, nint* P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0072: Expected Obj, but got I
		//IL_00a4: Expected I, but got Obj
		//IL_0048->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0062->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0053->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0089->IL008d: Incompatible stack heights: 1 vs 0
		//IL_00bb->IL008d: Incompatible stack heights: 1 vs 0
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				return 0u;
			default:
				*P_1 = 0;
				if (false)
				{
					obj2 = 2;
				}
				break;
			case 1:
				obj = null;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				obj = P_0;
				if (1 == 0)
				{
					_ = 1;
				}
				while (true)
				{
					switch ((int)/*Error near IL_009a: Stack underflow*/)
					{
					case 1:
						*P_1 = (nint)obj;
						if (false)
						{
							_ = 0;
						}
						continue;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00萀(nint P_0, nint* P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775427, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00蔀(nint P_0, byte* P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775424, new IntPtr(2737316784572L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00蘀(nint P_0, byte* P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0038: Expected Obj, but got I
		//IL_00ce: Expected Obj, but got I4
		//IL_00f4->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00da->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004f->IL0053: Incompatible stack heights: 1 vs 0
		//IL_00ff->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0084->IL0053: Incompatible stack heights: 1 vs 0
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
				if (false)
				{
					_ = 0;
				}
				while (true)
				{
					switch ((int)/*Error near IL_0060: Stack underflow*/)
					{
					default:
						*P_1 = ((obj != null) ? ((byte)1) : ((byte)0));
						if (true)
						{
							_ = 1;
						}
						continue;
					case 1:
						break;
					}
					break;
				}
				goto case 3;
			case 3:
				return 0u;
			case 2:
				obj = 0;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			case 1:
				*P_1 = 0;
				if (false)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00蜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775425, new IntPtr(2737316770012L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00蠀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00褀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00言(nint P_0, byte* P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0038: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I4
		//IL_0101->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00e2->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004f->IL0053: Incompatible stack heights: 1 vs 0
		//IL_010c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ed->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0084->IL0053: Incompatible stack heights: 1 vs 0
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
				if (0 == 0)
				{
					_ = 0;
				}
				while (true)
				{
					switch ((int)/*Error near IL_0060: Stack underflow*/)
					{
					default:
						*P_1 = ((obj != null) ? ((byte)1) : ((byte)0));
						if (true)
						{
							_ = 1;
						}
						continue;
					case 1:
						break;
					}
					break;
				}
				goto case 3;
			case 2:
				obj = 0;
				if (0 == 0)
				{
					obj2 = 1;
				}
				break;
			case 3:
				return 0u;
			case 1:
				*P_1 = 0;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00謀(nint P_0, uint P_1, nint P_2, uint* P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775438, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00谀(nint P_0, uint P_1, nint P_2, uint* P_3)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0108: Expected Obj, but got I
		//IL_011a: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got Ref
		//IL_008e: Expected I4, but got Obj
		//IL_0112->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00f6->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0126->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0101->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0131->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007f->IL0059: Incompatible stack heights: 2 vs 1
		//IL_008a->IL0059: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
			{
				nint num = P_0;
				obj = (object)(&obj);
				if (false)
				{
					num = 0;
				}
				while (true)
				{
					switch ((int)num)
					{
					default:
						if (0 == 0)
						{
							_ = 1;
						}
						continue;
					case 1:
						*P_3 = (uint)(int)obj;
						num = 2;
						continue;
					case 2:
						break;
					}
					break;
				}
				goto default;
			}
			case 2:
				*P_3 = 0u;
				if (1 == 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				obj = P_2;
				_ = 4;
				break;
			default:
				return 0u;
			case 3:
				obj = 0;
				if (1 == 0)
				{
					obj2 = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00贀(nint P_0, uint P_1, nint P_2, uint* P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775439, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}
}
