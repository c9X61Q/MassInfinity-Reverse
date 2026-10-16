using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using MsgPack;

namespace Mass.Game.Proxy.Protocols.Heypixel.Serverbound;

public class ServerboundReflectCheckPacket : HeypixelPacket
{
	internal static ServerboundReflectCheckPacket? RateAttribute;

	public EnumReflectCheck CheckType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _꤀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			뜀(value);
		}
	}

	public Guid Guid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 봀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			뼀(value);
		}
	}

	public long Timestamp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 뤀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			묀(value);
		}
	}

	public string? ReflectCheckAction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string?)글();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			가(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ServerboundReflectCheckPacket(HeypixelProtocol protocol)
	{
		//IL_0033: Expected I4, but got Obj
		//IL_0021->IL002a: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		HeypixelProtocol heypixelProtocol = protocol;
		if (false)
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
	public override void Write(Packer packer)
	{
		딀(packer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe override byte[] Encode(byte[] data)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 440, 1790778517, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778517, new IntPtr(2737367937964L), 15);
		}
		return (byte[])((delegate*<object, object, object>)obj)(this, data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectConnectedProcessor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerboundReflectCheckPacket? CheckAlphabeticContainer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte ꌀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778516, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte ꐀ()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte ꔀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778519, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object? ꘀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778518, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object? _A700()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object?)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object? ꠀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778513, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal EnumReflectCheck _꤀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (EnumReflectCheck)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe EnumReflectCheck ꨀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778512, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (EnumReflectCheck)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _AB00(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778515, new IntPtr(2737367947324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 가(object? P_0)
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
	internal unsafe void 관(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778514, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object? 글()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? 꼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778605, new IntPtr(2737367947324L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object? 뀀(object? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0043->IL0019: Incompatible stack heights: 0 vs 1
		//IL_006e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0079->IL0019: Incompatible stack types: I4 vs Obj
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
				return P_0;
			case 2:
				_ = ref obj;
				return this;
			case 1:
				if (this != null)
				{
					obj = this;
					if (1 == 0)
					{
						obj2 = 2;
					}
				}
				else if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 됀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778604, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 딀(object? P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_00d6: Expected I4, but got Obj
		//IL_00ee: Expected Obj, but got I4
		//IL_03b6: Expected I4, but got Obj
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected Obj, but got Unknown
		//IL_01af: Expected Obj, but got I4
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected Obj, but got Unknown
		//IL_050b->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00f8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0329->IL0019: Incompatible stack heights: 3 vs 1
		//IL_049e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_038f->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0480->IL0019: Incompatible stack heights: 4 vs 1
		//IL_03f3->IL0019: Incompatible stack heights: 3 vs 1
		//IL_030c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_04b0->IL0019: Incompatible stack heights: 0 vs 1
		//IL_04fb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_048f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0438->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0464->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0454->IL0019: Incompatible stack types: I4 vs Obj
		//IL_041d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0149->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01c7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01d6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_04cb->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01b9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_051a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_04eb->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0107->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0471->IL0019: Incompatible stack heights: 3 vs 1
		//IL_039f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0190->IL0019: Incompatible stack heights: 3 vs 1
		//IL_052c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_033b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0182->IL0019: Incompatible stack heights: 3 vs 1
		//IL_02ed->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0400->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00eb->IL0019: Incompatible stack heights: 3 vs 1
		//IL_054a->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0167->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0356->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0371->IL0019: Incompatible stack heights: 2 vs 1
		//IL_040c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03c0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0127->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0317->IL0019: Incompatible stack heights: 2 vs 1
		//IL_04bb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03d8->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0443->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0428->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0154->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01ff->IL0203: Incompatible stack heights: 1 vs 0
		//IL_01e1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0112->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0537->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0346->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02f8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0172->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0361->IL0019: Incompatible stack heights: 2 vs 1
		//IL_037c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_03e3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_024a->IL0203: Incompatible stack heights: 3 vs 0
		//IL_022a->IL0203: Incompatible stack heights: 2 vs 0
		//IL_0255->IL0203: Incompatible stack heights: 3 vs 0
		//IL_0235->IL0203: Incompatible stack heights: 2 vs 0
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 30;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 44:
				_ = 11;
				break;
			case 2:
				obj = 0;
				obj2 = 12;
				break;
			case 31:
				_ = 0;
				if (true)
				{
					_ = 1;
				}
				break;
			case 8:
			case 12:
				if ((nint)obj >= ((Array)obj).Length)
				{
					return;
				}
				obj2 = 26;
				break;
			case 21:
			case 26:
				obj = ((object[])obj)[obj];
				if (38 == 0)
				{
					obj2 = 45;
				}
				break;
			case 41:
				return;
			case 37:
				_ = ((Array)obj).Length;
				_ = 17;
				break;
			case 34:
				_ = 39;
				break;
			case 28:
				obj = 0;
				obj2 = 15;
				break;
			case 22:
				obj = obj;
				obj2 = 2;
				break;
			case 25:
				_ = 0;
				if (23 != 0)
				{
					_ = 12;
				}
				break;
			case 24:
				obj = this;
				if (2 == 0)
				{
					_ = 2;
				}
				while (true)
				{
					switch ((int)/*Error near IL_0214: Stack underflow*/)
					{
					default:
						return;
					case 2:
						if (true)
						{
							_ = 0;
						}
						break;
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
			case 39:
				obj = this;
				if (2 == 0)
				{
					obj2 = 3;
				}
				break;
			case 10:
				if (false)
				{
					_ = 0;
				}
				break;
			case 4:
				_ = 10;
				break;
			case 36:
				obj++;
				if (5 != 0)
				{
					obj2 = 8;
				}
				break;
			case 42:
				return;
			case 23:
				return;
			case 6:
				_ = 36;
				break;
			case 33:
				_ = 44;
				break;
			case 3:
				switch ((int)obj)
				{
				case 0:
					obj = this;
					if (24 == 0)
					{
						obj2 = 37;
					}
					break;
				case 1:
					_ = -1;
					if (23 != 0)
					{
						_ = 32;
					}
					break;
				case 2:
					_ = 0;
					if (40 == 0)
					{
						_ = 8;
					}
					break;
				default:
					obj2 = 41;
					break;
				case 3:
					obj2 = 24;
					break;
				}
				break;
			case 38:
				return;
			case 15:
			case 16:
				if ((nint)obj < ((Array)obj).Length)
				{
					if (40 != 0)
					{
						obj2 = 43;
					}
					break;
				}
				goto case 4;
			case 9:
				_ = 27;
				break;
			case 40:
				_ = 0;
				_ = 31;
				break;
			case 1:
				return;
			case 20:
				if (1 == 0)
				{
					_ = 5;
				}
				break;
			case 17:
				obj = obj;
				if (28 == 0)
				{
					obj2 = 8;
				}
				break;
			case 19:
			case 43:
				obj = ((object[])obj)[obj];
				obj2 = 20;
				break;
			case 18:
				_ = 33;
				break;
			case 32:
				_ = 0;
				_ = 25;
				break;
			case 7:
				_ = 1;
				_ = 34;
				break;
			case 14:
				_ = 13;
				break;
			case 5:
				_ = 14;
				break;
			case 11:
				obj = this;
				if (34 == 0)
				{
					obj2 = 35;
				}
				break;
			case 27:
				_ = 18;
				break;
			case 30:
				_ = 1;
				_ = 29;
				break;
			case 13:
				obj++;
				obj2 = 16;
				break;
			default:
				_ = 9;
				break;
			case 29:
				_ = (byte)this;
				_ = 7;
				break;
			case 35:
				_ = ((Array)obj).Length;
				if (22 == 0)
				{
					_ = 14;
				}
				break;
			case 45:
				_ = 6;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 똀(EnumReflectCheck P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778607, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 뜀(EnumReflectCheck P_0)
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
	internal unsafe void 렀(EnumReflectCheck P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778606, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal long 뤀()
	{
		//IL_000a: Expected I8, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (long)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe long 먀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778601, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (long)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 묀(long P_0)
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
	internal unsafe void 밀(long P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778600, new IntPtr(2737367947324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Guid 봀()
	{
		//IL_000a: Expected VT, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (Guid)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Guid 븀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778603, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (Guid)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 뼀(Guid P_0)
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
	internal unsafe void 쀀(Guid P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778602, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
