using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVirtualHubConnection
{
    [JsiiByValue(fqn: "azurerm.dataAzurermVirtualHubConnection.DataAzurermVirtualHubConnectionTimeouts")]
    public class DataAzurermVirtualHubConnectionTimeouts : azurerm.DataAzurermVirtualHubConnection.IDataAzurermVirtualHubConnectionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_hub_connection#read DataAzurermVirtualHubConnection#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
