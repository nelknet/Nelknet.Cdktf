using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiClass(nativeType: typeof(aws.Codepipeline.CodepipelineStageOnSuccessOutputReference), fullyQualifiedName: "aws.codepipeline.CodepipelineStageOnSuccessOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CodepipelineStageOnSuccessOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CodepipelineStageOnSuccessOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CodepipelineStageOnSuccessOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodepipelineStageOnSuccessOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codepipeline.CodepipelineStageOnSuccessCondition\"}}]")]
        public virtual void PutCondition(aws.Codepipeline.ICodepipelineStageOnSuccessCondition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codepipeline.ICodepipelineStageOnSuccessCondition)}, new object[]{@value});
        }

        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnSuccessConditionOutputReference\"}")]
        public virtual aws.Codepipeline.CodepipelineStageOnSuccessConditionOutputReference Condition
        {
            get => GetInstanceProperty<aws.Codepipeline.CodepipelineStageOnSuccessConditionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "conditionInput", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnSuccessCondition\"}", isOptional: true)]
        public virtual aws.Codepipeline.ICodepipelineStageOnSuccessCondition? ConditionInput
        {
            get => GetInstanceProperty<aws.Codepipeline.ICodepipelineStageOnSuccessCondition?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnSuccess\"}", isOptional: true)]
        public virtual aws.Codepipeline.ICodepipelineStageOnSuccess? InternalValue
        {
            get => GetInstanceProperty<aws.Codepipeline.ICodepipelineStageOnSuccess?>();
            set => SetInstanceProperty(value);
        }
    }
}
