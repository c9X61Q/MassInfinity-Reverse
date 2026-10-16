using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.Domain.Desktop.ValueObjects;

namespace Mass.Game.Launcher.Java.Option;

public class JavaGameOption
{
	private readonly Dictionary<string, string> _options;

	private static object DecorateIterableWatcher;

	public JavaGameOptionKey Key
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (JavaGameOptionKey)_FF00_FF00_FF00_FF00_FF00_FF00꼀();
		}
	}

	public string Language
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00가();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00ꠀ(value);
		}
	}

	public Size WindowSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00贀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00紀(value);
		}
	}

	public JavaGuiScale GuiScale
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00蜀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00鴀(value);
		}
	}

	public JavaNarrator Narrator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00谀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00ꔀ(value);
		}
	}

	public bool OnboardAccessibility
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00需() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00錀(value ? ((byte)1) : ((byte)0));
		}
	}

	public bool AutoJump
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00耀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00言(value ? ((byte)1) : ((byte)0));
		}
	}

	public string[] ResourcePacks
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string[])_FF00_FF00_FF00_FF00_FF00_FF00똀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00됀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JavaGameOption(EnumGameVersion version, string fileName)
	{
		//IL_004b: Expected I4, but got Obj
		//IL_0039->IL0042: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		JavaGameOption javaGameOption = this;
		if (false)
		{
			javaGameOption = (JavaGameOption)0;
		}
		switch ((int)javaGameOption)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static JavaGameOption Open(EnumGameVersion version, string fileName)
	{
		return (JavaGameOption)_FF00_FF00_FF00_FF00_FF00_FF00꤀(version, fileName);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JavaGameOption Load()
	{
		return (JavaGameOption)_FF00_FF00_FF00_FF00_FF00_FF00茀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Overwrite(JavaGameOption options)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00넀(options);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Save()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00ꘀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasKey(string key)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00ꈀ(key) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public T[] GetArray<T>(string key) where T : class
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetArray<T>(string key, T[] value) where T : class
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetString(string key, string defaultValue = "")
	{
		return (string)_FF00_FF00_FF00_FF00_FF00_FF00글(key, defaultValue);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetString(string key, string value)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00餀(key, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetInt(string key, int defaultValue = 0)
	{
		return (int)_FF00_FF00_FF00_FF00_FF00_FF00눀(key, (uint)defaultValue);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetInt(string key, int value)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00鼀(key, (uint)value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Size GetSize(string widthKey, string heightKey, int defaultWidth = 1740, int defaultHeight = 1080)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00鰀(widthKey, heightKey, (uint)defaultWidth, (uint)defaultHeight);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSize(string widthKey, string heightKey, Size value)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00騀(widthKey, heightKey, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe T GetEnum<T>(string key, T defaultValue = default(T)) where T : struct
	{
		//IL_000e: Expected Obj, but got VT
		//IL_0013: Expected VT, but got Ref
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = defaultValue;
		return (T)(&obj);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEnum<T>(string key, T value) where T : struct
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetBool(string key, bool defaultValue = false)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00销(key, defaultValue ? ((byte)1) : ((byte)0)) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBool(string key, bool value)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00輀(key, value ? ((byte)1) : ((byte)0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateIntegratedElement()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static JavaGameOption CheckLocalDriver()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00簀(Size P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779389, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00紀(Size P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0041->IL0019: Incompatible stack heights: 4 vs 1
		//IL_004c->IL0019: Incompatible stack heights: 4 vs 1
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00縀(Size P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779388, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00缀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779387, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00耀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00脀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779386, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00舀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779385, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00茀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 3416, 1790779384, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779384, new IntPtr(2737337593884L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00萀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00蔀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779383, new IntPtr(2737367914044L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe JavaGuiScale _FF00_FF00_FF00_FF00_FF00_FF00蘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779382, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
		return (JavaGuiScale)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal JavaGuiScale _FF00_FF00_FF00_FF00_FF00_FF00蜀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return JavaGuiScale.Auto;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe JavaGuiScale _FF00_FF00_FF00_FF00_FF00_FF00蠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779381, new IntPtr(2737367888044L), 15))(null, 0, new IntPtr(0L));
		return (JavaGuiScale)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00褀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779380, new IntPtr(2737367896364L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00言(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0049->IL0019: Incompatible stack heights: 3 vs 1
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00謀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779379, new IntPtr(2737367883884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal JavaNarrator _FF00_FF00_FF00_FF00_FF00_FF00谀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return JavaNarrator.Off;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Size _FF00_FF00_FF00_FF00_FF00_FF00贀()
	{
		//IL_001a: Expected VT, but got I4
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_ = 1740;
		return (Size)1080;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00踀(object P_0, byte P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779378, new IntPtr(2737367905724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00輀(object P_0, byte P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0049->IL0019: Incompatible stack heights: 3 vs 1
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
				_ = ref P_1;
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00退(object P_0, byte P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779377, new IntPtr(2737367883884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00鄀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00鈀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779376, new IntPtr(2737367903644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00錀(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0048->IL0019: Incompatible stack heights: 3 vs 1
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
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00销(object P_0, byte P_1)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(&P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00阀(object P_0, byte P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779375, new IntPtr(2737367913004L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00需()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00頀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779374, new IntPtr(2737367903644L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00餀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0041->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0065->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004c->IL0019: Incompatible stack heights: 3 vs 1
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
			case 0:
				return;
			case 2:
				if (0 == 0)
				{
					_ = 1;
				}
				break;
			case 1:
				obj2 = this;
				if (false)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00騀(object P_0, object P_1, Size P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_005f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0042->IL0019: Incompatible stack heights: 3 vs 1
		//IL_006a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_004d->IL0019: Incompatible stack heights: 3 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			case 2:
				return;
			case 1:
				_ = ref P_2;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			default:
				_ = ref P_2;
				if (2 != 0)
				{
					_ = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Size _FF00_FF00_FF00_FF00_FF00_FF00鬀(object P_0, object P_1, uint P_2, uint P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779373, new IntPtr(2737367896364L), 15))(null, 0, new IntPtr(0L));
		return (Size)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Size _FF00_FF00_FF00_FF00_FF00_FF00鰀(object P_0, object P_1, uint P_2, uint P_3)
	{
		//IL_0012: Expected Obj, but got I4
		//IL_0016: Expected VT, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = P_3;
		return (Size)obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00鴀(JavaGuiScale P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0049->IL0019: Incompatible stack heights: 3 vs 1
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00鸀(JavaGuiScale P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779372, new IntPtr(2737367906764L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00鼀(object P_0, uint P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0049->IL0019: Incompatible stack heights: 3 vs 1
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
				_ = ref P_1;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00ꀀ(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779371, new IntPtr(2737367913004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00ꄀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779370, new IntPtr(2737367893244L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00ꈀ(object P_0)
	{
		//IL_000c: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00ꌀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779369, new IntPtr(2737367902604L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00ꐀ(JavaNarrator P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779368, new IntPtr(2737367888044L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00ꔀ(JavaNarrator P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0049->IL0019: Incompatible stack heights: 3 vs 1
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
	private void _FF00_FF00_FF00_FF00_FF00_FF00ꘀ()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_004e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0059->IL0019: Incompatible stack heights: 3 vs 1
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
				_ = 0;
				if (false)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_A700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779367, new IntPtr(2737367893244L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00ꠀ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0049->IL0019: Incompatible stack heights: 3 vs 1
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
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00꤀(EnumGameVersion P_0, object P_1)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00ꨀ(EnumGameVersion P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779366, new IntPtr(2737367898444L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_AB00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779365, new IntPtr(2737367906764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00가()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 3457, 1790779364, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779364, new IntPtr(2737367891164L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00관()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779363, new IntPtr(2737367887004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00글(object P_0, object P_1)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00꼀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00뀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779362, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00넀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_009b: Expected Obj, but got Ref
		//IL_005b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b2->IL007c: Incompatible stack heights: 1 vs 0
		//IL_00d1->IL007c: Incompatible stack heights: 1 vs 0
		//IL_00e4->IL007c: Incompatible stack heights: 4 vs 0
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
				return;
			case 1:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				obj = P_0;
				obj2 = 2;
				break;
			case 2:
				while (true)
				{
					IL_00b2:
					if (&obj == null)
					{
						if (0 == 0)
						{
							_ = 1;
						}
						goto IL_007c;
					}
					goto IL_0096;
					IL_0096:
					obj = (object)(&obj);
					if (3 == 0)
					{
						_ = 1;
					}
					goto IL_007c;
					IL_007c:
					while (true)
					{
						switch ((int)/*Error near IL_0091: Stack underflow*/)
						{
						case 1:
							break;
						default:
							goto IL_0096;
						case 2:
							goto IL_00b2;
						case 3:
							_ = ref obj;
							_ = ref obj;
							_ = 2;
							continue;
						}
						break;
					}
					break;
				}
				goto case 1;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00눀(object P_0, uint P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_004c: Expected I4, but got Obj
		//IL_0032: Expected Obj, but got I4
		//IL_003e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_005a->IL0049: Incompatible stack heights: 3 vs 0
		//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0066->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0071->IL0019: Incompatible stack heights: 3 vs 1
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
				obj = P_1;
				if (false)
				{
					obj2 = 0;
				}
				break;
			default:
				return (uint)(int)obj;
			case 2:
				_ = ref P_1;
				if (&obj == null)
				{
					if (1 == 0)
					{
						_ = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00대(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779361, new IntPtr(2737367894284L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00됀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0049->IL0019: Incompatible stack heights: 3 vs 1
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00딀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779360, new IntPtr(2737367909884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00똀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 3467, 1790779295, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779295, new IntPtr(2737367901564L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00뜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779294, new IntPtr(2737367885964L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
