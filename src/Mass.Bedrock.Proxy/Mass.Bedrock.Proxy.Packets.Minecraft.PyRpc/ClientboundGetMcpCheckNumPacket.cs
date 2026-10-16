using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Mass.Application.Mobile;
using Mass.Application.Models;
using Mass.Bedrock.Proxy.Minecraft;
using Mass.Bedrock.Proxy.Network.Minecraft.Entities.PyRpc;
using Mass.Bedrock.Proxy.Network.Minecraft.Enums;
using Mass.Bedrock.Proxy.Network.Packet;
using Mass.Bedrock.Proxy.Network.RakNet.Protocol;
using Mass.Bedrock.Proxy.Packets.RakNet.Online;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Domain.Mobile.Entities;

namespace Mass.Bedrock.Proxy.Packets.Minecraft.PyRpc;

[PyRpcPacket(EnumPacketDirection.Clientbound, "GetMCPCheckNum")]
public class ClientboundGetMcpCheckNumPacket : PyRpcPacketBase
{
	private static object DecorateModularListener;

	public string McpData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00_E600();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_ED00(value);
		}
	}

	public McpCheckNum McpCheckNum
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (McpCheckNum)_FF00_FF00_FF00_FF00_FF00_FF00_EB00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_E500(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Deserialize(List<object> payload)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_EF00(payload);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Serialize(List<object> payload)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_E400(payload);
	}

	public override bool Handle(Connection connection)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe ClientboundGetMcpCheckNumPacket()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		((EntityLaunchBedrockProxy)/*Error near IL_001b: Stack underflow*/).ServerAddress__BackingField = this;
		EntityLaunchBedrockProxy.ReflectScheduledLogger = (EntityLaunchBedrockProxy)new EntityLaunchBedrockProxy((MobileSession)(object)this);
		((EntityLaunchBedrockProxy)/*Error near IL_0036: Stack underflow*/).GameId = (string)(object)this;
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
	internal static bool LeadInterpreter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ClientboundGetMcpCheckNumPacket CollectNode()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_E300(List<object> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778624, new IntPtr(2737337524204L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_E400(List<object> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0050: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got Unknown
		//IL_006c: Expected Obj, but got I4
		//IL_006d: Expected Obj, but got Unknown
		//IL_0086->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00b2->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0091->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00bd->IL0026: Incompatible stack heights: 2 vs 1
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			case 2:
				return;
			case 1:
				((EntityLaunchBedrockProxy)(object)P_0).ServerAddress = (string)(object)this;
				_ = EqualityComparer<EnumGameType>.Default;
				_ = 0;
				if (((BedrockProxy)BedrockProxy.Listener__BackingField).EndPoints__BackingField == null)
				{
					_ = 0;
				}
				continue;
			}
			Enum[] array = new Enum[3];
			((EntityLaunchBedrockProxy)0).Session = ((EntityLaunchBedrockProxy)(object)this).Session;
			((object[])(object)P_0)[(object)array] = array;
			_003F val = /*Error near IL_0051: Stack underflow*/;
			((EntityLaunchBedrockProxy)1).GameId = ((EntityLaunchBedrockProxy)(object)this).GameId;
			((object[])/*Error near IL_005f: Stack underflow*/)[/*Error near IL_005f: Stack underflow*/] = (object)val;
			_003F val2 = /*Error near IL_005f: Stack underflow*/;
			((EntityLaunchBedrockProxy)2).GameType = ((EntityLaunchBedrockProxy)(object)this).GameType;
			((object[])/*Error near IL_006d: Stack underflow*/)[/*Error near IL_006d: Stack underflow*/] = (object)val2;
			_ = EqualityComparer<MobileSession>.Default;
			_ = 2;
			if (((BedrockProxy)(object)BedrockProxy.ServerAddress).ServerPort == 0)
			{
				_ = 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_E500(object P_0)
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
				if (((EntityLaunchBedrockProxy)EntityLaunchBedrockProxy.ServerAddress__BackingField).ServerPort__BackingField == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_E600()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return ((EntityLaunchBedrockProxy)(object)this).Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_E700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778625, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_E800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778626, new IntPtr(2737337511724L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_E900()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (EntityLaunchBedrockProxy.Name__BackingField == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_EA00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778627, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_EB00()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return ((EntityLaunchBedrockProxy)(object)this).Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_EC00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778628, new IntPtr(2737337516924L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_ED00(object P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_EE00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778629, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_EF00(List<object> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_00c2: Expected Obj, but got VT
		//IL_011a: Expected Obj, but got I4
		//IL_011f: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I4
		//IL_00f3: Expected Obj, but got I4
		//IL_00d6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0107->IL0026: Incompatible stack heights: 4 vs 1
		//IL_006a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ae->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00e1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0112->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0085->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0090->IL0026: Incompatible stack types: I4 vs Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
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
				case 3:
					((EntityLaunchBedrockProxy)(object)((EntityLaunchBedrockProxy)(object)this).EqualityContract).Session = (MobileSession)(object)(EqualityComparer<int>)((object[])obj)[1];
					obj2 = 5;
					continue;
				case 6:
					if (obj != null)
					{
						obj2 = 0;
						if (BedrockProxy.Logger__BackingField == null)
						{
							obj2 = 0;
						}
						continue;
					}
					return;
				case 5:
					_ = ((EntityLaunchBedrockProxy)(object)this).GameType;
					_ = ((EntityLaunchBedrockProxy)(object)(List<Frame>)((object[])obj)[2]).Name;
					_ = 4;
					continue;
				default:
					((EntityLaunchBedrockProxy)/*Error near IL_00b4: Stack underflow*/).Name = (string)(object)this;
					((EntityLaunchBedrockProxy)/*Error near IL_00c2: Stack underflow*/).ServerAddress = (string)(RuntimeTypeHandle)((object[])obj)[0];
					obj2 = 3;
					if (((BedrockProxy)(object)BedrockProxy.PatchInfo).Listener__BackingField != null)
					{
						obj2 = 2;
					}
					continue;
				case 2:
					_ = (EntityLaunchBedrockProxy?)0 != (EntityLaunchBedrockProxy?)(object)(RuntimeHelpers)(object)EqualityComparer<int>.Default;
					_ = 1;
					if (((ConnectedPing)BedrockProxy.CloneProxy).ClientTimestamp__BackingField == 0L)
					{
						_ = 0;
					}
					continue;
				case 4:
					return;
				case 1:
					break;
				}
				break;
			}
			bool flag = ((EqualityComparer<MobileSession>)/*Error near IL_011a: Stack underflow*/).Equals((MobileSession?)(object)P_0, (MobileSession?)1);
			obj = ((((object)flag) is TaskAwaiter<EntityAuthentication>) ? ((object)flag) : null);
			obj = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_F000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778630, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_F100()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return EntityLaunchBedrockProxy.Name__BackingField;
	}
}
