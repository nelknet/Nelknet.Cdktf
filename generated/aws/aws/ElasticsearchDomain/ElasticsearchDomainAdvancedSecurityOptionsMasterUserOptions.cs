using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticsearchDomain
{
    [JsiiByValue(fqn: "aws.elasticsearchDomain.ElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions")]
    public class ElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions : aws.ElasticsearchDomain.IElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#master_user_arn ElasticsearchDomain#master_user_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "masterUserArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MasterUserArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#master_user_name ElasticsearchDomain#master_user_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "masterUserName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MasterUserName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#master_user_password ElasticsearchDomain#master_user_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "masterUserPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MasterUserPassword
        {
            get;
            set;
        }
    }
}
