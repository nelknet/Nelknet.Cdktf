using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticsearchDomainSamlOptions
{
    [JsiiInterface(nativeType: typeof(IElasticsearchDomainSamlOptionsSamlOptionsIdp), fullyQualifiedName: "aws.elasticsearchDomainSamlOptions.ElasticsearchDomainSamlOptionsSamlOptionsIdp")]
    public interface IElasticsearchDomainSamlOptionsSamlOptionsIdp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain_saml_options#entity_id ElasticsearchDomainSamlOptions#entity_id}.</summary>
        [JsiiProperty(name: "entityId", typeJson: "{\"primitive\":\"string\"}")]
        string EntityId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain_saml_options#metadata_content ElasticsearchDomainSamlOptions#metadata_content}.</summary>
        [JsiiProperty(name: "metadataContent", typeJson: "{\"primitive\":\"string\"}")]
        string MetadataContent
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticsearchDomainSamlOptionsSamlOptionsIdp), fullyQualifiedName: "aws.elasticsearchDomainSamlOptions.ElasticsearchDomainSamlOptionsSamlOptionsIdp")]
        internal sealed class _Proxy : DeputyBase, aws.ElasticsearchDomainSamlOptions.IElasticsearchDomainSamlOptionsSamlOptionsIdp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain_saml_options#entity_id ElasticsearchDomainSamlOptions#entity_id}.</summary>
            [JsiiProperty(name: "entityId", typeJson: "{\"primitive\":\"string\"}")]
            public string EntityId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain_saml_options#metadata_content ElasticsearchDomainSamlOptions#metadata_content}.</summary>
            [JsiiProperty(name: "metadataContent", typeJson: "{\"primitive\":\"string\"}")]
            public string MetadataContent
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
