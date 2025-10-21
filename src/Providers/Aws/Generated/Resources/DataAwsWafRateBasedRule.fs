namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsWafRateBasedRuleState<'Name> = { assignments: ResizeArray<aws.DataAwsWafRateBasedRule.DataAwsWafRateBasedRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/waf_rate_based_rule">aws_waf_rate_based_rule</a>.
    /// </summary>
    type DataAwsWafRateBasedRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsWafRateBasedRuleState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsWafRateBasedRuleState<Missing>)

        member _.Zero(()) : DataAwsWafRateBasedRuleState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsWafRateBasedRuleState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/waf_rate_based_rule#name-1">DataAwsWafRateBasedRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsWafRateBasedRuleState<Missing>, value: string) : DataAwsWafRateBasedRuleState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsWafRateBasedRuleState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/waf_rate_based_rule#id-1">DataAwsWafRateBasedRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsWafRateBasedRuleState<'Name>, value: string) : DataAwsWafRateBasedRuleState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsWafRateBasedRuleState<'Name>

        member _.Run(state: DataAwsWafRateBasedRuleState<Present>) : aws.DataAwsWafRateBasedRule.DataAwsWafRateBasedRule =
            let config = aws.DataAwsWafRateBasedRule.DataAwsWafRateBasedRuleConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsWafRateBasedRule.DataAwsWafRateBasedRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsWafRateBasedRule: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsWafRateBasedRuleState<_>) : aws.DataAwsWafRateBasedRule.DataAwsWafRateBasedRule =
            Unchecked.defaultof<aws.DataAwsWafRateBasedRule.DataAwsWafRateBasedRule>
