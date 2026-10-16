using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Bedrock.Proxy.Minecraft;
using Mass.Bedrock.Proxy.Network;
using Mass.Bedrock.Proxy.Network.Minecraft.Enums;
using Mass.Bedrock.Proxy.Network.Packet;

namespace Mass.Bedrock.Proxy.Packets.Minecraft;

[Packet(EnumPacketDirection.Clientbound, 7u)]
public class ClientboundResourcePackStackPacket : PacketBase
{
	private static object DecorateExternalReg;

	public bool MustAccept
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00挀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00怀(value ? ((byte)1) : ((byte)0));
		}
	}

	public List<PackEntry> ResourcePacks
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00崀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00吀(value);
		}
	}

	public List<PackEntry> BehaviorPacks
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00开();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00嬀(value);
		}
	}

	public string GameVersion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00昀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00唀(value);
		}
	}

	public List<Experiment> Experiments
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00儀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00漀(value);
		}
	}

	public bool ExperimentsPreviouslyUsed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00栀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00伀(value ? ((byte)1) : ((byte)0));
		}
	}

	public bool HasEditorPacks
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00樀() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00圀(value ? ((byte)1) : ((byte)0));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Read(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00愀(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00洀(buffer);
	}

	public override bool Handle(Connection connection)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClientboundResourcePackStackPacket()
	{
		//IL_0052: Expected I4, but got Obj
		//IL_0040->IL0049: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		ClientboundResourcePackStackPacket clientboundResourcePackStackPacket = this;
		if (0 == 0)
		{
			clientboundResourcePackStackPacket = (ClientboundResourcePackStackPacket)0;
		}
		switch ((int)clientboundResourcePackStackPacket)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateOperationalExecutor()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ClientboundResourcePackStackPacket TestGateway()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00䴀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778555, new IntPtr(2737337524204L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00一()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00伀(byte P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00倀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778556, new IntPtr(2737337532524L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<Experiment> _FF00_FF00_FF00_FF00_FF00_FF00儀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (List<Experiment>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<Experiment> _FF00_FF00_FF00_FF00_FF00_FF00刀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778557, new IntPtr(2737337525244L), 15))(null, 0, new IntPtr(0L));
		return (List<Experiment>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00匀(List<PackEntry> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778558, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00吀(List<PackEntry> P_0)
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00唀(object P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00嘀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778559, new IntPtr(2737337524204L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00圀(byte P_0)
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
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00堀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778688, new IntPtr(2737337532524L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00夀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00娀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778689, new IntPtr(2737337511724L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00嬀(List<PackEntry> P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00尀(List<PackEntry> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778690, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<PackEntry> _FF00_FF00_FF00_FF00_FF00_FF00崀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (List<PackEntry>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<PackEntry> _FF00_FF00_FF00_FF00_FF00_FF00帀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778691, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (List<PackEntry>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<PackEntry> _FF00_FF00_FF00_FF00_FF00_FF00开()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (List<PackEntry>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00怀(byte P_0)
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
	internal void _FF00_FF00_FF00_FF00_FF00_FF00愀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0086: Expected I4, but got Obj
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected Obj, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected Obj, but got Unknown
		//IL_011f: Expected Obj, but got I4
		//IL_025d: Expected Obj, but got I4
		//IL_00c1: Expected Obj, but got I4
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_0242: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I4
		//IL_01ec->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0172->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00f9->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0234->IL0019: Incompatible stack heights: 0 vs 1
		//IL_025a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0269->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00c6->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0112->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0284->IL0019: Incompatible stack types: I4 vs Obj
		//IL_024c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a8->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0190->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01da->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0099->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0180->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00dd->IL0019: Incompatible stack heights: 0 vs 1
		//IL_01f7->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0104->IL0019: Incompatible stack heights: 2 vs 1
		//IL_023f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0274->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b3->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01c0->IL0019: Incompatible stack heights: 0 vs 1
		//IL_019b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0139->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00e8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01cb->IL0019: Incompatible stack types: I4 vs Obj
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
				case 21:
					_ = 3;
					continue;
				case 17:
					obj = 0;
					if (0 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 11:
				case 16:
					obj = 2;
					break;
				default:
					if ((long)obj < (long)(ulong)obj)
					{
						if (7 == 0)
						{
							obj2 = 8;
						}
						continue;
					}
					goto case 21;
				case 4:
				case 25:
					if (14 != 0)
					{
						_ = 0;
					}
					continue;
				case 13:
					_ = 9;
					continue;
				case 6:
					obj = P_0;
					obj = 15;
					break;
				case 22:
				case 24:
					if ((long)obj < (long)(ulong)obj)
					{
						obj2 = 25;
						continue;
					}
					goto case 23;
				case 3:
					obj = P_0;
					obj2 = 17;
					continue;
				case 23:
					obj = P_0;
					obj2 = 10;
					continue;
				case 19:
					if (2 == 0)
					{
						_ = 13;
					}
					continue;
				case 9:
					return;
				case 1:
				case 18:
					if (Unsafe.As<object, UIntPtr>(ref obj) < Unsafe.As<object, UIntPtr>(ref obj))
					{
						if (4 == 0)
						{
							obj2 = 16;
						}
						continue;
					}
					goto case 19;
				case 8:
				case 20:
					_ = 5;
					continue;
				case 2:
					obj++;
					if (18 != 0)
					{
						obj2 = 13;
					}
					continue;
				case 5:
					obj++;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 15:
					obj = 0;
					obj2 = 22;
					continue;
				case 7:
					_ = 6;
					continue;
				case 10:
					obj = 0;
					if (12 == 0)
					{
						obj2 = 2;
					}
					continue;
				case 14:
					obj++;
					obj2 = 24;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00戀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778692, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00挀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00搀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778693, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00攀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778694, new IntPtr(2737337523164L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00昀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00最()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778695, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00栀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00椀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778696, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00樀()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00欀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778697, new IntPtr(2737337520044L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00氀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778698, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00洀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0056: Expected I4, but got Obj
		//IL_00f5: Expected Obj, but got Ref
		//IL_0208: Expected Obj, but got Ref
		//IL_0315: Expected Obj, but got Ref
		//IL_029a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0175->IL0019: Incompatible stack heights: 0 vs 1
		//IL_02b4->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00a3->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01a1->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0069->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0094->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0190->IL0019: Incompatible stack heights: 2 vs 1
		//IL_02a5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01c8->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0180->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0085->IL0019: Incompatible stack types: I4 vs Obj
		//IL_01ac->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0234->IL01e9: Incompatible stack heights: 0 vs 1
		//IL_010c->IL00b7: Incompatible stack heights: 1 vs 0
		//IL_00f0->IL00b7: Incompatible stack heights: 1 vs 0
		//IL_032c->IL02c9: Incompatible stack heights: 1 vs 0
		//IL_0302->IL02c9: Incompatible stack heights: 1 vs 0
		//IL_011a->IL00b7: Incompatible stack heights: 3 vs 0
		//IL_0220->IL01e9: Incompatible stack heights: 3 vs 1
		//IL_0310->IL02c9: Incompatible stack heights: 3 vs 0
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 8;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 10:
				_ = 12;
				break;
			case 8:
				obj2 = P_0;
				if (3 != 0)
				{
					obj2 = 7;
				}
				break;
			case 11:
				_ = 13;
				break;
			case 7:
				_ = 2;
				break;
			case 3:
				while (true)
				{
					if (&obj == null)
					{
						if (0 == 0)
						{
							_ = 0;
						}
						goto IL_00b7;
					}
					goto IL_00f0;
					IL_00f0:
					obj = (object)(&obj);
					if (0 == 0)
					{
						_ = 1;
					}
					goto IL_00b7;
					IL_00b7:
					while (true)
					{
						switch ((int)/*Error near IL_00cc: Stack underflow*/)
						{
						case 2:
							break;
						case 3:
							goto IL_00f0;
						case 1:
							_ = 2;
							continue;
						default:
							goto end_IL_00d1;
						}
						break;
					}
					continue;
					end_IL_00d1:
					break;
				}
				goto default;
			case 2:
				obj = this;
				if (3 == 0)
				{
					obj2 = 3;
				}
				break;
			case 12:
				_ = 4;
				break;
			case 9:
				obj = this;
				if (4 != 0)
				{
					obj2 = 6;
				}
				break;
			case 1:
				obj2 = P_0;
				if (11 == 0)
				{
					obj2 = 1;
				}
				break;
			case 5:
				while (true)
				{
					IL_0220:
					int num;
					if (&obj == null)
					{
						if (1 == 0)
						{
							num = 1;
						}
						goto IL_01e9;
					}
					goto IL_0203;
					IL_0203:
					obj = (object)(&obj);
					num = 3;
					goto IL_01e9;
					IL_01e9:
					while (true)
					{
						switch (num)
						{
						case 1:
							break;
						default:
							goto IL_0203;
						case 3:
							_ = 2;
							continue;
						case 2:
							goto IL_0220;
						}
						break;
					}
					break;
				}
				goto case 1;
			default:
				if (9 != 0)
				{
					_ = 5;
				}
				break;
			case 4:
				obj = this;
				obj2 = 5;
				break;
			case 13:
				return;
			case 6:
				while (true)
				{
					IL_02e3:
					if (&obj == null)
					{
						if (0 == 0)
						{
							_ = 0;
						}
						goto IL_02c9;
					}
					goto IL_0310;
					IL_0310:
					obj = (object)(&obj);
					if (false)
					{
						_ = 1;
					}
					goto IL_02c9;
					IL_02c9:
					while (true)
					{
						switch ((int)/*Error near IL_02de: Stack underflow*/)
						{
						case 3:
							goto IL_02e3;
						case 1:
							_ = 3;
							continue;
						case 2:
							goto IL_0310;
						}
						break;
					}
					break;
				}
				goto case 10;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00渀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778699, new IntPtr(2737337516924L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00漀(List<Experiment> P_0)
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
}
