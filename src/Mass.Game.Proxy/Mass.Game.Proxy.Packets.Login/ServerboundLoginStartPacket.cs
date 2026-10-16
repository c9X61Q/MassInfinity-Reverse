using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Network.Interface;
using Mass.Game.Proxy.Network.Packet;

namespace Mass.Game.Proxy.Packets.Login;

[PacketAllVersion(0)]
[Packet(EnumConnectionState.Login, EnumPacketDirection.Serverbound)]
public class ServerboundLoginStartPacket : IPacket, IBufferCodec, IBufferSerializable, IBufferDeserializable
{
	private static object DeleteLogger;

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00琀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00蜀(value);
		}
	}

	public Guid? Uuid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00褀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00謀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ServerboundLoginStartPacket(EnumProtocolVersion version)
	{
		//IL_0042: Expected I4, but got Obj
		//IL_0030->IL0039: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		ServerboundLoginStartPacket serverboundLoginStartPacket = this;
		if (0 == 0)
		{
			serverboundLoginStartPacket = (ServerboundLoginStartPacket)0;
		}
		switch ((int)serverboundLoginStartPacket)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Read(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00蔀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00缀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Handle(Connection connection)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00簀(connection) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CompressConnection()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerboundLoginStartPacket ReflectCustomizableProfiler()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00猀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778294, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00琀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00甀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778289, new IntPtr(2737368318348L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed byte _FF00_FF00_FF00_FF00_FF00_FF00簀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_004a: Expected I4, but got Obj
		//IL_00de: Expected Obj, but got I4
		//IL_008a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00c7->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0116->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0095->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00f8->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00b7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01f8->IL0019: Incompatible stack heights: 8 vs 1
		//IL_0103->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01b1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01bc->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 6;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 10:
					_ = 8;
					continue;
				case 2:
					if (7 == 0)
					{
						obj2 = 7;
					}
					continue;
				case 9:
					obj2 = obj;
					if (false)
					{
						obj2 = 0;
					}
					continue;
				case 5:
					if (10 == 0)
					{
						_ = 7;
					}
					continue;
				case 6:
					break;
				case 8:
					if (obj != null)
					{
						if (1 == 0)
						{
							obj2 = 1;
						}
						continue;
					}
					goto case 9;
				default:
					return 1;
				case 1:
					_ = 3;
					continue;
				case 4:
					return 1;
				case 3:
					obj = this;
					if ((nint)obj <= 763)
					{
						if ((nint)obj <= 340)
						{
							obj = (((nint)obj > 5) ? this : this);
						}
						else
						{
							obj = (((nint)obj > 757) ? this : this);
						}
					}
					else
					{
						obj = (((nint)obj > 766) ? this : this);
					}
					obj = obj;
					if (2 != 0)
					{
						_ = 0;
					}
					continue;
				case 7:
					_ = 0;
					_ = (ushort)obj;
					_ = 4;
					continue;
				}
				break;
			}
			obj = (object)/*Error near IL_00d5: Stack underflow*/;
			obj = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed byte _FF00_FF00_FF00_FF00_FF00_FF00紀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778288, new IntPtr(2737368307948L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00缀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_004e: Expected I4, but got Obj
		//IL_0113: Expected Obj, but got I4
		//IL_016f: Expected Obj, but got I4
		//IL_0118->IL0015: Incompatible stack heights: 1 vs 0
		//IL_008d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0139->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0075->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0061->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00f5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00cf->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0098->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b0->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0100->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00da->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0153->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00bb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_015e->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 9;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 10:
					obj = this;
					obj2 = 3;
					continue;
				case 9:
					_ = 32767;
					_ = 8;
					continue;
				case 5:
					obj = this;
					_ = ref obj;
					if (1 == 0)
					{
						_ = 2;
					}
					continue;
				case 8:
					if ((nint)this < 766)
					{
						if (6 == 0)
						{
							obj2 = 1;
						}
						continue;
					}
					goto case 7;
				case 4:
					if (&obj == null)
					{
						if (false)
						{
							obj2 = 0;
						}
						continue;
					}
					obj = this;
					_ = ref obj;
					if (11 != 0)
					{
						_ = 1;
					}
					continue;
				default:
					throw /*Error near IL_00dd: Stack underflow*/;
				case 1:
					obj = this;
					_ = ref obj;
					obj = 10;
					break;
				case 7:
					obj = this;
					obj2 = 4;
					continue;
				case 2:
					return;
				case 11:
					return;
				case 6:
					if ((nint)this < 763)
					{
						return;
					}
					if (1 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 3:
					if (&obj == null)
					{
						return;
					}
					obj = 5;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00耀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778291, new IntPtr(2737368316268L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00脀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778290, new IntPtr(2737368307948L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00舀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00茀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778253, new IntPtr(2737368326668L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00萀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00_FF00_FF00蔀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003e: Expected I4, but got Obj
		//IL_00d4->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0056->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0074->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0097->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00df->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0061->IL0019: Incompatible stack heights: 3 vs 1
		//IL_007f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00c2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00f8->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00a2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0103->IL0019: Incompatible stack types: I4 vs Obj
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
				if (3 != 0)
				{
					_ = 6;
				}
				break;
			case 5:
				if (3 != 0)
				{
					_ = 2;
				}
				break;
			default:
				if ((nint)this >= 766)
				{
					if (4 == 0)
					{
						obj2 = 5;
					}
					break;
				}
				if ((nint)this < 763)
				{
					if (2 == 0)
					{
						obj2 = 1;
					}
					break;
				}
				goto case 7;
			case 2:
				return;
			case 7:
				if (P_0 == null)
				{
					return;
				}
				obj2 = 4;
				break;
			case 1:
				_ = 16;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 3:
				return;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00蘀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778252, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00蜀(object P_0)
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
	internal unsafe Guid? _FF00_FF00_FF00_FF00_FF00_FF00蠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778255, new IntPtr(2737368328748L), 15))(null, 0, new IntPtr(0L));
		return (Guid?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Guid? _FF00_FF00_FF00_FF00_FF00_FF00褀()
	{
		//IL_000a: Expected VT, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (Guid?)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Guid? _FF00_FF00_FF00_FF00_FF00_FF00言()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778254, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		return (Guid?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00謀(Guid? P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00谀(Guid? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778249, new IntPtr(2737368315228L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
