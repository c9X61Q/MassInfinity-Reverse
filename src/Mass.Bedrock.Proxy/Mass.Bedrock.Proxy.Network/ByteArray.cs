using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using DotNetty.Buffers;
using Mass.Application.Mobile;
using Mass.Application.Models;
using Mass.Bedrock.Proxy.Network.RakNet;
using Mass.Bedrock.Proxy.Packets.RakNet.Online;
using Mass.Domain.Desktop.ValueObjects;

namespace Mass.Bedrock.Proxy.Network;

public static class ByteArray
{
	private static object QueryAuthenticator;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] ReadAsBytes(this IByteBuffer buffer)
	{
		return (byte[])_FF00_FF00_FF00_FF00䘀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] ReadAsBytes(this IByteBuffer buffer, int length)
	{
		return (byte[])_FF00_FF00_FF00_FF00䤀(buffer, (uint)length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SolveSchema()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ByteArray CheckEditableParameter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00㼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778662, new IntPtr(2737337525244L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00䀀()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return EntityLaunchBedrockProxy.Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00䄀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778663, new IntPtr(2737337524204L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00䈀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778664, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00䌀()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (EntityLaunchBedrockProxy.Name__BackingField == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00䐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778665, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00䔀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778666, new IntPtr(2737337510684L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00䘀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected I4, but got Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return ((EntityLaunchBedrockProxy)(object)((StringBuilder)P_0).Append((char)(int)P_0)).Session;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00䤀(object P_0, uint P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0057: Expected I4, but got Obj
		//IL_0161: Expected I4, but got Obj
		//IL_0161: Expected Obj, but got Ref
		//IL_0170: Expected Obj, but got I8
		//IL_014e: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got Ref
		//IL_0063: Expected Obj, but got Ref
		//IL_013a: Expected Obj, but got I4
		//IL_013a: Expected Obj, but got Ref
		//IL_009b: Expected Obj, but got Ref
		//IL_00a0: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got I4
		//IL_0111: Expected I4, but got Obj
		//IL_0113: Expected Obj, but got I4
		//IL_0122: Expected Obj, but got I
		//IL_0079: Expected Obj, but got Ref
		//IL_0197: Expected Obj, but got I8
		//IL_0175->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0158->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0100->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0072->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0144->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00b4->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0127->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0180->IL0026: Incompatible stack heights: 2 vs 1
		//IL_010b->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00bf->IL0026: Incompatible stack heights: 2 vs 1
		//IL_019c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0132->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0091->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01a7->IL0026: Incompatible stack types: I4 vs Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		object obj = 7;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				((StringBuilder)(object)((EntityLaunchBedrockProxy)(&obj)).EqualityContract)._002Ector();
				obj2 = 4;
				break;
			case 8:
				throw new StringBuilder((object?)((object)(&obj)).ToString());
			case 9:
				obj = new MobileSession[P_1];
				obj2 = 2;
				break;
			case 10:
				return obj;
			case 5:
				((EqualityComparer<Type>)/*Error near IL_00a0: Stack underflow*/).GetHashCode((Type)((EntityLaunchBedrockProxy)(&obj)).GameType);
				_ = 0;
				if (((BedrockProxy)BedrockProxy.GameType).ServerAddress != null)
				{
					_ = 0;
				}
				break;
			case 2:
				_ = EqualityComparer<EnumGameType>.Default;
				_ = 9;
				if (((BedrockProxy)BedrockProxy.Listener__BackingField).EndPoints__BackingField != null)
				{
					_ = 10;
				}
				break;
			case 7:
				obj = ((EqualityComparer<int>)/*Error near IL_0111: Stack underflow*/).GetHashCode((int)P_0);
				obj2 = 6;
				if (BedrockProxy.CloneProxy != null)
				{
					obj2 = 3;
				}
				break;
			case 4:
				Interlocked.CompareExchange(ref *(Action<RakNetSession>*)/*Error near IL_013a: Stack underflow*/, (Action<RakNetSession>)(&obj), (Action<RakNetSession>)P_1);
				_ = 5;
				break;
			case 1:
				((EqualityComparer<MobileSession>)(&obj)).Equals((MobileSession?)47, (MobileSession?)2);
				_ = 3;
				break;
			default:
				((IEnumerable<RakNetSession>)(&obj)).ElementAt((int)obj);
				_ = 8;
				if (ConnectedPong.CheckCustomizableNode == null)
				{
					_ = 6;
				}
				break;
			case 6:
				if ((int)P_1 <= (nint)obj)
				{
					obj2 = 9;
					if (((ConnectionRequest)ConnectionRequest.Guid__BackingField).Time__BackingField != 0L)
					{
						obj2 = 6;
					}
					break;
				}
				goto case 1;
			}
		}
	}
}
