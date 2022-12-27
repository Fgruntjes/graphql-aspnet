﻿// *************************************************************
// project:  graphql-aspnet
// --
// repo: https://github.com/graphql-aspnet
// docs: https://graphql-aspnet.github.io
// --
// License:  MIT
// *************************************************************

namespace GraphQL.AspNet.Execution.RulesEngine
{
    using GraphQL.AspNet.Execution.Contexts;
    using GraphQL.AspNet.Execution.FieldResolution;
    using GraphQL.AspNet.Execution.RulesEngine.RuleSets.FieldResolution;

    /// <summary>
    /// A rule processor that handles a set of rules relating to the immediate completion of a field
    /// resolution from user code. This rule set is executed directly following a resolver assigning a value
    /// to a <see cref="FieldDataItem"/> during a query plan execution. The rules of this processor must pass
    /// for the field to allow child context execution.
    /// </summary>
    public sealed class FieldCompletionRuleProcessor : RuleProcessor<FieldValidationContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldCompletionRuleProcessor"/> class.
        /// </summary>
        public FieldCompletionRuleProcessor()
            : base(FieldCompletionRulePackage.Instance)
        {
        }
    }
}