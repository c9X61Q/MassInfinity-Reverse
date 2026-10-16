using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Mass.Common.Extensions;
using Serilog;

namespace Mass.Game.Launcher.Helpers;

public static class CompressionHelper
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CExtractAllAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Action<int> progress;

		public List<(string archivePath, string outputDir)> extractList;

		public CancellationToken cancellationToken;

		private object _003C_003E8__1;

		private List<(string archivePath, string outputDir)>.Enumerator _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		internal static object ReflectActiveWorker;

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
		internal static bool SearchParameter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateLiteralCalc()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_0B00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777366, new IntPtr(2737367897404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00_0C00(object P_0)
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
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_0D00(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777365, new IntPtr(2737367926524L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_0E00()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00ༀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777364, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00က()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_04a3: Expected Obj, but got Ref
			//IL_00b9: Expected Obj, but got I4
			//IL_0286: Expected Obj, but got Ref
			//IL_0289: Expected Obj, but got Ref
			//IL_0292: Expected Obj, but got I4
			//IL_011b: Expected I4, but got Obj
			//IL_0200: Expected Obj, but got I4
			//IL_0239: Expected Obj, but got Ref
			//IL_0242: Expected Obj, but got I4
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0198: Expected Obj, but got Ref
			//IL_0210: Expected Obj, but got I4
			//IL_02b3: Expected Obj, but got Ref
			//IL_02bc: Expected Obj, but got Ref
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_0494->IL0019: Incompatible stack heights: 2 vs 1
			//IL_04bd->IL0019: Incompatible stack heights: 2 vs 1
			//IL_04ad->IL0019: Incompatible stack types: I4 vs Ref
			//IL_04e3->IL0019: Incompatible stack types: I4 vs Ref
			//IL_049f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_04c8->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0403->IL005e: Incompatible stack types: I4 vs Ref
			//IL_004f->IL005e: Incompatible stack heights: 0 vs 1
			//IL_005a->IL005e: Incompatible stack types: I4 vs Ref
			//IL_03f8->IL005e: Incompatible stack heights: 2 vs 1
			//IL_03d2->IL005e: Incompatible stack heights: 2 vs 1
			//IL_03eb->IL005e: Incompatible stack heights: 3 vs 1
			//IL_03a6->IL005e: Incompatible stack heights: 3 vs 1
			//IL_009d->IL005e: Incompatible stack heights: 2 vs 1
			//IL_03dd->IL005e: Incompatible stack heights: 2 vs 1
			//IL_03c0->IL005e: Incompatible stack types: I4 vs Ref
			//IL_00a8->IL005e: Incompatible stack heights: 2 vs 1
			//IL_00c2->IL00c2: Incompatible stack types: Obj vs Ref
			//IL_01f0->IL00c2: Incompatible stack heights: 0 vs 1
			//IL_01fb->IL00c2: Incompatible stack types: I4 vs Ref
			//IL_0274->IL00c2: Incompatible stack heights: 3 vs 1
			//IL_0255->IL00c2: Incompatible stack heights: 3 vs 1
			//IL_020b->IL00c2: Incompatible stack heights: 3 vs 1
			//IL_01cd->IL00c2: Incompatible stack heights: 3 vs 1
			//IL_01a2->IL00c2: Incompatible stack types: I4 vs Ref
			//IL_0262->IL00c2: Incompatible stack heights: 2 vs 1
			//IL_021b->IL00c2: Incompatible stack heights: 3 vs 1
			//IL_0188->IL00c2: Incompatible stack heights: 0 vs 1
			//IL_027f->IL00c2: Incompatible stack heights: 3 vs 1
			//IL_0235->IL00c2: Incompatible stack types: I4 vs Ref
			//IL_02a9->IL02b6: Incompatible stack heights: 3 vs 5
			//IL_02ee->IL00c2: Incompatible stack heights: 0 vs 1
			//IL_01bc->IL00c2: Incompatible stack types: I4 vs Ref
			//IL_0193->IL00c2: Incompatible stack types: I4 vs Ref
			//IL_02c8->IL00c2: Incompatible stack heights: 5 vs 1
			//IL_02f9->IL00c2: Incompatible stack types: I4 vs Ref
			//IL_031f->IL00c2: Incompatible stack heights: 2 vs 1
			//IL_02d3->IL00c2: Incompatible stack heights: 5 vs 1
			//IL_032a->IL00c2: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 5;
			ref _003CExtractAllAsync_003Ed__3 reference = ref *(_003CExtractAllAsync_003Ed__3*)obj;
			while (true)
			{
				ref _003CExtractAllAsync_003Ed__3 reference2;
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				case 4u:
					if (obj != null)
					{
						if (6 != 0)
						{
							reference2 = ref *(_003CExtractAllAsync_003Ed__3*)5;
						}
						goto IL_005e;
					}
					goto IL_03f8;
				case 1u:
					_ = null;
					if (false)
					{
						_ = 0;
					}
					break;
				case 5u:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(_003CExtractAllAsync_003Ed__3*)4;
					break;
				case 2u:
					goto IL_04ad;
				case 3u:
					return;
				default:
					{
						reference = ref this;
						if (2 == 0)
						{
							reference = ref *(_003CExtractAllAsync_003Ed__3*)3;
						}
						break;
					}
					IL_04ad:
					_ = -2;
					if (true)
					{
						_ = 1;
					}
					break;
					IL_03f8:
					reference2 = ref *(_003CExtractAllAsync_003Ed__3*)5;
					goto IL_005e;
					IL_005e:
					while (true)
					{
						ref byte reference3;
						switch ((uint)Unsafe.AsPointer(ref reference2))
						{
						case 8u:
							if (true)
							{
								_ = 0;
							}
							continue;
						case 5u:
							if (obj == null)
							{
								obj = 16;
								goto IL_00be;
							}
							goto IL_01dc;
						case 7u:
							_ = 4;
							continue;
						case 6u:
							reference2 = ref this;
							if (6 == 0)
							{
								reference2 = ref *(_003CExtractAllAsync_003Ed__3*)8;
							}
							continue;
						case 1u:
							if (3 == 0)
							{
								_ = 2;
							}
							continue;
						case 3u:
							_ = 0;
							_ = 7;
							continue;
						default:
							goto IL_03eb;
						case 4u:
							break;
						case 2u:
							goto IL_04ad;
							IL_00be:
							reference3 = ref *(byte*)obj;
							goto IL_00c2;
							IL_00c2:
							while (true)
							{
								switch ((uint)Unsafe.AsPointer(ref reference3))
								{
								case 9u:
									return;
								default:
									if (&obj != null)
									{
										if (4 == 0)
										{
											reference3 = ref *(byte*)4;
										}
										continue;
									}
									goto case 6u;
								case 12u:
									obj = (object)Unsafe.AsPointer(ref this);
									reference3 = ref *(byte*)10;
									continue;
								case 19u:
									reference3 = ref Unsafe.As<_003CExtractAllAsync_003Ed__3, byte>(ref this);
									if (15 != 0)
									{
										reference3 = ref *(byte*)15;
									}
									continue;
								case 10u:
									_ = obj + 1;
									_ = 18;
									continue;
								case 1u:
								case 11u:
								case 14u:
									break;
								case 6u:
									obj = 0;
									_ = 3;
									continue;
								case 15u:
									obj = -1;
									_ = 7;
									continue;
								case 4u:
								case 7u:
									reference3 = ref *(byte*)(&obj);
									if (12 != 0)
									{
										reference3 = ref *(byte*)6;
									}
									continue;
								case 8u:
								case 16u:
									goto IL_0235;
								case 3u:
									_ = 2;
									continue;
								case 13u:
									_ = 17;
									continue;
								case 2u:
									_ = ref obj;
									if (9 == 0)
									{
										_ = 4;
									}
									continue;
								case 5u:
									goto IL_027f;
								case 17u:
									if (Unsafe.AsPointer(ref this) == null)
									{
										obj = (object)Unsafe.AsPointer(ref this);
									}
									obj = (object)Unsafe.AsPointer(ref this);
									if (false)
									{
										_ = 0;
									}
									continue;
								case 18u:
									goto IL_02d3;
								case 20u:
									goto IL_03eb;
								}
								break;
								IL_02d3:
								if (Unsafe.AsPointer(ref this) == null)
								{
									if (true)
									{
										reference3 = ref *(byte*)1;
									}
									continue;
								}
								_ = (int)((double)(ref this) / (double)(ref this) * 100.0);
								if (11 != 0)
								{
									_ = 4;
								}
							}
							goto IL_01dc;
							IL_03eb:
							_ = 2;
							continue;
							IL_01dc:
							if (Unsafe.AsPointer(ref this) == null)
							{
								if (0 == 0)
								{
									reference3 = ref *(byte*)20;
								}
								goto IL_00c2;
							}
							goto IL_027f;
							IL_0235:
							obj = (object)Unsafe.AsPointer(ref this);
							obj = 19;
							goto IL_00be;
							IL_027f:
							obj = (object)Unsafe.AsPointer(ref this);
							obj = (object)Unsafe.AsPointer(ref this);
							obj = 13;
							goto IL_00be;
						}
						break;
					}
					goto IL_03f8;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00ᄀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777363, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00ሀ()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00ጀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777362, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CExtractAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Action<int> progress;

		public string archivePath;

		public string outputDir;

		public CancellationToken cancellationToken;

		private object _003C_003E8__1;

		private object _003C_003E8__2;

		private CancellationTokenRegistration _003Cregistration_003E5__2;

		private object _003C_003E7__wrap2;

		private nint _003C_003E7__wrap3;

		private TaskAwaiter _003C_003Eu__1;

		private ValueTaskAwaiter _003C_003Eu__2;

		private static object MonitorProfiler;

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
		internal static bool ReflectModularElement()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LeadCompressor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00ﴀ(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777361, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FE00(object P_0)
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
					if (false)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00Ā()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777360, new IntPtr(2737367923404L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00ࠀ()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_081b: Expected Obj, but got I4
			//IL_00f5: Expected Obj, but got I4
			//IL_0162: Expected Obj, but got Ref
			//IL_075d: Expected Obj, but got I4
			//IL_053a: Expected Obj, but got Ref
			//IL_0250: Expected Obj, but got Ref
			//IL_0506: Expected Obj, but got Ref
			//IL_05fd: Expected Obj, but got Ref
			//IL_02bb: Expected Obj, but got I4
			//IL_02a5: Expected Obj, but got Ref
			//IL_0556: Expected Obj, but got I4
			//IL_05d3: Expected Obj, but got I4
			//IL_0302: Expected Obj, but got I4
			//IL_0479: Expected Obj, but got Ref
			//IL_03d8: Expected Obj, but got Ref
			//IL_0392: Expected Obj, but got I4
			//IL_0410: Expected Obj, but got I4
			//IL_0375: Expected Obj, but got I4
			//IL_0437: Expected Obj, but got I4
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0063->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0072->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0820->IL0015: Incompatible stack heights: 2 vs 0
			//IL_0090->IL0094: Incompatible stack heights: 1 vs 0
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_007d->IL0019: Incompatible stack heights: 2 vs 1
			//IL_077a->IL0094: Incompatible stack heights: 1 vs 0
			//IL_01a4->IL0094: Incompatible stack heights: 13 vs 0
			//IL_0136->IL0094: Incompatible stack heights: 1 vs 0
			//IL_00ef->IL0094: Incompatible stack heights: 3 vs 0
			//IL_06ff->IL0094: Incompatible stack heights: 3 vs 0
			//IL_078b->IL0094: Incompatible stack heights: 3 vs 0
			//IL_0101->IL0094: Incompatible stack heights: 1 vs 0
			//IL_072a->IL0094: Incompatible stack heights: 1 vs 0
			//IL_0745->IL0094: Incompatible stack heights: 1 vs 0
			//IL_011b->IL0094: Incompatible stack heights: 1 vs 0
			//IL_06e5->IL0094: Incompatible stack heights: 1 vs 0
			//IL_0152->IL0094: Incompatible stack heights: 2 vs 0
			//IL_0710->IL0094: Incompatible stack heights: 2 vs 0
			//IL_01af->IL0094: Incompatible stack heights: 13 vs 0
			//IL_0141->IL0094: Incompatible stack heights: 1 vs 0
			//IL_010c->IL0094: Incompatible stack heights: 1 vs 0
			//IL_0735->IL0094: Incompatible stack heights: 1 vs 0
			//IL_0179->IL0094: Incompatible stack heights: 1 vs 0
			//IL_0750->IL0094: Incompatible stack heights: 1 vs 0
			//IL_0126->IL0094: Incompatible stack heights: 1 vs 0
			//IL_06f0->IL0094: Incompatible stack heights: 1 vs 0
			//IL_0094->IL0094: Incompatible stack heights: 2 vs 0
			//IL_015d->IL0094: Incompatible stack heights: 2 vs 0
			//IL_071b->IL0094: Incompatible stack heights: 2 vs 0
			//IL_0535->IL01d2: Incompatible stack heights: 1 vs 0
			//IL_01ce->IL01d2: Incompatible stack heights: 1 vs 0
			//IL_05f9->IL01d2: Incompatible stack heights: 2 vs 0
			//IL_0284->IL01d2: Incompatible stack heights: 1 vs 0
			//IL_0575->IL01d2: Incompatible stack heights: 2 vs 0
			//IL_02cd->IL01d2: Incompatible stack heights: 3 vs 0
			//IL_02eb->IL01d2: Incompatible stack heights: 1 vs 0
			//IL_0617->IL01d2: Incompatible stack heights: 4 vs 0
			//IL_025a->IL01d2: Incompatible stack heights: 1 vs 0
			//IL_026a->IL01d2: Incompatible stack heights: 2 vs 0
			//IL_0607->IL01d2: Incompatible stack heights: 1 vs 0
			//IL_02c0->IL01ce: Incompatible stack types: I4 vs Obj
			//IL_02af->IL01d2: Incompatible stack heights: 1 vs 0
			//IL_0561->IL01d2: Incompatible stack heights: 3 vs 0
			//IL_05e0->IL01d2: Incompatible stack heights: 2 vs 0
			//IL_0501->IL01d2: Incompatible stack heights: 4 vs 0
			//IL_0483->IL032a: Incompatible stack types: I4 vs Ref
			//IL_031b->IL032a: Incompatible stack heights: 0 vs 2
			//IL_02a1->IL01d2: Incompatible stack heights: 1 vs 0
			//IL_028f->IL01d2: Incompatible stack heights: 1 vs 0
			//IL_05a3->IL01d2: Incompatible stack heights: 1 vs 0
			//IL_0580->IL01d2: Incompatible stack heights: 2 vs 0
			//IL_02f6->IL01d2: Incompatible stack heights: 1 vs 0
			//IL_0551->IL01d2: Incompatible stack heights: 1 vs 0
			//IL_05ce->IL01d2: Incompatible stack heights: 1 vs 0
			//IL_0591->IL01d2: Incompatible stack heights: 1 vs 0
			//IL_051d->IL01d2: Incompatible stack heights: 1 vs 0
			//IL_0275->IL01d2: Incompatible stack heights: 2 vs 0
			//IL_01d2->IL01d2: Incompatible stack heights: 3 vs 0
			//IL_0629->IL01d2: Incompatible stack heights: 1 vs 0
			//IL_05eb->IL01d2: Incompatible stack heights: 2 vs 0
			//IL_036b->IL0470: Incompatible stack heights: 1 vs 0
			//IL_0326->IL032a: Incompatible stack heights: 1 vs 2
			//IL_0648->IL01d2: Incompatible stack heights: 1 vs 0
			//IL_03e2->IL032a: Incompatible stack types: I4 vs Ref
			//IL_039d->IL032a: Incompatible stack heights: 4 vs 2
			//IL_0382->IL032a: Incompatible stack heights: 3 vs 2
			//IL_0463->IL032a: Incompatible stack heights: 3 vs 2
			//IL_03b8->IL032a: Incompatible stack heights: 4 vs 2
			//IL_043c->IL0326: Incompatible stack heights: 3 vs 4
			//IL_03aa->IL032a: Incompatible stack heights: 4 vs 2
			//IL_0470->IL032a: Incompatible stack heights: 3 vs 2
			//IL_0370->IL0470: Incompatible stack heights: 1 vs 0
			//IL_0653->IL01d2: Incompatible stack heights: 1 vs 0
			//IL_032a->IL032a: Incompatible stack heights: 5 vs 2
			//IL_038d->IL032a: Incompatible stack heights: 3 vs 2
			//IL_03f6->IL032a: Incompatible stack heights: 1 vs 2
			//IL_0456->IL032a: Incompatible stack types: I4 vs Ref
			//IL_0401->IL032a: Incompatible stack heights: 1 vs 2
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
					case 1:
						obj = (object)Unsafe.AsPointer(ref this);
						if (0 == 0)
						{
							obj2 = 0;
						}
						continue;
					case 2:
						_ = 3;
						continue;
					case 4:
						_ = null;
						if (1 == 0)
						{
							_ = 2;
						}
						continue;
					default:
						if ((nuint)(nint)obj > (nuint)1u)
						{
							_ = 12;
							goto IL_0094;
						}
						goto IL_0762;
					case 5:
						break;
					case 3:
						return;
						IL_0762:
						if (5 == 0)
						{
							_ = 5;
						}
						goto IL_0094;
						IL_0094:
						while (true)
						{
							switch ((int)/*Error near IL_00dd: Stack underflow*/)
							{
							case 3:
								break;
							case 7:
								_ = 21;
								obj = 2;
								if (2 != 0)
								{
									_ = 2;
								}
								continue;
							case 11:
								if (5 == 0)
								{
									_ = 6;
								}
								continue;
							case 2:
								_ = ref obj;
								if (4 == 0)
								{
									_ = 4;
								}
								continue;
							case 14:
								if (9 == 0)
								{
									_ = 11;
								}
								continue;
							case 9:
								obj = (object)(&obj);
								if (false)
								{
									_ = 0;
								}
								continue;
							default:
								_ = 1;
								_ = 0;
								_ = 1;
								_ = 1;
								if (1 == 0)
								{
									_ = 0;
								}
								continue;
							case 5:
								goto IL_01af;
							case 12:
								if (9 != 0)
								{
									_ = 14;
								}
								continue;
							case 4:
								_ = ref obj;
								_ = 10;
								continue;
							case 16:
								_ = ref obj;
								if (10 == 0)
								{
									_ = 13;
								}
								continue;
							case 8:
								if (12 != 0)
								{
									_ = 15;
								}
								continue;
							case 10:
								_ = ref obj;
								if (16 == 0)
								{
									_ = 1;
								}
								continue;
							case 13:
								_ = ref obj;
								obj = 9;
								continue;
							case 1:
								goto end_IL_0094;
							case 6:
								_ = 7;
								continue;
							case 15:
								throw null;
							}
							goto IL_00e2;
							IL_01af:
							if (obj != null)
							{
								if (16 == 0)
								{
									_ = 19;
								}
								goto IL_01d2;
							}
							goto IL_051d;
							IL_00e2:
							_ = null;
							_ = 8;
							continue;
							IL_01d2:
							while (true)
							{
								scoped ref _003CExtractAsync_003Ed__4 reference;
								object obj3;
								ref object reference2;
								switch ((int)/*Error near IL_0247: Stack underflow*/)
								{
								case 24:
									break;
								case 14:
									obj = (object)Unsafe.AsPointer(ref this);
									_ = 9;
									continue;
								case 16:
									if (1 == 0)
									{
										_ = 10;
									}
									continue;
								case 4:
									_ = ref obj;
									if (5 == 0)
									{
										_ = 17;
									}
									continue;
								case 2:
									if ((nint)obj == 1)
									{
										_ = 21;
										continue;
									}
									goto case 27;
								case 20:
									obj = (object)Unsafe.AsPointer(ref this);
									_ = 2;
									continue;
								case 18:
									reference = ref this;
									obj = 3;
									obj3 = 0;
									continue;
								case 7:
									_ = null;
									_ = 18;
									continue;
								case 22:
									return;
								case 9:
									if (16 == 0)
									{
										_ = 23;
									}
									continue;
								case 27:
									reference = ref this;
									obj3 = null;
									obj = 24;
									continue;
								default:
									if (obj == null)
									{
										if (0 == 0)
										{
											_ = 1;
										}
										goto IL_032a;
									}
									goto IL_0470;
								case 26:
									_ = 7;
									continue;
								case 15:
									obj = (object)(&obj);
									if (3 == 0)
									{
										_ = 5;
									}
									continue;
								case 3:
									goto IL_051d;
								case 11:
									goto IL_0535;
								case 23:
									obj = -1;
									_ = 4;
									continue;
								case 6:
									if (false)
									{
										_ = 12;
									}
									continue;
								case 13:
									if (obj != null)
									{
										_ = 8;
										continue;
									}
									goto case 20;
								case 5:
									if (&obj == null)
									{
										_ = 25;
										continue;
									}
									goto case 4;
								case 12:
									if (1 == 0)
									{
										_ = 1;
									}
									continue;
								case 25:
									obj = 1;
									if (16 != 0)
									{
										_ = 2;
									}
									continue;
								case 1:
									_ = 26;
									continue;
								case 17:
									obj = (object)Unsafe.AsPointer(ref this);
									_ = 13;
									continue;
								case 10:
									_ = ref obj;
									_ = 22;
									continue;
								case 19:
									if ((nint)obj != 1)
									{
										_ = 6;
										continue;
									}
									goto case 14;
								case 8:
									goto IL_0629;
								case 21:
									goto end_IL_0019;
									IL_0470:
									obj = (object)Unsafe.AsPointer(ref this);
									reference2 = ref *(object*)11;
									goto IL_032a;
									IL_032a:
									while (true)
									{
										switch ((uint)Unsafe.AsPointer(ref reference2))
										{
										case 6u:
											obj = 0;
											if (9 == 0)
											{
												_ = 1;
											}
											continue;
										case 4u:
											obj = -1;
											_ = 12;
											continue;
										case 13u:
											_ = 1;
											_ = 7;
											continue;
										case 9u:
											_ = 5;
											continue;
										case 1u:
										case 2u:
											obj = (object)Unsafe.AsPointer(ref this);
											reference2 = ref *(object*)14;
											continue;
										case 11u:
											if (&obj == null)
											{
												if (6 != 0)
												{
													_ = 2;
												}
												continue;
											}
											goto case 12u;
										case 5u:
											_ = ref obj;
											obj = 3;
											continue;
										case 3u:
											return;
										case 10u:
											_ = 100;
											obj = 13;
											continue;
										case 12u:
											reference2 = ref obj;
											if (1 == 0)
											{
												reference2 = ref *(object*)8;
											}
											continue;
										case 8u:
											_ = 10;
											continue;
										case 14u:
											_ = 4;
											continue;
										case 7u:
											goto IL_0535;
										}
										break;
									}
									goto IL_0470;
									IL_0535:
									obj = (object)Unsafe.AsPointer(ref this);
									if (15 == 0)
									{
										_ = 2;
									}
									continue;
								}
								break;
								IL_0629:
								if (obj == null)
								{
									throw obj;
								}
								if (16 != 0)
								{
									_ = 20;
								}
							}
							goto IL_00e2;
							IL_051d:
							if (0 == 0)
							{
								_ = 0;
							}
							goto IL_01d2;
							continue;
							end_IL_0094:
							break;
						}
						goto IL_0762;
						end_IL_0019:
						break;
					}
					break;
				}
				_ = -2;
				obj = 4;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_0900()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_0A00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777359, new IntPtr(2737367899484L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[CompilerGenerated]
	private static readonly object Logger__BackingField;

	private static object RestartProxy;

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
	[AsyncStateMachine(typeof(_003CExtractAllAsync_003Ed__3))]
	public static Task ExtractAllAsync(List<(string archivePath, string outputDir)> extractList, Action<int>? progress = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00䌀(extractList, progress, cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CExtractAsync_003Ed__4))]
	public static Task ExtractAsync(string archivePath, string outputDir, Action<int> progress, CancellationToken cancellationToken = default(CancellationToken))
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00䘀(archivePath, outputDir, progress, cancellationToken);
	}

	static CompressionHelper()
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
				Logger__BackingField = Log.Logger.Category((string)ZYXDNGuarder._FF00_FF00_FF00_FF00_FF00䄀());
				obj2 = 0;
				if (_003CModule_003E_007B8336717d_002D71de_002D47ce_002Dbc69_002D4d75223ebc5e_007D.m_d836f3f9b6194f49a23d85cb66f28ddf.m_93c7682517474b7e96a6fa3d7f857ec8 == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PeekExtractor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CompressionHelper ReflectGeneralSorter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00䈀(List<(string, string)> P_0, Action<int> P_1, CancellationToken P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777445, new IntPtr(2737367928604L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00䌀(List<(string, string)> P_0, Action<int> P_1, CancellationToken P_2)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_0044: Expected Obj, but got Ref
		//IL_0064->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0052->IL0019: Incompatible stack heights: 3 vs 1
		//IL_007d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c1->IL0019: Incompatible stack heights: 3 vs 1
		//IL_006f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0098->IL0019: Incompatible stack heights: 2 vs 1
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
				return (object)(&obj);
			case 2:
				_ = ref obj;
				_ = 5;
				break;
			case 1:
				_ = ref obj;
				_ = ref obj;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 3:
				_ = ref obj;
				_ = 2;
				break;
			case 5:
				_ = ref obj;
				if (6 == 0)
				{
					_ = 4;
				}
				break;
			case 4:
				_ = ref obj;
				_ = -1;
				if (1 == 0)
				{
					_ = 1;
				}
				break;
			case 6:
				_ = ref obj;
				_ = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00䐀(List<(string, string)> P_0, Action<int> P_1, CancellationToken P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777444, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00䔀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00䘀(object P_0, object P_1, Action<int> P_2, CancellationToken P_3)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003e: Expected I4, but got Obj
		//IL_00d3: Expected Obj, but got Ref
		//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
		//IL_00ce->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0095->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0053->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0087->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00c0->IL0019: Incompatible stack heights: 3 vs 1
		//IL_005e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0079->IL0019: Incompatible stack types: I4 vs Ref
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		ref object reference = ref *(object*)obj;
		while (true)
		{
			switch ((uint)Unsafe.AsPointer(ref reference))
			{
			case 2u:
				_ = ref obj;
				if (1 == 0)
				{
					_ = 0;
				}
				break;
			case 5u:
				reference = ref obj;
				if (4 == 0)
				{
					reference = ref *(object*)3;
				}
				break;
			case 4u:
				_ = ref obj;
				_ = 3;
				break;
			case 1u:
				_ = ref obj;
				_ = -1;
				_ = 6;
				break;
			case 3u:
				_ = ref obj;
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 6u:
				_ = ref obj;
				_ = ref obj;
				_ = 7;
				break;
			default:
				_ = ref obj;
				_ = 2;
				break;
			case 7u:
				return (object)(&obj);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00䜀(object P_0, object P_1, Action<int> P_2, CancellationToken P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777443, new IntPtr(2737367925484L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00䠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777442, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00_FF00_FF00_FF00_FF00䤀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_FF00䨀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777441, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00䬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790777440, new IntPtr(2737367919244L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00䰀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}
}
