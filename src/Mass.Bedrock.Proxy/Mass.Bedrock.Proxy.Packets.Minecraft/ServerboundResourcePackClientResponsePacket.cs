using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Bedrock.Proxy.Network.Minecraft.Enums;
using Mass.Bedrock.Proxy.Network.Packet;

namespace Mass.Bedrock.Proxy.Packets.Minecraft;

[Packet(EnumPacketDirection.Serverbound, 8u)]
public class ServerboundResourcePackClientResponsePacket : PacketBase
{
	internal static ServerboundResourcePackClientResponsePacket ReflectJoinedReceiver;

	public EnumResponseStatus Status
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return this._FF00_FF00_FF00_FF00_FF00_FF00_FFFD();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00휀(value);
		}
	}

	public List<string> PackIds
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return this._FF00_FF00_FF00_FF00_FF00_FF00_FFFD();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00퐀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Read(IByteBuffer buffer)
	{
		this._FF00_FF00_FF00_FF00_FF00_FF00_FFFD((object)buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(IByteBuffer buffer)
	{
		this._FF00_FF00_FF00_FF00_FF00_FF00_FFFD((object)buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ServerboundResourcePackClientResponsePacket()
	{
		//IL_003a: Expected I4, but got Obj
		//IL_0028->IL0031: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		ServerboundResourcePackClientResponsePacket serverboundResourcePackClientResponsePacket = this;
		if (false)
		{
			serverboundResourcePackClientResponsePacket = (ServerboundResourcePackClientResponsePacket)0;
		}
		switch ((int)serverboundResourcePackClientResponsePacket)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckLiteralProc()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerboundResourcePackClientResponsePacket CheckScalableSpec()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00팀(List<string> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778744, new IntPtr(2737337529404L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00퐀(List<string> P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00픀(List<string> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778745, new IntPtr(2737337519004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00혀(EnumResponseStatus P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778746, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00휀(EnumResponseStatus P_0)
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0042: Expected I4, but got Obj
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_0059: Expected Obj, but got I4
		//IL_0082->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00c0->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00db->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00f7->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0065->IL0019: Incompatible stack heights: 0 vs 1
		//IL_008d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00cb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0102->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0070->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b0->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				obj = 0;
				if (5 != 0)
				{
					obj2 = 7;
				}
				break;
			default:
				obj++;
				if (3 == 0)
				{
					obj2 = 5;
				}
				break;
			case 6:
				return;
			case 5:
			case 7:
				if (Unsafe.As<object, UIntPtr>(ref obj) >= Unsafe.As<object, UIntPtr>(ref obj))
				{
					return;
				}
				obj2 = 8;
				break;
			case 1:
				obj = P_0;
				if (4 == 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				if (true)
				{
					_ = 1;
				}
				break;
			case 3:
			case 8:
				if (false)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778747, new IntPtr(2737337531484L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778748, new IntPtr(2737337523164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0047: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got Ref
		//IL_00d1: Expected Obj, but got I4
		//IL_004c->IL0015: Incompatible stack heights: 1 vs 0
		//IL_005e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0085->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0069->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00f2->IL00a6: Incompatible stack heights: 1 vs 0
		//IL_00a6->IL00a6: Incompatible stack heights: 1 vs 0
		//IL_0102->IL00a6: Incompatible stack heights: 2 vs 0
		//IL_010d->IL00a6: Incompatible stack heights: 2 vs 0
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 3:
					return;
				case 4:
					obj = this;
					if (2 == 0)
					{
						obj2 = 2;
					}
					continue;
				case 1:
					obj2 = P_0;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 2:
					while (true)
					{
						if (&obj == null)
						{
							obj = 3;
							goto IL_00a6;
						}
						goto IL_00d6;
						IL_00a6:
						while (true)
						{
							switch ((int)/*Error near IL_00bb: Stack underflow*/)
							{
							case 3:
								return;
							case 2:
								break;
							default:
								goto IL_00d6;
							case 1:
								if (2 == 0)
								{
									_ = 2;
								}
								continue;
							}
							break;
						}
						continue;
						IL_00d6:
						obj = (object)(&obj);
						if (0 == 0)
						{
							_ = 1;
						}
						goto IL_00a6;
					}
				}
				break;
			}
			_ = (ushort)this;
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<string> _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (List<string>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal EnumResponseStatus _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (EnumResponseStatus)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe EnumResponseStatus _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778749, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		return (EnumResponseStatus)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778750, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_E000()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_E100()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778751, new IntPtr(2737337527324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_E200()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}
}
