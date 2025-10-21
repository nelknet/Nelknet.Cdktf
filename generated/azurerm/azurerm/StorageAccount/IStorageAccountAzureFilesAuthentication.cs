using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    [JsiiInterface(nativeType: typeof(IStorageAccountAzureFilesAuthentication), fullyQualifiedName: "azurerm.storageAccount.StorageAccountAzureFilesAuthentication")]
    public interface IStorageAccountAzureFilesAuthentication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#directory_type StorageAccount#directory_type}.</summary>
        [JsiiProperty(name: "directoryType", typeJson: "{\"primitive\":\"string\"}")]
        string DirectoryType
        {
            get;
        }

        /// <summary>active_directory block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#active_directory StorageAccount#active_directory}
        /// </remarks>
        [JsiiProperty(name: "activeDirectory", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountAzureFilesAuthenticationActiveDirectory\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StorageAccount.IStorageAccountAzureFilesAuthenticationActiveDirectory? ActiveDirectory
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#default_share_level_permission StorageAccount#default_share_level_permission}.</summary>
        [JsiiProperty(name: "defaultShareLevelPermission", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultShareLevelPermission
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageAccountAzureFilesAuthentication), fullyQualifiedName: "azurerm.storageAccount.StorageAccountAzureFilesAuthentication")]
        internal sealed class _Proxy : DeputyBase, azurerm.StorageAccount.IStorageAccountAzureFilesAuthentication
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#directory_type StorageAccount#directory_type}.</summary>
            [JsiiProperty(name: "directoryType", typeJson: "{\"primitive\":\"string\"}")]
            public string DirectoryType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>active_directory block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#active_directory StorageAccount#active_directory}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "activeDirectory", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountAzureFilesAuthenticationActiveDirectory\"}", isOptional: true)]
            public azurerm.StorageAccount.IStorageAccountAzureFilesAuthenticationActiveDirectory? ActiveDirectory
            {
                get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountAzureFilesAuthenticationActiveDirectory?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#default_share_level_permission StorageAccount#default_share_level_permission}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultShareLevelPermission", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultShareLevelPermission
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
