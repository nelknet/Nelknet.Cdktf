using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTableBucket
{
    [JsiiByValue(fqn: "aws.s3TablesTableBucket.S3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemovalSettings")]
    public class S3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemovalSettings : aws.S3TablesTableBucket.IS3TablesTableBucketMaintenanceConfigurationIcebergUnreferencedFileRemovalSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_bucket#non_current_days S3TablesTableBucket#non_current_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nonCurrentDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NonCurrentDays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_bucket#unreferenced_days S3TablesTableBucket#unreferenced_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "unreferencedDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UnreferencedDays
        {
            get;
            set;
        }
    }
}
