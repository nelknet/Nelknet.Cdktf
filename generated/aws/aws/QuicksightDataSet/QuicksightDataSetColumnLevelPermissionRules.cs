using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiByValue(fqn: "aws.quicksightDataSet.QuicksightDataSetColumnLevelPermissionRules")]
    public class QuicksightDataSetColumnLevelPermissionRules : aws.QuicksightDataSet.IQuicksightDataSetColumnLevelPermissionRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#column_names QuicksightDataSet#column_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "columnNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ColumnNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#principals QuicksightDataSet#principals}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "principals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Principals
        {
            get;
            set;
        }
    }
}
