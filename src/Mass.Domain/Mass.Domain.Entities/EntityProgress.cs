using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Mass.Domain.ValueObjects;

namespace Mass.Domain.Entities;

public record EntityProgress
{
	[CompilerGenerated]
	protected virtual Type EqualityContract
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (Type)_FF00_FF00케();
		}
	}

	public EnumStepPhase Phase
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00휀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			this._FF00_FF00_FFFD(value);
		}
	}

	public int Step
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00턀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_F100((uint)value);
		}
	}

	public int Total
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_F200();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FFFD((uint)value);
		}
	}

	public int Percentage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00切();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_F800((uint)value);
		}
	}

	public string Message
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_F500();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_E900(value);
		}
	}

	internal static EntityProgress CheckAttachedConverter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EntityProgress(EnumStepPhase Phase, int Step, int Total, int Percentage, string Message)
	{
		//IL_005c: Expected I4, but got Obj
		//IL_004a->IL0053: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		EntityProgress entityProgress = this;
		if (0 == 0)
		{
			entityProgress = (EntityProgress)0;
		}
		switch ((int)entityProgress)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe override string ToString()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 139, 1790778569, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778569, new IntPtr(2737337540844L), 15);
		}
		return (string)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	protected virtual bool PrintMembers(StringBuilder builder)
	{
		return _FF00_FF00_E700(builder) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public override int GetHashCode()
	{
		return (int)_FF00_FF00_F000();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public virtual bool Equals(EntityProgress? other)
	{
		return _FF00_FF00ﬀ(other) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	protected EntityProgress(EntityProgress original)
	{
		//IL_0012: Expected Obj, but got I4
		//IL_003d: Expected I4, but got Obj
		//IL_0094: Expected Obj, but got I4
		//IL_00a9->IL0020: Incompatible stack heights: 3 vs 2
		//IL_0099->IL001c: Incompatible stack heights: 3 vs 1
		//IL_0052->IL0020: Incompatible stack heights: 3 vs 2
		//IL_006d->IL0020: Incompatible stack heights: 3 vs 2
		//IL_0087->IL0020: Incompatible stack heights: 4 vs 2
		//IL_00b4->IL0020: Incompatible stack heights: 3 vs 2
		//IL_005d->IL0020: Incompatible stack heights: 3 vs 2
		//IL_0078->IL0020: Incompatible stack heights: 3 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					return;
				case 3:
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
				case 4:
					if (0 == 0)
					{
						_ = 1;
					}
					continue;
				case 0:
					return;
				case 5:
					_ = 2;
					continue;
				case 2:
					break;
				case 1:
					if (5 == 0)
					{
						_ = 1;
					}
					continue;
				}
				break;
			}
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public unsafe void Deconstruct(out EnumStepPhase Phase, out int Step, out int Total, out int Percentage, out string Message)
	{
		_FF00_FF00_F700((nint)Unsafe.AsPointer(ref Phase), (nint)Unsafe.AsPointer(ref Step), (nint)Unsafe.AsPointer(ref Total), (nint)Unsafe.AsPointer(ref Percentage), (nint)Unsafe.AsPointer(ref Message));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PostFunction()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EntityProgress CountBuffer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00쬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778568, new IntPtr(2737337556444L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00찀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00촀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778567, new IntPtr(2737337541884L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe object _FF00_FF00츀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778566, new IntPtr(2737337556444L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected object _FF00_FF00케()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_000a: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe object _FF00_FF00퀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778565, new IntPtr(2737337547084L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00턀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00툀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0050: Expected I4, but got Obj
		//IL_0041->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0067->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0019: Incompatible stack types: I4 vs Obj
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
				if (P_0 != null)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				return 0;
			default:
				return (byte)(int)P_1;
			case 2:
				if (P_0 == P_1)
				{
					return 1;
				}
				if (true)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00팀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778564, new IntPtr(2737337548124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00퐀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00픀(object P_0, object P_1)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (P_1 == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00혀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778563, new IntPtr(2737337536684L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal EnumStepPhase _FF00_FF00휀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (EnumStepPhase)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778562, new IntPtr(2737337554364L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FFFD()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778561, new IntPtr(2737337560604L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FFFD(object P_0)
	{
		//IL_000c: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FFFD(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778560, new IntPtr(2737337541884L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FFFD(EnumStepPhase P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778431, new IntPtr(2737337566844L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FFFD(EnumStepPhase P_0)
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
	internal void _FF00_FF00_FFFD(uint P_0)
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
	internal unsafe void _FF00_FF00_E000(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778430, new IntPtr(2737337541884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe byte _FF00_FF00_E600(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778429, new IntPtr(2737337566844L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected byte _FF00_FF00_E700(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_004e: Expected I4, but got Obj
		//IL_0063->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0163->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0171->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00ba->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0143->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00d3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00aa->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ef->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0133->IL0019: Incompatible stack types: I4 vs Obj
		//IL_014e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0111->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				if (7 == 0)
				{
					obj2 = 9;
				}
				break;
			case 1:
				return 1;
			case 9:
				obj2 = P_0;
				obj = this;
				_ = ref obj;
				if (0 == 0)
				{
					obj2 = 8;
				}
				break;
			case 4:
				if (0 == 0)
				{
					obj2 = 3;
				}
				break;
			case 5:
				if (7 != 0)
				{
					obj2 = 5;
				}
				break;
			case 11:
				obj2 = 10;
				break;
			case 6:
				obj2 = P_0;
				if (true)
				{
					obj2 = 0;
				}
				break;
			case 10:
				obj2 = P_0;
				obj = this;
				_ = ref obj;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 7:
				obj2 = P_0;
				obj = this;
				_ = ref obj;
				if (9 == 0)
				{
					obj2 = 11;
				}
				break;
			case 8:
				if (4 == 0)
				{
					obj2 = 6;
				}
				break;
			case 2:
				obj = this;
				_ = ref obj;
				_ = 5;
				break;
			case 3:
				obj2 = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe byte _FF00_FF00_E800(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778428, new IntPtr(2737337550204L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_E900(object P_0)
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
	internal unsafe object _FF00_FF00_EE00()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0066: Expected I4, but got Obj
		//IL_01a2: Expected Obj, but got Ref
		//IL_01a8: Expected Obj, but got I4
		//IL_00ae: Expected Obj, but got I4
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_013f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0167->IL0019: Incompatible stack heights: 4 vs 1
		//IL_01cd->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00e5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01dd->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00fe->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01b4->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00b8->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0178->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0158->IL0019: Incompatible stack heights: 2 vs 1
		//IL_014a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00f0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a0->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01e8->IL0019: Incompatible stack types: I4 vs Ref
		//IL_01bf->IL0019: Incompatible stack types: I4 vs Ref
		//IL_019e->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0183->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0110->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0123->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00ab->IL0019: Incompatible stack types: I4 vs Ref
		//IL_012e->IL0019: Incompatible stack types: I4 vs Ref
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 8;
		ref object reference = ref *(object*)obj;
		while (true)
		{
			switch ((uint)Unsafe.AsPointer(ref reference))
			{
			case 6u:
				_ = ref obj;
				_ = 9;
				break;
			case 7u:
				if (obj == null)
				{
					if (0 == 0)
					{
						reference = ref *(object*)null;
					}
					break;
				}
				goto case 15u;
			default:
				obj = 1;
				reference = ref *(object*)11;
				break;
			case 5u:
				_ = ref obj;
				if (3 == 0)
				{
					_ = 1;
				}
				break;
			case 9u:
				_ = ref obj;
				_ = 4;
				break;
			case 15u:
				if ((nint)obj == 5)
				{
					reference = ref *(object*)12;
					break;
				}
				goto case 10u;
			case 11u:
			case 16u:
				if (obj == null)
				{
					if (2 == 0)
					{
						reference = ref *(object*)1;
					}
					break;
				}
				return this;
			case 1u:
				_ = ref obj;
				if (3 != 0)
				{
					_ = 17;
				}
				break;
			case 17u:
				_ = ref obj;
				_ = 5;
				break;
			case 2u:
				_ = ref obj;
				_ = 8;
				_ = 4;
				_ = 14;
				break;
			case 14u:
				_ = ref obj;
				if (13 == 0)
				{
					_ = 13;
				}
				break;
			case 13u:
				reference = ref obj;
				if (1 == 0)
				{
					reference = ref *(object*)null;
				}
				break;
			case 4u:
				return (object)(&obj);
			case 10u:
				obj = 0;
				if (11 == 0)
				{
					reference = ref *(object*)16;
				}
				break;
			case 3u:
				_ = ref obj;
				_ = 6;
				break;
			case 8u:
				obj = this;
				if (3 == 0)
				{
					reference = ref *(object*)7;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_EF00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778427, new IntPtr(2737337558524L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_F000()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected I4, but got Unknown
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(((((this * -1521134295 + this) * -1521134295 + this) * -1521134295 + this) * -1521134295 + this) * -1521134295 + this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_F100(uint P_0)
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
	internal uint _FF00_FF00_F200()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_F300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778426, new IntPtr(2737337551244L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_F400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778425, new IntPtr(2737337546044L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_F500()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_F600()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778424, new IntPtr(2737337566844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_F700(nint P_0, nint P_1, nint P_2, nint P_3, nint P_4)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0084: Expected I4, but got Obj
		//IL_0076: Expected I4, but got Obj
		//IL_005a: Expected I4, but got Obj
		//IL_003f: Expected I4, but got Obj
		//IL_008e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0080->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0066->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00aa->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0071->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 5:
				*(int*)P_0 = (int)this;
				if (4 != 0)
				{
					obj2 = 1;
				}
				break;
			case 4:
				*(int*)P_1 = (int)this;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			case 3:
				*(int*)P_3 = (int)this;
				obj2 = 2;
				break;
			case 1:
				*(int*)P_2 = (int)this;
				obj2 = 3;
				break;
			case 2:
				Unsafe.Write((void*)P_4, this);
				if (false)
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
	internal void _FF00_FF00_F800(uint P_0)
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
	internal unsafe uint _FF00_FF00豈()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778423, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00切()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00ﬀ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_004e: Expected I4, but got Obj
		//IL_014c: Expected I4, but got Obj
		//IL_00e2: Expected Obj, but got I4
		//IL_0093->IL0053: Incompatible stack heights: 1 vs 0
		//IL_00d9->IL0145: Incompatible stack heights: 1 vs 0
		//IL_00f1->IL0088: Incompatible stack heights: 1 vs 0
		//IL_005e->IL00b9: Incompatible stack heights: 1 vs 0
		//IL_00c4->IL014c: Incompatible stack heights: 1 vs 0
		//IL_0127->IL0019: Incompatible stack types: I4 vs Obj
		//IL_013a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_009d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00e7->IL0015: Incompatible stack heights: 1 vs 0
		//IL_00fb->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ce->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0145->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0075->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 7:
					obj2 = this;
					if (P_0 == null)
					{
						if (10 == 0)
						{
							obj2 = 7;
						}
						break;
					}
					goto case 9;
				case 3:
					if (P_0 == null)
					{
						_ = 8;
						break;
					}
					goto case 7;
				case 9:
					if (P_0 != null)
					{
						_ = 5;
						break;
					}
					goto case 4;
				case 5:
					if (P_0 == null)
					{
						goto end_IL_0019;
					}
					goto default;
				case 6:
					if (P_0 == null)
					{
						_ = 4;
						break;
					}
					goto case 3;
				case 1:
					if (P_0 != null)
					{
						obj2 = 6;
						break;
					}
					goto case 4;
				case 2:
					if (this != P_0)
					{
						if (0 == 0)
						{
							obj2 = 1;
						}
						break;
					}
					return 1;
				default:
					return (byte)(int)P_0;
				case 4:
				case 8:
				case 10:
				case 11:
					return 0;
				}
				continue;
				end_IL_0019:
				break;
			}
			obj = 11;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00ﰀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778422, new IntPtr(2737337556444L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}
}
