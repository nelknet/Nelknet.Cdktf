using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTable
{
    [JsiiInterface(nativeType: typeof(IS3TablesTableMaintenanceConfigurationIcebergCompactionSettings), fullyQualifiedName: "aws.s3TablesTable.S3TablesTableMaintenanceConfigurationIcebergCompactionSettings")]
    public interface IS3TablesTableMaintenanceConfigurationIcebergCompactionSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#target_file_size_mb S3TablesTable#target_file_size_mb}.</summary>
        [JsiiProperty(name: "targetFileSizeMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TargetFileSizeMb
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3TablesTableMaintenanceConfigurationIcebergCompactionSettings), fullyQualifiedName: "aws.s3TablesTable.S3TablesTableMaintenanceConfigurationIcebergCompactionSettings")]
        internal sealed class _Proxy : DeputyBase, aws.S3TablesTable.IS3TablesTableMaintenanceConfigurationIcebergCompactionSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#target_file_size_mb S3TablesTable#target_file_size_mb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetFileSizeMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TargetFileSizeMb
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
