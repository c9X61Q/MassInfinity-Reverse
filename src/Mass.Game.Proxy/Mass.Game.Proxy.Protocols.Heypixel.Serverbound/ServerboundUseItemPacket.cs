using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using MsgPack;

namespace Mass.Game.Proxy.Protocols.Heypixel.Serverbound;

public class ServerboundUseItemPacket : HeypixelPacket
{
	public double X;

	public double Y;

	public double Z;

	public int Face;

	public int Sequence;

	public double LocationX;

	public double LocationY;

	public double LocationZ;

	public double BlockX;

	public double BlockY;

	public double BlockZ;

	public bool InsideBlock;

	public float PlayerYaw;

	public float PlayerPitch;

	public bool IsHand;

	internal static ServerboundUseItemPacket DecorateControllableComparator;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ServerboundUseItemPacket(HeypixelProtocol protocol)
	{
		//IL_001b: Expected VT, but got I4
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)1;
		((_003C_003Ef__AnonymousType0<>)(object)this).Equals((object)protocol);
		int num = 0;
		if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field != 0)
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
		찀(packer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateTransferableBridge()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerboundUseItemPacket FlushFunction()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object 윀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778598, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 저()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object 준()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778593, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte 쨀()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte 쬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778592, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 찀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_006b: Expected I4, but got Obj
		//IL_007c: Expected Obj, but got VT
		//IL_0118: Expected Obj, but got VT
		//IL_01b1: Expected Obj, but got I4
		//IL_0145: Expected VT, but got Obj
		//IL_0145: Expected VT, but got Obj
		//IL_0145: Expected VT, but got Ref
		//IL_00d3: Expected VT, but got Obj
		//IL_00d3: Expected VT, but got Ref
		//IL_0107: Expected Obj, but got I4
		//IL_01dc: Expected Obj, but got I
		//IL_01e5: Expected Obj, but got I4
		//IL_0221: Expected VT, but got Obj
		//IL_00bd: Expected Obj, but got VT
		//IL_017a->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0090->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0256->IL0026: Incompatible stack heights: 5 vs 2
		//IL_00b1->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0122->IL0026: Incompatible stack heights: 4 vs 2
		//IL_01c5->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0138->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0159->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00e7->IL0026: Incompatible stack heights: 1 vs 2
		//IL_020a->IL0026: Incompatible stack heights: 5 vs 2
		//IL_010c->IL0022: Incompatible stack heights: 4 vs 1
		//IL_01ea->IL0022: Incompatible stack heights: 2 vs 1
		//IL_0235->IL0026: Incompatible stack types: I4 vs Obj
		//IL_019a->IL0026: Incompatible stack heights: 4 vs 2
		//IL_00c7->IL0026: Incompatible stack heights: 4 vs 2
		//IL_009b->IL0026: Incompatible stack heights: 3 vs 2
		//IL_01d0->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0164->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00f2->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0215->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0240->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01a5->IL0026: Incompatible stack heights: 4 vs 2
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
				case 1:
					((_003C_003Ef__AnonymousType0<>)P_0).Equals((object)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field);
					_ = 15;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
					{
						_ = 11;
					}
					continue;
				case 3:
					_ = ((_003C_003Ef__AnonymousType2<, , , >)(object)this)._003Cpayload_003Ei__Field;
					_003C_003Ef__AnonymousType0<>.ReflectJoinedTree();
					_ = 14;
					continue;
				case 15:
					_ = ((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType2<, , , >)(object)this)._003Cuser_id_003Ei__Field).uuid;
					_ = 8;
					continue;
				case 9:
					((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_00d3: Stack underflow*/)._002Ector((_003Cname_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_003Cuuid_003Ej__TPar)P_0, (_003Cuser_id_003Ej__TPar)((_003C_003Ef__AnonymousType3<, >)(object)this)._003Centry_003Ei__Field);
					_ = 4;
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance == null)
					{
						_ = 3;
					}
					continue;
				case 11:
					_ = _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectLocalTemplate;
					_003C_003Ef__AnonymousType1<, , >.ReflectScalableStack();
					obj = 10;
					break;
				case 5:
					_ = ((_003C_003Ef__AnonymousType2<, , , >)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_defaultTimeout).url;
					_ = 2;
					continue;
				case 7:
					_ = ((_003C_003Ef__AnonymousType2<, , , >)(object)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_ascii_68FF03FEFFFF87FEFFFF07).context;
					_ = 12;
					continue;
				case 4:
					return;
				case 8:
					((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_0145: Stack underflow*/)._002Ector((_003Curl_003Ej__TPar)/*Error near IL_0145: Stack underflow*/, (_003Cpayload_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_003Ccontext_003Ej__TPar)P_0, (_003Cuser_id_003Ej__TPar)((EntitySocks5Account)(object)this).Username__BackingField);
					_ = 1;
					if (((EntitySocks5)EntitySocks5Account.AttachElement).Address__BackingField != null)
					{
						_ = 3;
					}
					continue;
				default:
					_ = ((EntitySocks5)(object)this).Port__BackingField;
					_003C_003Ef__AnonymousType2<, , , >.CheckAccessibleObject();
					_ = 9;
					continue;
				case 14:
					_ = ((_003C_003Ef__AnonymousType3<, >)EntitySocks5.DecorateDynamicModule).entry;
					_ = 7;
					if (((EntityLaunchGameProxy)EntityLaunchGameProxy.GameId__BackingField).GameType__BackingField != 0)
					{
						_ = 5;
					}
					continue;
				case 6:
					((_003C_003Ef__AnonymousType3<, >)((EntityLaunchGameProxy)(object)this).GameVersion__BackingField).GetHashCode();
					_ = 13;
					if (((EntityLaunchGameProxy)EntityLaunchGameProxy.Name__BackingField).ServerAddress__BackingField == null)
					{
						_ = 7;
					}
					continue;
				case 12:
					((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0)((EntityLaunchGameProxy)(object)this).ServerPort__BackingField)._002Ector();
					obj = 5;
					break;
				case 10:
					_ = ((EntityLaunchGameProxy)(object)this).Value__BackingField;
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectSymbolicAuditor();
					_ = 0;
					if (((GameProxy)(object)EntityLaunchGameProxy.ReflectAlphabeticProcessor)._003Cargs_003EP != null)
					{
						_ = 1;
					}
					continue;
				case 13:
					((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)P_0).Scan((ReadOnlySpan<char>)GameProxy.Logger__BackingField);
					obj2 = 0;
					if (GameProxy.OnlineClients == null)
					{
						obj2 = 0;
					}
					continue;
				case 2:
					_ = ((GameProxy)(object)this).Name__BackingField;
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.VerifyVerifier();
					_ = 6;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 촀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778595, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
