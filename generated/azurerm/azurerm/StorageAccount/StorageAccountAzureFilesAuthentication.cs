using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.storageAccount.StorageAccountAzureFilesAuthentication")]
    public class StorageAccountAzureFilesAuthentication : azurerm.StorageAccount.IStorageAccountAzureFilesAuthentication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#directory_type StorageAccount#directory_type}.</summary>
        [JsiiProperty(name: "directoryType", typeJson: "{\"primitive\":\"string\"}")]
        public string DirectoryType
        {
            get;
            set;
        }

        /// <summary>active_directory block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#active_directory StorageAccount#active_directory}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "activeDirectory", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountAzureFilesAuthenticationActiveDirectory\"}", isOptional: true)]
        public azurerm.StorageAccount.IStorageAccountAzureFilesAuthenticationActiveDirectory? ActiveDirectory
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#default_share_level_permission StorageAccount#default_share_level_permission}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultShareLevelPermission", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultShareLevelPermission
        {
            get;
            set;
        }
    }
}
