using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksIdentityProviderConfig
{
    [JsiiInterface(nativeType: typeof(IEksIdentityProviderConfigOidc), fullyQualifiedName: "aws.eksIdentityProviderConfig.EksIdentityProviderConfigOidc")]
    public interface IEksIdentityProviderConfigOidc
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#client_id EksIdentityProviderConfig#client_id}.</summary>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        string ClientId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#identity_provider_config_name EksIdentityProviderConfig#identity_provider_config_name}.</summary>
        [JsiiProperty(name: "identityProviderConfigName", typeJson: "{\"primitive\":\"string\"}")]
        string IdentityProviderConfigName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#issuer_url EksIdentityProviderConfig#issuer_url}.</summary>
        [JsiiProperty(name: "issuerUrl", typeJson: "{\"primitive\":\"string\"}")]
        string IssuerUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#groups_claim EksIdentityProviderConfig#groups_claim}.</summary>
        [JsiiProperty(name: "groupsClaim", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GroupsClaim
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#groups_prefix EksIdentityProviderConfig#groups_prefix}.</summary>
        [JsiiProperty(name: "groupsPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GroupsPrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#required_claims EksIdentityProviderConfig#required_claims}.</summary>
        [JsiiProperty(name: "requiredClaims", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? RequiredClaims
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#username_claim EksIdentityProviderConfig#username_claim}.</summary>
        [JsiiProperty(name: "usernameClaim", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UsernameClaim
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#username_prefix EksIdentityProviderConfig#username_prefix}.</summary>
        [JsiiProperty(name: "usernamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UsernamePrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksIdentityProviderConfigOidc), fullyQualifiedName: "aws.eksIdentityProviderConfig.EksIdentityProviderConfigOidc")]
        internal sealed class _Proxy : DeputyBase, aws.EksIdentityProviderConfig.IEksIdentityProviderConfigOidc
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#client_id EksIdentityProviderConfig#client_id}.</summary>
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#identity_provider_config_name EksIdentityProviderConfig#identity_provider_config_name}.</summary>
            [JsiiProperty(name: "identityProviderConfigName", typeJson: "{\"primitive\":\"string\"}")]
            public string IdentityProviderConfigName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#issuer_url EksIdentityProviderConfig#issuer_url}.</summary>
            [JsiiProperty(name: "issuerUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string IssuerUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#groups_claim EksIdentityProviderConfig#groups_claim}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "groupsClaim", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GroupsClaim
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#groups_prefix EksIdentityProviderConfig#groups_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "groupsPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GroupsPrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#required_claims EksIdentityProviderConfig#required_claims}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requiredClaims", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? RequiredClaims
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#username_claim EksIdentityProviderConfig#username_claim}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "usernameClaim", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UsernameClaim
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#username_prefix EksIdentityProviderConfig#username_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "usernamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UsernamePrefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
