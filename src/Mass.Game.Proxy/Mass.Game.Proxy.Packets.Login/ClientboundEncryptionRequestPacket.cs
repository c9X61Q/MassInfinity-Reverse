using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Minecraft;
using Mass.Game.Proxy.Network.Interface;
using Mass.Game.Proxy.Network.Packet;

namespace Mass.Game.Proxy.Packets.Login;

[Packet(EnumConnectionState.Login, EnumPacketDirection.Clientbound)]
[PacketAllVersion(1)]
public class ClientboundEncryptionRequestPacket : IPacket, IBufferCodec, IBufferSerializable, IBufferDeserializable
{
	private static object AssessStruct;

	public string ServerId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (string)_FF00_FF00_FF00_FF00_FF00_FF00_FF00_2E00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00_2500(value);
		}
	}

	public byte[] PublicKey
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (byte[])_FF00_FF00_FF00_FF00_FF00_FF00_FF00_2A00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00ἀ(value);
		}
	}

	public byte[] VerifyToken
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (byte[])_FF00_FF00_FF00_FF00_FF00_FF00_FF00_1400();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00Ⰰ(value);
		}
	}

	public bool ShouldAuthenticate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᄀ() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			_FF00_FF00_FF00_FF00_FF00_FF00_FF00_2100(value ? ((byte)1) : ((byte)0));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClientboundEncryptionRequestPacket(EnumProtocolVersion version)
	{
		//IL_0052: Expected I4, but got Obj
		//IL_0040->IL0049: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		ClientboundEncryptionRequestPacket clientboundEncryptionRequestPacket = this;
		if (0 == 0)
		{
			clientboundEncryptionRequestPacket = (ClientboundEncryptionRequestPacket)0;
		}
		switch ((int)clientboundEncryptionRequestPacket)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Read(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00_2200(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(IByteBuffer buffer)
	{
		_FF00_FF00_FF00_FF00_FF00_FF00_FF00_1B00(buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Handle(Connection connection)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᤀ(connection) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateSortedEmitter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ClientboundEncryptionRequestPacket PauseChain()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00က()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778136, new IntPtr(2737368314188L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᄀ()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00ሀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778139, new IntPtr(2737368312108L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ጀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778138, new IntPtr(2737368316268L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_1400()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᔀ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778133, new IntPtr(2737368328748L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_1800(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778132, new IntPtr(2737368314188L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᤀ(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0042: Expected I4, but got Obj
		//IL_038e: Expected Obj, but got I4
		//IL_0396: Expected I4, but got Obj
		//IL_0066: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I4
		//IL_02c7: Expected Obj, but got I4
		//IL_02d0: Expected Obj, but got I4
		//IL_02aa: Expected Obj, but got I4
		//IL_014c: Expected Obj, but got I4
		//IL_01af: Expected Obj, but got I4
		//IL_01b9: Expected Obj, but got I4
		//IL_037f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0393->IL0015: Incompatible stack heights: 2 vs 0
		//IL_03c1->IL0019: Incompatible stack heights: 0 vs 1
		//IL_007e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_03a5->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0056->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0070->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03cc->IL0019: Incompatible stack types: I4 vs Obj
		//IL_03b0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0061->IL0019: Incompatible stack types: I4 vs Obj
		//IL_026f->IL0094: Incompatible stack heights: 10 vs 1
		//IL_0102->IL0094: Incompatible stack heights: 0 vs 1
		//IL_029c->IL0094: Incompatible stack heights: 0 vs 1
		//IL_012b->IL0094: Incompatible stack heights: 5 vs 1
		//IL_0222->IL0094: Incompatible stack heights: 4 vs 1
		//IL_0177->IL0094: Incompatible stack heights: 5 vs 1
		//IL_02d5->IL0090: Incompatible stack heights: 0 vs 2
		//IL_01e7->IL0094: Incompatible stack heights: 5 vs 1
		//IL_0158->IL0094: Incompatible stack heights: 0 vs 1
		//IL_01c3->IL0094: Incompatible stack heights: 9 vs 1
		//IL_0136->IL0094: Incompatible stack heights: 5 vs 1
		//IL_0094->IL0094: Incompatible stack heights: 3 vs 1
		//IL_022d->IL0094: Incompatible stack heights: 4 vs 1
		//IL_01ff->IL0094: Incompatible stack heights: 0 vs 1
		//IL_0302->IL0094: Incompatible stack heights: 2 vs 1
		//IL_030d->IL0094: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 7:
					obj = (object)/*Error near IL_004a: Stack underflow*/;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 8:
					obj = 20;
					obj2 = 6;
					continue;
				case 4:
					_ = 7;
					continue;
				case 6:
				{
					obj = this;
					int num = 12;
					while (true)
					{
						switch (num)
						{
						case 2:
							obj = this;
							if (6 != 0)
							{
								num = 8;
							}
							continue;
						case 4:
							_ = 0;
							if (false)
							{
								_ = 11;
							}
							continue;
						case 5:
							_ = 0;
							obj = 20;
							continue;
						case 17:
							obj = 1;
							if (false)
							{
								num = 0;
							}
							continue;
						case 8:
							_ = 0;
							_ = ((Array)obj).Length;
							_ = 5;
							continue;
						case 18:
							if (obj != null)
							{
								num = 13;
								continue;
							}
							goto case 14;
						case 20:
							obj = obj;
							num = 6;
							continue;
						case 19:
							/*Error near IL_019c: Stack underflow*/;
							_ = 1;
							_ = 0;
							obj = ((Array)obj).Length;
							_ = 0;
							obj = ((Array)(object)this).Length;
							_ = 4;
							continue;
						case 16:
							num = 18;
							continue;
						case 12:
							_ = 0;
							_ = ((Array)obj).Length;
							_ = 7;
							continue;
						case 14:
							if (obj != null)
							{
								if (15 == 0)
								{
									num = 14;
								}
								continue;
							}
							goto case 19;
						case 7:
							_ = 0;
							_ = ((Array)obj).Length;
							if (2 == 0)
							{
								_ = 2;
							}
							continue;
						case 1:
							_ = 16;
							continue;
						case 3:
							obj = obj;
							if (1 == 0)
							{
								num = 0;
							}
							continue;
						case 15:
							obj = 1;
							num = 10;
							continue;
						case 6:
							obj = obj;
							num = 3;
							continue;
						case 11:
							obj = 1;
							obj = 9;
							continue;
						case 13:
							if (17 == 0)
							{
								_ = 6;
							}
							continue;
						}
						break;
					}
					goto case 2;
				}
				default:
					_ = 128;
					_ = 3;
					continue;
				case 1:
					break;
				case 2:
					return (byte)(int)obj;
				case 5:
					obj = (object)/*Error near IL_0399: Stack underflow*/;
					if (3 != 0)
					{
						obj2 = 4;
					}
					continue;
				case 3:
					obj = this;
					if (1 == 0)
					{
						obj2 = 1;
					}
					continue;
				}
				break;
			}
			obj = 8;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᨀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778135, new IntPtr(2737368328748L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_1B00(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_004f: Expected Obj, but got I4
		//IL_0063->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0054->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0078->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00ae->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0096->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b9->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 6;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					return;
				case 5:
					break;
				case 1:
					_ = 4;
					continue;
				case 0:
					return;
				case 4:
					return;
				case 6:
					_ = 32767;
					_ = 5;
					continue;
				case 3:
					if (true)
					{
						_ = 2;
					}
					continue;
				case 2:
					if ((nint)this < 766)
					{
						if (false)
						{
							obj2 = 0;
						}
						continue;
					}
					goto case 1;
				}
				break;
			}
			obj = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᰀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778134, new IntPtr(2737368331868L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00ᴀ()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ḁ()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778129, new IntPtr(2737368306908L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ἀ(object P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2000(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778128, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2100(byte P_0)
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
	internal sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2200(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_00c0: Expected Obj, but got I4
		//IL_00c5->IL0015: Incompatible stack heights: 2 vs 0
		//IL_008b->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0051->IL0019: Incompatible stack heights: 3 vs 1
		//IL_006e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0096->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00db->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005c->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0079->IL0019: Incompatible stack heights: 3 vs 1
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
				case 3:
					if (1 == 0)
					{
						_ = 1;
					}
					continue;
				case 4:
					_ = 20;
					if (false)
					{
						_ = 3;
					}
					continue;
				case 1:
					if (2 == 0)
					{
						_ = 1;
					}
					continue;
				case 5:
					return;
				case 6:
					return;
				case 2:
					if ((nint)this < 766)
					{
						obj2 = 5;
						continue;
					}
					break;
				}
				break;
			}
			obj = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2300(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778131, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2400(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778130, new IntPtr(2737368301708L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2500(object P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2600(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778221, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2700()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778220, new IntPtr(2737368332908L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2800()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2900()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778223, new IntPtr(2737368312108L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2A00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2B00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778222, new IntPtr(2737368321468L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_FF00_FF00_FF00_FF00_FF00Ⰰ(object P_0)
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
	internal unsafe void _FF00_FF00_FF00_FF00_FF00_FF00_FF00ⴀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778217, new IntPtr(2737368320428L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2E00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_FF00_FF00_FF00_FF00_FF00_2F00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778216, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}
}
