using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksIdentityProviderConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.eksIdentityProviderConfig.EksIdentityProviderConfigOidc")]
    public class EksIdentityProviderConfigOidc : aws.EksIdentityProviderConfig.IEksIdentityProviderConfigOidc
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#client_id EksIdentityProviderConfig#client_id}.</summary>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public string ClientId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#identity_provider_config_name EksIdentityProviderConfig#identity_provider_config_name}.</summary>
        [JsiiProperty(name: "identityProviderConfigName", typeJson: "{\"primitive\":\"string\"}")]
        public string IdentityProviderConfigName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#issuer_url EksIdentityProviderConfig#issuer_url}.</summary>
        [JsiiProperty(name: "issuerUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string IssuerUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#groups_claim EksIdentityProviderConfig#groups_claim}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupsClaim", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GroupsClaim
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#groups_prefix EksIdentityProviderConfig#groups_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupsPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GroupsPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#required_claims EksIdentityProviderConfig#required_claims}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requiredClaims", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? RequiredClaims
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#username_claim EksIdentityProviderConfig#username_claim}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "usernameClaim", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UsernameClaim
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#username_prefix EksIdentityProviderConfig#username_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "usernamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UsernamePrefix
        {
            get;
            set;
        }
    }
}
