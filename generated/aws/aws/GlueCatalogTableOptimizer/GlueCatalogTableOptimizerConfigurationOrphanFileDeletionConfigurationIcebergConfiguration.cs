using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTableOptimizer
{
    [JsiiByValue(fqn: "aws.glueCatalogTableOptimizer.GlueCatalogTableOptimizerConfigurationOrphanFileDeletionConfigurationIcebergConfiguration")]
    public class GlueCatalogTableOptimizerConfigurationOrphanFileDeletionConfigurationIcebergConfiguration : aws.GlueCatalogTableOptimizer.IGlueCatalogTableOptimizerConfigurationOrphanFileDeletionConfigurationIcebergConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table_optimizer#location GlueCatalogTableOptimizer#location}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Location
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table_optimizer#orphan_file_retention_period_in_days GlueCatalogTableOptimizer#orphan_file_retention_period_in_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "orphanFileRetentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? OrphanFileRetentionPeriodInDays
        {
            get;
            set;
        }
    }
}
