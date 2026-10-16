using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.UI.Xaml.Markup;
using WinRT;
using WinRT.Mass_WinUIVtableClasses;

namespace Mass.WinUI.Mass_WinUI_XamlTypeInfo;

[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2602")]
[WinRTExposedType(typeof(Mass_WinUI_Mass_WinUI_XamlTypeInfo_XamlSystemBaseTypeWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Markup.IXamlType")]
[DebuggerNonUserCode]
internal class XamlSystemBaseType : IXamlType
{
	private object _fullName;

	private object _underlyingType;

	private static object DecorateCentralVisitor;

	public string FullName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00_FF00ἀ();
		}
	}

	public Type UnderlyingType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (Type)_FF00_FF00_FF00_FF00_FF00_FF00_FF00_3100();
		}
	}

	public virtual IXamlType BaseType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IXamlType)_FF00_FF00_FF00_FF00_FF00_FF00_FF00ᰀ();
		}
	}

	public virtual IXamlMember ContentProperty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IXamlMember)_FF00_FF00_FF00_FF00_FF00_FF00_FF00㰀();
		}
	}

	public virtual bool IsArray
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2500() != 0;
		}
	}

	public virtual bool IsCollection
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2E00() != 0;
		}
	}

	public virtual bool IsConstructible
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2600() != 0;
		}
	}

	public virtual bool IsDictionary
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2A00() != 0;
		}
	}

	public virtual bool IsMarkupExtension
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2B00() != 0;
		}
	}

	public virtual bool IsBindable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2300() != 0;
		}
	}

	public virtual bool IsReturnTypeStub
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FF00㠀() != 0;
		}
	}

	public virtual bool IsLocalType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FF00㤀() != 0;
		}
	}

	public virtual IXamlType ItemType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IXamlType)_FF00_FF00_FF00_FF00_FF00_FF00_FF00_2800();
		}
	}

	public virtual IXamlType KeyType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IXamlType)_FF00_FF00_FF00_FF00_FF00_FF00_FF00䌀();
		}
	}

	public virtual IXamlType BoxedType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IXamlType)_FF00_FF00_FF00_FF00_FF00_FF00_FF00㘀();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public XamlSystemBaseType(string fullName, Type underlyingType)
	{
		//IL_003a: Expected I4, but got Obj
		//IL_0020->IL0029: Incompatible stack types: I4 vs Obj
		//IL_0069->IL0029: Incompatible stack heights: 2 vs 1
		//IL_004f->IL0029: Incompatible stack heights: 2 vs 1
		//IL_0074->IL0029: Incompatible stack heights: 2 vs 1
		//IL_005a->IL0029: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		XamlSystemBaseType xamlSystemBaseType = this;
		if (1 == 0)
		{
			xamlSystemBaseType = (XamlSystemBaseType)1;
		}
		while (true)
		{
			switch ((int)xamlSystemBaseType)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 1:
				if (2 != 0)
				{
					_ = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IXamlMember GetMember(string name)
	{
		return (IXamlMember)_FF00_FF00_FF00_FF00_FF00_FF00_FF00㸀(name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual object ActivateInstance()
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2100();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddToMap(object instance, object key, object item)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00ᴀ(instance, key, item);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddToVector(object instance, object item)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00䀀(instance, item);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RunInitializer()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00㔀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual object CreateFromString(string input)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00_FF00䔀(input);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectStatelessWatcher()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static XamlSystemBaseType LoadInspector()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_1B00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777543, new IntPtr(2737336352572L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᰀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		throw /*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᴀ(object P_0, object P_1, object P_2)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		throw /*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ḁ(object P_0, object P_1, object P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777540, new IntPtr(2737336352572L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ἀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777541, new IntPtr(2737336352572L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2100()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		throw /*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2200()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777538, new IntPtr(2737336352572L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2300()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		throw /*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777539, new IntPtr(2737336352572L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2500()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		throw /*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2600()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		throw /*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777536, new IntPtr(2737336352572L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2800()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		throw /*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2900()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777537, new IntPtr(2737336352572L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2A00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		throw /*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2B00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		throw /*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ⰰ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777550, new IntPtr(2737336352572L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00ⴀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777551, new IntPtr(2737336352572L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2E00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		throw /*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2F00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777548, new IntPtr(2737336352572L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_3000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777549, new IntPtr(2737336352572L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_3100()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_3200()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_3300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777546, new IntPtr(2737336352572L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00㐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777547, new IntPtr(2737336352572L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00㔀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		throw /*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㘀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		throw /*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777544, new IntPtr(2737336352572L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00㠀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		throw /*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00㤀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		throw /*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00㨀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777545, new IntPtr(2737336352572L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777558, new IntPtr(2737336352572L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㰀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		throw /*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㴀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777559, new IntPtr(2737336352572L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㸀(object P_0)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		throw /*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㼀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777556, new IntPtr(2737336352572L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00䀀(object P_0, object P_1)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		throw /*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00䄀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00䈀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777557, new IntPtr(2737336352572L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00䌀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		throw /*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00䐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777554, new IntPtr(2737336352572L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00䔀(object P_0)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		throw /*Error near IL_0009: Stack underflow*/;
	}
}
