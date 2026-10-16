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
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Mass.Application.Desktop;
using Mass.Application.Extensions;
using Mass.Common.Extensions;
using Mass.Common.Helpers;
using Mass.Domain.Desktop.Entities.LanGame;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Game.Launcher.Entities.Fever;
using Mass.Game.Launcher.Models;
using Mass.Game.Launcher.Values;
using RestSharp;
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
		public unsafe TransferCallBack(DesktopTransfer Transfer, ushort Sid, byte[] Data)
		{
			//IL_001b: Expected I4, but got Obj
			//IL_0016: Expected native int or pointer, but got Obj
			//IL_0027: Expected VT, but got I4
			//IL_0022: Expected native int or pointer, but got Obj
			//IL_002e: Expected native int or pointer, but got Obj
			//IL_0048: Expected native int or pointer, but got Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = (int)Transfer;
			Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Et__builder, (AsyncTaskMethodBuilder)Sid);
			Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E4__this, Data);
			((TcpListener)this).Start();
			int num = 0;
			if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state != 0)
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
		protected unsafe TransferCallBack(TransferCallBack original)
		{
			//IL_001a: Expected VT, but got Obj
			//IL_008a: Expected native int or pointer, but got Obj
			//IL_008f: Expected native int or pointer, but got Obj
			//IL_005e: Expected native int or pointer, but got Obj
			//IL_0068: Expected Obj, but got VT
			//IL_0063: Expected native int or pointer, but got Obj
			//IL_00a0: Expected native int or pointer, but got Obj
			//IL_00aa: Expected Obj, but got VT
			//IL_00a5: Expected native int or pointer, but got Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			((ILogger)/*Error near IL_001a: Stack underflow*/).Debug<_0021_00210>((string)/*Error near IL_001a: Stack underflow*/, (_0021_00210)this);
			int num = 0;
			if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
			{
				num = 2;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 2:
					Unsafe.Write(&Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton, (object)((Authenticator._003CListenAsync_003Ed__7*)(nint)original)->_003C_003Eu__1);
					num = 0;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder != 0)
					{
						num = 1;
					}
					break;
				case 0:
					return;
				case 1:
					Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003E4__this, ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)original)->listener);
					num = 3;
					break;
				case 3:
					Unsafe.Write(&Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler, (object)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)original)->_003C_003Eu__1);
					num = 0;
					if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder != 0)
					{
						num = 0;
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
		internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00䈀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected I4, but got Obj
			//IL_003a: Expected native int or pointer, but got Obj
			//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
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
					((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = (int)P_0;
					obj2 = 0;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00䌀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779303, new IntPtr(2737367911964L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00䐀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00䔀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779302, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00䘀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return new Authenticator();
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
		internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00䤀()
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected Obj, but got Unknown
			//IL_0030: Expected native int or pointer, but got Obj
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected native int or pointer, but got Obj
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected Obj, but got Unknown
			//IL_005e: Expected native int or pointer, but got Obj
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected I4, but got Unknown
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			((ILogger)/*Error near IL_0019: Stack underflow*/).Debug<_0021_00210>((string)/*Error near IL_0019: Stack underflow*/, (_0021_00210)/*Error near IL_0019: Stack underflow*/);
			((Authenticator)/*Error near IL_001f: Stack underflow*/).Listener = (TcpListener?)(object)this;
			((TcpListener)(Task.Run((Func<Task?>)/*Error near IL_0024: Stack underflow*/) * -1521134295)).Start();
			_003F val = (/*Error near IL_003b: Stack underflow*/ + ((AsyncTaskMethodBuilder*)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->Task) * -1521134295;
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->listener.Dispose();
			((IAsyncStateMachine)((val + asyncTaskMethodBuilder) * -1521134295)).MoveNext();
			return (uint)(/*Error near IL_0069: Stack underflow*/ + ((Task)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler).GetAwaiter());
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
			//IL_001d: Expected Obj, but got I4
			//IL_003b: Expected I4, but got Obj
			//IL_0048: Expected I4, but got Obj
			//IL_0079: Expected native int or pointer, but got Obj
			//IL_0095: Expected Obj, but got I
			//IL_00a0: Expected native int or pointer, but got Obj
			//IL_005c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0083->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00aa->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0067->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00b5->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					*(short*)P_1 = (short)(int)((Authenticator)this).Listener;
					obj2 = 3;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 2;
					}
					break;
				case 2:
					Unsafe.Write((void*)P_0, ((Authenticator)this).ListenAsync());
					obj2 = 0;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state == 0)
					{
						obj2 = 1;
					}
					break;
				case 3:
					Unsafe.Write((void*)(nint)/*Error near IL_0096: Stack underflow*/, ((Authenticator)P_2).ReceiveAuthenticationDataAsync((object)this));
					obj2 = 0;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
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
		internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00䴀()
		{
			//IL_0015: Expected native int or pointer, but got Obj
			//IL_001b: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00一()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779297, new IntPtr(2737367916124L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00伀(object P_0, object P_1)
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (((Authenticator)P_1).Listener == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00倀(object P_0, object P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779296, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00儀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_004f: Expected I4, but got Obj
			//IL_00f1: Expected native int or pointer, but got Obj
			//IL_00f7: Expected native int or pointer, but got Obj
			//IL_0101: Expected Ref, but got VT
			//IL_0069: Expected native int or pointer, but got Obj
			//IL_006f: Expected native int or pointer, but got Obj
			//IL_007a: Expected I4, but got VT
			//IL_012b: Expected native int or pointer, but got Obj
			//IL_0131: Expected native int or pointer, but got Obj
			//IL_013b: Expected Ref, but got VT
			//IL_0110: Expected native int or pointer, but got Obj
			//IL_008e: Expected native int or pointer, but got Obj
			//IL_0106->IL0063: Incompatible stack heights: 1 vs 0
			//IL_0171->IL0125: Incompatible stack heights: 1 vs 0
			//IL_0140->IL00eb: Incompatible stack heights: 1 vs 0
			//IL_011a->IL0026: Incompatible stack heights: 2 vs 1
			//IL_017b->IL0026: Incompatible stack heights: 2 vs 1
			//IL_014a->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0098->IL0026: Incompatible stack types: I4 vs Obj
			//IL_015b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0125->IL0026: Incompatible stack heights: 2 vs 1
			//IL_00a3->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((ILogger)/*Error near IL_0068: Stack underflow*/).Debug<_0021_00210>((string)/*Error near IL_0068: Stack underflow*/, (_0021_00210)/*Error near IL_0068: Stack underflow*/);
					AsyncTaskMethodBuilder asyncTaskMethodBuilder = ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Et__builder;
					((TcpListener)(object)((Authenticator._003CListenAsync_003Ed__7*)(nint)P_0)->_003C_003E4__this).Start();
					return (byte)(int)asyncTaskMethodBuilder;
				}
				case 6:
				case 7:
				case 8:
					return 0;
				case 4:
					if (P_0 != null)
					{
						obj2 = 0;
						if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state == 0)
						{
							obj2 = 1;
						}
						break;
					}
					goto case 6;
				default:
				{
					_ = ((TaskAwaiter*)/*Error near IL_00f0: Stack underflow*/)->IsCompleted;
					int num = ((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003E1__state;
					((TaskAwaiter*)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)P_0)->_003C_003Et__builder)->GetResult();
					if (num == 0)
					{
						_ = 6;
						if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9.client)->_003C_003Eu__1 != 0)
						{
							_ = 2;
						}
						break;
					}
					goto case 2;
				}
				case 3:
					((AsyncTaskMethodBuilder*)/*Error near IL_012a: Stack underflow*/)->SetResult();
					_ = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->_003C_003E1__state;
					if (!((TaskAwaiter<TcpClient>*)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)P_0)->_003C_003Et__builder)->IsCompleted)
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
					((Authenticator._003CReceiveAsync_003Ed__9*)/*Error near IL_0161: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)this);
					if ((Authenticator._003CReceiveAsync_003Ed__9.ReflectAdvancedEnumerator() ? ((TaskAwaiter<TcpClient>*)1) : ((TaskAwaiter<TcpClient>*)null))->GetResult() == null)
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
		internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00匀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0040: Expected I4, but got Obj
			//IL_003b: Expected native int or pointer, but got Obj
			//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
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
				case 0:
					return;
				case 1:
					((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = (int)P_0;
					obj2 = 0;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 0;
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
		internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00唀(object P_0)
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			((Authenticator)(object)this).Listener = (TcpListener?)((P_0 is Authenticator._003CListenAuthenticationConnectAsync_003Ed__8) ? P_0 : null);
			return (byte)/*Error near IL_0021: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00嘀(object P_0, object P_1)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0037: Expected I4, but got Obj
			//IL_0044: Expected I4, but got Obj
			//IL_0062->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0088->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0093->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					return (byte)(int)((Authenticator)P_1).Listener;
				case 1:
					if (P_0 == null)
					{
						return 0;
					}
					obj2 = 0;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 0;
					}
					break;
				case 2:
					if (P_0 == P_1)
					{
						return 1;
					}
					obj2 = 0;
					if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton == null)
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
		internal unsafe ushort _FF00_FF00_FF00_FF00_FF00_FF00夀()
		{
			//IL_0015: Expected native int or pointer, but got Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (ushort)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe ushort _FF00_FF00_FF00_FF00_FF00_FF00娀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779227, new IntPtr(2737367911964L), 15))(null, 0, new IntPtr(0L));
			return (ushort)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00嬀()
		{
			//IL_0015: Expected native int or pointer, but got Obj
			//IL_001b: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00帀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00搀(ushort P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003a: Expected native int or pointer, but got Obj
			//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
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
					((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = P_0;
					obj2 = 0;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
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
		protected unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00樀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_004b: Expected I4, but got Obj
			//IL_0116: Expected Obj, but got I4
			//IL_00e9: Expected Obj, but got I4
			//IL_0066: Expected Obj, but got Ref
			//IL_0076: Expected native int or pointer, but got Obj
			//IL_010a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0121->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00f4->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00b2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0080->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00d3->IL0026: Incompatible stack heights: 3 vs 1
			//IL_00a3->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00de->IL0026: Incompatible stack heights: 3 vs 1
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 5:
					obj = ((Authenticator)this).Listener;
					((TcpListener)(object)((Task)(object)MulticastDelegate/*cast due to constrained. prefix*/).Run((Func<Task?>)(&obj))).Start();
					obj2 = 1;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state == 0)
					{
						obj2 = 0;
					}
					break;
				default:
					return 1;
				case 7:
					GC.SuppressFinalize(((Authenticator)/*Error near IL_0093: Stack underflow*/).ReceiveAuthenticationDataAsync(P_0));
					obj2 = 5;
					break;
				case 4:
					((TcpListener)/*Error near IL_00a8: Stack underflow*/).Dispose();
					obj2 = 3;
					break;
				case 6:
					_ = (Authenticator.ReflectMonoObject() ? ((TaskAwaiter*)1) : ((TaskAwaiter*)null))->IsCompleted;
					_ = 0;
					if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder != 0)
					{
						_ = 0;
					}
					break;
				case 3:
					((ILogger)/*Error near IL_00e9: Stack underflow*/).Error((Exception)P_0, (string)Authenticator._003CListenAsync_003Ed__7.DecorateExpandableParser());
					obj2 = 2;
					break;
				case 1:
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)P_0)->MoveNext();
					((AsyncTaskMethodBuilder*)/*Error near IL_00ff: Stack underflow*/)->SetResult();
					obj2 = 6;
					break;
				case 2:
					((AsyncTaskMethodBuilder*)this)->SetStateMachine((IAsyncStateMachine)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateGenericStruct());
					obj2 = 7;
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
		protected unsafe object _FF00_FF00_FF00_FF00_FF00_FF00洀()
		{
			//IL_001e: Expected I, but got VT
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			((Func<Task>)/*Error near IL_001e: Stack underflow*/)._002Ector((object)/*Error near IL_001e: Stack underflow*/, (nint)typeof(Authenticator._003CListenAuthenticationConnectAsync_003Ed__8).TypeHandle);
			return (object)/*Error near IL_001f: Stack underflow*/;
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00㠀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0045: Expected I, but got Obj
			//IL_0045: Expected Obj, but got Ref
			//IL_004f: Expected native int or pointer, but got Obj
			//IL_0059->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
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
				case 0:
					return;
				case 1:
					((Func<Task>)/*Error near IL_0045: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj2 = 0;
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00㨀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_009f: Expected VT, but got I4
			//IL_00a9: Expected native int or pointer, but got Obj
			//IL_0062: Expected Obj, but got VT
			//IL_006c: Expected native int or pointer, but got Obj
			//IL_0050: Expected Obj, but got I4
			//IL_00d6: Expected I4, but got Obj
			//IL_058e: Expected Obj, but got I4
			//IL_0561: Expected Obj, but got VT
			//IL_01c3: Expected Obj, but got I4
			//IL_04ca: Expected Obj, but got Ref
			//IL_0618: Expected Obj, but got I4
			//IL_061d: Expected Obj, but got I4
			//IL_061d: Expected Obj, but got Ref
			//IL_022b: Expected Obj, but got Ref
			//IL_022b: Expected Obj, but got Ref
			//IL_0691: Expected Obj, but got Ref
			//IL_067b: Expected Obj, but got I
			//IL_0330: Expected Obj, but got I4
			//IL_0335: Expected Obj, but got I4
			//IL_02d2: Expected Obj, but got I4
			//IL_05ec: Expected Obj, but got Ref
			//IL_0641: Expected Obj, but got I4
			//IL_0646: Expected Obj, but got I4
			//IL_0646: Expected Obj, but got Ref
			//IL_05d6: Expected Obj, but got I4
			//IL_05db: Expected VT, but got I4
			//IL_042c: Expected Obj, but got Ref
			//IL_023a: Expected Obj, but got I4
			//IL_023f: Expected Obj, but got I4
			//IL_0249: Expected native int or pointer, but got Obj
			//IL_034b: Expected native int or pointer, but got Obj
			//IL_0357: Expected native int or pointer, but got Obj
			//IL_0361: Expected Ref, but got VT
			//IL_0366: Expected I4, but got Obj
			//IL_0535: Expected native int or pointer, but got Obj
			//IL_038a: Expected Obj, but got I4
			//IL_038f: Expected Obj, but got I4
			//IL_0655: Expected Obj, but got I4
			//IL_065a: Expected Obj, but got Ref
			//IL_01d2: Expected Obj, but got I4
			//IL_01d7: Expected VT, but got I4
			//IL_01e1: Expected native int or pointer, but got Obj
			//IL_047e: Expected Obj, but got Ref
			//IL_01fd: Expected Obj, but got Ref
			//IL_0206: Expected Obj, but got I4
			//IL_0595: Expected native int or pointer, but got Obj
			//IL_059c: Expected native int or pointer, but got Obj
			//IL_05ad: Expected native int or pointer, but got Obj
			//IL_05b7: Expected I4, but got Obj
			//IL_05c3: Expected Obj, but got VT
			//IL_05cc: Expected Obj, but got I4
			//IL_06db: Expected Obj, but got Ref
			//IL_028f: Expected Obj, but got Ref
			//IL_0297: Expected Obj, but got Ref
			//IL_0407: Expected Obj, but got Ref
			//IL_0407: Expected Obj, but got Ref
			//IL_0416: Expected Obj, but got I
			//IL_03a1: Expected VT, but got Obj
			//IL_0316: Expected native int or pointer, but got Obj
			//IL_01b6: Expected I4, but got Obj
			//IL_06ef: Expected Obj, but got I
			//IL_00b3->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0096->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0076->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00be->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0081->IL0026: Incompatible stack types: I4 vs Obj
			//IL_021d->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_056b->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_01cd->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_00ea->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_00f5->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_04b8->IL00f9: Incompatible stack heights: 2 vs 1
			//IL_04d4->IL00f9: Incompatible stack heights: 2 vs 1
			//IL_0631->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_03c7->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_0235->IL00f9: Incompatible stack heights: 2 vs 1
			//IL_06a1->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_0680->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_033f->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_057d->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_0650->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_05e5->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_044d->IL00f9: Incompatible stack heights: 2 vs 1
			//IL_043c->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_0253->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_037a->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_053f->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_0399->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_0664->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_01eb->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_048e->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_050e->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_02ab->IL00f9: Incompatible stack heights: 4 vs 1
			//IL_03ee->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_041b->IL00f9: Incompatible stack heights: 3 vs 1
			//IL_03ab->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_0320->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_0613->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_02f9->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_04c3->IL00f9: Incompatible stack heights: 2 vs 1
			//IL_063c->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_03d2->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_068b->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_05fb->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_046d->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_025e->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_0385->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_054a->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_01f6->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_06f4->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_02b6->IL00f9: Incompatible stack heights: 4 vs 1
			//IL_03f9->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_027e->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_0426->IL00f9: Incompatible stack heights: 3 vs 1
			//IL_032b->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_0304->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_0478->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_06ff->IL00f9: Incompatible stack types: I4 vs Obj
			//IL_0289->IL00f9: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object stateMachine = 3;
			object obj = stateMachine;
			while (true)
			{
				switch ((int)obj)
				{
				case 3:
					stateMachine = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state;
					obj = 2;
					continue;
				case 2:
					stateMachine = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Et__builder;
					obj = 5;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
					{
						obj = 2;
					}
					continue;
				case 1:
					_ = Unsafe.As<object, AsyncTaskMethodBuilder>(ref Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton).Task;
					_ = 4;
					continue;
				case 4:
					return;
				case 5:
				{
					object obj2;
					switch ((int)stateMachine)
					{
					default:
						obj2 = 34;
						if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
						{
							obj2 = 23;
						}
						goto IL_00f9;
					case 3:
						stateMachine = ((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003E1__state;
						obj2 = 7;
						goto IL_00f9;
					case 0:
						goto IL_020b;
					case 2:
						goto IL_0559;
					case 1:
						goto IL_057d;
						IL_00f9:
						while (true)
						{
							switch ((int)obj2)
							{
							case 2:
								return;
							case 16:
								return;
							case 18:
								return;
							case 37:
								return;
							case 39:
								break;
							case 17:
								goto end_IL_00f9;
							case 30:
								stateMachine = 1;
								((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)1;
								obj2 = 5;
								if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9._003C_003E4__this)->client == null)
								{
									obj2 = 2;
								}
								continue;
							case 29:
							case 32:
								goto IL_01f6;
							case 20:
								goto IL_020b;
							case 6:
								((RestResponse<EntityFeverManifest>)(object)Unsafe.AsPointer(ref ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003E1__state)).EnsureSuccessStatusCode<EntityFeverManifest>((string?)(&stateMachine), (byte)Unsafe.AsPointer(ref this) != 0);
								_ = 2;
								continue;
							case 23:
								stateMachine = -1;
								((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this).client = (TcpClient)(-1);
								obj2 = 0;
								if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E4__this)->_003Cstream_003E5__2 != null)
								{
									obj2 = 0;
								}
								continue;
							case 40:
								if (((TaskAwaiter<TcpClient>*)(&stateMachine))->GetResult() != null)
								{
									obj2 = 8;
									if (((FeverInstaller)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway)._003CfeverVersion_003EP == null)
									{
										obj2 = 8;
									}
									continue;
								}
								goto case 10;
							case 36:
								_ = ref ((FeverInstaller)Unsafe.AsPointer(ref this))._003CappId_003EP;
								_ = ref stateMachine;
								((IEnumerable<byte>)Unsafe.AsPointer(ref this)).ToArray();
								_ = 5;
								if (((FeverInstaller)FeverInstaller.McBedrock__BackingField).Client__BackingField == null)
								{
									_ = 18;
								}
								continue;
							case 11:
								goto IL_02b6;
							case 45:
								((RestClientOptions)((FeverInstaller)/*Error near IL_02de: Stack underflow*/).GetFeverManifestAsync(stateMachine))._002Ector();
								stateMachine = (object)/*Error near IL_02e5: Stack underflow*/;
								obj2 = 16;
								if (((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003Eu__1)._003C_003E1__state == 0)
								{
									obj2 = 19;
								}
								continue;
							case 43:
								FeverInstaller._002Ecctor();
								obj2 = 25;
								if ((int)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E4__this)->_003C_003Eu__1 != 0)
								{
									obj2 = 13;
								}
								continue;
							case 10:
								stateMachine = 2;
								FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor = 2;
								obj2 = 42;
								continue;
							case 24:
							{
								int num = FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003E1__state;
								(FeverInstaller._003CFeverRequest_003Ed__15<>.CheckAdaptableResponder() ? ((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)1) : ((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)null))->Start<TStateMachine>(ref *(TStateMachine*)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)stateMachine)->_003C_003E4__this);
								((DefaultInterpolatedStringHandler*)num)->AppendFormatted((EnumItemMasterType)((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)stateMachine)->_003C_003Eu__1)->Task);
								obj2 = 11;
								if (((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13._003C_003Et__builder)._003C_003E4__this == null)
								{
									obj2 = 4;
								}
								continue;
							}
							case 26:
								stateMachine = -1;
								((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this).version = (EntityFeverAppVersion)(-1);
								obj2 = 21;
								continue;
							case 42:
								((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003Eu__1 = (TaskAwaiter<EntityFeverManifestInfo>)stateMachine;
								obj2 = 6;
								continue;
							case 5:
								FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CheckScalableWorker = stateMachine;
								obj2 = 41;
								if ((int)((FeverInstaller._003CInstallAsync_003Ed__11*)FeverInstaller._003CInstallAsync_003Ed__11._003C_003E1__state)->_003C_003Et__builder == 0)
								{
									obj2 = 23;
								}
								continue;
							case 38:
								((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003E4__this = (FeverInstaller)stateMachine;
								obj2 = 23;
								if ((int)((FeverInstaller._003CInstallAsync_003Ed__11)FeverInstaller._003CInstallAsync_003Ed__11._003C_003Eu__1)._003C_003Eu__2 == 0)
								{
									obj2 = 36;
								}
								continue;
							case 41:
								_ = ref ((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003Eu__3;
								((IReadOnlyDictionary<string, JsonElement>)(&stateMachine)).GetValueOrDefault((string)Unsafe.AsPointer(ref this));
								_ = 14;
								if (((Rpc)Rpc.ProcessId__BackingField).Logger__BackingField != null)
								{
									_ = 16;
								}
								continue;
							case 22:
								Unsafe.As<nint, @null>(ref ((Rpc)Unsafe.AsPointer(ref this)).NeedCha__BackingField) = null;
								obj2 = 23;
								continue;
							case 8:
							case 21:
								((TaskAwaiter<RestResponse<EntityFeverResponse<_00210>>>*)(&stateMachine))->GetResult();
								_ = 45;
								continue;
							case 19:
								((AsyncTaskMethodBuilder<_00210>*)/*Error near IL_0454: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_0454: Stack underflow*/, ref *(TStateMachine*)(&stateMachine));
								if ((int)/*Error near IL_0459: Stack underflow*/ == 0)
								{
									obj2 = 5;
									if (((Rpc)Rpc.Listener__BackingField)._chaChaEn != null)
									{
										obj2 = 14;
									}
									continue;
								}
								goto case 3;
							case 31:
								Unsafe.As<object, RuntimeTypeHandle>(ref ((Rpc)Unsafe.AsPointer(ref this))._chaChaDe) = default;
								obj2 = 26;
								continue;
							default:
								_ = ((TaskAwaiter<EntityFeverApp>*)(&stateMachine))->IsCompleted;
								_ = 9;
								if (((Rpc._003CListenAsync_003Ed__34)Rpc._003CListenAsync_003Ed__34._003C_003Et__builder)._003C_003E4__this != null)
								{
									_ = 5;
								}
								continue;
							case 3:
								((Task<EntityFeverApp>)(&stateMachine)).GetAwaiter();
								_ = 39;
								continue;
							case 33:
								Unsafe.As<AsyncTaskMethodBuilder, DefaultInterpolatedStringHandler>(ref ((Rpc._003CListenControlConnectAsync_003Ed__35)this)._003C_003Et__builder) = default;
								obj2 = 4;
								continue;
							case 25:
								((AsyncTaskMethodBuilder<EntityFeverManifest>*)/*Error near IL_0529: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_0529: Stack underflow*/, ref *(TStateMachine*)((Rpc)stateMachine).Listener);
								stateMachine = (object)/*Error near IL_052b: Stack underflow*/;
								obj2 = 6;
								if (((Rpc._003CReceiveAsync_003Ed__28*)(nint)Rpc._003CListenControlConnectAsync_003Ed__35.ReflectSymbolicDecorator)->_003C_003E1__state != 0)
								{
									obj2 = 40;
								}
								continue;
							case 27:
								goto IL_0559;
							case 13:
								((Rpc._003CReceiveAsync_003Ed__28)this).client = (TcpClient)stateMachine;
								obj2 = 44;
								continue;
							case 1:
								goto IL_057d;
							case 34:
								goto IL_0593;
							case 15:
								stateMachine = -1;
								((Rpc._003CSyncChaChaAsync_003Ed__38)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-1);
								obj2 = 3;
								continue;
							case 12:
								((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)/*Error near IL_05ec: Stack underflow*/)->SetException((Exception)(&stateMachine));
								if ((int)/*Error near IL_05f1: Stack underflow*/ != 0)
								{
									obj2 = 29;
									continue;
								}
								goto case 30;
							case 44:
								Unsafe.As<RpcCallBack, AsyncTaskMethodBuilder>(ref ((Rpc._003CSyncChaChaAsync_003Ed__38)this).callBack).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&stateMachine), ref Unsafe.As<_003CConnectAsync_003Ed__37, JavaGame._003COnDataReceivedAsync_003Ed__12>(ref this));
								obj2 = 37;
								continue;
							case 4:
								stateMachine = -1;
								((CppGameValue)Unsafe.AsPointer(ref this)).SkinPath__BackingField = -1;
								obj2 = 32;
								if (((GameValue)CppGameValue.DecorateAlphabeticList).MaxConcurrency__BackingField != 0)
								{
									obj2 = 30;
								}
								continue;
							case 14:
								stateMachine = 3;
								GameValue.CheckSimpleMapper = 3;
								obj2 = 13;
								continue;
							case 28:
								stateMachine = 0;
								((JavaGameValue)Unsafe.AsPointer(ref this)).MaxMemory__BackingField = 0;
								obj2 = 38;
								continue;
							case 9:
								((JavaGameValue)stateMachine).Reconnect__BackingField = 1;
								obj2 = 6;
								if (((JavaGameValue)JavaGameValue.ReconnectDelay__BackingField).SaveOptions__BackingField == 0)
								{
									obj2 = 24;
								}
								continue;
							case 7:
								Unsafe.As<nint, @null>(ref ((JavaGameValue)Unsafe.AsPointer(ref this)).SetChinese__BackingField) = null;
								obj2 = 15;
								continue;
							case 35:
								((BinaryWriter)(&stateMachine)).Flush();
								if ((int)/*Error near IL_06e0: Stack underflow*/ == 0)
								{
									obj2 = 28;
									if (JavaGameValue.ReflectResponsiveModule == null)
									{
										obj2 = 3;
									}
									continue;
								}
								goto default;
							}
							goto end_IL_00c1;
							continue;
							end_IL_00f9:
							break;
						}
						goto case 3;
						IL_0593:
						((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)/*Error near IL_05a6: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)Rpc._003CReceiveAsync_003Ed__28.CheckMonoProgram, ref *(TStateMachine*)((Rpc._003CRemoteCallBackAsync_003Ed__21*)(nint)stateMachine)->_003C_003E1__state);
						stateMachine = ((Task<EntityFeverManifestInfo>)(object)((string)/*Error near IL_05bc: Stack underflow*/).Replace((string)(object)RestRequestExtensions.AddQueryParameter<_0021_00210>((RestRequest)/*Error near IL_05ab: Stack underflow*/, (string)/*Error near IL_05ab: Stack underflow*/, (_0021_00210)/*Error near IL_05ab: Stack underflow*/, (byte)/*Error near IL_05ab: Stack underflow*/ != 0), RandomHelper.GetHex((int)((Rpc._003CRemoteCallBackAsync_003Ed__21*)(nint)stateMachine)->callBack))).GetAwaiter();
						stateMachine = 35;
						goto IL_00f5;
						IL_057d:
						stateMachine = ((Rpc._003CReceiveAsync_003Ed__28)this)._003C_003E4__this;
						stateMachine = 33;
						goto IL_00f5;
						IL_0559:
						stateMachine = ((Rpc._003CReceiveAsync_003Ed__28)this)._003C_003Et__builder;
						obj2 = 31;
						goto IL_00f9;
						IL_02b6:
						((FeverInstaller)FeverInstaller.ReflectVisualArgument).Dispose();
						((Stream)/*Error near IL_02c7: Stack underflow*/).Write((byte[])/*Error near IL_02c7: Stack underflow*/, (int)/*Error near IL_02c7: Stack underflow*/, (int)/*Error near IL_02c7: Stack underflow*/);
						stateMachine = (object)/*Error near IL_02c9: Stack underflow*/;
						stateMachine = 12;
						goto IL_00f5;
						IL_020b:
						stateMachine = Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain;
						obj2 = 22;
						goto IL_00f9;
						IL_01f6:
						((AsyncTaskMethodBuilder*)/*Error near IL_01fd: Stack underflow*/)->SetException((Exception)(&stateMachine));
						stateMachine = 43;
						goto IL_00f5;
						IL_00f5:
						obj2 = stateMachine;
						goto IL_00f9;
						end_IL_00c1:
						break;
					}
					break;
				}
				}
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-2);
				obj = 0;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
				{
					obj = 1;
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00㼀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_3000(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
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
					((Func<Task>)/*Error near IL_0044: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_3100()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_0047: Expected I4, but got Obj
			//IL_00af: Expected native int or pointer, but got Obj
			//IL_0526: Expected VT, but got Obj
			//IL_0530: Expected native int or pointer, but got Obj
			//IL_0061: Expected native int or pointer, but got Obj
			//IL_007e: Expected Obj, but got I4
			//IL_015d: Expected native int or pointer, but got Obj
			//IL_0167: Expected Ref, but got VT
			//IL_0182: Expected native int or pointer, but got Obj
			//IL_01c2: Expected native int or pointer, but got Obj
			//IL_0132: Expected Ref, but got F8
			//IL_0137: Expected Obj, but got Ref
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Expected VT, but got Unknown
			//IL_0146: Expected native int or pointer, but got Obj
			//IL_02a4: Expected Obj, but got I4
			//IL_0209: Expected native int or pointer, but got Obj
			//IL_02b0: Expected native int or pointer, but got Obj
			//IL_02ba: Expected Ref, but got VT
			//IL_0277: Expected Obj, but got Ref
			//IL_0272: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f6: Expected Obj, but got I4
			//IL_02d6: Expected Ref, but got VT
			//IL_036e: Expected native int or pointer, but got Obj
			//IL_038b: Expected VT, but got Obj
			//IL_0347: Expected Obj, but got I4
			//IL_034c: Expected Obj, but got I4
			//IL_00b9->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00e0->IL0026: Incompatible stack types: I4 vs Obj
			//IL_053a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0092->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00c4->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00eb->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0545->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0076->IL0026: Incompatible stack types: I4 vs Obj
			//IL_009d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01cc->IL0101: Incompatible stack heights: 4 vs 1
			//IL_01d7->IL0101: Incompatible stack heights: 4 vs 1
			//IL_0316->IL0222: Incompatible stack heights: 3 vs 1
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 1;
			object obj = awaiter;
			while (true)
			{
				int num2;
				int num;
				switch ((int)obj)
				{
				case 5:
					((Func<Task>)/*Error near IL_0057: Stack underflow*/)._002Ector((object)/*Error near IL_0057: Stack underflow*/, (nint)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state));
					obj = 4;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
					{
						obj = 1;
					}
					break;
				case 6:
					Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton = -2;
					obj = 2;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj = 3;
					}
					break;
				default:
					awaiter = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this).listener;
					obj = 2;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj = 2;
					}
					break;
				case 1:
					awaiter = Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler;
					obj = 0;
					if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj = 0;
					}
					break;
				case 2:
					if (awaiter != null)
					{
						num2 = 2;
						goto IL_0101;
					}
					goto IL_01d7;
				case 4:
					return;
				case 3:
					{
						((Rpc._003CListenControlConnectAsync_003Ed__35)this)._003C_003Eu__1 = (TaskAwaiter<TcpClient>)null;
						obj = 5;
						if (((Rpc._003CReceiveAsync_003Ed__28*)(nint)Rpc._003CListenControlConnectAsync_003Ed__35.ReflectSymbolicDecorator)->_003C_003E1__state != 0)
						{
							obj = 5;
						}
						break;
					}
					IL_0222:
					while (true)
					{
						switch (num)
						{
						case 11:
							break;
						case 3:
							new RestClient((RestClientOptions)/*Error near IL_0277: Stack underflow*/, (ConfigureHeaders)(object)(&awaiter), (ConfigureSerialization)awaiter, (byte)__ldftn(FeverInstaller.FeverRequest<T>) != 0).Dispose();
							num = 1;
							if (FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor != null)
							{
								num = 1;
							}
							continue;
						case 5:
							goto IL_029c;
						case 1:
							((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)/*Error near IL_02bf: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)awaiter)->_003C_003Et__builder)->Task);
							awaiter = (object)/*Error near IL_02c1: Stack underflow*/;
							num = 14;
							continue;
						case 8:
							awaiter = ((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003Eu__1)->Task;
							num = 3;
							continue;
						case 7:
							awaiter = 0;
							((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003E1__state = 0;
							num = 10;
							continue;
						case 2:
						case 6:
							_ = ref awaiter;
							AsyncTaskMethodBuilder<_0021_00210>.Create();
							_ = 11;
							continue;
						default:
							/*Error near IL_0318: Member reference must be method, but was: Field*/;
						case 14:
							_ = ref awaiter;
							/*Error near IL_032e: Member reference must be method, but was: Field*/;
						case 12:
							awaiter = -1;
							FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CheckScalableWorker = -1;
							num = 6;
							continue;
						case 9:
							Unsafe.As<int, AsyncTaskMethodBuilder<string>>(ref ((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003E1__state).AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)(&awaiter), ref Unsafe.As<_003CConnectWebRtc_003Ed__35, JavaAuthenticator._003CHandleAuthentication_003Ed__9>(ref this));
							num = 13;
							if ((int)((FeverInstaller._003CInstallAsync_003Ed__11*)(nint)FeverInstaller._003CInstallAsync_003Ed__11._003C_003E4__this)->_003C_003Eu__1 == 0)
							{
								num = 10;
							}
							continue;
						case 10:
							((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003Eu__2 = (TaskAwaiter<EntityFeverManifestInfo>)awaiter;
							num = 9;
							continue;
						case 13:
							return;
						case 4:
							Unsafe.As<TaskAwaiter<EntityFeverManifest>, @null>(ref ((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003Eu__3) = null;
							num = 12;
							continue;
						}
						break;
					}
					goto case 6;
					IL_01d7:
					num2 = 4;
					if (((FeverInstaller._003CFeverRequest_003Ed__15<>)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003Et__builder)._003C_003E4__this != null)
					{
						num2 = 5;
					}
					goto IL_0101;
					IL_0101:
					while (true)
					{
						switch (num2)
						{
						case 4:
							((TaskAwaiter*)10.0)->GetResult();
							Unsafe.Write(&((Authenticator._003CReceiveAsync_003Ed__9*)(nint)/*Error near IL_013c: Stack underflow*/)->_003C_003Eu__1, (TaskAwaiter)new ILogger((Exception)/*Error near IL_0137: Stack underflow*/, (string)Unsafe.AsPointer(ref this)));
							num2 = 1;
							if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain)->_003C_003E1__state == 0)
							{
								num2 = 1;
							}
							continue;
						default:
							((Authenticator._003CReceiveAsync_003Ed__9*)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)awaiter)->_003C_003Et__builder)->MoveNext();
							((Authenticator._003CReceiveAsync_003Ed__9*)/*Error near IL_016c: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)/*Error near IL_016c: Stack underflow*/);
							num2 = 4;
							continue;
						case 2:
							((AsyncTaskMethodBuilder*)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003Cstream_003E5__2)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityFeverManifest>*)Authenticator._003CReceiveAsync_003Ed__9.DecorateConvertibleParameter(), ref *(FeverInstaller._003CInstallAsync_003Ed__11*)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway);
							num2 = 3;
							if (((FeverInstaller)FeverInstaller._003CappId_003EP)._003CappVersion_003EP != null)
							{
								num2 = 3;
							}
							continue;
						case 3:
							_ = FeverInstaller.McBedrock__BackingField;
							_ = 1;
							_ = FeverInstaller.McBedrock;
							_ = 0;
							if (((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)FeverInstaller.ReflectVisualArgument)->_003C_003E1__state == 0)
							{
								_ = 0;
							}
							continue;
						case 1:
							break;
						case 5:
							goto IL_01f7;
						}
						break;
					}
					goto IL_01d7;
					IL_01f7:
					if (awaiter != null)
					{
						num = 0;
						if ((int)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)FeverInstaller._003CFeverRequest_003Ed__15<>.request)->_003C_003Eu__1 == 0)
						{
							num = 0;
						}
						goto IL_0222;
					}
					goto IL_029c;
					IL_029c:
					awaiter = ((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003E1__state;
					num = 4;
					goto IL_0222;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00㔀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00ἀ(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0045: Expected I, but got Obj
			//IL_0045: Expected Obj, but got Ref
			//IL_004f: Expected native int or pointer, but got Obj
			//IL_0059->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
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
				case 0:
					return;
				case 1:
					((Func<Task>)/*Error near IL_0045: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj2 = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_2000()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0730: Expected Obj, but got Ref
			//IL_0732: Expected Obj, but got I
			//IL_0709: Expected Obj, but got Ref
			//IL_071a: Expected Obj, but got I
			//IL_005d: Expected native int or pointer, but got Obj
			//IL_0745: Expected Obj, but got Ref
			//IL_0754: Expected Obj, but got I
			//IL_0624: Expected native int or pointer, but got Obj
			//IL_0160: Expected native int or pointer, but got Obj
			//IL_0594: Expected native int or pointer, but got Obj
			//IL_0549: Expected Obj, but got Ref
			//IL_01c9: Expected I4, but got Obj
			//IL_0149: Expected native int or pointer, but got Obj
			//IL_01f0: Expected Ref, but got VT
			//IL_0537: Expected I4, but got Obj
			//IL_0588: Expected I4, but got VT
			//IL_0614: Expected Obj, but got VT
			//IL_061d: Expected Obj, but got I4
			//IL_05af: Expected native int or pointer, but got Obj
			//IL_05f6: Expected I4, but got VT
			//IL_0380: Expected Obj, but got I4
			//IL_02a3: Expected Obj, but got I4
			//IL_0653: Expected I4, but got VT
			//IL_065c: Expected Obj, but got I4
			//IL_05ce: Expected Obj, but got VT
			//IL_05d8: Expected Obj, but got VT
			//IL_00f9: Expected I4, but got Obj
			//IL_041e: Expected native int or pointer, but got Obj
			//IL_02f3: Expected Obj, but got I4
			//IL_02f8: Expected Obj, but got I4
			//IL_03cf: Expected Obj, but got I4
			//IL_03d4: Expected Obj, but got I4
			//IL_03c5: Expected Obj, but got I4
			//IL_0322: Expected native int or pointer, but got Obj
			//IL_02e9: Expected I4, but got Obj
			//IL_03a0: Expected native int or pointer, but got Obj
			//IL_073c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_071f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0067->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0759->IL0026: Incompatible stack types: I4 vs Obj
			//IL_072a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0072->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0764->IL0026: Incompatible stack types: I4 vs Obj
			//IL_020a->IL0088: Incompatible stack types: I4 vs Obj
			//IL_0084->IL0088: Incompatible stack types: I4 vs Obj
			//IL_055a->IL0088: Incompatible stack types: I4 vs Obj
			//IL_01ae->IL0088: Incompatible stack types: I4 vs Obj
			//IL_0153->IL0088: Incompatible stack types: I4 vs Obj
			//IL_01ff->IL0088: Incompatible stack heights: 2 vs 1
			//IL_0117->IL0088: Incompatible stack heights: 3 vs 1
			//IL_0196->IL0088: Incompatible stack heights: 2 vs 1
			//IL_0130->IL0088: Incompatible stack types: I4 vs Obj
			//IL_0543->IL0088: Incompatible stack types: I4 vs Obj
			//IL_063f->IL0088: Incompatible stack types: I4 vs Obj
			//IL_0592->IL0088: Incompatible stack heights: 2 vs 1
			//IL_0176->IL0088: Incompatible stack types: I4 vs Obj
			//IL_0525->IL0088: Incompatible stack types: I4 vs Obj
			//IL_05b9->IL0088: Incompatible stack types: I4 vs Obj
			//IL_0600->IL0088: Incompatible stack heights: 2 vs 1
			//IL_0222->IL0088: Incompatible stack types: I4 vs Obj
			//IL_01d3->IL0088: Incompatible stack types: I4 vs Obj
			//IL_015e->IL0088: Incompatible stack types: I4 vs Obj
			//IL_038a->IL02ac: Incompatible stack types: I4 vs Obj
			//IL_023f->IL0088: Incompatible stack types: I4 vs Obj
			//IL_0661->IL0084: Incompatible stack heights: 1 vs 0
			//IL_0530->IL0088: Incompatible stack types: I4 vs Obj
			//IL_05c4->IL0088: Incompatible stack types: I4 vs Obj
			//IL_05e2->IL0088: Incompatible stack heights: 3 vs 1
			//IL_024a->IL0088: Incompatible stack types: I4 vs Obj
			//IL_03f4->IL02ac: Incompatible stack types: I4 vs Obj
			//IL_0396->IL02ee: Incompatible stack heights: 1 vs 0
			//IL_0428->IL02ac: Incompatible stack heights: 2 vs 1
			//IL_0406->IL02ac: Incompatible stack types: I4 vs Obj
			//IL_0302->IL02ac: Incompatible stack types: I4 vs Obj
			//IL_03de->IL02ac: Incompatible stack types: I4 vs Obj
			//IL_03ca->IL02a8: Incompatible stack heights: 2 vs 0
			//IL_036d->IL02ac: Incompatible stack types: I4 vs Obj
			//IL_03aa->IL02ac: Incompatible stack heights: 2 vs 1
			//IL_0433->IL02ac: Incompatible stack heights: 2 vs 1
			//IL_0340->IL02ac: Incompatible stack types: I4 vs Obj
			//IL_0378->IL02ac: Incompatible stack types: I4 vs Obj
			//IL_03b5->IL02ac: Incompatible stack heights: 2 vs 1
			//IL_034b->IL02ac: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				case 2:
					((Func<Task>)/*Error near IL_0053: Stack underflow*/)._002Ector((object)/*Error near IL_0053: Stack underflow*/, (nint)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state));
					obj2 = 4;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj2 = 3;
					}
					continue;
				case 5:
					if (obj != null)
					{
						obj3 = 6;
						goto IL_0088;
					}
					goto IL_01ff;
				case 1:
					obj = CppGameValue.DecorateAlphabeticList;
					obj2 = 0;
					if (GameValue.CheckSimpleMapper != null)
					{
						obj2 = 0;
					}
					continue;
				default:
					obj = ((JavaGameValue)Unsafe.AsPointer(ref this)).MaxMemory__BackingField;
					obj2 = 5;
					continue;
				case 4:
					return;
				case 3:
					break;
					IL_0088:
					while (true)
					{
						object obj4;
						switch ((int)obj3)
						{
						case 9:
						case 17:
							((Authenticator)/*Error near IL_0108: Stack underflow*/).ReceiveAsync(Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton);
							AsyncTaskMethodBuilder.Create();
							_ = 18;
							continue;
						case 12:
						case 22:
							((IAsyncStateMachine)((Authenticator)/*Error near IL_0121: Stack underflow*/).HandleAuthentication((string)(object)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)).MoveNext();
							obj3 = 5;
							continue;
						case 14:
						case 24:
							((Authenticator._003CListenAsync_003Ed__7*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->MoveNext();
							((AsyncTaskMethodBuilder*)/*Error near IL_013f: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_013f: Stack underflow*/, ref *(TStateMachine*)/*Error near IL_013f: Stack underflow*/);
							obj3 = 10;
							if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9._003C_003E4__this)->client != null)
							{
								obj3 = 3;
							}
							continue;
						case 1:
						{
							TaskAwaiter taskAwaiter = ((Authenticator._003CReceiveAsync_003Ed__9*)(nint)obj)->_003C_003Eu__1;
							if ((int)taskAwaiter == 0)
							{
								obj3 = 24;
								continue;
							}
							RestRequestExtensions.AddQueryParameter((RestRequest)/*Error near IL_0588: Stack underflow*/, (string)/*Error near IL_0588: Stack underflow*/, (string)/*Error near IL_0588: Stack underflow*/, (byte)(int)taskAwaiter != 0);
							_ = 14;
							continue;
						}
						case 2:
						case 21:
							_ = Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain;
							(Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateGenericStruct() ? ((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)1) : ((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)null))->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityFeverManifestInfo>*)obj, ref *(FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.ReflectRandomReporter());
							_ = 26;
							continue;
						case 8:
							((Authenticator._003CReceiveAsync_003Ed__9*)obj)->SetStateMachine((IAsyncStateMachine)obj);
							Unsafe.Write(&((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)/*Error near IL_01a4: Stack underflow*/)->_003Cstream_003E5__2, /*Error near IL_01a4: Stack underflow*/);
							obj3 = 19;
							continue;
						case 11:
							switch ((int)obj)
							{
							case 0:
								break;
							default:
								goto IL_01c9;
							case 3:
								goto IL_020a;
							case 1:
								goto IL_0503;
							case 4:
								goto IL_0592;
							case 2:
								goto IL_0622;
							}
							goto case 8;
						case 15:
						case 25:
							((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003Eu__1)->MoveNext();
							((Encoding)/*Error near IL_01f5: Stack underflow*/).GetBytes((string)/*Error near IL_01f5: Stack underflow*/);
							_ = 13;
							continue;
						case 19:
							break;
						case 7:
							goto IL_020a;
						case 20:
							if ((nint)obj == 17)
							{
								obj3 = 0;
								if (FeverInstaller.McBedrock__BackingField == null)
								{
									obj3 = 8;
								}
								continue;
							}
							goto IL_0622;
						case 16:
							if (obj != null)
							{
								obj = 9;
								goto IL_02a8;
							}
							goto IL_0378;
						case 3:
							goto IL_0503;
						case 23:
							((Rpc)/*Error near IL_0537: Stack underflow*/)._002Ector((ILogger)/*Error near IL_0537: Stack underflow*/, (byte)(int)obj != 0);
							obj = (object)/*Error near IL_0539: Stack underflow*/;
							obj3 = 11;
							continue;
						case 6:
							((ILogger)/*Error near IL_054e: Stack underflow*/).Information<string>((string)/*Error near IL_054e: Stack underflow*/, (string)((Rpc)Unsafe.AsPointer(ref this))._chaChaDe);
							obj = (object)/*Error near IL_0550: Stack underflow*/;
							obj3 = 23;
							continue;
						case 4:
							goto IL_0592;
						default:
							goto IL_0622;
						case 5:
						case 10:
						case 13:
						case 18:
						case 26:
							goto end_IL_0026;
							IL_0378:
							obj = ((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003E1__state;
							obj4 = 2;
							goto IL_02ac;
							IL_02ac:
							while (true)
							{
								switch ((int)obj4)
								{
								case 6:
									obj = 0;
									((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003E4__this = (FeverInstaller)0;
									obj4 = 5;
									continue;
								case 1:
									return;
								case 9:
									if (((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)obj)->request == null)
									{
										obj4 = 0;
										if (((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003Eu__1)._003C_003E1__state == 0)
										{
											obj4 = 0;
										}
										continue;
									}
									goto case 11;
								case 11:
								{
									object obj5 = obj;
									FeverInstaller._002Ecctor();
									((RestClient)obj5).Dispose();
									obj = (object)/*Error near IL_0359: Stack underflow*/;
									obj4 = 3;
									if (FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor == null)
									{
										obj4 = 3;
									}
									continue;
								}
								case 10:
									goto IL_0378;
								case 3:
									_ = ref obj;
									if ((int)AsyncTaskMethodBuilder<EntityFeverManifestInfo>.Create() != 0)
									{
										_ = 10;
										if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003E4__this)->info == null)
										{
											_ = 12;
										}
										continue;
									}
									goto case 6;
								case 8:
								case 12:
									goto IL_03b5;
								case 7:
									obj = -1;
									FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReflectReporter = -1;
									obj4 = 8;
									continue;
								case 2:
									Unsafe.As<int, @null>(ref ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003E1__state) = null;
									obj4 = 7;
									continue;
								case 5:
									((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003E4__this = (FeverInstaller)obj;
									obj4 = 4;
									continue;
								case 4:
									_ = ref ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this).version;
									((AsyncTaskMethodBuilder<string>*)(&obj))->Start(ref Unsafe.As<_003CHandleJoinRoomResponseAsync_003Ed__34, JavaAuthenticator._003CHandleAuthentication_003Ed__9>(ref this));
									_ = 1;
									if (((FeverInstaller._003CInstallAsync_003Ed__11*)(nint)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CheckScalableWorker)->_003C_003E1__state != 0)
									{
										_ = 1;
									}
									continue;
								}
								break;
							}
							goto case 1;
							IL_03b5:
							_ = ref obj;
							AsyncTaskMethodBuilder<EntityFeverAppVersion>.Create();
							obj = 13;
							goto IL_02a8;
							IL_02a8:
							obj4 = obj;
							goto IL_02ac;
							IL_01c9:
							obj3 = 20;
							continue;
						}
						break;
						IL_0622:
						object obj6 = Rpc._003CReceiveAsync_003Ed__28.CheckMonoProgram;
						if (obj6 == null)
						{
							obj3 = 2;
							continue;
						}
						((Rpc._003CListenAsync_003Ed__34*)/*Error near IL_0649: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)obj6);
						RestRequestExtensions.AddQueryParameter<_0021_00210>((RestRequest)/*Error near IL_0653: Stack underflow*/, (string)/*Error near IL_0653: Stack underflow*/, (_0021_00210)/*Error near IL_0653: Stack underflow*/, (byte)(int)new AsyncTaskMethodBuilder<EntityFeverManifestInfo>(ref *(TAwaiter*)/*Error near IL_064e: Stack underflow*/, ref *(TStateMachine*)/*Error near IL_064e: Stack underflow*/) != 0);
						obj = 21;
						goto IL_0084;
						IL_0084:
						obj3 = obj;
						continue;
						IL_020a:
						object obj7 = ((FeverInstaller)obj)._003CappId_003EP;
						if (obj7 == null)
						{
							obj3 = 12;
							continue;
						}
						((Rpc)/*Error near IL_05ec: Stack underflow*/).Listener = (TcpListener?)obj7;
						RestResponseExtensions.EnsureSuccessStatusCode<T>((RestResponse<T>)/*Error near IL_05f6: Stack underflow*/, (string?)/*Error near IL_05f6: Stack underflow*/, (byte)(int)new TaskAwaiter<RestResponse<EntityFeverManifest>>() != 0);
						_ = 22;
						continue;
						IL_0592:
						TaskAwaiter taskAwaiter2 = ((Rpc._003CListenAsync_003Ed__34*)(nint)obj)->_003C_003Eu__1;
						if ((int)taskAwaiter2 == 0)
						{
							obj3 = 9;
							if (((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)Rpc._003CListenAsync_003Ed__34.DecorateIterableWriter)->_003C_003E1__state != 0)
							{
								obj3 = 5;
							}
						}
						else
						{
							((Rpc)/*Error near IL_05ce: Stack underflow*/).ReceiveAsync((object)taskAwaiter2);
							((Task<RestResponse<EntityFeverManifest>>)new TaskAwaiter<RestResponse<EntityFeverManifest>>()).GetAwaiter();
							_ = 17;
						}
						continue;
						IL_0503:
						Dictionary<ushort, Func<RpcCallBack, Task>> dictionary = ((Rpc)obj).Callbacks__BackingField;
						if (dictionary == null)
						{
							obj3 = 25;
							if (((Rpc)Rpc.Writer__BackingField).Listener__BackingField == null)
							{
								obj3 = 15;
							}
							continue;
						}
						((AsyncTaskMethodBuilder<EntityFeverManifest>*)/*Error near IL_0614: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)new AsyncTaskMethodBuilder<EntityFeverManifest>((EntityFeverManifest)(object)((Rpc)/*Error near IL_060a: Stack underflow*/).SyncChaChaAsync((RpcCallBack)(object)dictionary)));
						obj = 15;
						goto IL_0084;
					}
					goto IL_01ff;
					IL_01ff:
					obj3 = 16;
					goto IL_0088;
					end_IL_0026:
					break;
				}
				((JavaGameValue)Unsafe.AsPointer(ref this)).Reconnect__BackingField = -2;
				obj2 = 2;
				if (((JavaGameValue)JavaGameValue.ReconnectDelay__BackingField).SaveOptions__BackingField == 0)
				{
					obj2 = 2;
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00ⴀ()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00ᔀ(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
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
					((Func<Task>)/*Error near IL_0044: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00ᘀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779202, new IntPtr(2737367893244L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00ᜀ()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00ᨀ()
		{
			// ILSpy could not decompile this. Please report the exception below,
			// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
			// System.ArgumentNullException: Value cannot be null. (Parameter 'source')
			//    at System.Linq.ThrowHelper.ThrowArgumentNullException(ExceptionArgument argument)
			//    at System.Linq.Enumerable.Skip[TSource](IEnumerable`1 source, Int32 count)
			//    at ICSharpCode.Decompiler.CSharp.ArgumentList.GetArgumentResolveResultsDirect(Int32 skipCount) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 124
			//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Probe() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 493
			//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Run() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 438
			//    at ICSharpCode.Decompiler.CSharp.Disambiguator.ForMethodReference(ExpressionBuilder expressionBuilder, IMethod method, IType targetType, TranslatedExpression target, Boolean requireTarget, ExpectedTargetDetails expectedTargetDetails, Boolean isExtensionMethodReference, Boolean castTargetUpFront) in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 131
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.DisambiguateDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1718
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1648
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildMethodReference(IMethod method, Boolean isVirtual) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1639
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitLdFtn(LdFtn inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 5058
			//    at ICSharpCode.Decompiler.IL.LdFtn.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 3175
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitConv(Conv inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2307
			//    at ICSharpCode.Decompiler.IL.Conv.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2298
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildArgumentList(ExpectedTargetDetails expectedTargetDetails, ResolveResult target, IMethod method, Int32 firstParamIndex, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, Boolean writtenAsAssignment) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1070
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(OpCode callOpCode, IMethod method, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, IType constrainedTo) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 461
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(CallInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 255
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitNewObj(NewObj inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 538
			//    at ICSharpCode.Decompiler.IL.NewObj.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4578
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitConv(Conv inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2307
			//    at ICSharpCode.Decompiler.IL.Conv.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2298
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildArgumentList(ExpectedTargetDetails expectedTargetDetails, ResolveResult target, IMethod method, Int32 firstParamIndex, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, Boolean writtenAsAssignment) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1070
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(OpCode callOpCode, IMethod method, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, IType constrainedTo) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 461
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(CallInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 255
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitCall(Call inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2530
			//    at ICSharpCode.Decompiler.IL.Call.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2192
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Default(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 93
			//    at ICSharpCode.Decompiler.IL.ILVisitor`1.VisitCall(Call inst) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 7663
			//    at ICSharpCode.Decompiler.IL.Call.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2188
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
			//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertSwitchSectionBody(SwitchSection astSection, ILInstruction bodyInst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 334
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.TranslateSwitch(BlockContainer switchContainer, SwitchInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 280
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1334
			//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertLoop(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1354
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1325
			//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.TranslateSwitch(BlockContainer switchContainer, SwitchInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 307
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1334
			//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertLoop(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1354
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1325
			//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertLoop(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1354
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1325
			//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1338
			//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertAsBlock(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 87
			//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2435
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_1B00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779263, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00ᰀ()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_0D00(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
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
					((Func<Task>)/*Error near IL_0044: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_0E00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779260, new IntPtr(2737367884924L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00ༀ()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_00a2: Expected Obj, but got I4
			//IL_00ac: Expected native int or pointer, but got Obj
			//IL_0051: Expected Obj, but got I4
			//IL_0220: Expected I4, but got Obj
			//IL_022c: Expected Obj, but got I4
			//IL_0236: Expected native int or pointer, but got Obj
			//IL_025f: Expected Obj, but got I4
			//IL_01f5: Expected Obj, but got I4
			//IL_01fa: Expected Obj, but got I4
			//IL_01fa: Expected Obj, but got Ref
			//IL_01e6: Expected Obj, but got Ref
			//IL_0194: Expected Obj, but got Ref
			//IL_0139: Expected native int or pointer, but got Obj
			//IL_0156: Expected Obj, but got VT
			//IL_0160: Expected native int or pointer, but got Obj
			//IL_01a3: Expected native int or pointer, but got Obj
			//IL_008f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00b6->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00d3->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0065->IL0026: Incompatible stack types: I4 vs Obj
			//IL_009a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00c1->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01f0->IL00e9: Incompatible stack heights: 2 vs 1
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 5;
			object obj = awaiter;
			while (true)
			{
				int num;
				switch ((int)obj)
				{
				case 1:
					return;
				case 5:
					awaiter = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state;
					obj = 4;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj = 4;
					}
					break;
				default:
					((AsyncTaskMethodBuilder*)/*Error near IL_007b: Stack underflow*/)->Start<TStateMachine>(ref Unsafe.As<TaskAwaiter, TStateMachine>(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Eu__1));
					obj = 0;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder != 0)
					{
						obj = 1;
					}
					break;
				case 3:
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this).listener = (TcpListener)(-2);
					obj = 0;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj = 0;
					}
					break;
				case 4:
					awaiter = Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler;
					obj = 2;
					break;
				case 2:
					{
						if (awaiter == null)
						{
							num = 6;
							goto IL_00e9;
						}
						goto IL_0219;
					}
					IL_0219:
					((ILogger)/*Error near IL_0220: Stack underflow*/).Debug<short>((string)/*Error near IL_0220: Stack underflow*/, (short)(int)awaiter);
					awaiter = ((TaskAwaiter<string>*)((FeverInstaller)/*Error near IL_0225: Stack underflow*/).InstallAsync())->IsCompleted;
					num = 8;
					if ((int)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)FeverInstaller._003CFeverRequest_003Ed__15<>.request)->_003C_003Eu__1 != 0)
					{
						num = 4;
					}
					goto IL_00e9;
					IL_00e9:
					while (true)
					{
						switch (num)
						{
						case 7:
							return;
						case 11:
							break;
						case 9:
							Unsafe.As<int, AsyncTaskMethodBuilder>(ref ((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003E1__state) = default;
							num = 0;
							if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9._003C_003E4__this)->client == null)
							{
								num = 0;
							}
							continue;
						case 6:
						case 10:
							awaiter = ((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003Eu__1;
							num = 5;
							if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain)->_003C_003E1__state != 0)
							{
								num = 9;
							}
							continue;
						case 5:
							Unsafe.As<AsyncTaskMethodBuilder, AsyncTaskMethodBuilder<EntityFeverManifestInfo>>(ref ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003Et__builder).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityFeverManifestInfo>*)(&awaiter), ref Unsafe.As<_003CHeartbeatAsync_003Ed__48, FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13>(ref this));
							num = 7;
							continue;
						case 8:
							if (((TcpListener)(&awaiter)).AcceptTcpClientAsync() == null)
							{
								num = 0;
								if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003Cstream_003E5__2)->_003C_003Eu__1 != 0)
								{
									num = 1;
								}
								continue;
							}
							goto case 4;
						case 2:
							Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway = awaiter;
							num = 5;
							if (((FeverInstaller)FeverInstaller._003CfeverVersion_003EP)._003CappId_003EP != null)
							{
								num = 1;
							}
							continue;
						case 4:
							((TcpClient)(&awaiter)).GetStream();
							_ = 11;
							continue;
						case 1:
							awaiter = 0;
							FeverInstaller.McBedrock__BackingField = 0;
							num = 2;
							if (FeverInstaller.ReflectVisualArgument == null)
							{
								num = 2;
							}
							continue;
						case 3:
							goto IL_0219;
						default:
							awaiter = -1;
							((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)this)._003C_003E1__state = -1;
							num = 4;
							continue;
						}
						break;
					}
					goto case 3;
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00ጀ()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00Ѐ(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
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
					((Func<Task>)/*Error near IL_0044: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00Ԁ()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0077: Expected Obj, but got Ref
			//IL_0081: Expected native int or pointer, but got Obj
			//IL_009f: Expected VT, but got I4
			//IL_00a9: Expected native int or pointer, but got Obj
			//IL_0050: Expected Obj, but got I4
			//IL_0062: Expected Obj, but got VT
			//IL_055e: Expected native int or pointer, but got Obj
			//IL_0535: Expected Obj, but got I4
			//IL_053a: Expected VT, but got I4
			//IL_0543: Expected Obj, but got I4
			//IL_0167: Expected Obj, but got Ref
			//IL_04ad: Expected I, but got Obj
			//IL_04ad: Expected Obj, but got Ref
			//IL_04bc: Expected Obj, but got I
			//IL_0179: Expected Obj, but got VT
			//IL_0183: Expected native int or pointer, but got Obj
			//IL_04d2: Expected Obj, but got Ref
			//IL_0511: Expected native int or pointer, but got Obj
			//IL_03ec: Expected Obj, but got I4
			//IL_03f1: Expected VT, but got I4
			//IL_03fb: Expected native int or pointer, but got Obj
			//IL_04eb: Expected Obj, but got Ref
			//IL_0320: Expected Obj, but got VT
			//IL_032a: Expected native int or pointer, but got Obj
			//IL_0125: Expected I4, but got Obj
			//IL_02ab: Expected Obj, but got I4
			//IL_02b0: Expected Obj, but got I4
			//IL_02b0: Expected Obj, but got Ref
			//IL_034d: Expected Obj, but got Ref
			//IL_034d: Expected Obj, but got Ref
			//IL_0205: Expected Obj, but got Ref
			//IL_024e: Expected Obj, but got I4
			//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0219: Expected Obj, but got I4
			//IL_021e: Expected VT, but got I4
			//IL_0228: Expected native int or pointer, but got Obj
			//IL_0285: Expected Obj, but got I4
			//IL_01f9: Expected I4, but got Obj
			//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00b3->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0096->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00be->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00d0->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_0530->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_0146->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_0151->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_0568->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_0171->IL00d4: Incompatible stack heights: 2 vs 1
			//IL_04c1->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_018d->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_04e4->IL00d4: Incompatible stack heights: 2 vs 1
			//IL_0405->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_0573->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_04cc->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_0198->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_0525->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_0410->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_0334->IL01c4: Incompatible stack types: I4 vs Obj
			//IL_01b5->IL01c4: Incompatible stack types: I4 vs Obj
			//IL_0504->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_04a5->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_033f->IL01c4: Incompatible stack types: I4 vs Obj
			//IL_01c0->IL01c4: Incompatible stack types: I4 vs Obj
			//IL_050f->IL00d4: Incompatible stack types: I4 vs Obj
			//IL_02ba->IL01c4: Incompatible stack types: I4 vs Obj
			//IL_0357->IL01c4: Incompatible stack types: I4 vs Obj
			//IL_026e->IL01c4: Incompatible stack heights: 2 vs 1
			//IL_02d0->IL01c4: Incompatible stack types: I4 vs Obj
			//IL_0232->IL01c4: Incompatible stack types: I4 vs Obj
			//IL_029b->IL01c4: Incompatible stack heights: 2 vs 1
			//IL_0214->IL01c4: Incompatible stack types: I4 vs Obj
			//IL_0279->IL01c4: Incompatible stack heights: 2 vs 1
			//IL_023d->IL01c4: Incompatible stack types: I4 vs Obj
			//IL_02a6->IL01c4: Incompatible stack heights: 2 vs 1
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				default:
					return;
				case 4:
					obj = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state;
					obj2 = 3;
					continue;
				case 5:
					obj = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Et__builder;
					obj2 = 4;
					continue;
				case 1:
					((TcpListener)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E4__this)).Start();
					obj2 = 0;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state != 0)
					{
						obj2 = 0;
					}
					continue;
				case 0:
					return;
				case 2:
					break;
				case 3:
					{
						if (obj == null)
						{
							obj3 = 2;
							goto IL_00d4;
						}
						goto IL_012a;
					}
					IL_012a:
					if ((nint)obj != 1)
					{
						obj3 = 0;
						if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler != null)
						{
							obj3 = 10;
						}
						goto IL_00d4;
					}
					goto IL_0525;
					IL_0525:
					obj3 = 16;
					goto IL_00d4;
					IL_00d4:
					while (true)
					{
						object obj4;
						switch ((int)obj3)
						{
						case 4:
							return;
						case 9:
							break;
						case 11:
							goto end_IL_00d4;
						default:
							((Task)(&obj)).GetAwaiter();
							_ = 14;
							continue;
						case 2:
						case 12:
							obj = ((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003Et__builder;
							obj3 = 1;
							if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9._003C_003E4__this)->client != null)
							{
								obj3 = 1;
							}
							continue;
						case 16:
							if ((nint)obj != 1)
							{
								obj4 = 11;
								if (Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain == null)
								{
									obj4 = 11;
								}
								goto IL_01c4;
							}
							goto IL_0318;
						case 15:
							obj = -1;
							((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003Eu__1 = (TaskAwaiter<EntityFeverManifestInfo>)(-1);
							obj3 = 5;
							if (((FeverInstaller._003CInstallAsync_003Ed__11*)(nint)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CheckScalableWorker)->_003C_003E1__state == 0)
							{
								obj3 = 5;
							}
							continue;
						case 7:
							_ = 30.0;
							/*Error near IL_044c: Member reference must be method, but was: Field*/;
						case 10:
						case 18:
							goto IL_048f;
						case 8:
							((Rpc)Unsafe.AsPointer(ref this)).NeedCha__BackingField = (nint)obj;
							obj3 = 13;
							if (((Rpc)Rpc.UseCha__BackingField).Callbacks__BackingField == null)
							{
								obj3 = 13;
							}
							continue;
						case 13:
							_ = ref ((Rpc)Unsafe.AsPointer(ref this)).Writer__BackingField;
							((AsyncTaskMethodBuilder*)(&obj))->Start(ref Unsafe.As<_003CHeartbeatCircleAsync_003Ed__38, JavaGame._003COnDataReceivedAsync_003Ed__12>(ref this));
							_ = 4;
							continue;
						case 17:
							((AsyncTaskMethodBuilder<_00210>*)/*Error near IL_04eb: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)(&obj));
							if ((int)/*Error near IL_04f0: Stack underflow*/ != 0)
							{
								obj3 = 0;
								if (Rpc.ParseMap == null)
								{
									obj3 = 0;
								}
								continue;
							}
							goto case 3;
						case 14:
							if (((Rpc._003CListenAsync_003Ed__34*)(nint)obj)->_003C_003E1__state != 0)
							{
								obj3 = 6;
								continue;
							}
							break;
						case 6:
							goto IL_0525;
						case 3:
							obj = 0;
							((Rpc._003CListenAsync_003Ed__34)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)0;
							obj = 8;
							obj3 = obj;
							continue;
						case 1:
							{
								((Rpc._003CListenAsync_003Ed__34)this)._003C_003E4__this = null;
								obj3 = 14;
								if (((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)Rpc._003CListenAsync_003Ed__34.DecorateIterableWriter)->_003C_003E1__state == 0)
								{
									obj3 = 15;
								}
								continue;
							}
							IL_0318:
							obj = ((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)this)._003C_003Et__builder;
							obj4 = 4;
							if ((int)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E4__this)->_003C_003Eu__1 != 0)
							{
								obj4 = 9;
							}
							goto IL_01c4;
							IL_01c4:
							while (true)
							{
								switch ((int)obj4)
								{
								case 8:
									return;
								case 4:
									((IAsyncStateMachine)/*Error near IL_0205: Stack underflow*/).SetStateMachine((IAsyncStateMachine)(&obj));
									if ((int)/*Error near IL_020a: Stack underflow*/ != 0)
									{
										obj4 = 2;
										continue;
									}
									goto default;
								case 10:
									obj = -1;
									((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-1);
									obj4 = 7;
									if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.client)->_003C_003E4__this == null)
									{
										obj4 = 7;
									}
									continue;
								case 5:
									((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003Cstream_003E5__2 = obj;
									obj = 3;
									obj4 = obj;
									continue;
								case 2:
								case 7:
									((TaskAwaiter<TcpClient>*)(&obj))->GetResult();
									_ = 6;
									if (((FeverInstaller)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway)._003CfeverVersion_003EP == null)
									{
										_ = 4;
									}
									continue;
								case 11:
									obj = ((TcpClient)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.DecorateFlexibleProfiler()).GetStream();
									_ = 4;
									if (((FeverInstaller)FeverInstaller.McBedrock__BackingField).Client__BackingField == null)
									{
										_ = 0;
									}
									continue;
								default:
									obj = 1;
									FeverInstaller.ReflectVisualArgument = 1;
									obj4 = 5;
									continue;
								case 9:
									((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003E1__state = (int)default(ConfigureSerialization);
									obj4 = 10;
									continue;
								case 1:
									break;
								case 3:
									Unsafe.As<object, ILogger>(ref FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor).Error<Type>((string)(&obj), (Type)Unsafe.AsPointer(ref this));
									obj4 = 8;
									continue;
								case 6:
									goto IL_048f;
								}
								break;
							}
							goto IL_0318;
							IL_048f:
							if (((Rpc)obj).Logger__BackingField == null)
							{
								obj3 = 9;
								continue;
							}
							goto case 7;
						}
						goto end_IL_0026;
						continue;
						end_IL_00d4:
						break;
					}
					goto IL_012a;
					end_IL_0026:
					break;
				}
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-2);
				obj2 = 1;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
				{
					obj2 = 0;
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_0B00()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00切(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
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
					((Func<Task>)/*Error near IL_0044: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00ﴀ()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FE00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779250, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_FF00()
		{
			// ILSpy could not decompile this. Please report the exception below,
			// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
			// System.ArgumentNullException: Value cannot be null. (Parameter 'source')
			//    at System.Linq.ThrowHelper.ThrowArgumentNullException(ExceptionArgument argument)
			//    at System.Linq.Enumerable.Skip[TSource](IEnumerable`1 source, Int32 count)
			//    at ICSharpCode.Decompiler.CSharp.ArgumentList.GetArgumentResolveResultsDirect(Int32 skipCount) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 124
			//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Probe() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 493
			//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Run() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 438
			//    at ICSharpCode.Decompiler.CSharp.Disambiguator.ForMethodReference(ExpressionBuilder expressionBuilder, IMethod method, IType targetType, TranslatedExpression target, Boolean requireTarget, ExpectedTargetDetails expectedTargetDetails, Boolean isExtensionMethodReference, Boolean castTargetUpFront) in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 131
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.DisambiguateDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1718
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1648
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildMethodReference(IMethod method, Boolean isVirtual) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1639
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitLdFtn(LdFtn inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 5058
			//    at ICSharpCode.Decompiler.IL.LdFtn.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 3175
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitConv(Conv inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2307
			//    at ICSharpCode.Decompiler.IL.Conv.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2298
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildArgumentList(ExpectedTargetDetails expectedTargetDetails, ResolveResult target, IMethod method, Int32 firstParamIndex, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, Boolean writtenAsAssignment) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1070
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(OpCode callOpCode, IMethod method, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, IType constrainedTo) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 461
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(CallInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 255
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitNewObj(NewObj inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 538
			//    at ICSharpCode.Decompiler.IL.NewObj.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4578
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitConv(Conv inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2307
			//    at ICSharpCode.Decompiler.IL.Conv.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2298
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildArgumentList(ExpectedTargetDetails expectedTargetDetails, ResolveResult target, IMethod method, Int32 firstParamIndex, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, Boolean writtenAsAssignment) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1070
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(OpCode callOpCode, IMethod method, IReadOnlyList`1 callArguments, IReadOnlyList`1 argumentToParameterMap, IType constrainedTo) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 461
			//    at ICSharpCode.Decompiler.CSharp.CallBuilder.Build(CallInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 255
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitCall(Call inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2530
			//    at ICSharpCode.Decompiler.IL.Call.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2192
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Default(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 93
			//    at ICSharpCode.Decompiler.IL.ILVisitor`1.VisitCall(Call inst) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 7663
			//    at ICSharpCode.Decompiler.IL.Call.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2188
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
			//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertSwitchSectionBody(SwitchSection astSection, ILInstruction bodyInst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 334
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.TranslateSwitch(BlockContainer switchContainer, SwitchInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 280
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1334
			//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertLoop(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1354
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1325
			//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.TranslateSwitch(BlockContainer switchContainer, SwitchInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 307
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1334
			//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertLoop(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1354
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1325
			//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1338
			//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertAsBlock(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 87
			//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2435
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00Ā()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779249, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00Ȁ()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_F000(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0045: Expected I, but got Obj
			//IL_0045: Expected Obj, but got Ref
			//IL_004f: Expected native int or pointer, but got Obj
			//IL_0059->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
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
				case 0:
					return;
				case 1:
					((Func<Task>)/*Error near IL_0045: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
					{
						obj2 = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_F100()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0050: Expected Obj, but got I4
			//IL_0077: Expected Obj, but got VT
			//IL_0081: Expected native int or pointer, but got Obj
			//IL_05e0: Expected Obj, but got Ref
			//IL_05ea: Expected native int or pointer, but got Obj
			//IL_05cb: Expected Obj, but got I4
			//IL_00de: Expected native int or pointer, but got Obj
			//IL_0297: Expected Obj, but got Ref
			//IL_0297: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Expected Obj, but got I4
			//IL_015d: Expected Obj, but got I4
			//IL_01c7: Expected Obj, but got I4
			//IL_0210: Expected VT, but got Obj
			//IL_016f: Expected Obj, but got I4
			//IL_02c1: Expected Obj, but got I4
			//IL_02c6: Expected Obj, but got I4
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_05f4->IL0026: Incompatible stack types: I4 vs Obj
			//IL_05d5->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0096->IL0026: Incompatible stack types: I4 vs Obj
			//IL_05ff->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01e4->IL0109: Incompatible stack heights: 2 vs 1
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 3;
			object obj = awaiter;
			while (true)
			{
				switch ((int)obj)
				{
				case 2:
					awaiter = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state;
					obj = 0;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj = 0;
					}
					break;
				case 3:
					awaiter = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Eu__1;
					obj = 2;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state == 0)
					{
						obj = 2;
					}
					break;
				default:
				{
					int num = 1;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener == null)
					{
						num = 0;
					}
					while (true)
					{
						int num2;
						switch (num)
						{
						case 1:
							num = 0;
							if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E4__this)->_003C_003Eu__1 == 0)
							{
								num = 0;
							}
							continue;
						default:
							if (awaiter == null)
							{
								num2 = 12;
								goto IL_0109;
							}
							goto IL_025d;
						case 2:
							break;
							IL_025d:
							if (((FeverInstaller)awaiter).Client__BackingField == null)
							{
								num2 = 13;
								goto IL_0109;
							}
							goto IL_018e;
							IL_0109:
							while (true)
							{
								switch (num2)
								{
								case 5:
									awaiter = 0;
									Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler = 0;
									num2 = 8;
									continue;
								case 11:
								case 12:
									awaiter = ((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003E1__state;
									num2 = 1;
									if (((Authenticator._003CReceiveAsync_003Ed__9)Authenticator._003CReceiveAsync_003Ed__9._003C_003Et__builder)._003C_003E4__this != null)
									{
										num2 = 0;
									}
									continue;
								case 15:
									break;
								case 7:
								{
									object obj2 = awaiter;
									((AsyncTaskMethodBuilder*)awaiter)->SetStateMachine((IAsyncStateMachine)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateGenericStruct());
									awaiter = obj2;
									num2 = 2;
									continue;
								}
								case 4:
								case 9:
									_ = ((TaskAwaiter<TcpClient>*)(&awaiter))->IsCompleted;
									_ = 10;
									continue;
								case 8:
									((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003Eu__1 = (TaskAwaiter<string>)awaiter;
									num2 = 3;
									continue;
								case 3:
									Unsafe.As<object, AsyncTaskMethodBuilder>(ref Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityFeverManifest>*)(&awaiter), ref Unsafe.As<_003CReceiveAsync_003Ed__39, FeverInstaller._003CInstallAsync_003Ed__11>(ref this));
									num2 = 6;
									continue;
								case 2:
									if (((Encoding)/*Error near IL_0239: Stack underflow*/).GetString((byte[])/*Error near IL_0239: Stack underflow*/, (int)/*Error near IL_0239: Stack underflow*/, (int)(&awaiter)) != null)
									{
										num2 = 4;
										if (FeverInstaller.McBedrock__BackingField != null)
										{
											num2 = 1;
										}
										continue;
									}
									goto case 5;
								default:
									goto IL_025d;
								case 6:
									return;
								case 1:
									FeverInstaller.ReflectVisualArgument = (object)default(ConfigureHeaders);
									num2 = 12;
									if (((FeverInstaller._003CFeverRequest_003Ed__15<>)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003Et__builder)._003C_003E4__this == null)
									{
										num2 = 14;
									}
									continue;
								case 14:
									awaiter = -1;
									((FeverInstaller._003CFeverRequest_003Ed__15<>)this).request = (RestRequest)(object)(-1);
									num2 = 9;
									if (((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003Eu__1)._003C_003E1__state != 0)
									{
										num2 = 4;
									}
									continue;
								case 13:
									goto end_IL_00bd;
								}
								break;
							}
							goto IL_018e;
							IL_018e:
							awaiter = new GC[4096];
							num2 = 0;
							if (Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain != null)
							{
								num2 = 7;
							}
							goto IL_0109;
							end_IL_00bd:
							break;
						}
						break;
					}
					goto case 5;
				}
				case 1:
					return;
				case 5:
					Rpc._003CListenAsync_003Ed__34.DecorateIterableWriter = -2;
					obj = 4;
					break;
				case 4:
					((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)/*Error near IL_05e0: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)Unsafe.AsPointer(ref ((Rpc._003CListenControlConnectAsync_003Ed__35)this)._003C_003E1__state));
					obj = 1;
					if (((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)Rpc._003CListenControlConnectAsync_003Ed__35.listener)->_003C_003E4__this != null)
					{
						obj = 1;
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_F800()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_E800(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
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
					((Func<Task>)/*Error near IL_0044: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_E900(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779243, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_EA00()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0050: Expected Obj, but got I4
			//IL_00b3: Expected Obj, but got Ref
			//IL_0077: Expected VT, but got I4
			//IL_018f: Expected native int or pointer, but got Obj
			//IL_0163: Expected native int or pointer, but got Obj
			//IL_0176: Expected Obj, but got VT
			//IL_0183: Expected Obj, but got I4
			//IL_01a3: Expected native int or pointer, but got Obj
			//IL_0305: Expected native int or pointer, but got Obj
			//IL_02e5: Expected I4, but got Obj
			//IL_0249: Expected I4, but got Obj
			//IL_0249: Expected I4, but got Obj
			//IL_024b: Expected Obj, but got I4
			//IL_025d: Expected Obj, but got VT
			//IL_0267: Expected native int or pointer, but got Obj
			//IL_0223: Expected Obj, but got Ref
			//IL_0290: Expected Obj, but got I4
			//IL_0295: Expected VT, but got I4
			//IL_0212: Expected Obj, but got Ref
			//IL_01f9: Expected Obj, but got Ref
			//IL_0201: Expected Obj, but got Ref
			//IL_0201: Expected Obj, but got Ref
			//IL_02b9: Expected Obj, but got I4
			//IL_02be: Expected Obj, but got I4
			//IL_009d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00c7->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0081->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00a8->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00d2->IL0026: Incompatible stack types: I4 vs Obj
			//IL_018d->IL00e8: Incompatible stack heights: 5 vs 1
			//IL_0255->IL00e8: Incompatible stack heights: 2 vs 1
			//IL_021c->IL00e8: Incompatible stack heights: 2 vs 1
			//IL_020b->IL00e8: Incompatible stack heights: 3 vs 1
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				case 1:
					obj = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state;
					obj2 = 0;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 0;
					}
					break;
				case 5:
					((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Eu__1 = (TaskAwaiter)(-2);
					obj2 = 3;
					break;
				default:
					obj = Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton;
					obj2 = 2;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder != 0)
					{
						obj2 = 1;
					}
					break;
				case 3:
					((TcpListener)Unsafe.AsPointer(ref ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this).listener)).Dispose();
					obj2 = 4;
					if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler != null)
					{
						obj2 = 2;
					}
					break;
				case 2:
					if (obj == null)
					{
						num = 4;
						goto IL_00e8;
					}
					goto IL_018d;
				case 4:
					return;
					IL_018d:
					if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)obj)->_003C_003Et__builder == 0)
					{
						num = 9;
						if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.client)->_003C_003E4__this == null)
						{
							num = 7;
						}
						goto IL_00e8;
					}
					goto IL_0161;
					IL_0161:
					_ = ((Authenticator._003CReceiveAsync_003Ed__9*)(nint)obj)->_003C_003E4__this;
					_ = ((Authenticator._003CReceiveAsync_003Ed__9)this).client;
					_ = 0;
					_ = ((Array)((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003Eu__1).Length;
					((IAsyncStateMachine)Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain).SetStateMachine((IAsyncStateMachine)0);
					_ = 3;
					goto IL_00e8;
					IL_00e8:
					while (true)
					{
						switch (num)
						{
						case 6:
							break;
						case 3:
						case 9:
							((AsyncTaskMethodBuilder*)/*Error near IL_0155: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003E1__state, ref *(TStateMachine*)null);
							obj = (object)/*Error near IL_0157: Stack underflow*/;
							num = 7;
							continue;
						case 14:
							goto IL_0161;
						case 17:
							goto IL_018d;
						case 7:
							((AsyncTaskMethodBuilder*)/*Error near IL_01d3: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityFeverAppVersion>*)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003Cstream_003E5__2, ref *(FeverInstaller._003CInstallAsync_003Ed__11*)2);
							((AsyncTaskMethodBuilder*)/*Error near IL_01d8: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityFeverManifestInfo>*)/*Error near IL_01d8: Stack underflow*/, ref *(FeverInstaller._003CInstallAsync_003Ed__11*)/*Error near IL_01d8: Stack underflow*/);
							obj = (object)/*Error near IL_01da: Stack underflow*/;
							num = 5;
							continue;
						case 11:
							return;
						case 15:
							_ = ref ((FeverInstaller)Unsafe.AsPointer(ref this))._003CfeverVersion_003EP;
							((IEnumerable<byte>)(&obj)).Concat((IEnumerable<byte>)Unsafe.AsPointer(ref this));
							_ = 11;
							continue;
						case 2:
						case 13:
							((TcpClient)(&obj)).GetStream();
							_ = 6;
							continue;
						case 10:
							if ((int)((Task<string>)(&obj)).GetAwaiter() != 0)
							{
								num = 2;
								continue;
							}
							goto case 16;
						case 5:
							obj = ((Stream)obj).Read((byte[])obj, (int)obj, (int)new FeverInstaller().Client);
							_ = 10;
							continue;
						case 4:
						case 8:
							obj = ((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003Et__builder;
							num = 0;
							if (((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003E4__this)->request == null)
							{
								num = 0;
							}
							continue;
						case 12:
							obj = -1;
							((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003Eu__1 = (TaskAwaiter<RestResponse<EntityFeverResponse<T>>>)(-1);
							num = 12;
							if ((int)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								num = 13;
							}
							continue;
						case 16:
							obj = 0;
							((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)this)._003C_003E4__this = (FeverInstaller)0;
							num = 1;
							if (FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor == null)
							{
								num = 1;
							}
							continue;
						case 1:
							((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003E1__state = (int)obj;
							num = 15;
							continue;
						default:
							Unsafe.As<AsyncTaskMethodBuilder<EntityFeverManifest>, @null>(ref ((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003Et__builder) = null;
							num = 12;
							if ((int)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12.info)->_003C_003Eu__1 == 0)
							{
								num = 3;
							}
							continue;
						}
						break;
					}
					goto case 5;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_ED00()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_E100(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
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
					((Func<Task>)/*Error near IL_0044: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_E200()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_05f7: Expected Obj, but got I4
			//IL_005e: Expected native int or pointer, but got Obj
			//IL_062e: Expected Obj, but got Ref
			//IL_063f: Expected Obj, but got I
			//IL_023c: Expected Obj, but got Ref
			//IL_030e: Expected native int or pointer, but got Obj
			//IL_0255: Invalid comparison between VT and I4
			//IL_043d: Expected Obj, but got I4
			//IL_0442: Expected Obj, but got Ref
			//IL_0182: Expected Obj, but got Ref
			//IL_0193: Expected native int or pointer, but got Obj
			//IL_01a9: Expected Ref, but got VT
			//IL_01a9: Expected Ref, but got VT
			//IL_01b5: Expected native int or pointer, but got Obj
			//IL_0296: Expected I4, but got Obj
			//IL_0325: Expected native int or pointer, but got Obj
			//IL_0342: Expected native int or pointer, but got Obj
			//IL_03a9: Expected native int or pointer, but got Obj
			//IL_04c0: Expected native int or pointer, but got Obj
			//IL_04fa: Expected native int or pointer, but got Obj
			//IL_0359: Expected native int or pointer, but got Obj
			//IL_0363: Expected Ref, but got VT
			//IL_03e4: Expected VT, but got Obj
			//IL_01fb: Expected native int or pointer, but got Obj
			//IL_020c: Expected Obj, but got I4
			//IL_0212: Expected Obj, but got I4
			//IL_0212: Expected native int or pointer, but got Obj
			//IL_0144: Expected Obj, but got I4
			//IL_0414: Expected Obj, but got I4
			//IL_0419: Expected Obj, but got Ref
			//IL_01e9: Expected Obj, but got Ref
			//IL_0514: Expected Obj, but got I4
			//IL_0519: Expected Obj, but got I4
			//IL_0468: Expected Obj, but got Ref
			//IL_01d8: Expected VT, but got Ref
			//IL_01d8: Expected Obj, but got Ref
			//IL_01d8: Expected Obj, but got Ref
			//IL_02b4: Expected native int or pointer, but got Obj
			//IL_0485: Expected Obj, but got Ref
			//IL_048c: Expected I4, but got Obj
			//IL_048c: Expected I4, but got Obj
			//IL_0601->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0644->IL0026: Incompatible stack types: I4 vs Obj
			//IL_061d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0073->IL0026: Incompatible stack types: I4 vs Obj
			//IL_064f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0628->IL0026: Incompatible stack types: I4 vs Obj
			//IL_034c->IL0089: Incompatible stack heights: 5 vs 1
			//IL_022b->IL0089: Incompatible stack heights: 4 vs 1
			//IL_03a7->IL0089: Incompatible stack heights: 2 vs 1
			//IL_01e2->IL0089: Incompatible stack heights: 2 vs 1
			//IL_0357->IL0089: Incompatible stack heights: 5 vs 1
			//IL_0236->IL0089: Incompatible stack heights: 4 vs 1
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object stateMachine = 5;
			object obj = stateMachine;
			while (true)
			{
				int num;
				switch ((int)obj)
				{
				default:
					return;
				case 0:
					return;
				case 3:
					((Func<Task>)/*Error near IL_0054: Stack underflow*/)._002Ector((object)/*Error near IL_0054: Stack underflow*/, (nint)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state));
					obj = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
					{
						obj = 0;
					}
					break;
				case 1:
					if (stateMachine == null)
					{
						num = 16;
						goto IL_0089;
					}
					goto IL_02fc;
				case 2:
					goto IL_05ef;
				case 5:
					stateMachine = ((Rpc._003CSyncChaChaAsync_003Ed__38)this).callBack;
					obj = 4;
					if (((CppGameValue)Rpc._003CSyncChaChaAsync_003Ed__38.RateStack).SkinPath__BackingField == null)
					{
						obj = 4;
					}
					break;
				case 4:
					{
						stateMachine = CppGameValue.DecorateAlphabeticList;
						obj = 1;
						if (GameValue.CheckSimpleMapper == null)
						{
							obj = 0;
						}
						break;
					}
					IL_0236:
					stateMachine = ((FeverInstaller)Unsafe.AsPointer(ref this))._003CappId_003EP;
					num = 10;
					goto IL_0089;
					IL_0089:
					while (true)
					{
						switch (num)
						{
						case 11:
							return;
						case 33:
							return;
						case 2:
						case 4:
							((AsyncTaskMethodBuilder*)/*Error near IL_0122: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)(&stateMachine));
							stateMachine = (object)/*Error near IL_0124: Stack underflow*/;
							num = 30;
							continue;
						case 30:
							if (stateMachine != null)
							{
								num = 25;
								continue;
							}
							goto case 31;
						case 20:
							stateMachine = 1;
							((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003E1__state = 1;
							num = 12;
							if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener == null)
							{
								num = 12;
							}
							continue;
						case 3:
							((TcpListener)(&stateMachine)).Dispose();
							if ((int)/*Error near IL_0187: Stack underflow*/ != 0)
							{
								num = 4;
								continue;
							}
							goto case 1;
						case 5:
							((AsyncTaskMethodBuilder*)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)stateMachine)->_003C_003Eu__1)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)2, ref *(TStateMachine*)((Task)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler).GetAwaiter());
							stateMachine = (object)/*Error near IL_01ab: Stack underflow*/;
							num = 3;
							if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9._003C_003E4__this)->client == null)
							{
								num = 6;
							}
							continue;
						case 27:
							RestClientExtensions.ExecuteAsync<EntityFeverManifest>((IRestClient)(object)Unsafe.AsPointer(ref ((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003Eu__1), (RestRequest)(object)(&stateMachine), (CancellationToken)Unsafe.AsPointer(ref this));
							_ = 33;
							continue;
						case 22:
							((IAsyncStateMachine)/*Error near IL_01e9: Stack underflow*/).SetStateMachine((IAsyncStateMachine)(&stateMachine));
							if ((int)/*Error near IL_01ee: Stack underflow*/ != 0)
							{
								num = 14;
								continue;
							}
							goto case 20;
						case 19:
							_ = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)stateMachine)->_003C_003Et__builder;
							_ = 0;
							Unsafe.Write(&((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)((TcpListener)((TaskAwaiter<TcpClient>*)2)->IsCompleted).AcceptTcpClientAsync())->_003C_003Eu__1, (TaskAwaiter<string>)((Task<TcpClient>)0).GetAwaiter());
							_ = 7;
							if (((FeverInstaller)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway)._003CfeverVersion_003EP != null)
							{
								_ = 17;
							}
							continue;
						case 29:
							break;
						default:
							if (((Task<string>)((FeverInstaller)stateMachine)._003CappVersion_003EP).GetAwaiter() < (object)2)
							{
								num = 7;
								continue;
							}
							goto case 19;
						case 6:
						{
							object obj2 = stateMachine;
							((FeverInstaller)stateMachine).Dispose();
							((Stream)/*Error near IL_0296: Stack underflow*/).Write((byte[])/*Error near IL_0296: Stack underflow*/, (int)/*Error near IL_0296: Stack underflow*/, (int)obj2);
							stateMachine = (object)/*Error near IL_0298: Stack underflow*/;
							num = 22;
							continue;
						}
						case 16:
						case 32:
							stateMachine = ((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003E4__this;
							num = 13;
							if ((int)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)FeverInstaller._003CFeverRequest_003Ed__15<>.request)->_003C_003Eu__1 == 0)
							{
								num = 4;
							}
							continue;
						case 28:
							goto IL_02fc;
						case 8:
							_ = FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor;
							_ = 0;
							_ = 2 + ((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003E1__state;
							AsyncTaskMethodBuilder<EntityFeverManifestInfo>.Create();
							_ = 0;
							if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003E4__this)->info == null)
							{
								_ = 0;
							}
							continue;
						case 17:
							if ((nint)((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)stateMachine)->_003C_003Eu__1)->Task >= 2 + ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003E1__state)
							{
								num = 4;
								if (((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13._003C_003Et__builder)._003C_003E4__this != null)
								{
									num = 5;
								}
								continue;
							}
							goto IL_05ef;
						case 26:
							_ = ref ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this).version;
							((AsyncTaskMethodBuilder<string>*)(&stateMachine))->Start(ref Unsafe.As<_003CReceiveDataAsync_003Ed__41, JavaAuthenticator._003CHandleAuthentication_003Ed__9>(ref this));
							_ = 11;
							continue;
						case 9:
							((AsyncTaskMethodBuilder<_0021_00210>*)/*Error near IL_03b3: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.CheckScalableWorker);
							_ = ((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003Et__builder;
							_ = 0;
							_ = ((Array)(object)((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003E4__this).Length;
							/*Error near IL_03c2: Member reference must be method, but was: Field*/;
						case 18:
							((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003Eu__3 = (TaskAwaiter<EntityFeverManifest>)stateMachine;
							num = 27;
							continue;
						case 12:
							FeverInstaller._003CInstallAsync_003Ed__11.ReflectAccessibleWatcher = stateMachine;
							num = 26;
							continue;
						case 21:
							stateMachine = -1;
							((Rpc)Unsafe.AsPointer(ref this)).ProcessId__BackingField = -1;
							num = 2;
							if (((Rpc)Rpc.Logger__BackingField).NeedCha__BackingField != 0)
							{
								num = 2;
							}
							continue;
						case 1:
							stateMachine = 0;
							((Rpc)Unsafe.AsPointer(ref this)).UseCha__BackingField = 0;
							num = 18;
							if (((Rpc)(object)Rpc.Callbacks__BackingField).Writer__BackingField != null)
							{
								num = 18;
							}
							continue;
						case 14:
						case 24:
							((AsyncTaskMethodBuilder<_00210>*)/*Error near IL_0468: Stack underflow*/)->SetException((Exception)(&stateMachine));
							num = 8;
							continue;
						case 31:
							throw new AsyncTaskMethodBuilder<_00210>((IAsyncStateMachine)/*Error near IL_0477: Stack underflow*/);
						case 25:
							((ILogger)/*Error near IL_048c: Stack underflow*/).Debug<int, int>((string)((Rpc)stateMachine)._chaChaDe, (int)Rpc.ParseMap, (int)stateMachine);
							((RestRequest)/*Error near IL_0491: Stack underflow*/)._002Ector((string)/*Error near IL_0491: Stack underflow*/, (Method)/*Error near IL_0491: Stack underflow*/);
							num = 15;
							continue;
						case 10:
							((Rpc._003CListenAsync_003Ed__34)this)._003C_003E4__this = null;
							num = 13;
							if (((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)Rpc._003CListenAsync_003Ed__34.DecorateIterableWriter)->_003C_003E1__state != 0)
							{
								num = 23;
							}
							continue;
						case 13:
							Unsafe.As<AsyncTaskMethodBuilder, KeyValuePair<string, string>>(ref ((Rpc._003CListenControlConnectAsync_003Ed__35)this)._003C_003Et__builder) = default;
							num = 21;
							if ((int)((Rpc._003CListenControlConnectAsync_003Ed__35*)(nint)Rpc._003CListenControlConnectAsync_003Ed__35._003C_003E4__this)->_003C_003Eu__1 != 0)
							{
								num = 11;
							}
							continue;
						case 23:
							stateMachine = -1;
							Rpc._003CListenControlConnectAsync_003Ed__35.ReflectSymbolicDecorator = -1;
							num = 18;
							if ((int)((Rpc._003CReceiveAsync_003Ed__28*)Rpc._003CReceiveAsync_003Ed__28._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								num = 24;
							}
							continue;
						case 7:
							goto IL_05ef;
						}
						break;
					}
					goto IL_0236;
					IL_02fc:
					if ((nint)stateMachine != 1)
					{
						num = 9;
						if ((int)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E4__this)->_003C_003Eu__1 == 0)
						{
							num = 4;
						}
						goto IL_0089;
					}
					goto IL_0236;
					IL_05ef:
					((Rpc._003CSyncChaChaAsync_003Ed__38)this)._003C_003E4__this = (Rpc)(-2);
					obj = 3;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_E500()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00혀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
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
					((Func<Task>)/*Error near IL_0044: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00휀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_045e: Expected Obj, but got Ref
			//IL_0463: Expected Obj, but got Ref
			//IL_0051: Expected Obj, but got I4
			//IL_048a: Expected Obj, but got I4
			//IL_0493: Expected Obj, but got I4
			//IL_0063: Expected VT, but got I4
			//IL_006d: Expected native int or pointer, but got Obj
			//IL_0163: Expected Obj, but got I4
			//IL_00c4: Expected native int or pointer, but got Obj
			//IL_00d4: Expected Obj, but got I4
			//IL_00e5: Expected native int or pointer, but got Obj
			//IL_010b: Expected native int or pointer, but got Obj
			//IL_0247: Expected Obj, but got I4
			//IL_024c: Expected VT, but got I4
			//IL_0214: Expected Obj, but got Ref
			//IL_031d: Expected Obj, but got I4
			//IL_02a6: Expected Ref, but got VT
			//IL_02ad: Expected Obj, but got VT
			//IL_02b6: Expected Obj, but got I4
			//IL_0207: Expected I4, but got Obj
			//IL_0477->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0077->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0482->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0082->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01a2->IL0098: Incompatible stack heights: 3 vs 1
			//IL_0098->IL0098: Incompatible stack heights: 2 vs 1
			//IL_02de->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_01ce->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_01ad->IL0098: Incompatible stack heights: 3 vs 1
			//IL_02cc->IL01d2: Incompatible stack heights: 3 vs 1
			//IL_0256->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_026e->IL01d2: Incompatible stack heights: 2 vs 1
			//IL_021e->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_0336->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_028e->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_02fe->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_0341->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_0299->IL01d2: Incompatible stack types: I4 vs Obj
			//IL_0309->IL01d2: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object stateMachine = 4;
			while (true)
			{
				object obj = stateMachine;
				while (true)
				{
					int num;
					switch ((int)obj)
					{
					default:
						return;
					case 0:
						return;
					case 3:
						stateMachine = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state;
						obj = 2;
						continue;
					case 5:
						((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)(-2);
						obj = 1;
						if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
						{
							obj = 1;
						}
						continue;
					case 2:
						if (stateMachine != null)
						{
							num = 5;
							goto IL_0098;
						}
						goto IL_0120;
					case 1:
						((AsyncTaskMethodBuilder<_00210>*)/*Error near IL_0463: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)Unsafe.AsPointer(ref ((Rpc)Unsafe.AsPointer(ref this)).Listener__BackingField));
						obj = 0;
						if (Rpc.ParseMap == null)
						{
							obj = 0;
						}
						continue;
					case 4:
						break;
						IL_0098:
						while (true)
						{
							object obj2;
							switch (num)
							{
							case 2:
							case 4:
								break;
							case 5:
								((AsyncTaskMethodBuilder<EntityFeverManifest>*)/*Error near IL_00d9: Stack underflow*/)->Start(ref *(FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)((Authenticator)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton).ReceiveAuthenticationDataAsync((object)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003E1__state));
								stateMachine = (object)/*Error near IL_00db: Stack underflow*/;
								num = 3;
								if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E4__this)->_003C_003Eu__1 != 0)
								{
									num = 0;
								}
								continue;
							case 3:
								if (stateMachine == null)
								{
									num = 0;
									if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state == 0)
									{
										num = 0;
									}
									continue;
								}
								goto case 7;
							case 1:
								goto IL_0120;
							default:
								((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CReceiveAsync_003Ed__9.client)->MoveNext();
								((RestResponse<EntityFeverManifest>)/*Error near IL_015a: Stack underflow*/).EnsureSuccessStatusCode<EntityFeverManifest>((string?)Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain, Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateGenericStruct());
								stateMachine = 2;
								continue;
							case 7:
								((Authenticator._003CReceiveAsync_003Ed__9*)/*Error near IL_0172: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.client);
								_ = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003Cstream_003E5__2;
								((IEnumerable<byte>)Authenticator._003CReceiveAsync_003Ed__9.DecorateConvertibleParameter()).Concat(((Encoding)stateMachine).GetBytes((string)(object)Encoding.UTF8));
								_ = 1;
								if (FeverInstaller.McBedrock__BackingField == null)
								{
									_ = 1;
								}
								continue;
							case 6:
								{
									if (stateMachine != null)
									{
										obj2 = 8;
										goto IL_01d2;
									}
									goto IL_02cc;
								}
								IL_02cc:
								stateMachine = ((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003E4__this;
								obj2 = 11;
								goto IL_01d2;
								IL_01d2:
								while (true)
								{
									switch ((int)obj2)
									{
									case 10:
										return;
									case 6:
										break;
									case 5:
										((FeverInstaller)Unsafe.AsPointer(ref this)).Client__BackingField = stateMachine;
										obj2 = 3;
										continue;
									case 2:
										stateMachine = 0;
										((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003Et__builder = (AsyncTaskMethodBuilder<T>)0;
										obj2 = 5;
										continue;
									case 3:
										_ = ref ((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003E4__this;
										((AsyncTaskMethodBuilder*)(&stateMachine))->Start(ref Unsafe.As<_003CRemoteCallBackAsync_003Ed__43, Rpc._003CListenAsync_003Ed__34>(ref this));
										_ = 10;
										continue;
									case 11:
										Unsafe.As<TaskAwaiter<RestResponse<EntityFeverResponse<T>>>, CancellationToken>(ref ((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003Eu__1) = default;
										obj2 = 7;
										if (((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003Et__builder)._003C_003E4__this != null)
										{
											obj2 = 0;
										}
										continue;
									case 8:
										((AsyncTaskMethodBuilder<EntityFeverManifest>*)stateMachine)->Start<TStateMachine>(ref *(TStateMachine*)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)this)._003C_003Eu__1);
										stateMachine = AsyncTaskMethodBuilder<EntityFeverManifest>.Create();
										stateMachine = 4;
										obj2 = stateMachine;
										continue;
									default:
										_ = ref stateMachine;
										AsyncTaskMethodBuilder<EntityFeverManifestInfo>.Create();
										_ = 6;
										continue;
									case 9:
										goto IL_02cc;
									case 4:
										((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)/*Error near IL_02e5: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)(&stateMachine));
										if ((int)/*Error near IL_02ea: Stack underflow*/ != 0)
										{
											obj2 = 0;
											if (FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReflectReporter != null)
											{
												obj2 = 0;
											}
											continue;
										}
										goto case 2;
									case 7:
										stateMachine = -1;
										((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003E1__state = -1;
										obj2 = 1;
										if (((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13._003C_003Et__builder)._003C_003E4__this == null)
										{
											obj2 = 0;
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
						IL_0120:
						num = 6;
						if (((Authenticator._003CReceiveAsync_003Ed__9)Authenticator._003CReceiveAsync_003Ed__9._003C_003Et__builder)._003C_003E4__this == null)
						{
							num = 6;
						}
						goto IL_0098;
					}
					break;
				}
				stateMachine = ((Rpc._003CListenAsync_003Ed__34)this)._003C_003E1__state;
				stateMachine = 3;
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00찀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
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
					((Func<Task>)/*Error near IL_0044: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00케()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00턀()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_0050: Expected Obj, but got I4
			//IL_0078: Expected VT, but got I4
			//IL_02e0: Expected native int or pointer, but got Obj
			//IL_026c: Expected Obj, but got Ref
			//IL_02f4: Expected native int or pointer, but got Obj
			//IL_01c5: Expected Obj, but got I4
			//IL_01f9: Expected Obj, but got I4
			//IL_0231: Expected Obj, but got Ref
			//IL_0224: Expected Obj, but got I4
			//IL_01ae: Expected Obj, but got I4
			//IL_01b3: Expected Obj, but got I4
			//IL_0166: Expected Obj, but got Ref
			//IL_013b: Expected Obj, but got I4
			//IL_0140: Expected Obj, but got I4
			//IL_0295: Expected VT, but got I4
			//IL_029a: Expected native int or pointer, but got Obj
			//IL_02a9: Expected VT, but got Obj
			//IL_02b3: Expected Obj, but got VT
			//IL_02c9: Expected native int or pointer, but got Obj
			//IL_010d: Expected Obj, but got I4
			//IL_00f3: Expected I4, but got Obj
			//IL_0094->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0082->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00a6->IL00aa: Incompatible stack types: I4 vs Obj
			//IL_0281->IL00aa: Incompatible stack types: I4 vs Obj
			//IL_02fe->IL00aa: Incompatible stack types: I4 vs Obj
			//IL_0309->IL00aa: Incompatible stack types: I4 vs Obj
			//IL_01d9->IL00aa: Incompatible stack types: I4 vs Obj
			//IL_023b->IL00aa: Incompatible stack types: I4 vs Obj
			//IL_01bd->IL00aa: Incompatible stack types: I4 vs Obj
			//IL_017a->IL00aa: Incompatible stack heights: 2 vs 1
			//IL_0154->IL00aa: Incompatible stack types: I4 vs Obj
			//IL_02d3->IL00aa: Incompatible stack types: I4 vs Obj
			//IL_01e4->IL00aa: Incompatible stack types: I4 vs Obj
			//IL_0185->IL00aa: Incompatible stack heights: 2 vs 1
			//IL_015f->IL00aa: Incompatible stack types: I4 vs Obj
			//IL_02de->IL00aa: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 2;
			object obj = awaiter;
			while (true)
			{
				object obj2;
				switch ((int)obj)
				{
				default:
					return;
				case 2:
					awaiter = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state;
					obj = 1;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
					{
						obj = 1;
					}
					break;
				case 0:
					return;
				case 4:
					((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Eu__1 = (TaskAwaiter)(-2);
					obj = 3;
					break;
				case 1:
					awaiter = Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton;
					obj = 5;
					break;
				case 5:
					if (awaiter == null)
					{
						obj2 = 6;
						goto IL_00aa;
					}
					goto IL_02de;
				case 3:
					{
						_ = ref ((FeverInstaller._003CInstallAsync_003Ed__11)this)._003C_003Et__builder;
						/*Error near IL_03c0: Member reference must be method, but was: Field*/;
					}
					IL_02de:
					if ((int)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)awaiter)->_003C_003Et__builder == 0)
					{
						obj2 = 1;
						if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003E4__this)->info == null)
						{
							obj2 = 5;
						}
						goto IL_00aa;
					}
					goto IL_025f;
					IL_025f:
					_ = FeverInstaller.McBedrock__BackingField;
					((FeverInstaller)(object)((FeverInstaller)((FeverInstaller)Unsafe.AsPointer(ref this)).Client__BackingField).Client).Dispose();
					obj2 = 7;
					goto IL_00aa;
					IL_00aa:
					while (true)
					{
						switch ((int)obj2)
						{
						case 14:
							return;
						case 7:
						case 15:
							break;
						case 11:
							if (((AsyncTaskMethodBuilder*)(&awaiter))->Task != null)
							{
								awaiter = 8;
								goto IL_00a6;
							}
							goto case 9;
						case 13:
							awaiter = -1;
							((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003E4__this = (Authenticator)(-1);
							obj2 = 12;
							if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
							{
								obj2 = 10;
							}
							continue;
						case 8:
						case 12:
							((Task)(&awaiter)).GetAwaiter();
							_ = 15;
							if (((Authenticator._003CReceiveAsync_003Ed__9)Authenticator._003CReceiveAsync_003Ed__9._003C_003Et__builder)._003C_003E4__this != null)
							{
								_ = 14;
							}
							continue;
						case 9:
							awaiter = 0;
							Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain = 0;
							obj2 = 2;
							continue;
						default:
							awaiter = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003E1__state;
							obj2 = 0;
							if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003Et__builder).client == null)
							{
								obj2 = 1;
							}
							continue;
						case 1:
							((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003E4__this = null;
							awaiter = 13;
							goto IL_00a6;
						case 4:
							Unsafe.As<TaskAwaiter<string>, AsyncTaskMethodBuilder>(ref ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003Eu__1).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityFeverManifestInfo>*)(&awaiter), ref Unsafe.As<_003CSendDataAsync_003Ed__49, FeverInstaller._003CInstallAsync_003Ed__11>(ref this));
							awaiter = 14;
							goto IL_00a6;
						case 2:
							((FeverInstaller)Unsafe.AsPointer(ref this))._003CfeverVersion_003EP = awaiter;
							obj2 = 4;
							continue;
						case 3:
							goto IL_025f;
						case 5:
						case 16:
						{
							object obj3 = awaiter;
							ConfigureSerialization[] array = new ConfigureSerialization[3]
							{
								(ConfigureSerialization)(object)(AsyncTaskMethodBuilder<>)513,
								default,
								default
							};
							((RestClientOptions)1).UserAgent = (string)(object)((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)awaiter)->request;
							((object[])obj3)[(object)array] = (CancellationToken)array;
							((object[])/*Error near IL_02aa: Stack underflow*/)[2] = ((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)this)._003C_003Et__builder;
							awaiter = (FeverInstaller.CheckScopeSummarizer() ? ((AsyncTaskMethodBuilder<EntityFeverManifest>*)1) : ((AsyncTaskMethodBuilder<EntityFeverManifest>*)null))->Task;
							obj2 = 11;
							if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor)->_003C_003E1__state != 0)
							{
								obj2 = 7;
							}
							continue;
						}
						case 10:
							goto IL_02de;
							IL_00a6:
							obj2 = awaiter;
							continue;
						}
						break;
					}
					goto case 4;
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00팀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00씀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0044: Expected I, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_004e: Expected native int or pointer, but got Obj
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
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
					((Func<Task>)/*Error near IL_0044: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
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
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00였()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_035b: Expected Obj, but got I4
			//IL_0365: Expected native int or pointer, but got Obj
			//IL_0077: Expected Obj, but got VT
			//IL_0050: Expected Obj, but got I4
			//IL_0191: Expected Obj, but got Ref
			//IL_0191: Expected Obj, but got Ref
			//IL_019b: Expected native int or pointer, but got Obj
			//IL_01ff: Expected Obj, but got I4
			//IL_0125: Expected Obj, but got Ref
			//IL_012f: Expected native int or pointer, but got Obj
			//IL_015a: Expected native int or pointer, but got Obj
			//IL_00ff: Expected Obj, but got VT
			//IL_0109: Expected native int or pointer, but got Obj
			//IL_025d: Expected Obj, but got I4
			//IL_0262: Expected Obj, but got I4
			//IL_01ca: Expected VT, but got Obj
			//IL_0174: Expected Obj, but got I4
			//IL_0179: Expected Obj, but got I4
			//IL_036f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0348->IL0026: Incompatible stack heights: 2 vs 1
			//IL_0081->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_037a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0353->IL0026: Incompatible stack heights: 2 vs 1
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01a5->IL0097: Incompatible stack heights: 2 vs 1
			//IL_0213->IL0097: Incompatible stack heights: 7 vs 1
			//IL_0113->IL0097: Incompatible stack heights: 2 vs 1
			//IL_01b0->IL0097: Incompatible stack heights: 2 vs 1
			//IL_021e->IL0097: Incompatible stack heights: 7 vs 1
			//IL_011e->IL0097: Incompatible stack heights: 2 vs 1
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object stateMachine = 3;
			object obj = stateMachine;
			while (true)
			{
				int num;
				switch ((int)obj)
				{
				case 3:
					stateMachine = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state;
					obj = 2;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
					{
						obj = 0;
					}
					continue;
				case 2:
					stateMachine = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Eu__1;
					obj = 5;
					continue;
				case 5:
					if (stateMachine != null)
					{
						num = 12;
						goto IL_0097;
					}
					goto IL_01b0;
				case 1:
					_ = Unsafe.As<TaskAwaiter<RestResponse<EntityFeverManifest>>, AsyncTaskMethodBuilder<EntityFeverAppVersion>>(ref ((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003Eu__1).Task;
					_ = 4;
					if ((int)((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						_ = 3;
					}
					continue;
				case 4:
					return;
					IL_01b0:
					stateMachine = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003Cstream_003E5__2;
					num = 3;
					goto IL_0097;
					IL_0097:
					while (true)
					{
						switch (num)
						{
						case 7:
							((AsyncTaskMethodBuilder*)/*Error near IL_00e0: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)(&stateMachine));
							if ((int)/*Error near IL_00e5: Stack underflow*/ == 0)
							{
								num = 9;
								continue;
							}
							goto case 2;
						case 5:
							((Authenticator)stateMachine).ReceiveAsync(stateMachine);
							stateMachine = AsyncTaskMethodBuilder.Create();
							_ = 6;
							if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this != null)
							{
								_ = 7;
							}
							continue;
						case 2:
							((IAsyncStateMachine)(&stateMachine)).MoveNext();
							num = 6;
							if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state != 0)
							{
								num = 0;
							}
							continue;
						case 3:
							Unsafe.As<AsyncTaskMethodBuilder, @null>(ref ((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003Et__builder) = null;
							num = 13;
							if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9.client)->_003C_003Eu__1 == 0)
							{
								num = 1;
							}
							continue;
						case 13:
							stateMachine = -1;
							Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain = -1;
							num = 2;
							continue;
						default:
							((RestResponse<EntityFeverManifest>)(object)Unsafe.AsPointer(ref ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003E1__state)).EnsureSuccessStatusCode<EntityFeverManifest>((string?)(&stateMachine), (byte)Unsafe.AsPointer(ref this) != 0);
							_ = 11;
							if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.client)->_003C_003E4__this != null)
							{
								_ = 0;
							}
							continue;
						case 4:
							break;
						case 10:
							((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003Eu__1 = (TaskAwaiter<string>)stateMachine;
							num = 0;
							if (((FeverInstaller)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway)._003CfeverVersion_003EP != null)
							{
								num = 0;
							}
							continue;
						case 1:
							_ = ((FeverInstaller)stateMachine)._003CappId_003EP;
							_ = 0;
							_ = ((Array)stateMachine).Length;
							((TcpClient)0).GetStream();
							_ = 2;
							if (((FeverInstaller)FeverInstaller.McBedrock__BackingField).Client__BackingField == null)
							{
								_ = 5;
							}
							continue;
						case 11:
							return;
						case 8:
							if (FeverInstaller.ReflectVisualArgument != null)
							{
								num = 0;
								if ((int)((FeverInstaller._003CFeverRequest_003Ed__15<>*)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003E1__state)->_003C_003Et__builder != 0)
								{
									num = 1;
								}
								continue;
							}
							goto case 5;
						case 9:
							stateMachine = 0;
							((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003E4__this = (FeverInstaller)0;
							num = 10;
							continue;
						case 12:
							stateMachine = ((FeverInstaller)(object)((FeverInstaller._003CFeverRequest_003Ed__15<>)this).request).GetFeverAppVersionAsync();
							num = 8;
							continue;
						case 6:
							goto end_IL_0026;
						}
						break;
					}
					goto IL_01b0;
					end_IL_0026:
					break;
				}
				((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003E4__this = (FeverInstaller)(-2);
				obj = 1;
				if ((int)((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13.version)->_003C_003Eu__1 == 0)
				{
					obj = 1;
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00쨀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00봀(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_0045: Expected I, but got Obj
			//IL_0045: Expected Obj, but got Ref
			//IL_004f: Expected native int or pointer, but got Obj
			//IL_0059->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
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
				case 0:
					return;
				case 1:
					((Func<Task>)/*Error near IL_0045: Stack underflow*/)._002Ector((object)Unsafe.AsPointer(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state), (nint)P_0);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj2 = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00븀()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
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
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_01c9: Expected native int or pointer, but got Obj
			//IL_00e4: Expected Obj, but got I4
			//IL_01e3: Expected Obj, but got I4
			//IL_01e8: Expected VT, but got I4
			//IL_01a7: Expected Obj, but got Ref
			//IL_01b2: Expected Obj, but got I4
			//IL_02a4: Expected Obj, but got I4
			//IL_02a9: Expected VT, but got I4
			//IL_02b3: Expected native int or pointer, but got Obj
			//IL_017e: Expected Obj, but got Ref
			//IL_027a: Unknown result type (might be due to invalid IL or missing references)
			//IL_028a: Expected native int or pointer, but got Obj
			//IL_023c: Expected Obj, but got I4
			//IL_01f4: Expected native int or pointer, but got Obj
			//IL_0205: Expected I4, but got Obj
			//IL_0205: Expected I4, but got Obj
			//IL_0216: Expected Obj, but got VT
			//IL_0141: Expected Obj, but got Ref
			//IL_0126: Expected I4, but got Obj
			//IL_008f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0065->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00c8->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ac->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01d3->IL00ed: Incompatible stack types: I4 vs Obj
			//IL_009a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0070->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00d3->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01de->IL00ed: Incompatible stack types: I4 vs Obj
			//IL_01f2->IL00ed: Incompatible stack types: I4 vs Obj
			//IL_02bd->IL00ed: Incompatible stack types: I4 vs Obj
			//IL_0188->IL00ed: Incompatible stack types: I4 vs Obj
			//IL_0177->IL00ed: Incompatible stack types: I4 vs Obj
			//IL_0294->IL00ed: Incompatible stack types: I4 vs Obj
			//IL_0269->IL00ed: Incompatible stack types: I4 vs Obj
			//IL_022a->IL00ed: Incompatible stack heights: 2 vs 1
			//IL_01a0->IL00ed: Incompatible stack types: I4 vs Obj
			//IL_02c8->IL00ed: Incompatible stack types: I4 vs Obj
			//IL_029f->IL00ed: Incompatible stack types: I4 vs Obj
			//IL_0274->IL00ed: Incompatible stack types: I4 vs Obj
			//IL_0235->IL00ed: Incompatible stack heights: 2 vs 1
			//IL_015a->IL00ed: Incompatible stack types: I4 vs Obj
			//IL_0165->IL00ed: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 5;
			object obj = awaiter;
			while (true)
			{
				object obj2;
				switch ((int)obj)
				{
				case 2:
					return;
				case 3:
					((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state = -2;
					obj = 1;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj = 1;
					}
					break;
				case 1:
					((AsyncTaskMethodBuilder*)/*Error near IL_007b: Stack underflow*/)->Start<TStateMachine>(ref Unsafe.As<TaskAwaiter, TStateMachine>(ref ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Eu__1));
					obj = 2;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder != 0)
					{
						obj = 1;
					}
					break;
				case 5:
					awaiter = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this).listener;
					obj = 4;
					break;
				case 4:
					awaiter = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003E4__this;
					obj = 0;
					if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
					{
						obj = 0;
					}
					break;
				default:
					{
						if (awaiter != null)
						{
							awaiter = 8;
							goto IL_00e9;
						}
						goto IL_01b7;
					}
					IL_01b7:
					awaiter = ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this).client;
					obj2 = 3;
					if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E4__this)->_003Cstream_003E5__2 == null)
					{
						obj2 = 7;
					}
					goto IL_00ed;
					IL_00ed:
					while (true)
					{
						switch ((int)obj2)
						{
						case 3:
							return;
						case 5:
							break;
						case 12:
							if ((int)((Task)(&awaiter)).GetAwaiter() == 0)
							{
								obj2 = 2;
								if (((Authenticator._003CReceiveAsync_003Ed__9)Authenticator._003CReceiveAsync_003Ed__9._003C_003Et__builder)._003C_003E4__this != null)
								{
									obj2 = 2;
								}
								continue;
							}
							goto case 4;
						case 6:
							((Authenticator._003CReceiveAsync_003Ed__9)this).client = (TcpClient)awaiter;
							obj2 = 10;
							continue;
						case 4:
							((AsyncTaskMethodBuilder*)/*Error near IL_017e: Stack underflow*/)->SetException((Exception)(&awaiter));
							obj2 = 5;
							continue;
						case 10:
							Unsafe.As<object, AsyncTaskMethodBuilder<EntityFeverManifest>>(ref Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<RestResponse<EntityFeverManifest>>*)(&awaiter), ref Unsafe.As<_003CSendMessageAsync_003Ed__45, FeverInstaller._003CGetFeverManifestAsync_003Ed__12>(ref this));
							obj2 = 3;
							continue;
						case 1:
							goto IL_01a0;
						case 11:
							goto IL_01b7;
						default:
							awaiter = -1;
							((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003C_003Eu__1 = (TaskAwaiter<string>)(-1);
							obj2 = 4;
							continue;
						case 9:
							((Encoding)/*Error near IL_0205: Stack underflow*/).GetString((byte[])/*Error near IL_0205: Stack underflow*/, (int)((Encoding)/*Error near IL_01fe: Stack underflow*/).GetBytes((string)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway), (int)awaiter);
							awaiter = null;
							awaiter = ((Task<string>)awaiter).GetAwaiter();
							_ = 1;
							if (FeverInstaller.ReflectVisualArgument != null)
							{
								_ = 1;
							}
							continue;
						case 8:
							((Stream)/*Error near IL_0243: Stack underflow*/).Write((byte[])/*Error near IL_0243: Stack underflow*/, (int)/*Error near IL_0243: Stack underflow*/, (int)(ushort)((Array)((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003E1__state).Length);
							((AsyncTaskMethodBuilder*)/*Error near IL_024e: Stack underflow*/)->Start(ref *(Rpc._003CListenAsync_003Ed__34*)((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003E4__this);
							((AsyncTaskMethodBuilder*)/*Error near IL_0253: Stack underflow*/)->Start(ref *(Rpc._003CListenControlConnectAsync_003Ed__35*)/*Error near IL_0253: Stack underflow*/);
							awaiter = (object)/*Error near IL_0255: Stack underflow*/;
							obj2 = 3;
							if ((int)((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14._003C_003E1__state)->_003C_003Et__builder == 0)
							{
								obj2 = 9;
							}
							continue;
						case 7:
							((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)this)._003C_003E4__this = (FeverInstaller)default(Method);
							obj2 = 0;
							if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor)->_003C_003E1__state == 0)
							{
								obj2 = 0;
							}
							continue;
						case 2:
							awaiter = 0;
							((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003Et__builder = (AsyncTaskMethodBuilder<EntityFeverManifest>)0;
							obj2 = 6;
							if (((FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(nint)FeverInstaller._003CGetFeverManifestAsync_003Ed__12._003C_003E4__this)->info == null)
							{
								obj2 = 0;
							}
							continue;
						}
						break;
					}
					goto case 3;
					IL_01a0:
					((AsyncTaskMethodBuilder*)/*Error near IL_01a7: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)(&awaiter));
					awaiter = (object)/*Error near IL_01a9: Stack underflow*/;
					awaiter = 12;
					goto IL_00e9;
					IL_00e9:
					obj2 = awaiter;
					goto IL_00ed;
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
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00숀()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
	public unsafe DesktopTransfer(DesktopSession session, EntityLanGameRoom room)
	{
		//IL_001a: Expected VT, but got Obj
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected VT, but got Unknown
		//IL_002f: Expected VT, but got Obj
		//IL_003f: Expected I4, but got VT
		//IL_0054: Expected native int or pointer, but got Obj
		//IL_0409: Expected native int or pointer, but got Obj
		//IL_0428: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got VT
		//IL_0111: Expected native int or pointer, but got Obj
		//IL_00de: Expected native int or pointer, but got Obj
		//IL_02ad: Expected Ref, but got VT
		//IL_01fe: Expected native int or pointer, but got Obj
		//IL_0288: Expected Ref, but got VT
		//IL_0158: Expected Obj, but got VT
		//IL_0162: Expected native int or pointer, but got Obj
		//IL_0251: Expected native int or pointer, but got Obj
		//IL_0267: Expected Obj, but got VT
		//IL_02ca: Expected native int or pointer, but got Obj
		//IL_01c4: Expected native int or pointer, but got Obj
		//IL_0238: Expected VT, but got Obj
		//IL_0233: Expected native int or pointer, but got Obj
		//IL_03e8: Expected native int or pointer, but got Obj
		//IL_03f9: Expected VT, but got Obj
		//IL_03f9: Expected Obj, but got I4
		//IL_03f9: Expected Obj, but got VT
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected Ref, but got Unknown
		//IL_0141->IL0072: Incompatible stack heights: 9 vs 3
		//IL_0196->IL0072: Incompatible stack heights: 1 vs 3
		//IL_02c9->IL0072: Incompatible stack heights: 5 vs 3
		//IL_029c->IL0072: Incompatible stack heights: 7 vs 3
		//IL_016c->IL0072: Incompatible stack heights: 6 vs 3
		//IL_0271->IL0072: Incompatible stack heights: 4 vs 3
		//IL_0408->IL0072: Incompatible stack heights: 2 vs 3
		//IL_010e->IL0072: Incompatible stack heights: 7 vs 3
		//IL_0072->IL0072: Incompatible stack heights: 6 vs 3
		//IL_01a1->IL0072: Incompatible stack heights: 1 vs 3
		//IL_02a7->IL0072: Incompatible stack heights: 7 vs 3
		//IL_0177->IL0072: Incompatible stack heights: 6 vs 3
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)/*Error near IL_001f: Stack underflow*/)->_003C_003Et__builder, (AsyncTaskMethodBuilder)new ILogger((string)/*Error near IL_001a: Stack underflow*/, (_0021_00210)this));
		Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)/*Error near IL_002f: Stack underflow*/)->_003C_003Eu__1, (TaskAwaiter)new Task((Func<Task?>)(object)this));
		((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)/*Error near IL_003f: Stack underflow*/)->_003C_003E1__state = (int)new AsyncTaskMethodBuilder(ref *(TStateMachine*)this);
		AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
		int num = 9;
		if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
		{
			num = 4;
		}
		object obj = default;
		while (true)
		{
			switch (num)
			{
			case 7:
			{
				object decorateAdjustableHandler = obj;
				((IAsyncStateMachine)obj).MoveNext();
				Unsafe.Write(&Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler, decorateAdjustableHandler);
				num = 4;
				break;
			}
			case 21:
				_ = 514;
				new AsyncTaskMethodBuilder(ref *(TAwaiter*)this, ref *(TStateMachine*)__ldftn(Authenticator._003CListenAsync_003Ed__7.MoveNext));
				Authenticator._003CListenAsync_003Ed__7.DecorateExpandableParser();
				_ = 10;
				break;
			case 5:
				Unsafe.Write(&((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->client, obj);
				num = 7;
				break;
			case 1:
				_ = 257;
				__ldftn(Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.MoveNext);
				new AsyncTaskMethodBuilder();
				Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateGenericStruct();
				_ = 11;
				break;
			case 11:
				_ = 513;
				((Authenticator._003CReceiveAsync_003Ed__9*)(delegate*<object>)(&Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.ReflectRandomReporter))->SetStateMachine((IAsyncStateMachine)new TaskAwaiter<TcpClient>());
				_ = 21;
				if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003Cstream_003E5__2)->_003C_003Eu__1 == 0)
				{
					_ = 21;
				}
				break;
			case 4:
				((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)this)->MoveNext();
				((FeverInstaller)this)._003CfeverVersion_003EP = asyncTaskMethodBuilder;
				_ = 6;
				if (((FeverInstaller)FeverInstaller._003CappId_003EP)._003CappVersion_003EP != null)
				{
					_ = 20;
				}
				break;
			case 15:
				FeverInstaller.McBedrock__BackingField = room;
				num = 8;
				break;
			case 16:
				((FeverInstaller)this).Client__BackingField = obj;
				num = 5;
				if (((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)FeverInstaller.ReflectVisualArgument)->_003C_003E1__state == 0)
				{
					num = 5;
				}
				break;
			case 14:
				obj = obj;
				num = 7;
				if (((FeverInstaller._003CFeverRequest_003Ed__15<>)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003Et__builder)._003C_003E4__this == null)
				{
					num = 18;
				}
				break;
			case 9:
				Unsafe.Write(&((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)this)->request, session);
				num = 15;
				break;
			case 18:
				obj = obj;
				num = 0;
				if (((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003Eu__1)._003C_003E1__state == 0)
				{
					num = 0;
				}
				break;
			case 17:
				Unsafe.Write(&((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)this)->_003C_003Et__builder, (AsyncTaskMethodBuilder<EntityFeverAppVersion>)obj);
				num = 16;
				break;
			default:
				obj = obj;
				num = 3;
				break;
			case 12:
				_ = ((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)this)->_003C_003E4__this;
				((FeverInstaller._003CFeverRequest_003Ed__15<>*)this)->SetStateMachine((IAsyncStateMachine)new AsyncTaskMethodBuilder<EntityFeverManifest>(ref *(TStateMachine*)(delegate*<FeverInstaller>)(&FeverInstaller.CheckStaticProgram)));
				_ = 2;
				break;
			case 10:
				_ = 516;
				_ = (delegate*<bool>)(&FeverInstaller._003CFeverRequest_003Ed__15<>.CheckAdaptableResponder);
				((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)new AsyncTaskMethodBuilder<EntityFeverManifestInfo>())->MoveNext();
				_ = 6;
				if (FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReflectReporter != null)
				{
					_ = 0;
				}
				break;
			case 8:
				((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)asyncTaskMethodBuilder)->Start<TStateMachine>(ref *(TStateMachine*)session);
				AsyncTaskMethodBuilder<_0021_00210>.Create();
				_ = ref obj;
				_ = ref obj;
				((DefaultInterpolatedStringHandler*)(&obj))->AppendFormatted((EnumGameVersion)(uint)(&obj));
				_ = 14;
				break;
			case 13:
				_ = ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(nint)this)->version;
				_ = (delegate*<object>)(&FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReceiveEnumerator);
				/*Error near IL_02d6: Member reference must be method, but was: Field*/;
			case 6:
				return;
			case 3:
				obj = obj;
				num = 17;
				if ((int)((FeverInstaller._003CInstallAsync_003Ed__11)FeverInstaller._003CInstallAsync_003Ed__11._003C_003Eu__1)._003C_003Eu__2 == 0)
				{
					num = 11;
				}
				break;
			case 20:
				_ = ref obj;
				_ = 14;
				_ = 5;
				/*Error near IL_032a: Member reference must be method, but was: Field*/;
			case 19:
				((Rpc._003CListenControlConnectAsync_003Ed__35*)new RestRequestExtensions((RestRequest)(object)asyncTaskMethodBuilder, (string)((Rpc._003CRemoteCallBackAsync_003Ed__21*)(nint)this)->_003C_003E1__state, (_0021_00210)this, (byte)(delegate*<bool>)(&Rpc._003CListenAsync_003Ed__34.CheckIntegratedDic) != 0))->MoveNext();
				_ = 12;
				break;
			case 2:
				_ = ((Rpc._003CRemoteCallBackAsync_003Ed__21*)(nint)this)->_003C_003Eu__1;
				_ = (delegate*<bool>)(&Rpc._003CListenControlConnectAsync_003Ed__35.DecorateConfigurableArgument);
				((Rpc._003CReceiveAsync_003Ed__28*)new Task<EntityFeverManifestInfo>())->MoveNext();
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
	internal unsafe void _FF00_FF00_FF00_FF00栀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00b4: Expected native int or pointer, but got Obj
		//IL_00bb: Expected Obj, but got VT
		//IL_0095: Expected native int or pointer, but got Obj
		//IL_00ae: Expected Obj, but got I4
		//IL_007e: Expected native int or pointer, but got Obj
		//IL_00de->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0060->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0088->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0093->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)Authenticator._003CListenAsync_003Ed__7._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj2 = 0;
					}
					continue;
				case 4:
					if (obj == obj)
					{
						obj2 = 1;
						if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
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
					obj = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003Et__builder;
					obj2 = 2;
					continue;
				default:
				{
					object obj3 = obj;
					GC.SuppressFinalize(P_0);
					obj = (string)obj3;
					obj2 = 5;
					continue;
				}
				}
				break;
			}
			((AsyncTaskMethodBuilder*)(&Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton))->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<string>*)obj, ref *(Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)obj);
			obj = (object)/*Error near IL_00a5: Stack underflow*/;
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
	private unsafe void _FF00_FF00_FF00_FF00欀()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0042: Expected native int or pointer, but got Obj
		//IL_0059: Expected VT, but got I4
		//IL_0054: Expected native int or pointer, but got Obj
		//IL_0063: Expected native int or pointer, but got Obj
		//IL_0079: Expected native int or pointer, but got Obj
		//IL_0051->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0097->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0078->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a2->IL0026: Incompatible stack heights: 2 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
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
				((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = 0;
				obj2 = 3;
				break;
			case 2:
				return;
			case 1:
				Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Et__builder, (AsyncTaskMethodBuilder)0);
				obj2 = 0;
				if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				_ = ((AsyncTaskMethodBuilder*)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->Task;
				_ = 0;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener == null)
				{
					_ = 2;
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
	internal unsafe sealed void _FF00_FF00_FF00_FF00焀()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_011e: Expected native int or pointer, but got Obj
		//IL_011c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01f4->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				_ = ((Authenticator)this).Listener;
				int num2 = 0;
				if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
				{
					num2 = 0;
				}
				switch (num2)
				{
				}
				goto default;
			}
			default:
				((AsyncTaskMethodBuilder*)/*Error near IL_0112: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_0112: Stack underflow*/, ref *(TStateMachine*)this);
				obj2 = 3;
				continue;
			case 2:
			{
				_ = ((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003E4__this;
				Authenticator._003CListenAsync_003Ed__7.ObserveTracker();
				int num = 0;
				if (Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain == null)
				{
					num = 0;
				}
				switch (num)
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
	internal unsafe static object _FF00_FF00_FF00_FF00琀()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00甀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779282, new IntPtr(2737367904684L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00瘀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0074: Expected I, but got Obj
		//IL_00af: Expected native int or pointer, but got Obj
		//IL_00bf: Expected Obj, but got I
		//IL_00c9: Expected native int or pointer, but got Obj
		//IL_0057: Expected native int or pointer, but got Obj
		//IL_005e: Expected Obj, but got I4
		//IL_0067: Expected Obj, but got I4
		//IL_0085->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0056->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00de->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ae->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
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
				default:
					return;
				case 4:
					obj = obj;
					obj2 = 2;
					continue;
				case 5:
					break;
				case 2:
					((Func<Task>)/*Error near IL_0074: Stack underflow*/)._002Ector(obj, (nint)P_0);
					obj = (Exception)/*Error near IL_0075: Stack underflow*/;
					obj2 = 3;
					continue;
				case 0:
					return;
				case 1:
					if (obj == obj)
					{
						obj2 = 0;
						if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton != null)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 4;
				case 3:
				{
					int* ptr = &((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003E1__state;
					((AsyncTaskMethodBuilder*)obj)->Start(ref *(FeverInstaller._003CInstallAsync_003Ed__11*)obj);
					obj = (object)ptr;
					obj2 = 0;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
					{
						obj2 = 1;
					}
					continue;
				}
				}
				break;
			}
			obj = ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
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
	internal unsafe static byte _FF00_FF00_FF00_FF00缀()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
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
	private unsafe void _FF00_FF00_FF00_FF00茀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0068: Expected native int or pointer, but got Obj
		//IL_0043: Expected native int or pointer, but got Obj
		//IL_0084: Expected Ref, but got VT
		//IL_005c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0098->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0067->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a3->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
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
				((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = 0;
				obj2 = 0;
				if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
				{
					obj2 = 0;
				}
				continue;
			case 3:
				return;
			}
			TaskAwaiter taskAwaiter = ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Eu__1;
			if ((int)taskAwaiter == 0)
			{
				obj2 = 3;
				continue;
			}
			((AsyncTaskMethodBuilder*)/*Error near IL_0084: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)taskAwaiter);
			obj2 = 2;
			if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
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
	internal unsafe void _FF00_FF00_FF00_FF00蔀(Action<byte[]> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00bc: Expected Obj, but got VT
		//IL_0049: Expected native int or pointer, but got Obj
		//IL_0059: Expected Obj, but got I
		//IL_0064: Expected native int or pointer, but got Obj
		//IL_00c6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ad->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ef->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
			{
				int* ptr = &((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
				((AsyncTaskMethodBuilder*)obj)->Start(ref *(Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)obj);
				obj = (object)ptr;
				obj2 = 5;
				break;
			}
			case 4:
				obj = ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E4__this;
				obj2 = 3;
				if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton == null)
				{
					obj2 = 1;
				}
				break;
			case 3:
				obj = obj;
				obj2 = 0;
				if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					obj2 = 0;
				}
				break;
			default:
			{
				object obj3 = obj;
				GC.SuppressFinalize(P_0);
				obj = (AsyncTaskMethodBuilder<_00210>)obj3;
				obj2 = 2;
				break;
			}
			case 1:
				return;
			case 5:
				if (obj == obj)
				{
					obj2 = 0;
					if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler != null)
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
	private unsafe void _FF00_FF00_FF00_FF00蘀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0041: Expected native int or pointer, but got Obj
		//IL_0074: Expected VT, but got I4
		//IL_006f: Expected native int or pointer, but got Obj
		//IL_007e: Expected native int or pointer, but got Obj
		//IL_00a3: Expected native int or pointer, but got Obj
		//IL_0088->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ad->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0061->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0093->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b8->IL0026: Incompatible stack heights: 3 vs 1
		//IL_006c->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				if (((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state == 0)
				{
					obj2 = 1;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 0;
					}
					break;
				}
				AsyncTaskMethodBuilder.Create();
				_ = 0;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this != null)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			case 3:
				Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Eu__1, (TaskAwaiter)1);
				obj2 = 2;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state == 0)
				{
					obj2 = 0;
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
	private unsafe void _FF00_FF00_FF00_FF00謀()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0039: Expected native int or pointer, but got Obj
		//IL_0043: Expected Obj, but got I4
		//IL_0058: Expected native int or pointer, but got Obj
		//IL_0062->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006d->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
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
				((Authenticator)/*Error near IL_0043: Stack underflow*/).Listener = (TcpListener?)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
				((TcpListener)(object)new Task((Func<Task?>)/*Error near IL_0048: Stack underflow*/)).Start();
				obj2 = 0;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state != 0)
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
	private unsafe void _FF00_FF00_FF00_FF00贀(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_003d: Expected native int or pointer, but got Obj
		//IL_007a: Expected native int or pointer, but got Obj
		//IL_0084->IL0026: Incompatible stack heights: 2 vs 1
		//IL_005d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0068->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				if (((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state == 0)
				{
					obj2 = 1;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 0;
					}
					break;
				}
				((TcpListener)P_1).Start();
				_ = 0;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state == 0)
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
	private unsafe void _FF00_FF00_FF00_FF00輀(ushort P_0, Func<TransferCallBack, Task> P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0046: Expected Obj, but got I4
		//IL_0078: Expected native int or pointer, but got Obj
		//IL_006b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0098->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0076->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a3->IL0026: Incompatible stack heights: 3 vs 1
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
			{
				((Authenticator)/*Error near IL_0046: Stack underflow*/).Listener = (TcpListener?)Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
				ushort num = P_0;
				((TcpListener)(object)Task.Run((Func<Task?>)(object)P_1)).Start();
				((AsyncTaskMethodBuilder*)/*Error near IL_0057: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)/*Error near IL_0057: Stack underflow*/, ref *(Authenticator._003CReceiveAsync_003Ed__9*)num);
				obj2 = 0;
				if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					obj2 = 0;
				}
				break;
			}
			case 0:
				return;
			case 2:
				_ = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->listener;
				((TcpListener)(object)P_1).Dispose();
				_ = 1;
				if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler == null)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_FF00_FF00鄀()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0039: Expected native int or pointer, but got Obj
		//IL_0043: Expected Obj, but got I4
		//IL_0058: Expected native int or pointer, but got Obj
		//IL_0062->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006d->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
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
				((Authenticator)/*Error near IL_0043: Stack underflow*/).Listener = (TcpListener?)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
				((TcpListener)(object)new Task((Func<Task?>)/*Error near IL_0048: Stack underflow*/)).Start();
				obj2 = 0;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state == 0)
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
	private unsafe void _FF00_FF00_FF00_FF00鐀()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0039: Expected native int or pointer, but got Obj
		//IL_0043: Expected Obj, but got I4
		//IL_0058: Expected native int or pointer, but got Obj
		//IL_0062->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006d->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
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
				((Authenticator)/*Error near IL_0043: Stack underflow*/).Listener = (TcpListener?)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
				((TcpListener)(object)new Task((Func<Task?>)/*Error near IL_0048: Stack underflow*/)).Start();
				obj2 = 0;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state == 0)
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
	private unsafe void _FF00_FF00_FF00_FF00阀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0068: Expected native int or pointer, but got Obj
		//IL_0043: Expected native int or pointer, but got Obj
		//IL_00a4: Expected native int or pointer, but got Obj
		//IL_007e: Expected native int or pointer, but got Obj
		//IL_005c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ae->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0088->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0067->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b9->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0093->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = 0;
				obj2 = 1;
				if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
				{
					obj2 = 2;
				}
				break;
			case 2:
				if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Eu__1 == 0)
				{
					obj2 = 0;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state != 0)
					{
						obj2 = 0;
					}
					break;
				}
				AsyncTaskMethodBuilder.Create();
				_ = 1;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
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
	internal unsafe void _FF00_FF00_FF00_FF00鰀(Action<byte[]> P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0049: Expected native int or pointer, but got Obj
		//IL_0059: Expected Obj, but got I
		//IL_0063: Expected native int or pointer, but got Obj
		//IL_0086: Expected native int or pointer, but got Obj
		//IL_00c4: Expected native int or pointer, but got Obj
		//IL_00f4: Expected Obj, but got VT
		//IL_0104: Expected native int or pointer, but got Obj
		//IL_006d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0090->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00df->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0078->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ea->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0119->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00c3->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
			{
				int* ptr = &((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
				((AsyncTaskMethodBuilder*)obj)->Start(ref *(Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)obj);
				obj = (object)ptr;
				obj2 = 2;
				if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
				{
					obj2 = 3;
				}
				break;
			}
			case 1:
				obj = obj;
				obj2 = 0;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state != 0)
				{
					obj2 = 4;
				}
				break;
			case 3:
				if (obj == obj)
				{
					obj2 = 1;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener != null)
					{
						obj2 = 5;
					}
					break;
				}
				goto case 1;
			case 2:
				obj = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003E4__this;
				obj2 = 0;
				if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler != null)
				{
					obj2 = 1;
				}
				break;
			case 5:
				return;
			case 4:
				obj = (Task<EntityFeverApp>)(object)((Task)(object)P_0).GetAwaiter();
				_ = 0;
				if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9._003C_003E4__this)->client == null)
				{
					_ = 0;
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
	private unsafe static long _FF00_FF00_FF00_FF00鼀()
	{
		//IL_001a: Expected VT, but got I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected I8, but got Unknown
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		((ILogger)/*Error near IL_001a: Stack underflow*/).Debug<_0021_00210>((string)/*Error near IL_001a: Stack underflow*/, (_0021_00210)8);
		((Func<Task>)/*Error near IL_001f: Stack underflow*/)._002Ector((object)/*Error near IL_001f: Stack underflow*/, (nint)/*Error near IL_001f: Stack underflow*/);
		return (Task.Run((Func<Task?>)/*Error near IL_0024: Stack underflow*/) & 0x7FFFFFFFFFFFFFFFL) % 9223372036854775806L;
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
	private unsafe object _FF00_FF00_FF00_FF00꼀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_009b: Expected I4, but got Obj
		//IL_02b0: Expected I4, but got Obj
		//IL_02ba: Expected native int or pointer, but got Obj
		//IL_0145: Expected native int or pointer, but got Obj
		//IL_00a1: Expected native int or pointer, but got Obj
		//IL_00a8: Expected Obj, but got I4
		//IL_031a: Expected Obj, but got I4
		//IL_0336: Expected native int or pointer, but got Obj
		//IL_032b: Expected VT, but got I4
		//IL_0326: Expected native int or pointer, but got Obj
		//IL_0379: Expected Ref, but got VT
		//IL_015a: Expected Obj, but got I4
		//IL_0109: Expected native int or pointer, but got Obj
		//IL_00da->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0244->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02c4->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0304->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00bc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0290->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0324->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01c4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0335->IL0026: Incompatible stack types: I4 vs Obj
		//IL_024f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0171->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0139->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02cf->IL0026: Incompatible stack heights: 2 vs 1
		//IL_038d->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00c7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01ab->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f8->IL0026: Incompatible stack heights: 5 vs 1
		//IL_0351->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0261->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0113->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01ea->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0144->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0398->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0365->IL0026: Incompatible stack heights: 3 vs 1
		//IL_011e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01f5->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					obj = ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
					obj2 = 5;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
					{
						obj2 = 5;
					}
					break;
				default:
					obj = ((Authenticator)obj).ListenAsync();
					obj2 = 22;
					break;
				case 14:
					throw new AsyncTaskMethodBuilder(ref *(TStateMachine*)/*Error near IL_00df: Stack underflow*/);
				case 18:
				case 25:
					new AsyncTaskMethodBuilder();
					AsyncTaskMethodBuilder.Create();
					_ = 7;
					break;
				case 22:
					if (obj == null)
					{
						obj2 = 11;
						if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
						{
							obj2 = 2;
						}
						break;
					}
					goto case 2;
				case 5:
					if (obj == null)
					{
						obj2 = 0;
						if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler != null)
						{
							obj2 = 4;
						}
						break;
					}
					goto case 21;
				case 10:
				case 24:
					if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)this)->_003C_003E1__state != 0)
					{
						(FeverInstaller._003CFeverRequest_003Ed__15<>.CheckAdaptableResponder() ? ((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)1) : ((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)null))->Start<TStateMachine>(ref *(TStateMachine*)new AsyncTaskMethodBuilder<EntityFeverManifestInfo>());
						_ = 13;
						if (FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReflectReporter == null)
						{
							_ = 11;
						}
						break;
					}
					goto end_IL_0026;
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
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CReceiveAsync_003Ed__9.client)->MoveNext();
					((AsyncTaskMethodBuilder*)/*Error near IL_01ba: Stack underflow*/)->SetResult();
					obj2 = 6;
					break;
				case 3:
				case 6:
				case 9:
					((IAsyncStateMachine)/*Error near IL_01c9: Stack underflow*/).SetStateMachine((IAsyncStateMachine)/*Error near IL_01c9: Stack underflow*/);
					return (object)/*Error near IL_01ca: Stack underflow*/;
				case 27:
					if ((nint)obj != 255)
					{
						obj2 = 17;
						if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003Et__builder).client != null)
						{
							obj2 = 24;
						}
						break;
					}
					goto case 12;
				case 1:
					((AsyncTaskMethodBuilder*)/*Error near IL_022e: Stack underflow*/)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityFeverAppVersion>*)/*Error near IL_022e: Stack underflow*/, ref *(FeverInstaller._003CInstallAsync_003Ed__11*)P_0);
					obj = (object)/*Error near IL_0230: Stack underflow*/;
					obj2 = 0;
					if (((FeverInstaller)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway)._003CfeverVersion_003EP != null)
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
					((FeverInstaller)/*Error near IL_0281: Stack underflow*/)._002Ector((string)FeverInstaller._003CappId_003EP, (string)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.HandleNotifier(), (string)obj);
					((AsyncTaskMethodBuilder*)/*Error near IL_0286: Stack underflow*/)->Start(ref *(Rpc._003CRemoteCallBackAsync_003Ed__21*)/*Error near IL_0286: Stack underflow*/);
					obj2 = 3;
					break;
				case 4:
				case 7:
					((FeverInstaller)FeverInstaller.ReflectVisualArgument).Dispose();
					((IEnumerable<byte>)/*Error near IL_02b0: Stack underflow*/).Skip((int)obj);
					_ = 8;
					if (((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003E4__this)->request == null)
					{
						_ = 9;
					}
					break;
				case 8:
					FeverInstaller._002Ecctor();
					obj = (object)/*Error near IL_02fa: Stack underflow*/;
					obj2 = 18;
					break;
				case 15:
					obj = FeverInstaller.CheckScopeSummarizer();
					obj2 = 25;
					break;
				case 11:
				case 26:
					Unsafe.Write(&((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)this)->_003C_003Eu__1, (TaskAwaiter<EntityFeverApp>)1);
					obj2 = 19;
					break;
				case 19:
					if (FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor == null)
					{
						obj2 = 16;
						break;
					}
					AsyncTaskMethodBuilder<EntityFeverManifest>.Create();
					_ = 20;
					break;
				}
				continue;
				end_IL_0026:
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
