namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsWafv2RuleGroupState<'Name, 'Scope> = { assignments: ResizeArray<aws.DataAwsWafv2RuleGroup.DataAwsWafv2RuleGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/wafv2_rule_group">aws_wafv2_rule_group</a>.
    /// </summary>
    type DataAwsWafv2RuleGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsWafv2RuleGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsWafv2RuleGroupState<Missing, Missing>)

        member _.Zero(()) : DataAwsWafv2RuleGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsWafv2RuleGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/wafv2_rule_group#name-1">DataAwsWafv2RuleGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsWafv2RuleGroupState<Missing, 'Scope>, value: string) : DataAwsWafv2RuleGroupState<Present, 'Scope> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsWafv2RuleGroupState<Present, 'Scope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/wafv2_rule_group#scope-1">DataAwsWafv2RuleGroup#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: DataAwsWafv2RuleGroupState<'Name, Missing>, value: string) : DataAwsWafv2RuleGroupState<'Name, Present> =
            state.assignments.Add(fun config -> config.Scope <- value)
            ({ assignments = state.assignments } : DataAwsWafv2RuleGroupState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/wafv2_rule_group#id-1">DataAwsWafv2RuleGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsWafv2RuleGroupState<'Name, 'Scope>, value: string) : DataAwsWafv2RuleGroupState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsWafv2RuleGroupState<'Name, 'Scope>

        member _.Run(state: DataAwsWafv2RuleGroupState<Present, Present>) : aws.DataAwsWafv2RuleGroup.DataAwsWafv2RuleGroup =
            let config = aws.DataAwsWafv2RuleGroup.DataAwsWafv2RuleGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsWafv2RuleGroup.DataAwsWafv2RuleGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsWafv2RuleGroup: missing required arguments. Must call: name, scope.", 9999, IsError = true)>]
        member _.Run(_: DataAwsWafv2RuleGroupState<_, _>) : aws.DataAwsWafv2RuleGroup.DataAwsWafv2RuleGroup =
            Unchecked.defaultof<aws.DataAwsWafv2RuleGroup.DataAwsWafv2RuleGroup>
