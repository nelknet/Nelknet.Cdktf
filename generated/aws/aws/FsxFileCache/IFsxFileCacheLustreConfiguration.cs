using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxFileCache
{
    [JsiiInterface(nativeType: typeof(IFsxFileCacheLustreConfiguration), fullyQualifiedName: "aws.fsxFileCache.FsxFileCacheLustreConfiguration")]
    public interface IFsxFileCacheLustreConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#deployment_type FsxFileCache#deployment_type}.</summary>
        [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}")]
        string DeploymentType
        {
            get;
        }

        /// <summary>metadata_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#metadata_configuration FsxFileCache#metadata_configuration}
        /// </remarks>
        [JsiiProperty(name: "metadataConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsxFileCache.FsxFileCacheLustreConfigurationMetadataConfiguration\"},\"kind\":\"array\"}}]}}")]
        object MetadataConfiguration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#per_unit_storage_throughput FsxFileCache#per_unit_storage_throughput}.</summary>
        [JsiiProperty(name: "perUnitStorageThroughput", typeJson: "{\"primitive\":\"number\"}")]
        double PerUnitStorageThroughput
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#weekly_maintenance_start_time FsxFileCache#weekly_maintenance_start_time}.</summary>
        [JsiiProperty(name: "weeklyMaintenanceStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WeeklyMaintenanceStartTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxFileCacheLustreConfiguration), fullyQualifiedName: "aws.fsxFileCache.FsxFileCacheLustreConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.FsxFileCache.IFsxFileCacheLustreConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#deployment_type FsxFileCache#deployment_type}.</summary>
            [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}")]
            public string DeploymentType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>metadata_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#metadata_configuration FsxFileCache#metadata_configuration}
            /// </remarks>
            [JsiiProperty(name: "metadataConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsxFileCache.FsxFileCacheLustreConfigurationMetadataConfiguration\"},\"kind\":\"array\"}}]}}")]
            public object MetadataConfiguration
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#per_unit_storage_throughput FsxFileCache#per_unit_storage_throughput}.</summary>
            [JsiiProperty(name: "perUnitStorageThroughput", typeJson: "{\"primitive\":\"number\"}")]
            public double PerUnitStorageThroughput
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#weekly_maintenance_start_time FsxFileCache#weekly_maintenance_start_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "weeklyMaintenanceStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WeeklyMaintenanceStartTime
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
