using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTable
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInput")]
    public class GlueCatalogTableOpenTableFormatInput : aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInput
    {
        /// <summary>iceberg_input block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#iceberg_input GlueCatalogTable#iceberg_input}
        /// </remarks>
        [JsiiProperty(name: "icebergInput", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInput\"}")]
        public aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInput IcebergInput
        {
            get;
            set;
        }
    }
}
