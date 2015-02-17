using System;
using System.Reflection;

namespace Diversion.Reflection
{
    public interface IReflectionInfoFactory
    {
        IAssemblyInfo FromFile(string assemblyPath);
        ITypeReference GetReference(Type type);
        ITypeInfo FromReflection(Type type);
        IMemberInfo FromReflection(MemberInfo member);
        IAttributeInfo FromReflection(CustomAttributeData attribute);
        IParameterInfo FromReflection(ParameterInfo parameter);
    }
}