using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Mass.Application.Event;
using Mass.Application.Models;
using Mass.Bedrock.Proxy.Network.Minecraft.Enums;
using Mass.Bedrock.Proxy.Network.Packet;
using Mass.Bedrock.Proxy.Network.RakNet;
using Mass.Bedrock.Proxy.Network.RakNet.Protocol;
using Mass.Bedrock.Proxy.Packets.RakNet.Online;
using Mass.Domain.Desktop.ValueObjects;
using MessagePack;

namespace Mass.Bedrock.Proxy.Network;

public static class PyRpc
{
	private static readonly object Options;

	internal static PyRpc ReflectGlobalWorker;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static PyRpcPacketBase? AsPyRpc(EnumPacketDirection direction, byte[] data)
	{
		return (PyRpcPacketBase?)_FF00_FF00_FF00_FF00_FF00_FF00_FF00㨀(direction, data);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] Serialize(PyRpcPacketBase packet)
	{
		return (byte[])_FF00_FF00_FF00_FF00_FF00_FF00_FF00㼀(packet);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static object Convert(object input)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 449, 1790778824, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778824, new IntPtr(2737337509644L), 15);
		}
		return ((delegate*<object, object>)obj)(input);
	}

	static PyRpc()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_001f: Expected I4, but got Obj
		//IL_004d->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0058->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
				Options = MessagePackSerializerOptions.Standard.WithOldSpec((bool?)true);
				obj2 = 0;
				if (_003CModule_003E_007B516b6972_002D90a8_002D4ed4_002Da9b8_002D9c8a3a89ca13_007D.m_1d065322f6cc4334a6da9cd60aaa535f.m_a347bb6573554289957a566a8523b5a9 == 0)
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
	internal static bool DecorateDetachedProvider()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PyRpc CheckDetailedCalc()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㔀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778825, new IntPtr(2737337523164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㘀()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return EntityLaunchBedrockProxy.Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㜀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778826, new IntPtr(2737337516924L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㠀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_006b: Expected I4, but got Obj
		//IL_010f: Expected Obj, but got I4
		//IL_012b: Expected Obj, but got I4
		//IL_01a2: Expected I4, but got Obj
		//IL_01a4: Expected Obj, but got I4
		//IL_0231: Expected Obj, but got I8
		//IL_0238: Expected Obj, but got I4
		//IL_0226: Expected Obj, but got I
		//IL_022c: Expected I, but got Obj
		//IL_01d7: Expected I4, but got Obj
		//IL_0238: Expected Obj, but got I4
		//IL_01e2: Expected I4, but got Obj
		//IL_008c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0215->IL022c: Incompatible stack types: I8 vs Obj
		//IL_00a9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01ca->IL01dd: Incompatible stack types: I vs Obj
		//IL_0130->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01ae->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0103->IL0026: Incompatible stack types: I4 vs Obj
		//IL_014c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0097->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0242->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01fd->IL0026: Incompatible stack types: I4 vs Obj
		//IL_013b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_018b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0208->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0196->IL0026: Incompatible stack types: I4 vs Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		object obj = 4;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 4:
					obj = P_0 as EqualityComparer<EnumGameType>;
					obj2 = 3;
					if (((EntityLaunchBedrockProxy)EntityLaunchBedrockProxy.ServerAddress__BackingField).ServerPort__BackingField == 0)
					{
						obj2 = 3;
					}
					continue;
				case 9:
					obj = P_0 as Action<RakNetSession>;
					obj2 = 14;
					continue;
				case 2:
				case 6:
				case 8:
				case 15:
					return obj;
				case 1:
					if (obj != null)
					{
						obj2 = 7;
						continue;
					}
					goto case 9;
				default:
					goto end_IL_0026;
				case 12:
					obj = P_0 as List<Frame>;
					obj2 = 1;
					if (((BedrockProxy)BedrockProxy.GameType).ServerAddress == null)
					{
						obj2 = 0;
					}
					continue;
				case 3:
					if (obj == null)
					{
						obj2 = 12;
						continue;
					}
					goto case 13;
				case 14:
					if (obj == null)
					{
						obj2 = 0;
						if (((BedrockProxy)(object)BedrockProxy.PatchInfo).Listener__BackingField == null)
						{
							obj2 = 0;
						}
						continue;
					}
					break;
				case 13:
					obj = EqualityComparer<int>.Default.GetHashCode((int)obj);
					obj2 = 15;
					continue;
				case 7:
				case 10:
				{
					object source = obj;
					nint num = BedrockProxy.ProxyPort__BackingField;
					EqualityComparer<int> equalityComparer = (EqualityComparer<int>)num;
					if (num == 0)
					{
						equalityComparer = (EqualityComparer<int>)(object)(ConnectedPing.DecorateVirtualExecutor = (ConnectedPing)new EqualityComparer<int>((int)null, (int)(delegate*<EntityLaunchBedrockProxy?, EntityLaunchBedrockProxy?, bool>)(&EntityLaunchBedrockProxy.op_Equality)));
					}
					obj = Interlocked.CompareExchange(ref *(Action<IPEndPoint, Reliability, IRakNetPacket>*)/*Error near IL_01e7: Stack underflow*/, (Action<IPEndPoint, Reliability, IRakNetPacket>)/*Error near IL_01e7: Stack underflow*/, (Action<IPEndPoint, Reliability, IRakNetPacket>)(object)((IEnumerable<RakNetSession>)source).ElementAt((int)equalityComparer));
					obj2 = 6;
					if (((ConnectionRequest)(object)ConnectedPong.CheckCustomizableNode).Guid__BackingField == 0L)
					{
						obj2 = 4;
					}
					continue;
				}
				case 5:
					break;
				}
				object first = obj;
				long num2 = ConnectionRequest.Time__BackingField;
				Action<RakNetSession> action = (Action<RakNetSession>)num2;
				if (num2 == 0L)
				{
					action = ((BedrockProxy)ConnectionRequest.UseEncryption__BackingField)._002Ector;
					ConnectionRequestAccepted.SystemIndex__BackingField = (nint)action;
				}
				obj = ((IEnumerable<byte>)first).SequenceEqual(((IEnumerable<byte>)(object)action).ToArray());
				obj2 = 8;
				continue;
				end_IL_0026:
				break;
			}
			obj = P_0;
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㤀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778827, new IntPtr(2737337532524L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㨀(EnumPacketDirection P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0063: Expected I4, but got Obj
		//IL_00aa: Expected Obj, but got I4
		//IL_0104: Expected I4, but got Obj
		//IL_0109: Expected Obj, but got I4
		//IL_0119: Expected Obj, but got I4
		//IL_0138: Expected Obj, but got I4
		//IL_0084: Expected I4, but got Obj
		//IL_00df->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0175->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0190->IL0026: Incompatible stack types: I4 vs Obj
		//IL_013d->IL0022: Incompatible stack heights: 2 vs 0
		//IL_01c9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ea->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0093->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00c0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0079->IL0026: Incompatible stack types: I4 vs Obj
		//IL_019b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01d4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01fe->IL0026: Incompatible stack heights: 3 vs 1
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		object obj = 13;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 12:
					if (obj == null)
					{
						obj2 = 9;
						continue;
					}
					goto case 1;
				case 3:
					return null;
				case 4:
					return obj;
				case 7:
					obj = ((object[])obj)[1] as IEquatable<EntityLaunchBedrockProxy>;
					obj = 5;
					break;
				case 8:
					if (obj == null)
					{
						obj2 = 3;
						continue;
					}
					((EventBus)/*Error near IL_0084: Stack underflow*/).Register((Action<EventPluginChanged>)obj, (int)obj);
					_ = ((EntityLaunchBedrockProxy)/*Error near IL_0089: Stack underflow*/).Session;
					_ = 10;
					continue;
				case 6:
				{
					object obj3 = ((object[])obj)[0];
					obj = ((obj3 is void) ? obj3 : null);
					obj2 = 2;
					if (((BedrockProxy)BedrockProxy.Logger__BackingField).Name == null)
					{
						obj2 = 1;
					}
					continue;
				}
				case 13:
				{
					int hashCode = ((EqualityComparer<Type>)/*Error near IL_00f0: Stack underflow*/).GetHashCode((Type)P_1);
					((DefaultInterpolatedStringHandler*)(int)BedrockProxy.GameType)->AppendFormatted((int)null);
					((EntityLaunchBedrockProxy)/*Error near IL_0109: Stack underflow*/).ServerAddress = (string)hashCode;
					obj = (object)/*isinst with value type is only supported in some contexts*/;
					obj = 12;
					break;
				}
				default:
					return null;
				case 1:
					if (((Array)obj).Length < 2)
					{
						obj2 = 11;
						continue;
					}
					goto case 6;
				case 2:
					if (obj != null)
					{
						obj2 = 7;
						if (((ConnectedPing)BedrockProxy.CloneProxy).ClientTimestamp__BackingField != 0L)
						{
							obj2 = 3;
						}
						continue;
					}
					goto default;
				case 5:
					if (obj != null)
					{
						_ = BedrockProxy.Listener__BackingField;
						obj = ((EntityLaunchBedrockProxy)obj).ToString();
						obj = 8;
						break;
					}
					obj2 = 0;
					if (((ConnectedPong)(object)ConnectedPing.DecorateVirtualExecutor).ClientTimestamp__BackingField == 0L)
					{
						obj2 = 0;
					}
					continue;
				case 10:
					((EntityLaunchBedrockProxy)((((Array)obj).Length > 2) ? ((object[])obj)[2] : null))._003CClone_003E_0024();
					_ = 4;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㬀(EnumPacketDirection P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778828, new IntPtr(2737337510684L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00㰀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778829, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00㴀()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (EntityLaunchBedrockProxy.Name__BackingField == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00㼀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2919, 1790778830, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778830, new IntPtr(2737337525244L), 15);
		}
		return ((delegate*<object, object>)obj)(P_0);
	}
}
