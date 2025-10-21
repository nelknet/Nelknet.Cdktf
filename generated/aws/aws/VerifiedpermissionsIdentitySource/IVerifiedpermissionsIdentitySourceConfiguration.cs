using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VerifiedpermissionsIdentitySource
{
    [JsiiInterface(nativeType: typeof(IVerifiedpermissionsIdentitySourceConfiguration), fullyQualifiedName: "aws.verifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySourceConfiguration")]
    public interface IVerifiedpermissionsIdentitySourceConfiguration
    {
        /// <summary>cognito_user_pool_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_identity_source#cognito_user_pool_configuration VerifiedpermissionsIdentitySource#cognito_user_pool_configuration}
        /// </remarks>
        [JsiiProperty(name: "cognitoUserPoolConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.verifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySourceConfigurationCognitoUserPoolConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CognitoUserPoolConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>open_id_connect_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_identity_source#open_id_connect_configuration VerifiedpermissionsIdentitySource#open_id_connect_configuration}
        /// </remarks>
        [JsiiProperty(name: "openIdConnectConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.verifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySourceConfigurationOpenIdConnectConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OpenIdConnectConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVerifiedpermissionsIdentitySourceConfiguration), fullyQualifiedName: "aws.verifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySourceConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.VerifiedpermissionsIdentitySource.IVerifiedpermissionsIdentitySourceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cognito_user_pool_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_identity_source#cognito_user_pool_configuration VerifiedpermissionsIdentitySource#cognito_user_pool_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cognitoUserPoolConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.verifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySourceConfigurationCognitoUserPoolConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CognitoUserPoolConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>open_id_connect_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_identity_source#open_id_connect_configuration VerifiedpermissionsIdentitySource#open_id_connect_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "openIdConnectConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.verifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySourceConfigurationOpenIdConnectConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OpenIdConnectConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
