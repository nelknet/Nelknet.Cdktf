using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    [JsiiInterface(nativeType: typeof(IStorageAccountStaticWebsite), fullyQualifiedName: "azurerm.storageAccount.StorageAccountStaticWebsite")]
    public interface IStorageAccountStaticWebsite
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#error_404_document StorageAccount#error_404_document}.</summary>
        [JsiiProperty(name: "error404Document", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Error404Document
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#index_document StorageAccount#index_document}.</summary>
        [JsiiProperty(name: "indexDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IndexDocument
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageAccountStaticWebsite), fullyQualifiedName: "azurerm.storageAccount.StorageAccountStaticWebsite")]
        internal sealed class _Proxy : DeputyBase, azurerm.StorageAccount.IStorageAccountStaticWebsite
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#error_404_document StorageAccount#error_404_document}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "error404Document", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Error404Document
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#index_document StorageAccount#index_document}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "indexDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IndexDocument
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
