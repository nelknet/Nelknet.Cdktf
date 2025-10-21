using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMobileNetworkDataNetwork
{
    [JsiiByValue(fqn: "azurerm.dataAzurermMobileNetworkDataNetwork.DataAzurermMobileNetworkDataNetworkTimeouts")]
    public class DataAzurermMobileNetworkDataNetworkTimeouts : azurerm.DataAzurermMobileNetworkDataNetwork.IDataAzurermMobileNetworkDataNetworkTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_data_network#read DataAzurermMobileNetworkDataNetwork#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
