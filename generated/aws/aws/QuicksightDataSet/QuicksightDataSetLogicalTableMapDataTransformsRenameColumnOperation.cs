using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsRenameColumnOperation")]
    public class QuicksightDataSetLogicalTableMapDataTransformsRenameColumnOperation : aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsRenameColumnOperation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#column_name QuicksightDataSet#column_name}.</summary>
        [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}")]
        public string ColumnName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#new_column_name QuicksightDataSet#new_column_name}.</summary>
        [JsiiProperty(name: "newColumnName", typeJson: "{\"primitive\":\"string\"}")]
        public string NewColumnName
        {
            get;
            set;
        }
    }
}
