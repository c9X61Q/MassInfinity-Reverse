using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;

namespace Mass.Game.Proxy.Protocols.Germ.Serverbound;

public class GermGuiScript : GermPacket
{
	internal static GermGuiScript ReflectIsolatedSummarizer;

	public string Gui
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00蘀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00缀(value);
		}
	}

	public string Part
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00謀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00退(value);
		}
	}

	public string Command
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00輀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00萀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GermGuiScript()
	{
		//IL_004a: Expected I4, but got Obj
		//IL_0038->IL0041: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		GermGuiScript germGuiScript = this;
		if (0 == 0)
		{
			germGuiScript = (GermGuiScript)0;
		}
		switch ((int)germGuiScript)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GermGuiScript(string gui, string part, string command)
	{
		//IL_0056: Expected I4, but got Obj
		//IL_0067: Expected Obj, but got I4
		//IL_0038->IL0041: Incompatible stack types: I4 vs Obj
		//IL_0096->IL0041: Incompatible stack heights: 5 vs 4
		//IL_007b->IL0041: Incompatible stack heights: 5 vs 4
		//IL_00a1->IL0041: Incompatible stack heights: 5 vs 4
		//IL_0041->IL0041: Incompatible stack heights: 6 vs 4
		//IL_0086->IL0041: Incompatible stack heights: 5 vs 4
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		GermGuiScript germGuiScript = this;
		if (2 == 0)
		{
			germGuiScript = (GermGuiScript)1;
		}
		while (true)
		{
			switch ((int)germGuiScript)
			{
			default:
				return;
			case 2:
			{
				object obj = 3;
				break;
			}
			case 3:
				if (false)
				{
					_ = 1;
				}
				break;
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
	public override void Read(IByteBuffer buffer)
	{
		_FF00谀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(IByteBuffer buffer)
	{
		_FF00縀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ValidateConsumer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GermGuiScript ReflectIterableTemplate()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00紀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779230, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00縀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0049->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0054->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0076->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0097->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 1:
				_ = 32767;
				if (3 != 0)
				{
					_ = 3;
				}
				break;
			case 0:
				return;
			case 2:
				_ = 32767;
				if (0 == 0)
				{
					_ = 1;
				}
				break;
			case 3:
				_ = 32767;
				if (false)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00缀(object P_0)
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
	internal unsafe void _FF00耀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779225, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00脀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779224, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00舀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00茀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779227, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00萀(object P_0)
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
	internal unsafe void _FF00蔀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779226, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00蘀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00蜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779221, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00蠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779220, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00褀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00言()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779223, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00謀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00谀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0068->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0048->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0088->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0073->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0053->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0093->IL0019: Incompatible stack heights: 3 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		while (true)
		{
			switch ((int)obj)
			{
			case 1:
				_ = 32767;
				if (false)
				{
					_ = 0;
				}
				break;
			default:
				_ = 32767;
				if (3 != 0)
				{
					_ = 3;
				}
				break;
			case 2:
				_ = 32767;
				if (false)
				{
					_ = 1;
				}
				break;
			case 3:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00贀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779222, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00踀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779217, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00輀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00退(object P_0)
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
	internal unsafe void _FF00鄀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779216, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
