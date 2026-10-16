using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Mass.Game.Proxy.Network;

public readonly struct Position
{
	public readonly long X;

	public readonly long Y;

	public readonly long Z;

	private static object FormatBuilder;

	public long Encoded
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_FF00_FF00匀();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe Position(long x, long y, long z)
	{
		//IL_003a: Expected VT, but got I8
		//IL_003a: Expected Obj, but got Ref
		//IL_0049: Expected Obj, but got VT
		//IL_0061: Expected VT, but got I8
		//IL_0061: Expected Obj, but got Ref
		//IL_0072: Expected VT, but got I8
		//IL_0072: Expected Obj, but got Ref
		//IL_0081: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref this))._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)x;
		int num = 1;
		if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				((_003C_003Ef__AnonymousType2<, , , >)Unsafe.AsPointer(ref this))._003Curl_003Ei__Field = (_003Curl_003Ej__TPar)y;
				num = 2;
				break;
			case 2:
				((_003C_003Ef__AnonymousType2<, , , >)Unsafe.AsPointer(ref this))._003Cpayload_003Ei__Field = (_003Cpayload_003Ej__TPar)z;
				num = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Ccontext_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Position(long encoded)
	{
		//IL_002c: Expected VT, but got I8
		//IL_002c: Expected Obj, but got I8
		//IL_003b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		_ = encoded >> 38;
		((_003C_003Ef__AnonymousType0<>)(encoded << 52 >> 52))._002Ector((_003Caction_003Ej__TPar)(encoded << 26 >> 38));
		int num = 0;
		if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
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
	internal static bool DecorateGlobalTransmitter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DecorateDetachedRecommender()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe long _FF00_FF00_FF00_FF00刀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776620, new IntPtr(2737368302748L), 15))(null, 0, new IntPtr(0L));
		return (long)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe long _FF00_FF00_FF00_FF00匀()
	{
		//IL_001a: Expected Obj, but got Ref
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Ref
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Ref
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected I8, but got Unknown
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref this))._003Cuuid_003Ei__Field & 0x3FFFFFF) << 38) | ((((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref this))._003Cuser_id_003Ei__Field & 0x3FFFFFF) << 12) | (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter & 0xFFF);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00吀()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00唀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776623, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00嘀()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}
}
