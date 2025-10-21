using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Eventhub
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.eventhub.EventhubCaptureDescriptionDestination")]
    public class EventhubCaptureDescriptionDestination : azurerm.Eventhub.IEventhubCaptureDescriptionDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub#archive_name_format Eventhub#archive_name_format}.</summary>
        [JsiiProperty(name: "archiveNameFormat", typeJson: "{\"primitive\":\"string\"}")]
        public string ArchiveNameFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub#blob_container_name Eventhub#blob_container_name}.</summary>
        [JsiiProperty(name: "blobContainerName", typeJson: "{\"primitive\":\"string\"}")]
        public string BlobContainerName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub#name Eventhub#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub#storage_account_id Eventhub#storage_account_id}.</summary>
        [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public string StorageAccountId
        {
            get;
            set;
        }
    }
}
