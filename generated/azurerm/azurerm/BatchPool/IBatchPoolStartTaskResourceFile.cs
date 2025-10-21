using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiInterface(nativeType: typeof(IBatchPoolStartTaskResourceFile), fullyQualifiedName: "azurerm.batchPool.BatchPoolStartTaskResourceFile")]
    public interface IBatchPoolStartTaskResourceFile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#auto_storage_container_name BatchPool#auto_storage_container_name}.</summary>
        [JsiiProperty(name: "autoStorageContainerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutoStorageContainerName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#blob_prefix BatchPool#blob_prefix}.</summary>
        [JsiiProperty(name: "blobPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BlobPrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#file_mode BatchPool#file_mode}.</summary>
        [JsiiProperty(name: "fileMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FileMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#file_path BatchPool#file_path}.</summary>
        [JsiiProperty(name: "filePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FilePath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#http_url BatchPool#http_url}.</summary>
        [JsiiProperty(name: "httpUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#storage_container_url BatchPool#storage_container_url}.</summary>
        [JsiiProperty(name: "storageContainerUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageContainerUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#user_assigned_identity_id BatchPool#user_assigned_identity_id}.</summary>
        [JsiiProperty(name: "userAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserAssignedIdentityId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchPoolStartTaskResourceFile), fullyQualifiedName: "azurerm.batchPool.BatchPoolStartTaskResourceFile")]
        internal sealed class _Proxy : DeputyBase, azurerm.BatchPool.IBatchPoolStartTaskResourceFile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#auto_storage_container_name BatchPool#auto_storage_container_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoStorageContainerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutoStorageContainerName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#blob_prefix BatchPool#blob_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "blobPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BlobPrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#file_mode BatchPool#file_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fileMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FileMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#file_path BatchPool#file_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FilePath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#http_url BatchPool#http_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#storage_container_url BatchPool#storage_container_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageContainerUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageContainerUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#user_assigned_identity_id BatchPool#user_assigned_identity_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserAssignedIdentityId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
