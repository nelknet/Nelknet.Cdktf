using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDiskEncryptionSet
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDiskEncryptionSet.DataAzurermDiskEncryptionSetTimeouts")]
    public class DataAzurermDiskEncryptionSetTimeouts : azurerm.DataAzurermDiskEncryptionSet.IDataAzurermDiskEncryptionSetTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/disk_encryption_set#read DataAzurermDiskEncryptionSet#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
