using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LexIntent
{
    [JsiiClass(nativeType: typeof(aws.LexIntent.LexIntentFollowUpPromptOutputReference), fullyQualifiedName: "aws.lexIntent.LexIntentFollowUpPromptOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LexIntentFollowUpPromptOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LexIntentFollowUpPromptOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LexIntentFollowUpPromptOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LexIntentFollowUpPromptOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPrompt", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lexIntent.LexIntentFollowUpPromptPrompt\"}}]")]
        public virtual void PutPrompt(aws.LexIntent.ILexIntentFollowUpPromptPrompt @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LexIntent.ILexIntentFollowUpPromptPrompt)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRejectionStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lexIntent.LexIntentFollowUpPromptRejectionStatement\"}}]")]
        public virtual void PutRejectionStatement(aws.LexIntent.ILexIntentFollowUpPromptRejectionStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LexIntent.ILexIntentFollowUpPromptRejectionStatement)}, new object[]{@value});
        }

        [JsiiProperty(name: "prompt", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentFollowUpPromptPromptOutputReference\"}")]
        public virtual aws.LexIntent.LexIntentFollowUpPromptPromptOutputReference Prompt
        {
            get => GetInstanceProperty<aws.LexIntent.LexIntentFollowUpPromptPromptOutputReference>()!;
        }

        [JsiiProperty(name: "rejectionStatement", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentFollowUpPromptRejectionStatementOutputReference\"}")]
        public virtual aws.LexIntent.LexIntentFollowUpPromptRejectionStatementOutputReference RejectionStatement
        {
            get => GetInstanceProperty<aws.LexIntent.LexIntentFollowUpPromptRejectionStatementOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "promptInput", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentFollowUpPromptPrompt\"}", isOptional: true)]
        public virtual aws.LexIntent.ILexIntentFollowUpPromptPrompt? PromptInput
        {
            get => GetInstanceProperty<aws.LexIntent.ILexIntentFollowUpPromptPrompt?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rejectionStatementInput", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentFollowUpPromptRejectionStatement\"}", isOptional: true)]
        public virtual aws.LexIntent.ILexIntentFollowUpPromptRejectionStatement? RejectionStatementInput
        {
            get => GetInstanceProperty<aws.LexIntent.ILexIntentFollowUpPromptRejectionStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentFollowUpPrompt\"}", isOptional: true)]
        public virtual aws.LexIntent.ILexIntentFollowUpPrompt? InternalValue
        {
            get => GetInstanceProperty<aws.LexIntent.ILexIntentFollowUpPrompt?>();
            set => SetInstanceProperty(value);
        }
    }
}
