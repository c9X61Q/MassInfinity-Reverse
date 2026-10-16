using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using DotNetty.Buffers;
using DotNetty.Transport.Bootstrapping;
using DotNetty.Transport.Channels;
using DotNetty.Transport.Channels.Sockets;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Game.Proxy.Protocols.Heypixel;
using Mass.Game.Proxy.Protocols.Hyt.VexView;

namespace Mass.Game.Proxy.Network;

public static class Utf8String
{
	private static object ReplaceTransformer;

	private static int Utf8MaxBytes(int length)
	{
		return length * 4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ReadString(this IByteBuffer buffer, int max = 32767)
	{
		return (string)_FF00_FF00_FF00_FF00䌀(buffer, (uint)max);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IByteBuffer WriteString(this IByteBuffer buffer, string input, int max = 32767)
	{
		return (IByteBuffer)_FF00_FF00_FF00_FF00䔀(buffer, input, (uint)max);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LoadMap()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Utf8String CheckFilteredStruct()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00䈀(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776618, new IntPtr(2737368307948L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00䌀(object P_0, uint P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_007f: Expected I4, but got Obj
		//IL_02de: Expected VT, but got I4
		//IL_023a: Expected Obj, but got Ref
		//IL_016f: Expected Obj, but got Ref
		//IL_0265: Expected Obj, but got Ref
		//IL_026a: Expected Obj, but got Ref
		//IL_02c5: Expected VT, but got Ref
		//IL_02c5: Expected Obj, but got Ref
		//IL_02ca: Expected Obj, but got I4
		//IL_01cf: Expected Obj, but got Ref
		//IL_01de: Expected Obj, but got I
		//IL_0147: Expected I4, but got Obj
		//IL_0147: Expected Obj, but got Ref
		//IL_0156: Expected Obj, but got VT
		//IL_00b2: Expected Obj, but got Ref
		//IL_008a: Expected VT, but got Obj
		//IL_008a: Expected Obj, but got Ref
		//IL_009b: Expected Obj, but got VT
		//IL_01b7: Expected VT, but got Ref
		//IL_01b7: Expected VT, but got Ref
		//IL_0223: Expected Obj, but got I4
		//IL_0201: Expected Obj, but got Ref
		//IL_010a: Expected Obj, but got VT
		//IL_02e8->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0179->IL0026: Incompatible stack heights: 3 vs 2
		//IL_00e6->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0274->IL0026: Incompatible stack heights: 1 vs 2
		//IL_02d4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02d4->IL0026: Incompatible stack types: VT vs Ref
		//IL_01e3->IL0026: Incompatible stack heights: 3 vs 2
		//IL_015b->IL0026: Incompatible stack heights: 3 vs 2
		//IL_00a0->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00d3->IL0026: Incompatible stack heights: 3 vs 2
		//IL_01c6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01c6->IL0026: Incompatible stack types: I4 vs Ref
		//IL_02b3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01b0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0228->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01ee->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0166->IL0026: Incompatible stack heights: 3 vs 2
		//IL_00ab->IL0026: Incompatible stack heights: 1 vs 2
		//IL_02be->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0233->IL0026: Incompatible stack types: I4 vs Obj
		//IL_020b->IL0026: Incompatible stack heights: 1 vs 2
		//IL_010f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_011a->IL0026: Incompatible stack types: I4 vs Obj
		ref readonly _003Caction_003Ej__TPar reference = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 19;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 18:
				((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref reference))._002Ector((_003Caction_003Ej__TPar)P_0);
				obj = (object)/*Error near IL_008c: Stack underflow*/;
				_ = 2;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
				{
					_ = 11;
				}
				break;
			case 17:
				((_003C_003Ef__AnonymousType0<>)(&obj)).ToString();
				/*Error near IL_00b2: Member reference must be method, but was: Field*/;
			case 19:
				obj = _003C_003Ef__AnonymousType0<>.ReflectJoinedTree();
				_ = 18;
				break;
			case 4:
				_ = ref obj;
				((AbstractBootstrap<ServerBootstrap, IServerChannel>)obj).Channel<TcpServerSocketChannel>();
				_ = 20;
				break;
			case 15:
				_ = ref obj;
				/*Error near IL_00e8: Member reference must be method, but was: Field*/;
			case 12:
				if ((nint)obj < 0)
				{
					obj2 = 0;
					if (_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument != null)
					{
						obj2 = 1;
					}
				}
				else
				{
					((Regex)P_0)._002Ector();
					obj = (object)Unsafe.AsPointer(ref reference);
					_ = 10;
				}
				break;
			case 16:
				((IEnumerable<byte>)(&obj)).Take((int)obj);
				_ = 7;
				if (!_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_hasTimeout)
				{
					_ = 4;
				}
				break;
			case 3:
				JsonSerializer.Serialize((_003C_003Ef__AnonymousType3<int, string>)(&obj), (JsonSerializerOptions?)obj);
				_ = 6;
				break;
			case 10:
				if (Unsafe.As<object, UIntPtr>(ref obj) <= Unsafe.As<object, UIntPtr>(ref obj))
				{
					obj2 = 8;
					break;
				}
				goto default;
			case 20:
			{
				((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_01b7: Stack underflow*/)._002Ector((_003Curl_003Ej__TPar)/*Error near IL_01b7: Stack underflow*/, (_003Cpayload_003Ej__TPar)/*Error near IL_01b7: Stack underflow*/, (_003Ccontext_003Ej__TPar)Unsafe.AsPointer(ref reference), (_003Cuser_id_003Ej__TPar)(&obj));
				bool flag = ((EqualityComparer<_00213>)/*Error near IL_01bc: Stack underflow*/).Equals((_00213?)/*Error near IL_01bc: Stack underflow*/, (_00213?)/*Error near IL_01bc: Stack underflow*/);
				obj2 = 3;
				reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
				break;
			}
			case 14:
				JsonSerializer.Deserialize<VexViewPacket>((string)(&obj), (JsonSerializerOptions?)obj);
				_ = 17;
				if (((EntitySocks5)EntitySocks5.Port__BackingField).Account__BackingField != null)
				{
					_ = 15;
				}
				break;
			case 1:
				_003C_003Ef__AnonymousType2<, , , >.DisableDecryptor();
				/*Error near IL_01f3: Member reference must be method, but was: Field*/;
			case 11:
				if (Unsafe.As<object, UIntPtr>(ref obj) <= Unsafe.As<object, UIntPtr>(ref obj))
				{
					obj2 = 12;
					if (((EntityLaunchGameProxy)EntityLaunchGameProxy.GameType__BackingField).GameVersion__BackingField == EnumGameVersion.None)
					{
						obj2 = 1;
					}
					break;
				}
				goto case 9;
			case 2:
				((_003C_003Ef__AnonymousType3<, >)(&obj)).GetHashCode();
				/*Error near IL_023a: Member reference must be method, but was: Field*/;
			case 6:
				((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0)(&obj))._002Ector();
				((RegexRunner)Unsafe.AsPointer(ref reference)).CheckTimeout();
				_ = 15;
				break;
			case 9:
				_ = ref obj;
				_ = 78;
				_ = 2;
				/*Error near IL_0279: Member reference must be method, but was: Field*/;
			case 7:
				throw new ReadOnlySpan<char>(((ReadOnlySpan<char>*)(&obj))->Length);
			case 8:
				((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory)obj)._002Ector();
				obj = P_0;
				obj2 = 2;
				if (((GameProxy)GameProxy._pinger).ConnectionChanged != null)
				{
					obj2 = 5;
				}
				break;
			case 13:
			{
				ReadOnlySpan<char> readOnlySpan = (string?)((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)Unsafe.AsPointer(ref reference)).TryMatchAtCurrentPosition((ReadOnlySpan<char>)(&obj));
				obj2 = 4;
				reference = ref *(_003Caction_003Ej__TPar*)readOnlySpan;
				break;
			}
			default:
				_ = ref obj;
				_ = 47;
				SearchValues.Create((ReadOnlySpan<char>)2);
				_ = 2;
				break;
			case 5:
				/*Error near IL_02e8: Member reference must be method, but was: Field*/;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00䔀(object P_0, object P_1, uint P_2)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0077: Expected I4, but got Obj
		//IL_011c: Expected Obj, but got Ref
		//IL_011c: Expected Obj, but got Ref
		//IL_0121: Expected VT, but got I4
		//IL_00ab: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I4
		//IL_024f: Expected VT, but got Obj
		//IL_0259: Expected Obj, but got I4
		//IL_01c4: Expected Obj, but got Ref
		//IL_01c9: Expected Obj, but got VT
		//IL_01d2: Expected Obj, but got I4
		//IL_0268: Expected Obj, but got I4
		//IL_0268: Expected VT, but got I4
		//IL_009b: Expected VT, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got Ref
		//IL_016e: Expected Obj, but got Ref
		//IL_0148: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I4
		//IL_0199: Expected Obj, but got Ref
		//IL_0106: Expected Obj, but got Ref
		//IL_010b: Expected VT, but got Ref
		//IL_00cc: Expected Obj, but got I4
		//IL_01ee: Expected Obj, but got I4
		//IL_0135->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0135->IL0026: Incompatible stack types: I4 vs Ref
		//IL_0299->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0091->IL0026: Incompatible stack types: I4 vs Obj
		//IL_027c->IL0026: Incompatible stack heights: 4 vs 2
		//IL_00a5->IL0026: Incompatible stack heights: 4 vs 2
		//IL_015c->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0115->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0115->IL0026: Incompatible stack types: I4 vs Ref
		//IL_0140->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0140->IL0026: Incompatible stack types: I4 vs Ref
		//IL_0287->IL0026: Incompatible stack heights: 4 vs 2
		//IL_00d1->IL0022: Incompatible stack heights: 0 vs 1
		//IL_0203->IL0026: Incompatible stack heights: 3 vs 2
		//IL_02e3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0167->IL0026: Incompatible stack heights: 4 vs 2
		//IL_020e->IL0026: Incompatible stack heights: 3 vs 2
		//IL_02ee->IL0026: Incompatible stack types: I4 vs Obj
		ref readonly _003Caction_003Ej__TPar reference = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 13;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 9:
					((DefaultInterpolatedStringHandler*)(&obj))->AppendFormatted(((Array)obj).Length);
					obj2 = 14;
					continue;
				case 12:
					_ = ref obj;
					((EqualityComparer<_00210>)38).GetHashCode((_00210)2);
					_ = 17;
					continue;
				case 6:
					obj = ((_003C_003Ef__AnonymousType0<>)P_2).GetHashCode();
					obj2 = 15;
					continue;
				case 13:
					if ((nint)string.Format((IFormatProvider?)/*Error near IL_00bd: Stack underflow*/, (string)Unsafe.AsPointer(ref reference), (object?[])P_1) > (int)P_2)
					{
						obj = 12;
						break;
					}
					((RegexRunner)/*Error near IL_0220: Stack underflow*/).CheckTimeout();
					/*Error near IL_0221: Member reference must be method, but was: Field*/;
				case 4:
					return P_0;
				case 8:
					_ = ref obj;
					/*Error near IL_00d6: Member reference must be method, but was: Field*/;
				case 18:
				{
					bool flag = ((EqualityComparer<_00212>)/*Error near IL_010b: Stack underflow*/).Equals((_00212?)Unsafe.AsPointer(ref reference), (_00212?)((_003C_003Ef__AnonymousType1<, , >)(&obj)).user_id);
					obj2 = 16;
					reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
					continue;
				}
				default:
				{
					bool flag2 = ((EqualityComparer<_00211>)/*Error near IL_0121: Stack underflow*/).Equals((_00211?)/*Error near IL_0121: Stack underflow*/, (_00211?)((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref reference)).Equals((object)(&obj)));
					obj2 = 9;
					reference = ref *(flag2 ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.StoreConverter != null)
					{
						obj2 = 5;
						reference = ref *(flag2 ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
					}
					continue;
				}
				case 16:
					_ = ref obj;
					((IEnumerable<byte>)P_2).ToArray();
					_ = 10;
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_ascii_68FF03FEFFFF87FEFFFF07 == null)
					{
						_ = 1;
					}
					continue;
				case 14:
					_ = ((_003C_003Ef__AnonymousType2<, , , >)(&obj)).context;
					/*Error near IL_016e: Member reference must be method, but was: Field*/;
				case 17:
					((_003C_003Ef__AnonymousType2<, , , >)(&obj)).GetHashCode();
					/*Error near IL_0199: Member reference must be method, but was: Field*/;
				case 10:
					((Regex)((_003C_003Ef__AnonymousType3<, >)(&obj)).entry)._002Ector();
					obj = 5;
					break;
				case 1:
					_ = ref obj;
					/*Error near IL_01d9: Member reference must be method, but was: Field*/;
				case 5:
					_ = ref obj;
					/*Error near IL_0210: Member reference must be method, but was: Field*/;
				case 7:
					MemoryExtensions.IndexOfAny<T>((ReadOnlySpan<T>)P_0, (SearchValues<T>)obj);
					obj = 4;
					break;
				case 11:
					_ = ref obj;
					MemoryExtensions.IndexOfAnyExcept<T>((ReadOnlySpan<T>)41, (SearchValues<T>)2);
					_ = 0;
					if (GameProxy.OnlineClients == null)
					{
						_ = 0;
					}
					continue;
				case 2:
					((AsyncTaskMethodBuilder<HeypixelHwid>*)(&obj))->Start(ref *(MassServiceExtensions._003CGetHeypixelSession_003Ed__1*)P_2);
					obj2 = 3;
					continue;
				case 3:
					_ = ref obj;
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.VerifyVerifier();
					/*Error near IL_02a0: Member reference must be method, but was: Field*/;
				case 15:
					if (((Array)obj).Length <= (nint)obj)
					{
						((_003C_003Ef__AnonymousType3<, >)((Array)obj).Length).GetHashCode();
						_ = 1;
						if (((EntityLaunchGameProxy)EntityLaunchGameProxy.Name__BackingField).ServerAddress__BackingField == null)
						{
							_ = 7;
						}
					}
					else
					{
						obj2 = 2;
						if (((GameProxy)GameProxy.ModHashList__BackingField).ServerAddress__BackingField != null)
						{
							obj2 = 11;
						}
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00䘀(object P_0, object P_1, uint P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776613, new IntPtr(2737368314188L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00䜀()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00䠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776612, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00䤀()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}
}
