using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Mass.Application.Services;
using Mass.Game.Proxy.Protocols.Heypixel.AntiCheat;

namespace Mass.Game.Proxy.Protocols.Heypixel;

public static class MassServiceExtensions
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetHeypixelAntiCheat_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<HeypixelRequestDto> _003C_003Et__builder;

		public MassService massService;

		public string url;

		public string payload;

		public string context;

		public string userId;

		private TaskAwaiter<HeypixelRequestDto> _003C_003Eu__1;

		internal static object ReflectActiveExtractor;

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
		internal static bool DecorateJoinedIterator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CalcClient()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_E900()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778532, new IntPtr(2737367947324L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_EA00()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_EB00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778535, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_EC00()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_ED00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778534, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_EF00()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0032: Expected I4, but got Obj
			//IL_0257: Expected Obj, but got Ref
			//IL_00e0: Expected Obj, but got Ref
			//IL_00b3: Expected Obj, but got Ref
			//IL_0150: Expected Obj, but got I4
			//IL_016d: Expected Obj, but got I4
			//IL_01ab: Expected Obj, but got Ref
			//IL_01b4: Expected Obj, but got I4
			//IL_027c->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0263->IL0019: Incompatible stack heights: 0 vs 1
			//IL_028d->IL0019: Incompatible stack heights: 2 vs 1
			//IL_026e->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0298->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00f7->IL005a: Incompatible stack heights: 1 vs 0
			//IL_0056->IL005a: Incompatible stack heights: 1 vs 0
			//IL_0125->IL005a: Incompatible stack heights: 3 vs 0
			//IL_0140->IL005a: Incompatible stack heights: 2 vs 0
			//IL_00bd->IL005a: Incompatible stack heights: 1 vs 0
			//IL_015d->IL005a: Incompatible stack heights: 2 vs 0
			//IL_017a->IL005a: Incompatible stack heights: 2 vs 0
			//IL_00dc->IL005a: Incompatible stack heights: 2 vs 0
			//IL_0130->IL005a: Incompatible stack heights: 3 vs 0
			//IL_00ae->IL005a: Incompatible stack heights: 1 vs 0
			//IL_014b->IL005a: Incompatible stack heights: 2 vs 0
			//IL_00cf->IL005a: Incompatible stack heights: 1 vs 0
			//IL_0168->IL005a: Incompatible stack heights: 2 vs 0
			//IL_0185->IL005a: Incompatible stack heights: 2 vs 0
			//IL_005a->IL005a: Incompatible stack heights: 5 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 1:
					if (obj != null)
					{
						if (1 == 0)
						{
							_ = 2;
						}
						goto IL_005a;
					}
					goto IL_00dc;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						obj2 = 1;
					}
					break;
				default:
					goto IL_026e;
				case 3:
					if (4 != 0)
					{
						_ = 4;
					}
					break;
				case 4:
					return;
					IL_005a:
					while (true)
					{
						switch ((int)/*Error near IL_0097: Stack underflow*/)
						{
						case 2:
							if (Unsafe.AsPointer(ref this) != null)
							{
								_ = 7;
								continue;
							}
							goto case 13;
						case 6:
						case 8:
							obj = (object)(&obj);
							_ = 3;
							continue;
						case 9:
							if (&obj != null)
							{
								_ = 8;
								continue;
							}
							goto case 10;
						case 12:
							_ = 11;
							continue;
						case 5:
							break;
						case 1:
							return;
						default:
							_ = ref obj;
							if (true)
							{
								_ = 1;
							}
							continue;
						case 4:
							if (false)
							{
								_ = 0;
							}
							continue;
						case 10:
							obj = 0;
							if (4 == 0)
							{
								_ = 1;
							}
							continue;
						case 11:
							obj = -1;
							if (6 != 0)
							{
								_ = 6;
							}
							continue;
						case 13:
							throw /*Error near IL_019b: Stack underflow*/;
						case 7:
							obj = (object)Unsafe.AsPointer(ref this);
							obj = 9;
							continue;
						case 3:
							goto IL_026e;
						}
						break;
					}
					goto IL_00dc;
					IL_00dc:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 != 0)
					{
						_ = 12;
					}
					goto IL_005a;
					IL_026e:
					_ = -2;
					_ = 3;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_F000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778529, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_F100(object P_0)
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
					if (0 == 0)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_F200(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778528, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetHeypixelSession_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<HeypixelHwid> _003C_003Et__builder;

		public MassService massService;

		public string name;

		public string uuid;

		public string userId;

		private TaskAwaiter<HeypixelHwid> _003C_003Eu__1;

		internal static object ReflectScalableTokenizer;

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
		internal static bool CheckModularContainer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckGroupedConverter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778531, new IntPtr(2737367941084L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FFFD()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_E000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778530, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_E100()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778557, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_E200()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_E300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778556, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_E600()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0032: Expected I4, but got Obj
			//IL_0265: Expected Obj, but got Ref
			//IL_008f: Expected Obj, but got Ref
			//IL_013b: Expected Obj, but got I4
			//IL_0158: Expected Obj, but got Ref
			//IL_00e2: Expected Obj, but got I4
			//IL_012c: Expected Obj, but got Ref
			//IL_0256->IL0019: Incompatible stack heights: 2 vs 1
			//IL_023a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_026f->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0261->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0245->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0049->IL004d: Incompatible stack heights: 1 vs 0
			//IL_00a6->IL004d: Incompatible stack heights: 1 vs 0
			//IL_0148->IL004d: Incompatible stack heights: 2 vs 0
			//IL_0181->IL004d: Incompatible stack heights: 3 vs 0
			//IL_00ed->IL004d: Incompatible stack heights: 3 vs 0
			//IL_00c2->IL004d: Incompatible stack heights: 2 vs 0
			//IL_00d2->IL004d: Incompatible stack heights: 2 vs 0
			//IL_0136->IL004d: Incompatible stack heights: 4 vs 0
			//IL_0153->IL004d: Incompatible stack heights: 2 vs 0
			//IL_016f->IL004d: Incompatible stack heights: 1 vs 0
			//IL_018c->IL004d: Incompatible stack heights: 3 vs 0
			//IL_00dd->IL004d: Incompatible stack heights: 2 vs 0
			//IL_010c->IL004d: Incompatible stack heights: 1 vs 0
			//IL_01ab->IL004d: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 3:
					if (obj != null)
					{
						_ = 9;
						goto IL_004d;
					}
					goto IL_008b;
				case 1:
					return;
				case 2:
					goto IL_022a;
				default:
					if (1 == 0)
					{
						_ = 1;
					}
					break;
				case 4:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 3;
						break;
					}
					IL_022a:
					_ = -2;
					if (false)
					{
						_ = 0;
					}
					break;
					IL_004d:
					while (true)
					{
						switch ((int)/*Error near IL_0086: Stack underflow*/)
						{
						default:
							return;
						case 6:
							break;
						case 0:
							return;
						case 10:
							_ = 8;
							continue;
						case 12:
							if (2 != 0)
							{
								_ = 7;
							}
							continue;
						case 8:
							obj = -1;
							_ = 4;
							continue;
						case 9:
							if (Unsafe.AsPointer(ref this) != null)
							{
								if (true)
								{
									_ = 0;
								}
								continue;
							}
							goto case 2;
						case 2:
							throw /*Error near IL_011e: Stack underflow*/;
						case 1:
							obj = (object)Unsafe.AsPointer(ref this);
							_ = 11;
							continue;
						case 3:
							obj = 0;
							if (12 != 0)
							{
								_ = 3;
							}
							continue;
						case 4:
							obj = (object)(&obj);
							if (5 == 0)
							{
								_ = 1;
							}
							continue;
						case 7:
							_ = ref obj;
							if (false)
							{
								_ = 0;
							}
							continue;
						case 11:
							if (&obj == null)
							{
								if (2 != 0)
								{
									_ = 3;
								}
								continue;
							}
							goto case 4;
						case 5:
							goto IL_022a;
						}
						break;
					}
					goto IL_008b;
					IL_008b:
					obj = (object)Unsafe.AsPointer(ref this);
					if (10 == 0)
					{
						_ = 2;
					}
					goto IL_004d;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_E700()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778559, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_E800(object P_0)
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
					if (0 == 0)
					{
						_ = 0;
					}
					break;
				}
			}
		}
	}

	private static object ReflectSymbolicDecider;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static HeypixelReflectCheckResult ReflectCheck(this MassService massService, string action)
	{
		return (HeypixelReflectCheckResult)_FF00_FF00_FF00_FF00切(massService, action);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetHeypixelSession_003Ed__1))]
	public static Task<HeypixelHwid> GetHeypixelSession(this MassService massService, string name, string uuid, string userId)
	{
		return _FF00_FF00_FF00_FF00_F700(massService, name, uuid, userId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetHeypixelAntiCheat_003Ed__2))]
	public static Task<HeypixelRequestDto> GetHeypixelAntiCheat(this MassService massService, string userId, string url, string payload, string context)
	{
		return _FF00_FF00_FF00_FF00_FF00(massService, userId, url, payload, context);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool StopProvider()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MassServiceExtensions ReadCalc()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_F300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778451, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_F400()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_F500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778450, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static Task<HeypixelHwid> _FF00_FF00_FF00_FF00_F600(object P_0, object P_1, object P_2, object P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778541, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
		return (Task<HeypixelHwid>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static Task<HeypixelHwid> _FF00_FF00_FF00_FF00_F700(object P_0, object P_1, object P_2, object P_3)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005b: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 9953, 1790778540, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 4, 1790778540, new IntPtr(2737367935884L), 15);
		}
		return (Task<HeypixelHwid>)((delegate*<object, object, object, object, object>)obj)(P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static Task<HeypixelHwid> _FF00_FF00_FF00_FF00_F800(object P_0, object P_1, object P_2, object P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778543, new IntPtr(2737367936924L), 15))(null, 0, new IntPtr(0L));
		return (Task<HeypixelHwid>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00切(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 9956, 1790778542, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778542, new IntPtr(2737367936924L), 15);
		}
		return ((delegate*<object, object, object>)obj)(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00ﬀ(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778537, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00ﰀ()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00ﴀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778536, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static Task<HeypixelRequestDto> _FF00_FF00_FF00_FF00_FE00(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778539, new IntPtr(2737367947324L), 15))(null, 0, new IntPtr(0L));
		return (Task<HeypixelRequestDto>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static Task<HeypixelRequestDto> _FF00_FF00_FF00_FF00_FF00(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005d: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 9961, 1790778538, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 5, 1790778538, new IntPtr(2737367948364L), 15);
		}
		return (Task<HeypixelRequestDto>)((delegate*<object, object, object, object, object, object>)obj)(P_0, P_1, P_2, P_3, P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static Task<HeypixelRequestDto> _FF00_FF00_FF00_FF00_FF00Ā(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778533, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		return (Task<HeypixelRequestDto>)/*Error near IL_0033: Stack underflow*/;
	}
}
