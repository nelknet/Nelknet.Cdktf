using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsoadminTrustedTokenIssuer
{
    [JsiiInterface(nativeType: typeof(ISsoadminTrustedTokenIssuerTrustedTokenIssuerConfiguration), fullyQualifiedName: "aws.ssoadminTrustedTokenIssuer.SsoadminTrustedTokenIssuerTrustedTokenIssuerConfiguration")]
    public interface ISsoadminTrustedTokenIssuerTrustedTokenIssuerConfiguration
    {
        /// <summary>oidc_jwt_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_trusted_token_issuer#oidc_jwt_configuration SsoadminTrustedTokenIssuer#oidc_jwt_configuration}
        /// </remarks>
        [JsiiProperty(name: "oidcJwtConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssoadminTrustedTokenIssuer.SsoadminTrustedTokenIssuerTrustedTokenIssuerConfigurationOidcJwtConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OidcJwtConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsoadminTrustedTokenIssuerTrustedTokenIssuerConfiguration), fullyQualifiedName: "aws.ssoadminTrustedTokenIssuer.SsoadminTrustedTokenIssuerTrustedTokenIssuerConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.SsoadminTrustedTokenIssuer.ISsoadminTrustedTokenIssuerTrustedTokenIssuerConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>oidc_jwt_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_trusted_token_issuer#oidc_jwt_configuration SsoadminTrustedTokenIssuer#oidc_jwt_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oidcJwtConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssoadminTrustedTokenIssuer.SsoadminTrustedTokenIssuerTrustedTokenIssuerConfigurationOidcJwtConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OidcJwtConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
