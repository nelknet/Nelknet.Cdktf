using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Eventhub
{
    [JsiiInterface(nativeType: typeof(IEventhubCaptureDescriptionDestination), fullyQualifiedName: "azurerm.eventhub.EventhubCaptureDescriptionDestination")]
    public interface IEventhubCaptureDescriptionDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub#archive_name_format Eventhub#archive_name_format}.</summary>
        [JsiiProperty(name: "archiveNameFormat", typeJson: "{\"primitive\":\"string\"}")]
        string ArchiveNameFormat
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub#blob_container_name Eventhub#blob_container_name}.</summary>
        [JsiiProperty(name: "blobContainerName", typeJson: "{\"primitive\":\"string\"}")]
        string BlobContainerName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub#name Eventhub#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub#storage_account_id Eventhub#storage_account_id}.</summary>
        [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}")]
        string StorageAccountId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEventhubCaptureDescriptionDestination), fullyQualifiedName: "azurerm.eventhub.EventhubCaptureDescriptionDestination")]
        internal sealed class _Proxy : DeputyBase, azurerm.Eventhub.IEventhubCaptureDescriptionDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub#archive_name_format Eventhub#archive_name_format}.</summary>
            [JsiiProperty(name: "archiveNameFormat", typeJson: "{\"primitive\":\"string\"}")]
            public string ArchiveNameFormat
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub#blob_container_name Eventhub#blob_container_name}.</summary>
            [JsiiProperty(name: "blobContainerName", typeJson: "{\"primitive\":\"string\"}")]
            public string BlobContainerName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub#name Eventhub#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub#storage_account_id Eventhub#storage_account_id}.</summary>
            [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageAccountId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
