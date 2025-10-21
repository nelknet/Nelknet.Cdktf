namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RbinRuleState<'ResourceType, 'RetentionPeriod> = { assignments: ResizeArray<aws.RbinRule.RbinRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule">aws_rbin_rule</a>.
    /// </summary>
    type RbinRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : RbinRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RbinRuleState<Missing, Missing>)

        member _.Zero(()) : RbinRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RbinRuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#resource_type-1">RbinRule#resource_type</a>.
        /// </summary>
        [<CustomOperation "resource_type">]
        member _.ResourceType(state: RbinRuleState<Missing, 'RetentionPeriod>, value: string) : RbinRuleState<Present, 'RetentionPeriod> =
            state.assignments.Add(fun config -> config.ResourceType <- value)
            ({ assignments = state.assignments } : RbinRuleState<Present, 'RetentionPeriod>)

        /// <summary>
        /// retention_period block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#retention_period-1">RbinRule#retention_period</a>
        /// </summary>
        [<CustomOperation "retention_period">]
        member _.RetentionPeriod(state: RbinRuleState<'ResourceType, Missing>, value: aws.RbinRule.RbinRuleRetentionPeriod) : RbinRuleState<'ResourceType, Present> =
            state.assignments.Add(fun config -> config.RetentionPeriod <- value)
            ({ assignments = state.assignments } : RbinRuleState<'ResourceType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#description-1">RbinRule#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: RbinRuleState<'ResourceType, 'RetentionPeriod>, value: string) : RbinRuleState<'ResourceType, 'RetentionPeriod> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : RbinRuleState<'ResourceType, 'RetentionPeriod>

        /// <summary>
        /// lock_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#lock_configuration-1">RbinRule#lock_configuration</a>
        /// </summary>
        [<CustomOperation "lock_configuration">]
        member _.LockConfiguration(state: RbinRuleState<'ResourceType, 'RetentionPeriod>, value: aws.RbinRule.RbinRuleLockConfiguration) : RbinRuleState<'ResourceType, 'RetentionPeriod> =
            state.assignments.Add(fun config -> config.LockConfiguration <- value)
            state : RbinRuleState<'ResourceType, 'RetentionPeriod>

        /// <summary>
        /// resource_tags block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#resource_tags-1">RbinRule#resource_tags</a> Accepts: aws.IResolvable | aws.RbinRule.RbinRuleResourceTags[]
        /// </summary>
        [<CustomOperation "resource_tags">]
        member _.ResourceTags(state: RbinRuleState<'ResourceType, 'RetentionPeriod>, value: HashiCorp.Cdktf.IResolvable) : RbinRuleState<'ResourceType, 'RetentionPeriod> =
            state.assignments.Add(fun config -> config.ResourceTags <- value)
            state : RbinRuleState<'ResourceType, 'RetentionPeriod>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#tags-1">RbinRule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RbinRuleState<'ResourceType, 'RetentionPeriod>, value: seq<string * string>) : RbinRuleState<'ResourceType, 'RetentionPeriod> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RbinRuleState<'ResourceType, 'RetentionPeriod>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#tags_all-1">RbinRule#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: RbinRuleState<'ResourceType, 'RetentionPeriod>, value: seq<string * string>) : RbinRuleState<'ResourceType, 'RetentionPeriod> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : RbinRuleState<'ResourceType, 'RetentionPeriod>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#timeouts-1">RbinRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RbinRuleState<'ResourceType, 'RetentionPeriod>, value: aws.RbinRule.RbinRuleTimeouts) : RbinRuleState<'ResourceType, 'RetentionPeriod> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RbinRuleState<'ResourceType, 'RetentionPeriod>

        member _.Run(state: RbinRuleState<Present, Present>) : aws.RbinRule.RbinRule =
            let config = aws.RbinRule.RbinRuleConfig()
            for setter in state.assignments do
                setter config
            aws.RbinRule.RbinRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.rbinRule: missing required arguments. Must call: resource_type, retention_period.", 9999, IsError = true)>]
        member _.Run(_: RbinRuleState<_, _>) : aws.RbinRule.RbinRule =
            Unchecked.defaultof<aws.RbinRule.RbinRule>
