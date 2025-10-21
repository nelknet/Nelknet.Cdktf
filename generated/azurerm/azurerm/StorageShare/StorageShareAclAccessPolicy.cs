using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageShare
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.storageShare.StorageShareAclAccessPolicy")]
    public class StorageShareAclAccessPolicy : azurerm.StorageShare.IStorageShareAclAccessPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share#permissions StorageShare#permissions}.</summary>
        [JsiiProperty(name: "permissions", typeJson: "{\"primitive\":\"string\"}")]
        public string Permissions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share#expiry StorageShare#expiry}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expiry", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Expiry
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share#start StorageShare#start}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Start
        {
            get;
            set;
        }
    }
}
