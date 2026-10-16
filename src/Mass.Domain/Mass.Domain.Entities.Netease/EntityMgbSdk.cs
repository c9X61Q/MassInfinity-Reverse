using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Mass.Domain.Value;

namespace Mass.Domain.Entities.Netease;

public class EntityMgbSdk
{
	internal static EntityMgbSdk? DecorateStatelessConfig;

	[JsonPropertyName("code")]
	public int Code
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00쐀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00였((uint)value);
		}
	}

	[JsonPropertyName("subcode")]
	public int SubCode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00준();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00봀((uint)value);
		}
	}

	[JsonPropertyName("status")]
	public string? Status
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string?)_FF00_FF00먀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00윀(value);
		}
	}

	[JsonPropertyName("msg")]
	public string? Message
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string?)_FF00_FF00똀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_A700(value);
		}
	}

	[JsonPropertyName("aid")]
	public uint Aid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00묀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00렀(value);
		}
	}

	[JsonPropertyName("sdkuid")]
	public string SdkUid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00대();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00됀(value);
		}
	}

	public unsafe string Reason
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0029: Expected Obj, but got I
			//IL_0058: Expected I, but got Obj
			//IL_0051: Expected Obj, but got I
			nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 173, 1790778421, 0, 0);
			object obj = num;
			if (num == 0)
			{
				obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778421, new IntPtr(2737337560604L), 15);
			}
			return (string)((delegate*<object, object>)obj)(this);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EntityMgbSdk()
	{
		//IL_0035: Expected Obj, but got I4
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		((ConfigValue)/*Error near IL_001b: Stack underflow*/).Id__BackingField = this;
		((IDisposable)this).Dispose();
		int num = 0;
		if (((ConfigValue)ConfigValue.Icon__BackingField).DisplayName__BackingField != null)
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
	internal static bool CheckScheduledEmitter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EntityMgbSdk? ReflectFilteredRunner()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00ꘀ(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778420, new IntPtr(2737337546044L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_A700(object? P_0)
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
	internal unsafe object? _FF00_FF00넀()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0093: Expected I4, but got Obj
		//IL_01c1: Expected I4, but got Obj
		//IL_0307: Expected Obj, but got I
		//IL_0282: Expected VT, but got I4
		//IL_01ac: Expected Obj, but got I4
		//IL_01b5: Expected Obj, but got I4
		//IL_024b: Expected Obj, but got I4
		//IL_0296: Expected Obj, but got F4
		//IL_032d: Expected Obj, but got I
		//IL_026b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02e5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01fc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_030c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ff->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_016e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0276->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02f0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01df->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0317->IL0026: Incompatible stack types: I4 vs Obj
		//IL_029b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_034e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0332->IL0026: Incompatible stack types: I4 vs Obj
		//IL_023b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_015c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01ea->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02a6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_033d->IL0026: Incompatible stack types: I4 vs Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		object obj = 23;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 16:
				case 18:
					((BoolValueAttribute)/*Error near IL_00e5: Stack underflow*/)._002Ector((byte)/*Error near IL_00e5: Stack underflow*/ != 0);
					obj = (object)/*Error near IL_00e7: Stack underflow*/;
					obj2 = 2;
					continue;
				case 2:
				case 5:
				case 8:
				case 11:
				case 15:
				case 19:
					obj = obj;
					obj2 = 20;
					continue;
				case 25:
					((List<ConfigValue>)obj).Add((ConfigValue)(object)BoolValueAttribute.DecorateCustomizableDefinition());
					if ((int)/*Error near IL_0152: Stack underflow*/ != 0)
					{
						obj2 = 6;
						continue;
					}
					goto case 21;
				case 23:
					((ConfigValue)/*Error near IL_0162: Stack underflow*/).Id = (string)(object)this;
					obj = (object)/*Error near IL_0164: Stack underflow*/;
					obj2 = 22;
					continue;
				case 14:
					obj = ((ConfigValue)/*Error near IL_01aa: Stack underflow*/).Icon;
					obj = 5;
					break;
				case 7:
					((ConfigValue)/*Error near IL_01c1: Stack underflow*/).Icon = (ValueIcon)obj;
					((List<ConfigValue>)/*Error near IL_01c6: Stack underflow*/).AddRange((IEnumerable<ConfigValue>)/*Error near IL_01c6: Stack underflow*/);
					if ((int)/*Error near IL_01cb: Stack underflow*/ != 0)
					{
						obj2 = 5;
						if (((ConfigValueAttribute)(object)ConfigValue._003C_003Ec__DisplayClass22_0.DetachRole).Icon__BackingField == ValueIcon.AccessTime)
						{
							obj2 = 9;
						}
						continue;
					}
					goto case 25;
				case 3:
				case 4:
					((ConfigValue)/*Error near IL_01f0: Stack underflow*/).Description = (string?)(object)this;
					obj = (object)/*Error near IL_01f2: Stack underflow*/;
					obj2 = 11;
					continue;
				case 24:
					((PropertyInfo)/*Error near IL_022c: Stack underflow*/).SetValue((object?)/*Error near IL_022c: Stack underflow*/, (object?)((ConfigValue)/*Error near IL_0227: Stack underflow*/).GetValue((string)obj));
					if ((int)/*Error near IL_0231: Stack underflow*/ != 0)
					{
						obj2 = 13;
						continue;
					}
					goto case 12;
				case 6:
				case 17:
					obj = ConfigValue.Get((Type)/*Error near IL_0240: Stack underflow*/);
					obj = 8;
					break;
				default:
					ConfigValue.InitValue((object?)/*Error near IL_0255: Stack underflow*/);
					obj = (object)/*Error near IL_0257: Stack underflow*/;
					obj2 = 17;
					if (((FloatValue)(object)ExpanderValue.PlanTracker).Unit__BackingField != null)
					{
						obj2 = 19;
					}
					continue;
				case 12:
					((DefaultInterpolatedStringHandler*)obj)->AppendFormatted<T>((T)ConfigValue.ReflectExpandableRecommender());
					if ((int)/*Error near IL_0287: Stack underflow*/ == 0)
					{
						obj2 = 6;
						if (FloatValue.CheckMixedHandler != null)
						{
							obj2 = 7;
						}
						continue;
					}
					goto case 14;
				case 1:
				case 9:
					obj = ((ConfigValue._003C_003Ec)/*Error near IL_02cf: Stack underflow*/)._003CGetValues_003Eb__23_2((ConfigValue)/*Error near IL_02cf: Stack underflow*/);
					obj2 = 11;
					if (FloatValueAttribute.DecorateCommonChain != null)
					{
						obj2 = 15;
					}
					continue;
				case 10:
					((ConfigValue._003C_003Ec__DisplayClass21_0)/*Error near IL_02f6: Stack underflow*/)._003CSetId_003Eb__0((ConfigValue)(object)this);
					obj = (object)/*Error near IL_02f8: Stack underflow*/;
					obj2 = 24;
					if (((IntegerValue)IntegerValue.Value__BackingField).Min__BackingField != 0)
					{
						obj2 = 18;
					}
					continue;
				case 22:
					if (obj == null)
					{
						obj2 = 6;
						if (IntegerValue.DecorateBasicGateway == null)
						{
							obj2 = 10;
						}
						continue;
					}
					goto case 20;
				case 21:
					if (obj != null)
					{
						goto case 3;
					}
					obj2 = 18;
					continue;
				case 20:
					return obj;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _FF00_FF00눀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778419, new IntPtr(2737337556444L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object? _FF00_FF00대()
	{
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return BoolValueAttribute.DecorateIdentifiableAggregator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00됀(object? P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
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
	internal unsafe object? _FF00_FF00딀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778418, new IntPtr(2737337558524L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object? _FF00_FF00똀()
	{
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return BoolValueAttribute.DecorateIdentifiableAggregator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00뜀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778417, new IntPtr(2737337552284L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00렀(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected Obj, but got I4
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
	internal unsafe void _FF00_FF00뤀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778416, new IntPtr(2737337550204L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object? _FF00_FF00먀()
	{
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return BoolValueAttribute.DecorateIdentifiableAggregator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00묀()
	{
		//IL_001b: Expected I4, but got Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return (uint)(int)BoolValueAttribute.DecorateIdentifiableAggregator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00밀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778415, new IntPtr(2737337557484L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00봀(uint P_0)
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
	internal unsafe void _FF00_FF00븀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778414, new IntPtr(2737337542924L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00뼀()
	{
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return (BoolValueAttribute.DecorateIdentifiableAggregator == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00쀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778413, new IntPtr(2737337538764L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object? _FF00_FF00섀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778412, new IntPtr(2737337548124L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object? _FF00_FF00숀()
	{
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return BoolValueAttribute.DecorateIdentifiableAggregator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object? _FF00_FF00쌀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778411, new IntPtr(2737337558524L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00쐀()
	{
		//IL_001b: Expected I4, but got Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return (uint)(int)BoolValueAttribute.DecorateIdentifiableAggregator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00씀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778410, new IntPtr(2737337565804L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00였(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected Obj, but got I4
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
	internal void _FF00_FF00윀(object? P_0)
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
	internal unsafe void _FF00_FF00저(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778409, new IntPtr(2737337554364L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00준()
	{
		//IL_001b: Expected I4, but got Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return (uint)(int)BoolValueAttribute.DecorateIdentifiableAggregator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00쨀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778408, new IntPtr(2737337539804L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}
}
