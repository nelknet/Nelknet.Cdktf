namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsWafregionalRateBasedRuleState<'Name> = { assignments: ResizeArray<aws.DataAwsWafregionalRateBasedRule.DataAwsWafregionalRateBasedRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/wafregional_rate_based_rule">aws_wafregional_rate_based_rule</a>.
    /// </summary>
    type DataAwsWafregionalRateBasedRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsWafregionalRateBasedRuleState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsWafregionalRateBasedRuleState<Missing>)

        member _.Zero(()) : DataAwsWafregionalRateBasedRuleState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsWafregionalRateBasedRuleState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/wafregional_rate_based_rule#name-1">DataAwsWafregionalRateBasedRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsWafregionalRateBasedRuleState<Missing>, value: string) : DataAwsWafregionalRateBasedRuleState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsWafregionalRateBasedRuleState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/wafregional_rate_based_rule#id-1">DataAwsWafregionalRateBasedRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsWafregionalRateBasedRuleState<'Name>, value: string) : DataAwsWafregionalRateBasedRuleState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsWafregionalRateBasedRuleState<'Name>

        member _.Run(state: DataAwsWafregionalRateBasedRuleState<Present>) : aws.DataAwsWafregionalRateBasedRule.DataAwsWafregionalRateBasedRule =
            let config = aws.DataAwsWafregionalRateBasedRule.DataAwsWafregionalRateBasedRuleConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsWafregionalRateBasedRule.DataAwsWafregionalRateBasedRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsWafregionalRateBasedRule: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsWafregionalRateBasedRuleState<_>) : aws.DataAwsWafregionalRateBasedRule.DataAwsWafregionalRateBasedRule =
            Unchecked.defaultof<aws.DataAwsWafregionalRateBasedRule.DataAwsWafregionalRateBasedRule>
