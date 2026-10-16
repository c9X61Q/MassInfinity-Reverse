using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WinRT.Mass_WinUIGenericHelpers;

internal static class IEnumerator_System_IDisposable
{
	private static readonly nint _initialized = (int)Init();

	internal static object ReflectTransferableAttribute;

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
		return _FF00_FF00_FF00_FF00_FF00_FF00딀(thisPtr, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_GetMany_3(nint thisPtr, uint __itemsSize, nint items, uint* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00밀(thisPtr, __itemsSize, items, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_get_Current_0(nint thisPtr, nint* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00눀(thisPtr, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_get_HasCurrent_1(nint thisPtr, byte* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00묀(thisPtr, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecompressAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IEnumerator_System_IDisposable DecorateSortedAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00글()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775452, new IntPtr(2737316773132L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte _FF00_FF00_FF00_FF00_FF00_FF00꼀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)/*Error near IL_000d: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00뀀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00넀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775453, new IntPtr(2737316784572L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00눀(nint P_0, nint* P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0072: Expected Obj, but got I
		//IL_00a4: Expected I, but got Obj
		//IL_0043->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0062->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0089->IL008d: Incompatible stack heights: 1 vs 0
		//IL_004e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00bb->IL008d: Incompatible stack heights: 1 vs 0
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
				*P_1 = 0;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				return 0u;
			case 3:
				obj = null;
				if (2 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				obj = P_0;
				if (true)
				{
					_ = 1;
				}
				while (true)
				{
					switch ((int)/*Error near IL_009a: Stack underflow*/)
					{
					case 1:
						*P_1 = (nint)obj;
						if (0 == 0)
						{
							_ = 0;
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
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00대(nint P_0, nint* P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775450, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00됀(nint P_0, byte* P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775451, new IntPtr(2737316781452L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00딀(nint P_0, byte* P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_00d6: Expected Obj, but got I4
		//IL_0038: Expected Obj, but got I
		//IL_00fa->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e2->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00ed->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004f->IL0053: Incompatible stack heights: 1 vs 0
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
			case 3:
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
				break;
			case 2:
				obj = 0;
				if (true)
				{
					obj2 = 1;
				}
				continue;
			case 1:
				*P_1 = 0;
				obj2 = 3;
				continue;
			}
			break;
		}
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00똀(nint P_0, byte* P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775448, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00뜀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00렀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775449, new IntPtr(2737316771052L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00뤀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00먀(nint P_0, byte* P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775526, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00묀(nint P_0, byte* P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_00d6: Expected Obj, but got I4
		//IL_0038: Expected Obj, but got I
		//IL_00ff->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e2->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00ed->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004f->IL0053: Incompatible stack heights: 1 vs 0
		//IL_0084->IL0053: Incompatible stack heights: 1 vs 0
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
						if (1 == 0)
						{
							_ = 1;
						}
						continue;
					case 1:
						break;
					}
					break;
				}
				goto case 2;
			case 1:
				obj = 0;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				return 0u;
			default:
				*P_1 = 0;
				obj2 = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00밀(nint P_0, uint P_1, nint P_2, uint* P_3)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_010d: Expected Obj, but got I4
		//IL_00e6: Expected Obj, but got I
		//IL_003e: Expected Obj, but got Ref
		//IL_0066: Expected I4, but got Obj
		//IL_00ff->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0119->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00f0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_010a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0124->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0072->IL004c: Incompatible stack heights: 1 vs 2
		//IL_008d->IL004c: Incompatible stack heights: 3 vs 2
		//IL_007d->IL004c: Incompatible stack heights: 1 vs 2
		//IL_0098->IL004c: Incompatible stack heights: 3 vs 2
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
				obj = (object)(&obj);
				while (true)
				{
					switch (2)
					{
					default:
						*P_3 = (uint)(int)obj;
						if (true)
						{
							_ = 1;
						}
						continue;
					case 2:
						if (false)
						{
							_ = 0;
						}
						continue;
					case 1:
						break;
					}
					break;
				}
				goto case 4;
			case 4:
				return 0u;
			case 2:
				obj = P_2;
				_ = 3;
				break;
			default:
				*P_3 = 0u;
				if (1 == 0)
				{
					obj2 = 2;
				}
				break;
			case 1:
				obj = 0;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00봀(nint P_0, uint P_1, nint P_2, uint* P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775527, new IntPtr(2737316784572L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}
}
