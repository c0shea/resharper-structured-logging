﻿using ReSharper.Structured.Logging.QuickFixes;

namespace ReSharper.Structured.Logging.Tests.QuickFixes
{
    public class RemoveRedundantMessageTemplateArgumentValueFixTests : QuickFixTestBase<RemoveRedundantMessageTemplateArgumentValueFix>
    {
        protected override string SubPath => "RedundantArgumentFix";
    }
}
