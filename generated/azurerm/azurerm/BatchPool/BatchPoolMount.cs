using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiByValue(fqn: "azurerm.batchPool.BatchPoolMount")]
    public class BatchPoolMount : azurerm.BatchPool.IBatchPoolMount
    {
        /// <summary>azure_blob_file_system block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#azure_blob_file_system BatchPool#azure_blob_file_system}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "azureBlobFileSystem", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolMountAzureBlobFileSystem\"}", isOptional: true)]
        public azurerm.BatchPool.IBatchPoolMountAzureBlobFileSystem? AzureBlobFileSystem
        {
            get;
            set;
        }

        private object? _azureFileShare;

        /// <summary>azure_file_share block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#azure_file_share BatchPool#azure_file_share}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "azureFileShare", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolMountAzureFileShare\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AzureFileShare
        {
            get => _azureFileShare;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.BatchPool.IBatchPoolMountAzureFileShare[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolMountAzureFileShare).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _azureFileShare = value;
            }
        }

        private object? _cifsMount;

        /// <summary>cifs_mount block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#cifs_mount BatchPool#cifs_mount}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cifsMount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolMountCifsMount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CifsMount
        {
            get => _cifsMount;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.BatchPool.IBatchPoolMountCifsMount[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolMountCifsMount).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cifsMount = value;
            }
        }

        private object? _nfsMount;

        /// <summary>nfs_mount block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#nfs_mount BatchPool#nfs_mount}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nfsMount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolMountNfsMount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NfsMount
        {
            get => _nfsMount;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.BatchPool.IBatchPoolMountNfsMount[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolMountNfsMount).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _nfsMount = value;
            }
        }
    }
}
