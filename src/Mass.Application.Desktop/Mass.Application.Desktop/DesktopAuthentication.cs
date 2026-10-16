using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Mass.Application.Desktop.Security;
using Mass.Common.Extensions;
using Mass.Domain.Desktop.Entities;
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
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_005f: Expected Obj, but got Ref
			//IL_0044: Expected Obj, but got Ref
			//IL_007d: Expected I4, but got Obj
			//IL_0165: Expected Obj, but got Ref
			//IL_01bc: Expected Obj, but got Ref
			//IL_02d7: Expected Obj, but got I4
			//IL_01f9: Expected Obj, but got I4
			//IL_0238: Expected Obj, but got Ref
			//IL_0218: Expected Obj, but got I4
			//IL_0182: Expected Obj, but got Ref
			//IL_013a: Expected Obj, but got I4
			//IL_03e7: Expected Obj, but got Ref
			//IL_03f0: Expected Obj, but got I4
			//IL_0130: Expected Obj, but got I4
			//IL_0347: Expected I4, but got Obj
			//IL_0370: Expected Obj, but got I4
			//IL_03d9: Expected Obj, but got Ref
			//IL_0438: Expected Obj, but got I4
			//IL_03b3: Expected Obj, but got I4
			//IL_0596->IL0019: Incompatible stack heights: 2 vs 1
			//IL_05ae->IL0019: Incompatible stack heights: 2 vs 1
			//IL_057c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0069->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0050->IL0019: Incompatible stack heights: 0 vs 1
			//IL_05a1->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0587->IL0019: Incompatible stack heights: 2 vs 1
			//IL_005b->IL0019: Incompatible stack types: I4 vs Obj
			//IL_016f->IL0098: Incompatible stack types: I4 vs Ref
			//IL_01c8->IL0098: Incompatible stack heights: 0 vs 1
			//IL_02aa->IL0098: Incompatible stack types: I4 vs Ref
			//IL_0089->IL0098: Incompatible stack heights: 0 vs 1
			//IL_01d3->IL0098: Incompatible stack types: I4 vs Ref
			//IL_0094->IL0098: Incompatible stack types: I4 vs Ref
			//IL_02e4->IL0098: Incompatible stack heights: 2 vs 1
			//IL_025b->IL0098: Incompatible stack heights: 2 vs 1
			//IL_0204->IL0098: Incompatible stack heights: 3 vs 1
			//IL_02b8->IL0098: Incompatible stack heights: 3 vs 1
			//IL_0242->IL0098: Incompatible stack heights: 6 vs 1
			//IL_011f->IL0098: Incompatible stack heights: 4 vs 1
			//IL_029f->IL0098: Incompatible stack heights: 2 vs 1
			//IL_0223->IL0098: Incompatible stack heights: 3 vs 1
			//IL_01e9->IL0098: Incompatible stack heights: 2 vs 1
			//IL_018e->IL0098: Incompatible stack heights: 0 vs 1
			//IL_0292->IL0098: Incompatible stack heights: 4 vs 1
			//IL_010f->IL0098: Incompatible stack heights: 2 vs 1
			//IL_0145->IL0098: Incompatible stack heights: 3 vs 1
			//IL_017d->IL0098: Incompatible stack heights: 3 vs 1
			//IL_02ef->IL0098: Incompatible stack heights: 2 vs 1
			//IL_0266->IL0098: Incompatible stack heights: 2 vs 1
			//IL_0302->IL0306: Incompatible stack types: I4 vs Obj
			//IL_01ad->IL0098: Incompatible stack heights: 0 vs 1
			//IL_01f4->IL0098: Incompatible stack heights: 2 vs 1
			//IL_0199->IL0098: Incompatible stack types: I4 vs Ref
			//IL_02d2->IL0098: Incompatible stack types: I4 vs Ref
			//IL_01b8->IL0098: Incompatible stack types: I4 vs Ref
			//IL_0098->IL0098: Incompatible stack types: Obj vs Ref
			//IL_037d->IL0306: Incompatible stack heights: 2 vs 1
			//IL_046b->IL0306: Incompatible stack heights: 2 vs 1
			//IL_03e3->IL0306: Incompatible stack types: I4 vs Obj
			//IL_045e->IL0306: Incompatible stack heights: 3 vs 1
			//IL_0445->IL0306: Incompatible stack heights: 2 vs 1
			//IL_0359->IL0306: Incompatible stack heights: 2 vs 1
			//IL_0433->IL0306: Incompatible stack heights: 2 vs 1
			//IL_0416->IL0306: Incompatible stack heights: 3 vs 1
			//IL_0388->IL0306: Incompatible stack heights: 2 vs 1
			//IL_0450->IL0306: Incompatible stack heights: 2 vs 1
			//IL_036b->IL0306: Incompatible stack types: I4 vs Obj
			//IL_0421->IL0306: Incompatible stack heights: 3 vs 1
			//IL_03a3->IL0306: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				case 2:
					return;
				case 5:
					obj = (object)Unsafe.AsPointer(ref this);
					if (4 != 0)
					{
						obj2 = 1;
					}
					break;
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 6;
					break;
				case 6:
				{
					ref object reference;
					switch ((int)obj)
					{
					default:
						if (6 != 0)
						{
							reference = ref *(object*)6;
						}
						goto IL_0098;
					case 0:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(object*)10;
						goto IL_0098;
					case 1:
						goto IL_01b8;
					case 2:
						goto IL_029f;
						IL_0098:
						while (true)
						{
							switch ((uint)Unsafe.AsPointer(ref reference))
							{
							case 4u:
								return;
							case 23u:
								return;
							case 18u:
								_ = 2;
								continue;
							case 7u:
								_ = ref obj;
								_ = 23;
								continue;
							case 22u:
								if (&obj != null)
								{
									obj = 12;
									reference = ref *(object*)obj;
									continue;
								}
								goto default;
							case 19u:
								obj = 0;
								_ = 20;
								continue;
							case 8u:
								break;
							case 20u:
								_ = 17;
								continue;
							case 16u:
								obj = (object)(&obj);
								if (6 == 0)
								{
									reference = ref *(object*)15;
								}
								continue;
							case 13u:
								if (&obj == null)
								{
									if (19 == 0)
									{
										reference = ref *(object*)4;
									}
									continue;
								}
								goto case 16u;
							case 14u:
								goto IL_01b8;
							case 15u:
								_ = 9;
								obj = obj;
								if (22 != 0)
								{
									_ = 5;
								}
								continue;
							case 2u:
								obj = -1;
								_ = 21;
								continue;
							case 11u:
								obj = -1;
								_ = 16;
								continue;
							case 6u:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 13;
								continue;
							case 1u:
								_ = 10.0;
								if (5 == 0)
								{
									_ = 5;
								}
								continue;
							case 17u:
								_ = ref obj;
								_ = 4;
								continue;
							case 10u:
								_ = 11;
								continue;
							case 5u:
								goto IL_029f;
							case 3u:
								_ = 7;
								continue;
							case 12u:
							case 21u:
								reference = ref obj;
								if (1 == 0)
								{
									reference = ref *(object*)1;
								}
								continue;
							default:
								obj = 1;
								if (0 == 0)
								{
									_ = 3;
								}
								continue;
							case 9u:
								goto end_IL_006c;
							}
							break;
						}
						goto case 0;
						IL_029f:
						reference = ref *(object*)9;
						goto IL_0098;
						IL_01b8:
						obj = (object)Unsafe.AsPointer(ref this);
						if (14 != 0)
						{
							reference = ref *(object*)18;
						}
						goto IL_0098;
						end_IL_006c:
						break;
					}
					if ((nint)obj != 2)
					{
						obj3 = 14;
						goto IL_0306;
					}
					goto IL_03e3;
				}
				case 3:
					goto IL_056c;
				default:
					_ = null;
					if (false)
					{
						_ = 1;
					}
					break;
				case 1:
					{
						_ = 2;
						break;
					}
					IL_056c:
					_ = -2;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
					IL_03e3:
					obj = (object)Unsafe.AsPointer(ref this);
					obj = 9;
					goto IL_0302;
					IL_0302:
					obj3 = obj;
					goto IL_0306;
					IL_0306:
					while (true)
					{
						switch ((int)obj3)
						{
						case 6:
							return;
						case 9:
							_ = 8;
							continue;
						case 11:
							if (&obj != null)
							{
								obj3 = 3;
								continue;
							}
							goto default;
						default:
							obj = 2;
							if (7 == 0)
							{
								_ = 7;
							}
							continue;
						case 14:
							obj3 = obj;
							if (1 == 0)
							{
								obj3 = 2;
							}
							continue;
						case 12:
							break;
						case 2:
							obj = (object)Unsafe.AsPointer(ref this);
							obj3 = 10;
							continue;
						case 4:
							goto IL_03e3;
						case 13:
							_ = ref obj;
							if (1 == 0)
							{
								_ = 6;
							}
							continue;
						case 10:
							_ = ref obj;
							_ = 12;
							continue;
						case 8:
							obj = -1;
							if (1 == 0)
							{
								_ = 0;
							}
							continue;
						case 7:
							_ = 13;
							continue;
						case 1:
						case 3:
							_ = ref obj;
							_ = 5;
							continue;
						case 5:
							goto IL_056c;
						}
						break;
					}
					obj = obj;
					obj = 11;
					goto IL_0302;
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
		private sealed void _FF00_FF00_FF00_FF00_F800(object P_0)
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_0548: Expected Obj, but got Ref
			//IL_0043: Expected Obj, but got Ref
			//IL_012c: Expected Obj, but got Ref
			//IL_0135: Expected Obj, but got I4
			//IL_0176: Expected Obj, but got I4
			//IL_0203: Expected Obj, but got I4
			//IL_0159: Expected Obj, but got I4
			//IL_022e: Expected Obj, but got Ref
			//IL_03d9: Expected Obj, but got Ref
			//IL_02d4: Expected Obj, but got I4
			//IL_02ff: Expected Obj, but got Ref
			//IL_0357: Expected Obj, but got I4
			//IL_0067->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0077->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0538->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0552->IL0019: Incompatible stack types: I4 vs Obj
			//IL_004f->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0082->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0543->IL0019: Incompatible stack heights: 2 vs 1
			//IL_005a->IL0019: Incompatible stack types: I4 vs Obj
			//IL_00a5->IL00a5: Incompatible stack heights: 1 vs 0
			//IL_00a1->IL00a5: Incompatible stack heights: 1 vs 0
			//IL_0183->IL00a5: Incompatible stack heights: 2 vs 0
			//IL_01f6->IL00a5: Incompatible stack heights: 1 vs 0
			//IL_0149->IL00a5: Incompatible stack heights: 1 vs 0
			//IL_0208->IL00a1: Incompatible stack heights: 2 vs 0
			//IL_019d->IL00a5: Incompatible stack heights: 1 vs 0
			//IL_011a->IL00a5: Incompatible stack heights: 4 vs 0
			//IL_0128->IL00a5: Incompatible stack heights: 3 vs 0
			//IL_010a->IL00a5: Incompatible stack heights: 3 vs 0
			//IL_0166->IL00a5: Incompatible stack heights: 2 vs 0
			//IL_0238->IL00a5: Incompatible stack heights: 3 vs 0
			//IL_01ba->IL00a5: Incompatible stack heights: 1 vs 0
			//IL_018e->IL00a5: Incompatible stack heights: 2 vs 0
			//IL_0154->IL00a5: Incompatible stack heights: 1 vs 0
			//IL_01a8->IL00a5: Incompatible stack heights: 1 vs 0
			//IL_0267->IL026b: Incompatible stack heights: 1 vs 0
			//IL_0220->IL00a5: Incompatible stack heights: 1 vs 0
			//IL_0171->IL00a5: Incompatible stack heights: 2 vs 0
			//IL_03f0->IL026b: Incompatible stack heights: 1 vs 0
			//IL_01d9->IL00a5: Incompatible stack heights: 1 vs 0
			//IL_02e1->IL026b: Incompatible stack heights: 2 vs 0
			//IL_03b6->IL026b: Incompatible stack heights: 2 vs 0
			//IL_02fa->IL026b: Incompatible stack heights: 3 vs 0
			//IL_0370->IL026b: Incompatible stack heights: 2 vs 0
			//IL_0347->IL026b: Incompatible stack heights: 3 vs 0
			//IL_0362->IL026b: Incompatible stack heights: 3 vs 0
			//IL_03ca->IL026b: Incompatible stack heights: 1 vs 0
			//IL_02c4->IL026b: Incompatible stack heights: 1 vs 0
			//IL_02ec->IL026b: Incompatible stack heights: 2 vs 0
			//IL_038e->IL026b: Incompatible stack heights: 1 vs 0
			//IL_0316->IL026b: Incompatible stack heights: 1 vs 0
			//IL_0352->IL026b: Incompatible stack heights: 3 vs 0
			//IL_03d5->IL026b: Incompatible stack heights: 1 vs 0
			//IL_03a9->IL026b: Incompatible stack heights: 1 vs 0
			//IL_02cf->IL026b: Incompatible stack heights: 1 vs 0
			//IL_0335->IL026b: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 6;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 6:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						obj2 = 5;
					}
					break;
				default:
					_ = 3;
					break;
				case 1:
					_ = -2;
					if (2 == 0)
					{
						_ = 0;
					}
					break;
				case 4:
					if (obj != null)
					{
						if (false)
						{
							_ = 0;
						}
						goto IL_00a5;
					}
					goto IL_0128;
				case 2:
					_ = null;
					if (false)
					{
						_ = 0;
					}
					break;
				case 3:
					return;
				case 5:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 4;
						break;
					}
					IL_026b:
					while (true)
					{
						switch ((int)/*Error near IL_02b0: Stack underflow*/)
						{
						case 14:
							break;
						case 15:
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						default:
							obj = -1;
							if (1 == 0)
							{
								_ = 1;
							}
							continue;
						case 6:
							_ = 9;
							continue;
						case 5:
							obj = (object)Unsafe.AsPointer(ref this);
							if (11 != 0)
							{
								_ = 1;
							}
							continue;
						case 2:
							if (&obj != null)
							{
								if (true)
								{
									_ = 3;
								}
								continue;
							}
							goto case 10;
						case 9:
							_ = ref obj;
							if (7 != 0)
							{
								_ = 6;
							}
							continue;
						case 10:
							obj = 1;
							_ = 6;
							continue;
						case 8:
							_ = 5;
							continue;
						case 4:
							obj = obj;
							if (1 == 0)
							{
								_ = 2;
							}
							continue;
						case 12:
							if (8 == 0)
							{
								_ = 14;
							}
							continue;
						case 1:
						case 3:
							_ = ref obj;
							_ = 12;
							continue;
						case 11:
							_ = ref obj;
							if (false)
							{
								_ = 4;
							}
							continue;
						case 13:
							goto IL_03d5;
						case 7:
							return;
						}
						break;
					}
					goto case 1;
					IL_0128:
					obj = (object)Unsafe.AsPointer(ref this);
					obj = 5;
					goto IL_00a5;
					IL_00a5:
					while (true)
					{
						switch ((int)/*Error near IL_00ee: Stack underflow*/)
						{
						case 9:
							_ = 10.0;
							_ = 11;
							continue;
						case 6:
							_ = ref obj;
							_ = 10;
							continue;
						case 7:
							_ = 6;
							continue;
						case 15:
							break;
						case 3:
						case 14:
							_ = ref obj;
							if (4 == 0)
							{
								_ = 3;
							}
							continue;
						case 12:
							obj = 0;
							if (7 == 0)
							{
								_ = 4;
							}
							continue;
						case 1:
							obj = -1;
							if (3 == 0)
							{
								_ = 2;
							}
							continue;
						case 5:
							if (1 == 0)
							{
								_ = 0;
							}
							continue;
						default:
							if ((nint)obj != 1)
							{
								_ = 13;
								continue;
							}
							goto case 11;
						case 16:
							if (&obj != null)
							{
								if (8 == 0)
								{
									_ = 14;
								}
								continue;
							}
							goto case 12;
						case 2:
							_ = 9;
							continue;
						case 4:
							_ = 1;
							obj = 2;
							continue;
						case 11:
							if (8 != 0)
							{
								_ = 4;
							}
							continue;
						case 13:
							obj = (object)Unsafe.AsPointer(ref this);
							_ = 16;
							continue;
						case 10:
							return;
						case 8:
							goto IL_0254;
						}
						break;
					}
					goto IL_0128;
					IL_0254:
					if ((nint)obj != 1)
					{
						_ = 8;
						goto IL_026b;
					}
					goto IL_03d5;
					IL_03d5:
					obj = (object)Unsafe.AsPointer(ref this);
					if (8 == 0)
					{
						_ = 15;
					}
					goto IL_026b;
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
		private sealed void _FF00_FF00_FF00_FF00_F100(object P_0)
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
		internal static byte _FF00_FF00_FF00_FF00_F200()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_F300()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0216: Expected Obj, but got Ref
			//IL_0231: Expected Obj, but got Ref
			//IL_010a: Expected Obj, but got Ref
			//IL_00c1: Expected Obj, but got I4
			//IL_00de: Expected Obj, but got I4
			//IL_0212->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0222->IL0019: Incompatible stack heights: 0 vs 1
			//IL_023d->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0259->IL0019: Incompatible stack heights: 2 vs 1
			//IL_022d->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0248->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0264->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0121->IL005e: Incompatible stack heights: 1 vs 0
			//IL_005a->IL005e: Incompatible stack heights: 1 vs 0
			//IL_00fb->IL005e: Incompatible stack heights: 3 vs 0
			//IL_00bc->IL005e: Incompatible stack heights: 2 vs 0
			//IL_00a4->IL005e: Incompatible stack heights: 2 vs 0
			//IL_00ce->IL005e: Incompatible stack heights: 2 vs 0
			//IL_013f->IL005e: Incompatible stack heights: 1 vs 0
			//IL_00e9->IL005e: Incompatible stack heights: 3 vs 0
			//IL_0106->IL005e: Incompatible stack heights: 3 vs 0
			//IL_0187->IL005e: Incompatible stack heights: 1 vs 0
			//IL_00af->IL005e: Incompatible stack heights: 2 vs 0
			//IL_00d9->IL005e: Incompatible stack heights: 2 vs 0
			//IL_014a->IL005e: Incompatible stack heights: 1 vs 0
			//IL_0169->IL005e: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 5:
					if (obj != null)
					{
						if (false)
						{
							_ = 3;
						}
						goto IL_005e;
					}
					goto IL_0106;
				default:
					_ = 4;
					continue;
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					if (5 == 0)
					{
						obj2 = 5;
					}
					continue;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (true)
					{
						obj2 = 0;
					}
					continue;
				case 4:
					return;
				case 3:
					break;
					IL_0106:
					obj = (object)Unsafe.AsPointer(ref this);
					if (8 != 0)
					{
						_ = 4;
					}
					goto IL_005e;
					IL_005e:
					while (true)
					{
						switch ((int)/*Error near IL_008f: Stack underflow*/)
						{
						case 6:
							if (true)
							{
								_ = 0;
							}
							continue;
						case 4:
							_ = ref obj;
							_ = 5;
							continue;
						case 7:
							obj = -1;
							if (4 != 0)
							{
								_ = 4;
							}
							continue;
						case 9:
							obj = 0;
							_ = 6;
							continue;
						case 1:
							_ = ref obj;
							if (10 == 0)
							{
								_ = 10;
							}
							continue;
						case 2:
							break;
						case 10:
							return;
						case 8:
							if (6 != 0)
							{
								_ = 7;
							}
							continue;
						default:
							if (&obj == null)
							{
								if (6 == 0)
								{
									_ = 9;
								}
								continue;
							}
							goto case 4;
						case 3:
							obj = obj;
							if (false)
							{
								_ = 0;
							}
							continue;
						case 5:
							goto end_IL_0019;
						}
						break;
					}
					goto IL_0106;
					end_IL_0019:
					break;
				}
				_ = -2;
				if (0 == 0)
				{
					_ = 0;
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
		private sealed void _FF00_FF00_FF00_FF00_E800(object P_0)
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_04b1: Expected Obj, but got Ref
			//IL_0496: Expected Obj, but got Ref
			//IL_03c5: Expected Obj, but got I4
			//IL_00d5: Expected Obj, but got F8
			//IL_01ae: Expected Obj, but got Ref
			//IL_00e4: Expected Obj, but got I4
			//IL_02d5: Expected Obj, but got Ref
			//IL_02c2: Expected Obj, but got I4
			//IL_02cc: Expected Obj, but got I4
			//IL_0349: Expected Obj, but got I4
			//IL_0492->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0049->IL0019: Incompatible stack heights: 2 vs 1
			//IL_04bd->IL0019: Incompatible stack heights: 0 vs 1
			//IL_04a2->IL0019: Incompatible stack heights: 0 vs 1
			//IL_005b->IL005f: Incompatible stack types: I4 vs Ref
			//IL_04c8->IL0019: Incompatible stack types: I4 vs Obj
			//IL_04ad->IL0019: Incompatible stack types: I4 vs Obj
			//IL_01aa->IL005f: Incompatible stack types: I4 vs Ref
			//IL_01f3->IL005f: Incompatible stack heights: 0 vs 1
			//IL_01fe->IL005f: Incompatible stack types: I4 vs Ref
			//IL_03d2->IL005f: Incompatible stack heights: 2 vs 1
			//IL_015d->IL005f: Incompatible stack heights: 3 vs 1
			//IL_00df->IL005f: Incompatible stack types: I4 vs Ref
			//IL_0194->IL005f: Incompatible stack heights: 2 vs 1
			//IL_01ba->IL005f: Incompatible stack heights: 0 vs 1
			//IL_03f9->IL005f: Incompatible stack heights: 2 vs 1
			//IL_00ef->IL005f: Incompatible stack heights: 3 vs 1
			//IL_0140->IL005f: Incompatible stack heights: 0 vs 1
			//IL_02df->IL0222: Incompatible stack types: I4 vs Ref
			//IL_0213->IL0222: Incompatible stack heights: 0 vs 1
			//IL_03dd->IL005f: Incompatible stack heights: 2 vs 1
			//IL_0168->IL005f: Incompatible stack heights: 3 vs 1
			//IL_019f->IL005f: Incompatible stack heights: 2 vs 1
			//IL_01df->IL005f: Incompatible stack types: I4 vs Ref
			//IL_0112->IL005f: Incompatible stack heights: 0 vs 1
			//IL_00c7->IL005f: Incompatible stack types: I4 vs Ref
			//IL_01c5->IL005f: Incompatible stack types: I4 vs Ref
			//IL_014b->IL005f: Incompatible stack types: I4 vs Ref
			//IL_021e->IL0222: Incompatible stack types: I4 vs Ref
			//IL_011d->IL005f: Incompatible stack types: I4 vs Ref
			//IL_0356->IL0222: Incompatible stack heights: 2 vs 1
			//IL_0289->IL0222: Incompatible stack heights: 2 vs 1
			//IL_02ef->IL0222: Incompatible stack heights: 4 vs 1
			//IL_02bd->IL0222: Incompatible stack heights: 2 vs 1
			//IL_026e->IL0222: Incompatible stack heights: 0 vs 1
			//IL_0222->IL0222: Incompatible stack heights: 3 vs 1
			//IL_0303->IL0222: Incompatible stack heights: 0 vs 1
			//IL_0361->IL0222: Incompatible stack heights: 2 vs 1
			//IL_0294->IL0222: Incompatible stack heights: 2 vs 1
			//IL_0328->IL0222: Incompatible stack types: I4 vs Ref
			//IL_0279->IL0222: Incompatible stack types: I4 vs Ref
			//IL_030e->IL0222: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			object obj2 = obj;
			while (true)
			{
				ref object reference;
				switch ((int)obj2)
				{
				case 3:
					return;
				case 2:
					_ = 3;
					break;
				case 1:
					if (obj == null)
					{
						reference = ref *(object*)13;
						goto IL_005f;
					}
					goto IL_01df;
				default:
					goto IL_0484;
				case 5:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						obj2 = 4;
					}
					break;
				case 4:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (1 == 0)
						{
							obj2 = 1;
						}
						break;
					}
					IL_019f:
					reference = ref *(object*)2;
					goto IL_005f;
					IL_005f:
					while (true)
					{
						ref _003CHeartbeatCircleAsync_003Ed__24 reference2;
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 9u:
							return;
						case 6u:
						case 12u:
							if (obj == null)
							{
								reference = ref *(object*)17;
								continue;
							}
							goto case 5u;
						case 5u:
							obj = 30.0;
							reference = ref *(object*)11;
							continue;
						case 18u:
							obj = -1;
							_ = 10;
							continue;
						case 11u:
							if (&obj != null)
							{
								if (8 == 0)
								{
									reference = ref *(object*)4;
								}
								continue;
							}
							goto case 3u;
						case 1u:
							if (obj != null)
							{
								if (false)
								{
									reference = ref *(object*)null;
								}
								continue;
							}
							goto IL_0484;
						case 4u:
							_ = ref obj;
							if (9 != 0)
							{
								_ = 8;
							}
							continue;
						case 7u:
							if (3 != 0)
							{
								_ = 4;
							}
							continue;
						case 13u:
						case 15u:
							obj = (object)Unsafe.AsPointer(ref this);
							if (14 == 0)
							{
								reference = ref *(object*)16;
							}
							continue;
						case 8u:
						case 10u:
							reference = ref obj;
							if (0 == 0)
							{
								reference = ref *(object*)1;
							}
							continue;
						case 14u:
							goto IL_01df;
						case 2u:
							if ((nint)obj != 1)
							{
								if (8 == 0)
								{
									reference2 = ref *(_003CHeartbeatCircleAsync_003Ed__24*)11;
								}
								goto IL_0222;
							}
							goto IL_02d1;
						case 3u:
							obj = 0;
							if (4 != 0)
							{
								_ = 7;
							}
							continue;
						case 16u:
							_ = 18;
							continue;
						case 17u:
							goto IL_0484;
							IL_02d1:
							obj = (object)Unsafe.AsPointer(ref this);
							reference2 = ref *(_003CHeartbeatCircleAsync_003Ed__24*)9;
							goto IL_0222;
							IL_0222:
							while (true)
							{
								switch ((uint)Unsafe.AsPointer(ref reference2))
								{
								case 6u:
									return;
								case 5u:
									break;
								case 11u:
									obj = obj;
									if (0 == 0)
									{
										reference2 = ref *(_003CHeartbeatCircleAsync_003Ed__24*)1;
									}
									continue;
								case 4u:
									if (5 == 0)
									{
										_ = 7;
									}
									continue;
								case 3u:
								case 8u:
									_ = ref obj;
									_ = 5;
									continue;
								default:
									obj = 1;
									obj = 4;
									continue;
								case 10u:
									goto IL_02d1;
								case 7u:
									_ = ref obj;
									_ = 6;
									continue;
								case 1u:
									if (&obj != null)
									{
										if (3 != 0)
										{
											reference2 = ref *(_003CHeartbeatCircleAsync_003Ed__24*)null;
										}
										continue;
									}
									goto default;
								case 9u:
									reference2 = ref this;
									if (2 == 0)
									{
										reference2 = ref *(_003CHeartbeatCircleAsync_003Ed__24*)null;
									}
									continue;
								case 2u:
									obj = -1;
									if (8 == 0)
									{
										_ = 1;
									}
									continue;
								}
								break;
							}
							goto case 6u;
						}
						break;
					}
					goto IL_019f;
					IL_01df:
					if ((nint)obj != 1)
					{
						if (6 == 0)
						{
							reference = ref *(object*)6;
						}
						goto IL_005f;
					}
					goto IL_019f;
					IL_0484:
					_ = -2;
					_ = 2;
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
		private sealed void _FF00_FF00_FF00_FF00_E000(object P_0)
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
		internal static byte _FF00_FF00_FF00_FF00_E100()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_005b: Expected Obj, but got Ref
			//IL_04a8: Expected Obj, but got Ref
			//IL_04b1: Expected Obj, but got I4
			//IL_00c3: Expected Obj, but got I4
			//IL_01d3: Expected Obj, but got I4
			//IL_0148: Expected Obj, but got I4
			//IL_010d: Expected I4, but got Obj
			//IL_0238: Expected Obj, but got I4
			//IL_01a2: Expected Obj, but got Ref
			//IL_021b: Expected Obj, but got I4
			//IL_004c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_04a4->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0067->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0057->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0072->IL0019: Incompatible stack types: I4 vs Obj
			//IL_00a7->IL0084: Incompatible stack heights: 0 vs 1
			//IL_00cc->IL00cc: Incompatible stack types: Obj vs Ref
			//IL_01df->IL00cc: Incompatible stack heights: 0 vs 1
			//IL_01ea->IL00cc: Incompatible stack types: I4 vs Ref
			//IL_01fc->IL00cc: Incompatible stack heights: 3 vs 1
			//IL_0245->IL00cc: Incompatible stack heights: 2 vs 1
			//IL_015d->IL00cc: Incompatible stack heights: 2 vs 1
			//IL_01be->IL00cc: Incompatible stack heights: 2 vs 1
			//IL_01cb->IL00cc: Incompatible stack heights: 2 vs 1
			//IL_01ac->IL00cc: Incompatible stack types: I4 vs Ref
			//IL_0228->IL00cc: Incompatible stack heights: 2 vs 1
			//IL_0207->IL00cc: Incompatible stack heights: 3 vs 1
			//IL_0182->IL00cc: Incompatible stack types: I4 vs Ref
			//IL_0250->IL00cc: Incompatible stack heights: 2 vs 1
			//IL_0168->IL00cc: Incompatible stack heights: 2 vs 1
			//IL_0124->IL00cc: Incompatible stack types: I4 vs Ref
			//IL_0233->IL00cc: Incompatible stack heights: 2 vs 1
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
					case 2:
						return;
					default:
						_ = -2;
						if (0 == 0)
						{
							_ = 1;
						}
						continue;
					case 4:
						obj = (object)Unsafe.AsPointer(ref this);
						if (3 == 0)
						{
							obj2 = 0;
						}
						continue;
					case 3:
					{
						int num = 2;
						while (true)
						{
							scoped ref object reference;
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
									if (obj == null)
									{
										obj = 13;
										goto IL_00c8;
									}
									goto IL_0137;
								}
								IL_0137:
								if (obj == null)
								{
									obj = 6;
									goto IL_00c8;
								}
								goto IL_01cb;
								IL_00cc:
								while (true)
								{
									switch ((uint)Unsafe.AsPointer(ref reference))
									{
									case 12u:
										return;
									case 6u:
										break;
									case 7u:
										if (&obj == null)
										{
											reference = ref *(object*)10;
											continue;
										}
										goto case 1u;
									case 11u:
									case 14u:
										goto end_IL_00cc;
									case 4u:
										if (0 == 0)
										{
											_ = 0;
										}
										continue;
									case 1u:
										reference = ref obj;
										if (11 == 0)
										{
											reference = ref *(object*)2;
										}
										continue;
									case 9u:
									case 13u:
										obj = (object)Unsafe.AsPointer(ref this);
										reference = ref *(object*)8;
										continue;
									case 5u:
										obj = obj;
										_ = 7;
										continue;
									case 8u:
										_ = 3;
										continue;
									case 2u:
										goto IL_01cb;
									default:
										_ = ref obj;
										if (12 != 0)
										{
											_ = 7;
										}
										continue;
									case 10u:
										obj = 0;
										if (4 == 0)
										{
											_ = 2;
										}
										continue;
									case 3u:
										obj = -1;
										if (false)
										{
											_ = 1;
										}
										continue;
									}
									goto end_IL_0084;
									continue;
									end_IL_00cc:
									break;
								}
								goto IL_0137;
								IL_00c8:
								reference = ref *(object*)obj;
								goto IL_00cc;
								IL_01cb:
								obj = 4096;
								if (5 == 0)
								{
									reference = ref *(object*)5;
								}
								goto IL_00cc;
								end_IL_0084:
								break;
							}
							break;
						}
						goto default;
					}
					case 1:
						_ = 2;
						continue;
					case 5:
						break;
					}
					break;
				}
				obj = (object)Unsafe.AsPointer(ref this);
				obj = 4;
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
		private sealed void _FF00_FF00_FF00_FF00_FFFD(object P_0)
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779265, new IntPtr(2737336599036L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FFFD()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_004f: Expected I4, but got Obj
			//IL_0704: Expected Obj, but got Ref
			//IL_071f: Expected Obj, but got Ref
			//IL_0530: Expected Obj, but got Ref
			//IL_02a1: Expected Obj, but got Ref
			//IL_0173: Expected Obj, but got Ref
			//IL_04e9: Expected Obj, but got I4
			//IL_0322: Expected Obj, but got I4
			//IL_0444: Expected Obj, but got I4
			//IL_0235: Expected Obj, but got I4
			//IL_050e: Expected Obj, but got I4
			//IL_01cb: Expected Obj, but got I4
			//IL_01d4: Expected Obj, but got I4
			//IL_054c: Expected Obj, but got I4
			//IL_04fb: Expected Obj, but got I4
			//IL_0504: Expected Obj, but got I4
			//IL_0245: Expected Obj, but got I4
			//IL_02e2: Expected Obj, but got Ref
			//IL_0192: Expected Obj, but got I4
			//IL_0300: Expected Obj, but got Ref
			//IL_0306: Expected Obj, but got I4
			//IL_05b2: Expected Obj, but got I4
			//IL_04ab: Expected Obj, but got Ref
			//IL_05fa: Expected Obj, but got I4
			//IL_0627: Expected Obj, but got I4
			//IL_0655: Expected Obj, but got I4
			//IL_027d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0280: Expected Obj, but got Unknown
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0710->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0729->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0739->IL0019: Incompatible stack heights: 2 vs 1
			//IL_02ab->IL005d: Incompatible stack heights: 1 vs 0
			//IL_017d->IL005d: Incompatible stack heights: 1 vs 0
			//IL_0059->IL005d: Incompatible stack heights: 1 vs 0
			//IL_06ff->IL0019: Incompatible stack types: I4 vs Ref
			//IL_071b->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0744->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0547->IL005d: Incompatible stack heights: 1 vs 0
			//IL_03a8->IL005d: Incompatible stack heights: 4 vs 0
			//IL_016f->IL005d: Incompatible stack heights: 3 vs 0
			//IL_04f4->IL005d: Incompatible stack heights: 3 vs 0
			//IL_032f->IL005d: Incompatible stack heights: 2 vs 0
			//IL_034e->IL005d: Incompatible stack heights: 1 vs 0
			//IL_025d->IL005d: Incompatible stack heights: 2 vs 0
			//IL_0369->IL005d: Incompatible stack heights: 2 vs 0
			//IL_0240->IL005d: Incompatible stack heights: 3 vs 0
			//IL_04e4->IL005d: Incompatible stack heights: 3 vs 0
			//IL_029d->IL005d: Incompatible stack heights: 5 vs 0
			//IL_0519->IL005d: Incompatible stack heights: 3 vs 0
			//IL_05d3->IL005d: Incompatible stack heights: 3 vs 0
			//IL_04a2->IL005d: Incompatible stack heights: 6 vs 0
			//IL_01d9->IL0059: Incompatible stack heights: 0 vs 4
			//IL_0557->IL005d: Incompatible stack heights: 3 vs 0
			//IL_0509->IL0059: Incompatible stack heights: 1 vs 4
			//IL_0206->IL005d: Incompatible stack heights: 6 vs 0
			//IL_0578->IL005d: Incompatible stack heights: 3 vs 0
			//IL_04d6->IL005d: Incompatible stack heights: 2 vs 0
			//IL_0250->IL005d: Incompatible stack heights: 3 vs 0
			//IL_05c5->IL005d: Incompatible stack heights: 3 vs 0
			//IL_02dd->IL005d: Incompatible stack heights: 3 vs 0
			//IL_026a->IL005d: Incompatible stack heights: 2 vs 0
			//IL_0213->IL005d: Incompatible stack heights: 1 vs 0
			//IL_01ed->IL005d: Incompatible stack heights: 3 vs 0
			//IL_0312->IL005d: Incompatible stack heights: 2 vs 0
			//IL_0225->IL005d: Incompatible stack heights: 3 vs 0
			//IL_05b7->IL0059: Incompatible stack heights: 1 vs 4
			//IL_04ba->IL005d: Incompatible stack heights: 7 vs 0
			//IL_0277->IL005d: Incompatible stack heights: 2 vs 0
			//IL_052c->IL005d: Incompatible stack heights: 1 vs 0
			//IL_03e8->IL005d: Incompatible stack heights: 1 vs 0
			//IL_033a->IL005d: Incompatible stack heights: 2 vs 0
			//IL_0359->IL005d: Incompatible stack heights: 1 vs 0
			//IL_005d->IL005d: Incompatible stack heights: 5 vs 0
			//IL_0374->IL005d: Incompatible stack heights: 2 vs 0
			//IL_05ff->IL0059: Incompatible stack heights: 0 vs 4
			//IL_03fa->IL005d: Incompatible stack heights: 1 vs 0
			//IL_0583->IL005d: Incompatible stack heights: 3 vs 0
			//IL_0389->IL005d: Incompatible stack heights: 1 vs 0
			//IL_065a->IL0059: Incompatible stack heights: 12 vs 4
			//IL_05a6->IL005d: Incompatible stack heights: 1 vs 0
			//IL_02cf->IL005d: Incompatible stack heights: 1 vs 0
			//IL_0415->IL005d: Incompatible stack heights: 1 vs 0
			//IL_0463->IL005d: Incompatible stack heights: 1 vs 0
			//IL_02f9->IL005d: Incompatible stack heights: 1 vs 0
			//IL_0427->IL005d: Incompatible stack heights: 1 vs 0
			//IL_01a9->IL005d: Incompatible stack heights: 1 vs 0
			//IL_031d->IL005d: Incompatible stack heights: 2 vs 0
			//IL_0230->IL005d: Incompatible stack heights: 3 vs 0
			//IL_028a->IL005d: Incompatible stack heights: 1 vs 0
			//IL_03c7->IL005d: Incompatible stack heights: 1 vs 0
			//IL_01c8->IL005d: Incompatible stack heights: 1 vs 0
			//IL_0611->IL005d: Incompatible stack heights: 1 vs 0
			//IL_0489->IL005d: Incompatible stack heights: 1 vs 0
			//IL_061c->IL005d: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			ref _003CReceiveControlDataAsync_003Ed__22 reference = ref *(_003CReceiveControlDataAsync_003Ed__22*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					switch ((int)obj)
					{
					default:
						_ = 46;
						goto IL_005d;
					case 2:
						obj = (object)Unsafe.AsPointer(ref this);
						_ = 8;
						goto IL_005d;
					case 1:
						goto IL_029d;
					case 0:
						goto IL_052c;
						IL_005d:
						while (true)
						{
							switch ((int)/*Error near IL_0156: Stack underflow*/)
							{
							default:
								return;
							case 3:
								obj = obj;
								_ = 4;
								continue;
							case 9:
								break;
							case 30:
								return;
							case 49:
								obj = ((byte[])(ref this))[4];
								if (24 == 0)
								{
									_ = 7;
								}
								continue;
							case 19:
								if (&obj == null)
								{
									if (17 == 0)
									{
										_ = 7;
									}
									continue;
								}
								goto case 44;
							case 21:
								obj = 0;
								obj = 53;
								continue;
							case 52:
								_ = 20;
								continue;
							case 26:
								_ = 8;
								_ = 0;
								_ = 18;
								continue;
							case 45:
								obj = (object)/*Error near IL_0209: Stack underflow*/;
								_ = 39;
								continue;
							case 55:
								_ = ref obj;
								if (false)
								{
									_ = 0;
								}
								continue;
							case 13:
								obj = -1;
								_ = 31;
								continue;
							case 34:
								obj = 2;
								_ = 35;
								continue;
							case 8:
								_ = 13;
								continue;
							case 42:
								_ = 22;
								continue;
							case 59:
								_ = ref obj;
								_ = 37;
								continue;
							case 58:
								throw /*Error near IL_027a: Stack underflow*/;
							case 16:
								_ = 0;
								_ = 16;
								_ = 52;
								continue;
							case 14:
								goto IL_029d;
							case 0:
								return;
							case 33:
							case 40:
								if (((byte[])(ref this))[0] == 17)
								{
									_ = 45;
									continue;
								}
								goto case 43;
							case 36:
								_ = 28;
								continue;
							case 44:
								obj = (object)(&obj);
								if (7 == 0)
								{
									_ = 4;
								}
								continue;
							case 54:
								_ = 4;
								obj = ((Array)Unsafe.AsPointer(ref this)).Length - 4;
								if (6 != 0)
								{
									_ = 21;
								}
								continue;
							case 6:
								obj = -1;
								if (44 != 0)
								{
									_ = 24;
								}
								continue;
							case 7:
								obj = obj;
								if (19 == 0)
								{
									_ = 25;
								}
								continue;
							case 12:
								if (20 == 0)
								{
									_ = 55;
								}
								continue;
							case 32:
							case 53:
								if ((nint)obj >= ((Array)obj).Length)
								{
									_ = 49;
									continue;
								}
								goto IL_0463;
							case 2:
								_ = ref obj;
								_ = 47;
								continue;
							case 10:
								if (obj == null)
								{
									if (1 == 0)
									{
										_ = 1;
									}
									continue;
								}
								goto case 50;
							case 4:
								if (&obj == null)
								{
									_ = 34;
									continue;
								}
								goto case 31;
							case 25:
								if (&obj == null)
								{
									_ = 5;
									continue;
								}
								goto case 59;
							case 39:
							case 41:
								obj = obj;
								if (38 == 0)
								{
									_ = 8;
								}
								continue;
							case 46:
								if (obj == null)
								{
									_ = 16;
									continue;
								}
								goto case 10;
							case 11:
								obj = obj;
								obj = 19;
								continue;
							case 43:
								obj = (object)/*Error near IL_044c: Stack underflow*/;
								if (10 != 0)
								{
									_ = 41;
								}
								continue;
							case 60:
								goto IL_0463;
							case 20:
								_ = 8;
								_ = 1;
								_ = 26;
								continue;
							case 50:
							case 57:
								_ = 0;
								_ = ((Array)Unsafe.AsPointer(ref this)).Length;
								_ = 0;
								_ = 54;
								continue;
							case 31:
								_ = ref obj;
								_ = 27;
								continue;
							case 15:
								_ = 1;
								_ = 23;
								continue;
							case 5:
								obj = 1;
								_ = 12;
								continue;
							case 24:
								obj = 8;
								obj = 3;
								continue;
							case 17:
								obj = 0;
								_ = 36;
								continue;
							case 1:
								if (((byte[])(ref this))[0] != 0)
								{
									_ = 33;
									continue;
								}
								goto case 15;
							case 51:
								goto IL_052c;
							case 22:
								obj = -1;
								_ = 59;
								continue;
							case 28:
								_ = ref obj;
								if (30 == 0)
								{
									_ = 25;
								}
								continue;
							case 38:
								goto IL_0592;
							case 56:
								obj = 6;
								continue;
							case 35:
								_ = 2;
								continue;
							case 18:
								_ = 1;
								_ = 11;
								continue;
							case 47:
								return;
							case 23:
								goto IL_05e2;
							case 27:
							case 29:
							case 37:
							case 48:
								goto end_IL_003e;
							}
							break;
							IL_05e2:
							if (obj == null)
							{
								obj = 29;
							}
							else if (48 == 0)
							{
								_ = 35;
							}
							continue;
							IL_0592:
							if (obj == null)
							{
								_ = 50;
								continue;
							}
							_ = 19;
							obj = 3;
							_ = ref obj;
							_ = ref obj;
							_ = ((byte[])(ref this))[0];
							_ = ref obj;
							_ = ref obj;
							_ = ((byte[])(ref this))[0];
							_ = ref obj;
							_ = ref obj;
							_ = ref obj;
							obj = 57;
							continue;
							IL_0463:
							if (((byte[])(ref this))[obj] == ((byte[])obj)[obj])
							{
								obj++;
								_ = 32;
							}
							else if (24 == 0)
							{
								_ = 58;
							}
						}
						goto case 2;
						IL_052c:
						obj = (object)Unsafe.AsPointer(ref this);
						if (56 == 0)
						{
							_ = 2;
						}
						goto IL_005d;
						IL_029d:
						obj = (object)Unsafe.AsPointer(ref this);
						_ = 42;
						goto IL_005d;
						end_IL_003e:
						break;
					}
					break;
				case 1u:
					reference = ref this;
					if (4 != 0)
					{
						reference = ref *(_003CReceiveControlDataAsync_003Ed__22*)2;
					}
					continue;
				case 4u:
					return;
				case 2u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						reference = ref *(_003CReceiveControlDataAsync_003Ed__22*)null;
					}
					continue;
				case 3u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CReceiveControlDataAsync_003Ed__22*)2;
					continue;
				case 5u:
					break;
				}
				_ = -2;
				if (1 == 0)
				{
					_ = 1;
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
		private sealed void _FF00_FF00_FF00_FF00촀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00츀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779277, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00케()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0082: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_040c: Expected Obj, but got Ref
			//IL_041b: Expected Obj, but got Ref
			//IL_046b: Invalid comparison between Obj and Ref
			//IL_048e: Expected Obj, but got I4
			//IL_0155: Expected Obj, but got I4
			//IL_01a6: Expected Obj, but got Ref
			//IL_044d: Expected Obj, but got I4
			//IL_042f: Expected Obj, but got Ref
			//IL_0434: Expected Obj, but got I4
			//IL_0479: Expected Obj, but got I4
			//IL_032e: Expected Obj, but got Ref
			//IL_033d: Expected Obj, but got I4
			//IL_02eb: Expected Obj, but got I4
			//IL_02f5: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_008e->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_007e->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0099->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0056->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0416->IL00bc: Incompatible stack types: I4 vs Ref
			//IL_00ad->IL00bc: Incompatible stack heights: 0 vs 1
			//IL_0070->IL0019: Incompatible stack types: I4 vs Ref
			//IL_00b8->IL00bc: Incompatible stack types: I4 vs Ref
			//IL_0425->IL00bc: Incompatible stack types: I4 vs Ref
			//IL_049b->IL00bc: Incompatible stack heights: 2 vs 1
			//IL_0162->IL00bc: Incompatible stack heights: 2 vs 1
			//IL_0489->IL00bc: Incompatible stack types: I4 vs Ref
			//IL_0134->IL00bc: Incompatible stack heights: 3 vs 1
			//IL_0180->IL00bc: Incompatible stack heights: 4 vs 1
			//IL_01b2->IL00bc: Incompatible stack heights: 2 vs 1
			//IL_0217->IL00bc: Incompatible stack heights: 6 vs 1
			//IL_043e->IL00bc: Incompatible stack heights: 4 vs 1
			//IL_024c->IL00bc: Incompatible stack heights: 0 vs 1
			//IL_047e->IL00b8: Incompatible stack heights: 0 vs 3
			//IL_04a6->IL00bc: Incompatible stack heights: 2 vs 1
			//IL_016d->IL00bc: Incompatible stack heights: 2 vs 1
			//IL_01e1->IL00bc: Incompatible stack heights: 4 vs 1
			//IL_01f3->IL00bc: Incompatible stack types: I4 vs Ref
			//IL_0408->IL00bc: Incompatible stack types: I4 vs Ref
			//IL_022d->IL00bc: Incompatible stack heights: 0 vs 1
			//IL_01bd->IL00bc: Incompatible stack heights: 2 vs 1
			//IL_0463->IL00bc: Incompatible stack types: I4 vs Ref
			//IL_00bc->IL00bc: Incompatible stack heights: 4 vs 1
			//IL_0338->IL027b: Incompatible stack types: I4 vs Ref
			//IL_026c->IL027b: Incompatible stack heights: 0 vs 1
			//IL_0257->IL00bc: Incompatible stack types: I4 vs Ref
			//IL_0238->IL00bc: Incompatible stack types: I4 vs Ref
			//IL_0277->IL027b: Incompatible stack types: I4 vs Ref
			//IL_0348->IL027b: Incompatible stack heights: 3 vs 1
			//IL_031f->IL027b: Incompatible stack heights: 3 vs 1
			//IL_0382->IL027b: Incompatible stack heights: 3 vs 1
			//IL_0355->IL027b: Incompatible stack heights: 2 vs 1
			//IL_0302->IL027b: Incompatible stack heights: 2 vs 1
			//IL_027b->IL027b: Incompatible stack heights: 2 vs 1
			//IL_032a->IL027b: Incompatible stack heights: 3 vs 1
			//IL_030d->IL027b: Incompatible stack heights: 2 vs 1
			//IL_02da->IL027b: Incompatible stack types: I4 vs Ref
			//IL_0369->IL027b: Incompatible stack heights: 0 vs 1
			//IL_0374->IL027b: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			ref _003CReceiveDataAsync_003Ed__21 reference = ref *(_003CReceiveDataAsync_003Ed__21*)obj;
			while (true)
			{
				ref _003CReceiveDataAsync_003Ed__21 reference2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 1u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						reference = ref *(_003CReceiveDataAsync_003Ed__21*)null;
					}
					break;
				case 4u:
					reference = ref this;
					if (2 != 0)
					{
						reference = ref *(_003CReceiveDataAsync_003Ed__21*)2;
					}
					break;
				case 5u:
					_ = -2;
					_ = 4;
					break;
				default:
					obj = (object)Unsafe.AsPointer(ref this);
					if (3 != 0)
					{
						reference = ref *(_003CReceiveDataAsync_003Ed__21*)3;
					}
					break;
				case 3u:
					if (obj != null)
					{
						if (0 == 0)
						{
							reference2 = ref *(_003CReceiveDataAsync_003Ed__21*)null;
						}
						goto IL_00bc;
					}
					goto IL_0408;
				case 2u:
					return;
					IL_0408:
					obj = (object)Unsafe.AsPointer(ref this);
					reference2 = ref *(_003CReceiveDataAsync_003Ed__21*)14;
					goto IL_00bc;
					IL_00bc:
					while (true)
					{
						ref _003CReceiveDataAsync_003Ed__21 reference3;
						switch ((uint)Unsafe.AsPointer(ref reference2))
						{
						case 20u:
							break;
						case 10u:
							_ = 21;
							continue;
						case 13u:
							return;
						case 5u:
							obj = -1;
							if (1 == 0)
							{
								_ = 1;
							}
							continue;
						case 15u:
							_ = 0;
							_ = (ref *(byte*)2) + (ref Unsafe.As<_003CReceiveDataAsync_003Ed__21, byte>(ref this));
							_ = 16;
							continue;
						case 17u:
							_ = 2;
							obj = (object)Unsafe.AsPointer(ref this);
							if (2 != 0)
							{
								_ = 7;
							}
							continue;
						case 9u:
							throw /*Error near IL_01ce: Stack underflow*/;
						case 6u:
							_ = 8;
							continue;
						case 11u:
							if (&obj != null)
							{
								reference2 = ref *(_003CReceiveDataAsync_003Ed__21*)3;
								continue;
							}
							goto case 4u;
						case 19u:
							_ = 0;
							_ = 2;
							_ = 0;
							_ = 2;
							continue;
						case 8u:
						case 16u:
							if ((nint)obj < 2)
							{
								if (18 == 0)
								{
									reference2 = ref *(_003CReceiveDataAsync_003Ed__21*)20;
								}
								continue;
							}
							goto case 19u;
						default:
							if ((nint)obj != 1)
							{
								if (10 != 0)
								{
									reference2 = ref *(_003CReceiveDataAsync_003Ed__21*)22;
								}
								continue;
							}
							goto case 7u;
						case 23u:
							if ((nint)obj != 1)
							{
								if (1 == 0)
								{
									reference3 = ref *(_003CReceiveDataAsync_003Ed__21*)1;
								}
								goto IL_027b;
							}
							goto IL_032a;
						case 14u:
							reference2 = ref this;
							if (false)
							{
								reference2 = ref *(_003CReceiveDataAsync_003Ed__21*)5;
							}
							continue;
						case 12u:
							goto IL_0408;
						case 1u:
						case 3u:
							obj = (object)(&obj);
							reference2 = ref *(_003CReceiveDataAsync_003Ed__21*)18;
							continue;
						case 22u:
							_ = 0;
							obj = ((Array)Unsafe.AsPointer(ref this)).Length;
							_ = 11;
							continue;
						case 21u:
							_ = ref obj;
							obj = 13;
							continue;
						case 18u:
							if (obj != null)
							{
								reference2 = ref *(_003CReceiveDataAsync_003Ed__21*)6;
								continue;
							}
							goto case 9u;
						case 2u:
							if (!Unsafe.IsAddressLessThan(ref *(byte*)obj, ref *(byte*)((ref *(byte*)2) + (ref Unsafe.As<_003CReceiveDataAsync_003Ed__21, byte>(ref this)))))
							{
								obj = 17;
								continue;
							}
							break;
						case 7u:
							reference2 = ref *(_003CReceiveDataAsync_003Ed__21*)23;
							continue;
						case 4u:
							{
								obj = 0;
								if (6 != 0)
								{
									_ = 10;
								}
								continue;
							}
							IL_032a:
							obj = (object)Unsafe.AsPointer(ref this);
							reference3 = ref *(_003CReceiveDataAsync_003Ed__21*)9;
							goto IL_027b;
							IL_027b:
							while (true)
							{
								switch ((uint)Unsafe.AsPointer(ref reference3))
								{
								case 2u:
									break;
								case 3u:
									return;
								case 9u:
									reference3 = ref this;
									if (0 == 0)
									{
										reference3 = ref *(_003CReceiveDataAsync_003Ed__21*)null;
									}
									continue;
								case 1u:
									obj = obj;
									obj = 10;
									continue;
								case 7u:
									obj = 1;
									if (false)
									{
										_ = 5;
									}
									continue;
								case 4u:
									_ = ref obj;
									if (3 == 0)
									{
										_ = 3;
									}
									continue;
								case 8u:
									goto IL_032a;
								default:
									obj = -1;
									_ = 6;
									continue;
								case 6u:
									_ = ref obj;
									_ = 2;
									continue;
								case 10u:
									if (&obj == null)
									{
										if (7 == 0)
										{
											reference3 = ref *(_003CReceiveDataAsync_003Ed__21*)5;
										}
										continue;
									}
									goto case 6u;
								case 5u:
									_ = 4;
									continue;
								}
								break;
							}
							goto case 15u;
						}
						break;
					}
					goto case 5u;
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
		private sealed void _FF00_FF00_FF00_FF00쀀(object P_0)
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
		internal static byte _FF00_FF00_FF00_FF00섀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0032: Expected I4, but got Obj
			//IL_0065: Expected Obj, but got Ref
			//IL_003b: Expected Obj, but got Ref
			//IL_027d: Expected Obj, but got I4
			//IL_01de: Expected Obj, but got I4
			//IL_025a: Expected Obj, but got I4
			//IL_02af: Expected Obj, but got I4
			//IL_02ee: Expected Obj, but got I4
			//IL_00d4: Expected I4, but got Obj
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_039e->IL0019: Incompatible stack heights: 3 vs 1
			//IL_006f->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0045->IL0019: Incompatible stack types: I4 vs Ref
			//IL_005f->IL0019: Incompatible stack types: I4 vs Ref
			//IL_01d0->IL0073: Incompatible stack heights: 0 vs 1
			//IL_016b->IL0073: Incompatible stack types: I4 vs Obj
			//IL_019a->IL0073: Incompatible stack heights: 0 vs 1
			//IL_01e8->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0266->IL0073: Incompatible stack heights: 0 vs 1
			//IL_02bb->IL0073: Incompatible stack heights: 0 vs 1
			//IL_0180->IL0073: Incompatible stack heights: 0 vs 1
			//IL_02a9->IL0073: Incompatible stack types: I4 vs Obj
			//IL_01db->IL0073: Incompatible stack types: I4 vs Obj
			//IL_024c->IL0073: Incompatible stack heights: 0 vs 1
			//IL_01a5->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0152->IL0073: Incompatible stack heights: 0 vs 1
			//IL_0118->IL0073: Incompatible stack heights: 0 vs 1
			//IL_0271->IL0073: Incompatible stack types: I4 vs Obj
			//IL_01fe->IL0073: Incompatible stack heights: 0 vs 1
			//IL_0238->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0312->IL0073: Incompatible stack heights: 10 vs 1
			//IL_0296->IL0073: Incompatible stack types: I4 vs Obj
			//IL_02c6->IL0073: Incompatible stack types: I4 vs Obj
			//IL_018b->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0257->IL0073: Incompatible stack types: I4 vs Obj
			//IL_015d->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0123->IL0073: Incompatible stack types: I4 vs Obj
			//IL_02e3->IL0073: Incompatible stack types: I4 vs Obj
			//IL_0209->IL0073: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			ref _003CRemoteCallBackAsync_003Ed__23 reference = ref *(_003CRemoteCallBackAsync_003Ed__23*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					return;
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CRemoteCallBackAsync_003Ed__23*)3;
					continue;
				case 2u:
					reference = ref this;
					if (false)
					{
						reference = ref *(_003CRemoteCallBackAsync_003Ed__23*)null;
					}
					continue;
				case 0u:
					return;
				case 3u:
				{
					obj = (object)Unsafe.AsPointer(ref this);
					object obj2 = 9;
					while (true)
					{
						switch ((int)obj2)
						{
						case 13:
							if ((nint)obj != 4)
							{
								if (2 == 0)
								{
									obj2 = 0;
								}
								continue;
							}
							goto case 3;
						case 12:
						case 14:
							if (obj != null)
							{
								if (0 == 0)
								{
									obj2 = 0;
								}
								continue;
							}
							break;
						case 6:
						case 7:
						case 8:
							obj = obj;
							obj2 = 20;
							continue;
						default:
							if (((byte[])(ref this))[0] != 0)
							{
								if (4 == 0)
								{
									obj2 = 4;
								}
								continue;
							}
							goto case 17;
						case 11:
							obj = (object)/*Error near IL_018e: Stack underflow*/;
							if (7 == 0)
							{
								obj2 = 4;
							}
							continue;
						case 3:
							obj = (object)/*Error near IL_01c4: Stack underflow*/;
							if (2 != 0)
							{
								obj2 = 8;
							}
							continue;
						case 15:
							obj = 1;
							obj2 = 14;
							continue;
						case 17:
							obj2 = obj;
							if (obj2 == null)
							{
								if (0 == 0)
								{
									obj2 = 1;
								}
							}
							else if (17 == 0)
							{
								obj2 = 19;
							}
							continue;
						case 18:
							if ((nint)obj == 9)
							{
								obj2 = 15;
								continue;
							}
							goto case 16;
						case 9:
							if ((nint)obj != 1)
							{
								if (17 != 0)
								{
									obj2 = 18;
								}
								continue;
							}
							goto case 15;
						case 16:
							obj = 0;
							if (12 == 0)
							{
								obj2 = 2;
							}
							continue;
						case 5:
							obj = (object)/*Error near IL_0274: Stack underflow*/;
							obj = 6;
							obj2 = obj;
							continue;
						case 20:
							if (obj == null)
							{
								obj2 = 10;
								continue;
							}
							_ = 18;
							obj = 2;
							_ = ref obj;
							_ = ref obj;
							_ = ((byte[])(ref this))[0];
							_ = ref obj;
							_ = ref obj;
							_ = ref obj;
							_ = 22;
							continue;
						case 2:
							if ((nint)obj == 16)
							{
								obj2 = 5;
								continue;
							}
							goto case 11;
						case 4:
						case 21:
							obj = ((byte[])(ref this))[0];
							if (12 != 0)
							{
								obj2 = 13;
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
				case 1u:
					break;
				}
				_ = -2;
				_ = 2;
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
		private sealed void _FF00_FF00_FF00_FF00렀(object P_0)
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
		internal static byte _FF00_FF00_FF00_FF00뤀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0040: Expected Obj, but got Ref
			//IL_0049: Expected Obj, but got I4
			//IL_005f: Expected Obj, but got Ref
			//IL_0237: Expected Obj, but got Ref
			//IL_0199: Expected Obj, but got Ref
			//IL_021b: Expected Obj, but got I4
			//IL_0155: Expected Obj, but got Ref
			//IL_015e: Expected Obj, but got Ref
			//IL_0211: Expected Obj, but got I4
			//IL_01e1: Expected Obj, but got I4
			//IL_0117: Expected Obj, but got Ref
			//IL_005b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0079->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0069->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0084->IL0019: Incompatible stack heights: 2 vs 1
			//IL_024e->IL00a7: Incompatible stack heights: 1 vs 0
			//IL_00a3->IL00a7: Incompatible stack heights: 1 vs 0
			//IL_01cd->IL00a7: Incompatible stack heights: 3 vs 0
			//IL_0175->IL00a7: Incompatible stack heights: 2 vs 0
			//IL_0103->IL00a7: Incompatible stack heights: 3 vs 0
			//IL_0233->IL00a7: Incompatible stack heights: 2 vs 0
			//IL_0226->IL00a7: Incompatible stack heights: 3 vs 0
			//IL_0168->IL00a7: Incompatible stack heights: 2 vs 0
			//IL_01ee->IL00a7: Incompatible stack heights: 2 vs 0
			//IL_0128->IL00a7: Incompatible stack heights: 6 vs 0
			//IL_01b0->IL00a7: Incompatible stack heights: 1 vs 0
			//IL_010e->IL00a7: Incompatible stack heights: 3 vs 0
			//IL_00a7->IL00a7: Incompatible stack heights: 4 vs 0
			//IL_01f9->IL00a7: Incompatible stack heights: 2 vs 0
			//IL_0133->IL00a7: Incompatible stack heights: 6 vs 0
			//IL_0152->IL00a7: Incompatible stack heights: 1 vs 0
			//IL_0194->IL00a7: Incompatible stack heights: 1 vs 0
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
					case 4:
						goto end_IL_0019;
					default:
						_ = 3;
						continue;
					case 5:
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 4;
						continue;
					case 1:
						break;
					case 2:
						{
							if (obj != null)
							{
								if (false)
								{
									_ = 0;
								}
								goto IL_00a7;
							}
							goto IL_0233;
						}
						IL_00a7:
						while (true)
						{
							switch ((int)/*Error near IL_00ec: Stack underflow*/)
							{
							case 14:
								return;
							case 6:
								break;
							case 5:
								_ = ref obj;
								if (14 == 0)
								{
									_ = 4;
								}
								continue;
							case 15:
								_ = 0;
								_ = ((Array)Unsafe.AsPointer(ref this)).Length;
								_ = 0;
								if (6 == 0)
								{
									_ = 11;
								}
								continue;
							default:
								if (obj == null)
								{
									if (true)
									{
										_ = 1;
									}
									continue;
								}
								goto case 15;
							case 1:
							case 11:
								_ = (ushort)((Array)Unsafe.AsPointer(ref this)).Length;
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 12;
								continue;
							case 3:
								_ = 9;
								continue;
							case 10:
								if (&obj == null)
								{
									if (5 == 0)
									{
										_ = 13;
									}
									continue;
								}
								goto case 7;
							case 4:
								obj = (object)(&obj);
								if (true)
								{
									_ = 10;
								}
								continue;
							case 2:
								_ = 5;
								continue;
							case 13:
								obj = 0;
								if (2 == 0)
								{
									_ = 2;
								}
								continue;
							case 12:
								_ = ref obj;
								obj = obj;
								obj = 4;
								continue;
							case 9:
								obj = -1;
								_ = 7;
								continue;
							case 7:
								_ = ref obj;
								_ = 6;
								continue;
							case 8:
								goto end_IL_00a7;
							}
							goto end_IL_0019_2;
							continue;
							end_IL_00a7:
							break;
						}
						goto IL_0233;
						IL_0233:
						obj = (object)Unsafe.AsPointer(ref this);
						if (3 == 0)
						{
							_ = 0;
						}
						goto IL_00a7;
						end_IL_0019_2:
						break;
					}
					_ = -2;
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
					end_IL_0019:
					break;
				}
				obj = (object)Unsafe.AsPointer(ref this);
				obj = 2;
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
		private sealed void _FF00_FF00_FF00_FF00꤀(object P_0)
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00관()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_029a: Expected Obj, but got I4
			//IL_003f: Expected Obj, but got Ref
			//IL_02a3: Expected Obj, but got Ref
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Expected Obj, but got Ref
			//IL_01a2: Expected Obj, but got I4
			//IL_0193: Expected Obj, but got Ref
			//IL_013a: Expected Obj, but got I4
			//IL_01c9: Expected Obj, but got I4
			//IL_0177: Expected Obj, but got I4
			//IL_00bd: Expected Obj, but got I4
			//IL_0283->IL0019: Incompatible stack heights: 2 vs 1
			//IL_029f->IL0015: Incompatible stack heights: 1 vs 0
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_02ad->IL0019: Incompatible stack types: I4 vs Obj
			//IL_028e->IL0019: Incompatible stack heights: 2 vs 1
			//IL_010a->IL006c: Incompatible stack types: I4 vs Ref
			//IL_0068->IL006c: Incompatible stack heights: 1 vs 10
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_00a9->IL00de: Incompatible stack heights: 9 vs 0
			//IL_01ad->IL006c: Incompatible stack heights: 12 vs 10
			//IL_019d->IL006c: Incompatible stack types: I4 vs Ref
			//IL_0158->IL006c: Incompatible stack heights: 13 vs 10
			//IL_01ce->IL0068: Incompatible stack heights: 11 vs 10
			//IL_0184->IL006c: Incompatible stack heights: 11 vs 10
			//IL_00c2->IL0068: Incompatible stack heights: 12 vs 10
			//IL_0172->IL006c: Incompatible stack types: I4 vs Ref
			//IL_011e->IL006c: Incompatible stack heights: 9 vs 10
			//IL_006c->IL006c: Incompatible stack heights: 11 vs 10
			//IL_01e8->IL006c: Incompatible stack types: I4 vs Ref
			//IL_018f->IL006c: Incompatible stack heights: 11 vs 10
			//IL_0129->IL006c: Incompatible stack heights: 9 vs 10
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					ref byte reference;
					switch ((int)obj2)
					{
					case 4:
						obj = (object)Unsafe.AsPointer(ref this);
						if (true)
						{
							obj2 = 1;
						}
						continue;
					case 1:
						if (obj == null)
						{
							_ = 9;
							goto IL_006c;
						}
						goto IL_00de;
					default:
						goto IL_0273;
					case 3:
						break;
					case 5:
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 4;
						continue;
					case 2:
						return;
						IL_00de:
						/*Error near IL_00df: Stack underflow*/;
						_ = 136;
						_ = 136;
						_ = 136;
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(byte*)10;
						goto IL_006c;
						IL_006c:
						while (true)
						{
							switch ((uint)Unsafe.AsPointer(ref reference))
							{
							case 13u:
								_ = ref obj;
								obj = 7;
								continue;
							case 8u:
								break;
							case 4u:
								if (&obj == null)
								{
									if (0 == 0)
									{
										_ = 1;
									}
									continue;
								}
								goto case 2u;
							case 5u:
								obj = obj;
								obj = 4;
								continue;
							case 10u:
								_ = 0;
								_ = ((Array)obj).Length;
								obj = obj;
								_ = 5;
								continue;
							case 2u:
								reference = ref *(byte*)(&obj);
								if (0 == 0)
								{
									reference = ref *(byte*)null;
								}
								continue;
							case 12u:
								obj = -1;
								if (2 == 0)
								{
									_ = 2;
								}
								continue;
							case 3u:
							case 9u:
								obj = (object)Unsafe.AsPointer(ref this);
								reference = ref *(byte*)6;
								continue;
							case 1u:
								obj = 0;
								_ = 11;
								continue;
							case 7u:
								return;
							case 11u:
								obj = 13;
								continue;
							case 6u:
								reference = ref Unsafe.As<_003CSendPacketAsync_003Ed__28, byte>(ref this);
								if (11 == 0)
								{
									reference = ref *(byte*)12;
								}
								continue;
							default:
								goto IL_0273;
							}
							break;
						}
						goto IL_00de;
						IL_0273:
						_ = -2;
						if (3 == 0)
						{
							_ = 3;
						}
						continue;
					}
					break;
				}
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
		private sealed void _FF00_FF00_FF00_FF00ꈀ(object P_0)
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
		internal static byte _FF00_FF00_FF00_FF00ꌀ()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
		//IL_0063: Expected I4, but got Obj
		//IL_0051->IL005a: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		DesktopAuthentication desktopAuthentication = this;
		if (0 == 0)
		{
			desktopAuthentication = (DesktopAuthentication)0;
		}
		switch ((int)desktopAuthentication)
		{
		case 0:
			break;
		}
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
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0048->IL0019: Incompatible stack types: I4 vs Obj
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
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_003f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0064->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004a->IL0019: Incompatible stack heights: 2 vs 1
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
			case 1:
				_ = 0;
				if (false)
				{
					_ = 0;
				}
				break;
			default:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 2;
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
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_00ce: Expected Obj, but got Ref
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_004d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00be->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005b->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00a3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0091->IL0019: Incompatible stack types: I4 vs Ref
		//IL_00c9->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ae->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0076->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		ref object reference = ref *(object*)obj;
		while (true)
		{
			switch ((uint)Unsafe.AsPointer(ref reference))
			{
			default:
				_ = ref obj;
				_ = 3;
				break;
			case 4u:
				_ = ref obj;
				_ = 6;
				break;
			case 6u:
				_ = ref obj;
				_ = -1;
				if (1 == 0)
				{
					_ = 5;
				}
				break;
			case 1u:
				reference = ref obj;
				if (0 == 0)
				{
					reference = ref *(object*)null;
				}
				break;
			case 5u:
				_ = ref obj;
				_ = ref obj;
				if (2 != 0)
				{
					_ = 0;
				}
				break;
			case 3u:
				_ = ref obj;
				if (2 == 0)
				{
					_ = 4;
				}
				break;
			case 2u:
				return (object)(&obj);
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
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_007a: Expected Obj, but got Ref
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_006a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0096->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0088->IL0019: Incompatible stack heights: 3 vs 1
		//IL_004f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0075->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ce->IL0019: Incompatible stack types: I4 vs Ref
		//IL_00b3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005a->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		ref object reference = ref *(object*)obj;
		while (true)
		{
			switch ((uint)Unsafe.AsPointer(ref reference))
			{
			case 5u:
				_ = ref obj;
				_ = -1;
				if (2 == 0)
				{
					_ = 2;
				}
				break;
			default:
				_ = ref obj;
				if (0 == 0)
				{
					_ = 4;
				}
				break;
			case 6u:
				return (object)(&obj);
			case 4u:
				_ = ref obj;
				_ = 3;
				break;
			case 3u:
				_ = ref obj;
				_ = 5;
				break;
			case 2u:
				_ = ref obj;
				_ = ref obj;
				if (3 == 0)
				{
					_ = 6;
				}
				break;
			case 1u:
				reference = ref obj;
				if (0 == 0)
				{
					reference = ref *(object*)null;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00_FF00ᜀ()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0061->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0048->IL0019: Incompatible stack types: I4 vs Obj
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
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
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
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0048->IL0019: Incompatible stack types: I4 vs Obj
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
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}
}
