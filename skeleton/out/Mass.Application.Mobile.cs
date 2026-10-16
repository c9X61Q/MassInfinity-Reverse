// 自动生成的可编译骨架 —— 声明来自元数据；方法体一律为显式占位（未还原）。
// 生成器：tools/MassSkeleton（dnlib 读元数据），不依赖反编译文本。
#nullable disable
using System;

namespace Mass.Application.Mobile {
	public abstract class MobileSession
	{
		public global::Mass.Domain.Mobile.Entities.Game.EntityPatchInfo PatchInfo { get; set; }
		public MobileSession(global::System.String userId, global::System.String token, global::System.Boolean startHeartbeat) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void Dispose() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object EntityRequestAsync(global::System.Object url, global::System.Object body, global::System.Byte checkCode) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<object> EntityRequestAsync_2<T0>(global::System.String url, global::System.Object body, global::System.Boolean checkCode) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<object[]> EntitiesRequestAsync<T0>(global::System.String url, global::System.Object body, global::System.Boolean checkCode) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<object> RequestAsync<T0>(global::System.String url, global::System.Object body, global::System.Boolean checkCode) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<object> RequestAsync_2<T0>(global::System.String url, global::System.String body, global::System.Boolean checkCode) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task InterLoginStartAsync() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task InterStartAsync(global::System.String gameId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task<global::Mass.Domain.Desktop.Entities.Skin.EntitySkinSetting[]> SetSkinAsync(global::System.String itemId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task<global::Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem[]> GetNetGamesAsync() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task<global::Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> SearchRentalGamesAsync(global::System.String keyword, global::System.Int32 offset) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task<global::Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> GetRentalGamesAsync(global::System.Int32 offset) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task<global::Mass.Domain.Desktop.Entities.RentalGame.EntityRentalGameAddress> GetRentalGameAddressAsync(global::System.String gameId, global::System.String password) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::Mass.Application.Desktop.Models.SessionContext<global::Mass.Application.Mobile.MobileSession, global::Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem> GetNetGame(global::System.String gameId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task<global::Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails> GetNetGameDetailsAsync(global::System.String gameId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task<global::Mass.Domain.Desktop.Entities.NetGame.EntityNetGameAddress> GetNetGameAddressAsync(global::System.String gameId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task<global::Mass.Domain.Mobile.Entities.Game.EntityGameResourceInfo[]> GetGameResourceInfos(global::System.String gameId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateEfficientStream() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Application.Mobile.MobileSession ReflectAttachedEncryptor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Threading.Tasks.Task<global::Mass.Domain.Desktop.Entities.Skin.EntitySkinSetting[]> Ȁ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Threading.Tasks.Task<global::Mass.Domain.Desktop.Entities.Skin.EntitySkinSetting[]> _(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Threading.Tasks.Task<global::Mass.Domain.Desktop.Entities.Skin.EntitySkinSetting[]> Ѐ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object Ԁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __3(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ࠀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __4(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Threading.Tasks.Task<global::Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> __6(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Threading.Tasks.Task<global::Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> __7(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Threading.Tasks.Task<global::Mass.Domain.Desktop.Entities.RentalGame.EntityRentalGameAddress> __8(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Threading.Tasks.Task<global::Mass.Domain.Desktop.Entities.RentalGame.EntityRentalGameAddress> __9(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Threading.Tasks.Task<global::Mass.Domain.Desktop.Entities.NetGame.EntityNetGameAddress> ༀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Threading.Tasks.Task<global::Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> က(global::System.Object p0, global::System.UInt32 p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Threading.Tasks.Task<global::Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> ᄀ(global::System.Object p0, global::System.UInt32 p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ሀ(global::System.Object p0, global::System.Object p1, global::System.Byte p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object ጀ(global::System.Object p0, global::System.Object p1, global::System.Byte p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Object __10(global::System.Object p0, global::System.Object p1, global::System.Byte p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ᔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ᘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ᜀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Threading.Tasks.Task<global::Mass.Domain.Mobile.Entities.Game.EntityGameResourceInfo[]> __11(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ᤀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Threading.Tasks.Task<global::Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails> ᨀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Threading.Tasks.Task<global::Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails> __12(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Threading.Tasks.Task<global::Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails> ᰀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object ᴀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object Ḁ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal object ἀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Application.Desktop.Models.SessionContext<global::Mass.Application.Mobile.MobileSession, global::Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem> __13(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Application.Desktop.Models.SessionContext<global::Mass.Application.Mobile.MobileSession, global::Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem> __14(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Threading.Tasks.Task<global::Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem[]> __15() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public sealed class __c
		{
			public static readonly global::Mass.Application.Mobile.MobileSession.__c __9;
			public static global::System.Func<global::Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem, global::System.Int64> __9__15_0;
			static __c() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Int64 _GetNetGamesAsync_b__15_0(global::Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem x) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public sealed class __c__DisplayClass19_0
		{
			public global::System.String gameId;
			internal static global::Mass.Application.Mobile.MobileSession.__c__DisplayClass19_0 CheckRemoteExplorer;
			public __c__DisplayClass19_0() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Boolean _GetNetGame_b__0(global::Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem n) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateActiveAuthenticator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::Mass.Application.Mobile.MobileSession.__c__DisplayClass19_0 CountSharer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Byte __7(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Byte Ⰰ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Byte ⴀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _EntitiesRequestAsync_d__9<T0>
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T0[]> __t__builder;
			public global::Mass.Application.Mobile.MobileSession __4__this;
			public global::System.String url;
			public global::System.Object body;
			public global::System.Boolean checkCode;
			private void MoveNext(ref global::Mass.Application.Mobile.MobileSession._EntitiesRequestAsync_d__9<T0> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Application.Mobile.MobileSession._EntitiesRequestAsync_d__9<T0> p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean PeekTransaction() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateModularConfig() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _EntityRequestAsync_d__7
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Application.Mobile.MobileSession __4__this;
			public global::System.String url;
			public global::System.Object body;
			public global::System.Boolean checkCode;
			private void MoveNext(ref global::Mass.Application.Mobile.MobileSession._EntityRequestAsync_d__7 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Application.Mobile.MobileSession._EntityRequestAsync_d__7 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckAccessibleRunner() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DisableAuditor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 㐀(ref global::Mass.Application.Mobile.MobileSession._EntityRequestAsync_d__7 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 㔀(ref global::Mass.Application.Mobile.MobileSession._EntityRequestAsync_d__7 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 㘀(ref global::Mass.Application.Mobile.MobileSession._EntityRequestAsync_d__7 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 㜀(ref global::Mass.Application.Mobile.MobileSession._EntityRequestAsync_d__7 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _EntityRequestAsync_d__8<T0>
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T0> __t__builder;
			public global::Mass.Application.Mobile.MobileSession __4__this;
			public global::System.String url;
			public global::System.Object body;
			public global::System.Boolean checkCode;
			private void MoveNext(ref global::Mass.Application.Mobile.MobileSession._EntityRequestAsync_d__8<T0> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Application.Mobile.MobileSession._EntityRequestAsync_d__8<T0> p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean LoadList() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object JoinRecord() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _GetGameResourceInfos_d__22
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Mass.Domain.Mobile.Entities.Game.EntityGameResourceInfo[]> __t__builder;
			public global::Mass.Application.Mobile.MobileSession __4__this;
			public global::System.String gameId;
			internal static global::System.Object DecorateLocalAggregator;
			private void MoveNext(ref global::Mass.Application.Mobile.MobileSession._GetGameResourceInfos_d__22 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Application.Mobile.MobileSession._GetGameResourceInfos_d__22 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateSymbolicTag() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckConfigurableDefinition() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 㠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 㤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 㨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 㬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 㰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 㴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 㼀(ref global::Mass.Application.Mobile.MobileSession._GetGameResourceInfos_d__22 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 䀀(ref global::Mass.Application.Mobile.MobileSession._GetGameResourceInfos_d__22 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 䄀(ref global::Mass.Application.Mobile.MobileSession._GetGameResourceInfos_d__22 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _GetNetGameAddressAsync_d__21
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Mass.Domain.Desktop.Entities.NetGame.EntityNetGameAddress> __t__builder;
			public global::Mass.Application.Mobile.MobileSession __4__this;
			public global::System.String gameId;
			internal static global::System.Object GuideRequester;
			private void MoveNext(ref global::Mass.Application.Mobile.MobileSession._GetNetGameAddressAsync_d__21 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Application.Mobile.MobileSession._GetNetGameAddressAsync_d__21 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckMonoRecommender() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object PatchEvent() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 䈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 䌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 䐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 䔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 䘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 䜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 䤀(ref global::Mass.Application.Mobile.MobileSession._GetNetGameAddressAsync_d__21 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 䨀(ref global::Mass.Application.Mobile.MobileSession._GetNetGameAddressAsync_d__21 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 䬀(ref global::Mass.Application.Mobile.MobileSession._GetNetGameAddressAsync_d__21 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 䰀(ref global::Mass.Application.Mobile.MobileSession._GetNetGameAddressAsync_d__21 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 䴀(ref global::Mass.Application.Mobile.MobileSession._GetNetGameAddressAsync_d__21 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _GetNetGameDetailsAsync_d__20
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Mass.Domain.Mobile.Entities.NetGame.EntityNetGameDetails> __t__builder;
			public global::Mass.Application.Mobile.MobileSession __4__this;
			public global::System.String gameId;
			private void MoveNext(ref global::Mass.Application.Mobile.MobileSession._GetNetGameDetailsAsync_d__20 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Application.Mobile.MobileSession._GetNetGameDetailsAsync_d__20 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateScopeNotifier() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectStaticDispatcher() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 一() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 伀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 倀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 儀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 匀(ref global::Mass.Application.Mobile.MobileSession._GetNetGameDetailsAsync_d__20 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 吀(ref global::Mass.Application.Mobile.MobileSession._GetNetGameDetailsAsync_d__20 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _GetNetGamesAsync_d__15
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Mass.Domain.Mobile.Entities.NetGame.EntityNetGameItem[]> __t__builder;
			public global::Mass.Application.Mobile.MobileSession __4__this;
			internal static global::System.Object DecorateDynamicSingleton;
			private void MoveNext(ref global::Mass.Application.Mobile.MobileSession._GetNetGamesAsync_d__15 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Application.Mobile.MobileSession._GetNetGamesAsync_d__15 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectConcreteParser() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateConnectedState() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 唀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 嘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 圀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 堀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 夀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 娀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 尀(ref global::Mass.Application.Mobile.MobileSession._GetNetGamesAsync_d__15 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 崀(ref global::Mass.Application.Mobile.MobileSession._GetNetGamesAsync_d__15 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 帀(ref global::Mass.Application.Mobile.MobileSession._GetNetGamesAsync_d__15 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 开(ref global::Mass.Application.Mobile.MobileSession._GetNetGamesAsync_d__15 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _GetRentalGameAddressAsync_d__18
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Mass.Domain.Desktop.Entities.RentalGame.EntityRentalGameAddress> __t__builder;
			public global::Mass.Application.Mobile.MobileSession __4__this;
			public global::System.String gameId;
			public global::System.String password;
			internal static global::System.Object StoreComparator;
			private void MoveNext(ref global::Mass.Application.Mobile.MobileSession._GetRentalGameAddressAsync_d__18 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Application.Mobile.MobileSession._GetRentalGameAddressAsync_d__18 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean VerifyBridge() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckLogicalReporter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 怀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 愀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 戀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 挀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 搀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 攀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 最(ref global::Mass.Application.Mobile.MobileSession._GetRentalGameAddressAsync_d__18 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 栀(ref global::Mass.Application.Mobile.MobileSession._GetRentalGameAddressAsync_d__18 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 椀(ref global::Mass.Application.Mobile.MobileSession._GetRentalGameAddressAsync_d__18 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 樀(ref global::Mass.Application.Mobile.MobileSession._GetRentalGameAddressAsync_d__18 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 欀(ref global::Mass.Application.Mobile.MobileSession._GetRentalGameAddressAsync_d__18 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _GetRentalGamesAsync_d__17
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> __t__builder;
			public global::Mass.Application.Mobile.MobileSession __4__this;
			public global::System.Int32 offset;
			internal static global::System.Object EncodeConsumer;
			private void MoveNext(ref global::Mass.Application.Mobile.MobileSession._GetRentalGamesAsync_d__17 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Application.Mobile.MobileSession._GetRentalGamesAsync_d__17 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateControllableEnumerator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object TrackSorter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 氀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 洀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 渀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 漀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 瀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 焀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 猀(ref global::Mass.Application.Mobile.MobileSession._GetRentalGamesAsync_d__17 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 琀(ref global::Mass.Application.Mobile.MobileSession._GetRentalGamesAsync_d__17 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 甀(ref global::Mass.Application.Mobile.MobileSession._GetRentalGamesAsync_d__17 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 瘀(ref global::Mass.Application.Mobile.MobileSession._GetRentalGamesAsync_d__17 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _RequestAsync_d__10<T0>
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T0> __t__builder;
			public global::Mass.Application.Mobile.MobileSession __4__this;
			public global::System.String url;
			public global::System.Object body;
			public global::System.Boolean checkCode;
			private void MoveNext(ref global::Mass.Application.Mobile.MobileSession._RequestAsync_d__10<T0> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Application.Mobile.MobileSession._RequestAsync_d__10<T0> p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateSortedProfiler() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateCombinedFactory() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _RequestAsync_d__11<T0>
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T0> __t__builder;
			public global::System.String url;
			public global::System.String body;
			public global::Mass.Application.Mobile.MobileSession __4__this;
			public global::System.Boolean checkCode;
			private void MoveNext(ref global::Mass.Application.Mobile.MobileSession._RequestAsync_d__11<T0> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Application.Mobile.MobileSession._RequestAsync_d__11<T0> p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateSequentialResponder() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateSetStream() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _SearchRentalGamesAsync_d__16
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Mass.Domain.Mobile.Entities.RentalGame.EntityRentalGameItem[]> __t__builder;
			public global::Mass.Application.Mobile.MobileSession __4__this;
			public global::System.Int32 offset;
			public global::System.String keyword;
			private void MoveNext(ref global::Mass.Application.Mobile.MobileSession._SearchRentalGamesAsync_d__16 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Application.Mobile.MobileSession._SearchRentalGamesAsync_d__16 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CloseAggregator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CreateTag() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 簀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 紀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 縀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 缀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 耀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 舀(ref global::Mass.Application.Mobile.MobileSession._SearchRentalGamesAsync_d__16 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 茀(ref global::Mass.Application.Mobile.MobileSession._SearchRentalGamesAsync_d__16 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 萀(ref global::Mass.Application.Mobile.MobileSession._SearchRentalGamesAsync_d__16 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Application.Mobile {
	public class NeteaseMobile
	{
		public global::Mass.Domain.Mobile.Entities.EntityLinkServer[] LinkServers;
		public global::System.String NeteaseVersion;
		internal readonly global::RestSharp.RestClient Client;
		private static global::Serilog.ILogger Logger { get; }
		public static global::Mass.Application.Mobile.NeteaseMobile Instance { get; }
		public global::System.Boolean HasSession(global::System.String userId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::Mass.Application.Mobile.MobileSession GetSession(global::System.String userId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::Mass.Application.Mobile.MobileSession TryGetSession(global::System.String userId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task InitAsync() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task<global::Mass.Application.Mobile.MobileSession> LoginAsync(global::System.String cookies) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<global::Mass.Application.Mobile.MobileSession> LoginAsync_2(global::System.Object dto) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<global::Mass.Domain.Desktop.Entities.EntityAuthenticationOtp> PeAuthenticationAsync(global::System.Object dto) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task<global::System.String> AuthenticationAsync(global::System.String userId, global::System.String token, global::Mass.Domain.Mobile.Entities.EntityAuthenticationDto dto) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task<global::Mass.Domain.Mobile.Entities.EntityAuthentication> AuthenticationV2Async(global::System.String userId, global::System.String token, global::Mass.Domain.Mobile.Entities.EntityAuthenticationDto dto) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task<global::Mass.Application.Models.Jwt_a706<global::Mass.Domain.Mobile.Entities.Game.EntityEncryptionKeyHeader, global::Mass.Domain.Mobile.Entities.Game.EntityEncryptionKeyPayload>> GetEncryptionKeyAsync(global::System.String userId, global::System.String token, global::Mass.Domain.Mobile.Entities.Game.EntityGetEncryptionKeyDto dto) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void Dispose() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public NeteaseMobile() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckDetachedFinder() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Application.Mobile.NeteaseMobile ReceiveAttribute() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Threading.Tasks.Task<global::Mass.Application.Mobile.MobileSession> 蔀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Threading.Tasks.Task<global::Mass.Application.Mobile.MobileSession> 蘀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 蠀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 褀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Threading.Tasks.Task<global::Mass.Application.Models.Jwt_a706<global::Mass.Domain.Mobile.Entities.Game.EntityEncryptionKeyHeader, global::Mass.Domain.Mobile.Entities.Game.EntityEncryptionKeyPayload>> 言(global::System.Object p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte 踀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte 輀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 退() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 鄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Threading.Tasks.Task<global::System.String> 鈀(global::System.Object p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Threading.Tasks.Task<global::System.String> 錀(global::System.Object p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 鐀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 销() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 阀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 需() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 頀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 餀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 鬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 鰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<global::Mass.Domain.Desktop.Entities.EntityAuthenticationOtp> 鴀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<global::Mass.Domain.Desktop.Entities.EntityAuthenticationOtp> 鸀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<global::Mass.Domain.Desktop.Entities.EntityAuthenticationOtp> 鼀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ꀀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<global::Mass.Application.Mobile.MobileSession> ꄀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<global::Mass.Application.Mobile.MobileSession> ꈀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Threading.Tasks.Task<global::Mass.Domain.Mobile.Entities.EntityAuthentication> ꌀ(global::System.Object p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Threading.Tasks.Task<global::Mass.Domain.Mobile.Entities.EntityAuthentication> ꐀ(global::System.Object p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public struct _AuthenticationAsync_d__16
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::System.String> __t__builder;
			public global::Mass.Domain.Mobile.Entities.EntityAuthenticationDto dto;
			public global::Mass.Application.Mobile.NeteaseMobile __4__this;
			public global::System.String userId;
			public global::System.String token;
			private void MoveNext(ref global::Mass.Application.Mobile.NeteaseMobile._AuthenticationAsync_d__16 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Application.Mobile.NeteaseMobile._AuthenticationAsync_d__16 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckDetailedQueue() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateDividedSender() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ꔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ꘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte ꠀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _꤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 관(ref global::Mass.Application.Mobile.NeteaseMobile._AuthenticationAsync_d__16 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 글(ref global::Mass.Application.Mobile.NeteaseMobile._AuthenticationAsync_d__16 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 꼀(ref global::Mass.Application.Mobile.NeteaseMobile._AuthenticationAsync_d__16 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 뀀(ref global::Mass.Application.Mobile.NeteaseMobile._AuthenticationAsync_d__16 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 넀(ref global::Mass.Application.Mobile.NeteaseMobile._AuthenticationAsync_d__16 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _AuthenticationV2Async_d__17
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Mass.Domain.Mobile.Entities.EntityAuthentication> __t__builder;
			public global::Mass.Domain.Mobile.Entities.EntityAuthenticationDto dto;
			public global::Mass.Application.Mobile.NeteaseMobile __4__this;
			public global::System.String userId;
			public global::System.String token;
			internal static global::System.Object DirectAnalyzer;
			private void MoveNext(ref global::Mass.Application.Mobile.NeteaseMobile._AuthenticationV2Async_d__17 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Application.Mobile.NeteaseMobile._AuthenticationV2Async_d__17 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectExtendedProvider() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateVisibleCalc() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 눀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 대() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 됀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 딀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 똀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 뜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 뤀(ref global::Mass.Application.Mobile.NeteaseMobile._AuthenticationV2Async_d__17 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 먀(ref global::Mass.Application.Mobile.NeteaseMobile._AuthenticationV2Async_d__17 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 묀(ref global::Mass.Application.Mobile.NeteaseMobile._AuthenticationV2Async_d__17 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _GetEncryptionKeyAsync_d__18
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Mass.Application.Models.Jwt_a706<global::Mass.Domain.Mobile.Entities.Game.EntityEncryptionKeyHeader, global::Mass.Domain.Mobile.Entities.Game.EntityEncryptionKeyPayload>> __t__builder;
			public global::Mass.Domain.Mobile.Entities.Game.EntityGetEncryptionKeyDto dto;
			public global::Mass.Application.Mobile.NeteaseMobile __4__this;
			public global::System.String userId;
			public global::System.String token;
			internal static global::System.Object ReflectCentralTree;
			private void MoveNext(ref global::Mass.Application.Mobile.NeteaseMobile._GetEncryptionKeyAsync_d__18 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Application.Mobile.NeteaseMobile._GetEncryptionKeyAsync_d__18 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckStatelessFilter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckScheduledStack() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 밀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 봀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 븀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 뼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 쀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 섀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 쐀(ref global::Mass.Application.Mobile.NeteaseMobile._GetEncryptionKeyAsync_d__18 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 씀(ref global::Mass.Application.Mobile.NeteaseMobile._GetEncryptionKeyAsync_d__18 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 였(ref global::Mass.Application.Mobile.NeteaseMobile._GetEncryptionKeyAsync_d__18 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 윀(ref global::Mass.Application.Mobile.NeteaseMobile._GetEncryptionKeyAsync_d__18 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 저(ref global::Mass.Application.Mobile.NeteaseMobile._GetEncryptionKeyAsync_d__18 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _InitAsync_d__12
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Application.Mobile.NeteaseMobile __4__this;
			private void MoveNext(ref global::Mass.Application.Mobile.NeteaseMobile._InitAsync_d__12 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Application.Mobile.NeteaseMobile._InitAsync_d__12 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckAutomatedLogger() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object UpdateStruct() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 준() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 쨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 쬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 찀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 촀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 퀀(ref global::Mass.Application.Mobile.NeteaseMobile._InitAsync_d__12 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 턀(ref global::Mass.Application.Mobile.NeteaseMobile._InitAsync_d__12 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 툀(ref global::Mass.Application.Mobile.NeteaseMobile._InitAsync_d__12 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void 팀(ref global::Mass.Application.Mobile.NeteaseMobile._InitAsync_d__12 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _LoginAsync_d__13
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Mass.Application.Mobile.MobileSession> __t__builder;
			public global::System.String cookies;
			public global::Mass.Application.Mobile.NeteaseMobile __4__this;
			internal static global::System.Object OpenReporter;
			private void MoveNext(ref global::Mass.Application.Mobile.NeteaseMobile._LoginAsync_d__13 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Application.Mobile.NeteaseMobile._LoginAsync_d__13 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckOperationalAuthorizer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object TestEnumerator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 퐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 픀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object 혀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte 휀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __2(ref global::Mass.Application.Mobile.NeteaseMobile._LoginAsync_d__13 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __3(ref global::Mass.Application.Mobile.NeteaseMobile._LoginAsync_d__13 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _LoginAsync_d__14
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Mass.Application.Mobile.MobileSession> __t__builder;
			public global::Mass.Domain.Mobile.Entities.EntityLoginOtpDto dto;
			public global::Mass.Application.Mobile.NeteaseMobile __4__this;
			private void MoveNext(ref global::Mass.Application.Mobile.NeteaseMobile._LoginAsync_d__14 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Application.Mobile.NeteaseMobile._LoginAsync_d__14 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateInterruptibleExecutor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckCustomizablePredictor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __7(ref global::Mass.Application.Mobile.NeteaseMobile._LoginAsync_d__14 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __8(ref global::Mass.Application.Mobile.NeteaseMobile._LoginAsync_d__14 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __9(ref global::Mass.Application.Mobile.NeteaseMobile._LoginAsync_d__14 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __10(ref global::Mass.Application.Mobile.NeteaseMobile._LoginAsync_d__14 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __11(ref global::Mass.Application.Mobile.NeteaseMobile._LoginAsync_d__14 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _PeAuthenticationAsync_d__15
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Mass.Domain.Desktop.Entities.EntityAuthenticationOtp> __t__builder;
			public global::Mass.Application.Mobile.NeteaseMobile __4__this;
			public global::Mass.Domain.Mobile.Entities.EntityPeAuthenticationDto dto;
			internal static global::System.Object InvokeFactory;
			private void MoveNext(ref global::Mass.Application.Mobile.NeteaseMobile._PeAuthenticationAsync_d__15 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Application.Mobile.NeteaseMobile._PeAuthenticationAsync_d__15 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ResetCompressor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectHiddenFunction() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte __5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __6(ref global::Mass.Application.Mobile.NeteaseMobile._PeAuthenticationAsync_d__15 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __7(ref global::Mass.Application.Mobile.NeteaseMobile._PeAuthenticationAsync_d__15 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __8(ref global::Mass.Application.Mobile.NeteaseMobile._PeAuthenticationAsync_d__15 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void __9(ref global::Mass.Application.Mobile.NeteaseMobile._PeAuthenticationAsync_d__15 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Application.Mobile.Helpers {
	public class HttpHelper
	{
		public static global::System.Byte[] Encrypt(global::System.String data) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.Byte[] Encrypt_2(global::System.Byte[] bodyIn) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.String DecryptLogin(global::System.Byte[] body) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.String DecryptAuthentication(global::System.Byte[] encryptedData) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.Byte[] Decrypt(global::System.Byte[] body) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ExtractJson(global::System.Object data) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object PickKey(global::System.Byte query) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object RandomBytes(global::System.UInt32 count) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		static HttpHelper() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CallMatcher() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Application.Mobile.Helpers.HttpHelper ReflectExtendedWorker() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __4(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __5(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __6(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 豈(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ﬀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ﰀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object __(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _ༀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _က(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _ᄀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _ሀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _ጀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___2(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _ᔀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _ᘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _ᜀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _ᤀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _ᨀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public sealed class __c
		{
			public static readonly global::Mass.Application.Mobile.Helpers.HttpHelper.__c __9;
			static __c() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal global::System.Byte[] __cctor_b__9_0(global::System.String k) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Application.Mobile.Helpers {
	public class ModHelper
	{
		private static global::System.Object GetDecryptionKey(global::System.Object deviceId, global::System.Object key, global::System.Object userId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object DecryptModJson(global::System.Object input, global::System.Object key, global::System.Object uuid) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::System.Threading.Tasks.Task DecryptModDirectory(global::Mass.Application.Mobile.MobileSession session, global::System.String itemId, global::System.String path) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object DecryptModDirectory_2(global::System.Object path, global::System.Object key, global::System.Object uuid) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean SendPredictor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Application.Mobile.Helpers.ModHelper CheckStatelessTree() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _ᰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _ᴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _Ḁ(global::System.Object p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _ἀ(global::System.Object p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ___2(global::System.Object p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ___3(global::System.Object p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ___4(global::System.Object p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ___7(global::System.Object p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ___8(global::System.Object p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object ___9(global::System.Object p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public struct _DecryptModDirectory_d__2
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::Mass.Application.Mobile.MobileSession session;
			public global::System.String itemId;
			public global::System.String path;
			internal static global::System.Object PlanFinder;
			private void MoveNext(ref global::Mass.Application.Mobile.Helpers.ModHelper._DecryptModDirectory_d__2 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Application.Mobile.Helpers.ModHelper._DecryptModDirectory_d__2 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean DecorateAdvancedExtractor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectConvertibleIterator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ___2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ___3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _Ⰰ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _ⴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ___4(ref global::Mass.Application.Mobile.Helpers.ModHelper._DecryptModDirectory_d__2 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ___5(ref global::Mass.Application.Mobile.Helpers.ModHelper._DecryptModDirectory_d__2 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ___6(ref global::Mass.Application.Mobile.Helpers.ModHelper._DecryptModDirectory_d__2 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void ___7(ref global::Mass.Application.Mobile.Helpers.ModHelper._DecryptModDirectory_d__2 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _DecryptModDirectory_d__3
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder;
			public global::System.String path;
			public global::System.Byte[] key;
			public global::System.String uuid;
			internal static global::System.Object DecorateMixedFormatter;
			private void MoveNext(ref global::Mass.Application.Mobile.Helpers.ModHelper._DecryptModDirectory_d__3 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Application.Mobile.Helpers.ModHelper._DecryptModDirectory_d__3 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CheckFlexibleTokenizer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object DecorateSegmentedValue() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object __() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _㐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _㔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _㘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _㜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _㬀(ref global::Mass.Application.Mobile.Helpers.ModHelper._DecryptModDirectory_d__3 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _㰀(ref global::Mass.Application.Mobile.Helpers.ModHelper._DecryptModDirectory_d__3 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _㴀(ref global::Mass.Application.Mobile.Helpers.ModHelper._DecryptModDirectory_d__3 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _㸀(ref global::Mass.Application.Mobile.Helpers.ModHelper._DecryptModDirectory_d__3 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _㼀(ref global::Mass.Application.Mobile.Helpers.ModHelper._DecryptModDirectory_d__3 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Application.Mobile.Extensions {
	public class RestClientExtensions
	{
		public static global::System.Threading.Tasks.Task<global::RestSharp.RestResponse<object>> ExecuteMobileAsync<T0>(global::RestSharp.RestClient client, global::RestSharp.RestRequest request) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public struct _ExecuteMobileAsync_d__0<T0>
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::RestSharp.RestResponse<T0>> __t__builder;
			public global::RestSharp.RestClient client;
			public global::RestSharp.RestRequest request;
			private void MoveNext(ref global::Mass.Application.Mobile.Extensions.RestClientExtensions._ExecuteMobileAsync_d__0<T0> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Application.Mobile.Extensions.RestClientExtensions._ExecuteMobileAsync_d__0<T0> p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean PushTree() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object CheckPortableField() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
namespace Mass.Application.Mobile.Extensions {
	public class RestRequestExtensions
	{
		internal static global::Mass.Application.Mobile.Extensions.RestRequestExtensions DecoratePassiveLogger;
		public static global::RestSharp.RestRequest AddMobileEncryptParameter(global::RestSharp.RestRequest request, global::System.Object body) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public static global::RestSharp.RestRequest AddMobileEncryptParameter_2(global::RestSharp.RestRequest request, global::System.String body) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateExternalConnection() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Application.Mobile.Extensions.RestRequestExtensions CheckOperationalAttribute() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _䀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _䄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _䈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _䌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _䐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _䔀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _䘀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _䠀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Application.Mobile.Extensions {
	public class RestResponseExtensions
	{
		public static object EnsureSuccessStatusCode<T0>(global::RestSharp.RestResponse<global::Mass.Domain.Mobile.Entities.Com4399.EntityCom4399Response<object>> response, global::System.Int32 code, global::System.String message) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Application.Mobile.Exceptions {
	public abstract class Com4399Exception
	{
		internal static global::Mass.Application.Mobile.Exceptions.Com4399Exception ReflectCustomizableExecutor;
		public Com4399Exception(global::System.String message) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean RemoveValue() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Application.Mobile.Exceptions.Com4399Exception ConvertPool() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _䨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _䬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _䰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _䴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Application.Mobile.Exceptions {
	public abstract class MobileException
	{
		internal static global::Mass.Application.Mobile.Exceptions.MobileException DecorateHiddenNode;
		public MobileException(global::Mass.Domain.Entities.Netease.EntityResponse response) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckAdjustableFunction() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Application.Mobile.Exceptions.MobileException DecorateGenericBuffer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _一() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _伀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _倀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _儀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _刀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Application.Mobile.Constants {
	public class MobileHeaderStore
	{
		public static readonly global::System.String UserAgent;
		public static readonly global::System.String DefaultUserAgent;
		public static readonly global::System.String DefaultNeteaseVersion;
		public MobileHeaderStore() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Application.Mobile.Constants {
	public class MobileUrlStore
	{
		public static readonly global::System.String WebServerUrl;
		public static readonly global::System.String ApiGatewayUrl;
		public static readonly global::System.String CoreServerUrl;
		public static readonly global::System.String AuthServerUrl;
		public static readonly global::System.String LinkServerUrl;
		public static readonly global::System.String DcWebUrl;
	}

}
namespace Mass.Application.Mobile.Com4399 {
	public class Com4399
	{
		private static global::Serilog.ILogger Logger { get; }
		public static global::Mass.Application.Mobile.Com4399.Com4399 Instance { get; }
		public Com4399(global::Mass.Domain.Mobile.Entities.Com4399.EntityCom4399Device device, global::System.String sdkVersion) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task<global::System.String> RandomAsync(global::System.Func<global::System.ValueTuple<global::System.String, global::System.String>> randomCallback, global::System.Action<global::System.String, global::System.String> accountCallback, global::System.Net.IWebProxy proxy) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.Threading.Tasks.Task<global::System.String> LoginAsync(global::System.String username, global::System.String password) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<global::System.String> LoginAsync_2(global::System.Object username, global::System.Object password, global::System.UInt32 retry, global::System.Object captchaCode, global::System.Object captchaId) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static void ThrowIfError(global::System.Object content) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		static Com4399() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static void _RandomAsync_g__RandomAccount_9_0(ref global::Mass.Application.Mobile.Com4399.Com4399.__c__DisplayClass9_0 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.ValueTuple<global::System.String, global::System.String> _RandomAsync_g__Random_9_1() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckCommonValue() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Application.Mobile.Com4399.Com4399 ReflectAdaptablePool() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<global::System.String> _匀(global::System.Object p0, global::System.Object p1, global::System.UInt32 p2, global::System.Object p3, global::System.Object p4) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<global::System.String> _吀(global::System.Object p0, global::System.Object p1, global::System.UInt32 p2, global::System.Object p3, global::System.Object p4) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.Threading.Tasks.Task<global::System.String> _唀(global::System.Object p0, global::System.Object p1, global::System.UInt32 p2, global::System.Object p3, global::System.Object p4) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Threading.Tasks.Task<global::System.String> _嘀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Threading.Tasks.Task<global::System.String> _圀(global::System.Object p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static void _堀(global::System.IntPtr p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static void _夀(global::System.IntPtr p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static void _帀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static void _开(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static void _怀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.ValueTuple<global::System.String, global::System.String> _戀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _最() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _栀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _椀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Threading.Tasks.Task<global::System.String> _樀(global::System.Func<global::System.ValueTuple<global::System.String, global::System.String>> p0, global::System.Action<global::System.String, global::System.String> p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Threading.Tasks.Task<global::System.String> _欀(global::System.Func<global::System.ValueTuple<global::System.String, global::System.String>> p0, global::System.Action<global::System.String, global::System.String> p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _氀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _洀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _渀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Object _漀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public struct __c__DisplayClass9_0
		{
			public global::System.Func<global::System.ValueTuple<global::System.String, global::System.String>> randomCallback;
			public global::System.String username;
			public global::System.String password;
			public global::System.Action<global::System.String, global::System.String> accountCallback;
		}

		public struct _LoginAsync_d__10
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::System.String> __t__builder;
			public global::Mass.Application.Mobile.Com4399.Com4399 __4__this;
			public global::System.String username;
			public global::System.String password;
			internal static global::System.Object CheckActiveSchema;
			private void MoveNext(ref global::Mass.Application.Mobile.Com4399.Com4399._LoginAsync_d__10 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Application.Mobile.Com4399.Com4399._LoginAsync_d__10 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectJoinedLocator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectLiteralService() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _瀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _焀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _爀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _猀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _琀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _甀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _瘀(ref global::Mass.Application.Mobile.Com4399.Com4399._LoginAsync_d__10 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _眀(ref global::Mass.Application.Mobile.Com4399.Com4399._LoginAsync_d__10 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _砀(ref global::Mass.Application.Mobile.Com4399.Com4399._LoginAsync_d__10 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _LoginAsync_d__11
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::System.String> __t__builder;
			public global::System.Int32 retry;
			public global::System.String username;
			public global::Mass.Application.Mobile.Com4399.Com4399 __4__this;
			public global::System.String password;
			public global::System.String captchaCode;
			public global::System.String captchaId;
			private void MoveNext(ref global::Mass.Application.Mobile.Com4399.Com4399._LoginAsync_d__11 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Application.Mobile.Com4399.Com4399._LoginAsync_d__11 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean CallReg() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectGroupedRunner() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _礀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _稀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _笀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _簀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _紀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _縀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _뼀(ref global::Mass.Application.Mobile.Com4399.Com4399._LoginAsync_d__11 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _쀀(ref global::Mass.Application.Mobile.Com4399.Com4399._LoginAsync_d__11 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _섀(ref global::Mass.Application.Mobile.Com4399.Com4399._LoginAsync_d__11 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _숀(ref global::Mass.Application.Mobile.Com4399.Com4399._LoginAsync_d__11 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

		public struct _RandomAsync_d__9
		{
			public global::System.Int32 __1__state;
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::System.String> __t__builder;
			public global::System.Func<global::System.ValueTuple<global::System.String, global::System.String>> randomCallback;
			public global::System.Action<global::System.String, global::System.String> accountCallback;
			public global::System.Net.IWebProxy proxy;
			public global::Mass.Application.Mobile.Com4399.Com4399 __4__this;
			internal static global::System.Object CheckAccessibleClient;
			private void MoveNext(ref global::Mass.Application.Mobile.Com4399.Com4399._RandomAsync_d__9 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void SetStateMachine(ref global::Mass.Application.Mobile.Com4399.Com4399._RandomAsync_d__9 p0, global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Boolean ReflectIsolatedListener() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object ReflectAutomatableTracker() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _쌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _쐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Object _씀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _였() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _윀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			internal static global::System.Byte _저() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _케(ref global::Mass.Application.Mobile.Com4399.Com4399._RandomAsync_d__9 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _퀀(ref global::Mass.Application.Mobile.Com4399.Com4399._RandomAsync_d__9 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
			private void _턀(ref global::Mass.Application.Mobile.Com4399.Com4399._RandomAsync_d__9 p0, global::System.Object p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		}

	}

}
internal sealed class _Module__dbd119a4_39f4_4b7c_bc69_20e65d7a2b8a__a40
{
	internal global::System.Int32 m_705dc7d0143a447ea21cb6353b0614c1;
	internal global::System.Int32 m_35ece11bfea64864841651006dcb3af1;
	internal global::System.Int32 m_7dea5af251804ba7aade0484c990cd26;
	internal global::System.Int32 m_61d02c690deb41cc96e6c62645957754;
	internal global::System.Int32 m_fb4c7cd1135f483f8848415171bcbf23;
	internal global::System.Int32 m_9d9430b1c9594de58c58e5802caeb1bc;
	internal global::System.Int32 m_8cc1a51fd5e6411487c7c7a9e298a511;
	internal global::System.Int32 m_0bdb358ad86e48a1bebf71e6f34a8b8a;
	internal global::System.Int32 m_68036f969c774e328ef8aa4b713b2308;
	internal global::System.Int32 m_7c41d44152184127a3b92a92c7a5618c;
	internal global::System.Int32 m_45092f573a3f4e5c84c00e1c2307c294;
	internal global::System.Int32 m_f08cda3bba7b447aaf9ffdda160e76d3;
	internal static _Module__dbd119a4_39f4_4b7c_bc69_20e65d7a2b8a__a40 m_b6f4e2307c8340e493bf28273abbb38e;
	internal global::System.Int32 m_666bd3d6770d49518d7ef03ffdcc4e9c;
	internal global::System.Int32 m_2eae1deef0a14af4957d607d8838e053;
	internal global::System.Int32 m_4755f9c6fccc415da1be2dcf4d20c289;
	internal global::System.Int32 m_e87973535d604961a020177e4abc5e80;
	internal global::System.Int32 m_827500729a014144b7990633c3aaefd4;
	internal global::System.Int32 m_842805cee83e4e96b29420c471a97496;
	internal global::System.Int32 m_75c067ccd6634aa2800c533f305c0860;
	internal global::System.Int32 m_457ffb2cbcb5496eaa72fed29c6dfdf6;
	internal global::System.Int32 m_c84984ac07a64b4f92fb2d1f75c53543;
	internal global::System.Int32 m_a9905d3c08d5461f82f7be75bdc0fc3e;
	internal global::System.Int32 m_99d19d5501c54151b2aa5e7da877decd;
	internal global::System.Int32 m_bda9778d14b14e5a9eb224ec3be367ed;
	internal global::System.Int32 m_887ea4ef12e245ddb0b9f4457c5a9950;
	internal global::System.Int32 m_baee77b418614d33a1d843813a0b38b4;
	internal global::System.Int32 m_b84db1cf1a5342e695debaef024529ed;
	internal global::System.Int32 m_be641d33a369427db9861ced255dec60;
	internal global::System.Int32 m_469ed9665198415ca7d771e90e8217f6;
	internal global::System.Int32 m_da1ab8dcd26242ea80231a5e5c4a0370;
	internal global::System.Int32 m_68e3677c4b6f4a61987c3ce86fb7e843;
	internal global::System.Int32 m_0cd066376adc4ebaacebbaa3476d5952;
	internal global::System.Int32 m_187a722c33424716a990f3f71dff37a9;
	internal global::System.Int32 m_d26a9993173b4bccada71ebb56d98d81;
	internal global::System.Int32 m_28e28140aa7e455ca62eff08e6cd0bd3;
	internal global::System.Int32 m_9c951017f7ce4063b04eb41c4d344d87;
	internal global::System.Int32 m_c4aac233b2a847aa9282d325844e03be;
	internal global::System.Int32 m_8d9cf89593e242048b368e88b5e6365c;
	internal global::System.Int32 m_dfffbf38f0be4cf0a5d050e8addfaa25;
	internal global::System.Int32 m_2ced9161a5294664b373358e28e2a9b4;
	internal global::System.Int32 m_fde7bd11589c4dd586d75a8076ee1e5d;
	internal global::System.Int32 m_1951f37f35c04a038d191e79d9bdfbe1;
	internal global::System.Int32 m_3ecaa11635564dd9b7f8810745cec352;
	internal global::System.Int32 m_2d037557e6534288894a697330fc7de2;
	internal global::System.Int32 m_d5262d4b26c6404683aabb7700ef40be;
	internal global::System.Int32 m_0cefec266bf14de59a2cc78601d58ce4;
	internal global::System.Int32 m_4f106b8c931b48d59579aad950b52957;
	internal global::System.Int32 m_6eee971f0fa2434da97872c95faf5fba;
	internal global::System.Int32 m_cd248082cb444244872ec14f842b3512;
	internal global::System.Int32 m_38830cd85e704e6ab2da35f2fd660f8f;
	internal global::System.Int32 m_c402469ae52d4e62896d5e40e5fb812e;
	internal global::System.Int32 m_21139e1b17af4dcd889726d19dcb973f;
	internal global::System.Int32 m_1a607b28049b4cae8f506210252ec4fc;
	internal global::System.Int32 m_6f93a037f1c9402e8ba66b136a88c5f2;
	internal global::System.Int32 m_7ccc76492fb04e0eb51772a1053b282c;
	internal global::System.Int32 m_bf632e40ffce494b9742204262be2678;
	internal global::System.Int32 m_0277fd129dda437fafbadb3809bc6dee;
	internal global::System.Int32 m_0b8cbacf94a8485f9d6936c624ce1824;
	internal global::System.Int32 m_81d5869387d44e109944ac9b229d1bdc;
	internal global::System.Int32 m_29378f7069b3400387e9a86f601fae1e;
	internal global::System.Int32 m_05fbb3d33c1441938877d860d6bb39d2;
	internal global::System.Int32 m_583b22d9b0934065bcf39b8c49d1f78a;
	internal global::System.Int32 m_2e3ecb1e2eb34b8ea54ed558c2a02d20;
	internal global::System.Int32 m_83dc179b544843818f8add48d31f1afc;
	internal global::System.Int32 m_399bb3aac7c5455d9a9cc06bfe79f346;
	internal global::System.Int32 m_e5444c2fde2b47cfa605b73b568923ff;
	internal global::System.Int32 m_17ede5b9d18749dd9f27b5908e9aefcb;
	internal global::System.Int32 m_6c88c9debec044a9a2ce52e144d4b74b;
	internal global::System.Int32 m_e04b7a1f9c62437a9d2c4e5233106c9b;
	internal global::System.Int32 m_685f94a86d534707a4588c46bdd6d30a;
	internal global::System.Int32 m_36d29baba73d4a11aab07510604fa58e;
	internal global::System.Int32 m_efa7aaf507684e89a5cd5de8f3f17067;
	internal global::System.Int32 m_ec76e138d68242e3a61f4a1c4f8e265e;
	internal global::System.Int32 m_0ce9df57ca4a47268e6b91432ef193cb;
	internal global::System.Int32 m_1ab2530a8db84a008cfe7a73f994b1fc;
	internal global::System.Int32 m_202eee3259c5487e8e0f780b3b72354a;
	internal global::System.Int32 m_ed19e0669e0842928e50c67d6369d9bc;
	internal global::System.Int32 m_41416fda11794589bd22e0562d7b4b59;
	internal global::System.Int32 m_e92e6c5984be4ad2a017bc4b60bf647c;
	internal global::System.Int32 m_35fb1c5c57e047ea87653a83f174ad57;
	internal global::System.Int32 m_e41a85350b3543acab3be221883ace6d;
	internal global::System.Int32 m_ea61d45511744b13a229bc4e843e07ea;
	internal global::System.Int32 m_592918663b7949a0ab9f92b528f87ece;
	internal global::System.Int32 m_c277917799db4e1b807a3808890cebfb;
	internal global::System.Int32 m_b12fcc54711f4834a7e6306c3022e8dc;
	internal global::System.Int32 m_c349b44c287644b2a684fca5dc84b5a8;
	internal global::System.Int32 m_3b4a8fdccbbb461099e0c5bbeb5c1d6b;
	internal global::System.Int32 m_99e81017206145069bcbb699efd11fb9;
	internal global::System.Int32 m_ce5a6009a361422e94c07c4ab8b4c165;
	internal global::System.Int32 m_b83fa6a10e8c4557806350a613ffe6e9;
	internal global::System.Int32 m_95f8949de6f1489584ee780aa32547ae;
	internal global::System.Int32 m_674daff7f9d04c83bab13bbac4c71b03;
	internal global::System.Int32 m_4cdc11bdc9a7436d9173194e8a407192;
	internal global::System.Int32 m_9c907fa4debb42f6837735e561a7d659;
	internal global::System.Int32 m_69e48e6e523f4cb382de4fd5515fc5f7;
	internal global::System.Int32 m_4f7089c1dad84f4eaec615ca47bfcc68;
	internal global::System.Int32 m_b7d2c45e595f4535b3bda08a68973c70;
	internal global::System.Int32 m_2347d5ac7e51449a8c1ad9f38491776f;
	internal global::System.Int32 m_53f0582c92544d59ae2bb08bf8d8f07c;
	internal global::System.Int32 m_c12c38b95b68404dbe85fb914175826c;
	internal static _Module__dbd119a4_39f4_4b7c_bc69_20e65d7a2b8a__a40 MatchFunction;
	public _Module__dbd119a4_39f4_4b7c_bc69_20e65d7a2b8a__a40() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static void r3147a4fff992459aa015ed8a04ea227c() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Boolean DecorateIntegratedAggregator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static _Module__dbd119a4_39f4_4b7c_bc69_20e65d7a2b8a__a40 DecorateLocalTag() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static void _툀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static void _팀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static void _퐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Byte _픀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Byte _혀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Byte _휀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
}

internal sealed class ZYXDNGuarder_a40
{
	internal static global::System.Boolean a;
	internal static global::System.String CheckString(global::System.Int32 p0, global::System.Int32 p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.String CheckString_2(global::System.Int32 p0, global::System.Int32 p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	static ZYXDNGuarder_a40() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	private static global::System.Boolean CheckRuntime(global::System.Int32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	private static global::System.Boolean CheckRuntime64(global::System.Int32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Boolean RunHVM() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Boolean RunHVM_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static void Startup() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static void RunHVM_3(global::System.IntPtr p0, global::System.IntPtr p1, global::System.IntPtr p2, global::System.Int32 p3) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static void dvm() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object Ā() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 㸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 䠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 刀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 嬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 昀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 爀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 眀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 砀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 礀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 稀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 笀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 脀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 蜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 謀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 谀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 贀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 騀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ꨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 가() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 렀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 숀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 쌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 츀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 케() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 切() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ﴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _Ā() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _Ȁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _Ѐ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _Ԁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _ࠀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _㠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _㤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _㨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _䜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _䤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _娀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _嬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _尀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _崀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _愀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _挀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _搀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _攀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _昀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _缀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _耀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _脀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _舀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _茀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _萀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _蔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _蘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _蜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _蠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _褀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _言() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _謀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _谀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _贀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _踀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _輀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _退() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _鄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _鈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _錀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _鐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _销() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _阀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _需() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _頀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _餀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _騀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _鬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _鰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _鴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _鸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _鼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _ꀀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _ꄀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _ꈀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _ꌀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _ꐀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _ꔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _ꘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _ꠀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _꤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _ꨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _가() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _관() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _글() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _꼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _뀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _넀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _눀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _대() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _됀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _딀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _똀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _뜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _렀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _뤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _먀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _묀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _밀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _봀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _븀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _준() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _쨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _쬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _찀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _촀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _츀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	public sealed class d
	{
		public d(global::System.Object p0, global::System.IntPtr p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.IntPtr Invoke(global::System.Object p0, global::System.Int32 p1, global::System.Int32 p2, global::System.IntPtr p3, global::System.Int32 p4) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}

