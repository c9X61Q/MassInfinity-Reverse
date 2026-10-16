using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Network.Interface;
using Mass.Game.Proxy.Network.Packet;

namespace Mass.Game.Proxy.Packets.Status;

[PacketAllVersion(0)]
[Packet(EnumConnectionState.Status, EnumPacketDirection.Serverbound)]
public class ServerboundStatusRequestPacket : IPacket, IBufferCodec, IBufferSerializable, IBufferDeserializable
{
	internal static ServerboundStatusRequestPacket DecorateGeneralTransmitter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe ServerboundStatusRequestPacket(EnumProtocolVersion version)
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

	public void Read(IByteBuffer buffer)
	{
	}

	public void Write(IByteBuffer buffer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Handle(Connection connection)
	{
		return _FF00_FF00_FF00쨀(connection) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NewBridge()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerboundStatusRequestPacket CheckCommand()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed byte _FF00_FF00_FF00준(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779052, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed byte _FF00_FF00_FF00쨀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0082: Expected Obj, but got VT
		//IL_0087: Expected Obj, but got VT
		//IL_008e: Expected VT, but got Obj
		//IL_008e: Expected VT, but got Obj
		//IL_0046: Expected Obj, but got VT
		//IL_0055: Expected Obj, but got VT
		//IL_00a1: Expected Obj, but got VT
		//IL_00ad: Expected VT, but got Obj
		//IL_00ad: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got VT
		//IL_00c9: Expected Obj, but got I4
		//IL_00d1: Expected VT, but got Obj
		//IL_00d1: Expected VT, but got Obj
		//IL_00d2: Invalid comparison between VT and Obj
		//IL_00dc: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got VT
		//IL_00e2: Expected VT, but got I4
		//IL_00fd: Expected Obj, but got VT
		//IL_0109: Expected Obj, but got I4
		//IL_0109: Expected Obj, but got VT
		//IL_010e: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I4
		//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009c->IL009c: Incompatible stack heights: 3 vs 4
		//IL_0065->IL0026: Incompatible stack types: I4 vs Obj
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
			case 2:
				return 1;
			case 1:
				obj = ((_003C_003Ef__AnonymousType1<, , >)P_0)._003Cuuid_003Ei__Field;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
				{
					obj2 = 0;
				}
				continue;
			}
			_003Curl_003Ej__TPar val = ((_003C_003Ef__AnonymousType2<, , , >)this)._003Curl_003Ei__Field;
			var anon = (_003C_003Ef__AnonymousType0<>)new { };
			((_003C_003Ef__AnonymousType1<, , >)(object)anon)._002Ector((_003Cname_003Ej__TPar)anon, (_003Cuuid_003Ej__TPar)((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType0<>.ReflectJoinedTree()).name).uuid).user_id, (_003Cuser_id_003Ej__TPar)obj);
			if ((int)val == 0)
			{
				((_003C_003Ef__AnonymousType1<, , >)1).Equals(obj);
			}
			((EqualityComparer<_00212>)((_003C_003Ef__AnonymousType1<, , >)val).GetHashCode()).GetHashCode((_00212)((_003C_003Ef__AnonymousType1<, , >)obj).ToString());
			_003Cpayload_003Ej__TPar payload = ((_003C_003Ef__AnonymousType2<, , , >)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.ReflectModularWriter()).url).payload;
			var anon2 = (_003C_003Ef__AnonymousType2<, , , >)new { };
			_003Cuser_id_003Ej__TPar user_id = ((_003C_003Ef__AnonymousType2<, , , >)1).user_id;
			anon2._002Ector((_003Curl_003Ej__TPar)anon2, (_003Cpayload_003Ej__TPar)user_id, (_003Ccontext_003Ej__TPar)user_id, (_003Cuser_id_003Ej__TPar)obj);
			((_003C_003Ef__AnonymousType2<, , , >)new EqualityComparer<_00213>((_00213)((_003C_003Ef__AnonymousType2<, , , >)payload).Equals(payload != (_003Cpayload_003Ej__TPar)(object)null))).ToString();
			_003C_003Ef__AnonymousType2<, , , >.CheckAccessibleObject();
			((_003C_003Ef__AnonymousType3<, >)((_003C_003Ef__AnonymousType3<, >)((_003C_003Ef__AnonymousType3<, >)((_003C_003Ef__AnonymousType3<, >)new { }).entry).sid).Equals(((EntityLaunchGameProxy)this).GameType__BackingField)).GetHashCode();
			/*Error near IL_010e: Member reference must be method, but was: Field*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed byte _FF00_FF00_FF00쬀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779055, new IntPtr(2737368310028L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00찀()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00촀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779054, new IntPtr(2737368310028L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00츀()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00케()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779049, new IntPtr(2737368312108L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
