using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Network.Interface;
using Mass.Game.Proxy.Network.Packet;

namespace Mass.Game.Proxy.Packets.Common;

public abstract class KeepAlivePacket : IPacket, IBufferCodec, IBufferSerializable, IBufferDeserializable
{
	internal static KeepAlivePacket DecorateAdaptableFilter;

	public long KeepAliveId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return this._FF00_FF00_FF00_FF00_FFFD();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			this._FF00_FF00_FF00_FF00_FFFD(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe KeepAlivePacket(EnumProtocolVersion version)
	{
		//IL_001b: Expected VT, but got I4
		//IL_0026: Expected VT, but got Obj
		//IL_0026: Expected Obj, but got Ref
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)version;
		((EqualityComparer<_00210>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).GetHashCode((_00210)this);
		int num = 0;
		if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
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
	public void Read(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00휀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00혀(buffer);
	}

	public bool Handle(Connection connection)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VisitGateway()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static KeepAlivePacket ConcatProfiler()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00픀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778010, new IntPtr(2737368317308L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00혀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_0072: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got Ref
		//IL_009a: Expected Obj, but got VT
		//IL_00b6: Invalid comparison between VT and I4
		//IL_0055: Expected VT, but got Obj
		//IL_005a: Expected VT, but got Ref
		//IL_00ca: Expected Obj, but got VT
		//IL_007d->IL0026: Incompatible stack heights: 1 vs 2
		//IL_009f->IL0026: Incompatible stack heights: 5 vs 2
		//IL_00fb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00aa->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0065->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00cf->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0106->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00da->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				return;
			case 4:
				return;
			case 2:
				string.Format((IFormatProvider?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (string)P_0, (object?[])((_003C_003Ef__AnonymousType0<>)this).GetHashCode());
				_ = 5;
				continue;
			case 6:
				_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
				_003C_003Ef__AnonymousType0<>.ReflectJoinedTree();
				_ = 4;
				if (_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic != null)
				{
					_ = 3;
				}
				continue;
			case 5:
				return;
			case 1:
				if ((nint)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance >= 47)
				{
					obj2 = 0;
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.StoreConverter == null)
					{
						obj2 = 0;
					}
					continue;
				}
				goto case 2;
			}
			if (((_003C_003Ef__AnonymousType3<, >)this)._003Centry_003Ei__Field >= (object)340)
			{
				((_003C_003Ef__AnonymousType0<>)P_0)._002Ector((_003Caction_003Ej__TPar)this);
				((EqualityComparer<_00210>)/*Error near IL_005a: Stack underflow*/).GetHashCode((_00210)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
				_ = 3;
				continue;
			}
			obj2 = 6;
			if (_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument == null)
			{
				obj2 = 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00휀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0057: Expected I4, but got Obj
		//IL_0071: Expected VT, but got Obj
		//IL_0071: Expected VT, but got Ref
		//IL_0073: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got VT
		//IL_015b: Expected Obj, but got I8
		//IL_0103: Expected VT, but got Obj
		//IL_0103: Expected VT, but got Ref
		//IL_0106: Expected Obj, but got I8
		//IL_0087->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0165->IL0026: Incompatible stack types: I4 vs Obj
		//IL_011a->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00b5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a4->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0092->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0125->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0146->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0189->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0151->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0194->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 7;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				obj = ((EqualityComparer<_00210>)/*Error near IL_0071: Stack underflow*/).Equals((_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00210?)P_0);
				_ = 6;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					_ = 10;
				}
				break;
			case 3:
			case 5:
			case 10:
				((_003C_003Ef__AnonymousType0<>)obj).ToString();
				_ = 8;
				break;
			case 7:
				_ = ((_003C_003Ef__AnonymousType2<, , , >)this)._003Cpayload_003Ei__Field;
				obj2 = 6;
				break;
			case 4:
				obj = (((EqualityComparer<_00212>)/*Error near IL_0103: Stack underflow*/).Equals((_00212?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00212?)P_0) ? 1 : 0);
				_ = 2;
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance == null)
				{
					_ = 3;
				}
				break;
			case 6:
				if ((nint)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectLocalTemplate >= 47)
				{
					obj2 = 0;
					if ((int)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_defaultTimeout != 0)
					{
						obj2 = 2;
					}
					break;
				}
				goto case 4;
			case 8:
				return;
			case 1:
				obj = (long)((_003C_003Ef__AnonymousType2<, , , >)P_0).url;
				obj2 = 5;
				break;
			case 2:
			case 9:
				if ((nint)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_ascii_68FF03FEFFFF87FEFFFF07 < 340)
				{
					obj2 = 1;
					if (((EntitySocks5Account)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.GuideMap).Username__BackingField != null)
					{
						obj2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778005, new IntPtr(2737368318348L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal long _FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_001b: Expected I8, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (long)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778004, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778007, new IntPtr(2737368314188L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FFFD(long P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got I8
		//IL_004e: Expected Obj, but got VT
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
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
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FFFD(long P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778006, new IntPtr(2737368321468L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
