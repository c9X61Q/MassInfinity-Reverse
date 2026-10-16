using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using DotNetty.Buffers;
using Mass.Common.Helpers;
using Mass.Game.Proxy.Protocols.Heypixel.Clientbound;
using Mass.Game.Proxy.Protocols.Heypixel.Serverbound;
using MsgPack;

namespace Mass.Game.Proxy.Protocols.Heypixel;

public abstract class HeypixelPacket
{
	private static readonly BiDictionary<int, Type> Packets;

	internal static HeypixelPacket CheckBasicWorker;

	protected HeypixelProtocol Protocol
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (HeypixelProtocol)_2100();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			က(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe HeypixelPacket(HeypixelProtocol protocol)
	{
		//IL_001b: Expected VT, but got Obj
		//IL_0026: Expected VT, but got Obj
		//IL_0026: Expected Obj, but got Ref
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)protocol;
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

	static HeypixelPacket()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0091->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0143->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00b6->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0109->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0128->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0062->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00da->IL0012: Incompatible stack types: I4 vs Obj
		//IL_009c->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0114->IL0012: Incompatible stack types: I4 vs Obj
		//IL_006d->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00e5->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 0:
				return;
			case 6:
				RegisterPacket(114u, typeof(ClientboundSyncKeyPacket));
				obj2 = 0;
				if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_0662d18a5af34da596af03e5c9747188 != 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				RegisterPacket(3u, typeof(ServerboundCpsPacket));
				obj2 = 3;
				if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_2178df51e0904ba79c4c8361c94f54e5 == 0)
				{
					obj2 = 2;
				}
				break;
			case 3:
				RegisterPacket(5u, typeof(ServerboundUseItemPacket));
				obj2 = 2;
				break;
			case 7:
				RegisterPacket(2u, typeof(ServerboundTimestampPacket));
				obj2 = 1;
				if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_228869e18032416d9510771ae703f1fc == 0)
				{
					obj2 = 0;
				}
				break;
			case 4:
				RegisterPacket(1u, typeof(ServerboundReflectCheckPacket));
				obj2 = 0;
				if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_2a1899bbfd66432b9701165f32836e5c == 0)
				{
					obj2 = 7;
				}
				break;
			case 5:
				Packets = new BiDictionary<int, Type>();
				obj2 = 4;
				break;
			case 2:
				RegisterPacket(101u, typeof(ClientboundReflectCheckPacket));
				obj2 = 6;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void RegisterPacket(uint id, object type)
	{
		ༀ(id, type);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint GetId(object type)
	{
		return ᰀ(type);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Handle(HeypixelProtocol protocol, IByteBuffer buffer)
	{
		return ᤀ(protocol, buffer) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object? Create(object protocol, uint id)
	{
		return _1800(protocol, id);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Read(Unpacker unpacker)
	{
		_0B00(unpacker);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Write(Packer packer)
	{
		_0700(packer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Handle()
	{
		ᜀ();
	}

	public virtual byte[] Encode(byte[] input)
	{
		return input;
	}

	public virtual byte[] Decode(byte[] input)
	{
		return input;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetId()
	{
		return (int)Ḁ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Send()
	{
		_1400();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateReadableProvider()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HeypixelPacket SetParameter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _0600(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778372, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _0700(object P_0)
	{
		//IL_0019: Expected VT, but got Ref
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType0<>)/*Error near IL_0019: Stack underflow*/)._002Ector((_003Caction_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
		throw new EqualityComparer<_00210>((_00210)/*Error near IL_001e: Stack underflow*/);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void ࠀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778375, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _0900()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _0B00(object P_0)
	{
		//IL_0019: Expected VT, but got Ref
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType0<>)/*Error near IL_0019: Stack underflow*/)._002Ector((_003Caction_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
		throw new EqualityComparer<_00210>((_00210)/*Error near IL_001e: Stack underflow*/);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _0C00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778374, new IntPtr(2737367946284L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _0D00()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void _0E00(uint P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778369, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ༀ(uint P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0044: Expected VT, but got Obj
		//IL_0044: Expected Obj, but got I4
		//IL_0058->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0063->IL0026: Incompatible stack heights: 4 vs 2
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
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
				_ = _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
				((EqualityComparer<_00210>)P_0).GetHashCode((_00210)P_1);
				_ = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field != 0)
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
	protected void က(object P_0)
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
	protected unsafe void ᄀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778368, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void ጀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778371, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _1400()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_006a: Expected Obj, but got Ref
		//IL_007b: Expected Obj, but got VT
		//IL_0041: Expected VT, but got Ref
		//IL_0052: Expected Obj, but got VT
		//IL_0108: Expected VT, but got Obj
		//IL_010a: Expected Obj, but got I4
		//IL_0163: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got VT
		//IL_00e2: Expected VT, but got Obj
		//IL_00e2: Expected VT, but got Obj
		//IL_0057->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0062->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0189->IL0233: Incompatible stack heights: 0 vs 1
		//IL_00cf->IL008f: Incompatible stack heights: 2 vs 1
		//IL_00da->IL008f: Incompatible stack heights: 2 vs 1
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				obj = new EqualityComparer<_00210>((_00210?)/*Error near IL_0041: Stack underflow*/, (_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
				_ = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
				{
					_ = 0;
				}
				continue;
			case 2:
				return;
			}
			obj = string.Format((IFormatProvider?)/*Error near IL_006a: Stack underflow*/, (string)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (object?[])obj);
			int num = 4;
			if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 3:
					obj = ((_003C_003Ef__AnonymousType1<, , >)obj).name;
					_ = 1;
					if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field != 0)
					{
						_ = 1;
					}
					break;
				case 5:
					((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_00e2: Stack underflow*/)._002Ector((_003Cname_003Ej__TPar)/*Error near IL_00e2: Stack underflow*/, (_003Cuuid_003Ej__TPar)this, (_003Cuser_id_003Ej__TPar)obj);
					num = 0;
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance != null)
					{
						num = 0;
					}
					break;
				default:
					obj = ((EqualityComparer<_00211>)/*Error near IL_0108: Stack underflow*/).GetHashCode((_00211)obj);
					num = 3;
					if ((int)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_defaultTimeout == 0)
					{
						num = 2;
					}
					break;
				case 4:
					/*Error near IL_012b: Member reference must be method, but was: Field*/;
				case 1:
					((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_0153: Stack underflow*/)._002Ector((_003Curl_003Ej__TPar)/*Error near IL_0153: Stack underflow*/, (_003Cpayload_003Ej__TPar)/*Error near IL_0153: Stack underflow*/, (_003Ccontext_003Ej__TPar)/*Error near IL_0153: Stack underflow*/, ((_003C_003Ef__AnonymousType2<, , , >)this).user_id);
					((EqualityComparer<_00213>)/*Error near IL_0158: Stack underflow*/).Equals((_00213?)/*Error near IL_0158: Stack underflow*/, (_00213?)/*Error near IL_0158: Stack underflow*/);
					((_003C_003Ef__AnonymousType2<, , , >)((_003C_003Ef__AnonymousType2<, , , >)this).GetHashCode()).ToString();
					_ = ((Array)obj).Length + 1;
					_003C_003Ef__AnonymousType2<, , , >.CheckAccessibleObject();
					/*Error near IL_0170: Member reference must be method, but was: Field*/;
				case 2:
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void ᔀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778370, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void ᜀ()
	{
		//IL_0019: Expected VT, but got Ref
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType0<>)/*Error near IL_0019: Stack underflow*/)._002Ector((_003Caction_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
		throw new EqualityComparer<_00210>((_00210)/*Error near IL_001e: Stack underflow*/);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _1800(object P_0, uint P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_0079: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got Ref
		//IL_011d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0128->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				return null;
			default:
				string.Format((IFormatProvider?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (string)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter, (object?[])P_1);
				(new string[1])[0] = (string)P_0;
				/*Error near IL_0083: Member reference must be method, but was: Field*/;
			case 3:
				return null;
			case 1:
				obj2 = 0;
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectLocalTemplate == null)
				{
					obj2 = 0;
				}
				break;
			case 2:
				_ = _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.StoreConverter;
				/*Error near IL_012e: Member reference must be method, but was: Field*/;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte ᤀ(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004f: Expected I4, but got Obj
		//IL_01ea: Expected Obj, but got I4
		//IL_01f3: Expected Obj, but got I4
		//IL_0229: Expected VT, but got Obj
		//IL_0229: Expected VT, but got Obj
		//IL_0229: Expected Obj, but got Ref
		//IL_005c: Expected VT, but got Obj
		//IL_005c: Expected VT, but got Ref
		//IL_005e: Expected Obj, but got I4
		//IL_0196: Expected I4, but got Obj
		//IL_01b5: Expected Obj, but got VT
		//IL_01ba: Expected VT, but got Obj
		//IL_01ba: Expected VT, but got Obj
		//IL_01ba: Expected VT, but got Ref
		//IL_01c1: Expected Obj, but got I4
		//IL_00d7: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got VT
		//IL_0081: Expected I4, but got Obj
		//IL_01f8->IL0022: Incompatible stack heights: 3 vs 1
		//IL_0235->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0068->IL006c: Incompatible stack types: I4 vs Obj
		//IL_01a7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01d5->IL0026: Incompatible stack heights: 1 vs 2
		//IL_01e0->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00a1->IL006c: Incompatible stack heights: 2 vs 1
		//IL_00c9->IL006c: Incompatible stack heights: 4 vs 1
		//IL_00ea->IL0193: Incompatible stack heights: 0 vs 1
		//IL_00ac->IL006c: Incompatible stack heights: 2 vs 1
		//IL_00d4->IL006c: Incompatible stack heights: 4 vs 1
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 7:
				{
					obj = ((EqualityComparer<_00210>)/*Error near IL_005c: Stack underflow*/).Equals((_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00210?)obj);
					object obj3 = 2;
					while (true)
					{
						switch ((int)obj3)
						{
						case 1:
							((_003C_003Ef__AnonymousType0<>)/*Error near IL_008d: Stack underflow*/).Equals(obj);
							_ = 0;
							if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
							{
								_ = 0;
							}
							continue;
						case 2:
							_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
							_ = 1;
							if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Ccontext_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
							{
								_ = 0;
							}
							continue;
						default:
							obj = 1;
							obj = 3;
							obj3 = obj;
							continue;
						case 3:
							break;
						}
						break;
					}
					goto case 8;
				}
				case 1:
					/*Error near IL_016d: Member reference must be method, but was: Field*/;
				case 8:
					return (byte)(int)obj;
				case 3:
					if (obj != null)
					{
						obj2 = 6;
						continue;
					}
					goto case 5;
				case 5:
					return 0;
				case 6:
					((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_01ba: Stack underflow*/)._002Ector((_003Curl_003Ej__TPar)/*Error near IL_01ba: Stack underflow*/, (_003Cpayload_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_003Ccontext_003Ej__TPar)P_1, (_003Cuser_id_003Ej__TPar)((EntitySocks5Account)((_003C_003Ef__AnonymousType2<, , , >)P_0).context).Username__BackingField);
					obj = ((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_01bf: Stack underflow*/).Equals((object)/*Error near IL_01bf: Stack underflow*/);
					_ = 2;
					if (((EntitySocks5)EntitySocks5.Address__BackingField).Port__BackingField == 0)
					{
						_ = 1;
					}
					continue;
				case 4:
					/*Error near IL_01fa: Member reference must be method, but was: Field*/;
				case 2:
					((_003C_003Ef__AnonymousType3<, >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Centry_003Ej__TPar)obj, (_003Csid_003Ej__TPar)obj);
					obj = (object)/*Error near IL_022b: Stack underflow*/;
					_ = 4;
					continue;
				}
				break;
			}
			obj = _003C_003Ef__AnonymousType2<, , , >.CheckAccessibleObject();
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte ᨀ(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778397, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _1B00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778396, new IntPtr(2737367946284L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint ᰀ(object P_0)
	{
		//IL_001f: Expected VT, but got Obj
		//IL_001f: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (uint)((EqualityComparer<_00210>)_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field).GetHashCode((_00210)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint ᴀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778399, new IntPtr(2737367947324L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint Ḁ()
	{
		//IL_001a: Expected VT, but got Obj
		//IL_001a: Expected VT, but got Ref
		//IL_001f: Expected Obj, but got I4
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType0<>)/*Error near IL_001f: Stack underflow*/).Equals((object)((EqualityComparer<_00210>)/*Error near IL_001a: Stack underflow*/).Equals((_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00210?)this)) ? 1u : 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint ἀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778398, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe object _2000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778393, new IntPtr(2737367948364L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected object _2100()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}
}
