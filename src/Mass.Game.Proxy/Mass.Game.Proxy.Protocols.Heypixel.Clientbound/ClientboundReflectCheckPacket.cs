using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using Mass.Domain.Desktop.ValueObjects;
using MsgPack;

namespace Mass.Game.Proxy.Protocols.Heypixel.Clientbound;

public class ClientboundReflectCheckPacket : HeypixelPacket
{
	internal static ClientboundReflectCheckPacket? GuideVisitor;

	public Guid Guid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _EF00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_0900(value);
		}
	}

	public long Timestamp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _EB00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_F400(value);
		}
	}

	public EnumReflectCheck CheckType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _E900();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_F100(value);
		}
	}

	public string? ReflectCheckAction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string?)_FF00Ȁ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_F300(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClientboundReflectCheckPacket(HeypixelProtocol protocol)
	{
		//IL_001b: Expected VT, but got Obj
		//IL_002a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType0<>)(object)this)._002Ector((_003Caction_003Ej__TPar)protocol);
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
	public override void Read(Unpacker unpacker)
	{
		_FF00_0600(unpacker);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe override byte[] Decode(byte[] input)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 518, 1790779193, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779193, new IntPtr(2737367939004L), 15);
		}
		return (byte[])((delegate*<object, object, object>)obj)(this, input);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Handle()
	{
		_FE00();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool InstantiateWatcher()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ClientboundReflectCheckPacket? PatchElement()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe EnumReflectCheck _E800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779192, new IntPtr(2737367947324L), 15))(null, 0, new IntPtr(0L));
		return (EnumReflectCheck)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal EnumReflectCheck _E900()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (EnumReflectCheck)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe EnumReflectCheck _EA00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779195, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		return (EnumReflectCheck)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal long _EB00()
	{
		//IL_001b: Expected I8, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (long)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe long _EC00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779194, new IntPtr(2737367947324L), 15))(null, 0, new IntPtr(0L));
		return (long)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _ED00(object? P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0046: Expected VT, but got Obj
		//IL_0046: Expected Obj, but got Ref
		//IL_00af: Expected VT, but got Obj
		//IL_00af: Expected VT, but got Ref
		//IL_00bb: Expected Obj, but got I4
		//IL_0050->IL00a7: Incompatible stack heights: 0 vs 1
		//IL_00c5->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0064->IL0026: Incompatible stack heights: 1 vs 2
		//IL_006f->IL0026: Incompatible stack heights: 1 vs 2
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
				((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Caction_003Ej__TPar)this);
				if ((int)((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_004b: Stack underflow*/)._003Cuser_id_003Ei__Field != 0)
				{
					_ = 1;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
					{
						_ = 1;
					}
					break;
				}
				goto default;
			case 3:
				_ = ref obj;
				/*Error near IL_0095: Member reference must be method, but was: Field*/;
			default:
				return P_0;
			case 1:
				((_003C_003Ef__AnonymousType1<, , >)(object)(*(JsonConverter<>*)/*Error near IL_00af: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((_003Cname_003Ej__TPar)/*Error near IL_00af: Stack underflow*/, (_003Cuuid_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_003Cuser_id_003Ej__TPar)this);
				obj = ((_003C_003Ef__AnonymousType1<, , >)(object)(*(JsonConverter<>*)_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument)/*cast due to constrained. prefix*/).GetHashCode();
				_ = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? _EE00(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779189, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Guid _EF00()
	{
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (Guid)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Guid _F000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779188, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		return (Guid)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _F100(EnumReflectCheck P_0)
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
				((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
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
	internal unsafe void _F200(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779191, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _F300(object? P_0)
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
				((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
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
	internal void _F400(long P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got I8
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
				((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
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
	internal unsafe void _F500(long P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779190, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object? _F600()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object? _F700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779185, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FE00()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_006f: Expected I4, but got Obj
		//IL_022f: Expected Obj, but got I4
		//IL_012c: Expected Obj, but got I4
		//IL_013b: Expected Obj, but got VT
		//IL_0080: Expected VT, but got I
		//IL_0095: Expected Obj, but got VT
		//IL_0250: Expected I4, but got Obj
		//IL_00bc: Expected Obj, but got VT
		//IL_01ca: Invalid comparison between VT and I4
		//IL_01e2: Expected Obj, but got Ref
		//IL_01e4: Expected Obj, but got VT
		//IL_01f3: Expected Obj, but got I4
		//IL_0119: Expected Obj, but got Ref
		//IL_0191: Expected Obj, but got Ref
		//IL_0193: Expected Obj, but got I4
		//IL_01a2: Expected Obj, but got I
		//IL_01d8: Expected Obj, but got I4
		//IL_0239->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0140->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009a->IL0026: Incompatible stack heights: 3 vs 2
		//IL_018c->IL0026: Incompatible stack heights: 4 vs 2
		//IL_01c3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c1->IL0026: Incompatible stack heights: 3 vs 2
		//IL_01f8->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0125->IL0026: Incompatible stack heights: 1 vs 2
		//IL_01a7->IL0026: Incompatible stack heights: 1 vs 2
		//IL_014b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a5->IL0026: Incompatible stack heights: 3 vs 2
		//IL_025a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00cc->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0203->IL0026: Incompatible stack heights: 1 vs 2
		//IL_01b2->IL0026: Incompatible stack heights: 1 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 10;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 3:
					((object)new EqualityComparer<_00210>((_00210)__ldftn(_003C_003Ef__AnonymousType0<>._002Ector))).ToString();
					_ = 1;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field != 0)
					{
						_ = 1;
					}
					break;
				case 9:
					obj = _003C_003Ef__AnonymousType0<>.ReflectJoinedTree();
					_ = 0;
					if (_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic != null)
					{
						_ = 0;
					}
					break;
				case 14:
					obj = ((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).ToString();
					_ = 15;
					break;
				case 2:
					goto IL_0125;
				case 4:
				case 5:
				case 7:
				case 13:
				case 15:
					_ = ((_003C_003Ef__AnonymousType2<, , , >)obj).user_id;
					((_003C_003Ef__AnonymousType2<, , , >)obj).Equals((object)EqualityComparer<_00213>.Default);
					_ = 3;
					break;
				case 16:
					goto IL_018c;
				case 8:
				case 11:
					obj = _003C_003Ef__AnonymousType2<, , , >.DisableDecryptor();
					obj2 = 7;
					break;
				case 10:
					if (((_003C_003Ef__AnonymousType3<, >)(object)this).entry != (_003Centry_003Ej__TPar)(object)3)
					{
						goto end_IL_0026;
					}
					goto case 3;
				case 12:
					goto IL_01dd;
				default:
					obj = _003C_003Ef__AnonymousType3<, >.LoadCache();
					_ = 6;
					break;
				case 6:
					switch ((int)obj)
					{
					case 3:
						break;
					case 2:
						goto IL_0125;
					case 0:
						goto IL_018c;
					case 1:
						goto IL_01dd;
					default:
						goto IL_0250;
					}
					goto case 14;
				case 1:
					return;
					IL_0250:
					obj2 = 11;
					break;
					IL_01dd:
					obj = ((_003C_003Ef__AnonymousType3<, >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).sid;
					_ = 12;
					if (((EntityLaunchGameProxy)EntityLaunchGameProxy.GameType__BackingField).GameVersion__BackingField == EnumGameVersion.None)
					{
						_ = 13;
					}
					break;
					IL_018c:
					obj = ((_003C_003Ef__AnonymousType2<, , , >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).GetHashCode();
					_ = 4;
					if (((EntitySocks5)EntitySocks5.Port__BackingField).Account__BackingField != null)
					{
						_ = 1;
					}
					break;
					IL_0125:
					obj = _003C_003Ef__AnonymousType1<, , >.ReflectScalableStack();
					obj2 = 5;
					if (!_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_hasTimeout)
					{
						obj2 = 1;
					}
					break;
				}
				continue;
				end_IL_0026:
				break;
			}
			obj = 9;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779184, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00Ā()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object? _FF00Ȁ()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_0300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779187, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00Ѐ()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003e: Expected VT, but got Obj
		//IL_003e: Expected Obj, but got Ref
		//IL_004f: Expected Obj, but got I4
		//IL_0067: Expected Obj, but got VT
		//IL_0078: Expected Obj, but got I4
		//IL_008c->IL0026: Incompatible stack heights: 7 vs 2
		//IL_0097->IL0026: Incompatible stack heights: 7 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
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
			{
				((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Caction_003Ej__TPar)this);
				_ = new
				{
					value = (object)/*Error near IL_0043: Stack underflow*/
				};
				((_003C_003Ef__AnonymousType0<>)((_003C_003Ef__AnonymousType0<>)(object)this).GetHashCode()).ToString();
				bool flag = _003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
				object obj2 = _003C_003Ef__AnonymousType0<>.ReflectJoinedTree();
				_003Cuuid_003Ej__TPar uuid = ((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType1<, , >)(object)this).name).uuid;
				((_003C_003Ef__AnonymousType1<, , >)obj2)._002Ector((_003Cname_003Ej__TPar)uuid, uuid, ((_003C_003Ef__AnonymousType1<, , >)(object)this).user_id);
				((_003C_003Ef__AnonymousType1<, , >)flag).Equals(obj2);
				_ = 0;
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectLocalTemplate == null)
				{
					_ = 0;
				}
				break;
			}
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00Ԁ(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779186, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_0600(object? P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00d7: Expected Obj, but got I4
		//IL_0090: Invalid comparison between VT and I4
		//IL_00bc: Expected VT, but got I4
		//IL_00bc: Expected VT, but got Obj
		//IL_00bc: Expected VT, but got Obj
		//IL_00bc: Expected Obj, but got Ref
		//IL_004f: Expected VT, but got Obj
		//IL_0054: Expected Obj, but got Ref
		//IL_00e1->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0089->IL0026: Incompatible stack heights: 6 vs 2
		//IL_00cb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00cb->IL0026: Incompatible stack types: I4 vs Ref
		//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0068->IL0026: Incompatible stack types: I4 vs Ref
		//IL_00a9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0073->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0073->IL0026: Incompatible stack types: I4 vs Ref
		//IL_00b4->IL0026: Incompatible stack types: I4 vs Obj
		ref readonly _003Caction_003Ej__TPar reference = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 5:
			{
				((_003C_003Ef__AnonymousType0<>)(object)this)._002Ector((_003Caction_003Ej__TPar)P_0);
				bool flag2 = ((_003C_003Ef__AnonymousType0<>)/*Error near IL_0054: Stack underflow*/).Equals((object)Unsafe.AsPointer(ref reference));
				obj2 = 1;
				reference = ref *(flag2 ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
				{
					obj2 = 0;
					reference = ref *(flag2 ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
				}
				break;
			}
			case 2:
				_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
				_003C_003Ef__AnonymousType0<>.ReflectJoinedTree();
				_ = 5;
				break;
			case 1:
				if (((_003C_003Ef__AnonymousType1<, , >)(object)this).name != (_003Cname_003Ej__TPar)(object)3)
				{
					return;
				}
				obj2 = 0;
				if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field == 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
			{
				((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref reference))._002Ector((_003Cname_003Ej__TPar)this, (_003Cuuid_003Ej__TPar)P_0, (_003Cuser_id_003Ej__TPar)0);
				bool flag = ((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_00c1: Stack underflow*/).Equals((object)/*Error near IL_00c1: Stack underflow*/);
				obj2 = 2;
				reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
				break;
			}
			default:
				((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType1<, , >)P_0).GetHashCode()).ToString();
				_ = 4;
				break;
			case 4:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_0700(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779149, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ࠀ(Guid P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779148, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_0900(Guid P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
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
				((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
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
	internal unsafe void _FF00_0A00(Guid P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779151, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
