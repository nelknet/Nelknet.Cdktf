using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsoadminTrustedTokenIssuer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ssoadminTrustedTokenIssuer.SsoadminTrustedTokenIssuerTrustedTokenIssuerConfigurationOidcJwtConfiguration")]
    public class SsoadminTrustedTokenIssuerTrustedTokenIssuerConfigurationOidcJwtConfiguration : aws.SsoadminTrustedTokenIssuer.ISsoadminTrustedTokenIssuerTrustedTokenIssuerConfigurationOidcJwtConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_trusted_token_issuer#claim_attribute_path SsoadminTrustedTokenIssuer#claim_attribute_path}.</summary>
        [JsiiProperty(name: "claimAttributePath", typeJson: "{\"primitive\":\"string\"}")]
        public string ClaimAttributePath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_trusted_token_issuer#identity_store_attribute_path SsoadminTrustedTokenIssuer#identity_store_attribute_path}.</summary>
        [JsiiProperty(name: "identityStoreAttributePath", typeJson: "{\"primitive\":\"string\"}")]
        public string IdentityStoreAttributePath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_trusted_token_issuer#issuer_url SsoadminTrustedTokenIssuer#issuer_url}.</summary>
        [JsiiProperty(name: "issuerUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string IssuerUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_trusted_token_issuer#jwks_retrieval_option SsoadminTrustedTokenIssuer#jwks_retrieval_option}.</summary>
        [JsiiProperty(name: "jwksRetrievalOption", typeJson: "{\"primitive\":\"string\"}")]
        public string JwksRetrievalOption
        {
            get;
            set;
        }
    }
}
