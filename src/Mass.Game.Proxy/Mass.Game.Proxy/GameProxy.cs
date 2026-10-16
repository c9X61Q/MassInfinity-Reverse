using System;
using System.Buffers;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using System.Threading;
using System.Threading.Tasks;
using DotNetty.Buffers;
using DotNetty.Transport.Bootstrapping;
using DotNetty.Transport.Channels;
using Mass.Application.Desktop;
using Mass.Application.Event;
using Mass.Application.Models;
using Mass.Application.Services;
using Mass.Common.Extensions;
using Mass.Common.Helpers;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Domain.Value;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Minecraft.Events;
using Mass.Game.Proxy.Network;
using Mass.Game.Proxy.Network.Item;
using Mass.Game.Proxy.Protocols;
using Mass.Game.Proxy.Protocols.Heypixel;
using Mass.Game.Proxy.Protocols.Heypixel.AntiCheat;
using Mass.Game.Proxy.Protocols.Heypixel.Floodgate;
using Mass.Game.Proxy.Protocols.Hyt.VexView;
using Mass.Game.Proxy.Protocols.OhMyGod;
using MsgPack;
using Serilog;

namespace Mass.Game.Proxy;

public class GameProxy : GameInstance
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static Action<EventPluginChanged> _003C0_003E__PluginChanged;

		public static Action<EventConnectServer> _003C1_003E__OnConnectServer;

		public static Action<EventConnectServer> _003C2_003E__OnConnectServer;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CListenAsync_003Ed__69 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public GameProxy _003C_003E4__this;

		public int port;

		private TaskAwaiter<IChannel> _003C_003Eu__1;

		private static object CheckCentralResponder;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CheckStatelessStream()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LoadDecorator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_2300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778707, new IntPtr(2737367929644L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_2400()
		{
			//IL_001a: Expected Obj, but got VT
			_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_2500()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778706, new IntPtr(2737367927564L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_2600()
		{
			//IL_001a: Invalid comparison between VT and Obj
			_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_2700()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778797, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00Ⰰ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778796, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00ⴀ()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_05a7: Expected Obj, but got I4
			//IL_05a7: Expected Obj, but got Ref
			//IL_004e: Expected Obj, but got Ref
			//IL_0053: Expected VT, but got Ref
			//IL_0053: Expected Obj, but got Ref
			//IL_0063: Expected Obj, but got Ref
			//IL_0074: Expected Obj, but got VT
			//IL_058f: Expected Obj, but got Ref
			//IL_059a: Expected Obj, but got I4
			//IL_0243: Expected Obj, but got Ref
			//IL_0497: Expected Obj, but got Ref
			//IL_0372: Expected Obj, but got I4
			//IL_0377: Expected Obj, but got I4
			//IL_01a9: Expected Obj, but got I4
			//IL_01ae: Expected Obj, but got I4
			//IL_01ae: Expected Obj, but got Ref
			//IL_027d: Expected Obj, but got Ref
			//IL_027f: Expected Obj, but got Ref
			//IL_01d6: Expected I, but got Obj
			//IL_0160: Expected Obj, but got Ref
			//IL_0194: Expected Obj, but got Ref
			//IL_0434: Expected Obj, but got Ref
			//IL_043c: Expected Obj, but got Ref
			//IL_043c: Expected Obj, but got Ref
			//IL_043c: Expected Obj, but got Ref
			//IL_026c: Expected I, but got Obj
			//IL_026c: Expected Obj, but got Ref
			//IL_017f: Expected Obj, but got Ref
			//IL_0184: Expected Obj, but got I4
			//IL_02c7: Expected VT, but got Obj
			//IL_02c7: Expected Obj, but got VT
			//IL_02df: Expected Obj, but got I4
			//IL_02f1: Expected Obj, but got I4
			//IL_02fc: Expected Obj, but got I4
			//IL_0307: Expected Obj, but got I4
			//IL_0316: Expected Obj, but got F8
			//IL_031b: Expected Obj, but got I4
			//IL_0328: Expected I4, but got Obj
			//IL_0332: Expected Obj, but got I4
			//IL_0339: Expected Obj, but got Ref
			//IL_033e: Expected I4, but got Obj
			//IL_0344: Expected Obj, but got Ref
			//IL_0349: Expected Obj, but got I4
			//IL_0350: Expected Obj, but got I4
			//IL_0149: Expected Obj, but got VT
			//IL_0149: Expected Obj, but got Ref
			//IL_0153: Expected Obj, but got I4
			//IL_0114: Expected Obj, but got VT
			//IL_0119: Invalid comparison between VT and I4
			//IL_03ac: Expected Obj, but got Ref
			//IL_0486: Expected VT, but got Obj
			//IL_0488: Expected Obj, but got VT
			//IL_03eb: Expected Obj, but got F8
			//IL_02a4: Expected Obj, but got I
			//IL_04bd: Expected I4, but got Obj
			//IL_04bd: Expected Obj, but got I4
			//IL_04cd: Expected Obj, but got I4
			//IL_05b1->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005d->IL0026: Incompatible stack types: I4 vs Ref
			//IL_0079->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0084->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0400->IL059f: Incompatible stack heights: 0 vs 1
			//IL_0289->IL009a: Incompatible stack heights: 1 vs 2
			//IL_016f->IL009a: Incompatible stack heights: 4 vs 2
			//IL_03a5->IL009a: Incompatible stack heights: 3 vs 2
			//IL_04d7->IL059f: Incompatible stack heights: 0 vs 1
			//IL_0450->IL009a: Incompatible stack heights: 3 vs 2
			//IL_018e->IL009a: Incompatible stack heights: 4 vs 2
			//IL_035a->IL009a: Incompatible stack heights: 1 vs 2
			//IL_035f->IL05b1: Incompatible stack heights: 0 vs 1
			//IL_03b1->IL0276: Incompatible stack heights: 0 vs 1
			//IL_04a9->IL04b1: Incompatible stack heights: 1 vs 0
			//IL_0492->IL009a: Incompatible stack heights: 1 vs 2
			//IL_0475->IL0475: Incompatible stack heights: 3 vs 2
			//IL_045b->IL009a: Incompatible stack heights: 3 vs 2
			//IL_009a->IL009a: Incompatible stack heights: 1 vs 2
			//IL_03c5->IL009a: Incompatible stack heights: 1 vs 2
			//IL_03d0->IL009a: Incompatible stack heights: 1 vs 2
			ref readonly _003Caction_003Ej__TPar reference = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			object obj = 5;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					int num;
					switch ((int)obj2)
					{
					case 3:
					{
						int hashCode = ((EqualityComparer<_00210>)Unsafe.AsPointer(ref reference)).GetHashCode((_00210)Unsafe.AsPointer(ref ((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref this))._003Cuuid_003Ei__Field));
						obj2 = 2;
						reference = ref *(_003Caction_003Ej__TPar*)hashCode;
						continue;
					}
					case 4:
						obj = _003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter;
						obj2 = 1;
						if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field == 0)
						{
							obj2 = 1;
						}
						continue;
					case 1:
						if (obj != null)
						{
							num = 24;
							goto IL_009a;
						}
						goto IL_023d;
					case 5:
						goto end_IL_0026;
					case 2:
						return;
						IL_023d:
						obj = ((EntityLaunchGameProxy)Unsafe.AsPointer(ref this)).ModHashList__BackingField;
						num = 0;
						if (((EntityLaunchGameProxy)EntityLaunchGameProxy.Name__BackingField).ServerAddress__BackingField == null)
						{
							num = 10;
						}
						goto IL_009a;
						IL_009a:
						while (true)
						{
							switch (num)
							{
							case 19:
								if (((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType2<, , , >)obj)._003Ccontext_003Ei__Field).name <= (object)1008009)
								{
									num = 2;
									if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field == 0)
									{
										num = 5;
									}
									continue;
								}
								goto default;
							case 18:
								((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref reference)).Equals(((_003C_003Ef__AnonymousType3<, >)obj)._003Csid_003Ei__Field);
								obj = 16;
								continue;
							case 9:
								((_003C_003Ef__AnonymousType1<, , >)(object)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance).ToString();
								_ = 19;
								continue;
							case 16:
							case 23:
								_003C_003Ef__AnonymousType1<, , >.ReflectScalableStack();
								JsonSerializer.Serialize((_003C_003Ef__AnonymousType3<int, string>)_003C_003Ef__AnonymousType1<, , >.ReflectModularWriter(), (JsonSerializerOptions?)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_hasTimeout);
								_ = 12;
								continue;
							case 10:
								_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.GuideMap = null;
								num = 3;
								continue;
							case 3:
								obj = -1;
								((EntitySocks5Account)Unsafe.AsPointer(ref this)).Password__BackingField = -1;
								num = 2;
								if (((EntitySocks5)EntitySocks5Account.AttachElement).Address__BackingField != null)
								{
									num = 6;
								}
								continue;
							case 8:
								((EntitySocks5)obj).Port__BackingField = (nint)obj;
								num = 9;
								if (EntitySocks5.DecorateDynamicModule != null)
								{
									num = 5;
								}
								continue;
							case 7:
								break;
							case 15:
								((EntityLaunchGameProxy)Unsafe.AsPointer(ref this)).ServerPort__BackingField = (nint)obj;
								num = 14;
								continue;
							case 6:
								((RegexRunnerFactory)(&obj))._002Ector();
								obj = (object)Unsafe.AsPointer(ref reference);
								_ = 8;
								continue;
							case 24:
								if (((EntityLaunchGameProxy)obj).Value__BackingField == null)
								{
									num = 2;
									if ((object)EntityLaunchGameProxy.ReflectAlphabeticProcessor != null)
									{
										num = 0;
									}
									continue;
								}
								goto end_IL_0026_2;
							case 2:
							case 17:
							{
								ReadOnlySpan<char> readOnlySpan = new ReadOnlySpan<char>((int)Unsafe.AsPointer(ref reference));
								((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory)obj)._002Ector();
								((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)readOnlySpan).Scan((ReadOnlySpan<char>)obj);
								((RegexRunner)/*Error near IL_02cc: Stack underflow*/).Capture((int)/*Error near IL_02cc: Stack underflow*/, (int)/*Error near IL_02cc: Stack underflow*/, (int)/*Error near IL_02cc: Stack underflow*/);
								((AsyncTaskMethodBuilder<HeypixelRequestDto>*)((MassService)/*Error near IL_02d1: Stack underflow*/).ApiRequestAsync<HeypixelReflectCheckResult>((string)/*Error near IL_02d1: Stack underflow*/, (object?)/*Error near IL_02d1: Stack underflow*/))->Start(ref *(MassServiceExtensions._003CGetHeypixelAntiCheat_003Ed__2*)1);
								Task<HeypixelRequestDto> task = ((MassService)/*Error near IL_02df: Stack underflow*/).ApiRequestAsync<HeypixelRequestDto>((string)/*Error near IL_02df: Stack underflow*/, (object?)1);
								PackerUnpackerExtensions.Pack<_0021_00210[]>(PackerUnpackerExtensions.Pack<string>((Packer)/*Error near IL_02e6: Stack underflow*/, (string)(object)task), (_0021_00210[])1048576).WriteDictionary((Dictionary<string, long>)1048576);
								((Packer)/*Error near IL_0307: Stack underflow*/).WriteArray((string[][])1048576);
								string text = (string?)/*Error near IL_0332: Stack underflow*/ + (string?)new int((string?)(object)JsonHelper.Deserialize<Modal>((string)((EqualityComparer<string>)/*Error near IL_0316: Stack underflow*/).GetHashCode((string)10.0)), out *(int*)new string((char)(int)obj, (StringSplitOptions)(int)__ldftn(EntitySocks5Account.GetHashCode)));
								obj = ((EqualityComparer<int>)/*Error near IL_034e: Stack underflow*/).Equals((int)/*Error near IL_034e: Stack underflow*/, ((EqualityComparer<EntitySocks5Account>)((EqualityComparer<int>)(object)text).GetHashCode((int)_003C_003EO._003C0_003E__PluginChanged)).GetHashCode((EntitySocks5Account)(object)_003C_003EO._003C2_003E__OnConnectServer));
								_ = 22;
								continue;
							}
							case 21:
								return;
							case 1:
								obj = 0;
								_003C_003E4__this = (GameProxy)0;
								num = 15;
								continue;
							case 11:
							case 20:
								((EntitySocks5)obj).Address = (string)obj;
								Unsafe.Write(&CheckCentralResponder, (object)new EntitySocks5());
								_ = 13;
								continue;
							case 22:
								if (((EqualityComparer<EnumGameType>)Unsafe.AsPointer(ref reference)).GetHashCode((EnumGameType)(int)(&obj)) == 0)
								{
									_ = 1;
									if (((CpsDetector)(object)CpsDetector._leftClicks)._rightClicks == null)
									{
										_ = 1;
									}
									continue;
								}
								goto case 6;
							case 13:
								if ((int)((CpsDetector)obj)._lastLeftCps != 0)
								{
									num = 13;
									if (((CpsDetector)CpsDetector._lastRightCps).OnCpsChange == null)
									{
										num = 23;
									}
									continue;
								}
								goto case 18;
							case 14:
								((IByteBuffer)(object)Unsafe.AsPointer(ref OhMyGodEncryption.DecorateEfficientEmitter)).WritePrefixedArray((List<Slot>)(&obj), (Action<Slot>)Unsafe.AsPointer(ref this));
								_ = 12;
								if (OhMyGodHwid.ControlProcessor == null)
								{
									_ = 21;
								}
								continue;
							case 5:
							{
								((EntitySocks5)/*Error near IL_0460: Stack underflow*/).Deconstruct(out *(string*)/*Error near IL_0460: Stack underflow*/, out *(int*)/*Error near IL_0460: Stack underflow*/, out Unsafe.As<_003Caction_003Ej__TPar, EntitySocks5Account?>(ref reference));
								object serverAddress = obj;
								bool flag = EntitySocks5.ReflectConcreteEvent();
								if (!flag)
								{
									EntitySocks5.DecorateConnectedWrapper();
								}
								((EntityLaunchGameProxy)/*Error near IL_047a: Stack underflow*/)._002Ector((DesktopSession)/*Error near IL_047a: Stack underflow*/, (string)/*Error near IL_047a: Stack underflow*/, (EnumGameType)/*Error near IL_047a: Stack underflow*/, (EnumGameVersion)/*Error near IL_047a: Stack underflow*/, (string)/*Error near IL_047a: Stack underflow*/, (string)/*Error near IL_047a: Stack underflow*/, (string)serverAddress, flag ? 1 : 0);
								obj = Interlocked.CompareExchange<T>(ref *(T*)/*Error near IL_0486: Stack underflow*/, (T)/*Error near IL_0486: Stack underflow*/, (T)((EntityLaunchGameProxy)obj).EqualityContract);
								_ = 20;
								continue;
							}
							default:
								((EntityLaunchGameProxy)/*Error near IL_0497: Stack underflow*/).Session = (DesktopSession)Unsafe.AsPointer(ref reference);
								if (((EntityLaunchGameProxy)obj).GameId == null)
								{
									((EntityLaunchGameProxy)/*Error near IL_04b1: Stack underflow*/).GameId = (string)obj;
								}
								((EntityLaunchGameProxy)((EntityLaunchGameProxy)/*Error near IL_04b6: Stack underflow*/).GameType).GameType = (EnumGameType)obj;
								obj = ((DefaultInterpolatedStringHandler*)/*Error near IL_04c2: Stack underflow*/)->ToStringAndClear();
								obj = 11;
								continue;
							case 4:
							case 12:
								goto end_IL_0026_2;
							}
							break;
						}
						goto IL_023d;
						end_IL_0026_2:
						break;
					}
					((VexViewGuiPacket)Unsafe.AsPointer(ref this)).Base__BackingField = -2;
					obj2 = 3;
					continue;
					end_IL_0026:
					break;
				}
				obj = VexViewCodec.OpenEmitter;
				obj = 4;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_2E00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778799, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_2F00(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0044: Expected VT, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_0058->IL0026: Incompatible stack heights: 3 vs 2
			//IL_0063->IL0026: Incompatible stack heights: 3 vs 2
			_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
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
					((EqualityComparer<_00210>)Unsafe.AsPointer(ref ((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref this))._003Cuuid_003Ei__Field)).GetHashCode((_00210)P_0);
					_ = 0;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
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

	[CompilerGenerated]
	private static readonly object Logger__BackingField;

	private object? _pinger;

	[CompilerGenerated]
	private Action<GameProxy>? m_ConnectionChanged;

	public static readonly ConcurrentDictionary<int, Mass.Game.Proxy.Minecraft.Minecraft> OnlineClients;

	public EntitySocks5? Socks5;

	public bool IsGame;

	public bool BlockIrcMessages;

	private object? _channel;

	private object? _connection;

	internal static GameProxy ReflectSimpleVerifier;

	public static ILogger Logger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00_FF00ᤀ();
		}
	}

	public DesktopSession Session
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DesktopSession)_FF00_FF00_FF00_FF00_FF00_FF00_FF00_2400();
		}
	}

	public EnumGameType GameType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00ﰀ();
		}
	}

	public string GameId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00_EA00();
		}
	}

	public EnumGameVersion GameVersion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2100();
		}
	}

	public string ModHashList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00_FF00_0600();
		}
	}

	public string ServerAddress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00_FF00Ȁ();
		}
	}

	public int ServerPort
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00_FF00_FF00_FF00_FF00_2B00();
		}
	}

	public string? TransferServerAddress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string?)_FF00_FF00_FF00_FF00_FF00_FF00_FF00ᔀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00ᄀ(value);
		}
	}

	public int TransferServerPort
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00_FF00_FF00_FF00_FF00ἀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00_2000((uint)value);
		}
	}

	public SectionValue? Section
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SectionValue?)_FF00_FF00_FF00_FF00_FF00_FF00_FF00ࠀ();
		}
	}

	private IEventLoopGroup WorkerGroup
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (IEventLoopGroup)_FF00_FF00_FF00_FF00_FF00_FF00_FF00Ⰰ();
		}
	}

	private IEventLoopGroup AcceptorGroup
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (IEventLoopGroup)_FF00_FF00_FF00_FF00_FF00_FF00_FF00ᜀ();
		}
	}

	public string? DisplayAddress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string?)_FF00_FF00_FF00_FF00_FF00_FF00_FE00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_F000(value);
		}
	}

	public string? ProxyAddress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string?)_FF00_FF00_FF00_FF00_FF00_FF00_FF00Ḁ();
		}
	}

	public int ProxyPort
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00_FF00_FF00_FF00_FF00_0300();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00_0D00((uint)value);
		}
	}

	public Connection? Connection
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (Connection?)_FF00_FF00_FF00_FF00_FF00_FF00_FF00_0E00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00_2700(value);
		}
	}

	public event Action<GameProxy>? ConnectionChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00_2600(value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00_2A00(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameProxy(EntityLaunchGameProxy args)
	{
		//IL_001b: Expected VT, but got Obj
		//IL_002c: Expected Obj, but got VT
		//IL_0031: Expected VT, but got I4
		//IL_0047: Expected VT, but got Obj
		//IL_0047: Expected Obj, but got VT
		//IL_0073: Expected Obj, but got I4
		//IL_0089: Expected I4, but got Obj
		//IL_009f: Expected Obj, but got VT
		//IL_00b5: Expected Obj, but got I4
		//IL_00cb: Expected Obj, but got I4
		//IL_00cb: Expected Obj, but got I
		//IL_00e1: Expected I4, but got VT
		//IL_00f2: Expected Obj, but got I4
		//IL_00f7: Expected Obj, but got I4
		//IL_011d: Expected I, but got Obj
		//IL_012d: Expected Obj, but got VT
		//IL_0138: Expected VT, but got Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)args;
		((_003C_003Ef__AnonymousType2<, , , >)(object)this)._003Curl_003Ei__Field = (_003Curl_003Ej__TPar)((_003C_003Ef__AnonymousType0<>)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuser_id_003Ei__Field).GetHashCode();
		((_003C_003Ef__AnonymousType2<, , , >)((_003C_003Ef__AnonymousType2<, , , >)(object)this)._003Cpayload_003Ei__Field)._003Cuser_id_003Ei__Field = (_003Cuser_id_003Ej__TPar)_003C_003Ef__AnonymousType0<>.ReflectJoinedTree();
		((_003C_003Ef__AnonymousType3<, >)(object)this)._003Csid_003Ei__Field = (_003Csid_003Ej__TPar)((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic).user_id;
		_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectLocalTemplate = ((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument).GetHashCode();
		_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_hasTimeout = (byte)(int)_003C_003Ef__AnonymousType1<, , >.ReflectModularWriter() != 0;
		((EntitySocks5Account)(object)this).Username__BackingField = ((_003C_003Ef__AnonymousType2<, , , >)(object)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_ascii_68FF03FEFFFF87FEFFFF07).context;
		((EntitySocks5)(object)this).Address__BackingField = ((_003C_003Ef__AnonymousType2<, , , >)(object)this).Equals(((EntitySocks5Account)(object)this).Password__BackingField);
		EntitySocks5.DecorateDynamicModule = _003C_003Ef__AnonymousType2<, , , >.CheckAccessibleObject();
		((EntityLaunchGameProxy)(object)this).GameType__BackingField = (EnumGameType)((_003C_003Ef__AnonymousType3<, >)((EntityLaunchGameProxy)(object)this).Session__BackingField).sid;
		((EntityLaunchGameProxy)(object)this).Name__BackingField = ((_003C_003Ef__AnonymousType3<, >)((EntityLaunchGameProxy)(object)this).GameVersion__BackingField).GetHashCode();
		((EntityLaunchGameProxy)((EntityLaunchGameProxy)(object)this).ServerAddress__BackingField).Socks5__BackingField = _003C_003Ef__AnonymousType3<, >.DecorateIntegratedProgram();
		((EntityLaunchGameProxy)(object)this).IsGame__BackingField = (nint)new RegexRunner();
		_003Cargs_003EP = new ReadOnlySpan<char>();
		MemoryExtensions.IndexOfAny<T>((ReadOnlySpan<T>)this, (SearchValues<T>)(object)this);
		int num = 0;
		if (((GameProxy)GameProxy._pinger).m_ConnectionChanged == null)
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
	[AsyncStateMachine(typeof(_003CListenAsync_003Ed__69))]
	public Task ListenAsync(int port)
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00_FF00_FF00_1B00((uint)port);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterEvents()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Dispose()
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00_2300();
	}

	static GameProxy()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0023: Expected I4, but got Obj
		//IL_007a->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0051->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0085->IL0012: Incompatible stack types: I4 vs Obj
		//IL_005c->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				Logger__BackingField = Log.Logger.Category((string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00_FF00_E800());
				obj2 = 1;
				if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_3369da80e85f42fda57cd6db7d7b31f1 != 0)
				{
					obj2 = 1;
				}
				break;
			case 1:
				OnlineClients = new ConcurrentDictionary<int, Mass.Game.Proxy.Minecraft.Minecraft>();
				obj2 = 0;
				if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_19d536ad208d4346b895990d78db913f == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ExcludeAuditor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GameProxy CheckTransferableComparator()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_E900()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778703, new IntPtr(2737367923404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_EA00()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_EB00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778702, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_EC00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778697, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_ED00(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got Obj
		//IL_003f: Expected VT, but got Ref
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		switch ((int)obj)
		{
		case 0:
			break;
		case 1:
			((EqualityComparer<_00210>)/*Error near IL_003f: Stack underflow*/).Equals((_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00210?)P_0);
			obj = new
			{
				value = P_0
			};
			((_003C_003Ef__AnonymousType0<>)(object)this).GetHashCode();
			_ = new { };
			/*Error near IL_0053: Member reference must be method, but was: Field*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_EE00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778696, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_EF00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778699, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_F000(object P_0)
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
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_F100()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_F200()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778698, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00_FF00_FF00_FF00_FF00_FF00ﬀ()
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
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitNewObj(NewObj inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 538
		//    at ICSharpCode.Decompiler.IL.NewObj.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4578
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitStObj(StObj inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 3219
		//    at ICSharpCode.Decompiler.IL.StObj.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4386
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitStLoc(StLoc inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 855
		//    at ICSharpCode.Decompiler.IL.StLoc.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2590
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitStLoc(StLoc inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 129
		//    at ICSharpCode.Decompiler.IL.StLoc.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2586
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
		//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitIfInstruction(IfInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 162
		//    at ICSharpCode.Decompiler.IL.IfInstruction.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 1440
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
	internal EnumGameType _FF00_FF00_FF00_FF00_FF00_FF00ﰀ()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (EnumGameType)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe EnumGameType _FF00_FF00_FF00_FF00_FF00_FF00ﴀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778693, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
		return (EnumGameType)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FE00()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778692, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ā()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778695, new IntPtr(2737367929644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ȁ()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0300()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (uint)(int)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ѐ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778694, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ԁ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778689, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0600()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778688, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ࠀ()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0900()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778691, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0A00()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0B00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778690, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0C00(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778717, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0D00(uint P_0)
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
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0E00()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ༀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778716, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00က(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778719, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᄀ(object P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ሀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778718, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00ጀ()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_1400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778713, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᔀ()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᘀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778712, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᜀ()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_1800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778715, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᤀ()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᨀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778714, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_1B00(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0092: Expected Obj, but got Ref
		//IL_00ee: Expected VT, but got I4
		//IL_00ee: Expected Obj, but got Ref
		//IL_00fd: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got Ref
		//IL_006c: Expected Obj, but got Ref
		//IL_006c: Expected Obj, but got Ref
		//IL_007b: Expected Obj, but got VT
		//IL_00a0: Expected VT, but got I4
		//IL_00a0: Expected Obj, but got Ref
		//IL_00af: Expected Obj, but got VT
		//IL_00c7: Expected Obj, but got Ref
		//IL_004f: Expected VT, but got Ref
		//IL_004f: Expected VT, but got Ref
		//IL_0054: Expected VT, but got I4
		//IL_0102->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0080->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00b4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00db->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack heights: 1 vs 2
		//IL_010d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008b->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00bf->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e6->IL0026: Incompatible stack types: I4 vs Obj
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 5:
				((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_0054: Stack underflow*/)._003Cuser_id_003Ei__Field = (_003Cuser_id_003Ej__TPar)((EqualityComparer<_00210>)/*Error near IL_004f: Stack underflow*/).Equals((_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00210?)(&obj));
				_ = 4;
				break;
			case 2:
				((EventBus)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Register((Action<EventMinecraft>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter), (int)(&obj));
				_ = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field != 0)
				{
					_ = 0;
				}
				break;
			default:
				_ = ref ((_003C_003Ef__AnonymousType2<, , , >)(&obj))._003Cuser_id_003Ei__Field;
				/*Error near IL_0092: Member reference must be method, but was: Field*/;
			case 3:
				((_003C_003Ef__AnonymousType3<, >)(&obj))._003Centry_003Ei__Field = (_003Centry_003Ej__TPar)(-1);
				obj2 = 2;
				if (_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument == null)
				{
					obj2 = 0;
				}
				break;
			case 4:
				_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance = (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0)(object)this;
				obj2 = 0;
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.StoreConverter == null)
				{
					obj2 = 1;
				}
				break;
			case 1:
				_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_defaultTimeout = (TimeSpan)P_0;
				obj2 = 2;
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_ascii_68FF03FEFFFF87FEFFFF07 == null)
				{
					obj2 = 3;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᰀ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778709, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ḁ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 10501, 1790778708, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778708, new IntPtr(2737367921324L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00_FF00_FF00_FF00_FF00ἀ()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (uint)(int)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2000(uint P_0)
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
	internal EnumGameVersion _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2100()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (EnumGameVersion)(int)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2300()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004f: Expected I4, but got Obj
		//IL_005b: Expected VT, but got I4
		//IL_0064: Expected Obj, but got I4
		//IL_006f: Expected VT, but got Obj
		//IL_006f: Expected Obj, but got Ref
		//IL_00c2: Expected Obj, but got VT
		//IL_00dc: Expected Obj, but got I4
		//IL_00e1: Expected VT, but got Obj
		//IL_00e1: Expected VT, but got Ref
		//IL_00eb: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got VT
		//IL_0083->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0083->IL0026: Incompatible stack types: I4 vs Ref
		//IL_008e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008e->IL0026: Incompatible stack types: I4 vs Ref
		//IL_00c7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f5->IL0026: Incompatible stack types: I4 vs Ref
		//IL_00a5->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0111->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_012f->IL0026: Incompatible stack heights: 4 vs 2
		//IL_013a->IL0026: Incompatible stack heights: 4 vs 2
		ref readonly _003Caction_003Ej__TPar reference = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 7;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 4:
				{
					int hashCode = ((EqualityComparer<_00210>)Unsafe.AsPointer(ref reference)).GetHashCode((_00210)this);
					obj2 = 1;
					reference = ref *(_003Caction_003Ej__TPar*)hashCode;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field != 0)
					{
						obj2 = 1;
						reference = ref *(_003Caction_003Ej__TPar*)hashCode;
					}
					continue;
				}
				case 7:
				{
					bool flag = _003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
					if (!flag)
					{
						_ = 6;
						continue;
					}
					((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_00e1: Stack underflow*/)._002Ector((_003Cname_003Ej__TPar)Unsafe.AsPointer(ref reference), (_003Cuuid_003Ej__TPar)this, (_003Cuser_id_003Ej__TPar)((_003C_003Ef__AnonymousType3<, >)flag)._003Centry_003Ei__Field);
					int hashCode2 = ((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_00e6: Stack underflow*/).Equals((object)/*Error near IL_00e6: Stack underflow*/)).GetHashCode();
					obj2 = 8;
					reference = ref *(_003Caction_003Ej__TPar*)hashCode2;
					continue;
				}
				case 1:
					return;
				case 2:
				case 5:
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)(object)this)._003Ccontext_003Ei__Field == 0)
					{
						obj2 = 1;
						if (_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic != null)
						{
							obj2 = 3;
						}
						continue;
					}
					/*Error near IL_013f: Member reference must be method, but was: Field*/;
				case 6:
				case 8:
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectLocalTemplate == null)
					{
						obj2 = 2;
						continue;
					}
					_003C_003Ef__AnonymousType1<, , >.ReflectScalableStack();
					_ = 0;
					if (!_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_hasTimeout)
					{
						_ = 5;
					}
					continue;
				}
				break;
			}
			((_003C_003Ef__AnonymousType0<>)(object)this)._002Ector((_003Caction_003Ej__TPar)0);
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2400()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778711, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2600(Action<GameProxy> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_008b: Expected Obj, but got VT
		//IL_00a4: Expected Obj, but got VT
		//IL_0059: Expected Obj, but got Ref
		//IL_00cb: Expected VT, but got Obj
		//IL_00cb: Expected VT, but got Obj
		//IL_00cb: Expected Obj, but got Ref
		//IL_00cc: Expected Obj, but got I4
		//IL_0090->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e6->IL0026: Incompatible stack heights: 1 vs 2
		//IL_009b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0078->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f1->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0104->IL0026: Incompatible stack types: I4 vs Obj
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
			{
				ref readonly _003Cuuid_003Ej__TPar reference = ref ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
				((AsyncTaskMethodBuilder*)obj)->Start(ref *(_003CListenAsync_003Ed__69*)obj);
				obj = (object)Unsafe.AsPointer(ref reference);
				obj2 = 5;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
				{
					obj2 = 4;
				}
				break;
			}
			default:
				obj = obj;
				obj2 = 3;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field != 0)
				{
					obj2 = 3;
				}
				break;
			case 4:
				return;
			case 1:
				obj = ((_003C_003Ef__AnonymousType2<, , , >)(object)this)._003Cuser_id_003Ei__Field;
				obj2 = 0;
				if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field == 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				obj = (EqualityComparer<Type>)(object)((EqualityComparer<_00212>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals((_00212?)obj, (_00212?)P_0);
				_ = 0;
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectLocalTemplate == null)
				{
					_ = 2;
				}
				break;
			case 5:
				if (obj == obj)
				{
					obj2 = 4;
					break;
				}
				goto default;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2700(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_009e: Invalid comparison between VT and Obj
		//IL_004b: Expected VT, but got Obj
		//IL_005a: Expected Obj, but got VT
		//IL_0086: Expected Obj, but got VT
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ad->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0096->IL0026: Incompatible stack types: I4 vs Obj
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
				((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)P_0;
				obj2 = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
				{
					obj2 = 1;
				}
				break;
			case 2:
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)(object)this)._003Curl_003Ei__Field != 0)
				{
					/*Error near IL_00b3: Member reference must be method, but was: Field*/;
				}
				obj2 = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field == 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				return;
			case 3:
				if (((_003C_003Ef__AnonymousType2<, , , >)(object)this)._003Cuser_id_003Ei__Field != (_003Cuser_id_003Ej__TPar)P_0)
				{
					obj2 = 2;
					break;
				}
				goto default;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2800(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778710, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2900(Action<GameProxy> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778705, new IntPtr(2737367922364L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2A00(Action<GameProxy> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0050: Expected Obj, but got VT
		//IL_005f: Expected Obj, but got VT
		//IL_0077: Expected Obj, but got Ref
		//IL_007e: Expected Obj, but got VT
		//IL_008d: Expected Obj, but got VT
		//IL_00ac: Expected Obj, but got Ref
		//IL_00d0: Expected Obj, but got VT
		//IL_00f8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00b8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0103->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00d5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e0->IL0026: Incompatible stack types: I4 vs Obj
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
				obj = ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
				obj2 = 1;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
				{
					obj2 = 1;
				}
				continue;
			case 3:
				obj = (_00212)string.Format((IFormatProvider?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (string)obj, (object?[])(object)P_0);
				_ = 5;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Ccontext_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
				{
					_ = 4;
				}
				continue;
			case 5:
				obj = ((AbstractBootstrap<ServerBootstrap, IServerChannel>)(object)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)).Option<IByteBufferAllocator>((ChannelOption<IByteBufferAllocator>)obj, (IByteBufferAllocator)obj);
				obj2 = 4;
				continue;
			case 4:
				if (obj == obj)
				{
					obj2 = 0;
					if (_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument != null)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
			case 1:
				break;
			case 0:
				return;
			}
			obj = obj;
			obj2 = 3;
			if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectLocalTemplate != null)
			{
				obj2 = 3;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2B00()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (uint)(int)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ⰰ()
	{
		//IL_001b: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ⴀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778704, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
