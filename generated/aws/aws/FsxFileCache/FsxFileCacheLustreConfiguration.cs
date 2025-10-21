using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxFileCache
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.fsxFileCache.FsxFileCacheLustreConfiguration")]
    public class FsxFileCacheLustreConfiguration : aws.FsxFileCache.IFsxFileCacheLustreConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#deployment_type FsxFileCache#deployment_type}.</summary>
        [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}")]
        public string DeploymentType
        {
            get;
            set;
        }

        private object _metadataConfiguration;

        /// <summary>metadata_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#metadata_configuration FsxFileCache#metadata_configuration}
        /// </remarks>
        [JsiiProperty(name: "metadataConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsxFileCache.FsxFileCacheLustreConfigurationMetadataConfiguration\"},\"kind\":\"array\"}}]}}")]
        public object MetadataConfiguration
        {
            get => _metadataConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.FsxFileCache.IFsxFileCacheLustreConfigurationMetadataConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.FsxFileCache.IFsxFileCacheLustreConfigurationMetadataConfiguration).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.FsxFileCache.IFsxFileCacheLustreConfigurationMetadataConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _metadataConfiguration = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#per_unit_storage_throughput FsxFileCache#per_unit_storage_throughput}.</summary>
        [JsiiProperty(name: "perUnitStorageThroughput", typeJson: "{\"primitive\":\"number\"}")]
        public double PerUnitStorageThroughput
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#weekly_maintenance_start_time FsxFileCache#weekly_maintenance_start_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weeklyMaintenanceStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WeeklyMaintenanceStartTime
        {
            get;
            set;
        }
    }
}
