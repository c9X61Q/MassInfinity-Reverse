using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Mass.Common.Helpers;

public static class CryptoJsAes
{
	public const string Key = "";

	internal static CryptoJsAes CustomizeProfile;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static string Encrypt(string plainText, string password = "lzYW5qaXVqa")
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 121, 1790778438, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778438, new IntPtr(2737337517964L), 15);
		}
		return (string)((delegate*<object, object, object>)obj)(plainText, password);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static string Decrypt(string encryptedText, string password = "lzYW5qaXVqa")
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 122, 1790778441, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778441, new IntPtr(2737337532524L), 15);
		}
		return (string)((delegate*<object, object, object>)obj)(encryptedText, password);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object EvpBytesToKey(uint keySize, uint ivSize, object password, object salt)
	{
		return _FF00ⴀ(keySize, ivSize, password, salt);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectSeparatedInitializer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CryptoJsAes InstantiateSolver()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_2200()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778440, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_2300()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_2400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778443, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_2700(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_004a: Expected I4, but got Obj
		//IL_02ec: Expected Obj, but got I4
		//IL_0313: Expected Obj, but got I4
		//IL_031c: Expected Obj, but got I4
		//IL_035a: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I4
		//IL_0102: Expected I4, but got Obj
		//IL_0132: Expected I4, but got Obj
		//IL_0161: Expected I4, but got Obj
		//IL_0082->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0343->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0326->IL0019: Incompatible stack heights: 7 vs 1
		//IL_005c->IL034e: Incompatible stack heights: 2 vs 0
		//IL_0334->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0303->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0366->IL0019: Incompatible stack heights: 2 vs 1
		//IL_034e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0068->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0386->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0371->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c5->IL00a2: Incompatible stack heights: 1 vs 2
		//IL_0073->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00d0->IL00a2: Incompatible stack heights: 1 vs 2
		//IL_00f5->IL00f9: Incompatible stack types: I4 vs Obj
		//IL_0125->IL0129: Incompatible stack types: I4 vs Obj
		//IL_0154->IL0158: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 9;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 7:
				_ = 0;
				if (8 == 0)
				{
					if (0 == 0)
					{
						_ = 2;
					}
					continue;
				}
				goto case 3;
			case 1:
				obj = P_1;
				obj2 = 6;
				continue;
			case 5:
			{
				int num = 2;
				if (0 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					default:
						obj = obj;
						if (1 == 0)
						{
							_ = 0;
						}
						continue;
					case 1:
						break;
					}
					break;
				}
				object obj3 = obj;
				object obj4 = obj;
				object obj5 = obj;
				obj = 0;
				if (0 == 0)
				{
					obj5 = 0;
				}
				switch ((int)obj5)
				{
				}
				obj = obj;
				if (false)
				{
					obj4 = 0;
				}
				switch ((int)obj4)
				{
				}
				obj = obj;
				if (false)
				{
					obj3 = 0;
				}
				switch ((int)obj3)
				{
				}
				break;
			}
			default:
				obj2 = obj;
				obj = 16;
				if (1 == 0)
				{
					obj2 = 0;
				}
				continue;
			case 6:
				_ = 32;
				_ = 16;
				obj = 32;
				_ = 32;
				obj = 16;
				_ = 4;
				continue;
			case 9:
				obj = P_0;
				obj2 = 8;
				continue;
			case 4:
				obj = (object)/*Error near IL_0337: Stack underflow*/;
				if (5 != 0)
				{
					obj2 = 1;
				}
				continue;
			case 3:
				throw /*Error near IL_0351: Stack underflow*/;
			case 2:
				_ = 8;
				obj = 8;
				if (0 == 0)
				{
					_ = 0;
				}
				continue;
			case 8:
				if (((Array)obj).Length >= 16)
				{
					obj2 = 7;
					continue;
				}
				goto case 3;
			case 10:
				break;
			}
			break;
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_2800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778442, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_2900()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_2A00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778445, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_2B00(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_0057: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got I4
		//IL_00f0: Expected Obj, but got I4
		//IL_0148: Expected Obj, but got I4
		//IL_0091->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0082->IL0019: Incompatible stack heights: 7 vs 1
		//IL_009c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00dd->IL00bc: Incompatible stack heights: 0 vs 2
		//IL_00e8->IL00bc: Incompatible stack heights: 1 vs 2
		//IL_013b->IL0111: Incompatible stack heights: 9 vs 5
		//IL_0154->IL0111: Incompatible stack heights: 8 vs 5
		//IL_015f->IL0111: Incompatible stack heights: 8 vs 5
		//IL_01cb->IL0180: Incompatible stack heights: 8 vs 4
		//IL_01d8->IL0180: Incompatible stack heights: 5 vs 4
		//IL_01ac->IL0180: Incompatible stack heights: 3 vs 4
		//IL_01b7->IL0180: Incompatible stack heights: 3 vs 4
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
				case 3:
					obj = P_1;
					obj2 = 5;
					continue;
				case 4:
					break;
				case 1:
					return obj;
				case 5:
					_ = 32;
					_ = 16;
					obj = 32;
					_ = 32;
					obj = 16;
					_ = 2;
					continue;
				case 2:
					obj = (object)/*Error near IL_0085: Stack underflow*/;
					if (false)
					{
						obj2 = 0;
					}
					continue;
				default:
				{
					object obj3 = obj;
					int num = 2;
					if (0 == 0)
					{
						num = 0;
					}
					while (true)
					{
						switch (num)
						{
						default:
							obj = obj3;
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
					obj = 8;
					_ = ref obj;
					int num2 = 0;
					int num3 = 8;
					if (1 == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							_ = 0;
							_ = ((Array)obj).Length;
							_ = 2;
							continue;
						case 2:
							obj = 1;
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						}
						break;
					}
					obj = P_0;
					if (0 == 0)
					{
						num2 = 0;
					}
					while (true)
					{
						switch (num2)
						{
						case 1:
							break;
						case 3:
							obj = obj;
							if (true)
							{
								_ = 1;
							}
							continue;
						default:
							_ = 0;
							_ = ((Array)obj).Length;
							_ = 2;
							continue;
						case 2:
							_ = 3;
							continue;
						}
						break;
					}
					goto case 1;
				}
				}
				break;
			}
			obj = 8;
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00Ⰰ(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778444, new IntPtr(2737337529404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00ⴀ(uint P_0, uint P_1, object P_2, object P_3)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_0097: Expected Obj, but got I4
		//IL_00dc: Expected I4, but got Obj
		//IL_0117: Expected Obj, but got I4
		//IL_0066->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_008f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0059->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01f1->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00ac->IL00bb: Incompatible stack heights: 0 vs 5
		//IL_01fc->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00dc->IL00e1: Incompatible stack heights: 4 vs 0
		//IL_0103->IL00bb: Incompatible stack types: I4 vs Obj
		//IL_00b7->IL00bb: Incompatible stack heights: 1 vs 5
		//IL_0171->IL00bb: Incompatible stack heights: 9 vs 5
		//IL_013c->IL00bb: Incompatible stack types: I4 vs Obj
		//IL_014d->IL00bb: Incompatible stack heights: 6 vs 5
		//IL_012d->IL00bb: Incompatible stack heights: 7 vs 5
		//IL_017c->IL00bb: Incompatible stack heights: 9 vs 5
		//IL_0158->IL00bb: Incompatible stack heights: 6 vs 5
		//IL_00bb->IL00bb: Incompatible stack heights: 10 vs 5
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			object obj3;
			switch ((int)obj2)
			{
			case 1:
				obj = (object)/*Error near IL_0042: Stack underflow*/;
				if (false)
				{
					obj2 = 0;
				}
				break;
			default:
				obj = (object)/*Error near IL_005c: Stack underflow*/;
				obj2 = 3;
				break;
			case 5:
				obj = (object)/*Error near IL_0085: Stack underflow*/;
				obj2 = 6;
				break;
			case 2:
				return P_0 + P_1;
			case 6:
				if (((Array)obj).Length != 0)
				{
					if (0 == 0)
					{
						_ = 0;
					}
					goto IL_00bb;
				}
				goto IL_00e1;
			case 3:
			case 4:
				goto IL_01da;
				IL_00e1:
				_ = 0;
				_ = ((Array)P_2).Length;
				obj3 = null;
				_ = 0;
				if (1 == 0)
				{
					obj3 = 5;
				}
				goto IL_00bb;
				IL_00bb:
				while (true)
				{
					switch ((int)obj3)
					{
					case 1:
						break;
					case 5:
						_ = 0;
						_ = ((Array)P_3).Length;
						_ = null;
						_ = 0;
						obj = 4;
						continue;
					case 4:
						_ = 0;
						_ = 0;
						_ = 2;
						continue;
					case 2:
						obj = obj;
						obj3 = 3;
						continue;
					case 3:
						if (true)
						{
							_ = 6;
						}
						continue;
					default:
						_ = 0;
						_ = ((Array)obj).Length;
						_ = null;
						_ = 0;
						if (true)
						{
							_ = 1;
						}
						continue;
					case 6:
						goto IL_01da;
					}
					break;
				}
				goto IL_00e1;
				IL_01da:
				if ((nint)obj >= (int)(P_0 + P_1))
				{
					if (2 != 0)
					{
						obj2 = 2;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_2E00(uint P_0, uint P_1, object P_2, object P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778447, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
