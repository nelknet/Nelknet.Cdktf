using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomainSamlOptions
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.opensearchDomainSamlOptions.OpensearchDomainSamlOptionsSamlOptionsIdp")]
    public class OpensearchDomainSamlOptionsSamlOptionsIdp : aws.OpensearchDomainSamlOptions.IOpensearchDomainSamlOptionsSamlOptionsIdp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#entity_id OpensearchDomainSamlOptions#entity_id}.</summary>
        [JsiiProperty(name: "entityId", typeJson: "{\"primitive\":\"string\"}")]
        public string EntityId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#metadata_content OpensearchDomainSamlOptions#metadata_content}.</summary>
        [JsiiProperty(name: "metadataContent", typeJson: "{\"primitive\":\"string\"}")]
        public string MetadataContent
        {
            get;
            set;
        }
    }
}
