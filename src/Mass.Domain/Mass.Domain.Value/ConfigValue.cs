using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Text;
using System.Text.Json;
using Mass.Domain.Entities;
using Mass.Domain.Entities.Mass;
using Mass.Domain.Entities.Netease;
using Mass.Domain.Entities.Netease.Opt;
using Mass.Domain.ValueObjects;

namespace Mass.Domain.Value;

public abstract class ConfigValue
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<ConfigValue, List<ConfigValue>> _003C_003E9__23_0;

		public static Func<List<ConfigValue>, IEnumerable<ConfigValue>> _003C_003E9__23_1;

		public static Func<ConfigValue, List<ConfigValue>> _003C_003E9__23_2;

		public static Func<List<ConfigValue>, IEnumerable<ConfigValue>> _003C_003E9__23_3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe _003C_003Ec()
		{
			if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
			{
			}
			_ = ((KeyValuePair<string, object>*)this)->Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal List<ConfigValue> _003CGetValues_003Eb__23_0(ConfigValue c)
		{
			//IL_001a: Expected I4, but got Obj
			if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
			{
			}
			((BoolValue)/*Error near IL_001a: Stack underflow*/).Value = (byte)(int)c != 0;
			return (List<ConfigValue>)/*Error near IL_001b: Stack underflow*/;
		}

		internal IEnumerable<ConfigValue> _003CGetValues_003Eb__23_1(List<ConfigValue> c)
		{
			return c;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal List<ConfigValue> _003CGetValues_003Eb__23_2(ConfigValue c)
		{
			//IL_001a: Expected I4, but got Obj
			if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
			{
			}
			((BoolValue)/*Error near IL_001a: Stack underflow*/).Value = (byte)(int)c != 0;
			return (List<ConfigValue>)/*Error near IL_001b: Stack underflow*/;
		}

		internal IEnumerable<ConfigValue> _003CGetValues_003Eb__23_3(List<ConfigValue> c)
		{
			return c;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public string id;

		internal static _003C_003Ec__DisplayClass21_0 RestartOrder;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe _003C_003Ec__DisplayClass21_0()
		{
			if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
			{
			}
			_ = ((KeyValuePair<string, object>*)this)->Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CSetId_003Eb__0(ConfigValue v)
		{
			_FF00_FF00_FF00㬀(v);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ReflectScalableFinder()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static _003C_003Ec__DisplayClass21_0 DecorateModularUser()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00㨀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778527, new IntPtr(2737337552284L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _FF00_FF00_FF00㬀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
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
					((BoolValue)BoolValueAttribute.DecorateIdentifiableAggregator)._002Ector();
					_ = 0;
					if (((ConfigValue)ConfigValue.Key__BackingField).Icon__BackingField == ValueIcon.AccessTime)
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
		internal unsafe void _FF00_FF00_FF00㰀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778526, new IntPtr(2737337536684L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00㴀()
		{
			if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
			{
			}
			return BoolValueAttribute.DecorateIdentifiableAggregator;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00㸀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778525, new IntPtr(2737337547084L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00㼀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778524, new IntPtr(2737337543964L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00䀀()
		{
			if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
			{
			}
			return (BoolValueAttribute.DecorateIdentifiableAggregator == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00䄀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778523, new IntPtr(2737337546044L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public string key;

		internal static _003C_003Ec__DisplayClass22_0 DetachRole;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe _003C_003Ec__DisplayClass22_0()
		{
			if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
			{
			}
			_ = ((KeyValuePair<string, object>*)this)->Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetValue_003Eb__0(ConfigValue i)
		{
			return _FF00_FF00_FF00㔀(i) != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GetCollection()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static _003C_003Ec__DisplayClass22_0 DecorateIsolatedTransformer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe byte _FF00_FF00_FF00㐀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778522, new IntPtr(2737337550204L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal byte _FF00_FF00_FF00㔀(object P_0)
		{
			//IL_001a: Expected I4, but got Obj
			if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
			{
			}
			((BoolValue)/*Error near IL_001a: Stack underflow*/).Value = (byte)(int)P_0 != 0;
			((IDisposable)Id__BackingField).Dispose();
			return (byte)/*Error near IL_0026: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe byte _FF00_FF00_FF00㘀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778521, new IntPtr(2737337566844L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00㜀()
		{
			if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
			{
			}
			return BoolValueAttribute.DecorateIdentifiableAggregator;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00㠀()
		{
			if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
			{
			}
			return (BoolValueAttribute.DecorateIdentifiableAggregator == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00㤀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778520, new IntPtr(2737337541884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[CompilerGenerated]
	private object Id__BackingField;

	[CompilerGenerated]
	private object Key__BackingField;

	[CompilerGenerated]
	private ValueIcon Icon__BackingField;

	[CompilerGenerated]
	private object DisplayName__BackingField;

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
		//IL_001a: Expected I4, but got Obj
		//IL_002b: Expected I4, but got Obj
		//IL_0036: Expected I, but got Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		((BoolValue)/*Error near IL_001a: Stack underflow*/).Value = (byte)(int)this != 0;
		((ConfigValue)/*Error near IL_001f: Stack underflow*/).Id__BackingField = (object)/*Error near IL_001f: Stack underflow*/;
		((ConfigValue)/*Error near IL_002b: Stack underflow*/).Icon__BackingField = (ValueIcon)this;
		((Action<ConfigValue>)/*Error near IL_0036: Stack underflow*/)._002Ector((object)/*Error near IL_0036: Stack underflow*/, (nint)this);
		int num = 0;
		if (ReflectInternalTransmitter != null)
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
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return BoolValueAttribute.DecorateIdentifiableAggregator;
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
	internal unsafe void _FF00_FF00_FF00䜀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778543, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00䠀()
	{
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return BoolValueAttribute.DecorateIdentifiableAggregator;
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
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return (BoolValueAttribute.DecorateIdentifiableAggregator == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00䰀()
	{
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return BoolValueAttribute.DecorateIdentifiableAggregator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00䴀(object P_0)
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
	internal List<ConfigValue> _FF00_FF00_FF00一()
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.ArgumentNullException: Value cannot be null. (Parameter 'source')
		//    at System.Linq.ThrowHelper.ThrowArgumentNullException(ExceptionArgument argument)
		//    at System.Linq.Enumerable.Skip[TSource](IEnumerable`1 source, Int32 count)
		//    at ICSharpCode.Decompiler.CSharp.ArgumentList.GetArgumentResolveResultsDirect(Int32 skipCount) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 124
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Probe() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 493
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Run() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 438
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.ForMethodReference(ExpressionBuilder expressionBuilder, IMethod method, IType targetType, TranslatedExpression target, Boolean requireTarget, ExpectedTargetDetails expectedTargetDetails, Boolean isExtensionMethodReference, Boolean castTargetUpFront) in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 131
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.DisambiguateDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1718
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1648
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildMethodReference(IMethod method, Boolean isVirtual) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1639
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitLdFtn(LdFtn inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 5058
		//    at ICSharpCode.Decompiler.IL.LdFtn.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 3175
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitConv(Conv inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2307
		//    at ICSharpCode.Decompiler.IL.Conv.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2298
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildArgumentList(ExpectedTargetDetails expectedTargetDetails, ResolveResult target, IMethod method, Int32 firstParamIndex, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, Boolean writtenAsAssignment) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1070
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(OpCode callOpCode, IMethod method, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, IType constrainedTo) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 461
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(CallInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 255
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitNewObj(NewObj inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 538
		//    at ICSharpCode.Decompiler.IL.NewObj.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4578
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitStObj(StObj inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 3219
		//    at ICSharpCode.Decompiler.IL.StObj.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4386
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitStObj(StObj inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 140
		//    at ICSharpCode.Decompiler.IL.StObj.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4382
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
		//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitIfInstruction(IfInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 162
		//    at ICSharpCode.Decompiler.IL.IfInstruction.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 1440
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
		//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertSwitchSectionBody(SwitchSection astSection, ILInstruction bodyInst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 334
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.TranslateSwitch(BlockContainer switchContainer, SwitchInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 280
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1334
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertLoop(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1354
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1325
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1338
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertAsBlock(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 87
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2435
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
				if (((ConfigValue)ConfigValue.Id__BackingField).Key__BackingField != null)
				{
					obj2 = 0;
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
	internal unsafe static void _FF00_FF00_FF00匀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_00c7: Expected I4, but got Obj
		//IL_0313: Expected Obj, but got I
		//IL_01e3: Expected Obj, but got VT
		//IL_01e8: Expected Obj, but got I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_0139: Expected Obj, but got I4
		//IL_0423: Expected Ref, but got VT
		//IL_0428: Expected Obj, but got I4
		//IL_0195: Expected I, but got Obj
		//IL_019e: Expected Obj, but got I4
		//IL_01ad: Expected I4, but got Obj
		//IL_0122: Expected I, but got VT
		//IL_0152: Expected VT, but got I4
		//IL_0273: Expected Obj, but got I4
		//IL_0381: Expected Obj, but got I
		//IL_0497: Expected I4, but got Obj
		//IL_049e: Expected Obj, but got I4
		//IL_0230: Expected Obj, but got I
		//IL_0318->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02f4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_051c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0143->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04dd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01bc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02cc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_016b->IL0026: Incompatible stack heights: 3 vs 1
		//IL_055a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_028c->IL0026: Incompatible stack heights: 3 vs 1
		//IL_045b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0323->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03f8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02bd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03ad->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02ff->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0527->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0201->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0441->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01d2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0111->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02a8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0136->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0176->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0386->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0297->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0476->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04b4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0235->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0403->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03b8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_020c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_044c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0391->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0481->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04bf->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0240->IL0026: Incompatible stack types: I4 vs Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
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
					obj2 = 1;
					if (((ConfigValue)BoolValueAttribute.DecorateIdentifiableAggregator).Id__BackingField == null)
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
					((IDisposable)obj).Dispose();
					((Action<ConfigValue>)/*Error near IL_0122: Stack underflow*/)._002Ector((object)/*Error near IL_0122: Stack underflow*/, (nint)typeof(int).TypeHandle);
					((List<ConfigValue>)/*Error near IL_0127: Stack underflow*/).ForEach((Action<ConfigValue>)/*Error near IL_0127: Stack underflow*/);
					if ((int)/*Error near IL_012c: Stack underflow*/ != 0)
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
					((List<ConfigValue>)obj).Add((ConfigValue)(object)(KeyValuePair<, >)BoolValueAttribute.ReflectInterruptibleTag());
					_ = 35;
					if (_003C_003Ec._003C_003E9__23_2 == null)
					{
						_ = 5;
					}
					continue;
				case 5:
					return;
				case 16:
					break;
				case 23:
				{
					object collection = obj;
					((ConfigValue)P_0)._FF00_FF00_FF00戀((ValueIcon)obj);
					((List<ConfigValue>)/*Error near IL_01b2: Stack underflow*/).AddRange((IEnumerable<ConfigValue>)collection);
					obj2 = 12;
					continue;
				}
				case 17:
					if (CustomAttributeExtensions.GetCustomAttribute<T>((MemberInfo)obj) != null)
					{
						obj2 = 15;
						continue;
					}
					goto case 1;
				case 11:
				case 27:
					if (Enumerable.ToList<TSource>((IEnumerable<TSource>)(((PropertyInfo)obj).PropertyType == (Type?)typeof(Type).TypeHandle)) != null)
					{
						obj2 = 0;
						if (((ExpanderValue)(object)ConfigValueAttribute.ReflectAdjustableDistributor).Item__BackingField != null)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 3;
				case 37:
					if (P_0 != null)
					{
						obj2 = 36;
						if (((ExpanderValue)ExpanderValue.IsExpanded__BackingField).Items__BackingField != null)
						{
							obj2 = 35;
						}
						continue;
					}
					return;
				case 33:
					((DefaultInterpolatedStringHandler*)obj)->AppendLiteral((string)ReflectExpandableRecommender());
					_ = 6;
					if ((int)((FloatValueAttribute)(object)FloatValue.CheckMixedHandler).MinValue__BackingField == 0)
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
					obj2 = 21;
					if (FloatValueAttribute.DecorateCommonChain == null)
					{
						obj2 = 2;
					}
					continue;
				default:
					obj = obj;
					obj2 = 22;
					if (((IntegerValue)IntegerValue.Value__BackingField).Min__BackingField == 0)
					{
						obj2 = 18;
					}
					continue;
				case 31:
					if (obj == null)
					{
						obj2 = 12;
						if (((IntegerValueAttribute)IntegerValueAttribute.DefaultValue__BackingField).Unit__BackingField != null)
						{
							obj2 = 24;
						}
						continue;
					}
					goto case 23;
				case 7:
					if (obj != null)
					{
						obj2 = 14;
						if (((ListValue)ListValue.Options__BackingField).Value__BackingField != null)
						{
							obj2 = 17;
						}
						continue;
					}
					goto case 1;
				case 3:
					/*Error near IL_03ba: Member reference must be method, but was: Field*/;
				case 2:
					if (obj == null)
					{
						obj2 = 0;
						if (SectionValue.ReflectIterableTransformer == null)
						{
							obj2 = 1;
						}
						continue;
					}
					goto case 26;
				case 15:
					((List<EntityMassReferralCustomer>)obj)._002Ector();
					((JsonException)/*Error near IL_0428: Stack underflow*/)._002Ector((string?)((Utf8JsonReader*)typeof(CompilerGeneratedAttribute).TypeHandle)->TokenType);
					if ((int)/*Error near IL_042d: Stack underflow*/ == 0)
					{
						obj2 = 27;
						if (TextValueAttribute.AssetController == null)
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
						obj2 = 13;
						if (ValueIcon.Accessibility == ValueIcon.AccessTime)
						{
							obj2 = 14;
						}
						continue;
					}
					break;
				case 29:
					return;
				case 36:
					((CompilationRelaxationsAttribute)/*Error near IL_0497: Stack underflow*/)._002Ector((int)P_0);
					((RuntimeCompatibilityAttribute)20)._002Ector();
					obj = (object)/*Error near IL_04a0: Stack underflow*/;
					obj2 = 13;
					if (ValueIcon.AlertOff != ValueIcon.AccessTime)
					{
						obj2 = 13;
					}
					continue;
				case 20:
				{
					object obj3 = obj;
					((FloatValue)obj)._002Ector();
					((AssemblyFileVersionAttribute)obj3)._002Ector((string)P_0);
					obj2 = 30;
					continue;
				}
				case 9:
					obj = ((object[])obj)[obj];
					obj2 = 7;
					if (ValueIcon.Apps == ValueIcon.AccessTime)
					{
						obj2 = 0;
					}
					continue;
				case 32:
					obj = obj;
					obj2 = 2;
					continue;
				}
				break;
			}
			object obj4 = obj;
			((ConfigValue)P_0)._FF00_FF00_FF00䴀(obj);
			((Func<List<ConfigValue>, IEnumerable<ConfigValue>>)/*Error near IL_0195: Stack underflow*/)._002Ector((object)/*Error near IL_0195: Stack underflow*/, (nint)obj4);
			obj = 28;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static List<ConfigValue> _FF00_FF00_FF00吀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_00c7: Expected I4, but got Obj
		//IL_02bd: Expected I4, but got Obj
		//IL_0322: Expected Obj, but got I4
		//IL_0340: Expected Obj, but got F4
		//IL_034d: Expected Obj, but got F4
		//IL_0375: Expected Obj, but got I4
		//IL_037d: Expected I4, but got Obj
		//IL_037d: Expected Obj, but got I4
		//IL_0382: Expected Obj, but got I4
		//IL_0387: Expected Obj, but got I4
		//IL_03b5: Expected I4, but got Obj
		//IL_03b5: Expected I4, but got Obj
		//IL_03b5: Expected I4, but got Obj
		//IL_03c7: Expected Obj, but got I4
		//IL_0571: Expected Obj, but got I4
		//IL_0252: Expected I4, but got Obj
		//IL_025c: Expected Obj, but got VT
		//IL_025c: Expected Obj, but got I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_0237: Expected I4, but got VT
		//IL_0237: Expected Obj, but got I4
		//IL_0134: Expected I4, but got Obj
		//IL_0170: Expected I4, but got Obj
		//IL_0170: Expected Obj, but got I4
		//IL_0175: Expected Obj, but got I4
		//IL_01a1: Expected Obj, but got I4
		//IL_01a1: Expected Obj, but got I4
		//IL_0483: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I4
		//IL_0522: Expected Obj, but got I4
		//IL_032c->IL0026: Incompatible stack heights: 6 vs 1
		//IL_04b3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_042a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_039b->IL0026: Incompatible stack heights: 10 vs 1
		//IL_0202->IL0026: Incompatible stack heights: 6 vs 1
		//IL_040a->IL0026: Incompatible stack heights: 9 vs 1
		//IL_0585->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0620->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0457->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00dc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0439->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0241->IL041b: Incompatible stack heights: 1 vs 0
		//IL_021b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01ab->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0499->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05c1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0503->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0660->IL0026: Incompatible stack types: I4 vs Obj
		//IL_064f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03a6->IL0026: Incompatible stack heights: 10 vs 1
		//IL_04dd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0590->IL0026: Incompatible stack types: I4 vs Obj
		//IL_062b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_027a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0104->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0538->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0605->IL0026: Incompatible stack types: I4 vs Obj
		//IL_041b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_024b->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0226->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04a4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_050e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04e8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0285->IL0026: Incompatible stack types: I4 vs Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
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
					obj = ((MemberInfo)obj).GetCustomAttribute<IntegerValueAttribute>();
					obj2 = 1;
					if (((ConfigValue)ConfigValue.Id__BackingField).Key__BackingField == null)
					{
						obj2 = 2;
					}
					continue;
				case 22:
					if ((int)((Dictionary<string, object>)obj).GetEnumerator() == 0)
					{
						obj = 26;
						break;
					}
					goto case 9;
				case 34:
				{
					new BoolValueAttribute((byte)(int)obj != 0);
					_ = ((BoolValueAttribute)obj).DefaultValue;
					bool flag = BoolValueAttribute.ReflectInterruptibleTag();
					bool flag2 = flag;
					object obj3 = obj;
					object text = ((ConfigValue)(object)BoolValueAttribute.DecorateCustomizableDefinition())._FF00_FF00_FF00䌀();
					((ConfigValue)text)._FF00_FF00_FF00堀(obj);
					object text2 = ((ConfigValue)text)._FF00_FF00_FF00䠀();
					((ConfigValue)text2)._FF00_FF00_FF00䴀(obj);
					ValueIcon valueIcon = ((ConfigValue)text2)._FF00_FF00_FF00娀();
					((ConfigValue)valueIcon)._FF00_FF00_FF00戀((ValueIcon)obj);
					object text3 = ((ConfigValue)valueIcon)._FF00_FF00_FF00䰀();
					((ConfigValue)text3)._FF00_FF00_FF00䘀(obj);
					object text4 = ((ConfigValue)text3)._FF00_FF00_FF00开();
					((ConfigValue)text4)._FF00_FF00_FF00倀(obj);
					ConfigValue configValue3 = ((ConfigValue)obj3).Load((Dictionary<string, object>)text4);
					((PropertyInfo)flag).SetValue(flag2, configValue3.GetValue((string)(object)configValue3.SetId((string)obj)));
					_ = 4;
					continue;
				}
				case 13:
				{
					List<ConfigValue> configValue = new ConfigValue((Type)obj);
					InitValue(obj);
					SetValue(configValue, (SectionValue)(object)configValue);
					/*Error near IL_01bf: Stack underflow*/;
					((ConfigValue)obj)._002Ector();
					ReflectExpandableRecommender();
					ConfigValue configValue2 = CheckHiddenAnalyzer();
					_003C_003Ec._002Ecctor();
					((_003C_003Ec)obj)._002Ector();
					List<ConfigValue> list = ((_003C_003Ec)(object)configValue2)._003CGetValues_003Eb__23_0(configValue2);
					((_003C_003Ec)(object)list)._003CGetValues_003Eb__23_2((ConfigValue)((_003C_003Ec)(object)list)._003CGetValues_003Eb__23_1((List<ConfigValue>)obj)).ToString();
					_ = 7;
					continue;
				}
				case 33:
					obj = obj;
					obj2 = 6;
					if (((IntegerValue)IntegerValue.Unit__BackingField).Value__BackingField == 0)
					{
						obj2 = 3;
					}
					continue;
				case 32:
					((EqualityComparer<EnumStepPhase>)((EqualityComparer<Type>)/*Error near IL_022d: Stack underflow*/).GetHashCode((Type)obj)).GetHashCode((EnumStepPhase)typeof(JsonTokenType).TypeHandle);
					if (EqualityComparer<int>.Default == null)
					{
						_ = 21;
						continue;
					}
					goto case 11;
				case 20:
					if (((EqualityComparer<int>)/*Error near IL_0261: Stack underflow*/).Equals((int)/*Error near IL_0261: Stack underflow*/, ((EqualityComparer<string>)((EqualityComparer<int>)/*Error near IL_0252: Stack underflow*/).GetHashCode((int)obj)).GetHashCode((string)typeof(CompilationRelaxationsAttribute).TypeHandle)))
					{
						obj2 = 1;
						if (((ListValue)ListValue.Options__BackingField).Value__BackingField == null)
						{
							obj2 = 1;
						}
						continue;
					}
					goto case 35;
				case 35:
					/*Error near IL_0287: Member reference must be method, but was: Field*/;
				default:
				{
					List<ConfigValue> items = ((ExpanderValue)new ExpanderValue
					{
						IsExpanded = ((byte)(int)obj != 0)
					}).Items;
					((ExpanderValue)(object)items).Items = (List<ConfigValue>)obj;
					((ExpanderValue)(object)items)._002Ector();
					ExpanderValue.CheckAdvancedParser();
					ExpanderValue expanderValue = ExpanderValue.DecorateConvertibleState();
					((FloatValue)(object)expanderValue).Unit = ((FloatValue)obj).Unit;
					((FloatValue)(object)expanderValue).Value = ((FloatValue)obj).Value;
					((FloatValue)(object)expanderValue).Min = ((FloatValue)obj).Min;
					((FloatValue)(object)expanderValue).Max = ((FloatValue)obj).Max;
					((FloatValue)obj)._002Ector();
					((AssemblyFileVersionAttribute)(object)expanderValue)._002Ector((string)FloatValue.AssessDefinition());
					_ = 28;
					continue;
				}
				case 12:
				{
					new FloatValueAttribute((float)/*Error near IL_0333: Stack underflow*/, (float)/*Error near IL_0333: Stack underflow*/, (float)/*Error near IL_0333: Stack underflow*/, (string?)obj);
					_ = ((FloatValueAttribute)((FloatValueAttribute)obj).MinValue).MaxValue;
					_ = ((FloatValueAttribute)((FloatValueAttribute)obj).DefaultValue).Unit;
					FloatValueAttribute.ReflectAdaptableEnumerator();
					FloatValueAttribute? floatValueAttribute = FloatValueAttribute.ReflectPortableParameter();
					((IntegerValue)(object)floatValueAttribute).Unit = ((IntegerValue)obj).Unit;
					int min = ((IntegerValue)((IntegerValue)obj).Value).Min;
					((IntegerValue)min).Min = (int)obj;
					((NullableAttribute)(object)floatValueAttribute)._002Ector((byte[])((IntegerValue)min).Max);
					_ = 5;
					if (ValueIcon.Badge == ValueIcon.AccessTime)
					{
						_ = 4;
					}
					continue;
				}
				case 3:
				case 15:
				{
					object obj4 = obj;
					IntegerValue? integerValue = new IntegerValue();
					((IntegerValueAttribute)/*Error near IL_03b5: Stack underflow*/)._002Ector((int)obj4, (int)integerValue, (int)integerValue, (string?)obj);
					_ = ((IntegerValueAttribute)/*Error near IL_03ba: Stack underflow*/).MinValue;
					_ = ((IntegerValueAttribute)((IntegerValueAttribute)obj).MaxValue).DefaultValue;
					_ = ((IntegerValueAttribute)obj).Unit;
					IntegerValueAttribute.CheckJoinedResponder();
					object obj5 = obj;
					IList<string> options = ((ListValue)(object)IntegerValueAttribute.CheckLiteralStream()).Options;
					((ListValue)options).Options = (IList<string>)obj;
					string value = ((ListValue)options).Value;
					((ListValue)(object)value).Value = (string)obj;
					((ListValue)(object)value)._002Ector();
					((AssemblyName)obj5).GetPublicKeyToken();
					_ = 25;
					continue;
				}
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
					obj = ((Hashtable)P_0)[(object)20];
					obj2 = 17;
					if (ValueIcon.BroadActivityFeed != ValueIcon.AccessTime)
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
						obj2 = 10;
						if (ValueIcon.Calendar3Day == ValueIcon.AccessTime)
						{
							obj2 = 1;
						}
						continue;
					}
					goto case 34;
				case 2:
					if (obj != null)
					{
						obj2 = 0;
						if (ValueIcon.CalendarAgenda != ValueIcon.AccessTime)
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
					obj2 = 4;
					if (ValueIcon.CalendarEmpty == ValueIcon.AccessTime)
					{
						obj2 = 16;
					}
					continue;
				case 37:
					obj = (object)/*Error near IL_05b7: Stack underflow*/;
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
					obj2 = 15;
					if (ValueIcon.CallMissed == ValueIcon.AccessTime)
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
	internal unsafe void _FF00_FF00_FF00夀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778534, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ValueIcon _FF00_FF00_FF00娀()
	{
		//IL_001b: Expected I4, but got Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return (ValueIcon)BoolValueAttribute.DecorateIdentifiableAggregator;
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
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return BoolValueAttribute.DecorateIdentifiableAggregator;
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
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
		{
		}
		return BoolValueAttribute.DecorateIdentifiableAggregator;
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
	internal static void _FF00_FF00_FF00挀(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_00f3: Expected I4, but got Obj
		//IL_060e: Expected Obj, but got VT
		//IL_01d4: Expected Obj, but got VT
		//IL_0581: Expected F4, but got Obj
		//IL_0422: Expected Obj, but got I4
		//IL_0123: Expected I4, but got Obj
		//IL_0393: Expected Obj, but got I
		//IL_014c: Expected Obj, but got I4
		//IL_01a0: Expected Obj, but got VT
		//IL_01a5: Expected I, but got VT
		//IL_0325: Expected Obj, but got VT
		//IL_0258: Expected Obj, but got I
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected Obj, but got Unknown
		//IL_034a: Expected I4, but got VT
		//IL_034a: Expected Obj, but got I4
		//IL_0117: Expected Obj, but got I4
		//IL_0551: Expected Obj, but got I4
		//IL_0218: Expected VT, but got Obj
		//IL_021f: Expected Obj, but got I4
		//IL_0221: Expected Obj, but got I4
		//IL_020c: Expected Obj, but got I4
		//IL_02b8: Expected Obj, but got F4
		//IL_058d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_013e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04cb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0398->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0532->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0184->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0156->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04af->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02e5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_032f->IL057a: Incompatible stack heights: 1 vs 0
		//IL_028f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_025d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03e7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0371->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0455->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0354->IL03a3: Incompatible stack heights: 1 vs 0
		//IL_05a6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05e3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03b0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_062c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01f2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0480->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0167->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0149->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03a3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0235->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02bd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05b7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_018f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04ba->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02f0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01b4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0339->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0268->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0495->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0460->IL0026: Incompatible stack types: I4 vs Obj
		//IL_035e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_04dc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05ee->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0637->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01fd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0240->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02c8->IL0026: Incompatible stack types: I4 vs Obj
		if (((KeyValuePair<string, object>)Unsafe.As<nint, object>(ref BoolValue.Value__BackingField)).Key == null)
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
					((BoolValue)/*Error near IL_0123: Stack underflow*/).Value = (byte)(int)obj != 0;
					obj = (object)/*Error near IL_0128: Stack underflow*/;
					obj2 = 31;
					if (((ConfigValue)ConfigValue.Key__BackingField).Icon__BackingField == ValueIcon.AccessTime)
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
					obj = obj as ConfigValueAttribute;
					obj2 = 24;
					if (ReflectInternalTransmitter == null)
					{
						obj2 = 46;
					}
					continue;
				case 19:
				case 32:
				{
					TSource? val = Enumerable.FirstOrDefault<TSource>((IEnumerable<TSource>)/*Error near IL_0196: Stack underflow*/, (Func<TSource, bool>)obj);
					((List<ConfigValue>)typeof(float).TypeHandle)._002Ector();
					((Func<ConfigValue, List<ConfigValue>>)/*Error near IL_01a5: Stack underflow*/)._002Ector((object)/*Error near IL_01a5: Stack underflow*/, (nint)val);
					if ((int)/*Error near IL_01aa: Stack underflow*/ != 0)
					{
						obj2 = 17;
						continue;
					}
					goto case 2;
				}
				case 3:
				case 35:
					((List<ConfigValue>)/*Error near IL_01d9: Stack underflow*/).AddRange((IEnumerable<ConfigValue>)Enumerable.SelectMany<TSource, TResult>((IEnumerable<TSource>)Enumerable.Select<TSource, TResult>((IEnumerable<TSource>)/*Error near IL_01ca: Stack underflow*/, (Func<TSource, TResult>)obj), (Func<TSource, IEnumerable<TResult>>)typeof(nint).TypeHandle));
					if ((int)/*Error near IL_01de: Stack underflow*/ == 0)
					{
						obj2 = 4;
						if (((ConfigValueAttribute)(object)_003C_003Ec__DisplayClass22_0.DetachRole).Icon__BackingField == ValueIcon.AccessTime)
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
					obj = Type.GetTypeFromHandle((RuntimeTypeHandle)P_0) == (Type?)20;
					obj2 = 28;
					if (ConfigValueAttribute.ReflectAdjustableDistributor == null)
					{
						obj2 = 21;
					}
					continue;
				case 38:
					obj = obj as EntityProgress;
					obj2 = 14;
					if (((ExpanderValue)ExpanderValue.IsExpanded__BackingField).Items__BackingField == null)
					{
						obj2 = 11;
					}
					continue;
				case 34:
					SetValue((object?)/*Error near IL_027e: Stack underflow*/, (SectionValue)obj);
					obj = (object)(DefaultInterpolatedStringHandler)/*Error near IL_0283: Stack underflow*/;
					obj2 = 37;
					continue;
				case 23:
					if (obj != null)
					{
						obj2 = 35;
						if ((int)((FloatValue)FloatValue.Value__BackingField).Min__BackingField == 0)
						{
							obj2 = 47;
						}
						continue;
					}
					goto case 7;
				case 30:
					obj = obj as EntityOptInitBox;
					obj2 = 12;
					if ((int)((FloatValueAttribute)(object)FloatValue.CheckMixedHandler).MinValue__BackingField != 0)
					{
						obj2 = 5;
					}
					continue;
				case 33:
					((StringBuilder)(object)obj.ToString()).Append((object?)typeof(Nullable<>).TypeHandle);
					if (EqualityComparer<Type>.Default == null)
					{
						_ = 2;
						continue;
					}
					goto case 10;
				case 15:
				case 45:
					((EqualityComparer<EnumStepPhase>)((EqualityComparer<Type>)/*Error near IL_0340: Stack underflow*/).GetHashCode((Type)obj)).GetHashCode((EnumStepPhase)typeof(JsonTokenType).TypeHandle);
					if (EqualityComparer<int>.Default != null)
					{
						_ = 16;
						continue;
					}
					goto case 2;
				case 41:
					obj = obj as EntityMassOrder;
					obj2 = 13;
					continue;
				case 6:
				case 8:
				case 20:
				case 27:
				case 31:
				case 37:
					obj = obj;
					obj2 = 18;
					if (((IntegerValueAttribute)IntegerValueAttribute.DefaultValue__BackingField).Unit__BackingField == null)
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
					obj = obj as EntityMassReferralInfo;
					obj2 = 5;
					continue;
				case 16:
					obj = ((ExpanderValue)obj).Item;
					obj = 8;
					break;
				case 43:
					/*Error near IL_042c: Member reference must be method, but was: Field*/;
				case 7:
				case 44:
					obj++;
					obj2 = 27;
					if (((TextValue)SectionValue.ReflectIterableTransformer).Value__BackingField == null)
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
					obj2 = 12;
					if (((TextValueAttribute)TextValue.CloneResponder).Placeholder__BackingField != null)
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
					((FloatValue)/*Error near IL_0581: Stack underflow*/).Min = (float)obj;
					obj = (object)/*Error near IL_0583: Stack underflow*/;
					obj2 = 27;
					continue;
				case 47:
					((FloatValue)P_1).Max = ((FloatValue)obj).Max;
					obj = (object)/*Error near IL_059c: Stack underflow*/;
					obj2 = 24;
					continue;
				case 24:
					if (obj == null)
					{
						obj2 = 7;
						continue;
					}
					goto case 25;
				case 48:
					((FloatValue)obj)._002Ector();
					obj = (object)/*Error near IL_05cf: Stack underflow*/;
					obj2 = 6;
					if (ValueIcon.AlertUrgent != ValueIcon.AccessTime)
					{
						obj2 = 4;
					}
					continue;
				case 1:
					((AssemblyInformationalVersionAttribute)/*Error near IL_0604: Stack underflow*/)._002Ector((string)obj);
					((AssemblyTitleAttribute)/*Error near IL_060e: Stack underflow*/)._002Ector((string)typeof(MethodBase).TypeHandle);
					((RefSafetyRulesAttribute)/*Error near IL_0613: Stack underflow*/)._002Ector((int)/*Error near IL_0613: Stack underflow*/);
					if ((int)/*Error near IL_0618: Stack underflow*/ == 0)
					{
						obj2 = 36;
						if (ValueIcon.AppsList == ValueIcon.AccessTime)
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
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_04e0: Expected Obj, but got Ref
		//IL_0096: Expected Obj, but got Ref
		//IL_00a7: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got Ref
		//IL_00d7: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got Ref
		//IL_03a5: Expected Obj, but got I
		//IL_03de: Expected Obj, but got I
		//IL_0328: Expected Obj, but got F4
		//IL_056b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0576->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0410->IL014b: Incompatible stack heights: 3 vs 1
		//IL_044c->IL014b: Incompatible stack heights: 4 vs 1
		//IL_0236->IL014b: Incompatible stack heights: 3 vs 1
		//IL_046f->IL014b: Incompatible stack heights: 3 vs 1
		//IL_02f2->IL014b: Incompatible stack heights: 2 vs 1
		//IL_041b->IL014b: Incompatible stack heights: 3 vs 1
		//IL_0457->IL014b: Incompatible stack heights: 4 vs 1
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
				while (true)
				{
					IL_04d9:
					((JsonException)/*Error near IL_04e0: Stack underflow*/)._002Ector((string?)(&obj));
					int num;
					if ((int)/*Error near IL_04e5: Stack underflow*/ == 0)
					{
						num = 2;
						goto IL_0065;
					}
					goto IL_008f;
					IL_0065:
					while (true)
					{
						switch (num)
						{
						case 3:
							break;
						case 7:
							if (obj == null)
							{
								num = 4;
								continue;
							}
							goto case 5;
						case 1:
							((List<ConfigValue>)this).ForEach((Action<ConfigValue>)(&obj));
							obj = BoolValueAttribute.ReflectInterruptibleTag();
							num = 7;
							if (_003C_003Ec._003C_003E9__23_0 != null)
							{
								num = 6;
							}
							continue;
						case 5:
							((List<ConfigValue>)(&obj))._002Ector();
							obj = (object)/*Error near IL_00ff: Stack underflow*/;
							num = 0;
							if (_003C_003Ec._003C_003E9__23_3 == null)
							{
								num = 0;
							}
							continue;
						default:
						{
							obj = obj as SectionValue;
							int num2 = 16;
							if (((_003C_003Ec__DisplayClass22_0)(object)_003C_003Ec__DisplayClass21_0.RestartOrder).key == null)
							{
								num2 = 13;
							}
							while (true)
							{
								switch (num2)
								{
								case 23:
									if (obj != null)
									{
										num2 = 0;
										if (((ConfigValueAttribute)(object)_003C_003Ec__DisplayClass22_0.DetachRole).Icon__BackingField != ValueIcon.AccessTime)
										{
											num2 = 0;
										}
										continue;
									}
									goto case 7;
								case 7:
									obj = ((obj is EnumMassGrowlSeverity) ? obj : null);
									num2 = 14;
									if (((ConfigValueAttribute)ConfigValueAttribute.DisplayName__BackingField).Description__BackingField != null)
									{
										num2 = 0;
									}
									continue;
								case 15:
									((ConfigValue)(object)(MemberInfo)obj).GetValues();
									_ = 8;
									continue;
								case 5:
									obj = obj as Entities<>;
									num2 = 19;
									continue;
								case 14:
									if (obj == null)
									{
										num2 = 24;
										continue;
									}
									goto case 17;
								default:
									SetValue(obj, (SectionValue)(IList<>)obj);
									num2 = 12;
									continue;
								case 16:
									if (obj == null)
									{
										num2 = 21;
										continue;
									}
									goto case 9;
								case 18:
								case 26:
									((_003C_003Ec)obj)._003CGetValues_003Eb__23_0((ConfigValue)(IEquatable<>)obj);
									_ = 3;
									continue;
								case 19:
									if (obj != null)
									{
										num2 = 26;
										continue;
									}
									break;
								case 11:
									if (obj != null)
									{
										num2 = 20;
										if ((int)((FloatValueAttribute)FloatValueAttribute.MaxValue__BackingField).DefaultValue__BackingField == 0)
										{
											num2 = 20;
										}
										continue;
									}
									goto case 5;
								case 22:
									obj = obj as EntityMassGrowl;
									num2 = 23;
									continue;
								case 21:
									obj = obj as EntityMassHistoryOrder;
									num2 = 1;
									if (((IntegerValue)IntegerValue.Min__BackingField).Max__BackingField != 0)
									{
										num2 = 0;
									}
									continue;
								case 1:
									if (obj == null)
									{
										num2 = 22;
										continue;
									}
									goto case 15;
								case 24:
									obj = obj as EntityMassIrcToken;
									num2 = 5;
									if (((IntegerValueAttribute)IntegerValueAttribute.MinValue__BackingField).MaxValue__BackingField == 0)
									{
										num2 = 11;
									}
									continue;
								case 9:
									_ = ((ConfigValueAttribute)(object)(CompilationRelaxationsAttribute)obj).Icon;
									_ = 11;
									if (((ListValue)(object)IntegerValueAttribute.ReflectActiveCompressor).Options__BackingField != null)
									{
										_ = 13;
									}
									continue;
								case 10:
								case 20:
									_ = (TargetFrameworkAttribute)obj;
									ConfigValueAttribute.CheckGenericNotifier();
									_ = 2;
									if (((ListValueAttribute)ListValueAttribute.DefaultValue__BackingField).Values__BackingField == null)
									{
										_ = 1;
									}
									continue;
								case 17:
									_ = ((ExpanderValue)(object)(AssemblyInformationalVersionAttribute)obj).IsExpanded;
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
							goto IL_04d9;
						}
						case 4:
						case 6:
							goto IL_04d9;
						case 2:
							goto end_IL_04d9;
						}
						break;
					}
					goto IL_008f;
					IL_008f:
					((IDisposable)(&obj)).Dispose();
					obj = (object)/*Error near IL_0098: Stack underflow*/;
					num = 1;
					if (((ConfigValue)ConfigValue.Icon__BackingField).DisplayName__BackingField != null)
					{
						num = 0;
					}
					goto IL_0065;
					continue;
					end_IL_04d9:
					break;
				}
				goto default;
			default:
				return this;
			case 2:
				((RuntimeCompatibilityAttribute)(object)P_0)._002Ector();
				obj = (object)/*Error near IL_0557: Stack underflow*/;
				obj2 = 0;
				if (ValueIcon.AlertOff == ValueIcon.AccessTime)
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
