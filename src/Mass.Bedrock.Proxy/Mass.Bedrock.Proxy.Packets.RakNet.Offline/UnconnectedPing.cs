using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Bedrock.Proxy.Network.Packet;

namespace Mass.Bedrock.Proxy.Packets.RakNet.Offline;

[RakNetPacket(1)]
public class UnconnectedPing : IRakNetPacket
{
	private static object DecorateDynamicHandler;

	public long Time
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00簀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00琀(value);
		}
	}

	public long Guid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00礀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00爀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Read(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00眀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00砀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UnconnectedPing()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectConcreteStruct()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static UnconnectedPing DefineBridge()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00焀(long P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778604, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00爀(long P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00猀(long P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778605, new IntPtr(2737337523164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00琀(long P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00甀(long P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778606, new IntPtr(2737337524204L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00瘀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778607, new IntPtr(2737337516924L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00眀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_005c: Expected Obj, but got I4
		//IL_0044->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0061->IL0015: Incompatible stack heights: 2 vs 0
		//IL_004f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007a->IL0019: Incompatible stack types: I4 vs Obj
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
				default:
					return;
				case 0:
					return;
				case 1:
					if (false)
					{
						_ = 0;
					}
					continue;
				case 3:
					break;
				case 2:
					obj2 = P_0;
					if (1 == 0)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
			}
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00砀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0076: Expected Obj, but got I4
		//IL_007b->IL0015: Incompatible stack heights: 1 vs 0
		//IL_004f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0068->IL0019: Incompatible stack types: I4 vs Obj
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
				default:
					return;
				case 1:
					obj2 = P_0;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 2:
					obj2 = P_0;
					if (0 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 3:
					break;
				case 0:
					return;
				}
				break;
			}
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal long _FF00_FF00_FF00_FF00礀()
	{
		//IL_000a: Expected I8, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (long)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe long _FF00_FF00_FF00_FF00稀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778608, new IntPtr(2737337510684L), 15))(null, 0, new IntPtr(0L));
		return (long)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe long _FF00_FF00_FF00_FF00笀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778609, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		return (long)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal long _FF00_FF00_FF00_FF00簀()
	{
		//IL_000a: Expected I8, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (long)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00紀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778610, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00縀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00缀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778611, new IntPtr(2737337519004L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00耀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}
}
