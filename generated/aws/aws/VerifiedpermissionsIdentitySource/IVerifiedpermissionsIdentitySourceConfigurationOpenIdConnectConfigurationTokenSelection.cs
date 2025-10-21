using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VerifiedpermissionsIdentitySource
{
    [JsiiInterface(nativeType: typeof(IVerifiedpermissionsIdentitySourceConfigurationOpenIdConnectConfigurationTokenSelection), fullyQualifiedName: "aws.verifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySourceConfigurationOpenIdConnectConfigurationTokenSelection")]
    public interface IVerifiedpermissionsIdentitySourceConfigurationOpenIdConnectConfigurationTokenSelection
    {
        /// <summary>access_token_only block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_identity_source#access_token_only VerifiedpermissionsIdentitySource#access_token_only}
        /// </remarks>
        [JsiiProperty(name: "accessTokenOnly", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.verifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySourceConfigurationOpenIdConnectConfigurationTokenSelectionAccessTokenOnly\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AccessTokenOnly
        {
            get
            {
                return null;
            }
        }

        /// <summary>identity_token_only block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_identity_source#identity_token_only VerifiedpermissionsIdentitySource#identity_token_only}
        /// </remarks>
        [JsiiProperty(name: "identityTokenOnly", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.verifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySourceConfigurationOpenIdConnectConfigurationTokenSelectionIdentityTokenOnly\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IdentityTokenOnly
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVerifiedpermissionsIdentitySourceConfigurationOpenIdConnectConfigurationTokenSelection), fullyQualifiedName: "aws.verifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySourceConfigurationOpenIdConnectConfigurationTokenSelection")]
        internal sealed class _Proxy : DeputyBase, aws.VerifiedpermissionsIdentitySource.IVerifiedpermissionsIdentitySourceConfigurationOpenIdConnectConfigurationTokenSelection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>access_token_only block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_identity_source#access_token_only VerifiedpermissionsIdentitySource#access_token_only}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessTokenOnly", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.verifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySourceConfigurationOpenIdConnectConfigurationTokenSelectionAccessTokenOnly\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AccessTokenOnly
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>identity_token_only block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_identity_source#identity_token_only VerifiedpermissionsIdentitySource#identity_token_only}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identityTokenOnly", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.verifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySourceConfigurationOpenIdConnectConfigurationTokenSelectionIdentityTokenOnly\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IdentityTokenOnly
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
