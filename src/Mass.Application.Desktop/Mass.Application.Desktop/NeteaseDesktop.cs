using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Mass.Common.Extensions;
using Mass.Domain.Desktop.Entities;
using Mass.Domain.Desktop.Entities.LanGame;
using Mass.Domain.Entities.Netease;
using RestSharp;
using Serilog;

namespace Mass.Application.Desktop;

public class NeteaseDesktop : IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAuthenticationOtpAsync_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityAuthenticationOtp> _003C_003Et__builder;

		public NeteaseDesktop _003C_003E4__this;

		public EntityAuthenticationOtpDto dto;

		private TaskAwaiter<RestResponse<Entity<EntityAuthenticationOtp>>> _003C_003Eu__1;

		internal static object ReflectLiteralDispatcher;

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
		internal static bool ReflectScalableSingleton()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateModularCalculator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_2000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778767, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_2100()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0281: Expected Obj, but got Ref
			//IL_0273: Expected Obj, but got Ref
			//IL_010d: Expected Obj, but got Ref
			//IL_00d6: Expected Obj, but got Ref
			//IL_0181: Expected Obj, but got I4
			//IL_013f: Expected Obj, but got Ref
			//IL_0163: Expected Obj, but got I4
			//IL_0177: Expected Obj, but got I4
			//IL_019e: Expected Obj, but got I4
			//IL_0264->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0249->IL0019: Incompatible stack heights: 2 vs 1
			//IL_028b->IL0019: Incompatible stack types: I4 vs Obj
			//IL_027d->IL0019: Incompatible stack types: I4 vs Obj
			//IL_026f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0254->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004d->IL0051: Incompatible stack heights: 1 vs 0
			//IL_0124->IL0051: Incompatible stack heights: 1 vs 0
			//IL_009f->IL0051: Incompatible stack heights: 2 vs 0
			//IL_00e2->IL0051: Incompatible stack heights: 2 vs 0
			//IL_01b6->IL0051: Incompatible stack heights: 2 vs 0
			//IL_018e->IL0051: Incompatible stack heights: 2 vs 0
			//IL_0138->IL0051: Incompatible stack heights: 3 vs 0
			//IL_017c->IL004d: Incompatible stack heights: 3 vs 0
			//IL_01a9->IL0051: Incompatible stack heights: 3 vs 0
			//IL_00aa->IL0051: Incompatible stack heights: 2 vs 0
			//IL_00ed->IL0051: Incompatible stack heights: 2 vs 0
			//IL_0199->IL0051: Incompatible stack heights: 2 vs 0
			//IL_0156->IL0051: Incompatible stack heights: 1 vs 0
			//IL_0051->IL0051: Incompatible stack heights: 1 vs 0
			//IL_00c9->IL0051: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 5:
					if (obj != null)
					{
						_ = 3;
						goto IL_0051;
					}
					goto IL_0109;
				case 1:
					if (1 == 0)
					{
						_ = 4;
					}
					break;
				default:
					goto IL_0254;
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 2;
					break;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 5;
					break;
				case 4:
					return;
					IL_0254:
					_ = -2;
					if (1 == 0)
					{
						_ = 1;
					}
					break;
					IL_0051:
					while (true)
					{
						switch ((int)/*Error near IL_008a: Stack underflow*/)
						{
						default:
							if (11 == 0)
							{
								_ = 6;
							}
							continue;
						case 8:
							if (&obj == null)
							{
								if (1 == 0)
								{
									_ = 6;
								}
								continue;
							}
							goto case 7;
						case 3:
							_ = 1;
							obj = (object)Unsafe.AsPointer(ref this);
							if (8 != 0)
							{
								_ = 8;
							}
							continue;
						case 5:
							return;
						case 1:
							break;
						case 10:
							_ = 9;
							continue;
						case 7:
							obj = (object)(&obj);
							if (1 == 0)
							{
								_ = 10;
							}
							continue;
						case 9:
							obj = obj;
							obj = 2;
							continue;
						case 11:
							_ = ref obj;
							obj = 5;
							continue;
						case 6:
							obj = 0;
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 12:
							obj = -1;
							_ = 7;
							continue;
						case 4:
							_ = 12;
							continue;
						case 2:
							goto IL_0254;
						}
						break;
					}
					goto IL_0109;
					IL_0109:
					obj = (object)Unsafe.AsPointer(ref this);
					if (4 != 0)
					{
						_ = 4;
					}
					goto IL_0051;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_2200(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778766, new IntPtr(2737336616716L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_2300(object P_0)
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
		internal static byte _FF00_FF00_FF00_2400()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_2500()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778761, new IntPtr(2737336630236L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_2600()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778760, new IntPtr(2737336628156L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_2700()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_2800()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778763, new IntPtr(2737336630236L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAuthenticationUpdateAsync_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityAuthenticationOtp> _003C_003Et__builder;

		public string userId;

		public NeteaseDesktop _003C_003E4__this;

		public string userToken;

		private TaskAwaiter<RestResponse<Entity<EntityAuthenticationOtp>>> _003C_003Eu__1;

		private static object DecorateGroupedDictionary;

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
		internal static bool CheckAccessibleMonitor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateIsolatedSynchronizer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00ᘀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778762, new IntPtr(2737336618796L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00ᜀ()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_02ac: Expected Obj, but got Ref
			//IL_028e: Expected Obj, but got Ref
			//IL_018c: Expected Obj, but got Ref
			//IL_00de: Expected Obj, but got Ref
			//IL_014f: Expected Obj, but got Ref
			//IL_01cc: Expected Obj, but got I4
			//IL_01ae: Expected Obj, but got I4
			//IL_010a: Expected Obj, but got I4
			//IL_02a7->IL0019: Incompatible stack heights: 3 vs 1
			//IL_027f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_02b8->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0298->IL0019: Incompatible stack types: I4 vs Obj
			//IL_028a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004d->IL0051: Incompatible stack heights: 1 vs 2
			//IL_02c3->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0092->IL0183: Incompatible stack heights: 1 vs 0
			//IL_00ad->IL0051: Incompatible stack heights: 3 vs 2
			//IL_0140->IL0051: Incompatible stack heights: 1 vs 2
			//IL_00ea->IL0051: Incompatible stack heights: 1 vs 2
			//IL_016b->IL0051: Incompatible stack heights: 4 vs 2
			//IL_01d9->IL0051: Incompatible stack heights: 3 vs 2
			//IL_01c7->IL0051: Incompatible stack heights: 4 vs 2
			//IL_01b9->IL0051: Incompatible stack heights: 4 vs 2
			//IL_0183->IL0051: Incompatible stack heights: 3 vs 2
			//IL_0114->IL0051: Incompatible stack heights: 8 vs 2
			//IL_00b8->IL0051: Incompatible stack heights: 3 vs 2
			//IL_014b->IL0051: Incompatible stack heights: 1 vs 2
			//IL_00f5->IL0051: Incompatible stack heights: 1 vs 2
			//IL_00cc->IL0051: Incompatible stack heights: 1 vs 2
			//IL_0176->IL0051: Incompatible stack heights: 4 vs 2
			//IL_01e4->IL0051: Incompatible stack heights: 3 vs 2
			//IL_00d7->IL0051: Incompatible stack heights: 1 vs 2
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				case 2:
					if (obj == null)
					{
						_ = 12;
						goto IL_0051;
					}
					goto IL_0183;
				case 1:
					goto IL_026f;
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 3;
					break;
				default:
					_ = 5;
					break;
				case 5:
					return;
				case 3:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (2 == 0)
						{
							obj2 = 0;
						}
						break;
					}
					IL_0051:
					while (true)
					{
						switch (num)
						{
						default:
							if (true)
							{
								_ = 1;
							}
							continue;
						case 3:
							if (&obj == null)
							{
								if (0 == 0)
								{
									_ = 10;
								}
								continue;
							}
							goto case 2;
						case 2:
							obj = (object)(&obj);
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 13:
							_ = 1;
							obj = 0;
							_ = 3;
							continue;
						case 14:
							return;
						case 1:
							obj = obj;
							if (2 == 0)
							{
								_ = 7;
							}
							continue;
						case 4:
						case 12:
							obj = (object)Unsafe.AsPointer(ref this);
							num = 11;
							continue;
						case 6:
							_ = ref obj;
							if (5 == 0)
							{
								_ = 14;
							}
							continue;
						case 11:
							_ = 8;
							continue;
						case 5:
							break;
						case 10:
							obj = 0;
							_ = 9;
							continue;
						case 9:
							_ = 6;
							continue;
						case 8:
							obj = -1;
							if (2 == 0)
							{
								_ = 2;
							}
							continue;
						case 7:
							goto IL_026f;
						}
						break;
					}
					goto IL_0183;
					IL_026f:
					_ = -2;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
					IL_0183:
					/*Error near IL_0184: Stack underflow*/;
					obj = (object)Unsafe.AsPointer(ref this);
					num = 13;
					goto IL_0051;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_1800(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778869, new IntPtr(2737336617756L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00ᤀ(object P_0)
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
		internal static byte _FF00_FF00_FF00ᨀ()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_1B00()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00ᰀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778868, new IntPtr(2737336628156L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetRelatedLanGameRooms_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityLanGameRoom[]> _003C_003Et__builder;

		public NeteaseDesktop _003C_003E4__this;

		public int count;

		private TaskAwaiter<RestResponse<EntityRelatedLanGameRoomResponse>> _003C_003Eu__1;

		private static object SerializeDispatcher;

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
		internal static bool ReflectIterableSystem()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckIntegratedRole()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_0900()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778871, new IntPtr(2737336633356L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_0A00()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_023f: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_0048: Expected Obj, but got I4
			//IL_0109: Expected Obj, but got Ref
			//IL_0161: Expected Obj, but got I4
			//IL_00bd: Expected Obj, but got I4
			//IL_00c7: Expected Obj, but got I4
			//IL_0196: Expected Obj, but got Ref
			//IL_024b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_022f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0264->IL0019: Incompatible stack heights: 3 vs 1
			//IL_005f->IL0063: Incompatible stack heights: 1 vs 0
			//IL_0256->IL0019: Incompatible stack types: I4 vs Obj
			//IL_023a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0120->IL0063: Incompatible stack heights: 1 vs 0
			//IL_016e->IL0063: Incompatible stack heights: 2 vs 0
			//IL_015c->IL0063: Incompatible stack heights: 7 vs 0
			//IL_00a9->IL0063: Incompatible stack heights: 4 vs 0
			//IL_00fa->IL0063: Incompatible stack heights: 1 vs 0
			//IL_0130->IL0063: Incompatible stack heights: 2 vs 0
			//IL_018c->IL0192: Incompatible stack types: I4 vs Ref
			//IL_0179->IL0063: Incompatible stack heights: 2 vs 0
			//IL_0063->IL0063: Incompatible stack heights: 3 vs 0
			//IL_0105->IL0063: Incompatible stack heights: 1 vs 0
			//IL_013b->IL0063: Incompatible stack heights: 2 vs 0
			//IL_01a0->IL0063: Incompatible stack heights: 2 vs 0
			//IL_00eb->IL0063: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 3:
						goto end_IL_0019;
					default:
						if (obj != null)
						{
							_ = 3;
							goto IL_0063;
						}
						goto IL_0105;
					case 4:
						if (1 == 0)
						{
							_ = 1;
						}
						continue;
					case 1:
						return;
					case 2:
						obj = (object)Unsafe.AsPointer(ref this);
						if (false)
						{
							obj2 = 0;
						}
						continue;
					case 5:
						break;
						IL_0063:
						while (true)
						{
							switch ((int)/*Error near IL_0094: Stack underflow*/)
							{
							case 6:
								_ = ref obj;
								_ = 7;
								continue;
							case 7:
								return;
							case 4:
								obj = 0;
								obj = 10;
								continue;
							case 8:
								if (&obj == null)
								{
									if (4 == 0)
									{
										_ = 1;
									}
									continue;
								}
								goto default;
							case 9:
								if (1 == 0)
								{
									_ = 0;
								}
								continue;
							case 5:
								break;
							case 10:
								if (false)
								{
									_ = 6;
								}
								continue;
							case 3:
								_ = 1;
								_ = 3;
								_ = ref obj;
								obj = obj;
								_ = 8;
								continue;
							case 1:
								obj = -1;
								if (false)
								{
									_ = 0;
								}
								continue;
							default:
								obj = (object)Unsafe.AsPointer(ref 1 == 0 ? ref *(byte*)(&obj) : ref *(byte*)1);
								_ = 2;
								continue;
							case 2:
								goto end_IL_0019_2;
							}
							break;
						}
						goto IL_0105;
						IL_0105:
						obj = (object)Unsafe.AsPointer(ref this);
						if (9 != 0)
						{
							_ = 1;
						}
						goto IL_0063;
						end_IL_0019_2:
						break;
					}
					_ = -2;
					_ = 4;
					continue;
					end_IL_0019:
					break;
				}
				obj = (object)Unsafe.AsPointer(ref this);
				obj = 2;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_0B00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778870, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_0C00(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_0D00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778865, new IntPtr(2737336634396L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_0E00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778864, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00ༀ()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00က()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778867, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00ᄀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778866, new IntPtr(2737336635436L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00ሀ()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetSingleLanGameRoom_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityLanGameRoom> _003C_003Et__builder;

		public NeteaseDesktop _003C_003E4__this;

		public uint hostId;

		public uint roomId;

		private TaskAwaiter<RestResponse<EntitySingleLanGameRoomResponse>> _003C_003Eu__1;

		internal static object DecorateLocalCollection;

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
		internal static bool CloneHandler()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectConfigurableChooser()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00ﴀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778877, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FE00()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0040: Expected Obj, but got Ref
			//IL_006a: Expected Obj, but got Ref
			//IL_01f7: Expected Obj, but got Ref
			//IL_018b: Expected Obj, but got I4
			//IL_0102: Expected Obj, but got I4
			//IL_0143: Expected Obj, but got Ref
			//IL_01a5: Expected Obj, but got I4
			//IL_0091->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004a->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0076->IL0019: Incompatible stack heights: 0 vs 1
			//IL_005b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_009c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0081->IL0019: Incompatible stack types: I4 vs Obj
			//IL_00b0->IL00bf: Incompatible stack heights: 0 vs 9
			//IL_0066->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00f8->IL011a: Incompatible stack heights: 8 vs 0
			//IL_00bb->IL00bf: Incompatible stack heights: 1 vs 9
			//IL_0167->IL00bf: Incompatible stack heights: 10 vs 9
			//IL_0203->IL00bf: Incompatible stack heights: 13 vs 9
			//IL_0196->IL00bf: Incompatible stack heights: 11 vs 9
			//IL_010f->IL00bf: Incompatible stack heights: 10 vs 9
			//IL_01b8->IL00bf: Incompatible stack heights: 11 vs 9
			//IL_014f->IL00bf: Incompatible stack heights: 8 vs 9
			//IL_020e->IL00bf: Incompatible stack heights: 13 vs 9
			//IL_017b->IL00bf: Incompatible stack heights: 8 vs 9
			//IL_011a->IL00bf: Incompatible stack heights: 10 vs 9
			//IL_015a->IL00bf: Incompatible stack heights: 8 vs 9
			//IL_00bf->IL00bf: Incompatible stack heights: 12 vs 9
			//IL_0186->IL00bf: Incompatible stack heights: 8 vs 9
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
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
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 4;
					continue;
				case 5:
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 1:
					break;
				case 4:
					{
						if (obj == null)
						{
							if (9 == 0)
							{
								_ = 2;
							}
							goto IL_00bf;
						}
						goto IL_011a;
					}
					IL_011a:
					_ = 1;
					_ = 3;
					_ = ref obj;
					obj = obj;
					goto IL_00bf;
					IL_00bf:
					while (true)
					{
						switch (3)
						{
						case 8:
							return;
						case 12:
							break;
						case 6:
							obj = -1;
							if (2 != 0)
							{
								_ = 2;
							}
							continue;
						case 5:
							goto end_IL_00bf;
						case 9:
						case 10:
							obj = (object)Unsafe.AsPointer(ref this);
							if (1 == 0)
							{
								_ = 1;
							}
							continue;
						case 1:
							_ = 6;
							continue;
						case 3:
							if (&obj != null)
							{
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							}
							goto case 4;
						case 4:
							obj = 0;
							_ = 7;
							continue;
						case 11:
							_ = ref obj;
							obj = 8;
							continue;
						case 7:
							_ = 11;
							continue;
						default:
							_ = ref obj;
							_ = 1;
							obj = (object)Unsafe.AsPointer(ref this);
							if (8 == 0)
							{
								_ = 12;
							}
							continue;
						}
						goto end_IL_0019;
						continue;
						end_IL_00bf:
						break;
					}
					goto IL_011a;
					end_IL_0019:
					break;
				}
				_ = -2;
				if (3 == 0)
				{
					_ = 5;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778876, new IntPtr(2737336621916L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00Ā(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00Ȁ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778879, new IntPtr(2737336628156L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_0300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778878, new IntPtr(2737336635436L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00Ѐ()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00Ԁ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778873, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_0600()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_0700()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778872, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInitAsync_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NeteaseDesktop _003C_003E4__this;

		private object _003Cclient_003E5__2;

		private TaskAwaiter<string> _003C_003Eu__1;

		private TaskAwaiter<EntityAuthServer[]?> _003C_003Eu__2;

		private TaskAwaiter<EntityTransferServer[]?> _003C_003Eu__3;

		internal static object ReflectSeparatedSolver;

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
		internal static bool ReflectMonoTester()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectOrderedTracer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_F500()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778875, new IntPtr(2737336635436L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_F600()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_0079: Expected Obj, but got Ref
			//IL_0051: Expected Obj, but got Ref
			//IL_014a: Expected I4, but got Obj
			//IL_0333: Expected Obj, but got Ref
			//IL_0213: Expected Obj, but got Ref
			//IL_0325: Expected Obj, but got Ref
			//IL_025c: Expected Obj, but got Ref
			//IL_0285: Expected Obj, but got I4
			//IL_02a5: Expected Obj, but got I4
			//IL_02af: Expected Obj, but got I4
			//IL_03a8: Expected Obj, but got Ref
			//IL_02b9: Expected Obj, but got I4
			//IL_023d: Expected Obj, but got I4
			//IL_0342: Expected Obj, but got Ref
			//IL_0316: Expected Obj, but got I4
			//IL_0374: Expected Obj, but got I4
			//IL_0441: Expected Obj, but got Ref
			//IL_0437: Expected Obj, but got I4
			//IL_04f2: Expected Obj, but got I4
			//IL_0085->IL0019: Incompatible stack heights: 0 vs 1
			//IL_005d->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0075->IL0019: Incompatible stack heights: 2 vs 1
			//IL_009f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004d->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0090->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0068->IL0019: Incompatible stack types: I4 vs Obj
			//IL_00bf->IL00ce: Incompatible stack heights: 0 vs 1
			//IL_00aa->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0136->IL00ce: Incompatible stack types: I4 vs Ref
			//IL_00ca->IL00ce: Incompatible stack types: I4 vs Ref
			//IL_0111->IL00ce: Incompatible stack heights: 0 vs 1
			//IL_011c->IL00ce: Incompatible stack types: I4 vs Ref
			//IL_033d->IL0165: Incompatible stack types: I4 vs Ref
			//IL_021d->IL0165: Incompatible stack types: I4 vs Ref
			//IL_032f->IL0165: Incompatible stack types: I4 vs Ref
			//IL_0156->IL0165: Incompatible stack heights: 0 vs 1
			//IL_0161->IL0165: Incompatible stack types: I4 vs Ref
			//IL_035c->IL0165: Incompatible stack heights: 4 vs 1
			//IL_03c0->IL0165: Incompatible stack heights: 3 vs 1
			//IL_02e3->IL0165: Incompatible stack heights: 3 vs 1
			//IL_03a3->IL0165: Incompatible stack heights: 3 vs 1
			//IL_0496->IL0165: Incompatible stack heights: 3 vs 1
			//IL_0266->IL0165: Incompatible stack types: I4 vs Ref
			//IL_0426->IL0165: Incompatible stack heights: 2 vs 1
			//IL_0290->IL0165: Incompatible stack heights: 3 vs 1
			//IL_02b4->IL0161: Incompatible stack types: I4 vs Obj
			//IL_03b2->IL0165: Incompatible stack types: I4 vs Ref
			//IL_022a->IL0165: Incompatible stack heights: 2 vs 1
			//IL_02c6->IL0165: Incompatible stack heights: 2 vs 1
			//IL_0311->IL0165: Incompatible stack heights: 4 vs 1
			//IL_024a->IL0165: Incompatible stack heights: 2 vs 1
			//IL_034c->IL0165: Incompatible stack types: I4 vs Ref
			//IL_0394->IL0165: Incompatible stack heights: 2 vs 1
			//IL_02a0->IL0165: Incompatible stack heights: 3 vs 1
			//IL_0480->IL0165: Incompatible stack heights: 3 vs 1
			//IL_0321->IL0165: Incompatible stack heights: 3 vs 1
			//IL_037f->IL0165: Incompatible stack heights: 3 vs 1
			//IL_0419->IL0165: Incompatible stack heights: 3 vs 1
			//IL_0238->IL0165: Incompatible stack heights: 3 vs 1
			//IL_044d->IL0165: Incompatible stack heights: 0 vs 1
			//IL_03d0->IL0165: Incompatible stack heights: 2 vs 1
			//IL_043c->IL0161: Incompatible stack heights: 0 vs 2
			//IL_02ee->IL0165: Incompatible stack heights: 3 vs 1
			//IL_04d5->IL0165: Incompatible stack types: I4 vs Ref
			//IL_036f->IL0165: Incompatible stack types: I4 vs Ref
			//IL_0165->IL0165: Incompatible stack heights: 3 vs 1
			//IL_02d1->IL0165: Incompatible stack heights: 2 vs 1
			//IL_046a->IL0165: Incompatible stack types: I4 vs Ref
			//IL_0255->IL0165: Incompatible stack heights: 2 vs 1
			//IL_0280->IL0165: Incompatible stack types: I4 vs Ref
			//IL_0458->IL0165: Incompatible stack types: I4 vs Ref
			//IL_04c4->IL0165: Incompatible stack types: I4 vs Ref
			//IL_03db->IL0165: Incompatible stack heights: 2 vs 1
			//IL_04f7->IL0161: Incompatible stack types: Obj vs Ref
			//IL_0515->IL0165: Incompatible stack heights: 3 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			object obj2 = obj;
			while (true)
			{
				ref _003CInitAsync_003Ed__14 reference;
				ref _003CInitAsync_003Ed__14 reference2;
				switch ((int)obj2)
				{
				case 6:
					_ = -2;
					_ = 5;
					break;
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
				default:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 3;
					}
					break;
				case 5:
					_ = null;
					if (2 == 0)
					{
						_ = 2;
					}
					break;
				case 3:
					if ((nuint)(nint)obj <= (nuint)2u)
					{
						if (3 == 0)
						{
							reference = ref *(_003CInitAsync_003Ed__14*)2;
						}
						goto IL_00ce;
					}
					goto IL_011c;
				case 4:
					return;
					IL_011c:
					reference = ref this;
					if (0 == 0)
					{
						reference = ref *(_003CInitAsync_003Ed__14*)null;
					}
					goto IL_00ce;
					IL_00ce:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						default:
							if (true)
							{
								reference = ref *(_003CInitAsync_003Ed__14*)1;
							}
							continue;
						case 2u:
							break;
						case 1u:
							goto IL_0136;
						}
						break;
					}
					goto IL_011c;
					IL_0136:
					switch ((int)obj)
					{
					default:
						if (9 == 0)
						{
							reference2 = ref *(_003CInitAsync_003Ed__14*)2;
						}
						goto IL_0165;
					case 1:
						obj = (object)Unsafe.AsPointer(ref this);
						reference2 = ref *(_003CInitAsync_003Ed__14*)17;
						goto IL_0165;
					case 2:
						goto IL_0321;
					case 0:
						goto IL_032f;
						IL_0165:
						while (true)
						{
							scoped ref _003CInitAsync_003Ed__14 reference3;
							object obj3;
							switch ((uint)Unsafe.AsPointer(ref reference2))
							{
							case 25u:
								break;
							case 36u:
								goto end_IL_0165;
							case 17u:
								_ = 15;
								continue;
							case 34u:
								_ = 21;
								continue;
							case 22u:
								obj = 2;
								if (7 == 0)
								{
									_ = 39;
								}
								continue;
							case 9u:
								obj = (object)Unsafe.AsPointer(ref this);
								reference2 = ref *(_003CInitAsync_003Ed__14*)37;
								continue;
							case 31u:
								reference2 = ref this;
								if (18 == 0)
								{
									reference2 = ref *(_003CInitAsync_003Ed__14*)7;
								}
								continue;
							case 14u:
								obj = 1;
								_ = 34;
								continue;
							case 28u:
								_ = 6;
								continue;
							case 15u:
								reference3 = ref this;
								obj = -1;
								obj = 35;
								obj3 = -1;
								continue;
							case 18u:
								obj = -1;
								if (2 != 0)
								{
									_ = 16;
								}
								continue;
							case 4u:
								_ = ref obj;
								if (true)
								{
									_ = 1;
								}
								continue;
							case 38u:
								return;
							case 21u:
								_ = ref obj;
								_ = 38;
								continue;
							case 30u:
								obj = 0;
								_ = 3;
								continue;
							case 5u:
								goto IL_0321;
							case 24u:
								goto IL_032f;
							case 23u:
								obj = (object)(&obj);
								reference2 = ref *(_003CInitAsync_003Ed__14*)33;
								continue;
							default:
								_ = ref obj;
								_ = 20;
								continue;
							case 11u:
								goto IL_035c;
							case 32u:
								obj = -1;
								_ = 23;
								continue;
							case 27u:
								_ = 29;
								continue;
							case 6u:
								_ = 27;
								continue;
							case 16u:
							case 26u:
								obj = (object)(&obj);
								reference2 = ref *(_003CInitAsync_003Ed__14*)10;
								continue;
							case 3u:
								_ = 4;
								continue;
							case 39u:
								if (false)
								{
									_ = 0;
								}
								continue;
							case 20u:
								return;
							case 1u:
								return;
							case 33u:
								((short[])2)[0] = 44;
								((short[])2)[1] = 10;
								obj = null;
								_ = 11;
								continue;
							case 13u:
								_ = 32;
								continue;
							case 2u:
								if (&obj != null)
								{
									obj = 26;
									continue;
								}
								goto case 22u;
							case 35u:
								obj = (object)(&obj);
								if (4 == 0)
								{
									reference2 = ref *(_003CInitAsync_003Ed__14*)7;
								}
								continue;
							case 19u:
								if (&obj == null)
								{
									reference2 = ref *(_003CInitAsync_003Ed__14*)14;
									continue;
								}
								goto case 35u;
							case 29u:
								_ = ref obj;
								obj = obj;
								_ = 19;
								continue;
							case 8u:
								_ = ref obj;
								obj = obj;
								_ = 2;
								continue;
							case 37u:
								if (&obj == null)
								{
									reference2 = ref *(_003CInitAsync_003Ed__14*)30;
									continue;
								}
								goto case 23u;
							case 12u:
								throw /*Error near IL_04c7: Stack underflow*/;
							case 7u:
								goto IL_04d5;
							case 10u:
								goto IL_04f7;
							}
							goto end_IL_0139;
							IL_04f7:
							object obj4 = obj;
							if (obj == null)
							{
								throw obj4;
							}
							_ = 25;
							continue;
							IL_04d5:
							object obj5 = obj;
							obj3 = obj ?? throw obj5;
							obj = 8;
							reference3 = ref *(_003CInitAsync_003Ed__14*)obj5;
							continue;
							IL_035c:
							object obj6 = obj;
							if (obj6 == null)
							{
								reference2 = ref *(_003CInitAsync_003Ed__14*)12;
								continue;
							}
							obj = obj6;
							reference2 = ref *(_003CInitAsync_003Ed__14*)28;
							continue;
							end_IL_0165:
							break;
						}
						goto case 1;
						IL_032f:
						obj = (object)Unsafe.AsPointer(ref this);
						reference2 = ref *(_003CInitAsync_003Ed__14*)13;
						goto IL_0165;
						IL_0321:
						obj = (object)Unsafe.AsPointer(ref this);
						reference2 = ref *(_003CInitAsync_003Ed__14*)31;
						goto IL_0165;
						end_IL_0139:
						break;
					}
					goto case 6;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_F700(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778874, new IntPtr(2737336617756L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_F800(object P_0)
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
		internal static byte _FF00_FF00豈()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00切()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00ﬀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778853, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoginAsync_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<DesktopSession> _003C_003Et__builder;

		public string cookies;

		public NeteaseDesktop _003C_003E4__this;

		private TaskAwaiter<DesktopSession> _003C_003Eu__1;

		private static object CompressParameter;

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
		internal static bool ReflectScopeDecryptor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateStaticError()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_E300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778852, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_E400()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_031a: Expected Obj, but got Ref
			//IL_0335: Expected Obj, but got Ref
			//IL_013d: Expected Obj, but got Ref
			//IL_0188: Expected Obj, but got I4
			//IL_00f7: Expected Obj, but got I4
			//IL_0159: Expected Obj, but got I4
			//IL_00cf: Expected Obj, but got I4
			//IL_009d: Expected Obj, but got Ref
			//IL_00a6: Expected Obj, but got I4
			//IL_0326->IL0019: Incompatible stack heights: 0 vs 1
			//IL_033f->IL0019: Incompatible stack types: I4 vs Obj
			//IL_030b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_02f0->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004e->IL0052: Incompatible stack heights: 1 vs 0
			//IL_0331->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0316->IL0019: Incompatible stack heights: 2 vs 1
			//IL_02fb->IL0019: Incompatible stack heights: 2 vs 1
			//IL_017c->IL0052: Incompatible stack heights: 1 vs 0
			//IL_00e8->IL0052: Incompatible stack heights: 3 vs 0
			//IL_0139->IL0052: Incompatible stack heights: 2 vs 0
			//IL_00fc->IL004e: Incompatible stack heights: 3 vs 1
			//IL_0164->IL0052: Incompatible stack heights: 3 vs 0
			//IL_00da->IL0052: Incompatible stack heights: 3 vs 0
			//IL_00ab->IL004e: Incompatible stack heights: 0 vs 1
			//IL_0154->IL0052: Incompatible stack heights: 1 vs 0
			//IL_0052->IL0052: Incompatible stack heights: 2 vs 0
			//IL_01c7->IL01cb: Incompatible stack types: I4 vs Ref
			//IL_00ca->IL0052: Incompatible stack heights: 1 vs 0
			//IL_0207->IL01cb: Incompatible stack heights: 0 vs 1
			//IL_0212->IL01cb: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
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
					if (obj == null)
					{
						_ = 10;
						goto IL_0052;
					}
					goto IL_0164;
				case 5:
					if (false)
					{
						_ = 0;
					}
					break;
				case 4:
					goto IL_02fb;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 1;
					}
					break;
				case 3:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 2;
						break;
					}
					IL_0164:
					if (14 == 0)
					{
						_ = 14;
					}
					goto IL_0052;
					IL_02fb:
					_ = -2;
					if (5 == 0)
					{
						_ = 4;
					}
					break;
					IL_0052:
					while (true)
					{
						switch ((int)/*Error near IL_0093: Stack underflow*/)
						{
						case 12:
							return;
						case 5:
						case 13:
							obj = (object)(&obj);
							obj = 8;
							continue;
						case 9:
							if (&obj != null)
							{
								if (5 != 0)
								{
									_ = 3;
								}
								continue;
							}
							goto case 11;
						case 11:
							obj = 0;
							_ = 3;
							continue;
						case 3:
							_ = 6;
							continue;
						case 6:
							_ = ref obj;
							obj = 12;
							continue;
						case 4:
							obj = obj;
							_ = 9;
							continue;
						default:
							obj = (object)Unsafe.AsPointer(ref this);
							if (0 == 0)
							{
								_ = 1;
							}
							continue;
						case 7:
							obj = -1;
							_ = 13;
							continue;
						case 2:
							break;
						case 1:
							obj = 7;
							continue;
						case 14:
						{
							ref _003CLoginAsync_003Ed__15 reference = ref this;
							obj = null;
							if (false)
							{
								reference = ref *(_003CLoginAsync_003Ed__15*)null;
							}
							while (true)
							{
								switch ((uint)Unsafe.AsPointer(ref reference))
								{
								case 1u:
									break;
								default:
									if (obj != null)
									{
										if (1 == 0)
										{
											reference = ref *(_003CLoginAsync_003Ed__15*)null;
										}
										continue;
									}
									goto case 2u;
								case 2u:
									throw /*Error near IL_0215: Stack underflow*/;
								}
								break;
							}
							goto case 4;
						}
						case 8:
							goto IL_02fb;
						}
						break;
					}
					goto IL_0164;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_E500()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778855, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_E600(object P_0)
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
		private unsafe sealed void _FF00_FF00_E700(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778854, new IntPtr(2737336621916L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_E800()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778849, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_E900()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_EA00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778848, new IntPtr(2737336620876L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_EB00()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoginAsync_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<DesktopSession> _003C_003Et__builder;

		public EntityLoginOtpDto dto;

		public NeteaseDesktop _003C_003E4__this;

		private object _003CsAuth_003E5__2;

		private object _003CmgbSdk_003E5__3;

		private object _003Csession_003E5__4;

		private TaskAwaiter<EntityMgbSdk> _003C_003Eu__1;

		private TaskAwaiter<EntityLoginOtp> _003C_003Eu__2;

		private TaskAwaiter<EntityAuthenticationOtp> _003C_003Eu__3;

		private TaskAwaiter _003C_003Eu__4;

		internal static object ConvertFactory;

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
		internal static bool RateCompressor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QueryResponder()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778851, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FFFD()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0042: Expected I4, but got Obj
			//IL_0059: Expected Obj, but got Ref
			//IL_0078: Expected Obj, but got Ref
			//IL_00b6: Expected I4, but got Obj
			//IL_006f: Expected Obj, but got I4
			//IL_0580: Expected Obj, but got Ref
			//IL_030a: Expected Obj, but got Ref
			//IL_05c9: Expected Obj, but got Ref
			//IL_05e8: Expected Obj, but got Ref
			//IL_0555: Expected Obj, but got I4
			//IL_05bb: Expected Obj, but got Ref
			//IL_03e1: Expected Obj, but got I4
			//IL_0468: Expected Obj, but got I4
			//IL_03a0: Expected Obj, but got I4
			//IL_03aa: Expected Obj, but got I4
			//IL_01db: Expected Obj, but got I4
			//IL_05da: Expected Obj, but got Ref
			//IL_03d2: Expected Obj, but got Ref
			//IL_0400: Expected Obj, but got I4
			//IL_043a: Expected Obj, but got Ref
			//IL_05f6: Expected Obj, but got Ref
			//IL_0241: Expected Obj, but got Ref
			//IL_0485: Expected Obj, but got I4
			//IL_048f: Expected Obj, but got I4
			//IL_04c1: Expected Obj, but got I4
			//IL_02cf: Expected Obj, but got Ref
			//IL_0499: Expected Obj, but got I4
			//IL_0458: Expected Obj, but got I4
			//IL_03f1: Expected Obj, but got Ref
			//IL_0538: Expected Obj, but got I8
			//IL_026a: Expected Obj, but got I4
			//IL_0093->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0055->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0714->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0063->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0082->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0723->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0074->IL0015: Incompatible stack heights: 2 vs 0
			//IL_009e->IL0019: Incompatible stack heights: 2 vs 1
			//IL_058a->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_0316->IL00d1: Incompatible stack heights: 0 vs 1
			//IL_05d3->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_05f2->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_00c2->IL00d1: Incompatible stack heights: 0 vs 1
			//IL_072e->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0321->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_00cd->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_0560->IL00d1: Incompatible stack heights: 3 vs 1
			//IL_0432->IL00d1: Incompatible stack heights: 2 vs 1
			//IL_04d3->IL00d1: Incompatible stack heights: 2 vs 1
			//IL_05c5->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_03ec->IL00d1: Incompatible stack heights: 3 vs 1
			//IL_0475->IL00d1: Incompatible stack heights: 2 vs 1
			//IL_0550->IL00d1: Incompatible stack heights: 3 vs 1
			//IL_03af->IL00cd: Incompatible stack types: I4 vs Obj
			//IL_05e4->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_0201->IL00d1: Incompatible stack heights: 4 vs 1
			//IL_03dc->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_0363->IL00d1: Incompatible stack heights: 3 vs 1
			//IL_01ed->IL00d1: Incompatible stack heights: 2 vs 1
			//IL_029c->IL00d1: Incompatible stack heights: 4 vs 1
			//IL_0259->IL00d1: Incompatible stack heights: 3 vs 1
			//IL_027e->IL00d1: Incompatible stack heights: 3 vs 1
			//IL_040b->IL00d1: Incompatible stack heights: 3 vs 1
			//IL_0444->IL00d1: Incompatible stack heights: 2 vs 1
			//IL_0602->IL00d1: Incompatible stack heights: 0 vs 1
			//IL_028c->IL00d1: Incompatible stack heights: 3 vs 1
			//IL_04b2->IL00d1: Incompatible stack heights: 3 vs 1
			//IL_024b->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_0494->IL00cd: Incompatible stack types: I4 vs Obj
			//IL_02d9->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_04ff->IL00d1: Incompatible stack heights: 4 vs 1
			//IL_04a4->IL00d1: Incompatible stack heights: 3 vs 1
			//IL_037f->IL00d1: Incompatible stack heights: 3 vs 1
			//IL_0463->IL00d1: Incompatible stack heights: 3 vs 1
			//IL_03fb->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_032d->IL0432: Incompatible stack heights: 1 vs 0
			//IL_0542->IL00d1: Incompatible stack heights: 19 vs 1
			//IL_0351->IL00d1: Incompatible stack heights: 2 vs 1
			//IL_05b5->IL00d1: Incompatible stack heights: 3 vs 1
			//IL_059c->IL00d1: Incompatible stack heights: 3 vs 1
			//IL_0630->IL00d1: Incompatible stack heights: 3 vs 1
			//IL_0623->IL0623: Incompatible stack heights: 5 vs 3
			//IL_02fb->IL00d1: Incompatible stack heights: 0 vs 1
			//IL_0480->IL00d1: Incompatible stack heights: 2 vs 1
			//IL_00d1->IL00d1: Incompatible stack heights: 3 vs 1
			//IL_02bf->IL00d1: Incompatible stack heights: 0 vs 1
			//IL_036e->IL00d1: Incompatible stack heights: 3 vs 1
			//IL_060d->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_03c3->IL00d1: Incompatible stack heights: 0 vs 1
			//IL_0425->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_0231->IL00d1: Incompatible stack heights: 0 vs 1
			//IL_026f->IL00cd: Incompatible stack heights: 0 vs 2
			//IL_05a7->IL00d1: Incompatible stack heights: 3 vs 1
			//IL_063b->IL00d1: Incompatible stack heights: 3 vs 1
			//IL_0306->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_02ca->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_03ce->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_023c->IL00d1: Incompatible stack types: I4 vs Ref
			//IL_0344->IL00d1: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 1:
						_ = -2;
						_ = 7;
						continue;
					case 3:
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 5;
						continue;
					case 7:
						break;
					case 4:
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 3;
						continue;
					default:
						if (8 == 0)
						{
							_ = 4;
						}
						continue;
					case 5:
					{
						ref _003CLoginAsync_003Ed__16 reference;
						switch ((int)obj)
						{
						default:
							if (25 == 0)
							{
								reference = ref *(_003CLoginAsync_003Ed__16*)2;
							}
							goto IL_00d1;
						case 1:
							obj = (object)Unsafe.AsPointer(ref this);
							if (40 == 0)
							{
								reference = ref *(_003CLoginAsync_003Ed__16*)53;
							}
							goto IL_00d1;
						case 0:
							goto IL_057c;
						case 2:
							goto IL_05c5;
						case 3:
							goto IL_05e4;
							IL_00d1:
							while (true)
							{
								scoped ref _003CLoginAsync_003Ed__16 reference2;
								object obj3;
								switch ((uint)Unsafe.AsPointer(ref reference))
								{
								case 23u:
								case 36u:
									break;
								case 12u:
									reference2 = ref this;
									obj3 = obj;
									obj = 2;
									continue;
								case 21u:
									_ = 10;
									continue;
								case 15u:
									obj = obj;
									_ = 6;
									continue;
								case 30u:
									return;
								case 45u:
									if (&obj == null)
									{
										if (37 != 0)
										{
											reference = ref *(_003CLoginAsync_003Ed__16*)10;
										}
										continue;
									}
									goto case 1u;
								case 16u:
								case 35u:
									obj = (object)(&obj);
									reference = ref *(_003CLoginAsync_003Ed__16*)34;
									continue;
								case 24u:
									_ = 19;
									continue;
								case 52u:
									if (&obj != null)
									{
										obj = 51;
										continue;
									}
									goto default;
								case 25u:
									_ = 14;
									continue;
								case 32u:
									_ = 22;
									continue;
								case 22u:
									_ = ref obj;
									_ = 27;
									continue;
								case 11u:
									if (&obj != null)
									{
										if (16 == 0)
										{
											reference = ref *(_003CLoginAsync_003Ed__16*)10;
										}
										continue;
									}
									goto case 46u;
								case 41u:
								case 51u:
									obj = (object)(&obj);
									reference = ref *(_003CLoginAsync_003Ed__16*)50;
									continue;
								case 6u:
									if (obj != null)
									{
										if (17 == 0)
										{
											reference = ref *(_003CLoginAsync_003Ed__16*)12;
										}
										continue;
									}
									goto case 29u;
								case 28u:
									goto end_IL_00d1;
								case 48u:
									reference = ref this;
									if (&obj != null)
									{
										if (15 != 0)
										{
											reference = ref *(_003CLoginAsync_003Ed__16*)15;
										}
										continue;
									}
									goto case 29u;
								case 53u:
									_ = 7;
									continue;
								case 19u:
									_ = ref obj;
									if (30 == 0)
									{
										_ = 6;
									}
									continue;
								case 44u:
									_ = 4;
									continue;
								case 20u:
									return;
								case 10u:
									reference2 = ref this;
									obj = -1;
									obj = 47;
									obj3 = -1;
									continue;
								case 33u:
									if (&obj != null)
									{
										if (10 != 0)
										{
											reference = ref *(_003CLoginAsync_003Ed__16*)13;
										}
										continue;
									}
									goto case 26u;
								case 17u:
									obj = (object)Unsafe.AsPointer(ref this);
									reference = ref *(_003CLoginAsync_003Ed__16*)23;
									continue;
								case 7u:
									obj = -1;
									_ = 41;
									continue;
								case 13u:
								case 47u:
									obj = (object)(&obj);
									reference = ref *(_003CLoginAsync_003Ed__16*)12;
									continue;
								case 26u:
									obj = 2;
									_ = 9;
									continue;
								case 39u:
									reference = ref this;
									if (5 == 0)
									{
										reference = ref *(_003CLoginAsync_003Ed__16*)8;
									}
									continue;
								case 1u:
									_ = ref obj;
									_ = 31;
									continue;
								case 29u:
									obj = (object)Unsafe.AsPointer(ref this);
									_ = 52;
									continue;
								case 27u:
									return;
								case 46u:
									obj = 0;
									_ = 24;
									continue;
								case 8u:
									obj = -1;
									if (1 == 0)
									{
										_ = 1;
									}
									continue;
								case 37u:
									reference2 = ref this;
									obj = 3;
									obj = 54;
									obj3 = 3;
									continue;
								case 43u:
									obj = -1;
									_ = 35;
									continue;
								case 34u:
									_ = 48;
									continue;
								case 40u:
									reference2 = ref this;
									obj3 = obj;
									obj = 44;
									continue;
								case 3u:
									_ = 43;
									continue;
								case 18u:
									return;
								case 42u:
									_ = ref obj;
									_ = 18;
									continue;
								case 50u:
									obj = obj;
									_ = ref obj;
									obj = 0;
									_ = 33;
									continue;
								case 9u:
									_ = 55;
									continue;
								default:
									obj = 1;
									_ = 32;
									continue;
								case 38u:
									goto IL_057c;
								case 55u:
									_ = ref obj;
									if (20 == 0)
									{
										_ = 7;
									}
									continue;
								case 54u:
									_ = 42;
									continue;
								case 4u:
									obj = (object)Unsafe.AsPointer(ref this);
									reference = ref *(_003CLoginAsync_003Ed__16*)45;
									continue;
								case 5u:
									goto IL_05c5;
								case 14u:
									obj = (object)Unsafe.AsPointer(ref this);
									reference = ref *(_003CLoginAsync_003Ed__16*)11;
									continue;
								case 49u:
									goto IL_05e4;
								case 31u:
									obj = (object)Unsafe.AsPointer(ref this);
									if (36 == 0)
									{
										reference = ref *(_003CLoginAsync_003Ed__16*)27;
									}
									continue;
								case 2u:
									if (obj == null)
									{
										_ = 1;
									}
									if (4 == 0)
									{
										_ = 40;
									}
									continue;
								}
								goto end_IL_00a1;
								continue;
								end_IL_00d1:
								break;
							}
							goto case 1;
							IL_05e4:
							obj = (object)Unsafe.AsPointer(ref this);
							reference = ref *(_003CLoginAsync_003Ed__16*)39;
							goto IL_00d1;
							IL_05c5:
							obj = (object)Unsafe.AsPointer(ref this);
							reference = ref *(_003CLoginAsync_003Ed__16*)21;
							goto IL_00d1;
							IL_057c:
							obj = (object)Unsafe.AsPointer(ref this);
							reference = ref *(_003CLoginAsync_003Ed__16*)3;
							goto IL_00d1;
							end_IL_00a1:
							break;
						}
						goto case 1;
					}
					case 8:
						return;
					case 2:
						_ = null;
						_ = 6;
						continue;
					case 6:
						_ = null;
						if (0 == 0)
						{
							_ = 0;
						}
						continue;
					}
					break;
				}
				_ = null;
				obj = 2;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FFFD(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778850, new IntPtr(2737336636476L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FFFD(object P_0)
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
		internal static byte _FF00_FF00_FFFD()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778861, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FFFD()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_E000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778860, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoginOtpAsync_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityLoginOtp> _003C_003Et__builder;

		public NeteaseDesktop _003C_003E4__this;

		public EntityLoginOtpDto dto;

		private TaskAwaiter<RestResponse<Entity<EntityLoginOtp>>> _003C_003Eu__1;

		private static object DecorateAlphabeticPublisher;

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
		internal static bool FillEncryptor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SelectController()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00툀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778863, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00팀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0234: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_00ff: Expected Obj, but got Ref
			//IL_0197: Expected Obj, but got I4
			//IL_0143: Expected Obj, but got I4
			//IL_014d: Expected Obj, but got I4
			//IL_018d: Expected Obj, but got I4
			//IL_00a4: Expected Obj, but got Ref
			//IL_024e->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0230->IL0019: Incompatible stack heights: 3 vs 1
			//IL_023e->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0259->IL0019: Incompatible stack heights: 2 vs 1
			//IL_005b->IL005f: Incompatible stack heights: 1 vs 0
			//IL_0116->IL005f: Incompatible stack heights: 1 vs 0
			//IL_013e->IL005f: Incompatible stack heights: 2 vs 0
			//IL_01a2->IL005f: Incompatible stack heights: 3 vs 0
			//IL_0192->IL005b: Incompatible stack heights: 5 vs 2
			//IL_00ed->IL005f: Incompatible stack heights: 3 vs 0
			//IL_00cf->IL005f: Incompatible stack heights: 3 vs 0
			//IL_00ae->IL005f: Incompatible stack heights: 1 vs 0
			//IL_00fb->IL005f: Incompatible stack heights: 3 vs 0
			//IL_0131->IL005f: Incompatible stack heights: 1 vs 0
			//IL_005f->IL005f: Incompatible stack heights: 3 vs 0
			//IL_00da->IL005f: Incompatible stack heights: 3 vs 0
			//IL_0171->IL005f: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 3;
					continue;
				case 2:
					if (obj != null)
					{
						_ = 5;
						goto IL_005f;
					}
					goto IL_00fb;
				case 5:
					return;
				case 1:
					_ = 5;
					continue;
				case 3:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 2;
						continue;
					}
					IL_005f:
					while (true)
					{
						switch ((int)/*Error near IL_0098: Stack underflow*/)
						{
						default:
							return;
						case 11:
							obj = (object)(&obj);
							_ = 6;
							continue;
						case 0:
							return;
						case 9:
							_ = ref obj;
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 6:
							_ = 3;
							continue;
						case 12:
							_ = 9;
							continue;
						case 10:
							break;
						case 3:
							obj = obj;
							if (4 == 0)
							{
								_ = 8;
							}
							continue;
						case 1:
							_ = 2;
							continue;
						case 4:
							obj = 0;
							obj = 12;
							continue;
						case 7:
							if (&obj == null)
							{
								if (4 != 0)
								{
									_ = 3;
								}
								continue;
							}
							goto case 11;
						case 5:
							_ = 1;
							_ = null;
							_ = ref obj;
							obj = obj;
							obj = 7;
							continue;
						case 2:
							obj = -1;
							_ = 11;
							continue;
						case 8:
							goto end_IL_0019;
						}
						break;
					}
					goto IL_00fb;
					IL_00fb:
					obj = (object)Unsafe.AsPointer(ref this);
					if (true)
					{
						_ = 1;
					}
					goto IL_005f;
					end_IL_0019:
					break;
				}
				_ = -2;
				if (1 == 0)
				{
					_ = 0;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00퐀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778862, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00픀(object P_0)
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
		internal unsafe static byte _FF00_FF00혀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778857, new IntPtr(2737336616716L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00휀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FFFD()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSearchLanGameRoom_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityLanGameRoom[]> _003C_003Et__builder;

		public NeteaseDesktop _003C_003E4__this;

		public string name;

		private TaskAwaiter<RestResponse<EntityRelatedLanGameRoomResponse>> _003C_003Eu__1;

		internal static object DecorateSimpleVisitor;

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
		internal static bool WatchAllocator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectTransferableElement()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00씀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778856, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00였()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_023b: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_011f: Expected Obj, but got Ref
			//IL_014f: Expected Obj, but got I4
			//IL_015f: Expected Obj, but got I4
			//IL_0187: Expected Obj, but got Ref
			//IL_0256->IL0019: Incompatible stack heights: 2 vs 1
			//IL_022c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0245->IL0019: Incompatible stack types: I4 vs Obj
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0261->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0237->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0100->IL0079: Incompatible stack types: I4 vs Ref
			//IL_006a->IL0079: Incompatible stack heights: 0 vs 7
			//IL_00ae->IL00df: Incompatible stack heights: 6 vs 0
			//IL_0075->IL0079: Incompatible stack heights: 1 vs 7
			//IL_011b->IL0079: Incompatible stack heights: 9 vs 7
			//IL_0129->IL0079: Incompatible stack types: I4 vs Ref
			//IL_010d->IL0079: Incompatible stack heights: 8 vs 7
			//IL_015a->IL0079: Incompatible stack heights: 9 vs 7
			//IL_016a->IL0079: Incompatible stack heights: 9 vs 7
			//IL_00d4->IL0079: Incompatible stack heights: 9 vs 7
			//IL_017d->IL0183: Incompatible stack types: I4 vs Ref
			//IL_013b->IL0079: Incompatible stack types: I4 vs Ref
			//IL_00df->IL0079: Incompatible stack heights: 9 vs 7
			//IL_019e->IL0079: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			object obj2 = obj;
			while (true)
			{
				ref object reference;
				switch ((int)obj2)
				{
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 2;
					}
					break;
				case 4:
					if (obj == null)
					{
						if (2 != 0)
						{
							_ = 0;
						}
						goto IL_0079;
					}
					goto IL_00df;
				case 1:
					goto IL_021c;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 4;
					break;
				default:
					if (5 == 0)
					{
						_ = 5;
					}
					break;
				case 5:
					return;
					IL_0079:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 1u:
							return;
						case 11u:
							_ = ref obj;
							if (1 == 0)
							{
								_ = 1;
							}
							continue;
						case 5u:
							break;
						case 7u:
							_ = 9;
							continue;
						case 4u:
							_ = 11;
							continue;
						case 2u:
						case 6u:
							obj = (object)Unsafe.AsPointer(ref this);
							reference = ref *(object*)7;
							continue;
						case 8u:
							if (&obj == null)
							{
								reference = ref *(object*)10;
								continue;
							}
							goto case 3u;
						case 9u:
							obj = -1;
							_ = 3;
							continue;
						case 10u:
							obj = 0;
							_ = 4;
							continue;
						case 3u:
							reference = ref obj;
							obj = (object)Unsafe.AsPointer(ref 1 == 0 ? ref Unsafe.As<object, byte>(ref reference) : ref *(byte*)1);
							if (0 == 0)
							{
								reference = ref *(object*)null;
							}
							continue;
						default:
							goto IL_021c;
						}
						break;
					}
					goto IL_00df;
					IL_021c:
					_ = -2;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
					IL_00df:
					_ = 1;
					_ = 3;
					_ = ref obj;
					obj = obj;
					reference = ref *(object*)8;
					goto IL_0079;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00윀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778859, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00저(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778858, new IntPtr(2737336633356L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00준(object P_0)
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
		private unsafe sealed void _FF00_FF00쨀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778837, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00쬀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00찀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778836, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00촀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778839, new IntPtr(2737336633356L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00츀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}
	}

	[CompilerGenerated]
	private static readonly object Logger__BackingField;

	[CompilerGenerated]
	private static readonly object Instance__BackingField;

	public EntityAuthServer[] AuthServers;

	public EntityTransferServer[] TransferServers;

	public string NeteaseVersion;

	public Dictionary<string, EntityJavaPatch> NeteasePatchList;

	public readonly RestClient Client;

	private static object EvaluateTemplate;

	public static ILogger Logger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	public static NeteaseDesktop Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasSession(string userId)
	{
		return _FF00_FF00_FF00_FF00_FF00뀀(userId) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DesktopSession GetSession(string userId)
	{
		return (DesktopSession)_FF00_FF00_FF00_FF00_FF00阀(userId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DesktopSession? TryGetSession(string userId)
	{
		return (DesktopSession?)_FF00_FF00_FF00_FF00_FF00ꘀ(userId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInitAsync_003Ed__14))]
	public Task InitAsync()
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00꤀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoginAsync_003Ed__15))]
	public Task<DesktopSession> LoginAsync(string cookies)
	{
		return _FF00_FF00_FF00_FF00_FF00가(cookies);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoginAsync_003Ed__16))]
	private Task<DesktopSession> LoginAsync(object dto)
	{
		return _FF00_FF00_FF00_FF00_FF00錀(dto);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoginOtpAsync_003Ed__17))]
	private Task<EntityLoginOtp> LoginOtpAsync(object dto)
	{
		return _FF00_FF00_FF00_FF00_FF00꼀(dto);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAuthenticationOtpAsync_003Ed__18))]
	private Task<EntityAuthenticationOtp> AuthenticationOtpAsync(object dto)
	{
		return _FF00_FF00_FF00_FF00_FF00_AB00(dto);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAuthenticationUpdateAsync_003Ed__19))]
	internal Task<EntityAuthenticationOtp> AuthenticationUpdateAsync(string userId, string userToken)
	{
		return _FF00_FF00_FF00_FF00_FF00踀(userId, userToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetRelatedLanGameRooms_003Ed__20))]
	public Task<EntityLanGameRoom[]> GetRelatedLanGameRooms(int count = 50)
	{
		return _FF00_FF00_FF00_FF00_FF00退((uint)count);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSingleLanGameRoom_003Ed__21))]
	public Task<EntityLanGameRoom> GetSingleLanGameRoom(uint hostId, uint roomId)
	{
		return _FF00_FF00_FF00_FF00_FF00鬀(hostId, roomId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSearchLanGameRoom_003Ed__22))]
	public Task<EntityLanGameRoom[]> SearchLanGameRoom(string name)
	{
		return _FF00_FF00_FF00_FF00_FF00鸀(name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		_FF00_FF00_FF00_FF00_FF00ꌀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NeteaseDesktop()
	{
		//IL_0062: Expected I4, but got Obj
		//IL_0050->IL0059: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_ = null;
		_ = null;
		_ = 0;
		NeteaseDesktop neteaseDesktop = this;
		if (false)
		{
			neteaseDesktop = (NeteaseDesktop)0;
		}
		switch ((int)neteaseDesktop)
		{
		case 0:
			break;
		}
	}

	static NeteaseDesktop()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0023: Expected I4, but got Obj
		//IL_0079->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0050->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0084->IL0012: Incompatible stack types: I4 vs Obj
		//IL_005b->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				Logger__BackingField = Log.Logger.Category((string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00餀());
				obj2 = 0;
				if (_003CModule_003E_007Bb8824bbe_002D6cfa_002D4013_002D8120_002Dcb1e84055f2d_007D.m_2f25a4da0ad14a089b13089b3bff794c.m_64a93f7adb8a4bdf8e57237a4efaaddc == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				Instance__BackingField = new NeteaseDesktop();
				obj2 = 2;
				if (_003CModule_003E_007Bb8824bbe_002D6cfa_002D4013_002D8120_002Dcb1e84055f2d_007D.m_2f25a4da0ad14a089b13089b3bff794c.m_8ab3a27dfef14c7492f7da35eb7da664 != 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateFilteredMapper()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static NeteaseDesktop ReflectAutomatedPolicy()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityAuthenticationOtp> _FF00_FF00_FF00_FF00_FF00贀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778794, new IntPtr(2737336620876L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityAuthenticationOtp>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityAuthenticationOtp> _FF00_FF00_FF00_FF00_FF00踀(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005a: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2105, 1790778773, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 3, 1790778773, new IntPtr(2737336611516L), 15);
		}
		return (Task<EntityAuthenticationOtp>)((delegate*<object, object, object, object>)obj)(this, P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityAuthenticationOtp> _FF00_FF00_FF00_FF00_FF00輀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778772, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityAuthenticationOtp>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityLanGameRoom[]> _FF00_FF00_FF00_FF00_FF00退(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0040: Expected Obj, but got Ref
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_009f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00af->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0086->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0091->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0076->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005b->IL0019: Incompatible stack types: I4 vs Ref
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		ref object reference = ref *(object*)obj;
		while (true)
		{
			switch ((uint)Unsafe.AsPointer(ref reference))
			{
			case 2u:
				return (Task<EntityLanGameRoom[]>)(&obj);
			case 5u:
				reference = ref obj;
				if (4 != 0)
				{
					reference = ref *(object*)4;
				}
				break;
			case 4u:
				_ = ref obj;
				if (false)
				{
					_ = 0;
				}
				break;
			case 3u:
				_ = ref obj;
				_ = -1;
				if (0 == 0)
				{
					_ = 1;
				}
				break;
			default:
				_ = ref obj;
				_ = 3;
				break;
			case 1u:
				_ = ref obj;
				_ = ref obj;
				_ = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityLanGameRoom[]> _FF00_FF00_FF00_FF00_FF00鄀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778775, new IntPtr(2737336619836L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityLanGameRoom[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<DesktopSession> _FF00_FF00_FF00_FF00_FF00鈀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778774, new IntPtr(2737336613596L), 15))(null, 0, new IntPtr(0L));
		return (Task<DesktopSession>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<DesktopSession> _FF00_FF00_FF00_FF00_FF00錀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2110, 1790778769, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778769, new IntPtr(2737336637516L), 15);
		}
		return (Task<DesktopSession>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00销(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778768, new IntPtr(2737336631276L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00阀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2113, 1790778771, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778771, new IntPtr(2737336612556L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00需()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00頀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778770, new IntPtr(2737336613596L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00騀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityLanGameRoom> _FF00_FF00_FF00_FF00_FF00鬀(uint P_0, uint P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_007c: Expected Obj, but got Ref
		//IL_00c0->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00a7->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0051->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ce->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0077->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0097->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 6;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				_ = ref obj;
				_ = ref obj;
				if (2 == 0)
				{
					_ = 0;
				}
				break;
			case 3:
				_ = ref obj;
				if (1 == 0)
				{
					_ = 1;
				}
				break;
			case 2:
				return (Task<EntityLanGameRoom>)(&obj);
			case 5:
				_ = ref obj;
				if (3 != 0)
				{
					_ = 0;
				}
				break;
			case 1:
				_ = ref obj;
				if (false)
				{
					_ = 0;
				}
				break;
			default:
				_ = ref obj;
				_ = -1;
				_ = 4;
				break;
			case 6:
				_ = ref obj;
				_ = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityLanGameRoom> _FF00_FF00_FF00_FF00_FF00鰀(uint P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778781, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityLanGameRoom>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityLanGameRoom[]> _FF00_FF00_FF00_FF00_FF00鴀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778780, new IntPtr(2737336627116L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityLanGameRoom[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityLanGameRoom[]> _FF00_FF00_FF00_FF00_FF00鸀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2121, 1790778783, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778783, new IntPtr(2737336631276L), 15);
		}
		return (Task<EntityLanGameRoom[]>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityLanGameRoom[]> _FF00_FF00_FF00_FF00_FF00鼀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778782, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityLanGameRoom[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00ꀀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00ꄀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778777, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00ꈀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778776, new IntPtr(2737336614636L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00_FF00ꌀ()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0063->IL0019: Incompatible stack types: I4 vs Obj
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
			default:
				obj2 = this;
				if (2 == 0)
				{
					obj2 = 2;
				}
				break;
			case 1:
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
	internal static object _FF00_FF00_FF00_FF00_FF00ꐀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00ꔀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778779, new IntPtr(2737336613596L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00ꘀ(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2129, 1790778778, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778778, new IntPtr(2737336625036L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_A700(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778757, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00ꠀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778756, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00꤀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2132, 1790778759, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778759, new IntPtr(2737336629196L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00ꨀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778758, new IntPtr(2737336614636L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<EntityAuthenticationOtp> _FF00_FF00_FF00_FF00_FF00_AB00(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2134, 1790778753, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778753, new IntPtr(2737336613596L), 15);
		}
		return (Task<EntityAuthenticationOtp>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<DesktopSession> _FF00_FF00_FF00_FF00_FF00가(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2135, 1790778752, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778752, new IntPtr(2737336619836L), 15);
		}
		return (Task<DesktopSession>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<DesktopSession> _FF00_FF00_FF00_FF00_FF00관(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778755, new IntPtr(2737336614636L), 15))(null, 0, new IntPtr(0L));
		return (Task<DesktopSession>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<EntityLoginOtp> _FF00_FF00_FF00_FF00_FF00글(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778754, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityLoginOtp>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe Task<EntityLoginOtp> _FF00_FF00_FF00_FF00_FF00꼀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2138, 1790778765, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778765, new IntPtr(2737336614636L), 15);
		}
		return (Task<EntityLoginOtp>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00뀀(object P_0)
	{
		//IL_000b: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00넀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778764, new IntPtr(2737336630236L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}
}
