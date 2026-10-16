using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Mass.Game.Launcher.Paths;

public class BedrockGamePath : GamePath
{
	public readonly string NeteaseData;

	public readonly string Launcher;

	internal static BedrockGamePath StartTemplate;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BedrockGamePath(string install, string startup)
	{
		//IL_0046: Expected I4, but got Obj
		//IL_0034->IL003d: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		BedrockGamePath bedrockGamePath = this;
		if (0 == 0)
		{
			bedrockGamePath = (BedrockGamePath)0;
		}
		switch ((int)bedrockGamePath)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static BedrockGamePath? GetBedrockPath()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0057: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 146, 1790778391, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778391, new IntPtr(2737337551244L), 15);
		}
		return (BedrockGamePath?)((delegate*<object>)obj)();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateSequentialContainer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static BedrockGamePath DecorateSetConverter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00栀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778390, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00椀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_014e: Expected Obj, but got I4
		//IL_01d5: Expected Obj, but got I4
		//IL_0256->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0261->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004e->IL0052: Incompatible stack heights: 1 vs 0
		//IL_0196->IL0052: Incompatible stack heights: 1 vs 0
		//IL_0119->IL0052: Incompatible stack heights: 1 vs 0
		//IL_01a9->IL0052: Incompatible stack heights: 1 vs 0
		//IL_0052->IL0052: Incompatible stack heights: 1 vs 0
		//IL_00c1->IL0052: Incompatible stack heights: 1 vs 0
		//IL_01c3->IL0052: Incompatible stack heights: 1 vs 0
		//IL_0106->IL0052: Incompatible stack heights: 1 vs 0
		//IL_0124->IL0052: Incompatible stack heights: 1 vs 0
		//IL_0142->IL0052: Incompatible stack heights: 1 vs 0
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			object obj3;
			switch ((int)obj2)
			{
			default:
				if (obj == null)
				{
					if (3 == 0)
					{
						_ = 0;
					}
					goto IL_0052;
				}
				goto IL_016f;
			case 1:
				obj = (object)/*Error near IL_024a: Stack underflow*/;
				if (0 == 0)
				{
					obj2 = 0;
				}
				continue;
			case 2:
				break;
				IL_0196:
				obj3 = null;
				goto IL_019d;
				IL_019d:
				obj = obj3;
				_ = 9;
				goto IL_0052;
				IL_0052:
				while (true)
				{
					object obj4;
					switch ((int)/*Error near IL_008f: Stack underflow*/)
					{
					case 4:
						if (obj == null)
						{
							_ = 11;
							continue;
						}
						goto case 8;
					case 11:
					case 12:
						obj = null;
						if (2 != 0)
						{
							_ = 7;
						}
						continue;
					default:
						obj = obj;
						if (1 == 0)
						{
							_ = 0;
						}
						continue;
					case 8:
						if (obj != null)
						{
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						}
						goto case 11;
					case 3:
						obj = null;
						obj = 6;
						continue;
					case 5:
						break;
					case 10:
						goto IL_0196;
					case 9:
						obj4 = obj;
						if (obj4 != null)
						{
							goto IL_01ca;
						}
						_ = 2;
						continue;
					case 2:
						obj4 = null;
						goto IL_01ca;
					case 1:
					case 6:
					case 7:
						goto end_IL_0019;
						IL_01ca:
						obj = obj4;
						obj = 4;
						continue;
					}
					break;
				}
				goto IL_016f;
				IL_016f:
				obj3 = obj;
				if (obj3 != null)
				{
					goto IL_019d;
				}
				if (2 != 0)
				{
					_ = 10;
				}
				goto IL_0052;
				end_IL_0019:
				break;
			}
			break;
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00樀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778389, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00欀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00氀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778388, new IntPtr(2737337565804L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00渀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778387, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00漀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00瀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778386, new IntPtr(2737337535644L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}
}
