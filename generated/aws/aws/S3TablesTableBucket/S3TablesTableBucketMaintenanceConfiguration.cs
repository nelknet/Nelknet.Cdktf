using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTableBucket
{
    [JsiiByValue(fqn: "aws.s3TablesTableBucket.S3TablesTableBucketMaintenanceConfiguration")]
    public class S3TablesTableBucketMaintenanceConfiguration : aws.S3TablesTableBucket.IS3TablesTableBucketMaintenanceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_bucket#iceberg_unreferenced_file_removal S3TablesTableBucket#iceberg_unreferenced_file_removal}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "icebergUnreferencedFileRemoval", typeJson: "{\"fqn\":\"aws.s3TablesTableBucket.S3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemoval\"}", isOptional: true)]
        public aws.S3TablesTableBucket.IS3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemoval? IcebergUnreferencedFileRemoval
        {
            get;
            set;
        }
    }
}
