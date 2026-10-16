using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Mass.Game.Proxy.Protocols.Heypixel;

public static class HeypixelEncryption
{
	internal static HeypixelEncryption PlanDistributor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string Encrypt(Guid password, string data)
	{
		return (string)_FF00_FF00_FF00_FF00_FF00謀(password, data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static byte[] Encrypt(string password, byte[] data)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 244, 1790778847, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778847, new IntPtr(2737367932764L), 15);
		}
		return (byte[])((delegate*<object, object, object>)obj)(password, data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string Decrypt(Guid password, string data)
	{
		return (string)_FF00_FF00_FF00_FF00_FF00ꌀ(password, data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static byte[] Decrypt(string password, byte[] data)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 246, 1790778846, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778846, new IntPtr(2737367933804L), 15);
		}
		return (byte[])((delegate*<object, object, object>)obj)(password, data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] Unmix(byte[] input, Guid guid)
	{
		return (byte[])_FF00_FF00_FF00_FF00_FF00錀(input, guid);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] Mix(byte[] input, Guid guid)
	{
		return (byte[])_FF00_FF00_FF00_FF00_FF00蔀(input, guid);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetType(Guid guid)
	{
		return (int)_FF00_FF00_FF00_FF00_FF00退(guid);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint Mod(long value, uint modulus)
	{
		return _FF00_FF00_FF00_FF00_FF00騀(value, modulus);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static byte[] Decompress(byte[] byArray)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 251, 1790778841, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778841, new IntPtr(2737367944204L), 15);
		}
		return (byte[])((delegate*<object, object>)obj)(byArray);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckAdvancedResponder()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HeypixelEncryption EnableDispatcher()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00萀(object P_0, Guid P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778840, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00蔀(object P_0, Guid P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_012a: Expected I4, but got Obj
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected Obj, but got Unknown
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected Obj, but got Unknown
		//IL_066d: Expected Obj, but got I4
		//IL_024d: Expected Obj, but got I4
		//IL_0528: Expected Obj, but got I4
		//IL_03c4: Expected Obj, but got I4
		//IL_0451: Expected Obj, but got I4
		//IL_0192: Expected Obj, but got I4
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Expected Obj, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		//IL_069b: Expected I4, but got Unknown
		//IL_0643: Expected Obj, but got VT
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		//IL_0774: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected Obj, but got Unknown
		//IL_0289: Expected Obj, but got I4
		//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Expected Obj, but got Unknown
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected Obj, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_0784: Expected Obj, but got I4
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected Obj, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected Obj, but got Unknown
		//IL_01ac: Expected Obj, but got I4
		//IL_01e1: Expected Obj, but got I4
		//IL_01ea: Expected Obj, but got I4
		//IL_02d4: Expected Obj, but got I4
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected Obj, but got Unknown
		//IL_059f: Expected Obj, but got I4
		//IL_0628: Expected Obj, but got I4
		//IL_0655: Expected Obj, but got I4
		//IL_055a: Expected Obj, but got I4
		//IL_055f: Expected Obj, but got I4
		//IL_0562: Expected Obj, but got I4
		//IL_071a: Expected Obj, but got I4
		//IL_05be: Expected Obj, but got I4
		//IL_0159: Expected Obj, but got I4
		//IL_06a4: Expected Obj, but got I4
		//IL_0222: Expected Obj, but got I4
		//IL_01cb->IL0019: Incompatible stack heights: 6 vs 1
		//IL_023f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_04ac->IL0019: Incompatible stack heights: 0 vs 1
		//IL_058b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_037e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0259->IL0019: Incompatible stack heights: 0 vs 1
		//IL_050b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0532->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03d0->IL0019: Incompatible stack heights: 0 vs 1
		//IL_045d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_019e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_05f9->IL0019: Incompatible stack heights: 0 vs 1
		//IL_018f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_064d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_06ca->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0273->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0206->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0525->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0781->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0295->IL0019: Incompatible stack heights: 0 vs 1
		//IL_06e5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0544->IL0019: Incompatible stack heights: 0 vs 1
		//IL_02e9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04c8->IL0019: Incompatible stack heights: 0 vs 1
		//IL_04e7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0348->IL0019: Incompatible stack heights: 5 vs 1
		//IL_0790->IL0019: Incompatible stack heights: 0 vs 1
		//IL_05dc->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0316->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01b6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0151->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02d9->IL0015: Incompatible stack heights: 5 vs 0
		//IL_048f->IL0019: Incompatible stack heights: 5 vs 1
		//IL_039a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0411->IL0019: Incompatible stack heights: 0 vs 1
		//IL_024a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04b7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0596->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02fc->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0389->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0264->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0516->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03db->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0468->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01a9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0604->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0286->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02b4->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0766->IL0019: Incompatible stack heights: 0 vs 1
		//IL_05ab->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0634->IL0019: Incompatible stack heights: 0 vs 1
		//IL_065f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_056e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0726->IL0019: Incompatible stack heights: 0 vs 1
		//IL_05c8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0163->IL0019: Incompatible stack types: I4 vs Obj
		//IL_06d5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0211->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02a0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_054f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04d3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0746->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01de->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0440->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0353->IL0019: Incompatible stack heights: 5 vs 1
		//IL_079b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05e7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0321->IL0019: Incompatible stack types: I4 vs Obj
		//IL_049a->IL0019: Incompatible stack heights: 5 vs 1
		//IL_03a5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_041c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02bf->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0771->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05b6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_063f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0579->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0731->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0751->IL0019: Incompatible stack types: I4 vs Obj
		//IL_044b->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 31;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				case 60:
					obj = obj;
					obj2 = 12;
					continue;
				case 18:
					return obj;
				case 26:
					obj--;
					obj2 = 41;
					continue;
				case 23:
					obj = 0;
					if (35 == 0)
					{
						obj2 = 26;
					}
					continue;
				case 57:
					obj = 0;
					obj2 = 10;
					continue;
				default:
					_ = obj * 4;
					_ = 4;
					_ = 43;
					continue;
				case 10:
				case 48:
					if (Unsafe.As<object, UIntPtr>(ref obj) >= Unsafe.As<object, UIntPtr>(ref obj))
					{
						obj2 = 18;
						continue;
					}
					goto case 47;
				case 58:
					obj = 1;
					obj = 40;
					break;
				case 22:
					return obj;
				case 5:
					return P_0;
				case 35:
					obj--;
					if (32 == 0)
					{
						obj2 = 15;
					}
					continue;
				case 32:
				case 41:
					if ((nint)obj >= 0)
					{
						obj = 44;
						break;
					}
					goto case 27;
				case 3:
				case 15:
					((sbyte[])obj)[obj] = (sbyte)((byte[])P_0)[((int[])obj)[obj]];
					if (39 != 0)
					{
						obj2 = 33;
					}
					continue;
				case 12:
					obj = 0;
					if (16 == 0)
					{
						obj2 = 6;
					}
					continue;
				case 34:
					obj = obj;
					obj2 = 14;
					continue;
				case 25:
				case 40:
					if (Unsafe.As<object, UIntPtr>(ref obj) < Unsafe.As<object, UIntPtr>(ref obj))
					{
						obj2 = 9;
						continue;
					}
					goto case 28;
				case 38:
					obj = 0;
					if (63 == 0)
					{
						obj2 = 2;
					}
					continue;
				case 27:
					if ((nint)obj > 0)
					{
						if (64 != 0)
						{
							obj2 = 19;
						}
						continue;
					}
					goto case 62;
				case 61:
					_ = 0;
					_ = obj - obj;
					obj = 50;
					break;
				case 43:
					obj += 4;
					obj2 = 26;
					continue;
				case 7:
				case 63:
					if (Unsafe.As<object, UIntPtr>(ref obj) < Unsafe.As<object, UIntPtr>(ref obj))
					{
						obj2 = 19;
						continue;
					}
					goto case 21;
				case 9:
				case 56:
				{
					object obj3 = obj;
					object obj4 = obj;
					obj = obj4 + 1;
					((sbyte[])obj3)[obj4] = (sbyte)((byte[])P_0)[obj];
					if (2 == 0)
					{
						obj2 = 6;
					}
					continue;
				}
				case 50:
					_ = 0;
					_ = obj - obj;
					if (53 == 0)
					{
						_ = 38;
					}
					continue;
				case 8:
				case 19:
					((sbyte[])obj)[obj] = (sbyte)(byte)(((byte[])P_0)[obj] ^ 0xA5);
					if (4 == 0)
					{
						obj2 = 4;
					}
					continue;
				case 65:
					obj = obj;
					if (9 == 0)
					{
						obj2 = 57;
					}
					continue;
				case 16:
					obj = 0;
					if (52 == 0)
					{
						obj2 = 40;
					}
					continue;
				case 1:
				case 66:
				{
					object obj5 = obj;
					object obj6 = obj;
					obj = obj6 + 1;
					((sbyte[])obj5)[obj6] = (sbyte)((byte[])P_0)[obj];
					if (true)
					{
						obj2 = 37;
					}
					continue;
				}
				case 49:
				case 59:
					if (Unsafe.As<object, UIntPtr>(ref obj) < Unsafe.As<object, UIntPtr>(ref obj))
					{
						if (4 == 0)
						{
							obj2 = 15;
						}
						continue;
					}
					goto case 22;
				case 20:
					obj = ((byte[])P_0)[obj];
					if (22 != 0)
					{
						obj2 = 33;
					}
					continue;
				case 64:
					_ = obj * 4;
					if (62 == 0)
					{
						_ = 32;
					}
					continue;
				case 4:
					obj++;
					if (1 == 0)
					{
						obj2 = 7;
					}
					continue;
				case 45:
					obj = obj;
					if (51 == 0)
					{
						obj2 = 39;
					}
					continue;
				case 47:
					((sbyte[])obj)[obj] = (sbyte)((byte[])P_0)[obj];
					obj2 = 42;
					continue;
				case 13:
					obj = obj;
					if (11 == 0)
					{
						obj2 = 45;
					}
					continue;
				case 36:
					obj = obj;
					obj2 = 61;
					continue;
				case 14:
					obj = 0;
					obj2 = 2;
					continue;
				case 42:
					obj++;
					if (36 == 0)
					{
						obj2 = 48;
					}
					continue;
				case 21:
					return obj;
				case 6:
					obj += 2;
					if (25 != 0)
					{
						obj2 = 1;
					}
					continue;
				case 17:
					goto IL_0596;
				case 55:
					return obj;
				case 54:
					obj = obj % 5 + 1;
					if (36 == 0)
					{
						obj2 = 30;
					}
					continue;
				case 24:
					obj++;
					if (29 == 0)
					{
						obj2 = 19;
					}
					continue;
				case 28:
					return obj;
				case 31:
					obj = P_1;
					obj2 = 30;
					continue;
				case 53:
					return obj;
				case 11:
					obj = obj;
					obj = 38;
					break;
				case 30:
					switch (obj - 1)
					{
					case 7:
						break;
					case 4:
						goto IL_0552;
					case 0:
						goto IL_0596;
					case 1:
						goto IL_059a;
					case 6:
						goto IL_05b9;
					case 2:
						goto IL_0623;
					case 3:
						goto IL_0650;
					default:
						goto IL_069b;
					case 5:
						goto IL_0715;
					}
					obj = ((Array)P_0).Length;
					obj2 = 13;
					continue;
				case 33:
					((sbyte[])obj)[obj] = (sbyte)(byte)(((obj >> 4) & 0xF) | ((obj & 0xF) << 4));
					if (9 != 0)
					{
						obj2 = 24;
					}
					continue;
				case 39:
					obj++;
					obj2 = 49;
					continue;
				case 62:
					return obj;
				case 46:
				case 52:
					if (Unsafe.As<object, UIntPtr>(ref obj) < Unsafe.As<object, UIntPtr>(ref obj))
					{
						if (true)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 58;
				case 2:
				case 29:
					if (Unsafe.As<object, UIntPtr>(ref obj) >= Unsafe.As<object, UIntPtr>(ref obj))
					{
						if (55 != 0)
						{
							obj2 = 22;
						}
						continue;
					}
					goto case 20;
				case 37:
					obj += 2;
					obj2 = 46;
					continue;
				case 51:
					{
						obj = 0;
						if (59 == 0)
						{
							obj2 = 15;
						}
						continue;
					}
					IL_0715:
					obj = ((Array)P_0).Length;
					if (31 == 0)
					{
						obj2 = 34;
					}
					continue;
					IL_069b:
					obj = 5;
					break;
					IL_0650:
					obj = ((Array)P_0).Length;
					obj2 = 11;
					continue;
					IL_0623:
					obj = ((Array)P_0).Length;
					if (54 == 0)
					{
						obj2 = 15;
					}
					continue;
					IL_05b9:
					obj = ((Array)P_0).Length;
					obj2 = 65;
					continue;
					IL_059a:
					obj = ((Array)P_0).Length;
					if (60 != 0)
					{
						obj2 = 18;
					}
					continue;
					IL_0552:
					num = ((Array)P_0).Length;
					obj = num / 4;
					obj = num % 4;
					obj = num;
					if (23 != 0)
					{
						obj2 = 13;
					}
					continue;
					IL_0596:
					return P_0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00蘀(object P_0, Guid P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778843, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00蠀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0064: Expected Obj, but got I4
		//IL_0068: Expected Obj, but got I4
		//IL_0098: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I4
		//IL_0085: Expected Obj, but got I4
		//IL_010e: Expected Obj, but got I4
		//IL_0132: Expected I4, but got Obj
		//IL_0140: Expected Obj, but got I4
		//IL_0164: Expected I4, but got Obj
		//IL_01a0: Expected I4, but got Obj
		//IL_004a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0074->IL0019: Incompatible stack heights: 4 vs 1
		//IL_00a6->IL0015: Incompatible stack heights: 1 vs 0
		//IL_008f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0055->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007f->IL0019: Incompatible stack heights: 4 vs 1
		//IL_00e4->IL00b9: Incompatible stack heights: 4 vs 3
		//IL_00ff->IL00b9: Incompatible stack heights: 4 vs 3
		//IL_0125->IL0129: Incompatible stack types: I4 vs Obj
		//IL_00ef->IL00b9: Incompatible stack heights: 4 vs 3
		//IL_010a->IL00b9: Incompatible stack heights: 4 vs 3
		//IL_0157->IL015b: Incompatible stack types: I4 vs Obj
		//IL_0180->IL018f: Incompatible stack types: I4 vs Obj
		//IL_018b->IL018f: Incompatible stack types: I4 vs Obj
		//IL_01ce->IL018f: Incompatible stack types: I4 vs Obj
		//IL_01bf->IL018f: Incompatible stack types: I4 vs Obj
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
					obj = (object)/*Error near IL_003e: Stack underflow*/;
					if (false)
					{
						obj2 = 0;
					}
					continue;
				case 2:
					_ = 1000;
					obj = 8;
					obj = 8;
					if (1 == 0)
					{
						_ = 1;
					}
					continue;
				case 4:
					obj = 8;
					_ = 3;
					continue;
				case 5:
					break;
				case 3:
					goto end_IL_0019;
				default:
				{
					object obj3 = obj;
					while (true)
					{
						switch (2)
						{
						case 1:
							obj = obj;
							if (false)
							{
								_ = 0;
							}
							continue;
						case 2:
							_ = 2;
							if (true)
							{
								_ = 1;
							}
							continue;
						}
						break;
					}
					obj = 1;
					if (false)
					{
						obj3 = 0;
					}
					switch ((int)obj3)
					{
					}
					object obj4 = obj;
					obj = 1;
					if (false)
					{
						obj4 = 0;
					}
					switch ((int)obj4)
					{
					}
					_ = 0;
					object obj5 = ((Array)obj).Length;
					if (1 == 0)
					{
						obj5 = 0;
					}
					while (true)
					{
						switch ((int)obj5)
						{
						case 2:
							break;
						case 1:
							obj5 = obj;
							if (false)
							{
								obj5 = 0;
							}
							continue;
						default:
							obj = obj;
							obj5 = 2;
							continue;
						}
						break;
					}
					break;
				}
				}
				return obj;
				continue;
				end_IL_0019:
				break;
			}
			obj = 8;
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00褀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778842, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00言(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_005a: Expected I4, but got Obj
		//IL_017b: Expected I4, but got Obj
		//IL_017a: Expected native int or pointer, but got Obj
		//IL_0154: Expected I4, but got Obj
		//IL_0153: Expected native int or pointer, but got Obj
		//IL_015d: Expected Obj, but got I4
		//IL_0066: Expected Obj, but got I4
		//IL_013b: Expected Obj, but got I4
		//IL_0121: Expected Obj, but got I4
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_0082: Expected Obj, but got I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_010c: Expected Obj, but got I4
		//IL_0115: Expected Obj, but got I4
		//IL_00fa: Expected Obj, but got I4
		//IL_0176->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0187->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0072->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0140->IL0015: Incompatible stack heights: 1 vs 0
		//IL_012b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01a2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0104->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0192->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e9->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0099->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00f4->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 14;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 5:
					obj = ((int[])obj)[obj];
					if (3 == 0)
					{
						obj2 = 2;
					}
					continue;
				case 10:
					obj = P_0 - 1;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 4:
				case 12:
					obj2 = obj;
					obj++;
					if (true)
					{
						obj2 = 0;
					}
					continue;
				default:
					if ((nint)obj > 0)
					{
						if (4 != 0)
						{
							obj2 = 2;
						}
						continue;
					}
					goto case 11;
				case 14:
					_ = 0;
					obj = P_0;
					_ = 13;
					continue;
				case 13:
					obj = 1592639215;
					obj = 10;
					break;
				case 8:
					obj = ((int[])obj)[obj];
					obj2 = 5;
					continue;
				case 6:
					obj = obj;
					obj = 8;
					break;
				case 3:
					*(int*)(nint)obj = (int)obj;
					obj = 2;
					break;
				case 11:
					return obj;
				case 1:
					obj = obj;
					_ = 6;
					continue;
				case 2:
					*(int*)(nint)obj = (int)obj;
					if (9 == 0)
					{
						obj2 = 3;
					}
					continue;
				case 9:
					obj--;
					obj2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00謀(Guid P_0, object P_1)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_ = ref P_0;
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00谀(Guid P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778837, new IntPtr(2737367936924L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00贀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_003f: Expected Obj, but got I4
		//IL_0332: Expected Obj, but got I4
		//IL_0336: Expected Obj, but got I4
		//IL_033f: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I4
		//IL_0124: Expected I4, but got Obj
		//IL_015e: Expected I4, but got Obj
		//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0318->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0344->IL0015: Incompatible stack heights: 4 vs 0
		//IL_0309->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0323->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009f->IL0079: Incompatible stack heights: 3 vs 2
		//IL_00bf->IL0079: Incompatible stack heights: 3 vs 2
		//IL_00aa->IL0079: Incompatible stack heights: 3 vs 2
		//IL_00ca->IL0079: Incompatible stack heights: 3 vs 2
		//IL_00e5->IL00e9: Incompatible stack heights: 1 vs 0
		//IL_0117->IL011b: Incompatible stack types: I4 vs Obj
		//IL_013e->IL014d: Incompatible stack types: I4 vs Obj
		//IL_0149->IL014d: Incompatible stack types: I4 vs Obj
		//IL_0190->IL014d: Incompatible stack heights: 6 vs 5
		//IL_017d->IL014d: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 1:
					obj = 8;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 3:
					return obj;
				case 2:
				{
					object obj3 = obj;
					int num = 1;
					if (0 == 0)
					{
						num = 0;
					}
					while (true)
					{
						switch (num)
						{
						default:
							_ = 2;
							if (false)
							{
								_ = 1;
							}
							continue;
						case 1:
							obj = obj;
							if (2 == 0)
							{
								_ = 1;
							}
							continue;
						case 2:
							break;
						}
						break;
					}
					obj = obj3;
					if (0 == 0)
					{
						_ = 0;
					}
					switch ((int)/*Error near IL_00f2: Stack underflow*/)
					{
					}
					object obj4 = obj;
					obj = 1;
					if (false)
					{
						obj4 = 0;
					}
					switch ((int)obj4)
					{
					}
					_ = 0;
					object obj5 = ((Array)P_1).Length;
					if (0 != 0)
					{
						obj5 = 0;
					}
					while (true)
					{
						switch ((int)obj5)
						{
						case 2:
							break;
						default:
							obj5 = obj;
							if (true)
							{
								obj5 = 1;
							}
							continue;
						case 1:
							obj = obj;
							_ = 2;
							continue;
						}
						break;
					}
					goto case 3;
				}
				default:
					obj2 = obj;
					if (5 != 0)
					{
						obj2 = 3;
					}
					continue;
				case 4:
					obj = (object)/*Error near IL_030c: Stack underflow*/;
					if (0 == 0)
					{
						obj2 = 2;
					}
					continue;
				case 5:
					break;
				}
				break;
			}
			_ = 1000;
			obj = 8;
			obj = 8;
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00踀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778836, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_FF00_FF00輀(Guid P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778839, new IntPtr(2737367947324L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint _FF00_FF00_FF00_FF00_FF00退(Guid P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0031: Expected Obj, but got VT
		//IL_0034: Expected Obj, but got VT
		//IL_0040->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004b->IL0019: Incompatible stack types: I4 vs Obj
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
				obj = P_0;
				obj = P_0;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				_ = obj ^ obj;
				return 8u;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_FF00_FF00鄀(Guid P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778838, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00鈀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0051: Expected Obj, but got I4
		//IL_0075: Expected I4, but got Obj
		//IL_00d5: Expected I4, but got Obj
		//IL_003f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0068->IL006c: Incompatible stack types: I4 vs Obj
		//IL_004a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0095->IL0099: Incompatible stack heights: 1 vs 0
		//IL_00c4->IL00c8: Incompatible stack types: I4 vs Obj
		//IL_00eb->IL00c8: Incompatible stack heights: 1 vs 2
		//IL_00f6->IL00c8: Incompatible stack heights: 1 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				obj = P_0;
				if (1 == 0)
				{
					obj2 = 0;
				}
				continue;
			case 1:
			{
				object obj3 = obj;
				obj = 0;
				if (0 == 0)
				{
					obj3 = 0;
				}
				switch ((int)obj3)
				{
				}
				obj = (object)/*Error near IL_007e: Stack underflow*/;
				if (false)
				{
					_ = 0;
				}
				switch ((int)/*Error near IL_00a2: Stack underflow*/)
				{
				}
				object obj4 = obj;
				if (0 == 0)
				{
					obj4 = 0;
				}
				while (true)
				{
					switch ((int)obj4)
					{
					default:
						obj = obj;
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
				break;
			}
			}
			break;
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00錀(object P_0, Guid P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_010e: Expected I4, but got Obj
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected I4, but got Unknown
		//IL_03b3: Expected Obj, but got VT
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected Obj, but got I4
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_04a5: Expected Obj, but got I4
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Expected Obj, but got Unknown
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected Obj, but got I4
		//IL_0552: Expected Obj, but got I4
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected Obj, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected Obj, but got Unknown
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected Obj, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected Obj, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected Obj, but got Unknown
		//IL_0562: Expected Obj, but got I4
		//IL_017b: Expected Obj, but got I4
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_05f6: Expected Obj, but got I4
		//IL_03a5: Expected Obj, but got I4
		//IL_03fa: Expected Obj, but got I4
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected Obj, but got I4
		//IL_04ce: Expected Obj, but got I4
		//IL_04d2: Expected Obj, but got I4
		//IL_0615: Expected Obj, but got I4
		//IL_0255: Expected Obj, but got I4
		//IL_0662: Expected Obj, but got I4
		//IL_0667: Expected Obj, but got I4
		//IL_066a: Expected Obj, but got I4
		//IL_02df: Expected Obj, but got I4
		//IL_02c0: Expected Obj, but got I4
		//IL_0267: Expected Obj, but got I4
		//IL_0196: Expected Obj, but got I4
		//IL_03bf->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0590->IL0019: Incompatible stack types: I4 vs Obj
		//IL_015b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05f3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0131->IL0019: Incompatible stack heights: 0 vs 1
		//IL_016d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_04b1->IL0019: Incompatible stack heights: 0 vs 1
		//IL_057c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_06ac->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0220->IL0019: Incompatible stack heights: 6 vs 1
		//IL_0524->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04a2->IL0015: Incompatible stack heights: 5 vs 0
		//IL_055c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0301->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01dd->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0423->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0324->IL0019: Incompatible stack heights: 5 vs 1
		//IL_038f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04fb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0241->IL0019: Incompatible stack heights: 0 vs 1
		//IL_03ec->IL0019: Incompatible stack heights: 0 vs 1
		//IL_03da->IL0019: Incompatible stack types: I4 vs Obj
		//IL_056c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0185->IL0019: Incompatible stack types: I4 vs Obj
		//IL_037f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0602->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0630->IL0019: Incompatible stack heights: 0 vs 1
		//IL_03af->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05de->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0406->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01f7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0533->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02ad->IL0019: Incompatible stack heights: 5 vs 1
		//IL_0452->IL0019: Incompatible stack heights: 0 vs 1
		//IL_05c4->IL0019: Incompatible stack heights: 0 vs 1
		//IL_04de->IL0019: Incompatible stack heights: 0 vs 1
		//IL_061f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_025f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0674->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02e9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02cc->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0273->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0364->IL0019: Incompatible stack heights: 0 vs 1
		//IL_03ca->IL0019: Incompatible stack types: I4 vs Obj
		//IL_013c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0178->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04bc->IL0019: Incompatible stack types: I4 vs Obj
		//IL_06b7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05a5->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0296->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0441->IL0019: Incompatible stack types: I4 vs Obj
		//IL_030c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01e8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_042e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_032f->IL0019: Incompatible stack heights: 5 vs 1
		//IL_024c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03f7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01cb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_060d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_020a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_063b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03a2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0411->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02b8->IL0019: Incompatible stack heights: 5 vs 1
		//IL_045d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05cf->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04e9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02d7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_027e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_036f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05b0->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 9:
					obj = 0;
					if (25 != 0)
					{
						obj2 = 18;
					}
					continue;
				case 6:
					obj++;
					obj2 = 41;
					continue;
				case 10:
					obj++;
					if (16 == 0)
					{
						obj2 = 49;
					}
					continue;
				case 42:
					obj = 0;
					obj2 = 39;
					continue;
				case 32:
					if ((nint)obj > 0)
					{
						obj = 23;
						break;
					}
					goto case 36;
				case 22:
				case 41:
					if ((nint)obj >= ((Array)P_0).Length)
					{
						obj2 = 5;
						continue;
					}
					goto case 16;
				case 28:
					obj--;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 56:
					obj = obj;
					obj2 = 42;
					continue;
				case 25:
				case 46:
					if (Unsafe.As<object, UIntPtr>(ref obj) < Unsafe.As<object, UIntPtr>(ref obj))
					{
						obj2 = 54;
						continue;
					}
					goto case 50;
				case 17:
					_ = obj - obj;
					_ = 0;
					_ = 30;
					continue;
				case 34:
					((sbyte[])obj)[obj] = (sbyte)(byte)(((obj >> 4) & 0xF) | ((obj & 0xF) << 4));
					if (15 != 0)
					{
						obj2 = 5;
					}
					continue;
				case 11:
					return obj;
				case 13:
					return obj;
				case 55:
					return obj;
				case 26:
					return P_0;
				case 8:
				case 19:
					if (Unsafe.As<object, UIntPtr>(ref obj) >= Unsafe.As<object, UIntPtr>(ref obj))
					{
						obj2 = 55;
						continue;
					}
					goto case 27;
				case 58:
					_ = obj * 4;
					_ = 4;
					if (28 == 0)
					{
						_ = 37;
					}
					continue;
				case 44:
					return obj;
				case 36:
					return obj;
				case 27:
					((sbyte[])obj)[((int[])obj)[obj]] = (sbyte)((byte[])P_0)[obj];
					if (7 != 0)
					{
						obj2 = 31;
					}
					continue;
				case 30:
					_ = 0;
					_ = obj - obj;
					if (6 != 0)
					{
						_ = 11;
					}
					continue;
				case 2:
					switch (obj - 1)
					{
					case 3:
						obj = ((Array)P_0).Length;
						obj2 = 14;
						continue;
					case 7:
						obj = ((Array)P_0).Length;
						if (9 == 0)
						{
							obj2 = 47;
						}
						continue;
					case 6:
						obj = ((Array)P_0).Length;
						if (25 != 0)
						{
							obj2 = 57;
						}
						continue;
					case 5:
						obj = ((Array)P_0).Length;
						obj2 = 56;
						continue;
					default:
						if (15 != 0)
						{
							obj2 = 26;
						}
						continue;
					case 0:
						break;
					case 1:
					{
						int num2 = ((Array)P_0).Length;
						obj = num2;
						obj = (num2 + 1) / 2;
						obj = num2 / 2;
						if (9 != 0)
						{
							obj2 = 5;
						}
						continue;
					}
					case 2:
						obj = ((Array)P_0).Length;
						obj2 = 33;
						continue;
					case 4:
					{
						int num = ((Array)P_0).Length;
						obj = num / 4;
						obj = num % 4;
						obj = num;
						obj2 = 24;
						continue;
					}
					}
					goto case 1;
				case 43:
					obj++;
					obj2 = 46;
					continue;
				case 31:
					obj++;
					obj2 = 19;
					continue;
				case 12:
				case 49:
					if (Unsafe.As<object, UIntPtr>(ref obj) >= Unsafe.As<object, UIntPtr>(ref obj))
					{
						obj2 = 13;
						continue;
					}
					goto case 4;
				case 50:
					obj = 0;
					obj2 = 53;
					continue;
				case 3:
					obj = P_1;
					if (2 != 0)
					{
						obj2 = 2;
					}
					continue;
				case 37:
					obj += 4;
					obj2 = 28;
					continue;
				case 35:
					obj--;
					if (14 != 0)
					{
						obj2 = 38;
					}
					continue;
				case 52:
					obj = 0;
					if (8 != 0)
					{
						obj2 = 8;
					}
					continue;
				case 29:
					obj++;
					if (17 != 0)
					{
						obj2 = 18;
					}
					continue;
				case 21:
				case 39:
					if (Unsafe.As<object, UIntPtr>(ref obj) >= Unsafe.As<object, UIntPtr>(ref obj))
					{
						obj2 = 44;
						continue;
					}
					goto case 40;
				case 59:
					obj = obj;
					if (9 != 0)
					{
						obj2 = 17;
					}
					continue;
				case 23:
					_ = obj * 4;
					obj = 36;
					break;
				case 14:
					obj = 0;
					if (16 != 0)
					{
						obj2 = 22;
					}
					continue;
				case 1:
					return P_0;
				case 33:
					obj = obj % 5 + 1;
					obj2 = 59;
					continue;
				case 20:
					((sbyte[])obj)[obj * 2 + 1] = (sbyte)((byte[])P_0)[(object)(obj + obj)];
					obj2 = 29;
					continue;
				case 57:
					obj = obj;
					obj2 = 45;
					continue;
				case 24:
					obj = 0;
					obj2 = 35;
					continue;
				case 40:
					obj = ((byte[])P_0)[obj];
					obj2 = 34;
					continue;
				case 15:
					obj++;
					obj2 = 21;
					continue;
				case 4:
					((sbyte[])obj)[obj] = (sbyte)((byte[])P_0)[obj];
					obj2 = 10;
					continue;
				case 18:
				case 53:
					if (Unsafe.As<object, UIntPtr>(ref obj) >= Unsafe.As<object, UIntPtr>(ref obj))
					{
						if (48 == 0)
						{
							obj2 = 26;
						}
						continue;
					}
					goto case 20;
				default:
					if ((nint)obj < 0)
					{
						if (23 == 0)
						{
							obj2 = 32;
						}
						continue;
					}
					goto case 58;
				case 51:
					obj = obj;
					obj2 = 52;
					continue;
				case 7:
				case 54:
					((sbyte[])obj)[obj * 2] = (sbyte)((byte[])P_0)[obj];
					obj2 = 43;
					continue;
				case 45:
					obj = 0;
					if (12 == 0)
					{
						obj2 = 2;
					}
					continue;
				case 48:
					return obj;
				case 47:
					obj = obj;
					if (51 != 0)
					{
						obj2 = 38;
					}
					continue;
				case 5:
					return obj;
				case 16:
					((sbyte[])obj)[obj] = (sbyte)(byte)(((byte[])P_0)[obj] ^ 0xA5);
					if (true)
					{
						obj2 = 6;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00鐀(object P_0, Guid P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778833, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00销()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00阀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778832, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00需(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0052->IL0019: Incompatible stack heights: 0 vs 1
		//IL_007c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00a3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0087->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				P_0 = (byte)(((P_0 & 0xAA) >> 1) | ((P_0 & 0x55) << 1));
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				P_0 = (byte)(((P_0 & 0xCC) >> 2) | ((P_0 & 0x33) << 2));
				if (false)
				{
					obj2 = 1;
				}
				break;
			default:
				return P_0;
			case 3:
				P_0 = (byte)(((P_0 >> 4) & 0xF) | ((P_0 & 0xF) << 4));
				obj2 = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00頀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00餀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778835, new IntPtr(2737367946284L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint _FF00_FF00_FF00_FF00_FF00騀(long P_0, uint P_1)
	{
		return (uint)((P_0 % (int)P_1 + (int)P_1) % (int)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00鬀(long P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778834, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00鰀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778413, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00鴀(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_005a: Expected I4, but got Obj
		//IL_00f7: Expected I4, but got Obj
		//IL_00f6: Expected native int or pointer, but got Obj
		//IL_0067: Expected I4, but got Obj
		//IL_0066: Expected native int or pointer, but got Obj
		//IL_0070: Expected Obj, but got I4
		//IL_00ca: Expected Obj, but got I4
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00e8: Expected Obj, but got I4
		//IL_018a: Expected Obj, but got I4
		//IL_0193: Expected Obj, but got I4
		//IL_0114: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I4
		//IL_0103->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00d6->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01c5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_015b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00a6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00f2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0120->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0088->IL0019: Incompatible stack heights: 0 vs 1
		//IL_010e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ba->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0149->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0166->IL0019: Incompatible stack types: I4 vs Obj
		//IL_012b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0093->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c5->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 13;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 2:
					return obj;
				case 1:
					*(int*)(nint)obj = (int)obj;
					obj = 9;
					break;
				case 14:
					obj = ((int[])obj)[obj];
					if (false)
					{
						obj2 = 0;
					}
					continue;
				case 6:
				case 10:
					obj++;
					_ = 8;
					continue;
				case 5:
				case 7:
					if ((nint)obj > 0)
					{
						if (6 == 0)
						{
							obj2 = 3;
						}
						continue;
					}
					goto case 2;
				case 3:
					obj = P_0 - 1;
					if (7 == 0)
					{
						obj2 = 4;
					}
					continue;
				case 11:
					obj = ((int[])obj)[obj];
					obj2 = 14;
					continue;
				default:
					*(int*)(nint)obj = (int)obj;
					if (1 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 13:
					obj = P_0;
					obj2 = 0;
					if (1 == 0)
					{
						obj2 = 12;
					}
					continue;
				case 8:
					obj2 = obj;
					obj = obj;
					if (0 == 0)
					{
						obj2 = 4;
					}
					continue;
				case 9:
					obj--;
					if (5 != 0)
					{
						obj2 = 5;
					}
					continue;
				case 12:
					obj = 1592639215;
					obj = 3;
					break;
				case 4:
					obj = obj;
					_ = 11;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00鸀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778412, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00鼀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778415, new IntPtr(2737367946284L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00ꀀ(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_007e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0054->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00a5->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0089->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b0->IL0019: Incompatible stack types: I4 vs Obj
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
				return P_0;
			case 2:
				P_0 = (byte)(((P_0 & 0xCC) >> 2) | ((P_0 & 0x33) << 2));
				if (true)
				{
					obj2 = 1;
				}
				break;
			case 1:
				P_0 = (byte)(((P_0 & 0xAA) >> 1) | ((P_0 & 0x55) << 1));
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				P_0 = (byte)(((P_0 >> 4) & 0xF) | ((P_0 & 0xF) << 4));
				if (1 == 0)
				{
					obj2 = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00ꄀ(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778414, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00ꈀ(Guid P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778409, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00ꌀ(Guid P_0, object P_1)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_ = ref P_0;
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00ꐀ(Guid P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778408, new IntPtr(2737367948364L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
