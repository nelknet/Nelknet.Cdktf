using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTableBucket
{
    [JsiiInterface(nativeType: typeof(IS3TablesTableBucketMaintenanceConfiguration), fullyQualifiedName: "aws.s3TablesTableBucket.S3TablesTableBucketMaintenanceConfiguration")]
    public interface IS3TablesTableBucketMaintenanceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_bucket#iceberg_unreferenced_file_removal S3TablesTableBucket#iceberg_unreferenced_file_removal}.</summary>
        [JsiiProperty(name: "icebergUnreferencedFileRemoval", typeJson: "{\"fqn\":\"aws.s3TablesTableBucket.S3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemoval\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3TablesTableBucket.IS3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemoval? IcebergUnreferencedFileRemoval
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3TablesTableBucketMaintenanceConfiguration), fullyQualifiedName: "aws.s3TablesTableBucket.S3TablesTableBucketMaintenanceConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.S3TablesTableBucket.IS3TablesTableBucketMaintenanceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_bucket#iceberg_unreferenced_file_removal S3TablesTableBucket#iceberg_unreferenced_file_removal}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "icebergUnreferencedFileRemoval", typeJson: "{\"fqn\":\"aws.s3TablesTableBucket.S3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemoval\"}", isOptional: true)]
            public aws.S3TablesTableBucket.IS3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemoval? IcebergUnreferencedFileRemoval
            {
                get => GetInstanceProperty<aws.S3TablesTableBucket.IS3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemoval?>();
            }
        }
    }
}
