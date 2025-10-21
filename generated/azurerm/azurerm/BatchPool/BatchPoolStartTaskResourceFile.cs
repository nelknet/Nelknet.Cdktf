using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiByValue(fqn: "azurerm.batchPool.BatchPoolStartTaskResourceFile")]
    public class BatchPoolStartTaskResourceFile : azurerm.BatchPool.IBatchPoolStartTaskResourceFile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#auto_storage_container_name BatchPool#auto_storage_container_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoStorageContainerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AutoStorageContainerName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#blob_prefix BatchPool#blob_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blobPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BlobPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#file_mode BatchPool#file_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fileMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FileMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#file_path BatchPool#file_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "filePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FilePath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#http_url BatchPool#http_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#storage_container_url BatchPool#storage_container_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageContainerUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageContainerUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#user_assigned_identity_id BatchPool#user_assigned_identity_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserAssignedIdentityId
        {
            get;
            set;
        }
    }
}
