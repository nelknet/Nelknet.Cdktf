namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodecommitApprovalRuleTemplateAssociationState<'ApprovalRuleTemplateName, 'RepositoryName> = { assignments: ResizeArray<aws.CodecommitApprovalRuleTemplateAssociation.CodecommitApprovalRuleTemplateAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecommit_approval_rule_template_association">aws_codecommit_approval_rule_template_association</a>.
    /// </summary>
    type CodecommitApprovalRuleTemplateAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodecommitApprovalRuleTemplateAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CodecommitApprovalRuleTemplateAssociationState<Missing, Missing>)

        member _.Zero(()) : CodecommitApprovalRuleTemplateAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CodecommitApprovalRuleTemplateAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecommit_approval_rule_template_association#approval_rule_template_name-1">CodecommitApprovalRuleTemplateAssociation#approval_rule_template_name</a>.
        /// </summary>
        [<CustomOperation "approval_rule_template_name">]
        member _.ApprovalRuleTemplateName(state: CodecommitApprovalRuleTemplateAssociationState<Missing, 'RepositoryName>, value: string) : CodecommitApprovalRuleTemplateAssociationState<Present, 'RepositoryName> =
            state.assignments.Add(fun config -> config.ApprovalRuleTemplateName <- value)
            ({ assignments = state.assignments } : CodecommitApprovalRuleTemplateAssociationState<Present, 'RepositoryName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecommit_approval_rule_template_association#repository_name-1">CodecommitApprovalRuleTemplateAssociation#repository_name</a>.
        /// </summary>
        [<CustomOperation "repository_name">]
        member _.RepositoryName(state: CodecommitApprovalRuleTemplateAssociationState<'ApprovalRuleTemplateName, Missing>, value: string) : CodecommitApprovalRuleTemplateAssociationState<'ApprovalRuleTemplateName, Present> =
            state.assignments.Add(fun config -> config.RepositoryName <- value)
            ({ assignments = state.assignments } : CodecommitApprovalRuleTemplateAssociationState<'ApprovalRuleTemplateName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecommit_approval_rule_template_association#id-1">CodecommitApprovalRuleTemplateAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CodecommitApprovalRuleTemplateAssociationState<'ApprovalRuleTemplateName, 'RepositoryName>, value: string) : CodecommitApprovalRuleTemplateAssociationState<'ApprovalRuleTemplateName, 'RepositoryName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CodecommitApprovalRuleTemplateAssociationState<'ApprovalRuleTemplateName, 'RepositoryName>

        member _.Run(state: CodecommitApprovalRuleTemplateAssociationState<Present, Present>) : aws.CodecommitApprovalRuleTemplateAssociation.CodecommitApprovalRuleTemplateAssociation =
            let config = aws.CodecommitApprovalRuleTemplateAssociation.CodecommitApprovalRuleTemplateAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.CodecommitApprovalRuleTemplateAssociation.CodecommitApprovalRuleTemplateAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codecommitApprovalRuleTemplateAssociation: missing required arguments. Must call: approval_rule_template_name, repository_name.", 9999, IsError = true)>]
        member _.Run(_: CodecommitApprovalRuleTemplateAssociationState<_, _>) : aws.CodecommitApprovalRuleTemplateAssociation.CodecommitApprovalRuleTemplateAssociation =
            Unchecked.defaultof<aws.CodecommitApprovalRuleTemplateAssociation.CodecommitApprovalRuleTemplateAssociation>
