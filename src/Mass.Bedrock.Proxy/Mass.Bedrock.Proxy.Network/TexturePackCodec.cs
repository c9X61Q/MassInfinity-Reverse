using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using DotNetty.Buffers;
using Mass.Application.Mobile;
using Mass.Application.Models;
using Mass.Bedrock.Proxy.Network.RakNet;
using Mass.Bedrock.Proxy.Packets.RakNet.Online;
using Mass.Domain.Desktop.ValueObjects;

namespace Mass.Bedrock.Proxy.Network;

public static class TexturePackCodec
{
	private static object GetList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TexturePack ReadTexturePack(this IByteBuffer buffer)
	{
		return (TexturePack)_FF00_FF00_FF00_FFFD(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteTexturePack(this IByteBuffer buffer, TexturePack texturePack)
	{
		_FF00_FF00_FF00_E100(buffer, texturePack);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectCentralLogger()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TexturePackCodec CheckStatelessConnection()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778852, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FFFD()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return EntityLaunchBedrockProxy.Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778853, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778854, new IntPtr(2737337523164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FFFD()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (EntityLaunchBedrockProxy.Name__BackingField == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778855, new IntPtr(2737337510684L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2059, 1790778856, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778856, new IntPtr(2737337510684L), 15);
		}
		return ((delegate*<object, object>)obj)(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_E000(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778857, new IntPtr(2737337521084L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_E100(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0057: Expected I4, but got Obj
		//IL_0117: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I4
		//IL_00a4: Expected I4, but got Obj
		//IL_00ea->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0026: Incompatible stack heights: 2 vs 1
		//IL_01a5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_012b->IL0026: Incompatible stack heights: 2 vs 1
		//IL_010b->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0072->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0183->IL0026: Incompatible stack heights: 2 vs 1
		//IL_014c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00be->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009d->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0136->IL0026: Incompatible stack heights: 2 vs 1
		//IL_018e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00c9->IL0026: Incompatible stack types: I4 vs Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		object obj = 6;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 7:
				_ = ((EntityLaunchBedrockProxy)(object)((EntityLaunchBedrockProxy)P_1).EqualityContract).Session;
				_ = 8;
				break;
			case 1:
				((EntityLaunchBedrockProxy)P_0).Session = (MobileSession)P_1;
				_ = ((EntityLaunchBedrockProxy)/*Error near IL_007e: Stack underflow*/).GameId;
				_ = 0;
				if (((BedrockProxy)BedrockProxy.Logger__BackingField).Name == null)
				{
					_ = 4;
				}
				break;
			case 10:
				((EntityLaunchBedrockProxy)P_0).GameType = (EnumGameType)P_1;
				_ = EqualityComparer<MobileSession>.Default;
				obj2 = 0;
				if (((BedrockProxy)(object)BedrockProxy.ServerAddress).ServerPort != 0)
				{
					obj2 = 0;
				}
				break;
			default:
				((EntityLaunchBedrockProxy)P_0).ServerAddress = (string)P_1;
				_ = EqualityComparer<EnumGameType>.Default;
				obj2 = 1;
				if (((BedrockProxy)BedrockProxy.Listener__BackingField).EndPoints__BackingField != null)
				{
					obj2 = 9;
				}
				break;
			case 6:
				_ = (EntityLaunchBedrockProxy?)/*Error near IL_0101: Stack underflow*/ != (EntityLaunchBedrockProxy?)((EntityLaunchBedrockProxy)P_0).PrintMembers((StringBuilder)P_1);
				_ = 5;
				break;
			case 5:
				((EntityLaunchBedrockProxy)((EntityLaunchBedrockProxy?)P_0 == (EntityLaunchBedrockProxy?)P_1)).GetHashCode();
				_ = 2;
				if (((ConnectedPong)(object)ConnectedPing.DecorateVirtualExecutor).ClientTimestamp__BackingField == 0L)
				{
					_ = 3;
				}
				break;
			case 9:
				((EntityLaunchBedrockProxy)P_0)._002Ector(((EntityLaunchBedrockProxy)P_1)._003CClone_003E_0024());
				obj2 = 2;
				break;
			case 4:
				((EntityLaunchBedrockProxy)/*Error near IL_0153: Stack underflow*/).Deconstruct(out *(MobileSession*)/*Error near IL_0153: Stack underflow*/, out *(string*)/*Error near IL_0153: Stack underflow*/, out *(EnumGameType*)/*Error near IL_0153: Stack underflow*/, out *(string*)/*Error near IL_0153: Stack underflow*/, out *(string*)P_0, out *(int*)P_1);
				/*Error near IL_0153: Member reference must be method, but was: Field*/;
			case 8:
				((BedrockProxy)P_1)._002Ector(EntityLaunchBedrockProxy.ReflectAutomatedAttribute());
				_ = 1;
				if (((ConnectionRequestAccepted)ConnectionRequestAccepted.ClientAddress__BackingField).SystemIndex__BackingField != 0)
				{
					_ = 1;
				}
				break;
			case 3:
				((BedrockProxy)P_0).Listener = (RakNetServer?)P_1;
				((Func<IPAddress, IPEndPoint>)/*Error near IL_019a: Stack underflow*/)._002Ector((object)/*Error near IL_019a: Stack underflow*/, (nint)/*Error near IL_019a: Stack underflow*/);
				obj2 = 7;
				break;
			case 2:
				return;
			}
		}
	}
}
