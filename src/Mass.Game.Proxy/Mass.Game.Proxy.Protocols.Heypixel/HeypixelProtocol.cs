using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DotNetty.Buffers;
using Mass.Application.Event;
using Mass.Common.Extensions;
using Mass.Domain.Value;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Minecraft.Events;
using Mass.Game.Proxy.Minecraft.Events.Play;
using Mass.Game.Proxy.Packets.Configuration;
using Mass.Game.Proxy.Packets.Handshake;
using Mass.Game.Proxy.Packets.Play;
using Mass.Game.Proxy.Protocols.FakeForge;
using Mass.Game.Proxy.Protocols.Heypixel.AntiCheat;
using RestSharp;
using Serilog;

namespace Mass.Game.Proxy.Protocols.Heypixel;

public class HeypixelProtocol : FakeForgeProtocol
{
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_03c7: Expected Obj, but got Ref
			//IL_03f1: Expected Obj, but got Ref
			//IL_0107: Expected Obj, but got Ref
			//IL_0199: Expected Obj, but got I4
			//IL_0129: Expected Obj, but got I4
			//IL_020b: Expected Obj, but got I4
			//IL_0175: Expected Obj, but got I4
			//IL_01b3: Expected Obj, but got Ref
			//IL_03e2->IL0019: Incompatible stack heights: 2 vs 1
			//IL_03d1->IL0019: Incompatible stack types: I4 vs Obj
			//IL_03fd->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_03ed->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0408->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0056->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0071->IL0075: Incompatible stack heights: 1 vs 0
			//IL_0111->IL00b5: Incompatible stack types: I4 vs Ref
			//IL_00b1->IL00b5: Incompatible stack types: I4 vs Ref
			//IL_009f->IL0075: Incompatible stack heights: 1 vs 0
			//IL_0136->IL00b5: Incompatible stack heights: 2 vs 1
			//IL_0255->IL00b5: Incompatible stack types: I4 vs Ref
			//IL_0158->IL00b5: Incompatible stack heights: 3 vs 1
			//IL_01ae->IL00b5: Incompatible stack types: I4 vs Ref
			//IL_0226->IL00b5: Incompatible stack heights: 4 vs 1
			//IL_0216->IL00b5: Incompatible stack heights: 3 vs 1
			//IL_0181->IL00b5: Incompatible stack heights: 0 vs 1
			//IL_01d9->IL00b5: Incompatible stack heights: 3 vs 1
			//IL_01ec->IL00b5: Incompatible stack types: I4 vs Ref
			//IL_01fb->IL00b5: Incompatible stack heights: 0 vs 1
			//IL_01bf->IL00b5: Incompatible stack heights: 0 vs 1
			//IL_00b5->IL00b5: Incompatible stack heights: 3 vs 1
			//IL_0141->IL00b5: Incompatible stack heights: 2 vs 1
			//IL_0172->IL00b5: Incompatible stack types: I4 vs Ref
			//IL_023a->IL00b5: Incompatible stack heights: 0 vs 1
			//IL_018c->IL00b5: Incompatible stack types: I4 vs Ref
			//IL_0206->IL00b5: Incompatible stack types: I4 vs Ref
			//IL_01ca->IL00b5: Incompatible stack types: I4 vs Ref
			//IL_0245->IL00b5: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				ref _003CInitialize_003Ed__17 reference;
				switch ((int)obj2)
				{
				case 3:
					_ = -2;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
				case 5:
					if (true)
					{
						_ = 1;
					}
					while (true)
					{
						switch ((int)/*Error near IL_0082: Stack underflow*/)
						{
						case 1:
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						}
						break;
					}
					if (obj != null)
					{
						reference = ref *(_003CInitialize_003Ed__17*)15;
						goto IL_00b5;
					}
					goto IL_0103;
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 5;
					break;
				default:
					if (3 == 0)
					{
						_ = 4;
					}
					break;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						obj2 = 1;
					}
					break;
				case 4:
					return;
					IL_00b5:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 1u:
							break;
						case 5u:
							goto IL_0103;
						case 9u:
							return;
						case 2u:
							obj = 0;
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 4u:
							_ = ref obj;
							obj = obj;
							_ = 8;
							continue;
						case 7u:
							reference = ref this;
							if (11 == 0)
							{
								reference = ref *(_003CInitialize_003Ed__17*)10;
							}
							continue;
						case 12u:
							obj = 1;
							if (0 == 0)
							{
								reference = ref *(_003CInitialize_003Ed__17*)1;
							}
							continue;
						default:
							obj = 10;
							continue;
						case 6u:
							obj = obj;
							reference = ref *(_003CInitialize_003Ed__17*)3;
							continue;
						case 16u:
							obj = (object)(&obj);
							if (5 == 0)
							{
								reference = ref *(_003CInitialize_003Ed__17*)13;
							}
							continue;
						case 13u:
							_ = 12;
							continue;
						case 14u:
							obj = obj;
							reference = ref *(_003CInitialize_003Ed__17*)4;
							continue;
						case 15u:
							if (6 == 0)
							{
								reference = ref *(_003CInitialize_003Ed__17*)null;
							}
							continue;
						case 11u:
							obj = -1;
							_ = 16;
							continue;
						case 10u:
							_ = ref obj;
							_ = 9;
							continue;
						case 8u:
							if (&obj == null)
							{
								if (2 == 0)
								{
									reference = ref *(_003CInitialize_003Ed__17*)2;
								}
								continue;
							}
							goto case 16u;
						case 3u:
							obj = obj;
							reference = ref *(_003CInitialize_003Ed__17*)14;
							continue;
						}
						break;
					}
					goto case 3;
					IL_0103:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CInitialize_003Ed__17*)7;
					goto IL_00b5;
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
		private sealed void _FF00_FF00_FF00_FF00_FF00㨀(object P_0)
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
					if (false)
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0c31: Expected Obj, but got Ref
			//IL_010b: Expected Obj, but got Ref
			//IL_00b1: Expected I4, but got Obj
			//IL_027d: Expected Obj, but got Ref
			//IL_0379: Expected Obj, but got I4
			//IL_044d: Expected I4, but got Obj
			//IL_0301: Expected Obj, but got I4
			//IL_03b2: Expected Obj, but got Ref
			//IL_0402: Expected Obj, but got I4
			//IL_0397: Expected Obj, but got Ref
			//IL_0615: Expected Obj, but got Ref
			//IL_05b0: Expected Obj, but got Ref
			//IL_0704: Expected Obj, but got Ref
			//IL_0573: Expected Obj, but got Ref
			//IL_055b: Expected Obj, but got I4
			//IL_0711: Unknown result type (might be due to invalid IL or missing references)
			//IL_0714: Expected Obj, but got Unknown
			//IL_092a: Expected Obj, but got Ref
			//IL_066a: Expected Obj, but got I4
			//IL_0959: Expected Obj, but got Ref
			//IL_069f: Expected Obj, but got I4
			//IL_06e5: Expected Obj, but got I4
			//IL_05a1: Expected Obj, but got I4
			//IL_08e4: Expected Obj, but got I4
			//IL_0975: Expected Obj, but got Ref
			//IL_0984: Expected Obj, but got I4
			//IL_0633: Expected Obj, but got Ref
			//IL_087a: Expected Obj, but got I4
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0c3d->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0c55->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0066->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0c48->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0104->IL0088: Incompatible stack types: I4 vs Obj
			//IL_0084->IL0088: Incompatible stack heights: 1 vs 2
			//IL_0071->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00b1->IL00f5: Incompatible stack heights: 1 vs 0
			//IL_0115->IL0088: Incompatible stack types: I4 vs Obj
			//IL_00c2->IL0168: Incompatible stack heights: 2 vs 1
			//IL_013e->IL0088: Incompatible stack heights: 1 vs 2
			//IL_015d->IL0088: Incompatible stack heights: 6 vs 2
			//IL_00b6->IL00f5: Incompatible stack heights: 1 vs 0
			//IL_035a->IL01a8: Incompatible stack types: I4 vs Ref
			//IL_0199->IL01a8: Incompatible stack heights: 1 vs 2
			//IL_0149->IL0088: Incompatible stack heights: 1 vs 2
			//IL_0168->IL0088: Incompatible stack heights: 6 vs 2
			//IL_00d9->IL0088: Incompatible stack types: I4 vs Obj
			//IL_01a4->IL01a8: Incompatible stack heights: 1 vs 2
			//IL_0287->IL01a8: Incompatible stack types: I4 vs Ref
			//IL_0b28->IL01a8: Incompatible stack heights: 4 vs 2
			//IL_0384->IL01a8: Incompatible stack heights: 4 vs 2
			//IL_0340->IL01a8: Incompatible stack heights: 4 vs 2
			//IL_0b0b->IL01a8: Incompatible stack heights: 3 vs 2
			//IL_042e->IL01a8: Incompatible stack heights: 3 vs 2
			//IL_0246->IL01a8: Incompatible stack heights: 3 vs 2
			//IL_030d->IL01a8: Incompatible stack heights: 1 vs 2
			//IL_03bc->IL01a8: Incompatible stack types: I4 vs Ref
			//IL_0328->IL01a8: Incompatible stack heights: 3 vs 2
			//IL_040f->IL01a8: Incompatible stack heights: 3 vs 2
			//IL_026d->IL01a8: Incompatible stack heights: 3 vs 2
			//IL_03f2->IL01a8: Incompatible stack heights: 3 vs 2
			//IL_0237->IL01a8: Incompatible stack heights: 3 vs 2
			//IL_03a3->IL01a8: Incompatible stack heights: 1 vs 2
			//IL_02b0->IL01a8: Incompatible stack heights: 3 vs 2
			//IL_0b33->IL01a8: Incompatible stack heights: 4 vs 2
			//IL_0af1->IL01a8: Incompatible stack heights: 1 vs 2
			//IL_0b16->IL01a8: Incompatible stack heights: 3 vs 2
			//IL_0439->IL01a8: Incompatible stack heights: 3 vs 2
			//IL_070e->IL0468: Incompatible stack heights: 2 vs 1
			//IL_0318->IL01a8: Incompatible stack heights: 1 vs 2
			//IL_0333->IL01a8: Incompatible stack heights: 3 vs 2
			//IL_041a->IL01a8: Incompatible stack heights: 3 vs 2
			//IL_0278->IL01a8: Incompatible stack heights: 3 vs 2
			//IL_03fd->IL01a8: Incompatible stack heights: 3 vs 2
			//IL_0374->IL01a8: Incompatible stack types: I4 vs Ref
			//IL_02ca->IL01a8: Incompatible stack types: I4 vs Ref
			//IL_0258->IL01a8: Incompatible stack types: I4 vs Ref
			//IL_03d0->IL01a8: Incompatible stack types: I4 vs Ref
			//IL_02de->IL01a8: Incompatible stack heights: 1 vs 2
			//IL_03ae->IL01a8: Incompatible stack heights: 1 vs 2
			//IL_03e2->IL01a8: Incompatible stack types: I4 vs Ref
			//IL_0afc->IL01a8: Incompatible stack heights: 1 vs 2
			//IL_0551->IL05ac: Incompatible stack heights: 0 vs 1
			//IL_0551->IL0611: Incompatible stack heights: 0 vs 1
			//IL_0551->IL0700: Incompatible stack heights: 0 vs 1
			//IL_062c->IL0468: Incompatible stack types: I4 vs Ref
			//IL_05c7->IL0468: Incompatible stack types: I4 vs Ref
			//IL_0464->IL0468: Incompatible stack types: I4 vs Ref
			//IL_02e9->IL01a8: Incompatible stack heights: 1 vs 2
			//IL_057f->IL0468: Incompatible stack heights: 3 vs 1
			//IL_0566->IL0468: Incompatible stack heights: 3 vs 1
			//IL_0606->IL0468: Incompatible stack heights: 2 vs 1
			//IL_07eb->IL0468: Incompatible stack heights: 2 vs 1
			//IL_0720->IL0468: Incompatible stack heights: 0 vs 1
			//IL_0934->IL0468: Incompatible stack types: I4 vs Ref
			//IL_0675->IL0468: Incompatible stack heights: 3 vs 1
			//IL_0965->IL0468: Incompatible stack heights: 0 vs 1
			//IL_08df->IL0468: Incompatible stack heights: 3 vs 1
			//IL_0a09->IL0468: Incompatible stack heights: 4 vs 1
			//IL_06b9->IL0468: Incompatible stack heights: 2 vs 1
			//IL_07a3->IL0b33: Incompatible stack heights: 0 vs 1
			//IL_0859->IL0468: Incompatible stack heights: 3 vs 1
			//IL_0700->IL0468: Incompatible stack heights: 4 vs 1
			//IL_06c9->IL0b33: Incompatible stack heights: 0 vs 1
			//IL_06a9->IL0468: Incompatible stack heights: 4 vs 1
			//IL_0877->IL0468: Incompatible stack types: I4 vs Ref
			//IL_06f0->IL0468: Incompatible stack heights: 3 vs 1
			//IL_0793->IL0468: Incompatible stack heights: 2 vs 1
			//IL_05ac->IL0468: Incompatible stack heights: 3 vs 1
			//IL_08ef->IL0468: Incompatible stack heights: 3 vs 1
			//IL_0a49->IL0468: Incompatible stack heights: 3 vs 1
			//IL_097f->IL0468: Incompatible stack types: I4 vs Ref
			//IL_065a->IL0468: Incompatible stack heights: 2 vs 1
			//IL_08a6->IL0b33: Incompatible stack heights: 0 vs 1
			//IL_0a59->IL0393: Incompatible stack heights: 0 vs 1
			//IL_0991->IL0468: Incompatible stack heights: 2 vs 1
			//IL_0739->IL0468: Incompatible stack heights: 3 vs 1
			//IL_09ad->IL0468: Incompatible stack heights: 2 vs 1
			//IL_063f->IL0468: Incompatible stack heights: 0 vs 1
			//IL_0884->IL0468: Incompatible stack types: I4 vs Ref
			//IL_067a->IL03bc: Incompatible stack heights: 0 vs 1
			//IL_09dc->IL0468: Incompatible stack heights: 4 vs 1
			//IL_0866->IL0468: Incompatible stack heights: 2 vs 1
			//IL_0896->IL0468: Incompatible stack heights: 3 vs 1
			//IL_09cc->IL0468: Incompatible stack types: I4 vs Ref
			//IL_07de->IL0468: Incompatible stack types: I4 vs Ref
			//IL_058a->IL0468: Incompatible stack heights: 3 vs 1
			//IL_0611->IL0468: Incompatible stack heights: 2 vs 1
			//IL_072b->IL0468: Incompatible stack types: I4 vs Ref
			//IL_08c4->IL0468: Incompatible stack heights: 0 vs 1
			//IL_0970->IL0468: Incompatible stack types: I4 vs Ref
			//IL_0a14->IL0468: Incompatible stack heights: 4 vs 1
			//IL_06c4->IL0468: Incompatible stack heights: 2 vs 1
			//IL_09f6->IL0468: Incompatible stack types: I4 vs Ref
			//IL_0811->IL0468: Incompatible stack types: I4 vs Ref
			//IL_0949->IL0468: Incompatible stack heights: 0 vs 1
			//IL_0909->IL0468: Incompatible stack types: I4 vs Ref
			//IL_079e->IL0468: Incompatible stack heights: 2 vs 1
			//IL_0841->IL0468: Incompatible stack heights: 0 vs 1
			//IL_0778->IL0468: Incompatible stack heights: 0 vs 1
			//IL_0a54->IL0468: Incompatible stack heights: 3 vs 1
			//IL_0665->IL0468: Incompatible stack heights: 2 vs 1
			//IL_059c->IL0468: Incompatible stack types: I4 vs Ref
			//IL_05d9->IL0468: Incompatible stack types: I4 vs Ref
			//IL_099c->IL0468: Incompatible stack heights: 2 vs 1
			//IL_09b8->IL0468: Incompatible stack heights: 2 vs 1
			//IL_064a->IL0468: Incompatible stack types: I4 vs Ref
			//IL_08a1->IL0468: Incompatible stack heights: 3 vs 1
			//IL_08cf->IL0468: Incompatible stack types: I4 vs Ref
			//IL_0954->IL0468: Incompatible stack types: I4 vs Ref
			//IL_084c->IL0468: Incompatible stack types: I4 vs Ref
			//IL_0783->IL0468: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			object obj2 = obj;
			while (true)
			{
				scoped ref byte reference;
				object obj3;
				switch ((int)obj2)
				{
				default:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						obj2 = 3;
					}
					break;
				case 5:
					_ = -2;
					if (2 != 0)
					{
						_ = 2;
					}
					break;
				case 3:
					if ((nuint)(nint)obj <= (nuint)3u)
					{
						_ = 6;
						goto IL_0088;
					}
					goto IL_00f5;
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						obj2 = 0;
					}
					break;
				case 2:
					_ = 4;
					break;
				case 4:
					return;
					IL_00f5:
					reference = ref Unsafe.As<_003CStartAntiCheatAsync_003Ed__34, byte>(ref this);
					obj3 = 2;
					goto IL_0088;
					IL_0088:
					while (true)
					{
						ref byte reference2;
						switch ((int)obj3)
						{
						case 7:
							break;
						case 2:
							obj3 = obj;
							if (Unsafe.AsPointer(ref this) == null)
							{
								if (2 == 0)
								{
									obj3 = 5;
								}
								continue;
							}
							break;
						default:
							goto IL_00f5;
						case 1:
						case 5:
							obj = (object)Unsafe.AsPointer(ref reference);
							obj3 = 8;
							continue;
						case 4:
						case 6:
							if (false)
							{
								_ = 3;
							}
							continue;
						case 8:
							_ = null;
							_ = null;
							_ = 0;
							if (4 == 0)
							{
								_ = 4;
							}
							continue;
						case 3:
							{
								if ((nuint)(nint)obj > (nuint)2u)
								{
									if (1 == 0)
									{
										_ = 2;
									}
									goto IL_01a8;
								}
								goto IL_034f;
							}
							IL_034f:
							reference2 = ref *(byte*)10;
							goto IL_01a8;
							IL_01a8:
							while (true)
							{
								switch ((uint)Unsafe.AsPointer(ref reference2))
								{
								case 7u:
								case 17u:
									break;
								case 24u:
									_ = 15;
									continue;
								case 11u:
									_ = 22;
									continue;
								case 22u:
									if (obj != null)
									{
										reference2 = ref *(byte*)12;
										continue;
									}
									goto case 9u;
								case 16u:
									if (21 == 0)
									{
										_ = 5;
									}
									continue;
								default:
									obj = (object)Unsafe.AsPointer(ref this);
									reference2 = ref *(byte*)11;
									continue;
								case 27u:
									_ = 18;
									continue;
								case 21u:
									reference2 = ref Unsafe.As<_003CStartAntiCheatAsync_003Ed__34, byte>(ref this);
									if (20 != 0)
									{
										reference2 = ref *(byte*)27;
									}
									continue;
								case 25u:
									if ((nint)obj == 1)
									{
										if (0 == 0)
										{
											_ = 0;
										}
										continue;
									}
									goto case 8u;
								case 12u:
									obj = 2000;
									if (4 == 0)
									{
										_ = 29;
									}
									continue;
								case 14u:
									if (1 == 0)
									{
										_ = 1;
									}
									continue;
								case 6u:
									_ = 0;
									_ = 20;
									continue;
								case 20u:
									goto IL_034f;
								case 19u:
									reference2 = ref *(byte*)(&obj);
									if (4 != 0)
									{
										reference2 = ref *(byte*)5;
									}
									continue;
								case 4u:
									obj = 3;
									_ = 14;
									continue;
								case 28u:
									return;
								case 26u:
									goto IL_0393;
								case 13u:
									obj = (object)Unsafe.AsPointer(ref this);
									reference2 = ref *(byte*)24;
									continue;
								case 3u:
								case 5u:
								case 23u:
									goto IL_03bc;
								case 29u:
									if (&obj == null)
									{
										reference2 = ref *(byte*)4;
										continue;
									}
									goto case 19u;
								case 18u:
									if (3 == 0)
									{
										_ = 3;
									}
									continue;
								case 15u:
									obj = -1;
									if (11 == 0)
									{
										_ = 19;
									}
									continue;
								case 9u:
									if (3 != 0)
									{
										_ = 17;
									}
									continue;
								case 10u:
									switch ((int)obj)
									{
									default:
										if (2 == 0)
										{
											reference = ref *(byte*)2;
										}
										goto IL_0468;
									case 1:
										goto IL_05ac;
									case 0:
										goto IL_0611;
									case 2:
										goto IL_0700;
										IL_05ac:
										obj = (object)Unsafe.AsPointer(ref this);
										if (23 == 0)
										{
											reference = ref *(byte*)55;
										}
										goto IL_0468;
										IL_0468:
										while (true)
										{
											switch ((uint)Unsafe.AsPointer(ref reference))
											{
											case 17u:
											case 23u:
											case 42u:
												break;
											case 46u:
												goto IL_0393;
											case 53u:
												goto IL_03bc;
											case 3u:
												obj = -1;
												_ = 39;
												continue;
											case 2u:
												obj = (object)Unsafe.AsPointer(ref this);
												if (37 == 0)
												{
													_ = 43;
												}
												continue;
											case 43u:
												if (&obj == null)
												{
													reference = ref *(byte*)33;
													continue;
												}
												goto case 12u;
											case 33u:
												obj = 0;
												_ = 48;
												continue;
											case 5u:
												goto IL_05ac;
											case 45u:
												if (Unsafe.AsPointer(ref this) != null)
												{
													reference = ref *(byte*)28;
													continue;
												}
												goto IL_03bc;
											case 4u:
												if (19 == 0)
												{
													_ = 11;
												}
												continue;
											case 13u:
												goto IL_0611;
											case 50u:
												obj = (object)Unsafe.AsPointer(ref this);
												if (35 != 0)
												{
													reference = ref *(byte*)1;
												}
												continue;
											case 40u:
												if (23 == 0)
												{
													_ = 54;
												}
												continue;
											case 9u:
												obj = -1;
												_ = 12;
												continue;
											case 26u:
											case 28u:
												_ = 1;
												obj = 0;
												_ = 38;
												continue;
											case 16u:
												if (1 == 0)
												{
													_ = 8;
												}
												continue;
											case 31u:
												obj = 2;
												_ = 32;
												continue;
											case 20u:
												_ = ref obj;
												_ = 24;
												continue;
											case 22u:
												goto IL_0700;
											case 7u:
												obj++;
												if (1 == 0)
												{
													reference = ref *(byte*)1;
												}
												continue;
											case 48u:
												_ = 20;
												continue;
											case 44u:
												return;
											case 35u:
												if (&obj == null)
												{
													if (25 != 0)
													{
														reference = ref *(byte*)47;
													}
													continue;
												}
												goto case 18u;
											case 32u:
												if (40 != 0)
												{
													_ = 56;
												}
												continue;
											case 1u:
											case 52u:
												if ((nint)obj < ((Array)obj).Length)
												{
													reference = ref *(byte*)37;
													continue;
												}
												goto case 34u;
											case 6u:
												_ = 9;
												continue;
											case 41u:
												return;
											case 21u:
												if ((nint)obj != 200)
												{
													reference = ref *(byte*)42;
													continue;
												}
												goto case 14u;
											case 24u:
												return;
											case 34u:
												if (Unsafe.AsPointer(ref this) != null)
												{
													break;
												}
												if (17 == 0)
												{
													reference = ref *(byte*)27;
												}
												continue;
											case 19u:
												_ = null;
												_ = 46;
												continue;
											case 55u:
												_ = 36;
												continue;
											case 29u:
											case 37u:
												obj = ((object[])obj)[obj];
												reference = ref *(byte*)49;
												continue;
											case 51u:
												obj = 0;
												reference = ref *(byte*)52;
												continue;
											case 56u:
												_ = ref obj;
												if (11 == 0)
												{
													_ = 44;
												}
												continue;
											case 11u:
												if (&obj == null)
												{
													if (31 == 0)
													{
														reference = ref *(byte*)24;
													}
													continue;
												}
												goto case 39u;
											case 14u:
												_ = 4;
												continue;
											case 36u:
												obj = -1;
												_ = 18;
												continue;
											case 30u:
												reference = ref Unsafe.As<_003CStartAntiCheatAsync_003Ed__34, byte>(ref this);
												if (3 == 0)
												{
													reference = ref *(byte*)3;
												}
												continue;
											case 8u:
												obj = (object)Unsafe.AsPointer(ref this);
												reference = ref *(byte*)51;
												continue;
											case 25u:
											case 27u:
												if ((nint)Unsafe.AsPointer(ref this) <= unchecked((nint)null))
												{
													if (10 == 0)
													{
														reference = ref *(byte*)1;
													}
													continue;
												}
												goto case 50u;
											case 12u:
												obj = (object)(&obj);
												if (9 == 0)
												{
													reference = ref *(byte*)16;
												}
												continue;
											case 39u:
												obj = (object)(&obj);
												reference = ref *(byte*)15;
												continue;
											case 47u:
												obj = 1;
												if (40 == 0)
												{
													_ = 4;
												}
												continue;
											case 49u:
												if (6 == 0)
												{
													_ = 7;
												}
												continue;
											default:
												if (obj != null)
												{
													reference = ref *(byte*)23;
													continue;
												}
												goto case 45u;
											case 54u:
												_ = ref obj;
												_ = 41;
												continue;
											case 18u:
												reference = ref *(byte*)(&obj);
												if (false)
												{
													reference = ref *(byte*)null;
												}
												continue;
											case 15u:
												_ = null;
												_ = 1;
												if (1 == 0)
												{
													_ = 21;
												}
												continue;
											case 38u:
												_ = ref obj;
												obj = obj;
												if (7 == 0)
												{
													_ = 11;
												}
												continue;
											}
											break;
										}
										break;
										IL_0700:
										obj = (object)Unsafe.AsPointer(ref this);
										_ = 30;
										goto IL_0468;
										IL_0611:
										obj = (object)Unsafe.AsPointer(ref this);
										if (6 != 0)
										{
											reference = ref *(byte*)6;
										}
										goto IL_0468;
									}
									break;
								case 2u:
									if ((nint)obj != 3)
									{
										if (11 != 0)
										{
											_ = 16;
										}
										continue;
									}
									goto case 13u;
								case 8u:
									_ = null;
									if (23 != 0)
									{
										_ = 19;
									}
									continue;
								case 1u:
									{
										_ = ref obj;
										if (21 == 0)
										{
											_ = 28;
										}
										continue;
									}
									IL_03bc:
									if (obj != null)
									{
										reference2 = ref *(byte*)7;
										continue;
									}
									goto case 6u;
									IL_0393:
									obj = (object)Unsafe.AsPointer(ref this);
									if (20 != 0)
									{
										_ = 25;
									}
									continue;
								}
								break;
							}
							break;
						}
						break;
					}
					goto case 5;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_2A00(object P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
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
				case 0:
					return;
				case 1:
					if (false)
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
	public HeypixelProtocol()
	{
		//IL_001c: Expected Obj, but got I4
		//IL_002a: Expected Obj, but got I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_0145: Expected I4, but got Obj
		//IL_0133->IL013c: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 19;
		object obj2 = (obj = obj);
		obj = 0;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		obj++;
		obj = obj;
		if (0 == 0)
		{
			obj2 = 0;
		}
		switch ((int)obj2)
		{
		case 0:
			break;
		}
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
	public void OnItemUse(EventPacket<ServerboundUseItemPacket> @event)
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
	internal void 㐀(EventPacket<ServerboundKnownPacksPacket> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0047->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = P_0;
				if (false)
				{
					obj2 = 0;
				}
				break;
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
	internal void 㸀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0195: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I4
		//IL_011a: Expected Obj, but got I4
		//IL_003d->IL0041: Incompatible stack heights: 1 vs 0
		//IL_009f->IL0041: Incompatible stack heights: 1 vs 0
		//IL_01bf->IL0041: Incompatible stack heights: 2 vs 0
		//IL_019f->IL0041: Incompatible stack heights: 3 vs 0
		//IL_010b->IL0041: Incompatible stack heights: 4 vs 0
		//IL_0146->IL0041: Incompatible stack heights: 2 vs 0
		//IL_016c->IL0041: Incompatible stack heights: 3 vs 0
		//IL_0126->IL0041: Incompatible stack heights: 3 vs 0
		//IL_00e8->IL0041: Incompatible stack heights: 1 vs 0
		//IL_0151->IL0041: Incompatible stack heights: 2 vs 0
		//IL_00b9->IL0041: Incompatible stack heights: 1 vs 0
		//IL_0177->IL0041: Incompatible stack heights: 3 vs 0
		//IL_018a->IL0041: Incompatible stack heights: 1 vs 0
		//IL_0131->IL0041: Incompatible stack heights: 3 vs 0
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		switch ((int)obj)
		{
		case 1:
			if (P_0 == null)
			{
				_ = 2;
				goto IL_0041;
			}
			goto IL_0083;
		case 0:
			break;
			IL_0041:
			while (true)
			{
				switch ((int)/*Error near IL_007e: Stack underflow*/)
				{
				case 10:
					obj = (object)/*Error near IL_00a2: Stack underflow*/;
					if (1 == 0)
					{
						_ = 5;
					}
					continue;
				case 2:
					return;
				case 6:
					if (obj == null)
					{
						_ = 9;
						continue;
					}
					goto case 3;
				case 9:
					return;
				case 4:
				case 5:
					_ = 8;
					continue;
				case 13:
					_ = 4;
					obj = 3;
					if (11 != 0)
					{
						_ = 3;
					}
					continue;
				case 8:
					if (7 != 0)
					{
						_ = 6;
					}
					continue;
				case 11:
					_ = 4;
					obj = 3;
					if (0 == 0)
					{
						_ = 1;
					}
					continue;
				case 12:
					if (obj == null)
					{
						_ = 13;
						continue;
					}
					goto case 10;
				case 3:
					_ = 4;
					obj = 32;
					_ = 12;
					continue;
				case 1:
					obj = obj;
					_ = 4;
					continue;
				case 7:
					return;
				}
				break;
			}
			goto IL_0083;
			IL_0083:
			obj = P_0;
			if (6 != 0)
			{
				_ = 6;
			}
			goto IL_0041;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 䀀(EventPacket<ServerboundHandshakePacket> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00ad->IL0019: Incompatible stack heights: 0 vs 1
		//IL_005d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_004f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0079->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0019: Incompatible stack heights: 0 vs 1
		//IL_009d->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				if ((nint)obj != 2)
				{
					return;
				}
				obj2 = 4;
				break;
			case 2:
				_ = 1;
				_ = 5;
				break;
			case 3:
				obj2 = this;
				if (2 == 0)
				{
					obj2 = 2;
				}
				break;
			case 4:
				if ((nint)obj == 766)
				{
					return;
				}
				if (3 == 0)
				{
					obj2 = 2;
				}
				break;
			case 1:
				obj = P_0;
				if (false)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void 䈀(EventPacket<ServerboundUseItemPacket> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778394, new IntPtr(2737367948364L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 䌀(EventPacket<ServerboundUseItemPacket> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0045->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = this;
				if (0 == 0)
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
	internal unsafe void 䐀(EventPacket<ServerboundUseItemPacket> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778389, new IntPtr(2737367942124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte 䔀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
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
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
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
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0045->IL0019: Incompatible stack heights: 2 vs 1
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
	internal unsafe void 一(EventPacket<ClientboundSetEntityMetadataPacket> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_004a: Expected I4, but got Obj
		//IL_00b6: Expected Obj, but got I4
		//IL_008b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_010c->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0096->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0061->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00f3->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0158->IL0019: Incompatible stack heights: 3 vs 1
		//IL_007b->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00fe->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_012c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00dd->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0137->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				{
					object obj3 = obj;
					if (&obj == null)
					{
						_ = 6;
						break;
					}
					if ((nint)obj != 65)
					{
						if (false)
						{
							_ = 0;
						}
						break;
					}
					obj = obj ?? obj3;
					if (8 != 0)
					{
						_ = 6;
					}
					break;
				}
				case 2:
					obj = P_0;
					if (false)
					{
						obj2 = 1;
					}
					break;
				case 1:
					if (P_0 == null)
					{
						return;
					}
					goto end_IL_0019;
				case 6:
					return;
				case 3:
					return;
				case 10:
					if (obj != null)
					{
						return;
					}
					if (false)
					{
						obj2 = 9;
					}
					break;
				case 9:
					_ = 1;
					_ = 3;
					break;
				case 0:
					return;
				case 5:
					if ((nint)obj != 1)
					{
					}
					_ = 10;
					break;
				}
				continue;
				end_IL_0019:
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
	internal void 倀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0048->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0053->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0085->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0090->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				_ = 1;
				if (1 == 0)
				{
					_ = 0;
				}
				break;
			case 3:
				if (P_0 == null)
				{
					if (false)
					{
						obj2 = 2;
					}
					break;
				}
				goto default;
			case 1:
				return;
			case 2:
				_ = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void 儀(double P_0, double P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0043->IL0019: Incompatible stack heights: 5 vs 1
		//IL_004e->IL0019: Incompatible stack heights: 5 vs 1
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
			case 0:
				return;
			case 1:
				_ = (int)P_0;
				_ = (int)P_1;
				if (0 == 0)
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
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0045->IL0019: Incompatible stack heights: 2 vs 1
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
	internal unsafe void 唀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778386, new IntPtr(2737367941084L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 夀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0048->IL004c: Incompatible stack heights: 1 vs 0
		//IL_0092->IL004c: Incompatible stack heights: 1 vs 0
		//IL_00e9->IL004c: Incompatible stack heights: 1 vs 0
		//IL_009d->IL004c: Incompatible stack heights: 1 vs 0
		//IL_00fb->IL004c: Incompatible stack heights: 1 vs 0
		//IL_0162->IL004c: Incompatible stack heights: 1 vs 0
		//IL_00be->IL004c: Incompatible stack heights: 1 vs 0
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		switch ((int)obj)
		{
		case 0:
			break;
		case 1:
			obj = P_0;
			if (0 == 0)
			{
				_ = 0;
			}
			while (true)
			{
				switch ((int)/*Error near IL_007d: Stack underflow*/)
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
					if (10 == 0)
					{
						_ = 10;
					}
					break;
				case 4:
				case 8:
					if (obj == null)
					{
						return;
					}
					if (7 == 0)
					{
						_ = 3;
					}
					break;
				default:
					obj = obj;
					if (true)
					{
						_ = 1;
					}
					break;
				case 5:
					if (obj != null)
					{
						return;
					}
					_ = 8;
					break;
				case 1:
					if (obj == null)
					{
						if (6 == 0)
						{
							_ = 6;
						}
						break;
					}
					goto case 5;
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
	internal void 嬀(EventPacket<ServerboundUseItemOnPacket> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105->IL0019: Incompatible stack heights: 27 vs 1
		//IL_0065->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0084->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0110->IL0019: Incompatible stack heights: 27 vs 1
		//IL_0070->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008f->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj = P_0;
				if (4 == 0)
				{
					obj2 = 1;
				}
				break;
			case 1:
				if (this == null)
				{
					return;
				}
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 4:
				_ = (double)(float)this;
				_ = (double)(float)this;
				_ = (double)(float)this;
				_ = (double)((float)obj + obj);
				_ = (double)((float)obj + obj);
				_ = (double)((float)obj + obj);
				_ = (double)obj;
				_ = (double)obj;
				_ = (double)obj;
				if (2 == 0)
				{
					_ = 2;
				}
				break;
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
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object 开()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778478, new IntPtr(2737367934844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 怀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0063->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0089->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006e->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				if (3 == 0)
				{
					if (0 == 0)
					{
						obj2 = 1;
					}
					break;
				}
				return;
			case 3:
				return;
			case 1:
				obj2 = this;
				if (false)
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
	internal void 愀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003c->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0047->IL0019: Incompatible stack heights: 3 vs 1
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
				if (false)
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
	internal void 搀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_004d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0058->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a2->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				if (1 == 0)
				{
					_ = 1;
				}
				break;
			case 3:
				return;
			case 4:
				if (this == null)
				{
					return;
				}
				obj2 = 2;
				break;
			case 5:
				if (P_0 != null)
				{
					return;
				}
				obj2 = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 栀(EventPacket<ClientboundJoinGamePacket> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_004a: Expected I4, but got Obj
		//IL_007e: Expected Obj, but got I4
		//IL_008c: Expected Obj, but got I4
		//IL_0121->IL0019: Incompatible stack heights: 3 vs 1
		//IL_006e->IL0019: Incompatible stack heights: 6 vs 1
		//IL_0133->IL0019: Incompatible stack heights: 3 vs 1
		//IL_014f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00f9->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0111->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a0->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0079->IL0019: Incompatible stack heights: 6 vs 1
		//IL_0104->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00df->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0142->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00bf->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00ab->IL0019: Incompatible stack heights: 4 vs 1
		//IL_00ea->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ca->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj = this;
				_ = ref obj;
				_ = 0;
				if (false)
				{
					_ = 3;
				}
				break;
			case 10:
				obj = 1;
				obj = obj;
				obj = 0;
				obj = obj;
				if (6 == 0)
				{
					_ = 9;
				}
				break;
			case 0:
				return;
			case 9:
				if (this != null)
				{
					if (8 != 0)
					{
						obj2 = 8;
					}
				}
				else
				{
					_ = null;
					_ = 6;
				}
				break;
			case 7:
				if (this == null)
				{
					if (0 == 0)
					{
						obj2 = 1;
					}
					break;
				}
				goto case 5;
			case 5:
				_ = 1;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 6:
				obj2 = 2;
				break;
			case 1:
				_ = 5;
				break;
			case 3:
				_ = 4;
				break;
			case 8:
				return;
			case 4:
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
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
	internal void 爀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0061->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0043->IL0019: Incompatible stack heights: 0 vs 1
		//IL_006c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008a->IL008e: Incompatible stack heights: 1 vs 0
		//IL_0160->IL008e: Incompatible stack heights: 3 vs 0
		//IL_00cb->IL008e: Incompatible stack heights: 5 vs 0
		//IL_016b->IL008e: Incompatible stack heights: 3 vs 0
		//IL_014d->IL008e: Incompatible stack heights: 1 vs 0
		//IL_010b->IL008e: Incompatible stack heights: 1 vs 0
		//IL_00eb->IL008e: Incompatible stack heights: 1 vs 0
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				obj = P_0;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 3:
				return;
			default:
				obj = obj;
				if (2 == 0)
				{
					obj2 = 2;
				}
				break;
			case 2:
				obj = obj;
				if (true)
				{
					_ = 1;
				}
				while (true)
				{
					switch ((int)/*Error near IL_00b3: Stack underflow*/)
					{
					case 4:
						return;
					case 5:
						return;
					case 6:
						return;
					case 7:
						_ = 6;
						break;
					case 1:
						if (obj == null)
						{
							if (0 == 0)
							{
								_ = 0;
							}
							break;
						}
						goto case 7;
					default:
						if (obj == null)
						{
							if (3 == 0)
							{
								_ = 4;
							}
							break;
						}
						goto case 3;
					case 3:
						if ((nint)obj != 250)
						{
							return;
						}
						_ = 2;
						break;
					case 2:
						if (5 != 0)
						{
							_ = 5;
						}
						break;
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
		//IL_0010: Expected Obj, but got I4
		//IL_0042: Expected I4, but got Obj
		//IL_00df: Expected Obj, but got Ref
		//IL_00e9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00bf->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0061->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00cf->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00fd->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00a5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00da->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0108->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				obj2 = this;
				if (6 == 0)
				{
					obj2 = 6;
				}
				break;
			case 7:
				_ = 3;
				break;
			case 6:
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				if ((long)(obj - (object)this) > 5000L)
				{
					obj2 = 7;
					break;
				}
				goto case 6;
			case 8:
				return;
			case 4:
				obj = (object)/*Error near IL_00c3: Stack underflow*/;
				if (false)
				{
					obj2 = 0;
				}
				break;
			default:
				obj = (object)(&obj);
				obj2 = 2;
				break;
			case 1:
				return;
			case 5:
				if (this == null)
				{
					return;
				}
				if (4 == 0)
				{
					obj2 = 3;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void 甀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0041->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0067->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				if (false)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			case 2:
				if (true)
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
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte 眀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778467, new IntPtr(2737367941084L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}
}
