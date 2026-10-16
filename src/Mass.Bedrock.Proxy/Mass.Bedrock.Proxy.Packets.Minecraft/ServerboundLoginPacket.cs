using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Bedrock.Proxy.Minecraft;
using Mass.Bedrock.Proxy.Network.Minecraft.Enums;
using Mass.Bedrock.Proxy.Network.Packet;

namespace Mass.Bedrock.Proxy.Packets.Minecraft;

[Packet(EnumPacketDirection.Serverbound, 1u)]
public class ServerboundLoginPacket : PacketBase
{
	internal static ServerboundLoginPacket BuildProvider;

	public int ProtocolVersion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00_FF00_FF00_FF00뤀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00븀((uint)value);
		}
	}

	public string ChainData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00딀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00뜀(value);
		}
	}

	public string ClientData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00ꀀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00鸀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Read(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00꼀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00넀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Handle(Connection connection)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00글(connection) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ServerboundLoginPacket()
	{
		//IL_0042: Expected I4, but got Obj
		//IL_0030->IL0039: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		ServerboundLoginPacket serverboundLoginPacket = this;
		if (0 == 0)
		{
			serverboundLoginPacket = (ServerboundLoginPacket)0;
		}
		switch ((int)serverboundLoginPacket)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectFlexibleBuilder()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerboundLoginPacket CheckSegmentedField()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00鴀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778722, new IntPtr(2737337520044L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00鸀(object P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00鼀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778723, new IntPtr(2737337516924L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00ꀀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00ꄀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778724, new IntPtr(2737337510684L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00글(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0102: Expected I4, but got Obj
		//IL_0125: Expected Obj, but got I4
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected Obj, but got I4
		//IL_02ed: Expected Obj, but got Ref
		//IL_02b7: Expected Obj, but got I4
		//IL_03b6: Expected Obj, but got I4
		//IL_0333: Expected Obj, but got I4
		//IL_05a2: Expected Obj, but got I4
		//IL_03cc: Expected Obj, but got I4
		//IL_04db->IL0019: Incompatible stack heights: 2 vs 1
		//IL_012a->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0399->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0516->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02dd->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0218->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0153->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0116->IL0019: Incompatible stack heights: 2 vs 1
		//IL_03e0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0177->IL0019: Incompatible stack heights: 4 vs 1
		//IL_01ad->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03f5->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0473->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0160->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01bd->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0139->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0525->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0347->IL0019: Incompatible stack types: I4 vs Obj
		//IL_05c7->IL0019: Incompatible stack heights: 3 vs 1
		//IL_04f5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0379->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0316->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0565->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0552->IL0019: Incompatible stack types: I4 vs Obj
		//IL_049e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0200->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0369->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0406->IL0019: Incompatible stack heights: 3 vs 1
		//IL_02f9->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0508->IL0019: Incompatible stack heights: 4 vs 1
		//IL_02bc->IL0015: Incompatible stack heights: 1 vs 0
		//IL_04ad->IL0019: Incompatible stack heights: 0 vs 1
		//IL_02cc->IL0019: Incompatible stack heights: 3 vs 1
		//IL_04c9->IL0019: Incompatible stack heights: 3 vs 1
		//IL_03a6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_043a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_029e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0358->IL0019: Incompatible stack heights: 3 vs 1
		//IL_03bb->IL0015: Incompatible stack heights: 2 vs 0
		//IL_05b6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0325->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01d6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0536->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0457->IL0019: Incompatible stack heights: 2 vs 1
		//IL_022d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_05a7->IL0015: Incompatible stack heights: 2 vs 0
		//IL_01e5->IL0019: Incompatible stack heights: 0 vs 1
		//IL_04e6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02e8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0182->IL0019: Incompatible stack heights: 4 vs 1
		//IL_047e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01c8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0144->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0384->IL0019: Incompatible stack heights: 2 vs 1
		//IL_019d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0570->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0280->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0249->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0304->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04b8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0445->IL0019: Incompatible stack heights: 3 vs 1
		//IL_02a9->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0586->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0541->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0462->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01f0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0591->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 10;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 9:
					_ = 41;
					continue;
				case 2:
					obj = 26;
					break;
				case 18:
					obj = (object)/*Error near IL_012d: Stack underflow*/;
					if (24 == 0)
					{
						obj2 = 49;
					}
					continue;
				case 8:
					obj = obj;
					obj2 = 19;
					continue;
				case 16:
					obj = (object)/*Error near IL_0156: Stack underflow*/;
					obj2 = 54;
					continue;
				case 11:
					_ = 0;
					if (3 != 0)
					{
						_ = 23;
					}
					continue;
				case 24:
					obj2 = obj;
					if (25 == 0)
					{
						obj2 = 40;
					}
					continue;
				case 12:
					obj = obj;
					obj2 = 27;
					continue;
				case 17:
					obj = obj;
					if (8 != 0)
					{
						obj2 = 8;
					}
					continue;
				case 49:
					_ = 52;
					continue;
				case 56:
					obj = (object)/*Error near IL_01d9: Stack underflow*/;
					if (false)
					{
						obj2 = 0;
					}
					continue;
				case 32:
					_ = 2;
					continue;
				case 7:
				{
					object obj3 = obj;
					_ = /*Error near IL_020d: Stack underflow*/| ((long)obj3 << 32);
					_ = 53;
					continue;
				}
				case 53:
					obj = obj;
					_ = ref obj;
					_ = 31;
					continue;
				case 30:
					obj2 = obj;
					if (34 == 0)
					{
						obj2 = 9;
					}
					continue;
				case 14:
				case 29:
					obj2 = obj;
					if (36 != 0)
					{
						obj2 = 36;
					}
					continue;
				case 43:
					obj = P_0;
					_ = ref obj;
					if (3 != 0)
					{
						_ = 22;
					}
					continue;
				case 37:
					obj = 47;
					break;
				case 39:
					_ = 33;
					continue;
				case 5:
					obj = this;
					if (6 != 0)
					{
						obj2 = 12;
					}
					continue;
				case 35:
					obj = (object)(&obj);
					if (1 == 0)
					{
						obj2 = 11;
					}
					continue;
				case 25:
					_ = 28;
					continue;
				case 48:
					_ = 38;
					continue;
				case 46:
					obj = obj;
					obj = 18;
					break;
				case 20:
					obj = obj;
					obj2 = 46;
					continue;
				case 44:
					_ = 43;
					continue;
				case 33:
					_ = 48;
					continue;
				case 23:
					_ = 0;
					if (55 == 0)
					{
						_ = 50;
					}
					continue;
				case 3:
					obj = obj;
					_ = ref obj;
					_ = 37;
					continue;
				case 41:
					obj2 = 4;
					continue;
				case 45:
					obj = 25;
					break;
				case 6:
					if ((nint)obj != 8)
					{
						obj = 14;
						break;
					}
					goto case 56;
				case 10:
					obj = P_0;
					obj2 = 9;
					continue;
				case 13:
					obj = 42;
					break;
				case 34:
					_ = 45;
					continue;
				case 42:
					obj = obj;
					if (false)
					{
						_ = 35;
					}
					continue;
				case 52:
					if (9 == 0)
					{
						_ = 17;
					}
					continue;
				case 15:
					obj = obj;
					if (5 != 0)
					{
						obj2 = 0;
					}
					continue;
				case 31:
					_ = 44;
					continue;
				case 38:
					obj = (object)/*Error near IL_04a1: Stack underflow*/;
					if (20 == 0)
					{
						obj2 = 4;
					}
					continue;
				case 40:
					_ = 51;
					continue;
				case 1:
					if (11 == 0)
					{
						_ = 13;
					}
					continue;
				case 22:
					_ = 3;
					continue;
				default:
					_ = 32;
					continue;
				case 4:
					obj = P_0;
					obj2 = 15;
					continue;
				case 19:
					obj = P_0;
					obj2 = 50;
					continue;
				case 51:
					obj = this;
					if (21 == 0)
					{
						obj2 = 6;
					}
					continue;
				case 27:
					obj = obj;
					obj2 = 39;
					continue;
				case 26:
					if (1 == 0)
					{
						_ = 1;
					}
					continue;
				case 28:
					return 0;
				case 50:
					if ((nint)obj != 2)
					{
						if (6 != 0)
						{
							obj2 = 2;
						}
						continue;
					}
					goto case 16;
				case 55:
					obj = 24;
					break;
				case 47:
					_ = 30;
					continue;
				case 21:
					_ = 7;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00꼀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_009e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0080->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0048->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0066->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00a9->IL0019: Incompatible stack heights: 3 vs 1
		//IL_008b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0053->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0071->IL0019: Incompatible stack heights: 3 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				return;
			case 3:
				if (2 == 0)
				{
					_ = 0;
				}
				break;
			case 4:
				if (0 == 0)
				{
					_ = 1;
				}
				break;
			case 2:
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				if (false)
				{
					_ = 4;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00뀀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778725, new IntPtr(2737337520044L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00넀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0042: Expected I4, but got Obj
		//IL_0058->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0077->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a6->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00e6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0067->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0093->IL0019: Incompatible stack types: I4 vs Obj
		//IL_010f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00f1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00cd->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				_ = ((Array)obj).Length;
				_ = 7;
				break;
			case 6:
				_ = 5;
				break;
			case 3:
				obj = this;
				obj2 = 6;
				break;
			case 1:
				obj2 = P_0;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 8:
				return;
			case 4:
				obj = this;
				if (0 == 0)
				{
					obj2 = 3;
				}
				break;
			case 7:
				obj2 = P_0;
				if (4 == 0)
				{
					obj2 = 8;
				}
				break;
			case 5:
				_ = ((Array)obj).Length + ((Array)obj).Length + 8;
				if (1 == 0)
				{
					_ = 2;
				}
				break;
			case 2:
				obj2 = P_0;
				_ = ((Array)obj).Length;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00눀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778726, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00대()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00됀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778727, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00딀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00똀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778728, new IntPtr(2737337520044L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00뜀(object P_0)
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
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00렀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778729, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00_FF00_FF00_FF00뤀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00먀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778730, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00묀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00밀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778731, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00봀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778732, new IntPtr(2737337523164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00븀(uint P_0)
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
