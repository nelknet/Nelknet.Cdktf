using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiByValue(fqn: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsTagColumnOperationTagsColumnDescription")]
    public class QuicksightDataSetLogicalTableMapDataTransformsTagColumnOperationTagsColumnDescription : aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsTagColumnOperationTagsColumnDescription
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#text QuicksightDataSet#text}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Text
        {
            get;
            set;
        }
    }
}
