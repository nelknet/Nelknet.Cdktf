using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermContainerApp
{
    [JsiiByValue(fqn: "azurerm.dataAzurermContainerApp.DataAzurermContainerAppTimeouts")]
    public class DataAzurermContainerAppTimeouts : azurerm.DataAzurermContainerApp.IDataAzurermContainerAppTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_app#read DataAzurermContainerApp#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
