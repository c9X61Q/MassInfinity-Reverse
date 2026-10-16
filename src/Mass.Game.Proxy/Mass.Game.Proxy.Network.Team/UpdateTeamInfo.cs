using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Network.Nbt;

namespace Mass.Game.Proxy.Network.Team;

public class UpdateTeamInfo : TeamActionBase
{
	private static object ReflectJoinedMatcher;

	public string DisplayName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00뼀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_A700(value);
		}
	}

	public string Prefix
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00찀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00ꨀ(value);
		}
	}

	public string Suffix
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00먀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00봀(value);
		}
	}

	public byte FriendlyFire
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00넀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00였(value);
		}
	}

	public string NameTagVisibility
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00렀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00뤀(value);
		}
	}

	public int Color
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00가();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00대((uint)value);
		}
	}

	public string CollisionRule
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00ꐀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00쀀(value);
		}
	}

	public NbtTag? NbtDisplayName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (NbtTag?)_FF00_FF00_FF00딀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00꤀(value);
		}
	}

	public NbtTag? NbtPrefix
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (NbtTag?)_FF00_FF00_FF00쐀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00숀(value);
		}
	}

	public NbtTag? NbtSuffix
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (NbtTag?)_FF00_FF00_FF00꼀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00섀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UpdateTeamInfo(EnumProtocolVersion version)
	{
		//IL_0062: Expected I4, but got Obj
		//IL_0050->IL0059: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		UpdateTeamInfo updateTeamInfo = this;
		if (false)
		{
			updateTeamInfo = (UpdateTeamInfo)0;
		}
		switch ((int)updateTeamInfo)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Read(IByteBuffer buffer)
	{
		_FF00_FF00_FF00ꄀ(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(IByteBuffer buffer)
	{
		_FF00_FF00_FF00케(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectLiteralReg()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static UpdateTeamInfo CheckScalableExecutor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00ꀀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776677, new IntPtr(2737368315228L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00ꄀ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_00b2: Expected I4, but got Obj
		//IL_01a3: Expected Obj, but got I4
		//IL_0110: Expected Obj, but got I4
		//IL_0294: Expected Obj, but got I4
		//IL_00f8->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0128->IL0019: Incompatible stack heights: 4 vs 1
		//IL_02a9->IL0019: Incompatible stack heights: 4 vs 1
		//IL_023d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00e3->IL0019: Incompatible stack heights: 3 vs 1
		//IL_03de->IL0019: Incompatible stack heights: 3 vs 1
		//IL_035d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01d0->IL0019: Incompatible stack heights: 3 vs 1
		//IL_03b6->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0273->IL0019: Incompatible stack heights: 3 vs 1
		//IL_025a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_02f9->IL0019: Incompatible stack heights: 3 vs 1
		//IL_03c9->IL0019: Incompatible stack heights: 4 vs 1
		//IL_01a8->IL0015: Incompatible stack heights: 3 vs 0
		//IL_017e->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0222->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0299->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0398->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0136->IL0019: Incompatible stack heights: 3 vs 1
		//IL_037d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0287->IL0019: Incompatible stack heights: 4 vs 1
		//IL_01f3->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0348->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0191->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0103->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0248->IL0019: Incompatible stack heights: 2 vs 1
		//IL_03e9->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0368->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01db->IL0019: Incompatible stack heights: 3 vs 1
		//IL_02eb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01bb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0265->IL0019: Incompatible stack heights: 3 vs 1
		//IL_022d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_014f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03a3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0212->IL0019: Incompatible stack heights: 4 vs 1
		//IL_02bf->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ca->IL0019: Incompatible stack heights: 3 vs 1
		//IL_02d5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0388->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0329->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0401->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01fe->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d5->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0334->IL0019: Incompatible stack types: I4 vs Obj
		//IL_040c->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 28;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 26:
					return;
				case 7:
					_ = 34;
					continue;
				case 3:
					_ = 32767;
					if (12 != 0)
					{
						_ = 17;
					}
					continue;
				case 23:
					obj = this;
					obj = 2;
					break;
				case 4:
					_ = 32767;
					_ = 18;
					continue;
				case 29:
					_ = 33;
					continue;
				case 32:
					return;
				default:
					throw /*Error near IL_0139: Stack underflow*/;
				case 27:
					if ((nint)obj <= 340)
					{
						obj2 = 35;
						continue;
					}
					goto case 1;
				case 20:
					_ = 32767;
					_ = 9;
					continue;
				case 2:
					if ((nint)obj != 47)
					{
						obj2 = 30;
						continue;
					}
					_ = 32767;
					_ = 7;
					continue;
				case 19:
					_ = 32767;
					obj = 25;
					break;
				case 14:
					if ((nint)obj != 47)
					{
						obj2 = 36;
						continue;
					}
					goto case 11;
				case 10:
					_ = 32767;
					if (6 != 0)
					{
						_ = 12;
					}
					continue;
				case 1:
					if ((nint)obj != 757)
					{
						if (13 != 0)
						{
							obj2 = 8;
						}
						continue;
					}
					goto IL_0274;
				case 34:
					return;
				case 22:
					if (6 == 0)
					{
						_ = 8;
					}
					continue;
				case 6:
					if (8 != 0)
					{
						_ = 23;
					}
					continue;
				case 15:
					if (5 == 0)
					{
						_ = 2;
					}
					continue;
				case 12:
					_ = 4;
					continue;
				case 16:
					return;
				case 25:
					obj = 16;
					break;
				case 5:
					_ = 32;
					continue;
				case 30:
					if ((nint)obj != 340)
					{
						obj2 = 24;
						continue;
					}
					_ = 32767;
					_ = 19;
					continue;
				case 31:
					if ((nint)obj != 766)
					{
						obj2 = 21;
					}
					else if (22 != 0)
					{
						_ = 6;
					}
					continue;
				case 13:
					if ((nint)obj != 763)
					{
						obj2 = 31;
						continue;
					}
					goto IL_0274;
				case 17:
					_ = 15;
					continue;
				case 35:
					if ((nint)obj != 5)
					{
						if (4 != 0)
						{
							obj2 = 14;
						}
						continue;
					}
					goto case 11;
				case 24:
					return;
				case 9:
					_ = 32767;
					if (3 == 0)
					{
						_ = 6;
					}
					continue;
				case 33:
					_ = 32767;
					if (10 == 0)
					{
						_ = 7;
					}
					continue;
				case 28:
					obj = this;
					if (12 == 0)
					{
						obj2 = 27;
					}
					continue;
				case 11:
					_ = 32767;
					_ = 20;
					continue;
				case 18:
					_ = 32767;
					_ = 26;
					continue;
				case 8:
					_ = 32767;
					if (false)
					{
						_ = 3;
					}
					continue;
				case 36:
					{
						if ((nint)obj != 340)
						{
							if (false)
							{
								obj2 = 0;
							}
							continue;
						}
						goto case 11;
					}
					IL_0274:
					_ = 32767;
					_ = 29;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00ꈀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776676, new IntPtr(2737368308988L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00ꌀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776679, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00ꐀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00ꔀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776678, new IntPtr(2737368331868L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00ꘀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776673, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_A700(object P_0)
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
	internal unsafe void _FF00_FF00_FF00ꠀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776672, new IntPtr(2737368325628L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00꤀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
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
			case 0:
				return;
			case 1:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00ꨀ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
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
			case 0:
				return;
			case 1:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_AB00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776675, new IntPtr(2737368307948L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00가()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00관()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776674, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00글()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776701, new IntPtr(2737368316268L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00꼀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00뀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776700, new IntPtr(2737368301708L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00넀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00눀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776703, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00대(uint P_0)
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
	internal unsafe void _FF00_FF00_FF00됀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776702, new IntPtr(2737368328748L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00딀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00똀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776697, new IntPtr(2737368307948L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00뜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776696, new IntPtr(2737368310028L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00렀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00뤀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
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
			case 0:
				return;
			case 1:
				if (false)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00먀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00묀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776699, new IntPtr(2737368328748L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00밀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776698, new IntPtr(2737368328748L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00봀(object P_0)
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
				if (false)
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
	internal unsafe void _FF00_FF00_FF00븀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776693, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00뼀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00쀀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
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
			case 0:
				return;
			case 1:
				if (false)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00섀(object P_0)
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
	internal void _FF00_FF00_FF00숀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
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
			case 0:
				return;
			case 1:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00쌀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776692, new IntPtr(2737368302748L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00쐀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00씀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776695, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00였(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
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
			case 0:
				return;
			case 1:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00윀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776694, new IntPtr(2737368307948L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00저()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00준()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776689, new IntPtr(2737368325628L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00쨀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00쬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776688, new IntPtr(2737368314188L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00찀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00촀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776691, new IntPtr(2737368315228L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00츀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776690, new IntPtr(2737368320428L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00케(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_00b2: Expected I4, but got Obj
		//IL_0228: Expected Obj, but got I4
		//IL_017f: Expected Obj, but got I4
		//IL_019a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_03c0->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0255->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0241->IL0019: Incompatible stack heights: 3 vs 1
		//IL_03cf->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00d5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_012d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_03ac->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00eb->IL0019: Incompatible stack heights: 2 vs 1
		//IL_022d->IL0015: Incompatible stack heights: 1 vs 0
		//IL_01b9->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0350->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0264->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0363->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0278->IL0019: Incompatible stack heights: 3 vs 1
		//IL_037c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_03e5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0119->IL0019: Incompatible stack heights: 2 vs 1
		//IL_010a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01a5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01ec->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0412->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02d6->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00f6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0342->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02f6->IL0019: Incompatible stack heights: 3 vs 1
		//IL_030c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0390->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0290->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0160->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02b3->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0324->IL0019: Incompatible stack heights: 0 vs 1
		//IL_036e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_020f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0149->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03f0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01f7->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02e1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_039b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_029b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_016b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02be->IL0019: Incompatible stack types: I4 vs Obj
		//IL_032f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_021a->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 23;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					return;
				case 33:
					_ = 31;
					continue;
				case 10:
					_ = 30;
					continue;
				case 13:
					_ = 32767;
					if (1 == 0)
					{
						_ = 0;
					}
					continue;
				case 36:
					_ = 32767;
					_ = 26;
					continue;
				case 35:
					_ = 5;
					continue;
				case 11:
					_ = 32767;
					_ = 7;
					continue;
				case 29:
					obj2 = P_0;
					if (5 == 0)
					{
						obj2 = 11;
					}
					continue;
				case 24:
					return;
				case 32:
					return;
				case 9:
				case 25:
					throw /*Error near IL_016e: Stack underflow*/;
				case 3:
					if ((nint)obj != 5)
					{
						obj = 14;
						break;
					}
					goto case 13;
				case 1:
					_ = 32767;
					if (21 == 0)
					{
						_ = 6;
					}
					continue;
				case 21:
					_ = 32767;
					_ = 33;
					continue;
				case 18:
					return;
				case 28:
					if ((nint)obj != 757)
					{
						if (2 == 0)
						{
							obj2 = 15;
						}
						continue;
					}
					goto IL_02e2;
				case 19:
					obj = 12;
					break;
				case 7:
					_ = 32767;
					_ = 35;
					continue;
				case 6:
					_ = 32767;
					_ = 19;
					continue;
				case 26:
					_ = 16;
					continue;
				case 30:
					_ = 32767;
					_ = 6;
					continue;
				case 17:
					if ((nint)obj != 766)
					{
						if (1 == 0)
						{
							obj2 = 25;
						}
					}
					else if (8 == 0)
					{
						_ = 10;
					}
					continue;
				case 20:
					if ((nint)obj == 340)
					{
						_ = 32767;
						if (24 == 0)
						{
							_ = 36;
						}
					}
					else if (16 == 0)
					{
						obj2 = 18;
					}
					continue;
				case 4:
					if ((nint)obj != 340)
					{
						if (8 == 0)
						{
							obj2 = 9;
						}
						continue;
					}
					goto case 13;
				case 16:
					return;
				case 15:
					if ((nint)obj != 763)
					{
						obj2 = 17;
						continue;
					}
					goto IL_02e2;
				case 22:
					if ((nint)obj <= 340)
					{
						if (3 == 0)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 28;
				case 14:
					if ((nint)obj != 47)
					{
						obj2 = 4;
						continue;
					}
					goto case 13;
				case 23:
					obj = this;
					obj2 = 22;
					continue;
				case 27:
					if (26 != 0)
					{
						_ = 32;
					}
					continue;
				case 31:
					obj = this;
					obj2 = 2;
					continue;
				case 0:
					return;
				case 12:
					_ = 27;
					continue;
				case 5:
					_ = 32767;
					_ = 34;
					continue;
				case 8:
					_ = 24;
					continue;
				case 34:
					_ = 32767;
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
				case 2:
					{
						if ((nint)obj != 47)
						{
							obj2 = 20;
							continue;
						}
						_ = 32767;
						if (2 == 0)
						{
							_ = 8;
						}
						continue;
					}
					IL_02e2:
					_ = 32767;
					_ = 29;
					continue;
				}
				break;
			}
		}
	}
}
