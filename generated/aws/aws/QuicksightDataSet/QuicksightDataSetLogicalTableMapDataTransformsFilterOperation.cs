using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsFilterOperation")]
    public class QuicksightDataSetLogicalTableMapDataTransformsFilterOperation : aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsFilterOperation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#condition_expression QuicksightDataSet#condition_expression}.</summary>
        [JsiiProperty(name: "conditionExpression", typeJson: "{\"primitive\":\"string\"}")]
        public string ConditionExpression
        {
            get;
            set;
        }
    }
}
