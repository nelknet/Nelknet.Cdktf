using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageTable
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.storageTable.StorageTableAclAccessPolicy")]
    public class StorageTableAclAccessPolicy : azurerm.StorageTable.IStorageTableAclAccessPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_table#expiry StorageTable#expiry}.</summary>
        [JsiiProperty(name: "expiry", typeJson: "{\"primitive\":\"string\"}")]
        public string Expiry
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_table#permissions StorageTable#permissions}.</summary>
        [JsiiProperty(name: "permissions", typeJson: "{\"primitive\":\"string\"}")]
        public string Permissions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_table#start StorageTable#start}.</summary>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}")]
        public string Start
        {
            get;
            set;
        }
    }
}
