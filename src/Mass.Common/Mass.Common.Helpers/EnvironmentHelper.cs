using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mass.Common.Models;

namespace Mass.Common.Helpers;

public static class EnvironmentHelper
{
	public static readonly OSPlatform Platform;

	internal static EnvironmentHelper DecorateConnectedWriter;

	static EnvironmentHelper()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_010a: Expected Obj, but got VT
		//IL_011b: Expected VT, but got Obj
		//IL_0099: Expected Obj, but got I4
		//IL_004b: Expected VT, but got Obj
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_0114->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00a3->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0096->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0055->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00f7->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00de->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00be->IL0012: Incompatible stack types: I4 vs Obj
		//IL_012a->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00c9->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 6;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 7:
				Platform = (OSPlatform)obj;
				obj2 = 3;
				break;
			case 6:
				obj = typeof(OSPlatform).GetProperties(BindingFlags.Static | BindingFlags.Public);
				obj2 = 5;
				break;
			case 5:
				obj = 0;
				obj2 = 2;
				break;
			case 3:
				return;
			case 1:
			case 2:
				if ((nint)obj >= ((Array)obj).Length)
				{
					obj2 = 9;
					break;
				}
				goto default;
			case 9:
				Platform = OSPlatform.Create((string)ZYXDNGuarder._FF00뀀());
				obj2 = 8;
				break;
			case 8:
				return;
			default:
				obj = (OSPlatform)((PropertyInfo)((object[])obj)[obj]).GetValue((object?)null);
				obj2 = 4;
				break;
			case 4:
				if (RuntimeInformation.IsOSPlatform((OSPlatform)obj))
				{
					obj2 = 7;
					break;
				}
				obj++;
				obj2 = 1;
				if (_003CModule_003E_007B4371cb51_002D3aac_002D43d2_002Da948_002D4dbd622b7dec_007D.m_1b5af9bf88cb406d9ea9459d99b3a863.m_f9f3f2b10d3948abb67d7d44cb223ecf != 0)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectAlphabeticDic()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EnvironmentHelper ReflectEditableObject()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00가()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778426, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00관()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ApiResponseBase<>.ManageProvider == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00글()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778429, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00꼀()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ApiResponseBase<>.ManageProvider;
	}
}
