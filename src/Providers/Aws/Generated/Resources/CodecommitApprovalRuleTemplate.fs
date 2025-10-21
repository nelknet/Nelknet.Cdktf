namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodecommitApprovalRuleTemplateState<'Content, 'Name> = { assignments: ResizeArray<aws.CodecommitApprovalRuleTemplate.CodecommitApprovalRuleTemplateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecommit_approval_rule_template">aws_codecommit_approval_rule_template</a>.
    /// </summary>
    type CodecommitApprovalRuleTemplateBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodecommitApprovalRuleTemplateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CodecommitApprovalRuleTemplateState<Missing, Missing>)

        member _.Zero(()) : CodecommitApprovalRuleTemplateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CodecommitApprovalRuleTemplateState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecommit_approval_rule_template#content-1">CodecommitApprovalRuleTemplate#content</a>.
        /// </summary>
        [<CustomOperation "content">]
        member _.Content(state: CodecommitApprovalRuleTemplateState<Missing, 'Name>, value: string) : CodecommitApprovalRuleTemplateState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Content <- value)
            ({ assignments = state.assignments } : CodecommitApprovalRuleTemplateState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecommit_approval_rule_template#name-1">CodecommitApprovalRuleTemplate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CodecommitApprovalRuleTemplateState<'Content, Missing>, value: string) : CodecommitApprovalRuleTemplateState<'Content, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CodecommitApprovalRuleTemplateState<'Content, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecommit_approval_rule_template#description-1">CodecommitApprovalRuleTemplate#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: CodecommitApprovalRuleTemplateState<'Content, 'Name>, value: string) : CodecommitApprovalRuleTemplateState<'Content, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : CodecommitApprovalRuleTemplateState<'Content, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecommit_approval_rule_template#id-1">CodecommitApprovalRuleTemplate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CodecommitApprovalRuleTemplateState<'Content, 'Name>, value: string) : CodecommitApprovalRuleTemplateState<'Content, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CodecommitApprovalRuleTemplateState<'Content, 'Name>

        member _.Run(state: CodecommitApprovalRuleTemplateState<Present, Present>) : aws.CodecommitApprovalRuleTemplate.CodecommitApprovalRuleTemplate =
            let config = aws.CodecommitApprovalRuleTemplate.CodecommitApprovalRuleTemplateConfig()
            for setter in state.assignments do
                setter config
            aws.CodecommitApprovalRuleTemplate.CodecommitApprovalRuleTemplate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codecommitApprovalRuleTemplate: missing required arguments. Must call: content, name.", 9999, IsError = true)>]
        member _.Run(_: CodecommitApprovalRuleTemplateState<_, _>) : aws.CodecommitApprovalRuleTemplate.CodecommitApprovalRuleTemplate =
            Unchecked.defaultof<aws.CodecommitApprovalRuleTemplate.CodecommitApprovalRuleTemplate>
