using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Application.Event;
using Mass.Game.Proxy.Minecraft.Events;
using Mass.Game.Proxy.Minecraft.Events.Play;
using Mass.Game.Proxy.Minecraft.Protocol;
using Mass.Game.Proxy.Packets.Play;
using Mass.Game.Proxy.Protocols.FakeForge.FmlHandshake.Messages;

namespace Mass.Game.Proxy.Protocols.FakeForge;

public class FakeForgeProtocol : Protocol
{
	private static object CloneProvider;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FakeForgeProtocol(List<string> channelNames, List<FmlMod> mods)
	{
		//IL_0042: Expected I4, but got Obj
		//IL_0030->IL0039: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		FakeForgeProtocol fakeForgeProtocol = this;
		if (0 == 0)
		{
			fakeForgeProtocol = (FakeForgeProtocol)0;
		}
		switch ((int)fakeForgeProtocol)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FakeForgeProtocol()
	{
		//IL_0034: Expected I4, but got Obj
		//IL_0022->IL002b: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		FakeForgeProtocol fakeForgeProtocol = this;
		if (0 == 0)
		{
			fakeForgeProtocol = (FakeForgeProtocol)0;
		}
		switch ((int)fakeForgeProtocol)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FakeForgeProtocol(List<string> channelNames)
	{
		//IL_0034: Expected I4, but got Obj
		//IL_0022->IL002b: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		List<string> list = channelNames;
		if (0 == 0)
		{
			list = (List<string>)0;
		}
		switch ((int)list)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public virtual void OnJoinGame(EventPacket<ClientboundJoinGamePacket> @event)
	{
		_FF00_FF00㘀(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public virtual void OnClientPluginMessage(EventClientPluginMessage @event)
	{
		_FF00_FF00_3300(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public virtual void OnServerPluginMessage(EventServerPluginMessage @event)
	{
		_FF00_FF00㨀(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SendFmlHandshakeMessage(object message)
	{
		_FF00_FF00䐀(message);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void SendRegisterChannel(string channelName = "REGISTER", List<string>? overrideChannelNames = null)
	{
		_FF00_FF00㸀(channelName, overrideChannelNames);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SendPluginMessage(string channelName, IByteBuffer buffer)
	{
		_FF00_FF00㠀(channelName, buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectExternalState()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FakeForgeProtocol ReflectOperationalHandler()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_3200(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779390, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_3300(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0048->IL0019: Incompatible stack heights: 0 vs 1
		//IL_02ab->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02bd->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0053->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02c8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0074->IL0078: Incompatible stack heights: 1 vs 0
		//IL_0224->IL0078: Incompatible stack heights: 1 vs 0
		//IL_01bd->IL0078: Incompatible stack heights: 1 vs 0
		//IL_01fb->IL0078: Incompatible stack heights: 4 vs 0
		//IL_017b->IL0078: Incompatible stack heights: 1 vs 0
		//IL_015f->IL0078: Incompatible stack heights: 1 vs 0
		//IL_01e5->IL0078: Incompatible stack heights: 3 vs 0
		//IL_013e->IL0078: Incompatible stack heights: 1 vs 0
		//IL_010d->IL0078: Incompatible stack heights: 1 vs 0
		//IL_01d7->IL0078: Incompatible stack heights: 1 vs 0
		//IL_0253->IL0078: Incompatible stack heights: 1 vs 0
		//IL_00f1->IL0078: Incompatible stack heights: 1 vs 0
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
				obj = obj;
				if (4 != 0)
				{
					obj2 = 3;
				}
				continue;
			case 3:
				obj = P_0;
				obj2 = 2;
				continue;
			case 4:
				obj = obj;
				if (false)
				{
					obj2 = 0;
				}
				continue;
			case 1:
				return;
			}
			if (obj == null)
			{
				if (3 != 0)
				{
					_ = 4;
				}
				goto IL_0078;
			}
			goto IL_0197;
			IL_020a:
			obj = (object)/*Error near IL_020d: Stack underflow*/;
			if (6 != 0)
			{
				_ = 4;
			}
			goto IL_0078;
			IL_0197:
			object obj3 = obj;
			obj = this;
			if (obj3 != null)
			{
				if (9 == 0)
				{
					_ = 1;
				}
				goto IL_0078;
			}
			goto IL_020a;
			IL_0078:
			while (true)
			{
				switch ((int)/*Error near IL_00c9: Stack underflow*/)
				{
				case 9:
					if ((nint)obj >= 772)
					{
						if (5 != 0)
						{
							_ = 15;
						}
						continue;
					}
					goto case 2;
				case 8:
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
				case 5:
					if (obj == null)
					{
						_ = 12;
						continue;
					}
					goto case 17;
				case 11:
					return;
				case 3:
				case 6:
				case 16:
					obj = obj;
					_ = 8;
					continue;
				case 2:
				case 10:
					obj = (object)/*Error near IL_0171: Stack underflow*/;
					_ = 16;
					continue;
				case 13:
				case 14:
					break;
				case 15:
				case 18:
					obj = (object)/*Error near IL_01c0: Stack underflow*/;
					if (0 == 0)
					{
						_ = 3;
					}
					continue;
				case 17:
					_ = 1;
					_ = 7;
					continue;
				default:
					_ = 32767;
					_ = 11;
					continue;
				case 12:
					return;
				case 1:
					goto IL_020a;
				case 4:
					if (obj != null)
					{
						if (0 == 0)
						{
							_ = 13;
						}
						continue;
					}
					goto case 5;
				case 7:
					return;
				}
				break;
			}
			goto IL_0197;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00㐀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779385, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00㘀(EventPacket<ClientboundJoinGamePacket> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
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
				_ = null;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00㜀(EventPacket<ClientboundJoinGamePacket> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779384, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00㠀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0048->IL0019: Incompatible stack heights: 3 vs 1
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
	internal unsafe void _FF00_FF00㤀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779387, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00㨀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0101: Expected I4, but got Obj
		//IL_01f0: Expected Obj, but got I4
		//IL_030c: Expected Obj, but got I4
		//IL_0206: Expected Obj, but got I4
		//IL_0063->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0084->IL0088: Incompatible stack types: I4 vs Obj
		//IL_004a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_038d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_031f->IL0088: Incompatible stack heights: 3 vs 1
		//IL_0153->IL0088: Incompatible stack heights: 3 vs 1
		//IL_0311->IL0084: Incompatible stack heights: 2 vs 0
		//IL_032d->IL0088: Incompatible stack heights: 3 vs 1
		//IL_024b->IL0088: Incompatible stack heights: 2 vs 1
		//IL_02e1->IL0088: Incompatible stack heights: 3 vs 1
		//IL_0229->IL0088: Incompatible stack heights: 3 vs 1
		//IL_02c1->IL0088: Incompatible stack types: I4 vs Obj
		//IL_0055->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0398->IL0019: Incompatible stack types: I4 vs Obj
		//IL_019b->IL0088: Incompatible stack types: I4 vs Obj
		//IL_023b->IL0088: Incompatible stack types: I4 vs Obj
		//IL_02f4->IL0088: Incompatible stack heights: 0 vs 1
		//IL_0181->IL0088: Incompatible stack types: I4 vs Obj
		//IL_0268->IL0088: Incompatible stack types: I4 vs Obj
		//IL_0136->IL0088: Incompatible stack types: I4 vs Obj
		//IL_028b->IL0088: Incompatible stack heights: 0 vs 1
		//IL_02d3->IL0088: Incompatible stack types: I4 vs Obj
		//IL_0256->IL0088: Incompatible stack heights: 2 vs 1
		//IL_02ff->IL0088: Incompatible stack types: I4 vs Obj
		//IL_0296->IL0088: Incompatible stack types: I4 vs Obj
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
				return;
			case 1:
				return;
			case 4:
				obj = P_0;
				obj2 = 3;
				break;
			case 2:
			{
				object obj3 = obj;
				obj = this;
				if (5 != 0)
				{
					obj3 = 10;
				}
				while (true)
				{
					switch ((int)obj3)
					{
					case 14:
						if ((nint)obj != 3)
						{
							obj3 = 15;
							continue;
						}
						break;
					case 2:
					case 16:
						_ = 2;
						_ = 27;
						continue;
					case 9:
						if (obj == null)
						{
							obj3 = 19;
							continue;
						}
						goto case 5;
					case 6:
						obj3 = this;
						if (13 != 0)
						{
							obj3 = 26;
						}
						continue;
					default:
						obj = obj;
						obj = 21;
						goto IL_0084;
					case 10:
						if (obj != null)
						{
							obj = 4;
							goto IL_0084;
						}
						goto case 20;
					case 26:
						_ = 24;
						continue;
					case 7:
						if (obj == null)
						{
							obj3 = 28;
							continue;
						}
						goto case 3;
					case 3:
					case 23:
						_ = 3;
						if (12 == 0)
						{
							_ = 5;
						}
						continue;
					case 13:
						if (obj != null)
						{
							obj3 = 3;
							continue;
						}
						goto case 7;
					case 20:
						if (obj != null)
						{
							if (0 == 0)
							{
								obj3 = 2;
							}
							continue;
						}
						goto case 13;
					case 28:
						obj = obj;
						obj3 = 8;
						continue;
					case 21:
						if ((nint)obj != 2)
						{
							obj3 = 14;
							continue;
						}
						goto case 25;
					case 25:
						_ = 4;
						_ = 11;
						continue;
					case 8:
						if (obj != null)
						{
							if (0 == 0)
							{
								obj3 = 0;
							}
							continue;
						}
						goto case 9;
					case 4:
					case 17:
						_ = null;
						obj = 6;
						goto IL_0084;
					case 5:
					case 11:
					case 12:
					case 15:
					case 19:
					case 24:
					case 27:
						_ = 1;
						_ = 18;
						continue;
					case 22:
						break;
					case 18:
						return;
						IL_0084:
						obj3 = obj;
						continue;
					}
					_ = 5;
					_ = 5;
				}
			}
			case 3:
				if (obj == null)
				{
					obj = obj;
					if (2 != 0)
					{
						obj2 = 2;
					}
				}
				else if (true)
				{
					obj2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00㬀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779386, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe void _FF00_FF00㴀(object P_0, List<string> P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779381, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _FF00_FF00㸀(object P_0, List<string> P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0060->IL0019: Incompatible stack heights: 4 vs 1
		//IL_006b->IL0019: Incompatible stack heights: 4 vs 1
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
				_ = 0;
				if (P_0 == null)
				{
				}
				if (false)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe void _FF00_FF00㼀(object P_0, List<string> P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779380, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00䀀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00䄀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779383, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00䈀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00䌀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779382, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00䐀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0041->IL0019: Incompatible stack heights: 3 vs 1
		//IL_004c->IL0019: Incompatible stack heights: 3 vs 1
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
}
