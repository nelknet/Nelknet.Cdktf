using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccountLocalUser
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.storageAccountLocalUser.StorageAccountLocalUserPermissionScope")]
    public class StorageAccountLocalUserPermissionScope : azurerm.StorageAccountLocalUser.IStorageAccountLocalUserPermissionScope
    {
        /// <summary>permissions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_local_user#permissions StorageAccountLocalUser#permissions}
        /// </remarks>
        [JsiiProperty(name: "permissions", typeJson: "{\"fqn\":\"azurerm.storageAccountLocalUser.StorageAccountLocalUserPermissionScopePermissions\"}")]
        public azurerm.StorageAccountLocalUser.IStorageAccountLocalUserPermissionScopePermissions Permissions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_local_user#resource_name StorageAccountLocalUser#resource_name}.</summary>
        [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_local_user#service StorageAccountLocalUser#service}.</summary>
        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}")]
        public string Service
        {
            get;
            set;
        }
    }
}
