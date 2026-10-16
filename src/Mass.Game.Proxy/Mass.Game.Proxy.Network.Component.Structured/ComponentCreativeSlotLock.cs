using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Game.Proxy.Enums;
using Mass.Game.Proxy.Network.Interface;

namespace Mass.Game.Proxy.Network.Component.Structured;

[Component(EnumProtocolVersion.V1206, 17)]
public class ComponentCreativeSlotLock : IComponent, IBufferCodec, IBufferSerializable, IBufferDeserializable
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe ComponentCreativeSlotLock(EnumProtocolVersion version)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790774785, new IntPtr(2737368322508L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	public void Read(IByteBuffer buffer)
	{
	}

	public void Write(IByteBuffer buffer)
	{
	}
}
