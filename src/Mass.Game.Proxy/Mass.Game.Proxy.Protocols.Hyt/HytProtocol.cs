using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using Mass.Application.Event;
using Mass.Game.Proxy.Minecraft.Events;
using Mass.Game.Proxy.Minecraft.Events.Play;
using Mass.Game.Proxy.Packets.Play;
using Mass.Game.Proxy.Protocols.FakeForge;
using Mass.Game.Proxy.Protocols.Heypixel;

namespace Mass.Game.Proxy.Protocols.Hyt;

public class HytProtocol : FakeForgeProtocol
{
	private nint _linkFlag;

	private object? _data;

	internal static HytProtocol CheckFilteredDistributor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe HytProtocol()
	{
		//IL_001a: Expected VT, but got Obj
		//IL_001a: Expected VT, but got Ref
		//IL_0025: Expected Obj, but got I4
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		EqualityComparer<_00210> equalityComparer = (EqualityComparer<_00210>)new EqualityComparer<_00210>((_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00210?)this);
		((_003C_003Ef__AnonymousType0<>)(object)((object)((_003C_003Ef__AnonymousType0<>)(object)equalityComparer).Equals((object)equalityComparer)).ToString()).ToString();
		/*Error near IL_002b: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public override void OnServerPluginMessage(EventServerPluginMessage @event)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00_F800(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public override void OnJoinGame(EventPacket<ClientboundJoinGamePacket> @event)
	{
		Ѐ(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnGermPacket(object packet)
	{
		Ā(packet);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnVexViewPacket(object packet)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00_E100(packet);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SendGermPacket(object packet)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00_E700(packet);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SendVexViewPacket(object packet)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00_E500(packet);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateAutomatedNotifier()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HytProtocol DecoratePassiveDispatcher()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00팀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778850, new IntPtr(2737367931724L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00퐀()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00픀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778877, new IntPtr(2737367931724L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E000(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778876, new IntPtr(2737367946284L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E100(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_006f: Expected I4, but got Obj
		//IL_0267: Expected Obj, but got I4
		//IL_0276: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got VT
		//IL_012c: Expected Obj, but got VT
		//IL_018a: Expected Obj, but got Ref
		//IL_018f: Expected Obj, but got I4
		//IL_014f: Expected Obj, but got I4
		//IL_0165: Expected Obj, but got VT
		//IL_016a: Expected VT, but got Obj
		//IL_016a: Expected Obj, but got I4
		//IL_022e: Expected VT, but got Obj
		//IL_022e: Expected Obj, but got Ref
		//IL_00e1: Expected VT, but got Obj
		//IL_00e6: Expected Obj, but got Ref
		//IL_00ec: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I4
		//IL_0214: Expected VT, but got Obj
		//IL_0214: Expected Obj, but got Ref
		//IL_027b->IL0026: Incompatible stack heights: 3 vs 2
		//IL_013e->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0174->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0240->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0100->IL0026: Incompatible stack heights: 4 vs 2
		//IL_01ef->IL0098: Incompatible stack heights: 2 vs 1
		//IL_021e->IL0228: Incompatible stack heights: 0 vs 1
		//IL_0286->IL0026: Incompatible stack heights: 3 vs 2
		//IL_029c->IL025e: Incompatible stack heights: 2 vs 1
		//IL_01d3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0203->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0228->IL0026: Incompatible stack heights: 1 vs 2
		//IL_02a6->IL0026: Incompatible stack heights: 3 vs 2
		//IL_01de->IL0026: Incompatible stack types: I4 vs Obj
		//IL_020e->IL0026: Incompatible stack heights: 3 vs 2
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
			case 8:
				return;
			case 12:
			{
				var anon = (_003C_003Ef__AnonymousType1<, , >)new { };
				_003Cuser_id_003Ej__TPar user_id = ((_003C_003Ef__AnonymousType1<, , >)obj).user_id;
				anon._002Ector((_003Cname_003Ej__TPar)anon, (_003Cuuid_003Ej__TPar)user_id, user_id);
				((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals(this)).GetHashCode()).ToString();
				_003C_003Ef__AnonymousType1<, , >.ReflectScalableStack();
				_ = 6;
				break;
			}
			default:
				_003C_003Ef__AnonymousType1<, , >.ReflectModularWriter();
				/*Error near IL_0107: Member reference must be method, but was: Field*/;
			case 4:
				_ = ((_003C_003Ef__AnonymousType2<, , , >)((_003C_003Ef__AnonymousType2<, , , >)((_003C_003Ef__AnonymousType2<, , , >)obj).payload).context).user_id;
				_ = 4;
				obj = EqualityComparer<_00213>.Default;
				_ = 12;
				break;
			case 9:
			{
				((_003C_003Ef__AnonymousType2<, , , >)((_003C_003Ef__AnonymousType2<, , , >)new
				{
					value = (object)this
				}).GetHashCode()).ToString();
				bool flag2 = _003C_003Ef__AnonymousType2<, , , >.CheckAccessibleObject();
				object obj3 = _003C_003Ef__AnonymousType2<, , , >.DisableDecryptor();
				((_003C_003Ef__AnonymousType3<, >)flag2)._002Ector((_003Centry_003Ej__TPar)obj3, ((_003C_003Ef__AnonymousType3<, >)((_003C_003Ef__AnonymousType3<, >)obj3).entry).sid);
				_ = 3;
				break;
			}
			case 15:
				return;
			case 7:
				((_003C_003Ef__AnonymousType3<, >)((_003C_003Ef__AnonymousType3<, >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals(obj)).GetHashCode();
				/*Error near IL_018f: Member reference must be method, but was: Field*/;
			case 13:
				if (obj == null)
				{
					obj2 = 6;
					if (((EntityLaunchGameProxy)EntityLaunchGameProxy.Socks5__BackingField).Value__BackingField == null)
					{
						obj2 = 15;
					}
					break;
				}
				goto case 7;
			case 14:
				if ((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectSymbolicAuditor() ? ((ReadOnlySpan<char>*)1) : ((ReadOnlySpan<char>*)null))->Length == 0)
				{
					return;
				}
				_ = 10;
				if (GameProxy.Logger__BackingField == null)
				{
					_ = 0;
				}
				break;
			case 16:
				((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Scan((ReadOnlySpan<char>)P_0);
				((RegexRunner)/*Error near IL_0219: Stack underflow*/).Capture((int)/*Error near IL_0219: Stack underflow*/, (int)/*Error near IL_0219: Stack underflow*/, (int)/*Error near IL_0219: Stack underflow*/);
				if ((int)/*Error near IL_021e: Stack underflow*/ != 0)
				{
					_ = 5;
					break;
				}
				goto case 11;
			case 11:
				((AsyncTaskMethodBuilder<HeypixelHwid>*)((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).TryMatchAtCurrentPosition((ReadOnlySpan<char>)P_0))->Start(ref *(MassServiceExtensions._003CGetHeypixelSession_003Ed__1*)null);
				obj = (object)/*Error near IL_0236: Stack underflow*/;
				_ = 13;
				break;
			case 5:
				return;
			case 6:
				return;
			case 1:
				obj = _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.VerifyVerifier();
				_ = 0;
				if (((GameProxy)GameProxy.GameType__BackingField).GameId__BackingField == null)
				{
					_ = 0;
				}
				break;
			case 3:
				return;
			case 10:
			{
				bool flag = _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.InstantiateVisitor();
				((StringBuilder)(object)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.PatchWatcher())._002Ector();
				if (flag)
				{
					return;
				}
				_ = 16;
				break;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E200(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778879, new IntPtr(2737367936924L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E400(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778878, new IntPtr(2737367931724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E500(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got Obj
		//IL_003f: Expected Obj, but got Ref
		//IL_0049: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got VT
		//IL_0068->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0073->IL0026: Incompatible stack heights: 4 vs 2
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
			case 0:
				return;
			case 1:
				((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Caction_003Ej__TPar)this);
				((object)((_003C_003Ef__AnonymousType0<>)/*Error near IL_0044: Stack underflow*/).Equals((object)/*Error near IL_0044: Stack underflow*/)).ToString();
				((_003C_003Ef__AnonymousType0<>)P_0).ToString();
				_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
				_ = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Ccontext_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E700(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003e: Expected VT, but got Obj
		//IL_003e: Expected Obj, but got Ref
		//IL_0048: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got VT
		//IL_0067->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0072->IL0026: Incompatible stack heights: 4 vs 2
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
				((object)((_003C_003Ef__AnonymousType0<>)/*Error near IL_0043: Stack underflow*/).Equals((object)/*Error near IL_0043: Stack underflow*/)).ToString();
				((_003C_003Ef__AnonymousType0<>)P_0).ToString();
				_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
				_ = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Ccontext_003Ei__Field)._003Cuser_id_003Ei__Field != 0)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_E800(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778873, new IntPtr(2737367931724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F700(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778872, new IntPtr(2737367933804L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_F800(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00b1: Expected VT, but got Obj
		//IL_00b1: Expected VT, but got Ref
		//IL_0129: Expected Obj, but got I4
		//IL_0138: Expected Obj, but got VT
		//IL_0160: Expected Obj, but got VT
		//IL_01ab: Expected VT, but got I4
		//IL_02b6->IL0026: Incompatible stack heights: 5 vs 2
		//IL_02c1->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0257->IL0044: Incompatible stack heights: 0 vs 1
		//IL_0252->IL00de: Incompatible stack heights: 2 vs 1
		//IL_014d->IL0044: Incompatible stack heights: 0 vs 1
		//IL_013d->IL00de: Incompatible stack heights: 2 vs 1
		//IL_0201->IL00de: Incompatible stack heights: 3 vs 1
		//IL_01d4->IL0044: Incompatible stack heights: 0 vs 1
		//IL_0148->IL00de: Incompatible stack heights: 2 vs 1
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
				return;
			case 3:
				return;
			default:
				/*Error near IL_0080: Member reference must be method, but was: Field*/;
			case 2:
				((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_00b1: Stack underflow*/)._002Ector((_003Cname_003Ej__TPar)/*Error near IL_00b1: Stack underflow*/, (_003Cuuid_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_003Cuser_id_003Ej__TPar)obj);
				if (EqualityComparer<_00211>.Default != null)
				{
					int num = 0;
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectLocalTemplate == null)
					{
						num = 3;
					}
					while (true)
					{
						switch (num)
						{
						default:
							return;
						case 0:
							return;
						case 6:
							return;
						case 13:
							return;
						case 8:
							obj = _003C_003Ef__AnonymousType1<, , >.ReflectScalableStack();
							_ = 1;
							if (!_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_hasTimeout)
							{
								_ = 0;
							}
							continue;
						case 3:
						case 10:
							obj = ((_003C_003Ef__AnonymousType2<, , , >)obj).payload;
							num = 4;
							continue;
						case 5:
						case 7:
							_ = 1;
							/*Error near IL_016c: Member reference must be method, but was: Field*/;
						case 12:
							new EqualityComparer<_00213>((_00213)1);
							/*Error near IL_01ab: Member reference must be method, but was: Field*/;
						case 1:
							if (obj != null)
							{
								num = 2;
								continue;
							}
							goto case 12;
						case 11:
							_ = ((_003C_003Ef__AnonymousType3<, >)obj).entry;
							_ = 5;
							continue;
						case 4:
							if (obj == null)
							{
								num = 7;
								continue;
							}
							goto case 11;
						case 9:
							break;
						case 2:
							((_003C_003Ef__AnonymousType3<, >)(object)this).Equals(obj);
							_ = 12;
							continue;
						}
						break;
					}
				}
				_ = ((_003C_003Ef__AnonymousType3<, >)obj).sid;
				/*Error near IL_022c: Member reference must be method, but was: Field*/;
			case 1:
				_003C_003Ef__AnonymousType3<, >.DecorateIntegratedProgram();
				_ = 0;
				if (((EntityLaunchGameProxy)EntityLaunchGameProxy.Socks5__BackingField).Value__BackingField != null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00豈(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778875, new IntPtr(2737367931724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00切()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ﬀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778874, new IntPtr(2737367931724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Ā(object P_0)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.ArgumentNullException: Value cannot be null. (Parameter 'source')
		//    at System.Linq.ThrowHelper.ThrowArgumentNullException(ExceptionArgument argument)
		//    at System.Linq.Enumerable.Skip[TSource](IEnumerable`1 source, Int32 count)
		//    at ICSharpCode.Decompiler.CSharp.ArgumentList.GetArgumentResolveResultsDirect(Int32 skipCount) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 124
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Probe() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 493
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Run() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 438
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.ForMethodReference(ExpressionBuilder expressionBuilder, IMethod method, IType targetType, TranslatedExpression target, Boolean requireTarget, ExpectedTargetDetails expectedTargetDetails, Boolean isExtensionMethodReference, Boolean castTargetUpFront) in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 131
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.DisambiguateDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1718
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1648
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildMethodReference(IMethod method, Boolean isVirtual) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1639
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitLdFtn(LdFtn inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 5058
		//    at ICSharpCode.Decompiler.IL.LdFtn.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 3175
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitConv(Conv inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2307
		//    at ICSharpCode.Decompiler.IL.Conv.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2298
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildArgumentList(ExpectedTargetDetails expectedTargetDetails, ResolveResult target, IMethod method, Int32 firstParamIndex, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, Boolean writtenAsAssignment) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1070
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(OpCode callOpCode, IMethod method, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, IType constrainedTo) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 461
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(CallInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 255
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitCall(Call inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2530
		//    at ICSharpCode.Decompiler.IL.Call.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2192
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Default(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 93
		//    at ICSharpCode.Decompiler.IL.ILVisitor`1.VisitCall(Call inst) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 7663
		//    at ICSharpCode.Decompiler.IL.Call.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2188
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
		//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertSwitchSectionBody(SwitchSection astSection, ILInstruction bodyInst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 334
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.TranslateSwitch(BlockContainer switchContainer, SwitchInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 280
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1334
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertLoop(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1354
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1325
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertLoop(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1354
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1325
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1338
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertAsBlock(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 87
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2435
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void Ȁ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778869, new IntPtr(2737367931724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _0300(EventPacket<ClientboundJoinGamePacket> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778868, new IntPtr(2737367933804L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void Ѐ(EventPacket<ClientboundJoinGamePacket> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0069: Expected VT, but got I4
		//IL_0078: Expected Obj, but got VT
		//IL_0043: Expected VT, but got Obj
		//IL_0052: Expected Obj, but got VT
		//IL_007d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0057->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0088->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0062->IL0026: Incompatible stack types: I4 vs Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 2:
				((_003C_003Ef__AnonymousType0<>)(object)this)._002Ector((_003Caction_003Ej__TPar)P_0);
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 1;
				}
				break;
			case 1:
				((_003C_003Ef__AnonymousType2<, , , >)(object)this)._003Curl_003Ei__Field = (_003Curl_003Ej__TPar)0;
				obj2 = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field != 0)
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
