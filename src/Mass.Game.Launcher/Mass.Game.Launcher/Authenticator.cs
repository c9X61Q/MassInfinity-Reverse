using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Serilog;

namespace Mass.Game.Launcher;

public abstract class Authenticator : IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CListenAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Authenticator _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object CheckInternalSingleton;

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
		internal static bool DecorateExpandableParser()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ObserveTracker()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00ﰀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778575, new IntPtr(2737337565804L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00ﴀ(object P_0)
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
		internal static object _FF00_FE00()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778574, new IntPtr(2737337536684L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00Ā()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0378: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_01d8: Expected Obj, but got Ref
			//IL_01e7: Expected Obj, but got I4
			//IL_01a2: Expected Obj, but got I4
			//IL_0189: Expected Obj, but got I4
			//IL_0359->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0384->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0369->IL0019: Incompatible stack heights: 2 vs 1
			//IL_038f->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0374->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00c1->IL0079: Incompatible stack heights: 1 vs 0
			//IL_0075->IL0079: Incompatible stack heights: 1 vs 0
			//IL_015f->IL0100: Incompatible stack types: I4 vs Ref
			//IL_00f1->IL0100: Incompatible stack heights: 0 vs 2
			//IL_00a9->IL0079: Incompatible stack heights: 1 vs 0
			//IL_0135->IL014c: Incompatible stack heights: 1 vs 0
			//IL_00fc->IL0100: Incompatible stack heights: 1 vs 2
			//IL_016d->IL0100: Incompatible stack heights: 4 vs 2
			//IL_01e2->IL0100: Incompatible stack types: I4 vs Ref
			//IL_01f2->IL0100: Incompatible stack heights: 4 vs 2
			//IL_017d->IL0100: Incompatible stack heights: 5 vs 2
			//IL_01af->IL0100: Incompatible stack heights: 3 vs 2
			//IL_01d4->IL0100: Incompatible stack types: I4 vs Ref
			//IL_014c->IL0100: Incompatible stack types: I4 vs Ref
			//IL_01ba->IL0100: Incompatible stack heights: 3 vs 2
			//IL_0100->IL0100: Incompatible stack heights: 3 vs 2
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						obj2 = 1;
					}
					break;
				case 4:
					if (obj != null)
					{
						if (0 == 0)
						{
							_ = 0;
						}
						goto IL_0079;
					}
					goto IL_00a9;
				case 5:
					return;
				default:
					_ = 5;
					break;
				case 3:
					goto IL_0359;
				case 1:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (4 == 0)
						{
							obj2 = 3;
						}
						break;
					}
					IL_0079:
					while (true)
					{
						ref object reference;
						switch ((int)/*Error near IL_0092: Stack underflow*/)
						{
						default:
							if (obj == null)
							{
								_ = 3;
								continue;
							}
							break;
						case 4:
							break;
						case 1:
							if (obj == null)
							{
								if (4 != 0)
								{
									_ = 0;
								}
								goto IL_0100;
							}
							goto IL_014c;
						case 3:
							goto IL_0359;
							IL_0100:
							while (true)
							{
								switch ((uint)Unsafe.AsPointer(ref reference))
								{
								case 5u:
									if (&obj == null)
									{
										reference = ref *(object*)10;
										continue;
									}
									goto case 3u;
								case 7u:
									goto IL_014c;
								case 1u:
									_ = 9;
									continue;
								case 9u:
									_ = ref obj;
									_ = 6;
									continue;
								case 11u:
									obj = 8;
									continue;
								case 10u:
									obj = 0;
									if (0 == 0)
									{
										_ = 1;
									}
									continue;
								case 3u:
									reference = ref obj;
									if (0 == 0)
									{
										reference = ref *(object*)null;
									}
									continue;
								case 2u:
								case 4u:
									obj = (object)Unsafe.AsPointer(ref this);
									reference = ref *(object*)11;
									continue;
								case 8u:
									obj = -1;
									_ = 3;
									continue;
								case 6u:
									return;
								}
								break;
							}
							goto default;
							IL_014c:
							obj = obj;
							reference = ref *(object*)5;
							goto IL_0100;
						}
						break;
					}
					goto IL_00a9;
					IL_0359:
					_ = -2;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
					IL_00a9:
					if (1 == 0)
					{
						_ = 1;
					}
					goto IL_0079;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00Ȁ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778573, new IntPtr(2737337561644L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_0300()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00Ѐ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778572, new IntPtr(2737337551244L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CListenAuthenticationConnectAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TcpListener listener;

		public Authenticator _003C_003E4__this;

		private TaskAwaiter<TcpClient> _003C_003Eu__1;

		internal static object DecorateAdjustableHandler;

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
		internal static bool DecorateGenericStruct()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectRandomReporter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_F400(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778571, new IntPtr(2737337561644L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_F500(object P_0)
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
		private unsafe sealed void _FF00_F600(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778570, new IntPtr(2737337542924L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_F700()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_F800()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778569, new IntPtr(2737337542924L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00豈()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_004d: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_0180: Expected Obj, but got Ref
			//IL_016f: Expected Obj, but got I4
			//IL_0144: Expected Obj, but got Ref
			//IL_018f: Expected Obj, but got Ref
			//IL_0109: Expected Obj, but got I4
			//IL_00c2: Expected I4, but got Obj
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0068->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0057->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0049->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0073->IL0019: Incompatible stack heights: 2 vs 1
			//IL_018a->IL0089: Incompatible stack types: I4 vs Obj
			//IL_0085->IL0089: Incompatible stack types: I4 vs Obj
			//IL_023e->IL0019: Incompatible stack types: I4 vs Ref
			//IL_00f2->IL0089: Incompatible stack heights: 4 vs 1
			//IL_017a->IL0089: Incompatible stack heights: 3 vs 1
			//IL_014e->IL0089: Incompatible stack types: I4 vs Obj
			//IL_00d7->IL0089: Incompatible stack heights: 2 vs 1
			//IL_0199->IL0089: Incompatible stack types: I4 vs Obj
			//IL_015b->IL0089: Incompatible stack heights: 2 vs 1
			//IL_0114->IL0089: Incompatible stack heights: 3 vs 1
			//IL_0104->IL0089: Incompatible stack types: I4 vs Obj
			//IL_0140->IL0089: Incompatible stack types: I4 vs Obj
			//IL_00e2->IL0089: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			ref _003CListenAuthenticationConnectAsync_003Ed__8 reference = ref *(_003CListenAuthenticationConnectAsync_003Ed__8*)obj;
			while (true)
			{
				object obj2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					return;
				case 5u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CListenAuthenticationConnectAsync_003Ed__8*)4;
					break;
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CListenAuthenticationConnectAsync_003Ed__8*)2;
					break;
				case 0u:
					return;
				case 1u:
					_ = -2;
					if (3 == 0)
					{
						_ = 3;
					}
					break;
				case 2u:
					if (obj == null)
					{
						obj2 = 5;
						goto IL_0089;
					}
					goto IL_017a;
				case 3u:
					{
						reference = ref this;
						if (0 == 0)
						{
							reference = ref *(_003CListenAuthenticationConnectAsync_003Ed__8*)null;
						}
						break;
					}
					IL_017a:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 3;
					goto IL_0089;
					IL_0089:
					while (true)
					{
						switch ((int)obj2)
						{
						case 9:
							return;
						case 1:
							break;
						case 8:
							if (false)
							{
								_ = 0;
							}
							continue;
						default:
							_ = ref obj;
							_ = 9;
							continue;
						case 3:
							if (&obj == null)
							{
								obj2 = 12;
								continue;
							}
							goto case 10;
						case 12:
							obj = 0;
							_ = 8;
							continue;
						case 7:
							obj2 = obj;
							if (true)
							{
								obj2 = 0;
							}
							continue;
						case 4:
						case 5:
							obj = (object)Unsafe.AsPointer(ref this);
							obj2 = 11;
							continue;
						case 11:
							_ = 2;
							continue;
						case 2:
							obj = -1;
							_ = 10;
							continue;
						case 6:
							goto IL_017a;
						case 10:
							obj = (object)(&obj);
							obj2 = 7;
							continue;
						}
						break;
					}
					goto case 1u;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00切()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778568, new IntPtr(2737337561644L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00ﬀ()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CReceiveAsync_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Authenticator _003C_003E4__this;

		public TcpClient client;

		private TaskAwaiter _003C_003Eu__1;

		internal static object CheckCustomChain;

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
		internal static bool ReflectAdvancedEnumerator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateConvertibleParameter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_EC00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778567, new IntPtr(2737337561644L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_ED00(object P_0)
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
		internal static object _FF00_EE00()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_EF00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778566, new IntPtr(2737337546044L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_F100()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_031c: Expected Obj, but got Ref
			//IL_0040: Expected Obj, but got Ref
			//IL_0148: Expected Obj, but got Ref
			//IL_00f2: Expected I4, but got Obj
			//IL_01d6: Expected Obj, but got Ref
			//IL_0181: Expected Obj, but got I4
			//IL_0164: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0326->IL0019: Incompatible stack types: I4 vs Ref
			//IL_004c->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0065->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0057->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0318->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0080->IL0084: Incompatible stack heights: 1 vs 0
			//IL_00ae->IL00bd: Incompatible stack heights: 0 vs 1
			//IL_0273->IL0084: Incompatible stack heights: 1 vs 0
			//IL_015f->IL00bd: Incompatible stack types: I4 vs Obj
			//IL_00b9->IL00bd: Incompatible stack types: I4 vs Obj
			//IL_01e2->IL00bd: Incompatible stack heights: 0 vs 1
			//IL_018c->IL00bd: Incompatible stack heights: 3 vs 1
			//IL_0104->IL00bd: Incompatible stack heights: 2 vs 1
			//IL_01d2->IL00bd: Incompatible stack heights: 2 vs 1
			//IL_0171->IL00bd: Incompatible stack heights: 2 vs 1
			//IL_0112->IL00bd: Incompatible stack heights: 3 vs 1
			//IL_01ba->IL00bd: Incompatible stack heights: 3 vs 1
			//IL_01ed->IL00bd: Incompatible stack types: I4 vs Obj
			//IL_0124->IL00bd: Incompatible stack types: I4 vs Obj
			//IL_017c->IL00bd: Incompatible stack heights: 2 vs 1
			//IL_01c5->IL00bd: Incompatible stack heights: 3 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			ref _003CReceiveAsync_003Ed__9 reference = ref *(_003CReceiveAsync_003Ed__9*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 3u:
					return;
				case 1u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						reference = ref *(_003CReceiveAsync_003Ed__9*)null;
					}
					break;
				case 2u:
					_ = -2;
					_ = 4;
					break;
				case 5u:
					if (1 == 0)
					{
						_ = 1;
					}
					while (true)
					{
						object obj2;
						switch ((int)/*Error near IL_0095: Stack underflow*/)
						{
						case 2:
							break;
						default:
							if (obj == null)
							{
								if (4 == 0)
								{
									obj2 = 5;
								}
								goto IL_00bd;
							}
							goto IL_0140;
						case 1:
							{
								if (false)
								{
									_ = 0;
								}
								continue;
							}
							IL_00bd:
							while (true)
							{
								switch ((int)obj2)
								{
								case 3:
									return;
								case 6:
									break;
								case 7:
									_ = 9;
									continue;
								case 10:
									_ = 11;
									continue;
								case 1:
									if (&obj == null)
									{
										obj2 = 4;
										continue;
									}
									goto case 8;
								case 2:
									goto end_IL_00bd;
								case 9:
									obj = -1;
									if (7 != 0)
									{
										_ = 8;
									}
									continue;
								case 4:
									obj = 0;
									_ = 10;
									continue;
								case 11:
									_ = ref obj;
									if (3 == 0)
									{
										_ = 0;
									}
									continue;
								case 8:
									_ = ref obj;
									_ = 6;
									continue;
								default:
									obj = (object)Unsafe.AsPointer(ref this);
									if (7 == 0)
									{
										obj2 = 7;
									}
									continue;
								}
								goto end_IL_0084;
								continue;
								end_IL_00bd:
								break;
							}
							goto IL_0140;
							IL_0140:
							obj2 = obj;
							obj = (object)Unsafe.AsPointer(ref this);
							if (1 == 0)
							{
								obj2 = 1;
							}
							goto IL_00bd;
							end_IL_0084:
							break;
						}
						break;
					}
					goto case 2u;
				case 4u:
					reference = ref this;
					if (3 == 0)
					{
						reference = ref *(_003CReceiveAsync_003Ed__9*)3;
					}
					break;
				default:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CReceiveAsync_003Ed__9*)5;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_F200()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_F300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778565, new IntPtr(2737337543964L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CReceiveAuthenticationDataAsync_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TcpClient client;

		public Authenticator _003C_003E4__this;

		private object _003Cstream_003E5__2;

		private TaskAwaiter<string> _003C_003Eu__1;

		internal static object ReflectMixedGateway;

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
		internal static bool DecorateFlexibleProfiler()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HandleNotifier()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_E300(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778564, new IntPtr(2737337543964L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_E400(object P_0)
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_E500()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778563, new IntPtr(2737337539804L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_E600()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_E700()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778562, new IntPtr(2737337542924L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_E800()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778561, new IntPtr(2737337546044L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_E900()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_02f7: Expected Obj, but got Ref
			//IL_0043: Expected Obj, but got Ref
			//IL_01b5: Expected Obj, but got Ref
			//IL_0141: Expected Obj, but got I4
			//IL_017f: Expected Obj, but got I4
			//IL_01f1: Expected Obj, but got Ref
			//IL_0207: Expected Obj, but got I4
			//IL_01d5: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0337->IL0019: Incompatible stack heights: 3 vs 1
			//IL_031f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0303->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004d->IL0019: Incompatible stack types: I4 vs Ref
			//IL_032a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_030e->IL0019: Incompatible stack types: I4 vs Ref
			//IL_01bf->IL007d: Incompatible stack types: I4 vs Ref
			//IL_0079->IL007d: Incompatible stack types: I4 vs Ref
			//IL_0067->IL0019: Incompatible stack types: I4 vs Ref
			//IL_017a->IL007d: Incompatible stack heights: 2 vs 1
			//IL_014c->IL007d: Incompatible stack heights: 3 vs 1
			//IL_0115->IL007d: Incompatible stack heights: 3 vs 1
			//IL_00e3->IL007d: Incompatible stack types: I4 vs Ref
			//IL_00f8->IL007d: Incompatible stack heights: 2 vs 1
			//IL_01cd->IL007d: Incompatible stack heights: 3 vs 1
			//IL_015d->IL007d: Incompatible stack heights: 2 vs 1
			//IL_018c->IL007d: Incompatible stack heights: 2 vs 1
			//IL_01fb->IL007d: Incompatible stack types: I4 vs Ref
			//IL_0211->IL007d: Incompatible stack heights: 4 vs 1
			//IL_0225->IL007d: Incompatible stack heights: 5 vs 1
			//IL_01e1->IL007d: Incompatible stack heights: 0 vs 1
			//IL_0232->IL007d: Incompatible stack heights: 2 vs 1
			//IL_0120->IL007d: Incompatible stack heights: 3 vs 1
			//IL_0103->IL007d: Incompatible stack heights: 2 vs 1
			//IL_0168->IL007d: Incompatible stack heights: 2 vs 1
			//IL_0197->IL007d: Incompatible stack heights: 2 vs 1
			//IL_01b1->IL007d: Incompatible stack types: I4 vs Ref
			//IL_0244->IL007d: Incompatible stack types: I4 vs Ref
			//IL_01ec->IL007d: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			ref _003CReceiveAuthenticationDataAsync_003Ed__10 reference = ref *(_003CReceiveAuthenticationDataAsync_003Ed__10*)obj;
			while (true)
			{
				ref _003CReceiveAuthenticationDataAsync_003Ed__10 reference2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CReceiveAuthenticationDataAsync_003Ed__10*)3;
					break;
				case 6u:
					reference = ref this;
					if (1 == 0)
					{
						reference = ref *(_003CReceiveAuthenticationDataAsync_003Ed__10*)1;
					}
					break;
				case 5u:
					if (obj != null)
					{
						reference2 = ref *(_003CReceiveAuthenticationDataAsync_003Ed__10*)8;
						goto IL_007d;
					}
					goto IL_01b1;
				case 3u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (5 == 0)
					{
						reference = ref *(_003CReceiveAuthenticationDataAsync_003Ed__10*)3;
					}
					break;
				case 1u:
					return;
				case 2u:
					goto IL_030f;
				default:
					{
						_ = null;
						_ = 6;
						break;
					}
					IL_01b1:
					obj = (object)Unsafe.AsPointer(ref this);
					reference2 = ref *(_003CReceiveAuthenticationDataAsync_003Ed__10*)18;
					goto IL_007d;
					IL_007d:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference2))
						{
						case 5u:
							obj = obj;
							reference2 = ref *(_003CReceiveAuthenticationDataAsync_003Ed__10*)14;
							continue;
						case 6u:
							_ = 0;
							obj = obj;
							if (1 == 0)
							{
								_ = 0;
							}
							continue;
						case 3u:
							_ = ref obj;
							if (17 != 0)
							{
								_ = 10;
							}
							continue;
						case 2u:
							obj = 0;
							_ = 7;
							continue;
						case 8u:
							if (16 == 0)
							{
								_ = 7;
							}
							continue;
						case 1u:
							obj = obj;
							_ = 12;
							continue;
						case 9u:
							obj = -1;
							if (6 != 0)
							{
								_ = 11;
							}
							continue;
						case 10u:
							reference2 = ref this;
							if (0 == 0)
							{
								reference2 = ref *(_003CReceiveAuthenticationDataAsync_003Ed__10*)null;
							}
							continue;
						case 4u:
							break;
						case 7u:
							_ = 3;
							continue;
						case 16u:
							obj = 1024;
							if (13 != 0)
							{
								reference2 = ref *(_003CReceiveAuthenticationDataAsync_003Ed__10*)12;
							}
							continue;
						case 11u:
						case 15u:
							obj = (object)(&obj);
							reference2 = ref *(_003CReceiveAuthenticationDataAsync_003Ed__10*)5;
							continue;
						case 13u:
							_ = 0;
							obj = ((Array)obj).Length;
							_ = 6;
							continue;
						case 14u:
							_ = 0;
							_ = ((Array)obj).Length;
							_ = 10;
							continue;
						case 18u:
							_ = 9;
							continue;
						case 12u:
							if (&obj != null)
							{
								reference2 = ref *(_003CReceiveAuthenticationDataAsync_003Ed__10*)15;
								continue;
							}
							goto case 2u;
						case 17u:
							return;
						default:
							goto IL_030f;
						}
						break;
					}
					goto IL_01b1;
					IL_030f:
					_ = -2;
					if (false)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_EA00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778560, new IntPtr(2737337538764L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_EB00()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}
	}

	private static object GuideError;

	private TcpListener? Listener
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (TcpListener?)_FF00_FF00_1400();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00ሀ(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected Authenticator(ILogger logger)
	{
		//IL_003a: Expected I4, but got Obj
		//IL_0028->IL0031: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		Authenticator authenticator = this;
		if (0 == 0)
		{
			authenticator = (Authenticator)0;
		}
		switch ((int)authenticator)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartListening(int port)
	{
		_FF00_FF00ࠀ((uint)port);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CListenAsync_003Ed__7))]
	private object ListenAsync()
	{
		return _FF00_FF00_0C00();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CListenAuthenticationConnectAsync_003Ed__8))]
	private object ListenAuthenticationConnectAsync(object listener)
	{
		return _FF00_FF00_0E00(listener);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CReceiveAsync_003Ed__9))]
	private object ReceiveAsync(object client)
	{
		return _FF00_FF00က(client);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CReceiveAuthenticationDataAsync_003Ed__10))]
	private object ReceiveAuthenticationDataAsync(object client)
	{
		return _FF00_FF00ᘀ(client);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		_FF00_FF00_0600();
	}

	protected abstract Task<string> HandleAuthentication(string message);

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectMonoObject()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Authenticator PatchUser()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00Ԁ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778589, new IntPtr(2737337548124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_0600()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0051->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0085->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0090->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ad->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
			case 3:
				_ = null;
				if (false)
				{
					_ = 0;
				}
				break;
			case 2:
				return;
			default:
				obj2 = this;
				if (2 == 0)
				{
					obj2 = 0;
				}
				break;
			case 4:
				obj2 = this;
				if (obj2 == null)
				{
					if (3 != 0)
					{
						obj2 = 1;
					}
				}
				else if (false)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00ࠀ(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0056->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0046->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0067->IL0019: Incompatible stack heights: 0 vs 1
		//IL_008c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0072->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				_ = 2;
				break;
			case 1:
				return;
			default:
				_ = 4;
				break;
			case 4:
				if (false)
				{
					obj2 = 1;
				}
				break;
			case 2:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_0900()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_0A00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778588, new IntPtr(2737337541884L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_0B00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778587, new IntPtr(2737337557484L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_0C00()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4317, 1790778586, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778586, new IntPtr(2737337547084L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_0D00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778585, new IntPtr(2737337561644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_0E00(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4319, 1790778584, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778584, new IntPtr(2737337541884L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00ༀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778583, new IntPtr(2737337566844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00က(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4321, 1790778582, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778582, new IntPtr(2737337556444L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00ᄀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778581, new IntPtr(2737337557484L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00ሀ(object P_0)
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
	private unsafe object _FF00_FF00ጀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778580, new IntPtr(2737337538764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_1400()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00ᔀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778579, new IntPtr(2737337557484L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00ᘀ(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4327, 1790778578, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778578, new IntPtr(2737337548124L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00ᜀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778577, new IntPtr(2737337550204L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_1800()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00ᤀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778576, new IntPtr(2737337549164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
