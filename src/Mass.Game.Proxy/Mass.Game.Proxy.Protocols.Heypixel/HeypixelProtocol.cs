using System;
using System.Buffers;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
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
using Mass.Domain.Desktop.ValueObjects;
using Mass.Domain.Value;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Minecraft.Events;
using Mass.Game.Proxy.Minecraft.Events.Play;
using Mass.Game.Proxy.Minecraft.Server;
using Mass.Game.Proxy.Network;
using Mass.Game.Proxy.Network.Component.Chat;
using Mass.Game.Proxy.Network.Metadata.Values;
using Mass.Game.Proxy.Network.Nbt;
using Mass.Game.Proxy.Packets.Configuration;
using Mass.Game.Proxy.Packets.Handshake;
using Mass.Game.Proxy.Packets.Play;
using Mass.Game.Proxy.Protocols.FakeForge;
using Mass.Game.Proxy.Protocols.FakeForge.FmlHandshake.Messages;
using Mass.Game.Proxy.Protocols.Germ;
using Mass.Game.Proxy.Protocols.Heypixel.AntiCheat;
using Mass.Game.Proxy.Protocols.Heypixel.Events;
using Mass.Game.Proxy.Protocols.Heypixel.Floodgate;
using Mass.Game.Proxy.Protocols.Heypixel.Serverbound;
using Mass.Game.Proxy.Protocols.Hyt;
using Mass.Game.Proxy.Protocols.Hyt.VexView;
using Mass.Game.Proxy.Protocols.OhMyGod;
using Mass.Game.Proxy.Protocols.Orange;
using RestSharp;
using Serilog;

namespace Mass.Game.Proxy.Protocols.Heypixel;

public class HeypixelProtocol : FakeForgeProtocol
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Predicate<MetadataEntry> _003C_003E9__31_0;

		internal static _003C_003Ec DecorateCustomAuthorizer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe _003C_003Ec()
		{
			//IL_001a: Expected VT, but got Obj
			//IL_001a: Expected VT, but got Ref
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			((EqualityComparer<_00210>)/*Error near IL_001a: Stack underflow*/).Equals((_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00210?)this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe bool _003COnSetEntityMetaData_003Eb__31_0(MetadataEntry m)
		{
			//IL_001a: Expected VT, but got Obj
			//IL_001a: Expected Obj, but got Ref
			//IL_001c: Invalid comparison between Unknown and I4
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Caction_003Ej__TPar)m);
			return (int)/*Error near IL_001e: Stack underflow*/ == 21;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EncodeContainer()
		{
			//IL_001a: Invalid comparison between VT and Obj
			_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static _003C_003Ec ReflectConvertibleReg()
		{
			//IL_001a: Expected Obj, but got VT
			_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			return (_003C_003Ec)_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInitialize_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public HeypixelProtocol _003C_003E4__this;

		private TaskAwaiter<HeypixelHwid> _003C_003Eu__1;

		internal static object CheckMixedExecutor;

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
		internal static bool DecorateFlexiblePredictor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PresentComparator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00Ⰰ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778466, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00ⴀ()
		{
			//IL_001a: Expected Obj, but got VT
			_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_2E00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778493, new IntPtr(2737367947324L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_2F00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778492, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_3000()
		{
			//IL_001a: Invalid comparison between VT and Obj
			_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_3100()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778495, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00㠀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_054a: Expected Obj, but got Ref
			//IL_0551: Expected Obj, but got Ref
			//IL_0538: Expected Obj, but got Ref
			//IL_0576: Expected Obj, but got Ref
			//IL_0050: Expected VT, but got I4
			//IL_0050: Expected Obj, but got Ref
			//IL_005f: Expected Obj, but got VT
			//IL_0082: Expected Obj, but got VT
			//IL_00b8: Expected Obj, but got VT
			//IL_0132: Expected Obj, but got Ref
			//IL_01fb: Expected I, but got Obj
			//IL_01fb: Expected Obj, but got Ref
			//IL_0204: Expected Obj, but got I4
			//IL_0156: Expected Obj, but got I4
			//IL_015b: Expected VT, but got I4
			//IL_015b: Expected Obj, but got Ref
			//IL_016a: Expected Obj, but got VT
			//IL_0316: Expected Obj, but got I4
			//IL_017f: Expected VT, but got Ref
			//IL_018e: Expected VT, but got Ref
			//IL_0215: Expected Obj, but got I4
			//IL_01ac: Expected Obj, but got Ref
			//IL_02e4: Expected Obj, but got Ref
			//IL_02cb: Expected Obj, but got Ref
			//IL_02d3: Expected Obj, but got Ref
			//IL_02d3: Expected Obj, but got Ref
			//IL_02d3: Expected Obj, but got Ref
			//IL_02b6: Expected Obj, but got I4
			//IL_02bb: Expected Obj, but got I4
			//IL_02bb: Expected Obj, but got Ref
			//IL_01d4: Expected Obj, but got I4
			//IL_0252: Expected I4, but got Obj
			//IL_0268: Expected Obj, but got I4
			//IL_0127: Expected I4, but got Obj
			//IL_0565->IL0026: Incompatible stack heights: 3 vs 2
			//IL_0544->IL0026: Incompatible stack types: I4 vs Obj
			//IL_058c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0570->IL0026: Incompatible stack heights: 3 vs 2
			//IL_0597->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_013e->IL00de: Incompatible stack types: I4 vs Obj
			//IL_00da->IL00de: Incompatible stack types: I4 vs Obj
			//IL_0325->IL0048: Incompatible stack heights: 0 vs 1
			//IL_016f->IL00de: Incompatible stack types: I4 vs Obj
			//IL_0320->IL00de: Incompatible stack types: I4 vs Obj
			//IL_0221->IL00de: Incompatible stack heights: 3 vs 2
			//IL_01c6->IL00de: Incompatible stack types: I4 vs Obj
			//IL_0143->IL0597: Incompatible stack heights: 0 vs 1
			//IL_02dd->IL00de: Incompatible stack heights: 3 vs 2
			//IL_02c5->IL00de: Incompatible stack types: I4 vs Obj
			//IL_01e8->IL00de: Incompatible stack types: I4 vs Obj
			//IL_025c->IL00de: Incompatible stack types: I4 vs Obj
			//IL_0283->IL00de: Incompatible stack types: I4 vs Obj
			//IL_02a6->IL00de: Incompatible stack heights: 3 vs 2
			//IL_017a->IL00de: Incompatible stack types: I4 vs Obj
			//IL_01d1->IL00de: Incompatible stack types: I4 vs Obj
			//IL_02fd->IL00de: Incompatible stack types: I4 vs Obj
			//IL_01f3->IL00de: Incompatible stack types: I4 vs Obj
			//IL_02b1->IL00de: Incompatible stack heights: 3 vs 2
			//IL_0308->IL00de: Incompatible stack types: I4 vs Obj
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				case 3:
					((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref this))._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)(-2);
					obj2 = 0;
					if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
					{
						obj2 = 0;
					}
					break;
				case 5:
				{
					int num = 1;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field != 0)
					{
						num = 1;
					}
					while (true)
					{
						switch (num)
						{
						case 1:
							num = 0;
							if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Ccontext_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
							{
								num = 0;
							}
							continue;
						}
						break;
					}
					if (obj != null)
					{
						obj3 = 15;
						goto IL_00de;
					}
					goto IL_012c;
				}
				case 1:
					obj = ((OhMyGodProtocol)Unsafe.AsPointer(ref this))._data;
					obj2 = 5;
					break;
				default:
					Delegate.Combine((Delegate?)Unsafe.AsPointer(ref OhMyGodProtocol.CheckGeneralAggregator), (Delegate?)obj);
					_ = 3;
					if (((HytMainMenu.Menu)(object)HytMainMenu.CheckCentralTransmitter).Name == null)
					{
						_ = 4;
					}
					break;
				case 2:
					obj = ((HytMainMenu.Menu)Unsafe.AsPointer(ref this)).Description;
					obj2 = 1;
					if (((HytMainMenu._003C_003Ec__DisplayClass2_0)HytMainMenu.Menu.CustomizeTemplate).minecraft == null)
					{
						obj2 = 1;
					}
					break;
				case 4:
					return;
					IL_00de:
					while (true)
					{
						switch ((int)obj3)
						{
						case 1:
							break;
						case 5:
							goto IL_012c;
						case 9:
							return;
						case 2:
							obj = 0;
							((_003C_003Ef__AnonymousType3<, >)Unsafe.AsPointer(ref this))._003Centry_003Ei__Field = (_003Centry_003Ej__TPar)0;
							obj3 = 0;
							if (_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument == null)
							{
								obj3 = 0;
							}
							continue;
						case 4:
							((EqualityComparer<_00211>)/*Error near IL_017f: Stack underflow*/).Equals((_00211?)/*Error near IL_017f: Stack underflow*/, (_00211?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
							((EqualityComparer<_00212>)(*(Color*)obj)/*cast due to constrained. prefix*/).GetHashCode((_00212)(&obj));
							_003C_003Ef__AnonymousType1<, , >.ReflectModularWriter();
							/*Error near IL_0195: Member reference must be method, but was: Field*/;
						case 7:
							_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_ascii_68FF03FEFFFF87FEFFFF07 = null;
							obj3 = 11;
							if (((EntitySocks5Account)EntitySocks5Account.Username__BackingField).Password__BackingField == null)
							{
								obj3 = 10;
							}
							continue;
						case 12:
							obj = 1;
							obj3 = 0;
							if (((EntitySocks5)EntitySocks5Account.AttachElement).Address__BackingField == null)
							{
								obj3 = 1;
							}
							continue;
						default:
							((EntitySocks5)Unsafe.AsPointer(ref this)).Port__BackingField = (nint)obj;
							obj = 10;
							obj3 = obj;
							continue;
						case 6:
							obj = EntitySocks5.DecorateDynamicModule;
							_ = 3;
							continue;
						case 16:
							_ = ref obj;
							/*Error near IL_0223: Member reference must be method, but was: Field*/;
						case 13:
							((EntityLaunchGameProxy)obj).GameVersion__BackingField = (EnumGameVersion)(int)obj;
							obj3 = 12;
							continue;
						case 14:
						{
							object obj5 = ((EntityLaunchGameProxy)((EntityLaunchGameProxy)((_003C_003Ef__AnonymousType3<, >)obj).GetHashCode()).Name__BackingField).ServerAddress__BackingField;
							((RegexRunnerFactory)_003C_003Ef__AnonymousType3<, >.DecorateIntegratedProgram())._002Ector();
							obj = obj5;
							obj3 = 4;
							continue;
						}
						case 15:
							_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0._002Ecctor();
							_ = (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectSymbolicAuditor() ? ((ReadOnlySpan<char>*)1) : ((ReadOnlySpan<char>*)null))->Length;
							_ = 6;
							if (GameProxy.Logger__BackingField == null)
							{
								_ = 0;
							}
							continue;
						case 11:
							obj = -1;
							((GameProxy)Unsafe.AsPointer(ref this))._pinger = -1;
							obj3 = 16;
							continue;
						case 10:
							((MassService)Unsafe.AsPointer(ref ((GameProxy)Unsafe.AsPointer(ref this)).ConnectionChanged)).ApiRequestAsync<HeypixelReflectCheckResult>((string)(&obj), (object?)Unsafe.AsPointer(ref this));
							_ = 9;
							continue;
						case 8:
							if ((int)(ReadOnlySpan<char>)(string?)(&obj) == 0)
							{
								obj3 = 2;
								if (((GameProxy)GameProxy.Session__BackingField).GameType__BackingField == 0)
								{
									obj3 = 2;
								}
								continue;
							}
							goto case 16;
						case 3:
						{
							object obj4 = obj;
							_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities._002Ecctor();
							obj = ((GameProxy)obj4).GameVersion__BackingField;
							obj3 = 14;
							continue;
						}
						}
						break;
					}
					goto case 3;
					IL_012c:
					obj = _003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic;
					obj3 = 7;
					goto IL_00de;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00㤀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778494, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00㨀(object P_0)
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
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field != 0)
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

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStartAntiCheatAsync_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string key;

		public HeypixelProtocol _003C_003E4__this;

		private object _003Cclient_003E5__2;

		private object _003CuserId_003E5__3;

		private object _003Ccontext_003E5__4;

		private object _003Curl_003E5__5;

		private object _003Cpayload_003E5__6;

		private object _003C_003E7__wrap6;

		private nint _003C_003E7__wrap7;

		private object _003Cdto_003E5__9;

		private TaskAwaiter<HeypixelRequestDto> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<RestResponse> _003C_003Eu__3;

		private static object CheckCommonNode;

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
		internal static bool ReflectAdaptableFunction()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecoratePortableBuffer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00ἀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778489, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_2000()
		{
			//IL_001a: Expected Obj, but got VT
			_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_2100()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778488, new IntPtr(2737367947324L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_2200()
		{
			//IL_001a: Invalid comparison between VT and Obj
			_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_2300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778491, new IntPtr(2737367947324L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_2900()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_004e: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got VT
			//IL_005f: Expected Obj, but got VT
			//IL_105d: Expected Obj, but got Ref
			//IL_1084: Expected Obj, but got Ref
			//IL_0077: Expected VT, but got I4
			//IL_0077: Expected Obj, but got Ref
			//IL_0086: Expected Obj, but got VT
			//IL_0146: Expected Obj, but got Ref
			//IL_014b: Expected I4, but got Obj
			//IL_014b: Expected Obj, but got VT
			//IL_015a: Expected Obj, but got Ref
			//IL_016a: Expected VT, but got I4
			//IL_016a: Expected Obj, but got VT
			//IL_016c: Expected Obj, but got I4
			//IL_00e4: Expected Obj, but got Ref
			//IL_00ee: Expected VT, but got Obj
			//IL_00ee: Expected VT, but got Obj
			//IL_01ca: Expected I4, but got Obj
			//IL_01ca: Expected Obj, but got I4
			//IL_01d9: Expected Obj, but got I4
			//IL_0225: Expected Obj, but got I
			//IL_0348: Expected Obj, but got Ref
			//IL_0ef6: Expected Obj, but got Ref
			//IL_0497: Expected Obj, but got I4
			//IL_049c: Expected Obj, but got I4
			//IL_0448: Expected VT, but got I4
			//IL_0ed1: Expected Obj, but got Ref
			//IL_057f: Expected I4, but got Obj
			//IL_057f: Expected Obj, but got Ref
			//IL_0590: Expected Obj, but got VT
			//IL_05c3: Expected I4, but got Obj
			//IL_02e2: Expected VT, but got Obj
			//IL_03f4: Expected Obj, but got Ref
			//IL_03f9: Expected Obj, but got I4
			//IL_04e2: Expected Obj, but got Ref
			//IL_04e4: Expected Obj, but got F8
			//IL_0422: Expected Obj, but got Ref
			//IL_042c: Expected native int or pointer, but got Obj
			//IL_0554: Expected Obj, but got I4
			//IL_0559: Expected Obj, but got I4
			//IL_0559: Expected Obj, but got Ref
			//IL_030a: Expected VT, but got Obj
			//IL_030a: Expected Obj, but got Ref
			//IL_030f: Expected Obj, but got I4
			//IL_052b: Expected Obj, but got Ref
			//IL_0530: Expected Obj, but got Ref
			//IL_0473: Expected Obj, but got Ref
			//IL_0473: Expected Obj, but got Ref
			//IL_0395: Expected Obj, but got Ref
			//IL_04f5: Expected Obj, but got Ref
			//IL_04fa: Expected Obj, but got I4
			//IL_02c1: Expected Obj, but got Ref
			//IL_04bb: Expected Obj, but got Ref
			//IL_0384: Expected Obj, but got Ref
			//IL_0384: Expected Obj, but got Ref
			//IL_07f5: Expected Obj, but got Ref
			//IL_0806: Expected Obj, but got VT
			//IL_0760: Expected Obj, but got Ref
			//IL_0960: Expected Obj, but got Ref
			//IL_0d11: Expected Obj, but got I4
			//IL_06ed: Expected Obj, but got Ref
			//IL_06f3: Expected Obj, but got Ref
			//IL_06f9: Expected Obj, but got Ref
			//IL_06ff: Expected Obj, but got Ref
			//IL_0705: Expected Obj, but got Ref
			//IL_06d9: Expected Obj, but got I4
			//IL_06de: Expected Obj, but got I4
			//IL_06de: Expected Obj, but got Ref
			//IL_07cb: Expected Obj, but got I4
			//IL_096f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0972: Expected Obj, but got Unknown
			//IL_0878: Expected Obj, but got I4
			//IL_087d: Expected Obj, but got I4
			//IL_087d: Expected Obj, but got Ref
			//IL_0b8b: Expected Obj, but got Ref
			//IL_0bb6: Expected Obj, but got Ref
			//IL_0bc5: Expected VT, but got Obj
			//IL_0d6d: Expected Obj, but got I4
			//IL_0d72: Expected F8, but got VT
			//IL_0d81: Expected Obj, but got F8
			//IL_08eb: Expected I, but got Obj
			//IL_08eb: Expected Obj, but got Ref
			//IL_08fa: Expected Obj, but got I
			//IL_0d44: Expected Obj, but got Ref
			//IL_0d44: Expected Obj, but got Ref
			//IL_0d53: Expected Obj, but got I4
			//IL_0948: Expected Obj, but got Ref
			//IL_0950: Expected Obj, but got Ref
			//IL_0950: Expected Obj, but got Ref
			//IL_08b1: Expected Obj, but got Ref
			//IL_08bb: Expected Obj, but got Ref
			//IL_08c7: Expected Obj, but got Ref
			//IL_08d7: Expected Obj, but got I4
			//IL_0bf9: Expected native int or pointer, but got Obj
			//IL_0933: Expected Obj, but got I4
			//IL_0938: Expected Obj, but got I4
			//IL_0938: Expected Obj, but got Ref
			//IL_0a09: Expected VT, but got Obj
			//IL_0a13: Expected native int or pointer, but got Obj
			//IL_074b: Expected Obj, but got I4
			//IL_0750: Expected Obj, but got I4
			//IL_0750: Expected Obj, but got Ref
			//IL_09dd: Expected Obj, but got Ref
			//IL_09dd: Expected Obj, but got Ref
			//IL_0bd4: Expected Obj, but got I4
			//IL_0bd9: Expected Obj, but got I4
			//IL_0dbb: Expected Obj, but got Ref
			//IL_0dd3: Expected Obj, but got I4
			//IL_0ca8: Expected Obj, but got Ref
			//IL_0854: Expected Obj, but got Ref
			//IL_0737: Expected Obj, but got Ref
			//IL_0787: Expected Obj, but got Ref
			//IL_0cb9: Expected Obj, but got I4
			//IL_0cbe: Expected Obj, but got Ref
			//IL_0999: Expected I4, but got Obj
			//IL_0cf5: Expected Obj, but got I8
			//IL_081c: Expected Obj, but got Ref
			//IL_0821: Expected Obj, but got I
			//IL_0821: Expected Obj, but got Ref
			//IL_0b3e: Expected Obj, but got I4
			//IL_0d2b: Expected Obj, but got Ref
			//IL_0d33: Expected Obj, but got Ref
			//IL_0d33: Expected Obj, but got Ref
			//IL_0b1a: Expected Obj, but got Ref
			//IL_0b4e: Expected Obj, but got Ref
			//IL_0b56: Expected Obj, but got Ref
			//IL_0b56: Expected Obj, but got Ref
			//IL_0b56: Expected Obj, but got Ref
			//IL_0c64: Expected native int or pointer, but got Obj
			//IL_09ec: Expected native int or pointer, but got Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_1073->IL0026: Incompatible stack types: I4 vs Obj
			//IL_1093->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_107e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0096->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0176->IL00ad: Incompatible stack heights: 1 vs 2
			//IL_01ee->IL006f: Incompatible stack heights: 0 vs 1
			//IL_01de->IL00ad: Incompatible stack heights: 6 vs 2
			//IL_01e9->IL00ad: Incompatible stack heights: 6 vs 2
			//IL_0f22->IL006f: Incompatible stack heights: 0 vs 1
			//IL_05a4->IL0239: Incompatible stack heights: 1 vs 2
			//IL_02ec->IL0239: Incompatible stack heights: 3 vs 2
			//IL_040f->IL0239: Incompatible stack heights: 1 vs 2
			//IL_0487->IL0239: Incompatible stack types: I4 vs Ref
			//IL_03a9->IL0239: Incompatible stack heights: 1 vs 2
			//IL_0504->IL0441: Incompatible stack heights: 0 vs 1
			//IL_038e->IL0239: Incompatible stack heights: 1 vs 2
			//IL_04ab->IL1093: Incompatible stack heights: 0 vs 1
			//IL_051a->IL046c: Incompatible stack heights: 2 vs 1
			//IL_05af->IL0239: Incompatible stack heights: 1 vs 2
			//IL_041a->IL0239: Incompatible stack heights: 1 vs 2
			//IL_0492->IL0239: Incompatible stack types: I4 vs Ref
			//IL_03b4->IL0239: Incompatible stack heights: 1 vs 2
			//IL_050e->IL0239: Incompatible stack heights: 1 vs 2
			//IL_0524->IL0239: Incompatible stack heights: 3 vs 2
			//IL_0c49->IL05e6: Incompatible stack heights: 3 vs 2
			//IL_0b90->IL0ca1: Incompatible stack heights: 0 vs 1
			//IL_0c96->IL05e6: Incompatible stack heights: 1 vs 2
			//IL_0d86->IL05e6: Incompatible stack heights: 4 vs 2
			//IL_0a2d->IL0f1d: Incompatible stack heights: 0 vs 1
			//IL_0d58->IL05e6: Incompatible stack heights: 1 vs 2
			//IL_095a->IL05e6: Incompatible stack heights: 4 vs 2
			//IL_090f->IL0f1d: Incompatible stack heights: 0 vs 1
			//IL_0ab5->IL1093: Incompatible stack heights: 0 vs 1
			//IL_08e3->IL05e6: Incompatible stack heights: 1 vs 2
			//IL_0ae4->IL0a28: Incompatible stack heights: 2 vs 1
			//IL_09e2->IL0d3d: Incompatible stack heights: 0 vs 1
			//IL_0de7->IL05e6: Incompatible stack heights: 4 vs 2
			//IL_0cb4->IL05e6: Incompatible stack heights: 1 vs 2
			//IL_0a8b->IL1093: Incompatible stack heights: 0 vs 1
			//IL_0b7a->IL0f1d: Incompatible stack heights: 0 vs 1
			//IL_073c->IL0c79: Incompatible stack heights: 0 vs 1
			//IL_09cc->IL1093: Incompatible stack heights: 0 vs 1
			//IL_0df7->IL04b5: Incompatible stack heights: 0 vs 1
			//IL_0cfa->IL05e6: Incompatible stack heights: 5 vs 2
			//IL_088c->IL04ee: Incompatible stack heights: 0 vs 1
			//IL_0d3d->IL05e6: Incompatible stack heights: 4 vs 2
			//IL_0b6a->IL05e6: Incompatible stack heights: 3 vs 2
			//IL_0ba4->IL05e6: Incompatible stack heights: 1 vs 2
			//IL_0ca1->IL05e6: Incompatible stack heights: 1 vs 2
			//IL_0d91->IL05e6: Incompatible stack heights: 4 vs 2
			//IL_0d63->IL05e6: Incompatible stack heights: 1 vs 2
			//IL_0af8->IL05e6: Incompatible stack heights: 3 vs 2
			//IL_09f6->IL05e6: Incompatible stack heights: 1 vs 2
			//IL_0df2->IL05e6: Incompatible stack heights: 4 vs 2
			//IL_0746->IL05e6: Incompatible stack heights: 1 vs 2
			//IL_0d05->IL05e6: Incompatible stack heights: 5 vs 2
			//IL_0b75->IL05e6: Incompatible stack heights: 3 vs 2
			//IL_0baf->IL05e6: Incompatible stack heights: 1 vs 2
			//IL_0b03->IL05e6: Incompatible stack heights: 3 vs 2
			//IL_0a01->IL05e6: Incompatible stack heights: 1 vs 2
			ref readonly byte reference = ref Unsafe.As<_003Caction_003Ej__TPar, byte>(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field);
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			object awaiter = 1;
			object obj = awaiter;
			while (true)
			{
				int num2;
				int num;
				switch ((int)obj)
				{
				default:
					awaiter = ((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref this))._003Cuuid_003Ei__Field;
					obj = 0;
					if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
					{
						obj = 3;
					}
					break;
				case 5:
					((_003C_003Ef__AnonymousType2<, , , >)Unsafe.AsPointer(ref this))._003Curl_003Ei__Field = (_003Curl_003Ej__TPar)(-2);
					obj = 2;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field != 0)
					{
						obj = 2;
					}
					break;
				case 3:
					if ((nuint)(nint)awaiter <= (nuint)3u)
					{
						num2 = 6;
						goto IL_00ad;
					}
					goto IL_0136;
				case 1:
					awaiter = ((HeypixelRequest)Unsafe.AsPointer(ref this)).Url__BackingField;
					obj = 0;
					if (HeypixelRequest.ReflectExpandableParameter != null)
					{
						obj = 0;
					}
					break;
				case 2:
					reference = ref Unsafe.As<string, byte>(ref Unsafe.As<byte, Span<string>>(ref reference)[(int)Unsafe.AsPointer(ref ((HeypixelRequestDto)Unsafe.AsPointer(ref this)).Request__BackingField)]);
					obj = 4;
					break;
				case 4:
					return;
					IL_0461:
					num = 10;
					goto IL_0239;
					IL_0239:
					while (true)
					{
						switch (num)
						{
						case 7:
						case 17:
							break;
						case 24:
							((EntityLaunchGameProxy)Unsafe.AsPointer(ref this)).Value__BackingField = null;
							num = 15;
							continue;
						case 11:
							MemoryExtensions.IndexOfAny<T>((ReadOnlySpan<T>)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.DecorateConfigurableDecider(), (SearchValues<T>)(object)((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory)awaiter).CreateInstance());
							_ = 22;
							continue;
						case 22:
							if (awaiter is EnumGameType)
							{
								num = 12;
								continue;
							}
							goto case 9;
						case 16:
							_ = ((GameProxy)(object)GameProxy.OnlineClients).Name__BackingField;
							_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.VerifyVerifier();
							/*Error near IL_0319: Member reference must be method, but was: Field*/;
						default:
							awaiter = (Delegate)((GameProxy)Unsafe.AsPointer(ref this)).ServerAddress__BackingField;
							num = 11;
							continue;
						case 27:
							((GameProxy)Unsafe.AsPointer(ref reference)).Socks5 = (EntitySocks5?)Unsafe.AsPointer(ref this);
							_ = 18;
							continue;
						case 21:
							((GameProxy)Unsafe.AsPointer(ref reference)).BlockIrcMessages = (byte)Unsafe.AsPointer(ref this) != 0;
							_ = 20;
							if (((GameProxy)GameProxy.WorkerGroup__BackingField).AcceptorGroup__BackingField != null)
							{
								_ = 27;
							}
							continue;
						case 25:
							if ((nint)awaiter == 1)
							{
								num = 0;
								if (((GameProxy)GameProxy._channel).DisplayAddress__BackingField == null)
								{
									num = 0;
								}
								continue;
							}
							goto case 8;
						case 12:
							awaiter = (string?)/*Error near IL_03f9: Stack underflow*/ + (string?)int.TryParse((string?)Unsafe.AsPointer(ref reference), out *(int*)2000);
							_ = 4;
							if (GameProxy._003C_003EO._003C0_003E__PluginChanged == null)
							{
								_ = 29;
							}
							continue;
						case 14:
							GameProxy._003C_003EO._003C1_003E__OnConnectServer = (Action<EventConnectServer>)awaiter;
							num = 1;
							if (((GameProxy._003CListenAsync_003Ed__69*)(nint)GameProxy._003C_003EO._003C2_003E__OnConnectServer)->_003C_003E1__state == 0)
							{
								num = 1;
							}
							continue;
						case 6:
							goto IL_0441;
						case 20:
							goto IL_0461;
						case 19:
						{
							bool flag = ((EqualityComparer<EntitySocks5Account>)/*Error near IL_0473: Stack underflow*/).Equals((EntitySocks5Account?)Unsafe.AsPointer(ref reference), (EntitySocks5Account?)(&awaiter));
							num = 4;
							reference = ref *(flag ? ((byte*)1) : ((byte*)null));
							if ((int)((GameProxy._003CListenAsync_003Ed__69*)GameProxy._003CListenAsync_003Ed__69.port)->_003C_003Eu__1 != 0)
							{
								num = 5;
								reference = ref *(flag ? ((byte*)1) : ((byte*)null));
							}
							continue;
						}
						case 4:
							awaiter = 3;
							GameProxy._003CListenAsync_003Ed__69.CheckCentralResponder = 3;
							num = 14;
							continue;
						case 28:
							return;
						case 26:
							goto IL_04b5;
						case 13:
							awaiter = ((CpsDetector)Unsafe.AsPointer(ref this))._lastLeftCps;
							num = 24;
							continue;
						case 3:
						case 5:
						case 23:
							goto IL_04ee;
						case 29:
							_ = ref awaiter;
							if (EqualityComparer<bool>.Default == null)
							{
								_ = 4;
								continue;
							}
							goto case 19;
						case 18:
							((OhMyGodHwid)Unsafe.AsPointer(ref this)).Hwid__BackingField = OhMyGodEncryption.DecorateEfficientEmitter;
							num = 3;
							if (OhMyGodHwid.ControlProcessor == null)
							{
								num = 3;
							}
							continue;
						case 15:
							awaiter = -1;
							OhMyGodHwid._003C_003EO._003C0_003E__GenerateRandomMac = (Func<string>)(-1);
							num = 11;
							if (OhMyGodHwid._003C_003EO._003C2_003E__GenerateRandomDiskStoreInfo == null)
							{
								num = 19;
							}
							continue;
						case 9:
							((EntityLaunchGameProxy)/*Error near IL_057f: Stack underflow*/)._002Ector((DesktopSession)/*Error near IL_057f: Stack underflow*/, (string)/*Error near IL_057f: Stack underflow*/, (EnumGameType)/*Error near IL_057f: Stack underflow*/, (EnumGameVersion)/*Error near IL_057f: Stack underflow*/, (string)/*Error near IL_057f: Stack underflow*/, (string)/*Error near IL_057f: Stack underflow*/, (string)Unsafe.AsPointer(ref reference), (int)awaiter);
							((GameInstance)awaiter)._002Ector();
							((EntityLaunchGameProxy)/*Error near IL_0590: Stack underflow*/).Session = (DesktopSession)Interlocked.CompareExchange<T>(ref *(T*)/*Error near IL_058b: Stack underflow*/, (T)/*Error near IL_058b: Stack underflow*/, (T)/*Error near IL_058b: Stack underflow*/);
							_ = 3;
							if (((HytMainMenu.Menu)(object)HytMainMenu.CheckCentralTransmitter).Name != null)
							{
								_ = 17;
							}
							continue;
						case 10:
							goto IL_05af;
						case 2:
							if ((nint)awaiter != 3)
							{
								num = 11;
								if (Form.DecorateAttachedClient != null)
								{
									num = 16;
								}
								continue;
							}
							goto case 13;
						case 8:
							((Modal)Unsafe.AsPointer(ref this)).Title__BackingField = null;
							num = 23;
							if (((Modal)Modal.Content__BackingField).Button1__BackingField != null)
							{
								num = 19;
							}
							continue;
						case 1:
							Unsafe.As<object, AsyncTaskMethodBuilder>(ref ((Modal)Unsafe.AsPointer(ref this)).Button2__BackingField).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<int>*)(&awaiter), ref Unsafe.As<_003CStartAntiCheatAsync_003Ed__34, LanServerPinger._003C_003CStartAsync_003Eg__SendMessageAsync_007C6_0_003Ed>(ref this));
							num = 21;
							if (((EventHeypixelAntiCheat)(object)Modal.RestartPool).Protocol__BackingField == null)
							{
								num = 28;
							}
							continue;
						}
						break;
						IL_05af:
						switch ((int)awaiter)
						{
						case 1:
							goto IL_075a;
						case 0:
							goto IL_07ef;
						case 2:
							goto IL_095a;
						}
						int num3 = 2;
						if (HytMainMenu.Menu.CustomizeTemplate == null)
						{
							num3 = 2;
						}
						goto IL_05e6;
						IL_0441:
						((GameProxy._003CListenAsync_003Ed__69)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)0;
						num = 20;
						continue;
						IL_04ee:
						if ((EntitySocks5?)/*Error near IL_04ff: Stack underflow*/ == (EntitySocks5?)(object)((CpsDetector)((EntitySocks5)Unsafe.AsPointer(ref reference)).PrintMembers((StringBuilder)awaiter)).OnCpsChange)
						{
							_ = 7;
							continue;
						}
						goto IL_0441;
						IL_05e6:
						while (true)
						{
							switch (num3)
							{
							case 17:
							case 23:
							case 42:
								break;
							case 46:
								goto IL_04b5;
							case 53:
								goto IL_04ee;
							case 3:
								awaiter = -1;
								((HytMainMenu._003C_003Ec__DisplayClass2_0)Unsafe.AsPointer(ref this)).minecraft = (Mass.Game.Proxy.Minecraft.Minecraft)(-1);
								num3 = 39;
								continue;
							case 2:
								/*Error near IL_06ed: Stack underflow*/((GameProxy)Unsafe.AsPointer(ref reference));
								_ = ((HytMainMenu._003C_003Ec__DisplayClass2_1)Unsafe.AsPointer(ref this)).menu;
								_ = ((HytMainMenu._003C_003Ec__DisplayClass2_1)Unsafe.AsPointer(ref this)).index;
								_ = ((HytMainMenu._003C_003Ec__DisplayClass2_1)Unsafe.AsPointer(ref this)).CS_0024_003C_003E8__locals1;
								_ = ((EntityLaunchGameProxy)HytMainMenu._003C_003Ec__DisplayClass2_1.RunMapper).ServerAddress;
								/*Error near IL_070a: Member reference must be method, but was: Field*/;
							case 43:
								((Action<EventMinecraft>)/*Error near IL_0737: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref reference), (nint)(&awaiter));
								if ((int)/*Error near IL_073c: Stack underflow*/ == 0)
								{
									_ = 33;
									continue;
								}
								goto case 12;
							case 33:
								awaiter = 0;
								HytProtocol.CheckFilteredDistributor = (HytProtocol)0;
								num3 = 48;
								continue;
							case 5:
								goto IL_075a;
							case 45:
								if (((EntityLaunchGameProxy)((VexViewPacket)Unsafe.AsPointer(ref this)).PacketType__BackingField).ToString() != null)
								{
									num3 = 28;
									continue;
								}
								goto IL_04ee;
							case 4:
								EnumReflectCheck.BlackClasses = (EnumReflectCheck)((EntityLaunchGameProxy)((EnumReflectCheck)this).value__).GetHashCode();
								num3 = 19;
								if (EnumReflectCheck.ReflectCheck == EnumReflectCheck.ClientInfo)
								{
									num3 = 11;
								}
								continue;
							case 13:
								goto IL_07ef;
							case 50:
								((GameProxy)Unsafe.AsPointer(ref reference))._002Ector((EntityLaunchGameProxy)((HeypixelHwid)Unsafe.AsPointer(ref this)).DllCount__BackingField);
								/*Error near IL_0821: Member reference must be method, but was: Field*/;
							case 40:
								((HeypixelHwid)Unsafe.AsPointer(ref this)).UserListInfo__BackingField = awaiter;
								num3 = 23;
								if (((HeypixelHwid)HeypixelHwid.Mods__BackingField).UserInfo__BackingField == null)
								{
									num3 = 54;
								}
								continue;
							case 9:
								awaiter = -1;
								((HeypixelHwid)Unsafe.AsPointer(ref this)).EncryptMods__BackingField = -1;
								num3 = 12;
								continue;
							case 26:
							case 28:
								((GameProxy)Unsafe.AsPointer(ref reference)).TransferServerAddress = ((GameProxy)(object)HeypixelHwid.CheckMixedEncryptor).TransferServerAddress;
								awaiter = (string?)/*Error near IL_08d7: Stack underflow*/ + (string?)(object)new AbstractBootstrap<ServerBootstrap, IServerChannel>(1) + (string?)(object)((GameProxy)(object)((GameProxy)(object)HeypixelMod.DecorateCommonAllocator).Section).WorkerGroup + (string?)0;
								_ = 38;
								continue;
							case 16:
								((HeypixelProtocol)Unsafe.AsPointer(ref this)).HwidSpoof__BackingField = (nint)awaiter;
								num3 = 1;
								if (Logger__BackingField == null)
								{
									num3 = 8;
								}
								continue;
							case 31:
								awaiter = 2;
								((HeypixelProtocol)Unsafe.AsPointer(ref this)).CpsDetector = (CpsDetector)2;
								num3 = 32;
								continue;
							case 20:
								_ = ref ((HeypixelProtocol)Unsafe.AsPointer(ref this))._timestampPacket;
								((IEnumerable<JsonElement>)(&awaiter)).All((Func<JsonElement, bool>)Unsafe.AsPointer(ref this));
								_ = 24;
								continue;
							case 22:
								goto IL_095a;
							case 7:
								awaiter++;
								num3 = 1;
								if (_003C_003Ec.DecorateCustomAuthorizer == null)
								{
									num3 = 1;
								}
								continue;
							case 48:
								((_003CInitialize_003Ed__17)this)._003C_003E1__state = (int)awaiter;
								num3 = 20;
								continue;
							case 44:
								return;
							case 35:
								((List<string>)Unsafe.AsPointer(ref reference)).Add((string)(&awaiter));
								if ((int)/*Error near IL_09e2: Stack underflow*/ == 0)
								{
									_ = 25;
									if (((_003CStartAntiCheatAsync_003Ed__34*)(nint)_003CInitialize_003Ed__17.CheckMixedExecutor)->_003C_003E1__state != 0)
									{
										_ = 47;
									}
									continue;
								}
								goto case 18;
							case 32:
								_003C_003Et__builder = (AsyncTaskMethodBuilder)awaiter;
								num3 = 40;
								if (((_003CStartAntiCheatAsync_003Ed__34*)(nint)_003CStartAntiCheatAsync_003Ed__34.key)->_003C_003E4__this != null)
								{
									num3 = 56;
								}
								continue;
							case 1:
							case 52:
								if ((nint)awaiter < ((Array)awaiter).Length)
								{
									num3 = 37;
									continue;
								}
								goto case 34;
							case 6:
								_003Ccontext_003E5__4 = null;
								num3 = 9;
								continue;
							case 41:
								return;
							case 21:
								if ((nint)SHA1.HashData((byte[])awaiter) != 200)
								{
									num3 = 42;
									continue;
								}
								goto case 14;
							case 24:
								return;
							case 34:
								_ = _003Cdto_003E5__9;
								if (OrangeProtocol.ArrangeRequester() != null)
								{
									break;
								}
								_ = 17;
								if ((int)((_003CStartAntiCheatAsync_003Ed__34)_003CStartAntiCheatAsync_003Ed__34._003C_003Eu__2)._003C_003Eu__3 == 0)
								{
									_ = 27;
								}
								continue;
							case 19:
								CheckCommonNode = null;
								num3 = 46;
								continue;
							case 55:
								Unsafe.As<nint, @null>(ref ((HeypixelRedirectProtocol)Unsafe.AsPointer(ref this)).Joined__BackingField) = null;
								num3 = 36;
								continue;
							case 29:
							case 37:
								awaiter = ((object[])awaiter)[awaiter];
								num3 = 49;
								continue;
							case 51:
								awaiter = 0;
								num3 = 52;
								continue;
							case 56:
								((IByteBuffer)(object)Unsafe.AsPointer(ref HeypixelRedirectProtocol.MonitorCompressor)).WritePrefixedArray((List<NbtTag>)(&awaiter), (Action<NbtTag>)Unsafe.AsPointer(ref this));
								_ = 11;
								if (HeypixelReflectCheckResult.CollectEncryptor == null)
								{
									_ = 44;
								}
								continue;
							case 11:
								if (((byte[])Unsafe.AsPointer(ref reference)).ToHex((byte)(&awaiter) != 0) == null)
								{
									_ = 31;
									if (HeypixelReflectCheckResult._003C_003Ec.ArrangeStrategy == null)
									{
										_ = 24;
									}
									continue;
								}
								goto case 39;
							case 14:
								((MassServiceExtensions._003CGetHeypixelAntiCheat_003Ed__2)this)._003C_003Et__builder = (AsyncTaskMethodBuilder<HeypixelRequestDto>)OhMyGodHwid.EncryptOrFallback((Func<string>)JavaUuidCompat.ReflectIterableProgram, OhMyGodHwid.GenerateHwid());
								num3 = 4;
								continue;
							case 36:
								awaiter = -1;
								((MassServiceExtensions._003CGetHeypixelAntiCheat_003Ed__2)this).massService = (MassService)(-1);
								num3 = 18;
								continue;
							case 30:
								((MassServiceExtensions._003CGetHeypixelAntiCheat_003Ed__2)this).url = null;
								num3 = 3;
								if (((MassServiceExtensions._003CGetHeypixelAntiCheat_003Ed__2*)(nint)MassServiceExtensions._003CGetHeypixelAntiCheat_003Ed__2.context)->userId == null)
								{
									num3 = 3;
								}
								continue;
							case 8:
								_ = ((MassServiceExtensions._003CGetHeypixelSession_003Ed__1)this)._003C_003E1__state;
								awaiter = OhMyGodProtocol.CheckVisibleDefinition();
								_ = 51;
								continue;
							case 25:
							case 27:
							{
								MassService massService = ((MassServiceExtensions._003CGetHeypixelSession_003Ed__1)this).massService;
								HytMainMenu._002Ecctor();
								if ((nint)massService <= 0)
								{
									num3 = 10;
									if (((MassServiceExtensions._003CGetHeypixelSession_003Ed__1*)(nint)MassServiceExtensions._003CGetHeypixelSession_003Ed__1.uuid)->userId == null)
									{
										num3 = 1;
									}
									continue;
								}
								goto case 50;
							}
							case 12:
								Unsafe.As<byte, bool?>(ref reference) = (byte)(&awaiter) != 0;
								awaiter = (object)/*Error near IL_0c82: Stack underflow*/;
								_ = 9;
								if (MsgPackExtensions.ReflectMonoContext == null)
								{
									_ = 16;
								}
								continue;
							case 39:
								awaiter = ((List<HytMainMenu.Menu>)Unsafe.AsPointer(ref reference))[(int)(&awaiter)];
								_ = 15;
								continue;
							case 47:
								awaiter = 1;
								((ServerboundCpsPacket)Unsafe.AsPointer(ref this)).RightCps__BackingField = 1;
								num3 = 40;
								if (((ServerboundReflectCheckPacket)ServerboundCpsPacket.DecorateScopeRequester).CheckType__BackingField == EnumReflectCheck.ClientInfo)
								{
									num3 = 4;
								}
								continue;
							case 49:
								HytMainMenu._003C_003Ec__DisplayClass2_1.CheckHiddenSubscriber();
								_ = 6;
								if (((ServerboundReflectCheckPacket)ServerboundReflectCheckPacket.Timestamp__BackingField).ReflectCheckAction__BackingField == null)
								{
									_ = 7;
								}
								continue;
							default:
							{
								object obj2 = awaiter;
								((HytProtocol)(object)ServerboundTimestampPacket.FillReg)._002Ector();
								if (obj2 != null)
								{
									num3 = 23;
									continue;
								}
								goto case 45;
							}
							case 54:
								_ = ref ((Mass.Game.Proxy.Protocols.Heypixel.Serverbound.ServerboundUseItemPacket)Unsafe.AsPointer(ref this)).Y;
								((IEnumerable<TextComponent>)(&awaiter)).Select((Func<TextComponent, string>)Unsafe.AsPointer(ref this));
								_ = 41;
								continue;
							case 18:
								((Action<GermPacket>)Unsafe.AsPointer(ref reference))((GermPacket)(&awaiter));
								_ = 0;
								if ((int)((Mass.Game.Proxy.Protocols.Heypixel.Serverbound.ServerboundUseItemPacket)Mass.Game.Proxy.Protocols.Heypixel.Serverbound.ServerboundUseItemPacket.Sequence).LocationX != 0)
								{
									_ = 0;
								}
								continue;
							case 15:
								((Mass.Game.Proxy.Protocols.Heypixel.Serverbound.ServerboundUseItemPacket)null).LocationZ = (double)CollectionsMarshal.AsSpan<T>((List<T>?)1);
								_ = 1;
								if ((int)((Mass.Game.Proxy.Protocols.Heypixel.Serverbound.ServerboundUseItemPacket)Mass.Game.Proxy.Protocols.Heypixel.Serverbound.ServerboundUseItemPacket.BlockX).BlockY == 0)
								{
									_ = 21;
								}
								continue;
							case 38:
								_ = ((Mass.Game.Proxy.Protocols.Heypixel.Serverbound.ServerboundUseItemPacket)Unsafe.AsPointer(ref this)).PlayerYaw;
								*(JsonProperty*)(&awaiter) = default;
								awaiter = ((IByteBuffer)((byte[])awaiter).ZipCompress()).ReadableBytes;
								_ = 7;
								if (Button.DecorateSortedConsumer == null)
								{
									_ = 11;
								}
								continue;
							}
							break;
						}
						break;
						IL_095a:
						awaiter = _003C_003Ec._003C_003E9;
						num3 = 30;
						goto IL_05e6;
						IL_07ef:
						awaiter = HeypixelEncryption.PlanDistributor;
						num3 = 6;
						if (((HeypixelHwid)HeypixelHwid.ClientGuid__BackingField).ClassesCount__BackingField != 0)
						{
							num3 = 6;
						}
						goto IL_05e6;
						IL_04b5:
						awaiter = ((CpsDetector)Unsafe.AsPointer(ref this))._lock;
						num = 20;
						if (((CpsDetector)(object)Mass.Game.Proxy.Protocols.CpsDetector._leftClicks)._rightClicks != null)
						{
							num = 25;
						}
						continue;
						IL_075a:
						awaiter = VexViewCodec.OpenEmitter;
						num3 = 23;
						if (VexViewGuiPacket.InsertListener == null)
						{
							num3 = 55;
						}
						goto IL_05e6;
					}
					goto case 5;
					IL_0136:
					CollectionsMarshal.SetCount((List<FmlMod>)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.ReflectModularWriter()).url, (int)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_ascii_68FF03FEFFFF87FEFFFF07);
					num2 = 2;
					goto IL_00ad;
					IL_00ad:
					while (true)
					{
						switch (num2)
						{
						case 7:
							break;
						case 2:
							if (!((EqualityComparer<_00212>)awaiter).Equals((_00212?)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic, (_00212?)new { }))
							{
								num2 = 2;
								if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance == null)
								{
									num2 = 5;
								}
								continue;
							}
							break;
						default:
							goto IL_0136;
						case 1:
						case 5:
						{
							_003Cuser_id_003Ej__TPar user_id = ((_003C_003Ef__AnonymousType2<, , , >)Unsafe.AsPointer(ref reference)).user_id;
							EqualityComparer<_00213> equalityComparer = new EqualityComparer<_00213>();
							awaiter = ((EqualityComparer<_00213>)user_id).GetHashCode((_00213)((_003C_003Ef__AnonymousType2<, , , >)(object)equalityComparer).Equals((object)equalityComparer));
							_ = 8;
							continue;
						}
						case 4:
						case 6:
							num2 = 0;
							if (((EntityLaunchGameProxy)EntitySocks5.DecorateDynamicModule).Session__BackingField != null)
							{
								num2 = 3;
							}
							continue;
						case 8:
							_ = null;
							_ = null;
							((EntityLaunchGameProxy)0).GameType__BackingField = (EnumGameType)new Regex();
							_ = 4;
							if (((EntityLaunchGameProxy)EntityLaunchGameProxy.GameVersion__BackingField).ModHashList__BackingField == null)
							{
								_ = 4;
							}
							continue;
						case 3:
							goto IL_020d;
						}
						break;
					}
					goto case 5;
					IL_020d:
					if ((nuint)(nint)awaiter > (nuint)2u)
					{
						num = 1;
						if (((EntityLaunchGameProxy)EntityLaunchGameProxy.ServerPort__BackingField).Socks5__BackingField == null)
						{
							num = 2;
						}
						goto IL_0239;
					}
					goto IL_0461;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_2A00(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected Obj, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 3 vs 2
			//IL_0064->IL0026: Incompatible stack heights: 3 vs 2
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
				case 0:
					return;
				case 1:
					((EqualityComparer<_00210>)Unsafe.AsPointer(ref ((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref this))._003Cuuid_003Ei__Field)).GetHashCode((_00210)P_0);
					_ = 0;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field != 0)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_2B00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778490, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[CompilerGenerated]
	private nint HwidSpoof__BackingField;

	[CompilerGenerated]
	private static readonly object Logger__BackingField;

	public HeypixelHwid Hwid;

	public bool RegisterChannel;

	public CpsDetector CpsDetector;

	private long _timestampPacket;

	internal static HeypixelProtocol ReflectGateway;

	[ConfigValue(ValueIcon.Fingerprint, "hwid-spoof", "是否启用机器码伪装", "控制是否启用硬件机器码（HWID）伪装功能。开启后，程序将动态修改并隐藏本机的真实硬件特征（如主板、硬盘序列号等），有效防止因机器码被封禁而无法访问，同时保护设备隐私。")]
	[BoolValue(true)]
	public bool HwidSpoof
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 瘀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			吀(value ? ((byte)1) : ((byte)0));
		}
	}

	[BoolValue(true)]
	[ConfigValue(ValueIcon.Chat, "enable-logging", "是否启用聊天框消息输出", "控制是否启用聊天框消息输出。关闭后将不会进行协议相关的消息提示。")]
	public bool EnableLogging
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 䔀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			䨀(value ? ((byte)1) : ((byte)0));
		}
	}

	public static ILogger Logger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe HeypixelProtocol()
	{
		//IL_001a: Expected VT, but got Obj
		//IL_001f: Expected VT, but got Obj
		//IL_001f: Expected Obj, but got Ref
		//IL_002f: Expected VT, but got Obj
		//IL_0039: Expected Obj, but got I4
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._003Cuser_id_003Ei__Field = (_003Cuser_id_003Ej__TPar)new
		{
			action = (_003Caction_003Ej__TPar)this
		};
		((_003C_003Ef__AnonymousType2<, , , >)(object)this)._003Curl_003Ei__Field = (_003Curl_003Ej__TPar)new { };
		object obj = 19;
		/*Error near IL_003b: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(Mass.Game.Proxy.Minecraft.Minecraft minecraft)
	{
		甀(minecraft);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnCpsChange(double leftCps, double rightCps)
	{
		儀(leftCps, rightCps);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInitialize_003Ed__17))]
	protected override Task<bool> Initialize()
	{
		return 漀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public override void OnJoinGame(EventPacket<ClientboundJoinGamePacket> @event)
	{
		栀(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public override void OnServerPluginMessage(EventServerPluginMessage @event)
	{
		爀(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public override void OnClientPluginMessage(EventClientPluginMessage @event)
	{
		倀(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public void OnTicking(EventTicking @event)
	{
		琀(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public void OnArmSwing(EventSwingArm @event)
	{
		怀(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public void OnItemUse(EventPacket<Mass.Game.Proxy.Packets.Play.ServerboundUseItemPacket> @event)
	{
		䌀(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public void OnItemUseOn(EventPacket<ServerboundUseItemOnPacket> @event)
	{
		嬀(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public void OnHandshake(EventPacket<ServerboundHandshakePacket> @event)
	{
		䀀(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public void OnServerChat(EventServerChat @event)
	{
		夀(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public void OnDisconnect(EventDisconnect @event)
	{
		㸀(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public void OnKnownPacks(EventPacket<ServerboundKnownPacksPacket> @event)
	{
		㐀(@event);
	}

	[SubscribeEvent]
	public static void OnConnectServer(EventConnectServer @event)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public void OnSetEntityMetaData(EventPacket<ClientboundSetEntityMetadataPacket> @event)
	{
		一(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowText(string? text)
	{
		搀(text);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SendPluginMessage(string channelName, IByteBuffer buffer)
	{
		愀(channelName, buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CStartAntiCheatAsync_003Ed__34))]
	public Task StartAntiCheatAsync(string key)
	{
		return (Task)洀(key);
	}

	static HeypixelProtocol()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_001f: Expected I4, but got Obj
		//IL_004d->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0058->IL0012: Incompatible stack types: I4 vs Obj
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
				Logger__BackingField = Log.Logger.Category((string)ZYXDNGuarder.䄀());
				obj2 = 0;
				if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_7d8a74fdb4384df0837ba9c40f699c8e == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectJoinedFilter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HeypixelProtocol DecorateLiteralStack()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _3300(EventPacket<ServerboundKnownPacksPacket> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778392, new IntPtr(2737367946284L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 㐀(EventPacket<ServerboundKnownPacksPacket> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got Obj
		//IL_003f: Expected VT, but got Ref
		//IL_0044: Expected Obj, but got I4
		//IL_0049: Expected Obj, but got I4
		//IL_0058: Expected Obj, but got VT
		//IL_005d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005d->IL0026: Incompatible stack types: Obj vs Ref
		//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0068->IL0026: Incompatible stack types: Obj vs Ref
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
				string? text = ((object)((_003C_003Ef__AnonymousType0<>)/*Error near IL_0044: Stack underflow*/).Equals((object)((EqualityComparer<_00210>)/*Error near IL_003f: Stack underflow*/).Equals((_00210?)Unsafe.AsPointer(ref reference), (_00210?)P_0))).ToString();
				obj2 = 0;
				reference = ref *(_003Caction_003Ej__TPar*)text;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field != 0)
				{
					obj2 = 0;
					reference = ref *(_003Caction_003Ej__TPar*)text;
				}
				break;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 㔀(EventPacket<ServerboundKnownPacksPacket> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778395, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 㸀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got Obj
		//IL_003f: Expected Obj, but got Ref
		//IL_009f: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I4
		//IL_00b0: Expected Obj, but got VT
		//IL_0251: Expected Obj, but got I4
		//IL_0258: Expected VT, but got I4
		//IL_0112: Expected VT, but got I4
		//IL_00d2: Expected Obj, but got VT
		//IL_01e8: Expected Obj, but got I4
		//IL_01f9: Expected I4, but got VT
		//IL_01fe: Expected Obj, but got VT
		//IL_01fe: Expected VT, but got Obj
		//IL_0203: Expected Obj, but got I4
		//IL_0203: Expected VT, but got Obj
		//IL_0205: Expected Obj, but got I4
		//IL_0164: Expected Obj, but got VT
		//IL_00e7->IL0318: Incompatible stack heights: 0 vs 1
		//IL_0264->IL0052: Incompatible stack heights: 4 vs 1
		//IL_0158->IL0052: Incompatible stack heights: 6 vs 1
		//IL_028d->IL0318: Incompatible stack heights: 0 vs 1
		//IL_0126->IL0318: Incompatible stack heights: 0 vs 1
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		int num;
		switch ((int)obj)
		{
		case 1:
			((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Caction_003Ej__TPar)P_0);
			if ((int)/*Error near IL_0044: Stack underflow*/ == 0)
			{
				num = 2;
				goto IL_0052;
			}
			goto IL_0094;
		case 0:
			break;
			IL_0052:
			while (true)
			{
				switch (num)
				{
				case 10:
					obj = (object)/*Error near IL_00c3: Stack underflow*/;
					num = 1;
					if (_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic == null)
					{
						num = 5;
					}
					continue;
				case 2:
					return;
				case 6:
					if (!((EqualityComparer<_00211>)/*Error near IL_0112: Stack underflow*/).Equals((_00211?)/*Error near IL_0112: Stack underflow*/, (_00211?)((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_010d: Stack underflow*/).Equals(obj)))
					{
						num = 9;
						continue;
					}
					goto case 3;
				case 9:
					return;
				case 4:
				case 5:
					((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_0135: Stack underflow*/).ToString();
					_003C_003Ef__AnonymousType1<, , >.ReflectScalableStack();
					_ = _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_hasTimeout;
					JsonSerializer.Serialize((_003C_003Ef__AnonymousType3<int, string>)obj, (JsonSerializerOptions?)obj);
					_ = 8;
					continue;
				case 13:
					_ = ((_003C_003Ef__AnonymousType2<, , , >)((_003C_003Ef__AnonymousType2<, , , >)obj).context).user_id;
					_ = 4;
					_ = EqualityComparer<_00213>.Default;
					_ = new EqualityComparer<>[3];
					__ldtoken(EntitySocks5.Address__BackingField);
					/*Error near IL_0176: Member reference must be method, but was: Field*/;
				case 8:
					_ = new
					{
						value = obj
					};
					/*Error near IL_01b1: Member reference must be method, but was: Field*/;
				case 11:
				{
					object obj3 = obj;
					((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0)_003C_003Ef__AnonymousType3<, >.DecorateIntegratedProgram())._002Ector();
					((RegexRunner)4).CheckTimeout();
					IEquatable<>[] array = new IEquatable<>[3];
					obj = MemoryExtensions.IndexOfAnyExcept<T>((ReadOnlySpan<T>)obj3, (SearchValues<T>)MemoryExtensions.IndexOfAny<T>((ReadOnlySpan<T>)array, (SearchValues<T>)((ReadOnlySpan<char>*)array)->Slice((int)__ldtoken(EntityLaunchGameProxy.ReflectAlphabeticProcessor))));
					num = 0;
					if (GameProxy.OnlineClients == null)
					{
						num = 1;
					}
					continue;
				}
				case 12:
					((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)obj)._002Ector();
					if (SearchValues.Create((ReadOnlySpan<char>)/*Error near IL_0230: Stack underflow*/) == null)
					{
						num = 13;
						continue;
					}
					goto case 10;
				case 3:
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.DecorateCustomNode();
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities._002Ecctor();
					AppContext.GetData((string)4);
					obj = Type.GetTypeFromHandle((RuntimeTypeHandle)32);
					_ = 12;
					continue;
				case 1:
				{
					object obj2 = obj;
					((StringBuilder)obj)._002Ector();
					obj = obj2;
					num = 4;
					continue;
				}
				case 7:
					return;
				}
				break;
			}
			goto IL_0094;
			IL_0094:
			obj = ((_003C_003Ef__AnonymousType0<>)((_003C_003Ef__AnonymousType0<>)/*Error near IL_009a: Stack underflow*/).Equals(P_0)).GetHashCode();
			num = 6;
			if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field != 0)
			{
				num = 6;
			}
			goto IL_0052;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 䀀(EventPacket<ServerboundHandshakePacket> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0050: Expected VT, but got Obj
		//IL_0050: Expected Obj, but got Ref
		//IL_0051: Invalid comparison between Unknown and I4
		//IL_00e0: Expected VT, but got Obj
		//IL_00e0: Expected Obj, but got Ref
		//IL_00e2: Expected Obj, but got I4
		//IL_0067: Expected VT, but got I4
		//IL_00b1: Expected VT, but got Obj
		//IL_00b1: Expected VT, but got Ref
		//IL_00b6: Invalid comparison between Unknown and I4
		//IL_0056->IL0048: Incompatible stack heights: 0 vs 1
		//IL_00f6->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0076->IL0026: Incompatible stack heights: 4 vs 2
		//IL_009f->IL0026: Incompatible stack heights: 5 vs 2
		//IL_00bb->IL0048: Incompatible stack heights: 0 vs 1
		//IL_0060->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0101->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00aa->IL0026: Incompatible stack heights: 5 vs 2
		//IL_00cf->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00da->IL0026: Incompatible stack heights: 1 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 5:
				return;
			default:
				((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Caction_003Ej__TPar)obj);
				if ((int)/*Error near IL_0056: Stack underflow*/ != 2)
				{
					return;
				}
				_ = 4;
				break;
			case 2:
				new EqualityComparer<_00210>((_00210)1).ToString();
				_ = 5;
				break;
			case 3:
				((_003C_003Ef__AnonymousType0<>)(object)this).ToString();
				_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
				_ = ((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType0<>.ReflectJoinedTree()).name;
				_ = 2;
				if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field == 0)
				{
					_ = 2;
				}
				break;
			case 4:
				((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_00b1: Stack underflow*/)._002Ector((_003Cname_003Ej__TPar)/*Error near IL_00b1: Stack underflow*/, (_003Cuuid_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_003Cuser_id_003Ej__TPar)obj);
				if ((int)/*Error near IL_00bb: Stack underflow*/ == 766)
				{
					return;
				}
				_ = 3;
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance == null)
				{
					_ = 2;
				}
				break;
			case 1:
				obj = ((EqualityComparer<_00211>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).GetHashCode((_00211)P_0);
				_ = 0;
				if ((int)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_defaultTimeout != 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 䈀(EventPacket<Mass.Game.Proxy.Packets.Play.ServerboundUseItemPacket> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778394, new IntPtr(2737367948364L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 䌀(EventPacket<Mass.Game.Proxy.Packets.Play.ServerboundUseItemPacket> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0043: Expected Obj, but got VT
		//IL_0043: Expected Obj, but got Ref
		//IL_0057->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0057->IL0026: Incompatible stack types: I4 vs Ref
		//IL_0062->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0062->IL0026: Incompatible stack types: I4 vs Ref
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
			case 1:
			{
				bool flag = ((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref reference)).Equals(((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field);
				obj2 = 0;
				reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
				{
					obj2 = 0;
					reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
				}
				break;
			}
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 䐀(EventPacket<Mass.Game.Proxy.Packets.Play.ServerboundUseItemPacket> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778389, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte 䔀()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (byte)(int)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte 䘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778388, new IntPtr(2737367947324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object 䜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778391, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 䠀()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 䤀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778390, new IntPtr(2737367948364L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 䨀(byte P_0)
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
	internal unsafe void 一(EventPacket<ClientboundSetEntityMetadataPacket> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0057: Expected I4, but got Obj
		//IL_00dd: Expected Obj, but got VT
		//IL_01ba: Expected Obj, but got Ref
		//IL_01bf: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I4
		//IL_0075: Expected VT, but got Obj
		//IL_0075: Expected Obj, but got Ref
		//IL_007f: Expected Obj, but got VT
		//IL_01e4: Expected I4, but got Obj
		//IL_01d3->IL01d8: Incompatible stack heights: 2 vs 3
		//IL_006e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01ee->IL0026: Incompatible stack heights: 1 vs 2
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 2;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					return;
				case 8:
					if ((nint)obj > 0)
					{
						obj2 = 5;
						break;
					}
					goto case 10;
				case 4:
					return;
				case 7:
					((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Caction_003Ej__TPar)P_0);
					((_003C_003Ef__AnonymousType0<>)((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_007a: Stack underflow*/)._003Cuser_id_003Ei__Field).GetHashCode();
					((_003C_003Ef__AnonymousType0<>)obj).ToString();
					_ = ref obj;
					/*Error near IL_0088: Member reference must be method, but was: Field*/;
				case 2:
					/*Error near IL_009d: Member reference must be method, but was: Field*/;
				case 1:
					if ((int)((_003C_003Ef__AnonymousType3<, >)((_003C_003Ef__AnonymousType1<, , >)(object)P_0).user_id)._003Csid_003Ei__Field == 0)
					{
						return;
					}
					goto end_IL_0026;
				case 6:
					return;
				case 3:
					return;
				case 10:
					_003C_003Ef__AnonymousType1<, , >.ReflectScalableStack();
					/*Error near IL_0126: Member reference must be method, but was: Field*/;
				case 9:
					_ = 1;
					/*Error near IL_0151: Member reference must be method, but was: Field*/;
				case 0:
					return;
				case 5:
				{
					int hashCode = ((_003C_003Ef__AnonymousType3<, >)((_003C_003Ef__AnonymousType3<, >)/*Error near IL_01ba: Stack underflow*/).Equals((object)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))).GetHashCode();
					object obj3 = obj;
					bool flag;
					if ((nint)obj != 1)
					{
						((_003C_003Ef__AnonymousType3<, >)obj3).ToString();
					}
					else
					{
						flag = _003C_003Ef__AnonymousType3<, >.LoadCache();
					}
					((ILogger)hashCode).Debug<int, string, int>((string)obj3, flag ? 1 : 0, (string)obj, (int)_003C_003Ef__AnonymousType3<, >.DecorateIntegratedProgram());
					_ = 10;
					break;
				}
				}
				continue;
				end_IL_0026:
				break;
			}
			obj = 7;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 伀(EventPacket<ClientboundSetEntityMetadataPacket> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778385, new IntPtr(2737367948364L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 倀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_004c: Expected VT, but got I4
		//IL_004c: Expected VT, but got Obj
		//IL_0051: Expected VT, but got Obj
		//IL_0051: Expected Obj, but got Ref
		//IL_009f: Expected Obj, but got VT
		//IL_00a4: Expected Obj, but got VT
		//IL_00a9: Expected VT, but got Ref
		//IL_0065->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0065->IL0026: Incompatible stack types: I4 vs Ref
		//IL_00ae->IL0045: Incompatible stack heights: 0 vs 1
		//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0070->IL0026: Incompatible stack types: I4 vs Ref
		//IL_00df->IL0026: Incompatible stack heights: 4 vs 2
		//IL_00c2->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00cd->IL0026: Incompatible stack heights: 1 vs 2
		ref readonly _003Caction_003Ej__TPar reference = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				return;
			default:
			{
				int hashCode = ((EqualityComparer<_00210>)Unsafe.AsPointer(ref reference)).GetHashCode((_00210)new EqualityComparer<_00210>((_00210?)P_0, (_00210?)1));
				obj2 = 1;
				reference = ref *(_003Caction_003Ej__TPar*)hashCode;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
				{
					obj2 = 0;
					reference = ref *(_003Caction_003Ej__TPar*)hashCode;
				}
				break;
			}
			case 3:
				if (!((EqualityComparer<_00212>)/*Error near IL_00a9: Stack underflow*/).Equals((_00212?)Unsafe.AsPointer(ref reference), (_00212?)((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType1<, , >)P_0).name).uuid).user_id))
				{
					_ = 0;
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance != null)
					{
						_ = 2;
					}
					break;
				}
				goto default;
			case 1:
				return;
			case 2:
				((_003C_003Ef__AnonymousType1<, , >)P_0).ToString();
				_ = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void 儀(double P_0, double P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected VT, but got Obj
		//IL_0047: Expected Obj, but got I4
		//IL_004f: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got VT
		//IL_0068->IL0026: Incompatible stack heights: 6 vs 2
		//IL_0073->IL0026: Incompatible stack heights: 6 vs 2
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
			case 0:
				return;
			case 1:
				new
				{
					action = (_003Caction_003Ej__TPar)this
				}.Equals((int)P_0);
				((_003C_003Ef__AnonymousType0<>)((_003C_003Ef__AnonymousType0<>)(int)P_1).GetHashCode()).ToString();
				_ = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void 刀(double P_0, double P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778384, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 匀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778387, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 吀(byte P_0)
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
	internal unsafe void 唀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778386, new IntPtr(2737367941084L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 夀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected VT, but got Obj
		//IL_0040: Expected Obj, but got Ref
		//IL_0051: Expected Obj, but got VT
		//IL_0126: Expected Obj, but got VT
		//IL_00ba: Expected Obj, but got VT
		//IL_00bf->IL0065: Incompatible stack heights: 4 vs 1
		//IL_0184->IL0038: Incompatible stack heights: 0 vs 1
		//IL_0151->IL0038: Incompatible stack heights: 0 vs 1
		//IL_01c8->IL0038: Incompatible stack heights: 0 vs 1
		//IL_00ca->IL0065: Incompatible stack heights: 4 vs 1
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 1;
		switch ((int)obj)
		{
		case 0:
			break;
		case 1:
		{
			((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Caction_003Ej__TPar)P_0);
			obj = (object)/*Error near IL_0042: Stack underflow*/;
			int num = 0;
			if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 3:
					return;
				case 6:
					return;
				case 9:
					return;
				case 10:
					return;
				case 2:
				case 7:
					((_003C_003Ef__AnonymousType0<>)(object)this).ToString();
					_003C_003Ef__AnonymousType0<>.ReflectActiveCalc();
					_003C_003Ef__AnonymousType0<>.ReflectJoinedTree();
					_ = 10;
					if (_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic == null)
					{
						_ = 10;
					}
					break;
				case 4:
				case 8:
					((_003C_003Ef__AnonymousType1<, , >)/*Error near IL_00d6: Stack underflow*/)._002Ector((_003Cname_003Ej__TPar)/*Error near IL_00d6: Stack underflow*/, (_003Cuuid_003Ej__TPar)/*Error near IL_00d6: Stack underflow*/, ((_003C_003Ef__AnonymousType1<, , >)obj).user_id);
					if (EqualityComparer<_00211>.Default == null)
					{
						return;
					}
					num = 7;
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectLocalTemplate == null)
					{
						num = 3;
					}
					break;
				default:
					obj = obj as OrangeProtocol;
					num = 1;
					if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_hasTimeout)
					{
						num = 1;
					}
					break;
				case 5:
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)obj).payload != 0)
					{
						return;
					}
					num = 8;
					break;
				case 1:
					if (obj == null)
					{
						num = 6;
						if (EntitySocks5Account.AttachElement == null)
						{
							num = 6;
						}
						break;
					}
					goto case 5;
				}
			}
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 娀(EventPacket<ServerboundUseItemOnPacket> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778477, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 嬀(EventPacket<ServerboundUseItemOnPacket> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00c6: Expected VT, but got Obj
		//IL_00c6: Expected VT, but got Ref
		//IL_00d2: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got F8
		//IL_00ef: Expected Obj, but got I4
		//IL_00f6: Expected Obj, but got F8
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got VT
		//IL_0107: Expected Obj, but got Unknown
		//IL_010e: Expected Obj, but got F8
		//IL_010e: Expected Obj, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected I4, but got F8
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_0144: Expected Obj, but got I4
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got F8
		//IL_0153: Expected Obj, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected I, but got F8
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got F8
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected VT, but got Obj
		//IL_018a: Expected Obj, but got Unknown
		//IL_018f: Expected Obj, but got Unknown
		//IL_0195: Expected Obj, but got F8
		//IL_0195: Expected Obj, but got Unknown
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01a8: Expected I4, but got F8
		//IL_01b5: Expected I4, but got Obj
		//IL_01b5: Expected Obj, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected Obj, but got Unknown
		//IL_01d7: Expected Obj, but got Unknown
		//IL_0081: Expected Obj, but got VT
		//IL_00a1->IL0069: Incompatible stack heights: 2 vs 1
		//IL_01fa->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01fa->IL0026: Incompatible stack types: I4 vs Ref
		//IL_0086->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b5->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0205->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0205->IL0026: Incompatible stack types: I4 vs Ref
		//IL_0091->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c0->IL0026: Incompatible stack heights: 3 vs 2
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
			case 3:
				return;
			default:
				obj = P_0.ToString();
				obj2 = 4;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field == 0)
				{
					obj2 = 1;
				}
				break;
			case 1:
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType0<>.ReflectJoinedTree())._003Cuser_id_003Ei__Field == 0)
				{
					return;
				}
				_ = 0;
				if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field == 0)
				{
					_ = 0;
				}
				break;
			case 4:
			{
				var anon = new
				{
					name = (_003Cname_003Ej__TPar)/*Error near IL_00c6: Stack underflow*/,
					uuid = (_003Cuuid_003Ej__TPar)Unsafe.AsPointer(ref reference),
					user_id = (_003Cuser_id_003Ej__TPar)this
				};
				_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.StoreConverter = (double)(float)((_003C_003Ef__AnonymousType1<, , >)(object)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance).ToString();
				_003F val = /*Error near IL_00de: Stack underflow*/;
				_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.GuideMap = (double)(float)((_003C_003Ef__AnonymousType2<, , , >)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_hasTimeout).payload;
				((EntitySocks5)val).Address__BackingField = (double)(float)(((_003C_003Ef__AnonymousType2<, , , >)val).Equals(((EntitySocks5Account)((_003C_003Ef__AnonymousType2<, , , >)(object)this).user_id).Password__BackingField) ? 1 : 0);
				((EntitySocks5)/*Error near IL_010e: Stack underflow*/).Account__BackingField = ((_003C_003Ef__AnonymousType2<, , , >)obj).ToString();
				_003F val2 = /*Error near IL_011b: Stack underflow*/;
				((EntityLaunchGameProxy)obj).GameType__BackingField = (EnumGameType)(double)((float)((EntityLaunchGameProxy)_003C_003Ef__AnonymousType2<, , , >.DisableDecryptor()).Session__BackingField + ((_003C_003Ef__AnonymousType3<, >)obj).sid);
				((EntityLaunchGameProxy)val2).ServerAddress__BackingField = (double)((float)((EntityLaunchGameProxy)((_003C_003Ef__AnonymousType3<, >)val2).Equals(obj)).ModHashList__BackingField + ((_003C_003Ef__AnonymousType3<, >)obj).ToString());
				_003F val3 = /*Error near IL_0153: Stack underflow*/;
				object obj3 = obj;
				float num = (float)((EntityLaunchGameProxy)_003C_003Ef__AnonymousType3<, >.DecorateIntegratedProgram()).Socks5__BackingField;
				object obj4 = obj;
				_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0._002Ecctor();
				((EntityLaunchGameProxy)obj3).IsGame__BackingField = (nint)(double)(num + obj4);
				GameProxy.Logger__BackingField = (double)((GameProxy)(object)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.DecorateConfigurableDecider())._003Cargs_003EP;
				((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)val3).Scan((ReadOnlySpan<char>)obj);
				GameProxy.OnlineClients = (ConcurrentDictionary<int, Mass.Game.Proxy.Minecraft.Minecraft>)(double)((GameProxy)val3).ConnectionChanged;
				_003F val4 = /*Error near IL_0195: Stack underflow*/;
				((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)obj)._002Ector();
				((GameProxy)/*Error near IL_01a8: Stack underflow*/).GameType__BackingField = (EnumGameType)(double)((GameProxy)val4).Session__BackingField;
				_003F val5 = /*Error near IL_01a8: Stack underflow*/;
				object obj5 = obj;
				_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities._002Ecctor();
				((GameProxy)val5).GameVersion__BackingField = (EnumGameVersion)(int)obj5;
				_003F val6 = /*Error near IL_01b5: Stack underflow*/;
				((GameProxy)(object)this).TransferServerAddress__BackingField = ((EntitySocks5Account)((GameProxy)(object)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.PatchWatcher()).ServerAddress__BackingField).EqualityContract;
				((EntitySocks5Account)val6).Username = (string)(object)this;
				((EntitySocks5Account)/*Error near IL_01dc: Stack underflow*/).Password = (string)((GameProxy)val6).Section__BackingField;
				((GameProxy)/*Error near IL_01e1: Stack underflow*/).IsGame = (byte)/*Error near IL_01e1: Stack underflow*/ != 0;
				bool flag = ((EntitySocks5Account)/*Error near IL_01e6: Stack underflow*/).PrintMembers((StringBuilder)/*Error near IL_01e6: Stack underflow*/);
				obj2 = 2;
				reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
				if (((GameProxy)GameProxy.WorkerGroup__BackingField).AcceptorGroup__BackingField == null)
				{
					obj2 = 2;
					reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
				}
				break;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 尀(EventPacket<ServerboundUseItemOnPacket> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778476, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object 崀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778479, new IntPtr(2737367936924L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object 帀()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object 开()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778478, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 怀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0069: Expected Obj, but got Ref
		//IL_006f: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got VT
		//IL_00ae: Expected Obj, but got VT
		//IL_0083: Expected Obj, but got VT
		//IL_0074->IL0093: Incompatible stack heights: 0 vs 1
		//IL_00b3->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0088->IL0026: Incompatible stack heights: 1 vs 2
		//IL_00be->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0093->IL0026: Incompatible stack heights: 1 vs 2
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
			case 2:
				if (string.Format((IFormatProvider?)/*Error near IL_006f: Stack underflow*/, ((object)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).ToString(), (object?[])3) == null)
				{
					_ = 0;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field == 0)
					{
						_ = 1;
					}
					break;
				}
				return;
			case 3:
				return;
			case 1:
				_ = ((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType2<, , , >)(object)this)._003Cuser_id_003Ei__Field).uuid;
				_ = 0;
				if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType3<, >._003Centry_003Ei__Field)._003Csid_003Ei__Field != 0)
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
	internal unsafe void 愀(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003e: Expected VT, but got Obj
		//IL_003e: Expected Obj, but got Ref
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
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 戀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778473, new IntPtr(2737367946284L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 挀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778472, new IntPtr(2737367941084L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 搀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00d9: Expected VT, but got Obj
		//IL_00d9: Expected VT, but got Ref
		//IL_0050: Expected VT, but got Obj
		//IL_0050: Expected Obj, but got Ref
		//IL_00de->IL00bd: Incompatible stack heights: 0 vs 1
		//IL_006a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006a->IL0026: Incompatible stack types: I4 vs Ref
		//IL_00e8->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0075->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0075->IL0026: Incompatible stack types: I4 vs Ref
		//IL_00d3->IL0026: Incompatible stack types: I4 vs Obj
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
			default:
				return;
			case 1:
				return;
			case 0:
				return;
			case 2:
			{
				((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref reference))._002Ector((_003Caction_003Ej__TPar)this);
				bool flag = ((_003C_003Ef__AnonymousType0<>)/*Error near IL_0056: Stack underflow*/).Equals(P_0);
				obj2 = 1;
				reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
				{
					obj2 = 1;
					reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
				}
				break;
			}
			case 3:
				return;
			case 4:
				if ((int)((_003C_003Ef__AnonymousType1<, , >)(object)this).user_id == 0)
				{
					return;
				}
				obj2 = 2;
				break;
			case 5:
				if (((EqualityComparer<_00212>)/*Error near IL_00d9: Stack underflow*/).Equals((_00212?)Unsafe.AsPointer(ref reference), (_00212?)P_0))
				{
					return;
				}
				_ = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 栀(EventPacket<ClientboundJoinGamePacket> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0057: Expected I4, but got Obj
		//IL_0062: Expected VT, but got Obj
		//IL_006e: Expected Obj, but got VT
		//IL_0073: Expected Obj, but got I4
		//IL_01d1: Expected Obj, but got Ref
		//IL_01dc: Expected VT, but got Obj
		//IL_01dc: Expected Obj, but got I4
		//IL_01e1: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got I4
		//IL_00c2: Expected VT, but got Obj
		//IL_00ca: Expected I4, but got Obj
		//IL_00d5: Expected Obj, but got I4
		//IL_01c6->IL0026: Incompatible stack heights: 5 vs 2
		//IL_01f0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01f0->IL0026: Incompatible stack types: I4 vs Ref
		//IL_021c->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0182->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01a6->IL0026: Incompatible stack heights: 3 vs 2
		//IL_018d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0207->IL0026: Incompatible stack heights: 5 vs 2
		//IL_0128->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0133->IL0026: Incompatible stack types: I4 vs Obj
		ref readonly _003Caction_003Ej__TPar reference = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 10;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 2:
				_ = new
				{
					action = (_003Caction_003Ej__TPar)this
				};
				((_003C_003Ef__AnonymousType0<>)((_003C_003Ef__AnonymousType0<>)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuser_id_003Ei__Field).GetHashCode()).ToString();
				/*Error near IL_0074: Member reference must be method, but was: Field*/;
			case 10:
				((_003C_003Ef__AnonymousType1<, , >)(object)this).GetHashCode();
				obj = 1;
				obj = ((IEnumerable<byte>)new EqualityComparer<_00211>((_00211)obj)).Take((int)obj).ToArray();
				obj = 0;
				_ = ref obj;
				/*Error near IL_00d9: Member reference must be method, but was: Field*/;
			case 0:
				return;
			case 9:
				if (EntitySocks5Account.AttachElement != null)
				{
					obj2 = 8;
					if (((EntitySocks5)EntitySocks5.Address__BackingField).Port__BackingField != 0)
					{
						obj2 = 8;
					}
				}
				else
				{
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.DecorateCustomNode();
					_ = null;
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities._002Ecctor();
					_ = 6;
				}
				break;
			case 7:
				_ = ((EntitySocks5)(object)this).Account__BackingField;
				_003C_003Ef__AnonymousType2<, , , >.DisableDecryptor();
				/*Error near IL_013e: Member reference must be method, but was: Field*/;
			case 5:
				((EntityLaunchGameProxy)(object)this).GameVersion__BackingField = (EnumGameVersion)1u;
				obj2 = 0;
				if (((EntityLaunchGameProxy)EntityLaunchGameProxy.ModHashList__BackingField).Name__BackingField == null)
				{
					obj2 = 0;
				}
				break;
			case 6:
				_003C_003Ef__AnonymousType3<, >.LoadCache();
				((RegexRunnerFactory)_003C_003Ef__AnonymousType3<, >.DecorateIntegratedProgram())._002Ector();
				_ = 2;
				break;
			case 1:
				_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0._002Ecctor();
				_ = ((EntityLaunchGameProxy)(object)this).IsGame__BackingField;
				((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory)(object)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.DecorateConfigurableDecider()).CreateInstance();
				_ = 5;
				break;
			case 3:
			{
				((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory)(object)this)._002Ector();
				((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)MemoryExtensions.IndexOfAnyExcept<T>((ReadOnlySpan<T>)/*Error near IL_01d1: Stack underflow*/, (SearchValues<T>)Unsafe.AsPointer(ref reference))).TryMatchAtCurrentPosition((ReadOnlySpan<char>)((GameProxy)(object)this).ConnectionChanged))._002Ector();
				bool flag = _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.VerifyVerifier();
				obj2 = 4;
				reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
				break;
			}
			case 8:
				return;
			case 4:
				_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.InstantiateVisitor();
				_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.PatchWatcher();
				_ = 7;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 椀(EventPacket<ClientboundJoinGamePacket> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778475, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte 樀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778474, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte 欀()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte 氀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778469, new IntPtr(2737367946284L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 洀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 10835, 1790778468, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778468, new IntPtr(2737367946284L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object 渀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778471, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe Task<bool> 漀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 10837, 1790778470, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778470, new IntPtr(2737367934844L), 15);
		}
		return (Task<bool>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe Task<bool> 瀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778465, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
		return (Task<bool>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 爀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0046: Expected VT, but got Obj
		//IL_0046: Expected Obj, but got Ref
		//IL_0057: Expected Obj, but got VT
		//IL_00a0: Expected Obj, but got VT
		//IL_00af: Expected Obj, but got VT
		//IL_00f3: Expected Obj, but got Ref
		//IL_0100: Expected VT, but got I
		//IL_005c->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0067->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0152->IL01a4: Incompatible stack heights: 2 vs 1
		//IL_01f6->IL0067: Incompatible stack heights: 0 vs 1
		//IL_0111->IL00c3: Incompatible stack heights: 6 vs 2
		//IL_0166->IL00c3: Incompatible stack heights: 3 vs 2
		//IL_0171->IL00c3: Incompatible stack heights: 3 vs 2
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
				obj = (object)/*Error near IL_0048: Stack underflow*/;
				_ = 0;
				if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
				{
					_ = 0;
				}
				break;
			case 3:
				return;
			default:
				((_003C_003Ef__AnonymousType0<>)obj).ToString();
				/*Error near IL_006f: Member reference must be method, but was: Field*/;
			case 2:
			{
				obj = ((_003C_003Ef__AnonymousType1<, , >)obj).uuid;
				int num = 1;
				if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType3<, >._003Centry_003Ei__Field)._003Csid_003Ei__Field != 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					case 4:
						return;
					case 5:
						return;
					case 6:
						return;
					case 7:
						((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals(this);
						new EqualityComparer<_00211>((_00211)__ldvirtftn(_003C_003Ef__AnonymousType1<, , >.GetHashCode));
						_003C_003Ef__AnonymousType1<, , >.ReflectScalableStack();
						_ = 6;
						break;
					case 1:
						_003C_003Ef__AnonymousType1<, , >.ReflectModularWriter();
						/*Error near IL_0118: Member reference must be method, but was: Field*/;
					default:
						_ = ((_003C_003Ef__AnonymousType2<, , , >)obj).user_id;
						if (EqualityComparer<_00213>.Default == null)
						{
							_ = 3;
							if (((EntitySocks5)EntitySocks5Account.AttachElement).Address__BackingField == null)
							{
								_ = 4;
							}
							break;
						}
						goto case 3;
					case 3:
						/*Error near IL_01a6: Member reference must be method, but was: Field*/;
					case 2:
						_ = ((_003C_003Ef__AnonymousType3<, >)obj).entry;
						new Regex();
						/*Error near IL_01cd: Member reference must be method, but was: Field*/;
					}
				}
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 猀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778464, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 琀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004f: Expected I4, but got Obj
		//IL_005a: Expected VT, but got Obj
		//IL_005f: Expected Obj, but got Ref
		//IL_00ce: Expected Obj, but got VT
		//IL_0086: Expected VT, but got Obj
		//IL_0102: Expected VT, but got Ref
		//IL_0104: Expected Obj, but got I4
		//IL_0073->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0073->IL0026: Incompatible stack types: I4 vs Ref
		//IL_00d3->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0090->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00fc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007e->IL0026: Incompatible stack types: I4 vs Ref
		//IL_0118->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0156->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00de->IL0026: Incompatible stack heights: 3 vs 2
		//IL_0123->IL0026: Incompatible stack heights: 1 vs 2
		//IL_0161->IL0026: Incompatible stack types: I4 vs Obj
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
			case 3:
			{
				bool flag = ((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref reference)).Equals(new
				{
					action = (_003Caction_003Ej__TPar)this
				});
				obj2 = 6;
				reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
				{
					obj2 = 6;
					reference = ref *(flag ? ((_003Caction_003Ej__TPar*)1) : ((_003Caction_003Ej__TPar*)null));
				}
				break;
			}
			case 7:
				((_003C_003Ef__AnonymousType2<, , , >)(object)this)._003Cpayload_003Ei__Field = (_003Cpayload_003Ej__TPar)obj;
				obj2 = 3;
				break;
			case 6:
				_ = ((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic).user_id;
				_ = 1;
				if (_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument == null)
				{
					_ = 0;
				}
				break;
			case 2:
				if ((long)(obj - (object)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance) > 5000L)
				{
					obj2 = 7;
					break;
				}
				goto case 6;
			case 8:
				return;
			case 4:
				obj = ((EqualityComparer<_00211>)/*Error near IL_0102: Stack underflow*/).GetHashCode((_00211)Unsafe.AsPointer(ref reference));
				_ = 0;
				if ((int)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_defaultTimeout != 0)
				{
					_ = 0;
				}
				break;
			default:
				_ = ref obj;
				/*Error near IL_0125: Member reference must be method, but was: Field*/;
			case 1:
				return;
			case 5:
				if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_ascii_68FF03FEFFFF87FEFFFF07 == null)
				{
					return;
				}
				obj2 = 4;
				if (((EntitySocks5Account)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.GuideMap).Username__BackingField == null)
				{
					obj2 = 3;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 甀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0062: Expected Obj, but got VT
		//IL_0067->IL0026: Incompatible stack heights: 6 vs 2
		//IL_008e->IL0026: Incompatible stack heights: 4 vs 2
		//IL_0072->IL0026: Incompatible stack heights: 6 vs 2
		//IL_0099->IL0026: Incompatible stack heights: 4 vs 2
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
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
			case 1:
				_ = ((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
				__ldftn(_003C_003Ef__AnonymousType0<>.Equals);
				((_003C_003Ef__AnonymousType0<>)(object)new object()).ToString();
				_ = 0;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Cpayload_003Ei__Field)._003Ccontext_003Ei__Field != 0)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			case 2:
				_ = ((_003C_003Ef__AnonymousType1<, , >)P_0).name;
				_ = 1;
				if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field != 0)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte 瘀()
	{
		//IL_001b: Expected I4, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (byte)(int)((_003C_003Ef__AnonymousType1<, , >)(object)this)._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte 眀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778467, new IntPtr(2737367941084L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}
}
