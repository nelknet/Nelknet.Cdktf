using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDevTestVirtualNetwork
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDevTestVirtualNetwork.DataAzurermDevTestVirtualNetworkTimeouts")]
    public class DataAzurermDevTestVirtualNetworkTimeouts : azurerm.DataAzurermDevTestVirtualNetwork.IDataAzurermDevTestVirtualNetworkTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dev_test_virtual_network#read DataAzurermDevTestVirtualNetwork#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
