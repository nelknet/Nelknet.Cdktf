using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTableOptimizer
{
    [JsiiByValue(fqn: "aws.glueCatalogTableOptimizer.GlueCatalogTableOptimizerConfigurationRetentionConfigurationIcebergConfiguration")]
    public class GlueCatalogTableOptimizerConfigurationRetentionConfigurationIcebergConfiguration : aws.GlueCatalogTableOptimizer.IGlueCatalogTableOptimizerConfigurationRetentionConfigurationIcebergConfiguration
    {
        private object? _cleanExpiredFiles;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table_optimizer#clean_expired_files GlueCatalogTableOptimizer#clean_expired_files}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cleanExpiredFiles", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? CleanExpiredFiles
        {
            get => _cleanExpiredFiles;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cleanExpiredFiles = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table_optimizer#number_of_snapshots_to_retain GlueCatalogTableOptimizer#number_of_snapshots_to_retain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "numberOfSnapshotsToRetain", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NumberOfSnapshotsToRetain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table_optimizer#snapshot_retention_period_in_days GlueCatalogTableOptimizer#snapshot_retention_period_in_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotRetentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SnapshotRetentionPeriodInDays
        {
            get;
            set;
        }
    }
}
