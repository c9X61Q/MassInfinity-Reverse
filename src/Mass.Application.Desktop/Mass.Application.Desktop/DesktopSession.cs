using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Mass.Application.Desktop.Models;
using Mass.Application.Netease;
using Mass.Application.Services;
using Mass.Common.Extensions;
using Mass.Domain.Desktop.Entities;
using Mass.Domain.Desktop.Entities.Game;
using Mass.Domain.Desktop.Entities.Item;
using Mass.Domain.Desktop.Entities.Mods;
using Mass.Domain.Desktop.Entities.NetGame;
using Mass.Domain.Desktop.Entities.RentalGame;
using Mass.Domain.Desktop.Entities.Skin;
using Mass.Domain.Desktop.Interfaces;
using Mass.Domain.Desktop.Models;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Domain.Entities.Netease;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Utilities;
using RestSharp;
using Serilog;

namespace Mass.Application.Desktop;

public class DesktopSession : NeteaseSession
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Entities<EntityNetGameItem>> _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		public int offset;

		private Entities<EntityNetGameItem> _003CnetGames_003E5__2;

		private Dictionary<string, EnumGameVersion> _003CversionDictionary_003E5__3;

		private TaskAwaiter<Entities<EntityNetGameItem>> _003C_003Eu__1;

		private TaskAwaiter<EntityNetGameVersion[]> _003C_003Eu__2;

		internal static object UpdateRecord;

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
		internal static bool ReflectConfigurableCollection()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckSeparatedProfile()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00销()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779150, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00阀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_004b: Expected I4, but got Obj
			//IL_0057: Expected Obj, but got Ref
			//IL_0068: Expected Obj, but got Ref
			//IL_0764: Expected Obj, but got VT
			//IL_008d: Expected Obj, but got Ref
			//IL_04d3: Expected Obj, but got VT
			//IL_05d4: Expected Obj, but got I4
			//IL_05d9: Expected Obj, but got I4
			//IL_05d9: Expected Obj, but got Ref
			//IL_020f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0212: Expected Obj, but got Unknown
			//IL_02f2: Expected Obj, but got Ref
			//IL_04fe: Expected native int or pointer, but got Obj
			//IL_026e: Expected I4, but got Obj
			//IL_0277: Expected Obj, but got I4
			//IL_02b9: Expected Obj, but got I4
			//IL_02be: Expected Obj, but got I4
			//IL_048a: Expected I4, but got Obj
			//IL_0494: Expected native int or pointer, but got Obj
			//IL_0518: Expected Obj, but got I4
			//IL_051d: Expected Obj, but got I4
			//IL_0381: Expected Obj, but got Ref
			//IL_0383: Expected Obj, but got I4
			//IL_02e1: Expected I, but got VT
			//IL_02e1: Expected Obj, but got VT
			//IL_021f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0222: Expected Obj, but got Unknown
			//IL_01f7: Expected native int or pointer, but got Obj
			//IL_0284: Expected Obj, but got VT
			//IL_0334: Expected Obj, but got VT
			//IL_059b: Expected Obj, but got I4
			//IL_0541: Expected Obj, but got I4
			//IL_0550: Expected native int or pointer, but got Obj
			//IL_0605: Expected Obj, but got Ref
			//IL_060a: Expected VT, but got Obj
			//IL_060a: Expected Obj, but got VT
			//IL_029f: Expected native int or pointer, but got Obj
			//IL_04ac: Expected Obj, but got I4
			//IL_04b6: Expected native int or pointer, but got Obj
			//IL_03b1: Expected Obj, but got VT
			//IL_03c5: Expected native int or pointer, but got Obj
			//IL_040b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0415: Expected Obj, but got Unknown
			//IL_041f: Expected native int or pointer, but got Obj
			//IL_0631: Expected Ref, but got VT
			//IL_063b: Expected I4, but got Obj
			//IL_0159: Expected I4, but got Obj
			//IL_0061->IL0026: Incompatible stack types: I4 vs Obj
			//IL_075c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_007c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_076e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0099->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0087->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ac->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_04dd->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_037a->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0466->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_05e3->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_021c->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0508->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_02c8->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_03f2->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_049e->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0531->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_044a->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0397->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_02eb->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_022c->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0201->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_028e->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_034a->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_05a5->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_055a->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0329->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_040a->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_02a9->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_04c0->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0482->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_03cf->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0429->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0471->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_030b->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0513->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_05c4->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_04a9->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_053c->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0598->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_03a2->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_025b->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_020c->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0355->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0565->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0652->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_062c->IL062c: Incompatible stack heights: 4 vs 3
			//IL_02b4->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_04cb->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_03da->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0434->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0316->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_05cf->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0266->IL00b0: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 7;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				default:
					((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP = null;
					obj2 = 2;
					break;
				case 3:
					((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserToken_003EP = null;
					obj2 = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
					{
						obj2 = 0;
					}
					break;
				case 7:
					obj = DesktopAuthentication.Crc32;
					obj2 = 6;
					break;
				case 4:
					return;
				case 5:
					if (obj == null)
					{
						obj3 = 24;
						goto IL_00b0;
					}
					goto IL_0368;
				case 2:
					_ = ref ((_003CAddGameCharacterAsync_003Ed__44)this).gameId;
					/*Error near IL_0726: Member reference must be method, but was: Field*/;
				case 1:
					goto IL_074a;
				case 6:
					{
						obj = ((_003CAddRentalGameCharacterAsync_003Ed__45)this)._003C_003Et__builder;
						obj2 = 5;
						break;
					}
					IL_0368:
					if ((nint)obj != 1)
					{
						obj3 = 19;
						goto IL_00b0;
					}
					goto IL_04cb;
					IL_04cb:
					obj = ((DesktopAuthentication._003CSendMessageAsync_003Ed__29)this)._003C_003Et__builder;
					obj3 = 16;
					goto IL_00b0;
					IL_00b0:
					while (true)
					{
						switch ((int)obj3)
						{
						case 11:
							return;
						case 32:
							return;
						case 19:
						{
							bool flag = _003C_003Ef__AnonymousType0<, >.ControlDriver();
							string? obj4 = new object();
							(flag ? ((AsyncTaskMethodBuilder*)1) : ((AsyncTaskMethodBuilder*)null))->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)obj4, ref *(DesktopAuthentication._003CAuthentication_003Ed__27*)obj4);
							/*Error near IL_0170: Member reference must be method, but was: Field*/;
						}
						case 25:
							((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E4__this = null;
							obj3 = 4;
							if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27.serverIdHash)->_003Ccts_003E5__2 != null)
							{
								obj3 = 15;
							}
							continue;
						case 5:
							obj++;
							obj3 = 8;
							continue;
						case 23:
							obj++;
							obj3 = 17;
							continue;
						case 22:
							if (((TaskAwaiter<byte[]>*)(&obj))->IsCompleted)
							{
								obj3 = 1;
								if (DesktopAuthentication._003CAuthentication_003Ed__27.ReflectInternalAnnotation == null)
								{
									obj3 = 1;
								}
								continue;
							}
							goto case 2;
						case 9:
							((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003E1__state = (int)obj;
							obj = 40;
							obj3 = obj;
							continue;
						case 26:
							obj = ((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003Et__builder;
							obj3 = 4;
							continue;
						case 36:
							obj = ((object[])obj)[obj];
							obj3 = 39;
							if (((DesktopAuthentication._003CConnect_003Ed__19*)(nint)DesktopAuthentication._003CConnect_003Ed__19._003C_003E4__this)->authServer == null)
							{
								obj3 = 2;
							}
							continue;
						case 12:
							obj = -1;
							((DesktopAuthentication._003CConnect_003Ed__19)this)._003Ccts_003E5__2 = -1;
							obj3 = 18;
							continue;
						case 20:
							((Action)((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003Eu__1)._002Ector(((TaskCompletionSource)obj).Task, (nint)((CancellationTokenSource)obj).Token);
							obj3 = 5;
							continue;
						case 6:
							if ((int)((CancellationToken*)/*Error near IL_02f2: Stack underflow*/)->Register((Action)(&obj)) != 0)
							{
								obj3 = 27;
								if (DesktopAuthentication._003CHeartbeatAsync_003Ed__25.ProcessResolver == null)
								{
									obj3 = 19;
								}
								continue;
							}
							goto case 31;
						case 1:
						case 34:
							((AsyncTaskMethodBuilder*)(&obj))->SetResult();
							obj = (object)/*Error near IL_031f: Stack underflow*/;
							obj3 = 9;
							continue;
						case 29:
							((AsyncTaskMethodBuilder*)/*Error near IL_0334: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003Et__builder);
							obj = (object)/*Error near IL_0336: Stack underflow*/;
							obj3 = 8;
							if (DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24.ReflectMixedRunner != null)
							{
								obj3 = 37;
							}
							continue;
						case 21:
							break;
						case 18:
						case 27:
							obj = ((EntityAuthServer)(&obj)).Port;
							obj3 = 30;
							if (((DesktopAuthentication._003CReceiveAsync_003Ed__20)DesktopAuthentication._003CReceiveAsync_003Ed__20._003C_003Et__builder)._003C_003E4__this == null)
							{
								obj3 = 15;
							}
							continue;
						case 39:
							((ILogger)obj).Warning((Exception)((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003Eu__1, (string)obj);
							((AsyncTaskMethodBuilder<EntityGameCharacter[]>*)/*Error near IL_03b6: Stack underflow*/)->Start(ref *(_003CGetGameCharactersAsync_003Ed__41*)/*Error near IL_03b6: Stack underflow*/);
							((ILogger)/*Error near IL_03bb: Stack underflow*/).Error((Exception)/*Error near IL_03bb: Stack underflow*/, (string)/*Error near IL_03bb: Stack underflow*/);
							obj3 = 23;
							if (((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22*)(nint)DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22._003C_003E4__this)->data == null)
							{
								obj3 = 8;
							}
							continue;
						case 13:
							_ = ref ((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this)._003C_003Eu__1;
							((AsyncTaskMethodBuilder<EntityNetGameAddress>*)(&obj))->Start(ref Unsafe.As<_003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed, _003CGetNetGameAddressAsync_003Ed__46>(ref this));
							_ = 11;
							continue;
						case 35:
							_ = ref DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22.DecorateBasicTag;
							((AsyncTaskMethodBuilder<EntityAuthItem>*)(&obj))->Start(ref Unsafe.As<_003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed, _003CGetAuthItemsAsync_003Ed__48>(ref this));
							_ = 32;
							continue;
						case 40:
							Unsafe.Write(&((DesktopAuthentication._003CReceiveDataAsync_003Ed__21*)(nint)/*Error near IL_0415: Stack underflow*/)->_003C_003E4__this, (DesktopAuthentication)(object)new Arrays((byte[])/*Error near IL_0410: Stack underflow*/, (int)/*Error near IL_0410: Stack underflow*/, (int)Unsafe.AsPointer(ref this)));
							obj3 = 5;
							if ((int)((DesktopAuthentication._003CReceiveDataAsync_003Ed__21*)(nint)DesktopAuthentication._003CReceiveDataAsync_003Ed__21.buffer)->_003C_003Eu__1 == 0)
							{
								obj3 = 33;
							}
							continue;
						case 16:
							Unsafe.As<nint, @null>(ref ((DesktopAuthentication._003CReceiveDataAsync_003Ed__21)this)._003Clength_003E5__2) = null;
							obj3 = 12;
							continue;
						default:
							DesktopAuthentication._003CReceiveDataAsync_003Ed__21.CheckActiveRecommender = obj;
							obj3 = 34;
							if ((int)((DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23*)DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23._003C_003E1__state)->_003C_003Et__builder != 0)
							{
								obj3 = 35;
							}
							continue;
						case 38:
							obj = ((object[])obj)[obj];
							obj3 = 20;
							continue;
						case 14:
							((DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23)this).sid = (ushort)(int)obj;
							obj3 = 13;
							if (((DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23*)(nint)DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23.payload)->_003C_003E4__this == null)
							{
								obj3 = 9;
							}
							continue;
						case 37:
							obj = 0;
							obj3 = 0;
							if (((DesktopAuthentication._003CSendMessageAsync_003Ed__29*)(nint)DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23.ReflectScalableNotifier)->_003C_003E1__state == 0)
							{
								obj3 = 3;
							}
							continue;
						case 28:
							goto IL_04cb;
						case 7:
						case 24:
							obj = ((DesktopAuthentication._003CSendMessageAsync_003Ed__29)this)._003C_003E4__this;
							obj3 = 19;
							if ((int)((DesktopAuthentication._003CSendMessageAsync_003Ed__29*)(nint)DesktopAuthentication._003CSendMessageAsync_003Ed__29.data)->_003C_003Eu__1 == 0)
							{
								obj3 = 25;
							}
							continue;
						case 15:
							obj = -1;
							DesktopAuthentication._003CSendMessageAsync_003Ed__29.CheckAccessibleCalculator = -1;
							obj3 = 24;
							if ((int)((DesktopAuthentication._003CSendPacketAsync_003Ed__28*)DesktopAuthentication._003CSendPacketAsync_003Ed__28._003C_003E1__state)->_003C_003Et__builder != 0)
							{
								obj3 = 34;
							}
							continue;
						case 31:
							obj = 1;
							((DesktopAuthentication._003CSendPacketAsync_003Ed__28)this).id = 1;
							obj3 = 0;
							if (((DesktopAuthentication._003CSendPacketAsync_003Ed__28*)(nint)DesktopAuthentication._003CSendPacketAsync_003Ed__28.data)->_003C_003E4__this != null)
							{
								obj3 = 0;
							}
							continue;
						case 3:
						case 17:
							if ((nint)obj >= ((Array)obj).Length)
							{
								obj3 = 26;
								continue;
							}
							goto case 36;
						case 30:
							obj = 0;
							obj3 = 10;
							continue;
						case 8:
						case 10:
							if ((nint)obj >= ((Array)obj).Length)
							{
								obj3 = 29;
								if (DesktopAuthentication._003CSendPacketAsync_003Ed__28.CheckIterableSynchronizer == null)
								{
									obj3 = 0;
								}
								continue;
							}
							goto case 38;
						case 2:
							obj = 0;
							((DesktopSession)Unsafe.AsPointer(ref this))._netGames = 0;
							obj3 = 14;
							continue;
						case 33:
						{
							EntityGameModsHash modHashList = ((DesktopSession)/*Error near IL_05f9: Stack underflow*/).GetModHashList((EntityItemDownload[])obj);
							ValueTaskAwaiter valueTask = new ValueTask();
							ValueTask valueTask2 = ((Stream)valueTask).WriteAsync((ReadOnlyMemory<byte>)valueTask, (CancellationToken)((DesktopSession)Unsafe.AsPointer(ref this)).UserDetail__BackingField);
							int num = _003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed._003C_003E1__state;
							if (num == 0)
							{
								_ = _003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed._003C_003Et__builder;
								_003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed._003CnetGames_003E5__2 = (Entities<EntityNetGameItem>)new BinaryWriter((byte)__ldftn(DesktopSession.InterStartAsync));
							}
							((AsyncTaskMethodBuilder<EntityGameCharacter[]>*)modHashList)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityGameCharacter[]>*)valueTask2, ref *(_003CGetGameCharactersAsync_003Ed__41*)num);
							((NeteaseSession)/*Error near IL_063b: Stack underflow*/)._002Ector((string)/*Error near IL_063b: Stack underflow*/, (string)/*Error near IL_063b: Stack underflow*/, (byte)(int)((DesktopSession)/*Error near IL_0636: Stack underflow*/).EntitiesRequestAsync<EntityGameCharacter>((string)/*Error near IL_0636: Stack underflow*/, (object)/*Error near IL_0636: Stack underflow*/, (byte)/*Error near IL_0636: Stack underflow*/ != 0) != 0);
							((AsyncTaskMethodBuilder<EntityGameClientPatch>*)/*Error near IL_0641: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityGameClientPatch>*)/*Error near IL_0641: Stack underflow*/, ref *(_003CGetGamePatchInfoAsync_003Ed__54*)1);
							((NeteaseSession)/*Error near IL_0646: Stack underflow*/).Dispose();
							obj = (object)/*Error near IL_0648: Stack underflow*/;
							obj3 = 6;
							continue;
						}
						case 4:
							goto IL_074a;
						}
						break;
					}
					goto IL_0368;
					IL_074a:
					((_003CAddRentalGameCharacterAsync_003Ed__45)this)._003C_003E1__state = -2;
					obj2 = 3;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00需()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779145, new IntPtr(2737336636476L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00頀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00餀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779144, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00騀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779147, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00鬀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00鰀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779146, new IntPtr(2737336613596L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00鴀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779253, new IntPtr(2737336631276L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00鸀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<EntityNetGameItem, string> _003C_003E9__15_2;

		public static Func<EntityNetGameItem, string> _003C_003E9__15_3;

		public static Func<IDesktopSkin, string> _003C_003E9__25_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			_ = EqualityComparer<_00211>.Default;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003CGetNetGamesAsync_003Eb__15_2(EntityNetGameItem n)
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (string)(object)EqualityComparer<_00211>.Default;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003CGetNetGamesAsync_003Eb__15_3(EntityNetGameItem n)
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (string)(object)EqualityComparer<_00211>.Default;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003CGetSkinImagesAsync_003Eb__25_0(IDesktopSkin n)
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (string)(object)EqualityComparer<_00211>.Default;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public string gameId;

		private static object IncludeEvent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass16_0()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			_ = EqualityComparer<_00211>.Default;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetNetGame_003Eb__0(EntityNetGameItem n)
		{
			return _FF00_FF00_FF00_FF00踀(n) != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ReflectStaticResolver()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static _003C_003Ec__DisplayClass16_0 CheckDynamicDecryptor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe byte _FF00_FF00_FF00_FF00贀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779252, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal byte _FF00_FF00_FF00_FF00踀(object P_0)
		{
			//IL_0026: Expected I4, but got Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			_ = EqualityComparer<_00211>.Default;
			_ = ((DesktopAuthentication)this)._003CuserToken_003EP;
			return (byte)(int)EqualityComparer<_00210>.Default;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe byte _FF00_FF00_FF00_FF00輀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779255, new IntPtr(2737336629196L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00退()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00鄀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779254, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00鈀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779249, new IntPtr(2737336637516L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00錀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddGameCharacterAsync_003Ed__44 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityGameCharacter> _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		public EnumGameType type;

		public string gameId;

		public string name;

		private TaskAwaiter<EntityGameCharacter> _003C_003Eu__1;

		internal static object DecorateEditableInitializer;

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
		internal static bool PlanComparator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecodeBridge()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00缀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779261, new IntPtr(2737336621916L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00耀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0075: Expected Obj, but got Ref
			//IL_00c8: Expected Obj, but got Ref
			//IL_00ca: Expected Obj, but got I
			//IL_00d9: Expected Obj, but got I
			//IL_009c: Expected Obj, but got Ref
			//IL_00a3: Expected Obj, but got Ref
			//IL_00b2: Expected Obj, but got I
			//IL_0050: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got Ref
			//IL_01e7: Expected Obj, but got I4
			//IL_01f3: Expected VT, but got Obj
			//IL_01f3: Expected Obj, but got VT
			//IL_01f9: Expected Ref, but got VT
			//IL_020a: Expected native int or pointer, but got Obj
			//IL_0192: Expected Obj, but got Ref
			//IL_0164: Expected Obj, but got Ref
			//IL_0275: Expected I4, but got Obj
			//IL_0286: Expected Obj, but got Ref
			//IL_0291: Expected Obj, but got I4
			//IL_02c3: Expected Obj, but got I4
			//IL_0224: Expected Obj, but got I4
			//IL_0229: Expected VT, but got I4
			//IL_0232: Expected Obj, but got I4
			//IL_029b: Expected Obj, but got I4
			//IL_02a0: Expected Obj, but got I4
			//IL_02a9: Expected Obj, but got I4
			//IL_014a: Expected I4, but got Obj
			//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00de->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00b7->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0096->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00e9->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00c2->IL0026: Incompatible stack heights: 2 vs 1
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0262->IL0115: Incompatible stack types: I4 vs Obj
			//IL_0106->IL0115: Incompatible stack types: I4 vs Obj
			//IL_026d->IL0115: Incompatible stack types: I4 vs Obj
			//IL_0111->IL0115: Incompatible stack types: I4 vs Obj
			//IL_0214->IL0115: Incompatible stack heights: 6 vs 1
			//IL_0180->IL0115: Incompatible stack types: I4 vs Obj
			//IL_027f->IL0115: Incompatible stack types: I4 vs Obj
			//IL_021f->IL0115: Incompatible stack heights: 6 vs 1
			//IL_01ab->IL0115: Incompatible stack types: I4 vs Obj
			//IL_018b->IL0115: Incompatible stack types: I4 vs Obj
			//IL_01b6->IL0115: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 1;
			object obj = awaiter;
			while (true)
			{
				object obj2;
				switch ((int)obj)
				{
				case 3:
					((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP = -2;
					obj = 2;
					if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP == null)
					{
						obj = 1;
					}
					break;
				default:
					awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CserverId_003EP;
					obj = 4;
					if (DesktopAuthentication.Logger == null)
					{
						obj = 1;
					}
					break;
				case 2:
					string.Format((IFormatProvider?)/*Error near IL_00a3: Stack underflow*/, (string)Unsafe.AsPointer(ref DesktopAuthentication.TokenKey), (object?[])awaiter);
					_ = 5;
					if (((DesktopAuthentication)DesktopAuthentication._connected)._buffer != null)
					{
						_ = 0;
					}
					break;
				case 1:
					awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshake;
					obj = 0;
					if (((DesktopAuthentication)DesktopAuthentication._handshakeSent)._handshakeKey == null)
					{
						obj = 0;
					}
					break;
				case 5:
					return;
				case 4:
					{
						if (awaiter != null)
						{
							obj2 = 0;
							if (((DesktopAuthentication)DesktopAuthentication._encryptedToken)._encryptChaCha == null)
							{
								obj2 = 0;
							}
							goto IL_0115;
						}
						goto IL_0246;
					}
					IL_0246:
					awaiter = ((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003E4__this;
					obj2 = 6;
					if (DesktopAuthentication._003CHeartbeatAsync_003Ed__25.ProcessResolver == null)
					{
						obj2 = 5;
					}
					goto IL_0115;
					IL_0115:
					while (true)
					{
						switch ((int)obj2)
						{
						case 11:
							break;
						case 10:
							return;
						case 2:
							Unsafe.As<object, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._decryptChaCha).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CAddGameCharacterAsync_003Ed__44, DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22>(ref this));
							obj2 = 5;
							if (DesktopAuthentication.PrepareDic != null)
							{
								obj2 = 10;
							}
							continue;
						case 1:
							((TimeoutException)/*Error near IL_0192: Stack underflow*/)._002Ector((string?)(&awaiter));
							if ((int)/*Error near IL_0197: Stack underflow*/ != 0)
							{
								obj2 = 1;
								if (((DesktopAuthentication._003CAuthentication_003Ed__27)DesktopAuthentication._003CAuthentication_003Ed__27._003C_003Et__builder)._003C_003E4__this != null)
								{
									obj2 = 3;
								}
								continue;
							}
							goto case 9;
						default:
						{
							((DesktopAuthentication)awaiter)._003CAuthentication_003Eb__27_0();
							new TaskAwaiter();
							_ = ((TaskAwaiter<byte[]>*)((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003Ccts_003E5__2)->IsCompleted;
							((Task)awaiter).GetAwaiter();
							MassService instance = MassService.Instance;
							TaskAwaiter<byte[]> awaiter2 = ((Task<byte[]>)((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003E1__state).GetAwaiter();
							((CancellationTokenSource)awaiter2)._002Ector((TimeSpan)((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003E4__this);
							((AsyncTaskMethodBuilder<EntityNetGameItem[]>*)awaiter2)->Start(ref *(_003CGetNetGamesAsync_003Ed__15*)1);
							((TaskCompletionSource)(object)instance)._002Ector();
							awaiter = instance;
							_ = 0;
							if (((DesktopAuthentication._003CHeartbeatAsync_003Ed__25*)(nint)DesktopAuthentication._003CConnect_003Ed__19.CheckAdjustableCommand)->_003C_003E1__state == 0)
							{
								_ = 1;
							}
							continue;
						}
						case 8:
							awaiter = -1;
							((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-1);
							awaiter = 5;
							goto IL_0111;
						case 7:
							goto IL_0246;
						case 4:
							((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003E1__state = (int)awaiter;
							obj2 = 2;
							continue;
						case 3:
						case 5:
							((IAsyncStateMachine)/*Error near IL_0286: Stack underflow*/).SetStateMachine((IAsyncStateMachine)(&awaiter));
							awaiter = (object)/*Error near IL_0288: Stack underflow*/;
							awaiter = 11;
							goto IL_0111;
						case 9:
							awaiter = 0;
							((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003E4__this = (DesktopAuthentication)0;
							awaiter = 4;
							goto IL_0111;
						case 6:
							{
								Unsafe.As<TaskAwaiter, AsyncTaskMethodBuilder<Entities<EntityNetGameItem>>>(ref ((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003Eu__1) = default;
								awaiter = 8;
								goto IL_0111;
							}
							IL_0111:
							obj2 = awaiter;
							continue;
						}
						break;
					}
					goto case 3;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00脀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779260, new IntPtr(2737336618796L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00舀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00茀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779263, new IntPtr(2737336625036L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00萀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779262, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00蔀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00蘀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddRentalGameCharacterAsync_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		public string gameId;

		public string name;

		private TaskAwaiter _003C_003Eu__1;

		private static object CheckControllableMap;

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
		internal static bool DecorateTransferableVisitor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AssessStrategy()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00琀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779257, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00甀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0075: Expected Obj, but got Ref
			//IL_007a: Expected VT, but got Ref
			//IL_004e: Expected Obj, but got Ref
			//IL_008c: Expected Obj, but got I4
			//IL_008c: Expected Obj, but got Ref
			//IL_00bc: Expected Obj, but got I4
			//IL_01b1: Expected VT, but got Obj
			//IL_01c2: Expected Obj, but got Ref
			//IL_0214: Expected Obj, but got I4
			//IL_0219: Expected Obj, but got I4
			//IL_01eb: Expected Obj, but got I4
			//IL_01f0: Expected VT, but got I4
			//IL_01fa: Expected native int or pointer, but got Obj
			//IL_024e: Expected native int or pointer, but got Obj
			//IL_0147: Expected Obj, but got Ref
			//IL_0159: Expected Obj, but got VT
			//IL_0160: Expected Obj, but got Ref
			//IL_0165: Expected Obj, but got VT
			//IL_016b: Expected Obj, but got I4
			//IL_0170: Expected Obj, but got VT
			//IL_0172: Expected Obj, but got I4
			//IL_017c: Expected native int or pointer, but got Obj
			//IL_00fa: Expected I4, but got Obj
			//IL_01d1: Expected native int or pointer, but got Obj
			//IL_0084->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0347->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00a0->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0275->IL00c5: Incompatible stack types: I4 vs Obj
			//IL_0352->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ab->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01bb->IL00c5: Incompatible stack types: I4 vs Obj
			//IL_022d->IL00c5: Incompatible stack types: I4 vs Obj
			//IL_01a9->IL00c5: Incompatible stack types: I4 vs Obj
			//IL_0204->IL00c5: Incompatible stack types: I4 vs Obj
			//IL_0258->IL00c5: Incompatible stack types: I4 vs Obj
			//IL_0186->IL00c5: Incompatible stack heights: 2 vs 1
			//IL_01db->IL00c5: Incompatible stack types: I4 vs Obj
			//IL_0238->IL00c5: Incompatible stack types: I4 vs Obj
			//IL_020f->IL00c5: Incompatible stack types: I4 vs Obj
			//IL_0263->IL00c5: Incompatible stack types: I4 vs Obj
			//IL_0191->IL00c5: Incompatible stack heights: 2 vs 1
			//IL_01e6->IL00c5: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 3;
			object obj = awaiter;
			while (true)
			{
				object obj2;
				switch ((int)obj)
				{
				case 3:
					awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
					obj = 2;
					if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP == null)
					{
						obj = 2;
					}
					break;
				default:
					((EqualityComparer<_00210>)/*Error near IL_007a: Stack underflow*/).GetHashCode((_00210)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CserverId_003EP));
					_ = 4;
					break;
				case 5:
					DesktopAuthentication.Logger = -2;
					obj = 0;
					if (((DesktopAuthentication)(object)DesktopAuthentication.TokenKey)._client == null)
					{
						obj = 0;
					}
					break;
				case 1:
					if (awaiter != null)
					{
						awaiter = 11;
						obj2 = awaiter;
						goto IL_00c5;
					}
					goto IL_0263;
				case 4:
					return;
				case 2:
					{
						awaiter = DesktopAuthentication._003CReceiveAsync_003Ed__20.CheckCommonTracker;
						obj = 1;
						if ((int)((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22*)DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22._003C_003E1__state)->_003C_003Et__builder == 0)
						{
							obj = 0;
						}
						break;
					}
					IL_0263:
					awaiter = DesktopAuthentication._003CHeartbeatAsync_003Ed__25.ProcessResolver;
					obj2 = 10;
					goto IL_00c5;
					IL_00c5:
					while (true)
					{
						switch ((int)obj2)
						{
						case 7:
							break;
						case 1:
						case 9:
							_ = ref awaiter;
							/*Error near IL_0101: Member reference must be method, but was: Field*/;
						case 8:
							return;
						case 11:
						{
							((DesktopAuthentication)/*Error near IL_013b: Stack underflow*/).ReceiveControlDataAsync(awaiter);
							AsyncTaskMethodBuilder asyncTaskMethodBuilder = new AsyncTaskMethodBuilder();
							((TcpClient)((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptedToken).Close();
							GC.SuppressFinalize(awaiter);
							RuntimeHelpers.InitializeArray((Array)asyncTaskMethodBuilder, (RuntimeFieldHandle)asyncTaskMethodBuilder);
							ILogger exception = ((ILogger)(object)asyncTaskMethodBuilder).Category((string)((DesktopAuthentication)Unsafe.AsPointer(ref this))._authenticationTcs);
							((DesktopAuthentication)1).Dispose();
							awaiter = ((TaskCompletionSource)asyncTaskMethodBuilder).TrySetException((Exception)(object)exception);
							_ = 3;
							if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27._003C_003E4__this)->modHashList == null)
							{
								_ = 3;
							}
							continue;
						}
						case 5:
							Unsafe.As<string, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication._003CAuthentication_003Ed__27)this).serverIdHash).AwaitUnsafeOnCompleted(ref *(ValueTaskAwaiter*)(&awaiter), ref Unsafe.As<_003CAddRentalGameCharacterAsync_003Ed__45, DesktopAuthentication._003CSendMessageAsync_003Ed__29>(ref this));
							obj2 = 8;
							continue;
						case 2:
							((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Eu__1 = (TaskAwaiter<byte[]>)awaiter;
							obj2 = 5;
							continue;
						case 3:
							if ((int)((Task)(&awaiter)).GetAwaiter() != 0)
							{
								obj2 = 1;
								if (((DesktopAuthentication._003CConnect_003Ed__19*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27.ReflectInternalAnnotation)->_003C_003E1__state != 0)
								{
									obj2 = 1;
								}
								continue;
							}
							goto case 6;
						case 6:
							awaiter = 0;
							((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)0;
							obj2 = 2;
							if (((DesktopAuthentication._003CConnect_003Ed__19*)(nint)DesktopAuthentication._003CConnect_003Ed__19._003C_003E4__this)->authServer == null)
							{
								obj2 = 1;
							}
							continue;
						case 4:
							awaiter = -1;
							((DesktopAuthentication._003CConnect_003Ed__19)this)._003Ccts_003E5__2 = -1;
							obj2 = 9;
							if (DesktopAuthentication._003CConnect_003Ed__19.CheckAdjustableCommand != null)
							{
								obj2 = 0;
							}
							continue;
						case 10:
							Unsafe.As<int, @null>(ref ((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003E1__state) = null;
							obj2 = 4;
							if ((int)((DesktopAuthentication._003CHeartbeatAsync_003Ed__25*)(nint)DesktopAuthentication._003CHeartbeatAsync_003Ed__25._003C_003E4__this)->_003C_003Eu__1 != 0)
							{
								obj2 = 2;
							}
							continue;
						default:
							goto IL_0263;
						}
						break;
					}
					goto case 5;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00瘀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779256, new IntPtr(2737336634396L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00眀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00砀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779259, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00礀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779258, new IntPtr(2737336633356L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00稀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00笀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779237, new IntPtr(2737336631276L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00簀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779236, new IntPtr(2737336635436L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00紀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDownloadImageAsync_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public string url;

		public string directoryPath;

		private object _003CimageName_003E5__2;

		private object _003CimagePath_003E5__3;

		private TaskAwaiter<byte[]?> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private static object DecorateSortedElement;

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
		internal static bool PauseConfig()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PushEmitter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00欀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779239, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00氀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0047: Expected I4, but got Obj
			//IL_05e2: Expected VT, but got Obj
			//IL_05bc: Expected Obj, but got Ref
			//IL_05c6: Expected native int or pointer, but got Obj
			//IL_05fa: Expected I4, but got Obj
			//IL_05fa: Expected Obj, but got Ref
			//IL_0604: Expected native int or pointer, but got Obj
			//IL_0066: Expected Obj, but got I4
			//IL_0066: Expected Obj, but got Ref
			//IL_0052: Expected Obj, but got Ref
			//IL_03f8: Expected Obj, but got VT
			//IL_04af: Expected Obj, but got I4
			//IL_04b4: Expected VT, but got I4
			//IL_04be: Expected native int or pointer, but got Obj
			//IL_033e: Expected Obj, but got I4
			//IL_0343: Expected VT, but got I4
			//IL_034d: Expected native int or pointer, but got Obj
			//IL_027a: Expected Obj, but got I4
			//IL_027f: Expected Obj, but got I4
			//IL_03c9: Expected Obj, but got I4
			//IL_03ce: Expected VT, but got I4
			//IL_01f7: Expected native int or pointer, but got Obj
			//IL_04db: Expected Obj, but got VT
			//IL_03b5: Expected Obj, but got Ref
			//IL_01a4: Expected Obj, but got Ref
			//IL_01bb: Expected Obj, but got I4
			//IL_047c: Expected Obj, but got I4
			//IL_047c: Expected VT, but got Ref
			//IL_0495: Expected native int or pointer, but got Obj
			//IL_026b: Expected VT, but got I4
			//IL_0266: Expected native int or pointer, but got Obj
			//IL_0144: Expected Obj, but got Ref
			//IL_015b: Expected Obj, but got I
			//IL_041d: Expected I4, but got Obj
			//IL_041d: Expected I4, but got Obj
			//IL_0422: Expected I4, but got Obj
			//IL_042d: Expected Obj, but got I4
			//IL_02a1: Expected F8, but got VT
			//IL_039f: Expected Obj, but got Ref
			//IL_032d: Expected Obj, but got Ref
			//IL_0379: Expected VT, but got Obj
			//IL_0383: Expected native int or pointer, but got Obj
			//IL_02b0: Expected native int or pointer, but got Obj
			//IL_0139: Expected I4, but got Obj
			//IL_05ec->IL0026: Incompatible stack types: I4 vs Obj
			//IL_05d0->IL0026: Incompatible stack types: I4 vs Obj
			//IL_060e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_007a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_05db->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0619->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0085->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0402->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_00a1->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_00ac->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0254->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_04c8->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0326->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0357->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0289->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_03d8->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0201->IL00b0: Incompatible stack heights: 3 vs 1
			//IL_04e5->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0448->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_049f->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0275->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_0160->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_03f0->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_0470->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_02f6->IL00b0: Incompatible stack heights: 3 vs 1
			//IL_0339->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0296->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_045e->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_038d->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_04d3->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0362->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_020c->IL00b0: Incompatible stack heights: 3 vs 1
			//IL_03c4->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_04aa->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_016b->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_021e->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0301->IL00b0: Incompatible stack heights: 3 vs 1
			//IL_01db->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_02ba->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_03ae->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0398->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_01e6->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_02c5->IL00b0: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 6;
			object obj = awaiter;
			while (true)
			{
				object obj2;
				switch ((int)obj)
				{
				case 6:
					awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
					obj = 5;
					break;
				case 4:
					((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserToken_003EP = -2;
					obj = 2;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
					{
						obj = 0;
					}
					break;
				case 5:
					if (awaiter != null)
					{
						obj2 = 21;
						if (DesktopAuthentication.Logger != null)
						{
							obj2 = 6;
						}
						goto IL_00b0;
					}
					goto IL_03f0;
				case 2:
					((DesktopSession)Unsafe.AsPointer(ref this)).UserDetail__BackingField = null;
					obj = 0;
					if (((_003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed*)(nint)DecorateVisibleDecider)->_003C_003E1__state != 0)
					{
						obj = 0;
					}
					break;
				default:
					((_003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed)this)._003C_003Et__builder = (AsyncTaskMethodBuilder<Entities<EntityNetGameItem>>)null;
					obj = 3;
					break;
				case 1:
					return;
				case 3:
					{
						((BinaryWriter)Unsafe.AsPointer(ref ((_003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed)this)._003C_003E4__this)).Write((byte)(int)awaiter);
						obj = 0;
						if (((_003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed*)(nint)_003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed._003CnetGames_003E5__2)->_003CversionDictionary_003E5__3 != null)
						{
							obj = 1;
						}
						break;
					}
					IL_03f0:
					awaiter = ((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this)._003C_003Eu__1;
					obj2 = 31;
					goto IL_00b0;
					IL_00b0:
					while (true)
					{
						switch ((int)obj2)
						{
						case 5:
						case 15:
							break;
						case 19:
							Unsafe.As<byte[], AsyncTaskMethodBuilder>(ref DesktopAuthentication.TokenKey).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CDownloadImageAsync_003Ed__34, DesktopAuthentication._003CAuthentication_003Ed__27>(ref this));
							obj2 = 1;
							if (((DesktopAuthentication)DesktopAuthentication._connected)._buffer != null)
							{
								obj2 = 1;
							}
							continue;
						case 1:
							return;
						case 16:
						case 23:
							((AsyncTaskMethodBuilder*)((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeKey)->Start<TStateMachine>(ref *(TStateMachine*)awaiter);
							((TcpClient)/*Error near IL_01b0: Stack underflow*/).Close();
							awaiter = (object)/*Error near IL_01b2: Stack underflow*/;
							awaiter = 28;
							goto IL_00ac;
						case 25:
							if (awaiter != null)
							{
								obj2 = 23;
								if (((DesktopAuthentication)DesktopAuthentication._decryptChaCha)._handshakeTcs == null)
								{
									obj2 = 2;
								}
								continue;
							}
							goto case 30;
						case 9:
							_ = ref awaiter;
							_ = Log.Logger;
							_ = 0;
							if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication.PrepareDic)->_003C_003E1__state == 0)
							{
								_ = 0;
							}
							continue;
						case 21:
							if ((nint)awaiter != 1)
							{
								obj2 = 17;
								continue;
							}
							goto case 10;
						default:
							awaiter = ((DesktopAuthentication._003CAuthentication_003Ed__27)this).modHashList;
							obj2 = 5;
							continue;
						case 18:
							Unsafe.Write(&((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)((DesktopAuthentication._003CAuthentication_003Ed__27)this).serverIdHash)->_003C_003Eu__2, (TaskAwaiter)((TaskAwaiter<byte[]>*)((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003Ccts_003E5__2)->IsCompleted);
							_ = 27;
							continue;
						case 6:
							awaiter = 0;
							DesktopAuthentication._003CAuthentication_003Ed__27.ReflectInternalAnnotation = 0;
							obj2 = 22;
							continue;
						case 30:
							awaiter = (object)/*Error near IL_028c: Stack underflow*/;
							obj2 = 15;
							continue;
						case 27:
							if ((int)TimeSpan.FromSeconds((double)((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003Et__builder) != 0)
							{
								obj2 = 7;
								if (((DesktopAuthentication._003CConnect_003Ed__19*)(nint)DesktopAuthentication._003CConnect_003Ed__19.authServer)->_003Ccts_003E5__2 == null)
								{
									obj2 = 11;
								}
								continue;
							}
							goto case 3;
						case 14:
							return;
						case 24:
							_ = ((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003Eu__1;
							_ = 0;
							awaiter = new TaskCompletionSource();
							_ = 18;
							if ((int)((DesktopAuthentication._003CHeartbeatAsync_003Ed__25*)DesktopAuthentication._003CHeartbeatAsync_003Ed__25._003C_003E1__state)->_003C_003Et__builder != 0)
							{
								_ = 26;
							}
							continue;
						case 3:
							((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24*)/*Error near IL_0306: Stack underflow*/)->MoveNext();
							((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24*)/*Error near IL_030b: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_030b: Stack underflow*/);
							((AsyncTaskMethodBuilder<bool>*)DesktopAuthentication._003CHeartbeatAsync_003Ed__25.ProcessResolver)->Start(ref *(_003CGetBuyItemResultAsync_003Ed__28*)((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003E1__state);
							obj2 = 24;
							continue;
						case 29:
							((AsyncTaskMethodBuilder*)/*Error near IL_032d: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)(&awaiter));
							awaiter = (object)/*Error near IL_032f: Stack underflow*/;
							obj2 = 25;
							continue;
						case 4:
							awaiter = -1;
							((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003Eu__1 = (TaskAwaiter)(-1);
							obj2 = 29;
							if (((DesktopAuthentication._003CReceiveAsync_003Ed__20*)(nint)DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24.ReflectMixedRunner)->_003C_003E1__state == 0)
							{
								obj2 = 25;
							}
							continue;
						case 32:
							((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)awaiter;
							obj2 = 19;
							if ((int)((DesktopAuthentication._003CReceiveAsync_003Ed__20*)(nint)DesktopAuthentication._003CReceiveAsync_003Ed__20._003C_003E4__this)->_003C_003Eu__1 == 0)
							{
								obj2 = 19;
							}
							continue;
						case 28:
							((ILogger)/*Error near IL_039f: Stack underflow*/).Warning((Exception)/*Error near IL_039f: Stack underflow*/, (string)(&awaiter));
							if ((int)/*Error near IL_03a4: Stack underflow*/ == 0)
							{
								obj2 = 2;
								continue;
							}
							goto case 9;
						case 12:
							((ILogger)/*Error near IL_03b5: Stack underflow*/).Debug((string)(&awaiter));
							if ((int)/*Error near IL_03ba: Stack underflow*/ == 0)
							{
								obj2 = 6;
								continue;
							}
							goto case 29;
						case 8:
							awaiter = -1;
							((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-1);
							obj2 = 9;
							continue;
						case 20:
							_ = ref ((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this)._003C_003E4__this;
							((AsyncTaskMethodBuilder<EntityGameCharacter>*)(&awaiter))->Start(ref Unsafe.As<_003CDownloadImageAsync_003Ed__34, _003CAddGameCharacterAsync_003Ed__44>(ref this));
							_ = 14;
							continue;
						case 7:
							goto IL_03f0;
						case 26:
						{
							object obj3 = DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22.DecorateBasicTag;
							object obj4 = awaiter;
							*(ValueTask*)(&awaiter) = default;
							awaiter = ((HashAlgorithm)/*Error near IL_0422: Stack underflow*/).ComputeHash((byte[])/*Error near IL_0422: Stack underflow*/, (int)/*Error near IL_0422: Stack underflow*/, (int)Arrays.CopyOfRange((byte[])obj3, (int)obj4, (int)awaiter));
							awaiter = 12;
							goto IL_00ac;
						}
						case 13:
							((DesktopAuthentication._003CReceiveDataAsync_003Ed__21)this).buffer = null;
							obj2 = 8;
							continue;
						case 31:
							Unsafe.As<nint, @null>(ref ((DesktopAuthentication._003CReceiveDataAsync_003Ed__21)this)._003Clength_003E5__2) = null;
							obj2 = 4;
							continue;
						case 22:
							DesktopAuthentication._003CReceiveDataAsync_003Ed__21.CheckActiveRecommender = awaiter;
							obj2 = 20;
							continue;
						case 17:
							((DefaultInterpolatedStringHandler*)/*Error near IL_047c: Stack underflow*/)->AppendFormatted<T>((T)Unsafe.AsPointer(ref this), (string?)((DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23)this)._003C_003E1__state);
							((DefaultInterpolatedStringHandler*)/*Error near IL_0486: Stack underflow*/)->AppendFormatted(((DesktopSession)/*Error near IL_0481: Stack underflow*/).EncryptToken);
							Unsafe.Write(&((DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23*)(nint)/*Error near IL_048b: Stack underflow*/)->_003C_003E4__this, /*Error near IL_048b: Stack underflow*/);
							obj2 = 18;
							if (((DesktopAuthentication._003CSendMessageAsync_003Ed__29*)(nint)DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23.ReflectScalableNotifier)->_003C_003E1__state != 0)
							{
								obj2 = 18;
							}
							continue;
						case 2:
							awaiter = 1;
							((DesktopAuthentication._003CSendMessageAsync_003Ed__29)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)1;
							obj2 = 23;
							if (((DesktopAuthentication._003CSendMessageAsync_003Ed__29*)(nint)DesktopAuthentication._003CSendMessageAsync_003Ed__29._003C_003E4__this)->data == null)
							{
								obj2 = 32;
							}
							continue;
						case 10:
							{
								awaiter = ((DesktopAuthentication._003CSendMessageAsync_003Ed__29)this)._003C_003Eu__1;
								obj2 = 13;
								continue;
							}
							IL_00ac:
							obj2 = awaiter;
							continue;
						}
						break;
					}
					goto case 4;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00洀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779238, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00渀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0044: Expected VT, but got Obj
			//IL_0044: Expected VT, but got Ref
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0044: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
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
		internal unsafe static byte _FF00_FF00_FF00_FF00漀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779233, new IntPtr(2737336618796L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00瀀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00焀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00爀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779232, new IntPtr(2737336621916L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CEntitiesRequestAsync_003Ed__11<T> : IAsyncStateMachine where T : notnull
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T[]> _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		public string url;

		public object body;

		public bool checkCode;

		private TaskAwaiter<Entities<T>> _003C_003Eu__1;

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

		internal static bool ReflectSetObject()
		{
			return true;
		}

		internal static object AnalyzeListener()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CEntityRequestAsync_003Ed__10<T> : IAsyncStateMachine where T : notnull
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		public string url;

		public object body;

		public bool checkCode;

		private TaskAwaiter<Entity<T>> _003C_003Eu__1;

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

		internal static bool ReflectFinalizer()
		{
			return true;
		}

		internal static object ReflectDetachedProgram()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CEntityRequestAsync_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		public string url;

		public object body;

		public bool checkCode;

		private TaskAwaiter<object> _003C_003Eu__1;

		internal static object CheckDetailedTemplate;

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
		internal static bool MonitorDefinition()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckGeneralDecider()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00戀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779235, new IntPtr(2737336628156L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00挀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0077: Expected Obj, but got I4
			//IL_0077: Expected Obj, but got Ref
			//IL_004e: Expected Obj, but got Ref
			//IL_0338: Expected VT, but got Ref
			//IL_015d: Expected Obj, but got Ref
			//IL_0134: Expected Obj, but got I4
			//IL_0139: Expected Obj, but got Ref
			//IL_019e: Expected Obj, but got Ref
			//IL_01a4: Expected Obj, but got Ref
			//IL_01c0: Expected native int or pointer, but got Obj
			//IL_0228: Expected native int or pointer, but got Obj
			//IL_016f: Expected Obj, but got Ref
			//IL_0177: Expected Obj, but got Ref
			//IL_0177: Expected Obj, but got Ref
			//IL_0148: Expected Obj, but got I4
			//IL_014d: Expected Obj, but got Ref
			//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0322->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0342->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0096->IL0026: Incompatible stack types: I4 vs Obj
			//IL_032d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0212->IL00c2: Incompatible stack heights: 2 vs 1
			//IL_018b->IL00c2: Incompatible stack heights: 3 vs 1
			//IL_0196->IL00c2: Incompatible stack heights: 3 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				case 3:
					obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
					obj2 = 1;
					if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP == null)
					{
						obj2 = 2;
					}
					break;
				case 1:
					((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CserverId_003EP = -2;
					obj2 = 5;
					if (DesktopAuthentication.Logger == null)
					{
						obj2 = 4;
					}
					break;
				case 4:
					return;
				default:
					if (obj != null)
					{
						num = 0;
						if (((DesktopAuthentication)(object)DesktopAuthentication.TokenKey)._client == null)
						{
							num = 7;
						}
						goto IL_00c2;
					}
					goto IL_0157;
				case 2:
					obj = DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24.ReflectMixedRunner;
					obj2 = 0;
					if ((int)((DesktopAuthentication._003CReceiveAsync_003Ed__20*)DesktopAuthentication._003CReceiveAsync_003Ed__20._003C_003E1__state)->_003C_003Et__builder != 0)
					{
						obj2 = 0;
					}
					break;
				case 5:
					{
						Task.Delay((TimeSpan)Unsafe.AsPointer(ref ((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003E4__this));
						_ = 4;
						break;
					}
					IL_00c2:
					while (true)
					{
						switch (num)
						{
						case 6:
							break;
						case 3:
							return;
						case 1:
							obj = -1;
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshake = -1;
							num = 8;
							continue;
						case 11:
							obj = 0;
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeSent = 0;
							num = 5;
							continue;
						default:
							goto IL_0157;
						case 10:
							_ = ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptedToken;
							((IEnumerable<byte>)(&obj)).Concat((IEnumerable<byte>)Unsafe.AsPointer(ref this));
							_ = 3;
							if (((DesktopAuthentication)DesktopAuthentication._decryptChaCha)._handshakeTcs != null)
							{
								_ = 1;
							}
							continue;
						case 7:
						{
							object obj3 = obj;
							object? authenticationTcs = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._authenticationTcs;
							((DefaultInterpolatedStringHandler*)DesktopAuthentication.PrepareDic)->AppendFormatted((byte)((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E1__state);
							((IAsyncStateMachine)authenticationTcs).MoveNext();
							obj = obj3;
							num = 2;
							if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27.modHashList)->serverIdHash == null)
							{
								num = 4;
							}
							continue;
						}
						case 4:
							if (((TaskAwaiter<byte[]>*)(&obj))->GetResult() != null)
							{
								num = 2;
								if ((int)((DesktopAuthentication._003CAuthentication_003Ed__27)DesktopAuthentication._003CAuthentication_003Ed__27._003C_003Eu__1)._003C_003Eu__2 == 0)
								{
									num = 2;
								}
								continue;
							}
							goto case 11;
						case 2:
						case 8:
							_ = ref obj;
							_ = MassService.Instance;
							_ = 6;
							continue;
						case 9:
							Unsafe.As<int, AsyncTaskMethodBuilder<EntityRentalGameCharacter[]>>(ref ((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003E1__state) = default;
							num = 1;
							if (((DesktopAuthentication._003CConnect_003Ed__19*)(nint)DesktopAuthentication._003CConnect_003Ed__19._003C_003E4__this)->authServer == null)
							{
								num = 1;
							}
							continue;
						case 5:
							((DesktopAuthentication._003CConnect_003Ed__19)this)._003Ccts_003E5__2 = obj;
							num = 10;
							if (DesktopAuthentication._003CConnect_003Ed__19.CheckAdjustableCommand != null)
							{
								num = 0;
							}
							continue;
						}
						break;
					}
					goto case 1;
					IL_0157:
					obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeKey;
					num = 9;
					goto IL_00c2;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00搀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779234, new IntPtr(2737336627116L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00攀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0044: Expected VT, but got Obj
			//IL_0044: Expected VT, but got Ref
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0044: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP != null)
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
		internal static byte _FF00_FF00_FF00_FF00昀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00最()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00栀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779245, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetAuthItemsAsync_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityAuthItem> _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		public EnumGameType masterType;

		public EnumGameVersion gameVersion;

		private TaskAwaiter<EntityAuthItem> _003C_003Eu__1;

		internal static object LeadRecommender;

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
		internal static bool DecorateVisibleRecord()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectCentralContext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00夀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779244, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00娀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0315: Expected VT, but got Obj
			//IL_031f: Expected native int or pointer, but got Obj
			//IL_033c: Expected Obj, but got VT
			//IL_0075: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got Ref
			//IL_018c: Expected Obj, but got Ref
			//IL_0196: Expected native int or pointer, but got Obj
			//IL_0160: Expected Obj, but got I4
			//IL_0165: Expected Obj, but got I4
			//IL_0165: Expected Obj, but got Ref
			//IL_00fc: Expected Obj, but got I4
			//IL_0101: Expected Obj, but got Ref
			//IL_0214: Expected VT, but got Ref
			//IL_0223: Expected native int or pointer, but got Obj
			//IL_0329->IL0026: Incompatible stack heights: 3 vs 1
			//IL_0346->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0334->IL0026: Incompatible stack heights: 3 vs 1
			//IL_0096->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01f0->IL00c1: Incompatible stack heights: 6 vs 1
			//IL_027b->IL00c1: Incompatible stack heights: 2 vs 1
			//IL_01fb->IL00c1: Incompatible stack heights: 6 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				case 3:
					((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP = -2;
					obj2 = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP == null)
					{
						obj2 = 0;
					}
					break;
				case 2:
					obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CserverId_003EP;
					obj2 = 1;
					if (DesktopAuthentication.Logger == null)
					{
						obj2 = 0;
					}
					break;
				case 5:
					if (obj != null)
					{
						num = 2;
						if (((DesktopAuthentication)(object)DesktopAuthentication.TokenKey)._client == null)
						{
							num = 5;
						}
						goto IL_00c1;
					}
					goto IL_01fb;
				default:
					_ = ref ((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003E4__this;
					Task.Delay((TimeSpan)obj);
					_ = 1;
					if (((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22*)(nint)DesktopAuthentication._003CReceiveAsync_003Ed__20.CheckCommonTracker)->_003C_003E1__state != 0)
					{
						_ = 4;
					}
					break;
				case 1:
					obj = ((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this)._003C_003Et__builder;
					obj2 = 5;
					break;
				case 4:
					return;
					IL_00c1:
					while (true)
					{
						switch (num)
						{
						case 9:
							break;
						case 4:
							obj = 0;
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._connected = 0;
							num = 0;
							if (((DesktopAuthentication)(object)DesktopAuthentication._buffer)._handshake != 0)
							{
								num = 0;
							}
							continue;
						case 2:
							obj = ((AsyncTaskMethodBuilder*)(&obj))->Task;
							num = 8;
							if (((DesktopAuthentication)DesktopAuthentication._handshakeKey)._encryptedToken != null)
							{
								num = 9;
							}
							continue;
						case 7:
							return;
						case 1:
							obj = -1;
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptChaCha = -1;
							num = 2;
							if (((DesktopAuthentication)DesktopAuthentication._decryptChaCha)._handshakeTcs == null)
							{
								num = 2;
							}
							continue;
						default:
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._authenticationTcs = obj;
							num = 3;
							if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication.PrepareDic)->_003C_003E1__state == 0)
							{
								num = 10;
							}
							continue;
						case 5:
							DesktopAuthentication._002Ecctor();
							new IAsyncStateMachine();
							_ = ((TaskAwaiter*)((DesktopAuthentication._003CAuthentication_003Ed__27)this).modHashList)->IsCompleted;
							(((TaskAwaiter<byte[]>*)((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003Ccts_003E5__2)->IsCompleted ? ((AsyncTaskMethodBuilder*)1) : ((AsyncTaskMethodBuilder*)null))->Start(ref *(_003CHeartbeatAsync_003Ed__7*)1);
							obj = MassService.Instance;
							_ = 6;
							if ((int)((DesktopAuthentication._003CConnect_003Ed__19*)DesktopAuthentication._003CConnect_003Ed__19._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								_ = 2;
							}
							continue;
						case 3:
							goto IL_01fb;
						case 6:
							((CancellationTokenSource)/*Error near IL_0214: Stack underflow*/)._002Ector((TimeSpan)(&obj));
							if ((int)/*Error near IL_0219: Stack underflow*/ == 0)
							{
								num = 4;
								if ((int)((DesktopAuthentication._003CConnect_003Ed__19*)(nint)DesktopAuthentication._003CConnect_003Ed__19._003Ccts_003E5__2)->_003C_003Eu__1 != 0)
								{
									num = 2;
								}
								continue;
							}
							goto case 2;
						case 8:
							Unsafe.As<object, AsyncTaskMethodBuilder<EntityItemDownload[]>>(ref DesktopAuthentication._003CConnect_003Ed__19.CheckAdjustableCommand) = default;
							num = 1;
							if (((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)DesktopAuthentication._003CHeartbeatAsync_003Ed__25._003C_003Et__builder)._003C_003E4__this == null)
							{
								num = 0;
							}
							continue;
						case 10:
							_ = ref ((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003Eu__1;
							((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CGetAuthItemsAsync_003Ed__48, _003CGetSkinImagesAsync_003Ed__25>(ref this));
							_ = 7;
							continue;
						}
						break;
					}
					goto case 3;
					IL_01fb:
					obj = ((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003E4__this;
					num = 8;
					goto IL_00c1;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00嬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779247, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00尀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0044: Expected VT, but got Obj
			//IL_0044: Expected VT, but got Ref
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0044: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00崀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779246, new IntPtr(2737336619836L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00帀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779241, new IntPtr(2737336612556L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00开()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00怀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779240, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00愀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetBuyItemResultAsync_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		public string orderId;

		private TaskAwaiter _003C_003Eu__1;

		internal static object SerializeNotifier;

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
		internal static bool ReflectScheduledPolicy()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateFilteredRequester()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00一()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779243, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00伀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_004e: Expected Obj, but got Ref
			//IL_008c: Expected Obj, but got Ref
			//IL_00b6: Expected Obj, but got Ref
			//IL_00e8: Expected Obj, but got I
			//IL_0075: Expected Obj, but got Ref
			//IL_007c: Expected VT, but got Obj
			//IL_007c: Expected Obj, but got Ref
			//IL_0184: Expected Obj, but got Ref
			//IL_0230: Expected Obj, but got I4
			//IL_0235: Expected VT, but got I4
			//IL_023f: Expected native int or pointer, but got Obj
			//IL_02ca: Expected VT, but got Obj
			//IL_01e0: Expected native int or pointer, but got Obj
			//IL_020c: Expected Obj, but got I4
			//IL_0216: Expected native int or pointer, but got Obj
			//IL_0297: Expected native int or pointer, but got Obj
			//IL_01b8: Expected Obj, but got I4
			//IL_01be: Expected Obj, but got I4
			//IL_01fa: Expected Obj, but got I4
			//IL_01ff: Expected VT, but got I4
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00a2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ca->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0086->IL0026: Incompatible stack heights: 2 vs 1
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ad->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00d5->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01ea->IL0144: Incompatible stack heights: 2 vs 1
			//IL_02a1->IL0144: Incompatible stack heights: 2 vs 1
			//IL_01f5->IL0144: Incompatible stack heights: 2 vs 1
			//IL_02ac->IL0144: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			object obj2 = obj;
			while (true)
			{
				int num2;
				switch ((int)obj2)
				{
				default:
					obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
					obj2 = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP == null)
					{
						obj2 = 3;
					}
					continue;
				case 5:
					((EqualityComparer<_00210>)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CserverId_003EP)).GetHashCode((_00210)obj);
					_ = 4;
					continue;
				case 1:
					obj = DesktopAuthentication.Logger;
					obj2 = 0;
					if (((DesktopAuthentication)(object)DesktopAuthentication.TokenKey)._client != null)
					{
						obj2 = 0;
					}
					continue;
				case 4:
					return;
				case 2:
					break;
				case 3:
					{
						int num = 0;
						if (((DesktopAuthentication)DesktopAuthentication._handshakeSent)._handshakeKey == null)
						{
							num = 1;
						}
						while (true)
						{
							switch (num)
							{
							case 1:
								num = 0;
								if (((DesktopAuthentication)DesktopAuthentication._encryptedToken)._encryptChaCha != null)
								{
									num = 0;
								}
								continue;
							}
							break;
						}
						if (obj != null)
						{
							num2 = 10;
							goto IL_0144;
						}
						goto IL_017e;
					}
					IL_0144:
					while (true)
					{
						switch (num2)
						{
						case 9:
							return;
						case 2:
							break;
						case 1:
							goto end_IL_0144;
						case 10:
						{
							object obj3 = ((DesktopAuthentication)/*Error near IL_01ac: Stack underflow*/).SendMessageAsync(obj);
							int num3 = ((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E1__state;
							TaskCompletionSource taskCompletionSource = (TaskCompletionSource)new TaskCompletionSource((Exception)6);
							((DesktopAuthentication)1)._003CConnect_003Eb__19_0();
							((AsyncTaskMethodBuilder*)obj3)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)num3, ref *(TStateMachine*)taskCompletionSource);
							obj = (object)/*Error near IL_01c5: Stack underflow*/;
							num2 = 7;
							continue;
						}
						case 5:
							_ = ((TaskAwaiter*)(&obj))->IsCompleted;
							_ = 1;
							if ((int)((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27._003Ccts_003E5__2)->_003C_003Eu__1 != 0)
							{
								_ = 6;
							}
							continue;
						case 11:
							obj = -1;
							((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Eu__2 = (TaskAwaiter)(-1);
							num2 = 5;
							continue;
						case 6:
							obj = 1;
							num2 = 2;
							if (((DesktopAuthentication._003CConnect_003Ed__19*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27.ReflectInternalAnnotation)->_003C_003E1__state == 0)
							{
								num2 = 2;
							}
							continue;
						default:
							obj = 0;
							((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)0;
							num2 = 2;
							if (((DesktopAuthentication._003CConnect_003Ed__19*)(nint)DesktopAuthentication._003CConnect_003Ed__19._003C_003E4__this)->authServer == null)
							{
								num2 = 4;
							}
							continue;
						case 7:
							((TaskAwaiter*)(&obj))->GetResult();
							if ((int)/*Error near IL_0260: Stack underflow*/ == 0)
							{
								num2 = 0;
								if (DesktopAuthentication._003CConnect_003Ed__19.CheckAdjustableCommand == null)
								{
									num2 = 0;
								}
								continue;
							}
							goto case 5;
						case 8:
							_ = ref ((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003E1__state;
							((AsyncTaskMethodBuilder<EntitySkinItem[]>*)(&obj))->Start(ref Unsafe.As<_003CGetBuyItemResultAsync_003Ed__28, _003CGetSkinsByIdAsync_003Ed__22>(ref this));
							_ = 9;
							if ((int)((DesktopAuthentication._003CHeartbeatAsync_003Ed__25*)(nint)DesktopAuthentication._003CHeartbeatAsync_003Ed__25._003C_003E4__this)->_003C_003Eu__1 == 0)
							{
								_ = 1;
							}
							continue;
						case 3:
							Unsafe.As<object, nint>(ref DesktopAuthentication._003CHeartbeatAsync_003Ed__25.ProcessResolver) = default;
							num2 = 11;
							continue;
						case 4:
							((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)obj;
							num2 = 8;
							continue;
						}
						goto end_IL_0026;
						continue;
						end_IL_0144:
						break;
					}
					goto IL_017e;
					IL_017e:
					obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._decryptChaCha;
					num2 = 3;
					if (((DesktopAuthentication)DesktopAuthentication._handshakeTcs)._authenticationTcs == null)
					{
						num2 = 3;
					}
					goto IL_0144;
					end_IL_0026:
					break;
				}
				((DesktopAuthentication)Unsafe.AsPointer(ref this))._connected = -2;
				obj2 = 0;
				if (((DesktopAuthentication)(object)DesktopAuthentication._buffer)._handshake == 0)
				{
					obj2 = 5;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00倀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779242, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00儀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0044: Expected VT, but got Obj
			//IL_0044: Expected VT, but got Ref
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0044: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00刀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779221, new IntPtr(2737336627116L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00匀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779220, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00吀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00唀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779223, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00嘀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779222, new IntPtr(2737336618796L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00圀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetCppGameClientInfo_003Ed__57 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityCppGameClientInfo> _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		private TaskAwaiter<EntityCppGameClientInfo> _003C_003Eu__1;

		private static object AwakeParser;

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
		internal static bool CloneState()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckExternalWrapper()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00䘀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779217, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00䜀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_004f: Expected Obj, but got Ref
			//IL_0056: Expected VT, but got Obj
			//IL_0056: Expected VT, but got Ref
			//IL_00b4: Expected Obj, but got Ref
			//IL_00b6: Expected Obj, but got I
			//IL_00a2: Expected Obj, but got Ref
			//IL_007d: Expected Obj, but got I4
			//IL_007d: Expected Obj, but got Ref
			//IL_0157: Expected Obj, but got Ref
			//IL_0162: Expected Obj, but got I4
			//IL_0120: Expected I4, but got Obj
			//IL_012b: Expected Obj, but got Ref
			//IL_0205: Expected Ref, but got VT
			//IL_01ca: Expected native int or pointer, but got Obj
			//IL_01e4: Expected Obj, but got I4
			//IL_01e9: Expected Obj, but got I4
			//IL_0142: Expected Obj, but got I4
			//IL_0147: Expected Obj, but got I4
			//IL_0147: Expected Obj, but got Ref
			//IL_022c: Expected Obj, but got Ref
			//IL_0186: Expected Obj, but got Ref
			//IL_016e: Expected Obj, but got Ref
			//IL_0179: Expected Obj, but got I4
			//IL_006a->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00ca->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ae->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0091->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0075->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00e7->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_00d5->IL0026: Incompatible stack types: I4 vs Obj
			//IL_009c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_013d->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0216->IL00eb: Incompatible stack heights: 3 vs 1
			//IL_01d4->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_01f3->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0151->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_019a->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_01df->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0245->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_01a5->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0250->IL00eb: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 3;
			object obj = awaiter;
			while (true)
			{
				object obj2;
				switch ((int)obj)
				{
				case 4:
					return;
				default:
					((EqualityComparer<_00211>)/*Error near IL_0056: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)awaiter);
					_ = 4;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
					{
						_ = 4;
					}
					break;
				case 5:
					DesktopAuthentication.Crc32 = -2;
					obj = 0;
					if (DesktopAuthentication.TokenKey == null)
					{
						obj = 0;
					}
					break;
				case 3:
					awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._client;
					obj = 2;
					break;
				case 2:
					awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._connected;
					obj = 1;
					if (((DesktopAuthentication)(object)DesktopAuthentication._buffer)._handshake == 0)
					{
						obj = 0;
					}
					break;
				case 1:
					{
						if (awaiter != null)
						{
							obj2 = 2;
							goto IL_00eb;
						}
						goto IL_0151;
					}
					IL_0151:
					awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptChaCha;
					awaiter = 5;
					goto IL_00e7;
					IL_00e7:
					obj2 = awaiter;
					goto IL_00eb;
					IL_00eb:
					while (true)
					{
						switch ((int)obj2)
						{
						case 4:
							return;
						case 6:
							break;
						case 1:
							Unsafe.As<nint, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeSent).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CGetCppGameClientInfo_003Ed__57, DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24>(ref this));
							obj2 = 4;
							continue;
						case 8:
							awaiter = -1;
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptedToken = -1;
							obj2 = 11;
							continue;
						case 3:
							goto IL_0151;
						default:
							goto IL_0167;
						case 10:
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeTcs = awaiter;
							obj2 = 0;
							if (DesktopAuthentication.PrepareDic == null)
							{
								obj2 = 1;
							}
							continue;
						case 5:
							Unsafe.As<int, AsyncTaskMethodBuilder<EntitySkinItem[]>>(ref ((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E1__state) = default;
							obj2 = 8;
							if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27._003C_003E4__this)->modHashList != null)
							{
								obj2 = 7;
							}
							continue;
						case 7:
							awaiter = 0;
							((DesktopAuthentication._003CAuthentication_003Ed__27)this).serverIdHash = (string)0;
							obj2 = 10;
							continue;
						case 2:
							DesktopAuthentication.ReflectExtendedAuditor();
							(new TaskAwaiter<byte[]>() ? ((AsyncTaskMethodBuilder*)1) : ((AsyncTaskMethodBuilder*)null))->Start(ref *(_003CHeartbeatAsync_003Ed__7*)1);
							awaiter = MassService.Instance;
							_ = 9;
							continue;
						case 9:
							if (((MassService)/*Error near IL_022c: Stack underflow*/).JoinServerAsync((byte[])/*Error near IL_022c: Stack underflow*/, (string)/*Error near IL_022c: Stack underflow*/, (string)/*Error near IL_022c: Stack underflow*/, (string)/*Error near IL_022c: Stack underflow*/, (string)/*Error near IL_022c: Stack underflow*/, (string)(&awaiter)) != null)
							{
								obj2 = 0;
								if (((DesktopAuthentication._003CConnect_003Ed__19)DesktopAuthentication._003CConnect_003Ed__19._003C_003Et__builder)._003C_003E4__this != null)
								{
									obj2 = 0;
								}
								continue;
							}
							goto case 7;
						}
						break;
					}
					goto case 5;
					IL_0167:
					GC.SuppressFinalize((object)(&awaiter));
					awaiter = (object)/*Error near IL_0170: Stack underflow*/;
					awaiter = 6;
					goto IL_00e7;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00䠀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779216, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00䤀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0044: Expected VT, but got Obj
			//IL_0044: Expected VT, but got Ref
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0044: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP != null)
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
		internal static byte _FF00_FF00_FF00_FF00䨀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00䬀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00䰀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779219, new IntPtr(2737336617756L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetGameCharactersAsync_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityGameCharacter[]> _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		public EnumGameType type;

		public string gameId;

		private TaskAwaiter<EntityGameCharacter[]> _003C_003Eu__1;

		internal static object ReadStruct;

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
		internal static bool ReflectVirtualContainer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateIdentifiableConverter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00㴀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779218, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00㸀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0050: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got Ref
			//IL_02c5: Expected Obj, but got VT
			//IL_02cf: Expected native int or pointer, but got Obj
			//IL_0060: Expected Obj, but got Ref
			//IL_00d3: Expected Obj, but got Ref
			//IL_01da: Expected Obj, but got VT
			//IL_01e0: Expected Ref, but got VT
			//IL_01e5: Expected Obj, but got Unknown
			//IL_0181: Expected Obj, but got Ref
			//IL_0189: Expected Obj, but got Ref
			//IL_0125: Expected I, but got Obj
			//IL_0125: Expected Obj, but got Ref
			//IL_0134: Expected Obj, but got I
			//IL_00f9: Expected Obj, but got I4
			//IL_00fe: Expected Obj, but got I4
			//IL_00fe: Expected Obj, but got Ref
			//IL_010d: Expected Obj, but got I
			//IL_019a: Expected Obj, but got Ref
			//IL_01f6: Expected Obj, but got I4
			//IL_01fb: Expected VT, but got I4
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02d9->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0305->IL0026: Incompatible stack heights: 3 vs 1
			//IL_02e4->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0310->IL0026: Incompatible stack heights: 3 vs 1
			//IL_0193->IL0097: Incompatible stack heights: 3 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object stateMachine = 3;
			object obj = stateMachine;
			while (true)
			{
				int num;
				switch ((int)obj)
				{
				case 1:
					((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP = -2;
					obj = 4;
					break;
				case 3:
					stateMachine = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserToken_003EP;
					obj = 2;
					break;
				default:
					if (stateMachine != null)
					{
						num = 0;
						if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
						{
							num = 0;
						}
						goto IL_0097;
					}
					goto IL_00cd;
				case 2:
					stateMachine = ((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003Et__builder;
					obj = 0;
					if ((int)((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24*)(nint)DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj = 0;
					}
					break;
				case 4:
					_ = ref DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24.ReflectMixedRunner;
					_ = ((EntityAuthServer)stateMachine).Port;
					_ = 4;
					if (((DesktopAuthentication._003CReceiveAsync_003Ed__20)DesktopAuthentication._003CReceiveAsync_003Ed__20._003C_003Et__builder)._003C_003E4__this == null)
					{
						_ = 5;
					}
					break;
				case 5:
					return;
					IL_00cd:
					stateMachine = DesktopAuthentication.Crc32;
					num = 0;
					if (DesktopAuthentication.TokenKey == null)
					{
						num = 1;
					}
					goto IL_0097;
					IL_0097:
					while (true)
					{
						switch (num)
						{
						case 8:
							break;
						case 6:
							goto IL_00cd;
						case 4:
							stateMachine = -1;
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._client = -1;
							num = 5;
							if (((DesktopAuthentication)DesktopAuthentication._connected)._buffer == null)
							{
								num = 0;
							}
							continue;
						case 3:
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshake = (nint)stateMachine;
							num = 2;
							if (((DesktopAuthentication)DesktopAuthentication._handshakeSent)._handshakeKey != null)
							{
								num = 0;
							}
							continue;
						case 5:
							((AsyncTaskMethodBuilder*)/*Error near IL_014b: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)(&stateMachine));
							stateMachine = (object)/*Error near IL_014d: Stack underflow*/;
							num = 8;
							continue;
						case 7:
							return;
						case 2:
							_ = ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeTcs;
							((IEnumerable<byte>)(&stateMachine)).Skip((int)Unsafe.AsPointer(ref this));
							_ = 7;
							continue;
						case 9:
							if (((ILogger)/*Error near IL_019a: Stack underflow*/).Category((string)(&stateMachine)) == null)
							{
								num = 10;
								continue;
							}
							goto case 5;
						default:
						{
							((DesktopAuthentication)stateMachine).Dispose();
							TaskCompletionSource taskCompletionSource = (TaskCompletionSource)new TaskCompletionSource((Exception)/*Error near IL_01b5: Stack underflow*/);
							((AsyncTaskMethodBuilder*)taskCompletionSource)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)taskCompletionSource, ref *(TStateMachine*)((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E4__this);
							_003F val = /*Error near IL_01c1: Stack underflow*/;
							byte[] result = (((TaskAwaiter*)stateMachine)->IsCompleted ? ((TaskAwaiter<byte[]>*)1) : ((TaskAwaiter<byte[]>*)null))->GetResult();
							((AsyncTaskMethodBuilder*)((Task)((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Eu__1).GetAwaiter())->Start(ref *(_003CEntityRequestAsync_003Ed__9*)1);
							stateMachine = ((MassService)/*Error near IL_01e5: Stack underflow*/).JoinServerAsync((byte[])/*Error near IL_01e5: Stack underflow*/, (string)/*Error near IL_01e5: Stack underflow*/, (string)/*Error near IL_01e5: Stack underflow*/, (string)val, (string)(object)result, (string)(object)result);
							num = 9;
							continue;
						}
						case 10:
							stateMachine = 0;
							((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)0;
							num = 3;
							continue;
						case 1:
							Unsafe.As<DesktopAuthentication, AsyncTaskMethodBuilder<EntityNetGameAddress>>(ref ((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003E4__this) = default;
							num = 4;
							continue;
						}
						break;
					}
					goto case 1;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00㼀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779229, new IntPtr(2737336612556L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00䀀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779228, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00䄀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0044: Expected VT, but got Obj
			//IL_0044: Expected VT, but got Ref
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0044: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
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
		internal unsafe static byte _FF00_FF00_FF00_FF00䈀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779231, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00䌀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00䐀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetGamePatchInfoAsync_003Ed__54 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityGameClientPatch> _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		public EnumGameVersion gameVersion;

		private TaskAwaiter<EntityGameClientPatch> _003C_003Eu__1;

		internal static object CheckInterruptibleVerifier;

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
		internal static bool ReflectCustomizableAnnotation()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckInternalComparator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_3300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779230, new IntPtr(2737336613596L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00㐀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0061: Expected Obj, but got Ref
			//IL_004e: Expected Obj, but got Ref
			//IL_008d: Expected Obj, but got Ref
			//IL_00b6: Expected Obj, but got Ref
			//IL_01f9: Expected Obj, but got Ref
			//IL_020f: Expected Obj, but got Ref
			//IL_0211: Expected Obj, but got VT
			//IL_021b: Expected native int or pointer, but got Obj
			//IL_01e3: Expected Obj, but got I4
			//IL_01e8: Expected Obj, but got I4
			//IL_023e: Expected Obj, but got Ref
			//IL_023e: Expected Obj, but got Ref
			//IL_0247: Expected Obj, but got I4
			//IL_014e: Expected Obj, but got Ref
			//IL_0153: Expected VT, but got Obj
			//IL_01d4: Expected VT, but got Obj
			//IL_012b: Expected Obj, but got Ref
			//IL_0184: Expected Obj, but got I4
			//IL_0189: Expected Obj, but got I4
			//IL_0193: Expected native int or pointer, but got Obj
			//IL_007c->IL0026: Incompatible stack heights: 4 vs 1
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00a3->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ca->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0087->IL0026: Incompatible stack heights: 4 vs 1
			//IL_00ae->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00d5->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00eb->IL00eb: Incompatible stack heights: 3 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				case 3:
					obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
					obj2 = 2;
					continue;
				case 1:
					return;
				default:
					_ = ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserToken_003EP;
					_ = EqualityComparer<_00210>.Default;
					_ = 1;
					if (DesktopAuthentication.Crc32 == null)
					{
						_ = 0;
					}
					continue;
				case 4:
					obj = DesktopAuthentication.Logger;
					obj2 = 3;
					if (((DesktopAuthentication)(object)DesktopAuthentication.TokenKey)._client == null)
					{
						obj2 = 1;
					}
					continue;
				case 5:
					break;
				case 2:
					{
						if (obj != null)
						{
							num = 5;
							goto IL_00eb;
						}
						goto IL_024c;
					}
					IL_024c:
					obj = DesktopAuthentication._003CConnect_003Ed__19.CheckAdjustableCommand;
					num = 9;
					goto IL_00eb;
					IL_00eb:
					while (true)
					{
						switch (num)
						{
						case 7:
							return;
						case 6:
							break;
						case 9:
							Unsafe.As<nint, _003CEntitiesRequestAsync_003Ed__11<_0021_00210>>(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeSent) = default;
							num = 10;
							continue;
						case 5:
						{
							object logger = ((DesktopAuthentication)obj).HeartbeatCircleAsync();
							TcpClient tcpClient = (TcpClient)new TcpClient();
							RuntimeHelpers.InitializeArray((Array)(object)tcpClient, (RuntimeFieldHandle)((DesktopAuthentication)Unsafe.AsPointer(ref this))._decryptChaCha);
							obj = ((ILogger)logger).Category((string)(object)((IEnumerable<byte>)tcpClient).Skip(1));
							num = 0;
							if ((int)((DesktopAuthentication._003CAuthentication_003Ed__27*)DesktopAuthentication._003CAuthentication_003Ed__27._003C_003E1__state)->_003C_003Et__builder != 0)
							{
								num = 0;
							}
							continue;
						}
						case 10:
							obj = -1;
							((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E4__this = (DesktopAuthentication)(-1);
							num = 2;
							if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27.modHashList)->serverIdHash == null)
							{
								num = 2;
							}
							continue;
						case 8:
							((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Eu__2 = (TaskAwaiter)obj;
							num = 4;
							continue;
						case 3:
							obj = 0;
							DesktopAuthentication._003CAuthentication_003Ed__27.ReflectInternalAnnotation = 0;
							num = 8;
							continue;
						default:
							if (((MassService)/*Error near IL_01f9: Stack underflow*/).JoinServerAsync((byte[])/*Error near IL_01f9: Stack underflow*/, (string)/*Error near IL_01f9: Stack underflow*/, (string)/*Error near IL_01f9: Stack underflow*/, (string)/*Error near IL_01f9: Stack underflow*/, (string)/*Error near IL_01f9: Stack underflow*/, (string)(&obj)) != null)
							{
								num = 11;
								continue;
							}
							goto case 3;
						case 2:
						case 11:
							obj = ((Task<byte[]>)(&obj)).GetAwaiter();
							num = 1;
							if (((DesktopAuthentication._003CConnect_003Ed__19*)(nint)DesktopAuthentication._003CConnect_003Ed__19._003C_003E4__this)->authServer != null)
							{
								num = 6;
							}
							continue;
						case 4:
							_ = ref ((DesktopAuthentication._003CConnect_003Ed__19)this)._003Ccts_003E5__2;
							((IEnumerable<EntityNetGameItem>)(&obj)).FirstOrDefault((Func<EntityNetGameItem, bool>)Unsafe.AsPointer(ref this));
							obj = 7;
							continue;
						case 1:
							goto end_IL_00eb;
						}
						goto end_IL_0026;
						continue;
						end_IL_00eb:
						break;
					}
					goto IL_024c;
					end_IL_0026:
					break;
				}
				((DesktopAuthentication)Unsafe.AsPointer(ref this))._connected = -2;
				obj2 = 0;
				if (((DesktopAuthentication)(object)DesktopAuthentication._buffer)._handshake == 0)
				{
					obj2 = 0;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00㔀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779225, new IntPtr(2737336636476L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00㘀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0044: Expected VT, but got Obj
			//IL_0044: Expected VT, but got Ref
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0044: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00㜀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779224, new IntPtr(2737336637516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00㠀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779227, new IntPtr(2737336629196L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00㤀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00㨀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779226, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00㬀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetItemChannelAsync_003Ed__42 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityItemChannel[]> _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		public List<string> itemIdList;

		public int channelId;

		private TaskAwaiter<EntityItemChannel[]> _003C_003Eu__1;

		internal static object ReflectExpandableBridge;

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
		internal static bool DecorateHiddenCommand()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckAdjustableConsumer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_2A00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779205, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_2B00()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0300: Expected VT, but got I4
			//IL_030a: Expected native int or pointer, but got Obj
			//IL_004e: Expected Obj, but got Ref
			//IL_02ac: Expected Obj, but got VT
			//IL_02b6: Expected native int or pointer, but got Obj
			//IL_00c5: Expected Obj, but got Ref
			//IL_00d0: Expected Obj, but got I4
			//IL_00ba: Expected I4, but got Obj
			//IL_01b9: Expected Obj, but got I4
			//IL_0183: Expected Obj, but got Ref
			//IL_00dd: Expected Obj, but got Ref
			//IL_01a1: Expected Obj, but got I4
			//IL_01a6: Expected Obj, but got I4
			//IL_0151: Expected Obj, but got I4
			//IL_0156: Expected Obj, but got I4
			//IL_0156: Expected Obj, but got Ref
			//IL_0160: Expected native int or pointer, but got Obj
			//IL_01e7: Expected Obj, but got I4
			//IL_0314->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02c0->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02ed->IL0026: Incompatible stack heights: 2 vs 1
			//IL_031f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02cb->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0076->IL0085: Incompatible stack types: I4 vs Obj
			//IL_02f8->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0081->IL0085: Incompatible stack types: I4 vs Obj
			//IL_01c3->IL0085: Incompatible stack types: I4 vs Obj
			//IL_0202->IL0085: Incompatible stack types: I4 vs Obj
			//IL_018d->IL0085: Incompatible stack heights: 3 vs 1
			//IL_00f1->IL0085: Incompatible stack types: I4 vs Obj
			//IL_01b0->IL0085: Incompatible stack types: I4 vs Obj
			//IL_016a->IL0085: Incompatible stack types: I4 vs Obj
			//IL_00fc->IL0085: Incompatible stack types: I4 vs Obj
			//IL_0175->IL0085: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				default:
					return;
				case 2:
					obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
					obj2 = 4;
					continue;
				case 4:
					if (obj != null)
					{
						obj3 = 0;
						if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP != null)
						{
							obj3 = 0;
						}
						goto IL_0085;
					}
					goto IL_00bf;
				case 3:
					obj = ((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003Et__builder;
					obj2 = 1;
					if ((int)((DesktopAuthentication._003CHeartbeatAsync_003Ed__25*)(nint)DesktopAuthentication._003CHeartbeatAsync_003Ed__25._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj2 = 2;
					}
					continue;
				case 0:
					return;
				case 5:
					_ = ref DesktopAuthentication._003CHeartbeatAsync_003Ed__25.ProcessResolver;
					((AsyncTaskMethodBuilder*)obj)->SetResult();
					_ = 0;
					if (((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24._003C_003Et__builder)._003C_003E4__this != null)
					{
						_ = 0;
					}
					continue;
				case 1:
					break;
					IL_0081:
					obj3 = obj;
					goto IL_0085;
					IL_0085:
					while (true)
					{
						switch ((int)obj3)
						{
						case 4:
							break;
						case 6:
							DesktopAuthentication.Crc32 = obj;
							obj3 = 5;
							if (DesktopAuthentication.TokenKey != null)
							{
								obj3 = 5;
							}
							continue;
						default:
							((DesktopAuthentication)/*Error near IL_0103: Stack underflow*/)._002Ector((string)/*Error near IL_0103: Stack underflow*/, (string)/*Error near IL_0103: Stack underflow*/, (string)/*Error near IL_0103: Stack underflow*/, (string)obj);
							/*Error near IL_0103: Member reference must be method, but was: Field*/;
						case 10:
							obj = -1;
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._authenticationTcs = -1;
							obj3 = 0;
							if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication.PrepareDic)->_003C_003E1__state != 0)
							{
								obj3 = 1;
							}
							continue;
						case 5:
							_ = ref ((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Et__builder;
							((IEnumerable<byte>)(&obj)).Take((int)Unsafe.AsPointer(ref this));
							_ = 3;
							continue;
						case 7:
							obj = 0;
							((DesktopAuthentication._003CAuthentication_003Ed__27)this).modHashList = (string)0;
							obj3 = 6;
							continue;
						case 1:
						case 11:
							obj = ((TaskAwaiter*)(&obj))->IsCompleted;
							obj3 = 8;
							continue;
						case 3:
							return;
						case 9:
							if (((TaskAwaiter<byte[]>*)(&obj))->GetResult() == null)
							{
								goto case 7;
							}
							goto IL_01de;
						case 2:
							Unsafe.As<TaskAwaiter<byte[]>, AsyncTaskMethodBuilder<EntityUserDetail>>(ref ((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Eu__1) = default;
							obj3 = 10;
							continue;
						case 8:
							goto end_IL_0026;
						}
						break;
					}
					goto IL_00bf;
					IL_01de:
					obj = 11;
					goto IL_0081;
					IL_00bf:
					obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CserverId_003EP;
					obj = 2;
					goto IL_0081;
					end_IL_0026:
					break;
				}
				((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003Eu__1 = (TaskAwaiter)(-2);
				obj2 = 2;
				if (((DesktopAuthentication._003CReceiveAsync_003Ed__20*)(nint)DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24.ReflectMixedRunner)->_003C_003E1__state == 0)
				{
					obj2 = 5;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00Ⰰ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779204, new IntPtr(2737336620876L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00ⴀ(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0044: Expected VT, but got Obj
			//IL_0044: Expected VT, but got Ref
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0044: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
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
		internal static byte _FF00_FF00_FF00_FF00_2E00()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_2F00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779207, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_3000()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_3100()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779206, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetItemDownloadAsync_003Ed__49 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityItemDownload> _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		public ulong itemId;

		private TaskAwaiter<EntityItemDownload> _003C_003Eu__1;

		internal static object ReflectGenericStrategy;

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
		internal static bool DecorateRandomSorter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectCustomConfig()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_2100()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779201, new IntPtr(2737336627116L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_2200()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_02c7: Expected Obj, but got VT
			//IL_02d1: Expected native int or pointer, but got Obj
			//IL_02ee: Expected Obj, but got VT
			//IL_0050: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got Ref
			//IL_0176: Expected Obj, but got Ref
			//IL_0181: Expected Obj, but got I4
			//IL_0181: Expected I4, but got Obj
			//IL_0188: Expected Obj, but got I4
			//IL_01a9: Expected Obj, but got I4
			//IL_01ae: Expected Obj, but got I4
			//IL_01b8: Expected native int or pointer, but got Obj
			//IL_00fe: Expected Obj, but got Ref
			//IL_0157: Expected Obj, but got Ref
			//IL_01d2: Expected Obj, but got I4
			//IL_01d7: Expected VT, but got I4
			//IL_020b: Expected Obj, but got I4
			//IL_00cf: Expected I4, but got Obj
			//IL_030f->IL0026: Incompatible stack heights: 3 vs 1
			//IL_02db->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02f8->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0192->IL009a: Incompatible stack types: I4 vs Obj
			//IL_008b->IL009a: Incompatible stack types: I4 vs Obj
			//IL_02e6->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0096->IL009a: Incompatible stack types: I4 vs Obj
			//IL_0231->IL009a: Incompatible stack types: I4 vs Obj
			//IL_01c2->IL009a: Incompatible stack types: I4 vs Obj
			//IL_011a->IL009a: Incompatible stack types: I4 vs Obj
			//IL_0163->IL009a: Incompatible stack types: I4 vs Obj
			//IL_01eb->IL009a: Incompatible stack types: I4 vs Obj
			//IL_01a4->IL009a: Incompatible stack types: I4 vs Obj
			//IL_01cd->IL009a: Incompatible stack types: I4 vs Obj
			//IL_0125->IL009a: Incompatible stack types: I4 vs Obj
			//IL_0145->IL009a: Incompatible stack types: I4 vs Obj
			//IL_01f6->IL009a: Incompatible stack types: I4 vs Obj
			//IL_0150->IL009a: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 3;
			object obj = awaiter;
			while (true)
			{
				object obj2;
				RuntimeHelpers runtimeHelpers;
				switch ((int)obj)
				{
				case 5:
					((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP = -2;
					obj = 1;
					if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP == null)
					{
						obj = 0;
					}
					break;
				default:
					if (awaiter == null)
					{
						obj2 = 9;
						if (DesktopAuthentication.Crc32 == null)
						{
							obj2 = 6;
						}
						goto IL_009a;
					}
					goto IL_0163;
				case 4:
					return;
				case 2:
					awaiter = ((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003Eu__1;
					obj = 0;
					if (((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24*)(nint)DesktopAuthentication._003CHeartbeatAsync_003Ed__25.ProcessResolver)->_003C_003E1__state == 0)
					{
						obj = 0;
					}
					break;
				case 3:
					awaiter = ((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003Et__builder;
					obj = 2;
					break;
				case 1:
					{
						_ = ref ((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003E4__this;
						_ = ((EntityAuthServer)awaiter).Ip;
						_ = 4;
						break;
					}
					IL_0163:
					((DesktopAuthentication)awaiter).Disconnect();
					runtimeHelpers = (RuntimeHelpers)new RuntimeHelpers((Array)/*Error near IL_016f: Stack underflow*/, (RuntimeFieldHandle)/*Error near IL_016f: Stack underflow*/);
					((DefaultInterpolatedStringHandler*)runtimeHelpers)->AppendFormatted((byte)(int)((ILogger)(object)runtimeHelpers).Category((string)((DesktopAuthentication)Unsafe.AsPointer(ref this))._authenticationTcs), (string?)1);
					awaiter = ((TaskCompletionSource)/*Error near IL_0186: Stack underflow*/).TrySetException((Exception)/*Error near IL_0186: Stack underflow*/);
					obj2 = 3;
					goto IL_009a;
					IL_009a:
					while (true)
					{
						switch ((int)obj2)
						{
						case 4:
							break;
						case 6:
							return;
						case 2:
							Unsafe.As<object, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._client).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<byte[]>*)(&awaiter), ref Unsafe.As<_003CGetItemDownloadAsync_003Ed__49, DesktopAuthentication._003CAuthentication_003Ed__27>(ref this));
							obj2 = 6;
							if (((DesktopAuthentication)(object)DesktopAuthentication._buffer)._handshake == 0)
							{
								obj2 = 3;
							}
							continue;
						case 3:
							if (((AsyncTaskMethodBuilder*)(&awaiter))->Task == null)
							{
								obj2 = 1;
								if (((DesktopAuthentication)DesktopAuthentication._handshakeKey)._encryptedToken == null)
								{
									obj2 = 0;
								}
								continue;
							}
							goto case 7;
						case 7:
							((TcpClient)(&awaiter)).Close();
							awaiter = (object)/*Error near IL_0159: Stack underflow*/;
							obj2 = 4;
							continue;
						case 5:
							goto IL_0163;
						case 9:
						case 10:
							awaiter = ((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E4__this;
							obj2 = 11;
							continue;
						case 1:
							awaiter = 0;
							((DesktopAuthentication._003CAuthentication_003Ed__27)this).modHashList = (string)0;
							obj2 = 0;
							if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27.serverIdHash)->_003Ccts_003E5__2 != null)
							{
								obj2 = 0;
							}
							continue;
						case 8:
							awaiter = -1;
							((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Eu__1 = (TaskAwaiter<byte[]>)(-1);
							obj2 = 7;
							if (DesktopAuthentication._003CAuthentication_003Ed__27.ReflectInternalAnnotation == null)
							{
								obj2 = 2;
							}
							continue;
						case 11:
							Unsafe.As<int, AsyncTaskMethodBuilder<EntityRentalGameCharacter[]>>(ref ((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003E1__state) = default;
							awaiter = 8;
							obj2 = awaiter;
							continue;
						default:
							((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003E4__this = (DesktopAuthentication)awaiter;
							obj2 = 2;
							continue;
						}
						break;
					}
					goto case 5;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_2300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779200, new IntPtr(2737336613596L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_2400(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_2500(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779203, new IntPtr(2737336620876L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_2600()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779202, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_2700()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_2800()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetItemDownloadAsync_003Ed__50 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityItemDownload[]> _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		public ulong[] itemIdList;

		private TaskAwaiter<EntityItemDownload[]> _003C_003Eu__1;

		internal static object ReflectAdvancedEmitter;

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
		internal static bool DecorateConvertibleRunner()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FindAllocator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_1800()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779213, new IntPtr(2737336612556L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00ᤀ()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_02ae: Expected Obj, but got I4
			//IL_004e: Expected Obj, but got Ref
			//IL_0077: Expected Obj, but got I4
			//IL_0077: Expected Obj, but got Ref
			//IL_0122: Expected Obj, but got Ref
			//IL_01fa: Expected Obj, but got VT
			//IL_0181: Expected Obj, but got I4
			//IL_0186: Expected Obj, but got I4
			//IL_0186: Expected Obj, but got Ref
			//IL_00ed: Expected Obj, but got Ref
			//IL_0100: Expected Obj, but got Ref
			//IL_01e3: Expected Obj, but got I4
			//IL_01e8: Expected Obj, but got I4
			//IL_0168: Expected Obj, but got Ref
			//IL_0177: Expected Obj, but got I4
			//IL_00e1: Expected I4, but got Obj
			//IL_02e4->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02c2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02cd->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0096->IL0026: Incompatible stack types: I4 vs Obj
			//IL_013e->IL00ac: Incompatible stack types: I4 vs Obj
			//IL_00a8->IL00ac: Incompatible stack types: I4 vs Obj
			//IL_0204->IL00ac: Incompatible stack types: I4 vs Obj
			//IL_0190->IL00ac: Incompatible stack types: I4 vs Obj
			//IL_00f9->IL00ac: Incompatible stack types: I4 vs Obj
			//IL_01ba->IL00ac: Incompatible stack types: I4 vs Obj
			//IL_01a8->IL00ac: Incompatible stack heights: 2 vs 1
			//IL_01f2->IL00ac: Incompatible stack types: I4 vs Obj
			//IL_010f->IL00ac: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				Task task;
				TcpClient tcpClient;
				switch ((int)obj2)
				{
				case 2:
					obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
					obj2 = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP == null)
					{
						obj2 = 1;
					}
					break;
				case 3:
					((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CserverId_003EP = -2;
					obj2 = 0;
					if (DesktopAuthentication.Logger != null)
					{
						obj2 = 0;
					}
					break;
				case 5:
					if (obj == null)
					{
						obj3 = 7;
						goto IL_00ac;
					}
					goto IL_010f;
				case 1:
					obj = ((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003E1__state;
					obj2 = 5;
					if (((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)DesktopAuthentication._003CHeartbeatAsync_003Ed__25._003C_003Et__builder)._003C_003E4__this != null)
					{
						obj2 = 3;
					}
					break;
				default:
					Unsafe.As<TaskAwaiter, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003Eu__1).SetException((Exception)obj);
					obj2 = 4;
					break;
				case 4:
					return;
					IL_010f:
					task = ((DesktopAuthentication)/*Error near IL_0116: Stack underflow*/).Connect((EntityAuthServer)obj);
					tcpClient = new TcpClient();
					((AsyncTaskMethodBuilder*)tcpClient)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)((AsyncTaskMethodBuilder*)((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshake)->Task, ref *(DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24*)1);
					((AsyncTaskMethodBuilder*)task)->Start<TStateMachine>(ref *(TStateMachine*)tcpClient);
					obj = (object)/*Error near IL_0134: Stack underflow*/;
					obj3 = 8;
					goto IL_00ac;
					IL_00ac:
					while (true)
					{
						switch ((int)obj3)
						{
						case 5:
							break;
						case 3:
							obj = ((object)(&obj)).ToString();
							obj3 = 5;
							continue;
						case 8:
							if (string.Format((IFormatProvider?)/*Error near IL_0100: Stack underflow*/, (string)/*Error near IL_0100: Stack underflow*/, (object?[])(&obj)) == null)
							{
								obj3 = 9;
								continue;
							}
							goto case 3;
						case 1:
							goto IL_010f;
						case 10:
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeTcs = null;
							obj = 2;
							obj3 = obj;
							continue;
						case 2:
							obj = -1;
							DesktopAuthentication.PrepareDic = (DesktopAuthentication)(-1);
							obj3 = 3;
							continue;
						case 6:
							_ = ref ((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E1__state;
							((DefaultInterpolatedStringHandler*)(&obj))->AppendFormatted((byte)Unsafe.AsPointer(ref this));
							_ = 11;
							continue;
						case 4:
							((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E4__this = (DesktopAuthentication)obj;
							obj3 = 6;
							continue;
						case 11:
							return;
						case 9:
							obj = 0;
							((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003Ccts_003E5__2 = 0;
							obj3 = 4;
							continue;
						default:
							obj = ((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Eu__1;
							obj3 = 10;
							continue;
						}
						break;
					}
					goto case 3;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00ᨀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779212, new IntPtr(2737336627116L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_1B00(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00ᰀ()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00ᴀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779215, new IntPtr(2737336612556L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00Ḁ()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00ἀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779214, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetModHashListAsync_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityGameModsHash> _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		public EnumGameType masterType;

		public EnumGameVersion gameVersion;

		private TaskAwaiter<EntityAuthItem> _003C_003Eu__1;

		private TaskAwaiter<EntityItemDownload[]> _003C_003Eu__2;

		internal static object CheckFlexibleListener;

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
		internal static bool PlaySender()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SetupWorker()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00ༀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779209, new IntPtr(2737336625036L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00က()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_00a3: Expected Obj, but got Ref
			//IL_004e: Expected Obj, but got Ref
			//IL_0088: Expected Obj, but got Ref
			//IL_008f: Expected VT, but got Obj
			//IL_008f: Expected Obj, but got Ref
			//IL_0098: Expected Obj, but got I4
			//IL_0077: Expected Obj, but got I4
			//IL_0077: Expected Obj, but got Ref
			//IL_0360: Expected Obj, but got I4
			//IL_0365: Expected VT, but got I4
			//IL_03bd: Expected Obj, but got I4
			//IL_03c2: Expected Obj, but got I4
			//IL_01d3: Expected VT, but got Obj
			//IL_01dd: Expected native int or pointer, but got Obj
			//IL_014e: Expected Obj, but got Ref
			//IL_0163: Expected Obj, but got I
			//IL_041a: Expected native int or pointer, but got Obj
			//IL_0204: Expected native int or pointer, but got Obj
			//IL_0310: Expected Obj, but got I4
			//IL_0315: Expected VT, but got I4
			//IL_033a: Expected Obj, but got Ref
			//IL_033c: Expected Obj, but got I4
			//IL_02cd: Expected Ref, but got VT
			//IL_02d2: Expected Obj, but got I4
			//IL_0324: Expected Obj, but got I4
			//IL_0329: Expected Obj, but got I4
			//IL_00b9->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_009d->IL0022: Incompatible stack heights: 1 vs 0
			//IL_0081->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00c4->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0300->IL00da: Incompatible stack heights: 2 vs 1
			//IL_026e->IL00da: Incompatible stack heights: 2 vs 1
			//IL_024c->IL03b8: Incompatible stack heights: 1 vs 0
			//IL_030b->IL00da: Incompatible stack heights: 2 vs 1
			//IL_0256->IL00da: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					int num;
					switch ((int)obj2)
					{
					case 2:
						obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
						obj2 = 1;
						if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP == null)
						{
							obj2 = 1;
						}
						continue;
					case 4:
						((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CserverId_003EP = -2;
						obj2 = 3;
						continue;
					case 5:
						return;
					case 3:
						break;
					case 1:
						obj = DesktopAuthentication.TokenKey;
						obj2 = 0;
						if (((DesktopAuthentication)DesktopAuthentication._client)._connected == 0)
						{
							obj2 = 0;
						}
						continue;
					default:
						{
							if (obj == null)
							{
								num = 6;
								goto IL_00da;
							}
							goto IL_0219;
						}
						IL_0219:
						if ((nint)obj != 1)
						{
							num = 21;
							goto IL_00da;
						}
						goto IL_03e1;
						IL_03e1:
						obj = DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22.DecorateBasicTag;
						num = 12;
						if ((int)((DesktopAuthentication._003CReceiveDataAsync_003Ed__21*)DesktopAuthentication._003CReceiveDataAsync_003Ed__21._003C_003E1__state)->_003C_003Et__builder == 0)
						{
							num = 3;
						}
						goto IL_00da;
						IL_00da:
						while (true)
						{
							switch (num)
							{
							case 18:
								break;
							case 15:
								return;
							case 17:
								return;
							case 9:
								Unsafe.As<List<byte>, _003CEntityRequestAsync_003Ed__10<_0021_00210>>(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._buffer) = default;
								num = 1;
								if (((DesktopAuthentication)DesktopAuthentication._handshakeSent)._handshakeKey != null)
								{
									num = 4;
								}
								continue;
							case 7:
								((AsyncTaskMethodBuilder*)obj)->Start<TStateMachine>(ref *(TStateMachine*)obj);
								GC.SuppressFinalize(((DesktopAuthentication)/*Error near IL_0181: Stack underflow*/).HeartbeatAsync());
								obj = (object)/*Error near IL_0188: Stack underflow*/;
								num = 7;
								if (((DesktopAuthentication)DesktopAuthentication._handshakeTcs)._authenticationTcs != null)
								{
									num = 10;
								}
								continue;
							case 8:
								((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)obj;
								num = 0;
								if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27._003C_003E4__this)->modHashList == null)
								{
									num = 0;
								}
								continue;
							case 14:
								((DesktopAuthentication._003CAuthentication_003Ed__27)this).serverIdHash = (string)obj;
								num = 2;
								if ((int)((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27._003Ccts_003E5__2)->_003C_003Eu__1 != 0)
								{
									num = 1;
								}
								continue;
							case 13:
								goto IL_0219;
							case 1:
								((DesktopAuthentication._003CAuthentication_003Ed__27*)obj)->SetStateMachine((IAsyncStateMachine)obj);
								obj = (object)/*Error near IL_0236: Stack underflow*/;
								num = 18;
								continue;
							case 20:
								_ = ref obj;
								if (MassService.Instance != null)
								{
									_ = 23;
									continue;
								}
								goto case 5;
							case 2:
								_ = ref ((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003E1__state;
								((AsyncTaskMethodBuilder<_0021_00210[]>*)(&obj))->Start(ref Unsafe.As<_003CGetModHashListAsync_003Ed__26, _003CEntitiesRequestAsync_003Ed__11<_0021_00210>>(ref this));
								_ = 15;
								continue;
							case 24:
								((TaskAwaiter*)(&obj))->GetResult();
								obj = (object)/*Error near IL_029b: Stack underflow*/;
								num = 1;
								if (DesktopAuthentication._003CConnect_003Ed__19.CheckAdjustableCommand == null)
								{
									num = 0;
								}
								continue;
							case 21:
							{
								object obj3 = obj;
								int num2 = ((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003E1__state;
								((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24*)((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003Et__builder)->MoveNext();
								((IDisposable)num2).Dispose();
								obj = obj3;
								num = 20;
								continue;
							}
							default:
								_ = ref DesktopAuthentication._003CHeartbeatAsync_003Ed__25.ProcessResolver;
								((AsyncTaskMethodBuilder<EntityGameModsHash>*)(&obj))->Start(ref this);
								_ = 17;
								if (((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24._003C_003Et__builder)._003C_003E4__this != null)
								{
									_ = 16;
								}
								continue;
							case 16:
								obj = -1;
								((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003Eu__1 = (TaskAwaiter)(-1);
								num = 24;
								continue;
							case 22:
								obj = 1;
								DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24.ReflectMixedRunner = 1;
								num = 14;
								continue;
							case 19:
							case 23:
								obj = ((EntityAuthServer)(&obj)).Port;
								num = 1;
								if (((DesktopAuthentication._003CReceiveAsync_003Ed__20)DesktopAuthentication._003CReceiveAsync_003Ed__20._003C_003Et__builder)._003C_003E4__this != null)
								{
									num = 7;
								}
								continue;
							case 4:
								obj = -1;
								((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003Eu__1 = (TaskAwaiter)(-1);
								num = 19;
								continue;
							case 12:
								DesktopAuthentication._003CReceiveAsync_003Ed__20.CheckCommonTracker = null;
								num = 14;
								if (((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22._003C_003Et__builder)._003C_003E4__this == null)
								{
									num = 16;
								}
								continue;
							case 5:
								obj = 0;
								((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this).data = (byte[])0;
								num = 4;
								if ((int)((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22._003C_003Eu__1)._003C_003Eu__2 != 0)
								{
									num = 8;
								}
								continue;
							case 3:
								goto IL_03e1;
							case 6:
							case 11:
								obj = ((DesktopAuthentication._003CReceiveDataAsync_003Ed__21)this)._003C_003E4__this;
								num = 2;
								if ((int)((DesktopAuthentication._003CReceiveDataAsync_003Ed__21*)(nint)DesktopAuthentication._003CReceiveDataAsync_003Ed__21.buffer)->_003C_003Eu__1 != 0)
								{
									num = 9;
								}
								continue;
							case 10:
								if (Enumerable.Skip<TSource>((IEnumerable<TSource>)/*Error near IL_0436: Stack underflow*/, (int)(&obj)) == null)
								{
									num = 22;
									continue;
								}
								goto case 24;
							}
							break;
						}
						goto case 4;
					}
					break;
				}
				((EqualityComparer<_00211>)Unsafe.AsPointer(ref DesktopAuthentication.Crc32)).GetHashCode((_00211)obj);
				obj = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00ᄀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779208, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00ሀ(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00ጀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779211, new IntPtr(2737336630236L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_1400()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779210, new IntPtr(2737336618796L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00ᔀ()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00ᘀ()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetNetGameAddressAsync_003Ed__46 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityNetGameAddress> _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		public string gameId;

		private TaskAwaiter<EntityNetGameAddress> _003C_003Eu__1;

		private static object ViewProvider;

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
		internal static bool EncryptCalc()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateBasicDefinition()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_0600()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779061, new IntPtr(2737336631276L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_0700()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_00b2: Expected Obj, but got Ref
			//IL_008b: Expected Obj, but got Ref
			//IL_004e: Expected Obj, but got Ref
			//IL_0059: Expected Obj, but got I4
			//IL_0066: Expected Obj, but got I4
			//IL_0066: Expected Obj, but got Ref
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_019a: Expected Obj, but got Ref
			//IL_019f: Expected Obj, but got Unknown
			//IL_01a5: Expected Ref, but got Unknown
			//IL_01b5: Expected Obj, but got I4
			//IL_00f0: Expected Obj, but got I
			//IL_0149: Expected I4, but got Obj
			//IL_01ff: Expected Obj, but got I4
			//IL_02de: Expected Obj, but got I4
			//IL_02e3: Expected Obj, but got I4
			//IL_0154: Expected Obj, but got Ref
			//IL_015c: Expected Obj, but got Ref
			//IL_015c: Expected Obj, but got Ref
			//IL_0258: Expected native int or pointer, but got Obj
			//IL_016c: Expected Obj, but got Ref
			//IL_02b8: Expected Obj, but got Ref
			//IL_029e: Expected I, but got VT
			//IL_02cf: Expected VT, but got Obj
			//IL_01bf: Expected Obj, but got I4
			//IL_01c4: Expected Obj, but got I4
			//IL_01cd: Expected Obj, but got I4
			//IL_02ac: Expected Obj, but got I4
			//IL_00a1->IL0026: Incompatible stack types: I4 vs Obj
			//IL_007a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00f5->IL0104: Incompatible stack types: I4 vs Obj
			//IL_00ac->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0085->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0100->IL0104: Incompatible stack types: I4 vs Obj
			//IL_0213->IL0104: Incompatible stack types: I4 vs Obj
			//IL_02ed->IL0104: Incompatible stack types: I4 vs Obj
			//IL_0166->IL0104: Incompatible stack heights: 3 vs 1
			//IL_0262->IL0104: Incompatible stack types: I4 vs Obj
			//IL_0178->IL0104: Incompatible stack types: I4 vs Obj
			//IL_02d9->IL0104: Incompatible stack types: I4 vs Obj
			//IL_0283->IL0104: Incompatible stack types: I4 vs Obj
			//IL_021e->IL0104: Incompatible stack types: I4 vs Obj
			//IL_026d->IL0104: Incompatible stack types: I4 vs Obj
			//IL_02c7->IL0104: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					object obj3;
					Task task;
					Log val;
					switch ((int)obj2)
					{
					case 4:
						break;
					case 5:
						((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserToken_003EP = -2;
						obj2 = 2;
						if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
						{
							obj2 = 1;
						}
						continue;
					case 3:
						obj = DesktopAuthentication.Crc32;
						obj2 = 0;
						if (DesktopAuthentication.TokenKey == null)
						{
							obj2 = 0;
						}
						continue;
					case 2:
						_ = ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._client;
						/*Error near IL_00b4: Member reference must be method, but was: Field*/;
					case 1:
						return;
					default:
						{
							if (obj == null)
							{
								obj3 = 1;
								if (((DesktopAuthentication)DesktopAuthentication._handshakeSent)._handshakeKey != null)
								{
									obj3 = 0;
								}
								goto IL_0104;
							}
							goto IL_0187;
						}
						IL_0187:
						task = ((DesktopAuthentication)/*Error near IL_018e: Stack underflow*/).Authentication((string)/*Error near IL_018e: Stack underflow*/, (string)obj);
						val = (Log)new Log();
						((TimeoutException)val)._002Ector((string?)(object)DesktopAuthentication.PrepareDic);
						((DefaultInterpolatedStringHandler*)val)->AppendFormatted((byte)1);
						((IAsyncStateMachine)task).MoveNext();
						obj = (object)/*Error near IL_01ac: Stack underflow*/;
						obj = 9;
						goto IL_0100;
						IL_0100:
						obj3 = obj;
						goto IL_0104;
						IL_0104:
						while (true)
						{
							switch ((int)obj3)
							{
							case 4:
								break;
							case 15:
								return;
							case 6:
								_ = ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptedToken;
								((IEnumerable<byte>)(&obj)).Concat((IEnumerable<byte>)Unsafe.AsPointer(ref this));
								_ = 15;
								continue;
							case 1:
							case 8:
								obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._decryptChaCha;
								obj3 = 7;
								continue;
							case 11:
								goto IL_0187;
							case 14:
								goto IL_01ba;
							case 2:
							case 5:
								obj = ((TaskAwaiter<byte[]>*)(&obj))->IsCompleted;
								obj3 = 0;
								if (DesktopAuthentication._003CAuthentication_003Ed__27.ReflectInternalAnnotation == null)
								{
									obj3 = 0;
								}
								continue;
							case 7:
								Unsafe.As<DesktopAuthentication, AsyncTaskMethodBuilder<EntityNetGameAddress>>(ref ((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003E4__this) = default;
								obj3 = 14;
								if ((int)((DesktopAuthentication._003CConnect_003Ed__19*)(nint)DesktopAuthentication._003CConnect_003Ed__19._003Ccts_003E5__2)->_003C_003Eu__1 != 0)
								{
									obj3 = 6;
								}
								continue;
							default:
								if (((TaskCompletionSource)obj).Task == null)
								{
									obj3 = 10;
									continue;
								}
								goto case 12;
							case 12:
								throw new Action((object)/*Error near IL_029e: Stack underflow*/, (nint)((CancellationTokenSource)obj).Token);
							case 10:
								goto IL_029f;
							case 9:
								if ((int)((CancellationToken*)/*Error near IL_02b8: Stack underflow*/)->Register((Action)(&obj)) != 0)
								{
									obj3 = 5;
									continue;
								}
								goto case 3;
							case 13:
								((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003Eu__1 = (TaskAwaiter)obj;
								obj3 = 6;
								continue;
							case 3:
								obj = 0;
								DesktopAuthentication._003CHeartbeatAsync_003Ed__25.ProcessResolver = 0;
								obj3 = 13;
								continue;
							}
							break;
						}
						goto case 5;
						IL_029f:
						obj = obj;
						obj = 4;
						goto IL_0100;
						IL_01ba:
						obj = -1;
						((DesktopAuthentication._003CAuthentication_003Ed__27)this).modHashList = (string)(-1);
						obj = 2;
						goto IL_0100;
					}
					break;
				}
				obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
				obj = 3;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00ࠀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779060, new IntPtr(2737336617756L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_0900(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP != null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_0A00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779063, new IntPtr(2737336618796L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_0B00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779062, new IntPtr(2737336636476L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_0C00()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_0D00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779057, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_0E00()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetNetGameDetailsAsync_003Ed__53 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityNetGameDetails> _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		public string gameId;

		private TaskAwaiter<EntityNetGameDetails> _003C_003Eu__1;

		internal static object DecorateReadableTransmitter;

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
		internal static bool DecorateRemoteRecommender()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateActiveAnalyzer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00ﬀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779056, new IntPtr(2737336618796L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00ﰀ()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0050: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got Ref
			//IL_0322: Expected Obj, but got I4
			//IL_0077: Expected Obj, but got Ref
			//IL_0060: Expected Obj, but got Ref
			//IL_018e: Expected Obj, but got I4
			//IL_0194: Expected Obj, but got I4
			//IL_01a4: Expected Obj, but got I4
			//IL_00f9: Expected I4, but got Obj
			//IL_0223: Expected native int or pointer, but got Obj
			//IL_0246: Expected Obj, but got Ref
			//IL_0246: Expected Obj, but got Ref
			//IL_024f: Expected Obj, but got I4
			//IL_01ae: Expected Obj, but got I4
			//IL_01b3: Expected Obj, but got I4
			//IL_01bd: Expected native int or pointer, but got Obj
			//IL_01ed: Expected Obj, but got VT
			//IL_0103: Expected Obj, but got I4
			//IL_0108: Expected Obj, but got Ref
			//IL_0157: Expected Obj, but got Ref
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_032c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0071->IL0026: Incompatible stack heights: 4 vs 1
			//IL_0098->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00b5->IL00c4: Incompatible stack types: I4 vs Obj
			//IL_00c0->IL00c4: Incompatible stack types: I4 vs Obj
			//IL_0144->IL00c4: Incompatible stack types: I4 vs Obj
			//IL_022d->IL00c4: Incompatible stack types: I4 vs Obj
			//IL_0203->IL0127: Incompatible stack heights: 1 vs 0
			//IL_0254->IL00c0: Incompatible stack heights: 2 vs 0
			//IL_01c7->IL00c4: Incompatible stack types: I4 vs Obj
			//IL_01f7->IL00c4: Incompatible stack types: I4 vs Obj
			//IL_011c->IL00c4: Incompatible stack types: I4 vs Obj
			//IL_016b->IL00c4: Incompatible stack types: I4 vs Obj
			//IL_014f->IL00c4: Incompatible stack types: I4 vs Obj
			//IL_0238->IL00c4: Incompatible stack types: I4 vs Obj
			//IL_020d->IL00c4: Incompatible stack heights: 2 vs 1
			//IL_01d2->IL00c4: Incompatible stack types: I4 vs Obj
			//IL_0127->IL00c4: Incompatible stack types: I4 vs Obj
			//IL_0176->IL00c4: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				ILogger loggerExtensions;
				switch ((int)obj2)
				{
				default:
					((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP = -2;
					obj2 = 4;
					break;
				case 4:
					_ = ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserToken_003EP;
					_ = EqualityComparer<_00210>.Default;
					_ = 3;
					break;
				case 2:
					obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CserverId_003EP;
					obj2 = 1;
					if (DesktopAuthentication.Logger == null)
					{
						obj2 = 1;
					}
					break;
				case 3:
					return;
				case 5:
					if (obj == null)
					{
						obj3 = 0;
						if (((DesktopAuthentication)(object)DesktopAuthentication.TokenKey)._client == null)
						{
							obj3 = 0;
						}
						goto IL_00c4;
					}
					goto IL_0176;
				case 1:
					{
						obj = ((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003E1__state;
						obj2 = 5;
						break;
					}
					IL_0176:
					loggerExtensions = new LoggerExtensions((ILogger)/*Error near IL_0182: Stack underflow*/, (string)((DesktopAuthentication)/*Error near IL_017d: Stack underflow*/).SendPacketAsync((byte)/*Error near IL_017d: Stack underflow*/, obj));
					((AsyncTaskMethodBuilder*)/*Error near IL_0199: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)loggerExtensions, ref *(TStateMachine*)((IEnumerable<byte>)((TaskCompletionSource)(object)loggerExtensions).TrySetException((Exception)((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E1__state)).Take(1));
					obj = (object)/*Error near IL_019b: Stack underflow*/;
					obj = 3;
					goto IL_00c0;
					IL_00c0:
					obj3 = obj;
					goto IL_00c4;
					IL_00c4:
					while (true)
					{
						switch ((int)obj3)
						{
						case 7:
							break;
						case 9:
							return;
						case 8:
							obj = -1;
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._connected = -1;
							obj3 = 1;
							if (((DesktopAuthentication)(object)DesktopAuthentication._buffer)._handshake == 0)
							{
								obj3 = 0;
							}
							continue;
						case 1:
							obj = ((AsyncTaskMethodBuilder*)(&obj))->Task;
							obj3 = 7;
							if (((DesktopAuthentication)DesktopAuthentication._handshakeKey)._encryptedToken == null)
							{
								obj3 = 2;
							}
							continue;
						case 11:
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptChaCha = obj;
							obj3 = 4;
							if (((DesktopAuthentication)DesktopAuthentication._decryptChaCha)._handshakeTcs == null)
							{
								obj3 = 1;
							}
							continue;
						case 10:
							goto IL_0176;
						case 5:
							obj = 0;
							((DesktopAuthentication._003CAuthentication_003Ed__27)this).serverIdHash = (string)0;
							obj3 = 4;
							if ((int)((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27._003Ccts_003E5__2)->_003C_003Eu__1 == 0)
							{
								obj3 = 11;
							}
							continue;
						default:
							obj = ((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Eu__2;
							obj3 = 2;
							continue;
						case 3:
							_ = ref obj;
							if (MassService.Instance == null)
							{
								_ = 5;
								continue;
							}
							goto case 1;
						case 2:
							Unsafe.As<int, AsyncTaskMethodBuilder<EntityRentalGameCharacter[]>>(ref ((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003E1__state) = default;
							obj3 = 0;
							if (((DesktopAuthentication._003CConnect_003Ed__19*)(nint)DesktopAuthentication._003CConnect_003Ed__19._003C_003E4__this)->authServer == null)
							{
								obj3 = 8;
							}
							continue;
						case 4:
							goto IL_0238;
						}
						break;
					}
					goto default;
					IL_0238:
					_ = ref ((DesktopAuthentication._003CConnect_003Ed__19)this)._003Ccts_003E5__2;
					((IEnumerable<EntityNetGameItem>)(&obj)).FirstOrDefault((Func<EntityNetGameItem, bool>)Unsafe.AsPointer(ref this));
					obj = 9;
					goto IL_00c0;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00ﴀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779059, new IntPtr(2737336629196L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FE00(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779058, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00Ā()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779069, new IntPtr(2737336631276L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00Ȁ()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_0300()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00Ѐ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779068, new IntPtr(2737336628156L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetNetGamesAsync_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityNetGameItem[]> _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		private List<EntityNetGameItem> _003CnetGames_003E5__2;

		private object _003Ctasks_003E5__3;

		private TaskAwaiter<Entities<EntityNetGameItem>> _003C_003Eu__1;

		private TaskAwaiter<Entities<EntityNetGameItem>[]> _003C_003Eu__2;

		private object _003C_003E7__wrap3;

		private nint _003C_003E7__wrap4;

		private List<EntityNetGameItem> _003C_003E7__wrap5;

		private TaskAwaiter<EntityItemChannel[]> _003C_003Eu__3;

		private static object ReflectJoinedDistributor;

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
		internal static bool RestartConnection()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectScalableDispatcher()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_F200()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779071, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_F300()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_004b: Expected I4, but got Obj
			//IL_0068: Expected I4, but got Obj
			//IL_0b4d: Expected I4, but got Obj
			//IL_0b57: Expected native int or pointer, but got Obj
			//IL_0bd8: Expected VT, but got I4
			//IL_0be2: Expected native int or pointer, but got Obj
			//IL_098e: Expected Obj, but got I4
			//IL_07c9: Expected Obj, but got VT
			//IL_07d3: Expected native int or pointer, but got Obj
			//IL_0893: Expected Obj, but got I4
			//IL_076f: Expected Obj, but got I4
			//IL_0516: Expected Obj, but got I4
			//IL_0204: Expected VT, but got Obj
			//IL_0210: Expected Obj, but got I4
			//IL_0538: Expected Obj, but got I4
			//IL_02c3: Expected Obj, but got F8
			//IL_02c6: Expected Obj, but got I4
			//IL_01dd: Expected Obj, but got I4
			//IL_045d: Expected Obj, but got I4
			//IL_04db: Expected Obj, but got I4
			//IL_04e0: Expected Obj, but got I4
			//IL_04ea: Expected native int or pointer, but got Obj
			//IL_094c: Expected Obj, but got I4
			//IL_0951: Expected VT, but got I4
			//IL_095b: Expected native int or pointer, but got Obj
			//IL_024a: Expected Obj, but got Ref
			//IL_0250: Expected Obj, but got Ref
			//IL_0251: Expected Obj, but got I
			//IL_093d: Expected I4, but got Obj
			//IL_0369: Expected Obj, but got VT
			//IL_0370: Expected Obj, but got VT
			//IL_0394: Expected Obj, but got I4
			//IL_0399: Expected VT, but got I4
			//IL_03a3: Expected native int or pointer, but got Obj
			//IL_03fb: Expected native int or pointer, but got Obj
			//IL_0402: Expected Obj, but got VT
			//IL_040c: Expected native int or pointer, but got Obj
			//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b6: Expected Obj, but got Unknown
			//IL_0292: Expected Obj, but got Ref
			//IL_02a7: Expected Obj, but got I4
			//IL_01ec: Expected Obj, but got I4
			//IL_01f1: Expected Obj, but got I4
			//IL_01f1: Expected Obj, but got Ref
			//IL_08c0: Expected Obj, but got Ref
			//IL_08c0: Expected Obj, but got Ref
			//IL_0859: Expected native int or pointer, but got Obj
			//IL_0860: Expected Obj, but got VT
			//IL_04a6: Expected I4, but got Obj
			//IL_03da: Expected VT, but got Obj
			//IL_03e4: Expected native int or pointer, but got Obj
			//IL_03bf: Expected Obj, but got Ref
			//IL_02fe: Expected Obj, but got VT
			//IL_0721: Expected VT, but got Obj
			//IL_07f9: Expected Obj, but got I4
			//IL_0191: Expected Obj, but got I4
			//IL_0196: Expected Obj, but got I4
			//IL_0196: Expected Obj, but got Ref
			//IL_01a5: Expected Obj, but got I4
			//IL_01aa: Expected Obj, but got I4
			//IL_01aa: Expected Obj, but got Ref
			//IL_0584: Expected Obj, but got I4
			//IL_0589: Expected Obj, but got I4
			//IL_09ac: Expected Obj, but got I4
			//IL_09b1: Expected VT, but got I4
			//IL_05bc: Expected native int or pointer, but got Obj
			//IL_0267: Expected Obj, but got Ref
			//IL_08cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0595: Expected native int or pointer, but got Obj
			//IL_0733: Unknown result type (might be due to invalid IL or missing references)
			//IL_0739: Expected Obj, but got Unknown
			//IL_0234: Expected Obj, but got I
			//IL_0a45: Expected I4, but got Obj
			//IL_0650: Expected Obj, but got Ref
			//IL_0652: Expected Obj, but got VT
			//IL_0634: Expected native int or pointer, but got Obj
			//IL_0bd0->IL0026: Incompatible stack heights: 4 vs 1
			//IL_0b87->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0b61->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0bae->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0b46->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0bec->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0b92->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0b6c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0bb9->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0bf7->IL0026: Incompatible stack types: I4 vs Obj
			//IL_021a->IL0076: Incompatible stack heights: 2 vs 1
			//IL_0462->IL0072: Incompatible stack heights: 0 vs 1
			//IL_02ac->IL0072: Incompatible stack heights: 2 vs 1
			//IL_08ca->IL0076: Incompatible stack heights: 2 vs 1
			//IL_07fe->IL0072: Incompatible stack heights: 0 vs 1
			//IL_0439->IL0076: Incompatible stack heights: 2 vs 1
			//IL_049e->IL0076: Incompatible stack heights: 2 vs 1
			//IL_0076->IL0076: Incompatible stack heights: 2 vs 1
			//IL_0a67->IL0076: Incompatible stack heights: 2 vs 1
			//IL_0a45->IL0a45: Incompatible stack heights: 5 vs 3
			//IL_063e->IL05fa: Incompatible stack heights: 2 vs 1
			//IL_0649->IL05fa: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 2:
				{
					int num;
					switch ((int)obj)
					{
					default:
						num = 65;
						goto IL_0076;
					case 2:
						obj = DesktopAuthentication._003CReceiveDataAsync_003Ed__21.CheckActiveRecommender;
						num = 39;
						goto IL_0076;
					case 1:
						goto IL_07c1;
					case 3:
						goto IL_088b;
					case 0:
						goto IL_0986;
						IL_0076:
						while (true)
						{
							switch (num)
							{
							case 47:
								obj = -1;
								((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP = -1;
								num = 42;
								continue;
							case 48:
								obj = 2;
								((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserToken_003EP = 2;
								num = 44;
								continue;
							case 52:
								obj = ((object[])obj)[obj];
								num = 5;
								if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
								{
									num = 2;
								}
								continue;
							case 11:
								obj = 0;
								num = 8;
								continue;
							case 29:
								obj = 1;
								DesktopAuthentication.Crc32 = 1;
								num = 45;
								continue;
							case 5:
								string.Format((IFormatProvider?)/*Error near IL_0210: Stack underflow*/, (string)((EqualityComparer<_00211>)obj).GetHashCode((_00211)obj), (object?[])(object)obj.ToString());
								_ = 25;
								continue;
							case 8:
							case 26:
								if ((nint)obj >= ((Array)obj).Length)
								{
									num = 6;
									if (((DesktopAuthentication)DesktopAuthentication._connected)._buffer != null)
									{
										num = 7;
									}
									continue;
								}
								goto case 52;
							case 17:
							case 51:
								if (((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshake >= ((Array)((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeSent).Length)
								{
									num = 9;
									continue;
								}
								goto case 21;
							case 59:
								Unsafe.As<object, _003CRequestAsync_003Ed__12<_0021_00210>>(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeKey) = default;
								num = 15;
								if (((DesktopAuthentication)DesktopAuthentication._encryptChaCha)._decryptChaCha != null)
								{
									num = 8;
								}
								continue;
							case 28:
								_ = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeTcs;
								((ILogger)obj).Category((string)(object)Log.Logger);
								obj = 19;
								continue;
							case 10:
								((TimeoutException)/*Error near IL_02b3: Stack underflow*/)._002Ector((string?)obj);
								obj = ((TaskCompletionSource)/*Error near IL_02c3: Stack underflow*/).TrySetException((Exception)((double)/*Error near IL_02b4: Stack underflow*/ / 50.0));
								num = 64;
								continue;
							case 62:
								((AsyncTaskMethodBuilder*)/*Error near IL_02dd: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)obj, ref *(TStateMachine*)((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E4__this);
								Unsafe.Write(&((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)/*Error near IL_02e2: Stack underflow*/)->serverIdHash, /*Error near IL_02e2: Stack underflow*/);
								num = 24;
								continue;
							case 38:
								((AsyncTaskMethodBuilder*)/*Error near IL_02f7: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)/*Error near IL_02f7: Stack underflow*/, ref *(DesktopAuthentication._003CSendPacketAsync_003Ed__28*)((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003Ccts_003E5__2);
								obj = ((Task)/*Error near IL_02fc: Stack underflow*/).GetAwaiter();
								num = 35;
								continue;
							case 21:
							{
								object obj5 = ((object[])(object)((DesktopAuthentication._003CConnect_003Ed__19)this).authServer)[((DesktopAuthentication._003CConnect_003Ed__19)this)._003Ccts_003E5__2];
								DesktopAuthentication._003CConnect_003Ed__19.CheckAdjustableCommand = ((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003Eu__1;
								obj = ((CancellationTokenSource)obj5).Token;
								num = 1;
								if (((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)DesktopAuthentication._003CHeartbeatAsync_003Ed__25._003C_003Et__builder)._003C_003E4__this == null)
								{
									num = 1;
								}
								continue;
							}
							case 22:
								obj = 3;
								((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003Eu__1 = (TaskAwaiter)3;
								num = 32;
								if (((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24*)(nint)DesktopAuthentication._003CHeartbeatAsync_003Ed__25.ProcessResolver)->_003C_003E1__state == 0)
								{
									num = 28;
								}
								continue;
							case 35:
								((IAsyncStateMachine)/*Error near IL_03bf: Stack underflow*/).SetStateMachine((IAsyncStateMachine)(&obj));
								if ((int)/*Error near IL_03c4: Stack underflow*/ != 0)
								{
									num = 2;
									continue;
								}
								goto case 29;
							case 33:
								((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003Eu__1 = (TaskAwaiter)((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003E4__this;
								num = 47;
								if (((DesktopAuthentication._003CReceiveAsync_003Ed__20*)(nint)DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24.ReflectMixedRunner)->_003C_003E1__state == 0)
								{
									num = 50;
								}
								continue;
							case 24:
								obj = ((DesktopAuthentication._003CReceiveAsync_003Ed__20*)(nint)obj)->_003C_003Et__builder;
								num = 23;
								if ((int)((DesktopAuthentication._003CReceiveAsync_003Ed__20*)(nint)DesktopAuthentication._003CReceiveAsync_003Ed__20._003C_003E4__this)->_003C_003Eu__1 == 0)
								{
									num = 10;
								}
								continue;
							case 54:
								_ = ref DesktopAuthentication._003CReceiveAsync_003Ed__20.CheckCommonTracker;
								((AsyncTaskMethodBuilder<EntityGameCharacter[]>*)(&obj))->Start(ref Unsafe.As<_003CGetNetGamesAsync_003Ed__15, _003CGetGameCharactersAsync_003Ed__41>(ref this));
								_ = 37;
								continue;
							case 13:
								Unsafe.As<AsyncTaskMethodBuilder, TaskAwaiter<EntityGameCharacter>>(ref ((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this)._003C_003Et__builder) = default;
								obj = 14;
								continue;
							case 6:
								return;
							case 63:
								_ = ref ((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this)._003C_003Eu__2;
								((AsyncTaskMethodBuilder<EntityRentalGameAddress>*)(&obj))->Start(ref Unsafe.As<_003CGetNetGamesAsync_003Ed__15, _003CGetRentalGameAddressAsync_003Ed__47>(ref this));
								_ = 12;
								continue;
							case 32:
								((DesktopAuthentication._003CReceiveDataAsync_003Ed__21)this)._003C_003E1__state = (int)obj;
								num = 54;
								continue;
							case 25:
								obj++;
								num = 26;
								continue;
							case 53:
								if (Arrays.CopyOfRange((byte[])/*Error near IL_04c7: Stack underflow*/, (int)/*Error near IL_04c7: Stack underflow*/, (int)(&obj)) == null)
								{
									num = 22;
									continue;
								}
								goto case 43;
							case 14:
								obj = -1;
								((DesktopAuthentication._003CReceiveDataAsync_003Ed__21)this)._003C_003E4__this = (DesktopAuthentication)(-1);
								num = 43;
								if ((int)((DesktopAuthentication._003CReceiveDataAsync_003Ed__21*)(nint)DesktopAuthentication._003CReceiveDataAsync_003Ed__21.buffer)->_003C_003Eu__1 == 0)
								{
									num = 27;
								}
								continue;
							case 4:
								_ = ref ((DesktopAuthentication._003CReceiveDataAsync_003Ed__21)this)._003Clength_003E5__2;
								((AsyncTaskMethodBuilder<EntityGameClientPatch>*)(&obj))->Start(ref Unsafe.As<_003CGetNetGamesAsync_003Ed__15, _003CGetGamePatchInfoAsync_003Ed__54>(ref this));
								obj = 6;
								continue;
							case 20:
								break;
							case 7:
								((DefaultInterpolatedStringHandler*)/*Error near IL_0538: Stack underflow*/)->AppendFormatted<T>((T)/*Error near IL_0538: Stack underflow*/, (string?)((DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23)this)._003C_003E1__state);
								obj = (object)/*Error near IL_053a: Stack underflow*/;
								num = 16;
								continue;
							case 37:
								return;
							case 39:
								Unsafe.As<ushort, @null>(ref ((DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23)this).sid) = null;
								num = 55;
								continue;
							case 34:
								if (((DefaultInterpolatedStringHandler*)(&obj))->ToStringAndClear() == null)
								{
									num = 57;
									continue;
								}
								goto case 58;
							case 55:
								obj = -1;
								DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23.ReflectScalableNotifier = -1;
								num = 18;
								continue;
							case 65:
								if (((DesktopAuthentication._003CSendMessageAsync_003Ed__29*)(nint)obj)->_003C_003E1__state != 0)
								{
									num = 31;
									continue;
								}
								goto default;
							case 58:
								obj = ((List<byte>)/*Error near IL_05b0: Stack underflow*/).GetRange((int)/*Error near IL_05b0: Stack underflow*/, (int)(&obj));
								num = 28;
								if (((DesktopAuthentication._003CSendMessageAsync_003Ed__29*)(nint)DesktopAuthentication._003CSendMessageAsync_003Ed__29._003C_003E4__this)->data != null)
								{
									num = 36;
								}
								continue;
							case 16:
								while (true)
								{
									IL_0671:
									int num3;
									if ((int)((ValueTask*)(&obj))->GetAwaiter() == 0)
									{
										num3 = 0;
										if (DecorateVisibleDecider != null)
										{
											num3 = 0;
										}
										goto IL_05fa;
									}
									goto IL_0649;
									IL_0649:
									obj = ((Task<int>)(&obj)).GetAwaiter();
									num3 = 3;
									if (((DesktopSession)DesktopSession._netGames)._skins == null)
									{
										num3 = 0;
									}
									goto IL_05fa;
									IL_05fa:
									while (true)
									{
										switch (num3)
										{
										case 3:
											((AsyncTaskMethodBuilder*)obj)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)obj, ref *(((TaskAwaiter<int>*)obj)->IsCompleted ? ((_003CAddRentalGameCharacterAsync_003Ed__45*)1) : ((_003CAddRentalGameCharacterAsync_003Ed__45*)null)));
											((TaskAwaiter<int>*)/*Error near IL_062a: Stack underflow*/)->GetResult();
											_ = 0;
											if ((int)((DesktopAuthentication._003CSendPacketAsync_003Ed__28*)(nint)DesktopAuthentication._003CSendPacketAsync_003Ed__28._003C_003E4__this)->_003C_003Eu__1 == 0)
											{
												_ = 1;
											}
											continue;
										case 2:
											goto IL_0649;
										case 1:
											goto IL_0671;
										}
										break;
									}
									break;
								}
								goto case 62;
							case 45:
								((_003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed)this)._003C_003Eu__1 = (TaskAwaiter<Entities<EntityNetGameItem>>)obj;
								num = 30;
								continue;
							case 66:
								_003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed.UpdateRecord = ((_003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed)this)._003C_003Eu__2 + 1;
								num = 15;
								if (_003C_003Ec._003C_003E9__15_2 != null)
								{
									num = 17;
								}
								continue;
							case 49:
								return;
							default:
								((DesktopSession)/*Error near IL_076f: Stack underflow*/).AddGameCharacterAsync((EnumGameType)/*Error near IL_076f: Stack underflow*/, (string)obj, (string)0);
								/*Error near IL_076f: Member reference must be method, but was: Field*/;
							case 43:
								_ = ref obj;
								/*Error near IL_0782: Member reference must be method, but was: Field*/;
							case 2:
							case 42:
								_ = ref obj;
								/*Error near IL_079c: Member reference must be method, but was: Field*/;
							case 3:
								goto IL_07c1;
							case 46:
								((_003CAddGameCharacterAsync_003Ed__44)this).gameId = (string)obj;
								obj = 4;
								continue;
							case 18:
							case 56:
								_ = ref obj;
								/*Error near IL_0800: Member reference must be method, but was: Field*/;
							case 36:
								/*Error near IL_0829: Member reference must be method, but was: Field*/;
							case 31:
								obj = ((_003CAddRentalGameCharacterAsync_003Ed__45*)(nint)obj)->_003C_003Eu__1;
								num = 60;
								continue;
							case 44:
								_003CAddRentalGameCharacterAsync_003Ed__45.CheckControllableMap = obj;
								num = 63;
								continue;
							case 40:
								goto IL_088b;
							case 30:
								((DesktopSession)/*Error near IL_08c0: Stack underflow*/).EntityRequestAsync<EntityRentalGameAddress>((string)Unsafe.AsPointer(ref ((_003CDownloadImageAsync_003Ed__34)this).directoryPath), (object)(&obj), (byte)Unsafe.AsPointer(ref this) != 0);
								_ = 49;
								continue;
							case 64:
								_ = 1;
								_ = obj - 1;
								/*Error near IL_08d0: Member reference must be method, but was: Field*/;
							case 9:
								((_003CEntitiesRequestAsync_003Ed__11<>)this).body = null;
								num = 50;
								if ((int)((_003CEntitiesRequestAsync_003Ed__11<>*)(_003CEntitiesRequestAsync_003Ed__11<>.checkCode ? 1 : 0))->_003C_003Eu__1 == 0)
								{
									num = 61;
								}
								continue;
							case 19:
								((_003CEntityRequestAsync_003Ed__10<>)this)._003C_003E1__state = (int)null;
								num = 66;
								continue;
							case 15:
								obj = -1;
								((_003CEntityRequestAsync_003Ed__10<>)this)._003C_003Et__builder = (AsyncTaskMethodBuilder<T>)(-1);
								num = 58;
								if (((_003CEntityRequestAsync_003Ed__10<>*)(nint)_003CEntityRequestAsync_003Ed__10<>._003C_003E4__this)->url == null)
								{
									num = 25;
								}
								continue;
							case 1:
								if (((AsyncTaskMethodBuilder<EntitySkinItem>*)(&obj))->Task != null)
								{
									num = 56;
									continue;
								}
								goto case 48;
							case 27:
								goto IL_0986;
							case 12:
								return;
							case 57:
								obj = 0;
								((_003CEntityRequestAsync_003Ed__10<>)this)._003C_003Eu__1 = (TaskAwaiter<Entity<T>>)0;
								num = 46;
								continue;
							case 50:
								((_003CEntityRequestAsync_003Ed__9)this)._003C_003E1__state = 0;
								num = 51;
								if (((_003CEntityRequestAsync_003Ed__9)_003CEntityRequestAsync_003Ed__9._003C_003Et__builder)._003C_003E4__this == null)
								{
									num = 32;
								}
								continue;
							case 41:
								Unsafe.As<string, TaskAwaiter<EntityTransferServer[]>>(ref ((_003CEntityRequestAsync_003Ed__9)this).url) = default;
								num = 47;
								if ((int)((_003CEntityRequestAsync_003Ed__9*)(_003CEntityRequestAsync_003Ed__9.checkCode ? 1 : 0))->_003C_003Eu__1 != 0)
								{
									num = 41;
								}
								continue;
							case 61:
							{
								object obj3 = obj;
								object obj4 = _003CEntityRequestAsync_003Ed__9.CheckDetailedTemplate;
								int num2 = _003CGetAuthItemsAsync_003Ed__48._003C_003E1__state;
								if (num2 == 0)
								{
									_ = _003CGetAuthItemsAsync_003Ed__48._003C_003Et__builder;
									_ = (delegate*<bool>)(&_003CEntityRequestAsync_003Ed__10<>.ReflectFinalizer);
									_003CGetAuthItemsAsync_003Ed__48.gameVersion = (EnumGameVersion)(int)new EntityItemDownload();
								}
								((AsyncTaskMethodBuilder<_00210>*)obj3)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<_00210>*)obj4, ref *(_003CRequestAsync_003Ed__12<_00210>*)num2);
								((AsyncTaskMethodBuilder<_00210>*)/*Error near IL_0a4f: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<RestResponse<_00210>>*)/*Error near IL_0a4f: Stack underflow*/, ref *(_003CRequestAsync_003Ed__13<_00210>*)/*Error near IL_0a4f: Stack underflow*/);
								_ = 24;
								obj = ((string)_003CEntityRequestAsync_003Ed__9.CheckGeneralDecider()).ToUpper();
								_ = 53;
								continue;
							}
							case 23:
							case 60:
								goto end_IL_0053;
							}
							break;
						}
						goto case 2;
						IL_0986:
						obj = ((_003CEntityRequestAsync_003Ed__10<>)this).checkCode;
						num = 59;
						goto IL_0076;
						IL_088b:
						obj = ((_003CDownloadImageAsync_003Ed__34)this)._003C_003E1__state;
						num = 12;
						if (((_003CDownloadImageAsync_003Ed__34)_003CDownloadImageAsync_003Ed__34._003C_003Et__builder).url == null)
						{
							num = 13;
						}
						goto IL_0076;
						IL_07c1:
						obj = ((_003CAddGameCharacterAsync_003Ed__44)this)._003C_003Et__builder;
						num = 41;
						if (((_003CAddGameCharacterAsync_003Ed__44*)(nint)_003CAddGameCharacterAsync_003Ed__44._003C_003E4__this)->type == 0)
						{
							num = 36;
						}
						goto IL_0076;
						end_IL_0053:
						break;
					}
					break;
				}
				case 7:
					return;
				case 5:
					obj = ((_003CGetGameCharactersAsync_003Ed__41)this)._003C_003E4__this;
					obj2 = 4;
					continue;
				case 3:
					((_003CGetGameCharactersAsync_003Ed__41)this).type = (EnumGameType)null;
					obj2 = 0;
					if ((int)((_003CGetGameCharactersAsync_003Ed__41*)(nint)_003CGetGameCharactersAsync_003Ed__41.gameId)->_003C_003Eu__1 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 1:
					_003CGetGameCharactersAsync_003Ed__41.ReadStruct = null;
					obj2 = 3;
					if ((int)((_003CGetGamePatchInfoAsync_003Ed__54*)_003CGetGamePatchInfoAsync_003Ed__54._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj2 = 3;
					}
					continue;
				case 4:
					obj = ((_003CGetGamePatchInfoAsync_003Ed__54)this)._003C_003E4__this;
					obj2 = 2;
					if ((int)((_003CGetGamePatchInfoAsync_003Ed__54*)(int)_003CGetGamePatchInfoAsync_003Ed__54.gameVersion)->_003C_003Eu__1 == 0)
					{
						obj2 = 2;
					}
					continue;
				default:
					_ = ref _003CGetGamePatchInfoAsync_003Ed__54.CheckInterruptibleVerifier;
					AsyncTaskMethodBuilder<EntityItemChannel[]>.Create();
					_ = 7;
					continue;
				case 6:
					break;
				}
				((_003CGetItemChannelAsync_003Ed__42)this)._003C_003Et__builder = (AsyncTaskMethodBuilder<EntityItemChannel[]>)(-2);
				obj2 = 1;
				if (((_003CGetItemChannelAsync_003Ed__42*)(nint)_003CGetItemChannelAsync_003Ed__42._003C_003E4__this)->itemIdList == null)
				{
					obj2 = 1;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_F400()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779070, new IntPtr(2737336613596L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_F500(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0044: Expected VT, but got Obj
			//IL_0044: Expected VT, but got Ref
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0044: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP != null)
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
		private unsafe sealed void _FF00_FF00_FF00_F600(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779065, new IntPtr(2737336620876L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_F700()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779064, new IntPtr(2737336621916L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_F800()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00豈()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetOwnedSkinsAsync_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<PageModel<IDesktopSkin>> _003C_003Et__builder;

		public int page;

		public DesktopSession _003C_003E4__this;

		private nint _003Ctotal_003E5__2;

		private object _003Cskins_003E5__3;

		private TaskAwaiter<Entities<EntityOwnedSkinItem>> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private static object CheckModularViewer;

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
		internal static bool DetachEvaluator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateAccessibleDictionary()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_E800()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779067, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_E900()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0047: Expected I4, but got Obj
			//IL_05ff: Expected Obj, but got I4
			//IL_05ff: Expected Obj, but got Ref
			//IL_007e: Expected Obj, but got Ref
			//IL_00a5: Expected Obj, but got Ref
			//IL_00b6: Expected Obj, but got I
			//IL_0052: Expected Obj, but got Ref
			//IL_0059: Expected VT, but got Obj
			//IL_0059: Expected VT, but got Ref
			//IL_0611: Expected Obj, but got Ref
			//IL_00dd: Expected Obj, but got I
			//IL_0360: Expected Obj, but got VT
			//IL_02c7: Expected Obj, but got I4
			//IL_036f: Expected Obj, but got I4
			//IL_0374: Expected Obj, but got I4
			//IL_037d: Expected Obj, but got I4
			//IL_038a: Expected I4, but got Obj
			//IL_0419: Expected VT, but got Obj
			//IL_03ec: Expected Obj, but got F8
			//IL_03ec: Expected Obj, but got Ref
			//IL_03f2: Expected VT, but got I4
			//IL_03fc: Expected native int or pointer, but got Obj
			//IL_021d: Expected Obj, but got I4
			//IL_0222: Expected Obj, but got I4
			//IL_02ab: Expected Obj, but got I4
			//IL_0273: Expected VT, but got Ref
			//IL_027f: Expected native int or pointer, but got Obj
			//IL_0209: Expected Obj, but got I4
			//IL_01e0: Expected Obj, but got Ref
			//IL_01f1: Expected Obj, but got I4
			//IL_01f3: Expected Obj, but got I4
			//IL_02d3: Expected Obj, but got Ref
			//IL_04ba: Expected Obj, but got Ref
			//IL_04bf: Expected I4, but got Obj
			//IL_04c4: Expected I4, but got Obj
			//IL_02fc: Expected Obj, but got I4
			//IL_0301: Expected VT, but got I4
			//IL_03b0: Expected Obj, but got Ref
			//IL_04f0: Expected I4, but got Obj
			//IL_04f5: Expected I4, but got Obj
			//IL_044d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0450: Unknown result type (might be due to invalid IL or missing references)
			//IL_0456: Expected VT, but got Unknown
			//IL_0456: Expected Ref, but got VT
			//IL_045e: Expected Obj, but got I4
			//IL_045e: Expected Ref, but got VT
			//IL_0469: Expected Obj, but got I4
			//IL_046b: Expected Obj, but got VT
			//IL_0339: Expected Obj, but got I4
			//IL_0312: Expected Obj, but got Ref
			//IL_048f: Expected Obj, but got I4
			//IL_0494: Expected Obj, but got I4
			//IL_02e2: Expected native int or pointer, but got Obj
			//IL_0609->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0094->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00bb->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006d->IL0026: Incompatible stack heights: 2 vs 1
			//IL_061b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_009f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00c6->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0078->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0382->IL00ed: Incompatible stack heights: 0 vs 1
			//IL_01fd->IL00f1: Incompatible stack heights: 3 vs 1
			//IL_047f->IL00f1: Incompatible stack heights: 2 vs 1
			//IL_00f1->IL00f1: Incompatible stack heights: 2 vs 1
			//IL_048a->IL00f1: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				case 3:
					((EqualityComparer<_00211>)/*Error near IL_0059: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)obj);
					_ = 5;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
					{
						_ = 4;
					}
					break;
				case 1:
					obj = DesktopAuthentication.Crc32;
					obj2 = 6;
					if (DesktopAuthentication.TokenKey == null)
					{
						obj2 = 3;
					}
					break;
				case 2:
					obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._client;
					obj2 = 0;
					if (((DesktopAuthentication)DesktopAuthentication._connected)._buffer == null)
					{
						obj2 = 1;
					}
					break;
				case 6:
					if (obj == null)
					{
						num = 21;
						if (((DesktopAuthentication)DesktopAuthentication._handshake)._handshakeSent == 0)
						{
							num = 20;
						}
						goto IL_00f1;
					}
					goto IL_019e;
				default:
					goto IL_05f7;
				case 5:
					return;
				case 4:
					{
						_003C_003Ec._003C_003E9__15_3 = null;
						obj2 = 3;
						break;
					}
					IL_05f7:
					_003C_003Ec._003C_003E9__15_2 = (Func<EntityNetGameItem, string>)(-2);
					obj2 = 4;
					break;
					IL_019e:
					if ((nint)obj != 1)
					{
						num = 13;
						if (((DesktopAuthentication)DesktopAuthentication._encryptChaCha)._decryptChaCha != null)
						{
							num = 7;
						}
						goto IL_00f1;
					}
					goto IL_0358;
					IL_0358:
					obj = ((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003Eu__1;
					num = 23;
					goto IL_00f1;
					IL_00f1:
					while (true)
					{
						scoped ref byte reference;
						switch (num)
						{
						case 17:
							return;
						case 26:
							break;
						case 8:
							return;
						case 14:
							obj = ((TaskCompletionSource)(object)((ILogger)new RuntimeHelpers((Array)/*Error near IL_01d9: Stack underflow*/, (RuntimeFieldHandle)/*Error near IL_01d9: Stack underflow*/)).Category((string)((DesktopAuthentication)Unsafe.AsPointer(ref this))._authenticationTcs)).TrySetException((Exception)((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E1__state);
							_ = 10;
							continue;
						case 13:
						{
							DesktopAuthentication desktopAuthentication = ((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E4__this;
							((DesktopAuthentication)1)._003CAuthentication_003Eb__27_0();
							((AsyncTaskMethodBuilder*)/*Error near IL_020e: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<int>*)/*Error near IL_020e: Stack underflow*/, ref *(DesktopAuthentication._003CReceiveDataAsync_003Ed__21*)desktopAuthentication);
							num = 22;
							continue;
						}
						case 7:
							obj = -1;
							((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003Ccts_003E5__2 = -1;
							num = 25;
							if ((int)((DesktopAuthentication._003CAuthentication_003Ed__27)DesktopAuthentication._003CAuthentication_003Ed__27._003C_003Eu__1)._003C_003Eu__2 != 0)
							{
								num = 5;
							}
							continue;
						case 23:
							DesktopAuthentication._003CAuthentication_003Ed__27.ReflectInternalAnnotation = null;
							num = 7;
							if (((DesktopAuthentication._003CConnect_003Ed__19)DesktopAuthentication._003CConnect_003Ed__19._003C_003Et__builder)._003C_003E4__this == null)
							{
								num = 6;
							}
							continue;
						default:
							((CancellationTokenSource)/*Error near IL_0273: Stack underflow*/)._002Ector((TimeSpan)(&obj));
							obj = (object)/*Error near IL_0275: Stack underflow*/;
							num = 6;
							if ((int)((DesktopAuthentication._003CConnect_003Ed__19*)(nint)DesktopAuthentication._003CConnect_003Ed__19._003Ccts_003E5__2)->_003C_003Eu__1 == 0)
							{
								num = 6;
							}
							continue;
						case 9:
							reference = ref Unsafe.As<object, byte>(ref DesktopAuthentication._003CConnect_003Ed__19.CheckAdjustableCommand);
							((AsyncTaskMethodBuilder<EntitySkinItem>*)(&obj))->Start(ref Unsafe.As<_003CGetOwnedSkinsAsync_003Ed__23, _003CGetSkinByIdAsync_003Ed__21>(ref this));
							obj = 17;
							continue;
						case 2:
							reference = ref Unsafe.As<AsyncTaskMethodBuilder, byte>(ref ((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003Et__builder);
							((AsyncTaskMethodBuilder<PageModel<IDesktopSkin>>*)(&obj))->Start(ref this);
							obj = 8;
							continue;
						case 15:
							((IDisposable)(&obj)).Dispose();
							if ((int)/*Error near IL_02d8: Stack underflow*/ == 0)
							{
								num = 15;
								if (((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24*)(nint)DesktopAuthentication._003CHeartbeatAsync_003Ed__25.ProcessResolver)->_003C_003E1__state != 0)
								{
									num = 27;
								}
								continue;
							}
							goto case 25;
						case 18:
							obj = -1;
							((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-1);
							num = 12;
							continue;
						case 25:
							((AsyncTaskMethodBuilder*)/*Error near IL_0312: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)(&obj));
							num = 14;
							if (DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24.ReflectMixedRunner == null)
							{
								num = 10;
							}
							continue;
						case 21:
						case 24:
							obj = ((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003E1__state;
							num = 1;
							if (((DesktopAuthentication._003CReceiveAsync_003Ed__20)DesktopAuthentication._003CReceiveAsync_003Ed__20._003C_003Et__builder)._003C_003E4__this == null)
							{
								num = 1;
							}
							continue;
						case 11:
							goto IL_0358;
						case 3:
							obj = 0;
							DesktopAuthentication._003CReceiveAsync_003Ed__20.CheckCommonTracker = 0;
							obj = 5;
							continue;
						case 4:
							((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this)._003C_003E1__state = (int)obj;
							num = 4;
							if (((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22._003C_003Et__builder)._003C_003E4__this == null)
							{
								num = 9;
							}
							continue;
						case 19:
							if (((Encoding)/*Error near IL_03b0: Stack underflow*/).GetBytes((string)(&obj)) != null)
							{
								num = 0;
								if ((int)((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22._003C_003Eu__1)._003C_003Eu__2 != 0)
								{
									num = 0;
								}
								continue;
							}
							goto case 3;
						case 6:
							((AuthenticationException)Unsafe.AsPointer(ref this))._002Ector((string?)((double)Enumerable.ToArray<TSource>((IEnumerable<TSource>)obj) / 20.0));
							Unsafe.Write(&((DesktopAuthentication._003CReceiveDataAsync_003Ed__21*)(nint)/*Error near IL_03f2: Stack underflow*/)->_003C_003Et__builder, (AsyncTaskMethodBuilder)(int)/*Error near IL_03ed: Stack underflow*/);
							num = 16;
							if (((DesktopAuthentication._003CReceiveDataAsync_003Ed__21*)(nint)DesktopAuthentication._003CReceiveDataAsync_003Ed__21._003C_003E4__this)->buffer == null)
							{
								num = 14;
							}
							continue;
						case 5:
							((DesktopAuthentication._003CReceiveDataAsync_003Ed__21)this)._003C_003Eu__1 = (TaskAwaiter<int>)obj;
							num = 2;
							continue;
						case 1:
							Unsafe.As<nint, @null>(ref ((DesktopAuthentication._003CReceiveDataAsync_003Ed__21)this)._003Clength_003E5__2) = null;
							num = 18;
							continue;
						case 22:
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = (DefaultInterpolatedStringHandler)new DefaultInterpolatedStringHandler((string)DesktopAuthentication._003CSendPacketAsync_003Ed__28.DecorateLocalSystem());
							((DefaultInterpolatedStringHandler*)defaultInterpolatedStringHandler)->AppendFormatted<T>((T)((((DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23)this)._003C_003Et__builder - 1) * 20));
							((DefaultInterpolatedStringHandler*)defaultInterpolatedStringHandler)->AppendFormatted((string?)20);
							((TaskCompletionSource)1).SetException((Exception)(object)Array.Empty<string>());
							obj = (object)defaultInterpolatedStringHandler;
							_ = 19;
							if ((int)((DesktopAuthentication._003CSendMessageAsync_003Ed__29*)DesktopAuthentication._003CSendMessageAsync_003Ed__29._003C_003E1__state)->_003C_003Et__builder != 0)
							{
								_ = 6;
							}
							continue;
						}
						case 27:
							obj = 1;
							((DesktopAuthentication._003CSendMessageAsync_003Ed__29)this)._003C_003E4__this = (DesktopAuthentication)1;
							num = 4;
							continue;
						case 16:
							((EndOfStreamException)obj)._002Ector();
							((DesktopAuthentication._003CSendPacketAsync_003Ed__28*)(nint)/*Error near IL_04c4: Stack underflow*/)->_003C_003E1__state = (int)((DesktopSession)/*Error near IL_04bf: Stack underflow*/).EntitiesRequestAsync<EntityNetGameVersion>((string)/*Error near IL_04bf: Stack underflow*/, (object)/*Error near IL_04bf: Stack underflow*/, (byte)(int)((IEnumerable<string>)Unsafe.AsPointer(ref this)).ToList() != 0);
							num = 20;
							if (((DesktopAuthentication._003CSendPacketAsync_003Ed__28)DesktopAuthentication._003CSendPacketAsync_003Ed__28._003C_003Et__builder).id != 0)
							{
								num = 8;
							}
							continue;
						case 20:
							obj = ((Stream)/*Error near IL_04f5: Stack underflow*/).ReadAsync((byte[])/*Error near IL_04f5: Stack underflow*/, (int)/*Error near IL_04f5: Stack underflow*/, (int)((DesktopSession)obj).GetOwnedSkinsAsync((int)((DesktopAuthentication._003CSendPacketAsync_003Ed__28)this).data));
							num = 15;
							if (((DesktopSession)DesktopAuthentication._003CSendPacketAsync_003Ed__28.CheckIterableSynchronizer)._netGames == null)
							{
								num = 15;
							}
							continue;
						case 10:
							goto IL_05f7;
						}
						break;
					}
					goto IL_019e;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_EA00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779066, new IntPtr(2737336612556L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_EB00(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP != null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_EC00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779045, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_ED00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779044, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_EE00()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_EF00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779047, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_F000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779046, new IntPtr(2737336628156L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_F100()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetRentalGameAddressAsync_003Ed__47 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityRentalGameAddress> _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		public string gameId;

		public string password;

		private TaskAwaiter<EntityRentalGameAddress> _003C_003Eu__1;

		internal static object DecorateIsolatedMonitor;

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
		internal static bool ReflectAutomatableSynchronizer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateIterableEditor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779041, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_E000()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0075: Expected Obj, but got Ref
			//IL_004e: Expected Obj, but got Ref
			//IL_0323: Expected Obj, but got Ref
			//IL_01d0: Expected native int or pointer, but got Obj
			//IL_0172: Expected VT, but got Ref
			//IL_019a: Expected Obj, but got I4
			//IL_019f: Expected Obj, but got I4
			//IL_019f: Expected Obj, but got Ref
			//IL_022a: Expected VT, but got Obj
			//IL_015b: Expected Obj, but got Ref
			//IL_0127: Expected I, but got Obj
			//IL_0127: Expected Obj, but got Ref
			//IL_0186: Expected Obj, but got I4
			//IL_018b: Expected Obj, but got I4
			//IL_018b: Expected Obj, but got Ref
			//IL_0252: Expected I, but got Obj
			//IL_025e: Expected native int or pointer, but got Obj
			//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_032d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0349->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0096->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0354->IL0026: Incompatible stack types: I4 vs Obj
			//IL_023c->IL0242: Incompatible stack heights: 5 vs 3
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 1;
			object obj = awaiter;
			while (true)
			{
				int num;
				switch ((int)obj)
				{
				case 1:
					awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
					obj = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP == null)
					{
						obj = 0;
					}
					continue;
				default:
					awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CserverId_003EP;
					obj = 4;
					if (DesktopAuthentication.Logger == null)
					{
						obj = 4;
					}
					continue;
				case 4:
					if (awaiter != null)
					{
						num = 4;
						if (((DesktopAuthentication)(object)DesktopAuthentication.TokenKey)._client != null)
						{
							num = 1;
						}
						goto IL_00c1;
					}
					goto IL_01be;
				case 3:
					return;
				case 2:
					((ILogger)/*Error near IL_0323: Stack underflow*/).Warning((Exception)Unsafe.AsPointer(ref ((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003Eu__1), (string)awaiter);
					obj = 3;
					continue;
				case 5:
					break;
					IL_00c1:
					while (true)
					{
						switch (num)
						{
						case 1:
							_ = ref awaiter;
							/*Error near IL_00f9: Member reference must be method, but was: Field*/;
						case 7:
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeSent = (nint)awaiter;
							num = 4;
							if (((DesktopAuthentication)DesktopAuthentication._handshakeKey)._encryptedToken == null)
							{
								num = 9;
							}
							continue;
						case 6:
							return;
						case 5:
							Unsafe.As<object, AsyncTaskMethodBuilder<EntityNetGameItem[]>>(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptChaCha) = default;
							num = 3;
							continue;
						case 2:
							RuntimeHelpers.InitializeArray((Array)/*Error near IL_0172: Stack underflow*/, (RuntimeFieldHandle)(&awaiter));
							if ((int)/*Error near IL_0177: Stack underflow*/ == 0)
							{
								num = 8;
								continue;
							}
							goto case 1;
						case 8:
							awaiter = 0;
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._authenticationTcs = 0;
							num = 7;
							continue;
						case 3:
							awaiter = -1;
							DesktopAuthentication.PrepareDic = (DesktopAuthentication)(-1);
							num = 1;
							if ((int)((DesktopAuthentication._003CAuthentication_003Ed__27*)DesktopAuthentication._003CAuthentication_003Ed__27._003C_003E1__state)->_003C_003Et__builder != 0)
							{
								num = 1;
							}
							continue;
						case 10:
							break;
						case 9:
							Unsafe.As<object, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003Ccts_003E5__2).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CGetRentalGameAddressAsync_003Ed__47, DesktopAuthentication._003CSendPacketAsync_003Ed__28>(ref this));
							num = 0;
							if (DesktopAuthentication._003CAuthentication_003Ed__27.ReflectInternalAnnotation != null)
							{
								num = 6;
							}
							continue;
						case 4:
						{
							object obj2 = awaiter;
							object obj3 = DesktopAuthentication._003CAuthentication_003Ed__27.PopChooser();
							Task<byte[]> task = (Task<byte[]>)new Task<byte[]>();
							((CancellationTokenSource)(object)task)._002Ector((TimeSpan)((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003E4__this);
							if (((DesktopAuthentication._003CConnect_003Ed__19)this)._003Ccts_003E5__2 == null)
							{
								((DesktopAuthentication._003CHeartbeatAsync_003Ed__25*)task)->MoveNext();
							}
							((AsyncTaskMethodBuilder<EntitySkinItem>*)((TaskCompletionSource)(object)task).Task)->Start(ref *(_003CGetSkinByIdAsync_003Ed__21*)1);
							((Action)/*Error near IL_0252: Stack underflow*/)._002Ector(obj2, (nint)obj3);
							awaiter = (object)/*Error near IL_0254: Stack underflow*/;
							num = 2;
							if ((int)((DesktopAuthentication._003CHeartbeatAsync_003Ed__25*)(nint)DesktopAuthentication._003CHeartbeatAsync_003Ed__25._003C_003E4__this)->_003C_003Eu__1 != 0)
							{
								num = 2;
							}
							continue;
						}
						default:
							goto end_IL_0026;
						}
						break;
					}
					goto IL_01be;
					IL_01be:
					awaiter = ((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E4__this;
					num = 2;
					if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27.modHashList)->serverIdHash == null)
					{
						num = 5;
					}
					goto IL_00c1;
					end_IL_0026:
					break;
				}
				((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this)._003C_003E1__state = -2;
				obj = 1;
				if (((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22._003C_003Et__builder)._003C_003E4__this == null)
				{
					obj = 2;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_E100(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779040, new IntPtr(2737336628156L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_E200(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP != null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_E300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779043, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_E400()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_E500()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_E600()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779042, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetRentalGameCharactersAsync_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityRentalGameCharacter[]> _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		public string gameId;

		private TaskAwaiter<EntityRentalGameCharacter[]> _003C_003Eu__1;

		internal static object JoinViewer;

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
		internal static bool MoveCalculator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateSymbolicCollection()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00혀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779053, new IntPtr(2737336634396L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00휀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0050: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got Ref
			//IL_0060: Expected Obj, but got Ref
			//IL_0300: Expected Obj, but got VT
			//IL_024c: Expected Obj, but got VT
			//IL_0101: Expected Obj, but got I4
			//IL_0106: Expected Obj, but got Ref
			//IL_012b: Expected Obj, but got Ref
			//IL_01b5: Expected Obj, but got Ref
			//IL_00d8: Expected Obj, but got I4
			//IL_00dd: Expected Obj, but got I4
			//IL_00dd: Expected Obj, but got Ref
			//IL_0157: Expected Obj, but got Ref
			//IL_01a4: Expected VT, but got Obj
			//IL_021e: Expected VT, but got Obj
			//IL_022d: Expected Obj, but got I4
			//IL_023a: Expected Obj, but got VT
			//IL_01c4: Expected native int or pointer, but got Obj
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_007b->IL0026: Incompatible stack heights: 4 vs 1
			//IL_030a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0326->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0086->IL0026: Incompatible stack heights: 4 vs 1
			//IL_0331->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0244->IL009d: Incompatible stack heights: 4 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 5;
			object obj = awaiter;
			while (true)
			{
				int num;
				switch ((int)obj)
				{
				default:
					return;
				case 1:
					((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP = -2;
					obj = 2;
					break;
				case 2:
					_ = ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserToken_003EP;
					_ = EqualityComparer<_00210>.Default;
					_ = 0;
					if (DesktopAuthentication.Crc32 != null)
					{
						_ = 0;
					}
					break;
				case 0:
					return;
				case 3:
					if (awaiter != null)
					{
						num = 10;
						goto IL_009d;
					}
					goto IL_0244;
				case 4:
					awaiter = ((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003Et__builder;
					obj = 3;
					break;
				case 5:
					{
						awaiter = ((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003E4__this;
						obj = 4;
						if (DesktopAuthentication._003CReceiveAsync_003Ed__20.CheckCommonTracker == null)
						{
							obj = 1;
						}
						break;
					}
					IL_0244:
					awaiter = ((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003Et__builder;
					num = 2;
					goto IL_009d;
					IL_009d:
					while (true)
					{
						switch (num)
						{
						case 1:
							break;
						case 3:
							return;
						case 6:
							awaiter = -1;
							DesktopAuthentication.Logger = -1;
							num = 2;
							if (((DesktopAuthentication)(object)DesktopAuthentication.TokenKey)._client == null)
							{
								num = 8;
							}
							continue;
						default:
							awaiter = 0;
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._connected = 0;
							num = 9;
							if (((DesktopAuthentication)(object)DesktopAuthentication._buffer)._handshake == 0)
							{
								num = 4;
							}
							continue;
						case 2:
							Unsafe.As<nint, _003CEntitiesRequestAsync_003Ed__11<_0021_00210>>(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeSent) = default;
							num = 1;
							if (((DesktopAuthentication)DesktopAuthentication._encryptedToken)._encryptChaCha == null)
							{
								num = 6;
							}
							continue;
						case 8:
							GC.SuppressFinalize((object)(&awaiter));
							awaiter = (object)/*Error near IL_0159: Stack underflow*/;
							num = 1;
							if (((DesktopAuthentication)DesktopAuthentication._handshakeTcs)._authenticationTcs != null)
							{
								num = 0;
							}
							continue;
						case 9:
							((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)awaiter;
							num = 4;
							continue;
						case 5:
							((IAsyncStateMachine)(&awaiter)).MoveNext();
							if ((int)/*Error near IL_01ba: Stack underflow*/ == 0)
							{
								num = 0;
								if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27.modHashList)->serverIdHash == null)
								{
									num = 0;
								}
								continue;
							}
							goto case 8;
						case 4:
							Unsafe.As<object, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003Ccts_003E5__2).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CGetRentalGameCharactersAsync_003Ed__43, DesktopAuthentication._003CSendPacketAsync_003Ed__28>(ref this));
							num = 3;
							if (DesktopAuthentication._003CAuthentication_003Ed__27.ReflectInternalAnnotation == null)
							{
								num = 1;
							}
							continue;
						case 10:
						{
							DesktopAuthentication._003CAuthentication_003Ed__27.PopChooser();
							Task<byte[]> task = (Task<byte[]>)new Task<byte[]>();
							((CancellationTokenSource)(object)task)._002Ector((TimeSpan)((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003E4__this);
							((TaskAwaiter*)null)->GetResult();
							((TaskCompletionSource)10)._002Ector();
							((AsyncTaskMethodBuilder<PageModel<IDesktopSkin>>*)task)->Start(ref *(_003CGetSkinsAsync_003Ed__20*)1);
							awaiter = ((CancellationTokenSource)(object)task).Token;
							_ = 5;
							continue;
						}
						case 7:
							goto IL_0244;
						}
						break;
					}
					goto case 1;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779052, new IntPtr(2737336619836L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FFFD(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0044: Expected VT, but got Obj
			//IL_0044: Expected VT, but got Ref
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0044: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP != null)
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
		private unsafe sealed void _FF00_FF00_FF00_FFFD(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779055, new IntPtr(2737336613596L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779054, new IntPtr(2737336619836L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FFFD()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FFFD()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetRentalGamesAsync_003Ed__51 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityRentalGameItem[]> _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		public string keyword;

		private TaskAwaiter<EntityRentalGameItem[]> _003C_003Eu__1;

		private static object DecorateConfigurableProfile;

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
		internal static bool CheckSeparatedChooser()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectMonoSolver()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00쬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779049, new IntPtr(2737336613596L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00찀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_02fa: Expected Obj, but got VT
			//IL_0303: Expected Obj, but got I4
			//IL_004e: Expected Obj, but got Ref
			//IL_0078: Expected Obj, but got I4
			//IL_0078: Expected Obj, but got Ref
			//IL_0088: Expected Obj, but got Ref
			//IL_008f: Expected VT, but got Obj
			//IL_008f: Expected Obj, but got Ref
			//IL_0143: Expected Obj, but got Ref
			//IL_00ee: Expected Obj, but got I4
			//IL_00f3: Expected Obj, but got I4
			//IL_00f3: Expected Obj, but got Ref
			//IL_0246: Expected Obj, but got Ref
			//IL_0246: Expected Obj, but got Ref
			//IL_0118: Expected Obj, but got Ref
			//IL_012d: Expected Obj, but got I
			//IL_018a: Expected Obj, but got I4
			//IL_0191: Expected Obj, but got I4
			//IL_0229: Expected Obj, but got I4
			//IL_022e: Expected Obj, but got I4
			//IL_0215: Expected F8, but got Ref
			//IL_0156: Expected Obj, but got Ref
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0082->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0099->IL0026: Incompatible stack heights: 2 vs 1
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0250->IL00af: Incompatible stack heights: 3 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					int num;
					switch ((int)obj2)
					{
					case 1:
						obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
						obj2 = 0;
						if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP == null)
						{
							obj2 = 0;
						}
						continue;
					case 3:
						return;
					case 2:
						((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CserverId_003EP = -2;
						obj2 = 5;
						continue;
					case 5:
						((EqualityComparer<_00211>)Unsafe.AsPointer(ref DesktopAuthentication.Crc32)).GetHashCode((_00211)obj);
						_ = 3;
						continue;
					case 4:
						{
							if (obj != null)
							{
								num = 7;
								goto IL_00af;
							}
							goto IL_013d;
						}
						IL_013d:
						obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptedToken;
						num = 6;
						goto IL_00af;
						IL_00af:
						while (true)
						{
							switch (num)
							{
							case 8:
								return;
							case 3:
								obj = -1;
								DesktopAuthentication.TokenKey = (byte[])(-1);
								num = 5;
								if (((DesktopAuthentication)DesktopAuthentication._client)._connected != 0)
								{
									num = 11;
								}
								continue;
							case 6:
								Unsafe.As<List<byte>, _003CEntityRequestAsync_003Ed__10<_0021_00210>>(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._buffer) = default;
								num = 3;
								if (((DesktopAuthentication)DesktopAuthentication._handshakeSent)._handshakeKey == null)
								{
									num = 0;
								}
								continue;
							case 1:
								goto IL_013d;
							case 2:
							case 11:
								((TcpClient)(&obj)).Close();
								obj = (object)/*Error near IL_0158: Stack underflow*/;
								num = 0;
								if (((DesktopAuthentication)DesktopAuthentication._decryptChaCha)._handshakeTcs != null)
								{
									num = 0;
								}
								continue;
							case 7:
							{
								ILogger loggerExtensions = new LoggerExtensions((ILogger)/*Error near IL_0183: Stack underflow*/, (string)((DesktopAuthentication)/*Error near IL_017e: Stack underflow*/).SendPacketAsync((byte)/*Error near IL_017e: Stack underflow*/, obj));
								((TimeoutException)(object)loggerExtensions)._002Ector((string?)0);
								bool flag = ((TaskCompletionSource)(object)loggerExtensions).TrySetException((Exception)0);
								(flag ? ((AsyncTaskMethodBuilder*)1) : ((AsyncTaskMethodBuilder*)null))->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(flag ? ((TAwaiter*)1) : ((TAwaiter*)null)), ref *(TStateMachine*)((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E4__this);
								((AsyncTaskMethodBuilder*)/*Error near IL_01a3: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<int>*)loggerExtensions, ref *(DesktopAuthentication._003CReceiveDataAsync_003Ed__21*)1);
								obj = ((TaskAwaiter<byte[]>*)/*Error near IL_01a8: Stack underflow*/)->GetResult();
								num = 10;
								if ((int)((DesktopAuthentication._003CAuthentication_003Ed__27)DesktopAuthentication._003CAuthentication_003Ed__27._003C_003Eu__1)._003C_003Eu__2 != 0)
								{
									num = 10;
								}
								continue;
							}
							case 4:
								DesktopAuthentication._003CAuthentication_003Ed__27.ReflectInternalAnnotation = obj;
								num = 5;
								continue;
							case 10:
								if ((int)TimeSpan.FromSeconds((double)(nint)(&obj)) != 0)
								{
									num = 2;
									continue;
								}
								goto case 9;
							case 9:
								obj = 0;
								((DesktopAuthentication._003CConnect_003Ed__19)this).authServer = (EntityAuthServer)0;
								num = 4;
								continue;
							case 5:
								_ = ref ((DesktopAuthentication._003CConnect_003Ed__19)this)._003Ccts_003E5__2;
								((IEnumerable<EntityNetGameItem>)(&obj)).FirstOrDefault((Func<EntityNetGameItem, bool>)Unsafe.AsPointer(ref this));
								_ = 8;
								continue;
							}
							break;
						}
						goto case 2;
					}
					break;
				}
				obj = ((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003Eu__1;
				obj = 4;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00촀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779048, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00츀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP != null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00케(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779051, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00퀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779050, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00턀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00툀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779029, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00팀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779028, new IntPtr(2737336618796L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00퐀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetServerTimeAsync_003Ed__58 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityServerTime> _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		private TaskAwaiter<EntityServerTime> _003C_003Eu__1;

		internal static object ReflectOrderedTester;

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
		internal static bool AttachRole()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateScopeResolver()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00쌀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779031, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00쐀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_004e: Expected Obj, but got Ref
			//IL_02f9: Expected Obj, but got VT
			//IL_00d6: Expected Obj, but got Ref
			//IL_01ed: Expected Obj, but got I4
			//IL_01f2: Expected Obj, but got I4
			//IL_00e8: Expected Obj, but got Ref
			//IL_01a0: Expected Obj, but got Ref
			//IL_01ac: Expected native int or pointer, but got Obj
			//IL_015a: Expected Obj, but got Ref
			//IL_0162: Expected Obj, but got Ref
			//IL_016c: Expected native int or pointer, but got Obj
			//IL_0203: Expected Obj, but got Ref
			//IL_0186: Expected Obj, but got I4
			//IL_018b: Expected VT, but got I4
			//IL_0194: Expected Obj, but got I4
			//IL_00cb: Expected I4, but got Obj
			//IL_0324->IL0026: Incompatible stack heights: 3 vs 1
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0303->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02e5->IL0026: Incompatible stack types: I4 vs Obj
			//IL_032f->IL0026: Incompatible stack heights: 3 vs 1
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02f0->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00e2->IL009a: Incompatible stack types: I4 vs Obj
			//IL_008b->IL009a: Incompatible stack types: I4 vs Obj
			//IL_0096->IL009a: Incompatible stack types: I4 vs Obj
			//IL_01fc->IL009a: Incompatible stack types: I4 vs Obj
			//IL_00f8->IL009a: Incompatible stack types: I4 vs Obj
			//IL_01b6->IL009a: Incompatible stack types: I4 vs Obj
			//IL_01dd->IL009a: Incompatible stack types: I4 vs Obj
			//IL_0125->IL009a: Incompatible stack types: I4 vs Obj
			//IL_0176->IL009a: Incompatible stack heights: 3 vs 1
			//IL_01c1->IL009a: Incompatible stack types: I4 vs Obj
			//IL_01e8->IL009a: Incompatible stack types: I4 vs Obj
			//IL_0130->IL009a: Incompatible stack types: I4 vs Obj
			//IL_0181->IL009a: Incompatible stack heights: 3 vs 1
			//IL_021c->IL009a: Incompatible stack types: I4 vs Obj
			//IL_0227->IL009a: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				default:
					return;
				case 2:
					obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
					obj2 = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP == null)
					{
						obj2 = 5;
					}
					break;
				case 5:
					if (obj != null)
					{
						obj3 = 6;
						if (DesktopAuthentication.Crc32 == null)
						{
							obj3 = 1;
						}
						goto IL_009a;
					}
					goto IL_00d0;
				case 4:
					goto IL_02c9;
				case 0:
					return;
				case 3:
					obj = ((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003Eu__1;
					obj2 = 2;
					break;
				case 1:
					{
						_ = ref DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24.ReflectMixedRunner;
						_ = ((EntityAuthServer)obj).Port;
						_ = 0;
						if (((DesktopAuthentication._003CReceiveAsync_003Ed__20)DesktopAuthentication._003CReceiveAsync_003Ed__20._003C_003Et__builder)._003C_003E4__this != null)
						{
							_ = 0;
						}
						break;
					}
					IL_009a:
					while (true)
					{
						switch ((int)obj3)
						{
						case 8:
							break;
						case 2:
							Unsafe.As<byte[], ReadOnlyMemory<byte>>(ref DesktopAuthentication.TokenKey) = default;
							obj3 = 10;
							continue;
						case 6:
							((AsyncTaskMethodBuilder*)/*Error near IL_010a: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)((DesktopAuthentication)(object)((DesktopAuthentication)/*Error near IL_00ff: Stack underflow*/).Connect((EntityAuthServer)obj)).ReceiveAsync(), ref *(DesktopAuthentication._003CHeartbeatAsync_003Ed__25*)1);
							obj = ((AsyncTaskMethodBuilder*)/*Error near IL_010f: Stack underflow*/)->Task;
							obj3 = 7;
							if (((DesktopAuthentication)DesktopAuthentication._handshakeKey)._encryptedToken != null)
							{
								obj3 = 9;
							}
							continue;
						case 1:
							return;
						case 7:
							_ = ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeTcs;
							((IEnumerable<byte>)(&obj)).Skip((int)Unsafe.AsPointer(ref this));
							_ = 0;
							if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication.PrepareDic)->_003C_003E1__state == 0)
							{
								_ = 1;
							}
							continue;
						case 10:
							obj = -1;
							((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-1);
							obj = 3;
							obj3 = obj;
							continue;
						case 3:
							((IAsyncStateMachine)(&obj)).MoveNext();
							obj = (object)/*Error near IL_01a2: Stack underflow*/;
							obj3 = 1;
							if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27.modHashList)->serverIdHash != null)
							{
								obj3 = 4;
							}
							continue;
						case 5:
							((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003Ccts_003E5__2 = obj;
							obj3 = 7;
							if ((int)((DesktopAuthentication._003CAuthentication_003Ed__27)DesktopAuthentication._003CAuthentication_003Ed__27._003C_003Eu__1)._003C_003Eu__2 == 0)
							{
								obj3 = 1;
							}
							continue;
						default:
							obj = 0;
							DesktopAuthentication._003CAuthentication_003Ed__27.ReflectInternalAnnotation = 0;
							obj3 = 5;
							continue;
						case 9:
							if (((MassService)/*Error near IL_0203: Stack underflow*/).JoinServerAsync((byte[])/*Error near IL_0203: Stack underflow*/, (string)/*Error near IL_0203: Stack underflow*/, (string)/*Error near IL_0203: Stack underflow*/, (string)/*Error near IL_0203: Stack underflow*/, (string)/*Error near IL_0203: Stack underflow*/, (string)(&obj)) == null)
							{
								obj3 = 0;
								if (((DesktopAuthentication._003CConnect_003Ed__19)DesktopAuthentication._003CConnect_003Ed__19._003C_003Et__builder)._003C_003E4__this != null)
								{
									obj3 = 0;
								}
								continue;
							}
							goto case 3;
						case 4:
							goto IL_02c9;
						}
						break;
					}
					goto IL_00d0;
					IL_02c9:
					((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003E1__state = -2;
					obj2 = 0;
					if (((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 1;
					}
					break;
					IL_00d0:
					obj = DesktopAuthentication.Logger;
					obj3 = 2;
					goto IL_009a;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00씀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779030, new IntPtr(2737336616716L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00였(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP != null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00윀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00저()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00준()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779025, new IntPtr(2737336619836L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetSkinByIdAsync_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntitySkinItem> _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		public string skinId;

		private TaskAwaiter<EntitySkinItem[]> _003C_003Eu__1;

		private static object ReflectStaticDecryptor;

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
		internal static bool CheckDynamicError()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectConcreteCache()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00뤀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779024, new IntPtr(2737336633356L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00먀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_02ec: Expected Obj, but got I4
			//IL_0060: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got Ref
			//IL_0087: Expected Obj, but got Ref
			//IL_008e: Expected VT, but got Obj
			//IL_008e: Expected Obj, but got Ref
			//IL_01e9: Expected Obj, but got VT
			//IL_00c4: Expected Obj, but got I
			//IL_011a: Expected I, but got Obj
			//IL_011a: Expected Obj, but got Ref
			//IL_0129: Expected Obj, but got I
			//IL_01b9: Expected native int or pointer, but got Obj
			//IL_0233: Expected Obj, but got I4
			//IL_0238: Expected Obj, but got I4
			//IL_0242: Expected native int or pointer, but got Obj
			//IL_017c: Expected Obj, but got Ref
			//IL_0192: Expected Obj, but got I4
			//IL_0197: Expected Obj, but got I4
			//IL_0149: Expected Obj, but got Ref
			//IL_0154: Expected VT, but got Obj
			//IL_02f6->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0076->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00a2->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0081->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ad->IL0026: Incompatible stack heights: 2 vs 1
			//IL_01ff->IL022e: Incompatible stack heights: 1 vs 0
			//IL_0209->IL00d8: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 1;
			object obj = awaiter;
			while (true)
			{
				int num;
				switch ((int)obj)
				{
				case 3:
					((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP = -2;
					obj = 5;
					break;
				case 1:
					awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserToken_003EP;
					obj = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP != null)
					{
						obj = 0;
					}
					break;
				case 5:
					((EqualityComparer<_00211>)Unsafe.AsPointer(ref DesktopAuthentication.Crc32)).GetHashCode((_00211)awaiter);
					_ = 2;
					if (((DesktopAuthentication)(object)DesktopAuthentication.TokenKey)._client == null)
					{
						_ = 2;
					}
					break;
				case 4:
					if (awaiter != null)
					{
						num = 4;
						if (((DesktopAuthentication)DesktopAuthentication._connected)._buffer == null)
						{
							num = 11;
						}
						goto IL_00d8;
					}
					goto IL_01e1;
				default:
					awaiter = ((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003E1__state;
					obj = 4;
					break;
				case 2:
					return;
					IL_01e1:
					awaiter = ((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Eu__2;
					num = 9;
					goto IL_00d8;
					IL_00d8:
					while (true)
					{
						switch (num)
						{
						case 5:
							break;
						default:
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshake = (nint)awaiter;
							num = 3;
							if (((DesktopAuthentication)DesktopAuthentication._handshakeSent)._handshakeKey != null)
							{
								num = 1;
							}
							continue;
						case 11:
						{
							object obj2 = awaiter;
							((DesktopAuthentication)(object)new ILogger[1] { (ILogger)((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptChaCha }).Disconnect();
							RuntimeHelpers.InitializeArray((Array)/*Error near IL_0154: Stack underflow*/, (RuntimeFieldHandle)obj2);
							awaiter = (object)/*Error near IL_0156: Stack underflow*/;
							num = 1;
							if (DesktopAuthentication.PrepareDic == null)
							{
								num = 1;
							}
							continue;
						}
						case 7:
						case 10:
							((TimeoutException)/*Error near IL_017c: Stack underflow*/)._002Ector((string?)(&awaiter));
							((DefaultInterpolatedStringHandler*)/*Error near IL_0181: Stack underflow*/)->AppendFormatted((byte)/*Error near IL_0181: Stack underflow*/);
							awaiter = (object)/*Error near IL_0183: Stack underflow*/;
							num = 5;
							continue;
						case 8:
							awaiter = -1;
							((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E4__this = (DesktopAuthentication)(-1);
							num = 7;
							continue;
						case 3:
							Unsafe.As<string, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication._003CAuthentication_003Ed__27)this).modHashList).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<int>*)(&awaiter), ref Unsafe.As<_003CGetSkinByIdAsync_003Ed__21, DesktopAuthentication._003CReceiveDataAsync_003Ed__21>(ref this));
							num = 4;
							if ((int)((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27._003Ccts_003E5__2)->_003C_003Eu__1 != 0)
							{
								num = 4;
							}
							continue;
						case 4:
							return;
						case 2:
							goto IL_01e1;
						case 1:
							_ = ref awaiter;
							if (MassService.Instance != null)
							{
								_ = 10;
								continue;
							}
							goto case 6;
						case 9:
							Unsafe.As<int, AsyncTaskMethodBuilder<EntityRentalGameCharacter[]>>(ref ((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003E1__state) = default;
							num = 8;
							continue;
						case 6:
							awaiter = 0;
							((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003E4__this = (DesktopAuthentication)0;
							num = 0;
							if (((DesktopAuthentication._003CConnect_003Ed__19*)(nint)DesktopAuthentication._003CConnect_003Ed__19.authServer)->_003Ccts_003E5__2 != null)
							{
								num = 0;
							}
							continue;
						}
						break;
					}
					goto case 3;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00묀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779027, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00밀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0044: Expected VT, but got Obj
			//IL_0044: Expected VT, but got Ref
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0044: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
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
		private unsafe sealed void _FF00_FF00_FF00봀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779026, new IntPtr(2737336628156L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00븀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779037, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00뼀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00쀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779036, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00섀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetSkinImagesAsync_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public IDesktopSkin[] skins;

		public DesktopSession _003C_003E4__this;

		private TaskAwaiter<EntityItemChannel[]> _003C_003Eu__1;

		private static object DefineTester;

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
		internal static bool StoreTracer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateEditablePublisher()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00꼀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779039, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00뀀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_008d: Expected Obj, but got I4
			//IL_008d: Expected Obj, but got Ref
			//IL_0064: Expected Obj, but got Ref
			//IL_009d: Expected Obj, but got Ref
			//IL_004e: Expected Obj, but got Ref
			//IL_0053: Expected VT, but got Ref
			//IL_045d: Expected Ref, but got VT
			//IL_046e: Expected Obj, but got I4
			//IL_046e: Expected Obj, but got I4
			//IL_0452: Expected Obj, but got I
			//IL_01e2: Expected Obj, but got I4
			//IL_02a5: Expected F8, but got VT
			//IL_01ab: Expected VT, but got Ref
			//IL_037a: Unknown result type (might be due to invalid IL or missing references)
			//IL_037d: Expected Obj, but got Unknown
			//IL_0242: Expected native int or pointer, but got Obj
			//IL_01c0: Expected Obj, but got Ref
			//IL_03d2: Expected Obj, but got I4
			//IL_0342: Expected Obj, but got I4
			//IL_02d8: Expected Obj, but got I4
			//IL_02dd: Expected Obj, but got I4
			//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ed: Expected Obj, but got Unknown
			//IL_0267: Expected Obj, but got I4
			//IL_0169: Expected Obj, but got Ref
			//IL_016b: Expected Obj, but got I
			//IL_0424: Expected Obj, but got I4
			//IL_0330: Expected Obj, but got I4
			//IL_0335: Expected VT, but got I4
			//IL_0191: Expected Obj, but got Ref
			//IL_015e: Expected I4, but got Obj
			//IL_0097->IL0026: Incompatible stack types: I4 vs Obj
			//IL_007a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00b3->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005d->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00da->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_0085->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00be->IL0026: Incompatible stack types: I4 vs Obj
			//IL_036c->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_00e5->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_047a->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_0377->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_0307->IL00e9: Incompatible stack heights: 2 vs 1
			//IL_02af->IL00e9: Incompatible stack heights: 3 vs 1
			//IL_0387->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_024c->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_01d2->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_03f2->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_03dc->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_034c->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_02e7->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_0201->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_017f->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_042e->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_033f->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_01a4->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_01ba->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_0257->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_02d3->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_0411->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_020c->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_018a->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_041c->IL00e9: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 3;
			object obj = awaiter;
			while (true)
			{
				object obj2;
				object obj5;
				switch ((int)obj)
				{
				case 4:
					((EqualityComparer<_00211>)/*Error near IL_0053: Stack underflow*/).Equals((_00211?)/*Error near IL_0053: Stack underflow*/, (_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP));
					_ = 5;
					break;
				case 5:
					return;
				case 2:
					awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CgameVersion_003EP;
					obj = 1;
					if (DesktopAuthentication.Crc32 == null)
					{
						obj = 0;
					}
					break;
				default:
					DesktopAuthentication.Logger = -2;
					obj = 4;
					break;
				case 3:
					awaiter = DesktopAuthentication.TokenKey;
					obj = 2;
					if (((DesktopAuthentication)DesktopAuthentication._client)._connected != 0)
					{
						obj = 2;
					}
					break;
				case 1:
					{
						if (awaiter == null)
						{
							obj2 = 0;
							if (((DesktopAuthentication)(object)DesktopAuthentication._buffer)._handshake == 0)
							{
								obj2 = 0;
							}
							goto IL_00e9;
						}
						goto IL_034c;
					}
					IL_00e9:
					while (true)
					{
						switch ((int)obj2)
						{
						case 10:
							return;
						case 15:
						case 24:
							break;
						default:
							awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeSent;
							obj2 = 8;
							if (((DesktopAuthentication)DesktopAuthentication._handshakeKey)._encryptedToken == null)
							{
								obj2 = 3;
							}
							continue;
						case 11:
						case 27:
							((TcpClient)(&awaiter)).Close();
							awaiter = new GC((object)/*Error near IL_0196: Stack underflow*/);
							awaiter = (object)/*Error near IL_019a: Stack underflow*/;
							obj2 = 12;
							continue;
						case 4:
							RuntimeHelpers.InitializeArray((Array)/*Error near IL_01ab: Stack underflow*/, (RuntimeFieldHandle)(&awaiter));
							if ((int)/*Error near IL_01b0: Stack underflow*/ != 0)
							{
								obj2 = 11;
								continue;
							}
							goto case 25;
						case 7:
							Unsafe.As<object?, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._authenticationTcs).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<byte[]>*)(&awaiter), ref Unsafe.As<_003CGetSkinImagesAsync_003Ed__25, DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22>(ref this));
							obj2 = 10;
							continue;
						case 1:
							awaiter = ((object[])awaiter)[awaiter];
							awaiter = 3;
							goto IL_00e5;
						case 19:
							awaiter++;
							obj2 = 14;
							if ((int)((DesktopAuthentication._003CAuthentication_003Ed__27*)DesktopAuthentication._003CAuthentication_003Ed__27._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								obj2 = 2;
							}
							continue;
						case 6:
							((DesktopAuthentication._003CAuthentication_003Ed__27)this).serverIdHash = (string)awaiter;
							obj2 = 3;
							if ((int)((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27._003Ccts_003E5__2)->_003C_003Eu__1 != 0)
							{
								obj2 = 7;
							}
							continue;
						case 20:
							awaiter = ((object[])awaiter)[awaiter];
							awaiter = 2;
							goto IL_00e5;
						case 3:
							((MassService)/*Error near IL_0299: Stack underflow*/).JoinServerAsync((byte[])/*Error near IL_0299: Stack underflow*/, (string)/*Error near IL_0299: Stack underflow*/, (string)/*Error near IL_0299: Stack underflow*/, (string)/*Error near IL_0299: Stack underflow*/, (string)awaiter, (string)awaiter);
							TimeSpan.FromSeconds((double)((Task<byte[]>)awaiter).GetAwaiter());
							_ = 5;
							continue;
						case 13:
						case 14:
							if ((nint)awaiter >= ((Array)awaiter).Length)
							{
								obj2 = 15;
								continue;
							}
							goto case 20;
						case 17:
							awaiter = -1;
							((DesktopAuthentication._003CConnect_003Ed__19)this).authServer = (EntityAuthServer)(-1);
							obj2 = 27;
							continue;
						case 2:
						{
							object obj3 = awaiter;
							object obj4 = awaiter;
							((TaskAwaiter*)awaiter)->GetResult();
							((AsyncTaskMethodBuilder<PageModel<IDesktopSkin>>*)obj3)->Start(ref *(_003CGetSkinsAsync_003Ed__20*)obj4);
							_ = ((CancellationTokenSource)/*Error near IL_02fd: Stack underflow*/).Token;
							_ = 19;
							continue;
						}
						case 25:
							awaiter = 0;
							((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003Eu__1 = (TaskAwaiter)0;
							obj2 = 6;
							continue;
						case 12:
							awaiter = 0;
							obj2 = 26;
							continue;
						case 16:
							goto IL_034c;
						case 5:
							awaiter++;
							obj2 = 18;
							continue;
						case 9:
							awaiter = 0;
							obj2 = 13;
							continue;
						case 8:
							Unsafe.As<AsyncTaskMethodBuilder, @null>(ref ((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003Et__builder) = null;
							obj2 = 17;
							continue;
						case 18:
						case 26:
							if ((nint)awaiter >= ((Array)awaiter).Length)
							{
								obj2 = 23;
								if (DesktopAuthentication._003CReceiveAsync_003Ed__20.CheckCommonTracker == null)
								{
									obj2 = 3;
								}
								continue;
							}
							goto case 1;
						case 23:
							awaiter = ((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this)._003C_003E1__state;
							obj2 = 9;
							continue;
						case 21:
							goto IL_042e;
							IL_00e5:
							obj2 = awaiter;
							continue;
						}
						break;
					}
					goto default;
					IL_034c:
					if (((Array)DesktopAuthentication._003CHeartbeatAsync_003Ed__25.ProcessResolver).Length == 0)
					{
						obj2 = 11;
						if ((int)((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24*)DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24._003C_003E1__state)->_003C_003Et__builder != 0)
						{
							obj2 = 24;
						}
						goto IL_00e9;
					}
					goto IL_042e;
					IL_042e:
					obj5 = awaiter;
					((AsyncTaskMethodBuilder<EntityAuthItem>*)((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this)._003C_003Et__builder)->Start(ref *(_003CGetAuthItemsAsync_003Ed__48*)(DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22._003C_003E4__this ?? (DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22.DecorateBasicTag = new Enumerable((IEnumerable<TSource>)(object)DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22.data, (IEnumerable<TSource>)__ldftn(DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23.SetStateMachine)))));
					((AsyncTaskMethodBuilder<EntityItemDownload>*)/*Error near IL_0462: Stack underflow*/)->Start(ref *(_003CGetItemDownloadAsync_003Ed__49*)obj5);
					awaiter = ((MassService)/*Error near IL_046e: Stack underflow*/).JoinServerAsync((byte[])/*Error near IL_046e: Stack underflow*/, (string)/*Error near IL_046e: Stack underflow*/, (string)/*Error near IL_046e: Stack underflow*/, (byte[])11, (string)DesktopAuthentication._003CSendMessageAsync_003Ed__29.ReflectIsolatedDictionary());
					obj2 = 4;
					goto IL_00e9;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00넀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779038, new IntPtr(2737336612556L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00눀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP != null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00대(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779033, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00됀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779032, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00딀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00똀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779035, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00뜀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779034, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00렀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetSkinsAsync_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<PageModel<IDesktopSkin>> _003C_003Et__builder;

		public int page;

		public DesktopSession _003C_003E4__this;

		private object _003Cskins_003E5__2;

		private TaskAwaiter<Entities<EntitySkinItem>> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		internal static object ReflectLogicalTransformer;

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
		internal static bool ReflectSimpleMap()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectControllableVisitor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00ꠀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779013, new IntPtr(2737336619836L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00꤀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0047: Expected I4, but got Obj
			//IL_00b5: Expected Obj, but got Ref
			//IL_0053: Expected Obj, but got Ref
			//IL_0090: Expected Obj, but got I4
			//IL_0090: Expected Obj, but got Ref
			//IL_0078: Expected Obj, but got Ref
			//IL_0083: Expected Obj, but got I4
			//IL_063d: Expected Obj, but got Ref
			//IL_01bc: Expected Obj, but got Ref
			//IL_03ee: Expected Obj, but got I4
			//IL_03ee: Expected Obj, but got VT
			//IL_03b8: Expected Obj, but got I4
			//IL_03c7: Expected native int or pointer, but got Obj
			//IL_04da: Expected Obj, but got Ref
			//IL_04da: Expected Obj, but got Ref
			//IL_055c: Expected Obj, but got I4
			//IL_0561: Expected Obj, but got I4
			//IL_0561: Expected Obj, but got Ref
			//IL_01d0: Expected Obj, but got Ref
			//IL_01d9: Expected Obj, but got I4
			//IL_01f2: Expected Obj, but got I4
			//IL_01f7: Expected Obj, but got I4
			//IL_01f7: Expected Obj, but got Ref
			//IL_02dd: Expected I, but got F8
			//IL_02e3: Expected Obj, but got I4
			//IL_0522: Expected I4, but got Obj
			//IL_0527: Expected I4, but got Obj
			//IL_052f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0532: Unknown result type (might be due to invalid IL or missing references)
			//IL_0538: Expected I4, but got Unknown
			//IL_054d: Expected Obj, but got VT
			//IL_046d: Expected Obj, but got Ref
			//IL_057c: Expected Obj, but got VT
			//IL_057c: Expected Obj, but got VT
			//IL_057f: Expected native int or pointer, but got Obj
			//IL_0589: Expected Obj, but got I4
			//IL_0589: Expected Obj, but got VT
			//IL_058b: Expected Obj, but got VT
			//IL_0388: Expected Obj, but got I4
			//IL_049a: Expected Obj, but got Ref
			//IL_049a: Expected Obj, but got Ref
			//IL_0267: Expected Obj, but got Ref
			//IL_0412: Expected native int or pointer, but got Obj
			//IL_0428: Expected Obj, but got Ref
			//IL_0428: Expected VT, but got Obj
			//IL_0428: Expected Ref, but got VT
			//IL_0191: Expected Obj, but got Ref
			//IL_0191: Unknown result type (might be due to invalid IL or missing references)
			//IL_017c: Expected Obj, but got I4
			//IL_0181: Expected Obj, but got Ref
			//IL_0218: Expected native int or pointer, but got Obj
			//IL_0461: Expected Obj, but got I4
			//IL_0172: Expected I4, but got Obj
			//IL_0067->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00a4->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0649->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0072->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00af->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ed->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_01c8->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_031e->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_0329->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_03fa->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_03d1->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_04ee->IL00f1: Incompatible stack heights: 2 vs 1
			//IL_056b->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_020b->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_02f7->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_0557->IL00f1: Incompatible stack heights: 3 vs 1
			//IL_0260->IL00f1: Incompatible stack heights: 2 vs 1
			//IL_0410->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_0481->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_0595->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_03a1->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_04ae->IL00f1: Incompatible stack heights: 3 vs 1
			//IL_02b9->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_01ab->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_029d->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_0378->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_018b->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_0242->IL00f1: Incompatible stack heights: 4 vs 1
			//IL_03dc->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_04f9->IL00f1: Incompatible stack heights: 2 vs 1
			//IL_0216->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_0302->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_048c->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_03ac->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_04b9->IL00f1: Incompatible stack heights: 3 vs 1
			//IL_0280->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_02c4->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_0441->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_01b6->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_0383->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_024d->IL00f1: Incompatible stack heights: 4 vs 1
			//IL_028b->IL00f1: Incompatible stack types: I4 vs Obj
			//IL_044c->IL00f1: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					object obj3;
					switch ((int)obj2)
					{
					case 1:
						((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP = null;
						obj2 = 0;
						if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP == null)
						{
							obj2 = 0;
						}
						continue;
					case 4:
						break;
					case 2:
						DesktopAuthentication.Crc32 = -2;
						obj2 = 1;
						if (DesktopAuthentication.TokenKey != null)
						{
							obj2 = 0;
						}
						continue;
					default:
						_ = ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._client;
						/*Error near IL_00b7: Member reference must be method, but was: Field*/;
					case 3:
						if (obj == null)
						{
							obj3 = 3;
							goto IL_00f1;
						}
						goto IL_0302;
					case 5:
						obj = ((_003C_003Ec__DisplayClass16_0)Unsafe.AsPointer(ref this)).gameId;
						obj2 = 4;
						continue;
					case 6:
						return;
						IL_0302:
						if ((nint)obj != 1)
						{
							obj3 = 0;
							if ((int)((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24*)DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								obj3 = 4;
							}
							goto IL_00f1;
						}
						goto IL_01b6;
						IL_01b6:
						obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeTcs;
						obj3 = 24;
						goto IL_00f1;
						IL_00f1:
						while (true)
						{
							switch ((int)obj3)
							{
							case 22:
								break;
							case 29:
								obj = -1;
								((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeSent = -1;
								obj3 = 12;
								continue;
							case 24:
								((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeKey = (object)default(ILogger);
								obj3 = 2;
								if (((DesktopAuthentication)DesktopAuthentication._encryptChaCha)._decryptChaCha == null)
								{
									obj3 = 16;
								}
								continue;
							case 20:
								goto IL_01b6;
							case 7:
								((DesktopAuthentication)Unsafe.AsPointer(ref this))._authenticationTcs = obj;
								obj = 17;
								goto IL_00ed;
							case 1:
								return;
							case 9:
								obj = 0;
								DesktopAuthentication.PrepareDic = (DesktopAuthentication)0;
								obj3 = 9;
								if ((int)((DesktopAuthentication._003CAuthentication_003Ed__27*)DesktopAuthentication._003CAuthentication_003Ed__27._003C_003E1__state)->_003C_003Et__builder == 0)
								{
									obj3 = 25;
								}
								continue;
							case 23:
							case 30:
								_ = ((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)obj)->_003C_003E4__this;
								_ = ((DesktopAuthentication._003CAuthentication_003Ed__27)this).modHashList;
								((TaskAwaiter<byte[]>*)((DesktopAuthentication._003CAuthentication_003Ed__27)this).serverIdHash)->GetResult();
								_ = 3;
								if ((int)((DesktopAuthentication._003CAuthentication_003Ed__27)DesktopAuthentication._003CAuthentication_003Ed__27._003C_003Eu__1)._003C_003Eu__2 != 0)
								{
									_ = 15;
								}
								continue;
							default:
								_ = ref obj;
								obj = MassService.Instance;
								_ = 10;
								continue;
							case 18:
								if (((MassService)/*Error near IL_0267: Stack underflow*/).JoinServerAsync((byte[])/*Error near IL_0267: Stack underflow*/, (string)/*Error near IL_0267: Stack underflow*/, (string)/*Error near IL_0267: Stack underflow*/, (string)/*Error near IL_0267: Stack underflow*/, (string)/*Error near IL_0267: Stack underflow*/, (string)(&obj)) != null)
								{
									obj3 = 0;
									if (((DesktopAuthentication._003CConnect_003Ed__19)DesktopAuthentication._003CConnect_003Ed__19._003C_003Et__builder)._003C_003E4__this == null)
									{
										obj3 = 0;
									}
									continue;
								}
								goto case 9;
							case 25:
								((DesktopAuthentication._003CConnect_003Ed__19)this).authServer = (EntityAuthServer)obj;
								obj3 = 5;
								continue;
							case 3:
							case 19:
								obj = ((DesktopAuthentication._003CConnect_003Ed__19)this)._003Ccts_003E5__2;
								obj3 = 13;
								if (DesktopAuthentication._003CConnect_003Ed__19.CheckAdjustableCommand != null)
								{
									obj3 = 8;
								}
								continue;
							case 10:
								((Action)/*Error near IL_02dd: Stack underflow*/)._002Ector(obj, (nint)((double)((CancellationTokenSource)obj).Token / 20.0));
								Unsafe.Write(&((DesktopAuthentication._003CHeartbeatAsync_003Ed__25*)(nint)/*Error near IL_02e3: Stack underflow*/)->_003C_003E4__this, (DesktopAuthentication)(int)/*Error near IL_02de: Stack underflow*/);
								obj3 = 26;
								if (DesktopAuthentication._003CHeartbeatAsync_003Ed__25.ProcessResolver == null)
								{
									obj3 = 10;
								}
								continue;
							case 28:
								goto IL_0302;
							case 26:
								((AsyncTaskMethodBuilder)this).Start(ref *(_003CLogoutAsync_003Ed__32*)IPAddress.Parse((string)obj));
								((AsyncTaskMethodBuilder*)/*Error near IL_035f: Stack underflow*/)->Start(ref *(_003CInterStartAsync_003Ed__33*)/*Error near IL_035f: Stack underflow*/);
								Unsafe.Write(&((DesktopAuthentication._003CReceiveAsync_003Ed__20*)(nint)/*Error near IL_0364: Stack underflow*/)->_003C_003E4__this, /*Error near IL_0364: Stack underflow*/);
								obj3 = 2;
								if (DesktopAuthentication._003CReceiveAsync_003Ed__20.CheckCommonTracker == null)
								{
									obj3 = 0;
								}
								continue;
							case 16:
								obj = -1;
								((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this)._003C_003E1__state = -1;
								obj3 = 2;
								if (((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22._003C_003Et__builder)._003C_003E4__this != null)
								{
									obj3 = 14;
								}
								continue;
							case 4:
								((DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23*)((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this).data)->SetStateMachine((IAsyncStateMachine)1);
								((AsyncTaskMethodBuilder<EntityNetGameAddress>*)/*Error near IL_03bd: Stack underflow*/)->Start(ref *(_003CGetNetGameAddressAsync_003Ed__46*)/*Error near IL_03bd: Stack underflow*/);
								obj3 = 7;
								if (((DesktopAuthentication._003CReceiveDataAsync_003Ed__21*)(nint)DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22.DecorateBasicTag)->_003C_003E1__state != 0)
								{
									obj3 = 21;
								}
								continue;
							case 2:
								obj = ((MassService)/*Error near IL_03ee: Stack underflow*/).JoinServerAsync((byte[])/*Error near IL_03ee: Stack underflow*/, (string)/*Error near IL_03ee: Stack underflow*/, (string)obj, (byte[])((DesktopAuthentication._003CReceiveDataAsync_003Ed__21)this)._003C_003Et__builder, (string)DesktopAuthentication._003CSendMessageAsync_003Ed__29.ReflectIsolatedDictionary());
								obj3 = 27;
								continue;
							case 13:
								Unsafe.As<TaskAwaiter<int>, TaskAwaiter<Entity<_00210>>>(ref ((DesktopAuthentication._003CReceiveDataAsync_003Ed__21)this)._003C_003Eu__1) = default;
								obj3 = 29;
								continue;
							case 21:
								((DefaultInterpolatedStringHandler*)((DesktopAuthentication._003CReceiveDataAsync_003Ed__21*)(nint)obj)->_003C_003Eu__2)->AppendFormatted<T>((T)DesktopAuthentication._003CReceiveDataAsync_003Ed__21.CheckActiveRecommender, (string?)Unsafe.AsPointer(ref ((DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23)this)._003C_003E1__state));
								if ((int)/*Error near IL_042d: Stack underflow*/ != 0)
								{
									obj3 = 7;
									if (((DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23*)(int)DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23.sid)->payload == null)
									{
										obj3 = 23;
									}
									continue;
								}
								goto case 11;
							case 27:
								if (((DefaultInterpolatedStringHandler*)(&obj))->ToStringAndClear() == null)
								{
									obj = 6;
									goto IL_00ed;
								}
								goto case 14;
							case 14:
								((TaskCompletionSource)/*Error near IL_046d: Stack underflow*/).SetException((Exception)(&obj));
								obj3 = 12;
								if ((int)((DesktopAuthentication._003CSendMessageAsync_003Ed__29*)DesktopAuthentication._003CSendMessageAsync_003Ed__29._003C_003E1__state)->_003C_003Et__builder == 0)
								{
									obj3 = 30;
								}
								continue;
							case 17:
								_ = ref ((DesktopAuthentication._003CSendMessageAsync_003Ed__29)this)._003C_003E4__this;
								((IEnumerable<EntityNetGameItem>)(&obj)).Select((Func<EntityNetGameItem, string>)Unsafe.AsPointer(ref this));
								_ = 4;
								if (DesktopAuthentication._003CSendMessageAsync_003Ed__29.CheckAccessibleCalculator == null)
								{
									_ = 8;
								}
								continue;
							case 5:
								((DesktopSession)/*Error near IL_04da: Stack underflow*/).EntityRequestAsync<EntityGameCharacter>((string)Unsafe.AsPointer(ref ((DesktopAuthentication._003CSendPacketAsync_003Ed__28)this)._003C_003E1__state), (object)(&obj), (byte)Unsafe.AsPointer(ref this) != 0);
								_ = 1;
								if (((DesktopAuthentication._003CSendPacketAsync_003Ed__28*)(int)DesktopAuthentication._003CSendPacketAsync_003Ed__28.id)->data == null)
								{
									_ = 0;
								}
								continue;
							case 8:
								return;
							case 11:
							{
								new Stream((byte[])/*Error near IL_0527: Stack underflow*/, (int)/*Error near IL_0527: Stack underflow*/, (int)((DesktopSession)/*Error near IL_0522: Stack underflow*/).GetOwnedSkinsAsync((int)obj));
								byte[] bytes = BitConverter.GetBytes((ushort)((DesktopAuthentication._003CSendPacketAsync_003Ed__28.CheckIterableSynchronizer - 1) * 20));
								((AsyncTaskMethodBuilder<_00210>*)bytes)->AwaitUnsafeOnCompleted(ref *(((ValueTaskAwaiter*)20)->IsCompleted ? ((TaskAwaiter<Entity<_00210>>*)1) : ((TaskAwaiter<Entity<_00210>>*)null)), ref *(_003CEntityRequestAsync_003Ed__10<_00210>*)1);
								obj = (ReadOnlyMemory<byte>)bytes;
								_ = 18;
								continue;
							}
							case 6:
								obj = 1;
								DecorateVisibleDecider = (DesktopSession)1;
								obj3 = 7;
								continue;
							case 15:
								{
									ValueTaskAwaiter valueTaskAwaiter = (ValueTaskAwaiter)new ValueTaskAwaiter();
									((BinaryWriter)valueTaskAwaiter)._002Ector((Stream)((_003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed)this)._003C_003Et__builder);
									((BinaryWriter)valueTaskAwaiter).Write((byte[])((_003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed*)(nint)obj)->offset);
									obj = valueTaskAwaiter;
									obj3 = 22;
									continue;
								}
								IL_00ed:
								obj3 = obj;
								continue;
							}
							break;
						}
						goto case 2;
					}
					break;
				}
				obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CserverId_003EP;
				obj = 3;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00ꨀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779012, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_AB00(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00가()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00관()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00글()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779015, new IntPtr(2737336635436L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetSkinsByIdAsync_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntitySkinItem[]> _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		public string[] skinIds;

		private TaskAwaiter<EntitySkinItem[]> _003C_003Eu__1;

		internal static object TrackUser;

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
		internal static bool CheckResponsiveElement()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckSortedDriver()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00鼀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779014, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00ꀀ()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_02e7: Expected VT, but got I4
			//IL_00b5: Expected VT, but got Obj
			//IL_00c5: Expected VT, but got I4
			//IL_00cc: Expected Obj, but got Ref
			//IL_0203: Expected Obj, but got Ref
			//IL_00a2: Expected Obj, but got Ref
			//IL_0135: Expected Obj, but got I4
			//IL_013a: Expected Obj, but got I4
			//IL_013a: Expected Obj, but got Ref
			//IL_0180: Expected native int or pointer, but got Obj
			//IL_01ab: Expected native int or pointer, but got Obj
			//IL_015e: Expected Obj, but got I4
			//IL_0163: Expected Obj, but got I4
			//IL_0163: Expected Obj, but got Ref
			//IL_02f1->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0325->IL0026: Incompatible stack types: I4 vs Obj
			//IL_034c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0308->IL0026: Incompatible stack heights: 3 vs 1
			//IL_0330->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0357->IL0026: Incompatible stack types: I4 vs Obj
			//IL_018a->IL005e: Incompatible stack heights: 2 vs 1
			//IL_0195->IL005e: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 2;
			object obj = awaiter;
			while (true)
			{
				switch ((int)obj)
				{
				case 5:
				{
					if (awaiter == null)
					{
						int num = 6;
						while (true)
						{
							switch (num)
							{
							default:
								return;
							case 2:
							case 6:
								awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
								num = 10;
								continue;
							case 11:
								break;
							case 7:
								awaiter = -1;
								((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptedToken = -1;
								num = 9;
								if (((DesktopAuthentication)DesktopAuthentication._encryptChaCha)._decryptChaCha == null)
								{
									num = 7;
								}
								continue;
							case 12:
								awaiter = 0;
								((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeTcs = 0;
								num = 3;
								continue;
							case 5:
							case 9:
								_ = ref awaiter;
								awaiter = Log.Logger;
								_ = 5;
								if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication.PrepareDic)->_003C_003E1__state != 0)
								{
									_ = 8;
								}
								continue;
							case 10:
								Unsafe.As<AsyncTaskMethodBuilder, AsyncTaskMethodBuilder<EntityGameModsHash>>(ref ((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Et__builder) = default;
								num = 2;
								if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27.modHashList)->serverIdHash == null)
								{
									num = 7;
								}
								continue;
							case 0:
								return;
							case 4:
								Unsafe.As<object, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003Ccts_003E5__2).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CGetSkinsByIdAsync_003Ed__22, DesktopAuthentication._003CSendPacketAsync_003Ed__28>(ref this));
								num = 0;
								if (DesktopAuthentication._003CAuthentication_003Ed__27.ReflectInternalAnnotation == null)
								{
									num = 0;
								}
								continue;
							case 1:
								if (((MassService)/*Error near IL_0203: Stack underflow*/).JoinServerAsync((byte[])/*Error near IL_0203: Stack underflow*/, (string)/*Error near IL_0203: Stack underflow*/, (string)/*Error near IL_0203: Stack underflow*/, (string)/*Error near IL_0203: Stack underflow*/, (string)/*Error near IL_0203: Stack underflow*/, (string)(&awaiter)) != null)
								{
									num = 2;
									if (((DesktopAuthentication._003CConnect_003Ed__19)DesktopAuthentication._003CConnect_003Ed__19._003C_003Et__builder)._003C_003E4__this != null)
									{
										num = 5;
									}
									continue;
								}
								goto case 12;
							case 3:
								((DesktopAuthentication._003CConnect_003Ed__19)this).authServer = (EntityAuthServer)awaiter;
								num = 4;
								continue;
							case 8:
								goto IL_02df;
							}
							break;
						}
					}
					((_003C_003Ef__AnonymousType0<, >)/*Error near IL_00b5: Stack underflow*/)._002Ector((_003Corderid_003Ej__TPar)/*Error near IL_00b5: Stack underflow*/, (_003Cbuy_type_003Ej__TPar)awaiter);
					EqualityComparer<_00210> equalityComparer = new EqualityComparer<_00210>();
					((AsyncTaskMethodBuilder*)equalityComparer.GetHashCode((_00210)((_003C_003Ef__AnonymousType0<, >)(object)equalityComparer).GetHashCode()))->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)DesktopAuthentication.Logger.ToString(), ref *(DesktopAuthentication._003CAuthentication_003Ed__27*)1);
					/*Error near IL_00d7: Member reference must be method, but was: Field*/;
				}
				default:
					goto IL_02df;
				case 3:
					_ = ref ((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003E4__this;
					_ = ((EntityAuthServer)awaiter).Ip;
					_ = 4;
					break;
				case 4:
					return;
				case 1:
					awaiter = DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24.ReflectMixedRunner;
					obj = 3;
					if ((int)((DesktopAuthentication._003CReceiveAsync_003Ed__20*)DesktopAuthentication._003CReceiveAsync_003Ed__20._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj = 5;
					}
					break;
				case 2:
					{
						awaiter = ((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003E4__this;
						obj = 1;
						if (DesktopAuthentication._003CReceiveAsync_003Ed__20.CheckCommonTracker == null)
						{
							obj = 0;
						}
						break;
					}
					IL_02df:
					((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-2);
					obj = 3;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00ꄀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779009, new IntPtr(2737336616716L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00ꈀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779008, new IntPtr(2737336612556L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00ꌀ(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0044: Expected VT, but got Obj
			//IL_0044: Expected VT, but got Ref
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0044: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP != null)
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
		internal unsafe static byte _FF00_FF00_FF00ꐀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779011, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00ꔀ()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00ꘀ()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetUserDetailAsync_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityUserDetail> _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		private TaskAwaiter<EntityUserDetail> _003C_003Eu__1;

		internal static object CombineTransformer;

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
		internal static bool StartMap()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectSequentialObject()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00鐀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779010, new IntPtr(2737336618796L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00销()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0340: Expected VT, but got I4
			//IL_01df: Expected Obj, but got I4
			//IL_00bc: Expected I4, but got Obj
			//IL_017d: Expected Obj, but got I4
			//IL_025f: Expected F8, but got Ref
			//IL_00ea: Expected Obj, but got Ref
			//IL_0124: Expected Obj, but got I
			//IL_01aa: Expected Obj, but got I4
			//IL_0102: Expected Obj, but got Ref
			//IL_028a: Expected VT, but got Ref
			//IL_0296: Expected native int or pointer, but got Obj
			//IL_0234: Expected Obj, but got I4
			//IL_0239: Expected Obj, but got I4
			//IL_026d: Expected Obj, but got I4
			//IL_03a5->IL0026: Incompatible stack types: I4 vs Obj
			//IL_035d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_034a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_037e->IL0026: Incompatible stack heights: 3 vs 1
			//IL_0064->IL0073: Incompatible stack types: I4 vs Obj
			//IL_03b0->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0389->IL0026: Incompatible stack heights: 3 vs 1
			//IL_006f->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0182->IL006f: Incompatible stack heights: 1 vs 0
			//IL_019a->IL0073: Incompatible stack types: I4 vs Obj
			//IL_015d->IL0073: Incompatible stack types: I4 vs Obj
			//IL_01fc->IL0073: Incompatible stack types: I4 vs Obj
			//IL_00fa->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0129->IL0073: Incompatible stack types: I4 vs Obj
			//IL_00d9->IL0073: Incompatible stack types: I4 vs Obj
			//IL_01c3->IL0073: Incompatible stack types: I4 vs Obj
			//IL_010c->IL0073: Incompatible stack types: I4 vs Obj
			//IL_02a0->IL0073: Incompatible stack types: I4 vs Obj
			//IL_024d->IL0073: Incompatible stack types: I4 vs Obj
			//IL_01a5->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0168->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0134->IL0073: Incompatible stack types: I4 vs Obj
			//IL_00e4->IL0073: Incompatible stack types: I4 vs Obj
			//IL_01ce->IL0073: Incompatible stack types: I4 vs Obj
			//IL_02ab->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0283->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0258->IL0073: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 3;
			object obj = awaiter;
			while (true)
			{
				object obj2;
				object serverIdHash;
				object modHashList;
				switch ((int)obj)
				{
				default:
					if (awaiter != null)
					{
						obj2 = 9;
						if (((DesktopAuthentication)DesktopAuthentication._003CuserId_003EP)._003CuserToken_003EP != null)
						{
							obj2 = 6;
						}
						goto IL_0073;
					}
					goto IL_01ce;
				case 4:
					goto IL_0338;
				case 1:
					return;
				case 3:
					awaiter = ((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003E4__this;
					obj = 2;
					break;
				case 5:
					_ = ref ((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003Eu__1;
					IPAddress.Parse((string)awaiter);
					_ = 1;
					if ((int)((DesktopAuthentication._003CReceiveAsync_003Ed__20*)DesktopAuthentication._003CReceiveAsync_003Ed__20._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						_ = 1;
					}
					break;
				case 2:
					{
						awaiter = ((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003E4__this;
						obj = 0;
						if (DesktopAuthentication._003CReceiveAsync_003Ed__20.CheckCommonTracker != null)
						{
							obj = 0;
						}
						break;
					}
					IL_006f:
					obj2 = awaiter;
					goto IL_0073;
					IL_0073:
					while (true)
					{
						switch ((int)obj2)
						{
						case 10:
							awaiter = awaiter;
							obj2 = 2;
							if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP != null)
							{
								obj2 = 2;
							}
							continue;
						case 8:
							Unsafe.As<object, TaskAwaiter<int>>(ref DesktopAuthentication.Crc32) = default;
							obj2 = 16;
							continue;
						case 12:
							DesktopAuthentication.TokenKey = (byte[])awaiter;
							obj2 = 6;
							continue;
						case 9:
							((DesktopAuthentication)/*Error near IL_0113: Stack underflow*/)._002Ector((string)/*Error near IL_0113: Stack underflow*/, (string)/*Error near IL_0113: Stack underflow*/, (string)/*Error near IL_0113: Stack underflow*/, (string)awaiter);
							awaiter = (object)/*Error near IL_0115: Stack underflow*/;
							obj2 = 14;
							if (((DesktopAuthentication)DesktopAuthentication._connected)._buffer == null)
							{
								obj2 = 2;
							}
							continue;
						case 3:
						{
							object obj3 = ((DesktopAuthentication)/*Error near IL_013b: Stack underflow*/).ReceiveDataAsync(awaiter);
							((AsyncTaskMethodBuilder*)/*Error near IL_0142: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)obj3, ref *(DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24*)1);
							((AsyncTaskMethodBuilder*)/*Error near IL_0147: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)/*Error near IL_0147: Stack underflow*/);
							awaiter = (object)/*Error near IL_0149: Stack underflow*/;
							obj2 = 1;
							if (((DesktopAuthentication)DesktopAuthentication._encryptChaCha)._decryptChaCha == null)
							{
								obj2 = 0;
							}
							continue;
						}
						case 2:
							awaiter = awaiter;
							obj2 = 7;
							if (DesktopAuthentication.PrepareDic == null)
							{
								obj2 = 7;
							}
							continue;
						case 11:
							awaiter = 0;
							((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E1__state = 0;
							obj2 = 6;
							if (((DesktopAuthentication._003CAuthentication_003Ed__27)DesktopAuthentication._003CAuthentication_003Ed__27._003C_003Et__builder)._003C_003E4__this == null)
							{
								obj2 = 12;
							}
							continue;
						case 4:
							goto IL_01ce;
						case 6:
							Unsafe.As<string, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication._003CAuthentication_003Ed__27)this).serverIdHash).AwaitUnsafeOnCompleted(ref *(ValueTaskAwaiter*)(&awaiter), ref Unsafe.As<_003CGetUserDetailAsync_003Ed__39, DesktopAuthentication._003CSendMessageAsync_003Ed__29>(ref this));
							obj2 = 15;
							continue;
						case 15:
							return;
						case 16:
							awaiter = -1;
							DesktopAuthentication._003CAuthentication_003Ed__27.ReflectInternalAnnotation = -1;
							obj2 = 13;
							if ((int)((DesktopAuthentication._003CConnect_003Ed__19*)DesktopAuthentication._003CConnect_003Ed__19._003C_003E1__state)->_003C_003Et__builder != 0)
							{
								obj2 = 12;
							}
							continue;
						case 1:
							if ((int)TimeSpan.FromSeconds((double)(nint)(&awaiter)) == 0)
							{
								goto case 11;
							}
							goto IL_0264;
						case 14:
							if (awaiter == null)
							{
								obj2 = 3;
								continue;
							}
							goto case 2;
						case 5:
						case 13:
							((CancellationTokenSource)/*Error near IL_028a: Stack underflow*/)._002Ector((TimeSpan)(&awaiter));
							awaiter = (object)/*Error near IL_028c: Stack underflow*/;
							obj2 = 0;
							if ((int)((DesktopAuthentication._003CConnect_003Ed__19*)(nint)DesktopAuthentication._003CConnect_003Ed__19._003Ccts_003E5__2)->_003C_003Eu__1 != 0)
							{
								obj2 = 0;
							}
							continue;
						case 7:
							goto IL_0338;
						}
						break;
					}
					serverIdHash = awaiter;
					modHashList = (awaiter = awaiter);
					((DesktopAuthentication)/*Error near IL_0174: Stack underflow*/).Authentication((string)serverIdHash, (string)modHashList);
					awaiter = 10;
					goto IL_006f;
					IL_0338:
					((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-2);
					obj = 5;
					break;
					IL_0264:
					awaiter = 5;
					goto IL_006f;
					IL_01ce:
					awaiter = ((DesktopAuthentication._003CAuthentication_003Ed__27)this).modHashList;
					awaiter = 8;
					goto IL_006f;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00阀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779021, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00需(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00頀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779020, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00餀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779023, new IntPtr(2737336614636L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00騀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00鬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779022, new IntPtr(2737336612556L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00鰀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetUserSkinAsync_003Ed__55 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityUserSkin[]> _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		public string userId;

		private TaskAwaiter<EntityUserSkin[]> _003C_003Eu__1;

		internal static object DecorateSetDecorator;

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
		internal static bool CheckEfficientArgument()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CloseDriver()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00謀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779017, new IntPtr(2737336619836L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00谀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0062: Expected Obj, but got I4
			//IL_0062: Expected Obj, but got Ref
			//IL_02ce: Expected native int or pointer, but got Obj
			//IL_02eb: Expected Obj, but got VT
			//IL_02f5: Expected native int or pointer, but got Obj
			//IL_004e: Expected Obj, but got Ref
			//IL_010a: Expected Obj, but got Ref
			//IL_01c5: Expected Obj, but got I4
			//IL_01ca: Expected VT, but got I4
			//IL_01ab: Expected native int or pointer, but got Obj
			//IL_0145: Expected Obj, but got Ref
			//IL_011b: Expected Obj, but got I4
			//IL_0120: Expected Obj, but got I4
			//IL_0120: Expected Obj, but got Ref
			//IL_012f: Expected Obj, but got I
			//IL_0186: Expected Obj, but got Ref
			//IL_006c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02d8->IL0026: Incompatible stack heights: 2 vs 1
			//IL_02ff->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02e3->IL0026: Incompatible stack heights: 2 vs 1
			//IL_030a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01b5->IL0082: Incompatible stack heights: 2 vs 1
			//IL_0161->IL01c0: Incompatible stack heights: 1 vs 0
			//IL_0215->IL0082: Incompatible stack heights: 3 vs 1
			//IL_01c0->IL0082: Incompatible stack heights: 2 vs 1
			//IL_0175->IL0082: Incompatible stack heights: 2 vs 1
			//IL_0180->IL0082: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 5;
			object obj = awaiter;
			while (true)
			{
				int num;
				switch ((int)obj)
				{
				case 5:
					awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
					obj = 4;
					break;
				case 1:
					((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserToken_003EP = -2;
					obj = 2;
					break;
				default:
					if (awaiter != null)
					{
						num = 9;
						goto IL_0082;
					}
					goto IL_0104;
				case 2:
					_ = ref ((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003E4__this;
					((IDisposable)awaiter).Dispose();
					_ = 3;
					if (((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24*)(nint)DesktopAuthentication._003CHeartbeatAsync_003Ed__25.ProcessResolver)->_003C_003E1__state == 0)
					{
						_ = 3;
					}
					break;
				case 4:
					awaiter = ((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003Et__builder;
					obj = 0;
					if ((int)((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24*)(nint)DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24._003C_003E4__this)->_003C_003Eu__1 != 0)
					{
						obj = 0;
					}
					break;
				case 3:
					return;
					IL_0082:
					while (true)
					{
						switch (num)
						{
						case 10:
							break;
						case 2:
							return;
						case 1:
							goto IL_0104;
						case 8:
							awaiter = -1;
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._client = -1;
							num = 1;
							if (((DesktopAuthentication)DesktopAuthentication._connected)._buffer != null)
							{
								num = 5;
							}
							continue;
						case 7:
							Unsafe.As<nint, AsyncTaskMethodBuilder<_0021_00210[]>>(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshake) = default;
							num = 8;
							continue;
						case 6:
							_ = ref awaiter;
							if ((int)AsyncTaskMethodBuilder.Create() != 0)
							{
								_ = 4;
								if (((DesktopAuthentication)DesktopAuthentication._encryptedToken)._encryptChaCha == null)
								{
									_ = 2;
								}
								continue;
							}
							goto default;
						case 11:
							Unsafe.As<object, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._decryptChaCha).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CGetUserSkinAsync_003Ed__55, DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22>(ref this));
							num = 2;
							continue;
						case 4:
						case 5:
							_ = ref awaiter;
							awaiter = Log.Logger;
							_ = 10;
							if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication.PrepareDic)->_003C_003E1__state == 0)
							{
								_ = 7;
							}
							continue;
						default:
							awaiter = 0;
							((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)0;
							num = 3;
							continue;
						case 3:
							((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E4__this = (DesktopAuthentication)awaiter;
							num = 11;
							continue;
						case 9:
							((DesktopAuthentication)awaiter)._003CAuthentication_003Eb__27_0();
							new TaskAwaiter();
							(((TaskAwaiter<byte[]>*)((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003Ccts_003E5__2)->IsCompleted ? ((AsyncTaskMethodBuilder*)1) : ((AsyncTaskMethodBuilder*)null))->Start(ref *(_003CHeartbeatAsync_003Ed__7*)1);
							awaiter = MassService.Instance;
							_ = 6;
							continue;
						}
						break;
					}
					goto case 1;
					IL_0104:
					awaiter = DesktopAuthentication.TokenKey;
					num = 7;
					goto IL_0082;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00贀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779016, new IntPtr(2737336625036L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00踀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00輀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00退()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779019, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00鄀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00鈀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779018, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetUserSkinAsync_003Ed__56 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityUserSkin> _003C_003Et__builder;

		public EnumGameType gameType;

		public DesktopSession _003C_003E4__this;

		public string userId;

		private object _003C_003E8__1;

		private TaskAwaiter<EntityUserSkin[]> _003C_003Eu__1;

		internal static object DecorateGlobalProgram;

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
		internal static bool CheckDetachedTemplate()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectDetailedAuditor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00脀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779125, new IntPtr(2737336613596L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00舀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0047: Expected I4, but got Obj
			//IL_0054: Expected Obj, but got I4
			//IL_0054: Expected Obj, but got Ref
			//IL_00a3: Expected Obj, but got Ref
			//IL_0064: Expected Obj, but got Ref
			//IL_00b3: Expected Obj, but got Ref
			//IL_008b: Expected Obj, but got Ref
			//IL_0092: Expected VT, but got Obj
			//IL_0092: Expected Obj, but got Ref
			//IL_027a: Expected Obj, but got VT
			//IL_00d7: Expected Obj, but got I
			//IL_017f: Expected Obj, but got Ref
			//IL_0134: Expected Obj, but got Ref
			//IL_0249: Expected VT, but got Ref
			//IL_026a: Expected Obj, but got I4
			//IL_016f: Expected Obj, but got Ref
			//IL_01ac: Expected Obj, but got Ref
			//IL_01b8: Expected Obj, but got I4
			//IL_01c2: Expected native int or pointer, but got Obj
			//IL_01e8: Expected VT, but got Obj
			//IL_01e3: Expected native int or pointer, but got Obj
			//IL_0289: Expected Obj, but got I4
			//IL_028e: Expected VT, but got I4
			//IL_0297: Expected Obj, but got I4
			//IL_0233: Expected Obj, but got I4
			//IL_0238: Expected Obj, but got I4
			//IL_0128: Expected I4, but got Obj
			//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ad->IL0026: Incompatible stack types: I4 vs Obj
			//IL_007a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00bf->IL0026: Incompatible stack types: I4 vs Obj
			//IL_009c->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0284->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_00dc->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0085->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00e7->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0199->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0179->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_01cc->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_02b8->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_01f2->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_022e->IL00eb: Incompatible stack heights: 2 vs 1
			//IL_0242->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_01a4->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_0143->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_01d7->IL00eb: Incompatible stack types: I4 vs Obj
			//IL_02c3->IL00eb: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				case 1:
					((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP = -2;
					obj2 = 3;
					break;
				case 4:
					obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserToken_003EP;
					obj2 = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
					{
						obj2 = 0;
					}
					break;
				case 6:
					((EqualityComparer<_00211>)Unsafe.AsPointer(ref DesktopAuthentication.Crc32)).GetHashCode((_00211)obj);
					_ = 2;
					break;
				case 3:
					DesktopAuthentication.TokenKey = null;
					obj2 = 6;
					break;
				case 5:
					obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._client;
					obj2 = 4;
					break;
				case 2:
					return;
				default:
					{
						if (obj == null)
						{
							obj3 = 6;
							if (((DesktopAuthentication)DesktopAuthentication._connected)._buffer != null)
							{
								obj3 = 11;
							}
							goto IL_00eb;
						}
						goto IL_026f;
					}
					IL_026f:
					((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003E4__this = (DesktopAuthentication)new DesktopAuthentication._003CHeartbeatAsync_003Ed__25();
					obj3 = 8;
					goto IL_00eb;
					IL_00eb:
					while (true)
					{
						switch ((int)obj3)
						{
						case 7:
							break;
						case 13:
							return;
						case 1:
							((List<byte>)(&obj))._002Ector();
							if ((int)/*Error near IL_0139: Stack underflow*/ == 0)
							{
								obj3 = 9;
								continue;
							}
							goto case 2;
						case 3:
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptedToken = obj;
							obj3 = 10;
							continue;
						default:
							Unsafe.As<object, AsyncTaskMethodBuilder<EntityNetGameItem[]>>(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptChaCha) = default;
							obj3 = 12;
							if (((DesktopAuthentication)DesktopAuthentication._handshakeTcs)._authenticationTcs == null)
							{
								obj3 = 4;
							}
							continue;
						case 4:
						{
							object exception = obj;
							DesktopAuthentication.PrepareDic.Dispose();
							obj = ((TaskCompletionSource)/*Error near IL_01b6: Stack underflow*/).TrySetException((Exception)exception);
							obj3 = 1;
							if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27._003C_003E4__this)->modHashList == null)
							{
								obj3 = 1;
							}
							continue;
						}
						case 8:
							Unsafe.Write(&((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)((DesktopAuthentication._003CAuthentication_003Ed__27)this).serverIdHash)->_003C_003Eu__1, (TaskAwaiter<byte[]>)((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003Ccts_003E5__2);
							obj3 = 4;
							continue;
						case 10:
							_ = ref ((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003E1__state;
							((AsyncTaskMethodBuilder<_0021_00210[]>*)(&obj))->Start(ref Unsafe.As<_003CGetUserSkinAsync_003Ed__56, _003CEntitiesRequestAsync_003Ed__11<_0021_00210>>(ref this));
							_ = 13;
							continue;
						case 12:
							obj = -1;
							((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003E4__this = (DesktopAuthentication)(-1);
							obj3 = 2;
							continue;
						case 2:
						{
							((CancellationTokenSource)/*Error near IL_0249: Stack underflow*/)._002Ector((TimeSpan)(&obj));
							object obj4 = ((DesktopAuthentication._003CConnect_003Ed__19)this)._003Ccts_003E5__2;
							((AsyncTaskMethodBuilder<EntitySkinItem>*)__ldftn(DesktopAuthentication._003CHeartbeatAsync_003Ed__25.MoveNext))->Start(ref *(_003CGetSkinByIdAsync_003Ed__21*)new TaskCompletionSource());
							obj = obj4;
							obj = 7;
							goto IL_00e7;
						}
						case 6:
							goto IL_026f;
						case 9:
							obj = 0;
							((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003Eu__1 = (TaskAwaiter)0;
							obj = 3;
							goto IL_00e7;
						case 5:
						case 11:
							{
								obj = DesktopAuthentication._003CHeartbeatAsync_003Ed__25.ProcessResolver;
								obj3 = 0;
								if ((int)((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24*)DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24._003C_003E1__state)->_003C_003Et__builder == 0)
								{
									obj3 = 0;
								}
								continue;
							}
							IL_00e7:
							obj3 = obj;
							continue;
						}
						break;
					}
					goto case 1;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00茀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779124, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00萀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00蔀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779127, new IntPtr(2737336631276L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00蘀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779126, new IntPtr(2737336635436L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00蜀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00蠀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779121, new IntPtr(2737336629196L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00褀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CHeartbeatAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		private TaskAwaiter<EntityAuthenticationOtp> _003C_003Eu__1;

		private static object CheckDividedDecider;

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
		internal static bool DecorateGeneralList()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectExtendedRecord()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00眀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779120, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00砀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0075: Expected Obj, but got Ref
			//IL_007a: Expected VT, but got Ref
			//IL_00c7: Expected Obj, but got Ref
			//IL_00c9: Expected Obj, but got I
			//IL_009f: Expected Obj, but got Ref
			//IL_00b0: Expected Obj, but got I
			//IL_0050: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got Ref
			//IL_020c: Expected Obj, but got I4
			//IL_020c: Expected Obj, but got VT
			//IL_020c: Expected Obj, but got I4
			//IL_025b: Expected Obj, but got Ref
			//IL_0271: Expected Obj, but got Ref
			//IL_0273: Expected Obj, but got VT
			//IL_016b: Expected Obj, but got I4
			//IL_0170: Expected Obj, but got I4
			//IL_0170: Expected Obj, but got Ref
			//IL_018f: Expected Obj, but got Ref
			//IL_023f: Expected native int or pointer, but got Obj
			//IL_0156: Expected Obj, but got Ref
			//IL_012c: Expected Obj, but got I4
			//IL_0131: Expected Obj, but got Ref
			//IL_008e->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00d3->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00b5->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0099->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00c0->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01e0->IL00e9: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 2;
			object obj = awaiter;
			while (true)
			{
				int num;
				switch ((int)obj)
				{
				case 3:
					((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP = -2;
					obj = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP == null)
					{
						obj = 0;
					}
					break;
				default:
					((EqualityComparer<_00210>)/*Error near IL_007a: Stack underflow*/).GetHashCode((_00210)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CserverId_003EP));
					_ = 4;
					if (DesktopAuthentication.TokenKey != null)
					{
						_ = 5;
					}
					break;
				case 2:
					awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._client;
					obj = 1;
					if (((DesktopAuthentication)DesktopAuthentication._connected)._buffer != null)
					{
						obj = 1;
					}
					break;
				case 5:
					return;
				case 1:
					awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshake;
					obj = 4;
					break;
				case 4:
					{
						if (awaiter == null)
						{
							num = 11;
							goto IL_00e9;
						}
						goto IL_01ef;
					}
					IL_01ef:
					awaiter = ((MassService)/*Error near IL_020c: Stack underflow*/).JoinServerAsync((byte[])/*Error near IL_020c: Stack underflow*/, (string)/*Error near IL_020c: Stack underflow*/, (string)(object)DesktopAuthentication.ReflectExtendedAuditor(), (string)((TaskAwaiter<byte[]>*)awaiter)->IsCompleted, (string)((Task)awaiter).GetAwaiter(), (string)DesktopAuthentication._003CAuthentication_003Ed__27.CheckExpandableComparator());
					num = 0;
					if (((DesktopAuthentication._003CConnect_003Ed__19)DesktopAuthentication._003CConnect_003Ed__19._003C_003Et__builder)._003C_003E4__this == null)
					{
						num = 0;
					}
					goto IL_00e9;
					IL_00e9:
					while (true)
					{
						switch (num)
						{
						case 3:
							break;
						case 9:
							return;
						case 12:
							awaiter = -1;
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeSent = -1;
							num = 0;
							if (((DesktopAuthentication)DesktopAuthentication._handshakeKey)._encryptedToken == null)
							{
								num = 1;
							}
							continue;
						case 7:
							Unsafe.As<object, AsyncTaskMethodBuilder<EntityNetGameItem[]>>(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptChaCha) = default;
							num = 12;
							continue;
						case 2:
							awaiter = 0;
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeTcs = 0;
							num = 5;
							continue;
						case 4:
							Unsafe.As<object?, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._authenticationTcs).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<byte[]>*)(&awaiter), ref Unsafe.As<_003CHeartbeatAsync_003Ed__7, DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22>(ref this));
							num = 9;
							if ((int)((DesktopAuthentication._003CAuthentication_003Ed__27*)DesktopAuthentication._003CAuthentication_003Ed__27._003C_003E1__state)->_003C_003Et__builder != 0)
							{
								num = 8;
							}
							continue;
						case 6:
						case 11:
							awaiter = ((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E4__this;
							num = 7;
							continue;
						case 8:
							((AsyncTaskMethodBuilder*)/*Error near IL_01d1: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)awaiter, ref *(TStateMachine*)awaiter);
							_ = ((TaskAwaiter*)/*Error near IL_01d6: Stack underflow*/)->IsCompleted;
							_ = 3;
							continue;
						case 10:
							goto IL_01ef;
						case 5:
							((DesktopAuthentication._003CConnect_003Ed__19)this).authServer = (EntityAuthServer)awaiter;
							num = 4;
							if ((int)((DesktopAuthentication._003CConnect_003Ed__19*)(nint)DesktopAuthentication._003CConnect_003Ed__19._003Ccts_003E5__2)->_003C_003Eu__1 == 0)
							{
								num = 1;
							}
							continue;
						default:
							if (((TaskCompletionSource)(&awaiter)).Task == null)
							{
								num = 2;
								continue;
							}
							goto case 1;
						case 1:
							awaiter = ((CancellationTokenSource)(&awaiter)).Token;
							num = 8;
							continue;
						}
						break;
					}
					goto case 3;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00礀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779123, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00稀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00笀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779122, new IntPtr(2737336612556L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00簀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779133, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00紀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00縀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779132, new IntPtr(2737336620876L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00缀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779135, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00耀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInterLoginStartAsync_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		private TaskAwaiter<EntityResponse> _003C_003Eu__1;

		internal static object ReflectVisibleContext;

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
		internal static bool ReflectCentralMapper()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckStatelessPolicy()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00瀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779134, new IntPtr(2737336637516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00焀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_02f2: Expected Obj, but got VT
			//IL_02fc: Expected native int or pointer, but got Obj
			//IL_0060: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got Ref
			//IL_02ca: Expected Obj, but got Ref
			//IL_02d4: Expected native int or pointer, but got Obj
			//IL_00ec: Expected Obj, but got Ref
			//IL_0160: Expected Obj, but got Ref
			//IL_0168: Expected Obj, but got Ref
			//IL_0112: Expected Obj, but got I4
			//IL_0117: Expected Obj, but got I4
			//IL_0117: Expected Obj, but got Ref
			//IL_01f6: Expected Ref, but got VT
			//IL_01fd: Expected Obj, but got I4
			//IL_0150: Expected Obj, but got Ref
			//IL_01d5: Expected Obj, but got I4
			//IL_01da: Expected Obj, but got I4
			//IL_019d: Expected Obj, but got Ref
			//IL_0128: Expected Obj, but got Ref
			//IL_0138: Expected Obj, but got I
			//IL_0306->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0076->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02de->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0311->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0081->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02e9->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0172->IL00ac: Incompatible stack heights: 4 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				default:
					return;
				case 4:
					((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP = -2;
					obj2 = 5;
					break;
				case 3:
					obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserToken_003EP;
					obj2 = 2;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
					{
						obj2 = 2;
					}
					break;
				case 1:
					if (obj != null)
					{
						num = 2;
						if (DesktopAuthentication.Logger != null)
						{
							num = 4;
						}
						goto IL_00ac;
					}
					goto IL_00e6;
				case 5:
					((IDisposable)Unsafe.AsPointer(ref ((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003E4__this)).Dispose();
					obj2 = 0;
					if (((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24*)(nint)DesktopAuthentication._003CHeartbeatAsync_003Ed__25.ProcessResolver)->_003C_003E1__state != 0)
					{
						obj2 = 0;
					}
					break;
				case 0:
					return;
				case 2:
					{
						obj = ((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003Et__builder;
						obj2 = 1;
						if ((int)((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24*)(nint)DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24._003C_003E4__this)->_003C_003Eu__1 != 0)
						{
							obj2 = 1;
						}
						break;
					}
					IL_00e6:
					obj = DesktopAuthentication.TokenKey;
					num = 0;
					if (((DesktopAuthentication)DesktopAuthentication._client)._connected != 0)
					{
						num = 0;
					}
					goto IL_00ac;
					IL_00ac:
					while (true)
					{
						switch (num)
						{
						case 7:
							break;
						case 1:
							goto IL_00e6;
						case 3:
							obj = 0;
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._buffer = (List<byte>)0;
							num = 6;
							continue;
						case 10:
						case 11:
							((List<byte>)(&obj))._002Ector();
							num = 2;
							if (((DesktopAuthentication)DesktopAuthentication._handshakeSent)._handshakeKey == null)
							{
								num = 7;
							}
							continue;
						case 6:
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptedToken = obj;
							num = 2;
							continue;
						case 2:
							_ = ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptChaCha;
							_ = ref obj;
							((IEnumerable<byte>)Unsafe.AsPointer(ref this)).ToArray();
							_ = 5;
							continue;
						case 9:
							if (((ILogger)/*Error near IL_019d: Stack underflow*/).Category((string)(&obj)) != null)
							{
								num = 10;
								continue;
							}
							goto case 3;
						case 5:
							return;
						case 8:
							obj = -1;
							((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E4__this = (DesktopAuthentication)(-1);
							num = 11;
							continue;
						case 4:
							((DesktopAuthentication)obj)._003CAuthentication_003Eb__27_0();
							((AsyncTaskMethodBuilder*)/*Error near IL_01f6: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(new TaskAwaiter() ? ((ValueTaskAwaiter*)1) : ((ValueTaskAwaiter*)null)), ref *(DesktopAuthentication._003CSendMessageAsync_003Ed__29*)null);
							obj = ((TaskAwaiter<byte[]>*)/*Error near IL_01fb: Stack underflow*/)->IsCompleted;
							num = 9;
							continue;
						default:
							Unsafe.As<TaskAwaiter, AsyncTaskMethodBuilder<EntityGameCharacter[]>>(ref ((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Eu__2) = default;
							num = 8;
							continue;
						}
						break;
					}
					goto case 4;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00爀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779129, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00猀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0044: Expected VT, but got Obj
			//IL_0044: Expected VT, but got Ref
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0044: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP != null)
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
		internal static byte _FF00_FF00_FF00琀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00甀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00瘀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779128, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInterLoginStopAsync_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		private TaskAwaiter<EntityResponse> _003C_003Eu__1;

		private static object CheckScheduledRequester;

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
		internal static bool ReflectFilteredModule()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectAutomatedEvent()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00最()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779131, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00栀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_02db: Expected VT, but got I4
			//IL_02b3: Expected Obj, but got Ref
			//IL_004e: Expected Obj, but got Ref
			//IL_012f: Expected Obj, but got Ref
			//IL_0140: Expected Obj, but got I
			//IL_01f3: Expected Obj, but got I4
			//IL_01f8: Expected Obj, but got I4
			//IL_0201: Expected Obj, but got I4
			//IL_00fe: Expected Obj, but got I4
			//IL_0103: Expected Obj, but got I4
			//IL_0103: Expected Obj, but got Ref
			//IL_0113: Expected Obj, but got Ref
			//IL_0124: Expected Obj, but got I4
			//IL_01d9: Expected native int or pointer, but got Obj
			//IL_01b2: Expected Obj, but got I4
			//IL_01b2: Expected I4, but got Obj
			//IL_01b9: Expected Obj, but got I4
			//IL_01c2: Expected Obj, but got I4
			//IL_017b: Expected Obj, but got Ref
			//IL_00d9: Expected VT, but got Ref
			//IL_00ba: Expected I4, but got Obj
			//IL_02e5->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02c7->IL0026: Incompatible stack heights: 2 vs 1
			//IL_02f7->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0145->IL0085: Incompatible stack types: I4 vs Obj
			//IL_0076->IL0085: Incompatible stack types: I4 vs Obj
			//IL_02d2->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0150->IL0085: Incompatible stack types: I4 vs Obj
			//IL_0081->IL0085: Incompatible stack types: I4 vs Obj
			//IL_016b->IL00f9: Incompatible stack heights: 1 vs 0
			//IL_010d->IL0085: Incompatible stack types: I4 vs Obj
			//IL_01e3->IL0085: Incompatible stack types: I4 vs Obj
			//IL_0195->IL0085: Incompatible stack types: I4 vs Obj
			//IL_00ee->IL0085: Incompatible stack types: I4 vs Obj
			//IL_0175->IL0085: Incompatible stack heights: 2 vs 1
			//IL_01ee->IL0085: Incompatible stack types: I4 vs Obj
			//IL_01a0->IL0085: Incompatible stack types: I4 vs Obj
			//IL_00f9->IL0085: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 5;
			object obj = awaiter;
			while (true)
			{
				object obj2;
				switch ((int)obj)
				{
				default:
					return;
				case 5:
					awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
					obj = 4;
					break;
				case 2:
					if (awaiter != null)
					{
						obj2 = 8;
						if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP != null)
						{
							obj2 = 7;
						}
						goto IL_0085;
					}
					goto IL_0129;
				case 3:
					_ = ((CancellationTokenSource)Unsafe.AsPointer(ref DesktopAuthentication._003CConnect_003Ed__19.CheckAdjustableCommand)).Token;
					_ = 0;
					if (((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)DesktopAuthentication._003CHeartbeatAsync_003Ed__25._003C_003Et__builder)._003C_003E4__this != null)
					{
						_ = 0;
					}
					break;
				case 0:
					return;
				case 1:
					goto IL_02d3;
				case 4:
					{
						awaiter = DesktopAuthentication._003CHeartbeatAsync_003Ed__25.ProcessResolver;
						obj = 2;
						break;
					}
					IL_0085:
					while (true)
					{
						switch ((int)obj2)
						{
						case 6:
						case 10:
							((EqualityComparer<_00210>)/*Error near IL_00d9: Stack underflow*/).Equals((_00210?)/*Error near IL_00d9: Stack underflow*/, (_00210?)(&awaiter));
							obj2 = 0;
							if (DesktopAuthentication.Logger == null)
							{
								obj2 = 0;
							}
							continue;
						case 3:
							awaiter = 0;
							DesktopAuthentication.TokenKey = (byte[])0;
							obj2 = 5;
							continue;
						case 4:
							Unsafe.As<object, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._client).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<byte[]>*)(&awaiter), ref Unsafe.As<_003CInterLoginStopAsync_003Ed__31, DesktopAuthentication._003CAuthentication_003Ed__27>(ref this));
							awaiter = 11;
							goto IL_0081;
						case 7:
							break;
						case 11:
							return;
						case 2:
							_ = ref awaiter;
							if ((int)AsyncTaskMethodBuilder.Create() != 0)
							{
								_ = 6;
								continue;
							}
							goto case 3;
						case 9:
							Unsafe.As<object, _003CRequestAsync_003Ed__13<_0021_00210>>(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptedToken) = default;
							obj2 = 1;
							if (((DesktopAuthentication)DesktopAuthentication._decryptChaCha)._handshakeTcs != null)
							{
								obj2 = 1;
							}
							continue;
						case 8:
							((DefaultInterpolatedStringHandler*)/*Error near IL_01b2: Stack underflow*/)->AppendFormatted((byte)(int)new LoggerExtensions((ILogger)/*Error near IL_01ac: Stack underflow*/, (string)((DesktopAuthentication)/*Error near IL_01a7: Stack underflow*/).SendPacketAsync((byte)/*Error near IL_01a7: Stack underflow*/, awaiter)), (string?)0);
							awaiter = ((TaskCompletionSource)/*Error near IL_01b7: Stack underflow*/).TrySetException((Exception)/*Error near IL_01b7: Stack underflow*/);
							awaiter = 2;
							goto IL_0081;
						case 5:
							((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E4__this = (DesktopAuthentication)awaiter;
							obj2 = 0;
							if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27.modHashList)->serverIdHash == null)
							{
								obj2 = 4;
							}
							continue;
						case 1:
							awaiter = -1;
							((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003Ccts_003E5__2 = -1;
							awaiter = 10;
							goto IL_0081;
						default:
							goto IL_02d3;
							IL_0081:
							obj2 = awaiter;
							continue;
						}
						break;
					}
					goto IL_0129;
					IL_02d3:
					((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003Eu__1 = (TaskAwaiter)(-2);
					obj = 3;
					break;
					IL_0129:
					awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._buffer;
					obj2 = 9;
					if (((DesktopAuthentication)DesktopAuthentication._handshake)._handshakeSent != 0)
					{
						obj2 = 5;
					}
					goto IL_0085;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00椀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779130, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00樀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779109, new IntPtr(2737336627116L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00欀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0044: Expected VT, but got Obj
			//IL_0044: Expected VT, but got Ref
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0044: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
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
		internal unsafe static byte _FF00_FF00_FF00氀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779108, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00洀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00渀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInterStartAsync_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		public string gameId;

		private TaskAwaiter<EntityResponse> _003C_003Eu__1;

		private static object UpdateContext;

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
		internal static bool OpenMapper()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectOperationalContainer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00崀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779111, new IntPtr(2737336619836L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00帀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_009d: Expected Obj, but got Ref
			//IL_0075: Expected Obj, but got Ref
			//IL_0050: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got Ref
			//IL_030e: Expected native int or pointer, but got Obj
			//IL_01d3: Expected Obj, but got VT
			//IL_0210: Expected Obj, but got VT
			//IL_0128: Expected Obj, but got Ref
			//IL_016a: Expected Obj, but got I4
			//IL_016f: Expected Obj, but got I4
			//IL_016f: Expected Obj, but got Ref
			//IL_0140: Expected Obj, but got Ref
			//IL_010f: Expected Obj, but got I4
			//IL_0114: Expected Obj, but got I4
			//IL_0114: Expected Obj, but got Ref
			//IL_011d: Expected Obj, but got I4
			//IL_0233: Expected Obj, but got Ref
			//IL_018a: Expected Obj, but got I4
			//IL_01a6: Expected Obj, but got Ref
			//IL_0242: Expected native int or pointer, but got Obj
			//IL_0105: Expected I4, but got Obj
			//IL_00a9->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0318->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0096->IL0026: Incompatible stack types: I4 vs Obj
			//IL_022c->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_00c5->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0323->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00d0->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_021a->IL00d4: Incompatible stack heights: 2 vs 1
			//IL_013a->IL00d4: Incompatible stack heights: 5 vs 1
			//IL_0179->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_015a->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_018f->IL00d0: Incompatible stack heights: 1 vs 0
			//IL_01ba->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_0165->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_024c->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_01c5->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_0257->IL00d4: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				default:
					return;
				case 4:
					((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP = -2;
					obj2 = 5;
					if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP == null)
					{
						obj2 = 0;
					}
					break;
				case 2:
					obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CserverId_003EP;
					obj2 = 0;
					if (DesktopAuthentication.Logger != null)
					{
						obj2 = 1;
					}
					break;
				case 0:
					return;
				case 1:
					obj = DesktopAuthentication.TokenKey;
					obj2 = 3;
					break;
				case 3:
					if (obj != null)
					{
						obj3 = 0;
						if (((DesktopAuthentication)DesktopAuthentication._client)._connected == 0)
						{
							obj3 = 0;
						}
						goto IL_00d4;
					}
					goto IL_021a;
				case 5:
					{
						((TcpClient)/*Error near IL_0304: Stack underflow*/).ConnectAsync((IPAddress)/*Error near IL_0304: Stack underflow*/, (int)Unsafe.AsPointer(ref ((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003E1__state));
						_ = 0;
						if ((int)((DesktopAuthentication._003CReceiveAsync_003Ed__20*)(nint)DesktopAuthentication._003CReceiveAsync_003Ed__20._003C_003E4__this)->_003C_003Eu__1 != 0)
						{
							_ = 0;
						}
						break;
					}
					IL_021a:
					obj = ((DesktopAuthentication._003CConnect_003Ed__19)this)._003Ccts_003E5__2;
					obj3 = 6;
					goto IL_00d4;
					IL_00d4:
					while (true)
					{
						switch ((int)obj3)
						{
						case 2:
							break;
						case 5:
							return;
						case 7:
							obj = 0;
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._buffer = (List<byte>)0;
							obj = 10;
							goto IL_00d0;
						case 1:
							_ = ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshake;
							_ = ref obj;
							Array.Empty<byte>();
							_ = 5;
							continue;
						case 6:
							Unsafe.As<object, _003CRequestAsync_003Ed__12<_0021_00210>>(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeKey) = default;
							obj3 = 0;
							if (((DesktopAuthentication)DesktopAuthentication._encryptChaCha)._decryptChaCha == null)
							{
								obj3 = 3;
							}
							continue;
						case 3:
							obj = -1;
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeTcs = -1;
							obj3 = 9;
							continue;
						case 9:
							_ = ref obj;
							_ = Log.Logger;
							obj = 2;
							goto IL_00d0;
						case 10:
							DesktopAuthentication.PrepareDic = (DesktopAuthentication)obj;
							obj3 = 0;
							if ((int)((DesktopAuthentication._003CAuthentication_003Ed__27*)DesktopAuthentication._003CAuthentication_003Ed__27._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								obj3 = 1;
							}
							continue;
						default:
						{
							((DesktopAuthentication)obj)._003CConnect_003Eb__19_0();
							obj = new AsyncTaskMethodBuilder(ref *(TAwaiter*)/*Error near IL_01d1: Stack underflow*/, ref *(TStateMachine*)/*Error near IL_01d1: Stack underflow*/);
							byte[] result = ((TaskAwaiter<byte[]>*)((DesktopAuthentication._003CAuthentication_003Ed__27)this).serverIdHash)->GetResult();
							((DesktopAuthentication._003CAuthentication_003Ed__27*)obj)->MoveNext();
							TaskAwaiter awaiter = ((Task)(object)result).GetAwaiter();
							object obj4 = obj;
							TaskAwaiter<byte[]> awaiter2 = ((Task<byte[]>)(object)new LoggerExtensions[1] { (LoggerExtensions)DesktopAuthentication._003CAuthentication_003Ed__27.PopChooser() }).GetAwaiter();
							((AsyncTaskMethodBuilder<_0021_00210>*)obj)->Start(ref *(_003CRequestAsync_003Ed__12<_0021_00210>*)null);
							((CancellationTokenSource)obj4)._002Ector((TimeSpan)awaiter2);
							obj = awaiter;
							_ = 8;
							continue;
						}
						case 4:
							goto IL_021a;
						case 8:
							{
								((TaskCompletionSource)(&obj))._002Ector();
								if ((int)/*Error near IL_0238: Stack underflow*/ == 0)
								{
									obj3 = 7;
									if (((DesktopAuthentication._003CHeartbeatAsync_003Ed__25*)(nint)DesktopAuthentication._003CConnect_003Ed__19.CheckAdjustableCommand)->_003C_003E1__state == 0)
									{
										obj3 = 3;
									}
									continue;
								}
								goto case 9;
							}
							IL_00d0:
							obj3 = obj;
							continue;
						}
						break;
					}
					goto case 4;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00开(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779110, new IntPtr(2737336631276L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00怀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0044: Expected VT, but got Obj
			//IL_0044: Expected VT, but got Ref
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0044: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
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
		private unsafe sealed void _FF00_FF00_FF00愀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779105, new IntPtr(2737336621916L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00戀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779104, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00挀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00搀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779107, new IntPtr(2737336631276L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00攀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLogoutAsync_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<EntityResponse> _003C_003Eu__2;

		private static object TestRequester;

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
		internal static bool InsertModule()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object InterruptEvent()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00刀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779106, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00匀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_009f: Expected Obj, but got Ref
			//IL_00b0: Expected Obj, but got I
			//IL_004e: Expected Obj, but got Ref
			//IL_0075: Expected Obj, but got Ref
			//IL_007a: Expected VT, but got Ref
			//IL_014e: Expected Obj, but got Ref
			//IL_0150: Expected Obj, but got I
			//IL_015f: Expected Obj, but got I
			//IL_0209: Expected native int or pointer, but got Obj
			//IL_03cb: Expected Obj, but got I4
			//IL_035e: Expected Obj, but got VT
			//IL_034c: Expected Obj, but got Ref
			//IL_02db: Expected Obj, but got I4
			//IL_0279: Expected F8, but got VT
			//IL_02e5: Expected Obj, but got I4
			//IL_02ea: Expected VT, but got I4
			//IL_01c1: Expected Obj, but got Ref
			//IL_0188: Expected Obj, but got Ref
			//IL_0235: Expected Obj, but got I4
			//IL_023a: Expected VT, but got I4
			//IL_0408: Expected I4, but got Obj
			//IL_0408: Expected I4, but got Obj
			//IL_040d: Expected I4, but got Obj
			//IL_040d: Expected I4, but got Obj
			//IL_0249: Expected Obj, but got I4
			//IL_024e: Expected VT, but got I4
			//IL_0258: Expected native int or pointer, but got Obj
			//IL_02a0: Expected Obj, but got I4
			//IL_02a5: Expected VT, but got I4
			//IL_02af: Expected native int or pointer, but got Obj
			//IL_0321: Expected Obj, but got Ref
			//IL_0143: Expected I4, but got Obj
			//IL_04d9->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00b5->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008e->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00d2->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_00c0->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0099->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0164->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_0213->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_016f->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_021e->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_03ab->IL00d6: Incompatible stack heights: 2 vs 1
			//IL_0368->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_0356->IL00d6: Incompatible stack heights: 2 vs 1
			//IL_01ec->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_02e0->IL00d2: Incompatible stack heights: 1 vs 0
			//IL_0283->IL00d6: Incompatible stack heights: 2 vs 1
			//IL_02f4->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_0389->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_0230->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_0181->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_01d1->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_0244->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_0424->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_029b->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_0262->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_030f->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_02b9->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_03b6->IL00d6: Incompatible stack heights: 2 vs 1
			//IL_01f7->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_01a1->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_026d->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_031a->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_02c4->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_033a->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_01ac->IL00d6: Incompatible stack types: I4 vs Obj
			//IL_0345->IL00d6: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object stateMachine = 4;
			object obj = stateMachine;
			while (true)
			{
				object obj2;
				switch ((int)obj)
				{
				default:
					return;
				case 4:
					stateMachine = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
					obj = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP != null)
					{
						obj = 3;
					}
					continue;
				case 5:
					((EqualityComparer<_00210>)/*Error near IL_007a: Stack underflow*/).GetHashCode((_00210)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CserverId_003EP));
					_ = 0;
					if (DesktopAuthentication.TokenKey == null)
					{
						_ = 0;
					}
					continue;
				case 3:
					stateMachine = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._client;
					obj = 1;
					if (((DesktopAuthentication)DesktopAuthentication._connected)._buffer == null)
					{
						obj = 1;
					}
					continue;
				case 1:
					if (stateMachine == null)
					{
						obj2 = 7;
						goto IL_00d6;
					}
					goto IL_01f7;
				case 0:
					return;
				case 2:
					break;
					IL_00d6:
					while (true)
					{
						switch ((int)obj2)
						{
						case 2:
							break;
						case 14:
							((AsyncTaskMethodBuilder*)/*Error near IL_0176: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)(&stateMachine));
							obj2 = 8;
							continue;
						case 16:
							((TcpClient)(&stateMachine)).Close();
							if ((int)/*Error near IL_018d: Stack underflow*/ == 0)
							{
								obj2 = 14;
								if (((DesktopAuthentication)DesktopAuthentication._decryptChaCha)._handshakeTcs != null)
								{
									obj2 = 21;
								}
								continue;
							}
							goto case 14;
						case 6:
							return;
						case 15:
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._authenticationTcs = null;
							obj2 = 11;
							continue;
						case 8:
							((TimeoutException)/*Error near IL_01d8: Stack underflow*/)._002Ector((string?)stateMachine);
							obj2 = 9;
							if (((DesktopAuthentication._003CAuthentication_003Ed__27)DesktopAuthentication._003CAuthentication_003Ed__27._003C_003Et__builder)._003C_003E4__this == null)
							{
								obj2 = 10;
							}
							continue;
						case 20:
							goto IL_01f7;
						case 13:
							((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003Ccts_003E5__2 = stateMachine;
							obj2 = 9;
							continue;
						case 17:
							stateMachine = 0;
							((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Eu__1 = (TaskAwaiter<byte[]>)0;
							obj2 = 12;
							continue;
						case 21:
							stateMachine = 1;
							((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Eu__2 = (TaskAwaiter)1;
							obj2 = 13;
							if (((DesktopAuthentication._003CConnect_003Ed__19*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27.ReflectInternalAnnotation)->_003C_003E1__state == 0)
							{
								obj2 = 11;
							}
							continue;
						case 10:
							TimeSpan.FromSeconds((double)((Task<byte[]>)stateMachine).GetAwaiter());
							_ = 22;
							continue;
						case 19:
						{
							object obj4 = stateMachine;
							(DesktopAuthentication._003CConnect_003Ed__19.CheckGenericConsumer() ? ((TaskAwaiter*)1) : ((TaskAwaiter*)null))->GetResult();
							stateMachine = obj4;
							obj2 = 25;
							continue;
						}
						case 24:
							stateMachine = -1;
							((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003Eu__1 = (TaskAwaiter)(-1);
							obj2 = 10;
							if (((DesktopAuthentication._003CHeartbeatAsync_003Ed__25*)(nint)DesktopAuthentication._003CConnect_003Ed__19.CheckAdjustableCommand)->_003C_003E1__state != 0)
							{
								obj2 = 14;
							}
							continue;
						case 9:
							_ = ref ((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003Et__builder;
							((AsyncTaskMethodBuilder<PageModel<IDesktopSkin>>*)(&stateMachine))->Start(ref Unsafe.As<_003CLogoutAsync_003Ed__32, _003CGetOwnedSkinsAsync_003Ed__23>(ref this));
							stateMachine = 6;
							goto IL_00d2;
						case 11:
							stateMachine = -1;
							((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003Eu__1 = (TaskAwaiter)(-1);
							obj2 = 5;
							continue;
						case 22:
							((AsyncTaskMethodBuilder*)/*Error near IL_02fb: Stack underflow*/)->SetException((Exception)stateMachine);
							obj2 = 0;
							if ((int)((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24*)DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24._003C_003E1__state)->_003C_003Et__builder != 0)
							{
								obj2 = 1;
							}
							continue;
						case 25:
							((AsyncTaskMethodBuilder*)/*Error near IL_0321: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)(&stateMachine));
							if ((int)/*Error near IL_0326: Stack underflow*/ == 0)
							{
								obj2 = 0;
								if (DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24.ReflectMixedRunner == null)
								{
									obj2 = 17;
								}
								continue;
							}
							goto case 5;
						case 5:
							_ = ((EntityAuthServer)(&stateMachine)).Port;
							_ = 18;
							continue;
						case 4:
						case 7:
							stateMachine = ((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003Et__builder;
							obj2 = 15;
							continue;
						case 23:
							return;
						case 12:
							((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003E4__this = (DesktopAuthentication)stateMachine;
							obj2 = 3;
							continue;
						case 3:
							_ = ref ((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003Eu__1;
							((AsyncTaskMethodBuilder*)(&stateMachine))->Start(ref Unsafe.As<_003CLogoutAsync_003Ed__32, _003CSetNicknameAsync_003Ed__40>(ref this));
							_ = 23;
							if ((int)((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22*)DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								_ = 12;
							}
							continue;
						default:
							((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this)._003C_003E4__this = null;
							stateMachine = 24;
							goto IL_00d2;
						case 18:
						{
							object obj3 = stateMachine;
							AuthenticationException ex = new AuthenticationException((string?)DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23.ReflectGroupedViewer());
							((AsyncTaskMethodBuilder<EntityRentalGameItem[]>*)((HashAlgorithm)/*Error near IL_040d: Stack underflow*/).ComputeHash((byte[])/*Error near IL_040d: Stack underflow*/, (int)obj3, (int)Arrays.CopyOfRange((byte[])(object)ex, (int)ex, (int)stateMachine)))->Start(ref *(_003CGetRentalGamesAsync_003Ed__51*)1);
							((Salsa20Engine)/*Error near IL_0418: Stack underflow*/).ProcessBytes((byte[])/*Error near IL_0418: Stack underflow*/, (int)/*Error near IL_0418: Stack underflow*/, (int)/*Error near IL_0418: Stack underflow*/, (byte[])/*Error near IL_0418: Stack underflow*/, (int)/*Error near IL_0418: Stack underflow*/);
							stateMachine = (object)/*Error near IL_041a: Stack underflow*/;
							obj2 = 16;
							continue;
						}
						case 1:
							goto end_IL_0026;
							IL_00d2:
							obj2 = stateMachine;
							continue;
						}
						break;
					}
					goto IL_0148;
					IL_01f7:
					if ((nint)stateMachine != 1)
					{
						obj2 = 19;
						if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27.modHashList)->serverIdHash != null)
						{
							obj2 = 18;
						}
						goto IL_00d6;
					}
					goto IL_0148;
					IL_0148:
					stateMachine = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshake;
					obj2 = 0;
					if (((DesktopAuthentication)DesktopAuthentication._handshakeSent)._handshakeKey == null)
					{
						obj2 = 0;
					}
					goto IL_00d6;
					end_IL_0026:
					break;
				}
				((DesktopAuthentication._003CSendMessageAsync_003Ed__29)this)._003C_003E1__state = -2;
				obj = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00吀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779117, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00唀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP != null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00嘀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00圀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779116, new IntPtr(2737336629196L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00堀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00夀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779119, new IntPtr(2737336625036L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPurchaseItemAsync_003Ed__52 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityItemPurchase> _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		public string itemId;

		private TaskAwaiter<EntityItemPurchase> _003C_003Eu__1;

		private static object ReflectCustomizableComparator;

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
		internal static bool InvokeProcessor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckExpandableCommand()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00䤀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779118, new IntPtr(2737336628156L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00䨀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_004e: Expected Obj, but got Ref
			//IL_0055: Expected VT, but got Obj
			//IL_0055: Expected VT, but got Ref
			//IL_0079: Expected Obj, but got I4
			//IL_0079: Expected Obj, but got Ref
			//IL_0065: Expected Obj, but got Ref
			//IL_01fb: Expected Obj, but got I4
			//IL_0201: Expected Ref, but got VT
			//IL_0206: Expected Obj, but got VT
			//IL_0206: Expected Obj, but got VT
			//IL_01c8: Expected Obj, but got VT
			//IL_01d1: Expected Obj, but got I4
			//IL_0143: Expected Obj, but got I4
			//IL_0148: Expected Obj, but got I4
			//IL_0148: Expected Obj, but got Ref
			//IL_0157: Expected Obj, but got I4
			//IL_015c: Expected Obj, but got I4
			//IL_015c: Expected Obj, but got Ref
			//IL_0219: Expected Obj, but got Ref
			//IL_012c: Expected Obj, but got Ref
			//IL_00ee: Expected Obj, but got Ref
			//IL_016e: Expected Obj, but got Ref
			//IL_0228: Expected native int or pointer, but got Obj
			//IL_00e3: Expected I4, but got Obj
			//IL_005f->IL0026: Incompatible stack heights: 2 vs 1
			//IL_008d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02eb->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0071->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0212->IL00ae: Incompatible stack types: I4 vs Obj
			//IL_00aa->IL00ae: Incompatible stack types: I4 vs Obj
			//IL_0098->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02f6->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0152->IL00ae: Incompatible stack types: I4 vs Obj
			//IL_0166->IL00ae: Incompatible stack types: I4 vs Obj
			//IL_013e->IL00ae: Incompatible stack types: I4 vs Obj
			//IL_00fe->IL00ae: Incompatible stack types: I4 vs Obj
			//IL_0182->IL00ae: Incompatible stack types: I4 vs Obj
			//IL_0232->IL00ae: Incompatible stack types: I4 vs Obj
			//IL_018d->IL00ae: Incompatible stack types: I4 vs Obj
			//IL_023d->IL00ae: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 4;
			object obj = awaiter;
			while (true)
			{
				object obj2;
				AsyncTaskMethodBuilder asyncTaskMethodBuilder;
				byte[] result;
				switch ((int)obj)
				{
				default:
					((EqualityComparer<_00211>)/*Error near IL_0055: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)awaiter);
					_ = 5;
					break;
				case 4:
					awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CgameVersion_003EP;
					obj = 3;
					break;
				case 2:
					((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CserverId_003EP = -2;
					obj = 0;
					if (DesktopAuthentication.Logger != null)
					{
						obj = 0;
					}
					break;
				case 1:
					if (awaiter == null)
					{
						obj2 = 8;
						goto IL_00ae;
					}
					goto IL_01d6;
				case 5:
					return;
				case 3:
					{
						awaiter = DesktopAuthentication._003CHeartbeatAsync_003Ed__25.ProcessResolver;
						obj = 0;
						if ((int)((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24*)DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24._003C_003E1__state)->_003C_003Et__builder != 0)
						{
							obj = 1;
						}
						break;
					}
					IL_01d6:
					((DesktopAuthentication)awaiter)._003CConnect_003Eb__19_0();
					asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)new AsyncTaskMethodBuilder(ref *(TAwaiter*)/*Error near IL_01e2: Stack underflow*/, ref *(TStateMachine*)/*Error near IL_01e2: Stack underflow*/);
					result = ((TaskAwaiter<byte[]>*)((DesktopAuthentication._003CAuthentication_003Ed__27)this).serverIdHash)->GetResult();
					((AsyncTaskMethodBuilder*)((Task)((TaskAwaiter<byte[]>*)awaiter)->IsCompleted).GetAwaiter())->Start(ref *(_003CEntityRequestAsync_003Ed__9*)1);
					awaiter = ((MassService)/*Error near IL_0206: Stack underflow*/).JoinServerAsync((byte[])/*Error near IL_0206: Stack underflow*/, (string)/*Error near IL_0206: Stack underflow*/, (string)asyncTaskMethodBuilder, (string)asyncTaskMethodBuilder, (string)(object)result, (string)(object)result);
					obj2 = 6;
					goto IL_00ae;
					IL_00ae:
					while (true)
					{
						switch ((int)obj2)
						{
						case 1:
							break;
						case 9:
							Unsafe.As<byte[], ReadOnlyMemory<byte>>(ref DesktopAuthentication.TokenKey) = default;
							obj2 = 4;
							continue;
						case 3:
							_ = ref awaiter;
							/*Error near IL_0100: Member reference must be method, but was: Field*/;
						case 7:
							Unsafe.As<nint, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeSent).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CPurchaseItemAsync_003Ed__52, DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24>(ref this));
							obj2 = 5;
							continue;
						case 2:
							awaiter = 0;
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptedToken = 0;
							obj2 = 10;
							continue;
						case 4:
							awaiter = -1;
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptChaCha = -1;
							obj2 = 3;
							continue;
						case 10:
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._decryptChaCha = awaiter;
							obj2 = 5;
							if (((DesktopAuthentication)DesktopAuthentication._handshakeTcs)._authenticationTcs == null)
							{
								obj2 = 7;
							}
							continue;
						case 5:
							return;
						default:
							awaiter = ((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Et__builder;
							awaiter = 9;
							obj2 = awaiter;
							continue;
						case 11:
							goto IL_01d6;
						case 6:
							if ((int)((Task<byte[]>)(&awaiter)).GetAwaiter() == 0)
							{
								obj2 = 2;
								if (((DesktopAuthentication._003CConnect_003Ed__19*)(nint)DesktopAuthentication._003CConnect_003Ed__19._003C_003E4__this)->authServer == null)
								{
									obj2 = 2;
								}
								continue;
							}
							goto case 3;
						}
						break;
					}
					goto case 2;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00䬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779113, new IntPtr(2737336619836L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00䰀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00䴀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779112, new IntPtr(2737336613596L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00一()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779115, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00伀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00倀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRequestAsync_003Ed__12<T> : IAsyncStateMachine where T : notnull, EntityResponse
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		public string url;

		public object body;

		public bool checkCode;

		private TaskAwaiter<T> _003C_003Eu__1;

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

		internal static bool DecorateAdjustableStrategy()
		{
			return true;
		}

		internal static object WriteAnnotation()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRequestAsync_003Ed__13<T> : IAsyncStateMachine where T : notnull, EntityResponse
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public string url;

		public string body;

		public DesktopSession _003C_003E4__this;

		public bool checkCode;

		private TaskAwaiter<RestResponse<T>> _003C_003Eu__1;

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

		internal static bool DecorateCustomEmitter()
		{
			return true;
		}

		internal static object CheckAdvancedRunner()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSearchSkinAsync_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<PageModel<IDesktopSkin>> _003C_003Et__builder;

		public int page;

		public DesktopSession _003C_003E4__this;

		public string keyword;

		private object _003Cskins_003E5__2;

		private nint _003CtotalPage_003E5__3;

		private TaskAwaiter<Entities<EntitySkinItem>> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private static object ReflectConvertibleClient;

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
		internal static bool BuildStrategy()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectFlexibleTracker()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00䀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779114, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00䄀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0047: Expected I4, but got Obj
			//IL_0052: Expected Obj, but got Ref
			//IL_00a0: Expected Obj, but got Ref
			//IL_00c8: Expected Obj, but got Ref
			//IL_0586: Expected Obj, but got Ref
			//IL_007b: Expected Obj, but got I4
			//IL_007b: Expected Obj, but got Ref
			//IL_01aa: Expected Obj, but got Ref
			//IL_00f0: Expected Obj, but got I
			//IL_031d: Expected VT, but got Obj
			//IL_0327: Expected native int or pointer, but got Obj
			//IL_040e: Expected VT, but got Ref
			//IL_0427: Expected native int or pointer, but got Obj
			//IL_02ca: Expected Obj, but got F8
			//IL_02d0: Expected Obj, but got I4
			//IL_0463: Expected Obj, but got I4
			//IL_01ee: Expected Obj, but got I4
			//IL_01f3: Expected Obj, but got I4
			//IL_04a7: Expected Obj, but got I4
			//IL_04ac: Expected Obj, but got I4
			//IL_01bc: Expected Obj, but got Ref
			//IL_0382: Expected Obj, but got VT
			//IL_03a8: Expected Obj, but got I4
			//IL_03ad: Expected Obj, but got I4
			//IL_03b7: Expected native int or pointer, but got Obj
			//IL_0222: Expected Obj, but got Ref
			//IL_0224: Expected Obj, but got VT
			//IL_04be: Expected I4, but got Obj
			//IL_01df: Expected Obj, but got I4
			//IL_0211: Expected Obj, but got I4
			//IL_023a: Expected Obj, but got I4
			//IL_0246: Expected F8, but got VT
			//IL_024e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0251: Unknown result type (might be due to invalid IL or missing references)
			//IL_0257: Expected Ref, but got Unknown
			//IL_025f: Expected Obj, but got I4
			//IL_0265: Expected Ref, but got VT
			//IL_026a: Expected Obj, but got VT
			//IL_026c: Expected Obj, but got VT
			//IL_0341: Expected Obj, but got I4
			//IL_0346: Expected Obj, but got I4
			//IL_02e1: Expected Obj, but got Ref
			//IL_047a: Expected native int or pointer, but got Obj
			//IL_0179: Expected I4, but got Obj
			//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00b6->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00d9->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0590->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01b6->IL0104: Incompatible stack types: I4 vs Obj
			//IL_00f5->IL0104: Incompatible stack types: I4 vs Obj
			//IL_0073->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00c1->IL0026: Incompatible stack types: I4 vs Obj
			//IL_009a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0100->IL0104: Incompatible stack types: I4 vs Obj
			//IL_0331->IL0104: Incompatible stack types: I4 vs Obj
			//IL_0431->IL0104: Incompatible stack types: I4 vs Obj
			//IL_03e2->IL0104: Incompatible stack types: I4 vs Obj
			//IL_02da->IL0104: Incompatible stack types: I4 vs Obj
			//IL_0306->IL0104: Incompatible stack types: I4 vs Obj
			//IL_01fd->IL0104: Incompatible stack types: I4 vs Obj
			//IL_04b6->IL0104: Incompatible stack types: I4 vs Obj
			//IL_01ce->IL0104: Incompatible stack types: I4 vs Obj
			//IL_0398->IL0104: Incompatible stack heights: 4 vs 1
			//IL_03c1->IL0104: Incompatible stack types: I4 vs Obj
			//IL_022e->IL0104: Incompatible stack types: I4 vs Obj
			//IL_04c8->IL0104: Incompatible stack types: I4 vs Obj
			//IL_0199->IL0104: Incompatible stack types: I4 vs Obj
			//IL_01e9->IL0104: Incompatible stack heights: 2 vs 1
			//IL_021b->IL0104: Incompatible stack heights: 3 vs 1
			//IL_0276->IL0104: Incompatible stack heights: 4 vs 1
			//IL_035a->IL0104: Incompatible stack types: I4 vs Obj
			//IL_0298->IL0104: Incompatible stack heights: 2 vs 1
			//IL_033c->IL0104: Incompatible stack types: I4 vs Obj
			//IL_043c->IL0104: Incompatible stack types: I4 vs Obj
			//IL_0484->IL0104: Incompatible stack types: I4 vs Obj
			//IL_0452->IL0104: Incompatible stack types: I4 vs Obj
			//IL_03a3->IL0104: Incompatible stack heights: 4 vs 1
			//IL_03cc->IL0104: Incompatible stack types: I4 vs Obj
			//IL_01a4->IL0104: Incompatible stack types: I4 vs Obj
			//IL_0365->IL0104: Incompatible stack types: I4 vs Obj
			//IL_02a3->IL0104: Incompatible stack heights: 2 vs 1
			//IL_02f0->IL0104: Incompatible stack types: I4 vs Obj
			//IL_048f->IL0104: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 2;
			object obj = awaiter;
			while (true)
			{
				object obj2;
				switch ((int)obj)
				{
				case 1:
					awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
					obj = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP == null)
					{
						obj = 0;
					}
					break;
				case 6:
					((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CserverId_003EP = -2;
					obj = 2;
					if (DesktopAuthentication.Logger != null)
					{
						obj = 5;
					}
					break;
				case 2:
					awaiter = DesktopAuthentication.TokenKey;
					obj = 1;
					if (((DesktopAuthentication)DesktopAuthentication._client)._connected == 0)
					{
						obj = 0;
					}
					break;
				case 3:
					return;
				case 4:
					_ = ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._buffer;
					((List<byte>)awaiter)._002Ector();
					_ = 3;
					break;
				default:
					if (awaiter != null)
					{
						obj2 = 5;
						if (((DesktopAuthentication)DesktopAuthentication._handshakeSent)._handshakeKey != null)
						{
							obj2 = 5;
						}
						goto IL_0104;
					}
					goto IL_01a4;
				case 5:
					{
						DecorateVisibleDecider = null;
						obj = 4;
						break;
					}
					IL_01a4:
					awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeTcs;
					obj2 = 3;
					goto IL_0104;
					IL_0104:
					while (true)
					{
						switch ((int)obj2)
						{
						case 25:
							break;
						default:
							return;
						case 0:
							return;
						case 19:
							return;
						case 17:
						case 22:
							((AsyncTaskMethodBuilder*)/*Error near IL_0185: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)(&awaiter));
							obj2 = 13;
							if (((DesktopAuthentication)DesktopAuthentication._encryptChaCha)._decryptChaCha != null)
							{
								obj2 = 3;
							}
							continue;
						case 11:
							goto IL_01a4;
						case 12:
							Unsafe.As<object?, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._authenticationTcs).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<byte[]>*)(&awaiter), ref Unsafe.As<_003CSearchSkinAsync_003Ed__24, DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22>(ref this));
							obj2 = 19;
							continue;
						case 20:
						{
							int num = ((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E1__state;
							DesktopAuthentication._002Ecctor();
							((IEnumerable<byte>)num).Take(1);
							_ = 23;
							continue;
						}
						case 8:
							awaiter = -1;
							((DesktopAuthentication._003CAuthentication_003Ed__27)this).modHashList = (string)(-1);
							obj2 = 17;
							continue;
						case 21:
							_ = ((DesktopAuthentication._003CAuthentication_003Ed__27)this).serverIdHash;
							awaiter = ((TaskAwaiter<byte[]>*)DesktopAuthentication.ReflectExtendedAuditor())->IsCompleted;
							_ = 9;
							continue;
						case 15:
						case 18:
							awaiter = ((Task)(&awaiter)).GetAwaiter();
							obj2 = 2;
							continue;
						case 23:
						{
							new MassService((byte[])/*Error near IL_023a: Stack underflow*/, (string)/*Error near IL_023a: Stack underflow*/, (string)/*Error near IL_023a: Stack underflow*/, (string)/*Error near IL_023a: Stack underflow*/, (string)awaiter, (string)DesktopAuthentication._003CAuthentication_003Ed__27.CheckExpandableComparator());
							TimeSpan timeSpan = TimeSpan.FromSeconds((double)((DesktopAuthentication._003CConnect_003Ed__19)this)._003C_003Et__builder);
							((TaskAwaiter*)((((DesktopAuthentication._003CConnect_003Ed__19)this).authServer - 1) * 20))->GetResult();
							((TaskCompletionSource)20)._002Ector();
							((AsyncTaskMethodBuilder<PageModel<IDesktopSkin>>*)timeSpan)->Start(ref *(_003CGetSkinsAsync_003Ed__20*)1);
							awaiter = ((CancellationTokenSource)timeSpan).Token;
							_ = 27;
							continue;
						}
						case 26:
							_ = ref ((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003Et__builder;
							((AsyncTaskMethodBuilder<PageModel<IDesktopSkin>>*)(&awaiter))->Start(ref Unsafe.As<_003CSearchSkinAsync_003Ed__24, _003CGetOwnedSkinsAsync_003Ed__23>(ref this));
							_ = 0;
							if (DesktopAuthentication._003CHeartbeatAsync_003Ed__25.ProcessResolver == null)
							{
								_ = 0;
							}
							continue;
						case 4:
							((AsyncTaskMethodBuilder*)awaiter)->SetResult();
							((IAsyncStateMachine)/*Error near IL_02ca: Stack underflow*/).SetStateMachine((IAsyncStateMachine)((double)(ref this) / 20.0));
							Unsafe.Write(&((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24*)(nint)/*Error near IL_02d0: Stack underflow*/)->_003C_003E4__this, (DesktopAuthentication)(int)/*Error near IL_02cb: Stack underflow*/);
							obj2 = 21;
							continue;
						case 27:
							if (((EntityAuthServer)(&awaiter)).Ip != null)
							{
								obj2 = 18;
								continue;
							}
							goto case 10;
						case 6:
							Unsafe.As<object, DefaultInterpolatedStringHandler>(ref DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24.ReflectMixedRunner) = default;
							obj2 = 8;
							continue;
						case 1:
							((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)awaiter;
							obj2 = 12;
							if ((int)((DesktopAuthentication._003CReceiveAsync_003Ed__20*)(nint)DesktopAuthentication._003CReceiveAsync_003Ed__20._003C_003E4__this)->_003C_003Eu__1 == 0)
							{
								obj2 = 5;
							}
							continue;
						case 24:
							awaiter = 1;
							DesktopAuthentication._003CReceiveAsync_003Ed__20.CheckCommonTracker = 1;
							obj2 = 0;
							if ((int)((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22*)DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								obj2 = 1;
							}
							continue;
						case 13:
							((byte[])(object)new Encoding()).Xor(((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this).data);
							awaiter = Enumerable.ToArray<TSource>((IEnumerable<TSource>)((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this)._003C_003Eu__2);
							_ = 25;
							if ((int)((DesktopAuthentication._003CReceiveDataAsync_003Ed__21*)DesktopAuthentication._003CReceiveDataAsync_003Ed__21._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								_ = 25;
							}
							continue;
						case 14:
							awaiter = -1;
							((DesktopAuthentication._003CReceiveDataAsync_003Ed__21)this)._003C_003E4__this = (DesktopAuthentication)(-1);
							obj2 = 15;
							if ((int)((DesktopAuthentication._003CReceiveDataAsync_003Ed__21*)(nint)DesktopAuthentication._003CReceiveDataAsync_003Ed__21.buffer)->_003C_003Eu__1 == 0)
							{
								obj2 = 3;
							}
							continue;
						case 3:
							Unsafe.As<nint, @null>(ref ((DesktopAuthentication._003CReceiveDataAsync_003Ed__21)this)._003Clength_003E5__2) = null;
							obj2 = 14;
							continue;
						case 2:
							((DefaultInterpolatedStringHandler*)/*Error near IL_040e: Stack underflow*/)->AppendFormatted<T>((T)Unsafe.AsPointer(ref this), (string?)awaiter);
							((AsyncTaskMethodBuilder<EntityServerTime>*)/*Error near IL_0413: Stack underflow*/)->Start(ref *(_003CGetServerTimeAsync_003Ed__58*)/*Error near IL_0413: Stack underflow*/);
							((AsyncTaskMethodBuilder<Entities<EntityNetGameItem>>*)/*Error near IL_0418: Stack underflow*/)->Start(ref *(_003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed*)/*Error near IL_0418: Stack underflow*/);
							Unsafe.Write(&((DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23*)(nint)/*Error near IL_041d: Stack underflow*/)->_003C_003E4__this, /*Error near IL_041d: Stack underflow*/);
							obj2 = 1;
							if (((DesktopAuthentication._003CSendMessageAsync_003Ed__29*)(nint)DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23.ReflectScalableNotifier)->_003C_003E1__state == 0)
							{
								obj2 = 4;
							}
							continue;
						case 9:
							if (((List<byte>)/*Error near IL_0443: Stack underflow*/).GetRange((int)/*Error near IL_0443: Stack underflow*/, (int)(&awaiter)) != null)
							{
								obj2 = 22;
								continue;
							}
							goto case 24;
						case 7:
							awaiter = ((DesktopAuthentication._003CSendMessageAsync_003Ed__29)this)._003C_003E4__this;
							awaiter = 6;
							obj2 = awaiter;
							continue;
						case 5:
							if ((nint)awaiter != 1)
							{
								obj2 = 20;
								if ((int)((DesktopAuthentication._003CSendMessageAsync_003Ed__29*)(nint)DesktopAuthentication._003CSendMessageAsync_003Ed__29.data)->_003C_003Eu__1 == 0)
								{
									obj2 = 2;
								}
								continue;
							}
							goto case 7;
						case 10:
							awaiter = 0;
							DesktopAuthentication._003CSendMessageAsync_003Ed__29.CheckAccessibleCalculator = 0;
							obj2 = 16;
							continue;
						case 16:
							((DesktopAuthentication._003CSendPacketAsync_003Ed__28)this)._003C_003E1__state = (int)awaiter;
							obj2 = 26;
							continue;
						}
						break;
					}
					goto case 6;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00䈀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779093, new IntPtr(2737336636476L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00䌀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00䐀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779092, new IntPtr(2737336631276L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00䔀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779095, new IntPtr(2737336637516L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00䘀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00䜀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSetNicknameAsync_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopSession _003C_003E4__this;

		public string nickname;

		private TaskAwaiter _003C_003Eu__1;

		internal static object HandleConfig;

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
		internal static bool PauseEmitter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectAdaptableTag()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00㐀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779094, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00㔀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_004f: Expected Obj, but got Ref
			//IL_0073: Expected Obj, but got Ref
			//IL_0063: Expected Obj, but got I4
			//IL_0063: Expected Obj, but got Ref
			//IL_009a: Expected Obj, but got Ref
			//IL_009f: Expected Obj, but got Ref
			//IL_02ac: Expected Obj, but got VT
			//IL_02ac: Expected Ref, but got VT
			//IL_02b9: Expected Obj, but got VT
			//IL_02b9: Expected Obj, but got VT
			//IL_02bf: Expected Obj, but got I4
			//IL_02d0: Expected native int or pointer, but got Obj
			//IL_01c8: Expected native int or pointer, but got Obj
			//IL_025c: Expected Obj, but got I4
			//IL_0261: Expected Obj, but got I4
			//IL_01fe: Expected Obj, but got Ref
			//IL_0208: Expected native int or pointer, but got Obj
			//IL_0224: Expected Obj, but got Ref
			//IL_0172: Expected Obj, but got Ref
			//IL_0162: Expected Obj, but got Ref
			//IL_0285: Expected Obj, but got I4
			//IL_013c: Expected Obj, but got Ref
			//IL_02ed: Expected Obj, but got VT
			//IL_02f7: Expected native int or pointer, but got Obj
			//IL_01f2: Expected Obj, but got I4
			//IL_012a: Expected I4, but got Obj
			//IL_005b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0089->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00b3->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0094->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02da->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_00da->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_00be->IL0026: Incompatible stack heights: 2 vs 1
			//IL_02e5->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_00e5->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_01d2->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_01b2->IL00e9: Incompatible stack heights: 2 vs 1
			//IL_0275->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_0212->IL00e9: Incompatible stack heights: 2 vs 1
			//IL_018e->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_016c->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_0294->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_014b->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_0301->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_01dd->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_0280->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_021d->IL00e9: Incompatible stack heights: 2 vs 1
			//IL_0233->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_0199->IL00e9: Incompatible stack types: I4 vs Obj
			//IL_030c->IL00e9: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 1;
			object obj = awaiter;
			while (true)
			{
				object obj2;
				object obj3;
				CancellationTokenRegistration cancellationToken;
				switch ((int)obj)
				{
				case 4:
					return;
				default:
					awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
					obj = 3;
					break;
				case 2:
					((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserToken_003EP = -2;
					obj = 5;
					break;
				case 1:
					awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CgameVersion_003EP;
					obj = 0;
					if (DesktopAuthentication.Crc32 != null)
					{
						obj = 0;
					}
					break;
				case 5:
					((object)Unsafe.AsPointer(ref DesktopAuthentication.Logger)).ToString();
					_ = 4;
					if (((DesktopAuthentication)DesktopAuthentication._client)._connected == 0)
					{
						_ = 4;
					}
					break;
				case 3:
					{
						if (awaiter == null)
						{
							obj2 = 0;
							if (((DesktopAuthentication)(object)DesktopAuthentication._buffer)._handshake == 0)
							{
								obj2 = 0;
							}
							goto IL_00e9;
						}
						goto IL_0294;
					}
					IL_0294:
					obj3 = awaiter;
					cancellationToken = new CancellationToken((Action)DesktopAuthentication._003CHeartbeatAsync_003Ed__25.ExcludeError());
					((AsyncTaskMethodBuilder*)cancellationToken)->SetException((Exception)((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003Eu__1);
					((AsyncTaskMethodBuilder*)awaiter)->SetResult();
					((IAsyncStateMachine)cancellationToken).SetStateMachine((IAsyncStateMachine)cancellationToken);
					((DesktopAuthentication._003CReceiveAsync_003Ed__20*)obj3)->SetStateMachine((IAsyncStateMachine)1);
					awaiter = ((EntityAuthServer)/*Error near IL_02c4: Stack underflow*/).Ip;
					obj2 = 6;
					if (((DesktopAuthentication._003CReceiveAsync_003Ed__20*)(nint)DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24.ReflectMixedRunner)->_003C_003E1__state == 0)
					{
						obj2 = 9;
					}
					goto IL_00e9;
					IL_00e9:
					while (true)
					{
						switch ((int)obj2)
						{
						case 8:
							return;
						case 7:
							break;
						case 13:
							((AsyncTaskMethodBuilder*)((DesktopAuthentication)/*Error near IL_0136: Stack underflow*/).ReceiveControlDataAsync(awaiter))->Start<TStateMachine>(ref *(TStateMachine*)((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeKey);
							obj2 = 7;
							continue;
						case 11:
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptChaCha = awaiter;
							obj2 = 10;
							continue;
						case 10:
							Unsafe.As<object, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._decryptChaCha).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CSetNicknameAsync_003Ed__40, DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22>(ref this));
							obj2 = 8;
							if (DesktopAuthentication.PrepareDic == null)
							{
								obj2 = 2;
							}
							continue;
						case 3:
							awaiter = new TimeoutException((string?)awaiter);
							DesktopAuthentication._002Ecctor();
							_ = 13;
							continue;
						case 1:
							((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E4__this = null;
							obj2 = 12;
							if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27.serverIdHash)->_003Ccts_003E5__2 != null)
							{
								obj2 = 1;
							}
							continue;
						case 2:
							((DesktopAuthentication._003CAuthentication_003Ed__27*)awaiter)->MoveNext();
							if ((int)/*Error near IL_01e9: Stack underflow*/ == 0)
							{
								awaiter = 3;
								obj2 = awaiter;
								continue;
							}
							goto case 13;
						case 5:
							((Task)(&awaiter)).GetAwaiter();
							_ = 2;
							if (((DesktopAuthentication._003CConnect_003Ed__19*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27.ReflectInternalAnnotation)->_003C_003E1__state != 0)
							{
								_ = 2;
							}
							continue;
						case 9:
							if ((int)((Task<byte[]>)(&awaiter)).GetAwaiter() == 0)
							{
								obj2 = 4;
								continue;
							}
							goto case 5;
						case 4:
							awaiter = 0;
							((DesktopAuthentication._003CConnect_003Ed__19)this)._003Ccts_003E5__2 = 0;
							obj2 = 11;
							if (DesktopAuthentication._003CConnect_003Ed__19.CheckAdjustableCommand == null)
							{
								obj2 = 5;
							}
							continue;
						case 12:
							awaiter = -1;
							((DesktopAuthentication._003CHeartbeatAsync_003Ed__25)this)._003C_003E1__state = -1;
							obj2 = 5;
							continue;
						case 6:
							goto IL_0294;
						default:
							awaiter = ((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003Et__builder;
							obj2 = 1;
							if ((int)((DesktopAuthentication._003CReceiveAsync_003Ed__20*)(nint)DesktopAuthentication._003CReceiveAsync_003Ed__20._003C_003E4__this)->_003C_003Eu__1 != 0)
							{
								obj2 = 0;
							}
							continue;
						}
						break;
					}
					goto case 2;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00㘀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779089, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00㜀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0044: Expected VT, but got Obj
			//IL_0044: Expected VT, but got Ref
			//IL_0058->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0063->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0044: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
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
		private unsafe sealed void _FF00_FF00_FF00㠀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779088, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00㤀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779091, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00㨀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00㬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779090, new IntPtr(2737336636476L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00㰀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779101, new IntPtr(2737336614636L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00㴀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSetSkinAsync_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntitySkinSetting[]> _003C_003Et__builder;

		public string itemId;

		public DesktopSession _003C_003E4__this;

		private long _003CskinId_003E5__2;

		private object _003CpurchaseItemResult_003E5__3;

		private nint _003Cbought_003E5__4;

		private TaskAwaiter<EntityItemPurchase> _003C_003Eu__1;

		private nint _003Ci_003E5__5;

		private TaskAwaiter<bool> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private TaskAwaiter<EntitySkinSetting[]> _003C_003Eu__4;

		private static object VisitClient;

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
		internal static bool ReflectBasicTransmitter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckReadableRecommender()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_2B00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779100, new IntPtr(2737336636476L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00Ⰰ()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_004e: Expected Obj, but got Ref
			//IL_0a20: Expected Obj, but got I4
			//IL_0062: Expected Obj, but got I4
			//IL_0062: Expected Obj, but got Ref
			//IL_006b: Expected Obj, but got I4
			//IL_0114: Expected Obj, but got Ref
			//IL_08fe: Expected I4, but got Obj
			//IL_07a1: Expected I4, but got Obj
			//IL_07b5: Expected Obj, but got I4
			//IL_07bc: Expected Obj, but got Ref
			//IL_090d: Expected Obj, but got I4
			//IL_0912: Expected VT, but got I4
			//IL_0170: Expected I4, but got Obj
			//IL_00f0: Expected Obj, but got I4
			//IL_00f5: Expected Obj, but got I4
			//IL_00f5: Expected Obj, but got Ref
			//IL_093c: Expected Obj, but got VT
			//IL_0937: Expected native int or pointer, but got Obj
			//IL_0945: Expected Obj, but got I4
			//IL_0690: Expected Obj, but got I4
			//IL_0699: Expected Obj, but got I4
			//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ad: Expected I4, but got Unknown
			//IL_0656: Expected Obj, but got I4
			//IL_065f: Expected Obj, but got I4
			//IL_04e4: Expected native int or pointer, but got Obj
			//IL_05dd: Expected Obj, but got I4
			//IL_05e2: Expected Obj, but got I4
			//IL_02ea: Expected Obj, but got I4
			//IL_02ef: Expected Obj, but got I4
			//IL_0300: Expected native int or pointer, but got Obj
			//IL_028f: Expected Obj, but got I4
			//IL_057a: Expected Obj, but got I4
			//IL_062b: Expected Obj, but got I4
			//IL_0630: Expected Obj, but got I4
			//IL_063a: Expected native int or pointer, but got Obj
			//IL_070e: Expected VT, but got Obj
			//IL_0727: Expected Obj, but got Ref
			//IL_0547: Expected Obj, but got VT
			//IL_050f: Expected Obj, but got I4
			//IL_0514: Expected Obj, but got I4
			//IL_0425: Expected Obj, but got I4
			//IL_042a: Expected Obj, but got I4
			//IL_025e: Expected Obj, but got I4
			//IL_0263: Expected Obj, but got Ref
			//IL_0273: Expected Obj, but got Ref
			//IL_02ca: Expected Obj, but got Ref
			//IL_031b: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a5: Expected Obj, but got I4
			//IL_0556: Expected Obj, but got I4
			//IL_0477: Expected VT, but got Obj
			//IL_0481: Expected native int or pointer, but got Obj
			//IL_03ad: Expected Obj, but got Ref
			//IL_03af: Expected Obj, but got VT
			//IL_0254: Expected I4, but got Obj
			//IL_037a: Expected Obj, but got I4
			//IL_0716: Expected I4, but got Obj
			//IL_02d8: Expected Obj, but got I4
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0a34->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0a0d->IL0026: Incompatible stack heights: 3 vs 1
			//IL_0a3f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0a18->IL0026: Incompatible stack heights: 3 vs 1
			//IL_0130->IL009d: Incompatible stack heights: 2 vs 1
			//IL_013b->IL009d: Incompatible stack heights: 2 vs 1
			//IL_05d8->IL0193: Incompatible stack types: I4 vs Obj
			//IL_04cc->IL0193: Incompatible stack types: I4 vs Obj
			//IL_0184->IL0193: Incompatible stack types: I4 vs Obj
			//IL_009d->IL009d: Incompatible stack heights: 2 vs 1
			//IL_018f->IL0193: Incompatible stack types: I4 vs Obj
			//IL_053f->IL0193: Incompatible stack types: I4 vs Obj
			//IL_06d9->IL0193: Incompatible stack types: I4 vs Obj
			//IL_05b7->IL0193: Incompatible stack types: I4 vs Obj
			//IL_04ee->IL0193: Incompatible stack heights: 2 vs 1
			//IL_05ec->IL0193: Incompatible stack types: I4 vs Obj
			//IL_030a->IL0193: Incompatible stack types: I4 vs Obj
			//IL_02a0->IL0193: Incompatible stack types: I4 vs Obj
			//IL_0644->IL0193: Incompatible stack types: I4 vs Obj
			//IL_0420->IL0193: Incompatible stack types: I4 vs Obj
			//IL_0551->IL0193: Incompatible stack types: I4 vs Obj
			//IL_051e->IL0193: Incompatible stack types: I4 vs Obj
			//IL_043e->IL0193: Incompatible stack types: I4 vs Obj
			//IL_026d->IL0193: Incompatible stack types: I4 vs Obj
			//IL_0285->IL0193: Incompatible stack types: I4 vs Obj
			//IL_039b->IL0193: Incompatible stack types: I4 vs Obj
			//IL_032b->IL0193: Incompatible stack types: I4 vs Obj
			//IL_06af->IL0193: Incompatible stack types: I4 vs Obj
			//IL_050a->IL0193: Incompatible stack heights: 2 vs 1
			//IL_0565->IL0193: Incompatible stack types: I4 vs Obj
			//IL_048b->IL0193: Incompatible stack types: I4 vs Obj
			//IL_03b9->IL0193: Incompatible stack types: I4 vs Obj
			//IL_06c1->IL0193: Incompatible stack types: I4 vs Obj
			//IL_0464->IL0193: Incompatible stack types: I4 vs Obj
			//IL_0341->IL0193: Incompatible stack types: I4 vs Obj
			//IL_04f9->IL0193: Incompatible stack heights: 2 vs 1
			//IL_0315->IL0193: Incompatible stack types: I4 vs Obj
			//IL_064f->IL0193: Incompatible stack types: I4 vs Obj
			//IL_0736->IL0193: Incompatible stack types: I4 vs Obj
			//IL_06f9->IL0193: Incompatible stack types: I4 vs Obj
			//IL_0449->IL0193: Incompatible stack types: I4 vs Obj
			//IL_03cf->IL0193: Incompatible stack types: I4 vs Obj
			//IL_03a6->IL0193: Incompatible stack types: I4 vs Obj
			//IL_0720->IL0193: Incompatible stack types: I4 vs Obj
			//IL_0626->IL0193: Incompatible stack types: I4 vs Obj
			//IL_0496->IL0193: Incompatible stack types: I4 vs Obj
			//IL_046f->IL0193: Incompatible stack types: I4 vs Obj
			//IL_0704->IL0193: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object stateMachine = 1;
			while (true)
			{
				object obj = stateMachine;
				while (true)
				{
					int num;
					switch ((int)obj)
					{
					default:
						stateMachine = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
						obj = 4;
						continue;
					case 5:
						break;
					case 2:
						return;
					case 4:
						if ((nuint)(nint)stateMachine <= (nuint)2u)
						{
							num = 1;
							if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
							{
								num = 5;
							}
							goto IL_009d;
						}
						goto IL_013b;
					case 3:
						_ = ref _003CEntityRequestAsync_003Ed__9.CheckDetailedTemplate;
						_ = ((EntitySubItemDownload)stateMachine).ResourceName;
						_ = 2;
						if (((_003CGetAuthItemsAsync_003Ed__48)_003CGetAuthItemsAsync_003Ed__48._003C_003Et__builder)._003C_003E4__this == null)
						{
							_ = 2;
						}
						continue;
					case 1:
						{
							stateMachine = ((_003CGetAuthItemsAsync_003Ed__48)this).masterType;
							obj = 0;
							if ((int)((_003CGetAuthItemsAsync_003Ed__48*)(int)_003CGetAuthItemsAsync_003Ed__48.gameVersion)->_003C_003Eu__1 == 0)
							{
								obj = 0;
							}
							continue;
						}
						IL_013b:
						if ((nint)stateMachine != 3)
						{
							num = 16;
							goto IL_009d;
						}
						goto IL_0883;
						IL_009d:
						while (true)
						{
							switch (num)
							{
							case 1:
								return;
							case 15:
								stateMachine = -1;
								DesktopAuthentication.Crc32 = -1;
								num = 8;
								continue;
							case 2:
								_ = ref DesktopAuthentication.Logger;
								((AsyncTaskMethodBuilder*)(&stateMachine))->Start(ref Unsafe.As<_003CSetSkinAsync_003Ed__29, DesktopAuthentication._003CSendMessageAsync_003Ed__29>(ref this));
								_ = 0;
								if (((DesktopAuthentication)DesktopAuthentication._client)._connected != 0)
								{
									_ = 1;
								}
								continue;
							case 14:
								goto end_IL_009d;
							case 12:
							{
								object obj2;
								switch ((int)stateMachine)
								{
								default:
									obj2 = 12;
									if (((DesktopAuthentication)(object)DesktopAuthentication._buffer)._handshake == 0)
									{
										obj2 = 16;
									}
									goto IL_0193;
								case 1:
									stateMachine = ((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this).data;
									obj2 = 45;
									goto IL_0193;
								case 0:
									goto IL_05c6;
								case 2:
									goto IL_0688;
									IL_018f:
									obj2 = stateMachine;
									goto IL_0193;
									IL_0193:
									while (true)
									{
										switch ((int)obj2)
										{
										case 5:
											return;
										case 11:
											return;
										case 13:
											return;
										case 26:
											stateMachine = -1;
											((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeSent = -1;
											obj2 = 41;
											continue;
										case 28:
											Unsafe.As<object, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeKey).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&stateMachine), ref Unsafe.As<_003CSetSkinAsync_003Ed__29, DesktopAuthentication._003CReceiveAsync_003Ed__20>(ref this));
											obj2 = 11;
											continue;
										case 10:
										case 17:
											((TcpClient)500).Close();
											GC.SuppressFinalize((object)/*Error near IL_0294: Stack underflow*/);
											stateMachine = (object)/*Error near IL_0296: Stack underflow*/;
											obj2 = 36;
											continue;
										case 9:
										case 35:
											((DesktopAuthentication)((TaskCompletionSource)stateMachine).TrySetException((Exception)((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003E1__state))._003CConnect_003Eb__19_0();
											((AsyncTaskMethodBuilder*)/*Error near IL_02f4: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_02f4: Stack underflow*/, ref *(TStateMachine*)/*Error near IL_02f4: Stack underflow*/);
											stateMachine = (object)/*Error near IL_02f6: Stack underflow*/;
											obj2 = 16;
											if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27.serverIdHash)->_003Ccts_003E5__2 == null)
											{
												obj2 = 21;
											}
											continue;
										case 33:
											((DesktopAuthentication._003CAuthentication_003Ed__27)this)._003C_003Eu__1 = (TaskAwaiter<byte[]>)default(Log);
											obj2 = 24;
											continue;
										case 45:
											Unsafe.As<object, AsyncTaskMethodBuilder<EntityItemChannel[]>>(ref DesktopAuthentication._003CAuthentication_003Ed__27.ReflectInternalAnnotation) = default;
											obj2 = 8;
											continue;
										case 23:
										case 34:
											goto IL_0365;
										case 30:
											((DesktopAuthentication._003CConnect_003Ed__19)this)._003Ccts_003E5__2 = stateMachine;
											obj2 = 6;
											if (DesktopAuthentication._003CConnect_003Ed__19.CheckAdjustableCommand == null)
											{
												obj2 = 4;
											}
											continue;
										case 19:
										case 41:
											stateMachine = ((CancellationTokenSource)(&stateMachine)).Token;
											obj2 = 30;
											continue;
										case 27:
										case 29:
											((Action)/*Error near IL_03c0: Stack underflow*/)._002Ector((object)/*Error near IL_03c0: Stack underflow*/, (nint)(&stateMachine));
											if ((int)/*Error near IL_03c5: Stack underflow*/ == 0)
											{
												obj2 = 17;
												continue;
											}
											goto case 44;
										case 16:
										{
											object obj3 = stateMachine;
											((IAsyncStateMachine)DesktopAuthentication._003CHeartbeatAsync_003Ed__25.ProcessResolver).SetStateMachine((IAsyncStateMachine)DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24.DecorateSegmentedListener());
											stateMachine = obj3;
											obj2 = 20;
											continue;
										}
										case 25:
											stateMachine = 0;
											((DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24)this)._003C_003E4__this = (DesktopAuthentication)0;
											obj2 = 15;
											if (DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24.ReflectMixedRunner == null)
											{
												obj2 = 40;
											}
											continue;
										case 44:
											((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003E1__state = 1;
											obj2 = 0;
											if (((DesktopAuthentication._003CReceiveAsync_003Ed__20)DesktopAuthentication._003CReceiveAsync_003Ed__20._003C_003Et__builder)._003C_003E4__this == null)
											{
												obj2 = 0;
											}
											continue;
										case 40:
											((DesktopAuthentication._003CReceiveAsync_003Ed__20)this)._003C_003Eu__1 = (TaskAwaiter)stateMachine;
											obj2 = 10;
											if (((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22*)(nint)DesktopAuthentication._003CReceiveAsync_003Ed__20.CheckCommonTracker)->_003C_003E1__state == 0)
											{
												obj2 = 28;
											}
											continue;
										case 31:
											goto end_IL_0193;
										case 7:
											_ = ref ((DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22)this)._003C_003Eu__1;
											((AsyncTaskMethodBuilder<EntityNetGameAddress>*)(&stateMachine))->Start(ref Unsafe.As<_003CSetSkinAsync_003Ed__29, _003CGetNetGameAddressAsync_003Ed__46>(ref this));
											_ = 5;
											if (((DesktopAuthentication._003CReceiveDataAsync_003Ed__21*)(nint)DesktopAuthentication._003CReceiveControlDataAsync_003Ed__22.DecorateBasicTag)->_003C_003E1__state == 0)
											{
												_ = 0;
											}
											continue;
										case 14:
										case 38:
											Arrays.CopyOfRange((byte[])/*Error near IL_0500: Stack underflow*/, (int)/*Error near IL_0500: Stack underflow*/, (int)(&stateMachine));
											_ = 22;
											continue;
										case 24:
											stateMachine = -1;
											((DesktopAuthentication._003CReceiveDataAsync_003Ed__21)this)._003C_003E4__this = (DesktopAuthentication)(-1);
											obj2 = 38;
											continue;
										case 2:
											((DesktopAuthentication._003CReceiveDataAsync_003Ed__21)this).buffer = (byte[])stateMachine;
											obj2 = 3;
											continue;
										case 22:
											stateMachine = ((DesktopAuthentication._003CReceiveDataAsync_003Ed__21)this)._003C_003Eu__1;
											obj2 = 4;
											continue;
										case 39:
											stateMachine = 1;
											((DesktopAuthentication._003CReceiveDataAsync_003Ed__21)this)._003Clength_003E5__2 = 1;
											obj2 = 2;
											continue;
										case 12:
											goto IL_0565;
										case 4:
											((DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23)this).sid = (ushort)(stateMachine + 1);
											obj2 = 23;
											continue;
										case 46:
											goto IL_05c6;
										case 8:
											stateMachine = -1;
											((DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23)this)._003C_003E4__this = (DesktopAuthentication)(-1);
											obj2 = 29;
											continue;
										case 36:
											if (((List<byte>)/*Error near IL_0617: Stack underflow*/).GetRange((int)/*Error near IL_0617: Stack underflow*/, (int)(&stateMachine)) != null)
											{
												obj2 = 14;
												continue;
											}
											goto case 15;
										case 15:
											stateMachine = 2;
											((DesktopAuthentication._003CSendMessageAsync_003Ed__29)this)._003C_003E4__this = (DesktopAuthentication)2;
											obj2 = 40;
											if ((int)((DesktopAuthentication._003CSendMessageAsync_003Ed__29*)(nint)DesktopAuthentication._003CSendMessageAsync_003Ed__29.data)->_003C_003Eu__1 == 0)
											{
												obj2 = 43;
											}
											continue;
										case 6:
											goto IL_064f;
										case 1:
											goto IL_0688;
										case 37:
											((DesktopAuthentication._003CSendPacketAsync_003Ed__28)this).data = (byte[])0;
											obj2 = 34;
											continue;
										case 43:
											((DesktopAuthentication._003CSendPacketAsync_003Ed__28)this)._003C_003E4__this = (DesktopAuthentication)stateMachine;
											obj2 = 7;
											continue;
										case 3:
											Unsafe.As<TaskAwaiter, AsyncTaskMethodBuilder<_00210[]>>(ref ((DesktopAuthentication._003CSendPacketAsync_003Ed__28)this)._003C_003Eu__1).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<Entities<_00210>>*)(&stateMachine), ref Unsafe.As<_003CSetSkinAsync_003Ed__29, _003CEntitiesRequestAsync_003Ed__11<_00210>>(ref this));
											obj2 = 13;
											continue;
										case 21:
											if (BitConverter.GetBytes((ushort)(&stateMachine)) != null)
											{
												obj2 = 20;
												if (((DesktopSession)(object)DesktopSession._skins)._skinTotal == 0)
												{
													obj2 = 27;
												}
												continue;
											}
											goto case 39;
										case 18:
											throw new Stream((ReadOnlyMemory<byte>)/*Error near IL_070e: Stack underflow*/, (CancellationToken)((DesktopSession)/*Error near IL_0709: Stack underflow*/).SetSkinAsync((string)/*Error near IL_0709: Stack underflow*/));
										case 20:
											((MemoryStream)(&stateMachine))._002Ector();
											if ((int)/*Error near IL_072c: Stack underflow*/ != 0)
											{
												obj2 = 19;
												continue;
											}
											goto case 25;
										case 42:
											goto end_IL_015f;
										}
										goto IL_02c4;
										IL_0365:
										if ((nint)((DesktopAuthentication._003CConnect_003Ed__19)this).authServer >= 5)
										{
											goto IL_02c4;
										}
										goto IL_0371;
										IL_02c4:
										if (DesktopAuthentication.PrepareDic != null)
										{
											((_003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed)this)._003C_003E1__state = (int)null;
											obj2 = 42;
											continue;
										}
										goto IL_02cf;
										continue;
										end_IL_0193:
										break;
									}
									goto case 1;
									IL_0688:
									stateMachine = ((DesktopAuthentication._003CSendPacketAsync_003Ed__28)this).id;
									stateMachine = 33;
									goto IL_018f;
									IL_064f:
									DesktopAuthentication._003CSendMessageAsync_003Ed__29.CheckAccessibleCalculator = 0;
									stateMachine = 37;
									goto IL_018f;
									IL_05c6:
									stateMachine = ((DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23)this).payload;
									obj2 = 12;
									goto IL_0193;
									IL_0565:
									Unsafe.As<TaskAwaiter, @null>(ref ((DesktopAuthentication._003CReceiveDataAsync_003Ed__21)this)._003C_003Eu__2) = null;
									stateMachine = 26;
									goto IL_018f;
									IL_0371:
									stateMachine = 35;
									goto IL_018f;
									IL_02cf:
									stateMachine = 18;
									goto IL_018f;
									end_IL_015f:
									break;
								}
								goto case 7;
							}
							case 7:
								new NeteaseSession((string)/*Error near IL_07a1: Stack underflow*/, (string)/*Error near IL_07a1: Stack underflow*/, (byte)(int)((DesktopSession)stateMachine).GetUserDetailAsync() != 0);
								new NeteaseSession();
								new NeteaseSession();
								((Dictionary<int, IDesktopSkin[]>)9).Clear();
								_ = _003C_003Ec._003C_003E9__15_3;
								/*Error near IL_07bc: Member reference must be method, but was: Field*/;
							case 8:
							case 11:
								_ = ref stateMachine;
								/*Error near IL_085d: Member reference must be method, but was: Field*/;
							case 6:
								goto IL_0883;
							case 13:
								((AsyncTaskMethodBuilder<EntityNetGameItem[]>*)/*Error near IL_08b1: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)(&stateMachine));
								if ((int)/*Error near IL_08b6: Stack underflow*/ != 0)
								{
									num = 11;
									continue;
								}
								goto case 9;
							case 10:
								Unsafe.As<string, AsyncTaskMethodBuilder<EntityLoginOtp>>(ref ((_003CEntitiesRequestAsync_003Ed__11<>)this).url) = default;
								num = 15;
								if ((int)((_003CEntitiesRequestAsync_003Ed__11<>*)(_003CEntitiesRequestAsync_003Ed__11<>.checkCode ? 1 : 0))->_003C_003Eu__1 == 0)
								{
									num = 0;
								}
								continue;
							case 3:
							case 5:
								num = 12;
								continue;
							case 4:
								((_003CEntityRequestAsync_003Ed__10<>)this)._003C_003E1__state = (int)stateMachine;
								num = 2;
								continue;
							case 9:
								stateMachine = 3;
								((_003CEntityRequestAsync_003Ed__10<>)this)._003C_003Et__builder = (AsyncTaskMethodBuilder<T>)3;
								num = 4;
								continue;
							case 16:
								Unsafe.Write(&((_003CEntityRequestAsync_003Ed__10<>*)(nint)((_003CEntityRequestAsync_003Ed__10<>)this)._003C_003E4__this)->body, (object)AsyncTaskMethodBuilder<EntitySkinItem>.Create());
								stateMachine = 3;
								continue;
							}
							goto end_IL_0026;
							continue;
							end_IL_009d:
							break;
						}
						goto IL_013b;
						IL_0883:
						stateMachine = _003CDownloadImageAsync_003Ed__34.DecorateSortedElement;
						num = 10;
						if ((int)((_003CEntitiesRequestAsync_003Ed__11<>*)_003CEntitiesRequestAsync_003Ed__11<>._003C_003E1__state)->_003C_003Et__builder == 0)
						{
							num = 6;
						}
						goto IL_009d;
					}
					break;
					continue;
					end_IL_0026:
					break;
				}
				((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserToken_003EP = -2;
				stateMachine = 3;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00ⴀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779103, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_2E00(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected VT, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((EqualityComparer<_00211>)/*Error near IL_0045: Stack underflow*/).Equals((_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP), (_00211?)P_0);
					_ = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP != null)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_2F00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779102, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_3000()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_3100()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_3200()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779097, new IntPtr(2737336630236L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	private object? _netGames;

	private readonly Dictionary<int, IDesktopSkin[]> _skins;

	private nint _skinTotal;

	[CompilerGenerated]
	private object? UserDetail__BackingField;

	internal static DesktopSession DecorateVisibleDecider;

	public override ILogger Logger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (ILogger)_FF00_FF00_FF00_FF00_FF00_3300();
		}
	}

	public string EncryptToken
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00戀();
		}
	}

	public string Md5Token
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_2B00();
		}
	}

	public EntityUserDetail? UserDetail
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (EntityUserDetail?)_FF00_FF00_FF00_FF00_FF00攀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00渀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DesktopSession(string userId, string token, bool startHeartbeat = true)
	{
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((DesktopAuthentication)(object)this)._003CuserToken_003EP = new EqualityComparer<_00211>();
		_ = EqualityComparer<_00210>.Default;
		int num = 0;
		if (DesktopAuthentication.Crc32 != null)
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
	[AsyncStateMachine(typeof(_003CHeartbeatAsync_003Ed__7))]
	protected override Task HeartbeatAsync()
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00圀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Dispose()
	{
		_FF00_FF00_FF00_FF00_FF00紀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CEntityRequestAsync_003Ed__9))]
	private object EntityRequestAsync(object url, object body, byte checkCode = 1)
	{
		return _FF00_FF00_FF00_FF00_FF00娀(url, body, checkCode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CEntityRequestAsync_003Ed__10<>))]
	private Task<T> EntityRequestAsync<T>(string url, object body, bool checkCode = true)
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CEntitiesRequestAsync_003Ed__11<>))]
	private Task<T[]> EntitiesRequestAsync<T>(string url, object body, bool checkCode = true)
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRequestAsync_003Ed__12<>))]
	private Task<T> RequestAsync<T>(string url, object body, bool checkCode = true) where T : EntityResponse
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRequestAsync_003Ed__13<>))]
	private Task<T> RequestAsync<T>(string url, string body, bool checkCode) where T : EntityResponse
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetNetGamesAsync_003Ed__15))]
	public Task<EntityNetGameItem[]> GetNetGamesAsync()
	{
		return _FF00_FF00_FF00_FF00_FF00ⴀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SessionContext<DesktopSession, EntityNetGameItem> GetNetGame(string gameId)
	{
		return _FF00_FF00_FF00_FF00_FF00蘀(gameId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSkinsAsync_003Ed__20))]
	public Task<PageModel<IDesktopSkin>> GetSkinsAsync(int page)
	{
		return _FF00_FF00_FF00_FF00_FF00䔀((uint)page);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSkinByIdAsync_003Ed__21))]
	public Task<EntitySkinItem?> GetSkinByIdAsync(string skinId)
	{
		return _FF00_FF00_FF00_FF00_FF00匀(skinId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSkinsByIdAsync_003Ed__22))]
	public Task<EntitySkinItem[]> GetSkinsByIdAsync(string[] skinIds)
	{
		return _FF00_FF00_FF00_FF00_FF00㜀(skinIds);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetOwnedSkinsAsync_003Ed__23))]
	public Task<PageModel<IDesktopSkin>> GetOwnedSkinsAsync(int page)
	{
		return _FF00_FF00_FF00_FF00_FF00䨀((uint)page);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSearchSkinAsync_003Ed__24))]
	public Task<PageModel<IDesktopSkin>> SearchSkinAsync(string keyword, int page = 0)
	{
		return _FF00_FF00_FF00_FF00_FF00蠀(keyword, (uint)page);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSkinImagesAsync_003Ed__25))]
	private object GetSkinImagesAsync(object skins)
	{
		return _FF00_FF00_FF00_FF00_FF00栀(skins);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetModHashListAsync_003Ed__26))]
	public Task<EntityGameModsHash> GetModHashListAsync(EnumGameType masterType, EnumGameVersion gameVersion)
	{
		return _FF00_FF00_FF00_FF00_FF00唀(masterType, gameVersion);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe EntityGameModsHash GetModHashList(EntityItemDownload[] itemDownloads)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 89, 1790779329, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779329, new IntPtr(2737336596956L), 15);
		}
		return (EntityGameModsHash)((delegate*<object, object, object>)obj)(this, itemDownloads);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetBuyItemResultAsync_003Ed__28))]
	public Task<bool> GetBuyItemResultAsync(string orderId)
	{
		return _FF00_FF00_FF00_FF00_FF00愀(orderId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetSkinAsync_003Ed__29))]
	public virtual Task<EntitySkinSetting[]> SetSkinAsync(string itemId)
	{
		return _FF00_FF00_FF00_FF00_FF00_2F00(itemId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInterLoginStartAsync_003Ed__30))]
	public virtual Task InterLoginStartAsync()
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00儀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInterLoginStopAsync_003Ed__31))]
	public virtual Task InterLoginStopAsync()
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00挀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLogoutAsync_003Ed__32))]
	public virtual Task LogoutAsync()
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00㤀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInterStartAsync_003Ed__33))]
	public virtual Task InterStartAsync(string gameId)
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00_3100(gameId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDownloadImageAsync_003Ed__34))]
	public Task<string> DownloadImageAsync(string directoryPath, string url)
	{
		return _FF00_FF00_FF00_FF00_FF00漀(directoryPath, url);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetUserDetailAsync_003Ed__39))]
	public Task<EntityUserDetail> GetUserDetailAsync()
	{
		return _FF00_FF00_FF00_FF00_FF00甀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetNicknameAsync_003Ed__40))]
	public Task SetNicknameAsync(string nickname)
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00䰀(nickname);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetGameCharactersAsync_003Ed__41))]
	public Task<EntityGameCharacter[]> GetGameCharactersAsync(EnumGameType type, string gameId = "")
	{
		return _FF00_FF00_FF00_FF00_FF00䐀(type, gameId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetItemChannelAsync_003Ed__42))]
	public Task<EntityItemChannel[]> GetItemChannelAsync(List<string> itemIdList, int channelId)
	{
		return _FF00_FF00_FF00_FF00_FF00瀀(itemIdList, (uint)channelId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetRentalGameCharactersAsync_003Ed__43))]
	public Task<EntityRentalGameCharacter[]> GetRentalGameCharactersAsync(string gameId = "")
	{
		return _FF00_FF00_FF00_FF00_FF00脀(gameId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddGameCharacterAsync_003Ed__44))]
	public Task<EntityGameCharacter> AddGameCharacterAsync(EnumGameType type, string name, string gameId = "")
	{
		return _FF00_FF00_FF00_FF00_FF00舀(type, name, gameId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddRentalGameCharacterAsync_003Ed__45))]
	public Task AddRentalGameCharacterAsync(string gameId, string name)
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00稀(gameId, name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetNetGameAddressAsync_003Ed__46))]
	public Task<EntityNetGameAddress> GetNetGameAddressAsync(string gameId)
	{
		return _FF00_FF00_FF00_FF00_FF00帀(gameId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetRentalGameAddressAsync_003Ed__47))]
	public Task<EntityRentalGameAddress> GetRentalGameAddressAsync(string gameId, string? password = null)
	{
		return _FF00_FF00_FF00_FF00_FF00䜀(gameId, password);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetAuthItemsAsync_003Ed__48))]
	public Task<EntityAuthItem> GetAuthItemsAsync(EnumGameType masterType, EnumGameVersion gameVersion)
	{
		return _FF00_FF00_FF00_FF00_FF00猀(masterType, gameVersion);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetItemDownloadAsync_003Ed__49))]
	public Task<EntityItemDownload> GetItemDownloadAsync(ulong itemId)
	{
		return _FF00_FF00_FF00_FF00_FF00簀(itemId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetItemDownloadAsync_003Ed__50))]
	public Task<EntityItemDownload[]> GetItemDownloadAsync(ulong[] itemIdList)
	{
		return _FF00_FF00_FF00_FF00_FF00欀(itemIdList);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetRentalGamesAsync_003Ed__51))]
	public Task<EntityRentalGameItem[]> GetRentalGamesAsync(string? keyword = null)
	{
		return _FF00_FF00_FF00_FF00_FF00㰀(keyword);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPurchaseItemAsync_003Ed__52))]
	public Task<EntityItemPurchase> PurchaseItemAsync(string itemId)
	{
		return _FF00_FF00_FF00_FF00_FF00眀(itemId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetNetGameDetailsAsync_003Ed__53))]
	public Task<EntityNetGameDetails> GetNetGameDetailsAsync(string gameId)
	{
		return _FF00_FF00_FF00_FF00_FF00怀(gameId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetGamePatchInfoAsync_003Ed__54))]
	public Task<EntityGameClientPatch> GetGamePatchInfoAsync(EnumGameVersion gameVersion)
	{
		return _FF00_FF00_FF00_FF00_FF00㸀(gameVersion);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetUserSkinAsync_003Ed__55))]
	public Task<EntityUserSkin[]> GetUserSkinAsync(string userId)
	{
		return _FF00_FF00_FF00_FF00_FF00䄀(userId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetUserSkinAsync_003Ed__56))]
	public Task<EntityUserSkin?> GetUserSkinAsync(string userId, EnumGameType gameType)
	{
		return _FF00_FF00_FF00_FF00_FF00㔀(userId, gameType);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetCppGameClientInfo_003Ed__57))]
	public Task<EntityCppGameClientInfo> GetCppGameClientInfo()
	{
		return _FF00_FF00_FF00_FF00_FF00一();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetServerTimeAsync_003Ed__58))]
	public Task<EntityServerTime> GetServerTimeAsync()
	{
		return _FF00_FF00_FF00_FF00_FF00缀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateCentralList()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DesktopSession DecorateStatelessRecord()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_2A00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779328, new IntPtr(2737336583436L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_2B00()
	{
		//IL_001f: Expected VT, but got Obj
		//IL_001f: Expected VT, but got Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((_003C_003Ef__AnonymousType0<, >)/*Error near IL_001f: Stack underflow*/)._002Ector((_003Corderid_003Ej__TPar)this, (_003Cbuy_type_003Ej__TPar)EqualityComparer<_00211>.Default);
		return (object)/*Error near IL_0020: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00Ⰰ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779331, new IntPtr(2737336580316L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityNetGameItem[]> _FF00_FF00_FF00_FF00_FF00ⴀ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2008, 1790779330, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779330, new IntPtr(2737336579276L), 15);
		}
		return (Task<EntityNetGameItem[]>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntitySkinSetting[]> _FF00_FF00_FF00_FF00_FF00_2E00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779341, new IntPtr(2737336606316L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntitySkinSetting[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntitySkinSetting[]> _FF00_FF00_FF00_FF00_FF00_2F00(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2010, 1790779340, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779340, new IntPtr(2737336584476L), 15);
		}
		return (Task<EntitySkinSetting[]>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_3000(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779343, new IntPtr(2737336587596L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_3100(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2012, 1790779342, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779342, new IntPtr(2737336594876L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_3200(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779337, new IntPtr(2737336602156L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_3300()
	{
		//IL_001a: Expected Obj, but got VT
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ((_003C_003Ef__AnonymousType0<, >)/*Error near IL_0019: Stack underflow*/).buy_type;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00㐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779336, new IntPtr(2737336580316L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityUserSkin> _FF00_FF00_FF00_FF00_FF00㔀(object P_0, EnumGameType P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_00eb: Expected Obj, but got Ref
		//IL_00f2: Expected Obj, but got Ref
		//IL_00f2: Expected Obj, but got Ref
		//IL_00b3: Expected Obj, but got Ref
		//IL_007a: Expected VT, but got Ref
		//IL_007f: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got Ref
		//IL_0104: Expected Obj, but got Ref
		//IL_00c5: Expected Obj, but got Ref
		//IL_00d4: Expected Obj, but got I
		//IL_00a5: Expected Obj, but got Ref
		//IL_00fc->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00bd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0093->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0118->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0073->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0123->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e4->IL0026: Incompatible stack types: I4 vs Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				((DesktopAuthentication)(&obj))._003CuserId_003EP = P_1;
				obj2 = 3;
				if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP != null)
				{
					obj2 = 5;
				}
				break;
			case 2:
				DesktopAuthentication.Crc32 = ((EqualityComparer<_00210>)/*Error near IL_007a: Stack underflow*/).Equals((_00210?)/*Error near IL_007a: Stack underflow*/, (_00210?)(&obj));
				obj2 = 1;
				if (DesktopAuthentication.TokenKey != null)
				{
					obj2 = 1;
				}
				break;
			case 6:
				_ = ref ((DesktopAuthentication)(&obj))._client;
				/*Error near IL_00a5: Member reference must be method, but was: Field*/;
			case 1:
				((DesktopAuthentication)(&obj))._buffer = (List<byte>)(object)this;
				obj2 = 4;
				break;
			case 5:
				((DesktopAuthentication)(&obj))._handshake = -1;
				obj2 = 0;
				if (((DesktopAuthentication)DesktopAuthentication._handshakeSent)._handshakeKey != null)
				{
					obj2 = 0;
				}
				break;
			default:
				((IEnumerable<byte>)Unsafe.AsPointer(ref ((DesktopAuthentication)(&obj))._encryptedToken)).Concat((IEnumerable<byte>)(&obj));
				_ = 6;
				break;
			case 4:
				((DesktopAuthentication)(&obj))._decryptChaCha = P_0;
				obj2 = 1;
				if (((DesktopAuthentication)DesktopAuthentication._handshakeTcs)._authenticationTcs == null)
				{
					obj2 = 3;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntitySkinItem[]> _FF00_FF00_FF00_FF00_FF00㘀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779339, new IntPtr(2737336586556L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntitySkinItem[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntitySkinItem[]> _FF00_FF00_FF00_FF00_FF00㜀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2018, 1790779338, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779338, new IntPtr(2737336580316L), 15);
		}
		return (Task<EntitySkinItem[]>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntitySkinItem[]> _FF00_FF00_FF00_FF00_FF00㠀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779189, new IntPtr(2737336602156L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntitySkinItem[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00㤀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2020, 1790779188, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779188, new IntPtr(2737336578236L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00㨀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779191, new IntPtr(2737336583436L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityRentalGameItem[]> _FF00_FF00_FF00_FF00_FF00㬀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779190, new IntPtr(2737336603196L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityRentalGameItem[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityRentalGameItem[]> _FF00_FF00_FF00_FF00_FF00㰀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2023, 1790779185, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779185, new IntPtr(2737336606316L), 15);
		}
		return (Task<EntityRentalGameItem[]>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityRentalGameItem[]> _FF00_FF00_FF00_FF00_FF00㴀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779184, new IntPtr(2737336599036L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityRentalGameItem[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityGameClientPatch> _FF00_FF00_FF00_FF00_FF00㸀(EnumGameVersion P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_009c: Expected Obj, but got Ref
		//IL_00ab: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I4
		//IL_0050: Expected Obj, but got Ref
		//IL_00c3: Expected Obj, but got Ref
		//IL_00d2: Expected Obj, but got I
		//IL_006e: Expected Obj, but got Ref
		//IL_0061: Expected Obj, but got Ref
		//IL_00b0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0102->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0089->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00bb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0094->IL0026: Incompatible stack types: I4 vs Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 1;
		object obj = stateMachine;
		while (true)
		{
			switch ((int)obj)
			{
			case 2:
				((DesktopAuthentication)(&stateMachine))._003CuserId_003EP = P_0;
				obj = 3;
				break;
			case 5:
				_ = ref ((DesktopAuthentication)(&stateMachine))._003CuserToken_003EP;
				return (Task<EntityGameClientPatch>)(object)EqualityComparer<_00210>.Default;
			case 4:
				Unsafe.As<object, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication)(&stateMachine))._003CserverId_003EP).Start(ref *(DesktopAuthentication._003CAuthentication_003Ed__27*)(&stateMachine));
				obj = 3;
				if (DesktopAuthentication.TokenKey == null)
				{
					obj = 5;
				}
				break;
			default:
				((DesktopAuthentication)(&stateMachine))._client = this;
				obj = 1;
				if (((DesktopAuthentication)DesktopAuthentication._connected)._buffer != null)
				{
					obj = 2;
				}
				break;
			case 3:
				((DesktopAuthentication)(&stateMachine))._handshake = -1;
				obj = 3;
				if (((DesktopAuthentication)DesktopAuthentication._handshakeSent)._handshakeKey == null)
				{
					obj = 4;
				}
				break;
			case 1:
				((AsyncTaskMethodBuilder*)/*Error near IL_00e9: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)(&stateMachine));
				((DesktopAuthentication)/*Error near IL_00ee: Stack underflow*/)._encryptChaCha = (object)/*Error near IL_00ee: Stack underflow*/;
				obj = 0;
				if (((DesktopAuthentication)DesktopAuthentication._decryptChaCha)._handshakeTcs == null)
				{
					obj = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityGameClientPatch> _FF00_FF00_FF00_FF00_FF00㼀(EnumGameVersion P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779187, new IntPtr(2737336605276L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityGameClientPatch>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityUserSkin[]> _FF00_FF00_FF00_FF00_FF00䀀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779186, new IntPtr(2737336595916L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityUserSkin[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityUserSkin[]> _FF00_FF00_FF00_FF00_FF00䄀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2028, 1790779197, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779197, new IntPtr(2737336588636L), 15);
		}
		return (Task<EntityUserSkin[]>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<Entities<EntityNetGameItem>> _FF00_FF00_FF00_FF00_FF00䈀(uint P_0)
	{
		//IL_001e: Expected Obj, but got I4
		//IL_001f: Expected Obj, but got VT
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Task<Entities<EntityNetGameItem>>)((_003C_003Ef__AnonymousType0<, >)(P_0 * 50)).buy_type;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<Entities<EntityNetGameItem>> _FF00_FF00_FF00_FF00_FF00䌀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779196, new IntPtr(2737336605276L), 15))(null, 0, new IntPtr(0L));
		return (Task<Entities<EntityNetGameItem>>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityGameCharacter[]> _FF00_FF00_FF00_FF00_FF00䐀(EnumGameType P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_00a1: Expected Obj, but got Ref
		//IL_00b7: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got Ref
		//IL_00ce: Expected Obj, but got Ref
		//IL_0054: Expected Obj, but got Ref
		//IL_0102: Expected Obj, but got Ref
		//IL_007b: Expected Obj, but got Ref
		//IL_0119: Expected Obj, but got I4
		//IL_0119: Expected Obj, but got Ref
		//IL_0123: Expected native int or pointer, but got Obj
		//IL_00bc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0111->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_012d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00fb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0073->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0138->IL0026: Incompatible stack types: I4 vs Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 4;
		object obj = stateMachine;
		while (true)
		{
			switch ((int)obj)
			{
			case 3:
				((DesktopAuthentication)(&stateMachine))._003CuserId_003EP = this;
				obj = 0;
				if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP == null)
				{
					obj = 1;
				}
				break;
			case 5:
				((DesktopAuthentication)(&stateMachine))._003CserverId_003EP = P_1;
				obj = 2;
				if (DesktopAuthentication.Logger != null)
				{
					obj = 6;
				}
				break;
			default:
				((AsyncTaskMethodBuilder*)/*Error near IL_00a8: Stack underflow*/)->AwaitUnsafeOnCompleted(ref Unsafe.As<byte[], TaskAwaiter>(ref DesktopAuthentication.TokenKey), ref *(DesktopAuthentication._003CAuthentication_003Ed__27*)(&stateMachine));
				obj = 2;
				if (((DesktopAuthentication)DesktopAuthentication._connected)._buffer == null)
				{
					obj = 2;
				}
				break;
			case 2:
				return (Task<EntityGameCharacter[]>)Unsafe.As<nint, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication)(&stateMachine))._handshake).Task;
			case 1:
				((DesktopAuthentication)(&stateMachine))._handshakeKey = P_0;
				obj = 5;
				if (((DesktopAuthentication)DesktopAuthentication._encryptedToken)._encryptChaCha != null)
				{
					obj = 0;
				}
				break;
			case 4:
				GC.SuppressFinalize((object)(&stateMachine));
				((DesktopAuthentication)/*Error near IL_0107: Stack underflow*/)._handshakeTcs = (object?)/*Error near IL_0107: Stack underflow*/;
				obj = 3;
				break;
			case 6:
				((DesktopAuthentication)(&stateMachine))._authenticationTcs = -1;
				obj = 0;
				if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication.PrepareDic)->_003C_003E1__state != 0)
				{
					obj = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<PageModel<IDesktopSkin>> _FF00_FF00_FF00_FF00_FF00䔀(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_007d: Expected Obj, but got I4
		//IL_007d: Expected Obj, but got Ref
		//IL_0107: Expected Obj, but got Ref
		//IL_010c: Expected VT, but got Ref
		//IL_00e1: Expected Obj, but got Ref
		//IL_008f: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got Ref
		//IL_004f: Expected Obj, but got Ref
		//IL_0087->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0100->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ae->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0075->IL0026: Incompatible stack types: I4 vs Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 3;
		object obj = stateMachine;
		while (true)
		{
			switch ((int)obj)
			{
			case 5:
				Unsafe.As<object, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication)(&stateMachine))._003CuserId_003EP).Start(ref *(DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23*)(&stateMachine));
				obj = 1;
				if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP != null)
				{
					obj = 1;
				}
				break;
			default:
				DesktopAuthentication.Crc32 = -1;
				obj = 5;
				break;
			case 4:
				DesktopAuthentication.Logger = P_0;
				obj = 0;
				if (((DesktopAuthentication)(object)DesktopAuthentication.TokenKey)._client != null)
				{
					obj = 0;
				}
				break;
			case 3:
				_ = ref stateMachine;
				/*Error near IL_00b0: Member reference must be method, but was: Field*/;
			case 2:
				((DesktopAuthentication)(&stateMachine))._handshakeKey = this;
				obj = 4;
				if (((DesktopAuthentication)DesktopAuthentication._encryptedToken)._encryptChaCha == null)
				{
					obj = 4;
				}
				break;
			case 1:
				RuntimeHelpers.InitializeArray((Array)/*Error near IL_010c: Stack underflow*/, (RuntimeFieldHandle)Unsafe.AsPointer(ref ((DesktopAuthentication)(&stateMachine))._decryptChaCha));
				return (Task<PageModel<IDesktopSkin>>)/*Error near IL_010d: Stack underflow*/;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<PageModel<IDesktopSkin>> _FF00_FF00_FF00_FF00_FF00䘀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779199, new IntPtr(2737336583436L), 15))(null, 0, new IntPtr(0L));
		return (Task<PageModel<IDesktopSkin>>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityRentalGameAddress> _FF00_FF00_FF00_FF00_FF00䜀(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005a: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2034, 1790779198, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 3, 1790779198, new IntPtr(2737336595916L), 15);
		}
		return (Task<EntityRentalGameAddress>)((delegate*<object, object, object, object>)obj)(this, P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityRentalGameAddress> _FF00_FF00_FF00_FF00_FF00䠀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779193, new IntPtr(2737336597996L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityRentalGameAddress>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<PageModel<IDesktopSkin>> _FF00_FF00_FF00_FF00_FF00䤀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779192, new IntPtr(2737336574076L), 15))(null, 0, new IntPtr(0L));
		return (Task<PageModel<IDesktopSkin>>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<PageModel<IDesktopSkin>> _FF00_FF00_FF00_FF00_FF00䨀(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00ce: Expected Obj, but got Ref
		//IL_00d4: Expected Obj, but got VT
		//IL_00a1: Expected Obj, but got Ref
		//IL_00dc: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got Ref
		//IL_00ee: Expected Obj, but got I4
		//IL_00ee: Expected Obj, but got Ref
		//IL_007b: Expected Obj, but got Ref
		//IL_0054: Expected Obj, but got Ref
		//IL_00bc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0102->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0073->IL0026: Incompatible stack types: I4 vs Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 5;
		object obj = stateMachine;
		while (true)
		{
			switch ((int)obj)
			{
			case 5:
				((DesktopAuthentication)(&stateMachine))._003CuserToken_003EP = EqualityComparer<_00211>.Default;
				obj = 4;
				if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
				{
					obj = 4;
				}
				break;
			case 4:
				DesktopAuthentication.Crc32 = this;
				obj = 2;
				if (DesktopAuthentication.TokenKey != null)
				{
					obj = 2;
				}
				break;
			case 1:
				((AsyncTaskMethodBuilder*)/*Error near IL_00a8: Stack underflow*/)->AwaitUnsafeOnCompleted(ref Unsafe.As<object, TaskAwaiter<byte[]>>(ref ((DesktopAuthentication)(&stateMachine))._client), ref *(DesktopAuthentication._003CAuthentication_003Ed__27*)(&stateMachine));
				obj = 0;
				if (((DesktopAuthentication)(object)DesktopAuthentication._buffer)._handshake == 0)
				{
					obj = 0;
				}
				break;
			default:
				_ = ref ((DesktopAuthentication)(&stateMachine))._handshakeSent;
				return (Task<PageModel<IDesktopSkin>>)AsyncTaskMethodBuilder.Create();
			case 2:
				((DesktopAuthentication)(&stateMachine))._encryptedToken = P_0;
				obj = 3;
				break;
			case 3:
				((DesktopAuthentication)(&stateMachine))._encryptChaCha = -1;
				obj = 1;
				if (((DesktopAuthentication)DesktopAuthentication._decryptChaCha)._handshakeTcs == null)
				{
					obj = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00䬀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779195, new IntPtr(2737336583436L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00䰀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2039, 1790779194, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779194, new IntPtr(2737336597996L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00䴀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779173, new IntPtr(2737336602156L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityCppGameClientInfo> _FF00_FF00_FF00_FF00_FF00一()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2041, 1790779172, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779172, new IntPtr(2737336583436L), 15);
		}
		return (Task<EntityCppGameClientInfo>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityCppGameClientInfo> _FF00_FF00_FF00_FF00_FF00伀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779175, new IntPtr(2737336576156L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityCppGameClientInfo>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00倀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0073: Expected I4, but got Obj
		//IL_015f: Expected Ref, but got VT
		//IL_016c: Expected Obj, but got VT
		//IL_0174: Expected VT, but got Obj
		//IL_0174: Expected Obj, but got VT
		//IL_0186: Expected Obj, but got VT
		//IL_018b: Expected Obj, but got VT
		//IL_018b: Expected Obj, but got VT
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_025c: Expected Obj, but got I4
		//IL_0198: Expected Obj, but got I4
		//IL_00d0: Expected VT, but got Obj
		//IL_00d2: Expected Obj, but got I4
		//IL_0210: Expected Obj, but got I4
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		//IL_01b7: Expected native int or pointer, but got Obj
		//IL_0195->IL0026: Incompatible stack heights: 3 vs 1
		//IL_014b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0133->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0266->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01fd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01a2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00dc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00aa->IL0078: Incompatible stack heights: 1 vs 0
		//IL_01dd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_024e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01c1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0126->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0102->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00be->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0259->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01cc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c9->IL0026: Incompatible stack heights: 2 vs 1
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 7;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 5:
				obj++;
				obj2 = 3;
				if (((DesktopAuthentication)DesktopAuthentication._003CuserId_003EP)._003CuserToken_003EP != null)
				{
					obj2 = 1;
				}
				break;
			case 15:
				if ((nint)EqualityComparer<_00210>.Default == 3)
				{
					_ = 12;
					if (DesktopAuthentication.Crc32 == null)
					{
						_ = 4;
					}
					break;
				}
				goto case 5;
			case 12:
				obj = ((EqualityComparer<_00211>)/*Error near IL_00d0: Stack underflow*/).GetHashCode((_00211)obj);
				obj2 = 10;
				break;
			case 7:
				obj = new object();
				obj2 = 0;
				if (((DesktopAuthentication)DesktopAuthentication._client)._connected == 0)
				{
					obj2 = 6;
				}
				break;
			case 3:
			case 11:
				if ((nint)obj >= ((Array)obj).Length)
				{
					obj2 = 14;
					break;
				}
				goto case 16;
			case 6:
				obj = P_0;
				obj2 = 8;
				break;
			case 4:
				((TcpClient)obj)._002Ector();
				((List<byte>)/*Error near IL_013f: Stack underflow*/)._002Ector();
				obj = (object)/*Error near IL_0141: Stack underflow*/;
				obj2 = 2;
				break;
			case 2:
			{
				AsyncTaskMethodBuilder asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)new AsyncTaskMethodBuilder();
				((AsyncTaskMethodBuilder*)obj)->Start<TStateMachine>(ref *(TStateMachine*)AsyncTaskMethodBuilder.Create());
				((TcpClient)obj).Close();
				GC.SuppressFinalize(asyncTaskMethodBuilder);
				RuntimeHelpers.InitializeArray((Array)asyncTaskMethodBuilder, (RuntimeFieldHandle)obj);
				((TimeoutException)asyncTaskMethodBuilder)._002Ector((string?)(object)((ILogger)obj).Category((string)(object)Log.Logger));
				((TaskCompletionSource)asyncTaskMethodBuilder).TrySetException((Exception)asyncTaskMethodBuilder);
				_ = 17;
				break;
			}
			case 10:
				obj = 0;
				obj2 = 13;
				break;
			case 1:
			case 13:
				if ((nint)obj < ((Array)obj).Length)
				{
					obj2 = 0;
					if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication._003CAuthentication_003Ed__27._003C_003E4__this)->modHashList != null)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 5;
			case 16:
				obj = ((object[])obj)[obj];
				obj2 = 15;
				break;
			default:
				obj = ((object[])obj)[obj];
				obj2 = 4;
				break;
			case 14:
				new TaskAwaiter();
				return ((TaskAwaiter<byte[]>*)((TaskAwaiter<byte[]>*)obj)->GetResult())->IsCompleted;
			case 17:
				obj++;
				obj2 = 1;
				if ((int)((DesktopAuthentication._003CConnect_003Ed__19*)DesktopAuthentication._003CConnect_003Ed__19._003C_003E1__state)->_003C_003Et__builder != 0)
				{
					obj2 = 0;
				}
				break;
			case 8:
				obj = 0;
				obj2 = 11;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00儀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2044, 1790779174, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779174, new IntPtr(2737336576156L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00刀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779169, new IntPtr(2737336599036L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntitySkinItem> _FF00_FF00_FF00_FF00_FF00匀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2046, 1790779168, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779168, new IntPtr(2737336587596L), 15);
		}
		return (Task<EntitySkinItem>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityGameModsHash> _FF00_FF00_FF00_FF00_FF00吀(EnumGameType P_0, EnumGameVersion P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779171, new IntPtr(2737336586556L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityGameModsHash>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityGameModsHash> _FF00_FF00_FF00_FF00_FF00唀(EnumGameType P_0, EnumGameVersion P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_00c4: Expected Obj, but got Ref
		//IL_0061: Expected Obj, but got Ref
		//IL_0099: Expected Obj, but got Ref
		//IL_00ad: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got Ref
		//IL_0104: Expected Obj, but got I4
		//IL_0104: Expected Obj, but got Ref
		//IL_0053: Expected Obj, but got Ref
		//IL_0058: Expected VT, but got Ref
		//IL_0059: Expected Obj, but got I4
		//IL_00f2: Expected Obj, but got I4
		//IL_00f2: Expected Obj, but got Ref
		//IL_00df->IL0026: Incompatible stack heights: 4 vs 1
		//IL_006b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0087->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00fc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ea->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00bd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0026: Incompatible stack types: I4 vs Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 5:
				return (Task<EntityGameModsHash>)((EqualityComparer<_00211>)/*Error near IL_0058: Stack underflow*/).Equals((_00211?)/*Error near IL_0058: Stack underflow*/, (_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)(&obj))._003CuserId_003EP));
			case 1:
				((DesktopAuthentication)(&obj))._003CgameVersion_003EP = this;
				obj2 = 4;
				continue;
			case 3:
				((DesktopAuthentication)(&obj))._003CserverId_003EP = -1;
				obj2 = 0;
				if (DesktopAuthentication.Logger == null)
				{
					obj2 = 0;
				}
				continue;
			case 2:
				((DesktopAuthentication)/*Error near IL_009e: Stack underflow*/)._client = ((object)(&obj)).ToString();
				obj2 = 1;
				if (((DesktopAuthentication)DesktopAuthentication._connected)._buffer == null)
				{
					obj2 = 0;
				}
				continue;
			case 6:
				((DesktopAuthentication)(&obj))._encryptChaCha = P_1;
				obj2 = 3;
				continue;
			case 4:
				((DesktopAuthentication)(&obj))._decryptChaCha = P_0;
				obj2 = 6;
				continue;
			}
			_ = ref ((DesktopAuthentication)(&obj))._handshake;
			_ = ref obj;
			Array.Empty<byte>();
			_ = 1;
			if (((DesktopAuthentication)DesktopAuthentication._handshakeKey)._encryptedToken == null)
			{
				_ = 5;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityGameModsHash> _FF00_FF00_FF00_FF00_FF00嘀(EnumGameType P_0, EnumGameVersion P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779170, new IntPtr(2737336586556L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityGameModsHash>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe object _FF00_FF00_FF00_FF00_FF00圀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2050, 1790779181, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779181, new IntPtr(2737336605276L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe object _FF00_FF00_FF00_FF00_FF00堀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779180, new IntPtr(2737336586556L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00夀(object P_0, object P_1, byte P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779183, new IntPtr(2737336586556L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00娀(object P_0, object P_1, byte P_2)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004b: Expected I4, but got Obj
		//IL_012f: Expected Obj, but got I4
		//IL_012f: Expected Obj, but got Ref
		//IL_00b7: Expected Obj, but got Ref
		//IL_007f: Expected Obj, but got Ref
		//IL_0108: Expected Obj, but got Ref
		//IL_00c4: Expected Obj, but got Ref
		//IL_00da: Expected Obj, but got Ref
		//IL_0058: Expected Obj, but got I4
		//IL_0058: Expected Obj, but got Ref
		//IL_0091: Expected Obj, but got Ref
		//IL_0139->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0089->IL0026: Incompatible stack types: I4 vs Obj
		//IL_011c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0127->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0100->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0077->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b0->IL0026: Incompatible stack types: I4 vs Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 4;
		object obj = stateMachine;
		while (true)
		{
			switch ((int)obj)
			{
			case 6:
				((DesktopAuthentication)(&stateMachine))._003CuserId_003EP = P_2;
				obj = 0;
				if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP != null)
				{
					obj = 0;
				}
				break;
			case 2:
				((DesktopAuthentication)(&stateMachine))._003CserverId_003EP = P_1;
				obj = 6;
				break;
			case 7:
				DesktopAuthentication.Crc32 = P_0;
				obj = 2;
				if (DesktopAuthentication.TokenKey == null)
				{
					obj = 2;
				}
				break;
			case 1:
				_ = ref ((DesktopAuthentication)(&stateMachine))._client;
				/*Error near IL_00b7: Member reference must be method, but was: Field*/;
			case 4:
				((TcpClient)(&stateMachine))._002Ector();
				((DesktopAuthentication)/*Error near IL_00c9: Stack underflow*/)._handshake = (nint)/*Error near IL_00c9: Stack underflow*/;
				obj = 3;
				break;
			case 5:
				((AsyncTaskMethodBuilder*)/*Error near IL_00e1: Stack underflow*/)->AwaitUnsafeOnCompleted(ref Unsafe.As<nint, TaskAwaiter>(ref ((DesktopAuthentication)(&stateMachine))._handshakeSent), ref *(DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24*)(&stateMachine));
				obj = 0;
				if (((DesktopAuthentication)DesktopAuthentication._encryptedToken)._encryptChaCha == null)
				{
					obj = 1;
				}
				break;
			case 3:
				((DesktopAuthentication)(&stateMachine))._decryptChaCha = this;
				obj = 3;
				if (((DesktopAuthentication)DesktopAuthentication._handshakeTcs)._authenticationTcs != null)
				{
					obj = 7;
				}
				break;
			default:
				DesktopAuthentication.PrepareDic = (DesktopAuthentication)(-1);
				obj = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00嬀(object P_0, object P_1, byte P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779182, new IntPtr(2737336586556L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00尀()
	{
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityNetGameAddress> _FF00_FF00_FF00_FF00_FF00崀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779177, new IntPtr(2737336577196L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityNetGameAddress>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityNetGameAddress> _FF00_FF00_FF00_FF00_FF00帀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2057, 1790779176, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779176, new IntPtr(2737336599036L), 15);
		}
		return (Task<EntityNetGameAddress>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityNetGameAddress> _FF00_FF00_FF00_FF00_FF00开(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779179, new IntPtr(2737336586556L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityNetGameAddress>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityNetGameDetails> _FF00_FF00_FF00_FF00_FF00怀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2059, 1790779178, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779178, new IntPtr(2737336600076L), 15);
		}
		return (Task<EntityNetGameDetails>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<bool> _FF00_FF00_FF00_FF00_FF00愀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2060, 1790779157, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779157, new IntPtr(2737336601116L), 15);
		}
		return (Task<bool>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00戀()
	{
		//IL_001f: Expected VT, but got Obj
		//IL_001f: Expected VT, but got Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((_003C_003Ef__AnonymousType0<, >)/*Error near IL_001f: Stack underflow*/)._002Ector((_003Corderid_003Ej__TPar)this, (_003Cbuy_type_003Ej__TPar)EqualityComparer<_00211>.Default);
		return (object)/*Error near IL_0020: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00挀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2062, 1790779156, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779156, new IntPtr(2737336602156L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00搀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779159, new IntPtr(2737336586556L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00攀()
	{
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ((DesktopAuthentication)(object)this)._003CuserId_003EP;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00昀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779158, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<Entities<EntityNetGameItem>> _FF00_FF00_FF00_FF00_FF00最(uint P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00e0: Expected Obj, but got Ref
		//IL_004f: Expected Obj, but got Ref
		//IL_00ba: Expected Obj, but got Ref
		//IL_00c9: Expected Obj, but got I
		//IL_007c: Expected VT, but got Ref
		//IL_0081: Expected Obj, but got I4
		//IL_00ee: Expected Obj, but got I4
		//IL_00ee: Expected Obj, but got Ref
		//IL_0093: Expected Obj, but got I4
		//IL_0093: Expected Obj, but got Ref
		//IL_006a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ce->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0075->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b2->IL0026: Incompatible stack types: I4 vs Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 3;
		object obj = stateMachine;
		while (true)
		{
			switch ((int)obj)
			{
			case 1:
				Unsafe.As<object, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication)(&stateMachine))._003CuserId_003EP).Start(ref *(DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23*)(&stateMachine));
				obj = 0;
				if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP != null)
				{
					obj = 0;
				}
				break;
			case 3:
				DesktopAuthentication.Logger = ((EqualityComparer<_00210>)/*Error near IL_007c: Stack underflow*/).GetHashCode((_00210)(&stateMachine));
				obj = 2;
				break;
			case 5:
				DesktopAuthentication.TokenKey = (byte[])(-1);
				obj = 1;
				if (((DesktopAuthentication)DesktopAuthentication._client)._connected != 0)
				{
					obj = 1;
				}
				break;
			case 2:
				((DesktopAuthentication)(&stateMachine))._buffer = (List<byte>)(object)this;
				obj = 2;
				if (((DesktopAuthentication)DesktopAuthentication._handshake)._handshakeSent != 0)
				{
					obj = 4;
				}
				break;
			default:
				((AsyncTaskMethodBuilder*)/*Error near IL_00e5: Stack underflow*/)->Start<TStateMachine>(ref Unsafe.As<object, TStateMachine>(ref ((DesktopAuthentication)(&stateMachine))._handshakeKey));
				return (Task<Entities<EntityNetGameItem>>)/*Error near IL_00e6: Stack underflow*/;
			case 4:
				((DesktopAuthentication)(&stateMachine))._encryptChaCha = P_0;
				obj = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00栀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2067, 1790779153, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779153, new IntPtr(2737336603196L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00椀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779152, new IntPtr(2737336586556L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityItemDownload[]> _FF00_FF00_FF00_FF00_FF00樀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779155, new IntPtr(2737336577196L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityItemDownload[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityItemDownload[]> _FF00_FF00_FF00_FF00_FF00欀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2070, 1790779154, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779154, new IntPtr(2737336574076L), 15);
		}
		return (Task<EntityItemDownload[]>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00氀()
	{
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return DesktopAuthentication._003CuserId_003EP;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00洀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779165, new IntPtr(2737336607356L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00渀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				((DesktopAuthentication)(object)this)._003CuserId_003EP = P_0;
				obj2 = 0;
				if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP != null)
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
	internal unsafe Task<string> _FF00_FF00_FF00_FF00_FF00漀(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005a: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2074, 1790779164, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 3, 1790779164, new IntPtr(2737336586556L), 15);
		}
		return (Task<string>)((delegate*<object, object, object, object>)obj)(this, P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityItemChannel[]> _FF00_FF00_FF00_FF00_FF00瀀(List<string> P_0, uint P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_0054: Expected Obj, but got Ref
		//IL_008c: Expected Obj, but got Ref
		//IL_00e0: Expected Obj, but got Ref
		//IL_00e6: Expected Obj, but got VT
		//IL_00ba: Expected I, but got Obj
		//IL_00ba: Expected Obj, but got Ref
		//IL_0066: Expected Obj, but got I4
		//IL_0066: Expected Obj, but got Ref
		//IL_0119: Expected Obj, but got I4
		//IL_0119: Expected Obj, but got Ref
		//IL_0123: Expected native int or pointer, but got Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ce->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0106->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_012d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0111->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0085->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0138->IL0026: Incompatible stack types: I4 vs Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 4;
		object obj = stateMachine;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				((DesktopAuthentication)(&stateMachine))._003CuserId_003EP = P_0;
				obj = 5;
				break;
			case 5:
				((DesktopAuthentication)(&stateMachine))._003CuserToken_003EP = P_1;
				obj = 6;
				if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
				{
					obj = 5;
				}
				break;
			case 1:
				Unsafe.As<object, AsyncTaskMethodBuilder>(ref DesktopAuthentication.Crc32).Start(ref *(DesktopAuthentication._003CSendPacketAsync_003Ed__28*)(&stateMachine));
				obj = 2;
				if (((DesktopAuthentication)(object)DesktopAuthentication.TokenKey)._client == null)
				{
					obj = 2;
				}
				break;
			case 3:
				((DesktopAuthentication)(&stateMachine))._connected = (nint)this;
				obj = 0;
				if (((DesktopAuthentication)(object)DesktopAuthentication._buffer)._handshake != 0)
				{
					obj = 0;
				}
				break;
			case 2:
				_ = ref ((DesktopAuthentication)(&stateMachine))._handshakeSent;
				return (Task<EntityItemChannel[]>)AsyncTaskMethodBuilder.Create();
			case 4:
				((AsyncTaskMethodBuilder*)/*Error near IL_00ed: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)(&stateMachine));
				((DesktopAuthentication)/*Error near IL_00f2: Stack underflow*/)._encryptChaCha = (object)/*Error near IL_00f2: Stack underflow*/;
				obj = 1;
				if (((DesktopAuthentication)DesktopAuthentication._decryptChaCha)._handshakeTcs != null)
				{
					obj = 3;
				}
				break;
			case 6:
				((DesktopAuthentication)(&stateMachine))._authenticationTcs = -1;
				obj = 1;
				if (((DesktopAuthentication._003CAuthentication_003Ed__27*)(nint)DesktopAuthentication.PrepareDic)->_003C_003E1__state == 0)
				{
					obj = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityItemChannel[]> _FF00_FF00_FF00_FF00_FF00焀(List<string> P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779167, new IntPtr(2737336607356L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityItemChannel[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityAuthItem> _FF00_FF00_FF00_FF00_FF00爀(EnumGameType P_0, EnumGameVersion P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779166, new IntPtr(2737336607356L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityAuthItem>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityAuthItem> _FF00_FF00_FF00_FF00_FF00猀(EnumGameType P_0, EnumGameVersion P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_00af: Expected Obj, but got Ref
		//IL_0088: Expected Obj, but got Ref
		//IL_0091: Expected Obj, but got I4
		//IL_00c7: Expected Obj, but got Ref
		//IL_00db: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got Ref
		//IL_007a: Expected Obj, but got Ref
		//IL_007f: Expected VT, but got Ref
		//IL_0080: Expected Obj, but got I4
		//IL_009e: Expected Obj, but got I4
		//IL_009e: Expected Obj, but got Ref
		//IL_00f3: Expected Obj, but got I4
		//IL_00f3: Expected Obj, but got Ref
		//IL_00c0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0107->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00eb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0073->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0112->IL0026: Incompatible stack types: I4 vs Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 2;
		while (true)
		{
			object obj = stateMachine;
			while (true)
			{
				switch ((int)obj)
				{
				case 3:
					((DesktopAuthentication)(&stateMachine))._003CuserId_003EP = -1;
					obj = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP != null)
					{
						obj = 0;
					}
					continue;
				case 4:
					return (Task<EntityAuthItem>)((EqualityComparer<_00210>)/*Error near IL_007f: Stack underflow*/).GetHashCode((_00210)Unsafe.AsPointer(ref ((DesktopAuthentication)(&stateMachine))._003CserverId_003EP));
				case 1:
					break;
				case 5:
					DesktopAuthentication.TokenKey = (byte[])P_1;
					obj = 3;
					continue;
				default:
					((AsyncTaskMethodBuilder*)/*Error near IL_00b6: Stack underflow*/)->AwaitUnsafeOnCompleted(ref Unsafe.As<object, TaskAwaiter<byte[]>>(ref ((DesktopAuthentication)(&stateMachine))._client), ref *(DesktopAuthentication._003CAuthentication_003Ed__27*)(&stateMachine));
					obj = 4;
					continue;
				case 2:
					((TcpClient)(&stateMachine))._002Ector();
					((DesktopAuthentication)/*Error near IL_00cc: Stack underflow*/)._handshake = (nint)/*Error near IL_00cc: Stack underflow*/;
					obj = 1;
					if (((DesktopAuthentication)DesktopAuthentication._handshakeSent)._handshakeKey != null)
					{
						obj = 1;
					}
					continue;
				case 6:
					((DesktopAuthentication)(&stateMachine))._encryptedToken = P_0;
					obj = 4;
					if (((DesktopAuthentication)DesktopAuthentication._encryptChaCha)._decryptChaCha == null)
					{
						obj = 5;
					}
					continue;
				}
				break;
			}
			DesktopAuthentication.Logger = this;
			stateMachine = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityUserDetail> _FF00_FF00_FF00_FF00_FF00琀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779161, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityUserDetail>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityUserDetail> _FF00_FF00_FF00_FF00_FF00甀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2080, 1790779160, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779160, new IntPtr(2737336607356L), 15);
		}
		return (Task<EntityUserDetail>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityUserDetail> _FF00_FF00_FF00_FF00_FF00瘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779163, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityUserDetail>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityItemPurchase> _FF00_FF00_FF00_FF00_FF00眀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2082, 1790779162, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779162, new IntPtr(2737336609436L), 15);
		}
		return (Task<EntityItemPurchase>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityItemPurchase> _FF00_FF00_FF00_FF00_FF00砀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779141, new IntPtr(2737336608396L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityItemPurchase>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00礀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779140, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00稀(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005a: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2085, 1790779143, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 3, 1790779143, new IntPtr(2737336589676L), 15);
		}
		return ((delegate*<object, object, object, object>)obj)(this, P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00笀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779142, new IntPtr(2737336608396L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityItemDownload> _FF00_FF00_FF00_FF00_FF00簀(ulong P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0103: Expected Obj, but got I8
		//IL_0103: Expected Obj, but got Ref
		//IL_00ca: Expected Obj, but got Ref
		//IL_004f: Expected Obj, but got Ref
		//IL_007d: Expected Obj, but got Ref
		//IL_00dc: Expected Obj, but got VT
		//IL_00dc: Expected Obj, but got Ref
		//IL_00a4: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got Ref
		//IL_00b3: Expected Obj, but got I
		//IL_010d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0091->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0075->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00fb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c3->IL0026: Incompatible stack types: I4 vs Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 4;
		object obj = stateMachine;
		while (true)
		{
			switch ((int)obj)
			{
			case 2:
				Unsafe.As<object, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication)(&stateMachine))._003CuserId_003EP).Start(ref *(DesktopAuthentication._003CRemoteCallBackAsync_003Ed__23*)(&stateMachine));
				obj = 1;
				if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
				{
					obj = 1;
				}
				break;
			case 3:
				DesktopAuthentication.Crc32 = this;
				obj = 0;
				if (DesktopAuthentication.TokenKey == null)
				{
					obj = 0;
				}
				break;
			case 5:
				((DesktopAuthentication)(&stateMachine))._client = -1;
				obj = 1;
				if (((DesktopAuthentication)DesktopAuthentication._connected)._buffer != null)
				{
					obj = 2;
				}
				break;
			case 1:
				return (Task<EntityItemDownload>)Unsafe.As<nint, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication)(&stateMachine))._handshake).Task;
			case 4:
				((DesktopAuthentication)(&stateMachine))._encryptedToken = AsyncTaskMethodBuilder.Create();
				obj = 3;
				if (((DesktopAuthentication)DesktopAuthentication._encryptChaCha)._decryptChaCha == null)
				{
					obj = 3;
				}
				break;
			default:
				((DesktopAuthentication)(&stateMachine))._handshakeTcs = P_0;
				obj = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00紀()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_006c: Expected VT, but got Obj
		//IL_0081: Expected VT, but got Obj
		//IL_0076->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0095->IL0026: Incompatible stack heights: 2 vs 1
		//IL_005b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a0->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0066->IL0026: Incompatible stack types: I4 vs Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				((DesktopAuthentication)(object)this)._003CuserId_003EP = null;
				obj2 = 1;
				if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP == null)
				{
					obj2 = 1;
				}
				break;
			default:
				((EqualityComparer<_00210>)/*Error near IL_006c: Stack underflow*/).Equals((_00210?)/*Error near IL_006c: Stack underflow*/, (_00210?)this);
				_ = 3;
				break;
			case 1:
				((EqualityComparer<_00211>)/*Error near IL_0081: Stack underflow*/).GetHashCode((_00211)DesktopAuthentication.Crc32);
				_ = 0;
				if (((DesktopAuthentication)(object)DesktopAuthentication.TokenKey)._client == null)
				{
					_ = 0;
				}
				break;
			case 3:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityServerTime> _FF00_FF00_FF00_FF00_FF00縀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779137, new IntPtr(2737336608396L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityServerTime>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityServerTime> _FF00_FF00_FF00_FF00_FF00缀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2090, 1790779136, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779136, new IntPtr(2737336608396L), 15);
		}
		return (Task<EntityServerTime>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityServerTime> _FF00_FF00_FF00_FF00_FF00耀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779139, new IntPtr(2737336577196L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityServerTime>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityRentalGameCharacter[]> _FF00_FF00_FF00_FF00_FF00脀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2092, 1790779138, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779138, new IntPtr(2737336577196L), 15);
		}
		return (Task<EntityRentalGameCharacter[]>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityGameCharacter> _FF00_FF00_FF00_FF00_FF00舀(EnumGameType P_0, object P_1, object P_2)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004b: Expected I4, but got Obj
		//IL_00e6: Expected Obj, but got Ref
		//IL_0151: Expected Obj, but got Ref
		//IL_0152: Expected Obj, but got I4
		//IL_00c0: Expected I, but got Obj
		//IL_00c0: Expected Obj, but got Ref
		//IL_013b: Expected Obj, but got I4
		//IL_013b: Expected Obj, but got Ref
		//IL_0114: Expected Obj, but got I4
		//IL_0114: Expected Obj, but got Ref
		//IL_00aa: Expected Obj, but got Ref
		//IL_00b3: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got Ref
		//IL_0083: Expected Obj, but got Ref
		//IL_0101->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0145->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0128->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0097->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00df->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0133->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a2->IL0026: Incompatible stack types: I4 vs Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 6;
		while (true)
		{
			object obj = stateMachine;
			while (true)
			{
				switch ((int)obj)
				{
				case 6:
					((DesktopAuthentication)(&stateMachine))._003CuserToken_003EP = EqualityComparer<_00211>.Default;
					obj = 5;
					if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP == null)
					{
						obj = 1;
					}
					continue;
				case 7:
					DesktopAuthentication.Crc32 = P_2;
					obj = 4;
					if (DesktopAuthentication.TokenKey != null)
					{
						obj = 2;
					}
					continue;
				case 5:
					break;
				case 2:
					((DesktopAuthentication)(&stateMachine))._connected = (nint)P_1;
					obj = 7;
					if (((DesktopAuthentication)(object)DesktopAuthentication._buffer)._handshake == 0)
					{
						obj = 3;
					}
					continue;
				default:
					((AsyncTaskMethodBuilder*)/*Error near IL_00ed: Stack underflow*/)->AwaitUnsafeOnCompleted(ref Unsafe.As<nint, TaskAwaiter>(ref ((DesktopAuthentication)(&stateMachine))._handshakeSent), ref *(DesktopAuthentication._003CHeartbeatCircleAsync_003Ed__24*)(&stateMachine));
					obj = 1;
					if (((DesktopAuthentication)DesktopAuthentication._encryptedToken)._encryptChaCha == null)
					{
						obj = 1;
					}
					continue;
				case 4:
					((DesktopAuthentication)(&stateMachine))._decryptChaCha = -1;
					obj = 0;
					if (((DesktopAuthentication)DesktopAuthentication._handshakeTcs)._authenticationTcs == null)
					{
						obj = 0;
					}
					continue;
				case 3:
					DesktopAuthentication.PrepareDic = (DesktopAuthentication)P_0;
					obj = 2;
					continue;
				case 1:
					return (Task<EntityGameCharacter>)((TaskCompletionSource)/*Error near IL_0151: Stack underflow*/).TrySetException((Exception)(&((DesktopAuthentication._003CAuthentication_003Ed__27*)(&stateMachine))->_003C_003E1__state));
				}
				break;
			}
			((DesktopAuthentication)(&stateMachine))._client = this;
			stateMachine = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityGameCharacter> _FF00_FF00_FF00_FF00_FF00茀(EnumGameType P_0, object P_1, object P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779149, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityGameCharacter>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe SessionContext<DesktopSession, EntityNetGameItem> _FF00_FF00_FF00_FF00_FF00蘀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2097, 1790779148, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779148, new IntPtr(2737336610476L), 15);
		}
		return (SessionContext<DesktopSession, EntityNetGameItem>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe SessionContext<DesktopSession, EntityNetGameItem> _FF00_FF00_FF00_FF00_FF00蜀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779151, new IntPtr(2737336633356L), 15))(null, 0, new IntPtr(0L));
		return (SessionContext<DesktopSession, EntityNetGameItem>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<PageModel<IDesktopSkin>> _FF00_FF00_FF00_FF00_FF00蠀(object P_0, uint P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_00d9: Expected Obj, but got Ref
		//IL_00b9: Expected Obj, but got Ref
		//IL_00be: Expected Obj, but got Ref
		//IL_00c7: Expected I, but got Obj
		//IL_00c7: Expected Obj, but got Ref
		//IL_00ff: Expected Obj, but got Ref
		//IL_0066: Expected Obj, but got Ref
		//IL_008c: Expected Obj, but got Ref
		//IL_0054: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got Ref
		//IL_00ed->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0085->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b2->IL0026: Incompatible stack types: I4 vs Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 3;
		object obj = stateMachine;
		while (true)
		{
			switch ((int)obj)
			{
			case 6:
				((DesktopAuthentication)(&stateMachine))._003CuserId_003EP = -1;
				obj = 5;
				break;
			case 4:
				((DesktopAuthentication)(&stateMachine))._003CuserToken_003EP = P_0;
				obj = 0;
				if (((DesktopAuthentication)DesktopAuthentication._003CgameVersion_003EP)._003CserverId_003EP != null)
				{
					obj = 0;
				}
				break;
			case 5:
				Unsafe.As<object, AsyncTaskMethodBuilder>(ref DesktopAuthentication.Crc32).Start(ref *(DesktopAuthentication._003CSendPacketAsync_003Ed__28*)(&stateMachine));
				obj = 1;
				if (((DesktopAuthentication)(object)DesktopAuthentication.TokenKey)._client == null)
				{
					obj = 0;
				}
				break;
			case 1:
				((TcpClient)Unsafe.AsPointer(ref ((DesktopAuthentication)(&stateMachine))._connected))._002Ector();
				return (Task<PageModel<IDesktopSkin>>)/*Error near IL_00bf: Stack underflow*/;
			case 2:
				((DesktopAuthentication)(&stateMachine))._handshake = (nint)this;
				obj = 4;
				break;
			default:
				((DesktopAuthentication)(&stateMachine))._handshakeSent = (int)P_1;
				obj = 6;
				if (((DesktopAuthentication)DesktopAuthentication._handshakeKey)._encryptedToken == null)
				{
					obj = 6;
				}
				break;
			case 3:
				((TcpClient)(&stateMachine)).Close();
				((DesktopAuthentication)/*Error near IL_0104: Stack underflow*/)._decryptChaCha = (object)/*Error near IL_0104: Stack underflow*/;
				obj = 2;
				break;
			}
		}
	}
}
