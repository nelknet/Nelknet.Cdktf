using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedLustreFileSystem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.managedLustreFileSystem.ManagedLustreFileSystemEncryptionKey")]
    public class ManagedLustreFileSystemEncryptionKey : azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemEncryptionKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system#key_url ManagedLustreFileSystem#key_url}.</summary>
        [JsiiProperty(name: "keyUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system#source_vault_id ManagedLustreFileSystem#source_vault_id}.</summary>
        [JsiiProperty(name: "sourceVaultId", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceVaultId
        {
            get;
            set;
        }
    }
}
