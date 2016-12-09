﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using Roslynator.CSharp.Refactorings;

namespace Roslynator.CSharp.DiagnosticAnalyzers
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class BlockDiagnosticAnalyzer : BaseDiagnosticAnalyzer
    {
        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                return ImmutableArray.Create(
                    DiagnosticDescriptors.FormatEmptyBlock,
                    DiagnosticDescriptors.FormatEachStatementOnSeparateLine,
                    DiagnosticDescriptors.RemoveRedundantEmptyLine);
            }
        }

        public override void Initialize(AnalysisContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            context.RegisterSyntaxNodeAction(f => AnalyzeBlock(f), SyntaxKind.Block);
        }

        private void AnalyzeBlock(SyntaxNodeAnalysisContext context)
        {
            if (GeneratedCodeAnalyzer?.IsGeneratedCode(context) == true)
                return;

            var block = (BlockSyntax)context.Node;

            RemoveRedundantEmptyLineRefactoring.Analyze(context, block);

            FormatEachStatementOnSeparateLineRefactoring.Analyze(context, block);

            FormatEmptyBlockRefactoring.Analyze(context, block);
        }
    }
}
