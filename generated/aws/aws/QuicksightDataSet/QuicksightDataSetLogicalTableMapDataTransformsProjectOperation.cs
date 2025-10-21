using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsProjectOperation")]
    public class QuicksightDataSetLogicalTableMapDataTransformsProjectOperation : aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsProjectOperation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#projected_columns QuicksightDataSet#projected_columns}.</summary>
        [JsiiProperty(name: "projectedColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] ProjectedColumns
        {
            get;
            set;
        }
    }
}
