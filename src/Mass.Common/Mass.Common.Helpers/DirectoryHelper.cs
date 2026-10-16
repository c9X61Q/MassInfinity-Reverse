using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.Common.Extensions;
using Mass.Common.Localization;
using Mass.Common.Models;
using Serilog;

namespace Mass.Common.Helpers;

public static class DirectoryHelper
{
	[CompilerGenerated]
	private static readonly object Logger__BackingField;

	private static object ReflectStaticWatcher;

	private static ILogger Logger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string Search(string rootPath, string fileName)
	{
		return (string)_FF00ꠀ(rootPath, fileName);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Create(string dir, bool log = true)
	{
		_FF00ꔀ(dir, log ? ((byte)1) : ((byte)0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Delete(string dir)
	{
		_FF00ꨀ(dir);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ClearReadOnly(string dir)
	{
		_FF00鼀(dir);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Copy(string src, string dest)
	{
		_FF00ꄀ(src, dest);
	}

	static DirectoryHelper()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_001f: Expected I4, but got Obj
		//IL_004d->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0058->IL0012: Incompatible stack types: I4 vs Obj
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
				Logger__BackingField = Log.Logger.Category((string)ZYXDNGuarder._FF00鰀());
				obj2 = 0;
				if (_003CModule_003E_007B4371cb51_002D3aac_002D43d2_002Da948_002D4dbd622b7dec_007D.m_1b5af9bf88cb406d9ea9459d99b3a863.m_f9edc8d8cd7f4faead1b102bfad50330 == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckDynamicElement()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DirectoryHelper CheckConcreteDriver()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00餀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778418, new IntPtr(2737337521084L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00騀()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ApiResponseBase<>.ManageProvider;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00鬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778421, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00鴀()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ApiResponseBase<>.ManageProvider == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00鼀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0073: Expected I4, but got Obj
		//IL_0265: Expected Obj, but got I4
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_01d7: Expected Obj, but got I4
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_01ca: Expected Obj, but got I4
		//IL_009c: Expected native int or pointer, but got Obj
		//IL_026f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01bb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01eb->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0211->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01d4->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01a0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01f6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00a6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_021c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0248->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01ab->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0253->IL0026: Incompatible stack types: I4 vs Obj
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 16;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
			case 8:
				if ((nint)obj >= ((Array)obj).Length)
				{
					obj2 = 0;
					if (((ApiResponseBase<>._003CThen_003Ed__10*)(nint)ApiResponseBase<>.ManageProvider)->_003C_003E1__state != 0)
					{
						obj2 = 2;
					}
					break;
				}
				goto case 9;
			case 9:
			{
				object obj3 = ((object[])obj)[obj];
				((ApiResponseBase<ApiResponse<_00210>>)obj3)._002Ector();
				_ = obj3 & -2;
				/*Error near IL_00bf: Member reference must be method, but was: Field*/;
			}
			default:
				/*Error near IL_00d1: Member reference must be method, but was: Field*/;
			case 7:
			case 10:
				_ = ((AsyncTaskMethodBuilder<_00210>*)((object[])obj)[obj])->Task & -2;
				/*Error near IL_010b: Member reference must be method, but was: Field*/;
			case 16:
				/*Error near IL_0130: Member reference must be method, but was: Field*/;
			case 2:
				_ = ((ApiResponseBase<>)obj).Msg;
				_ = 1;
				/*Error near IL_015b: Member reference must be method, but was: Field*/;
			case 4:
			case 14:
				if ((nint)obj >= ((Array)obj).Length)
				{
					return;
				}
				obj2 = 10;
				if (((ResourceLocalizer)LocalizationManager.ReflectAdaptableSingleton)._003CresourceManager_003EP != null)
				{
					obj2 = 9;
				}
				break;
			case 5:
				obj++;
				obj2 = 4;
				break;
			case 13:
				((ApiResponseBase<>)obj)._002Ector();
				obj = ((TaskAwaiter*)1)->IsCompleted;
				obj2 = 6;
				break;
			case 6:
				obj = 0;
				obj2 = 1;
				if (AssemblyHelper.Name__BackingField == null)
				{
					obj2 = 0;
				}
				break;
			case 12:
				return;
			case 11:
				obj++;
				obj2 = 3;
				if (AssemblyHelper.Directory__BackingField != null)
				{
					obj2 = 8;
				}
				break;
			case 17:
				return;
			case 15:
				obj = new IAsyncStateMachine((IAsyncStateMachine)P_0);
				obj2 = 0;
				if (((BiDictionary<, >)(object)BiDictionary<, >._forward)._reverse != null)
				{
					obj2 = 0;
				}
				break;
			case 3:
				obj = 0;
				obj2 = 14;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00ꄀ(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0077: Expected I4, but got Obj
		//IL_0156: Expected Obj, but got I4
		//IL_0216: Expected VT, but got Obj
		//IL_00a8: Expected Obj, but got I4
		//IL_00b2: Expected native int or pointer, but got Obj
		//IL_00cd: Expected I4, but got Obj
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected Obj, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_025d: Expected I4, but got Obj
		//IL_0113: Expected Obj, but got I4
		//IL_023c->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0160->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0222->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00bc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0257->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0153->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0273->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0127->IL0026: Incompatible stack heights: 3 vs 1
		//IL_0247->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00c7->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0143->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00e6->IL0026: Incompatible stack types: I4 vs Obj
		//IL_027e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0205->IL0026: Incompatible stack types: I4 vs Obj
		//IL_017f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0132->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00f1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0210->IL0026: Incompatible stack types: I4 vs Obj
		//IL_018a->IL0026: Incompatible stack types: I4 vs Obj
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 7;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 11:
				_ = ((object[])obj)[obj];
				/*Error near IL_0082: Member reference must be method, but was: Field*/;
			case 17:
				return;
			case 5:
				obj = 0;
				obj2 = 0;
				if (((ApiResponseBase<>._003CThen_003Ed__10*)(nint)ApiResponseBase<>._003CThen_003Ed__10.task)->_003C_003E4__this != null)
				{
					obj2 = 0;
				}
				continue;
			case 7:
				((ApiResponseBase<_00210>)/*Error near IL_00cd: Stack underflow*/).Code = (int)P_0;
				if ((int)/*Error near IL_00d2: Stack underflow*/ == 0)
				{
					obj2 = 5;
					if (((ErrorResponse)ErrorResponse.Type__BackingField).Title__BackingField != null)
					{
						obj2 = 6;
					}
				}
				else
				{
					((ApiResponseBase<>)/*Error near IL_0139: Stack underflow*/).Msg = (string)P_0;
					obj2 = 2;
				}
				continue;
			case 6:
				((ApiResponse<>)/*Error near IL_00f6: Stack underflow*/).Data = (T?)/*Error near IL_00f6: Stack underflow*/;
				((ILogger)/*Error near IL_0102: Stack underflow*/).Warning<string>((Exception)(object)((ApiResponse<>)/*Error near IL_00fb: Stack underflow*/).SetData((T)/*Error near IL_00fb: Stack underflow*/), (string)P_0, (string)P_1);
				obj2 = 16;
				continue;
			case 15:
				_ = ((ApiResponseBase<>)0).Code;
				_ = 4;
				if (ErrorResponse._003C_003Ec._003C_003E9__22_0 != null)
				{
					_ = 3;
				}
				continue;
			case 16:
				return;
			case 10:
				obj++;
				obj2 = 14;
				continue;
			case 3:
				obj = 0;
				obj2 = 18;
				continue;
			default:
				if ((nint)obj >= ((Array)obj).Length)
				{
					obj2 = 5;
					if (LocalizationManager.CultureChanged != null)
					{
						obj2 = 17;
					}
					continue;
				}
				goto case 11;
			case 1:
			case 8:
			{
				object obj3 = ((object[])obj)[obj];
				((IAsyncStateMachine)obj3).MoveNext();
				obj = obj3;
				/*Error near IL_019a: Member reference must be method, but was: Field*/;
			}
			case 13:
			case 18:
				if ((nint)obj < ((Array)obj).Length)
				{
					obj2 = 1;
					if (AssemblyHelper.Path__BackingField != null)
					{
						obj2 = 1;
					}
					continue;
				}
				break;
			case 4:
				((AsyncTaskMethodBuilder<_00210>*)/*Error near IL_0216: Stack underflow*/)->SetResult((_00210)P_0);
				obj = (object)/*Error near IL_0218: Stack underflow*/;
				obj2 = 3;
				continue;
			case 2:
				ApiResponseBase<>._003CThen_003Ed__10.CheckOrderedMap();
				_ = 15;
				if (((BiDictionary<, >)(object)BiDictionary<, >._forward)._reverse == null)
				{
					_ = 13;
				}
				continue;
			case 9:
				obj++;
				obj2 = 13;
				continue;
			case 12:
				break;
			}
			((List<string>)/*Error near IL_025d: Stack underflow*/)._002Ector((int)P_0);
			obj = (object)/*Error near IL_025f: Stack underflow*/;
			obj2 = 5;
			if (ConfigHelper.CheckIsolatedTester != null)
			{
				obj2 = 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00ꈀ(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778420, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00ꌀ()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ApiResponseBase<>.ManageProvider;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00ꔀ(object P_0, byte P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0070: Expected VT, but got Obj
		//IL_00ae->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0089->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0059->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0094->IL0026: Incompatible stack types: I4 vs Obj
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
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
				if (P_1 != 0)
				{
					obj2 = 5;
					break;
				}
				goto case 3;
			case 3:
				/*Error near IL_005a: Member reference must be method, but was: Field*/;
			case 2:
				((ApiResponse<_00210>)/*Error near IL_0070: Stack underflow*/).Data = (_00210?)P_0;
				if ((int)/*Error near IL_0075: Stack underflow*/ != 0)
				{
					return;
				}
				obj2 = 1;
				if (((ApiResponseBase<>._003CThen_003Ed__10)ApiResponseBase<>._003CThen_003Ed__10._003C_003Et__builder).task == null)
				{
					obj2 = 1;
				}
				break;
			case 5:
				((ILogger)ApiResponse.Create()).Warning<string>((string)(object)ApiResponse.Create<T>(), (string)P_0);
				obj2 = 3;
				break;
			case 4:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00ꘀ(object P_0, byte P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778423, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_A700(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778422, new IntPtr(2737337530444L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00ꠀ(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 784, 1790778425, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778425, new IntPtr(2737337529404L), 15);
		}
		return ((delegate*<object, object, object>)obj)(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00꤀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778424, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00ꨀ(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0098: Expected Obj, but got I4
		//IL_00ac->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00b7->IL0026: Incompatible stack types: I4 vs Obj
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				/*Error near IL_0041: Member reference must be method, but was: Field*/;
			case 2:
				return;
			case 1:
				return;
			}
			((ApiResponseBase<_00210>)P_0).Msg = (string)1;
			obj2 = 1;
			if (((ErrorResponse)ErrorResponse.Title__BackingField).Status__BackingField != 0)
			{
				obj2 = 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00_AB00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778427, new IntPtr(2737337526284L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
