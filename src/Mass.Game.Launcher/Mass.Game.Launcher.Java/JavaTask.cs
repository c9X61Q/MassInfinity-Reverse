using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Mass.Domain.Desktop.ValueObjects;
using Mass.Game.Launcher.Enums;

namespace Mass.Game.Launcher.Java;

public sealed class JavaTask
{
	private readonly record struct TaskKey
	{
		public EnumGameVersion Version
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _FF00_FF00_FF00_FF00_FF00_FF00ﴀ();
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			init
			{
				_FF00_FF00_FF00_FF00_FF00_FF00_FF00Ѐ(value);
			}
		}

		public string Id
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (string)_FF00_FF00_FF00_FF00_FF00_FF00_F100();
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			init
			{
				_FF00_FF00_FF00_FF00_FF00_FF00_F300(value);
			}
		}

		public JavaStep Step
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ԁ();
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			init
			{
				_FF00_FF00_FF00_FF00_FF00_FF00_EE00(value);
			}
		}

		private static object CheckDividedRunner;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaskKey(EnumGameVersion Version, string Id, JavaStep Step)
		{
			//IL_0050->IL0010: Incompatible stack heights: 3 vs 2
			//IL_0068->IL0010: Incompatible stack heights: 4 vs 2
			//IL_005b->IL0010: Incompatible stack heights: 3 vs 2
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			int num = (int)Version;
			if (false)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 2:
					return;
				case 1:
					_ = 2;
					continue;
				}
				if (1 == 0)
				{
					_ = 1;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public override string ToString()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private byte PrintMembers(object builder)
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00豈(builder);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool Equals(TaskKey other)
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public unsafe void Deconstruct(out EnumGameVersion Version, out string Id, out JavaStep Step)
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_E400((nint)Unsafe.AsPointer(ref Version), (nint)Unsafe.AsPointer(ref Id), (nint)Unsafe.AsPointer(ref Step));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ReflectGeneralClient()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecorateExtendedListener()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_E100()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778902, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_E200()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_E300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778901, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_E400(nint P_0, nint P_1, nint P_2)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002e: Expected I4, but got Obj
			//IL_0053: Expected Obj, but got Ref
			//IL_005d->IL0019: Incompatible stack types: I4 vs Obj
			//IL_006d->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0043->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0078->IL0019: Incompatible stack types: I4 vs Obj
			//IL_004e->IL0019: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 3:
					*(int*)P_2 = (int)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 2;
					}
					break;
				case 2:
					return;
				default:
					Unsafe.Write((void*)P_1, (object)Unsafe.AsPointer(ref this));
					obj2 = 3;
					break;
				case 1:
					*(int*)P_0 = (int)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal byte _FF00_FF00_FF00_FF00_FF00_FF00_E500(object P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_004e: Expected I4, but got Obj
			//IL_003e->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
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
					if (P_0 != null)
					{
						if (0 == 0)
						{
							obj2 = 0;
						}
						break;
					}
					return 0;
				default:
					return (byte)(int)P_0;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_E600(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778900, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_E700()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_E800(TaskKey P_0, TaskKey P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778899, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_E900(TaskKey P_0, TaskKey P_1)
		{
			//IL_000c: Expected I4, but got VT
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			_ = ref P_0;
			return (byte)(int)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_EA00(TaskKey P_0, TaskKey P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778898, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_EB00(TaskKey P_0, TaskKey P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778897, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_EC00(TaskKey P_0, TaskKey P_1)
		{
			//IL_000b: Invalid comparison between VT and I4
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (P_1 == (TaskKey)(object)0) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_ED00(TaskKey P_0, TaskKey P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778896, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _FF00_FF00_FF00_FF00_FF00_FF00_EE00(JavaStep P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0045->IL0019: Incompatible stack heights: 2 vs 1
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
		internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_EF00(JavaStep P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778895, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_F000()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778894, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_F100()
		{
			//IL_000a: Expected Obj, but got Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)Unsafe.AsPointer(ref this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_F200()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778893, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _FF00_FF00_FF00_FF00_FF00_FF00_F300(object P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0045->IL0019: Incompatible stack heights: 2 vs 1
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
		internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_F400(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778892, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_F500()
		{
			//IL_0029: Expected Obj, but got I
			//IL_0058: Expected I, but got Obj
			//IL_0051: Expected Obj, but got I
			nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 3530, 1790778891, 0, 0);
			object obj = num;
			if (num == 0)
			{
				obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778891, new IntPtr(2737337581404L), 15);
			}
			return ((delegate*<nint, object>)obj)((nint)Unsafe.AsPointer(ref this));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_F800(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778890, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00豈(object P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_005f: Expected Obj, but got Ref
			//IL_00bb: Expected Obj, but got Ref
			//IL_006f->IL0019: Incompatible stack heights: 2 vs 1
			//IL_007f->IL0019: Incompatible stack heights: 0 vs 1
			//IL_004f->IL0019: Incompatible stack heights: 0 vs 1
			//IL_00cb->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0098->IL0019: Incompatible stack types: I4 vs Obj
			//IL_00b6->IL0019: Incompatible stack types: I4 vs Obj
			//IL_008a->IL0019: Incompatible stack types: I4 vs Obj
			//IL_005a->IL0019: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 3:
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					_ = ref obj;
					_ = 3;
					continue;
				case 2:
					if (1 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 5:
					obj2 = 4;
					continue;
				case 6:
					return 1;
				case 4:
					obj = (object)Unsafe.AsPointer(ref this);
					_ = ref obj;
					_ = 6;
					continue;
				}
				obj2 = P_0;
				if (5 == 0)
				{
					obj2 = 1;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00切(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778889, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00ﬀ()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (uint)Unsafe.AsPointer(ref Unsafe.AddByteOffset(byteOffset: (nint)Unsafe.AsPointer(ref Unsafe.AddByteOffset(byteOffset: (nint)Unsafe.AsPointer(ref this) * (nint)(-1521134295), source: ref this)) * (nint)(-1521134295), source: ref this));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe uint _FF00_FF00_FF00_FF00_FF00_FF00ﰀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778888, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (uint)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe EnumGameVersion _FF00_FF00_FF00_FF00_FF00_FF00ﴀ()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (EnumGameVersion)(uint)Unsafe.AsPointer(ref this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe EnumGameVersion _FF00_FF00_FF00_FF00_FF00_FF00_FE00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778887, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (EnumGameVersion)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00(TaskKey P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778886, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ā(TaskKey P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0032: Expected I4, but got Obj
			//IL_008b: Expected I4, but got VT
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_005e->IL0084: Incompatible stack heights: 1 vs 0
			//IL_0098->IL0053: Incompatible stack heights: 1 vs 0
			//IL_0068->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00af->IL0019: Incompatible stack types: I4 vs Ref
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			ref readonly TaskKey reference = ref *(TaskKey*)obj;
			while (true)
			{
				switch ((uint)Unsafe.AsPointer(ref reference))
				{
				default:
					if ((int)P_0 == 0)
					{
						_ = 3;
						break;
					}
					goto case 4u;
				case 4u:
					return (byte)(int)P_0;
				case 1u:
				case 3u:
					return 0;
				case 2u:
					reference = ref this;
					if ((int)P_0 == 0)
					{
						if (1 == 0)
						{
							reference = ref *(TaskKey*)1;
						}
						break;
					}
					goto default;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ȁ(TaskKey P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778885, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0300(EnumGameVersion P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778884, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ѐ(EnumGameVersion P_0)
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
		internal unsafe JavaStep _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ԁ()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (JavaStep)(int)Unsafe.AsPointer(ref this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe JavaStep _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0600()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778883, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (JavaStep)/*Error near IL_0033: Stack underflow*/;
		}
	}

	private sealed class TaskEntry
	{
		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CWaitAsync_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public TaskEntry _003C_003E4__this;

			public CancellationToken callerToken;

			private object _003C_003E7__wrap1;

			private nint _003C_003E7__wrap2;

			private TaskAwaiter _003C_003Eu__1;

			private static object AssetCalc;

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
			internal static bool DeleteTree()
			{
				throw new Exception("Error, DNGuard Runtime library not loaded!");
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object CheckInterruptibleHandler()
			{
				throw new Exception("Error, DNGuard Runtime library not loaded!");
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00쐀(object P_0)
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778935, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private sealed void _FF00_FF00_FF00_FF00_FF00_FF00씀(object P_0)
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
			internal static object _FF00_FF00_FF00_FF00_FF00_FF00였()
			{
				if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
				{
				}
				return (object)/*Error near IL_0009: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00윀()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778934, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
				return (object)/*Error near IL_0033: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00저()
			{
				//IL_0010: Expected Obj, but got I4
				//IL_0036: Expected I4, but got Obj
				//IL_05d3: Expected Obj, but got Ref
				//IL_05aa: Expected Obj, but got Ref
				//IL_03dc: Expected Obj, but got I4
				//IL_015a: Expected Obj, but got Ref
				//IL_0187: Expected Obj, but got Ref
				//IL_03cc: Expected Obj, but got I4
				//IL_02eb: Expected Obj, but got Ref
				//IL_021d: Expected I4, but got Obj
				//IL_027e: Expected Obj, but got Ref
				//IL_0287: Expected Obj, but got I4
				//IL_02ca: Expected Obj, but got I4
				//IL_0307: Expected Obj, but got I4
				//IL_05df->IL0019: Incompatible stack heights: 0 vs 1
				//IL_05b6->IL0019: Incompatible stack heights: 0 vs 1
				//IL_05cf->IL0019: Incompatible stack heights: 2 vs 1
				//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
				//IL_05ea->IL0019: Incompatible stack types: I4 vs Obj
				//IL_05c1->IL0019: Incompatible stack types: I4 vs Obj
				//IL_0056->IL0019: Incompatible stack heights: 2 vs 1
				//IL_051d->IL006a: Incompatible stack heights: 0 vs 1
				//IL_014b->IL0096: Incompatible stack heights: 0 vs 1
				//IL_0449->IL0096: Incompatible stack heights: 3 vs 1
				//IL_03e9->IL0096: Incompatible stack heights: 2 vs 1
				//IL_0166->IL0096: Incompatible stack heights: 0 vs 1
				//IL_01c3->IL0096: Incompatible stack heights: 3 vs 1
				//IL_0101->IL0096: Incompatible stack heights: 2 vs 1
				//IL_0401->IL0096: Incompatible stack heights: 2 vs 1
				//IL_03d7->IL0096: Incompatible stack heights: 3 vs 1
				//IL_011c->IL0096: Incompatible stack heights: 3 vs 1
				//IL_010f->IL0096: Incompatible stack heights: 3 vs 1
				//IL_0415->IL0096: Incompatible stack heights: 0 vs 1
				//IL_01e0->IL01e4: Incompatible stack types: I4 vs Obj
				//IL_03f4->IL0096: Incompatible stack heights: 2 vs 1
				//IL_03bc->IL0096: Incompatible stack heights: 0 vs 1
				//IL_046c->IL0096: Incompatible stack heights: 2 vs 1
				//IL_01ce->IL0096: Incompatible stack heights: 3 vs 1
				//IL_01a6->IL0096: Incompatible stack heights: 0 vs 1
				//IL_0302->IL01e4: Incompatible stack types: I4 vs Obj
				//IL_029e->IL01e4: Incompatible stack heights: 3 vs 1
				//IL_02d7->IL01e4: Incompatible stack heights: 2 vs 1
				//IL_031f->IL01e4: Incompatible stack heights: 2 vs 1
				//IL_02c5->IL01e4: Incompatible stack heights: 2 vs 1
				//IL_023f->IL01e4: Incompatible stack heights: 3 vs 1
				//IL_0312->IL01e4: Incompatible stack heights: 3 vs 1
				//IL_02a9->IL01e4: Incompatible stack heights: 3 vs 1
				//IL_02e2->IL01e4: Incompatible stack heights: 2 vs 1
				//IL_0253->IL01e4: Incompatible stack heights: 0 vs 1
				//IL_025e->IL01e4: Incompatible stack types: I4 vs Obj
				if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
				{
				}
				object obj = 1;
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 5:
						_ = -2;
						if (false)
						{
							_ = 2;
						}
						break;
					case 3:
					{
						_ = 1;
						int num = 2;
						while (true)
						{
							int num2;
							switch (num)
							{
							case 1:
								if (obj != null)
								{
									num2 = 18;
									goto IL_0096;
								}
								goto IL_0449;
							case 2:
								{
									if (1 == 0)
									{
										num = 1;
									}
									continue;
								}
								IL_0449:
								num2 = 2;
								goto IL_0096;
								IL_0096:
								while (true)
								{
									object obj3;
									switch (num2)
									{
									case 3:
										break;
									case 10:
									case 13:
										_ = ref obj;
										_ = 7;
										continue;
									case 20:
										_ = 9;
										continue;
									case 17:
										_ = null;
										_ = 3;
										continue;
									case 19:
										return;
									default:
										obj = obj;
										if (true)
										{
											num2 = 1;
										}
										continue;
									case 8:
										obj = (object)Unsafe.AsPointer(ref this);
										if (15 == 0)
										{
											num2 = 9;
										}
										continue;
									case 18:
										if ((nint)obj != 1)
										{
											num2 = 4;
											continue;
										}
										goto case 8;
									case 14:
										obj = (object)Unsafe.AsPointer(ref this);
										num2 = 6;
										continue;
									case 11:
										if (obj == null)
										{
											if (0 == 0)
											{
												num2 = 0;
											}
											continue;
										}
										goto IL_0454;
									case 9:
										_ = ref obj;
										if (19 != 0)
										{
											_ = 1;
										}
										continue;
									case 2:
										if (obj == null)
										{
											obj3 = 9;
											goto IL_01e4;
										}
										goto IL_02e2;
									case 6:
										if ((nint)obj == 1)
										{
											if (11 == 0)
											{
												num2 = 9;
											}
											continue;
										}
										goto case 17;
									case 16:
										obj = -1;
										_ = 10;
										continue;
									case 5:
										obj = 1;
										if (20 == 0)
										{
											_ = 2;
										}
										continue;
									case 15:
										_ = 16;
										continue;
									case 1:
										if (&obj != null)
										{
											if (13 != 0)
											{
												num2 = 8;
											}
											continue;
										}
										goto case 5;
									case 4:
										_ = 0;
										_ = 12;
										continue;
									case 12:
										goto end_IL_0096;
									case 7:
										goto IL_0454;
										IL_02e2:
										obj3 = obj;
										obj = (object)Unsafe.AsPointer(ref this);
										if (10 == 0)
										{
											obj3 = 1;
										}
										goto IL_01e4;
										IL_01e4:
										while (true)
										{
											switch ((int)obj3)
											{
											case 12:
												break;
											case 8:
												_ = 2;
												continue;
											case 10:
												if (&obj != null)
												{
													if (0 == 0)
													{
														obj3 = 1;
													}
													continue;
												}
												goto case 3;
											case 7:
												return;
											default:
												obj = (object)Unsafe.AsPointer(ref this);
												obj = 4;
												obj3 = obj;
												continue;
											case 2:
												_ = ref obj;
												if (7 != 0)
												{
													_ = 2;
												}
												continue;
											case 1:
											case 5:
												_ = ref obj;
												_ = 12;
												continue;
											case 3:
												obj = 0;
												if (6 != 0)
												{
													_ = 8;
												}
												continue;
											case 6:
												goto IL_02e2;
											case 11:
												obj = -1;
												_ = 5;
												continue;
											case 4:
												_ = 11;
												continue;
											}
											break;
										}
										goto case 14;
									}
									goto end_IL_006a;
									IL_0454:
									if (Unsafe.AsPointer(ref this) == null)
									{
										throw ref this;
									}
									_ = 17;
									continue;
									end_IL_0096:
									break;
								}
								goto IL_0449;
								end_IL_006a:
								break;
							}
							break;
						}
						goto case 5;
					}
					case 1:
						obj = (object)Unsafe.AsPointer(ref this);
						if (0 == 0)
						{
							obj2 = 0;
						}
						break;
					case 4:
						return;
					case 2:
						_ = 4;
						break;
					default:
						obj = (object)Unsafe.AsPointer(ref this);
						if (1 == 0)
						{
							obj2 = 3;
						}
						break;
					}
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00준()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778933, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
				_ = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static byte _FF00_FF00_FF00_FF00_FF00_FF00쨀()
			{
				//IL_0009: Invalid comparison between Unknown and Obj
				if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
				{
				}
				return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00쬀()
			{
				//IL_0008: Expected I8, but got I4
				((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778932, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
				return (byte)/*Error near IL_0033: Stack underflow*/;
			}
		}

		private readonly object _internalCts;

		private nint _waiterCount;

		private object? _sourceGame;

		private nint _progressBound;

		internal static object DecorateVisibleTracker;

		public Task Task
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (Task)_FF00_FF00_FF00_FF00_FF00_FF00_E000();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaskEntry(Task task, CancellationTokenSource cts)
		{
			//IL_0042: Expected I4, but got Obj
			//IL_0030->IL0039: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			TaskEntry taskEntry = this;
			if (0 == 0)
			{
				taskEntry = (TaskEntry)0;
			}
			switch ((int)taskEntry)
			{
			case 0:
				break;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task AttachCaller(CancellationToken callerToken)
		{
			return (Task)_FF00_FF00_FF00_FF00_FF00_FF00혀(callerToken);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(_003CWaitAsync_003Ed__9))]
		private object WaitAsync(CancellationToken callerToken)
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FFFD(callerToken);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BindProgress(JavaGame target, JavaStep step)
		{
			_FF00_FF00_FF00_FF00_FF00_FF00픀(target, step);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ReflectCentralFinalizer()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskEntry ReflectStatelessAggregator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00퐀(object P_0, JavaStep P_1)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778882, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _FF00_FF00_FF00_FF00_FF00_FF00픀(object P_0, JavaStep P_1)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0056: Expected I4, but got Obj
			//IL_0095: Expected Obj, but got I4
			//IL_015d: Expected Obj, but got I4
			//IL_018c->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0102->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0068->IL0019: Incompatible stack types: I4 vs Obj
			//IL_009a->IL0015: Incompatible stack heights: 2 vs 0
			//IL_0121->IL0019: Incompatible stack heights: 2 vs 1
			//IL_007c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00e9->IL0019: Incompatible stack heights: 2 vs 1
			//IL_012c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00ce->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0110->IL0019: Incompatible stack heights: 3 vs 1
			//IL_014c->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0087->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00f4->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00ae->IL0019: Incompatible stack heights: 0 vs 1
			//IL_00d9->IL0019: Incompatible stack types: I4 vs Obj
			//IL_00b9->IL0019: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
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
					default:
						return;
					case 4:
						obj = (object)/*Error near IL_005e: Stack underflow*/;
						obj2 = 3;
						continue;
					case 11:
						if (0 == 0)
						{
							_ = 10;
						}
						continue;
					case 5:
						obj = 2;
						break;
					case 13:
						return;
					case 9:
						return;
					case 7:
						if (this == null)
						{
							if (this == null)
							{
								if (2 == 0)
								{
									obj2 = 5;
								}
								continue;
							}
							if (this != null)
							{
								return;
							}
							obj = 8;
							break;
						}
						if (13 == 0)
						{
							obj2 = 13;
						}
						continue;
					case 12:
						if (true)
						{
							_ = 1;
						}
						continue;
					case 3:
						_ = 12;
						continue;
					case 0:
						return;
					case 8:
						_ = 1;
						_ = 6;
						continue;
					case 6:
						if (11 != 0)
						{
							_ = 10;
						}
						continue;
					case 10:
						obj2 = this;
						if (5 != 0)
						{
							obj2 = 9;
						}
						continue;
					case 2:
						return;
					case 1:
						_ = 7;
						continue;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00혀(CancellationToken P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0032: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got VT
			//IL_0051->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0091->IL0019: Incompatible stack heights: 0 vs 1
			//IL_007d->IL0019: Incompatible stack types: I4 vs Obj
			//IL_005c->IL0019: Incompatible stack types: I4 vs Obj
			//IL_009c->IL0019: Incompatible stack types: I4 vs Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 4:
					return this;
				case 3:
					return P_0;
				default:
					return this;
				case 2:
					if (&P_0 != null)
					{
						obj2 = 3;
						break;
					}
					goto case 4;
				case 1:
					if (this == null)
					{
						if (false)
						{
							obj2 = 2;
						}
					}
					else if (false)
					{
						obj2 = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00휀(CancellationToken P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778881, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778880, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778943, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778942, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FFFD()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778941, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FFFD(CancellationToken P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778940, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FFFD(CancellationToken P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0085: Expected Obj, but got I4
			//IL_005b: Expected Obj, but got Ref
			//IL_0019->IL0019: Incompatible stack types: Obj vs Ref
			//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_009a->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00b5->IL0019: Incompatible stack heights: 2 vs 1
			//IL_008a->IL0015: Incompatible stack heights: 2 vs 0
			//IL_0056->IL0019: Incompatible stack heights: 2 vs 1
			//IL_00a5->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0076->IL0019: Incompatible stack types: I4 vs Ref
			//IL_00c0->IL0019: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 2;
			while (true)
			{
				ref object reference = ref *(object*)obj;
				while (true)
				{
					switch ((uint)Unsafe.AsPointer(ref reference))
					{
					default:
						_ = ref obj;
						_ = -1;
						if (1 == 0)
						{
							_ = 4;
						}
						continue;
					case 5u:
						return (object)(&obj);
					case 2u:
						reference = ref obj;
						if (1 == 0)
						{
							reference = ref *(object*)1;
						}
						continue;
					case 4u:
						break;
					case 1u:
						_ = ref obj;
						if (3 != 0)
						{
							_ = 2;
						}
						continue;
					case 3u:
						_ = ref obj;
						if (false)
						{
							_ = 0;
						}
						continue;
					}
					break;
				}
				_ = ref obj;
				_ = ref obj;
				obj = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal object _FF00_FF00_FF00_FF00_FF00_FF00_E000()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return this;
		}
	}

	private readonly ConcurrentDictionary<TaskKey, TaskEntry> _tasks;

	internal static JavaTask DecorateAccessibleTransformer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task CallPrepareJre(JavaGame game, CancellationToken cancellationToken = default(CancellationToken))
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00_FF00_FF00_0E00(game, cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task CallPrepareBaseVersion(JavaGame game, CancellationToken cancellationToken = default(CancellationToken))
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00_FF00_FF00ࠀ(game, cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task CallPrepareVersion(JavaGame game, CancellationToken cancellationToken = default(CancellationToken))
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00_FF00_FF00ጀ(game, cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task CallPrepareComponents(JavaGame game, CancellationToken cancellationToken = default(CancellationToken))
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00_FF00_FF00ᄀ(game, cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task CallPrepareServerResource(JavaGame game, CancellationToken cancellationToken = default(CancellationToken))
	{
		return (Task)_FF00_FF00_FF00_FF00_FF00_FF00_FF00ᔀ(game, cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object Call(EnumGameVersion version, object id, JavaStep step, object caller, Func<CancellationToken, Task> factory, CancellationToken cancellationToken = default(CancellationToken))
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0A00(version, id, step, caller, factory, cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JavaTask()
	{
		//IL_003a: Expected I4, but got Obj
		//IL_0028->IL0031: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		JavaTask javaTask = this;
		if (false)
		{
			javaTask = (JavaTask)0;
		}
		switch ((int)javaTask)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateIsolatedMap()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static JavaTask CheckAutomatableVisitor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0700(object P_0, CancellationToken P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778909, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ࠀ(object P_0, CancellationToken P_1)
	{
		//IL_002d: Expected Obj, but got VT
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_ = 2;
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0900(object P_0, CancellationToken P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778908, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0A00(EnumGameVersion P_0, object P_1, JavaStep P_2, object P_3, Func<CancellationToken, Task> P_4, CancellationToken P_5)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_009b: Expected Obj, but got VT
		//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
		//IL_007d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0061->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00ac->IL0019: Incompatible stack heights: 5 vs 1
		//IL_0052->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0088->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006c->IL0019: Incompatible stack types: I4 vs Obj
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
				if (4 == 0)
				{
					_ = 4;
				}
				break;
			case 2:
				obj = (object)/*Error near IL_0055: Stack underflow*/;
				if (true)
				{
					obj2 = 0;
				}
				break;
			case 1:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 3:
				return P_5;
			case 4:
				_ = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0B00(EnumGameVersion P_0, object P_1, JavaStep P_2, object P_3, Func<CancellationToken, Task> P_4, CancellationToken P_5)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778907, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0C00()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0D00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778906, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_0E00(object P_0, CancellationToken P_1)
	{
		//IL_0012: Expected Obj, but got VT
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_ = 0;
		_ = 1;
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ༀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00က()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778905, new IntPtr(2737337593884L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᄀ(object P_0, CancellationToken P_1)
	{
		//IL_0023: Expected Obj, but got VT
		//IL_0019->IL001b: Incompatible stack heights: 2 vs 3
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		if ((nint)P_0 != 9)
		{
		}
		_ = 5;
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ሀ(object P_0, CancellationToken P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778904, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ጀ(object P_0, CancellationToken P_1)
	{
		//IL_0013: Expected Obj, but got VT
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_ = 3;
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_1400(object P_0, CancellationToken P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778903, new IntPtr(2737337581404L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᔀ(object P_0, CancellationToken P_1)
	{
		//IL_0014: Expected Obj, but got VT
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		_ = 6;
		return P_1;
	}
}
