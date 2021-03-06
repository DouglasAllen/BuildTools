﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

// V2
namespace ComparisonScenarios
{
    internal class PublicToInternalClass
    {
    }

    public interface TypeToRenameRenamed
    {
    }

    public struct StructToMakeGeneric<TGenericType>
    {
    }

    public class ClassToNestContainer
    {
        public class ClassToNest
        {
        }
    }

    public class ClassToUnnestContainer
    {
    }

    public class ClassToUnnest
    {
    }

    public class GenericTypeWithConstraintsToBeAdded<TToConstrain> where TToConstrain : IEnumerable<TToConstrain>, new()
    {
    }

    public class ClassWithMethods
    {
        public void MethodToAddParameters(int addedParameter) { }
    }

    public class TypeWithExtraInterface : IExtraInterface
    {
        public int Property { get; set; }
    }

    public interface IExtraInterface
    {
        int Property { get; set; }
    }

    public interface IInterfaceToAddMembersTo
    {
        bool ExistingMember { get; set; }
        int NewMember { get; set; }
    }

    public interface IInterfaceWithMembersThatWillGetRenamedRemovedAndAdded
    {
        void RenamedMember();
        void AddedMember();
    }

    public interface IInterfaceWithSameNumberOfRemovedAndAddedMembers
    {
        void FirstUnchangedMember();
        void SecondUnchangedMember();
        void FirstAddedMember();
        void SecondAddedMember();
        void ThirdAddedMember();
    }
}

namespace ComparisonScenarios.ChangedNamespace
{
    public class ClassToChangeNamespaces
    {
    }
}