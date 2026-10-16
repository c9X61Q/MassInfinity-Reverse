using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.Common.Models;

namespace Mass.Common.Helpers;

public static class AssemblyHelper
{
	[CompilerGenerated]
	private static readonly object VersionInfo__BackingField;

	[CompilerGenerated]
	private static readonly object Version__BackingField;

	[CompilerGenerated]
	private static readonly object? Name__BackingField;

	[CompilerGenerated]
	private static readonly object? Path__BackingField;

	[CompilerGenerated]
	private static readonly object? Directory__BackingField;

	internal static AssemblyHelper? ReflectJoinedChain;

	public static FileVersionInfo VersionInfo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	public static string Version
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	public static string? Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	public static string? Path
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	public static string? Directory
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	static AssemblyHelper()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_00c4: Expected Obj, but got I4
		//IL_0081->IL0012: Incompatible stack types: I4 vs Obj
		//IL_01b9->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00f3->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0165->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0194->IL0012: Incompatible stack types: I4 vs Obj
		//IL_011d->IL0012: Incompatible stack types: I4 vs Obj
		//IL_008c->IL0012: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0012: Incompatible stack types: I4 vs Obj
		//IL_013c->IL0012: Incompatible stack types: I4 vs Obj
		//IL_01c4->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0170->IL0012: Incompatible stack types: I4 vs Obj
		//IL_019f->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0128->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 5;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				object obj5;
				object obj3;
				object obj4;
				object obj6;
				switch ((int)obj2)
				{
				case 7:
				{
					Assembly? entryAssembly2 = Assembly.GetEntryAssembly();
					if ((object)entryAssembly2 == null)
					{
						obj2 = 2;
						continue;
					}
					obj5 = entryAssembly2.GetName().Name;
					goto IL_014c;
				}
				case 5:
					VersionInfo__BackingField = FileVersionInfo.GetVersionInfo(Environment.ProcessPath);
					obj2 = 1;
					if (_003CModule_003E_007B4371cb51_002D3aac_002D43d2_002Da948_002D4dbd622b7dec_007D.m_1b5af9bf88cb406d9ea9459d99b3a863.m_49812867cd6147d58febc4354f08355c != 0)
					{
						obj2 = 4;
					}
					continue;
				case 6:
					return;
				case 10:
					if (Path == null)
					{
						goto end_IL_0012;
					}
					goto default;
				default:
					obj3 = System.IO.Path.GetDirectoryName(Path);
					break;
				case 1:
				{
					Assembly? entryAssembly = Assembly.GetEntryAssembly();
					if ((object)entryAssembly == null)
					{
						obj2 = 3;
						continue;
					}
					obj4 = entryAssembly.Location;
					goto IL_017b;
				}
				case 4:
					obj6 = VersionInfo.FileVersion;
					if (obj6 != null)
					{
						goto IL_012d;
					}
					obj2 = 2;
					if (_003CModule_003E_007B4371cb51_002D3aac_002D43d2_002Da948_002D4dbd622b7dec_007D.m_1b5af9bf88cb406d9ea9459d99b3a863.m_191789f4bc914b9e971c2b97405c55e5 == 0)
					{
						obj2 = 9;
					}
					continue;
				case 9:
					obj6 = ZYXDNGuarder._FF00蔀();
					goto IL_012d;
				case 2:
					obj5 = null;
					goto IL_014c;
				case 3:
					obj4 = null;
					goto IL_017b;
				case 8:
					{
						obj3 = null;
						break;
					}
					IL_012d:
					Version__BackingField = obj6;
					obj2 = 7;
					continue;
					IL_014c:
					Name__BackingField = obj5;
					obj2 = 0;
					if (_003CModule_003E_007B4371cb51_002D3aac_002D43d2_002Da948_002D4dbd622b7dec_007D.m_1b5af9bf88cb406d9ea9459d99b3a863.m_9b468029b7fb4c608ae3785e1c3347b4 == 0)
					{
						obj2 = 1;
					}
					continue;
					IL_017b:
					Path__BackingField = obj4;
					obj2 = 10;
					if (_003CModule_003E_007B4371cb51_002D3aac_002D43d2_002Da948_002D4dbd622b7dec_007D.m_1b5af9bf88cb406d9ea9459d99b3a863.m_2f184996951b4d6685f102df10de52c8 != 0)
					{
						obj2 = 7;
					}
					continue;
				}
				Directory__BackingField = obj3;
				obj2 = 1;
				if (_003CModule_003E_007B4371cb51_002D3aac_002D43d2_002Da948_002D4dbd622b7dec_007D.m_1b5af9bf88cb406d9ea9459d99b3a863.m_08f8517ba5b64a0e86b6d7d7d044562d == 0)
				{
					obj2 = 6;
				}
				continue;
				end_IL_0012:
				break;
			}
			obj = 8;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateLiteralEnumerator()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AssemblyHelper? ReflectScalableParameter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object? _FF00笀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778450, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object? _FF00簀()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ApiResponseBase<>.ManageProvider;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object? _FF00紀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778453, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object? _FF00縀()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ApiResponseBase<>.ManageProvider;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object? _FF00缀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778452, new IntPtr(2737337521084L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object? _FF00耀()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ApiResponseBase<>.ManageProvider;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object? _FF00脀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778455, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object? _FF00舀()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ApiResponseBase<>.ManageProvider;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00茀()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ApiResponseBase<>.ManageProvider == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00萀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778454, new IntPtr(2737337516924L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object? _FF00蘀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778457, new IntPtr(2737337514844L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object? _FF00蜀()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ApiResponseBase<>.ManageProvider;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object? _FF00蠀()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ApiResponseBase<>.ManageProvider;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object? _FF00褀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778456, new IntPtr(2737337519004L), 15))(null, 0, new IntPtr(0L));
		return (object?)/*Error near IL_0033: Stack underflow*/;
	}
}
