using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiClass(nativeType: typeof(aws.Codepipeline.CodepipelineStageBeforeEntryOutputReference), fullyQualifiedName: "aws.codepipeline.CodepipelineStageBeforeEntryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CodepipelineStageBeforeEntryOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CodepipelineStageBeforeEntryOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CodepipelineStageBeforeEntryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodepipelineStageBeforeEntryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codepipeline.CodepipelineStageBeforeEntryCondition\"}}]")]
        public virtual void PutCondition(aws.Codepipeline.ICodepipelineStageBeforeEntryCondition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codepipeline.ICodepipelineStageBeforeEntryCondition)}, new object[]{@value});
        }

        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageBeforeEntryConditionOutputReference\"}")]
        public virtual aws.Codepipeline.CodepipelineStageBeforeEntryConditionOutputReference Condition
        {
            get => GetInstanceProperty<aws.Codepipeline.CodepipelineStageBeforeEntryConditionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "conditionInput", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageBeforeEntryCondition\"}", isOptional: true)]
        public virtual aws.Codepipeline.ICodepipelineStageBeforeEntryCondition? ConditionInput
        {
            get => GetInstanceProperty<aws.Codepipeline.ICodepipelineStageBeforeEntryCondition?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageBeforeEntry\"}", isOptional: true)]
        public virtual aws.Codepipeline.ICodepipelineStageBeforeEntry? InternalValue
        {
            get => GetInstanceProperty<aws.Codepipeline.ICodepipelineStageBeforeEntry?>();
            set => SetInstanceProperty(value);
        }
    }
}
