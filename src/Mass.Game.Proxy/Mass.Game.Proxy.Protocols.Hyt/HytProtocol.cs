using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.Application.Event;
using Mass.Game.Proxy.Minecraft.Events;
using Mass.Game.Proxy.Minecraft.Events.Play;
using Mass.Game.Proxy.Packets.Play;
using Mass.Game.Proxy.Protocols.FakeForge;

namespace Mass.Game.Proxy.Protocols.Hyt;

public class HytProtocol : FakeForgeProtocol
{
	private nint _linkFlag;

	private object? _data;

	internal static HytProtocol CheckFilteredDistributor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HytProtocol()
	{
		//IL_0037: Expected Obj, but got I4
		//IL_0045: Expected Obj, but got I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		//IL_020d: Expected I4, but got Obj
		//IL_01fb->IL0204: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 28;
		object obj2 = (obj = obj);
		obj = 0;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		if (false)
		{
			obj2 = 0;
		}
		switch ((int)obj2)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public override void OnServerPluginMessage(EventServerPluginMessage @event)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00_F800(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public override void OnJoinGame(EventPacket<ClientboundJoinGamePacket> @event)
	{
		Ѐ(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnGermPacket(object packet)
	{
		Ā(packet);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnVexViewPacket(object packet)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00_E100(packet);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SendGermPacket(object packet)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00_E700(packet);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SendVexViewPacket(object packet)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00_E500(packet);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateAutomatedNotifier()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HytProtocol DecoratePassiveDispatcher()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00팀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778850, new IntPtr(2737367931724L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00퐀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00픀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778877, new IntPtr(2737367931724L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E000(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778876, new IntPtr(2737367946284L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E100(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0062: Expected I4, but got Obj
		//IL_00d7: Expected Obj, but got I4
		//IL_01b6->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00e1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00f7->IL0019: Incompatible stack heights: 5 vs 1
		//IL_0187->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00bb->IL0019: Incompatible stack heights: 6 vs 1
		//IL_00ce->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01c1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_011c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_013a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_015a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0177->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0099->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0127->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01d5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0145->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0165->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a4->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				return;
			case 8:
				return;
			case 12:
				_ = 6;
				continue;
			case 4:
				obj = 4;
				_ = 12;
				continue;
			case 9:
				_ = 3;
				continue;
			case 15:
				return;
			case 7:
				if (obj == null)
				{
					if (2 == 0)
					{
						obj2 = 2;
					}
					continue;
				}
				goto case 4;
			case 13:
				if (obj == null)
				{
					if (6 == 0)
					{
						obj2 = 15;
					}
					continue;
				}
				goto case 7;
			case 14:
				if (obj == null)
				{
					return;
				}
				if (10 == 0)
				{
					obj2 = 0;
				}
				continue;
			case 16:
				if (P_0 != null)
				{
					obj2 = 5;
					continue;
				}
				goto case 11;
			case 11:
				obj = null;
				_ = 13;
				continue;
			case 5:
				return;
			case 6:
				return;
			case 1:
				obj = P_0;
				if (0 == 0)
				{
					obj2 = 0;
				}
				continue;
			case 3:
				return;
			case 10:
				if (P_0 != null)
				{
					return;
				}
				obj2 = 16;
				continue;
			}
			if (obj == null)
			{
				obj2 = 14;
				continue;
			}
			if (P_0 == null)
			{
				if (8 == 0)
				{
					obj2 = 9;
				}
				continue;
			}
			return;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E200(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778879, new IntPtr(2737367936924L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E400(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778878, new IntPtr(2737367931724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E500(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004a->IL0019: Incompatible stack heights: 2 vs 1
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
	private void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E700(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0049->IL0019: Incompatible stack heights: 2 vs 1
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
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E800(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778873, new IntPtr(2737367931724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F700(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778872, new IntPtr(2737367933804L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F800(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_021d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_006d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0228->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0078->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01c3->IL009d: Incompatible stack heights: 1 vs 0
		//IL_0099->IL009d: Incompatible stack heights: 1 vs 0
		//IL_00fb->IL009d: Incompatible stack heights: 1 vs 0
		//IL_01d1->IL009d: Incompatible stack heights: 3 vs 0
		//IL_0127->IL009d: Incompatible stack heights: 3 vs 0
		//IL_0119->IL009d: Incompatible stack heights: 1 vs 0
		//IL_018c->IL009d: Incompatible stack heights: 3 vs 0
		//IL_0153->IL009d: Incompatible stack heights: 2 vs 0
		//IL_017e->IL009d: Incompatible stack heights: 1 vs 0
		//IL_019d->IL009d: Incompatible stack heights: 1 vs 0
		//IL_015e->IL009d: Incompatible stack heights: 2 vs 0
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				return;
			case 3:
				return;
			case 2:
				if (obj != null)
				{
					if (0 == 0)
					{
						_ = 3;
					}
					goto IL_009d;
				}
				goto IL_01b0;
			case 1:
				{
					if (false)
					{
						_ = 0;
					}
					continue;
				}
				IL_009d:
				while (true)
				{
					switch ((int)/*Error near IL_00da: Stack underflow*/)
					{
					default:
						return;
					case 0:
						return;
					case 6:
						return;
					case 13:
						return;
					case 8:
						break;
					case 3:
					case 10:
						obj = obj;
						_ = 4;
						continue;
					case 5:
					case 7:
						_ = 1;
						_ = 13;
						continue;
					case 12:
						_ = 1;
						if (0 == 0)
						{
							_ = 0;
						}
						continue;
					case 1:
						if (obj != null)
						{
							_ = 2;
							continue;
						}
						goto case 12;
					case 11:
						_ = 5;
						continue;
					case 4:
						if (obj == null)
						{
							_ = 7;
							continue;
						}
						goto case 11;
					case 9:
						goto IL_01b0;
					case 2:
						_ = 12;
						continue;
					}
					break;
				}
				goto IL_00df;
				IL_00df:
				obj = obj;
				if (1 == 0)
				{
					_ = 0;
				}
				goto IL_009d;
				IL_01b0:
				if (obj == null)
				{
					_ = 6;
					goto IL_009d;
				}
				goto IL_00df;
			}
			if (P_0 == null)
			{
				obj = (obj = P_0);
				if (2 != 0)
				{
					obj2 = 1;
				}
			}
			else if (3 != 0)
			{
				obj2 = 3;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00豈(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778875, new IntPtr(2737367931724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00切()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ﬀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778874, new IntPtr(2737367931724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Ā(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_00be: Expected I4, but got Obj
		//IL_01db: Expected Obj, but got I4
		//IL_0140: Expected Obj, but got I4
		//IL_01ac: Expected Obj, but got I4
		//IL_02df->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0202->IL0019: Incompatible stack heights: 0 vs 1
		//IL_017f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0121->IL0019: Incompatible stack heights: 4 vs 1
		//IL_02b0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_036f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_037e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01c1->IL0019: Incompatible stack heights: 4 vs 1
		//IL_02c0->IL0019: Incompatible stack heights: 0 vs 1
		//IL_02f7->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02ea->IL0019: Incompatible stack heights: 2 vs 1
		//IL_019b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_020d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0342->IL0019: Incompatible stack heights: 7 vs 1
		//IL_021f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0254->IL0019: Incompatible stack heights: 7 vs 1
		//IL_01d2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_018a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_03bf->IL0019: Incompatible stack heights: 0 vs 1
		//IL_03a5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0296->IL0019: Incompatible stack heights: 0 vs 1
		//IL_03ef->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0357->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0429->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00f4->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0155->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0329->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01f2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d6->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0409->IL0019: Incompatible stack heights: 0 vs 1
		//IL_02cb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03ca->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03db->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02a1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0278->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0362->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0434->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0393->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ff->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0160->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00e1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0414->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0283->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				case 35:
					if (P_0 != null)
					{
						if (19 == 0)
						{
							obj2 = 28;
						}
						continue;
					}
					goto case 38;
				case 26:
					if (obj == null)
					{
						if (35 == 0)
						{
							obj2 = 29;
						}
						continue;
					}
					if (obj != null)
					{
						obj2 = 11;
						continue;
					}
					goto case 31;
				case 10:
					_ = 30;
					continue;
				case 18:
					return;
				case 23:
					if (P_0 == null)
					{
						obj = 3;
						break;
					}
					if (this == null)
					{
						obj = 5;
						break;
					}
					goto default;
				case 33:
					return;
				case 28:
					_ = 1;
					if (37 == 0)
					{
						_ = 9;
					}
					continue;
				case 7:
					if (16 != 0)
					{
						_ = 12;
					}
					continue;
				case 1:
					if (obj != null)
					{
						obj2 = 21;
						continue;
					}
					goto case 19;
				case 34:
					return;
				case 30:
					_ = 36;
					_ = 1;
					_ = 33;
					continue;
				case 6:
					if (obj == null)
					{
						obj2 = 23;
						continue;
					}
					_ = 2;
					_ = 0;
					_ = 34;
					continue;
				case 32:
					obj2 = obj;
					obj = 4;
					if (4 == 0)
					{
						obj2 = 2;
					}
					continue;
				case 2:
					obj = P_0;
					if (1 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 4:
					if (obj == null)
					{
						obj2 = 29;
						continue;
					}
					_ = 0;
					_ = 0;
					_ = 10;
					continue;
				case 5:
					return;
				case 37:
					return;
				case 11:
					return;
				case 3:
					return;
				case 21:
					if (obj == null)
					{
						if (12 != 0)
						{
							obj2 = 7;
						}
						continue;
					}
					goto case 8;
				case 17:
					if (obj == null)
					{
						if (27 == 0)
						{
							obj2 = 15;
						}
						continue;
					}
					goto case 7;
				case 15:
					return;
				case 27:
					return;
				case 19:
					obj = P_0;
					obj2 = 26;
					continue;
				case 38:
					obj = P_0;
					if (2 == 0)
					{
						obj2 = 6;
					}
					continue;
				default:
					_ = 20;
					if (20 != 0)
					{
						_ = 13;
					}
					continue;
				case 9:
				case 39:
					_ = 24;
					continue;
				case 31:
					if (obj != null)
					{
						return;
					}
					obj2 = 32;
					continue;
				case 22:
					return;
				case 12:
				case 24:
					if (this == null)
					{
						if (14 != 0)
						{
							obj2 = 6;
						}
					}
					else
					{
						_ = 13;
					}
					continue;
				case 20:
					_ = 0;
					_ = 15;
					continue;
				case 29:
					_ = 22;
					continue;
				case 16:
					return;
				case 13:
				case 14:
					if (obj == null)
					{
						obj2 = 18;
						continue;
					}
					goto case 36;
				case 8:
					if (this != null)
					{
						obj2 = 39;
					}
					else if (2 != 0)
					{
						obj2 = 9;
					}
					continue;
				case 36:
					obj3 = this;
					if (obj3 != null)
					{
						goto IL_041b;
					}
					if (25 == 0)
					{
						obj2 = 16;
					}
					continue;
				case 25:
					{
						obj3 = null;
						goto IL_041b;
					}
					IL_041b:
					obj = obj3;
					if (17 != 0)
					{
						obj2 = 10;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void Ȁ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778869, new IntPtr(2737367931724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _0300(EventPacket<ClientboundJoinGamePacket> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778868, new IntPtr(2737367933804L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void Ѐ(EventPacket<ClientboundJoinGamePacket> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0058->IL0019: Incompatible stack heights: 2 vs 1
		//IL_003e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0063->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0049->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 2:
				if (0 == 0)
				{
					_ = 1;
				}
				break;
			case 1:
				_ = 0;
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
}
