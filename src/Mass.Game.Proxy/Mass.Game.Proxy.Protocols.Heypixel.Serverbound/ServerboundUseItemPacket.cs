using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using MsgPack;

namespace Mass.Game.Proxy.Protocols.Heypixel.Serverbound;

public class ServerboundUseItemPacket : HeypixelPacket
{
	public double X;

	public double Y;

	public double Z;

	public int Face;

	public int Sequence;

	public double LocationX;

	public double LocationY;

	public double LocationZ;

	public double BlockX;

	public double BlockY;

	public double BlockZ;

	public bool InsideBlock;

	public float PlayerYaw;

	public float PlayerPitch;

	public bool IsHand;

	internal static ServerboundUseItemPacket DecorateControllableComparator;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ServerboundUseItemPacket(HeypixelProtocol protocol)
	{
		//IL_003b: Expected I4, but got Obj
		//IL_0029->IL0032: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_ = 1;
		HeypixelProtocol heypixelProtocol = protocol;
		if (false)
		{
			heypixelProtocol = (HeypixelProtocol)0;
		}
		switch ((int)heypixelProtocol)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(Packer packer)
	{
		찀(packer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateTransferableBridge()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerboundUseItemPacket FlushFunction()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object 윀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778598, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 저()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object 준()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778593, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte 쨀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte 쬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778592, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 찀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_005e: Expected I4, but got Obj
		//IL_00c2: Expected Obj, but got I4
		//IL_0150: Expected Obj, but got I4
		//IL_010d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0073->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0199->IL0019: Incompatible stack heights: 3 vs 1
		//IL_008c->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00d5->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0138->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00e3->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00f4->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00aa->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0165->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c7->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0155->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0180->IL0019: Incompatible stack heights: 2 vs 1
		//IL_011d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_007e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0143->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ff->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0170->IL0019: Incompatible stack heights: 2 vs 1
		//IL_018b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0128->IL0019: Incompatible stack heights: 2 vs 1
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
				case 1:
					if (15 == 0)
					{
						_ = 11;
					}
					continue;
				case 3:
					_ = 14;
					continue;
				case 15:
					_ = 8;
					continue;
				case 9:
					if (4 == 0)
					{
						_ = 3;
					}
					continue;
				case 11:
					obj = 10;
					break;
				case 5:
					_ = 2;
					continue;
				case 7:
					_ = 12;
					continue;
				case 4:
					return;
				case 8:
					if (true)
					{
						_ = 3;
					}
					continue;
				default:
					_ = 9;
					continue;
				case 14:
					if (7 != 0)
					{
						_ = 5;
					}
					continue;
				case 6:
					if (13 == 0)
					{
						_ = 7;
					}
					continue;
				case 12:
					obj = 5;
					break;
				case 10:
					if (false)
					{
						_ = 1;
					}
					continue;
				case 13:
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
				case 2:
					_ = 6;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 촀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778595, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
