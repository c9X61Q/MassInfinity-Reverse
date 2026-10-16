using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WinRT.Mass_WinUIGenericHelpers;

internal static class IList_object
{
	private static readonly nint _initialized = (int)Init();

	private static object PatchAttribute;

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
		return _FF00_FF00_FF00_FF00_FF00_FF00氀(thisPtr, index, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_GetView_2(nint thisPtr, nint* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00琀(thisPtr, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_IndexOf_3(nint thisPtr, nint value, uint* index, byte* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00簀(thisPtr, value, index, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private static uint Do_Abi_SetAt_4(nint thisPtr, uint index, nint value)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00紀(thisPtr, index, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private static uint Do_Abi_InsertAt_5(nint thisPtr, uint index, nint value)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00眀(thisPtr, index, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private static uint Do_Abi_RemoveAt_6(nint thisPtr, uint index)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00焀(thisPtr, index);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private static uint Do_Abi_Append_7(nint thisPtr, nint value)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00搀(thisPtr, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private static uint Do_Abi_RemoveAtEnd_8(nint thisPtr)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00栀(thisPtr);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private static uint Do_Abi_Clear_9(nint thisPtr)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00瘀(thisPtr);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_GetMany_10(nint thisPtr, uint startIndex, uint __itemsSize, nint items, uint* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00最(thisPtr, startIndex, __itemsSize, items, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private static uint Do_Abi_ReplaceAll_11(nint thisPtr, uint __itemsSize, nint items)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00爀(thisPtr, __itemsSize, items);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_get_Size_1(nint thisPtr, uint* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00欀(thisPtr, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IList_object ReflectScopeAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00挀(nint P_0, nint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775473, new IntPtr(2737316770012L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint _FF00_FF00_FF00_FF00_FF00_FF00搀(nint P_0, nint P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		switch ((int)obj)
		{
		case 1:
		{
			nint num = P_1;
			if (false)
			{
				num = 0;
			}
			switch ((int)num)
			{
			}
			break;
		}
		}
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00攀(nint P_0, nint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775486, new IntPtr(2737316784572L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00昀(nint P_0, uint P_1, uint P_2, nint P_3, uint* P_4)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775487, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00最(nint P_0, uint P_1, uint P_2, nint P_3, uint* P_4)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0059: Expected Obj, but got Ref
		//IL_012b: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I4
		//IL_008f: Expected I4, but got Obj
		//IL_0137->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0124->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0046->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0142->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0051->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b7->IL0074: Incompatible stack heights: 3 vs 2
		//IL_009b->IL0074: Incompatible stack heights: 1 vs 2
		//IL_00c2->IL0074: Incompatible stack heights: 3 vs 2
		//IL_00a6->IL0074: Incompatible stack heights: 1 vs 2
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
				if (3 == 0)
				{
					obj2 = 3;
				}
				break;
			case 1:
			{
				int num = (int)P_1;
				obj = (object)(&obj);
				if (0 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						*P_4 = (uint)(int)obj;
						if (2 == 0)
						{
							_ = 0;
						}
						continue;
					default:
						if (true)
						{
							_ = 1;
						}
						continue;
					case 2:
						break;
					}
					break;
				}
				goto default;
			}
			default:
				return 0u;
			case 3:
				*P_4 = 0u;
				obj2 = 2;
				break;
			case 2:
				obj = P_3;
				obj2 = P_2;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint _FF00_FF00_FF00_FF00_FF00_FF00栀(nint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		switch ((int)obj)
		{
		case 1:
		{
			nint num = P_0;
			if (0 == 0)
			{
				num = 0;
			}
			switch ((int)num)
			{
			}
			break;
		}
		}
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00椀(nint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775484, new IntPtr(2737316770012L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00樀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00欀(nint P_0, uint* P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_00d2: Expected Obj, but got I4
		//IL_0038: Expected Obj, but got I
		//IL_0069: Expected I4, but got Obj
		//IL_00f8->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00de->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0103->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004f->IL0053: Incompatible stack heights: 1 vs 0
		//IL_0080->IL0053: Incompatible stack heights: 1 vs 0
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
						*P_1 = (uint)(int)obj;
						if (false)
						{
							_ = 0;
						}
						continue;
					}
					break;
				}
				break;
			case 1:
				obj = 0;
				if (false)
				{
					obj2 = 0;
				}
				continue;
			default:
				*P_1 = 0u;
				if (2 == 0)
				{
					obj2 = 2;
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
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00氀(nint P_0, uint P_1, nint* P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0073: Expected Obj, but got I4
		//IL_00a5: Expected native int or pointer, but got Obj
		//IL_0048->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0062->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0053->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006d->IL0019: Incompatible stack types: I4 vs Obj
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
				*P_2 = 0;
				if (2 != 0)
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
			{
				nint num = P_0;
				obj = P_1;
				if (0 == 0)
				{
					num = 1;
				}
				while (true)
				{
					switch ((int)num)
					{
					case 1:
						num = (nint)P_2;
						*(IntPtr*)(nint)obj = (IntPtr)1;
						if (false)
						{
							num = 0;
						}
						continue;
					}
					break;
				}
				goto case 3;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00洀(nint P_0, uint P_1, nint* P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775485, new IntPtr(2737316770012L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00渀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00漀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00瀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775482, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint _FF00_FF00_FF00_FF00_FF00_FF00焀(nint P_0, uint P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		switch ((int)obj)
		{
		case 1:
		{
			int num = (int)P_1;
			if (0 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			break;
		}
		}
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint _FF00_FF00_FF00_FF00_FF00_FF00爀(nint P_0, uint P_1, nint P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		switch ((int)obj)
		{
		case 1:
		{
			nint num = P_2;
			if (false)
			{
				num = 0;
			}
			switch ((int)num)
			{
			}
			break;
		}
		}
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00猀(nint P_0, uint P_1, nint P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775483, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00琀(nint P_0, nint* P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0038: Expected Obj, but got I
		//IL_006a: Expected I, but got Obj
		//IL_00f8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00df->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00ea->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004f->IL0053: Incompatible stack heights: 1 vs 0
		//IL_0081->IL0053: Incompatible stack heights: 1 vs 0
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
				if (true)
				{
					_ = 1;
				}
				while (true)
				{
					switch ((int)/*Error near IL_0060: Stack underflow*/)
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
				break;
			case 2:
				obj = null;
				if (1 == 0)
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
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00甀(nint P_0, nint* P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775480, new IntPtr(2737316770012L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint _FF00_FF00_FF00_FF00_FF00_FF00瘀(nint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		switch ((int)obj)
		{
		case 1:
		{
			nint num = P_0;
			if (0 == 0)
			{
				num = 0;
			}
			switch ((int)num)
			{
			}
			break;
		}
		}
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint _FF00_FF00_FF00_FF00_FF00_FF00眀(nint P_0, uint P_1, nint P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		switch ((int)obj)
		{
		case 1:
		{
			nint num = P_2;
			if (0 == 0)
			{
				num = 0;
			}
			switch ((int)num)
			{
			}
			break;
		}
		}
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00砀(nint P_0, uint P_1, nint P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775481, new IntPtr(2737316775212L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00礀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775430, new IntPtr(2737316783532L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte _FF00_FF00_FF00_FF00_FF00_FF00稀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)/*Error near IL_0015: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00笀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775431, new IntPtr(2737316770012L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00簀(nint P_0, nint P_1, uint* P_2, byte* P_3)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0091: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got Ref
		//IL_0077: Expected Obj, but got I4
		//IL_00dd: Expected I4, but got Obj
		//IL_004a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0064->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0083->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0055->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00fb->IL00c3: Incompatible stack heights: 1 vs 2
		//IL_0106->IL00c3: Incompatible stack heights: 1 vs 2
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
				case 2:
					*P_3 = 0;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 4:
					*P_2 = 0u;
					if (2 != 0)
					{
						obj2 = 2;
					}
					continue;
				case 1:
					return 0u;
				case 5:
					obj = 0;
					if (1 == 0)
					{
						obj2 = 4;
					}
					continue;
				case 3:
				{
					nint num = P_1;
					obj = (object)(&obj);
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
							*P_2 = (uint)(int)obj;
							num = 2;
							continue;
						case 2:
							*P_3 = ((obj != null) ? ((byte)1) : ((byte)0));
							if (1 == 0)
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
				break;
			}
			obj = 0;
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint _FF00_FF00_FF00_FF00_FF00_FF00紀(nint P_0, uint P_1, nint P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		switch ((int)obj)
		{
		case 1:
		{
			nint num = P_2;
			if (false)
			{
				num = 0;
			}
			switch ((int)num)
			{
			}
			break;
		}
		}
		return 0u;
	}
}
