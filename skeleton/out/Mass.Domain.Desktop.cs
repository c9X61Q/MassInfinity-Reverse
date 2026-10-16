// 自动生成的可编译骨架 —— 声明来自元数据；方法体一律为显式占位（未还原）。
// 生成器：tools/MassSkeleton（dnlib 读元数据），不依赖反编译文本。
#nullable disable
using System;

namespace Mass.Domain.Desktop.ValueObjects {
	public enum EnumGameClientType
	{
		all = 0,
		java = 1,
		cpp = 2,
	}

}
namespace Mass.Domain.Desktop.ValueObjects {
	public enum EnumGameType
	{
		None = -1,
		SingleGame = 1,
		NetGame = 2,
		McGame = 7,
		ServerGame = 8,
		LanGame = 9,
		OnlineLobbyGame = 10,
	}

}
namespace Mass.Domain.Desktop.ValueObjects {
	public enum EnumGameVersion
	{
		None = 0,
		V_CPP = 100000000,
		V_X64_CPP = 300000000,
		V_RTX = 200000000,
		V_1_7_10 = 1007010,
		V_1_10_2 = 1010002,
		V_1_8 = 1008000,
		V_1_11_2 = 1011002,
		V_1_12_2 = 1012002,
		V_1_8_8 = 1008008,
		V_1_8_9 = 1008009,
		V_1_9_4 = 1009004,
		V_1_6_4 = 1006004,
		V_1_7_2 = 1007002,
		V_1_12 = 1012000,
		V_1_13_2 = 1013002,
		V_1_14_3 = 1014003,
		V_1_15 = 1015000,
		V_1_16 = 1016000,
		V_1_18 = 1018000,
		V_1_19_2 = 1019002,
		V_1_20 = 1020000,
		V_1_20_6 = 1020006,
		V_1_21 = 1021000,
		V_1_21_8 = 1021008,
		V_1_21_10 = 1021010,
	}

}
namespace Mass.Domain.Desktop.ValueObjects {
	public enum EnumItemMasterType
	{
		None = 0,
		SingleGame = 1,
		NetGame = 2,
		Functional = 3,
		Visual = 4,
		Map = 5,
		GamePlay = 6,
		Apperance = 10,
		OnlineLobbyMap = 11,
	}

}
namespace Mass.Domain.Desktop.ValueObjects {
	public enum EnumItemSubType
	{
		All = 0,
		Tool = 15,
		Adventure = 16,
		Science = 17,
		Shadow = 18,
		Material = 19,
		Scenario = 21,
		Building = 22,
		Environment = 23,
		Puz = 24,
		Spg = 25,
		Avg = 26,
		Act = 27,
		Simulation = 28,
		Strategy = 29,
		Rpg = 30,
		Skin = 31,
		Cape = 32,
		Pre = 34,
		Farm = 35,
		Decorate = 36,
		Magic = 37,
		Other = 38,
		Biology = 43,
		ParticleEffect = 44,
	}

}
namespace Mass.Domain.Desktop.ValueObjects {
	public enum EnumItemType
	{
		Game = 1,
		Component = 2,
	}

}
namespace Mass.Domain.Desktop.ValueObjects {
	public enum EnumJavaType
	{
		None = 0,
		Java7 = 7,
		Java8 = 8,
		Java17 = 17,
	}

}
namespace Mass.Domain.Desktop.ValueObjects {
	public enum EnumPlayerStatus
	{
		Permit = 0,
		Blacklist = 1,
	}

}
namespace Mass.Domain.Desktop.ValueObjects {
	public enum EnumServerStatus
	{
		None = -1,
		ServerOff = 0,
		ServerOn = 1,
		Uninitialized = 2,
		Opening = 3,
		Closing = 4,
		OutOfDate = 5,
		SaveCleaning = 6,
		Resetting = 7,
		Upgrading = 8,
		DiscOverflow = 9,
	}

}
namespace Mass.Domain.Desktop.ValueObjects {
	public enum EnumTextureType
	{
		Skin = 31,
		FourDimensionalSkin = 41,
		SpecialSkin = 42,
	}

}
namespace Mass.Domain.Desktop.ValueObjects {
	public enum EnumVisibilityStatus
	{
		Public = 0,
		Friend = 1,
		Private = 2,
		Password = 3,
	}

}
namespace Mass.Domain.Desktop.Models {
	public class PageModel<T0>
	{
		internal static global::System.Object ReflectStatelessBridge;
		public T0[] Items { get; set; }
		public global::System.Int32 TotalPage { get; set; }
		public PageModel() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean MatchEnumerator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object AssembleParameter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Interfaces {
	public interface IDesktopGame
	{
		public global::System.String EntityId { get; set; }
		public global::System.String Name { get; set; }
		public global::System.String Author { get; set; }
		public global::System.String Description { get; set; }
		public global::System.Int32 PlayerCount { get; set; }
		public global::System.Int32 MaxCount { get; set; }
		public global::System.Int32 LikeCount { get; set; }
		public global::System.String ImageUrl { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion GameVersion { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameType GameType { get; set; }
	}

}
namespace Mass.Domain.Desktop.Interfaces {
	public interface IDesktopGameCharacter
	{
		public global::System.String GameId { get; set; }
		public global::System.String Name { get; set; }
		public global::System.DateTime CreateTime { get; set; }
	}

}
namespace Mass.Domain.Desktop.Interfaces {
	public interface IDesktopSkin
	{
		public global::System.String EntityId { get; set; }
		public global::System.String Name { get; set; }
		public global::System.String BriefSummary { get; set; }
		public global::System.String ImageUrl { get; set; }
	}

}
namespace Mass.Domain.Desktop.Entities {
	public class EntityAuthenticationBan
	{
		internal static global::Mass.Domain.Desktop.Entities.EntityAuthenticationBan CheckExpandableAggregator;
		public global::System.String BanType { get; set; }
		public global::System.DateTime BanTo { get; set; }
		public global::System.String BanMessage { get; set; }
		public EntityAuthenticationBan() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateHiddenTag() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.EntityAuthenticationBan ReflectAdjustableDefinition() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______鬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______鰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______鴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______鸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______鼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______ꀀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______ꄀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______ꈀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______ꌀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______ꐀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.DateTime _______ꔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______ꘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______ꠀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______꤀(global::System.DateTime p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______ꨀ(global::System.DateTime p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities {
	public class EntityAuthenticationDelete
	{
		public global::System.String UserId { get; set; }
		public global::System.Int32 LogoutType { get; set; }
		public EntityAuthenticationDelete() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean FillProvider() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.EntityAuthenticationDelete ReflectCustomAnalyzer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______踀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______輀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______退() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______鄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______鈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______錀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______鐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______销(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______阀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______需(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______頀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _______餀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _______騀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities {
	public class EntityAuthenticationOtp
	{
		internal static global::Mass.Domain.Desktop.Entities.EntityAuthenticationOtp ReflectAdvancedDistributor;
		public global::System.String EntityId { get; set; }
		public global::System.String Account { get; set; }
		public global::System.String Token { get; set; }
		public global::System.String Sead { get; set; }
		public global::System.Boolean HasMessage { get; set; }
		public global::System.String SdkUid { get; set; }
		public global::System.String AccessToken { get; set; }
		public global::System.String UniSdkLoginJson { get; set; }
		public global::System.Int32 VerifyStatus { get; set; }
		public global::System.Boolean HasGmail { get; set; }
		public global::System.Boolean IsRegister { get; set; }
		public global::System.String Env { get; set; }
		public global::System.Int64 LastServerUpTime { get; set; }
		public global::System.String MinEngineVersion { get; set; }
		public global::System.String MinPatchVersion { get; set; }
		public EntityAuthenticationOtp() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectConvertibleNotifier() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.EntityAuthenticationOtp CheckMixedDispatcher() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______匀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______吀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______唀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______嘀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______圀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______堀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______夀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______娀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______嬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _______尀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _______崀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______帀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______开(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______怀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______愀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______戀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _______挀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _______搀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______攀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _______昀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _______最() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______栀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______椀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______樀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______欀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______氀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______洀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______渀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______漀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______瀀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______焀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______爀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______猀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______琀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _______甀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _______瘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______眀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______砀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______礀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______稀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______笀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______簀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______紀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______縀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______缀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______耀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______脀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Int64 _______舀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______茀(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______萀(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______蔀(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______蘀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______蜀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______蠀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______褀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______言() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______謀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______谀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______贀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities {
	public class EntityAuthenticationOtpDetail
	{
		public global::System.String OsName { get; set; }
		public global::System.String OsVer { get; set; }
		public global::System.String MacAddr { get; set; }
		public global::System.String Udid { get; set; }
		public global::System.String AppVersion { get; set; }
		public global::System.String SdkVersion { get; set; }
		public global::System.String Network { get; set; }
		public global::System.String Disk { get; set; }
		public global::System.String Is64Bit { get; set; }
		public global::System.String VideoCard1 { get; set; }
		public global::System.String VideoCard2 { get; set; }
		public global::System.String VideoCard3 { get; set; }
		public global::System.String VideoCard4 { get; set; }
		public global::System.String LauncherType { get; set; }
		public global::System.String PayChannel { get; set; }
		public global::System.String DotNetVersion { get; set; }
		public global::System.String CpuType { get; set; }
		public global::System.String RamSize { get; set; }
		public global::System.String DeviceWidth { get; set; }
		public global::System.String DeviceHeight { get; set; }
		public global::System.String OsDetail { get; set; }
		public EntityAuthenticationOtpDetail() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean PlayLogger() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.EntityAuthenticationOtpDetail CheckCommonState() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________2(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________3(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______豈() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______切() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______ﬀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______ﰀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______ﴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______Ā() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______Ȁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______Ѐ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______Ԁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _________2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _________3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______ࠀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _________4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _________5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _________6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _________7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _________8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _________9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______ༀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______က(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______ᄀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______ሀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______ጀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _________10(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______ᔀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______ᘀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______ᜀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _________11(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______ᤀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______ᨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _________12(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______ᰀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _________13(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _________14(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______Ⰰ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______ⴀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _________15(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _________16() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _________17() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _________18(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _________19(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _________20() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______㐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______㔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______㘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______㜀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______㠀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______㤀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______㨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______㬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______㰀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______㴀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______㸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______㼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______䀀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______䄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______䈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______䌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______䐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______䔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______䘀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______䜀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______䠀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______䤀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______䨀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______䬀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______䰀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______䴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______一() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______伀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______倀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______儀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______刀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities {
	public class EntityAuthenticationOtpDto
	{
		internal static global::Mass.Domain.Desktop.Entities.EntityAuthenticationOtpDto CheckAdaptableHandler;
		public global::Mass.Domain.Desktop.Entities.EntityAuthenticationOtpDetail SaData { get; set; }
		public global::Mass.Domain.Desktop.Entities.SAuth.EntitySAuth AuthJson { get; set; }
		public global::Mass.Domain.Desktop.Entities.EntityAuthenticationOtpVersion Version { get; set; }
		public global::System.String SdkUid { get; set; }
		public global::System.String Aid { get; set; }
		public global::System.Boolean HasMessage { get; set; }
		public global::System.Boolean HasGmail { get; set; }
		public global::System.String OtpToken { get; set; }
		public global::System.String OtpPwd { get; set; }
		public global::System.Int64 LockTime { get; set; }
		public global::System.String Env { get; set; }
		public global::System.String MinEngineVersion { get; set; }
		public global::System.String MinPatchVersion { get; set; }
		public global::System.Int32 VerifyStatus { get; set; }
		public global::System.String UniSdkLoginJson { get; set; }
		public global::System.String Token { get; set; }
		public global::System.Boolean IsRegister { get; set; }
		public global::System.String EntityId { get; set; }
		public EntityAuthenticationOtpDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckPortableStruct() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.EntityAuthenticationOtpDto ReflectBasicReporter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______꼀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______뀀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______넀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______눀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Int64 ______대() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Int64 ______됀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______딀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______똀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______뜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______렀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______뤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______먀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______묀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ______밀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ______봀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______븀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ______뼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______쀀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______섀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______숀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______쌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______쐀(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______씀(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______였(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______윀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______저() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ______준() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ______쨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ______쬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______찀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______촀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______츀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______케() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______퀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______턀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______툀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______팀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______퐀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______픀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______혀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______휀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ________2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________3(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________5(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ________11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ________12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ________13() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ________14() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________15() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________16() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________17(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________18(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________19(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________20(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________21(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________22(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________23() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________24() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________25() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________26(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities {
	public class EntityAuthenticationOtpVersion
	{
		public global::System.String Version { get; set; }
		public global::System.String LauncherMd5 { get; set; }
		public global::System.String UpdaterMd5 { get; set; }
		public EntityAuthenticationOtpVersion() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean FormatExecutor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.EntityAuthenticationOtpVersion PostPredictor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______鴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______鸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______鼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______ꀀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______ꄀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______ꈀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______ꌀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______ꐀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______ꔀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______ꘀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______ꠀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______꤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______ꨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______가(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______관(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______글(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities {
	public class EntityAuthenticationUpdate
	{
		internal static global::Mass.Domain.Desktop.Entities.EntityAuthenticationUpdate CheckJoinedGateway;
		public global::System.UInt64 EntityId { get; set; }
		public EntityAuthenticationUpdate() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean RestartNode() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.EntityAuthenticationUpdate DecorateScalableFactory() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______销() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______阀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______需(global::System.UInt64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______頀(global::System.UInt64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______餀(global::System.UInt64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______騀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______鬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt64 ______鰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities {
	public class EntityAuthServer
	{
		internal static global::Mass.Domain.Desktop.Entities.EntityAuthServer CheckModularTester;
		public global::System.String Ip { get; set; }
		public global::System.Int32 Port { get; set; }
		public global::System.String ServerType { get; set; }
		public EntityAuthServer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DetachMonitor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.EntityAuthServer GetSynchronizer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______茀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______萀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______蔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______蘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______蜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______蠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______褀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______言() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______謀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______谀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______贀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ______踀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ______輀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______退() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______鄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______鈀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______錀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______鐀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities {
	public class EntityCppGameClientInfo
	{
		public global::System.String Url { get; set; }
		public global::System.String Md5 { get; set; }
		public EntityCppGameClientInfo() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckAutomatableError() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.EntityCppGameClientInfo CheckIterableCache() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______瘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______眀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______砀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______礀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______稀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______笀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______簀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______紀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______縀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______缀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______耀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______脀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______舀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities {
	public class EntityGetCppGameClientInfoDto
	{
		public global::System.String Os { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion Version { get; set; }
		public global::System.String EntityId { get; set; }
		public EntityGetCppGameClientInfoDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean MoveProfile() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.EntityGetCppGameClientInfoDto ChangeChooser() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______搀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______攀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______昀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______栀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______椀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______樀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______欀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______氀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______洀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______渀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______漀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion ______瀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______焀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______爀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______猀(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______琀(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______甀(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities {
	public class EntityJavaPatch
	{
		internal static global::Mass.Domain.Desktop.Entities.EntityJavaPatch CustomizeSolver;
		public global::System.Int64 Size { get; set; }
		public global::System.String Url { get; set; }
		public global::System.String Md5 { get; set; }
		public EntityJavaPatch() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectSeparatedMap() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.EntityJavaPatch ReflectMonoVisitor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______刀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______匀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______吀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______唀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______嘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______圀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______堀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______夀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______娀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______嬀(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______尀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______崀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______帀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Int64 ______开() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Int64 ______怀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Int64 ______愀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______戀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______挀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities {
	public class EntityLoginOtp
	{
		internal static global::Mass.Domain.Desktop.Entities.EntityLoginOtp CheckOrderedWatcher;
		private global::System.Int32 Otp { get; set; }
		public global::System.String OtpToken { get; set; }
		public global::System.Int32 Aid { get; set; }
		public global::System.Int64 LockTime { get; set; }
		public global::System.Int32 OpenOtp { get; set; }
		public EntityLoginOtp() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckVisualElement() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.EntityLoginOtp AddError() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ______㠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ______㤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.UInt32 ______㨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.UInt32 ______㬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private global::System.UInt32 ______㰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______㴀(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______㸀(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______㼀(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Int64 ______䀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Int64 ______䄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______䈀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______䌀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______䐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______䔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______䘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______䜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______䠀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______䤀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______䨀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______䬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______䰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ______䴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ______一() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ______伀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ______倀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private void ______儀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities {
	public class EntityLoginOtpDto
	{
		public global::Mass.Domain.Desktop.Entities.SAuth.EntitySAuth Json { get; set; }
		public EntityLoginOtpDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckDynamicDic() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.EntityLoginOtpDto CheckConcreteObject() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ________2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________3(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________4(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ________5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______㐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______㔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______㘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______㜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities {
	public class EntityServerTime
	{
		internal static global::Mass.Domain.Desktop.Entities.EntityServerTime ReflectConnectedDecorator;
		public global::System.Int32 Current { get; set; }
		public EntityServerTime() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectAlphabeticArgument() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.EntityServerTime CheckEditableSummarizer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ________2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________3(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________4(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______Ⰰ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ______ⴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ________5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities {
	public class EntitySetNicknameDto
	{
		internal static global::Mass.Domain.Desktop.Entities.EntitySetNicknameDto ProcessVisitor;
		public global::System.String Nickname { get; set; }
		public global::System.String UserId { get; set; }
		public EntitySetNicknameDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckSimpleTemplate() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.EntitySetNicknameDto ReflectControllableAuditor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______ᰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______ᴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______Ḁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______ἀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ________2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ________3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________4(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________5(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________6(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________7(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities {
	public class EntityTransferServer
	{
		internal static global::Mass.Domain.Desktop.Entities.EntityTransferServer ReflectTransferableDecider;
		public global::System.String Ip { get; set; }
		public global::System.Int32 Port { get; set; }
		public global::System.Int32 WebPort { get; set; }
		public global::System.String ServerType { get; set; }
		public EntityTransferServer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecompressWriter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.EntityTransferServer PresentDic() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______Ѐ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______Ԁ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______ࠀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________4(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________5(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ________6(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ________7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ________8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______ༀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______က(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______ᄀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ______ሀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ______ጀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ________9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______ᔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______ᘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______ᜀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______ᤀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______ᨀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities {
	public class EntityUserDetail
	{
		public global::System.String Name { get; set; }
		public EntityUserDetail() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean StartDecorator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.EntityUserDetail ReflectSequentialPolicy() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____ﴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______2(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______Ā(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______Ȁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Web4399 {
	public class EntityWeb4399Check
	{
		public global::System.Boolean State { get; set; }
		public global::System.String Data { get; set; }
		public global::System.String Url { get; set; }
		public EntityWeb4399Check() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean SaveProgram() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Web4399.EntityWeb4399Check CheckAttachedEvent() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______6(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______7(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______8(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______9(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _____豈() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____切(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____ﬀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____ﰀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Web4399 {
	public class EntityWeb4399Register
	{
		public global::System.Boolean State { get; set; }
		public global::System.Int32 Code { get; set; }
		public global::System.String Msg { get; set; }
		public EntityWeb4399Register() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckDetachedProcessor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Web4399.EntityWeb4399Register CheckDetailedContainer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______7(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______8(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______9(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______10(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _______11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _______12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _______13() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _______14() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _______15() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _______16() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______17(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______18(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Sy4399 {
	public class Entity4399JsonCallback
	{
		public global::System.Int32 Code { get; set; }
		public global::System.String Message { get; set; }
		public global::Mass.Domain.Desktop.Entities.Sy4399.Entity4399JsonResult Result { get; set; }
		public Entity4399JsonCallback() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckGeneralVerifier() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Sy4399.Entity4399JsonCallback ReflectExtendedAnnotation() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____촀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____츀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____케() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____퀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____턀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____툀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____팀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____퐀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____픀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____혀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____휀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ______() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______2(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______3(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______4(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Sy4399 {
	public class Entity4399JsonResult
	{
		public global::System.String CaptchaId { get; set; }
		public Entity4399JsonResult() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CancelRequester() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Sy4399.Entity4399JsonResult ValidateModule() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____쐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____씀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____였(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____윀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____저() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____준() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____쨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____쬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____찀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Skin {
	public class EntityGetOwnedSkinsDto
	{
		internal static global::Mass.Domain.Desktop.Entities.Skin.EntityGetOwnedSkinsDto EvaluateEvent;
		public global::Mass.Domain.Desktop.ValueObjects.EnumItemMasterType MasterTypeId { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumItemType ItemType { get; set; }
		public global::System.Int32 Length { get; set; }
		public global::System.Int32 Offset { get; set; }
		public EntityGetOwnedSkinsDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateFilteredStrategy() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Skin.EntityGetOwnedSkinsDto ReflectAutomatedSorter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____글(global::Mass.Domain.Desktop.ValueObjects.EnumItemType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____꼀(global::Mass.Domain.Desktop.ValueObjects.EnumItemType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____뀀(global::Mass.Domain.Desktop.ValueObjects.EnumItemType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumItemMasterType _____넀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumItemMasterType _____눀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____대(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____됀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumItemType _____딀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumItemType _____똀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____뜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____렀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____뤀(global::Mass.Domain.Desktop.ValueObjects.EnumItemMasterType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____먀(global::Mass.Domain.Desktop.ValueObjects.EnumItemMasterType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____묀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____밀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____봀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____븀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____뼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____쀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____섀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____숀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____쌀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Skin {
	public class EntityGetSkinsDto
	{
		public global::System.Boolean IsHas { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumItemType ItemType { get; set; }
		public global::System.Int32 Length { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumItemMasterType MasterTypeId { get; set; }
		public global::System.Int32 Offset { get; set; }
		public global::System.Int32 PriceType { get; set; }
		public global::System.String SecondaryTypeId { get; set; }
		public EntityGetSkinsDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean OpenConverter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Skin.EntityGetSkinsDto DecorateOperationalRunner() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____贀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____踀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____輀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____退(global::Mass.Domain.Desktop.ValueObjects.EnumItemType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____鄀(global::Mass.Domain.Desktop.ValueObjects.EnumItemType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____鈀(global::Mass.Domain.Desktop.ValueObjects.EnumItemType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____錀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____鐀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____销(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumItemMasterType _____阀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumItemMasterType _____需() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumItemMasterType _____頀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____餀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____騀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____鬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____鰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumItemType _____鴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumItemType _____鸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____鼀(global::Mass.Domain.Desktop.ValueObjects.EnumItemMasterType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____ꀀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____ꄀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____ꈀ(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____ꌀ(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____ꐀ(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____ꔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____ꘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____ꠀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____꤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____ꨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _______2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____가(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____관(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Skin {
	public class EntityGetUserSkinDto
	{
		public global::System.String UserId { get; set; }
		public EntityGetUserSkinDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean InsertComparator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Skin.EntityGetUserSkinDto InterruptBridge() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____蘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____蜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____蠀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____褀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____言() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____謀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____谀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Skin {
	public class EntityOwnedSkinItem
	{
		internal static global::Mass.Domain.Desktop.Entities.Skin.EntityOwnedSkinItem DecorateCustomizableFinalizer;
		public global::System.String ItemId { get; set; }
		public global::System.String EntityId { get; set; }
		public global::System.String Name { get; set; }
		public global::System.String Brief { get; set; }
		public global::System.String BriefSummary { get; set; }
		public global::System.String ImageUrl { get; set; }
		public EntityOwnedSkinItem() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectInternalAggregator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Skin.EntityOwnedSkinItem CheckExpandableTag() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____洀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____渀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____漀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____瀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____焀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____爀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____猀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____琀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____甀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____瘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____眀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____砀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____礀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____稀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____笀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____簀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____紀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____縀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____缀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____耀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____脀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____舀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____茀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____萀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____蔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Skin {
	public class EntitySearchSkinItemDto
	{
		internal static global::Mass.Domain.Desktop.Entities.Skin.EntitySearchSkinItemDto ObserveSorter;
		public global::System.Boolean IsHas { get; set; }
		public global::System.Int32 IsSync { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumItemType ItemType { get; set; }
		public global::System.String Keyword { get; set; }
		public global::System.Int32 Length { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumItemMasterType MasterTypeId { get; set; }
		public global::System.Int32 Offset { get; set; }
		public global::System.Int32 PriceType { get; set; }
		public global::System.String SecondaryTypeId { get; set; }
		public global::System.Int32 SortType { get; set; }
		public global::System.Int32 Year { get; set; }
		public EntitySearchSkinItemDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateAdjustableTransmitter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Skin.EntitySearchSkinItemDto WriteEmitter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____㸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____㼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____䀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____䄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____䈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____䌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____䐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____䔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _____䘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _____䜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _____䠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____䤀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____䨀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____䬀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumItemMasterType _____䰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumItemMasterType _____䴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumItemMasterType _____一() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumItemType _____伀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____倀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____儀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____刀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____匀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____吀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____唀(global::Mass.Domain.Desktop.ValueObjects.EnumItemType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____嘀(global::Mass.Domain.Desktop.ValueObjects.EnumItemType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____圀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____堀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____夀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____娀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____嬀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____尀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____崀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____帀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____开(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____怀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____愀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____戀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____挀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____搀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____攀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____昀(global::Mass.Domain.Desktop.ValueObjects.EnumItemMasterType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____栀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____椀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____樀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____欀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____氀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Skin {
	public class EntitySkinItem
	{
		public global::System.UInt32 DownloadCount;
		public global::System.String EntityId { get; set; }
		public global::System.String Name { get; set; }
		public global::System.UInt32 LikeCount { get; set; }
		public global::System.String DeveloperName { get; set; }
		public global::System.String BriefSummary { get; set; }
		public global::System.String ImageUrl { get; set; }
		public EntitySkinItem() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckCustomDistributor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Skin.EntitySkinItem ReflectAdvancedNotifier() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______5(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______6(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______7(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______9(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______10(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____Ⰰ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____ⴀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______13() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______14() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______15() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______16(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____㐀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____㔀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____㘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____㜀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____㠀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____㤀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____㨀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____㬀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____㰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____㴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Skin {
	public class EntitySkinSetting
	{
		internal static global::Mass.Domain.Desktop.Entities.Skin.EntitySkinSetting ReflectConvertibleDispatcher;
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameClientType ClientType { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameType GameType { get; set; }
		public global::System.Int64 SkinId { get; set; }
		public global::System.Int32 SkinMode { get; set; }
		public global::System.Int32 SkinType { get; set; }
		public EntitySkinSetting() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckMixedSingleton() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Skin.EntitySkinSetting AssessAggregator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Int64 ______() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Int64 _____ࠀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameClientType _______2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameClientType _______3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______4(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______5(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _______6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _______7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____ༀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____က(global::Mass.Domain.Desktop.ValueObjects.EnumGameType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____ᄀ(global::Mass.Domain.Desktop.ValueObjects.EnumGameType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType _____ሀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType _____ጀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____ᔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____ᘀ(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____ᜀ(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______9(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____ᤀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____ᨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____ᰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____ᴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____Ḁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____ἀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______11(global::Mass.Domain.Desktop.ValueObjects.EnumGameClientType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______12(global::Mass.Domain.Desktop.ValueObjects.EnumGameClientType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Skin {
	public class EntitySkinSettings
	{
		internal static global::Mass.Domain.Desktop.Entities.Skin.EntitySkinSettings HandleTag;
		public global::System.Collections.Generic.List<global::Mass.Domain.Desktop.Entities.Skin.EntitySkinSetting> SkinSettings { get; set; }
		public EntitySkinSettings() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateCommonHandler() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Skin.EntitySkinSettings ReflectAdaptableStruct() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____Ā() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____Ȁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______(global::System.Collections.Generic.List<global::Mass.Domain.Desktop.Entities.Skin.EntitySkinSetting> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____Ѐ(global::System.Collections.Generic.List<global::Mass.Domain.Desktop.Entities.Skin.EntitySkinSetting> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _____Ԁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::Mass.Domain.Desktop.Entities.Skin.EntitySkinSetting> _______2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Skin {
	public class EntityUserSkin
	{
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameType GameType { get; set; }
		public global::System.String SkinId { get; set; }
		public global::System.Int32 SkinMode { get; set; }
		public global::System.Int32 SkinType { get; set; }
		public EntityUserSkin() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectBasicChain() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Skin.EntityUserSkin AnalyzeDistributor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______2(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______3(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType ______4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType ______5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType ______6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______7(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______13(global::Mass.Domain.Desktop.ValueObjects.EnumGameType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______14(global::Mass.Domain.Desktop.ValueObjects.EnumGameType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ______15() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ______16() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ____豈() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____切() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____ﬀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ____ﰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____ﴀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______17(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______18(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.SAuth {
	public abstract class Entity4399SAuth
	{
		internal static global::Mass.Domain.Desktop.Entities.SAuth.Entity4399SAuth SetNotifier;
		public global::Mass.Domain.Desktop.Entities.SAuth.EntitySAuthRealNameInfo RealName { get; set; }
		public global::System.String Timestamp { get; set; }
		public global::System.String UserId { get; set; }
		public Entity4399SAuth() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectActiveGateway() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.SAuth.Entity4399SAuth SearchSingleton() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ________() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______가() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______관() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______글(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______꼀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______뀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______넀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______눀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______대(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______됀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______딀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______똀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______뜀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______렀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______묀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______밀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.SAuth {
	public class EntitySAuth
	{
		public global::System.String GameId { get; set; }
		public global::System.String LoginChannel { get; set; }
		public global::System.String AppChannel { get; set; }
		public global::System.String Platform { get; set; }
		public global::System.String SdkUserId { get; set; }
		public global::System.String SessionId { get; set; }
		public global::System.String SdkVersion { get; set; }
		public global::System.String UniqueDeviceId { get; set; }
		public global::System.String DeviceId { get; set; }
		public global::Mass.Domain.Desktop.Entities.SAuth.EntitySAuthAimInfo AimInfo { get; set; }
		public global::System.String ClientLoginSn { get; set; }
		public global::System.String GetAccessToken { get; set; }
		public global::System.String SourcePlatform { get; set; }
		public global::System.String Ip { get; set; }
		public EntitySAuth() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckScalableCompressor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.SAuth.EntitySAuth CallHandler() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____꤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____ꨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____가() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____관() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____글() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____꼀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____뀀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____넀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____눀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____대(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____됀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____딀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____똀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____뜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____렀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____뤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____먀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____묀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____밀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____봀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____븀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____뼀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____쀀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____섀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____숀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____쌀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____쐀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____씀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____였() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____윀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____저() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____준(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____쨀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____쬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____찀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____촀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____츀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____케() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____퀀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____턀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____휀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______2(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______3(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______7(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______8(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______9(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______10(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______11(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______13() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______14() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______15() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______16() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______17() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______18() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.SAuth {
	public class EntitySAuthAimInfo
	{
		internal static global::Mass.Domain.Desktop.Entities.SAuth.EntitySAuthAimInfo LeadStruct;
		public global::System.String Ip { get; set; }
		public global::System.String Country { get; set; }
		public global::System.String TimeZone { get; set; }
		public global::System.String TimeZoneId { get; set; }
		public EntitySAuthAimInfo() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateAccessibleDecryptor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.SAuth.EntitySAuthAimInfo ReflectIsolatedError() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____鄀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____鈀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____錀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____鐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____销() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____阀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____需(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____頀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____餀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____騀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____鬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____鰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____鴀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____鸀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____鼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____ꌀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____ꐀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____ꔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____ꘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____ꠀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.SAuth {
	public class EntitySAuthRealNameInfo
	{
		internal static global::Mass.Domain.Desktop.Entities.SAuth.EntitySAuthRealNameInfo DecorateAutomatableCache;
		public global::System.String RealNameType { get; set; }
		public EntitySAuthRealNameInfo() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateIterableUser() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.SAuth.EntitySAuthRealNameInfo AssembleGateway() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____謀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____谀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____贀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____踀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____輀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____退() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.RentalGame {
	public class EntityAddRentalGameCharacterDto
	{
		public global::System.String ServerId { get; set; }
		public global::System.String UserId { get; set; }
		public global::System.String Name { get; set; }
		public global::System.Int64 CreateTime { get; set; }
		public global::System.Boolean IsOnline { get; set; }
		public global::System.Int32 Status { get; set; }
		public EntityAddRentalGameCharacterDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CloneFactory() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.RentalGame.EntityAddRentalGameCharacterDto CheckConfigurableMap() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____欀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____氀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____洀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____渀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____漀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____瀀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ____焀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ____爀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ____猀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____琀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____甀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____瘀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____眀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____砀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____礀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ____稀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ____笀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Int64 ____簀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Int64 ____紀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____縀(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____缀(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____耀(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____脀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____舀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____茀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____萀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____蔀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____蘀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____蜀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____蠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____褀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____言() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.RentalGame {
	public class EntityGetRentalGameAddressDto
	{
		internal static global::Mass.Domain.Desktop.Entities.RentalGame.EntityGetRentalGameAddressDto DecorateSeparatedVisitor;
		public global::System.String ServerId { get; set; }
		public global::System.String Password { get; set; }
		public EntityGetRentalGameAddressDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean AssetStream() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.RentalGame.EntityGetRentalGameAddressDto ReflectOrderedElement() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____开() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____怀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____愀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____戀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____挀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____搀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____攀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____昀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____最(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____栀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____椀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____樀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.RentalGame {
	public class EntityGetRentalGameCharactersDto
	{
		public global::System.String ServerId { get; set; }
		public global::System.Int32 Offset { get; set; }
		public global::System.Int32 Length { get; set; }
		public EntityGetRentalGameCharactersDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean MeasureFinder() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.RentalGame.EntityGetRentalGameCharactersDto RemoveAllocator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____䴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____一() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____伀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____倀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____儀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ____刀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____匀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____吀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____唀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____嘀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ____圀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ____堀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ____夀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____娀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____嬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____尀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____崀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____帀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.RentalGame {
	public class EntityGetRentalGamesDto
	{
		internal static global::Mass.Domain.Desktop.Entities.RentalGame.EntityGetRentalGamesDto DecorateDynamicObject;
		public global::System.Int32 Offset { get; set; }
		public global::System.Int32 SortType { get; set; }
		public global::System.String Keyword { get; set; }
		public EntityGetRentalGamesDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateConcreteDecorator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.RentalGame.EntityGetRentalGamesDto ReflectConnectedArgument() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____㰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____㴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____㸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____㼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____䀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____䄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____䈀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____䌀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____䐀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____䔀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ____䘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ____䜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ____䠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ____䤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____䨀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____䬀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____䰀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.RentalGame {
	public class EntityRentalGameAddress
	{
		internal static global::Mass.Domain.Desktop.Entities.RentalGame.EntityRentalGameAddress CheckAlphabeticSummarizer;
		public global::System.String McServerHost { get; set; }
		public global::System.UInt16 McServerPort { get; set; }
		public EntityRentalGameAddress() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateEditableProgram() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.RentalGame.EntityRentalGameAddress ReflectLogicalTemplate() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____㐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____㔀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____㘀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____㜀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____㠀(global::System.UInt16 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt16 ____㤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt16 ____㨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt16 ____㬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.RentalGame {
	public class EntityRentalGameCharacter
	{
		internal static global::Mass.Domain.Desktop.Entities.RentalGame.EntityRentalGameCharacter ManageFilter;
		public global::System.String GameId { get; set; }
		public global::System.String ServerId { get; set; }
		public global::System.String UserId { get; set; }
		public global::System.String Name { get; set; }
		public global::System.DateTime CreateTime { get; set; }
		public global::System.DateTime DeleteTime { get; set; }
		public global::System.Boolean IsOnline { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumPlayerStatus Status { get; set; }
		public EntityRentalGameCharacter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean WatchStack() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.RentalGame.EntityRentalGameCharacter ReflectTransferableList() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______2(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______3(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______4(global::System.DateTime p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______5(global::System.DateTime p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____ༀ(global::Mass.Domain.Desktop.ValueObjects.EnumPlayerStatus p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____က() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____ᄀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____ሀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.DateTime ____ጀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.DateTime ______6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____ᔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____ᘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____ᜀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____ᤀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____ᨀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______8(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____ᰀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____ᴀ(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____Ḁ(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____ἀ(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ______9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ______10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ______11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.DateTime ______12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______13() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ______14() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______15(global::System.DateTime p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______16(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______17(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumPlayerStatus ______18() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumPlayerStatus ______19() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumPlayerStatus ______20() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____Ⰰ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____ⴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.RentalGame {
	public class EntityRentalGameItem
	{
		internal static global::Mass.Domain.Desktop.Entities.RentalGame.EntityRentalGameItem ReflectResponsiveRecord;
		public global::System.String EntityId { get; set; }
		public global::System.String Name { get; set; }
		public global::System.String ServerName { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumVisibilityStatus Visibility { get; set; }
		public global::System.Boolean HasPassword { get; set; }
		public global::System.String ServerType { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumServerStatus Status { get; set; }
		public global::System.Int32 MaxCount { get; set; }
		public global::System.String McVersion { get; set; }
		public global::System.Int64 OwnerId { get; set; }
		public global::System.Int32 PlayerCount { get; set; }
		public global::System.Collections.Generic.List<global::System.String> ImageUrls { get; set; }
		public global::System.String WorldId { get; set; }
		public global::System.String MinLevel { get; set; }
		public global::System.Boolean IsPvpEnabled { get; set; }
		public global::System.Int32 LikeCount { get; set; }
		public global::System.UInt32 IconIndex { get; set; }
		public global::System.String Offset { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion GameVersion { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameType GameType { get; set; }
		public global::System.String ImageUrl { get; set; }
		public global::System.String Author { get; set; }
		public global::System.String Description { get; set; }
		public EntityRentalGameItem() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean PlayConnection() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.RentalGame.EntityRentalGameItem DecorateCombinedMapper() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___됀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___딀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___똀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___뜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___렀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___뤀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Int64 ___먀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Int64 ___묀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Int64 ___밀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___봀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___븀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___뼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___쀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___섀(global::Mass.Domain.Desktop.ValueObjects.EnumVisibilityStatus p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___숀(global::Mass.Domain.Desktop.ValueObjects.EnumVisibilityStatus p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___쌀(global::Mass.Domain.Desktop.ValueObjects.EnumVisibilityStatus p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___쐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___씀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___였(global::System.Collections.Generic.List<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___윀(global::System.Collections.Generic.List<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___저() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___준() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___쨀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___쬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___찀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.String> ___촀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___츀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___케() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___퀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___턀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___툀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___팀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion ___퐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion ___픀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___혀(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumVisibilityStatus ___휀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumVisibilityStatus ____() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumVisibilityStatus _____2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____3(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____4(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____5(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType _____8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType _____9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____10(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____11(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumServerStatus _____12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumServerStatus _____13() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____14() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____15() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____16() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____17() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____18(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____19(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____20(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____21(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____22(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____23(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____24(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____25(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____26(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____27(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____28(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____29() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____30() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____31() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____32() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____33() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___豈(global::Mass.Domain.Desktop.ValueObjects.EnumServerStatus p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___切(global::Mass.Domain.Desktop.ValueObjects.EnumServerStatus p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___ﬀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___ﰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___ﴀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____34(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____35(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____Ā(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____Ȁ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____(global::Mass.Domain.Desktop.ValueObjects.EnumGameType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____Ѐ(global::Mass.Domain.Desktop.ValueObjects.EnumGameType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____Ԁ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ______2(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ______3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ____ࠀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ______4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Pc4399 {
	public class Entity4399SdkData
	{
		internal static global::Mass.Domain.Desktop.Entities.Pc4399.Entity4399SdkData CheckTransformablePolicy;
		public global::System.Collections.Generic.List<global::Mass.Domain.Desktop.Entities.Pc4399.Entity4399SdkOperation> Operations { get; set; }
		public global::System.String Username { get; set; }
		public global::System.String LoginTip { get; set; }
		public global::System.String SdkLoginData { get; set; }
		public Entity4399SdkData() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean EncryptMatcher() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Pc4399.Entity4399SdkData DecorateSetModule() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___鼀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___ꀀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___ꄀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::Mass.Domain.Desktop.Entities.Pc4399.Entity4399SdkOperation> ___ꈀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::Mass.Domain.Desktop.Entities.Pc4399.Entity4399SdkOperation> ___ꌀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___ꐀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___ꔀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___ꘀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___ꠀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___꤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___ꨀ(global::System.Collections.Generic.List<global::Mass.Domain.Desktop.Entities.Pc4399.Entity4399SdkOperation> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____2(global::System.Collections.Generic.List<global::Mass.Domain.Desktop.Entities.Pc4399.Entity4399SdkOperation> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___가() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___관() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___글() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___꼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___뀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___넀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___눀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___대(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Pc4399 {
	public class Entity4399SdkInfo
	{
		internal static global::Mass.Domain.Desktop.Entities.Pc4399.Entity4399SdkInfo InitExecutor;
		public global::System.Int32 Code { get; set; }
		public global::System.String Message { get; set; }
		public global::Mass.Domain.Desktop.Entities.Pc4399.Entity4399SdkData Data { get; set; }
		public Entity4399SdkInfo() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean FormatPredictor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Pc4399.Entity4399SdkInfo CheckGlobalProcessor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___踀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___輀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___退() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___鄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___鈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___錀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___鐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___销(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___阀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___需(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___頀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___餀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___騀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___鬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___鰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___鴀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___鸀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Pc4399 {
	public class Entity4399SdkOperation
	{
		internal static global::Mass.Domain.Desktop.Entities.Pc4399.Entity4399SdkOperation DecorateDetachedContainer;
		public global::System.String Name { get; set; }
		public global::System.String Link { get; set; }
		public global::System.String Banner { get; set; }
		public global::System.Int32 Type { get; set; }
		public Entity4399SdkOperation() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectDetailedConverter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Pc4399.Entity4399SdkOperation PeekBuffer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___稀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___笀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___簀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___紀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___縀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___缀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___耀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___脀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___舀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___茀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___萀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___蔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___蘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___蜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___蠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___褀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___言() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___謀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___谀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___贀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.NetGame {
	public class EntityGetNetGameAddressDto
	{
		public global::System.String GameId { get; set; }
		public EntityGetNetGameAddressDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateExtendedComparator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.NetGame.EntityGetNetGameAddressDto GetEditor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___爀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___猀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___琀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___甀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___瘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___眀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___砀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___礀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.NetGame {
	public class EntityGetNetGameDetailsDto
	{
		public global::System.String GameId { get; set; }
		public EntityGetNetGameDetailsDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectStatelessConsumer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.NetGame.EntityGetNetGameDetailsDto DecorateScheduledStrategy() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___椀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___樀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___欀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___氀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___洀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___渀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___漀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___瀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___焀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.NetGame {
	public class EntityGetNetGamesDto
	{
		internal static global::Mass.Domain.Desktop.Entities.NetGame.EntityGetNetGamesDto JoinProfile;
		public global::System.String[] AvailableMcVersions { get; set; }
		public global::System.Int32 ItemType { get; set; }
		public global::System.Int32 Length { get; set; }
		public global::System.Int32 Offset { get; set; }
		public global::System.String MasterTypeId { get; set; }
		public global::System.String SecondaryTypeId { get; set; }
		public EntityGetNetGamesDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean MoveChooser() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.NetGame.EntityGetNetGamesDto CheckPassiveEmitter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___䨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___䬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___䰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___䴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___一(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___伀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___倀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___儀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___刀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___匀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___吀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___唀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___嘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___圀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___堀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___夀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___娀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___嬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___尀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___崀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___帀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___开(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___怀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___愀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___戀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___挀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___搀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___攀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___昀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___最(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___栀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.NetGame {
	public class EntityGetNetGameVersionDto
	{
		internal static global::Mass.Domain.Desktop.Entities.NetGame.EntityGetNetGameVersionDto DecorateExternalRunner;
		public global::System.Collections.Generic.List<global::System.String> ItemIds { get; set; }
		public EntityGetNetGameVersionDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean GuideTracer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.NetGame.EntityGetNetGameVersionDto DecorateVirtualListener() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___䈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___䌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___䐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___䔀(global::System.Collections.Generic.List<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___䘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.String> ___䜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.String> ___䠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.String> ___䤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.NetGame {
	public class EntityNetGameAddress
	{
		public global::System.String EntityId { get; set; }
		public global::System.Boolean IspEnable { get; set; }
		public global::System.String Ip { get; set; }
		public global::System.Int32 Port { get; set; }
		public global::System.Int32 GameStatus { get; set; }
		public global::System.String Announcement { get; set; }
		public global::System.Boolean InWhitelist { get; set; }
		public EntityNetGameAddress() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckInterruptibleFinalizer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.NetGame.EntityNetGameAddress ReflectCustomizableAggregator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___ᴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___Ḁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte ___ἀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____2(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____3(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____4(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____5(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____6(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _____9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____10(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____11(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _____12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___Ⰰ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___ⴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _____13() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _____14() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____15(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____16(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____17(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____18() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___㐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___㔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___㘀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___㜀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___㠀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___㤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___㨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___㬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___㰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___㴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___㸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___㼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___䀀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___䄀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.NetGame {
	public class EntityNetGameDetails
	{
		internal static global::Mass.Domain.Desktop.Entities.NetGame.EntityNetGameDetails RunUser;
		public global::System.Collections.Generic.List<global::System.String> BriefImageUrls { get; set; }
		public global::System.String BriefSummary { get; set; }
		public global::System.String DetailDescription { get; set; }
		public global::System.String DeveloperName { get; set; }
		public global::System.String DeveloperUrs { get; set; }
		public global::System.String Forum { get; set; }
		public EntityNetGameDetails() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateExpandableDefinition() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.NetGame.EntityNetGameDetails ReflectHiddenTransmitter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __ﴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___Ā() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___Ȁ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___Ѐ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___Ԁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____3(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___ࠀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____4(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____5(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___ༀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___က() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___ᄀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___ሀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.String> ___ጀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.String> _____10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.String> ___ᔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___ᘀ(global::System.Collections.Generic.List<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___ᜀ(global::System.Collections.Generic.List<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _____11(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___ᤀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___ᨀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _____12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___ᰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.NetGame {
	public class EntityNetGameItem
	{
		public global::System.String EntityId { get; set; }
		public global::System.String Description { get; set; }
		public global::System.String Name { get; set; }
		public global::System.String Author { get; set; }
		public global::System.Int32 PlayerCount { get; set; }
		public global::System.Int32 LikeCount { get; set; }
		public global::System.String ImageUrl { get; set; }
		public global::System.Int32 DownloadCount { get; set; }
		public global::System.String MasterType { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion GameVersion { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameType GameType { get; set; }
		public global::System.Int32 MaxCount { get; set; }
		public EntityNetGameItem() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateGenericAnalyzer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.NetGame.EntityNetGameItem CheckRandomDistributor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __윀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __저(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __준(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __쨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __쬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __찀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __촀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __츀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __케(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __퀀(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __턀(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __툀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __팀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __퐀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __픀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __혀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __휀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____5(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____6(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType ____10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType ____11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____12(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____13(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____14(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ____15() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ____16() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____17(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____18() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____19() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____20(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____21(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion ____22() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____23() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____24() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____25() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____26(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____27(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____28() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____29(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____30(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____31(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____32(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ____33() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __豈() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __切(global::Mass.Domain.Desktop.ValueObjects.EnumGameType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __ﬀ(global::Mass.Domain.Desktop.ValueObjects.EnumGameType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __ﰀ(global::Mass.Domain.Desktop.ValueObjects.EnumGameType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.NetGame {
	public class EntityNetGameVersion
	{
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion GameVersion { get; set; }
		public global::System.String ItemId { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumJavaType JavaVersion { get; set; }
		public EntityNetGameVersion() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectAdvancedDispatcher() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.NetGame.EntityNetGameVersion CheckConvertibleSingleton() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __뜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __렀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __뤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __먀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __묀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __밀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumJavaType __봀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumJavaType __븀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __뼀(global::Mass.Domain.Desktop.ValueObjects.EnumJavaType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __쀀(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __섀(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __숀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __쌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion __쐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion __씀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __였(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.MPay {
	public class EntityMPayDevice
	{
		public global::System.String Id { get; set; }
		public global::System.String Key { get; set; }
		public EntityMPayDevice() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecompressDic() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.MPay.EntityMPayDevice DecorateSegmentedHandler() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __가() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __관() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __글() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __꼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __뀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __넀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __눀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __대(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __됀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __딀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __똀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.MPay {
	public abstract class EntityMPayDevices
	{
		public global::Mass.Domain.Desktop.Entities.MPay.EntityMPayDevice Device { get; set; }
		public EntityMPayDevices() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectAdaptableReporter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.MPay.EntityMPayDevices DecoratePortableChain() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______봀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______븀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______뼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______쀀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______섀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______숀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______쌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______쐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______씀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.MPay {
	public abstract class EntityMPayDevicesUser
	{
		internal static global::Mass.Domain.Desktop.Entities.MPay.EntityMPayDevicesUser CheckBasicEnumerator;
		public global::Mass.Domain.Desktop.Entities.MPay.EntityMPayUser User { get; set; }
		public EntityMPayDevicesUser() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean SaveTemplate() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.MPay.EntityMPayDevicesUser CloseAuditor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______였() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______윀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______저() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______준(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______쨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______쬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______찀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______촀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.MPay {
	public class EntityMPayDevicesUserDto
	{
		public global::System.String Password { get; set; }
		public global::System.String UniqueId { get; set; }
		public global::System.String Username { get; set; }
		public EntityMPayDevicesUserDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ControlList() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.MPay.EntityMPayDevicesUserDto CheckLiteralCompressor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __鬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __鰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __鴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __鸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __鼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __ꀀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __ꄀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __ꈀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __ꌀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __ꐀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __ꔀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __ꘀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __ꠀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __꤀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __ꨀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.MPay {
	public class EntityMPayResponse
	{
		public global::System.Int32 Code { get; set; }
		public global::System.String Reason { get; set; }
		public global::System.String VerifyUrl { get; set; }
		public EntityMPayResponse() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckModularResolver() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.MPay.EntityMPayResponse NewPolicy() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __謀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __谀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __贀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __踀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __輀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __退() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __鄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __鈀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __錀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __鐀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __销(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __阀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __需() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __頀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __餀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __騀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.MPay {
	public abstract class EntityMPayTicket
	{
		internal static global::Mass.Domain.Desktop.Entities.MPay.EntityMPayTicket ReflectAccessibleError;
		public global::System.String Ticket { get; set; }
		public global::System.String GuideText { get; set; }
		public EntityMPayTicket() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CancelModule() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.MPay.EntityMPayTicket DecorateAutomatableUser() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______츀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______케() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _______퀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______턀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______툀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______팀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______퐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______픀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______혀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______휀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ________() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _________2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.MPay {
	public class EntityMPayUser
	{
		public global::System.String Token { get; set; }
		public global::System.String Id { get; set; }
		public global::System.Nullable<global::System.Int32> RealNameVerifyStatus { get; set; }
		public global::System.Nullable<global::System.Int32> RealNameStatus { get; set; }
		public EntityMPayUser() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckIntegratedPublisher() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.MPay.EntityMPayUser SplitContainer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __眀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __砀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __礀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __稀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __笀(global::System.Nullable<global::System.Int32> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __簀(global::System.Nullable<global::System.Int32> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __紀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __縀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __缀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __耀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __脀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Nullable<global::System.Int32> __舀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Nullable<global::System.Int32> __茀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Nullable<global::System.Int32> __萀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __蔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __蘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __蜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Nullable<global::System.Int32> __蠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __褀(global::System.Nullable<global::System.Int32> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __言(global::System.Nullable<global::System.Int32> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Mods {
	public class EntityAuthItem
	{
		internal static global::Mass.Domain.Desktop.Entities.Mods.EntityAuthItem UpdateConverter;
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion GameVersion { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameType GameType { get; set; }
		public global::System.UInt64[] ItemIdList { get; set; }
		public EntityAuthItem() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateConfigurableVisitor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Mods.EntityAuthItem CheckSeparatedWatcher() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __昀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __最() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __栀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __椀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __樀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __欀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __氀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __洀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __渀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __漀(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __瀀(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType __焀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType __爀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion __猀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion __琀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion __甀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __瘀(global::Mass.Domain.Desktop.ValueObjects.EnumGameType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Mods {
	public class EntityGameClientPatch
	{
		public global::System.String CoreLibMd5 { get; set; }
		public global::System.String CoreLibName { get; set; }
		public global::System.Int32 CoreLibSize { get; set; }
		public global::System.String CoreLibUrl { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion GameVersion { get; set; }
		public global::System.String Name { get; set; }
		public global::System.Int32 RefreshTime { get; set; }
		public global::System.Int32 Size { get; set; }
		public global::System.String Md5 { get; set; }
		public global::System.String Url { get; set; }
		public global::System.String Version { get; set; }
		public EntityGameClientPatch() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckOrderedDriver() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Mods.EntityGameClientPatch DecorateVisualWriter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __㘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __㜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __㠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __㤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __㨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __㬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __㰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __㴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __㸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __㼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __䀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __䄀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __䈀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __䌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __䐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __䔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __䘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __䜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __䠀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __䤀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __䨀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __䬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __䰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __䴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __一(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __伀(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __倀(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __儀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __刀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __匀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __吀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __唀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __嘀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __圀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __堀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __夀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __娀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __嬀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __尀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __崀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __帀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __开(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __怀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion __愀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion __戀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __挀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __搀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __攀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Mods {
	public class EntityGameModHash
	{
		internal static global::Mass.Domain.Desktop.Entities.Mods.EntityGameModHash ReflectScopeDic;
		public global::System.String ModPath { get; set; }
		public global::System.String ModId { get; set; }
		public global::System.String ItemId { get; set; }
		public global::System.String ModName { get; set; }
		public global::System.String ModMd5 { get; set; }
		public EntityGameModHash() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean InvokeStrategy() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Mods.EntityGameModHash ResetSorter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __ᰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __ᴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __Ḁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __ἀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____2(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____3(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____6(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __Ⰰ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __ⴀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ____13(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____14() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____15() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____16() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____17() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____18() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __㐀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __㔀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Mods {
	public class EntityGameModsHash
	{
		internal static global::Mass.Domain.Desktop.Entities.Mods.EntityGameModsHash ReflectConcreteArgument;
		public global::Mass.Domain.Desktop.Entities.Mods.EntityGameModHash[] Mods { get; set; }
		public EntityGameModsHash() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean MergeEmitter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Mods.EntityGameModsHash CheckAlphabeticProgram() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __ᔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __ᘀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __ᜀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __ᤀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __ᨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ____3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Mods {
	public class EntityGetAuthItemsDto
	{
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameType GameType { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion GameVersion { get; set; }
		public EntityGetAuthItemsDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean PlanListener() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Mods.EntityGetAuthItemsDto DecodeTracker() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType __ࠀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType ___() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType ____2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ____6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __ༀ(global::Mass.Domain.Desktop.ValueObjects.EnumGameType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __က(global::Mass.Domain.Desktop.ValueObjects.EnumGameType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __ᄀ(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion __ሀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion __ጀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Mods {
	public class EntityGetGamePatchInfoDto
	{
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion McVersion { get; set; }
		public EntityGetGamePatchInfoDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean BuildAggregator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Mods.EntityGetGamePatchInfoDto AssessTag() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __Ȁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __Ѐ(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __Ԁ(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ____2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion ____3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Mods {
	public class EntityItemDownload
	{
		internal static global::Mass.Domain.Desktop.Entities.Mods.EntityItemDownload CheckSortedMapper;
		public global::System.String ItemId { get; set; }
		public global::System.String UserId { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumItemType ItemType { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumItemMasterType MasterType { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumItemSubType SubType { get; set; }
		public global::Mass.Domain.Desktop.Entities.Mods.EntitySubItemDownload[] SubEntities { get; set; }
		public global::System.UInt64[] SubModList { get; set; }
		public global::System.String ResourceName { get; }
		public EntityItemDownload() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateCombinedPolicy() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Mods.EntityItemDownload PushRecommender() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumItemMasterType __() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumItemMasterType ___2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___3(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___4(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___5(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___9(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___10(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___11(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___13() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___14() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___15(global::Mass.Domain.Desktop.ValueObjects.EnumItemType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___16(global::Mass.Domain.Desktop.ValueObjects.EnumItemMasterType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___17(global::Mass.Domain.Desktop.ValueObjects.EnumItemMasterType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___18() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___19() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumItemSubType ___20() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumItemSubType ___21() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___22() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___23() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___24(global::Mass.Domain.Desktop.ValueObjects.EnumItemSubType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___25(global::Mass.Domain.Desktop.ValueObjects.EnumItemSubType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___26() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _豈() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _切() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _ﬀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumItemType _ﰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumItemType _ﴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___27(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___28(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __Ā(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Mods {
	public class EntitySubItemDownload
	{
		public global::System.String EntityId { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumJavaType JavaVersion { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion GameVersion { get; set; }
		public global::System.String ResourceUrl { get; set; }
		public global::System.Int32 ResourceSize { get; set; }
		public global::System.String ResourceMd5 { get; set; }
		public global::System.String JarMd5 { get; set; }
		public global::System.String ResourceName { get; set; }
		public global::System.Int32 ResourceVersion { get; set; }
		public EntitySubItemDownload() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateSetEvent() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Mods.EntitySubItemDownload ReflectEfficientWrapper() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _대(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _됀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _딀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _똀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _뜀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _렀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _뤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _먀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _묀(global::Mass.Domain.Desktop.ValueObjects.EnumJavaType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _밀(global::Mass.Domain.Desktop.ValueObjects.EnumJavaType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _봀(global::Mass.Domain.Desktop.ValueObjects.EnumJavaType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _븀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _뼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _쀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _섀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _숀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _쌀(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _쐀(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _씀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _였() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _윀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _저(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _준(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _쨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _쬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _찀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _촀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _츀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _케() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _퀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _턀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _툀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _팀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _퐀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _픀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion _혀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion _휀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumJavaType ___2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumJavaType ___3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumJavaType ___4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.LanGame {
	public class EntityGetRelatedLanGameRoomsDto
	{
		internal static global::Mass.Domain.Desktop.Entities.LanGame.EntityGetRelatedLanGameRoomsDto CheckAttachedProcessor;
		public global::System.Int32 Count { get; set; }
		public EntityGetRelatedLanGameRoomsDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectSingleton() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.LanGame.EntityGetRelatedLanGameRoomsDto ReflectDetachedConverter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _ꨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _가(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _관(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _글() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _꼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _뀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _넀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _눀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.LanGame {
	public class EntityGetSingleLanGameRoomDto
	{
		internal static global::Mass.Domain.Desktop.Entities.LanGame.EntityGetSingleLanGameRoomDto DecorateDetailedVerifier;
		public global::System.UInt32 HostId { get; set; }
		public global::System.UInt32 RoomId { get; set; }
		public EntityGetSingleLanGameRoomDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean MonitorHandler() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.LanGame.EntityGetSingleLanGameRoomDto ReflectGeneralComparator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _鸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _鼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _ꀀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _ꄀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _ꈀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _ꌀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _ꐀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ꔀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ꘀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ꠀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _꤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.LanGame {
	public class EntityLanGameRoom
	{
		internal static global::Mass.Domain.Desktop.Entities.LanGame.EntityLanGameRoom LeadReporter;
		public global::System.String EntityId { get; set; }
		public global::System.String Name { get; set; }
		public global::System.String Author { get; set; }
		public global::System.String Description { get; set; }
		public global::System.Int32 PlayerCount { get; set; }
		public global::System.Int32 MaxCount { get; set; }
		public global::System.Int32 LikeCount { get; set; }
		public global::System.String ImageUrl { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameType GameType { get; set; }
		public global::System.UInt32 RoomId { get; set; }
		public global::System.String RoomName { get; set; }
		public global::System.UInt32 HostId { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion GameVersion { get; set; }
		public global::System.String Guid { get; set; }
		public global::System.String Ip { get; set; }
		public global::System.Int32 Port { get; set; }
		public global::Mass.Domain.Desktop.Entities.LanGame.EntityLanGameTips Tips { get; set; }
		public EntityLanGameRoom(global::Mass.Domain.Desktop.Entities.LanGame.EntityLanGameRoomInfo room) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectVisibleCommand() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.LanGame.EntityLanGameRoom SendEnumerator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _唀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _嘀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _圀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _堀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _夀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _娀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _嬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType _尀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType _崀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _帀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _开(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _怀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _愀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _戀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _挀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _搀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _攀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _昀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _最() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _栀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _椀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _樀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _欀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _氀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _洀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _渀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _漀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _瀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _焀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _爀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _猀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _琀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _甀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _瘀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _眀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _砀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _礀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _稀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _笀(global::Mass.Domain.Desktop.ValueObjects.EnumGameType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _簀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _紀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _縀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _缀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _耀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _脀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _舀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _茀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _萀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _蔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _蘀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _蜀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _蠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _褀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _言() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _謀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _谀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _贀(global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _踀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _輀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _錀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _鐀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _销(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _阀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _需(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion _頀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion _餀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _騀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _鬀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _鰀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _鴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.LanGame {
	public class EntityLanGameRoomInfo
	{
		public global::System.UInt32 HostId { get; set; }
		public global::System.UInt32 RoomId { get; set; }
		public global::System.UInt32 Cap { get; set; }
		public global::System.UInt32 Free { get; set; }
		public global::System.UInt32 Type { get; set; }
		public global::System.String Name { get; set; }
		public global::System.String Tips { get; set; }
		public global::System.Collections.Generic.List<global::System.UInt32> TagIds { get; set; }
		public global::System.String ServerAddress { get; set; }
		public EntityLanGameRoomInfo() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateScheduledSorter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.LanGame.EntityLanGameRoomInfo ReflectFilteredConfig() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _Ⰰ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ⴀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___2(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___3(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___4(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___5(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _㐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _㔀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _㘀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _㜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _㠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _㤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _㨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _㬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _㰀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _㴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _㸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _㼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _䀀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _䄀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _䈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _䌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.UInt32> _䐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.UInt32> _䔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.UInt32> _䘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _䜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _䠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _䤀(global::System.Collections.Generic.List<global::System.UInt32> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _䨀(global::System.Collections.Generic.List<global::System.UInt32> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _䬀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _䰀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _䴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _一() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _伀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _倀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _儀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _刀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _匀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _吀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.LanGame {
	public class EntityLanGameTips
	{
		internal static global::Mass.Domain.Desktop.Entities.LanGame.EntityLanGameTips AwakeFactory;
		public global::System.String NickName { get; set; }
		public global::System.UInt32 Version { get; set; }
		public global::System.String Guid { get; set; }
		public global::System.Collections.Generic.List<global::System.UInt64> ComponentList { get; set; }
		public EntityLanGameTips() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecoratePassiveRunner() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.LanGame.EntityLanGameTips ReflectExternalClient() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ᤀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ᨀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _ᰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ᴀ(global::System.Collections.Generic.List<global::System.UInt64> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _Ḁ(global::System.Collections.Generic.List<global::System.UInt64> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _ἀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___4(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___5(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.UInt64> ___10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.UInt64> ___11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.UInt64> ___12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___13(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___14(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.LanGame {
	public class EntityRelatedLanGameRoomResponse
	{
		public global::System.Int32 Code { get; set; }
		public global::Mass.Domain.Desktop.Entities.LanGame.EntityLanGameRoomInfo[] List { get; set; }
		public EntityRelatedLanGameRoomResponse() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectVirtualTracker() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.LanGame.EntityRelatedLanGameRoomResponse DecorateIdentifiableFinalizer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ___3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _ༀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _က() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ᄀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ሀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ጀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___4(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ᔀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _ᘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _ᜀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.LanGame {
	public class EntitySearchLanGameRoomDto
	{
		public global::System.String Name { get; set; }
		public EntitySearchLanGameRoomDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean MeasureAllocator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.LanGame.EntitySearchLanGameRoomDto DecorateInternalDefinition() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ___2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _ࠀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ___3(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ___4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ___5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.LanGame {
	public class EntitySingleLanGameRoomResponse
	{
		public global::System.Int32 Code { get; set; }
		public global::Mass.Domain.Desktop.Entities.LanGame.EntityLanGameRoomInfo Info { get; set; }
		public EntitySingleLanGameRoomResponse() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckHiddenRecommender() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.LanGame.EntitySingleLanGameRoomResponse CheckAdjustableAnalyzer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 豈() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 切() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ﬀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ﰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ﴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __3(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __4(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _Ā(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _Ȁ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _Ѐ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _Ԁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Item {
	public class EntityGetItemChannelListDto
	{
		internal static global::Mass.Domain.Desktop.Entities.Item.EntityGetItemChannelListDto ReflectGenericDistributor;
		public global::System.Collections.Generic.List<global::System.String> ItemIdList { get; set; }
		public global::System.Int32 ChannelId { get; set; }
		public EntityGetItemChannelListDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckRandomNotifier() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Item.EntityGetItemChannelListDto DecorateCustomDispatcher() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.String> _() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.String> __2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Collections.Generic.List<global::System.String> __3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __8(global::System.Collections.Generic.List<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __9(global::System.Collections.Generic.List<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __10(global::System.Collections.Generic.List<global::System.String> p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __11(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __13() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __14() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Item {
	public class EntityGetItemDownloadDto
	{
		public global::System.UInt64 ItemId { get; set; }
		public global::System.Int32 Length { get; set; }
		public global::System.Int32 Offset { get; set; }
		public EntityGetItemDownloadDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckConvertibleParser() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Item.EntityGetItemDownloadDto DecorateMixedState() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __9(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __10(global::System.UInt64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __11(global::System.UInt64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __13() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt64 __14() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt64 __15() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __16(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Item {
	public class EntityGetItemDownloadListDto
	{
		public global::System.UInt64[] ItemIdList { get; set; }
		public EntityGetItemDownloadListDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean SetupAuthorizer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Item.EntityGetItemDownloadListDto ReflectAdaptableChain() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 턀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 툀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 팀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 퐀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 픀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 혀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 휀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Item {
	public class EntityItemChannel
	{
		internal static global::Mass.Domain.Desktop.Entities.Item.EntityItemChannel CheckPortableEnumerator;
		public global::System.String ChannelId { get; set; }
		public global::System.String ItemId { get; set; }
		public global::System.String TitleImageUrl { get; set; }
		public EntityItemChannel() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectBasicParameter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Item.EntityItemChannel DecorateReadableGateway() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 뼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 쀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 섀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 숀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 쌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 쐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 씀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 였(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 윀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 저(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 준(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 쨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 쬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 찀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 촀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 츀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 케(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 퀀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Item {
	public class EntityItemPurchase
	{
		internal static global::Mass.Domain.Desktop.Entities.Item.EntityItemPurchase ReflectRemoteProfiler;
		public global::System.Int32 BuyType { get; set; }
		public global::System.String EntityId { get; set; }
		public EntityItemPurchase() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean PostNode() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Item.EntityItemPurchase DecorateJoinedCompressor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 넀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 눀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 대() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 됀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 딀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 똀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 뜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 렀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 뤀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 먀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 묀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 밀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 봀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 븀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Item {
	public class EntityPurchaseItemDto
	{
		public global::System.String ItemId { get; set; }
		public global::System.String UserId { get; set; }
		public global::System.Int32 BatchCount { get; set; }
		public global::System.String BuyPath { get; set; }
		public global::System.Int32 Diamond { get; set; }
		public global::System.Int32 EntityId { get; set; }
		public global::System.Int32 ItemLevel { get; set; }
		public global::System.Int64 LastPlayTime { get; set; }
		public global::System.Int64 PurchaseTime { get; set; }
		public global::System.Int64 TotalPlayTime { get; set; }
		public EntityPurchaseItemDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean PeekCollector() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Item.EntityPurchaseItemDto DecorateModularDecryptor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 萀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 蔀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 蘀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Int64 蜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Int64 蠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 褀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 言() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Int64 謀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Int64 谀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Int64 贀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 踀(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 輀(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 退(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 鄀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 鈀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 錀(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 鐀(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 销(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 阀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 需() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 頀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 餀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 騀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 鬀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 鰀(global::System.Int64 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 鴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 鸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 鼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ꀀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ꄀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 ꈀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ꌀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ꐀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Int64 ꔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object ꘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object _() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ꠀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _꤀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __2(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 가(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 관() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 글() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 꼀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 뀀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Item {
	public class EntitySearchItemIdsDto
	{
		public global::System.String ChannelId { get; set; }
		public global::System.String[] EntityIds { get; set; }
		public global::System.Boolean IsHas { get; set; }
		public global::System.Int32 WithPrice { get; set; }
		public global::System.Int32 WithTitleImage { get; set; }
		public EntitySearchItemIdsDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckAccessibleCache() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Item.EntitySearchItemIdsDto DecorateIsolatedUser() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte 椀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte 樀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 欀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 氀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 洀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 渀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 漀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 瀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 焀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 爀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 猀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 琀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 甀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 瘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 眀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 砀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 礀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 稀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 笀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 簀(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 紀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 縀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 缀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 耀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 脀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 舀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 茀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.InterConn {
	public class EntityInterContinueDto
	{
		internal static global::Mass.Domain.Desktop.Entities.InterConn.EntityInterContinueDto ReplaceCollection;
		public global::System.String GameId { get; set; }
		public global::System.String GameType { get; set; }
		public global::System.Boolean StrictMode { get; set; }
		public EntityInterContinueDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckIterablePublisher() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.InterConn.EntityInterContinueDto JoinChooser() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 堀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 夀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 娀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 嬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 尀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte 崀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte 帀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 开(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 怀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 愀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 戀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 挀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 搀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 攀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 昀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 最() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 栀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.InterConn {
	public class EntityInterLoginDto
	{
		internal static global::Mass.Domain.Desktop.Entities.InterConn.EntityInterLoginDto DecorateLocalMap;
		public global::System.Boolean StrictMode { get; set; }
		public EntityInterLoginDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ChangeTester() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.InterConn.EntityInterLoginDto CheckConfigurableWatcher() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 倀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 儀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 刀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 匀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 吀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte 唀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte 嘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte 圀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.InterConn {
	public class EntityInterStartDto
	{
		internal static global::Mass.Domain.Desktop.Entities.InterConn.EntityInterStartDto DecorateSeparatedElement;
		public global::System.String GameId { get; set; }
		public global::System.String GameType { get; set; }
		public global::System.Boolean StrictMode { get; set; }
		public global::System.String[] ItemList { get; set; }
		public EntityInterStartDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean InstantiateDecryptor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.InterConn.EntityInterStartDto PatchError() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 㨀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 㬀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 㰀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 㴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 㸀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 㼀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 䀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 䄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 䈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 䌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 䐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 䔀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 䘀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte 䜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte 䠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte 䤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 䨀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 䬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object 䰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 䴀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 一(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 伀(global::System.Byte p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Game {
	public class EntityGameCharacter
	{
		public global::System.String EntityId { get; set; }
		public global::System.String GameId { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameType GameType { get; set; }
		public global::System.String UserId { get; set; }
		public global::System.String Name { get; set; }
		public global::System.DateTime CreateTime { get; set; }
		public EntityGameCharacter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateScopeObject() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Game.EntityGameCharacter ReflectStaticDecorator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ᨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ᰀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ᴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void Ḁ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ἀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __2(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.DateTime __3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.DateTime __4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.DateTime __5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __6(global::Mass.Domain.Desktop.ValueObjects.EnumGameType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __7(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __8(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __13() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object Ⰰ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ⴀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __14(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __15() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __16() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __17() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __18(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __19(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 㐀(global::System.DateTime p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 㔀(global::System.DateTime p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType 㘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType 㜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType 㠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Entities.Game {
	public class EntityGetGameCharactersDto
	{
		public global::System.Int32 Offset { get; set; }
		public global::System.Int32 Length { get; set; }
		public global::System.String UserId { get; set; }
		public global::System.String GameId { get; set; }
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameType GameType { get; set; }
		public EntityGetGameCharactersDto() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateConcreteSummarizer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Entities.Game.EntityGetGameCharactersDto DecorateConnectedProgram() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object Ā() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object Ȁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 _() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 Ѐ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void Ԁ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __2(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ࠀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __4(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __5(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 __7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __9(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ༀ(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void က(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ᄀ(global::Mass.Domain.Desktop.ValueObjects.EnumGameType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ሀ(global::Mass.Domain.Desktop.ValueObjects.EnumGameType p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ጀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType ᔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType ᘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameType ᜀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __11(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ᤀ(global::System.UInt32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Converters {
	public abstract class GameVersionIdConverter
	{
		internal static global::Mass.Domain.Desktop.Converters.GameVersionIdConverter StoreVisitor;
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion Read(ref global::System.Text.Json.Utf8JsonReader reader, global::System.Type typeToConvert, global::System.Text.Json.JsonSerializerOptions options) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void Write(global::System.Text.Json.Utf8JsonWriter writer, global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion @value, global::System.Text.Json.JsonSerializerOptions serializer) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public GameVersionIdConverter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectEditableAuditor() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Converters.GameVersionIdConverter CheckLogicalDecider() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ________() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _________2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _________3(global::System.Object p0, global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _________4(global::System.Object p0, global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _________5(global::System.Object p0, global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _________6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _________7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion _________8(global::System.IntPtr p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Converters {
	public abstract class GameVersionNameConverter
	{
		public global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion Read(ref global::System.Text.Json.Utf8JsonReader reader, global::System.Type typeToConvert, global::System.Text.Json.JsonSerializerOptions options) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void Write(global::System.Text.Json.Utf8JsonWriter writer, global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion @value, global::System.Text.Json.JsonSerializerOptions options) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public GameVersionNameConverter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ReflectControllableRecord() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Converters.GameVersionNameConverter ReflectTransferableContext() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______豈() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______切() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _______ﬀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void _______ﰀ(global::System.Object p0, global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object _______ﴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::Mass.Domain.Desktop.ValueObjects.EnumGameVersion ________(global::System.IntPtr p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Converters {
	public abstract class SAuthConverter
	{
		internal static global::Mass.Domain.Desktop.Converters.SAuthConverter DecompressObject;
		public global::Mass.Domain.Desktop.Entities.SAuth.EntitySAuth Read(ref global::System.Text.Json.Utf8JsonReader reader, global::System.Type typeToConvert, global::System.Text.Json.JsonSerializerOptions options) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void Write(global::System.Text.Json.Utf8JsonWriter writer, global::Mass.Domain.Desktop.Entities.SAuth.EntitySAuth @value, global::System.Text.Json.JsonSerializerOptions options) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public SAuthConverter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean PresentDecorator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Converters.SAuthConverter CheckCombinedRequester() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte _() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ᤀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte ᨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __2(global::System.Object p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ᰀ(global::System.Object p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ᴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object Ḁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ἀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __3(global::System.IntPtr p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Object __4(global::System.IntPtr p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Converters {
	public abstract class SingleOrArrayConverter<T0>
	{
		public global::System.Collections.Generic.List<T0> Read(ref global::System.Text.Json.Utf8JsonReader reader, global::System.Type typeToConvert, global::System.Text.Json.JsonSerializerOptions options) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void Write(global::System.Text.Json.Utf8JsonWriter writer, global::System.Collections.Generic.List<T0> @value, global::System.Text.Json.JsonSerializerOptions options) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public SingleOrArrayConverter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean ResumeProgram() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object ArrangeTemplate() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Converters {
	public sealed class StringBoolConverter
	{
		internal static global::Mass.Domain.Desktop.Converters.StringBoolConverter CheckEfficientProcessor;
		public global::System.Boolean Read(ref global::System.Text.Json.Utf8JsonReader reader, global::System.Type typeToConvert, global::System.Text.Json.JsonSerializerOptions options) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void Write(global::System.Text.Json.Utf8JsonWriter writer, global::System.Boolean @value, global::System.Text.Json.JsonSerializerOptions options) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Byte ReadNumber(global::System.IntPtr reader) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Byte ReadString(global::System.Object @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public StringBoolConverter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateAttachedContainer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Converters.StringBoolConverter ReflectGlobalConverter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte _(global::System.IntPtr p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __2(global::System.IntPtr p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.Byte __3(global::System.IntPtr p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object __5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte __6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte Ⰰ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void ⴀ(global::System.Object p0, global::System.Byte p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __7(global::System.Object p0, global::System.Byte p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void __8(global::System.Object p0, global::System.Byte p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Byte 㜀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Byte 㠀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.Byte 㨀(global::System.IntPtr p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Converters {
	public sealed class StringIntConverter
	{
		public global::System.Int32 Read(ref global::System.Text.Json.Utf8JsonReader reader, global::System.Type typeToConvert, global::System.Text.Json.JsonSerializerOptions options) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void Write(global::System.Text.Json.Utf8JsonWriter writer, global::System.Int32 @value, global::System.Text.Json.JsonSerializerOptions options) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.UInt32 ParseString(global::System.Object @value) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public StringIntConverter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean CheckDetailedAnnotation() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Converters.StringIntConverter DecorateDividedComparator() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.UInt32 㰀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		private static global::System.UInt32 㴀(global::System.Object p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.UInt32 㼀(global::System.IntPtr p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 䀀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 䄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 䈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 䌀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 䐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 䔀(global::System.Object p0, global::System.UInt32 p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 䘀(global::System.Object p0, global::System.UInt32 p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
namespace Mass.Domain.Desktop.Converters {
	public abstract class TimestampConverter
	{
		public global::System.DateTime Read(ref global::System.Text.Json.Utf8JsonReader reader, global::System.Type typeToConvert, global::System.Text.Json.JsonSerializerOptions options) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public void Write(global::System.Text.Json.Utf8JsonWriter writer, global::System.DateTime @value, global::System.Text.Json.JsonSerializerOptions options) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public TimestampConverter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Boolean DecorateExtendedCommand() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::Mass.Domain.Desktop.Converters.TimestampConverter CheckVisibleConsumer() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 䜀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Byte 䠀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 䤀(global::System.Object p0, global::System.DateTime p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal void 䨀(global::System.Object p0, global::System.DateTime p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 䬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal static global::System.Object 䰀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.DateTime 一(global::System.IntPtr p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		internal global::System.DateTime 伀(global::System.IntPtr p0, global::System.Object p1, global::System.Object p2) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}
internal sealed class _Module__d0ebc330_fd9a_43a2_b162_94426f3b6431__a993
{
	internal global::System.Int32 m_523e38cede7f4cee8e043ac24b557072;
	internal global::System.Int32 m_33ccdb49d2174f0ea12c458bc9b90a02;
	internal global::System.Int32 m_890f96469c814b0287f9058162b075f7;
	internal global::System.Int32 m_8748049810e54ecf834c591927669d7b;
	internal global::System.Int32 m_2567983871c54d14825468a0ba8fccc3;
	internal global::System.Int32 m_d1ef254acc384183b80e3e803a5b1ddb;
	internal global::System.Int32 m_9cc4359cdce04ddea40a2833dc4b9048;
	internal global::System.Int32 m_eac4f53f3b4d44159412c0a3697548d3;
	internal global::System.Int32 m_979ea909993942ab9a184527265b595e;
	internal global::System.Int32 m_a8ff824a931045ac9bc7083555bb3242;
	internal global::System.Int32 m_086f4439fee14ee1a69dfaedd6f2232e;
	internal global::System.Int32 m_cd7eea264b4f4079b95599256c2ace91;
	internal global::System.Int32 m_9e76a9e895a94424b334e9f4be5948ad;
	internal global::System.Int32 m_b0f698688b6f4aeab9c35a8ebd95c962;
	internal global::System.Int32 m_a0b12ecd832b43cca02946de2b9d864c;
	internal global::System.Int32 m_738533136f504cf2a6c521fd99052177;
	internal global::System.Int32 m_69a8e6b01e544632bf41f29c8558e18e;
	internal global::System.Int32 m_6172a4626909473a99923781e8882575;
	internal global::System.Int32 m_614655a6b6024e33a54f8442827502a6;
	internal global::System.Int32 m_965218992140443684ba2db6a6500353;
	internal global::System.Int32 m_dffd185e2ca047cc9d604db5f87ae76d;
	internal global::System.Int32 m_821a72367e004000968fa208d86c362c;
	internal global::System.Int32 m_080fea4a46954257af16ef63f9b06d62;
	internal global::System.Int32 m_0a3a31a83fbe4da5b4cd362b84fd6190;
	internal global::System.Int32 m_6fe9307ae13a49159268126eccabf470;
	internal global::System.Int32 m_7a21fd4a122646598926da6d06fe1a47;
	internal global::System.Int32 m_89eb6b5eb1b84260845102cb7d5123c2;
	internal global::System.Int32 m_611b9ec9fd7b420996db92778d9f56ad;
	internal global::System.Int32 m_ad8e76a7a619451dac9657e5607f30ba;
	internal global::System.Int32 m_70dba263a8cc4e2a8c362910d2c587fd;
	internal global::System.Int32 m_e4c0886fef1c4cd6a14e57b5131a2f4e;
	internal global::System.Int32 m_16660747179347d787836a7d91044ef6;
	internal global::System.Int32 m_6f8877e766374a07b85b08c53bd63bb0;
	internal global::System.Int32 m_1c862c0334fd475daaed07fdea65f85c;
	internal global::System.Int32 m_d8118817f2594edfb32d307933f2c53e;
	internal global::System.Int32 m_654ed13775404819b8d065bf6811271b;
	internal global::System.Int32 m_721d5b742dff4190ba7026472d49bf6a;
	internal global::System.Int32 m_1586348d4c5b441aa7e3b774850a1446;
	internal global::System.Int32 m_3fddd330c2b844dda07b66b1fbadb962;
	internal global::System.Int32 m_c76d6bd9dd91455fad848d42f15fbec8;
	internal static _Module__d0ebc330_fd9a_43a2_b162_94426f3b6431__a993 m_093538511d094ceeacecc9ecf6b946ab;
	internal global::System.Int32 m_8b47180ee4ee46d18c7e26a49324be79;
	internal global::System.Int32 m_fcdcb608a8f545db86db8087d8cb9658;
	internal global::System.Int32 m_1a69b6833d97463f9391740982878d4b;
	internal global::System.Int32 m_9d18f68d29064537b5a8330d57ca3a8c;
	internal global::System.Int32 m_3d27b6043be84f869dfbf31b5498978e;
	internal global::System.Int32 m_71fb5835cda9422aa623c99e8c5f1487;
	internal global::System.Int32 m_850f14b772984d77897d93447c581358;
	internal global::System.Int32 m_eb8bebc21552462e9ca838187c189ccc;
	internal global::System.Int32 m_70845e73420641eaab18f993502fa8ec;
	internal global::System.Int32 m_431d777a710c4a4aa90622319d7079ca;
	internal global::System.Int32 m_686cba73265a4d499bb9ff3007f9d353;
	internal global::System.Int32 m_28a86d9216bd465e9b452f054193382a;
	internal global::System.Int32 m_a62292e675e949288181b6897620fd68;
	internal global::System.Int32 m_47ac35d8c54d4cf8a0ad8fc5b12673a1;
	internal global::System.Int32 m_fe8abbf9f84c45fe82e06bcc401bb252;
	internal global::System.Int32 m_b0addef2a5a34408a62d660aff7ced8a;
	internal global::System.Int32 m_66934f0764024e66a13a9bee1af5d354;
	internal global::System.Int32 m_1ba67f24cbe6497ba68156c1c77b19ee;
	internal global::System.Int32 m_c1aab6b04b5646ae9b90509f6587e821;
	internal global::System.Int32 m_7f62beb9e8ae47e093f94571fe2a3099;
	internal global::System.Int32 m_f9198a522b074ff1917480fd648a6ee0;
	internal global::System.Int32 m_43b8e3cac60b4311b2a6eacb1a9621d8;
	internal global::System.Int32 m_36c0795cdf57494ea0ab2c8df6333024;
	internal global::System.Int32 m_89a37f374d474ddb826881af4d832c8b;
	internal global::System.Int32 m_5132022e9e094bd189f0cf5ae38280dd;
	internal global::System.Int32 m_a30cd9390c294377b246e88c4fa103e8;
	internal global::System.Int32 m_3de983d4978f40a8b85a26712f511768;
	internal global::System.Int32 m_b9e9e7b4436642589ee635df35362974;
	internal global::System.Int32 m_756dc97f13fc48089692d636c1eb2aaf;
	internal global::System.Int32 m_2a893aba637f41e7ad85200a793b4101;
	internal global::System.Int32 m_d9918c4d74a748cb882f63bd510d56b8;
	internal global::System.Int32 m_1d73f669bd084fe9bcb1f794fe876507;
	internal global::System.Int32 m_6db1fdccfbd9454da3fa14688c10c33d;
	internal global::System.Int32 m_93928b7e688d46dc9031abcbae53175a;
	internal global::System.Int32 m_1baf1b490fb14dfba4812430fdb0acbb;
	internal global::System.Int32 m_621b4c84f45a45a3bd47140852f7d7f7;
	internal global::System.Int32 m_ca98cc11dd5e4f8db28fc14db273299d;
	internal global::System.Int32 m_849908711b584dff85e760774ca3e7e7;
	internal global::System.Int32 m_b9a5784c78454b249b01d81fad715f6e;
	internal global::System.Int32 m_6b60c6da5de44fab917cedecd7092ca6;
	internal global::System.Int32 m_5bcfec08d94b477bb805a8aee28eab42;
	internal global::System.Int32 m_d81d00968b804efb90a7658569c7a1cf;
	internal global::System.Int32 m_4b6feeb9fc11428191aeefeb78d33717;
	internal global::System.Int32 m_caa461632cbb4c30a869c1b076c6bf79;
	internal global::System.Int32 m_cc58d8b22c1749819a6a3b9e6d319098;
	internal global::System.Int32 m_2c82aed0b12043b6883ca99cd49af02d;
	internal global::System.Int32 m_bd41a15dfb8b4e66b276f73217be918d;
	internal global::System.Int32 m_9593c3595d25405ba6af011c77e727c5;
	internal global::System.Int32 m_8e850c0dc51045bd91985b424c67c133;
	internal global::System.Int32 m_d2e77f36e328411397c88d89ab61563c;
	internal global::System.Int32 m_24c4ee9cbf194ea8b85b318741f7b5da;
	internal global::System.Int32 m_d4b749674482407380d860551340e52b;
	internal global::System.Int32 m_75d65f7a86ef46dc8fa31bcb8c9ad5bf;
	internal global::System.Int32 m_7334abf5938a44cca85578d102bddda2;
	internal global::System.Int32 m_6286b6b6816e4612b27cbd1b07bb74fb;
	internal global::System.Int32 m_51917b0b5fe841e8876137496ca4239c;
	internal global::System.Int32 m_e8cc419891bc4c0a8f84cff764283321;
	internal global::System.Int32 m_31e7e44d0e484f2fadb4b503e08a4a69;
	internal global::System.Int32 m_faf941caded044bea3c7be8cd1dda202;
	internal global::System.Int32 m_14b6713ba9b644c9bad0caa39b72596b;
	internal global::System.Int32 m_b8ea3a8f18924b73b7303822badee0c5;
	internal global::System.Int32 m_36557cdbbf61484daadf0bf2f990e7c6;
	internal global::System.Int32 m_11dcb273a2614899ab52fba75b207e43;
	internal global::System.Int32 m_ff4dadc8bed74320ae1cdf589655f4e6;
	internal global::System.Int32 m_50c30b727c194bc39551d23e3c220879;
	internal global::System.Int32 m_1761d35ab961422c8d5fdfbf0d482536;
	internal global::System.Int32 m_9c7aa9929fa343338f6a5eb8216684da;
	internal global::System.Int32 m_c4ac77948490424aa46de94203157128;
	internal global::System.Int32 m_1b80db59c9a84b19be0e7f6baa060f9a;
	internal global::System.Int32 m_d1b6272160f9493c842a12b5f18171fd;
	internal global::System.Int32 m_c5d010a00b96422cbb34498dc3f1e7fd;
	internal global::System.Int32 m_36dc47d6b654414a836f323ce80df4c6;
	internal global::System.Int32 m_018679f8b54d43e1814041adc2dd95ac;
	internal global::System.Int32 m_8d2f822d78834b0f8898d377f9ee370e;
	internal global::System.Int32 m_bf9568ded12343ebb774ce3c8531a5f1;
	internal global::System.Int32 m_9ccd6d6cc5274a22a101507bf49dd3c9;
	internal global::System.Int32 m_295207ab865a4587935185c233caae9d;
	internal global::System.Int32 m_5eec0bdfa69a4cf0a929326e48dda555;
	internal global::System.Int32 m_fc846d4cb55d4affbfd9367595bdd88c;
	internal global::System.Int32 m_d4aa0f4f32aa4b78a579c06f13ba6ff0;
	internal global::System.Int32 m_fb53f85e9fda49778d6677661d0324c8;
	internal global::System.Int32 m_c8e74f316cbc4e3ebd777a38182a9ec8;
	internal global::System.Int32 m_9cb8077e2b484e2e974140b7ac9a1faf;
	internal global::System.Int32 m_23f37a3a74f448628a1dfe4510a951ca;
	internal global::System.Int32 m_187ba72a9dcd4a16ab0bebfeec0bf613;
	internal global::System.Int32 m_482670d11a1244549fd4e7475cc2ddd4;
	internal global::System.Int32 m_41f153769d244d41971d106d82bcb115;
	internal global::System.Int32 m_847c25de25384e2d815a970e88364573;
	public _Module__d0ebc330_fd9a_43a2_b162_94426f3b6431__a993() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static void b10c96abd08534fe19838b58dad4f5a5f() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Boolean DecorateStatelessSorter() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static _Module__d0ebc330_fd9a_43a2_b162_94426f3b6431__a993 DecorateScheduledConfig() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Byte 倀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Byte 儀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 刀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 匀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static void 吀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static void 唀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
}

internal sealed class ZYXDNGuarder_a993
{
	internal static global::System.Boolean a;
	internal static global::System.String CheckString(global::System.Int32 p0, global::System.Int32 p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.String CheckString_2(global::System.Int32 p0, global::System.Int32 p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	static ZYXDNGuarder_a993() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	private static global::System.Boolean CheckRuntime(global::System.Int32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	private static global::System.Boolean CheckRuntime64(global::System.Int32 p0) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Boolean RunHVM() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Boolean RunHVM_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static void Startup() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static void RunHVM_3(global::System.IntPtr p0, global::System.IntPtr p1, global::System.IntPtr p2, global::System.Int32 p3) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static void dvm() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 㤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ꨀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _退() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _鄀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _鈀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ___2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____ꀀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____ꄀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____ꈀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____툀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____팀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____퐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____픀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ____혀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _____最() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ______最() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______ᴀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______Ḁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______ἀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ________() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______뤀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _______먀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________13() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________14() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________15() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________16() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________17() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________18() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________19() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________20() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________21() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________22() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________23() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________24() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________25() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________26() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________27() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________28() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________29() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________30() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________31() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________32() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________33() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _________34() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object Ā() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object Ȁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object _() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object Ѐ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object Ԁ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __3() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ࠀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __4() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __5() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __6() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __7() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __8() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __9() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ༀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object က() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ᄀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ሀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ጀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __10() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ᔀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ᘀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object ᜀ() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __11() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __12() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __13() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __14() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __15() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __16() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __17() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object __18() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 㐀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 㔀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 㘀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 㤀_2() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 㬀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 㸀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	internal static global::System.Object 䴀() { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	public sealed class d
	{
		public d(global::System.Object p0, global::System.IntPtr p1) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
		public global::System.IntPtr Invoke(global::System.Object p0, global::System.Int32 p1, global::System.Int32 p2, global::System.IntPtr p3, global::System.Int32 p4) { throw new System.NotImplementedException("未还原 (DNGuard HVM)"); }
	}

}

