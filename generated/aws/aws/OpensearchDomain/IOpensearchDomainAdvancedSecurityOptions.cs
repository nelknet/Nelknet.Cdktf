using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiInterface(nativeType: typeof(IOpensearchDomainAdvancedSecurityOptions), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainAdvancedSecurityOptions")]
    public interface IOpensearchDomainAdvancedSecurityOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#enabled OpensearchDomain#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#anonymous_auth_enabled OpensearchDomain#anonymous_auth_enabled}.</summary>
        [JsiiProperty(name: "anonymousAuthEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AnonymousAuthEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#internal_user_database_enabled OpensearchDomain#internal_user_database_enabled}.</summary>
        [JsiiProperty(name: "internalUserDatabaseEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InternalUserDatabaseEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>master_user_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#master_user_options OpensearchDomain#master_user_options}
        /// </remarks>
        [JsiiProperty(name: "masterUserOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAdvancedSecurityOptionsMasterUserOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpensearchDomain.IOpensearchDomainAdvancedSecurityOptionsMasterUserOptions? MasterUserOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchDomainAdvancedSecurityOptions), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainAdvancedSecurityOptions")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchDomain.IOpensearchDomainAdvancedSecurityOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#enabled OpensearchDomain#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#anonymous_auth_enabled OpensearchDomain#anonymous_auth_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "anonymousAuthEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AnonymousAuthEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#internal_user_database_enabled OpensearchDomain#internal_user_database_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "internalUserDatabaseEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? InternalUserDatabaseEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>master_user_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#master_user_options OpensearchDomain#master_user_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "masterUserOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAdvancedSecurityOptionsMasterUserOptions\"}", isOptional: true)]
            public aws.OpensearchDomain.IOpensearchDomainAdvancedSecurityOptionsMasterUserOptions? MasterUserOptions
            {
                get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainAdvancedSecurityOptionsMasterUserOptions?>();
            }
        }
    }
}
