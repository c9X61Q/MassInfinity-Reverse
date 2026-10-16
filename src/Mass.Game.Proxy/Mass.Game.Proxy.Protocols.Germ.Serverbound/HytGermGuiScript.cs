using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using DotNetty.Buffers;

namespace Mass.Game.Proxy.Protocols.Germ.Serverbound;

public class HytGermGuiScript : GermPacket
{
	internal static HytGermGuiScript ReflectOrderedPolicy;

	public string Gui
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00쌀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00봀(value);
		}
	}

	public string Command
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00먀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00뼀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe HytGermGuiScript()
	{
		//IL_001b: Expected VT, but got Obj
		//IL_001b: Expected Obj, but got Ref
		//IL_0027: Expected VT, but got Obj
		//IL_0041: Expected Obj, but got VT
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._003Cuser_id_003Ei__Field = (_003Cuser_id_003Ej__TPar)this;
		((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_0027: Stack underflow*/)._003Curl_003Ei__Field = (_003Curl_003Ej__TPar)this;
		_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
		int num = 0;
		if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Ccontext_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
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
	public unsafe HytGermGuiScript(string gui, string command)
	{
		//IL_001b: Expected VT, but got Obj
		//IL_001b: Expected Obj, but got Ref
		//IL_0027: Expected VT, but got Obj
		//IL_0041: Expected Obj, but got VT
		//IL_0086: Expected Obj, but got VT
		//IL_00a8->IL005a: Incompatible stack heights: 4 vs 3
		//IL_008b->IL005a: Incompatible stack heights: 5 vs 3
		//IL_0096->IL005a: Incompatible stack heights: 5 vs 3
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._003Cuser_id_003Ei__Field = (_003Cuser_id_003Ej__TPar)this;
		((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_0027: Stack underflow*/)._003Curl_003Ei__Field = (_003Curl_003Ej__TPar)this;
		_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
		int num = 0;
		if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Ccontext_003Ei__Field)._003Cuser_id_003Ei__Field != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				_ = ((_003C_003Ef__AnonymousType1<, , >)(object)gui).uuid;
				_ = 0;
				if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType3<, >._003Centry_003Ei__Field)._003Csid_003Ei__Field == 0)
				{
					_ = 0;
				}
				break;
			case 2:
				return;
			default:
				((_003C_003Ef__AnonymousType1<, , >)(object)this).Equals((object)command);
				_ = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Read(IByteBuffer buffer)
	{
		_FF00씀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(IByteBuffer buffer)
	{
		_FF00윀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckVisualRequester()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HytGermGuiScript ReflectScopeModule()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00뜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779326, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00렀()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00뤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779321, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00먀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00묀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779320, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00밀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779323, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00봀(object P_0)
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
	internal unsafe void _FF00븀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779322, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00뼀(object P_0)
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
	internal static object _FF00쀀()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00섀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779317, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00숀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779316, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00쌀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00쐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779319, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00씀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0049: Expected VT, but got I4
		//IL_004e: Expected Obj, but got Ref
		//IL_008d: Expected Obj, but got VT
		//IL_0062->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0062->IL0026: Incompatible stack types: I4 vs Ref
		//IL_0092->IL0026: Incompatible stack heights: 7 vs 2
		//IL_006d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006d->IL0026: Incompatible stack types: I4 vs Ref
		//IL_009d->IL0026: Incompatible stack heights: 7 vs 2
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
			case 2:
				return;
			case 1:
				_ = 32767;
				_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
				_003C_003Ef__AnonymousType0<>.ReflectJoinedTree();
				_ = 0;
				if (_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic == null)
				{
					_ = 0;
				}
				continue;
			}
			((_003C_003Ef__AnonymousType0<>)P_0)._002Ector((_003Caction_003Ej__TPar)32767);
			bool flag = ((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref reference)).Equals(this);
			obj2 = 1;
			reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
			if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field != 0)
			{
				obj2 = 2;
				reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00였(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779318, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00윀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_008f: Expected Obj, but got VT
		//IL_0044: Expected VT, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got Ref
		//IL_0094->IL0026: Incompatible stack heights: 6 vs 2
		//IL_0063->IL0026: Incompatible stack heights: 1 vs 2
		//IL_009f->IL0026: Incompatible stack heights: 6 vs 2
		//IL_006e->IL0026: Incompatible stack heights: 1 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 2;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				((_003C_003Ef__AnonymousType0<>)P_0)._002Ector((_003Caction_003Ej__TPar)this);
				((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals(32767);
				_ = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field != 0)
				{
					_ = 1;
				}
				break;
			case 1:
				_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
				_ = 32767;
				_003C_003Ef__AnonymousType0<>.ReflectJoinedTree();
				_ = 0;
				if (_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic != null)
				{
					_ = 0;
				}
				break;
			}
		}
	}
}
