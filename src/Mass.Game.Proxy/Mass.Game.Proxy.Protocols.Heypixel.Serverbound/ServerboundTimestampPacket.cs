using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using MsgPack;

namespace Mass.Game.Proxy.Protocols.Heypixel.Serverbound;

public class ServerboundTimestampPacket : HeypixelPacket
{
	internal static ServerboundTimestampPacket FillReg;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ServerboundTimestampPacket(HeypixelProtocol protocol)
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
	public override void Write(Packer packer)
	{
		였(packer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SelectExecutor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerboundTimestampPacket ReflectSimpleAnnotation()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object 섀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778597, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 숀()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object 쌀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778596, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte 쐀()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte 씀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778599, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 였(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got Obj
		//IL_003f: Expected VT, but got Ref
		//IL_0041: Expected Obj, but got I4
		//IL_0048: Expected VT, but got Ref
		//IL_004d: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got VT
		//IL_0061->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0061->IL0026: Incompatible stack types: I4 vs Ref
		//IL_006c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006c->IL0026: Incompatible stack types: I4 vs Ref
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
			default:
				return;
			case 0:
				return;
			case 1:
			{
				obj = ((EqualityComparer<_00210>)/*Error near IL_003f: Stack underflow*/).Equals((_00210?)Unsafe.AsPointer(ref reference), (_00210?)P_0);
				int hashCode = ((_003C_003Ef__AnonymousType0<>)((EqualityComparer<_00210>)/*Error near IL_0048: Stack underflow*/).GetHashCode((_00210)(&obj))).GetHashCode();
				obj2 = 0;
				reference = ref *(_003Caction_003Ej__TPar*)hashCode;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field == 0)
				{
					obj2 = 0;
					reference = ref *(_003Caction_003Ej__TPar*)hashCode;
				}
				break;
			}
			}
		}
	}
}
