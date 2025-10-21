using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsoadminApplication
{
    [JsiiInterface(nativeType: typeof(ISsoadminApplicationPortalOptions), fullyQualifiedName: "aws.ssoadminApplication.SsoadminApplicationPortalOptions")]
    public interface ISsoadminApplicationPortalOptions
    {
        /// <summary>sign_in_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application#sign_in_options SsoadminApplication#sign_in_options}
        /// </remarks>
        [JsiiProperty(name: "signInOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssoadminApplication.SsoadminApplicationPortalOptionsSignInOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SignInOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application#visibility SsoadminApplication#visibility}.</summary>
        [JsiiProperty(name: "visibility", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Visibility
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsoadminApplicationPortalOptions), fullyQualifiedName: "aws.ssoadminApplication.SsoadminApplicationPortalOptions")]
        internal sealed class _Proxy : DeputyBase, aws.SsoadminApplication.ISsoadminApplicationPortalOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>sign_in_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application#sign_in_options SsoadminApplication#sign_in_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "signInOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssoadminApplication.SsoadminApplicationPortalOptionsSignInOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SignInOptions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application#visibility SsoadminApplication#visibility}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "visibility", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Visibility
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
