using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    [JsiiByValue(fqn: "azurerm.storageAccount.StorageAccountStaticWebsite")]
    public class StorageAccountStaticWebsite : azurerm.StorageAccount.IStorageAccountStaticWebsite
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#error_404_document StorageAccount#error_404_document}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "error404Document", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Error404Document
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#index_document StorageAccount#index_document}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "indexDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IndexDocument
        {
            get;
            set;
        }
    }
}
