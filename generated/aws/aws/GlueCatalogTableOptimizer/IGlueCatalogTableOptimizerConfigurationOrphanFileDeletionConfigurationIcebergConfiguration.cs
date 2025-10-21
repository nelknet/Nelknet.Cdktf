using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTableOptimizer
{
    [JsiiInterface(nativeType: typeof(IGlueCatalogTableOptimizerConfigurationOrphanFileDeletionConfigurationIcebergConfiguration), fullyQualifiedName: "aws.glueCatalogTableOptimizer.GlueCatalogTableOptimizerConfigurationOrphanFileDeletionConfigurationIcebergConfiguration")]
    public interface IGlueCatalogTableOptimizerConfigurationOrphanFileDeletionConfigurationIcebergConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table_optimizer#location GlueCatalogTableOptimizer#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Location
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table_optimizer#orphan_file_retention_period_in_days GlueCatalogTableOptimizer#orphan_file_retention_period_in_days}.</summary>
        [JsiiProperty(name: "orphanFileRetentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? OrphanFileRetentionPeriodInDays
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCatalogTableOptimizerConfigurationOrphanFileDeletionConfigurationIcebergConfiguration), fullyQualifiedName: "aws.glueCatalogTableOptimizer.GlueCatalogTableOptimizerConfigurationOrphanFileDeletionConfigurationIcebergConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.GlueCatalogTableOptimizer.IGlueCatalogTableOptimizerConfigurationOrphanFileDeletionConfigurationIcebergConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table_optimizer#location GlueCatalogTableOptimizer#location}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Location
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table_optimizer#orphan_file_retention_period_in_days GlueCatalogTableOptimizer#orphan_file_retention_period_in_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "orphanFileRetentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? OrphanFileRetentionPeriodInDays
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
