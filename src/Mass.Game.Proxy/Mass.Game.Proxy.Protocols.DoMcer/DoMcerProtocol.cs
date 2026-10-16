using System;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mass.Application.Event;
using Mass.Common.Extensions;
using Mass.Game.Proxy.Minecraft.Events.Play;
using Mass.Game.Proxy.Minecraft.Protocol;
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0071: Expected Obj, but got I4
			//IL_0374: Expected Obj, but got Ref
			//IL_005b: Expected Obj, but got Ref
			//IL_015e: Expected Obj, but got Ref
			//IL_0136: Expected Obj, but got I4
			//IL_025b: Expected Obj, but got I4
			//IL_014f: Expected Obj, but got I4
			//IL_01eb: Expected Obj, but got I4
			//IL_0076->IL0015: Incompatible stack heights: 1 vs 0
			//IL_004c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0380->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0065->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0057->IL0019: Incompatible stack heights: 2 vs 1
			//IL_038b->IL0019: Incompatible stack types: I4 vs Obj
			//IL_00ab->IL0088: Incompatible stack heights: 0 vs 1
			//IL_0175->IL00d9: Incompatible stack heights: 1 vs 0
			//IL_00d5->IL00d9: Incompatible stack heights: 1 vs 0
			//IL_01be->IL00d9: Incompatible stack heights: 1 vs 0
			//IL_0293->IL00d9: Incompatible stack heights: 1 vs 0
			//IL_021a->IL00d9: Incompatible stack heights: 2 vs 0
			//IL_01ff->IL00d9: Incompatible stack heights: 1 vs 0
			//IL_024b->IL00d9: Incompatible stack heights: 2 vs 0
			//IL_0266->IL00d9: Incompatible stack heights: 3 vs 0
			//IL_015a->IL00d9: Incompatible stack heights: 3 vs 0
			//IL_01da->IL00d9: Incompatible stack heights: 3 vs 0
			//IL_00d9->IL00d9: Incompatible stack heights: 4 vs 0
			//IL_01c9->IL00d9: Incompatible stack heights: 1 vs 0
			//IL_0192->IL00d9: Incompatible stack heights: 1 vs 0
			//IL_0225->IL00d9: Incompatible stack heights: 2 vs 0
			//IL_020a->IL00d9: Incompatible stack heights: 1 vs 0
			//IL_0256->IL00d9: Incompatible stack heights: 2 vs 0
			//IL_01f0->IL00d5: Incompatible stack heights: 0 vs 3
			//IL_0286->IL00d9: Incompatible stack heights: 1 vs 0
			//IL_01af->IL00d9: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					case 3:
						return;
					case 2:
						_ = -2;
						if (1 == 0)
						{
							_ = 1;
						}
						continue;
					case 5:
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 4;
						continue;
					case 1:
						break;
					default:
					{
						int num = 2;
						while (true)
						{
							switch (num)
							{
							case 1:
								break;
							case 2:
								if (0 == 0)
								{
									num = 0;
								}
								continue;
							default:
								{
									if (obj != null)
									{
										if (2 != 0)
										{
											_ = 1;
										}
										goto IL_00d9;
									}
									goto IL_015a;
								}
								IL_00d9:
								while (true)
								{
									switch ((int)/*Error near IL_0122: Stack underflow*/)
									{
									case 12:
										return;
									case 15:
										break;
									default:
										_ = ref obj;
										obj = 12;
										continue;
									case 13:
										obj = -1;
										_ = 7;
										continue;
									case 6:
										goto end_IL_00d9;
									case 4:
										obj = (object)/*Error near IL_017b: Stack underflow*/;
										if (16 == 0)
										{
											_ = 9;
										}
										continue;
									case 14:
										obj = obj;
										if (10 != 0)
										{
											_ = 9;
										}
										continue;
									case 1:
										if (7 == 0)
										{
											_ = 13;
										}
										continue;
									case 16:
										_ = 11;
										continue;
									case 10:
										if (&obj != null)
										{
											obj = 3;
											continue;
										}
										goto case 9;
									case 3:
									case 7:
										_ = ref obj;
										if (5 != 0)
										{
											_ = 15;
										}
										continue;
									case 5:
										if (0 == 0)
										{
											_ = 0;
										}
										continue;
									case 8:
										if (12 != 0)
										{
											_ = 14;
										}
										continue;
									case 9:
										obj = 0;
										_ = 5;
										continue;
									case 11:
										obj = obj;
										if (1 == 0)
										{
											_ = 8;
										}
										continue;
									case 2:
										_ = 4;
										continue;
									}
									goto end_IL_0088;
									continue;
									end_IL_00d9:
									break;
								}
								goto IL_015a;
								IL_015a:
								obj = (object)Unsafe.AsPointer(ref this);
								if (false)
								{
									_ = 1;
								}
								goto IL_00d9;
								end_IL_0088:
								break;
							}
							break;
						}
						goto case 2;
					}
					case 4:
						obj = (object)Unsafe.AsPointer(ref this);
						if (0 == 0)
						{
							obj2 = 0;
						}
						continue;
					}
					break;
				}
				obj = 3;
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
		private sealed void _FF00_FF00_FF00_FF00Ѐ(object P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (0 == 0)
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			//IL_0010: Expected Obj, but got I4
			//IL_003e: Expected I4, but got Obj
			//IL_009b: Expected Obj, but got Ref
			//IL_006f: Expected Obj, but got Ref
			//IL_0078: Expected Obj, but got I4
			//IL_04a7: Expected Obj, but got Ref
			//IL_0472: Expected Obj, but got I4
			//IL_050a: Expected Obj, but got Ref
			//IL_032c: Expected Obj, but got Ref
			//IL_02f1: Expected Obj, but got Ref
			//IL_0482: Expected Obj, but got I4
			//IL_048c: Expected Obj, but got I4
			//IL_03dc: Expected Obj, but got I4
			//IL_034b: Expected Obj, but got Ref
			//IL_033b: Expected Obj, but got I4
			//IL_04fb: Expected Obj, but got I4
			//IL_0421: Expected Obj, but got Ref
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_00a5->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0051->IL0019: Incompatible stack heights: 3 vs 1
			//IL_008c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0714->IL0019: Incompatible stack heights: 3 vs 1
			//IL_006b->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0097->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00f8->IL00ca: Incompatible stack heights: 1 vs 0
			//IL_00c6->IL00ca: Incompatible stack heights: 1 vs 0
			//IL_0107->IL00ca: Incompatible stack heights: 1 vs 0
			//IL_0125->IL0129: Incompatible stack types: I4 vs Ref
			//IL_0112->IL00ca: Incompatible stack heights: 1 vs 0
			//IL_01c8->IL0129: Incompatible stack types: I4 vs Ref
			//IL_020f->IL0129: Incompatible stack heights: 2 vs 1
			//IL_0183->IL0129: Incompatible stack heights: 2 vs 1
			//IL_018e->IL0129: Incompatible stack types: I4 vs Ref
			//IL_01ab->IL0129: Incompatible stack types: I4 vs Ref
			//IL_01e5->IL0129: Incompatible stack types: I4 vs Ref
			//IL_0202->IL0129: Incompatible stack types: I4 vs Ref
			//IL_022e->IL0232: Incompatible stack heights: 1 vs 0
			//IL_04be->IL0232: Incompatible stack heights: 1 vs 0
			//IL_03c7->IL0232: Incompatible stack heights: 1 vs 0
			//IL_0372->IL0232: Incompatible stack heights: 4 vs 0
			//IL_0452->IL0232: Incompatible stack heights: 3 vs 0
			//IL_047d->IL0232: Incompatible stack heights: 3 vs 0
			//IL_041b->IL0232: Incompatible stack heights: 4 vs 0
			//IL_04de->IL0232: Incompatible stack heights: 1 vs 0
			//IL_039d->IL0232: Incompatible stack heights: 2 vs 0
			//IL_03fa->IL0232: Incompatible stack heights: 1 vs 0
			//IL_046d->IL0232: Incompatible stack heights: 4 vs 0
			//IL_02d9->IL0232: Incompatible stack heights: 1 vs 0
			//IL_0336->IL0232: Incompatible stack heights: 1 vs 0
			//IL_0382->IL0232: Incompatible stack heights: 2 vs 0
			//IL_04f6->IL0232: Incompatible stack heights: 1 vs 0
			//IL_02fb->IL0232: Incompatible stack heights: 3 vs 0
			//IL_04cf->IL0232: Incompatible stack heights: 3 vs 0
			//IL_0491->IL022e: Incompatible stack types: I4 vs Ref
			//IL_0346->IL0232: Incompatible stack heights: 3 vs 0
			//IL_0506->IL0232: Incompatible stack heights: 3 vs 0
			//IL_042b->IL0232: Incompatible stack heights: 1 vs 0
			//IL_0324->IL0232: Incompatible stack heights: 1 vs 0
			//IL_045d->IL0232: Incompatible stack heights: 3 vs 0
			//IL_02ca->IL0232: Incompatible stack heights: 1 vs 0
			//IL_04e9->IL0232: Incompatible stack heights: 1 vs 0
			//IL_03a8->IL0232: Incompatible stack heights: 2 vs 0
			//IL_0405->IL0232: Incompatible stack heights: 1 vs 0
			//IL_04a3->IL0232: Incompatible stack heights: 1 vs 0
			//IL_0521->IL0232: Incompatible stack heights: 1 vs 0
			//IL_02e4->IL0232: Incompatible stack heights: 1 vs 0
			//IL_038d->IL0232: Incompatible stack heights: 2 vs 0
			//IL_0232->IL0232: Incompatible stack heights: 3 vs 0
			//IL_0362->IL0232: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			while (true)
			{
				ref _003CSendImage_003Ed__6 reference = ref *(_003CSendImage_003Ed__6*)obj;
				while (true)
				{
					ref _003CSendImage_003Ed__6 reference2;
					switch ((uint)Unsafe.AsPointer(ref reference))
					{
					default:
						return;
					case 4u:
						_ = -2;
						_ = 6;
						continue;
					case 1u:
						reference = ref this;
						if (0 == 0)
						{
							reference = ref *(_003CSendImage_003Ed__6*)null;
						}
						continue;
					case 3u:
						break;
					case 5u:
						_ = null;
						if (1 == 0)
						{
							_ = 0;
						}
						continue;
					case 2u:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(_003CSendImage_003Ed__6*)7;
						continue;
					case 0u:
						return;
					case 7u:
						if ((nuint)(nint)obj > (nuint)1u)
						{
							if (1 == 0)
							{
								_ = 1;
							}
							goto IL_00ca;
						}
						goto IL_00e0;
					case 6u:
						{
							_ = null;
							_ = 5;
							continue;
						}
						IL_03a8:
						if ((nint)obj != 1)
						{
							if (1 == 0)
							{
								_ = 1;
							}
							goto IL_0232;
						}
						goto IL_04a3;
						IL_00e0:
						if (false)
						{
							_ = 0;
						}
						goto IL_00ca;
						IL_00ca:
						while (true)
						{
							switch ((int)/*Error near IL_00db: Stack underflow*/)
							{
							case 2:
								break;
							case 1:
								if (2 == 0)
								{
									_ = 2;
								}
								continue;
							default:
								goto IL_0112;
							}
							break;
						}
						goto IL_00e0;
						IL_0112:
						if ((nuint)(nint)obj <= (nuint)1u)
						{
							reference2 = ref *(_003CSendImage_003Ed__6*)6;
							goto IL_0129;
						}
						goto IL_01ab;
						IL_04a3:
						obj = (object)Unsafe.AsPointer(ref this);
						if (13 == 0)
						{
							_ = 5;
						}
						goto IL_0232;
						IL_01ab:
						reference2 = ref this;
						if (4 != 0)
						{
							reference2 = ref *(_003CSendImage_003Ed__6*)1;
						}
						goto IL_0129;
						IL_0129:
						while (true)
						{
							switch ((uint)Unsafe.AsPointer(ref reference2))
							{
							case 4u:
								_ = 5;
								continue;
							case 6u:
							case 7u:
								reference2 = ref *(_003CSendImage_003Ed__6*)3;
								continue;
							case 2u:
								reference2 = ref this;
								if (7 == 0)
								{
									reference2 = ref *(_003CSendImage_003Ed__6*)8;
								}
								continue;
							case 5u:
								reference2 = ref this;
								if (2 == 0)
								{
									reference2 = ref *(_003CSendImage_003Ed__6*)null;
								}
								continue;
							case 8u:
								reference2 = ref this;
								if (false)
								{
									reference2 = ref *(_003CSendImage_003Ed__6*)1;
								}
								continue;
							case 1u:
								_ = 7;
								continue;
							case 3u:
								goto IL_020f;
							}
							break;
						}
						goto IL_01ab;
						IL_020f:
						if (obj == null)
						{
							if (6 != 0)
							{
								_ = 2;
							}
							goto IL_0232;
						}
						goto IL_03a8;
						IL_0232:
						while (true)
						{
							scoped ref byte reference3;
							ref object reference4;
							switch ((int)/*Error near IL_02b3: Stack underflow*/)
							{
							case 14:
								break;
							case 19:
								return;
							case 25:
								return;
							case 3:
								if (&obj != null)
								{
									_ = 27;
									continue;
								}
								goto case 4;
							case 13:
								if (11 == 0)
								{
									_ = 28;
								}
								continue;
							case 18:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 11;
								continue;
							case 1:
								obj = (object)/*Error near IL_030d: Stack underflow*/;
								if (17 != 0)
								{
									_ = 13;
								}
								continue;
							case 15:
								obj = (object)(&obj);
								_ = 3;
								continue;
							case 28:
								obj = -1;
								_ = 24;
								continue;
							case 26:
								obj = (object)(&obj);
								if (2 == 0)
								{
									_ = 9;
								}
								continue;
							default:
								_ = ref obj;
								_ = 25;
								continue;
							case 16:
								if (10 == 0)
								{
									_ = 10;
								}
								continue;
							case 8:
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							case 20:
								goto IL_03a8;
							case 24:
							case 27:
								reference3 = ref *(byte*)(&obj);
								reference4 = ref obj;
								obj = obj;
								obj = 30;
								continue;
							case 9:
								obj = obj;
								if (21 == 0)
								{
									_ = 5;
								}
								continue;
							case 5:
								_ = 2;
								continue;
							case 30:
								obj = (object)(&obj);
								_ = 26;
								continue;
							case 2:
								if (13 == 0)
								{
									_ = 18;
								}
								continue;
							case 10:
								_ = ref obj;
								_ = 19;
								continue;
							case 4:
								obj = 1;
								_ = 8;
								continue;
							case 22:
								reference3 = ref Unsafe.As<_003CSendImage_003Ed__6, byte>(ref this);
								obj = -1;
								obj = 15;
								reference4 = ref *(object*)(-1);
								continue;
							case 11:
								if (&obj == null)
								{
									_ = 29;
									continue;
								}
								goto case 15;
							case 23:
								goto IL_04a3;
							case 21:
								_ = 14;
								continue;
							case 7:
								if (22 == 0)
								{
									_ = 19;
								}
								continue;
							case 17:
								obj = (object)/*Error near IL_04ec: Stack underflow*/;
								_ = 5;
								continue;
							case 29:
								obj = 0;
								_ = 16;
								continue;
							case 6:
							case 12:
								obj = (object)Unsafe.AsPointer(ref this);
								if (1 == 0)
								{
									_ = 7;
								}
								continue;
							}
							break;
						}
						goto case 4u;
					}
					break;
				}
				obj = (object)Unsafe.AsPointer(ref this);
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
		private sealed void _FF00_FF00_FF00_F600(object P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (0 == 0)
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
	public DoMcerProtocol()
	{
		//IL_0040: Expected I4, but got Obj
		//IL_002e->IL0037: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = this;
		_ = ref obj;
		DoMcerProtocol doMcerProtocol = this;
		if (0 == 0)
		{
			doMcerProtocol = (DoMcerProtocol)0;
		}
		switch ((int)doMcerProtocol)
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
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
	private static object _FF00_FF00_E900()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected Obj, but got Unknown
		//IL_02f7: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got I4
		//IL_00a6: Expected I4, but got Obj
		//IL_02dc->IL0019: Incompatible stack heights: 0 vs 1
		//IL_02c2->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0303->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004a->IL0059: Incompatible stack types: I4 vs Obj
		//IL_02e7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02cd->IL0019: Incompatible stack types: I4 vs Obj
		//IL_030e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0055->IL0059: Incompatible stack types: I4 vs Obj
		//IL_011d->IL0059: Incompatible stack heights: 4 vs 2
		//IL_0160->IL0059: Incompatible stack heights: 4 vs 2
		//IL_01d5->IL0059: Incompatible stack heights: 3 vs 2
		//IL_0130->IL0059: Incompatible stack heights: 3 vs 2
		//IL_01f6->IL0059: Incompatible stack heights: 3 vs 2
		//IL_014c->IL0059: Incompatible stack heights: 4 vs 2
		//IL_0213->IL0059: Incompatible stack heights: 3 vs 2
		//IL_01a2->IL0059: Incompatible stack heights: 4 vs 2
		//IL_0173->IL0059: Incompatible stack heights: 3 vs 2
		//IL_00eb->IL0059: Incompatible stack heights: 4 vs 2
		//IL_00bb->IL0059: Incompatible stack heights: 4 vs 2
		//IL_0192->IL0059: Incompatible stack heights: 4 vs 2
		//IL_00fe->IL0059: Incompatible stack heights: 3 vs 2
		//IL_00cb->IL0059: Incompatible stack heights: 4 vs 2
		//IL_00db->IL0059: Incompatible stack heights: 4 vs 2
		//IL_01e0->IL0059: Incompatible stack heights: 3 vs 2
		//IL_01c2->IL0059: Incompatible stack types: I4 vs Obj
		//IL_013b->IL0059: Incompatible stack heights: 3 vs 2
		//IL_0201->IL0059: Incompatible stack heights: 3 vs 2
		//IL_021e->IL0059: Incompatible stack heights: 3 vs 2
		//IL_017e->IL0059: Incompatible stack heights: 3 vs 2
		//IL_0109->IL0059: Incompatible stack heights: 3 vs 2
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				object obj3 = 2;
				if (1 == 0)
				{
					obj3 = 7;
				}
				while (true)
				{
					switch ((int)obj3)
					{
					case 13:
						_ = 0;
						_ = 15;
						continue;
					case 16:
						_ = 0;
						_ = 3;
						continue;
					case 17:
						_ = 1;
						_ = 10;
						continue;
					case 12:
						_ = 0;
						_ = 8;
						continue;
					case 15:
						_ = 54;
						if (2 != 0)
						{
							_ = 5;
						}
						continue;
					default:
						_ = 960;
						_ = 17;
						continue;
					case 5:
						_ = 40;
						if (5 == 0)
						{
							_ = 6;
						}
						continue;
					case 7:
						_ = 13;
						continue;
					case 1:
						_ = 2835;
						_ = 14;
						continue;
					case 10:
						_ = 24;
						if (16 != 0)
						{
							_ = 16;
						}
						continue;
					case 14:
						_ = 2835;
						_ = 12;
						continue;
					case 9:
						_ = 11;
						continue;
					case 4:
						obj = obj;
						obj3 = obj;
						if (9 == 0)
						{
							obj3 = 3;
						}
						continue;
					case 3:
						if (true)
						{
							_ = 0;
						}
						continue;
					case 6:
						_ = 1280;
						if (false)
						{
							_ = 0;
						}
						continue;
					case 8:
						_ = 0;
						if (4 != 0)
						{
							_ = 3;
						}
						continue;
					case 11:
						obj = obj;
						obj = 2;
						obj3 = obj;
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
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				obj = (object)/*Error near IL_02d0: Stack underflow*/;
				if (1 == 0)
				{
					obj2 = 4;
				}
				break;
			case 3:
				return obj;
			case 2:
				obj = 3840 * 960;
				if (true)
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
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
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
	internal void _FF00_FF00_F300(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_01f7: Expected Obj, but got I4
		//IL_01fb: Expected Obj, but got I4
		//IL_01ff: Expected Obj, but got I4
		//IL_0203: Expected Obj, but got I4
		//IL_0207: Expected Obj, but got I4
		//IL_020b: Expected Obj, but got I4
		//IL_02b3->IL0019: Incompatible stack heights: 0 vs 1
		//IL_02ce->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0050->IL0054: Incompatible stack heights: 1 vs 0
		//IL_02be->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02d9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01d7->IL00e3: Incompatible stack heights: 1 vs 0
		//IL_00c6->IL0054: Incompatible stack heights: 1 vs 0
		//IL_014c->IL019c: Incompatible stack heights: 1 vs 0
		//IL_00d8->IL0054: Incompatible stack heights: 2 vs 0
		//IL_012e->IL0054: Incompatible stack heights: 1 vs 0
		//IL_0175->IL0054: Incompatible stack heights: 2 vs 0
		//IL_01e3->IL0054: Incompatible stack heights: 1 vs 0
		//IL_01b9->IL0054: Incompatible stack heights: 1 vs 0
		//IL_0158->IL0054: Incompatible stack heights: 1 vs 0
		//IL_00e3->IL0054: Incompatible stack heights: 2 vs 0
		//IL_00b9->IL0054: Incompatible stack heights: 1 vs 0
		//IL_0227->IL0054: Incompatible stack heights: 1 vs 0
		//IL_0180->IL0054: Incompatible stack heights: 2 vs 0
		//IL_01ee->IL0054: Incompatible stack heights: 1 vs 0
		//IL_0163->IL0054: Incompatible stack heights: 1 vs 0
		//IL_0112->IL0054: Incompatible stack heights: 1 vs 0
		//IL_0263->IL0054: Incompatible stack heights: 1 vs 0
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj = obj;
				if (0 == 0)
				{
					obj2 = 0;
				}
				continue;
			case 2:
				obj = P_0;
				if (0 == 0)
				{
					obj2 = 1;
				}
				continue;
			}
			obj = obj;
			if (8 != 0)
			{
				_ = 16;
			}
			while (true)
			{
				switch ((int)/*Error near IL_00a1: Stack underflow*/)
				{
				case 12:
					if (obj == null)
					{
						_ = 10;
						break;
					}
					goto case 8;
				case 5:
					_ = 2;
					break;
				case 9:
					if (false)
					{
						_ = 13;
					}
					break;
				case 6:
					return;
				case 10:
					if (obj == null)
					{
						if (3 != 0)
						{
							_ = 3;
						}
						break;
					}
					goto case 5;
				case 13:
					return;
				default:
					_ = 14;
					break;
				case 11:
					return;
				case 8:
					if (obj == null)
					{
						if (11 == 0)
						{
							_ = 7;
						}
						break;
					}
					goto case 7;
				case 17:
					if (1 == 0)
					{
						_ = 1;
					}
					break;
				case 7:
					obj = (object)/*Error near IL_01a2: Stack underflow*/;
					if (9 == 0)
					{
						_ = 2;
					}
					break;
				case 3:
					return;
				case 4:
					if (obj == null)
					{
						return;
					}
					if (false)
					{
						_ = 0;
					}
					break;
				case 14:
				{
					((object[])6)[6] = 0;
					((object[])0)[0] = 1;
					_003F val = /*Error near IL_01fb: Stack underflow*/;
					((object[])/*Error near IL_01ff: Stack underflow*/)[val] = 2;
					_003F val2 = /*Error near IL_01ff: Stack underflow*/;
					((object[])/*Error near IL_0203: Stack underflow*/)[val2] = 3;
					_003F val3 = /*Error near IL_0203: Stack underflow*/;
					((object[])/*Error near IL_0207: Stack underflow*/)[val3] = 4;
					_003F val4 = /*Error near IL_0207: Stack underflow*/;
					((object[])/*Error near IL_020b: Stack underflow*/)[val4] = 5;
					obj = (object)/*Error near IL_0210: Stack underflow*/;
					if (17 != 0)
					{
						_ = 4;
					}
					break;
				}
				case 1:
					return;
				case 16:
					if (obj == null)
					{
						if (9 != 0)
						{
							_ = 12;
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
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
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
