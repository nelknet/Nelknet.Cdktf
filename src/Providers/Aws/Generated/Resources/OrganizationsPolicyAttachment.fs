namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OrganizationsPolicyAttachmentState<'PolicyId, 'TargetId> = { assignments: ResizeArray<aws.OrganizationsPolicyAttachment.OrganizationsPolicyAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_policy_attachment">aws_organizations_policy_attachment</a>.
    /// </summary>
    type OrganizationsPolicyAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : OrganizationsPolicyAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OrganizationsPolicyAttachmentState<Missing, Missing>)

        member _.Zero(()) : OrganizationsPolicyAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OrganizationsPolicyAttachmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_policy_attachment#policy_id-1">OrganizationsPolicyAttachment#policy_id</a>.
        /// </summary>
        [<CustomOperation "policy_id">]
        member _.PolicyId(state: OrganizationsPolicyAttachmentState<Missing, 'TargetId>, value: string) : OrganizationsPolicyAttachmentState<Present, 'TargetId> =
            state.assignments.Add(fun config -> config.PolicyId <- value)
            ({ assignments = state.assignments } : OrganizationsPolicyAttachmentState<Present, 'TargetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_policy_attachment#target_id-1">OrganizationsPolicyAttachment#target_id</a>.
        /// </summary>
        [<CustomOperation "target_id">]
        member _.TargetId(state: OrganizationsPolicyAttachmentState<'PolicyId, Missing>, value: string) : OrganizationsPolicyAttachmentState<'PolicyId, Present> =
            state.assignments.Add(fun config -> config.TargetId <- value)
            ({ assignments = state.assignments } : OrganizationsPolicyAttachmentState<'PolicyId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_policy_attachment#id-1">OrganizationsPolicyAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OrganizationsPolicyAttachmentState<'PolicyId, 'TargetId>, value: string) : OrganizationsPolicyAttachmentState<'PolicyId, 'TargetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OrganizationsPolicyAttachmentState<'PolicyId, 'TargetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_policy_attachment#skip_destroy-1">OrganizationsPolicyAttachment#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: OrganizationsPolicyAttachmentState<'PolicyId, 'TargetId>, value: bool) : OrganizationsPolicyAttachmentState<'PolicyId, 'TargetId> =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : OrganizationsPolicyAttachmentState<'PolicyId, 'TargetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_policy_attachment#skip_destroy-1">OrganizationsPolicyAttachment#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: OrganizationsPolicyAttachmentState<'PolicyId, 'TargetId>, value: HashiCorp.Cdktf.IResolvable) : OrganizationsPolicyAttachmentState<'PolicyId, 'TargetId> =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : OrganizationsPolicyAttachmentState<'PolicyId, 'TargetId>

        member _.Run(state: OrganizationsPolicyAttachmentState<Present, Present>) : aws.OrganizationsPolicyAttachment.OrganizationsPolicyAttachment =
            let config = aws.OrganizationsPolicyAttachment.OrganizationsPolicyAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.OrganizationsPolicyAttachment.OrganizationsPolicyAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.organizationsPolicyAttachment: missing required arguments. Must call: policy_id, target_id.", 9999, IsError = true)>]
        member _.Run(_: OrganizationsPolicyAttachmentState<_, _>) : aws.OrganizationsPolicyAttachment.OrganizationsPolicyAttachment =
            Unchecked.defaultof<aws.OrganizationsPolicyAttachment.OrganizationsPolicyAttachment>
