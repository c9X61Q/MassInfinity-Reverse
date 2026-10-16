using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;

namespace Mass.Game.Proxy.Network.Team;

public class RemoveTeamPlayer : TeamActionBase
{
	private static object DecompressRequester;

	public HashSet<string> Players
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00鸀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00阀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RemoveTeamPlayer(EnumProtocolVersion version)
	{
		//IL_0042: Expected I4, but got Obj
		//IL_0030->IL0039: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		RemoveTeamPlayer removeTeamPlayer = this;
		if (0 == 0)
		{
			removeTeamPlayer = (RemoveTeamPlayer)0;
		}
		switch ((int)removeTeamPlayer)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Read(IByteBuffer buffer)
	{
		_FF00_FF00_FF00鴀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(IByteBuffer buffer)
	{
		_FF00_FF00_FF00頀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectSegmentedTree()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RemoveTeamPlayer ReflectCommonFilter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00錀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776603, new IntPtr(2737368318348L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00鐀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00销(HashSet<string> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776602, new IntPtr(2737368331868L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00阀(HashSet<string> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0045->IL0019: Incompatible stack heights: 2 vs 1
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
	internal unsafe void _FF00_FF00_FF00需(HashSet<string> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776597, new IntPtr(2737368328748L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00頀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0056: Expected I4, but got Obj
		//IL_0152: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_013d: Expected Obj, but got I4
		//IL_0157->IL0015: Incompatible stack heights: 1 vs 0
		//IL_00d5->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0168->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00f4->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0088->IL0019: Incompatible stack heights: 0 vs 1
		//IL_017a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00e0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0125->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0093->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0185->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0130->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 8;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 8:
					obj = this;
					if (7 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 6:
					obj2 = P_0;
					_ = ((Array)obj).Length;
					if (11 == 0)
					{
						obj2 = 3;
					}
					continue;
				case 1:
				case 12:
					if ((nint)obj >= ((Array)obj).Length)
					{
						obj2 = 3;
						continue;
					}
					goto case 4;
				case 2:
					obj = 0;
					if (true)
					{
						obj2 = 1;
					}
					continue;
				case 5:
					_ = 32767;
					_ = 9;
					continue;
				case 3:
					return;
				case 7:
					if ((nint)this > 5)
					{
						if (13 != 0)
						{
							obj2 = 13;
						}
						continue;
					}
					goto case 6;
				case 10:
				case 11:
					obj = obj;
					obj = 2;
					break;
				default:
					_ = ((Array)obj).Length;
					obj = 10;
					break;
				case 4:
					obj = ((object[])obj)[obj];
					obj2 = 5;
					continue;
				case 9:
					obj++;
					if (12 == 0)
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
	internal unsafe void _FF00_FF00_FF00餀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776596, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00騀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776599, new IntPtr(2737368310028L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00鬀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00鰀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776598, new IntPtr(2737368305868L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00鴀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0046: Expected I4, but got Obj
		//IL_00c1: Expected Obj, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_005b: Expected Obj, but got I4
		//IL_00cb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0093->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0124->IL0019: Incompatible stack heights: 0 vs 1
		//IL_009e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ec->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b3->IL0019: Incompatible stack heights: 0 vs 1
		//IL_012f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00be->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 8;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				case 2:
					return;
				case 4:
					goto end_IL_0019;
				default:
					_ = 32767;
					if (4 == 0)
					{
						_ = 4;
					}
					continue;
				case 6:
				case 9:
					if (Unsafe.As<object, UIntPtr>(ref obj) >= Unsafe.As<object, UIntPtr>(ref obj))
					{
						return;
					}
					if (false)
					{
						obj2 = 0;
					}
					continue;
				case 1:
					obj = 0;
					obj2 = 6;
					continue;
				case 8:
					if ((nint)this <= 5)
					{
						obj2 = 7;
						continue;
					}
					goto case 3;
				case 3:
					obj3 = P_0;
					break;
				case 7:
					obj3 = P_0;
					break;
				}
				obj = obj3;
				if (0 == 0)
				{
					obj2 = 1;
				}
				continue;
				end_IL_0019:
				break;
			}
			obj++;
			obj = 9;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal HashSet<string> _FF00_FF00_FF00鸀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (HashSet<string>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe HashSet<string> _FF00_FF00_FF00鼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776593, new IntPtr(2737368318348L), 15))(null, 0, new IntPtr(0L));
		return (HashSet<string>)/*Error near IL_0033: Stack underflow*/;
	}
}
