using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DotNetty.Buffers;
using Mass.Application.Mobile;
using Mass.Application.Models;
using Mass.Application.Netease;
using Mass.Bedrock.Proxy.Minecraft;
using Mass.Bedrock.Proxy.Network;
using Mass.Bedrock.Proxy.Network.Minecraft.Entities;
using Mass.Bedrock.Proxy.Network.Minecraft.Enums;
using Mass.Bedrock.Proxy.Network.Packet;
using Mass.Bedrock.Proxy.Network.RakNet;
using Mass.Bedrock.Proxy.Network.RakNet.Protocol;
using Mass.Bedrock.Proxy.Packets.Minecraft.PyRpc;
using Mass.Bedrock.Proxy.Packets.RakNet.Offline;
using Mass.Bedrock.Proxy.Packets.RakNet.Online;
using Mass.Common.Extensions;
using Mass.Common.Helpers;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Domain.Mobile.Entities;
using Mass.Domain.Mobile.Entities.Game;
using MessagePack;
using Serilog;

namespace Mass.Bedrock.Proxy.Packets.Minecraft;

[Packet(EnumPacketDirection.Serverbound, 1u)]
public class ServerboundLoginPacket : PacketBase
{
	internal static ServerboundLoginPacket BuildProvider;

	public int ProtocolVersion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00_FF00_FF00_FF00뤀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00븀((uint)value);
		}
	}

	public string ChainData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00딀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00뜀(value);
		}
	}

	public string ClientData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00ꀀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00鸀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Read(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00꼀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00넀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Handle(Connection connection)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00글(connection) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe ServerboundLoginPacket()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		((EntityLaunchBedrockProxy)/*Error near IL_001b: Stack underflow*/).ServerAddress__BackingField = this;
		EntityLaunchBedrockProxy.ReflectScheduledLogger = (EntityLaunchBedrockProxy)(object)this;
		((EntityLaunchBedrockProxy)/*Error near IL_0032: Stack underflow*/).GameId = (string)(object)this;
		int num = 0;
		if (((BedrockProxy)(object)BedrockProxy.Name).GameId == null)
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
	internal static bool ReflectFlexibleBuilder()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerboundLoginPacket CheckSegmentedField()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00鴀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778722, new IntPtr(2737337520044L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00鸀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
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
				((EntityLaunchBedrockProxy)(object)this).Name__BackingField = P_0;
				obj2 = 0;
				if (((EntityLaunchBedrockProxy)EntityLaunchBedrockProxy.ServerAddress__BackingField).ServerPort__BackingField == 0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00鼀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778723, new IntPtr(2737337516924L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00ꀀ()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return ((EntityLaunchBedrockProxy)(object)this).Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00ꄀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778724, new IntPtr(2737337510684L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00글(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_010f: Expected I4, but got Obj
		//IL_014a: Expected Obj, but got I4
		//IL_053a: Expected Obj, but got Ref
		//IL_0784: Expected Obj, but got VT
		//IL_0409: Expected I4, but got Obj
		//IL_041b: Expected Obj, but got I
		//IL_017e: Expected Obj, but got I4
		//IL_05a4: Expected Obj, but got I4
		//IL_01b3: Expected I4, but got Obj
		//IL_01b8: Expected I4, but got Obj
		//IL_01b8: Expected Obj, but got I4
		//IL_0210: Expected Obj, but got I4
		//IL_05d0: Expected Obj, but got I4
		//IL_022d: Expected Obj, but got I
		//IL_0165: Expected Obj, but got I4
		//IL_079b: Expected Obj, but got I8
		//IL_088d: Expected I8, but got Obj
		//IL_0500: Expected Obj, but got I4
		//IL_01e3: Expected Obj, but got I4
		//IL_01f2: Expected Obj, but got I8
		//IL_0466: Expected Obj, but got I4
		//IL_046b: Expected Obj, but got I4
		//IL_07f3: Expected VT, but got Obj
		//IL_07f8: Expected Obj, but got VT
		//IL_07fd: Expected Obj, but got I4
		//IL_07d8: Expected I4, but got Obj
		//IL_07e0: Expected Obj, but got VT
		//IL_0346: Expected VT, but got Obj
		//IL_034b: Expected I8, but got Obj
		//IL_035a: Expected Obj, but got I
		//IL_02f7: Expected I8, but got Obj
		//IL_030b: Expected Obj, but got I4
		//IL_06c4: Expected Obj, but got I4
		//IL_03e2: Expected Obj, but got I4
		//IL_03ef: Expected F4, but got Obj
		//IL_062c: Expected Obj, but got VT
		//IL_0377: Expected Obj, but got I4
		//IL_0395: Expected Obj, but got I8
		//IL_039a: Expected Obj, but got I4
		//IL_03a9: Expected I4, but got Obj
		//IL_03b8: Expected Obj, but got I8
		//IL_04cd: Expected Obj, but got VT
		//IL_04cd: Expected Obj, but got I4
		//IL_057e: Expected Obj, but got I4
		//IL_0497: Expected I4, but got Obj
		//IL_04a2: Expected Obj, but got I4
		//IL_0877: Expected I8, but got Obj
		//IL_07ab: Expected I4, but got Obj
		//IL_0858: Expected VT, but got Obj
		//IL_085d: Expected I4, but got Obj
		//IL_0866: Expected Obj, but got I4
		//IL_0269: Expected Obj, but got I8
		//IL_0594: Expected Obj, but got I4
		//IL_0737->IL0026: Incompatible stack types: I4 vs Obj
		//IL_014f->IL0022: Incompatible stack heights: 3 vs 0
		//IL_0549->IL0026: Incompatible stack types: I4 vs Obj
		//IL_078e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0420->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0188->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0133->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05b0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01cc->IL0026: Incompatible stack heights: 4 vs 1
		//IL_021a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_05d5->IL0022: Incompatible stack heights: 2 vs 0
		//IL_0697->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0199->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0232->IL0026: Incompatible stack types: I4 vs Obj
		//IL_016a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_07a5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04ba->IL0026: Incompatible stack types: I4 vs Obj
		//IL_08a7->IL0026: Incompatible stack heights: 4 vs 1
		//IL_075d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0514->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01f7->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0475->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0811->IL0026: Incompatible stack heights: 2 vs 1
		//IL_07ea->IL0026: Incompatible stack types: I4 vs Obj
		//IL_035f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0310->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06ce->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0291->IL0026: Incompatible stack heights: 2 vs 1
		//IL_04f8->IL0026: Incompatible stack heights: 3 vs 1
		//IL_05f6->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0448->IL0026: Incompatible stack types: I4 vs Obj
		//IL_077c->IL0026: Incompatible stack heights: 2 vs 1
		//IL_03e7->IL0022: Incompatible stack heights: 3 vs 0
		//IL_06e9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0403->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0715->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0562->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0642->IL0026: Incompatible stack heights: 4 vs 1
		//IL_03bd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_04d7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0886->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0490->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0253->IL0026: Incompatible stack types: I4 vs Obj
		//IL_07c6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_066f->IL0026: Incompatible stack heights: 4 vs 1
		//IL_02eb->IL0026: Incompatible stack heights: 3 vs 1
		//IL_026e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0742->IL0026: Incompatible stack types: I4 vs Obj
		//IL_042b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01d7->IL0026: Incompatible stack heights: 4 vs 1
		//IL_06a2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_023d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0175->IL0026: Incompatible stack types: I4 vs Obj
		//IL_051f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0202->IL0026: Incompatible stack heights: 2 vs 1
		//IL_081c->IL0026: Incompatible stack heights: 2 vs 1
		//IL_036a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_031b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0453->IL0026: Incompatible stack types: I4 vs Obj
		//IL_06f4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_064d->IL0026: Incompatible stack heights: 4 vs 1
		//IL_03c8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_083a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_07d1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_067a->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0279->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0845->IL0026: Incompatible stack types: I4 vs Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		object obj = 10;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 9:
					((EntityLaunchBedrockProxy)(object)((EntityLaunchBedrockProxy)(object)((EntityLaunchBedrockProxy)/*Error near IL_0119: Stack underflow*/).EqualityContract).Session).Session = (MobileSession)(object)this;
					((ILogger)/*Error near IL_0129: Stack underflow*/).Debug<int>((string)/*Error near IL_0129: Stack underflow*/, (int)/*Error near IL_0129: Stack underflow*/);
					obj2 = 41;
					continue;
				case 2:
					RuntimeHelpers.EnsureSufficientExecutionStack();
					_ = EqualityComparer<Type>.Default;
					obj = 26;
					break;
				case 18:
					obj = new EqualityComparer<Type>((Type)/*Error near IL_0154: Stack underflow*/);
					obj2 = 24;
					if (((BedrockProxy)BedrockProxy.GameType).ServerAddress == null)
					{
						obj2 = 49;
					}
					continue;
				case 8:
					obj = ((BedrockProxy)obj).ServerPort;
					obj2 = 19;
					continue;
				case 16:
					((EntityLaunchBedrockProxy)/*Error near IL_018d: Stack underflow*/).ServerAddress = (string)/*Error near IL_018d: Stack underflow*/;
					obj = (object)/*Error near IL_018f: Stack underflow*/;
					obj2 = 54;
					continue;
				case 11:
					_ = EqualityComparer<EnumGameType>.Default;
					((EqualityComparer<EnumGameType>)0).Equals((EnumGameType)((BedrockProxy)P_0).Listener__BackingField, (EnumGameType)((EqualityComparer<int>)obj).GetHashCode((int)EqualityComparer<int>.Default));
					_ = 3;
					if (((ConnectedPing)BedrockProxy.CloneProxy).ClientTimestamp__BackingField != 0L)
					{
						_ = 23;
					}
					continue;
				case 24:
					((EntityLaunchBedrockProxy)/*Error near IL_01e3: Stack underflow*/).Equals((EntityLaunchBedrockProxy?)((EntityLaunchBedrockProxy)/*Error near IL_01de: Stack underflow*/).Equals(obj));
					_ = 25;
					if (ConnectedPong.CheckCustomizableNode == null)
					{
						_ = 40;
					}
					continue;
				case 12:
					((EntityLaunchBedrockProxy)/*Error near IL_0209: Stack underflow*/).Deconstruct(out *(MobileSession*)/*Error near IL_0209: Stack underflow*/, out *(string*)/*Error near IL_0209: Stack underflow*/, out *(EnumGameType*)/*Error near IL_0209: Stack underflow*/, out *(string*)/*Error near IL_0209: Stack underflow*/, out *(string*)/*Error near IL_0209: Stack underflow*/, out *(int*)obj);
					obj = ((IEnumerable<uint>)/*Error near IL_020e: Stack underflow*/).Last();
					obj2 = 27;
					continue;
				case 17:
					obj = obj;
					obj2 = 8;
					if (ConnectionRequest.CheckHiddenCollector != null)
					{
						obj2 = 8;
					}
					continue;
				case 49:
					((Exception)obj)._002Ector((string?)(object)BedrockProxy.Logger);
					obj2 = 52;
					continue;
				case 56:
					((BedrockProxy)/*Error near IL_0258: Stack underflow*/).Listener = (RakNetServer?)/*Error near IL_0258: Stack underflow*/;
					obj = (object)/*Error near IL_025a: Stack underflow*/;
					obj2 = 0;
					if (ConnectionRequestAccepted.DecorateRandomExtractor != null)
					{
						obj2 = 0;
					}
					continue;
				case 32:
					IPAddress.TryParse((string?)obj, out *(IPAddress?*)Enumerable.ToArray<TSource>((IEnumerable<TSource>)obj));
					_ = 2;
					continue;
				case 7:
					GC.SuppressFinalize(obj);
					/*Error near IL_0298: Member reference must be method, but was: Field*/;
				case 53:
					obj = ((IByteBuffer)/*Error near IL_02cd: Stack underflow*/).WriteLong(((IByteBuffer)obj).ReadLong());
					((IByteBuffer)(*(Jwt<, >*)/*Error near IL_02dc: Stack underflow*/)/*cast due to constrained. prefix*/).WriteBoolean((byte)(&obj) != 0);
					BedrockProxy.ReflectOperationalReg();
					_ = 31;
					continue;
				case 30:
					((ConnectedPing)/*Error near IL_02f7: Stack underflow*/).ClientTimestamp = (long)IPAddress.Parse((string)obj);
					((ConnectedPing)/*Error near IL_02fc: Stack underflow*/).Read((IByteBuffer)/*Error near IL_02fc: Stack underflow*/);
					obj2 = 34;
					if (((OpenConnectionReply1)OpenConnectionReply1.Cookie__BackingField).MtuSize__BackingField == 0)
					{
						obj2 = 9;
					}
					continue;
				case 14:
				case 29:
					((ConnectedPong)/*Error near IL_034b: Stack underflow*/).ClientTimestamp = (long)(object)(Guid)obj;
					obj2 = 36;
					if (OpenConnectionReply2.ReflectLocalTransmitter != null)
					{
						obj2 = 36;
					}
					continue;
				case 43:
					((ConnectedPong)((IByteBuffer)obj).ReadByte()).Write((IByteBuffer)P_0);
					obj = (object)/*Error near IL_0379: Stack underflow*/;
					((ConnectionRequest)(object)((IByteBuffer)(*(AsyncUdpClient._003C_003Ec__DisplayClass11_0*)/*Error near IL_0386: Stack underflow*/)/*cast due to constrained. prefix*/).WriteInt((int)(&obj))).Time = ((ConnectionRequest)((List<AckRange>)((ConnectionRequest)(object)ConnectedPong.ReflectExpandableBuffer()).Guid).Count).Time;
					((ConnectionRequest)/*Error near IL_03a9: Stack underflow*/).UseEncryption = (byte)(int)((Jwt<AlgorithmHeader, SaltPayload>)/*Error near IL_03a4: Stack underflow*/).Header != 0;
					obj2 = 3;
					if (UnconnectedPing.DecorateDynamicHandler != null)
					{
						obj2 = 22;
					}
					continue;
				case 37:
					((IByteBuffer)obj).ReadFloatLE();
					ConnectionRequest.ReflectAdjustableOrder();
					ConnectionRequest.ReflectGenericProxy();
					obj = 47;
					break;
				case 39:
					((ConnectionRequestAccepted)/*Error near IL_03f4: Stack underflow*/).ClientAddress = (IPEndPoint)(object)((IByteBuffer)P_0).WriteFloatLE((float)obj);
					_ = ((ConnectionRequestAccepted)/*Error near IL_03f9: Stack underflow*/).SystemIndex;
					_ = 33;
					continue;
				case 5:
					((ConnectionRequestAccepted)/*Error near IL_0409: Stack underflow*/).SystemIndex = (ushort)(int)this;
					obj = (object)/*Error near IL_040c: Stack underflow*/;
					obj2 = 6;
					if (((ClientboundDisconnectPacket)ClientboundDisconnectPacket.SkipMessage__BackingField).Message__BackingField != null)
					{
						obj2 = 12;
					}
					continue;
				case 35:
					obj = ((IByteBuffer)/*Error near IL_0432: Stack underflow*/).WriteShortLE((int)(&obj));
					obj2 = 1;
					if (((ClientboundHandshakePacket)(object)ClientboundDisconnectPacket.CheckTransformableEncryptor).JwtData__BackingField == null)
					{
						obj2 = 11;
					}
					continue;
				case 25:
					((DisconnectionNotification)((ClientboundHandshakePacket)P_0).ServerSessionKey__BackingField).Read((IByteBuffer)(object)((List<PackEntry>)((IByteBuffer)obj).ReadIntLE()).Count);
					_ = 28;
					continue;
				case 48:
					((DisconnectionNotification)(object)((List<PackEntry>.Enumerator*)obj)->Current)._002Ector();
					_ = ((FrameSetPacket)/*Error near IL_0486: Stack underflow*/).SequenceNumber;
					_ = 38;
					continue;
				case 46:
					obj = ((IByteBuffer)/*Error near IL_0497: Stack underflow*/).WriteIntLE((int)obj);
					obj = 18;
					break;
				case 20:
					obj = ((List<Experiment>.Enumerator*)obj)->Current;
					obj2 = 46;
					continue;
				case 44:
					((FrameSetPacket)((List<Experiment>.Enumerator*)obj)->MoveNext()).Write((IByteBuffer)(object)((List<Experiment>)obj).GetEnumerator());
					obj2 = 43;
					continue;
				case 33:
					((List<Experiment>)obj)._002Ector();
					_ = ((ClientboundResourcePacksInfoPacket)P_0).HasScripts__BackingField;
					_ = ((GamePacket)(object)Encoding.UTF8).Data;
					_ = 48;
					continue;
				case 23:
					((GamePacket)obj).Data = (byte[])0;
					obj2 = 55;
					if (((ClientboundResourcePackStackPacket)(object)ClientboundResourcePacksInfoPacket.CheckFilteredAttribute).MustAccept__BackingField == 0)
					{
						obj2 = 50;
					}
					continue;
				case 3:
					((EntityAuthenticationDto)/*Error near IL_0526: Stack underflow*/).PatchVersion = (string)obj;
					((EntityAuthenticationDto)/*Error near IL_052b: Stack underflow*/)._002Ector();
					obj = (object)/*Error near IL_052d: Stack underflow*/;
					((List<string>)(object)(*(InvalidDataException*)/*Error near IL_053a: Stack underflow*/)/*cast due to constrained. prefix*/).Insert((int)/*Error near IL_053a: Stack underflow*/, (string)(&obj));
					((NewIncomingConnection)/*Error near IL_053f: Stack underflow*/).ServerAddress = (IPEndPoint)/*Error near IL_053f: Stack underflow*/;
					obj2 = 37;
					continue;
				case 41:
					((NewIncomingConnection)/*Error near IL_0553: Stack underflow*/).RequestTimestamp = ((NewIncomingConnection)/*Error near IL_054e: Stack underflow*/).RequestTimestamp;
					((EntityAuthenticationDto)/*Error near IL_0558: Stack underflow*/).OsName = (string)/*Error near IL_0558: Stack underflow*/;
					obj2 = 4;
					continue;
				case 45:
					((NewIncomingConnection)(object)((Jwt<AlgorithmHeader, ClientPayload>)obj).Payload).Write((IByteBuffer)ClientboundStartGamePacket.DecorateIdentifiableInterpreter);
					obj = 25;
					break;
				case 6:
					if ((nint)obj != 8)
					{
						obj = 14;
						break;
					}
					goto case 56;
				case 10:
					obj = PyRpcPacket.InvokeResponder;
					obj2 = 9;
					continue;
				case 13:
					_ = ((NeteaseSession)(object)((Jwt<AlgorithmHeader, ChainPayload>)(object)((TaskAwaiter<EntityAuthentication>*)((ServerboundClientCacheStatusPacket)P_0).Enabled__BackingField)->GetResult()).Payload).Token;
					obj = 42;
					break;
				case 34:
				{
					string userId = ((NeteaseSession)obj).UserId;
					((AlreadyConnected)P_0)._002Ector();
					((ILogger)/*Error near IL_05e7: Stack underflow*/).Debug(userId);
					AlreadyConnected.ExecuteTemplate();
					_ = 45;
					continue;
				}
				case 42:
					obj = ((EntityPatchInfo)((Task<EntityAuthentication>)obj).GetAwaiter()).EngineVersion;
					_ = 0;
					if (((ClientboundGetMcpCheckNumPacket)ClientboundGetMcpCheckNumPacket.McpData__BackingField).McpCheckNum__BackingField != null)
					{
						_ = 35;
					}
					continue;
				case 52:
					JsonHelper.Serialize(NeteaseMobile.Instance);
					_ = 9;
					if (((ClientboundHeartBeatPacket)(object)ClientboundGetStartTypePacket.ReflectIsolatedAggregator).Content__BackingField == null)
					{
						_ = 17;
					}
					continue;
				case 15:
					obj = ClientboundHeartBeatPacket.ReflectIntegratedTransmitter;
					obj2 = 5;
					if (ServerboundHeartBeatPacket.StopIterator != null)
					{
						obj2 = 0;
					}
					continue;
				case 31:
					Jwt<AlgorithmHeader, ChainPayload>.Parse((string)obj);
					_ = ((OpenConnectionReply1)uint.Parse((string)obj)).MtuSize;
					_ = 44;
					continue;
				case 38:
					obj = ((Jwt<AlgorithmHeader, ClientPayload>)/*Error near IL_06d3: Stack underflow*/).Header;
					obj2 = 20;
					if (((Experiment)ByteArray.QueryAuthenticator).Name__BackingField == null)
					{
						obj2 = 4;
					}
					continue;
				case 40:
					((List<string>)obj).GetEnumerator();
					_ = ((OpenConnectionReply2)(object)(OpenConnectionReply1.CheckIterableTag() ? ((List<string>.Enumerator*)1) : ((List<string>.Enumerator*)null))->Current).Guid;
					_ = 51;
					continue;
				case 1:
					((List<object>)obj).Add(((PackEntry)obj).Version__BackingField);
					obj2 = 11;
					if (PackEntryCodec.DecorateSetAllocator == null)
					{
						obj2 = 13;
					}
					continue;
				case 22:
					((OpenConnectionReply2)/*Error near IL_0753: Stack underflow*/).EncryptionEnabled = ((OpenConnectionReply2)(object)((string)obj).HexToBytes()).EncryptionEnabled;
					obj2 = 3;
					continue;
				default:
					((OpenConnectionReply2)obj).Read((IByteBuffer)obj);
					((Dictionary<object, object>)/*Error near IL_076d: Stack underflow*/)[(object)/*Error near IL_076d: Stack underflow*/] = obj;
					_ = (string?)/*Error near IL_0772: Stack underflow*/ == (string?)/*Error near IL_0772: Stack underflow*/;
					_ = 32;
					continue;
				case 4:
					obj = ((TexturePack)P_0).Uuid__BackingField;
					obj2 = 15;
					continue;
				case 19:
					obj = ((TexturePack)((TexturePack)P_0).Version__BackingField).Size__BackingField;
					obj2 = 50;
					continue;
				case 51:
					((OpenConnectionRequest1)/*Error near IL_07ab: Stack underflow*/).ProtocolVersion = (byte)(int)this;
					((InvalidOperationException)/*Error near IL_07b0: Stack underflow*/)._002Ector((string?)/*Error near IL_07b0: Stack underflow*/);
					obj = (object)/*Error near IL_07b2: Stack underflow*/;
					obj2 = 21;
					if (((TexturePack)TexturePack.ContentIdentity__BackingField).HasScripts__BackingField == 0)
					{
						obj2 = 6;
					}
					continue;
				case 27:
					((DefaultInterpolatedStringHandler*)/*Error near IL_07d8: Stack underflow*/)->_002Ector((int)/*Error near IL_07d8: Stack underflow*/, (int)obj);
					obj = (ReadOnlyMemory<byte>)(byte[]?)/*Error near IL_07de: Stack underflow*/;
					obj2 = 39;
					continue;
				case 26:
					string.IsNullOrEmpty((string?)MessagePackSerializer.Deserialize<_0021_00210>((ReadOnlyMemory<byte>)/*Error near IL_07f3: Stack underflow*/, (MessagePackSerializerOptions)obj, (CancellationToken)obj)).GetType();
					_ = 1;
					if (Uuid.InstantiateProcessor == null)
					{
						_ = 1;
					}
					continue;
				case 28:
					return 0;
				case 50:
					if ((nint)obj != 2)
					{
						obj2 = 6;
						if ((int)((WorldTemplate)(object)VarInt.AddVerifier).Uuid__BackingField != 0)
						{
							obj2 = 2;
						}
						continue;
					}
					goto case 16;
				case 55:
				{
					object obj3 = obj;
					((OpenConnectionRequest2)obj).Address = (IPEndPoint)(object)MessagePackSerializerOptions.Standard;
					((OpenConnectionRequest2)/*Error near IL_085d: Stack underflow*/).Mtu = (ushort)(int)((MessagePackSerializerOptions)/*Error near IL_0858: Stack underflow*/).WithOldSpec((bool?)obj3);
					obj = 24;
					break;
				}
				case 47:
					((OpenConnectionRequest2)/*Error near IL_0877: Stack underflow*/).Guid = (long)((KeyValuePair<object, object>*)obj)->Value;
					((OpenConnectionRequest2)/*Error near IL_087c: Stack underflow*/).Read((IByteBuffer)/*Error near IL_087c: Stack underflow*/);
					obj2 = 30;
					continue;
				case 21:
					((IByteBuffer)/*Error near IL_088d: Stack underflow*/).WriteLongLE((long)obj);
					_ = (ReadOnlySpan<byte>)(byte[]?)(object)AsyncUdpClient._003C_003Ec._003C_003E9;
					OpenConnectionRequest2.ReflectStaticState();
					_ = 7;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00꼀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_00d9: Expected I4, but got Obj
		//IL_00de: Expected I4, but got Obj
		//IL_00e3: Expected Obj, but got I4
		//IL_00f2: Expected Obj, but got I8
		//IL_004c: Expected I4, but got Obj
		//IL_0060: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I4
		//IL_00f7->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00c1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0065->IL0026: Incompatible stack heights: 2 vs 1
		//IL_009b->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0102->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00cc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0070->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a6->IL0026: Incompatible stack heights: 4 vs 1
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				return;
			case 3:
				_ = ((EntityLaunchBedrockProxy)(object)((StringBuilder)(object)this).Append((char)(int)P_0)).Session;
				_ = 2;
				if ((object)EntityLaunchBedrockProxy.ReflectScheduledLogger == null)
				{
					_ = 0;
				}
				break;
			case 4:
				RuntimeHelpers.EnsureSufficientExecutionStack();
				_ = ((EntityLaunchBedrockProxy)((EqualityComparer<Type>)P_0).GetHashCode((Type)(object)EqualityComparer<Type>.Default)).Name;
				_ = 0;
				if (((BedrockProxy)(object)BedrockProxy.ServerAddress).ServerPort == 0)
				{
					_ = 1;
				}
				break;
			case 2:
				((EntityLaunchBedrockProxy)/*Error near IL_00ac: Stack underflow*/).ServerAddress = (string)P_0;
				obj2 = 0;
				if (((BedrockProxy)(object)BedrockProxy.PatchInfo).Listener__BackingField == null)
				{
					obj2 = 0;
				}
				break;
			default:
				_ = (EntityLaunchBedrockProxy?)/*Error near IL_00e3: Stack underflow*/ == (EntityLaunchBedrockProxy?)((EqualityComparer<EnumGameType>)(object)this).Equals((EnumGameType)P_0, (EnumGameType)((EqualityComparer<int>)P_0).GetHashCode((int)EqualityComparer<int>.Default));
				_ = 0;
				if (ConnectedPing.DecorateVirtualExecutor != null)
				{
					_ = 4;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00뀀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778725, new IntPtr(2737337520044L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00넀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_004f: Expected I4, but got Obj
		//IL_00b4: Expected Obj, but got I4
		//IL_0158: Expected Obj, but got I4
		//IL_012f: Expected Obj, but got I4
		//IL_00fe: Expected I4, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_0069->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_016d->IL0026: Incompatible stack heights: 2 vs 1
		//IL_009c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00eb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0143->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0080->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0113->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0178->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00f6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_014e->IL0026: Incompatible stack heights: 3 vs 1
		//IL_011e->IL0026: Incompatible stack types: I4 vs Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				((StringBuilder)P_0).Append((char)((Array)obj).Length);
				obj2 = 7;
				break;
			case 6:
				((object)((EntityLaunchBedrockProxy)(object)this).Session).ToString();
				_ = 5;
				break;
			case 3:
				((EntityLaunchBedrockProxy)(object)((StringBuilder)/*Error near IL_0085: Stack underflow*/).Append((object?)/*Error near IL_0085: Stack underflow*/)).GameId = (string)(object)this;
				obj = EqualityComparer<Type>.Default;
				obj2 = 6;
				break;
			case 1:
				((EqualityComparer<Type>)P_0).GetHashCode((Type)obj);
				obj2 = 0;
				if (((BedrockProxy)BedrockProxy.GameType).ServerAddress == null)
				{
					obj2 = 0;
				}
				break;
			case 8:
				return;
			case 4:
				((EntityLaunchBedrockProxy)(object)EqualityComparer<string>.Default).ServerAddress = (string)(object)this;
				obj = EqualityComparer<EnumGameType>.Default;
				obj2 = 0;
				if (((BedrockProxy)BedrockProxy.Listener__BackingField).EndPoints__BackingField == null)
				{
					obj2 = 3;
				}
				break;
			case 7:
				((EqualityComparer<int>)P_0).GetHashCode((int)obj);
				obj2 = 4;
				if (BedrockProxy.CloneProxy == null)
				{
					obj2 = 8;
				}
				break;
			case 5:
				((EntityLaunchBedrockProxy)(((Array)obj).Length + ((Array)obj).Length + 8)).GetHashCode();
				_ = 1;
				if (((ConnectedPong)(object)ConnectedPing.DecorateVirtualExecutor).ClientTimestamp__BackingField == 0L)
				{
					_ = 2;
				}
				break;
			case 2:
				_ = ((MobileSession)((Array)obj).Length).PatchInfo;
				_ = 1;
				if (((ConnectionRequest)(object)ConnectedPong.CheckCustomizableNode).Guid__BackingField == 0L)
				{
					_ = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00눀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778726, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00대()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (EntityLaunchBedrockProxy.Name__BackingField == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00됀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778727, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00딀()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return ((EntityLaunchBedrockProxy)(object)this).Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00똀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778728, new IntPtr(2737337520044L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00뜀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
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
				((EntityLaunchBedrockProxy)(object)this).Name__BackingField = P_0;
				obj2 = 0;
				if (((EntityLaunchBedrockProxy)EntityLaunchBedrockProxy.ServerAddress__BackingField).ServerPort__BackingField != 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00렀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778729, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00뤀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected I4, but got Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (uint)(int)((EntityLaunchBedrockProxy)(object)this).Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00먀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778730, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00묀()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return EntityLaunchBedrockProxy.Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00밀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778731, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00봀(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778732, new IntPtr(2737337523164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00븀(uint P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected Obj, but got I4
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
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
				((EntityLaunchBedrockProxy)(object)this).Name__BackingField = P_0;
				obj2 = 0;
				if (((EntityLaunchBedrockProxy)EntityLaunchBedrockProxy.ServerAddress__BackingField).ServerPort__BackingField != 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}
}
