using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiByValue(fqn: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsTagColumnOperationTags")]
    public class QuicksightDataSetLogicalTableMapDataTransformsTagColumnOperationTags : aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsTagColumnOperationTags
    {
        /// <summary>column_description block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#column_description QuicksightDataSet#column_description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "columnDescription", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsTagColumnOperationTagsColumnDescription\"}", isOptional: true)]
        public aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsTagColumnOperationTagsColumnDescription? ColumnDescription
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#column_geographic_role QuicksightDataSet#column_geographic_role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "columnGeographicRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ColumnGeographicRole
        {
            get;
            set;
        }
    }
}
