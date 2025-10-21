using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVirtualWan
{
    [JsiiByValue(fqn: "azurerm.dataAzurermVirtualWan.DataAzurermVirtualWanTimeouts")]
    public class DataAzurermVirtualWanTimeouts : azurerm.DataAzurermVirtualWan.IDataAzurermVirtualWanTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_wan#read DataAzurermVirtualWan#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
