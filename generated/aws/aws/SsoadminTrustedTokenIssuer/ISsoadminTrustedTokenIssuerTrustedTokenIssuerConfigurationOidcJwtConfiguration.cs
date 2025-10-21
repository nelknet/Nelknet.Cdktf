using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsoadminTrustedTokenIssuer
{
    [JsiiInterface(nativeType: typeof(ISsoadminTrustedTokenIssuerTrustedTokenIssuerConfigurationOidcJwtConfiguration), fullyQualifiedName: "aws.ssoadminTrustedTokenIssuer.SsoadminTrustedTokenIssuerTrustedTokenIssuerConfigurationOidcJwtConfiguration")]
    public interface ISsoadminTrustedTokenIssuerTrustedTokenIssuerConfigurationOidcJwtConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_trusted_token_issuer#claim_attribute_path SsoadminTrustedTokenIssuer#claim_attribute_path}.</summary>
        [JsiiProperty(name: "claimAttributePath", typeJson: "{\"primitive\":\"string\"}")]
        string ClaimAttributePath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_trusted_token_issuer#identity_store_attribute_path SsoadminTrustedTokenIssuer#identity_store_attribute_path}.</summary>
        [JsiiProperty(name: "identityStoreAttributePath", typeJson: "{\"primitive\":\"string\"}")]
        string IdentityStoreAttributePath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_trusted_token_issuer#issuer_url SsoadminTrustedTokenIssuer#issuer_url}.</summary>
        [JsiiProperty(name: "issuerUrl", typeJson: "{\"primitive\":\"string\"}")]
        string IssuerUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_trusted_token_issuer#jwks_retrieval_option SsoadminTrustedTokenIssuer#jwks_retrieval_option}.</summary>
        [JsiiProperty(name: "jwksRetrievalOption", typeJson: "{\"primitive\":\"string\"}")]
        string JwksRetrievalOption
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISsoadminTrustedTokenIssuerTrustedTokenIssuerConfigurationOidcJwtConfiguration), fullyQualifiedName: "aws.ssoadminTrustedTokenIssuer.SsoadminTrustedTokenIssuerTrustedTokenIssuerConfigurationOidcJwtConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.SsoadminTrustedTokenIssuer.ISsoadminTrustedTokenIssuerTrustedTokenIssuerConfigurationOidcJwtConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_trusted_token_issuer#claim_attribute_path SsoadminTrustedTokenIssuer#claim_attribute_path}.</summary>
            [JsiiProperty(name: "claimAttributePath", typeJson: "{\"primitive\":\"string\"}")]
            public string ClaimAttributePath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_trusted_token_issuer#identity_store_attribute_path SsoadminTrustedTokenIssuer#identity_store_attribute_path}.</summary>
            [JsiiProperty(name: "identityStoreAttributePath", typeJson: "{\"primitive\":\"string\"}")]
            public string IdentityStoreAttributePath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_trusted_token_issuer#issuer_url SsoadminTrustedTokenIssuer#issuer_url}.</summary>
            [JsiiProperty(name: "issuerUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string IssuerUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_trusted_token_issuer#jwks_retrieval_option SsoadminTrustedTokenIssuer#jwks_retrieval_option}.</summary>
            [JsiiProperty(name: "jwksRetrievalOption", typeJson: "{\"primitive\":\"string\"}")]
            public string JwksRetrievalOption
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
