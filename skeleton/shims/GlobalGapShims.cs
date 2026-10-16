// 全局命名空间缺口占位（**不是官方实现**）
// 少数引用在元数据里不带命名空间限定（如 MsgPack.Cli 的 ValueCollection），
// 这里提供同名占位以便编译通过。见 docs/骨架生成器-进展与剩余错误.md
using System.Collections.Generic;

public class ValueCollection<TKey, TValue> : Dictionary<TKey, TValue>
{
    public ValueCollection() { }
    public ValueCollection(IDictionary<TKey, TValue> d) : base(d) { }
}
