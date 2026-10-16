using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using WinRT;

namespace Mass.WinUI.Models;

public sealed class CustomTopUpModel
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe CustomTopUpModel()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		ExceptionHelpers.GetHRForException((Exception)(object)this);
	}
}
