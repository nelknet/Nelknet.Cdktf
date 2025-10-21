using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetworkServiceTags
{
    [JsiiByValue(fqn: "azurerm.dataAzurermNetworkServiceTags.DataAzurermNetworkServiceTagsTimeouts")]
    public class DataAzurermNetworkServiceTagsTimeouts : azurerm.DataAzurermNetworkServiceTags.IDataAzurermNetworkServiceTagsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_service_tags#read DataAzurermNetworkServiceTags#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
