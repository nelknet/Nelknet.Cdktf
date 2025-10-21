using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccountLocalUser
{
    [JsiiInterface(nativeType: typeof(IStorageAccountLocalUserPermissionScope), fullyQualifiedName: "azurerm.storageAccountLocalUser.StorageAccountLocalUserPermissionScope")]
    public interface IStorageAccountLocalUserPermissionScope
    {
        /// <summary>permissions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_local_user#permissions StorageAccountLocalUser#permissions}
        /// </remarks>
        [JsiiProperty(name: "permissions", typeJson: "{\"fqn\":\"azurerm.storageAccountLocalUser.StorageAccountLocalUserPermissionScopePermissions\"}")]
        azurerm.StorageAccountLocalUser.IStorageAccountLocalUserPermissionScopePermissions Permissions
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_local_user#resource_name StorageAccountLocalUser#resource_name}.</summary>
        [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_local_user#service StorageAccountLocalUser#service}.</summary>
        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}")]
        string Service
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageAccountLocalUserPermissionScope), fullyQualifiedName: "azurerm.storageAccountLocalUser.StorageAccountLocalUserPermissionScope")]
        internal sealed class _Proxy : DeputyBase, azurerm.StorageAccountLocalUser.IStorageAccountLocalUserPermissionScope
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>permissions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_local_user#permissions StorageAccountLocalUser#permissions}
            /// </remarks>
            [JsiiProperty(name: "permissions", typeJson: "{\"fqn\":\"azurerm.storageAccountLocalUser.StorageAccountLocalUserPermissionScopePermissions\"}")]
            public azurerm.StorageAccountLocalUser.IStorageAccountLocalUserPermissionScopePermissions Permissions
            {
                get => GetInstanceProperty<azurerm.StorageAccountLocalUser.IStorageAccountLocalUserPermissionScopePermissions>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_local_user#resource_name StorageAccountLocalUser#resource_name}.</summary>
            [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_local_user#service StorageAccountLocalUser#service}.</summary>
            [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}")]
            public string Service
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
