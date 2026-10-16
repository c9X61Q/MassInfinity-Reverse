using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using System.Threading;
using DotNetty.Buffers;
using DotNetty.Transport.Bootstrapping;
using DotNetty.Transport.Channels;
using Mass.Application.Event;
using Mass.Application.Models;
using Mass.Application.Services;
using Mass.Common.Extensions;
using Mass.Game.Proxy.Protocols.Heypixel.AntiCheat;
using Mass.Game.Proxy.Protocols.OhMyGod;
using Mass.Game.Proxy.Protocols.Orange;
using Serilog;

namespace Mass.Game.Proxy.Protocols.Heypixel;

public static class HeypixelEncryption
{
	internal static HeypixelEncryption PlanDistributor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string Encrypt(Guid password, string data)
	{
		return (string)_FF00_FF00_FF00_FF00_FF00謀(password, data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static byte[] Encrypt(string password, byte[] data)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 244, 1790778847, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778847, new IntPtr(2737367932764L), 15);
		}
		return (byte[])((delegate*<object, object, object>)obj)(password, data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string Decrypt(Guid password, string data)
	{
		return (string)_FF00_FF00_FF00_FF00_FF00ꌀ(password, data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static byte[] Decrypt(string password, byte[] data)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 246, 1790778846, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778846, new IntPtr(2737367933804L), 15);
		}
		return (byte[])((delegate*<object, object, object>)obj)(password, data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] Unmix(byte[] input, Guid guid)
	{
		return (byte[])_FF00_FF00_FF00_FF00_FF00錀(input, guid);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] Mix(byte[] input, Guid guid)
	{
		return (byte[])_FF00_FF00_FF00_FF00_FF00蔀(input, guid);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetType(Guid guid)
	{
		return (int)_FF00_FF00_FF00_FF00_FF00退(guid);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint Mod(long value, uint modulus)
	{
		return _FF00_FF00_FF00_FF00_FF00騀(value, modulus);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static byte[] Decompress(byte[] byArray)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 251, 1790778841, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778841, new IntPtr(2737367944204L), 15);
		}
		return (byte[])((delegate*<object, object>)obj)(byArray);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckAdvancedResponder()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HeypixelEncryption EnableDispatcher()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00萀(object P_0, Guid P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778840, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00蔀(object P_0, Guid P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0137: Expected I4, but got Obj
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got VT
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected Obj, but got Unknown
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0674: Expected Obj, but got Unknown
		//IL_07a2: Expected Obj, but got I4
		//IL_0282: Expected Obj, but got I4
		//IL_0609: Expected Obj, but got I4
		//IL_0449: Expected Obj, but got I4
		//IL_0699: Expected Obj, but got Ref
		//IL_04f6: Expected Obj, but got I4
		//IL_01ab: Expected Obj, but got I4
		//IL_01ba: Expected Obj, but got VT
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Expected Obj, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Expected I4, but got Unknown
		//IL_0772: Expected Obj, but got VT
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_022e: Expected Obj, but got VT
		//IL_08c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cc: Expected Obj, but got Unknown
		//IL_02ca: Expected Obj, but got I4
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Expected Obj, but got Unknown
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Expected Obj, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got Unknown
		//IL_0590: Expected Obj, but got I4
		//IL_05ad: Expected Obj, but got I4
		//IL_039d: Expected VT, but got Obj
		//IL_039d: Expected VT, but got Obj
		//IL_08d9: Expected Obj, but got I4
		//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Expected Obj, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_01cd: Expected Obj, but got I4
		//IL_0206: Expected Obj, but got I4
		//IL_020f: Expected Obj, but got I4
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected I4, but got Obj
		//IL_0534: Expected I4, but got Obj
		//IL_0534: Expected I4, but got Obj
		//IL_0534: Expected Obj, but got Unknown
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected Obj, but got Unknown
		//IL_0300: Expected Obj, but got I4
		//IL_06a4: Expected Obj, but got I4
		//IL_074d: Expected Obj, but got I4
		//IL_0786: Expected Obj, but got I4
		//IL_0643: Expected Obj, but got I4
		//IL_0648: Expected Obj, but got I4
		//IL_0857: Expected Obj, but got I4
		//IL_0866: Expected Obj, but got F8
		//IL_06cb: Expected Obj, but got I4
		//IL_016a: Expected Obj, but got I4
		//IL_07d9: Expected Obj, but got I4
		//IL_024f: Expected Obj, but got I4
		//IL_0274->IL0026: Incompatible stack types: I4 vs Obj
		//IL_056d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0688->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03ef->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0296->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05e8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0613->IL0026: Incompatible stack types: I4 vs Obj
		//IL_045d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_050a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01bf->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0716->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01a8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_077e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0807->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02b4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0233->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0606->IL0026: Incompatible stack types: I4 vs Obj
		//IL_08d6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02de->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0822->IL0026: Incompatible stack types: I4 vs Obj
		//IL_062d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_033e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0595->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05b8->IL0026: Incompatible stack heights: 1 vs 2
		//IL_03b1->IL0026: Incompatible stack heights: 5 vs 2
		//IL_08ed->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06f1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0373->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01d7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0162->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0548->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0417->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04ae->IL0026: Incompatible stack types: I4 vs Obj
		//IL_027f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0578->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0693->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0351->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03fa->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02a1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05f3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0468->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0515->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01ca->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0721->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02c7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0305->IL0026: Incompatible stack types: I4 vs Obj
		//IL_08bb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06b8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0761->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0790->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0663->IL0026: Incompatible stack types: I4 vs Obj
		//IL_086b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06d5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0174->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0812->IL0026: Incompatible stack types: I4 vs Obj
		//IL_023e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02e9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0638->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05a0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0893->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0203->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04e5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03bc->IL0026: Incompatible stack heights: 5 vs 2
		//IL_08f8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06fc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_037e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0553->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0422->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04b9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0310->IL0026: Incompatible stack types: I4 vs Obj
		//IL_08c6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06c3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_076c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_066e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0876->IL0026: Incompatible stack types: I4 vs Obj
		//IL_089e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04f0->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 31;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				case 60:
					obj = new RegexRunner[obj];
					obj2 = 12;
					continue;
				case 18:
					return obj;
				case 26:
					obj--;
					obj2 = 41;
					continue;
				case 23:
					obj = 0;
					obj2 = 35;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field == 0)
					{
						obj2 = 26;
					}
					continue;
				case 57:
					obj = 0;
					obj2 = 10;
					continue;
				default:
					_ = obj * 4;
					_ = 4;
					/*Error near IL_01e1: Member reference must be method, but was: Field*/;
				case 10:
				case 48:
					if (Unsafe.As<object, UIntPtr>(ref obj) >= Unsafe.As<object, UIntPtr>(ref obj))
					{
						obj2 = 18;
						continue;
					}
					goto case 47;
				case 58:
					obj = 1;
					obj = 40;
					break;
				case 22:
					return obj;
				case 5:
					return P_0;
				case 35:
					obj--;
					obj2 = 32;
					if (_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic == null)
					{
						obj2 = 15;
					}
					continue;
				case 32:
				case 41:
					if ((nint)obj >= 0)
					{
						obj = 44;
						break;
					}
					goto case 27;
				case 3:
				case 15:
					((sbyte[])obj)[obj] = (sbyte)((byte[])P_0)[((int[])obj)[obj]];
					obj2 = 39;
					if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType3<, >._003Centry_003Ei__Field)._003Csid_003Ei__Field != 0)
					{
						obj2 = 33;
					}
					continue;
				case 12:
					obj = 0;
					obj2 = 16;
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance == null)
					{
						obj2 = 6;
					}
					continue;
				case 34:
					obj = new Color[obj];
					obj2 = 14;
					continue;
				case 25:
				case 40:
					if (Unsafe.As<object, UIntPtr>(ref obj) < Unsafe.As<object, UIntPtr>(ref obj))
					{
						obj2 = 9;
						continue;
					}
					goto case 28;
				case 38:
					obj = 0;
					obj2 = 63;
					if ((int)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_defaultTimeout == 0)
					{
						obj2 = 2;
					}
					continue;
				case 27:
					if ((nint)obj > 0)
					{
						obj2 = 64;
						if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_ascii_68FF03FEFFFF87FEFFFF07 != null)
						{
							obj2 = 19;
						}
						continue;
					}
					goto case 62;
				case 61:
					_ = 0;
					_ = obj - obj;
					/*Error near IL_031b: Member reference must be method, but was: Field*/;
				case 43:
					obj += 4;
					obj2 = 26;
					continue;
				case 7:
				case 63:
					if (Unsafe.As<object, UIntPtr>(ref obj) < Unsafe.As<object, UIntPtr>(ref obj))
					{
						obj2 = 19;
						continue;
					}
					goto case 21;
				case 9:
				case 56:
				{
					object obj3 = obj;
					object obj4 = obj;
					obj = obj4 + 1;
					((sbyte[])obj3)[obj4] = (sbyte)((byte[])P_0)[obj];
					obj2 = 2;
					if (((EntitySocks5Account)EntitySocks5Account.Username__BackingField).Password__BackingField == null)
					{
						obj2 = 6;
					}
					continue;
				}
				case 50:
					_ = 0;
					((EqualityComparer<_00213>)obj).Equals((_00213?)(obj - obj), (_00213?)obj);
					_ = 53;
					if (((EntitySocks5)EntitySocks5.Address__BackingField).Port__BackingField == 0)
					{
						_ = 38;
					}
					continue;
				case 8:
				case 19:
					((sbyte[])obj)[obj] = (sbyte)(byte)(((byte[])P_0)[obj] ^ 0xA5);
					obj2 = 4;
					if (EntitySocks5.DecorateDynamicModule == null)
					{
						obj2 = 4;
					}
					continue;
				case 65:
					obj = new char[obj];
					obj2 = 9;
					if (((EntityLaunchGameProxy)EntityLaunchGameProxy.GameId__BackingField).GameType__BackingField == 0)
					{
						obj2 = 57;
					}
					continue;
				case 16:
					obj = 0;
					obj2 = 52;
					if (((EntityLaunchGameProxy)EntityLaunchGameProxy.Name__BackingField).ServerAddress__BackingField == null)
					{
						obj2 = 40;
					}
					continue;
				case 1:
				case 66:
				{
					object obj6 = obj;
					object obj7 = obj;
					obj = obj7 + 1;
					((sbyte[])obj6)[obj7] = (sbyte)((byte[])P_0)[obj];
					obj2 = 1;
					if (((EntityLaunchGameProxy)EntityLaunchGameProxy.Value__BackingField).IsGame__BackingField != 0)
					{
						obj2 = 37;
					}
					continue;
				}
				case 49:
				case 59:
					if (Unsafe.As<object, UIntPtr>(ref obj) < Unsafe.As<object, UIntPtr>(ref obj))
					{
						obj2 = 4;
						if (((GameProxy)(object)EntityLaunchGameProxy.ReflectAlphabeticProcessor)._003Cargs_003EP == null)
						{
							obj2 = 15;
						}
						continue;
					}
					goto case 22;
				case 20:
					obj = ((byte[])P_0)[obj];
					obj2 = 22;
					if (((GameProxy)GameProxy.Logger__BackingField)._pinger != null)
					{
						obj2 = 33;
					}
					continue;
				case 64:
					((RegexRunner)(obj * 4)).Capture((int)obj, (int)obj, (int)obj);
					_ = 62;
					if (((GameProxy)(object)GameProxy.OnlineClients).Name__BackingField == null)
					{
						_ = 32;
					}
					continue;
				case 4:
					obj++;
					obj2 = 1;
					if (((GameProxy)GameProxy.Session__BackingField).GameType__BackingField == 0)
					{
						obj2 = 7;
					}
					continue;
				case 45:
				{
					object obj5 = obj;
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities._002Ecctor();
					obj = obj5;
					obj2 = 51;
					if (((GameProxy)GameProxy.GameVersion__BackingField).ModHashList__BackingField == null)
					{
						obj2 = 39;
					}
					continue;
				}
				case 47:
					((EntitySocks5Account)obj)._002Ector((string)obj, (string)((byte[])P_0)[obj]);
					((sbyte[])/*Error near IL_05ae: Stack underflow*/)[/*Error near IL_05ae: Stack underflow*/] = (sbyte)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field);
					_ = 42;
					continue;
				case 13:
					obj = new Delegate[obj];
					obj2 = 11;
					if (((GameProxy)GameProxy.TransferServerAddress__BackingField).TransferServerPort__BackingField == 0)
					{
						obj2 = 45;
					}
					continue;
				case 36:
					obj = new AsyncTaskMethodBuilder[obj];
					obj2 = 61;
					continue;
				case 14:
					obj = 0;
					obj2 = 2;
					continue;
				case 42:
					obj++;
					obj2 = 36;
					if (!((GameProxy)(object)GameProxy.Socks5).IsGame)
					{
						obj2 = 48;
					}
					continue;
				case 21:
					return obj;
				case 6:
					obj += 2;
					obj2 = 25;
					if (((GameProxy)GameProxy._channel).DisplayAddress__BackingField != null)
					{
						obj2 = 1;
					}
					continue;
				case 17:
					goto IL_0693;
				case 55:
					return obj;
				case 54:
					obj = obj % 5 + 1;
					obj2 = 36;
					if (GameProxy._003C_003EO._003C2_003E__OnConnectServer == null)
					{
						obj2 = 30;
					}
					continue;
				case 24:
					obj++;
					obj2 = 29;
					if ((int)((GameProxy._003CListenAsync_003Ed__69*)GameProxy._003CListenAsync_003Ed__69._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj2 = 19;
					}
					continue;
				case 28:
					return obj;
				case 31:
					obj = ((EntitySocks5)P_1).Account;
					obj2 = 30;
					continue;
				case 53:
					return obj;
				case 11:
					obj = new PooledByteBufferAllocator[obj];
					obj = 38;
					break;
				case 30:
					switch (obj - 1)
					{
					case 7:
						break;
					case 4:
						goto IL_063b;
					case 0:
						goto IL_0693;
					case 1:
						goto IL_069f;
					case 6:
						goto IL_06c6;
					case 2:
						goto IL_0748;
					case 3:
						goto IL_0781;
					default:
						goto IL_07d0;
					case 5:
						goto IL_0852;
					}
					obj = ((Array)P_0).Length;
					obj2 = 13;
					continue;
				case 33:
					((sbyte[])obj)[obj] = (sbyte)(byte)(((obj >> 4) & 0xF) | ((obj & 0xF) << 4));
					obj2 = 9;
					if ((int)((CpsDetector)(object)CpsDetector._rightClicks)._lastLeftCps != 0)
					{
						obj2 = 24;
					}
					continue;
				case 39:
					obj++;
					obj2 = 49;
					continue;
				case 62:
					return obj;
				case 46:
				case 52:
					if (Unsafe.As<object, UIntPtr>(ref obj) < Unsafe.As<object, UIntPtr>(ref obj))
					{
						obj2 = 1;
						if (OrangeProtocol.StartMapper != null)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 58;
				case 2:
				case 29:
					if (Unsafe.As<object, UIntPtr>(ref obj) >= Unsafe.As<object, UIntPtr>(ref obj))
					{
						obj2 = 55;
						if (((OhMyGodHwid)OhMyGodEncryption.DecorateEfficientEmitter).Hwid__BackingField != null)
						{
							obj2 = 22;
						}
						continue;
					}
					goto case 20;
				case 37:
					obj += 2;
					obj2 = 46;
					continue;
				case 51:
					{
						obj = 0;
						obj2 = 59;
						if (OhMyGodHwid.ControlProcessor == null)
						{
							obj2 = 15;
						}
						continue;
					}
					IL_0852:
					obj = ((Array)P_0).Length;
					obj2 = 31;
					if (((CpsDetector)CpsDetector._lastRightCps).OnCpsChange == null)
					{
						obj2 = 34;
					}
					continue;
					IL_07d0:
					obj = 5;
					break;
					IL_0781:
					obj = ((Array)P_0).Length;
					obj2 = 11;
					continue;
					IL_0748:
					obj = ((Array)P_0).Length;
					obj2 = 54;
					if (GameProxy._003CListenAsync_003Ed__69.CheckCentralResponder == null)
					{
						obj2 = 15;
					}
					continue;
					IL_06c6:
					obj = ((Array)P_0).Length;
					obj2 = 65;
					continue;
					IL_069f:
					obj = ((Array)P_0).Length;
					obj2 = 60;
					if (GameProxy._003C_003EO._003C0_003E__PluginChanged != null)
					{
						obj2 = 18;
					}
					continue;
					IL_063b:
					num = ((Array)P_0).Length;
					obj = num / 4;
					obj = num % 4;
					obj = new EventBus[num];
					obj2 = 23;
					if (((GameProxy)GameProxy.WorkerGroup__BackingField).AcceptorGroup__BackingField != null)
					{
						obj2 = 13;
					}
					continue;
					IL_0693:
					((ILogger)/*Error near IL_0699: Stack underflow*/).Debug<string>((string)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (string)P_0);
					((ILogger)/*Error near IL_069e: Stack underflow*/).Information<string, string>((string)/*Error near IL_069e: Stack underflow*/, (string)/*Error near IL_069e: Stack underflow*/, (string)/*Error near IL_069e: Stack underflow*/);
					return (object)/*Error near IL_069f: Stack underflow*/;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00蘀(object P_0, Guid P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778843, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00蠀(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00f0: Expected VT, but got I4
		//IL_004d: Expected VT, but got Ref
		//IL_004f: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got VT
		//IL_00e2: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got Ref
		//IL_00bc: Expected VT, but got Obj
		//IL_016d: Expected VT, but got I4
		//IL_016d: Expected VT, but got Ref
		//IL_0063->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00e7->IL0022: Incompatible stack heights: 0 vs 1
		//IL_00c8->IL0026: Incompatible stack heights: 1 vs 2
		//IL_006e->IL0026: Incompatible stack heights: 1 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 4;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 1:
					obj = ((EqualityComparer<_00210>)/*Error near IL_004d: Stack underflow*/).Equals((_00210?)/*Error near IL_004d: Stack underflow*/, (_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
					_ = 0;
					if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
					{
						_ = 0;
					}
					continue;
				case 2:
					((_003C_003Ef__AnonymousType0<>)obj).ToString();
					_ = 1000;
					/*Error near IL_007b: Member reference must be method, but was: Field*/;
				case 4:
					obj = ((AbstractBootstrap<ServerBootstrap, IServerChannel>)/*Error near IL_00bc: Stack underflow*/).Option<TimeSpan>((ChannelOption<TimeSpan>)/*Error near IL_00bc: Stack underflow*/, (TimeSpan)((AbstractBootstrap<ServerBootstrap, IServerChannel>)(object)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Option<int>((ChannelOption<int>)P_1, 8));
					_ = 3;
					continue;
				case 5:
					return obj;
				case 3:
					break;
				default:
				{
					int hashCode = ((EqualityComparer<_00212>)obj).GetHashCode((_00212)1);
					switch (2)
					{
					case 1:
						/*Error near IL_011a: Member reference must be method, but was: Field*/;
					case 2:
						_ = 2;
						/*Error near IL_0143: Member reference must be method, but was: Field*/;
					default:
					{
						obj = new EqualityComparer<_00213>((_00213?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00213?)hashCode);
						int num = 0;
						if (((EntitySocks5)EntitySocks5.Address__BackingField).Port__BackingField != 0)
						{
							num = 0;
						}
						switch (num)
						{
						default:
							_ = 1;
							/*Error near IL_01a6: Member reference must be method, but was: Field*/;
						}
					}
					}
				}
				}
				break;
			}
			Unsafe.As<_003Caction_003Ej__TPar, AsyncTaskMethodBuilder>(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<IChannel>*)P_1, ref *(GameProxy._003CListenAsync_003Ed__69*)8);
			obj = Interlocked.CompareExchange(ref *(Action<double, double>*)/*Error near IL_00d7: Stack underflow*/, (Action<double, double>)/*Error near IL_00d7: Stack underflow*/, (Action<double, double>)/*Error near IL_00d7: Stack underflow*/);
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00褀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778842, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00言(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0067: Expected I4, but got Obj
		//IL_01b9: Expected Obj, but got Ref
		//IL_01c8: Expected I4, but got Obj
		//IL_01c7: Expected native int or pointer, but got Obj
		//IL_019d: Expected I4, but got Obj
		//IL_019c: Expected native int or pointer, but got Obj
		//IL_01a6: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got VT
		//IL_017b: Expected Obj, but got Ref
		//IL_0184: Expected Obj, but got I4
		//IL_0166: Expected Obj, but got I4
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got Unknown
		//IL_0097: Expected Obj, but got I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected VT, but got I4
		//IL_015a: Expected Obj, but got I4
		//IL_0134: Expected VT, but got I4
		//IL_0134: Expected VT, but got I4
		//IL_0134: Expected Obj, but got Ref
		//IL_0139: Expected Obj, but got I4
		//IL_011d: Expected Obj, but got VT
		//IL_01c3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01dc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0087->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0170->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01f7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ab->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0145->IL0026: Incompatible stack heights: 1 vs 2
		//IL_01e7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0122->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_012d->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 14;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 5:
					obj = ((int[])obj)[obj];
					obj2 = 3;
					if ((int)((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
					{
						obj2 = 2;
					}
					continue;
				case 10:
					obj = P_0 - 1;
					obj2 = 0;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
					{
						obj2 = 0;
					}
					continue;
				case 4:
				case 12:
					_ = obj + 1;
					/*Error near IL_00bc: Member reference must be method, but was: Field*/;
				default:
					if ((nint)obj > 0)
					{
						obj2 = 4;
						if (_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument != null)
						{
							obj2 = 2;
						}
						continue;
					}
					goto case 11;
				case 14:
					obj = Interlocked.CompareExchange(ref *(Action<double, double>*)/*Error near IL_0139: Stack underflow*/, (Action<double, double>)/*Error near IL_0139: Stack underflow*/, (Action<double, double>)((EqualityComparer<_00211>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals((_00211?)0, (_00211?)P_0));
					_ = 13;
					continue;
				case 13:
					obj = new EqualityComparer<_00212>((_00212)1592639215);
					obj = 10;
					break;
				case 8:
					obj = ((int[])obj)[obj];
					obj2 = 5;
					continue;
				case 6:
					obj = (object)Unsafe.AsPointer(ref ((Event[])obj)[obj]);
					obj = 8;
					break;
				case 3:
					*(int*)(nint)obj = (int)obj;
					obj = 2;
					break;
				case 11:
					return obj;
				case 1:
					obj = (object)Unsafe.AsPointer(ref ((ChannelHandlerAdapter[])obj)[obj]);
					obj2 = 6;
					continue;
				case 2:
					*(int*)(nint)obj = (int)obj;
					obj2 = 9;
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.GuideMap == null)
					{
						obj2 = 3;
					}
					continue;
				case 9:
					obj--;
					obj2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00謀(Guid P_0, object P_1)
	{
		//IL_0021: Expected VT, but got Ref
		//IL_0026: Expected Obj, but got I4
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		string.Format((IFormatProvider?)/*Error near IL_002c: Stack underflow*/, ((object)((EqualityComparer<_00210>)(object)Unsafe.As<_003Caction_003Ej__TPar, RegexRunner>(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)/*cast due to constrained. prefix*/).GetHashCode((_00210)(&P_0))).ToString(), (object?[])P_1);
		_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
		/*Error near IL_0031: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00谀(Guid P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778837, new IntPtr(2737367936924L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00贀(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_03bc: Expected VT, but got Ref
		//IL_03d2: Expected Obj, but got I
		//IL_005f: Expected Obj, but got VT
		//IL_007b: Expected Obj, but got I4
		//IL_007b: Expected Obj, but got Ref
		//IL_008a: Expected Obj, but got VT
		//IL_03e7: Expected Obj, but got Ref
		//IL_0421: Expected Obj, but got I4
		//IL_0423: Expected Obj, but got I4
		//IL_0429: Expected Obj, but got I4
		//IL_0429: Expected Obj, but got I4
		//IL_042b: Expected Obj, but got I4
		//IL_0434: Expected Obj, but got I4
		//IL_00e6: Expected VT, but got Obj
		//IL_00e6: Expected VT, but got Obj
		//IL_00e8: Expected Obj, but got I4
		//IL_010d: Expected VT, but got Obj
		//IL_03d7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03d7->IL0026: Incompatible stack types: Obj vs Ref
		//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03fd->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0439->IL0022: Incompatible stack heights: 3 vs 1
		//IL_03e2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03e2->IL0026: Incompatible stack types: Obj vs Ref
		//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0408->IL0026: Incompatible stack heights: 1 vs 2
		ref readonly _003Caction_003Ej__TPar reference = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
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
				case 1:
					obj = new RegexRunner[8];
					obj2 = 0;
					if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
					{
						obj2 = 0;
					}
					continue;
				case 3:
					return obj;
				case 2:
				{
					string text = string.Format((IFormatProvider?)Unsafe.AsPointer(ref reference), (string)obj, (object?[])1);
					int num = 0;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field == 0)
					{
						num = 0;
					}
					while (true)
					{
						switch (num)
						{
						default:
							_ = 2;
							/*Error near IL_00b7: Member reference must be method, but was: Field*/;
						case 1:
							obj = ((EqualityComparer<_00212>)obj).Equals((_00212?)obj, (_00212?)obj);
							num = 2;
							if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance == null)
							{
								num = 1;
							}
							break;
						case 2:
						{
							obj = new EqualityComparer<_00211>((_00211)text);
							int num2 = 0;
							if ((int)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_defaultTimeout == 0)
							{
								num2 = 0;
							}
							switch (num2)
							{
							default:
								_ = 1;
								/*Error near IL_0146: Member reference must be method, but was: Field*/;
							}
						}
						}
					}
				}
				default:
				{
					Type? typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)Unsafe.AsPointer(ref reference));
					((StringBuilder)obj)._002Ector();
					obj2 = 5;
					reference = ref *(_003Caction_003Ej__TPar*)typeFromHandle;
					if (((GameProxy)GameProxy.ServerPort__BackingField).TransferServerAddress__BackingField != null)
					{
						obj2 = 3;
						reference = ref *(_003Caction_003Ej__TPar*)typeFromHandle;
					}
					continue;
				}
				case 4:
					obj = ((StringBuilder)/*Error near IL_03e7: Stack underflow*/).Append((object?)Unsafe.AsPointer(ref reference));
					_ = 0;
					if ((object)((GameProxy)GameProxy.Section__BackingField).Socks5 == null)
					{
						_ = 2;
					}
					continue;
				case 5:
					break;
				}
				break;
			}
			((EntitySocks5Account)obj).ToString();
			EqualityComparer<string> equalityComparer = new EqualityComparer<string>();
			obj = equalityComparer.GetHashCode((string)8);
			obj = ((EqualityComparer<string>)1000).Equals((string?)(object)equalityComparer, (string?)8);
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00踀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778836, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_FF00_FF00輀(Guid P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778839, new IntPtr(2737367947324L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_FF00_FF00退(Guid P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0070: Expected I4, but got Obj
		//IL_003e: Expected Obj, but got Ref
		//IL_0042: Expected Obj, but got Unknown
		//IL_0054: Expected Obj, but got VT
		//IL_0059->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0064->IL0026: Incompatible stack heights: 1 vs 2
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
				((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Caction_003Ej__TPar)P_0);
				obj = (object)/*Error near IL_003e: Stack underflow*/;
				obj = (object)/*Error near IL_0045: Stack underflow*/;
				_ = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field == 0)
				{
					_ = 0;
				}
				break;
			default:
				_ = obj ^ obj;
				_ = 8;
				return (uint)(int)_003C_003Ef__AnonymousType0<>.ReflectJoinedTree();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_FF00_FF00鄀(Guid P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778838, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00鈀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_006c: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got Ref
		//IL_007d: Expected Obj, but got VT
		//IL_0042: Expected VT, but got Obj
		//IL_0042: Expected VT, but got Ref
		//IL_0053: Expected Obj, but got VT
		//IL_0058->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0063->IL0026: Incompatible stack heights: 1 vs 2
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
				obj = new EqualityComparer<_00210>((_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00210?)P_0);
				_ = 1;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					_ = 0;
				}
				break;
			case 1:
			{
				obj = new string((IFormatProvider?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (string)obj, (object?[])0);
				int num = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field == 0)
				{
					num = 0;
				}
				switch (num)
				{
				default:
					/*Error near IL_00a0: Member reference must be method, but was: Field*/;
				}
			}
			default:
				return obj;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00錀(object P_0, Guid P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_011b: Expected I4, but got Obj
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected I4, but got Unknown
		//IL_042e: Expected VT, but got Ref
		//IL_043f: Expected Obj, but got I4
		//IL_0666: Expected Obj, but got I4
		//IL_0667: Expected I4, but got Obj
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got VT
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_055a: Expected Obj, but got I4
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Expected Obj, but got Unknown
		//IL_07c7: Expected native int or pointer, but got Obj
		//IL_024b: Expected VT, but got Obj
		//IL_024b: Expected VT, but got I4
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Expected Obj, but got I4
		//IL_062f: Expected Obj, but got I4
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_0205: Expected Obj, but got VT
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected Obj, but got Unknown
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected Obj, but got Unknown
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected Obj, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected Obj, but got Unknown
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected Obj, but got Unknown
		//IL_063f: Expected Obj, but got I4
		//IL_0198: Expected Obj, but got I4
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected Obj, but got Unknown
		//IL_06eb: Expected Obj, but got I4
		//IL_041e: Expected Obj, but got I4
		//IL_06c7: Expected Obj, but got Ref
		//IL_06c9: Expected Obj, but got I4
		//IL_0487: Expected Obj, but got I4
		//IL_0496: Expected Obj, but got I
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Expected Obj, but got I4
		//IL_0597: Expected Obj, but got I4
		//IL_059b: Expected Obj, but got I4
		//IL_0712: Expected Obj, but got I4
		//IL_0773: Expected Obj, but got I4
		//IL_0778: Expected Obj, but got I4
		//IL_033c: Expected Obj, but got I4
		//IL_0315: Expected Obj, but got I4
		//IL_02a8: Expected Obj, but got I4
		//IL_01b3: Expected Obj, but got I4
		//IL_0444->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0671->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0170->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06e8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0146->IL0026: Incompatible stack types: I4 vs Obj
		//IL_018a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_056e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0659->IL0026: Incompatible stack types: I4 vs Obj
		//IL_07d1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0255->IL0026: Incompatible stack heights: 5 vs 2
		//IL_05f5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0557->IL0022: Incompatible stack heights: 5 vs 1
		//IL_0639->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0366->IL0026: Incompatible stack types: I4 vs Obj
		//IL_020a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04c0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0408->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05cc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_027e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0479->IL0026: Incompatible stack types: I4 vs Obj
		//IL_045f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0649->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01a2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03f8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06ff->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0739->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0428->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06d3->IL0026: Incompatible stack heights: 1 vs 2
		//IL_049b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0228->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0608->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04fb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06b5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05af->IL0026: Incompatible stack types: I4 vs Obj
		//IL_071c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02a0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0789->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0346->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0329->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02bc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03dd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_044f->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0151->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0195->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0579->IL0026: Incompatible stack types: I4 vs Obj
		//IL_07dc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_068e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02df->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04de->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0371->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0215->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04cb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0289->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0484->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01f0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_070a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_023b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0744->IL0026: Incompatible stack types: I4 vs Obj
		//IL_041b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04a6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0506->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06c0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05ba->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0334->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02c7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03e8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0699->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 3;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 9:
					obj = 0;
					obj2 = 25;
					if ((int)((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field)._003Cuser_id_003Ei__Field != 0)
					{
						obj2 = 18;
					}
					continue;
				case 6:
					obj++;
					obj2 = 41;
					continue;
				case 10:
					obj++;
					obj2 = 16;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
					{
						obj2 = 49;
					}
					continue;
				case 42:
					obj = 0;
					obj2 = 39;
					continue;
				case 32:
					if ((nint)obj > 0)
					{
						obj = 23;
						break;
					}
					goto case 36;
				case 22:
				case 41:
					if ((nint)obj >= ((Array)P_0).Length)
					{
						obj2 = 5;
						continue;
					}
					goto case 16;
				case 28:
					obj--;
					obj2 = 0;
					if (_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic == null)
					{
						obj2 = 0;
					}
					continue;
				case 56:
					obj = new IByteBuffer[obj];
					obj2 = 42;
					continue;
				case 25:
				case 46:
					if (Unsafe.As<object, UIntPtr>(ref obj) < Unsafe.As<object, UIntPtr>(ref obj))
					{
						obj2 = 54;
						continue;
					}
					goto case 50;
				case 17:
					_ = obj - obj;
					((EqualityComparer<_00212>)obj).Equals((_00212?)0, (_00212?)obj);
					_ = 30;
					continue;
				case 34:
					((sbyte[])obj)[obj] = (sbyte)(byte)(((obj >> 4) & 0xF) | ((obj & 0xF) << 4));
					obj2 = 15;
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance != null)
					{
						obj2 = 5;
					}
					continue;
				case 11:
					return obj;
				case 13:
					return obj;
				case 55:
					return obj;
				case 26:
					return P_0;
				case 8:
				case 19:
					if (Unsafe.As<object, UIntPtr>(ref obj) >= Unsafe.As<object, UIntPtr>(ref obj))
					{
						obj2 = 55;
						continue;
					}
					goto case 27;
				case 58:
					_ = obj * 4;
					_ = 4;
					/*Error near IL_02e9: Member reference must be method, but was: Field*/;
				case 44:
					return obj;
				case 36:
					return obj;
				case 27:
					((sbyte[])obj)[((int[])obj)[obj]] = (sbyte)((byte[])P_0)[obj];
					obj2 = 7;
					if (((EntitySocks5)EntitySocks5Account.AttachElement).Address__BackingField != null)
					{
						obj2 = 31;
					}
					continue;
				case 30:
					_ = 0;
					_ = obj - obj;
					/*Error near IL_037c: Member reference must be method, but was: Field*/;
				case 2:
					switch (obj - 1)
					{
					case 3:
						obj = new Color[((Array)P_0).Length];
						obj2 = 14;
						continue;
					case 7:
						obj = ((Array)P_0).Length;
						obj2 = 9;
						if ((int)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_defaultTimeout == 0)
						{
							obj2 = 47;
						}
						continue;
					case 6:
						obj = ((Array)P_0).Length;
						obj2 = 25;
						if (((EntitySocks5Account)EntitySocks5Account.Username__BackingField).Password__BackingField != null)
						{
							obj2 = 57;
						}
						continue;
					case 5:
						obj = ((Array)P_0).Length;
						obj2 = 56;
						continue;
					default:
						obj2 = 15;
						if (((EntityLaunchGameProxy)EntityLaunchGameProxy.Session__BackingField).GameId__BackingField != null)
						{
							obj2 = 26;
						}
						continue;
					case 0:
						break;
					case 1:
					{
						int num2 = ((Array)P_0).Length;
						obj = new IChannel[num2];
						obj = (num2 + 1) / 2;
						obj = num2 / 2;
						obj2 = 9;
						if (((GameProxy)GameProxy.ModHashList__BackingField).ServerAddress__BackingField != null)
						{
							obj2 = 5;
						}
						continue;
					}
					case 2:
						obj = ((Array)P_0).Length;
						obj2 = 33;
						continue;
					case 4:
					{
						int num = ((Array)P_0).Length;
						obj = num / 4;
						obj = num % 4;
						obj = new Exception[num];
						obj2 = 24;
						continue;
					}
					}
					goto case 1;
				case 43:
					obj++;
					obj2 = 46;
					continue;
				case 31:
					obj++;
					obj2 = 19;
					continue;
				case 12:
				case 49:
					if (Unsafe.As<object, UIntPtr>(ref obj) >= Unsafe.As<object, UIntPtr>(ref obj))
					{
						obj2 = 13;
						continue;
					}
					goto case 4;
				case 50:
					obj = 0;
					obj2 = 53;
					continue;
				case 3:
					((_003C_003Ef__AnonymousType3<, >)/*Error near IL_042e: Stack underflow*/)._002Ector((_003Centry_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_003Csid_003Ej__TPar)P_1);
					obj = (object)/*Error near IL_0430: Stack underflow*/;
					_ = 2;
					if (((EntityLaunchGameProxy)EntityLaunchGameProxy.GameVersion__BackingField).ModHashList__BackingField != null)
					{
						_ = 2;
					}
					continue;
				case 37:
					obj += 4;
					obj2 = 28;
					continue;
				case 35:
					obj--;
					obj2 = 14;
					if (((EntityLaunchGameProxy)EntityLaunchGameProxy.Name__BackingField).ServerAddress__BackingField != null)
					{
						obj2 = 38;
					}
					continue;
				case 52:
					obj = 0;
					obj2 = 8;
					if (((EntityLaunchGameProxy)EntityLaunchGameProxy.ServerPort__BackingField).Socks5__BackingField != null)
					{
						obj2 = 8;
					}
					continue;
				case 29:
					obj++;
					obj2 = 17;
					if (((EntityLaunchGameProxy)EntityLaunchGameProxy.Value__BackingField).IsGame__BackingField != 0)
					{
						obj2 = 18;
					}
					continue;
				case 21:
				case 39:
					if (Unsafe.As<object, UIntPtr>(ref obj) >= Unsafe.As<object, UIntPtr>(ref obj))
					{
						obj2 = 44;
						continue;
					}
					goto case 40;
				case 59:
					obj = new StringSplitOptions[obj];
					obj2 = 9;
					if (GameProxy.Logger__BackingField != null)
					{
						obj2 = 17;
					}
					continue;
				case 23:
					_ = obj * 4;
					((RegexRunner)obj)._002Ector();
					obj = 36;
					break;
				case 14:
					obj = 0;
					obj2 = 16;
					if (((GameProxy)GameProxy.Name__BackingField).Session__BackingField != null)
					{
						obj2 = 22;
					}
					continue;
				case 1:
					((AsyncTaskMethodBuilder<HeypixelRequestDto>*)/*Error near IL_057f: Stack underflow*/)->AwaitUnsafeOnCompleted(ref Unsafe.As<_003Caction_003Ej__TPar, TaskAwaiter<HeypixelRequestDto>>(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), ref *(MassServiceExtensions._003CGetHeypixelAntiCheat_003Ed__2*)P_0);
					return ((MassService)/*Error near IL_0584: Stack underflow*/).ApiRequestAsync<HeypixelRequestDto>((string)/*Error near IL_0584: Stack underflow*/, (object?)/*Error near IL_0584: Stack underflow*/);
				case 33:
					obj = obj % 5 + 1;
					obj2 = 59;
					continue;
				case 20:
					((sbyte[])obj)[obj * 2 + 1] = (sbyte)((byte[])P_0)[(object)(obj + obj)];
					obj2 = 29;
					continue;
				case 57:
					obj = new Delegate[obj];
					obj2 = 45;
					continue;
				case 24:
					obj = 0;
					obj2 = 35;
					continue;
				case 40:
					obj = ((byte[])P_0)[obj];
					obj2 = 34;
					continue;
				case 15:
					obj++;
					obj2 = 21;
					continue;
				case 4:
					((sbyte[])obj)[obj] = (sbyte)(int)((EntitySocks5Account)((byte[])P_0)[obj]).Password;
					obj2 = 10;
					continue;
				case 18:
				case 53:
					if (Unsafe.As<object, UIntPtr>(ref obj) >= Unsafe.As<object, UIntPtr>(ref obj))
					{
						obj2 = 48;
						if (!((GameProxy)(object)GameProxy.Socks5).IsGame)
						{
							obj2 = 26;
						}
						continue;
					}
					goto case 20;
				default:
					if ((nint)obj < 0)
					{
						obj2 = 23;
						if (((GameProxy)GameProxy.BlockIrcMessages).WorkerGroup__BackingField == null)
						{
							obj2 = 32;
						}
						continue;
					}
					goto case 58;
				case 51:
					obj = (EntitySocks5Account?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field) == (EntitySocks5Account?)obj;
					_ = 52;
					continue;
				case 7:
				case 54:
					((sbyte[])obj)[obj * 2] = (sbyte)((byte[])P_0)[obj];
					obj2 = 43;
					continue;
				case 45:
					obj = 0;
					obj2 = 12;
					if (((GameProxy)GameProxy._channel).DisplayAddress__BackingField == null)
					{
						obj2 = 2;
					}
					continue;
				case 48:
					return obj;
				case 47:
					obj = new LoggerExtensions[obj];
					obj2 = 51;
					if (GameProxy.ReflectSimpleVerifier != null)
					{
						obj2 = 38;
					}
					continue;
				case 5:
					return obj;
				case 16:
					((sbyte[])obj)[obj] = (sbyte)(byte)(((byte[])P_0)[obj] ^ 0xA5);
					obj2 = 1;
					if (((GameProxy._003CListenAsync_003Ed__69*)(nint)GameProxy._003CListenAsync_003Ed__69._003C_003E4__this)->port != 0)
					{
						obj2 = 6;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00鐀(object P_0, Guid P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778833, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00销()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00阀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778832, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00需(byte P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0062: Expected Obj, but got VT
		//IL_0067->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0099->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a4->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				P_0 = (byte)(((P_0 & 0xAA) >> 1) | ((P_0 & 0x55) << 1));
				obj2 = 0;
				if ((int)((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				P_0 = (byte)(((P_0 & 0xCC) >> 2) | ((P_0 & 0x33) << 2));
				obj2 = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field != 0)
				{
					obj2 = 1;
				}
				break;
			default:
				return P_0;
			case 3:
				P_0 = (byte)(((P_0 >> 4) & 0xF) | ((P_0 & 0xF) << 4));
				obj2 = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00頀()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00餀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778835, new IntPtr(2737367946284L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint _FF00_FF00_FF00_FF00_FF00騀(long P_0, uint P_1)
	{
		return (uint)((P_0 % (int)P_1 + (int)P_1) % (int)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00鬀(long P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778834, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00鰀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778413, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00鴀(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0067: Expected I4, but got Obj
		//IL_0120: Expected I4, but got Obj
		//IL_011f: Expected native int or pointer, but got Obj
		//IL_0074: Expected I4, but got Obj
		//IL_0073: Expected native int or pointer, but got Obj
		//IL_007d: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I4
		//IL_00fa: Expected Obj, but got VT
		//IL_0228: Expected Obj, but got Ref
		//IL_0177: Expected Obj, but got Ref
		//IL_0186: Expected Obj, but got VT
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_0111: Expected Obj, but got I4
		//IL_01e9: Expected VT, but got I4
		//IL_01e9: Expected VT, but got Ref
		//IL_01f4: Expected Obj, but got I4
		//IL_0146: Expected VT, but got I4
		//IL_0146: Expected VT, but got I4
		//IL_0146: Expected Obj, but got Ref
		//IL_014b: Expected VT, but got I4
		//IL_0089: Expected Obj, but got I4
		//IL_0098: Expected Obj, but got VT
		//IL_00d6: Expected Obj, but got VT
		//IL_0134->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ff->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0232->IL0026: Incompatible stack types: I4 vs Obj
		//IL_018b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01b0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00bf->IL0026: Incompatible stack heights: 3 vs 2
		//IL_011b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01f9->IL0022: Incompatible stack heights: 0 vs 1
		//IL_0161->IL0026: Incompatible stack heights: 1 vs 2
		//IL_009d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_013f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00db->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0196->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01bb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_016c->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00a8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e6->IL0026: Incompatible stack types: I4 vs Obj
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
				case 2:
					return obj;
				case 1:
					*(int*)(nint)obj = (int)obj;
					obj = 9;
					break;
				case 14:
					obj = ((int[])obj)[obj];
					obj2 = 0;
					if ((int)((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field)._003Cuser_id_003Ei__Field != 0)
					{
						obj2 = 0;
					}
					continue;
				case 6:
				case 10:
					obj = ((object)(obj + 1)).ToString();
					_ = 8;
					continue;
				case 5:
				case 7:
					if ((nint)obj > 0)
					{
						obj2 = 6;
						if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field == 0)
						{
							obj2 = 3;
						}
						continue;
					}
					goto case 2;
				case 3:
					obj = P_0 - 1;
					obj2 = 7;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Ccontext_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
					{
						obj2 = 4;
					}
					continue;
				case 11:
					obj = ((int[])obj)[obj];
					obj2 = 14;
					continue;
				default:
					*(int*)(nint)obj = (int)obj;
					obj2 = 1;
					if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field == 0)
					{
						obj2 = 1;
					}
					continue;
				case 13:
					obj = ((AbstractBootstrap<ServerBootstrap, IServerChannel>)/*Error near IL_014b: Stack underflow*/).Option<TimeSpan>((ChannelOption<TimeSpan>)/*Error near IL_014b: Stack underflow*/, (TimeSpan)((EqualityComparer<_00212>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals((_00212?)0, (_00212?)P_0));
					_ = 1;
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectLocalTemplate == null)
					{
						_ = 12;
					}
					continue;
				case 8:
					obj = (object)Unsafe.AsPointer(ref ((Guid[])obj)[obj]);
					obj2 = 0;
					if (!_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_hasTimeout)
					{
						obj2 = 4;
					}
					continue;
				case 9:
					obj--;
					obj2 = 5;
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.GuideMap != null)
					{
						obj2 = 5;
					}
					continue;
				case 12:
					obj = new EqualityComparer<_00213>((_00213?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00213?)1592639215);
					obj = 3;
					break;
				case 4:
					obj = (object)Unsafe.AsPointer(ref ((TimeSpan[])obj)[obj]);
					obj2 = 11;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00鸀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778412, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00鼀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778415, new IntPtr(2737367946284L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00ꀀ(byte P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0064: Expected Obj, but got VT
		//IL_00c5: Expected Obj, but got VT
		//IL_009b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0069->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ca->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0074->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d5->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return P_0;
			case 2:
				P_0 = (byte)(((P_0 & 0xCC) >> 2) | ((P_0 & 0x33) << 2));
				obj2 = 1;
				if ((int)((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field)._003Cuser_id_003Ei__Field != 0)
				{
					obj2 = 1;
				}
				break;
			case 1:
				P_0 = (byte)(((P_0 & 0xAA) >> 1) | ((P_0 & 0x55) << 1));
				obj2 = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				P_0 = (byte)(((P_0 >> 4) & 0xF) | ((P_0 & 0xF) << 4));
				obj2 = 1;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field == 0)
				{
					obj2 = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00ꄀ(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778414, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00ꈀ(Guid P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778409, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00ꌀ(Guid P_0, object P_1)
	{
		//IL_0019: Expected VT, but got Ref
		//IL_002c: Expected Obj, but got I4
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		string.Format((IFormatProvider?)((EqualityComparer<_00210>)/*Error near IL_0019: Stack underflow*/).Equals((_00210?)/*Error near IL_0019: Stack underflow*/, (_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)), ((GameInstance*)(&P_0))->ToString(), (object?[])P_1);
		_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
		/*Error near IL_0031: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00ꐀ(Guid P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778408, new IntPtr(2737367948364L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
