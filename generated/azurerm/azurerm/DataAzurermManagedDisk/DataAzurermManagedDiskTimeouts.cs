using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermManagedDisk
{
    [JsiiByValue(fqn: "azurerm.dataAzurermManagedDisk.DataAzurermManagedDiskTimeouts")]
    public class DataAzurermManagedDiskTimeouts : azurerm.DataAzurermManagedDisk.IDataAzurermManagedDiskTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/managed_disk#read DataAzurermManagedDisk#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
