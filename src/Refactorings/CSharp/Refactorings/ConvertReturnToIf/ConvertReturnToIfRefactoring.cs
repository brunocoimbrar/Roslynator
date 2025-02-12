﻿// Copyright (c) Josef Pihrt and Contributors. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Roslynator.CSharp.Refactorings.ConvertReturnToIf
{
    internal static class ConvertReturnToIfRefactoring
    {
        public static ConvertReturnToIfElseRefactoring ConvertReturnToIfElse { get; } = new ConvertReturnToIfElseRefactoring();

        public static ConvertYieldReturnToIfElseRefactoring ConvertYieldReturnToIfElse { get; } = new ConvertYieldReturnToIfElseRefactoring();
    }
}
