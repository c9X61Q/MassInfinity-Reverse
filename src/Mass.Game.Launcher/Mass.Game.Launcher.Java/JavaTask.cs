using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Game.Launcher.Entities.Fever;
using Mass.Game.Launcher.Enums;
using Mass.Game.Launcher.Paths;
using Mass.Game.Launcher.Values;
using RestSharp;
using Serilog;

namespace Mass.Game.Launcher.Java;

public sealed class JavaTask
{
	private readonly record struct TaskKey
	{
		public EnumGameVersion Version
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _FF00_FF00_FF00_FF00_FF00_FF00ﴀ();
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			init
			{
				_FF00_FF00_FF00_FF00_FF00_FF00_FF00Ѐ(value);
			}
		}

		public string Id
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (string)_FF00_FF00_FF00_FF00_FF00_FF00_F100();
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			init
			{
				_FF00_FF00_FF00_FF00_FF00_FF00_F300(value);
			}
		}

		public JavaStep Step
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ԁ();
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			init
			{
				_FF00_FF00_FF00_FF00_FF00_FF00_EE00(value);
			}
		}

		private static object CheckDividedRunner;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe TaskKey(EnumGameVersion Version, string Id, JavaStep Step)
		{
			//IL_0061: Expected VT, but got Obj
			//IL_006b: Expected native int or pointer, but got Obj
			//IL_0087: Expected VT, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state = (int)Version;
			int num = 0;
			if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 2:
					return;
				case 1:
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003Et__builder = (AsyncTaskMethodBuilder)Step;
					num = 2;
					continue;
				}
				((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Eu__1 = (TaskAwaiter)Id;
				num = 1;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state == 0)
				{
					num = 1;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public override string ToString()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private byte PrintMembers(object builder)
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00豈(builder);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool Equals(TaskKey other)
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public unsafe void Deconstruct(out EnumGameVersion Version, out string Id, out JavaStep Step)
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_E400((nint)Unsafe.AsPointer(ref Version), (nint)Unsafe.AsPointer(ref Id), (nint)Unsafe.AsPointer(ref Step));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ReflectGeneralClient()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateExtendedListener()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_E100()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778902, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_E200()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_E300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778901, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_E400(nint P_0, nint P_1, nint P_2)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_003b: Expected I4, but got Obj
			//IL_006f: Expected Obj, but got Ref
			//IL_0081: Expected Obj, but got Ref
			//IL_0081: Expected Obj, but got I
			//IL_0082: Expected I4, but got Obj
			//IL_0047: Expected Obj, but got Ref
			//IL_0048: Expected I4, but got Obj
			//IL_007a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0096->IL0026: Incompatible stack types: I4 vs Obj
			//IL_005c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00a1->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0067->IL0026: Incompatible stack types: I4 vs Obj
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
				case 3:
					*(int*)P_2 = (int)((Authenticator)Unsafe.AsPointer(ref this)).Listener;
					obj2 = 0;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 2;
					}
					break;
				case 2:
					return;
				default:
					Unsafe.Write((void*)P_1, ((Authenticator)Unsafe.AsPointer(ref this)).ListenAsync());
					obj2 = 3;
					break;
				case 1:
					*(int*)(nint)/*Error near IL_0082: Stack underflow*/ = (int)((Authenticator)P_0).ListenAuthenticationConnectAsync((object)Unsafe.AsPointer(ref this));
					obj2 = 0;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj2 = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_E500(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_006e: Expected Obj, but got Ref
			//IL_006f: Expected I4, but got Obj
			//IL_0057->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0062->IL0026: Incompatible stack types: I4 vs Obj
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
				case 1:
					if (!(P_0 is Authenticator._003CListenAuthenticationConnectAsync_003Ed__8))
					{
						return 0;
					}
					obj2 = 0;
					if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 0;
					}
					break;
				default:
					return (byte)(int)((Authenticator)Unsafe.AsPointer(ref this)).ListenAuthenticationConnectAsync((object)(FeverInstaller)P_0);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_E600(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778900, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_E700()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_E800(TaskKey P_0, TaskKey P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778899, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_E900(TaskKey P_0, TaskKey P_1)
		{
			//IL_001c: Expected Obj, but got VT
			//IL_001d: Expected I4, but got Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			_ = ref P_0;
			return (byte)(int)((Authenticator)P_1).Listener;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_EA00(TaskKey P_0, TaskKey P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778898, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_EB00(TaskKey P_0, TaskKey P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778897, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_EC00(TaskKey P_0, TaskKey P_1)
		{
			//IL_001b: Expected Obj, but got VT
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (((Authenticator)P_1).Listener == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_ED00(TaskKey P_0, TaskKey P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778896, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_EE00(JavaStep P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
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
					((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state = (int)P_0;
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
		internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_EF00(JavaStep P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778895, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_F000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778894, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_F100()
		{
			//IL_001b: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_F200()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778893, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_F300(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected I4, but got Obj
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
					((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state = (int)P_0;
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
		internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_F400(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778892, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_F500()
		{
			//IL_0029: Expected Obj, but got I
			//IL_0058: Expected I, but got Obj
			//IL_0051: Expected Obj, but got I
			nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 3530, 1790778891, 0, 0);
			object obj = num;
			if (num == 0)
			{
				obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778891, new IntPtr(2737337581404L), 15);
			}
			return ((delegate*<nint, object>)obj)((nint)Unsafe.AsPointer(ref this));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_F800(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778890, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00豈(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0047: Expected I4, but got Obj
			//IL_00f7: Expected native int or pointer, but got Obj
			//IL_007e: Expected Obj, but got Ref
			//IL_0092: Expected Obj, but got VT
			//IL_00b3: Expected native int or pointer, but got Obj
			//IL_0057: Expected I, but got Obj
			//IL_0062: Expected native int or pointer, but got Obj
			//IL_0101->IL0026: Incompatible stack types: I4 vs Obj
			//IL_009d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00bd->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0132->IL0026: Incompatible stack heights: 3 vs 1
			//IL_00de->IL0026: Incompatible stack types: I4 vs Obj
			//IL_010c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00c8->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0077->IL0026: Incompatible stack types: I4 vs Obj
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
				case 3:
					((Func<Task>)/*Error near IL_0057: Stack underflow*/)._002Ector((object)/*Error near IL_0057: Stack underflow*/, (nint)((Authenticator)P_0).Listener);
					obj2 = 0;
					if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj2 = 0;
					}
					break;
				case 1:
					obj = ((Authenticator)P_0).ListenAuthenticationConnectAsync((object)Unsafe.AsPointer(ref this));
					_ = ref obj;
					GC.SuppressFinalize(((AsyncTaskMethodBuilder)TcpListener/*cast due to constrained. prefix*/).Create());
					obj2 = 3;
					break;
				case 2:
					((IAsyncStateMachine)((Authenticator)/*Error near IL_00a3: Stack underflow*/).HandleAuthentication((string)P_0)).MoveNext();
					obj2 = 1;
					if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state == 0)
					{
						obj2 = 1;
					}
					break;
				case 5:
					((Authenticator._003CListenAsync_003Ed__7*)/*Error near IL_00ce: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)P_0);
					((TaskAwaiter*)/*Error near IL_00d3: Stack underflow*/)->GetResult();
					obj2 = 4;
					break;
				case 6:
					return 1;
				default:
					Unsafe.As<TaskKey, AsyncTaskMethodBuilder>(ref this).SetException((Exception)Authenticator._003CListenAsync_003Ed__7.ObserveTracker());
					obj2 = 5;
					if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain)->_003C_003E1__state == 0)
					{
						obj2 = 1;
					}
					break;
				case 4:
					obj = Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.ReflectRandomReporter();
					((TcpListener)(object)(*(ComponentPath*)(&obj))/*cast due to constrained. prefix*/).AcceptTcpClientAsync().GetAwaiter();
					_ = 6;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00切(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778889, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00ﬀ()
		{
			//IL_0024: Expected Obj, but got VT
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected Obj, but got Unknown
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected I4, but got Unknown
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			((ILogger)/*Error near IL_0019: Stack underflow*/).Debug<_0021_00210>((string)/*Error near IL_0019: Stack underflow*/, (_0021_00210)/*Error near IL_0019: Stack underflow*/);
			((TcpListener)(Task.Run((Func<Task?>)((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Et__builder) * -1521134295)).Start();
			_003F val = (/*Error near IL_003b: Stack underflow*/ + ((AsyncTaskMethodBuilder*)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->Task) * -1521134295;
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this).listener.Dispose();
			return (uint)(val + asyncTaskMethodBuilder);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00ﰀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778888, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (uint)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe EnumGameVersion _FF00_FF00_FF00_FF00_FF00_FF00ﴀ()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (EnumGameVersion)((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe EnumGameVersion _FF00_FF00_FF00_FF00_FF00_FF00_FE00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778887, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (EnumGameVersion)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00(TaskKey P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778886, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ā(TaskKey P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_003f: Expected I4, but got Obj
			//IL_00c8: Expected I4, but got VT
			//IL_00ef: Expected native int or pointer, but got Obj
			//IL_0083->IL00b1: Incompatible stack heights: 2 vs 0
			//IL_008d->IL0026: Incompatible stack heights: 3 vs 1
			//IL_00f9->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0104->IL0026: Incompatible stack types: I4 vs Obj
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
					Task.Run((Func<Task?>)/*Error near IL_006d: Stack underflow*/);
					_ = ((Authenticator._003CListenAsync_003Ed__7)this)._003C_003Eu__1;
					if (((AsyncTaskMethodBuilder*)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->Task == null)
					{
						_ = 3;
						break;
					}
					goto case 4;
				case 4:
					((TcpListener)/*Error near IL_00b6: Stack underflow*/).Dispose();
					_ = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003Eu__1;
					return (byte)(int)((Task)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler).GetAwaiter();
				case 1:
				case 3:
					return 0;
				case 2:
					((AsyncTaskMethodBuilder*)/*Error near IL_00cf: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)/*Error near IL_00cf: Stack underflow*/, ref *(TStateMachine*)/*Error near IL_00cf: Stack underflow*/);
					((AsyncTaskMethodBuilder*)((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003E4__this)->SetException((Exception)(object)((Authenticator._003CReceiveAsync_003Ed__9*)(&P_0))->client);
					if ((int)/*Error near IL_00e5: Stack underflow*/ == 0)
					{
						obj2 = 1;
						if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain)->_003C_003E1__state == 0)
						{
							obj2 = 1;
						}
						break;
					}
					goto default;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ȁ(TaskKey P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778885, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0300(EnumGameVersion P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778884, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ѐ(EnumGameVersion P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
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
					((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state = (int)P_0;
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
		internal unsafe JavaStep _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ԁ()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (JavaStep)((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe JavaStep _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0600()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778883, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (JavaStep)/*Error near IL_0033: Stack underflow*/;
		}
	}

	private sealed class TaskEntry
	{
		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CWaitAsync_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public TaskEntry _003C_003E4__this;

			public CancellationToken callerToken;

			private object _003C_003E7__wrap1;

			private nint _003C_003E7__wrap2;

			private TaskAwaiter _003C_003Eu__1;

			private static object AssetCalc;

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
			internal static bool DeleteTree()
			{
				throw new Exception("Error, DNGuard Runtime library not loaded!");
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object CheckInterruptibleHandler()
			{
				throw new Exception("Error, DNGuard Runtime library not loaded!");
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00쐀(object P_0)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778935, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00씀(object P_0)
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
			internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00였()
			{
				//IL_001a: Expected Obj, but got I4
				((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
				if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
				{
				}
				return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00윀()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778934, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
				return (object)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00저()
			{
				//IL_001d: Expected Obj, but got I4
				//IL_0043: Expected I4, but got Obj
				//IL_078c: Expected Obj, but got Ref
				//IL_078e: Expected Obj, but got I
				//IL_079d: Expected Obj, but got I
				//IL_074f: Expected Obj, but got Ref
				//IL_0751: Expected Obj, but got I
				//IL_0760: Expected Obj, but got I
				//IL_0777: Expected Obj, but got Ref
				//IL_077c: Expected Obj, but got Ref
				//IL_0692: Expected native int or pointer, but got Obj
				//IL_0167: Expected native int or pointer, but got Obj
				//IL_0178: Expected Obj, but got I4
				//IL_0523: Expected Obj, but got Ref
				//IL_0572: Expected VT, but got I4
				//IL_04e2: Expected Obj, but got I4
				//IL_04e7: Expected Obj, but got Ref
				//IL_01a9: Expected native int or pointer, but got Obj
				//IL_0114: Expected Obj, but got Ref
				//IL_01e4: Expected native int or pointer, but got Obj
				//IL_01ee: Expected Obj, but got I
				//IL_050c: Expected Obj, but got Ref
				//IL_04ce: Expected Obj, but got I4
				//IL_04d3: Expected Obj, but got Ref
				//IL_0137: Expected I4, but got Obj
				//IL_0532: Expected native int or pointer, but got Obj
				//IL_03a1: Expected Ref, but got VT
				//IL_04b9: Expected Obj, but got I
				//IL_05a9: Expected Obj, but got I4
				//IL_01fd: Expected native int or pointer, but got Obj
				//IL_030b: Expected Obj, but got VT
				//IL_0314: Expected Obj, but got I4
				//IL_036b: Expected Obj, but got I4
				//IL_0370: Expected Obj, but got I4
				//IL_02aa: Expected Obj, but got Ref
				//IL_02bb: Expected Obj, but got Ref
				//IL_03cc: Expected Obj, but got I4
				//IL_028e: Expected I4, but got Obj
				//IL_07a2->IL0026: Incompatible stack types: I4 vs Obj
				//IL_0765->IL0026: Incompatible stack types: I4 vs Obj
				//IL_0786->IL0026: Incompatible stack heights: 2 vs 1
				//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
				//IL_07ad->IL0026: Incompatible stack types: I4 vs Obj
				//IL_0770->IL0026: Incompatible stack types: I4 vs Obj
				//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
				//IL_03bc->IL0255: Incompatible stack types: I4 vs Obj
				//IL_0251->IL0255: Incompatible stack types: I4 vs Obj
				//IL_05b3->IL00af: Incompatible stack heights: 2 vs 1
				//IL_03c7->IL0255: Incompatible stack types: I4 vs Obj
				//IL_033b->IL0255: Incompatible stack heights: 2 vs 1
				//IL_0384->IL0255: Incompatible stack types: I4 vs Obj
				//IL_03f1->IL0255: Incompatible stack types: I4 vs Obj
				//IL_0366->IL0255: Incompatible stack types: I4 vs Obj
				//IL_02b4->IL0255: Incompatible stack types: I4 vs Obj
				//IL_03db->IL0255: Incompatible stack types: I4 vs Obj
				//IL_0346->IL0255: Incompatible stack heights: 2 vs 1
				//IL_038f->IL0255: Incompatible stack types: I4 vs Obj
				//IL_02d4->IL0255: Incompatible stack types: I4 vs Obj
				//IL_02df->IL0255: Incompatible stack types: I4 vs Obj
				((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
				if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
				{
				}
				object awaiter = 1;
				object obj = awaiter;
				while (true)
				{
					switch ((int)obj)
					{
					case 5:
						((Authenticator._003CListenAsync_003Ed__7)this)._003C_003E1__state = -2;
						obj = 0;
						if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
						{
							obj = 2;
						}
						break;
					case 3:
					{
						_ = 1;
						int num = 2;
						while (true)
						{
							int num2;
							switch (num)
							{
							case 1:
								if (awaiter != null)
								{
									num2 = 18;
									goto IL_00af;
								}
								goto IL_057c;
							case 2:
								{
									num = 1;
									if (((Rpc._003CSyncChaChaAsync_003Ed__38*)(nint)Rpc._003CRemoteCallBackAsync_003Ed__21.MeasureCalc)->_003C_003E1__state == 0)
									{
										num = 1;
									}
									continue;
								}
								IL_057c:
								num2 = 2;
								goto IL_00af;
								IL_00af:
								while (true)
								{
									object obj2;
									switch (num2)
									{
									case 3:
										break;
									case 10:
									case 13:
										((TcpListener)(&awaiter)).Start();
										num2 = 7;
										continue;
									case 20:
										Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton = awaiter;
										num2 = 9;
										continue;
									case 17:
										((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)this)._003C_003E1__state = (int)null;
										num2 = 3;
										continue;
									case 19:
										return;
									default:
										((IAsyncStateMachine)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)awaiter)->_003C_003E4__this).MoveNext();
										awaiter = ((TaskAwaiter*)/*Error near IL_0176: Stack underflow*/)->IsCompleted;
										num2 = 1;
										if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder != 0)
										{
											num2 = 1;
										}
										continue;
									case 8:
										awaiter = ((Authenticator._003CReceiveAsync_003Ed__9)this)._003C_003E4__this;
										num2 = 15;
										if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9.client)->_003C_003Eu__1 == 0)
										{
											num2 = 9;
										}
										continue;
									case 18:
										if ((nint)awaiter != 1)
										{
											num2 = 4;
											continue;
										}
										goto case 8;
									case 14:
										awaiter = Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain;
										num2 = 6;
										continue;
									case 11:
										((AsyncTaskMethodBuilder*)/*Error near IL_01ee: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)(&((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)awaiter)->_003C_003E1__state));
										if ((int)/*Error near IL_01f3: Stack underflow*/ == 0)
										{
											num2 = 0;
											if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.client)->_003C_003E4__this == null)
											{
												num2 = 0;
											}
											continue;
										}
										goto IL_0587;
									case 9:
										Unsafe.As<object, AsyncTaskMethodBuilder>(ref ((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)this)._003Cstream_003E5__2).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<EntityFeverAppVersion>*)(&awaiter), ref Unsafe.As<_003CWaitAsync_003Ed__9, FeverInstaller._003CInstallAsync_003Ed__11>(ref this));
										num2 = 19;
										if (((FeverInstaller)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway)._003CfeverVersion_003EP != null)
										{
											num2 = 1;
										}
										continue;
									case 2:
										if (awaiter == null)
										{
											obj2 = 9;
											goto IL_0255;
										}
										goto IL_038f;
									case 6:
										if ((nint)awaiter == 1)
										{
											num2 = 11;
											if (((Rpc)Rpc.ProcessId__BackingField).Logger__BackingField == null)
											{
												num2 = 9;
											}
											continue;
										}
										goto case 17;
									case 16:
										awaiter = -1;
										((Rpc)Unsafe.AsPointer(ref this)).NeedCha__BackingField = -1;
										num2 = 10;
										continue;
									case 5:
										awaiter = 1;
										((Rpc)Unsafe.AsPointer(ref this)).UseCha__BackingField = 1;
										num2 = 20;
										if (((Rpc)(object)Rpc.Callbacks__BackingField).Writer__BackingField == null)
										{
											num2 = 2;
										}
										continue;
									case 15:
										Unsafe.As<object?, EnumGameVersion>(ref ((Rpc)Unsafe.AsPointer(ref this)).Listener__BackingField) = default;
										num2 = 16;
										continue;
									case 1:
										((AsyncTaskMethodBuilder<EntityFeverAppVersion>*)/*Error near IL_0523: Stack underflow*/)->SetResult((EntityFeverAppVersion)(&awaiter));
										if ((int)/*Error near IL_0528: Stack underflow*/ != 0)
										{
											num2 = 13;
											if (((Rpc._003CListenAsync_003Ed__34*)(nint)Rpc.ParseMap)->_003C_003E1__state != 0)
											{
												num2 = 8;
											}
											continue;
										}
										goto case 5;
									case 4:
										((Rpc._003CListenAsync_003Ed__34)this)._003C_003Eu__1 = (TaskAwaiter)0;
										num2 = 12;
										continue;
									case 12:
										goto end_IL_00af;
									case 7:
										goto IL_0587;
										IL_038f:
										((FeverInstaller._003CFeverRequest_003Ed__15<>*)/*Error near IL_0396: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)awaiter);
										((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)/*Error near IL_03a6: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)((FeverInstaller._003CGetFeverManifestAsync_003Ed__12)this)._003C_003Et__builder)->Task);
										awaiter = (object)/*Error near IL_03a8: Stack underflow*/;
										obj2 = 10;
										if (FeverInstaller._003CGetFeverManifestAsync_003Ed__12.ReflectReporter == null)
										{
											obj2 = 1;
										}
										goto IL_0255;
										IL_0255:
										while (true)
										{
											switch ((int)obj2)
											{
											case 12:
												break;
											case 8:
												((FeverInstaller)Unsafe.AsPointer(ref this))._003CappId_003EP = awaiter;
												obj2 = 2;
												continue;
											case 10:
												if (((TcpClient)(&awaiter)).GetStream() != null)
												{
													obj2 = 0;
													if (((FeverInstaller)FeverInstaller.McBedrock__BackingField).Client__BackingField == null)
													{
														obj2 = 1;
													}
													continue;
												}
												goto case 3;
											case 7:
												return;
											default:
												awaiter = ((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003Et__builder;
												awaiter = 4;
												obj2 = awaiter;
												continue;
											case 2:
												_ = ref ((FeverInstaller._003CFeverRequest_003Ed__15<>)this)._003C_003E4__this;
												((AsyncTaskMethodBuilder*)(&awaiter))->Start(ref Unsafe.As<_003CWaitAsync_003Ed__9, Rpc._003CListenAsync_003Ed__34>(ref this));
												_ = 7;
												if (((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003Eu__1)._003C_003E1__state != 0)
												{
													_ = 2;
												}
												continue;
											case 1:
											case 5:
												((RestClient)/*Error near IL_035c: Stack underflow*/)._002Ector((RestClientOptions)/*Error near IL_035c: Stack underflow*/, (ConfigureHeaders)/*Error near IL_035c: Stack underflow*/, (ConfigureSerialization)/*Error near IL_035c: Stack underflow*/, (byte)(&awaiter) != 0);
												obj2 = 12;
												continue;
											case 3:
												awaiter = 0;
												((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14)this)._003C_003E4__this = (FeverInstaller)0;
												obj2 = 6;
												if (FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14.CheckBasicEncryptor != null)
												{
													obj2 = 8;
												}
												continue;
											case 6:
												goto IL_038f;
											case 11:
												awaiter = -1;
												((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003E1__state = -1;
												obj2 = 5;
												continue;
											case 4:
												Unsafe.As<AsyncTaskMethodBuilder<EntityFeverManifestInfo>, @null>(ref ((FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13)this)._003C_003Et__builder) = null;
												obj2 = 11;
												continue;
											}
											break;
										}
										goto case 14;
									}
									goto end_IL_0083;
									IL_0587:
									object obj3 = Rpc._003CListenAsync_003Ed__34.DecorateIterableWriter;
									((Task<RestResponse<EntityFeverManifest>>)((TaskAwaiter<RestResponse<EntityFeverManifest>>*)(((obj3 is EnumItemMasterType) ? obj3 : null) ?? throw ((Rpc._003CListenControlConnectAsync_003Ed__35)this)._003C_003Et__builder))->IsCompleted).GetAwaiter();
									_ = 17;
									continue;
									end_IL_00af:
									break;
								}
								goto IL_057c;
								end_IL_0083:
								break;
							}
							break;
						}
						goto case 5;
					}
					case 1:
						awaiter = ((JavaGameValue)Unsafe.AsPointer(ref this)).Reconnect__BackingField;
						obj = 0;
						if (((JavaGameValue)JavaGameValue.ReconnectDelay__BackingField).SaveOptions__BackingField == 0)
						{
							obj = 0;
						}
						break;
					case 4:
						return;
					case 2:
						Enumerable.Concat<TSource>((IEnumerable<TSource>)/*Error near IL_077c: Stack underflow*/, (IEnumerable<TSource>)Unsafe.AsPointer(ref ((JavaGameValue)Unsafe.AsPointer(ref this)).SetChinese__BackingField));
						_ = 4;
						break;
					default:
						awaiter = ((JavaGameValue)Unsafe.AsPointer(ref this)).GuiScale__BackingField;
						obj = 1;
						if (((JavaGameValue)JavaGameValue.SetSize__BackingField).WindowWidth__BackingField == 0)
						{
							obj = 3;
						}
						break;
					}
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00준()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778933, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00쨀()
			{
				((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
				if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
				{
				}
				return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00쬀()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778932, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
				return (byte)/*Error near IL_0033: Stack underflow*/;
			}
		}

		private readonly object _internalCts;

		private nint _waiterCount;

		private object? _sourceGame;

		private nint _progressBound;

		internal static object DecorateVisibleTracker;

		public Task Task
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (Task)_FF00_FF00_FF00_FF00_FF00_FF00_E000();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe TaskEntry(Task task, CancellationTokenSource cts)
		{
			//IL_001b: Expected I4, but got Obj
			//IL_0016: Expected native int or pointer, but got Obj
			//IL_0027: Expected VT, but got Obj
			//IL_0022: Expected native int or pointer, but got Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state = (int)task;
			Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Et__builder, (AsyncTaskMethodBuilder)cts);
			System.Threading.Tasks.Task.Run((Func<Task?>)(object)this);
			int num = 0;
			if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton == null)
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
		public Task AttachCaller(CancellationToken callerToken)
		{
			return (Task)_FF00_FF00_FF00_FF00_FF00_FF00혀(callerToken);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(_003CWaitAsync_003Ed__9))]
		private object WaitAsync(CancellationToken callerToken)
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FFFD(callerToken);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BindProgress(JavaGame target, JavaStep step)
		{
			_FF00_FF00_FF00_FF00_FF00_FF00픀(target, step);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ReflectCentralFinalizer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskEntry ReflectStatelessAggregator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00퐀(object P_0, JavaStep P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778882, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00픀(object P_0, JavaStep P_1)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0063: Expected I4, but got Obj
			//IL_0221: Expected I4, but got Obj
			//IL_021c: Expected native int or pointer, but got Obj
			//IL_0151: Expected native int or pointer, but got Obj
			//IL_00b4: Expected native int or pointer, but got Obj
			//IL_00b9: Expected native int or pointer, but got Obj
			//IL_00c7: Expected Obj, but got I4
			//IL_0175: Expected native int or pointer, but got Obj
			//IL_017f: Expected VT, but got Obj
			//IL_017a: Expected native int or pointer, but got Obj
			//IL_007b: Expected native int or pointer, but got Obj
			//IL_0092: Expected Obj, but got I
			//IL_012f: Expected Obj, but got I4
			//IL_012a: Expected native int or pointer, but got Obj
			//IL_00ce: Expected native int or pointer, but got Obj
			//IL_0112: Expected native int or pointer, but got Obj
			//IL_0168: Expected Obj, but got I4
			//IL_0163: Expected native int or pointer, but got Obj
			//IL_01dd: Expected native int or pointer, but got Obj
			//IL_00e2: Expected native int or pointer, but got Obj
			//IL_01f0: Expected Obj, but got I4
			//IL_022b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0160->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0079->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0193->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01d0->IL0026: Incompatible stack heights: 4 vs 1
			//IL_00a6->IL0026: Incompatible stack heights: 4 vs 1
			//IL_0143->IL0026: Incompatible stack types: I4 vs Obj
			//IL_019e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_011c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0172->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01db->IL0026: Incompatible stack heights: 4 vs 1
			//IL_00b1->IL0026: Incompatible stack heights: 4 vs 1
			//IL_014e->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ec->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0127->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00f7->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					default:
						return;
					case 4:
						obj = new Authenticator();
						obj2 = 3;
						continue;
					case 11:
						_ = ((Authenticator._003CListenAsync_003Ed__7*)(nint)obj)->_003C_003Et__builder;
						((Authenticator)__ldftn(Authenticator.StartListening)).ListenAuthenticationConnectAsync((object)new TcpListener());
						_ = 0;
						if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder == 0)
						{
							_ = 10;
						}
						continue;
					case 5:
						Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003E4__this, ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)obj)->listener);
						obj = 2;
						break;
					case 13:
						return;
					case 9:
						return;
					case 7:
						((Authenticator._003CListenAsync_003Ed__7*)/*Error near IL_00fe: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)(object)this);
						((TaskAwaiter*)/*Error near IL_0103: Stack underflow*/)->GetResult();
						if ((int)/*Error near IL_0108: Stack underflow*/ == 0)
						{
							if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003Eu__1 == 0)
							{
								obj2 = 2;
								if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state == 0)
								{
									obj2 = 5;
								}
								continue;
							}
							if (((FeverInstaller._003CFeverRequest_003Ed__15<>*)(nint)this)->_003C_003E4__this != null)
							{
								return;
							}
							obj = 8;
							break;
						}
						obj2 = 13;
						if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9.client)->_003C_003Eu__1 == 0)
						{
							obj2 = 13;
						}
						continue;
					case 12:
						Unsafe.Write(&Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain, (object)P_1);
						obj2 = 1;
						if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003E1__state)->_003C_003Et__builder != 0)
						{
							obj2 = 1;
						}
						continue;
					case 3:
						Unsafe.Write(&((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)obj)->client, this);
						obj2 = 12;
						continue;
					case 0:
						return;
					case 8:
						Unsafe.Write(&((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->_003C_003E4__this, (Authenticator)1);
						obj2 = 6;
						continue;
					case 6:
						Unsafe.Write(&((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)obj)->_003C_003Eu__1, (TaskAwaiter<string>)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)this)->_003Cstream_003E5__2);
						obj2 = 11;
						if (((FeverInstaller)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway)._003CfeverVersion_003EP != null)
						{
							obj2 = 10;
						}
						continue;
					case 10:
						Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.DecorateFlexibleProfiler();
						((TcpClient)new Task<string>()).Close();
						((TaskAwaiter<string>*)(delegate*<object>)(&Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.HandleNotifier))->GetResult();
						_ = 5;
						if ((int)((FeverInstaller._003CFeverRequest_003Ed__15<>*)FeverInstaller._003CFeverRequest_003Ed__15<>._003C_003E1__state)->_003C_003Et__builder != 0)
						{
							_ = 9;
						}
						continue;
					case 2:
						return;
					case 1:
						((FeverInstaller._003CGetFeverAppVersionAsync_003Ed__14*)(nint)obj)->_003C_003E1__state = (int)P_0;
						obj2 = 7;
						continue;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00혀(CancellationToken P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_003f: Expected I4, but got Obj
			//IL_0059: Expected I4, but got Obj
			//IL_009b: Expected Obj, but got Ref
			//IL_005b: Expected native int or pointer, but got Obj
			//IL_00c4: Expected native int or pointer, but got Obj
			//IL_0052: Expected Obj, but got VT
			//IL_007a->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ce->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00aa->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0085->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00d9->IL0026: Incompatible stack types: I4 vs Obj
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
				case 4:
					return ((Authenticator)this).Listener;
				case 3:
					((Authenticator)this).Listener = (TcpListener?)P_0;
					return (object)/*Error near IL_0053: Stack underflow*/;
				default:
					((Authenticator)/*Error near IL_0059: Stack underflow*/).StartListening((int)this);
					return (object)/*Error near IL_005a: Stack underflow*/;
				case 2:
					GC.SuppressFinalize((object)(&P_0));
					if ((int)/*Error near IL_00a0: Stack underflow*/ != 0)
					{
						obj2 = 3;
						break;
					}
					goto case 4;
				case 1:
					((IAsyncStateMachine)((Authenticator)/*Error near IL_00b0: Stack underflow*/).HandleAuthentication((string)(object)this)).MoveNext();
					if ((int)/*Error near IL_00ba: Stack underflow*/ == 0)
					{
						((AsyncTaskMethodBuilder*)/*Error near IL_0065: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)(&((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003Eu__1));
						obj2 = 0;
						if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E1__state)->_003C_003Et__builder != 0)
						{
							obj2 = 2;
						}
					}
					else
					{
						obj2 = 0;
						if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)->_003C_003E1__state != 0)
						{
							obj2 = 0;
						}
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00휀(CancellationToken P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778881, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778880, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778943, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778942, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_001a: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778941, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FFFD(CancellationToken P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778940, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FFFD(CancellationToken P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0043: Expected I4, but got Obj
			//IL_00cb: Expected I4, but got Obj
			//IL_0088: Expected VT, but got Obj
			//IL_0092: Expected native int or pointer, but got Obj
			//IL_00f2: Expected Obj, but got VT
			//IL_00be: Expected Obj, but got I4
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00df->IL0026: Incompatible stack types: I4 vs Obj
			//IL_009c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0106->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00ea->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00a7->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0111->IL0026: Incompatible stack types: I4 vs Obj
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object stateMachine = 2;
			while (true)
			{
				object obj = stateMachine;
				while (true)
				{
					switch ((int)obj)
					{
					default:
						((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003E1__state = -1;
						obj = 1;
						if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
						{
							obj = 4;
						}
						continue;
					case 5:
						((AsyncTaskMethodBuilder*)/*Error near IL_007b: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)(&((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003Eu__1));
						return (object)/*Error near IL_007c: Stack underflow*/;
					case 2:
						Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)/*Error near IL_0088: Stack underflow*/)->_003C_003Et__builder, (AsyncTaskMethodBuilder)((AsyncTaskMethodBuilder*)(&stateMachine))->Task);
						obj = 1;
						if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
						{
							obj = 1;
						}
						continue;
					case 4:
						break;
					case 1:
						((Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine))->_003C_003E1__state = (int)this;
						obj = 3;
						if (((Authenticator._003CReceiveAsync_003Ed__9)Authenticator._003CReceiveAsync_003Ed__9._003C_003Et__builder)._003C_003E4__this != null)
						{
							obj = 2;
						}
						continue;
					case 3:
						((Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine))->client = (TcpClient)P_0;
						obj = 0;
						if (Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain != null)
						{
							obj = 0;
						}
						continue;
					}
					break;
				}
				((AsyncTaskMethodBuilder<_0021_00210>*)(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&stateMachine))->_003C_003Eu__1))->Start(ref *(FeverInstaller._003CFeverRequest_003Ed__15<_0021_00210>*)(&stateMachine));
				stateMachine = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_E000()
		{
			//IL_0015: Expected native int or pointer, but got Obj
			//IL_001b: Expected Obj, but got I4
			((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return ((Authenticator._003CListenAsync_003Ed__7*)(nint)this)->_003C_003E1__state;
		}
	}

	private readonly ConcurrentDictionary<TaskKey, TaskEntry> _tasks;

	internal static JavaTask DecorateAccessibleTransformer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task CallPrepareJre(JavaGame game, CancellationToken cancellationToken = default(CancellationToken))
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00_FF00_FF00_0E00(game, cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task CallPrepareBaseVersion(JavaGame game, CancellationToken cancellationToken = default(CancellationToken))
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00_FF00_FF00ࠀ(game, cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task CallPrepareVersion(JavaGame game, CancellationToken cancellationToken = default(CancellationToken))
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00_FF00_FF00ጀ(game, cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task CallPrepareComponents(JavaGame game, CancellationToken cancellationToken = default(CancellationToken))
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00_FF00_FF00ᄀ(game, cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task CallPrepareServerResource(JavaGame game, CancellationToken cancellationToken = default(CancellationToken))
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00_FF00_FF00ᔀ(game, cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object Call(EnumGameVersion version, object id, JavaStep step, object caller, Func<CancellationToken, Task> factory, CancellationToken cancellationToken = default(CancellationToken))
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0A00(version, id, step, caller, factory, cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe JavaTask()
	{
		//IL_001a: Expected VT, but got Obj
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected VT, but got Unknown
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)/*Error near IL_001f: Stack underflow*/)->_003C_003Et__builder, (AsyncTaskMethodBuilder)new ILogger((string)/*Error near IL_001a: Stack underflow*/, (_0021_00210)this));
		Task.Run((Func<Task?>)(object)this);
		int num = 0;
		if (Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton != null)
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
	internal static bool DecorateIsolatedMap()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static JavaTask CheckAutomatableVisitor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0700(object P_0, CancellationToken P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778909, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ࠀ(object P_0, CancellationToken P_1)
	{
		//IL_0016: Expected native int or pointer, but got Obj
		//IL_004a: Expected Obj, but got VT
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		if ((uint)((Authenticator._003CListenAsync_003Ed__7*)(nint)P_0)->_003C_003E1__state > 1020000u)
		{
			_ = 1020006;
		}
		else
			_ = 0;
		_ = 2;
		__ldftn(Authenticator.StartListening);
		return ((Authenticator)new TcpListener()).ListenAuthenticationConnectAsync((object)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0900(object P_0, CancellationToken P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778908, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0A00(EnumGameVersion P_0, object P_1, JavaStep P_2, object P_3, Func<CancellationToken, Task> P_4, CancellationToken P_5)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_004c: Expected I4, but got Obj
		//IL_0047: Expected native int or pointer, but got Obj
		//IL_009a: Expected VT, but got Obj
		//IL_0095: Expected native int or pointer, but got Obj
		//IL_00a4: Expected native int or pointer, but got Obj
		//IL_007c: Expected native int or pointer, but got Obj
		//IL_00ba: Expected native int or pointer, but got Obj
		//IL_00c1: Expected native int or pointer, but got Obj
		//IL_00d8: Expected Ref, but got VT
		//IL_00e8: Expected Ref, but got VT
		//IL_00f3: Expected Obj, but got I4
		//IL_00f8: Expected I4, but got VT
		//IL_00f3: Expected native int or pointer, but got Obj
		//IL_0060->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ae->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0086->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0102->IL0026: Incompatible stack heights: 3 vs 1
		//IL_006b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0091->IL0026: Incompatible stack types: I4 vs Obj
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
				((Authenticator._003CListenAsync_003Ed__7*)(nint)obj)->_003C_003E1__state = (int)this;
				obj2 = 4;
				if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this == null)
				{
					obj2 = 4;
				}
				break;
			case 2:
				obj = new Authenticator();
				obj2 = 1;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state != 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)obj)->_003C_003Et__builder, (AsyncTaskMethodBuilder)P_4);
				obj2 = 0;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.listener)->_003C_003E4__this == null)
				{
					obj2 = 0;
				}
				break;
			case 3:
			{
				_ = ((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)this)->_003C_003Eu__1;
				_ = Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler;
				((TaskAwaiter*)new AsyncTaskMethodBuilder(ref *(TAwaiter*)obj, ref *(TStateMachine*)__ldftn(Authenticator._003CListenAsync_003Ed__7.MoveNext)))->GetResult();
				object result = Authenticator._003CListenAsync_003Ed__7.ObserveTracker();
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)P_5)->MoveNext();
				return result;
			}
			case 4:
				((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)P_1)->_003C_003E1__state = (int)new Authenticator._003CListenAuthenticationConnectAsync_003Ed__8((IAsyncStateMachine)P_2);
				_ = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0B00(EnumGameVersion P_0, object P_1, JavaStep P_2, object P_3, Func<CancellationToken, Task> P_4, CancellationToken P_5)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778907, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0C00()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0D00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778906, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0E00(object P_0, CancellationToken P_1)
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
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Default(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 93
		//    at ICSharpCode.Decompiler.IL.ILVisitor`1.VisitNewObj(NewObj inst) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 7823
		//    at ICSharpCode.Decompiler.IL.NewObj.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4574
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
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ༀ()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00က()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778905, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᄀ(object P_0, CancellationToken P_1)
	{
		//IL_0016: Expected native int or pointer, but got Obj
		//IL_001c: Expected native int or pointer, but got Obj
		//IL_0023: Invalid comparison between VT and I4
		//IL_002f: Expected native int or pointer, but got Obj
		//IL_0048: Expected Obj, but got VT
		//IL_0048: Expected Obj, but got VT
		//IL_002e->IL0034: Incompatible stack heights: 2 vs 3
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		_ = ((Authenticator._003CListenAsync_003Ed__7*)(nint)P_0)->_003C_003E1__state;
		if (((Authenticator._003CListenAsync_003Ed__7*)(nint)P_0)->_003C_003Et__builder == (AsyncTaskMethodBuilder)(object)9)
		{
			_ = ((Authenticator._003CListenAsync_003Ed__7*)(nint)P_0)->_003C_003Eu__1;
		}
		_ = 5;
		__ldftn(Authenticator.ListenAuthenticationConnectAsync);
		return ((Authenticator)(object)new AsyncTaskMethodBuilder()).ReceiveAuthenticationDataAsync((object)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ሀ(object P_0, CancellationToken P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778904, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ጀ(object P_0, CancellationToken P_1)
	{
		//IL_0016: Expected native int or pointer, but got Obj
		//IL_0030: Expected Obj, but got VT
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		_ = ((Authenticator._003CListenAsync_003Ed__7*)(nint)P_0)->_003C_003E1__state;
		_ = 3;
		__ldftn(Authenticator.StartListening);
		return ((Authenticator)new TcpListener()).ListenAuthenticationConnectAsync((object)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_1400(object P_0, CancellationToken P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778903, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᔀ(object P_0, CancellationToken P_1)
	{
		//IL_0016: Expected native int or pointer, but got Obj
		//IL_001c: Expected native int or pointer, but got Obj
		//IL_0035: Expected Obj, but got VT
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		_ = ((Authenticator._003CListenAsync_003Ed__7*)(nint)P_0)->_003C_003E1__state;
		_ = ((Authenticator._003CListenAsync_003Ed__7*)(nint)P_0)->_003C_003Et__builder;
		_ = 6;
		__ldftn(Authenticator.StartListening);
		return ((Authenticator)new TcpListener()).ListenAuthenticationConnectAsync((object)P_1);
	}
}
