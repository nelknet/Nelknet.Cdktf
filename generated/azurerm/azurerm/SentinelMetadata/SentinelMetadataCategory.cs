using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SentinelMetadata
{
    [JsiiByValue(fqn: "azurerm.sentinelMetadata.SentinelMetadataCategory")]
    public class SentinelMetadataCategory : azurerm.SentinelMetadata.ISentinelMetadataCategory
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata#domains SentinelMetadata#domains}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Domains
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata#verticals SentinelMetadata#verticals}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "verticals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Verticals
        {
            get;
            set;
        }
    }
}
