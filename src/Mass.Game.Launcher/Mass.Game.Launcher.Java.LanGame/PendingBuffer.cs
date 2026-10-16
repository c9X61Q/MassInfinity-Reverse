using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Mass.Game.Launcher.Java.LanGame;

public class PendingBuffer
{
	private readonly object _buffer;

	private static object ReflectControllableRequester;

	public int Length
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00_FF00_FF00缀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			_FF00_FF00_FF00_FF00_FF00脀((uint)value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] ToArray()
	{
		return (byte[])_FF00_FF00_FF00_FF00_FF00蔀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Append(byte[] data)
	{
		return _FF00_FF00_FF00_FF00_FF00褀(data) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		_FF00_FF00_FF00_FF00_FF00蜀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PendingBuffer()
	{
		//IL_003f: Expected I4, but got Obj
		//IL_002d->IL0036: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_ = 16384;
		PendingBuffer pendingBuffer = this;
		if (false)
		{
			pendingBuffer = (PendingBuffer)0;
		}
		switch ((int)pendingBuffer)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateTransferableModule()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PendingBuffer DecorateResponsiveEvent()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00縀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777478, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00_FF00_FF00缀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00耀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777477, new IntPtr(2737367892204L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_FF00脀(uint P_0)
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
	private unsafe void _FF00_FF00_FF00_FF00_FF00舀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777476, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00茀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777475, new IntPtr(2737367892204L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00萀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00蔀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 3163, 1790777474, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777474, new IntPtr(2737367892204L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00蘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777473, new IntPtr(2737367884924L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00蜀()
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
				_ = 0;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00蠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777472, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00褀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Invalid comparison between Unknown and I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004b->IL0019: Incompatible stack heights: 5 vs 1
		//IL_0091->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0075->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0056->IL0019: Incompatible stack heights: 5 vs 1
		//IL_009c->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				return 0;
			case 3:
				_ = this + ((Array)P_0).Length;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 2:
				if (this + ((Array)P_0).Length <= 16384)
				{
					_ = 0;
					_ = ((Array)P_0).Length;
					if (3 == 0)
					{
						_ = 2;
					}
				}
				else if (1 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				return 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00言(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777535, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00謀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}
}
