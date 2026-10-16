using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Mass.Common.Extensions;
using Mass.Common.Localization;
using Mass.Common.Models;
using Serilog;

namespace Mass.Common.Helpers;

public static class FileHelper
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CReadAllBytesAsync_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<byte[]> _003C_003Et__builder;

		public string path;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		internal static object ReflectSimpleSummarizer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DecorateControllableProgram()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckTransferableTemplate()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_0600()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778391, new IntPtr(2737337519004L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_0700()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_003f: Expected I4, but got Obj
			//IL_004c: Expected Obj, but got I4
			//IL_004c: Expected Obj, but got Ref
			//IL_033a: Expected Obj, but got Ref
			//IL_0255: Expected Obj, but got Ref
			//IL_009e: Expected Obj, but got VT
			//IL_015e: Expected Obj, but got Ref
			//IL_0199: Expected Obj, but got I4
			//IL_019e: Expected Obj, but got I4
			//IL_019e: Expected Obj, but got Ref
			//IL_0283: Expected Obj, but got I4
			//IL_0288: Expected Obj, but got I4
			//IL_0288: Expected Obj, but got Ref
			//IL_0185: Expected Obj, but got Ref
			//IL_0127: Expected Obj, but got Ref
			//IL_012f: Expected Obj, but got Ref
			//IL_012f: Expected Obj, but got Ref
			//IL_0141: Expected Obj, but got Ref
			//IL_01e5: Expected Obj, but got Ref
			//IL_01e7: Expected Obj, but got VT
			//IL_01d9: Expected Obj, but got I4
			//IL_0206: Expected Obj, but got Ref
			//IL_0106: Expected Obj, but got Ref
			//IL_00fb: Expected I4, but got Obj
			//IL_0060->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0350->IL0026: Incompatible stack types: I4 vs Obj
			//IL_006b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00a3->IL00b2: Incompatible stack types: I4 vs Obj
			//IL_035b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0158->IL00b2: Incompatible stack types: I4 vs Obj
			//IL_0273->IL00b2: Incompatible stack types: I4 vs Obj
			//IL_00ae->IL00b2: Incompatible stack types: I4 vs Obj
			//IL_027e->IL00b2: Incompatible stack types: I4 vs Obj
			//IL_01b2->IL00b2: Incompatible stack types: I4 vs Obj
			//IL_0292->IL00b2: Incompatible stack types: I4 vs Obj
			//IL_0139->IL00b2: Incompatible stack heights: 3 vs 1
			//IL_014b->IL00b2: Incompatible stack types: I4 vs Obj
			//IL_01f1->IL00b2: Incompatible stack types: I4 vs Obj
			//IL_0220->IL00b2: Incompatible stack types: I4 vs Obj
			//IL_0112->IL00b2: Incompatible stack types: I4 vs Obj
			//IL_01bd->IL00b2: Incompatible stack types: I4 vs Obj
			//IL_0194->IL00b2: Incompatible stack types: I4 vs Obj
			//IL_022b->IL00b2: Incompatible stack types: I4 vs Obj
			((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				default:
					ApiResponseBase<>.ManageProvider = -2;
					obj2 = 0;
					if ((int)((ApiResponseBase<>._003CThen_003Ed__10*)ApiResponseBase<>._003CThen_003Ed__10._003C_003E1__state)->_003C_003Et__builder != 0)
					{
						obj2 = 1;
					}
					break;
				case 4:
					return;
				case 1:
					_ = ref ((ApiResponseBase<>._003CThen_003Ed__10)this).task;
					/*Error near IL_0074: Member reference must be method, but was: Field*/;
				case 2:
					if (obj == null)
					{
						obj3 = 6;
						if (((ErrorResponse)ApiResponseBase<>._003CThen_003Ed__10._003C_003Eu__1).Type__BackingField != null)
						{
							obj3 = 2;
						}
						goto IL_00b2;
					}
					goto IL_024f;
				case 3:
					{
						obj = CryptoJsAes.Key;
						obj2 = 0;
						if (DateTimeHelper.DecorateOrderedTransformer == null)
						{
							obj2 = 2;
						}
						break;
					}
					IL_014b:
					obj = null;
					obj3 = 14;
					goto IL_00b2;
					IL_00b2:
					while (true)
					{
						switch ((int)obj3)
						{
						case 11:
							break;
						case 5:
							return;
						case 6:
						case 16:
							obj = ((ErrorResponse)Unsafe.AsPointer(ref this)).Title__BackingField;
							obj3 = 15;
							continue;
						case 9:
							_ = ref ((ErrorResponse)Unsafe.AsPointer(ref this)).Status__BackingField;
							JsonSerializer.Deserialize<_0021_00210>((string)(&obj), (JsonSerializerOptions?)Unsafe.AsPointer(ref this));
							_ = 5;
							continue;
						case 10:
							((ErrorResponse)Unsafe.AsPointer(ref this)).TraceId__BackingField = obj;
							obj3 = 9;
							continue;
						case 3:
							goto IL_014b;
						default:
							_ = ErrorResponse.FlushFilter;
							obj = null;
							AsyncTaskMethodBuilder<_00210>.Create();
							/*Error near IL_016d: Member reference must be method, but was: Field*/;
						case 8:
							((object)(&obj))._002Ector();
							if ((int)/*Error near IL_018a: Stack underflow*/ != 0)
							{
								obj3 = 7;
								continue;
							}
							goto case 4;
						case 2:
							obj = -1;
							LocalizationManager.CultureChanged = (Action<CultureInfo>?)(-1);
							obj3 = 8;
							if (((ResourceLocalizer)LocalizationManager.ReflectAdaptableSingleton)._003CresourceManager_003EP == null)
							{
								obj3 = 13;
							}
							continue;
						case 12:
						case 14:
							obj = obj;
							obj = 11;
							obj3 = obj;
							continue;
						case 7:
						case 13:
							obj = ((Task)(&obj)).GetAwaiter();
							obj3 = 12;
							continue;
						case 15:
							AssemblyHelper.VersionInfo__BackingField = null;
							obj3 = 1;
							if (AssemblyHelper.Path__BackingField != null)
							{
								obj3 = 2;
							}
							continue;
						case 1:
							goto IL_024f;
						case 4:
							obj = 0;
							ConfigHelper.CheckIsolatedTester = (ConfigHelper)0;
							obj3 = 10;
							continue;
						}
						break;
					}
					goto default;
					IL_024f:
					((Dictionary<string, List<string>>)(object)((BiDictionary<, >)Unsafe.AsPointer(ref this))._forward)._002Ector();
					if ((int)/*Error near IL_025f: Stack underflow*/ != 0)
					{
						obj3 = 0;
						if (ConfigHelper.Logger__BackingField == null)
						{
							obj3 = 0;
						}
						goto IL_00b2;
					}
					goto IL_014b;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00ࠀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778390, new IntPtr(2737337521084L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_0900(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778393, new IntPtr(2737337519004L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_0A00(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected Obj, but got Ref
			//IL_0059->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((ApiResponse<_00210>)Unsafe.AsPointer(ref ApiResponseBase<>.ManageProvider)).Data = (_00210?)P_0;
					obj2 = 0;
					if (((ApiResponseBase<>._003CThen_003Ed__10)ApiResponseBase<>._003CThen_003Ed__10._003C_003Et__builder).task == null)
					{
						obj2 = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_0B00()
		{
			((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (ApiResponseBase<>.ManageProvider == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_0C00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778392, new IntPtr(2737337519004L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_0D00()
		{
			((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return ApiResponseBase<>.ManageProvider;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_0E00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778395, new IntPtr(2737337530444L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CWriteAllBytesAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string path;

		public byte[] content;

		private TaskAwaiter _003C_003Eu__1;

		internal static object CheckResponsiveAuditor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DecorateSortedDecider()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SetupLogger()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void ﴀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778394, new IntPtr(2737337530444L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FE00()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_003f: Expected I4, but got Obj
			//IL_005e: Expected Obj, but got I4
			//IL_004c: Expected Obj, but got I4
			//IL_004c: Expected Obj, but got Ref
			//IL_0113: Expected Obj, but got Ref
			//IL_011e: Expected Obj, but got I4
			//IL_00bf: Expected Obj, but got I
			//IL_0108: Expected I4, but got Obj
			//IL_01f9: Expected Obj, but got Ref
			//IL_0210: Expected Obj, but got Ref
			//IL_021a: Expected native int or pointer, but got Obj
			//IL_025c: Expected Obj, but got Ref
			//IL_0129: Expected Obj, but got Ref
			//IL_0131: Expected VT, but got Ref
			//IL_01cd: Expected Obj, but got Ref
			//IL_01d3: Expected Obj, but got Ref
			//IL_01a2: Expected Obj, but got I4
			//IL_01a7: Expected Obj, but got I4
			//IL_01a7: Expected Obj, but got Ref
			//IL_01b7: Expected Obj, but got Ref
			//IL_0236: Expected Obj, but got Ref
			//IL_0179: Expected Obj, but got I4
			//IL_017e: Expected Obj, but got I4
			//IL_017e: Expected Obj, but got Ref
			//IL_026b: Expected native int or pointer, but got Obj
			//IL_0072->IL0026: Incompatible stack types: I4 vs Obj
			//IL_009c->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0056->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00c4->IL00d3: Incompatible stack types: I4 vs Obj
			//IL_007d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00a7->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00cf->IL00d3: Incompatible stack types: I4 vs Obj
			//IL_0208->IL00d3: Incompatible stack types: I4 vs Obj
			//IL_0224->IL00d3: Incompatible stack types: I4 vs Obj
			//IL_0145->IL00d3: Incompatible stack heights: 4 vs 1
			//IL_01f3->IL00d3: Incompatible stack types: I4 vs Obj
			//IL_01b1->IL00d3: Incompatible stack types: I4 vs Obj
			//IL_01c7->IL00d3: Incompatible stack types: I4 vs Obj
			//IL_024a->IL00d3: Incompatible stack heights: 2 vs 1
			//IL_0192->IL00d3: Incompatible stack types: I4 vs Obj
			//IL_022f->IL00d3: Incompatible stack types: I4 vs Obj
			//IL_0275->IL00d3: Incompatible stack types: I4 vs Obj
			//IL_0150->IL00d3: Incompatible stack heights: 4 vs 1
			//IL_0255->IL00d3: Incompatible stack heights: 2 vs 1
			//IL_019d->IL00d3: Incompatible stack types: I4 vs Obj
			//IL_0280->IL00d3: Incompatible stack types: I4 vs Obj
			((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				case 4:
					ApiResponseBase<>.ManageProvider = -2;
					obj2 = 3;
					break;
				case 1:
					obj = ((ApiResponseBase<>._003CThen_003Ed__10)this)._003C_003E1__state;
					obj2 = 0;
					if (((ApiResponseBase<>._003CThen_003Ed__10)ApiResponseBase<>._003CThen_003Ed__10._003C_003Et__builder).task != null)
					{
						obj2 = 0;
					}
					break;
				case 3:
					((ApiResponseBase<_00210>)/*Error near IL_0088: Stack underflow*/).Code = (int)Unsafe.AsPointer(ref ((ApiResponseBase<>._003CThen_003Ed__10)this)._003C_003E4__this);
					obj2 = 2;
					if (((ErrorResponse)ErrorResponse.Type__BackingField).Title__BackingField != null)
					{
						obj2 = 2;
					}
					break;
				case 2:
					return;
				default:
					{
						if (obj != null)
						{
							obj3 = 0;
							if (((ErrorResponse)ErrorResponse.Status__BackingField).Errors__BackingField != null)
							{
								obj3 = 0;
							}
							goto IL_00d3;
						}
						goto IL_010d;
					}
					IL_010d:
					obj = ((ErrorResponse)Unsafe.AsPointer(ref this)).TraceId__BackingField;
					obj = 8;
					obj3 = obj;
					goto IL_00d3;
					IL_00d3:
					while (true)
					{
						switch ((int)obj3)
						{
						case 4:
							break;
						case 6:
							return;
						case 9:
							goto IL_010d;
						case 3:
							_ = ref ErrorResponse.FlushFilter;
							_ = ref obj;
							Marshal.SizeOf((ConsoleHelper.CONSOLE_FONT_INFO_EX)Unsafe.AsPointer(ref this));
							_ = 6;
							if (ErrorResponse._003C_003Ec.CheckVisualVisitor == null)
							{
								_ = 5;
							}
							continue;
						case 11:
							obj = 0;
							LocalizationManager.ReflectAdaptableSingleton = 0;
							obj3 = 0;
							if (ResourceLocalizer.InitAuthorizer == null)
							{
								obj3 = 1;
							}
							continue;
						case 7:
							obj = -1;
							AssemblyHelper.VersionInfo__BackingField = -1;
							obj3 = 10;
							continue;
						case 8:
							AssemblyHelper.Version__BackingField = null;
							obj3 = 7;
							continue;
						case 5:
						{
							object? obj4 = AssemblyHelper.Path__BackingField;
							object? obj5 = AssemblyHelper.Directory__BackingField;
							obj = null;
							((AsyncTaskMethodBuilder<_00210>*)obj5)->SetStateMachine((IAsyncStateMachine)obj);
							((Dictionary<string, List<string>>)obj4)._002Ector();
							obj = (object)/*Error near IL_01e9: Stack underflow*/;
							obj3 = 2;
							continue;
						}
						default:
							((ErrorResponse)/*Error near IL_01fe: Stack underflow*/).Type = (string)BiDictionary<, >.ExecuteViewer;
							obj3 = 5;
							continue;
						case 1:
							ConfigHelper.CheckIsolatedTester = (ConfigHelper)obj;
							obj3 = 3;
							if (((ConsoleHelper.CONSOLE_FONT_INFO_EX*)(nint)ConsoleHelper.DecorateIntegratedDecryptor)->cbSize == 0)
							{
								obj3 = 0;
							}
							continue;
						case 10:
							_ = ((Dictionary<string, List<string>>)(&obj)).Count;
							_ = 4;
							if (((ConsoleHelper.CONSOLE_FONT_INFO_EX)ConsoleHelper.CONSOLE_FONT_INFO_EX.dwFontSize).FontFamily != 0)
							{
								_ = 1;
							}
							continue;
						case 2:
							if (string.Join<T>((char)/*Error near IL_025c: Stack underflow*/, (IEnumerable<T>)(&obj)) == null)
							{
								obj3 = 11;
								if (((ConsoleHelper.COORD*)(nint)ConsoleHelper.CONSOLE_FONT_INFO_EX.FaceName)->X != 0)
								{
									obj3 = 0;
								}
								continue;
							}
							goto case 10;
						}
						break;
					}
					goto case 4;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778397, new IntPtr(2737337530444L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00Ā(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778396, new IntPtr(2737337530444L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00Ȁ(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0044: Expected VT, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((ApiResponse<_00210>)Unsafe.AsPointer(ref ApiResponseBase<>.ManageProvider)).Data = (_00210?)P_0;
					obj2 = 0;
					if (((ApiResponseBase<>._003CThen_003Ed__10)ApiResponseBase<>._003CThen_003Ed__10._003C_003Et__builder).task == null)
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
		private unsafe sealed void _FF00_0300(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778399, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00Ѐ()
		{
			((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (ApiResponseBase<>.ManageProvider == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00Ԁ()
		{
			((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return ApiResponseBase<>.ManageProvider;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CWriteAllLinesAsync_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string path;

		public IEnumerable<string> contents;

		private TaskAwaiter _003C_003Eu__1;

		internal static object ViewConnection;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CheckSequentialContext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ScanAuthorizer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _F400()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778398, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _F500()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_003f: Expected I4, but got Obj
			//IL_004c: Expected Obj, but got I4
			//IL_004c: Expected Obj, but got Ref
			//IL_005e: Expected Obj, but got I4
			//IL_0322: Expected Obj, but got Ref
			//IL_0327: Expected Obj, but got Ref
			//IL_0228: Expected Obj, but got Ref
			//IL_0090: Expected native int or pointer, but got Obj
			//IL_0100: Expected Obj, but got I4
			//IL_0105: Expected Obj, but got I4
			//IL_0105: Expected Obj, but got Ref
			//IL_0114: Expected Obj, but got I
			//IL_023d: Expected Obj, but got Ref
			//IL_012a: Expected Obj, but got Ref
			//IL_0130: Expected Obj, but got Ref
			//IL_00ec: Expected Obj, but got I4
			//IL_00f1: Expected Obj, but got I4
			//IL_00f1: Expected Obj, but got Ref
			//IL_01e5: Expected Obj, but got Ref
			//IL_016c: Expected Obj, but got Ref
			//IL_01bc: Expected Obj, but got Ref
			//IL_0056->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0072->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0331->IL0026: Incompatible stack heights: 2 vs 1
			//IL_009a->IL00a9: Incompatible stack heights: 1 vs 2
			//IL_007d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00e2->IL0222: Incompatible stack heights: 1 vs 0
			//IL_00a5->IL00a9: Incompatible stack heights: 1 vs 2
			((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object awaiter = 2;
			object obj = awaiter;
			while (true)
			{
				int num;
				switch ((int)obj)
				{
				default:
					ApiResponseBase<>.ManageProvider = -2;
					obj = 3;
					break;
				case 2:
					awaiter = ((ApiResponseBase<>._003CThen_003Ed__10)this)._003C_003E1__state;
					obj = 1;
					if (((ApiResponseBase<>._003CThen_003Ed__10)ApiResponseBase<>._003CThen_003Ed__10._003C_003Et__builder).task == null)
					{
						obj = 1;
					}
					break;
				case 4:
					return;
				case 1:
					if (awaiter == null)
					{
						_ = 9;
						if ((int)((ApiResponseBase<>._003CThen_003Ed__10*)(nint)ApiResponseBase<>._003CThen_003Ed__10._003C_003E4__this)->_003C_003Eu__1 == 0)
						{
							_ = 11;
						}
						goto IL_00a9;
					}
					goto IL_0222;
				case 3:
					{
						((ResourceManager)/*Error near IL_0327: Stack underflow*/).GetString((string)/*Error near IL_0327: Stack underflow*/, (CultureInfo?)Unsafe.AsPointer(ref EnvironmentHelper.DecorateConnectedWriter));
						_ = 4;
						break;
					}
					IL_0222:
					_ = ((ErrorResponse)ConfigHelper.Logger__BackingField).Title;
					num = 3;
					goto IL_00a9;
					IL_00a9:
					while (true)
					{
						switch (num)
						{
						case 5:
							break;
						case 2:
							return;
						case 4:
							awaiter = -1;
							((ErrorResponse)Unsafe.AsPointer(ref this)).Type__BackingField = -1;
							num = 9;
							continue;
						default:
							awaiter = 0;
							((ErrorResponse)Unsafe.AsPointer(ref this)).Title__BackingField = 0;
							num = 7;
							if (((ErrorResponse)ErrorResponse.Status__BackingField).Errors__BackingField == null)
							{
								num = 8;
							}
							continue;
						case 3:
							_ = ((ErrorResponse)Unsafe.AsPointer(ref this)).TraceId__BackingField;
							_ = ErrorResponse.FlushFilter;
							awaiter = null;
							AsyncTaskMethodBuilder<_00210>.Create();
							/*Error near IL_013f: Member reference must be method, but was: Field*/;
						case 9:
							((IAsyncStateMachine)(&awaiter)).MoveNext();
							num = 5;
							if (ResourceLocalizer.InitAuthorizer == null)
							{
								num = 5;
							}
							continue;
						case 6:
							if (!((TaskAwaiter*)(&awaiter))->IsCompleted)
							{
								num = 0;
								if (AssemblyHelper.Name__BackingField != null)
								{
									num = 0;
								}
								continue;
							}
							goto case 9;
						case 10:
						case 11:
							awaiter = AssemblyHelper.Path__BackingField;
							num = 1;
							if (AssemblyHelper.ReflectJoinedChain == null)
							{
								num = 0;
							}
							continue;
						case 8:
							((BiDictionary<, >)Unsafe.AsPointer(ref this))._forward = (Dictionary<TKey, TValue>)awaiter;
							num = 12;
							continue;
						case 7:
							goto IL_0222;
						case 1:
							ConsoleHelper.DecorateIntegratedDecryptor = null;
							num = 0;
							if ((int)((ConsoleHelper.CONSOLE_FONT_INFO_EX*)(int)ConsoleHelper.CONSOLE_FONT_INFO_EX.nFont)->dwFontSize == 0)
							{
								num = 4;
							}
							continue;
						case 12:
							Unsafe.As<int, AsyncTaskMethodBuilder>(ref ((ConsoleHelper.CONSOLE_FONT_INFO_EX)this).FontFamily).AwaitUnsafeOnCompleted(ref *(TaskAwaiter<string>*)(&awaiter), ref Unsafe.As<_003CWriteAllLinesAsync_003Ed__6, IpHelper._003CInitAsync_003Ed__1>(ref this));
							num = 2;
							continue;
						}
						break;
					}
					goto default;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _F600()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778369, new IntPtr(2737337530444L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _F700(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got Ref
			//IL_0044: Expected VT, but got Obj
			//IL_0044: Expected Obj, but got Ref
			//IL_0058->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0063->IL0026: Incompatible stack types: I4 vs Obj
			((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((ApiResponse<_00210>)Unsafe.AsPointer(ref ApiResponseBase<>.ManageProvider)).Data = (_00210?)P_0;
					obj2 = 0;
					if (((ApiResponseBase<>._003CThen_003Ed__10)ApiResponseBase<>._003CThen_003Ed__10._003C_003Et__builder).task != null)
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
		internal static byte _F800()
		{
			((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (ApiResponseBase<>.ManageProvider == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte 豈()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778368, new IntPtr(2737337519004L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object 切()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778371, new IntPtr(2737337519004L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ﬀ()
		{
			((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return ApiResponseBase<>.ManageProvider;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object ﰀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778370, new IntPtr(2737337519004L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CWriteAllTextAsync_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string path;

		public string content;

		private TaskAwaiter _003C_003Eu__1;

		internal static object InitMatcher;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ReflectAttachedRequester()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateGlobalModule()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _EE00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778373, new IntPtr(2737337519004L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _EF00()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_003f: Expected I4, but got Obj
			//IL_0317: Expected Obj, but got Ref
			//IL_031c: Expected Obj, but got Ref
			//IL_02f2: Expected Obj, but got I4
			//IL_01e7: Expected Obj, but got Ref
			//IL_0167: Expected Obj, but got Ref
			//IL_01fd: Expected VT, but got Ref
			//IL_01d2: Expected Obj, but got I4
			//IL_01d7: Expected Obj, but got I4
			//IL_01d7: Expected Obj, but got Ref
			//IL_0192: Expected Obj, but got Ref
			//IL_0198: Expected Obj, but got Ref
			//IL_00f0: Expected Obj, but got VT
			//IL_0129: Expected Obj, but got I4
			//IL_012e: Expected Obj, but got Ref
			//IL_0137: Expected Obj, but got I4
			//IL_0157: Expected Obj, but got Ref
			//IL_00cf: Expected Obj, but got Ref
			//IL_00cf: Expected Obj, but got Ref
			//IL_0098: Expected I4, but got Obj
			//IL_02ea->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0330->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0306->IL0026: Incompatible stack types: I4 vs Obj
			//IL_033b->IL0026: Incompatible stack types: I4 vs Obj
			//IL_01f6->IL005b: Incompatible stack types: I4 vs Obj
			//IL_0057->IL005b: Incompatible stack types: I4 vs Obj
			//IL_0311->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0181->IL005b: Incompatible stack types: I4 vs Obj
			//IL_01e1->IL005b: Incompatible stack types: I4 vs Obj
			//IL_00f5->IL005b: Incompatible stack types: I4 vs Obj
			//IL_0161->IL005b: Incompatible stack types: I4 vs Obj
			//IL_00d9->IL005b: Incompatible stack heights: 2 vs 1
			//IL_018c->IL005b: Incompatible stack types: I4 vs Obj
			//IL_0216->IL005b: Incompatible stack types: I4 vs Obj
			//IL_0100->IL005b: Incompatible stack types: I4 vs Obj
			//IL_0221->IL005b: Incompatible stack types: I4 vs Obj
			((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			object obj2 = obj;
			while (true)
			{
				object obj3;
				switch ((int)obj2)
				{
				default:
					return;
				case 0:
					return;
				case 3:
					if (obj == null)
					{
						obj3 = 4;
						goto IL_005b;
					}
					goto IL_01e1;
				case 1:
					goto IL_02d8;
				case 4:
					obj = ((ConsoleHelper.COORD)this).Y;
					obj2 = 2;
					if (CryptoJsAes.CustomizeProfile == null)
					{
						obj2 = 3;
					}
					break;
				case 2:
					{
						CultureInfo.CurrentUICulture = (CultureInfo)Unsafe.AsPointer(ref DateTimeHelper.DecorateOrderedTransformer);
						obj2 = 0;
						if ((int)EnvironmentHelper.Platform == 0)
						{
							obj2 = 0;
						}
						break;
					}
					IL_01e1:
					((ApiResponseBase<>._003CThen_003Ed__10*)/*Error near IL_01ec: Stack underflow*/)->SetStateMachine((IAsyncStateMachine)AssemblyHelper.Name__BackingField);
					obj3 = 5;
					goto IL_005b;
					IL_005b:
					while (true)
					{
						switch ((int)obj3)
						{
						case 6:
							return;
						case 12:
							Interlocked.CompareExchange(ref Unsafe.As<AsyncTaskMethodBuilder<TSelf>, Action<CultureInfo>>(ref ((ApiResponseBase<>._003CThen_003Ed__10)this)._003C_003Et__builder), (Action<CultureInfo>)(&obj), (Action<CultureInfo>)Unsafe.AsPointer(ref this));
							_ = 6;
							continue;
						case 4:
						case 8:
							obj = ((ApiResponseBase<>._003CThen_003Ed__10)this)._003C_003E4__this;
							obj3 = 0;
							if (((ErrorResponse)ApiResponseBase<>._003CThen_003Ed__10._003C_003Eu__1).Type__BackingField != null)
							{
								obj3 = 0;
							}
							continue;
						case 7:
						case 13:
							_ = ref obj;
							/*Error near IL_0102: Member reference must be method, but was: Field*/;
						case 10:
							obj = 0;
							((ErrorResponse)Unsafe.AsPointer(ref this)).Status__BackingField = 0;
							obj = 11;
							obj3 = obj;
							continue;
						case 11:
							((ErrorResponse)Unsafe.AsPointer(ref this)).Errors__BackingField = (Dictionary<string, List<string>>)obj;
							obj3 = 12;
							continue;
						default:
							((ErrorResponse)Unsafe.AsPointer(ref this)).TraceId__BackingField = null;
							obj3 = 3;
							if (ErrorResponse._003C_003Ec._003C_003E9__22_0 != null)
							{
								obj3 = 3;
							}
							continue;
						case 5:
							_ = ErrorResponse._003C_003Ec.CheckVisualVisitor;
							_ = LocalizationManager.Culture__BackingField;
							obj = null;
							((IAsyncStateMachine)obj).MoveNext();
							/*Error near IL_01a7: Member reference must be method, but was: Field*/;
						case 3:
							obj = -1;
							AssemblyHelper.Version__BackingField = -1;
							obj3 = 13;
							continue;
						case 2:
							break;
						case 1:
							((AsyncTaskMethodBuilder<_00210>*)/*Error near IL_01fd: Stack underflow*/)->SetResult((_00210)(&obj));
							if ((int)/*Error near IL_0202: Stack underflow*/ != 0)
							{
								obj3 = 7;
								if (((BiDictionary<, >)(object)AssemblyHelper.ReflectJoinedChain)._forward == null)
								{
									obj3 = 7;
								}
								continue;
							}
							goto case 10;
						case 9:
							goto IL_02d8;
						}
						break;
					}
					goto IL_01e1;
					IL_02d8:
					((ConsoleHelper.COORD)this).X = -2;
					obj2 = 2;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _F000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778372, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _F100(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected Obj, but got Ref
			//IL_0059->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0064->IL0026: Incompatible stack types: I4 vs Obj
			((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
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
					((ApiResponse<_00210>)Unsafe.AsPointer(ref ApiResponseBase<>.ManageProvider)).Data = (_00210?)P_0;
					obj2 = 0;
					if (((ApiResponseBase<>._003CThen_003Ed__10)ApiResponseBase<>._003CThen_003Ed__10._003C_003Et__builder).task == null)
					{
						obj2 = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _F200()
		{
			((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return (ApiResponseBase<>.ManageProvider == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _F300()
		{
			((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
			if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
			{
			}
			return ApiResponseBase<>.ManageProvider;
		}
	}

	[CompilerGenerated]
	private static readonly object Logger__BackingField;

	internal static FileHelper ProcessTransformer;

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
	[AsyncStateMachine(typeof(_003CWriteAllBytesAsync_003Ed__3))]
	public static Task WriteAllBytesAsync(string path, byte[] content)
	{
		return (Task)_FF00봀(path, content);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteAllText(string path, string content)
	{
		_FF00씀(path, content);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteAllTextAsync_003Ed__5))]
	public static Task WriteAllTextAsync(string path, string content)
	{
		return (Task)_FF00먀(path, content);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteAllLinesAsync_003Ed__6))]
	public static Task WriteAllLinesAsync(string path, IEnumerable<string> contents)
	{
		return (Task)_FF00숀(path, contents);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteAllLines(string path, IEnumerable<string> contents)
	{
		_FF00저(path, contents);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding)
	{
		_FF00됀(path, contents, encoding);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void EnsureDirectory(object filePath)
	{
		_FF00케(filePath);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string? ReadAllText(string path)
	{
		return (string?)_FF00쬀(path);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CReadAllBytesAsync_003Ed__11))]
	public static Task<byte[]?> ReadAllBytesAsync(string path)
	{
		return _FF00턀(path);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Copy(string source, string destination)
	{
		_FF00뼀(source, destination);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Delete(string path)
	{
		_FF00퐀(path);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ComputeSha1(string filePath)
	{
		return (string)_FF00뜀(filePath);
	}

	static FileHelper()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_001f: Expected I4, but got Obj
		//IL_004c->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0057->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
				Logger__BackingField = Log.Logger.Category((string)ZYXDNGuarder._FF00윀());
				obj2 = 0;
				if (_003CModule_003E_007B4371cb51_002D3aac_002D43d2_002Da948_002D4dbd622b7dec_007D.m_1b5af9bf88cb406d9ea9459d99b3a863.m_2e560cf4281d4df7a0fd6058ab8acab6 == 0)
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
	internal static bool DecorateSimpleArgument()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FileHelper ReflectControllableSummarizer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00넀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778428, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00눀()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (ApiResponseBase<>.ManageProvider == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00대()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778431, new IntPtr(2737337521084L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00됀(object P_0, IEnumerable<string> P_1, object P_2)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0074: Expected native int or pointer, but got Obj
		//IL_007e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0089->IL0026: Incompatible stack types: I4 vs Obj
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
				/*Error near IL_0040: Member reference must be method, but was: Field*/;
			case 2:
				((NonDVMAttribute)P_0)._002Ector();
				obj2 = 1;
				if ((int)((ApiResponseBase<>._003CThen_003Ed__10*)(nint)ApiResponseBase<>._003CThen_003Ed__10._003C_003E4__this)->_003C_003Eu__1 == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00딀(object P_0, IEnumerable<string> P_1, object P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778430, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00똀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778401, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00뜀(object P_0)
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		/*Error near IL_0015: Member reference must be method, but was: Field*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00렀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778400, new IntPtr(2737337515884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00뤀()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ApiResponseBase<>.ManageProvider;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00먀(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 802, 1790778403, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778403, new IntPtr(2737337515884L), 15);
		}
		return ((delegate*<object, object, object>)obj)(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00묀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778402, new IntPtr(2737337521084L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00밀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778405, new IntPtr(2737337530444L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00봀(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 805, 1790778404, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778404, new IntPtr(2737337526284L), 15);
		}
		return ((delegate*<object, object, object>)obj)(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00븀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778407, new IntPtr(2737337516924L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00뼀(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0074: Expected native int or pointer, but got Obj
		//IL_007e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0089->IL0026: Incompatible stack types: I4 vs Obj
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
				_ = 1;
				/*Error near IL_0040: Member reference must be method, but was: Field*/;
			case 2:
				((NonDVMAttribute)P_1)._002Ector();
				obj2 = 0;
				if ((int)((ApiResponseBase<>._003CThen_003Ed__10*)(nint)ApiResponseBase<>._003CThen_003Ed__10._003C_003E4__this)->_003C_003Eu__1 == 0)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00쀀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778406, new IntPtr(2737337516924L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00섀(object P_0, IEnumerable<string> P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778409, new IntPtr(2737337516924L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00숀(object P_0, IEnumerable<string> P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 810, 1790778408, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778408, new IntPtr(2737337527324L), 15);
		}
		return ((delegate*<object, object, object>)obj)(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00쌀(object P_0, IEnumerable<string> P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778411, new IntPtr(2737337516924L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00쐀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778410, new IntPtr(2737337528364L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00씀(object P_0, object P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0056->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0061->IL0026: Incompatible stack types: I4 vs Obj
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
			case 2:
				((SecureCallbackMethodAttribute)P_0)._002Ector();
				obj2 = 1;
				if ((int)((ApiResponseBase<>._003CThen_003Ed__10*)ApiResponseBase<>._003CThen_003Ed__10._003C_003E1__state)->_003C_003Et__builder != 0)
				{
					obj2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				/*Error near IL_0064: Member reference must be method, but was: Field*/;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00였(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778413, new IntPtr(2737337516924L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00저(object P_0, IEnumerable<string> P_1)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0037: Expected I4, but got Obj
		//IL_0056->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0061->IL0026: Incompatible stack types: I4 vs Obj
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				((SecureCallbackMethodAttribute)P_0)._002Ector();
				obj2 = 0;
				if ((int)((ApiResponseBase<>._003CThen_003Ed__10*)ApiResponseBase<>._003CThen_003Ed__10._003C_003E1__state)->_003C_003Et__builder == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				/*Error near IL_0063: Member reference must be method, but was: Field*/;
			case 2:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00준(object P_0, IEnumerable<string> P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778412, new IntPtr(2737337516924L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00쨀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778415, new IntPtr(2737337516924L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00쬀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 819, 1790778414, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778414, new IntPtr(2737337528364L), 15);
		}
		return ((delegate*<object, object>)obj)(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00찀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778385, new IntPtr(2737337516924L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void _FF00츀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778384, new IntPtr(2737337516924L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void _FF00케(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got Obj
		//IL_0076: Expected native int or pointer, but got Obj
		//IL_0051: Expected Obj, but got I4
		//IL_00ec->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0080->IL0026: Incompatible stack heights: 2 vs 1
		//IL_005b->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00cf->IL0026: Incompatible stack types: I4 vs Obj
		//IL_008b->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00da->IL0026: Incompatible stack types: I4 vs Obj
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
			default:
				return;
			case 0:
				return;
			case 1:
				((SecureCallbackMethodAttribute)1)._002Ector();
				_ = 5;
				break;
			case 5:
				return;
			case 4:
				((NonSecureAttribute)/*Error near IL_0061: Stack underflow*/)._002Ector();
				((NonHVMProxyAttribute)/*Error near IL_0066: Stack underflow*/)._002Ector();
				Interlocked.CompareExchange(ref *(Action<CultureInfo>*)/*Error near IL_006c: Stack underflow*/, (Action<CultureInfo>)/*Error near IL_006c: Stack underflow*/, (Action<CultureInfo>)P_0);
				_ = 0;
				if ((int)((ApiResponseBase<>._003CThen_003Ed__10*)(nint)ApiResponseBase<>._003CThen_003Ed__10._003C_003E4__this)->_003C_003Eu__1 != 0)
				{
					_ = 0;
				}
				break;
			case 2:
				if (((AsyncTaskMethodBuilder<_00210>*)obj)->Task == null)
				{
					obj2 = 1;
					if (((ErrorResponse)(object)ErrorResponse.Errors__BackingField).TraceId__BackingField != null)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 4;
			case 3:
				((AsyncTaskMethodBuilder<_00210>*)/*Error near IL_00e0: Stack underflow*/)->Start<TStateMachine>(ref *(TStateMachine*)P_0);
				obj = (object)/*Error near IL_00e2: Stack underflow*/;
				obj2 = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void _FF00퀀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778387, new IntPtr(2737337522124L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static Task<byte[]> _FF00턀(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 825, 1790778386, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778386, new IntPtr(2737337516924L), 15);
		}
		return (Task<byte[]>)((delegate*<object, object>)obj)(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static Task<byte[]> _FF00툀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778389, new IntPtr(2737337519004L), 15))(null, 0, new IntPtr(0L));
		return (Task<byte[]>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00퐀(object P_0)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_005b: Expected native int or pointer, but got Obj
		//IL_0076: Expected I4, but got Obj
		//IL_0065->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0070->IL0026: Incompatible stack heights: 2 vs 1
		//IL_00a0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0085->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ab->IL0026: Incompatible stack types: I4 vs Obj
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
			default:
				return;
			case 1:
				return;
			case 2:
				((SecureCallbackMethodAttribute)/*Error near IL_0046: Stack underflow*/)._002Ector();
				((NonSecureAttribute)/*Error near IL_004b: Stack underflow*/)._002Ector();
				string.Join((char)/*Error near IL_0051: Stack underflow*/, (IEnumerable<string>)P_0);
				_ = 0;
				if (((ApiResponseBase<>._003CThen_003Ed__10*)(nint)ApiResponseBase<>._003CThen_003Ed__10.task)->_003C_003E4__this == null)
				{
					_ = 0;
				}
				break;
			case 3:
				((ApiResponseBase<_00210>)/*Error near IL_0076: Stack underflow*/).Code = (int)P_0;
				if ((int)/*Error near IL_007b: Stack underflow*/ == 0)
				{
					obj2 = 2;
					break;
				}
				((ApiResponseBase<_00210>)/*Error near IL_008c: Stack underflow*/).Msg = (string)P_0;
				obj2 = 1;
				if (((ErrorResponse)ErrorResponse.Title__BackingField).Status__BackingField == 0)
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
	internal static object _FF00픀()
	{
		((ApiResponseBase<ApiResponse>)Unsafe.As<T?, object>(ref ApiResponse<>.Data__BackingField)/*cast due to constrained. prefix*/)._002Ector();
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return ApiResponseBase<>.ManageProvider;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00혀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778388, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
