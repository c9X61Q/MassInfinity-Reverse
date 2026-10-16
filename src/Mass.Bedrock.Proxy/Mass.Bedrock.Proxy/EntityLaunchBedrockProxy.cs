using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using DotNetty.Buffers;
using Mass.Application.Event;
using Mass.Application.Mobile;
using Mass.Application.Models;
using Mass.Bedrock.Proxy.Network.RakNet;
using Mass.Bedrock.Proxy.Packets.RakNet.Offline;
using Mass.Bedrock.Proxy.Packets.RakNet.Online;
using Mass.Domain.Desktop.ValueObjects;
using Serilog;

namespace Mass.Bedrock.Proxy;

public record EntityLaunchBedrockProxy
{
	[CompilerGenerated]
	protected virtual Type EqualityContract
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (Type)_FF00_FF00_FF00_FF00_FF00鄀();
		}
	}

	public MobileSession Session
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (MobileSession)_FF00_FF00_FF00_FF00_FF00鴀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00뀀(value);
		}
	}

	public string GameId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00鼀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00蘀(value);
		}
	}

	public EnumGameType GameType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00餀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00輀(value);
		}
	}

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00ꘀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00舀(value);
		}
	}

	public string ServerAddress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00褀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00謀(value);
		}
	}

	public int ServerPort
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (int)_FF00_FF00_FF00_FF00_FF00눀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_FF00_FF00_FF00_FF00ꌀ((uint)value);
		}
	}

	[CompilerGenerated]
	private readonly object Session__BackingField;

	[CompilerGenerated]
	private readonly object Name__BackingField;

	[CompilerGenerated]
	private readonly object ServerAddress__BackingField;

	[CompilerGenerated]
	private readonly nint ServerPort__BackingField;

	internal static EntityLaunchBedrockProxy ReflectScheduledLogger;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe EntityLaunchBedrockProxy(MobileSession Session, string GameId, EnumGameType GameType, string Name, string ServerAddress, int ServerPort)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_005a: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I4
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		Name__BackingField = Session;
		ServerAddress__BackingField = GameId;
		ServerPort__BackingField = (nint)GameType;
		ReflectScheduledLogger = (EntityLaunchBedrockProxy)(object)Name;
		BedrockProxy.Logger__BackingField = ServerAddress;
		((BedrockProxy)this).Name = (string)ServerPort;
		((EqualityComparer<Type>)/*Error near IL_0065: Stack underflow*/).GetHashCode((Type)(object)this);
		int num = 0;
		if (((BedrockProxy)BedrockProxy.GameType).ServerAddress == null)
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
	[CompilerGenerated]
	public override string ToString()
	{
		return (string)_FF00_FF00_FF00_FF00_FF00销();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	protected virtual bool PrintMembers(StringBuilder builder)
	{
		return _FF00_FF00_FF00_FF00_FF00글(builder) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public override int GetHashCode()
	{
		return (int)_FF00_FF00_FF00_FF00_FF00鬀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public virtual bool Equals(EntityLaunchBedrockProxy? other)
	{
		return _FF00_FF00_FF00_FF00_FF00ꐀ(other) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	protected unsafe EntityLaunchBedrockProxy(EntityLaunchBedrockProxy original)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001a: Expected I4, but got Obj
		//IL_00f7: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I8
		//IL_00a0: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got I4
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		((StringBuilder)/*Error near IL_001a: Stack underflow*/).Append((char)(int)this);
		int num = 0;
		if (((EntityLaunchBedrockProxy)EntityLaunchBedrockProxy.ServerAddress__BackingField).ServerPort__BackingField == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				BedrockProxy.Logger__BackingField = ReflectScheduledLogger;
				num = 3;
				break;
			case 3:
				((BedrockProxy)this).GameId = ((BedrockProxy)(object)original).Name;
				num = 5;
				break;
			case 2:
				((BedrockProxy)this).ServerAddress = (string)((BedrockProxy)(object)original).GameType;
				num = 6;
				if (((BedrockProxy)BedrockProxy.ServerPort).Session != null)
				{
					num = 0;
				}
				break;
			case 5:
				((BedrockProxy)this).Listener__BackingField = ((BedrockProxy)(object)original).PatchInfo;
				num = 0;
				if (((BedrockProxy)BedrockProxy.EndPoints__BackingField).EndPointIndex__BackingField == 0)
				{
					num = 0;
				}
				break;
			case 6:
				return;
			case 1:
				BedrockProxy.CloneProxy = ((BedrockProxy)(object)original).ProxyPort__BackingField;
				num = 1;
				if (ConnectedPing.DecorateVirtualExecutor != null)
				{
					num = 4;
				}
				break;
			default:
				((ConnectedPong)this).ServerTimestamp__BackingField = ((ConnectedPong)(object)original).ClientTimestamp__BackingField;
				num = 0;
				if (((ConnectionRequest)(object)ConnectedPong.CheckCustomizableNode).Guid__BackingField != 0L)
				{
					num = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public unsafe void Deconstruct(out MobileSession Session, out string GameId, out EnumGameType GameType, out string Name, out string ServerAddress, out int ServerPort)
	{
		_FF00_FF00_FF00_FF00_FF00똀((nint)Unsafe.AsPointer(ref Session), (nint)Unsafe.AsPointer(ref GameId), (nint)Unsafe.AsPointer(ref GameType), (nint)Unsafe.AsPointer(ref Name), (nint)Unsafe.AsPointer(ref ServerAddress), (nint)Unsafe.AsPointer(ref ServerPort));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AssembleCollector()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EntityLaunchBedrockProxy ReflectAutomatedAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00脀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778434, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00舀(object P_0)
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
				Name__BackingField = P_0;
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
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00茀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778435, new IntPtr(2737337520044L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00萀(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_008a: Expected Obj, but got I
		//IL_008f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0051->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009a->IL0026: Incompatible stack types: I4 vs Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				if (P_0 == P_1)
				{
					return 1;
				}
				obj2 = 2;
				break;
			case 2:
				if (P_0 == null)
				{
					obj2 = 0;
					if ((object)ReflectScheduledLogger != null)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 1;
			case 1:
				((EntityLaunchBedrockProxy)P_0)._FF00_FF00_FF00_FF00_FF00蘀(P_1);
				return (byte)/*Error near IL_00a2: Stack underflow*/;
			default:
				return 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00蔀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778436, new IntPtr(2737337525244L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00蘀(object P_0)
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
				Name__BackingField = P_0;
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00蜀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778437, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00蠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778438, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00褀()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00言()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778439, new IntPtr(2737337511724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00謀(object P_0)
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
				Name__BackingField = P_0;
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00谀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778440, new IntPtr(2737337513804L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00贀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_0021: Expected I4, but got Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (byte)(int)((EntityLaunchBedrockProxy)(object)(P_0 as ConnectedPing))._FF00_FF00_FF00_FF00_FF00鴀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00踀(EnumGameType P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778441, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00輀(EnumGameType P_0)
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
				Name__BackingField = P_0;
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
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00退()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return EntityLaunchBedrockProxy.Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe object _FF00_FF00_FF00_FF00_FF00鄀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001e: Expected Obj, but got VT
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		((StringBuilder)typeof(ConnectedPing).TypeHandle)._002Ector();
		return (object)/*Error near IL_001f: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00鐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778442, new IntPtr(2737337520044L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00销()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2495, 1790778443, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778443, new IntPtr(2737337513804L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00阀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778444, new IntPtr(2737337524204L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00需(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (((EntityLaunchBedrockProxy)P_1)._FF00_FF00_FF00_FF00_FF00鄀() == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00頀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778445, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe EnumGameType _FF00_FF00_FF00_FF00_FF00餀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected I4, but got Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (EnumGameType)Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe EnumGameType _FF00_FF00_FF00_FF00_FF00騀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778446, new IntPtr(2737337532524L), 15))(null, 0, new IntPtr(0L));
		return (EnumGameType)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00鬀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I4
		//IL_0051: Expected Obj, but got I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected I4, but got Unknown
		//IL_007f: Expected I4, but got Obj
		//IL_007f: Expected Obj, but got I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected I4, but got Unknown
		//IL_0096: Expected I4, but got Obj
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00ad: Expected Obj, but got I8
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected I4, but got Unknown
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (uint)(((EqualityComparer<MobileSession>)/*Error near IL_00a2: Stack underflow*/).Equals((MobileSession?)/*Error near IL_00a2: Stack underflow*/, (MobileSession?)((/*Error near IL_0097: Stack underflow*/ + ((EqualityComparer<int>)/*Error near IL_0096: Stack underflow*/).Equals(((EqualityComparer<EnumGameType>)/*Error near IL_008b: Stack underflow*/).Equals((EnumGameType)/*Error near IL_008b: Stack underflow*/, (EnumGameType)(((/*Error near IL_0052: Stack underflow*/ + ((EqualityComparer<MobileSession>)((EqualityComparer<Type>)(object)((StringBuilder)/*Error near IL_0019: Stack underflow*/).Append((char)/*Error near IL_0019: Stack underflow*/).Append((object?)(_FF00_FF00_FF00_FF00_FF00鴀().ToString() * -1521134295))).GetHashCode((Type)((BedrockProxy.Logger__BackingField + (object)EqualityComparer<Type>.Default) * -1521134295))).GetHashCode((MobileSession)((BedrockProxy)this).GameType)) * -1521134295 + ((EqualityComparer<int>)((EqualityComparer<EnumGameType>)(object)EqualityComparer<string>.Default).GetHashCode((EnumGameType)(((object)((BedrockProxy)this).Session + (object)EqualityComparer<EnumGameType>.Default) * -1521134295))).GetHashCode((int)((BedrockProxy)this).EndPoints__BackingField)) * -1521134295)) ? 1 : 0, (int)BedrockProxy.CloneProxy)) * -1521134295)) + ((MobileSession)((ConnectedPong)this).ClientTimestamp__BackingField).PatchInfo);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00鰀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778447, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00鴀()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00鸀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778448, new IntPtr(2737337525244L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00鼀()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00ꀀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778449, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00ꄀ()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return EntityLaunchBedrockProxy._FF00_FF00_FF00_FF00_FF00鄀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00ꈀ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778450, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00ꌀ(uint P_0)
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
				Name__BackingField = P_0;
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
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00ꐀ(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0067: Expected I4, but got Obj
		//IL_013e: Expected I4, but got Obj
		//IL_013e: Expected Obj, but got I4
		//IL_01dd: Expected Obj, but got I
		//IL_01dd: Expected Obj, but got I8
		//IL_01de: Expected I4, but got Obj
		//IL_0232: Expected I4, but got Obj
		//IL_0238: Expected I4, but got Obj
		//IL_01f8: Expected I, but got I8
		//IL_01f8: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I4
		//IL_0251: Expected Obj, but got I8
		//IL_0195: Expected Obj, but got I8
		//IL_0222->IL00c5: Incompatible stack heights: 1 vs 0
		//IL_00e0->IL0128: Incompatible stack heights: 2 vs 0
		//IL_0109->IL01c7: Incompatible stack heights: 3 vs 0
		//IL_0157->IL0026: Incompatible stack types: I4 vs Obj
		//IL_022c->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00ee->IL0022: Incompatible stack heights: 2 vs 0
		//IL_011d->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0256->IL0026: Incompatible stack types: I4 vs Obj
		//IL_019a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0207->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0162->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0128->IL0026: Incompatible stack heights: 4 vs 1
		//IL_0261->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01a5->IL0026: Incompatible stack types: I4 vs Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		object obj = 12;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 12:
					if (this == P_0)
					{
						return 1;
					}
					obj2 = 11;
					break;
				case 6:
					RuntimeHelpers.EnsureSufficientExecutionStack();
					_ = ((BedrockProxy)this).Name;
					_ = ((BedrockProxy)P_0).GameId;
					if (EqualityComparer<MobileSession>.Default == null)
					{
						goto end_IL_0026;
					}
					goto case 3;
				case 8:
					((EqualityComparer<MobileSession>)/*Error near IL_00f3: Stack underflow*/).GetHashCode((MobileSession)/*Error near IL_00f3: Stack underflow*/);
					_ = ((BedrockProxy)this).ServerPort;
					_ = ((BedrockProxy)P_0).Session;
					if (EqualityComparer<EnumGameType>.Default == null)
					{
						_ = 0;
						if (((BedrockProxy)BedrockProxy.Listener__BackingField).EndPoints__BackingField != null)
						{
							_ = 1;
						}
						break;
					}
					goto case 5;
				case 3:
					if (!((EqualityComparer<int>)((EqualityComparer<int>)/*Error near IL_012d: Stack underflow*/).GetHashCode((int)/*Error near IL_012d: Stack underflow*/)).Equals((int)((BedrockProxy)this).ProxyPort__BackingField, (int)BedrockProxy.CloneProxy))
					{
						obj2 = 7;
						if (((ConnectedPong)(object)ConnectedPing.DecorateVirtualExecutor).ClientTimestamp__BackingField == 0L)
						{
							obj2 = 5;
						}
						break;
					}
					goto case 8;
				case 11:
					if (P_0 != null)
					{
						obj2 = 9;
						if (ConnectedPong.CheckCustomizableNode != null)
						{
							obj2 = 2;
						}
						break;
					}
					goto default;
				case 5:
					((ILogger)/*Error near IL_01cc: Stack underflow*/).Information<_0021_00210>((string)/*Error near IL_01cc: Stack underflow*/, (_0021_00210)/*Error near IL_01cc: Stack underflow*/);
					return (byte)(int)((string?)/*Error near IL_01dd: Stack underflow*/ + (string?)((ConnectionRequest)this).Time__BackingField + (string?)((ConnectionRequest)P_0).UseEncryption__BackingField);
				default:
					return 0;
				case 13:
					((Action<RakNetSession>)/*Error near IL_01e7: Stack underflow*/)._002Ector((object)/*Error near IL_01e7: Stack underflow*/, (nint)/*Error near IL_01e7: Stack underflow*/);
					((Func<IPAddress, IPEndPoint>)/*Error near IL_01f8: Stack underflow*/)._002Ector((object)((ConnectionRequestAccepted)this).SystemIndex__BackingField, (nint)((ConnectionRequestAccepted)P_0).RequestTimestamp__BackingField);
					if ((int)/*Error near IL_01fd: Stack underflow*/ == 0)
					{
						obj2 = 2;
						break;
					}
					goto case 4;
				case 4:
				{
					Enumerable.Select<TSource, TResult>((IEnumerable<TSource>)/*Error near IL_020c: Stack underflow*/, (Func<TSource, TResult>)/*Error near IL_020c: Stack underflow*/);
					uint num = ((FrameSetPacket)this).SequenceNumber__BackingField;
					GC.SuppressFinalize(((FrameSetPacket)P_0).Frames__BackingField);
					if (num == 0)
					{
						_ = 14;
						break;
					}
					goto case 6;
				}
				case 9:
					((BedrockProxy)/*Error near IL_0232: Stack underflow*/).ProxyPort = (int)this;
					((BedrockProxy)/*Error near IL_0238: Stack underflow*/).StartListen((int)P_0);
					((EventBus)/*Error near IL_023d: Stack underflow*/).Register<T>((Action<T>)/*Error near IL_023d: Stack underflow*/, (int)/*Error near IL_023d: Stack underflow*/);
					if ((int)/*Error near IL_0242: Stack underflow*/ == 0)
					{
						obj2 = 0;
						if (((NewIncomingConnection)NewIncomingConnection.RequestTimestamp__BackingField).AcceptedTimestamp__BackingField == 0L)
						{
							obj2 = 0;
						}
						break;
					}
					goto case 13;
				}
				continue;
				end_IL_0026:
				break;
			}
			obj = 10;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00ꔀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778451, new IntPtr(2737337520044L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00ꘀ()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe byte _FF00_FF00_FF00_FF00_FF00관(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778452, new IntPtr(2737337523164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe byte _FF00_FF00_FF00_FF00_FF00글(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0063: Expected I4, but got Obj
		//IL_0205: Expected Obj, but got I8
		//IL_0132: Expected Obj, but got I4
		//IL_00b0: Expected I4, but got Obj
		//IL_0152: Expected Obj, but got I4
		//IL_01c6: Expected I4, but got Obj
		//IL_01d5: Expected Obj, but got I4
		//IL_0220: Expected I8, but got Obj
		//IL_01e1: Expected I4, but got Obj
		//IL_011b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_020a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_013d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ca->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0235->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01f1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01b5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0189->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00fb->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0126->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0215->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00aa->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0240->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01c0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0194->IL0026: Incompatible stack types: I4 vs Obj
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
				case 12:
					((StringBuilder)_FF00_FF00_FF00_FF00_FF00鄀())._002Ector();
					obj2 = 7;
					continue;
				case 6:
					((EntityLaunchBedrockProxy)/*Error near IL_0085: Stack underflow*/)._FF00_FF00_FF00_FF00_FF00뀀(P_0);
					((StringBuilder)/*Error near IL_008a: Stack underflow*/).Append((object?)/*Error near IL_008a: Stack underflow*/);
					obj2 = 12;
					if (((BedrockProxy)BedrockProxy.Logger__BackingField).Name == null)
					{
						obj2 = 5;
					}
					continue;
				case 3:
					((EntityLaunchBedrockProxy)/*Error near IL_00b0: Stack underflow*/)._FF00_FF00_FF00_FF00_FF00輀((EnumGameType)P_0);
					_ = EqualityComparer<MobileSession>.Default;
					obj2 = 2;
					if (((BedrockProxy)(object)BedrockProxy.ServerAddress).ServerPort != 0)
					{
						obj2 = 2;
					}
					continue;
				case 13:
					((EntityLaunchBedrockProxy)P_0)._FF00_FF00_FF00_FF00_FF00謀((object)this);
					obj = (object)/*Error near IL_00de: Stack underflow*/;
					((EqualityComparer<EnumGameType>)(object)(*(StringBuilder*)/*Error near IL_00eb: Stack underflow*/)/*cast due to constrained. prefix*/).GetHashCode((EnumGameType)(int)(&obj));
					_ = EqualityComparer<int>.Default;
					_ = 10;
					continue;
				default:
					((EqualityComparer<EnumGameType>)/*Error near IL_0106: Stack underflow*/).Equals((EnumGameType)/*Error near IL_0106: Stack underflow*/, (EnumGameType)((EntityLaunchBedrockProxy)/*Error near IL_0101: Stack underflow*/)._FF00_FF00_FF00_FF00_FF00글(P_0));
					obj2 = 8;
					if (((ConnectedPing)BedrockProxy.CloneProxy).ClientTimestamp__BackingField != 0L)
					{
						obj2 = 1;
					}
					continue;
				case 2:
					_ = (Type?)/*Error near IL_0132: Stack underflow*/ == (Type?)((EntityLaunchBedrockProxy)P_0)._FF00_FF00_FF00_FF00_FF00贀((object)this);
					obj2 = 5;
					continue;
				case 4:
					((GameInstance)((EntityLaunchBedrockProxy)P_0)._FF00_FF00_FF00_FF00_FF00ꄀ())._002Ector();
					obj = 13;
					break;
				case 10:
					return 1;
				case 11:
					((EntityLaunchBedrockProxy)/*Error near IL_0160: Stack underflow*/).Deconstruct(out *(MobileSession*)/*Error near IL_0160: Stack underflow*/, out *(string*)/*Error near IL_0160: Stack underflow*/, out *(EnumGameType*)/*Error near IL_0160: Stack underflow*/, out *(string*)/*Error near IL_0160: Stack underflow*/, out *(string*)P_0, out *(int*)this);
					obj = (object)/*Error near IL_0162: Stack underflow*/;
					((IPEndPoint)(object)(*(Dns*)/*Error near IL_016f: Stack underflow*/)/*cast due to constrained. prefix*/)._002Ector((IPAddress)/*Error near IL_016f: Stack underflow*/, (int)(&obj));
					_ = (string?)/*Error near IL_0174: Stack underflow*/ + (string?)/*Error near IL_0174: Stack underflow*/ + (string?)/*Error near IL_0174: Stack underflow*/;
					obj2 = 3;
					if (((ConnectionRequestAccepted)ConnectionRequestAccepted.ClientAddress__BackingField).SystemIndex__BackingField != 0)
					{
						obj2 = 1;
					}
					continue;
				case 9:
					((BedrockProxy)P_0).Listener = (RakNetServer?)(object)this;
					((Func<IPAddress, IPEndPoint>)/*Error near IL_01a0: Stack underflow*/)._002Ector((object)/*Error near IL_01a0: Stack underflow*/, (nint)/*Error near IL_01a0: Stack underflow*/);
					obj2 = 3;
					if (((FrameSetPacket)ConnectionRequestAccepted.DecorateRandomExtractor).SequenceNumber__BackingField == 0)
					{
						obj2 = 4;
					}
					continue;
				case 5:
					((BedrockProxy)/*Error near IL_01c6: Stack underflow*/).EndPointIndex = (int)P_0;
					GC.SuppressFinalize((object)/*Error near IL_01cb: Stack underflow*/);
					obj = 9;
					break;
				case 8:
					((BedrockProxy)P_0).ProxyPort = (int)this;
					((Action<EventPluginChanged>)/*Error near IL_01e6: Stack underflow*/)._002Ector((object)/*Error near IL_01e6: Stack underflow*/, (nint)/*Error near IL_01e6: Stack underflow*/);
					obj2 = 6;
					continue;
				case 1:
					((EventBus)/*Error near IL_01f6: Stack underflow*/).Register<T>((Action<T>)/*Error near IL_01f6: Stack underflow*/, (int)/*Error near IL_01f6: Stack underflow*/);
					obj2 = 0;
					if (((NewIncomingConnection)NewIncomingConnection.RequestTimestamp__BackingField).AcceptedTimestamp__BackingField == 0L)
					{
						obj2 = 0;
					}
					continue;
				case 7:
					BedrockProxy.RegisterEvents();
					((IByteBuffer)/*Error near IL_0220: Stack underflow*/).WriteLong((long)P_0);
					obj2 = 11;
					if (((IncompatibleProtocolVersion)AlreadyConnected.RestartGenerator).ServerProtocol__BackingField == 0)
					{
						obj2 = 11;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe byte _FF00_FF00_FF00_FF00_FF00꼀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778453, new IntPtr(2737337520044L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00뀀(object P_0)
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
				Name__BackingField = P_0;
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
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00넀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778454, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00눀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected I4, but got Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (uint)(int)Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00대()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778455, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00됀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778456, new IntPtr(2737337510684L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00딀()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (EntityLaunchBedrockProxy.Name__BackingField == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00똀(nint P_0, nint P_1, nint P_2, nint P_3, nint P_4, nint P_5)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_00dc: Expected I4, but got Obj
		//IL_008e: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I
		//IL_00b6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0099->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0087->IL0026: Incompatible stack types: I4 vs Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		object obj = 6;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 3:
				Unsafe.Write((void*)P_3, _FF00_FF00_FF00_FF00_FF00鄀());
				obj2 = 2;
				break;
			case 2:
				Unsafe.Write((void*)P_4, _FF00_FF00_FF00_FF00_FF00鴀());
				obj2 = 1;
				if ((object)ReflectScheduledLogger == null)
				{
					obj2 = 0;
				}
				break;
			case 5:
				((EntityLaunchBedrockProxy)P_1)._FF00_FF00_FF00_FF00_FF00蘀(this);
				Unsafe.Write((void*)(nint)/*Error near IL_008f: Stack underflow*/, /*Error near IL_008f: Stack underflow*/);
				obj2 = 4;
				break;
			case 1:
				*(EnumGameType*)P_5 = _FF00_FF00_FF00_FF00_FF00餀();
				obj2 = 0;
				if (((BedrockProxy)(object)BedrockProxy.GameId).GameType != 0)
				{
					obj2 = 0;
				}
				break;
			case 0:
				return;
			case 6:
				((EntityLaunchBedrockProxy)P_0)._FF00_FF00_FF00_FF00_FF00舀(this);
				Unsafe.Write((void*)(nint)/*Error near IL_00ca: Stack underflow*/, /*Error near IL_00ca: Stack underflow*/);
				obj2 = 5;
				break;
			case 4:
				*(int*)P_2 = (int)_FF00_FF00_FF00_FF00_FF00褀();
				obj2 = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00뜀(nint P_0, nint P_1, nint P_2, nint P_3, nint P_4, nint P_5)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778457, new IntPtr(2737337527324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
