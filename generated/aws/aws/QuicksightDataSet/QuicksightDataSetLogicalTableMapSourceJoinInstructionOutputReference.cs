using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiClass(nativeType: typeof(aws.QuicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstructionOutputReference), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstructionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuicksightDataSetLogicalTableMapSourceJoinInstructionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuicksightDataSetLogicalTableMapSourceJoinInstructionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected QuicksightDataSetLogicalTableMapSourceJoinInstructionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDataSetLogicalTableMapSourceJoinInstructionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLeftJoinKeyProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstructionLeftJoinKeyProperties\"}}]")]
        public virtual void PutLeftJoinKeyProperties(aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstructionLeftJoinKeyProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstructionLeftJoinKeyProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRightJoinKeyProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstructionRightJoinKeyProperties\"}}]")]
        public virtual void PutRightJoinKeyProperties(aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstructionRightJoinKeyProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstructionRightJoinKeyProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetLeftJoinKeyProperties")]
        public virtual void ResetLeftJoinKeyProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRightJoinKeyProperties")]
        public virtual void ResetRightJoinKeyProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "leftJoinKeyProperties", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstructionLeftJoinKeyPropertiesOutputReference\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstructionLeftJoinKeyPropertiesOutputReference LeftJoinKeyProperties
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstructionLeftJoinKeyPropertiesOutputReference>()!;
        }

        [JsiiProperty(name: "rightJoinKeyProperties", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstructionRightJoinKeyPropertiesOutputReference\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstructionRightJoinKeyPropertiesOutputReference RightJoinKeyProperties
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstructionRightJoinKeyPropertiesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "leftJoinKeyPropertiesInput", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstructionLeftJoinKeyProperties\"}", isOptional: true)]
        public virtual aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstructionLeftJoinKeyProperties? LeftJoinKeyPropertiesInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstructionLeftJoinKeyProperties?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "leftOperandInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LeftOperandInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onClauseInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OnClauseInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rightJoinKeyPropertiesInput", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstructionRightJoinKeyProperties\"}", isOptional: true)]
        public virtual aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstructionRightJoinKeyProperties? RightJoinKeyPropertiesInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstructionRightJoinKeyProperties?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rightOperandInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RightOperandInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "leftOperand", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LeftOperand
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "onClause", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnClause
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rightOperand", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RightOperand
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSourceJoinInstruction\"}", isOptional: true)]
        public virtual aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstruction? InternalValue
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSourceJoinInstruction?>();
            set => SetInstanceProperty(value);
        }
    }
}
