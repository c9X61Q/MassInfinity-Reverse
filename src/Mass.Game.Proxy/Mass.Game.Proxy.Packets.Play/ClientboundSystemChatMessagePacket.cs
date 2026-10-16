using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Network.Component.Chat;
using Mass.Game.Proxy.Network.Interface;
using Mass.Game.Proxy.Network.Nbt;
using Mass.Game.Proxy.Network.Packet;

namespace Mass.Game.Proxy.Packets.Play;

[PacketVersion(EnumProtocolVersion.V1206, 108)]
[Packet(EnumConnectionState.Play, EnumPacketDirection.Clientbound)]
[PacketVersion(EnumProtocolVersion.V1211, 108)]
[PacketVersion(EnumProtocolVersion.V1201, 100)]
public class ClientboundSystemChatMessagePacket : IPacket, IBufferCodec, IBufferSerializable, IBufferDeserializable
{
	private static object? GetCache;

	public NbtTag? NbtContent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (NbtTag?)관();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			됀(value);
		}
	}

	public string? Content
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string?)똀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			꼀(value);
		}
	}

	public bool Overlay
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 넀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			ꠀ(value ? ((byte)1) : ((byte)0));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe ClientboundSystemChatMessagePacket(EnumProtocolVersion version)
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
	public unsafe ClientboundSystemChatMessagePacket(EnumProtocolVersion version, TextComponent text)
	{
		//IL_001b: Expected VT, but got I4
		//IL_002a: Expected Obj, but got VT
		//IL_00ce: Expected VT, but got Obj
		//IL_00ce: Expected VT, but got Obj
		//IL_00ce: Expected Obj, but got Ref
		//IL_00d3: Expected Obj, but got I4
		//IL_0077->IL0043: Incompatible stack heights: 5 vs 2
		//IL_00dd->IL0043: Incompatible stack types: I4 vs Ref
		ref readonly _003Caction_003Ej__TPar reference = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType0<>)this)._002Ector((_003Caction_003Ej__TPar)version);
		int num = 0;
		if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				((_003C_003Ef__AnonymousType0<>)(object)text).ToString();
				_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
				_ = 2;
				break;
			default:
				if (version < EnumProtocolVersion.V1206)
				{
					num = 3;
					if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field != 0)
					{
						num = 3;
					}
					break;
				}
				goto case 1;
			case 4:
				return;
			case 2:
				return;
			case 3:
			{
				bool flag = ((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_00d3: Stack underflow*/).Equals((object)((EqualityComparer<_00212>)Unsafe.AsPointer(ref reference)).Equals((_00212?)this, (_00212?)text));
				num = 4;
				reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
				break;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Read(IByteBuffer buffer)
	{
		ꘀ(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(IByteBuffer buffer)
	{
		_AB00(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Handle(Connection connection)
	{
		return ꨀ(connection) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DisableUser()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ClientboundSystemChatMessagePacket? ReflectStatelessDispatcher()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte ꈀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777471, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte ꌀ()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object? ꐀ()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object? ꔀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777470, new IntPtr(2737368302748L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void ꘀ(object? P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00d3: Expected Obj, but got VT
		//IL_00d8: Expected Obj, but got I4
		//IL_00a2: Invalid comparison between VT and I4
		//IL_00ee: Expected Obj, but got I4
		//IL_0102: Expected Obj, but got VT
		//IL_004f: Expected VT, but got Obj
		//IL_004f: Expected VT, but got Obj
		//IL_004f: Expected Obj, but got Ref
		//IL_0054: Expected Obj, but got I4
		//IL_00e2->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0107->IL0026: Incompatible stack heights: 6 vs 2
		//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0068->IL0026: Incompatible stack types: I4 vs Ref
		//IL_00bb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0112->IL0026: Incompatible stack heights: 6 vs 2
		//IL_0073->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0073->IL0026: Incompatible stack types: I4 vs Ref
		//IL_00c6->IL0026: Incompatible stack types: I4 vs Obj
		ref readonly _003Caction_003Ej__TPar reference = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
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
			case 5:
			{
				bool flag = ((_003C_003Ef__AnonymousType0<>)/*Error near IL_0054: Stack underflow*/).Equals((object)((EqualityComparer<_00210>)Unsafe.AsPointer(ref reference)).Equals((_00210?)this, (_00210?)P_0));
				obj2 = 4;
				reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
				{
					obj2 = 4;
					reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
				}
				continue;
			}
			case 1:
				if (((_003C_003Ef__AnonymousType2<, , , >)this)._003Cuser_id_003Ei__Field >= (object)766)
				{
					obj2 = 0;
					if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field != 0)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
			default:
				((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType1<, , >)P_0).Equals((object)((_003C_003Ef__AnonymousType3<, >)this)._003Csid_003Ei__Field)).GetHashCode();
				_ = 5;
				continue;
			case 2:
				break;
			case 4:
				return;
			}
			((_003C_003Ef__AnonymousType1<, , >)32767).ToString();
			_003C_003Ef__AnonymousType1<, , >.ReflectScalableStack();
			_ = 2;
			if (!_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_hasTimeout)
			{
				_ = 3;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _A700(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777465, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void ꠀ(byte P_0)
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
	internal unsafe void _꤀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777464, new IntPtr(2737368322508L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed byte ꨀ(object? P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004b: Expected I4, but got Obj
		//IL_005b: Invalid comparison between VT and I4
		//IL_0114: Expected VT, but got Obj
		//IL_0114: Expected Obj, but got Ref
		//IL_00c7: Expected Obj, but got VT
		//IL_00ec: Expected VT, but got Obj
		//IL_00ec: Expected VT, but got Ref
		//IL_00f3: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got VT
		//IL_00db->IL0026: Incompatible stack heights: 3 vs 2
		//IL_00fd->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0074->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e6->IL0026: Incompatible stack heights: 3 vs 2
		//IL_009a->IL0026: Incompatible stack heights: 4 vs 2
		//IL_00ab->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007f->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				if (((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field < (object)766)
				{
					obj2 = 1;
					if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 4;
			case 5:
				return 0;
			default:
				if (obj == null)
				{
					obj2 = 5;
					break;
				}
				_ = ((_003C_003Ef__AnonymousType2<, , , >)P_0)._003Curl_003Ei__Field;
				obj = new { };
				_ = 3;
				break;
			case 4:
				obj = ((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType0<>.ReflectJoinedTree()).name;
				_ = 0;
				if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field == 0)
				{
					_ = 0;
				}
				break;
			case 1:
			case 6:
				((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_00ec: Stack underflow*/)._002Ector((_003Cname_003Ej__TPar)/*Error near IL_00ec: Stack underflow*/, (_003Cuuid_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_003Cuser_id_003Ej__TPar)this);
				obj = ((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_00f1: Stack underflow*/).Equals((object)/*Error near IL_00f1: Stack underflow*/);
				_ = 7;
				break;
			case 3:
				return (byte)((EqualityComparer<_00211>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).GetHashCode((_00211)obj);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _AB00(object? P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00c9: Expected VT, but got Obj
		//IL_00c9: Expected Obj, but got Ref
		//IL_008f: Expected Obj, but got VT
		//IL_00b8: Expected Obj, but got I4
		//IL_0105->IL0026: Incompatible stack heights: 5 vs 2
		//IL_00de->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0094->IL0026: Incompatible stack heights: 5 vs 2
		//IL_00e9->IL0026: Incompatible stack heights: 1 vs 2
		//IL_009f->IL0026: Incompatible stack heights: 5 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 5;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					return;
				case 0:
					return;
				case 4:
					((_003C_003Ef__AnonymousType0<>)this).GetHashCode();
					_ = ((_003C_003Ef__AnonymousType2<, , , >)this)._003Curl_003Ei__Field;
					_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
					_ = 1;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Ccontext_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
					{
						_ = 1;
					}
					continue;
				case 5:
					if ((nint)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic < 766)
					{
						break;
					}
					goto end_IL_0026;
				case 1:
				case 3:
					((EqualityComparer<_00212>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals((_00212?)P_0, (_00212?)((_003C_003Ef__AnonymousType1<, , >)this).user_id);
					_ = 0;
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance == null)
					{
						_ = 0;
					}
					continue;
				case 2:
					break;
				}
				((_003C_003Ef__AnonymousType1<, , >)this).ToString();
				_ = 32767;
				_003C_003Ef__AnonymousType1<, , >.ReflectScalableStack();
				_ = 3;
				continue;
				end_IL_0026:
				break;
			}
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? 가()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777467, new IntPtr(2737368326668L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object? 관()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? 글()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777466, new IntPtr(2737368315228L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 꼀(object? P_0)
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
	internal unsafe byte 뀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777461, new IntPtr(2737368325628L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte 넀()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (byte)(int)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte 눀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777460, new IntPtr(2737368320428L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 대(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777463, new IntPtr(2737368331868L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 됀(object? P_0)
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
	internal unsafe void 딀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777462, new IntPtr(2737368316268L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object? 똀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? 뜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777457, new IntPtr(2737368325628L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}
}
