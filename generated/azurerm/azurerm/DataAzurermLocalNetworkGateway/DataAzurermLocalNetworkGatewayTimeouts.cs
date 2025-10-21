using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLocalNetworkGateway
{
    [JsiiByValue(fqn: "azurerm.dataAzurermLocalNetworkGateway.DataAzurermLocalNetworkGatewayTimeouts")]
    public class DataAzurermLocalNetworkGatewayTimeouts : azurerm.DataAzurermLocalNetworkGateway.IDataAzurermLocalNetworkGatewayTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/local_network_gateway#read DataAzurermLocalNetworkGateway#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
