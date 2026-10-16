using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;

namespace Mass.Game.Proxy.Network.Team;

public class AddTeamPlayer : TeamActionBase
{
	private static object DecorateExpandableStream;

	public HashSet<string> Players
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00开();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00圀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AddTeamPlayer(EnumProtocolVersion version)
	{
		//IL_0042: Expected I4, but got Obj
		//IL_0030->IL0039: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		AddTeamPlayer addTeamPlayer = this;
		if (0 == 0)
		{
			addTeamPlayer = (AddTeamPlayer)0;
		}
		switch ((int)addTeamPlayer)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Read(IByteBuffer buffer)
	{
		_FF00_FF00_FF00尀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(IByteBuffer buffer)
	{
		_FF00_FF00_FF00夀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PopTemplate()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AddTeamPlayer DecorateAdjustableController()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00吀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776634, new IntPtr(2737368331868L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00唀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00嘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776629, new IntPtr(2737368310028L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00圀(HashSet<string> P_0)
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
	internal unsafe void _FF00_FF00_FF00堀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776628, new IntPtr(2737368306908L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00夀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_005a: Expected I4, but got Obj
		//IL_00fe: Expected Obj, but got I4
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_014e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0095->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0108->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0084->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0070->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0169->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00df->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0159->IL0019: Incompatible stack types: I4 vs Obj
		//IL_013e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_011a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a0->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 8;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 5:
			case 13:
				obj = ((object[])obj)[obj];
				obj2 = 12;
				continue;
			case 12:
				_ = 32767;
				_ = 14;
				continue;
			case 8:
				obj = this;
				if (7 == 0)
				{
					obj2 = 2;
				}
				continue;
			case 10:
				_ = ((Array)obj).Length;
				_ = 11;
				continue;
			case 3:
				return;
			case 9:
				obj = 0;
				obj2 = 6;
				continue;
			case 7:
				if ((nint)this > 5)
				{
					obj2 = 4;
					continue;
				}
				goto case 10;
			case 2:
			case 6:
				if ((nint)obj >= ((Array)obj).Length)
				{
					return;
				}
				obj2 = 5;
				continue;
			case 1:
			case 11:
				obj = obj;
				if (9 != 0)
				{
					obj2 = 5;
				}
				continue;
			case 14:
				obj++;
				obj2 = 2;
				continue;
			}
			obj2 = P_0;
			_ = ((Array)obj).Length;
			if (1 == 0)
			{
				obj2 = 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00娀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776631, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00嬀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00尀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0046: Expected I4, but got Obj
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_00c2: Expected Obj, but got I4
		//IL_0062->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00e9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ce->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0124->IL0019: Incompatible stack heights: 0 vs 1
		//IL_006d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b3->IL0019: Incompatible stack heights: 0 vs 1
		//IL_012f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00be->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 6;
		object obj2 = obj;
		while (true)
		{
			object obj3;
			switch ((int)obj2)
			{
			case 2:
			case 3:
				_ = 32767;
				if (4 != 0)
				{
					_ = 4;
				}
				continue;
			case 6:
				if ((nint)this <= 5)
				{
					obj2 = 5;
					continue;
				}
				goto case 1;
			case 1:
				obj3 = P_0;
				break;
			default:
				if (Unsafe.As<object, UIntPtr>(ref obj) < Unsafe.As<object, UIntPtr>(ref obj))
				{
					if (0 == 0)
					{
						obj2 = 3;
					}
					continue;
				}
				return;
			case 8:
				return;
			case 7:
				obj = 0;
				if (0 == 0)
				{
					obj2 = 0;
				}
				continue;
			case 4:
				obj++;
				obj2 = 9;
				continue;
			case 5:
				obj3 = P_0;
				break;
			}
			obj = obj3;
			if (7 != 0)
			{
				obj2 = 5;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00崀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776630, new IntPtr(2737368319388L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe HashSet<string> _FF00_FF00_FF00帀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776625, new IntPtr(2737368331868L), 15))(null, 0, new IntPtr(0L));
		return (HashSet<string>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal HashSet<string> _FF00_FF00_FF00开()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (HashSet<string>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe HashSet<string> _FF00_FF00_FF00怀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776624, new IntPtr(2737368319388L), 15))(null, 0, new IntPtr(0L));
		return (HashSet<string>)/*Error near IL_0033: Stack underflow*/;
	}
}
