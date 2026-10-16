using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Mass.Common.Extensions;
using Mass.Domain.Entities.Netease;
using RestSharp;
using Serilog;

namespace Mass.Application.Netease;

public class NeteaseMgbSdk
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAuthSessionAsync_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EntityMgbSdk> _003C_003Et__builder;

		public NeteaseMgbSdk _003C_003E4__this;

		public object sAuth;

		private TaskAwaiter<RestResponse<EntityMgbSdk>> _003C_003Eu__1;

		private static object DecorateDynamicVisitor;

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
		internal static bool ReflectConcreteWatcher()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateConnectedElement()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00錀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778896, new IntPtr(2737337507564L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00鐀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_003f: Expected Obj, but got Ref
			//IL_0292: Expected Obj, but got Ref
			//IL_01ce: Expected Obj, but got Ref
			//IL_01b3: Expected Obj, but got I4
			//IL_00bd: Expected Obj, but got I4
			//IL_0102: Expected Obj, but got I4
			//IL_0131: Expected Obj, but got I4
			//IL_0282->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 0 vs 1
			//IL_029c->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0267->IL0019: Incompatible stack heights: 2 vs 1
			//IL_028d->IL0019: Incompatible stack heights: 2 vs 1
			//IL_01d8->IL006c: Incompatible stack types: I4 vs Ref
			//IL_0068->IL006c: Incompatible stack types: I4 vs Ref
			//IL_0056->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0272->IL0019: Incompatible stack heights: 2 vs 1
			//IL_017f->IL006c: Incompatible stack heights: 3 vs 1
			//IL_010f->IL006c: Incompatible stack heights: 2 vs 1
			//IL_0157->IL006c: Incompatible stack types: I4 vs Ref
			//IL_013e->IL006c: Incompatible stack heights: 2 vs 1
			//IL_01ab->IL006c: Incompatible stack heights: 6 vs 1
			//IL_01ca->IL006c: Incompatible stack types: I4 vs Ref
			//IL_006c->IL006c: Incompatible stack heights: 4 vs 1
			//IL_00fd->IL006c: Incompatible stack types: I4 vs Ref
			//IL_00db->IL006c: Incompatible stack heights: 0 vs 1
			//IL_0171->IL006c: Incompatible stack types: I4 vs Ref
			//IL_012c->IL006c: Incompatible stack types: I4 vs Ref
			//IL_011a->IL006c: Incompatible stack heights: 2 vs 1
			//IL_0149->IL006c: Incompatible stack heights: 2 vs 1
			//IL_00e6->IL006c: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 4;
			object obj2 = obj;
			while (true)
			{
				ref byte reference;
				switch ((int)obj2)
				{
				case 3:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 2;
					}
					break;
				case 2:
					if (obj != null)
					{
						reference = ref *(byte*)12;
						goto IL_006c;
					}
					goto IL_01ca;
				case 5:
					if (0 == 0)
					{
						_ = 1;
					}
					break;
				default:
					goto IL_0272;
				case 1:
					return;
				case 4:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						obj2 = 3;
						break;
					}
					IL_0272:
					_ = -2;
					if (5 == 0)
					{
						_ = 5;
					}
					break;
					IL_01ca:
					obj = (object)Unsafe.AsPointer(ref this);
					reference = ref *(byte*)4;
					goto IL_006c;
					IL_006c:
					while (true)
					{
						switch ((uint)Unsafe.AsPointer(ref reference))
						{
						case 2u:
							_ = ref obj;
							obj = 13;
							continue;
						case 3u:
							break;
						case 10u:
							throw obj;
						case 6u:
							obj = 0;
							if (1 == 0)
							{
								_ = 1;
							}
							continue;
						case 5u:
							if (&obj == null)
							{
								reference = ref *(byte*)6;
								continue;
							}
							goto default;
						case 11u:
							obj = -1;
							if (false)
							{
								_ = 0;
							}
							continue;
						case 9u:
							obj = obj;
							reference = ref *(byte*)8;
							continue;
						case 4u:
							reference = ref Unsafe.As<_003CAuthSessionAsync_003Ed__11, byte>(ref this);
							if (10 != 0)
							{
								reference = ref *(byte*)11;
							}
							continue;
						case 1u:
							_ = 2;
							continue;
						case 13u:
							return;
						case 12u:
							_ = 1;
							_ = null;
							_ = ref obj;
							obj = obj;
							_ = 5;
							continue;
						default:
							reference = ref *(byte*)(&obj);
							obj = 1;
							if (2 != 0)
							{
								reference = ref *(byte*)3;
							}
							continue;
						case 7u:
							goto end_IL_006c;
						case 8u:
							goto IL_0272;
						}
						if ((nint)obj != 200)
						{
							if (10 != 0)
							{
								reference = ref *(byte*)10;
							}
						}
						else
						{
							reference = ref *(byte*)9;
						}
						continue;
						end_IL_006c:
						break;
					}
					goto IL_01ca;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00销()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778903, new IntPtr(2737337507564L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00阀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778902, new IntPtr(2737337507564L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00需(object P_0)
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
		private unsafe sealed void _FF00頀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778901, new IntPtr(2737337507564L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00餀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778900, new IntPtr(2737337507564L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00騀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00鬀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00鰀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778907, new IntPtr(2737337507564L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[CompilerGenerated]
	private static readonly object Logger__BackingField;

	[CompilerGenerated]
	private static readonly object Desktop__BackingField;

	[CompilerGenerated]
	private static readonly object Mobile__BackingField;

	private readonly object _client;

	private static object ReadEnumerator;

	private static ILogger Logger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	public static NeteaseMgbSdk Desktop
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	public static NeteaseMgbSdk Mobile
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NeteaseMgbSdk(bool isDesktop)
	{
		//IL_004e: Expected I4, but got Obj
		//IL_0017->IL0018: Incompatible stack heights: 2 vs 3
		//IL_003c->IL0045: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		if (isDesktop)
		{
			_ = null;
		}
		_ = null;
		_ = null;
		_ = 0;
		NeteaseMgbSdk neteaseMgbSdk = this;
		if (0 == 0)
		{
			neteaseMgbSdk = (NeteaseMgbSdk)0;
		}
		switch ((int)neteaseMgbSdk)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAuthSessionAsync_003Ed__11))]
	public Task<EntityMgbSdk> AuthSessionAsync(object sAuth)
	{
		return _FF00_FF00_FF00_FF00_2000(sAuth);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedRegex("<ntsdk.*?</ntsdk>", RegexOptions.Singleline)]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.13.2707")]
	private static object NtsdkRegex()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	static NeteaseMgbSdk()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0027: Expected I4, but got Obj
		//IL_0075->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00a9->IL0012: Incompatible stack types: I4 vs Obj
		//IL_004b->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0080->IL0012: Incompatible stack types: I4 vs Obj
		//IL_00b4->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0056->IL0012: Incompatible stack types: I4 vs Obj
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				Mobile__BackingField = new NeteaseMgbSdk(isDesktop: false);
				obj2 = 1;
				if (_003CModule_003E_007Bc547b36a_002Df832_002D4783_002Dbff4_002D35ff9bad7e58_007D.m_a6edc9c6177f4d1d9742e13736eb3634.m_b98b8c7ea03c4809a1590868030ba3d6 != 0)
				{
					obj2 = 3;
				}
				break;
			default:
				Desktop__BackingField = new NeteaseMgbSdk(isDesktop: true);
				obj2 = 2;
				if (_003CModule_003E_007Bc547b36a_002Df832_002D4783_002Dbff4_002D35ff9bad7e58_007D.m_a6edc9c6177f4d1d9742e13736eb3634.m_f7e42b7a624b4fbc9dee8f4ccb3eb28c != 0)
				{
					obj2 = 2;
				}
				break;
			case 3:
				return;
			case 1:
				Logger__BackingField = Log.Logger.Category((string)ZYXDNGuarder._FF00_FF00_FF00_FF00ᰀ());
				obj2 = 0;
				if (_003CModule_003E_007Bc547b36a_002Df832_002D4783_002Dbff4_002D35ff9bad7e58_007D.m_a6edc9c6177f4d1d9742e13736eb3634.m_cf3bab1d42f2405f92a3e5e30296ffd6 == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckMonoDecryptor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static NeteaseMgbSdk CheckOrderedError()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00ᤀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778857, new IntPtr(2737337507564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00ᨀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_1B00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778856, new IntPtr(2737337506524L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00ᴀ()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00Ḁ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778863, new IntPtr(2737337506524L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityMgbSdk> _FF00_FF00_FF00_FF00ἀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778862, new IntPtr(2737337506524L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityMgbSdk>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityMgbSdk> _FF00_FF00_FF00_FF00_2000(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 1825, 1790778861, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778861, new IntPtr(2737337506524L), 15);
		}
		return (Task<EntityMgbSdk>)((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe Task<EntityMgbSdk> _FF00_FF00_FF00_FF00_2100(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778860, new IntPtr(2737337507564L), 15))(null, 0, new IntPtr(0L));
		return (Task<EntityMgbSdk>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00_FF00_FF00_FF00_2200()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_2300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778899, new IntPtr(2737337507564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object _FF00_FF00_FF00_FF00_2400()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00_2500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778898, new IntPtr(2737337507564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_2600()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_2900()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_2A00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778897, new IntPtr(2737337507564L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
