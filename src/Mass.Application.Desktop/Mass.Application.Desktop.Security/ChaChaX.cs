using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Org.BouncyCastle.Crypto.Engines;

namespace Mass.Application.Desktop.Security;

public class ChaChaX : ChaCha7539Engine
{
	public static readonly byte[] ChaChaIv;

	private static object DecoratePassiveRequester;

	public override string AlgorithmName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00뜀();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ChaChaX(byte[] key, byte[] iv, int rounds, bool forEncryption)
	{
		//IL_004c: Expected VT, but got Obj
		//IL_004c: Expected VT, but got I4
		//IL_0057: Expected VT, but got Obj
		//IL_0057: Expected VT, but got Obj
		//IL_006b->IL002d: Incompatible stack heights: 5 vs 3
		//IL_008d->IL002d: Incompatible stack heights: 5 vs 3
		//IL_0076->IL002d: Incompatible stack heights: 5 vs 3
		//IL_0098->IL002d: Incompatible stack heights: 5 vs 3
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		_ = EqualityComparer<_00211>.Default;
		while (true)
		{
			switch (2)
			{
			default:
				return;
			case 1:
				((EqualityComparer<_00210>)new EqualityComparer<_00211>((_00211?)forEncryption, (_00211?)key)).Equals((_00210?)iv, (_00210?)new EqualityComparer<_00210>());
				_ = 0;
				if (DesktopAuthentication.Logger != null)
				{
					_ = 0;
				}
				break;
			case 2:
				_ = 1;
				if (((DesktopAuthentication)DesktopAuthentication._client)._connected == 0)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	unsafe static ChaChaX()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0023: Expected I4, but got Obj
		//IL_0061: Expected Obj, but got VT
		//IL_0048->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0075->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0053->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0080->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				ChaChaIv = ((ReadOnlySpan<byte>*)(&obj))->ToArray();
				obj2 = 1;
				if (_003CModule_003E_007Bb8824bbe_002D6cfa_002D4013_002D8120_002Dcb1e84055f2d_007D.m_2f25a4da0ad14a089b13089b3bff794c.m_567e52d5e7544cd9bf1b4820a8503c98 != 0)
				{
					obj2 = 2;
				}
				break;
			case 1:
				obj = (object)"163 NetEase\n"u8;
				obj2 = 0;
				if (_003CModule_003E_007Bb8824bbe_002D6cfa_002D4013_002D8120_002Dcb1e84055f2d_007D.m_2f25a4da0ad14a089b13089b3bff794c.m_2be09b9d4a094bd49f9f575b5bb5af2d == 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckExternalModule()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ChaChaX AdaptContext()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00똀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778681, new IntPtr(2737336620876L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00뜀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2146, 1790778680, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778680, new IntPtr(2737336627116L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00렀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778683, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00뤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778682, new IntPtr(2737336633356L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00먀()
	{
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return DesktopAuthentication._003CuserId_003EP;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00묀()
	{
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00밀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778661, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}
}
