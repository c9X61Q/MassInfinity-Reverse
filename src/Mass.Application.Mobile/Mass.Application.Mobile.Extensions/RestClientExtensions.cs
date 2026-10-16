using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using RestSharp;

namespace Mass.Application.Mobile.Extensions;

public static class RestClientExtensions
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CExecuteMobileAsync_003Ed__0<T> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<RestResponse<T>> _003C_003Et__builder;

		public RestClient client;

		public RestRequest request;

		private TaskAwaiter<RestResponse> _003C_003Eu__1;

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

		internal static bool PushTree()
		{
			return true;
		}

		internal static object CheckPortableField()
		{
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CExecuteMobileAsync_003Ed__0<>))]
	public static Task<RestResponse<T>> ExecuteMobileAsync<T>(this RestClient client, RestRequest request)
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}
}
