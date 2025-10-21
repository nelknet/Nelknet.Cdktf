using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsoadminPermissionSetInlinePolicy
{
    [JsiiInterface(nativeType: typeof(ISsoadminPermissionSetInlinePolicyTimeouts), fullyQualifiedName: "aws.ssoadminPermissionSetInlinePolicy.SsoadminPermissionSetInlinePolicyTimeouts")]
    public interface ISsoadminPermissionSetInlinePolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permission_set_inline_policy#create SsoadminPermissionSetInlinePolicy#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permission_set_inline_policy#delete SsoadminPermissionSetInlinePolicy#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsoadminPermissionSetInlinePolicyTimeouts), fullyQualifiedName: "aws.ssoadminPermissionSetInlinePolicy.SsoadminPermissionSetInlinePolicyTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.SsoadminPermissionSetInlinePolicy.ISsoadminPermissionSetInlinePolicyTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permission_set_inline_policy#create SsoadminPermissionSetInlinePolicy#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permission_set_inline_policy#delete SsoadminPermissionSetInlinePolicy#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
