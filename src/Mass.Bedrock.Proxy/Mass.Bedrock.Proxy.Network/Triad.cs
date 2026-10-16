using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using DotNetty.Buffers;
using Mass.Application.Models;
using Mass.Domain.Desktop.ValueObjects;

namespace Mass.Bedrock.Proxy.Network;

public static class Triad
{
	private static object DecorateScheduledAttribute;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteTriadLE(this IByteBuffer buffer, uint value)
	{
		_FF00_FF00_FF00픀(buffer, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static uint ReadTriadLE(this IByteBuffer buffer)
	{
		return _FF00_FF00_FF00휀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectFilteredAuthorizer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Triad MoveRequester()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00츀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778858, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00케()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return EntityLaunchBedrockProxy.Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00퀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778859, new IntPtr(2737337523164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00턀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778860, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00툀()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (EntityLaunchBedrockProxy.Name__BackingField == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00픀(object P_0, uint P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0067->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b7->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0072->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c2->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00ef->IL0026: Incompatible stack heights: 3 vs 1
		//IL_010f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00fa->IL0026: Incompatible stack heights: 3 vs 1
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				((StringBuilder)P_0).Append((char)(byte)(P_1 >> 8));
				obj2 = 3;
				if (((EntityLaunchBedrockProxy)EntityLaunchBedrockProxy.ServerAddress__BackingField).ServerPort__BackingField == 0)
				{
					obj2 = 3;
				}
				break;
			case 1:
				return;
			case 3:
				_ = (byte)(P_1 >> 16);
				_ = EqualityComparer<Type>.Default;
				_ = 1;
				if (((BedrockProxy)(object)BedrockProxy.GameId).GameType == 0)
				{
					_ = 1;
				}
				break;
			case 2:
				((EntityLaunchBedrockProxy)/*Error near IL_00c7: Stack underflow*/).Name = (string)/*Error near IL_00c7: Stack underflow*/;
				throw new EqualityComparer<string>(((EntityLaunchBedrockProxy)/*Error near IL_00cc: Stack underflow*/).ServerAddress);
			case 4:
				_ = (byte)P_1;
				_ = EqualityComparer<EnumGameType>.Default;
				_ = 0;
				if (((BedrockProxy)BedrockProxy.Listener__BackingField).EndPoints__BackingField == null)
				{
					_ = 0;
				}
				break;
			case 5:
				if (P_1 <= 16777215)
				{
					obj2 = 4;
					break;
				}
				goto case 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_FF00_FF00혀(object P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778861, new IntPtr(2737337511724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00휀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001a: Expected I4, but got Obj
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected I4, but got Unknown
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		StringBuilder stringBuilder = ((StringBuilder)/*Error near IL_001a: Stack underflow*/).Append((char)(int)P_0);
		((StringBuilder)P_0)._002Ector();
		object obj = stringBuilder;
		obj = P_0.ToString();
		return (uint)(/*Error near IL_002f: Stack underflow*/ | (obj << 8) | (obj << 16));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static uint _FF00_FF00_FF00_FFFD(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778862, new IntPtr(2737337527324L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}
}
