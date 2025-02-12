﻿// Copyright (c) Josef Pihrt and Contributors. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Roslynator.CSharp.Refactorings.WrapSelectedLines
{
    internal sealed class WrapInRegionRefactoring : WrapSelectedLinesRefactoring
    {
        private WrapInRegionRefactoring()
        {
        }

        public static WrapInRegionRefactoring Instance { get; } = new WrapInRegionRefactoring();

        public override bool Indent
        {
            get { return true; }
        }

        public override string GetFirstLineText()
        {
            return "#region";
        }

        public override string GetLastLineText()
        {
            return "#endregion";
        }
    }
}
