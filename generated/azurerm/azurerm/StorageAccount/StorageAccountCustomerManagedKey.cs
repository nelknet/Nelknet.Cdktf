using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.storageAccount.StorageAccountCustomerManagedKey")]
    public class StorageAccountCustomerManagedKey : azurerm.StorageAccount.IStorageAccountCustomerManagedKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#user_assigned_identity_id StorageAccount#user_assigned_identity_id}.</summary>
        [JsiiProperty(name: "userAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}")]
        public string UserAssignedIdentityId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#key_vault_key_id StorageAccount#key_vault_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyVaultKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyVaultKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#managed_hsm_key_id StorageAccount#managed_hsm_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "managedHsmKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ManagedHsmKeyId
        {
            get;
            set;
        }
    }
}
