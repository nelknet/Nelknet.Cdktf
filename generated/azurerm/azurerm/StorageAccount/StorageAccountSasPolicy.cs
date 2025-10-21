using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.storageAccount.StorageAccountSasPolicy")]
    public class StorageAccountSasPolicy : azurerm.StorageAccount.IStorageAccountSasPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#expiration_period StorageAccount#expiration_period}.</summary>
        [JsiiProperty(name: "expirationPeriod", typeJson: "{\"primitive\":\"string\"}")]
        public string ExpirationPeriod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#expiration_action StorageAccount#expiration_action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expirationAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExpirationAction
        {
            get;
            set;
        }
    }
}
