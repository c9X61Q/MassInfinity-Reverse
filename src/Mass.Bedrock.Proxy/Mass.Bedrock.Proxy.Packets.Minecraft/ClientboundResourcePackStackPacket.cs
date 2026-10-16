using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using DotNetty.Buffers;
using Mass.Application.Event;
using Mass.Application.Mobile;
using Mass.Application.Models;
using Mass.Bedrock.Proxy.Minecraft;
using Mass.Bedrock.Proxy.Network;
using Mass.Bedrock.Proxy.Network.Minecraft.Enums;
using Mass.Bedrock.Proxy.Network.Packet;
using Mass.Bedrock.Proxy.Network.RakNet;
using Mass.Bedrock.Proxy.Packets.RakNet.Offline;
using Mass.Bedrock.Proxy.Packets.RakNet.Online;
using Mass.Domain.Desktop.ValueObjects;

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
	public unsafe ClientboundResourcePackStackPacket()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001a: Expected I4, but got Obj
		//IL_004b: Expected I4, but got Obj
		//IL_0065: Expected Obj, but got I4
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		((EntityLaunchBedrockProxy)/*Error near IL_001f: Stack underflow*/).ServerAddress__BackingField = new StringBuilder((char)(int)this);
		EntityLaunchBedrockProxy.ReflectScheduledLogger = (EntityLaunchBedrockProxy)(object)new object();
		((BedrockProxy)/*Error near IL_003b: Stack underflow*/).Name = (string)(object)this;
		((BedrockProxy)/*Error near IL_004b: Stack underflow*/).GameType = (EnumGameType)new EqualityComparer<Type>((Type)(object)this);
		((EntityLaunchBedrockProxy)/*Error near IL_0056: Stack underflow*/).Name = (string)(object)this;
		int num = 0;
		if (((BedrockProxy)BedrockProxy.ServerPort).Session == null)
		{
			num = 0;
		}
		switch (num)
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
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00一()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return EntityLaunchBedrockProxy.Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00伀(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected Obj, but got I4
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
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
				((EntityLaunchBedrockProxy)(object)this).Name__BackingField = P_0;
				obj2 = 0;
				if (((EntityLaunchBedrockProxy)EntityLaunchBedrockProxy.ServerAddress__BackingField).ServerPort__BackingField != 0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00倀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778556, new IntPtr(2737337532524L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<Experiment> _FF00_FF00_FF00_FF00_FF00_FF00儀()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (List<Experiment>)((EntityLaunchBedrockProxy)(object)this).Name__BackingField;
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00吀(List<PackEntry> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
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
				((EntityLaunchBedrockProxy)(object)this).Name__BackingField = P_0;
				obj2 = 0;
				if (((EntityLaunchBedrockProxy)EntityLaunchBedrockProxy.ServerAddress__BackingField).ServerPort__BackingField == 0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00唀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
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
				((EntityLaunchBedrockProxy)(object)this).Name__BackingField = P_0;
				obj2 = 0;
				if (((EntityLaunchBedrockProxy)EntityLaunchBedrockProxy.ServerAddress__BackingField).ServerPort__BackingField == 0)
				{
					obj2 = 0;
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00圀(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0040: Expected Obj, but got I4
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
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
				((EntityLaunchBedrockProxy)(object)this).Name__BackingField = P_0;
				obj2 = 0;
				if (((EntityLaunchBedrockProxy)EntityLaunchBedrockProxy.ServerAddress__BackingField).ServerPort__BackingField != 0)
				{
					obj2 = 0;
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
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00夀()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (EntityLaunchBedrockProxy.Name__BackingField == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00娀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778689, new IntPtr(2737337511724L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00嬀(List<PackEntry> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0054->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005f->IL0026: Incompatible stack types: I4 vs Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
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
				((EntityLaunchBedrockProxy)(object)this).Name__BackingField = P_0;
				obj2 = 0;
				if (((EntityLaunchBedrockProxy)EntityLaunchBedrockProxy.ServerAddress__BackingField).ServerPort__BackingField != 0)
				{
					obj2 = 0;
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
	internal unsafe List<PackEntry> _FF00_FF00_FF00_FF00_FF00_FF00崀()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (List<PackEntry>)((EntityLaunchBedrockProxy)(object)this).Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<PackEntry> _FF00_FF00_FF00_FF00_FF00_FF00帀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778691, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (List<PackEntry>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe List<PackEntry> _FF00_FF00_FF00_FF00_FF00_FF00开()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (List<PackEntry>)((EntityLaunchBedrockProxy)(object)this).Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00怀(byte P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_003f: Expected Obj, but got I4
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
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
				((EntityLaunchBedrockProxy)(object)this).Name__BackingField = P_0;
				obj2 = 0;
				if (((EntityLaunchBedrockProxy)EntityLaunchBedrockProxy.ServerAddress__BackingField).ServerPort__BackingField != 0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00愀(object P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0093: Expected I4, but got Obj
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected Obj, but got Unknown
		//IL_01c5: Expected Obj, but got I4
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_0167: Expected Obj, but got I4
		//IL_0170: Expected Obj, but got I4
		//IL_02f0: Expected I4, but got Obj
		//IL_0302: Expected Obj, but got I4
		//IL_0311: Expected Obj, but got I8
		//IL_00e1: Expected Obj, but got I4
		//IL_00ea: Expected Obj, but got I4
		//IL_0150: Expected I4, but got Obj
		//IL_0155: Expected Obj, but got I4
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected Obj, but got Unknown
		//IL_02df: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I
		//IL_01fc: Expected Obj, but got I8
		//IL_0109: Expected Obj, but got I4
		//IL_0279->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01cf->IL0026: Incompatible stack types: I4 vs Obj
		//IL_013e->IL0026: Incompatible stack heights: 2 vs 1
		//IL_02d1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02ff->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0316->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ef->IL0022: Incompatible stack heights: 1 vs 0
		//IL_015f->IL0026: Incompatible stack heights: 2 vs 1
		//IL_0331->IL0026: Incompatible stack types: I4 vs Obj
		//IL_02e9->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c5->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0201->IL0026: Incompatible stack types: I4 vs Obj
		//IL_025f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00ae->IL0026: Incompatible stack heights: 3 vs 1
		//IL_01e1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_010e->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0284->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0149->IL0026: Incompatible stack heights: 2 vs 1
		//IL_02dc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0321->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00d0->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0239->IL0026: Incompatible stack types: I4 vs Obj
		//IL_020c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_018a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0119->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0244->IL0026: Incompatible stack types: I4 vs Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
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
					_ = ((EntityLaunchBedrockProxy)(object)((EntityLaunchBedrockProxy)P_0).EqualityContract).Session;
					_ = 3;
					continue;
				case 17:
					obj = 0;
					obj2 = 0;
					if ((object)EntityLaunchBedrockProxy.ReflectScheduledLogger == null)
					{
						obj2 = 1;
					}
					continue;
				case 11:
				case 16:
					((EntityLaunchBedrockProxy)/*Error near IL_00d6: Stack underflow*/).GameId = (string)(object)this;
					((EqualityComparer<Type>)/*Error near IL_00e1: Stack underflow*/).GetHashCode((Type)((EntityLaunchBedrockProxy)P_0).GameType);
					obj = 2;
					break;
				default:
					if ((long)obj < (long)(ulong)obj)
					{
						obj2 = 7;
						if (((BedrockProxy)BedrockProxy.GameType).ServerAddress == null)
						{
							obj2 = 8;
						}
						continue;
					}
					goto case 21;
				case 4:
				case 25:
					((EntityLaunchBedrockProxy)(object)((EntityLaunchBedrockProxy)(object)this).ServerAddress).ServerAddress = (string)P_0;
					_ = EqualityComparer<EnumGameType>.Default;
					_ = 14;
					if (((BedrockProxy)BedrockProxy.Listener__BackingField).EndPoints__BackingField != null)
					{
						_ = 0;
					}
					continue;
				case 13:
					_ = (EntityLaunchBedrockProxy?)/*Error near IL_0155: Stack underflow*/ != (EntityLaunchBedrockProxy?)((EqualityComparer<int>)(object)this).GetHashCode((int)P_0);
					_ = 9;
					continue;
				case 6:
					obj = (EntityLaunchBedrockProxy?)/*Error near IL_0165: Stack underflow*/ == (EntityLaunchBedrockProxy?)P_0;
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
					obj = (Type?)/*Error near IL_01c3: Stack underflow*/ == (Type?)P_0;
					obj2 = 17;
					continue;
				case 23:
					obj = ((EntityLaunchBedrockProxy)P_0)._003CClone_003E_0024();
					obj2 = 10;
					continue;
				case 19:
					((GameInstance)P_0)._002Ector();
					((EntityLaunchBedrockProxy)/*Error near IL_01ed: Stack underflow*/).Deconstruct(out *(MobileSession*)/*Error near IL_01ed: Stack underflow*/, out *(string*)/*Error near IL_01ed: Stack underflow*/, out *(EnumGameType*)/*Error near IL_01ed: Stack underflow*/, out *(string*)/*Error near IL_01ed: Stack underflow*/, out *(string*)/*Error near IL_01ed: Stack underflow*/, out *(int*)this);
					obj2 = 2;
					if (((ConnectionRequest)ConnectionRequest.Time__BackingField).UseEncryption__BackingField == 0)
					{
						obj2 = 13;
					}
					continue;
				case 9:
					return;
				case 1:
				case 18:
					if (Unsafe.As<object, UIntPtr>(ref obj) < Unsafe.As<object, UIntPtr>(ref obj))
					{
						obj2 = 4;
						if (((ConnectionRequestAccepted)(object)ConnectionRequest.CheckHiddenCollector).ClientAddress__BackingField == null)
						{
							obj2 = 16;
						}
						continue;
					}
					goto case 19;
				case 8:
				case 20:
					((BedrockProxy)(object)((BedrockProxy)(object)this).Listener).Listener = (RakNetServer?)P_0;
					((Func<IPAddress, IPEndPoint>)/*Error near IL_0255: Stack underflow*/)._002Ector((object)/*Error near IL_0255: Stack underflow*/, (nint)/*Error near IL_0255: Stack underflow*/);
					obj2 = 5;
					continue;
				case 2:
					obj++;
					obj2 = 18;
					if (((FrameSetPacket)ConnectionRequestAccepted.DecorateRandomExtractor).SequenceNumber__BackingField != 0)
					{
						obj2 = 13;
					}
					continue;
				case 5:
					obj++;
					obj2 = 0;
					if (GamePacket.ReflectPortableExplorer == null)
					{
						obj2 = 0;
					}
					continue;
				case 15:
					obj = 0;
					obj2 = 22;
					continue;
				case 7:
					((EventBus)/*Error near IL_02f0: Stack underflow*/).Register<T>((Action<T>)(object)this, (int)P_0);
					((BedrockProxy)/*Error near IL_02f5: Stack underflow*/).OnConnected((object)/*Error near IL_02f5: Stack underflow*/);
					obj2 = 6;
					continue;
				case 10:
					obj = 0;
					obj2 = 12;
					if (NewIncomingConnection.FormatSharer == null)
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
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00挀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected I4, but got Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (byte)(int)((EntityLaunchBedrockProxy)(object)this).Name__BackingField;
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
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00昀()
	{
		//IL_0011: Expected Obj, but got Ref
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return ((EntityLaunchBedrockProxy)(object)this).Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00最()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778695, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00栀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected I4, but got Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (byte)(int)((EntityLaunchBedrockProxy)(object)this).Name__BackingField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00椀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778696, new IntPtr(2737337509644L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00樀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001b: Expected I4, but got Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		return (byte)(int)((EntityLaunchBedrockProxy)(object)this).Name__BackingField;
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
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0063: Expected I4, but got Obj
		//IL_036f: Expected I8, but got Obj
		//IL_0379: Expected I8, but got Obj
		//IL_0388: Expected Obj, but got I
		//IL_024d: Expected I4, but got Obj
		//IL_0262: Expected Obj, but got I8
		//IL_0227: Expected Obj, but got I4
		//IL_00b1: Expected I4, but got Obj
		//IL_013c: Expected Obj, but got Ref
		//IL_013e: Expected Obj, but got I4
		//IL_014d: Expected Obj, but got I
		//IL_02be: Expected Obj, but got I4
		//IL_0422: Expected Obj, but got Ref
		//IL_03f9: Expected Obj, but got I
		//IL_038d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0267->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01f3->IL0026: Incompatible stack types: I4 vs Obj
		//IL_03af->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00dc->IL0026: Incompatible stack types: I4 vs Obj
		//IL_009f->IL0026: Incompatible stack types: I4 vs Obj
		//IL_023b->IL0026: Incompatible stack types: I4 vs Obj
		//IL_007e->IL0026: Incompatible stack heights: 3 vs 1
		//IL_00c1->IL0026: Incompatible stack types: I4 vs Obj
		//IL_021a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0398->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0272->IL0026: Incompatible stack types: I4 vs Obj
		//IL_01fe->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00aa->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0246->IL0026: Incompatible stack types: I4 vs Obj
		//IL_012a->IL00f0: Incompatible stack heights: 2 vs 1
		//IL_0105->IL0135: Incompatible stack heights: 0 vs 1
		//IL_0135->IL00f0: Incompatible stack heights: 2 vs 1
		//IL_016f->IL00f0: Incompatible stack heights: 3 vs 1
		//IL_02da->IL029b: Incompatible stack heights: 4 vs 1
		//IL_041b->IL03c4: Incompatible stack heights: 3 vs 1
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
		{
		}
		object obj = 8;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 10:
				_ = ((EntityLaunchBedrockProxy)(object)((EntityLaunchBedrockProxy)(object)this).EqualityContract).Session;
				_ = 12;
				break;
			case 8:
				((EntityLaunchBedrockProxy)P_0).Session = (MobileSession)(object)this;
				((StringBuilder)/*Error near IL_008a: Stack underflow*/).Append((object?)/*Error near IL_008a: Stack underflow*/);
				obj2 = 3;
				if (((BedrockProxy)BedrockProxy.Logger__BackingField).Name != null)
				{
					obj2 = 7;
				}
				break;
			case 11:
				((EntityLaunchBedrockProxy)P_0).GameType = (EnumGameType)this;
				_ = EqualityComparer<MobileSession>.Default;
				obj2 = 13;
				break;
			case 7:
				((EntityLaunchBedrockProxy)P_0).Name = (string)(object)this;
				((EntityLaunchBedrockProxy)/*Error near IL_00d2: Stack underflow*/).ServerAddress = (string)(object)EqualityComparer<string>.Default;
				obj2 = 2;
				break;
			case 3:
				while (true)
				{
					if (EqualityComparer<EnumGameType>.Default == null)
					{
						_ = 0;
						if (((BedrockProxy)BedrockProxy.Listener__BackingField).EndPoints__BackingField == null)
						{
							_ = 0;
						}
						goto IL_00f0;
					}
					goto IL_0135;
					IL_0135:
					obj = ((EqualityComparer<int>)(&obj)).GetHashCode((int)(&obj));
					int num3 = 0;
					if (BedrockProxy.CloneProxy == null)
					{
						num3 = 1;
					}
					goto IL_00f0;
					IL_00f0:
					while (true)
					{
						switch (num3)
						{
						case 2:
							break;
						case 3:
							goto IL_0135;
						case 1:
							((EntityLaunchBedrockProxy)obj).GetHashCode();
							_ = 2;
							continue;
						default:
							goto end_IL_010a;
						}
						break;
					}
					continue;
					end_IL_010a:
					break;
				}
				goto default;
			case 2:
				obj = (string?)/*Error near IL_01dd: Stack underflow*/ + (string?)(object)this + (string?)(object)EntityLaunchBedrockProxy.ReflectAutomatedAttribute();
				obj2 = 3;
				if (((ConnectionRequestAccepted)ConnectionRequestAccepted.ClientAddress__BackingField).SystemIndex__BackingField == 0)
				{
					obj2 = 3;
				}
				break;
			case 12:
				((BedrockProxy)P_0).Listener = (RakNetServer?)(object)this;
				((Func<IPAddress, IPEndPoint>)/*Error near IL_020a: Stack underflow*/)._002Ector((object)/*Error near IL_020a: Stack underflow*/, (nint)/*Error near IL_020a: Stack underflow*/);
				Enumerable.Select<TSource, TResult>((IEnumerable<TSource>)/*Error near IL_020f: Stack underflow*/, (Func<TSource, TResult>)/*Error near IL_020f: Stack underflow*/);
				obj2 = 4;
				break;
			case 9:
				obj = IPAddress.TryParse((string?)/*Error near IL_0225: Stack underflow*/, out *(IPAddress?*)((BedrockProxy)(object)this).EndPointIndex);
				obj2 = 4;
				if (((GamePacket)FrameSetPacket.PlaySpec).Data__BackingField != null)
				{
					obj2 = 6;
				}
				break;
			case 1:
				((BedrockProxy)P_0).StartListen((int)this);
				((EventBus)/*Error near IL_0252: Stack underflow*/).Register<T>((Action<T>)/*Error near IL_0252: Stack underflow*/, (int)/*Error near IL_0252: Stack underflow*/);
				obj2 = 11;
				if (((NewIncomingConnection)NewIncomingConnection.RequestTimestamp__BackingField).AcceptedTimestamp__BackingField == 0L)
				{
					obj2 = 1;
				}
				break;
			case 5:
				while (true)
				{
					IL_02da:
					int num2;
					if (((IByteBuffer*)(&obj))->ReadUnsignedShort() == 0)
					{
						num2 = 1;
						if (((OpenConnectionReply1)(object)IncompatibleProtocolVersion.CheckGroupedListener).Guid__BackingField == 0L)
						{
							num2 = 1;
						}
						goto IL_029b;
					}
					goto IL_02b5;
					IL_02b5:
					obj = ((IByteBuffer*)(&obj))->ReadBoolean();
					num2 = 3;
					goto IL_029b;
					IL_029b:
					while (true)
					{
						switch (num2)
						{
						case 1:
							break;
						default:
							goto IL_02b5;
						case 3:
							BedrockProxy.DecorateExternalMatcher();
							_ = 2;
							continue;
						case 2:
							goto IL_02da;
						}
						break;
					}
					break;
				}
				goto case 1;
			default:
				((ConnectedPong)P_0).ClientTimestamp = (long)this;
				((ConnectedPong)/*Error near IL_0379: Stack underflow*/).ServerTimestamp = (long)((IByteBuffer)/*Error near IL_0374: Stack underflow*/).WriteBytes((byte[])/*Error near IL_0374: Stack underflow*/);
				obj2 = 9;
				if (((OpenConnectionRequest1)OpenConnectionRequest1.ProtocolVersion__BackingField).MtuSize__BackingField != 0)
				{
					obj2 = 5;
				}
				break;
			case 4:
				((ConnectedPong)(object)this)._002Ector();
				obj = ((IByteBuffer)/*Error near IL_03a3: Stack underflow*/).WriteInt((int)/*Error near IL_03a3: Stack underflow*/);
				obj2 = 5;
				break;
			case 13:
				return;
			case 6:
				while (true)
				{
					IL_03de:
					int num;
					if (((IByteBuffer*)(&obj))->ReaderIndex == 0)
					{
						num = 0;
						if (((OpenConnectionRequest2)OpenConnectionRequest2.UseSecurity__BackingField).Address__BackingField == null)
						{
							num = 0;
						}
						goto IL_03c4;
					}
					goto IL_041b;
					IL_041b:
					obj = Jwt.Resign((ECDsa)/*Error near IL_0422: Stack underflow*/, (string)(&obj));
					num = 0;
					if (((UnconnectedPing)OpenConnectionRequest2.DecorateVisualSingleton).Time__BackingField != 0L)
					{
						num = 1;
					}
					goto IL_03c4;
					IL_03c4:
					while (true)
					{
						switch (num)
						{
						case 3:
							goto IL_03de;
						case 1:
							_ = ((ConnectionRequest)obj).Time;
							_ = 3;
							continue;
						case 2:
							goto IL_041b;
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00漀(List<Experiment> P_0)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_0053->IL0026: Incompatible stack types: I4 vs Obj
		//IL_005e->IL0026: Incompatible stack types: I4 vs Obj
		if (((StringBuilder)(object)(*(GameInstance*)/*Error near IL_0011: Stack underflow*/)/*cast due to constrained. prefix*/).Append((string?)Unsafe.AsPointer(ref EntityLaunchBedrockProxy.Session__BackingField)) == null)
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
				((EntityLaunchBedrockProxy)(object)this).Name__BackingField = P_0;
				obj2 = 0;
				if (((EntityLaunchBedrockProxy)EntityLaunchBedrockProxy.ServerAddress__BackingField).ServerPort__BackingField != 0)
				{
					obj2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}
}
