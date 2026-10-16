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
using Mass.Game.Proxy.Network.Nbt;
using Mass.Game.Proxy.Protocols.OhMyGod;
using Mass.Game.Proxy.Protocols.Orange;

namespace Mass.Game.Proxy.Network.Team;

public class UpdateTeamInfo : TeamActionBase
{
	private static object ReflectJoinedMatcher;

	public string DisplayName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00뼀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_A700(value);
		}
	}

	public string Prefix
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00찀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00ꨀ(value);
		}
	}

	public string Suffix
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00먀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00봀(value);
		}
	}

	public byte FriendlyFire
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00넀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00였(value);
		}
	}

	public string NameTagVisibility
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00렀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00뤀(value);
		}
	}

	public int Color
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00가();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00대((uint)value);
		}
	}

	public string CollisionRule
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00ꐀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00쀀(value);
		}
	}

	public NbtTag? NbtDisplayName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (NbtTag?)_FF00_FF00_FF00딀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00꤀(value);
		}
	}

	public NbtTag? NbtPrefix
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (NbtTag?)_FF00_FF00_FF00쐀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00숀(value);
		}
	}

	public NbtTag? NbtSuffix
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (NbtTag?)_FF00_FF00_FF00꼀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00섀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UpdateTeamInfo(EnumProtocolVersion version)
	{
		//IL_001b: Expected VT, but got I4
		//IL_0027: Expected Obj, but got Ref
		//IL_0033: Expected VT, but got Obj
		//IL_003f: Expected VT, but got Obj
		//IL_004b: Expected VT, but got Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)version;
		_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter = this;
		((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_0033: Stack underflow*/)._003Cpayload_003Ei__Field = (_003Cpayload_003Ej__TPar)this;
		((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_003f: Stack underflow*/)._003Cuser_id_003Ei__Field = (_003Cuser_id_003Ej__TPar)this;
		((_003C_003Ef__AnonymousType3<, >)/*Error near IL_004b: Stack underflow*/)._003Centry_003Ei__Field = (_003Centry_003Ej__TPar)this;
		_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument = this;
		((_003C_003Ef__AnonymousType1<, , >)(object)this).GetHashCode();
		int num = 0;
		if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.StoreConverter != null)
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
	public override void Read(IByteBuffer buffer)
	{
		_FF00_FF00_FF00ꄀ(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(IByteBuffer buffer)
	{
		_FF00_FF00_FF00케(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectLiteralReg()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static UpdateTeamInfo CheckScalableExecutor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00ꀀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776677, new IntPtr(2737368315228L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00ꄀ(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_00bf: Expected I4, but got Obj
		//IL_0118: Expected Obj, but got I4
		//IL_011d: Expected Obj, but got VT
		//IL_012c: Expected Obj, but got VT
		//IL_015e: Expected Obj, but got I4
		//IL_0512: Expected Obj, but got I4
		//IL_0517: Expected Obj, but got I4
		//IL_0455: Expected Obj, but got I4
		//IL_04dc: Expected Obj, but got I4
		//IL_02fe: Expected VT, but got Obj
		//IL_0303: Expected VT, but got I4
		//IL_03d8: Expected Obj, but got Ref
		//IL_04f7: Expected Obj, but got I4
		//IL_01fe: Expected Obj, but got I4
		//IL_0203: Expected Obj, but got I4
		//IL_020c: Expected Obj, but got I4
		//IL_01d0: Expected VT, but got I4
		//IL_01d0: Expected VT, but got Obj
		//IL_01d0: Expected VT, but got Obj
		//IL_01d0: Expected VT, but got Ref
		//IL_02a2: Expected VT, but got Obj
		//IL_014d: Expected Obj, but got I4
		//IL_0369: Expected Obj, but got I4
		//IL_04aa: Expected native int or pointer, but got Obj
		//IL_04b1: Expected Obj, but got I4
		//IL_026f: Expected Obj, but got I4
		//IL_043a: Expected Obj, but got I4
		//IL_043f: Expected Obj, but got I4
		//IL_028c: Expected Obj, but got I4
		//IL_0291: Expected Obj, but got I4
		//IL_00d2: Expected Obj, but got VT
		//IL_00d7: Expected Obj, but got I4
		//IL_00e6: Expected Obj, but got VT
		//IL_0131->IL0026: Incompatible stack heights: 5 vs 2
		//IL_016d->IL0026: Incompatible stack heights: 6 vs 2
		//IL_038a->IL0026: Incompatible stack heights: 3 vs 2
		//IL_052b->IL0026: Incompatible stack heights: 3 vs 2
		//IL_046e->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0249->IL0026: Incompatible stack heights: 7 vs 2
		//IL_04eb->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0338->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0317->IL0026: Incompatible stack heights: 3 vs 2
		//IL_03e2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03e2->IL0026: Incompatible stack types: Obj vs Ref
		//IL_0506->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0211->IL0022: Incompatible stack heights: 4 vs 1
		//IL_01df->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01df->IL0026: Incompatible stack types: I4 vs Ref
		//IL_02bb->IL0026: Incompatible stack heights: 4 vs 2
		//IL_036e->IL0022: Incompatible stack heights: 2 vs 1
		//IL_04c5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_049e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0354->IL0026: Incompatible stack heights: 7 vs 2
		//IL_0274->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0449->IL0026: Incompatible stack heights: 3 vs 2
		//IL_01f2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_013c->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0536->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0479->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0254->IL0026: Incompatible stack heights: 7 vs 2
		//IL_03cc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0224->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0322->IL0026: Incompatible stack heights: 3 vs 2
		//IL_02c6->IL0026: Incompatible stack heights: 4 vs 2
		//IL_01a0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04d0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_029b->IL0026: Incompatible stack heights: 5 vs 2
		//IL_03a0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00eb->IL0026: Incompatible stack heights: 4 vs 2
		//IL_03b6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04a9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0422->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0556->IL0026: Incompatible stack types: I4 vs Obj
		//IL_027f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f6->IL0026: Incompatible stack heights: 4 vs 2
		//IL_042d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0561->IL0026: Incompatible stack types: I4 vs Obj
		ref readonly _003Caction_003Ej__TPar reference = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 28;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 26:
					return;
				case 7:
					/*Error near IL_00f8: Member reference must be method, but was: Field*/;
				case 3:
					_ = ((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType1<, , >)32767).uuid).user_id;
					_ = 12;
					if (_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument != null)
					{
						_ = 17;
					}
					continue;
				case 23:
					obj = _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance;
					obj = 2;
					break;
				case 4:
					((_003C_003Ef__AnonymousType1<, , >)32767).ToString();
					_003C_003Ef__AnonymousType1<, , >.ReflectScalableStack();
					_ = 18;
					continue;
				case 29:
					/*Error near IL_016f: Member reference must be method, but was: Field*/;
				case 32:
					return;
				default:
					/*Error near IL_0184: Member reference must be method, but was: Field*/;
				case 27:
					if ((nint)obj <= 340)
					{
						obj2 = 35;
						continue;
					}
					goto case 1;
				case 20:
				{
					((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_01d0: Stack underflow*/)._002Ector((_003Curl_003Ej__TPar)Unsafe.AsPointer(ref reference), (_003Cpayload_003Ej__TPar)this, (_003Ccontext_003Ej__TPar)P_0, (_003Cuser_id_003Ej__TPar)32767);
					bool flag = ((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_01d5: Stack underflow*/).Equals((object)/*Error near IL_01d5: Stack underflow*/);
					obj2 = 9;
					reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
					continue;
				}
				case 2:
					if ((nint)obj != 47)
					{
						obj2 = 30;
						continue;
					}
					((EntitySocks5Account)(object)this).Equals((EntitySocks5Account?)((EntitySocks5Account)P_0).Equals((object?)32767));
					_ = 7;
					continue;
				case 19:
					((_003C_003Ef__AnonymousType2<, , , >)((_003C_003Ef__AnonymousType2<, , , >)32767).GetHashCode()).ToString();
					obj = 25;
					break;
				case 14:
					if ((nint)obj != 47)
					{
						obj2 = 36;
						continue;
					}
					goto case 11;
				case 10:
					_ = 32767;
					_003C_003Ef__AnonymousType2<, , , >.CheckAccessibleObject();
					_003C_003Ef__AnonymousType2<, , , >.DisableDecryptor();
					_ = 6;
					if (((EntityLaunchGameProxy)EntityLaunchGameProxy.Session__BackingField).GameId__BackingField != null)
					{
						_ = 12;
					}
					continue;
				case 1:
					if ((nint)obj != 757)
					{
						obj2 = 13;
						if (((EntityLaunchGameProxy)EntityLaunchGameProxy.GameType__BackingField).GameVersion__BackingField != EnumGameVersion.None)
						{
							obj2 = 8;
						}
						continue;
					}
					goto IL_0339;
				case 34:
					return;
				case 22:
					Regex.ValidateMatchTimeout((TimeSpan)P_0);
					_003C_003Ef__AnonymousType3<, >.DecorateIntegratedProgram();
					_ = 6;
					if (((EntityLaunchGameProxy)EntityLaunchGameProxy.Socks5__BackingField).Value__BackingField == null)
					{
						_ = 8;
					}
					continue;
				case 6:
					/*Error near IL_02c8: Member reference must be method, but was: Field*/;
				case 15:
					((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)(object)this).TryMatchAtCurrentPosition((ReadOnlySpan<char>)((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)P_0).TryFindNextPossibleStartingPosition((ReadOnlySpan<char>)((GameProxy)(object)this)._pinger));
					_ = 5;
					if (((GameProxy)GameProxy.Name__BackingField).Session__BackingField == null)
					{
						_ = 2;
					}
					continue;
				case 12:
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.DecorateCustomNode();
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities._002Ecctor();
					_ = 4;
					continue;
				case 16:
					return;
				case 25:
					((StringBuilder)P_0)._002Ector();
					_ = ((EntitySocks5Account)(object)this).EqualityContract;
					obj = 16;
					break;
				case 5:
					((EntitySocks5Account)P_0).Username = (string)((GameProxy)(object)this).TransferServerAddress__BackingField;
					_ = ((EntitySocks5Account)(object)this).Password;
					_ = 32;
					continue;
				case 30:
					if ((nint)obj != 340)
					{
						obj2 = 24;
						continue;
					}
					((_003C_003Ef__AnonymousType3<, >)((_003C_003Ef__AnonymousType3<, >)32767).GetHashCode()).ToString();
					_ = 19;
					continue;
				case 31:
					if ((nint)obj != 766)
					{
						obj2 = 21;
						continue;
					}
					((_003C_003Ef__AnonymousType0<>)((_003C_003Ef__AnonymousType0<>)P_0).Equals((object)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field)).GetHashCode();
					_ = 22;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field != 0)
					{
						_ = 6;
					}
					continue;
				case 13:
					if ((nint)obj != 763)
					{
						obj2 = 31;
						continue;
					}
					goto IL_0339;
				case 17:
				{
					((EntitySocks5Account)(object)this).Password = (string)P_0;
					string text = ((EntitySocks5Account)Unsafe.AsPointer(ref reference)).ToString();
					obj2 = 15;
					reference = ref *(_003Caction_003Ej__TPar*)text;
					continue;
				}
				case 35:
					if ((nint)obj != 5)
					{
						obj2 = 4;
						if (((GameProxy)GameProxy.AcceptorGroup__BackingField)._channel != null)
						{
							obj2 = 14;
						}
						continue;
					}
					goto case 11;
				case 24:
					return;
				case 9:
					((EntitySocks5Account)P_0)._002Ector(((EntitySocks5Account)32767)._003CClone_003E_0024());
					_ = 3;
					if (GameProxy._003C_003EO._003C1_003E__OnConnectServer == null)
					{
						_ = 6;
					}
					continue;
				case 33:
					((EntitySocks5)(object)this)._002Ector((string)P_0, 32767, EntitySocks5Account.RunWriter());
					obj2 = 10;
					if (((GameProxy._003CListenAsync_003Ed__69)GameProxy._003CListenAsync_003Ed__69._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 7;
					}
					continue;
				case 28:
					obj = ((GameProxy._003CListenAsync_003Ed__69*)(nint)this)->port;
					obj2 = 12;
					if (GameProxy._003CListenAsync_003Ed__69.CheckCentralResponder == null)
					{
						obj2 = 27;
					}
					continue;
				case 11:
					((EntitySocks5)P_0).Account = ((EntitySocks5)32767).Account;
					_ = 20;
					continue;
				case 18:
					EntitySocks5.Parse((string?)32767).ToString();
					_ = 26;
					continue;
				case 8:
					_ = (EntitySocks5?)(object)this != (EntitySocks5?)((EntitySocks5)P_0).PrintMembers((StringBuilder)32767);
					_ = 0;
					if (OrangeProtocol.StartMapper != null)
					{
						_ = 3;
					}
					continue;
				case 36:
					{
						if ((nint)obj != 340)
						{
							obj2 = 0;
							if (((OhMyGodHwid)OhMyGodEncryption.DecorateEfficientEmitter).Hwid__BackingField != null)
							{
								obj2 = 0;
							}
							continue;
						}
						goto case 11;
					}
					IL_0339:
					_ = 32767;
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.InstantiateVisitor();
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.PatchWatcher();
					_ = 29;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00ꈀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776676, new IntPtr(2737368308988L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00ꌀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776679, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00ꐀ()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00ꔀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776678, new IntPtr(2737368331868L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00ꘀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776673, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_A700(object P_0)
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
	internal unsafe void _FF00_FF00_FF00ꠀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776672, new IntPtr(2737368325628L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00꤀(object P_0)
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
	internal void _FF00_FF00_FF00ꨀ(object P_0)
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
	internal unsafe uint _FF00_FF00_FF00_AB00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776675, new IntPtr(2737368307948L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00가()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (uint)(int)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00관()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776674, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00글()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776701, new IntPtr(2737368316268L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00꼀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00뀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776700, new IntPtr(2737368301708L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00넀()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (byte)(int)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00눀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776703, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00대(uint P_0)
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
	internal unsafe void _FF00_FF00_FF00됀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776702, new IntPtr(2737368328748L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00딀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00똀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776697, new IntPtr(2737368307948L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00뜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776696, new IntPtr(2737368310028L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00렀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00뤀(object P_0)
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
	internal object _FF00_FF00_FF00먀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00묀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776699, new IntPtr(2737368328748L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00밀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776698, new IntPtr(2737368328748L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00봀(object P_0)
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
	internal unsafe void _FF00_FF00_FF00븀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776693, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00뼀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00쀀(object P_0)
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
	internal void _FF00_FF00_FF00섀(object P_0)
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
	internal void _FF00_FF00_FF00숀(object P_0)
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
	internal unsafe void _FF00_FF00_FF00쌀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776692, new IntPtr(2737368302748L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00쐀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00씀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776695, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00였(byte P_0)
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
	internal unsafe static object _FF00_FF00_FF00윀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776694, new IntPtr(2737368307948L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00저()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00준()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776689, new IntPtr(2737368325628L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00쨀()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00쬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776688, new IntPtr(2737368314188L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00찀()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00촀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776691, new IntPtr(2737368315228L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00츀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776690, new IntPtr(2737368320428L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00케(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_00bf: Expected I4, but got Obj
		//IL_04ea: Expected Obj, but got I4
		//IL_02f9: Expected VT, but got Obj
		//IL_0303: Expected Obj, but got I4
		//IL_02dd: Expected VT, but got Obj
		//IL_02e7: Expected VT, but got I4
		//IL_02e7: Expected Obj, but got Ref
		//IL_00e7: Expected Obj, but got I4
		//IL_00e7: Expected Obj, but got Ref
		//IL_04c4: Expected native int or pointer, but got Obj
		//IL_04ce: Expected I4, but got VT
		//IL_04ce: Expected Obj, but got Ref
		//IL_0113: Expected Obj, but got VT
		//IL_02d1: Expected Obj, but got I4
		//IL_0225: Expected VT, but got Obj
		//IL_0225: Expected VT, but got Obj
		//IL_0225: Expected Obj, but got Ref
		//IL_022f: Expected Obj, but got I4
		//IL_0457: Expected Obj, but got I4
		//IL_00cb: Expected VT, but got Obj
		//IL_00d0: Expected VT, but got Ref
		//IL_051d: Expected Obj, but got I4
		//IL_051d: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I4
		//IL_0134: Expected VT, but got I4
		//IL_0134: Expected VT, but got Obj
		//IL_0134: Expected Obj, but got Ref
		//IL_01e8: Expected Obj, but got I4
		//IL_03b2: Expected Obj, but got I
		//IL_03d4: Expected Obj, but got I4
		//IL_01b0: Expected VT, but got I4
		//IL_01b0: Expected VT, but got Obj
		//IL_01b0: Expected VT, but got Ref
		//IL_0387: Expected Obj, but got I
		//IL_0410: Expected Obj, but got I4
		//IL_02ab: Expected Obj, but got I
		//IL_0213->IL0026: Incompatible stack heights: 6 vs 2
		//IL_04f5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_030e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02f2->IL0026: Incompatible stack heights: 1 vs 2
		//IL_050c->IL0026: Incompatible stack heights: 4 vs 2
		//IL_00f2->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0172->IL0026: Incompatible stack heights: 5 vs 2
		//IL_04d9->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0118->IL0026: Incompatible stack heights: 6 vs 2
		//IL_023a->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0445->IL0026: Incompatible stack types: I4 vs Obj
		//IL_046c->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0341->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0489->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00db->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0532->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0156->IL0026: Incompatible stack types: I4 vs Obj
		//IL_013f->IL0026: Incompatible stack heights: 1 vs 2
		//IL_021e->IL0026: Incompatible stack heights: 6 vs 2
		//IL_0285->IL0026: Incompatible stack heights: 6 vs 2
		//IL_055f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03b7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0123->IL0026: Incompatible stack heights: 6 vs 2
		//IL_0433->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03df->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03f5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04b1->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0361->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01c5->IL0026: Incompatible stack heights: 1 vs 2
		//IL_038c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0415->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0477->IL0026: Incompatible stack heights: 3 vs 2
		//IL_02b0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_053d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0290->IL0026: Incompatible stack heights: 6 vs 2
		//IL_03c2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04bc->IL0026: Incompatible stack heights: 1 vs 2
		//IL_036c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01d0->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0397->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0420->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02bb->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 23;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					return;
				case 33:
					((_003C_003Ef__AnonymousType0<>)P_0)._002Ector((_003Caction_003Ej__TPar)this);
					((EqualityComparer<_00210>)/*Error near IL_00d0: Stack underflow*/).GetHashCode((_00210)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
					_ = 31;
					continue;
				case 10:
					string.Format((IFormatProvider?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (string)P_0, (object?[])((_003C_003Ef__AnonymousType0<>)(object)this).GetHashCode());
					_ = 30;
					continue;
				case 13:
					_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
					_ = 32767;
					_003C_003Ef__AnonymousType0<>.ReflectJoinedTree();
					_ = 1;
					if (_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic == null)
					{
						_ = 0;
					}
					continue;
				case 36:
					((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Cname_003Ej__TPar)P_0, (_003Cuuid_003Ej__TPar)((_003C_003Ef__AnonymousType1<, , >)(object)this).user_id, (_003Cuser_id_003Ej__TPar)32767);
					_ = 26;
					continue;
				case 35:
					((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType1<, , >)P_0).Equals((object)this)).GetHashCode();
					obj2 = 5;
					continue;
				case 11:
					((_003C_003Ef__AnonymousType1<, , >)(object)this).ToString();
					_ = 32767;
					_003C_003Ef__AnonymousType1<, , >.ReflectScalableStack();
					_ = 7;
					continue;
				case 29:
					_003C_003Ef__AnonymousType1<, , >.ReflectModularWriter();
					/*Error near IL_0179: Member reference must be method, but was: Field*/;
				case 24:
					return;
				case 32:
					return;
				case 9:
				case 25:
					/*Error near IL_01d1: Member reference must be method, but was: Field*/;
				case 3:
					if ((nint)obj != 5)
					{
						obj = 14;
						break;
					}
					goto case 13;
				case 1:
					_003C_003Ef__AnonymousType2<, , , >.CheckAccessibleObject();
					_ = 32767;
					_003C_003Ef__AnonymousType2<, , , >.DisableDecryptor();
					_ = 21;
					if (((EntityLaunchGameProxy)EntityLaunchGameProxy.Session__BackingField).GameId__BackingField == null)
					{
						_ = 6;
					}
					continue;
				case 21:
					((_003C_003Ef__AnonymousType3<, >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Centry_003Ej__TPar)P_0, (_003Csid_003Ej__TPar)this);
					((_003C_003Ef__AnonymousType3<, >)/*Error near IL_022f: Stack underflow*/).Equals((object)32767);
					_ = 33;
					continue;
				case 18:
					return;
				case 28:
					if ((nint)obj != 757)
					{
						obj2 = 2;
						if ((object)EntityLaunchGameProxy.ReflectAlphabeticProcessor == null)
						{
							obj2 = 15;
						}
						continue;
					}
					goto IL_03c3;
				case 19:
					((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory)(object)((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory)(object)this).CreateInstance())._002Ector();
					obj = 12;
					break;
				case 7:
					((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)P_0).Scan((ReadOnlySpan<char>)this);
					((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).TryFindNextPossibleStartingPosition((ReadOnlySpan<char>)32767);
					_ = 35;
					continue;
				case 6:
					((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)P_0).TryMatchAtCurrentPosition((ReadOnlySpan<char>)this);
					((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)32767)._002Ector();
					obj2 = 19;
					continue;
				case 26:
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.VerifyVerifier();
					/*Error near IL_0315: Member reference must be method, but was: Field*/;
				case 30:
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities._002Ecctor();
					_ = 32767;
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.InstantiateVisitor();
					_ = 6;
					continue;
				case 17:
					if ((nint)obj != 766)
					{
						obj2 = 1;
						if (((GameProxy)GameProxy.ModHashList__BackingField).ServerAddress__BackingField == null)
						{
							obj2 = 25;
						}
						continue;
					}
					((EntitySocks5)P_0)._002Ector((string)(object)this, EntitySocks5Account.ReflectScopePolicy() ? 1 : 0, (EntitySocks5Account?)(object)GameProxy._003C_003EO._003C2_003E__OnConnectServer);
					_ = 8;
					if (((GameProxy._003CListenAsync_003Ed__69)GameProxy._003CListenAsync_003Ed__69._003C_003Et__builder)._003C_003E4__this == null)
					{
						_ = 10;
					}
					continue;
				case 20:
					if ((nint)obj == 340)
					{
						((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_01b0: Stack underflow*/)._002Ector((_003Curl_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_003Cpayload_003Ej__TPar)P_0, (_003Ccontext_003Ej__TPar)((_003C_003Ef__AnonymousType2<, , , >)(object)this).user_id, (_003Cuser_id_003Ej__TPar)32767);
						_ = 24;
						if (((EntitySocks5)EntitySocks5Account.AttachElement).Address__BackingField == null)
						{
							_ = 36;
						}
					}
					else
					{
						obj2 = 16;
						if (((GameProxy)GameProxy.ServerPort__BackingField).TransferServerAddress__BackingField == null)
						{
							obj2 = 18;
						}
					}
					continue;
				case 4:
					if ((nint)obj != 340)
					{
						obj2 = 8;
						if (((GameProxy)GameProxy.TransferServerPort__BackingField).Section__BackingField == null)
						{
							obj2 = 9;
						}
						continue;
					}
					goto case 13;
				case 16:
					return;
				case 15:
					if ((nint)obj != 763)
					{
						obj2 = 17;
						continue;
					}
					goto IL_03c3;
				case 22:
					if ((nint)obj <= 340)
					{
						obj2 = 3;
						if (((GameProxy)GameProxy.BlockIrcMessages).WorkerGroup__BackingField == null)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 28;
				case 14:
					if ((nint)obj != 47)
					{
						obj2 = 4;
						continue;
					}
					goto case 13;
				case 23:
					obj = ((GameProxy)(object)this).AcceptorGroup__BackingField;
					obj2 = 22;
					continue;
				case 27:
					((EntitySocks5Account)((EntitySocks5Account)(object)this).GetHashCode()).Equals((EntitySocks5Account?)((GameProxy)(object)this).DisplayAddress__BackingField);
					_ = 26;
					if (GameProxy.ReflectSimpleVerifier != null)
					{
						_ = 32;
					}
					continue;
				case 31:
					obj = GameProxy._003C_003EO._003C0_003E__PluginChanged;
					obj2 = 2;
					continue;
				case 0:
					return;
				case 12:
					((EntitySocks5)P_0).Address = (string)(object)this;
					((EntitySocks5)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Port = (int)((GameProxy._003CListenAsync_003Ed__69*)(nint)this)->_003C_003Eu__1;
					_ = 27;
					continue;
				case 5:
					((EntitySocks5)(object)((EntitySocks5)(object)this).Account).Account = (EntitySocks5Account?)32767;
					obj2 = 34;
					continue;
				case 8:
					EntitySocks5.Parse((string?)(object)this);
					_ = EqualityComparer<EntitySocks5>.Default;
					_ = 24;
					continue;
				case 34:
					_ = (EntitySocks5?)((EntitySocks5)P_0).PrintMembers((StringBuilder)(object)this) != (EntitySocks5?)32767;
					obj2 = 0;
					if (OrangeProtocol.StartMapper == null)
					{
						obj2 = 0;
					}
					continue;
				case 2:
					{
						if ((nint)obj != 47)
						{
							obj2 = 20;
							continue;
						}
						_003C_003Ef__AnonymousType3<, >.LoadCache();
						_ = 32767;
						_003C_003Ef__AnonymousType3<, >.DecorateIntegratedProgram();
						_ = 2;
						if (((EntityLaunchGameProxy)EntityLaunchGameProxy.Socks5__BackingField).Value__BackingField == null)
						{
							_ = 8;
						}
						continue;
					}
					IL_03c3:
					((EntitySocks5Account)P_0).Password = (string)(object)this;
					((EntitySocks5Account)32767).ToString();
					obj2 = 29;
					continue;
				}
				break;
			}
		}
	}
}
