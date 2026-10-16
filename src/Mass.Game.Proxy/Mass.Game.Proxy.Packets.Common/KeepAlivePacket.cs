using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Network.Interface;
using Mass.Game.Proxy.Network.Packet;

namespace Mass.Game.Proxy.Packets.Common;

public abstract class KeepAlivePacket : IPacket, IBufferCodec, IBufferSerializable, IBufferDeserializable
{
	internal static KeepAlivePacket DecorateAdaptableFilter;

	public long KeepAliveId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return this._FF00_FF00_FF00_FF00_FFFD();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			this._FF00_FF00_FF00_FF00_FFFD(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected KeepAlivePacket(EnumProtocolVersion version)
	{
		//IL_003a: Expected I4, but got Obj
		//IL_0028->IL0031: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		KeepAlivePacket keepAlivePacket = this;
		if (0 == 0)
		{
			keepAlivePacket = (KeepAlivePacket)0;
		}
		switch ((int)keepAlivePacket)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Read(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00휀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00혀(buffer);
	}

	public bool Handle(Connection connection)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VisitGateway()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static KeepAlivePacket ConcatProfiler()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00픀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778010, new IntPtr(2737368317308L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00혀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_0060->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b6->IL0019: Incompatible stack heights: 0 vs 1
		//IL_007d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0050->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0096->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00c1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a1->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				return;
			case 4:
				return;
			case 2:
				_ = (int)this;
				_ = 5;
				break;
			case 6:
				obj2 = P_0;
				_ = (int)this;
				if (4 != 0)
				{
					obj2 = 3;
				}
				break;
			case 5:
				return;
			default:
				if ((nint)this >= 340)
				{
					_ = 3;
				}
				else if (6 == 0)
				{
					obj2 = 4;
				}
				break;
			case 1:
				if ((nint)this >= 47)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00휀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_004a: Expected I4, but got Obj
		//IL_010e: Expected Obj, but got I8
		//IL_00d1: Expected Obj, but got I8
		//IL_006e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0118->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00dd->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0094->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0087->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0079->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00fd->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0130->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0108->IL0019: Incompatible stack types: I4 vs Obj
		//IL_013b->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 7;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				obj = P_0;
				if (6 == 0)
				{
					obj2 = 10;
				}
				break;
			case 3:
			case 5:
			case 10:
				_ = 8;
				break;
			case 7:
				obj2 = 6;
				break;
			case 4:
				obj = (long)P_0;
				if (2 == 0)
				{
					obj2 = 3;
				}
				break;
			case 6:
				if ((nint)this >= 47)
				{
					if (false)
					{
						obj2 = 2;
					}
					break;
				}
				goto case 4;
			case 8:
				return;
			case 1:
				obj = (long)P_0;
				obj2 = 5;
				break;
			case 2:
			case 9:
				if ((nint)this < 340)
				{
					if (true)
					{
						obj2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778005, new IntPtr(2737368318348L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal long _FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_000a: Expected I8, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (long)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778004, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FFFD()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778007, new IntPtr(2737368314188L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FFFD(long P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FFFD(long P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778006, new IntPtr(2737368321468L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
