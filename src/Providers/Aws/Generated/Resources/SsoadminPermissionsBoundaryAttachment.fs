namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsoadminPermissionsBoundaryAttachmentState<'InstanceArn, 'PermissionsBoundary, 'PermissionSetArn> = { assignments: ResizeArray<aws.SsoadminPermissionsBoundaryAttachment.SsoadminPermissionsBoundaryAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permissions_boundary_attachment">aws_ssoadmin_permissions_boundary_attachment</a>.
    /// </summary>
    type SsoadminPermissionsBoundaryAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsoadminPermissionsBoundaryAttachmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsoadminPermissionsBoundaryAttachmentState<Missing, Missing, Missing>)

        member _.Zero(()) : SsoadminPermissionsBoundaryAttachmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsoadminPermissionsBoundaryAttachmentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permissions_boundary_attachment#instance_arn-1">SsoadminPermissionsBoundaryAttachment#instance_arn</a>.
        /// </summary>
        [<CustomOperation "instance_arn">]
        member _.InstanceArn(state: SsoadminPermissionsBoundaryAttachmentState<Missing, 'PermissionsBoundary, 'PermissionSetArn>, value: string) : SsoadminPermissionsBoundaryAttachmentState<Present, 'PermissionsBoundary, 'PermissionSetArn> =
            state.assignments.Add(fun config -> config.InstanceArn <- value)
            ({ assignments = state.assignments } : SsoadminPermissionsBoundaryAttachmentState<Present, 'PermissionsBoundary, 'PermissionSetArn>)

        /// <summary>
        /// permissions_boundary block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permissions_boundary_attachment#permissions_boundary-1">SsoadminPermissionsBoundaryAttachment#permissions_boundary</a>
        /// </summary>
        [<CustomOperation "permissions_boundary">]
        member _.PermissionsBoundary(state: SsoadminPermissionsBoundaryAttachmentState<'InstanceArn, Missing, 'PermissionSetArn>, value: aws.SsoadminPermissionsBoundaryAttachment.SsoadminPermissionsBoundaryAttachmentPermissionsBoundary) : SsoadminPermissionsBoundaryAttachmentState<'InstanceArn, Present, 'PermissionSetArn> =
            state.assignments.Add(fun config -> config.PermissionsBoundary <- value)
            ({ assignments = state.assignments } : SsoadminPermissionsBoundaryAttachmentState<'InstanceArn, Present, 'PermissionSetArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permissions_boundary_attachment#permission_set_arn-1">SsoadminPermissionsBoundaryAttachment#permission_set_arn</a>.
        /// </summary>
        [<CustomOperation "permission_set_arn">]
        member _.PermissionSetArn(state: SsoadminPermissionsBoundaryAttachmentState<'InstanceArn, 'PermissionsBoundary, Missing>, value: string) : SsoadminPermissionsBoundaryAttachmentState<'InstanceArn, 'PermissionsBoundary, Present> =
            state.assignments.Add(fun config -> config.PermissionSetArn <- value)
            ({ assignments = state.assignments } : SsoadminPermissionsBoundaryAttachmentState<'InstanceArn, 'PermissionsBoundary, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permissions_boundary_attachment#id-1">SsoadminPermissionsBoundaryAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SsoadminPermissionsBoundaryAttachmentState<'InstanceArn, 'PermissionsBoundary, 'PermissionSetArn>, value: string) : SsoadminPermissionsBoundaryAttachmentState<'InstanceArn, 'PermissionsBoundary, 'PermissionSetArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SsoadminPermissionsBoundaryAttachmentState<'InstanceArn, 'PermissionsBoundary, 'PermissionSetArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permissions_boundary_attachment#timeouts-1">SsoadminPermissionsBoundaryAttachment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SsoadminPermissionsBoundaryAttachmentState<'InstanceArn, 'PermissionsBoundary, 'PermissionSetArn>, value: aws.SsoadminPermissionsBoundaryAttachment.SsoadminPermissionsBoundaryAttachmentTimeouts) : SsoadminPermissionsBoundaryAttachmentState<'InstanceArn, 'PermissionsBoundary, 'PermissionSetArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SsoadminPermissionsBoundaryAttachmentState<'InstanceArn, 'PermissionsBoundary, 'PermissionSetArn>

        member _.Run(state: SsoadminPermissionsBoundaryAttachmentState<Present, Present, Present>) : aws.SsoadminPermissionsBoundaryAttachment.SsoadminPermissionsBoundaryAttachment =
            let config = aws.SsoadminPermissionsBoundaryAttachment.SsoadminPermissionsBoundaryAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.SsoadminPermissionsBoundaryAttachment.SsoadminPermissionsBoundaryAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssoadminPermissionsBoundaryAttachment: missing required arguments. Must call: instance_arn, permissions_boundary, permission_set_arn.", 9999, IsError = true)>]
        member _.Run(_: SsoadminPermissionsBoundaryAttachmentState<_, _, _>) : aws.SsoadminPermissionsBoundaryAttachment.SsoadminPermissionsBoundaryAttachment =
            Unchecked.defaultof<aws.SsoadminPermissionsBoundaryAttachment.SsoadminPermissionsBoundaryAttachment>
