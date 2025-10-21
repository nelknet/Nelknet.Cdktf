using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticsearchDomain
{
    [JsiiInterface(nativeType: typeof(IElasticsearchDomainAdvancedSecurityOptions), fullyQualifiedName: "aws.elasticsearchDomain.ElasticsearchDomainAdvancedSecurityOptions")]
    public interface IElasticsearchDomainAdvancedSecurityOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#enabled ElasticsearchDomain#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#internal_user_database_enabled ElasticsearchDomain#internal_user_database_enabled}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#master_user_options ElasticsearchDomain#master_user_options}
        /// </remarks>
        [JsiiProperty(name: "masterUserOptions", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ElasticsearchDomain.IElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions? MasterUserOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticsearchDomainAdvancedSecurityOptions), fullyQualifiedName: "aws.elasticsearchDomain.ElasticsearchDomainAdvancedSecurityOptions")]
        internal sealed class _Proxy : DeputyBase, aws.ElasticsearchDomain.IElasticsearchDomainAdvancedSecurityOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#enabled ElasticsearchDomain#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#internal_user_database_enabled ElasticsearchDomain#internal_user_database_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "internalUserDatabaseEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? InternalUserDatabaseEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>master_user_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#master_user_options ElasticsearchDomain#master_user_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "masterUserOptions", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions\"}", isOptional: true)]
            public aws.ElasticsearchDomain.IElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions? MasterUserOptions
            {
                get => GetInstanceProperty<aws.ElasticsearchDomain.IElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions?>();
            }
        }
    }
}
