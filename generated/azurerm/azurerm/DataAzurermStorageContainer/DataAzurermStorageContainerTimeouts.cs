using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStorageContainer
{
    [JsiiByValue(fqn: "azurerm.dataAzurermStorageContainer.DataAzurermStorageContainerTimeouts")]
    public class DataAzurermStorageContainerTimeouts : azurerm.DataAzurermStorageContainer.IDataAzurermStorageContainerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_container#read DataAzurermStorageContainer#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
