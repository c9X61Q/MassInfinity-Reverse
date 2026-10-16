using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Mass.Game.Proxy.Protocols;

public class CpsDetector
{
	private readonly object _lock;

	private readonly Queue<long> _leftClicks;

	private readonly Queue<long> _rightClicks;

	private double _lastLeftCps;

	private double _lastRightCps;

	[CompilerGenerated]
	private Action<double, double>? m_OnCpsChange;

	private static object DecompressList;

	public event Action<double, double>? OnCpsChange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			_FF00_FF00_FF00_FF00_FF00_FF00Ḁ(value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			_FF00_FF00_FF00_FF00_FF00_FF00ጀ(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LeftClick()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_2100();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RightClick()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00ᔀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnTick()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_1B00();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CpsDetector()
	{
		//IL_004a: Expected I4, but got Obj
		//IL_0038->IL0041: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		CpsDetector cpsDetector = this;
		if (false)
		{
			cpsDetector = (CpsDetector)0;
		}
		switch ((int)cpsDetector)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateSortedCommand()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CpsDetector ReflectCombinedConsumer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00ሀ(Action<double, double> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778789, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00ጀ(Action<double, double> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00aa->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00c3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0094->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0076->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 3:
				obj = obj;
				if (5 != 0)
				{
					obj2 = 4;
				}
				break;
			case 2:
				if (obj == obj)
				{
					if (false)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 3;
			case 5:
				obj2 = obj;
				obj = P_0;
				if (1 == 0)
				{
					obj2 = 0;
				}
				break;
			case 0:
				return;
			case 1:
				obj = obj;
				if (2 != 0)
				{
					_ = 1;
				}
				break;
			case 4:
				obj = this;
				obj2 = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_1400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778788, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00ᔀ()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_010b: Expected Obj, but got I4
		//IL_0117->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0043->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0122->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006c->IL0070: Incompatible stack types: I4 vs Ref
		//IL_0092->IL0070: Incompatible stack types: Obj vs Ref
		//IL_009d->IL0070: Incompatible stack types: I4 vs Ref
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
				obj = this;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 2:
				return;
			case 3:
			{
				ref object reference = ref obj;
				if (0 == 0)
				{
					reference = ref *(object*)null;
				}
				while (true)
				{
					switch ((uint)Unsafe.AsPointer(ref reference))
					{
					case 1u:
						return;
					}
					reference = ref *(object*)this;
					if (1 != 0)
					{
						reference = ref *(object*)1;
					}
				}
			}
			default:
				obj = 0;
				if (3 != 0)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00ᘀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778791, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00ᜀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778790, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_1800()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00ᤀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778785, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00ᨀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778784, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_1B00()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_02dd: Expected Obj, but got I4
		//IL_00f9: Expected Obj, but got F8
		//IL_01ca: Expected Obj, but got Ref
		//IL_01ff: Expected Obj, but got F8
		//IL_00c4: Invalid comparison between Obj and F8
		//IL_0218: Invalid comparison between Obj and F8
		//IL_01f4: Expected Obj, but got I4
		//IL_00b0: Expected I4, but got Obj
		//IL_02e9->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0043->IL0019: Incompatible stack heights: 0 vs 1
		//IL_005f->IL0063: Incompatible stack types: I4 vs Obj
		//IL_02f4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0103->IL0063: Incompatible stack types: I4 vs Obj
		//IL_01d6->IL0063: Incompatible stack heights: 1 vs 3
		//IL_0141->IL0063: Incompatible stack heights: 4 vs 3
		//IL_0199->IL0063: Incompatible stack heights: 2 vs 3
		//IL_0126->IL0063: Incompatible stack heights: 4 vs 3
		//IL_0189->IL0063: Incompatible stack types: I4 vs Obj
		//IL_0209->IL0063: Incompatible stack types: I4 vs Obj
		//IL_0116->IL0063: Incompatible stack types: I4 vs Obj
		//IL_01e1->IL0063: Incompatible stack heights: 1 vs 3
		//IL_014c->IL0063: Incompatible stack heights: 4 vs 3
		//IL_01a4->IL0063: Incompatible stack heights: 2 vs 3
		//IL_0131->IL0063: Incompatible stack heights: 4 vs 3
		//IL_017b->IL0063: Incompatible stack types: I4 vs Obj
		//IL_024a->IL0063: Incompatible stack heights: 2 vs 3
		//IL_00d5->IL0063: Incompatible stack heights: 2 vs 3
		//IL_0229->IL0063: Incompatible stack heights: 2 vs 3
		//IL_0269->IL0063: Incompatible stack heights: 6 vs 3
		//IL_00f3->IL0063: Incompatible stack types: I4 vs Obj
		//IL_0255->IL0063: Incompatible stack heights: 2 vs 3
		//IL_00e0->IL0063: Incompatible stack heights: 2 vs 3
		//IL_0234->IL0063: Incompatible stack heights: 2 vs 3
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
				obj = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				return;
			case 2:
			{
				object obj3 = 2;
				while (true)
				{
					switch ((int)obj3)
					{
					case 10:
						return;
					case 11:
						return;
					case 15:
					{
						object obj4 = obj - (object)this;
						if (Unsafe.As<object, UIntPtr>(ref obj4) <= Unsafe.As<object, UIntPtr>(ref (object)0.01))
						{
							return;
						}
						if (3 != 0)
						{
							_ = 1;
						}
						break;
					}
					case 17:
						if (this == null)
						{
							obj3 = 11;
						}
						else
						{
							_ = 10;
						}
						break;
					default:
						obj = (double)this;
						obj3 = 8;
						break;
					case 1:
					case 13:
						if ((nint)this > 0)
						{
							obj3 = 14;
							break;
						}
						goto default;
					case 5:
						if (6 == 0)
						{
							_ = 17;
						}
						break;
					case 3:
						if (3 == 0)
						{
							_ = 5;
						}
						break;
					case 9:
					case 12:
						if ((nint)this > 0)
						{
							obj3 = 7;
							break;
						}
						goto case 1;
					case 6:
						obj3 = 9;
						break;
					case 4:
						if (0 == 0)
						{
							_ = 1;
						}
						break;
					case 2:
						obj = (object)Unsafe.AsPointer(ref Unsafe.SubtractByteOffset(ref obj, 1000));
						if (10 == 0)
						{
							_ = 12;
						}
						break;
					case 7:
						if (Unsafe.As<CpsDetector, UIntPtr>(ref this) >= Unsafe.As<object, UIntPtr>(ref obj))
						{
							obj = 13;
							obj3 = obj;
							break;
						}
						goto case 6;
					case 8:
						obj = (double)this;
						obj3 = 16;
						break;
					case 16:
					{
						object obj5 = obj - (object)this;
						if (Unsafe.As<object, UIntPtr>(ref obj5) <= Unsafe.As<object, UIntPtr>(ref (object)0.01))
						{
							if (1 == 0)
							{
								_ = 15;
							}
							break;
						}
						goto case 3;
					}
					case 14:
						if (Unsafe.As<CpsDetector, UIntPtr>(ref this) >= Unsafe.As<object, UIntPtr>(ref obj))
						{
							if (0 == 0)
							{
								_ = 0;
							}
							break;
						}
						goto case 4;
					}
				}
			}
			default:
				obj = 0;
				if (2 == 0)
				{
					obj2 = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00ᰀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778787, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00ᴀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00Ḁ(Action<double, double> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0098->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00b8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0088->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006a->IL0019: Incompatible stack types: I4 vs Obj
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
				obj = this;
				if (true)
				{
					obj2 = 1;
				}
				continue;
			case 3:
				return;
			case 5:
				if (obj == obj)
				{
					obj2 = 3;
					continue;
				}
				goto case 1;
			case 1:
				obj = obj;
				if (false)
				{
					obj2 = 0;
				}
				continue;
			case 4:
				obj = obj;
				if (5 == 0)
				{
					_ = 0;
				}
				continue;
			}
			obj2 = obj;
			obj = P_0;
			if (1 == 0)
			{
				obj2 = 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00ἀ(Action<double, double> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778786, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_2000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778813, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_2100()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0102: Expected Obj, but got I4
		//IL_010e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_012a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0050->IL0054: Incompatible stack types: I4 vs Ref
		//IL_0119->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0135->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0076->IL0054: Incompatible stack types: Obj vs Ref
		//IL_0081->IL0054: Incompatible stack types: I4 vs Ref
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				obj = 0;
				if (0 == 0)
				{
					obj2 = 0;
				}
				continue;
			case 3:
				return;
			case 2:
				obj = this;
				if (true)
				{
					obj2 = 1;
				}
				continue;
			}
			ref object reference = ref obj;
			if (1 == 0)
			{
				reference = ref *(object*)1;
			}
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					return;
				case 1u:
					reference = ref *(object*)this;
					if (0 == 0)
					{
						reference = ref *(object*)null;
					}
					break;
				case 0u:
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_2200()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778812, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
