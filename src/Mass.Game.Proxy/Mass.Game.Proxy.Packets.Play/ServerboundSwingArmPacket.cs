using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Network.Interface;
using Mass.Game.Proxy.Network.Packet;

namespace Mass.Game.Proxy.Packets.Play;

[Packet(EnumConnectionState.Play, EnumPacketDirection.Serverbound)]
[PacketVersion(EnumProtocolVersion.V1211, 54)]
[PacketVersion(EnumProtocolVersion.V1201, 47)]
[PacketVersion(EnumProtocolVersion.V1181, 44)]
[PacketVersion(EnumProtocolVersion.V1122, 29)]
[PacketVersion(EnumProtocolVersion.V189, 10)]
[PacketVersion(EnumProtocolVersion.V1710, 10)]
[PacketVersion(EnumProtocolVersion.V1206, 54)]
public class ServerboundSwingArmPacket : IPacket, IBufferCodec, IBufferSerializable, IBufferDeserializable
{
	internal static ServerboundSwingArmPacket SplitRunner;

	public int EntityId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00_FF00_FF00_FF00_FF00鬀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00ꈀ((uint)value);
		}
	}

	public byte Animation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FF00鰀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00ꘀ(value);
		}
	}

	public int Hand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00_FF00_FF00_FF00_FF00가();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00_AB00((uint)value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ServerboundSwingArmPacket(EnumProtocolVersion version)
	{
		//IL_003a: Expected I4, but got Obj
		//IL_0028->IL0031: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		ServerboundSwingArmPacket serverboundSwingArmPacket = this;
		if (0 == 0)
		{
			serverboundSwingArmPacket = (ServerboundSwingArmPacket)0;
		}
		switch ((int)serverboundSwingArmPacket)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Read(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00ꀀ(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00ꠀ(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Handle(Connection connection)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00_FF00頀(connection) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateSymbolicMapper()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerboundSwingArmPacket OpenListener()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00需(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777561, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00頀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0066->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0047->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0085->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0052->IL0019: Incompatible stack types: I4 vs Obj
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
				if ((nint)this == 5)
				{
					if (0 == 0)
					{
						obj2 = 1;
					}
					break;
				}
				goto IL_0056;
			case 3:
				return 0;
			default:
				return 0;
			case 1:
				{
					if ((nint)this != 1)
					{
						if (false)
						{
							obj2 = 0;
						}
						break;
					}
					goto IL_0056;
				}
				IL_0056:
				obj2 = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00餀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777560, new IntPtr(2737368321468L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00_FF00騀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777563, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00_FF00_FF00_FF00_FF00鬀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00鰀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00鴀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777562, new IntPtr(2737368310028L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00鸀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00鼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777557, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꀀ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003e: Expected I4, but got Obj
		//IL_00ac->IL0019: Incompatible stack heights: 0 vs 1
		//IL_009c->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0083->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0057->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e7->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00b7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00f2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d3->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 5:
				return;
			default:
				if ((nint)obj == 47)
				{
					return;
				}
				obj2 = 6;
				break;
			case 7:
				if (2 != 0)
				{
					_ = 3;
				}
				break;
			case 3:
				_ = 4;
				break;
			case 2:
				obj = this;
				if (true)
				{
					obj2 = 1;
				}
				break;
			case 4:
				return;
			case 6:
				if (3 == 0)
				{
					_ = 5;
				}
				break;
			case 1:
				if ((nint)obj != 5)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 7;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꄀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777556, new IntPtr(2737368312108L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꈀ(uint P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꌀ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777559, new IntPtr(2737368329788L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꐀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777558, new IntPtr(2737368305868L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꔀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꘀ(byte P_0)
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
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_A700(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777553, new IntPtr(2737368302748L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꠀ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003e: Expected I4, but got Obj
		//IL_00cb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b2->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00bd->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 7;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				return;
			case 6:
				if ((nint)obj != 5)
				{
					obj2 = 4;
					break;
				}
				goto case 3;
			case 3:
				obj2 = P_0;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				obj2 = P_0;
				if (5 != 0)
				{
					obj2 = 5;
				}
				break;
			case 4:
				if ((nint)obj == 47)
				{
					return;
				}
				if (2 == 0)
				{
					obj2 = 2;
				}
				break;
			case 7:
				obj = this;
				obj2 = 6;
				break;
			case 5:
				return;
			case 2:
				obj2 = P_0;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00꤀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777552, new IntPtr(2737368314188L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꨀ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777555, new IntPtr(2737368331868L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_AB00(uint P_0)
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
	internal uint _FF00_FF00_FF00_FF00_FF00_FF00_FF00가()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00_FF00관()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777554, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}
}
