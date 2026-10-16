using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Network.Interface;
using Mass.Game.Proxy.Network.Nbt;
using Mass.Game.Proxy.Network.Packet;

namespace Mass.Game.Proxy.Packets.Play;

[PacketVersion(EnumProtocolVersion.V1710, 45)]
[PacketVersion(EnumProtocolVersion.V189, 45)]
[Packet(EnumConnectionState.Play, EnumPacketDirection.Clientbound)]
[PacketVersion(EnumProtocolVersion.V1181, 46)]
[PacketVersion(EnumProtocolVersion.V1201, 48)]
[PacketVersion(EnumProtocolVersion.V1206, 51)]
[PacketVersion(EnumProtocolVersion.V1211, 51)]
[PacketVersion(EnumProtocolVersion.V1122, 19)]
public class ClientboundOpenWindowPacket : IPacket, IBufferCodec, IBufferSerializable, IBufferDeserializable
{
	internal static ClientboundOpenWindowPacket ReflectModularArgument;

	public int WindowId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_0D00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00ᴀ((uint)value);
		}
	}

	public int WindowType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00Ԁ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00ﴀ((uint)value);
		}
	}

	public string WindowTypeString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_0600();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00ᔀ(value);
		}
	}

	public string WindowTitle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00ጀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_1800(value);
		}
	}

	public NbtTag? NbtWindowTitle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (NbtTag?)_FF00_FF00_2200();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00(value);
		}
	}

	public byte NumberOfSlots
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00Ā();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_0B00(value);
		}
	}

	public bool UseProvidedWindowTitle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00ᄀ() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00ᨀ(value ? ((byte)1) : ((byte)0));
		}
	}

	public int EntityId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00ࠀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_0300((uint)value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClientboundOpenWindowPacket(EnumProtocolVersion version)
	{
		//IL_003a: Expected I4, but got Obj
		//IL_0028->IL0031: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		ClientboundOpenWindowPacket clientboundOpenWindowPacket = this;
		if (0 == 0)
		{
			clientboundOpenWindowPacket = (ClientboundOpenWindowPacket)0;
		}
		switch ((int)clientboundOpenWindowPacket)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Read(IByteBuffer buffer)
	{
		_FF00_FF00_2300(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(IByteBuffer buffer)
	{
		_FF00_FF00_2000(buffer);
	}

	public bool Handle(Connection connection)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LeadController()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ClientboundOpenWindowPacket CollectFinder()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ﰀ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777768, new IntPtr(2737368315228L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00ﴀ(uint P_0)
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
	internal unsafe void _FF00_FE00(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777771, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00(object P_0)
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
	internal byte _FF00_FF00Ā()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00Ȁ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777770, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_0300(uint P_0)
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
	internal unsafe void _FF00_FF00Ѐ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777765, new IntPtr(2737368321468L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00Ԁ()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_0600()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_0700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777764, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00ࠀ()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_0900()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777767, new IntPtr(2737368310028L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_0A00(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777766, new IntPtr(2737368325628L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_0B00(byte P_0)
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
	internal unsafe void _FF00_FF00_0C00(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777761, new IntPtr(2737368316268L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_0D00()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_0E00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777760, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00ༀ()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00က()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777763, new IntPtr(2737368326668L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00ᄀ()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00ሀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777762, new IntPtr(2737368328748L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00ጀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_1400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777789, new IntPtr(2737368307948L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00ᔀ(object P_0)
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
	internal static object _FF00_FF00ᘀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00ᜀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777788, new IntPtr(2737368305868L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_1800(object P_0)
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
	internal unsafe void _FF00_FF00ᤀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777791, new IntPtr(2737368314188L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00ᨀ(byte P_0)
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
	internal unsafe void _FF00_FF00_1B00(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777790, new IntPtr(2737368310028L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00ᰀ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777785, new IntPtr(2737368308988L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00ᴀ(uint P_0)
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
	internal unsafe void _FF00_FF00Ḁ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777784, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_2000(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_009a: Expected I4, but got Obj
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Invalid comparison between Unknown and I4
		//IL_02c9: Expected Obj, but got I4
		//IL_0379->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02ce->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0168->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0105->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01ea->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00ef->IL0019: Incompatible stack heights: 2 vs 1
		//IL_028c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0159->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01cf->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02a0->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00c9->IL0250: Incompatible stack heights: 1 vs 0
		//IL_030f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0209->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01b9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_018e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02b6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_017e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0110->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0300->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01f5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02ea->IL0019: Incompatible stack types: I4 vs Obj
		//IL_032b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b4->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01a1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_035f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_012c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0148->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01da->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0214->IL0019: Incompatible stack types: I4 vs Obj
		//IL_024d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_027d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00bf->IL0019: Incompatible stack types: I4 vs Obj
		//IL_036a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e0->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 11;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 15:
					if ((nint)obj != 47)
					{
						if (6 == 0)
						{
							obj2 = 5;
						}
						continue;
					}
					goto IL_0261;
				case 29:
					obj2 = this;
					if (5 != 0)
					{
						if (23 == 0)
						{
							obj2 = 15;
						}
						continue;
					}
					return;
				case 16:
					_ = 30;
					continue;
				case 9:
					_ = 32767;
					if (5 != 0)
					{
						_ = 28;
					}
					continue;
				case 21:
					obj2 = P_0;
					if (12 != 0)
					{
						obj2 = 8;
					}
					continue;
				case 23:
					obj2 = P_0;
					if (18 == 0)
					{
						obj2 = 16;
					}
					continue;
				case 24:
					_ = 22;
					continue;
				case 7:
					_ = 9;
					continue;
				case 6:
					if ((nint)obj != 340)
					{
						obj2 = 2;
						continue;
					}
					goto IL_0261;
				case 18:
					return;
				case 19:
					if ((nint)this == 11)
					{
						obj2 = 17;
						continue;
					}
					return;
				case 1:
					if (obj - 766 > 1)
					{
						obj2 = 27;
						continue;
					}
					obj2 = P_0;
					if (7 != 0)
					{
						obj2 = 13;
					}
					continue;
				case 25:
					_ = 32767;
					if (3 != 0)
					{
						_ = 16;
					}
					continue;
				case 11:
					obj = this;
					if (10 == 0)
					{
						obj2 = 10;
					}
					continue;
				default:
					if ((nint)obj != 5)
					{
						if (15 == 0)
						{
							obj2 = 3;
						}
						continue;
					}
					goto case 21;
				case 28:
					return;
				case 22:
					return;
				case 2:
				case 27:
					throw /*Error near IL_0250: Stack underflow*/;
				case 14:
					return;
				case 17:
					_ = 14;
					continue;
				case 26:
					_ = 32767;
					_ = 4;
					continue;
				case 3:
				case 8:
					if ((nint)obj != 757)
					{
						obj2 = 20;
						continue;
					}
					goto IL_017f;
				case 5:
					break;
				case 12:
					obj2 = P_0;
					if (11 == 0)
					{
						obj2 = 25;
					}
					continue;
				case 10:
					if ((nint)obj > 340)
					{
						obj2 = 8;
						continue;
					}
					goto default;
				case 30:
					_ = 19;
					continue;
				case 13:
					obj2 = P_0;
					if (6 != 0)
					{
						obj2 = 24;
					}
					continue;
				case 20:
					if ((nint)obj != 763)
					{
						if (1 == 0)
						{
							obj2 = 0;
						}
						continue;
					}
					goto IL_017f;
				case 4:
					{
						_ = 29;
						continue;
					}
					IL_0261:
					obj2 = P_0;
					if (2 == 0)
					{
						obj2 = 5;
					}
					continue;
					IL_017f:
					_ = 7;
					continue;
				}
				break;
			}
			_ = 32767;
			obj = 26;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_2100()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777787, new IntPtr(2737368314188L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_2200()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_2300(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_009e: Expected I4, but got Obj
		//IL_0221: Expected Obj, but got I4
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Invalid comparison between Unknown and I4
		//IL_02f4: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I4
		//IL_0334: Expected Obj, but got I4
		//IL_00e0->IL0019: Incompatible stack heights: 3 vs 1
		//IL_02e7->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01c9->IL0019: Incompatible stack heights: 3 vs 1
		//IL_031f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01f6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b1->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0188->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0247->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0226->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0123->IL02d9: Incompatible stack heights: 1 vs 0
		//IL_02f9->IL0015: Incompatible stack heights: 2 vs 0
		//IL_014f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_016a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_010a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_029f->IL0019: Incompatible stack heights: 4 vs 1
		//IL_019b->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0214->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00eb->IL0019: Incompatible stack heights: 3 vs 1
		//IL_02bd->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01b0->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01dd->IL0019: Incompatible stack heights: 0 vs 1
		//IL_028f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0239->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0256->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0311->IL0019: Incompatible stack types: I4 vs Obj
		//IL_026e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_015a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0175->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0115->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01bb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01e8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_013a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0279->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 14;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 15:
					_ = 9;
					continue;
				default:
					if ((nint)obj != 763)
					{
						obj = 20;
						break;
					}
					goto IL_0206;
				case 1:
					_ = 32767;
					if (11 != 0)
					{
						_ = 12;
					}
					continue;
				case 28:
					if (6 != 0)
					{
						_ = 15;
					}
					continue;
				case 31:
					return;
				case 17:
				case 24:
					throw /*Error near IL_0118: Stack underflow*/;
				case 21:
					return;
				case 22:
					obj2 = this;
					if (5 == 0)
					{
						if (21 != 0)
						{
							obj2 = 21;
						}
						continue;
					}
					goto case 2;
				case 26:
					_ = 32767;
					if (true)
					{
						_ = 1;
					}
					continue;
				case 27:
					if (16 == 0)
					{
						_ = 10;
					}
					continue;
				case 16:
					_ = 32767;
					_ = 28;
					continue;
				case 30:
					_ = 32767;
					_ = 8;
					continue;
				case 3:
					if ((nint)obj != 47)
					{
						if (0 == 0)
						{
							obj2 = 7;
						}
						continue;
					}
					goto IL_02af;
				case 6:
					_ = 30;
					continue;
				case 4:
					if ((nint)obj != 5)
					{
						if (2 == 0)
						{
							obj2 = 3;
						}
						continue;
					}
					goto case 25;
				case 14:
					obj = this;
					obj2 = 13;
					continue;
				case 5:
					return;
				case 19:
					obj = 29;
					break;
				case 9:
					if ((nint)this != 11)
					{
						return;
					}
					obj2 = 18;
					continue;
				case 18:
					_ = 10;
					continue;
				case 8:
					return;
				case 11:
					_ = 19;
					continue;
				case 23:
					if ((nint)obj != 757)
					{
						if (0 == 0)
						{
							obj2 = 0;
						}
						continue;
					}
					goto IL_0206;
				case 7:
					if ((nint)obj != 340)
					{
						obj2 = 17;
						continue;
					}
					goto IL_02af;
				case 29:
					_ = 31;
					continue;
				case 10:
					return;
				case 2:
					_ = 5;
					continue;
				case 25:
					obj = 27;
					break;
				case 20:
					if (obj - 766 > 1)
					{
						goto case 17;
					}
					obj2 = 11;
					continue;
				case 12:
					_ = 22;
					continue;
				case 13:
					{
						if ((nint)obj <= 340)
						{
							obj = 4;
							break;
						}
						goto case 23;
					}
					IL_0206:
					_ = 6;
					continue;
					IL_02af:
					_ = 26;
					continue;
				}
				break;
			}
		}
	}
}
