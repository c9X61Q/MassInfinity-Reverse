using System;
using System.Collections.Generic;
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
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
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
		//IL_001d: Expected Obj, but got I4
		//IL_001e: Expected I4, but got VT
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		_ = 0;
		return (uint)(int)((_003C_003Ef__AnonymousType0<, >)P_2).buy_type;
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
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0049: Expected VT, but got I4
		//IL_0049: Expected VT, but got I4
		//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				throw new EqualityComparer<_00211>();
			case 1:
				if (P_1 != null)
				{
					((_003C_003Ef__AnonymousType0<, >)P_1)._002Ector((_003Corderid_003Ej__TPar)0, (_003Cbuy_type_003Ej__TPar)((Array)P_1).Length);
					return P_0;
				}
				obj2 = 0;
				if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP != null)
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
		//IL_001d: Expected Obj, but got I4
		//IL_004b: Expected I4, but got Obj
		//IL_007f: Expected VT, but got I4
		//IL_0074: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I4
		//IL_00c5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0060->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a6->IL0026: Incompatible stack types: I4 vs Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					obj2 = 5;
					if (DesktopAuthentication.TokenKey == null)
					{
						obj2 = 3;
					}
					break;
				}
				goto case 2;
			case 3:
			case 4:
			case 5:
				throw new EqualityComparer<_00211>((_00211?)/*Error near IL_006a: Stack underflow*/, (_00211?)((_003C_003Ef__AnonymousType0<, >)/*Error near IL_0065: Stack underflow*/).buy_type);
			case 1:
				return ((_003C_003Ef__AnonymousType0<, >)P_2).Equals(P_3) ? 1u : 0u;
			case 6:
				throw new EqualityComparer<_00210>((_00210)((_003C_003Ef__AnonymousType0<, >)/*Error near IL_007a: Stack underflow*/).GetHashCode());
			default:
				if ((int)(P_2 + P_3) <= ((Array)P_1).Length)
				{
					obj2 = 0;
					if (((DesktopAuthentication)DesktopAuthentication._client)._connected == 0)
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
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0057: Expected Obj, but got I4
		//IL_00a0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ab->IL0026: Incompatible stack types: I4 vs Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				((_003C_003Ef__AnonymousType0<, >)/*Error near IL_0046: Stack underflow*/)._002Ector((_003Corderid_003Ej__TPar)/*Error near IL_0046: Stack underflow*/, ((_003C_003Ef__AnonymousType0<, >)/*Error near IL_0041: Stack underflow*/).buy_type);
				throw new EqualityComparer<_00210>();
			case 1:
				_ = 0;
				_ = 0;
				return (((_003C_003Ef__AnonymousType0<, >)((Array)P_0).Length).GetHashCode() == 558161692) ? ((byte)1) : ((byte)0);
			case 2:
				if (((Array)P_0).Length >= 4)
				{
					obj2 = 1;
					if (((DesktopAuthentication)(object)DesktopAuthentication.TokenKey)._client == null)
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
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_004a: Expected VT, but got I4
		//IL_004a: Expected VT, but got I4
		//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0073->IL0026: Incompatible stack types: I4 vs Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				_ = DesktopAuthentication._003CuserId_003EP;
				((_003C_003Ef__AnonymousType0<, >)P_1)._002Ector((_003Corderid_003Ej__TPar)P_2, (_003Cbuy_type_003Ej__TPar)P_3);
				return P_0;
			case 1:
				return P_0;
			case 2:
				if ((int)P_3 <= 0)
				{
					obj2 = 1;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
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
		//IL_001d: Expected Obj, but got I4
		//IL_004f: Expected I4, but got Obj
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got I4
		//IL_00eb: Expected I4, but got Obj
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_00e8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_012b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ae->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008e->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0069->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0115->IL0026: Incompatible stack types: I4 vs Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				((_003C_003Ef__AnonymousType0<, >)/*Error near IL_0073: Stack underflow*/)._002Ector((_003Corderid_003Ej__TPar)/*Error near IL_0073: Stack underflow*/, ((_003C_003Ef__AnonymousType0<, >)/*Error near IL_006e: Stack underflow*/).buy_type);
				throw new EqualityComparer<_00210>();
			case 5:
				_ = 0;
				obj = ((_003C_003Ef__AnonymousType0<, >)P_2).GetHashCode();
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
				obj2 = 1;
				if (((DesktopAuthentication)(object)DesktopAuthentication.TokenKey)._client != null)
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
		//IL_001c: Expected I4, but got VT
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		_ = 0;
		return (uint)(int)((_003C_003Ef__AnonymousType0<, >)P_0).buy_type;
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
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0047: Expected VT, but got I4
		//IL_0047: Expected VT, but got I4
		//IL_0060->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006b->IL0026: Incompatible stack types: I4 vs Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
			{
				object obj3 = ((DesktopAuthentication)(object)this)._003CuserId_003EP;
				((_003C_003Ef__AnonymousType0<, >)P_0)._002Ector((_003Corderid_003Ej__TPar)P_1, (_003Cbuy_type_003Ej__TPar)P_2);
				((DesktopAuthentication)(object)this)._003CgameVersion_003EP = obj3;
				obj2 = 0;
				if (DesktopAuthentication.Crc32 == null)
				{
					obj2 = 0;
				}
				break;
			}
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
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_00a4: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_0059->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					obj2 = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CuserId_003EP)._003CuserToken_003EP == null)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				((_003C_003Ef__AnonymousType0<, >)/*Error near IL_008d: Stack underflow*/).ToString();
				_003C_003Ef__AnonymousType0<, >.ControlDriver();
				throw new object();
			default:
				((DesktopAuthentication)/*Error near IL_00a4: Stack underflow*/)._002Ector((string)/*Error near IL_00a4: Stack underflow*/, (string)P_0, (string)0, (string)(((Array)P_0).Length - 4));
				return (uint)/*Error near IL_00a5: Stack underflow*/;
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
