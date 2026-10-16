using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WinRT.Mass_WinUIGenericHelpers;

internal static class IReadOnlyList_System_ComponentModel_INotifyPropertyChanged
{
	private static readonly nint _initialized = (int)Init();

	private static object JoinAttribute;

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
		return _FF00_FF00_FF00_FF00_FF00_FF00倀(thisPtr, index, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_IndexOf_2(nint thisPtr, nint value, uint* index, byte* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00圀(thisPtr, value, index, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_GetMany_3(nint thisPtr, uint startIndex, uint __itemsSize, nint items, uint* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00一(thisPtr, startIndex, __itemsSize, items, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_get_Size_1(nint thisPtr, uint* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00吀(thisPtr, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MoveAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IReadOnlyList_System_ComponentModel_INotifyPropertyChanged CheckSymbolicAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00䤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775468, new IntPtr(2737316772092L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte _FF00_FF00_FF00_FF00_FF00_FF00䨀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)/*Error near IL_000d: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00䬀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00䰀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775469, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00䴀(nint P_0, uint P_1, uint P_2, nint P_3, uint* P_4)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775466, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00一(nint P_0, uint P_1, uint P_2, nint P_3, uint* P_4)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_004b: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I4
		//IL_007d: Expected Obj, but got Ref
		//IL_00d7: Expected Obj, but got I4
		//IL_00b3: Expected I4, but got Obj
		//IL_0055->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0044->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0075->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00bf->IL0098: Incompatible stack heights: 1 vs 2
		//IL_0098->IL0098: Incompatible stack heights: 4 vs 2
		//IL_00ca->IL0098: Incompatible stack heights: 1 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				obj = 0;
				obj2 = 2;
				break;
			case 1:
				obj = P_3;
				_ = 4;
				break;
			default:
				return 0u;
			case 2:
				*P_4 = 0u;
				if (true)
				{
					obj2 = 0;
				}
				break;
			case 4:
			{
				int num = (int)P_1;
				obj = (object)(&obj);
				if (1 == 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					case 2:
						*P_4 = (uint)(int)obj;
						if (0 == 0)
						{
							_ = 0;
						}
						continue;
					case 1:
						obj = 2;
						continue;
					}
					break;
				}
				goto default;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00伀(nint P_0, uint P_1, nint* P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775467, new IntPtr(2737316783532L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00倀(nint P_0, uint P_1, nint* P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0073: Expected Obj, but got I4
		//IL_00a5: Expected I, but got Obj
		//IL_005d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0042->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0068->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b1->IL008e: Incompatible stack heights: 0 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				obj = null;
				if (0 == 0)
				{
					obj2 = 0;
				}
				continue;
			default:
				*P_2 = 0;
				if (2 == 0)
				{
					obj2 = 2;
				}
				continue;
			case 3:
				break;
			case 2:
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
					case 1:
						break;
					default:
						*P_2 = (nint)obj;
						if (1 == 0)
						{
							num = 1;
						}
						continue;
					}
					break;
				}
				break;
			}
			}
			break;
		}
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00儀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00刀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00匀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775464, new IntPtr(2737316770012L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00吀(nint P_0, uint* P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0038: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I4
		//IL_0069: Expected I4, but got Obj
		//IL_00e3->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00fd->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004f->IL0053: Incompatible stack heights: 1 vs 0
		//IL_00ee->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0108->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0080->IL0053: Incompatible stack heights: 1 vs 0
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
				goto case 1;
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
				if (2 == 0)
				{
					obj2 = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00唀(nint P_0, uint* P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775465, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00嘀(nint P_0, nint P_1, uint* P_2, byte* P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775478, new IntPtr(2737316774172L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00圀(nint P_0, nint P_1, uint* P_2, byte* P_3)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0128: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got Ref
		//IL_0066: Expected Obj, but got I4
		//IL_0117: Expected Obj, but got I4
		//IL_0120: Expected Obj, but got I4
		//IL_00bb: Expected I4, but got Obj
		//IL_0134->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_013f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0055->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ac->IL0082: Incompatible stack heights: 2 vs 3
		//IL_00c7->IL0082: Incompatible stack heights: 2 vs 3
		//IL_00b7->IL0082: Incompatible stack heights: 2 vs 3
		//IL_00d2->IL0082: Incompatible stack heights: 2 vs 3
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
					*P_3 = 0;
					if (false)
					{
						obj2 = 0;
					}
					continue;
				case 2:
					return 0u;
				case 4:
					*P_2 = 0u;
					obj = 3;
					break;
				case 1:
					obj = (object)(&obj);
					while (true)
					{
						switch (2)
						{
						case 1:
							break;
						default:
							*P_3 = ((obj != null) ? ((byte)1) : ((byte)0));
							if (0 == 0)
							{
								_ = 1;
							}
							continue;
						case 2:
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
				case 5:
					obj = 0;
					obj = 4;
					break;
				default:
					obj = 0;
					if (true)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}
}
