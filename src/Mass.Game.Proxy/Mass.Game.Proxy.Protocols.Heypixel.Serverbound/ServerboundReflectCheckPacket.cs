using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using DotNetty.Buffers;
using Mass.Application.Desktop;
using Mass.Application.Event;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Game.Proxy.Minecraft.Events;
using Mass.Game.Proxy.Network;
using Mass.Game.Proxy.Network.Nbt;
using Mass.Game.Proxy.Network.Packet;
using Mass.Game.Proxy.Protocols.Hyt;
using Mass.Game.Proxy.Protocols.Hyt.VexView;
using Mass.Game.Proxy.Protocols.OhMyGod;
using MsgPack;

namespace Mass.Game.Proxy.Protocols.Heypixel.Serverbound;

public class ServerboundReflectCheckPacket : HeypixelPacket
{
	internal static ServerboundReflectCheckPacket? RateAttribute;

	public EnumReflectCheck CheckType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _꤀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			뜀(value);
		}
	}

	public Guid Guid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 봀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			뼀(value);
		}
	}

	public long Timestamp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 뤀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			묀(value);
		}
	}

	public string? ReflectCheckAction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string?)글();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			가(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ServerboundReflectCheckPacket(HeypixelProtocol protocol)
	{
		//IL_001b: Expected VT, but got Obj
		//IL_002a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType0<>)(object)this)._002Ector((_003Caction_003Ej__TPar)protocol);
		int num = 0;
		if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
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
	public override void Write(Packer packer)
	{
		딀(packer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe override byte[] Encode(byte[] data)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 440, 1790778517, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778517, new IntPtr(2737367937964L), 15);
		}
		return (byte[])((delegate*<object, object, object>)obj)(this, data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectConnectedProcessor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerboundReflectCheckPacket? CheckAlphabeticContainer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte ꌀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778516, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte ꐀ()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte ꔀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778519, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object? ꘀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778518, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object? _A700()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object? ꠀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778513, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal EnumReflectCheck _꤀()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (EnumReflectCheck)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe EnumReflectCheck ꨀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778512, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (EnumReflectCheck)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _AB00(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778515, new IntPtr(2737367947324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 가(object? P_0)
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
	internal unsafe void 관(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778514, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object? 글()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? 꼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778605, new IntPtr(2737367947324L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object? 뀀(object? P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0044: Expected VT, but got Obj
		//IL_004e: Expected Ref, but got VT
		//IL_0050: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got VT
		//IL_00b7: Expected Obj, but got VT
		//IL_0064->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00bc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006f->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00c7->IL0026: Incompatible stack types: I4 vs Obj
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
				return P_0;
			case 2:
				_ = ref obj;
				/*Error near IL_0071: Member reference must be method, but was: Field*/;
			case 1:
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.StoreConverter != null)
				{
					((_003C_003Ef__AnonymousType0<>)(object)Unsafe.As<_003Caction_003Ej__TPar, Enum>(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)/*cast due to constrained. prefix*/)._002Ector((_003Caction_003Ej__TPar)this);
					obj = ((_003C_003Ef__AnonymousType0<>)(object)(*(Enum*)((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_0049: Stack underflow*/)._003Cuser_id_003Ei__Field)/*cast due to constrained. prefix*/).GetHashCode();
					_ = 1;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field == 0)
					{
						_ = 2;
					}
				}
				else
				{
					obj2 = 0;
					if (!_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_hasTimeout)
					{
						obj2 = 0;
					}
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 됀(object? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778604, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 딀(object? P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_00e3: Expected I4, but got Obj
		//IL_010b: Expected Obj, but got I4
		//IL_050f: Expected I4, but got Obj
		//IL_0420: Expected Obj, but got I4
		//IL_0425: Expected Obj, but got Ref
		//IL_04c2: Expected Obj, but got F8
		//IL_04c9: Expected Obj, but got I4
		//IL_04ce: Expected Obj, but got I4
		//IL_04ce: Expected Obj, but got Ref
		//IL_061f: Expected Obj, but got I4
		//IL_0550: Expected Obj, but got I4
		//IL_0555: Expected I4, but got Obj
		//IL_0555: Expected Obj, but got Ref
		//IL_03f0: Expected Obj, but got I4
		//IL_03f0: Expected Obj, but got Ref
		//IL_03f5: Expected Obj, but got I4
		//IL_0669: Expected Obj, but got I4
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Expected Obj, but got Unknown
		//IL_05e8: Expected I4, but got Obj
		//IL_05ed: Expected Obj, but got Ref
		//IL_058e: Expected Obj, but got Ref
		//IL_0227: Expected VT, but got I4
		//IL_0227: Expected VT, but got Obj
		//IL_0227: Expected VT, but got Ref
		//IL_0694: Expected Obj, but got I4
		//IL_0699: Expected Obj, but got Ref
		//IL_069e: Expected Obj, but got I4
		//IL_0208: Expected Obj, but got I4
		//IL_0715: Expected Obj, but got I4
		//IL_06c8: Expected Obj, but got I4
		//IL_06ce: Expected Obj, but got I4
		//IL_012b: Expected Obj, but got VT
		//IL_0608: Expected Obj, but got I4
		//IL_04e4: Expected Obj, but got I4
		//IL_04ee: Expected Obj, but got I4
		//IL_04ee: Expected Obj, but got Ref
		//IL_01d7: Expected Obj, but got VT
		//IL_0729: Expected Obj, but got I4
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected Obj, but got Unknown
		//IL_056b: Expected Obj, but got I4
		//IL_00ef: Expected VT, but got Obj
		//IL_00f4: Expected Obj, but got Ref
		//IL_00f9: Expected Obj, but got VT
		//IL_0754: Expected Obj, but got I4
		//IL_018c: Expected VT, but got Obj
		//IL_018c: Expected VT, but got Ref
		//IL_0198: Expected Obj, but got I4
		//IL_046b: Expected Obj, but got I4
		//IL_0708->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0115->IL0026: Incompatible stack types: I4 vs Obj
		//IL_043e->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0657->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04d8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04d8->IL0026: Incompatible stack types: I4 vs Ref
		//IL_0629->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0564->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0564->IL0026: Incompatible stack types: Obj vs Ref
		//IL_0409->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0409->IL0026: Incompatible stack types: I4 vs Ref
		//IL_067d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06e8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0640->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05c5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0601->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0601->IL0026: Incompatible stack types: Obj vs Ref
		//IL_05e1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05a2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05a2->IL0026: Incompatible stack types: Obj vs Ref
		//IL_017a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0220->IL0026: Incompatible stack types: I4 vs Obj
		//IL_023b->IL0026: Incompatible stack heights: 1 vs 2
		//IL_06a8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06a8->IL0026: Incompatible stack types: Obj vs Ref
		//IL_0212->IL0026: Incompatible stack types: I4 vs Obj
		//IL_071f->IL0026: Incompatible stack heights: 3 vs 2
		//IL_06d8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0130->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0612->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04f8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04f8->IL0026: Incompatible stack types: Obj vs Ref
		//IL_01e1->IL0026: Incompatible stack heights: 4 vs 2
		//IL_073d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0458->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01cb->IL0026: Incompatible stack heights: 5 vs 2
		//IL_03ca->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0575->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0108->IL0026: Incompatible stack heights: 1 vs 2
		//IL_076f->IL0026: Incompatible stack heights: 5 vs 2
		//IL_01ac->IL0026: Incompatible stack heights: 1 vs 2
		//IL_047f->IL0026: Incompatible stack heights: 4 vs 2
		//IL_04a6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0581->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0519->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0150->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0414->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0414->IL0026: Incompatible stack types: I4 vs Ref
		//IL_0688->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0539->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05d0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05ad->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05ad->IL0026: Incompatible stack types: Obj vs Ref
		//IL_0185->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0246->IL0026: Incompatible stack heights: 1 vs 2
		//IL_013b->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0748->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0463->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03d5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01b7->IL0026: Incompatible stack heights: 1 vs 2
		//IL_048a->IL0026: Incompatible stack heights: 4 vs 2
		//IL_04b1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0544->IL0026: Incompatible stack types: I4 vs Obj
		ref readonly _003Caction_003Ej__TPar reference = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 30;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 44:
				((_003C_003Ef__AnonymousType0<>)P_0)._002Ector((_003Caction_003Ej__TPar)this);
				((EventBus)/*Error near IL_00fe: Stack underflow*/).Register((Action<EventMinecraft>)/*Error near IL_00fe: Stack underflow*/, ((_003C_003Ef__AnonymousType0<>)((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref reference))._003Cuser_id_003Ei__Field).GetHashCode());
				_ = 11;
				break;
			case 2:
				obj = 0;
				obj2 = 12;
				break;
			case 31:
				_ = 0;
				_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
				_ = 1;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Ccontext_003Ei__Field)._003Cuser_id_003Ei__Field != 0)
				{
					_ = 1;
				}
				break;
			case 8:
			case 12:
				if ((nint)obj >= ((Array)obj).Length)
				{
					return;
				}
				obj2 = 26;
				break;
			case 21:
			case 26:
				obj = ((object[])obj)[obj];
				obj2 = 38;
				if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field == 0)
				{
					obj2 = 45;
				}
				break;
			case 41:
				return;
			case 37:
				_ = ((Array)obj).Length;
				_003C_003Ef__AnonymousType1<, , >.ReflectModularWriter();
				_ = 17;
				break;
			case 34:
				_ = ((_003C_003Ef__AnonymousType2<, , , >)((_003C_003Ef__AnonymousType2<, , , >)(object)this).url).payload;
				_ = 39;
				break;
			case 28:
				obj = 0;
				obj2 = 15;
				break;
			case 22:
				obj = obj;
				obj2 = 2;
				break;
			case 25:
				((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_0227: Stack underflow*/)._002Ector((_003Curl_003Ej__TPar)/*Error near IL_0227: Stack underflow*/, (_003Cpayload_003Ej__TPar)Unsafe.AsPointer(ref reference), (_003Ccontext_003Ej__TPar)P_0, (_003Cuser_id_003Ej__TPar)0);
				_ = 23;
				if (((EntitySocks5)EntitySocks5Account.AttachElement).Address__BackingField != null)
				{
					_ = 12;
				}
				break;
			case 24:
				/*Error near IL_0247: Member reference must be method, but was: Field*/;
			case 39:
				obj = ((EntitySocks5Account)(object)this).EqualityContract;
				obj2 = 2;
				if (((GameProxy)GameProxy.TransferServerAddress__BackingField).TransferServerPort__BackingField == 0)
				{
					obj2 = 3;
				}
				break;
			case 10:
			{
				bool flag2 = (EntitySocks5Account?)/*Error near IL_03f5: Stack underflow*/ == (EntitySocks5Account?)((EqualityComparer<string>)Unsafe.AsPointer(ref reference)).GetHashCode((string)((EntitySocks5Account)P_0).PrintMembers((StringBuilder)(object)((EntitySocks5Account)(object)((GameProxy)(object)((EntitySocks5Account)(object)this).Password).Socks5).ToString()));
				obj2 = 0;
				reference = ref *(flag2 ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
				if (((GameProxy)GameProxy._channel).DisplayAddress__BackingField != null)
				{
					obj2 = 0;
					reference = ref *(flag2 ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
				}
				break;
			}
			case 4:
				((EntitySocks5Account)Unsafe.AsPointer(ref reference))._002Ector((EntitySocks5Account)((GameProxy)((EntitySocks5Account)P_0).Equals((EntitySocks5Account?)(object)this))._connection);
				((EntitySocks5Account)/*Error near IL_042a: Stack underflow*/).Deconstruct(out *(string*)/*Error near IL_042a: Stack underflow*/, out *(string*)/*Error near IL_042a: Stack underflow*/);
				((EqualityComparer<int>)/*Error near IL_042f: Stack underflow*/).GetHashCode((int)/*Error near IL_042f: Stack underflow*/);
				EntitySocks5Account.RunWriter();
				_ = 10;
				break;
			case 36:
				obj++;
				obj2 = 5;
				if ((int)((GameProxy._003CListenAsync_003Ed__69*)GameProxy._003CListenAsync_003Ed__69._003C_003E1__state)->_003C_003Et__builder != 0)
				{
					obj2 = 8;
				}
				break;
			case 42:
				return;
			case 23:
				return;
			case 6:
			{
				bool flag = (EntitySocks5?)Unsafe.AsPointer(ref reference) == (EntitySocks5?)((EntitySocks5?)((EntitySocks5)P_0).PrintMembers((StringBuilder)((CpsDetector)(object)EntitySocks5.Parse((string?)(object)this))._lastLeftCps) != (EntitySocks5?)obj);
				obj2 = 36;
				reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
				break;
			}
			case 33:
			{
				Optional<byte[]> optional2 = ((IByteBuffer)(object)Unsafe.AsPointer(ref reference)).ReadOptional((Func<IByteBuffer, byte[]>)((EntitySocks5)P_0).Equals((EntitySocks5?)OhMyGodEncryption.DecorateEfficientEmitter));
				obj2 = 44;
				reference = ref *(_003Caction_003Ej__TPar*)optional2;
				break;
			}
			case 3:
				switch ((int)obj)
				{
				case 0:
					((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_018c: Stack underflow*/)._002Ector((_003Cname_003Ej__TPar)/*Error near IL_018c: Stack underflow*/, (_003Cuuid_003Ej__TPar)Unsafe.AsPointer(ref reference), (_003Cuser_id_003Ej__TPar)this);
					obj = ((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument).GetHashCode();
					_ = 24;
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.StoreConverter == null)
					{
						_ = 37;
					}
					break;
				case 1:
					_ = ((EntitySocks5)(-1)).Address;
					_ = 23;
					if ((int)((GameProxy._003CListenAsync_003Ed__69*)GameProxy._003CListenAsync_003Ed__69.port)->_003C_003Eu__1 != 0)
					{
						_ = 32;
					}
					break;
				case 2:
					((EntitySocks5)P_0).Port = 0;
					obj2 = 40;
					if (((CpsDetector)CpsDetector._lock)._leftClicks == null)
					{
						obj2 = 8;
					}
					break;
				default:
					obj2 = 41;
					break;
				case 3:
					obj2 = 24;
					break;
				}
				break;
			case 38:
				return;
			case 15:
			case 16:
				if ((nint)obj < ((Array)obj).Length)
				{
					obj2 = 40;
					if (OhMyGodHwid._003C_003EO._003C0_003E__GenerateRandomMac != null)
					{
						obj2 = 43;
					}
					break;
				}
				goto case 4;
			case 9:
			{
				((EntityLaunchGameProxy)/*Error near IL_0555: Stack underflow*/)._002Ector((DesktopSession)/*Error near IL_0555: Stack underflow*/, (string)/*Error near IL_0555: Stack underflow*/, (EnumGameType)/*Error near IL_0555: Stack underflow*/, (EnumGameVersion)/*Error near IL_0555: Stack underflow*/, (string)Unsafe.AsPointer(ref reference), (string)P_0, (string)(object)this, (int)OhMyGodHwid._003C_003EO._003C2_003E__GenerateRandomDiskStoreInfo);
				Optional<NbtTag> optional = ((IByteBuffer)/*Error near IL_055a: Stack underflow*/).ReadOptional((Func<IByteBuffer, NbtTag>)/*Error near IL_055a: Stack underflow*/);
				obj2 = 27;
				reference = ref *(_003Caction_003Ej__TPar*)optional;
				break;
			}
			case 40:
				_ = ((EntityLaunchGameProxy)0).Session;
				_ = 31;
				break;
			case 1:
				return;
			case 20:
			{
				((EntityLaunchGameProxy)P_0).Session = (DesktopSession)obj;
				string gameId = ((EntityLaunchGameProxy)Unsafe.AsPointer(ref reference)).GameId;
				obj2 = 1;
				reference = ref *(_003Caction_003Ej__TPar*)gameId;
				if (((HytMainMenu.Menu)HytMainMenu.Menu.Name).Description == null)
				{
					obj2 = 5;
					reference = ref *(_003Caction_003Ej__TPar*)gameId;
				}
				break;
			}
			case 17:
				obj = obj;
				obj2 = 28;
				if (((HytMainMenu._003C_003Ec__DisplayClass2_0)HytMainMenu.Menu.CustomizeTemplate).minecraft == null)
				{
					obj2 = 8;
				}
				break;
			case 19:
			case 43:
				obj = ((object[])obj)[obj];
				obj2 = 20;
				break;
			case 18:
			{
				((EntityLaunchGameProxy)P_0).GameVersion = (EnumGameVersion)(int)this;
				((EntityLaunchGameProxy)/*Error near IL_05f2: Stack underflow*/).ModHashList = (string)(object)((HytMainMenu._003C_003Ec__DisplayClass2_1)Unsafe.AsPointer(ref reference)).menu;
				IByteBuffer val = ((IByteBuffer)/*Error near IL_05f7: Stack underflow*/).WriteMap((Dictionary<string, List<int>>)/*Error near IL_05f7: Stack underflow*/, (Action<string>)/*Error near IL_05f7: Stack underflow*/, (Action<List<int>>)/*Error near IL_05f7: Stack underflow*/);
				obj2 = 33;
				reference = ref *(_003Caction_003Ej__TPar*)val;
				break;
			}
			case 32:
				((EntityLaunchGameProxy)P_0).Name = (string)0;
				obj2 = 25;
				break;
			case 7:
				((EntityLaunchGameProxy)(object)((EntityLaunchGameProxy)(object)this).ServerAddress).ServerAddress = (string)1;
				_ = 34;
				break;
			case 14:
				((EntityLaunchGameProxy)P_0).ServerPort = ((EntityLaunchGameProxy)obj).ServerPort;
				obj2 = 13;
				break;
			case 5:
				((EntityLaunchGameProxy)P_0).Socks5 = ((EntityLaunchGameProxy)obj).Socks5;
				obj2 = 14;
				break;
			case 11:
				obj = ((EntityLaunchGameProxy)((VexViewGuiPacket)(object)((EntityLaunchGameProxy)(object)this).Value).Base__BackingField).IsGame;
				obj2 = 34;
				if (((VexViewPacket)VexViewPacket.PacketType__BackingField).PacketSubType__BackingField == null)
				{
					obj2 = 35;
				}
				break;
			case 27:
			{
				IEnumerable<PacketVersionAttribute> customAttributes = ((MemberInfo)((EntityLaunchGameProxy?)Unsafe.AsPointer(ref reference) == (EntityLaunchGameProxy?)VexViewPacket.DecorateInternalChain)).GetCustomAttributes<PacketVersionAttribute>();
				obj2 = 18;
				reference = ref *(_003Caction_003Ej__TPar*)customAttributes;
				break;
			}
			case 30:
				((EntityLaunchGameProxy)EnumReflectCheck.BlackModules)._003CClone_003E_0024()._002Ector((EntityLaunchGameProxy)1);
				obj2 = 29;
				break;
			case 13:
				obj++;
				obj2 = 16;
				break;
			default:
				((EntityLaunchGameProxy)/*Error near IL_06ef: Stack underflow*/).Deconstruct(out *(DesktopSession*)/*Error near IL_06ef: Stack underflow*/, out *(string*)/*Error near IL_06ef: Stack underflow*/, out *(EnumGameType*)/*Error near IL_06ef: Stack underflow*/, out *(EnumGameVersion*)/*Error near IL_06ef: Stack underflow*/, out *(string*)/*Error near IL_06ef: Stack underflow*/, out Unsafe.As<_003Caction_003Ej__TPar, string>(ref reference), out *(string*)P_0, out *(int*)this);
				_ = ((HeypixelHwid)/*Error near IL_06f4: Stack underflow*/).ClassesCount__BackingField;
				((MemberInfo)(object)EntityLaunchGameProxy.DecorateLogicalConverter()).GetCustomAttribute<JsonPropertyNameAttribute>();
				_ = 9;
				break;
			case 29:
				((GameProxy)(object)this).ConnectionChanged += (Action<GameProxy>?)(byte)GameProxy.Logger;
				_ = 7;
				break;
			case 35:
				((GameProxy)P_0).ConnectionChanged -= (Action<GameProxy>?)((Array)obj).Length;
				obj2 = 22;
				if (((HeypixelHwid)HeypixelHwid.DiskInfo__BackingField).UserListInfo__BackingField == null)
				{
					obj2 = 14;
				}
				break;
			case 45:
				_ = ((GameProxy)(object)((HeypixelHwid)((GameProxy)(object)this).GameType).UserInfo__BackingField).GameVersion;
				_ = ((GameProxy)(object)((GameProxy)obj).ModHashList).ServerAddress;
				_ = 6;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 똀(EnumReflectCheck P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778607, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 뜀(EnumReflectCheck P_0)
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
	internal unsafe void 렀(EnumReflectCheck P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778606, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal long 뤀()
	{
		//IL_001b: Expected I8, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (long)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe long 먀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778601, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (long)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 묀(long P_0)
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
	internal unsafe void 밀(long P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778600, new IntPtr(2737367947324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Guid 봀()
	{
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (Guid)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Guid 븀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778603, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (Guid)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 뼀(Guid P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
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
	internal unsafe void 쀀(Guid P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778602, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
