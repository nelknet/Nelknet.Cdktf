using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVirtualHubRouteTable
{
    [JsiiByValue(fqn: "azurerm.dataAzurermVirtualHubRouteTable.DataAzurermVirtualHubRouteTableTimeouts")]
    public class DataAzurermVirtualHubRouteTableTimeouts : azurerm.DataAzurermVirtualHubRouteTable.IDataAzurermVirtualHubRouteTableTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_hub_route_table#read DataAzurermVirtualHubRouteTable#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
