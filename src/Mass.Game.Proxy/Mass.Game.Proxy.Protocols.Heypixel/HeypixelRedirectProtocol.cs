using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.Application.Event;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Minecraft.Events;
using Mass.Game.Proxy.Minecraft.Events.Play;
using Mass.Game.Proxy.Minecraft.Protocol;
using Mass.Game.Proxy.Packets.Play;

namespace Mass.Game.Proxy.Protocols.Heypixel;

public class HeypixelRedirectProtocol : Protocol
{
	internal static HeypixelRedirectProtocol MonitorCompressor;

	public bool Joined
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 蔀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			礀(value ? ((byte)1) : ((byte)0));
		}
	}

	public bool EnableLogging
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 脀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			稀(value ? ((byte)1) : ((byte)0));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(Mass.Game.Proxy.Minecraft.Minecraft minecraft)
	{
		蠀(minecraft);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public void OnJoinGame(EventPacket<ClientboundJoinGamePacket> @event)
	{
		退(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public void OnServerPluginMessage(EventServerPluginMessage @event)
	{
		谀(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public void OnClientPluginMessage(EventClientPluginMessage @event)
	{
		缀(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowText(string? text)
	{
		謀(text);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HeypixelRedirectProtocol()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckModularDic()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HeypixelRedirectProtocol CheckGroupedObject()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 砀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778444, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 礀(byte P_0)
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
	internal void 稀(byte P_0)
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
	internal unsafe void 笀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778447, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte 簀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte 紀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778446, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 縀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778441, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 缀(object P_0)
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
			case 1:
				_ = 1;
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
	internal unsafe void 耀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778440, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte 脀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte 舀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778443, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object 茀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778442, new IntPtr(2737367947324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 萀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte 蔀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 蜀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778437, new IntPtr(2737367948364L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 蠀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_006d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00bc->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0089->IL0019: Incompatible stack heights: 3 vs 1
		//IL_009c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0053->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0078->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			object obj3;
			switch ((int)obj2)
			{
			default:
				return;
			case 3:
				obj3 = this;
				if (obj3 == null)
				{
					if (1 == 0)
					{
						obj2 = 1;
					}
					continue;
				}
				break;
			case 4:
				if (3 == 0)
				{
					_ = 1;
				}
				continue;
			case 5:
				return;
			case 0:
				return;
			case 2:
				if (obj != null)
				{
					_ = 5;
				}
				else if (false)
				{
					obj2 = 0;
				}
				continue;
			case 1:
				obj3 = null;
				break;
			}
			obj = obj3;
			obj2 = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 褀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778436, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 言(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778439, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 謀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0067->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0049->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0084->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0054->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 3:
				return;
			case 0:
				return;
			case 4:
				if (2 != 0)
				{
					_ = 3;
				}
				break;
			case 2:
				if (P_0 != null)
				{
					if (1 == 0)
					{
						obj2 = 1;
					}
					break;
				}
				if (this == null)
				{
					return;
				}
				obj2 = 4;
				break;
			case 1:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 谀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_005e: Expected I4, but got Obj
		//IL_0166->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0149->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0049->IL004d: Incompatible stack heights: 1 vs 3
		//IL_0171->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0154->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005e->IL007f: Incompatible stack heights: 2 vs 0
		//IL_009f->IL004d: Incompatible stack types: I4 vs Obj
		//IL_0063->IL007f: Incompatible stack heights: 2 vs 0
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			object obj3;
			switch ((int)obj2)
			{
			default:
				if (obj == null)
				{
					_ = 2;
					goto IL_004d;
				}
				goto IL_007f;
			case 3:
				obj = P_0;
				if (0 == 0)
				{
					obj2 = 2;
				}
				break;
			case 2:
				obj = obj;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				return;
				IL_004d:
				switch ((int)obj3)
				{
				case 2:
					return;
				case 1:
					return;
				}
				goto IL_007f;
				IL_007f:
				obj3 = obj;
				if (true)
				{
					obj3 = 0;
				}
				goto IL_004d;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 贀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778438, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 輀(EventPacket<ClientboundJoinGamePacket> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778433, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 退(EventPacket<ClientboundJoinGamePacket> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_006c->IL0019: Incompatible stack heights: 3 vs 1
		//IL_005f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00be->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0050->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 6;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 6:
				if (this != null)
				{
					obj2 = 5;
					continue;
				}
				break;
			case 1:
				obj2 = 2;
				continue;
			default:
				_ = 1;
				_ = 4;
				continue;
			case 4:
				return;
			case 2:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				continue;
			case 3:
				break;
			}
			obj2 = this;
			if (1 == 0)
			{
				obj2 = 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 鄀(EventPacket<ClientboundJoinGamePacket> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778432, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
