using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccountLocalUser
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.storageAccountLocalUser.StorageAccountLocalUserSshAuthorizedKey")]
    public class StorageAccountLocalUserSshAuthorizedKey : azurerm.StorageAccountLocalUser.IStorageAccountLocalUserSshAuthorizedKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_local_user#key StorageAccountLocalUser#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_local_user#description StorageAccountLocalUser#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }
    }
}
