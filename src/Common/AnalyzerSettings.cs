﻿// Copyright (c) Josef Pihrt and Contributors. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Roslynator.Configuration;

namespace Roslynator
{
    internal sealed class AnalyzerSettings : CodeAnalysisSettings<string>
    {
        public static AnalyzerSettings Current { get; } = LoadSettings();

        public int MaxLineLength { get; set; }

        private static AnalyzerSettings LoadSettings()
        {
            var settings = new AnalyzerSettings();

            settings.Reset();

            return settings;
        }

        protected override void SetValues(CodeAnalysisConfiguration configuration)
        {
            if (configuration == null)
                return;

            MaxLineLength = configuration.MaxLineLength;
        }
    }
}
