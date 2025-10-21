using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstruction")]
    public class QuicksightDataSetLogicalTableMapSourceJoinInstruction : aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstruction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#left_operand QuicksightDataSet#left_operand}.</summary>
        [JsiiProperty(name: "leftOperand", typeJson: "{\"primitive\":\"string\"}")]
        public string LeftOperand
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#on_clause QuicksightDataSet#on_clause}.</summary>
        [JsiiProperty(name: "onClause", typeJson: "{\"primitive\":\"string\"}")]
        public string OnClause
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#right_operand QuicksightDataSet#right_operand}.</summary>
        [JsiiProperty(name: "rightOperand", typeJson: "{\"primitive\":\"string\"}")]
        public string RightOperand
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#type QuicksightDataSet#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>left_join_key_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#left_join_key_properties QuicksightDataSet#left_join_key_properties}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "leftJoinKeyProperties", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstructionLeftJoinKeyProperties\"}", isOptional: true)]
        public aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstructionLeftJoinKeyProperties? LeftJoinKeyProperties
        {
            get;
            set;
        }

        /// <summary>right_join_key_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#right_join_key_properties QuicksightDataSet#right_join_key_properties}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rightJoinKeyProperties", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstructionRightJoinKeyProperties\"}", isOptional: true)]
        public aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstructionRightJoinKeyProperties? RightJoinKeyProperties
        {
            get;
            set;
        }
    }
}
