using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSetLogicalTableMapSourceJoinInstruction), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstruction")]
    public interface IQuicksightDataSetLogicalTableMapSourceJoinInstruction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#left_operand QuicksightDataSet#left_operand}.</summary>
        [JsiiProperty(name: "leftOperand", typeJson: "{\"primitive\":\"string\"}")]
        string LeftOperand
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#on_clause QuicksightDataSet#on_clause}.</summary>
        [JsiiProperty(name: "onClause", typeJson: "{\"primitive\":\"string\"}")]
        string OnClause
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#right_operand QuicksightDataSet#right_operand}.</summary>
        [JsiiProperty(name: "rightOperand", typeJson: "{\"primitive\":\"string\"}")]
        string RightOperand
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#type QuicksightDataSet#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>left_join_key_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#left_join_key_properties QuicksightDataSet#left_join_key_properties}
        /// </remarks>
        [JsiiProperty(name: "leftJoinKeyProperties", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstructionLeftJoinKeyProperties\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstructionLeftJoinKeyProperties? LeftJoinKeyProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>right_join_key_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#right_join_key_properties QuicksightDataSet#right_join_key_properties}
        /// </remarks>
        [JsiiProperty(name: "rightJoinKeyProperties", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstructionRightJoinKeyProperties\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstructionRightJoinKeyProperties? RightJoinKeyProperties
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSetLogicalTableMapSourceJoinInstruction), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstruction")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstruction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#left_operand QuicksightDataSet#left_operand}.</summary>
            [JsiiProperty(name: "leftOperand", typeJson: "{\"primitive\":\"string\"}")]
            public string LeftOperand
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#on_clause QuicksightDataSet#on_clause}.</summary>
            [JsiiProperty(name: "onClause", typeJson: "{\"primitive\":\"string\"}")]
            public string OnClause
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#right_operand QuicksightDataSet#right_operand}.</summary>
            [JsiiProperty(name: "rightOperand", typeJson: "{\"primitive\":\"string\"}")]
            public string RightOperand
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#type QuicksightDataSet#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>left_join_key_properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#left_join_key_properties QuicksightDataSet#left_join_key_properties}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "leftJoinKeyProperties", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstructionLeftJoinKeyProperties\"}", isOptional: true)]
            public aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstructionLeftJoinKeyProperties? LeftJoinKeyProperties
            {
                get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstructionLeftJoinKeyProperties?>();
            }

            /// <summary>right_join_key_properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#right_join_key_properties QuicksightDataSet#right_join_key_properties}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rightJoinKeyProperties", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstructionRightJoinKeyProperties\"}", isOptional: true)]
            public aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstructionRightJoinKeyProperties? RightJoinKeyProperties
            {
                get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstructionRightJoinKeyProperties?>();
            }
        }
    }
}
