namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VerifiedpermissionsPolicyTemplateState<'PolicyStoreId, 'Statement> = { assignments: ResizeArray<aws.VerifiedpermissionsPolicyTemplate.VerifiedpermissionsPolicyTemplateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy_template">aws_verifiedpermissions_policy_template</a>.
    /// </summary>
    type VerifiedpermissionsPolicyTemplateBuilder(logicalId: string) =
        member _.Yield(_: unit) : VerifiedpermissionsPolicyTemplateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VerifiedpermissionsPolicyTemplateState<Missing, Missing>)

        member _.Zero(()) : VerifiedpermissionsPolicyTemplateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VerifiedpermissionsPolicyTemplateState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy_template#policy_store_id-1">VerifiedpermissionsPolicyTemplate#policy_store_id</a>.
        /// </summary>
        [<CustomOperation "policy_store_id">]
        member _.PolicyStoreId(state: VerifiedpermissionsPolicyTemplateState<Missing, 'Statement>, value: string) : VerifiedpermissionsPolicyTemplateState<Present, 'Statement> =
            state.assignments.Add(fun config -> config.PolicyStoreId <- value)
            ({ assignments = state.assignments } : VerifiedpermissionsPolicyTemplateState<Present, 'Statement>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy_template#statement-1">VerifiedpermissionsPolicyTemplate#statement</a>.
        /// </summary>
        [<CustomOperation "statement">]
        member _.Statement(state: VerifiedpermissionsPolicyTemplateState<'PolicyStoreId, Missing>, value: string) : VerifiedpermissionsPolicyTemplateState<'PolicyStoreId, Present> =
            state.assignments.Add(fun config -> config.Statement <- value)
            ({ assignments = state.assignments } : VerifiedpermissionsPolicyTemplateState<'PolicyStoreId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy_template#description-1">VerifiedpermissionsPolicyTemplate#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: VerifiedpermissionsPolicyTemplateState<'PolicyStoreId, 'Statement>, value: string) : VerifiedpermissionsPolicyTemplateState<'PolicyStoreId, 'Statement> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : VerifiedpermissionsPolicyTemplateState<'PolicyStoreId, 'Statement>

        member _.Run(state: VerifiedpermissionsPolicyTemplateState<Present, Present>) : aws.VerifiedpermissionsPolicyTemplate.VerifiedpermissionsPolicyTemplate =
            let config = aws.VerifiedpermissionsPolicyTemplate.VerifiedpermissionsPolicyTemplateConfig()
            for setter in state.assignments do
                setter config
            aws.VerifiedpermissionsPolicyTemplate.VerifiedpermissionsPolicyTemplate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.verifiedpermissionsPolicyTemplate: missing required arguments. Must call: policy_store_id, statement.", 9999, IsError = true)>]
        member _.Run(_: VerifiedpermissionsPolicyTemplateState<_, _>) : aws.VerifiedpermissionsPolicyTemplate.VerifiedpermissionsPolicyTemplate =
            Unchecked.defaultof<aws.VerifiedpermissionsPolicyTemplate.VerifiedpermissionsPolicyTemplate>
