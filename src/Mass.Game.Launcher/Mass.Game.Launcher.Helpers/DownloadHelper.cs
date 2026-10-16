using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Mass.Common.Extensions;
using Mass.Game.Launcher.Entities.Fever;
using RestSharp;
using Serilog;

namespace Mass.Game.Launcher.Helpers;

public static class DownloadHelper
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDownloadAllAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Action<int> progress;

		public List<(string url, string path)> downloadList;

		private object _003C_003E8__1;

		public int maxConcurrency;

		public CancellationToken cancellationToken;

		private List<(string url, string path)>.Enumerator _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		private static object AssetProvider;

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
		internal unsafe static bool ReflectOrderedList()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777801, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object CompressTree()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777800, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00혀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777799, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00휀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777798, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777797, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777796, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777795, new IntPtr(2737367927564L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777794, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777793, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDownloadAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string url;

		public string destinationPath;

		public Action<int> progress;

		public int maxConcurrency;

		public CancellationToken cancellationToken;

		private object _003Cclient_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		internal static object ReflectScopeContext;

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
		internal unsafe static bool DecorateStaticMapper()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777854, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object ReflectDynamicPolicy()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777853, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00촀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777852, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00츀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777851, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00케(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777850, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00퀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777849, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00턀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777848, new IntPtr(2737367929644L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00툀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777847, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00팀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777846, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00퐀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777845, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00픀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777844, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDownloadAsync_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string destinationPath;

		public string url;

		public HttpClient httpClient;

		public CancellationToken cancellationToken;

		public int maxConcurrency;

		public Action<int> progress;

		private object _003CheadReq_003E5__2;

		private object _003CheadResp_003E5__3;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		internal static object DecorateConcreteRequester;

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
		internal unsafe static bool QueryConnection()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777841, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object ReflectAlphabeticEvent()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777840, new IntPtr(2737367925484L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00쐀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777839, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00씀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777838, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00였()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777837, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00윀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777836, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00쨀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777835, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00쬀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777834, new IntPtr(2737367920284L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00찀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777833, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSafeMultiSegmentDownloadAsync_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CancellationToken ct;

		public string url;

		public HttpClient httpClient;

		public Action<int> progress;

		public long totalSize;

		private object _003C_003E8__1;

		public string path;

		public int maxConcurrency;

		private object _003CprobeReq_003E5__2;

		private object _003CprobeResp_003E5__3;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private static object DecorateEditableWrapper;

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
		internal unsafe static bool CheckLogicalProcessor()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777830, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object ReflectSimpleContainer()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777829, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00먀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777828, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00묀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777827, new IntPtr(2737367929644L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00밀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777826, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00봀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777825, new IntPtr(2737367924444L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00븀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777824, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00쀀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777759, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00섀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777758, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00숀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777757, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00쌀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777756, new IntPtr(2737367928604L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSingleDownloadAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HttpClient httpClient;

		public string url;

		public CancellationToken ct;

		public string path;

		public Action<int> progress;

		private object _003Cresp_003E5__2;

		private long _003Ctotal_003E5__3;

		private long _003Cread_003E5__4;

		private object _003Cinput_003E5__5;

		private object _003Coutput_003E5__6;

		private object _003Cbuffer_003E5__7;

		private object _003Csw_003E5__8;

		private nint _003ClastReported_003E5__9;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<Stream> _003C_003Eu__2;

		private object _003C_003E7__wrap9;

		private nint _003C_003E7__wrap10;

		private object _003C_003E7__wrap11;

		private nint _003C_003E7__wrap12;

		private nint _003Cn_003E5__14;

		private ValueTaskAwaiter<int> _003C_003Eu__3;

		private ValueTaskAwaiter _003C_003Eu__4;

		private static object DecorateControllableConverter;

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
		internal unsafe static bool CheckTransferableVerifier()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777753, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object CheckResponsiveAnnotation()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777752, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00눀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777751, new IntPtr(2737367929644L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00대(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777750, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00됀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777749, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00딀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777748, new IntPtr(2737367920284L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00똀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777747, new IntPtr(2737367924444L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00뜀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777746, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00렀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777745, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00뤀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777744, new IntPtr(2737367928604L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[CompilerGenerated]
	private static readonly object Logger__BackingField;

	internal static DownloadHelper DetachCollection;

	private static ILogger Logger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDownloadAllAsync_003Ed__3))]
	public static Task DownloadAllAsync(List<(string url, string path)> downloadList, Action<int>? progress = null, int maxConcurrency = 4, CancellationToken cancellationToken = default(CancellationToken))
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00堀(downloadList, progress, (uint)maxConcurrency, cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDownloadAsync_003Ed__4))]
	public static Task DownloadAsync(string url, string destinationPath, Action<int>? progress = null, int maxConcurrency = 4, CancellationToken cancellationToken = default(CancellationToken))
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00娀(url, destinationPath, progress, (uint)maxConcurrency, cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDownloadAsync_003Ed__5))]
	public static Task DownloadAsync(HttpClient httpClient, string url, string destinationPath, Action<int>? progress = null, int maxConcurrency = 4, CancellationToken cancellationToken = default(CancellationToken))
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00嘀(httpClient, url, destinationPath, progress, (uint)maxConcurrency, cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSafeMultiSegmentDownloadAsync_003Ed__6))]
	private static object SafeMultiSegmentDownloadAsync(object httpClient, object url, object path, long totalSize, Action<int>? progress, uint maxConcurrency, CancellationToken ct)
	{
		return _FF00_FF00_FF00_FF00_FF00一(httpClient, url, path, totalSize, progress, maxConcurrency, ct);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSingleDownloadAsync_003Ed__7))]
	private static object SingleDownloadAsync(object httpClient, object url, object path, Action<int>? progress, CancellationToken ct)
	{
		return _FF00_FF00_FF00_FF00_FF00匀(httpClient, url, path, progress, ct);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object CalculateRanges(uint segments, long total)
	{
		return _FF00_FF00_FF00_FF00_FF00儀(segments, total);
	}

	static DownloadHelper()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_001f: Expected I4, but got Obj
		//IL_004c->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0057->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
				Logger__BackingField = Log.Logger.Category((string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00唀());
				obj2 = 0;
				if (_003CModule_003E_007B8336717d_002D71de_002D47ce_002Dbc69_002D4d75223ebc5e_007D.m_d836f3f9b6194f49a23d85cb66f28ddf.m_37cf582f2207428eb3a5e0db0b876fea == 0)
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
	internal static bool GetProfile()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DownloadHelper CheckCentralRunner()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00䴀(object P_0, object P_1, object P_2, long P_3, Action<int> P_4, uint P_5, CancellationToken P_6)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777405, new IntPtr(2737367929644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00一(object P_0, object P_1, object P_2, long P_3, Action<int> P_4, uint P_5, CancellationToken P_6)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0057: Expected I4, but got Obj
		//IL_00f4: Expected I4, but got I8
		//IL_00e2: Expected Obj, but got VT
		//IL_0077: Expected VT, but got Obj
		//IL_0088: Expected Obj, but got Ref
		//IL_008d: Expected VT, but got Obj
		//IL_0097: Expected native int or pointer, but got Obj
		//IL_016b: Expected Obj, but got I4
		//IL_0065: Expected I4, but got Obj
		//IL_0178: Expected Obj, but got I4
		//IL_00c4: Expected native int or pointer, but got Obj
		//IL_00fe->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ec->IL0026: Incompatible stack types: I4 vs Obj
		//IL_014f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0127->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0081->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_006f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_018c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ce->IL0026: Incompatible stack types: I4 vs Obj
		//IL_015a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0132->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ac->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0197->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d9->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 6;
		while (true)
		{
			object obj = stateMachine;
			while (true)
			{
				switch ((int)obj)
				{
				case 8:
					((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003E1__state = (int)P_4;
					obj = 2;
					continue;
				case 5:
					((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003Et__builder = (AsyncTaskMethodBuilder)P_0;
					obj = 7;
					continue;
				case 6:
					Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)/*Error near IL_008d: Stack underflow*/)->_003C_003Eu__1, (TaskAwaiter)Task.Run((Func<Task?>)(&stateMachine)));
					obj = 2;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state == 0)
					{
						obj = 5;
					}
					continue;
				case 10:
					((AsyncTaskMethodBuilder<EntityFeverManifest>*)(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&stateMachine))->_003C_003Et__builder))->Start(ref *(FeverInstaller._003CGetFeverManifestAsync_003Ed__12*)(&stateMachine));
					obj = 1;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E4__this)->_003C_003Eu__1 != 0)
					{
						obj = 4;
					}
					continue;
				case 1:
					Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler = P_6;
					obj = 9;
					continue;
				default:
					((Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine))->_003C_003E1__state = (int)P_3;
					obj = 8;
					continue;
				case 4:
					((TaskAwaiter*)(&((Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine))->_003C_003Et__builder))->GetResult();
					return (object)/*Error near IL_010b: Stack underflow*/;
				case 3:
					((Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine))->client = (TcpClient)P_2;
					obj = 0;
					if (Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain == null)
					{
						obj = 0;
					}
					continue;
				case 2:
					((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(&stateMachine))->_003C_003E1__state = (int)P_5;
					obj = 0;
					if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003Et__builder).client == null)
					{
						obj = 1;
					}
					continue;
				case 7:
					break;
				case 9:
					((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(&stateMachine))->_003Cstream_003E5__2 = -1;
					obj = 10;
					if (Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10.ReflectMixedGateway != null)
					{
						obj = 3;
					}
					continue;
				}
				break;
			}
			((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(&stateMachine))->_003C_003E4__this = (Authenticator)P_1;
			stateMachine = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00伀(object P_0, object P_1, object P_2, long P_3, Action<int> P_4, uint P_5, CancellationToken P_6)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777404, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00倀()
	{
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (Authenticator._003CListenAsync_003Ed__7._003C_003E1__state == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00儀(uint P_0, long P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_004b: Expected native int or pointer, but got Obj
		//IL_0116: Expected Obj, but got VT
		//IL_0120: Expected native int or pointer, but got Obj
		//IL_0085: Expected native int or pointer, but got Obj
		//IL_008e: Expected native int or pointer, but got Obj
		//IL_00a5: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I8
		//IL_0062: Expected VT, but got I8
		//IL_005d: Expected native int or pointer, but got Obj
		//IL_006c: Expected native int or pointer, but got Obj
		//IL_00cc: Expected native int or pointer, but got Obj
		//IL_00e3: Expected Obj, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_00ed: Expected VT, but got Obj
		//IL_00f2: Expected native int or pointer, but got Obj
		//IL_00f9: Expected native int or pointer, but got Obj
		//IL_0105: Expected Obj, but got I8
		//IL_0100: Expected native int or pointer, but got Obj
		//IL_005a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_012a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00be->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0076->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0135->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c9->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0081->IL0026: Incompatible stack types: I4 vs Obj
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
				((Authenticator._003CListenAsync_003Ed__7*)(nint)obj)->_003C_003E1__state = (int)P_0;
				obj2 = 3;
				break;
			case 3:
				Unsafe.Write(&((Authenticator._003CListenAsync_003Ed__7*)(nint)obj)->_003C_003Et__builder, (AsyncTaskMethodBuilder)P_1);
				obj2 = 0;
				if ((int)((Authenticator._003CListenAsync_003Ed__7*)(nint)Authenticator._003CListenAsync_003Ed__7._003C_003E4__this)->_003C_003Eu__1 != 0)
				{
					obj2 = 2;
				}
				break;
			case 2:
			{
				_ = Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton;
				long num = 1L;
				long num2 = (long)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)obj)->_003C_003E1__state / 1048576L;
				GC.SuppressFinalize((int)AsyncTaskMethodBuilder.Create());
				Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)num)->_003C_003E4__this, (Authenticator)num2);
				_ = 2;
				if (Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler != null)
				{
					_ = 5;
				}
				break;
			}
			case 4:
				((AsyncTaskMethodBuilder*)/*Error near IL_00d6: Stack underflow*/)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)null, ref *(TStateMachine*)((Authenticator._003CReceiveAsync_003Ed__9*)(nint)obj)->_003C_003E1__state);
				return RestClientExtensions.ExecuteAsync<EntityFeverManifest>((IRestClient)/*Error near IL_00ed: Stack underflow*/, (RestRequest)/*Error near IL_00ed: Stack underflow*/, (CancellationToken)((FeverInstaller)/*Error near IL_00e8: Stack underflow*/).FeverRequest<EntityFeverApp>((RestRequest)(object)new ILogger((Exception)obj, (string)(delegate*<bool>)(&Authenticator._003CListenAsync_003Ed__7.DecorateExpandableParser))));
			case 5:
				Unsafe.Write(&((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)obj)->client, (TcpClient)(((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)obj)->_003C_003E1__state / (long)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)obj)->_003C_003Et__builder));
				obj2 = 4;
				break;
			case 1:
				obj = new Authenticator._003CReceiveAsync_003Ed__9((IAsyncStateMachine)/*Error near IL_0114: Stack underflow*/);
				obj2 = 0;
				if ((int)((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003Cstream_003E5__2)->_003C_003Eu__1 != 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00刀(uint P_0, long P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777403, new IntPtr(2737367927564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00匀(object P_0, object P_1, object P_2, Action<int> P_3, CancellationToken P_4)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004f: Expected I4, but got Obj
		//IL_0124: Expected Obj, but got Ref
		//IL_0124: Expected Obj, but got Ref
		//IL_012e: Expected native int or pointer, but got Obj
		//IL_0085: Expected Obj, but got VT
		//IL_00f7: Expected I4, but got Obj
		//IL_005c: Expected I4, but got Obj
		//IL_00ca: Expected Obj, but got Ref
		//IL_00d8: Expected Obj, but got I4
		//IL_006e: Expected VT, but got Obj
		//IL_0077: Expected Obj, but got I4
		//IL_0138->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00b8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ef->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0066->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0143->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00c3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0116->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 7;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 6:
					((Authenticator._003CListenAsync_003Ed__7*)(&obj))->_003C_003E1__state = (int)P_0;
					obj2 = 5;
					continue;
				case 8:
					((Authenticator._003CListenAsync_003Ed__7*)(&obj))->_003C_003Et__builder = (AsyncTaskMethodBuilder)P_3;
					obj = 3;
					break;
				case 3:
					((Authenticator._003CListenAsync_003Ed__7*)(&obj))->_003C_003E4__this = (Authenticator)P_4;
					obj2 = 2;
					continue;
				default:
					((AsyncTaskMethodBuilder*)/*Error near IL_009b: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)(&((Authenticator._003CListenAsync_003Ed__7*)(&obj))->_003C_003Eu__1));
					return (object)/*Error near IL_009c: Stack underflow*/;
				case 2:
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&obj))->_003C_003E1__state = -1;
					obj2 = 0;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener == null)
					{
						obj2 = 1;
					}
					continue;
				case 7:
					((TcpListener)(&obj)).Dispose();
					Unsafe.Write(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)/*Error near IL_00cf: Stack underflow*/)->_003C_003Eu__1, /*Error near IL_00cf: Stack underflow*/);
					obj = 6;
					break;
				case 5:
					Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler = P_1;
					obj2 = 4;
					continue;
				case 4:
					((Authenticator._003CReceiveAsync_003Ed__9*)(&obj))->_003C_003E1__state = (int)P_2;
					obj2 = 8;
					if (((Authenticator._003CReceiveAsync_003Ed__9)Authenticator._003CReceiveAsync_003Ed__9._003C_003Et__builder)._003C_003E4__this == null)
					{
						obj2 = 7;
					}
					continue;
				case 1:
					((FeverInstaller)(&((Authenticator._003CReceiveAsync_003Ed__9*)(&obj))->client)).FeverRequest<EntityFeverApp>((RestRequest)(object)(&obj));
					_ = 0;
					if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain)->_003C_003E1__state != 0)
					{
						_ = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00吀(object P_0, object P_1, object P_2, Action<int> P_3, CancellationToken P_4)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777402, new IntPtr(2737367921324L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00嘀(object P_0, object P_1, object P_2, Action<int> P_3, uint P_4, CancellationToken P_5)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0053: Expected I4, but got Obj
		//IL_0103: Expected native int or pointer, but got Obj
		//IL_00af: Expected VT, but got Obj
		//IL_00d9: Expected VT, but got Obj
		//IL_0088: Expected VT, but got Obj
		//IL_0092: Expected native int or pointer, but got Obj
		//IL_00ef: Expected Obj, but got Ref
		//IL_00f0: Expected Obj, but got VT
		//IL_015d: Expected Obj, but got I4
		//IL_0120: Expected VT, but got Obj
		//IL_012a: Expected native int or pointer, but got Obj
		//IL_0146: Expected Obj, but got Ref
		//IL_010d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0075->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0167->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0134->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0155->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0118->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0080->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_013f->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 9;
		object obj = stateMachine;
		while (true)
		{
			switch ((int)obj)
			{
			case 2:
				((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003E1__state = (int)P_4;
				obj = 0;
				if (((Authenticator._003CListenAsync_003Ed__7)Authenticator._003CListenAsync_003Ed__7._003C_003Et__builder)._003C_003E4__this != null)
				{
					obj = 0;
				}
				break;
			case 4:
				((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003Eu__1 = (TaskAwaiter)P_2;
				obj = 3;
				if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state != 0)
				{
					obj = 3;
				}
				break;
			case 1:
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&stateMachine))->_003C_003Et__builder = (AsyncTaskMethodBuilder)P_1;
				obj = 4;
				break;
			case 5:
				((AsyncTaskMethodBuilder<EntityFeverManifestInfo>*)(&((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&stateMachine))->listener))->Start(ref *(FeverInstaller._003CGetFeverManifestInfoAsync_003Ed__13*)(&stateMachine));
				obj = 6;
				break;
			case 3:
				((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&stateMachine))->_003C_003Eu__1 = (TaskAwaiter<TcpClient>)P_3;
				obj = 2;
				break;
			case 6:
				return ((Task)(&Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)).GetAwaiter();
			default:
				((Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine))->_003C_003Et__builder = (AsyncTaskMethodBuilder)P_5;
				obj = 7;
				if (((Authenticator._003CReceiveAsync_003Ed__9*)(nint)Authenticator._003CReceiveAsync_003Ed__9._003C_003E4__this)->client == null)
				{
					obj = 1;
				}
				break;
			case 8:
				((Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine))->_003C_003Eu__1 = (TaskAwaiter)P_0;
				obj = 1;
				if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain)->_003C_003E1__state != 0)
				{
					obj = 1;
				}
				break;
			case 9:
				((AsyncTaskMethodBuilder*)/*Error near IL_0146: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)(&stateMachine));
				Unsafe.Write(&((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(nint)/*Error near IL_014b: Stack underflow*/)->client, /*Error near IL_014b: Stack underflow*/);
				obj = 8;
				break;
			case 7:
				((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(&stateMachine))->_003C_003E4__this = (Authenticator)(-1);
				obj = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00圀(List<(string, string)> P_0, Action<int> P_1, uint P_2, CancellationToken P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777401, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00堀(List<(string, string)> P_0, Action<int> P_1, uint P_2, CancellationToken P_3)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004b: Expected I4, but got Obj
		//IL_0061: Expected Obj, but got I4
		//IL_0093: Expected I4, but got VT
		//IL_0072: Expected Obj, but got Ref
		//IL_00cc: Expected VT, but got Obj
		//IL_00de: Expected Obj, but got I4
		//IL_00a7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_011d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0128->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00fd->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 6;
		while (true)
		{
			object obj = stateMachine;
			while (true)
			{
				switch ((int)obj)
				{
				case 2:
					return Task.Run((Func<Task?>)(&((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003Et__builder));
				case 3:
					((AsyncTaskMethodBuilder*)/*Error near IL_0081: Stack underflow*/)->AwaitUnsafeOnCompleted(ref ((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003Eu__1, ref *(Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine));
					obj = 2;
					continue;
				case 1:
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&stateMachine))->_003C_003E1__state = (int)P_3;
					obj = 0;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003Et__builder).listener == null)
					{
						obj = 0;
					}
					continue;
				case 4:
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&stateMachine))->_003C_003E4__this = (Authenticator)(object)P_1;
					obj = 7;
					continue;
				case 5:
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&stateMachine))->_003C_003Eu__1 = (TaskAwaiter<TcpClient>)P_0;
					obj = 4;
					continue;
				case 7:
					Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler = P_2;
					obj = 0;
					if ((int)((Authenticator._003CReceiveAsync_003Ed__9*)Authenticator._003CReceiveAsync_003Ed__9._003C_003E1__state)->_003C_003Et__builder == 0)
					{
						obj = 1;
					}
					continue;
				case 6:
					((TaskAwaiter*)(&stateMachine))->GetResult();
					Unsafe.Write(&((Authenticator._003CReceiveAsync_003Ed__9*)(nint)/*Error near IL_0109: Stack underflow*/)->client, /*Error near IL_0109: Stack underflow*/);
					obj = 5;
					if (Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain == null)
					{
						obj = 3;
					}
					continue;
				}
				break;
			}
			((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003E1__state = -1;
			stateMachine = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00夀(List<(string, string)> P_0, Action<int> P_1, uint P_2, CancellationToken P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777400, new IntPtr(2737367929644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00娀(object P_0, object P_1, Action<int> P_2, uint P_3, CancellationToken P_4)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_004f: Expected I4, but got Obj
		//IL_00fc: Expected VT, but got Obj
		//IL_00f3: Expected Obj, but got Ref
		//IL_00f4: Expected Obj, but got VT
		//IL_00c8: Expected Obj, but got I4
		//IL_00d2: Expected native int or pointer, but got Obj
		//IL_008b: Expected VT, but got Obj
		//IL_0095: Expected native int or pointer, but got Obj
		//IL_00b2: Expected VT, but got Obj
		//IL_00bb: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got VT
		//IL_006b: Expected Obj, but got I4
		//IL_0106->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0126->IL0026: Incompatible stack types: I4 vs Obj
		//IL_014d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00dc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0083->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0131->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0158->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00aa->IL0026: Incompatible stack types: I4 vs Obj
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object stateMachine = 1;
		while (true)
		{
			object obj = stateMachine;
			while (true)
			{
				switch ((int)obj)
				{
				case 8:
					((AsyncTaskMethodBuilder*)(&((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003E1__state))->Start(ref *(Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(&stateMachine));
					stateMachine = 3;
					break;
				case 7:
					((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003E4__this = (Authenticator)P_4;
					obj = 4;
					continue;
				case 5:
					((Authenticator._003CListenAsync_003Ed__7*)(&stateMachine))->_003C_003Eu__1 = (TaskAwaiter)P_2;
					obj = 2;
					if (((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAsync_003Ed__7.CheckInternalSingleton)->_003C_003E1__state == 0)
					{
						obj = 0;
					}
					continue;
				case 6:
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&stateMachine))->_003C_003Et__builder = (AsyncTaskMethodBuilder)P_1;
					stateMachine = 5;
					break;
				case 4:
					((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(&stateMachine))->listener = (TcpListener)(-1);
					obj = 8;
					if ((int)((Authenticator._003CListenAuthenticationConnectAsync_003Ed__8*)(nint)Authenticator._003CListenAuthenticationConnectAsync_003Ed__8._003C_003E4__this)->_003C_003Eu__1 == 0)
					{
						obj = 2;
					}
					continue;
				case 3:
					return ((Task)(&Authenticator._003CListenAuthenticationConnectAsync_003Ed__8.DecorateAdjustableHandler)).GetAwaiter();
				default:
					((Authenticator._003CReceiveAsync_003Ed__9*)(&stateMachine))->_003C_003Et__builder = (AsyncTaskMethodBuilder)P_0;
					obj = 6;
					continue;
				case 1:
					((TaskAwaiter*)(&stateMachine))->GetResult();
					Unsafe.Write(&((Authenticator._003CReceiveAsync_003Ed__9*)(nint)/*Error near IL_0112: Stack underflow*/)->client, /*Error near IL_0112: Stack underflow*/);
					obj = 0;
					if (Authenticator._003CReceiveAsync_003Ed__9.CheckCustomChain == null)
					{
						obj = 0;
					}
					continue;
				case 2:
					((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10*)(&stateMachine))->_003C_003E1__state = (int)P_3;
					obj = 5;
					if (((Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10)Authenticator._003CReceiveAuthenticationDataAsync_003Ed__10._003C_003Et__builder).client == null)
					{
						obj = 7;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00嬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777399, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00尀()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00崀()
	{
		//IL_001a: Expected Obj, but got I4
		((TcpListener)(object)(*(ValueType*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_0011: Stack underflow*/, (int)Unsafe.AsPointer(ref Authenticator._003Clogger_003EP));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return Authenticator._003CListenAsync_003Ed__7._003C_003E1__state;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00帀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777398, new IntPtr(2737367927564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
