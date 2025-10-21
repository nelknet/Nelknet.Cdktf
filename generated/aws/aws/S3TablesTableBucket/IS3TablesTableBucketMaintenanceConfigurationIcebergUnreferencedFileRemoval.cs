using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTableBucket
{
    [JsiiInterface(nativeType: typeof(IS3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemoval), fullyQualifiedName: "aws.s3TablesTableBucket.S3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemoval")]
    public interface IS3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemoval
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_bucket#settings S3TablesTableBucket#settings}.</summary>
        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"aws.s3TablesTableBucket.S3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemovalSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3TablesTableBucket.IS3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemovalSettings? Settings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_bucket#status S3TablesTableBucket#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemoval), fullyQualifiedName: "aws.s3TablesTableBucket.S3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemoval")]
        internal sealed class _Proxy : DeputyBase, aws.S3TablesTableBucket.IS3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemoval
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_bucket#settings S3TablesTableBucket#settings}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"aws.s3TablesTableBucket.S3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemovalSettings\"}", isOptional: true)]
            public aws.S3TablesTableBucket.IS3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemovalSettings? Settings
            {
                get => GetInstanceProperty<aws.S3TablesTableBucket.IS3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemovalSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_bucket#status S3TablesTableBucket#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
