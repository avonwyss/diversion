using System.Collections.Generic;

namespace Diversion.Reflection
{
    public interface IPropertyInfo : IMemberInfo, IVirtualizable
    {
        IReadOnlyList<IParameterInfo> IndexerParameters { get; }
        ITypeReference Type { get; }
    }
}