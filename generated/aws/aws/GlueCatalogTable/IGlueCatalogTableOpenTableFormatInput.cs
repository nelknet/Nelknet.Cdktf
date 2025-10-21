using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTable
{
    [JsiiInterface(nativeType: typeof(IGlueCatalogTableOpenTableFormatInput), fullyQualifiedName: "aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInput")]
    public interface IGlueCatalogTableOpenTableFormatInput
    {
        /// <summary>iceberg_input block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#iceberg_input GlueCatalogTable#iceberg_input}
        /// </remarks>
        [JsiiProperty(name: "icebergInput", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInput\"}")]
        aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInput IcebergInput
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCatalogTableOpenTableFormatInput), fullyQualifiedName: "aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInput")]
        internal sealed class _Proxy : DeputyBase, aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInput
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>iceberg_input block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#iceberg_input GlueCatalogTable#iceberg_input}
            /// </remarks>
            [JsiiProperty(name: "icebergInput", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInput\"}")]
            public aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInput IcebergInput
            {
                get => GetInstanceProperty<aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInput>()!;
            }
        }
    }
}
