using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Network.Nbt;

namespace Mass.Game.Proxy.Network.Team;

public class CreateTeam : TeamActionBase
{
	internal static CreateTeam DecorateGenericFinder;

	public string DisplayName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00樀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00萀(value);
		}
	}

	public string Prefix
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00猀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00紀(value);
		}
	}

	public string Suffix
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00戀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00氀(value);
		}
	}

	public byte FriendlyFire
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00谀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00栀(value);
		}
	}

	public HashSet<string> Players
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00瀀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00琀(value);
		}
	}

	public string NameTagVisibility
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00鄀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00縀(value);
		}
	}

	public int Color
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00輀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00舀((uint)value);
		}
	}

	public string CollisionRule
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00眀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00搀(value);
		}
	}

	public NbtTag? NbtDisplayName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (NbtTag?)_FF00_FF00_FF00蜀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00焀(value);
		}
	}

	public NbtTag? NbtPrefix
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (NbtTag?)_FF00_FF00_FF00笀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00蔀(value);
		}
	}

	public NbtTag? NbtSuffix
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (NbtTag?)_FF00_FF00_FF00最();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00渀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CreateTeam(EnumProtocolVersion version)
	{
		//IL_006a: Expected I4, but got Obj
		//IL_0058->IL0061: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		CreateTeam createTeam = this;
		if (0 == 0)
		{
			createTeam = (CreateTeam)0;
		}
		switch ((int)createTeam)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Read(IByteBuffer buffer)
	{
		_FF00_FF00_FF00贀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(IByteBuffer buffer)
	{
		_FF00_FF00_FF00言(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VerifyList()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CreateTeam ReflectCustomQueue()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00愀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776627, new IntPtr(2737368305868L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00戀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00挀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776626, new IntPtr(2737368316268L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00搀(object P_0)
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
	internal unsafe void _FF00_FF00_FF00攀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776589, new IntPtr(2737368314188L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00昀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776588, new IntPtr(2737368307948L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00最()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00栀(byte P_0)
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
	internal unsafe object _FF00_FF00_FF00椀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776591, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00樀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00欀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776590, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00氀(object P_0)
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
	internal unsafe void _FF00_FF00_FF00洀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776585, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00渀(object P_0)
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
	internal unsafe void _FF00_FF00_FF00漀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776584, new IntPtr(2737368328748L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal HashSet<string> _FF00_FF00_FF00瀀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (HashSet<string>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00焀(object P_0)
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
	internal unsafe void _FF00_FF00_FF00爀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776587, new IntPtr(2737368310028L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00猀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00琀(HashSet<string> P_0)
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
	internal unsafe void _FF00_FF00_FF00甀(HashSet<string> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776586, new IntPtr(2737368307948L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00瘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776581, new IntPtr(2737368307948L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00眀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00砀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776580, new IntPtr(2737368308988L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00礀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00稀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776583, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00笀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00簀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776582, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00紀(object P_0)
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
	internal void _FF00_FF00_FF00縀(object P_0)
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
	internal unsafe void _FF00_FF00_FF00缀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776577, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00耀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00脀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776576, new IntPtr(2737368318348L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00舀(uint P_0)
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
	internal unsafe void _FF00_FF00_FF00茀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776579, new IntPtr(2737368325628L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00萀(object P_0)
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
	internal void _FF00_FF00_FF00蔀(object P_0)
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
	internal unsafe void _FF00_FF00_FF00蘀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776578, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00蜀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00蠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776605, new IntPtr(2737368325628L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00褀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776604, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00言(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_010a: Expected I4, but got Obj
		//IL_01b7: Expected Obj, but got I4
		//IL_0155: Expected Obj, but got I4
		//IL_0122: Expected Obj, but got I4
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Expected Obj, but got Unknown
		//IL_01a4: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I4
		//IL_034b: Expected Obj, but got I4
		//IL_02e8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_04b0->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01bc->IL0015: Incompatible stack heights: 1 vs 0
		//IL_0463->IL0019: Incompatible stack heights: 2 vs 1
		//IL_054d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_05ff->IL0019: Incompatible stack heights: 3 vs 1
		//IL_015a->IL0015: Incompatible stack heights: 2 vs 0
		//IL_04e2->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0432->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01e6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0127->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0240->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0189->IL0019: Incompatible stack heights: 0 vs 1
		//IL_060f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_063a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0200->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01a9->IL0015: Incompatible stack heights: 1 vs 0
		//IL_0311->IL0019: Incompatible stack heights: 2 vs 1
		//IL_037a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_05e0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0256->IL0019: Incompatible stack heights: 2 vs 1
		//IL_03b3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_059c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_056c->IL0019: Incompatible stack heights: 3 vs 1
		//IL_02a1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0364->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0509->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0134->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04f3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0350->IL0015: Incompatible stack heights: 2 vs 0
		//IL_01d0->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0145->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0397->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0338->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0423->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05bf->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0580->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0178->IL0019: Incompatible stack types: I4 vs Obj
		//IL_046e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_052c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0558->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01f1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0194->IL0019: Incompatible stack types: I4 vs Obj
		//IL_031c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0385->IL0019: Incompatible stack heights: 2 vs 1
		//IL_05eb->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02b7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_040d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02d9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0261->IL0019: Incompatible stack heights: 2 vs 1
		//IL_03c8->IL0019: Incompatible stack heights: 0 vs 1
		//IL_05a7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0276->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02fe->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0514->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0491->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0232->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03a2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05ca->IL0019: Incompatible stack types: I4 vs Obj
		//IL_058b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0537->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03d3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_049c->IL0019: Incompatible stack types: I4 vs Obj
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
				case 20:
					_ = 32767;
					obj = 42;
					break;
				case 47:
					obj = 0;
					obj2 = 50;
					continue;
				case 58:
					_ = ((Array)obj).Length;
					_ = 43;
					continue;
				case 14:
					obj = 10;
					break;
				case 9:
					obj2 = P_0;
					_ = ((Array)obj).Length;
					if (29 == 0)
					{
						obj2 = 14;
					}
					continue;
				case 22:
					obj = this;
					if (21 != 0)
					{
						obj2 = 8;
					}
					continue;
				case 26:
					_ = ((Array)obj).Length;
					obj = 38;
					break;
				case 7:
					obj = 31;
					break;
				case 55:
					_ = 32767;
					_ = 20;
					continue;
				case 19:
					_ = 32767;
					if (12 == 0)
					{
						_ = 2;
					}
					continue;
				case 25:
					_ = 46;
					continue;
				case 49:
				case 57:
					if ((nint)obj != 757)
					{
						obj2 = 11;
						continue;
					}
					goto case 15;
				case 21:
					obj = this;
					obj2 = 32;
					continue;
				case 35:
					_ = 32767;
					if (24 != 0)
					{
						_ = 16;
					}
					continue;
				case 41:
				case 50:
					if ((nint)obj < ((Array)obj).Length)
					{
						obj2 = 27;
						continue;
					}
					return;
				case 42:
					_ = 39;
					continue;
				case 32:
					if ((nint)obj > 340)
					{
						obj2 = 49;
						continue;
					}
					goto case 8;
				case 34:
					if ((nint)obj != 47)
					{
						obj2 = 44;
						continue;
					}
					goto case 6;
				case 1:
					_ = 19;
					continue;
				case 44:
					if ((nint)obj != 340)
					{
						obj2 = 52;
						continue;
					}
					goto case 6;
				case 28:
					if (7 != 0)
					{
						_ = 1;
					}
					continue;
				case 2:
					obj2 = P_0;
					if (6 != 0)
					{
						obj2 = 14;
					}
					continue;
				case 53:
					_ = 32767;
					obj = 18;
					break;
				case 45:
					_ = 32767;
					_ = 53;
					continue;
				case 30:
					_ = 32767;
					if (1 == 0)
					{
						_ = 1;
					}
					continue;
				case 16:
				case 51:
				case 52:
					throw /*Error near IL_0387: Stack underflow*/;
				default:
					obj = obj;
					if (26 == 0)
					{
						obj2 = 47;
					}
					continue;
				case 36:
					_ = ((Array)obj).Length;
					_ = 54;
					continue;
				case 37:
					if ((nint)obj != 47)
					{
						if (3 != 0)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 35;
				case 33:
					obj2 = P_0;
					_ = ((Array)obj).Length;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 3:
					if ((nint)obj != 340)
					{
						obj2 = 17;
						continue;
					}
					goto case 45;
				case 18:
					_ = 58;
					continue;
				case 10:
					if (26 == 0)
					{
						_ = 24;
					}
					continue;
				case 56:
					if ((nint)obj != 5)
					{
						if (37 == 0)
						{
							obj2 = 25;
						}
						continue;
					}
					goto case 33;
				case 6:
					_ = 32767;
					_ = 55;
					continue;
				case 15:
					_ = 32767;
					_ = 25;
					continue;
				case 27:
				case 48:
					obj = ((object[])obj)[obj];
					obj2 = 13;
					continue;
				case 46:
					_ = 32767;
					if (30 != 0)
					{
						_ = 22;
					}
					continue;
				case 11:
					if ((nint)obj != 763)
					{
						if (5 == 0)
						{
							obj2 = 5;
						}
						continue;
					}
					goto case 15;
				case 12:
					_ = 32767;
					if (9 != 0)
					{
						_ = 1;
					}
					continue;
				case 40:
					_ = 32767;
					_ = 2;
					continue;
				case 8:
					if ((nint)obj != 5)
					{
						if (7 == 0)
						{
							obj2 = 34;
						}
						continue;
					}
					goto case 6;
				case 4:
					return;
				case 39:
					obj = this;
					if (56 == 0)
					{
						obj2 = 40;
					}
					continue;
				case 5:
					if ((nint)obj != 766)
					{
						if (51 == 0)
						{
							obj2 = 10;
						}
						continue;
					}
					goto case 28;
				case 31:
					_ = 32767;
					if (40 == 0)
					{
						_ = 33;
					}
					continue;
				case 13:
					_ = 32767;
					_ = 23;
					continue;
				case 23:
					obj++;
					obj2 = 41;
					continue;
				case 24:
					_ = 36;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00謀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776607, new IntPtr(2737368305868L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00谀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00贀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_00fa: Expected I4, but got Obj
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected Obj, but got Unknown
		//IL_048b: Expected Obj, but got I4
		//IL_0373: Expected Obj, but got I4
		//IL_01dd: Expected Obj, but got I4
		//IL_0543->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0348->IL0019: Incompatible stack heights: 3 vs 1
		//IL_02b3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0160->IL0019: Incompatible stack types: I4 vs Obj
		//IL_022f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01a5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_04c2->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0508->IL0019: Incompatible stack heights: 0 vs 1
		//IL_02df->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0551->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02a3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0526->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0479->IL0019: Incompatible stack heights: 3 vs 1
		//IL_045c->IL0019: Incompatible stack heights: 4 vs 1
		//IL_021a->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0295->IL0019: Incompatible stack heights: 3 vs 1
		//IL_04dd->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0406->IL0019: Incompatible stack heights: 2 vs 1
		//IL_04a5->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0175->IL0019: Incompatible stack heights: 3 vs 1
		//IL_02f4->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0152->IL0019: Incompatible stack heights: 4 vs 1
		//IL_03a7->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0566->IL0019: Incompatible stack heights: 3 vs 1
		//IL_04ed->IL0019: Incompatible stack heights: 2 vs 1
		//IL_018e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0490->IL0015: Incompatible stack heights: 3 vs 0
		//IL_0327->IL0019: Incompatible stack heights: 3 vs 1
		//IL_03b9->IL0019: Incompatible stack heights: 3 vs 1
		//IL_024a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0353->IL0019: Incompatible stack heights: 3 vs 1
		//IL_02be->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01e9->IL0019: Incompatible stack heights: 0 vs 1
		//IL_03f6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_023a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01b0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0433->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0583->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04cd->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0513->IL0019: Incompatible stack types: I4 vs Obj
		//IL_059b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01d8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_027c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0125->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0449->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0411->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0366->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04b0->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0180->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0315->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02ff->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0571->IL0019: Incompatible stack heights: 3 vs 1
		//IL_04f8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01c6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0207->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0332->IL0019: Incompatible stack heights: 3 vs 1
		//IL_03c4->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0255->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01f4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05a6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0287->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0130->IL0019: Incompatible stack heights: 3 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 7;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 4:
				case 30:
					throw /*Error near IL_0110: Stack underflow*/;
				case 41:
					_ = 32767;
					_ = 26;
					continue;
				case 7:
					obj = this;
					obj2 = 6;
					continue;
				case 38:
					_ = 32767;
					if (2 != 0)
					{
						_ = 2;
					}
					continue;
				case 46:
					obj = P_0;
					obj2 = 20;
					continue;
				case 9:
				case 10:
					_ = 32767;
					if (2 == 0)
					{
						_ = 33;
					}
					continue;
				case 48:
					if ((nint)obj != 763)
					{
						obj2 = 16;
						continue;
					}
					goto IL_0110;
				case 18:
					if ((nint)obj != 5)
					{
						obj2 = 11;
						continue;
					}
					goto case 54;
				case 5:
				case 23:
				case 36:
					throw /*Error near IL_01da: Stack underflow*/;
				case 3:
				case 13:
				case 20:
				case 25:
				case 45:
					obj = 0;
					if (51 == 0)
					{
						obj2 = 49;
					}
					continue;
				case 49:
				case 51:
					if (Unsafe.As<object, UIntPtr>(ref obj) < Unsafe.As<object, UIntPtr>(ref obj))
					{
						obj2 = 10;
						continue;
					}
					return;
				case 31:
					_ = 32767;
					_ = 28;
					continue;
				case 8:
					_ = 32767;
					if (38 != 0)
					{
						_ = 12;
					}
					continue;
				case 53:
					obj = P_0;
					if (36 != 0)
					{
						obj2 = 45;
					}
					continue;
				case 19:
					if ((nint)obj != 340)
					{
						if (14 != 0)
						{
							obj2 = 30;
						}
						continue;
					}
					goto case 40;
				case 32:
					_ = 8;
					continue;
				case 24:
					obj = this;
					obj2 = 18;
					continue;
				case 2:
					if (32 == 0)
					{
						_ = 43;
					}
					continue;
				case 17:
					_ = 15;
					continue;
				case 40:
					_ = 32767;
					if (25 != 0)
					{
						_ = 31;
					}
					continue;
				case 39:
					if ((nint)obj != 340)
					{
						obj2 = 36;
						continue;
					}
					goto case 29;
				case 50:
					if (46 != 0)
					{
						_ = 20;
					}
					continue;
				case 22:
					return;
				case 1:
					_ = 32767;
					if (21 == 0)
					{
						_ = 9;
					}
					continue;
				case 35:
					if ((nint)obj != 47)
					{
						obj2 = 39;
						continue;
					}
					goto case 29;
				case 54:
					obj = P_0;
					obj = 25;
					break;
				case 42:
					_ = 32767;
					_ = 44;
					continue;
				case 52:
					if (false)
					{
						_ = 0;
					}
					continue;
				case 6:
					if ((nint)obj <= 340)
					{
						obj2 = 12;
						continue;
					}
					goto case 27;
				case 34:
					if (true)
					{
						_ = 14;
					}
					continue;
				case 11:
					if ((nint)obj != 47)
					{
						obj2 = 19;
						continue;
					}
					goto case 47;
				case 27:
					if ((nint)obj != 757)
					{
						obj2 = 48;
						continue;
					}
					goto IL_0110;
				case 29:
					_ = 32767;
					_ = 37;
					continue;
				case 28:
					_ = 53;
					continue;
				case 47:
					_ = 32767;
					obj = 17;
					break;
				case 37:
					_ = 32767;
					if (16 != 0)
					{
						_ = 42;
					}
					continue;
				case 14:
					if (50 == 0)
					{
						_ = 36;
					}
					continue;
				case 33:
					obj++;
					obj2 = 49;
					continue;
				case 44:
					if (24 == 0)
					{
						_ = 9;
					}
					continue;
				case 15:
					obj = P_0;
					if (13 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 26:
					_ = 32767;
					_ = 34;
					continue;
				default:
					_ = 41;
					continue;
				case 21:
					obj = P_0;
					obj2 = 3;
					continue;
				case 43:
					_ = 32767;
					if (1 == 0)
					{
						_ = 1;
					}
					continue;
				case 12:
					if ((nint)obj != 5)
					{
						obj2 = 35;
						continue;
					}
					goto case 29;
				case 16:
					{
						if ((nint)obj != 766)
						{
							if (5 == 0)
							{
								obj2 = 4;
							}
							continue;
						}
						goto case 52;
					}
					IL_0110:
					_ = 32767;
					if (32 == 0)
					{
						_ = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00踀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776606, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00輀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00退()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776601, new IntPtr(2737368306908L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00鄀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00鈀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776600, new IntPtr(2737368329788L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
