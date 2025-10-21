namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Wafv2RuleGroupState<'Capacity, 'Scope, 'VisibilityConfig> = { assignments: ResizeArray<aws.Wafv2RuleGroup.Wafv2RuleGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group">aws_wafv2_rule_group</a>.
    /// </summary>
    type Wafv2RuleGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : Wafv2RuleGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Wafv2RuleGroupState<Missing, Missing, Missing>)

        member _.Zero(()) : Wafv2RuleGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Wafv2RuleGroupState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#capacity-1">Wafv2RuleGroup#capacity</a>.
        /// </summary>
        [<CustomOperation "capacity">]
        member _.Capacity(state: Wafv2RuleGroupState<Missing, 'Scope, 'VisibilityConfig>, value: double) : Wafv2RuleGroupState<Present, 'Scope, 'VisibilityConfig> =
            state.assignments.Add(fun config -> config.Capacity <- value)
            ({ assignments = state.assignments } : Wafv2RuleGroupState<Present, 'Scope, 'VisibilityConfig>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#scope-1">Wafv2RuleGroup#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: Wafv2RuleGroupState<'Capacity, Missing, 'VisibilityConfig>, value: string) : Wafv2RuleGroupState<'Capacity, Present, 'VisibilityConfig> =
            state.assignments.Add(fun config -> config.Scope <- value)
            ({ assignments = state.assignments } : Wafv2RuleGroupState<'Capacity, Present, 'VisibilityConfig>)

        /// <summary>
        /// visibility_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#visibility_config-1">Wafv2RuleGroup#visibility_config</a>
        /// </summary>
        [<CustomOperation "visibility_config">]
        member _.VisibilityConfig(state: Wafv2RuleGroupState<'Capacity, 'Scope, Missing>, value: aws.Wafv2RuleGroup.Wafv2RuleGroupVisibilityConfig) : Wafv2RuleGroupState<'Capacity, 'Scope, Present> =
            state.assignments.Add(fun config -> config.VisibilityConfig <- value)
            ({ assignments = state.assignments } : Wafv2RuleGroupState<'Capacity, 'Scope, Present>)

        /// <summary>
        /// custom_response_body block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#custom_response_body-1">Wafv2RuleGroup#custom_response_body</a> Accepts: aws.IResolvable | aws.Wafv2RuleGroup.Wafv2RuleGroupCustomResponseBody[]
        /// </summary>
        [<CustomOperation "custom_response_body">]
        member _.CustomResponseBody(state: Wafv2RuleGroupState<'Capacity, 'Scope, 'VisibilityConfig>, value: HashiCorp.Cdktf.IResolvable) : Wafv2RuleGroupState<'Capacity, 'Scope, 'VisibilityConfig> =
            state.assignments.Add(fun config -> config.CustomResponseBody <- value)
            state : Wafv2RuleGroupState<'Capacity, 'Scope, 'VisibilityConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#description-1">Wafv2RuleGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Wafv2RuleGroupState<'Capacity, 'Scope, 'VisibilityConfig>, value: string) : Wafv2RuleGroupState<'Capacity, 'Scope, 'VisibilityConfig> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Wafv2RuleGroupState<'Capacity, 'Scope, 'VisibilityConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#id-1">Wafv2RuleGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Wafv2RuleGroupState<'Capacity, 'Scope, 'VisibilityConfig>, value: string) : Wafv2RuleGroupState<'Capacity, 'Scope, 'VisibilityConfig> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Wafv2RuleGroupState<'Capacity, 'Scope, 'VisibilityConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#name-1">Wafv2RuleGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Wafv2RuleGroupState<'Capacity, 'Scope, 'VisibilityConfig>, value: string) : Wafv2RuleGroupState<'Capacity, 'Scope, 'VisibilityConfig> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : Wafv2RuleGroupState<'Capacity, 'Scope, 'VisibilityConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#name_prefix-1">Wafv2RuleGroup#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: Wafv2RuleGroupState<'Capacity, 'Scope, 'VisibilityConfig>, value: string) : Wafv2RuleGroupState<'Capacity, 'Scope, 'VisibilityConfig> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : Wafv2RuleGroupState<'Capacity, 'Scope, 'VisibilityConfig>

        /// <summary>
        /// rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#rule-1">Wafv2RuleGroup#rule</a> Accepts: aws.IResolvable | aws.Wafv2RuleGroup.Wafv2RuleGroupRule[]
        /// </summary>
        [<CustomOperation "rule">]
        member _.Rule(state: Wafv2RuleGroupState<'Capacity, 'Scope, 'VisibilityConfig>, value: HashiCorp.Cdktf.IResolvable) : Wafv2RuleGroupState<'Capacity, 'Scope, 'VisibilityConfig> =
            state.assignments.Add(fun config -> config.Rule <- value)
            state : Wafv2RuleGroupState<'Capacity, 'Scope, 'VisibilityConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#tags-1">Wafv2RuleGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Wafv2RuleGroupState<'Capacity, 'Scope, 'VisibilityConfig>, value: seq<string * string>) : Wafv2RuleGroupState<'Capacity, 'Scope, 'VisibilityConfig> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Wafv2RuleGroupState<'Capacity, 'Scope, 'VisibilityConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#tags_all-1">Wafv2RuleGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Wafv2RuleGroupState<'Capacity, 'Scope, 'VisibilityConfig>, value: seq<string * string>) : Wafv2RuleGroupState<'Capacity, 'Scope, 'VisibilityConfig> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Wafv2RuleGroupState<'Capacity, 'Scope, 'VisibilityConfig>

        member _.Run(state: Wafv2RuleGroupState<Present, Present, Present>) : aws.Wafv2RuleGroup.Wafv2RuleGroup =
            let config = aws.Wafv2RuleGroup.Wafv2RuleGroupConfig()
            for setter in state.assignments do
                setter config
            aws.Wafv2RuleGroup.Wafv2RuleGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafv2RuleGroup: missing required arguments. Must call: capacity, scope, visibility_config.", 9999, IsError = true)>]
        member _.Run(_: Wafv2RuleGroupState<_, _, _>) : aws.Wafv2RuleGroup.Wafv2RuleGroup =
            Unchecked.defaultof<aws.Wafv2RuleGroup.Wafv2RuleGroup>
