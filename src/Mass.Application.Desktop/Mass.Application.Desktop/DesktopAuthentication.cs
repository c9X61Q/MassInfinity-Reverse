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
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Mass.Application.Desktop.Security;
using Mass.Application.Netease;
using Mass.Application.Services;
using Mass.Common.Extensions;
using Mass.Domain.Desktop.Entities;
using Mass.Domain.Desktop.Entities.Game;
using Mass.Domain.Desktop.Entities.Mods;
using Mass.Domain.Desktop.Entities.NetGame;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Domain.Entities.Netease;
using Serilog;

namespace Mass.Application.Desktop;

public class DesktopAuthentication : IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAuthentication_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopAuthentication _003C_003E4__this;

		public string modHashList;

		public string serverIdHash;

		private object _003Ccts_003E5__2;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		internal static object ReflectInternalAnnotation;

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
		internal static bool CheckExpandableComparator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PopChooser()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_F500()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779285, new IntPtr(2737336594876L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_F600()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0047: Expected I4, but got Obj
			//IL_0761: Expected native int or pointer, but got Obj
			//IL_0731: Expected VT, but got I4
			//IL_073b: Expected native int or pointer, but got Obj
			//IL_007a: Expected Obj, but got Ref
			//IL_0053: Expected Obj, but got Ref
			//IL_009a: Expected I4, but got Obj
			//IL_01ad: Expected Obj, but got Ref
			//IL_0230: Expected native int or pointer, but got Obj
			//IL_03c2: Expected Obj, but got I4
			//IL_03c7: Expected VT, but got I4
			//IL_03d1: Expected native int or pointer, but got Obj
			//IL_02ff: Expected Ref, but got F8
			//IL_0304: Expected Obj, but got Ref
			//IL_027b: Expected Obj, but got I4
			//IL_0280: Expected VT, but got I4
			//IL_038d: Expected VT, but got Obj
			//IL_02b4: Expected native int or pointer, but got Obj
			//IL_02bb: Expected native int or pointer, but got Obj
			//IL_02c2: Expected native int or pointer, but got Obj
			//IL_02c9: Expected native int or pointer, but got Obj
			//IL_02e4: Expected Obj, but got VT
			//IL_0143: Expected Obj, but got Ref
			//IL_029e: Expected Obj, but got I4
			//IL_02a3: Expected Obj, but got I4
			//IL_01fa: Expected Obj, but got Ref
			//IL_0255: Expected Obj, but got I4
			//IL_0257: Expected Obj, but got VT
			//IL_0261: Expected native int or pointer, but got Obj
			//IL_01d2: Expected VT, but got Ref
			//IL_012d: Expected Obj, but got Ref
			//IL_0174: Expected Obj, but got I4
			//IL_0179: Expected Obj, but got Ref
			//IL_01c1: Expected Obj, but got Ref
			//IL_03a8: Expected native int or pointer, but got Obj
			//IL_015c: Expected Obj, but got Ref
			//IL_0527: Expected Obj, but got VT
			//IL_0530: Expected Obj, but got I4
			//IL_016a: Expected Obj, but got I4
			//IL_043e: Expected I4, but got Obj
			//IL_0474: Expected Obj, but got I4
			//IL_0479: Expected VT, but got I4
			//IL_05d2: Expected Obj, but got Ref
			//IL_05c1: Expected I, but got Obj
			//IL_05c1: Expected Obj, but got Ref
			//IL_0595: Expected Obj, but got I4
			//IL_059a: Expected Obj, but got I4
			//IL_0585: Expected I4, but got Obj
			//IL_0585: Expected Obj, but got Ref
			//IL_0460: Expected Obj, but got Ref
			//IL_04c5: Expected native int or pointer, but got Obj
			//IL_04df: Expected Obj, but got I4
			//IL_049f: Expected I4, but got Obj
			//IL_04a4: Expected I4, but got VT
			//IL_0122: Expected I4, but got Obj
			//IL_076b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0745->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0086->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0069->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0776->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0750->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0074->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01b9->IL00bd: Incompatible stack types: I4 vs Obj
			//IL_023a->IL00bd: Incompatible stack types: I4 vs Obj
			//IL_0385->IL00bd: Incompatible stack types: I4 vs Obj
			//IL_00ae->IL00bd: Incompatible stack types: I4 vs Obj
			//IL_0245->IL00bd: Incompatible stack types: I4 vs Obj
			//IL_00b9->IL00bd: Incompatible stack types: I4 vs Obj
			//IL_03db->IL00bd: Incompatible stack types: I4 vs Obj
			//IL_031d->IL00bd: Incompatible stack types: I4 vs Obj
			//IL_028a->IL00bd: Incompatible stack types: I4 vs Obj
			//IL_0397->IL00bd: Incompatible stack types: I4 vs Obj
			//IL_02f0->IL00bd: Incompatible stack heights: 3 vs 1
			//IL_0155->IL00bd: Incompatible stack types: I4 vs Obj
			//IL_037a->IL00bd: Incompatible stack types: I4 vs Obj
			//IL_02ad->IL00bd: Incompatible stack types: I4 vs Obj
			//IL_026b->IL00bd: Incompatible stack heights: 2 vs 1
			//IL_01e8->IL00bd: Incompatible stack types: I4 vs Obj
			//IL_0364->IL00bd: Incompatible stack heights: 2 vs 1
			//IL_013d->IL00bd: Incompatible stack types: I4 vs Obj
			//IL_0183->IL00bd: Incompatible stack types: I4 vs Obj
			//IL_01cb->IL00bd: Incompatible stack types: I4 vs Obj
			//IL_03b2->IL00bd: Incompatible stack heights: 3 vs 1
			//IL_03e6->IL00bd: Incompatible stack types: I4 vs Obj
			//IL_0328->IL00bd: Incompatible stack types: I4 vs Obj
			//IL_03f9->IL03fd: Incompatible stack types: I4 vs Obj
			//IL_0213->IL00bd: Incompatible stack types: I4 vs Obj
			//IL_0276->IL00bd: Incompatible stack heights: 2 vs 1
			//IL_01f3->IL00bd: Incompatible stack types: I4 vs Obj
			//IL_03bd->IL00bd: Incompatible stack heights: 3 vs 1
			//IL_021e->IL00bd: Incompatible stack types: I4 vs Obj
			//IL_048d->IL03fd: Incompatible stack types: I4 vs Obj
			//IL_05dc->IL03fd: Incompatible stack heights: 2 vs 1
			//IL_051f->IL03fd: Incompatible stack types: I4 vs Obj
			//IL_05cb->IL03fd: Incompatible stack types: I4 vs Obj
			//IL_05ae->IL03fd: Incompatible stack types: I4 vs Obj
			//IL_0459->IL03fd: Incompatible stack types: I4 vs Obj
			//IL_0590->IL03fd: Incompatible stack types: I4 vs Obj
			//IL_0566->IL03fd: Incompatible stack types: I4 vs Obj
			//IL_04b8->IL03fd: Incompatible stack types: I4 vs Obj
			//IL_0498->IL03fd: Incompatible stack types: I4 vs Obj
			//IL_05b9->IL03fd: Incompatible stack types: I4 vs Obj
			//IL_046f->IL03fd: Incompatible stack types: I4 vs Obj
			//IL_0571->IL03fd: Incompatible stack types: I4 vs Obj
			//IL_04c3->IL03fd: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 5;
			object obj = awaiter;
			while (true)
			{
				object obj4;
				switch ((int)obj)
				{
				case 2:
					return;
				case 5:
					awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
					obj = 4;
					if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP != null)
					{
						obj = 1;
					}
					break;
				case 4:
					awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CserverId_003EP;
					obj = 6;
					break;
				case 6:
				{
					object obj2;
					switch ((int)awaiter)
					{
					default:
						obj2 = 6;
						if (Logger != null)
						{
							obj2 = 6;
						}
						goto IL_00bd;
					case 0:
						awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptChaCha;
						obj2 = 10;
						goto IL_00bd;
					case 1:
						goto IL_021e;
					case 2:
						goto IL_037a;
						IL_00bd:
						while (true)
						{
							switch ((int)obj2)
							{
							case 4:
								return;
							case 23:
								return;
							case 18:
								Unsafe.As<byte[], void>(ref TokenKey) = default;
								obj2 = 2;
								continue;
							case 7:
								Unsafe.As<nint, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._connected).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CAuthentication_003Ed__27, _003CConnect_003Ed__19>(ref this));
								obj2 = 23;
								continue;
							case 22:
								((List<byte>)(&awaiter))._002Ector();
								if ((int)/*Error near IL_0161: Stack underflow*/ != 0)
								{
									awaiter = 12;
									obj2 = awaiter;
									continue;
								}
								goto default;
							case 19:
								awaiter = 0;
								((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeSent = 0;
								obj2 = 20;
								continue;
							case 8:
								break;
							case 20:
								((DesktopAuthentication)Unsafe.AsPointer(ref this))._decryptChaCha = awaiter;
								obj2 = 17;
								continue;
							case 16:
								RuntimeHelpers.InitializeArray((Array)/*Error near IL_01d2: Stack underflow*/, (RuntimeFieldHandle)(&awaiter));
								awaiter = (object)/*Error near IL_01d4: Stack underflow*/;
								obj2 = 6;
								if (PrepareDic == null)
								{
									obj2 = 15;
								}
								continue;
							case 13:
								((TimeoutException)/*Error near IL_01fa: Stack underflow*/)._002Ector((string?)(&awaiter));
								if ((int)/*Error near IL_01ff: Stack underflow*/ == 0)
								{
									obj2 = 19;
									if (((_003CAuthentication_003Ed__27)_003CAuthentication_003Ed__27._003C_003Et__builder)._003C_003E4__this == null)
									{
										obj2 = 4;
									}
									continue;
								}
								goto case 16;
							case 14:
								goto IL_021e;
							case 15:
								((_003CAuthentication_003Ed__27*)awaiter)->MoveNext();
								awaiter = ((Task)9).GetAwaiter();
								_ = 22;
								if (((_003CConnect_003Ed__19*)(nint)ReflectInternalAnnotation)->_003C_003E1__state != 0)
								{
									_ = 5;
								}
								continue;
							case 2:
								awaiter = -1;
								((_003CConnect_003Ed__19)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-1);
								obj2 = 21;
								continue;
							case 11:
								awaiter = -1;
								((_003CConnect_003Ed__19)this)._003C_003E4__this = (DesktopAuthentication)(-1);
								obj2 = 16;
								continue;
							case 6:
							{
								((CancellationTokenSource)/*Error near IL_02b2: Stack underflow*/)._002Ector((TimeSpan)/*Error near IL_02b2: Stack underflow*/);
								_ = ((_003CConnect_003Ed__19*)(nint)awaiter)->_003Ccts_003E5__2;
								_ = ((_003CConnect_003Ed__19*)(nint)awaiter)->_003C_003Eu__1;
								object obj3 = _003CConnect_003Ed__19.CheckAdjustableCommand;
								int num = ((_003CHeartbeatAsync_003Ed__25*)(nint)awaiter)->_003C_003E1__state;
								AsyncTaskMethodBuilder asyncTaskMethodBuilder = ((_003CHeartbeatAsync_003Ed__25)this)._003C_003Et__builder;
								((IDisposable)((_003CHeartbeatAsync_003Ed__25)this)._003C_003E4__this).Dispose();
								((AsyncTaskMethodBuilder*)num)->SetException((Exception)asyncTaskMethodBuilder);
								awaiter = obj3;
								_ = 13;
								continue;
							}
							case 1:
								((AsyncTaskMethodBuilder*)10.0)->SetResult();
								Unsafe.Write(&((_003CHeartbeatCircleAsync_003Ed__24*)(nint)/*Error near IL_0309: Stack underflow*/)->_003C_003E4__this, (DesktopAuthentication)new IAsyncStateMachine((IAsyncStateMachine)Unsafe.AsPointer(ref this)));
								obj2 = 5;
								if (_003CHeartbeatCircleAsync_003Ed__24.ReflectMixedRunner == null)
								{
									obj2 = 5;
								}
								continue;
							case 17:
								_ = ref ((_003CReceiveAsync_003Ed__20)this)._003C_003E4__this;
								((AsyncTaskMethodBuilder<EntityUserDetail>*)(&awaiter))->Start(ref Unsafe.As<_003CAuthentication_003Ed__27, DesktopSession._003CGetUserDetailAsync_003Ed__39>(ref this));
								_ = 4;
								continue;
							case 10:
								_003CReceiveAsync_003Ed__20.CheckCommonTracker = null;
								obj2 = 11;
								continue;
							case 5:
								goto IL_037a;
							case 3:
								((_003CReceiveControlDataAsync_003Ed__22)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)awaiter;
								obj2 = 7;
								continue;
							case 12:
							case 21:
								_ = ref awaiter;
								_ = Encoding.ASCII;
								_ = 1;
								if ((int)((_003CReceiveControlDataAsync_003Ed__22*)(nint)_003CReceiveControlDataAsync_003Ed__22.data)->_003C_003Eu__1 == 0)
								{
									_ = 1;
								}
								continue;
							default:
								awaiter = 1;
								((_003CReceiveControlDataAsync_003Ed__22)this)._003C_003Eu__2 = (TaskAwaiter)1;
								obj2 = 0;
								if (((_003CReceiveDataAsync_003Ed__21*)(nint)_003CReceiveControlDataAsync_003Ed__22.DecorateBasicTag)->_003C_003E1__state == 0)
								{
									obj2 = 3;
								}
								continue;
							case 9:
								goto end_IL_0089;
							}
							break;
						}
						goto case 0;
						IL_037a:
						obj2 = 9;
						goto IL_00bd;
						IL_021e:
						awaiter = modHashList;
						obj2 = 14;
						if (((_003CAuthentication_003Ed__27*)(nint)_003CAuthentication_003Ed__27.serverIdHash)->_003Ccts_003E5__2 != null)
						{
							obj2 = 18;
						}
						goto IL_00bd;
						end_IL_0089:
						break;
					}
					if ((nint)awaiter != 2)
					{
						obj4 = 14;
						goto IL_03fd;
					}
					goto IL_051f;
				}
				case 3:
					goto IL_0729;
				default:
					((DesktopSession._003CAddGameCharacterAsync_003Ed__44)this).gameId = null;
					obj = 0;
					if ((int)((DesktopSession._003CAddGameCharacterAsync_003Ed__44*)(nint)DesktopSession._003CAddGameCharacterAsync_003Ed__44.name)->_003C_003Eu__1 != 0)
					{
						obj = 1;
					}
					break;
				case 1:
					{
						_ = ref DesktopSession._003CAddGameCharacterAsync_003Ed__44.DecorateEditableInitializer;
						/*Error near IL_077c: Member reference must be method, but was: Field*/;
					}
					IL_0729:
					((DesktopSession._003CAddGameCharacterAsync_003Ed__44)this)._003C_003Et__builder = (AsyncTaskMethodBuilder<EntityGameCharacter>)(-2);
					obj = 0;
					if (((DesktopSession._003CAddGameCharacterAsync_003Ed__44*)(nint)DesktopSession._003CAddGameCharacterAsync_003Ed__44._003C_003E4__this)->type == 0)
					{
						obj = 0;
					}
					break;
					IL_051f:
					awaiter = ((_003CSendMessageAsync_003Ed__29)this)._003C_003Eu__1;
					awaiter = 9;
					goto IL_03f9;
					IL_03f9:
					obj4 = awaiter;
					goto IL_03fd;
					IL_03fd:
					while (true)
					{
						switch ((int)obj4)
						{
						case 6:
							return;
						case 9:
							Unsafe.As<AsyncTaskMethodBuilder, @null>(ref ((_003CReceiveDataAsync_003Ed__21)this)._003C_003Et__builder) = null;
							obj4 = 8;
							continue;
						case 11:
							if (((MassService)/*Error near IL_0460: Stack underflow*/).JoinServerAsync((byte[])/*Error near IL_0460: Stack underflow*/, (string)/*Error near IL_0460: Stack underflow*/, (string)/*Error near IL_0460: Stack underflow*/, (byte[])/*Error near IL_0460: Stack underflow*/, (string)(&awaiter)) != null)
							{
								obj4 = 3;
								continue;
							}
							goto default;
						default:
							awaiter = 2;
							((_003CReceiveDataAsync_003Ed__21)this)._003C_003Eu__1 = (TaskAwaiter<int>)2;
							obj4 = 7;
							if ((int)((_003CReceiveDataAsync_003Ed__21*)_003CReceiveDataAsync_003Ed__21._003Clength_003E5__2)->_003C_003Eu__2 == 0)
							{
								obj4 = 7;
							}
							continue;
						case 14:
							((_003CRemoteCallBackAsync_003Ed__23*)(nint)/*Error near IL_04a4: Stack underflow*/)->_003C_003E1__state = (int)new DefaultInterpolatedStringHandler((int)/*Error near IL_049f: Stack underflow*/, (int)awaiter);
							obj4 = 1;
							if (((_003CRemoteCallBackAsync_003Ed__23)_003CRemoteCallBackAsync_003Ed__23._003C_003Et__builder).sid == 0)
							{
								obj4 = 2;
							}
							continue;
						case 12:
							break;
						case 2:
							((EndOfStreamException)(object)((_003CSendMessageAsync_003Ed__29)this)._003C_003E4__this)._002Ector();
							awaiter = (object)/*Error near IL_0515: Stack underflow*/;
							obj4 = 10;
							continue;
						case 4:
							goto IL_051f;
						case 13:
							Unsafe.As<object, AsyncTaskMethodBuilder<EntityGameCharacter>>(ref _003CSendMessageAsync_003Ed__29.CheckAccessibleCalculator).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityGameCharacter>*)(&awaiter), ref Unsafe.As<_003CAuthentication_003Ed__27, DesktopSession._003CAddGameCharacterAsync_003Ed__44>(ref this));
							obj4 = 1;
							if (((_003CSendPacketAsync_003Ed__28)_003CSendPacketAsync_003Ed__28._003C_003Et__builder).id == 0)
							{
								obj4 = 6;
							}
							continue;
						case 10:
							((Stream)(&awaiter)).ReadAsync((byte[])awaiter, (int)__ldftn(DesktopSession.GetSkinsByIdAsync), (int)new TcpClient());
							obj4 = 12;
							continue;
						case 8:
							awaiter = -1;
							_003CSendPacketAsync_003Ed__28.CheckIterableSynchronizer = -1;
							obj4 = 1;
							if (((DesktopSession)DesktopSession._netGames)._skins == null)
							{
								obj4 = 0;
							}
							continue;
						case 7:
							((DesktopSession)Unsafe.AsPointer(ref this))._skinTotal = (nint)awaiter;
							obj4 = 13;
							continue;
						case 1:
						case 3:
							_ = (ReadOnlyMemory<byte>)(byte[]?)(&awaiter);
							_ = 5;
							continue;
						case 5:
							goto IL_0729;
						}
						break;
					}
					((TaskCompletionSource)/*Error near IL_04d4: Stack underflow*/).SetException((Exception)(object)((DefaultInterpolatedStringHandler*)((_003CRemoteCallBackAsync_003Ed__23*)(nint)awaiter)->payload)->ToStringAndClear());
					awaiter = (object)/*Error near IL_04d6: Stack underflow*/;
					awaiter = 11;
					goto IL_03f9;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_F700(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779284, new IntPtr(2737336576156L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_F800(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00豈(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779287, new IntPtr(2737336574076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00切()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779286, new IntPtr(2737336583436L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00ﬀ()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00ﰀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779281, new IntPtr(2737336580316L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00ﴀ()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FE00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779280, new IntPtr(2737336600076L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CConnect_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopAuthentication _003C_003E4__this;

		public EntityAuthServer authServer;

		private object _003Ccts_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private static object CheckAdjustableCommand;

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
		internal static bool CheckGenericConsumer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VerifyTracer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_EE00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779283, new IntPtr(2737336587596L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_EF00()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0047: Expected I4, but got Obj
			//IL_0079: Expected Obj, but got Ref
			//IL_007e: Expected VT, but got Ref
			//IL_0090: Expected Obj, but got I4
			//IL_0090: Expected Obj, but got Ref
			//IL_06f4: Expected I4, but got Obj
			//IL_06fe: Expected native int or pointer, but got Obj
			//IL_071c: Expected Obj, but got VT
			//IL_0052: Expected Obj, but got Ref
			//IL_017b: Expected Obj, but got Ref
			//IL_0186: Expected Obj, but got I4
			//IL_00c6: Expected Obj, but got I
			//IL_0123: Expected I4, but got Obj
			//IL_01df: Expected Obj, but got I4
			//IL_01e4: Expected Obj, but got I4
			//IL_01ee: Expected native int or pointer, but got Obj
			//IL_019c: Expected native int or pointer, but got Obj
			//IL_0294: Expected Obj, but got I4
			//IL_028f: Expected native int or pointer, but got Obj
			//IL_029d: Expected Obj, but got I4
			//IL_0151: Expected Obj, but got Ref
			//IL_0159: Expected Obj, but got Ref
			//IL_0159: Expected Obj, but got Ref
			//IL_016b: Expected Obj, but got Ref
			//IL_0137: Expected Obj, but got F8
			//IL_0141: Expected Obj, but got VT
			//IL_0141: Expected Obj, but got Ref
			//IL_01b6: Expected Obj, but got I4
			//IL_01bb: Expected VT, but got I4
			//IL_01c5: Expected native int or pointer, but got Obj
			//IL_02c4: Expected native int or pointer, but got Obj
			//IL_02d4: Expected Obj, but got VT
			//IL_02e4: Expected Obj, but got VT
			//IL_0247: Expected F8, but got Ref
			//IL_0256: Expected native int or pointer, but got Obj
			//IL_03af: Expected Obj, but got I4
			//IL_03b4: Expected VT, but got I4
			//IL_03be: Expected native int or pointer, but got Obj
			//IL_0495: Expected native int or pointer, but got Obj
			//IL_03f0: Expected Obj, but got VT
			//IL_03db: Expected VT, but got Obj
			//IL_0484: Expected VT, but got Obj
			//IL_0489: Expected Obj, but got VT
			//IL_0454: Expected native int or pointer, but got Obj
			//IL_046e: Expected Obj, but got I4
			//IL_0473: Expected VT, but got I4
			//IL_051c: Expected native int or pointer, but got Obj
			//IL_04cc: Expected I4, but got Obj
			//IL_0395: Expected native int or pointer, but got Obj
			//IL_0427: Expected native int or pointer, but got Obj
			//IL_0088->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00a4->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0708->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0726->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00af->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0713->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00cb->IL00da: Incompatible stack types: I4 vs Obj
			//IL_0073->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00d6->IL00da: Incompatible stack types: I4 vs Obj
			//IL_01f8->IL00da: Incompatible stack types: I4 vs Obj
			//IL_028c->IL00da: Incompatible stack types: I4 vs Obj
			//IL_01a6->IL00da: Incompatible stack heights: 3 vs 1
			//IL_0223->IL00da: Incompatible stack types: I4 vs Obj
			//IL_0163->IL00da: Incompatible stack heights: 3 vs 1
			//IL_0175->IL00da: Incompatible stack types: I4 vs Obj
			//IL_014b->IL00da: Incompatible stack types: I4 vs Obj
			//IL_02b7->IL00da: Incompatible stack types: I4 vs Obj
			//IL_01cf->IL00da: Incompatible stack types: I4 vs Obj
			//IL_02fa->IL00da: Incompatible stack types: I4 vs Obj
			//IL_0240->IL00da: Incompatible stack types: I4 vs Obj
			//IL_0203->IL00da: Incompatible stack types: I4 vs Obj
			//IL_01b1->IL00da: Incompatible stack heights: 3 vs 1
			//IL_022e->IL00da: Incompatible stack types: I4 vs Obj
			//IL_02c2->IL00da: Incompatible stack types: I4 vs Obj
			//IL_01da->IL00da: Incompatible stack types: I4 vs Obj
			//IL_0260->IL00da: Incompatible stack types: I4 vs Obj
			//IL_026b->IL00da: Incompatible stack types: I4 vs Obj
			//IL_04fd->IL0335: Incompatible stack heights: 2 vs 1
			//IL_045e->IL0335: Incompatible stack heights: 2 vs 1
			//IL_0526->IL0335: Incompatible stack heights: 4 vs 1
			//IL_0469->IL0335: Incompatible stack heights: 2 vs 1
			//IL_0531->IL0335: Incompatible stack heights: 4 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 6;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				int num;
				switch ((int)obj2)
				{
				case 6:
					obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
					obj2 = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP != null)
					{
						obj2 = 5;
					}
					break;
				default:
					((EqualityComparer<_00210>)/*Error near IL_007e: Stack underflow*/).GetHashCode((_00210)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CserverId_003EP));
					_ = 3;
					break;
				case 1:
					Logger = -2;
					obj2 = 2;
					if (((DesktopAuthentication)(object)TokenKey)._client == null)
					{
						obj2 = 0;
					}
					break;
				case 4:
					if (obj != null)
					{
						obj3 = 0;
						if (((DesktopAuthentication)DesktopAuthentication._connected)._buffer != null)
						{
							obj3 = 0;
						}
						goto IL_00da;
					}
					goto IL_0175;
				case 2:
					((DesktopSession._003CAddGameCharacterAsync_003Ed__44)this).type = (EnumGameType)null;
					obj2 = 0;
					if (((DesktopSession._003CAddGameCharacterAsync_003Ed__44*)(nint)DesktopSession._003CAddGameCharacterAsync_003Ed__44.gameId)->name != null)
					{
						obj2 = 0;
					}
					break;
				case 3:
					return;
				case 5:
					{
						obj = ((DesktopSession._003CAddGameCharacterAsync_003Ed__44)this)._003C_003Eu__1;
						obj2 = 4;
						break;
					}
					IL_0335:
					while (true)
					{
						switch (num)
						{
						case 14:
							break;
						case 15:
							((_003CReceiveAsync_003Ed__20)this)._003C_003E4__this = null;
							num = 0;
							if (((_003CReceiveControlDataAsync_003Ed__22*)(nint)_003CReceiveAsync_003Ed__20.CheckCommonTracker)->_003C_003E1__state == 0)
							{
								num = 0;
							}
							continue;
						default:
							obj = -1;
							((_003CReceiveControlDataAsync_003Ed__22)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-1);
							num = 1;
							if (((_003CReceiveControlDataAsync_003Ed__22*)(nint)_003CReceiveControlDataAsync_003Ed__22._003C_003E4__this)->data == null)
							{
								num = 1;
							}
							continue;
						case 6:
							((_003CReceiveControlDataAsync_003Ed__22)this)._003C_003Eu__1 = (TaskAwaiter<byte[]>)obj;
							num = 9;
							continue;
						case 5:
							obj = Enumerable.ToArray<TSource>((IEnumerable<TSource>)((_003CReceiveControlDataAsync_003Ed__22)this)._003C_003Eu__2);
							num = 11;
							if ((int)((_003CReceiveDataAsync_003Ed__21*)_003CReceiveDataAsync_003Ed__21._003C_003E1__state)->_003C_003Et__builder != 0)
							{
								num = 1;
							}
							continue;
						case 2:
							if (((HashAlgorithm)/*Error near IL_0418: Stack underflow*/).ComputeHash((byte[])/*Error near IL_0418: Stack underflow*/, (int)/*Error near IL_0418: Stack underflow*/, (int)(&obj)) != null)
							{
								num = 1;
								if ((int)((_003CReceiveDataAsync_003Ed__21*)(nint)_003CReceiveDataAsync_003Ed__21.buffer)->_003C_003Eu__1 != 0)
								{
									num = 3;
								}
								continue;
							}
							goto case 10;
						case 9:
							_ = ref ((_003CReceiveDataAsync_003Ed__21)this)._003Clength_003E5__2;
							((AsyncTaskMethodBuilder<EntityGameClientPatch>*)(&obj))->Start(ref Unsafe.As<_003CConnect_003Ed__19, DesktopSession._003CGetGamePatchInfoAsync_003Ed__54>(ref this));
							_ = 7;
							if (((_003CRemoteCallBackAsync_003Ed__23*)(nint)_003CReceiveDataAsync_003Ed__21.CheckActiveRecommender)->_003C_003E1__state != 0)
							{
								_ = 6;
							}
							continue;
						case 10:
							obj = 1;
							((_003CRemoteCallBackAsync_003Ed__23)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)1;
							num = 6;
							continue;
						case 8:
							Unsafe.Write(&((_003CRemoteCallBackAsync_003Ed__23*)(nint)/*Error near IL_0489: Stack underflow*/)->payload, (byte[])new DefaultInterpolatedStringHandler((T)obj));
							num = 5;
							continue;
						case 4:
							((TaskCompletionSource)/*Error near IL_049f: Stack underflow*/).SetException((Exception)(object)((_003CRemoteCallBackAsync_003Ed__23*)(nint)obj)->_003C_003E4__this);
							((List<byte>)/*Error near IL_04a4: Stack underflow*/).RemoveRange((int)/*Error near IL_04a4: Stack underflow*/, (int)/*Error near IL_04a4: Stack underflow*/);
							obj = (object)/*Error near IL_04a6: Stack underflow*/;
							num = 1;
							if (((_003CSendMessageAsync_003Ed__29)_003CSendMessageAsync_003Ed__29._003C_003Et__builder)._003C_003E4__this == null)
							{
								num = 2;
							}
							continue;
						case 12:
							((DesktopSession)/*Error near IL_04cc: Stack underflow*/).RequestAsync<T>((string)/*Error near IL_04cc: Stack underflow*/, (object)/*Error near IL_04cc: Stack underflow*/, (byte)(int)obj != 0);
							num = 8;
							if (_003CSendMessageAsync_003Ed__29.CheckAccessibleCalculator == null)
							{
								num = 14;
							}
							continue;
						case 1:
						case 3:
							_ = ((TaskAwaiter<int>*)(&obj))->IsCompleted;
							_ = 12;
							continue;
						case 11:
							_ = ref obj;
							__ldftn(DesktopSession.GetSkinsAsync);
							((TaskAwaiter<int>*)new List<byte>())->GetResult();
							_ = 0;
							if ((int)((_003CSendPacketAsync_003Ed__28*)(nint)_003CSendPacketAsync_003Ed__28._003C_003E4__this)->_003C_003Eu__1 != 0)
							{
								_ = 4;
							}
							continue;
						case 13:
							goto IL_0531;
						case 7:
							return;
						}
						break;
					}
					goto case 1;
					IL_028c:
					Unsafe.Write(&CheckAdjustableCommand, (object)1);
					obj = 2;
					goto IL_00d6;
					IL_0175:
					obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeTcs;
					obj = 5;
					goto IL_00d6;
					IL_00d6:
					obj3 = obj;
					goto IL_00da;
					IL_00da:
					while (true)
					{
						switch ((int)obj3)
						{
						case 9:
							((List<byte>)10.0)._002Ector();
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeKey = new AsyncTaskMethodBuilder();
							obj3 = 11;
							continue;
						case 6:
							_ = ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptedToken;
							((IEnumerable<byte>)(&obj)).Concat((IEnumerable<byte>)Unsafe.AsPointer(ref this));
							_ = 10;
							continue;
						case 7:
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._decryptChaCha = obj;
							obj3 = 6;
							continue;
						case 15:
							break;
						case 3:
						case 14:
							_ = ref obj;
							_ = Log.Logger;
							_ = 4;
							if (((_003CAuthentication_003Ed__27*)(nint)PrepareDic)->_003C_003E1__state == 0)
							{
								_ = 3;
							}
							continue;
						case 12:
							obj = 0;
							((_003CAuthentication_003Ed__27)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)0;
							obj3 = 7;
							if (((_003CAuthentication_003Ed__27*)(nint)_003CAuthentication_003Ed__27._003C_003E4__this)->modHashList == null)
							{
								obj3 = 4;
							}
							continue;
						case 1:
							obj = -1;
							((_003CAuthentication_003Ed__27)this).serverIdHash = (string)(-1);
							obj3 = 3;
							if ((int)((_003CAuthentication_003Ed__27*)(nint)_003CAuthentication_003Ed__27._003Ccts_003E5__2)->_003C_003Eu__1 == 0)
							{
								obj3 = 2;
							}
							continue;
						case 5:
							Unsafe.As<TaskAwaiter, @null>(ref ((_003CAuthentication_003Ed__27)this)._003C_003Eu__2) = null;
							obj3 = 1;
							if ((int)((_003CConnect_003Ed__19*)_003CConnect_003Ed__19._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								obj3 = 0;
							}
							continue;
						default:
							if ((nint)obj != 1)
							{
								obj3 = 13;
								continue;
							}
							goto case 11;
						case 16:
							if ((int)TimeSpan.FromSeconds((double)(nint)(&obj)) != 0)
							{
								obj3 = 8;
								if (((_003CConnect_003Ed__19*)(nint)_003CConnect_003Ed__19.authServer)->_003Ccts_003E5__2 == null)
								{
									obj3 = 14;
								}
								continue;
							}
							goto case 12;
						case 2:
							((_003CHeartbeatAsync_003Ed__25*)obj)->MoveNext();
							obj3 = 9;
							continue;
						case 4:
							goto IL_028c;
						case 11:
							obj3 = 8;
							if ((int)((_003CHeartbeatAsync_003Ed__25*)_003CHeartbeatAsync_003Ed__25._003C_003E1__state)->_003C_003Et__builder != 0)
							{
								obj3 = 4;
							}
							continue;
						case 13:
							((AsyncTaskMethodBuilder*)((_003CHeartbeatAsync_003Ed__25*)(nint)obj)->_003C_003E4__this)->SetException((Exception)((_003CHeartbeatAsync_003Ed__25)this)._003C_003Eu__1);
							((AsyncTaskMethodBuilder*)/*Error near IL_02d9: Stack underflow*/)->SetResult();
							((AsyncTaskMethodBuilder*)/*Error near IL_02e4: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)((_003CHeartbeatCircleAsync_003Ed__24)this)._003C_003Et__builder);
							obj = IPAddress.Parse(((EntityAuthServer)/*Error near IL_02e9: Stack underflow*/).Ip);
							obj3 = 16;
							continue;
						case 10:
							return;
						case 8:
							goto IL_031e;
						}
						break;
					}
					goto IL_0175;
					IL_031e:
					if ((nint)obj != 1)
					{
						num = 8;
						goto IL_0335;
					}
					goto IL_0531;
					IL_0531:
					obj = _003CSendPacketAsync_003Ed__28.CheckIterableSynchronizer;
					num = 8;
					if (((DesktopSession)DesktopSession._netGames)._skins == null)
					{
						num = 15;
					}
					goto IL_0335;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_F000(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779282, new IntPtr(2737336605276L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_F100(object P_0)
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
		internal static byte _FF00_FF00_FF00_FF00_F200()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_F300()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_F400()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779293, new IntPtr(2737336601116L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CHeartbeatAsync_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopAuthentication _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object ProcessResolver;

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
		internal static bool CheckAdvancedConfig()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ExcludeError()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_E500()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779292, new IntPtr(2737336586556L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_E600()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_02b6: Expected Obj, but got Ref
			//IL_02c8: Expected Obj, but got I4
			//IL_02ef: Expected Obj, but got VT
			//IL_02f9: Expected native int or pointer, but got Obj
			//IL_0317: Expected VT, but got I4
			//IL_0321: Expected native int or pointer, but got Obj
			//IL_0151: Expected Obj, but got Ref
			//IL_01b3: Expected Obj, but got Ref
			//IL_0124: Expected Obj, but got Ref
			//IL_01ea: Expected Obj, but got VT
			//IL_01f4: Expected native int or pointer, but got Obj
			//IL_00d7: Expected VT, but got Ref
			//IL_00b1: Expected Obj, but got Ref
			//IL_00e6: Expected Obj, but got I4
			//IL_00eb: Expected Obj, but got I4
			//IL_00eb: Expected Obj, but got Ref
			//IL_0187: Expected Obj, but got Ref
			//IL_010f: Expected Obj, but got I4
			//IL_0114: Expected Obj, but got I4
			//IL_0114: Expected Obj, but got Ref
			//IL_01c2: Expected native int or pointer, but got Obj
			//IL_02c0->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02dc->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0303->IL0026: Incompatible stack types: I4 vs Obj
			//IL_032b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_02e7->IL0026: Incompatible stack types: I4 vs Obj
			//IL_030e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0336->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0140->IL0073: Incompatible stack heights: 5 vs 1
			//IL_00e1->IL0073: Incompatible stack heights: 2 vs 1
			//IL_014b->IL0073: Incompatible stack heights: 5 vs 1
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
				case 5:
					if (obj != null)
					{
						num = 0;
						if (((DesktopAuthentication)DesktopAuthentication._003CuserId_003EP)._003CuserToken_003EP != null)
						{
							num = 3;
						}
						goto IL_0073;
					}
					goto IL_014b;
				default:
					((AsyncTaskMethodBuilder*)/*Error near IL_02b6: Stack underflow*/)->SetException((Exception)Unsafe.AsPointer(ref _003C_003Eu__1));
					obj2 = 4;
					continue;
				case 1:
					obj = ((_003CHeartbeatCircleAsync_003Ed__24)this)._003C_003E1__state;
					obj2 = 5;
					if (((_003CHeartbeatCircleAsync_003Ed__24)_003CHeartbeatCircleAsync_003Ed__24._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 5;
					}
					continue;
				case 2:
					obj = ((_003CHeartbeatCircleAsync_003Ed__24)this)._003C_003Eu__1;
					obj2 = 1;
					if (((_003CReceiveAsync_003Ed__20*)(nint)_003CHeartbeatCircleAsync_003Ed__24.ReflectMixedRunner)->_003C_003E1__state != 0)
					{
						obj2 = 0;
					}
					continue;
				case 4:
					return;
				case 3:
					break;
					IL_014b:
					obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptChaCha;
					num = 8;
					if (((DesktopAuthentication)DesktopAuthentication._decryptChaCha)._handshakeTcs != null)
					{
						num = 4;
					}
					goto IL_0073;
					IL_0073:
					while (true)
					{
						switch (num)
						{
						case 6:
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CgameVersion_003EP = obj;
							num = 1;
							if (Crc32 != null)
							{
								num = 0;
							}
							continue;
						case 4:
							((EqualityComparer<_00211>)/*Error near IL_00d7: Stack underflow*/).GetHashCode((_00211)(&obj));
							_ = 5;
							continue;
						case 7:
							obj = -1;
							TokenKey = (byte[])(-1);
							num = 4;
							if (((DesktopAuthentication)DesktopAuthentication._client)._connected != 0)
							{
								num = 4;
							}
							continue;
						case 9:
							obj = 0;
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._buffer = (List<byte>)0;
							num = 6;
							continue;
						case 1:
							_ = ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshake;
							_ = ref obj;
							Array.Empty<byte>();
							_ = 10;
							if (((DesktopAuthentication)DesktopAuthentication._handshakeKey)._encryptedToken == null)
							{
								_ = 10;
							}
							continue;
						case 2:
							break;
						case 10:
							return;
						case 8:
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._authenticationTcs = null;
							num = 6;
							if ((int)((_003CAuthentication_003Ed__27*)_003CAuthentication_003Ed__27._003C_003E1__state)->_003C_003Et__builder != 0)
							{
								num = 7;
							}
							continue;
						default:
							((IAsyncStateMachine)(&obj)).MoveNext();
							if ((int)/*Error near IL_01b8: Stack underflow*/ == 0)
							{
								num = 6;
								if (((_003CAuthentication_003Ed__27*)(nint)_003CAuthentication_003Ed__27.modHashList)->serverIdHash == null)
								{
									num = 9;
								}
								continue;
							}
							goto case 4;
						case 3:
							((AsyncTaskMethodBuilder*)/*Error near IL_01de: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(ValueTaskAwaiter*)/*Error near IL_01de: Stack underflow*/, ref *(_003CSendMessageAsync_003Ed__29*)obj);
							((_003CAuthentication_003Ed__27*)/*Error near IL_01e3: Stack underflow*/)->MoveNext();
							obj = ((Task)/*Error near IL_01e8: Stack underflow*/).GetAwaiter();
							num = 0;
							if (((_003CConnect_003Ed__19*)(nint)_003CAuthentication_003Ed__27.ReflectInternalAnnotation)->_003C_003E1__state != 0)
							{
								num = 0;
							}
							continue;
						case 5:
							goto end_IL_0026;
						}
						break;
					}
					goto IL_014b;
					end_IL_0026:
					break;
				}
				((_003CReceiveAsync_003Ed__20)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-2);
				obj2 = 0;
				if ((int)((_003CReceiveAsync_003Ed__20*)(nint)_003CReceiveAsync_003Ed__20._003C_003E4__this)->_003C_003Eu__1 == 0)
				{
					obj2 = 0;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_E700()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779295, new IntPtr(2737336594876L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_E800(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_E900(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779294, new IntPtr(2737336594876L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_EA00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779289, new IntPtr(2737336602156L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_EB00()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_EC00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779288, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_ED00()
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
	private struct _003CHeartbeatCircleAsync_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopAuthentication _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object ReflectMixedRunner;

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
		internal static bool DecompressUser()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateSegmentedListener()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779291, new IntPtr(2737336583436L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_05df: Expected Obj, but got I4
			//IL_004f: Expected Obj, but got Ref
			//IL_0054: Expected VT, but got Ref
			//IL_0616: Expected Obj, but got Ref
			//IL_0627: Expected Obj, but got I
			//IL_05f1: Expected Obj, but got VT
			//IL_04d7: Expected Obj, but got I4
			//IL_0192: Expected Obj, but got Ref
			//IL_019a: Expected Obj, but got Ref
			//IL_019a: Expected Obj, but got Ref
			//IL_00ee: Expected VT, but got F8
			//IL_00f3: Expected VT, but got I4
			//IL_00f8: Expected VT, but got I4
			//IL_00fa: Expected Obj, but got I4
			//IL_01e5: Expected I4, but got Obj
			//IL_012e: Expected Obj, but got Ref
			//IL_0221: Expected native int or pointer, but got Obj
			//IL_0109: Expected Obj, but got I4
			//IL_010e: Expected Obj, but got I4
			//IL_010e: Expected Obj, but got Ref
			//IL_017c: Expected Obj, but got I
			//IL_0392: Expected Obj, but got VT
			//IL_0296: Expected native int or pointer, but got Obj
			//IL_0142: Expected Obj, but got I
			//IL_0377: Expected Obj, but got I4
			//IL_037c: Expected Obj, but got I4
			//IL_0385: Expected Obj, but got I4
			//IL_0433: Expected Obj, but got I4
			//IL_0438: Expected VT, but got I4
			//IL_0442: Expected native int or pointer, but got Obj
			//IL_031e: Expected VT, but got Obj
			//IL_0328: Expected native int or pointer, but got Obj
			//IL_0368: Expected Obj, but got Ref
			//IL_0301: Expected native int or pointer, but got Obj
			//IL_03ca: Expected native int or pointer, but got Obj
			//IL_02e4: Expected I4, but got Obj
			//IL_05e9->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005e->IL0026: Incompatible stack heights: 2 vs 1
			//IL_062c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0605->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0637->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0610->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01ae->IL0074: Incompatible stack heights: 3 vs 1
			//IL_0251->IL0074: Incompatible stack heights: 2 vs 1
			//IL_039c->IL02af: Incompatible stack types: I4 vs Obj
			//IL_02a0->IL02af: Incompatible stack types: I4 vs Obj
			//IL_01b9->IL0074: Incompatible stack heights: 3 vs 1
			//IL_025c->IL0074: Incompatible stack heights: 2 vs 1
			//IL_02ab->IL02af: Incompatible stack types: I4 vs Obj
			//IL_044c->IL02af: Incompatible stack types: I4 vs Obj
			//IL_0332->IL02af: Incompatible stack types: I4 vs Obj
			//IL_03b4->IL02af: Incompatible stack heights: 2 vs 1
			//IL_0372->IL02af: Incompatible stack types: I4 vs Obj
			//IL_03ff->IL02af: Incompatible stack types: I4 vs Obj
			//IL_030b->IL02af: Incompatible stack types: I4 vs Obj
			//IL_03d4->IL02af: Incompatible stack types: I4 vs Obj
			//IL_0457->IL02af: Incompatible stack types: I4 vs Obj
			//IL_033d->IL02af: Incompatible stack types: I4 vs Obj
			//IL_040a->IL02af: Incompatible stack types: I4 vs Obj
			//IL_0316->IL02af: Incompatible stack types: I4 vs Obj
			//IL_03df->IL02af: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				case 3:
					return;
				case 2:
					((EqualityComparer<_00211>)/*Error near IL_0054: Stack underflow*/).Equals((_00211?)/*Error near IL_0054: Stack underflow*/, (_00211?)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP));
					_ = 3;
					break;
				case 1:
					if (obj == null)
					{
						num = 13;
						goto IL_0074;
					}
					goto IL_025c;
				default:
					goto IL_05d7;
				case 5:
					obj = ((_003CSendPacketAsync_003Ed__28)this)._003C_003Eu__1;
					obj2 = 1;
					if (((DesktopSession)_003CSendPacketAsync_003Ed__28.CheckIterableSynchronizer)._netGames == null)
					{
						obj2 = 4;
					}
					break;
				case 4:
					{
						obj = ((DesktopSession)Unsafe.AsPointer(ref this))._skins;
						obj2 = 1;
						if (((DesktopSession)DesktopSession._skinTotal).UserDetail__BackingField == null)
						{
							obj2 = 1;
						}
						break;
					}
					IL_0204:
					num = 2;
					goto IL_0074;
					IL_0074:
					while (true)
					{
						object obj3;
						switch (num)
						{
						case 9:
							return;
						case 6:
						case 12:
							if (((DesktopAuthentication)obj)._003CgameVersion_003EP == null)
							{
								num = 17;
								continue;
							}
							goto case 5;
						case 5:
							obj = ((EqualityComparer<_00211>)/*Error near IL_00f8: Stack underflow*/).GetHashCode((_00211)((EqualityComparer<_00210>)/*Error near IL_00f3: Stack underflow*/).GetHashCode((_00210)((EqualityComparer<_00210>)/*Error near IL_00ee: Stack underflow*/).Equals((_00210?)/*Error near IL_00ee: Stack underflow*/, (_00210?)30.0)));
							num = 11;
							continue;
						case 18:
							obj = -1;
							TokenKey = (byte[])(-1);
							num = 10;
							continue;
						case 11:
							if (string.Format((IFormatProvider?)/*Error near IL_012e: Stack underflow*/, (string)/*Error near IL_012e: Stack underflow*/, (object?[])(&obj)) != null)
							{
								num = 8;
								if (((DesktopAuthentication)DesktopAuthentication._connected)._buffer == null)
								{
									num = 4;
								}
								continue;
							}
							goto case 3;
						case 1:
							if (((DesktopAuthentication)obj)._handshake != 0)
							{
								num = 0;
								if (((DesktopAuthentication)DesktopAuthentication._handshakeSent)._handshakeKey != null)
								{
									num = 0;
								}
								continue;
							}
							goto IL_05d7;
						case 4:
							_ = ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptedToken;
							((IEnumerable<byte>)(&obj)).Concat((IEnumerable<byte>)Unsafe.AsPointer(ref this));
							_ = 9;
							if (((DesktopAuthentication)DesktopAuthentication._decryptChaCha)._handshakeTcs != null)
							{
								_ = 8;
							}
							continue;
						case 7:
							((_003CAuthentication_003Ed__27)this)._003C_003E1__state = (int)obj;
							num = 3;
							if (((_003CAuthentication_003Ed__27)_003CAuthentication_003Ed__27._003C_003Et__builder)._003C_003E4__this != null)
							{
								num = 4;
							}
							continue;
						case 13:
						case 15:
							obj = ((_003CAuthentication_003Ed__27)this).modHashList;
							num = 14;
							if (((_003CAuthentication_003Ed__27*)(nint)_003CAuthentication_003Ed__27.serverIdHash)->_003Ccts_003E5__2 == null)
							{
								num = 16;
							}
							continue;
						case 8:
						case 10:
							_ = ((TaskAwaiter<byte[]>*)(&obj))->IsCompleted;
							_ = 0;
							if (_003CAuthentication_003Ed__27.ReflectInternalAnnotation == null)
							{
								_ = 1;
							}
							continue;
						case 14:
							goto IL_025c;
						case 2:
							if ((nint)obj != 1)
							{
								obj3 = 8;
								if (((_003CConnect_003Ed__19*)(nint)_003CConnect_003Ed__19._003C_003E4__this)->authServer == null)
								{
									obj3 = 11;
								}
								goto IL_02af;
							}
							goto IL_038a;
						case 3:
							obj = 0;
							((_003CRemoteCallBackAsync_003Ed__23)this)._003C_003E1__state = 0;
							num = 4;
							if (((_003CRemoteCallBackAsync_003Ed__23)_003CRemoteCallBackAsync_003Ed__23._003C_003Et__builder).sid != 0)
							{
								num = 7;
							}
							continue;
						case 16:
							((_003CRemoteCallBackAsync_003Ed__23)this).payload = null;
							num = 18;
							continue;
						case 17:
							goto IL_05d7;
							IL_038a:
							obj = _003C_003Eu__1;
							obj3 = 9;
							goto IL_02af;
							IL_02af:
							while (true)
							{
								switch ((int)obj3)
								{
								case 6:
									return;
								case 5:
									break;
								case 11:
								{
									object obj4 = obj;
									((TaskCompletionSource)_003CConnect_003Ed__19.VerifyTracer())._002Ector();
									obj = obj4;
									obj3 = 0;
									if (((_003CHeartbeatAsync_003Ed__25*)(nint)_003CConnect_003Ed__19.CheckAdjustableCommand)->_003C_003E1__state == 0)
									{
										obj3 = 1;
									}
									continue;
								}
								case 4:
									((_003CHeartbeatAsync_003Ed__25)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)obj;
									obj3 = 5;
									if ((int)((_003CHeartbeatAsync_003Ed__25*)(nint)_003CHeartbeatAsync_003Ed__25._003C_003E4__this)->_003C_003Eu__1 == 0)
									{
										obj3 = 7;
									}
									continue;
								case 3:
								case 8:
									((IAsyncStateMachine)/*Error near IL_0368: Stack underflow*/).SetStateMachine((IAsyncStateMachine)(&obj));
									obj3 = 5;
									continue;
								default:
									obj = 1;
									_003C_003E4__this = (DesktopAuthentication)1;
									obj = 4;
									obj3 = obj;
									continue;
								case 10:
									goto IL_038a;
								case 7:
									_ = ref ReflectMixedRunner;
									((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CHeartbeatCircleAsync_003Ed__24, DesktopSession._003CLogoutAsync_003Ed__32>(ref this));
									_ = 6;
									continue;
								case 1:
									if (((TcpClient)/*Error near IL_03bb: Stack underflow*/).ConnectAsync((IPAddress)/*Error near IL_03bb: Stack underflow*/, (int)(&obj)) != null)
									{
										obj3 = 3;
										if ((int)((_003CReceiveAsync_003Ed__20*)(nint)_003CReceiveAsync_003Ed__20._003C_003E4__this)->_003C_003Eu__1 != 0)
										{
											obj3 = 0;
										}
										continue;
									}
									goto default;
								case 9:
									_003CReceiveAsync_003Ed__20.CheckCommonTracker = null;
									obj3 = 2;
									if (((_003CReceiveControlDataAsync_003Ed__22)_003CReceiveControlDataAsync_003Ed__22._003C_003Et__builder)._003C_003E4__this == null)
									{
										obj3 = 0;
									}
									continue;
								case 2:
									obj = -1;
									((_003CReceiveControlDataAsync_003Ed__22)this)._003C_003Eu__2 = (TaskAwaiter)(-1);
									obj3 = 8;
									if (((_003CReceiveDataAsync_003Ed__21*)(nint)_003CReceiveControlDataAsync_003Ed__22.DecorateBasicTag)->_003C_003E1__state == 0)
									{
										obj3 = 1;
									}
									continue;
								}
								break;
							}
							goto case 6;
						}
						break;
					}
					goto IL_0204;
					IL_025c:
					if ((nint)obj != 1)
					{
						num = 6;
						if ((int)((_003CConnect_003Ed__19*)_003CConnect_003Ed__19._003C_003E1__state)->_003C_003Et__builder == 0)
						{
							num = 6;
						}
						goto IL_0074;
					}
					goto IL_0204;
					IL_05d7:
					((_003CSendPacketAsync_003Ed__28)this)._003C_003E4__this = (DesktopAuthentication)(-2);
					obj2 = 2;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FFFD(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779290, new IntPtr(2737336583436L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_E000(object P_0)
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
		internal static byte _FF00_FF00_FF00_FF00_E100()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_E200()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779269, new IntPtr(2737336594876L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_E300()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_E400()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779268, new IntPtr(2737336606316L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CReceiveAsync_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopAuthentication _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object CheckCommonTracker;

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
		internal static bool StartTransformer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecoratePortableAggregator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00픀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779271, new IntPtr(2737336600076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00혀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0051: Expected Obj, but got I4
			//IL_0051: Expected Obj, but got Ref
			//IL_05dc: Expected Obj, but got Ref
			//IL_0076: Expected Obj, but got Ref
			//IL_05ee: Expected Obj, but got I4
			//IL_05f7: Expected Obj, but got I4
			//IL_00f0: Expected Obj, but got I4
			//IL_024b: Expected native int or pointer, but got Obj
			//IL_017d: Expected Obj, but got I4
			//IL_013a: Expected I4, but got Obj
			//IL_02ca: Expected Obj, but got I4
			//IL_02cf: Expected VT, but got I4
			//IL_02d9: Expected native int or pointer, but got Obj
			//IL_018a: Expected I, but got Obj
			//IL_018a: Expected Obj, but got Ref
			//IL_0199: Expected Obj, but got I
			//IL_0215: Expected Obj, but got I4
			//IL_01f9: Expected Obj, but got Ref
			//IL_02a1: Expected Obj, but got I4
			//IL_02a6: Expected Obj, but got I4
			//IL_02b0: Expected native int or pointer, but got Obj
			//IL_0065->IL0026: Incompatible stack types: I4 vs Obj
			//IL_05e6->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0097->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0255->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_0260->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_0282->IL00f9: Incompatible stack heights: 2 vs 1
			//IL_01c4->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_02e3->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_019e->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_021f->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_0235->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_0205->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_02ba->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_028d->IL00f9: Incompatible stack heights: 2 vs 1
			//IL_01cf->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_02ee->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_01a9->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_02c5->IL00f9: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object stateMachine = 5;
			while (true)
			{
				object obj = stateMachine;
				while (true)
				{
					switch ((int)obj)
					{
					case 2:
						return;
					default:
						((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP = -2;
						obj = 0;
						if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP == null)
						{
							obj = 1;
						}
						continue;
					case 4:
						stateMachine = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CserverId_003EP;
						obj = 3;
						if (Logger == null)
						{
							obj = 0;
						}
						continue;
					case 3:
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
								if (((DesktopAuthentication)(object)TokenKey)._client == null)
								{
									num = 0;
								}
								continue;
							default:
								{
									if (stateMachine == null)
									{
										stateMachine = 13;
										goto IL_00f5;
									}
									goto IL_0168;
								}
								IL_0168:
								if (((DesktopAuthentication)stateMachine)._buffer == null)
								{
									stateMachine = 6;
									goto IL_00f5;
								}
								goto IL_0235;
								IL_00f9:
								while (true)
								{
									switch ((int)obj2)
									{
									case 12:
										return;
									case 6:
										break;
									case 7:
										_ = ref stateMachine;
										/*Error near IL_0141: Member reference must be method, but was: Field*/;
									case 11:
									case 14:
										goto end_IL_00f9;
									case 4:
										((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshake = (nint)stateMachine;
										obj2 = 0;
										if (((DesktopAuthentication)DesktopAuthentication._handshakeSent)._handshakeKey == null)
										{
											obj2 = 0;
										}
										continue;
									case 1:
										((AsyncTaskMethodBuilder*)/*Error near IL_01b0: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)(&stateMachine));
										obj2 = 11;
										if (((DesktopAuthentication)DesktopAuthentication._encryptChaCha)._decryptChaCha == null)
										{
											obj2 = 2;
										}
										continue;
									case 9:
									case 13:
										stateMachine = PrepareDic;
										obj2 = 8;
										continue;
									case 5:
									{
										object exception = stateMachine;
										((DesktopAuthentication)stateMachine).Dispose();
										stateMachine = ((TaskCompletionSource)/*Error near IL_0213: Stack underflow*/).TrySetException((Exception)exception);
										obj2 = 7;
										continue;
									}
									case 8:
										((_003CAuthentication_003Ed__27)this)._003C_003E4__this = null;
										obj2 = 3;
										continue;
									case 2:
										goto IL_0235;
									default:
										_ = ref ((_003CAuthentication_003Ed__27)this)._003C_003Eu__2;
										((AsyncTaskMethodBuilder*)(&stateMachine))->Start(ref Unsafe.As<_003CReceiveAsync_003Ed__20, DesktopSession._003CEntityRequestAsync_003Ed__9>(ref this));
										_ = 12;
										if ((int)((_003CConnect_003Ed__19*)_003CConnect_003Ed__19._003C_003E1__state)->_003C_003Et__builder != 0)
										{
											_ = 7;
										}
										continue;
									case 10:
										stateMachine = 0;
										((_003CConnect_003Ed__19)this)._003C_003E4__this = (DesktopAuthentication)0;
										obj2 = 4;
										if (((_003CConnect_003Ed__19*)(nint)_003CConnect_003Ed__19.authServer)->_003Ccts_003E5__2 == null)
										{
											obj2 = 2;
										}
										continue;
									case 3:
										stateMachine = -1;
										((_003CConnect_003Ed__19)this)._003C_003Eu__1 = (TaskAwaiter)(-1);
										obj2 = 0;
										if (((_003CHeartbeatAsync_003Ed__25*)(nint)_003CConnect_003Ed__19.CheckAdjustableCommand)->_003C_003E1__state != 0)
										{
											obj2 = 1;
										}
										continue;
									}
									goto end_IL_00a9;
									continue;
									end_IL_00f9:
									break;
								}
								goto IL_0168;
								IL_00f5:
								obj2 = stateMachine;
								goto IL_00f9;
								IL_0235:
								stateMachine = new RuntimeHelpers[4096];
								obj2 = 5;
								if ((int)((_003CAuthentication_003Ed__27*)(nint)_003CAuthentication_003Ed__27._003Ccts_003E5__2)->_003C_003Eu__1 == 0)
								{
									obj2 = 5;
								}
								goto IL_00f9;
								end_IL_00a9:
								break;
							}
							break;
						}
						goto default;
					}
					case 1:
						((List<byte>)/*Error near IL_05dc: Stack underflow*/).AddRange((IEnumerable<byte>)Unsafe.AsPointer(ref ((_003CSendMessageAsync_003Ed__29)this)._003C_003Eu__1));
						obj = 2;
						continue;
					case 5:
						break;
					}
					break;
				}
				stateMachine = ((_003CSendPacketAsync_003Ed__28)this)._003C_003E1__state;
				stateMachine = 4;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00휀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779270, new IntPtr(2737336600076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FFFD(object P_0)
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779265, new IntPtr(2737336599036L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FFFD()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FFFD()
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
	private struct _003CReceiveControlDataAsync_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopAuthentication _003C_003E4__this;

		public byte[] data;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		internal static object DecorateBasicTag;

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
		internal static bool ReflectReadableDefinition()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CloseElement()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00준()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779264, new IntPtr(2737336587596L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00쨀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_005c: Expected I4, but got Obj
			//IL_0954: Expected Obj, but got Ref
			//IL_095e: Expected native int or pointer, but got Obj
			//IL_097c: Expected Obj, but got VT
			//IL_0986: Expected native int or pointer, but got Obj
			//IL_09a3: Expected Obj, but got I4
			//IL_09b5: Expected VT, but got I4
			//IL_09bf: Expected native int or pointer, but got Obj
			//IL_06e5: Expected Obj, but got Ref
			//IL_018a: Expected Obj, but got Ref
			//IL_06ce: Expected Obj, but got Ref
			//IL_0178: Expected VT, but got Obj
			//IL_017a: Expected Obj, but got I4
			//IL_04f4: Expected Obj, but got Ref
			//IL_0684: Expected Obj, but got I4
			//IL_0689: Expected Obj, but got I4
			//IL_0689: Expected Obj, but got Ref
			//IL_03fd: Expected Obj, but got I4
			//IL_0402: Expected VT, but got I4
			//IL_040c: Expected native int or pointer, but got Obj
			//IL_043b: Expected native int or pointer, but got Obj
			//IL_04b5: Expected native int or pointer, but got Obj
			//IL_0559: Expected native int or pointer, but got Obj
			//IL_0560: Expected native int or pointer, but got Obj
			//IL_0567: Expected native int or pointer, but got Obj
			//IL_056e: Expected native int or pointer, but got Obj
			//IL_0575: Expected native int or pointer, but got Obj
			//IL_0584: Expected Obj, but got VT
			//IL_0586: Expected Obj, but got I4
			//IL_058f: Expected Obj, but got I4
			//IL_0458: Expected VT, but got Obj
			//IL_0462: Expected native int or pointer, but got Obj
			//IL_02ae: Expected Obj, but got I4
			//IL_02b3: Expected Obj, but got I4
			//IL_0675: Expected Obj, but got I4
			//IL_0339: Expected Obj, but got I4
			//IL_0339: Expected native int or pointer, but got VT
			//IL_06b9: Expected Obj, but got I4
			//IL_06be: Expected Obj, but got I4
			//IL_06be: Expected Obj, but got Ref
			//IL_07b1: Expected Obj, but got I4
			//IL_07ac: Expected native int or pointer, but got Obj
			//IL_01d5: Expected Obj, but got Ref
			//IL_01fc: Expected Obj, but got I4
			//IL_0205: Expected Obj, but got I4
			//IL_070b: Expected Obj, but got I4
			//IL_0710: Expected Obj, but got I4
			//IL_07cc: Expected native int or pointer, but got Obj
			//IL_0699: Expected Obj, but got Ref
			//IL_06a4: Expected I4, but got Obj
			//IL_06af: Expected Obj, but got I4
			//IL_050a: Expected VT, but got Ref
			//IL_024b: Expected I4, but got Obj
			//IL_0737: Expected Obj, but got Ref
			//IL_0741: Expected native int or pointer, but got Obj
			//IL_0663: Expected Obj, but got Ref
			//IL_02c2: Expected Obj, but got I4
			//IL_038a: Expected VT, but got Obj
			//IL_0767: Expected native int or pointer, but got Obj
			//IL_0527: Expected native int or pointer, but got Obj
			//IL_05a5: Expected native int or pointer, but got Obj
			//IL_039b: Expected Obj, but got Ref
			//IL_053e: Expected native int or pointer, but got Obj
			//IL_01ab: Expected Obj, but got Ref
			//IL_01af: Expected Obj, but got I4
			//IL_03d7: Expected VT, but got I4
			//IL_03e3: Expected native int or pointer, but got Obj
			//IL_0792: Expected Obj, but got I4
			//IL_0623: Expected native int or pointer, but got Obj
			//IL_0643: Expected Obj, but got VT
			//IL_0643: Expected Obj, but got I4
			//IL_0643: Expected Obj, but got I4
			//IL_0304: Expected Obj, but got Ref
			//IL_04c9: Expected native int or pointer, but got Obj
			//IL_07e6: Expected Obj, but got I4
			//IL_031c: Unknown result type (might be due to invalid IL or missing references)
			//IL_031f: Expected Obj, but got Unknown
			//IL_0968->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0990->IL0026: Incompatible stack types: I4 vs Obj
			//IL_09ad->IL0026: Incompatible stack types: I4 vs Obj
			//IL_09c9->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0973->IL0026: Incompatible stack heights: 2 vs 1
			//IL_099b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_09d4->IL0026: Incompatible stack types: I4 vs Obj
			//IL_04b3->IL006a: Incompatible stack heights: 2 vs 1
			//IL_0348->IL006a: Incompatible stack heights: 2 vs 1
			//IL_0621->IL006a: Incompatible stack heights: 4 vs 1
			//IL_020a->IL0066: Incompatible stack heights: 0 vs 3
			//IL_06b4->IL0066: Incompatible stack heights: 0 vs 3
			//IL_026b->IL006a: Incompatible stack heights: 3 vs 1
			//IL_074b->IL006a: Incompatible stack heights: 4 vs 1
			//IL_066d->IL006a: Incompatible stack heights: 2 vs 1
			//IL_03ed->IL006a: Incompatible stack heights: 4 vs 1
			//IL_0797->IL0066: Incompatible stack heights: 0 vs 3
			//IL_064d->IL006a: Incompatible stack heights: 3 vs 1
			//IL_006a->IL006a: Incompatible stack heights: 4 vs 1
			//IL_07eb->IL0066: Incompatible stack heights: 0 vs 3
			//IL_0756->IL006a: Incompatible stack heights: 4 vs 1
			//IL_03f8->IL006a: Incompatible stack heights: 4 vs 1
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 3;
			object obj = awaiter;
			while (true)
			{
				switch ((int)obj)
				{
				default:
				{
					int num;
					switch ((int)awaiter)
					{
					default:
						num = 46;
						goto IL_006a;
					case 2:
						awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CgameVersion_003EP;
						num = 8;
						goto IL_006a;
					case 1:
						goto IL_0348;
					case 0:
						goto IL_06df;
						IL_006a:
						while (true)
						{
							switch (num)
							{
							default:
								return;
							case 3:
								awaiter = ((EqualityComparer<_00211>)awaiter).Equals((_00211?)awaiter, (_00211?)((_003C_003Ef__AnonymousType0<, >)awaiter).buy_type);
								num = 4;
								continue;
							case 9:
								break;
							case 30:
								return;
							case 49:
								awaiter = ((byte[])((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CserverId_003EP)[4];
								num = 24;
								if (Logger == null)
								{
									num = 7;
								}
								continue;
							case 19:
								if (((object)(&awaiter)).ToString() == null)
								{
									num = 17;
									if (((DesktopAuthentication)DesktopAuthentication._client)._connected == 0)
									{
										num = 7;
									}
									continue;
								}
								goto case 44;
							case 21:
								awaiter = 0;
								awaiter = 53;
								continue;
							case 52:
								((TcpClient)awaiter)._002Ector();
								((AsyncTaskMethodBuilder*)((AsyncTaskMethodBuilder*)((DesktopAuthentication)awaiter)._handshake)->Task)->Start<TStateMachine>(ref *(TStateMachine*)DesktopAuthentication._handshakeKey);
								((DesktopAuthentication)/*Error near IL_022c: Stack underflow*/)._encryptChaCha = (object)/*Error near IL_022c: Stack underflow*/;
								num = 20;
								continue;
							case 26:
								((AsyncTaskMethodBuilder*)/*Error near IL_0250: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<byte[]>*)awaiter, ref *(_003CReceiveControlDataAsync_003Ed__22*)((IEnumerable<byte>)((DesktopAuthentication)awaiter)._decryptChaCha).Skip((int)((DesktopAuthentication)awaiter)._handshakeTcs));
								_ = _003CAuthentication_003Ed__27._003C_003E1__state;
								_ = 8;
								Unsafe.Write(&((_003CAuthentication_003Ed__27*)null)->_003C_003E4__this, new DesktopAuthentication());
								_ = 18;
								continue;
							case 45:
								((DesktopAuthentication)/*Error near IL_0270: Stack underflow*/)._FF00_FF00_FF00_FF00_FF00_0600();
								awaiter = (object)/*Error near IL_0272: Stack underflow*/;
								num = 39;
								continue;
							case 55:
								Unsafe.As<string, AsyncTaskMethodBuilder>(ref ((_003CAuthentication_003Ed__27)this).serverIdHash).AwaitUnsafeOnCompleted(ref *(ValueTaskAwaiter*)(&awaiter), ref Unsafe.As<_003CReceiveControlDataAsync_003Ed__22, _003CSendMessageAsync_003Ed__29>(ref this));
								num = 0;
								if ((int)((_003CAuthentication_003Ed__27)_003CAuthentication_003Ed__27._003C_003Eu__1)._003C_003Eu__2 != 0)
								{
									num = 0;
								}
								continue;
							case 13:
								awaiter = -1;
								_003CAuthentication_003Ed__27.ReflectInternalAnnotation = -1;
								num = 31;
								continue;
							case 34:
								awaiter = 2;
								((_003CConnect_003Ed__19)this)._003C_003E1__state = 2;
								num = 35;
								continue;
							case 8:
								Unsafe.As<AsyncTaskMethodBuilder, @null>(ref ((_003CConnect_003Ed__19)this)._003C_003Et__builder) = null;
								num = 13;
								continue;
							case 42:
								Unsafe.As<EntityAuthServer, TaskAwaiter>(ref ((_003CConnect_003Ed__19)this).authServer) = default;
								num = 22;
								continue;
							case 59:
								((TaskCompletionSource)(&awaiter))._002Ector();
								num = 37;
								continue;
							case 58:
								((_003CHeartbeatAsync_003Ed__25*)/*Error near IL_0313: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_0313: Stack underflow*/);
								throw new CancellationTokenSource();
							case 16:
								Unsafe.Write(&((_003CHeartbeatAsync_003Ed__25*)(nint)((_003CHeartbeatAsync_003Ed__25)this)._003C_003Et__builder)->_003C_003Eu__1, (TaskAwaiter)((CancellationToken*)null)->Register((Action)16));
								_ = 52;
								continue;
							case 14:
								goto IL_0348;
							case 0:
								return;
							case 33:
							case 40:
								if (((byte[])((_003CHeartbeatCircleAsync_003Ed__24)this)._003C_003E1__state)[0] == 17)
								{
									num = 45;
									continue;
								}
								goto case 43;
							case 36:
								((_003CHeartbeatCircleAsync_003Ed__24)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)awaiter;
								num = 28;
								continue;
							case 44:
								((AsyncTaskMethodBuilder*)/*Error near IL_039b: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)(&awaiter));
								awaiter = (object)/*Error near IL_039d: Stack underflow*/;
								num = 7;
								if (_003CHeartbeatCircleAsync_003Ed__24.ReflectMixedRunner == null)
								{
									num = 4;
								}
								continue;
							case 54:
								_ = _003CReceiveAsync_003Ed__20._003C_003E1__state;
								_ = ((_003CReceiveAsync_003Ed__20)this)._003C_003Et__builder;
								_ = 4;
								awaiter = Task.Delay((TimeSpan)(((Array)(object)((_003CReceiveAsync_003Ed__20)this)._003C_003E4__this).Length - 4));
								_ = 6;
								if (((_003CReceiveControlDataAsync_003Ed__22*)(nint)_003CReceiveAsync_003Ed__20.CheckCommonTracker)->_003C_003E1__state != 0)
								{
									_ = 21;
								}
								continue;
							case 6:
								awaiter = -1;
								_003C_003Et__builder = (AsyncTaskMethodBuilder)(-1);
								num = 44;
								if (((_003CReceiveControlDataAsync_003Ed__22*)(nint)_003CReceiveControlDataAsync_003Ed__22._003C_003E4__this)->data != null)
								{
									num = 24;
								}
								continue;
							case 7:
								((_003CRemoteCallBackAsync_003Ed__23*)awaiter)->SetStateMachine((IAsyncStateMachine)awaiter);
								awaiter = Enumerable.Concat<TSource>((IEnumerable<TSource>)/*Error near IL_042f: Stack underflow*/, (IEnumerable<TSource>)/*Error near IL_042f: Stack underflow*/);
								num = 19;
								if (((_003CReceiveDataAsync_003Ed__21*)(nint)DecorateBasicTag)->_003C_003E1__state == 0)
								{
									num = 25;
								}
								continue;
							case 12:
								((_003CReceiveDataAsync_003Ed__21)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)awaiter;
								num = 20;
								if (((_003CReceiveDataAsync_003Ed__21*)(nint)_003CReceiveDataAsync_003Ed__21._003C_003E4__this)->buffer == null)
								{
									num = 55;
								}
								continue;
							case 32:
							case 53:
								if ((nint)awaiter >= ((Array)awaiter).Length)
								{
									num = 49;
									continue;
								}
								goto IL_05ba;
							case 2:
								_ = ref ((_003CReceiveDataAsync_003Ed__21)this)._003C_003Eu__1;
								((AsyncTaskMethodBuilder<EntityNetGameDetails>*)(&awaiter))->Start(ref Unsafe.As<_003CReceiveControlDataAsync_003Ed__22, DesktopSession._003CGetNetGameDetailsAsync_003Ed__53>(ref this));
								_ = 47;
								continue;
							case 10:
								if ((int)((_003CReceiveDataAsync_003Ed__21*)(nint)awaiter)->_003C_003Eu__2 == 0)
								{
									num = 1;
									if (((_003CRemoteCallBackAsync_003Ed__23*)(nint)_003CReceiveDataAsync_003Ed__21.CheckActiveRecommender)->_003C_003E1__state == 0)
									{
										num = 1;
									}
									continue;
								}
								goto case 50;
							case 4:
								((DefaultInterpolatedStringHandler*)/*Error near IL_04f4: Stack underflow*/)->AppendFormatted<T>((T)/*Error near IL_04f4: Stack underflow*/, (string?)(&awaiter));
								if ((int)/*Error near IL_04f9: Stack underflow*/ == 0)
								{
									num = 34;
									continue;
								}
								goto case 31;
							case 25:
								((DefaultInterpolatedStringHandler*)/*Error near IL_050a: Stack underflow*/)->AppendFormatted<T>((T)(&awaiter));
								if ((int)/*Error near IL_050f: Stack underflow*/ == 0)
								{
									num = 5;
									continue;
								}
								goto case 59;
							case 39:
							case 41:
								awaiter = awaiter;
								num = 38;
								if (((_003CRemoteCallBackAsync_003Ed__23*)(nint)_003CRemoteCallBackAsync_003Ed__23.payload)->_003C_003E4__this == null)
								{
									num = 8;
								}
								continue;
							case 46:
								if (_003CRemoteCallBackAsync_003Ed__23.ReflectScalableNotifier == null)
								{
									num = 16;
									continue;
								}
								goto case 10;
							case 11:
								((List<byte>)/*Error near IL_0557: Stack underflow*/).RemoveRange((int)/*Error near IL_0557: Stack underflow*/, (int)/*Error near IL_0557: Stack underflow*/);
								_ = ((_003CSendMessageAsync_003Ed__29*)(nint)awaiter)->_003C_003Et__builder;
								_ = ((_003CSendMessageAsync_003Ed__29*)(nint)awaiter)->_003C_003E4__this;
								_ = ((_003CSendMessageAsync_003Ed__29*)(nint)awaiter)->data;
								awaiter = BitConverter.ToUInt16((byte[])((_003CSendMessageAsync_003Ed__29*)(nint)awaiter)->_003C_003Eu__1, ((TaskAwaiter<int>*)_003CSendMessageAsync_003Ed__29.CheckAccessibleCalculator)->IsCompleted ? 1 : 0);
								awaiter = 19;
								continue;
							case 43:
								awaiter = ((DesktopSession)/*Error near IL_0599: Stack underflow*/).GetSkinByIdAsync((string)/*Error near IL_0599: Stack underflow*/);
								num = 10;
								if (((_003CSendPacketAsync_003Ed__28*)(nint)_003CSendPacketAsync_003Ed__28.data)->_003C_003E4__this != null)
								{
									num = 41;
								}
								continue;
							case 60:
								goto IL_05ba;
							case 20:
								((AsyncTaskMethodBuilder*)awaiter)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<object>*)((DesktopSession)awaiter)._skins, ref *(DesktopSession._003CEntityRequestAsync_003Ed__9*)((DesktopSession)awaiter)._skinTotal);
								((DesktopSession)/*Error near IL_0606: Stack underflow*/).EntityRequestAsync<object>((string)/*Error near IL_0606: Stack underflow*/, (object)/*Error near IL_0606: Stack underflow*/, (byte)/*Error near IL_0606: Stack underflow*/ != 0);
								_ = DesktopSession._003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed._003C_003E1__state;
								_ = 8;
								Unsafe.Write(&((DesktopSession._003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed*)1)->_003C_003E4__this, new DesktopSession());
								_ = 26;
								continue;
							case 50:
							case 57:
								_ = ((DesktopSession._003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed*)(nint)awaiter)->offset;
								_ = ((DesktopSession._003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed)this)._003CnetGames_003E5__2;
								((NeteaseSession)0)._002Ector((string)((Array)(object)((DesktopSession._003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed)this)._003CversionDictionary_003E5__3).Length, (string)((DesktopSession._003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed)this)._003C_003Eu__1, startHeartbeat: false);
								_ = 54;
								continue;
							case 31:
								_ = ((NeteaseSession)(&awaiter)).Token;
								_ = 27;
								continue;
							case 15:
								DesktopSession._003C_003Ec._003C_003E9 = (DesktopSession._003C_003Ec)1;
								num = 23;
								continue;
							case 5:
								awaiter = 1;
								DesktopSession._003C_003Ec._003C_003E9__15_2 = (Func<EntityNetGameItem, string>)1;
								num = 12;
								continue;
							case 24:
								awaiter = ((DesktopSession)/*Error near IL_06a4: Stack underflow*/).EntitiesRequestAsync<EntityItemDownload>((string)/*Error near IL_06a4: Stack underflow*/, (object)/*Error near IL_06a4: Stack underflow*/, (byte)(int)((DesktopSession)/*Error near IL_069f: Stack underflow*/).EntityRequestAsync<EntityItemDownload>((string)/*Error near IL_069f: Stack underflow*/, (object)DesktopSession._003C_003Ec._003C_003E9__15_3, true) != 0);
								awaiter = 3;
								continue;
							case 17:
								awaiter = 0;
								DesktopSession._003C_003Ec__DisplayClass16_0.IncludeEvent = 0;
								num = 36;
								continue;
							case 1:
								if (((byte[])((DesktopSession._003C_003Ec__DisplayClass56_0)Unsafe.AsPointer(ref this)).gameType)[0] != 0)
								{
									num = 33;
									continue;
								}
								goto case 15;
							case 51:
								goto IL_06df;
							case 22:
								awaiter = -1;
								((DesktopSession._003CAddGameCharacterAsync_003Ed__44)this)._003C_003E4__this = (DesktopSession)(-1);
								num = 59;
								continue;
							case 28:
								_ = ref ((DesktopSession._003CAddGameCharacterAsync_003Ed__44)this).type;
								_ = ref awaiter;
								Task.WhenAll((Task<Entities<EntityNetGameItem>>[])Unsafe.AsPointer(ref this));
								_ = 30;
								if ((int)((DesktopSession._003CAddGameCharacterAsync_003Ed__44*)(nint)DesktopSession._003CAddGameCharacterAsync_003Ed__44.name)->_003C_003Eu__1 == 0)
								{
									_ = 25;
								}
								continue;
							case 38:
								goto IL_0765;
							case 56:
								Unsafe.As<int, @null>(ref ((DesktopSession._003CAddRentalGameCharacterAsync_003Ed__45)this)._003C_003E1__state) = null;
								awaiter = 6;
								continue;
							case 35:
								((DesktopSession._003CAddRentalGameCharacterAsync_003Ed__45)this)._003C_003E4__this = (DesktopSession)awaiter;
								num = 2;
								continue;
							case 18:
								Unsafe.Write(&((DesktopSession._003CAddRentalGameCharacterAsync_003Ed__45*)(nint)awaiter)->gameId, (string)1);
								num = 11;
								continue;
							case 47:
								return;
							case 23:
								goto IL_07ca;
							case 27:
							case 29:
							case 37:
							case 48:
								goto end_IL_004b;
							}
							break;
							IL_07ca:
							if (((DesktopSession._003CAddRentalGameCharacterAsync_003Ed__45*)(nint)awaiter)->name == null)
							{
								awaiter = 29;
								continue;
							}
							/*Error near IL_07f0: Member reference must be method, but was: Field*/;
							IL_0765:
							if (DesktopSession._003CAddGameCharacterAsync_003Ed__44.DecorateEditableInitializer == null)
							{
								num = 50;
								continue;
							}
							_ = 19;
							_ = 3;
							/*Error near IL_081c: Member reference must be method, but was: Field*/;
							IL_05ba:
							if (((byte[])((_003CSendPacketAsync_003Ed__28)this)._003C_003Eu__1)[awaiter] == ((byte[])awaiter)[awaiter])
							{
								awaiter++;
								num = 32;
								continue;
							}
							num = 24;
							if (((DesktopSession)_003CSendPacketAsync_003Ed__28.CheckIterableSynchronizer)._netGames == null)
							{
								num = 58;
							}
						}
						goto case 2;
						IL_06df:
						awaiter = DesktopSession._003C_003Ec__DisplayClass56_0.ObserveContainer;
						num = 56;
						if ((int)((DesktopSession._003CAddGameCharacterAsync_003Ed__44*)DesktopSession._003CAddGameCharacterAsync_003Ed__44._003C_003E1__state)->_003C_003Et__builder == 0)
						{
							num = 2;
						}
						goto IL_006a;
						IL_0348:
						awaiter = _003CHeartbeatAsync_003Ed__25.ProcessResolver;
						num = 42;
						goto IL_006a;
						end_IL_004b:
						break;
					}
					break;
				}
				case 1:
					_ = ((EntityItemDownload)Unsafe.AsPointer(ref ((DesktopSession._003CEntityRequestAsync_003Ed__9)this).checkCode)).SubEntities;
					_ = 4;
					if (((DesktopSession._003CGetAuthItemsAsync_003Ed__48*)(nint)DesktopSession._003CEntityRequestAsync_003Ed__9.CheckDetailedTemplate)->_003C_003E1__state != 0)
					{
						_ = 2;
					}
					continue;
				case 4:
					return;
				case 2:
					awaiter = ((DesktopSession._003CGetAuthItemsAsync_003Ed__48)this)._003C_003Et__builder;
					obj = 0;
					if (((DesktopSession._003CGetAuthItemsAsync_003Ed__48*)(nint)DesktopSession._003CGetAuthItemsAsync_003Ed__48._003C_003E4__this)->masterType != 0)
					{
						obj = 0;
					}
					continue;
				case 3:
					awaiter = ((DesktopSession._003CGetAuthItemsAsync_003Ed__48)this).gameVersion;
					obj = 2;
					continue;
				case 5:
					break;
				}
				((DesktopSession._003CGetAuthItemsAsync_003Ed__48)this)._003C_003Eu__1 = (TaskAwaiter<EntityAuthItem>)(-2);
				obj = 1;
				if (((DesktopSession._003CGetBuyItemResultAsync_003Ed__28*)(nint)DesktopSession._003CGetAuthItemsAsync_003Ed__48.LeadRecommender)->_003C_003E1__state == 0)
				{
					obj = 1;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00쬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779267, new IntPtr(2737336577196L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00찀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779266, new IntPtr(2737336583436L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00촀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00츀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779277, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00케()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00퀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779276, new IntPtr(2737336596956L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00턀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779279, new IntPtr(2737336606316L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00툀()
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
	private struct _003CReceiveDataAsync_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopAuthentication _003C_003E4__this;

		public byte[] buffer;

		private TaskAwaiter<int> _003C_003Eu__1;

		private nint _003Clength_003E5__2;

		private TaskAwaiter _003C_003Eu__2;

		internal static object CheckActiveRecommender;

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
		internal static bool ControlWriter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectLiteralDistributor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00봀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779278, new IntPtr(2737336583436L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00븀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_00b1: Expected Obj, but got Ref
			//IL_00b3: Expected Obj, but got I
			//IL_004e: Expected Obj, but got Ref
			//IL_0075: Expected Obj, but got Ref
			//IL_007a: Expected VT, but got Ref
			//IL_00a1: Expected Obj, but got I4
			//IL_00a1: Expected Obj, but got Ref
			//IL_0567: Expected Obj, but got VT
			//IL_00e9: Expected Obj, but got I
			//IL_0578: Expected Obj, but got Ref
			//IL_057a: Expected Obj, but got VT
			//IL_05e4: Expected native int or pointer, but got Obj
			//IL_05ee: Expected Obj, but got I4
			//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0619: Expected Obj, but got I4
			//IL_061e: Expected VT, but got I4
			//IL_01a2: Expected Obj, but got I4
			//IL_01a7: Expected Obj, but got I4
			//IL_01a7: Expected Obj, but got Ref
			//IL_016f: Expected Obj, but got Ref
			//IL_0281: Expected Obj, but got Ref
			//IL_054a: Expected native int or pointer, but got Obj
			//IL_01c8: Expected native int or pointer, but got Obj
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Expected Obj, but got Unknown
			//IL_02ca: Expected native int or pointer, but got Obj
			//IL_02d4: Expected Obj, but got VT
			//IL_02d5: Invalid comparison between Unknown and I4
			//IL_020b: Expected native int or pointer, but got Obj
			//IL_021c: Expected Obj, but got VT
			//IL_02a2: Expected native int or pointer, but got Obj
			//IL_02ae: Expected Obj, but got I4
			//IL_02b3: Expected Obj, but got VT
			//IL_02b9: Expected Obj, but got I4
			//IL_02b9: Expected Ref, but got VT
			//IL_05cc: Expected Obj, but got I4
			//IL_0596: Expected Obj, but got Ref
			//IL_059d: Expected Obj, but got Ref
			//IL_05a4: Expected VT, but got I4
			//IL_05a4: Expected VT, but got I4
			//IL_05a4: Expected Obj, but got I
			//IL_05a9: Expected Ref, but got VT
			//IL_05ab: Expected Obj, but got I4
			//IL_0604: Expected Obj, but got I4
			//IL_0259: Expected native int or pointer, but got Obj
			//IL_0438: Expected Obj, but got I
			//IL_0333: Expected native int or pointer, but got Obj
			//IL_0162: Expected I4, but got Obj
			//IL_0447: Expected Obj, but got I4
			//IL_044c: Expected VT, but got I4
			//IL_03d5: Expected Obj, but got I4
			//IL_041b: Expected native int or pointer, but got Obj
			//IL_03df: Expected Obj, but got I4
			//IL_03e4: Expected VT, but got I4
			//IL_03ee: Expected native int or pointer, but got Obj
			//IL_046e: Expected Obj, but got Ref
			//IL_037d: Expected I4, but got Obj
			//IL_00c7->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008e->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00ab->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00d2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0571->IL00fd: Incompatible stack types: I4 vs Obj
			//IL_00ee->IL00fd: Incompatible stack types: I4 vs Obj
			//IL_0099->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00f9->IL00fd: Incompatible stack types: I4 vs Obj
			//IL_0584->IL00fd: Incompatible stack types: I4 vs Obj
			//IL_0632->IL00fd: Incompatible stack types: I4 vs Obj
			//IL_01bb->IL00fd: Incompatible stack types: I4 vs Obj
			//IL_0614->IL00fd: Incompatible stack types: I4 vs Obj
			//IL_0179->IL00fd: Incompatible stack types: I4 vs Obj
			//IL_0554->IL00fd: Incompatible stack types: I4 vs Obj
			//IL_01e5->IL00fd: Incompatible stack heights: 3 vs 1
			//IL_0237->IL00fd: Incompatible stack heights: 4 vs 1
			//IL_02c8->IL00fd: Incompatible stack types: I4 vs Obj
			//IL_05b5->IL00fd: Incompatible stack types: I4 vs Obj
			//IL_0315->IL00fd: Incompatible stack types: I4 vs Obj
			//IL_063d->IL00fd: Incompatible stack types: I4 vs Obj
			//IL_01c6->IL00fd: Incompatible stack types: I4 vs Obj
			//IL_027a->IL00fd: Incompatible stack heights: 3 vs 1
			//IL_0290->IL00fd: Incompatible stack types: I4 vs Obj
			//IL_055f->IL00fd: Incompatible stack types: I4 vs Obj
			//IL_02ee->IL00fd: Incompatible stack types: I4 vs Obj
			//IL_0242->IL00fd: Incompatible stack heights: 4 vs 1
			//IL_05e2->IL00fd: Incompatible stack types: I4 vs Obj
			//IL_0442->IL034c: Incompatible stack types: I4 vs Obj
			//IL_033d->IL034c: Incompatible stack types: I4 vs Obj
			//IL_0320->IL00fd: Incompatible stack types: I4 vs Obj
			//IL_02f9->IL00fd: Incompatible stack types: I4 vs Obj
			//IL_0348->IL034c: Incompatible stack types: I4 vs Obj
			//IL_0456->IL034c: Incompatible stack types: I4 vs Obj
			//IL_0425->IL034c: Incompatible stack heights: 2 vs 1
			//IL_04a4->IL034c: Incompatible stack types: I4 vs Obj
			//IL_0467->IL034c: Incompatible stack types: I4 vs Obj
			//IL_03f8->IL034c: Incompatible stack types: I4 vs Obj
			//IL_03b1->IL034c: Incompatible stack types: I4 vs Obj
			//IL_0430->IL034c: Incompatible stack heights: 2 vs 1
			//IL_0403->IL034c: Incompatible stack types: I4 vs Obj
			//IL_03bc->IL034c: Incompatible stack types: I4 vs Obj
			//IL_0487->IL034c: Incompatible stack types: I4 vs Obj
			//IL_0492->IL034c: Incompatible stack types: I4 vs Obj
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
				case 1:
					awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
					obj = 0;
					if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP != null)
					{
						obj = 0;
					}
					break;
				case 4:
					((EqualityComparer<_00210>)/*Error near IL_007a: Stack underflow*/).GetHashCode((_00210)Unsafe.AsPointer(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CserverId_003EP));
					_ = 2;
					if (TokenKey != null)
					{
						_ = 2;
					}
					break;
				case 5:
					((DesktopAuthentication)Unsafe.AsPointer(ref this))._client = -2;
					obj = 4;
					break;
				default:
					awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._connected;
					obj = 3;
					if (((DesktopAuthentication)(object)DesktopAuthentication._buffer)._handshake != 0)
					{
						obj = 3;
					}
					break;
				case 3:
					if (awaiter != null)
					{
						obj2 = 0;
						if (((DesktopAuthentication)DesktopAuthentication._handshakeSent)._handshakeKey == null)
						{
							obj2 = 0;
						}
						goto IL_00fd;
					}
					goto IL_055f;
				case 2:
					return;
					IL_055f:
					awaiter = ((_003CSendPacketAsync_003Ed__28)this)._003C_003Eu__1;
					obj2 = 14;
					goto IL_00fd;
					IL_00fd:
					while (true)
					{
						object obj3;
						switch ((int)obj2)
						{
						case 20:
							break;
						case 10:
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptedToken = awaiter;
							obj2 = 21;
							continue;
						case 13:
							return;
						case 5:
							awaiter = -1;
							((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeTcs = -1;
							obj2 = 1;
							if (PrepareDic == null)
							{
								obj2 = 1;
							}
							continue;
						case 15:
							_ = ((_003CAuthentication_003Ed__27*)(nint)awaiter)->_003C_003E1__state;
							_ = 0;
							((IAsyncStateMachine)(2 + ((_003CAuthentication_003Ed__27)this)._003C_003Et__builder)).MoveNext();
							_ = 16;
							continue;
						case 17:
							_ = ((_003CAuthentication_003Ed__27*)(nint)awaiter)->_003Ccts_003E5__2;
							_ = 2;
							((Task)((_003CAuthentication_003Ed__27)this)._003C_003Eu__1).GetAwaiter();
							awaiter = MassService.Instance;
							_ = 2;
							if ((int)((_003CConnect_003Ed__19*)_003CConnect_003Ed__19._003C_003E1__state)->_003C_003Et__builder != 0)
							{
								_ = 7;
							}
							continue;
						case 9:
							throw new TimeSpan((double)/*Error near IL_0256: Stack underflow*/);
						case 6:
							_ = ((_003CConnect_003Ed__19*)(nint)awaiter)->authServer;
							_ = ((TaskCompletionSource)(object)((IEnumerable<EntityNetGameItem>)((_003CConnect_003Ed__19)this)._003Ccts_003E5__2).FirstOrDefault((Func<EntityNetGameItem, bool>)awaiter)).Task;
							_ = 8;
							continue;
						case 11:
							if ((int)((CancellationTokenSource)(&awaiter)).Token != 0)
							{
								obj2 = 3;
								continue;
							}
							goto case 4;
						case 19:
						{
							AsyncTaskMethodBuilder asyncTaskMethodBuilder = ((_003CHeartbeatAsync_003Ed__25*)(nint)awaiter)->_003C_003Et__builder;
							((IDisposable)((CancellationToken*)null)->Register((Action)2)).Dispose();
							((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->SetException((Exception)0);
							((_003CHeartbeatCircleAsync_003Ed__24*)(nint)/*Error near IL_02be: Stack underflow*/)->_003C_003E1__state = (int)Unsafe.AsPointer(ref this);
							obj2 = 2;
							continue;
						}
						case 8:
						case 16:
							((AsyncTaskMethodBuilder*)/*Error near IL_02d4: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)((_003CHeartbeatCircleAsync_003Ed__24*)(nint)awaiter)->_003C_003Et__builder);
							if ((int)/*Error near IL_02da: Stack underflow*/ < 2)
							{
								obj2 = 18;
								if (_003CHeartbeatCircleAsync_003Ed__24.ReflectMixedRunner == null)
								{
									obj2 = 20;
								}
								continue;
							}
							goto case 19;
						default:
							if ((nint)awaiter != 1)
							{
								obj2 = 10;
								if ((int)((_003CReceiveAsync_003Ed__20*)_003CReceiveAsync_003Ed__20._003C_003E1__state)->_003C_003Et__builder != 0)
								{
									obj2 = 22;
								}
								continue;
							}
							goto case 7;
						case 23:
							if ((nint)awaiter != 1)
							{
								obj3 = 1;
								if ((int)((_003CReceiveAsync_003Ed__20*)(nint)_003CReceiveAsync_003Ed__20._003C_003E4__this)->_003C_003Eu__1 == 0)
								{
									obj3 = 1;
								}
								goto IL_034c;
							}
							goto IL_0430;
						case 14:
							Unsafe.As<AsyncTaskMethodBuilder, TaskAwaiter<EntityItemDownload[]>>(ref ((_003CSendPacketAsync_003Ed__28)this)._003C_003Et__builder) = default;
							obj2 = 0;
							if (((_003CSendPacketAsync_003Ed__28*)(nint)_003CSendPacketAsync_003Ed__28.data)->_003C_003E4__this != null)
							{
								obj2 = 5;
							}
							continue;
						case 12:
							goto IL_055f;
						case 1:
						case 3:
							awaiter = ((Task<int>)(&awaiter)).GetAwaiter();
							obj2 = 18;
							continue;
						case 22:
						{
							bool isCompleted = ((ValueTaskAwaiter*)((DesktopSession)awaiter)._netGames)->IsCompleted;
							((ValueTaskAwaiter*)((Stream)((DesktopSession)Unsafe.AsPointer(ref this))._skinTotal).WriteAsync((ReadOnlyMemory<byte>)0, (CancellationToken)((Array)((DesktopSession)Unsafe.AsPointer(ref this)).UserDetail__BackingField).Length))->GetResult();
							awaiter = isCompleted;
							obj2 = 11;
							continue;
						}
						case 21:
							Unsafe.As<AsyncTaskMethodBuilder<Entities<EntityNetGameItem>>, AsyncTaskMethodBuilder<bool>>(ref ((DesktopSession._003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed)this)._003C_003Et__builder).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CReceiveDataAsync_003Ed__21, DesktopSession._003CGetBuyItemResultAsync_003Ed__28>(ref this));
							awaiter = 13;
							goto IL_00f9;
						case 18:
							if (awaiter != null)
							{
								obj2 = 6;
								continue;
							}
							goto case 9;
						case 2:
							((BinaryWriter)/*Error near IL_05ee: Stack underflow*/).Write((byte[])((DesktopSession._003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed*)(nint)awaiter)->offset);
							if (/*Error near IL_05fb: Stack underflow*/ >= 2 + ((DesktopSession._003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed)this)._003CversionDictionary_003E5__3)
							{
								awaiter = 17;
								goto IL_00f9;
							}
							break;
						case 7:
							obj2 = 23;
							continue;
						case 4:
							{
								awaiter = 0;
								((DesktopSession._003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed)this)._003C_003Eu__1 = (TaskAwaiter<Entities<EntityNetGameItem>>)0;
								obj2 = 6;
								if (DesktopSession._003C_003CGetNetGamesAsync_003Eg__GetNetGamesAsync_007C15_1_003Ed.UpdateRecord != null)
								{
									obj2 = 10;
								}
								continue;
							}
							IL_00f9:
							obj2 = awaiter;
							continue;
							IL_0430:
							awaiter = _003Clength_003E5__2;
							obj3 = 9;
							goto IL_034c;
							IL_034c:
							while (true)
							{
								switch ((int)obj3)
								{
								case 2:
									break;
								case 3:
									return;
								case 9:
									_003CReceiveAsync_003Ed__20.CheckCommonTracker = null;
									obj3 = 0;
									if (((_003CReceiveControlDataAsync_003Ed__22)_003CReceiveControlDataAsync_003Ed__22._003C_003Et__builder)._003C_003E4__this == null)
									{
										obj3 = 0;
									}
									continue;
								case 1:
								{
									object bytes = awaiter;
									((_003CRemoteCallBackAsync_003Ed__23*)awaiter)->MoveNext();
									awaiter = ((byte[])/*Error near IL_03ca: Stack underflow*/).Xor((byte[])bytes);
									awaiter = 10;
									obj3 = awaiter;
									continue;
								}
								case 7:
									awaiter = 1;
									((_003CReceiveControlDataAsync_003Ed__22)this)._003C_003Eu__2 = (TaskAwaiter)1;
									obj3 = 0;
									if (((_003CReceiveDataAsync_003Ed__21*)(nint)_003CReceiveControlDataAsync_003Ed__22.DecorateBasicTag)->_003C_003E1__state != 0)
									{
										obj3 = 5;
									}
									continue;
								case 4:
									_ = ref _003C_003Et__builder;
									((AsyncTaskMethodBuilder<EntityItemDownload[]>*)(&awaiter))->Start(ref Unsafe.As<_003CReceiveDataAsync_003Ed__21, DesktopSession._003CGetItemDownloadAsync_003Ed__50>(ref this));
									_ = 3;
									if ((int)((_003CReceiveDataAsync_003Ed__21*)(nint)_003CReceiveDataAsync_003Ed__21.buffer)->_003C_003Eu__1 == 0)
									{
										_ = 3;
									}
									continue;
								case 8:
									goto IL_0430;
								default:
									awaiter = -1;
									_003C_003Eu__2 = (TaskAwaiter)(-1);
									obj3 = 6;
									continue;
								case 6:
									Unsafe.Write((void*)(nint)/*Error near IL_045d: Stack underflow*/, new DefaultInterpolatedStringHandler((int)/*Error near IL_045d: Stack underflow*/, (int)(&awaiter)));
									obj3 = 2;
									continue;
								case 10:
									((DefaultInterpolatedStringHandler*)/*Error near IL_046e: Stack underflow*/)->AppendLiteral((string)(&awaiter));
									if ((int)/*Error near IL_0473: Stack underflow*/ == 0)
									{
										obj3 = 7;
										if (((_003CRemoteCallBackAsync_003Ed__23)_003CRemoteCallBackAsync_003Ed__23._003C_003Et__builder).sid == 0)
										{
											obj3 = 5;
										}
										continue;
									}
									goto case 6;
								case 5:
									((_003CRemoteCallBackAsync_003Ed__23)this).payload = (byte[])awaiter;
									obj3 = 4;
									continue;
								}
								break;
							}
							goto case 15;
						}
						break;
					}
					goto case 5;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00뼀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779273, new IntPtr(2737336605276L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00쀀(object P_0)
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
		internal static byte _FF00_FF00_FF00_FF00섀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00숀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779272, new IntPtr(2737336594876L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00쌀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00쐀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779275, new IntPtr(2737336594876L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRemoteCallBackAsync_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ushort sid;

		public byte[] payload;

		public DesktopAuthentication _003C_003E4__this;

		internal static object ReflectScalableNotifier;

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
		internal static bool CheckModularTask()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectGroupedViewer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00딀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779274, new IntPtr(2737336583436L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00똀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_003f: Expected I4, but got Obj
			//IL_04a1: Expected VT, but got I4
			//IL_005c: Expected Obj, but got Ref
			//IL_0088: Expected Obj, but got Ref
			//IL_004a: Expected Obj, but got Ref
			//IL_01b6: Expected Obj, but got Ref
			//IL_0237: Expected native int or pointer, but got Obj
			//IL_0316: Expected Obj, but got I4
			//IL_01ed: Expected native int or pointer, but got Obj
			//IL_024f: Expected Obj, but got I4
			//IL_02e7: Expected Obj, but got I4
			//IL_02f1: Expected native int or pointer, but got Obj
			//IL_025b: Expected native int or pointer, but got Obj
			//IL_031d: Expected native int or pointer, but got Obj
			//IL_0350: Expected Obj, but got I4
			//IL_035a: Expected native int or pointer, but got Obj
			//IL_02cf: Expected native int or pointer, but got Obj
			//IL_0148: Expected Obj, but got I
			//IL_0379: Expected Obj, but got VT
			//IL_03a5: Expected Obj, but got I4
			//IL_03a7: Expected Obj, but got VT
			//IL_03b3: Expected Obj, but got I4
			//IL_03c2: Expected Obj, but got I4
			//IL_03d3: Expected Obj, but got Ref
			//IL_03e3: Expected Obj, but got Ref
			//IL_03e3: Expected Obj, but got I4
			//IL_00f9: Expected I4, but got Obj
			//IL_04ab->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0075->IL0026: Incompatible stack heights: 3 vs 1
			//IL_0094->IL0098: Incompatible stack types: I4 vs Obj
			//IL_0056->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0080->IL0026: Incompatible stack heights: 3 vs 1
			//IL_0241->IL0098: Incompatible stack types: I4 vs Obj
			//IL_01b0->IL0098: Incompatible stack types: I4 vs Obj
			//IL_01f7->IL0098: Incompatible stack types: I4 vs Obj
			//IL_0259->IL0098: Incompatible stack types: I4 vs Obj
			//IL_02fb->IL0098: Incompatible stack types: I4 vs Obj
			//IL_0364->IL0098: Incompatible stack types: I4 vs Obj
			//IL_01d1->IL0098: Incompatible stack types: I4 vs Obj
			//IL_0346->IL0098: Incompatible stack types: I4 vs Obj
			//IL_024c->IL0098: Incompatible stack types: I4 vs Obj
			//IL_02d9->IL0098: Incompatible stack types: I4 vs Obj
			//IL_0202->IL0098: Incompatible stack types: I4 vs Obj
			//IL_0197->IL0098: Incompatible stack types: I4 vs Obj
			//IL_014d->IL0098: Incompatible stack types: I4 vs Obj
			//IL_0306->IL0098: Incompatible stack types: I4 vs Obj
			//IL_038d->IL0098: Incompatible stack types: I4 vs Obj
			//IL_027b->IL0098: Incompatible stack types: I4 vs Obj
			//IL_02bd->IL0098: Incompatible stack types: I4 vs Obj
			//IL_03f7->IL0098: Incompatible stack heights: 2 vs 1
			//IL_0333->IL0098: Incompatible stack types: I4 vs Obj
			//IL_036f->IL0098: Incompatible stack types: I4 vs Obj
			//IL_01dc->IL0098: Incompatible stack types: I4 vs Obj
			//IL_02e4->IL0098: Incompatible stack types: I4 vs Obj
			//IL_01a2->IL0098: Incompatible stack types: I4 vs Obj
			//IL_0158->IL0098: Incompatible stack types: I4 vs Obj
			//IL_0398->IL0098: Incompatible stack types: I4 vs Obj
			//IL_0286->IL0098: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				case 4:
					obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
					obj2 = 3;
					continue;
				case 2:
					_ = ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserToken_003EP;
					_ = EqualityComparer<_00210>.Default;
					_ = 0;
					if (Crc32 != null)
					{
						_ = 0;
					}
					continue;
				case 0:
					return;
				case 3:
				{
					obj = Logger;
					object obj3 = 9;
					while (true)
					{
						switch ((int)obj3)
						{
						case 13:
							if ((nint)obj != 4)
							{
								obj3 = 2;
								if (((DesktopAuthentication)DesktopAuthentication._connected)._buffer == null)
								{
									obj3 = 0;
								}
								continue;
							}
							goto case 3;
						case 12:
						case 14:
							if (obj != null)
							{
								obj3 = 0;
								if (((DesktopAuthentication)DesktopAuthentication._handshakeKey)._encryptedToken == null)
								{
									obj3 = 0;
								}
								continue;
							}
							break;
						case 6:
						case 7:
						case 8:
							obj = obj;
							obj3 = 20;
							continue;
						default:
							if (((byte[])((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptChaCha)[0] != 0)
							{
								obj3 = 4;
								if (((DesktopAuthentication)DesktopAuthentication._decryptChaCha)._handshakeTcs == null)
								{
									obj3 = 4;
								}
								continue;
							}
							goto case 17;
						case 11:
							obj = ((DesktopAuthentication)/*Error near IL_01e1: Stack underflow*/).SendPacketAsync((byte)/*Error near IL_01e1: Stack underflow*/, (object)/*Error near IL_01e1: Stack underflow*/);
							obj3 = 7;
							if (((_003CAuthentication_003Ed__27*)(nint)PrepareDic)->_003C_003E1__state == 0)
							{
								obj3 = 4;
							}
							continue;
						case 3:
							((DesktopAuthentication)/*Error near IL_022b: Stack underflow*/)._FF00_FF00_FF00_FF00_FF00_0600();
							obj = (object)/*Error near IL_022d: Stack underflow*/;
							obj3 = 2;
							if (((_003CAuthentication_003Ed__27*)(nint)_003CAuthentication_003Ed__27.serverIdHash)->_003Ccts_003E5__2 != null)
							{
								obj3 = 8;
							}
							continue;
						case 15:
							obj = 1;
							obj3 = 14;
							continue;
						case 17:
						{
							TaskAwaiter<byte[]> taskAwaiter = ((_003CAuthentication_003Ed__27*)(nint)obj)->_003C_003Eu__1;
							if ((int)taskAwaiter == 0)
							{
								obj3 = 0;
								if (_003CAuthentication_003Ed__27.ReflectInternalAnnotation == null)
								{
									obj3 = 1;
								}
								continue;
							}
							((AsyncTaskMethodBuilder*)/*Error near IL_0379: Stack underflow*/)->SetException((Exception)taskAwaiter);
							obj3 = 17;
							if ((int)((_003CHeartbeatCircleAsync_003Ed__24*)_003CHeartbeatCircleAsync_003Ed__24._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								obj3 = 19;
							}
							continue;
						}
						case 18:
							if ((nint)obj == 9)
							{
								obj3 = 15;
								continue;
							}
							goto case 16;
						case 9:
							if ((nint)obj != 1)
							{
								obj3 = 17;
								if (((_003CConnect_003Ed__19*)(nint)_003CConnect_003Ed__19._003C_003E4__this)->authServer != null)
								{
									obj3 = 18;
								}
								continue;
							}
							goto case 15;
						case 16:
							obj = 0;
							obj3 = 12;
							if ((int)((_003CConnect_003Ed__19*)(nint)_003CConnect_003Ed__19._003Ccts_003E5__2)->_003C_003Eu__1 == 0)
							{
								obj3 = 2;
							}
							continue;
						case 5:
							((_003CHeartbeatAsync_003Ed__25*)/*Error near IL_030b: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_030b: Stack underflow*/);
							obj = (object)/*Error near IL_030d: Stack underflow*/;
							obj = 6;
							obj3 = obj;
							continue;
						case 20:
						{
							int num = ((_003CHeartbeatAsync_003Ed__25*)(nint)obj)->_003C_003E1__state;
							if (num == 0)
							{
								obj3 = 10;
								continue;
							}
							obj = new AsyncTaskMethodBuilder((IAsyncStateMachine)2);
							IPAddress iPAddress = IPAddress.Parse((string)_003CReceiveAsync_003Ed__20.StartTransformer());
							((_003CReceiveControlDataAsync_003Ed__22*)(&obj))->SetStateMachine((IAsyncStateMachine)((byte[])((_003CReceiveAsync_003Ed__20)this)._003C_003E1__state)[0]);
							((AsyncTaskMethodBuilder<string>*)(&obj))->Start(ref *(DesktopSession._003CDownloadImageAsync_003Ed__34*)iPAddress);
							((ILogger)18).Warning((Exception)(&obj), (string)_003CReceiveControlDataAsync_003Ed__22.CloseElement());
							((ILogger*)(&obj))->Debug((string)obj);
							((ILogger)/*Error near IL_03e3: Stack underflow*/).Error((Exception)num, (string)(&obj));
							((Encoding)/*Error near IL_03ed: Stack underflow*/).GetBytes((string)(object)new Encoding());
							_ = 22;
							continue;
						}
						case 2:
							if ((nint)obj == 16)
							{
								obj3 = 5;
								continue;
							}
							goto case 11;
						case 4:
						case 21:
							obj = ((byte[])((_003CHeartbeatAsync_003Ed__25)this)._003C_003Et__builder)[0];
							obj3 = 12;
							if ((int)((_003CHeartbeatAsync_003Ed__25*)(nint)_003CHeartbeatAsync_003Ed__25._003C_003E4__this)->_003C_003Eu__1 != 0)
							{
								obj3 = 13;
							}
							continue;
						case 1:
						case 10:
						case 19:
						case 22:
							break;
						}
						break;
					}
					break;
				}
				case 1:
					break;
				}
				((_003CReceiveDataAsync_003Ed__21)this)._003C_003Eu__2 = (TaskAwaiter)(-2);
				obj2 = 2;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00뜀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779381, new IntPtr(2737336600076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00렀(object P_0)
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
		internal static byte _FF00_FF00_FF00_FF00뤀()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00먀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779380, new IntPtr(2737336596956L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00묀()
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
	private struct _003CSendMessageAsync_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopAuthentication _003C_003E4__this;

		public byte[] data;

		private ValueTaskAwaiter _003C_003Eu__1;

		internal static object CheckAccessibleCalculator;

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
		internal static bool ReflectIsolatedDictionary()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectAutomatableMonitor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00ꘀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779383, new IntPtr(2737336583436L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_A700()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0065: Expected Obj, but got Ref
			//IL_008e: Expected Obj, but got I4
			//IL_008e: Expected Obj, but got Ref
			//IL_004f: Expected Obj, but got Ref
			//IL_005a: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got Ref
			//IL_0192: Expected native int or pointer, but got Obj
			//IL_0265: Expected VT, but got Obj
			//IL_022d: Expected Obj, but got Ref
			//IL_0239: Expected native int or pointer, but got Obj
			//IL_0128: Expected Obj, but got Ref
			//IL_013f: Expected Obj, but got I
			//IL_02de: Expected Obj, but got I4
			//IL_0202: Expected F8, but got Ref
			//IL_01d4: Expected Ref, but got VT
			//IL_02a9: Expected native int or pointer, but got Obj
			//IL_02b3: Expected Obj, but got I4
			//IL_02d4: Expected Obj, but got I4
			//IL_0283: Expected Obj, but got I4
			//IL_0288: Expected Obj, but got I4
			//IL_015c: Expected Obj, but got Ref
			//IL_0163: Expected Obj, but got Ref
			//IL_016b: Expected Obj, but got Ref
			//IL_017b: Expected native int or pointer, but got Obj
			//IL_01a6: Expected native int or pointer, but got Obj
			//IL_0211: Expected native int or pointer, but got Obj
			//IL_011d: Expected I4, but got Obj
			//IL_0074->IL0026: Incompatible stack heights: 3 vs 1
			//IL_00a2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0086->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ad->IL0026: Incompatible stack types: I4 vs Obj
			//IL_031a->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_00c9->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_0325->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_00d4->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_026f->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_01fb->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_0243->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_0144->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_02fe->IL00d8: Incompatible stack heights: 2 vs 1
			//IL_02ed->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_01e5->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_029c->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_0185->IL00d8: Incompatible stack heights: 8 vs 1
			//IL_01b0->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_024e->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_014f->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_021b->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_02a7->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_0190->IL00d8: Incompatible stack heights: 8 vs 1
			//IL_01bb->IL00d8: Incompatible stack types: I4 vs Obj
			//IL_0226->IL00d8: Incompatible stack types: I4 vs Obj
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 5;
			while (true)
			{
				object obj = awaiter;
				while (true)
				{
					object obj2;
					switch ((int)obj)
					{
					case 3:
						return;
					case 4:
						goto end_IL_0026;
					default:
						_ = ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserToken_003EP;
						_ = EqualityComparer<_00210>.Default;
						_ = 3;
						continue;
					case 5:
						awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CserverId_003EP;
						obj = 4;
						continue;
					case 1:
						break;
					case 2:
						{
							if (awaiter != null)
							{
								obj2 = 0;
								if (((DesktopAuthentication)DesktopAuthentication._client)._connected != 0)
								{
									obj2 = 0;
								}
								goto IL_00d8;
							}
							goto IL_02fe;
						}
						IL_00d8:
						while (true)
						{
							switch ((int)obj2)
							{
							case 14:
								return;
							case 6:
								break;
							case 5:
								Unsafe.As<List<byte>, AsyncTaskMethodBuilder>(ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._buffer).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CSendMessageAsync_003Ed__29, _003CHeartbeatAsync_003Ed__25>(ref this));
								obj2 = 14;
								if (((DesktopAuthentication)DesktopAuthentication._handshakeSent)._handshakeKey == null)
								{
									obj2 = 4;
								}
								continue;
							case 15:
								_ = ((DesktopAuthentication)awaiter)._encryptedToken;
								_ = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._encryptChaCha;
								_ = 0;
								_ = ((Array)((DesktopAuthentication)Unsafe.AsPointer(ref this))._decryptChaCha).Length;
								_ = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._handshakeTcs;
								_ = 0;
								_ = Log.Logger;
								_ = 6;
								if (((_003CAuthentication_003Ed__27*)(nint)PrepareDic)->_003C_003E1__state == 0)
								{
									_ = 11;
								}
								continue;
							default:
								if ((int)((_003CAuthentication_003Ed__27*)(nint)awaiter)->_003C_003Et__builder == 0)
								{
									obj2 = 1;
									if (((_003CAuthentication_003Ed__27*)(nint)_003CAuthentication_003Ed__27._003C_003E4__this)->modHashList != null)
									{
										obj2 = 1;
									}
									continue;
								}
								goto case 15;
							case 1:
							case 11:
								((AsyncTaskMethodBuilder*)((TaskAwaiter<byte[]>*)(ushort)((Array)(object)((_003CAuthentication_003Ed__27)this).serverIdHash).Length)->GetResult())->Start(ref *(DesktopSession._003CHeartbeatAsync_003Ed__7*)((_003CAuthentication_003Ed__27)this)._003C_003Eu__1);
								((AsyncTaskMethodBuilder*)/*Error near IL_01d9: Stack underflow*/)->Start(ref *(DesktopSession._003CEntityRequestAsync_003Ed__9*)/*Error near IL_01d9: Stack underflow*/);
								awaiter = (object)/*Error near IL_01db: Stack underflow*/;
								obj2 = 12;
								continue;
							case 3:
								Unsafe.As<int, @null>(ref ((_003CConnect_003Ed__19)this)._003C_003E1__state) = null;
								obj2 = 9;
								continue;
							case 10:
								if ((int)TimeSpan.FromSeconds((double)(nint)(&awaiter)) == 0)
								{
									obj2 = 5;
									if (((_003CConnect_003Ed__19*)(nint)_003CConnect_003Ed__19.authServer)->_003Ccts_003E5__2 == null)
									{
										obj2 = 13;
									}
									continue;
								}
								goto case 7;
							case 4:
								((TaskCompletionSource)(&awaiter))._002Ector();
								awaiter = (object)/*Error near IL_022f: Stack underflow*/;
								obj2 = 1;
								if (((_003CHeartbeatAsync_003Ed__25*)(nint)_003CConnect_003Ed__19.CheckAdjustableCommand)->_003C_003E1__state != 0)
								{
									obj2 = 10;
								}
								continue;
							case 2:
								((_003CHeartbeatAsync_003Ed__25)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)awaiter;
								obj2 = 5;
								continue;
							case 13:
								awaiter = 0;
								((_003CHeartbeatAsync_003Ed__25)this)._003C_003E4__this = (DesktopAuthentication)0;
								obj2 = 2;
								if (_003CHeartbeatAsync_003Ed__25.ProcessResolver == null)
								{
									obj2 = 2;
								}
								continue;
							case 12:
								((IAsyncStateMachine)/*Error near IL_02b3: Stack underflow*/).SetStateMachine((IAsyncStateMachine)((_003CHeartbeatCircleAsync_003Ed__24*)(nint)awaiter)->_003C_003E1__state);
								((AsyncTaskMethodBuilder*)/*Error near IL_02ba: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)awaiter);
								awaiter = null;
								awaiter = IPAddress.Parse((string)awaiter);
								awaiter = 4;
								obj2 = awaiter;
								continue;
							case 9:
								awaiter = -1;
								((_003CReceiveAsync_003Ed__20)this)._003C_003E1__state = -1;
								obj2 = 7;
								continue;
							case 7:
								((TcpClient)/*Error near IL_02f4: Stack underflow*/).ConnectAsync((IPAddress)/*Error near IL_02f4: Stack underflow*/, (int)(&awaiter));
								_ = 6;
								continue;
							case 8:
								goto end_IL_00d8;
							}
							goto end_IL_0026_2;
							continue;
							end_IL_00d8:
							break;
						}
						goto IL_02fe;
						IL_02fe:
						awaiter = ((_003CReceiveAsync_003Ed__20)this)._003C_003E4__this;
						obj2 = 3;
						if (_003CReceiveAsync_003Ed__20.CheckCommonTracker == null)
						{
							obj2 = 0;
						}
						goto IL_00d8;
						end_IL_0026_2:
						break;
					}
					Crc32 = -2;
					obj = 0;
					if (TokenKey == null)
					{
						obj = 0;
					}
					continue;
					end_IL_0026:
					break;
				}
				awaiter = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
				awaiter = 2;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00ꠀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779382, new IntPtr(2737336600076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00꤀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00ꨀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779377, new IntPtr(2737336602156L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_AB00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779376, new IntPtr(2737336583436L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00가()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00관()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00글()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779379, new IntPtr(2737336594876L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSendPacketAsync_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public byte id;

		public byte[] data;

		public DesktopAuthentication _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object CheckIterableSynchronizer;

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
		internal static bool CheckIntegratedEditor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateLocalSystem()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00鼀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779378, new IntPtr(2737336595916L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00ꀀ()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_037b: Expected Obj, but got Ref
			//IL_0384: Expected Obj, but got I4
			//IL_004e: Expected Obj, but got Ref
			//IL_0391: Expected Obj, but got VT
			//IL_0233: Expected Obj, but got I4
			//IL_0238: Expected VT, but got I4
			//IL_01d4: Expected Obj, but got Ref
			//IL_01de: Expected native int or pointer, but got Obj
			//IL_019f: Expected Obj, but got I4
			//IL_027d: Expected native int or pointer, but got Obj
			//IL_0262: Expected Obj, but got I4
			//IL_01f8: Expected Obj, but got I4
			//IL_01fd: Expected VT, but got I4
			//IL_0207: Expected native int or pointer, but got Obj
			//IL_00cd: Expected Obj, but got Ref
			//IL_00de: Expected Obj, but got I4
			//IL_0171: Expected native int or pointer, but got Obj
			//IL_00c2: Expected I4, but got Obj
			//IL_0365->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0389->IL0022: Incompatible stack heights: 1 vs 0
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_039b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0370->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0081->IL0085: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0242->IL0085: Incompatible stack types: I4 vs Obj
			//IL_01e8->IL0085: Incompatible stack heights: 2 vs 1
			//IL_022e->IL0085: Incompatible stack types: I4 vs Obj
			//IL_0167->IL01cd: Incompatible stack heights: 1 vs 0
			//IL_0287->IL0085: Incompatible stack types: I4 vs Obj
			//IL_01cd->IL0085: Incompatible stack types: I4 vs Obj
			//IL_0211->IL0085: Incompatible stack types: I4 vs Obj
			//IL_00e3->IL0081: Incompatible stack heights: 1 vs 0
			//IL_01f3->IL0085: Incompatible stack heights: 2 vs 1
			//IL_017b->IL0085: Incompatible stack heights: 2 vs 1
			//IL_0292->IL0085: Incompatible stack types: I4 vs Obj
			//IL_021c->IL0085: Incompatible stack types: I4 vs Obj
			//IL_0186->IL0085: Incompatible stack heights: 2 vs 1
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
					switch ((int)obj2)
					{
					case 4:
						obj = ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CuserId_003EP;
						obj2 = 1;
						if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP != null)
						{
							obj2 = 1;
						}
						continue;
					case 1:
						if (obj == null)
						{
							object obj3 = 9;
							while (true)
							{
								switch ((int)obj3)
								{
								case 13:
									_ = ref ((DesktopAuthentication)Unsafe.AsPointer(ref this))._003CserverId_003EP;
									((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CSendPacketAsync_003Ed__28, _003CAuthentication_003Ed__27>(ref this));
									obj = 7;
									goto IL_0081;
								case 8:
									break;
								case 4:
									_ = ref obj;
									if (Log.Logger == null)
									{
										_ = 0;
										if (((_003CAuthentication_003Ed__27*)(nint)PrepareDic)->_003C_003E1__state == 0)
										{
											_ = 1;
										}
										continue;
									}
									goto case 2;
								case 5:
								{
									object obj5 = obj;
									object obj6 = obj;
									DesktopAuthentication._002Ecctor();
									((IAsyncStateMachine)obj6).MoveNext();
									obj = obj5;
									obj = 4;
									goto IL_0081;
								}
								case 10:
								{
									string modHashList = _003CAuthentication_003Ed__27.modHashList;
									object obj4 = obj;
									((AsyncTaskMethodBuilder*)null)->AwaitUnsafeOnCompleted(ref *(((TaskAwaiter*)((Array)obj).Length)->IsCompleted ? ((ValueTaskAwaiter*)1) : ((ValueTaskAwaiter*)null)), ref *(_003CSendMessageAsync_003Ed__29*)obj);
									((AsyncTaskMethodBuilder*)/*Error near IL_01c1: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)modHashList, ref *(_003CSendPacketAsync_003Ed__28*)obj4);
									obj = (object)/*Error near IL_01c3: Stack underflow*/;
									obj3 = 5;
									continue;
								}
								case 2:
									((Task)(&obj)).GetAwaiter();
									_ = 0;
									if (((_003CConnect_003Ed__19*)(nint)_003CAuthentication_003Ed__27.ReflectInternalAnnotation)->_003C_003E1__state == 0)
									{
										_ = 0;
									}
									continue;
								case 12:
									obj = -1;
									((_003CConnect_003Ed__19)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-1);
									obj3 = 2;
									if (((_003CConnect_003Ed__19*)(nint)_003CConnect_003Ed__19._003C_003E4__this)->authServer == null)
									{
										obj3 = 2;
									}
									continue;
								case 3:
								case 9:
									obj = ((_003CConnect_003Ed__19)this)._003Ccts_003E5__2;
									obj3 = 6;
									continue;
								case 1:
									obj = 0;
									((_003CConnect_003Ed__19)this)._003C_003Eu__1 = (TaskAwaiter)0;
									obj3 = 11;
									continue;
								case 7:
									return;
								case 11:
									_003CConnect_003Ed__19.CheckAdjustableCommand = obj;
									obj = 13;
									goto IL_0081;
								case 6:
									Unsafe.As<int, @null>(ref ((_003CHeartbeatAsync_003Ed__25)this)._003C_003E1__state) = null;
									obj3 = 11;
									if ((int)((_003CHeartbeatAsync_003Ed__25*)(nint)_003CHeartbeatAsync_003Ed__25._003C_003E4__this)->_003C_003Eu__1 == 0)
									{
										obj3 = 12;
									}
									continue;
								default:
									goto IL_0349;
									IL_0081:
									obj3 = obj;
									continue;
								}
								break;
							}
						}
						new string((IFormatProvider?)/*Error near IL_010c: Stack underflow*/, (string)/*Error near IL_010c: Stack underflow*/, (object?[])/*Error near IL_010c: Stack underflow*/);
						/*Error near IL_010d: Member reference must be method, but was: Field*/;
					default:
						goto IL_0349;
					case 3:
						break;
					case 5:
						obj = ((_003CReceiveControlDataAsync_003Ed__22)this)._003C_003Eu__2;
						obj2 = 4;
						continue;
					case 2:
						return;
						IL_0349:
						((_003CReceiveControlDataAsync_003Ed__22)this)._003C_003E1__state = -2;
						obj2 = 3;
						if (((_003CReceiveControlDataAsync_003Ed__22)_003CReceiveControlDataAsync_003Ed__22._003C_003Et__builder)._003C_003E4__this == null)
						{
							obj2 = 3;
						}
						continue;
					}
					break;
				}
				((byte[])/*Error near IL_037b: Stack underflow*/).Xor((byte[])Unsafe.AsPointer(ref ((_003CReceiveControlDataAsync_003Ed__22)this).data));
				obj = 2;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00ꄀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779389, new IntPtr(2737336583436L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00ꈀ(object P_0)
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
		internal static byte _FF00_FF00_FF00_FF00ꌀ()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00ꐀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779388, new IntPtr(2737336583436L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00ꔀ()
		{
			Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return DesktopAuthentication._003CuserId_003EP;
		}
	}

	private static readonly object Crc32;

	private static readonly object Logger;

	public static readonly byte[] TokenKey;

	private readonly object _client;

	private nint _connected;

	private readonly List<byte> _buffer;

	private nint _handshake;

	private nint _handshakeSent;

	private object _handshakeKey;

	private object _encryptedToken;

	private object _encryptChaCha;

	private object _decryptChaCha;

	private object? _handshakeTcs;

	private object? _authenticationTcs;

	internal static DesktopAuthentication PrepareDic;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DesktopAuthentication(string userId, string userToken, string gameVersion, string serverId)
	{
		//IL_004b: Expected VT, but got Obj
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		_003CuserId_003EP = userId;
		_003CuserToken_003EP = userToken;
		_003CgameVersion_003EP = gameVersion;
		_003CserverId_003EP = serverId;
		Logger = new EqualityComparer<_00210>((_00210)this);
		_client = new object();
		/*Error near IL_0066: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CConnect_003Ed__19))]
	public Task Connect(EntityAuthServer authServer)
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00_2200(authServer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CReceiveAsync_003Ed__20))]
	private object ReceiveAsync()
	{
		return _FF00_FF00_FF00_FF00_FF00_0300();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CReceiveDataAsync_003Ed__21))]
	private object ReceiveDataAsync(object buffer)
	{
		return _FF00_FF00_FF00_FF00_FF00ᰀ(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CReceiveControlDataAsync_003Ed__22))]
	private object ReceiveControlDataAsync(object data)
	{
		return _FF00_FF00_FF00_FF00_FF00ᨀ(data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoteCallBackAsync_003Ed__23))]
	private object RemoteCallBackAsync(ushort sid, object payload)
	{
		return _FF00_FF00_FF00_FF00_FF00ᘀ(sid, payload);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CHeartbeatCircleAsync_003Ed__24))]
	private object HeartbeatCircleAsync()
	{
		return _FF00_FF00_FF00_FF00_FF00_0C00();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CHeartbeatAsync_003Ed__25))]
	private object HeartbeatAsync()
	{
		return _FF00_FF00_FF00_FF00_FF00ༀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Disconnect()
	{
		_FF00_FF00_FF00_FF00_FF00ᄀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAuthentication_003Ed__27))]
	public Task Authentication(string serverIdHash, string modHashList)
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00_2700(serverIdHash, modHashList);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSendPacketAsync_003Ed__28))]
	private object SendPacketAsync(byte id, object data)
	{
		return _FF00_FF00_FF00_FF00_FF00_1400(id, data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSendMessageAsync_003Ed__29))]
	private object SendMessageAsync(object data)
	{
		return _FF00_FF00_FF00_FF00_FF00_2400(data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		_FF00_FF00_FF00_FF00_FF00ᜀ();
	}

	static DesktopAuthentication()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0027: Expected I4, but got Obj
		//IL_0077: Expected Obj, but got I4
		//IL_0057->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00a4->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0062->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00af->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 3;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					return;
				case 1:
					TokenKey = new byte[16]
					{
						172, 36, 156, 105, 199, 44, 179, 180, 78, 192,
						204, 108, 84, 58, 129, 149
					};
					obj2 = 0;
					if (_003CModule_003E_007Bb8824bbe_002D6cfa_002D4013_002D8120_002Dcb1e84055f2d_007D.m_2f25a4da0ad14a089b13089b3bff794c.m_9fc16bf525e44ec098be86f91c385c40 != 0)
					{
						obj2 = 0;
					}
					continue;
				case 0:
					return;
				case 3:
					break;
				case 2:
					Logger = Log.Logger.Category((string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00Ā());
					obj2 = 1;
					if (_003CModule_003E_007Bb8824bbe_002D6cfa_002D4013_002D8120_002Dcb1e84055f2d_007D.m_2f25a4da0ad14a089b13089b3bff794c.m_ed11e091e89a40debc71b89a4d0a18f0 == 0)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
			}
			Crc32 = new Crc32();
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DirectObject()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DesktopAuthentication ReflectExtendedAuditor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00Ȁ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779319, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00_0300()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1966, 1790779318, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779318, new IntPtr(2737336581356L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00Ѐ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779313, new IntPtr(2737336591756L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_FF00_0600()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0043: Expected VT, but got Obj
		//IL_004d: Expected VT, but got Obj
		//IL_0062->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006d->IL0026: Incompatible stack types: I4 vs Obj
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
				((_003C_003Ef__AnonymousType0<, >)/*Error near IL_0043: Stack underflow*/)._002Ector((_003Corderid_003Ej__TPar)/*Error near IL_0043: Stack underflow*/, (_003Cbuy_type_003Ej__TPar)_003CuserId_003EP);
				((EqualityComparer<_00210>)/*Error near IL_004d: Stack underflow*/).Equals((_00210?)/*Error near IL_004d: Stack underflow*/, (_00210?)new EqualityComparer<_00210>());
				obj2 = 0;
				if (Logger == null)
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
	private unsafe void _FF00_FF00_FF00_FF00_FF00_0700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779312, new IntPtr(2737336606316L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00ࠀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779315, new IntPtr(2737336600076L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_0900()
	{
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (DesktopAuthentication._003CuserId_003EP == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_0A00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779314, new IntPtr(2737336582396L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00_0B00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779325, new IntPtr(2737336591756L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00_0C00()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1975, 1790779324, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779324, new IntPtr(2737336590716L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00_0D00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779327, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00_0E00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779326, new IntPtr(2737336578236L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00ༀ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1978, 1790779321, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779321, new IntPtr(2737336591756L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00က()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779320, new IntPtr(2737336577196L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_FF00ᄀ()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_006e: Expected VT, but got Obj
		//IL_0044: Expected Obj, but got I4
		//IL_0082->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008d->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
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
			case 2:
				return;
			case 1:
				_003CuserId_003EP = 0;
				obj2 = 0;
				if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP != null)
				{
					obj2 = 0;
				}
				break;
			default:
				((EqualityComparer<_00210>)/*Error near IL_006e: Stack underflow*/).GetHashCode((_00210)_003CserverId_003EP);
				_ = 0;
				if (TokenKey == null)
				{
					_ = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00ሀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779323, new IntPtr(2737336576156L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00ጀ(byte P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779322, new IntPtr(2737336592796L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00_1400(byte P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_0054: Expected Obj, but got Ref
		//IL_009e: Expected VT, but got Ref
		//IL_00a3: Expected Obj, but got I4
		//IL_011d: Expected Obj, but got Ref
		//IL_00f7: Expected Obj, but got I4
		//IL_00f7: Expected Obj, but got Ref
		//IL_0066: Expected Obj, but got Ref
		//IL_00c9: Expected Obj, but got Ref
		//IL_00df: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got Ref
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0116->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ef->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0097->IL0026: Incompatible stack types: I4 vs Obj
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
			default:
				((DesktopAuthentication)(&stateMachine))._003CuserId_003EP = this;
				obj = 3;
				break;
			case 4:
				((DesktopAuthentication)(&stateMachine))._003CuserToken_003EP = P_1;
				obj = 6;
				break;
			case 6:
				((DesktopAuthentication)(&stateMachine))._003CgameVersion_003EP = -1;
				obj = 1;
				if (Crc32 == null)
				{
					obj = 5;
				}
				break;
			case 1:
				TokenKey = (byte[])((EqualityComparer<_00211>)/*Error near IL_009e: Stack underflow*/).GetHashCode((_00211)(&stateMachine));
				obj = 0;
				if (((DesktopAuthentication)DesktopAuthentication._client)._connected == 0)
				{
					obj = 0;
				}
				break;
			case 5:
				((AsyncTaskMethodBuilder*)/*Error near IL_00d0: Stack underflow*/)->AwaitUnsafeOnCompleted(ref Unsafe.As<List<byte>, TaskAwaiter>(ref ((DesktopAuthentication)(&stateMachine))._buffer), ref *(_003CHeartbeatAsync_003Ed__25*)(&stateMachine));
				obj = 2;
				if (((DesktopAuthentication)DesktopAuthentication._handshakeSent)._handshakeKey != null)
				{
					obj = 0;
				}
				break;
			case 3:
				((DesktopAuthentication)(&stateMachine))._encryptedToken = P_0;
				obj = 2;
				if (((DesktopAuthentication)DesktopAuthentication._encryptChaCha)._decryptChaCha == null)
				{
					obj = 4;
				}
				break;
			case 2:
				_ = ref ((DesktopAuthentication)(&stateMachine))._handshakeTcs;
				return Log.Logger;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00ᔀ(byte P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779301, new IntPtr(2737336604236L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00ᘀ(ushort P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_007b: Expected Obj, but got Ref
		//IL_00ff: Expected Obj, but got Ref
		//IL_00d2: Expected Obj, but got Ref
		//IL_00c1: Expected Obj, but got Ref
		//IL_00af: Expected Obj, but got Ref
		//IL_0054: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got Ref
		//IL_00a1: Expected Obj, but got Ref
		//IL_00a6: Expected Obj, but got Ref
		//IL_008f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0118->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ed->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00cb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0123->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f8->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0073->IL0026: Incompatible stack types: I4 vs Obj
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
			case 5:
				((DesktopAuthentication)(&obj))._003CuserId_003EP = -1;
				obj2 = 2;
				if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP == null)
				{
					obj2 = 2;
				}
				break;
			default:
				((DesktopAuthentication)(&obj))._003CserverId_003EP = this;
				obj2 = 0;
				if (Logger == null)
				{
					obj2 = 4;
				}
				break;
			case 6:
				return string.Format((IFormatProvider?)/*Error near IL_00a6: Stack underflow*/, (string)/*Error near IL_00a6: Stack underflow*/, (object?[])Unsafe.AsPointer(ref TokenKey));
			case 4:
				((DesktopAuthentication)(&obj))._connected = (int)P_0;
				obj2 = 3;
				break;
			case 3:
				((DesktopAuthentication)(&obj))._buffer = (List<byte>)P_1;
				obj2 = 5;
				break;
			case 2:
				_ = ref ((DesktopAuthentication)(&obj))._handshake;
				_ = ref obj;
				Array.Empty<byte>();
				_ = 3;
				if (((DesktopAuthentication)DesktopAuthentication._handshakeKey)._encryptedToken == null)
				{
					_ = 6;
				}
				break;
			case 1:
				((TcpClient)(&obj)).Close();
				((DesktopAuthentication)/*Error near IL_0104: Stack underflow*/)._decryptChaCha = (object)/*Error near IL_0104: Stack underflow*/;
				obj2 = 0;
				if (((DesktopAuthentication)DesktopAuthentication._handshakeTcs)._authenticationTcs == null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00_FF00ᜀ()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0067: Expected VT, but got Obj
		//IL_007b->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0056->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0086->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0061->IL0026: Incompatible stack heights: 2 vs 1
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				_ = ((_003C_003Ef__AnonymousType0<, >)this).buy_type;
				_ = 1;
				if (((DesktopAuthentication)DesktopAuthentication._003CuserToken_003EP)._003CgameVersion_003EP == null)
				{
					_ = 1;
				}
				break;
			case 1:
				((EqualityComparer<_00210>)/*Error near IL_0067: Stack underflow*/).Equals((_00210?)/*Error near IL_0067: Stack underflow*/, (_00210?)this);
				_ = 0;
				if (Logger == null)
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
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_1800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779300, new IntPtr(2737336605276L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00ᤀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779303, new IntPtr(2737336584476L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00ᨀ(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1989, 1790779302, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779302, new IntPtr(2737336575116L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00_1B00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779297, new IntPtr(2737336580316L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00ᰀ(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1991, 1790779296, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779296, new IntPtr(2737336604236L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00ᴀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779299, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00_FF00ἀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779298, new IntPtr(2737336599036L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00_FF00_2000()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0043: Expected VT, but got Obj
		//IL_004d: Expected VT, but got Obj
		//IL_0062->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006d->IL0026: Incompatible stack types: I4 vs Obj
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
				((_003C_003Ef__AnonymousType0<, >)/*Error near IL_0043: Stack underflow*/)._002Ector((_003Corderid_003Ej__TPar)/*Error near IL_0043: Stack underflow*/, (_003Cbuy_type_003Ej__TPar)_003CuserId_003EP);
				((EqualityComparer<_00210>)/*Error near IL_004d: Stack underflow*/).Equals((_00210?)/*Error near IL_004d: Stack underflow*/, (_00210?)new EqualityComparer<_00210>());
				obj2 = 0;
				if (Logger == null)
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
	private unsafe void _FF00_FF00_FF00_FF00_FF00_2100()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779309, new IntPtr(2737336584476L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_2200(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1997, 1790779308, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779308, new IntPtr(2737336592796L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_2300(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779311, new IntPtr(2737336600076L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00_2400(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1999, 1790779310, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779310, new IntPtr(2737336582396L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00_2500(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779305, new IntPtr(2737336599036L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_2600(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779304, new IntPtr(2737336583436L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_2700(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005a: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2002, 1790779307, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 3, 1790779307, new IntPtr(2737336585516L), 15);
		}
		return ((delegate*<object, object, object, object>)obj)(this, P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_2800(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779306, new IntPtr(2737336576156L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_2900()
	{
		Unsafe.As<_003Corderid_003Ej__TPar, ValueType>(ref _003C_003Ef__AnonymousType0<, >._003Corderid_003Ei__Field)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return DesktopAuthentication._003CuserId_003EP;
	}
}
