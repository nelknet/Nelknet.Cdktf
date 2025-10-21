using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTable
{
    [JsiiInterface(nativeType: typeof(IS3TablesTableMaintenanceConfigurationIcebergCompaction), fullyQualifiedName: "aws.s3TablesTable.S3TablesTableMaintenanceConfigurationIcebergCompaction")]
    public interface IS3TablesTableMaintenanceConfigurationIcebergCompaction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#settings S3TablesTable#settings}.</summary>
        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"aws.s3TablesTable.S3TablesTableMaintenanceConfigurationIcebergCompactionSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3TablesTable.IS3TablesTableMaintenanceConfigurationIcebergCompactionSettings? Settings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#status S3TablesTable#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3TablesTableMaintenanceConfigurationIcebergCompaction), fullyQualifiedName: "aws.s3TablesTable.S3TablesTableMaintenanceConfigurationIcebergCompaction")]
        internal sealed class _Proxy : DeputyBase, aws.S3TablesTable.IS3TablesTableMaintenanceConfigurationIcebergCompaction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#settings S3TablesTable#settings}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"aws.s3TablesTable.S3TablesTableMaintenanceConfigurationIcebergCompactionSettings\"}", isOptional: true)]
            public aws.S3TablesTable.IS3TablesTableMaintenanceConfigurationIcebergCompactionSettings? Settings
            {
                get => GetInstanceProperty<aws.S3TablesTable.IS3TablesTableMaintenanceConfigurationIcebergCompactionSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#status S3TablesTable#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
