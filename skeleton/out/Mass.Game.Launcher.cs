// 自动生成的可编译骨架 —— 声明来自元数据；方法体一律为显式占位（未还原）。
// 生成器：tools/MassSkeleton（dnlib 读元数据），不依赖反编译文本。
#nullable disable
using System;

namespace Mass.Game.Launcher {
	public abstract class Authenticator
	{
		private global::System.Net.Sockets.TcpListener Listener { get; set; }
		protected Authenticator(global::Serilog.ILogger logger) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void StartListening(global::System.Int32 port) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ListenAsync() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ListenAuthenticationConnectAsync(global::System.Object listener) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ReceiveAsync(global::System.Object client) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ReceiveAuthenticationDataAsync(global::System.Object client) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void Dispose() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected abstract global::System.Threading.Tasks.Task<global::System.String> HandleAuthentication(global::System.String message);
		internal static global::System.Boolean ReflectMonoObject() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Authenticator PatchUser() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __Ԁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __ࠀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____7(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object __ༀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object __က(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object __ᄀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void __ሀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object __ጀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object __ᔀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object __ᘀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __ᜀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __ᤀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public struct _ListenAsync_d__7
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Authenticator __4__this;
			private void MoveNext(ref global::Mass.Game.Launcher.Authenticator._ListenAsync_d__7 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Authenticator._ListenAsync_d__7 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateExpandableParser() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ObserveTracker() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _ﰀ(ref global::Mass.Game.Launcher.Authenticator._ListenAsync_d__7 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _ﴀ(ref global::Mass.Game.Launcher.Authenticator._ListenAsync_d__7 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ___2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __Ā(ref global::Mass.Game.Launcher.Authenticator._ListenAsync_d__7 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __Ȁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ___() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __Ѐ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _ListenAuthenticationConnectAsync_d__8
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::System.Net.Sockets.TcpListener listener;
			public global::Mass.Game.Launcher.Authenticator __4__this;
			internal static global::System.Object DecorateAdjustableHandler;
			private void MoveNext(ref global::Mass.Game.Launcher.Authenticator._ListenAuthenticationConnectAsync_d__8 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Authenticator._ListenAuthenticationConnectAsync_d__8 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateGenericStruct() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectRandomReporter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __(ref global::Mass.Game.Launcher.Authenticator._ListenAuthenticationConnectAsync_d__8 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ___2(ref global::Mass.Game.Launcher.Authenticator._ListenAuthenticationConnectAsync_d__8 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ___3(ref global::Mass.Game.Launcher.Authenticator._ListenAuthenticationConnectAsync_d__8 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ___4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ___5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _豈(ref global::Mass.Game.Launcher.Authenticator._ListenAuthenticationConnectAsync_d__8 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _切(ref global::Mass.Game.Launcher.Authenticator._ListenAuthenticationConnectAsync_d__8 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _ﬀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _ReceiveAsync_d__9
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Authenticator __4__this;
			public global::System.Net.Sockets.TcpClient client;
			internal static global::System.Object CheckCustomChain;
			private void MoveNext(ref global::Mass.Game.Launcher.Authenticator._ReceiveAsync_d__9 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Authenticator._ReceiveAsync_d__9 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectAdvancedEnumerator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateConvertibleParameter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __(ref global::Mass.Game.Launcher.Authenticator._ReceiveAsync_d__9 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ___2(ref global::Mass.Game.Launcher.Authenticator._ReceiveAsync_d__9 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ___3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ___4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ___5(ref global::Mass.Game.Launcher.Authenticator._ReceiveAsync_d__9 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ___6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ___7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _ReceiveAuthenticationDataAsync_d__10
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::System.Net.Sockets.TcpClient client;
			public global::Mass.Game.Launcher.Authenticator __4__this;
			internal static global::System.Object ReflectMixedGateway;
			private void MoveNext(ref global::Mass.Game.Launcher.Authenticator._ReceiveAuthenticationDataAsync_d__10 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Authenticator._ReceiveAuthenticationDataAsync_d__10 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateFlexibleProfiler() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object HandleNotifier() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __(ref global::Mass.Game.Launcher.Authenticator._ReceiveAuthenticationDataAsync_d__10 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ___2(ref global::Mass.Game.Launcher.Authenticator._ReceiveAuthenticationDataAsync_d__10 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ___3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ___4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ___5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ___6(ref global::Mass.Game.Launcher.Authenticator._ReceiveAuthenticationDataAsync_d__10 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ___7(ref global::Mass.Game.Launcher.Authenticator._ReceiveAuthenticationDataAsync_d__10 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ___8(ref global::Mass.Game.Launcher.Authenticator._ReceiveAuthenticationDataAsync_d__10 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ___9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Game.Launcher {
	public class FeverInstaller
	{
		public static global::Mass.Game.Launcher.FeverInstaller McBedrock { get; }
		private global::RestSharp.RestClient Client { get; }
		public FeverInstaller(global::System.String feverVersion, global::System.String appId, global::System.String appVersion) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void Dispose() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task InstallAsync() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<global::Mass.Game.Launcher.Entities.Fever.EntityFeverManifest> GetFeverManifestAsync(global::System.Object info) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<global::Mass.Game.Launcher.Entities.Fever.EntityFeverManifestInfo> GetFeverManifestInfoAsync(global::System.Object version) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<global::Mass.Game.Launcher.Entities.Fever.EntityFeverAppVersion> GetFeverAppVersionAsync() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<object> FeverRequest<T0>(global::RestSharp.RestRequest request) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		static FeverInstaller() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckScopeSummarizer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.FeverInstaller CheckStaticProgram() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __ᨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __ᰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<global::Mass.Game.Launcher.Entities.Fever.EntityFeverManifestInfo> __ᴀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<global::Mass.Game.Launcher.Entities.Fever.EntityFeverManifestInfo> __Ḁ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<global::Mass.Game.Launcher.Entities.Fever.EntityFeverManifestInfo> __ἀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<global::Mass.Game.Launcher.Entities.Fever.EntityFeverAppVersion> ____2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<global::Mass.Game.Launcher.Entities.Fever.EntityFeverAppVersion> ____3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<global::Mass.Game.Launcher.Entities.Fever.EntityFeverManifest> ____7(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __Ⰰ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __ⴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public struct _FeverRequest_d__15<T0>
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T0> __t__builder;
			public global::Mass.Game.Launcher.FeverInstaller __4__this;
			public global::RestSharp.RestRequest request;
			private void MoveNext(ref global::Mass.Game.Launcher.FeverInstaller._FeverRequest_d__15<T0> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.FeverInstaller._FeverRequest_d__15<T0> p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckAdaptableResponder() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object VisitParser() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _GetFeverAppVersionAsync_d__14
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Mass.Game.Launcher.Entities.Fever.EntityFeverAppVersion> __t__builder;
			public global::Mass.Game.Launcher.FeverInstaller __4__this;
			internal static global::System.Object CheckBasicEncryptor;
			private void MoveNext(ref global::Mass.Game.Launcher.FeverInstaller._GetFeverAppVersionAsync_d__14 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.FeverInstaller._GetFeverAppVersionAsync_d__14 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean AnalyzeHandler() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectRemoteFinder() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _혀(ref global::Mass.Game.Launcher.FeverInstaller._GetFeverAppVersionAsync_d__14 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _휀(ref global::Mass.Game.Launcher.FeverInstaller._GetFeverAppVersionAsync_d__14 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ___2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ___3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ___4(ref global::Mass.Game.Launcher.FeverInstaller._GetFeverAppVersionAsync_d__14 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ___5(ref global::Mass.Game.Launcher.FeverInstaller._GetFeverAppVersionAsync_d__14 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ___6(ref global::Mass.Game.Launcher.FeverInstaller._GetFeverAppVersionAsync_d__14 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ___7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ___8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _GetFeverManifestAsync_d__12
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Mass.Game.Launcher.Entities.Fever.EntityFeverManifest> __t__builder;
			public global::Mass.Game.Launcher.FeverInstaller __4__this;
			public global::Mass.Game.Launcher.Entities.Fever.EntityFeverManifestInfo info;
			private void MoveNext(ref global::Mass.Game.Launcher.FeverInstaller._GetFeverManifestAsync_d__12 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.FeverInstaller._GetFeverManifestAsync_d__12 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean SearchChain() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReceiveEnumerator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _케(ref global::Mass.Game.Launcher.FeverInstaller._GetFeverManifestAsync_d__12 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _퀀(ref global::Mass.Game.Launcher.FeverInstaller._GetFeverManifestAsync_d__12 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _턀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _툀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _팀(ref global::Mass.Game.Launcher.FeverInstaller._GetFeverManifestAsync_d__12 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _퐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _픀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _GetFeverManifestInfoAsync_d__13
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Mass.Game.Launcher.Entities.Fever.EntityFeverManifestInfo> __t__builder;
			public global::Mass.Game.Launcher.FeverInstaller __4__this;
			public global::Mass.Game.Launcher.Entities.Fever.EntityFeverAppVersion version;
			internal static global::System.Object CheckScalableWorker;
			private void MoveNext(ref global::Mass.Game.Launcher.FeverInstaller._GetFeverManifestInfoAsync_d__13 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.FeverInstaller._GetFeverManifestInfoAsync_d__13 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CallGateway() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateGroupedVisitor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _봀(ref global::Mass.Game.Launcher.FeverInstaller._GetFeverManifestInfoAsync_d__13 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _븀(ref global::Mass.Game.Launcher.FeverInstaller._GetFeverManifestInfoAsync_d__13 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _뼀(ref global::Mass.Game.Launcher.FeverInstaller._GetFeverManifestInfoAsync_d__13 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _쀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _섀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _쬀(ref global::Mass.Game.Launcher.FeverInstaller._GetFeverManifestInfoAsync_d__13 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _찀(ref global::Mass.Game.Launcher.FeverInstaller._GetFeverManifestInfoAsync_d__13 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _촀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _츀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _InstallAsync_d__11
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.FeverInstaller __4__this;
			private void MoveNext(ref global::Mass.Game.Launcher.FeverInstaller._InstallAsync_d__11 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.FeverInstaller._InstallAsync_d__11 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckIsolatedElement() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object SerializeResponder() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _똀(ref global::Mass.Game.Launcher.FeverInstaller._InstallAsync_d__11 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _뜀(ref global::Mass.Game.Launcher.FeverInstaller._InstallAsync_d__11 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _렀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _뤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _먀(ref global::Mass.Game.Launcher.FeverInstaller._InstallAsync_d__11 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _묀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _밀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Game.Launcher {
	public class Rpc
	{
		public global::System.Int32 ProcessId { get; set; }
		private global::Serilog.ILogger Logger { get; }
		public global::System.Boolean NeedCha { get; set; }
		private global::System.Boolean UseCha { get; set; }
		private global::System.Collections.Generic.Dictionary<global::System.UInt16, global::System.Func<global::Mass.Game.Launcher.Models.RpcCallBack, global::System.Threading.Tasks.Task>> Callbacks { get; }
		protected global::System.IO.BinaryWriter Writer { get; set; }
		private global::System.Net.Sockets.TcpListener Listener { get; set; }
		protected Rpc(global::Serilog.ILogger logger, global::System.Boolean needCha) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void SendMessage(global::System.IO.BinaryWriter writer, global::System.Object[] values) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected void AddCallBack(global::System.UInt16 sid, global::System.Func<global::Mass.Game.Launcher.Models.RpcCallBack, global::System.Threading.Tasks.Task> callback) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object RemoteCallBackAsync(global::System.Object callBack) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void StartListen(global::System.Int32 port) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void Dispose() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ReceiveAsync(global::System.Object client) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ReceiveControlData(global::System.Object reader, global::System.Object writer) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ListenAsync() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ListenControlConnectAsync(global::System.Object listener) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task SyncChaChaAsync(global::Mass.Game.Launcher.Models.RpcCallBack callBack) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean PopVisitor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Rpc CheckConnectedDecider() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _茀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _萀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _蔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _蘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Collections.Generic.Dictionary<global::System.UInt16, global::System.Func<global::Mass.Game.Launcher.Models.RpcCallBack, global::System.Threading.Tasks.Task>> _蜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Collections.Generic.Dictionary<global::System.UInt16, global::System.Func<global::Mass.Game.Launcher.Models.RpcCallBack, global::System.Threading.Tasks.Task>> _蠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected global::System.Object _褀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Byte _言() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Byte _謀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _谀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _贀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _踀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _輀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _鄀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _鈀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _錀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _鐀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _销() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _阀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _需() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _頀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _餀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _騀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _鬀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _鰀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _鴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _鸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _鼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _ꀀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _ꄀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _ꈀ(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _ꌀ(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _ꐀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _ꔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _ꘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ꠀ(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ꨀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___2(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _가(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _관(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _글(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _꼀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected void _넀(global::System.UInt16 p0, global::System.Func<global::Mass.Game.Launcher.Models.RpcCallBack, global::System.Threading.Tasks.Task> p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _눀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _대() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected void _됀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected void _딀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public struct _ListenAsync_d__34
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Rpc __4__this;
			private void MoveNext(ref global::Mass.Game.Launcher.Rpc._ListenAsync_d__34 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Rpc._ListenAsync_d__34 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckIntegratedDic() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckLocalObject() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _稀(ref global::Mass.Game.Launcher.Rpc._ListenAsync_d__34 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _笀(ref global::Mass.Game.Launcher.Rpc._ListenAsync_d__34 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _簀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _紀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _缀(ref global::Mass.Game.Launcher.Rpc._ListenAsync_d__34 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _耀(ref global::Mass.Game.Launcher.Rpc._ListenAsync_d__34 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _脀(ref global::Mass.Game.Launcher.Rpc._ListenAsync_d__34 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _舀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _ListenControlConnectAsync_d__35
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::System.Net.Sockets.TcpListener listener;
			public global::Mass.Game.Launcher.Rpc __4__this;
			private void MoveNext(ref global::Mass.Game.Launcher.Rpc._ListenControlConnectAsync_d__35 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Rpc._ListenControlConnectAsync_d__35 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateConfigurableArgument() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateSeparatedSummarizer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _渀(ref global::Mass.Game.Launcher.Rpc._ListenControlConnectAsync_d__35 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _漀(ref global::Mass.Game.Launcher.Rpc._ListenControlConnectAsync_d__35 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _瀀(ref global::Mass.Game.Launcher.Rpc._ListenControlConnectAsync_d__35 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _焀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _爀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _瘀(ref global::Mass.Game.Launcher.Rpc._ListenControlConnectAsync_d__35 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _眀(ref global::Mass.Game.Launcher.Rpc._ListenControlConnectAsync_d__35 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _砀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _礀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _ReceiveAsync_d__28
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::System.Net.Sockets.TcpClient client;
			public global::Mass.Game.Launcher.Rpc __4__this;
			internal static global::System.Object CheckMonoProgram;
			private void MoveNext(ref global::Mass.Game.Launcher.Rpc._ReceiveAsync_d__28 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Rpc._ReceiveAsync_d__28 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateOrderedTemplate() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectVisualAuditor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _昀(ref global::Mass.Game.Launcher.Rpc._ReceiveAsync_d__28 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _最(ref global::Mass.Game.Launcher.Rpc._ReceiveAsync_d__28 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _栀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _椀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _欀(ref global::Mass.Game.Launcher.Rpc._ReceiveAsync_d__28 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _氀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _洀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _RemoteCallBackAsync_d__21
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Rpc __4__this;
			public global::Mass.Game.Launcher.Models.RpcCallBack callBack;
			internal static global::System.Object MeasureCalc;
			private void MoveNext(ref global::Mass.Game.Launcher.Rpc._RemoteCallBackAsync_d__21 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Rpc._RemoteCallBackAsync_d__21 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean RemoveTree() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ConvertFilter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _嬀(ref global::Mass.Game.Launcher.Rpc._RemoteCallBackAsync_d__21 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _尀(ref global::Mass.Game.Launcher.Rpc._RemoteCallBackAsync_d__21 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _崀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _帀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _戀(ref global::Mass.Game.Launcher.Rpc._RemoteCallBackAsync_d__21 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _挀(ref global::Mass.Game.Launcher.Rpc._RemoteCallBackAsync_d__21 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _搀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _攀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _SyncChaChaAsync_d__38
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Rpc __4__this;
			public global::Mass.Game.Launcher.Models.RpcCallBack callBack;
			private void MoveNext(ref global::Mass.Game.Launcher.Rpc._SyncChaChaAsync_d__38 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Rpc._SyncChaChaAsync_d__38 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateConnectedMapper() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckAlphabeticPolicy() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _刀(ref global::Mass.Game.Launcher.Rpc._SyncChaChaAsync_d__38 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _匀(ref global::Mass.Game.Launcher.Rpc._SyncChaChaAsync_d__38 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _吀(ref global::Mass.Game.Launcher.Rpc._SyncChaChaAsync_d__38 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _唀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _嘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _堀(ref global::Mass.Game.Launcher.Rpc._SyncChaChaAsync_d__38 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _夀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _娀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Game.Launcher.Values {
	public abstract class CppGameValue
	{
		public global::System.String SkinPath { get; set; }
		public static global::Mass.Game.Launcher.Values.CppGameValue Get(global::Mass.Domain.Value.SectionValue @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public CppGameValue() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectEditableRecord() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Values.CppGameValue CheckLogicalContext() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____2(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____3(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____5(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __㐀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __㔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __㘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __㜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __㠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Values {
	public class GameValue
	{
		public global::System.Int32 MaxConcurrency { get; set; }
		public static global::System.Collections.Generic.List<global::Mass.Domain.Value.ConfigValue> GetDesktopValue(global::System.String gameId, global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion version) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.Collections.Generic.List<global::Mass.Domain.Value.ConfigValue> GetMobileValue(global::System.String gameId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public GameValue() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckControllablePolicy() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Values.GameValue TrackDecorator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Collections.Generic.List<global::Mass.Domain.Value.ConfigValue> _䔀(global::System.Object p0, global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Collections.Generic.List<global::Mass.Domain.Value.ConfigValue> _䘀(global::System.Object p0, global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _䜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _䠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _䤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _䨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Collections.Generic.List<global::Mass.Domain.Value.ConfigValue> _䬀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Collections.Generic.List<global::Mass.Domain.Value.ConfigValue> _䰀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _䴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _一() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _伀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _倀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _儀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Values {
	public abstract class JavaGameValue
	{
		internal static global::Mass.Game.Launcher.Values.JavaGameValue ReflectResponsiveModule;
		public global::System.Int32 MaxMemory { get; set; }
		public global::System.Boolean Reconnect { get; set; }
		public global::System.Int32 ReconnectDelay { get; set; }
		public global::System.Boolean SaveOptions { get; set; }
		public global::System.Boolean SetChinese { get; set; }
		public global::System.Boolean SetGuiScale { get; set; }
		public global::System.Int32 GuiScale { get; set; }
		public global::System.Boolean SetSize { get; set; }
		public global::System.Int32 WindowWidth { get; set; }
		public global::System.Int32 WindowHeight { get; set; }
		public static global::Mass.Game.Launcher.Values.JavaGameValue Get(global::Mass.Domain.Value.SectionValue @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public JavaGameValue() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateSortedEvent() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Values.JavaGameValue CombineProgram() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __㤀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __㨀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __㬀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __㰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __㴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __㸀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __㼀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __䀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __䄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __䈀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __䌀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __䐀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __䔀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __䘀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __䜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __䠀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __䤀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __䨀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __䬀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __䰀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __䴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __一() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __伀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __倀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __儀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __刀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __匀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __吀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __唀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __嘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __圀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __堀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __夀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __娀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __嬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __尀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __崀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __帀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __开(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __怀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __愀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __戀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __挀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __搀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Paths {
	public abstract class BedrockGamePath
	{
		public readonly global::System.String NeteaseData;
		public readonly global::System.String Launcher;
		internal static global::Mass.Game.Launcher.Paths.BedrockGamePath StartTemplate;
		public BedrockGamePath(global::System.String install, global::System.String startup) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::Mass.Game.Launcher.Paths.BedrockGamePath GetBedrockPath() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateSequentialContainer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Paths.BedrockGamePath DecorateSetConverter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __栀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __椀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __樀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __欀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __氀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __渀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __漀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __瀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Paths {
	public abstract class ComponentPath
	{
		public readonly global::System.Boolean IsDirectory;
		public readonly global::System.String Target;
		public readonly global::System.String Source;
		public readonly global::System.String ComponentName;
		public readonly global::System.String ComponentZip;
		public readonly global::System.String ComponentMd5;
		public readonly global::System.String ComponentCache;
		public readonly global::System.String ComponentExtension;
		public readonly global::Mass.Domain.Desktop.Entities.Mods.EntitySubItemDownload Item;
		public readonly global::System.Boolean IsShaderPack;
		public readonly global::System.Boolean IsResourcePack;
		internal static global::Mass.Game.Launcher.Paths.ComponentPath ReflectEfficientVerifier;
		public ComponentPath(global::System.String @base, global::Mass.Domain.Desktop.Entities.Mods.EntityItemDownload download, global::Mass.Domain.Desktop.Entities.Mods.EntitySubItemDownload subItem) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CloseRecord() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Paths.ComponentPath DecorateGlobalComparator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __焀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __爀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __猀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __稀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __笀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Paths {
	public abstract class CppGamePath
	{
		public readonly global::System.String BedrockLauncherFile;
		public readonly global::System.String BedrockLauncher;
		public readonly global::System.String BedrockHash;
		public readonly global::System.String Bedrock;
		public readonly global::System.String GameZip;
		public readonly global::System.String BePackCache;
		public readonly global::System.String BeMain;
		public readonly global::System.String AppData;
		public readonly global::System.String GameRuntime;
		public readonly global::System.String ConfigFile;
		public readonly global::System.String ErrorLog;
		public CppGamePath(global::Mass.Game.Launcher.Cpp.EntityLaunchCppGame args) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectDetailedCommand() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Paths.CppGamePath DecorateDividedConsumer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __簀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __紀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __蜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __蠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Paths {
	public class GamePath
	{
		public readonly global::System.String Root;
		public readonly global::System.String Resources;
		public readonly global::System.String Data;
		public readonly global::System.String Files;
		public readonly global::System.String Cache;
		public readonly global::System.String Game;
		public readonly global::System.String GameAuthenticationDllSource;
		public readonly global::System.String PatchMcpSource;
		public GamePath() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectExtendedSorter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Paths.GamePath CheckWrapper() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _㸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _㼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _䀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _䐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Paths {
	public abstract class JavaGamePath
	{
		public readonly global::System.String Java;
		public readonly global::System.String JavaUrl;
		public readonly global::System.String JavaTarget;
		public readonly global::System.String JavaZip;
		public readonly global::System.String JavaExe;
		public readonly global::System.String GameBase;
		public readonly global::System.String GameBaseComponents;
		public readonly global::System.String GameBaseMd5;
		public readonly global::Mass.Game.Launcher.Paths.MinecraftPath BaseMinecraft;
		public readonly global::System.String GameVersionMd5;
		public readonly global::System.String GameCoreLibs;
		public readonly global::System.String GameCoreLibMd5;
		public readonly global::System.String GameRuntime;
		public readonly global::System.String GameRuntimeMd5;
		public readonly global::System.String Custom;
		public readonly global::System.String CustomOptions;
		public readonly global::System.String GameCustom;
		public readonly global::Mass.Game.Launcher.Paths.MinecraftPath Minecraft;
		internal static global::Mass.Game.Launcher.Paths.JavaGamePath ReflectCentralEmitter;
		public JavaGamePath(global::Mass.Game.Launcher.Java.EntityLaunchJavaGame args) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object GetGameVersionNameLower(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion version) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object GetMd5FileName(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion version, global::System.Object suffix) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckStatelessRunner() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Paths.JavaGamePath DecorateScheduledClient() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __褀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __言() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __謀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __谀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object __贀(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object __踀(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object __輀(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object __退(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object __鄀(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Paths {
	public class MinecraftPath
	{
		public readonly global::System.String Root;
		public readonly global::System.String Versions;
		public readonly global::System.String Version;
		public readonly global::System.String VersionDat;
		public readonly global::System.String VersionJson;
		public readonly global::System.String VersionJar;
		public readonly global::System.String Natives;
		public readonly global::System.String GameAuthenticationDll;
		public readonly global::System.String Runtime;
		public readonly global::System.String Mods;
		public readonly global::System.String ModSettings;
		public readonly global::System.String WordV;
		public readonly global::System.String Libraries;
		public readonly global::System.String Assets;
		public readonly global::System.String Options;
		public readonly global::System.String OptionsShaders;
		internal static global::Mass.Game.Launcher.Paths.MinecraftPath CheckFilteredListener;
		public MinecraftPath(global::System.String mcPath, global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion version) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.String ToString() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectAutomatedTracker() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Paths.MinecraftPath CheckPassiveFinalizer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _Ⰰ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _ⴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _㴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Paths {
	public abstract class ServerModPath
	{
		public readonly global::System.String Resource;
		public readonly global::System.String ResourceMd5;
		public readonly global::System.String Mods;
		public readonly global::Mass.Game.Launcher.Paths.MinecraftPath Minecraft;
		public readonly global::Mass.Domain.Desktop.Entities.Mods.EntitySubItemDownload Item;
		internal static global::Mass.Game.Launcher.Paths.ServerModPath DecorateExternalAggregator;
		public ServerModPath(global::Mass.Game.Launcher.Java.EntityLaunchJavaGame args, global::System.String gameBase, global::Mass.Domain.Desktop.Entities.Mods.EntityItemDownload download, global::Mass.Domain.Desktop.Entities.Mods.EntitySubItemDownload subItem) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean AdaptCommand() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Paths.ServerModPath CheckVirtualDefinition() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __ꠀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __꤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __ꨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Models {
	public class RpcCallBack
	{
		internal static global::Mass.Game.Launcher.Models.RpcCallBack ReflectIdentifiableTransmitter;
		protected global::System.Type EqualityContract { get; }
		public global::Mass.Game.Launcher.Rpc Rpc { get; set; }
		public global::System.IO.BinaryWriter Writer { get; set; }
		public global::System.UInt16 Sid { get; set; }
		public global::System.Byte[] Data { get; set; }
		public RpcCallBack(global::Mass.Game.Launcher.Rpc Rpc, global::System.IO.BinaryWriter Writer, global::System.UInt16 Sid, global::System.Byte[] Data) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void Send(global::System.Object[] values) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public object As<T0>() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.String ToString() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected global::System.Boolean PrintMembers(global::System.Text.StringBuilder builder) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.Boolean op_Inequality(global::Mass.Game.Launcher.Models.RpcCallBack left, global::Mass.Game.Launcher.Models.RpcCallBack right) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.Boolean op_Equality(global::Mass.Game.Launcher.Models.RpcCallBack left, global::Mass.Game.Launcher.Models.RpcCallBack right) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Int32 GetHashCode() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Boolean Equals(global::System.Object obj) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Boolean Equals_2(global::Mass.Game.Launcher.Models.RpcCallBack other) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::Mass.Game.Launcher.Models.RpcCallBack _Clone__() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected RpcCallBack(global::Mass.Game.Launcher.Models.RpcCallBack original) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void Deconstruct(out global::Mass.Game.Launcher.Rpc Rpc, out global::System.IO.BinaryWriter Writer, out global::System.UInt16 Sid, out global::System.Byte[] Data) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean InterruptSorter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Models.RpcCallBack DecorateCustomizableAnalyzer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected global::System.Object _() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected global::System.Object _Ā() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected global::System.Object _Ȁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _Ѐ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _Ԁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___2(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _ࠀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object ___5(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object ___6(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object ___7(global::System.UInt16 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object ___8(global::System.UInt16 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ༀ(global::System.IntPtr p0, global::System.IntPtr p1, global::System.IntPtr p2, global::System.IntPtr p3) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _က(global::System.IntPtr p0, global::System.IntPtr p1, global::System.IntPtr p2, global::System.IntPtr p3) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ᄀ(global::System.IntPtr p0, global::System.IntPtr p1, global::System.IntPtr p2, global::System.IntPtr p3) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected global::System.Byte ___9(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ᔀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ᘀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ᜀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt16 ___10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt16 _ᤀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt16 _ᨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object ___11(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object _ᰀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _ᴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _Ḁ(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _ἀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object ___12(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object ___13(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object ___14(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___15() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___16() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___17() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___18(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___19() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___20(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___21(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___22() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Java {
	public abstract class JavaAuthenticator
	{
		private static global::Serilog.ILogger Logger { get; }
		public JavaAuthenticator(global::Mass.Application.Desktop.DesktopSession session, global::Mass.Domain.Desktop.ValueObjects.EnumGameType type, global::System.String gameId, global::System.String gameVersion, global::System.String modHashList) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected global::System.Threading.Tasks.Task<global::System.String> HandleAuthentication(global::System.String message) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		static JavaAuthenticator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckExpandableNotifier() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Java.JavaAuthenticator ReflectHiddenDispatcher() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object __가() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object __관() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object __글() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __꼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected global::System.Threading.Tasks.Task<global::System.String> __뀀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected global::System.Threading.Tasks.Task<global::System.String> __넀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __눀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __대() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __됀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public struct _HandleAuthentication_d__9
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::System.String> __t__builder;
			public global::Mass.Game.Launcher.Java.JavaAuthenticator __4__this;
			public global::System.String message;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaAuthenticator._HandleAuthentication_d__9 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaAuthenticator._HandleAuthentication_d__9 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectLogicalModule() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectSimpleEvent() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _(ref global::Mass.Game.Launcher.Java.JavaAuthenticator._HandleAuthentication_d__9 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __2(ref global::Mass.Game.Launcher.Java.JavaAuthenticator._HandleAuthentication_d__9 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __3(ref global::Mass.Game.Launcher.Java.JavaAuthenticator._HandleAuthentication_d__9 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ﰀ(ref global::Mass.Game.Launcher.Java.JavaAuthenticator._HandleAuthentication_d__9 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ﴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Game.Launcher.Java {
	public class JavaCommand
	{
		internal static global::Mass.Game.Launcher.Java.JavaCommand DecorateAdjustableSingleton;
		private static global::Serilog.ILogger Logger { get; }
		private global::Mass.Game.Launcher.Paths.MinecraftPath BaseMinecraft { get; }
		private global::Mass.Game.Launcher.Paths.MinecraftPath Minecraft { get; }
		private global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion Version { get; }
		private global::Mass.Domain.Desktop.ValueObjects.EnumGameType Type { get; }
		private global::System.String VersionName { get; }
		private global::System.String GameId { get; }
		private global::System.String Uuid { get; }
		private global::System.String Name { get; }
		private global::System.Int32 MaxMemory { get; }
		private global::System.String Address { get; }
		private global::System.Int32 Port { get; }
		private global::Mass.Application.Desktop.DesktopSession Session { get; }
		private global::System.Int32 SocketPort { get; }
		private global::System.Int32 RpcPort { get; }
		private global::System.Boolean IsFilter { get; }
		private JavaCommand(global::System.Object session, global::System.Object baseMinecraft, global::System.Object minecraft, global::Mass.Domain.Desktop.ValueObjects.EnumGameType type, global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion version, global::System.UInt32 socketPort, global::System.UInt32 rpcPort, global::System.Object gameId, global::System.Object address, global::System.UInt32 port, global::System.Object name, global::System.UInt32 maxMemory, global::System.Byte isFilter) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.String Build(global::Mass.Application.Desktop.DesktopSession session, global::Mass.Game.Launcher.Paths.MinecraftPath baseMinecraft, global::Mass.Game.Launcher.Paths.MinecraftPath minecraft, global::Mass.Domain.Desktop.ValueObjects.EnumGameType type, global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion version, global::System.Int32 socketPort, global::System.Int32 rpcPort, global::System.String gameId, global::System.String address, global::System.Int32 port, global::System.String name, global::System.Int32 maxMemory, global::System.Boolean isFilter) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object BuildCommand() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void AddNativePath(global::System.Object sb) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object Escape(global::System.Object path) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object GetUserPropertiesEx() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object GetUserProperties() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Collections.Generic.List<global::System.String> BuildJars(global::System.Collections.Generic.Dictionary<global::System.String, global::System.Text.Json.JsonElement> cfg) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object BuildCommandNew(global::System.Collections.Generic.Dictionary<global::System.String, global::System.Text.Json.JsonElement> json, global::System.Collections.Generic.List<global::System.String> jars) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ReplaceLibraryPath(global::System.Object args, global::System.Object option) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ReplaceClassPath(global::System.Object args, global::System.Object option) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object BuildCommandOld(global::System.Collections.Generic.Dictionary<global::System.String, global::System.Text.Json.JsonElement> json, global::System.Collections.Generic.List<global::System.String> jars) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		static JavaCommand() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _ReplaceClassPath_b__58_0(global::System.Object p) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean WriteTracker() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Java.JavaCommand FilterFinalizer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object __딀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object __똀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object __뜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object __먀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object __묀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object __밀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object __봀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __븀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __뼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object __쌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object __쐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.UInt32 __씀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.UInt32 __였() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object __윀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object __저(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object __쨀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object __쬀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object __찀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::Mass.Domain.Desktop.ValueObjects.EnumGameType __촀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::Mass.Domain.Desktop.ValueObjects.EnumGameType __츀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::Mass.Domain.Desktop.ValueObjects.EnumGameType __케() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.UInt32 __퀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object __턀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object __툀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object __팀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object __퐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object __픀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object __휀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Byte ____2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Byte ____3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Byte ____4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____9(global::System.Object p0, global::System.Object p1, global::System.Object p2, global::Mass.Domain.Desktop.ValueObjects.EnumGameType p3, global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p4, global::System.UInt32 p5, global::System.UInt32 p6, global::System.Object p7, global::System.Object p8, global::System.UInt32 p9, global::System.Object p10, global::System.UInt32 p11, global::System.Byte p12) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____10(global::System.Object p0, global::System.Object p1, global::System.Object p2, global::Mass.Domain.Desktop.ValueObjects.EnumGameType p3, global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p4, global::System.UInt32 p5, global::System.UInt32 p6, global::System.Object p7, global::System.Object p8, global::System.UInt32 p9, global::System.Object p10, global::System.UInt32 p11, global::System.Byte p12) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____13() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____14() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion ____15() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion ____16() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____17() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____18() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____19() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___ༀ(global::System.Collections.Generic.Dictionary<global::System.String, global::System.Text.Json.JsonElement> p0, global::System.Collections.Generic.List<global::System.String> p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___က(global::System.Collections.Generic.Dictionary<global::System.String, global::System.Text.Json.JsonElement> p0, global::System.Collections.Generic.List<global::System.String> p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___ᄀ(global::System.Collections.Generic.Dictionary<global::System.String, global::System.Text.Json.JsonElement> p0, global::System.Collections.Generic.List<global::System.String> p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.UInt32 ___ሀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.UInt32 ___ጀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____(global::System.Collections.Generic.Dictionary<global::System.String, global::System.Text.Json.JsonElement> p0, global::System.Collections.Generic.List<global::System.String> p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____2(global::System.Collections.Generic.Dictionary<global::System.String, global::System.Text.Json.JsonElement> p0, global::System.Collections.Generic.List<global::System.String> p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Collections.Generic.List<global::System.String> _____3(global::System.Collections.Generic.Dictionary<global::System.String, global::System.Text.Json.JsonElement> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _____4(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ___Ⰰ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____5(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____6(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____7(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.UInt32 _____8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.UInt32 ___㐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.UInt32 ___㔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Java {
	public enum CrashReason
	{
		Unknown = 0,
		HsErrCrash = 1,
		OutOfMemory = 2,
		JvmArgError = 3,
		JavaVersionTooHigh = 4,
		JavaVersionIncompat = 5,
		OpenGLNotSupported = 6,
		PixelFormatError = 7,
		GpuDriverIntelCrash = 8,
		GpuDriverAmdCrash = 9,
		GpuDriverNvidiaCrash = 10,
		GameCoreVerificationLibraryCrash = 11,
		NativeComponentLoadFailed = 12,
		ModExtracted = 13,
		ModDuplicate = 14,
		ModMissingDep = 15,
		ModConflict = 16,
		ModMixinFailed = 17,
		ModCrash = 18,
		ModConfigError = 19,
		OpenJ9 = 20,
		ManualDebugCrash = 21,
		WindowsIllegalInstruction = 22,
		WindowsAccessViolation = 23,
		WindowsInvalidImageFormat = 24,
		WindowsDllNotFound = 25,
		WindowsEntryPointNotFound = 26,
		WindowsDllInitializationFailed = 27,
		WindowsHeapCorruption = 28,
		WindowsStackBufferOverrun = 29,
		WindowsIntegerDivideByZero = 30,
		WindowsPrivilegedInstruction = 31,
		WindowsOutOfMemory = 32,
		WindowsInPageError = 33,
		WindowsBreakpoint = 34,
		WindowsControlC = 35,
	}

}
namespace Mass.Game.Launcher.Java {
	public class JavaCrashAnalyzer
	{
		internal static global::Mass.Game.Launcher.Java.JavaCrashAnalyzer DecorateMixedChain;
		public static global::System.String Analyze(global::Mass.Game.Launcher.Paths.MinecraftPath mcPath, global::System.Collections.Generic.IReadOnlyList<global::System.String> recentLog, global::System.Int32 exitCode) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ReadRecentLog(global::System.Collections.Generic.IReadOnlyList<global::System.String> lines) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ReadLatestCrashReport(global::System.Object mcPath) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ReadLatestHsErr(global::System.Object mcPath) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ReadNewestFile(global::System.Object dir, global::System.Object pattern) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.ValueTuple<global::Mass.Game.Launcher.Java.CrashReason, global::System.String> Classify(global::System.Object logMc, global::System.Object logCrash, global::System.Object logHs, global::System.UInt32 exitCode) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Nullable<global::System.ValueTuple<global::Mass.Game.Launcher.Java.CrashReason, global::System.String>> AnalyzeExitCode(global::System.UInt32 exitCode) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Nullable<global::System.ValueTuple<global::Mass.Game.Launcher.Java.CrashReason, global::System.String>> AnalyzeCrit1(global::System.Object logMc, global::System.Object logCrash, global::System.Object logHs) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Nullable<global::System.ValueTuple<global::Mass.Game.Launcher.Java.CrashReason, global::System.String>> AnalyzeCrit2(global::System.Object logMc, global::System.Object logCrash) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Nullable<global::System.ValueTuple<global::Mass.Game.Launcher.Java.CrashReason, global::System.String>> AnalyzeCrit3(global::System.Object logMc, global::System.Object logCrash) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Byte IsMixin(global::System.Object log, global::System.IntPtr modName) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ExtractAfter(global::System.Object s, global::System.Object marker) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ExtractBetween(global::System.Object s, global::System.Object start, global::System.Object end) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ExtractDuplicateMod(global::System.Object logMc) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object BuildMessage(global::Mass.Game.Launcher.Java.CrashReason reason, global::System.Object detail) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object BuildWindowsExitCodeMessage(global::System.Object detail, global::System.Object cause) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckFlexibleEnumerator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Java.JavaCrashAnalyzer DecorateSegmentedParameter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.ValueTuple<global::Mass.Game.Launcher.Java.CrashReason, global::System.String> 伀(global::System.Object p0, global::System.Object p1, global::System.Object p2, global::System.UInt32 p3) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.ValueTuple<global::Mass.Game.Launcher.Java.CrashReason, global::System.String> 倀(global::System.Object p0, global::System.Object p1, global::System.Object p2, global::System.UInt32 p3) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object 儀(global::System.Collections.Generic.IReadOnlyList<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object 刀(global::System.Collections.Generic.IReadOnlyList<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object 吀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object 唀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Nullable<global::System.ValueTuple<global::Mass.Game.Launcher.Java.CrashReason, global::System.String>> 搀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object 昀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object 最(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 栀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 椀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Nullable<global::System.ValueTuple<global::Mass.Game.Launcher.Java.CrashReason, global::System.String>> 錀(global::System.Object p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Nullable<global::System.ValueTuple<global::Mass.Game.Launcher.Java.CrashReason, global::System.String>> 鐀(global::System.Object p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object 需(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object 頀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object 餀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object 鴀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object 鸀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 鼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object 케(global::Mass.Game.Launcher.Java.CrashReason p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object 퀀(global::Mass.Game.Launcher.Java.CrashReason p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object 턀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Nullable<global::System.ValueTuple<global::Mass.Game.Launcher.Java.CrashReason, global::System.String>> 픀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Nullable<global::System.ValueTuple<global::Mass.Game.Launcher.Java.CrashReason, global::System.String>> 혀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Nullable<global::System.ValueTuple<global::Mass.Game.Launcher.Java.CrashReason, global::System.String>> _(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Nullable<global::System.ValueTuple<global::Mass.Game.Launcher.Java.CrashReason, global::System.String>> __2(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Nullable<global::System.ValueTuple<global::Mass.Game.Launcher.Java.CrashReason, global::System.String>> __3(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object __4(global::System.Object p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object __5(global::System.Object p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Byte __6(global::System.Object p0, global::System.IntPtr p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Byte __7(global::System.Object p0, global::System.IntPtr p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __8(global::System.Object p0, global::System.Collections.Generic.IReadOnlyList<global::System.String> p1, global::System.UInt32 p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __9(global::System.Object p0, global::System.Collections.Generic.IReadOnlyList<global::System.String> p1, global::System.UInt32 p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __10(global::System.Object p0, global::System.Collections.Generic.IReadOnlyList<global::System.String> p1, global::System.UInt32 p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object __11(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object __12(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public sealed class __c
		{
			public static readonly global::Mass.Game.Launcher.Java.JavaCrashAnalyzer.__c __9;
			public static global::System.Func<global::System.String, global::System.IO.FileInfo> __9__4_0;
			public static global::System.Func<global::System.IO.FileInfo, global::System.Boolean> __9__4_1;
			public static global::System.Func<global::System.IO.FileInfo, global::System.DateTime> __9__4_2;
			static __c() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.IO.FileInfo _ReadNewestFile_b__4_0(global::System.String f) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Boolean _ReadNewestFile_b__4_1(global::System.IO.FileInfo f) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.DateTime _ReadNewestFile_b__4_2(global::System.IO.FileInfo f) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckTransferableProcessor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::Mass.Game.Launcher.Java.JavaCrashAnalyzer.__c FlushExecutor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Game.Launcher.Java {
	public abstract class JavaGame
	{
		public readonly global::System.String Name;
		public readonly global::Mass.Application.Desktop.DesktopSession Session;
		public readonly global::System.String GameId;
		public readonly global::Mass.Domain.Desktop.ValueObjects.EnumGameType GameType;
		public readonly global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion GameVersion;
		public readonly global::System.String ServerAddress;
		public readonly global::System.Int32 ServerPort;
		private global::Mass.Game.Launcher.Java.JavaLog Log { get; }
		private global::System.Threading.CancellationTokenSource ReconnectCts { get; set; }
		private global::Mass.Game.Launcher.Java.Option.JavaGameOption GameOptions { get; set; }
		public global::System.Collections.Generic.List<global::Mass.Game.Launcher.Paths.ComponentPath> Components { get; set; }
		public global::Mass.Game.Launcher.Paths.ServerModPath ServerModPath { get; set; }
		private static global::Serilog.ILogger Logger { get; }
		public global::System.Boolean Starting { get; set; }
		public global::System.Collections.Generic.List<global::System.UInt64> ComponentList { get; set; }
		public global::System.String ModHashList { get; set; }
		public global::System.Boolean Launched { get; set; }
		private global::System.Diagnostics.Process Process { get; set; }
		private static global::Mass.Game.Launcher.Java.JavaTask Task { get; }
		private global::Mass.Game.Launcher.Values.JavaGameValue Value { get; }
		private global::Mass.Game.Launcher.Paths.JavaGamePath Path { get; }
		public global::Mass.Domain.Entities.EntityProgress Progress { get; set; }
		public global::Mass.Domain.ValueObjects.EnumStepPhase LastPhase { get; set; }
		public global::Mass.Game.Launcher.Enums.JavaStep LastStep { get; set; }
		private global::Mass.Game.Proxy.GameProxy Proxy { get; set; }
		private global::Mass.Game.Launcher.Java.JavaRpc Rpc { get; set; }
		private global::Mass.Game.Launcher.Java.JavaAuthenticator Authenticator { get; set; }
		public global::System.Boolean HasExited { get; set; }
		public global::System.Int32 ExitCode { get; set; }
		public global::System.Int32 ProcessId { get; set; }
		public global::System.Action<global::Mass.Game.Launcher.Java.JavaGame> GameProgressChanged;  // 原为 event，改为字段以避免 add_/remove_ 保留名冲突
		public global::System.Action Disposed;  // 原为 event，改为字段以避免 add_/remove_ 保留名冲突
		private void LaunchPreCheck() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object LaunchStepsAsync() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void Dispose() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void WaitWindow() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void OnDataReceived(global::System.Object sender, global::System.Object e) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object OnDataReceivedAsync(global::System.Object sender, global::System.Object e) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object OnDataReceivedAsync_2(global::System.Object line) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object OnDisconnectedAsync() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void OnGameExit(global::System.Object sender, global::System.Object e) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void PrepareStart() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void PrepareEnvironment() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void PrepareOptions() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void SaveGameOptions() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task PrepareComponentsAsync(global::System.Threading.CancellationToken cancellationToken) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void InstallComponents() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void InstallCoreLib() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task PrepareJreAsync(global::System.Threading.CancellationToken cancellationToken) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task PrepareServerResourceAsync(global::System.Threading.CancellationToken cancellationToken) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void InstallServerResources() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void InstallServerMods() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task PrepareBaseVersionAsync(global::System.Threading.CancellationToken cancellationToken) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task PrepareVersionAsync(global::System.Threading.CancellationToken cancellationToken) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object PreparePackageAsync(global::Mass.Game.Launcher.Enums.JavaStep step, global::System.Object md5, global::System.Object name, global::System.Object url, global::System.Object md5Path, global::System.Object outputPath, global::System.Threading.CancellationToken cancellationToken, global::System.Object before, global::System.Object after) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public JavaGame(global::Mass.Game.Launcher.Java.EntityLaunchJavaGame args) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void add_GameProgressChanged(global::System.Action<global::Mass.Game.Launcher.Java.JavaGame> @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void remove_GameProgressChanged(global::System.Action<global::Mass.Game.Launcher.Java.JavaGame> @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void add_Disposed(global::System.Action @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void remove_Disposed(global::System.Action @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void StartLaunch() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object LaunchAsync() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ReportProgress(global::Mass.Domain.ValueObjects.EnumStepPhase phase, global::Mass.Game.Launcher.Enums.JavaStep step, global::System.UInt32 percentage, global::System.Object message) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void ReportProgress_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object GetStepMessage(global::Mass.Domain.ValueObjects.EnumStepPhase phase, global::Mass.Game.Launcher.Enums.JavaStep step, global::System.Object message) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object GetStepName(global::Mass.Domain.ValueObjects.EnumStepPhase phase, global::Mass.Game.Launcher.Enums.JavaStep step) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void PrepareMods() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object StartGameAsync(global::System.Threading.CancellationToken token) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object StartGameUnsafe(global::System.Threading.CancellationToken token) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.String ToString() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		static JavaGame() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Byte _PrepareComponentsAsync_b__28_4(global::System.Object s) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _PrepareComponentsAsync_b__28_1(global::System.UInt32 p) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _PrepareComponentsAsync_b__28_3(global::System.UInt32 p) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _PrepareJreAsync_b__35_0(global::System.UInt32 p) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _PrepareJreAsync_b__35_1(global::System.UInt32 p) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _PrepareServerResourceAsync_b__36_0() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _PrepareServerResourceAsync_b__36_1() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _PrepareVersionAsync_b__44_0() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _StartGameUnsafe_g__Report_138_0(global::System.IntPtr p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateAdaptableProfiler() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Java.JavaGame ReflectPortableFactory() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___㘀(global::System.Action<global::Mass.Game.Launcher.Java.JavaGame> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___㜀(global::System.Action<global::Mass.Game.Launcher.Java.JavaGame> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___㠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___㤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___㬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___㰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___㴀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___㸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___㼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___䀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___䄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___䈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___䌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ___䐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___䔀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___嘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Byte ___圀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Byte ___堀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___夀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___娀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___氀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___洀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___渀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___漀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___瀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___焀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::Mass.Game.Launcher.Paths.ComponentPath> ___爀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::Mass.Game.Launcher.Paths.ComponentPath> ___猀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::Mass.Game.Launcher.Paths.ComponentPath> ___琀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___甀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___瘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___眀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___砀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___礀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___稀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Game.Launcher.Enums.JavaStep ___笀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Game.Launcher.Enums.JavaStep ___簀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___紀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___縀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___耀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___脀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___舀(global::Mass.Domain.ValueObjects.EnumStepPhase p0, global::Mass.Game.Launcher.Enums.JavaStep p1, global::System.UInt32 p2, global::System.Object p3) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___茀(global::Mass.Domain.ValueObjects.EnumStepPhase p0, global::Mass.Game.Launcher.Enums.JavaStep p1, global::System.UInt32 p2, global::System.Object p3) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___萀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.ValueObjects.EnumStepPhase ___蔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.ValueObjects.EnumStepPhase ___蘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___蜀(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___蠀(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___褀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___言() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___謀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___谀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___贀(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___踀(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___輀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___退() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___鄀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___鈀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___錀(global::System.Collections.Generic.List<global::System.UInt64> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___鐀(global::System.Collections.Generic.List<global::System.UInt64> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___需() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___頀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___餀(global::System.Action<global::Mass.Game.Launcher.Java.JavaGame> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___騀(global::System.Action<global::Mass.Game.Launcher.Java.JavaGame> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___鬀(global::System.Action<global::Mass.Game.Launcher.Java.JavaGame> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___鰀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___鴀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___鸀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___鼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___ꀀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___ꄀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___ꈀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___ꌀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___ꐀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___ꔀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___ꘀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___ꠀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___꤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___ꨀ(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____2(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___가(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___관(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___글(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___꼀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___뀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___넀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___섀(global::Mass.Domain.ValueObjects.EnumStepPhase p0, global::Mass.Game.Launcher.Enums.JavaStep p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___숀(global::Mass.Domain.ValueObjects.EnumStepPhase p0, global::Mass.Game.Launcher.Enums.JavaStep p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___쌀(global::Mass.Domain.ValueObjects.EnumStepPhase p0, global::Mass.Game.Launcher.Enums.JavaStep p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___쐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___씀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___였() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___윀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___저() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___준(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___쨀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___촀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___츀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___케() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___퀀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___턀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___툀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___팀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___퐀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___픀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___혀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___휀(global::System.IntPtr p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _____3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____4(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____5(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____6(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____7(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____8(global::Mass.Game.Launcher.Enums.JavaStep p0, global::System.Object p1, global::System.Object p2, global::System.Object p3, global::System.Object p4, global::System.Object p5, global::System.Threading.CancellationToken p6, global::System.Object p7, global::System.Object p8) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____9(global::Mass.Game.Launcher.Enums.JavaStep p0, global::System.Object p1, global::System.Object p2, global::System.Object p3, global::System.Object p4, global::System.Object p5, global::System.Threading.CancellationToken p6, global::System.Object p7, global::System.Object p8) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____10(global::Mass.Game.Launcher.Enums.JavaStep p0, global::System.Object p1, global::System.Object p2, global::System.Object p3, global::System.Object p4, global::System.Object p5, global::System.Threading.CancellationToken p6, global::System.Object p7, global::System.Object p8) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____11(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____12(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____13() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____14() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____15() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____16() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____17() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____18(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____19(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____20() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____21() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____22() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____23(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____24(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____25(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____26(global::Mass.Game.Launcher.Enums.JavaStep p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___切() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ___ﬀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ___ﰀ(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____27() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____28() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____Ȁ(global::Mass.Domain.ValueObjects.EnumStepPhase p0, global::Mass.Game.Launcher.Enums.JavaStep p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____(global::Mass.Domain.ValueObjects.EnumStepPhase p0, global::Mass.Game.Launcher.Enums.JavaStep p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____Ѐ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ______2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ______3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____ࠀ(global::Mass.Domain.ValueObjects.EnumStepPhase p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______4(global::Mass.Domain.ValueObjects.EnumStepPhase p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______5(global::Mass.Domain.ValueObjects.EnumStepPhase p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______6(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______7(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______8(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ______9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____ༀ(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____က(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____ᄀ(global::System.Collections.Generic.List<global::Mass.Game.Launcher.Paths.ComponentPath> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____ሀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____ጀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ______10(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____ᔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____ᘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____ᜀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ______11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____ᤀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____ᨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ______12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ____ᰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ____ᴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ______13(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______14(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______15(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______16(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ______17(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ______18() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ______19() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ____Ⰰ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ____ⴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ______20() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ______21() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ______22() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ______23(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ______24() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____㐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____㔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.UInt64> ____㘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.UInt64> ____㜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public sealed class __c
		{
			public static readonly global::Mass.Game.Launcher.Java.JavaGame.__c __9;
			public static global::System.Func<global::Mass.Game.Launcher.Paths.ComponentPath, global::System.ValueTuple<global::System.String, global::System.String>> __9__28_0;
			public static global::System.Func<global::Mass.Game.Launcher.Paths.ComponentPath, global::System.ValueTuple<global::System.String, global::System.String>> __9__28_2;
			public static global::System.Func<global::Mass.Game.Launcher.Paths.ComponentPath, global::System.Boolean> __9__33_0;
			public static global::System.Func<global::Mass.Game.Launcher.Paths.ComponentPath, global::System.String> __9__33_1;
			public static global::System.Func<global::Mass.Game.Launcher.Paths.ComponentPath, global::System.Boolean> __9__33_2;
			internal static global::Mass.Game.Launcher.Java.JavaGame.__c DecorateSortedConverter;
			static __c() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.ValueTuple<global::System.String, global::System.String> _PrepareComponentsAsync_b__28_0(global::Mass.Game.Launcher.Paths.ComponentPath p) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.ValueTuple<global::System.String, global::System.String> _PrepareComponentsAsync_b__28_2(global::Mass.Game.Launcher.Paths.ComponentPath p) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Boolean _InstallComponents_b__33_0(global::Mass.Game.Launcher.Paths.ComponentPath c) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.String _InstallComponents_b__33_1(global::Mass.Game.Launcher.Paths.ComponentPath c) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Boolean _InstallComponents_b__33_2(global::Mass.Game.Launcher.Paths.ComponentPath c) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectCombinedVerifier() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::Mass.Game.Launcher.Java.JavaGame.__c ReflectTransformableAnnotation() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct __c__DisplayClass138_0
		{
			public global::Mass.Game.Launcher.Java.JavaGame __4__this;
			public global::System.Int32 percentage;
		}

		public sealed class __c__DisplayClass45_0
		{
			public global::Mass.Game.Launcher.Java.JavaGame __4__this;
			public global::Mass.Game.Launcher.Enums.JavaStep step;
			internal static global::Mass.Game.Launcher.Java.JavaGame.__c__DisplayClass45_0 CheckAttachedConsumer;
			public __c__DisplayClass45_0() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void _PreparePackageAsync_b__0(global::System.Int32 p) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void _PreparePackageAsync_b__1(global::System.Int32 p) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckGlobalStrategy() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::Mass.Game.Launcher.Java.JavaGame.__c__DisplayClass45_0 DecorateDetachedSorter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 䜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 䠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 䤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 䨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 䬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void 䰀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void 䴀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void 一(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _LaunchAsync_d__106
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.JavaGame __4__this;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaGame._LaunchAsync_d__106 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaGame._LaunchAsync_d__106 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateDividedEmitter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateGeneralRunner() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 㼀(ref global::Mass.Game.Launcher.Java.JavaGame._LaunchAsync_d__106 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 䀀(ref global::Mass.Game.Launcher.Java.JavaGame._LaunchAsync_d__106 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 䄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 䈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 䌀(ref global::Mass.Game.Launcher.Java.JavaGame._LaunchAsync_d__106 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 䐀(ref global::Mass.Game.Launcher.Java.JavaGame._LaunchAsync_d__106 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 䔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 䘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _LaunchStepsAsync_d__2
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.JavaGame __4__this;
			internal static global::System.Object DetachChooser;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaGame._LaunchStepsAsync_d__2 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaGame._LaunchStepsAsync_d__2 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckVisibleListener() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateCentralTracker() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 㔀(ref global::Mass.Game.Launcher.Java.JavaGame._LaunchStepsAsync_d__2 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 㘀(ref global::Mass.Game.Launcher.Java.JavaGame._LaunchStepsAsync_d__2 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 㜀(ref global::Mass.Game.Launcher.Java.JavaGame._LaunchStepsAsync_d__2 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 㠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 㤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 㨀(ref global::Mass.Game.Launcher.Java.JavaGame._LaunchStepsAsync_d__2 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 㬀(ref global::Mass.Game.Launcher.Java.JavaGame._LaunchStepsAsync_d__2 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 㰀(ref global::Mass.Game.Launcher.Java.JavaGame._LaunchStepsAsync_d__2 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 㴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 㸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _OnDataReceivedAsync_d__12
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::System.Diagnostics.DataReceivedEventArgs e;
			public global::Mass.Game.Launcher.Java.JavaGame __4__this;
			internal static global::System.Object DecorateStatelessFinalizer;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaGame._OnDataReceivedAsync_d__12 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaGame._OnDataReceivedAsync_d__12 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckScheduledAggregator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object JoinDecryptor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void Ⰰ(ref global::Mass.Game.Launcher.Java.JavaGame._OnDataReceivedAsync_d__12 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ⴀ(ref global::Mass.Game.Launcher.Java.JavaGame._OnDataReceivedAsync_d__12 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __4(ref global::Mass.Game.Launcher.Java.JavaGame._OnDataReceivedAsync_d__12 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __5(ref global::Mass.Game.Launcher.Java.JavaGame._OnDataReceivedAsync_d__12 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 㐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _OnDataReceivedAsync_d__13
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.JavaGame __4__this;
			public global::System.String line;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaGame._OnDataReceivedAsync_d__13 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaGame._OnDataReceivedAsync_d__13 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ChangeCache() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CustomizeUser() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _(ref global::Mass.Game.Launcher.Java.JavaGame._OnDataReceivedAsync_d__13 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __2(ref global::Mass.Game.Launcher.Java.JavaGame._OnDataReceivedAsync_d__13 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __5(ref global::Mass.Game.Launcher.Java.JavaGame._OnDataReceivedAsync_d__13 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __6(ref global::Mass.Game.Launcher.Java.JavaGame._OnDataReceivedAsync_d__13 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _OnDisconnectedAsync_d__14
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.JavaGame __4__this;
			internal static global::System.Object CheckOperationalAnalyzer;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaGame._OnDisconnectedAsync_d__14 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaGame._OnDisconnectedAsync_d__14 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean InstantiatePublisher() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateIdentifiableNotifier() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _(ref global::Mass.Game.Launcher.Java.JavaGame._OnDisconnectedAsync_d__14 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ᔀ(ref global::Mass.Game.Launcher.Java.JavaGame._OnDisconnectedAsync_d__14 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ᘀ(ref global::Mass.Game.Launcher.Java.JavaGame._OnDisconnectedAsync_d__14 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ᜀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void Ḁ(ref global::Mass.Game.Launcher.Java.JavaGame._OnDisconnectedAsync_d__14 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ἀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _PrepareBaseVersionAsync_d__43
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.JavaGame __4__this;
			public global::System.Threading.CancellationToken cancellationToken;
			internal static global::System.Object AttachMap;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareBaseVersionAsync_d__43 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareBaseVersionAsync_d__43 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean AddVisitor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectInternalParser() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareBaseVersionAsync_d__43 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __2(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareBaseVersionAsync_d__43 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __3(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareBaseVersionAsync_d__43 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ༀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void က(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareBaseVersionAsync_d__43 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ᄀ(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareBaseVersionAsync_d__43 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ሀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ጀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _PrepareComponentsAsync_d__28
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.JavaGame __4__this;
			public global::System.Threading.CancellationToken cancellationToken;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareComponentsAsync_d__28 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareComponentsAsync_d__28 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckHiddenHandler() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckAdjustableStruct() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______ﴀ(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareComponentsAsync_d__28 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ________(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareComponentsAsync_d__28 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _________2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object Ā() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ࠀ(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareComponentsAsync_d__28 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _PrepareJreAsync_d__35
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.JavaGame __4__this;
			public global::System.Threading.CancellationToken cancellationToken;
			internal static global::System.Object StoreDic;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareJreAsync_d__35 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareJreAsync_d__35 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectRandomChain() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckCustomEnumerator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ________(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareJreAsync_d__35 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _________2(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareJreAsync_d__35 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _________3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _________4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______豈(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareJreAsync_d__35 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______切(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareJreAsync_d__35 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______ﬀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______ﰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _PreparePackageAsync_d__45
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.JavaGame __4__this;
			public global::Mass.Game.Launcher.Enums.JavaStep step;
			public global::System.String md5Path;
			public global::System.String md5;
			public global::System.Action before;
			public global::System.String name;
			public global::System.String url;
			public global::System.Threading.CancellationToken cancellationToken;
			public global::System.String outputPath;
			public global::System.Action after;
			internal static global::System.Object EncodeArgument;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaGame._PreparePackageAsync_d__45 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaGame._PreparePackageAsync_d__45 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ExcludeSummarizer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckMixedProfiler() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ________(ref global::Mass.Game.Launcher.Java.JavaGame._PreparePackageAsync_d__45 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _________2(ref global::Mass.Game.Launcher.Java.JavaGame._PreparePackageAsync_d__45 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _________3(ref global::Mass.Game.Launcher.Java.JavaGame._PreparePackageAsync_d__45 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _________4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _________5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _________6(ref global::Mass.Game.Launcher.Java.JavaGame._PreparePackageAsync_d__45 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _________7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _________8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _PrepareServerResourceAsync_d__36
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.JavaGame __4__this;
			public global::System.Threading.CancellationToken cancellationToken;
			internal static global::System.Object DecorateFlexibleFactory;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareServerResourceAsync_d__36 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareServerResourceAsync_d__36 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean PresentAuditor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectCommonResponder() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ________(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareServerResourceAsync_d__36 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _________2(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareServerResourceAsync_d__36 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _________3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _________4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _________5(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareServerResourceAsync_d__36 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _________6(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareServerResourceAsync_d__36 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _________7(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareServerResourceAsync_d__36 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _________8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _PrepareVersionAsync_d__44
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.JavaGame __4__this;
			public global::System.Threading.CancellationToken cancellationToken;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareVersionAsync_d__44 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareVersionAsync_d__44 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecoratePortableEncryptor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ArrangeContext() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ________(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareVersionAsync_d__44 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _________2(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareVersionAsync_d__44 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _________3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _________4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _________5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _________6(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareVersionAsync_d__44 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _________7(ref global::Mass.Game.Launcher.Java.JavaGame._PrepareVersionAsync_d__44 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _________8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _StartGameAsync_d__137
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.JavaGame __4__this;
			public global::System.Threading.CancellationToken token;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaGame._StartGameAsync_d__137 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaGame._StartGameAsync_d__137 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckRemoteAllocator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectActiveQueue() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______턀(ref global::Mass.Game.Launcher.Java.JavaGame._StartGameAsync_d__137 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______툀(ref global::Mass.Game.Launcher.Java.JavaGame._StartGameAsync_d__137 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______팀(ref global::Mass.Game.Launcher.Java.JavaGame._StartGameAsync_d__137 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______퐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______픀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______혀(ref global::Mass.Game.Launcher.Java.JavaGame._StartGameAsync_d__137 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______휀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ________() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _________2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _StartGameUnsafe_d__138
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.JavaGame __4__this;
			public global::System.Threading.CancellationToken token;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaGame._StartGameUnsafe_d__138 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaGame._StartGameUnsafe_d__138 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckLiteralWorker() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateScalableProvider() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______저(ref global::Mass.Game.Launcher.Java.JavaGame._StartGameUnsafe_d__138 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______준(ref global::Mass.Game.Launcher.Java.JavaGame._StartGameUnsafe_d__138 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______쨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______쬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______츀(ref global::Mass.Game.Launcher.Java.JavaGame._StartGameUnsafe_d__138 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______케() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______퀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Game.Launcher.Java {
	public class EntityLaunchJavaGame
	{
		internal static global::Mass.Game.Launcher.Java.EntityLaunchJavaGame ConcatSingleton;
		protected global::System.Type EqualityContract { get; }
		public global::Mass.Application.Desktop.DesktopSession Session { get; set; }
		public global::System.String GameId { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameType GameType { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion GameVersion { get; set; }
		public global::System.String Name { get; set; }
		public global::System.String ServerAddress { get; set; }
		public global::System.Int32 ServerPort { get; set; }
		public global::Mass.Domain.Value.SectionValue GameValue { get; set; }
		public global::Mass.Domain.Value.SectionValue ProxyValue { get; set; }
		public global::System.Boolean BlockIrcMessages { get; set; }
		public EntityLaunchJavaGame(global::Mass.Application.Desktop.DesktopSession Session, global::System.String GameId, global::Mass.Domain.Desktop.ValueObjects.EnumGameType GameType, global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion GameVersion, global::System.String Name, global::System.String ServerAddress, global::System.Int32 ServerPort, global::Mass.Domain.Value.SectionValue GameValue, global::Mass.Domain.Value.SectionValue ProxyValue, global::System.Boolean BlockIrcMessages) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.String ToString() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected global::System.Boolean PrintMembers(global::System.Text.StringBuilder builder) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.Boolean op_Inequality(global::Mass.Game.Launcher.Java.EntityLaunchJavaGame left, global::Mass.Game.Launcher.Java.EntityLaunchJavaGame right) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.Boolean op_Equality(global::Mass.Game.Launcher.Java.EntityLaunchJavaGame left, global::Mass.Game.Launcher.Java.EntityLaunchJavaGame right) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Int32 GetHashCode() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Boolean Equals(global::System.Object obj) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Boolean Equals_2(global::Mass.Game.Launcher.Java.EntityLaunchJavaGame other) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::Mass.Game.Launcher.Java.EntityLaunchJavaGame _Clone__() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected EntityLaunchJavaGame(global::Mass.Game.Launcher.Java.EntityLaunchJavaGame original) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void Deconstruct(out global::Mass.Application.Desktop.DesktopSession Session, out global::System.String GameId, out global::Mass.Domain.Desktop.ValueObjects.EnumGameType GameType, out global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion GameVersion, out global::System.String Name, out global::System.String ServerAddress, out global::System.Int32 ServerPort, out global::Mass.Domain.Value.SectionValue GameValue, out global::Mass.Domain.Value.SectionValue ProxyValue, out global::System.Boolean BlockIrcMessages) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectReadableResponder() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Java.EntityLaunchJavaGame SetState() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _______萀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _______蔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion _______蘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion _______蜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected global::System.Object _______蠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected global::System.Object _______褀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______言() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______謀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _______谀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______贀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______踀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object _______輀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object _______退(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object _______鄀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______鈀(global::System.IntPtr p0, global::System.IntPtr p1, global::System.IntPtr p2, global::System.IntPtr p3, global::System.IntPtr p4, global::System.IntPtr p5, global::System.IntPtr p6, global::System.IntPtr p7, global::System.IntPtr p8, global::System.IntPtr p9) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______錀(global::System.IntPtr p0, global::System.IntPtr p1, global::System.IntPtr p2, global::System.IntPtr p3, global::System.IntPtr p4, global::System.IntPtr p5, global::System.IntPtr p6, global::System.IntPtr p7, global::System.IntPtr p8, global::System.IntPtr p9) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object _______鐀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object _______销(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object _______阀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object _______需(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object _______頀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______餀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______騀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected global::System.Byte _______鼀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected global::System.Byte _______ꀀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______ꄀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______ꈀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______ꌀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______ꐀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______ꔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object _______ꘀ(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object ________(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object _______ꠀ(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object _______꤀(global::Mass.Domain.Desktop.ValueObjects.EnumGameType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______ꨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _________2(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _______가(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType _______관() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType _______글() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object _______꼀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object _______뀀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______넀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______눀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______대() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______됀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______딀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______똀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object _______뜀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object _______렀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object _______뤀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object _______먀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _______묀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _______밀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _______봀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object _______븀(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object _______뼀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object _______쀀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _______섀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _______숀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______쌀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______쐀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______씀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______윀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Java {
	public class JavaLog
	{
		public readonly global::System.String Disconnect;
		internal static global::Mass.Game.Launcher.Java.JavaLog DecorateActiveEncryptor;
		public JavaLog(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion version) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean SearchStruct() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Java.JavaLog DecorateLiteralFinder() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______紀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______縀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______舀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______茀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Java {
	public abstract class JavaRpc
	{
		internal static global::Mass.Game.Launcher.Java.JavaRpc ReflectScalableAllocator;
		private static global::Serilog.ILogger Logger { get; }
		private global::Mass.Application.Desktop.DesktopSession Session { get; }
		private global::System.String ServerAddress { get; }
		private global::System.Int32 ServerPort { get; }
		private global::System.String CharacterName { get; }
		private global::Mass.Domain.Desktop.ValueObjects.EnumGameType Type { get; }
		public JavaRpc(global::Mass.Application.Desktop.DesktopSession session, global::Mass.Domain.Desktop.ValueObjects.EnumGameType type, global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion version, global::System.String serverAddress, global::System.Int32 serverPort, global::System.String characterName) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected void RegisterCallBack(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion version) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task ClientShieldCheckAsync(global::Mass.Game.Launcher.Models.RpcCallBack callBack) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task GameChatOtherAsync(global::Mass.Game.Launcher.Models.RpcCallBack callBack) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task FilterSalogAsync(global::Mass.Game.Launcher.Models.RpcCallBack callBack) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task PlayerBaseInfoAsync(global::Mass.Game.Launcher.Models.RpcCallBack callBack) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task CheckPlayerMsgAsync(global::Mass.Game.Launcher.Models.RpcCallBack callBack) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task PCycEntityCheckAsync(global::Mass.Game.Launcher.Models.RpcCallBack callBack) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task AuthenticationNewVersionAsync(global::Mass.Game.Launcher.Models.RpcCallBack callBack) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task HeartBeatAsync(global::Mass.Game.Launcher.Models.RpcCallBack callBack) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task AuthenticationAsync(global::Mass.Game.Launcher.Models.RpcCallBack callBack) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void SendReconnect() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void SendReconnect_2(global::System.Object writer) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task PlayerSkinAsync(global::Mass.Game.Launcher.Models.RpcCallBack callBack) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task MsgFilterCheckAsync(global::Mass.Game.Launcher.Models.RpcCallBack callBack) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task LoginGameAsync(global::Mass.Game.Launcher.Models.RpcCallBack callBack) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		static JavaRpc() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckModularInitializer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Java.JavaRpc ReflectGroupedPublisher() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ____㠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ____㤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ____㨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____㬀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____㰀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____㴀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____㸀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____㼀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____䀀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::Mass.Domain.Desktop.ValueObjects.EnumGameType ____䄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::Mass.Domain.Desktop.ValueObjects.EnumGameType ____䈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____䌀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____䐀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____䔀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____䘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____䜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____䠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____䤀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____䨀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.UInt32 ____䬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.UInt32 ____䰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____䴀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____伀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____倀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____儀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____刀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____匀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____吀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____唀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____嘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____圀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected void ____堀(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected void ____夀(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____娀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____嬀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____尀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____崀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____帀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____开() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____怀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____愀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____戀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____挀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____搀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____攀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____昀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public struct _AuthenticationAsync_d__28
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.JavaRpc __4__this;
			public global::Mass.Game.Launcher.Models.RpcCallBack callBack;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaRpc._AuthenticationAsync_d__28 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaRpc._AuthenticationAsync_d__28 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean NewContainer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckConverter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______甀(ref global::Mass.Game.Launcher.Java.JavaRpc._AuthenticationAsync_d__28 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______瘀(ref global::Mass.Game.Launcher.Java.JavaRpc._AuthenticationAsync_d__28 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______眀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______砀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______礀(ref global::Mass.Game.Launcher.Java.JavaRpc._AuthenticationAsync_d__28 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______稀(ref global::Mass.Game.Launcher.Java.JavaRpc._AuthenticationAsync_d__28 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______笀(ref global::Mass.Game.Launcher.Java.JavaRpc._AuthenticationAsync_d__28 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______簀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _AuthenticationNewVersionAsync_d__26
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Models.RpcCallBack callBack;
			public global::Mass.Game.Launcher.Java.JavaRpc __4__this;
			internal static global::System.Object DecorateIsolatedDriver;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaRpc._AuthenticationNewVersionAsync_d__26 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaRpc._AuthenticationNewVersionAsync_d__26 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectAutomatableWriter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object EvaluateComparator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______氀(ref global::Mass.Game.Launcher.Java.JavaRpc._AuthenticationNewVersionAsync_d__26 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______洀(ref global::Mass.Game.Launcher.Java.JavaRpc._AuthenticationNewVersionAsync_d__26 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______渀(ref global::Mass.Game.Launcher.Java.JavaRpc._AuthenticationNewVersionAsync_d__26 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______漀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______瀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______焀(ref global::Mass.Game.Launcher.Java.JavaRpc._AuthenticationNewVersionAsync_d__26 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______爀(ref global::Mass.Game.Launcher.Java.JavaRpc._AuthenticationNewVersionAsync_d__26 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______猀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______琀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _CheckPlayerMsgAsync_d__24
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Models.RpcCallBack callBack;
			internal static global::System.Object CheckIntegratedObject;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaRpc._CheckPlayerMsgAsync_d__24 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaRpc._CheckPlayerMsgAsync_d__24 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckLocalDecorator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectSymbolicArgument() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______攀(ref global::Mass.Game.Launcher.Java.JavaRpc._CheckPlayerMsgAsync_d__24 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______昀(ref global::Mass.Game.Launcher.Java.JavaRpc._CheckPlayerMsgAsync_d__24 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______最() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______栀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______椀(ref global::Mass.Game.Launcher.Java.JavaRpc._CheckPlayerMsgAsync_d__24 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______樀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______欀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _ClientShieldCheckAsync_d__20
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Models.RpcCallBack callBack;
			internal static global::System.Object DecorateConfigurableSummarizer;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaRpc._ClientShieldCheckAsync_d__20 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaRpc._ClientShieldCheckAsync_d__20 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectSeparatedProgram() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckMonoTemplate() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______崀(ref global::Mass.Game.Launcher.Java.JavaRpc._ClientShieldCheckAsync_d__20 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______帀(ref global::Mass.Game.Launcher.Java.JavaRpc._ClientShieldCheckAsync_d__20 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______开() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______怀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______愀(ref global::Mass.Game.Launcher.Java.JavaRpc._ClientShieldCheckAsync_d__20 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______戀(ref global::Mass.Game.Launcher.Java.JavaRpc._ClientShieldCheckAsync_d__20 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______挀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______搀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _FilterSalogAsync_d__22
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Models.RpcCallBack callBack;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaRpc._FilterSalogAsync_d__22 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaRpc._FilterSalogAsync_d__22 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckVisualDecider() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateScopeList() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______唀(ref global::Mass.Game.Launcher.Java.JavaRpc._FilterSalogAsync_d__22 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______嘀(ref global::Mass.Game.Launcher.Java.JavaRpc._FilterSalogAsync_d__22 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______圀(ref global::Mass.Game.Launcher.Java.JavaRpc._FilterSalogAsync_d__22 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______堀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______夀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______娀(ref global::Mass.Game.Launcher.Java.JavaRpc._FilterSalogAsync_d__22 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______嬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______尀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _GameChatOtherAsync_d__21
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaRpc._GameChatOtherAsync_d__21 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaRpc._GameChatOtherAsync_d__21 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ResetTracker() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ObserveFinalizer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______䴀(ref global::Mass.Game.Launcher.Java.JavaRpc._GameChatOtherAsync_d__21 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______一(ref global::Mass.Game.Launcher.Java.JavaRpc._GameChatOtherAsync_d__21 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______伀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______倀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______儀(ref global::Mass.Game.Launcher.Java.JavaRpc._GameChatOtherAsync_d__21 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______刀(ref global::Mass.Game.Launcher.Java.JavaRpc._GameChatOtherAsync_d__21 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______匀(ref global::Mass.Game.Launcher.Java.JavaRpc._GameChatOtherAsync_d__21 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______吀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _HeartBeatAsync_d__27
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Models.RpcCallBack callBack;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaRpc._HeartBeatAsync_d__27 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaRpc._HeartBeatAsync_d__27 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateAlphabeticRequester() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateEditableModule() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______䌀(ref global::Mass.Game.Launcher.Java.JavaRpc._HeartBeatAsync_d__27 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______䐀(ref global::Mass.Game.Launcher.Java.JavaRpc._HeartBeatAsync_d__27 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______䔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______䘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______䜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______䨀(ref global::Mass.Game.Launcher.Java.JavaRpc._HeartBeatAsync_d__27 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______䬀(ref global::Mass.Game.Launcher.Java.JavaRpc._HeartBeatAsync_d__27 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______䰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _LoginGameAsync_d__33
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			internal static global::System.Object DecorateLogicalEvent;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaRpc._LoginGameAsync_d__33 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaRpc._LoginGameAsync_d__33 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecodeRecommender() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectControllableProcessor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______㤀(ref global::Mass.Game.Launcher.Java.JavaRpc._LoginGameAsync_d__33 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______㨀(ref global::Mass.Game.Launcher.Java.JavaRpc._LoginGameAsync_d__33 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______㬀(ref global::Mass.Game.Launcher.Java.JavaRpc._LoginGameAsync_d__33 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______㰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______㴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______㼀(ref global::Mass.Game.Launcher.Java.JavaRpc._LoginGameAsync_d__33 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______䀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______䄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______䈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _MsgFilterCheckAsync_d__32
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Models.RpcCallBack callBack;
			internal static global::System.Object ReflectTransferableContainer;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaRpc._MsgFilterCheckAsync_d__32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaRpc._MsgFilterCheckAsync_d__32 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean AssessNotifier() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object HandleDispatcher() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ________(ref global::Mass.Game.Launcher.Java.JavaRpc._MsgFilterCheckAsync_d__32 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _________2(ref global::Mass.Game.Launcher.Java.JavaRpc._MsgFilterCheckAsync_d__32 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _________3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______㐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______㔀(ref global::Mass.Game.Launcher.Java.JavaRpc._MsgFilterCheckAsync_d__32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______㘀(ref global::Mass.Game.Launcher.Java.JavaRpc._MsgFilterCheckAsync_d__32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______㜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______㠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _PCycEntityCheckAsync_d__25
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaRpc._PCycEntityCheckAsync_d__25 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaRpc._PCycEntityCheckAsync_d__25 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean PushParser() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectSequentialBridge() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ________(ref global::Mass.Game.Launcher.Java.JavaRpc._PCycEntityCheckAsync_d__25 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _________2(ref global::Mass.Game.Launcher.Java.JavaRpc._PCycEntityCheckAsync_d__25 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _________3(ref global::Mass.Game.Launcher.Java.JavaRpc._PCycEntityCheckAsync_d__25 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______Ⰰ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______ⴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _________4(ref global::Mass.Game.Launcher.Java.JavaRpc._PCycEntityCheckAsync_d__25 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _________5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _________6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _PlayerBaseInfoAsync_d__23
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaRpc._PlayerBaseInfoAsync_d__23 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaRpc._PlayerBaseInfoAsync_d__23 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean AnalyzeStruct() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object SetReporter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ________(ref global::Mass.Game.Launcher.Java.JavaRpc._PlayerBaseInfoAsync_d__23 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _________2(ref global::Mass.Game.Launcher.Java.JavaRpc._PlayerBaseInfoAsync_d__23 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _________3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _________4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _________5(ref global::Mass.Game.Launcher.Java.JavaRpc._PlayerBaseInfoAsync_d__23 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _________6(ref global::Mass.Game.Launcher.Java.JavaRpc._PlayerBaseInfoAsync_d__23 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _________7(ref global::Mass.Game.Launcher.Java.JavaRpc._PlayerBaseInfoAsync_d__23 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _________8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _PlayerSkinAsync_d__31
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Models.RpcCallBack callBack;
			public global::Mass.Game.Launcher.Java.JavaRpc __4__this;
			internal static global::System.Object DecorateGlobalSorter;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaRpc._PlayerSkinAsync_d__31 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaRpc._PlayerSkinAsync_d__31 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectDetachedConfig() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectDetailedEmitter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______ᘀ(ref global::Mass.Game.Launcher.Java.JavaRpc._PlayerSkinAsync_d__31 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______ᜀ(ref global::Mass.Game.Launcher.Java.JavaRpc._PlayerSkinAsync_d__31 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ________() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______ᤀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______ᨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______Ḁ(ref global::Mass.Game.Launcher.Java.JavaRpc._PlayerSkinAsync_d__31 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______ἀ(ref global::Mass.Game.Launcher.Java.JavaRpc._PlayerSkinAsync_d__31 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _________2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Game.Launcher.Java {
	public sealed class JavaTask
	{
		internal static global::Mass.Game.Launcher.Java.JavaTask DecorateAccessibleTransformer;
		public global::System.Threading.Tasks.Task CallPrepareJre(global::Mass.Game.Launcher.Java.JavaGame game, global::System.Threading.CancellationToken cancellationToken) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task CallPrepareBaseVersion(global::Mass.Game.Launcher.Java.JavaGame game, global::System.Threading.CancellationToken cancellationToken) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task CallPrepareVersion(global::Mass.Game.Launcher.Java.JavaGame game, global::System.Threading.CancellationToken cancellationToken) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task CallPrepareComponents(global::Mass.Game.Launcher.Java.JavaGame game, global::System.Threading.CancellationToken cancellationToken) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task CallPrepareServerResource(global::Mass.Game.Launcher.Java.JavaGame game, global::System.Threading.CancellationToken cancellationToken) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object Call(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion version, global::System.Object id, global::Mass.Game.Launcher.Enums.JavaStep step, global::System.Object caller, global::System.Func<global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task> factory, global::System.Threading.CancellationToken cancellationToken) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public JavaTask() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateIsolatedMap() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Java.JavaTask CheckAutomatableVisitor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________(global::System.Object p0, global::System.Threading.CancellationToken p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______ࠀ(global::System.Object p0, global::System.Threading.CancellationToken p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _________2(global::System.Object p0, global::System.Threading.CancellationToken p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _________3(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0, global::System.Object p1, global::Mass.Game.Launcher.Enums.JavaStep p2, global::System.Object p3, global::System.Func<global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task> p4, global::System.Threading.CancellationToken p5) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _________4(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0, global::System.Object p1, global::Mass.Game.Launcher.Enums.JavaStep p2, global::System.Object p3, global::System.Func<global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task> p4, global::System.Threading.CancellationToken p5) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _________5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _________6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _________7(global::System.Object p0, global::System.Threading.CancellationToken p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______ༀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______က() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______ᄀ(global::System.Object p0, global::System.Threading.CancellationToken p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______ሀ(global::System.Object p0, global::System.Threading.CancellationToken p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______ጀ(global::System.Object p0, global::System.Threading.CancellationToken p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _________8(global::System.Object p0, global::System.Threading.CancellationToken p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______ᔀ(global::System.Object p0, global::System.Threading.CancellationToken p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public struct TaskKey
		{
			public global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion Version { get; set; }
			public global::System.String Id { get; set; }
			public global::Mass.Game.Launcher.Enums.JavaStep Step { get; set; }
			public TaskKey(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0, global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion Version, global::System.String Id, global::Mass.Game.Launcher.Enums.JavaStep Step) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public global::System.String ToString(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private global::System.Byte PrintMembers(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0, global::System.Object builder) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public static global::System.Boolean op_Inequality(global::Mass.Game.Launcher.Java.JavaTask.TaskKey left, global::Mass.Game.Launcher.Java.JavaTask.TaskKey right) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public static global::System.Boolean op_Equality(global::Mass.Game.Launcher.Java.JavaTask.TaskKey left, global::Mass.Game.Launcher.Java.JavaTask.TaskKey right) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public global::System.Int32 GetHashCode(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public global::System.Boolean Equals(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0, global::System.Object obj) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public global::System.Boolean Equals_2(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0, global::Mass.Game.Launcher.Java.JavaTask.TaskKey other) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public void Deconstruct(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0, out global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion Version, out global::System.String Id, out global::Mass.Game.Launcher.Enums.JavaStep Step) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectGeneralClient() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateExtendedListener() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ________2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ________3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void ________4(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0, global::System.IntPtr p1, global::System.IntPtr p2, global::System.IntPtr p3) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Byte ________5(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Byte ________6(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ________7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ________8(global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0, global::Mass.Game.Launcher.Java.JavaTask.TaskKey p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ________9(global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0, global::Mass.Game.Launcher.Java.JavaTask.TaskKey p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ________10(global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0, global::Mass.Game.Launcher.Java.JavaTask.TaskKey p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ________11(global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0, global::Mass.Game.Launcher.Java.JavaTask.TaskKey p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ________12(global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0, global::Mass.Game.Launcher.Java.JavaTask.TaskKey p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ________13(global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0, global::Mass.Game.Launcher.Java.JavaTask.TaskKey p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal object ________14(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0, global::Mass.Game.Launcher.Enums.JavaStep p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal object ________15(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0, global::Mass.Game.Launcher.Enums.JavaStep p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object ________16(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object ________17(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object ________18(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal object ________19(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal object ________20(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object ________21(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private global::System.Byte ________22(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private global::System.Byte ______豈(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private global::System.Byte ______切(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.UInt32 ______ﬀ(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.UInt32 ______ﰀ(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion ______ﴀ(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion ________23(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Byte ________24(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0, global::Mass.Game.Launcher.Java.JavaTask.TaskKey p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Byte _______Ā(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0, global::Mass.Game.Launcher.Java.JavaTask.TaskKey p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Byte _______Ȁ(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0, global::Mass.Game.Launcher.Java.JavaTask.TaskKey p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal object ________(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0, global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal object _______Ѐ(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0, global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::Mass.Game.Launcher.Enums.JavaStep _______Ԁ(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::Mass.Game.Launcher.Enums.JavaStep _________2(ref global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public sealed class TaskEntry
		{
			internal static global::System.Object DecorateVisibleTracker;
			public global::System.Threading.Tasks.Task Task { get; }
			public TaskEntry(global::System.Threading.Tasks.Task task, global::System.Threading.CancellationTokenSource cts) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public global::System.Threading.Tasks.Task AttachCaller(global::System.Threading.CancellationToken callerToken) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private global::System.Object WaitAsync(global::System.Threading.CancellationToken callerToken) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public void BindProgress(global::Mass.Game.Launcher.Java.JavaGame target, global::Mass.Game.Launcher.Enums.JavaStep step) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectCentralFinalizer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::Mass.Game.Launcher.Java.JavaTask.TaskEntry ReflectStatelessAggregator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void ______퐀(global::System.Object p0, global::Mass.Game.Launcher.Enums.JavaStep p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void ______픀(global::System.Object p0, global::Mass.Game.Launcher.Enums.JavaStep p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object ______혀(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object ______휀(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ________2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ________3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ________4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ________5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ________6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private global::System.Object ________7(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private global::System.Object ________8(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object ________9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public sealed class __c__DisplayClass10_0
			{
				public global::Mass.Game.Launcher.Java.JavaTask.TaskEntry __4__this;
				public global::Mass.Game.Launcher.Java.JavaGame source;
				public global::Mass.Game.Launcher.Enums.JavaStep step;
				public global::Mass.Game.Launcher.Java.JavaGame target;
				public __c__DisplayClass10_0() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal void _BindProgress_g__Handler_0(global::Mass.Game.Launcher.Java.JavaGame g) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal void _BindProgress_b__1(global::System.Threading.Tasks.Task p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Boolean ReflectExternalDispatcher() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::Mass.Game.Launcher.Java.JavaTask.TaskEntry.__c__DisplayClass10_0 CheckOperationalSingleton() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Object ______찀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Object ______촀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Object ______츀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Byte ______케() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Byte ______퀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal void ______턀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal void ______툀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal void ______팀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			}

			public struct _WaitAsync_d__9
			{
				public global::System.Int32 __1__state;
				public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
				public global::Mass.Game.Launcher.Java.JavaTask.TaskEntry __4__this;
				public global::System.Threading.CancellationToken callerToken;
				private void MoveNext(ref global::Mass.Game.Launcher.Java.JavaTask.TaskEntry._WaitAsync_d__9 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				private void SetStateMachine(ref global::Mass.Game.Launcher.Java.JavaTask.TaskEntry._WaitAsync_d__9 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Boolean DeleteTree() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Object CheckInterruptibleHandler() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				private void ______쐀(ref global::Mass.Game.Launcher.Java.JavaTask.TaskEntry._WaitAsync_d__9 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				private void ______씀(ref global::Mass.Game.Launcher.Java.JavaTask.TaskEntry._WaitAsync_d__9 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Object ______였() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Object ______윀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				private void ______저(ref global::Mass.Game.Launcher.Java.JavaTask.TaskEntry._WaitAsync_d__9 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				private void ______준(ref global::Mass.Game.Launcher.Java.JavaTask.TaskEntry._WaitAsync_d__9 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Byte ______쨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Byte ______쬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			}

		}

		public sealed class __c__DisplayClass6_0
		{
			public global::System.Func<global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task> factory;
			public global::Mass.Game.Launcher.Java.JavaTask __4__this;
			public global::Mass.Game.Launcher.Java.JavaTask.TaskKey key;
			internal static global::Mass.Game.Launcher.Java.JavaTask.__c__DisplayClass6_0 CheckScheduledTag;
			public __c__DisplayClass6_0() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::Mass.Game.Launcher.Java.JavaTask.TaskEntry _Call_b__0(global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean AssembleController() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::Mass.Game.Launcher.Java.JavaTask.__c__DisplayClass6_0 AwakeFinder() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object ______봀(global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object ______븀(global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object ______뼀(global::Mass.Game.Launcher.Java.JavaTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ______쀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ______섀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ______숀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ______쌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public sealed class __c__DisplayClass6_1
		{
			public global::System.Threading.CancellationTokenSource cts;
			public global::Mass.Game.Launcher.Java.JavaTask.__c__DisplayClass6_0 CS___8__locals1;
			public __c__DisplayClass6_1() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void _Call_b__1(global::System.Threading.Tasks.Task t) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectExternalAnalyzer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::Mass.Game.Launcher.Java.JavaTask.__c__DisplayClass6_1 ReadSender() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void ______렀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void ______뤀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ______먀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ______묀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ______밀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Game.Launcher.Java.Option {
	public class JavaGameOption
	{
		public global::Mass.Game.Launcher.Java.Option.JavaGameOptionKey Key { get; }
		public global::System.String Language { get; set; }
		public global::System.Drawing.Size WindowSize { get; set; }
		public global::Mass.Game.Launcher.Java.Option.JavaGuiScale GuiScale { get; set; }
		public global::Mass.Game.Launcher.Java.Option.JavaNarrator Narrator { get; set; }
		public global::System.Boolean OnboardAccessibility { get; set; }
		public global::System.Boolean AutoJump { get; set; }
		public global::System.String[] ResourcePacks { get; set; }
		public JavaGameOption(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion version, global::System.String fileName) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::Mass.Game.Launcher.Java.Option.JavaGameOption Open(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion version, global::System.String fileName) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::Mass.Game.Launcher.Java.Option.JavaGameOption Load() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void Overwrite(global::Mass.Game.Launcher.Java.Option.JavaGameOption options) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void Save() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Boolean HasKey(global::System.String key) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public object[] GetArray<T0>(global::System.String key) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void SetArray<T0>(global::System.String key, object[] @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.String GetString(global::System.String key, global::System.String defaultValue) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void SetString(global::System.String key, global::System.String @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Int32 GetInt(global::System.String key, global::System.Int32 defaultValue) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void SetInt(global::System.String key, global::System.Int32 @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Drawing.Size GetSize(global::System.String widthKey, global::System.String heightKey, global::System.Int32 defaultWidth, global::System.Int32 defaultHeight) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void SetSize(global::System.String widthKey, global::System.String heightKey, global::System.Drawing.Size @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public object GetEnum<T0>(global::System.String key, object defaultValue) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void SetEnum<T0>(global::System.String key, object @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Boolean GetBool(global::System.String key, global::System.Boolean defaultValue) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void SetBool(global::System.String key, global::System.Boolean @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateIntegratedElement() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Java.Option.JavaGameOption CheckLocalDriver() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______簀(global::System.Drawing.Size p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______紀(global::System.Drawing.Size p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______縀(global::System.Drawing.Size p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ______缀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ______耀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ______脀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______舀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______茀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______萀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______蔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Game.Launcher.Java.Option.JavaGuiScale ______蘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Game.Launcher.Java.Option.JavaGuiScale ______蜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Game.Launcher.Java.Option.JavaGuiScale ______蠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______褀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______言(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______謀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Game.Launcher.Java.Option.JavaNarrator ______谀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Drawing.Size ______贀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______踀(global::System.Object p0, global::System.Byte p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______輀(global::System.Object p0, global::System.Byte p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______退(global::System.Object p0, global::System.Byte p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______鄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______鈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______錀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ______销(global::System.Object p0, global::System.Byte p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ______阀(global::System.Object p0, global::System.Byte p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ______需() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ______頀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______餀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______騀(global::System.Object p0, global::System.Object p1, global::System.Drawing.Size p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Drawing.Size ______鬀(global::System.Object p0, global::System.Object p1, global::System.UInt32 p2, global::System.UInt32 p3) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Drawing.Size ______鰀(global::System.Object p0, global::System.Object p1, global::System.UInt32 p2, global::System.UInt32 p3) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______鴀(global::Mass.Game.Launcher.Java.Option.JavaGuiScale p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______鸀(global::Mass.Game.Launcher.Java.Option.JavaGuiScale p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______鼀(global::System.Object p0, global::System.UInt32 p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______ꀀ(global::System.Object p0, global::System.UInt32 p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ______ꄀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ______ꈀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ______ꌀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______ꐀ(global::Mass.Game.Launcher.Java.Option.JavaNarrator p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______ꔀ(global::Mass.Game.Launcher.Java.Option.JavaNarrator p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ______ꘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _______() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______ꠀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______꤀(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______ꨀ(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______가() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______관() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______글(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______꼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______뀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______넀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ______눀(global::System.Object p0, global::System.UInt32 p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ______대(global::System.Object p0, global::System.UInt32 p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______됀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______딀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______똀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______뜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public sealed class __c
		{
			public static readonly global::Mass.Game.Launcher.Java.Option.JavaGameOption.__c __9;
			public static global::System.Converter<global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>, global::System.String> __9__30_0;
			static __c() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.String _Save_b__30_0(global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String> kvp) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DeleteProvider() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::Mass.Game.Launcher.Java.Option.JavaGameOption.__c ReflectInterruptibleSingleton() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Game.Launcher.Java.Option {
	public class JavaGameOptionKey
	{
		public readonly global::System.String ResourcePacks;
		public readonly global::System.String Language;
		public readonly global::System.String WindowWidth;
		public readonly global::System.String WindowHeight;
		public readonly global::System.String GuiScale;
		public readonly global::System.String AutoJump;
		public readonly global::System.String Narrator;
		public readonly global::System.String OnboardAccessibility;
		internal static global::Mass.Game.Launcher.Java.Option.JavaGameOptionKey ReflectSymbolicWriter;
		public JavaGameOptionKey(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion version) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateConfigurableDic() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Java.Option.JavaGameOptionKey ReflectSeparatedObject() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______漀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______瀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______礀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______稀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Java.Option {
	public enum JavaGuiScale
	{
		Auto = 0,
		Small = 1,
		Normal = 2,
		Large = 3,
		ExtraLarge = 4,
	}

}
namespace Mass.Game.Launcher.Java.Option {
	public enum JavaNarrator
	{
		Off = 0,
		All = 1,
		Chat = 2,
		System = 3,
	}

}
namespace Mass.Game.Launcher.Java.LanGame {
	public class DesktopTransfer
	{
		public global::System.Boolean Connected;
		internal static global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer ReflectConcreteDecider;
		public global::System.Action<global::System.Byte[]> OnDataReceived;  // 原为 event，改为字段以避免 add_/remove_ 保留名冲突
		public global::System.Action OnDisconnect;  // 原为 event，改为字段以避免 add_/remove_ 保留名冲突
		public DesktopTransfer(global::Mass.Application.Desktop.DesktopSession session, global::Mass.Domain.Desktop.Entities.LanGame.EntityLanGameRoom room) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void Dispose() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void add_OnDataReceived(global::System.Action<global::System.Byte[]> @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void remove_OnDataReceived(global::System.Action<global::System.Byte[]> @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void add_OnDisconnect(global::System.Action @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void remove_OnDisconnect(global::System.Action @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void DataChannelOpen(global::System.Object peerId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void DataChannelError(global::System.Object e) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void DataChannelClose(global::System.Object peerId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void BinaryMessage(global::System.Object peerId, global::System.Object data) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object HandleGameDataResponseAsync(global::System.Object callback) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object HandleLoginResponseAsync(global::System.Object callback) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object HandlePlayerLeaveResponseAsync(global::System.Object callback) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object HandleJoinRoomResponseAsync(global::System.Object callback) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ConnectWebRtc() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void RegisterCallBack(global::System.UInt16 sid, global::System.Func<global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer.TransferCallBack, global::System.Threading.Tasks.Task> callback) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task ConnectAsync() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object HeartbeatCircleAsync() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ReceiveAsync() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void Disconnect() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ReceiveDataAsync(global::System.Object buffer) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ReceiveControlDataAsync(global::System.Object data) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object RemoteCallBackAsync(global::System.Object callBack) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object SendMessageAsync(global::System.Object values) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object SendMessageAsync_2(global::System.Object data) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object HandshakeAsync() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object JoinRoomAsync() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object HeartbeatAsync() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task SendDataAsync(global::System.Byte[] data) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Int64 RandomSessionId() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		static DesktopTransfer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _ConnectWebRtc_b__35_0() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _HandshakeAsync_b__46_0() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _JoinRoomAsync_b__47_0() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectConnectedList() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer DecorateAlphabeticRecord() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____最(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____栀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____椀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____樀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____欀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____氀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____洀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____渀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____焀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____爀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____猀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____琀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____甀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____瘀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____稀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____笀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____簀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____紀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____縀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____缀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____耀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____脀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____舀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____茀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____萀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____蔀(global::System.Action<global::System.Byte[]> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____蘀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____蜀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____蠀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____褀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____謀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____谀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____贀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____輀(global::System.UInt16 p0, global::System.Func<global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer.TransferCallBack, global::System.Threading.Tasks.Task> p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____鄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____鈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____鐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____销(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____阀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____需(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____頀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____餀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____騀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____鬀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____鰀(global::System.Action<global::System.Byte[]> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____鴀(global::System.Action<global::System.Byte[]> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Int64 ____鸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Int64 ____鼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Int64 ____ꀀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____ꄀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____ꈀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____ꌀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____ꐀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____ꔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____ꠀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____꤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____꼀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____넀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____눀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____대(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____됀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____딀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____똀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____뜀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____렀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____뤀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____먀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public class TransferCallBack
		{
			internal static global::System.Object MeasureTree;
			protected global::System.Type EqualityContract { get; }
			public global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer Transfer { get; set; }
			public global::System.UInt16 Sid { get; set; }
			public global::System.Byte[] Data { get; set; }
			public TransferCallBack(global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer Transfer, global::System.UInt16 Sid, global::System.Byte[] Data) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public object As<T0>() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public global::System.String ToString() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			protected global::System.Boolean PrintMembers(global::System.Text.StringBuilder builder) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public static global::System.Boolean op_Inequality(global::System.Object left, global::System.Object right) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public static global::System.Boolean op_Equality(global::System.Object left, global::System.Object right) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public global::System.Int32 GetHashCode() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public global::System.Boolean Equals(global::System.Object obj) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public global::System.Boolean Equals_2(global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer.TransferCallBack other) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer.TransferCallBack _Clone__() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			protected TransferCallBack(global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer.TransferCallBack original) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public void Deconstruct(out global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer Transfer, out global::System.UInt16 Sid, out global::System.Byte[] Data) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean RemoveFilter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer.TransferCallBack CheckExpandableHandler() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal object ______䄀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal object ______䈀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ______䌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ______䐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object ______䔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object ______䘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object ______䜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.UInt32 ______䠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.UInt32 ______䤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.UInt32 ______䨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void ______䬀(global::System.IntPtr p0, global::System.IntPtr p1, global::System.IntPtr p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void ______䰀(global::System.IntPtr p0, global::System.IntPtr p1, global::System.IntPtr p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object ______䴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object ______一() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ______伀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ______倀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Byte ______儀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal object ______刀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal object ______匀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal object ______吀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Byte ______唀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ______嘀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ______圀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.UInt16 ______堀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.UInt16 ______夀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.UInt16 ______娀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object ______嬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object ______尀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ______崀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ______帀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ______开() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object ______愀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object ______戀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal object ______挀(global::System.UInt16 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal object ______搀(global::System.UInt16 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal object ______攀(global::System.UInt16 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			protected global::System.Byte ______椀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			protected global::System.Byte ______樀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			protected global::System.Byte ______欀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			protected global::System.Object ______氀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			protected global::System.Object ______洀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			protected global::System.Object ______渀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _ConnectAsync_d__37
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer __4__this;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ConnectAsync_d__37 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ConnectAsync_d__37 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateAdjustableReporter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateGenericChain() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ______㜀(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ConnectAsync_d__37 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ______㠀(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ConnectAsync_d__37 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ______㤀(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ConnectAsync_d__37 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ______㨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ______㬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ______㴀(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ConnectAsync_d__37 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ______㸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ______㼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ______䀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _ConnectWebRtc_d__35
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer __4__this;
			internal static global::System.Object ReflectRandomEnumerator;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ConnectWebRtc_d__35 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ConnectWebRtc_d__35 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckCustomParameter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateAdvancedGateway() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ConnectWebRtc_d__35 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ________2(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ConnectWebRtc_d__35 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ________3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ________4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ______㐀(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ConnectWebRtc_d__35 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ______㔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ______㘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _HandleJoinRoomResponseAsync_d__34
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer.TransferCallBack callback;
			public global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer __4__this;
			internal static global::System.Object WatchReg;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._HandleJoinRoomResponseAsync_d__34 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._HandleJoinRoomResponseAsync_d__34 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean FindExecutor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object FlushPredictor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ______Ḁ(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._HandleJoinRoomResponseAsync_d__34 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ______ἀ(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._HandleJoinRoomResponseAsync_d__34 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ________2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ________3(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._HandleJoinRoomResponseAsync_d__34 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ______Ⰰ(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._HandleJoinRoomResponseAsync_d__34 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ______ⴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ________4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _HandshakeAsync_d__46
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer __4__this;
			internal static global::System.Object DecorateSegmentedResponder;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._HandshakeAsync_d__46 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._HandshakeAsync_d__46 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean SetupNode() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ViewFunction() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._HandshakeAsync_d__46 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ______ᔀ(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._HandshakeAsync_d__46 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ______ᘀ(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._HandshakeAsync_d__46 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ______ᜀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ________2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ______ᤀ(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._HandshakeAsync_d__46 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ______ᨀ(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._HandshakeAsync_d__46 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ________3(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._HandshakeAsync_d__46 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ______ᰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ______ᴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _HeartbeatAsync_d__48
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer __4__this;
			internal static global::System.Object ReflectPortableController;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._HeartbeatAsync_d__48 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._HeartbeatAsync_d__48 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateBasicFinder() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateReadableAllocator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._HeartbeatAsync_d__48 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ________2(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._HeartbeatAsync_d__48 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ________3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ______ༀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ______က() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ______ᄀ(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._HeartbeatAsync_d__48 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ______ሀ(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._HeartbeatAsync_d__48 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ______ጀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _HeartbeatCircleAsync_d__38
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer __4__this;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._HeartbeatCircleAsync_d__38 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._HeartbeatCircleAsync_d__38 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateActiveSender() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CountIterator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._HeartbeatCircleAsync_d__38 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ______Ѐ(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._HeartbeatCircleAsync_d__38 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ______Ԁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ________2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ______ࠀ(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._HeartbeatCircleAsync_d__38 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ________3(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._HeartbeatCircleAsync_d__38 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ________4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ________5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _JoinRoomAsync_d__47
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer __4__this;
			internal static global::System.Object DecorateLiteralProvider;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._JoinRoomAsync_d__47 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._JoinRoomAsync_d__47 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateScalableCalc() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ExecuteChooser() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____豈(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._JoinRoomAsync_d__47 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____切(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._JoinRoomAsync_d__47 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____ﬀ(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._JoinRoomAsync_d__47 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____ﰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____ﴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ______() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______2(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._JoinRoomAsync_d__47 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ______Ā(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._JoinRoomAsync_d__47 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ______Ȁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _ReceiveAsync_d__39
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer __4__this;
			internal static global::System.Object ReflectGroupedElement;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ReceiveAsync_d__39 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ReceiveAsync_d__39 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean GetTester() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckIsolatedWriter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ______(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ReceiveAsync_d__39 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______2(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ReceiveAsync_d__39 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______5(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ReceiveAsync_d__39 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______6(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ReceiveAsync_d__39 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _ReceiveControlDataAsync_d__42
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer __4__this;
			public global::System.Byte[] data;
			internal static global::System.Object ReflectAutomatableDic;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ReceiveControlDataAsync_d__42 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ReceiveControlDataAsync_d__42 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateIterableObject() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectIntegratedDecorator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ______(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ReceiveControlDataAsync_d__42 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______2(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ReceiveControlDataAsync_d__42 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______3(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ReceiveControlDataAsync_d__42 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______6(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ReceiveControlDataAsync_d__42 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _ReceiveDataAsync_d__41
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer __4__this;
			public global::System.Byte[] buffer;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ReceiveDataAsync_d__41 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ReceiveDataAsync_d__41 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectSymbolicSummarizer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CustomizeInitializer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ______(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ReceiveDataAsync_d__41 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______2(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ReceiveDataAsync_d__41 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______5(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._ReceiveDataAsync_d__41 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _RemoteCallBackAsync_d__43
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer __4__this;
			public global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer.TransferCallBack callBack;
			internal static global::System.Object GuidePublisher;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._RemoteCallBackAsync_d__43 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._RemoteCallBackAsync_d__43 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckMonoAuditor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckOrderedDecider() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____픀(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._RemoteCallBackAsync_d__43 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____혀(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._RemoteCallBackAsync_d__43 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____휀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ______() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______2(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._RemoteCallBackAsync_d__43 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______3(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._RemoteCallBackAsync_d__43 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______4(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._RemoteCallBackAsync_d__43 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _SendDataAsync_d__49
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer __4__this;
			public global::System.Byte[] data;
			internal static global::System.Object DecorateVisualList;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._SendDataAsync_d__49 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._SendDataAsync_d__49 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateScopeRecord() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckStaticContext() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____쬀(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._SendDataAsync_d__49 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____찀(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._SendDataAsync_d__49 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____촀(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._SendDataAsync_d__49 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____츀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____케() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____턀(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._SendDataAsync_d__49 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____툀(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._SendDataAsync_d__49 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____팀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____퐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _SendMessageAsync_d__44
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::System.Object[] values;
			public global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer __4__this;
			internal static global::System.Object CheckDynamicMapper;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._SendMessageAsync_d__44 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._SendMessageAsync_d__44 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean PopWriter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectConnectedRequester() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____쐀(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._SendMessageAsync_d__44 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____씀(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._SendMessageAsync_d__44 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____였() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____윀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____저(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._SendMessageAsync_d__44 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____준() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____쨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _SendMessageAsync_d__45
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::System.Byte[] data;
			public global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer __4__this;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._SendMessageAsync_d__45 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._SendMessageAsync_d__45 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean VerifyDecorator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ProcessArgument() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____밀(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._SendMessageAsync_d__45 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____봀(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._SendMessageAsync_d__45 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____븀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____뼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____쀀(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._SendMessageAsync_d__45 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____섀(ref global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer._SendMessageAsync_d__45 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____숀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____쌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Game.Launcher.Java.LanGame {
	public class LanGameProxy
	{
		public global::System.Int32 Port;
		public LanGameProxy(global::Mass.Application.Desktop.DesktopSession session, global::Mass.Domain.Desktop.Entities.LanGame.EntityLanGameRoom room) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void StartListen(global::System.Int32 port) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ListenAsync() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object AcceptLoopAsync(global::System.Object listener) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ReceiveAsync(global::System.Object client) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ReceiveGameDataAsync(global::System.Object transfer, global::System.Object client) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void Dispose() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		static LanGameProxy() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean SelectLogger() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Java.LanGame.LanGameProxy ReflectSimplePolicy() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____묀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____밀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____봀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____븀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____뼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____섀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____숀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____쌀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____씀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____였(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____윀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____저(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____준(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____쨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____쬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____찀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____촀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public sealed class __c__DisplayClass10_0
		{
			public global::System.Threading.SemaphoreSlim writeLock;
			public global::System.Net.Sockets.NetworkStream stream;
			public __c__DisplayClass10_0() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void _ReceiveGameDataAsync_g__OnDataReceived_0(global::System.Byte[] bytes) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectControllableContainer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::Mass.Game.Launcher.Java.LanGame.LanGameProxy.__c__DisplayClass10_0 DecorateTransferableConverter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void _____뜀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void _____렀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____뤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____먀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____묀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public struct __ReceiveGameDataAsync_g__OnDataReceived_0_d
			{
				public global::System.Int32 __1__state;
				public global::System.Runtime.CompilerServices.AsyncVoidMethodBuilder __t__builder;
				public global::System.Byte[] bytes;
				public global::Mass.Game.Launcher.Java.LanGame.LanGameProxy.__c__DisplayClass10_0 __4__this;
				private void MoveNext(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy.__c__DisplayClass10_0.__ReceiveGameDataAsync_g__OnDataReceived_0_d p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				private void SetStateMachine(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy.__c__DisplayClass10_0.__ReceiveGameDataAsync_g__OnDataReceived_0_d p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Boolean CheckInternalReporter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Object DecorateExpandableChain() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				private void _____꼀(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy.__c__DisplayClass10_0.__ReceiveGameDataAsync_g__OnDataReceived_0_d p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				private void _____뀀(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy.__c__DisplayClass10_0.__ReceiveGameDataAsync_g__OnDataReceived_0_d p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Object _____넀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Object _____눀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				private void _____대(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy.__c__DisplayClass10_0.__ReceiveGameDataAsync_g__OnDataReceived_0_d p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				private void _____됀(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy.__c__DisplayClass10_0.__ReceiveGameDataAsync_g__OnDataReceived_0_d p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				private void _____딀(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy.__c__DisplayClass10_0.__ReceiveGameDataAsync_g__OnDataReceived_0_d p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Byte _____똀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			}

		}

		public struct _AcceptLoopAsync_d__8
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::System.Net.Sockets.TcpListener listener;
			public global::Mass.Game.Launcher.Java.LanGame.LanGameProxy __4__this;
			internal static global::System.Object DecorateResponsiveVerifier;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy._AcceptLoopAsync_d__8 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy._AcceptLoopAsync_d__8 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean PresentDecider() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckCombinedComparator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____ꘀ(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy._AcceptLoopAsync_d__8 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ______(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy._AcceptLoopAsync_d__8 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____ꠀ(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy._AcceptLoopAsync_d__8 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____꤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____ꨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______2(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy._AcceptLoopAsync_d__8 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____가(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy._AcceptLoopAsync_d__8 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____관() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____글() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _ListenAsync_d__7
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.LanGame.LanGameProxy __4__this;
			internal static global::System.Object StartRecord;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy._ListenAsync_d__7 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy._ListenAsync_d__7 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ResumeContext() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ArrangeMapper() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____鸀(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy._ListenAsync_d__7 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____鼀(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy._ListenAsync_d__7 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____ꀀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____ꄀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____ꌀ(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy._ListenAsync_d__7 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____ꐀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____ꔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _ReceiveAsync_d__9
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.LanGame.LanGameProxy __4__this;
			public global::System.Net.Sockets.TcpClient client;
			internal static global::System.Object ReflectEfficientStrategy;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy._ReceiveAsync_d__9 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy._ReceiveAsync_d__9 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckAttachedSorter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectGlobalConfig() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____鐀(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy._ReceiveAsync_d__9 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____销(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy._ReceiveAsync_d__9 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____阀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____需() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____騀(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy._ReceiveAsync_d__9 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____鬀(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy._ReceiveAsync_d__9 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____鰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____鴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _ReceiveGameDataAsync_d__10
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::System.Net.Sockets.TcpClient client;
			public global::Mass.Game.Launcher.Java.LanGame.DesktopTransfer transfer;
			internal static global::System.Object CheckDetachedEmitter;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy._ReceiveGameDataAsync_d__10 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy._ReceiveGameDataAsync_d__10 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectDetailedRunner() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectDividedClient() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____谀(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy._ReceiveGameDataAsync_d__10 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____贀(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy._ReceiveGameDataAsync_d__10 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____踀(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy._ReceiveGameDataAsync_d__10 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____輀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____退() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____鄀(ref global::Mass.Game.Launcher.Java.LanGame.LanGameProxy._ReceiveGameDataAsync_d__10 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____鈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____錀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Game.Launcher.Java.LanGame {
	public class PendingBuffer
	{
		public global::System.Int32 Length { get; set; }
		public global::System.Byte[] ToArray() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Boolean Append(global::System.Byte[] data) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void Clear() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public PendingBuffer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateTransferableModule() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Java.LanGame.PendingBuffer DecorateResponsiveEvent() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____縀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____缀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____耀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____脀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____舀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____茀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____萀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____蔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____蘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____蜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____蠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _____褀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _____言(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____謀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Java.LanGame {
	public class WebRtc
	{
		public static readonly global::Serilog.ILogger Logger;
		internal static global::Mass.Game.Launcher.Java.LanGame.WebRtc PlayReg;
		public global::System.Action<global::System.String> OnDataChannelOpen;  // 原为 event，改为字段以避免 add_/remove_ 保留名冲突
		public global::System.Action<global::System.Exception> OnDataChannelError;  // 原为 event，改为字段以避免 add_/remove_ 保留名冲突
		public global::System.Action<global::System.String> OnDataChannelClose;  // 原为 event，改为字段以避免 add_/remove_ 保留名冲突
		public global::System.Action<global::System.String, global::System.Byte[]> OnBinaryMessage;  // 原为 event，改为字段以避免 add_/remove_ 保留名冲突
		public WebRtc(global::Mass.Application.Desktop.DesktopSession session, global::System.String url) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void add_OnDataChannelOpen(global::System.Action<global::System.String> @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void remove_OnDataChannelOpen(global::System.Action<global::System.String> @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void add_OnDataChannelError(global::System.Action<global::System.Exception> @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void remove_OnDataChannelError(global::System.Action<global::System.Exception> @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void add_OnDataChannelClose(global::System.Action<global::System.String> @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void remove_OnDataChannelClose(global::System.Action<global::System.String> @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void add_OnBinaryMessage(global::System.Action<global::System.String, global::System.Byte[]> @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void remove_OnBinaryMessage(global::System.Action<global::System.String, global::System.Byte[]> @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void Dispose() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void SetCompressionEnabled(global::System.Boolean enabled) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task ConnectSignalServerAsync() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void StartWebRtc(global::System.String peerId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void InstallWebRtc(global::System.Object peerId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ReceiveLoopAsync() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ReceiveAsync() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void HandleSignalMessage(global::System.Object signal) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void HandleSessionDescription(global::System.IntPtr handle, global::System.Object signal) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object RetrySetIceCandidateAsync(global::System.IntPtr handle, global::System.Object desc, global::System.UInt32 retryCount) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ReleasePinnedCallbacks(global::System.IntPtr handle) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void RegisterCallback<T0>(global::System.IntPtr handle, object callback, global::System.Action<global::System.IntPtr, object> register) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void DataBinaryMessageCallback(global::System.Object peerId, global::System.IntPtr dataPtr, global::System.UInt32 length) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object NormalizePeerId(global::System.Object peerId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void IceCandidateCallback(global::System.Object peerId, global::System.Object mid, global::System.UInt32 index, global::System.Object sdp) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object SendSessionDescriptionAsync(global::System.Object desc, global::System.Object peerId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void DataChannelOpenCallback(global::System.Object peerId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void DataChannelCloseCallback(global::System.Object peerId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void SuccessCallback(global::System.Object peerId, global::System.Object type, global::System.Object sdp) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void FlushPendingData(global::System.Object peerId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Boolean SendData(global::System.Byte[] data, global::System.String peerId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		static WebRtc() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.IntPtr _HandleSignalMessage_g__GetHandle_36_0(global::System.Object from) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean SetupExecutor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Java.LanGame.WebRtc ReflectTransformableContainer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____케(global::System.Action<global::System.String, global::System.Byte[]> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____퀀(global::System.Action<global::System.String, global::System.Byte[]> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____턀(global::System.Action<global::System.String, global::System.Byte[]> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____툀(global::System.Action<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____팀(global::System.Action<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ____퐀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ____픀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____(global::System.Object p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ______2(global::System.Object p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ______3(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ______4(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ______7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.IntPtr ______8(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.IntPtr ______9(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______10(global::System.Action<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______11(global::System.Action<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______12(global::System.Action<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______13(global::System.Action<global::System.Exception> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______14(global::System.Action<global::System.Exception> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______15(global::System.Action<global::System.Exception> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______16(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ______17(global::System.Object p0, global::System.Object p1, global::System.UInt32 p2, global::System.Object p3) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ______18(global::System.Object p0, global::System.Object p1, global::System.UInt32 p2, global::System.Object p3) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______19() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______20() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ______21(global::System.IntPtr p0, global::System.Object p1, global::System.UInt32 p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ______22(global::System.IntPtr p0, global::System.Object p1, global::System.UInt32 p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ______23(global::System.Object p0, global::System.IntPtr p1, global::System.UInt32 p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______24(global::System.Action<global::System.String, global::System.Byte[]> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____豈(global::System.Action<global::System.String, global::System.Byte[]> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ______25(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ______26(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____Ԁ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ______(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____ࠀ(global::System.Action<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______2(global::System.Action<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____ༀ(global::System.IntPtr p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____က(global::System.IntPtr p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____ᄀ(global::System.Action<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____ሀ(global::System.Action<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____ጀ(global::System.Action<global::System.Exception> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____ᔀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____ᘀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____ᜀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _______3(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____Ⰰ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____ⴀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _______5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _______6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____㘀(global::System.IntPtr p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____㜀(global::System.IntPtr p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____㨀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____㬀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____㰀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____㴀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____㸀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____㼀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____䀀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public class __O
		{
			public static global::System.Action<global::System.IntPtr, global::Mass.Game.Launcher.Java.LanGame.WebRtcNative.DataBinaryMessageCallback> _0___RegisterOnDataBinaryMessageCallback;
			public static global::System.Action<global::System.IntPtr, global::Mass.Game.Launcher.Java.LanGame.WebRtcNative.IceCandidateCallback> _1___RegisterOnIceCandidateCallback;
			public static global::System.Action<global::System.IntPtr, global::Mass.Game.Launcher.Java.LanGame.WebRtcNative.DataChannelStateChangeCallback> _2___RegisterOnDataChannelOpenCallback;
			public static global::System.Action<global::System.IntPtr, global::Mass.Game.Launcher.Java.LanGame.WebRtcNative.DataChannelStateChangeCallback> _3___RegisterOnDataChannelCloseCallback;
			public static global::System.Action<global::System.IntPtr, global::Mass.Game.Launcher.Java.LanGame.WebRtcNative.SuccessCallback> _4___RegisterOnSuccessCallback;
		}

		public sealed class __c
		{
			public static readonly global::Mass.Game.Launcher.Java.LanGame.WebRtc.__c __9;
			public static global::System.Func<global::System.IntPtr, global::System.Boolean> __9__36_1;
			static __c() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Boolean _HandleSignalMessage_b__36_1(global::System.IntPtr i) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ValidateComparator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::Mass.Game.Launcher.Java.LanGame.WebRtc.__c CheckScheduledDefinition() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public sealed class __c__DisplayClass32_0
		{
			public global::Mass.Game.Launcher.Java.LanGame.WebRtc __4__this;
			public global::System.String peerId;
			internal static global::Mass.Game.Launcher.Java.LanGame.WebRtc.__c__DisplayClass32_0 CheckFilteredTransmitter;
			public __c__DisplayClass32_0() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void _StartWebRtc_b__0() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void _StartWebRtc_b__1(global::System.Threading.Tasks.Task t) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean SplitConsumer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::Mass.Game.Launcher.Java.LanGame.WebRtc.__c__DisplayClass32_0 DecoratePassiveAnalyzer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____甀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____瘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____眀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____砀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____礀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void _____稀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void _____簀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void _____紀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _ConnectSignalServerAsync_d__31
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.LanGame.WebRtc __4__this;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._ConnectSignalServerAsync_d__31 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._ConnectSignalServerAsync_d__31 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectOperationalNotifier() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckVirtualDispatcher() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____樀(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._ConnectSignalServerAsync_d__31 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____欀(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._ConnectSignalServerAsync_d__31 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____氀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____洀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____焀(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._ConnectSignalServerAsync_d__31 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____爀(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._ConnectSignalServerAsync_d__31 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____猀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____琀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _ReceiveAsync_d__35
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.LanGame.WebRtc __4__this;
			internal static global::System.Object ReflectIdentifiableSingleton;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._ReceiveAsync_d__35 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._ReceiveAsync_d__35 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean InterruptClient() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectCustomizableState() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____嘀(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._ReceiveAsync_d__35 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____圀(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._ReceiveAsync_d__35 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____堀(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._ReceiveAsync_d__35 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____夀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____娀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____最(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._ReceiveAsync_d__35 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____栀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____椀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _ReceiveLoopAsync_d__34
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.LanGame.WebRtc __4__this;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._ReceiveLoopAsync_d__34 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._ReceiveLoopAsync_d__34 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ResetFinalizer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ObserveAggregator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____䬀(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._ReceiveLoopAsync_d__34 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____䰀(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._ReceiveLoopAsync_d__34 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____䴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____一() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____匀(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._ReceiveLoopAsync_d__34 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____吀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____唀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _RetrySetIceCandidateAsync_d__38
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::System.IntPtr handle;
			public global::Mass.Game.Launcher.Entities.EntitySessionDescription desc;
			public global::System.Int32 retryCount;
			public global::Mass.Game.Launcher.Java.LanGame.WebRtc __4__this;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._RetrySetIceCandidateAsync_d__38 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._RetrySetIceCandidateAsync_d__38 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectGenericEnumerator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object FilterTransmitter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____㼀(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._RetrySetIceCandidateAsync_d__38 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____䀀(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._RetrySetIceCandidateAsync_d__38 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____䄀(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._RetrySetIceCandidateAsync_d__38 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____䈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____䌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____䠀(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._RetrySetIceCandidateAsync_d__38 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____䤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____䨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _SendSessionDescriptionAsync_d__44
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Java.LanGame.WebRtc __4__this;
			public global::System.String peerId;
			public global::Mass.Game.Launcher.Entities.EntitySessionDescription desc;
			private void MoveNext(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._SendSessionDescriptionAsync_d__44 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._SendSessionDescriptionAsync_d__44 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckAdvancedProfiler() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckConvertibleFactory() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____㔀(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._SendSessionDescriptionAsync_d__44 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____㘀(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._SendSessionDescriptionAsync_d__44 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____㜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____㠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____㰀(ref global::Mass.Game.Launcher.Java.LanGame.WebRtc._SendSessionDescriptionAsync_d__44 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____㴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____㸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Game.Launcher.Java.LanGame {
	public sealed class WebRtcCompressor
	{
		internal static global::Mass.Game.Launcher.Java.LanGame.WebRtcCompressor EncryptInterpreter;
		public global::System.Byte[] Decompress(global::System.Byte[] data) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Byte[] Compress(global::System.Byte[] data) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void Reset() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public WebRtcCompressor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ScanNode() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Java.LanGame.WebRtcCompressor InitFunction() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______2(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______3(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____Ⰰ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____ⴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______6(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______7(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______8(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____㐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Java.LanGame {
	public class WebRtcNative
	{
		public static global::System.IntPtr CreateConductor(global::System.String peerId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static void DeleteConductor(global::System.IntPtr conductorPtr) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static void Quit(global::System.IntPtr conductorPtr) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static void Run(global::System.IntPtr conductorPtr) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static void InitializeSSL() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static void CleanupSSL() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.Boolean InitializePeerConnection(global::System.IntPtr conductorPtr) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static void CreateOffer(global::System.IntPtr conductorPtr) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static void CreateAnswer(global::System.IntPtr conductorPtr) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static void ProcessMessages(global::System.IntPtr conductorPtr, global::System.Int32 delayMs) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static void CreateDataChannel(global::System.IntPtr conductorPtr, global::System.String label) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static void AddServerConfig(global::System.IntPtr conductorPtr, global::System.String url, global::System.String username, global::System.String password) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static void OnOfferRequest(global::System.IntPtr conductorPtr, global::System.String sdp) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static void OnOfferReply(global::System.IntPtr conductorPtr, global::System.String type, global::System.String sdp) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.Boolean GetChannelReady(global::System.IntPtr conductorPtr) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.IntPtr GetCandidateType(global::System.IntPtr conductorPtr) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.Boolean AddIceCandidate(global::System.IntPtr conductorPtr, global::System.String mid, global::System.Int32 index, global::System.String sdp) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.Boolean DataChannelSendText(global::System.IntPtr conductorPtr, global::System.String text) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.Boolean DataChannelSendData(global::System.IntPtr conductorPtr, global::System.Byte[] data, global::System.Int32 length) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static void RegisterOnSuccessCallback(global::System.IntPtr conductorPtr, global::Mass.Game.Launcher.Java.LanGame.WebRtcNative.SuccessCallback callback) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static void RegisterOnFailureCallback(global::System.IntPtr conductorPtr, global::Mass.Game.Launcher.Java.LanGame.WebRtcNative.FailureCallback callback) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static void RegisterOnErrorCallback(global::System.IntPtr conductorPtr, global::Mass.Game.Launcher.Java.LanGame.WebRtcNative.ErrorCallback callback) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static void RegisterOnIceCandidateCallback(global::System.IntPtr conductorPtr, global::Mass.Game.Launcher.Java.LanGame.WebRtcNative.IceCandidateCallback callback) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static void RegisterOnDataBinaryMessageCallback(global::System.IntPtr conductorPtr, global::Mass.Game.Launcher.Java.LanGame.WebRtcNative.DataBinaryMessageCallback callback) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static void RegisterOnDataMessageCallback(global::System.IntPtr conductorPtr, global::Mass.Game.Launcher.Java.LanGame.WebRtcNative.DataMessageCallback callback) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static void RegisterOnDataChannelStateChangeCallback(global::System.IntPtr conductorPtr, global::Mass.Game.Launcher.Java.LanGame.WebRtcNative.DataChannelStateChangeCallback callback) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static void RegisterOnDataChannelOpenCallback(global::System.IntPtr conductorPtr, global::Mass.Game.Launcher.Java.LanGame.WebRtcNative.DataChannelStateChangeCallback callback) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static void RegisterOnDataChannelCloseCallback(global::System.IntPtr conductorPtr, global::Mass.Game.Launcher.Java.LanGame.WebRtcNative.DataChannelStateChangeCallback callback) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public sealed class SuccessCallback
		{
			public SuccessCallback(global::System.Object @object, global::System.IntPtr method) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public void Invoke(global::System.String peerId, global::System.String type, global::System.String sdp) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public global::System.IAsyncResult BeginInvoke(global::System.String peerId, global::System.String type, global::System.String sdp, global::System.AsyncCallback callback, global::System.Object @object) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public void EndInvoke(global::System.IAsyncResult result) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public sealed class FailureCallback
		{
			public FailureCallback(global::System.Object @object, global::System.IntPtr method) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public void Invoke(global::System.String peerId, global::System.String message) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public global::System.IAsyncResult BeginInvoke(global::System.String peerId, global::System.String message, global::System.AsyncCallback callback, global::System.Object @object) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public void EndInvoke(global::System.IAsyncResult result) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public sealed class ErrorCallback
		{
			public ErrorCallback(global::System.Object @object, global::System.IntPtr method) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public void Invoke(global::System.String peerId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public global::System.IAsyncResult BeginInvoke(global::System.String peerId, global::System.AsyncCallback callback, global::System.Object @object) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public void EndInvoke(global::System.IAsyncResult result) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public sealed class IceCandidateCallback
		{
			public IceCandidateCallback(global::System.Object @object, global::System.IntPtr method) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public void Invoke(global::System.String peerId, global::System.String mid, global::System.Int32 index, global::System.String sdp) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public global::System.IAsyncResult BeginInvoke(global::System.String peerId, global::System.String mid, global::System.Int32 index, global::System.String sdp, global::System.AsyncCallback callback, global::System.Object @object) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public void EndInvoke(global::System.IAsyncResult result) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public sealed class DataBinaryMessageCallback
		{
			public DataBinaryMessageCallback(global::System.Object @object, global::System.IntPtr method) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public void Invoke(global::System.String peerId, global::System.IntPtr dataPtr, global::System.Int32 length) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public global::System.IAsyncResult BeginInvoke(global::System.String peerId, global::System.IntPtr dataPtr, global::System.Int32 length, global::System.AsyncCallback callback, global::System.Object @object) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public void EndInvoke(global::System.IAsyncResult result) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public sealed class DataMessageCallback
		{
			public DataMessageCallback(global::System.Object @object, global::System.IntPtr method) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public void Invoke(global::System.String peerId, global::System.String message) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public global::System.IAsyncResult BeginInvoke(global::System.String peerId, global::System.String message, global::System.AsyncCallback callback, global::System.Object @object) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public void EndInvoke(global::System.IAsyncResult result) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public sealed class DataChannelStateChangeCallback
		{
			public DataChannelStateChangeCallback(global::System.Object @object, global::System.IntPtr method) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public void Invoke(global::System.String peerId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public global::System.IAsyncResult BeginInvoke(global::System.String peerId, global::System.AsyncCallback callback, global::System.Object @object) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public void EndInvoke(global::System.IAsyncResult result) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Game.Launcher.Helpers {
	public class CompressionHelper
	{
		private static global::Serilog.ILogger Logger { get; }
		public static global::System.Threading.Tasks.Task ExtractAllAsync(global::System.Collections.Generic.List<global::System.ValueTuple<global::System.String, global::System.String>> extractList, global::System.Action<global::System.Int32> progress, global::System.Threading.CancellationToken cancellationToken) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.Threading.Tasks.Task ExtractAsync(global::System.String archivePath, global::System.String outputDir, global::System.Action<global::System.Int32> progress, global::System.Threading.CancellationToken cancellationToken) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		static CompressionHelper() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean PeekExtractor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Helpers.CompressionHelper ReflectGeneralSorter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____䈀(global::System.Collections.Generic.List<global::System.ValueTuple<global::System.String, global::System.String>> p0, global::System.Action<global::System.Int32> p1, global::System.Threading.CancellationToken p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____䌀(global::System.Collections.Generic.List<global::System.ValueTuple<global::System.String, global::System.String>> p0, global::System.Action<global::System.Int32> p1, global::System.Threading.CancellationToken p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____䐀(global::System.Collections.Generic.List<global::System.ValueTuple<global::System.String, global::System.String>> p0, global::System.Action<global::System.Int32> p1, global::System.Threading.CancellationToken p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____䔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____䘀(global::System.Object p0, global::System.Object p1, global::System.Action<global::System.Int32> p2, global::System.Threading.CancellationToken p3) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____䜀(global::System.Object p0, global::System.Object p1, global::System.Action<global::System.Int32> p2, global::System.Threading.CancellationToken p3) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _____䠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _____䤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _____䨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____䬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____䰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public sealed class __c__DisplayClass3_0
		{
			public global::System.Int32 completed;
			public global::System.Int32 total;
			public global::System.Action<global::System.Int32> progress;
			public global::System.Action<global::System.Int32> __9__0;
			public __c__DisplayClass3_0() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void _ExtractAllAsync_b__0(global::System.Int32 p) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectFlexibleResponder() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::Mass.Game.Launcher.Helpers.CompressionHelper.__c__DisplayClass3_0 DecorateSegmentedStream() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void ______(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void _______2(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void _______3(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public sealed class __c__DisplayClass4_0
		{
			public global::System.Action<global::System.Int32> progress;
			internal static global::Mass.Game.Launcher.Helpers.CompressionHelper.__c__DisplayClass4_0 ReflectCommonEncryptor;
			public __c__DisplayClass4_0() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void _ExtractAsync_b__0(global::System.Object p0, global::System.Diagnostics.DataReceivedEventArgs e) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckAdaptableController() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::Mass.Game.Launcher.Helpers.CompressionHelper.__c__DisplayClass4_0 CheckPortableFinder() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void ______(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void _____ᰀ(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____ᴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____Ḁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____ἀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public sealed class __c__DisplayClass4_1
		{
			public global::System.Diagnostics.Process process;
			public __c__DisplayClass4_1() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void _ExtractAsync_b__1() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateReadableQueue() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::Mass.Game.Launcher.Helpers.CompressionHelper.__c__DisplayClass4_1 SetChain() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void ______() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void _____ᔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____ᘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____ᜀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____ᤀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _ExtractAllAsync_d__3
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::System.Action<global::System.Int32> progress;
			public global::System.Collections.Generic.List<global::System.ValueTuple<global::System.String, global::System.String>> extractList;
			public global::System.Threading.CancellationToken cancellationToken;
			internal static global::System.Object ReflectActiveWorker;
			private void MoveNext(ref global::Mass.Game.Launcher.Helpers.CompressionHelper._ExtractAllAsync_d__3 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Helpers.CompressionHelper._ExtractAllAsync_d__3 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean SearchParameter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateLiteralCalc() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ______(ref global::Mass.Game.Launcher.Helpers.CompressionHelper._ExtractAllAsync_d__3 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______2(ref global::Mass.Game.Launcher.Helpers.CompressionHelper._ExtractAllAsync_d__3 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _______3(ref global::Mass.Game.Launcher.Helpers.CompressionHelper._ExtractAllAsync_d__3 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _______4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____ༀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____က(ref global::Mass.Game.Launcher.Helpers.CompressionHelper._ExtractAllAsync_d__3 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____ᄀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____ሀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _____ጀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _ExtractAsync_d__4
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::System.Action<global::System.Int32> progress;
			public global::System.String archivePath;
			public global::System.String outputDir;
			public global::System.Threading.CancellationToken cancellationToken;
			private void MoveNext(ref global::Mass.Game.Launcher.Helpers.CompressionHelper._ExtractAsync_d__4 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Helpers.CompressionHelper._ExtractAsync_d__4 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectModularElement() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object LeadCompressor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____ﴀ(ref global::Mass.Game.Launcher.Helpers.CompressionHelper._ExtractAsync_d__4 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____(ref global::Mass.Game.Launcher.Helpers.CompressionHelper._ExtractAsync_d__4 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ______2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____Ā() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _____ࠀ(ref global::Mass.Game.Launcher.Helpers.CompressionHelper._ExtractAsync_d__4 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ______() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _______2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Game.Launcher.Helpers {
	public class DownloadHelper
	{
		internal static global::Mass.Game.Launcher.Helpers.DownloadHelper DetachCollection;
		private static global::Serilog.ILogger Logger { get; }
		public static global::System.Threading.Tasks.Task DownloadAllAsync(global::System.Collections.Generic.List<global::System.ValueTuple<global::System.String, global::System.String>> downloadList, global::System.Action<global::System.Int32> progress, global::System.Int32 maxConcurrency, global::System.Threading.CancellationToken cancellationToken) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.Threading.Tasks.Task DownloadAsync(global::System.String url, global::System.String destinationPath, global::System.Action<global::System.Int32> progress, global::System.Int32 maxConcurrency, global::System.Threading.CancellationToken cancellationToken) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.Threading.Tasks.Task DownloadAsync_2(global::System.Net.Http.HttpClient httpClient, global::System.String url, global::System.String destinationPath, global::System.Action<global::System.Int32> progress, global::System.Int32 maxConcurrency, global::System.Threading.CancellationToken cancellationToken) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object SafeMultiSegmentDownloadAsync(global::System.Object httpClient, global::System.Object url, global::System.Object path, global::System.Int64 totalSize, global::System.Action<global::System.Int32> progress, global::System.UInt32 maxConcurrency, global::System.Threading.CancellationToken ct) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object SingleDownloadAsync(global::System.Object httpClient, global::System.Object url, global::System.Object path, global::System.Action<global::System.Int32> progress, global::System.Threading.CancellationToken ct) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object CalculateRanges(global::System.UInt32 segments, global::System.Int64 total) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		static DownloadHelper() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean GetProfile() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Helpers.DownloadHelper CheckCentralRunner() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _____䴀(global::System.Object p0, global::System.Object p1, global::System.Object p2, global::System.Int64 p3, global::System.Action<global::System.Int32> p4, global::System.UInt32 p5, global::System.Threading.CancellationToken p6) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _____一(global::System.Object p0, global::System.Object p1, global::System.Object p2, global::System.Int64 p3, global::System.Action<global::System.Int32> p4, global::System.UInt32 p5, global::System.Threading.CancellationToken p6) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _____伀(global::System.Object p0, global::System.Object p1, global::System.Object p2, global::System.Int64 p3, global::System.Action<global::System.Int32> p4, global::System.UInt32 p5, global::System.Threading.CancellationToken p6) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____倀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _____儀(global::System.UInt32 p0, global::System.Int64 p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _____刀(global::System.UInt32 p0, global::System.Int64 p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _____匀(global::System.Object p0, global::System.Object p1, global::System.Object p2, global::System.Action<global::System.Int32> p3, global::System.Threading.CancellationToken p4) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _____吀(global::System.Object p0, global::System.Object p1, global::System.Object p2, global::System.Action<global::System.Int32> p3, global::System.Threading.CancellationToken p4) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____嘀(global::System.Object p0, global::System.Object p1, global::System.Object p2, global::System.Action<global::System.Int32> p3, global::System.UInt32 p4, global::System.Threading.CancellationToken p5) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____圀(global::System.Collections.Generic.List<global::System.ValueTuple<global::System.String, global::System.String>> p0, global::System.Action<global::System.Int32> p1, global::System.UInt32 p2, global::System.Threading.CancellationToken p3) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____堀(global::System.Collections.Generic.List<global::System.ValueTuple<global::System.String, global::System.String>> p0, global::System.Action<global::System.Int32> p1, global::System.UInt32 p2, global::System.Threading.CancellationToken p3) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____夀(global::System.Collections.Generic.List<global::System.ValueTuple<global::System.String, global::System.String>> p0, global::System.Action<global::System.Int32> p1, global::System.UInt32 p2, global::System.Threading.CancellationToken p3) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____娀(global::System.Object p0, global::System.Object p1, global::System.Action<global::System.Int32> p2, global::System.UInt32 p3, global::System.Threading.CancellationToken p4) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____嬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____尀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _____崀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _____帀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public sealed class __c__DisplayClass3_0
		{
			public global::System.Int32 completed;
			public global::System.Int32 total;
			public global::System.Action<global::System.Int32> progress;
			public global::System.Action<global::System.Int32> __9__0;
			internal static global::Mass.Game.Launcher.Helpers.DownloadHelper.__c__DisplayClass3_0 CollectResponder;
			public __c__DisplayClass3_0() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void _DownloadAllAsync_b__0(global::System.Int32 p) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectIsolatedDic() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::Mass.Game.Launcher.Helpers.DownloadHelper.__c__DisplayClass3_0 DecorateAutomatableObject() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void _____(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void ______2(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void ______3(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____豈() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____切() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____ﬀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____ﰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public sealed class __c__DisplayClass6_0
		{
			public global::System.Threading.SemaphoreSlim semaphore;
			public global::System.Threading.CancellationToken ct;
			public global::System.String url;
			public global::System.Net.Http.HttpClient httpClient;
			public global::System.IO.MemoryMappedFiles.MemoryMappedFile mmf;
			public global::System.Int64 downloaded;
			public global::System.Collections.Concurrent.ConcurrentBag<global::System.Exception> errors;
			public global::System.Action<global::System.Int32> progress;
			public global::System.Diagnostics.Stopwatch sw;
			public global::System.Int64 totalSize;
			public global::System.Int32 lastReported;
			public __c__DisplayClass6_0() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Threading.Tasks.Task _SafeMultiSegmentDownloadAsync_g__DownloadRangeAsync_0(global::System.ValueTuple<global::System.Int64, global::System.Int64> range) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void _SafeMultiSegmentDownloadAsync_g__ReportProgress_1(global::System.Int64 totalRead) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateIntegratedArgument() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::Mass.Game.Launcher.Helpers.DownloadHelper.__c__DisplayClass6_0 ReflectLocalSummarizer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ______2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ______3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ______4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ______5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object ______6(global::System.ValueTuple<global::System.Int64, global::System.Int64> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void ______7(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void ______8(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public struct __SafeMultiSegmentDownloadAsync_g__DownloadRangeAsync_0_d
			{
				public global::System.Int32 __1__state;
				public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
				public global::Mass.Game.Launcher.Helpers.DownloadHelper.__c__DisplayClass6_0 __4__this;
				public global::System.ValueTuple<global::System.Int64, global::System.Int64> range;
				private void MoveNext(ref global::Mass.Game.Launcher.Helpers.DownloadHelper.__c__DisplayClass6_0.__SafeMultiSegmentDownloadAsync_g__DownloadRangeAsync_0_d p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				private void SetStateMachine(ref global::Mass.Game.Launcher.Helpers.DownloadHelper.__c__DisplayClass6_0.__SafeMultiSegmentDownloadAsync_g__DownloadRangeAsync_0_d p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Boolean DecorateAdjustableParameter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Object SolveAuthorizer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				private void _____(ref global::Mass.Game.Launcher.Helpers.DownloadHelper.__c__DisplayClass6_0.__SafeMultiSegmentDownloadAsync_g__DownloadRangeAsync_0_d p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				private void ______2(ref global::Mass.Game.Launcher.Helpers.DownloadHelper.__c__DisplayClass6_0.__SafeMultiSegmentDownloadAsync_g__DownloadRangeAsync_0_d p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Object ______3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Object ______4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				private void ______5(ref global::Mass.Game.Launcher.Helpers.DownloadHelper.__c__DisplayClass6_0.__SafeMultiSegmentDownloadAsync_g__DownloadRangeAsync_0_d p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Byte ______6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Byte ______7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Byte ______8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			}

		}

		public sealed class __c__DisplayClass8_0
		{
			public global::System.Int64 size;
			public global::System.Int32 segments;
			public global::System.Int64 total;
			public __c__DisplayClass8_0() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.ValueTuple<global::System.Int64, global::System.Int64> _CalculateRanges_b__0(global::System.Int32 i) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateConfigurableTemplate() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::Mass.Game.Launcher.Helpers.DownloadHelper.__c__DisplayClass8_0 ReadWorker() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.ValueTuple<global::System.Int64, global::System.Int64> _____(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.ValueTuple<global::System.Int64, global::System.Int64> ______2(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.ValueTuple<global::System.Int64, global::System.Int64> ______3(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ______4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ______5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ______6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _DownloadAllAsync_d__3
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::System.Action<global::System.Int32> progress;
			public global::System.Collections.Generic.List<global::System.ValueTuple<global::System.String, global::System.String>> downloadList;
			public global::System.Int32 maxConcurrency;
			public global::System.Threading.CancellationToken cancellationToken;
			private void MoveNext(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._DownloadAllAsync_d__3 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._DownloadAllAsync_d__3 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectOrderedList() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CompressTree() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____혀(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._DownloadAllAsync_d__3 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____휀(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._DownloadAllAsync_d__3 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _____() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ______2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ______3(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._DownloadAllAsync_d__3 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ______4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ______5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _DownloadAsync_d__4
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::System.String url;
			public global::System.String destinationPath;
			public global::System.Action<global::System.Int32> progress;
			public global::System.Int32 maxConcurrency;
			public global::System.Threading.CancellationToken cancellationToken;
			internal static global::System.Object ReflectScopeContext;
			private void MoveNext(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._DownloadAsync_d__4 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._DownloadAsync_d__4 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateStaticMapper() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectDynamicPolicy() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____촀(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._DownloadAsync_d__4 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____츀(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._DownloadAsync_d__4 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____케(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._DownloadAsync_d__4 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____퀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____턀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____툀(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._DownloadAsync_d__4 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____팀(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._DownloadAsync_d__4 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____퐀(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._DownloadAsync_d__4 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____픀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _DownloadAsync_d__5
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::System.String destinationPath;
			public global::System.String url;
			public global::System.Net.Http.HttpClient httpClient;
			public global::System.Threading.CancellationToken cancellationToken;
			public global::System.Int32 maxConcurrency;
			public global::System.Action<global::System.Int32> progress;
			internal static global::System.Object DecorateConcreteRequester;
			private void MoveNext(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._DownloadAsync_d__5 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._DownloadAsync_d__5 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean QueryConnection() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectAlphabeticEvent() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____쐀(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._DownloadAsync_d__5 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____씀(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._DownloadAsync_d__5 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____였() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____윀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____쨀(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._DownloadAsync_d__5 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____쬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____찀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _SafeMultiSegmentDownloadAsync_d__6
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::System.Threading.CancellationToken ct;
			public global::System.String url;
			public global::System.Net.Http.HttpClient httpClient;
			public global::System.Action<global::System.Int32> progress;
			public global::System.Int64 totalSize;
			public global::System.String path;
			public global::System.Int32 maxConcurrency;
			private void MoveNext(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._SafeMultiSegmentDownloadAsync_d__6 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._SafeMultiSegmentDownloadAsync_d__6 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckLogicalProcessor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectSimpleContainer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____먀(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._SafeMultiSegmentDownloadAsync_d__6 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____묀(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._SafeMultiSegmentDownloadAsync_d__6 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____밀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____봀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____븀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____쀀(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._SafeMultiSegmentDownloadAsync_d__6 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____섀(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._SafeMultiSegmentDownloadAsync_d__6 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____숀(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._SafeMultiSegmentDownloadAsync_d__6 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____쌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _SingleDownloadAsync_d__7
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::System.Net.Http.HttpClient httpClient;
			public global::System.String url;
			public global::System.Threading.CancellationToken ct;
			public global::System.String path;
			public global::System.Action<global::System.Int32> progress;
			private void MoveNext(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._SingleDownloadAsync_d__7 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._SingleDownloadAsync_d__7 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckTransferableVerifier() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckResponsiveAnnotation() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____눀(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._SingleDownloadAsync_d__7 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____대(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._SingleDownloadAsync_d__7 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____됀(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._SingleDownloadAsync_d__7 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____딀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____똀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____뜀(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._SingleDownloadAsync_d__7 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____렀(ref global::Mass.Game.Launcher.Helpers.DownloadHelper._SingleDownloadAsync_d__7 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____뤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Game.Launcher.Helpers {
	public class JavaRpcPacker
	{
		public static global::System.Byte[] Pack(global::System.Object[] values) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public JavaRpcPacker() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckScheduledListener() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Helpers.JavaRpcPacker JoinTracer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____ꨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____가() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____관(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____글(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____꼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____뀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____넀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public sealed class __c
		{
			public static readonly global::Mass.Game.Launcher.Helpers.JavaRpcPacker.__c __9;
			public static global::System.Func<global::System.UInt32, global::System.Object> __9__0_0;
			public static global::System.Func<global::System.UInt64, global::System.Object> __9__0_1;
			static __c() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object _Pack_b__0_0(global::System.UInt32 u) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object _Pack_b__0_1(global::System.UInt64 u) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Game.Launcher.Helpers {
	public class JavaRpcUnpacker
	{
		internal static global::Mass.Game.Launcher.Helpers.JavaRpcUnpacker MoveResolver;
		private global::System.Byte[] Content { get; set; }
		private global::System.Int32 Index { get; set; }
		public JavaRpcUnpacker(global::System.Byte[] bytes) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static object Unpack<T0>(global::System.Byte[] bytes) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private object InnerUnpack<T0>() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object InnerUnpack_2(global::System.Object type) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void Ensure(global::System.Object type, global::System.UInt32 size) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecoratePassiveAggregator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Helpers.JavaRpcUnpacker CheckExternalTag() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____騀(global::System.Object p0, global::System.UInt32 p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____鬀(global::System.Object p0, global::System.UInt32 p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.UInt32 ____鰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____鴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____鸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____鼀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____ꀀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ____ꄀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____ꈀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____ꌀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____ꔀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ____ꘀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____ꠀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____꤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public sealed class __c__9<T0>
		{
			public static readonly global::Mass.Game.Launcher.Helpers.JavaRpcUnpacker.__c__9<T0> __9;
			public static global::System.Func<global::System.Reflection.PropertyInfo, global::System.Int32> __9__9_0;
			static __c__9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Int32 _Unpack_b__9_0(global::System.Reflection.PropertyInfo f) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Game.Launcher.Extensions {
	public class RestResponseExtensions
	{
		public static object EnsureSuccessStatusCode<T0>(global::RestSharp.RestResponse<global::Mass.Game.Launcher.Entities.Fever.EntityFeverResponse<object>> response) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Extensions {
	public class SessionExtensions
	{
		public static global::System.Threading.Tasks.Task<global::Mass.Game.Launcher.Java.JavaGame> StartNetJavaGameAsync(global::Mass.Application.Desktop.Models.SessionContext<global::Mass.Application.Desktop.DesktopSession, global::Mass.Domain.Desktop.Entities.NetGame.EntityNetGameItem> context, global::System.String name, global::Mass.Domain.Value.SectionValue gameValue, global::Mass.Domain.Value.SectionValue proxyValue, global::System.Boolean blockIrcMessages) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.Threading.Tasks.Task<global::Mass.Game.Launcher.Java.JavaGame> StartRentalJavaGameAsync(global::Mass.Application.Desktop.DesktopSession session, global::System.String gameId, global::System.String name, global::System.String password, global::Mass.Domain.Value.SectionValue gameValue, global::Mass.Domain.Value.SectionValue proxyValue) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::Mass.Game.Launcher.Java.JavaGame StartLanJavaGame(global::Mass.Application.Desktop.DesktopSession session, global::Mass.Domain.Desktop.Entities.LanGame.EntityLanGameRoom room, global::System.String name, global::Mass.Domain.Value.SectionValue gameValue) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object StartJavaGameAsync(global::System.Object session, global::Mass.Domain.Desktop.ValueObjects.EnumGameType type, global::System.Object gameId, global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion gameVersion, global::System.Object address, global::System.UInt32 port, global::System.Object name, global::System.Object gameValue, global::System.Object proxyValue, global::System.Byte blockIrcMessages) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.Threading.Tasks.Task<global::Mass.Game.Launcher.Cpp.CppGame> StartNetCppGameAsync(global::Mass.Application.Desktop.Models.SessionContext<global::Mass.Application.Mobile.MobileSession, global::Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem> context, global::Mass.Domain.Value.SectionValue gameValue) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.Threading.Tasks.Task<global::Mass.Game.Launcher.Cpp.CppGame> StartNetCppGameAsync_2(global::Mass.Application.Mobile.MobileSession session, global::System.String gameId, global::System.String name, global::Mass.Domain.Value.SectionValue gameValue) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.Threading.Tasks.Task<global::Mass.Game.Launcher.Cpp.CppGame> StartRentalCppGameAsync(global::Mass.Application.Mobile.MobileSession session, global::System.String gameId, global::System.String name, global::System.String password, global::Mass.Domain.Value.SectionValue gameValue) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object StartCppGameAsync(global::System.Object session, global::Mass.Domain.Desktop.ValueObjects.EnumGameType type, global::System.Object gameId, global::System.Object address, global::System.UInt32 port, global::System.Object name, global::System.Object gameValue) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckCustomizableDistributor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Extensions.SessionExtensions RunMap() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Threading.Tasks.Task<global::Mass.Game.Launcher.Cpp.CppGame> ____脀(global::Mass.Application.Desktop.Models.SessionContext<global::Mass.Application.Mobile.MobileSession, global::Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem> p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Threading.Tasks.Task<global::Mass.Game.Launcher.Cpp.CppGame> ____舀(global::Mass.Application.Desktop.Models.SessionContext<global::Mass.Application.Mobile.MobileSession, global::Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem> p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Threading.Tasks.Task<global::Mass.Game.Launcher.Cpp.CppGame> ____茀(global::Mass.Application.Desktop.Models.SessionContext<global::Mass.Application.Mobile.MobileSession, global::Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem> p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____萀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____蔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Threading.Tasks.Task<global::Mass.Game.Launcher.Cpp.CppGame> ____蘀(global::System.Object p0, global::System.Object p1, global::System.Object p2, global::System.Object p3, global::System.Object p4) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Threading.Tasks.Task<global::Mass.Game.Launcher.Cpp.CppGame> ____蜀(global::System.Object p0, global::System.Object p1, global::System.Object p2, global::System.Object p3) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Threading.Tasks.Task<global::Mass.Game.Launcher.Cpp.CppGame> ____蠀(global::System.Object p0, global::System.Object p1, global::System.Object p2, global::System.Object p3) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ____言(global::System.Object p0, global::Mass.Domain.Desktop.ValueObjects.EnumGameType p1, global::System.Object p2, global::System.Object p3, global::System.UInt32 p4, global::System.Object p5, global::System.Object p6) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ____謀(global::System.Object p0, global::Mass.Domain.Desktop.ValueObjects.EnumGameType p1, global::System.Object p2, global::System.Object p3, global::System.UInt32 p4, global::System.Object p5, global::System.Object p6) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ____谀(global::System.Object p0, global::Mass.Domain.Desktop.ValueObjects.EnumGameType p1, global::System.Object p2, global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p3, global::System.Object p4, global::System.UInt32 p5, global::System.Object p6, global::System.Object p7, global::System.Object p8, global::System.Byte p9) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ____贀(global::System.Object p0, global::Mass.Domain.Desktop.ValueObjects.EnumGameType p1, global::System.Object p2, global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p3, global::System.Object p4, global::System.UInt32 p5, global::System.Object p6, global::System.Object p7, global::System.Object p8, global::System.Byte p9) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Threading.Tasks.Task<global::Mass.Game.Launcher.Java.JavaGame> ____踀(global::System.Object p0, global::System.Object p1, global::System.Object p2, global::System.Object p3, global::System.Object p4, global::System.Object p5) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Threading.Tasks.Task<global::Mass.Game.Launcher.Java.JavaGame> ____輀(global::System.Object p0, global::System.Object p1, global::System.Object p2, global::System.Object p3, global::System.Object p4, global::System.Object p5) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____退(global::System.Object p0, global::System.Object p1, global::System.Object p2, global::System.Object p3) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____鄀(global::System.Object p0, global::System.Object p1, global::System.Object p2, global::System.Object p3) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____鈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____錀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____鐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Threading.Tasks.Task<global::Mass.Game.Launcher.Java.JavaGame> ____销(global::Mass.Application.Desktop.Models.SessionContext<global::Mass.Application.Desktop.DesktopSession, global::Mass.Domain.Desktop.Entities.NetGame.EntityNetGameItem> p0, global::System.Object p1, global::System.Object p2, global::System.Object p3, global::System.Byte p4) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public sealed class __c__DisplayClass2_0
		{
			public global::Mass.Game.Launcher.Java.LanGame.LanGameProxy proxy;
			public __c__DisplayClass2_0() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void _StartLanJavaGame_b__0() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectGlobalEmitter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::Mass.Game.Launcher.Extensions.SessionExtensions.__c__DisplayClass2_0 DecorateDetachedRunner() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void ____稀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void ____笀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____簀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____紀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____縀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____缀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public sealed class __c__DisplayClass7_0
		{
			public global::Mass.Bedrock.Proxy.BedrockProxy proxy;
			internal static global::Mass.Game.Launcher.Extensions.SessionExtensions.__c__DisplayClass7_0 CheckDetailedClient;
			public __c__DisplayClass7_0() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void _StartCppGameAsync_b__0() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateDividedListener() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::Mass.Game.Launcher.Extensions.SessionExtensions.__c__DisplayClass7_0 ExecuteSolver() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void ____猀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void ____琀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void ____甀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____瘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____眀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____砀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____礀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _StartNetCppGameAsync_d__5
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Mass.Game.Launcher.Cpp.CppGame> __t__builder;
			public global::System.String gameId;
			public global::System.String name;
			public global::Mass.Application.Mobile.MobileSession session;
			public global::Mass.Domain.Value.SectionValue gameValue;
			private void MoveNext(ref global::Mass.Game.Launcher.Extensions.SessionExtensions._StartNetCppGameAsync_d__5 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Extensions.SessionExtensions._StartNetCppGameAsync_d__5 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean GetTracer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckCentralTag() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____氀(ref global::Mass.Game.Launcher.Extensions.SessionExtensions._StartNetCppGameAsync_d__5 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____洀(ref global::Mass.Game.Launcher.Extensions.SessionExtensions._StartNetCppGameAsync_d__5 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____渀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____漀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____瀀(ref global::Mass.Game.Launcher.Extensions.SessionExtensions._StartNetCppGameAsync_d__5 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____焀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____爀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _StartNetJavaGameAsync_d__0
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Mass.Game.Launcher.Java.JavaGame> __t__builder;
			public global::Mass.Application.Desktop.Models.SessionContext<global::Mass.Application.Desktop.DesktopSession, global::Mass.Domain.Desktop.Entities.NetGame.EntityNetGameItem> context;
			public global::System.String name;
			public global::Mass.Domain.Value.SectionValue gameValue;
			public global::Mass.Domain.Value.SectionValue proxyValue;
			public global::System.Boolean blockIrcMessages;
			internal static global::System.Object ReplaceDecryptor;
			private void MoveNext(ref global::Mass.Game.Launcher.Extensions.SessionExtensions._StartNetJavaGameAsync_d__0 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Extensions.SessionExtensions._StartNetJavaGameAsync_d__0 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean LoadError() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckFilteredRecommender() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____搀(ref global::Mass.Game.Launcher.Extensions.SessionExtensions._StartNetJavaGameAsync_d__0 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____攀(ref global::Mass.Game.Launcher.Extensions.SessionExtensions._StartNetJavaGameAsync_d__0 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____昀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____最() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____栀(ref global::Mass.Game.Launcher.Extensions.SessionExtensions._StartNetJavaGameAsync_d__0 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____椀(ref global::Mass.Game.Launcher.Extensions.SessionExtensions._StartNetJavaGameAsync_d__0 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____樀(ref global::Mass.Game.Launcher.Extensions.SessionExtensions._StartNetJavaGameAsync_d__0 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____欀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _StartRentalCppGameAsync_d__6
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Mass.Game.Launcher.Cpp.CppGame> __t__builder;
			public global::System.String gameId;
			public global::System.String name;
			public global::Mass.Application.Mobile.MobileSession session;
			public global::System.String password;
			public global::Mass.Domain.Value.SectionValue gameValue;
			internal static global::System.Object MoveUser;
			private void MoveNext(ref global::Mass.Game.Launcher.Extensions.SessionExtensions._StartRentalCppGameAsync_d__6 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Extensions.SessionExtensions._StartRentalCppGameAsync_d__6 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectPassiveDistributor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectExternalNotifier() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____尀(ref global::Mass.Game.Launcher.Extensions.SessionExtensions._StartRentalCppGameAsync_d__6 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____崀(ref global::Mass.Game.Launcher.Extensions.SessionExtensions._StartRentalCppGameAsync_d__6 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____帀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____开() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____怀(ref global::Mass.Game.Launcher.Extensions.SessionExtensions._StartRentalCppGameAsync_d__6 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____愀(ref global::Mass.Game.Launcher.Extensions.SessionExtensions._StartRentalCppGameAsync_d__6 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____戀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____挀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _StartRentalJavaGameAsync_d__1
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Mass.Game.Launcher.Java.JavaGame> __t__builder;
			public global::System.String gameId;
			public global::System.String name;
			public global::Mass.Application.Desktop.DesktopSession session;
			public global::System.String password;
			public global::Mass.Domain.Value.SectionValue gameValue;
			public global::Mass.Domain.Value.SectionValue proxyValue;
			internal static global::System.Object DecorateOperationalDispatcher;
			private void MoveNext(ref global::Mass.Game.Launcher.Extensions.SessionExtensions._StartRentalJavaGameAsync_d__1 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Extensions.SessionExtensions._StartRentalJavaGameAsync_d__1 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean InstantiateMap() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateIdentifiableParser() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____刀(ref global::Mass.Game.Launcher.Extensions.SessionExtensions._StartRentalJavaGameAsync_d__1 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____匀(ref global::Mass.Game.Launcher.Extensions.SessionExtensions._StartRentalJavaGameAsync_d__1 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____吀(ref global::Mass.Game.Launcher.Extensions.SessionExtensions._StartRentalJavaGameAsync_d__1 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____唀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____嘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____圀(ref global::Mass.Game.Launcher.Extensions.SessionExtensions._StartRentalJavaGameAsync_d__1 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____堀(ref global::Mass.Game.Launcher.Extensions.SessionExtensions._StartRentalJavaGameAsync_d__1 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____夀(ref global::Mass.Game.Launcher.Extensions.SessionExtensions._StartRentalJavaGameAsync_d__1 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____娀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____嬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Game.Launcher.Exceptions {
	public abstract class FeverException
	{
		internal static global::Mass.Game.Launcher.Exceptions.FeverException ReflectExpandableDispatcher;
		public FeverException(global::System.String message) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectHiddenSingleton() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Exceptions.FeverException DecorateAdjustableParser() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____一() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____伀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____倀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____儀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Enums {
	public enum CppStep
	{
		Game = 1,
		GameProcess = 2,
	}

}
namespace Mass.Game.Launcher.Enums {
	public enum JavaStep
	{
		Java = 1,
		BaseVersion = 2,
		GameVersion = 3,
		CoreLib = 4,
		Components = 5,
		ServerResource = 6,
		GameProcess = 7,
		GameWindow = 8,
	}

}
namespace Mass.Game.Launcher.Entities {
	public class EntityPlayerLeaveResponse
	{
		internal static global::Mass.Game.Launcher.Entities.EntityPlayerLeaveResponse DecompressSummarizer;
		public global::System.UInt32 UserId { get; set; }
		public EntityPlayerLeaveResponse() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckSegmentedGateway() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Entities.EntityPlayerLeaveResponse CheckCommonProfiler() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____䌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____䐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____䔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____䘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____䜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____䠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____䤀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____䨀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ____䬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ____䰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ____䴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Entities {
	public class EntitySessionDescription
	{
		public global::System.String Type { get; set; }
		public global::System.String Mid { get; set; }
		public global::System.Int32 Index { get; set; }
		public global::System.String Sdp { get; set; }
		public EntitySessionDescription() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckPortableCompressor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Entities.EntitySessionDescription DecorateBasicResponder() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______2(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____㐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ____㔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ____㘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____㜀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____㠀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____㤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____㨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____㬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____㰀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____㴀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____㸀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____㼀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____䀀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____䄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____䈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Entities {
	public class EntityTurnAuthServer
	{
		public global::System.Int32 ExpirationInSeconds { get; set; }
		public global::System.Collections.Generic.List<global::Mass.Game.Launcher.Entities.EntityTurnResponse> TurnAuthServers { get; set; }
		public EntityTurnAuthServer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckRemoteEncryptor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Entities.EntityTurnAuthServer CreateMapper() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::Mass.Game.Launcher.Entities.EntityTurnResponse> _____() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::Mass.Game.Launcher.Entities.EntityTurnResponse> ______2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::Mass.Game.Launcher.Entities.EntityTurnResponse> ______3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____Ⰰ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____ⴀ(global::System.Collections.Generic.List<global::Mass.Game.Launcher.Entities.EntityTurnResponse> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______6(global::System.Collections.Generic.List<global::Mass.Game.Launcher.Entities.EntityTurnResponse> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ______7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______8(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______9(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Entities {
	public class EntityTurnResponse
	{
		public global::System.String Username { get; set; }
		public global::System.String Password { get; set; }
		public global::System.Collections.Generic.List<global::System.String> Urls { get; set; }
		public EntityTurnResponse() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectLiteralAllocator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Entities.EntityTurnResponse CheckScalableQueue() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____ᔀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____ᘀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____ᜀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____(global::System.Collections.Generic.List<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____ᤀ(global::System.Collections.Generic.List<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____ᨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____ᰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____ᴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____Ḁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____ἀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______4(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______5(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.String> ______8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.String> ______9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Entities {
	public class EntityWebSocketMessage
	{
		public global::System.String From { get; set; }
		public global::System.Int64 To { get; set; }
		public global::System.String Message { get; set; }
		public global::System.Int32 Type { get; set; }
		public EntityWebSocketMessage() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateGroupedTransformer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Entities.EntityWebSocketMessage CheckProcessor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____Ȁ(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____Ѐ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____Ԁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______3(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____ࠀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ______4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ______5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Int64 ______6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______7(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______8(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______9(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____ༀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____က() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____ᄀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____ሀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____ጀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Entities.Transfer {
	public class EntityJoinRoomResponse
	{
		public global::System.Byte Code { get; set; }
		public global::System.Collections.Generic.List<global::System.UInt32> Players { get; set; }
		public global::System.Boolean EnableRtc { get; set; }
		public EntityJoinRoomResponse() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ValidateConverter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Entities.Transfer.EntityJoinRoomResponse ReflectIterableElement() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____2(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____3(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____4(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____5(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____6(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _____9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___豈() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___切() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___ﬀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___ﰀ(global::System.Collections.Generic.List<global::System.UInt32> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___ﴀ(global::System.Collections.Generic.List<global::System.UInt32> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.UInt32> _____10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.UInt32> _____11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ____Ā() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Entities.Transfer {
	public class EntityLoginResponse
	{
		public global::System.Byte Code { get; set; }
		public EntityLoginResponse() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckLocalWriter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Entities.Transfer.EntityLoginResponse ReflectSymbolicDic() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____6(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _____7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _____8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Entities.Transfer {
	public enum EnumJoinRoomCode
	{
		Success = 0,
		RoomNotExist = 1,
		NoPermission = 3,
		RoomFull = 4,
		SuccessAlreadyInRoom = 17,
	}

}
namespace Mass.Game.Launcher.Entities.Transfer {
	public enum EnumLoginCode
	{
		Success = 0,
		Busy = 4,
		Invalid = 255,
	}

}
namespace Mass.Game.Launcher.Entities.Rpc {
	public class EntityChaChaHandShake
	{
		public global::System.Int16 A { get; set; }
		public global::System.String Key { get; set; }
		public EntityChaChaHandShake() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ResetClient() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Entities.Rpc.EntityChaChaHandShake ObserveListener() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____7(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____8(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt16 _____9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt16 _____10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____11(global::System.UInt16 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____12(global::System.UInt16 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Entities.Rpc {
	public class EntityCheckPlayer
	{
		internal static global::Mass.Game.Launcher.Entities.Rpc.EntityCheckPlayer MergeTracker;
		public global::System.Int32 Length { get; set; }
		public global::System.String Message { get; set; }
		public EntityCheckPlayer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateAlphabeticContext() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Entities.Rpc.EntityCheckPlayer FilterAggregator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___툀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___팀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___퐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___픀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___혀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___휀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____4(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Entities.Rpc {
	public class EntityClientShieldCheck
	{
		internal static global::Mass.Game.Launcher.Entities.Rpc.EntityClientShieldCheck DecorateLogicalPolicy;
		public global::System.Int32 Id { get; set; }
		public global::System.String Content { get; set; }
		public EntityClientShieldCheck() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateSimpleRequester() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Entities.Rpc.EntityClientShieldCheck EnableTransmitter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___였() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___윀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___저() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___준() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___쨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___쬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___찀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___촀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___츀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___케() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___퀀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___턀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Entities.Rpc {
	public class EntityGameDescription
	{
		public global::System.String NickName { get; set; }
		public global::System.UInt32 Version { get; set; }
		public global::System.String Guid { get; set; }
		public global::System.Collections.Generic.List<global::System.UInt64> ComponentList { get; set; }
		public EntityGameDescription() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateResponsiveWrapper() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Entities.Rpc.EntityGameDescription ReflectSortedProcessor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___눀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___대(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___됀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___딀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___똀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___뜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___렀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___뤀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.UInt64> ___먀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.UInt64> ___묀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___밀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___봀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___븀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___뼀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___쀀(global::System.Collections.Generic.List<global::System.UInt64> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___섀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___숀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___쌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___쐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___씀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Entities.Rpc {
	public class EntityOtherEnterWorld
	{
		internal static global::Mass.Game.Launcher.Entities.Rpc.EntityOtherEnterWorld DecorateCombinedContainer;
		public global::System.Int16 Id { get; set; }
		public global::System.String Name { get; set; }
		public global::System.String Uuid { get; set; }
		public EntityOtherEnterWorld() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean PushDispatcher() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Entities.Rpc.EntityOtherEnterWorld CheckSequentialVerifier() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___ꄀ(global::System.UInt16 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___ꈀ(global::System.UInt16 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___ꌀ(global::System.UInt16 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___ꐀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___ꔀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___ꘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt16 ____() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt16 ___ꠀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___꤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___ꨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____2(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___가(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___관() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___글() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___꼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___뀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___넀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Entities.Java {
	public class EntityGameException
	{
		internal static global::Mass.Game.Launcher.Entities.Java.EntityGameException ReflectSetAnnotation;
		public global::System.Boolean Success { get; set; }
		public global::System.String Message { get; set; }
		public global::System.Exception Error { get; set; }
		public EntityGameException() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectEfficientComparator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Entities.Java.EntityGameException SetHandler() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___鄀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___鈀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___錀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___鐀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___销(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___阀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___需() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___頀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___餀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___騀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___鬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___鰀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___鴀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___鸀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___鼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___ꀀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Entities.Java {
	public class EntityModSettings
	{
		internal static global::Mass.Game.Launcher.Entities.Java.EntityModSettings ReflectStruct;
		public global::System.Boolean GamePopup { get; set; }
		public global::System.Boolean LazyDfu { get; set; }
		public global::System.Boolean NetworkEncrypt { get; set; }
		public global::System.Int32 NetworkCompressionThreshold { get; set; }
		public global::Mass.Game.Launcher.Entities.Java.EntityGameException Result { get; set; }
		public EntityModSettings() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectDetachedConsumer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Entities.Java.EntityModSettings DecorateDetailedStrategy() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___簀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___紀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___縀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___缀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___耀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___脀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___舀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___茀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___萀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___蔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___蘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___蜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___蠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___褀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___言() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___謀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___谀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___贀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___踀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___輀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___退() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Entities.Java {
	public class EntityUserProperties
	{
		public global::System.UInt64[] UserId { get; set; }
		public global::System.Int32[] GameId { get; set; }
		public global::System.Int32[] LauncherPort { get; set; }
		public global::System.String[] FilterKey { get; set; }
		public global::System.String[] FilterPath { get; set; }
		public global::System.Int32[] TimeDelta { get; set; }
		public global::System.String[] LaunchVersion { get; set; }
		public EntityUserProperties() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectGeneralConfig() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Entities.Java.EntityUserProperties CheckExtendedEmitter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___娀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___嬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___尀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___崀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___帀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___开() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___怀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___愀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___戀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___挀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___搀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___攀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___昀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___最() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___栀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___椀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___樀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___欀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___氀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___洀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___渀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___漀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___瀀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___焀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___爀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___猀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___琀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___甀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___瘀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___眀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___砀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___礀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___稀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___笀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Entities.Java {
	public class EntityUserPropertiesEx
	{
		public global::System.Int32 GameType { get; set; }
		public global::System.Boolean IsFilter { get; set; }
		public global::System.String Channel { get; set; }
		public global::System.Int32 TimeDelta { get; set; }
		public global::System.String LauncherVersion { get; set; }
		public EntityUserPropertiesEx() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateCentralClient() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Entities.Java.EntityUserPropertiesEx SerializeCompressor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___䄀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___䈀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___䌀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___䐀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___䔀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___䘀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___䜀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___䠀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___䤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___䨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___䬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___䰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___䴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___一() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___伀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___倀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___儀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___刀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___匀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___吀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___唀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___嘀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___圀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___堀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___夀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Entities.Fever {
	public class EntityFeverApp
	{
		internal static global::Mass.Game.Launcher.Entities.Fever.EntityFeverApp CheckScheduledTracker;
		public global::Mass.Game.Launcher.Entities.Fever.EntityFeverAppVersion MainContent { get; set; }
		public EntityFeverApp() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean AssembleStream() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Entities.Fever.EntityFeverApp ReflectAutomatedAggregator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___㘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___㜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___㠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___㤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___㨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___㬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___㰀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___㴀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___㸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___㼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___䀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Entities.Fever {
	public class EntityFeverAppVersion
	{
		internal static global::Mass.Game.Launcher.Entities.Fever.EntityFeverAppVersion DecoratePassiveTag;
		public global::System.String VersionCode { get; set; }
		public global::System.Int32 AppContentId { get; set; }
		public EntityFeverAppVersion() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean StopFinder() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Entities.Fever.EntityFeverAppVersion DecorateOperationalTransmitter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ____() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___Ⰰ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___ⴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____6(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____7(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___㐀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___㔀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Entities.Fever {
	public class EntityFeverEntry
	{
		internal static global::Mass.Game.Launcher.Entities.Fever.EntityFeverEntry ReflectVirtualRecommender;
		public global::System.String Name { get; set; }
		public global::System.Int32 Dir { get; set; }
		public global::System.String IndexUrl { get; set; }
		public global::System.String Md5 { get; set; }
		public global::System.Int32 CompressMethod { get; set; }
		public EntityFeverEntry() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateIdentifiableAnalyzer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Entities.Fever.EntityFeverEntry DecorateInterruptibleDistributor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___ጀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___ᔀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___ᘀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___ᜀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____2(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___ᤀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___ᨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___ᰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___ᴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___Ḁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___ἀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____8(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____9(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____10(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____11(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____13() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Entities.Fever {
	public class EntityFeverManifest
	{
		internal static global::Mass.Game.Launcher.Entities.Fever.EntityFeverManifest MeasureProvider;
		public global::System.Collections.Generic.List<global::Mass.Game.Launcher.Entities.Fever.EntityFeverEntry> Files { get; set; }
		public EntityFeverManifest() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean RemoveCalc() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Entities.Fever.EntityFeverManifest ConvertTree() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____5(global::System.Collections.Generic.List<global::Mass.Game.Launcher.Entities.Fever.EntityFeverEntry> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___ༀ(global::System.Collections.Generic.List<global::Mass.Game.Launcher.Entities.Fever.EntityFeverEntry> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::Mass.Game.Launcher.Entities.Fever.EntityFeverEntry> ___က() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::Mass.Game.Launcher.Entities.Fever.EntityFeverEntry> ___ᄀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::Mass.Game.Launcher.Entities.Fever.EntityFeverEntry> ___ሀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Entities.Fever {
	public class EntityFeverManifestInfo
	{
		internal static global::Mass.Game.Launcher.Entities.Fever.EntityFeverManifestInfo RateFilter;
		public global::System.String Name { get; set; }
		public global::System.String ManifestUrl { get; set; }
		public global::System.String AesKey { get; set; }
		public EntityFeverManifestInfo() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateAdjustableState() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Entities.Fever.EntityFeverManifestInfo DecorateGenericHandler() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____2(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __豈(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __切(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __ﬀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __ﰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __ﴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___Ā() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___Ȁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___Ѐ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___Ԁ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___ࠀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Entities.Fever {
	public class EntityFeverResponse<T0>
	{
		internal static global::System.Object CheckRandomStruct;
		public T0 Data { get; set; }
		public global::System.Int32 Code { get; set; }
		public global::System.String Message { get; set; }
		public EntityFeverResponse() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateCustomReporter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object DecorateAdvancedChain() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Cpp {
	public abstract class CppGame
	{
		public readonly global::System.String GameId;
		public readonly global::System.String Name;
		public readonly global::Mass.Application.Mobile.MobileSession Session;
		private global::System.IO.FileSystemWatcher Watcher { get; set; }
		private static global::Serilog.ILogger Logger { get; }
		public global::Mass.Domain.Entities.EntityProgress Progress { get; set; }
		public global::System.Boolean Starting { get; set; }
		public global::Mass.Domain.ValueObjects.EnumStepPhase LastPhase { get; set; }
		public global::Mass.Game.Launcher.Enums.CppStep LastStep { get; set; }
		private static global::Mass.Game.Launcher.Cpp.CppTask Task { get; }
		public global::System.Boolean Launched { get; set; }
		private global::System.Diagnostics.Process Process { get; set; }
		private global::Mass.Game.Launcher.Paths.CppGamePath Path { get; set; }
		private global::Mass.Game.Launcher.Values.CppGameValue Value { get; }
		public global::System.Boolean HasExited { get; set; }
		public global::System.Int32 ExitCode { get; set; }
		public global::System.Int32 ProcessId { get; set; }
		private global::Mass.Game.Launcher.Cpp.CppGameRpc Rpc { get; set; }
		private global::Mass.Game.Launcher.Cpp.CppGameAuthenticator Authenticator { get; set; }
		public global::System.Action<global::Mass.Game.Launcher.Cpp.CppGame> GameProgressChanged;  // 原为 event，改为字段以避免 add_/remove_ 保留名冲突
		public global::System.Action Disposed;  // 原为 event，改为字段以避免 add_/remove_ 保留名冲突
		private global::System.Object LaunchStepsAsync() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void Dispose() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void OnGameExit(global::System.Object sender, global::System.Object e) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void Patch() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void OnFileCreate(global::System.Object sender, global::System.Object e) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task PrepareGameAsync(global::System.Threading.CancellationToken cancellationToken) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public CppGame(global::Mass.Game.Launcher.Cpp.EntityLaunchCppGame args) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void add_GameProgressChanged(global::System.Action<global::Mass.Game.Launcher.Cpp.CppGame> @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void remove_GameProgressChanged(global::System.Action<global::Mass.Game.Launcher.Cpp.CppGame> @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void add_Disposed(global::System.Action @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void remove_Disposed(global::System.Action @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void StartLaunch() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object LaunchAsync() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ReportProgress(global::Mass.Domain.ValueObjects.EnumStepPhase phase, global::Mass.Game.Launcher.Enums.CppStep step, global::System.UInt32 percentage, global::System.Object message) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object GetStepMessage(global::Mass.Domain.ValueObjects.EnumStepPhase phase, global::Mass.Game.Launcher.Enums.CppStep step, global::System.Object message) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object GetStepName(global::Mass.Domain.ValueObjects.EnumStepPhase phase, global::Mass.Game.Launcher.Enums.CppStep step) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void ReportProgress_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object StartGameAsync(global::System.Threading.CancellationToken token) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object StartGameUnsafe(global::System.Threading.CancellationToken token) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.String ToString() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		static CppGame() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _PrepareGameAsync_b__10_0(global::System.UInt32 p) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _PrepareGameAsync_b__10_1(global::System.UInt32 p) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _StartGameUnsafe_g__Report_87_0(global::System.IntPtr p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectMixedParameter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Cpp.CppGame DecorateFlexibleGateway() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____开() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____怀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____愀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____戀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____挀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____最() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____栀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____椀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____樀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _____欀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____氀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____洀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____渀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____漀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _____瀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _____焀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____猀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____琀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____甀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____瘀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____眀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____砀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Game.Launcher.Enums.CppStep _____礀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Game.Launcher.Enums.CppStep _____稀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____紀(global::Mass.Domain.ValueObjects.EnumStepPhase p0, global::Mass.Game.Launcher.Enums.CppStep p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____縀(global::System.IntPtr p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____缀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____耀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____脀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____舀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____茀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____萀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____蔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____蘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _____蜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _____蠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____褀(global::Mass.Domain.ValueObjects.EnumStepPhase p0, global::Mass.Game.Launcher.Enums.CppStep p1, global::System.UInt32 p2, global::System.Object p3) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____言(global::Mass.Domain.ValueObjects.EnumStepPhase p0, global::Mass.Game.Launcher.Enums.CppStep p1, global::System.UInt32 p2, global::System.Object p3) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____謀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____谀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____贀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____踀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _____輀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _____退() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____鈀(global::Mass.Domain.ValueObjects.EnumStepPhase p0, global::Mass.Game.Launcher.Enums.CppStep p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____錀(global::Mass.Domain.ValueObjects.EnumStepPhase p0, global::Mass.Game.Launcher.Enums.CppStep p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____鐀(global::Mass.Domain.ValueObjects.EnumStepPhase p0, global::Mass.Game.Launcher.Enums.CppStep p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____销() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____阀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____需() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____頀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____餀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____騀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____鬀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____鰀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____鴀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____鸀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____鼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____ꀀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____ꄀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____ꈀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____ꌀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____ꐀ(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____ꔀ(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____ꘀ(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ______(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____ꠀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____꤀(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____ꨀ(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _______2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____가() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____관() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____글(global::Mass.Domain.ValueObjects.EnumStepPhase p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____꼀(global::Mass.Domain.ValueObjects.EnumStepPhase p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____뀀(global::Mass.Domain.ValueObjects.EnumStepPhase p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____넀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____눀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.ValueObjects.EnumStepPhase _____대() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.ValueObjects.EnumStepPhase _____됀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____딀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____똀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____뜀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____렀(global::System.Action<global::Mass.Game.Launcher.Cpp.CppGame> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____뤀(global::System.Action<global::Mass.Game.Launcher.Cpp.CppGame> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____먀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____묀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____밀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____봀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____븀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____뼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____쀀(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____섀(global::System.Action<global::Mass.Game.Launcher.Cpp.CppGame> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____숀(global::System.Action<global::Mass.Game.Launcher.Cpp.CppGame> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____쌀(global::Mass.Game.Launcher.Enums.CppStep p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____쐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____씀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____였() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _____윀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _____저() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____준() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____쨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public struct __c__DisplayClass87_0
		{
			public global::Mass.Game.Launcher.Cpp.CppGame __4__this;
			public global::System.Int32 percentage;
		}

		public struct _LaunchAsync_d__61
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Cpp.CppGame __4__this;
			internal static global::System.Object DecorateExpandableReporter;
			private void MoveNext(ref global::Mass.Game.Launcher.Cpp.CppGame._LaunchAsync_d__61 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Cpp.CppGame._LaunchAsync_d__61 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean PopDic() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectAdjustableEnumerator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ___(ref global::Mass.Game.Launcher.Cpp.CppGame._LaunchAsync_d__61 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____2(ref global::Mass.Game.Launcher.Cpp.CppGame._LaunchAsync_d__61 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____3(ref global::Mass.Game.Launcher.Cpp.CppGame._LaunchAsync_d__61 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____6(ref global::Mass.Game.Launcher.Cpp.CppGame._LaunchAsync_d__61 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _LaunchStepsAsync_d__1
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Cpp.CppGame __4__this;
			internal static global::System.Object ReflectGenericParameter;
			private void MoveNext(ref global::Mass.Game.Launcher.Cpp.CppGame._LaunchStepsAsync_d__1 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Cpp.CppGame._LaunchStepsAsync_d__1 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectRandomGateway() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckCustomProfiler() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ___(ref global::Mass.Game.Launcher.Cpp.CppGame._LaunchStepsAsync_d__1 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____2(ref global::Mass.Game.Launcher.Cpp.CppGame._LaunchStepsAsync_d__1 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____5(ref global::Mass.Game.Launcher.Cpp.CppGame._LaunchStepsAsync_d__1 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _PrepareGameAsync_d__10
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Cpp.CppGame __4__this;
			public global::System.Threading.CancellationToken cancellationToken;
			internal static global::System.Object EncodeProgram;
			private void MoveNext(ref global::Mass.Game.Launcher.Cpp.CppGame._PrepareGameAsync_d__10 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Cpp.CppGame._PrepareGameAsync_d__10 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ExcludeTemplate() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateMixedResponder() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ___(ref global::Mass.Game.Launcher.Cpp.CppGame._PrepareGameAsync_d__10 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____2(ref global::Mass.Game.Launcher.Cpp.CppGame._PrepareGameAsync_d__10 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ____4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____5(ref global::Mass.Game.Launcher.Cpp.CppGame._PrepareGameAsync_d__10 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ____6(ref global::Mass.Game.Launcher.Cpp.CppGame._PrepareGameAsync_d__10 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _StartGameAsync_d__78
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Cpp.CppGame __4__this;
			public global::System.Threading.CancellationToken token;
			internal static global::System.Object CheckFlexibleStream;
			private void MoveNext(ref global::Mass.Game.Launcher.Cpp.CppGame._StartGameAsync_d__78 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Cpp.CppGame._StartGameAsync_d__78 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectSegmentedEncryptor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckCommonController() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __케(ref global::Mass.Game.Launcher.Cpp.CppGame._StartGameAsync_d__78 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __퀀(ref global::Mass.Game.Launcher.Cpp.CppGame._StartGameAsync_d__78 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __턀(ref global::Mass.Game.Launcher.Cpp.CppGame._StartGameAsync_d__78 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __툀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __팀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __혀(ref global::Mass.Game.Launcher.Cpp.CppGame._StartGameAsync_d__78 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __휀(ref global::Mass.Game.Launcher.Cpp.CppGame._StartGameAsync_d__78 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ___(ref global::Mass.Game.Launcher.Cpp.CppGame._StartGameAsync_d__78 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ____3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _StartGameUnsafe_d__87
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Cpp.CppGame __4__this;
			public global::System.Threading.CancellationToken token;
			internal static global::System.Object CheckAdaptableFinder;
			private void MoveNext(ref global::Mass.Game.Launcher.Cpp.CppGame._StartGameUnsafe_d__87 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Cpp.CppGame._StartGameUnsafe_d__87 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectPortableAllocator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ArrangePolicy() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __숀(ref global::Mass.Game.Launcher.Cpp.CppGame._StartGameUnsafe_d__87 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __쌀(ref global::Mass.Game.Launcher.Cpp.CppGame._StartGameUnsafe_d__87 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __쐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __씀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __였() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __찀(ref global::Mass.Game.Launcher.Cpp.CppGame._StartGameUnsafe_d__87 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __촀(ref global::Mass.Game.Launcher.Cpp.CppGame._StartGameUnsafe_d__87 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __츀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Game.Launcher.Cpp {
	public class CppGameAuthenticator
	{
		internal static global::Mass.Game.Launcher.Cpp.CppGameAuthenticator CheckSegmentedProfiler;
		private static global::Serilog.ILogger Logger { get; }
		public CppGameAuthenticator(global::Mass.Application.Mobile.MobileSession session, global::System.String gameId, global::Mass.Domain.Desktop.ValueObjects.EnumGameType type) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void StartListen(global::System.Int32 port) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ListenAsync() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object AcceptAsync(global::System.Object context) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<global::System.Byte[]> CallBackAsync(global::System.Object context) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void Dispose() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		static CppGameAuthenticator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckCommonFactory() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Cpp.CppGameAuthenticator CheckAdaptableCompressor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____쬀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____찀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____촀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____츀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____케() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____퀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<global::System.Byte[]> _____턀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<global::System.Byte[]> _____툀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _____퐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _____픀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____혀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____휀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public struct _AcceptAsync_d__10
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Cpp.CppGameAuthenticator __4__this;
			public global::System.Net.HttpListenerContext context;
			private void MoveNext(ref global::Mass.Game.Launcher.Cpp.CppGameAuthenticator._AcceptAsync_d__10 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Cpp.CppGameAuthenticator._AcceptAsync_d__10 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CloseModule() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckActiveProvider() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __됀(ref global::Mass.Game.Launcher.Cpp.CppGameAuthenticator._AcceptAsync_d__10 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __딀(ref global::Mass.Game.Launcher.Cpp.CppGameAuthenticator._AcceptAsync_d__10 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __똀(ref global::Mass.Game.Launcher.Cpp.CppGameAuthenticator._AcceptAsync_d__10 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __뜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __렀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __븀(ref global::Mass.Game.Launcher.Cpp.CppGameAuthenticator._AcceptAsync_d__10 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __뼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __쀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __섀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _CallBackAsync_d__11
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::System.Byte[]> __t__builder;
			public global::System.Net.HttpListenerContext context;
			public global::Mass.Game.Launcher.Cpp.CppGameAuthenticator __4__this;
			private void MoveNext(ref global::Mass.Game.Launcher.Cpp.CppGameAuthenticator._CallBackAsync_d__11 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Cpp.CppGameAuthenticator._CallBackAsync_d__11 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectLiteralTree() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateScalableFilter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ___(ref global::Mass.Game.Launcher.Cpp.CppGameAuthenticator._CallBackAsync_d__11 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __ꠀ(ref global::Mass.Game.Launcher.Cpp.CppGameAuthenticator._CallBackAsync_d__11 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __꤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __ꨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __넀(ref global::Mass.Game.Launcher.Cpp.CppGameAuthenticator._CallBackAsync_d__11 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __눀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __대() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _ListenAsync_d__9
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Cpp.CppGameAuthenticator __4__this;
			internal static global::System.Object DirectConverter;
			private void MoveNext(ref global::Mass.Game.Launcher.Cpp.CppGameAuthenticator._ListenAsync_d__9 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Cpp.CppGameAuthenticator._ListenAsync_d__9 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateGroupedWriter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectAccessibleDic() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __鸀(ref global::Mass.Game.Launcher.Cpp.CppGameAuthenticator._ListenAsync_d__9 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __鼀(ref global::Mass.Game.Launcher.Cpp.CppGameAuthenticator._ListenAsync_d__9 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __ꀀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __ꄀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __ꌀ(ref global::Mass.Game.Launcher.Cpp.CppGameAuthenticator._ListenAsync_d__9 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __ꐀ(ref global::Mass.Game.Launcher.Cpp.CppGameAuthenticator._ListenAsync_d__9 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __ꔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __ꘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Game.Launcher.Cpp {
	public class CppGameConfig
	{
		internal static global::Mass.Game.Launcher.Cpp.CppGameConfig DecoratePortableResponder;
		public global::Mass.Game.Launcher.Cpp.LaunchParams LaunchParams { get; set; }
		public global::Mass.Game.Launcher.Cpp.WorldInfo WorldInfo { get; set; }
		public global::Mass.Game.Launcher.Cpp.RoomInfo RoomInfo { get; set; }
		public global::Mass.Game.Launcher.Cpp.PlayerInfo PlayerInfo { get; set; }
		public global::Mass.Game.Launcher.Cpp.SkinInfo SkinInfo { get; set; }
		public global::Mass.Game.Launcher.Cpp.AntiAddictionInfo AntiAddictionInfo { get; set; }
		public global::Mass.Game.Launcher.Cpp.MiscInfo Misc { get; set; }
		public global::System.String Path { get; set; }
		public global::System.String WebServerUrl { get; set; }
		public global::System.String CoreServerUrl { get; set; }
		public global::Mass.Game.Launcher.Cpp.SocialSetting SocialSetting { get; set; }
		public global::System.Collections.Generic.List<global::System.String> VipUsingMod { get; set; }
		public global::Mass.Game.Launcher.Cpp.ResultInfo Result { get; set; }
		public CppGameConfig(global::System.Int32 rpcPort, global::System.String authUrl, global::System.String configPath, global::System.String skinMd5, global::System.String skinPath, global::System.String gameId, global::System.String gameName, global::System.String address, global::System.Int32 port, global::System.UInt32 userId, global::System.String token, global::System.String userName) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectBasicStream() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Cpp.CppGameConfig DecorateReadableEncryptor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __愀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __戀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __挀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __搀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __攀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __昀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __最() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __栀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __椀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __洀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __渀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __漀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __瀀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __焀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __爀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __猀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __琀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __甀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __瘀(global::System.Collections.Generic.List<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __眀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __砀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __礀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __稀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __笀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __簀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __紀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __縀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __缀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __耀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __脀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __舀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __茀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __萀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __蔀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __蘀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __蜀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __蠀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __褀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __言() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __謀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __谀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __贀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __踀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.String> __輀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __退() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __鄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __鈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __錀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __鐀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __销() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __阀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __需(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __頀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __餀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __騀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __鬀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __鰀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __鴀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Cpp {
	public class LaunchParams
	{
		internal static global::Mass.Game.Launcher.Cpp.LaunchParams DecorateRemoteController;
		public global::System.Boolean ClosePetAddon { get; set; }
		public LaunchParams() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckActiveFinder() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Cpp.LaunchParams ReflectJoinedAllocator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __夀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __娀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __嬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __尀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __崀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __帀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __开() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __怀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Cpp {
	public class WorldInfo
	{
		public global::System.String LevelId { get; set; }
		public global::System.Int32 GameType { get; set; }
		public global::System.Int32 Difficulty { get; set; }
		public global::System.Int32 PermissionLevel { get; set; }
		public global::System.Boolean Cheat { get; set; }
		public global::System.Boolean OtherCheat { get; set; }
		public global::Mass.Game.Launcher.Cpp.CheatInfo CheatInfo { get; set; }
		public global::System.Collections.Generic.List<global::System.String> ResourcePacks { get; set; }
		public global::System.Collections.Generic.List<global::System.String> BehaviorPacks { get; set; }
		public global::System.String Name { get; set; }
		public global::System.Int32 WorldType { get; set; }
		public global::System.Boolean StartWithMap { get; set; }
		public global::System.Boolean BonusItems { get; set; }
		public global::System.String Seed { get; set; }
		public WorldInfo() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckScalableSender() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Cpp.WorldInfo ReflectModularTransformer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.String> __ᴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.String> __Ḁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __ἀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____2(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____3(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ____4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ____5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____9(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____10(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____11(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____12(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __Ⰰ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __ⴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ____13() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ____14() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.String> ____15() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.String> ____16() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____17() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____18() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __㐀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __㔀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __㘀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __㜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __㠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __㤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __㨀(global::System.Collections.Generic.List<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __㬀(global::System.Collections.Generic.List<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __㰀(global::System.Collections.Generic.List<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __㴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __㸀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __㼀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __䀀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __䄀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __䈀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __䌀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __䐀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __䔀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __䘀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __䜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __䠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __䤀(global::System.Collections.Generic.List<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __䨀(global::System.Collections.Generic.List<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __䬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __䰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __䴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __一() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __伀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __倀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __儀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __刀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __匀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __吀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __唀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __嘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __圀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __堀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Cpp {
	public class CheatInfo
	{
		public global::System.Boolean Pvp { get; set; }
		public global::System.Boolean ShowCoordinates { get; set; }
		public global::System.Boolean AlwaysDay { get; set; }
		public global::System.Boolean DaylightCycle { get; set; }
		public global::System.Boolean FireSpreads { get; set; }
		public global::System.Boolean TntExplodes { get; set; }
		public global::System.Boolean KeepInventory { get; set; }
		public global::System.Boolean MobSpawn { get; set; }
		public global::System.Boolean NaturalRegeneration { get; set; }
		public global::System.Boolean MobLoot { get; set; }
		public global::System.Boolean MobGriefing { get; set; }
		public global::System.Boolean TileDrops { get; set; }
		public global::System.Boolean EntitiesDropLoot { get; set; }
		public global::System.Boolean WeatherCycle { get; set; }
		public global::System.Boolean CommandBlocksEnabled { get; set; }
		public global::System.Int32 RandomTickSpeed { get; set; }
		public global::System.Boolean ExperimentalHoliday { get; set; }
		public global::System.Boolean ExperimentalBiomes { get; set; }
		public global::System.Boolean FancyBubbles { get; set; }
		public CheatInfo() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateAccessibleVisitor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Cpp.CheatInfo CheckIsolatedWatcher() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _쬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _찀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _촀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _츀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _케(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _퀀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _턀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _툀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _팀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _퐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _픀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _혀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _휀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___3(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___4(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___5(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___6(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___7(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___12(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___13(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___14(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___15(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___16(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___17() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___18() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___19() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___20() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___21(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___22(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___23(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___24(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___25(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___26(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___27(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___28(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___29(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___30(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___31() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___32() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___33() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _豈() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _切(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _ﬀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _ﰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _ﴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___34() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___35() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __Ā(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __Ȁ(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __Ѐ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __Ԁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ____2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ____3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __ࠀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ____4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____5(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____6(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____7(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ____8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____9(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __ༀ(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __က() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __ᄀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __ሀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __ጀ(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____10(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __ᔀ(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __ᘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __ᜀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ____11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __ᤀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __ᨀ(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____12(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __ᰀ(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Cpp {
	public class RoomInfo
	{
		internal static global::Mass.Game.Launcher.Cpp.RoomInfo CheckAutomatableElement;
		public global::System.String Ip { get; set; }
		public global::System.Int32 Port { get; set; }
		public global::System.String RoomName { get; set; }
		public global::System.String EnterPassword { get; set; }
		public global::System.String Token { get; set; }
		public global::System.Int32 RoomId { get; set; }
		public global::System.Int64 HostId { get; set; }
		public global::System.Boolean AllowPe { get; set; }
		public global::System.Int32 MaxPlayer { get; set; }
		public global::System.Int32 VisibilityMode { get; set; }
		public global::System.Collections.Generic.List<global::System.String> ItemIds { get; set; }
		public global::System.Collections.Generic.List<global::System.UInt32> TagIds { get; set; }
		public global::System.Int32 SimpleGameVersion { get; set; }
		public global::System.String CreateRoomExtraBits { get; set; }
		public global::System.Int32 SignalWebPort { get; set; }
		public global::System.Boolean InWebrtcGray { get; set; }
		public global::System.Boolean ModPreDownload { get; set; }
		public RoomInfo() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean LoadTracer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Cpp.RoomInfo JoinResolver() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _舀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _茀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _萀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _蔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _蘀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _蜀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _蠀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _褀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _言(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _謀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _谀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _贀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _踀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _輀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _退(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _鄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _鈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _錀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _鐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _销() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _阀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _需() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.UInt32> _頀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.UInt32> _餀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _騀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _鬀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Int64 _鰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Int64 _鴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _鸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _鼀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ꀀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ꄀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ꈀ(global::System.Collections.Generic.List<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ꌀ(global::System.Collections.Generic.List<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ꐀ(global::System.Collections.Generic.List<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ꔀ(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _ꘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ꠀ(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _꤀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ꨀ(global::System.Collections.Generic.List<global::System.UInt32> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___2(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _가(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _관() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _글() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _꼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _뀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _넀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.String> _눀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.String> _대() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.String> _됀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _딀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _똀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _뜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _렀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _뤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _먀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _묀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _밀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _봀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _븀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _뼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _쀀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _섀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _숀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _쌀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _쐀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _씀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _였(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _윀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _저() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _준() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _쨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Cpp {
	public class PlayerInfo
	{
		public global::System.UInt32 UserId { get; set; }
		public global::System.String UserName { get; set; }
		public global::System.String Urs { get; set; }
		public PlayerInfo() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectSymbolicObject() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Cpp.PlayerInfo ReflectConfigurableDecorator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _焀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _爀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _猀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _琀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _甀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _瘀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _眀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _砀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _礀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _稀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _笀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _簀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _紀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _縀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _缀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _耀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _脀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Cpp {
	public class SkinInfo
	{
		internal static global::Mass.Game.Launcher.Cpp.SkinInfo ReflectSeparatedArgument;
		public global::System.String SkinPath { get; set; }
		public global::System.String Md5 { get; set; }
		public global::System.Boolean IsSlim { get; set; }
		public global::System.String SkinIid { get; set; }
		public SkinInfo() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateMonoSummarizer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Cpp.SkinInfo PatchPublisher() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _开(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _怀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _愀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _戀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _挀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _搀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _攀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _昀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _最() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _栀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _椀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _樀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _欀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _氀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _洀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _渀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _漀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _瀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Cpp {
	public class AntiAddictionInfo
	{
		internal static global::Mass.Game.Launcher.Cpp.AntiAddictionInfo AttachTransformer;
		public global::System.Boolean Enable { get; set; }
		public global::System.Int32 LeftTime { get; set; }
		public global::System.Decimal ExpMultiplier { get; set; }
		public global::System.Decimal BlockMultiplier { get; set; }
		public global::System.String FirstMessage { get; set; }
		public AntiAddictionInfo() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean AddMap() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Cpp.AntiAddictionInfo ReflectStaticDecider() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _䜀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _䠀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _䤀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _䨀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _䬀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _䰀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _䴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _一() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _伀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _倀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _儀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _刀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Decimal _匀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Decimal _吀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _唀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _嘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _圀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _堀(global::System.Decimal p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _夀(global::System.Decimal p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _娀(global::System.Decimal p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _嬀(global::System.Decimal p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Decimal _尀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Decimal _崀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Cpp {
	public class MiscInfo
	{
		internal static global::Mass.Game.Launcher.Cpp.MiscInfo ReflectDynamicList;
		public global::System.Int32 MultiplayerGameType { get; set; }
		public global::System.String AuthServerUrl { get; set; }
		public global::System.Int32 LauncherPort { get; set; }
		public global::System.String SensitiveWordFile { get; set; }
		public MiscInfo() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckConcreteRecord() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Cpp.MiscInfo DecorateConnectedContext() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _㐀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _㔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _㘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _㜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _㠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _㤀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _㨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _㬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _㰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _㴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _㸀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _㼀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _䀀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _䄀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _䈀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _䌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _䐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _䔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _䘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Cpp {
	public class SocialSetting
	{
		public global::System.Boolean UnderageMode { get; set; }
		public global::System.Boolean BlockStrangers { get; set; }
		public global::System.Boolean BlockAllMessages { get; set; }
		public global::System.Boolean BlockRepostedAndCommented { get; set; }
		public global::System.Int32 MessageVisibility { get; set; }
		public SocialSetting() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectEditablePolicy() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Cpp.SocialSetting ProcessObject() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ᴀ(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _Ḁ(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ἀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___2(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___3(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _Ⰰ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _ⴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___13(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___14(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___15(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___16() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___17() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Cpp {
	public class ResultInfo
	{
		internal static global::Mass.Game.Launcher.Cpp.ResultInfo DecorateSimpleModule;
		public global::System.Boolean A { get; set; }
		public global::System.String B { get; set; }
		public global::System.Exception C { get; set; }
		public ResultInfo() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectControllableEvent() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Cpp.ResultInfo CheckTransferableWrapper() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___2(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___3(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ༀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _က(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ᄀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _ሀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _ጀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _ᔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _ᘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _ᜀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ᤀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _ᨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _ᰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Cpp {
	public class CppGameConfigCipher
	{
		public static global::System.String Encrypt(global::System.String data) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.String Encrypt_2(global::System.String data, global::System.String key) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.String Decrypt(global::System.String data) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.String Decrypt_2(global::System.String data, global::System.String key) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object EncryptBlocks(global::System.Object v, global::System.Object k) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object DecryptBlocks(global::System.Object v, global::System.Object k) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Int64 CalculateMix(global::System.Int64 z, global::System.Int64 y, global::System.Int64 sum, global::System.Object k, global::System.UInt32 p, global::System.Int64 e) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ToInt64Array(global::System.Object byteArray) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ToByteArray(global::System.Object longArray) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ToHexString(global::System.Object longArray) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object HexStringToLongArray(global::System.Object hexString) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean PresentTemplate() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Cpp.CppGameConfigCipher CheckCombinedConverter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __2(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __3(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object __4(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object __5(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __6(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __7(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __8(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __9(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 豈() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 切() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ﬀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ﰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ﴀ(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object __10(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object __11(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _Ā(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _Ȁ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _Ѐ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _Ԁ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ___2(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ___3(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Int64 _ࠀ(global::System.Int64 p0, global::System.Int64 p1, global::System.Int64 p2, global::System.Object p3, global::System.UInt32 p4, global::System.Int64 p5) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Int64 ___4(global::System.Int64 p0, global::System.Int64 p1, global::System.Int64 p2, global::System.Object p3, global::System.UInt32 p4, global::System.Int64 p5) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Int64 ___5(global::System.Int64 p0, global::System.Int64 p1, global::System.Int64 p2, global::System.Object p3, global::System.UInt32 p4, global::System.Int64 p5) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ___6(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Cpp {
	public class EntityLaunchCppGame
	{
		internal static global::Mass.Game.Launcher.Cpp.EntityLaunchCppGame StartDecider;
		protected global::System.Type EqualityContract { get; }
		public global::Mass.Application.Mobile.MobileSession Session { get; set; }
		public global::System.String GameId { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameType GameType { get; set; }
		public global::System.String Name { get; set; }
		public global::System.String ServerAddress { get; set; }
		public global::System.Int32 ServerPort { get; set; }
		public global::Mass.Domain.Value.SectionValue Value { get; set; }
		public EntityLaunchCppGame(global::Mass.Application.Mobile.MobileSession Session, global::System.String GameId, global::Mass.Domain.Desktop.ValueObjects.EnumGameType GameType, global::System.String Name, global::System.String ServerAddress, global::System.Int32 ServerPort, global::Mass.Domain.Value.SectionValue Value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.String ToString() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected global::System.Boolean PrintMembers(global::System.Text.StringBuilder builder) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.Boolean op_Inequality(global::Mass.Game.Launcher.Cpp.EntityLaunchCppGame left, global::Mass.Game.Launcher.Cpp.EntityLaunchCppGame right) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.Boolean op_Equality(global::Mass.Game.Launcher.Cpp.EntityLaunchCppGame left, global::Mass.Game.Launcher.Cpp.EntityLaunchCppGame right) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Int32 GetHashCode() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Boolean Equals(global::System.Object obj) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Boolean Equals_2(global::Mass.Game.Launcher.Cpp.EntityLaunchCppGame other) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::Mass.Game.Launcher.Cpp.EntityLaunchCppGame _Clone__() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected EntityLaunchCppGame(global::Mass.Game.Launcher.Cpp.EntityLaunchCppGame original) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void Deconstruct(out global::Mass.Application.Mobile.MobileSession Session, out global::System.String GameId, out global::Mass.Domain.Desktop.ValueObjects.EnumGameType GameType, out global::System.String Name, out global::System.String ServerAddress, out global::System.Int32 ServerPort, out global::Mass.Domain.Value.SectionValue Value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ResumeList() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Cpp.EntityLaunchCppGame ReflectSetComparator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object 가(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object 관(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object 글(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object 꼀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object 뀀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object 넀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object 눀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected global::System.Object 대() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected global::System.Object 됀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected global::System.Object 딀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 똀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 뜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 렀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 뤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object 먀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object 묀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object 밀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 봀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 븀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 뼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected global::System.Byte 윀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected global::System.Byte 저(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected global::System.Byte 준(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 쨀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 쬀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte 찀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte 촀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte 츀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 케() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 퀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType 턀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType 툀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType 팀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 퐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 픀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 혀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 휀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object __2(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object __9(global::Mass.Domain.Desktop.ValueObjects.EnumGameType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __10(global::System.IntPtr p0, global::System.IntPtr p1, global::System.IntPtr p2, global::System.IntPtr p3, global::System.IntPtr p4, global::System.IntPtr p5, global::System.IntPtr p6) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __11(global::System.IntPtr p0, global::System.IntPtr p1, global::System.IntPtr p2, global::System.IntPtr p3, global::System.IntPtr p4, global::System.IntPtr p5, global::System.IntPtr p6) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object __12(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object __13(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __14() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __15() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __16() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __17() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __18(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __19(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __20(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Cpp {
	public abstract class CppGameRpc
	{
		private static global::Serilog.ILogger Logger { get; }
		public CppGameRpc(global::Mass.Application.Mobile.MobileSession session, global::Mass.Domain.Desktop.ValueObjects.EnumGameType type, global::System.String serverAddress, global::System.Int32 serverPort, global::System.String characterName) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void RegisterCallBack() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task HeartBeatAsync(global::Mass.Game.Launcher.Models.RpcCallBack callBack) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task AuthenticationAsync(global::Mass.Game.Launcher.Models.RpcCallBack callBack) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task PropertyExpandViewAsync(global::Mass.Game.Launcher.Models.RpcCallBack callBack) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task LaunchOrPlayGameAsync(global::Mass.Game.Launcher.Models.RpcCallBack callBack) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task LoginGameAsync(global::Mass.Game.Launcher.Models.RpcCallBack callBack) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task PeAntiCheatMessageAsync(global::Mass.Game.Launcher.Models.RpcCallBack callBack) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		static CppGameRpc() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectAttachedCommand() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Cpp.CppGameRpc CreatePolicy() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______2(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______3(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______4(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______7(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______8(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______9(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______10(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______11(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______12(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _______13() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______14(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______15(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______16(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _______17() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _______18() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _______19() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______20() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public struct _AuthenticationAsync_d__6
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			internal static global::System.Object DecorateIsolatedObject;
			private void MoveNext(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._AuthenticationAsync_d__6 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._AuthenticationAsync_d__6 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectAutomatableDecorator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckIterableArgument() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ꌀ(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._AuthenticationAsync_d__6 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ꐀ(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._AuthenticationAsync_d__6 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ꔀ(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._AuthenticationAsync_d__6 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ꘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ꠀ(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._AuthenticationAsync_d__6 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _꤀(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._AuthenticationAsync_d__6 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ꨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _HeartBeatAsync_d__5
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			private void MoveNext(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._HeartBeatAsync_d__5 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._HeartBeatAsync_d__5 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateLocalProgram() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object UpdateSorter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 鰀(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._HeartBeatAsync_d__5 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 鴀(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._HeartBeatAsync_d__5 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 鸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 鼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ꀀ(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._HeartBeatAsync_d__5 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ꄀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ꈀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _LaunchOrPlayGameAsync_d__8
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			private void MoveNext(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._LaunchOrPlayGameAsync_d__8 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._LaunchOrPlayGameAsync_d__8 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckSeparatedDecider() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectMonoList() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 錀(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._LaunchOrPlayGameAsync_d__8 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 鐀(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._LaunchOrPlayGameAsync_d__8 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 销(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._LaunchOrPlayGameAsync_d__8 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 阀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 需() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 頀(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._LaunchOrPlayGameAsync_d__8 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 餀(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._LaunchOrPlayGameAsync_d__8 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 騀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 鬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _LoginGameAsync_d__9
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			internal static global::System.Object CheckOrderedRecord;
			private void MoveNext(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._LoginGameAsync_d__9 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._LoginGameAsync_d__9 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateVisualContext() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateScopeMapper() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 谀(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._LoginGameAsync_d__9 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 贀(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._LoginGameAsync_d__9 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 踀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 輀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 退(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._LoginGameAsync_d__9 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 鄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 鈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _PeAntiCheatMessageAsync_d__10
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			internal static global::System.Object InvokeFinalizer;
			private void MoveNext(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._PeAntiCheatMessageAsync_d__10 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._PeAntiCheatMessageAsync_d__10 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectDynamicRequester() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectConcreteModule() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 萀(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._PeAntiCheatMessageAsync_d__10 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 蔀(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._PeAntiCheatMessageAsync_d__10 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 蘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 蜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 蠀(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._PeAntiCheatMessageAsync_d__10 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 褀(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._PeAntiCheatMessageAsync_d__10 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 言() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 謀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _PropertyExpandViewAsync_d__7
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			internal static global::System.Object DecorateConnectedEvent;
			private void MoveNext(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._PropertyExpandViewAsync_d__7 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._PropertyExpandViewAsync_d__7 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean WriteTransmitter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckEditableProcessor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 簀(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._PropertyExpandViewAsync_d__7 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 紀(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._PropertyExpandViewAsync_d__7 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 縀(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._PropertyExpandViewAsync_d__7 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 缀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 耀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 脀(ref global::Mass.Game.Launcher.Cpp.CppGameRpc._PropertyExpandViewAsync_d__7 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 舀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 茀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Game.Launcher.Cpp {
	public sealed class CppTask
	{
		internal static global::Mass.Game.Launcher.Cpp.CppTask CheckDetachedStrategy;
		public global::System.Threading.Tasks.Task CallPrepareGame(global::Mass.Game.Launcher.Cpp.CppGame game, global::System.Threading.CancellationToken cancellationToken) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object Call(global::System.Object id, global::Mass.Game.Launcher.Enums.CppStep step, global::System.Object caller, global::System.Func<global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task> factory, global::System.Threading.CancellationToken cancellationToken) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public CppTask() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CalcModule() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Cpp.CppTask ReflectDividedConfig() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 琀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 甀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 瘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 眀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 砀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object 礀(global::System.Object p0, global::Mass.Game.Launcher.Enums.CppStep p1, global::System.Object p2, global::System.Func<global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task> p3, global::System.Threading.CancellationToken p4) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 稀(global::System.Object p0, global::System.Threading.CancellationToken p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 笀(global::System.Object p0, global::System.Threading.CancellationToken p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public struct TaskKey
		{
			internal static global::System.Object CheckLogicalContainer;
			public global::System.String Id { get; set; }
			public global::Mass.Game.Launcher.Enums.CppStep Step { get; set; }
			public TaskKey(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0, global::System.String Id, global::Mass.Game.Launcher.Enums.CppStep Step) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public global::System.String ToString(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private global::System.Byte PrintMembers(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0, global::System.Object builder) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public static global::System.Boolean op_Inequality(global::Mass.Game.Launcher.Cpp.CppTask.TaskKey left, global::Mass.Game.Launcher.Cpp.CppTask.TaskKey right) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public static global::System.Boolean op_Equality(global::Mass.Game.Launcher.Cpp.CppTask.TaskKey left, global::Mass.Game.Launcher.Cpp.CppTask.TaskKey right) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public global::System.Int32 GetHashCode(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public global::System.Boolean Equals(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0, global::System.Object obj) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public global::System.Boolean Equals_2(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0, global::Mass.Game.Launcher.Cpp.CppTask.TaskKey other) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public void Deconstruct(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0, out global::System.String Id, out global::Mass.Game.Launcher.Enums.CppStep Step) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateSimpleConverter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateControllableVerifier() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 刀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 匀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 吀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private global::System.Byte 圀(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private global::System.Byte 堀(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void 夀(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0, global::System.IntPtr p1, global::System.IntPtr p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void 娀(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0, global::System.IntPtr p1, global::System.IntPtr p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object 嬀(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object 尀(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 崀(global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0, global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 帀(global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0, global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 开(global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0, global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 怀(global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0, global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Byte 愀(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0, global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Byte 戀(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0, global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object 攀(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object 昀(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object 最(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal object 栀(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal object 椀(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal object 樀(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal object 欀(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0, global::Mass.Game.Launcher.Enums.CppStep p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal object 氀(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0, global::Mass.Game.Launcher.Enums.CppStep p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.UInt32 洀(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.UInt32 渀(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::Mass.Game.Launcher.Enums.CppStep 漀(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 瀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 焀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Byte 爀(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Byte 猀(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public sealed class TaskEntry
		{
			public global::System.Threading.Tasks.Task Task { get; }
			public TaskEntry(global::System.Threading.Tasks.Task task, global::System.Threading.CancellationTokenSource cts) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public global::System.Threading.Tasks.Task AttachCaller(global::System.Threading.CancellationToken callerToken) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private global::System.Object WaitAsync(global::System.Threading.CancellationToken callerToken) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public void BindProgress(global::Mass.Game.Launcher.Cpp.CppGame target, global::Mass.Game.Launcher.Enums.CppStep step) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectResponsiveComparator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::Mass.Game.Launcher.Cpp.CppTask.TaskEntry HandleParser() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void 䜀(global::System.Object p0, global::Mass.Game.Launcher.Enums.CppStep p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void 䠀(global::System.Object p0, global::Mass.Game.Launcher.Enums.CppStep p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object 䤀(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object 䨀(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 䬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 䰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 䴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private global::System.Object 一(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private global::System.Object 伀(global::System.Threading.CancellationToken p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object 倀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object 儀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			public sealed class __c__DisplayClass10_0
			{
				public global::Mass.Game.Launcher.Cpp.CppTask.TaskEntry __4__this;
				public global::Mass.Game.Launcher.Cpp.CppGame source;
				public global::Mass.Game.Launcher.Enums.CppStep step;
				public global::Mass.Game.Launcher.Cpp.CppGame target;
				public __c__DisplayClass10_0() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal void _BindProgress_g__Handler_0(global::Mass.Game.Launcher.Cpp.CppGame g) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal void _BindProgress_b__1(global::System.Threading.Tasks.Task p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Boolean SelectReg() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::Mass.Game.Launcher.Cpp.CppTask.TaskEntry.__c__DisplayClass10_0 ManageExecutor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Object 㴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Object 㸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Object 㼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Byte 䀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Byte 䄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Byte 䈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal void 䌀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal void 䐀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal void 䔀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal void 䘀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			}

			public struct _WaitAsync_d__9
			{
				public global::System.Int32 __1__state;
				public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
				public global::Mass.Game.Launcher.Cpp.CppTask.TaskEntry __4__this;
				public global::System.Threading.CancellationToken callerToken;
				internal static global::System.Object ReflectConvertibleResponder;
				private void MoveNext(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskEntry._WaitAsync_d__9 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				private void SetStateMachine(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskEntry._WaitAsync_d__9 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Boolean FindInterpreter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Object CheckFlexibleEncryptor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				private void 㔀(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskEntry._WaitAsync_d__9 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				private void 㘀(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskEntry._WaitAsync_d__9 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				private void 㜀(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskEntry._WaitAsync_d__9 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Object 㠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Object 㤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				private void 㨀(ref global::Mass.Game.Launcher.Cpp.CppTask.TaskEntry._WaitAsync_d__9 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Byte 㬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
				internal static global::System.Byte 㰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			}

		}

		public sealed class __c__DisplayClass2_0
		{
			public global::System.Func<global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task> factory;
			public global::Mass.Game.Launcher.Cpp.CppTask __4__this;
			public global::Mass.Game.Launcher.Cpp.CppTask.TaskKey key;
			internal static global::Mass.Game.Launcher.Cpp.CppTask.__c__DisplayClass2_0 CheckCombinedCommand;
			public __c__DisplayClass2_0() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::Mass.Game.Launcher.Cpp.CppTask.TaskEntry _Call_b__0(global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckTransformableConsumer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::Mass.Game.Launcher.Cpp.CppTask.__c__DisplayClass2_0 ReflectSequentialStrategy() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object _(global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Object __2(global::Mass.Game.Launcher.Cpp.CppTask.TaskKey p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 㐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public sealed class __c__DisplayClass2_1
		{
			public global::System.Threading.CancellationTokenSource cts;
			public global::Mass.Game.Launcher.Cpp.CppTask.__c__DisplayClass2_0 CS___8__locals1;
			internal static global::Mass.Game.Launcher.Cpp.CppTask.__c__DisplayClass2_1 ReflectSetSorter;
			public __c__DisplayClass2_1() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void _Call_b__1(global::System.Threading.Tasks.Task t) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckEfficientConfig() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::Mass.Game.Launcher.Cpp.CppTask.__c__DisplayClass2_1 DecorateAttachedEmitter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void _(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal void Ⰰ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ⴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Game.Launcher.Bedrock {
	public abstract class BedrockAuthenticator
	{
		private static global::Serilog.ILogger Logger { get; }
		public BedrockAuthenticator(global::System.String sAuth) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected global::System.Threading.Tasks.Task<global::System.String> HandleAuthentication(global::System.String message) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		static BedrockAuthenticator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckExtendedRunner() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Bedrock.BedrockAuthenticator ReflectVisibleClient() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ______() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _______2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _______3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected global::System.Threading.Tasks.Task<global::System.String> _______7(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		protected global::System.Threading.Tasks.Task<global::System.String> _______8(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public struct _HandleAuthentication_d__5
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::System.String> __t__builder;
			public global::System.String message;
			public global::Mass.Game.Launcher.Bedrock.BedrockAuthenticator __4__this;
			internal static global::System.Object DecorateGlobalRunner;
			private void MoveNext(ref global::Mass.Game.Launcher.Bedrock.BedrockAuthenticator._HandleAuthentication_d__5 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Bedrock.BedrockAuthenticator._HandleAuthentication_d__5 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckDetachedClient() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckDetailedListener() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ἀ(ref global::Mass.Game.Launcher.Bedrock.BedrockAuthenticator._HandleAuthentication_d__5 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _(ref global::Mass.Game.Launcher.Bedrock.BedrockAuthenticator._HandleAuthentication_d__5 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __4(ref global::Mass.Game.Launcher.Bedrock.BedrockAuthenticator._HandleAuthentication_d__5 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __5(ref global::Mass.Game.Launcher.Bedrock.BedrockAuthenticator._HandleAuthentication_d__5 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Game.Launcher.Bedrock {
	public abstract class BedrockGame
	{
		private static global::Serilog.ILogger Logger { get; }
		private global::Mass.Game.Launcher.Bedrock.BedrockAuthenticator Authenticator { get; }
		private global::Mass.Game.Launcher.Paths.BedrockGamePath Path { get; }
		private global::System.Diagnostics.Process Process { get; set; }
		public global::System.Boolean HasExited { get; set; }
		public global::System.Int32 ExitCode { get; set; }
		public global::System.Int32 ProcessId { get; set; }
		public BedrockGame(global::System.String sAuthJson) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task LaunchAsync() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void OnGameExit(global::System.Object sender, global::System.Object e) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void Dispose() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		static BedrockGame() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateStatelessTracker() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Bedrock.BedrockGame EvaluateAnnotation() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____豈(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _____切(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ______() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object _______2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ______Ā() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ______Ȁ(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void _______(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ______Ѐ(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______Ԁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ________2(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ________3(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ______ࠀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ________4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ________5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ________6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ________9(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ______ༀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ______က(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ______ᄀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ______ሀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ______ጀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ________10(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______ᔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______ᘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ______ᜀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ________11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ______ᤀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ______ᨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public struct _LaunchAsync_d__26
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Game.Launcher.Bedrock.BedrockGame __4__this;
			private void MoveNext(ref global::Mass.Game.Launcher.Bedrock.BedrockGame._LaunchAsync_d__26 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Game.Launcher.Bedrock.BedrockGame._LaunchAsync_d__26 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckGeneralFinalizer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateExtendedAggregator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ༀ(ref global::Mass.Game.Launcher.Bedrock.BedrockGame._LaunchAsync_d__26 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void က(ref global::Mass.Game.Launcher.Bedrock.BedrockGame._LaunchAsync_d__26 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ᄀ(ref global::Mass.Game.Launcher.Bedrock.BedrockGame._LaunchAsync_d__26 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ሀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ጀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ᨀ(ref global::Mass.Game.Launcher.Bedrock.BedrockGame._LaunchAsync_d__26 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _(ref global::Mass.Game.Launcher.Bedrock.BedrockGame._LaunchAsync_d__26 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ᰀ(ref global::Mass.Game.Launcher.Bedrock.BedrockGame._LaunchAsync_d__26 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ᴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte Ḁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Game.Launcher.Bedrock {
	public class NeteaseData
	{
		internal static global::Mass.Game.Launcher.Bedrock.NeteaseData CheckFilteredAggregator;
		public static global::System.Byte[] Mc163Data { get; }
		public static global::Mass.Game.Launcher.Bedrock.NeteaseData Mc163 { get; }
		public static global::System.Byte[] McFeverData { get; }
		public static global::Mass.Game.Launcher.Bedrock.NeteaseData McFever { get; }
		public global::System.String JfGameId { get; set; }
		public global::System.String UniSdkJfGas3 { get; set; }
		public global::System.String UniSdkJfGas3Url { get; set; }
		public global::System.String JfLogKey { get; set; }
		public global::System.String JfLogUrl { get; set; }
		public global::System.String YyGameId { get; set; }
		public global::System.String XmGameId { get; set; }
		public global::System.String AppChannel { get; set; }
		public global::System.String CompactUrl { get; set; }
		public global::System.String AppId { get; set; }
		public global::System.String DebugLog { get; set; }
		public global::System.String MPayDebug { get; set; }
		public global::System.String NtAllYSdkPayHost { get; set; }
		public global::System.String EnableLoadingBayLogin { get; set; }
		public NeteaseData() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectAutomatedTag() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Bedrock.NeteaseData CheckPassiveDefinition() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______ᰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______ᴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______Ḁ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______ἀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ________7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ________8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ________9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ________10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ________11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________12(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________13(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______Ⰰ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______ⴀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________14(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________15(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________16(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ________17() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ________18() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________19(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______㐀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______㔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______㘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______㜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______㠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______㤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______㨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______㬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______㰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______㴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______㸀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______㼀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______䔀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______䘀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______䜀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______䠀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______䤀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______䴀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______一() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______伀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______倀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______儀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______刀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______匀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______吀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______唀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______嘀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______圀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______堀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______夀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______娀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______嬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______尀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______崀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______帀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______开(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______怀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______愀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______戀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______挀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______搀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______攀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______昀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______最() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______栀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______椀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______樀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______欀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Game.Launcher.Bedrock {
	public class WindowsHelper
	{
		public static readonly global::System.UInt32 CreateNoWindow;
		public static readonly global::System.UInt32 CreateSuspended;
		public static readonly global::System.UInt32 MemoryCommit;
		public static readonly global::System.UInt32 MemoryReserve;
		public static readonly global::System.UInt32 PageReadwrite;
		internal static global::Mass.Game.Launcher.Bedrock.WindowsHelper OpenConsumer;
		public static global::System.IntPtr OpenProcess(global::System.UInt32 processAccess, global::System.Boolean bInheritHandle, global::System.Int32 processId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.IntPtr GetProcAddress(global::System.IntPtr hModule, global::System.String lpProcName) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.IntPtr GetModuleHandle(global::System.String lpModuleName) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.IntPtr VirtualAllocEx(global::System.IntPtr hProcess, global::System.IntPtr lpAddress, global::System.UInt32 dwSize, global::System.UInt32 flAllocationType, global::System.UInt32 flProtect) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.Boolean WriteProcessMemory(global::System.IntPtr hProcess, global::System.IntPtr lpBaseAddress, global::System.Byte[] lpBuffer, global::System.UInt32 nSize, out global::System.IntPtr lpNumberOfBytesWritten) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.IntPtr CreateRemoteThread(global::System.IntPtr hProcess, global::System.IntPtr lpThreadAttributes, global::System.UInt32 dwStackSize, global::System.IntPtr lpStartAddress, global::System.IntPtr lpParameter, global::System.UInt32 dwCreationFlags, global::System.IntPtr lpThreadId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.UInt32 ResumeThread(global::System.IntPtr hThread) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.Boolean CreateProcess(global::System.String lpApplicationName, global::System.String lpCommandLine, global::System.IntPtr lpProcessAttributes, global::System.IntPtr lpThreadAttributes, global::System.Boolean bInheritHandles, global::System.UInt32 dwCreationFlags, global::System.IntPtr lpEnvironment, global::System.String lpCurrentDirectory, ref global::Mass.Game.Launcher.Bedrock.WindowsHelper.StartupInfo lpStartupInfo, out global::Mass.Game.Launcher.Bedrock.WindowsHelper.ProcessInformation lpProcessInformation) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::Mass.Game.Launcher.Bedrock.WindowsHelper.ProcessInformation CreateSuspendedProcess(global::System.String path, global::System.String commandLine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static void InjectRemoteThread(global::System.IntPtr processHandle, global::System.String dllPath) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean AdaptStrategy() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Bedrock.WindowsHelper DecorateVirtualAnalyzer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static void _(global::System.IntPtr p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static void ࠀ(global::System.IntPtr p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Bedrock.WindowsHelper.ProcessInformation __4(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Bedrock.WindowsHelper.ProcessInformation __5(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Game.Launcher.Bedrock.WindowsHelper.ProcessInformation __6(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public struct StartupInfo
		{
			public global::System.UInt32 Size;
			public global::System.String Reserved;
			public global::System.String Desktop;
			public global::System.String Title;
			public global::System.UInt32 X;
			public global::System.UInt32 Y;
			public global::System.UInt32 XSize;
			public global::System.UInt32 YSize;
			public global::System.UInt32 XCountChars;
			public global::System.UInt32 YCountChars;
			public global::System.UInt32 FillAttribute;
			public global::System.UInt32 Flags;
			public global::System.Int16 ShowWindow;
			public global::System.Int16 Reserved2;
			public global::System.IntPtr Reserved2Ptr;
			public global::System.IntPtr StdInputHandle;
			public global::System.IntPtr StdOutputHandle;
			public global::System.IntPtr StdErrorHandle;
		}

		public struct ProcessInformation
		{
			public global::System.IntPtr ProcessHandle;
			public global::System.IntPtr ThreadHandle;
			public global::System.Int32 ProcessId;
			public global::System.Int32 ThreadId;
		}

	}

}
internal sealed class _PrivateImplementationDetails__a642
{
	internal static void ThrowSwitchExpressionException(global::System.Object unmatchedValue) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static void Ā(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static void Ȁ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static void _(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
}

internal sealed class _Module__8336717d_71de_47ce_bc69_4d75223ebc5e__a642
{
	internal global::System.Int32 m_21c2d6a5a1ff48f88a97e83aaff795fb;
	internal global::System.Int32 m_e46ae95aab514972b62366d7b63485b8;
	internal global::System.Int32 m_ec8ffa3b0a764989a61229d4294de763;
	internal global::System.Int32 m_0be80c49ff864ca5b7e7a2cda9702be9;
	internal global::System.Int32 m_6ee4c0c3edb643a1a00879e1552c7a54;
	internal global::System.Int32 m_1c12a357ae964f4e960c5e6b22d1dd22;
	internal global::System.Int32 m_7b158a23c2aa4cfd8be76c2f826f6925;
	internal global::System.Int32 m_740226fe3a9741f19fb5a544832ec66b;
	internal global::System.Int32 m_7652dc77dcc24eb3bd8452a6e3daae25;
	internal global::System.Int32 m_f8f6b7457651475bb2140ad13d034362;
	internal global::System.Int32 m_d3420a8d75a94a06999bd9f97d581825;
	internal global::System.Int32 m_d1a0c45cd9a64284baf5daebf92b62ce;
	internal global::System.Int32 m_8bfbede9d7cb466eab6596d6cf928300;
	internal global::System.Int32 m_d27b3fae86e24781a0870ff7b2adf74b;
	internal global::System.Int32 m_32c8504aa7ef4296865cd847f4f3d15a;
	internal global::System.Int32 m_510e29609cc746a3ab5b48cfae510236;
	internal global::System.Int32 m_ce23eebe3a6249edb1b9dcdc5b25270b;
	internal global::System.Int32 m_19e36861110b422ca86d79ccc8a5e049;
	internal global::System.Int32 m_6df226b27371400690be0eaea4a03213;
	internal global::System.Int32 m_f8b10c0cb3e1457fa63d1cc479fd3526;
	internal global::System.Int32 m_193106210de04502aa90aeb3292fc5d6;
	internal global::System.Int32 m_5af160ec9ddf43109ceedec528380067;
	internal global::System.Int32 m_a781e564272545e8bae1d8cc82fe860c;
	internal global::System.Int32 m_bba3bc948d05406eb63333eb807a2700;
	internal global::System.Int32 m_04eb6f34762d4772a216b643651002e9;
	internal global::System.Int32 m_7dc78cb2106b42aa83679f30cfc42f00;
	internal global::System.Int32 m_754127fedb9140788e33eb05341df7b9;
	internal global::System.Int32 m_5ce31dc7dc634548bc25423132aca254;
	internal global::System.Int32 m_f044c630484b4b428dd33534833a06eb;
	internal global::System.Int32 m_48d39a6b357a478b99e41f39b364aec5;
	internal global::System.Int32 m_3270570ab81247c6b7c48885bb5e7226;
	internal global::System.Int32 m_06146694e6244192a3893d7df88b7d6e;
	internal global::System.Int32 m_02be9761d64b40cf8e0f893336bc4d58;
	internal global::System.Int32 m_c69222d0b2224f2fa06ef6920fbb3998;
	internal global::System.Int32 m_a585ae28e0f3427799090b29e03b19d4;
	internal global::System.Int32 m_ae904350709546e49c5357b0def197ce;
	internal global::System.Int32 m_575912eab8494c19965db63a6f94744f;
	internal global::System.Int32 m_09e8a373dce1480282f16f41a7d7dabb;
	internal global::System.Int32 m_a07450e83ee34d77a9d7c9fd57b4db4b;
	internal global::System.Int32 m_67fd06582483440d884ace7c8962063a;
	internal global::System.Int32 m_7a1332bf1f904d8ea30872f824145ebc;
	internal global::System.Int32 m_efd6ef523c9945c7906f1f0a6dccaab5;
	internal global::System.Int32 m_dad6d23ec81d4d7db4a72ae53e3d51e2;
	internal global::System.Int32 m_5435db2c4ecd4fa093371c792cd58559;
	internal global::System.Int32 m_e3c476aee6314b65917db92bda49aae7;
	internal static _Module__8336717d_71de_47ce_bc69_4d75223ebc5e__a642 m_d836f3f9b6194f49a23d85cb66f28ddf;
	internal global::System.Int32 m_13a321edc2cf448e9e0d85d18d9fb295;
	internal global::System.Int32 m_e9c9a9d05681470697ac06912d5f5b55;
	internal global::System.Int32 m_e07df61efa7046b698c7f6f65e6196c5;
	internal global::System.Int32 m_8d15d782e61741a1bab9ffa500515719;
	internal global::System.Int32 m_91ca4a7dc6284fa790425ff8c30d487c;
	internal global::System.Int32 m_e30f1d1ea94848f9b36aabf47cb7444e;
	internal global::System.Int32 m_a082f2d9e1f54c18abb19f7d6732fc8f;
	internal global::System.Int32 m_bf3265abdac4421692caedc038041099;
	internal global::System.Int32 m_d2752a9d184b49108fa658a76d0ffb96;
	internal global::System.Int32 m_91622539d0d944dbb6a083d3624b2d18;
	internal global::System.Int32 m_d7e8d125527d4800855fe8652a214dfe;
	internal global::System.Int32 m_cae1e15037304b228109ef88d332231c;
	internal global::System.Int32 m_3bda31e6518a4e52b09423b526d0ae7c;
	internal global::System.Int32 m_509b7c3ee759466a8ea5b6a7fd3229d6;
	internal global::System.Int32 m_4f8feb60f7074b5aab5fa6f4852aeb26;
	internal global::System.Int32 m_7f98a846e0b041088ce091bf901be523;
	internal global::System.Int32 m_b064e610f85c4780a2998d9ea2d41d4e;
	internal global::System.Int32 m_621613bfcf104737a2ec386743301f1b;
	internal global::System.Int32 m_a39aadb3c03848bf923ea1acd1d74129;
	internal global::System.Int32 m_e25a46004d7f47c1831fc53b98fe47d7;
	internal global::System.Int32 m_d57f1ce4f5a6429889cacd5e99a27484;
	internal global::System.Int32 m_ca13e411c29c4e8daf84ac945c1024ce;
	internal global::System.Int32 m_5cd53c2b204f4788bf31741ea17dbc6f;
	internal global::System.Int32 m_0f91af6d8d9a4a2191fb4b64fca39c50;
	internal global::System.Int32 m_bc4a00b2852c4ac5ad6618841a779813;
	internal global::System.Int32 m_fc1b11301d6a4d59b7e26632481da6bf;
	internal global::System.Int32 m_af98d19c9edc47ada769dc2d4f07299d;
	internal global::System.Int32 m_8ec42cf7e5e24c9c97ecace6350d415b;
	internal global::System.Int32 m_909585e5bb074f56b84395f6cc262932;
	internal global::System.Int32 m_59840eb025a147a7896ac4fbd6ad6257;
	internal global::System.Int32 m_f95ece697618495cb9f747e5dd594b96;
	internal global::System.Int32 m_34ed7e4ace5c4ee2be35bc6b24aaef54;
	internal global::System.Int32 m_93c7682517474b7e96a6fa3d7f857ec8;
	internal global::System.Int32 m_2eacc048b2d44c84a7fc9d98f379d3a0;
	internal global::System.Int32 m_26ac8216b86c49f2ad637ac8b6c955bc;
	internal global::System.Int32 m_16f769239df44eeb9ae5c0e1196477b6;
	internal global::System.Int32 m_4eb037afe2f34c6f9052fb3eeabd4b21;
	internal global::System.Int32 m_7e8937f9535a4f00b0a89710f63c9a3d;
	internal global::System.Int32 m_96b124e461ea4453a12647fcd1c8b04e;
	internal global::System.Int32 m_1aef3360c092496fb40fb0a2a21e97e2;
	internal global::System.Int32 m_1b627bb2ca68499e86a018e0f7d1950c;
	internal global::System.Int32 m_6b5cfec75b394079b1612154be69a065;
	internal global::System.Int32 m_31ca86160e7e4573b833c35697a3c172;
	internal global::System.Int32 m_90b7ab9d772e41eeb245fdb6b42bfe75;
	internal global::System.Int32 m_37cf582f2207428eb3a5e0db0b876fea;
	internal global::System.Int32 m_10f5371d66c24b429a51120cd2e465c0;
	internal global::System.Int32 m_374ed6bee2fb4e3faba6863fc6b45fe3;
	internal global::System.Int32 m_dc5eee19ff284285af2e5a6dd35a4ff0;
	internal global::System.Int32 m_de2bdc1a39db448eb95149b49c839526;
	internal global::System.Int32 m_84dd71e84a0a4e748e6af762b582de09;
	internal global::System.Int32 m_069cf53d50e9432ea68075584eaf695f;
	internal global::System.Int32 m_333714624230442e9e85dba6a6a00295;
	internal global::System.Int32 m_fdc44878a33744858fb3114459595919;
	internal global::System.Int32 m_597326fe4f664fdea957bc1ea336919e;
	internal global::System.Int32 m_8b21b1a8206d4e6bb4e4305d68f0bf4d;
	internal global::System.Int32 m_585bcc24d11143219c03d6ed5fecb684;
	internal global::System.Int32 m_e604d41070514b808d337da00a011ce7;
	internal global::System.Int32 m_78d6527c4e8a4f279dbb99d0736f371b;
	internal global::System.Int32 m_86491293bf554d7587244aa2e02c1b60;
	internal global::System.Int32 m_5744838e200c4fb09458922eaa83206c;
	internal global::System.Int32 m_caccc24e579b400cb9e1855f77ce64d1;
	internal global::System.Int32 m_33bcd49b970f4d51a6fcb84e0b151cde;
	internal global::System.Int32 m_9ead6045417241f3b8bafc464162e590;
	internal global::System.Int32 m_84065c04bb9141d2942802a1a3abc575;
	internal global::System.Int32 m_ff1a5a5a1d5545e7a70fa0e5bf95f133;
	internal global::System.Int32 m_dea8a962aeb84b04abdce6791cd46b06;
	internal global::System.Int32 m_c2d0958316b14d18a429a8c3f76a5c32;
	internal global::System.Int32 m_3fb0296cb5844ca39ace937aef056969;
	internal global::System.Int32 m_321c6a1cff9f4414af9ea63d5ccdbcaa;
	internal global::System.Int32 m_6862d284c9514424bcaf71bcb5f2b40c;
	internal global::System.Int32 m_a7588c9b89aa45bba8df6ef96ad2a6c7;
	internal global::System.Int32 m_8a3b145d022d47d7a3dcdb83e30b4ab6;
	internal global::System.Int32 m_cacec26663b246e09f2c355d69450388;
	public _Module__8336717d_71de_47ce_bc69_4d75223ebc5e__a642() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static void xd254b5595479469cb08f516c9d0e2c67() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Boolean DecorateCommonFinder() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static _Module__8336717d_71de_47ce_bc69_4d75223ebc5e__a642 DecorateAdaptableAllocator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______氀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______洀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______渀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Byte ______漀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Byte ______瀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static void ______焀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static void ______爀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
}

internal sealed class ZYXDNGuarder_a642
{
	internal static global::System.Boolean a;
	internal static global::System.String CheckString(global::System.Int32 p0, global::System.Int32 p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.String CheckString_2(global::System.Int32 p0, global::System.Int32 p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	static ZYXDNGuarder_a642() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	private static global::System.Boolean CheckRuntime(global::System.Int32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	private static global::System.Boolean CheckRuntime64(global::System.Int32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Boolean RunHVM() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Boolean RunHVM_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static void Startup() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static void RunHVM_3(global::System.IntPtr p0, global::System.IntPtr p1, global::System.IntPtr p2, global::System.Int32 p3) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static void dvm() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object Ѐ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object Ԁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ᔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ᘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ᜀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ᤀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 唀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 嘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 挀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 搀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 쀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 섀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 숀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 쌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 쐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 씀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 였() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _帀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __樀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __欀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __氀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __ꈀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __가() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __관() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __글() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __꼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __뀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __뤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __먀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __묀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __밀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __봀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __윀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __저() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __준() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __쨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __쬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __퐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __픀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____耀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____褀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____阀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____需() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____頀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____餀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____ꐀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____뼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____저() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____준() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____Ȁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____Ѐ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____Ԁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____ᨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____㤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____㨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____㬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____䐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____䔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____䘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____䜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____伀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____倀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____儀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____刀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____嬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____尀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____崀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____帀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____开() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____怀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____愀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____戀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____挀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____搀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____攀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____昀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____渀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____漀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____瀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____笀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____頀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____餀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____ꈀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____퀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ________2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ________3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ________4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ________5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ________6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ________7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ________8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ________9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ________10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ________11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______㰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______怀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______昀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______最() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______栀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______焀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______爀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______猀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______琀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______甀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______瘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______眀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______砀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______笀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______鐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ________12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ________13() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ________() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______ᰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______ᴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______㸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______䠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______䤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______缀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______耀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______脀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______鬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______鰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______鴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______鸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______였() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______찀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______촀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object Ȁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object Ѐ_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object Ԁ_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __13() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __14() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ᤀ_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ᨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __15() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ᰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ᴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __16() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __17() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __18() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __19() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 匀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 嘀_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 圀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 堀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 夀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 娀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 嬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 尀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 崀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 帀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 开() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 怀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 愀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 戀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 挀_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 攀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 樀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 欀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 氀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 洀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 渀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 漀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 瀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 焀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 爀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 猀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 琀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 甀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 瘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 眀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 砀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 礀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 稀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 笀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 簀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 紀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 縀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 缀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 耀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 脀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 舀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 茀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 萀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 蔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 蘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 蜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 蠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 褀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 言() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 謀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 谀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 贀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 踀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 輀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 退() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 鄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 鈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 销() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 阀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 騀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 鬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 鰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ꀀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ꄀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ꈀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ꌀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ꐀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ꔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ꘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __20() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ꠀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _꤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ꨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __21() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 가() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 관() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 글() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 꼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 뀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 넀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 눀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 대() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 됀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 딀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 똀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 뜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 렀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 뤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 먀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 묀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 밀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 봀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 븀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 뼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 쀀_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 섀_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 숀_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 쌀_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 쐀_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 씀_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 였_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 윀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 저() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 준() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 쨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 쬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 찀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 촀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 츀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 툀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 팀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 퐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 휀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __22() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __23() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __24() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __25() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __26() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __27() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __28() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __29() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __30() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __31() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __32() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __33() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __34() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __35() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __36() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __37() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 豈() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 切() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ﬀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _ሀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _ጀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _㐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _㔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _㘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _㜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _㠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _㤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _㨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _㬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _㰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _䄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _䈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _䌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _圀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _开() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _怀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _愀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _樀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _猀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _琀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _甀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _縀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _退() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _꤀_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _뀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _숀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _쌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _쐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _씀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _였() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _윀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _저() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _준() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _쨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __攀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __昀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __最() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __洀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __琀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __甀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __瘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __眀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __砀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __礀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __縀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __缀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __耀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __脀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __舀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __茀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __萀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __蔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __蘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __鈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __錀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __鐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __销() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __阀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __需() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __頀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __餀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __騀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __鬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __鰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __鴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __鸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __鼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __ꀀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __ꄀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __ꈀ_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __ꌀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __ꐀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __ꔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __ꘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __렀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __뤀_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __쀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __섀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __숀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __준_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __혀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____13() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____14() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____15() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____16() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____17() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____18() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____19() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____20() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____21() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____22() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____23() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____24() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __豈() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __切() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __ﬀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __ﰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __ﴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____25() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____26() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___Ā() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___Ȁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___Ѐ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___Ԁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___ࠀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___ᔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___ᘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___ᜀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___ᤀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___ᨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___ᰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___ᴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___Ḁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___ἀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____13() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____14() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____15() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____16() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____17() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____18() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____19() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____20() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___ⴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____21() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____22() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___㨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___䘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___䜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___䠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___䤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___䨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___䬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___䰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___䴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___一() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___伀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___倀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___儀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___刀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___匀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___吀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___唀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___嬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___尀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___崀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___帀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___开() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___怀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___愀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___戀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___挀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___搀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___攀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___昀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___最() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___栀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___椀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___樀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___欀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___缀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___销() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___阀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___눀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___대() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___됀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___딀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___똀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___뜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___렀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___뤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___먀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___묀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___밀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___봀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___븀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___뼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___쀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___쬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___찀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____23() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____24() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____25() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____26() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____27() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____28() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____29() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____30() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____31() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___豈() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___ﴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____Ā() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____Ԁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____Ḁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____ἀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____一() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____漀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____瀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____眀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____砀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____礀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____言() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____踀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____退() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____錀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____ꘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____ꨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____가() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____관() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____글() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____뀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____쀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____쐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____츀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____혀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____휀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______13() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______14() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______15() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______16() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______17() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______18() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______19() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____切() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____ﬀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____ﰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____ﴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____Ā() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____Ȁ_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____Ѐ_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______13() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______14() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______15() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______16() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______17() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______18() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______19() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____ᤀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____ᨀ_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______20() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____ᰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____ᴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____Ḁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____ἀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______21() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______22() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______23() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______24() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______25() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______26() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______27() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______28() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______29() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______30() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______31() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______32() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______33() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____㐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____㔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____㠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____㤀_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____䄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____唀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____搀_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____攀_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____昀_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____爀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____笀_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____簀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____鄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____팀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______34() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____ﬀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____ﰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____ﴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______䀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______䄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______䈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______䌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______䐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______䨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______䬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______䰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	public sealed class d
	{
		public d(global::System.Object p0, global::System.IntPtr p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.IntPtr Invoke(global::System.Object p0, global::System.Int32 p1, global::System.Int32 p2, global::System.IntPtr p3, global::System.Int32 p4) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}

