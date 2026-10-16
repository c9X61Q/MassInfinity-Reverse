using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Mass.Domain.Entities.Mass;
using Mass.Domain.Value;
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
		//IL_001b: Expected Obj, but got I4
		//IL_0027: Expected Obj, but got I4
		//IL_0033: Expected Obj, but got I4
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		BoolValueAttribute.DecorateIdentifiableAggregator = Phase;
		((ConfigValue)this).Id__BackingField = Step;
		((ConfigValue)this).Key__BackingField = Total;
		((ConfigValue)this).Icon__BackingField = (ValueIcon)Percentage;
		((ConfigValue)this).DisplayName__BackingField = Message;
		((List<ConfigValue>)/*Error near IL_0058: Stack underflow*/).ForEach((Action<ConfigValue>)(object)this);
		int num = 0;
		if (ConfigValue._003C_003Ec._003C_003E9 == null)
		{
			num = 0;
		}
		switch (num)
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
	protected unsafe EntityProgress(EntityProgress original)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_004e: Expected I4, but got Obj
		//IL_00d5: Expected Obj, but got I4
		//IL_006e: Expected Obj, but got I4
		//IL_00fa->IL0031: Incompatible stack types: I4 vs Obj
		//IL_0073->IL0031: Incompatible stack types: I4 vs Obj
		//IL_009e->IL0031: Incompatible stack types: I4 vs Obj
		//IL_00c0->IL0031: Incompatible stack types: I4 vs Obj
		//IL_0105->IL0031: Incompatible stack types: I4 vs Obj
		//IL_007e->IL0031: Incompatible stack types: I4 vs Obj
		//IL_00a9->IL0031: Incompatible stack types: I4 vs Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		_ = ((KeyValuePair<string, object>*)this)->Value;
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
					((ConfigValue)this).Key__BackingField = ((ConfigValue)(object)original).Id__BackingField;
					obj2 = 0;
					if (((ConfigValue)ConfigValue.Icon__BackingField).DisplayName__BackingField == null)
					{
						obj2 = 0;
					}
					continue;
				case 4:
					ConfigValue.ReflectInternalTransmitter = ((ConfigValue)(object)original).Description__BackingField;
					obj2 = 0;
					if (ConfigValue._003C_003Ec._003C_003E9__23_0 == null)
					{
						obj2 = 1;
					}
					continue;
				case 0:
					return;
				case 5:
					ConfigValue._003C_003Ec._003C_003E9__23_2 = (Func<ConfigValue, List<ConfigValue>>)ConfigValue._003C_003Ec._003C_003E9__23_1;
					obj2 = 2;
					continue;
				case 2:
					break;
				case 1:
					((ConfigValue._003C_003Ec__DisplayClass22_0)this).key = (string)(object)ConfigValue._003C_003Ec__DisplayClass21_0.RestartOrder;
					obj2 = 5;
					if (((ConfigValueAttribute)(object)ConfigValue._003C_003Ec__DisplayClass22_0.DetachRole).Icon__BackingField == ValueIcon.AccessTime)
					{
						obj2 = 1;
					}
					continue;
				}
				break;
			}
			((ConfigValue._003C_003Ec__DisplayClass21_0)this).id = (string)(object)ConfigValue._003C_003Ec._003C_003E9__23_3;
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
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return (BoolValueAttribute.DecorateIdentifiableAggregator == null) ? ((byte)1) : ((byte)0);
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
	protected unsafe object _FF00_FF00케()
	{
		//IL_001e: Expected Ref, but got VT
		//IL_001f: Expected Obj, but got I4
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return ((Dictionary<string, object>.Enumerator*)typeof(ConfigValue).TypeHandle)->MoveNext();
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
		//IL_001b: Expected I4, but got Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return (uint)(int)BoolValueAttribute.DecorateIdentifiableAggregator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00툀(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0083: Expected Obj, but got I4
		//IL_0056->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0088->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0061->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0093->IL0026: Incompatible stack types: I4 vs Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				if (P_0 == null)
				{
					return 0;
				}
				obj2 = 0;
				if (((ConfigValue)BoolValueAttribute.DecorateIdentifiableAggregator).Id__BackingField == null)
				{
					obj2 = 0;
				}
				break;
			default:
				return BoolValue.DecorateOperationalTracker() ? ((byte)1) : ((byte)0);
			case 2:
				if (P_0 == P_1)
				{
					return 1;
				}
				obj2 = 1;
				if (((ConfigValue)ConfigValue.Icon__BackingField).DisplayName__BackingField != null)
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
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return BoolValueAttribute.DecorateIdentifiableAggregator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00픀(object P_0, object P_1)
	{
		//IL_001b: Expected I4, but got Obj
		//IL_001c: Invalid comparison between Unknown and I4
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		((BoolValue)P_0).Value = (byte)(int)P_1 != 0;
		return ((int)/*Error near IL_001e: Stack underflow*/ == 0) ? ((byte)1) : ((byte)0);
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
		//IL_001b: Expected I4, but got Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return (EnumStepPhase)BoolValueAttribute.DecorateIdentifiableAggregator;
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
		//IL_001a: Expected I4, but got Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return new BoolValue((byte)(int)this != 0);
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
		//IL_0021: Expected I4, but got Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		((BoolValue)(P_0 as ConfigValue))._002Ector();
		return (byte)(int)this;
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
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected Obj, but got I4
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		object obj = 1;
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
				BoolValueAttribute.DecorateIdentifiableAggregator = P_0;
				obj2 = 0;
				if (((ConfigValue)ConfigValue.Id__BackingField).Key__BackingField == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FFFD(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected Obj, but got I4
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		object obj = 1;
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
				BoolValueAttribute.DecorateIdentifiableAggregator = P_0;
				obj2 = 0;
				if (((ConfigValue)ConfigValue.Id__BackingField).Key__BackingField == null)
				{
					obj2 = 0;
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
	protected unsafe byte _FF00_FF00_E700(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_005b: Expected I4, but got Obj
		//IL_0066: Expected I4, but got Obj
		//IL_0203: Expected Obj, but got I4
		//IL_00f2: Expected I4, but got Obj
		//IL_0139: Expected I4, but got Obj
		//IL_01ea: Expected Obj, but got I
		//IL_0094: Expected I4, but got Obj
		//IL_016f: Expected Obj, but got Ref
		//IL_0174: Expected Obj, but got I4
		//IL_0184: Expected Obj, but got F4
		//IL_0080->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0220->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0236->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_014e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01c4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01ef->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00bd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0189->IL0026: Incompatible stack types: I4 vs Obj
		//IL_012d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ec->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0117->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0159->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01cf->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01fa->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0194->IL0026: Incompatible stack types: I4 vs Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				((BoolValue)/*Error near IL_0066: Stack underflow*/).Value = (byte)(int)P_0 != 0;
				((Dictionary<string, object>.Enumerator*)/*Error near IL_006b: Stack underflow*/)->MoveNext();
				obj2 = 7;
				if (((ConfigValue)ConfigValue.Key__BackingField).Icon__BackingField == ValueIcon.AccessTime)
				{
					obj2 = 9;
				}
				break;
			case 1:
				return 1;
			case 9:
				((BoolValueAttribute)P_0)._002Ector((byte)(int)this != 0);
				obj = (object)/*Error near IL_0096: Stack underflow*/;
				((Func<ConfigValue, bool>)(object)(*(Dictionary<, >*)/*Error near IL_00a3: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((object)/*Error near IL_00a3: Stack underflow*/, (nint)(&obj));
				Enumerable.FirstOrDefault<TSource>((IEnumerable<TSource>)/*Error near IL_00a8: Stack underflow*/, (Func<TSource, bool>)/*Error near IL_00a8: Stack underflow*/);
				obj2 = 0;
				if (ConfigValue._003C_003Ec._003C_003E9__23_1 == null)
				{
					obj2 = 8;
				}
				break;
			case 4:
				((Func<ConfigValue, List<ConfigValue>>)/*Error near IL_00cd: Stack underflow*/)._002Ector((object)/*Error near IL_00cd: Stack underflow*/, (nint)/*Error near IL_00cd: Stack underflow*/);
				obj2 = 0;
				if (((ConfigValue._003C_003Ec__DisplayClass21_0)(object)ConfigValue._003C_003Ec._003C_003E9__23_3).id == null)
				{
					obj2 = 3;
				}
				break;
			case 5:
				((ConfigValue)/*Error near IL_00f2: Stack underflow*/).Icon = (ValueIcon)P_0;
				((List<ConfigValue>)/*Error near IL_00f7: Stack underflow*/).AddRange((IEnumerable<ConfigValue>)/*Error near IL_00f7: Stack underflow*/);
				obj2 = 7;
				if (((ConfigValueAttribute)(object)ConfigValue._003C_003Ec__DisplayClass22_0.DetachRole).Icon__BackingField != ValueIcon.AccessTime)
				{
					obj2 = 5;
				}
				break;
			case 11:
				((ConfigValue)/*Error near IL_011d: Stack underflow*/).Description = (string?)P_0;
				_ = (Type?)/*Error near IL_0122: Stack underflow*/ == (Type?)/*Error near IL_0122: Stack underflow*/;
				obj2 = 10;
				break;
			case 6:
				((Type)/*Error near IL_0139: Stack underflow*/).GetProperties((BindingFlags)((ConfigValue)P_0).SetId((string)(object)this));
				obj2 = 1;
				if (((ExpanderValue)ExpanderValue.Item__BackingField).IsExpanded__BackingField != 0)
				{
					obj2 = 0;
				}
				break;
			case 10:
				ConfigValue.InitValue(this);
				obj = P_0;
				((List<string>)((string?)/*Error near IL_016f: Stack underflow*/ == (string?)(&obj)))._002Ector();
				obj2 = 0;
				if ((int)((FloatValue)FloatValue.Min__BackingField).Max__BackingField == 0)
				{
					obj2 = 0;
				}
				break;
			case 7:
				((ConfigValue._003C_003Ec)this)._002Ector();
				obj = P_0;
				((StringBuilder)/*Error near IL_01af: Stack underflow*/).Append(((DefaultInterpolatedStringHandler)(*(Array*)(&obj))/*cast due to constrained. prefix*/).ToStringAndClear());
				obj2 = 9;
				if (FloatValueAttribute.DecorateCommonChain == null)
				{
					obj2 = 11;
				}
				break;
			case 8:
				((ConfigValue._003C_003Ec__DisplayClass21_0)/*Error near IL_01d5: Stack underflow*/)._003CSetId_003Eb__0((ConfigValue)P_0);
				_ = EqualityComparer<Type>.Default;
				obj2 = 4;
				if (((IntegerValue)IntegerValue.Min__BackingField).Max__BackingField == 0)
				{
					obj2 = 6;
				}
				break;
			case 2:
				obj = ((ConfigValue._003C_003Ec__DisplayClass22_0)P_0)._003CGetValue_003Eb__0((ConfigValue)(object)this);
				((EqualityComparer<int>)(object)(*(EntityMassManifest*)/*Error near IL_0210: Stack underflow*/)/*cast due to constrained. prefix*/).GetHashCode((int)(&obj));
				_ = EqualityComparer<string>.Default;
				_ = 5;
				break;
			case 3:
				((EqualityComparer<int>)/*Error near IL_022b: Stack underflow*/).Equals((int)/*Error near IL_022b: Stack underflow*/, (int)((ConfigValueAttribute)P_0).Icon);
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
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
				BoolValueAttribute.DecorateIdentifiableAggregator = P_0;
				obj2 = 0;
				if (((ConfigValue)ConfigValue.Id__BackingField).Key__BackingField == null)
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
	internal unsafe object _FF00_FF00_EE00()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0073: Expected I4, but got Obj
		//IL_018b: Expected Obj, but got I4
		//IL_01ba: Expected Obj, but got I4
		//IL_0253: Expected Obj, but got Ref
		//IL_0093: Expected I4, but got Obj
		//IL_0093: Expected Obj, but got Ref
		//IL_0279: Expected Obj, but got I
		//IL_012c: Expected Obj, but got Ref
		//IL_022d: Expected Obj, but got I4
		//IL_023c: Expected Obj, but got F4
		//IL_00cb: Expected Obj, but got I4
		//IL_01f7: Expected Obj, but got Ref
		//IL_020b: Expected Obj, but got F4
		//IL_01a2: Expected Obj, but got Ref
		//IL_0190->IL0026: Incompatible stack heights: 3 vs 1
		//IL_01c4->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0262->IL0026: Incompatible stack heights: 2 vs 1
		//IL_011a->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a2->IL0026: Incompatible stack heights: 2 vs 1
		//IL_027e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_013b->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0241->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0210->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01e5->IL0026: Incompatible stack heights: 3 vs 1
		//IL_01b1->IL0026: Incompatible stack heights: 2 vs 1
		//IL_019b->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0125->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00bd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0289->IL0026: Incompatible stack types: I4 vs Obj
		//IL_024c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_021b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01f0->IL0026: Incompatible stack heights: 3 vs 1
		//IL_014d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0168->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0173->IL0026: Incompatible stack types: I4 vs Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		object obj = 8;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 6:
				((BoolValue)(&obj)).Value = (byte)(int)this != 0;
				((MemberInfo)/*Error near IL_0098: Stack underflow*/).GetCustomAttribute<ConfigValueAttribute>();
				_ = 9;
				break;
			case 7:
				if (obj == null)
				{
					obj2 = 0;
					if (((ConfigValue)ConfigValue.Key__BackingField).Icon__BackingField == ValueIcon.AccessTime)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 15;
			default:
				obj = 1;
				obj2 = 11;
				break;
			case 5:
				_ = ref obj;
				((DefaultInterpolatedStringHandler*)this)->AppendFormatted(BoolValueAttribute.ReflectInterruptibleTag() ? 1 : 0);
				_ = 3;
				if (ConfigValue._003C_003Ec._003C_003E9__23_1 == null)
				{
					_ = 1;
				}
				break;
			case 9:
				Enumerable.Select<TSource, TResult>((IEnumerable<TSource>)/*Error near IL_0131: Stack underflow*/, (Func<TSource, TResult>)(object)((ConfigValue)(&obj)).Key);
				_ = 4;
				break;
			case 15:
				if ((nint)obj == 5)
				{
					obj2 = 12;
					break;
				}
				goto case 10;
			case 11:
			case 16:
				if (obj != null)
				{
					return ((ConfigValue._003C_003Ec)/*Error near IL_0229: Stack underflow*/)._003CGetValues_003Eb__23_0((ConfigValue)(object)this);
				}
				obj2 = 2;
				if (ConfigValue._003C_003Ec__DisplayClass21_0.RestartOrder == null)
				{
					obj2 = 1;
				}
				break;
			case 1:
				_ = ref obj;
				_ = ((ConfigValue)this).DisplayName;
				_ = 3;
				if (((ConfigValueAttribute)ConfigValueAttribute.Icon__BackingField).Key__BackingField != null)
				{
					_ = 17;
				}
				break;
			case 17:
				Enumerable.ToList<TSource>((IEnumerable<TSource>)((ConfigValue)/*Error near IL_01a2: Stack underflow*/).Load((Dictionary<string, object>)(&obj)));
				_ = 5;
				break;
			case 2:
				_ = ref obj;
				((Type)8).GetProperties(BindingFlags.Instance);
				_ = 14;
				break;
			case 14:
				_ = ref obj;
				((ConfigValue)this).GetValues().GetType();
				_ = 13;
				if (ExpanderValue.PlanTracker == null)
				{
					_ = 13;
				}
				break;
			case 13:
				((ConfigValue)(&obj))._002Ector();
				((List<string>)/*Error near IL_01fc: Stack underflow*/)._002Ector();
				obj2 = 1;
				if ((int)((FloatValue)FloatValue.Min__BackingField).Max__BackingField == 0)
				{
					obj2 = 0;
				}
				break;
			case 4:
				Unsafe.Write((void*)(nint)/*Error near IL_0222: Stack underflow*/, new DefaultInterpolatedStringHandler((int)/*Error near IL_0222: Stack underflow*/, (int)(&obj)));
				return (object)/*Error near IL_0223: Stack underflow*/;
			case 10:
				obj = 0;
				obj2 = 11;
				if ((int)((FloatValueAttribute)FloatValueAttribute.MaxValue__BackingField).DefaultValue__BackingField == 0)
				{
					obj2 = 16;
				}
				break;
			case 3:
				((ConfigValue._003C_003Ec)/*Error near IL_0253: Stack underflow*/)._003CGetValues_003Eb__23_3((List<ConfigValue>)(&obj));
				RuntimeHelpers.EnsureSufficientExecutionStack();
				_ = 6;
				break;
			case 8:
				((ConfigValue._003C_003Ec__DisplayClass21_0)/*Error near IL_0268: Stack underflow*/)._003CSetId_003Eb__0((ConfigValue)(object)this);
				obj = (object)/*Error near IL_026a: Stack underflow*/;
				obj2 = 3;
				if (((IntegerValue)IntegerValue.Value__BackingField).Min__BackingField == 0)
				{
					obj2 = 7;
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
	internal unsafe uint _FF00_FF00_F000()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_003a: Expected Obj, but got VT
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected I, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected I, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_0096: Expected VT, but got I4
		//IL_0098: Expected I4, but got Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		object value = ((KeyValuePair<string, object>*)/*Error near IL_0019: Stack underflow*/)->Value;
		((BoolValue)this)._002Ector();
		((IDisposable)value).Dispose();
		((List<ConfigValue>)((Dictionary<string, object>)(/*Error near IL_002a: Stack underflow*/ * -1521134295)).GetEnumerator()).ForEach((Action<ConfigValue>)((ConfigValue)this).DisplayName__BackingField);
		((Func<ConfigValue, bool>)/*Error near IL_0046: Stack underflow*/)._002Ector((object)/*Error near IL_0046: Stack underflow*/, (nint)((/*Error near IL_003b: Stack underflow*/ + /*Error near IL_003b: Stack underflow*/) * -1521134295));
		((List<ConfigValue>)/*Error near IL_0051: Stack underflow*/).Add((ConfigValue)(object)ConfigValue._003C_003Ec._003C_003E9);
		((List<ConfigValue>)((/*Error near IL_0052: Stack underflow*/ + /*Error near IL_0052: Stack underflow*/) * -1521134295))._002Ector();
		((Func<List<ConfigValue>, IEnumerable<ConfigValue>>)/*Error near IL_0074: Stack underflow*/)._002Ector((object)/*Error near IL_0074: Stack underflow*/, (nint)((/*Error near IL_0069: Stack underflow*/ + Enumerable.Select<TSource, TResult>((IEnumerable<TSource>)/*Error near IL_0068: Stack underflow*/, (Func<TSource, TResult>)(object)ConfigValue._003C_003Ec._003C_003E9__23_2)) * -1521134295));
		((List<ConfigValue>)/*Error near IL_007f: Stack underflow*/).AddRange((IEnumerable<ConfigValue>)(object)ConfigValue._003C_003Ec__DisplayClass21_0.RestartOrder);
		return (uint)(int)((object)CustomAttributeExtensions.GetCustomAttribute<T>((MemberInfo)((/*Error near IL_0080: Stack underflow*/ + /*Error near IL_0080: Stack underflow*/) * -1521134295)) + (object)Type.GetTypeFromHandle((RuntimeTypeHandle)((ConfigValueAttribute)this).Icon__BackingField));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_F100(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected Obj, but got I4
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		object obj = 1;
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
				BoolValueAttribute.DecorateIdentifiableAggregator = P_0;
				obj2 = 0;
				if (((ConfigValue)ConfigValue.Id__BackingField).Key__BackingField == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_F200()
	{
		//IL_001b: Expected I4, but got Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return (uint)(int)BoolValueAttribute.DecorateIdentifiableAggregator;
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
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return BoolValueAttribute.DecorateIdentifiableAggregator;
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
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00b1: Expected I4, but got Obj
		//IL_00b0: Expected native int or pointer, but got Obj
		//IL_009e: Expected native int or pointer, but got Obj
		//IL_0077: Expected I4, but got Obj
		//IL_0076: Expected native int or pointer, but got Obj
		//IL_004f: Expected I4, but got Obj
		//IL_004f: Expected Obj, but got I
		//IL_00bb->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00d8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a9->IL0026: Incompatible stack heights: 2 vs 1
		//IL_008b->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0096->IL0026: Incompatible stack heights: 2 vs 1
		//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
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
				((BoolValue)P_0).Value = (byte)(int)this != 0;
				*(_003F*)(nint)/*Error near IL_0050: Stack underflow*/ = /*Error near IL_0050: Stack underflow*/;
				obj2 = 4;
				if (((ConfigValue)ConfigValue.Id__BackingField).Key__BackingField != null)
				{
					obj2 = 1;
				}
				break;
			case 4:
				*(int*)(nint)this = (int)BoolValue.ReflectVirtualFinalizer();
				_ = 1;
				if (((ConfigValue)ConfigValue.DisplayName__BackingField).Description__BackingField == null)
				{
					_ = 1;
				}
				break;
			case 3:
				*(int*)(nint)this = (BoolValueAttribute.ReflectInterruptibleTag() ? 1 : 0);
				_ = 2;
				break;
			case 1:
				*(int*)(nint)this = (int)BoolValueAttribute.DecorateCustomizableDefinition();
				_ = 3;
				break;
			case 2:
				Unsafe.Write((void*)P_4, ((ConfigValue)this).Id);
				obj2 = 0;
				if (ConfigValue._003C_003Ec._003C_003E9__23_2 != null)
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
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected Obj, but got I4
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		object obj = 1;
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
				BoolValueAttribute.DecorateIdentifiableAggregator = P_0;
				obj2 = 0;
				if (((ConfigValue)ConfigValue.Id__BackingField).Key__BackingField != null)
				{
					obj2 = 0;
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
		//IL_001b: Expected I4, but got Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return (uint)(int)BoolValueAttribute.DecorateIdentifiableAggregator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00ﬀ(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_005b: Expected I4, but got Obj
		//IL_01d4: Expected Ref, but got F4
		//IL_013f: Expected Obj, but got I4
		//IL_0136->IL01be: Incompatible stack heights: 2 vs 0
		//IL_015a->IL00ad: Incompatible stack heights: 1 vs 0
		//IL_007b->IL00f6: Incompatible stack heights: 2 vs 0
		//IL_0111->IL01d5: Incompatible stack heights: 1 vs 0
		//IL_0198->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01b3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0144->IL0022: Incompatible stack heights: 2 vs 0
		//IL_0164->IL0026: Incompatible stack heights: 2 vs 1
		//IL_008f->IL0026: Incompatible stack heights: 3 vs 1
		//IL_011b->IL0026: Incompatible stack heights: 2 vs 1
		//IL_01be->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009a->IL0026: Incompatible stack heights: 3 vs 1
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
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
					_ = ((KeyValuePair<string, object>*)/*Error near IL_0065: Stack underflow*/)->Value;
					_ = ((ConfigValue)this).Id__BackingField;
					if ((int)((Dictionary<string, object>)((ConfigValue)P_0).Key__BackingField).GetEnumerator() == 0)
					{
						_ = 10;
						if (((ConfigValue)ConfigValue.DisplayName__BackingField).Description__BackingField == null)
						{
							_ = 7;
						}
						break;
					}
					goto case 9;
				case 3:
				{
					((Func<ConfigValue, bool>)/*Error near IL_00b2: Stack underflow*/)._002Ector((object)/*Error near IL_00b2: Stack underflow*/, (nint)/*Error near IL_00b2: Stack underflow*/);
					ConfigValue._003C_003Ec obj3 = ConfigValue._003C_003Ec._003C_003E9;
					((List<ConfigValue>)(object)ConfigValue._003C_003Ec._003C_003E9__23_0)._002Ector();
					if (obj3 == null)
					{
						obj2 = 8;
						break;
					}
					goto case 7;
				}
				case 9:
					((Func<List<ConfigValue>, IEnumerable<ConfigValue>>)/*Error near IL_00fb: Stack underflow*/)._002Ector((object)/*Error near IL_00fb: Stack underflow*/, (nint)/*Error near IL_00fb: Stack underflow*/);
					_ = ConfigValue._003C_003Ec__DisplayClass21_0.RestartOrder;
					if (CustomAttributeExtensions.GetCustomAttribute<T>((MemberInfo)(object)((ConfigValue._003C_003Ec__DisplayClass22_0)P_0).key) != null)
					{
						_ = 5;
						break;
					}
					goto case 4;
				case 5:
					_ = ((PropertyInfo)/*Error near IL_0120: Stack underflow*/).PropertyType;
					_ = ((ConfigValueAttribute)this).Key__BackingField;
					if (Enumerable.ToList<TSource>((IEnumerable<TSource>)((ConfigValueAttribute)P_0).DisplayName__BackingField) == null)
					{
						goto end_IL_0026;
					}
					goto default;
				case 6:
					((ConfigValue)/*Error near IL_014a: Stack underflow*/).GetValue((string)(object)this);
					if ((object)((ConfigValue)P_0).GetValues().GetType() == null)
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
					if (this == P_0)
					{
						return 1;
					}
					obj2 = 0;
					if ((int)((FloatValue)FloatValue.Unit__BackingField).Value__BackingField == 0)
					{
						obj2 = 1;
					}
					break;
				default:
					((DefaultInterpolatedStringHandler*)/*Error near IL_01c3: Stack underflow*/)->AppendFormatted<T>((T)/*Error near IL_01c3: Stack underflow*/);
					((DefaultInterpolatedStringHandler*)((FloatValue)this).Max__BackingField)->AppendFormatted((string?)(object)FloatValue.CheckMixedHandler);
					return (byte)/*Error near IL_01d5: Stack underflow*/;
				case 4:
				case 8:
				case 10:
				case 11:
					return 0;
				}
				continue;
				end_IL_0026:
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
