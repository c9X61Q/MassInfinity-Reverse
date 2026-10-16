using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Mass.Application.Mobile;
using Mass.Application.Models;
using Mass.Bedrock.Proxy.Minecraft;
using Mass.Bedrock.Proxy.Network.Minecraft.Enums;
using Mass.Bedrock.Proxy.Network.Packet;
using Mass.Bedrock.Proxy.Network.RakNet;
using Mass.Bedrock.Proxy.Packets.RakNet.Online;

namespace Mass.Bedrock.Proxy.Packets.Minecraft.PyRpc;

[PyRpcPacket(EnumPacketDirection.Clientbound, "S2CHeartBeat")]
public class ClientboundHeartBeatPacket : PyRpcPacketBase
{
	private static object ReflectIntegratedTransmitter;

	public Dictionary<object, object> Content
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᄀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00Ā(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Deserialize(List<object> payload)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00_0600(payload);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Serialize(List<object> payload)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00_0300(payload);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Handle(Connection connection)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0E00(connection) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe ClientboundHeartBeatPacket()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001a: Expected I4, but got Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		((EntityLaunchBedrockProxy)/*Error near IL_001f: Stack underflow*/).ServerAddress__BackingField = new StringBuilder((char)(int)this);
		((EntityLaunchBedrockProxy)/*Error near IL_002a: Stack underflow*/).Session = (MobileSession)(object)this;
		int num = 0;
		if (BedrockProxy.Logger__BackingField == null)
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
	internal static bool AwakeProxy()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ClientboundHeartBeatPacket CloneExtractor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00(Dictionary<object, object> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778637, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ā(Dictionary<object, object> P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ȁ(List<object> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778638, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0300(List<object> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0054: Expected Obj, but got I
		//IL_0059->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0064->IL0026: Incompatible stack heights: 2 vs 1
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
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
				((StringBuilder)(object)((EntityLaunchBedrockProxy)(object)this).EqualityContract)._002Ector();
				_ = 0;
				if ((object)EntityLaunchBedrockProxy.ReflectScheduledLogger == null)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ѐ()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (EntityLaunchBedrockProxy.Name__BackingField == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ԁ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778639, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0600(List<object> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0069->IL0026: Incompatible stack types: I4 vs Obj
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
				((EntityLaunchBedrockProxy)(object)this).Session = (MobileSession)(object)(EqualityComparer<int>)(object)((StringBuilder)(object)P_0).Append('\0');
				obj2 = 0;
				if (BedrockProxy.Logger__BackingField != null)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0700(List<object> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778640, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0D00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778641, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0E00(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0057: Expected I4, but got Obj
		//IL_012a: Expected Obj, but got I8
		//IL_012f: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I4
		//IL_0165: Expected Obj, but got I
		//IL_016a: Expected I, but got Obj
		//IL_016a: Expected Obj, but got I4
		//IL_018d: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		//IL_0148->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00f4->IL0026: Incompatible stack heights: 2 vs 1
		//IL_01f5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0083->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0192->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0153->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008e->IL0026: Incompatible stack heights: 4 vs 1
		//IL_00ce->IL0026: Incompatible stack types: I4 vs Obj
		//IL_019d->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00d9->IL0026: Incompatible stack types: I4 vs Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 6:
				_ = 0;
				((EntityLaunchBedrockProxy)(object)new EntityLaunchBedrockProxy()).Session = new EntityLaunchBedrockProxy();
				_ = 7;
				if (BedrockProxy.Logger__BackingField == null)
				{
					_ = 1;
				}
				break;
			case 4:
				if (((EqualityComparer<Type>)/*Error near IL_009a: Stack underflow*/).GetHashCode((Type)((EntityLaunchBedrockProxy)obj).GameType) == 0)
				{
					obj2 = 8;
					break;
				}
				goto case 1;
			case 8:
			case 9:
				if (((EqualityComparer<MobileSession>)/*Error near IL_00b5: Stack underflow*/).GetHashCode((MobileSession)(object)((EntityLaunchBedrockProxy)obj).Name) == 0)
				{
					obj2 = 1;
					if (((BedrockProxy)BedrockProxy.ServerPort).Session == null)
					{
						obj2 = 2;
					}
					break;
				}
				goto case 10;
			case 1:
				((EntityLaunchBedrockProxy)/*Error near IL_00e5: Stack underflow*/).ServerPort = ((EntityLaunchBedrockProxy)obj).ServerPort;
				_ = EqualityComparer<int>.Default;
				_ = 9;
				break;
			default:
				_ = ((MobileSession)((Type?)((EntityLaunchBedrockProxy?)/*Error near IL_011f: Stack underflow*/ == (EntityLaunchBedrockProxy?)obj) == (Type?)(object)ConnectedPing.DecorateVirtualExecutor)).PatchInfo;
				_ = 0;
				if (((ConnectionRequest)(object)ConnectedPong.CheckCustomizableNode).Guid__BackingField != 0L)
				{
					_ = 6;
				}
				break;
			case 10:
				((Action<RakNetSession>)obj)._002Ector((object)EntityLaunchBedrockProxy.AssembleCollector(), (nint)ConnectionRequest.CheckHiddenCollector);
				Enumerable.Select<TSource, TResult>((IEnumerable<TSource>)/*Error near IL_017e: Stack underflow*/, (Func<TSource, TResult>)(object)Dns.GetHostAddresses((string)(object)((BedrockProxy)/*Error near IL_016f: Stack underflow*/).Listener));
				_ = 0;
				if (((FrameSetPacket)FrameSetPacket.SequenceNumber__BackingField).Frames__BackingField == null)
				{
					_ = 3;
				}
				break;
			case 7:
				return 1;
			case 2:
			case 3:
				_ = ((BedrockProxy)obj).ProxyPort;
				/*Error near IL_01b5: Member reference must be method, but was: Field*/;
			case 5:
				((BedrockProxy)/*Error near IL_01e4: Stack underflow*/).OnConnected((object)this);
				obj = ((MemberInfo)/*Error near IL_01e9: Stack underflow*/).GetCustomAttribute<RakNetPacketAttribute>();
				obj2 = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00ༀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778642, new IntPtr(2737337517964L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Dictionary<object, object> _FF00_FF00_FF00_FF00_FF00_FF00_FF00က()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778643, new IntPtr(2737337529404L), 15))(null, 0, new IntPtr(0L));
		return (Dictionary<object, object>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Dictionary<object, object> _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᄀ()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (Dictionary<object, object>)((EntityLaunchBedrockProxy)(object)this).Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ሀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778644, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ጀ()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return EntityLaunchBedrockProxy.Name__BackingField;
	}
}
