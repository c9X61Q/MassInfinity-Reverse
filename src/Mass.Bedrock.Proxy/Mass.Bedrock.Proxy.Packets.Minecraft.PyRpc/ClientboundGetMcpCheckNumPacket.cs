using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.Bedrock.Proxy.Minecraft;
using Mass.Bedrock.Proxy.Network.Minecraft.Entities.PyRpc;
using Mass.Bedrock.Proxy.Network.Minecraft.Enums;
using Mass.Bedrock.Proxy.Network.Packet;

namespace Mass.Bedrock.Proxy.Packets.Minecraft.PyRpc;

[PyRpcPacket(EnumPacketDirection.Clientbound, "GetMCPCheckNum")]
public class ClientboundGetMcpCheckNumPacket : PyRpcPacketBase
{
	private static object DecorateModularListener;

	public string McpData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00_E600();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_ED00(value);
		}
	}

	public McpCheckNum McpCheckNum
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (McpCheckNum)_FF00_FF00_FF00_FF00_FF00_FF00_EB00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_E500(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Deserialize(List<object> payload)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_EF00(payload);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Serialize(List<object> payload)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_E400(payload);
	}

	public override bool Handle(Connection connection)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClientboundGetMcpCheckNumPacket()
	{
		//IL_0042: Expected I4, but got Obj
		//IL_0030->IL0039: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		ClientboundGetMcpCheckNumPacket clientboundGetMcpCheckNumPacket = this;
		if (0 == 0)
		{
			clientboundGetMcpCheckNumPacket = (ClientboundGetMcpCheckNumPacket)0;
		}
		switch ((int)clientboundGetMcpCheckNumPacket)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LeadInterpreter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ClientboundGetMcpCheckNumPacket CollectNode()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_E300(List<object> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778624, new IntPtr(2737337524204L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_E400(List<object> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0051->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0078->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			case 2:
				return;
			case 1:
				if (0 == 0)
				{
					_ = 0;
				}
				continue;
			}
			((object[])3)[0] = this;
			((object[])3)[1] = this;
			((object[])3)[2] = this;
			if (2 == 0)
			{
				_ = 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_E500(object P_0)
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
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_E600()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_E700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778625, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_E800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778626, new IntPtr(2737337511724L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_E900()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_EA00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778627, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_EB00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_EC00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778628, new IntPtr(2737337516924L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_ED00(object P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_EE00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778629, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_EF00(List<object> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_00c4: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I4
		//IL_0095->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00d2->IL0015: Incompatible stack heights: 1 vs 0
		//IL_00b2->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0051->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0081->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00a0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00bd->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0064->IL0019: Incompatible stack heights: 0 vs 1
		//IL_006f->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 3:
					_ = ((object[])obj)[1];
					_ = 5;
					continue;
				case 6:
					if (obj != null)
					{
						if (0 == 0)
						{
							obj2 = 0;
						}
						continue;
					}
					return;
				case 5:
					_ = ((object[])obj)[2];
					_ = 4;
					continue;
				default:
					_ = ((object[])obj)[0];
					if (3 != 0)
					{
						_ = 2;
					}
					continue;
				case 2:
					_ = 0;
					if (1 == 0)
					{
						_ = 0;
					}
					continue;
				case 4:
					return;
				case 1:
					break;
				}
				break;
			}
			obj = 1;
			obj = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_F000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778630, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_F100()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}
}
