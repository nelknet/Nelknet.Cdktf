using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTable
{
    [JsiiInterface(nativeType: typeof(IS3TablesTableMaintenanceConfiguration), fullyQualifiedName: "aws.s3TablesTable.S3TablesTableMaintenanceConfiguration")]
    public interface IS3TablesTableMaintenanceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#iceberg_compaction S3TablesTable#iceberg_compaction}.</summary>
        [JsiiProperty(name: "icebergCompaction", typeJson: "{\"fqn\":\"aws.s3TablesTable.S3TablesTableMaintenanceConfigurationIcebergCompaction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3TablesTable.IS3TablesTableMaintenanceConfigurationIcebergCompaction? IcebergCompaction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#iceberg_snapshot_management S3TablesTable#iceberg_snapshot_management}.</summary>
        [JsiiProperty(name: "icebergSnapshotManagement", typeJson: "{\"fqn\":\"aws.s3TablesTable.S3TablesTableMaintenanceConfigurationIcebergSnapshotManagement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3TablesTable.IS3TablesTableMaintenanceConfigurationIcebergSnapshotManagement? IcebergSnapshotManagement
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3TablesTableMaintenanceConfiguration), fullyQualifiedName: "aws.s3TablesTable.S3TablesTableMaintenanceConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.S3TablesTable.IS3TablesTableMaintenanceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#iceberg_compaction S3TablesTable#iceberg_compaction}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "icebergCompaction", typeJson: "{\"fqn\":\"aws.s3TablesTable.S3TablesTableMaintenanceConfigurationIcebergCompaction\"}", isOptional: true)]
            public aws.S3TablesTable.IS3TablesTableMaintenanceConfigurationIcebergCompaction? IcebergCompaction
            {
                get => GetInstanceProperty<aws.S3TablesTable.IS3TablesTableMaintenanceConfigurationIcebergCompaction?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#iceberg_snapshot_management S3TablesTable#iceberg_snapshot_management}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "icebergSnapshotManagement", typeJson: "{\"fqn\":\"aws.s3TablesTable.S3TablesTableMaintenanceConfigurationIcebergSnapshotManagement\"}", isOptional: true)]
            public aws.S3TablesTable.IS3TablesTableMaintenanceConfigurationIcebergSnapshotManagement? IcebergSnapshotManagement
            {
                get => GetInstanceProperty<aws.S3TablesTable.IS3TablesTableMaintenanceConfigurationIcebergSnapshotManagement?>();
            }
        }
    }
}
