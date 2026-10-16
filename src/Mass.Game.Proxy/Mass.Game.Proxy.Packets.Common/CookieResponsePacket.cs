using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Network;
using Mass.Game.Proxy.Network.Interface;
using Mass.Game.Proxy.Network.Packet;

namespace Mass.Game.Proxy.Packets.Common;

public class CookieResponsePacket : IPacket, IBufferCodec, IBufferSerializable, IBufferDeserializable
{
	internal static CookieResponsePacket ReflectFlexibleProvider;

	public string Key
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_ED00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00豈(value);
		}
	}

	public Optional<byte[]> Data
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00ﬀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FE00(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CookieResponsePacket(EnumProtocolVersion version)
	{
		//IL_0042: Expected I4, but got Obj
		//IL_0030->IL0039: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		CookieResponsePacket cookieResponsePacket = this;
		if (0 == 0)
		{
			cookieResponsePacket = (CookieResponsePacket)0;
		}
		switch ((int)cookieResponsePacket)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Read(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00_F700(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00_EF00(buffer);
	}

	public bool Handle(Connection connection)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckSegmentedCalc()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CookieResponsePacket CheckCommonTree()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_EC00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777997, new IntPtr(2737368310028L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_ED00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_EE00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777996, new IntPtr(2737368319388L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00_EF00(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0091: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I4
		//IL_0096->IL0015: Incompatible stack heights: 2 vs 0
		//IL_00a6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0052->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006b->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00b1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005d->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 3:
					if (1 == 0)
					{
						_ = 0;
					}
					continue;
				case 4:
					_ = 2;
					continue;
				case 5:
					obj = (object)/*Error near IL_006e: Stack underflow*/;
					obj = 4;
					break;
				default:
					_ = 32767;
					obj = 3;
					break;
				case 2:
					if (false)
					{
						_ = 0;
					}
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_F000(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777999, new IntPtr(2737368317308L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_F100()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_F200()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777998, new IntPtr(2737368316268L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_F300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777993, new IntPtr(2737368302748L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_F400()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_F500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777992, new IntPtr(2737368314188L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_F600(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777995, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00_F700(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00a8->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00b7->IL0019: Incompatible stack heights: 0 vs 1
		//IL_006c->IL0019: Incompatible stack heights: 3 vs 1
		//IL_008f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0077->IL0019: Incompatible stack heights: 3 vs 1
		//IL_009a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0056->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 5:
				if (2 != 0)
				{
					_ = 4;
				}
				break;
			case 2:
				if (1 == 0)
				{
					_ = 3;
				}
				break;
			case 3:
				return;
			case 4:
				_ = 32767;
				if (2 != 0)
				{
					_ = 2;
				}
				break;
			default:
				_ = 5;
				break;
			case 1:
				obj = (object)/*Error near IL_00ab: Stack underflow*/;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_F800(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777994, new IntPtr(2737368301708L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00豈(object P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00切(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777989, new IntPtr(2737368321468L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Optional<byte[]> _FF00_FF00_FF00_FF00ﬀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (Optional<byte[]>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Optional<byte[]> _FF00_FF00_FF00_FF00ﰀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777988, new IntPtr(2737368322508L), 15))(null, 0, new IntPtr(0L));
		return (Optional<byte[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00ﴀ(Optional<byte[]> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777991, new IntPtr(2737368312108L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FE00(Optional<byte[]> P_0)
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
}
