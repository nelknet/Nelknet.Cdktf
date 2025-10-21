using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiClass(nativeType: typeof(aws.QuicksightDataSet.QuicksightDataSetLogicalTableMapSourceOutputReference), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuicksightDataSetLogicalTableMapSourceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuicksightDataSetLogicalTableMapSourceOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDataSetLogicalTableMapSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDataSetLogicalTableMapSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putJoinInstruction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstruction\"}}]")]
        public virtual void PutJoinInstruction(aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstruction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstruction)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDataSetArn")]
        public virtual void ResetDataSetArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJoinInstruction")]
        public virtual void ResetJoinInstruction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPhysicalTableId")]
        public virtual void ResetPhysicalTableId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "joinInstruction", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstructionOutputReference\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstructionOutputReference JoinInstruction
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstructionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataSetArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataSetArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "joinInstructionInput", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstruction\"}", isOptional: true)]
        public virtual aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstruction? JoinInstructionInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstruction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "physicalTableIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PhysicalTableIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dataSetArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataSetArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "physicalTableId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PhysicalTableId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSource\"}", isOptional: true)]
        public virtual aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSource? InternalValue
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSource?>();
            set => SetInstanceProperty(value);
        }
    }
}
