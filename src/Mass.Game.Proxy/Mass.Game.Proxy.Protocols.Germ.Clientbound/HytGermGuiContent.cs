using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Mass.Game.Proxy.Protocols.Germ.Clientbound;

public class HytGermGuiContent : GermGuiContent
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe HytGermGuiContent()
	{
		//IL_001a: Expected VT, but got Obj
		//IL_001a: Expected Obj, but got Ref
		if (((EqualityComparer<_00210>)(object)Regex).Default == null)
		{
		}
		((_003C_003Ef__AnonymousType0<>)Unsafe.AsPointer(ref _003C_003Ef__AnonymousType0<>._003Caction_003Ei__Field))._002Ector((_003Caction_003Ej__TPar)this);
	}
}
