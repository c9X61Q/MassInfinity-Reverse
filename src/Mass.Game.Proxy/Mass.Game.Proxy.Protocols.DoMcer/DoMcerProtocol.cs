using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using DotNetty.Buffers;
using DotNetty.Transport.Channels;
using Mass.Application.Event;
using Mass.Application.Models;
using Mass.Common.Extensions;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Domain.Value;
using Mass.Game.Proxy.Minecraft.Events.Play;
using Mass.Game.Proxy.Minecraft.Protocol;
using Mass.Game.Proxy.Network;
using Mass.Game.Proxy.Network.Item;
using Mass.Game.Proxy.Network.Nbt;
using Mass.Game.Proxy.Protocols.Heypixel;
using Mass.Game.Proxy.Protocols.Hyt;
using Mass.Game.Proxy.Protocols.Hyt.VexView;
using Mass.Game.Proxy.Protocols.OhMyGod;
using Mass.Game.Proxy.Protocols.Orange;
using Serilog;

namespace Mass.Game.Proxy.Protocols.DoMcer;

public class DoMcerProtocol : Protocol
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSendCustomSkin_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DoMcerProtocol _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object DecorateMonoEmitter;

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
		internal static bool InsertParser()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object InterruptState()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_F700()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778996, new IntPtr(2737368328748L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_F800()
		{
			//IL_001a: Expected Obj, but got VT
			_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00豈()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778999, new IntPtr(2737368330828L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00切()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778998, new IntPtr(2737368316268L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00ﬀ()
		{
			//IL_001a: Invalid comparison between VT and Obj
			_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00ﰀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778993, new IntPtr(2737368322508L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00Ȁ()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0088: Expected Obj, but got Ref
			//IL_0051: Expected VT, but got I4
			//IL_0051: Expected Obj, but got Ref
			//IL_0060: Expected Obj, but got VT
			//IL_04a4: Expected Obj, but got Ref
			//IL_0076: Expected Obj, but got Ref
			//IL_0078: Expected Obj, but got VT
			//IL_00d3: Expected Obj, but got VT
			//IL_01a1: Expected Obj, but got Ref
			//IL_01b2: Expected Obj, but got VT
			//IL_00fa: Expected Obj, but got VT
			//IL_0162: Expected Obj, but got Ref
			//IL_0173: Expected Obj, but got I4
			//IL_022a: Expected Obj, but got Ref
			//IL_023f: Expected Obj, but got I4
			//IL_036d: Expected Obj, but got Ref
			//IL_02b4: Expected Obj, but got Ref
			//IL_028d: Expected Obj, but got Ref
			//IL_029c: Expected Obj, but got I
			//IL_02ed: Expected VT, but got Obj
			//IL_02ed: Expected Obj, but got Ref
			//IL_02f2: Expected VT, but got I4
			//IL_031d: Expected Obj, but got I4
			//IL_0322: Expected Obj, but got I4
			//IL_0322: Expected Obj, but got Ref
			//IL_0273: Expected Obj, but got Ref
			//IL_0331: Expected Obj, but got Ref
			//IL_0336: Expected VT, but got Obj
			//IL_0347: Expected I4, but got Obj
			//IL_0358: Expected Obj, but got I
			//IL_018c: Expected Obj, but got I4
			//IL_0191: Expected Obj, but got I4
			//IL_0191: Expected Obj, but got Ref
			//IL_0281: Expected Obj, but got I4
			//IL_0157: Expected I4, but got Obj
			//IL_0065->IL0026: Incompatible stack types: I4 vs Obj
			//IL_04ba->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0082->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
			//IL_04c5->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0416->IL0049: Incompatible stack heights: 0 vs 1
			//IL_01b7->IL010e: Incompatible stack types: I4 vs Obj
			//IL_00ff->IL010e: Incompatible stack types: I4 vs Obj
			//IL_01c2->IL010e: Incompatible stack types: I4 vs Obj
			//IL_010a->IL010e: Incompatible stack types: I4 vs Obj
			//IL_0244->IL010e: Incompatible stack types: I4 vs Obj
			//IL_0381->IL010e: Incompatible stack heights: 3 vs 2
			//IL_02c8->IL010e: Incompatible stack types: I4 vs Obj
			//IL_02a1->IL010e: Incompatible stack types: I4 vs Obj
			//IL_030d->IL010e: Incompatible stack types: I4 vs Obj
			//IL_030d->IL010e: Incompatible stack types: I4 vs Ref
			//IL_032c->IL010e: Incompatible stack types: I4 vs Obj
			//IL_0278->IL0318: Incompatible stack heights: 0 vs 1
			//IL_035d->IL010e: Incompatible stack heights: 1 vs 2
			//IL_017d->IL0048: Incompatible stack heights: 0 vs 1
			//IL_019b->IL010e: Incompatible stack types: I4 vs Obj
			//IL_0386->IL0411: Incompatible stack heights: 0 vs 1
			//IL_026c->IL010e: Incompatible stack heights: 6 vs 2
			//IL_024f->IL010e: Incompatible stack types: I4 vs Obj
			//IL_02d3->IL010e: Incompatible stack types: I4 vs Obj
			//IL_02ac->IL010e: Incompatible stack types: I4 vs Obj
			//IL_0318->IL010e: Incompatible stack types: I4 vs Obj
			//IL_0318->IL010e: Incompatible stack types: I4 vs Ref
			//IL_0286->IL010a: Incompatible stack heights: 0 vs 1
			//IL_0368->IL010e: Incompatible stack heights: 1 vs 2
			ref readonly _003Caction_003Ej__TPar reference = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			object awaiter = 5;
			object obj = awaiter;
			while (true)
			{
				switch ((int)obj)
				{
				case 3:
					return;
				case 2:
					((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref this))._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)(-2);
					obj = 1;
					if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
					{
						obj = 1;
					}
					break;
				case 5:
					awaiter = ((_003C_003Ef__AnonymousType2<, , , >)Unsafe.AsPointer(ref this))._003Curl_003Ei__Field;
					obj = 4;
					break;
				case 1:
					_ = ref ((_003C_003Ef__AnonymousType2<, , , >)Unsafe.AsPointer(ref this))._003Cpayload_003Ei__Field;
					/*Error near IL_0088: Member reference must be method, but was: Field*/;
				default:
				{
					int num = 2;
					while (true)
					{
						object obj2;
						switch (num)
						{
						case 1:
							break;
						case 2:
							num = 0;
							if (_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic == null)
							{
								num = 0;
							}
							continue;
						default:
							{
								if (awaiter != null)
								{
									obj2 = 2;
									if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType3<, >._003Centry_003Ei__Field)._003Csid_003Ei__Field != 0)
									{
										obj2 = 1;
									}
									goto IL_010e;
								}
								goto IL_019b;
							}
							IL_010e:
							while (true)
							{
								switch ((int)obj2)
								{
								case 12:
									return;
								case 15:
									break;
								default:
									Unsafe.As<object, AsyncTaskMethodBuilder>(ref _003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<IChannel>*)(&awaiter), ref Unsafe.As<_003CSendCustomSkin_003Ed__5, GameProxy._003CListenAsync_003Ed__69>(ref this));
									awaiter = 12;
									goto IL_010a;
								case 13:
									awaiter = -1;
									_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectLocalTemplate = -1;
									obj2 = 7;
									continue;
								case 6:
									goto end_IL_010e;
								case 4:
									/*Error near IL_01c2: Member reference must be method, but was: Field*/;
								case 14:
									((_003C_003Ef__AnonymousType2<, , , >)awaiter).ToString();
									/*Error near IL_01fe: Member reference must be method, but was: Field*/;
								case 1:
									((EntityLaunchGameProxy)Unsafe.AsPointer(ref this)).GameId__BackingField = null;
									obj2 = 7;
									if (((EntityLaunchGameProxy)EntityLaunchGameProxy.GameVersion__BackingField).ModHashList__BackingField == null)
									{
										obj2 = 13;
									}
									continue;
								case 16:
									((_003C_003Ef__AnonymousType3<, >)awaiter).ToString();
									_003C_003Ef__AnonymousType3<, >.LoadCache();
									_003C_003Ef__AnonymousType3<, >.DecorateIntegratedProgram();
									_ = 11;
									continue;
								case 10:
									((RegexRunnerFactory)(&awaiter))._002Ector();
									if (Unsafe.AsPointer(ref reference) != null)
									{
										awaiter = 3;
										goto IL_010a;
									}
									goto case 9;
								case 3:
								case 7:
									((RegexRunner)(&awaiter)).CheckTimeout();
									obj2 = 5;
									if ((object)EntityLaunchGameProxy.ReflectAlphabeticProcessor != null)
									{
										obj2 = 15;
									}
									continue;
								case 5:
									((GameProxy)Unsafe.AsPointer(ref this))._003Cargs_003EP = awaiter;
									obj2 = 0;
									if (((GameProxy)GameProxy.Logger__BackingField)._pinger == null)
									{
										obj2 = 0;
									}
									continue;
								case 8:
								{
									byte b = ((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)/*Error near IL_02f2: Stack underflow*/).TryMatchAtCurrentPosition((ReadOnlySpan<char>)((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)Unsafe.AsPointer(ref reference)).TryFindNextPossibleStartingPosition((ReadOnlySpan<char>)awaiter));
									((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)awaiter)._002Ector();
									obj2 = 12;
									reference = ref *(_003Caction_003Ej__TPar*)b;
									if (((GameProxy)GameProxy.Session__BackingField).GameType__BackingField != 0)
									{
										obj2 = 14;
										reference = ref *(_003Caction_003Ej__TPar*)b;
									}
									continue;
								}
								case 9:
									awaiter = 0;
									((GameProxy)Unsafe.AsPointer(ref this)).GameId__BackingField = 0;
									obj2 = 5;
									continue;
								case 11:
									awaiter = ((StringBuilder)/*Error near IL_0347: Stack underflow*/).Append((char)(int)((StringBuilder)(object)Type.GetTypeFromHandle((RuntimeTypeHandle)AppContext.GetData((string)Unsafe.AsPointer(ref reference)))).Append((string?)((GameProxy)awaiter).ServerAddress__BackingField));
									_ = 1;
									if (((GameProxy)GameProxy.TransferServerPort__BackingField).Section__BackingField == null)
									{
										_ = 8;
									}
									continue;
								case 2:
									{
										((EntitySocks5Account)/*Error near IL_036d: Stack underflow*/).Password = (string)Unsafe.AsPointer(ref reference);
										((EntitySocks5Account)/*Error near IL_0372: Stack underflow*/).ToString();
										_ = EqualityComparer<string>.Default;
										_ = 4;
										continue;
									}
									IL_010a:
									obj2 = awaiter;
									continue;
								}
								goto end_IL_00ad;
								continue;
								end_IL_010e:
								break;
							}
							goto IL_019b;
							IL_019b:
							awaiter = _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.StoreConverter;
							obj2 = 0;
							if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_hasTimeout)
							{
								obj2 = 1;
							}
							goto IL_010e;
							end_IL_00ad:
							break;
						}
						break;
					}
					goto case 2;
				}
				case 4:
					awaiter = ((CpsDetector)Unsafe.AsPointer(ref this))._lock;
					obj = 0;
					if (((CpsDetector)(object)CpsDetector._leftClicks)._rightClicks == null)
					{
						obj = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_0300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778992, new IntPtr(2737368308988L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00Ѐ(object P_0)
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00Ԁ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778995, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSendImage_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DoMcerProtocol _003C_003E4__this;

		private object _003Cclient_003E5__2;

		private object _003Cform_003E5__3;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		internal static object DecorateScopeListener;

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
		internal static bool ReflectStaticTracker()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateDynamicFinalizer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778994, new IntPtr(2737368321468L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FFFD()
		{
			//IL_001a: Expected Obj, but got VT
			_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_E000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778957, new IntPtr(2737368318348L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_E100()
		{
			//IL_001a: Invalid comparison between VT and Obj
			_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_E200()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778956, new IntPtr(2737368306908L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_F300()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_004b: Expected I4, but got Obj
			//IL_0068: Expected Obj, but got Ref
			//IL_006d: Expected Obj, but got Ref
			//IL_007c: Expected Obj, but got VT
			//IL_00ce: Expected Obj, but got Ref
			//IL_00d0: Expected Obj, but got VT
			//IL_0092: Expected Obj, but got Ref
			//IL_0094: Expected Obj, but got VT
			//IL_009d: Expected Obj, but got I4
			//IL_0058: Expected VT, but got I4
			//IL_0058: Expected Obj, but got Ref
			//IL_00a9: Expected VT, but got Obj
			//IL_00a9: Expected Obj, but got Ref
			//IL_09d6: Expected I, but got Obj
			//IL_09d6: Expected Obj, but got Ref
			//IL_023e: Expected Obj, but got Ref
			//IL_0243: Expected Obj, but got I
			//IL_02ee: Expected I4, but got Obj
			//IL_02ee: Expected Obj, but got Ref
			//IL_0205: Expected Obj, but got Ref
			//IL_020f: Expected VT, but got I4
			//IL_020f: Expected VT, but got Ref
			//IL_01d6: Expected Obj, but got Ref
			//IL_01db: Expected VT, but got Obj
			//IL_01db: Expected Obj, but got I4
			//IL_01e0: Expected Obj, but got I4
			//IL_0277: Expected Obj, but got Ref
			//IL_027c: Expected I4, but got Obj
			//IL_0286: Expected Obj, but got I4
			//IL_029a: Expected Obj, but got I4
			//IL_02b0: Expected Obj, but got Ref
			//IL_02b5: Expected VT, but got I4
			//IL_02ba: Expected Obj, but got I4
			//IL_02ba: Expected Obj, but got Ref
			//IL_02c4: Expected I4, but got Obj
			//IL_02d3: Expected Obj, but got I
			//IL_030f: Expected Obj, but got I4
			//IL_06b0: Expected Obj, but got Ref
			//IL_04b6: Expected Obj, but got Ref
			//IL_04be: Expected Obj, but got Ref
			//IL_04be: Expected Obj, but got Ref
			//IL_04be: Expected Obj, but got Ref
			//IL_0431: Expected Obj, but got I4
			//IL_0431: Expected Obj, but got Ref
			//IL_060f: Expected Obj, but got Ref
			//IL_0611: Unknown result type (might be due to invalid IL or missing references)
			//IL_061b: Expected Obj, but got Unknown
			//IL_061d: Expected native int or pointer, but got Obj
			//IL_0627: Expected Obj, but got I4
			//IL_0627: Expected Obj, but got I4
			//IL_062c: Expected VT, but got I4
			//IL_03b0: Expected Obj, but got Ref
			//IL_03b0: Expected Obj, but got I4
			//IL_03b0: Expected Obj, but got Ref
			//IL_066d: Expected Obj, but got I4
			//IL_0672: Expected Obj, but got I4
			//IL_0672: Expected Obj, but got Ref
			//IL_05b6: Expected Obj, but got Ref
			//IL_05bd: Expected I4, but got Obj
			//IL_06f4: Expected Obj, but got Ref
			//IL_04f7: Expected Obj, but got Ref
			//IL_056d: Expected Obj, but got I4
			//IL_0656: Expected Obj, but got Ref
			//IL_065e: Expected Obj, but got Ref
			//IL_065e: Expected Obj, but got Ref
			//IL_0744: Expected Obj, but got Ref
			//IL_03c5: Expected Obj, but got Ref
			//IL_03da: Expected Obj, but got I
			//IL_0459: Expected Obj, but got I4
			//IL_0463: Expected I4, but got Obj
			//IL_0463: Expected Obj, but got I4
			//IL_04d0: Expected Obj, but got Ref
			//IL_071e: Expected Obj, but got I4
			//IL_071e: Expected Obj, but got Ref
			//IL_03f0: Expected Obj, but got Ref
			//IL_03f5: Expected Obj, but got Ref
			//IL_040c: Expected I4, but got Obj
			//IL_0411: Expected Obj, but got I4
			//IL_0413: Expected Obj, but got I4
			//IL_06dd: Expected Obj, but got I4
			//IL_0681: Expected Obj, but got I4
			//IL_0686: Expected Obj, but got I4
			//IL_0686: Expected Obj, but got Ref
			//IL_068f: Expected Obj, but got I4
			//IL_0544: Expected Obj, but got Ref
			//IL_0544: Expected Obj, but got I4
			//IL_0553: Expected I4, but got Obj
			//IL_0553: Expected I4, but got Obj
			//IL_0563: Expected Obj, but got I4
			//IL_0479: Expected Obj, but got I4
			//IL_047e: Expected F8, but got I4
			//IL_047e: Expected Obj, but got Ref
			//IL_072f: Expected Obj, but got I4
			//IL_0734: Expected Obj, but got I4
			//IL_0734: Expected Obj, but got Ref
			//IL_05e9: Expected Obj, but got I4
			//IL_05ee: Expected Obj, but got Ref
			//IL_03a4: Expected I4, but got Obj
			//IL_0081->IL0026: Incompatible stack heights: 3 vs 2
			//IL_00da->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0062->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00bd->IL0026: Incompatible stack types: I4 vs Obj
			//IL_09e0->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008c->IL0026: Incompatible stack heights: 3 vs 2
			//IL_00c8->IL0026: Incompatible stack types: I4 vs Obj
			//IL_017a->IL017e: Incompatible stack heights: 2 vs 3
			//IL_01a7->IL0238: Incompatible stack heights: 2 vs 1
			//IL_029f->IL017e: Incompatible stack heights: 2 vs 3
			//IL_02d8->IL017e: Incompatible stack heights: 2 vs 3
			//IL_01ac->IL0238: Incompatible stack heights: 2 vs 1
			//IL_0314->IL0323: Incompatible stack types: I4 vs Obj
			//IL_02aa->IL017e: Incompatible stack heights: 2 vs 3
			//IL_02e3->IL017e: Incompatible stack heights: 2 vs 3
			//IL_06c6->IL0323: Incompatible stack types: I4 vs Obj
			//IL_0532->IL0323: Incompatible stack types: I4 vs Obj
			//IL_031f->IL0323: Incompatible stack types: I4 vs Obj
			//IL_06d1->IL0323: Incompatible stack types: I4 vs Obj
			//IL_053d->IL0323: Incompatible stack types: I4 vs Obj
			//IL_04c8->IL0323: Incompatible stack heights: 4 vs 3
			//IL_0447->IL0323: Incompatible stack heights: 1 vs 3
			//IL_0645->IL0323: Incompatible stack heights: 2 vs 3
			//IL_03b5->IL0668: Incompatible stack heights: 0 vs 2
			//IL_067c->IL0323: Incompatible stack types: I4 vs Obj
			//IL_05e2->IL0323: Incompatible stack heights: 4 vs 3
			//IL_070e->IL0323: Incompatible stack types: I4 vs Obj
			//IL_050b->IL0323: Incompatible stack types: I4 vs Obj
			//IL_0668->IL0323: Incompatible stack heights: 5 vs 3
			//IL_075a->IL0323: Incompatible stack types: I4 vs Obj
			//IL_03df->IL0323: Incompatible stack types: I4 vs Obj
			//IL_079d->IL0050: Incompatible stack heights: 0 vs 1
			//IL_0474->IL0323: Incompatible stack types: I4 vs Obj
			//IL_04e4->IL0323: Incompatible stack types: I4 vs Obj
			//IL_072a->IL0323: Incompatible stack heights: 1 vs 3
			//IL_041d->IL0323: Incompatible stack heights: 1 vs 3
			//IL_05ff->IL00da: Incompatible stack heights: 0 vs 1
			//IL_06ee->IL0323: Incompatible stack heights: 5 vs 3
			//IL_0568->IL031f: Incompatible stack heights: 0 vs 2
			//IL_0422->IL00da: Incompatible stack heights: 0 vs 1
			//IL_04a5->IL0323: Incompatible stack heights: 4 vs 3
			//IL_0488->IL0323: Incompatible stack types: I4 vs Obj
			//IL_073e->IL0323: Incompatible stack types: I4 vs Obj
			//IL_05fa->IL0323: Incompatible stack heights: 1 vs 3
			//IL_0452->IL0323: Incompatible stack heights: 1 vs 3
			//IL_0650->IL0323: Incompatible stack heights: 2 vs 3
			//IL_03bf->IL0323: Incompatible stack heights: 1 vs 3
			//IL_0719->IL0323: Incompatible stack types: I4 vs Obj
			//IL_0516->IL0323: Incompatible stack types: I4 vs Obj
			//IL_0765->IL0323: Incompatible stack types: I4 vs Obj
			//IL_03ea->IL0323: Incompatible stack types: I4 vs Obj
			//IL_04ef->IL0323: Incompatible stack types: I4 vs Obj
			//IL_04b0->IL0323: Incompatible stack heights: 4 vs 3
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			object obj = 3;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					int num;
					object obj3;
					int num2;
					int num3;
					switch ((int)obj2)
					{
					default:
						return;
					case 4:
						((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref this))._003Cuuid_003Ei__Field = (_003Cuuid_003Ej__TPar)(-2);
						obj2 = 6;
						continue;
					case 1:
						((object)Unsafe.AsPointer(ref ((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref this))._003Cuser_id_003Ei__Field)).ToString();
						_ = 0;
						if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field == 0)
						{
							_ = 0;
						}
						continue;
					case 3:
						break;
					case 5:
						((_003C_003Ef__AnonymousType2<, , , >)Unsafe.AsPointer(ref this))._003Cuser_id_003Ei__Field = (_003Cuser_id_003Ej__TPar)null;
						obj2 = 1;
						if ((int)((_003C_003Ef__AnonymousType3<, >)_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic)._003Centry_003Ei__Field == 0)
						{
							obj2 = 0;
						}
						continue;
					case 2:
						obj = ((_003C_003Ef__AnonymousType3<, >)Unsafe.AsPointer(ref this))._003Csid_003Ei__Field;
						obj2 = 7;
						continue;
					case 0:
						return;
					case 7:
						if ((nuint)(nint)obj > (nuint)1u)
						{
							num = 1;
							if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.Instance == null)
							{
								num = 1;
							}
							goto IL_0107;
						}
						goto IL_011d;
					case 6:
						{
							((HeypixelRedirectProtocol)Unsafe.AsPointer(ref this)).Joined__BackingField = unchecked((nint)null);
							obj2 = 5;
							continue;
						}
						IL_0516:
						if ((nint)obj != 1)
						{
							obj3 = 1;
							if (OhMyGodProtocol.CheckGeneralAggregator == null)
							{
								obj3 = 1;
							}
							goto IL_0323;
						}
						goto IL_06aa;
						IL_011d:
						num = 0;
						if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.StoreConverter != null)
						{
							num = 0;
						}
						goto IL_0107;
						IL_0107:
						switch (num)
						{
						case 2:
							break;
						case 1:
							/*Error near IL_013e: Member reference must be method, but was: Field*/;
						default:
							goto IL_0167;
						}
						goto IL_011d;
						IL_0167:
						if ((nuint)(nint)obj <= (nuint)1u)
						{
							_ = 6;
							goto IL_017e;
						}
						goto IL_0238;
						IL_06aa:
						obj = ((HeypixelHwid)Unsafe.AsPointer(ref this)).NetworkCardInfo__BackingField;
						obj3 = 13;
						if (((HeypixelHwid)HeypixelHwid.DiskInfo__BackingField).UserListInfo__BackingField == null)
						{
							obj3 = 5;
						}
						goto IL_0323;
						IL_0238:
						((RegexRunnerFactory)((EntityLaunchGameProxy)Unsafe.AsPointer(ref this)).ServerPort__BackingField)._002Ector();
						_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0._002Ecctor();
						num2 = (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectSymbolicAuditor() ? ((ReadOnlySpan<char>*)1) : ((ReadOnlySpan<char>*)null))->Length;
						num3 = 4;
						if (GameProxy.Logger__BackingField != null)
						{
							num3 = 1;
						}
						goto IL_017e;
						IL_017e:
						while (true)
						{
							switch (num3)
							{
							case 4:
								((_003C_003Ef__AnonymousType2<, , , >)((EqualityComparer<_00213>)num2).GetHashCode((_00213)EntitySocks5Account.AttachElement)).ToString();
								_003C_003Ef__AnonymousType2<, , , >.CheckAccessibleObject();
								/*Error near IL_01e5: Member reference must be method, but was: Field*/;
							case 6:
							case 7:
								num3 = 3;
								continue;
							case 2:
								((Regex)((EntityLaunchGameProxy)Unsafe.AsPointer(ref this)).Session__BackingField)._002Ector();
								((_003C_003Ef__AnonymousType3<, >)/*Error near IL_020f: Stack underflow*/)._002Ector((_003Centry_003Ej__TPar)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_003Csid_003Ej__TPar)num2);
								((_003C_003Ef__AnonymousType3<, >)/*Error near IL_0214: Stack underflow*/).Equals((object)/*Error near IL_0214: Stack underflow*/);
								/*Error near IL_0214: Member reference must be method, but was: Field*/;
							case 5:
								((RegexRunner)/*Error near IL_027c: Stack underflow*/).Capture((int)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), num2, (int)((GameProxy)Unsafe.AsPointer(ref this))._pinger);
								((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)/*Error near IL_0281: Stack underflow*/).TryMatchAtCurrentPosition((ReadOnlySpan<char>)/*Error near IL_0281: Stack underflow*/))._002Ector();
								SearchValues.Create((ReadOnlySpan<char>)/*Error near IL_028b: Stack underflow*/);
								_ = 2;
								if (((GameProxy)GameProxy.GameType__BackingField).GameId__BackingField == null)
								{
									_ = 0;
								}
								continue;
							case 8:
								((EntitySocks5Account)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((string)num2, (string)(object)Type.GetTypeFromHandle((RuntimeTypeHandle)((GameProxy)Unsafe.AsPointer(ref this)).GameVersion__BackingField));
								((StringBuilder)/*Error near IL_02c4: Stack underflow*/).Append((char)(int)((EntitySocks5Account)/*Error near IL_02bf: Stack underflow*/).EqualityContract);
								_ = 0;
								if (((GameProxy)GameProxy.TransferServerPort__BackingField).Section__BackingField != null)
								{
									_ = 1;
								}
								continue;
							case 1:
								((GameProxy)Unsafe.AsPointer(ref this)).IsGame = (byte)(int)new EqualityComparer<Type>() != 0;
								num3 = 7;
								continue;
							case 3:
								goto IL_02f8;
							}
							break;
						}
						goto IL_0238;
						IL_02f8:
						if (obj == null)
						{
							obj3 = 6;
							if (((GameProxy)GameProxy.BlockIrcMessages).WorkerGroup__BackingField != null)
							{
								obj3 = 2;
							}
							goto IL_0323;
						}
						goto IL_0516;
						IL_0323:
						while (true)
						{
							switch ((int)obj3)
							{
							case 14:
								break;
							case 19:
								return;
							case 25:
								return;
							case 3:
								if (((EqualityComparer<string>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Equals((string?)num2, (string?)(&obj)))
								{
									_ = 27;
									continue;
								}
								goto case 4;
							case 13:
								((GameProxy)Unsafe.AsPointer(ref this))._channel = null;
								obj3 = 11;
								if (((GameProxy)GameProxy.ProxyPort__BackingField)._connection == null)
								{
									obj3 = 28;
								}
								continue;
							case 18:
								((EntitySocks5Account)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Deconstruct(out *(string*)num2, out *(string*)GameProxy.ReflectSimpleVerifier);
								obj = ((EqualityComparer<EntitySocks5Account>)/*Error near IL_0411: Stack underflow*/).Equals((EntitySocks5Account?)/*Error near IL_0411: Stack underflow*/, (EntitySocks5Account?)((EqualityComparer<int>)(object)GameProxy._003C_003EO._003C1_003E__OnConnectServer).Equals((int)EqualityComparer<EntitySocks5Account>.Default, ((GameProxy._003CListenAsync_003Ed__69)this)._003C_003E1__state));
								_ = 11;
								continue;
							case 1:
								((EntitySocks5)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).Address = (string)num2;
								obj = (object)/*Error near IL_0433: Stack underflow*/;
								_ = 17;
								if (GameProxy._003CListenAsync_003Ed__69.CheckCentralResponder != null)
								{
									_ = 13;
								}
								continue;
							case 15:
								num2 = ((EqualityComparer<EnumGameVersion>)((EqualityComparer<EnumGameType>)num2).GetHashCode((EnumGameType)(int)(&obj))).GetHashCode((EnumGameVersion)(int)EqualityComparer<EnumGameVersion>.Default);
								obj = EqualityComparer<EntitySocks5>.Default;
								obj3 = 3;
								continue;
							case 28:
								obj = -1;
								((CpsDetector)Unsafe.AsPointer(ref this))._lastRightCps = -1.0;
								obj3 = 24;
								continue;
							case 26:
								_ = ref obj;
								obj = EqualityComparer<SectionValue>.Default;
								_ = 2;
								if (OrangeProtocol.StartMapper == null)
								{
									_ = 9;
								}
								continue;
							default:
								((IByteBuffer)(object)Unsafe.AsPointer(ref OhMyGodEncryption.DecorateEfficientEmitter)).WritePrefixedArray((List<Slot>)(&obj), (Action<Slot>)Unsafe.AsPointer(ref this));
								_ = 25;
								continue;
							case 16:
								((OhMyGodHwid)Unsafe.AsPointer(ref this)).HwidMd5__BackingField = obj;
								obj3 = 10;
								if (OhMyGodHwid._003C_003EO._003C0_003E__GenerateRandomMac == null)
								{
									obj3 = 10;
								}
								continue;
							case 8:
								OhMyGodHwid._003C_003EO._003C1_003E__GenerateRandomCpu = (Func<string>)obj;
								obj3 = 0;
								if (((OhMyGodProtocol)(object)OhMyGodHwid._003C_003EO._003C2_003E__GenerateRandomDiskStoreInfo)._hwid == null)
								{
									obj3 = 0;
								}
								continue;
							case 20:
								goto IL_0516;
							case 24:
							case 27:
							{
								Delegate? obj4 = Delegate.Combine((Delegate?)num2, (Delegate?)(&obj));
								obj = null;
								Unsafe.As<_003Caction_003Ej__TPar, DefaultInterpolatedStringHandler>(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field) = new DefaultInterpolatedStringHandler((int)obj4, (int)obj);
								((DefaultInterpolatedStringHandler*)/*Error near IL_0558: Stack underflow*/)->AppendFormatted<T>((T)/*Error near IL_0558: Stack underflow*/);
								obj = (object)/*Error near IL_055a: Stack underflow*/;
								obj = 30;
								goto IL_031f;
							}
							case 9:
							{
								Unsafe.As<_003Caction_003Ej__TPar, DefaultInterpolatedStringHandler>(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field).AppendLiteral((string)num2);
								string text = ((DefaultInterpolatedStringHandler*)/*Error near IL_0572: Stack underflow*/)->ToStringAndClear();
								((AsyncTaskMethodBuilder*)((EntityLaunchGameProxy)(object)((HytMainMenu._003C_003Ec__DisplayClass2_0)obj).sendGermPacket).ModHashList)->Start<TStateMachine>(ref *(TStateMachine*)obj);
								_ = ((AsyncTaskMethodBuilder*)text)->Task;
								/*Error near IL_058a: Member reference must be method, but was: Field*/;
							}
							case 5:
							{
								EntitySocks5? socks = ((EntityLaunchGameProxy)new EventBus((Action<T>)HytMainMenu._003C_003Ec__DisplayClass2_2.DefineModule, (int)obj)).Socks5;
								GC.SuppressFinalize(((EntityLaunchGameProxy)(object)HytProtocol.CheckFilteredDistributor).Value);
								((IChannel)socks).CloseAsync();
								_ = 2;
								continue;
							}
							case 30:
								((EntityLaunchGameProxy)num2).IsGame = (byte)(&obj) != 0;
								obj = ((ILogger)/*Error near IL_05ee: Stack underflow*/).Category((string)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
								_ = 26;
								continue;
							case 2:
								((ILogger)num2).Information<_0021_00210>((string)((VexViewPacket)Unsafe.AsPointer(ref this)).PacketData__BackingField, (_0021_00210)((EntityLaunchGameProxy)((EntityLaunchGameProxy?)obj == (EntityLaunchGameProxy?)(object)new IChannel())).Equals(EnumReflectCheck.ClientInfo));
								Unsafe.As<_003Caction_003Ej__TPar, TaskAwaiter<IChannel>>(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field).GetResult();
								_ = 13;
								if ((int)((HeypixelHwid)(object)HeypixelEncryption.PlanDistributor).ClientGuid__BackingField == 0)
								{
									_ = 18;
								}
								continue;
							case 10:
								_ = ref ((HeypixelHwid)Unsafe.AsPointer(ref this)).ClassesCount__BackingField;
								((IEnumerable<NbtTag>)(&obj)).Any((Func<NbtTag, bool>)Unsafe.AsPointer(ref this));
								_ = 19;
								continue;
							case 4:
								obj = 1;
								((HeypixelHwid)Unsafe.AsPointer(ref this)).McDownloadPath__BackingField = 1;
								obj3 = 8;
								continue;
							case 22:
								obj = -1;
								((HeypixelHwid)Unsafe.AsPointer(ref this)).CpuInfo__BackingField = -1;
								obj = 15;
								goto IL_031f;
							case 11:
								_ = ref obj;
								/*Error near IL_0696: Member reference must be method, but was: Field*/;
							case 23:
								goto IL_06aa;
							case 21:
								_ = ((GameProxy)((GameProxy)obj).GameType).GameId;
								_ = ((GameProxy)obj).GameVersion;
								_ = 14;
								continue;
							case 7:
								((HeypixelHwid)Unsafe.AsPointer(ref this)).Notice__BackingField = null;
								obj3 = 22;
								if (((HeypixelMod)(object)HeypixelHwid.CheckMixedEncryptor).ModPath__BackingField == null)
								{
									obj3 = 19;
								}
								continue;
							case 17:
								((GameProxy)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).TransferServerAddress = (string?)num2;
								obj = (object)/*Error near IL_0720: Stack underflow*/;
								_ = 5;
								continue;
							case 29:
								obj = 0;
								((HeypixelMod)Unsafe.AsPointer(ref this)).ModName__BackingField = 0;
								obj3 = 16;
								continue;
							case 6:
							case 12:
								{
									obj = HeypixelMod.DecorateCommonAllocator;
									obj3 = 1;
									if (HeypixelPacket.Packets == null)
									{
										obj3 = 7;
									}
									continue;
								}
								IL_031f:
								obj3 = obj;
								continue;
							}
							break;
						}
						goto case 4;
					}
					break;
				}
				obj = ((_003C_003Ef__AnonymousType2<, , , >)Unsafe.AsPointer(ref this))._003Ccontext_003Ei__Field;
				obj = 2;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_F400()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778959, new IntPtr(2737368331868L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_F500(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778958, new IntPtr(2737368331868L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_F600(object P_0)
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

	public readonly string ClientId;

	internal static DoMcerProtocol DecorateSimpleBridge;

	private static ILogger Logger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SubscribeEvent]
	public void OnServerPluginMessage(EventServerPluginMessage @event)
	{
		_FF00_FF00_F300(@event);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSendCustomSkin_003Ed__5))]
	private object SendCustomSkin()
	{
		return _FF00_FF00豈();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSendImage_003Ed__6))]
	private object SendImage()
	{
		return _FF00_FF00_F700();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object GenerateRandomBmp()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0057: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 840, 1790778982, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778982, new IntPtr(2737368303788L), 15);
		}
		return ((delegate*<object>)obj)();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe DoMcerProtocol()
	{
		//IL_001a: Expected VT, but got Obj
		//IL_001a: Expected VT, but got Ref
		//IL_001c: Expected Obj, but got I4
		//IL_002e: Expected VT, but got Obj
		//IL_0048: Expected Obj, but got VT
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = ((EqualityComparer<_00210>)/*Error near IL_001a: Stack underflow*/).Equals((_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00210?)this);
		((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_002e: Stack underflow*/)._003Curl_003Ei__Field = (_003Curl_003Ej__TPar)((GameInstance*)(&obj))->ToString();
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

	static DoMcerProtocol()
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
				Logger__BackingField = Log.Logger.Category((string)ZYXDNGuarder._FF00_FF00_EB00());
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
	internal static bool CheckControllableCommand()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DoMcerProtocol TrackRecord()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_E500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778977, new IntPtr(2737368325628L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_E600()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_E700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778976, new IntPtr(2737368317308L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_E800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778979, new IntPtr(2737368319388L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_E900()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_040f: Expected Obj, but got Ref
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected Obj, but got Unknown
		//IL_0440: Expected Obj, but got I4
		//IL_0052: Expected VT, but got I4
		//IL_0066: Expected Obj, but got VT
		//IL_01e9: Expected Obj, but got I4
		//IL_02bd: Expected Obj, but got I4
		//IL_028b: Expected Obj, but got I
		//IL_02d9: Expected Obj, but got I4
		//IL_02de: Expected Obj, but got I4
		//IL_02de: Expected Obj, but got Ref
		//IL_02e3: Expected Obj, but got I4
		//IL_030a: Expected Obj, but got I4
		//IL_0210: Expected Obj, but got VT
		//IL_0210: Expected VT, but got Obj
		//IL_033c: Expected Obj, but got I4
		//IL_0345: Expected Obj, but got I4
		//IL_023b: Expected Obj, but got I4
		//IL_00f5: Expected VT, but got Obj
		//IL_00f5: Expected VT, but got I4
		//IL_010c: Expected VT, but got I4
		//IL_010c: Expected VT, but got Obj
		//IL_0111: Expected VT, but got I4
		//IL_0111: Expected Obj, but got Ref
		//IL_0116: Expected VT, but got I4
		//IL_0425->IL0026: Incompatible stack heights: 1 vs 2
		//IL_03ff->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0454->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0430->IL0026: Incompatible stack heights: 1 vs 2
		//IL_040a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_045f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_034f->IL0430: Incompatible stack heights: 0 vs 1
		//IL_02c2->IL007a: Incompatible stack heights: 7 vs 5
		//IL_02f7->IL007a: Incompatible stack heights: 3 vs 5
		//IL_0224->IL007a: Incompatible stack types: I4 vs Obj
		//IL_024f->IL007a: Incompatible stack heights: 6 vs 5
		//IL_0104->IL007a: Incompatible stack heights: 7 vs 5
		//IL_0120->IL007a: Incompatible stack heights: 3 vs 5
		//IL_02cd->IL007a: Incompatible stack heights: 7 vs 5
		//IL_0302->IL007a: Incompatible stack heights: 3 vs 5
		//IL_022f->IL007a: Incompatible stack types: I4 vs Obj
		//IL_007a->IL007a: Incompatible stack heights: 4 vs 5
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
			{
				object obj3 = obj;
				object obj4 = new EqualityComparer<_00210>((_00210)2).ToString();
				int num = 1;
				if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType2<, , , >._003Curl_003Ei__Field)._003Cpayload_003Ei__Field == 0)
				{
					num = 7;
				}
				while (true)
				{
					switch (num)
					{
					case 13:
						_ = 0;
						/*Error near IL_00cf: Member reference must be method, but was: Field*/;
					case 16:
						((EqualityComparer<_00212>)obj).Equals((_00212?)0, (_00212?)EqualityComparer<_00212>.Default);
						_ = EqualityComparer<_00211>.Default;
						_ = 3;
						continue;
					case 17:
						((EqualityComparer<_00212>)obj3).GetHashCode((_00212)((EqualityComparer<_00211>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field)).GetHashCode((_00211)((EqualityComparer<_00211>)obj4).Equals((_00211?)obj, (_00211?)1)));
						_ = 10;
						continue;
					case 12:
						_ = 0;
						/*Error near IL_0123: Member reference must be method, but was: Field*/;
					case 15:
						_ = 54;
						/*Error near IL_0140: Member reference must be method, but was: Field*/;
					default:
						_ = 960;
						/*Error near IL_0175: Member reference must be method, but was: Field*/;
					case 5:
						_ = 40;
						/*Error near IL_0192: Member reference must be method, but was: Field*/;
					case 7:
						/*Error near IL_01c4: Member reference must be method, but was: Field*/;
					case 1:
					{
						object obj5 = obj;
						((RegexRunnerFactory)2835)._002Ector();
						((RegexRunner)obj5).CheckTimeout();
						/*Error near IL_01ee: Member reference must be method, but was: Field*/;
					}
					case 10:
					{
						int num2 = MemoryExtensions.IndexOfAny<T>((ReadOnlySpan<T>)obj4, (SearchValues<T>)((ReadOnlySpan<char>*)obj)->Slice(((ReadOnlySpan<char>*)24)->Length));
						num = 16;
						obj4 = num2;
						if (((GameProxy)GameProxy._pinger).ConnectionChanged != null)
						{
							num = 16;
							obj4 = num2;
						}
						continue;
					}
					case 14:
					{
						object text = obj;
						((RegexRunner)2835)._002Ector();
						SearchValues.Create((string?)text);
						_ = 12;
						continue;
					}
					case 9:
						/*Error near IL_0253: Member reference must be method, but was: Field*/;
					case 4:
						obj4 = new AppContext((string)obj4);
						obj = new MultithreadEventLoopGroup[obj];
						((StringBuilder)obj)._002Ector();
						num = 9;
						if (((GameProxy)GameProxy.ServerPort__BackingField).TransferServerAddress__BackingField == null)
						{
							num = 3;
						}
						continue;
					case 3:
						((StringBuilder)obj).Append(obj);
						RuntimeHelpers.EnsureSufficientExecutionStack();
						_ = EqualityComparer<Type>.Default;
						_ = 1;
						if (((GameProxy)GameProxy.IsGame).BlockIrcMessages)
						{
							_ = 0;
						}
						continue;
					case 6:
						_ = (Type?)obj3 == (Type?)((EqualityComparer<string>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field)).Equals((string?)obj4, (string?)((EqualityComparer<string>)obj).GetHashCode((string)1280));
						_ = 0;
						if (((GameProxy)GameProxy.DisplayAddress__BackingField).ProxyPort__BackingField != 0)
						{
							_ = 0;
						}
						continue;
					case 8:
						((FormatException)obj4)._002Ector((string?)obj + (string?)0);
						obj4 = EqualityComparer<int>.Default;
						num = 4;
						if (GameProxy._003C_003EO._003C2_003E__OnConnectServer != null)
						{
							num = 3;
						}
						continue;
					case 11:
						obj = ((EqualityComparer<EntitySocks5Account>)obj4).GetHashCode((EntitySocks5Account)obj);
						obj = 2;
						continue;
					case 2:
						break;
					}
					break;
				}
				goto case 3;
			}
			case 1:
				obj = 54 + obj;
				obj2 = 0;
				if ((int)((CpsDetector)(object)CpsDetector._rightClicks)._lastLeftCps == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				obj = new EqualityComparer<EntitySocks5>((EntitySocks5)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field));
				_ = 1;
				if (CpsDetector.DecompressList == null)
				{
					_ = 4;
				}
				break;
			case 3:
				return obj;
			case 2:
				obj = 3840 * 960;
				obj2 = 1;
				if (OhMyGodEncryption.DecorateEfficientEmitter != null)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_EA00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778978, new IntPtr(2737368316268L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_EC00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779005, new IntPtr(2737368326668L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00_FF00_ED00()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_EE00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779004, new IntPtr(2737368319388L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_F200(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779007, new IntPtr(2737368329788L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_F300(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0048: Expected VT, but got Obj
		//IL_0048: Expected Obj, but got Ref
		//IL_0059: Expected Obj, but got VT
		//IL_040a: Expected Obj, but got F8
		//IL_027f: Expected I4, but got Obj
		//IL_027f: Expected I4, but got Obj
		//IL_0289: Expected Obj, but got I4
		//IL_00f6: Expected Obj, but got VT
		//IL_010c: Expected Obj, but got VT
		//IL_0137: Expected VT, but got I4
		//IL_02cf: Expected Obj, but got I4
		//IL_02d7: Expected Obj, but got I4
		//IL_02d7: Expected Obj, but got I4
		//IL_02d8: Expected Obj, but got I4
		//IL_02df: Expected Obj, but got I4
		//IL_02e7: Expected Obj, but got I4
		//IL_02ef: Expected Obj, but got I4
		//IL_02f7: Expected Obj, but got I4
		//IL_02f8: Expected Obj, but got I4
		//IL_0302: Expected Obj, but got I4
		//IL_0307: Expected Obj, but got I4
		//IL_0309: Expected Obj, but got I4
		//IL_0174: Expected Obj, but got VT
		//IL_0367: Expected native int or pointer, but got Obj
		//IL_03e8->IL0026: Incompatible stack heights: 3 vs 2
		//IL_040f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03f3->IL0026: Incompatible stack heights: 3 vs 2
		//IL_041a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_032d->IL03c5: Incompatible stack heights: 0 vs 1
		//IL_0381->IL03c5: Incompatible stack heights: 0 vs 1
		//IL_0267->IL03c5: Incompatible stack heights: 0 vs 1
		//IL_00eb->IL006d: Incompatible stack heights: 2 vs 1
		//IL_0121->IL03c5: Incompatible stack heights: 0 vs 1
		//IL_0111->IL006d: Incompatible stack heights: 3 vs 1
		//IL_0188->IL03c5: Incompatible stack heights: 0 vs 1
		//IL_0160->IL03c5: Incompatible stack heights: 0 vs 1
		//IL_01fe->IL006d: Incompatible stack heights: 2 vs 1
		//IL_011c->IL006d: Incompatible stack heights: 3 vs 1
		//IL_0209->IL006d: Incompatible stack heights: 2 vs 1
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				return;
			case 1:
				_ = ((EntitySocks5)obj).Port;
				obj = EqualityComparer<EnumGameType>.Default;
				_ = 0;
				if (((CpsDetector)CpsDetector._lock)._leftClicks == null)
				{
					_ = 0;
				}
				continue;
			case 2:
				obj = EntitySocks5.Parse((string?)P_0);
				obj2 = 0;
				if ((int)((CpsDetector)CpsDetector._lastLeftCps)._lastRightCps == 0)
				{
					obj2 = 1;
				}
				continue;
			}
			((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Caction_003Ej__TPar)obj);
			obj = (object)/*Error near IL_004a: Stack underflow*/;
			int num = 8;
			if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
			{
				num = 16;
			}
			while (true)
			{
				switch (num)
				{
				case 12:
					((_003C_003Ef__AnonymousType0<>)obj).ToString();
					/*Error near IL_00c6: Member reference must be method, but was: Field*/;
				case 5:
					_003C_003Ef__AnonymousType0<>.ReflectJoinedTree();
					_ = 2;
					break;
				case 9:
					_ = ((_003C_003Ef__AnonymousType1<, , >)((_003C_003Ef__AnonymousType1<, , >)(object)this).name).uuid;
					_ = ((_003C_003Ef__AnonymousType1<, , >)obj).user_id;
					_ = 0;
					if (_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument != null)
					{
						_ = 13;
					}
					break;
				case 6:
					return;
				case 10:
					if (((EqualityComparer<_00211>)/*Error near IL_0137: Stack underflow*/).GetHashCode((_00211)((_003C_003Ef__AnonymousType1<, , >)obj).GetHashCode()) == 0)
					{
						num = 3;
						if ((int)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_defaultTimeout != 0)
						{
							num = 3;
						}
						break;
					}
					goto case 5;
				case 13:
					return;
				default:
					_ = ((_003C_003Ef__AnonymousType2<, , , >)((_003C_003Ef__AnonymousType2<, , , >)/*Error near IL_016f: Stack underflow*/).url).payload;
					/*Error near IL_0174: Member reference must be method, but was: Field*/;
				case 11:
					return;
				case 8:
					/*Error near IL_0192: Member reference must be method, but was: Field*/;
				case 17:
					((_003C_003Ef__AnonymousType3<, >)/*Error near IL_01e3: Stack underflow*/)._002Ector((_003Centry_003Ej__TPar)/*Error near IL_01e3: Stack underflow*/, ((_003C_003Ef__AnonymousType3<, >)(object)this).sid);
					((_003C_003Ef__AnonymousType3<, >)/*Error near IL_01ea: Stack underflow*/).Equals(obj);
					_ = 1;
					if (((EntityLaunchGameProxy)EntityLaunchGameProxy.ModHashList__BackingField).Name__BackingField == null)
					{
						_ = 1;
					}
					break;
				case 7:
					((RegexRunnerFactory)/*Error near IL_0232: Stack underflow*/)._002Ector();
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0._002Ecctor();
					/*Error near IL_0237: Member reference must be method, but was: Field*/;
				case 3:
					return;
				case 4:
					((RegexRunner)/*Error near IL_027f: Stack underflow*/).Capture(MemoryExtensions.IndexOfAnyExcept<T>((ReadOnlySpan<T>)/*Error near IL_0276: Stack underflow*/, (SearchValues<T>)/*Error near IL_0276: Stack underflow*/), (int)obj, (int)obj);
					_ = (ReadOnlySpan<char>)(string?)((_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner)/*Error near IL_0284: Stack underflow*/).TryMatchAtCurrentPosition((ReadOnlySpan<char>)/*Error near IL_0284: Stack underflow*/);
					_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.VerifyVerifier();
					/*Error near IL_028e: Member reference must be method, but was: Field*/;
				case 14:
				{
					((StringBuilder)(object)Type.GetTypeFromHandle((RuntimeTypeHandle)/*Error near IL_02bc: Stack underflow*/))._002Ector();
					Delegate[] array = new Delegate[6];
					array[(object)array] = (Delegate)(object)((EntitySocks5Account)0).Username;
					((EntitySocks5Account)0).Username = (string)1;
					((object[])/*Error near IL_02d8: Stack underflow*/)[/*Error near IL_02d8: Stack underflow*/] = 0;
					((object[])/*Error near IL_02e0: Stack underflow*/)[/*Error near IL_02d8: Stack underflow*/] = ((EntitySocks5Account)2).Password;
					((EntitySocks5Account)/*Error near IL_02e0: Stack underflow*/).Password = (string)3;
					((object[])/*Error near IL_02e8: Stack underflow*/)[/*Error near IL_02e8: Stack underflow*/] = (object)/*Error near IL_02e8: Stack underflow*/;
					((object[])/*Error near IL_02f0: Stack underflow*/)[/*Error near IL_02e8: Stack underflow*/] = ((EntitySocks5Account)4).ToString();
					((object[])/*Error near IL_02f8: Stack underflow*/)[/*Error near IL_02f8: Stack underflow*/] = ((EntitySocks5Account)/*Error near IL_02f0: Stack underflow*/).PrintMembers((StringBuilder)5);
					obj = (Type?)/*Error near IL_0307: Stack underflow*/ == (Type?)((EqualityComparer<string>)/*Error near IL_0302: Stack underflow*/).Equals((string?)/*Error near IL_0302: Stack underflow*/, (string?)((EqualityComparer<string>)/*Error near IL_02fd: Stack underflow*/).GetHashCode((string)/*Error near IL_02fd: Stack underflow*/));
					num = 17;
					if (((GameProxy)GameProxy.DisplayAddress__BackingField).ProxyPort__BackingField != 0)
					{
						num = 4;
					}
					break;
				}
				case 1:
					return;
				case 16:
					((EntitySocks5Account)/*Error near IL_0353: Stack underflow*/).Deconstruct(out *(string*)/*Error near IL_0353: Stack underflow*/, out *(string*)obj);
					if (((EqualityComparer<int>)/*Error near IL_0358: Stack underflow*/).GetHashCode((int)/*Error near IL_0358: Stack underflow*/) == 0)
					{
						num = 9;
						if (((GameProxy._003CListenAsync_003Ed__69*)(nint)GameProxy._003C_003EO._003C2_003E__OnConnectServer)->_003C_003E1__state != 0)
						{
							num = 12;
						}
						break;
					}
					goto case 4;
				case 2:
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_F400()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_F500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779006, new IntPtr(2737368329788L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_F600()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779001, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_F700()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 11483, 1790779000, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779000, new IntPtr(2737368323548L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_F800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779003, new IntPtr(2737368316268L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00豈()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 11485, 1790779002, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779002, new IntPtr(2737368311068L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00切()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778997, new IntPtr(2737368317308L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
