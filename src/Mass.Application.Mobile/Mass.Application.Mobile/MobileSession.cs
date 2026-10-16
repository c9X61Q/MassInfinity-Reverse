using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Mass.Application.Desktop;
using Mass.Application.Desktop.Models;
using Mass.Domain.Desktop.Entities.NetGame;
using Mass.Domain.Desktop.Entities.RentalGame;
using Mass.Domain.Desktop.Entities.Skin;
using Mass.Domain.Entities.Netease;
using Mass.Domain.Mobile.Entities.Game;
using Mass.Domain.Mobile.Entities.NetGame;
using Mass.Domain.Mobile.Entities.RentalGame;
using RestSharp;

namespace Mass.Application.Mobile;

public class MobileSession : DesktopSession
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CEntitiesRequestAsync_003Ed__9<T> : IAsyncStateMachine where T : notnull
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T[]> _003C_003Et__builder;

		public MobileSession _003C_003E4__this;

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

		internal static bool PeekTransaction()
		{
			return true;
		}

		internal static object DecorateModularConfig()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CEntityRequestAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MobileSession _003C_003E4__this;

		public string url;

		public object body;

		public bool checkCode;

		private TaskAwaiter<object> _003C_003Eu__1;

		private static object CheckGroupedEmitter;

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
		internal static bool CheckAccessibleRunner()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DisableAuditor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _2E00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778397, new IntPtr(2737336620876L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _2F00()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _3000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778396, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _3100()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778403, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _3200()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _3300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778402, new IntPtr(2737336636476L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 㐀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_026a: Expected Obj, but got Ref
			//IL_0258: Expected Obj, but got Ref
			//IL_0261: Expected Obj, but got I4
			//IL_00d5: Expected Obj, but got Ref
			//IL_0144: Expected Obj, but got I4
			//IL_014e: Expected Obj, but got I4
			//IL_0162: Expected Obj, but got I4
			//IL_010d: Expected Obj, but got I4
			//IL_00b2: Expected Obj, but got Ref
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0274->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0284->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0254->IL0019: Incompatible stack types: I4 vs Ref
			//IL_028f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004d->IL0051: Incompatible stack heights: 1 vs 3
			//IL_008a->IL00c9: Incompatible stack heights: 2 vs 0
			//IL_00ec->IL0051: Incompatible stack types: I4 vs Ref
			//IL_0167->IL004d: Incompatible stack heights: 5 vs 4
			//IL_011a->IL0051: Incompatible stack heights: 4 vs 3
			//IL_00be->IL0051: Incompatible stack heights: 2 vs 3
			//IL_0184->IL0051: Incompatible stack types: I4 vs Ref
			//IL_0194->IL0051: Incompatible stack heights: 4 vs 3
			//IL_0051->IL0051: Incompatible stack heights: 5 vs 3
			//IL_013f->IL0051: Incompatible stack types: I4 vs Ref
			//IL_0125->IL0051: Incompatible stack heights: 4 vs 3
			//IL_00a3->IL0051: Incompatible stack heights: 2 vs 3
			//IL_00c9->IL0051: Incompatible stack heights: 2 vs 3
			//IL_019f->IL0051: Incompatible stack heights: 4 vs 3
			//IL_00ae->IL0051: Incompatible stack heights: 2 vs 3
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			while (true)
			{
				ref _003CEntityRequestAsync_003Ed__7 reference = ref *(_003CEntityRequestAsync_003Ed__7*)obj;
				while (true)
				{
					scoped ref _003CEntityRequestAsync_003Ed__7 reference2;
					switch ((uint)Unsafe.AsPointer(ref reference))
					{
					case 5u:
						if (obj == null)
						{
							_ = 8;
							goto IL_0051;
						}
						goto IL_00c9;
					case 1u:
						return;
					default:
						reference = ref this;
						if (1 == 0)
						{
							reference = ref *(_003CEntityRequestAsync_003Ed__7*)1;
						}
						continue;
					case 3u:
						goto end_IL_0019;
					case 2u:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(_003CEntityRequestAsync_003Ed__7*)5;
						continue;
					case 4u:
						break;
						IL_00c9:
						reference2 = ref this;
						obj = (object)Unsafe.AsPointer(ref this);
						if (9 == 0)
						{
							reference2 = ref *(_003CEntityRequestAsync_003Ed__7*)null;
						}
						goto IL_0051;
						IL_0051:
						while (true)
						{
							switch ((uint)Unsafe.AsPointer(ref reference2))
							{
							case 9u:
								if (&obj != null)
								{
									if (7 == 0)
									{
										_ = 5;
									}
									continue;
								}
								goto default;
							case 8u:
							case 10u:
								obj = (object)Unsafe.AsPointer(ref this);
								if (2 != 0)
								{
									_ = 0;
								}
								continue;
							case 5u:
								break;
							case 6u:
								obj = -1;
								if (11 != 0)
								{
									_ = 7;
								}
								continue;
							case 2u:
								reference2 = ref this;
								if (6 != 0)
								{
									reference2 = ref *(_003CEntityRequestAsync_003Ed__7*)null;
								}
								continue;
							default:
								obj = 0;
								obj = 12;
								continue;
							case 1u:
								_ = ref obj;
								obj = 4;
								continue;
							case 7u:
							case 11u:
								_ = ref obj;
								reference2 = ref *(_003CEntityRequestAsync_003Ed__7*)3;
								continue;
							case 12u:
								if (true)
								{
									_ = 1;
								}
								continue;
							case 4u:
								return;
							case 3u:
								goto end_IL_0019_2;
							}
							break;
						}
						goto IL_00c9;
						end_IL_0019_2:
						break;
					}
					_ = -2;
					if (false)
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
		private unsafe sealed void 㔀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778401, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void 㘀(object P_0)
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
		private unsafe sealed void 㜀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778400, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CEntityRequestAsync_003Ed__8<T> : IAsyncStateMachine where T : notnull
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public MobileSession _003C_003E4__this;

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

		internal static bool LoadList()
		{
			return true;
		}

		internal static object JoinRecord()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetGameResourceInfos_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityGameResourceInfo[]> _003C_003Et__builder;

		public MobileSession _003C_003E4__this;

		public string gameId;

		private TaskAwaiter<EntityGameResourceInfo[]> _003C_003Eu__1;

		internal static object DecorateLocalAggregator;

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
		internal static bool DecorateSymbolicTag()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckConfigurableDefinition()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 㠀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778407, new IntPtr(2737336620876L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object 㤀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 㨀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778406, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 㬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778405, new IntPtr(2737336618796L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte 㰀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 㴀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778404, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 㼀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0225: Expected Obj, but got Ref
			//IL_024e: Expected Obj, but got Ref
			//IL_0100: Expected Obj, but got Ref
			//IL_0090: Expected Obj, but got I4
			//IL_015f: Expected Obj, but got I4
			//IL_00ca: Expected Obj, but got Ref
			//IL_017d: Expected Obj, but got I4
			//IL_024a->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0231->IL0019: Incompatible stack heights: 0 vs 1
			//IL_025a->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0274->IL0019: Incompatible stack heights: 3 vs 1
			//IL_004d->IL0051: Incompatible stack heights: 1 vs 0
			//IL_023c->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0265->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0117->IL0051: Incompatible stack heights: 1 vs 0
			//IL_009b->IL0051: Incompatible stack heights: 3 vs 0
			//IL_0169->IL0051: Incompatible stack heights: 4 vs 0
			//IL_00f1->IL0051: Incompatible stack heights: 2 vs 0
			//IL_018a->IL0051: Incompatible stack heights: 2 vs 0
			//IL_00aa->IL0051: Incompatible stack heights: 1 vs 0
			//IL_00c5->IL0051: Incompatible stack heights: 4 vs 0
			//IL_00e1->IL0051: Incompatible stack heights: 1 vs 0
			//IL_00fc->IL0051: Incompatible stack heights: 2 vs 0
			//IL_0195->IL0051: Incompatible stack heights: 2 vs 0
			//IL_00b5->IL0051: Incompatible stack heights: 1 vs 0
			//IL_0136->IL0051: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					if (obj != null)
					{
						_ = 3;
						goto IL_0051;
					}
					goto IL_00fc;
				case 2:
					return;
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						obj2 = 0;
					}
					break;
				case 1:
					goto IL_023c;
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					if (3 == 0)
					{
						obj2 = 3;
					}
					break;
				case 5:
					{
						_ = 2;
						break;
					}
					IL_00fc:
					obj = (object)Unsafe.AsPointer(ref this);
					if (8 == 0)
					{
						_ = 8;
					}
					goto IL_0051;
					IL_023c:
					_ = -2;
					_ = 5;
					break;
					IL_0051:
					while (true)
					{
						switch ((int)/*Error near IL_0086: Stack underflow*/)
						{
						default:
							obj = -1;
							_ = 5;
							continue;
						case 8:
							if (false)
							{
								_ = 0;
							}
							continue;
						case 10:
							_ = ref obj;
							_ = 11;
							continue;
						case 1:
						case 5:
							obj = (object)(&obj);
							if (9 == 0)
							{
								_ = 8;
							}
							continue;
						case 6:
							if (10 == 0)
							{
								_ = 10;
							}
							continue;
						case 2:
							break;
						case 4:
							if (&obj != null)
							{
								if (true)
								{
									_ = 1;
								}
								continue;
							}
							goto case 7;
						case 11:
							return;
						case 3:
							obj = 1;
							_ = 4;
							continue;
						case 7:
							obj = 0;
							if (false)
							{
								_ = 6;
							}
							continue;
						case 9:
							goto IL_023c;
						}
						break;
					}
					goto IL_00fc;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 䀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778411, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void 䄀(object P_0)
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

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetNetGameAddressAsync_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityNetGameAddress> _003C_003Et__builder;

		public MobileSession _003C_003E4__this;

		public string gameId;

		private TaskAwaiter<EntityNetGameAddress> _003C_003Eu__1;

		internal static object GuideRequester;

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
		internal static bool CheckMonoRecommender()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PatchEvent()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 䈀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778410, new IntPtr(2737336620876L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object 䌀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 䐀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778409, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 䔀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778408, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte 䘀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 䜀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778415, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 䤀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778414, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 䨀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_004e: Expected Obj, but got Ref
			//IL_0078: Expected Obj, but got Ref
			//IL_0161: Expected Obj, but got Ref
			//IL_0152: Expected Obj, but got I4
			//IL_00f4: Expected Obj, but got Ref
			//IL_010b: Expected Obj, but got I4
			//IL_00d7: Expected Obj, but got I4
			//IL_004a->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0074->IL0019: Incompatible stack heights: 3 vs 1
			//IL_005a->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0082->IL0019: Incompatible stack types: I4 vs Obj
			//IL_016b->IL0098: Incompatible stack types: I4 vs Ref
			//IL_0094->IL0098: Incompatible stack types: I4 vs Ref
			//IL_0065->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0142->IL0098: Incompatible stack heights: 3 vs 1
			//IL_015d->IL0098: Incompatible stack heights: 3 vs 1
			//IL_00fe->IL0098: Incompatible stack types: I4 vs Ref
			//IL_0115->IL0098: Incompatible stack heights: 4 vs 1
			//IL_00e4->IL0098: Incompatible stack heights: 2 vs 1
			//IL_0125->IL0098: Incompatible stack heights: 2 vs 1
			//IL_014d->IL0098: Incompatible stack heights: 3 vs 1
			//IL_0185->IL0098: Incompatible stack types: I4 vs Ref
			//IL_00ef->IL0098: Incompatible stack heights: 2 vs 1
			//IL_0199->IL0098: Incompatible stack heights: 0 vs 1
			//IL_0130->IL0098: Incompatible stack heights: 2 vs 1
			//IL_01a4->IL0098: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			object obj2 = obj;
			while (true)
			{
				ref _003CGetNetGameAddressAsync_003Ed__21 reference;
				switch ((int)obj2)
				{
				case 5:
					return;
				case 1:
					_ = -2;
					_ = 2;
					break;
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						obj2 = 0;
					}
					break;
				case 2:
					_ = 5;
					break;
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 3;
					break;
				default:
					{
						if (obj != null)
						{
							reference = ref *(_003CGetNetGameAddressAsync_003Ed__21*)6;
							goto IL_0098;
						}
						goto IL_015d;
					}
					IL_015d:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CGetNetGameAddressAsync_003Ed__21*)2;
					goto IL_0098;
					IL_0098:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						default:
							return;
						case 0u:
							return;
						case 5u:
							break;
						case 7u:
							obj = 0;
							if (3 == 0)
							{
								_ = 10;
							}
							continue;
						case 4u:
						case 11u:
							obj = (object)(&obj);
							reference = ref *(_003CGetNetGameAddressAsync_003Ed__21*)5;
							continue;
						case 6u:
							obj = 1;
							_ = 9;
							continue;
						case 10u:
							if (true)
							{
								_ = 1;
							}
							continue;
						case 1u:
							_ = ref obj;
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 3u:
							obj = -1;
							_ = 4;
							continue;
						case 8u:
							goto IL_015d;
						case 2u:
							reference = ref this;
							if (3 == 0)
							{
								reference = ref *(_003CGetNetGameAddressAsync_003Ed__21*)3;
							}
							continue;
						case 9u:
							if (&obj != null)
							{
								if (11 != 0)
								{
									reference = ref *(_003CGetNetGameAddressAsync_003Ed__21*)6;
								}
								continue;
							}
							goto case 7u;
						}
						break;
					}
					goto case 1;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 䬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778413, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void 䰀(object P_0)
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
		private unsafe sealed void 䴀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778412, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetNetGameDetailsAsync_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails> _003C_003Et__builder;

		public MobileSession _003C_003E4__this;

		public string gameId;

		private TaskAwaiter<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails> _003C_003Eu__1;

		private static object AttachWrapper;

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
		internal static bool DecorateScopeNotifier()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectStaticDispatcher()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 一()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778419, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object 伀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 倀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778418, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte 儀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 匀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0250: Expected Obj, but got Ref
			//IL_0235: Expected Obj, but got Ref
			//IL_0162: Expected Obj, but got I4
			//IL_0103: Expected Obj, but got Ref
			//IL_00e6: Expected Obj, but got I4
			//IL_014a: Expected Obj, but got I4
			//IL_011e: Expected Obj, but got Ref
			//IL_0230->IL0019: Incompatible stack heights: 3 vs 1
			//IL_025a->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0241->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0216->IL0019: Incompatible stack heights: 2 vs 1
			//IL_024c->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0221->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004f->IL005e: Incompatible stack heights: 0 vs 3
			//IL_0093->IL0155: Incompatible stack heights: 2 vs 0
			//IL_0179->IL005e: Incompatible stack types: I4 vs Ref
			//IL_005a->IL005e: Incompatible stack heights: 1 vs 3
			//IL_00fe->IL005e: Incompatible stack heights: 4 vs 3
			//IL_010f->IL005e: Incompatible stack heights: 2 vs 3
			//IL_00f1->IL005e: Incompatible stack heights: 5 vs 3
			//IL_0155->IL005e: Incompatible stack heights: 5 vs 3
			//IL_00a8->IL005e: Incompatible stack heights: 4 vs 3
			//IL_012a->IL005e: Incompatible stack heights: 2 vs 3
			//IL_0145->IL005e: Incompatible stack heights: 6 vs 3
			//IL_011a->IL005e: Incompatible stack heights: 2 vs 3
			//IL_00b3->IL005e: Incompatible stack heights: 4 vs 3
			//IL_0135->IL005e: Incompatible stack heights: 2 vs 3
			//IL_00c5->IL005e: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				scoped ref _003CGetNetGameDetailsAsync_003Ed__20 reference;
				switch ((int)obj2)
				{
				case 5:
					if (obj == null)
					{
						if (5 != 0)
						{
							_ = 5;
						}
						goto IL_005e;
					}
					goto IL_0155;
				case 4:
					goto IL_0206;
				default:
					_ = 3;
					break;
				case 3:
					return;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						obj2 = 1;
					}
					break;
				case 1:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 5;
						break;
					}
					IL_0155:
					reference = ref this;
					obj = 1;
					if (11 == 0)
					{
						reference = ref *(_003CGetNetGameDetailsAsync_003Ed__20*)2;
					}
					goto IL_005e;
					IL_0206:
					_ = -2;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
					IL_005e:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 7u:
							if (2 != 0)
							{
								_ = 10;
							}
							continue;
						case 11u:
							if (&obj == null)
							{
								reference = ref *(_003CGetNetGameDetailsAsync_003Ed__20*)3;
								continue;
							}
							goto case 2u;
						case 6u:
							return;
						case 3u:
							obj = 0;
							_ = 7;
							continue;
						case 1u:
							_ = 4;
							continue;
						case 2u:
							obj = (object)(&obj);
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 5u:
						case 9u:
							obj = (object)Unsafe.AsPointer(ref this);
							if (1 == 0)
							{
								_ = 0;
							}
							continue;
						case 10u:
							_ = ref obj;
							_ = 6;
							continue;
						case 4u:
							obj = -1;
							_ = 2;
							continue;
						case 8u:
							break;
						default:
							goto IL_0206;
						}
						break;
					}
					goto IL_0155;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void 吀(object P_0)
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

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetNetGamesAsync_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem[]> _003C_003Et__builder;

		public MobileSession _003C_003E4__this;

		private TaskAwaiter<EntityNetGames> _003C_003Eu__1;

		internal static object DecorateDynamicSingleton;

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
		internal static bool ReflectConcreteParser()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateConnectedState()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 唀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778417, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object 嘀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 圀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778416, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 堀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778423, new IntPtr(2737336636476L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte 夀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 娀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778422, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 尀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0065: Expected Obj, but got I4
			//IL_0040: Expected Obj, but got Ref
			//IL_02f8: Expected Obj, but got Ref
			//IL_00d6: Expected Obj, but got Ref
			//IL_01b7: Expected Obj, but got I4
			//IL_0174: Expected Obj, but got I4
			//IL_017e: Expected Obj, but got I4
			//IL_01ec: Expected Obj, but got I4
			//IL_00fb: Expected Obj, but got I4
			//IL_0213: Expected Obj, but got Ref
			//IL_00f1: Expected Obj, but got I4
			//IL_006a->IL0015: Incompatible stack heights: 2 vs 0
			//IL_02e9->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004c->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0302->IL0019: Incompatible stack types: I4 vs Obj
			//IL_02f4->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0057->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0194->IL0080: Incompatible stack heights: 0 vs 1
			//IL_0130->IL0080: Incompatible stack heights: 3 vs 1
			//IL_01c1->IL0080: Incompatible stack heights: 2 vs 1
			//IL_01d3->IL0080: Incompatible stack heights: 2 vs 1
			//IL_01f1->IL007c: Incompatible stack heights: 0 vs 2
			//IL_0106->IL0080: Incompatible stack heights: 3 vs 1
			//IL_0203->IL0080: Incompatible stack heights: 3 vs 1
			//IL_0150->IL0080: Incompatible stack heights: 2 vs 1
			//IL_0164->IL0080: Incompatible stack heights: 0 vs 1
			//IL_01de->IL0080: Incompatible stack heights: 2 vs 1
			//IL_00f6->IL007c: Incompatible stack heights: 0 vs 2
			//IL_0080->IL0080: Incompatible stack heights: 3 vs 1
			//IL_020e->IL0080: Incompatible stack heights: 3 vs 1
			//IL_0243->IL0080: Incompatible stack heights: 2 vs 1
			//IL_024e->IL0080: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					int num;
					switch ((int)obj2)
					{
					case 5:
						return;
					case 2:
						obj = (object)Unsafe.AsPointer(ref this);
						if (4 == 0)
						{
							obj2 = 1;
						}
						continue;
					case 4:
						if (obj != null)
						{
							num = 3;
							goto IL_0080;
						}
						goto IL_00d2;
					case 1:
						goto IL_02d9;
					case 3:
						{
							obj = (object)Unsafe.AsPointer(ref this);
							obj2 = 2;
							continue;
						}
						IL_00d2:
						obj = (object)Unsafe.AsPointer(ref this);
						num = 14;
						goto IL_0080;
						IL_0080:
						while (true)
						{
							switch (num)
							{
							default:
								return;
							case 0:
								return;
							case 15:
								break;
							case 7:
								if (&obj == null)
								{
									obj = 11;
									continue;
								}
								goto case 16;
							case 11:
								obj = 0;
								_ = 4;
								continue;
							case 4:
								_ = 13;
								continue;
							case 14:
								_ = 9;
								continue;
							case 3:
								if (obj == null)
								{
									if (12 == 0)
									{
										num = 3;
									}
									continue;
								}
								goto case 10;
							case 9:
								obj = -1;
								obj = 16;
								continue;
							case 2:
								obj = obj;
								if (8 != 0)
								{
									num = 7;
								}
								continue;
							case 5:
							case 12:
								obj = 1;
								_ = 7;
								continue;
							case 6:
								if (false)
								{
									_ = 1;
								}
								continue;
							case 10:
								obj = obj;
								obj = 17;
								continue;
							case 13:
								_ = ref obj;
								if (false)
								{
									_ = 0;
								}
								continue;
							case 16:
								obj = (object)(&obj);
								num = 6;
								continue;
							case 1:
							{
								object obj3 = obj;
								if (false)
								{
									_ = 2;
								}
								continue;
							}
							case 8:
							case 17:
								goto IL_02d9;
							}
							break;
						}
						goto IL_00d2;
						IL_02d9:
						_ = -2;
						if (0 == 0)
						{
							_ = 0;
						}
						continue;
					}
					break;
				}
				obj = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 崀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778421, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 帀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778420, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void 开(object P_0)
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

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetRentalGameAddressAsync_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityRentalGameAddress> _003C_003Et__builder;

		public MobileSession _003C_003E4__this;

		public string gameId;

		public string password;

		private TaskAwaiter<EntityRentalGameAddress> _003C_003Eu__1;

		internal static object StoreComparator;

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
		internal static bool VerifyBridge()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckLogicalReporter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 怀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778427, new IntPtr(2737336618796L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object 愀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 戀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778426, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 挀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778425, new IntPtr(2737336618796L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte 搀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 攀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778424, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 最()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778431, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 栀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_026d: Expected Obj, but got Ref
			//IL_016c: Expected Obj, but got Ref
			//IL_0159: Expected Obj, but got I4
			//IL_0163: Expected Obj, but got I4
			//IL_00ab: Expected Obj, but got I4
			//IL_00bb: Expected Obj, but got Ref
			//IL_019c: Expected Obj, but got I4
			//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0279->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0241->IL0019: Incompatible stack heights: 2 vs 1
			//IL_025e->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0284->IL0019: Incompatible stack types: I4 vs Obj
			//IL_024c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0269->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0183->IL006c: Incompatible stack heights: 1 vs 0
			//IL_0068->IL006c: Incompatible stack heights: 1 vs 0
			//IL_0154->IL006c: Incompatible stack heights: 2 vs 0
			//IL_00e2->IL006c: Incompatible stack heights: 2 vs 0
			//IL_00b6->IL006c: Incompatible stack heights: 3 vs 0
			//IL_012d->IL006c: Incompatible stack heights: 3 vs 0
			//IL_01a8->IL006c: Incompatible stack heights: 5 vs 0
			//IL_0196->IL0196: Incompatible stack heights: 4 vs 5
			//IL_006c->IL006c: Incompatible stack heights: 3 vs 0
			//IL_00ed->IL006c: Incompatible stack heights: 2 vs 0
			//IL_0138->IL006c: Incompatible stack heights: 3 vs 0
			//IL_00d2->IL006c: Incompatible stack heights: 1 vs 0
			//IL_01b3->IL006c: Incompatible stack heights: 5 vs 0
			//IL_011b->IL006c: Incompatible stack heights: 1 vs 0
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
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 5;
					break;
				case 5:
					if (obj != null)
					{
						if (1 == 0)
						{
							_ = 1;
						}
						goto IL_006c;
					}
					goto IL_0168;
				case 2:
					goto IL_0231;
				case 4:
					return;
				case 3:
					if (4 != 0)
					{
						_ = 1;
					}
					break;
				case 1:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (false)
						{
							obj2 = 0;
						}
						break;
					}
					IL_0168:
					obj = (object)Unsafe.AsPointer(ref this);
					if (6 != 0)
					{
						_ = 3;
					}
					goto IL_006c;
					IL_006c:
					while (true)
					{
						switch ((int)/*Error near IL_00a1: Stack underflow*/)
						{
						case 8:
							obj = -1;
							_ = 11;
							continue;
						default:
							obj = (object)(&obj);
							if (10 != 0)
							{
								_ = 5;
							}
							continue;
						case 7:
							if (9 == 0)
							{
								_ = 8;
							}
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
						case 9:
							_ = ref obj;
							if (true)
							{
								_ = 2;
							}
							continue;
						case 2:
							return;
						case 6:
							_ = 8;
							continue;
						case 4:
							obj = 0;
							obj = 7;
							continue;
						case 5:
							break;
						case 1:
							if (Unsafe.AsPointer(ref this) == null)
							{
							}
							obj = 1;
							if (3 == 0)
							{
								_ = 1;
							}
							continue;
						case 10:
							goto IL_0231;
						}
						break;
					}
					goto IL_0168;
					IL_0231:
					_ = -2;
					if (false)
					{
						_ = 3;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 椀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778430, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void 樀(object P_0)
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
		private unsafe sealed void 欀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778429, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetRentalGamesAsync_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> _003C_003Et__builder;

		public MobileSession _003C_003E4__this;

		public int offset;

		private TaskAwaiter<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> _003C_003Eu__1;

		internal static object EncodeConsumer;

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
		internal static bool DecorateControllableEnumerator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TrackSorter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 氀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778428, new IntPtr(2737336636476L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object 洀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 渀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778435, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 漀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778434, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte 瀀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 焀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778433, new IntPtr(2737336632316L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 猀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0243: Expected Obj, but got Ref
			//IL_0228: Expected Obj, but got Ref
			//IL_0103: Expected Obj, but got Ref
			//IL_012f: Expected Obj, but got I4
			//IL_0165: Expected Obj, but got I4
			//IL_00d7: Expected Obj, but got Ref
			//IL_00e0: Expected Obj, but got I4
			//IL_008c: Expected Obj, but got I4
			//IL_024f->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0234->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0268->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0218->IL0019: Incompatible stack heights: 2 vs 1
			//IL_025a->IL0019: Incompatible stack types: I4 vs Obj
			//IL_023f->IL0019: Incompatible stack types: I4 vs Obj
			//IL_004d->IL0051: Incompatible stack heights: 1 vs 0
			//IL_0223->IL0019: Incompatible stack heights: 2 vs 1
			//IL_011a->IL0051: Incompatible stack heights: 1 vs 0
			//IL_013c->IL0051: Incompatible stack heights: 2 vs 0
			//IL_0155->IL0051: Incompatible stack heights: 3 vs 0
			//IL_00f4->IL0051: Incompatible stack heights: 1 vs 0
			//IL_0171->IL0051: Incompatible stack heights: 5 vs 0
			//IL_012a->IL0051: Incompatible stack heights: 4 vs 0
			//IL_0097->IL0051: Incompatible stack heights: 3 vs 0
			//IL_0147->IL0051: Incompatible stack heights: 2 vs 0
			//IL_00ff->IL0051: Incompatible stack heights: 1 vs 0
			//IL_017c->IL0051: Incompatible stack heights: 5 vs 0
			//IL_0051->IL0051: Incompatible stack heights: 1 vs 0
			//IL_00d2->IL0051: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 4:
					if (obj != null)
					{
						_ = 6;
						goto IL_0051;
					}
					goto IL_00ff;
				case 5:
					if (2 == 0)
					{
						_ = 2;
					}
					continue;
				case 2:
					return;
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						obj2 = 0;
					}
					continue;
				default:
					obj = (object)Unsafe.AsPointer(ref this);
					if (true)
					{
						obj2 = 4;
					}
					continue;
				case 3:
					break;
					IL_0051:
					while (true)
					{
						switch ((int)/*Error near IL_0082: Stack underflow*/)
						{
						case 9:
							obj = 0;
							_ = 2;
							continue;
						case 10:
							return;
						case 4:
							if (&obj == null)
							{
								if (3 != 0)
								{
									_ = 9;
								}
								continue;
							}
							goto case 8;
						case 8:
							obj = (object)(&obj);
							obj = 5;
							continue;
						case 3:
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 1:
							break;
						case 7:
							_ = ref obj;
							_ = 10;
							continue;
						default:
							obj = -1;
							if (8 == 0)
							{
								_ = 1;
							}
							continue;
						case 2:
							_ = 7;
							continue;
						case 6:
							_ = 0;
							obj = 1;
							if (4 == 0)
							{
								_ = 3;
							}
							continue;
						case 5:
							goto end_IL_0019;
						}
						break;
					}
					goto IL_00ff;
					IL_00ff:
					obj = (object)Unsafe.AsPointer(ref this);
					if (3 == 0)
					{
						_ = 2;
					}
					goto IL_0051;
					end_IL_0019:
					break;
				}
				_ = -2;
				_ = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 琀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778432, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 甀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778439, new IntPtr(2737336636476L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void 瘀(object P_0)
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

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRequestAsync_003Ed__10<T> : IAsyncStateMachine where T : notnull, EntityResponse
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public MobileSession _003C_003E4__this;

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

		internal static bool DecorateSortedProfiler()
		{
			return true;
		}

		internal static object DecorateCombinedFactory()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRequestAsync_003Ed__11<T> : IAsyncStateMachine where T : notnull, EntityResponse
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public string url;

		public string body;

		public MobileSession _003C_003E4__this;

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

		internal static bool DecorateSequentialResponder()
		{
			return true;
		}

		internal static object DecorateSetStream()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSearchRentalGamesAsync_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> _003C_003Et__builder;

		public MobileSession _003C_003E4__this;

		public int offset;

		public string keyword;

		private TaskAwaiter<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> _003C_003Eu__1;

		private static object DecorateEfficientEncryptor;

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
		internal static bool CloseAggregator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CreateTag()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 簀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778438, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object 紀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 縀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778437, new IntPtr(2737336636476L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 缀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778436, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte 耀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 舀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_024f: Expected Obj, but got Ref
			//IL_0218: Expected Obj, but got Ref
			//IL_0167: Expected Obj, but got I4
			//IL_00cd: Expected Obj, but got I4
			//IL_00af: Expected Obj, but got I4
			//IL_018c: Expected Obj, but got Ref
			//IL_00a0: Expected Obj, but got Ref
			//IL_0182: Expected Obj, but got I4
			//IL_0097: Expected I4, but got Obj
			//IL_0275->IL0019: Incompatible stack heights: 3 vs 1
			//IL_025b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0224->IL0019: Incompatible stack heights: 0 vs 1
			//IL_023f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0171->IL005e: Incompatible stack types: I4 vs Obj
			//IL_004f->IL005e: Incompatible stack heights: 0 vs 6
			//IL_0266->IL0019: Incompatible stack types: I4 vs Obj
			//IL_022f->IL0019: Incompatible stack types: I4 vs Obj
			//IL_024a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0097->IL0156: Incompatible stack heights: 5 vs 0
			//IL_005a->IL005e: Incompatible stack heights: 1 vs 6
			//IL_00da->IL005e: Incompatible stack heights: 7 vs 6
			//IL_00f7->IL005e: Incompatible stack heights: 8 vs 6
			//IL_0156->IL005e: Incompatible stack heights: 7 vs 6
			//IL_00ba->IL005e: Incompatible stack heights: 8 vs 6
			//IL_0198->IL005e: Incompatible stack heights: 5 vs 6
			//IL_00c8->IL005e: Incompatible stack heights: 8 vs 6
			//IL_00aa->IL005e: Incompatible stack types: I4 vs Obj
			//IL_00e5->IL005e: Incompatible stack heights: 7 vs 6
			//IL_0102->IL005e: Incompatible stack heights: 8 vs 6
			//IL_01a3->IL005e: Incompatible stack heights: 5 vs 6
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (obj == null)
					{
						if (0 == 0)
						{
							_ = 0;
						}
						goto IL_005e;
					}
					goto IL_0156;
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 != 0)
					{
						obj2 = 2;
					}
					break;
				case 4:
					goto IL_022f;
				case 5:
					return;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						obj2 = 0;
					}
					break;
				case 1:
					{
						_ = 5;
						break;
					}
					IL_022f:
					_ = -2;
					if (1 == 0)
					{
						_ = 1;
					}
					break;
					IL_0156:
					obj = 1;
					obj3 = 2;
					goto IL_005e;
					IL_005e:
					while (true)
					{
						switch ((int)obj3)
						{
						default:
							obj = (object)Unsafe.AsPointer(ref this);
							obj3 = 5;
							continue;
						case 6:
							obj = -1;
							_ = 7;
							continue;
						case 9:
							_ = 3;
							continue;
						case 1:
							obj = 0;
							if (9 == 0)
							{
								_ = 8;
							}
							continue;
						case 3:
							_ = ref obj;
							if (12 != 0)
							{
								_ = 5;
							}
							continue;
						case 12:
							return;
						case 5:
							_ = 6;
							continue;
						case 11:
							break;
						case 2:
							if (&obj != null)
							{
								obj = 8;
								obj3 = obj;
								continue;
							}
							goto case 1;
						case 7:
						case 8:
							obj = (object)(&obj);
							if (4 != 0)
							{
								_ = 2;
							}
							continue;
						case 4:
							goto IL_022f;
						}
						break;
					}
					goto IL_0156;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void 茀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778443, new IntPtr(2737336636476L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void 萀(object P_0)
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
	}

	private object? _netGames;

	private static object ConcatFilter;

	public required EntityPatchInfo PatchInfo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (EntityPatchInfo)Ԁ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			Ḁ(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MobileSession(string userId, string token, bool startHeartbeat = true)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		int num = (startHeartbeat ? 1 : 0);
		if (0 == 0)
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
	public override void Dispose()
	{
		ᘀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CEntityRequestAsync_003Ed__7))]
	private object EntityRequestAsync(object url, object body, byte checkCode = 1)
	{
		return ጀ(url, body, checkCode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CEntityRequestAsync_003Ed__8<>))]
	private Task<T> EntityRequestAsync<T>(string url, object body, bool checkCode = true)
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CEntitiesRequestAsync_003Ed__9<>))]
	private Task<T[]> EntitiesRequestAsync<T>(string url, object body, bool checkCode = true)
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRequestAsync_003Ed__10<>))]
	private Task<T> RequestAsync<T>(string url, object body, bool checkCode = true) where T : EntityResponse
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRequestAsync_003Ed__11<>))]
	private Task<T> RequestAsync<T>(string url, string body, bool checkCode) where T : EntityResponse
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task InterLoginStartAsync()
	{
		return (Task)_0A00();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task InterStartAsync(string gameId)
	{
		return (Task)ࠀ(gameId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task<EntitySkinSetting[]> SetSkinAsync(string itemId)
	{
		return _0300(itemId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetNetGamesAsync_003Ed__15))]
	public new Task<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem[]> GetNetGamesAsync()
	{
		return _2400();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSearchRentalGamesAsync_003Ed__16))]
	public Task<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> SearchRentalGamesAsync(string keyword, int offset = 0)
	{
		return ᄀ(keyword, (uint)offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetRentalGamesAsync_003Ed__17))]
	public Task<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> GetRentalGamesAsync(int offset = 0)
	{
		return _0C00((uint)offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetRentalGameAddressAsync_003Ed__18))]
	public new Task<EntityRentalGameAddress> GetRentalGameAddressAsync(string gameId, string? password = null)
	{
		return _0E00(gameId, password);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public new SessionContext<MobileSession, Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem> GetNetGame(string gameId)
	{
		return _2200(gameId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetNetGameDetailsAsync_003Ed__20))]
	public new Task<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails> GetNetGameDetailsAsync(string gameId)
	{
		return _1B00(gameId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetNetGameAddressAsync_003Ed__21))]
	public new Task<EntityNetGameAddress> GetNetGameAddressAsync(string gameId)
	{
		return ༀ(gameId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetGameResourceInfos_003Ed__22))]
	public Task<EntityGameResourceInfo[]> GetGameResourceInfos(string gameId)
	{
		return _1800(gameId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateEfficientStream()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MobileSession ReflectAttachedEncryptor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntitySkinSetting[]> Ȁ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778369, new IntPtr(2737336620876L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntitySkinSetting[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Task<EntitySkinSetting[]> _0300(object P_0)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		throw /*Error near IL_000a: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntitySkinSetting[]> Ѐ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778368, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntitySkinSetting[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object Ԁ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _0600()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778375, new IntPtr(2737336634396L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _0700(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778374, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object ࠀ(object P_0)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _0900(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778373, new IntPtr(2737336623996L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _0A00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> _0B00(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778372, new IntPtr(2737336634396L), 15))(null, 0, new IntPtr(0L));
		return (Task<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> _0C00(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_004e: Expected Obj, but got Ref
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_0049->IL0019: Incompatible stack heights: 3 vs 1
		//IL_006e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005c->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00a4->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0094->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0079->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00af->IL0019: Incompatible stack heights: 2 vs 1
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
			case 5u:
				return (Task<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]>)(&obj);
			case 3u:
				_ = ref obj;
				_ = 4;
				break;
			case 2u:
				_ = ref obj;
				_ = ref obj;
				if (2 == 0)
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
			case 4u:
				_ = ref obj;
				_ = -1;
				if (2 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityRentalGameAddress> _0D00(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778379, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityRentalGameAddress>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityRentalGameAddress> _0E00(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005a: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 222, 1790778378, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 3, 1790778378, new IntPtr(2737336628156L), 15);
		}
		return (Task<EntityRentalGameAddress>)((delegate*<object, object, object, object>)obj)(this, P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityNetGameAddress> ༀ(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 223, 1790778377, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778377, new IntPtr(2737336633356L), 15);
		}
		return (Task<EntityNetGameAddress>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> က(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778376, new IntPtr(2737336616716L), 15))(null, 0, new IntPtr(0L));
		return (Task<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> ᄀ(object P_0, uint P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_0044: Expected Obj, but got Ref
		//IL_0089->IL0019: Incompatible stack heights: 3 vs 1
		//IL_009b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0070->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0060->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00b6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0052->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c1->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 6;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return (Task<Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]>)(&obj);
			case 6:
				_ = ref obj;
				_ = 5;
				break;
			case 4:
				_ = ref obj;
				_ = -1;
				_ = 2;
				break;
			case 3:
				_ = ref obj;
				if (true)
				{
					_ = 1;
				}
				break;
			case 1:
				_ = ref obj;
				_ = 4;
				break;
			case 2:
				_ = ref obj;
				_ = ref obj;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 5:
				_ = ref obj;
				if (3 == 0)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object ሀ(object P_0, object P_1, byte P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778383, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object ጀ(object P_0, object P_1, byte P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003e: Expected I4, but got Obj
		//IL_00b1: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got Ref
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_00b6->IL0015: Incompatible stack heights: 2 vs 0
		//IL_00c6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0053->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0070->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a4->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00d1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ec->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0096->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007b->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		while (true)
		{
			ref object reference = ref *(object*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 3u:
					_ = ref obj;
					if (5 == 0)
					{
						_ = 1;
					}
					continue;
				case 6u:
					_ = ref obj;
					_ = ref obj;
					if (false)
					{
						_ = 1;
					}
					continue;
				case 5u:
					_ = ref obj;
					if (false)
					{
						_ = 0;
					}
					continue;
				case 7u:
					_ = ref obj;
					_ = -1;
					_ = 6;
					continue;
				case 2u:
					_ = ref obj;
					if (7 != 0)
					{
						_ = 7;
					}
					continue;
				case 4u:
					reference = ref obj;
					if (3 == 0)
					{
						reference = ref *(object*)null;
					}
					continue;
				case 1u:
					return (object)(&obj);
				}
				break;
			}
			_ = ref obj;
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _1400(object P_0, object P_1, byte P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778382, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ᔀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void ᘀ()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_003f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0063->IL0019: Incompatible stack types: I4 vs Obj
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
				_ = null;
				if (false)
				{
					_ = 0;
				}
				break;
			default:
				obj2 = this;
				if (2 == 0)
				{
					obj2 = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void ᜀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778381, new IntPtr(2737336634396L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityGameResourceInfo[]> _1800(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 232, 1790778380, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778380, new IntPtr(2737336634396L), 15);
		}
		return (Task<EntityGameResourceInfo[]>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte ᤀ()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails> ᨀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778387, new IntPtr(2737336635436L), 15))(null, 0, new IntPtr(0L));
		return (Task<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails> _1B00(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 235, 1790778386, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778386, new IntPtr(2737336635436L), 15);
		}
		return (Task<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails> ᰀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778385, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
		return (Task<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void ᴀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778384, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void Ḁ(object P_0)
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
	internal unsafe void ἀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778391, new IntPtr(2737336615676L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe SessionContext<MobileSession, Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem> _2200(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 242, 1790778390, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778390, new IntPtr(2737336630236L), 15);
		}
		return (SessionContext<MobileSession, Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe SessionContext<MobileSession, Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem> _2300(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778389, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
		return (SessionContext<MobileSession, Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem[]> _2400()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 244, 1790778388, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778388, new IntPtr(2737336616716L), 15);
		}
		return (Task<Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem[]>)((delegate*<object, object>)obj)(this);
	}
}
