namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSesActiveReceiptRuleSetState = { assignments: ResizeArray<aws.DataAwsSesActiveReceiptRuleSet.DataAwsSesActiveReceiptRuleSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ses_active_receipt_rule_set">aws_ses_active_receipt_rule_set</a>.
    /// </summary>
    type DataAwsSesActiveReceiptRuleSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSesActiveReceiptRuleSetState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsSesActiveReceiptRuleSetState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ses_active_receipt_rule_set#id-1">DataAwsSesActiveReceiptRuleSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSesActiveReceiptRuleSetState, value: string) : DataAwsSesActiveReceiptRuleSetState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSesActiveReceiptRuleSetState

        member _.Run(state: DataAwsSesActiveReceiptRuleSetState) : aws.DataAwsSesActiveReceiptRuleSet.DataAwsSesActiveReceiptRuleSet =
            let config = aws.DataAwsSesActiveReceiptRuleSet.DataAwsSesActiveReceiptRuleSetConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSesActiveReceiptRuleSet.DataAwsSesActiveReceiptRuleSet(StackContext.get (), logicalId, config)
