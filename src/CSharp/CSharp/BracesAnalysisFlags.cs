﻿// Copyright (c) Josef Pihrt and Contributors. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Roslynator.CSharp
{
    [Flags]
    internal enum BracesAnalysisFlags
    {
        None = 0,
        AddBraces = 1,
        RemoveBraces = 2,
    }
}
