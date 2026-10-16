using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using System.Threading.Tasks;
using Mass.Application.Services;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Game.Proxy.Protocols.Heypixel.AntiCheat;
using Mass.Game.Proxy.Protocols.Hyt.VexView;

namespace Mass.Game.Proxy.Protocols.Heypixel;

public static class MassServiceExtensions
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetHeypixelAntiCheat_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<HeypixelRequestDto> _003C_003Et__builder;

		public MassService massService;

		public string url;

		public string payload;

		public string context;

		public string userId;

		private TaskAwaiter<HeypixelRequestDto> _003C_003Eu__1;

		internal static object ReflectActiveExtractor;

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
		internal static bool DecorateJoinedIterator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CalcClient()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_E900()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778532, new IntPtr(2737367947324L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_EA00()
		{
			//IL_001a: Expected Obj, but got VT
			_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_EB00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778535, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_EC00()
		{
			//IL_001a: Invalid comparison between VT and Obj
			_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_ED00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778534, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_EF00()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_003f: Expected I4, but got Obj
			//IL_034c: Expected Obj, but got Ref
			//IL_0323: Expected Obj, but got Ref
			//IL_0334: Expected Obj, but got I
			//IL_035c: Expected Obj, but got Ref
			//IL_0372: Expected Obj, but got I4
			//IL_010c: Expected Obj, but got Ref
			//IL_010e: Expected Obj, but got VT
			//IL_011d: Expected Obj, but got VT
			//IL_005b: Expected Obj, but got VT
			//IL_0157: Expected Obj, but got Ref
			//IL_015f: Expected Obj, but got Ref
			//IL_016e: Expected Obj, but got I4
			//IL_00b7: Expected Obj, but got Ref
			//IL_0186: Expected Obj, but got Ref
			//IL_01aa: Expected Obj, but got I4
			//IL_01af: Expected Obj, but got I4
			//IL_01af: Expected Obj, but got Ref
			//IL_01d3: Expected Obj, but got I4
			//IL_01d8: Expected Obj, but got I4
			//IL_01d8: Expected Obj, but got Ref
			//IL_00f6: Expected Obj, but got Ref
			//IL_020f: Expected Obj, but got Ref
			//IL_021b: Expected Obj, but got Ref
			//IL_0220: Expected Obj, but got I4
			//IL_0226: Expected Obj, but got Ref
			//IL_022c: Expected Obj, but got Ref
			//IL_0232: Expected Obj, but got Ref
			//IL_0238: Expected Obj, but got Ref
			//IL_0249: Expected Obj, but got I4
			//IL_0252: Expected Obj, but got I4
			//IL_0356->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0339->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0377->IL0026: Incompatible stack heights: 5 vs 2
			//IL_0344->IL0026: Incompatible stack types: I4 vs Obj
			//IL_0382->IL0026: Incompatible stack heights: 5 vs 2
			//IL_0173->IL006f: Incompatible stack heights: 5 vs 2
			//IL_0132->IL0382: Incompatible stack heights: 0 vs 1
			//IL_0280->IL0344: Incompatible stack heights: 0 vs 1
			//IL_017e->IL006f: Incompatible stack heights: 5 vs 2
			//IL_006f->IL006f: Incompatible stack heights: 4 vs 2
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				case 1:
					if (obj != null)
					{
						num = 1;
						if ((int)((_003C_003Ef__AnonymousType1<, , >)_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field)._003Cuser_id_003Ei__Field == 0)
						{
							num = 2;
						}
						goto IL_006f;
					}
					goto IL_0106;
				case 2:
					obj = ((GameProxy)Unsafe.AsPointer(ref this)).ServerAddress__BackingField;
					obj2 = 0;
					if (((GameProxy)GameProxy.ServerPort__BackingField).TransferServerAddress__BackingField != null)
					{
						obj2 = 1;
					}
					break;
				default:
					goto IL_0344;
				case 3:
					_ = ref ((GameProxy)Unsafe.AsPointer(ref this)).Section__BackingField;
					_ = EqualityComparer<Type>.Default;
					_ = 4;
					if (((GameProxy)GameProxy.IsGame).BlockIrcMessages)
					{
						_ = 4;
					}
					break;
				case 4:
					return;
					IL_006f:
					while (true)
					{
						switch (num)
						{
						case 2:
							if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter != null)
							{
								num = 7;
								continue;
							}
							goto case 13;
						case 6:
						case 8:
							_ = ref obj;
							/*Error near IL_00c9: Member reference must be method, but was: Field*/;
						case 9:
							_ = ref obj;
							/*Error near IL_00dc: Member reference must be method, but was: Field*/;
						case 12:
							Unsafe.As<_003Cuser_id_003Ej__TPar, _00213>(ref ((_003C_003Ef__AnonymousType2<, , , >)Unsafe.AsPointer(ref this))._003Cuser_id_003Ei__Field) = default;
							num = 11;
							continue;
						case 5:
							break;
						case 1:
							return;
						default:
							_ = ref _003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.RunnerFactory.Runner.StoreConverter;
							_ = ref obj;
							((IEnumerable<byte>)Unsafe.AsPointer(ref this)).ToArray();
							_ = 1;
							if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_ascii_68FF03FEFFFF87FEFFFF07 != null)
							{
								_ = 1;
							}
							continue;
						case 4:
							_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.GuideMap = obj;
							num = 0;
							if (((EntitySocks5Account)EntitySocks5Account.Username__BackingField).Password__BackingField != null)
							{
								num = 0;
							}
							continue;
						case 10:
							obj = 0;
							EntitySocks5Account.AttachElement = 0;
							num = 4;
							if (((EntitySocks5)EntitySocks5.Address__BackingField).Port__BackingField == 0)
							{
								num = 1;
							}
							continue;
						case 11:
							obj = -1;
							((EntitySocks5)Unsafe.AsPointer(ref this)).Account__BackingField = -1;
							num = 6;
							if (((EntityLaunchGameProxy)EntitySocks5.DecorateDynamicModule).Session__BackingField != null)
							{
								num = 6;
							}
							continue;
						case 13:
							_ = ((_003C_003Ef__AnonymousType3<, >)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field)).sid;
							/*Error near IL_020f: Member reference must be method, but was: Field*/;
						case 7:
						{
							((_003C_003Ef__AnonymousType3<, >)((EntityLaunchGameProxy)Unsafe.AsPointer(ref this)).GameVersion__BackingField).GetHashCode();
							_ = ((EntityLaunchGameProxy)Unsafe.AsPointer(ref this)).Name__BackingField;
							object obj3 = ((EntityLaunchGameProxy)Unsafe.AsPointer(ref this)).ServerAddress__BackingField;
							((AsyncTaskMethodBuilder<bool>*)((EntityLaunchGameProxy)Unsafe.AsPointer(ref this)).ServerPort__BackingField)->AwaitUnsafeOnCompleted(ref *(TaskAwaiter<HeypixelHwid>*)((EntityLaunchGameProxy)Unsafe.AsPointer(ref this)).Socks5__BackingField, ref *(HeypixelProtocol._003CInitialize_003Ed__17*)new RegexRunner());
							obj = ((ReadOnlySpan<char>*)obj3)->Length;
							obj = 9;
							continue;
						}
						case 3:
							goto IL_0344;
						}
						break;
					}
					goto IL_0106;
					IL_0106:
					obj = ((_003C_003Ef__AnonymousType3<, >)Unsafe.AsPointer(ref this))._003Centry_003Ei__Field;
					num = 2;
					if (_003C_003Ef__AnonymousType3<, >.ReflectAutomatableArgument != null)
					{
						num = 12;
					}
					goto IL_006f;
					IL_0344:
					((GameProxy)Unsafe.AsPointer(ref this)).TransferServerPort__BackingField = -2;
					obj2 = 3;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_F000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778529, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_F100(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected Obj, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 3 vs 2
			//IL_0064->IL0026: Incompatible stack heights: 3 vs 2
			_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
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
					((EqualityComparer<_00210>)Unsafe.AsPointer(ref ((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref this))._003Cuuid_003Ei__Field)).GetHashCode((_00210)P_0);
					_ = 0;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_F200(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778528, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetHeypixelSession_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<HeypixelHwid> _003C_003Et__builder;

		public MassService massService;

		public string name;

		public string uuid;

		public string userId;

		private TaskAwaiter<HeypixelHwid> _003C_003Eu__1;

		internal static object ReflectScalableTokenizer;

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
		internal static bool CheckModularContainer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckGroupedConverter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778531, new IntPtr(2737367941084L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_001a: Expected Obj, but got VT
			_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_E000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778530, new IntPtr(2737367939004L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_E100()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778557, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_E200()
		{
			//IL_001a: Invalid comparison between VT and Obj
			_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_E300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778556, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_E600()
		{
			//IL_001d: Expected Obj, but got I4
			//IL_003f: Expected I4, but got Obj
			//IL_0315: Expected Obj, but got Ref
			//IL_031c: Expected Obj, but got Ref
			//IL_02f0: Expected Obj, but got I4
			//IL_02f0: Expected Obj, but got Ref
			//IL_02ff: Expected Obj, but got I4
			//IL_0341: Expected Obj, but got Ref
			//IL_009e: Expected Obj, but got Ref
			//IL_00a0: Expected Obj, but got VT
			//IL_00af: Expected Obj, but got VT
			//IL_01a1: Expected Obj, but got I4
			//IL_01a6: Expected Obj, but got I4
			//IL_01a6: Expected Obj, but got Ref
			//IL_01cc: Expected Obj, but got Ref
			//IL_01ce: Expected Obj, but got Ref
			//IL_01dd: Expected Obj, but got I4
			//IL_01f3: Expected Obj, but got Ref
			//IL_01fb: Expected Obj, but got Ref
			//IL_0110: Expected Obj, but got I4
			//IL_0115: Expected VT, but got I4
			//IL_0115: Expected Obj, but got Ref
			//IL_0125: Expected Obj, but got Ref
			//IL_00d4: Expected Obj, but got Ref
			//IL_0221: Expected Obj, but got Ref
			//IL_00ec: Expected VT, but got Obj
			//IL_00ec: Expected Obj, but got Ref
			//IL_00fb: Expected Obj, but got VT
			//IL_016a: Expected Obj, but got Ref
			//IL_016f: Expected Obj, but got I4
			//IL_0175: Expected Obj, but got Ref
			//IL_017b: Expected Obj, but got Ref
			//IL_0181: Expected Obj, but got Ref
			//IL_0186: Expected VT, but got Obj
			//IL_0186: Expected VT, but got Obj
			//IL_0330->IL0026: Incompatible stack heights: 3 vs 2
			//IL_0304->IL0026: Incompatible stack types: I4 vs Obj
			//IL_034d->IL0026: Incompatible stack types: I4 vs Obj
			//IL_033b->IL0026: Incompatible stack heights: 3 vs 2
			//IL_030f->IL0026: Incompatible stack types: I4 vs Obj
			//IL_00c4->IL02e7: Incompatible stack heights: 0 vs 1
			//IL_01e2->IL005a: Incompatible stack heights: 1 vs 2
			//IL_024a->IL02e8: Incompatible stack heights: 0 vs 1
			//IL_020f->IL005a: Incompatible stack heights: 5 vs 2
			//IL_0226->IL01c5: Incompatible stack heights: 0 vs 1
			//IL_01ed->IL005a: Incompatible stack heights: 1 vs 2
			//IL_021a->IL005a: Incompatible stack heights: 5 vs 2
			//IL_023a->IL005a: Incompatible stack heights: 1 vs 2
			//IL_0245->IL005a: Incompatible stack heights: 1 vs 2
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
			{
			}
			object obj = 4;
			object obj2 = obj;
			while (true)
			{
				int num;
				switch ((int)obj2)
				{
				case 3:
					if (obj != null)
					{
						num = 9;
						goto IL_005a;
					}
					goto IL_0098;
				case 1:
					return;
				case 2:
					goto IL_02e8;
				default:
					((StringBuilder)Unsafe.AsPointer(ref ((GameProxy)Unsafe.AsPointer(ref this)).ServerAddress__BackingField)).Append((string?)obj);
					_ = 1;
					if (((GameProxy)GameProxy.TransferServerAddress__BackingField).TransferServerPort__BackingField == 0)
					{
						_ = 1;
					}
					break;
				case 4:
					{
						obj = ((GameProxy)Unsafe.AsPointer(ref this)).Section__BackingField;
						obj2 = 3;
						break;
					}
					IL_02e8:
					((GameProxy)Unsafe.AsPointer(ref this)).GameId__BackingField = -2;
					obj2 = 0;
					if (((GameProxy)GameProxy.GameVersion__BackingField).ModHashList__BackingField != null)
					{
						obj2 = 0;
					}
					break;
					IL_005a:
					while (true)
					{
						switch (num)
						{
						default:
							return;
						case 6:
							break;
						case 0:
							return;
						case 10:
							Unsafe.As<_003Curl_003Ej__TPar, _00212>(ref ((_003C_003Ef__AnonymousType2<, , , >)Unsafe.AsPointer(ref this))._003Curl_003Ei__Field) = default;
							num = 8;
							continue;
						case 12:
							((_003C_003Ef__AnonymousType2<, , , >)Unsafe.AsPointer(ref this))._003Ccontext_003Ei__Field = (_003Ccontext_003Ej__TPar)obj;
							num = 2;
							if (_003C_003Ef__AnonymousType2<, , , >.DecorateGroupedDic != null)
							{
								num = 7;
							}
							continue;
						case 8:
							obj = -1;
							((_003C_003Ef__AnonymousType3<, >)Unsafe.AsPointer(ref this))._003Centry_003Ei__Field = (_003Centry_003Ej__TPar)(-1);
							num = 4;
							continue;
						case 9:
							if ((int)((_003C_003Ef__AnonymousType3<, >)Unsafe.AsPointer(ref this))._003Csid_003Ei__Field != 0)
							{
								num = 1;
								if (_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__SimpleValue_0.ReflectLocalTemplate != null)
								{
									num = 0;
								}
								continue;
							}
							goto case 2;
						case 2:
							_003C_003Ef__AnonymousType1<, , >.ReflectScalableStack();
							/*Error near IL_015e: Member reference must be method, but was: Field*/;
						case 1:
							_ = ((_003C_003Ef__AnonymousType2<, , , >)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.s_hasTimeout).payload;
							JsonSerializer.Deserialize<VexViewPacket>((string)_003CRegexGenerator_g_003EFE26B9200A6BC2C3D514D911C1DF88A90313018C3ED11EC3076198847E4099DA3__Utilities.GuideMap, (JsonSerializerOptions?)new EqualityComparer<_00213>((_00213?)((EntitySocks5Account)Unsafe.AsPointer(ref this)).Username__BackingField, (_00213?)((EntitySocks5Account)Unsafe.AsPointer(ref this)).Password__BackingField));
							/*Error near IL_018b: Member reference must be method, but was: Field*/;
						case 3:
							obj = 0;
							((EntitySocks5)Unsafe.AsPointer(ref this)).Account__BackingField = 0;
							num = 12;
							if (((EntityLaunchGameProxy)EntitySocks5.DecorateDynamicModule).Session__BackingField != null)
							{
								num = 3;
							}
							continue;
						case 4:
							((Regex)(&obj))._002Ector();
							obj = (object)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field);
							_ = 5;
							if (((EntityLaunchGameProxy)EntityLaunchGameProxy.GameType__BackingField).GameVersion__BackingField == EnumGameVersion.None)
							{
								_ = 1;
							}
							continue;
						case 7:
							_ = ref ((EntityLaunchGameProxy)Unsafe.AsPointer(ref this)).ModHashList__BackingField;
							_ = ref obj;
							CollectionsMarshal.AsSpan((List<string>?)Unsafe.AsPointer(ref this));
							_ = 0;
							if (((EntityLaunchGameProxy)EntityLaunchGameProxy.ServerAddress__BackingField).ServerPort__BackingField != 0)
							{
								_ = 0;
							}
							continue;
						case 11:
							((RegexRunnerFactory)(&obj))._002Ector();
							if (Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field) == null)
							{
								_ = 2;
								if (((EntityLaunchGameProxy)EntityLaunchGameProxy.Value__BackingField).IsGame__BackingField != 0)
								{
									_ = 3;
								}
								continue;
							}
							goto case 4;
						case 5:
							goto IL_02e8;
						}
						break;
					}
					goto IL_0098;
					IL_0098:
					obj = ((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref this))._003Cuuid_003Ei__Field;
					num = 10;
					if (_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter == null)
					{
						num = 2;
					}
					goto IL_005a;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_E700()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778559, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_E800(object P_0)
		{
			//IL_001d: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got Obj
			//IL_0045: Expected Obj, but got Ref
			//IL_0059->IL0026: Incompatible stack heights: 3 vs 2
			//IL_0064->IL0026: Incompatible stack heights: 3 vs 2
			_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
			if (((EqualityComparer<_00210>)(object)Regex).Default == null)
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
					((EqualityComparer<_00210>)Unsafe.AsPointer(ref ((_003C_003Ef__AnonymousType1<, , >)Unsafe.AsPointer(ref this))._003Cuuid_003Ei__Field)).GetHashCode((_00210)P_0);
					_ = 0;
					if ((int)((_003C_003Ef__AnonymousType2<, , , >)_003C_003Ef__AnonymousType1<, , >.CheckLiteralFilter)._003Curl_003Ei__Field == 0)
					{
						_ = 0;
					}
					break;
				}
			}
		}
	}

	private static object ReflectSymbolicDecider;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static HeypixelReflectCheckResult ReflectCheck(this MassService massService, string action)
	{
		return (HeypixelReflectCheckResult)_FF00_FF00_FF00_FF00切(massService, action);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetHeypixelSession_003Ed__1))]
	public static Task<HeypixelHwid> GetHeypixelSession(this MassService massService, string name, string uuid, string userId)
	{
		return _FF00_FF00_FF00_FF00_F700(massService, name, uuid, userId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetHeypixelAntiCheat_003Ed__2))]
	public static Task<HeypixelRequestDto> GetHeypixelAntiCheat(this MassService massService, string userId, string url, string payload, string context)
	{
		return _FF00_FF00_FF00_FF00_FF00(massService, userId, url, payload, context);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool StopProvider()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MassServiceExtensions ReadCalc()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_F300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778451, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_F400()
	{
		//IL_001a: Expected Obj, but got VT
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return _003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_F500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778450, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static Task<HeypixelHwid> _FF00_FF00_FF00_FF00_F600(object P_0, object P_1, object P_2, object P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778541, new IntPtr(2737367935884L), 15))(null, 0, new IntPtr(0L));
		return (Task<HeypixelHwid>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static Task<HeypixelHwid> _FF00_FF00_FF00_FF00_F700(object P_0, object P_1, object P_2, object P_3)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005b: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 9953, 1790778540, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 4, 1790778540, new IntPtr(2737367935884L), 15);
		}
		return (Task<HeypixelHwid>)((delegate*<object, object, object, object, object>)obj)(P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static Task<HeypixelHwid> _FF00_FF00_FF00_FF00_F800(object P_0, object P_1, object P_2, object P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778543, new IntPtr(2737367936924L), 15))(null, 0, new IntPtr(0L));
		return (Task<HeypixelHwid>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00切(object P_0, object P_1)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 9956, 1790778542, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778542, new IntPtr(2737367936924L), 15);
		}
		return ((delegate*<object, object, object>)obj)(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00ﬀ(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778537, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00ﰀ()
	{
		//IL_001a: Invalid comparison between VT and Obj
		_ = ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field;
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		return (_003C_003Ef__AnonymousType1<, , >._003Cuuid_003Ei__Field == (_003Cuuid_003Ej__TPar)(object)null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00ﴀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778536, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static Task<HeypixelRequestDto> _FF00_FF00_FF00_FF00_FE00(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778539, new IntPtr(2737367947324L), 15))(null, 0, new IntPtr(0L));
		return (Task<HeypixelRequestDto>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static Task<HeypixelRequestDto> _FF00_FF00_FF00_FF00_FF00(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		//IL_0029: Expected Obj, but got I
		//IL_005d: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 9961, 1790778538, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 5, 1790778538, new IntPtr(2737367948364L), 15);
		}
		return (Task<HeypixelRequestDto>)((delegate*<object, object, object, object, object, object>)obj)(P_0, P_1, P_2, P_3, P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static Task<HeypixelRequestDto> _FF00_FF00_FF00_FF00_FF00Ā(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778533, new IntPtr(2737367937964L), 15))(null, 0, new IntPtr(0L));
		return (Task<HeypixelRequestDto>)/*Error near IL_0033: Stack underflow*/;
	}
}
