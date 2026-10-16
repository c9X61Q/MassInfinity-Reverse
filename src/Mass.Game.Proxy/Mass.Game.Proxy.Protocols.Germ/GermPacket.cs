using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using DotNetty.Buffers;

namespace Mass.Game.Proxy.Protocols.Germ;

public abstract class GermPacket
{
	public abstract void Read(IByteBuffer buffer);

	public abstract void Write(IByteBuffer buffer);

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe GermPacket()
	{
		//IL_001a: Expected VT, but got Obj
		//IL_001a: Expected VT, but got Ref
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((EqualityComparer<_00210>)/*Error near IL_001a: Stack underflow*/).Equals((_00210?)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field), (_00210?)this);
	}
}
