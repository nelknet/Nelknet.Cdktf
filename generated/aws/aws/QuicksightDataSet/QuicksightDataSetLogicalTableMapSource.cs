using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiByValue(fqn: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSource")]
    public class QuicksightDataSetLogicalTableMapSource : aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#data_set_arn QuicksightDataSet#data_set_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataSetArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataSetArn
        {
            get;
            set;
        }

        /// <summary>join_instruction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#join_instruction QuicksightDataSet#join_instruction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "joinInstruction", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstruction\"}", isOptional: true)]
        public aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstruction? JoinInstruction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#physical_table_id QuicksightDataSet#physical_table_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "physicalTableId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PhysicalTableId
        {
            get;
            set;
        }
    }
}
