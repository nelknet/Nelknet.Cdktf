using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStorageEncryptionScope
{
    [JsiiByValue(fqn: "azurerm.dataAzurermStorageEncryptionScope.DataAzurermStorageEncryptionScopeTimeouts")]
    public class DataAzurermStorageEncryptionScopeTimeouts : azurerm.DataAzurermStorageEncryptionScope.IDataAzurermStorageEncryptionScopeTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_encryption_scope#read DataAzurermStorageEncryptionScope#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
