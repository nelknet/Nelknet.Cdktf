using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Image
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.image.ImageDataDisk")]
    public class ImageDataDisk : azurerm.Image.IImageDataDisk
    {
        /// <summary>The type of storage disk.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/image#storage_type Image#storage_type}
        /// </remarks>
        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}")]
        public string StorageType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/image#blob_uri Image#blob_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blobUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BlobUri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/image#caching Image#caching}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "caching", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Caching
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/image#disk_encryption_set_id Image#disk_encryption_set_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "diskEncryptionSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DiskEncryptionSetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/image#lun Image#lun}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lun", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Lun
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/image#managed_disk_id Image#managed_disk_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "managedDiskId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ManagedDiskId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/image#size_gb Image#size_gb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sizeGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SizeGb
        {
            get;
            set;
        }
    }
}
