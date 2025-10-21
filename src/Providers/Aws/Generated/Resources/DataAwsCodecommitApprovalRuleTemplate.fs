namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCodecommitApprovalRuleTemplateState<'Name> = { assignments: ResizeArray<aws.DataAwsCodecommitApprovalRuleTemplate.DataAwsCodecommitApprovalRuleTemplateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codecommit_approval_rule_template">aws_codecommit_approval_rule_template</a>.
    /// </summary>
    type DataAwsCodecommitApprovalRuleTemplateBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCodecommitApprovalRuleTemplateState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCodecommitApprovalRuleTemplateState<Missing>)

        member _.Zero(()) : DataAwsCodecommitApprovalRuleTemplateState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCodecommitApprovalRuleTemplateState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codecommit_approval_rule_template#name-1">DataAwsCodecommitApprovalRuleTemplate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsCodecommitApprovalRuleTemplateState<Missing>, value: string) : DataAwsCodecommitApprovalRuleTemplateState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsCodecommitApprovalRuleTemplateState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codecommit_approval_rule_template#id-1">DataAwsCodecommitApprovalRuleTemplate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCodecommitApprovalRuleTemplateState<'Name>, value: string) : DataAwsCodecommitApprovalRuleTemplateState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCodecommitApprovalRuleTemplateState<'Name>

        member _.Run(state: DataAwsCodecommitApprovalRuleTemplateState<Present>) : aws.DataAwsCodecommitApprovalRuleTemplate.DataAwsCodecommitApprovalRuleTemplate =
            let config = aws.DataAwsCodecommitApprovalRuleTemplate.DataAwsCodecommitApprovalRuleTemplateConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCodecommitApprovalRuleTemplate.DataAwsCodecommitApprovalRuleTemplate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCodecommitApprovalRuleTemplate: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCodecommitApprovalRuleTemplateState<_>) : aws.DataAwsCodecommitApprovalRuleTemplate.DataAwsCodecommitApprovalRuleTemplate =
            Unchecked.defaultof<aws.DataAwsCodecommitApprovalRuleTemplate.DataAwsCodecommitApprovalRuleTemplate>
