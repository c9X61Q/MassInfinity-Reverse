using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Mass.WinUI.Helpers;

public static class ObservableHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateObservableCollection<T>(IList<T> collection, List<T> newItems)
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}
}
