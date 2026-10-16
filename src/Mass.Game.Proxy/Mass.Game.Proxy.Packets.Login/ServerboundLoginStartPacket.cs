using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using DotNetty.Buffers;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Network.Interface;
using Mass.Game.Proxy.Network.Packet;

namespace Mass.Game.Proxy.Packets.Login;

[PacketAllVersion(0)]
[Packet(EnumConnectionState.Login, EnumPacketDirection.Serverbound)]
public class ServerboundLoginStartPacket : IPacket, IBufferCodec, IBufferSerializable, IBufferDeserializable
{
	private static object DeleteLogger;

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00琀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00蜀(value);
		}
	}

	public Guid? Uuid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00褀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00謀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ServerboundLoginStartPacket(EnumProtocolVersion version)
	{
		//IL_001b: Expected VT, but got I4
		//IL_0027: Expected Obj, but got Ref
		//IL_0041: Expected Obj, but got VT
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)version;
		_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter = this;
		string.Format((IFormatProvider?)/*Error near IL_0032: Stack underflow*/, (string)/*Error near IL_0032: Stack underflow*/, (object?[])(object)this);
		int num = 0;
		if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field == 0)
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
		_FF00_FF00_FF00_FF00_FF00_FF00蔀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00缀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Handle(Connection connection)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00簀(connection) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CompressConnection()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerboundLoginStartPacket ReflectCustomizableProfiler()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00猀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778294, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00琀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00甀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778289, new IntPtr(2737368318348L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed byte _FF00_FF00_FF00_FF00_FF00_FF00簀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0057: Expected I4, but got Obj
		//IL_013f: Expected Obj, but got I4
		//IL_028b: Expected Obj, but got I4
		//IL_0290: Expected Obj, but got I4
		//IL_029c: Expected I4, but got Obj
		//IL_029c: Expected Obj, but got I4
		//IL_02a8: Expected Obj, but got I
		//IL_02ba: Expected Obj, but got I4
		//IL_02ba: Expected Obj, but got I4
		//IL_00cb: Expected VT, but got Ref
		//IL_00d5: Expected Obj, but got I4
		//IL_00da: Expected Obj, but got I4
		//IL_0064: Expected VT, but got Obj
		//IL_0188: Expected Obj, but got I4
		//IL_018d: Expected Obj, but got I4
		//IL_02d0: Expected Obj, but got I4
		//IL_02e2: Expected I4, but got Obj
		//IL_02e7: Expected Obj, but got I4
		//IL_0247: Expected VT, but got Obj
		//IL_0249: Expected Obj, but got I4
		//IL_023b: Expected VT, but got Obj
		//IL_023d: Expected Obj, but got I
		//IL_0250: Expected VT, but got Obj
		//IL_0250: Expected Obj, but got I
		//IL_0252: Expected Obj, but got I4
		//IL_0124->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0155->IL00ba: Incompatible stack heights: 2 vs 1
		//IL_00fd->IL0026: Incompatible stack heights: 4 vs 2
		//IL_006e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0197->IL0026: Incompatible stack heights: 4 vs 2
		//IL_012f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0169->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0108->IL0026: Incompatible stack heights: 4 vs 2
		//IL_02f2->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0174->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0242->IL0249: Incompatible stack heights: 2 vs 3
		//IL_0212->IL0249: Incompatible stack heights: 4 vs 3
		//IL_0266->IL0026: Incompatible stack heights: 3 vs 2
		//IL_022a->IL0249: Incompatible stack heights: 4 vs 3
		//IL_021e->IL0249: Incompatible stack heights: 5 vs 3
		//IL_0271->IL0026: Incompatible stack heights: 3 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 6;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 10:
					((_003C_003Ef__AnonymousType1<, , >)obj)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)this;
					obj2 = 8;
					continue;
				case 2:
					/*Error near IL_0095: Member reference must be method, but was: Field*/;
				case 9:
					((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_00cb: Stack underflow*/)._002Ector((_003Cname_003Ej__TPar)/*Error near IL_00cb: Stack underflow*/, (_003Cuuid_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_003Cuser_id_003Ej__TPar)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field);
					((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_00d0: Stack underflow*/).Equals((object)/*Error near IL_00d0: Stack underflow*/)).GetHashCode()).ToString();
					_003C_003Ef__AnonymousType1<, , >.ReflectScalableStack();
					_ = ((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.ReflectModularWriter()).url;
					_ = 0;
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.GuideMap != null)
					{
						_ = 0;
					}
					continue;
				case 5:
					((EntitySocks5Account)obj).Username__BackingField = P_0;
					obj2 = 10;
					if (EntitySocks5Account.AttachElement == null)
					{
						obj2 = 7;
					}
					continue;
				case 6:
					break;
				case 8:
					_ = ((EntitySocks5)obj).Port__BackingField;
					if (_003C_003Ef__AnonymousType2<, , , >.CheckAccessibleObject())
					{
						_ = 1;
						if (((EntityLaunchGameProxy)EntitySocks5.DecorateDynamicModule).Session__BackingField == null)
						{
							_ = 1;
						}
						continue;
					}
					goto case 9;
				default:
					return 1;
				case 1:
					((_003C_003Ef__AnonymousType3<, >)((EntityLaunchGameProxy)((EntityLaunchGameProxy)((EntityLaunchGameProxy)obj).GameId__BackingField).GameType__BackingField).GameVersion__BackingField).GetHashCode();
					_ = 3;
					continue;
				case 4:
					return 1;
				case 3:
				{
					_ = ((EntityLaunchGameProxy)((EntityLaunchGameProxy)obj).Name__BackingField).ServerAddress__BackingField;
					nint num2 = ((EntityLaunchGameProxy)this).ServerPort__BackingField;
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0 obj3 = new _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0();
					obj = ((EntityLaunchGameProxy)this).Value__BackingField;
					if ((nint)obj <= 763)
					{
						if ((nint)obj <= 340)
						{
							obj = (((nint)obj > 5) ? _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.DecorateConfigurableDecider() : obj3);
						}
						else if ((nint)obj <= 757)
						{
							obj = ((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory)(object)obj3).CreateInstance();
						}
						else
						{
							((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory)(object)obj3)._002Ector();
							obj = obj3;
						}
					}
					else if ((nint)obj <= 766)
					{
						((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)(object)obj3).Scan((ReadOnlySpan<char>)obj3);
						obj = num2;
					}
					else
					{
						obj = ((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)(object)obj3).TryFindNextPossibleStartingPosition((ReadOnlySpan<char>)obj3);
					}
					obj = ((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)num2).TryMatchAtCurrentPosition((ReadOnlySpan<char>)obj);
					_ = 2;
					if (((GameProxy)GameProxy.Name__BackingField).Session__BackingField != null)
					{
						_ = 0;
					}
					continue;
				}
				case 7:
				{
					EnumGameType enumGameType = ((GameProxy)obj).GameType__BackingField;
					((EntitySocks5Account)0)._002Ector((string)((GameProxy)this).GameId__BackingField, (string)((GameProxy)((GameProxy)obj).GameVersion__BackingField).ModHashList__BackingField);
					((EntitySocks5Account)(object)((StringBuilder)enumGameType).Append((char)(int)((EntitySocks5Account)obj).EqualityContract)).Password = (string)((GameProxy)((GameProxy)obj).TransferServerPort__BackingField).Section__BackingField;
					int num = (((EntitySocks5Account)(ushort)(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).PrintMembers((StringBuilder)((GameProxy)obj).IsGame) ? 3 : 2);
					int.TryParse((string?)((EntitySocks5Account?)/*Error near IL_02d5: Stack underflow*/ == (EntitySocks5Account?)new EntitySocks5Account((EntitySocks5Account?)/*Error near IL_02d0: Stack underflow*/, (EntitySocks5Account?)num)), out *(int*)new string((char)(int)obj, (StringSplitOptions)(int)__ldftn(EntitySocks5Account.GetHashCode)));
					_ = 4;
					continue;
				}
				}
				break;
			}
			obj = new { };
			obj = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed byte _FF00_FF00_FF00_FF00_FF00_FF00紀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778288, new IntPtr(2737368307948L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00缀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_005b: Expected I4, but got Obj
		//IL_0128: Expected Obj, but got Ref
		//IL_0172: Expected Obj, but got I4
		//IL_00ff: Expected VT, but got Ref
		//IL_00ff: Expected Obj, but got Ref
		//IL_01a8: Expected Obj, but got VT
		//IL_00d4: Invalid comparison between VT and I4
		//IL_0083: Expected Obj, but got I4
		//IL_0066: Expected VT, but got Obj
		//IL_0066: Expected Obj, but got Ref
		//IL_0137: Expected Obj, but got VT
		//IL_01d3: Expected Obj, but got I4
		//IL_01b2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008e->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0072->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0118->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00ed->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0123->IL0026: Incompatible stack heights: 1 vs 2
		//IL_01d8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01e3->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 9;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 10:
				((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Caction_003Ej__TPar)this);
				obj = (object)/*Error near IL_0068: Stack underflow*/;
				_ = 3;
				break;
			case 9:
				((_003C_003Ef__AnonymousType0<>)P_0).Equals((object)this);
				((_003C_003Ef__AnonymousType0<>)32767).GetHashCode();
				_ = 8;
				break;
			case 5:
				obj = ((_003C_003Ef__AnonymousType0<>)this).ToString();
				_ = ref obj;
				/*Error near IL_0099: Member reference must be method, but was: Field*/;
			case 8:
				if (((_003C_003Ef__AnonymousType3<, >)this)._003Csid_003Ei__Field < (object)766)
				{
					obj2 = 6;
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance == null)
					{
						obj2 = 1;
					}
					break;
				}
				goto case 7;
			case 4:
				if (((EqualityComparer<_00211>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).GetHashCode((_00211)(&obj)) == 0)
				{
					_ = 0;
					if ((int)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_defaultTimeout != 0)
					{
						_ = 0;
					}
					break;
				}
				obj = ((_003C_003Ef__AnonymousType2<, , , >)this).context;
				_ = ref obj;
				/*Error near IL_0139: Member reference must be method, but was: Field*/;
			default:
				_ = ((_003C_003Ef__AnonymousType2<, , , >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).url;
				/*Error near IL_0128: Member reference must be method, but was: Field*/;
			case 1:
				obj = _003C_003Ef__AnonymousType2<, , , >.CheckAccessibleObject();
				_ = ref obj;
				/*Error near IL_0174: Member reference must be method, but was: Field*/;
			case 7:
				obj = ((_003C_003Ef__AnonymousType3<, >)this).sid;
				obj2 = 4;
				break;
			case 2:
				return;
			case 11:
				return;
			case 6:
				if (((EntityLaunchGameProxy)this).GameType__BackingField < (EnumGameType)763)
				{
					return;
				}
				obj2 = 1;
				if (((EntityLaunchGameProxy)EntityLaunchGameProxy.GameVersion__BackingField).ModHashList__BackingField == null)
				{
					obj2 = 1;
				}
				break;
			case 3:
				_ = ref obj;
				/*Error near IL_01e5: Member reference must be method, but was: Field*/;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00耀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778291, new IntPtr(2737368316268L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00脀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778290, new IntPtr(2737368307948L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00舀()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00茀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778253, new IntPtr(2737368326668L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00萀()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00_FF00_FF00蔀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004b: Expected I4, but got Obj
		//IL_0118: Expected Obj, but got I4
		//IL_011d: Expected Obj, but got VT
		//IL_005d: Expected Obj, but got VT
		//IL_0076: Expected Obj, but got VT
		//IL_0093: Expected Obj, but got VT
		//IL_009d: Expected VT, but got Obj
		//IL_009d: Expected VT, but got Obj
		//IL_0131->IL0026: Incompatible stack heights: 5 vs 2
		//IL_007b->IL0026: Incompatible stack heights: 5 vs 2
		//IL_00b1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_013c->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0086->IL0026: Incompatible stack heights: 5 vs 2
		//IL_00bc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0161->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00eb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_016c->IL0026: Incompatible stack types: I4 vs Obj
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
			case 4:
				((_003C_003Ef__AnonymousType0<>)P_0).Equals((object)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field);
				((_003C_003Ef__AnonymousType0<>)(object)new object()).ToString();
				_ = 3;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field != 0)
				{
					_ = 6;
				}
				break;
			case 5:
				((_003C_003Ef__AnonymousType1<, , >)this)._002Ector((_003Cname_003Ej__TPar)P_0, ((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType2<, , , >)this)._003Cuser_id_003Ei__Field).uuid, (_003Cuser_id_003Ej__TPar)new EqualityComparer<_00212>());
				obj2 = 3;
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance != null)
				{
					obj2 = 2;
				}
				break;
			default:
				if ((nint)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectLocalTemplate >= 766)
				{
					obj2 = 4;
					if ((int)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_defaultTimeout == 0)
					{
						obj2 = 5;
					}
					break;
				}
				if ((nint)EntitySocks5Account.AttachElement < 763)
				{
					obj2 = 2;
					if (((EntitySocks5)EntitySocks5.Address__BackingField).Port__BackingField == 0)
					{
						obj2 = 1;
					}
					break;
				}
				goto case 7;
			case 2:
				return;
			case 7:
				/*Error near IL_00fb: Member reference must be method, but was: Field*/;
			case 1:
				_ = ((_003C_003Ef__AnonymousType2<, , , >)((_003C_003Ef__AnonymousType2<, , , >)16).payload).context;
				_ = 0;
				if (((EntitySocks5Account)EntitySocks5Account.Username__BackingField).Password__BackingField == null)
				{
					_ = 0;
				}
				break;
			case 3:
				return;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00蘀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778252, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00蜀(object P_0)
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
	internal unsafe Guid? _FF00_FF00_FF00_FF00_FF00_FF00蠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778255, new IntPtr(2737368328748L), 15))(null, 0, new IntPtr(0L));
		return (Guid?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Guid? _FF00_FF00_FF00_FF00_FF00_FF00褀()
	{
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (Guid?)((_003C_003Ef__AnonymousType1<, , >)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Guid? _FF00_FF00_FF00_FF00_FF00_FF00言()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778254, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		return (Guid?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00謀(Guid? P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00谀(Guid? P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778249, new IntPtr(2737368315228L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
