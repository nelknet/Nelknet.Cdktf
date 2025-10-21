using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStorageShare
{
    [JsiiByValue(fqn: "azurerm.dataAzurermStorageShare.DataAzurermStorageShareTimeouts")]
    public class DataAzurermStorageShareTimeouts : azurerm.DataAzurermStorageShare.IDataAzurermStorageShareTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_share#read DataAzurermStorageShare#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
