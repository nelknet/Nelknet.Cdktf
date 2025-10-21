using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsSsoadminApplication
{
    [JsiiInterface(nativeType: typeof(IDataAwsSsoadminApplicationPortalOptions), fullyQualifiedName: "aws.dataAwsSsoadminApplication.DataAwsSsoadminApplicationPortalOptions")]
    public interface IDataAwsSsoadminApplicationPortalOptions
    {
        /// <summary>sign_in_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_application#sign_in_options DataAwsSsoadminApplication#sign_in_options}
        /// </remarks>
        [JsiiProperty(name: "signInOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsSsoadminApplication.DataAwsSsoadminApplicationPortalOptionsSignInOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SignInOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsSsoadminApplicationPortalOptions), fullyQualifiedName: "aws.dataAwsSsoadminApplication.DataAwsSsoadminApplicationPortalOptions")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsSsoadminApplication.IDataAwsSsoadminApplicationPortalOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>sign_in_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_application#sign_in_options DataAwsSsoadminApplication#sign_in_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "signInOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsSsoadminApplication.DataAwsSsoadminApplicationPortalOptionsSignInOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SignInOptions
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
