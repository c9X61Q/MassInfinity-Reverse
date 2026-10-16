using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Network.Converters;
using Mass.Game.Proxy.Network.Interface;
using Mass.Game.Proxy.Network.Packet;

namespace Mass.Game.Proxy.Packets.Common;

public class PluginMessagePacket : IPacket, IBufferCodec, IBufferSerializable, IBufferDeserializable
{
	internal static PluginMessagePacket CheckGroupedAuditor;

	public string Channel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00鼀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00ꨀ(value);
		}
	}

	[JsonConverter(typeof(ByteBufferConverter))]
	public IByteBuffer Data
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (IByteBuffer)_FF00_FF00_FF00_FF00관();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00꼀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PluginMessagePacket(EnumProtocolVersion version)
	{
		//IL_004a: Expected I4, but got Obj
		//IL_0038->IL0041: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		PluginMessagePacket pluginMessagePacket = this;
		if (0 == 0)
		{
			pluginMessagePacket = (PluginMessagePacket)0;
		}
		switch ((int)pluginMessagePacket)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Read(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00ꠀ(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00ꄀ(buffer);
	}

	public virtual bool Handle(Connection connection)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CollectQueue()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PluginMessagePacket CheckIsolatedList()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00鸀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778110, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00鼀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00ꀀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778105, new IntPtr(2737368331868L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00ꄀ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_006a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00cd->IL0019: Incompatible stack heights: 3 vs 1
		//IL_009a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ae->IL0019: Incompatible stack heights: 0 vs 1
		//IL_005c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b9->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 5:
				obj2 = P_0;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				obj2 = 6;
				break;
			case 6:
				return;
			default:
				obj2 = P_0;
				if (true)
				{
					obj2 = 1;
				}
				break;
			case 3:
				if ((nint)this > 5)
				{
					if (2 != 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 5;
			case 4:
				_ = 32767;
				_ = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00ꈀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778104, new IntPtr(2737368310028L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00ꌀ()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00ꐀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778107, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00ꔀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778106, new IntPtr(2737368331868L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00ꘀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_A700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778101, new IntPtr(2737368332908L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00ꠀ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00b1: Expected Obj, but got I4
		//IL_005f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0079->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004f->IL0019: Incompatible stack heights: 4 vs 1
		//IL_006a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0084->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 4:
					return;
				case 3:
					_ = 32767;
					_ = 2;
					continue;
				default:
					if (4 == 0)
					{
						_ = 3;
					}
					continue;
				case 1:
					break;
				case 2:
					if ((nint)this <= 5)
					{
						break;
					}
					goto end_IL_0019;
				}
				if (0 == 0)
				{
					obj2 = 0;
				}
				continue;
				end_IL_0019:
				break;
			}
			obj = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00꤀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778100, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00ꨀ(object P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_AB00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778103, new IntPtr(2737368316268L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00가()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778102, new IntPtr(2737368302748L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00관()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00글()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778097, new IntPtr(2737368317308L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00꼀(object P_0)
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
