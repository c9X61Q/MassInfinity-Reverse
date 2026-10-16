using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Game.Launcher.Entities.Fever;
using Serilog;

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
	public unsafe JavaGameOption(EnumGameVersion version, string fileName)
	{
		//IL_001b: Expected I4, but got Obj
		//IL_0016: Expected native int or pointer, but got Obj
		//IL_0026: Expected I, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = (int)fileName;
		Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)/*Error near IL_002b: Stack underflow*/)->_003C_003E4__this, new Func<Task>((object)/*Error near IL_0026: Stack underflow*/, (nint)this));
		Unsafe.Write(&Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton, new Authenticator());
		_ = ((AsyncTaskMethodBuilder*)this)->Task;
		int num = 0;
		if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener != null)
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
		//IL_001c: Expected Obj, but got VT
		//IL_0021: Expected I, but got Obj
		//IL_002e: Expected Obj, but got Ref
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((Func<Task>)this)._002Ector((object)key, (nint)(object)defaultValue);
		((Authenticator)/*Error near IL_0026: Stack underflow*/).StartListening((int)/*Error near IL_0026: Stack underflow*/);
		object obj = (object)/*Error near IL_0027: Stack underflow*/;
		((TcpListener)(&obj)).Start();
		((AsyncTaskMethodBuilder*)/*Error near IL_0033: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)/*Error near IL_0033: Stack underflow*/, ref *(Authenticator._003CReceiveAsync_003Ed__9*)/*Error near IL_0033: Stack underflow*/);
		return (T)/*Error near IL_0034: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe void SetEnum<T>(string key, T value) where T : struct
	{
		//IL_001c: Expected Obj, but got VT
		//IL_0021: Expected I, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((Func<Task>)this)._002Ector((object)key, (nint)(object)value);
		((Authenticator)/*Error near IL_0026: Stack underflow*/).StartListening((int)/*Error near IL_0026: Stack underflow*/);
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00紀(Size P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected native int or pointer, but got Obj
		//IL_004b: Expected I4, but got Obj
		//IL_004b: Expected Obj, but got VT
		//IL_004b: Expected native int or pointer, but got Obj
		//IL_0056: Expected Obj, but got VT
		//IL_0056: Expected Obj, but got VT
		//IL_006a->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0075->IL0026: Incompatible stack heights: 2 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				((Authenticator)((Authenticator._003CListenAsync_003Ed__7*)(nint)((Authenticator)this).Listener)->_003C_003Et__builder).StartListening((int)this);
				((Authenticator)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Eu__1).ListenAuthenticationConnectAsync((object)P_0);
				_ = 0;
				if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
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
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00耀()
	{
		//IL_001b: Expected native int or pointer, but got Obj
		//IL_0026: Expected Obj, but got VT
		//IL_0027: Expected I4, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((Authenticator)((Authenticator._003CListenAsync_003Ed__7*)(nint)((Authenticator)this).Listener)->_003C_003Et__builder).StartListening(0);
		return (byte)(int)this;
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
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00萀()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
	internal unsafe JavaGuiScale _FF00_FF00_FF00_FF00_FF00_FF00蜀()
	{
		//IL_001b: Expected native int or pointer, but got Obj
		//IL_0026: Expected Ref, but got VT
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((AsyncTaskMethodBuilder*)this)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)((Authenticator._003CListenAsync_003Ed__7*)(nint)((Authenticator)this).Listener)->_003C_003Et__builder, ref *(Authenticator._003CListenAsync_003Ed__7*)null);
		return (JavaGuiScale)/*Error near IL_0027: Stack underflow*/;
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00言(byte P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected native int or pointer, but got Obj
		//IL_004b: Expected Obj, but got VT
		//IL_005f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_006a->IL0026: Incompatible stack heights: 2 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				((Authenticator)((Authenticator._003CListenAsync_003Ed__7*)(nint)((Authenticator)this).Listener)->_003C_003Et__builder).StartListening(P_0);
				_ = 0;
				if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton != null)
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
	internal unsafe JavaNarrator _FF00_FF00_FF00_FF00_FF00_FF00谀()
	{
		//IL_001b: Expected native int or pointer, but got Obj
		//IL_0026: Expected Ref, but got VT
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((AsyncTaskMethodBuilder*)this)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)((Authenticator._003CListenAsync_003Ed__7*)(nint)((Authenticator)this).Listener)->_003C_003Et__builder, ref *(Authenticator._003CListenAsync_003Ed__7*)null);
		return (JavaNarrator)/*Error near IL_0027: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Size _FF00_FF00_FF00_FF00_FF00_FF00贀()
	{
		//IL_001b: Expected native int or pointer, but got Obj
		//IL_0026: Expected I4, but got Obj
		//IL_0026: Expected Obj, but got VT
		//IL_0026: Expected native int or pointer, but got Obj
		//IL_003a: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I4
		//IL_003b: Expected VT, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((Authenticator)((Authenticator._003CListenAsync_003Ed__7*)(nint)((Authenticator)this).Listener)->_003C_003Et__builder).StartListening((int)this);
		_ = ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Eu__1;
		return (Size)((Authenticator)1740).ListenAuthenticationConnectAsync((object)1080);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00踀(object P_0, byte P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779378, new IntPtr(2737367905724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00輀(object P_0, byte P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0041: Expected VT, but got Ref
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006a->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				((ILogger)this).Debug<_0021_00210>((string)P_0, (_0021_00210)(&P_1));
				((Func<Task>)/*Error near IL_0046: Stack underflow*/)._002Ector((object)/*Error near IL_0046: Stack underflow*/, (nint)/*Error near IL_0046: Stack underflow*/);
				((Authenticator)/*Error near IL_004b: Stack underflow*/).StartListening((int)/*Error near IL_004b: Stack underflow*/);
				obj2 = 0;
				if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton == null)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00退(object P_0, byte P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779377, new IntPtr(2737367883884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00鄀()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00鈀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779376, new IntPtr(2737367903644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00錀(byte P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected native int or pointer, but got Obj
		//IL_004a: Expected Obj, but got VT
		//IL_005e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0069->IL0026: Incompatible stack heights: 2 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				((Authenticator)((Authenticator._003CListenAsync_003Ed__7*)(nint)((Authenticator)this).Listener)->_003C_003Et__builder).StartListening(P_0);
				_ = 0;
				if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton == null)
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
		//IL_001d: Expected VT, but got Ref
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((ILogger)this).Debug<_0021_00210>((string)P_0, (_0021_00210)(&P_1));
		((Authenticator)/*Error near IL_0022: Stack underflow*/).Listener = (TcpListener?)/*Error near IL_0022: Stack underflow*/;
		((AsyncTaskMethodBuilder*)/*Error near IL_0031: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)((Authenticator)(object)Task.Run((Func<Task?>)/*Error near IL_0027: Stack underflow*/)).ListenAsync());
		return (byte)/*Error near IL_0032: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00阀(object P_0, byte P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779375, new IntPtr(2737367913004L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00需()
	{
		//IL_001b: Expected native int or pointer, but got Obj
		//IL_0026: Expected Obj, but got VT
		//IL_0027: Expected I4, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((Authenticator)((Authenticator._003CListenAsync_003Ed__7*)(nint)((Authenticator)this).Listener)->_003C_003Et__builder).StartListening(0);
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00頀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779374, new IntPtr(2737367903644L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00餀(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_003e: Expected native int or pointer, but got Obj
		//IL_004a: Expected I, but got Obj
		//IL_004a: Expected Obj, but got I4
		//IL_0054: Expected native int or pointer, but got Obj
		//IL_0083->IL0026: Incompatible stack heights: 2 vs 1
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0069->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				((Func<Task>)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state)._002Ector(P_0, (nint)P_1);
				obj2 = 0;
				if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
				{
					obj2 = 1;
				}
				break;
			case 1:
				((Authenticator)/*Error near IL_006f: Stack underflow*/).ListenAuthenticationConnectAsync((object)this);
				_ = 0;
				if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder != 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00騀(object P_0, object P_1, Size P_2)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0046: Expected VT, but got Ref
		//IL_0055: Expected native int or pointer, but got Obj
		//IL_008c->IL0026: Incompatible stack heights: 2 vs 1
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0097->IL0026: Incompatible stack heights: 2 vs 1
		//IL_006a->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				return;
			case 1:
				((ILogger)this).Debug<_0021_00210>((string)P_0, (_0021_00210)(&P_2));
				((Authenticator)/*Error near IL_004b: Stack underflow*/).Listener = (TcpListener?)/*Error near IL_004b: Stack underflow*/;
				obj2 = 0;
				if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				((AsyncTaskMethodBuilder*)P_1)->Start<TStateMachine>(ref *(TStateMachine*)(&P_2));
				((Authenticator)/*Error near IL_0078: Stack underflow*/).ReceiveAsync((object)this);
				_ = 2;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener != null)
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
	internal unsafe Size _FF00_FF00_FF00_FF00_FF00_FF00鰀(object P_0, object P_1, uint P_2, uint P_3)
	{
		//IL_001c: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I4
		//IL_002f: Expected VT, but got Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		_ = ((Authenticator)P_2).Listener;
		((Authenticator)P_1).Listener = (TcpListener?)P_3;
		return (Size)new Task((Func<Task?>)(object)this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00鴀(JavaGuiScale P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected native int or pointer, but got Obj
		//IL_004b: Expected Ref, but got VT
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006a->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				((AsyncTaskMethodBuilder*)this)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)((Authenticator._003CListenAsync_003Ed__7*)(nint)((Authenticator)this).Listener)->_003C_003Et__builder, ref *(Authenticator._003CListenAsync_003Ed__7*)(int)P_0);
				obj2 = 0;
				if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton != null)
				{
					obj2 = 0;
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00鼀(object P_0, uint P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0042: Expected VT, but got Ref
		//IL_0051: Expected native int or pointer, but got Obj
		//IL_005b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0066->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				((ILogger)this).Debug<_0021_00210>((string)P_0, (_0021_00210)(&P_1));
				((Authenticator)/*Error near IL_0047: Stack underflow*/).Listener = (TcpListener?)/*Error near IL_0047: Stack underflow*/;
				obj2 = 0;
				if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
				{
					obj2 = 0;
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
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00ꈀ(object P_0)
	{
		//IL_0015: Expected native int or pointer, but got Obj
		//IL_0020: Expected I, but got Obj
		//IL_0020: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((Func<Task>)/*Error near IL_0020: Stack underflow*/)._002Ector((object)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state, (nint)P_0);
		return (byte)/*Error near IL_0021: Stack underflow*/;
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00ꔀ(JavaNarrator P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected native int or pointer, but got Obj
		//IL_004b: Expected Ref, but got VT
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006a->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				((AsyncTaskMethodBuilder*)this)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)((Authenticator._003CListenAsync_003Ed__7*)(nint)((Authenticator)this).Listener)->_003C_003Et__builder, ref *(Authenticator._003CListenAsync_003Ed__7*)(int)P_0);
				obj2 = 0;
				if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton != null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00ꘀ()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003a: Expected native int or pointer, but got Obj
		//IL_0040: Expected native int or pointer, but got Obj
		//IL_004a: Expected Ref, but got VT
		//IL_0071: Expected Ref, but got VT
		//IL_006c: Expected Obj, but got VT
		//IL_0090->IL0026: Incompatible stack heights: 3 vs 1
		//IL_006c->IL006c: Incompatible stack heights: 3 vs 1
		//IL_009b->IL0026: Incompatible stack heights: 3 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
			{
				((AsyncTaskMethodBuilder*)/*Error near IL_004a: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state, ref *(Authenticator._003CListenAsync_003Ed__7*)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Et__builder);
				TaskAwaiter taskAwaiter = Authenticator._003CListenAsync_003Ed__7._003C_003Eu__1;
				if ((int)taskAwaiter == 0)
				{
					_ = Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton;
					__ldftn(Authenticator.ReceiveAsync);
					Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener = (TcpListener)new AsyncTaskMethodBuilder();
				}
				((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)/*Error near IL_0071: Stack underflow*/)->Start(ref *(FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)taskAwaiter);
				_ = 0;
				_ = ((TaskAwaiter*)new IAsyncStateMachine())->IsCompleted;
				_ = 0;
				if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder != 0)
				{
					_ = 0;
				}
				break;
			}
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00ꠀ(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected native int or pointer, but got Obj
		//IL_004b: Expected I4, but got Obj
		//IL_004b: Expected Obj, but got VT
		//IL_005f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_006a->IL0026: Incompatible stack heights: 2 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				((Authenticator)((Authenticator._003CListenAsync_003Ed__7*)(nint)((Authenticator)this).Listener)->_003C_003Et__builder).StartListening((int)P_0);
				_ = 0;
				if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton == null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00꤀(EnumGameVersion P_0, object P_1)
	{
		//IL_0021: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((Authenticator)P_1).Listener = new Authenticator();
		return P_0;
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
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00글(object P_0, object P_1)
	{
		//IL_0015: Expected native int or pointer, but got Obj
		//IL_0022: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		int num = ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
		((AsyncTaskMethodBuilder*)P_0)->Start(ref *(Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)P_1);
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00꼀()
	{
		//IL_0015: Expected native int or pointer, but got Obj
		//IL_001b: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
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
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0066: Expected native int or pointer, but got Obj
		//IL_0070: Expected Ref, but got VT
		//IL_00c6: Expected Obj, but got Ref
		//IL_00d2: Expected native int or pointer, but got Obj
		//IL_0113: Expected native int or pointer, but got Obj
		//IL_011f: Expected Obj, but got Ref
		//IL_0126: Expected Obj, but got Ref
		//IL_005a->IL0026: Incompatible stack heights: 2 vs 1
		//IL_007c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0065->IL0026: Incompatible stack heights: 2 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				_ = ((Authenticator)this).Listener;
				_ = 0;
				if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
				{
					_ = 0;
				}
				break;
			case 3:
				((AsyncTaskMethodBuilder*)/*Error near IL_0070: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)((Authenticator._003CListenAsync_003Ed__7*)(nint)P_0)->_003C_003Eu__1);
				obj = (object)/*Error near IL_0072: Stack underflow*/;
				obj2 = 2;
				break;
			case 2:
				while (true)
				{
					IL_00e7:
					int num;
					if (!((TaskAwaiter*)(&obj))->IsCompleted)
					{
						num = 0;
						if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder == 0)
						{
							num = 1;
						}
						goto IL_00a5;
					}
					goto IL_00bf;
					IL_00bf:
					GC.SuppressFinalize((object)(&obj));
					obj = (object)/*Error near IL_00c8: Stack underflow*/;
					num = 3;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						num = 1;
					}
					goto IL_00a5;
					IL_00a5:
					while (true)
					{
						switch (num)
						{
						case 1:
							break;
						default:
							goto IL_00bf;
						case 2:
							goto IL_00e7;
						case 3:
							((ILogger)/*Error near IL_011f: Stack underflow*/).Error((Exception)(object)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003E4__this, (string)(&obj));
							((AsyncTaskMethodBuilder*)/*Error near IL_0126: Stack underflow*/)->SetException((Exception)(&obj));
							((AsyncTaskMethodBuilder*)/*Error near IL_012b: Stack underflow*/)->SetResult();
							num = 2;
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
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_003f: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got Ref
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007b->IL005e: Incompatible stack heights: 1 vs 0
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_009a->IL0026: Incompatible stack heights: 2 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 2;
		object obj = stateMachine;
		while (true)
		{
			switch ((int)obj)
			{
			case 1:
				stateMachine = P_1;
				obj = 0;
				if ((int)((Authenticator._003CListenAsync_003Ed__7*)Authenticator._003CListenAsync_003Ed__7._003C_003E1__state)->_003C_003Et__builder != 0)
				{
					obj = 0;
				}
				break;
			default:
				return (uint)(int)stateMachine;
			case 2:
				((AsyncTaskMethodBuilder*)((Authenticator)(object)Task.Run((Func<Task?>)(&P_1))).ListenAsync())->Start<TStateMachine>(ref *(TStateMachine*)(&stateMachine));
				if (P_0 == null)
				{
					_ = 1;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00됀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected native int or pointer, but got Obj
		//IL_004b: Expected Ref, but got VT
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006a->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				((AsyncTaskMethodBuilder*)this)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)((Authenticator._003CListenAsync_003Ed__7*)(nint)((Authenticator)this).Listener)->_003C_003Et__builder, ref *(Authenticator._003CListenAsync_003Ed__7*)P_0);
				obj2 = 0;
				if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton == null)
				{
					obj2 = 0;
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
