using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Mass.Application.Desktop;
using Mass.Common.Extensions;
using Mass.Domain.Desktop.Entities.LanGame;
using Serilog;

namespace Mass.Game.Launcher.Java.LanGame;

public class DesktopTransfer : IDisposable
{
	private record TransferCallBack
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (Type)_FF00_FF00_FF00_FF00_FF00_FF00洀();
			}
		}

		public DesktopTransfer Transfer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (DesktopTransfer)_FF00_FF00_FF00_FF00_FF00_FF00嬀();
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			init
			{
				_FF00_FF00_FF00_FF00_FF00_FF00匀(value);
			}
		}

		public ushort Sid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _FF00_FF00_FF00_FF00_FF00_FF00夀();
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			init
			{
				_FF00_FF00_FF00_FF00_FF00_FF00搀(value);
			}
		}

		public byte[] Data
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (byte[])_FF00_FF00_FF00_FF00_FF00_FF00䴀();
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			init
			{
				_FF00_FF00_FF00_FF00_FF00_FF00䈀(value);
			}
		}

		internal static object MeasureTree;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TransferCallBack(DesktopTransfer Transfer, ushort Sid, byte[] Data)
		{
			//IL_004a: Expected I4, but got Obj
			//IL_0038->IL0041: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			TransferCallBack transferCallBack = this;
			if (false)
			{
				transferCallBack = (TransferCallBack)0;
			}
			switch ((int)transferCallBack)
			{
			case 0:
				break;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T As<T>() where T : new()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public override string ToString()
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00戀();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00樀(builder) != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public static bool operator !=(object? left, object? right)
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00伀(left, right) != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public static bool operator ==(object? left, object? right)
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00嘀(left, right) != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (int)_FF00_FF00_FF00_FF00_FF00_FF00䤀();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public virtual bool Equals(TransferCallBack? other)
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00儀(other) != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected TransferCallBack(TransferCallBack original)
		{
			//IL_003e: Expected I4, but got Obj
			//IL_0020->IL0029: Incompatible stack types: I4 vs Obj
			//IL_006d->IL0029: Incompatible stack heights: 3 vs 1
			//IL_0053->IL0029: Incompatible stack heights: 2 vs 1
			//IL_007d->IL0029: Incompatible stack heights: 2 vs 1
			//IL_005e->IL0029: Incompatible stack heights: 2 vs 1
			//IL_0088->IL0029: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			TransferCallBack transferCallBack = this;
			if (0 == 0)
			{
				transferCallBack = (TransferCallBack)2;
			}
			while (true)
			{
				switch ((int)transferCallBack)
				{
				default:
					return;
				case 2:
					if (false)
					{
						_ = 1;
					}
					break;
				case 0:
					return;
				case 1:
					_ = 3;
					break;
				case 3:
					if (false)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public unsafe void Deconstruct(out DesktopTransfer Transfer, out ushort Sid, out byte[] Data)
		{
			_FF00_FF00_FF00_FF00_FF00_FF00䬀((nint)Unsafe.AsPointer(ref Transfer), (nint)Unsafe.AsPointer(ref Sid), (nint)Unsafe.AsPointer(ref Data));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RemoveFilter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TransferCallBack CheckExpandableHandler()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00䄀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779304, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _FF00_FF00_FF00_FF00_FF00_FF00䈀(object P_0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00䌀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779303, new IntPtr(2737367911964L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00䐀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00䔀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779302, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal object _FF00_FF00_FF00_FF00_FF00_FF00䘀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00䜀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779301, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00䠀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779300, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
			return (uint)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal uint _FF00_FF00_FF00_FF00_FF00_FF00䤀()
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected I4, but got Unknown
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (uint)(((this * -1521134295 + this) * -1521134295 + this) * -1521134295 + this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00䨀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779299, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
			return (uint)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00䬀(nint P_0, nint P_1, nint P_2)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002e: Expected I4, but got Obj
			//IL_0037: Expected I4, but got Obj
			//IL_0043->IL0019: Incompatible stack heights: 0 vs 1
			//IL_005e->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0079->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004e->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0069->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0084->IL0019: Incompatible stack types: I4 vs Obj
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
				case 1:
					*(short*)P_1 = (short)(int)this;
					if (3 == 0)
					{
						obj2 = 2;
					}
					break;
				case 2:
					Unsafe.Write((void*)P_0, this);
					if (0 == 0)
					{
						obj2 = 1;
					}
					break;
				case 3:
					Unsafe.Write((void*)P_2, this);
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
		internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00䰀(nint P_0, nint P_1, nint P_2)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779298, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal object _FF00_FF00_FF00_FF00_FF00_FF00䴀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00一()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779297, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00伀(object P_0, object P_1)
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (P_1 == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00倀(object P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779296, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal byte _FF00_FF00_FF00_FF00_FF00_FF00儀(object P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0042: Expected I4, but got Obj
			//IL_005d: Expected I4, but got Obj
			//IL_00c1->IL0056: Incompatible stack heights: 1 vs 0
			//IL_0108->IL00d8: Incompatible stack heights: 1 vs 0
			//IL_00e3->IL00b6: Incompatible stack heights: 1 vs 0
			//IL_0112->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00ed->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0073->IL0019: Incompatible stack heights: 0 vs 1
			//IL_00fe->IL0019: Incompatible stack types: I4 vs Obj
			//IL_00d8->IL0019: Incompatible stack types: I4 vs Obj
			//IL_007e->IL0019: Incompatible stack types: I4 vs Obj
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
					return (byte)(int)P_0;
				case 6:
				case 7:
				case 8:
					return 0;
				case 4:
					if (P_0 != null)
					{
						if (0 == 0)
						{
							obj2 = 1;
						}
						break;
					}
					goto case 6;
				default:
					obj2 = this;
					if (P_0 == null)
					{
						if (6 != 0)
						{
							obj2 = 2;
						}
						break;
					}
					goto case 2;
				case 3:
					if (P_0 == null)
					{
						_ = 8;
						break;
					}
					goto default;
				case 5:
					if ((object)this == P_0)
					{
						return 1;
					}
					obj2 = 4;
					break;
				case 1:
					if (P_0 == null)
					{
						_ = 7;
						break;
					}
					goto case 3;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00刀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779231, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _FF00_FF00_FF00_FF00_FF00_FF00匀(object P_0)
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
		internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00吀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779230, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal byte _FF00_FF00_FF00_FF00_FF00_FF00唀(object P_0)
		{
			//IL_000c: Expected I4, but got Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (byte)(int)P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00嘀(object P_0, object P_1)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002a: Expected I4, but got Obj
			//IL_0033: Expected I4, but got Obj
			//IL_0049->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0067->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0054->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0072->IL0019: Incompatible stack types: I4 vs Obj
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
					return (byte)(int)P_1;
				case 1:
					if (P_0 == null)
					{
						return 0;
					}
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				case 2:
					if (P_0 == P_1)
					{
						return 1;
					}
					if (0 == 0)
					{
						obj2 = 1;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00圀(object P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779229, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe ushort _FF00_FF00_FF00_FF00_FF00_FF00堀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779228, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			return (ushort)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ushort _FF00_FF00_FF00_FF00_FF00_FF00夀()
		{
			//IL_000a: Expected I4, but got Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (ushort)(int)this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe ushort _FF00_FF00_FF00_FF00_FF00_FF00娀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779227, new IntPtr(2737367911964L), 15))(null, 0, new IntPtr(0L));
			return (ushort)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal object _FF00_FF00_FF00_FF00_FF00_FF00嬀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00尀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779226, new IntPtr(2737367911964L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00崀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779225, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00帀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00开()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779224, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00愀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779223, new IntPtr(2737367887004L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00戀()
		{
			//IL_0029: Expected Obj, but got I
			//IL_0058: Expected I, but got Obj
			//IL_0051: Expected Obj, but got I
			nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 3383, 1790779222, 0, 0);
			object obj = num;
			if (num == 0)
			{
				obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779222, new IntPtr(2737367911964L), 15);
			}
			return ((delegate*<object, object>)obj)(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00挀(ushort P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779221, new IntPtr(2737367913004L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _FF00_FF00_FF00_FF00_FF00_FF00搀(ushort P_0)
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
		internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00攀(ushort P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779220, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00椀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779219, new IntPtr(2737367883884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected byte _FF00_FF00_FF00_FF00_FF00_FF00樀(object P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_003e: Expected I4, but got Obj
			//IL_00b8->IL0019: Incompatible stack types: I4 vs Obj
			//IL_00c7->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00aa->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0080->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0075->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0065->IL0019: Incompatible stack types: I4 vs Obj
			//IL_009c->IL0019: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 5:
					obj2 = P_0;
					obj = this;
					_ = ref obj;
					if (1 == 0)
					{
						obj2 = 0;
					}
					break;
				default:
					return 1;
				case 7:
					obj2 = 5;
					break;
				case 4:
					obj2 = 3;
					break;
				case 6:
					obj2 = P_0;
					if (false)
					{
						obj2 = 0;
					}
					break;
				case 3:
					obj2 = 2;
					break;
				case 1:
					obj2 = 6;
					break;
				case 2:
					_ = 7;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00欀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779218, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected unsafe object _FF00_FF00_FF00_FF00_FF00_FF00氀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779217, new IntPtr(2737367913004L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected object _FF00_FF00_FF00_FF00_FF00_FF00洀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_000a: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected unsafe object _FF00_FF00_FF00_FF00_FF00_FF00渀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779216, new IntPtr(2737367913004L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CConnectAsync_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopTransfer _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object RateSubscriber;

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
		internal static bool DecorateAdjustableReporter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateGenericChain()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00㜀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779215, new IntPtr(2737367913004L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00㠀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00㤀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779214, new IntPtr(2737367913004L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00㨀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00㬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779213, new IntPtr(2737367913004L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00㴀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_004d: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_00a5: Expected I4, but got Obj
			//IL_01c2: Expected Obj, but got Ref
			//IL_0425: Expected Obj, but got Ref
			//IL_042e: Expected Obj, but got I4
			//IL_0409: Expected Obj, but got Ref
			//IL_0186: Expected Obj, but got Ref
			//IL_0488: Expected Obj, but got I4
			//IL_0287: Expected Obj, but got I4
			//IL_0245: Expected Obj, but got I4
			//IL_04a5: Expected Obj, but got I4
			//IL_0456: Expected Obj, but got I4
			//IL_01e1: Expected Obj, but got I4
			//IL_02b9: Expected Obj, but got I4
			//IL_04b5: Expected Obj, but got I4
			//IL_0195: Expected Obj, but got I4
			//IL_01b9: Expected Obj, but got I4
			//IL_044c: Expected Obj, but got I4
			//IL_0082->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0071->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0059->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
			//IL_008d->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0019: Incompatible stack types: I4 vs Obj
			//IL_01cc->IL00c0: Incompatible stack types: I4 vs Ref
			//IL_0413->IL00c0: Incompatible stack types: I4 vs Ref
			//IL_0190->IL00c0: Incompatible stack types: I4 vs Ref
			//IL_00b1->IL00c0: Incompatible stack heights: 0 vs 1
			//IL_00c0->IL00c0: Incompatible stack types: Obj vs Ref
			//IL_00bc->IL00c0: Incompatible stack types: I4 vs Ref
			//IL_03a1->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_0495->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_02e2->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_01dc->IL00c0: Incompatible stack heights: 4 vs 1
			//IL_04e8->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_04d0->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_0292->IL00c0: Incompatible stack heights: 3 vs 1
			//IL_0421->IL00c0: Incompatible stack heights: 3 vs 1
			//IL_04b0->IL00c0: Incompatible stack heights: 3 vs 1
			//IL_0461->IL00c0: Incompatible stack heights: 3 vs 1
			//IL_033f->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_0332->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_01ee->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_02a9->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_03eb->IL00c0: Incompatible stack heights: 0 vs 1
			//IL_02c4->IL00c0: Incompatible stack heights: 3 vs 1
			//IL_04c0->IL00c0: Incompatible stack heights: 3 vs 1
			//IL_01a2->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_036b->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_01be->IL00bc: Incompatible stack heights: 1 vs 0
			//IL_03ca->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_0451->IL00bc: Incompatible stack heights: 2 vs 0
			//IL_022a->IL00c0: Incompatible stack heights: 3 vs 1
			//IL_02fd->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_031a->IL00c0: Incompatible stack heights: 3 vs 1
			//IL_02d2->IL00c0: Incompatible stack heights: 3 vs 1
			//IL_0277->IL00c0: Incompatible stack heights: 0 vs 1
			//IL_0483->IL00c0: Incompatible stack heights: 4 vs 1
			//IL_025c->IL00c0: Incompatible stack heights: 0 vs 1
			//IL_0394->IL00c0: Incompatible stack types: I4 vs Ref
			//IL_04a0->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_02ed->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_04db->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_0473->IL00c0: Incompatible stack types: I4 vs Ref
			//IL_0353->IL00c0: Incompatible stack heights: 0 vs 1
			//IL_01f9->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_02b4->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_03f6->IL00c0: Incompatible stack types: I4 vs Ref
			//IL_01ad->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_0527->IL00c0: Incompatible stack heights: 0 vs 1
			//IL_0235->IL00c0: Incompatible stack heights: 3 vs 1
			//IL_0308->IL00c0: Incompatible stack heights: 2 vs 1
			//IL_020d->IL00c0: Incompatible stack heights: 0 vs 1
			//IL_0325->IL00c0: Incompatible stack heights: 3 vs 1
			//IL_0282->IL00c0: Incompatible stack types: I4 vs Ref
			//IL_0267->IL00c0: Incompatible stack types: I4 vs Ref
			//IL_035e->IL00c0: Incompatible stack types: I4 vs Ref
			//IL_0532->IL00c0: Incompatible stack types: I4 vs Ref
			//IL_0218->IL00c0: Incompatible stack types: I4 vs Ref
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
					obj = (object)Unsafe.AsPointer(ref this);
					obj2 = 2;
					continue;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (5 != 0)
					{
						obj2 = 2;
					}
					continue;
				case 1:
					_ = 4;
					continue;
				case 4:
					return;
				case 5:
				{
					ref object reference;
					switch ((int)obj)
					{
					default:
						if (34 == 0)
						{
							reference = ref *(object*)23;
						}
						goto IL_00c0;
					case 3:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(object*)7;
						goto IL_00c0;
					case 0:
						goto IL_01be;
					case 2:
						goto IL_0405;
					case 1:
						goto IL_0421;
						IL_00c0:
						while (true)
						{
							switch ((uint)Unsafe.AsPointer(ref reference))
							{
							case 2u:
								return;
							case 16u:
								return;
							case 18u:
								return;
							case 37u:
								return;
							case 39u:
								break;
							case 17u:
								goto end_IL_00c0;
							case 30u:
								obj = 1;
								if (5 == 0)
								{
									_ = 2;
								}
								continue;
							case 29u:
							case 32u:
								goto IL_01ad;
							case 20u:
								goto IL_01be;
							case 6u:
								_ = ref obj;
								_ = 2;
								continue;
							case 23u:
								obj = -1;
								if (false)
								{
									_ = 0;
								}
								continue;
							case 40u:
								if (&obj != null)
								{
									if (8 == 0)
									{
										reference = ref *(object*)8;
									}
									continue;
								}
								goto case 10u;
							case 36u:
								_ = ref obj;
								if (5 == 0)
								{
									_ = 18;
								}
								continue;
							case 11u:
								goto IL_0235;
							case 45u:
								obj = obj;
								if (16 == 0)
								{
									reference = ref *(object*)19;
								}
								continue;
							case 43u:
								if (25 != 0)
								{
									reference = ref *(object*)13;
								}
								continue;
							case 10u:
								obj = 2;
								_ = 42;
								continue;
							case 24u:
								if (11 == 0)
								{
									_ = 4;
								}
								continue;
							case 26u:
								obj = -1;
								_ = 21;
								continue;
							case 42u:
								_ = 6;
								continue;
							case 5u:
								if (41 == 0)
								{
									_ = 23;
								}
								continue;
							case 38u:
								if (23 == 0)
								{
									_ = 36;
								}
								continue;
							case 41u:
								_ = ref obj;
								if (14 != 0)
								{
									_ = 16;
								}
								continue;
							case 22u:
								_ = 23;
								continue;
							case 8u:
							case 21u:
								_ = ref obj;
								_ = 45;
								continue;
							case 19u:
								if (&obj == null)
								{
									if (5 != 0)
									{
										reference = ref *(object*)14;
									}
									continue;
								}
								goto case 3u;
							case 31u:
								_ = 26;
								continue;
							default:
								reference = ref obj;
								if (9 != 0)
								{
									reference = ref *(object*)5;
								}
								continue;
							case 3u:
								_ = ref obj;
								_ = 39;
								continue;
							case 33u:
								_ = 4;
								continue;
							case 25u:
								obj = obj;
								if (6 != 0)
								{
									reference = ref *(object*)40;
								}
								continue;
							case 27u:
								goto IL_0405;
							case 13u:
								_ = 44;
								continue;
							case 1u:
								goto IL_0421;
							case 34u:
								goto IL_0433;
							case 15u:
								obj = -1;
								_ = 3;
								continue;
							case 12u:
								if (&obj != null)
								{
									reference = ref *(object*)29;
									continue;
								}
								goto case 30u;
							case 44u:
								_ = ref obj;
								_ = 37;
								continue;
							case 4u:
								obj = -1;
								if (32 != 0)
								{
									_ = 30;
								}
								continue;
							case 14u:
								obj = 3;
								_ = 13;
								continue;
							case 28u:
								obj = 0;
								_ = 38;
								continue;
							case 9u:
								_ = 1;
								if (6 == 0)
								{
									_ = 24;
								}
								continue;
							case 7u:
								_ = 15;
								continue;
							case 35u:
								if (&obj == null)
								{
									if (28 == 0)
									{
										reference = ref *(object*)3;
									}
									continue;
								}
								goto default;
							}
							goto end_IL_0090;
							continue;
							end_IL_00c0:
							break;
						}
						goto case 3;
						IL_0433:
						obj = obj;
						obj = 35;
						goto IL_00bc;
						IL_0421:
						obj = (object)Unsafe.AsPointer(ref this);
						obj = 33;
						goto IL_00bc;
						IL_0405:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(object*)31;
						goto IL_00c0;
						IL_0235:
						obj = obj;
						obj = 12;
						goto IL_00bc;
						IL_01be:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(object*)22;
						goto IL_00c0;
						IL_01ad:
						_ = ref obj;
						obj = 43;
						goto IL_00bc;
						IL_00bc:
						reference = ref *(object*)obj;
						goto IL_00c0;
						end_IL_0090:
						break;
					}
					break;
				}
				}
				_ = -2;
				if (0 == 0)
				{
					_ = 1;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00㸀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779212, new IntPtr(2737367883884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00㼀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00䀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779211, new IntPtr(2737367887004L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CConnectWebRtc_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopTransfer _003C_003E4__this;

		private object _003Ccts_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		internal static object ReflectRandomEnumerator;

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
		internal static bool CheckCustomParameter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateAdvancedGateway()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_2F00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779210, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_3000(object P_0)
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
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_3100()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_3200()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779209, new IntPtr(2737367913004L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00㐀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_0078: Expected Obj, but got Ref
			//IL_0093: Expected Obj, but got Ref
			//IL_01f2: Expected Obj, but got Ref
			//IL_0230: Expected Obj, but got I4
			//IL_0212: Expected Obj, but got Ref
			//IL_026d: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0084->IL0019: Incompatible stack heights: 0 vs 1
			//IL_009f->IL0019: Incompatible stack heights: 0 vs 1
			//IL_03e7->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0069->IL0019: Incompatible stack heights: 2 vs 1
			//IL_008f->IL0019: Incompatible stack types: I4 vs Ref
			//IL_00aa->IL0019: Incompatible stack types: I4 vs Ref
			//IL_00bc->IL00c0: Incompatible stack heights: 1 vs 0
			//IL_03f2->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0059->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0074->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0166->IL00c0: Incompatible stack heights: 1 vs 0
			//IL_0115->IL00c0: Incompatible stack heights: 2 vs 0
			//IL_0127->IL00c0: Incompatible stack heights: 1 vs 0
			//IL_0143->IL00c0: Incompatible stack heights: 2 vs 0
			//IL_00fb->IL00c0: Incompatible stack heights: 2 vs 0
			//IL_0132->IL00c0: Incompatible stack heights: 1 vs 0
			//IL_014e->IL00c0: Incompatible stack heights: 2 vs 0
			//IL_0106->IL00c0: Incompatible stack heights: 2 vs 0
			//IL_01fc->IL0189: Incompatible stack types: I4 vs Ref
			//IL_017a->IL0189: Incompatible stack heights: 0 vs 1
			//IL_0185->IL0189: Incompatible stack types: I4 vs Ref
			//IL_0256->IL0189: Incompatible stack heights: 2 vs 1
			//IL_020d->IL0189: Incompatible stack types: I4 vs Ref
			//IL_02bf->IL0189: Incompatible stack heights: 2 vs 1
			//IL_0248->IL0189: Incompatible stack heights: 2 vs 1
			//IL_023b->IL0189: Incompatible stack heights: 3 vs 1
			//IL_021c->IL0189: Incompatible stack types: I4 vs Ref
			//IL_028a->IL0189: Incompatible stack heights: 3 vs 1
			//IL_02a3->IL0189: Incompatible stack heights: 3 vs 1
			//IL_0278->IL0189: Incompatible stack heights: 3 vs 1
			//IL_01ee->IL0189: Incompatible stack types: I4 vs Ref
			//IL_0295->IL0189: Incompatible stack heights: 3 vs 1
			//IL_0268->IL0189: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			ref _003CConnectWebRtc_003Ed__35 reference = ref *(_003CConnectWebRtc_003Ed__35*)obj;
			while (true)
			{
				ref object reference2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 5u:
					reference = ref this;
					if (4 != 0)
					{
						reference = ref *(_003CConnectWebRtc_003Ed__35*)1;
					}
					break;
				case 6u:
					_ = -2;
					if (2 == 0)
					{
						_ = 3;
					}
					break;
				default:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 == 0)
					{
						reference = ref *(_003CConnectWebRtc_003Ed__35*)2;
					}
					break;
				case 1u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						reference = ref *(_003CConnectWebRtc_003Ed__35*)null;
					}
					break;
				case 2u:
					if (obj != null)
					{
						_ = 2;
						goto IL_00c0;
					}
					goto IL_014e;
				case 4u:
					return;
				case 3u:
					{
						_ = null;
						if (5 != 0)
						{
							_ = 5;
						}
						break;
					}
					IL_0189:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference2))
						{
						case 11u:
							break;
						case 3u:
							reference2 = ref obj;
							if (true)
							{
								reference2 = ref *(object*)1;
							}
							continue;
						case 5u:
							goto IL_01ee;
						case 1u:
							obj = obj;
							reference2 = ref *(object*)14;
							continue;
						case 8u:
							obj = (object)Unsafe.AsPointer(ref this);
							reference2 = ref *(object*)3;
							continue;
						case 7u:
							obj = 0;
							_ = 10;
							continue;
						case 2u:
						case 6u:
							_ = ref obj;
							_ = 11;
							continue;
						default:
							_ = 8;
							continue;
						case 14u:
							if (&obj != null)
							{
								reference2 = ref *(object*)2;
								continue;
							}
							goto case 7u;
						case 12u:
							obj = -1;
							_ = 6;
							continue;
						case 9u:
							_ = ref obj;
							if (13 == 0)
							{
								_ = 10;
							}
							continue;
						case 10u:
							_ = 9;
							continue;
						case 13u:
							return;
						case 4u:
							_ = 12;
							continue;
						}
						break;
					}
					goto case 6u;
					IL_014e:
					if (4 != 0)
					{
						_ = 5;
					}
					goto IL_00c0;
					IL_00c0:
					while (true)
					{
						switch ((int)/*Error near IL_00dd: Stack underflow*/)
						{
						case 4:
							_ = 10.0;
							if (1 == 0)
							{
								_ = 1;
							}
							continue;
						default:
							_ = 4;
							continue;
						case 2:
							if (3 != 0)
							{
								_ = 3;
							}
							continue;
						case 3:
							_ = 1;
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 1:
							break;
						case 5:
							goto IL_0166;
						}
						break;
					}
					goto IL_014e;
					IL_0166:
					if (obj != null)
					{
						if (0 == 0)
						{
							reference2 = ref *(object*)null;
						}
						goto IL_0189;
					}
					goto IL_01ee;
					IL_01ee:
					obj = (object)Unsafe.AsPointer(ref this);
					reference2 = ref *(object*)4;
					goto IL_0189;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00㔀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00㘀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779208, new IntPtr(2737367913004L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CHandleJoinRoomResponseAsync_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TransferCallBack callback;

		public DesktopTransfer _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object WatchReg;

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
		internal static bool FindExecutor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FlushPredictor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00Ḁ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779207, new IntPtr(2737367884924L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00ἀ(object P_0)
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
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_2000()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_2100()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779206, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_2B00()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0590: Expected Obj, but got Ref
			//IL_0575: Expected Obj, but got Ref
			//IL_042e: Expected Obj, but got Ref
			//IL_0164: Expected I4, but got Obj
			//IL_04bf: Expected Obj, but got I4
			//IL_02cf: Expected Obj, but got Ref
			//IL_0216: Expected Obj, but got I4
			//IL_04ee: Expected Obj, but got I4
			//IL_0266: Expected Obj, but got I4
			//IL_030e: Expected Obj, but got I4
			//IL_0304: Expected Obj, but got I4
			//IL_025c: Expected I4, but got Obj
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_059a->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0581->IL0019: Incompatible stack heights: 0 vs 1
			//IL_05ab->IL0019: Incompatible stack heights: 2 vs 1
			//IL_058c->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0055->IL0019: Incompatible stack types: I4 vs Ref
			//IL_05b6->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0149->IL006b: Incompatible stack heights: 3 vs 1
			//IL_010a->IL006b: Incompatible stack heights: 0 vs 1
			//IL_0139->IL006b: Incompatible stack heights: 2 vs 1
			//IL_0464->IL006b: Incompatible stack heights: 2 vs 1
			//IL_040f->IL006b: Incompatible stack heights: 0 vs 1
			//IL_047f->IL006b: Incompatible stack heights: 0 vs 1
			//IL_04ae->IL006b: Incompatible stack heights: 2 vs 1
			//IL_02d9->IL021f: Incompatible stack types: I4 vs Obj
			//IL_01c2->IL006b: Incompatible stack heights: 0 vs 1
			//IL_006b->IL006b: Incompatible stack heights: 2 vs 1
			//IL_049c->IL006b: Incompatible stack heights: 2 vs 1
			//IL_0326->IL021f: Incompatible stack heights: 2 vs 1
			//IL_0346->IL021f: Incompatible stack heights: 3 vs 1
			//IL_0334->IL021f: Incompatible stack heights: 3 vs 1
			//IL_0271->IL021f: Incompatible stack heights: 3 vs 1
			//IL_0319->IL021f: Incompatible stack heights: 3 vs 1
			//IL_0309->IL021b: Incompatible stack heights: 1 vs 0
			//IL_02c0->IL021f: Incompatible stack heights: 0 vs 1
			//IL_02ed->IL021f: Incompatible stack heights: 0 vs 1
			//IL_0351->IL021f: Incompatible stack heights: 3 vs 1
			//IL_02a3->IL021f: Incompatible stack heights: 0 vs 1
			//IL_02cb->IL021f: Incompatible stack types: I4 vs Obj
			//IL_02f8->IL021f: Incompatible stack types: I4 vs Obj
			//IL_02ae->IL021f: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			ref _003CHandleJoinRoomResponseAsync_003Ed__34 reference = ref *(_003CHandleJoinRoomResponseAsync_003Ed__34*)obj;
			while (true)
			{
				int num;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 2u:
					reference = ref this;
					if (4 == 0)
					{
						reference = ref *(_003CHandleJoinRoomResponseAsync_003Ed__34*)3;
					}
					continue;
				case 5u:
					if (obj != null)
					{
						num = 6;
						goto IL_006b;
					}
					goto IL_018e;
				case 1u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						reference = ref *(_003CHandleJoinRoomResponseAsync_003Ed__34*)null;
					}
					continue;
				default:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CHandleJoinRoomResponseAsync_003Ed__34*)5;
					continue;
				case 4u:
					return;
				case 3u:
					break;
					IL_006b:
					while (true)
					{
						object obj2;
						switch (num)
						{
						case 9:
						case 17:
							num = 18;
							continue;
						case 12:
						case 22:
							num = 5;
							continue;
						case 14:
						case 24:
							if (10 != 0)
							{
								num = 3;
							}
							continue;
						case 1:
							if (obj == null)
							{
								num = 24;
							}
							else
							{
								_ = 14;
							}
							continue;
						case 2:
						case 21:
							_ = 26;
							continue;
						case 8:
							_ = 19;
							continue;
						case 11:
							switch ((int)obj)
							{
							case 0:
								break;
							default:
								goto IL_0164;
							case 3:
								goto IL_0199;
							case 1:
								goto IL_03f9;
							case 4:
								goto IL_0464;
							case 2:
								goto IL_04c4;
							}
							goto case 8;
						case 15:
						case 25:
							num = 13;
							continue;
						case 19:
							break;
						case 7:
							goto IL_0199;
						case 20:
							if ((nint)obj == 17)
							{
								if (0 == 0)
								{
									num = 8;
								}
								continue;
							}
							goto IL_04c4;
						case 16:
							if (obj != null)
							{
								obj = 9;
								goto IL_021b;
							}
							goto IL_02cb;
						case 3:
							goto IL_03f9;
						case 23:
							obj = obj;
							num = 11;
							continue;
						case 6:
							obj = (object)Unsafe.AsPointer(ref this);
							num = 23;
							continue;
						case 4:
							goto IL_0464;
						default:
							goto IL_04c4;
						case 5:
						case 10:
						case 13:
						case 18:
						case 26:
							goto end_IL_0019;
							IL_02cb:
							obj = (object)Unsafe.AsPointer(ref this);
							obj2 = 2;
							goto IL_021f;
							IL_021f:
							while (true)
							{
								switch ((int)obj2)
								{
								case 6:
									obj = 0;
									_ = 5;
									continue;
								case 1:
									return;
								case 9:
									if (obj == null)
									{
										if (0 == 0)
										{
											obj2 = 0;
										}
										continue;
									}
									goto case 11;
								case 11:
									obj = obj;
									if (3 == 0)
									{
										obj2 = 3;
									}
									continue;
								case 10:
									goto IL_02cb;
								case 3:
									if (&obj != null)
									{
										if (10 == 0)
										{
											obj2 = 12;
										}
										continue;
									}
									goto case 6;
								case 8:
								case 12:
									goto IL_02f8;
								case 7:
									obj = -1;
									_ = 8;
									continue;
								case 2:
									_ = 7;
									continue;
								case 5:
									_ = 4;
									continue;
								case 4:
									_ = ref obj;
									if (true)
									{
										_ = 1;
									}
									continue;
								}
								break;
							}
							goto case 1;
							IL_02f8:
							_ = ref obj;
							obj = 13;
							goto IL_021b;
							IL_021b:
							obj2 = obj;
							goto IL_021f;
							IL_0164:
							num = 20;
							continue;
						}
						break;
						IL_04c4:
						object obj3 = obj;
						if (obj3 == null)
						{
							num = 2;
						}
						else
						{
							obj = 21;
						}
						continue;
						IL_0199:
						if (obj == null)
						{
							num = 12;
						}
						else
						{
							_ = 22;
						}
						continue;
						IL_03f9:
						obj3 = obj;
						if (obj3 == null)
						{
							if (25 == 0)
							{
								num = 15;
							}
						}
						else
						{
							obj = 15;
						}
						continue;
						IL_0464:
						if (obj == null)
						{
							if (9 != 0)
							{
								num = 5;
							}
						}
						else
						{
							_ = 17;
						}
					}
					goto IL_018e;
					IL_018e:
					num = 16;
					goto IL_006b;
					end_IL_0019:
					break;
				}
				_ = -2;
				if (2 == 0)
				{
					_ = 2;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00Ⰰ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779205, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00ⴀ()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_2E00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779204, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CHandshakeAsync_003Ed__46 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopTransfer _003C_003E4__this;

		private object _003Ccts_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		internal static object DecorateSegmentedResponder;

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
		internal static bool SetupNode()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ViewFunction()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_1400(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779203, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00ᔀ(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00ᘀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779202, new IntPtr(2737367893244L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00ᜀ()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_1800()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779201, new IntPtr(2737367890124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00ᤀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779200, new IntPtr(2737367913004L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00ᨀ()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_04f6: Expected Obj, but got Ref
			//IL_04db: Expected Obj, but got Ref
			//IL_04d2: Expected Obj, but got I4
			//IL_0330: Expected Obj, but got Ref
			//IL_0180: Expected Obj, but got I4
			//IL_01df: Expected Obj, but got Ref
			//IL_0276: Expected Obj, but got I4
			//IL_0397: Expected Obj, but got I4
			//IL_0369: Expected Obj, but got I4
			//IL_018f: Expected Obj, but got Ref
			//IL_01b3: Expected Obj, but got I4
			//IL_01cc: Expected Obj, but got I4
			//IL_01d5: Expected Obj, but got I4
			//IL_0234: Expected Obj, but got I4
			//IL_004c->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0500->IL0019: Incompatible stack types: I4 vs Obj
			//IL_04e7->IL0019: Incompatible stack heights: 0 vs 1
			//IL_04d7->IL0015: Incompatible stack heights: 1 vs 0
			//IL_005d->IL0019: Incompatible stack heights: 2 vs 1
			//IL_04f2->IL0019: Incompatible stack types: I4 vs Obj
			//IL_007b->IL007f: Incompatible stack heights: 1 vs 0
			//IL_0068->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00d1->IL007f: Incompatible stack heights: 1 vs 0
			//IL_00ae->IL007f: Incompatible stack heights: 2 vs 0
			//IL_00e3->IL00e7: Incompatible stack heights: 1 vs 0
			//IL_00b9->IL007f: Incompatible stack heights: 2 vs 0
			//IL_0347->IL00e7: Incompatible stack heights: 1 vs 0
			//IL_018b->IL00e7: Incompatible stack heights: 3 vs 0
			//IL_029c->IL00e7: Incompatible stack heights: 3 vs 0
			//IL_0359->IL00e7: Incompatible stack heights: 3 vs 0
			//IL_0208->IL00e7: Incompatible stack heights: 2 vs 0
			//IL_0248->IL00e7: Incompatible stack heights: 1 vs 0
			//IL_01e9->IL00e7: Incompatible stack heights: 1 vs 0
			//IL_0283->IL00e7: Incompatible stack heights: 2 vs 0
			//IL_032c->IL00e7: Incompatible stack heights: 1 vs 0
			//IL_02d8->IL00e7: Incompatible stack heights: 1 vs 0
			//IL_03a4->IL00e7: Incompatible stack heights: 2 vs 0
			//IL_03c3->IL00e7: Incompatible stack heights: 1 vs 0
			//IL_0374->IL00e7: Incompatible stack heights: 3 vs 0
			//IL_0170->IL00e7: Incompatible stack heights: 1 vs 0
			//IL_02aa->IL00e7: Incompatible stack heights: 2 vs 0
			//IL_031e->IL00e7: Incompatible stack heights: 2 vs 0
			//IL_0223->IL00e7: Incompatible stack heights: 4 vs 0
			//IL_0364->IL00e7: Incompatible stack heights: 3 vs 0
			//IL_0213->IL00e7: Incompatible stack heights: 2 vs 0
			//IL_0253->IL00e7: Incompatible stack heights: 1 vs 0
			//IL_028e->IL00e7: Incompatible stack heights: 2 vs 0
			//IL_02e3->IL00e7: Incompatible stack heights: 1 vs 0
			//IL_03af->IL00e7: Incompatible stack heights: 2 vs 0
			//IL_03ce->IL00e7: Incompatible stack heights: 1 vs 0
			//IL_0392->IL00e7: Incompatible stack heights: 1 vs 0
			//IL_017b->IL00e7: Incompatible stack heights: 1 vs 0
			//IL_0239->IL00e3: Incompatible stack heights: 0 vs 1
			//IL_01a6->IL00e7: Incompatible stack heights: 1 vs 0
			//IL_0311->IL00e7: Incompatible stack heights: 1 vs 0
			//IL_00e7->IL00e7: Incompatible stack heights: 2 vs 0
			//IL_02c9->IL00e7: Incompatible stack heights: 1 vs 0
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
						_ = null;
						_ = 3;
						continue;
					case 5:
						return;
					case 6:
						_ = -2;
						if (0 == 0)
						{
							_ = 0;
						}
						continue;
					case 4:
						if ((nuint)(nint)obj > (nuint)1u)
						{
							_ = 2;
							goto IL_007f;
						}
						goto IL_00b9;
					case 3:
						break;
					case 2:
						obj = (object)Unsafe.AsPointer(ref this);
						if (0 == 0)
						{
							obj2 = 1;
						}
						continue;
					case 1:
						{
							obj = (object)Unsafe.AsPointer(ref this);
							obj2 = 4;
							continue;
						}
						IL_032c:
						obj = (object)Unsafe.AsPointer(ref this);
						if (1 == 0)
						{
							_ = 8;
						}
						goto IL_00e7;
						IL_00b9:
						if (1 == 0)
						{
							_ = 0;
						}
						goto IL_007f;
						IL_00e7:
						while (true)
						{
							switch ((int)/*Error near IL_015c: Stack underflow*/)
							{
							case 4:
								return;
							case 19:
								return;
							case 7:
								break;
							case 18:
								if (11 == 0)
								{
									_ = 14;
								}
								continue;
							case 1:
								obj = -1;
								_ = 13;
								continue;
							case 22:
								obj = (object)Unsafe.AsPointer(ref this);
								if (9 == 0)
								{
									_ = 18;
								}
								continue;
							case 25:
								((object[])4)[0] = 257;
								((object[])4)[1] = obj;
								((object[])4)[2] = obj;
								((object[])4)[3] = obj;
								obj = 4;
								obj = 26;
								continue;
							case 10:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 15;
								continue;
							case 6:
								if (true)
								{
									_ = 5;
								}
								continue;
							case 27:
								_ = ref obj;
								_ = 4;
								continue;
							case 20:
								if ((nint)obj != 1)
								{
									obj = 21;
									continue;
								}
								goto case 22;
							case 8:
								if (true)
								{
									_ = 1;
								}
								continue;
							case 11:
								obj = 0;
								if (6 == 0)
								{
									_ = 1;
								}
								continue;
							case 3:
								_ = 27;
								continue;
							case 21:
								_ = 10;
								continue;
							case 26:
								if (&obj != null)
								{
									if (2 == 0)
									{
										_ = 2;
									}
									continue;
								}
								goto case 11;
							case 2:
							case 13:
								_ = ref obj;
								if (17 != 0)
								{
									_ = 5;
								}
								continue;
							case 23:
								if (&obj != null)
								{
									_ = 9;
									continue;
								}
								goto case 16;
							case 9:
							case 24:
								_ = ref obj;
								_ = 12;
								continue;
							case 12:
								_ = 7;
								continue;
							default:
								goto IL_032c;
							case 5:
								_ = ref obj;
								if (19 != 0)
								{
									_ = 12;
								}
								continue;
							case 16:
								obj = 1;
								_ = 3;
								continue;
							case 17:
								obj = obj;
								if (23 == 0)
								{
									_ = 23;
								}
								continue;
							case 14:
								obj = -1;
								if (24 == 0)
								{
									_ = 19;
								}
								continue;
							case 15:
								_ = ref obj;
								if (25 == 0)
								{
									_ = 25;
								}
								continue;
							}
							break;
						}
						goto case 6;
						IL_007f:
						while (true)
						{
							switch ((int)/*Error near IL_0090: Stack underflow*/)
							{
							case 2:
								_ = 10.0;
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							case 1:
								goto IL_00d1;
							}
							break;
						}
						goto IL_00b9;
						IL_00d1:
						if (obj != null)
						{
							_ = 20;
							goto IL_00e7;
						}
						goto IL_032c;
					}
					break;
				}
				obj = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_1B00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779263, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00ᰀ()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00ᴀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779262, new IntPtr(2737367884924L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CHeartbeatAsync_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopTransfer _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object ReflectPortableController;

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
		internal static bool DecorateBasicFinder()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateReadableAllocator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_0C00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779261, new IntPtr(2737367892204L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00_0D00(object P_0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_0E00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779260, new IntPtr(2737367884924L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00ༀ()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00က()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779259, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00ᄀ()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0090: Expected Obj, but got Ref
			//IL_0040: Expected Obj, but got Ref
			//IL_01c5: Expected Obj, but got I4
			//IL_017b: Expected Obj, but got I4
			//IL_0108: Expected Obj, but got Ref
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0081->IL0019: Incompatible stack heights: 2 vs 1
			//IL_009a->IL0019: Incompatible stack types: I4 vs Ref
			//IL_004c->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0071->IL0019: Incompatible stack types: I4 vs Ref
			//IL_00ac->IL00b0: Incompatible stack heights: 1 vs 0
			//IL_008c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0057->IL0019: Incompatible stack types: I4 vs Ref
			//IL_01b1->IL00b0: Incompatible stack heights: 1 vs 0
			//IL_01d0->IL00b0: Incompatible stack heights: 3 vs 0
			//IL_0188->IL00b0: Incompatible stack heights: 2 vs 0
			//IL_015e->IL00b0: Incompatible stack heights: 2 vs 0
			//IL_0176->IL00b0: Incompatible stack heights: 2 vs 0
			//IL_012f->IL00b0: Incompatible stack heights: 4 vs 0
			//IL_00f9->IL00b0: Incompatible stack heights: 1 vs 0
			//IL_0193->IL00b0: Incompatible stack heights: 2 vs 0
			//IL_0169->IL00b0: Incompatible stack heights: 2 vs 0
			//IL_0104->IL00b0: Incompatible stack heights: 1 vs 0
			//IL_011f->IL00b0: Incompatible stack heights: 1 vs 0
			//IL_014e->IL00b0: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			ref _003CHeartbeatAsync_003Ed__48 reference = ref *(_003CHeartbeatAsync_003Ed__48*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 1u:
					return;
				case 5u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (4 == 0)
					{
						reference = ref *(_003CHeartbeatAsync_003Ed__48*)4;
					}
					break;
				default:
					reference = ref this;
					if (false)
					{
						reference = ref *(_003CHeartbeatAsync_003Ed__48*)1;
					}
					break;
				case 3u:
					_ = -2;
					if (0 == 0)
					{
						_ = 0;
					}
					break;
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CHeartbeatAsync_003Ed__48*)2;
					break;
				case 2u:
					{
						if (obj == null)
						{
							_ = 6;
							goto IL_00b0;
						}
						goto IL_0193;
					}
					IL_0193:
					obj = obj;
					if (8 != 0)
					{
						_ = 4;
					}
					goto IL_00b0;
					IL_00b0:
					while (true)
					{
						switch ((int)/*Error near IL_00e5: Stack underflow*/)
						{
						case 7:
							return;
						case 11:
							break;
						case 9:
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 6:
						case 10:
							obj = (object)Unsafe.AsPointer(ref this);
							if (5 != 0)
							{
								_ = 9;
							}
							continue;
						case 5:
							_ = ref obj;
							_ = 7;
							continue;
						case 8:
							if (&obj == null)
							{
								if (false)
								{
									_ = 1;
								}
								continue;
							}
							goto case 4;
						case 2:
							if (5 != 0)
							{
								_ = 1;
							}
							continue;
						case 4:
							_ = ref obj;
							_ = 11;
							continue;
						case 1:
							obj = 0;
							if (2 == 0)
							{
								_ = 2;
							}
							continue;
						case 3:
							goto IL_0193;
						default:
							obj = -1;
							_ = 4;
							continue;
						}
						break;
					}
					goto case 3u;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00ሀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779258, new IntPtr(2737367913004L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00ጀ()
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
	private struct _003CHeartbeatCircleAsync_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopTransfer _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object DecorateRemoteQueue;

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
		internal static bool DecorateActiveSender()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CountIterator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_0300(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779257, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00Ѐ(object P_0)
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
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00Ԁ()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_0600()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779256, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00ࠀ()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_004d: Expected Obj, but got Ref
			//IL_040f: Expected Obj, but got I4
			//IL_0419: Expected Obj, but got I4
			//IL_0367: Expected Obj, but got F8
			//IL_0138: Expected Obj, but got Ref
			//IL_0316: Expected Obj, but got I4
			//IL_027e: Expected Obj, but got Ref
			//IL_022a: Expected Obj, but got I4
			//IL_01e9: Expected Obj, but got I4
			//IL_01c4: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0082->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0049->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0057->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0071->IL0019: Incompatible stack types: I4 vs Ref
			//IL_008d->IL0019: Incompatible stack heights: 2 vs 1
			//IL_009f->IL00a3: Incompatible stack types: I4 vs Ref
			//IL_040a->IL00a3: Incompatible stack types: I4 vs Ref
			//IL_010d->IL00a3: Incompatible stack heights: 0 vs 1
			//IL_0118->IL00a3: Incompatible stack types: I4 vs Ref
			//IL_0134->IL00a3: Incompatible stack heights: 2 vs 1
			//IL_0373->IL00a3: Incompatible stack heights: 0 vs 1
			//IL_03b3->IL00a3: Incompatible stack heights: 2 vs 1
			//IL_0144->IL00a3: Incompatible stack heights: 0 vs 1
			//IL_03ce->IL00a3: Incompatible stack heights: 4 vs 1
			//IL_0323->IL00a3: Incompatible stack heights: 2 vs 1
			//IL_0438->IL00a3: Incompatible stack types: I4 vs Ref
			//IL_00a3->IL00a3: Incompatible stack heights: 3 vs 1
			//IL_037e->IL00a3: Incompatible stack types: I4 vs Ref
			//IL_03be->IL00a3: Incompatible stack heights: 2 vs 1
			//IL_014f->IL00a3: Incompatible stack types: I4 vs Ref
			//IL_03ff->IL00a3: Incompatible stack types: I4 vs Ref
			//IL_032e->IL00a3: Incompatible stack heights: 2 vs 1
			//IL_03e2->IL00a3: Incompatible stack heights: 0 vs 1
			//IL_03a3->IL00a3: Incompatible stack types: I4 vs Ref
			//IL_0295->IL0173: Incompatible stack heights: 1 vs 0
			//IL_016f->IL0173: Incompatible stack heights: 1 vs 0
			//IL_03ed->IL00a3: Incompatible stack types: I4 vs Ref
			//IL_0235->IL0173: Incompatible stack heights: 3 vs 0
			//IL_02a5->IL0173: Incompatible stack heights: 4 vs 0
			//IL_01fd->IL0173: Incompatible stack heights: 1 vs 0
			//IL_0242->IL0173: Incompatible stack heights: 2 vs 0
			//IL_01d1->IL0173: Incompatible stack heights: 2 vs 0
			//IL_01bf->IL0173: Incompatible stack heights: 1 vs 0
			//IL_0173->IL0173: Incompatible stack heights: 3 vs 0
			//IL_0208->IL0173: Incompatible stack heights: 1 vs 0
			//IL_01dc->IL0173: Incompatible stack heights: 2 vs 0
			//IL_0225->IL0173: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			ref _003CHeartbeatCircleAsync_003Ed__38 reference = ref *(_003CHeartbeatCircleAsync_003Ed__38*)obj;
			while (true)
			{
				ref _003CHeartbeatCircleAsync_003Ed__38 reference2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					return;
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CHeartbeatCircleAsync_003Ed__38*)3;
					continue;
				case 5u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CHeartbeatCircleAsync_003Ed__38*)4;
					continue;
				case 1u:
					reference = ref this;
					if (false)
					{
						reference = ref *(_003CHeartbeatCircleAsync_003Ed__38*)null;
					}
					continue;
				case 0u:
					return;
				case 2u:
					break;
				case 3u:
					{
						if (obj == null)
						{
							reference2 = ref *(_003CHeartbeatCircleAsync_003Ed__38*)2;
							goto IL_00a3;
						}
						goto IL_00f9;
					}
					IL_00f9:
					if ((nint)obj != 1)
					{
						if (false)
						{
							reference2 = ref *(_003CHeartbeatCircleAsync_003Ed__38*)10;
						}
						goto IL_00a3;
					}
					goto IL_03ff;
					IL_03ff:
					reference2 = ref *(_003CHeartbeatCircleAsync_003Ed__38*)16;
					goto IL_00a3;
					IL_00a3:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference2))
						{
						case 4u:
							return;
						case 9u:
							break;
						case 11u:
							goto end_IL_00a3;
						default:
							_ = ref obj;
							_ = 14;
							continue;
						case 2u:
						case 12u:
							obj = (object)Unsafe.AsPointer(ref this);
							if (true)
							{
								reference2 = ref *(_003CHeartbeatCircleAsync_003Ed__38*)1;
							}
							continue;
						case 16u:
							if ((nint)obj != 1)
							{
								if (11 == 0)
								{
									_ = 11;
								}
								goto IL_0173;
							}
							goto IL_027a;
						case 15u:
							obj = -1;
							if (5 == 0)
							{
								_ = 5;
							}
							continue;
						case 7u:
							obj = 30.0;
							if (13 != 0)
							{
								reference2 = ref *(_003CHeartbeatCircleAsync_003Ed__38*)17;
							}
							continue;
						case 10u:
						case 18u:
							goto IL_0391;
						case 8u:
							if (13 == 0)
							{
								_ = 13;
							}
							continue;
						case 13u:
							_ = ref obj;
							_ = 4;
							continue;
						case 17u:
							if (&obj != null)
							{
								if (0 == 0)
								{
									reference2 = ref *(_003CHeartbeatCircleAsync_003Ed__38*)null;
								}
								continue;
							}
							goto case 3u;
						case 14u:
							if (obj != null)
							{
								reference2 = ref *(_003CHeartbeatCircleAsync_003Ed__38*)6;
								continue;
							}
							break;
						case 6u:
							goto IL_03ff;
						case 3u:
							obj = 0;
							obj = 8;
							continue;
						case 1u:
							{
								reference2 = ref this;
								if (14 == 0)
								{
									reference2 = ref *(_003CHeartbeatCircleAsync_003Ed__38*)15;
								}
								continue;
							}
							IL_027a:
							obj = (object)Unsafe.AsPointer(ref this);
							if (4 != 0)
							{
								_ = 9;
							}
							goto IL_0173;
							IL_0173:
							while (true)
							{
								switch ((int)/*Error near IL_01a8: Stack underflow*/)
								{
								case 8:
									return;
								case 4:
									if (&obj != null)
									{
										_ = 2;
										continue;
									}
									goto default;
								case 10:
									obj = -1;
									if (7 == 0)
									{
										_ = 7;
									}
									continue;
								case 5:
									obj = 3;
									continue;
								case 2:
								case 7:
									_ = ref obj;
									if (6 == 0)
									{
										_ = 4;
									}
									continue;
								case 11:
									obj = obj;
									if (4 == 0)
									{
										_ = 0;
									}
									continue;
								default:
									obj = 1;
									_ = 5;
									continue;
								case 9:
									_ = 10;
									continue;
								case 1:
									break;
								case 3:
									_ = ref obj;
									_ = 8;
									continue;
								case 6:
									goto IL_0391;
								}
								break;
							}
							goto IL_027a;
							IL_0391:
							if (obj == null)
							{
								reference2 = ref *(_003CHeartbeatCircleAsync_003Ed__38*)9;
								continue;
							}
							goto case 7u;
						}
						goto end_IL_0019;
						continue;
						end_IL_00a3:
						break;
					}
					goto IL_00f9;
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_0900()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779255, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_0A00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779254, new IntPtr(2737367913004L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_0B00()
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
	private struct _003CJoinRoomAsync_003Ed__47 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopTransfer _003C_003E4__this;

		private object _003Ccts_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		internal static object DecorateLiteralProvider;

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
		internal static bool DecorateScalableCalc()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ExecuteChooser()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00豈(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779253, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00切(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00ﬀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779252, new IntPtr(2737367885964L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00ﰀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779251, new IntPtr(2737367913004L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00ﴀ()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FE00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779250, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_005f: Expected Obj, but got Ref
			//IL_0043: Expected Obj, but got Ref
			//IL_020c: Expected Obj, but got Ref
			//IL_0228: Expected Obj, but got I4
			//IL_0232: Expected Obj, but got I4
			//IL_028a: Expected Obj, but got I4
			//IL_0259: Expected Obj, but got I4
			//IL_0263: Expected Obj, but got I4
			//IL_03fe: Expected Obj, but got Ref
			//IL_01f1: Expected Obj, but got Ref
			//IL_023c: Expected Obj, but got I4
			//IL_02af: Expected Obj, but got I4
			//IL_02ca: Expected Obj, but got I4
			//IL_00ad->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0083->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0093->IL0019: Incompatible stack heights: 2 vs 1
			//IL_006b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004f->IL0019: Incompatible stack heights: 0 vs 1
			//IL_00b8->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00cd->IL00dc: Incompatible stack heights: 0 vs 1
			//IL_009e->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0076->IL0019: Incompatible stack types: I4 vs Obj
			//IL_005a->IL0019: Incompatible stack types: I4 vs Obj
			//IL_010b->IL00dc: Incompatible stack heights: 2 vs 1
			//IL_0116->IL00dc: Incompatible stack heights: 2 vs 1
			//IL_0133->IL0137: Incompatible stack types: I4 vs Ref
			//IL_0218->IL0137: Incompatible stack heights: 0 vs 1
			//IL_034e->IL0137: Incompatible stack heights: 0 vs 1
			//IL_0223->IL0137: Incompatible stack types: I4 vs Ref
			//IL_0359->IL0137: Incompatible stack types: I4 vs Ref
			//IL_01b7->IL0137: Incompatible stack heights: 2 vs 1
			//IL_03bf->IL0137: Incompatible stack types: I4 vs Ref
			//IL_0369->IL0137: Incompatible stack heights: 4 vs 1
			//IL_0297->IL0137: Incompatible stack heights: 2 vs 1
			//IL_01d1->IL0137: Incompatible stack heights: 2 vs 1
			//IL_01c4->IL0137: Incompatible stack heights: 2 vs 1
			//IL_01e1->IL0137: Incompatible stack heights: 2 vs 1
			//IL_027a->IL0137: Incompatible stack heights: 3 vs 1
			//IL_040a->IL0137: Incompatible stack heights: 0 vs 1
			//IL_031b->IL0137: Incompatible stack heights: 3 vs 1
			//IL_01fd->IL0137: Incompatible stack heights: 0 vs 1
			//IL_0249->IL0137: Incompatible stack heights: 2 vs 1
			//IL_02d4->IL0137: Incompatible stack heights: 2 vs 1
			//IL_0137->IL0137: Incompatible stack heights: 3 vs 1
			//IL_0392->IL0137: Incompatible stack types: I4 vs Ref
			//IL_02a2->IL0137: Incompatible stack heights: 2 vs 1
			//IL_030d->IL0137: Incompatible stack types: I4 vs Ref
			//IL_01ec->IL0137: Incompatible stack heights: 2 vs 1
			//IL_0285->IL0137: Incompatible stack heights: 3 vs 1
			//IL_0415->IL0137: Incompatible stack types: I4 vs Ref
			//IL_032f->IL0137: Incompatible stack heights: 0 vs 1
			//IL_02ee->IL0137: Incompatible stack types: I4 vs Ref
			//IL_0208->IL0137: Incompatible stack types: I4 vs Ref
			//IL_0254->IL0137: Incompatible stack heights: 2 vs 1
			//IL_03d3->IL0137: Incompatible stack heights: 0 vs 1
			//IL_033a->IL0137: Incompatible stack types: I4 vs Ref
			//IL_03de->IL0137: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 6;
			object obj2 = obj;
			while (true)
			{
				int num;
				ref object reference;
				switch ((int)obj2)
				{
				case 6:
					obj = (object)Unsafe.AsPointer(ref this);
					if (3 == 0)
					{
						obj2 = 5;
					}
					break;
				case 3:
					return;
				case 5:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 1;
					}
					break;
				case 2:
					_ = 3;
					break;
				case 4:
					_ = -2;
					if (false)
					{
						_ = 0;
					}
					break;
				default:
					_ = null;
					if (2 == 0)
					{
						_ = 2;
					}
					break;
				case 1:
					{
						if ((nuint)(nint)obj > (nuint)1u)
						{
							if (0 == 0)
							{
								num = 0;
							}
							goto IL_00dc;
						}
						goto IL_0116;
					}
					IL_0137:
					while (true)
					{
						scoped ref _003CJoinRoomAsync_003Ed__47 reference2;
						int num2;
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 15u:
							return;
						case 20u:
							return;
						case 21u:
							break;
						default:
							_ = 22;
							continue;
						case 11u:
							_ = 23;
							continue;
						case 10u:
							_ = 7;
							continue;
						case 12u:
							if (11 != 0)
							{
								_ = 13;
							}
							continue;
						case 22u:
							obj = (object)Unsafe.AsPointer(ref this);
							if (4 != 0)
							{
								reference = ref *(object*)9;
							}
							continue;
						case 18u:
							goto IL_0208;
						case 1u:
							reference2 = ref this;
							num2 = 0;
							obj = num2;
							obj = 12;
							continue;
						case 23u:
							obj = -1;
							if (17 != 0)
							{
								_ = 5;
							}
							continue;
						case 7u:
							reference2 = ref this;
							num2 = -1;
							obj = num2;
							obj = 2;
							continue;
						case 13u:
							_ = ref obj;
							if (0 == 0)
							{
								_ = 15;
							}
							continue;
						case 6u:
							obj = 1;
							if (19 == 0)
							{
								_ = 3;
							}
							continue;
						case 25u:
							((object[])4)[0] = 514;
							((object[])4)[1] = obj;
							((object[])4)[2] = obj;
							((object[])4)[3] = obj;
							obj = 4;
							_ = 16;
							continue;
						case 17u:
							reference = ref obj;
							if (21 == 0)
							{
								reference = ref *(object*)19;
							}
							continue;
						case 9u:
							reference = ref obj;
							if (3 == 0)
							{
								reference = ref *(object*)25;
							}
							continue;
						case 19u:
							_ = 5;
							continue;
						case 16u:
							if (&obj == null)
							{
								if (0 == 0)
								{
									reference = ref *(object*)1;
								}
								continue;
							}
							goto case 2u;
						case 8u:
							goto IL_033a;
						case 5u:
							_ = ref obj;
							_ = 20;
							continue;
						case 2u:
							reference = ref obj;
							if (2 == 0)
							{
								reference = ref *(object*)4;
							}
							continue;
						case 4u:
							obj = obj;
							reference = ref *(object*)24;
							continue;
						case 24u:
							if (&obj == null)
							{
								if (6 != 0)
								{
									reference = ref *(object*)3;
								}
								continue;
							}
							goto case 17u;
						case 3u:
						case 14u:
							obj = (object)Unsafe.AsPointer(ref this);
							if (10 == 0)
							{
								reference = ref *(object*)1;
							}
							continue;
						}
						break;
					}
					goto case 4;
					IL_0116:
					num = 2;
					goto IL_00dc;
					IL_00dc:
					while (true)
					{
						switch (num)
						{
						default:
							_ = 10.0;
							if (true)
							{
								_ = 1;
							}
							continue;
						case 1:
							break;
						case 2:
							goto IL_0121;
						}
						break;
					}
					goto IL_0116;
					IL_0121:
					if (obj == null)
					{
						reference = ref *(object*)3;
						goto IL_0137;
					}
					goto IL_033a;
					IL_033a:
					if ((nint)obj != 1)
					{
						if (0 == 0)
						{
							reference = ref *(object*)null;
						}
						goto IL_0137;
					}
					goto IL_0208;
					IL_0208:
					obj = (object)Unsafe.AsPointer(ref this);
					if (11 == 0)
					{
						reference = ref *(object*)2;
					}
					goto IL_0137;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00Ā()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779249, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00Ȁ()
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
	private struct _003CReceiveAsync_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopTransfer _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object ReflectGroupedElement;

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
		internal static bool GetTester()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckIsolatedWriter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_EF00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779248, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_F000(object P_0)
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
		internal static object _FF00_FF00_FF00_FF00_FF00_F100()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_F200()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779247, new IntPtr(2737367913004L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_F500()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_005a: Expected Obj, but got Ref
			//IL_0151: Expected Obj, but got I4
			//IL_0123: Expected Obj, but got I4
			//IL_0132: Expected Obj, but got Ref
			//IL_022f: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0066->IL0019: Incompatible stack heights: 0 vs 1
			//IL_049f->IL0019: Incompatible stack heights: 3 vs 1
			//IL_008c->IL0090: Incompatible stack heights: 1 vs 0
			//IL_0056->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0071->IL0019: Incompatible stack types: I4 vs Ref
			//IL_04b9->IL0019: Incompatible stack types: I4 vs Ref
			//IL_00d0->IL00d4: Incompatible stack types: I4 vs Ref
			//IL_00be->IL0090: Incompatible stack heights: 1 vs 0
			//IL_015d->IL00d4: Incompatible stack heights: 0 vs 1
			//IL_01f2->IL00d4: Incompatible stack types: I4 vs Ref
			//IL_01c1->IL00d4: Incompatible stack heights: 4 vs 1
			//IL_012e->IL00d4: Incompatible stack heights: 3 vs 1
			//IL_017a->IL00d4: Incompatible stack heights: 2 vs 1
			//IL_01b1->IL00d4: Incompatible stack heights: 3 vs 1
			//IL_0187->IL00d4: Incompatible stack heights: 2 vs 1
			//IL_013e->IL00d4: Incompatible stack heights: 0 vs 1
			//IL_023c->IL00d4: Incompatible stack heights: 2 vs 1
			//IL_0168->IL00d4: Incompatible stack types: I4 vs Ref
			//IL_022a->IL00d4: Incompatible stack types: I4 vs Ref
			//IL_01d5->IL00d4: Incompatible stack heights: 0 vs 1
			//IL_0149->IL00d4: Incompatible stack types: I4 vs Ref
			//IL_0247->IL00d4: Incompatible stack heights: 2 vs 1
			//IL_01e0->IL00d4: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			ref _003CReceiveAsync_003Ed__39 reference = ref *(_003CReceiveAsync_003Ed__39*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 2u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						reference = ref *(_003CReceiveAsync_003Ed__39*)null;
					}
					break;
				case 3u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 == 0)
					{
						reference = ref *(_003CReceiveAsync_003Ed__39*)2;
					}
					break;
				default:
					if (1 == 0)
					{
						_ = 0;
					}
					while (true)
					{
						ref _003CReceiveAsync_003Ed__39 reference2;
						switch ((int)/*Error near IL_00a1: Stack underflow*/)
						{
						case 1:
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						default:
							if (obj == null)
							{
								reference2 = ref *(_003CReceiveAsync_003Ed__39*)12;
								goto IL_00d4;
							}
							goto IL_01e0;
						case 2:
							break;
							IL_01e0:
							if (obj == null)
							{
								reference2 = ref *(_003CReceiveAsync_003Ed__39*)13;
								goto IL_00d4;
							}
							goto IL_0149;
							IL_00d4:
							while (true)
							{
								switch ((uint)Unsafe.AsPointer(ref reference2))
								{
								case 5u:
									obj = 0;
									_ = 8;
									continue;
								case 11u:
								case 12u:
									obj = (object)Unsafe.AsPointer(ref this);
									if (true)
									{
										reference2 = ref *(_003CReceiveAsync_003Ed__39*)null;
									}
									continue;
								case 15u:
									break;
								case 7u:
									obj = obj;
									_ = 2;
									continue;
								case 4u:
								case 9u:
									_ = ref obj;
									_ = 10;
									continue;
								case 8u:
									_ = 3;
									continue;
								case 3u:
									_ = ref obj;
									_ = 6;
									continue;
								case 2u:
									if (&obj != null)
									{
										if (4 != 0)
										{
											reference2 = ref *(_003CReceiveAsync_003Ed__39*)1;
										}
										continue;
									}
									goto case 5u;
								default:
									goto IL_01e0;
								case 6u:
									return;
								case 1u:
									reference2 = ref this;
									if (12 == 0)
									{
										reference2 = ref *(_003CReceiveAsync_003Ed__39*)14;
									}
									continue;
								case 14u:
									obj = -1;
									if (9 != 0)
									{
										_ = 4;
									}
									continue;
								case 13u:
									goto end_IL_0090;
								}
								break;
							}
							goto IL_0149;
							IL_0149:
							obj = 4096;
							if (false)
							{
								reference2 = ref *(_003CReceiveAsync_003Ed__39*)7;
							}
							goto IL_00d4;
							end_IL_0090:
							break;
						}
						break;
					}
					goto case 5u;
				case 1u:
					return;
				case 5u:
					_ = -2;
					_ = 4;
					break;
				case 4u:
					reference = ref this;
					if (true)
					{
						reference = ref *(_003CReceiveAsync_003Ed__39*)1;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_F600()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779246, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_F700()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779245, new IntPtr(2737367913004L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_F800()
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
	private struct _003CReceiveControlDataAsync_003Ed__42 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopTransfer _003C_003E4__this;

		public byte[] data;

		private TaskAwaiter _003C_003Eu__1;

		internal static object ReflectAutomatableDic;

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
		internal static bool DecorateIterableObject()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectIntegratedDecorator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_E700(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779244, new IntPtr(2737367887004L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_E800(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_E900(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779243, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_EA00()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_EB00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779242, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_EC00()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0068: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_0129: Expected Obj, but got Ref
			//IL_0116: Expected Obj, but got I4
			//IL_016d: Expected Obj, but got I4
			//IL_01d0: Expected Obj, but got Ref
			//IL_01fb: Expected Obj, but got I4
			//IL_0218: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0074->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0064->IL0019: Incompatible stack heights: 3 vs 1
			//IL_007f->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0056->IL0019: Incompatible stack types: I4 vs Ref
			//IL_00ab->IL00af: Incompatible stack types: I4 vs Ref
			//IL_0099->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0138->IL00af: Incompatible stack heights: 7 vs 1
			//IL_014c->IL00af: Incompatible stack heights: 0 vs 1
			//IL_0157->IL00af: Incompatible stack types: I4 vs Ref
			//IL_023e->IL00af: Incompatible stack heights: 3 vs 1
			//IL_0120->IL00af: Incompatible stack heights: 2 vs 1
			//IL_01cc->IL00af: Incompatible stack heights: 4 vs 1
			//IL_0177->IL00af: Incompatible stack heights: 2 vs 1
			//IL_01dc->IL00af: Incompatible stack heights: 0 vs 1
			//IL_0208->IL00af: Incompatible stack heights: 2 vs 1
			//IL_01a3->IL00af: Incompatible stack heights: 2 vs 1
			//IL_0196->IL00af: Incompatible stack heights: 4 vs 1
			//IL_0225->IL00af: Incompatible stack heights: 2 vs 1
			//IL_0258->IL00af: Incompatible stack types: I4 vs Ref
			//IL_01e7->IL00af: Incompatible stack types: I4 vs Ref
			//IL_01b5->IL00af: Incompatible stack types: I4 vs Ref
			//IL_0213->IL00af: Incompatible stack heights: 2 vs 1
			//IL_0230->IL00af: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			ref _003CReceiveControlDataAsync_003Ed__42 reference = ref *(_003CReceiveControlDataAsync_003Ed__42*)obj;
			while (true)
			{
				ref _003CReceiveControlDataAsync_003Ed__42 reference2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 1u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						reference = ref *(_003CReceiveControlDataAsync_003Ed__42*)null;
					}
					break;
				case 5u:
					_ = -2;
					_ = 3;
					break;
				default:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 != 0)
					{
						reference = ref *(_003CReceiveControlDataAsync_003Ed__42*)1;
					}
					break;
				case 3u:
					reference = ref this;
					if (4 != 0)
					{
						reference = ref *(_003CReceiveControlDataAsync_003Ed__42*)2;
					}
					break;
				case 2u:
					if (obj == null)
					{
						reference2 = ref *(_003CReceiveControlDataAsync_003Ed__42*)4;
						goto IL_00af;
					}
					goto IL_0138;
				case 4u:
					return;
					IL_0138:
					if (obj == null)
					{
						if (9 == 0)
						{
							reference2 = ref *(_003CReceiveControlDataAsync_003Ed__42*)7;
						}
						goto IL_00af;
					}
					goto IL_0120;
					IL_0120:
					_ = 0;
					_ = ((Array)Unsafe.AsPointer(ref this)).Length;
					_ = 0;
					_ = 3;
					goto IL_00af;
					IL_00af:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference2))
						{
						case 6u:
							break;
						case 3u:
						case 9u:
							obj = 0;
							_ = 7;
							continue;
						case 14u:
							goto IL_0120;
						case 17u:
							goto IL_0138;
						case 7u:
							obj = 2;
							_ = 5;
							continue;
						case 11u:
							return;
						case 15u:
							_ = ref obj;
							_ = 11;
							continue;
						case 2u:
						case 13u:
							_ = ref obj;
							_ = 6;
							continue;
						case 10u:
							if (&obj != null)
							{
								reference2 = ref *(_003CReceiveControlDataAsync_003Ed__42*)2;
								continue;
							}
							goto case 16u;
						case 5u:
							obj = obj;
							_ = 10;
							continue;
						case 4u:
						case 8u:
							obj = (object)Unsafe.AsPointer(ref this);
							if (0 == 0)
							{
								reference2 = ref *(_003CReceiveControlDataAsync_003Ed__42*)null;
							}
							continue;
						case 12u:
							obj = -1;
							if (12 == 0)
							{
								_ = 13;
							}
							continue;
						case 16u:
							obj = 0;
							if (1 == 0)
							{
								_ = 1;
							}
							continue;
						case 1u:
							_ = 15;
							continue;
						default:
							reference2 = ref this;
							if (12 == 0)
							{
								reference2 = ref *(_003CReceiveControlDataAsync_003Ed__42*)3;
							}
							continue;
						}
						break;
					}
					goto case 5u;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_ED00()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_EE00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779241, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CReceiveDataAsync_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopTransfer _003C_003E4__this;

		public byte[] buffer;

		private TaskAwaiter<int> _003C_003Eu__1;

		private nint _003Clength_003E5__2;

		private TaskAwaiter _003C_003Eu__2;

		private static object MoveCache;

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
		internal static bool ReflectSymbolicSummarizer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CustomizeInitializer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_E000(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779240, new IntPtr(2737367890124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_E100(object P_0)
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
		internal static object _FF00_FF00_FF00_FF00_FF00_E200()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_E300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779239, new IntPtr(2737367884924L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_E400()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0499: Expected Obj, but got Ref
			//IL_047e: Expected Obj, but got Ref
			//IL_01c9: Expected Obj, but got Ref
			//IL_0338: Expected Obj, but got I4
			//IL_0103: Expected Obj, but got Ref
			//IL_016a: Expected Obj, but got Ref
			//IL_02d8: Expected Obj, but got Ref
			//IL_02dd: Expected Obj, but got I4
			//IL_02e6: Expected Obj, but got I4
			//IL_02a2: Invalid comparison between Obj and Ref
			//IL_0123: Expected Obj, but got I4
			//IL_031b: Expected Obj, but got I4
			//IL_03c9: Expected Obj, but got I4
			//IL_0219: Expected Obj, but got Ref
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_047a->IL0019: Incompatible stack heights: 3 vs 1
			//IL_04a5->IL0019: Incompatible stack heights: 0 vs 1
			//IL_048a->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0068->IL006c: Incompatible stack types: I4 vs Ref
			//IL_0056->IL0019: Incompatible stack types: I4 vs Ref
			//IL_04b0->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0495->IL0019: Incompatible stack types: I4 vs Ref
			//IL_01d3->IL006c: Incompatible stack types: I4 vs Ref
			//IL_026f->IL006c: Incompatible stack heights: 0 vs 1
			//IL_027a->IL006c: Incompatible stack types: I4 vs Ref
			//IL_0345->IL006c: Incompatible stack heights: 2 vs 1
			//IL_010d->IL006c: Incompatible stack types: I4 vs Ref
			//IL_0176->IL006c: Incompatible stack heights: 2 vs 1
			//IL_0215->IL006c: Incompatible stack heights: 2 vs 1
			//IL_028f->IL006c: Incompatible stack heights: 3 vs 1
			//IL_0307->IL006c: Incompatible stack heights: 3 vs 1
			//IL_02f9->IL006c: Incompatible stack heights: 3 vs 1
			//IL_01ba->IL006c: Incompatible stack heights: 5 vs 1
			//IL_0130->IL006c: Incompatible stack heights: 2 vs 1
			//IL_0328->IL006c: Incompatible stack heights: 2 vs 1
			//IL_03d6->IL006c: Incompatible stack heights: 2 vs 1
			//IL_035d->IL006c: Incompatible stack heights: 2 vs 1
			//IL_02ce->IL006c: Incompatible stack heights: 4 vs 1
			//IL_0191->IL006c: Incompatible stack heights: 4 vs 1
			//IL_0225->IL006c: Incompatible stack heights: 0 vs 1
			//IL_01e7->IL006c: Incompatible stack types: I4 vs Ref
			//IL_0350->IL006c: Incompatible stack heights: 2 vs 1
			//IL_0160->IL006c: Incompatible stack types: I4 vs Ref
			//IL_0181->IL006c: Incompatible stack heights: 2 vs 1
			//IL_029a->IL006c: Incompatible stack heights: 3 vs 1
			//IL_006c->IL006c: Incompatible stack heights: 4 vs 1
			//IL_039b->IL006c: Incompatible stack types: I4 vs Ref
			//IL_03c4->IL006c: Incompatible stack types: I4 vs Ref
			//IL_02b3->IL006c: Incompatible stack heights: 0 vs 1
			//IL_01c5->IL006c: Incompatible stack heights: 5 vs 1
			//IL_013b->IL006c: Incompatible stack heights: 2 vs 1
			//IL_0333->IL006c: Incompatible stack heights: 2 vs 1
			//IL_01a3->IL006c: Incompatible stack types: I4 vs Ref
			//IL_03e1->IL006c: Incompatible stack heights: 2 vs 1
			//IL_0372->IL006c: Incompatible stack heights: 4 vs 1
			//IL_011e->IL006c: Incompatible stack types: I4 vs Ref
			//IL_0230->IL006c: Incompatible stack types: I4 vs Ref
			//IL_02be->IL006c: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			ref _003CReceiveDataAsync_003Ed__41 reference = ref *(_003CReceiveDataAsync_003Ed__41*)obj;
			while (true)
			{
				ref _003CReceiveDataAsync_003Ed__41 reference2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					return;
				case 0u:
					return;
				case 3u:
					reference = ref this;
					if (false)
					{
						reference = ref *(_003CReceiveDataAsync_003Ed__41*)null;
					}
					break;
				case 1u:
					if (obj == null)
					{
						reference2 = ref *(_003CReceiveDataAsync_003Ed__41*)16;
						goto IL_006c;
					}
					goto IL_025b;
				case 2u:
					goto IL_046c;
				case 5u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (4 == 0)
					{
						reference = ref *(_003CReceiveDataAsync_003Ed__41*)4;
					}
					break;
				case 4u:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (1 == 0)
						{
							reference = ref *(_003CReceiveDataAsync_003Ed__41*)null;
						}
						break;
					}
					IL_01c5:
					obj = (object)Unsafe.AsPointer(ref this);
					reference2 = ref *(_003CReceiveDataAsync_003Ed__41*)10;
					goto IL_006c;
					IL_006c:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference2))
						{
						case 11u:
							return;
						case 33u:
							return;
						case 2u:
						case 4u:
							obj = (object)(&obj);
							reference2 = ref *(_003CReceiveDataAsync_003Ed__41*)30;
							continue;
						case 30u:
							if (obj != null)
							{
								reference2 = ref *(_003CReceiveDataAsync_003Ed__41*)25;
								continue;
							}
							goto case 31u;
						case 20u:
							obj = 1;
							if (12 == 0)
							{
								_ = 12;
							}
							continue;
						case 3u:
							if (&obj != null)
							{
								reference2 = ref *(_003CReceiveDataAsync_003Ed__41*)4;
								continue;
							}
							goto case 1u;
						case 5u:
							_ = 2;
							obj = (object)Unsafe.AsPointer(ref this);
							if (3 == 0)
							{
								_ = 6;
							}
							continue;
						case 27u:
							_ = ref obj;
							_ = 33;
							continue;
						case 22u:
							if (&obj != null)
							{
								reference2 = ref *(_003CReceiveDataAsync_003Ed__41*)14;
								continue;
							}
							goto case 20u;
						case 19u:
							_ = 0;
							_ = 2;
							_ = 0;
							if (7 != 0)
							{
								_ = 17;
							}
							continue;
						case 29u:
							break;
						default:
							if ((nint)obj < 2)
							{
								reference2 = ref *(_003CReceiveDataAsync_003Ed__41*)7;
								continue;
							}
							goto case 19u;
						case 6u:
							obj = obj;
							_ = 22;
							continue;
						case 16u:
						case 32u:
							obj = (object)Unsafe.AsPointer(ref this);
							if (13 == 0)
							{
								reference2 = ref *(_003CReceiveDataAsync_003Ed__41*)4;
							}
							continue;
						case 28u:
							goto IL_025b;
						case 8u:
							_ = 0;
							_ = (ref *(byte*)2) + (ref Unsafe.As<_003CReceiveDataAsync_003Ed__41, byte>(ref this));
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 17u:
							if (!Unsafe.IsAddressLessThan(ref *(byte*)obj, ref *(byte*)((ref *(byte*)2) + (ref Unsafe.As<_003CReceiveDataAsync_003Ed__41, byte>(ref this)))))
							{
								if (4 != 0)
								{
									reference2 = ref *(_003CReceiveDataAsync_003Ed__41*)5;
								}
								continue;
							}
							goto IL_046c;
						case 26u:
							_ = ref obj;
							_ = 11;
							continue;
						case 9u:
							_ = 0;
							obj = ((Array)Unsafe.AsPointer(ref this)).Length;
							obj = 3;
							continue;
						case 18u:
							_ = 27;
							continue;
						case 12u:
							_ = 26;
							continue;
						case 21u:
							obj = -1;
							if (2 != 0)
							{
								_ = 2;
							}
							continue;
						case 1u:
							obj = 0;
							if (18 != 0)
							{
								_ = 18;
							}
							continue;
						case 14u:
						case 24u:
							_ = ref obj;
							_ = 8;
							continue;
						case 31u:
							throw /*Error near IL_035f: Stack underflow*/;
						case 25u:
							_ = 15;
							continue;
						case 10u:
							reference2 = ref this;
							if (13 != 0)
							{
								reference2 = ref *(_003CReceiveDataAsync_003Ed__41*)23;
							}
							continue;
						case 13u:
							reference2 = ref this;
							if (21 != 0)
							{
								reference2 = ref *(_003CReceiveDataAsync_003Ed__41*)11;
							}
							continue;
						case 23u:
							obj = -1;
							if (18 == 0)
							{
								_ = 24;
							}
							continue;
						case 7u:
							goto IL_046c;
						}
						break;
					}
					goto IL_01c5;
					IL_025b:
					if ((nint)obj != 1)
					{
						if (9 == 0)
						{
							reference2 = ref *(_003CReceiveDataAsync_003Ed__41*)4;
						}
						goto IL_006c;
					}
					goto IL_01c5;
					IL_046c:
					_ = -2;
					_ = 3;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_E500()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_E600()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779238, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRemoteCallBackAsync_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopTransfer _003C_003E4__this;

		public TransferCallBack callBack;

		private TaskAwaiter _003C_003Eu__1;

		internal static object GuidePublisher;

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
		internal static bool CheckMonoAuditor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckOrderedDecider()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00픀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779237, new IntPtr(2737367892204L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00혀(object P_0)
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
		internal static object _FF00_FF00_FF00_FF00_FF00휀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779236, new IntPtr(2737367892204L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779235, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0040: Expected Obj, but got Ref
			//IL_0364: Expected Obj, but got Ref
			//IL_036d: Expected Obj, but got I4
			//IL_010a: Expected Obj, but got I4
			//IL_00ae: Expected Obj, but got Ref
			//IL_021a: Expected Obj, but got Ref
			//IL_01be: Expected Obj, but got I4
			//IL_0257: Expected Obj, but got I4
			//IL_01fb: Expected Obj, but got Ref
			//IL_0204: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_004a->IL0019: Incompatible stack types: I4 vs Ref
			//IL_005a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0360->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0077->IL007b: Incompatible stack heights: 1 vs 0
			//IL_0065->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00fb->IL007b: Incompatible stack heights: 1 vs 0
			//IL_00ba->IL007b: Incompatible stack heights: 1 vs 0
			//IL_0125->IL007b: Incompatible stack heights: 2 vs 0
			//IL_007b->IL007b: Incompatible stack heights: 2 vs 0
			//IL_00c5->IL007b: Incompatible stack heights: 1 vs 0
			//IL_0224->IL0155: Incompatible stack types: I4 vs Ref
			//IL_0151->IL0155: Incompatible stack types: I4 vs Ref
			//IL_0130->IL007b: Incompatible stack heights: 2 vs 0
			//IL_00e3->IL007b: Incompatible stack heights: 1 vs 0
			//IL_0216->IL0155: Incompatible stack heights: 2 vs 1
			//IL_01c9->IL0155: Incompatible stack heights: 3 vs 1
			//IL_01d9->IL0155: Incompatible stack heights: 4 vs 1
			//IL_019d->IL0155: Incompatible stack heights: 3 vs 1
			//IL_0264->IL0155: Incompatible stack heights: 2 vs 1
			//IL_0238->IL0155: Incompatible stack heights: 0 vs 1
			//IL_026f->IL0155: Incompatible stack heights: 2 vs 1
			//IL_0155->IL0155: Incompatible stack heights: 2 vs 1
			//IL_01f3->IL0155: Incompatible stack types: I4 vs Ref
			//IL_0243->IL0155: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			while (true)
			{
				ref _003CRemoteCallBackAsync_003Ed__43 reference = ref *(_003CRemoteCallBackAsync_003Ed__43*)obj;
				while (true)
				{
					switch ((uint)Unsafe.AsPointer(ref reference))
					{
					default:
						return;
					case 0u:
						return;
					case 3u:
						obj = (object)Unsafe.AsPointer(ref this);
						reference = ref *(_003CRemoteCallBackAsync_003Ed__43*)2;
						continue;
					case 5u:
						_ = -2;
						if (true)
						{
							_ = 1;
						}
						continue;
					case 2u:
						if (obj != null)
						{
							_ = 5;
							goto IL_007b;
						}
						goto IL_00e3;
					case 1u:
						reference = ref this;
						if (0 == 0)
						{
							reference = ref *(_003CRemoteCallBackAsync_003Ed__43*)null;
						}
						continue;
					case 4u:
						break;
						IL_007b:
						while (true)
						{
							ref _003CRemoteCallBackAsync_003Ed__43 reference2;
							switch ((int)/*Error near IL_00a0: Stack underflow*/)
							{
							case 2:
							case 4:
								break;
							case 5:
								obj = (object)Unsafe.AsPointer(ref this);
								if (3 != 0)
								{
									_ = 0;
								}
								continue;
							case 3:
								if (obj == null)
								{
									if (0 == 0)
									{
										_ = 0;
									}
									continue;
								}
								goto case 7;
							case 1:
								goto IL_00e3;
							default:
								obj = 2;
								continue;
							case 7:
								if (1 == 0)
								{
									_ = 1;
								}
								continue;
							case 6:
								{
									if (obj != null)
									{
										reference2 = ref *(_003CRemoteCallBackAsync_003Ed__43*)8;
										goto IL_0155;
									}
									goto IL_0216;
								}
								IL_0216:
								obj = (object)Unsafe.AsPointer(ref this);
								reference2 = ref *(_003CRemoteCallBackAsync_003Ed__43*)11;
								goto IL_0155;
								IL_0155:
								while (true)
								{
									switch ((uint)Unsafe.AsPointer(ref reference2))
									{
									case 10u:
										return;
									case 6u:
										break;
									case 5u:
										_ = 3;
										continue;
									case 2u:
										obj = 0;
										_ = 5;
										continue;
									case 3u:
										_ = ref obj;
										_ = 10;
										continue;
									case 11u:
										reference2 = ref this;
										if (7 != 0)
										{
											reference2 = ref *(_003CRemoteCallBackAsync_003Ed__43*)null;
										}
										continue;
									case 8u:
										obj = (object)Unsafe.AsPointer(ref this);
										obj = 4;
										continue;
									default:
										_ = ref obj;
										_ = 6;
										continue;
									case 9u:
										goto IL_0216;
									case 4u:
										if (&obj != null)
										{
											if (false)
											{
												reference2 = ref *(_003CRemoteCallBackAsync_003Ed__43*)null;
											}
											continue;
										}
										goto case 2u;
									case 7u:
										obj = -1;
										if (1 == 0)
										{
											_ = 0;
										}
										continue;
									}
									break;
								}
								break;
							}
							break;
						}
						goto case 5u;
						IL_00e3:
						if (6 == 0)
						{
							_ = 6;
						}
						goto IL_007b;
					}
					break;
				}
				obj = (object)Unsafe.AsPointer(ref this);
				obj = 3;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779234, new IntPtr(2737367913004L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FFFD()
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
	private struct _003CSendDataAsync_003Ed__49 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DesktopTransfer _003C_003E4__this;

		public byte[] data;

		private TaskAwaiter _003C_003Eu__1;

		internal static object DecorateVisualList;

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
		internal static bool DecorateScopeRecord()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckStaticContext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00쬀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779233, new IntPtr(2737367890124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00찀(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00촀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779232, new IntPtr(2737367913004L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00츀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779167, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00케()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00턀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0069: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_0170: Expected Obj, but got Ref
			//IL_0193: Expected Obj, but got I4
			//IL_01b6: Expected Obj, but got I4
			//IL_0161: Expected Obj, but got I4
			//IL_010e: Expected Obj, but got I4
			//IL_0204: Expected Obj, but got I4
			//IL_0211: Expected Obj, but got Ref
			//IL_0215: Expected Obj, but got I4
			//IL_00e8: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0073->IL0019: Incompatible stack types: I4 vs Ref
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0065->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0056->IL0019: Incompatible stack types: I4 vs Ref
			//IL_02f2->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0085->IL0089: Incompatible stack types: I4 vs Ref
			//IL_01f7->IL0089: Incompatible stack heights: 2 vs 1
			//IL_0240->IL0089: Incompatible stack heights: 0 vs 1
			//IL_024b->IL0089: Incompatible stack types: I4 vs Ref
			//IL_017c->IL0089: Incompatible stack heights: 0 vs 1
			//IL_01c9->IL0089: Incompatible stack heights: 3 vs 1
			//IL_01bb->IL0085: Incompatible stack heights: 3 vs 1
			//IL_016c->IL0089: Incompatible stack heights: 3 vs 1
			//IL_011b->IL0089: Incompatible stack heights: 2 vs 1
			//IL_0221->IL0089: Incompatible stack types: Obj vs Ref
			//IL_0187->IL0089: Incompatible stack types: I4 vs Ref
			//IL_0089->IL0089: Incompatible stack heights: 2 vs 1
			//IL_00ed->IL0085: Incompatible stack heights: 0 vs 1
			//IL_0140->IL0089: Incompatible stack types: I4 vs Ref
			//IL_0126->IL0089: Incompatible stack heights: 2 vs 1
			//IL_022c->IL0089: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			ref _003CSendDataAsync_003Ed__49 reference = ref *(_003CSendDataAsync_003Ed__49*)obj;
			while (true)
			{
				ref object reference2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					return;
				case 2u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (true)
					{
						reference = ref *(_003CSendDataAsync_003Ed__49*)1;
					}
					break;
				case 0u:
					return;
				case 4u:
					_ = -2;
					_ = 3;
					break;
				case 1u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CSendDataAsync_003Ed__49*)5;
					break;
				case 5u:
					if (obj == null)
					{
						reference2 = ref *(object*)6;
						goto IL_0089;
					}
					goto IL_022c;
				case 3u:
					{
						reference = ref this;
						if (0 == 0)
						{
							reference = ref *(_003CSendDataAsync_003Ed__49*)null;
						}
						break;
					}
					IL_0089:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference2))
						{
						case 14u:
							return;
						case 7u:
						case 15u:
							break;
						case 11u:
							if (&obj != null)
							{
								obj = 8;
								continue;
							}
							goto case 9u;
						case 13u:
							obj = -1;
							if (12 == 0)
							{
								_ = 10;
							}
							continue;
						case 8u:
						case 12u:
							reference2 = ref obj;
							if (15 != 0)
							{
								reference2 = ref *(object*)14;
							}
							continue;
						case 9u:
							obj = 0;
							_ = 2;
							continue;
						default:
							obj = (object)Unsafe.AsPointer(ref this);
							if (0 == 0)
							{
								reference2 = ref *(object*)1;
							}
							continue;
						case 1u:
							obj = 13;
							continue;
						case 4u:
							_ = ref obj;
							obj = 14;
							continue;
						case 2u:
							_ = 4;
							continue;
						case 3u:
							goto IL_01e5;
						case 5u:
						case 16u:
						{
							object obj2 = obj;
							((object[])3)[0] = 513;
							((object[])3)[1] = obj;
							((object[])3)[2] = (object)Unsafe.AsPointer(ref this);
							obj = 3;
							reference2 = ref *(object*)obj2;
							if (11 != 0)
							{
								reference2 = ref *(object*)7;
							}
							continue;
						}
						case 10u:
							goto IL_022c;
						}
						break;
					}
					goto case 4u;
					IL_022c:
					if (obj == null)
					{
						if (1 == 0)
						{
							reference2 = ref *(object*)5;
						}
						goto IL_0089;
					}
					goto IL_01e5;
					IL_01e5:
					_ = 7;
					goto IL_0089;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00툀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779166, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00팀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00퐀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779165, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSendMessageAsync_003Ed__44 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public object[] values;

		public DesktopTransfer _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object CheckDynamicMapper;

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
		internal static bool PopWriter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectConnectedRequester()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00쐀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779164, new IntPtr(2737367913004L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00씀(object P_0)
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
		internal static object _FF00_FF00_FF00_FF00_FF00였()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00윀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779163, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00저()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_005a: Expected Obj, but got Ref
			//IL_003f: Expected Obj, but got Ref
			//IL_0152: Expected Obj, but got Ref
			//IL_01cf: Expected Obj, but got I4
			//IL_01df: Expected Obj, but got Ref
			//IL_0126: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0295->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0064->IL0019: Incompatible stack types: I4 vs Ref
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_02a0->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0285->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0056->IL0019: Incompatible stack types: I4 vs Ref
			//IL_015c->IL007a: Incompatible stack types: I4 vs Ref
			//IL_0076->IL007a: Incompatible stack types: I4 vs Ref
			//IL_0143->IL007a: Incompatible stack heights: 3 vs 1
			//IL_0191->IL007a: Incompatible stack heights: 6 vs 1
			//IL_00e2->IL007a: Incompatible stack types: Obj vs Ref
			//IL_01da->IL007a: Incompatible stack heights: 3 vs 1
			//IL_016c->IL007a: Incompatible stack heights: 2 vs 1
			//IL_01e9->IL007a: Incompatible stack types: I4 vs Ref
			//IL_0131->IL007a: Incompatible stack heights: 3 vs 1
			//IL_014e->IL007a: Incompatible stack heights: 3 vs 1
			//IL_019c->IL007a: Incompatible stack heights: 6 vs 1
			//IL_0107->IL007a: Incompatible stack types: I4 vs Ref
			//IL_0121->IL007a: Incompatible stack types: I4 vs Ref
			//IL_00ed->IL007a: Incompatible stack types: I4 vs Ref
			//IL_00ce->IL007a: Incompatible stack types: I4 vs Ref
			//IL_01bf->IL007a: Incompatible stack heights: 0 vs 1
			//IL_0177->IL007a: Incompatible stack heights: 2 vs 1
			//IL_01ca->IL007a: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			ref _003CSendMessageAsync_003Ed__44 reference = ref *(_003CSendMessageAsync_003Ed__44*)obj;
			while (true)
			{
				ref byte reference2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 3u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 != 0)
					{
						reference = ref *(_003CSendMessageAsync_003Ed__44*)null;
					}
					continue;
				case 2u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CSendMessageAsync_003Ed__44*)5;
					continue;
				case 5u:
					if (obj != null)
					{
						reference2 = ref *(byte*)12;
						goto IL_007a;
					}
					goto IL_014e;
				case 1u:
					reference = ref this;
					if (4 == 0)
					{
						reference = ref *(_003CSendMessageAsync_003Ed__44*)3;
					}
					continue;
				case 4u:
					return;
					IL_014e:
					obj = (object)Unsafe.AsPointer(ref this);
					reference2 = ref *(byte*)3;
					goto IL_007a;
					IL_007a:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference2))
						{
						case 7u:
							if (&obj == null)
							{
								reference2 = ref *(byte*)9;
								continue;
							}
							goto case 2u;
						case 5u:
						{
							object obj2 = obj;
							obj = obj;
							reference2 = ref *(byte*)obj2;
							if (6 != 0)
							{
								reference2 = ref *(byte*)7;
							}
							continue;
						}
						case 2u:
							reference2 = ref *(byte*)(&obj);
							if (6 != 0)
							{
								reference2 = ref *(byte*)null;
							}
							continue;
						case 3u:
							reference2 = ref Unsafe.As<_003CSendMessageAsync_003Ed__44, byte>(ref this);
							if (13 == 0)
							{
								reference2 = ref *(byte*)1;
							}
							continue;
						case 13u:
							obj = -1;
							_ = 2;
							continue;
						default:
							_ = ref obj;
							if (11 != 0)
							{
								_ = 0;
							}
							continue;
						case 4u:
							break;
						case 10u:
							if (false)
							{
								_ = 0;
							}
							continue;
						case 1u:
							_ = 0;
							_ = ((Array)obj).Length;
							_ = 0;
							if (2 == 0)
							{
								_ = 5;
							}
							continue;
						case 11u:
							return;
						case 8u:
							if (obj != null)
							{
								if (false)
								{
									reference2 = ref *(byte*)1;
								}
								continue;
							}
							goto case 5u;
						case 9u:
							obj = 0;
							_ = 10;
							continue;
						case 12u:
							obj = (object)Unsafe.AsPointer(ref this);
							reference2 = ref *(byte*)8;
							continue;
						case 6u:
							goto end_IL_0019;
						}
						break;
					}
					goto IL_014e;
					end_IL_0019:
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00준()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779162, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00쨀()
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
	private struct _003CSendMessageAsync_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public byte[] data;

		public DesktopTransfer _003C_003E4__this;

		private ValueTaskAwaiter _003C_003Eu__1;

		private static object ReflectAlphabeticModule;

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
		internal static bool VerifyDecorator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ProcessArgument()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00밀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779161, new IntPtr(2737367913004L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00봀(object P_0)
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
		internal static object _FF00_FF00_FF00_FF00_FF00븀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00뼀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779160, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00쀀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0083: Expected Obj, but got Ref
			//IL_0075: Expected Obj, but got Ref
			//IL_0162: Expected Obj, but got Ref
			//IL_00ab: Expected Obj, but got I4
			//IL_017e: Expected Obj, but got I4
			//IL_0150: Expected Obj, but got Ref
			//IL_0159: Expected Obj, but got I4
			//IL_01f1: Expected Obj, but got I4
			//IL_01b2: Expected Obj, but got Ref
			//IL_01bb: Expected Obj, but got Ref
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_004c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_008f->IL0019: Incompatible stack heights: 0 vs 1
			//IL_007f->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0071->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0057->IL0019: Incompatible stack heights: 2 vs 1
			//IL_009a->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0179->IL00b4: Incompatible stack heights: 1 vs 0
			//IL_00b4->IL00b4: Incompatible stack heights: 1 vs 0
			//IL_0189->IL00b4: Incompatible stack heights: 3 vs 0
			//IL_01fe->IL00b4: Incompatible stack heights: 2 vs 0
			//IL_013b->IL00b4: Incompatible stack heights: 2 vs 0
			//IL_012e->IL00b4: Incompatible stack heights: 3 vs 0
			//IL_01e1->IL00b4: Incompatible stack heights: 1 vs 0
			//IL_01c7->IL00b4: Incompatible stack heights: 1 vs 0
			//IL_01a4->IL00b4: Incompatible stack heights: 3 vs 0
			//IL_014b->IL00b4: Incompatible stack heights: 4 vs 0
			//IL_0209->IL00b4: Incompatible stack heights: 2 vs 0
			//IL_01ec->IL00b4: Incompatible stack heights: 1 vs 0
			//IL_01d2->IL00b4: Incompatible stack heights: 1 vs 0
			//IL_01af->IL00b4: Incompatible stack heights: 3 vs 0
			//IL_0120->IL00b4: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			ref _003CSendMessageAsync_003Ed__45 reference = ref *(_003CSendMessageAsync_003Ed__45*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 2u:
					return;
				case 3u:
					_ = -2;
					if (1 == 0)
					{
						_ = 1;
					}
					break;
				case 1u:
					reference = ref this;
					if (2 != 0)
					{
						reference = ref *(_003CSendMessageAsync_003Ed__45*)1;
					}
					break;
				case 5u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CSendMessageAsync_003Ed__45*)4;
					break;
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						reference = ref *(_003CSendMessageAsync_003Ed__45*)null;
					}
					break;
				default:
					{
						if (obj != null)
						{
							obj = 8;
							goto IL_00b4;
						}
						goto IL_015e;
					}
					IL_015e:
					obj = (object)Unsafe.AsPointer(ref this);
					if (3 == 0)
					{
						_ = 7;
					}
					goto IL_00b4;
					IL_00b4:
					while (true)
					{
						switch ((int)/*Error near IL_00ed: Stack underflow*/)
						{
						case 3:
							return;
						case 5:
							break;
						case 12:
							if (&obj == null)
							{
								if (2 != 0)
								{
									_ = 2;
								}
								continue;
							}
							goto case 4;
						case 6:
							_ = 10;
							continue;
						case 4:
							_ = ref obj;
							_ = 5;
							continue;
						case 10:
							_ = ref obj;
							_ = 3;
							continue;
						case 1:
							obj = (object)(&obj);
							obj = 12;
							continue;
						case 11:
							goto IL_015e;
						default:
							obj = -1;
							_ = 4;
							continue;
						case 9:
							_ = ref obj;
							obj = obj;
							if (true)
							{
								_ = 1;
							}
							continue;
						case 8:
							_ = (ushort)((Array)Unsafe.AsPointer(ref this)).Length;
							obj = (object)Unsafe.AsPointer(ref this);
							if (3 == 0)
							{
								_ = 9;
							}
							continue;
						case 7:
							if (0 == 0)
							{
								_ = 0;
							}
							continue;
						case 2:
							obj = 0;
							if (6 == 0)
							{
								_ = 0;
							}
							continue;
						}
						break;
					}
					goto case 3u;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00섀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779159, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00숀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00쌀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779158, new IntPtr(2737367885964L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	private static readonly object Logger;

	[CompilerGenerated]
	private Action<byte[]>? m_OnDataReceived;

	[CompilerGenerated]
	private object? m_OnDisconnect;

	public bool Connected;

	private readonly object _rtc;

	private readonly long _rtcSessionId;

	private readonly object _session;

	private readonly object _random;

	private readonly object _encryptKey;

	private readonly object _decryptChaCha;

	private readonly object _encryptChaCha;

	private readonly object _client;

	private readonly object _room;

	private nint _connected;

	private readonly List<byte> _buffer;

	private nint _handshake;

	private readonly Dictionary<ushort, Func<TransferCallBack, Task>> _callbacks;

	private nint _enableRtc;

	private object? _handshakeTcs;

	private object? _joinRoomTcs;

	private object? _channelReadyTcs;

	internal static DesktopTransfer ReflectConcreteDecider;

	public event Action<byte[]>? OnDataReceived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			_FF00_FF00_FF00_FF00鰀(value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			_FF00_FF00_FF00_FF00蔀(value);
		}
	}

	public event Action? OnDisconnect
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			_FF00_FF00_FF00_FF00栀(value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			_FF00_FF00_FF00_FF00瘀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DesktopTransfer(DesktopSession session, EntityLanGameRoom room)
	{
		//IL_009e: Expected I4, but got Obj
		//IL_029f: Expected Obj, but got I4
		//IL_0038->IL0041: Incompatible stack types: I4 vs Obj
		//IL_01ac->IL0041: Incompatible stack types: I4 vs Obj
		//IL_00ea->IL0041: Incompatible stack heights: 7 vs 4
		//IL_0221->IL0041: Incompatible stack heights: 3 vs 4
		//IL_00d6->IL0041: Incompatible stack heights: 6 vs 4
		//IL_00b4->IL0041: Incompatible stack heights: 7 vs 4
		//IL_01f3->IL0041: Incompatible stack heights: 9 vs 4
		//IL_0175->IL0041: Incompatible stack heights: 6 vs 4
		//IL_01d2->IL0041: Incompatible stack heights: 6 vs 4
		//IL_0100->IL0041: Incompatible stack heights: 6 vs 4
		//IL_01bc->IL0041: Incompatible stack heights: 6 vs 4
		//IL_0205->IL0041: Incompatible stack heights: 5 vs 4
		//IL_015d->IL0041: Incompatible stack heights: 3 vs 4
		//IL_0132->IL0041: Incompatible stack heights: 6 vs 4
		//IL_0142->IL0041: Incompatible stack heights: 5 vs 4
		//IL_019e->IL0041: Incompatible stack heights: 6 vs 4
		//IL_0185->IL0041: Incompatible stack heights: 3 vs 4
		//IL_0290->IL0041: Incompatible stack heights: 6 vs 4
		//IL_0275->IL0041: Incompatible stack heights: 24 vs 4
		//IL_00c8->IL0041: Incompatible stack heights: 7 vs 4
		//IL_0041->IL0041: Incompatible stack heights: 6 vs 4
		//IL_022c->IL0041: Incompatible stack heights: 3 vs 4
		//IL_0125->IL0041: Incompatible stack types: I4 vs Obj
		//IL_01dd->IL0041: Incompatible stack heights: 6 vs 4
		//IL_010b->IL0041: Incompatible stack heights: 6 vs 4
		//IL_0210->IL0041: Incompatible stack heights: 5 vs 4
		//IL_0168->IL0041: Incompatible stack heights: 3 vs 4
		//IL_014d->IL0041: Incompatible stack heights: 5 vs 4
		//IL_0190->IL0041: Incompatible stack heights: 3 vs 4
		//IL_0280->IL0041: Incompatible stack heights: 24 vs 4
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		DesktopTransfer desktopTransfer = this;
		if (9 == 0)
		{
			desktopTransfer = (DesktopTransfer)4;
		}
		object obj = default;
		while (true)
		{
			switch ((int)desktopTransfer)
			{
			case 7:
				_ = 4;
				break;
			case 21:
				_ = 514;
				_ = 10;
				break;
			case 5:
				_ = 7;
				break;
			case 1:
				_ = 257;
				_ = 11;
				break;
			case 11:
				_ = 513;
				if (21 == 0)
				{
					_ = 21;
				}
				break;
			case 4:
				desktopTransfer = this;
				if (6 != 0)
				{
					desktopTransfer = (DesktopTransfer)20;
				}
				break;
			case 15:
				_ = 8;
				break;
			case 16:
				if (5 == 0)
				{
					_ = 5;
				}
				break;
			case 14:
				obj = obj;
				if (7 == 0)
				{
					_ = 18;
				}
				break;
			case 9:
				_ = 15;
				break;
			case 18:
				obj = obj;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 17:
				_ = 16;
				break;
			default:
				obj = obj;
				desktopTransfer = (DesktopTransfer)3;
				break;
			case 12:
				_ = 2;
				break;
			case 10:
				_ = 516;
				if (6 != 0)
				{
					_ = 0;
				}
				break;
			case 8:
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = 14;
				break;
			case 13:
				if (1 == 0)
				{
					_ = 0;
				}
				break;
			case 6:
				return;
			case 3:
				obj = obj;
				if (17 == 0)
				{
					_ = 11;
				}
				break;
			case 20:
				_ = ref obj;
				_ = 14;
				_ = 5;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				_ = ref obj;
				if (3 == 0)
				{
					_ = 19;
				}
				break;
			case 19:
				_ = 12;
				break;
			case 2:
				obj = 13;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		_FF00_FF00_FF00_FF00焀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DataChannelOpen(object peerId)
	{
		_FF00_FF00_FF00_FF00蘀(peerId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DataChannelError(object e)
	{
		_FF00_FF00_FF00_FF00阀(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DataChannelClose(object peerId)
	{
		_FF00_FF00_FF00_FF00茀(peerId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BinaryMessage(object peerId, object data)
	{
		_FF00_FF00_FF00_FF00贀(peerId, data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object HandleGameDataResponseAsync(object callback)
	{
		return _FF00_FF00_FF00_FF00뜀(callback);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object HandleLoginResponseAsync(object callback)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 632, 1790779291, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779291, new IntPtr(2737367906764L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, callback);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object HandlePlayerLeaveResponseAsync(object callback)
	{
		return _FF00_FF00_FF00_FF00넀(callback);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CHandleJoinRoomResponseAsync_003Ed__34))]
	private object HandleJoinRoomResponseAsync(object callback)
	{
		return _FF00_FF00_FF00_FF00蠀(callback);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CConnectWebRtc_003Ed__35))]
	private object ConnectWebRtc()
	{
		return _FF00_FF00_FF00_FF00洀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RegisterCallBack(ushort sid, Func<TransferCallBack, Task> callback)
	{
		_FF00_FF00_FF00_FF00輀(sid, callback);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CConnectAsync_003Ed__37))]
	public Task ConnectAsync()
	{
		return (Task)_FF00_FF00_FF00_FF00舀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CHeartbeatCircleAsync_003Ed__38))]
	private object HeartbeatCircleAsync()
	{
		return _FF00_FF00_FF00_FF00ꠀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CReceiveAsync_003Ed__39))]
	private object ReceiveAsync()
	{
		return _FF00_FF00_FF00_FF00ꐀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Disconnect()
	{
		_FF00_FF00_FF00_FF00欀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CReceiveDataAsync_003Ed__41))]
	private object ReceiveDataAsync(object buffer)
	{
		return _FF00_FF00_FF00_FF00됀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CReceiveControlDataAsync_003Ed__42))]
	private object ReceiveControlDataAsync(object data)
	{
		return _FF00_FF00_FF00_FF00脀(data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoteCallBackAsync_003Ed__43))]
	private object RemoteCallBackAsync(object callBack)
	{
		return _FF00_FF00_FF00_FF00뤀(callBack);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSendMessageAsync_003Ed__44))]
	private object SendMessageAsync(object values)
	{
		return _FF00_FF00_FF00_FF00騀(values);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSendMessageAsync_003Ed__45))]
	private object SendMessageAsync(object data)
	{
		return _FF00_FF00_FF00_FF00渀(data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CHandshakeAsync_003Ed__46))]
	private object HandshakeAsync()
	{
		return _FF00_FF00_FF00_FF00紀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CJoinRoomAsync_003Ed__47))]
	private object JoinRoomAsync()
	{
		return _FF00_FF00_FF00_FF00ꈀ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CHeartbeatAsync_003Ed__48))]
	private object HeartbeatAsync()
	{
		return _FF00_FF00_FF00_FF00笀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSendDataAsync_003Ed__49))]
	public Task SendDataAsync(byte[] data)
	{
		return (Task)_FF00_FF00_FF00_FF00頀(data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static long RandomSessionId()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	static DesktopTransfer()
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
				Logger = Log.Logger.Category((string)ZYXDNGuarder._FF00_FF00_FF00_FF00ꘀ());
				obj2 = 0;
				if (_003CModule_003E_007B8336717d_002D71de_002D47ce_002Dbc69_002D4d75223ebc5e_007D.m_d836f3f9b6194f49a23d85cb66f28ddf.m_7e8937f9535a4f00b0a89710f63c9a3d == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectConnectedList()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DesktopTransfer DecorateAlphabeticRecord()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00最(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779290, new IntPtr(2737367893244L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00栀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0089: Expected Obj, but got I4
		//IL_00ad->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_009c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008e->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0076->IL0019: Incompatible stack types: I4 vs Obj
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
				case 2:
					obj = obj;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 4:
					if (obj == obj)
					{
						if (1 == 0)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 2;
				case 1:
					return;
				case 5:
					break;
				case 3:
					obj = this;
					obj2 = 2;
					continue;
				default:
					obj = P_0;
					_ = 5;
					continue;
				}
				break;
			}
			obj = obj;
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00椀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779289, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00樀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779288, new IntPtr(2737367893244L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00欀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0040->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0050->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0075->IL0019: Incompatible stack types: I4 vs Obj
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
				_ = 0;
				_ = 3;
				break;
			case 2:
				return;
			case 1:
				_ = 0;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 3:
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
	private unsafe object _FF00_FF00_FF00_FF00氀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779287, new IntPtr(2737367907804L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00洀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4924, 1790779286, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779286, new IntPtr(2737367895324L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00渀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4925, 1790779285, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779285, new IntPtr(2737367898444L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00焀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0103: Expected I4, but got Obj
		//IL_005e: Expected I4, but got Obj
		//IL_00db->IL0019: Incompatible stack heights: 2 vs 1
		//IL_017f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00f6->IL00fa: Incompatible stack types: I4 vs Obj
		//IL_0051->IL0055: Incompatible stack types: I4 vs Obj
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
				DesktopTransfer desktopTransfer2 = this;
				if (false)
				{
					desktopTransfer2 = (DesktopTransfer)0;
				}
				switch ((int)desktopTransfer2)
				{
				}
				goto default;
			}
			default:
				_ = 3;
				continue;
			case 2:
			{
				DesktopTransfer desktopTransfer = this;
				if (0 == 0)
				{
					desktopTransfer = (DesktopTransfer)0;
				}
				switch ((int)desktopTransfer)
				{
				}
				break;
			}
			case 1:
				break;
			case 3:
				return;
			}
			obj2 = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00爀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779284, new IntPtr(2737367903644L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00猀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779283, new IntPtr(2737367914044L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00琀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00甀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779282, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00瘀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0056: Expected Obj, but got I4
		//IL_006c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a2->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0082->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00ad->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008d->IL0019: Incompatible stack types: I4 vs Obj
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
				default:
					return;
				case 4:
					obj = obj;
					obj2 = 2;
					continue;
				case 5:
					break;
				case 2:
					obj = P_0;
					_ = 3;
					continue;
				case 0:
					return;
				case 1:
					if (obj == obj)
					{
						if (false)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 4;
				case 3:
					obj = obj;
					if (0 == 0)
					{
						_ = 1;
					}
					continue;
				}
				break;
			}
			obj = this;
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00稀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779281, new IntPtr(2737367885964L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00笀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4938, 1790779280, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779280, new IntPtr(2737367909884L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00簀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779279, new IntPtr(2737367913004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00紀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4940, 1790779278, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779278, new IntPtr(2737367889084L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00縀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779277, new IntPtr(2737367910924L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00缀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00耀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779276, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00脀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4944, 1790779275, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779275, new IntPtr(2737367907804L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00舀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4945, 1790779274, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779274, new IntPtr(2737367914044L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00茀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0043->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0061->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007a->IL0019: Incompatible stack types: I4 vs Obj
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
				continue;
			case 3:
				return;
			}
			obj2 = this;
			if (obj2 == null)
			{
				obj2 = 3;
			}
			else if (2 == 0)
			{
				obj2 = 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00萀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779273, new IntPtr(2737367883884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00蔀(Action<byte[]> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0095->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0079->IL0019: Incompatible stack heights: 0 vs 1
		//IL_005e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0084->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0069->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ab->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00b6->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				obj = obj;
				_ = 5;
				break;
			case 4:
				obj = this;
				if (3 == 0)
				{
					obj2 = 1;
				}
				break;
			case 3:
				obj = obj;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				obj = P_0;
				_ = 2;
				break;
			case 1:
				return;
			case 5:
				if (obj == obj)
				{
					if (false)
					{
						obj2 = 1;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00蘀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0063->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0048->IL0019: Incompatible stack heights: 0 vs 1
		//IL_006e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0087->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0053->IL0019: Incompatible stack types: I4 vs Obj
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
				obj2 = this;
				if (obj2 == null)
				{
					if (1 == 0)
					{
						obj2 = 0;
					}
				}
				else if (false)
				{
					obj2 = 0;
				}
				break;
			case 0:
				return;
			case 3:
				_ = 1;
				if (2 == 0)
				{
					_ = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00蜀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779272, new IntPtr(2737367905724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00蠀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4951, 1790779271, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779271, new IntPtr(2737367896364L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00褀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779270, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00謀()
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
	private unsafe void _FF00_FF00_FF00_FF00谀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779269, new IntPtr(2737367883884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00贀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_005f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0044->IL0019: Incompatible stack heights: 0 vs 1
		//IL_006a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_004f->IL0019: Incompatible stack types: I4 vs Obj
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
				if (this == null)
				{
					if (1 == 0)
					{
						obj2 = 0;
					}
				}
				else if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			case 1:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00輀(ushort P_0, Func<TransferCallBack, Task> P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0042->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_004d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006a->IL0019: Incompatible stack heights: 3 vs 1
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
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			case 2:
				if (1 == 0)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00鄀()
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
	private unsafe void _FF00_FF00_FF00_FF00鈀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779268, new IntPtr(2737367900524L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00鐀()
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
	private unsafe void _FF00_FF00_FF00_FF00销(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779267, new IntPtr(2737367905724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_FF00_FF00阀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0043->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0063->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0088->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006e->IL0019: Incompatible stack types: I4 vs Obj
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
			case 1:
				return;
			case 3:
				_ = 0;
				if (1 == 0)
				{
					_ = 2;
				}
				break;
			case 2:
				if (this == null)
				{
					if (false)
					{
						obj2 = 0;
					}
				}
				else if (1 == 0)
				{
					_ = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00需(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779266, new IntPtr(2737367908844L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00頀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4967, 1790779265, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779265, new IntPtr(2737367915084L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00餀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779264, new IntPtr(2737367900524L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00騀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4969, 1790779327, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779327, new IntPtr(2737367894284L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00鬀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779326, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00鰀(Action<byte[]> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0050->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00a6->IL0019: Incompatible stack heights: 0 vs 1
		//IL_005b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0076->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00d0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0096->IL0019: Incompatible stack types: I4 vs Obj
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
				obj = obj;
				if (2 == 0)
				{
					_ = 3;
				}
				break;
			case 1:
				obj = obj;
				if (false)
				{
					obj2 = 4;
				}
				break;
			case 3:
				if (obj == obj)
				{
					if (true)
					{
						obj2 = 5;
					}
					break;
				}
				goto case 1;
			case 2:
				obj = this;
				if (false)
				{
					obj2 = 1;
				}
				break;
			case 5:
				return;
			case 4:
				obj2 = obj;
				obj = P_0;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00鴀(Action<byte[]> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779325, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static long _FF00_FF00_FF00_FF00鸀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779324, new IntPtr(2737367900524L), 15))(null, 0, new IntPtr(0L));
		return (long)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static long _FF00_FF00_FF00_FF00鼀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (8 & 0x7FFFFFFFFFFFFFFFL) % 9223372036854775806L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static long _FF00_FF00_FF00_FF00ꀀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779323, new IntPtr(2737367913004L), 15))(null, 0, new IntPtr(0L));
		return (long)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00ꄀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779322, new IntPtr(2737367910924L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00ꈀ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4977, 1790779321, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779321, new IntPtr(2737367888044L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00ꌀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779320, new IntPtr(2737367885964L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00ꐀ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4979, 1790779319, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779319, new IntPtr(2737367905724L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00ꔀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779318, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_A700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779317, new IntPtr(2737367908844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00ꠀ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4983, 1790779316, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790779316, new IntPtr(2737367900524L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00꤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779315, new IntPtr(2737367902604L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FF00_FF00꼀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_008e: Expected I4, but got Obj
		//IL_011d: Expected Obj, but got I4
		//IL_00bd->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01d3->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0263->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a3->IL0019: Incompatible stack heights: 0 vs 1
		//IL_020f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_027f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0173->IL0019: Incompatible stack types: I4 vs Obj
		//IL_028c->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01de->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0134->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0100->IL0019: Incompatible stack heights: 0 vs 1
		//IL_023a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ae->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0166->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00cf->IL0019: Incompatible stack heights: 3 vs 1
		//IL_02a4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01f0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e2->IL0019: Incompatible stack heights: 0 vs 1
		//IL_018d->IL0019: Incompatible stack heights: 0 vs 1
		//IL_010b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02d3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_02b4->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ed->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0198->IL0019: Incompatible stack types: I4 vs Obj
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
				case 12:
					obj = this;
					if (5 != 0)
					{
						obj2 = 5;
					}
					break;
				default:
					obj = obj;
					obj2 = 22;
					break;
				case 14:
					throw /*Error near IL_00bf: Stack underflow*/;
				case 18:
				case 25:
					_ = 7;
					break;
				case 22:
					if (obj == null)
					{
						if (11 == 0)
						{
							obj2 = 2;
						}
						break;
					}
					goto case 2;
				case 5:
					if (obj == null)
					{
						if (false)
						{
							obj2 = 4;
						}
						break;
					}
					goto case 21;
				case 10:
				case 24:
					obj2 = this;
					if (obj2 != null)
					{
						if (13 == 0)
						{
							obj2 = 11;
						}
						break;
					}
					goto end_IL_0019;
				case 2:
					if ((nint)obj != 4)
					{
						obj2 = 27;
						break;
					}
					goto case 12;
				case 17:
					if ((nint)obj == 255)
					{
						obj2 = 8;
						break;
					}
					goto case 14;
				case 16:
				case 20:
					obj2 = 6;
					break;
				case 3:
				case 6:
				case 9:
					return (object)/*Error near IL_0175: Stack underflow*/;
				case 27:
					if ((nint)obj != 255)
					{
						if (17 != 0)
						{
							obj2 = 24;
						}
						break;
					}
					goto case 12;
				case 1:
					obj = P_0;
					if (false)
					{
						obj2 = 0;
					}
					break;
				case 21:
					if ((nint)obj != 4)
					{
						obj2 = 17;
						break;
					}
					goto case 15;
				case 13:
				case 23:
					_ = 3;
					break;
				case 4:
				case 7:
					obj2 = obj;
					if (8 == 0)
					{
						obj2 = 9;
					}
					break;
				case 8:
					obj = (object)/*Error near IL_0259: Stack underflow*/;
					obj2 = 18;
					break;
				case 15:
					obj = (object)/*Error near IL_0275: Stack underflow*/;
					obj2 = 25;
					break;
				case 11:
				case 26:
					_ = 1;
					_ = 19;
					break;
				case 19:
					if (this == null)
					{
						obj2 = 16;
					}
					else
					{
						_ = 20;
					}
					break;
				}
				continue;
				end_IL_0019:
				break;
			}
			obj = 23;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00넀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4992, 1790779314, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779314, new IntPtr(2737367908844L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00눀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779313, new IntPtr(2737367910924L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00대(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779312, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00됀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4995, 1790779311, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779311, new IntPtr(2737367910924L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00딀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779310, new IntPtr(2737367913004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00똀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779309, new IntPtr(2737367893244L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00뜀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4998, 1790779308, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779308, new IntPtr(2737367902604L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00렀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779307, new IntPtr(2737367890124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00뤀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 5000, 1790779306, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790779306, new IntPtr(2737367903644L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00먀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779305, new IntPtr(2737367911964L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
