using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTable
{
    [JsiiByValue(fqn: "aws.s3TablesTable.S3TablesTableMaintenanceConfigurationIcebergCompaction")]
    public class S3TablesTableMaintenanceConfigurationIcebergCompaction : aws.S3TablesTable.IS3TablesTableMaintenanceConfigurationIcebergCompaction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#settings S3TablesTable#settings}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"aws.s3TablesTable.S3TablesTableMaintenanceConfigurationIcebergCompactionSettings\"}", isOptional: true)]
        public aws.S3TablesTable.IS3TablesTableMaintenanceConfigurationIcebergCompactionSettings? Settings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#status S3TablesTable#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }
    }
}
