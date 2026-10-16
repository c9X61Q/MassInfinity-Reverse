using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Mass.Application.Desktop.Security;

public class Crc32 : HashAlgorithm
{
	private class SafeProxy
	{
		private readonly object _table;

		internal static object FlushSender;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe SafeProxy()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778624, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void Init(uint poly)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778653, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe uint Append(uint crc, byte[] input, int offset, int length)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778652, new IntPtr(2737336630236L), 15))(null, 0, new IntPtr(0L));
			return (uint)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static bool CheckSortedWriter()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778655, new IntPtr(2737336634396L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static SafeProxy ReflectCombinedDic()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778654, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (SafeProxy)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00_FF00먀(uint P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778649, new IntPtr(2737336630236L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00_FF00묀(uint P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778648, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void _FF00_FF00밀(uint P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778651, new IntPtr(2737336628156L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe uint _FF00_FF00봀(uint P_0, object P_1, uint P_2, uint P_3)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778650, new IntPtr(2737336633356L), 15))(null, 0, new IntPtr(0L));
			return (uint)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe uint _FF00_FF00븀(uint P_0, object P_1, uint P_2, uint P_3)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778629, new IntPtr(2737336628156L), 15))(null, 0, new IntPtr(0L));
			return (uint)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00뼀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778628, new IntPtr(2737336635436L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00쀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778631, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00섀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778630, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00숀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778625, new IntPtr(2737336630236L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	private uint _currentCrc;

	private readonly nint _isBigEndian;

	private static readonly object _proxy = new SafeProxy();

	internal static Crc32 TestMapper;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe Crc32(bool isBigEndian = false)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778642, new IntPtr(2737336630236L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint Append(uint initial, object input, uint offset, uint length)
	{
		return _FF00_FF00_FF00_FF00_FF00였(initial, input, offset, length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint Append(uint initial, object input)
	{
		return _FF00_FF00_FF00_FF00_FF00쌀(initial, input);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static uint Compute(byte[] input, int offset, int length)
	{
		return _FF00_FF00_FF00_FF00_FF00쀀(input, (uint)offset, (uint)length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static uint Compute(byte[] input)
	{
		return _FF00_FF00_FF00_FF00_FF00턀(input);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static uint ComputeAndWriteToEnd(byte[] input, int offset, int length)
	{
		return _FF00_FF00_FF00_FF00_FF00케(input, (uint)offset, (uint)length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static uint ComputeAndWriteToEnd(byte[] input)
	{
		return _FF00_FF00_FF00_FF00_FF00픀(input);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsValidWithCrcAtEnd(byte[] input, int offset, int lengthWithCrc)
	{
		return Crc32._FF00_FF00_FF00_FF00_FF00_FFFD((object)input, (uint)offset, (uint)lengthWithCrc) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsValidWithCrcAtEnd(byte[] input)
	{
		return _FF00_FF00_FF00_FF00_FF00쨀(input) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize()
	{
		this._FF00_FF00_FF00_FF00_FF00_FFFD();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void HashCore(byte[] input, int offset, int length)
	{
		_FF00_FF00_FF00_FF00_FF00팀(input, (uint)offset, (uint)length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override byte[] HashFinal()
	{
		return (byte[])_FF00_FF00_FF00_FF00_FF00_E000();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint AppendInternal(uint initial, object input, uint offset, uint length)
	{
		return _FF00_FF00_FF00_FF00_FF00찀(initial, input, offset, length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool InsertPolicy()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Crc32 CheckInterruptibleContainer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00봀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778660, new IntPtr(2737336633356L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00븀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00뼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778663, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint _FF00_FF00_FF00_FF00_FF00쀀(object P_0, uint P_1, uint P_2)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_ = 0;
		return P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_FF00_FF00섀(object P_0, uint P_1, uint P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778662, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00숀(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778657, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint _FF00_FF00_FF00_FF00_FF00쌀(uint P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0047->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0052->IL0019: Incompatible stack types: I4 vs Obj
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
				throw /*Error near IL_002d: Stack underflow*/;
			case 1:
				if (P_1 != null)
				{
					_ = 0;
					return (uint)((Array)P_1).Length;
				}
				if (false)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint _FF00_FF00_FF00_FF00_FF00였(uint P_0, object P_1, uint P_2, uint P_3)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003e: Expected I4, but got Obj
		//IL_0094->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00b0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0053->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0019: Incompatible stack heights: 0 vs 1
		//IL_007d->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 7;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 7:
				if (P_1 == null)
				{
					obj2 = 6;
					break;
				}
				if ((int)P_2 < 0)
				{
					if (5 == 0)
					{
						obj2 = 3;
					}
					break;
				}
				goto case 2;
			case 3:
			case 4:
			case 5:
				throw /*Error near IL_0056: Stack underflow*/;
			case 1:
				return P_3;
			case 6:
				throw /*Error near IL_005f: Stack underflow*/;
			default:
				if ((int)(P_2 + P_3) <= ((Array)P_1).Length)
				{
					if (0 == 0)
					{
						obj2 = 1;
					}
					break;
				}
				goto case 3;
			case 2:
				if ((int)P_3 < 0)
				{
					obj2 = 4;
					break;
				}
				goto default;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00윀(uint P_0, object P_1, uint P_2, uint P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778656, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00준(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778659, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00쨀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0073->IL0019: Incompatible stack heights: 0 vs 1
		//IL_007e->IL0019: Incompatible stack types: I4 vs Obj
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
				throw /*Error near IL_0033: Stack underflow*/;
			case 1:
				_ = 0;
				_ = 0;
				return (((Array)P_0).Length == 558161692) ? ((byte)1) : ((byte)0);
			case 2:
				if (((Array)P_0).Length >= 4)
				{
					if (1 == 0)
					{
						obj2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00쬀(uint P_0, object P_1, uint P_2, uint P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778658, new IntPtr(2737336616716L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint _FF00_FF00_FF00_FF00_FF00찀(uint P_0, object P_1, uint P_2, uint P_3)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
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
				return P_3;
			case 1:
				return P_0;
			case 2:
				if ((int)P_3 <= 0)
				{
					if (1 == 0)
					{
						obj2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_FF00_FF00츀(object P_0, uint P_1, uint P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778669, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint _FF00_FF00_FF00_FF00_FF00케(object P_0, uint P_1, uint P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0042: Expected I4, but got Obj
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got I4
		//IL_00c6: Expected I4, but got Obj
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got I4
		//IL_00c3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00fe->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0091->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0080->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00dd->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0071->IL0019: Incompatible stack heights: 4 vs 1
		//IL_005c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e8->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 6;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 6:
				if ((int)(P_2 + 4) <= ((Array)P_0).Length)
				{
					obj2 = 5;
					break;
				}
				goto default;
			default:
				throw /*Error near IL_0060: Stack underflow*/;
			case 5:
				_ = 0;
				obj = P_2;
				_ = 4;
				break;
			case 4:
				obj = P_1 + P_2;
				obj2 = 3;
				break;
			case 3:
				((sbyte[])P_0)[obj] = (sbyte)(byte)obj;
				obj2 = 8;
				break;
			case 1:
				((sbyte[])P_0)[obj + 2] = (sbyte)(byte)(obj >> 16);
				obj2 = 2;
				break;
			case 7:
				return (uint)(int)obj;
			case 8:
				((sbyte[])P_0)[obj + 1] = (sbyte)(byte)(obj >> 8);
				if (true)
				{
					obj2 = 0;
				}
				break;
			case 2:
				((sbyte[])P_0)[obj + 3] = (sbyte)(byte)(obj >> 24);
				obj2 = 7;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_FF00_FF00퀀(object P_0, uint P_1, uint P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778668, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint _FF00_FF00_FF00_FF00_FF00턀(object P_0)
	{
		//IL_000b: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_ = 0;
		return (uint)(int)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_FF00_FF00툀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778671, new IntPtr(2737336634396L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _FF00_FF00_FF00_FF00_FF00팀(object P_0, uint P_1, uint P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003f->IL0019: Incompatible stack heights: 5 vs 1
		//IL_004a->IL0019: Incompatible stack heights: 5 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 1:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe void _FF00_FF00_FF00_FF00_FF00퐀(object P_0, uint P_1, uint P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778670, new IntPtr(2737336630236L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint _FF00_FF00_FF00_FF00_FF00픀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0044->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004f->IL0019: Incompatible stack types: I4 vs Obj
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
				if (((Array)P_0).Length >= 4)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				throw /*Error near IL_006f: Stack underflow*/;
			default:
				_ = 0;
				return (uint)(((Array)P_0).Length - 4);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_FF00_FF00혀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778665, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00휀(object P_0, uint P_1, uint P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778664, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FFFD(object P_0, uint P_1, uint P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778667, new IntPtr(2737336630236L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FFFD(object P_0, uint P_1, uint P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778666, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778645, new IntPtr(2737336636476L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778644, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778647, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778646, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778641, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe object _FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778640, new IntPtr(2737336635436L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe object _FF00_FF00_FF00_FF00_FF00_E000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778643, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
