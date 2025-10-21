namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SesReceiptRuleSetState<'RuleSetName> = { assignments: ResizeArray<aws.SesReceiptRuleSet.SesReceiptRuleSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_receipt_rule_set">aws_ses_receipt_rule_set</a>.
    /// </summary>
    type SesReceiptRuleSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : SesReceiptRuleSetState<Missing> =
            ({ assignments = ResizeArray() } : SesReceiptRuleSetState<Missing>)

        member _.Zero(()) : SesReceiptRuleSetState<Missing> =
            ({ assignments = ResizeArray() } : SesReceiptRuleSetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_receipt_rule_set#rule_set_name-1">SesReceiptRuleSet#rule_set_name</a>.
        /// </summary>
        [<CustomOperation "rule_set_name">]
        member _.RuleSetName(state: SesReceiptRuleSetState<Missing>, value: string) : SesReceiptRuleSetState<Present> =
            state.assignments.Add(fun config -> config.RuleSetName <- value)
            ({ assignments = state.assignments } : SesReceiptRuleSetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_receipt_rule_set#id-1">SesReceiptRuleSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SesReceiptRuleSetState<'RuleSetName>, value: string) : SesReceiptRuleSetState<'RuleSetName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SesReceiptRuleSetState<'RuleSetName>

        member _.Run(state: SesReceiptRuleSetState<Present>) : aws.SesReceiptRuleSet.SesReceiptRuleSet =
            let config = aws.SesReceiptRuleSet.SesReceiptRuleSetConfig()
            for setter in state.assignments do
                setter config
            aws.SesReceiptRuleSet.SesReceiptRuleSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sesReceiptRuleSet: missing required arguments. Must call: rule_set_name.", 9999, IsError = true)>]
        member _.Run(_: SesReceiptRuleSetState<_>) : aws.SesReceiptRuleSet.SesReceiptRuleSet =
            Unchecked.defaultof<aws.SesReceiptRuleSet.SesReceiptRuleSet>
