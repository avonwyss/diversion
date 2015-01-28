namespace Diversion.Reflection
{
    public interface IFieldInfo : IMemberInfo
    {
        ITypeInfo Type { get; }
        bool IsReadOnly { get; }
        bool IsConstant { get; }
    }
}