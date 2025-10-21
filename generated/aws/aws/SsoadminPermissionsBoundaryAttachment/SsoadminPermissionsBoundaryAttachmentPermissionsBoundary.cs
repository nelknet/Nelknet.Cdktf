using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsoadminPermissionsBoundaryAttachment
{
    [JsiiByValue(fqn: "aws.ssoadminPermissionsBoundaryAttachment.SsoadminPermissionsBoundaryAttachmentPermissionsBoundary")]
    public class SsoadminPermissionsBoundaryAttachmentPermissionsBoundary : aws.SsoadminPermissionsBoundaryAttachment.ISsoadminPermissionsBoundaryAttachmentPermissionsBoundary
    {
        /// <summary>customer_managed_policy_reference block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permissions_boundary_attachment#customer_managed_policy_reference SsoadminPermissionsBoundaryAttachment#customer_managed_policy_reference}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customerManagedPolicyReference", typeJson: "{\"fqn\":\"aws.ssoadminPermissionsBoundaryAttachment.SsoadminPermissionsBoundaryAttachmentPermissionsBoundaryCustomerManagedPolicyReference\"}", isOptional: true)]
        public aws.SsoadminPermissionsBoundaryAttachment.ISsoadminPermissionsBoundaryAttachmentPermissionsBoundaryCustomerManagedPolicyReference? CustomerManagedPolicyReference
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permissions_boundary_attachment#managed_policy_arn SsoadminPermissionsBoundaryAttachment#managed_policy_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "managedPolicyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ManagedPolicyArn
        {
            get;
            set;
        }
    }
}
