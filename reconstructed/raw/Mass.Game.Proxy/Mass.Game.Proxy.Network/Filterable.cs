using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Mass.Game.Proxy.Network;

public class Filterable<T>
{
	public readonly T Value;

	public readonly Optional<T> Optional;

	// 说明：原始构造函数体经 ILSpy 反编译后为无效表达式（DNGuard 保护 + 反编译残留），
	// 字段声明本身是真实的，此处保留字段、以占位体替代。
	// 见 docs/可编译性-缺口台账.md
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Filterable(T value, Optional<T> optional)
	{
		throw new NotImplementedException("Filterable<T> 的构造函数体未还原（DNGuard HVM 保护）");
	}
}
