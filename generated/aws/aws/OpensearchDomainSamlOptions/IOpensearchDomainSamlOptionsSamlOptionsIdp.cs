using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomainSamlOptions
{
    [JsiiInterface(nativeType: typeof(IOpensearchDomainSamlOptionsSamlOptionsIdp), fullyQualifiedName: "aws.opensearchDomainSamlOptions.OpensearchDomainSamlOptionsSamlOptionsIdp")]
    public interface IOpensearchDomainSamlOptionsSamlOptionsIdp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#entity_id OpensearchDomainSamlOptions#entity_id}.</summary>
        [JsiiProperty(name: "entityId", typeJson: "{\"primitive\":\"string\"}")]
        string EntityId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#metadata_content OpensearchDomainSamlOptions#metadata_content}.</summary>
        [JsiiProperty(name: "metadataContent", typeJson: "{\"primitive\":\"string\"}")]
        string MetadataContent
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchDomainSamlOptionsSamlOptionsIdp), fullyQualifiedName: "aws.opensearchDomainSamlOptions.OpensearchDomainSamlOptionsSamlOptionsIdp")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchDomainSamlOptions.IOpensearchDomainSamlOptionsSamlOptionsIdp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#entity_id OpensearchDomainSamlOptions#entity_id}.</summary>
            [JsiiProperty(name: "entityId", typeJson: "{\"primitive\":\"string\"}")]
            public string EntityId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#metadata_content OpensearchDomainSamlOptions#metadata_content}.</summary>
            [JsiiProperty(name: "metadataContent", typeJson: "{\"primitive\":\"string\"}")]
            public string MetadataContent
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
