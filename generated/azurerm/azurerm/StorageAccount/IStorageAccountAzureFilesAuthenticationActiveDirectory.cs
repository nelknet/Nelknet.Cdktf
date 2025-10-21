using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    [JsiiInterface(nativeType: typeof(IStorageAccountAzureFilesAuthenticationActiveDirectory), fullyQualifiedName: "azurerm.storageAccount.StorageAccountAzureFilesAuthenticationActiveDirectory")]
    public interface IStorageAccountAzureFilesAuthenticationActiveDirectory
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#domain_guid StorageAccount#domain_guid}.</summary>
        [JsiiProperty(name: "domainGuid", typeJson: "{\"primitive\":\"string\"}")]
        string DomainGuid
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#domain_name StorageAccount#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        string DomainName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#domain_sid StorageAccount#domain_sid}.</summary>
        [JsiiProperty(name: "domainSid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DomainSid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#forest_name StorageAccount#forest_name}.</summary>
        [JsiiProperty(name: "forestName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ForestName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#netbios_domain_name StorageAccount#netbios_domain_name}.</summary>
        [JsiiProperty(name: "netbiosDomainName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NetbiosDomainName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#storage_sid StorageAccount#storage_sid}.</summary>
        [JsiiProperty(name: "storageSid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageSid
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageAccountAzureFilesAuthenticationActiveDirectory), fullyQualifiedName: "azurerm.storageAccount.StorageAccountAzureFilesAuthenticationActiveDirectory")]
        internal sealed class _Proxy : DeputyBase, azurerm.StorageAccount.IStorageAccountAzureFilesAuthenticationActiveDirectory
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#domain_guid StorageAccount#domain_guid}.</summary>
            [JsiiProperty(name: "domainGuid", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainGuid
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#domain_name StorageAccount#domain_name}.</summary>
            [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#domain_sid StorageAccount#domain_sid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "domainSid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DomainSid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#forest_name StorageAccount#forest_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "forestName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ForestName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#netbios_domain_name StorageAccount#netbios_domain_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "netbiosDomainName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NetbiosDomainName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#storage_sid StorageAccount#storage_sid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageSid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageSid
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
