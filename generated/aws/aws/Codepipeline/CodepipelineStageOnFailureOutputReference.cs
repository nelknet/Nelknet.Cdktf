using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiClass(nativeType: typeof(aws.Codepipeline.CodepipelineStageOnFailureOutputReference), fullyQualifiedName: "aws.codepipeline.CodepipelineStageOnFailureOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CodepipelineStageOnFailureOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CodepipelineStageOnFailureOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CodepipelineStageOnFailureOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodepipelineStageOnFailureOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codepipeline.CodepipelineStageOnFailureCondition\"}}]")]
        public virtual void PutCondition(aws.Codepipeline.ICodepipelineStageOnFailureCondition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codepipeline.ICodepipelineStageOnFailureCondition)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRetryConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codepipeline.CodepipelineStageOnFailureRetryConfiguration\"}}]")]
        public virtual void PutRetryConfiguration(aws.Codepipeline.ICodepipelineStageOnFailureRetryConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codepipeline.ICodepipelineStageOnFailureRetryConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCondition")]
        public virtual void ResetCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResult")]
        public virtual void ResetResult()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetryConfiguration")]
        public virtual void ResetRetryConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnFailureConditionOutputReference\"}")]
        public virtual aws.Codepipeline.CodepipelineStageOnFailureConditionOutputReference Condition
        {
            get => GetInstanceProperty<aws.Codepipeline.CodepipelineStageOnFailureConditionOutputReference>()!;
        }

        [JsiiProperty(name: "retryConfiguration", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnFailureRetryConfigurationOutputReference\"}")]
        public virtual aws.Codepipeline.CodepipelineStageOnFailureRetryConfigurationOutputReference RetryConfiguration
        {
            get => GetInstanceProperty<aws.Codepipeline.CodepipelineStageOnFailureRetryConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "conditionInput", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnFailureCondition\"}", isOptional: true)]
        public virtual aws.Codepipeline.ICodepipelineStageOnFailureCondition? ConditionInput
        {
            get => GetInstanceProperty<aws.Codepipeline.ICodepipelineStageOnFailureCondition?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resultInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResultInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retryConfigurationInput", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnFailureRetryConfiguration\"}", isOptional: true)]
        public virtual aws.Codepipeline.ICodepipelineStageOnFailureRetryConfiguration? RetryConfigurationInput
        {
            get => GetInstanceProperty<aws.Codepipeline.ICodepipelineStageOnFailureRetryConfiguration?>();
        }

        [JsiiProperty(name: "result", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Result
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnFailure\"}", isOptional: true)]
        public virtual aws.Codepipeline.ICodepipelineStageOnFailure? InternalValue
        {
            get => GetInstanceProperty<aws.Codepipeline.ICodepipelineStageOnFailure?>();
            set => SetInstanceProperty(value);
        }
    }
}
