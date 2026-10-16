using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.UI.Xaml.Markup;
using WinRT;
using WinRT.Mass_WinUIVtableClasses;

namespace Mass.WinUI.Mass_WinUI_XamlTypeInfo;

[DebuggerNonUserCode]
[WinRTExposedType(typeof(Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Markup.IXamlType")]
[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
internal class XamlUserType : XamlSystemBaseType, IXamlType
{
	private object _provider;

	private object _baseType;

	private object _boxedType;

	private nint _isArray;

	private nint _isMarkupExtension;

	private nint _isBindable;

	private nint _isReturnTypeStub;

	private nint _isLocalType;

	private object _contentPropertyName;

	private object _itemTypeName;

	private object _keyTypeName;

	private Dictionary<string, string> _memberNames;

	private Dictionary<string, object> _enumValues;

	private static object CheckFilteredDriver;

	public override IXamlType BaseType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IXamlType)_FF00_FF00_FF00_FF00_FF00_FF00_FF00輀();
		}
	}

	public override bool IsArray
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FF00茀() != 0;
		}
	}

	public override bool IsCollection
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FF00瘀() != 0;
		}
	}

	public override bool IsConstructible
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FF00猀() != 0;
		}
	}

	public override bool IsDictionary
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FF00退() != 0;
		}
	}

	public override bool IsMarkupExtension
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FF00紀() != 0;
		}
	}

	public override bool IsBindable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FF00대() != 0;
		}
	}

	public override bool IsReturnTypeStub
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FF00餀() != 0;
		}
	}

	public override bool IsLocalType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FF00렀() != 0;
		}
	}

	public override IXamlType BoxedType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IXamlType)_FF00_FF00_FF00_FF00_FF00_FF00_FF00谀();
		}
	}

	public override IXamlMember ContentProperty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IXamlMember)_FF00_FF00_FF00_FF00_FF00_FF00_FF00焀();
		}
	}

	public override IXamlType ItemType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IXamlType)_FF00_FF00_FF00_FF00_FF00_FF00_FF00漀();
		}
	}

	public override IXamlType KeyType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IXamlType)_FF00_FF00_FF00_FF00_FF00_FF00_FF00밀();
		}
	}

	public Activator Activator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (Activator)_FF00_FF00_FF00_FF00_FF00_FF00_FF00阀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00ꐀ(value);
		}
	}

	public StaticInitializer StaticInitializer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (StaticInitializer)_FF00_FF00_FF00_FF00_FF00_FF00_FF00萀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00ꌀ(value);
		}
	}

	public AddToCollection CollectionAdd
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (AddToCollection)_FF00_FF00_FF00_FF00_FF00_FF00_FF00洀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00ꠀ(value);
		}
	}

	public AddToDictionary DictionaryAdd
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (AddToDictionary)_FF00_FF00_FF00_FF00_FF00_FF00_FF00脀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00欀(value);
		}
	}

	public CreateFromStringMethod CreateFromStringMethod
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (CreateFromStringMethod)_FF00_FF00_FF00_FF00_FF00_FF00_FF00砀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00鄀(value);
		}
	}

	public BoxInstanceMethod BoxInstance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (BoxInstanceMethod)_FF00_FF00_FF00_FF00_FF00_FF00_FF00ꄀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00言(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public XamlUserType(XamlTypeInfoProvider provider, string fullName, Type fullType, IXamlType baseType)
	{
		//IL_003c: Expected I4, but got Obj
		//IL_0022->IL002b: Incompatible stack types: I4 vs Obj
		//IL_005f->IL002b: Incompatible stack heights: 4 vs 3
		//IL_0050->IL002b: Incompatible stack heights: 5 vs 3
		//IL_006a->IL002b: Incompatible stack heights: 4 vs 3
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		Type type = fullType;
		if (0 == 0)
		{
			type = (Type)0;
		}
		while (true)
		{
			switch ((int)type)
			{
			case 2:
				return;
			case 1:
				_ = 2;
				continue;
			}
			if (false)
			{
				_ = 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override IXamlMember GetMember(string name)
	{
		return (IXamlMember)_FF00_FF00_FF00_FF00_FF00_FF00_FF00뼀(name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object ActivateInstance()
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00_FF00贀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void AddToMap(object instance, object key, object item)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00缀(instance, key, item);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void AddToVector(object instance, object item)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00ꘀ(instance, item);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void RunInitializer()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00뀀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe override object CreateFromString(string input)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2000, 1790777555, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790777555, new IntPtr(2737336352572L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, input);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetContentPropertyName(string contentPropertyName)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00蘀(contentPropertyName);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetIsArray()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00鬀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetIsMarkupExtension()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00甀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetIsBindable()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00笀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetIsReturnTypeStub()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00需();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetIsLocalType()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00_AB00();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetItemTypeName(string itemTypeName)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00관(itemTypeName);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetKeyTypeName(string keyTypeName)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00稀(keyTypeName);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBoxedType(IXamlType boxedType)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00글(boxedType);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object BoxType<T>(object instance) where T : struct
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return instance;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddMemberName(string shortName)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00鐀(shortName);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddEnumValue(string name, object value)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00먀(name, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectAutomatedWriter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static XamlUserType CheckPassiveDic()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00樀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777552, new IntPtr(2737336353612L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00欀(object P_0)
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
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00氀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777553, new IntPtr(2737336353612L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00洀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00渀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777566, new IntPtr(2737336353612L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00漀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17162, 1790777567, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777567, new IntPtr(2737336353612L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00瀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777564, new IntPtr(2737336354652L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00焀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17164, 1790777565, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777565, new IntPtr(2737336354652L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00爀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777562, new IntPtr(2737335707036L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00猀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (this != null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00琀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777563, new IntPtr(2737335726796L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00甀()
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
				_ = 1;
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
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00瘀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (this != null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00眀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777560, new IntPtr(2737335722636L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00砀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00礀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777561, new IntPtr(2737335730956L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00稀(object P_0)
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00笀()
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
				_ = 1;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00簀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777382, new IntPtr(2737335705996L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00紀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00縀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777383, new IntPtr(2737335701836L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00缀(object P_0, object P_1, object P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003d->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0048->IL0019: Incompatible stack heights: 4 vs 1
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00耀(object P_0, object P_1, object P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777380, new IntPtr(2737335703916L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00脀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00舀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777381, new IntPtr(2737335710156L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00茀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00萀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00蔀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777378, new IntPtr(2737335704956L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00蘀(object P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00蜀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777379, new IntPtr(2737335721596L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00蠀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_005e: Expected I4, but got Obj
		//IL_045c: Expected Obj, but got I4
		//IL_0083: Expected Obj, but got I8
		//IL_0091: Expected Obj, but got I8
		//IL_009a: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I4
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected Obj, but got Unknown
		//IL_00e5: Expected I4, but got Obj
		//IL_0115: Expected I4, but got Obj
		//IL_0466->IL0019: Incompatible stack heights: 3 vs 1
		//IL_008d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_042f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03a3->IL0019: Incompatible stack heights: 0 vs 1
		//IL_03d4->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0375->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03ae->IL0019: Incompatible stack types: I4 vs Obj
		//IL_044a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_03df->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e5->IL02ee: Incompatible stack heights: 1 vs 2
		//IL_0306->IL00c8: Incompatible stack types: I4 vs Obj
		//IL_00c4->IL00c8: Incompatible stack types: I4 vs Obj
		//IL_03f7->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0455->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02e3->IL00c8: Incompatible stack heights: 1 vs 2
		//IL_0315->IL00c8: Incompatible stack types: I4 vs Obj
		//IL_0402->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0108->IL010c: Incompatible stack types: I4 vs Obj
		//IL_02ee->IL00c8: Incompatible stack heights: 1 vs 2
		//IL_011f->IL02d0: Incompatible stack heights: 0 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				XamlUserType xamlUserType;
				object obj3;
				switch ((int)obj2)
				{
				case 12:
					obj = 0;
					obj2 = 14;
					continue;
				case 7:
					obj = 0;
					obj2 = 4;
					continue;
				case 9:
					break;
				case 13:
					xamlUserType = this;
					obj3 = obj;
					if (&obj != null)
					{
						if (2 == 0)
						{
							obj3 = 0;
						}
						goto IL_00c8;
					}
					goto IL_02ee;
				default:
					return this;
				case 6:
					throw this;
				case 5:
				case 14:
					if ((nint)obj < ((Array)obj).Length)
					{
						obj2 = 3;
						continue;
					}
					goto default;
				case 15:
					goto IL_0391;
				case 2:
					if (this == null)
					{
						if (1 == 0)
						{
							obj2 = 1;
						}
						continue;
					}
					goto case 10;
				case 8:
					return P_0;
				case 3:
				case 11:
					obj = ((object[])obj)[obj];
					obj2 = 9;
					continue;
				case 10:
					return P_0;
				case 1:
					if (this == null)
					{
						if (this == null)
						{
							if (6 != 0)
							{
								obj2 = 6;
							}
							continue;
						}
						goto case 7;
					}
					if (8 == 0)
					{
						obj2 = 8;
					}
					continue;
				case 4:
					{
						_ = 44;
						obj = 0;
						_ = 12;
						continue;
					}
					IL_0391:
					obj++;
					if (5 != 0)
					{
						obj2 = 5;
					}
					continue;
					IL_02ee:
					if (0 == 0)
					{
						obj3 = 0;
					}
					goto IL_00c8;
					IL_00c8:
					while (true)
					{
						switch ((int)obj3)
						{
						default:
							obj = obj;
							if (0 == 0)
							{
								xamlUserType = (XamlUserType)0;
							}
							switch ((int)xamlUserType)
							{
							}
							goto case 1;
						case 1:
						case 3:
							obj |= obj;
							if (5 == 0)
							{
								_ = 3;
							}
							continue;
						case 4:
							break;
						case 2:
							obj = obj;
							obj3 = 3;
							continue;
						case 5:
							goto IL_0391;
						}
						break;
					}
					goto IL_02ee;
				}
				break;
			}
			obj = 0;
			obj = 13;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00褀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777376, new IntPtr(2737335719516L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00言(object P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00謀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777377, new IntPtr(2737335712236L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00谀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00贀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00踀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777390, new IntPtr(2737335719516L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00輀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00退()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (this != null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00鄀(object P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00鈀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777391, new IntPtr(2737335705996L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00鐀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_005d->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0068->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0048->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009f->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				if (this != null)
				{
					obj2 = 2;
					continue;
				}
				break;
			default:
				if (true)
				{
					_ = 0;
				}
				continue;
			case 1:
				return;
			case 4:
				break;
			}
			obj2 = this;
			if (false)
			{
				obj2 = 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00销(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777388, new IntPtr(2737335725756L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00阀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00需()
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
				_ = 1;
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00頀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777389, new IntPtr(2737335711196L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00餀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00騀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777386, new IntPtr(2737335700796L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00鬀()
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
				_ = 1;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00鰀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777387, new IntPtr(2737335721596L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00鴀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777384, new IntPtr(2737335710156L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00鸀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00鼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777385, new IntPtr(2737335728876L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꀀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777398, new IntPtr(2737335698716L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꄀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꈀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777399, new IntPtr(2737335704956L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꌀ(object P_0)
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꐀ(object P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꔀ(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777396, new IntPtr(2737335698716L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꘀ(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003c->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0047->IL0019: Incompatible stack heights: 3 vs 1
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_A700(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777397, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꠀ(object P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00꤀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777394, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ꨀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777395, new IntPtr(2737335716396L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_AB00()
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
				_ = 1;
				if (false)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00가()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777392, new IntPtr(2737335724716L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00관(object P_0)
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00글(object P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00꼀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777393, new IntPtr(2737335724716L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00뀀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0045->IL0019: Incompatible stack types: I4 vs Obj
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
				return;
			case 1:
				obj2 = this;
				if (0 == 0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00넀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777406, new IntPtr(2737335727836L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00눀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777407, new IntPtr(2737335726796L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00대()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00됀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777404, new IntPtr(2737335704956L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00딀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777405, new IntPtr(2737335703916L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00똀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00뜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777402, new IntPtr(2737335700796L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00렀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00뤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777403, new IntPtr(2737335701836L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00먀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0048->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0053->IL0019: Incompatible stack heights: 3 vs 1
		//IL_009b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006d->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				if (true)
				{
					_ = 0;
				}
				break;
			case 4:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				return;
			case 3:
				if (this != null)
				{
					obj2 = 2;
					break;
				}
				goto case 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00묀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777400, new IntPtr(2737335721596L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00밀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17239, 1790777401, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790777401, new IntPtr(2737335699756L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00봀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777350, new IntPtr(2737335714316L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00븀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777351, new IntPtr(2737335707036L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00뼀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17242, 1790777348, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790777348, new IntPtr(2737335716396L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}
}
