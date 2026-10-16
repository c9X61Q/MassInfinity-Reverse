using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Network.Interface;
using Mass.Game.Proxy.Network.Item;
using Mass.Game.Proxy.Network.Packet;

namespace Mass.Game.Proxy.Packets.Login;

[PacketAllVersion(2)]
[Packet(EnumConnectionState.Login, EnumPacketDirection.Clientbound)]
public class ClientboundLoginSuccessPacket : IPacket, IBufferCodec, IBufferSerializable, IBufferDeserializable
{
	private static object DecorateEfficientFinalizer;

	public Guid Uuid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_F200();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_EB00(value);
		}
	}

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00_EE00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_E400(value);
		}
	}

	public List<SignedProperty> Properties
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
			_FF00_FF00_FF00_FF00_FF00_FF00_F000(value);
		}
	}

	public bool StrictErrorHandling
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return this._FF00_FF00_FF00_FF00_FF00_FF00_FFFD() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_E600(value ? ((byte)1) : ((byte)0));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClientboundLoginSuccessPacket(EnumProtocolVersion version)
	{
		//IL_004a: Expected I4, but got Obj
		//IL_0038->IL0041: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		ClientboundLoginSuccessPacket clientboundLoginSuccessPacket = this;
		if (false)
		{
			clientboundLoginSuccessPacket = (ClientboundLoginSuccessPacket)0;
		}
		switch ((int)clientboundLoginSuccessPacket)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Read(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_E800(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_E000(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Handle(Connection connection)
	{
		return this._FF00_FF00_FF00_FF00_FF00_FF00_FFFD((object)connection) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateAttachedAggregator()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ClientboundLoginSuccessPacket ReflectGlobalTag()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00휀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778229, new IntPtr(2737368330828L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778228, new IntPtr(2737368316268L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<SignedProperty> _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778231, new IntPtr(2737368307948L), 15))(null, 0, new IntPtr(0L));
		return (List<SignedProperty>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<SignedProperty> _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (List<SignedProperty>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<SignedProperty> _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778230, new IntPtr(2737368329788L), 15))(null, 0, new IntPtr(0L));
		return (List<SignedProperty>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed byte _FF00_FF00_FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0083->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0067->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0072->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				if ((nint)P_0 < 766)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 1;
			case 3:
				if (1 == 0)
				{
					_ = 2;
				}
				break;
			case 1:
				return 0;
			default:
				_ = 0;
				if (true)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed byte _FF00_FF00_FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778225, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778224, new IntPtr(2737368302748L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00_FF00_FF00_E000(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_004e: Expected I4, but got Obj
		//IL_010c: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I4
		//IL_0128->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_014b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0133->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ce->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0089->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0156->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0100->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0174->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 9:
					return;
				case 11:
					return;
				case 6:
					if ((nint)this > 767)
					{
						return;
					}
					obj = 10;
					break;
				case 3:
					if (1 == 0)
					{
						_ = 1;
					}
					continue;
				case 2:
				case 5:
					if ((nint)this < 766)
					{
						obj2 = 11;
						continue;
					}
					goto case 6;
				case 1:
					if (7 != 0)
					{
						_ = 1;
					}
					continue;
				case 8:
					if ((nint)this < 763)
					{
						obj2 = 5;
						continue;
					}
					goto default;
				case 4:
					obj = (object)/*Error near IL_0103: Stack underflow*/;
					obj = 3;
					break;
				default:
					if (2 != 0)
					{
						_ = 2;
					}
					continue;
				case 7:
					_ = 32767;
					if (8 == 0)
					{
						_ = 8;
					}
					continue;
				case 10:
					obj2 = obj;
					if (8 != 0)
					{
						obj2 = 9;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_E100(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778227, new IntPtr(2737368305868L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_E200()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778226, new IntPtr(2737368306908L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_E300()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_E400(object P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_E500(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778189, new IntPtr(2737368305868L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_E600(byte P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_E700(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778188, new IntPtr(2737368317308L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00_FF00_FF00_E800(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0046: Expected I4, but got Obj
		//IL_007c: Expected Obj, but got I4
		//IL_00bf->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0117->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0129->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0081->IL0015: Incompatible stack heights: 2 vs 0
		//IL_008e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a4->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00d7->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00fa->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00af->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0064->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00e2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0105->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006f->IL0019: Incompatible stack types: I4 vs Obj
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
				case 2:
					return;
				case 9:
					if ((nint)this >= 763)
					{
						if (2 == 0)
						{
							obj2 = 8;
						}
						continue;
					}
					goto case 4;
				case 6:
					break;
				case 7:
					obj = (object)/*Error near IL_0084: Stack underflow*/;
					obj2 = 6;
					continue;
				case 8:
					if (4 == 0)
					{
						_ = 4;
					}
					continue;
				default:
					_ = 2;
					continue;
				case 1:
					if ((nint)this > 767)
					{
						return;
					}
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 4:
					if ((nint)this < 766)
					{
						return;
					}
					if (0 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 3:
					_ = 16;
					_ = 9;
					continue;
				case 5:
					_ = 3;
					continue;
				}
				break;
			}
			obj = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_E900(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778191, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_EA00(Guid P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778190, new IntPtr(2737368326668L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_EB00(Guid P_0)
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
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_EC00()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_ED00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778185, new IntPtr(2737368310028L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_EE00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_EF00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778184, new IntPtr(2737368302748L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_F000(List<SignedProperty> P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_F100(List<SignedProperty> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778187, new IntPtr(2737368320428L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Guid _FF00_FF00_FF00_FF00_FF00_FF00_F200()
	{
		//IL_000a: Expected VT, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (Guid)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Guid _FF00_FF00_FF00_FF00_FF00_FF00_F300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778186, new IntPtr(2737368312108L), 15))(null, 0, new IntPtr(0L));
		return (Guid)/*Error near IL_0033: Stack underflow*/;
	}
}
