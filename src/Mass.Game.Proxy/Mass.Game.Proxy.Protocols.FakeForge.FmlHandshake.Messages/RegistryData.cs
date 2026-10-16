using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using DotNetty.Buffers;
using Mass.Domain.Desktop.ValueObjects;

namespace Mass.Game.Proxy.Protocols.FakeForge.FmlHandshake.Messages;

public class RegistryData : FmlHandshakeMessage
{
	public class IdEntity
	{
		public string Name;

		public int Id;

		private static object DecorateSymbolicStrategy;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe IdEntity(string name, int id)
		{
			//IL_001a: Expected VT, but got Obj
			//IL_001a: Expected VT, but got Ref
			//IL_0029: Expected Obj, but got VT
			//IL_0060: Expected VT, but got I4
			//IL_006f: Expected Obj, but got VT
			//IL_0086: Expected VT, but got Obj
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			((EqualityComparer<_00210>)/*Error near IL_001a: Stack underflow*/).Equals((_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00210?)this);
			int num = 0;
			if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 2:
					return;
				default:
					((_003C_003Ef__AnonymousType2<, , , >)this)._003Curl_003Ei__Field = (_003Curl_003Ej__TPar)id;
					num = 0;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field == 0)
					{
						num = 2;
					}
					break;
				case 1:
					((_003C_003Ef__AnonymousType2<, , , >)this)._003Cuser_id_003Ei__Field = (_003Cuser_id_003Ej__TPar)name;
					num = 0;
					if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CheckConfigurableSorter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static IdEntity DecorateSeparatedConfig()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_1B00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778933, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00ᰀ()
		{
			//IL_001a: Invalid comparison between VT and Obj
			_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00ᴀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778932, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00Ḁ()
		{
			//IL_001a: Expected Obj, but got VT
			_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00ἀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778935, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	private static object ReflectAutomatableTemplate;

	public bool HasMore
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00踀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00退(value ? ((byte)1) : ((byte)0));
		}
	}

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00ꄀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00蠀(value);
		}
	}

	public List<IdEntity> Ids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00销();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00蔀(value);
		}
	}

	public List<string> Substitutions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00鈀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00鼀(value);
		}
	}

	public List<string> Dummies
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00錀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00ꀀ(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Read(IByteBuffer buffer)
	{
		_FF00_FF00謀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(IByteBuffer buffer)
	{
		_FF00_FF00騀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe RegistryData()
	{
		//IL_001b: Expected VT, but got Obj
		//IL_001b: Expected Obj, but got Ref
		//IL_002b: Expected VT, but got Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._003Cuser_id_003Ei__Field = (_003Cuser_id_003Ej__TPar)this;
		((_003C_003Ef__AnonymousType2<, , , >)(object)this)._003Curl_003Ei__Field = (_003Curl_003Ej__TPar)new object();
		/*Error near IL_0031: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckIterableAuditor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RegistryData ReflectIntegratedDecider()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00萀(List<IdEntity> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778917, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00蔀(List<IdEntity> P_0)
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
	internal unsafe void _FF00_FF00蘀(List<IdEntity> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778916, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00蜀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778919, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00蠀(object P_0)
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
	internal unsafe void _FF00_FF00褀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778918, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00言(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778913, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00謀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_008b: Expected I4, but got Obj
		//IL_00f4: Expected Obj, but got VT
		//IL_0178: Expected Obj, but got I4
		//IL_0304: Expected Obj, but got I4
		//IL_01e0: Expected Obj, but got Ref
		//IL_01eb: Expected Obj, but got I4
		//IL_0246: Expected Obj, but got I4
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected Obj, but got Unknown
		//IL_0093: Expected Obj, but got I4
		//IL_0125: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got VT
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		//IL_00a4: Expected VT, but got Obj
		//IL_00a4: Expected VT, but got Obj
		//IL_00a4: Expected Obj, but got Ref
		//IL_00a9: Expected Obj, but got I4
		//IL_02df: Expected Obj, but got I4
		//IL_00fe->IL0026: Incompatible stack types: I4 vs Obj
		//IL_030e->IL0026: Incompatible stack heights: 3 vs 2
		//IL_02dc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02a4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0139->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0154->IL0026: Incompatible stack types: I4 vs Obj
		//IL_028a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02ca->IL0026: Incompatible stack heights: 5 vs 2
		//IL_00bd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00bd->IL0026: Incompatible stack types: I4 vs Ref
		//IL_02e9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0235->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02af->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0144->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c8->IL0026: Incompatible stack types: I4 vs Ref
		//IL_02fc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0217->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0222->IL0026: Incompatible stack types: I4 vs Obj
		ref readonly _003Caction_003Ej__TPar reference = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 17;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 11:
				obj = 0;
				obj2 = 10;
				break;
			case 17:
			{
				bool flag = ((_003C_003Ef__AnonymousType0<>)/*Error near IL_00a9: Stack underflow*/).Equals((object)((EqualityComparer<_00210>)Unsafe.AsPointer(ref reference)).Equals((_00210?)this, (_00210?)P_0));
				obj2 = 16;
				reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field != 0)
				{
					obj2 = 15;
					reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
				}
				break;
			}
			default:
				obj = ((_003C_003Ef__AnonymousType1<, , >)P_0).name;
				obj2 = 11;
				break;
			case 13:
				obj = 0;
				obj2 = 3;
				if (_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument != null)
				{
					obj2 = 2;
				}
				break;
			case 14:
				obj++;
				obj2 = 20;
				break;
			case 1:
			case 12:
				((_003C_003Ef__AnonymousType1<, , >)(object)this).GetHashCode();
				((_003C_003Ef__AnonymousType1<, , >)32767).ToString();
				_003C_003Ef__AnonymousType1<, , >.ReflectScalableStack();
				_ = new { };
				/*Error near IL_0183: Member reference must be method, but was: Field*/;
			case 4:
			case 23:
				((_003C_003Ef__AnonymousType2<, , , >)Unsafe.AsPointer(ref reference)).Equals(this);
				((_003C_003Ef__AnonymousType2<, , , >)32767).GetHashCode();
				/*Error near IL_01eb: Member reference must be method, but was: Field*/;
			case 19:
			case 20:
				if (Unsafe.As<object, UIntPtr>(ref obj) < Unsafe.As<object, UIntPtr>(ref obj))
				{
					obj2 = 23;
					if (EntitySocks5.DecorateDynamicModule == null)
					{
						obj2 = 17;
					}
					break;
				}
				goto default;
			case 3:
			case 7:
				if (Unsafe.As<object, UIntPtr>(ref obj) < Unsafe.As<object, UIntPtr>(ref obj))
				{
					obj2 = 12;
					break;
				}
				goto case 6;
			case 5:
			case 21:
				_ = ((_003C_003Ef__AnonymousType3<, >)(object)this).entry;
				_ = ((_003C_003Ef__AnonymousType3<, >)32767).sid;
				/*Error near IL_0246: Member reference must be method, but was: Field*/;
			case 9:
				return;
			case 15:
				obj++;
				obj2 = 18;
				break;
			case 8:
				obj++;
				obj2 = 4;
				if (((EntityLaunchGameProxy)EntityLaunchGameProxy.Name__BackingField).ServerAddress__BackingField != null)
				{
					obj2 = 7;
				}
				break;
			case 16:
				_ = 32767;
				((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0)_003C_003Ef__AnonymousType3<, >.DecorateIntegratedProgram())._002Ector();
				_ = 2;
				break;
			case 6:
				_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0._002Ecctor();
				obj = P_0;
				obj2 = 22;
				break;
			case 22:
				obj = 0;
				obj2 = 19;
				break;
			case 10:
			case 18:
				if (Unsafe.As<object, UIntPtr>(ref obj) >= Unsafe.As<object, UIntPtr>(ref obj))
				{
					return;
				}
				obj2 = 21;
				break;
			case 2:
				obj = _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectSymbolicAuditor();
				_ = 13;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00谀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778912, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00贀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778915, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00踀()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (byte)(int)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00輀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778914, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00退(byte P_0)
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00鄀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778941, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<string> _FF00_FF00鈀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (List<string>)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<string> _FF00_FF00錀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (List<string>)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<string> _FF00_FF00鐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778940, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (List<string>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<IdEntity> _FF00_FF00销()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (List<IdEntity>)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<IdEntity> _FF00_FF00阀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778943, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (List<IdEntity>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00需()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00頀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778942, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00餀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778937, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00騀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_005b: Expected I4, but got Obj
		//IL_01e3: Expected Obj, but got VT
		//IL_01e5: Expected Obj, but got Ref
		//IL_01f4: Expected Obj, but got I4
		//IL_0231: Expected Obj, but got I4
		//IL_0068: Expected VT, but got Obj
		//IL_006d: Expected VT, but got Ref
		//IL_01ab: Expected Obj, but got Ref
		//IL_01b0: Expected VT, but got I4
		//IL_01b2: Expected Obj, but got I4
		//IL_047f: Expected Obj, but got I4
		//IL_0108: Expected VT, but got Ref
		//IL_0108: Expected VT, but got Ref
		//IL_0275: Expected Obj, but got Ref
		//IL_0286: Expected Obj, but got I
		//IL_03ff: Expected Obj, but got Ref
		//IL_03ff: Expected Obj, but got Ref
		//IL_0401: Expected Obj, but got I4
		//IL_040a: Expected Obj, but got I4
		//IL_014c: Expected Obj, but got I4
		//IL_02a3: Expected Obj, but got I4
		//IL_0380: Expected Obj, but got I4
		//IL_0390: Expected Obj, but got I
		//IL_03ad: Expected Obj, but got I
		//IL_01f9->IL0026: Incompatible stack heights: 1 vs 2
		//IL_023c->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0082->IL0026: Incompatible stack heights: 1 vs 2
		//IL_01bc->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0493->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0204->IL0026: Incompatible stack heights: 1 vs 2
		//IL_008d->IL0026: Incompatible stack heights: 1 vs 2
		//IL_049e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00fc->IL0101: Incompatible stack heights: 0 vs 1
		//IL_0269->IL02c3: Incompatible stack heights: 0 vs 1
		//IL_0350->IL0350: Incompatible stack heights: 2 vs 3
		//IL_0369->IL03cd: Incompatible stack heights: 2 vs 1
		//IL_015c->IL0060: Incompatible stack heights: 0 vs 1
		//IL_0157->IL00e7: Incompatible stack heights: 3 vs 1
		//IL_02b8->IL0254: Incompatible stack heights: 3 vs 1
		//IL_02de->IL01bc: Incompatible stack heights: 0 vs 1
		//IL_0414->IL0204: Incompatible stack heights: 0 vs 1
		//IL_0395->IL0350: Incompatible stack heights: 2 vs 3
		//IL_03c2->IL0350: Incompatible stack heights: 4 vs 3
		//IL_02c3->IL0254: Incompatible stack heights: 3 vs 1
		//IL_03a0->IL0350: Incompatible stack heights: 2 vs 3
		//IL_03cd->IL0350: Incompatible stack heights: 4 vs 3
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 9:
				return;
			case 3:
				((_003C_003Ef__AnonymousType0<>)P_0)._002Ector((_003Caction_003Ej__TPar)this);
				((EqualityComparer<_00210>)/*Error near IL_006d: Stack underflow*/).GetHashCode((_00210)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
				_ = 2;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
				{
					_ = 2;
				}
				continue;
			case 7:
				_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
				/*Error near IL_0094: Member reference must be method, but was: Field*/;
			case 10:
				obj = ((EqualityComparer<_00213>)/*Error near IL_01b0: Stack underflow*/).GetHashCode((_00213)((_003C_003Ef__AnonymousType2<, , , >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals(this));
				_ = 4;
				continue;
			case 8:
				((_003C_003Ef__AnonymousType2<, , , >)(object)this).ToString();
				/*Error near IL_01c3: Member reference must be method, but was: Field*/;
			case 1:
				((Regex)((_003C_003Ef__AnonymousType3<, >)(object)this).entry)._002Ector();
				obj = (object)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field);
				_ = 5;
				if (((EntityLaunchGameProxy)EntityLaunchGameProxy.GameType__BackingField).GameVersion__BackingField == EnumGameVersion.None)
				{
					_ = 3;
				}
				continue;
			case 6:
				((_003C_003Ef__AnonymousType3<, >)(object)this).GetHashCode();
				/*Error near IL_020b: Member reference must be method, but was: Field*/;
			case 2:
				_003C_003Ef__AnonymousType3<, >.DecorateIntegratedProgram();
				((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0)32767)._002Ector();
				_ = 7;
				continue;
			case 4:
				while (true)
				{
					IL_02c3:
					((RegexRunner)/*Error near IL_02ca: Stack underflow*/).Capture((int)/*Error near IL_02ca: Stack underflow*/, (int)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (int)(&obj));
					int num2;
					if ((int)/*Error near IL_02cf: Stack underflow*/ == 0)
					{
						num2 = 2;
						goto IL_0254;
					}
					goto IL_026e;
					IL_0254:
					while (true)
					{
						switch (num2)
						{
						case 2:
							break;
						case 3:
							goto IL_026e;
						default:
							((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory)32767).CreateInstance();
							_ = 1;
							if (((GameProxy)GameProxy.Logger__BackingField)._pinger != null)
							{
								_ = 1;
							}
							continue;
						case 1:
							goto IL_02c3;
						}
						break;
					}
					break;
					IL_026e:
					((RegexRunner)(&obj)).CheckTimeout();
					obj = (object)/*Error near IL_0277: Stack underflow*/;
					num2 = 0;
					if ((object)EntityLaunchGameProxy.ReflectAlphabeticProcessor == null)
					{
						num2 = 0;
					}
					goto IL_0254;
				}
				goto case 8;
			case 5:
				while (true)
				{
					IL_03cd:
					int num;
					if (EqualityComparer<string>.Default == null)
					{
						num = 1;
						if (((GameProxy)GameProxy.WorkerGroup__BackingField).AcceptorGroup__BackingField == null)
						{
							num = 1;
						}
						goto IL_0350;
					}
					goto IL_03f8;
					IL_03f8:
					obj = (Type?)(&obj) == (Type?)(&obj);
					obj = 2;
					goto IL_0350;
					IL_0350:
					while (true)
					{
						switch (num)
						{
						case 1:
							break;
						case 2:
							((EntitySocks5Account)P_0)._002Ector((string)((GameProxy)obj).ModHashList__BackingField, (string)32767);
							_ = 4;
							if (((GameProxy)GameProxy.ServerPort__BackingField).TransferServerAddress__BackingField == null)
							{
								_ = 4;
							}
							continue;
						case 4:
							_ = ((EntitySocks5Account)((GameProxy)obj).TransferServerPort__BackingField).Password;
							_ = 2;
							if (!((GameProxy)(object)GameProxy.Socks5).IsGame)
							{
								_ = 3;
							}
							continue;
						case 3:
							goto IL_03cd;
						default:
							goto IL_03f8;
						}
						break;
					}
					break;
				}
				goto case 6;
			case 11:
				obj = ((EqualityComparer<EntitySocks5Account>)(object)this).GetHashCode(EntitySocks5Account.RunWriter());
				obj2 = 0;
				if (((GameProxy._003CListenAsync_003Ed__69)GameProxy._003CListenAsync_003Ed__69._003C_003Et__builder)._003C_003E4__this != null)
				{
					obj2 = 0;
				}
				continue;
			}
			while (!((EqualityComparer<_00211>)/*Error near IL_0108: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00211?)(&obj)))
			{
				int num3 = 0;
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.StoreConverter == null)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					default:
						return;
					case 0:
						return;
					case 2:
						break;
					case 1:
						goto end_IL_0101;
					case 3:
						_ = ((_003C_003Ef__AnonymousType2<, , , >)32767).url;
						_ = 2;
						continue;
					}
					break;
				}
				continue;
				end_IL_0101:
				break;
			}
			_ = ref obj;
			/*Error near IL_012e: Member reference must be method, but was: Field*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00鬀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778936, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00鰀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778939, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00鴀()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00鸀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778938, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00鼀(List<string> P_0)
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
	internal void _FF00_FF00ꀀ(List<string> P_0)
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
	internal object _FF00_FF00ꄀ()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}
}
