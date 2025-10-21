using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStorageTableEntity
{
    [JsiiByValue(fqn: "azurerm.dataAzurermStorageTableEntity.DataAzurermStorageTableEntityTimeouts")]
    public class DataAzurermStorageTableEntityTimeouts : azurerm.DataAzurermStorageTableEntity.IDataAzurermStorageTableEntityTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_table_entity#read DataAzurermStorageTableEntity#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
