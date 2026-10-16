using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using DotNetty.Buffers;

namespace Mass.Game.Proxy.Protocols.Germ.Serverbound;

public class GermGuiClickDown : GermPacket
{
	private static object SaveEvent;

	public string Type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00䀀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00䠀(value);
		}
	}

	public string Top
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00㸀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00䤀(value);
		}
	}

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00䴀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00䄀(value);
		}
	}

	public int Action
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00刀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00㬀((uint)value);
		}
	}

	public int X
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00唀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00嘀((uint)value);
		}
	}

	public int Y
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00䐀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00倀((uint)value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe GermGuiClickDown()
	{
		//IL_001b: Expected VT, but got Obj
		//IL_001b: Expected Obj, but got Ref
		//IL_0027: Expected VT, but got Obj
		//IL_0033: Expected VT, but got Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._003Cuser_id_003Ei__Field = (_003Cuser_id_003Ej__TPar)this;
		((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_0027: Stack underflow*/)._003Curl_003Ei__Field = (_003Curl_003Ej__TPar)this;
		((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_0033: Stack underflow*/)._003Ccontext_003Ei__Field = (_003Ccontext_003Ej__TPar)this;
		_ = ((_003C_003Ef__AnonymousType1<, , >)(object)this).name;
		int num = 0;
		if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field != 0)
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
	public unsafe GermGuiClickDown(string type, string top, string name, int action, int x, int y)
	{
		//IL_001b: Expected VT, but got Obj
		//IL_001b: Expected Obj, but got Ref
		//IL_0027: Expected VT, but got Obj
		//IL_0033: Expected VT, but got Obj
		//IL_00f8: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got VT
		//IL_0105: Expected Obj, but got I4
		//IL_00cb->IL0051: Incompatible stack heights: 4 vs 2
		//IL_0089->IL0051: Incompatible stack heights: 4 vs 2
		//IL_00e8->IL0051: Incompatible stack heights: 5 vs 2
		//IL_00a4->IL0051: Incompatible stack heights: 4 vs 2
		//IL_010f->IL0051: Incompatible stack heights: 4 vs 2
		//IL_0051->IL0051: Incompatible stack heights: 4 vs 2
		//IL_00d6->IL0051: Incompatible stack heights: 4 vs 2
		//IL_00af->IL0051: Incompatible stack heights: 4 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._003Cuser_id_003Ei__Field = (_003Cuser_id_003Ej__TPar)this;
		((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_0027: Stack underflow*/)._003Curl_003Ei__Field = (_003Curl_003Ej__TPar)this;
		((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_0033: Stack underflow*/)._003Ccontext_003Ei__Field = (_003Ccontext_003Ej__TPar)this;
		_ = ((_003C_003Ef__AnonymousType1<, , >)(object)this).name;
		while (true)
		{
			switch (4)
			{
			default:
				return;
			case 3:
				_ = ((_003C_003Ef__AnonymousType1<, , >)x).uuid;
				_ = 2;
				break;
			case 5:
				_ = ((_003C_003Ef__AnonymousType1<, , >)(object)top).user_id;
				_ = 1;
				if (_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument == null)
				{
					_ = 0;
				}
				break;
			case 2:
				((_003C_003Ef__AnonymousType1<, , >)y).GetHashCode();
				_ = 0;
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.StoreConverter == null)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			case 4:
				_003C_003Ef__AnonymousType1<, , >.ReflectModularWriter();
				_ = 5;
				break;
			case 1:
			{
				_ = ((_003C_003Ef__AnonymousType2<, , , >)(object)name).url;
				object obj = 6;
				break;
			}
			case 6:
				_ = ((_003C_003Ef__AnonymousType2<, , , >)action).payload;
				_ = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Read(IByteBuffer buffer)
	{
		_FF00䘀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(IByteBuffer buffer)
	{
		_FF00吀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CloseWrapper()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GermGuiClickDown DecorateActiveFilter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00㨀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779257, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00㬀(uint P_0)
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
				((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
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
	internal unsafe void _FF00㰀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779256, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00㴀()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00㸀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00㼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779259, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00䀀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00䄀(object P_0)
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
	internal unsafe void _FF00䈀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779258, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00䌀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779253, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00䐀()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (uint)(int)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00䔀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779252, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00䘀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_009a: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got VT
		//IL_00ae: Expected Obj, but got VT
		//IL_0054: Expected VT, but got Obj
		//IL_0054: Expected VT, but got Obj
		//IL_0054: Expected Obj, but got Ref
		//IL_0059: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I4
		//IL_00ca: Expected Obj, but got I4
		//IL_00cf: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got VT
		//IL_00b3->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0063->IL0026: Incompatible stack types: I4 vs Ref
		//IL_00f4->IL0026: Incompatible stack heights: 6 vs 2
		//IL_00d9->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0083->IL0026: Incompatible stack heights: 4 vs 2
		//IL_00be->IL0026: Incompatible stack heights: 5 vs 2
		//IL_008e->IL0026: Incompatible stack heights: 4 vs 2
		ref readonly _003Caction_003Ej__TPar reference = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				return;
			case 3:
			{
				bool flag = ((_003C_003Ef__AnonymousType0<>)/*Error near IL_0059: Stack underflow*/).Equals((object)((EqualityComparer<_00210>)Unsafe.AsPointer(ref reference)).Equals((_00210?)this, (_00210?)P_0));
				obj2 = 6;
				reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
				break;
			}
			case 6:
				((_003C_003Ef__AnonymousType0<>)(object)P_0.ToString()).ToString();
				_ = 1;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field == 0)
				{
					_ = 0;
				}
				break;
			case 2:
				_ = ((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType1<, , >)32767).name).uuid;
				_ = 0;
				if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType3<, >._003Centry_003Ei__Field)._003Csid_003Ei__Field == 0)
				{
					_ = 0;
				}
				break;
			case 5:
				((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType1<, , >)P_0).Equals((object)32767)).GetHashCode();
				_ = 4;
				break;
			case 4:
				((_003C_003Ef__AnonymousType1<, , >)32767).ToString();
				_003C_003Ef__AnonymousType1<, , >.ReflectScalableStack();
				_ = 2;
				break;
			default:
				/*Error near IL_00f6: Member reference must be method, but was: Field*/;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00䜀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779255, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00䠀(object P_0)
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
	internal void _FF00䤀(object P_0)
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
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00䨀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779254, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00䬀()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00䰀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779249, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00䴀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00一()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779248, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00伀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779251, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00倀(uint P_0)
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
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00儀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779250, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00刀()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (uint)(int)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00匀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779213, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00吀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_00e9: Expected VT, but got Obj
		//IL_0074: Expected Obj, but got I4
		//IL_00bd: Expected VT, but got I4
		//IL_00bd: Expected VT, but got Obj
		//IL_00bd: Expected Obj, but got Ref
		//IL_0105: Expected Obj, but got I4
		//IL_0053: Expected VT, but got Obj
		//IL_0058: Expected VT, but got Ref
		//IL_00f4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007f->IL0026: Incompatible stack heights: 4 vs 2
		//IL_00d2->IL0026: Incompatible stack heights: 1 vs 2
		//IL_011a->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0063->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00dd->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0125->IL0026: Incompatible stack heights: 5 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 6:
				((_003C_003Ef__AnonymousType0<>)P_0)._002Ector((_003Caction_003Ej__TPar)this);
				((EqualityComparer<_00210>)/*Error near IL_0058: Stack underflow*/).GetHashCode((_00210)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
				_ = 4;
				break;
			case 1:
				((_003C_003Ef__AnonymousType0<>)(object)this).GetHashCode();
				((_003C_003Ef__AnonymousType0<>)32767).ToString();
				_ = 3;
				break;
			case 4:
				return;
			case 5:
				_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
				/*Error near IL_0087: Member reference must be method, but was: Field*/;
			case 2:
				((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Cname_003Ej__TPar)P_0, (_003Cuuid_003Ej__TPar)((_003C_003Ef__AnonymousType1<, , >)(object)this).user_id, (_003Cuser_id_003Ej__TPar)32767);
				_ = 1;
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance != null)
				{
					_ = 1;
				}
				break;
			default:
				((EqualityComparer<_00212>)P_0).GetHashCode((_00212)((_003C_003Ef__AnonymousType1<, , >)(object)this).ToString());
				obj2 = 6;
				break;
			case 3:
				_003C_003Ef__AnonymousType1<, , >.ReflectModularWriter();
				_ = ((_003C_003Ef__AnonymousType2<, , , >)32767).url;
				_ = 5;
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.GuideMap == null)
				{
					_ = 5;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00唀()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (uint)(int)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00嘀(uint P_0)
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
}
