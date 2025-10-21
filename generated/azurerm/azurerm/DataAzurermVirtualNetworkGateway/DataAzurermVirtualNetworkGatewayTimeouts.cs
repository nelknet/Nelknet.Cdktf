using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVirtualNetworkGateway
{
    [JsiiByValue(fqn: "azurerm.dataAzurermVirtualNetworkGateway.DataAzurermVirtualNetworkGatewayTimeouts")]
    public class DataAzurermVirtualNetworkGatewayTimeouts : azurerm.DataAzurermVirtualNetworkGateway.IDataAzurermVirtualNetworkGatewayTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_network_gateway#read DataAzurermVirtualNetworkGateway#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
