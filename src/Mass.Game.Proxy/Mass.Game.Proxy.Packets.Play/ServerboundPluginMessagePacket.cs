using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Network.Packet;
using Mass.Game.Proxy.Packets.Common;

namespace Mass.Game.Proxy.Packets.Play;

[Packet(EnumConnectionState.Play, EnumPacketDirection.Serverbound)]
[PacketVersion(EnumProtocolVersion.V1181, 10)]
[PacketVersion(EnumProtocolVersion.V1710, 23)]
[PacketVersion(EnumProtocolVersion.V1201, 13)]
[PacketVersion(EnumProtocolVersion.V1206, 18)]
[PacketVersion(EnumProtocolVersion.V1211, 18)]
[PacketVersion(EnumProtocolVersion.V1122, 9)]
[PacketVersion(EnumProtocolVersion.V189, 23)]
public class ServerboundPluginMessagePacket : PluginMessagePacket
{
	private static object CheckGroupedProgram;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ServerboundPluginMessagePacket(EnumProtocolVersion version)
	{
		//IL_001b: Expected VT, but got I4
		//IL_002a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType0<>)(object)this)._002Ector((_003Caction_003Ej__TPar)version);
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
	public ServerboundPluginMessagePacket(EnumProtocolVersion version, string channel, IByteBuffer data)
	{
		//IL_001b: Expected VT, but got I4
		//IL_002a: Expected Obj, but got VT
		//IL_006f: Expected Obj, but got VT
		//IL_0074->IL0043: Incompatible stack heights: 4 vs 2
		//IL_0091->IL0043: Incompatible stack heights: 4 vs 2
		//IL_007f->IL0043: Incompatible stack heights: 4 vs 2
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType0<>)(object)this)._002Ector((_003Caction_003Ej__TPar)version);
		int num = 0;
		if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				_ = ((_003C_003Ef__AnonymousType1<, , >)(object)data).name;
				_ = 2;
				continue;
			}
			((_003C_003Ef__AnonymousType0<>)(object)channel).ToString();
			_ = 1;
			if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field == 0)
			{
				_ = 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Handle(Connection connection)
	{
		return _FF00_FF00_FF00_2900(connection) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateAccessibleTemplate()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerboundPluginMessagePacket CancelStrategy()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_2500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777597, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_2600()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_2700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777596, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_2800()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_2900(object P_0)
	{
		//IL_0026: Expected Obj, but got VT
		//IL_0027: Expected I4, but got Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (byte)(int)string.Format((IFormatProvider?)((_003C_003Ef__AnonymousType1<, , >)P_0)._003Cuser_id_003Ei__Field, (string)(object)this, (object?[])new { });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_2A00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777599, new IntPtr(2737368320428L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}
}
