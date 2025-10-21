using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageObjectReplication
{
    [JsiiInterface(nativeType: typeof(IStorageObjectReplicationRules), fullyQualifiedName: "azurerm.storageObjectReplication.StorageObjectReplicationRules")]
    public interface IStorageObjectReplicationRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_object_replication#destination_container_name StorageObjectReplication#destination_container_name}.</summary>
        [JsiiProperty(name: "destinationContainerName", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationContainerName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_object_replication#source_container_name StorageObjectReplication#source_container_name}.</summary>
        [JsiiProperty(name: "sourceContainerName", typeJson: "{\"primitive\":\"string\"}")]
        string SourceContainerName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_object_replication#copy_blobs_created_after StorageObjectReplication#copy_blobs_created_after}.</summary>
        [JsiiProperty(name: "copyBlobsCreatedAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CopyBlobsCreatedAfter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_object_replication#filter_out_blobs_with_prefix StorageObjectReplication#filter_out_blobs_with_prefix}.</summary>
        [JsiiProperty(name: "filterOutBlobsWithPrefix", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? FilterOutBlobsWithPrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageObjectReplicationRules), fullyQualifiedName: "azurerm.storageObjectReplication.StorageObjectReplicationRules")]
        internal sealed class _Proxy : DeputyBase, azurerm.StorageObjectReplication.IStorageObjectReplicationRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_object_replication#destination_container_name StorageObjectReplication#destination_container_name}.</summary>
            [JsiiProperty(name: "destinationContainerName", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationContainerName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_object_replication#source_container_name StorageObjectReplication#source_container_name}.</summary>
            [JsiiProperty(name: "sourceContainerName", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceContainerName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_object_replication#copy_blobs_created_after StorageObjectReplication#copy_blobs_created_after}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "copyBlobsCreatedAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CopyBlobsCreatedAfter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_object_replication#filter_out_blobs_with_prefix StorageObjectReplication#filter_out_blobs_with_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filterOutBlobsWithPrefix", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? FilterOutBlobsWithPrefix
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
