namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsoadminManagedPolicyAttachmentState<'InstanceArn, 'ManagedPolicyArn, 'PermissionSetArn> = { assignments: ResizeArray<aws.SsoadminManagedPolicyAttachment.SsoadminManagedPolicyAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_managed_policy_attachment">aws_ssoadmin_managed_policy_attachment</a>.
    /// </summary>
    type SsoadminManagedPolicyAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsoadminManagedPolicyAttachmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsoadminManagedPolicyAttachmentState<Missing, Missing, Missing>)

        member _.Zero(()) : SsoadminManagedPolicyAttachmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsoadminManagedPolicyAttachmentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_managed_policy_attachment#instance_arn-1">SsoadminManagedPolicyAttachment#instance_arn</a>.
        /// </summary>
        [<CustomOperation "instance_arn">]
        member _.InstanceArn(state: SsoadminManagedPolicyAttachmentState<Missing, 'ManagedPolicyArn, 'PermissionSetArn>, value: string) : SsoadminManagedPolicyAttachmentState<Present, 'ManagedPolicyArn, 'PermissionSetArn> =
            state.assignments.Add(fun config -> config.InstanceArn <- value)
            ({ assignments = state.assignments } : SsoadminManagedPolicyAttachmentState<Present, 'ManagedPolicyArn, 'PermissionSetArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_managed_policy_attachment#managed_policy_arn-1">SsoadminManagedPolicyAttachment#managed_policy_arn</a>.
        /// </summary>
        [<CustomOperation "managed_policy_arn">]
        member _.ManagedPolicyArn(state: SsoadminManagedPolicyAttachmentState<'InstanceArn, Missing, 'PermissionSetArn>, value: string) : SsoadminManagedPolicyAttachmentState<'InstanceArn, Present, 'PermissionSetArn> =
            state.assignments.Add(fun config -> config.ManagedPolicyArn <- value)
            ({ assignments = state.assignments } : SsoadminManagedPolicyAttachmentState<'InstanceArn, Present, 'PermissionSetArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_managed_policy_attachment#permission_set_arn-1">SsoadminManagedPolicyAttachment#permission_set_arn</a>.
        /// </summary>
        [<CustomOperation "permission_set_arn">]
        member _.PermissionSetArn(state: SsoadminManagedPolicyAttachmentState<'InstanceArn, 'ManagedPolicyArn, Missing>, value: string) : SsoadminManagedPolicyAttachmentState<'InstanceArn, 'ManagedPolicyArn, Present> =
            state.assignments.Add(fun config -> config.PermissionSetArn <- value)
            ({ assignments = state.assignments } : SsoadminManagedPolicyAttachmentState<'InstanceArn, 'ManagedPolicyArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_managed_policy_attachment#id-1">SsoadminManagedPolicyAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SsoadminManagedPolicyAttachmentState<'InstanceArn, 'ManagedPolicyArn, 'PermissionSetArn>, value: string) : SsoadminManagedPolicyAttachmentState<'InstanceArn, 'ManagedPolicyArn, 'PermissionSetArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SsoadminManagedPolicyAttachmentState<'InstanceArn, 'ManagedPolicyArn, 'PermissionSetArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_managed_policy_attachment#timeouts-1">SsoadminManagedPolicyAttachment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SsoadminManagedPolicyAttachmentState<'InstanceArn, 'ManagedPolicyArn, 'PermissionSetArn>, value: aws.SsoadminManagedPolicyAttachment.SsoadminManagedPolicyAttachmentTimeouts) : SsoadminManagedPolicyAttachmentState<'InstanceArn, 'ManagedPolicyArn, 'PermissionSetArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SsoadminManagedPolicyAttachmentState<'InstanceArn, 'ManagedPolicyArn, 'PermissionSetArn>

        member _.Run(state: SsoadminManagedPolicyAttachmentState<Present, Present, Present>) : aws.SsoadminManagedPolicyAttachment.SsoadminManagedPolicyAttachment =
            let config = aws.SsoadminManagedPolicyAttachment.SsoadminManagedPolicyAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.SsoadminManagedPolicyAttachment.SsoadminManagedPolicyAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssoadminManagedPolicyAttachment: missing required arguments. Must call: instance_arn, managed_policy_arn, permission_set_arn.", 9999, IsError = true)>]
        member _.Run(_: SsoadminManagedPolicyAttachmentState<_, _, _>) : aws.SsoadminManagedPolicyAttachment.SsoadminManagedPolicyAttachment =
            Unchecked.defaultof<aws.SsoadminManagedPolicyAttachment.SsoadminManagedPolicyAttachment>
