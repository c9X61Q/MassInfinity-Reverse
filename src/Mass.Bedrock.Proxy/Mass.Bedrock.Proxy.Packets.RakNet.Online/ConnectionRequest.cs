using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using DotNetty.Buffers;
using Mass.Application.Mobile;
using Mass.Application.Models;
using Mass.Bedrock.Proxy.Network.Packet;
using Mass.Domain.Desktop.ValueObjects;

namespace Mass.Bedrock.Proxy.Packets.RakNet.Online;

[RakNetPacket(9)]
public class ConnectionRequest : IRakNetPacket
{
	internal static ConnectionRequest CheckHiddenCollector;

	public long Guid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00崀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00唀(value);
		}
	}

	public long Time
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00刀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00开(value);
		}
	}

	public bool UseEncryption
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00圀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00挀(value ? ((byte)1) : ((byte)0));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Read(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00_FF00嬀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00_FF00夀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe ConnectionRequest()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001a: Expected I4, but got Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		((StringBuilder)/*Error near IL_001a: Stack underflow*/).Append((char)(int)this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectAdjustableOrder()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ConnectionRequest ReflectGenericProxy()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00伀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778487, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00倀()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return EntityLaunchBedrockProxy.Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00儀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778488, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe long _FF00_FF00_FF00_FF00_FF00刀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected I8, but got Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (long)((EntityLaunchBedrockProxy)this).Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe long _FF00_FF00_FF00_FF00_FF00匀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778489, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		return (long)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00吀(long P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778490, new IntPtr(2737337517964L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00唀(long P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected Obj, but got I8
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
				((EntityLaunchBedrockProxy)this).Name__BackingField = P_0;
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
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00嘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778491, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00圀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected I4, but got Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (byte)(int)((EntityLaunchBedrockProxy)this).Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00堀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778492, new IntPtr(2737337517964L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00夀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_008f: Expected I4, but got Obj
		//IL_0057: Expected Obj, but got I4
		//IL_00a9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0088->IL0026: Incompatible stack types: I4 vs Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		object obj = 3;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					return;
				case 0:
					return;
				case 3:
					break;
				case 2:
					((EntityLaunchBedrockProxy)P_0).Session = (MobileSession)(object)this;
					((StringBuilder)/*Error near IL_0068: Stack underflow*/).Append((object?)/*Error near IL_0068: Stack underflow*/);
					obj2 = 1;
					if (((BedrockProxy)BedrockProxy.Logger__BackingField).Name == null)
					{
						obj2 = 1;
					}
					continue;
				case 1:
					((EntityLaunchBedrockProxy)P_0).GameType = (EnumGameType)this;
					_ = EqualityComparer<MobileSession>.Default;
					obj2 = 0;
					if (((BedrockProxy)(object)BedrockProxy.ServerAddress).ServerPort != 0)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
			}
			((StringBuilder)(object)((EntityLaunchBedrockProxy)this).EqualityContract)._002Ector();
			obj = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00娀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778493, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00嬀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_00a3: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_005b: Expected Obj, but got I
		//IL_00ad->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0060->IL0026: Incompatible stack heights: 2 vs 1
		//IL_008b->IL0026: Incompatible stack heights: 3 vs 1
		//IL_006b->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0096->IL0026: Incompatible stack heights: 3 vs 1
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		object obj = 2;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 2:
				_ = ((EntityLaunchBedrockProxy)(object)((StringBuilder)(object)this).Append((char)(int)P_0)).Session;
				_ = 1;
				if ((object)EntityLaunchBedrockProxy.ReflectScheduledLogger != null)
				{
					_ = 1;
				}
				break;
			case 3:
				RuntimeHelpers.EnsureSufficientExecutionStack();
				_ = ((EntityLaunchBedrockProxy)P_0).GameType;
				_ = 0;
				if (((BedrockProxy)(object)BedrockProxy.GameId).GameType != 0)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			case 1:
				_ = ((EntityLaunchBedrockProxy)((EqualityComparer<MobileSession>)(object)this).GetHashCode((MobileSession)P_0)).ServerAddress;
				_ = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00尀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778494, new IntPtr(2737337528364L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe long _FF00_FF00_FF00_FF00_FF00崀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected I8, but got Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (long)((EntityLaunchBedrockProxy)this).Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe long _FF00_FF00_FF00_FF00_FF00帀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778495, new IntPtr(2737337532524L), 15))(null, 0, new IntPtr(0L));
		return (long)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00开(long P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected Obj, but got I8
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
				((EntityLaunchBedrockProxy)this).Name__BackingField = P_0;
				obj2 = 0;
				if (((EntityLaunchBedrockProxy)EntityLaunchBedrockProxy.ServerAddress__BackingField).ServerPort__BackingField != 0)
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
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00怀()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (EntityLaunchBedrockProxy.Name__BackingField == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00愀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778368, new IntPtr(2737337524204L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00戀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778369, new IntPtr(2737337520044L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00挀(byte P_0)
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
				((EntityLaunchBedrockProxy)this).Name__BackingField = P_0;
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00搀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778370, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
