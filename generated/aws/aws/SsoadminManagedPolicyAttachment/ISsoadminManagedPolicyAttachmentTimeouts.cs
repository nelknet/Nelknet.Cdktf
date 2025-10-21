using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsoadminManagedPolicyAttachment
{
    [JsiiInterface(nativeType: typeof(ISsoadminManagedPolicyAttachmentTimeouts), fullyQualifiedName: "aws.ssoadminManagedPolicyAttachment.SsoadminManagedPolicyAttachmentTimeouts")]
    public interface ISsoadminManagedPolicyAttachmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_managed_policy_attachment#create SsoadminManagedPolicyAttachment#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_managed_policy_attachment#delete SsoadminManagedPolicyAttachment#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsoadminManagedPolicyAttachmentTimeouts), fullyQualifiedName: "aws.ssoadminManagedPolicyAttachment.SsoadminManagedPolicyAttachmentTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.SsoadminManagedPolicyAttachment.ISsoadminManagedPolicyAttachmentTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_managed_policy_attachment#create SsoadminManagedPolicyAttachment#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_managed_policy_attachment#delete SsoadminManagedPolicyAttachment#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
