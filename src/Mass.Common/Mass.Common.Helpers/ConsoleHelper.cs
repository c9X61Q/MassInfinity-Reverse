using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Mass.Common.Helpers;

public static class ConsoleHelper
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct CONSOLE_FONT_INFO_EX
	{
		public uint cbSize;

		public uint nFont;

		public COORD dwFontSize;

		public int FontFamily;

		public int FontWeight;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string FaceName;
	}

	private struct COORD
	{
		public short X;

		public short Y;
	}

	internal static ConsoleHelper DecorateIntegratedDecryptor;

	[DllImport("kernel32.dll")]
	private static extern nint GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern int SetWindowLongPtr(nint hWnd, int nIndex, int dwNewLong);

	[DllImport("user32.dll")]
	private static extern int GetWindowLongPtr(nint hWnd, int nIndex);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern nint GetStdHandle(int hConsoleHandle);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool GetCurrentConsoleFontEx(nint hConsoleOutput, bool bMaximumWindow, ref CONSOLE_FONT_INFO_EX lpConsoleCurrentFontEx);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool SetCurrentConsoleFontEx(nint hConsoleOutput, bool bMaximumWindow, ref CONSOLE_FONT_INFO_EX lpConsoleCurrentFontEx);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool GetConsoleMode(nint hConsoleHandle, out uint mode);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool SetConsoleMode(nint hConsoleHandle, uint mode);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DisabledSizeMode()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetFontSize(short x = 8, short y = 16)
	{
		_FF00㐀((ushort)x, (ushort)y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DisableQuickEditMode()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetSize(int width = 160, int height = 40)
	{
		_FF00_3000((uint)width, (uint)height);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetTitle(string title)
	{
		_FF00㴀(title);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Init(bool isDevelopment = false)
	{
		_FF00㬀(isDevelopment ? ((byte)1) : ((byte)0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckLocalError()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ConsoleHelper ChangeCollection()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_2F00(uint P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778462, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_3000(uint P_0, uint P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_008f: Invalid comparison between Unknown and I4
		//IL_0114: Invalid comparison between Unknown and I4
		//IL_0045->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0064->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0050->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0131->IL00af: Incompatible stack heights: 1 vs 0
		//IL_00ab->IL00af: Incompatible stack heights: 1 vs 0
		//IL_013c->IL00af: Incompatible stack heights: 1 vs 0
		//IL_0123->IL00af: Incompatible stack heights: 1 vs 0
		//IL_0124->IL0124: Incompatible stack heights: 0 vs 1
		//IL_014a->IL00af: Incompatible stack heights: 1 vs 0
		//IL_013d->IL013d: Incompatible stack heights: 0 vs 1
		//IL_0155->IL00af: Incompatible stack heights: 1 vs 0
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
				return;
			default:
				if (2 == 0)
				{
					obj2 = 2;
				}
				break;
			case 1:
				if ((int)/*Error near IL_0058: Stack underflow*/ != 0)
				{
					return;
				}
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				return;
			case 2:
				{
					if ((int)/*Error near IL_0094: Stack underflow*/ < (int)P_0)
					{
						if (2 == 0)
						{
							_ = 2;
						}
						goto IL_00af;
					}
					goto IL_0124;
				}
				IL_00af:
				while (true)
				{
					switch ((int)/*Error near IL_00cc: Stack underflow*/)
					{
					case 1:
						return;
					default:
						if ((int)/*Error near IL_0119: Stack underflow*/ >= (int)P_1)
						{
							goto case 3;
						}
						_ = 4;
						continue;
					case 2:
					case 5:
						break;
					case 3:
					case 4:
						if (false)
						{
							_ = 1;
						}
						continue;
					}
					break;
				}
				goto IL_0124;
				IL_0124:
				if (false)
				{
					_ = 0;
				}
				goto IL_00af;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_3100()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778433, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_3200()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_00e9->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00d0->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00f4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00db->IL0019: Incompatible stack types: I4 vs Obj
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
				return;
			case 0:
				return;
			case 1:
			{
				int num = -10;
				_ = ref obj;
				obj &= -65;
				if (false)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
				return;
			}
			case 3:
				if ((int)/*Error near IL_00c4: Stack underflow*/ != 0)
				{
					if (true)
					{
						obj2 = 2;
					}
				}
				else if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_3300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778432, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00㐀(ushort P_0, ushort P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_004a: Expected I4, but got Obj
		//IL_0128: Expected Obj, but got I4
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_00c6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00e2->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0145->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00d1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006c->IL0019: Incompatible stack heights: 7 vs 1
		//IL_00f6->IL0019: Incompatible stack types: I4 vs Ref
		//IL_00a9->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0132->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0108->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0150->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0122->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0077->IL0019: Incompatible stack heights: 7 vs 1
		//IL_00b4->IL0019: Incompatible stack types: I4 vs Ref
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 7;
		ref object reference = ref *(object*)obj;
		while (true)
		{
			switch ((uint)Unsafe.AsPointer(ref reference))
			{
			default:
				return;
			case 5u:
				return;
			case 4u:
				if ((nint)obj == (int)P_1)
				{
					if (5 == 0)
					{
						reference = ref *(object*)1;
					}
					break;
				}
				goto IL_0050;
			case 1u:
				_ = ref obj;
				if (9 != 0)
				{
					_ = 8;
				}
				break;
			case 3u:
				_ = 0;
				_ = ref obj;
				_ = 8;
				break;
			case 2u:
				if ((nint)obj == (int)P_0)
				{
					reference = ref *(object*)4;
					break;
				}
				goto IL_0050;
			case 7u:
				if ((int)/*Error near IL_00fe: Stack underflow*/ != 0)
				{
					return;
				}
				reference = ref *(object*)6;
				break;
			case 10u:
				reference = ref obj;
				if (true)
				{
					reference = ref *(object*)1;
				}
				break;
			case 0u:
				return;
			case 6u:
				obj = -11;
				reference = ref *(object*)10;
				break;
			case 9u:
				_ = 0;
				_ = ref obj;
				if (2 != 0)
				{
					_ = 1;
				}
				break;
			case 8u:
				return;
				IL_0050:
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				if (2 == 0)
				{
					_ = 3;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00㔀(ushort P_0, ushort P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778435, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00㘀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_003f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0053->IL0019: Incompatible stack heights: 0 vs 1
		//IL_007a->IL007e: Incompatible stack heights: 1 vs 0
		//IL_005e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b3->IL007e: Incompatible stack heights: 3 vs 0
		//IL_00be->IL007e: Incompatible stack heights: 3 vs 0
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
				return;
			case 1:
				return;
			case 2:
				if ((int)/*Error near IL_0047: Stack underflow*/ == 0)
				{
					obj2 = 3;
				}
				else if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			case 0:
				return;
			case 3:
				obj = (object)/*Error near IL_0063: Stack underflow*/;
				if (true)
				{
					_ = 1;
				}
				while (true)
				{
					switch ((int)/*Error near IL_008b: Stack underflow*/)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						_ = -16;
						_ = -262160 & -65537;
						if (false)
						{
							_ = 0;
						}
						break;
					}
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00㜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778434, new IntPtr(2737337532524L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00㠀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00㨀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778437, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00㬀(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003e: Expected I4, but got Obj
		//IL_0093: Expected Obj, but got I4
		//IL_00a6->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0065->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0079->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0084->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ce->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0057->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d9->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 1:
					return;
				case 2:
					return;
				case 3:
					if ((int)/*Error near IL_004d: Stack underflow*/ != 0)
					{
						obj2 = 6;
					}
					else if (5 == 0)
					{
						obj2 = 0;
					}
					break;
				case 5:
					_ = 8;
					_ = 16;
					_ = 7;
					break;
				case 7:
					_ = 160;
					_ = 40;
					if (false)
					{
						_ = 0;
					}
					break;
				case 4:
					if (P_0 != 0)
					{
						return;
					}
					goto end_IL_0019;
				default:
					if (0 == 0)
					{
						obj2 = 1;
					}
					break;
				case 6:
					return;
				}
				continue;
				end_IL_0019:
				break;
			}
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00㰀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778436, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00㴀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_005e: Expected I4, but got Obj
		//IL_00cc->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b5->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0051->IL0055: Incompatible stack types: I4 vs Obj
		//IL_00c0->IL0019: Incompatible stack types: I4 vs Obj
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
				return;
			case 3:
			{
				object obj3 = P_0;
				if (false)
				{
					obj3 = 0;
				}
				switch ((int)obj3)
				{
				case 0:
					break;
				}
				return;
			}
			case 2:
				if ((int)/*Error near IL_00a9: Stack underflow*/ == 0)
				{
					if (0 == 0)
					{
						obj2 = 1;
					}
					break;
				}
				return;
			case 0:
				return;
			case 1:
				obj2 = 3;
				break;
			case 4:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00㸀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778439, new IntPtr(2737337532524L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00㼀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}
}
