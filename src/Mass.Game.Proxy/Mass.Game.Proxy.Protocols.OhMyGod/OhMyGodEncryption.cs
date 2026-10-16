using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Mass.Game.Proxy.Protocols.OhMyGod;

public static class OhMyGodEncryption
{
	private static object DecorateEfficientEmitter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string EncryptData(string input)
	{
		return (string)_FF00_FF00_FF00_FF00_FF00_FF00_0600(input);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object DesEncrypt(object key, object data)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00ࠀ(key, data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object DesEncrypt(object key, object data)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 177, 1790778809, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778809, new IntPtr(2737367922364L), 15);
		}
		return ((delegate*<object, object, object>)obj)(key, data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object ToBase32(this object? data)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 178, 1790778808, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778808, new IntPtr(2737367923404L), 15);
		}
		return ((delegate*<object, object>)obj)(data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectAttachedRunner()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static OhMyGodEncryption DecorateGlobalClient()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778811, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00_FF00_FF00_FF00_FF00_FF00Ā(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0092: Expected I4, but got Obj
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Obj, but got Unknown
		//IL_0266: Expected Obj, but got I4
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected Obj, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected Obj, but got Unknown
		//IL_01e4: Expected Obj, but got I4
		//IL_0239: Expected Obj, but got I4
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected Obj, but got Unknown
		//IL_011d: Expected Obj, but got I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_00f0: Expected Obj, but got I4
		//IL_01b5: Expected Obj, but got I4
		//IL_0210->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0270->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02c6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_029c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0263->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0251->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01ee->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02f7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0127->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00bf->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00fc->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01c1->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0200->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02dc->IL0019: Incompatible stack heights: 0 vs 1
		//IL_02a7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01e1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_022d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0146->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ed->IL0019: Incompatible stack types: I4 vs Obj
		//IL_015e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00d2->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0107->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01cc->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02e7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0169->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00dd->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 22;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 26:
					obj = (obj << ((5 - obj) & 0x1F)) & 0x1F;
					obj2 = 16;
					continue;
				case 27:
					if (((Array)P_0).Length != 0)
					{
						if (1 == 0)
						{
							obj2 = 1;
						}
						continue;
					}
					goto case 20;
				case 22:
					if (P_0 == null)
					{
						obj2 = 21;
						continue;
					}
					goto case 27;
				case 28:
					obj = 0;
					if (2 == 0)
					{
						obj2 = 8;
					}
					continue;
				case 14:
				case 25:
					obj = ((byte[])obj)[obj];
					obj2 = 13;
					continue;
				case 16:
					obj2 = obj;
					if (5 == 0)
					{
						obj2 = 7;
					}
					continue;
				case 24:
					return obj;
				case 2:
				case 23:
					if ((nint)obj < 5)
					{
						if (3 == 0)
						{
							obj2 = 3;
						}
						continue;
					}
					goto case 9;
				case 20:
				case 21:
					return (object)/*Error near IL_01a9: Stack underflow*/;
				case 1:
					obj = (((Array)P_0).Length * 8 + 4) / 5;
					if (17 != 0)
					{
						obj2 = 2;
					}
					continue;
				case 8:
				case 12:
					if ((nint)obj < ((Array)obj).Length)
					{
						obj2 = 14;
						continue;
					}
					goto case 5;
				case 17:
					obj = 0;
					obj2 = 4;
					continue;
				case 5:
					if ((nint)obj > 0)
					{
						obj2 = 26;
						continue;
					}
					goto case 6;
				case 3:
					obj++;
					obj2 = 12;
					continue;
				default:
					obj2 = obj;
					_ = 61;
					if (1 == 0)
					{
						obj2 = 6;
					}
					continue;
				case 18:
					break;
				case 13:
					obj = (object)(obj << 8) | obj;
					obj2 = 19;
					continue;
				case 11:
					_ = 23;
					continue;
				case 4:
					obj = 0;
					obj2 = 18;
					continue;
				case 10:
					obj = (obj >> (obj & 0x1F)) & 0x1F;
					if (4 == 0)
					{
						obj2 = 11;
					}
					continue;
				case 9:
					obj -= 5;
					obj2 = 10;
					continue;
				case 6:
				case 7:
					if (obj % 8 != 0)
					{
						if (false)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 24;
				case 19:
					obj += 8;
					obj2 = 2;
					continue;
				}
				break;
			}
			obj = P_0;
			obj = 28;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00Ȁ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778810, new IntPtr(2737367924444L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_0600(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 10222, 1790778805, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778805, new IntPtr(2737367924444L), 15);
		}
		return ((delegate*<object, object>)obj)(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_0700(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778804, new IntPtr(2737367928604L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00ࠀ(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 10224, 1790778807, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778807, new IntPtr(2737367926524L), 15);
		}
		return ((delegate*<object, object, object>)obj)(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_0900(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778806, new IntPtr(2737367927564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_0A00(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778801, new IntPtr(2737367927564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00_FF00_FF00_FF00_FF00_FF00_0B00(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0056: Expected Obj, but got I4
		//IL_00ef: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I4
		//IL_0042->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00bd->IL0081: Incompatible stack heights: 4 vs 3
		//IL_00d9->IL0081: Incompatible stack heights: 2 vs 3
		//IL_0081->IL0081: Incompatible stack heights: 5 vs 3
		//IL_00c8->IL0081: Incompatible stack heights: 4 vs 3
		//IL_00e4->IL0081: Incompatible stack heights: 2 vs 3
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
				obj = (object)/*Error near IL_0036: Stack underflow*/;
				if (3 != 0)
				{
					obj2 = 1;
				}
				continue;
			case 1:
				obj2 = P_0;
				obj = 8;
				if (false)
				{
					obj2 = 0;
				}
				continue;
			case 3:
			{
				while (true)
				{
					switch (2)
					{
					case 1:
						_ = 2;
						obj = 3;
						continue;
					case 2:
						_ = 2;
						if (1 == 0)
						{
							_ = 1;
						}
						continue;
					case 3:
						obj = obj;
						if (0 == 0)
						{
							_ = 0;
						}
						continue;
					}
					break;
				}
				int num = 0;
				obj = ((Array)P_1).Length;
				if (0 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				break;
			}
			case 2:
				break;
			}
			break;
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_0C00(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778800, new IntPtr(2737367927564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_0D00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778803, new IntPtr(2737367927564L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_0E00()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00ༀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778802, new IntPtr(2737367927564L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00က()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778765, new IntPtr(2737367927564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00ᄀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}
}
