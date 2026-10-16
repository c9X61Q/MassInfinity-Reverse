using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.Application.Event;
using Mass.Common.Extensions;
using Mass.Game.Proxy.Minecraft.Events;
using Mass.Game.Proxy.Minecraft.Events.Play;
using Mass.Game.Proxy.Minecraft.Protocol;
using Serilog;

namespace Mass.Game.Proxy.Protocols.EastLand;

public class EastLandProtocol : Protocol
{
	[CompilerGenerated]
	private static readonly object Logger__BackingField;

	private static object DecorateDynamicProcessor;

	private static ILogger Logger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	public byte[]? ClientKey
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (byte[]?)_FF00_FF00렀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00숀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public void OnServerPluginMessage(EventServerPluginMessage @event)
	{
		_FF00_FF00븀(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object Decrypt(object key, object data)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005a: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 820, 1790778906, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 3, 1790778906, new IntPtr(2737367950444L), 15);
		}
		return ((delegate*<object, object, object, object>)obj)(this, key, data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static byte[] Decompress(byte[] bytes)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 821, 1790778901, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778901, new IntPtr(2737367951484L), 15);
		}
		return (byte[])((delegate*<object, object>)obj)(bytes);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public void OnClientPluginMessage(EventClientPluginMessage @event)
	{
		_FF00_FF00찀(@event);
	}

	[SubscribeEvent]
	public static void OnConnectServer(EventConnectServer @event)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EastLandProtocol()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}

	static EastLandProtocol()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_001f: Expected I4, but got Obj
		//IL_004c->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0057->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
				Logger__BackingField = Log.Logger.Category((string)ZYXDNGuarder._FF00_FF00똀());
				obj2 = 0;
				if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_e28d6b3bc6ae415aa8c9a8c33ac158d7 != 0)
				{
					obj2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PopArgument()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EastLandProtocol DefineSummarizer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00뜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778900, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00렀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00봀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778903, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00븀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_01d9: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I4
		//IL_004f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01cc->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0203->IL0019: Incompatible stack heights: 0 vs 1
		//IL_006d->IL0071: Incompatible stack heights: 1 vs 0
		//IL_020e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b5->IL0071: Incompatible stack heights: 1 vs 0
		//IL_00ef->IL0071: Incompatible stack heights: 2 vs 0
		//IL_0116->IL0071: Incompatible stack heights: 2 vs 0
		//IL_00c0->IL0071: Incompatible stack heights: 1 vs 0
		//IL_00fa->IL0071: Incompatible stack heights: 2 vs 0
		//IL_0121->IL0071: Incompatible stack heights: 2 vs 0
		//IL_00df->IL0071: Incompatible stack heights: 1 vs 0
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
				case 2:
					_ = 4;
					continue;
				case 5:
					obj = obj;
					if (true)
					{
						_ = 2;
					}
					while (true)
					{
						switch ((int)/*Error near IL_008e: Stack underflow*/)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							if (0 == 0)
							{
								_ = 4;
							}
							continue;
						case 2:
							if (obj != null)
							{
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							}
							break;
						case 3:
							if (1 == 0)
							{
								_ = 0;
							}
							continue;
						case 5:
							break;
						case 4:
							return;
						}
						obj = 16;
						_ = ref obj;
						obj = obj;
						if (2 == 0)
						{
							_ = 3;
						}
					}
				case 6:
					return;
				case 1:
					obj = obj;
					obj2 = 5;
					continue;
				case 3:
					break;
				case 4:
					if (obj != null)
					{
						return;
					}
					if (0 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 0:
					return;
				}
				break;
			}
			obj = P_0;
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00뼀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778902, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00쀀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00섀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778897, new IntPtr(2737368306908L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00숀(object P_0)
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
	internal unsafe void _FF00_FF00쌀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778896, new IntPtr(2737368315228L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00쐀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00씀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778899, new IntPtr(2737368314188L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00_FF00였()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00윀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_007e: Expected I4, but got Obj
		//IL_00c6: Expected Obj, but got I4
		//IL_003e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0065->IL0069: Incompatible stack types: I4 vs Obj
		//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0091->IL0069: Incompatible stack heights: 4 vs 2
		//IL_009f->IL0069: Incompatible stack heights: 4 vs 2
		//IL_00b0->IL0069: Incompatible stack heights: 1 vs 2
		//IL_00bb->IL0069: Incompatible stack heights: 1 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				obj = (object)/*Error near IL_0032: Stack underflow*/;
				if (1 == 0)
				{
					obj2 = 1;
				}
				continue;
			case 1:
			{
				object obj3 = P_0;
				if (false)
				{
					obj3 = 0;
				}
				while (true)
				{
					switch ((int)obj3)
					{
					default:
						_ = 2;
						_ = 2;
						continue;
					case 2:
						_ = 2;
						_ = 3;
						continue;
					case 3:
						obj = obj;
						if (true)
						{
							_ = 1;
						}
						continue;
					case 1:
						break;
					}
					break;
				}
				int num = 0;
				obj = ((Array)P_1).Length;
				if (0 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				break;
			}
			}
			break;
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00저(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778898, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00쬀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778989, new IntPtr(2737368318348L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00찀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_01de->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01c3->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01ce->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01b3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01f4->IL0019: Incompatible stack heights: 0 vs 1
		//IL_005a->IL005e: Incompatible stack heights: 1 vs 0
		//IL_01ff->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d0->IL005e: Incompatible stack heights: 2 vs 0
		//IL_0096->IL005e: Incompatible stack heights: 2 vs 0
		//IL_00fd->IL005e: Incompatible stack heights: 2 vs 0
		//IL_00a1->IL005e: Incompatible stack heights: 2 vs 0
		//IL_0108->IL005e: Incompatible stack heights: 2 vs 0
		//IL_00ed->IL005e: Incompatible stack heights: 1 vs 0
		//IL_00c1->IL005e: Incompatible stack heights: 1 vs 0
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
			case 0:
				return;
			case 4:
				obj = obj;
				if (2 == 0)
				{
					_ = 4;
				}
				while (true)
				{
					switch ((int)/*Error near IL_007b: Stack underflow*/)
					{
					case 5:
						return;
					case 1:
						obj = obj;
						if (true)
						{
							_ = 3;
						}
						break;
					case 4:
						if ((nint)obj != 1)
						{
							return;
						}
						if (1 == 0)
						{
							_ = 1;
						}
						break;
					default:
						_ = 2;
						break;
					case 3:
						obj = obj;
						if (0 == 0)
						{
							_ = 0;
						}
						break;
					case 2:
						_ = 1;
						if (true)
						{
							_ = 5;
						}
						break;
					}
				}
			case 5:
				return;
			case 2:
				obj = P_0;
				if (true)
				{
					obj2 = 0;
				}
				break;
			case 1:
				_ = 3;
				break;
			case 3:
				if (obj == null)
				{
					obj = obj;
					obj2 = 4;
				}
				else if (5 != 0)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00촀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778988, new IntPtr(2737368314188L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00츀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0055: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I4
		//IL_0079: Expected I4, but got Obj
		//IL_00d9: Expected I4, but got Obj
		//IL_006c->IL0070: Incompatible stack types: I4 vs Obj
		//IL_004b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0099->IL009d: Incompatible stack heights: 1 vs 0
		//IL_00c8->IL00cc: Incompatible stack types: I4 vs Obj
		//IL_00ef->IL00cc: Incompatible stack heights: 1 vs 2
		//IL_00fa->IL00cc: Incompatible stack heights: 1 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				obj2 = P_0;
				obj = 0;
				if (true)
				{
					obj2 = 1;
				}
				continue;
			case 1:
			{
				object obj3 = obj;
				obj = 0;
				if (0 == 0)
				{
					obj3 = 0;
				}
				switch ((int)obj3)
				{
				}
				obj = (object)/*Error near IL_0082: Stack underflow*/;
				if (0 == 0)
				{
					_ = 0;
				}
				switch ((int)/*Error near IL_00a6: Stack underflow*/)
				{
				}
				object obj4 = obj;
				if (false)
				{
					obj4 = 0;
				}
				while (true)
				{
					switch ((int)obj4)
					{
					case 1:
						break;
					default:
						obj = obj;
						if (0 == 0)
						{
							_ = 1;
						}
						continue;
					}
					break;
				}
				break;
			}
			}
			break;
		}
		return obj;
	}
}
