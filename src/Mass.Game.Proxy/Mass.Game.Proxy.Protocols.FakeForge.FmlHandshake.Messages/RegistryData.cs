using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;

namespace Mass.Game.Proxy.Protocols.FakeForge.FmlHandshake.Messages;

public class RegistryData : FmlHandshakeMessage
{
	public class IdEntity
	{
		public string Name;

		public int Id;

		private static object DecorateSymbolicStrategy;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IdEntity(string name, int id)
		{
			//IL_003a: Expected I4, but got Obj
			//IL_0020->IL0029: Incompatible stack types: I4 vs Obj
			//IL_004f->IL0029: Incompatible stack heights: 2 vs 1
			//IL_0069->IL0029: Incompatible stack heights: 2 vs 1
			//IL_005a->IL0029: Incompatible stack heights: 2 vs 1
			//IL_0074->IL0029: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			IdEntity idEntity = this;
			if (0 == 0)
			{
				idEntity = (IdEntity)1;
			}
			while (true)
			{
				switch ((int)idEntity)
				{
				case 2:
					return;
				default:
					if (0 == 0)
					{
						_ = 2;
					}
					break;
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
		internal static bool CheckConfigurableSorter()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static IdEntity DecorateSeparatedConfig()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_1B00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778933, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00ᰀ()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00ᴀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778932, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00Ḁ()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00ἀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778935, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}
	}

	private static object ReflectAutomatableTemplate;

	public bool HasMore
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00踀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00退(value ? ((byte)1) : ((byte)0));
		}
	}

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00ꄀ();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00蠀(value);
		}
	}

	public List<IdEntity> Ids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00销();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00蔀(value);
		}
	}

	public List<string> Substitutions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00鈀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00鼀(value);
		}
	}

	public List<string> Dummies
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00錀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00ꀀ(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Read(IByteBuffer buffer)
	{
		_FF00_FF00謀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(IByteBuffer buffer)
	{
		_FF00_FF00騀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RegistryData()
	{
		//IL_0052: Expected I4, but got Obj
		//IL_0040->IL0049: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		RegistryData registryData = this;
		if (0 == 0)
		{
			registryData = (RegistryData)0;
		}
		switch ((int)registryData)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckIterableAuditor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RegistryData ReflectIntegratedDecider()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00萀(List<IdEntity> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778917, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00蔀(List<IdEntity> P_0)
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
	internal unsafe void _FF00_FF00蘀(List<IdEntity> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778916, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00蜀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778919, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00蠀(object P_0)
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
	internal unsafe void _FF00_FF00褀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778918, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00言(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778913, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00謀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_007e: Expected I4, but got Obj
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_0086: Expected Obj, but got I4
		//IL_00f4: Expected Obj, but got I4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		//IL_0246: Expected Obj, but got I4
		//IL_00d5->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0145->IL0019: Incompatible stack heights: 5 vs 1
		//IL_0271->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0191->IL0019: Incompatible stack heights: 4 vs 1
		//IL_01d8->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0243->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0217->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0090->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0100->IL0019: Incompatible stack heights: 0 vs 1
		//IL_011b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0205->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0235->IL0019: Incompatible stack heights: 4 vs 1
		//IL_00a0->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0250->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01c4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0222->IL0019: Incompatible stack types: I4 vs Obj
		//IL_010b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ab->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0263->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01a6->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01b1->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 17;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 11:
				obj = 0;
				obj2 = 10;
				break;
			case 17:
				if (16 != 0)
				{
					_ = 15;
				}
				break;
			default:
				obj = P_0;
				obj2 = 11;
				break;
			case 13:
				obj = 0;
				if (3 != 0)
				{
					obj2 = 2;
				}
				break;
			case 14:
				obj++;
				obj2 = 20;
				break;
			case 1:
			case 12:
				_ = 32767;
				_ = 8;
				break;
			case 4:
			case 23:
				_ = 32767;
				_ = 14;
				break;
			case 19:
			case 20:
				if (Unsafe.As<object, UIntPtr>(ref obj) < Unsafe.As<object, UIntPtr>(ref obj))
				{
					if (23 == 0)
					{
						obj2 = 17;
					}
					break;
				}
				goto default;
			case 3:
			case 7:
				if (Unsafe.As<object, UIntPtr>(ref obj) < Unsafe.As<object, UIntPtr>(ref obj))
				{
					obj2 = 12;
					break;
				}
				goto case 6;
			case 5:
			case 21:
				_ = 32767;
				_ = 15;
				break;
			case 9:
				return;
			case 15:
				obj++;
				obj2 = 18;
				break;
			case 8:
				obj++;
				if (4 != 0)
				{
					obj2 = 7;
				}
				break;
			case 16:
				_ = 32767;
				_ = 2;
				break;
			case 6:
				obj = P_0;
				obj2 = 22;
				break;
			case 22:
				obj = 0;
				obj2 = 19;
				break;
			case 10:
			case 18:
				if (Unsafe.As<object, UIntPtr>(ref obj) >= Unsafe.As<object, UIntPtr>(ref obj))
				{
					return;
				}
				obj2 = 21;
				break;
			case 2:
				obj = P_0;
				obj2 = 13;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00谀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778912, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00贀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778915, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00踀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00輀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778914, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00退(byte P_0)
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
	internal unsafe void _FF00_FF00鄀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778941, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<string> _FF00_FF00鈀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (List<string>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<string> _FF00_FF00錀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (List<string>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<string> _FF00_FF00鐀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778940, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (List<string>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<IdEntity> _FF00_FF00销()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (List<IdEntity>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<IdEntity> _FF00_FF00阀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778943, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (List<IdEntity>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00需()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00頀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778942, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00餀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778937, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00騀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_004e: Expected I4, but got Obj
		//IL_00ec: Expected Obj, but got Ref
		//IL_01dd: Expected Obj, but got Ref
		//IL_0306: Expected Obj, but got Ref
		//IL_030f: Expected Obj, but got I4
		//IL_0177->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01a6->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0192->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0166->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0156->IL0019: Incompatible stack types: I4 vs Obj
		//IL_036f->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0182->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0070->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_037a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00dc->IL00ae: Incompatible stack heights: 0 vs 1
		//IL_0227->IL01be: Incompatible stack heights: 1 vs 0
		//IL_01f4->IL01be: Incompatible stack heights: 1 vs 0
		//IL_0285->IL0285: Incompatible stack heights: 1 vs 0
		//IL_0301->IL0285: Incompatible stack heights: 1 vs 0
		//IL_010a->IL00ae: Incompatible stack heights: 3 vs 1
		//IL_020a->IL01be: Incompatible stack heights: 2 vs 0
		//IL_02ba->IL0285: Incompatible stack heights: 2 vs 0
		//IL_02d7->IL0285: Incompatible stack heights: 1 vs 0
		//IL_0215->IL01be: Incompatible stack heights: 2 vs 0
		//IL_02c5->IL0285: Incompatible stack heights: 2 vs 0
		//IL_02e2->IL0285: Incompatible stack heights: 1 vs 0
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 9:
				return;
			case 3:
				obj2 = P_0;
				if (2 == 0)
				{
					obj2 = 2;
				}
				continue;
			case 7:
				obj2 = P_0;
				if (0 == 0)
				{
					obj2 = 1;
				}
				continue;
			case 10:
				obj = this;
				obj2 = 4;
				continue;
			case 8:
				_ = 11;
				continue;
			case 1:
				obj = this;
				if (5 == 0)
				{
					obj2 = 3;
				}
				continue;
			case 6:
				_ = 10;
				continue;
			case 2:
				_ = 32767;
				_ = 7;
				continue;
			case 4:
				while (true)
				{
					IL_0215:
					if (&obj == null)
					{
						_ = 2;
						goto IL_01be;
					}
					goto IL_01d8;
					IL_01be:
					while (true)
					{
						switch ((int)/*Error near IL_01d3: Stack underflow*/)
						{
						case 2:
							break;
						case 3:
							goto IL_01d8;
						default:
							_ = 32767;
							if (true)
							{
								_ = 1;
							}
							continue;
						case 1:
							goto IL_0215;
						}
						break;
					}
					break;
					IL_01d8:
					obj = (object)(&obj);
					if (0 == 0)
					{
						_ = 0;
					}
					goto IL_01be;
				}
				goto case 8;
			case 5:
				while (true)
				{
					IL_02e2:
					if (&obj == null)
					{
						if (1 == 0)
						{
							_ = 1;
						}
						goto IL_0285;
					}
					goto IL_0301;
					IL_0301:
					obj = (object)(&obj);
					obj = 2;
					goto IL_0285;
					IL_0285:
					while (true)
					{
						switch ((int)/*Error near IL_029e: Stack underflow*/)
						{
						case 1:
							break;
						case 2:
							_ = 32767;
							if (4 == 0)
							{
								_ = 4;
							}
							continue;
						case 4:
							if (2 == 0)
							{
								_ = 3;
							}
							continue;
						case 3:
							goto IL_02e2;
						default:
							goto IL_0301;
						}
						break;
					}
					break;
				}
				goto case 6;
			case 11:
				obj = this;
				if (false)
				{
					obj2 = 0;
				}
				continue;
			}
			while (true)
			{
				int num;
				if (&obj == null)
				{
					if (0 == 0)
					{
						num = 0;
					}
					goto IL_00ae;
				}
				goto IL_00e7;
				IL_00e7:
				obj = (object)(&obj);
				num = 3;
				goto IL_00ae;
				IL_00ae:
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 0:
						return;
					case 2:
						break;
					case 1:
						goto IL_00e7;
					case 3:
						_ = 32767;
						_ = 2;
						continue;
					}
					break;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00鬀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778936, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00鰀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778939, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00鴀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00鸀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778938, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00鼀(List<string> P_0)
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
	internal void _FF00_FF00ꀀ(List<string> P_0)
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
	internal object _FF00_FF00ꄀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}
}
