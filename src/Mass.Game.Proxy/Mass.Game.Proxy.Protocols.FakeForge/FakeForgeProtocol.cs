using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using DotNetty.Buffers;
using Mass.Application.Event;
using Mass.Game.Proxy.Minecraft.Events;
using Mass.Game.Proxy.Minecraft.Events.Play;
using Mass.Game.Proxy.Minecraft.Protocol;
using Mass.Game.Proxy.Packets.Play;
using Mass.Game.Proxy.Protocols.FakeForge.FmlHandshake.Messages;
using Mass.Game.Proxy.Protocols.Heypixel;
using Mass.Game.Proxy.Protocols.Hyt.VexView;
using Mass.Game.Proxy.Protocols.OhMyGod;

namespace Mass.Game.Proxy.Protocols.FakeForge;

public class FakeForgeProtocol : Protocol
{
	private static object CloneProvider;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FakeForgeProtocol(List<string> channelNames, List<FmlMod> mods)
	{
		//IL_001b: Expected VT, but got Obj
		//IL_0027: Expected VT, but got Obj
		//IL_0041: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)channelNames;
		((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuser_id_003Ei__Field = (_003Cuser_id_003Ej__TPar)mods;
		((_003C_003Ef__AnonymousType0<>)(object)this).GetHashCode();
		int num = 0;
		if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field == 0)
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
	public unsafe FakeForgeProtocol()
	{
		//IL_001a: Expected VT, but got Obj
		//IL_001a: Expected VT, but got Ref
		//IL_001f: Expected VT, but got Obj
		//IL_0033: Expected Obj, but got VT
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType0<>)new EqualityComparer<_00210>((_00210)new EqualityComparer<_00210>((_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00210?)this))).GetHashCode();
		int num = 0;
		if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field == 0)
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
	public unsafe FakeForgeProtocol(List<string> channelNames)
	{
		//IL_001b: Expected VT, but got Obj
		//IL_001b: Expected VT, but got Obj
		//IL_0020: Expected Obj, but got Ref
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals(new EqualityComparer<_00210>((_00210?)this, (_00210?)channelNames));
		int num = 0;
		if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
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
	[SubscribeEvent]
	public virtual void OnJoinGame(EventPacket<ClientboundJoinGamePacket> @event)
	{
		_FF00_FF00㘀(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public virtual void OnClientPluginMessage(EventClientPluginMessage @event)
	{
		_FF00_FF00_3300(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public virtual void OnServerPluginMessage(EventServerPluginMessage @event)
	{
		_FF00_FF00㨀(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SendFmlHandshakeMessage(object message)
	{
		_FF00_FF00䐀(message);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void SendRegisterChannel(string channelName = "REGISTER", List<string>? overrideChannelNames = null)
	{
		_FF00_FF00㸀(channelName, overrideChannelNames);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SendPluginMessage(string channelName, IByteBuffer buffer)
	{
		_FF00_FF00㠀(channelName, buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectExternalState()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FakeForgeProtocol ReflectOperationalHandler()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_3200(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779390, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_3300(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_004b: Expected VT, but got Obj
		//IL_004b: Expected Obj, but got Ref
		//IL_005c: Expected Obj, but got VT
		//IL_037c: Expected VT, but got I4
		//IL_0061->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0370->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0392->IL0026: Incompatible stack heights: 3 vs 2
		//IL_006c->IL0026: Incompatible stack heights: 1 vs 2
		//IL_039d->IL0026: Incompatible stack heights: 3 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Caction_003Ej__TPar)obj);
				obj = (object)/*Error near IL_004d: Stack underflow*/;
				_ = 4;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
				{
					_ = 3;
				}
				break;
			default:
				((_003C_003Ef__AnonymousType0<>)obj).ToString();
				/*Error near IL_0074: Member reference must be method, but was: Field*/;
			case 3:
				_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities._002Ecctor();
				obj = P_0;
				obj2 = 2;
				break;
			case 4:
				obj = Type.GetTypeFromHandle((RuntimeTypeHandle)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.InstantiateVisitor());
				_ = 0;
				if (((GameProxy)GameProxy.ServerAddress__BackingField).ServerPort__BackingField != 0)
				{
					_ = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00㐀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779385, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00㘀(EventPacket<ClientboundJoinGamePacket> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got Obj
		//IL_003f: Expected Obj, but got Ref
		//IL_0059->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0059->IL0026: Incompatible stack types: I4 vs Ref
		//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0064->IL0026: Incompatible stack types: I4 vs Ref
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
				((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref reference))._002Ector((_003Caction_003Ej__TPar)this);
				bool flag = ((_003C_003Ef__AnonymousType0<>)/*Error near IL_0045: Stack underflow*/).Equals((object)null);
				obj2 = 0;
				reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
				{
					obj2 = 0;
					reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
				}
				break;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00㜀(EventPacket<ClientboundJoinGamePacket> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779384, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00㠀(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got Obj
		//IL_003f: Expected Obj, but got Ref
		//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005a->IL0026: Incompatible stack types: I4 vs Ref
		//IL_0065->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0065->IL0026: Incompatible stack types: I4 vs Ref
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
				((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref reference))._002Ector((_003Caction_003Ej__TPar)this);
				bool flag = ((_003C_003Ef__AnonymousType0<>)P_0).Equals(P_1);
				obj2 = 0;
				reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field != 0)
				{
					obj2 = 0;
					reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
				}
				break;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00㤀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779387, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00㨀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_0097: Expected Obj, but got VT
		//IL_009c: Expected Obj, but got VT
		//IL_009e: Expected Obj, but got VT
		//IL_00ad: Expected Obj, but got VT
		//IL_046b: Expected Obj, but got Ref
		//IL_0470: Expected Obj, but got I4
		//IL_0475: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I4
		//IL_004c: Expected VT, but got Obj
		//IL_0053: Expected Obj, but got I4
		//IL_0261: Expected Obj, but got I4
		//IL_03e1: Expected VT, but got I4
		//IL_03d5: Expected Obj, but got I4
		//IL_02db: Expected Obj, but got I
		//IL_038b: Expected VT, but got I4
		//IL_029b: Expected VT, but got Obj
		//IL_029b: Expected VT, but got Obj
		//IL_027b: Expected Obj, but got I4
		//IL_0084->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0067->IL0026: Incompatible stack heights: 1 vs 2
		//IL_048e->IL0026: Incompatible stack heights: 1 vs 2
		//IL_03f0->IL00c1: Incompatible stack heights: 5 vs 4
		//IL_01ed->IL00c1: Incompatible stack heights: 6 vs 4
		//IL_0194->IL00c1: Incompatible stack heights: 7 vs 4
		//IL_03da->IL00bd: Incompatible stack heights: 6 vs 4
		//IL_040b->IL0499: Incompatible stack heights: 0 vs 1
		//IL_0406->IL00c1: Incompatible stack heights: 7 vs 4
		//IL_02e0->IL00c1: Incompatible stack heights: 8 vs 4
		//IL_039a->IL00c1: Incompatible stack heights: 5 vs 4
		//IL_02aa->IL00c1: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0499->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00c1->IL00c1: Incompatible stack heights: 5 vs 4
		//IL_01f8->IL00c1: Incompatible stack heights: 6 vs 4
		//IL_0280->IL00bd: Incompatible stack heights: 3 vs 4
		//IL_02eb->IL00c1: Incompatible stack heights: 8 vs 4
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
				return;
			case 4:
				obj = _003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
				_ = 3;
				break;
			case 2:
			{
				FakeForgeProtocol fakeForgeProtocol = this;
				obj = ((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType0<>.ReflectJoinedTree())._003Cuser_id_003Ei__Field).uuid).user_id;
				int num = 5;
				if (_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument != null)
				{
					num = 10;
				}
				while (true)
				{
					switch (num)
					{
					case 14:
						if ((nint)obj != 3)
						{
							num = 15;
							continue;
						}
						break;
					case 2:
					case 16:
						_ = 2;
						((_003C_003Ef__AnonymousType1<, , >)new { }).ToString();
						_ = 27;
						continue;
					case 9:
						if (!(obj is OhMyGodHwid))
						{
							num = 19;
							continue;
						}
						goto case 5;
					case 6:
						_ = ((_003C_003Ef__AnonymousType2<, , , >)new { }).context;
						_ = 13;
						if (((EntitySocks5Account)EntitySocks5Account.Username__BackingField).Password__BackingField != null)
						{
							_ = 26;
						}
						continue;
					default:
						obj = _003C_003Ef__AnonymousType2<, , , >.DisableDecryptor();
						obj = 21;
						continue;
					case 10:
						if (obj is VexViewGuiPacket)
						{
							obj = 4;
							continue;
						}
						goto case 20;
					case 26:
					{
						bool flag = ((_003C_003Ef__AnonymousType3<, >)(object)fakeForgeProtocol).Equals((object)new
						{
							entry = (_003Centry_003Ej__TPar)this,
							sid = (_003Csid_003Ej__TPar)((EntityLaunchGameProxy)(object)this).GameId__BackingField
						});
						num = 24;
						fakeForgeProtocol = (FakeForgeProtocol)flag;
						continue;
					}
					case 7:
						if (!(obj is HeypixelHwid))
						{
							num = 28;
							continue;
						}
						goto case 3;
					case 3:
					case 23:
						_ = 3;
						_ = new { };
						_003C_003Ef__AnonymousType3<, >.LoadCache();
						_ = 12;
						if (((EntityLaunchGameProxy)EntityLaunchGameProxy.ServerPort__BackingField).Socks5__BackingField == null)
						{
							_ = 5;
						}
						continue;
					case 13:
						if (obj is HeypixelProtocol._003CInitialize_003Ed__17)
						{
							num = 3;
							continue;
						}
						goto case 7;
					case 20:
						if (obj is HeypixelProtocol._003CStartAntiCheatAsync_003Ed__34)
						{
							num = 0;
							if (((GameProxy)(object)EntityLaunchGameProxy.ReflectAlphabeticProcessor)._003Cargs_003EP == null)
							{
								num = 2;
							}
							continue;
						}
						goto case 13;
					case 28:
						obj = obj as MassServiceExtensions;
						num = 8;
						continue;
					case 21:
						if ((nint)obj != 2)
						{
							num = 14;
							continue;
						}
						goto case 25;
					case 25:
						((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)new _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner((ReadOnlySpan<char>)4))._002Ector();
						_ = 11;
						continue;
					case 8:
						if (obj != null)
						{
							num = 0;
							if (((GameProxy)GameProxy.Session__BackingField).GameType__BackingField == 0)
							{
								num = 0;
							}
							continue;
						}
						goto case 9;
					case 4:
					case 17:
						_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities._002Ecctor();
						_ = null;
						_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.InstantiateVisitor();
						obj = 6;
						continue;
					case 5:
					case 11:
					case 12:
					case 15:
					case 19:
					case 24:
					case 27:
						((StringBuilder)(object)new Type((RuntimeTypeHandle)1))._002Ector();
						_ = 18;
						continue;
					case 22:
						break;
					case 18:
						return;
					}
					_ = 5;
					_ = ((EntitySocks5Account)(object)new EntitySocks5Account()).Username;
					_ = 5;
				}
			}
			case 3:
				if (!((Type?)/*Error near IL_0475: Stack underflow*/ == (Type?)((EntitySocks5Account?)/*Error near IL_0470: Stack underflow*/ == (EntitySocks5Account?)((EntitySocks5Account?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field) != (EntitySocks5Account?)obj))))
				{
					((_003C_003Ef__AnonymousType0<>)/*Error near IL_004c: Stack underflow*/)._002Ector((_003Caction_003Ej__TPar)obj);
					obj = ((EqualityComparer<_00210>)/*Error near IL_0051: Stack underflow*/).GetHashCode((_00210)/*Error near IL_0051: Stack underflow*/);
					_ = 2;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field != 0)
					{
						_ = 2;
					}
				}
				else
				{
					_ = 1;
					if (((GameProxy)GameProxy.DisplayAddress__BackingField).ProxyPort__BackingField != 0)
					{
						_ = 1;
					}
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00㬀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779386, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe void _FF00_FF00㴀(object P_0, List<string> P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779381, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe void _FF00_FF00㸀(object P_0, List<string> P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got Obj
		//IL_0040: Expected VT, but got Obj
		//IL_0040: Expected Obj, but got Ref
		//IL_0045: Expected VT, but got I4
		//IL_005e: Expected I4, but got Obj
		//IL_005e: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got I4
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		switch ((int)obj)
		{
		case 0:
			break;
		case 1:
			((EventBus)((EqualityComparer<_00210>)/*Error near IL_0045: Stack underflow*/).GetHashCode((_00210)((EqualityComparer<_00210>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals((_00210?)this, (_00210?)P_0))).Register((Action<EventMinecraft>)0, (int)(P_1 ?? _003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter));
			_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
			/*Error near IL_0064: Member reference must be method, but was: Field*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe void _FF00_FF00㼀(object P_0, List<string> P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779380, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00䀀()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00䄀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779383, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00䈀()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00䌀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779382, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00䐀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003e: Expected VT, but got Obj
		//IL_003e: Expected Obj, but got Ref
		//IL_004f: Expected Obj, but got I4
		//IL_0072->IL0026: Incompatible stack heights: 6 vs 2
		//IL_007d->IL0026: Incompatible stack heights: 6 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 1:
				((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Caction_003Ej__TPar)this);
				((EqualityComparer<_00210>)/*Error near IL_0043: Stack underflow*/).GetHashCode((_00210)/*Error near IL_0043: Stack underflow*/);
				_ = ((_003C_003Ef__AnonymousType2<, , , >)((_003C_003Ef__AnonymousType0<>)(object)this).GetHashCode())._003Curl_003Ei__Field;
				_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
				_ = ((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType0<>.ReflectJoinedTree()).name;
				_ = 0;
				if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field == 0)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}
}
