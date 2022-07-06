// Copyright (c) Josef Pihrt and Contributors. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp;

namespace Roslynator.CSharp
{
    internal class ModifierKindComparer : IComparer<SyntaxKind>
    {
        public static ModifierKindComparer Default { get; } = new ModifierKindComparer();

        public int Compare(SyntaxKind x, SyntaxKind y)
        {
            return GetRank(x).CompareTo(GetRank(y));
        }

        public virtual int GetRank(SyntaxKind kind)
        {
            switch (kind)
            {
                case SyntaxKind.PublicKeyword:
                    return 0;
                case SyntaxKind.PrivateKeyword:
                    return 1;
                case SyntaxKind.ProtectedKeyword:
                    return 2;
                case SyntaxKind.InternalKeyword:
                    return 3;
                case SyntaxKind.NewKeyword:
                    return 4;
                case SyntaxKind.UnsafeKeyword:
                    return 5;
                case SyntaxKind.ConstKeyword:
                    return 6;
                case SyntaxKind.StaticKeyword:
                    return 7;
                case SyntaxKind.ReadOnlyKeyword:
                    return 8;
                case SyntaxKind.VolatileKeyword:
                    return 9;
                case SyntaxKind.ExternKeyword:
                    return 10;
                case SyntaxKind.AbstractKeyword:
                    return 11;
                case SyntaxKind.VirtualKeyword:
                    return 12;
                case SyntaxKind.SealedKeyword:
                    return 13;
                case SyntaxKind.OverrideKeyword:
                    return 14;
                case SyntaxKind.AsyncKeyword:
                    return 15;
                case SyntaxKind.FixedKeyword:
                    return 16;
                case SyntaxKind.PartialKeyword:
                    return 17;
                case SyntaxKind.InKeyword:
                    return 18;
                case SyntaxKind.OutKeyword:
                    return 19;
                case SyntaxKind.RefKeyword:
                    return 20;
                case SyntaxKind.ThisKeyword:
                    return 21;
                default:
                    {
                        Debug.Fail($"unknown modifier '{kind}'");
                        return ModifierComparer.MaxRank;
                    }
            }
        }
    }
}
