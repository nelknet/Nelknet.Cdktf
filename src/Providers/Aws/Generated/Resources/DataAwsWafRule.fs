namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsWafRuleState<'Name> = { assignments: ResizeArray<aws.DataAwsWafRule.DataAwsWafRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/waf_rule">aws_waf_rule</a>.
    /// </summary>
    type DataAwsWafRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsWafRuleState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsWafRuleState<Missing>)

        member _.Zero(()) : DataAwsWafRuleState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsWafRuleState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/waf_rule#name-1">DataAwsWafRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsWafRuleState<Missing>, value: string) : DataAwsWafRuleState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsWafRuleState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/waf_rule#id-1">DataAwsWafRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsWafRuleState<'Name>, value: string) : DataAwsWafRuleState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsWafRuleState<'Name>

        member _.Run(state: DataAwsWafRuleState<Present>) : aws.DataAwsWafRule.DataAwsWafRule =
            let config = aws.DataAwsWafRule.DataAwsWafRuleConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsWafRule.DataAwsWafRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsWafRule: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsWafRuleState<_>) : aws.DataAwsWafRule.DataAwsWafRule =
            Unchecked.defaultof<aws.DataAwsWafRule.DataAwsWafRule>
