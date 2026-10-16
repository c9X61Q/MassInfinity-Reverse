using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WinRT.Mass_WinUIGenericHelpers;

internal static class IEnumerator_object
{
	private static readonly nint _initialized = (int)Init();

	internal static object CheckIsolatedAttribute;

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
		return _FF00_FF00_FF00_FF00_FF00_FF00䀀(thisPtr, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_GetMany_3(nint thisPtr, uint __itemsSize, nint items, uint* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00䜀(thisPtr, __itemsSize, items, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_get_Current_0(nint thisPtr, nint* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00㴀(thisPtr, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_get_HasCurrent_1(nint thisPtr, byte* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00䘀(thisPtr, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateAutomatableAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IEnumerator_object LoadAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00㤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775460, new IntPtr(2737316770012L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte _FF00_FF00_FF00_FF00_FF00_FF00㨀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)/*Error near IL_000d: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00㬀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00㰀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775461, new IntPtr(2737316783532L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00㴀(nint P_0, nint* P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0038: Expected Obj, but got I
		//IL_006a: Expected native int or pointer, but got Obj
		//IL_00e1->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0100->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004f->IL0053: Incompatible stack heights: 1 vs 0
		//IL_00ec->IL0019: Incompatible stack types: I4 vs Obj
		//IL_010b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0077->IL0053: Incompatible stack heights: 1 vs 0
		//IL_0082->IL0053: Incompatible stack heights: 1 vs 0
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
					_ = 1;
				}
				while (true)
				{
					switch ((int)/*Error near IL_0060: Stack underflow*/)
					{
					case 1:
						*(IntPtr*)(nint)obj = (IntPtr)1;
						if (0 == 0)
						{
							_ = 0;
						}
						continue;
					}
					break;
				}
				goto case 1;
			case 2:
				*P_1 = 0;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 1:
				return 0u;
			case 3:
				obj = null;
				if (2 != 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00㸀(nint P_0, nint* P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775458, new IntPtr(2737316775212L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00㼀(nint P_0, byte* P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775459, new IntPtr(2737316770012L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00䀀(nint P_0, byte* P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0057: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I4
		//IL_0101->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0042->IL0019: Incompatible stack heights: 0 vs 1
		//IL_006e->IL0072: Incompatible stack heights: 1 vs 0
		//IL_010c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a3->IL0072: Incompatible stack heights: 1 vs 0
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
				if (2 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				return 0u;
			case 1:
				obj = P_0;
				if (0 == 0)
				{
					_ = 1;
				}
				while (true)
				{
					switch ((int)/*Error near IL_007f: Stack underflow*/)
					{
					case 1:
						*P_1 = ((obj != null) ? ((byte)1) : ((byte)0));
						if (0 == 0)
						{
							_ = 0;
						}
						continue;
					}
					break;
				}
				goto default;
			case 2:
				*P_1 = 0;
				if (true)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00䄀(nint P_0, byte* P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775456, new IntPtr(2737316783532L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00䈀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00䌀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775457, new IntPtr(2737316783532L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00䐀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00䔀(nint P_0, byte* P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775470, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00䘀(nint P_0, byte* P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0038: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I4
		//IL_00fc->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00e2->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004f->IL0053: Incompatible stack heights: 1 vs 0
		//IL_0107->IL0019: Incompatible stack types: I4 vs Obj
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
				if (true)
				{
					_ = 1;
				}
				while (true)
				{
					switch ((int)/*Error near IL_0060: Stack underflow*/)
					{
					case 1:
						*P_1 = ((obj != null) ? ((byte)1) : ((byte)0));
						if (0 == 0)
						{
							_ = 0;
						}
						continue;
					}
					break;
				}
				break;
			case 2:
				obj = 0;
				if (0 == 0)
				{
					obj2 = 1;
				}
				continue;
			case 1:
				*P_1 = 0;
				if (false)
				{
					obj2 = 0;
				}
				continue;
			case 3:
				break;
			}
			break;
		}
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00䜀(nint P_0, uint P_1, nint P_2, uint* P_3)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_00f8: Expected Obj, but got I4
		//IL_0116: Expected Obj, but got I
		//IL_003e: Expected Obj, but got Ref
		//IL_0073: Expected I4, but got Obj
		//IL_012d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0104->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0120->IL0019: Incompatible stack heights: 2 vs 1
		//IL_010f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007f->IL0059: Incompatible stack heights: 0 vs 1
		//IL_009b->IL0059: Incompatible stack heights: 2 vs 1
		//IL_00a6->IL0059: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
			{
				nint num = P_0;
				obj = (object)(&obj);
				if (1 == 0)
				{
					num = 1;
				}
				while (true)
				{
					switch ((int)num)
					{
					default:
						*P_3 = (uint)(int)obj;
						if (0 == 0)
						{
							num = 2;
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
				break;
			}
			case 1:
				obj = 0;
				if (false)
				{
					obj2 = 0;
				}
				continue;
			case 3:
				obj = P_2;
				_ = 4;
				continue;
			default:
				*P_3 = 0u;
				obj2 = 3;
				continue;
			case 2:
				break;
			}
			break;
		}
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00䠀(nint P_0, uint P_1, nint P_2, uint* P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775471, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}
}
