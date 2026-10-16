using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using DotNetty.Buffers;
using Mass.Application.Desktop;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Network.Interface;
using Mass.Game.Proxy.Network.Nbt;
using Mass.Game.Proxy.Network.Packet;

namespace Mass.Game.Proxy.Packets.Play;

[PacketVersion(EnumProtocolVersion.V1710, 45)]
[PacketVersion(EnumProtocolVersion.V189, 45)]
[Packet(EnumConnectionState.Play, EnumPacketDirection.Clientbound)]
[PacketVersion(EnumProtocolVersion.V1181, 46)]
[PacketVersion(EnumProtocolVersion.V1201, 48)]
[PacketVersion(EnumProtocolVersion.V1206, 51)]
[PacketVersion(EnumProtocolVersion.V1211, 51)]
[PacketVersion(EnumProtocolVersion.V1122, 19)]
public class ClientboundOpenWindowPacket : IPacket, IBufferCodec, IBufferSerializable, IBufferDeserializable
{
	internal static ClientboundOpenWindowPacket ReflectModularArgument;

	public int WindowId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_0D00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00ᴀ((uint)value);
		}
	}

	public int WindowType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00Ԁ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00ﴀ((uint)value);
		}
	}

	public string WindowTypeString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_0600();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00ᔀ(value);
		}
	}

	public string WindowTitle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00ጀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_1800(value);
		}
	}

	public NbtTag? NbtWindowTitle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (NbtTag?)_FF00_FF00_2200();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00(value);
		}
	}

	public byte NumberOfSlots
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00Ā();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_0B00(value);
		}
	}

	public bool UseProvidedWindowTitle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00ᄀ() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00ᨀ(value ? ((byte)1) : ((byte)0));
		}
	}

	public int EntityId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00ࠀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_0300((uint)value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe ClientboundOpenWindowPacket(EnumProtocolVersion version)
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
		_FF00_FF00_2300(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(IByteBuffer buffer)
	{
		_FF00_FF00_2000(buffer);
	}

	public bool Handle(Connection connection)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LeadController()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ClientboundOpenWindowPacket CollectFinder()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ﰀ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777768, new IntPtr(2737368315228L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00ﴀ(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got I4
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
	internal unsafe void _FF00_FE00(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777771, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got Obj
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
	internal byte _FF00_FF00Ā()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (byte)(int)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00Ȁ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777770, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_0300(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got I4
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
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
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
	internal unsafe void _FF00_FF00Ѐ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777765, new IntPtr(2737368321468L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00Ԁ()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (uint)(int)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_0600()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_0700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777764, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00ࠀ()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (uint)(int)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_0900()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777767, new IntPtr(2737368310028L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_0A00(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777766, new IntPtr(2737368325628L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_0B00(byte P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got I4
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
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_0C00(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777761, new IntPtr(2737368316268L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_0D00()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (uint)(int)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_0E00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777760, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00ༀ()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00က()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777763, new IntPtr(2737368326668L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00ᄀ()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (byte)(int)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00ሀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777762, new IntPtr(2737368328748L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00ጀ()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_1400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777789, new IntPtr(2737368307948L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00ᔀ(object P_0)
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
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00ᘀ()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00ᜀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777788, new IntPtr(2737368305868L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_1800(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got Obj
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
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
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
	internal unsafe void _FF00_FF00ᤀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777791, new IntPtr(2737368314188L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00ᨀ(byte P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got I4
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
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_1B00(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777790, new IntPtr(2737368310028L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00ᰀ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777785, new IntPtr(2737368308988L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00ᴀ(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got I4
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
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
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
	internal unsafe void _FF00_FF00Ḁ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777784, new IntPtr(2737368333948L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_2000(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_00a7: Expected I4, but got Obj
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Invalid comparison between Unknown and I4
		//IL_0497: Expected Obj, but got Ref
		//IL_03a8: Expected Obj, but got I4
		//IL_03b2: Expected Obj, but got I4
		//IL_0127: Expected VT, but got Obj
		//IL_0127: Expected VT, but got Obj
		//IL_0127: Expected VT, but got Ref
		//IL_0131: Expected Obj, but got I4
		//IL_03c3: Expected Obj, but got I4
		//IL_03c3: Expected Obj, but got Ref
		//IL_035a: Expected I4, but got Obj
		//IL_0211: Expected Obj, but got Ref
		//IL_024b: Expected Obj, but got I4
		//IL_0376: Expected Obj, but got I4
		//IL_00df: Expected Obj, but got I4
		//IL_0405: Expected Obj, but got Ref
		//IL_02e5: Expected VT, but got Obj
		//IL_02ea: Expected VT, but got I4
		//IL_02ea: Expected Obj, but got Ref
		//IL_0200: Expected VT, but got Obj
		//IL_0200: Expected Obj, but got Ref
		//IL_00c4: Expected Obj, but got VT
		//IL_04a2->IL0026: Incompatible stack heights: 1 vs 2
		//IL_01dd->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0146->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0287->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03d8->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0431->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0120->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0365->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01c6->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0260->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0381->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0410->IL0026: Incompatible stack heights: 1 vs 2
		//IL_02ae->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02ff->IL0026: Incompatible stack heights: 1 vs 2
		//IL_023a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_020b->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0397->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0343->IL0026: Incompatible stack heights: 3 vs 2
		//IL_01f3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0151->IL0026: Incompatible stack heights: 1 vs 2
		//IL_03f9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0292->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03e3->IL0026: Incompatible stack heights: 1 vs 2
		//IL_043c->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00c9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0222->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0480->IL0026: Incompatible stack types: I4 vs Obj
		//IL_026b->IL0026: Incompatible stack heights: 4 vs 2
		//IL_02b9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_030a->IL0026: Incompatible stack heights: 1 vs 2
		//IL_034e->IL0026: Incompatible stack heights: 3 vs 2
		//IL_00d4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_048b->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 11;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 15:
					if ((nint)obj != 47)
					{
						obj2 = 6;
						if ((int)((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
						{
							obj2 = 5;
						}
						continue;
					}
					goto IL_0322;
				case 29:
					((_003C_003Ef__AnonymousType0<>)((_003C_003Ef__AnonymousType0<>)this).GetHashCode()).ToString();
					_ = 5;
					/*Error near IL_00e0: Member reference must be method, but was: Field*/;
				case 16:
					_ = ((_003C_003Ef__AnonymousType1<, , >)this).uuid;
					_ = EqualityComparer<_00212>.Default;
					_ = 30;
					continue;
				case 9:
					((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_0127: Stack underflow*/)._002Ector((_003Cname_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_003Cuuid_003Ej__TPar)P_0, (_003Cuser_id_003Ej__TPar)this);
					((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_0131: Stack underflow*/).Equals((object)32767);
					_ = 5;
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectLocalTemplate != null)
					{
						_ = 28;
					}
					continue;
				case 21:
					_003C_003Ef__AnonymousType1<, , >.ReflectScalableStack();
					/*Error near IL_0158: Member reference must be method, but was: Field*/;
				case 23:
					_ = ((_003C_003Ef__AnonymousType2<, , , >)this).context;
					/*Error near IL_0184: Member reference must be method, but was: Field*/;
				case 24:
					((_003C_003Ef__AnonymousType2<, , , >)this).GetHashCode();
					_ = ((EntitySocks5)this).Port__BackingField;
					_003C_003Ef__AnonymousType2<, , , >.CheckAccessibleObject();
					_ = 22;
					continue;
				case 7:
					_ = ((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DisableDecryptor()).entry;
					_ = 9;
					continue;
				case 6:
					if ((nint)obj != 340)
					{
						obj2 = 2;
						continue;
					}
					goto IL_0322;
				case 18:
					return;
				case 19:
					if ((((_003C_003Ef__AnonymousType3<, >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals(this) ? 1 : 0) == 11)
					{
						_ = 17;
						continue;
					}
					return;
				case 1:
					if (obj - 766 > 1)
					{
						obj2 = 27;
						continue;
					}
					((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).TryMatchAtCurrentPosition((ReadOnlySpan<char>)((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)P_0).TryFindNextPossibleStartingPosition((ReadOnlySpan<char>)this));
					_ = 7;
					if (((GameProxy)GameProxy.Name__BackingField).Session__BackingField != null)
					{
						_ = 13;
					}
					continue;
				case 25:
					((_003C_003Ef__AnonymousType3<, >)this).GetHashCode();
					((_003C_003Ef__AnonymousType3<, >)32767).ToString();
					_ = 3;
					if (((EntityLaunchGameProxy)EntityLaunchGameProxy.ServerAddress__BackingField).ServerPort__BackingField != 0)
					{
						_ = 16;
					}
					continue;
				case 11:
					obj = ((EntityLaunchGameProxy)this).Socks5__BackingField;
					obj2 = 10;
					if (((EntityLaunchGameProxy)EntityLaunchGameProxy.Value__BackingField).IsGame__BackingField == 0)
					{
						obj2 = 10;
					}
					continue;
				default:
					if ((nint)obj != 5)
					{
						obj2 = 15;
						if (((GameProxy)(object)EntityLaunchGameProxy.ReflectAlphabeticProcessor)._003Cargs_003EP == null)
						{
							obj2 = 3;
						}
						continue;
					}
					goto case 21;
				case 28:
					return;
				case 22:
					return;
				case 2:
				case 27:
					/*Error near IL_030b: Member reference must be method, but was: Field*/;
				case 14:
					return;
				case 17:
					((StringBuilder)P_0).Append((char)(int)((EntitySocks5Account)this).EqualityContract);
					obj2 = 14;
					continue;
				case 26:
					((EntitySocks5Account)P_0).Username = (string)(object)this;
					_ = ((EntitySocks5Account)32767).Password;
					obj2 = 4;
					continue;
				case 3:
				case 8:
					if ((nint)obj != 757)
					{
						obj2 = 20;
						continue;
					}
					goto IL_01f4;
				case 5:
					break;
				case 12:
					((EqualityComparer<string>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).GetHashCode((string)((EntitySocks5Account)P_0).PrintMembers((StringBuilder)(object)this));
					_ = 11;
					if (((GameProxy)GameProxy.AcceptorGroup__BackingField)._channel == null)
					{
						_ = 25;
					}
					continue;
				case 10:
					if ((nint)obj > 340)
					{
						obj2 = 8;
						continue;
					}
					goto default;
				case 30:
					int.TryParse((string?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), out *(((EntitySocks5Account)P_0).Equals((object?)this) ? ((int*)1) : ((int*)null)));
					_ = 19;
					continue;
				case 13:
					((EntitySocks5Account)P_0)._002Ector(((EntitySocks5Account)this)._003CClone_003E_0024());
					_ = 6;
					if (GameProxy._003C_003EO._003C1_003E__OnConnectServer != null)
					{
						_ = 24;
					}
					continue;
				case 20:
					if ((nint)obj != 763)
					{
						obj2 = 1;
						if (((GameProxy._003CListenAsync_003Ed__69)GameProxy._003CListenAsync_003Ed__69._003C_003Et__builder)._003C_003E4__this == null)
						{
							obj2 = 0;
						}
						continue;
					}
					goto IL_01f4;
				case 4:
					{
						((EntitySocks5)P_0).Address = (string)(object)this;
						((EqualityComparer<DesktopSession>)/*Error near IL_0497: Stack underflow*/).GetHashCode((DesktopSession)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
						_ = 29;
						continue;
					}
					IL_0322:
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities._002Ecctor();
					AppContext.GetData((string)(object)this);
					_ = 2;
					if (((GameProxy)GameProxy.ModHashList__BackingField).ServerAddress__BackingField == null)
					{
						_ = 5;
					}
					continue;
					IL_01f4:
					((_003C_003Ef__AnonymousType3<, >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Centry_003Ej__TPar)P_0, ((_003C_003Ef__AnonymousType3<, >)this).sid);
					_ = 7;
					continue;
				}
				break;
			}
			((EntitySocks5Account)P_0).Password = (string)(object)this;
			((EntitySocks5Account)32767).ToString();
			obj = 26;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_2100()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777787, new IntPtr(2737368314188L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_2200()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_2300(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_00ab: Expected I4, but got Obj
		//IL_00ec: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got VT
		//IL_02d5: Expected VT, but got Obj
		//IL_02d5: Expected Obj, but got Ref
		//IL_02d7: Invalid comparison between Unknown and I4
		//IL_0409: Expected Obj, but got Ref
		//IL_040e: Expected Obj, but got I4
		//IL_00b7: Expected VT, but got Obj
		//IL_00b7: Expected VT, but got Obj
		//IL_00b7: Expected Obj, but got Ref
		//IL_00bc: Expected Obj, but got I4
		//IL_02ed: Expected I4, but got Obj
		//IL_02ed: Expected I4, but got Obj
		//IL_02ca: Expected Obj, but got I4
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Invalid comparison between Unknown and I4
		//IL_015d: Expected Obj, but got I4
		//IL_0163: Expected VT, but got I4
		//IL_03e5: Expected Obj, but got I4
		//IL_0193: Expected Obj, but got I4
		//IL_0198: Expected Obj, but got VT
		//IL_01be: Expected VT, but got Obj
		//IL_01be: Expected VT, but got Obj
		//IL_01be: Expected Obj, but got Ref
		//IL_01c3: Expected Obj, but got I4
		//IL_01d2: Expected Obj, but got I
		//IL_0366: Expected Obj, but got I4
		//IL_0209: Expected Obj, but got I4
		//IL_020e: Expected VT, but got Obj
		//IL_00db: Expected Obj, but got I4
		//IL_0230: Expected Obj, but got I4
		//IL_026d: Expected Obj, but got I
		//IL_042d: Expected Obj, but got I4
		//IL_0177: Expected Obj, but got VT
		//IL_032e: Expected Obj, but got I4
		//IL_0105->IL0026: Incompatible stack heights: 5 vs 2
		//IL_03d0->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0256->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0418->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0418->IL0026: Incompatible stack types: I4 vs Ref
		//IL_028f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c6->IL0026: Incompatible stack types: I4 vs Ref
		//IL_01fd->IL0026: Incompatible stack heights: 6 vs 2
		//IL_02fc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02fc->IL0026: Incompatible stack types: I4 vs Ref
		//IL_02cf->IL0022: Incompatible stack heights: 2 vs 1
		//IL_039b->IL0151: Incompatible stack heights: 1 vs 0
		//IL_03ea->IL0022: Incompatible stack heights: 3 vs 1
		//IL_01ac->IL0026: Incompatible stack heights: 5 vs 2
		//IL_01d7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01d7->IL0026: Incompatible stack types: I4 vs Ref
		//IL_0370->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0218->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02b5->IL0026: Incompatible stack heights: 6 vs 2
		//IL_0110->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0396->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0235->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0272->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0354->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02e6->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0313->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0402->IL0026: Incompatible stack types: I4 vs Obj
		//IL_017c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0333->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01b7->IL0026: Incompatible stack heights: 5 vs 2
		//IL_01e2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01e2->IL0026: Incompatible stack types: I4 vs Ref
		//IL_0240->IL0026: Incompatible stack types: I4 vs Obj
		//IL_027d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0187->IL0026: Incompatible stack types: I4 vs Obj
		//IL_033e->IL0026: Incompatible stack types: I4 vs Obj
		ref readonly _003Caction_003Ej__TPar reference = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 14;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 15:
				{
					bool flag = ((_003C_003Ef__AnonymousType0<>)/*Error near IL_00bc: Stack underflow*/).Equals((object)((EqualityComparer<_00210>)Unsafe.AsPointer(ref reference)).Equals((_00210?)this, (_00210?)P_0));
					obj2 = 9;
					reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
					continue;
				}
				default:
					if ((nint)obj != 763)
					{
						obj = 20;
						break;
					}
					goto IL_029f;
				case 1:
					((_003C_003Ef__AnonymousType0<>)((_003C_003Ef__AnonymousType0<>)32767).GetHashCode()).ToString();
					_ = 11;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field != 0)
					{
						_ = 12;
					}
					continue;
				case 28:
					/*Error near IL_0121: Member reference must be method, but was: Field*/;
				case 31:
					return;
				case 17:
				case 24:
					throw new EqualityComparer<_00211>();
				case 21:
					return;
				case 22:
					if (((EqualityComparer<_00212>)(object)((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType1<, , >)this).GetHashCode()).ToString()).GetHashCode((_00212)5) == 0)
					{
						obj2 = 21;
						if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_hasTimeout)
						{
							obj2 = 21;
						}
						continue;
					}
					goto case 2;
				case 26:
					_ = ((_003C_003Ef__AnonymousType2<, , , >)((_003C_003Ef__AnonymousType2<, , , >)32767).payload).context;
					_ = 1;
					if (((EntitySocks5Account)EntitySocks5Account.Username__BackingField).Password__BackingField != null)
					{
						_ = 1;
					}
					continue;
				case 27:
				{
					int hashCode = ((_003C_003Ef__AnonymousType2<, , , >)((EqualityComparer<_00213>)Unsafe.AsPointer(ref reference)).Equals((_00213?)this, (_00213?)P_0)).GetHashCode();
					obj2 = 16;
					reference = ref *(_003Caction_003Ej__TPar*)hashCode;
					if (((EntitySocks5)EntitySocks5.Port__BackingField).Account__BackingField == null)
					{
						obj2 = 10;
						reference = ref *(_003Caction_003Ej__TPar*)hashCode;
					}
					continue;
				}
				case 16:
					_ = 32767;
					_ = ((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DisableDecryptor()).entry;
					_ = 28;
					continue;
				case 30:
					((_003C_003Ef__AnonymousType3<, >)this)._002Ector((_003Centry_003Ej__TPar)P_0, ((_003C_003Ef__AnonymousType3<, >)32767).sid);
					obj2 = 8;
					continue;
				case 3:
					if ((nint)obj != 47)
					{
						obj2 = 0;
						if (((EntityLaunchGameProxy)EntityLaunchGameProxy.GameVersion__BackingField).ModHashList__BackingField == null)
						{
							obj2 = 7;
						}
						continue;
					}
					goto IL_0380;
				case 6:
					((_003C_003Ef__AnonymousType3<, >)P_0).ToString();
					_003C_003Ef__AnonymousType3<, >.LoadCache();
					_ = 30;
					continue;
				case 4:
					if ((nint)obj != 5)
					{
						obj2 = 2;
						if (((EntityLaunchGameProxy)EntityLaunchGameProxy.ServerPort__BackingField).Socks5__BackingField == null)
						{
							obj2 = 3;
						}
						continue;
					}
					goto case 25;
				case 14:
					obj = ((EntityLaunchGameProxy)this).Value__BackingField;
					obj2 = 13;
					continue;
				case 5:
					return;
				case 19:
					((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory)(object)((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory)P_0).CreateInstance())._002Ector();
					obj = 29;
					break;
				case 9:
					((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)Unsafe.AsPointer(ref reference)).Scan((ReadOnlySpan<char>)this);
					if ((int)/*Error near IL_02dc: Stack underflow*/ != 11)
					{
						return;
					}
					_ = 18;
					continue;
				case 18:
				{
					((RegexRunner)/*Error near IL_02ed: Stack underflow*/).Capture((int)Unsafe.AsPointer(ref reference), (int)this, (int)P_0);
					byte b = ((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)/*Error near IL_02f2: Stack underflow*/).TryMatchAtCurrentPosition((ReadOnlySpan<char>)/*Error near IL_02f2: Stack underflow*/);
					obj2 = 10;
					reference = ref *(_003Caction_003Ej__TPar*)b;
					continue;
				}
				case 8:
					return;
				case 11:
					((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)P_0)._002Ector();
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.VerifyVerifier();
					_ = 19;
					continue;
				case 23:
					if ((nint)obj != 757)
					{
						obj2 = 0;
						if (((GameProxy)GameProxy.GameType__BackingField).GameId__BackingField == null)
						{
							obj2 = 0;
						}
						continue;
					}
					goto IL_029f;
				case 7:
					if ((nint)obj != 340)
					{
						obj2 = 17;
						continue;
					}
					goto IL_0380;
				case 29:
					((EntitySocks5Account)P_0)._002Ector((string)((GameProxy)this).GameVersion__BackingField, (string)(object)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.PatchWatcher());
					_ = 31;
					continue;
				case 10:
					return;
				case 2:
					((EntitySocks5Account)(object)EqualityComparer<Type>.Default).ToString();
					_ = 5;
					continue;
				case 25:
					_ = (EntitySocks5Account?)P_0 != (EntitySocks5Account?)(object)EqualityComparer<string>.Default;
					obj = 27;
					break;
				case 20:
					if (obj - 766 > 1)
					{
						goto case 17;
					}
					obj2 = 11;
					continue;
				case 12:
				{
					int hashCode2 = ((EntitySocks5Account)((EqualityComparer<string>)Unsafe.AsPointer(ref reference)).Equals((string?)(object)this, (string?)P_0)).GetHashCode();
					obj2 = 22;
					reference = ref *(_003Caction_003Ej__TPar*)hashCode2;
					continue;
				}
				case 13:
					{
						if ((nint)obj <= 340)
						{
							obj = 4;
							break;
						}
						goto case 23;
					}
					IL_029f:
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectSymbolicAuditor();
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.DecorateConfigurableDecider();
					_ = 6;
					continue;
					IL_0380:
					_ = ((EntitySocks5Account)(object)((StringBuilder)(object)this).Append((string?)P_0)).Username;
					_ = 26;
					continue;
				}
				break;
			}
		}
	}
}
