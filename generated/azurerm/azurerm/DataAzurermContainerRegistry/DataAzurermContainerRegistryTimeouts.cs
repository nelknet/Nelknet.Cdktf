using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermContainerRegistry
{
    [JsiiByValue(fqn: "azurerm.dataAzurermContainerRegistry.DataAzurermContainerRegistryTimeouts")]
    public class DataAzurermContainerRegistryTimeouts : azurerm.DataAzurermContainerRegistry.IDataAzurermContainerRegistryTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry#read DataAzurermContainerRegistry#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
