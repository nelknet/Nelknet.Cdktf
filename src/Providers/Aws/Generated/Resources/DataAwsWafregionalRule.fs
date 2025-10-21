namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsWafregionalRuleState<'Name> = { assignments: ResizeArray<aws.DataAwsWafregionalRule.DataAwsWafregionalRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/wafregional_rule">aws_wafregional_rule</a>.
    /// </summary>
    type DataAwsWafregionalRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsWafregionalRuleState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsWafregionalRuleState<Missing>)

        member _.Zero(()) : DataAwsWafregionalRuleState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsWafregionalRuleState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/wafregional_rule#name-1">DataAwsWafregionalRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsWafregionalRuleState<Missing>, value: string) : DataAwsWafregionalRuleState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsWafregionalRuleState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/wafregional_rule#id-1">DataAwsWafregionalRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsWafregionalRuleState<'Name>, value: string) : DataAwsWafregionalRuleState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsWafregionalRuleState<'Name>

        member _.Run(state: DataAwsWafregionalRuleState<Present>) : aws.DataAwsWafregionalRule.DataAwsWafregionalRule =
            let config = aws.DataAwsWafregionalRule.DataAwsWafregionalRuleConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsWafregionalRule.DataAwsWafregionalRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsWafregionalRule: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsWafregionalRuleState<_>) : aws.DataAwsWafregionalRule.DataAwsWafregionalRule =
            Unchecked.defaultof<aws.DataAwsWafregionalRule.DataAwsWafregionalRule>
