using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Mass.Application.Models;
using Mass.Bedrock.Proxy.Network.Minecraft.Enums;
using Mass.Bedrock.Proxy.Network.Packet;
using Mass.Domain.Desktop.ValueObjects;

namespace Mass.Bedrock.Proxy.Packets.Minecraft;

[Packet(EnumPacketDirection.Serverbound, 200u)]
public class ServerboundPyRpcPacket : PyRpcPacket
{
	internal static ServerboundPyRpcPacket DecorateCommonToken;

	public override EnumPacketDirection Direction => EnumPacketDirection.Serverbound;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe ServerboundPyRpcPacket()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		_ = ((EntityLaunchBedrockProxy)(object)this).EqualityContract;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe ServerboundPyRpcPacket(PyRpcPacketBase packet)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_004f: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got I
		//IL_008e->IL002d: Incompatible stack types: I4 vs Obj
		//IL_0099->IL002d: Incompatible stack types: I4 vs Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		Type type = ((EntityLaunchBedrockProxy)(object)this).EqualityContract;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				((EntityLaunchBedrockProxy)(object)this).ServerAddress__BackingField = 98247598;
				num = 0;
				if ((object)EntityLaunchBedrockProxy.ReflectScheduledLogger == null)
				{
					num = 0;
				}
				break;
			case 2:
			{
				((EntityLaunchBedrockProxy)(object)this).GameId = (string)(object)packet;
				EnumGameType gameType = ((EntityLaunchBedrockProxy)(object)type).GameType;
				num = 0;
				type = (Type)gameType;
				if (((BedrockProxy)(object)BedrockProxy.GameId).GameType != 0)
				{
					num = 1;
					type = (Type)gameType;
				}
				break;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateAdaptableExplorer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerboundPyRpcPacket VisitSubscriber()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00뼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778733, new IntPtr(2737337512764L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00쀀()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (EntityLaunchBedrockProxy.Name__BackingField == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00섀()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return EntityLaunchBedrockProxy.Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00숀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778734, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
