using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiClass(nativeType: typeof(aws.PipesPipe.PipesPipeLogConfigurationOutputReference), fullyQualifiedName: "aws.pipesPipe.PipesPipeLogConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PipesPipeLogConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PipesPipeLogConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PipesPipeLogConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PipesPipeLogConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCloudwatchLogsLogDestination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeLogConfigurationCloudwatchLogsLogDestination\"}}]")]
        public virtual void PutCloudwatchLogsLogDestination(aws.PipesPipe.IPipesPipeLogConfigurationCloudwatchLogsLogDestination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeLogConfigurationCloudwatchLogsLogDestination)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFirehoseLogDestination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeLogConfigurationFirehoseLogDestination\"}}]")]
        public virtual void PutFirehoseLogDestination(aws.PipesPipe.IPipesPipeLogConfigurationFirehoseLogDestination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeLogConfigurationFirehoseLogDestination)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3LogDestination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeLogConfigurationS3LogDestination\"}}]")]
        public virtual void PutS3LogDestination(aws.PipesPipe.IPipesPipeLogConfigurationS3LogDestination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeLogConfigurationS3LogDestination)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudwatchLogsLogDestination")]
        public virtual void ResetCloudwatchLogsLogDestination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFirehoseLogDestination")]
        public virtual void ResetFirehoseLogDestination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIncludeExecutionData")]
        public virtual void ResetIncludeExecutionData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3LogDestination")]
        public virtual void ResetS3LogDestination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cloudwatchLogsLogDestination", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeLogConfigurationCloudwatchLogsLogDestinationOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeLogConfigurationCloudwatchLogsLogDestinationOutputReference CloudwatchLogsLogDestination
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeLogConfigurationCloudwatchLogsLogDestinationOutputReference>()!;
        }

        [JsiiProperty(name: "firehoseLogDestination", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeLogConfigurationFirehoseLogDestinationOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeLogConfigurationFirehoseLogDestinationOutputReference FirehoseLogDestination
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeLogConfigurationFirehoseLogDestinationOutputReference>()!;
        }

        [JsiiProperty(name: "s3LogDestination", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeLogConfigurationS3LogDestinationOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeLogConfigurationS3LogDestinationOutputReference S3LogDestination
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeLogConfigurationS3LogDestinationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogsLogDestinationInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeLogConfigurationCloudwatchLogsLogDestination\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeLogConfigurationCloudwatchLogsLogDestination? CloudwatchLogsLogDestinationInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeLogConfigurationCloudwatchLogsLogDestination?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firehoseLogDestinationInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeLogConfigurationFirehoseLogDestination\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeLogConfigurationFirehoseLogDestination? FirehoseLogDestinationInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeLogConfigurationFirehoseLogDestination?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeExecutionDataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? IncludeExecutionDataInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "levelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3LogDestinationInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeLogConfigurationS3LogDestination\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeLogConfigurationS3LogDestination? S3LogDestinationInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeLogConfigurationS3LogDestination?>();
        }

        [JsiiProperty(name: "includeExecutionData", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IncludeExecutionData
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Level
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeLogConfiguration\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeLogConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeLogConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
