using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Mass.Common.Extensions;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0032: Expected I4, but got Obj
			//IL_0061: Expected Obj, but got I4
			//IL_0289: Expected Obj, but got Ref
			//IL_014b: Expected Obj, but got I4
			//IL_01fc: Expected Obj, but got I4
			//IL_0189: Expected Obj, but got Ref
			//IL_017f: Expected Obj, but got I4
			//IL_00db: Expected Obj, but got Ref
			//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0066->IL0015: Incompatible stack heights: 2 vs 0
			//IL_0295->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0052->IL0019: Incompatible stack heights: 2 vs 1
			//IL_02a0->IL0019: Incompatible stack types: I4 vs Obj
			//IL_011f->IL0089: Incompatible stack heights: 1 vs 0
			//IL_0085->IL0089: Incompatible stack heights: 1 vs 0
			//IL_01f7->IL0089: Incompatible stack heights: 1 vs 0
			//IL_0134->IL0089: Incompatible stack heights: 3 vs 0
			//IL_0158->IL0089: Incompatible stack heights: 2 vs 0
			//IL_0207->IL0089: Incompatible stack heights: 3 vs 0
			//IL_0104->IL0089: Incompatible stack heights: 4 vs 0
			//IL_0112->IL0089: Incompatible stack heights: 3 vs 0
			//IL_0193->IL0089: Incompatible stack heights: 1 vs 0
			//IL_01b1->IL0089: Incompatible stack heights: 1 vs 0
			//IL_00e5->IL0089: Incompatible stack heights: 1 vs 0
			//IL_0163->IL0089: Incompatible stack heights: 2 vs 0
			//IL_0146->IL0089: Incompatible stack heights: 1 vs 0
			//IL_0089->IL0089: Incompatible stack heights: 1 vs 0
			//IL_01bc->IL0089: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 3;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						_ = -2;
						if (false)
						{
							_ = 1;
						}
						continue;
					case 4:
						return;
					case 1:
						break;
					case 2:
						if (obj == null)
						{
							if (6 != 0)
							{
								_ = 2;
							}
							goto IL_0089;
						}
						goto IL_01d8;
					case 3:
						{
							obj = (object)Unsafe.AsPointer(ref this);
							if (0 == 0)
							{
								obj2 = 2;
							}
							continue;
						}
						IL_0089:
						while (true)
						{
							switch ((int)/*Error near IL_00d2: Stack underflow*/)
							{
							case 11:
								break;
							case 5:
								return;
							case 6:
							case 16:
								obj = (object)Unsafe.AsPointer(ref this);
								_ = 15;
								continue;
							case 9:
								_ = ref obj;
								_ = 5;
								continue;
							case 10:
								_ = 9;
								continue;
							case 3:
								goto IL_0112;
							default:
								_ = ref obj;
								obj = obj;
								_ = 8;
								continue;
							case 8:
								if (&obj != null)
								{
									_ = 7;
									continue;
								}
								goto case 4;
							case 2:
								obj = -1;
								if (8 == 0)
								{
									_ = 13;
								}
								continue;
							case 12:
							case 14:
								obj = obj;
								obj = 11;
								continue;
							case 7:
							case 13:
								obj = (object)(&obj);
								_ = 12;
								continue;
							case 15:
								if (true)
								{
									_ = 2;
								}
								continue;
							case 1:
								goto IL_01d8;
							case 4:
								obj = 0;
								_ = 10;
								continue;
							}
							break;
						}
						goto default;
						IL_0112:
						obj = null;
						_ = 14;
						goto IL_0089;
						IL_01d8:
						if (Unsafe.AsPointer(ref this) != null)
						{
							if (0 == 0)
							{
								_ = 0;
							}
							goto IL_0089;
						}
						goto IL_0112;
					}
					break;
				}
				obj = 4;
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
		private sealed void _FF00_0A00(object P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
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
		internal static byte _FF00_0B00()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0032: Expected I4, but got Obj
			//IL_0049: Expected Obj, but got Ref
			//IL_00dc: Expected Obj, but got Ref
			//IL_00e5: Expected Obj, but got I4
			//IL_0145: Expected Obj, but got I4
			//IL_0128: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0055->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0045->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0060->IL0019: Incompatible stack types: I4 vs Ref
			//IL_007a->IL0019: Incompatible stack types: I4 vs Ref
			//IL_009e->IL009e: Incompatible stack heights: 1 vs 0
			//IL_009a->IL009e: Incompatible stack heights: 1 vs 0
			//IL_0181->IL009e: Incompatible stack heights: 2 vs 0
			//IL_0191->IL009e: Incompatible stack heights: 2 vs 0
			//IL_00fc->IL009e: Incompatible stack heights: 3 vs 0
			//IL_0174->IL009e: Incompatible stack heights: 4 vs 0
			//IL_0150->IL009e: Incompatible stack heights: 3 vs 0
			//IL_015d->IL009e: Incompatible stack heights: 2 vs 0
			//IL_01ab->IL009e: Incompatible stack heights: 1 vs 0
			//IL_0135->IL009e: Incompatible stack heights: 2 vs 0
			//IL_019c->IL009e: Incompatible stack heights: 2 vs 0
			//IL_0107->IL009e: Incompatible stack heights: 3 vs 0
			//IL_01b6->IL009e: Incompatible stack heights: 1 vs 0
			//IL_0140->IL009e: Incompatible stack heights: 2 vs 0
			//IL_01d5->IL009e: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			ref _003CWriteAllBytesAsync_003Ed__3 reference = ref *(_003CWriteAllBytesAsync_003Ed__3*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 4u:
					_ = -2;
					_ = 3;
					break;
				case 1u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (false)
					{
						reference = ref *(_003CWriteAllBytesAsync_003Ed__3*)null;
					}
					break;
				case 3u:
					reference = ref this;
					if (2 != 0)
					{
						reference = ref *(_003CWriteAllBytesAsync_003Ed__3*)2;
					}
					break;
				case 2u:
					return;
				default:
					{
						if (obj != null)
						{
							if (false)
							{
								_ = 0;
							}
							goto IL_009e;
						}
						goto IL_00d8;
					}
					IL_00d8:
					obj = (object)Unsafe.AsPointer(ref this);
					obj = 8;
					goto IL_009e;
					IL_009e:
					while (true)
					{
						switch ((int)/*Error near IL_00d3: Stack underflow*/)
						{
						case 4:
							break;
						case 6:
							return;
						case 9:
							goto IL_00d8;
						case 3:
							_ = ref obj;
							if (6 == 0)
							{
								_ = 5;
							}
							continue;
						case 11:
							obj = 0;
							if (0 == 0)
							{
								_ = 1;
							}
							continue;
						case 7:
							obj = -1;
							_ = 10;
							continue;
						case 8:
							_ = 7;
							continue;
						case 5:
							_ = ref obj;
							obj = obj;
							_ = 2;
							continue;
						default:
							_ = 5;
							continue;
						case 1:
							if (3 == 0)
							{
								_ = 0;
							}
							continue;
						case 10:
							_ = ref obj;
							if (4 != 0)
							{
								_ = 1;
							}
							continue;
						case 2:
							if (&obj == null)
							{
								if (11 != 0)
								{
									_ = 0;
								}
								continue;
							}
							goto case 10;
						}
						break;
					}
					goto case 4u;
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
		private sealed void _FF00Ȁ(object P_0)
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
		private unsafe sealed void _FF00_0300(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778399, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00Ѐ()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00Ԁ()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0032: Expected I4, but got Obj
			//IL_0049: Expected Obj, but got Ref
			//IL_00d7: Expected Obj, but got I4
			//IL_00c7: Expected Obj, but got I4
			//IL_0150: Expected Obj, but got Ref
			//IL_0045->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0055->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0262->IL0019: Incompatible stack heights: 2 vs 1
			//IL_01ad->IL0084: Incompatible stack types: I4 vs Ref
			//IL_0075->IL0084: Incompatible stack heights: 0 vs 2
			//IL_0060->IL0019: Incompatible stack types: I4 vs Obj
			//IL_00bd->IL01a0: Incompatible stack heights: 1 vs 0
			//IL_0080->IL0084: Incompatible stack heights: 1 vs 2
			//IL_00e4->IL0084: Incompatible stack heights: 3 vs 2
			//IL_0108->IL0084: Incompatible stack heights: 4 vs 2
			//IL_00d2->IL0084: Incompatible stack heights: 4 vs 2
			//IL_0175->IL0084: Incompatible stack heights: 4 vs 2
			//IL_015c->IL0084: Incompatible stack heights: 1 vs 2
			//IL_01d7->IL0084: Incompatible stack heights: 5 vs 2
			//IL_00ef->IL0084: Incompatible stack heights: 3 vs 2
			//IL_01c7->IL0084: Incompatible stack types: I4 vs Ref
			//IL_0113->IL0084: Incompatible stack heights: 4 vs 2
			//IL_0141->IL0084: Incompatible stack heights: 1 vs 2
			//IL_012d->IL0084: Incompatible stack types: I4 vs Ref
			//IL_0167->IL0084: Incompatible stack heights: 1 vs 2
			//IL_014c->IL0084: Incompatible stack heights: 1 vs 2
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				ref byte reference;
				switch ((int)obj2)
				{
				default:
					_ = -2;
					_ = 3;
					break;
				case 2:
					obj = (object)Unsafe.AsPointer(ref this);
					if (1 == 0)
					{
						obj2 = 1;
					}
					break;
				case 4:
					return;
				case 1:
					if (obj == null)
					{
						if (9 == 0)
						{
							_ = 11;
						}
						goto IL_0084;
					}
					goto IL_01a0;
				case 3:
					{
						_ = 4;
						break;
					}
					IL_01a0:
					reference = ref *(byte*)3;
					goto IL_0084;
					IL_0084:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 5u:
							break;
						case 2u:
							return;
						case 4u:
							obj = -1;
							_ = 9;
							continue;
						default:
							obj = 0;
							if (7 == 0)
							{
								_ = 8;
							}
							continue;
						case 3u:
							_ = ref obj;
							obj = obj;
							if (6 == 0)
							{
								_ = 6;
							}
							continue;
						case 9u:
							reference = ref *(byte*)(&obj);
							if (5 == 0)
							{
								reference = ref *(byte*)5;
							}
							continue;
						case 6u:
							if (&obj == null)
							{
								if (false)
								{
									_ = 0;
								}
								continue;
							}
							goto case 9u;
						case 10u:
						case 11u:
							obj = (object)Unsafe.AsPointer(ref this);
							if (1 == 0)
							{
								_ = 0;
							}
							continue;
						case 8u:
							_ = 12;
							continue;
						case 7u:
							goto IL_01a0;
						case 1u:
							reference = ref Unsafe.As<_003CWriteAllLinesAsync_003Ed__6, byte>(ref this);
							if (0 == 0)
							{
								reference = ref *(byte*)4;
							}
							continue;
						case 12u:
							_ = ref obj;
							_ = 2;
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
		private sealed void _F700(object P_0)
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
		internal static byte _F800()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
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
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
			//IL_0010: Expected Obj, but got I4
			//IL_0032: Expected I4, but got Obj
			//IL_0243: Expected Obj, but got Ref
			//IL_016f: Expected Obj, but got I4
			//IL_00c0: Expected Obj, but got Ref
			//IL_00fc: Expected Obj, but got I4
			//IL_0106: Expected Obj, but got I4
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_023f->IL0019: Incompatible stack heights: 3 vs 1
			//IL_024f->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0274->IL0019: Incompatible stack types: I4 vs Ref
			//IL_0187->IL004e: Incompatible stack types: I4 vs Ref
			//IL_004a->IL004e: Incompatible stack heights: 1 vs 2
			//IL_025a->IL0019: Incompatible stack types: I4 vs Ref
			//IL_008b->IL017a: Incompatible stack heights: 1 vs 0
			//IL_017a->IL004e: Incompatible stack heights: 4 vs 2
			//IL_015f->IL004e: Incompatible stack heights: 4 vs 2
			//IL_00cc->IL004e: Incompatible stack heights: 1 vs 2
			//IL_012c->IL004e: Incompatible stack heights: 4 vs 2
			//IL_00bc->IL004e: Incompatible stack heights: 5 vs 2
			//IL_00e4->IL004e: Incompatible stack heights: 3 vs 2
			//IL_0146->IL004e: Incompatible stack types: I4 vs Ref
			//IL_019b->IL004e: Incompatible stack heights: 1 vs 2
			//IL_016a->IL004e: Incompatible stack heights: 4 vs 2
			//IL_00d7->IL004e: Incompatible stack heights: 1 vs 2
			//IL_004e->IL004e: Incompatible stack heights: 4 vs 2
			//IL_01a6->IL004e: Incompatible stack heights: 1 vs 2
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			ref _003CWriteAllTextAsync_003Ed__5 reference = ref *(_003CWriteAllTextAsync_003Ed__5*)obj;
			while (true)
			{
				ref _003CWriteAllTextAsync_003Ed__5 reference2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					return;
				case 0u:
					return;
				case 3u:
					if (obj == null)
					{
						_ = 4;
						goto IL_004e;
					}
					goto IL_017a;
				case 1u:
					goto IL_0231;
				case 4u:
					obj = (object)Unsafe.AsPointer(ref this);
					if (2 == 0)
					{
						reference = ref *(_003CWriteAllTextAsync_003Ed__5*)3;
					}
					break;
				case 2u:
					{
						reference = ref this;
						if (0 == 0)
						{
							reference = ref *(_003CWriteAllTextAsync_003Ed__5*)null;
						}
						break;
					}
					IL_017a:
					reference2 = ref *(_003CWriteAllTextAsync_003Ed__5*)5;
					goto IL_004e;
					IL_004e:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference2))
						{
						case 6u:
							return;
						case 12u:
							_ = ref obj;
							_ = 6;
							continue;
						case 4u:
						case 8u:
							obj = (object)Unsafe.AsPointer(ref this);
							if (false)
							{
								_ = 0;
							}
							continue;
						case 7u:
						case 13u:
							_ = ref obj;
							_ = 9;
							continue;
						case 10u:
							obj = 0;
							obj = 11;
							continue;
						case 11u:
							_ = 12;
							continue;
						default:
							reference2 = ref this;
							if (3 != 0)
							{
								reference2 = ref *(_003CWriteAllTextAsync_003Ed__5*)3;
							}
							continue;
						case 5u:
							_ = ref obj;
							obj = obj;
							if (false)
							{
								_ = 1;
							}
							continue;
						case 3u:
							obj = -1;
							_ = 13;
							continue;
						case 2u:
							break;
						case 1u:
							if (&obj != null)
							{
								if (7 == 0)
								{
									_ = 7;
								}
								continue;
							}
							goto case 10u;
						case 9u:
							goto IL_0231;
						}
						break;
					}
					goto IL_017a;
					IL_0231:
					_ = -2;
					_ = 2;
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
		private sealed void _F100(object P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
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
		internal static byte _F200()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _F300()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
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
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00대()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778431, new IntPtr(2737337521084L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00됀(object P_0, IEnumerable<string> P_1, object P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0040->IL0019: Incompatible stack heights: 3 vs 1
		//IL_004b->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0064->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				if (false)
				{
					_ = 0;
				}
				break;
			case 2:
				obj2 = P_0;
				if (1 == 0)
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
		//IL_000c: Expected Obj, but got I4
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return 1;
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
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
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
	internal static void _FF00뼀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0040->IL0019: Incompatible stack heights: 3 vs 1
		//IL_004b->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0064->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 2:
				obj2 = P_1;
				if (0 == 0)
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
	internal static void _FF00씀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0058->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0063->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0048->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = P_0;
				if (true)
				{
					obj2 = 1;
				}
				break;
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
	internal unsafe static void _FF00였(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778413, new IntPtr(2737337516924L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _FF00저(object P_0, IEnumerable<string> P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0057->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0062->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0048->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				obj2 = P_0;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				if (2 != 0)
				{
					_ = 1;
				}
				break;
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
	private static void _FF00케(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00af->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0096->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0066->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a1->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				_ = 1;
				_ = 5;
				break;
			case 5:
				return;
			case 4:
				obj2 = P_0;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 2:
				if (obj == null)
				{
					if (true)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 4;
			case 3:
				obj = P_0;
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
	internal static void _FF00퐀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_004f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0060->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007a->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
				obj2 = P_0;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				if (P_0 == null)
				{
					obj2 = 2;
					break;
				}
				obj2 = P_0;
				if (1 == 0)
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
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00혀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778388, new IntPtr(2737337533564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
