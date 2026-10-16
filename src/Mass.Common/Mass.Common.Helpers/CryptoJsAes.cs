using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using Mass.Common.Localization;
using Mass.Common.Models;
using Serilog;

namespace Mass.Common.Helpers;

public static class CryptoJsAes
{
	public const string Key = "";

	internal static CryptoJsAes CustomizeProfile;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static string Encrypt(string plainText, string password = "lzYW5qaXVqa")
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 121, 1790778438, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778438, new IntPtr(2737337517964L), 15);
		}
		return (string)((delegate*<object, object, object>)obj)(plainText, password);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static string Decrypt(string encryptedText, string password = "lzYW5qaXVqa")
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 122, 1790778441, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778441, new IntPtr(2737337532524L), 15);
		}
		return (string)((delegate*<object, object, object>)obj)(encryptedText, password);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object EvpBytesToKey(uint keySize, uint ivSize, object password, object salt)
	{
		return _FF00ⴀ(keySize, ivSize, password, salt);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectSeparatedInitializer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CryptoJsAes InstantiateSolver()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_2200()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778440, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_2300()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ApiResponseBase<>.ManageProvider == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_2400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778443, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_2700(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0057: Expected I4, but got Obj
		//IL_03b6: Expected Obj, but got I4
		//IL_03bb: Expected Obj, but got I4
		//IL_043a: Expected native int or pointer, but got Obj
		//IL_03f6: Expected Obj, but got I4
		//IL_03ff: Expected Obj, but got I4
		//IL_03ff: Expected Obj, but got I4
		//IL_0406: Expected Obj, but got I4
		//IL_0406: Expected Obj, but got I4
		//IL_041f: Expected Obj, but got I4
		//IL_0463: Expected Obj, but got I4
		//IL_00f6: Expected Obj, but got VT
		//IL_03d1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0444->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0417->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0429->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03dc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0477->IL0026: Incompatible stack heights: 3 vs 1
		//IL_044f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0497->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0482->IL0026: Incompatible stack heights: 3 vs 1
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 9;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 7:
				/*Error near IL_005c: Member reference must be method, but was: Field*/;
			case 1:
				((ApiResponseBase<_00210>)/*Error near IL_009d: Stack underflow*/).Msg = (string)/*Error near IL_009d: Stack underflow*/;
				/*Error near IL_009e: Member reference must be method, but was: Field*/;
			case 5:
			{
				_ = ((AsyncTaskMethodBuilder<_00210>*)2)->Task;
				int num = 0;
				if (((ErrorResponse)(object)ErrorResponse.Errors__BackingField).TraceId__BackingField == null)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						/*Error near IL_011e: Member reference must be method, but was: Field*/;
					}
					obj = new AsyncTaskMethodBuilder<_00210>(ref *(TStateMachine*)obj);
					num = 1;
					if (ErrorResponse._003C_003Ec._003C_003E9__22_0 == null)
					{
						num = 0;
					}
				}
			}
			default:
				obj = ((IEnumerable)((IEnumerable<IPEndPoint>)obj).Any((Func<IPEndPoint, bool>)16)).OfType<string>();
				obj2 = 1;
				if ((int)((FileHelper._003CReadAllBytesAsync_003Ed__11*)FileHelper._003CReadAllBytesAsync_003Ed__11._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					obj2 = 0;
				}
				break;
			case 6:
			{
				object obj3 = obj;
				LocalizationManager.SetCulture((string)obj);
				((AsyncTaskMethodBuilder*)obj3)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter*)obj3, ref *(ProcessHelper._003CWaitProcessModule_003Ed__3*)32);
				obj = ((IEnumerable)16).Cast<ProcessModule>();
				obj = ((IEnumerable<_00210>)((IEnumerable<byte>)((IEnumerable<ProcessModule>)32).Any((Func<ProcessModule, bool>)32)).Select((Func<byte, string>)16)).Reverse();
				obj2 = 4;
				break;
			}
			case 9:
				obj = ((Dictionary<_00210, _00211>)P_0).Count;
				obj2 = 8;
				break;
			case 4:
				obj = ((Dictionary<_00210, _00211>)/*Error near IL_042e: Stack underflow*/).Keys;
				obj2 = 5;
				if (((FileHelper._003CWriteAllLinesAsync_003Ed__6*)(nint)FileHelper._003CWriteAllBytesAsync_003Ed__3.CheckResponsiveAuditor)->_003C_003E1__state != 0)
				{
					obj2 = 1;
				}
				break;
			case 3:
				_ = AssemblyHelper.Name;
				/*Error near IL_0454: Member reference must be method, but was: Field*/;
			case 2:
				_ = 8;
				obj = 8;
				_ = 0;
				if ((int)((FileHelper._003CWriteAllTextAsync_003Ed__5*)FileHelper._003CWriteAllTextAsync_003Ed__5._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					_ = 0;
				}
				break;
			case 8:
				if (((Array)obj).Length >= 16)
				{
					obj2 = 7;
					break;
				}
				goto case 3;
			case 10:
				return obj;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_2800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778442, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_2900()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ApiResponseBase<>.ManageProvider;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_2A00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778445, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_2B00(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0065: Expected Obj, but got I4
		//IL_0070: Expected Obj, but got I4
		//IL_008d: Expected VT, but got I4
		//IL_0092: Expected VT, but got Obj
		//IL_0094: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I4
		//IL_00b3->IL0026: Incompatible stack types: I4 vs Obj
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
				case 3:
					/*Error near IL_0048: Member reference must be method, but was: Field*/;
				case 4:
					break;
				case 1:
					return obj;
				case 5:
					goto IL_0078;
				case 2:
					/*Error near IL_00b3: Member reference must be method, but was: Field*/;
				default:
					_ = 2;
					/*Error near IL_00dd: Member reference must be method, but was: Field*/;
				}
				break;
				IL_0078:
				object obj3 = obj;
				((NonDVMAttribute)obj)._002Ector();
				((DefaultInterpolatedStringHandler*)obj3)->AppendFormatted((_00210)32);
				((DefaultInterpolatedStringHandler*)16)->AppendFormatted((_00211)obj3);
				obj = 32;
				((ILogger)/*Error near IL_009b: Stack underflow*/).Warning<string>((string)/*Error near IL_009b: Stack underflow*/, (string)32);
				((ILogger)/*Error near IL_00a2: Stack underflow*/).Debug<string>((string)/*Error near IL_00a2: Stack underflow*/, (string)16);
				obj = JsonSerializer.Serialize((_0021_00210)/*Error near IL_00a7: Stack underflow*/, (JsonSerializerOptions?)/*Error near IL_00a7: Stack underflow*/);
				obj2 = 2;
			}
			((ApiResponseBase<ApiResponse<_00210>>)8)._002Ector();
			obj = (object)/*Error near IL_0067: Stack underflow*/;
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00Ⰰ(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778444, new IntPtr(2737337529404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00ⴀ(uint P_0, uint P_1, object P_2, object P_3)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0047: Expected I4, but got Obj
		//IL_00c2: Expected Obj, but got I4
		//IL_0262: Expected I4, but got Obj
		//IL_0265: Invalid comparison between Unknown and I4
		//IL_0187: Expected Obj, but got I4
		//IL_016c: Expected I4, but got Obj
		//IL_016c: Expected Obj, but got I4
		//IL_0083->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b8->IL0026: Incompatible stack types: I4 vs Obj
		//IL_027e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e5->IL00f4: Incompatible stack heights: 1 vs 4
		//IL_0289->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0115->IL011a: Incompatible stack heights: 3 vs 0
		//IL_00f0->IL00f4: Incompatible stack heights: 1 vs 4
		//IL_01de->IL00f4: Incompatible stack heights: 6 vs 4
		//IL_0191->IL00f4: Incompatible stack heights: 3 vs 4
		//IL_01e9->IL00f4: Incompatible stack heights: 6 vs 4
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			int num;
			switch ((int)obj2)
			{
			case 1:
				/*Error near IL_004c: Member reference must be method, but was: Field*/;
			default:
				obj = Interlocked.CompareExchange(ref *(Action<CultureInfo>*)/*Error near IL_0077: Stack underflow*/, (Action<CultureInfo>)/*Error near IL_0077: Stack underflow*/, (Action<CultureInfo>)/*Error near IL_0077: Stack underflow*/);
				obj2 = 3;
				break;
			case 5:
				((ApiResponseBase<_00210>)/*Error near IL_00ac: Stack underflow*/).Msg = (string)/*Error near IL_00ac: Stack underflow*/;
				obj = (object)/*Error near IL_00ae: Stack underflow*/;
				obj2 = 6;
				break;
			case 2:
				((ILogger)/*Error near IL_00c2: Stack underflow*/).Debug<string>((string)obj, (string)(P_0 + P_1));
				return JsonSerializer.Serialize((_0021_00210)/*Error near IL_00c7: Stack underflow*/, (JsonSerializerOptions?)/*Error near IL_00c7: Stack underflow*/);
			case 6:
				if (((Array)obj).Length != 0)
				{
					_ = 0;
					if (((ErrorResponse)(object)ErrorResponse.Errors__BackingField).TraceId__BackingField == null)
					{
						_ = 0;
					}
					goto IL_00f4;
				}
				goto IL_011a;
			case 3:
			case 4:
				goto IL_025b;
				IL_011a:
				_ = ((Array)P_2).Length;
				((AsyncTaskMethodBuilder<_00210>*)null)->Start<TStateMachine>(ref *(TStateMachine*)null);
				num = 1;
				if (ErrorResponse._003C_003Ec._003C_003E9__22_0 == null)
				{
					num = 5;
				}
				goto IL_00f4;
				IL_00f4:
				while (true)
				{
					switch (num)
					{
					case 1:
						break;
					case 5:
						_ = 0;
						_ = ((Array)P_3).Length;
						_ = null;
						_ = 0;
						/*Error near IL_0151: Member reference must be method, but was: Field*/;
					case 4:
						((IEnumerable<byte>)0).Skip((int)obj);
						_ = 0;
						_ = 0;
						/*Error near IL_016e: Member reference must be method, but was: Field*/;
					case 2:
						((IAsyncStateMachine)obj).MoveNext();
						obj = 0;
						_ = 3;
						continue;
					case 3:
						/*Error near IL_0195: Member reference must be method, but was: Field*/;
					default:
						_ = 0;
						((AsyncTaskMethodBuilder<_00210>*)((Array)obj).Length)->AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref *(TAwaiter*)null, ref *(TStateMachine*)null);
						_ = 1;
						if (AssemblyHelper.Path__BackingField != null)
						{
							_ = 1;
						}
						continue;
					case 6:
						goto IL_025b;
					}
					break;
				}
				goto IL_011a;
				IL_025b:
				CollectionsMarshal.SetCount<T>((List<T>)/*Error near IL_0262: Stack underflow*/, (int)obj);
				if ((int)/*Error near IL_026a: Stack underflow*/ >= (int)(P_0 + P_1))
				{
					obj2 = 2;
					if (ConsoleHelper.DecorateIntegratedDecryptor != null)
					{
						obj2 = 2;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_2E00(uint P_0, uint P_1, object P_2, object P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778447, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
