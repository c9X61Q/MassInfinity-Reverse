using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace Mass.Game.Launcher.Models;

public record RpcCallBack
{
	[CompilerGenerated]
	protected virtual Type EqualityContract
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (Type)_FF00Ā();
		}
	}

	public Rpc Rpc
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (Rpc)_FF00ἀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00ᰀ(value);
		}
	}

	public BinaryWriter Writer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (BinaryWriter)_FF00ᴀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_2100(value);
		}
	}

	public ushort Sid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00ᤀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_0E00(value);
		}
	}

	public byte[] Data
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (byte[])_FF00_0900();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		init
		{
			_FF00_0B00(value);
		}
	}

	internal static RpcCallBack ReflectIdentifiableTransmitter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RpcCallBack(Rpc Rpc, BinaryWriter Writer, ushort Sid, byte[] Data)
	{
		//IL_0053: Expected I4, but got Obj
		//IL_0041->IL004a: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		RpcCallBack rpcCallBack = this;
		if (0 == 0)
		{
			rpcCallBack = (RpcCallBack)0;
		}
		switch ((int)rpcCallBack)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Send(params object[] values)
	{
		_FF00ᘀ(values);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public T As<T>() where T : new()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public override string ToString()
	{
		return (string)_FF00Ѐ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	protected virtual bool PrintMembers(StringBuilder builder)
	{
		return _FF00_1400(builder) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public override int GetHashCode()
	{
		return (int)_FF00_2700();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public virtual bool Equals(RpcCallBack? other)
	{
		return _FF00_2800(other) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	protected RpcCallBack(RpcCallBack original)
	{
		//IL_0012: Expected Obj, but got I4
		//IL_0039: Expected I4, but got Obj
		//IL_0090: Expected Obj, but got I4
		//IL_0078->IL0020: Incompatible stack heights: 3 vs 2
		//IL_0095->IL001c: Incompatible stack heights: 3 vs 1
		//IL_004f->IL0020: Incompatible stack heights: 3 vs 2
		//IL_0068->IL0020: Incompatible stack heights: 4 vs 2
		//IL_0083->IL0020: Incompatible stack heights: 3 vs 2
		//IL_005a->IL0020: Incompatible stack heights: 3 vs 2
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
				case 4:
					return;
				case 2:
					if (false)
					{
						_ = 0;
					}
					continue;
				case 3:
					_ = 2;
					continue;
				default:
					if (false)
					{
						_ = 1;
					}
					continue;
				case 1:
					break;
				}
				break;
			}
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	public unsafe void Deconstruct(out Rpc Rpc, out BinaryWriter Writer, out ushort Sid, out byte[] Data)
	{
		_FF00က((nint)Unsafe.AsPointer(ref Rpc), (nint)Unsafe.AsPointer(ref Writer), (nint)Unsafe.AsPointer(ref Sid), (nint)Unsafe.AsPointer(ref Data));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool InterruptSorter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RpcCallBack DecorateCustomizableAnalyzer()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe object _FF00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778368, new IntPtr(2737337545004L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected object _FF00Ā()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_000a: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe object _FF00Ȁ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778431, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00Ѐ()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 4054, 1790778430, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778430, new IntPtr(2737337545004L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00Ԁ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778429, new IntPtr(2737337534604L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_0600(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778428, new IntPtr(2737337538764L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_0700(object P_0)
	{
		//IL_000c: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00ࠀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778427, new IntPtr(2737337546044L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_0900()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_0A00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778426, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_0B00(object P_0)
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
	internal unsafe void _FF00_0C00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778425, new IntPtr(2737337546044L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_0D00(ushort P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778424, new IntPtr(2737337534604L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_0E00(ushort P_0)
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
	internal unsafe void _FF00ༀ(nint P_0, nint P_1, nint P_2, nint P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778423, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00က(nint P_0, nint P_1, nint P_2, nint P_3)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0085: Expected I4, but got Obj
		//IL_0045: Expected Obj, but got I4
		//IL_0091->IL0019: Incompatible stack heights: 0 vs 1
		//IL_005b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0076->IL0019: Incompatible stack heights: 0 vs 1
		//IL_009c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0066->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0081->IL0019: Incompatible stack types: I4 vs Obj
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
				case 2:
					return;
				case 4:
					break;
				case 1:
					Unsafe.Write((void*)P_3, this);
					if (2 != 0)
					{
						obj2 = 2;
					}
					continue;
				case 3:
					Unsafe.Write((void*)P_1, this);
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				default:
					*(short*)P_2 = (short)(int)this;
					if (1 == 0)
					{
						obj2 = 1;
					}
					continue;
				}
				break;
			}
			Unsafe.Write((void*)P_0, this);
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ᄀ(nint P_0, nint P_1, nint P_2, nint P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778422, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected byte _FF00_1400(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0046: Expected I4, but got Obj
		//IL_00eb: Expected Obj, but got I4
		//IL_005b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a9->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00d3->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00c3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0119->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0099->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0077->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_010c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00de->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0124->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 9;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 5:
					return 1;
				default:
					obj2 = 7;
					continue;
				case 2:
					obj2 = P_0;
					if (6 != 0)
					{
						obj2 = 2;
					}
					continue;
				case 1:
					obj2 = P_0;
					obj = this;
					_ = ref obj;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 3:
					if (2 != 0)
					{
						obj2 = 0;
					}
					continue;
				case 7:
					_ = 5;
					continue;
				case 6:
					if (1 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 8:
					break;
				case 4:
					obj2 = P_0;
					if (3 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 9:
					if (1 == 0)
					{
						obj2 = 8;
					}
					continue;
				}
				break;
			}
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00ᔀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778421, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00ᘀ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_003d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0048->IL0019: Incompatible stack heights: 3 vs 1
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
	internal unsafe void _FF00ᜀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778420, new IntPtr(2737337546044L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ushort _FF00_1800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778419, new IntPtr(2737337546044L), 15))(null, 0, new IntPtr(0L));
		return (ushort)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ushort _FF00ᤀ()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ushort)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ushort _FF00ᨀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778418, new IntPtr(2737337546044L), 15))(null, 0, new IntPtr(0L));
		return (ushort)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_1B00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778417, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00ᰀ(object P_0)
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
				if (false)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00ᴀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00Ḁ(object P_0, object P_1)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (P_1 == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00ἀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_2000(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778416, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_2100(object P_0)
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
				if (false)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_2200(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778415, new IntPtr(2737337546044L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_2300()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_2400()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778414, new IntPtr(2737337546044L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_2500()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_2600(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_006e: Expected I4, but got Obj
		//IL_005f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0042->IL0019: Incompatible stack heights: 0 vs 1
		//IL_006a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_004d->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				if (P_0 != P_1)
				{
					if (0 == 0)
					{
						obj2 = 1;
					}
					break;
				}
				return 1;
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
				return (byte)(int)P_1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_2700()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected I4, but got Unknown
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)((((this * -1521134295 + this) * -1521134295 + this) * -1521134295 + this) * -1521134295 + this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_2800(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0042: Expected I4, but got Obj
		//IL_00b4: Expected I4, but got Obj
		//IL_00e9: Expected Obj, but got I4
		//IL_00f8->IL00b4: Incompatible stack heights: 1 vs 0
		//IL_0092->IL00b4: Incompatible stack heights: 1 vs 0
		//IL_0061->IL00ad: Incompatible stack heights: 1 vs 0
		//IL_00e0->IL0087: Incompatible stack heights: 1 vs 0
		//IL_0102->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ca->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00ad->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ee->IL0015: Incompatible stack heights: 1 vs 0
		//IL_0078->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d5->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 7;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 4:
					obj2 = this;
					if (P_0 == null)
					{
						if (false)
						{
							obj2 = 0;
						}
						break;
					}
					goto case 3;
				case 2:
					if (P_0 != null)
					{
						_ = 4;
						break;
					}
					goto default;
				case 7:
					if (this == P_0)
					{
						return 1;
					}
					obj2 = 6;
					break;
				case 3:
					return (byte)(int)P_0;
				default:
					return 0;
				case 6:
					if (P_0 != null)
					{
						if (1 == 0)
						{
							obj2 = 1;
						}
						break;
					}
					goto default;
				case 8:
					if (P_0 == null)
					{
						goto end_IL_0019;
					}
					goto case 2;
				case 1:
					if (P_0 != null)
					{
						_ = 8;
						break;
					}
					goto default;
				}
				continue;
				end_IL_0019:
				break;
			}
			obj = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_2900(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778413, new IntPtr(2737337539804L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_2A00()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}
}
