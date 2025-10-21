namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsoadminCustomerManagedPolicyAttachmentState<'CustomerManagedPolicyReference, 'InstanceArn, 'PermissionSetArn> = { assignments: ResizeArray<aws.SsoadminCustomerManagedPolicyAttachment.SsoadminCustomerManagedPolicyAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_customer_managed_policy_attachment">aws_ssoadmin_customer_managed_policy_attachment</a>.
    /// </summary>
    type SsoadminCustomerManagedPolicyAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsoadminCustomerManagedPolicyAttachmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsoadminCustomerManagedPolicyAttachmentState<Missing, Missing, Missing>)

        member _.Zero(()) : SsoadminCustomerManagedPolicyAttachmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsoadminCustomerManagedPolicyAttachmentState<Missing, Missing, Missing>)

        /// <summary>
        /// customer_managed_policy_reference block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_customer_managed_policy_attachment#customer_managed_policy_reference-1">SsoadminCustomerManagedPolicyAttachment#customer_managed_policy_reference</a>
        /// </summary>
        [<CustomOperation "customer_managed_policy_reference">]
        member _.CustomerManagedPolicyReference(state: SsoadminCustomerManagedPolicyAttachmentState<Missing, 'InstanceArn, 'PermissionSetArn>, value: aws.SsoadminCustomerManagedPolicyAttachment.SsoadminCustomerManagedPolicyAttachmentCustomerManagedPolicyReference) : SsoadminCustomerManagedPolicyAttachmentState<Present, 'InstanceArn, 'PermissionSetArn> =
            state.assignments.Add(fun config -> config.CustomerManagedPolicyReference <- value)
            ({ assignments = state.assignments } : SsoadminCustomerManagedPolicyAttachmentState<Present, 'InstanceArn, 'PermissionSetArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_customer_managed_policy_attachment#instance_arn-1">SsoadminCustomerManagedPolicyAttachment#instance_arn</a>.
        /// </summary>
        [<CustomOperation "instance_arn">]
        member _.InstanceArn(state: SsoadminCustomerManagedPolicyAttachmentState<'CustomerManagedPolicyReference, Missing, 'PermissionSetArn>, value: string) : SsoadminCustomerManagedPolicyAttachmentState<'CustomerManagedPolicyReference, Present, 'PermissionSetArn> =
            state.assignments.Add(fun config -> config.InstanceArn <- value)
            ({ assignments = state.assignments } : SsoadminCustomerManagedPolicyAttachmentState<'CustomerManagedPolicyReference, Present, 'PermissionSetArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_customer_managed_policy_attachment#permission_set_arn-1">SsoadminCustomerManagedPolicyAttachment#permission_set_arn</a>.
        /// </summary>
        [<CustomOperation "permission_set_arn">]
        member _.PermissionSetArn(state: SsoadminCustomerManagedPolicyAttachmentState<'CustomerManagedPolicyReference, 'InstanceArn, Missing>, value: string) : SsoadminCustomerManagedPolicyAttachmentState<'CustomerManagedPolicyReference, 'InstanceArn, Present> =
            state.assignments.Add(fun config -> config.PermissionSetArn <- value)
            ({ assignments = state.assignments } : SsoadminCustomerManagedPolicyAttachmentState<'CustomerManagedPolicyReference, 'InstanceArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_customer_managed_policy_attachment#id-1">SsoadminCustomerManagedPolicyAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SsoadminCustomerManagedPolicyAttachmentState<'CustomerManagedPolicyReference, 'InstanceArn, 'PermissionSetArn>, value: string) : SsoadminCustomerManagedPolicyAttachmentState<'CustomerManagedPolicyReference, 'InstanceArn, 'PermissionSetArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SsoadminCustomerManagedPolicyAttachmentState<'CustomerManagedPolicyReference, 'InstanceArn, 'PermissionSetArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_customer_managed_policy_attachment#timeouts-1">SsoadminCustomerManagedPolicyAttachment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SsoadminCustomerManagedPolicyAttachmentState<'CustomerManagedPolicyReference, 'InstanceArn, 'PermissionSetArn>, value: aws.SsoadminCustomerManagedPolicyAttachment.SsoadminCustomerManagedPolicyAttachmentTimeouts) : SsoadminCustomerManagedPolicyAttachmentState<'CustomerManagedPolicyReference, 'InstanceArn, 'PermissionSetArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SsoadminCustomerManagedPolicyAttachmentState<'CustomerManagedPolicyReference, 'InstanceArn, 'PermissionSetArn>

        member _.Run(state: SsoadminCustomerManagedPolicyAttachmentState<Present, Present, Present>) : aws.SsoadminCustomerManagedPolicyAttachment.SsoadminCustomerManagedPolicyAttachment =
            let config = aws.SsoadminCustomerManagedPolicyAttachment.SsoadminCustomerManagedPolicyAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.SsoadminCustomerManagedPolicyAttachment.SsoadminCustomerManagedPolicyAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssoadminCustomerManagedPolicyAttachment: missing required arguments. Must call: customer_managed_policy_reference, instance_arn, permission_set_arn.", 9999, IsError = true)>]
        member _.Run(_: SsoadminCustomerManagedPolicyAttachmentState<_, _, _>) : aws.SsoadminCustomerManagedPolicyAttachment.SsoadminCustomerManagedPolicyAttachment =
            Unchecked.defaultof<aws.SsoadminCustomerManagedPolicyAttachment.SsoadminCustomerManagedPolicyAttachment>
