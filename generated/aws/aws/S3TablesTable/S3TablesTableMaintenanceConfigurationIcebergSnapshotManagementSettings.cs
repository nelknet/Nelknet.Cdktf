using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTable
{
    [JsiiByValue(fqn: "aws.s3TablesTable.S3TablesTableMaintenanceConfigurationIcebergSnapshotManagementSettings")]
    public class S3TablesTableMaintenanceConfigurationIcebergSnapshotManagementSettings : aws.S3TablesTable.IS3TablesTableMaintenanceConfigurationIcebergSnapshotManagementSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#max_snapshot_age_hours S3TablesTable#max_snapshot_age_hours}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxSnapshotAgeHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxSnapshotAgeHours
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#min_snapshots_to_keep S3TablesTable#min_snapshots_to_keep}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minSnapshotsToKeep", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinSnapshotsToKeep
        {
            get;
            set;
        }
    }
}
