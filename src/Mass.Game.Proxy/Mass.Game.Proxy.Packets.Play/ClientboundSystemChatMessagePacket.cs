using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Network.Component.Chat;
using Mass.Game.Proxy.Network.Interface;
using Mass.Game.Proxy.Network.Nbt;
using Mass.Game.Proxy.Network.Packet;

namespace Mass.Game.Proxy.Packets.Play;

[PacketVersion(EnumProtocolVersion.V1206, 108)]
[Packet(EnumConnectionState.Play, EnumPacketDirection.Clientbound)]
[PacketVersion(EnumProtocolVersion.V1211, 108)]
[PacketVersion(EnumProtocolVersion.V1201, 100)]
public class ClientboundSystemChatMessagePacket : IPacket, IBufferCodec, IBufferSerializable, IBufferDeserializable
{
	private static object? GetCache;

	public NbtTag? NbtContent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (NbtTag?)관();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			됀(value);
		}
	}

	public string? Content
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string?)똀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			꼀(value);
		}
	}

	public bool Overlay
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 넀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			ꠀ(value ? ((byte)1) : ((byte)0));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClientboundSystemChatMessagePacket(EnumProtocolVersion version)
	{
		//IL_003a: Expected I4, but got Obj
		//IL_0028->IL0031: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		ClientboundSystemChatMessagePacket clientboundSystemChatMessagePacket = this;
		if (0 == 0)
		{
			clientboundSystemChatMessagePacket = (ClientboundSystemChatMessagePacket)0;
		}
		switch ((int)clientboundSystemChatMessagePacket)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClientboundSystemChatMessagePacket(EnumProtocolVersion version, TextComponent text)
	{
		//IL_0056->IL002a: Incompatible stack heights: 4 vs 2
		//IL_0089->IL002a: Incompatible stack heights: 1 vs 2
		//IL_00a4->IL002a: Incompatible stack heights: 4 vs 2
		//IL_0094->IL002a: Incompatible stack heights: 1 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		int num = (int)version;
		if (false)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				_ = 2;
				break;
			default:
				if (version < EnumProtocolVersion.V1206)
				{
					if (3 != 0)
					{
						_ = 3;
					}
					break;
				}
				goto case 1;
			case 4:
				return;
			case 2:
				return;
			case 3:
				_ = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Read(IByteBuffer buffer)
	{
		ꘀ(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(IByteBuffer buffer)
	{
		_AB00(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Handle(Connection connection)
	{
		return ꨀ(connection) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DisableUser()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ClientboundSystemChatMessagePacket? ReflectStatelessDispatcher()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte ꈀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777471, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte ꌀ()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object? ꐀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object?)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object? ꔀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777470, new IntPtr(2737368302748L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void ꘀ(object? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00a5->IL0019: Incompatible stack heights: 4 vs 1
		//IL_00ba->IL0019: Incompatible stack heights: 3 vs 1
		//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00c5->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0056->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0095->IL0019: Incompatible stack types: I4 vs Obj
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
			case 5:
				if (4 == 0)
				{
					_ = 4;
				}
				continue;
			case 1:
				if ((nint)this >= 766)
				{
					if (false)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
			default:
				_ = 5;
				continue;
			case 2:
				break;
			case 4:
				return;
			}
			_ = 32767;
			if (2 == 0)
			{
				_ = 3;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _A700(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777465, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void ꠀ(byte P_0)
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
	internal unsafe void _꤀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777464, new IntPtr(2737368322508L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed byte ꨀ(object? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003e: Expected I4, but got Obj
		//IL_00d8: Expected I4, but got Obj
		//IL_00aa->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00c4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00b5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0079->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0066->IL0019: Incompatible stack types: I4 vs Obj
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
				if ((nint)this < 766)
				{
					if (true)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 4;
			case 5:
				return 0;
			default:
				if (obj == null)
				{
					obj2 = 5;
					break;
				}
				obj = obj;
				_ = 3;
				break;
			case 4:
				obj = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
			case 6:
				obj = this;
				obj2 = 7;
				break;
			case 3:
				return (byte)(int)obj;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _AB00(object? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_008b: Expected Obj, but got I4
		//IL_00c0->IL0019: Incompatible stack heights: 3 vs 1
		//IL_006b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ac->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0076->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		while (true)
		{
			object? obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					return;
				case 0:
					return;
				case 4:
					if (1 == 0)
					{
						_ = 1;
					}
					continue;
				case 5:
					if ((nint)this < 766)
					{
						break;
					}
					goto end_IL_0019;
				case 1:
				case 3:
					obj2 = P_0;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 2:
					break;
				}
				_ = 32767;
				_ = 3;
				continue;
				end_IL_0019:
				break;
			}
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? 가()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777467, new IntPtr(2737368326668L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object? 관()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? 글()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777466, new IntPtr(2737368315228L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 꼀(object? P_0)
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
	internal unsafe byte 뀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777461, new IntPtr(2737368325628L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte 넀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte 눀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777460, new IntPtr(2737368320428L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 대(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777463, new IntPtr(2737368331868L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 됀(object? P_0)
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
	internal unsafe void 딀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777462, new IntPtr(2737368316268L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object? 똀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? 뜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777457, new IntPtr(2737368325628L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}
}
