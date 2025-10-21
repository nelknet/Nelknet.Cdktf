using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElastictranscoderPipeline
{
    [JsiiClass(nativeType: typeof(aws.ElastictranscoderPipeline.ElastictranscoderPipelineNotificationsOutputReference), fullyQualifiedName: "aws.elastictranscoderPipeline.ElastictranscoderPipelineNotificationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ElastictranscoderPipelineNotificationsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ElastictranscoderPipelineNotificationsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ElastictranscoderPipelineNotificationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElastictranscoderPipelineNotificationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCompleted")]
        public virtual void ResetCompleted()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetError")]
        public virtual void ResetError()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProgressing")]
        public virtual void ResetProgressing()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWarning")]
        public virtual void ResetWarning()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "completedInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompletedInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "errorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ErrorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "progressingInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProgressingInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "warningInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WarningInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "completed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Completed
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "error", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Error
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "progressing", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Progressing
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "warning", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Warning
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.elastictranscoderPipeline.ElastictranscoderPipelineNotifications\"}", isOptional: true)]
        public virtual aws.ElastictranscoderPipeline.IElastictranscoderPipelineNotifications? InternalValue
        {
            get => GetInstanceProperty<aws.ElastictranscoderPipeline.IElastictranscoderPipelineNotifications?>();
            set => SetInstanceProperty(value);
        }
    }
}
