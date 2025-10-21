using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetworkManagerNetworkGroup
{
    [JsiiByValue(fqn: "azurerm.dataAzurermNetworkManagerNetworkGroup.DataAzurermNetworkManagerNetworkGroupTimeouts")]
    public class DataAzurermNetworkManagerNetworkGroupTimeouts : azurerm.DataAzurermNetworkManagerNetworkGroup.IDataAzurermNetworkManagerNetworkGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_manager_network_group#read DataAzurermNetworkManagerNetworkGroup#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
