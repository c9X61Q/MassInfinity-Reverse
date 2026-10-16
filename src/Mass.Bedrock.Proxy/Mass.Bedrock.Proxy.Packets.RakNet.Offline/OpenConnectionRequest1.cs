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

namespace Mass.Bedrock.Proxy.Packets.RakNet.Offline;

[RakNetPacket(5)]
public class OpenConnectionRequest1 : IRakNetPacket
{
	internal static OpenConnectionRequest1 CheckSeparatedDistributor;

	public byte ProtocolVersion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00가();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00ꐀ(value);
		}
	}

	public ushort MtuSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00ꨀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00ꄀ(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Read(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00ꔀ(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00_A700(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe OpenConnectionRequest1()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001a: Expected I4, but got Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		((StringBuilder)/*Error near IL_001a: Stack underflow*/).Append((char)(int)this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckMonoNotifier()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static OpenConnectionRequest1 ReflectOrderedDispatcher()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00ꀀ(ushort P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778580, new IntPtr(2737337524204L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00ꄀ(ushort P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00ꈀ(ushort P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778581, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00ꌀ(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778582, new IntPtr(2737337517964L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00ꐀ(byte P_0)
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
	internal unsafe sealed void _FF00_FF00_FF00_FF00ꔀ(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got I4
		//IL_0048: Expected I4, but got Obj
		//IL_005c: Expected Obj, but got I
		//IL_0097->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0061->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00bc->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a2->IL0026: Incompatible stack heights: 2 vs 1
		//IL_006c->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00c7->IL0026: Incompatible stack heights: 2 vs 1
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		object obj = 2;
		while (true)
		{
			switch ((int)obj)
			{
			case 3:
				return;
			case 1:
				_ = ((EntityLaunchBedrockProxy)(object)((StringBuilder)(object)this).Append((char)(int)P_0)).Session;
				_ = 0;
				if ((object)EntityLaunchBedrockProxy.ReflectScheduledLogger != null)
				{
					_ = 0;
				}
				continue;
			case 2:
				_ = ((EntityLaunchBedrockProxy)P_0).ServerAddress;
				_ = 1;
				if ((object)((BedrockProxy)(object)BedrockProxy.Session).PatchInfo == null)
				{
					_ = 1;
				}
				continue;
			}
			RuntimeHelpers.EnsureSufficientExecutionStack();
			((EntityLaunchBedrockProxy)P_0).GameType = (EnumGameType)(ushort)(P_0 + (object)EqualityComparer<Type>.Default + 28);
			_ = 2;
			if (((BedrockProxy)BedrockProxy.GameType).ServerAddress == null)
			{
				_ = 3;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00ꘀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778583, new IntPtr(2737337510684L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_A700(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086->IL0026: Incompatible stack heights: 2 vs 1
		//IL_005a->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00c2->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0091->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0065->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00cd->IL0026: Incompatible stack types: I4 vs Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				_ = ((EntityLaunchBedrockProxy)P_0).EqualityContract;
				_ = 0;
				if (((EntityLaunchBedrockProxy)EntityLaunchBedrockProxy.ServerAddress__BackingField).ServerPort__BackingField == 0)
				{
					_ = 0;
				}
				continue;
			case 3:
				return;
			case 2:
				((EqualityComparer<string>)/*Error near IL_00ad: Stack underflow*/).GetHashCode((string)(object)new RuntimeTypeHandle[P_0 - ((EqualityComparer<MobileSession>)(object)((EntityLaunchBedrockProxy)this).Name).GetHashCode((MobileSession)P_0) - 28]);
				obj2 = 3;
				if (((BedrockProxy)(object)BedrockProxy.PatchInfo).Listener__BackingField == null)
				{
					obj2 = 2;
				}
				continue;
			}
			_ = ((EntityLaunchBedrockProxy)this).GameId;
			RuntimeHelpers.EnsureSufficientExecutionStack();
			_ = 2;
			if (((BedrockProxy)(object)BedrockProxy.Name).GameId != null)
			{
				_ = 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00ꠀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778584, new IntPtr(2737337531484L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ushort _FF00_FF00_FF00_FF00꤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778585, new IntPtr(2737337520044L), 15))(null, 0, new IntPtr(0L));
		return (ushort)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ushort _FF00_FF00_FF00_FF00ꨀ()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected I4, but got Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (ushort)(int)((EntityLaunchBedrockProxy)this).Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_AB00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778586, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00가()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected I4, but got Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (byte)(int)((EntityLaunchBedrockProxy)this).Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00관()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778587, new IntPtr(2737337519004L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00글()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return EntityLaunchBedrockProxy.Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00꼀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778588, new IntPtr(2737337530444L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00뀀()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (EntityLaunchBedrockProxy.Name__BackingField == null) ? ((byte)1) : ((byte)0);
	}
}
