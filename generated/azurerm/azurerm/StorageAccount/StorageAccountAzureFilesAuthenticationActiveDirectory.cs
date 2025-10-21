using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.storageAccount.StorageAccountAzureFilesAuthenticationActiveDirectory")]
    public class StorageAccountAzureFilesAuthenticationActiveDirectory : azurerm.StorageAccount.IStorageAccountAzureFilesAuthenticationActiveDirectory
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#domain_guid StorageAccount#domain_guid}.</summary>
        [JsiiProperty(name: "domainGuid", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainGuid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#domain_name StorageAccount#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#domain_sid StorageAccount#domain_sid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domainSid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DomainSid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#forest_name StorageAccount#forest_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "forestName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ForestName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#netbios_domain_name StorageAccount#netbios_domain_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netbiosDomainName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetbiosDomainName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#storage_sid StorageAccount#storage_sid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageSid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageSid
        {
            get;
            set;
        }
    }
}
