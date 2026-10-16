using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Mass.Game.Launcher.Java.LanGame;

public sealed class WebRtcCompressor
{
	private readonly object _deflater;

	private readonly object _inflater;

	private readonly object _decompressBuffer;

	private readonly object _compressBuffer;

	internal static WebRtcCompressor EncryptInterpreter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe byte[] Decompress(byte[] data)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 840, 1790777454, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790777454, new IntPtr(2737367918204L), 15);
		}
		return (byte[])((delegate*<object, object, object>)obj)(this, data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe byte[] Compress(byte[] data)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 841, 1790777453, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790777453, new IntPtr(2737367885964L), 15);
		}
		return (byte[])((delegate*<object, object, object>)obj)(this, data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
		_FF00_FF00_FF00_FF00_FF00ⴀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WebRtcCompressor()
	{
		//IL_005d: Expected I4, but got Obj
		//IL_004b->IL0054: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_ = -1;
		_ = 1024;
		_ = 1024;
		WebRtcCompressor webRtcCompressor = this;
		if (0 == 0)
		{
			webRtcCompressor = (WebRtcCompressor)0;
		}
		switch ((int)webRtcCompressor)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ScanNode()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static WebRtcCompressor InitFunction()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_2800(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777452, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_2900(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0060: Expected I4, but got Obj
		//IL_009d: Expected Obj, but got I4
		//IL_00c3: Expected I4, but got Obj
		//IL_00f5: Expected Obj, but got I4
		//IL_0047->IL004b: Incompatible stack types: I4 vs Obj
		//IL_008c->IL004b: Incompatible stack heights: 1 vs 2
		//IL_007f->IL004b: Incompatible stack types: I4 vs Obj
		//IL_0142->IL01c8: Incompatible stack heights: 0 vs 1
		//IL_00d9->IL00a6: Incompatible stack heights: 2 vs 3
		//IL_013d->IL00a6: Incompatible stack heights: 7 vs 3
		//IL_00e4->IL00a6: Incompatible stack heights: 2 vs 3
		//IL_0118->IL00a6: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		switch ((int)obj)
		{
		case 1:
		{
			object obj2 = P_0;
			if (0 == 0)
			{
				obj2 = 0;
			}
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					obj2 = this;
					if (1 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 1:
					obj = this;
					_ = 2;
					continue;
				case 2:
					obj = this;
					obj = 4;
					while (true)
					{
						object obj3 = obj;
						while (true)
						{
							switch ((int)obj3)
							{
							case 2:
								obj = obj;
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							case 1:
							case 4:
								if ((nint)obj <= 0)
								{
									goto end_IL_00a6;
								}
								goto case 3;
							case 5:
								obj3 = this;
								obj = this;
								if (0 == 0)
								{
									obj3 = 1;
								}
								continue;
							case 3:
								_ = 0;
								_ = 5;
								continue;
							}
							goto end_IL_004b;
							continue;
							end_IL_00a6:
							break;
						}
						obj = 2;
					}
				case 3:
					break;
					end_IL_004b:
					break;
				}
				break;
			}
			break;
		}
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_2A00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777451, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_2B00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00Ⰰ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777450, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00ⴀ()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0063->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				obj2 = this;
				if (true)
				{
					obj2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_2E00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777449, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_3000(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777448, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_3100(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_005c: Expected I4, but got Obj
		//IL_00bf: Expected I4, but got Obj
		//IL_0047->IL004b: Incompatible stack types: I4 vs Obj
		//IL_0070->IL004b: Incompatible stack heights: 0 vs 2
		//IL_009a->IL009e: Incompatible stack types: I4 vs Obj
		//IL_007b->IL004b: Incompatible stack heights: 1 vs 2
		//IL_00e5->IL009e: Incompatible stack heights: 6 vs 2
		//IL_0152->IL01c2: Incompatible stack heights: 0 vs 1
		//IL_00f4->IL009e: Incompatible stack types: I4 vs Obj
		//IL_0124->IL009e: Incompatible stack heights: 1 vs 2
		//IL_014d->IL009e: Incompatible stack types: I4 vs Obj
		//IL_012f->IL009e: Incompatible stack heights: 1 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		switch ((int)obj)
		{
		case 1:
		{
			object obj2 = P_0;
			if (1 == 0)
			{
				obj2 = 1;
			}
			while (true)
			{
				switch ((int)obj2)
				{
				case 1:
					obj = this;
					if (false)
					{
						_ = 0;
					}
					continue;
				default:
				{
					WebRtcCompressor webRtcCompressor = this;
					obj = this;
					if (3 == 0)
					{
						webRtcCompressor = (WebRtcCompressor)1;
					}
					while (true)
					{
						switch ((int)webRtcCompressor)
						{
						case 1:
						case 6:
							_ = 0;
							_ = 5;
							continue;
						case 4:
							obj = obj;
							webRtcCompressor = (WebRtcCompressor)2;
							continue;
						default:
							if ((nint)obj > 0)
							{
								if (6 != 0)
								{
									_ = 2;
								}
								continue;
							}
							goto case 4;
						case 5:
							webRtcCompressor = this;
							obj = this;
							if (0 == 0)
							{
								webRtcCompressor = (WebRtcCompressor)0;
							}
							continue;
						case 2:
							break;
						}
						break;
					}
					break;
				}
				case 2:
					break;
				}
				break;
			}
			break;
		}
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_3200(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777447, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_3300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777446, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00㐀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}
}
