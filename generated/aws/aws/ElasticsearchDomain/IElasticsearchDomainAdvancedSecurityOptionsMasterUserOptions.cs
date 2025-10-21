using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticsearchDomain
{
    [JsiiInterface(nativeType: typeof(IElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions), fullyQualifiedName: "aws.elasticsearchDomain.ElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions")]
    public interface IElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#master_user_arn ElasticsearchDomain#master_user_arn}.</summary>
        [JsiiProperty(name: "masterUserArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MasterUserArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#master_user_name ElasticsearchDomain#master_user_name}.</summary>
        [JsiiProperty(name: "masterUserName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MasterUserName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#master_user_password ElasticsearchDomain#master_user_password}.</summary>
        [JsiiProperty(name: "masterUserPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MasterUserPassword
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions), fullyQualifiedName: "aws.elasticsearchDomain.ElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions")]
        internal sealed class _Proxy : DeputyBase, aws.ElasticsearchDomain.IElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#master_user_arn ElasticsearchDomain#master_user_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "masterUserArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MasterUserArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#master_user_name ElasticsearchDomain#master_user_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "masterUserName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MasterUserName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#master_user_password ElasticsearchDomain#master_user_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "masterUserPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MasterUserPassword
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
