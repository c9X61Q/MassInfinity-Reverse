using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using DotNetty.Buffers;
using Mass.Application.Event;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Minecraft.Events;
using Mass.Game.Proxy.Network.Interface;
using Mass.Game.Proxy.Network.Packet;

namespace Mass.Game.Proxy.Packets.Play;

[PacketVersion(EnumProtocolVersion.V1206, 66)]
[Packet(EnumConnectionState.Play, EnumPacketDirection.Clientbound)]
public class ClientboundRemoveEntitiesPacket : IPacket, IBufferCodec, IBufferSerializable, IBufferDeserializable
{
	private static object DecorateConfigurableMapper;

	public List<int> EntityIds
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return this._FF00_FFFD();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_E400(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe ClientboundRemoveEntitiesPacket(EnumProtocolVersion version)
	{
		//IL_001a: Expected VT, but got Obj
		//IL_001a: Expected VT, but got Ref
		//IL_001f: Expected VT, but got Obj
		//IL_0039: Expected Obj, but got VT
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_001f: Stack underflow*/)._003Cuser_id_003Ei__Field = (_003Cuser_id_003Ej__TPar)new EqualityComparer<_00210>((_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00210?)this);
		base.ToString();
		int num = 0;
		if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field == 0)
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
		this._FF00_FFFD((object)buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(IByteBuffer buffer)
	{
		_FF00_E000(buffer);
	}

	public bool Handle(Connection connection)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectSeparatedPolicy()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ClientboundRemoveEntitiesPacket AssetStack()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<int> _FF00휀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777739, new IntPtr(2737368328748L), 15))(null, 0, new IntPtr(0L));
		return (List<int>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<int> _FF00_FFFD()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (List<int>)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FFFD(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777738, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FFFD(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_00a7: Expected Obj, but got VT
		//IL_005a: Expected I4, but got Obj
		//IL_005a: Expected Obj, but got I
		//IL_006e: Expected Obj, but got VT
		//IL_0091->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ac->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0073->IL0026: Incompatible stack heights: 5 vs 2
		//IL_00b7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007e->IL0026: Incompatible stack heights: 5 vs 2
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
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
			case 3:
				_ = ((_003C_003Ef__AnonymousType1<, , >)obj)._003Cuuid_003Ei__Field;
				((EventBus)obj).Register((Action<EventMinecraft>)__ldftn(_003C_003Ef__AnonymousType0<>.Equals), (int)new object());
				_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
				_ = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Ccontext_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			case 1:
				_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic = P_0;
				obj2 = 3;
				break;
			case 2:
				obj = new { };
				obj2 = 1;
				if (_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument == null)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FFFD(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777733, new IntPtr(2737368329788L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777732, new IntPtr(2737368320428L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FFFD()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777735, new IntPtr(2737368331868L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FFFD(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777734, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_E000(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_004d: Expected Obj, but got VT
		//IL_005a: Expected Obj, but got I
		//IL_005a: Expected Obj, but got I4
		//IL_005f: Expected I4, but got Obj
		//IL_005f: Expected Obj, but got Ref
		//IL_0072: Expected VT, but got Obj
		//IL_0081: Expected Obj, but got VT
		//IL_00a7: Expected Obj, but got VT
		//IL_006a->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0086->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ac->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0091->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b7->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				((EventBus)/*Error near IL_005f: Stack underflow*/).Register((Action<EventConnectServer>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (int)new string((IFormatProvider?)((_003C_003Ef__AnonymousType0<>)((_003C_003Ef__AnonymousType1<, , >)obj)._003Cuuid_003Ei__Field).Equals(this), (string)obj, (object?[])__ldftn(_003C_003Ef__AnonymousType0<>.GetHashCode)));
				_ = 3;
				break;
			case 1:
				((_003C_003Ef__AnonymousType2<, , , >)obj)._003Ccontext_003Ei__Field = (_003Ccontext_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic != null)
				{
					obj2 = 0;
				}
				break;
			case 2:
				obj = new { };
				obj2 = 1;
				if (_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument != null)
				{
					obj2 = 1;
				}
				break;
			case 3:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_E100(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777729, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_E200()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777728, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_E300()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_E400(List<int> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got Obj
		//IL_004f: Expected Obj, but got VT
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
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
			case 0:
				return;
			case 1:
				((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_E500(List<int> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777731, new IntPtr(2737368320428L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
