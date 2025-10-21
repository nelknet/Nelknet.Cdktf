using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSetLogicalTableMapSource), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSource")]
    public interface IQuicksightDataSetLogicalTableMapSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#data_set_arn QuicksightDataSet#data_set_arn}.</summary>
        [JsiiProperty(name: "dataSetArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataSetArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>join_instruction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#join_instruction QuicksightDataSet#join_instruction}
        /// </remarks>
        [JsiiProperty(name: "joinInstruction", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstruction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstruction? JoinInstruction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#physical_table_id QuicksightDataSet#physical_table_id}.</summary>
        [JsiiProperty(name: "physicalTableId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PhysicalTableId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSetLogicalTableMapSource), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSource")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#data_set_arn QuicksightDataSet#data_set_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataSetArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataSetArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>join_instruction block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#join_instruction QuicksightDataSet#join_instruction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "joinInstruction", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstruction\"}", isOptional: true)]
            public aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstruction? JoinInstruction
            {
                get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstruction?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#physical_table_id QuicksightDataSet#physical_table_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "physicalTableId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PhysicalTableId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
