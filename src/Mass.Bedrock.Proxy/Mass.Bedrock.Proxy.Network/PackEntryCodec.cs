using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using DotNetty.Buffers;
using Mass.Application.Mobile;
using Mass.Application.Models;
using Mass.Domain.Desktop.ValueObjects;

namespace Mass.Bedrock.Proxy.Network;

public static class PackEntryCodec
{
	internal static PackEntryCodec DecorateSetAllocator;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static PackEntry ReadPackEntry(this IByteBuffer buffer)
	{
		return (PackEntry)_FF00_FF00_FF00_FF00_1400(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WritePackEntry(this IByteBuffer buffer, PackEntry entry)
	{
		_FF00_FF00_FF00_FF00ᘀ(buffer, entry);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckEfficientQueue()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PackEntryCodec ReflectAttachedSender()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_0E00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778818, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00ༀ()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return EntityLaunchBedrockProxy.Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00က()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778819, new IntPtr(2737337520044L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00ᄀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778820, new IntPtr(2737337512764L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00ሀ()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (EntityLaunchBedrockProxy.Name__BackingField == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00ጀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778821, new IntPtr(2737337523164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_1400(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 2111, 1790778822, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778822, new IntPtr(2737337531484L), 15);
		}
		return ((delegate*<object, object>)obj)(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00ᔀ(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778823, new IntPtr(2737337527324L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00_FF00ᘀ(object P_0, object P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_008d: Expected I4, but got Obj
		//IL_0055: Expected Obj, but got I4
		//IL_00a6->IL0026: Incompatible stack heights: 2 vs 1
		//IL_007a->IL0026: Incompatible stack heights: 2 vs 1
		//IL_005a->IL0022: Incompatible stack heights: 2 vs 0
		//IL_00b1->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0085->IL0026: Incompatible stack heights: 2 vs 1
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
				case 2:
					break;
				case 1:
					((EntityLaunchBedrockProxy)P_0).Session = (MobileSession)P_1;
					_ = ((EntityLaunchBedrockProxy)/*Error near IL_0066: Stack underflow*/).GameId;
					_ = 0;
					if (((BedrockProxy)BedrockProxy.Logger__BackingField).Name == null)
					{
						_ = 0;
					}
					continue;
				case 3:
					return;
				default:
					((EntityLaunchBedrockProxy)P_0).GameType = (EnumGameType)P_1;
					_ = ((EntityLaunchBedrockProxy)/*Error near IL_0092: Stack underflow*/).Name;
					_ = 2;
					if (((BedrockProxy)(object)BedrockProxy.ServerAddress).ServerPort == 0)
					{
						_ = 0;
					}
					continue;
				}
				break;
			}
			_ = ((EntityLaunchBedrockProxy)(object)((EntityLaunchBedrockProxy)P_1).EqualityContract).Session;
			obj = 3;
		}
	}
}
