using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMobileNetworkSite
{
    [JsiiByValue(fqn: "azurerm.dataAzurermMobileNetworkSite.DataAzurermMobileNetworkSiteTimeouts")]
    public class DataAzurermMobileNetworkSiteTimeouts : azurerm.DataAzurermMobileNetworkSite.IDataAzurermMobileNetworkSiteTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_site#read DataAzurermMobileNetworkSite#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
