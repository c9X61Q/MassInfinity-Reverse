using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using DotNetty.Buffers;
using Mass.Application.Mobile;
using Mass.Application.Models;
using Mass.Bedrock.Proxy.Network.Minecraft.Enums;
using Mass.Bedrock.Proxy.Network.Packet;
using Mass.Bedrock.Proxy.Packets.RakNet.Online;

namespace Mass.Bedrock.Proxy.Packets.Minecraft;

[Packet(EnumPacketDirection.Serverbound, 8u)]
public class ServerboundResourcePackClientResponsePacket : PacketBase
{
	internal static ServerboundResourcePackClientResponsePacket ReflectJoinedReceiver;

	public EnumResponseStatus Status
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return this._FF00_FF00_FF00_FF00_FF00_FF00_FFFD();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00휀(value);
		}
	}

	public List<string> PackIds
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return this._FF00_FF00_FF00_FF00_FF00_FF00_FFFD();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00퐀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Read(IByteBuffer buffer)
	{
		this._FF00_FF00_FF00_FF00_FF00_FF00_FFFD((object)buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(IByteBuffer buffer)
	{
		this._FF00_FF00_FF00_FF00_FF00_FF00_FFFD((object)buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe ServerboundResourcePackClientResponsePacket()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001a: Expected I4, but got Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		((EntityLaunchBedrockProxy)/*Error near IL_001f: Stack underflow*/).ServerAddress__BackingField = new StringBuilder((char)(int)this);
		((EntityLaunchBedrockProxy)/*Error near IL_002a: Stack underflow*/).Session = (MobileSession)(object)this;
		int num = 0;
		if (BedrockProxy.Logger__BackingField != null)
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
	internal static bool CheckLiteralProc()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerboundResourcePackClientResponsePacket CheckScalableSpec()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00팀(List<string> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778744, new IntPtr(2737337529404L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00퐀(List<string> P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00픀(List<string> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778745, new IntPtr(2737337519004L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00혀(EnumResponseStatus P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778746, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00휀(EnumResponseStatus P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected Obj, but got I4
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_004f: Expected I4, but got Obj
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_009a: Expected Obj, but got I
		//IL_010f: Expected Obj, but got I4
		//IL_012b: Expected I4, but got Obj
		//IL_012b: Expected Obj, but got I4
		//IL_013f: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_009f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0114->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0144->IL0026: Incompatible stack heights: 2 vs 1
		//IL_007a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00aa->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00f4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_011f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_014f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0085->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00cd->IL0026: Incompatible stack types: I4 vs Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				obj = 0;
				obj2 = 5;
				if (((EntityLaunchBedrockProxy)EntityLaunchBedrockProxy.Name__BackingField).ServerAddress__BackingField != null)
				{
					obj2 = 7;
				}
				break;
			default:
				obj++;
				obj2 = 3;
				if ((object)EntityLaunchBedrockProxy.ReflectScheduledLogger == null)
				{
					obj2 = 5;
				}
				break;
			case 6:
				return;
			case 5:
			case 7:
				if (Unsafe.As<object, UIntPtr>(ref obj) >= Unsafe.As<object, UIntPtr>(ref obj))
				{
					return;
				}
				obj2 = 8;
				break;
			case 1:
				RuntimeHelpers.EnsureSufficientExecutionStack();
				obj = P_0;
				obj2 = 4;
				if (((BedrockProxy)(object)BedrockProxy.Name).GameId == null)
				{
					obj2 = 0;
				}
				break;
			case 2:
				((EntityLaunchBedrockProxy)P_0).Name = (string)(object)EqualityComparer<MobileSession>.Default;
				_ = 1;
				if (((BedrockProxy)BedrockProxy.ServerPort).Session != null)
				{
					_ = 1;
				}
				break;
			case 3:
			case 8:
				((EntityLaunchBedrockProxy)((EntityLaunchBedrockProxy)(object)this).ServerPort).ServerPort = (int)P_0;
				_ = EqualityComparer<int>.Default;
				_ = 0;
				if (((BedrockProxy)BedrockProxy.EndPointIndex__BackingField).ProxyPort__BackingField != 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778747, new IntPtr(2737337531484L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778748, new IntPtr(2737337523164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_0056: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got I4
		//IL_00ae: Expected Obj, but got I4
		//IL_0122: Expected Obj, but got Ref
		//IL_0124: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got I
		//IL_0116: Expected Obj, but got I4
		//IL_00b3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0087->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00be->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00fc->IL011b: Incompatible stack heights: 0 vs 1
		//IL_00e7->IL00e7: Incompatible stack heights: 2 vs 1
		//IL_015f->IL00e7: Incompatible stack heights: 3 vs 1
		//IL_0101->IL011b: Incompatible stack heights: 0 vs 1
		//IL_016a->IL00e7: Incompatible stack heights: 3 vs 1
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		object obj = 1;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					goto end_IL_0026;
				case 3:
					return;
				case 4:
				{
					string gameId = ((EntityLaunchBedrockProxy)(object)this).GameId;
					RuntimeHelpers.EnsureSufficientExecutionStack();
					obj = gameId;
					obj2 = 2;
					if (((BedrockProxy)(object)BedrockProxy.Name).GameId == null)
					{
						obj2 = 2;
					}
					continue;
				}
				case 1:
					((EqualityComparer<MobileSession>)P_0).GetHashCode((MobileSession)(object)((EntityLaunchBedrockProxy)(object)this).Name);
					obj2 = 0;
					if (((BedrockProxy)BedrockProxy.ServerPort).Session == null)
					{
						obj2 = 0;
					}
					continue;
				case 2:
					break;
				}
				while (true)
				{
					if (EqualityComparer<int>.Default == null)
					{
						obj = 3;
						goto IL_00e7;
					}
					goto IL_011b;
					IL_00e7:
					int num;
					while (true)
					{
						switch (num)
						{
						case 3:
							return;
						case 2:
							break;
						default:
							goto IL_011b;
						case 1:
							((EntityLaunchBedrockProxy)obj).GetHashCode();
							_ = 2;
							if (((ConnectedPong)(object)ConnectedPing.DecorateVirtualExecutor).ClientTimestamp__BackingField == 0L)
							{
								_ = 2;
							}
							continue;
						}
						break;
					}
					continue;
					IL_011b:
					obj = ((EqualityComparer<int>)(&obj)).GetHashCode((int)(&obj));
					num = 0;
					if (BedrockProxy.CloneProxy == null)
					{
						num = 1;
					}
					goto IL_00e7;
				}
				continue;
				end_IL_0026:
				break;
			}
			((StringBuilder)(object)((EntityLaunchBedrockProxy)(object)this).EqualityContract)._002Ector();
			((object)(ushort)P_0).ToString();
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<string> _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (List<string>)((EntityLaunchBedrockProxy)(object)this).Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe EnumResponseStatus _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected I4, but got Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (EnumResponseStatus)(int)((EntityLaunchBedrockProxy)(object)this).Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe EnumResponseStatus _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778749, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		return (EnumResponseStatus)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778750, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_E000()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return EntityLaunchBedrockProxy.Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_E100()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778751, new IntPtr(2737337527324L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_E200()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (EntityLaunchBedrockProxy.Name__BackingField == null) ? ((byte)1) : ((byte)0);
	}
}
