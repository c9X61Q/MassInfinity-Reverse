using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;

namespace Mass.Game.Proxy.Protocols.FakeForge.FmlHandshake.Messages;

public class ModList : FmlHandshakeMessage
{
	private static object RestartBuilder;

	public List<FmlMod> Mods
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00脀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00眀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ModList()
	{
		//IL_003a: Expected I4, but got Obj
		//IL_0028->IL0031: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		ModList modList = this;
		if (false)
		{
			modList = (ModList)0;
		}
		switch ((int)modList)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ModList(List<FmlMod> mods)
	{
		//IL_003e: Expected I4, but got Obj
		//IL_0028->IL0031: Incompatible stack types: I4 vs Obj
		//IL_0052->IL0031: Incompatible stack heights: 3 vs 2
		//IL_005d->IL0031: Incompatible stack heights: 3 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		ModList modList = this;
		if (0 == 0)
		{
			modList = (ModList)0;
		}
		while (true)
		{
			switch ((int)modList)
			{
			case 1:
				return;
			}
			if (0 == 0)
			{
				_ = 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Read(IByteBuffer buffer)
	{
		_FF00_FF00簀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(IByteBuffer buffer)
	{
		_FF00_FF00舀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectScalableConnection()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ModList ReflectModularDecorator()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00瘀(List<FmlMod> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779344, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00眀(List<FmlMod> P_0)
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
	internal unsafe void _FF00_FF00砀(List<FmlMod> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779347, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00礀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00稀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779346, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00笀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778925, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00簀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_0099: Expected Obj, but got I4
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00a3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00c2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005b->IL0019: Incompatible stack heights: 6 vs 1
		//IL_0096->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0070->IL0019: Incompatible stack heights: 0 vs 1
		//IL_007b->IL0019: Incompatible stack types: I4 vs Obj
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
			case 6:
				_ = 32767;
				_ = 32767;
				_ = 5;
				break;
			case 3:
			case 4:
				if (Unsafe.As<object, UIntPtr>(ref obj) >= Unsafe.As<object, UIntPtr>(ref obj))
				{
					if (false)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 6;
			case 2:
				obj = P_0;
				if (1 == 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				obj = 0;
				obj2 = 3;
				break;
			case 5:
				obj++;
				obj2 = 4;
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00紀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778924, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00縀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778927, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00缀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00耀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778926, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<FmlMod> _FF00_FF00脀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (List<FmlMod>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00舀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_00dc: Expected Obj, but got Ref
		//IL_00bd: Expected Obj, but got I4
		//IL_0044->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00f3->IL008e: Incompatible stack heights: 1 vs 0
		//IL_008e->IL008e: Incompatible stack heights: 1 vs 0
		//IL_010a->IL008e: Incompatible stack heights: 2 vs 0
		//IL_00d7->IL008e: Incompatible stack heights: 3 vs 0
		//IL_0115->IL008e: Incompatible stack heights: 2 vs 0
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				obj = this;
				if (2 == 0)
				{
					obj2 = 2;
				}
				continue;
			case 3:
				return;
			case 1:
				obj2 = P_0;
				if (0 == 0)
				{
					obj2 = 0;
				}
				continue;
			case 2:
				break;
			}
			break;
		}
		while (true)
		{
			if (&obj == null)
			{
				obj = 3;
				goto IL_008e;
			}
			goto IL_00d7;
			IL_008e:
			while (true)
			{
				switch ((int)/*Error near IL_00a7: Stack underflow*/)
				{
				case 3:
					return;
				case 4:
					break;
				case 2:
					_ = 32767;
					_ = 4;
					continue;
				case 1:
					goto IL_00d7;
				default:
					_ = 32767;
					if (2 == 0)
					{
						_ = 1;
					}
					continue;
				}
				break;
			}
			continue;
			IL_00d7:
			obj = (object)(&obj);
			if (0 == 0)
			{
				_ = 0;
			}
			goto IL_008e;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00茀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778921, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
