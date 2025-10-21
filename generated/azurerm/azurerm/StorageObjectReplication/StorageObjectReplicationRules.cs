using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageObjectReplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.storageObjectReplication.StorageObjectReplicationRules")]
    public class StorageObjectReplicationRules : azurerm.StorageObjectReplication.IStorageObjectReplicationRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_object_replication#destination_container_name StorageObjectReplication#destination_container_name}.</summary>
        [JsiiProperty(name: "destinationContainerName", typeJson: "{\"primitive\":\"string\"}")]
        public string DestinationContainerName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_object_replication#source_container_name StorageObjectReplication#source_container_name}.</summary>
        [JsiiProperty(name: "sourceContainerName", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceContainerName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_object_replication#copy_blobs_created_after StorageObjectReplication#copy_blobs_created_after}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "copyBlobsCreatedAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CopyBlobsCreatedAfter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_object_replication#filter_out_blobs_with_prefix StorageObjectReplication#filter_out_blobs_with_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "filterOutBlobsWithPrefix", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? FilterOutBlobsWithPrefix
        {
            get;
            set;
        }
    }
}
