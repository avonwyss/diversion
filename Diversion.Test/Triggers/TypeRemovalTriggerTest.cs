﻿using Diversion.Reflection;
using Diversion.Triggers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Should;

namespace Diversion.Test.Triggers
{
    [TestClass]
    public class TypeRemovalTriggerTest
    {
        [TestMethod]
        public void ShouldTriggerIfAnyPublicTypesHaveBeenRemoved()
        {
            var change = Mock.Of<IAssemblyDiversion>(
                obj => obj.TypeDiversions == Mock.Of<IDiversions<ITypeInfo, ITypeDiversion>>(
                    tc => tc.Removed == new[] {Mock.Of<ITypeInfo>(t => t.IsOnApiSurface)}));
            new TypeRemovalTrigger().IsTriggered(change).ShouldBeTrue();
        }

        [TestMethod]
        public void ShouldNotTriggerIfNoPublicTypesHaveBeenRemoved()
        {
            var change = Mock.Of<IAssemblyDiversion>(
                obj => obj.TypeDiversions == Mock.Of<IDiversions<ITypeInfo, ITypeDiversion>>(
                    tc =>
                    tc.Diverged == new ITypeDiversion[0] &&
                    tc.Removed == new ITypeInfo[0]));
            new TypeRemovalTrigger().IsTriggered(change).ShouldBeFalse();
        }
    }
}
