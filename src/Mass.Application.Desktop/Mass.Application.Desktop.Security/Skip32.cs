using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Mass.Application.Desktop.Security;

public class Skip32
{
	public const int KeySize = 10;

	public const int BlockSize = 4;

	private object _key;

	private static object _ftable;

	public bool IsNeedReverse;

	internal static Skip32 FilterVerifier;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe Skip32(byte[] key)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778701, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe Skip32(string key, Skip32CipherKeyFormat format)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778700, new IntPtr(2737336617756L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object Reverse(object input, uint start = 0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778746, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe uint Encrypt(uint value)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778725, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe int Encrypt(int value)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778724, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (int)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe byte[] Encrypt(byte[] value)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778727, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (byte[])/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe byte[] Encrypt(byte[] value, int start)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778726, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
		return (byte[])/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe uint Decrypt(uint value)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778721, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe int Decrypt(int value)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778720, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
		return (int)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe byte[] Decrypt(byte[] value)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778723, new IntPtr(2737336620876L), 15))(null, 0, new IntPtr(0L));
		return (byte[])/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe byte[] Decrypt(byte[] value, int start = 0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778722, new IntPtr(2737336635436L), 15))(null, 0, new IntPtr(0L));
		return (byte[])/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object skip32(object key, object input, uint start, byte isEncrypt)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778733, new IntPtr(2737336635436L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	static Skip32()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_001f: Expected I4, but got Obj
		//IL_0053->IL0012: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 1;
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
				_ftable = new byte[256]
				{
					163, 215, 9, 131, 248, 72, 246, 244, 179, 33,
					21, 120, 153, 177, 175, 249, 231, 45, 77, 138,
					206, 76, 202, 46, 82, 149, 217, 30, 78, 56,
					68, 40, 10, 223, 2, 160, 23, 241, 96, 104,
					18, 183, 122, 195, 233, 250, 61, 83, 150, 132,
					107, 186, 242, 99, 154, 25, 124, 174, 229, 245,
					247, 22, 106, 162, 57, 182, 123, 15, 193, 147,
					129, 27, 238, 180, 26, 234, 208, 145, 47, 184,
					85, 185, 218, 133, 63, 65, 191, 224, 90, 88,
					128, 95, 102, 11, 216, 144, 53, 213, 192, 167,
					51, 6, 101, 105, 69, 0, 148, 86, 109, 152,
					155, 118, 151, 252, 178, 194, 176, 254, 219, 32,
					225, 235, 214, 228, 221, 71, 74, 29, 66, 237,
					158, 110, 73, 60, 205, 67, 39, 210, 7, 212,
					222, 199, 103, 24, 137, 203, 48, 31, 141, 198,
					143, 170, 200, 116, 220, 201, 93, 92, 49, 164,
					112, 136, 97, 44, 159, 13, 43, 135, 80, 130,
					84, 100, 38, 125, 3, 64, 52, 75, 28, 115,
					209, 196, 253, 59, 204, 251, 127, 171, 230, 62,
					91, 165, 173, 4, 35, 156, 20, 81, 34, 240,
					41, 121, 113, 126, 255, 140, 14, 226, 12, 239,
					188, 114, 117, 111, 55, 161, 236, 211, 142, 98,
					139, 134, 16, 232, 8, 119, 17, 190, 146, 79,
					36, 197, 50, 54, 157, 207, 243, 166, 187, 172,
					94, 108, 169, 19, 87, 37, 181, 227, 189, 168,
					58, 1, 5, 89, 42, 70
				};
				obj2 = 0;
				if (_003CModule_003E_007Bb8824bbe_002D6cfa_002D4013_002D8120_002Dcb1e84055f2d_007D.m_2f25a4da0ad14a089b13089b3bff794c.m_2be09b9d4a094bd49f9f575b5bb5af2d != 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static bool PlanAnnotation()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778735, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static Skip32 CheckAdvancedSorter()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778734, new IntPtr(2737336634396L), 15))(null, 0, new IntPtr(0L));
		return (Skip32)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_E100()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778729, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_E200()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778728, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_E300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778731, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_E400(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778730, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00_E500(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778709, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00_E600(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778708, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_EC00(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778711, new IntPtr(2737336616716L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_ED00(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778710, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_F300(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778705, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_F400(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778704, new IntPtr(2737336635436L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_F500(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778707, new IntPtr(2737336635436L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_F600(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778706, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00豈(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778717, new IntPtr(2737336628156L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00切(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778716, new IntPtr(2737336630236L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00ﬀ(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778719, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00ﰀ(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778718, new IntPtr(2737336630236L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00_FF00ﴀ(nint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778713, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00_FF00_FE00(nint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778712, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778715, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00Ā(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778714, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00Ȁ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778693, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_0300(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778692, new IntPtr(2737336633356L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00Ѐ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778695, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00Ԁ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778694, new IntPtr(2737336616716L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_0600()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778689, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_0700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778688, new IntPtr(2737336620876L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00_FF00ࠀ(object P_0, object P_1, uint P_2, byte P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778691, new IntPtr(2737336630236L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_0900(object P_0, object P_1, uint P_2, byte P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778690, new IntPtr(2737336620876L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
