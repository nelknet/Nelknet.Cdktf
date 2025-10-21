using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraIndex
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kendraIndex.KendraIndexDocumentMetadataConfigurationUpdates")]
    public class KendraIndexDocumentMetadataConfigurationUpdates : aws.KendraIndex.IKendraIndexDocumentMetadataConfigurationUpdates
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#name KendraIndex#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#type KendraIndex#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>relevance block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#relevance KendraIndex#relevance}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "relevance", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexDocumentMetadataConfigurationUpdatesRelevance\"}", isOptional: true)]
        public aws.KendraIndex.IKendraIndexDocumentMetadataConfigurationUpdatesRelevance? Relevance
        {
            get;
            set;
        }

        /// <summary>search block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#search KendraIndex#search}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "search", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexDocumentMetadataConfigurationUpdatesSearch\"}", isOptional: true)]
        public aws.KendraIndex.IKendraIndexDocumentMetadataConfigurationUpdatesSearch? Search
        {
            get;
            set;
        }
    }
}
