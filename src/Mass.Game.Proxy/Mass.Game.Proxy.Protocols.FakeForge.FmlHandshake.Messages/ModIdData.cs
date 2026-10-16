using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;

namespace Mass.Game.Proxy.Protocols.FakeForge.FmlHandshake.Messages;

public class ModIdData : FmlHandshakeMessage
{
	internal static ModIdData ReflectRemoteFilter;

	public List<RegistryData.IdEntity> Mapping
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00攀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00洀(value);
		}
	}

	public List<string> BlockSubstitutions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00栀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00挀(value);
		}
	}

	public List<string> ItemSubstitutions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00愀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00樀(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Read(IByteBuffer buffer)
	{
		_FF00_FF00琀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(IByteBuffer buffer)
	{
		_FF00_FF00漀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ModIdData()
	{
		//IL_004a: Expected I4, but got Obj
		//IL_0038->IL0041: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		ModIdData modIdData = this;
		if (0 == 0)
		{
			modIdData = (ModIdData)0;
		}
		switch ((int)modIdData)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateActiveStack()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ModIdData DecorateJoinedSubscriber()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<string> _FF00_FF00怀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779356, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (List<string>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<string> _FF00_FF00愀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (List<string>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<string> _FF00_FF00戀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779359, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (List<string>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00挀(List<string> P_0)
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
	internal unsafe void _FF00_FF00搀(List<string> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779358, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<RegistryData.IdEntity> _FF00_FF00攀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (List<RegistryData.IdEntity>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<RegistryData.IdEntity> _FF00_FF00昀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779353, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (List<RegistryData.IdEntity>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<string> _FF00_FF00最()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779352, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (List<string>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<string> _FF00_FF00栀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (List<string>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<string> _FF00_FF00椀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779355, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (List<string>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00樀(List<string> P_0)
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
	internal unsafe void _FF00_FF00欀(List<string> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779354, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00氀(List<RegistryData.IdEntity> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779349, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00洀(List<RegistryData.IdEntity> P_0)
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
	internal unsafe void _FF00_FF00渀(List<RegistryData.IdEntity> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779348, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00漀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0046: Expected I4, but got Obj
		//IL_01c9: Expected Obj, but got Ref
		//IL_00ac: Expected Obj, but got Ref
		//IL_02b2: Expected Obj, but got Ref
		//IL_01ef: Expected Obj, but got I4
		//IL_0130->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0348->IL0019: Incompatible stack types: I4 vs Obj
		//IL_014b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_015c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_013b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0185->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0167->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0365->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0206->IL01a6: Incompatible stack heights: 1 vs 0
		//IL_00d5->IL006c: Incompatible stack heights: 1 vs 0
		//IL_01e0->IL01a6: Incompatible stack heights: 1 vs 0
		//IL_00c3->IL006c: Incompatible stack heights: 1 vs 0
		//IL_02c9->IL0293: Incompatible stack heights: 1 vs 0
		//IL_02e8->IL0293: Incompatible stack heights: 1 vs 0
		//IL_021d->IL01a6: Incompatible stack heights: 2 vs 0
		//IL_009c->IL006c: Incompatible stack heights: 2 vs 0
		//IL_02fc->IL0293: Incompatible stack heights: 3 vs 0
		//IL_0228->IL01a6: Incompatible stack heights: 2 vs 0
		//IL_01a6->IL01a6: Incompatible stack heights: 2 vs 0
		//IL_00a7->IL006c: Incompatible stack heights: 2 vs 0
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 8;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				while (true)
				{
					IL_00c3:
					if (&obj == null)
					{
						_ = 2;
						goto IL_006c;
					}
					goto IL_00a7;
					IL_006c:
					while (true)
					{
						switch ((int)/*Error near IL_0081: Stack underflow*/)
						{
						default:
							_ = 32767;
							if (3 != 0)
							{
								_ = 0;
							}
							continue;
						case 1:
							break;
						case 3:
							goto IL_00c3;
						case 2:
							goto end_IL_00c3;
						}
						break;
					}
					goto IL_00a7;
					IL_00a7:
					obj = (object)(&obj);
					if (false)
					{
						_ = 0;
					}
					goto IL_006c;
					continue;
					end_IL_00c3:
					break;
				}
				goto case 4;
			case 1:
				obj = this;
				if (9 == 0)
				{
					obj2 = 6;
				}
				break;
			case 6:
				_ = 5;
				break;
			case 7:
				obj = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				return;
			case 4:
				obj2 = P_0;
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			default:
				while (true)
				{
					IL_01f4:
					if (&obj == null)
					{
						_ = 4;
						goto IL_01a6;
					}
					goto IL_01c4;
					IL_01a6:
					while (true)
					{
						switch ((int)/*Error near IL_01bf: Stack underflow*/)
						{
						case 4:
							break;
						case 3:
							goto IL_01c4;
						case 1:
							obj = 2;
							continue;
						case 2:
							goto IL_01f4;
						default:
							_ = 32767;
							if (0 == 0)
							{
								_ = 1;
							}
							continue;
						}
						break;
					}
					break;
					IL_01c4:
					obj = (object)(&obj);
					if (0 == 0)
					{
						_ = 0;
					}
					goto IL_01a6;
				}
				goto case 6;
			case 9:
				while (true)
				{
					IL_02c9:
					if (&obj == null)
					{
						if (2 != 0)
						{
							_ = 3;
						}
						goto IL_0293;
					}
					goto IL_02ad;
					IL_02ad:
					obj = (object)(&obj);
					if (1 == 0)
					{
						_ = 1;
					}
					goto IL_0293;
					IL_0293:
					while (true)
					{
						switch ((int)/*Error near IL_02a8: Stack underflow*/)
						{
						case 3:
							return;
						case 2:
							goto IL_02c9;
						case 1:
							_ = 32767;
							_ = 2;
							continue;
						}
						break;
					}
					goto IL_02ad;
				}
			case 5:
				obj = this;
				obj2 = 2;
				break;
			case 8:
				obj2 = P_0;
				if (true)
				{
					obj2 = 7;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00瀀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00焀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779351, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00爀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00猀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779350, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00琀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0072: Expected I4, but got Obj
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		//IL_01a8: Expected Obj, but got I4
		//IL_0188: Expected Obj, but got I4
		//IL_01c2: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got I4
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_00e8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a1->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0211->IL0019: Incompatible stack heights: 3 vs 1
		//IL_022c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01b4->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0192->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00fe->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00cd->IL0019: Incompatible stack heights: 4 vs 1
		//IL_0117->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01ce->IL0019: Incompatible stack heights: 0 vs 1
		//IL_014b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01fb->IL0019: Incompatible stack types: I4 vs Obj
		//IL_021c->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01bf->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0109->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0185->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00d8->IL0019: Incompatible stack heights: 4 vs 1
		//IL_01d9->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0156->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 18;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 4:
					obj = P_0;
					obj2 = 8;
					continue;
				case 12:
				case 15:
					if (Unsafe.As<object, UIntPtr>(ref obj) >= Unsafe.As<object, UIntPtr>(ref obj))
					{
						obj2 = 16;
						continue;
					}
					goto case 13;
				case 13:
					_ = 32767;
					if (6 == 0)
					{
						_ = 6;
					}
					continue;
				case 2:
					obj++;
					obj2 = 11;
					continue;
				case 7:
				case 10:
					_ = 32767;
					if (2 == 0)
					{
						_ = 0;
					}
					continue;
				case 16:
					obj = P_0;
					obj2 = 9;
					continue;
				case 19:
					return;
				case 18:
					break;
				case 20:
					obj++;
					if (false)
					{
						obj2 = 0;
					}
					continue;
				case 1:
				case 11:
					if (Unsafe.As<object, UIntPtr>(ref obj) >= Unsafe.As<object, UIntPtr>(ref obj))
					{
						return;
					}
					obj2 = 7;
					continue;
				case 9:
					obj = 0;
					obj2 = 14;
					continue;
				case 8:
					obj = 0;
					if (1 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 17:
					obj = 0;
					if (12 != 0)
					{
						obj2 = 15;
					}
					continue;
				default:
					if (Unsafe.As<object, UIntPtr>(ref obj) < Unsafe.As<object, UIntPtr>(ref obj))
					{
						obj2 = 3;
						continue;
					}
					goto case 4;
				case 3:
				case 5:
					_ = 32767;
					if (12 != 0)
					{
						_ = 20;
					}
					continue;
				case 6:
					obj++;
					obj2 = 12;
					continue;
				}
				break;
			}
			obj = P_0;
			obj = 17;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00甀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790779345, new IntPtr(2737367943164L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
