using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using MsgPack;

namespace Mass.Game.Proxy.Protocols.Heypixel.Clientbound;

public class ClientboundReflectCheckPacket : HeypixelPacket
{
	internal static ClientboundReflectCheckPacket? GuideVisitor;

	public Guid Guid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _EF00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_0900(value);
		}
	}

	public long Timestamp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _EB00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_F400(value);
		}
	}

	public EnumReflectCheck CheckType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _E900();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_F100(value);
		}
	}

	public string? ReflectCheckAction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string?)_FF00Ȁ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_F300(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClientboundReflectCheckPacket(HeypixelProtocol protocol)
	{
		//IL_0033: Expected I4, but got Obj
		//IL_0021->IL002a: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		HeypixelProtocol heypixelProtocol = protocol;
		if (0 == 0)
		{
			heypixelProtocol = (HeypixelProtocol)0;
		}
		switch ((int)heypixelProtocol)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Read(Unpacker unpacker)
	{
		_FF00_0600(unpacker);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe override byte[] Decode(byte[] input)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 518, 1790779193, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779193, new IntPtr(2737367939004L), 15);
		}
		return (byte[])((delegate*<object, object, object>)obj)(this, input);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Handle()
	{
		_FE00();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool InstantiateWatcher()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ClientboundReflectCheckPacket? PatchElement()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe EnumReflectCheck _E800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779192, new IntPtr(2737367947324L), 15))(null, 0, new IntPtr(0L));
		return (EnumReflectCheck)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal EnumReflectCheck _E900()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (EnumReflectCheck)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe EnumReflectCheck _EA00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779195, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		return (EnumReflectCheck)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal long _EB00()
	{
		//IL_000a: Expected I8, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (long)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe long _EC00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779194, new IntPtr(2737367947324L), 15))(null, 0, new IntPtr(0L));
		return (long)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object? _ED00(object? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0087->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0047->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0052->IL0019: Incompatible stack types: I4 vs Obj
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
				if (this != null)
				{
					if (1 == 0)
					{
						obj2 = 1;
					}
					break;
				}
				goto default;
			case 3:
				_ = ref obj;
				return P_0;
			default:
				return P_0;
			case 1:
				obj = this;
				obj2 = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _EE00(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779189, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Guid _EF00()
	{
		//IL_000a: Expected VT, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (Guid)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Guid _F000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779188, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		return (Guid)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _F100(EnumReflectCheck P_0)
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
	internal unsafe void _F200(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779191, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _F300(object? P_0)
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
	internal void _F400(long P_0)
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
	internal unsafe void _F500(long P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779190, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object? _F600()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object?)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object? _F700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779185, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FE00()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0062: Expected I4, but got Obj
		//IL_01c2: Expected I4, but got Obj
		//IL_0162: Expected Obj, but got I4
		//IL_01ab->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00f2->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0078->IL0019: Incompatible stack heights: 0 vs 1
		//IL_012a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0151->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0093->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0176->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00e3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0139->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00fd->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0083->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01cc->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0181->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0144->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 10;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 3:
					if (true)
					{
						obj2 = 1;
					}
					break;
				case 9:
					obj = this;
					if (false)
					{
						obj2 = 0;
					}
					break;
				case 14:
					obj = (object)/*Error near IL_00d9: Stack underflow*/;
					obj2 = 15;
					break;
				case 2:
					goto IL_00e3;
				case 4:
				case 5:
				case 7:
				case 13:
				case 15:
					_ = 3;
					break;
				case 16:
					goto IL_012a;
				case 8:
				case 11:
					obj = (object)/*Error near IL_0147: Stack underflow*/;
					obj2 = 7;
					break;
				case 10:
					if ((nint)this != 3)
					{
						goto end_IL_0019;
					}
					goto case 3;
				case 12:
					goto IL_0167;
				default:
					obj = this;
					obj2 = 6;
					break;
				case 6:
					switch ((int)obj)
					{
					case 3:
						break;
					case 2:
						goto IL_00e3;
					case 0:
						goto IL_012a;
					case 1:
						goto IL_0167;
					default:
						goto IL_01c2;
					}
					goto case 14;
				case 1:
					return;
					IL_01c2:
					obj2 = 11;
					break;
					IL_0167:
					obj = (object)/*Error near IL_016a: Stack underflow*/;
					if (12 == 0)
					{
						obj2 = 13;
					}
					break;
					IL_012a:
					obj = (object)/*Error near IL_012d: Stack underflow*/;
					if (4 != 0)
					{
						obj2 = 1;
					}
					break;
					IL_00e3:
					obj = (object)/*Error near IL_00e6: Stack underflow*/;
					if (5 == 0)
					{
						obj2 = 1;
					}
					break;
				}
				continue;
				end_IL_0019:
				break;
			}
			obj = 9;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779184, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00Ā()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object? _FF00Ȁ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_0300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779187, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00Ѐ()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_004b->IL0019: Incompatible stack heights: 9 vs 1
		//IL_0056->IL0019: Incompatible stack heights: 9 vs 1
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
	internal unsafe void _FF00Ԁ(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779186, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_0600(object? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00a0->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0064->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0092->IL0019: Incompatible stack heights: 4 vs 1
		//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0078->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0056->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0083->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 5:
				if (1 == 0)
				{
					_ = 0;
				}
				break;
			case 2:
				_ = 5;
				break;
			case 1:
				if ((nint)this == 3)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				return;
			case 3:
				_ = 0;
				_ = 2;
				break;
			default:
				_ = 4;
				break;
			case 4:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_0700(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779149, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ࠀ(Guid P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779148, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_0900(Guid P_0)
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
	internal unsafe void _FF00_0A00(Guid P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779151, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
