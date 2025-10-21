namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SesActiveReceiptRuleSetState<'RuleSetName> = { assignments: ResizeArray<aws.SesActiveReceiptRuleSet.SesActiveReceiptRuleSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_active_receipt_rule_set">aws_ses_active_receipt_rule_set</a>.
    /// </summary>
    type SesActiveReceiptRuleSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : SesActiveReceiptRuleSetState<Missing> =
            ({ assignments = ResizeArray() } : SesActiveReceiptRuleSetState<Missing>)

        member _.Zero(()) : SesActiveReceiptRuleSetState<Missing> =
            ({ assignments = ResizeArray() } : SesActiveReceiptRuleSetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_active_receipt_rule_set#rule_set_name-1">SesActiveReceiptRuleSet#rule_set_name</a>.
        /// </summary>
        [<CustomOperation "rule_set_name">]
        member _.RuleSetName(state: SesActiveReceiptRuleSetState<Missing>, value: string) : SesActiveReceiptRuleSetState<Present> =
            state.assignments.Add(fun config -> config.RuleSetName <- value)
            ({ assignments = state.assignments } : SesActiveReceiptRuleSetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_active_receipt_rule_set#id-1">SesActiveReceiptRuleSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SesActiveReceiptRuleSetState<'RuleSetName>, value: string) : SesActiveReceiptRuleSetState<'RuleSetName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SesActiveReceiptRuleSetState<'RuleSetName>

        member _.Run(state: SesActiveReceiptRuleSetState<Present>) : aws.SesActiveReceiptRuleSet.SesActiveReceiptRuleSet =
            let config = aws.SesActiveReceiptRuleSet.SesActiveReceiptRuleSetConfig()
            for setter in state.assignments do
                setter config
            aws.SesActiveReceiptRuleSet.SesActiveReceiptRuleSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sesActiveReceiptRuleSet: missing required arguments. Must call: rule_set_name.", 9999, IsError = true)>]
        member _.Run(_: SesActiveReceiptRuleSetState<_>) : aws.SesActiveReceiptRuleSet.SesActiveReceiptRuleSet =
            Unchecked.defaultof<aws.SesActiveReceiptRuleSet.SesActiveReceiptRuleSet>
