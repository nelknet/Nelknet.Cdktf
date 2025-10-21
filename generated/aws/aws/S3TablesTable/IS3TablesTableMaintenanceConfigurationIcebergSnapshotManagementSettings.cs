using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTable
{
    [JsiiInterface(nativeType: typeof(IS3TablesTableMaintenanceConfigurationIcebergSnapshotManagementSettings), fullyQualifiedName: "aws.s3TablesTable.S3TablesTableMaintenanceConfigurationIcebergSnapshotManagementSettings")]
    public interface IS3TablesTableMaintenanceConfigurationIcebergSnapshotManagementSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#max_snapshot_age_hours S3TablesTable#max_snapshot_age_hours}.</summary>
        [JsiiProperty(name: "maxSnapshotAgeHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxSnapshotAgeHours
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#min_snapshots_to_keep S3TablesTable#min_snapshots_to_keep}.</summary>
        [JsiiProperty(name: "minSnapshotsToKeep", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinSnapshotsToKeep
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3TablesTableMaintenanceConfigurationIcebergSnapshotManagementSettings), fullyQualifiedName: "aws.s3TablesTable.S3TablesTableMaintenanceConfigurationIcebergSnapshotManagementSettings")]
        internal sealed class _Proxy : DeputyBase, aws.S3TablesTable.IS3TablesTableMaintenanceConfigurationIcebergSnapshotManagementSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#max_snapshot_age_hours S3TablesTable#max_snapshot_age_hours}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxSnapshotAgeHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxSnapshotAgeHours
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#min_snapshots_to_keep S3TablesTable#min_snapshots_to_keep}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minSnapshotsToKeep", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinSnapshotsToKeep
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
