using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Mass.Application.Mobile;
using Mass.Domain.Desktop.ValueObjects;

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

	internal static EntityLaunchBedrockProxy ReflectScheduledLogger;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EntityLaunchBedrockProxy(MobileSession Session, string GameId, EnumGameType GameType, string Name, string ServerAddress, int ServerPort)
	{
		//IL_0065: Expected I4, but got Obj
		//IL_0053->IL005c: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		EntityLaunchBedrockProxy entityLaunchBedrockProxy = this;
		if (0 == 0)
		{
			entityLaunchBedrockProxy = (EntityLaunchBedrockProxy)0;
		}
		switch ((int)entityLaunchBedrockProxy)
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
	protected EntityLaunchBedrockProxy(EntityLaunchBedrockProxy original)
	{
		//IL_004a: Expected I4, but got Obj
		//IL_0020->IL0029: Incompatible stack types: I4 vs Obj
		//IL_00cd->IL0029: Incompatible stack heights: 2 vs 1
		//IL_00b2->IL0029: Incompatible stack heights: 2 vs 1
		//IL_007b->IL0029: Incompatible stack heights: 2 vs 1
		//IL_006b->IL0029: Incompatible stack heights: 3 vs 1
		//IL_005d->IL0029: Incompatible stack heights: 3 vs 1
		//IL_0096->IL0029: Incompatible stack heights: 2 vs 1
		//IL_00d8->IL0029: Incompatible stack heights: 2 vs 1
		//IL_00bd->IL0029: Incompatible stack heights: 2 vs 1
		//IL_0086->IL0029: Incompatible stack heights: 2 vs 1
		//IL_00a1->IL0029: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		EntityLaunchBedrockProxy entityLaunchBedrockProxy = this;
		if (0 == 0)
		{
			entityLaunchBedrockProxy = (EntityLaunchBedrockProxy)1;
		}
		while (true)
		{
			switch ((int)entityLaunchBedrockProxy)
			{
			case 4:
				_ = 3;
				break;
			case 3:
				_ = 5;
				break;
			case 2:
				if (6 != 0)
				{
					_ = 0;
				}
				break;
			case 5:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 6:
				return;
			case 1:
				if (true)
				{
					_ = 4;
				}
				break;
			default:
				if (false)
				{
					_ = 2;
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
	internal void _FF00_FF00_FF00_FF00_FF00舀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0045->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 1:
				if (0 == 0)
				{
					_ = 0;
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
	internal static byte _FF00_FF00_FF00_FF00_FF00萀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0081: Expected I4, but got Obj
		//IL_0072->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0044->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007d->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (false)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 1;
			case 1:
				return (byte)(int)P_1;
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
	internal void _FF00_FF00_FF00_FF00_FF00蘀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0045->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 1:
				if (false)
				{
					_ = 0;
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
	internal object _FF00_FF00_FF00_FF00_FF00褀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00言()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778439, new IntPtr(2737337511724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00謀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				if (false)
				{
					_ = 0;
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
	internal byte _FF00_FF00_FF00_FF00_FF00贀(object P_0)
	{
		//IL_000c: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00踀(EnumGameType P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778441, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00輀(EnumGameType P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0045->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 1:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00退()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected object _FF00_FF00_FF00_FF00_FF00鄀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_000a: Stack underflow*/;
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
	internal static byte _FF00_FF00_FF00_FF00_FF00需(object P_0, object P_1)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (P_1 == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00頀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778445, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal EnumGameType _FF00_FF00_FF00_FF00_FF00餀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (EnumGameType)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe EnumGameType _FF00_FF00_FF00_FF00_FF00騀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778446, new IntPtr(2737337532524L), 15))(null, 0, new IntPtr(0L));
		return (EnumGameType)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_FF00_FF00_FF00鬀()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected I4, but got Unknown
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)((((((this * -1521134295 + this) * -1521134295 + this) * -1521134295 + this) * -1521134295 + this) * -1521134295 + this) * -1521134295 + this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_FF00_FF00_FF00鰀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778447, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00鴀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00鸀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778448, new IntPtr(2737337525244L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00鼀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00ꀀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778449, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00ꄀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00ꈀ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778450, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00ꌀ(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0045->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		while (true)
		{
			switch ((int)obj)
			{
			default:
				return;
			case 1:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00ꐀ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_005a: Expected I4, but got Obj
		//IL_0169: Expected I4, but got Obj
		//IL_00bc: Expected Obj, but got I4
		//IL_00ee->IL00c1: Incompatible stack heights: 1 vs 0
		//IL_018d->IL00a8: Incompatible stack heights: 1 vs 0
		//IL_00b3->IL00e3: Incompatible stack heights: 1 vs 0
		//IL_00cc->IL0162: Incompatible stack heights: 1 vs 0
		//IL_01a1->IL016d: Incompatible stack heights: 1 vs 0
		//IL_0178->IL0182: Incompatible stack heights: 1 vs 0
		//IL_0197->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c1->IL0015: Incompatible stack heights: 1 vs 0
		//IL_0135->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00a8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0182->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0105->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01b8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0140->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					if (P_0 == null)
					{
						goto end_IL_0019;
					}
					goto case 3;
				case 8:
					obj2 = this;
					if (P_0 == null)
					{
						if (false)
						{
							obj2 = 1;
						}
						break;
					}
					goto case 5;
				case 3:
					obj2 = this;
					if (P_0 == null)
					{
						if (7 == 0)
						{
							obj2 = 5;
						}
						break;
					}
					goto case 8;
				case 11:
					if (P_0 != null)
					{
						if (9 != 0)
						{
							obj2 = 2;
						}
						break;
					}
					goto default;
				case 5:
					return (byte)(int)P_0;
				default:
					return 0;
				case 13:
					if (P_0 == null)
					{
						_ = 2;
						break;
					}
					goto case 4;
				case 4:
					if (P_0 == null)
					{
						_ = 14;
						break;
					}
					goto case 6;
				case 9:
					obj2 = this;
					if (P_0 == null)
					{
						if (0 == 0)
						{
							obj2 = 0;
						}
						break;
					}
					goto case 13;
				}
				continue;
				end_IL_0019:
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
	internal object _FF00_FF00_FF00_FF00_FF00ꘀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe byte _FF00_FF00_FF00_FF00_FF00관(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778452, new IntPtr(2737337523164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected byte _FF00_FF00_FF00_FF00_FF00글(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0056: Expected I4, but got Obj
		//IL_00ec: Expected Obj, but got I4
		//IL_013e: Expected Obj, but got I4
		//IL_00c5->IL0019: Incompatible stack heights: 0 vs 1
		//IL_015f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00df->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0095->IL0019: Incompatible stack heights: 0 vs 1
		//IL_007a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_017a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0152->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00d0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_016a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0085->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0185->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0131->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0115->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					_ = 7;
					continue;
				case 6:
					if (12 == 0)
					{
						obj2 = 5;
					}
					continue;
				case 3:
					if (2 != 0)
					{
						obj2 = 2;
					}
					continue;
				case 13:
					obj = this;
					_ = ref obj;
					_ = 10;
					continue;
				default:
					if (8 != 0)
					{
						obj2 = 1;
					}
					continue;
				case 2:
					_ = 5;
					continue;
				case 4:
					obj = 13;
					break;
				case 10:
					return 1;
				case 11:
					obj2 = P_0;
					obj = this;
					_ = ref obj;
					if (3 != 0)
					{
						obj2 = 1;
					}
					continue;
				case 9:
					obj2 = P_0;
					if (3 == 0)
					{
						obj2 = 4;
					}
					continue;
				case 5:
					obj = 9;
					break;
				case 8:
					_ = 6;
					continue;
				case 1:
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 7:
					if (11 == 0)
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
	internal void _FF00_FF00_FF00_FF00_FF00뀀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				if (0 == 0)
				{
					_ = 0;
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
	internal uint _FF00_FF00_FF00_FF00_FF00눀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
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
	internal static byte _FF00_FF00_FF00_FF00_FF00딀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00똀(nint P_0, nint P_1, nint P_2, nint P_3, nint P_4, nint P_5)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_007d: Expected I4, but got Obj
		//IL_00a7: Expected I4, but got Obj
		//IL_0089->IL0019: Incompatible stack heights: 0 vs 1
		//IL_005f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0078->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0094->IL0019: Incompatible stack types: I4 vs Obj
		//IL_006a->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				Unsafe.Write((void*)P_3, this);
				obj2 = 2;
				break;
			case 2:
				Unsafe.Write((void*)P_4, this);
				if (1 == 0)
				{
					obj2 = 0;
				}
				break;
			case 5:
				Unsafe.Write((void*)P_1, this);
				obj2 = 4;
				break;
			case 1:
				*(int*)P_5 = (int)this;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 0:
				return;
			case 6:
				Unsafe.Write((void*)P_0, this);
				obj2 = 5;
				break;
			case 4:
				*(int*)P_2 = (int)this;
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
