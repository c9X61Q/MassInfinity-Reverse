using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Mass.Domain.Value;

public abstract class ConfigValue
{
	private static object ReflectInternalTransmitter;

	public string Id
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00䌀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00堀(value);
		}
	}

	public string Key
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00䠀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00䴀(value);
		}
	}

	public required ValueIcon Icon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00娀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00戀(value);
		}
	}

	public required string DisplayName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00䰀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00䘀(value);
		}
	}

	public string? Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string?)_FF00_FF00_FF00开();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00倀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe ConfigValue Load(Dictionary<string, object> config)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 22, 1790778548, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778548, new IntPtr(2737337522124L), 15);
		}
		return (ConfigValue)((delegate*<object, object, object>)obj)(this, config);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ConfigValue SetId(string id)
	{
		return (ConfigValue)_FF00_FF00_FF00圀(id);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ConfigValue? GetValue(string key)
	{
		return (ConfigValue?)_FF00_FF00_FF00䐀(key);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe List<ConfigValue> GetValues()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 25, 1790778547, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778547, new IntPtr(2737337533564L), 15);
		}
		return (List<ConfigValue>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static List<ConfigValue> Get(Type type)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 26, 1790778546, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778546, new IntPtr(2737337559564L), 15);
		}
		return (List<ConfigValue>)((delegate*<object, object>)obj)(type);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InitValue(object? obj)
	{
		_FF00_FF00_FF00匀(obj);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetValue(object? obj, SectionValue section)
	{
		_FF00_FF00_FF00挀(obj, section);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected ConfigValue()
	{
		//IL_0042: Expected I4, but got Obj
		//IL_0030->IL0039: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		ConfigValue configValue = this;
		if (false)
		{
			configValue = (ConfigValue)0;
		}
		switch ((int)configValue)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectExpandableRecommender()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ConfigValue CheckHiddenAnalyzer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00䈀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778545, new IntPtr(2737337534604L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00䌀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00䐀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1405, 1790778544, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778544, new IntPtr(2737337555404L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00䘀(object P_0)
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
	internal unsafe void _FF00_FF00_FF00䜀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778543, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00䠀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00䤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778542, new IntPtr(2737337535644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00䨀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778541, new IntPtr(2737337537724L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00䬀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00䰀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00䴀(object P_0)
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
	internal List<ConfigValue> _FF00_FF00_FF00一()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0046: Expected I4, but got Obj
		//IL_00d2->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0085->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0059->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00a3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00dd->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0096->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0077->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0158->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0115->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0163->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0120->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 7;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 6:
				_ = 3;
				continue;
			case 5:
				if (obj == null)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
			case 3:
				obj = this;
				obj2 = 9;
				continue;
			case 9:
				if (obj != null)
				{
					obj2 = 8;
					continue;
				}
				goto case 2;
			case 7:
				obj = (object)/*Error near IL_0099: Stack underflow*/;
				obj2 = 6;
				continue;
			default:
				return (List<ConfigValue>)obj;
			case 2:
				obj = this;
				if (5 == 0)
				{
					obj2 = 0;
				}
				continue;
			case 8:
			{
				object obj3 = obj;
				object obj4 = obj ?? obj3;
				if (obj4 == null)
				{
					obj4 = obj3;
				}
				if (2 == 0)
				{
					_ = 2;
				}
				continue;
			}
			case 4:
				break;
			}
			object obj5 = obj;
			object obj6 = obj ?? obj5;
			if (obj6 == null)
			{
				obj6 = obj5;
			}
			if (true)
			{
				_ = 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<ConfigValue> _FF00_FF00_FF00伀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778540, new IntPtr(2737337536684L), 15))(null, 0, new IntPtr(0L));
		return (List<ConfigValue>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00倀(object P_0)
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
	internal unsafe void _FF00_FF00_FF00儀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778539, new IntPtr(2737337548124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00刀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778538, new IntPtr(2737337561644L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_FF00_FF00匀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_00ba: Expected I4, but got Obj
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_0114: Expected Obj, but got I4
		//IL_015d: Expected Obj, but got I4
		//IL_03a7: Expected Obj, but got I4
		//IL_027f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0263->IL0019: Incompatible stack heights: 0 vs 1
		//IL_03ff->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00d1->IL0019: Incompatible stack heights: 0 vs 1
		//IL_011e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0162->IL0015: Incompatible stack heights: 3 vs 0
		//IL_03d0->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0173->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0243->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0132->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0435->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0203->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0372->IL0019: Incompatible stack types: I4 vs Obj
		//IL_028a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0327->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0314->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0234->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02f4->IL0019: Incompatible stack heights: 0 vs 1
		//IL_026e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_040a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_019c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00dc->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0358->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0185->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00fc->IL0019: Incompatible stack types: I4 vs Obj
		//IL_021f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0111->IL0019: Incompatible stack types: I4 vs Obj
		//IL_013d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_02d5->IL0019: Incompatible stack heights: 0 vs 1
		//IL_020e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0385->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01c8->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0332->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02ff->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01a7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0363->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02e0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0390->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03be->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01d3->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 37;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 1:
				case 6:
				case 10:
				case 12:
				case 14:
				case 28:
				case 30:
				case 35:
					obj++;
					if (1 == 0)
					{
						obj2 = 4;
					}
					continue;
				case 21:
					if (obj == null)
					{
						obj2 = 10;
						continue;
					}
					goto case 20;
				case 19:
				case 25:
					if (obj != null)
					{
						obj2 = 38;
						continue;
					}
					goto case 1;
				case 13:
					obj = 0;
					obj2 = 18;
					continue;
				case 26:
					if (35 == 0)
					{
						_ = 5;
					}
					continue;
				case 5:
					return;
				case 16:
					goto end_IL_0019;
				case 23:
					_ = 12;
					continue;
				case 17:
					if (obj != null)
					{
						obj2 = 15;
						continue;
					}
					goto case 1;
				case 11:
				case 27:
					if (obj != null)
					{
						if (false)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 3;
				case 37:
					if (P_0 != null)
					{
						if (36 != 0)
						{
							obj2 = 35;
						}
						continue;
					}
					return;
				case 33:
					if (6 == 0)
					{
						_ = 6;
					}
					continue;
				case 22:
					if (obj != null)
					{
						obj2 = 33;
						continue;
					}
					goto case 1;
				case 4:
				case 18:
					if ((nint)obj >= ((Array)obj).Length)
					{
						obj2 = 5;
						continue;
					}
					goto case 9;
				case 24:
					obj = obj;
					obj2 = 34;
					continue;
				case 8:
					obj = obj;
					if (21 == 0)
					{
						obj2 = 2;
					}
					continue;
				default:
					obj = obj;
					if (22 == 0)
					{
						obj2 = 18;
					}
					continue;
				case 31:
					if (obj == null)
					{
						if (12 != 0)
						{
							obj2 = 24;
						}
						continue;
					}
					goto case 23;
				case 7:
					if (obj != null)
					{
						if (14 != 0)
						{
							obj2 = 17;
						}
						continue;
					}
					goto case 1;
				case 3:
					if (obj == null)
					{
						obj2 = 19;
						continue;
					}
					break;
				case 2:
					if (obj == null)
					{
						if (0 == 0)
						{
							obj2 = 1;
						}
						continue;
					}
					goto case 26;
				case 15:
					if (obj == null)
					{
						if (27 == 0)
						{
							obj2 = 27;
						}
						continue;
					}
					goto case 8;
				case 38:
					obj = obj;
					obj2 = 31;
					continue;
				case 34:
					if (obj == null)
					{
						if (13 == 0)
						{
							obj2 = 14;
						}
						continue;
					}
					goto end_IL_0019;
				case 29:
					return;
				case 36:
					obj2 = P_0;
					obj = 20;
					if (13 != 0)
					{
						obj2 = 13;
					}
					continue;
				case 20:
					_ = 30;
					continue;
				case 9:
					obj = ((object[])obj)[obj];
					if (7 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 32:
					break;
				}
				obj = obj;
				obj2 = 2;
				continue;
				end_IL_0019:
				break;
			}
			obj = 28;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static List<ConfigValue> _FF00_FF00_FF00吀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_00ba: Expected I4, but got Obj
		//IL_03b0: Expected Obj, but got I4
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_02e4: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got I4
		//IL_0369: Expected Obj, but got I4
		//IL_01d4: Expected Obj, but got I4
		//IL_020f->IL0019: Incompatible stack heights: 18 vs 1
		//IL_030a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0295->IL0019: Incompatible stack types: I4 vs Obj
		//IL_023e->IL0019: Incompatible stack heights: 13 vs 1
		//IL_016d->IL0019: Incompatible stack heights: 12 vs 1
		//IL_0275->IL0019: Incompatible stack heights: 14 vs 1
		//IL_03bc->IL0019: Incompatible stack heights: 0 vs 1
		//IL_043f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_02c2->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e0->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00cf->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02a4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_017e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0146->IL0019: Incompatible stack heights: 18 vs 1
		//IL_03f0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_034a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_047f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_046e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0249->IL0019: Incompatible stack heights: 13 vs 1
		//IL_032c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_03c7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_044a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01b5->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00eb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_037f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_042c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0286->IL0019: Incompatible stack types: I4 vs Obj
		//IL_019e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0189->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02fb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0355->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0337->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01c0->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 37;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 4:
				case 5:
				case 7:
				case 10:
				case 21:
				case 25:
				case 26:
				case 28:
				case 38:
					obj++;
					obj2 = 31;
					continue;
				case 23:
					obj = obj;
					if (1 == 0)
					{
						obj2 = 2;
					}
					continue;
				case 22:
					if (obj == null)
					{
						obj = 26;
						break;
					}
					goto case 9;
				case 34:
					_ = 4;
					continue;
				case 13:
					_ = 7;
					continue;
				case 33:
					obj = obj;
					if (6 == 0)
					{
						obj2 = 3;
					}
					continue;
				case 32:
					if (obj == null)
					{
						obj2 = 21;
						continue;
					}
					goto case 11;
				case 20:
					if (obj != null)
					{
						if (1 == 0)
						{
							obj2 = 1;
						}
						continue;
					}
					goto case 35;
				case 35:
					if (obj != null)
					{
						obj = 23;
						break;
					}
					goto case 32;
				default:
					_ = 28;
					continue;
				case 12:
					if (5 == 0)
					{
						_ = 4;
					}
					continue;
				case 3:
				case 15:
					_ = 25;
					continue;
				case 29:
					if (obj != null)
					{
						obj2 = 3;
						continue;
					}
					goto case 19;
				case 11:
					obj = obj;
					obj2 = 29;
					continue;
				case 30:
					obj = obj;
					obj2 = 27;
					continue;
				case 19:
					obj = obj;
					obj2 = 24;
					continue;
				case 36:
					obj2 = P_0;
					obj = 20;
					if (17 != 0)
					{
						obj2 = 14;
					}
					continue;
				case 1:
					obj = obj;
					obj2 = 14;
					continue;
				case 14:
					if (obj == null)
					{
						if (10 == 0)
						{
							obj2 = 1;
						}
						continue;
					}
					goto case 34;
				case 2:
					if (obj != null)
					{
						if (false)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 4;
				case 16:
				case 31:
					if ((nint)obj >= ((Array)obj).Length)
					{
						obj = 8;
						break;
					}
					goto case 18;
				case 24:
					if (obj != null)
					{
						obj2 = 12;
						continue;
					}
					goto case 4;
				case 8:
					return (List<ConfigValue>)obj;
				case 17:
					obj = 0;
					if (4 == 0)
					{
						obj2 = 16;
					}
					continue;
				case 37:
					obj = (object)/*Error near IL_03e6: Stack underflow*/;
					obj2 = 36;
					continue;
				case 27:
					if (obj != null)
					{
						obj2 = 13;
						continue;
					}
					goto case 4;
				case 18:
					obj = ((object[])obj)[obj];
					if (15 == 0)
					{
						obj2 = 33;
					}
					continue;
				case 9:
					if (obj != null)
					{
						obj2 = 30;
						continue;
					}
					goto case 20;
				case 6:
					if (obj == null)
					{
						obj2 = 38;
						continue;
					}
					goto case 22;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static List<ConfigValue> _FF00_FF00_FF00唀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778537, new IntPtr(2737337543964L), 15))(null, 0, new IntPtr(0L));
		return (List<ConfigValue>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00嘀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778536, new IntPtr(2737337551244L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00圀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1424, 1790778535, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778535, new IntPtr(2737337537724L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00堀(object P_0)
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
	internal unsafe void _FF00_FF00_FF00夀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778534, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ValueIcon _FF00_FF00_FF00娀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ValueIcon)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ValueIcon _FF00_FF00_FF00嬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778533, new IntPtr(2737337566844L), 15))(null, 0, new IntPtr(0L));
		return (ValueIcon)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00尀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00崀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778532, new IntPtr(2737337536684L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00帀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778531, new IntPtr(2737337554364L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00开()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00怀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778530, new IntPtr(2737337545004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00愀(ValueIcon P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778529, new IntPtr(2737337543964L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00戀(ValueIcon P_0)
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
	internal static void _FF00_FF00_FF00挀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_00e6: Expected I4, but got Obj
		//IL_0349: Expected Obj, but got I4
		//IL_012f: Expected Obj, but got I4
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected Obj, but got Unknown
		//IL_010a: Expected Obj, but got I4
		//IL_0454: Expected Obj, but got I4
		//IL_01c8: Expected Obj, but got I4
		//IL_01bb: Expected Obj, but got I4
		//IL_0484->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0121->IL0019: Incompatible stack heights: 0 vs 1
		//IL_03de->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02db->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0435->IL0019: Incompatible stack types: I4 vs Obj
		//IL_015b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0139->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03c2->IL0019: Incompatible stack heights: 0 vs 1
		//IL_025c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_021a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01f0->IL0019: Incompatible stack heights: 0 vs 1
		//IL_031e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02bc->IL0019: Incompatible stack types: I4 vs Obj
		//IL_035e->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0370->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0495->IL0019: Incompatible stack heights: 2 vs 1
		//IL_04c6->IL0019: Incompatible stack heights: 0 vs 1
		//IL_02f3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04f7->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01a1->IL0019: Incompatible stack heights: 0 vs 1
		//IL_039b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_014a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_012c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02e6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0240->IL0019: Incompatible stack heights: 0 vs 1
		//IL_04a6->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0166->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03cd->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0267->IL0019: Incompatible stack types: I4 vs Obj
		//IL_017b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0298->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01fb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03b0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_037b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02ad->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03ef->IL0019: Incompatible stack types: I4 vs Obj
		//IL_04d1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0502->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01ac->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01df->IL0019: Incompatible stack types: I4 vs Obj
		//IL_024b->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 22;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					return;
				case 5:
					if (obj == null)
					{
						obj = 42;
						break;
					}
					goto case 33;
				case 17:
					obj = obj;
					if (31 == 0)
					{
						obj2 = 31;
					}
					continue;
				case 28:
					obj = 0;
					obj2 = 9;
					continue;
				case 14:
					if (obj != null)
					{
						obj2 = 19;
						continue;
					}
					goto case 41;
				case 26:
					obj = obj;
					if (24 == 0)
					{
						obj2 = 46;
					}
					continue;
				case 19:
				case 32:
					if (obj != null)
					{
						obj2 = 17;
						continue;
					}
					goto case 2;
				case 3:
				case 35:
					if (obj == null)
					{
						if (4 == 0)
						{
							obj2 = 4;
						}
						continue;
					}
					goto case 34;
				case 22:
					if (P_0 != null)
					{
						obj = 21;
						break;
					}
					return;
				case 0:
					return;
				case 21:
					obj2 = P_0;
					obj = 20;
					if (28 == 0)
					{
						obj2 = 21;
					}
					continue;
				case 38:
					obj = obj;
					if (14 == 0)
					{
						obj2 = 11;
					}
					continue;
				case 34:
					obj = obj;
					obj2 = 37;
					continue;
				case 23:
					if (obj != null)
					{
						if (35 == 0)
						{
							obj2 = 47;
						}
						continue;
					}
					goto case 7;
				case 30:
					obj = obj;
					if (12 != 0)
					{
						obj2 = 5;
					}
					continue;
				case 33:
					if (obj == null)
					{
						obj2 = 2;
						continue;
					}
					goto case 10;
				case 15:
				case 45:
					if (obj != null)
					{
						obj2 = 16;
						continue;
					}
					goto case 2;
				case 41:
					obj = obj;
					obj2 = 13;
					continue;
				case 6:
				case 8:
				case 20:
				case 27:
				case 31:
				case 37:
					obj = obj;
					if (18 == 0)
					{
						obj2 = 43;
					}
					continue;
				case 2:
				case 4:
				case 36:
				case 42:
				case 49:
					obj = null;
					obj2 = 20;
					continue;
				case 39:
					obj = obj;
					obj2 = 5;
					continue;
				case 16:
					obj = obj;
					obj = 8;
					break;
				case 43:
					_ = 44;
					continue;
				case 7:
				case 44:
					obj++;
					if (27 == 0)
					{
						obj2 = 40;
					}
					continue;
				case 13:
					if (obj == null)
					{
						obj2 = 39;
						continue;
					}
					goto case 1;
				case 9:
				case 40:
					if ((nint)obj >= ((Array)obj).Length)
					{
						obj2 = 11;
						continue;
					}
					goto case 18;
				case 11:
					return;
				case 29:
					obj = obj;
					if (12 != 0)
					{
						obj2 = 23;
					}
					continue;
				case 18:
					obj = ((object[])obj)[obj];
					obj2 = 29;
					continue;
				case 46:
					if (obj != null)
					{
						obj2 = 15;
						continue;
					}
					goto case 30;
				case 25:
					obj = obj;
					obj2 = 26;
					continue;
				case 12:
					if (obj != null)
					{
						obj = 35;
						break;
					}
					goto case 38;
				case 10:
					obj = obj;
					obj2 = 27;
					continue;
				case 47:
					obj = obj;
					_ = 24;
					continue;
				case 24:
					if (obj == null)
					{
						obj2 = 7;
						continue;
					}
					goto case 25;
				case 48:
					obj = obj;
					if (6 != 0)
					{
						obj2 = 4;
					}
					continue;
				case 1:
					if (obj == null)
					{
						if (36 == 0)
						{
							obj2 = 33;
						}
						continue;
					}
					goto case 48;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00搀(Dictionary<string, object> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_007f: Expected Obj, but got Ref
		//IL_00ae: Expected Obj, but got Ref
		//IL_00ca: Expected Obj, but got Ref
		//IL_045a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0465->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03fe->IL0050: Incompatible stack heights: 1 vs 0
		//IL_0096->IL0050: Incompatible stack heights: 1 vs 0
		//IL_00ba->IL0050: Incompatible stack heights: 1 vs 0
		//IL_00fe->IL0102: Incompatible stack heights: 1 vs 0
		//IL_00c5->IL0050: Incompatible stack heights: 1 vs 0
		//IL_00e1->IL0050: Incompatible stack heights: 1 vs 0
		//IL_00a7->IL0050: Incompatible stack heights: 1 vs 0
		//IL_01e0->IL0102: Incompatible stack heights: 1 vs 0
		//IL_0201->IL0102: Incompatible stack heights: 3 vs 0
		//IL_034b->IL0102: Incompatible stack heights: 2 vs 0
		//IL_0377->IL0102: Incompatible stack heights: 2 vs 0
		//IL_01d1->IL0102: Incompatible stack heights: 3 vs 0
		//IL_0392->IL0102: Incompatible stack heights: 3 vs 0
		//IL_0269->IL0102: Incompatible stack heights: 3 vs 0
		//IL_02d2->IL0102: Incompatible stack heights: 1 vs 0
		//IL_031d->IL0102: Incompatible stack heights: 1 vs 0
		//IL_01c1->IL0102: Incompatible stack heights: 1 vs 0
		//IL_0356->IL0102: Incompatible stack heights: 2 vs 0
		//IL_0382->IL0102: Incompatible stack heights: 2 vs 0
		//IL_01f1->IL0102: Incompatible stack heights: 1 vs 0
		//IL_0212->IL0102: Incompatible stack heights: 1 vs 0
		//IL_0289->IL0102: Incompatible stack heights: 1 vs 0
		//IL_030c->IL0102: Incompatible stack heights: 1 vs 0
		//IL_0339->IL0102: Incompatible stack heights: 1 vs 0
		//IL_02a7->IL0102: Incompatible stack heights: 1 vs 0
		//IL_01a5->IL0102: Incompatible stack heights: 1 vs 0
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
				while (true)
				{
					IL_03ec:
					if (&obj == null)
					{
						_ = 2;
						goto IL_0050;
					}
					goto IL_007a;
					IL_0050:
					while (true)
					{
						switch ((int)/*Error near IL_0075: Stack underflow*/)
						{
						case 3:
							break;
						case 7:
							if (obj == null)
							{
								_ = 4;
								continue;
							}
							goto case 5;
						case 1:
							obj = (object)(&obj);
							if (7 != 0)
							{
								_ = 6;
							}
							continue;
						case 5:
							obj = (object)(&obj);
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						default:
							obj = obj;
							if (16 == 0)
							{
								_ = 13;
							}
							while (true)
							{
								switch ((int)/*Error near IL_0173: Stack underflow*/)
								{
								case 23:
									if (obj != null)
									{
										if (false)
										{
											_ = 0;
										}
										continue;
									}
									goto case 7;
								case 7:
									obj = obj;
									if (14 != 0)
									{
										_ = 0;
									}
									continue;
								case 15:
									_ = 8;
									continue;
								case 5:
									obj = obj;
									_ = 19;
									continue;
								case 14:
									if (obj == null)
									{
										_ = 24;
										continue;
									}
									goto case 17;
								default:
									_ = 12;
									continue;
								case 16:
									if (obj == null)
									{
										_ = 21;
										continue;
									}
									goto case 9;
								case 18:
								case 26:
									_ = 3;
									continue;
								case 19:
									if (obj != null)
									{
										_ = 26;
										continue;
									}
									break;
								case 11:
									if (obj != null)
									{
										if (20 == 0)
										{
											_ = 20;
										}
										continue;
									}
									goto case 5;
								case 22:
									obj = obj;
									_ = 23;
									continue;
								case 21:
									obj = obj;
									if (true)
									{
										_ = 0;
									}
									continue;
								case 1:
									if (obj == null)
									{
										_ = 22;
										continue;
									}
									goto case 15;
								case 24:
									obj = obj;
									if (5 == 0)
									{
										_ = 11;
									}
									continue;
								case 9:
									if (11 != 0)
									{
										_ = 13;
									}
									continue;
								case 10:
								case 20:
									if (2 == 0)
									{
										_ = 1;
									}
									continue;
								case 17:
									_ = 25;
									continue;
								case 2:
								case 3:
								case 4:
								case 8:
								case 12:
								case 13:
								case 25:
									break;
								}
								break;
							}
							goto IL_03ec;
						case 4:
						case 6:
							goto IL_03ec;
						case 2:
							goto end_IL_03ec;
						}
						break;
					}
					goto IL_007a;
					IL_007a:
					obj = (object)(&obj);
					if (true)
					{
						_ = 0;
					}
					goto IL_0050;
					continue;
					end_IL_03ec:
					break;
				}
				goto default;
			default:
				return this;
			case 2:
				obj = P_0;
				if (0 == 0)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00攀(Dictionary<string, object> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778528, new IntPtr(2737337564764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
