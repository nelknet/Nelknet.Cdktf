using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTableBucket
{
    [JsiiInterface(nativeType: typeof(IS3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemovalSettings), fullyQualifiedName: "aws.s3TablesTableBucket.S3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemovalSettings")]
    public interface IS3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemovalSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_bucket#non_current_days S3TablesTableBucket#non_current_days}.</summary>
        [JsiiProperty(name: "nonCurrentDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NonCurrentDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_bucket#unreferenced_days S3TablesTableBucket#unreferenced_days}.</summary>
        [JsiiProperty(name: "unreferencedDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? UnreferencedDays
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemovalSettings), fullyQualifiedName: "aws.s3TablesTableBucket.S3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemovalSettings")]
        internal sealed class _Proxy : DeputyBase, aws.S3TablesTableBucket.IS3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemovalSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_bucket#non_current_days S3TablesTableBucket#non_current_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nonCurrentDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NonCurrentDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_bucket#unreferenced_days S3TablesTableBucket#unreferenced_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "unreferencedDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UnreferencedDays
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
