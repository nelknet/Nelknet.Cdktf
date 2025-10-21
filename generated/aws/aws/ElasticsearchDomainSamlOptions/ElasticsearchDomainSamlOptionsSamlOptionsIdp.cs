using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticsearchDomainSamlOptions
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elasticsearchDomainSamlOptions.ElasticsearchDomainSamlOptionsSamlOptionsIdp")]
    public class ElasticsearchDomainSamlOptionsSamlOptionsIdp : aws.ElasticsearchDomainSamlOptions.IElasticsearchDomainSamlOptionsSamlOptionsIdp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain_saml_options#entity_id ElasticsearchDomainSamlOptions#entity_id}.</summary>
        [JsiiProperty(name: "entityId", typeJson: "{\"primitive\":\"string\"}")]
        public string EntityId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain_saml_options#metadata_content ElasticsearchDomainSamlOptions#metadata_content}.</summary>
        [JsiiProperty(name: "metadataContent", typeJson: "{\"primitive\":\"string\"}")]
        public string MetadataContent
        {
            get;
            set;
        }
    }
}
