using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Mass.Application.Desktop.Models;
using Mass.Application.Netease;
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
using RestSharp;
using Serilog;

namespace Mass.Application.Desktop;

public class DesktopSession : NeteaseSession
{
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_005a: Expected Obj, but got Ref
			//IL_0091: Expected Obj, but got Ref
			//IL_01a9: Expected Obj, but got Ref
			//IL_016b: Expected Obj, but got I4
			//IL_01d3: Expected Obj, but got Ref
			//IL_01dc: Expected Obj, but got I4
			//IL_0201: Expected Obj, but got I4
			//IL_0187: Expected Obj, but got I4
			//IL_0191: Expected Obj, but got I4
			//IL_01e6: Expected Obj, but got I4
			//IL_01f0: Expected Obj, but got I4
			//IL_0066->IL0019: Incompatible stack heights: 0 vs 1
			//IL_009d->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0082->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0071->IL0019: Incompatible stack types: I4 vs Obj
			//IL_00a8->IL0019: Incompatible stack types: I4 vs Obj
			//IL_008d->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0056->IL0019: Incompatible stack heights: 2 vs 1
			//IL_01c0->IL00cc: Incompatible stack heights: 1 vs 0
			//IL_00c8->IL00cc: Incompatible stack heights: 1 vs 0
			//IL_0177->IL00cc: Incompatible stack heights: 9 vs 0
			//IL_0127->IL00cc: Incompatible stack heights: 3 vs 0
			//IL_01ce->IL00cc: Incompatible stack heights: 3 vs 0
			//IL_0206->IL00c8: Incompatible stack heights: 1 vs 0
			//IL_0196->IL00c8: Incompatible stack heights: 2 vs 0
			//IL_01f5->IL00c8: Incompatible stack heights: 2 vs 0
			//IL_0182->IL00cc: Incompatible stack heights: 9 vs 0
			//IL_0132->IL00cc: Incompatible stack heights: 3 vs 0
			//IL_00cc->IL00cc: Incompatible stack heights: 1 vs 0
			//IL_0151->IL00cc: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 3:
					_ = -2;
					if (2 == 0)
					{
						_ = 1;
					}
					break;
				default:
					obj = (object)Unsafe.AsPointer(ref this);
					if (4 == 0)
					{
						obj2 = 1;
					}
					break;
				case 2:
					if (5 != 0)
					{
						_ = 0;
					}
					break;
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				case 5:
					return;
				case 4:
					{
						if (obj != null)
						{
							if (0 == 0)
							{
								_ = 0;
							}
							goto IL_00cc;
						}
						goto IL_01a5;
					}
					IL_01a5:
					obj = (object)Unsafe.AsPointer(ref this);
					if (6 == 0)
					{
						_ = 5;
					}
					goto IL_00cc;
					IL_00cc:
					while (true)
					{
						switch ((int)/*Error near IL_0101: Stack underflow*/)
						{
						case 11:
							break;
						case 10:
							return;
						case 2:
							_ = ref obj;
							if (5 != 0)
							{
								_ = 10;
							}
							continue;
						case 1:
							if (&obj != null)
							{
								if (true)
								{
									_ = 3;
								}
								continue;
							}
							goto case 9;
						default:
							obj = 1;
							if (0 == 0)
							{
								_ = 1;
							}
							continue;
						case 8:
							obj = -1;
							obj = 5;
							continue;
						case 7:
							goto IL_01a5;
						case 4:
							_ = 2;
							continue;
						case 3:
						case 5:
							obj = (object)(&obj);
							obj = 11;
							continue;
						case 9:
							obj = 0;
							obj = 4;
							continue;
						case 6:
							obj = 8;
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
		private sealed void _FF00_FF00_FF00_FF00舀(object P_0)
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00蘀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_025d: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_01bd: Expected Obj, but got Ref
			//IL_008f: Expected Obj, but got I4
			//IL_0187: Expected Obj, but got I4
			//IL_016a: Expected Obj, but got I4
			//IL_0111: Expected Obj, but got I4
			//IL_0063->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0269->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0073->IL0019: Incompatible stack heights: 2 vs 1
			//IL_01c7->IL0098: Incompatible stack types: I4 vs Ref
			//IL_0274->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_007e->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0098->IL0098: Incompatible stack types: Obj vs Ref
			//IL_0146->IL0098: Incompatible stack heights: 3 vs 1
			//IL_0194->IL0098: Incompatible stack heights: 2 vs 1
			//IL_0138->IL0098: Incompatible stack heights: 4 vs 1
			//IL_0177->IL0098: Incompatible stack heights: 2 vs 1
			//IL_00df->IL0098: Incompatible stack heights: 2 vs 1
			//IL_011d->IL0098: Incompatible stack heights: 7 vs 1
			//IL_015a->IL0098: Incompatible stack heights: 0 vs 1
			//IL_019f->IL0098: Incompatible stack heights: 2 vs 1
			//IL_0182->IL0098: Incompatible stack heights: 2 vs 1
			//IL_01b9->IL0098: Incompatible stack types: I4 vs Ref
			//IL_0128->IL0098: Incompatible stack heights: 7 vs 1
			//IL_0165->IL0098: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			object obj2 = obj;
			while (true)
			{
				ref _003CAddRentalGameCharacterAsync_003Ed__45 reference;
				switch ((int)obj2)
				{
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 == 0)
					{
						obj2 = 2;
					}
					break;
				default:
					_ = 4;
					break;
				case 5:
					_ = -2;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
				case 1:
					if (obj != null)
					{
						obj = 11;
						reference = ref *(_003CAddRentalGameCharacterAsync_003Ed__45*)obj;
						goto IL_0098;
					}
					goto IL_01b9;
				case 4:
					return;
				case 2:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (1 == 0)
						{
							obj2 = 0;
						}
						break;
					}
					IL_01b9:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CAddRentalGameCharacterAsync_003Ed__45*)10;
					goto IL_0098;
					IL_0098:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 7u:
							break;
						case 1u:
						case 9u:
							_ = ref obj;
							_ = 7;
							continue;
						case 8u:
							return;
						case 11u:
							obj = 1;
							if (3 == 0)
							{
								_ = 3;
							}
							continue;
						case 5u:
							_ = ref obj;
							_ = 8;
							continue;
						case 2u:
							_ = 5;
							continue;
						case 3u:
							if (&obj != null)
							{
								if (true)
								{
									reference = ref *(_003CAddRentalGameCharacterAsync_003Ed__45*)1;
								}
								continue;
							}
							goto case 6u;
						case 6u:
							obj = 0;
							if (2 == 0)
							{
								_ = 1;
							}
							continue;
						case 4u:
							obj = -1;
							if (9 != 0)
							{
								_ = 0;
							}
							continue;
						case 10u:
							reference = ref this;
							if (4 != 0)
							{
								reference = ref *(_003CAddRentalGameCharacterAsync_003Ed__45*)2;
							}
							continue;
						default:
							goto IL_01b9;
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
		private sealed void _FF00_FF00_FF00_FF00眀(object P_0)
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_0043: Expected Obj, but got Ref
			//IL_0313: Expected Obj, but got Ref
			//IL_01e1: Expected Obj, but got Ref
			//IL_0383: Expected Obj, but got I4
			//IL_0289: Expected Obj, but got I4
			//IL_0201: Expected Obj, but got I4
			//IL_02f4: Expected Obj, but got I4
			//IL_039f: Expected Obj, but got Ref
			//IL_0172: Expected Obj, but got I4
			//IL_024d: Expected Obj, but got I4
			//IL_0333: Expected Obj, but got I4
			//IL_027a: Expected Obj, but got Ref
			//IL_0474->IL0019: Incompatible stack heights: 3 vs 1
			//IL_045c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0486->IL0019: Incompatible stack heights: 2 vs 1
			//IL_005d->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004d->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0467->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0491->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0068->IL0019: Incompatible stack heights: 2 vs 1
			//IL_031d->IL008b: Incompatible stack types: I4 vs Ref
			//IL_007c->IL008b: Incompatible stack heights: 0 vs 1
			//IL_0087->IL008b: Incompatible stack types: I4 vs Ref
			//IL_01eb->IL008b: Incompatible stack types: I4 vs Ref
			//IL_0390->IL008b: Incompatible stack heights: 2 vs 1
			//IL_0275->IL008b: Incompatible stack heights: 3 vs 1
			//IL_0296->IL008b: Incompatible stack heights: 2 vs 1
			//IL_020c->IL008b: Incompatible stack heights: 3 vs 1
			//IL_02ff->IL008b: Incompatible stack heights: 3 vs 1
			//IL_03a9->IL008b: Incompatible stack types: I4 vs Ref
			//IL_0345->IL008b: Incompatible stack heights: 2 vs 1
			//IL_0373->IL008b: Incompatible stack heights: 2 vs 1
			//IL_01fc->IL008b: Incompatible stack heights: 4 vs 1
			//IL_012b->IL008b: Incompatible stack heights: 3 vs 1
			//IL_030f->IL008b: Incompatible stack heights: 4 vs 1
			//IL_0360->IL008b: Incompatible stack heights: 3 vs 1
			//IL_0338->IL0087: Incompatible stack heights: 2 vs 1
			//IL_0284->IL008b: Incompatible stack types: I4 vs Ref
			//IL_0219->IL008b: Incompatible stack types: I4 vs Ref
			//IL_0352->IL008b: Incompatible stack heights: 2 vs 1
			//IL_02c0->IL008b: Incompatible stack heights: 2 vs 1
			//IL_039b->IL008b: Incompatible stack heights: 2 vs 1
			//IL_02a1->IL008b: Incompatible stack heights: 2 vs 1
			//IL_01af->IL008b: Incompatible stack types: I4 vs Ref
			//IL_02ef->IL008b: Incompatible stack types: I4 vs Ref
			//IL_008b->IL008b: Incompatible stack heights: 2 vs 1
			//IL_037e->IL008b: Incompatible stack heights: 2 vs 1
			//IL_0136->IL008b: Incompatible stack heights: 3 vs 1
			//IL_01c1->IL008b: Incompatible stack types: I4 vs Ref
			//IL_0264->IL008b: Incompatible stack types: I4 vs Ref
			//IL_018a->IL008b: Incompatible stack heights: 0 vs 1
			//IL_022d->IL008b: Incompatible stack heights: 0 vs 1
			//IL_02dd->IL008b: Incompatible stack types: I4 vs Ref
			//IL_02cb->IL008b: Incompatible stack heights: 2 vs 1
			//IL_0195->IL008b: Incompatible stack types: I4 vs Ref
			//IL_0238->IL008b: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 6;
			object obj2 = obj;
			while (true)
			{
				ref byte reference;
				switch ((int)obj2)
				{
				case 6:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 5;
					break;
				case 4:
					_ = -2;
					if (2 == 0)
					{
						_ = 0;
					}
					break;
				case 5:
					if (obj != null)
					{
						if (21 != 0)
						{
							reference = ref *(byte*)6;
						}
						goto IL_008b;
					}
					goto IL_030f;
				case 2:
					_ = null;
					if (false)
					{
						_ = 0;
					}
					break;
				default:
					_ = null;
					_ = 3;
					break;
				case 1:
					return;
				case 3:
					{
						if (false)
						{
							_ = 1;
						}
						break;
					}
					IL_030f:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(byte*)31;
					goto IL_008b;
					IL_008b:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 5u:
						case 15u:
							break;
						case 19u:
							_ = ref obj;
							if (true)
							{
								_ = 1;
							}
							continue;
						case 1u:
							return;
						case 16u:
						case 23u:
							obj = obj;
							obj = 28;
							continue;
						case 25u:
							if (obj != null)
							{
								if (23 == 0)
								{
									reference = ref *(byte*)2;
								}
								continue;
							}
							goto case 30u;
						case 9u:
							reference = ref *(byte*)(&obj);
							if (0 == 0)
							{
								reference = ref *(byte*)null;
							}
							continue;
						case 21u:
							if ((nint)obj != 1)
							{
								reference = ref *(byte*)17;
								continue;
							}
							goto case 10u;
						default:
							obj = (object)Unsafe.AsPointer(ref this);
							reference = ref *(byte*)5;
							continue;
						case 18u:
							_ = 27;
							continue;
						case 6u:
							obj = 0;
							_ = 22;
							continue;
						case 30u:
							obj = (object)/*Error near IL_020f: Stack underflow*/;
							reference = ref *(byte*)15;
							continue;
						case 27u:
							if (Unsafe.AsPointer(ref this) != null)
							{
								if (7 == 0)
								{
									reference = ref *(byte*)11;
								}
								continue;
							}
							goto case 3u;
						case 14u:
							return;
						case 24u:
							reference = ref Unsafe.As<_003CDownloadImageAsync_003Ed__34, byte>(ref this);
							obj = 0;
							if (18 != 0)
							{
								reference = ref *(byte*)26;
							}
							continue;
						case 3u:
							_ = 24;
							continue;
						case 29u:
							obj = (object)(&obj);
							reference = ref *(byte*)25;
							continue;
						case 4u:
							obj = -1;
							if (29 == 0)
							{
								_ = 25;
							}
							continue;
						case 32u:
							if (19 == 0)
							{
								_ = 19;
							}
							continue;
						case 28u:
							if (&obj == null)
							{
								reference = ref *(byte*)2;
								continue;
							}
							goto case 9u;
						case 12u:
							if (&obj == null)
							{
								reference = ref *(byte*)6;
								continue;
							}
							goto case 29u;
						case 8u:
							obj = -1;
							_ = 9;
							continue;
						case 20u:
							_ = ref obj;
							_ = 14;
							continue;
						case 7u:
							goto IL_030f;
						case 26u:
							_ = ref obj;
							obj = obj;
							obj = 12;
							continue;
						case 13u:
							_ = 8;
							continue;
						case 31u:
							_ = 4;
							continue;
						case 22u:
							_ = 20;
							continue;
						case 17u:
							if (18 != 0)
							{
								_ = 18;
							}
							continue;
						case 2u:
							obj = 1;
							if (23 == 0)
							{
								_ = 32;
							}
							continue;
						case 10u:
							obj = (object)Unsafe.AsPointer(ref this);
							reference = ref *(byte*)13;
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
		private sealed void _FF00_FF00_FF00_FF00渀(object P_0)
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
		internal unsafe static byte _FF00_FF00_FF00_FF00漀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779233, new IntPtr(2737336618796L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00瀀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00焀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_024c: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_011e: Expected Obj, but got Ref
			//IL_00ff: Expected Obj, but got I4
			//IL_0151: Expected Obj, but got Ref
			//IL_010f: Expected Obj, but got I4
			//IL_0066->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0258->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0270->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0128->IL0095: Incompatible stack types: I4 vs Ref
			//IL_0086->IL0095: Incompatible stack heights: 0 vs 1
			//IL_0071->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0263->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0091->IL0095: Incompatible stack types: I4 vs Ref
			//IL_010a->IL0095: Incompatible stack heights: 3 vs 1
			//IL_01bf->IL0095: Incompatible stack heights: 2 vs 1
			//IL_015d->IL0095: Incompatible stack heights: 3 vs 1
			//IL_0195->IL0095: Incompatible stack types: I4 vs Ref
			//IL_013a->IL0095: Incompatible stack heights: 3 vs 1
			//IL_011a->IL0095: Incompatible stack heights: 3 vs 1
			//IL_017c->IL0095: Incompatible stack heights: 0 vs 1
			//IL_01ca->IL0095: Incompatible stack heights: 2 vs 1
			//IL_0168->IL0095: Incompatible stack heights: 3 vs 1
			//IL_01af->IL0095: Incompatible stack types: I4 vs Ref
			//IL_0145->IL0095: Incompatible stack heights: 3 vs 1
			//IL_0187->IL0095: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			object obj2 = obj;
			while (true)
			{
				scoped ref _003CEntityRequestAsync_003Ed__9 reference;
				switch ((int)obj2)
				{
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						obj2 = 2;
					}
					break;
				case 1:
					_ = -2;
					if (5 == 0)
					{
						_ = 4;
					}
					break;
				case 4:
					return;
				default:
					if (obj != null)
					{
						if (0 == 0)
						{
							reference = ref *(_003CEntityRequestAsync_003Ed__9*)7;
						}
						goto IL_0095;
					}
					goto IL_011a;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						obj2 = 0;
					}
					break;
				case 5:
					{
						_ = 4;
						break;
					}
					IL_0095:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 6u:
							break;
						case 3u:
							return;
						case 1u:
							obj = -1;
							_ = 8;
							continue;
						case 11u:
							obj = 0;
							_ = 5;
							continue;
						default:
							goto IL_011a;
						case 10u:
							_ = ref obj;
							if (3 != 0)
							{
								_ = 1;
							}
							continue;
						case 7u:
							obj = (object)Unsafe.AsPointer(ref this);
							if (2 == 0)
							{
								_ = 4;
							}
							continue;
						case 4u:
							if (&obj != null)
							{
								if (2 == 0)
								{
									reference = ref *(_003CEntityRequestAsync_003Ed__9*)2;
								}
								continue;
							}
							goto case 11u;
						case 2u:
						case 8u:
							_ = ref obj;
							reference = ref *(_003CEntityRequestAsync_003Ed__9*)6;
							continue;
						case 9u:
							reference = ref this;
							if (1 == 0)
							{
								reference = ref *(_003CEntityRequestAsync_003Ed__9*)1;
							}
							continue;
						case 5u:
							if (10 != 0)
							{
								_ = 0;
							}
							continue;
						}
						break;
					}
					goto case 1;
					IL_011a:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CEntityRequestAsync_003Ed__9*)9;
					goto IL_0095;
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
		private sealed void _FF00_FF00_FF00_FF00攀(object P_0)
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
		internal static byte _FF00_FF00_FF00_FF00昀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00最()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_025e: Expected Obj, but got Ref
			//IL_005a: Expected Obj, but got Ref
			//IL_017a: Expected Obj, but got Ref
			//IL_011b: Expected Obj, but got I4
			//IL_00ec: Expected Obj, but got Ref
			//IL_00cf: Expected Obj, but got I4
			//IL_015f: Expected Obj, but got I4
			//IL_024f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0268->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0066->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_025a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0071->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0056->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0184->IL0094: Incompatible stack types: I4 vs Ref
			//IL_0085->IL0094: Incompatible stack heights: 0 vs 1
			//IL_0090->IL0094: Incompatible stack types: I4 vs Ref
			//IL_0143->IL0094: Incompatible stack heights: 2 vs 1
			//IL_0128->IL0094: Incompatible stack heights: 2 vs 1
			//IL_00f8->IL0094: Incompatible stack heights: 0 vs 1
			//IL_00dc->IL0094: Incompatible stack heights: 2 vs 1
			//IL_016b->IL0094: Incompatible stack heights: 5 vs 1
			//IL_01cd->IL0094: Incompatible stack heights: 4 vs 1
			//IL_014e->IL0094: Incompatible stack heights: 2 vs 1
			//IL_0133->IL0094: Incompatible stack heights: 2 vs 1
			//IL_0103->IL0094: Incompatible stack types: I4 vs Ref
			//IL_00e7->IL0094: Incompatible stack heights: 2 vs 1
			//IL_0176->IL0094: Incompatible stack heights: 5 vs 1
			//IL_0198->IL0094: Incompatible stack heights: 0 vs 1
			//IL_01bd->IL0094: Incompatible stack types: I4 vs Ref
			//IL_01a3->IL0094: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				scoped ref _003CGetAuthItemsAsync_003Ed__48 reference;
				switch ((int)obj2)
				{
				case 3:
					_ = -2;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						obj2 = 0;
					}
					break;
				case 5:
					if (obj != null)
					{
						if (2 == 0)
						{
							reference = ref *(_003CGetAuthItemsAsync_003Ed__48*)5;
						}
						goto IL_0094;
					}
					goto IL_0176;
				default:
					if (true)
					{
						_ = 4;
					}
					break;
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 5;
					break;
				case 4:
					return;
					IL_0094:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 9u:
							break;
						case 4u:
							obj = 0;
							if (false)
							{
								_ = 0;
							}
							continue;
						case 2u:
							obj = (object)(&obj);
							if (8 != 0)
							{
								reference = ref *(_003CGetAuthItemsAsync_003Ed__48*)9;
							}
							continue;
						case 7u:
							return;
						case 1u:
							obj = -1;
							if (2 == 0)
							{
								_ = 2;
							}
							continue;
						default:
							if (3 == 0)
							{
								_ = 10;
							}
							continue;
						case 5u:
							obj = 1;
							if (6 == 0)
							{
								_ = 2;
							}
							continue;
						case 3u:
							goto IL_0176;
						case 6u:
							if (&obj == null)
							{
								if (4 != 0)
								{
									reference = ref *(_003CGetAuthItemsAsync_003Ed__48*)2;
								}
								continue;
							}
							goto case 2u;
						case 8u:
							reference = ref this;
							if (1 == 0)
							{
								reference = ref *(_003CGetAuthItemsAsync_003Ed__48*)null;
							}
							continue;
						case 10u:
							_ = ref obj;
							_ = 7;
							continue;
						}
						break;
					}
					goto case 3;
					IL_0176:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CGetAuthItemsAsync_003Ed__48*)8;
					goto IL_0094;
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
		private sealed void _FF00_FF00_FF00_FF00尀(object P_0)
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0069: Expected Obj, but got Ref
			//IL_0139: Expected Obj, but got Ref
			//IL_01af: Expected Obj, but got I4
			//IL_0193: Expected Obj, but got I4
			//IL_015c: Expected Obj, but got I4
			//IL_0185: Expected Obj, but got I4
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0075->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0091->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0065->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0080->IL0019: Incompatible stack types: I4 vs Obj
			//IL_009c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00b7->IL00bb: Incompatible stack heights: 1 vs 0
			//IL_00f7->IL00fb: Incompatible stack heights: 1 vs 0
			//IL_00e5->IL00bb: Incompatible stack heights: 1 vs 0
			//IL_0150->IL00fb: Incompatible stack heights: 1 vs 0
			//IL_01bc->IL00fb: Incompatible stack heights: 2 vs 0
			//IL_0210->IL00fb: Incompatible stack heights: 2 vs 0
			//IL_021e->IL00fb: Incompatible stack heights: 3 vs 0
			//IL_0175->IL00fb: Incompatible stack heights: 1 vs 0
			//IL_01f8->IL00fb: Incompatible stack heights: 3 vs 0
			//IL_0166->IL00fb: Incompatible stack heights: 4 vs 0
			//IL_0190->IL00fb: Incompatible stack heights: 3 vs 0
			//IL_01c7->IL00fb: Incompatible stack heights: 2 vs 0
			//IL_0180->IL00fb: Incompatible stack heights: 1 vs 0
			//IL_01aa->IL00fb: Incompatible stack heights: 1 vs 0
			//IL_0203->IL00fb: Incompatible stack heights: 3 vs 0
			//IL_01e6->IL00fb: Incompatible stack heights: 1 vs 0
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
					if (0 == 0)
					{
						obj2 = 3;
					}
					continue;
				case 5:
					_ = 4;
					continue;
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
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
						if (0 == 0)
						{
							_ = 1;
						}
						while (true)
						{
							switch ((int)/*Error near IL_00c8: Stack underflow*/)
							{
							case 1:
								if (false)
								{
									_ = 0;
								}
								continue;
							}
							break;
						}
						if (obj != null)
						{
							_ = 10;
							goto IL_00fb;
						}
						goto IL_0135;
					}
					IL_00fb:
					while (true)
					{
						switch ((int)/*Error near IL_0130: Stack underflow*/)
						{
						case 9:
							return;
						case 2:
							break;
						case 1:
							goto end_IL_00fb;
						case 10:
							_ = 6;
							obj = 1;
							_ = 7;
							continue;
						case 5:
							_ = ref obj;
							if (true)
							{
								_ = 6;
							}
							continue;
						case 11:
							obj = -1;
							_ = 5;
							continue;
						case 6:
							obj = 1;
							if (2 == 0)
							{
								_ = 2;
							}
							continue;
						default:
							obj = 0;
							if (2 == 0)
							{
								_ = 4;
							}
							continue;
						case 7:
							if (&obj == null)
							{
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							}
							goto case 5;
						case 8:
							_ = ref obj;
							if (9 == 0)
							{
								_ = 1;
							}
							continue;
						case 3:
							_ = 11;
							continue;
						case 4:
							_ = 8;
							continue;
						}
						goto end_IL_0019;
						continue;
						end_IL_00fb:
						break;
					}
					goto IL_0135;
					IL_0135:
					obj = (object)Unsafe.AsPointer(ref this);
					if (3 == 0)
					{
						_ = 3;
					}
					goto IL_00fb;
					end_IL_0019:
					break;
				}
				_ = -2;
				if (0 == 0)
				{
					_ = 5;
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
		private sealed void _FF00_FF00_FF00_FF00儀(object P_0)
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0085: Expected Obj, but got Ref
			//IL_0077: Expected Obj, but got Ref
			//IL_0110: Expected Obj, but got Ref
			//IL_0119: Expected Obj, but got I4
			//IL_00e7: Expected I4, but got Obj
			//IL_018e: Expected Obj, but got I4
			//IL_017a: Expected Obj, but got I4
			//IL_0101: Expected Obj, but got I4
			//IL_0123: Expected Obj, but got Ref
			//IL_012c: Expected Obj, but got I4
			//IL_004d->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0091->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0081->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0068->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0058->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00ae->IL00b2: Incompatible stack types: I4 vs Ref
			//IL_009c->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0073->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00b2->IL00b2: Incompatible stack types: Obj vs Ref
			//IL_00fc->IL00b2: Incompatible stack heights: 4 vs 1
			//IL_0198->IL00b2: Incompatible stack heights: 2 vs 1
			//IL_0185->IL00b2: Incompatible stack heights: 3 vs 1
			//IL_010c->IL00b2: Incompatible stack heights: 3 vs 1
			//IL_0141->IL00b2: Incompatible stack heights: 2 vs 1
			//IL_0175->IL00b2: Incompatible stack types: I4 vs Ref
			//IL_01bb->IL00b2: Incompatible stack heights: 0 vs 1
			//IL_014c->IL00b2: Incompatible stack heights: 2 vs 1
			//IL_01c6->IL00b2: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			object obj2 = obj;
			while (true)
			{
				ref _003CGetCppGameClientInfo_003Ed__57 reference;
				switch ((int)obj2)
				{
				case 4:
					return;
				default:
					if (4 == 0)
					{
						_ = 4;
					}
					break;
				case 5:
					_ = -2;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 2;
					break;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						obj2 = 0;
					}
					break;
				case 1:
					{
						if (obj != null)
						{
							reference = ref *(_003CGetCppGameClientInfo_003Ed__57*)2;
							goto IL_00b2;
						}
						goto IL_010c;
					}
					IL_010c:
					obj = (object)Unsafe.AsPointer(ref this);
					obj = 5;
					goto IL_00ae;
					IL_00ae:
					reference = ref *(_003CGetCppGameClientInfo_003Ed__57*)obj;
					goto IL_00b2;
					IL_00b2:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 4u:
							return;
						case 6u:
							break;
						case 1u:
							_ = ref obj;
							_ = 4;
							continue;
						case 8u:
							obj = -1;
							_ = 11;
							continue;
						case 3u:
							goto IL_010c;
						default:
							goto IL_011e;
						case 10u:
							if (0 == 0)
							{
								_ = 1;
							}
							continue;
						case 5u:
							reference = ref this;
							if (8 != 0)
							{
								reference = ref *(_003CGetCppGameClientInfo_003Ed__57*)7;
							}
							continue;
						case 7u:
							obj = 0;
							_ = 10;
							continue;
						case 2u:
							obj = 1;
							_ = 9;
							continue;
						case 9u:
							if (&obj != null)
							{
								if (false)
								{
									reference = ref *(_003CGetCppGameClientInfo_003Ed__57*)null;
								}
								continue;
							}
							goto case 7u;
						}
						break;
					}
					goto case 5;
					IL_011e:
					obj = (object)(&obj);
					obj = 6;
					goto IL_00ae;
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
		private sealed void _FF00_FF00_FF00_FF00䤀(object P_0)
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
		internal static byte _FF00_FF00_FF00_FF00䨀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00䬀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_020f: Expected Obj, but got Ref
			//IL_004d: Expected Obj, but got Ref
			//IL_00b4: Expected Obj, but got Ref
			//IL_0166: Expected Obj, but got I4
			//IL_00d0: Expected Obj, but got I4
			//IL_0108: Expected Obj, but got Ref
			//IL_0175: Expected Obj, but got I4
			//IL_0049->IL0019: Incompatible stack heights: 3 vs 1
			//IL_021b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0057->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0237->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0226->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0242->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00cb->IL007a: Incompatible stack heights: 1 vs 0
			//IL_0076->IL007a: Incompatible stack heights: 1 vs 0
			//IL_0170->IL007a: Incompatible stack heights: 8 vs 0
			//IL_018d->IL007a: Incompatible stack heights: 2 vs 0
			//IL_013e->IL007a: Incompatible stack heights: 4 vs 0
			//IL_00f8->IL007a: Incompatible stack heights: 2 vs 0
			//IL_00dd->IL007a: Incompatible stack heights: 2 vs 0
			//IL_0112->IL007a: Incompatible stack heights: 1 vs 0
			//IL_0180->IL007a: Incompatible stack heights: 3 vs 0
			//IL_0103->IL007a: Incompatible stack heights: 2 vs 0
			//IL_00e8->IL007a: Incompatible stack heights: 2 vs 0
			//IL_0150->IL007a: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 1:
					_ = -2;
					_ = 4;
					break;
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 2;
					break;
				default:
					if (obj != null)
					{
						if (0 == 0)
						{
							_ = 0;
						}
						goto IL_007a;
					}
					goto IL_00b0;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				case 4:
					if (4 == 0)
					{
						_ = 5;
					}
					break;
				case 5:
					return;
					IL_00b0:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						_ = 1;
					}
					goto IL_007a;
					IL_007a:
					while (true)
					{
						switch ((int)/*Error near IL_00ab: Stack underflow*/)
						{
						case 8:
							break;
						case 6:
							goto IL_00b0;
						case 4:
							obj = -1;
							if (5 == 0)
							{
								_ = 0;
							}
							continue;
						case 3:
							if (2 != 0)
							{
								_ = 0;
							}
							continue;
						case 5:
							obj = (object)(&obj);
							_ = 8;
							continue;
						case 7:
							return;
						case 2:
							_ = ref obj;
							_ = 7;
							continue;
						case 9:
							if (&obj == null)
							{
								_ = 10;
								continue;
							}
							goto case 5;
						default:
							obj = 1;
							_ = 9;
							continue;
						case 10:
							obj = 0;
							_ = 3;
							continue;
						case 1:
							_ = 4;
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
		private sealed void _FF00_FF00_FF00_FF00䄀(object P_0)
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
		internal unsafe static byte _FF00_FF00_FF00_FF00䈀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779231, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00䌀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00䐀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_006a: Expected Obj, but got Ref
			//IL_01ba: Expected Obj, but got Ref
			//IL_018b: Expected Obj, but got Ref
			//IL_0169: Expected Obj, but got I4
			//IL_01b1: Expected Obj, but got I4
			//IL_0106: Expected Obj, but got I4
			//IL_0122: Expected Obj, but got I4
			//IL_005b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0076->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0091->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0066->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0081->IL0019: Incompatible stack types: I4 vs Obj
			//IL_009c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0197->IL00b2: Incompatible stack heights: 0 vs 1
			//IL_0174->IL00b2: Incompatible stack heights: 3 vs 1
			//IL_0112->IL00b2: Incompatible stack heights: 3 vs 1
			//IL_0164->IL00b2: Incompatible stack heights: 3 vs 1
			//IL_00f9->IL00b2: Incompatible stack heights: 2 vs 1
			//IL_012f->IL00b2: Incompatible stack heights: 2 vs 1
			//IL_00b2->IL00b2: Incompatible stack heights: 4 vs 1
			//IL_011d->IL00b2: Incompatible stack heights: 3 vs 1
			//IL_013a->IL00b2: Incompatible stack heights: 2 vs 1
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
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 2;
					continue;
				case 1:
					return;
				default:
					if (1 == 0)
					{
						_ = 0;
					}
					continue;
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					if (3 == 0)
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
							goto IL_00b2;
						}
						goto IL_01b6;
					}
					IL_01b6:
					obj = (object)Unsafe.AsPointer(ref this);
					num = 9;
					goto IL_00b2;
					IL_00b2:
					while (true)
					{
						switch (num)
						{
						case 7:
							return;
						case 6:
							break;
						case 9:
							_ = 10;
							continue;
						case 5:
							obj = 1;
							if (false)
							{
								_ = 0;
							}
							continue;
						case 10:
							obj = -1;
							if (2 == 0)
							{
								_ = 2;
							}
							continue;
						case 8:
							_ = 4;
							continue;
						case 3:
							obj = 0;
							_ = 8;
							continue;
						default:
							if (&obj != null)
							{
								num = 11;
								continue;
							}
							goto case 3;
						case 2:
						case 11:
							obj = (object)(&obj);
							if (true)
							{
								num = 6;
							}
							continue;
						case 4:
							_ = ref obj;
							obj = 7;
							continue;
						case 1:
							goto end_IL_00b2;
						}
						goto end_IL_0019;
						continue;
						end_IL_00b2:
						break;
					}
					goto IL_01b6;
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
		private unsafe sealed void _FF00_FF00_FF00_FF00㔀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779225, new IntPtr(2737336636476L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00㘀(object P_0)
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_020a: Expected Obj, but got Ref
			//IL_00aa: Expected Obj, but got Ref
			//IL_00b3: Expected Obj, but got I4
			//IL_00e4: Expected Obj, but got I4
			//IL_014c: Expected Obj, but got Ref
			//IL_013c: Expected Obj, but got I4
			//IL_0100: Expected Obj, but got I4
			//IL_0176: Expected Obj, but got I4
			//IL_024e->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0216->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0233->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0259->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0221->IL0019: Incompatible stack types: I4 vs Obj
			//IL_023e->IL0019: Incompatible stack heights: 2 vs 1
			//IL_006c->IL006c: Incompatible stack heights: 1 vs 0
			//IL_0068->IL006c: Incompatible stack heights: 1 vs 0
			//IL_00f0->IL006c: Incompatible stack heights: 5 vs 0
			//IL_0156->IL006c: Incompatible stack heights: 1 vs 0
			//IL_0188->IL006c: Incompatible stack heights: 2 vs 0
			//IL_0128->IL006c: Incompatible stack heights: 4 vs 0
			//IL_00c8->IL006c: Incompatible stack heights: 2 vs 0
			//IL_0147->IL006c: Incompatible stack heights: 3 vs 0
			//IL_010d->IL006c: Incompatible stack heights: 2 vs 0
			//IL_00fb->IL006c: Incompatible stack heights: 5 vs 0
			//IL_00d3->IL006c: Incompatible stack heights: 2 vs 0
			//IL_0118->IL006c: Incompatible stack heights: 2 vs 0
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
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 4;
					continue;
				case 4:
					if (obj != null)
					{
						if (false)
						{
							_ = 0;
						}
						goto IL_006c;
					}
					goto IL_00a6;
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						obj2 = 2;
					}
					continue;
				case 0:
					return;
				case 5:
					if (false)
					{
						_ = 0;
					}
					continue;
				case 1:
					break;
					IL_00a6:
					obj = (object)Unsafe.AsPointer(ref this);
					obj = 2;
					goto IL_006c;
					IL_006c:
					while (true)
					{
						switch ((int)/*Error near IL_00a1: Stack underflow*/)
						{
						case 4:
							break;
						case 6:
							if (5 != 0)
							{
								_ = 5;
							}
							continue;
						default:
							obj = 1;
							if (9 != 0)
							{
								_ = 0;
							}
							continue;
						case 10:
							obj = -1;
							if (false)
							{
								_ = 1;
							}
							continue;
						case 5:
							_ = ref obj;
							_ = 3;
							continue;
						case 7:
							obj = 0;
							_ = 6;
							continue;
						case 1:
						case 11:
							obj = (object)(&obj);
							_ = 8;
							continue;
						case 3:
							return;
						case 9:
							if (&obj != null)
							{
								obj = 11;
								continue;
							}
							goto case 7;
						case 2:
							_ = 10;
							continue;
						case 8:
							goto end_IL_0019;
						}
						break;
					}
					goto IL_00a6;
					end_IL_0019:
					break;
				}
				_ = -2;
				if (2 == 0)
				{
					_ = 5;
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
		private sealed void _FF00_FF00_FF00_FF00ⴀ(object P_0)
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
		internal static byte _FF00_FF00_FF00_FF00_2E00()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_021d: Expected Obj, but got Ref
			//IL_0238: Expected Obj, but got Ref
			//IL_0127: Expected Obj, but got I4
			//IL_0144: Expected Obj, but got I4
			//IL_0110: Expected Obj, but got Ref
			//IL_0161: Expected Obj, but got I4
			//IL_0135: Expected Obj, but got Ref
			//IL_0185: Expected Obj, but got I4
			//IL_0251->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0229->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0242->IL0019: Incompatible stack types: I4 vs Obj
			//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_006a->IL0079: Incompatible stack heights: 0 vs 4
			//IL_0234->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0056->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00ae->IL011a: Incompatible stack heights: 3 vs 0
			//IL_0075->IL0079: Incompatible stack heights: 1 vs 4
			//IL_01a7->IL0079: Incompatible stack heights: 6 vs 4
			//IL_0151->IL0079: Incompatible stack heights: 5 vs 4
			//IL_00e1->IL0079: Incompatible stack heights: 6 vs 4
			//IL_016e->IL0079: Incompatible stack heights: 5 vs 4
			//IL_015c->IL0079: Incompatible stack heights: 5 vs 4
			//IL_00ec->IL0079: Incompatible stack heights: 6 vs 4
			//IL_0100->IL0079: Incompatible stack heights: 3 vs 4
			//IL_0179->IL0079: Incompatible stack heights: 5 vs 4
			//IL_0079->IL0079: Incompatible stack heights: 5 vs 4
			//IL_010b->IL0079: Incompatible stack heights: 3 vs 4
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				case 5:
					_ = -2;
					if (1 == 0)
					{
						_ = 0;
					}
					break;
				default:
					if (obj == null)
					{
						if (9 == 0)
						{
							_ = 6;
						}
						goto IL_0079;
					}
					goto IL_011a;
				case 4:
					return;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 2;
					break;
				case 1:
					{
						_ = 4;
						break;
					}
					IL_011a:
					obj = 1;
					num = 3;
					goto IL_0079;
					IL_0079:
					while (true)
					{
						switch (num)
						{
						case 4:
							break;
						case 6:
							return;
						case 2:
							_ = ref obj;
							if (6 == 0)
							{
								_ = 3;
							}
							continue;
						case 3:
							if (&obj == null)
							{
								if (1 == 0)
								{
									_ = 0;
								}
								continue;
							}
							goto case 7;
						case 7:
							obj = (object)(&obj);
							num = 4;
							continue;
						case 5:
							goto IL_011a;
						case 9:
						case 10:
							obj = (object)Unsafe.AsPointer(ref this);
							num = 11;
							continue;
						case 1:
							obj = 0;
							if (false)
							{
								_ = 0;
							}
							continue;
						case 8:
							obj = -1;
							if (7 == 0)
							{
								_ = 2;
							}
							continue;
						case 11:
							obj = 8;
							continue;
						default:
							_ = 2;
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
		private sealed void _FF00_FF00_FF00_FF00_2400(object P_0)
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_2800()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0210: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_00ef: Expected Obj, but got I4
			//IL_0184: Expected Obj, but got Ref
			//IL_012b: Expected Obj, but got I4
			//IL_00c6: Expected Obj, but got Ref
			//IL_0175: Expected Obj, but got I4
			//IL_0121: Expected Obj, but got I4
			//IL_0236->IL0019: Incompatible stack heights: 3 vs 1
			//IL_021c->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0066->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0227->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0071->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0083->IL0087: Incompatible stack heights: 1 vs 4
			//IL_00bc->IL00e2: Incompatible stack heights: 3 vs 0
			//IL_0136->IL0087: Incompatible stack heights: 6 vs 4
			//IL_0154->IL0087: Incompatible stack heights: 6 vs 4
			//IL_0146->IL0087: Incompatible stack heights: 7 vs 4
			//IL_0180->IL0087: Incompatible stack heights: 6 vs 4
			//IL_0087->IL0087: Incompatible stack heights: 5 vs 4
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 1;
					}
					break;
				case 3:
					_ = -2;
					if (false)
					{
						_ = 0;
					}
					break;
				case 5:
					if (obj == null)
					{
						_ = 7;
						goto IL_0087;
					}
					goto IL_00e2;
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					if (5 != 0)
					{
						obj2 = 3;
					}
					break;
				default:
					_ = 4;
					break;
				case 4:
					return;
					IL_00e2:
					obj = 1;
					num = 8;
					goto IL_0087;
					IL_0087:
					while (true)
					{
						switch (num)
						{
						case 5:
							break;
						case 3:
							obj = (object)(&obj);
							num = 5;
							continue;
						case 8:
							if (&obj == null)
							{
								num = 9;
								continue;
							}
							goto case 3;
						case 1:
							goto IL_00e2;
						case 10:
							obj = 2;
							continue;
						case 2:
							obj = -1;
							_ = 3;
							continue;
						case 6:
							_ = ref obj;
							_ = 11;
							continue;
						case 4:
							_ = 6;
							continue;
						case 11:
							return;
						case 9:
							obj = 0;
							_ = 4;
							continue;
						default:
							obj = (object)Unsafe.AsPointer(ref this);
							num = 10;
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
		private sealed void _FF00_FF00_FF00_FF00_1B00(object P_0)
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
		internal static byte _FF00_FF00_FF00_FF00ᰀ()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_007c: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_0073: Expected Obj, but got I4
			//IL_02f6: Expected Obj, but got Ref
			//IL_0292: Expected Obj, but got I4
			//IL_02da: Expected Obj, but got I4
			//IL_0311: Expected Obj, but got Ref
			//IL_0256: Expected Obj, but got I4
			//IL_0276: Expected Obj, but got Ref
			//IL_022a: Expected Obj, but got Ref
			//IL_0266: Expected Obj, but got I4
			//IL_0209: Expected Obj, but got Ref
			//IL_0088->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0078->IL0015: Incompatible stack heights: 2 vs 0
			//IL_0064->IL0019: Incompatible stack heights: 3 vs 1
			//IL_00a5->IL00a9: Incompatible stack types: I4 vs Ref
			//IL_0093->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0302->IL00a9: Incompatible stack heights: 0 vs 1
			//IL_01b5->IL00a9: Incompatible stack types: I4 vs Ref
			//IL_030d->IL00a9: Incompatible stack types: I4 vs Ref
			//IL_0246->IL00a9: Incompatible stack heights: 3 vs 1
			//IL_01c6->IL00a9: Incompatible stack heights: 2 vs 1
			//IL_01e8->IL00a9: Incompatible stack heights: 4 vs 1
			//IL_029d->IL00a9: Incompatible stack heights: 3 vs 1
			//IL_02e7->IL00a9: Incompatible stack heights: 2 vs 1
			//IL_0146->IL00a9: Incompatible stack types: Obj vs Ref
			//IL_017d->IL00a9: Incompatible stack heights: 2 vs 1
			//IL_031d->IL00a9: Incompatible stack heights: 0 vs 1
			//IL_0198->IL00a9: Incompatible stack heights: 2 vs 1
			//IL_0261->IL00a9: Incompatible stack heights: 3 vs 1
			//IL_0282->IL00a9: Incompatible stack heights: 0 vs 1
			//IL_0234->IL00a9: Incompatible stack heights: 3 vs 1
			//IL_0271->IL00a9: Incompatible stack heights: 3 vs 1
			//IL_0215->IL00a9: Incompatible stack heights: 0 vs 1
			//IL_0251->IL00a9: Incompatible stack heights: 3 vs 1
			//IL_02f2->IL00a9: Incompatible stack heights: 2 vs 1
			//IL_0151->IL00a9: Incompatible stack types: I4 vs Ref
			//IL_0188->IL00a9: Incompatible stack heights: 2 vs 1
			//IL_0131->IL00a9: Incompatible stack types: I4 vs Ref
			//IL_033a->IL00a9: Incompatible stack types: I4 vs Ref
			//IL_0328->IL00a9: Incompatible stack types: I4 vs Ref
			//IL_02c6->IL00a9: Incompatible stack types: I4 vs Ref
			//IL_01a3->IL00a9: Incompatible stack heights: 2 vs 1
			//IL_028d->IL00a9: Incompatible stack types: I4 vs Ref
			//IL_01d8->IL00a9: Incompatible stack types: I4 vs Ref
			//IL_0220->IL00a9: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					ref _003CGetModHashListAsync_003Ed__26 reference;
					switch ((int)obj2)
					{
					case 2:
						obj = (object)Unsafe.AsPointer(ref this);
						if (1 == 0)
						{
							obj2 = 1;
						}
						continue;
					case 4:
						_ = -2;
						_ = 3;
						continue;
					case 5:
						return;
					case 3:
						break;
					case 1:
						obj = (object)Unsafe.AsPointer(ref this);
						if (0 == 0)
						{
							obj2 = 0;
						}
						continue;
					default:
						{
							if (obj == null)
							{
								reference = ref *(_003CGetModHashListAsync_003Ed__26*)6;
								goto IL_00a9;
							}
							goto IL_01a3;
						}
						IL_01a3:
						if ((nint)obj != 1)
						{
							reference = ref *(_003CGetModHashListAsync_003Ed__26*)21;
							goto IL_00a9;
						}
						goto IL_02f2;
						IL_02f2:
						obj = (object)Unsafe.AsPointer(ref this);
						if (12 == 0)
						{
							reference = ref *(_003CGetModHashListAsync_003Ed__26*)3;
						}
						goto IL_00a9;
						IL_00a9:
						while (true)
						{
							switch ((uint)Unsafe.AsPointer(ref reference))
							{
							case 18u:
								break;
							case 15u:
								return;
							case 17u:
								return;
							case 9u:
								reference = ref this;
								if (true)
								{
									reference = ref *(_003CGetModHashListAsync_003Ed__26*)4;
								}
								continue;
							case 7u:
							{
								object obj3 = obj;
								obj = obj;
								reference = ref *(_003CGetModHashListAsync_003Ed__26*)obj3;
								if (7 != 0)
								{
									reference = ref *(_003CGetModHashListAsync_003Ed__26*)10;
								}
								continue;
							}
							case 8u:
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							case 14u:
								if (2 != 0)
								{
									_ = 1;
								}
								continue;
							case 13u:
								goto IL_01a3;
							case 1u:
								obj = obj;
								_ = 18;
								continue;
							case 20u:
								if (&obj != null)
								{
									reference = ref *(_003CGetModHashListAsync_003Ed__26*)23;
									continue;
								}
								goto case 5u;
							case 2u:
								_ = ref obj;
								_ = 15;
								continue;
							case 24u:
								obj = (object)(&obj);
								if (1 == 0)
								{
									reference = ref *(_003CGetModHashListAsync_003Ed__26*)null;
								}
								continue;
							case 21u:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 20;
								continue;
							default:
								_ = ref obj;
								if (17 != 0)
								{
									_ = 16;
								}
								continue;
							case 16u:
								obj = -1;
								_ = 24;
								continue;
							case 22u:
								obj = 1;
								_ = 14;
								continue;
							case 19u:
							case 23u:
								obj = (object)(&obj);
								if (true)
								{
									reference = ref *(_003CGetModHashListAsync_003Ed__26*)7;
								}
								continue;
							case 4u:
								obj = -1;
								_ = 19;
								continue;
							case 12u:
								reference = ref this;
								if (14 == 0)
								{
									reference = ref *(_003CGetModHashListAsync_003Ed__26*)16;
								}
								continue;
							case 5u:
								obj = 0;
								if (4 != 0)
								{
									_ = 8;
								}
								continue;
							case 3u:
								goto IL_02f2;
							case 6u:
							case 11u:
								obj = (object)Unsafe.AsPointer(ref this);
								if (2 != 0)
								{
									reference = ref *(_003CGetModHashListAsync_003Ed__26*)9;
								}
								continue;
							case 10u:
								if (&obj == null)
								{
									reference = ref *(_003CGetModHashListAsync_003Ed__26*)22;
									continue;
								}
								goto case 24u;
							}
							break;
						}
						goto case 4;
					}
					break;
				}
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
		private sealed void _FF00_FF00_FF00_FF00ሀ(object P_0)
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00ᘀ()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_006c: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_0048: Expected Obj, but got I4
			//IL_0147: Expected Obj, but got I4
			//IL_0150: Expected Obj, but got I4
			//IL_018a: Expected Obj, but got Ref
			//IL_0234: Expected Obj, but got I4
			//IL_0121: Expected Obj, but got Ref
			//IL_015a: Expected Obj, but got I4
			//IL_0164: Expected Obj, but got I4
			//IL_020a: Expected Obj, but got I4
			//IL_0094->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0078->IL0019: Incompatible stack heights: 0 vs 1
			//IL_005d->IL0019: Incompatible stack heights: 2 vs 1
			//IL_009f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0083->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0068->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00c3->IL00c3: Incompatible stack heights: 4 vs 0
			//IL_00bf->IL00c3: Incompatible stack heights: 1 vs 0
			//IL_023f->IL00c3: Incompatible stack heights: 3 vs 0
			//IL_011d->IL00c3: Incompatible stack heights: 4 vs 0
			//IL_01cc->IL00c3: Incompatible stack heights: 1 vs 0
			//IL_012b->IL00c3: Incompatible stack heights: 1 vs 0
			//IL_022f->IL00c3: Incompatible stack heights: 3 vs 0
			//IL_0169->IL00bf: Incompatible stack heights: 2 vs 3
			//IL_01e9->IL00c3: Incompatible stack heights: 1 vs 0
			//IL_01a1->IL00c3: Incompatible stack heights: 1 vs 0
			//IL_01d7->IL00c3: Incompatible stack heights: 1 vs 0
			//IL_0221->IL00c3: Incompatible stack heights: 1 vs 0
			//IL_020f->IL00bf: Incompatible stack heights: 0 vs 3
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
					case 4:
						break;
					case 5:
						_ = -2;
						if (2 == 0)
						{
							_ = 1;
						}
						continue;
					case 3:
						obj = (object)Unsafe.AsPointer(ref this);
						if (0 == 0)
						{
							obj2 = 0;
						}
						continue;
					case 2:
						if (1 == 0)
						{
							_ = 1;
						}
						continue;
					case 1:
						return;
					default:
						{
							if (obj == null)
							{
								if (true)
								{
									_ = 0;
								}
								goto IL_00c3;
							}
							goto IL_013a;
						}
						IL_013a:
						obj = 1;
						obj = 9;
						goto IL_00c3;
						IL_00c3:
						while (true)
						{
							switch ((int)/*Error near IL_0108: Stack underflow*/)
							{
							case 4:
								break;
							case 15:
								return;
							case 6:
								_ = ref obj;
								_ = 15;
								continue;
							case 1:
							case 8:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 7;
								continue;
							case 11:
								goto IL_013a;
							case 14:
								obj = -1;
								obj = 2;
								continue;
							case 2:
							case 5:
								obj = (object)(&obj);
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							case 7:
								if (14 != 0)
								{
									_ = 6;
								}
								continue;
							default:
								if (obj == null)
								{
									_ = 10;
									continue;
								}
								goto case 12;
							case 12:
								throw obj;
							case 10:
								obj = obj;
								obj = 4;
								continue;
							case 9:
								if (&obj != null)
								{
									_ = 5;
									continue;
								}
								goto case 3;
							case 13:
								_ = 6;
								continue;
							case 3:
								obj = 0;
								_ = 13;
								continue;
							}
							break;
						}
						goto case 5;
					}
					break;
				}
				obj = (object)Unsafe.AsPointer(ref this);
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
		private sealed void _FF00_FF00_FF00_FF00_0900(object P_0)
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_025c: Expected Obj, but got Ref
			//IL_005c: Expected Obj, but got Ref
			//IL_0132: Expected Obj, but got I4
			//IL_013b: Expected Obj, but got I4
			//IL_00f3: Expected Obj, but got Ref
			//IL_01b9: Expected Obj, but got I4
			//IL_0145: Expected Obj, but got I4
			//IL_0174: Expected Obj, but got Ref
			//IL_00d6: Expected Obj, but got I4
			//IL_0049->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0266->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0068->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0058->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0073->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0140->IL0093: Incompatible stack types: Obj vs Ref
			//IL_0140->IL0093: Incompatible stack types: Obj vs Ref
			//IL_0097->IL0097: Incompatible stack heights: 4 vs 0
			//IL_0093->IL0097: Incompatible stack heights: 1 vs 0
			//IL_019f->IL0097: Incompatible stack heights: 1 vs 0
			//IL_0152->IL0097: Incompatible stack heights: 2 vs 0
			//IL_017e->IL0097: Incompatible stack heights: 1 vs 0
			//IL_00e3->IL0097: Incompatible stack heights: 2 vs 0
			//IL_011a->IL0097: Incompatible stack heights: 2 vs 0
			//IL_010a->IL0097: Incompatible stack heights: 1 vs 0
			//IL_01aa->IL0097: Incompatible stack heights: 1 vs 0
			//IL_0190->IL0097: Incompatible stack heights: 1 vs 0
			//IL_015d->IL0097: Incompatible stack heights: 2 vs 0
			//IL_00ee->IL0097: Incompatible stack heights: 2 vs 0
			//IL_0125->IL0097: Incompatible stack heights: 2 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				scoped ref _003CGetNetGameDetailsAsync_003Ed__53 reference;
				ref object reference2;
				ref _003CGetNetGameDetailsAsync_003Ed__53 reference3;
				switch ((int)obj2)
				{
				default:
					_ = -2;
					_ = 4;
					break;
				case 4:
					_ = 3;
					break;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						obj2 = 1;
					}
					break;
				case 3:
					return;
				case 5:
					if (obj == null)
					{
						if (0 == 0)
						{
							_ = 0;
						}
						goto IL_0097;
					}
					goto IL_0125;
				case 1:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 5;
						break;
					}
					IL_0125:
					obj3 = obj;
					reference = ref this;
					obj = 1;
					obj = 3;
					reference2 = ref *(object*)obj3;
					reference3 = ref *(_003CGetNetGameDetailsAsync_003Ed__53*)obj3;
					goto IL_0097;
					IL_0097:
					while (true)
					{
						switch ((int)/*Error near IL_00cc: Stack underflow*/)
						{
						case 7:
							break;
						case 9:
							return;
						case 8:
							obj = -1;
							if (1 == 0)
							{
								_ = 0;
							}
							continue;
						case 1:
							obj = (object)(&obj);
							if (7 == 0)
							{
								_ = 2;
							}
							continue;
						case 11:
							if (4 == 0)
							{
								_ = 1;
							}
							continue;
						case 10:
							goto IL_0125;
						case 5:
							obj = 0;
							if (4 == 0)
							{
								_ = 11;
							}
							continue;
						default:
							obj = (object)Unsafe.AsPointer(ref this);
							_ = 2;
							continue;
						case 3:
							if (&obj == null)
							{
								_ = 5;
								continue;
							}
							goto case 1;
						case 2:
							if (0 == 0)
							{
								_ = 8;
							}
							continue;
						case 4:
							reference3 = ref this;
							reference2 = ref obj;
							reference = ref this;
							obj = 9;
							continue;
						}
						break;
					}
					goto default;
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
		private sealed void _FF00_FF00_FF00_FE00(object P_0)
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_0300()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_003e: Expected I4, but got Obj
			//IL_005b: Expected I4, but got Obj
			//IL_08ba: Expected Obj, but got Ref
			//IL_0878: Expected Obj, but got Ref
			//IL_0744: Expected Obj, but got Ref
			//IL_060c: Expected Obj, but got Ref
			//IL_0410: Expected Obj, but got Ref
			//IL_069e: Expected Obj, but got Ref
			//IL_05d1: Expected Obj, but got I4
			//IL_0407: Expected Obj, but got I4
			//IL_041f: Expected Obj, but got Ref
			//IL_0264: Expected Obj, but got I4
			//IL_01c0: Expected Obj, but got I4
			//IL_037a: Expected Obj, but got I4
			//IL_03e0: Expected Obj, but got I4
			//IL_0716: Expected Obj, but got I4
			//IL_0214: Expected Obj, but got Ref
			//IL_063a: Expected Obj, but got Ref
			//IL_02d2: Expected Obj, but got Ref
			//IL_02ee: Expected Obj, but got I4
			//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bf: Expected Obj, but got Unknown
			//IL_024d: Expected Obj, but got I4
			//IL_01cf: Expected Obj, but got I4
			//IL_0284: Expected Obj, but got Ref
			//IL_05e1: Expected Obj, but got Ref
			//IL_0630: Expected Obj, but got I4
			//IL_0184: Expected Obj, but got I4
			//IL_0194: Expected Obj, but got I4
			//IL_045c: Expected Obj, but got I4
			//IL_0762: Expected Obj, but got I4
			//IL_047e: Expected Obj, but got Ref
			//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c9: Expected Obj, but got I4
			//IL_04f6: Expected Obj, but got Ref
			//IL_08e0->IL0019: Incompatible stack heights: 3 vs 1
			//IL_08ab->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0891->IL0019: Incompatible stack heights: 2 vs 1
			//IL_08c6->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0882->IL0019: Incompatible stack types: I4 vs Obj
			//IL_08f0->IL0019: Incompatible stack heights: 2 vs 1
			//IL_08b6->IL0019: Incompatible stack heights: 2 vs 1
			//IL_074e->IL0069: Incompatible stack types: I4 vs Ref
			//IL_0618->IL0069: Incompatible stack heights: 0 vs 1
			//IL_041a->IL0069: Incompatible stack types: I4 vs Ref
			//IL_06aa->IL0069: Incompatible stack heights: 0 vs 1
			//IL_0065->IL0069: Incompatible stack types: I4 vs Ref
			//IL_089c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_08d1->IL0019: Incompatible stack types: I4 vs Obj
			//IL_08fb->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0623->IL0069: Incompatible stack types: I4 vs Ref
			//IL_06b5->IL0069: Incompatible stack types: I4 vs Ref
			//IL_05db->IL0069: Incompatible stack heights: 2 vs 1
			//IL_01ed->IL0069: Incompatible stack heights: 4 vs 1
			//IL_0429->IL0069: Incompatible stack types: I4 vs Ref
			//IL_06f9->IL0069: Incompatible stack heights: 2 vs 1
			//IL_026e->IL0069: Incompatible stack types: I4 vs Ref
			//IL_01ca->IL0069: Incompatible stack types: I4 vs Ref
			//IL_037f->IL0065: Incompatible stack heights: 1 vs 3
			//IL_03ed->IL0069: Incompatible stack heights: 2 vs 1
			//IL_0723->IL0069: Incompatible stack heights: 2 vs 1
			//IL_0646->IL0069: Incompatible stack heights: 0 vs 1
			//IL_0711->IL0069: Incompatible stack heights: 3 vs 1
			//IL_02de->IL0069: Incompatible stack heights: 2 vs 1
			//IL_02fb->IL0069: Incompatible stack heights: 2 vs 1
			//IL_0344->IL0069: Incompatible stack heights: 0 vs 1
			//IL_03c9->IL0069: Incompatible stack types: I4 vs Ref
			//IL_0252->IL0065: Incompatible stack heights: 2 vs 3
			//IL_01da->IL0069: Incompatible stack heights: 3 vs 1
			//IL_06c5->IL0069: Incompatible stack heights: 4 vs 1
			//IL_067d->IL0069: Incompatible stack types: I4 vs Ref
			//IL_03b9->IL0069: Incompatible stack heights: 3 vs 1
			//IL_0328->IL0069: Incompatible stack heights: 2 vs 1
			//IL_0663->IL0069: Incompatible stack heights: 2 vs 1
			//IL_028e->IL0069: Incompatible stack types: I4 vs Ref
			//IL_0445->IL0069: Incompatible stack heights: 2 vs 1
			//IL_05fd->IL0069: Incompatible stack heights: 0 vs 1
			//IL_05ed->IL0069: Incompatible stack types: I4 vs Ref
			//IL_069a->IL0069: Incompatible stack heights: 3 vs 1
			//IL_059e->IL0069: Incompatible stack heights: 3 vs 1
			//IL_0635->IL0065: Incompatible stack heights: 2 vs 3
			//IL_018f->IL0069: Incompatible stack heights: 3 vs 1
			//IL_019f->IL0069: Incompatible stack heights: 3 vs 1
			//IL_077c->IL0069: Incompatible stack heights: 2 vs 1
			//IL_01b2->IL0069: Incompatible stack heights: 0 vs 1
			//IL_035f->IL0069: Incompatible stack heights: 4 vs 1
			//IL_0467->IL0069: Incompatible stack heights: 3 vs 1
			//IL_076d->IL0069: Incompatible stack heights: 3 vs 1
			//IL_048a->IL0069: Incompatible stack heights: 0 vs 1
			//IL_027e->IL0069: Incompatible stack heights: 3 vs 1
			//IL_03ab->IL0069: Incompatible stack heights: 4 vs 1
			//IL_06df->IL0069: Incompatible stack heights: 4 vs 1
			//IL_05b0->IL0069: Incompatible stack heights: 2 vs 1
			//IL_0740->IL0069: Incompatible stack types: I4 vs Ref
			//IL_0069->IL0069: Incompatible stack heights: 4 vs 1
			//IL_0704->IL0069: Incompatible stack heights: 2 vs 1
			//IL_03f8->IL0069: Incompatible stack heights: 2 vs 1
			//IL_072e->IL0069: Incompatible stack heights: 2 vs 1
			//IL_0224->IL0069: Incompatible stack types: I4 vs Ref
			//IL_0651->IL0069: Incompatible stack types: I4 vs Ref
			//IL_02e9->IL0069: Incompatible stack heights: 2 vs 1
			//IL_0306->IL0069: Incompatible stack heights: 2 vs 1
			//IL_034f->IL0069: Incompatible stack types: I4 vs Ref
			//IL_0204->IL0069: Incompatible stack heights: 0 vs 1
			//IL_0333->IL0069: Incompatible stack heights: 2 vs 1
			//IL_0457->IL0069: Incompatible stack types: I4 vs Ref
			//IL_0318->IL0069: Incompatible stack types: I4 vs Ref
			//IL_066e->IL0069: Incompatible stack heights: 2 vs 1
			//IL_07b0->IL0069: Incompatible stack types: I4 vs Ref
			//IL_0608->IL0069: Incompatible stack types: I4 vs Ref
			//IL_0787->IL0069: Incompatible stack heights: 2 vs 1
			//IL_01bd->IL0069: Incompatible stack types: I4 vs Ref
			//IL_03db->IL0069: Incompatible stack types: I4 vs Ref
			//IL_0495->IL0069: Incompatible stack types: I4 vs Ref
			//IL_023e->IL0069: Incompatible stack types: I4 vs Ref
			//IL_07d3->IL0069: Incompatible stack heights: 3 vs 1
			//IL_07c1->IL07c1: Incompatible stack types: Obj vs Ref
			//IL_06ea->IL0069: Incompatible stack heights: 4 vs 1
			//IL_0479->IL0069: Incompatible stack types: I4 vs Ref
			//IL_05bb->IL0069: Incompatible stack heights: 2 vs 1
			//IL_020f->IL0069: Incompatible stack types: I4 vs Ref
			//IL_050d->IL04b6: Incompatible stack heights: 1 vs 0
			//IL_052c->IL04b6: Incompatible stack heights: 1 vs 0
			//IL_04e6->IL04b6: Incompatible stack heights: 3 vs 0
			//IL_04f1->IL04b6: Incompatible stack heights: 3 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					ref _003CGetNetGamesAsync_003Ed__15 reference;
					switch ((int)obj)
					{
					default:
						reference = ref *(_003CGetNetGamesAsync_003Ed__15*)65;
						goto IL_0069;
					case 2:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(_003CGetNetGamesAsync_003Ed__15*)39;
						goto IL_0069;
					case 1:
						goto IL_0608;
					case 3:
						goto IL_069a;
					case 0:
						goto IL_0740;
						IL_0069:
						while (true)
						{
							switch ((uint)Unsafe.AsPointer(ref reference))
							{
							case 47u:
								obj = -1;
								_ = 42;
								continue;
							case 48u:
								obj = 2;
								_ = 44;
								continue;
							case 52u:
								obj = ((object[])obj)[obj];
								if (5 == 0)
								{
									reference = ref *(_003CGetNetGamesAsync_003Ed__15*)2;
								}
								continue;
							case 11u:
								obj = 0;
								reference = ref *(_003CGetNetGamesAsync_003Ed__15*)8;
								continue;
							case 29u:
								obj = 1;
								_ = 45;
								continue;
							case 5u:
								_ = 25;
								continue;
							case 8u:
							case 26u:
								if ((nint)obj >= ((Array)obj).Length)
								{
									if (6 != 0)
									{
										reference = ref *(_003CGetNetGamesAsync_003Ed__15*)7;
									}
									continue;
								}
								goto case 52u;
							case 17u:
							case 51u:
								if ((nint)Unsafe.AsPointer(ref this) >= (nint)((Array)Unsafe.AsPointer(ref this)).Length)
								{
									reference = ref *(_003CGetNetGamesAsync_003Ed__15*)9;
									continue;
								}
								goto case 21u;
							case 59u:
								reference = ref this;
								if (15 != 0)
								{
									reference = ref *(_003CGetNetGamesAsync_003Ed__15*)8;
								}
								continue;
							case 28u:
								obj = 19;
								continue;
							case 10u:
								obj = (int)((double)obj / 50.0);
								reference = ref *(_003CGetNetGamesAsync_003Ed__15*)64;
								continue;
							case 62u:
								_ = 24;
								continue;
							case 38u:
								obj = (object)Unsafe.AsPointer(ref this);
								reference = ref *(_003CGetNetGamesAsync_003Ed__15*)35;
								continue;
							case 21u:
								_ = ((object[])(ref this))[ref Unsafe.As<_003CGetNetGamesAsync_003Ed__15, byte>(ref this)];
								obj = (object)Unsafe.AsPointer(ref this);
								if (1 == 0)
								{
									_ = 1;
								}
								continue;
							case 22u:
								obj = 3;
								if (32 == 0)
								{
									_ = 28;
								}
								continue;
							case 35u:
								if (&obj != null)
								{
									reference = ref *(_003CGetNetGamesAsync_003Ed__15*)2;
									continue;
								}
								goto case 29u;
							case 33u:
								if (47 == 0)
								{
									_ = 50;
								}
								continue;
							case 24u:
								obj = obj;
								if (23 == 0)
								{
									reference = ref *(_003CGetNetGamesAsync_003Ed__15*)10;
								}
								continue;
							case 54u:
								_ = ref obj;
								_ = 37;
								continue;
							case 13u:
								obj = 14;
								continue;
							case 6u:
								return;
							case 63u:
								_ = ref obj;
								_ = 12;
								continue;
							case 32u:
								_ = 54;
								continue;
							case 25u:
								obj++;
								reference = ref *(_003CGetNetGamesAsync_003Ed__15*)26;
								continue;
							case 53u:
								if (&obj == null)
								{
									reference = ref *(_003CGetNetGamesAsync_003Ed__15*)22;
									continue;
								}
								goto case 43u;
							case 14u:
								obj = -1;
								if (43 == 0)
								{
									_ = 27;
								}
								continue;
							case 4u:
								_ = ref obj;
								obj = 6;
								continue;
							case 20u:
								break;
							case 7u:
								obj = (object)Unsafe.AsPointer(ref this);
								reference = ref *(_003CGetNetGamesAsync_003Ed__15*)16;
								continue;
							case 37u:
								return;
							case 39u:
								_ = 55;
								continue;
							case 34u:
								if (&obj == null)
								{
									reference = ref *(_003CGetNetGamesAsync_003Ed__15*)57;
									continue;
								}
								goto case 58u;
							case 55u:
								obj = -1;
								_ = 18;
								continue;
							case 65u:
								if (obj != null)
								{
									reference = ref *(_003CGetNetGamesAsync_003Ed__15*)31;
									continue;
								}
								goto default;
							case 58u:
								obj = (object)(&obj);
								if (28 != 0)
								{
									reference = ref *(_003CGetNetGamesAsync_003Ed__15*)36;
								}
								continue;
							case 16u:
								while (true)
								{
									IL_050d:
									if (&obj == null)
									{
										if (false)
										{
											_ = 0;
										}
										goto IL_04b6;
									}
									goto IL_04f1;
									IL_04f1:
									obj = (object)(&obj);
									if (3 == 0)
									{
										_ = 0;
									}
									goto IL_04b6;
									IL_04b6:
									while (true)
									{
										switch ((int)/*Error near IL_04cb: Stack underflow*/)
										{
										case 3:
											if (0 == 0)
											{
												_ = 1;
											}
											continue;
										case 2:
											goto IL_04f1;
										case 1:
											goto IL_050d;
										}
										break;
									}
									break;
								}
								goto case 62u;
							case 45u:
								_ = 30;
								continue;
							case 66u:
								Unsafe.AddByteOffset(ref this, 1);
								if (15 != 0)
								{
									_ = 17;
								}
								continue;
							case 49u:
								return;
							default:
								obj = 0;
								_ = 34;
								continue;
							case 43u:
								obj = (object)(&obj);
								obj = (object)/*Error near IL_05e3: Stack underflow*/;
								reference = ref *(_003CGetNetGamesAsync_003Ed__15*)11;
								continue;
							case 2u:
							case 42u:
								_ = ref obj;
								if (3 == 0)
								{
									reference = ref *(_003CGetNetGamesAsync_003Ed__15*)33;
								}
								continue;
							case 3u:
								goto IL_0608;
							case 46u:
								obj = 4;
								continue;
							case 18u:
							case 56u:
								obj = (object)(&obj);
								if (18 != 0)
								{
									reference = ref *(_003CGetNetGamesAsync_003Ed__15*)28;
								}
								continue;
							case 36u:
								if (8 != 0)
								{
									_ = 10;
								}
								continue;
							case 31u:
								obj = obj;
								reference = ref *(_003CGetNetGamesAsync_003Ed__15*)60;
								continue;
							case 44u:
								_ = 63;
								continue;
							case 40u:
								goto IL_069a;
							case 30u:
								_ = ref obj;
								_ = 49;
								continue;
							case 64u:
								_ = 1;
								_ = obj - 1;
								if (38 == 0)
								{
									_ = 30;
								}
								continue;
							case 9u:
								_ = null;
								if (50 == 0)
								{
									_ = 61;
								}
								continue;
							case 19u:
								_ = null;
								_ = 66;
								continue;
							case 15u:
								obj = -1;
								if (58 == 0)
								{
									_ = 25;
								}
								continue;
							case 1u:
								if (&obj != null)
								{
									reference = ref *(_003CGetNetGamesAsync_003Ed__15*)56;
									continue;
								}
								goto case 48u;
							case 27u:
								goto IL_0740;
							case 12u:
								return;
							case 57u:
								obj = 0;
								_ = 46;
								continue;
							case 50u:
								_ = 0;
								if (51 == 0)
								{
									_ = 32;
								}
								continue;
							case 41u:
								reference = ref this;
								if (47 != 0)
								{
									reference = ref *(_003CGetNetGamesAsync_003Ed__15*)41;
								}
								continue;
							case 61u:
							{
								object obj3 = obj;
								ref _003CGetNetGamesAsync_003Ed__15 reference2 = ref this;
								if (Unsafe.AsPointer(ref reference2) == null)
								{
									reference2 = ref *(_003CGetNetGamesAsync_003Ed__15*)obj3;
								}
								obj = 24;
								_ = 53;
								continue;
							}
							case 23u:
							case 60u:
								goto end_IL_0046;
							}
							break;
						}
						goto case 2;
						IL_0740:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(_003CGetNetGamesAsync_003Ed__15*)59;
						goto IL_0069;
						IL_069a:
						obj = (object)Unsafe.AsPointer(ref this);
						if (12 == 0)
						{
							reference = ref *(_003CGetNetGamesAsync_003Ed__15*)13;
						}
						goto IL_0069;
						IL_0608:
						obj = (object)Unsafe.AsPointer(ref this);
						if (41 == 0)
						{
							reference = ref *(_003CGetNetGamesAsync_003Ed__15*)36;
						}
						goto IL_0069;
						end_IL_0046:
						break;
					}
					break;
				}
				case 7:
					return;
				case 5:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 4;
					continue;
				case 3:
					_ = null;
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
				case 1:
					_ = null;
					if (3 == 0)
					{
						_ = 3;
					}
					continue;
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 == 0)
					{
						obj2 = 2;
					}
					continue;
				default:
					_ = 7;
					continue;
				case 6:
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
		private unsafe sealed void _FF00_FF00_FF00_F400()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779070, new IntPtr(2737336613596L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_F500(object P_0)
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00豈()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_005f: Expected Obj, but got Ref
			//IL_007a: Expected Obj, but got Ref
			//IL_028e: Expected Obj, but got Ref
			//IL_0221: Expected Obj, but got I4
			//IL_029d: Expected Obj, but got I4
			//IL_02a7: Expected Obj, but got I4
			//IL_01b0: Expected Obj, but got I4
			//IL_020d: Expected Obj, but got I4
			//IL_01e7: Expected Obj, but got Ref
			//IL_0192: Expected Obj, but got Ref
			//IL_024a: Expected Obj, but got I4
			//IL_039c: Expected Obj, but got Ref
			//IL_0340: Expected Obj, but got I4
			//IL_0273: Expected Obj, but got Ref
			//IL_035c: Expected Obj, but got I4
			//IL_046a->IL0019: Incompatible stack heights: 3 vs 1
			//IL_006b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0086->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0050->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0478->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0076->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0091->IL0019: Incompatible stack types: I4 vs Obj
			//IL_005b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0298->IL00b4: Incompatible stack heights: 1 vs 0
			//IL_00b0->IL00b4: Incompatible stack heights: 1 vs 0
			//IL_0178->IL00b4: Incompatible stack heights: 1 vs 0
			//IL_032a->IL00b4: Incompatible stack heights: 2 vs 0
			//IL_02ac->IL00b0: Incompatible stack heights: 2 vs 3
			//IL_02bc->IL00b4: Incompatible stack heights: 2 vs 0
			//IL_031d->IL00b4: Incompatible stack heights: 3 vs 0
			//IL_0304->IL00b4: Incompatible stack heights: 2 vs 0
			//IL_01bd->IL00b4: Incompatible stack heights: 2 vs 0
			//IL_01ab->IL00b4: Incompatible stack heights: 3 vs 0
			//IL_019c->IL00b4: Incompatible stack heights: 4 vs 0
			//IL_0389->IL00b4: Incompatible stack heights: 2 vs 0
			//IL_0255->IL00b4: Incompatible stack heights: 3 vs 0
			//IL_03a8->IL00b4: Incompatible stack heights: 1 vs 0
			//IL_034c->IL00b4: Incompatible stack heights: 5 vs 0
			//IL_01d7->IL00b4: Incompatible stack heights: 1 vs 0
			//IL_0264->IL00b4: Incompatible stack heights: 1 vs 0
			//IL_0367->IL00b4: Incompatible stack heights: 3 vs 0
			//IL_00b4->IL00b4: Incompatible stack heights: 4 vs 0
			//IL_02c7->IL00b4: Incompatible stack heights: 2 vs 0
			//IL_030f->IL00b4: Incompatible stack heights: 2 vs 0
			//IL_01c8->IL00b4: Incompatible stack heights: 2 vs 0
			//IL_01fe->IL00b4: Incompatible stack heights: 1 vs 0
			//IL_0394->IL00b4: Incompatible stack heights: 2 vs 0
			//IL_03b3->IL00b4: Incompatible stack heights: 1 vs 0
			//IL_0357->IL00b4: Incompatible stack heights: 5 vs 0
			//IL_01e2->IL00b4: Incompatible stack heights: 1 vs 0
			//IL_028a->IL00b4: Incompatible stack heights: 1 vs 0
			//IL_026f->IL00b4: Incompatible stack heights: 1 vs 0
			//IL_0245->IL00b4: Incompatible stack heights: 1 vs 0
			//IL_02e6->IL00b4: Incompatible stack heights: 1 vs 0
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
					if (5 == 0)
					{
						_ = 4;
					}
					break;
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					if (6 == 0)
					{
						obj2 = 3;
					}
					break;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 1;
					}
					break;
				case 6:
					if (obj == null)
					{
						if (21 == 0)
						{
							_ = 20;
						}
						goto IL_00b4;
					}
					goto IL_0159;
				default:
					goto IL_045c;
				case 5:
					return;
				case 4:
					{
						_ = null;
						_ = 3;
						break;
					}
					IL_045c:
					_ = -2;
					_ = 4;
					break;
					IL_0159:
					if ((nint)obj != 1)
					{
						if (13 != 0)
						{
							_ = 7;
						}
						goto IL_00b4;
					}
					goto IL_028a;
					IL_028a:
					obj = (object)Unsafe.AsPointer(ref this);
					_ = 23;
					goto IL_00b4;
					IL_00b4:
					while (true)
					{
						scoped ref _003CGetOwnedSkinsAsync_003Ed__23 reference;
						scoped ref object reference2;
						scoped ref _003CGetOwnedSkinsAsync_003Ed__23 reference3;
						switch ((int)/*Error near IL_0129: Stack underflow*/)
						{
						case 17:
							return;
						case 26:
							break;
						case 8:
							return;
						case 14:
							/*Error near IL_0188: Stack underflow*/;
							obj = (object)Unsafe.AsPointer(ref this);
							_ = 10;
							continue;
						case 13:
							_ = 1;
							_ = 22;
							continue;
						case 7:
							obj = -1;
							if (25 != 0)
							{
								_ = 5;
							}
							continue;
						case 23:
							if (7 == 0)
							{
								_ = 6;
							}
							continue;
						default:
							obj = (object)(&obj);
							if (6 == 0)
							{
								_ = 6;
							}
							continue;
						case 9:
							reference = ref this;
							reference2 = ref obj;
							reference3 = ref this;
							obj = 17;
							continue;
						case 2:
							reference = ref this;
							reference2 = ref obj;
							reference3 = ref this;
							obj = 8;
							continue;
						case 15:
							if (&obj == null)
							{
								if (15 != 0)
								{
									_ = 27;
								}
								continue;
							}
							goto case 25;
						case 18:
							obj = -1;
							_ = 12;
							continue;
						case 25:
							_ = ref obj;
							if (14 == 0)
							{
								_ = 10;
							}
							continue;
						case 21:
						case 24:
							obj = (object)Unsafe.AsPointer(ref this);
							if (1 == 0)
							{
								_ = 1;
							}
							continue;
						case 11:
							goto IL_028a;
						case 3:
							obj = 0;
							obj = 5;
							continue;
						case 4:
							if (4 == 0)
							{
								_ = 9;
							}
							continue;
						case 19:
							if (&obj != null)
							{
								if (false)
								{
									_ = 0;
								}
								continue;
							}
							goto case 3;
						case 6:
							_ = (int)((double)obj / 20.0);
							if (16 == 0)
							{
								_ = 14;
							}
							continue;
						case 5:
							_ = 2;
							continue;
						case 1:
							_ = 18;
							continue;
						case 22:
							_ = (nint)Unsafe.AsPointer(ref Unsafe.SubtractByteOffset(ref this, 1)) * (nint)20;
							_ = 20;
							obj = 1;
							if (19 != 0)
							{
								_ = 6;
							}
							continue;
						case 27:
							obj = 1;
							_ = 4;
							continue;
						case 16:
							if (20 != 0)
							{
								_ = 8;
							}
							continue;
						case 20:
							obj = (object)Unsafe.AsPointer(ref this);
							if (15 == 0)
							{
								_ = 15;
							}
							continue;
						case 10:
							goto IL_045c;
						}
						break;
					}
					goto IL_0159;
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
		private sealed void _FF00_FF00_FF00_EB00(object P_0)
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_005a: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_0160: Expected Obj, but got Ref
			//IL_00cf: Expected Obj, but got Ref
			//IL_0144: Expected Obj, but got I4
			//IL_0134: Expected Obj, but got I4
			//IL_01b2: Expected Obj, but got I4
			//IL_0066->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0257->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0267->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0071->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0272->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0177->IL0094: Incompatible stack heights: 1 vs 0
			//IL_0090->IL0094: Incompatible stack heights: 1 vs 0
			//IL_0151->IL0094: Incompatible stack heights: 2 vs 0
			//IL_011d->IL0094: Incompatible stack heights: 2 vs 0
			//IL_00f6->IL0094: Incompatible stack heights: 2 vs 0
			//IL_013f->IL0094: Incompatible stack heights: 3 vs 0
			//IL_0189->IL0094: Incompatible stack heights: 3 vs 0
			//IL_00e6->IL0094: Incompatible stack heights: 1 vs 0
			//IL_012f->IL0094: Incompatible stack heights: 1 vs 0
			//IL_015c->IL0094: Incompatible stack heights: 2 vs 0
			//IL_01aa->IL01ac: Incompatible stack heights: 5 vs 4
			//IL_0101->IL0094: Incompatible stack heights: 2 vs 0
			//IL_0194->IL0094: Incompatible stack heights: 3 vs 0
			//IL_01be->IL0094: Incompatible stack heights: 4 vs 0
			//IL_01c9->IL0094: Incompatible stack heights: 4 vs 0
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
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				default:
					obj = (object)Unsafe.AsPointer(ref this);
					if (4 == 0)
					{
						obj2 = 4;
					}
					continue;
				case 4:
					if (obj != null)
					{
						if (4 != 0)
						{
							_ = 1;
						}
						goto IL_0094;
					}
					goto IL_015c;
				case 3:
					return;
				case 2:
					_ = 3;
					continue;
				case 5:
					break;
					IL_0094:
					while (true)
					{
						switch ((int)/*Error near IL_00c5: Stack underflow*/)
						{
						case 1:
							obj = (object)(&obj);
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 7:
							if (4 == 0)
							{
								_ = 9;
							}
							continue;
						case 6:
							return;
						case 5:
							_ = 3;
							continue;
						case 2:
							if (&obj == null)
							{
								_ = 8;
								continue;
							}
							goto case 1;
						case 8:
							obj = 0;
							_ = 7;
							continue;
						case 3:
							obj = -1;
							if (true)
							{
								_ = 1;
							}
							continue;
						case 10:
							break;
						case 9:
							_ = ref obj;
							if (false)
							{
								_ = 6;
							}
							continue;
						case 4:
							if (Unsafe.AsPointer(ref this) != null)
							{
							}
							obj = 1;
							if (2 != 0)
							{
								_ = 2;
							}
							continue;
						default:
							goto end_IL_0019;
						}
						break;
					}
					goto IL_015c;
					IL_015c:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 == 0)
					{
						_ = 5;
					}
					goto IL_0094;
					end_IL_0019:
					break;
				}
				_ = -2;
				if (1 == 0)
				{
					_ = 2;
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
		private sealed void _FF00_FF00_FF00_E200(object P_0)
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
		internal unsafe static byte _FF00_FF00_FF00_E300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779043, new IntPtr(2737336626076L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_E400()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_E500()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0236: Expected Obj, but got Ref
			//IL_0244: Expected Obj, but got Ref
			//IL_01aa: Expected Obj, but got Ref
			//IL_00d4: Expected Obj, but got I4
			//IL_00b7: Expected Obj, but got I4
			//IL_010b: Expected Obj, but got Ref
			//IL_019c: Expected Obj, but got I4
			//IL_0049->IL0019: Incompatible stack heights: 3 vs 1
			//IL_005a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0240->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0250->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0065->IL0019: Incompatible stack heights: 2 vs 1
			//IL_01b4->IL007c: Incompatible stack types: I4 vs Ref
			//IL_0078->IL007c: Incompatible stack types: I4 vs Ref
			//IL_025b->IL0019: Incompatible stack types: I4 vs Obj
			//IL_00e1->IL007c: Incompatible stack heights: 2 vs 1
			//IL_017d->IL007c: Incompatible stack heights: 3 vs 1
			//IL_00c4->IL007c: Incompatible stack heights: 2 vs 1
			//IL_0117->IL007c: Incompatible stack heights: 0 vs 1
			//IL_014c->IL007c: Incompatible stack heights: 3 vs 1
			//IL_01a6->IL007c: Incompatible stack heights: 8 vs 1
			//IL_00ec->IL007c: Incompatible stack heights: 2 vs 1
			//IL_0106->IL007c: Incompatible stack types: I4 vs Ref
			//IL_0188->IL007c: Incompatible stack heights: 3 vs 1
			//IL_0160->IL007c: Incompatible stack heights: 0 vs 1
			//IL_00cf->IL007c: Incompatible stack heights: 2 vs 1
			//IL_0122->IL007c: Incompatible stack types: I4 vs Ref
			//IL_016b->IL007c: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			object obj2 = obj;
			while (true)
			{
				ref _003CGetRentalGameCharactersAsync_003Ed__43 reference;
				switch ((int)obj2)
				{
				default:
					return;
				case 1:
					_ = -2;
					_ = 2;
					break;
				case 2:
					if (false)
					{
						_ = 0;
					}
					break;
				case 0:
					return;
				case 3:
					if (obj != null)
					{
						reference = ref *(_003CGetRentalGameCharactersAsync_003Ed__43*)10;
						goto IL_007c;
					}
					goto IL_01a6;
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 3;
					break;
				case 5:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (4 == 0)
						{
							obj2 = 1;
						}
						break;
					}
					IL_01a6:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CGetRentalGameCharactersAsync_003Ed__43*)2;
					goto IL_007c;
					IL_007c:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 1u:
							break;
						case 3u:
							return;
						case 6u:
							obj = -1;
							if (2 == 0)
							{
								_ = 8;
							}
							continue;
						default:
							obj = 0;
							if (9 == 0)
							{
								_ = 4;
							}
							continue;
						case 2u:
							reference = ref this;
							if (1 == 0)
							{
								reference = ref *(_003CGetRentalGameCharactersAsync_003Ed__43*)6;
							}
							continue;
						case 8u:
							obj = (object)(&obj);
							if (true)
							{
								reference = ref *(_003CGetRentalGameCharactersAsync_003Ed__43*)null;
							}
							continue;
						case 9u:
							_ = 4;
							continue;
						case 5u:
							if (&obj == null)
							{
								if (0 == 0)
								{
									reference = ref *(_003CGetRentalGameCharactersAsync_003Ed__43*)null;
								}
								continue;
							}
							goto case 8u;
						case 4u:
							_ = ref obj;
							if (3 == 0)
							{
								_ = 1;
							}
							continue;
						case 10u:
							_ = 0;
							_ = 10;
							obj = 1;
							_ = 5;
							continue;
						case 7u:
							goto IL_01a6;
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
		private sealed void _FF00_FF00_FF00_FFFD(object P_0)
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FFFD()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_023c: Expected Obj, but got Ref
			//IL_0245: Expected Obj, but got I4
			//IL_003f: Expected Obj, but got Ref
			//IL_00ff: Expected Obj, but got Ref
			//IL_00c9: Expected Obj, but got I4
			//IL_0138: Expected Obj, but got I4
			//IL_019f: Expected Obj, but got I4
			//IL_010e: Expected Obj, but got Ref
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0065->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0074->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0109->IL008a: Incompatible stack types: I4 vs Ref
			//IL_0086->IL008a: Incompatible stack types: I4 vs Ref
			//IL_00d6->IL008a: Incompatible stack heights: 2 vs 1
			//IL_015d->IL008a: Incompatible stack heights: 3 vs 1
			//IL_01ba->IL008a: Incompatible stack heights: 4 vs 1
			//IL_0144->IL008a: Incompatible stack heights: 7 vs 1
			//IL_01aa->IL008a: Incompatible stack heights: 3 vs 1
			//IL_011a->IL008a: Incompatible stack heights: 0 vs 1
			//IL_00e1->IL008a: Incompatible stack heights: 2 vs 1
			//IL_00fb->IL008a: Incompatible stack types: I4 vs Ref
			//IL_014f->IL008a: Incompatible stack heights: 7 vs 1
			//IL_019a->IL008a: Incompatible stack types: I4 vs Ref
			//IL_0125->IL008a: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					ref _003CGetRentalGamesAsync_003Ed__51 reference;
					switch ((int)obj2)
					{
					case 1:
						obj = (object)Unsafe.AsPointer(ref this);
						if (0 == 0)
						{
							obj2 = 0;
						}
						continue;
					case 3:
						return;
					case 2:
						_ = -2;
						_ = 5;
						continue;
					case 5:
						_ = 3;
						continue;
					case 4:
						{
							if (obj != null)
							{
								reference = ref *(_003CGetRentalGamesAsync_003Ed__51*)7;
								goto IL_008a;
							}
							goto IL_00fb;
						}
						IL_00fb:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(_003CGetRentalGamesAsync_003Ed__51*)6;
						goto IL_008a;
						IL_008a:
						while (true)
						{
							switch ((uint)Unsafe.AsPointer(ref reference))
							{
							case 8u:
								return;
							case 3u:
								obj = -1;
								if (5 != 0)
								{
									_ = 11;
								}
								continue;
							case 6u:
								reference = ref this;
								if (3 == 0)
								{
									reference = ref *(_003CGetRentalGamesAsync_003Ed__51*)null;
								}
								continue;
							case 1u:
								goto IL_00fb;
							case 2u:
							case 11u:
								obj = (object)(&obj);
								if (false)
								{
									reference = ref *(_003CGetRentalGamesAsync_003Ed__51*)null;
								}
								continue;
							case 7u:
								_ = 0;
								_ = 0;
								obj = 1;
								if (10 != 0)
								{
									_ = 10;
								}
								continue;
							case 4u:
								_ = 5;
								continue;
							case 10u:
								if (&obj != null)
								{
									reference = ref *(_003CGetRentalGamesAsync_003Ed__51*)2;
									continue;
								}
								goto case 9u;
							case 9u:
								obj = 0;
								_ = 4;
								continue;
							case 5u:
								_ = ref obj;
								_ = 8;
								continue;
							}
							break;
						}
						goto case 2;
					}
					break;
				}
				obj = (object)Unsafe.AsPointer(ref this);
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
		private sealed void _FF00_FF00_FF00츀(object P_0)
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_023b: Expected Obj, but got Ref
			//IL_00b3: Expected Obj, but got Ref
			//IL_0173: Expected Obj, but got I4
			//IL_013c: Expected Obj, but got Ref
			//IL_00d3: Expected Obj, but got I4
			//IL_0128: Expected Obj, but got I4
			//IL_0132: Expected Obj, but got I4
			//IL_00aa: Expected I4, but got Obj
			//IL_0256->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0245->IL0019: Incompatible stack types: I4 vs Obj
			//IL_022b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0261->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0236->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00bd->IL0079: Incompatible stack types: I4 vs Obj
			//IL_006a->IL0079: Incompatible stack heights: 0 vs 1
			//IL_0075->IL0079: Incompatible stack types: I4 vs Obj
			//IL_017e->IL0079: Incompatible stack heights: 3 vs 1
			//IL_00ca->IL0079: Incompatible stack heights: 2 vs 1
			//IL_0148->IL0079: Incompatible stack heights: 0 vs 1
			//IL_0163->IL0079: Incompatible stack heights: 2 vs 1
			//IL_0118->IL0079: Incompatible stack heights: 3 vs 1
			//IL_0153->IL0079: Incompatible stack types: I4 vs Obj
			//IL_016e->IL0079: Incompatible stack heights: 2 vs 1
			//IL_00ea->IL0079: Incompatible stack types: I4 vs Obj
			//IL_0123->IL0079: Incompatible stack heights: 3 vs 1
			//IL_0192->IL0079: Incompatible stack heights: 0 vs 1
			//IL_0079->IL0079: Incompatible stack heights: 3 vs 1
			//IL_019d->IL0079: Incompatible stack types: I4 vs Obj
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
					return;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 5;
					}
					break;
				case 5:
					if (obj != null)
					{
						if (6 == 0)
						{
							obj3 = 1;
						}
						goto IL_0079;
					}
					goto IL_00af;
				case 4:
					goto IL_021b;
				case 0:
					return;
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 2;
					break;
				case 1:
					{
						if (false)
						{
							_ = 0;
						}
						break;
					}
					IL_0079:
					while (true)
					{
						switch ((int)obj3)
						{
						case 8:
							break;
						case 2:
							_ = 10;
							continue;
						case 6:
							obj3 = obj;
							obj = 1;
							if (7 != 0)
							{
								obj3 = 9;
							}
							continue;
						case 1:
							return;
						case 7:
							_ = ref obj;
							if (0 == 0)
							{
								_ = 1;
							}
							continue;
						case 10:
							obj = -1;
							obj = 3;
							continue;
						case 3:
							obj = (object)(&obj);
							if (true)
							{
								obj3 = 4;
							}
							continue;
						case 5:
							if (7 == 0)
							{
								_ = 1;
							}
							continue;
						default:
							obj = 0;
							_ = 5;
							continue;
						case 9:
							if (&obj == null)
							{
								if (false)
								{
									obj3 = 0;
								}
								continue;
							}
							goto case 3;
						case 4:
							goto IL_021b;
						}
						break;
					}
					goto IL_00af;
					IL_021b:
					_ = -2;
					if (0 == 0)
					{
						_ = 1;
					}
					break;
					IL_00af:
					obj = (object)Unsafe.AsPointer(ref this);
					obj3 = 2;
					goto IL_0079;
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
		private sealed void _FF00_FF00_FF00였(object P_0)
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
		internal static byte _FF00_FF00_FF00윀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00저()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_023a: Expected Obj, but got Ref
			//IL_004d: Expected Obj, but got Ref
			//IL_0170: Expected Obj, but got Ref
			//IL_01ad: Expected Obj, but got I4
			//IL_0122: Expected Obj, but got Ref
			//IL_0131: Expected Obj, but got I4
			//IL_0101: Expected Obj, but got Ref
			//IL_0105: Expected Obj, but got I4
			//IL_00d8: Expected I4, but got Obj
			//IL_0244->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0059->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0049->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0075->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0019: Incompatible stack types: I4 vs Obj
			//IL_017a->IL00a3: Incompatible stack types: I4 vs Obj
			//IL_0094->IL00a3: Incompatible stack heights: 0 vs 1
			//IL_0080->IL0019: Incompatible stack heights: 2 vs 1
			//IL_009f->IL00a3: Incompatible stack types: I4 vs Obj
			//IL_00ed->IL00a3: Incompatible stack heights: 2 vs 1
			//IL_014e->IL00a3: Incompatible stack heights: 3 vs 1
			//IL_01ba->IL00a3: Incompatible stack heights: 2 vs 1
			//IL_012c->IL00a3: Incompatible stack types: I4 vs Obj
			//IL_013c->IL00a3: Incompatible stack heights: 3 vs 1
			//IL_0199->IL00a3: Incompatible stack heights: 2 vs 1
			//IL_00f8->IL00a3: Incompatible stack heights: 2 vs 1
			//IL_018c->IL00a3: Incompatible stack types: I4 vs Obj
			//IL_0159->IL00a3: Incompatible stack heights: 3 vs 1
			//IL_01c5->IL00a3: Incompatible stack heights: 2 vs 1
			//IL_011c->IL00a3: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				case 3:
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
				case 5:
					if (2 == 0)
					{
						_ = 2;
					}
					break;
				case 4:
					if (obj != null)
					{
						if (4 == 0)
						{
							obj3 = 11;
						}
						goto IL_00a3;
					}
					goto IL_016c;
				default:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 4;
					break;
				case 2:
					return;
					IL_016c:
					obj = (object)Unsafe.AsPointer(ref this);
					obj3 = 9;
					goto IL_00a3;
					IL_00a3:
					while (true)
					{
						switch ((int)obj3)
						{
						case 5:
							break;
						default:
							if (3 != 0)
							{
								_ = 1;
							}
							continue;
						case 11:
							obj3 = obj;
							((object[])1)[0] = (object)Unsafe.AsPointer(ref this);
							obj = 1;
							if (1 == 0)
							{
								obj3 = 1;
							}
							continue;
						case 7:
						case 10:
							obj = (object)(&obj);
							obj3 = 5;
							continue;
						case 8:
							obj = -1;
							_ = 7;
							continue;
						case 3:
							_ = ref obj;
							if (4 != 0)
							{
								_ = 4;
							}
							continue;
						case 4:
							return;
						case 2:
							goto IL_016c;
						case 1:
							if (&obj != null)
							{
								obj3 = 10;
								continue;
							}
							goto case 6;
						case 9:
							_ = 8;
							continue;
						case 6:
							obj = 0;
							if (false)
							{
								_ = 0;
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
		private sealed void _FF00_FF00_FF00밀(object P_0)
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_004d: Expected Obj, but got Ref
			//IL_0076: Expected Obj, but got Ref
			//IL_02aa: Expected Obj, but got Ref
			//IL_0371: Expected Obj, but got I4
			//IL_0189: Expected Obj, but got I4
			//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cc: Expected Obj, but got Unknown
			//IL_0311: Expected Obj, but got I4
			//IL_029d: Expected Obj, but got I4
			//IL_024f: Expected Obj, but got I4
			//IL_0191: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Expected Obj, but got Unknown
			//IL_01f2: Expected Obj, but got I4
			//IL_012e: Expected Obj, but got Ref
			//IL_034e: Expected Obj, but got Ref
			//IL_028f: Expected Obj, but got I4
			//IL_014b: Expected Obj, but got Ref
			//IL_0072->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0059->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0082->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0048->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0019: Incompatible stack types: I4 vs Obj
			//IL_008d->IL0019: Incompatible stack types: I4 vs Obj
			//IL_00ac->IL00b0: Incompatible stack heights: 1 vs 0
			//IL_037b->IL00b0: Incompatible stack heights: 3 vs 0
			//IL_0369->IL0369: Incompatible stack types: Obj vs Ref
			//IL_02c6->IL00b0: Incompatible stack heights: 1 vs 0
			//IL_026e->IL00b0: Incompatible stack heights: 4 vs 0
			//IL_0226->IL00b0: Incompatible stack heights: 4 vs 0
			//IL_02d6->IL00b0: Incompatible stack heights: 1 vs 0
			//IL_01d7->IL00b0: Incompatible stack heights: 2 vs 0
			//IL_0179->IL00b0: Incompatible stack heights: 4 vs 0
			//IL_0328->IL00b0: Incompatible stack heights: 2 vs 0
			//IL_031b->IL00b0: Incompatible stack heights: 1 vs 0
			//IL_02a7->IL00b0: Incompatible stack heights: 1 vs 0
			//IL_025a->IL00b0: Incompatible stack heights: 3 vs 0
			//IL_0358->IL00b0: Incompatible stack heights: 1 vs 0
			//IL_029a->IL00b0: Incompatible stack heights: 3 vs 0
			//IL_0157->IL00b0: Incompatible stack heights: 1 vs 0
			//IL_00b0->IL00b0: Incompatible stack heights: 1 vs 0
			//IL_0169->IL00b0: Incompatible stack heights: 1 vs 0
			//IL_01e2->IL00b0: Incompatible stack heights: 2 vs 0
			//IL_024a->IL00b0: Incompatible stack heights: 1 vs 0
			//IL_01ab->IL00b0: Incompatible stack heights: 1 vs 0
			//IL_0145->IL00b0: Incompatible stack heights: 1 vs 0
			//IL_034a->IL00b0: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				scoped ref _003CGetSkinImagesAsync_003Ed__25 reference;
				switch ((int)obj2)
				{
				case 4:
					_ = 5;
					break;
				case 5:
					return;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						obj2 = 0;
					}
					break;
				default:
					_ = -2;
					_ = 4;
					break;
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 != 0)
					{
						obj2 = 2;
					}
					break;
				case 1:
					{
						if (obj == null)
						{
							if (0 == 0)
							{
								_ = 0;
							}
							goto IL_00b0;
						}
						goto IL_02a7;
					}
					IL_00b0:
					while (true)
					{
						switch ((int)/*Error near IL_0125: Stack underflow*/)
						{
						case 10:
							return;
						case 15:
						case 24:
							break;
						default:
							obj = (object)Unsafe.AsPointer(ref this);
							if (8 == 0)
							{
								_ = 3;
							}
							continue;
						case 11:
						case 27:
							obj = (object)(&obj);
							obj = (object)/*Error near IL_014d: Stack underflow*/;
							_ = 12;
							continue;
						case 4:
							if (&obj != null)
							{
								_ = 11;
								continue;
							}
							goto case 25;
						case 7:
							_ = ref obj;
							_ = 10;
							continue;
						case 1:
							obj = ((object[])obj)[obj];
							obj = 3;
							continue;
						case 19:
							obj++;
							if (14 == 0)
							{
								_ = 2;
							}
							continue;
						case 6:
							if (3 != 0)
							{
								_ = 7;
							}
							continue;
						case 20:
							obj = ((object[])obj)[obj];
							obj = 2;
							continue;
						case 3:
							_ = 5;
							continue;
						case 13:
						case 14:
							if ((nint)obj >= ((Array)obj).Length)
							{
								_ = 15;
								continue;
							}
							goto case 20;
						case 17:
							obj = -1;
							_ = 27;
							continue;
						case 2:
							_ = 19;
							continue;
						case 25:
							obj = 0;
							_ = 6;
							continue;
						case 12:
							obj = 0;
							_ = 26;
							continue;
						case 16:
							goto IL_02a7;
						case 5:
							obj++;
							_ = 18;
							continue;
						case 9:
							obj = 0;
							_ = 13;
							continue;
						case 8:
							_ = 17;
							continue;
						case 18:
						case 26:
							if ((nint)obj >= ((Array)obj).Length)
							{
								if (23 == 0)
								{
									_ = 3;
								}
								continue;
							}
							goto case 1;
						case 23:
							obj = (object)Unsafe.AsPointer(ref this);
							_ = 9;
							continue;
						case 21:
							goto IL_0358;
						}
						break;
					}
					goto default;
					IL_02a7:
					if (((Array)Unsafe.AsPointer(ref this)).Length == 0)
					{
						if (11 != 0)
						{
							_ = 24;
						}
						goto IL_00b0;
					}
					goto IL_0358;
					IL_0358:
					obj3 = obj;
					reference = ref this;
					if (Unsafe.AsPointer(ref reference) == null)
					{
						reference = ref *(_003CGetSkinImagesAsync_003Ed__25*)obj3;
					}
					obj = 11;
					_ = 4;
					goto IL_00b0;
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
		private sealed void _FF00_FF00_FF00눀(object P_0)
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_005d: Expected Obj, but got Ref
			//IL_0066: Expected Obj, but got I4
			//IL_0494: Expected Obj, but got Ref
			//IL_016c: Expected Obj, but got Ref
			//IL_02ee: Expected Obj, but got Ref
			//IL_03ed: Expected Obj, but got I4
			//IL_0183: Expected Obj, but got I4
			//IL_019c: Expected Obj, but got I4
			//IL_03de: Expected Obj, but got I4
			//IL_01d8: Expected Obj, but got Ref
			//IL_02b2: Expected Obj, but got I4
			//IL_0213: Expected Obj, but got Ref
			//IL_0143: Expected Obj, but got I4
			//IL_033a: Expected Obj, but got I4
			//IL_0097->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004e->IL0019: Incompatible stack heights: 2 vs 1
			//IL_007b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_049e->IL0019: Incompatible stack types: I4 vs Obj
			//IL_00a2->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0059->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0086->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00b4->IL00b8: Incompatible stack types: I4 vs Ref
			//IL_0176->IL00b8: Incompatible stack types: I4 vs Ref
			//IL_0268->IL00b8: Incompatible stack heights: 0 vs 1
			//IL_0273->IL00b8: Incompatible stack types: I4 vs Ref
			//IL_02f8->IL00b8: Incompatible stack heights: 2 vs 1
			//IL_02db->IL00b8: Incompatible stack heights: 2 vs 1
			//IL_039b->IL00b8: Incompatible stack heights: 3 vs 1
			//IL_03f8->IL00b8: Incompatible stack heights: 3 vs 1
			//IL_01a9->IL00b8: Incompatible stack heights: 2 vs 1
			//IL_0249->IL00b8: Incompatible stack heights: 2 vs 1
			//IL_03e8->IL00b8: Incompatible stack heights: 6 vs 1
			//IL_01e2->IL00b8: Incompatible stack types: I4 vs Ref
			//IL_0305->IL00b8: Incompatible stack heights: 2 vs 1
			//IL_040e->IL00b8: Incompatible stack heights: 4 vs 1
			//IL_02bf->IL00b8: Incompatible stack heights: 2 vs 1
			//IL_036b->IL00b8: Incompatible stack heights: 3 vs 1
			//IL_021f->IL00b8: Incompatible stack heights: 0 vs 1
			//IL_0312->IL03c8: Incompatible stack heights: 2 vs 0
			//IL_020f->IL00b8: Incompatible stack heights: 3 vs 1
			//IL_02a2->IL00b8: Incompatible stack heights: 2 vs 1
			//IL_014e->IL00b8: Incompatible stack heights: 3 vs 1
			//IL_01c8->IL00b8: Incompatible stack heights: 3 vs 1
			//IL_02e6->IL00b8: Incompatible stack heights: 2 vs 1
			//IL_03a6->IL00b8: Incompatible stack heights: 3 vs 1
			//IL_00b8->IL00b8: Incompatible stack heights: 3 vs 1
			//IL_01b4->IL00b8: Incompatible stack heights: 2 vs 1
			//IL_0254->IL00b8: Incompatible stack heights: 2 vs 1
			//IL_0359->IL00b8: Incompatible stack types: I4 vs Ref
			//IL_02ca->IL00b8: Incompatible stack heights: 2 vs 1
			//IL_0376->IL00b8: Incompatible stack heights: 3 vs 1
			//IL_01f6->IL00b8: Incompatible stack heights: 0 vs 1
			//IL_022a->IL00b8: Incompatible stack types: I4 vs Ref
			//IL_031e->IL00b8: Incompatible stack heights: 2 vs 1
			//IL_0168->IL00b8: Incompatible stack types: I4 vs Ref
			//IL_02ad->IL00b8: Incompatible stack heights: 2 vs 1
			//IL_033f->IL00b4: Incompatible stack heights: 0 vs 2
			//IL_01d3->IL00b8: Incompatible stack heights: 3 vs 1
			//IL_0201->IL00b8: Incompatible stack types: I4 vs Ref
			//IL_0329->IL00b8: Incompatible stack heights: 2 vs 1
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
					case 1:
						_ = null;
						if (0 == 0)
						{
							_ = 0;
						}
						continue;
					case 4:
						break;
					case 2:
						_ = -2;
						if (true)
						{
							_ = 0;
						}
						continue;
					default:
						if (5 != 0)
						{
							_ = 6;
						}
						continue;
					case 3:
						if (obj == null)
						{
							reference = ref *(byte*)3;
							goto IL_00b8;
						}
						goto IL_0254;
					case 5:
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 4;
						continue;
					case 6:
						return;
						IL_0254:
						if ((nint)obj != 1)
						{
							if (0 == 0)
							{
								reference = ref *(byte*)4;
							}
							goto IL_00b8;
						}
						goto IL_0168;
						IL_0168:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(byte*)24;
						goto IL_00b8;
						IL_00b8:
						while (true)
						{
							switch ((uint)Unsafe.AsPointer(ref reference))
							{
							case 22u:
								break;
							case 29u:
								obj = -1;
								_ = 12;
								continue;
							case 24u:
								reference = ref Unsafe.As<_003CGetSkinsAsync_003Ed__20, byte>(ref this);
								if (2 == 0)
								{
									reference = ref *(byte*)16;
								}
								continue;
							case 20u:
								goto IL_0168;
							case 7u:
								obj = 17;
								continue;
							case 1u:
								return;
							case 9u:
								obj = 0;
								if (9 == 0)
								{
									_ = 25;
								}
								continue;
							case 23u:
							case 30u:
								if (3 != 0)
								{
									_ = 15;
								}
								continue;
							default:
								obj = (object)(&obj);
								reference = ref *(byte*)10;
								continue;
							case 18u:
								if (&obj != null)
								{
									if (0 == 0)
									{
										reference = ref *(byte*)null;
									}
									continue;
								}
								goto case 9u;
							case 25u:
								_ = 5;
								continue;
							case 3u:
							case 19u:
								obj = (object)Unsafe.AsPointer(ref this);
								if (13 != 0)
								{
									reference = ref *(byte*)8;
								}
								continue;
							case 10u:
								_ = (int)((double)obj / 20.0);
								if (26 == 0)
								{
									_ = 10;
								}
								continue;
							case 28u:
								goto IL_0254;
							case 26u:
								if (2 == 0)
								{
									_ = 0;
								}
								continue;
							case 16u:
								obj = -1;
								if (2 != 0)
								{
									_ = 14;
								}
								continue;
							case 4u:
								_ = 1;
								if (7 != 0)
								{
									_ = 21;
								}
								continue;
							case 2u:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 27;
								continue;
							case 13u:
								_ = 29;
								continue;
							case 21u:
								if (Unsafe.AsPointer(ref this) != null)
								{
									if (7 == 0)
									{
										_ = 23;
									}
									continue;
								}
								goto case 11u;
							case 27u:
								if (&obj == null)
								{
									obj = 6;
									continue;
								}
								goto case 14u;
							case 14u:
								reference = ref *(byte*)(&obj);
								if (12 == 0)
								{
									reference = ref *(byte*)30;
								}
								continue;
							case 17u:
								_ = ref obj;
								if (4 == 0)
								{
									_ = 8;
								}
								continue;
							case 5u:
								_ = ref obj;
								if (1 == 0)
								{
									_ = 0;
								}
								continue;
							case 8u:
								return;
							case 11u:
								_ = (nint)Unsafe.AsPointer(ref Unsafe.SubtractByteOffset(ref this, 1)) * (nint)20;
								_ = 20;
								obj = 1;
								_ = 18;
								continue;
							case 6u:
								obj = 1;
								_ = 7;
								continue;
							case 15u:
								/*Error near IL_03f9: Stack underflow*/;
								obj = obj;
								_ = 22;
								continue;
							}
							break;
						}
						goto case 2;
					}
					break;
				}
				obj = (object)Unsafe.AsPointer(ref this);
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
		private sealed void _FF00_FF00_FF00_AB00(object P_0)
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
		internal static byte _FF00_FF00_FF00가()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00관()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_024f: Expected Obj, but got Ref
			//IL_026a: Expected Obj, but got Ref
			//IL_00ad: Expected Obj, but got I4
			//IL_0093: Expected Obj, but got Ref
			//IL_00f4: Expected Obj, but got I4
			//IL_0121: Expected Obj, but got Ref
			//IL_0111: Expected Obj, but got I4
			//IL_023b->IL0019: Incompatible stack heights: 3 vs 1
			//IL_025b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0276->IL0019: Incompatible stack heights: 0 vs 1
			//IL_024a->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0266->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0281->IL0019: Incompatible stack types: I4 vs Obj
			//IL_004d->IL0051: Incompatible stack heights: 1 vs 4
			//IL_008a->IL009d: Incompatible stack heights: 3 vs 0
			//IL_00c4->IL0051: Incompatible stack types: I4 vs Ref
			//IL_009d->IL0051: Incompatible stack types: I4 vs Ref
			//IL_01ab->IL0051: Incompatible stack heights: 6 vs 4
			//IL_0173->IL0051: Incompatible stack heights: 6 vs 4
			//IL_0101->IL0051: Incompatible stack heights: 5 vs 4
			//IL_012d->IL0051: Incompatible stack heights: 3 vs 4
			//IL_011c->IL0051: Incompatible stack heights: 6 vs 4
			//IL_0192->IL0051: Incompatible stack heights: 3 vs 4
			//IL_017e->IL0051: Incompatible stack heights: 6 vs 4
			//IL_010c->IL0051: Incompatible stack heights: 5 vs 4
			//IL_0138->IL0051: Incompatible stack heights: 3 vs 4
			//IL_0152->IL0051: Incompatible stack types: I4 vs Ref
			//IL_019d->IL0051: Incompatible stack heights: 3 vs 4
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				scoped ref _003CGetSkinsByIdAsync_003Ed__22 reference;
				switch ((int)obj2)
				{
				case 5:
					if (obj == null)
					{
						_ = 6;
						goto IL_0051;
					}
					goto IL_009d;
				default:
					goto IL_022d;
				case 3:
					_ = 4;
					break;
				case 4:
					return;
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					if (3 == 0)
					{
						obj2 = 5;
					}
					break;
				case 2:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (1 == 0)
						{
							obj2 = 0;
						}
						break;
					}
					IL_009d:
					reference = ref this;
					obj = 1;
					if (0 == 0)
					{
						reference = ref *(_003CGetSkinsByIdAsync_003Ed__22*)1;
					}
					goto IL_0051;
					IL_022d:
					_ = -2;
					_ = 3;
					break;
					IL_0051:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						default:
							return;
						case 2u:
						case 6u:
							obj = (object)Unsafe.AsPointer(ref this);
							reference = ref *(_003CGetSkinsByIdAsync_003Ed__22*)10;
							continue;
						case 11u:
							break;
						case 7u:
							obj = -1;
							if (9 == 0)
							{
								_ = 7;
							}
							continue;
						case 12u:
							obj = 0;
							_ = 3;
							continue;
						case 5u:
						case 9u:
							obj = (object)(&obj);
							if (5 != 0)
							{
								_ = 8;
							}
							continue;
						case 10u:
							reference = ref this;
							if (2 == 0)
							{
								reference = ref *(_003CGetSkinsByIdAsync_003Ed__22*)7;
							}
							continue;
						case 0u:
							return;
						case 4u:
							_ = ref obj;
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 1u:
							if (&obj != null)
							{
								if (2 != 0)
								{
									_ = 5;
								}
								continue;
							}
							goto case 12u;
						case 3u:
							_ = 4;
							continue;
						case 8u:
							goto IL_022d;
						}
						break;
					}
					goto IL_009d;
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
		private sealed void _FF00_FF00_FF00ꌀ(object P_0)
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
		internal unsafe static byte _FF00_FF00_FF00ꐀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779011, new IntPtr(2737336622956L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00ꔀ()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00ꘀ()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_02c7: Expected Obj, but got Ref
			//IL_029d: Expected Obj, but got Ref
			//IL_0170: Expected Obj, but got Ref
			//IL_0179: Expected Obj, but got I4
			//IL_012f: Expected Obj, but got I4
			//IL_0107: Expected Obj, but got I4
			//IL_0154: Expected Obj, but got I4
			//IL_0202: Expected Obj, but got Ref
			//IL_01be: Expected Obj, but got I4
			//IL_01e7: Expected Obj, but got I4
			//IL_02d3->IL0019: Incompatible stack heights: 0 vs 1
			//IL_02a7->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0298->IL0019: Incompatible stack heights: 3 vs 1
			//IL_02b8->IL0019: Incompatible stack heights: 2 vs 1
			//IL_02de->IL0019: Incompatible stack types: I4 vs Obj
			//IL_02c3->IL0019: Incompatible stack heights: 2 vs 1
			//IL_005e->IL005e: Incompatible stack heights: 1 vs 0
			//IL_005a->IL005e: Incompatible stack heights: 1 vs 0
			//IL_0134->IL005a: Incompatible stack heights: 2 vs 0
			//IL_0113->IL005e: Incompatible stack heights: 1 vs 0
			//IL_018e->IL005e: Incompatible stack heights: 4 vs 0
			//IL_00d4->IL005e: Incompatible stack heights: 2 vs 0
			//IL_0161->IL005e: Incompatible stack heights: 2 vs 0
			//IL_00e2->IL005e: Incompatible stack heights: 3 vs 0
			//IL_01cb->IL005e: Incompatible stack heights: 2 vs 0
			//IL_014f->IL005e: Incompatible stack heights: 1 vs 0
			//IL_011e->IL005e: Incompatible stack heights: 1 vs 0
			//IL_00fe->IL005e: Incompatible stack heights: 1 vs 0
			//IL_00c7->IL005e: Incompatible stack heights: 1 vs 0
			//IL_016c->IL005e: Incompatible stack heights: 2 vs 0
			//IL_0219->IL005e: Incompatible stack heights: 1 vs 0
			//IL_01fd->IL005e: Incompatible stack heights: 1 vs 0
			//IL_01d6->IL005e: Incompatible stack heights: 2 vs 0
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
					if (obj != null)
					{
						if (9 != 0)
						{
							_ = 6;
						}
						goto IL_005e;
					}
					goto IL_016c;
				case 4:
					goto IL_028a;
				case 1:
					return;
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 2;
					break;
				case 5:
					if (1 == 0)
					{
						_ = 1;
					}
					break;
				case 2:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (false)
						{
							obj2 = 0;
						}
						break;
					}
					IL_028a:
					_ = -2;
					_ = 5;
					break;
					IL_016c:
					obj = (object)Unsafe.AsPointer(ref this);
					obj = 8;
					goto IL_005e;
					IL_005e:
					while (true)
					{
						switch ((int)/*Error near IL_00a7: Stack underflow*/)
						{
						case 10:
							obj = obj;
							if (2 != 0)
							{
								_ = 2;
							}
							continue;
						case 8:
							_ = 16;
							continue;
						case 12:
							_ = 6;
							continue;
						case 9:
							obj = obj;
							if (14 == 0)
							{
								_ = 2;
							}
							continue;
						case 3:
							obj = 1;
							if (1 == 0)
							{
								_ = 0;
							}
							continue;
						default:
							obj = obj;
							obj = 10;
							continue;
						case 2:
							obj = obj;
							if (7 == 0)
							{
								_ = 7;
							}
							continue;
						case 11:
							obj = 0;
							if (6 == 0)
							{
								_ = 12;
							}
							continue;
						case 4:
							break;
						case 6:
							_ = ref obj;
							_ = 15;
							continue;
						case 15:
							return;
						case 16:
							obj = -1;
							if (13 != 0)
							{
								_ = 12;
							}
							continue;
						case 1:
							if (&obj != null)
							{
								obj = 5;
								continue;
							}
							goto case 11;
						case 14:
							if (obj == null)
							{
								_ = 3;
								continue;
							}
							goto case 2;
						case 5:
						case 13:
							obj = (object)(&obj);
							if (false)
							{
								_ = 0;
							}
							continue;
						case 7:
							goto IL_028a;
						}
						break;
					}
					goto IL_016c;
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
		private sealed void _FF00_FF00_FF00需(object P_0)
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0235: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_00e3: Expected Obj, but got Ref
			//IL_0167: Expected Obj, but got I4
			//IL_014b: Expected Obj, but got Ref
			//IL_00f2: Expected Obj, but got I4
			//IL_018d: Expected Obj, but got I4
			//IL_0057->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0226->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0241->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0231->IL0019: Incompatible stack heights: 2 vs 1
			//IL_024c->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0172->IL006d: Incompatible stack heights: 3 vs 1
			//IL_0180->IL006d: Incompatible stack heights: 3 vs 1
			//IL_0157->IL006d: Incompatible stack heights: 0 vs 1
			//IL_0117->IL006d: Incompatible stack heights: 2 vs 1
			//IL_00ff->IL006d: Incompatible stack heights: 2 vs 1
			//IL_0197->IL006d: Incompatible stack heights: 4 vs 1
			//IL_0146->IL006d: Incompatible stack heights: 4 vs 1
			//IL_012b->IL006d: Incompatible stack heights: 0 vs 1
			//IL_010a->IL006d: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				case 5:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 4;
					break;
				case 1:
					_ = -2;
					_ = 2;
					break;
				default:
					if (obj != null)
					{
						num = 9;
						goto IL_006d;
					}
					goto IL_00df;
				case 2:
					if (3 == 0)
					{
						_ = 3;
					}
					break;
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						obj2 = 0;
					}
					break;
				case 3:
					return;
					IL_006d:
					while (true)
					{
						switch (num)
						{
						case 10:
							break;
						case 2:
							return;
						case 1:
							goto IL_00df;
						case 8:
							obj = -1;
							if (true)
							{
								_ = 5;
							}
							continue;
						case 7:
							_ = 8;
							continue;
						case 6:
							if (&obj != null)
							{
								if (4 == 0)
								{
									num = 2;
								}
								continue;
							}
							goto default;
						case 11:
							_ = ref obj;
							_ = 2;
							continue;
						case 4:
						case 5:
							obj = (object)(&obj);
							if (10 == 0)
							{
								num = 7;
							}
							continue;
						default:
							obj = 0;
							_ = 3;
							continue;
						case 3:
							_ = 11;
							continue;
						case 9:
							obj = 1;
							_ = 6;
							continue;
						}
						break;
					}
					goto case 1;
					IL_00df:
					obj = (object)Unsafe.AsPointer(ref this);
					num = 7;
					goto IL_006d;
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
		private sealed void _FF00_FF00_FF00踀(object P_0)
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
		internal static byte _FF00_FF00_FF00輀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_0051: Expected Obj, but got Ref
			//IL_0088: Expected Obj, but got Ref
			//IL_01c2: Expected Obj, but got Ref
			//IL_01cb: Expected Obj, but got I4
			//IL_0156: Expected Obj, but got Ref
			//IL_01f5: Expected Obj, but got Ref
			//IL_01e2: Expected Obj, but got I4
			//IL_01ec: Expected Obj, but got I4
			//IL_01ad: Expected Obj, but got I4
			//IL_004d->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0084->IL0019: Incompatible stack heights: 3 vs 1
			//IL_005d->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0092->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0077->IL0019: Incompatible stack heights: 3 vs 1
			//IL_01dd->IL00b6: Incompatible stack types: I4 vs Ref
			//IL_00a7->IL00b6: Incompatible stack heights: 0 vs 2
			//IL_0068->IL0019: Incompatible stack types: I4 vs Obj
			//IL_00f3->IL01d0: Incompatible stack heights: 1 vs 0
			//IL_00b2->IL00b6: Incompatible stack heights: 1 vs 2
			//IL_0134->IL00b6: Incompatible stack heights: 4 vs 2
			//IL_0162->IL00b6: Incompatible stack types: Obj vs Ref
			//IL_0201->IL00b6: Incompatible stack heights: 1 vs 2
			//IL_017c->IL00b6: Incompatible stack heights: 4 vs 2
			//IL_01f1->IL00b2: Incompatible stack heights: 3 vs 2
			//IL_01a8->IL00b6: Incompatible stack heights: 5 vs 2
			//IL_01b8->IL00b6: Incompatible stack heights: 4 vs 2
			//IL_014e->IL00b6: Incompatible stack types: I4 vs Ref
			//IL_010a->IL00b6: Incompatible stack types: I4 vs Ref
			//IL_00b6->IL00b6: Incompatible stack heights: 3 vs 2
			//IL_016d->IL00b6: Incompatible stack types: I4 vs Ref
			//IL_020c->IL00b6: Incompatible stack heights: 1 vs 2
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			object obj2 = obj;
			while (true)
			{
				ref _003CGetUserSkinAsync_003Ed__56 reference;
				switch ((int)obj2)
				{
				case 1:
					_ = -2;
					_ = 3;
					break;
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				case 6:
					_ = 2;
					break;
				case 3:
					_ = null;
					_ = 6;
					break;
				case 5:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 4;
					break;
				case 2:
					return;
				default:
					{
						if (obj == null)
						{
							if (6 != 0)
							{
								_ = 11;
							}
							goto IL_00b6;
						}
						goto IL_01d0;
					}
					IL_01d0:
					reference = ref *(_003CGetUserSkinAsync_003Ed__56*)8;
					goto IL_00b6;
					IL_00b6:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 7u:
							break;
						case 13u:
							return;
						case 1u:
							if (&obj == null)
							{
								reference = ref *(_003CGetUserSkinAsync_003Ed__56*)9;
								continue;
							}
							goto case 2u;
						case 3u:
							_ = 10;
							continue;
						default:
							reference = ref this;
							if (12 == 0)
							{
								reference = ref *(_003CGetUserSkinAsync_003Ed__56*)4;
							}
							continue;
						case 4u:
						{
							object obj3 = obj;
							obj = (object)Unsafe.AsPointer(ref this);
							reference = ref *(_003CGetUserSkinAsync_003Ed__56*)obj3;
							if (1 == 0)
							{
								reference = ref *(_003CGetUserSkinAsync_003Ed__56*)1;
							}
							continue;
						}
						case 8u:
							_ = 4;
							continue;
						case 10u:
							_ = ref obj;
							_ = 13;
							continue;
						case 12u:
							obj = -1;
							_ = 2;
							continue;
						case 2u:
							_ = ref obj;
							obj = (object)Unsafe.AsPointer(ref this);
							obj = 7;
							continue;
						case 6u:
							goto IL_01d0;
						case 9u:
							obj = 0;
							obj = 3;
							continue;
						case 5u:
						case 11u:
							obj = (object)Unsafe.AsPointer(ref this);
							if (0 == 0)
							{
								_ = 0;
							}
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
		private sealed void _FF00_FF00_FF00萀(object P_0)
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0090: Expected Obj, but got Ref
			//IL_0074: Expected Obj, but got Ref
			//IL_00e9: Expected I4, but got Obj
			//IL_01d5: Expected Obj, but got Ref
			//IL_011d: Expected Obj, but got I4
			//IL_0158: Expected Obj, but got Ref
			//IL_00f3: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_009a->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0080->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0070->IL0019: Incompatible stack types: I4 vs Ref
			//IL_008b->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0056->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00ac->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_01a3->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_01df->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0128->IL00b0: Incompatible stack heights: 3 vs 1
			//IL_0149->IL00b0: Incompatible stack heights: 3 vs 1
			//IL_01b3->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_0162->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0118->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_0172->IL00b0: Incompatible stack heights: 3 vs 1
			//IL_0100->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_01d0->IL00b0: Incompatible stack types: I4 vs Obj
			//IL_0154->IL00b0: Incompatible stack heights: 3 vs 1
			//IL_01be->IL00b0: Incompatible stack heights: 2 vs 1
			//IL_010b->IL00b0: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			ref _003CHeartbeatAsync_003Ed__7 reference = ref *(_003CHeartbeatAsync_003Ed__7*)obj;
			while (true)
			{
				object obj2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 3u:
					_ = -2;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
				default:
					reference = ref this;
					if (4 != 0)
					{
						reference = ref *(_003CHeartbeatAsync_003Ed__7*)5;
					}
					break;
				case 2u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (true)
					{
						reference = ref *(_003CHeartbeatAsync_003Ed__7*)1;
					}
					break;
				case 5u:
					return;
				case 1u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CHeartbeatAsync_003Ed__7*)4;
					break;
				case 4u:
					{
						if (obj == null)
						{
							obj2 = 11;
							goto IL_00b0;
						}
						goto IL_0181;
					}
					IL_0181:
					obj2 = obj;
					obj = obj;
					if (0 == 0)
					{
						obj2 = 0;
					}
					goto IL_00b0;
					IL_00b0:
					while (true)
					{
						switch ((int)obj2)
						{
						case 3:
							break;
						case 9:
							return;
						case 12:
							obj = -1;
							if (0 == 0)
							{
								_ = 1;
							}
							continue;
						case 7:
							_ = 12;
							continue;
						case 2:
							obj = 0;
							_ = 5;
							continue;
						case 4:
							_ = ref obj;
							if (9 != 0)
							{
								_ = 8;
							}
							continue;
						case 6:
						case 11:
							obj = (object)Unsafe.AsPointer(ref this);
							obj2 = 7;
							continue;
						case 8:
							_ = 3;
							continue;
						case 10:
							goto IL_0181;
						case 5:
							if (4 == 0)
							{
								_ = 1;
							}
							continue;
						default:
							if (&obj == null)
							{
								obj2 = 2;
								continue;
							}
							goto case 1;
						case 1:
							obj = (object)(&obj);
							obj2 = 8;
							continue;
						}
						break;
					}
					goto case 3u;
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
		private sealed void _FF00_FF00_FF00稀(object P_0)
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_023c: Expected Obj, but got Ref
			//IL_004d: Expected Obj, but got Ref
			//IL_00c5: Expected Obj, but got Ref
			//IL_00e1: Expected Obj, but got I4
			//IL_0188: Expected Obj, but got I4
			//IL_0174: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0248->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0059->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0049->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0253->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0064->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0237->IL0019: Incompatible stack types: I4 vs Ref
			//IL_00dc->IL0087: Incompatible stack heights: 1 vs 0
			//IL_0083->IL0087: Incompatible stack heights: 1 vs 0
			//IL_019f->IL0087: Incompatible stack heights: 2 vs 0
			//IL_0125->IL0087: Incompatible stack heights: 4 vs 0
			//IL_00ec->IL0087: Incompatible stack heights: 3 vs 0
			//IL_0192->IL0087: Incompatible stack heights: 2 vs 0
			//IL_0115->IL0087: Incompatible stack heights: 3 vs 0
			//IL_017f->IL0087: Incompatible stack heights: 3 vs 0
			//IL_0153->IL0087: Incompatible stack heights: 1 vs 0
			//IL_0107->IL0087: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			ref _003CInterLoginStartAsync_003Ed__30 reference = ref *(_003CInterLoginStartAsync_003Ed__30*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					return;
				case 4u:
					_ = -2;
					_ = 5;
					break;
				case 3u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 == 0)
					{
						reference = ref *(_003CInterLoginStartAsync_003Ed__30*)2;
					}
					break;
				case 1u:
					if (obj != null)
					{
						if (2 != 0)
						{
							_ = 4;
						}
						goto IL_0087;
					}
					goto IL_00c1;
				case 5u:
					reference = ref this;
					if (false)
					{
						reference = ref *(_003CInterLoginStartAsync_003Ed__30*)null;
					}
					break;
				case 0u:
					return;
				case 2u:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (true)
						{
							reference = ref *(_003CInterLoginStartAsync_003Ed__30*)1;
						}
						break;
					}
					IL_00c1:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						_ = 0;
					}
					goto IL_0087;
					IL_0087:
					while (true)
					{
						switch ((int)/*Error near IL_00bc: Stack underflow*/)
						{
						case 7:
							break;
						case 1:
							goto IL_00c1;
						case 3:
							obj = 0;
							_ = 6;
							continue;
						case 10:
						case 11:
							_ = ref obj;
							if (2 == 0)
							{
								_ = 7;
							}
							continue;
						case 6:
							_ = 2;
							continue;
						case 2:
							_ = ref obj;
							_ = 5;
							continue;
						case 9:
							if (&obj != null)
							{
								_ = 10;
								continue;
							}
							goto case 3;
						case 5:
							return;
						case 8:
							obj = -1;
							_ = 11;
							continue;
						case 4:
							obj = 0;
							_ = 9;
							continue;
						default:
							_ = 8;
							continue;
						}
						break;
					}
					goto case 4u;
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
		private sealed void _FF00_FF00_FF00猀(object P_0)
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
		internal static byte _FF00_FF00_FF00琀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00甀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_023f: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_00fc: Expected Obj, but got Ref
			//IL_0185: Expected Obj, but got I4
			//IL_018f: Expected Obj, but got I4
			//IL_00d9: Expected Obj, but got I4
			//IL_00f3: Expected Obj, but got I4
			//IL_0157: Expected Obj, but got I4
			//IL_0160: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_023b->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0249->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0049->IL0019: Incompatible stack types: I4 vs Ref
			//IL_022c->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0113->IL006c: Incompatible stack heights: 1 vs 0
			//IL_0068->IL006c: Incompatible stack heights: 1 vs 0
			//IL_00e4->IL006c: Incompatible stack heights: 3 vs 0
			//IL_00f8->IL0068: Incompatible stack heights: 3 vs 2
			//IL_0175->IL006c: Incompatible stack heights: 2 vs 0
			//IL_0165->IL0068: Incompatible stack heights: 1 vs 2
			//IL_0143->IL006c: Incompatible stack heights: 1 vs 0
			//IL_006c->IL006c: Incompatible stack heights: 3 vs 0
			//IL_0134->IL006c: Incompatible stack heights: 1 vs 0
			//IL_0180->IL006c: Incompatible stack heights: 2 vs 0
			//IL_014e->IL006c: Incompatible stack heights: 1 vs 0
			//IL_00d4->IL006c: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			ref _003CInterLoginStopAsync_003Ed__31 reference = ref *(_003CInterLoginStopAsync_003Ed__31*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					return;
				case 5u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CInterLoginStopAsync_003Ed__31*)4;
					break;
				case 2u:
					if (obj != null)
					{
						if (8 != 0)
						{
							_ = 7;
						}
						goto IL_006c;
					}
					goto IL_00f8;
				case 3u:
					reference = ref this;
					if (false)
					{
						reference = ref *(_003CInterLoginStopAsync_003Ed__31*)null;
					}
					break;
				case 0u:
					return;
				case 1u:
					goto IL_022d;
				case 4u:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(_003CInterLoginStopAsync_003Ed__31*)2;
						break;
					}
					IL_006c:
					while (true)
					{
						switch ((int)/*Error near IL_00a1: Stack underflow*/)
						{
						case 6:
						case 10:
							_ = ref obj;
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 3:
							obj = 0;
							_ = 5;
							continue;
						case 4:
							_ = ref obj;
							obj = 11;
							continue;
						case 7:
							break;
						case 11:
							return;
						case 2:
							if (&obj != null)
							{
								_ = 6;
								continue;
							}
							goto case 3;
						case 9:
							if (true)
							{
								_ = 1;
							}
							continue;
						case 8:
							obj = 0;
							obj = 2;
							continue;
						case 5:
							if (0 == 0)
							{
								_ = 4;
							}
							continue;
						case 1:
							obj = -1;
							obj = 10;
							continue;
						default:
							goto IL_022d;
						}
						break;
					}
					goto IL_00f8;
					IL_022d:
					_ = -2;
					_ = 3;
					break;
					IL_00f8:
					obj = (object)Unsafe.AsPointer(ref this);
					if (9 != 0)
					{
						_ = 5;
					}
					goto IL_006c;
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
		private sealed void _FF00_FF00_FF00欀(object P_0)
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
		internal unsafe static byte _FF00_FF00_FF00氀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779108, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00洀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00渀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0076: Expected Obj, but got Ref
			//IL_005a: Expected Obj, but got Ref
			//IL_0190: Expected Obj, but got Ref
			//IL_017a: Expected Obj, but got I4
			//IL_0182: Expected Obj, but got I4
			//IL_011c: Expected Obj, but got I4
			//IL_00de: Expected Obj, but got I4
			//IL_00e8: Expected Obj, but got I4
			//IL_0134: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0080->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0066->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0071->IL0019: Incompatible stack types: I4 vs Ref
			//IL_019a->IL00a3: Incompatible stack types: I4 vs Ref
			//IL_0094->IL00a3: Incompatible stack heights: 0 vs 1
			//IL_0056->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0251->IL0019: Incompatible stack types: I4 vs Ref
			//IL_009f->IL00a3: Incompatible stack types: I4 vs Ref
			//IL_018c->IL00a3: Incompatible stack heights: 6 vs 1
			//IL_00fd->IL00a3: Incompatible stack heights: 4 vs 1
			//IL_0127->IL00a3: Incompatible stack heights: 3 vs 1
			//IL_0139->IL009f: Incompatible stack heights: 0 vs 2
			//IL_0158->IL00a3: Incompatible stack heights: 2 vs 1
			//IL_0117->IL00a3: Incompatible stack types: I4 vs Ref
			//IL_00a3->IL00a3: Incompatible stack heights: 3 vs 1
			//IL_01ae->IL00a3: Incompatible stack heights: 0 vs 1
			//IL_0163->IL00a3: Incompatible stack heights: 2 vs 1
			//IL_01b9->IL00a3: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			ref _003CInterStartAsync_003Ed__33 reference = ref *(_003CInterStartAsync_003Ed__33*)obj;
			while (true)
			{
				ref _003CInterStartAsync_003Ed__33 reference2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					return;
				case 4u:
					_ = -2;
					if (5 == 0)
					{
						_ = 0;
					}
					break;
				case 2u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						reference = ref *(_003CInterStartAsync_003Ed__33*)1;
					}
					break;
				case 0u:
					return;
				case 1u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CInterStartAsync_003Ed__33*)3;
					break;
				case 3u:
					if (obj != null)
					{
						if (0 == 0)
						{
							reference2 = ref *(_003CInterStartAsync_003Ed__33*)null;
						}
						goto IL_00a3;
					}
					goto IL_018c;
				case 5u:
					{
						reference = ref this;
						if (false)
						{
							reference = ref *(_003CInterStartAsync_003Ed__33*)null;
						}
						break;
					}
					IL_018c:
					obj = (object)Unsafe.AsPointer(ref this);
					reference2 = ref *(_003CInterStartAsync_003Ed__33*)6;
					goto IL_00a3;
					IL_00a3:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference2))
						{
						case 2u:
							break;
						case 5u:
							return;
						case 7u:
							obj = 0;
							obj = 10;
							continue;
						case 1u:
							_ = ref obj;
							_ = 5;
							continue;
						case 6u:
							reference2 = ref this;
							if (0 == 0)
							{
								reference2 = ref *(_003CInterStartAsync_003Ed__33*)3;
							}
							continue;
						case 3u:
							obj = -1;
							_ = 9;
							continue;
						case 9u:
							_ = ref obj;
							obj = 2;
							continue;
						case 10u:
							if (0 == 0)
							{
								_ = 1;
							}
							continue;
						default:
							obj = obj;
							((object[])1)[1] = 0;
							obj = 0;
							_ = 8;
							continue;
						case 4u:
							goto IL_018c;
						case 8u:
							if (&obj == null)
							{
								if (7 == 0)
								{
									reference2 = ref *(_003CInterStartAsync_003Ed__33*)3;
								}
								continue;
							}
							goto case 9u;
						}
						break;
					}
					goto case 4u;
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
		private sealed void _FF00_FF00_FF00怀(object P_0)
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0074: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_0117: Expected Obj, but got Ref
			//IL_02e4: Expected Obj, but got I4
			//IL_0294: Expected Obj, but got Ref
			//IL_0235: Expected Obj, but got I4
			//IL_023f: Expected Obj, but got I4
			//IL_01c3: Expected Obj, but got I4
			//IL_0313: Expected Obj, but got I4
			//IL_01d3: Expected Obj, but got I4
			//IL_020e: Expected Obj, but got I4
			//IL_010e: Expected I4, but got Obj
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_03aa->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0080->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_009d->IL00a1: Incompatible stack types: I4 vs Obj
			//IL_008b->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0056->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0070->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0123->IL00a1: Incompatible stack heights: 0 vs 1
			//IL_01a5->IL00a1: Incompatible stack heights: 0 vs 1
			//IL_012e->IL00a1: Incompatible stack types: I4 vs Obj
			//IL_01b0->IL00a1: Incompatible stack types: I4 vs Obj
			//IL_02cd->IL00a1: Incompatible stack heights: 3 vs 1
			//IL_029e->IL00a1: Incompatible stack types: I4 vs Obj
			//IL_0290->IL00a1: Incompatible stack heights: 2 vs 1
			//IL_023a->IL009d: Incompatible stack heights: 3 vs 1
			//IL_01f9->IL00a1: Incompatible stack heights: 2 vs 1
			//IL_024a->IL00a1: Incompatible stack heights: 3 vs 1
			//IL_02bb->IL00a1: Incompatible stack heights: 3 vs 1
			//IL_01be->IL00a1: Incompatible stack heights: 3 vs 1
			//IL_013c->IL00a1: Incompatible stack types: I4 vs Obj
			//IL_0177->IL00a1: Incompatible stack heights: 2 vs 1
			//IL_01ce->IL00a1: Incompatible stack heights: 3 vs 1
			//IL_031d->IL00a1: Incompatible stack heights: 4 vs 1
			//IL_0209->IL00a1: Incompatible stack types: I4 vs Obj
			//IL_01e0->IL00a1: Incompatible stack heights: 2 vs 1
			//IL_021b->IL00a1: Incompatible stack heights: 2 vs 1
			//IL_00a1->IL00a1: Incompatible stack heights: 2 vs 1
			//IL_02d8->IL00a1: Incompatible stack heights: 3 vs 1
			//IL_0191->IL00a1: Incompatible stack types: I4 vs Obj
			//IL_0150->IL00a1: Incompatible stack heights: 0 vs 1
			//IL_01eb->IL00a1: Incompatible stack heights: 2 vs 1
			//IL_0264->IL00a1: Incompatible stack types: I4 vs Obj
			//IL_0226->IL00a1: Incompatible stack heights: 2 vs 1
			//IL_0278->IL00a1: Incompatible stack heights: 0 vs 1
			//IL_015b->IL00a1: Incompatible stack types: I4 vs Obj
			//IL_0283->IL00a1: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			ref _003CLogoutAsync_003Ed__32 reference = ref *(_003CLogoutAsync_003Ed__32*)obj;
			while (true)
			{
				object obj2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					return;
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						reference = ref *(_003CLogoutAsync_003Ed__32*)3;
					}
					continue;
				case 5u:
					reference = ref this;
					if (0 == 0)
					{
						reference = ref *(_003CLogoutAsync_003Ed__32*)null;
					}
					continue;
				case 3u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						reference = ref *(_003CLogoutAsync_003Ed__32*)1;
					}
					continue;
				case 1u:
					if (obj == null)
					{
						obj2 = 7;
						goto IL_00a1;
					}
					goto IL_0191;
				case 0u:
					return;
				case 2u:
					break;
					IL_00a1:
					while (true)
					{
						switch ((int)obj2)
						{
						case 2:
							break;
						case 14:
							_ = ref obj;
							obj2 = 8;
							continue;
						case 16:
							if (&obj == null)
							{
								if (14 != 0)
								{
									obj2 = 21;
								}
								continue;
							}
							goto case 14;
						case 6:
							return;
						case 15:
							_ = 11;
							continue;
						case 8:
							obj2 = obj;
							if (9 == 0)
							{
								obj2 = 10;
							}
							continue;
						case 20:
							goto IL_0191;
						case 13:
							_ = 9;
							continue;
						case 17:
							obj = 0;
							_ = 12;
							continue;
						case 21:
							obj = 1;
							if (13 == 0)
							{
								_ = 11;
							}
							continue;
						case 10:
							_ = 22;
							continue;
						case 19:
							obj = obj;
							obj2 = 25;
							continue;
						case 24:
							obj = -1;
							if (10 != 0)
							{
								_ = 14;
							}
							continue;
						case 9:
							_ = ref obj;
							obj = 6;
							continue;
						case 11:
							obj = -1;
							_ = 5;
							continue;
						case 22:
							obj2 = obj;
							if (false)
							{
								obj2 = 1;
							}
							continue;
						case 25:
							if (&obj == null)
							{
								if (0 == 0)
								{
									obj2 = 17;
								}
								continue;
							}
							goto case 5;
						case 5:
							_ = ref obj;
							_ = 18;
							continue;
						case 4:
						case 7:
							obj = (object)Unsafe.AsPointer(ref this);
							obj2 = 15;
							continue;
						case 23:
							return;
						case 12:
							_ = 3;
							continue;
						case 3:
							_ = ref obj;
							if (23 == 0)
							{
								_ = 12;
							}
							continue;
						default:
							obj = 24;
							continue;
						case 18:
							obj = 1;
							_ = 16;
							continue;
						case 1:
							goto end_IL_0019;
						}
						break;
					}
					goto IL_0113;
					IL_0191:
					if ((nint)obj != 1)
					{
						if (19 != 0)
						{
							obj2 = 18;
						}
						goto IL_00a1;
					}
					goto IL_0113;
					IL_0113:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 0;
					}
					goto IL_00a1;
					end_IL_0019:
					break;
				}
				_ = -2;
				_ = 5;
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
		private sealed void _FF00_FF00_FF00唀(object P_0)
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
		internal static byte _FF00_FF00_FF00嘀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0229: Expected Obj, but got Ref
			//IL_004e: Expected Obj, but got Ref
			//IL_0186: Expected Obj, but got I4
			//IL_0166: Expected Obj, but got Ref
			//IL_016f: Expected Obj, but got I4
			//IL_0101: Expected Obj, but got I4
			//IL_00d5: Expected Obj, but got Ref
			//IL_0111: Expected Obj, but got I4
			//IL_00be: Expected I4, but got Obj
			//IL_004a->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0068->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0235->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0058->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0190->IL0089: Incompatible stack types: I4 vs Obj
			//IL_0085->IL0089: Incompatible stack heights: 1 vs 6
			//IL_0073->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0240->IL0019: Incompatible stack types: I4 vs Obj
			//IL_00be->IL0174: Incompatible stack heights: 5 vs 0
			//IL_010c->IL0089: Incompatible stack heights: 8 vs 6
			//IL_00e1->IL0089: Incompatible stack heights: 5 vs 6
			//IL_011c->IL0089: Incompatible stack heights: 8 vs 6
			//IL_00fc->IL0089: Incompatible stack heights: 9 vs 6
			//IL_00d0->IL0089: Incompatible stack heights: 7 vs 6
			//IL_012c->IL0089: Incompatible stack heights: 7 vs 6
			//IL_00ec->IL0089: Incompatible stack heights: 5 vs 6
			//IL_01a4->IL0089: Incompatible stack heights: 5 vs 6
			//IL_0137->IL0089: Incompatible stack heights: 7 vs 6
			//IL_01af->IL0089: Incompatible stack heights: 5 vs 6
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				default:
					_ = 5;
					break;
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 3;
					break;
				case 2:
					_ = -2;
					if (false)
					{
						_ = 0;
					}
					break;
				case 1:
					if (obj == null)
					{
						_ = 8;
						goto IL_0089;
					}
					goto IL_0174;
				case 5:
					return;
				case 3:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (false)
						{
							obj2 = 1;
						}
						break;
					}
					IL_0174:
					obj = 1;
					obj3 = 6;
					goto IL_0089;
					IL_0089:
					while (true)
					{
						switch ((int)obj3)
						{
						case 1:
							break;
						case 9:
							_ = 4;
							continue;
						case 3:
							obj = (object)(&obj);
							if (true)
							{
								_ = 1;
							}
							continue;
						case 7:
							_ = ref obj;
							_ = 5;
							continue;
						case 2:
							obj = 0;
							_ = 10;
							continue;
						case 4:
							obj = -1;
							_ = 3;
							continue;
						case 10:
							if (5 == 0)
							{
								_ = 7;
							}
							continue;
						case 5:
							return;
						default:
							obj = (object)Unsafe.AsPointer(ref this);
							obj = 9;
							obj3 = obj;
							continue;
						case 11:
							goto IL_0174;
						case 6:
							if (&obj == null)
							{
								if (2 == 0)
								{
									_ = 2;
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
		private sealed void _FF00_FF00_FF00䰀(object P_0)
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00倀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_0043: Expected Obj, but got Ref
			//IL_0079: Expected Obj, but got Ref
			//IL_015b: Expected Obj, but got Ref
			//IL_0323: Expected Obj, but got Ref
			//IL_032c: Expected Obj, but got I4
			//IL_0189: Expected Obj, but got I4
			//IL_0368: Expected Obj, but got I4
			//IL_0292: Expected Obj, but got Ref
			//IL_02ae: Expected Obj, but got I4
			//IL_01ab: Expected Obj, but got Ref
			//IL_019c: Expected Obj, but got Ref
			//IL_01cf: Expected Obj, but got I4
			//IL_026f: Expected Obj, but got I4
			//IL_004f->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0085->IL0019: Incompatible stack heights: 0 vs 1
			//IL_00a0->IL0019: Incompatible stack heights: 3 vs 1
			//IL_041d->IL0019: Incompatible stack heights: 3 vs 1
			//IL_006a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0165->IL00c3: Incompatible stack types: I4 vs Ref
			//IL_00b4->IL00c3: Incompatible stack heights: 0 vs 1
			//IL_005a->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0090->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0075->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00bf->IL00c3: Incompatible stack types: I4 vs Ref
			//IL_025f->IL00c3: Incompatible stack heights: 2 vs 1
			//IL_0302->IL00c3: Incompatible stack heights: 2 vs 1
			//IL_02d3->IL00c3: Incompatible stack heights: 2 vs 1
			//IL_0221->IL00c3: Incompatible stack heights: 3 vs 1
			//IL_0240->IL00c3: Incompatible stack heights: 2 vs 1
			//IL_0194->IL00c3: Incompatible stack heights: 3 vs 1
			//IL_0373->IL00c3: Incompatible stack heights: 3 vs 1
			//IL_0175->IL00c3: Incompatible stack heights: 4 vs 1
			//IL_029e->IL00c3: Incompatible stack heights: 3 vs 1
			//IL_02bb->IL00c3: Incompatible stack heights: 2 vs 1
			//IL_01b5->IL00c3: Incompatible stack types: I4 vs Ref
			//IL_0381->IL00c3: Incompatible stack heights: 3 vs 1
			//IL_0184->IL00c3: Incompatible stack heights: 3 vs 1
			//IL_01a6->IL00c3: Incompatible stack heights: 2 vs 1
			//IL_01d9->IL00c3: Incompatible stack heights: 8 vs 1
			//IL_027c->IL00c3: Incompatible stack heights: 2 vs 1
			//IL_01eb->IL00c3: Incompatible stack heights: 3 vs 1
			//IL_026a->IL00c3: Incompatible stack heights: 2 vs 1
			//IL_030d->IL00c3: Incompatible stack heights: 2 vs 1
			//IL_0345->IL00c3: Incompatible stack heights: 0 vs 1
			//IL_00c3->IL00c3: Incompatible stack types: Obj vs Ref
			//IL_031f->IL00c3: Incompatible stack types: I4 vs Ref
			//IL_02a9->IL00c3: Incompatible stack heights: 3 vs 1
			//IL_02c6->IL00c3: Incompatible stack heights: 2 vs 1
			//IL_0157->IL00c3: Incompatible stack types: I4 vs Ref
			//IL_0287->IL00c3: Incompatible stack heights: 2 vs 1
			//IL_01f6->IL00c3: Incompatible stack heights: 3 vs 1
			//IL_0233->IL00c3: Incompatible stack types: I4 vs Ref
			//IL_0350->IL00c3: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				ref object reference;
				switch ((int)obj2)
				{
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				case 6:
					_ = -2;
					if (2 != 0)
					{
						_ = 5;
					}
					break;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						obj2 = 0;
					}
					break;
				case 3:
					return;
				case 4:
					_ = 3;
					break;
				default:
					if (obj != null)
					{
						if (5 != 0)
						{
							reference = ref *(object*)5;
						}
						goto IL_00c3;
					}
					goto IL_0157;
				case 5:
					{
						_ = null;
						_ = 4;
						break;
					}
					IL_0157:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(object*)3;
					goto IL_00c3;
					IL_00c3:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 25u:
							break;
						default:
							return;
						case 0u:
							return;
						case 19u:
							return;
						case 17u:
						case 22u:
							reference = ref obj;
							if (13 != 0)
							{
								reference = ref *(object*)3;
							}
							continue;
						case 11u:
							goto IL_0157;
						case 12u:
							_ = ref obj;
							_ = 19;
							continue;
						case 20u:
							_ = 1;
							_ = 23;
							continue;
						case 8u:
							obj = -1;
							_ = 17;
							continue;
						case 21u:
							obj = (object)Unsafe.AsPointer(ref this);
							_ = 9;
							continue;
						case 15u:
						case 18u:
							obj = (object)(&obj);
							reference = ref *(object*)2;
							continue;
						case 23u:
							_ = (nint)Unsafe.AsPointer(ref Unsafe.SubtractByteOffset(ref this, 1)) * (nint)20;
							_ = 20;
							obj = 1;
							_ = 27;
							continue;
						case 26u:
							_ = ref obj;
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 4u:
							_ = (int)((double)obj / 20.0);
							_ = 21;
							continue;
						case 27u:
							if (&obj != null)
							{
								reference = ref *(object*)18;
								continue;
							}
							goto case 10u;
						case 6u:
							_ = 8;
							continue;
						case 1u:
							if (12 == 0)
							{
								_ = 5;
							}
							continue;
						case 24u:
							obj = 1;
							if (0 == 0)
							{
								_ = 1;
							}
							continue;
						case 13u:
							/*Error near IL_0288: Stack underflow*/;
							obj = (object)Unsafe.AsPointer(ref this);
							if (25 == 0)
							{
								_ = 25;
							}
							continue;
						case 14u:
							obj = -1;
							if (15 == 0)
							{
								_ = 3;
							}
							continue;
						case 3u:
							_ = 14;
							continue;
						case 2u:
							if (1 == 0)
							{
								_ = 4;
							}
							continue;
						case 9u:
							if (&obj != null)
							{
								reference = ref *(object*)22;
								continue;
							}
							goto case 24u;
						case 7u:
							obj = (object)Unsafe.AsPointer(ref this);
							obj = 6;
							reference = ref *(object*)obj;
							continue;
						case 5u:
							if ((nint)obj != 1)
							{
								if (20 == 0)
								{
									reference = ref *(object*)2;
								}
								continue;
							}
							goto case 7u;
						case 10u:
							obj = 0;
							_ = 16;
							continue;
						case 16u:
							_ = 26;
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
		private sealed void _FF00_FF00_FF00䌀(object P_0)
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00䜀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0040: Expected Obj, but got Ref
			//IL_005c: Expected Obj, but got Ref
			//IL_0208: Expected Obj, but got I4
			//IL_00f1: Expected I4, but got Obj
			//IL_01ce: Expected Obj, but got I4
			//IL_01eb: Expected Obj, but got I4
			//IL_0223: Expected Obj, but got Ref
			//IL_017c: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_004a->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0068->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0058->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0073->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0214->IL00b0: Incompatible stack types: Obj vs Ref
			//IL_00a1->IL00b0: Incompatible stack heights: 0 vs 5
			//IL_008d->IL0019: Incompatible stack types: I4 vs Ref
			//IL_00f1->IL01f6: Incompatible stack heights: 4 vs 0
			//IL_021f->IL00b0: Incompatible stack types: I4 vs Ref
			//IL_00ac->IL00b0: Incompatible stack heights: 1 vs 5
			//IL_0151->IL00b0: Incompatible stack heights: 6 vs 5
			//IL_01db->IL00b0: Incompatible stack heights: 6 vs 5
			//IL_0135->IL00b0: Incompatible stack heights: 7 vs 5
			//IL_0123->IL00b0: Incompatible stack heights: 7 vs 5
			//IL_01f6->IL00b0: Incompatible stack heights: 7 vs 5
			//IL_0106->IL00b0: Incompatible stack heights: 7 vs 5
			//IL_022f->IL00b0: Incompatible stack heights: 4 vs 5
			//IL_016b->IL00b0: Incompatible stack types: I4 vs Ref
			//IL_01e6->IL00b0: Incompatible stack heights: 6 vs 5
			//IL_019b->IL00b0: Incompatible stack types: I4 vs Ref
			//IL_01ad->IL00b0: Incompatible stack types: I4 vs Ref
			//IL_0140->IL00b0: Incompatible stack heights: 7 vs 5
			//IL_023a->IL00b0: Incompatible stack heights: 4 vs 5
			//IL_00b0->IL00b0: Incompatible stack types: Obj vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			ref _003CSetNicknameAsync_003Ed__40 reference = ref *(_003CSetNicknameAsync_003Ed__40*)obj;
			while (true)
			{
				object obj2;
				ref byte reference2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 4u:
					return;
				default:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CSetNicknameAsync_003Ed__40*)3;
					break;
				case 2u:
					_ = -2;
					_ = 5;
					break;
				case 1u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						reference = ref *(_003CSetNicknameAsync_003Ed__40*)null;
					}
					break;
				case 5u:
					reference = ref this;
					if (4 == 0)
					{
						reference = ref *(_003CSetNicknameAsync_003Ed__40*)4;
					}
					break;
				case 3u:
					{
						if (obj == null)
						{
							if (0 == 0)
							{
								_ = 0;
							}
							goto IL_00b0;
						}
						goto IL_01f6;
					}
					IL_01f6:
					obj2 = obj;
					obj = 1;
					reference2 = ref *(byte*)obj2;
					if (6 == 0)
					{
						reference2 = ref *(byte*)9;
					}
					goto IL_00b0;
					IL_00b0:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference2))
						{
						case 8u:
							return;
						case 7u:
							break;
						case 13u:
							_ = 7;
							continue;
						case 11u:
							_ = 10;
							continue;
						case 10u:
							_ = ref obj;
							if (8 == 0)
							{
								_ = 2;
							}
							continue;
						case 3u:
							obj = obj;
							_ = 13;
							continue;
						case 1u:
							reference2 = ref Unsafe.As<_003CSetNicknameAsync_003Ed__40, byte>(ref this);
							if (12 != 0)
							{
								reference2 = ref *(byte*)1;
							}
							continue;
						case 2u:
							if (obj == null)
							{
								obj = 3;
								reference2 = ref *(byte*)obj;
								continue;
							}
							goto case 13u;
						case 5u:
							reference2 = ref *(byte*)(&obj);
							if (2 != 0)
							{
								reference2 = ref *(byte*)2;
							}
							continue;
						case 9u:
							if (&obj == null)
							{
								reference2 = ref *(byte*)4;
								continue;
							}
							goto case 5u;
						case 4u:
							obj = 0;
							if (11 == 0)
							{
								_ = 5;
							}
							continue;
						case 12u:
							obj = -1;
							_ = 5;
							continue;
						case 6u:
							goto IL_01f6;
						default:
							obj = (object)Unsafe.AsPointer(ref this);
							if (true)
							{
								_ = 0;
							}
							continue;
						}
						break;
					}
					goto case 2u;
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
		private sealed void _FF00_FF00_FF00㜀(object P_0)
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
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_079f: Expected Obj, but got Ref
			//IL_0056: Expected Obj, but got I4
			//IL_0673: Expected Obj, but got Ref
			//IL_0649: Expected Obj, but got I4
			//IL_0658: Expected Obj, but got Ref
			//IL_06d4: Expected Obj, but got I4
			//IL_013f: Expected I4, but got Obj
			//IL_00d3: Expected Obj, but got I4
			//IL_06fc: Expected Obj, but got I4
			//IL_04aa: Expected Obj, but got Ref
			//IL_03db: Expected Obj, but got Ref
			//IL_0540: Expected Obj, but got Ref
			//IL_0549: Expected Obj, but got I4
			//IL_048b: Unknown result type (might be due to invalid IL or missing references)
			//IL_051b: Expected Obj, but got I4
			//IL_04b9: Expected Obj, but got I4
			//IL_028d: Expected Obj, but got Ref
			//IL_0249: Expected Obj, but got I4
			//IL_0466: Expected Obj, but got I4
			//IL_04f7: Expected Obj, but got I4
			//IL_035f: Expected Obj, but got Ref
			//IL_0440: Expected Obj, but got Ref
			//IL_0414: Expected Obj, but got I4
			//IL_036e: Expected Obj, but got I4
			//IL_0225: Expected Obj, but got I4
			//IL_044f: Expected Obj, but got I4
			//IL_0310: Expected Obj, but got Ref
			//IL_021b: Expected I4, but got Obj
			//IL_02eb: Expected Obj, but got I4
			//IL_027f: Expected Obj, but got I4
			//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
			//IL_07ab->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0790->IL0019: Incompatible stack heights: 2 vs 1
			//IL_005b->IL0015: Incompatible stack heights: 2 vs 0
			//IL_07b6->IL0019: Incompatible stack types: I4 vs Obj
			//IL_079b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_011c->IL0080: Incompatible stack heights: 1 vs 0
			//IL_007c->IL0080: Incompatible stack heights: 1 vs 0
			//IL_068a->IL0080: Incompatible stack heights: 1 vs 0
			//IL_00ff->IL0080: Incompatible stack heights: 3 vs 0
			//IL_06c1->IL0080: Incompatible stack heights: 1 vs 0
			//IL_06cf->IL0080: Incompatible stack heights: 3 vs 0
			//IL_0653->IL0080: Incompatible stack heights: 28 vs 0
			//IL_06df->IL0080: Incompatible stack heights: 3 vs 0
			//IL_06ab->IL0080: Incompatible stack heights: 1 vs 0
			//IL_00de->IL0080: Incompatible stack heights: 3 vs 0
			//IL_010a->IL0080: Incompatible stack heights: 3 vs 0
			//IL_066f->IL0080: Incompatible stack heights: 1 vs 0
			//IL_06b6->IL0080: Incompatible stack heights: 1 vs 0
			//IL_04b4->IL015a: Incompatible stack types: I4 vs Obj
			//IL_03e5->IL015a: Incompatible stack types: I4 vs Obj
			//IL_014b->IL015a: Incompatible stack heights: 0 vs 1
			//IL_069c->IL0080: Incompatible stack heights: 1 vs 0
			//IL_0080->IL0080: Incompatible stack heights: 3 vs 0
			//IL_0156->IL015a: Incompatible stack types: I4 vs Obj
			//IL_043c->IL015a: Incompatible stack heights: 3 vs 1
			//IL_0579->IL015a: Incompatible stack heights: 4 vs 1
			//IL_0497->IL015a: Incompatible stack heights: 3 vs 1
			//IL_0520->IL0156: Incompatible stack heights: 2 vs 0
			//IL_03f7->IL015a: Incompatible stack heights: 3 vs 1
			//IL_04c4->IL015a: Incompatible stack heights: 3 vs 1
			//IL_0253->IL015a: Incompatible stack types: I4 vs Obj
			//IL_046b->IL0156: Incompatible stack heights: 1 vs 0
			//IL_0504->IL015a: Incompatible stack heights: 2 vs 1
			//IL_0369->IL015a: Incompatible stack heights: 2 vs 1
			//IL_044a->IL015a: Incompatible stack types: I4 vs Obj
			//IL_041f->IL015a: Incompatible stack heights: 3 vs 1
			//IL_037b->IL015a: Incompatible stack heights: 2 vs 1
			//IL_0230->IL015a: Incompatible stack heights: 3 vs 1
			//IL_0240->IL015a: Incompatible stack heights: 4 vs 1
			//IL_0300->IL015a: Incompatible stack heights: 2 vs 1
			//IL_02b1->IL015a: Incompatible stack heights: 2 vs 1
			//IL_055b->IL015a: Incompatible stack heights: 3 vs 1
			//IL_040f->IL015a: Incompatible stack heights: 2 vs 1
			//IL_045a->IL015a: Incompatible stack heights: 3 vs 1
			//IL_03b0->IL015a: Incompatible stack heights: 2 vs 1
			//IL_031a->IL015a: Incompatible stack types: I4 vs Obj
			//IL_0569->IL015a: Incompatible stack heights: 3 vs 1
			//IL_0395->IL015a: Incompatible stack heights: 2 vs 1
			//IL_02be->IL015a: Incompatible stack heights: 2 vs 1
			//IL_0402->IL015a: Incompatible stack heights: 3 vs 1
			//IL_02a4->IL015a: Incompatible stack types: I4 vs Obj
			//IL_050f->IL015a: Incompatible stack heights: 2 vs 1
			//IL_05ba->IL015a: Incompatible stack types: I4 vs Obj
			//IL_058d->IL015a: Incompatible stack heights: 0 vs 1
			//IL_0386->IL015a: Incompatible stack heights: 2 vs 1
			//IL_032c->IL015a: Incompatible stack types: I4 vs Obj
			//IL_030b->IL015a: Incompatible stack heights: 2 vs 1
			//IL_05a8->IL015a: Incompatible stack heights: 3 vs 1
			//IL_04f2->IL015a: Incompatible stack types: I4 vs Obj
			//IL_03bb->IL015a: Incompatible stack heights: 2 vs 1
			//IL_03a0->IL015a: Incompatible stack heights: 2 vs 1
			//IL_0598->IL015a: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 4;
						continue;
					case 5:
						break;
					case 2:
						return;
					case 4:
						if ((nuint)(nint)obj <= (nuint)2u)
						{
							if (1 == 0)
							{
								_ = 5;
							}
							goto IL_0080;
						}
						goto IL_010a;
					case 3:
						if (2 == 0)
						{
							_ = 2;
						}
						continue;
					case 1:
						{
							obj = (object)Unsafe.AsPointer(ref this);
							if (0 == 0)
							{
								obj2 = 0;
							}
							continue;
						}
						IL_010a:
						if ((nint)obj != 3)
						{
							_ = 16;
							goto IL_0080;
						}
						goto IL_066f;
						IL_0080:
						while (true)
						{
							switch ((int)/*Error near IL_00c9: Stack underflow*/)
							{
							case 1:
								return;
							case 15:
								obj = -1;
								_ = 8;
								continue;
							case 2:
								_ = ref obj;
								if (false)
								{
									_ = 1;
								}
								continue;
							case 14:
								goto end_IL_0080;
							case 12:
							{
								object obj3;
								switch ((int)obj)
								{
								default:
									if (12 == 0)
									{
										obj3 = 16;
									}
									goto IL_015a;
								case 1:
									obj = (object)Unsafe.AsPointer(ref this);
									obj3 = 45;
									goto IL_015a;
								case 0:
									goto IL_04a6;
								case 2:
									goto IL_053c;
									IL_0156:
									obj3 = obj;
									goto IL_015a;
									IL_015a:
									while (true)
									{
										switch ((int)obj3)
										{
										case 5:
											return;
										case 11:
											return;
										case 13:
											return;
										case 26:
											obj = -1;
											_ = 41;
											continue;
										case 28:
											_ = ref obj;
											_ = 11;
											continue;
										case 10:
										case 17:
											obj = 500;
											obj3 = 36;
											continue;
										case 9:
										case 35:
											obj3 = obj;
											obj = (object)Unsafe.AsPointer(ref this);
											if (16 == 0)
											{
												obj3 = 21;
											}
											continue;
										case 33:
											_ = 24;
											continue;
										case 45:
											_ = 8;
											continue;
										case 23:
										case 34:
											goto IL_02da;
										case 30:
											if (6 == 0)
											{
												_ = 4;
											}
											continue;
										case 19:
										case 41:
											obj = (object)(&obj);
											obj3 = 30;
											continue;
										case 27:
										case 29:
											if (&obj == null)
											{
												obj3 = 17;
												continue;
											}
											goto case 44;
										case 16:
											obj = (object)Unsafe.AsPointer(ref this);
											_ = 20;
											continue;
										case 25:
											obj = 0;
											if (15 == 0)
											{
												_ = 40;
											}
											continue;
										case 44:
											_ = 1;
											if (0 == 0)
											{
												_ = 0;
											}
											continue;
										case 40:
											if (10 == 0)
											{
												_ = 28;
											}
											continue;
										case 31:
											goto end_IL_015a;
										case 7:
											_ = ref obj;
											if (5 == 0)
											{
												_ = 0;
											}
											continue;
										case 14:
										case 38:
											_ = ref obj;
											_ = 22;
											continue;
										case 24:
											obj = -1;
											_ = 38;
											continue;
										case 2:
											_ = 3;
											continue;
										case 22:
											obj = (object)Unsafe.AsPointer(ref this);
											obj3 = 4;
											continue;
										case 39:
											obj = 1;
											_ = 2;
											continue;
										case 12:
											goto IL_045a;
										case 4:
											_ = obj + 1;
											_ = 23;
											continue;
										case 46:
											goto IL_04a6;
										case 8:
											obj = -1;
											_ = 29;
											continue;
										case 36:
											if (&obj != null)
											{
												obj3 = 14;
												continue;
											}
											goto case 15;
										case 15:
											obj = 2;
											if (40 == 0)
											{
												_ = 43;
											}
											continue;
										case 6:
											goto IL_050f;
										case 1:
											goto IL_053c;
										case 37:
											_ = 0;
											_ = 34;
											continue;
										case 43:
											_ = 7;
											continue;
										case 3:
											_ = ref obj;
											_ = 13;
											continue;
										case 21:
											if (&obj != null)
											{
												if (20 == 0)
												{
													obj3 = 27;
												}
												continue;
											}
											goto case 39;
										case 18:
											throw /*Error near IL_059b: Stack underflow*/;
										case 20:
											if (&obj != null)
											{
												obj3 = 19;
												continue;
											}
											goto case 25;
										case 42:
											goto end_IL_012e;
										}
										goto IL_026f;
										IL_02da:
										if ((nint)Unsafe.AsPointer(ref this) >= (nint)5)
										{
											goto IL_026f;
										}
										goto IL_02e2;
										IL_026f:
										if (Unsafe.AsPointer(ref this) != null)
										{
											_ = null;
											_ = 42;
											continue;
										}
										goto IL_0276;
										continue;
										end_IL_015a:
										break;
									}
									goto case 1;
									IL_053c:
									obj = (object)Unsafe.AsPointer(ref this);
									obj = 33;
									goto IL_0156;
									IL_050f:
									_ = 0;
									obj = 37;
									goto IL_0156;
									IL_04a6:
									obj = (object)Unsafe.AsPointer(ref this);
									obj3 = 12;
									goto IL_015a;
									IL_045a:
									obj = 26;
									goto IL_0156;
									IL_02e2:
									obj = 35;
									goto IL_0156;
									IL_0276:
									obj = 18;
									goto IL_0156;
									end_IL_012e:
									break;
								}
								goto case 7;
							}
							case 7:
								_ = 9;
								_ = 8;
								_ = 2;
								_ = 10;
								_ = 7;
								obj = 1;
								_ = 13;
								continue;
							case 8:
							case 11:
								obj = (object)(&obj);
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							case 6:
								goto IL_066f;
							case 13:
								if (&obj != null)
								{
									_ = 11;
									continue;
								}
								goto case 9;
							case 10:
								if (15 == 0)
								{
									_ = 0;
								}
								continue;
							case 3:
							case 5:
								_ = 12;
								continue;
							case 4:
								_ = 2;
								continue;
							case 9:
								obj = 3;
								_ = 4;
								continue;
							case 16:
								obj = 3;
								continue;
							}
							goto end_IL_0019;
							continue;
							end_IL_0080:
							break;
						}
						goto IL_010a;
						IL_066f:
						obj = (object)Unsafe.AsPointer(ref this);
						if (10 == 0)
						{
							_ = 6;
						}
						goto IL_0080;
						end_IL_0019:
						break;
					}
					break;
				}
				_ = -2;
				obj = 3;
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
		private sealed void _FF00_FF00_FF00_2E00(object P_0)
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
		internal unsafe static byte _FF00_FF00_FF00_2F00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779102, new IntPtr(2737336611516L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_3000()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_3100()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		int num = (startHeartbeat ? 1 : 0);
		if (false)
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
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
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
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
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
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_007a: Expected Obj, but got Ref
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_00b3->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0088->IL0019: Incompatible stack heights: 3 vs 1
		//IL_004f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0098->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0075->IL0019: Incompatible stack types: I4 vs Ref
		//IL_005a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ce->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a3->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		ref object reference = ref *(object*)obj;
		while (true)
		{
			switch ((uint)Unsafe.AsPointer(ref reference))
			{
			case 3u:
				_ = ref obj;
				if (3 != 0)
				{
					_ = 5;
				}
				break;
			case 2u:
				reference = ref obj;
				if (true)
				{
					reference = ref *(object*)1;
				}
				break;
			case 6u:
				return (Task<EntityUserSkin>)(&obj);
			case 1u:
				_ = ref obj;
				_ = 4;
				break;
			case 5u:
				_ = ref obj;
				_ = -1;
				if (false)
				{
					_ = 0;
				}
				break;
			default:
				_ = ref obj;
				_ = ref obj;
				_ = 6;
				break;
			case 4u:
				_ = ref obj;
				if (1 == 0)
				{
					_ = 3;
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
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_004e: Expected Obj, but got Ref
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_007b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0049->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0096->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0060->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0086->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00bc->IL0019: Incompatible stack types: I4 vs Ref
		//IL_00a1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006b->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		ref object reference = ref *(object*)obj;
		while (true)
		{
			switch ((uint)Unsafe.AsPointer(ref reference))
			{
			case 2u:
				_ = ref obj;
				_ = 3;
				break;
			case 5u:
				return (Task<EntityGameClientPatch>)(&obj);
			case 4u:
				_ = ref obj;
				_ = ref obj;
				if (3 == 0)
				{
					_ = 5;
				}
				break;
			default:
				_ = ref obj;
				if (true)
				{
					_ = 2;
				}
				break;
			case 3u:
				_ = ref obj;
				_ = -1;
				if (3 == 0)
				{
					_ = 4;
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
		//IL_000e: Expected Obj, but got I4
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (Task<Entities<EntityNetGameItem>>)(P_0 * 50);
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
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_0097: Expected Obj, but got Ref
		//IL_0087->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a7->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00d0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0092->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0075->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00db->IL0019: Incompatible stack heights: 2 vs 1
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
				_ = ref obj;
				if (0 == 0)
				{
					_ = 1;
				}
				break;
			case 5:
				_ = ref obj;
				if (2 != 0)
				{
					_ = 6;
				}
				break;
			default:
				_ = ref obj;
				_ = ref obj;
				if (2 == 0)
				{
					_ = 2;
				}
				break;
			case 2:
				return (Task<EntityGameCharacter[]>)(&obj);
			case 1:
				_ = ref obj;
				if (5 != 0)
				{
					_ = 0;
				}
				break;
			case 4:
				_ = ref obj;
				_ = 3;
				break;
			case 6:
				_ = ref obj;
				_ = -1;
				if (false)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<PageModel<IDesktopSkin>> _FF00_FF00_FF00_FF00_FF00䔀(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00bc: Expected Obj, but got Ref
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_0066->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00ac->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0076->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b7->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009c->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0081->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0058->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		ref object reference = ref *(object*)obj;
		while (true)
		{
			switch ((uint)Unsafe.AsPointer(ref reference))
			{
			case 5u:
				_ = ref obj;
				_ = ref obj;
				if (true)
				{
					_ = 1;
				}
				break;
			default:
				_ = ref obj;
				_ = -1;
				_ = 5;
				break;
			case 4u:
				_ = ref obj;
				if (false)
				{
					_ = 0;
				}
				break;
			case 3u:
				reference = ref obj;
				if (2 == 0)
				{
					reference = ref *(object*)2;
				}
				break;
			case 2u:
				_ = ref obj;
				if (4 == 0)
				{
					_ = 4;
				}
				break;
			case 1u:
				return (Task<PageModel<IDesktopSkin>>)(&obj);
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
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0093: Expected Obj, but got Ref
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_0083->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a1->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00b1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0066->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00bc->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0071->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0056->IL0019: Incompatible stack types: I4 vs Ref
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		ref object reference = ref *(object*)obj;
		while (true)
		{
			switch ((uint)Unsafe.AsPointer(ref reference))
			{
			case 5u:
				reference = ref obj;
				if (4 == 0)
				{
					reference = ref *(object*)4;
				}
				break;
			case 4u:
				_ = ref obj;
				if (2 != 0)
				{
					_ = 2;
				}
				break;
			case 1u:
				_ = ref obj;
				_ = ref obj;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			default:
				return (Task<PageModel<IDesktopSkin>>)(&obj);
			case 2u:
				_ = ref obj;
				_ = 3;
				break;
			case 3u:
				_ = ref obj;
				_ = -1;
				if (1 == 0)
				{
					_ = 1;
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
	internal object _FF00_FF00_FF00_FF00_FF00倀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0066: Expected I4, but got Obj
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_01d7: Expected Obj, but got I4
		//IL_0137: Expected Obj, but got I4
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_0134->IL0019: Incompatible stack heights: 10 vs 1
		//IL_0112->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0102->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00c6->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01e1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0194->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0141->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0174->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01c9->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0158->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00f5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0088->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01d4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0163->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a8->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				if (3 != 0)
				{
					obj2 = 1;
				}
				break;
			case 15:
				if ((nint)obj == 3)
				{
					if (12 == 0)
					{
						obj2 = 4;
					}
					break;
				}
				goto case 5;
			case 12:
				obj = obj;
				obj2 = 10;
				break;
			case 7:
				obj = (object)/*Error near IL_00ba: Stack underflow*/;
				if (0 == 0)
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
				obj = obj;
				obj2 = 2;
				break;
			case 2:
				_ = 17;
				break;
			case 10:
				obj = 0;
				obj2 = 13;
				break;
			case 1:
			case 13:
				if ((nint)obj < ((Array)obj).Length)
				{
					if (false)
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
				/*Error near IL_0195: Stack underflow*/;
				return obj;
			case 17:
				obj++;
				if (true)
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
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_0044: Expected Obj, but got Ref
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_009a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0052->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0062->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c1->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00b3->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00a5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0088->IL0019: Incompatible stack types: I4 vs Ref
		//IL_006d->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		ref object reference = ref *(object*)obj;
		while (true)
		{
			switch ((uint)Unsafe.AsPointer(ref reference))
			{
			case 5u:
				return (Task<EntityGameModsHash>)(&obj);
			case 1u:
				_ = ref obj;
				_ = 4;
				break;
			case 3u:
				_ = ref obj;
				_ = -1;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 2u:
				reference = ref obj;
				if (1 == 0)
				{
					reference = ref *(object*)null;
				}
				break;
			default:
				_ = ref obj;
				_ = ref obj;
				if (1 == 0)
				{
					_ = 5;
				}
				break;
			case 6u:
				_ = ref obj;
				_ = 3;
				break;
			case 4u:
				_ = ref obj;
				_ = 6;
				break;
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
		//IL_0010: Expected Obj, but got I4
		//IL_003e: Expected I4, but got Obj
		//IL_008c: Expected Obj, but got Ref
		//IL_00e0->IL0019: Incompatible stack heights: 3 vs 1
		//IL_006c->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00c7->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ac->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0053->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00d2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b7->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0087->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 6:
				_ = ref obj;
				if (false)
				{
					_ = 0;
				}
				break;
			case 2:
				_ = ref obj;
				_ = 6;
				break;
			case 7:
				_ = ref obj;
				if (2 == 0)
				{
					_ = 2;
				}
				break;
			case 1:
				return (object)(&obj);
			case 4:
				_ = ref obj;
				_ = 3;
				break;
			case 5:
				_ = ref obj;
				_ = ref obj;
				if (0 == 0)
				{
					_ = 1;
				}
				break;
			case 3:
				_ = ref obj;
				if (3 != 0)
				{
					_ = 7;
				}
				break;
			default:
				_ = ref obj;
				_ = -1;
				_ = 5;
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
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
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
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
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
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00a1: Expected Obj, but got Ref
		//IL_004d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0091->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0066->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00af->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0076->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0058->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0081->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				_ = ref obj;
				_ = ref obj;
				if (false)
				{
					_ = 0;
				}
				break;
			case 3:
				_ = ref obj;
				_ = 2;
				break;
			case 5:
				_ = ref obj;
				_ = -1;
				if (true)
				{
					_ = 1;
				}
				break;
			case 2:
				_ = ref obj;
				if (2 != 0)
				{
					_ = 4;
				}
				break;
			default:
				return (Task<Entities<EntityNetGameItem>>)(&obj);
			case 4:
				_ = ref obj;
				_ = 5;
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
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
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
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_00a5: Expected Obj, but got Ref
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_004d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_007a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0095->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00d0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0085->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c0->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0068->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00db->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		ref object reference = ref *(object*)obj;
		while (true)
		{
			switch ((uint)Unsafe.AsPointer(ref reference))
			{
			default:
				_ = ref obj;
				_ = 5;
				break;
			case 5u:
				_ = ref obj;
				if (6 == 0)
				{
					_ = 5;
				}
				break;
			case 1u:
				_ = ref obj;
				_ = ref obj;
				if (2 == 0)
				{
					_ = 2;
				}
				break;
			case 3u:
				_ = ref obj;
				if (false)
				{
					_ = 0;
				}
				break;
			case 2u:
				return (Task<EntityItemChannel[]>)(&obj);
			case 4u:
				reference = ref obj;
				if (true)
				{
					reference = ref *(object*)3;
				}
				break;
			case 6u:
				_ = ref obj;
				_ = -1;
				if (1 == 0)
				{
					_ = 1;
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
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_006c: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got Ref
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_008f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0071->IL0015: Incompatible stack heights: 2 vs 0
		//IL_004f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00ba->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00aa->IL0019: Incompatible stack types: I4 vs Ref
		//IL_005a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c5->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		while (true)
		{
			ref object reference = ref *(object*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 3u:
					_ = ref obj;
					_ = -1;
					if (false)
					{
						_ = 0;
					}
					continue;
				case 4u:
					return (Task<EntityAuthItem>)(&obj);
				case 1u:
					break;
				case 5u:
					_ = ref obj;
					_ = 3;
					continue;
				default:
					_ = ref obj;
					_ = ref obj;
					_ = 4;
					continue;
				case 2u:
					reference = ref obj;
					if (true)
					{
						reference = ref *(object*)1;
					}
					continue;
				case 6u:
					_ = ref obj;
					if (4 == 0)
					{
						_ = 5;
					}
					continue;
				}
				break;
			}
			_ = ref obj;
			obj = 6;
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
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0093: Expected Obj, but got Ref
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_00bc->IL0019: Incompatible stack heights: 3 vs 1
		//IL_004d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0068->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0083->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0058->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0073->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ae->IL0019: Incompatible stack types: I4 vs Ref
		//IL_008e->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		ref object reference = ref *(object*)obj;
		while (true)
		{
			switch ((uint)Unsafe.AsPointer(ref reference))
			{
			case 2u:
				_ = ref obj;
				_ = ref obj;
				if (1 == 0)
				{
					_ = 1;
				}
				break;
			case 3u:
				_ = ref obj;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 5u:
				_ = ref obj;
				_ = -1;
				if (true)
				{
					_ = 2;
				}
				break;
			case 1u:
				return (Task<EntityItemDownload>)(&obj);
			case 4u:
				reference = ref obj;
				if (3 == 0)
				{
					reference = ref *(object*)3;
				}
				break;
			default:
				_ = ref obj;
				_ = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00紀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0059->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0042->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0073->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004d->IL0019: Incompatible stack heights: 2 vs 1
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
				_ = null;
				if (1 == 0)
				{
					_ = 1;
				}
				break;
			default:
				_ = 3;
				break;
			case 1:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
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
		//IL_0010: Expected Obj, but got I4
		//IL_003e: Expected I4, but got Obj
		//IL_00f1: Expected Obj, but got Ref
		//IL_0086: Expected Obj, but got I4
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_00b8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ec->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00d3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008b->IL0015: Incompatible stack heights: 2 vs 0
		//IL_006e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a6->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00de->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005e->IL0019: Incompatible stack types: I4 vs Ref
		//IL_0079->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 6;
		while (true)
		{
			ref object reference = ref *(object*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 6u:
					reference = ref obj;
					if (5 == 0)
					{
						reference = ref *(object*)1;
					}
					continue;
				case 7u:
					_ = ref obj;
					if (4 != 0)
					{
						_ = 2;
					}
					continue;
				case 5u:
					break;
				case 2u:
					_ = ref obj;
					if (7 == 0)
					{
						_ = 3;
					}
					continue;
				default:
					_ = ref obj;
					_ = ref obj;
					if (1 == 0)
					{
						_ = 1;
					}
					continue;
				case 4u:
					_ = ref obj;
					_ = -1;
					if (0 == 0)
					{
						_ = 0;
					}
					continue;
				case 3u:
					_ = ref obj;
					_ = 2;
					continue;
				case 1u:
					return (Task<EntityGameCharacter>)(&obj);
				}
				break;
			}
			_ = ref obj;
			obj = 3;
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
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_008a: Expected Obj, but got Ref
		//IL_00a8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0098->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00c1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00b3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0068->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0085->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 6:
				_ = ref obj;
				_ = -1;
				_ = 5;
				break;
			case 4:
				_ = ref obj;
				if (false)
				{
					_ = 0;
				}
				break;
			case 5:
				_ = ref obj;
				_ = ref obj;
				if (1 == 0)
				{
					_ = 0;
				}
				break;
			case 1:
				return (Task<PageModel<IDesktopSkin>>)(&obj);
			case 2:
				_ = ref obj;
				_ = 4;
				break;
			default:
				_ = ref obj;
				if (6 == 0)
				{
					_ = 6;
				}
				break;
			case 3:
				_ = ref obj;
				_ = 2;
				break;
			}
		}
	}
}
