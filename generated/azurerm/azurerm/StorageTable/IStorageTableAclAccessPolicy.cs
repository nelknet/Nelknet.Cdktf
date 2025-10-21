using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageTable
{
    [JsiiInterface(nativeType: typeof(IStorageTableAclAccessPolicy), fullyQualifiedName: "azurerm.storageTable.StorageTableAclAccessPolicy")]
    public interface IStorageTableAclAccessPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_table#expiry StorageTable#expiry}.</summary>
        [JsiiProperty(name: "expiry", typeJson: "{\"primitive\":\"string\"}")]
        string Expiry
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_table#permissions StorageTable#permissions}.</summary>
        [JsiiProperty(name: "permissions", typeJson: "{\"primitive\":\"string\"}")]
        string Permissions
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_table#start StorageTable#start}.</summary>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}")]
        string Start
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageTableAclAccessPolicy), fullyQualifiedName: "azurerm.storageTable.StorageTableAclAccessPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.StorageTable.IStorageTableAclAccessPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_table#expiry StorageTable#expiry}.</summary>
            [JsiiProperty(name: "expiry", typeJson: "{\"primitive\":\"string\"}")]
            public string Expiry
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_table#permissions StorageTable#permissions}.</summary>
            [JsiiProperty(name: "permissions", typeJson: "{\"primitive\":\"string\"}")]
            public string Permissions
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_table#start StorageTable#start}.</summary>
            [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}")]
            public string Start
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
