using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IvschatLoggingConfiguration
{
    [JsiiClass(nativeType: typeof(aws.IvschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationOutputReference), fullyQualifiedName: "aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IvschatLoggingConfigurationDestinationConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IvschatLoggingConfigurationDestinationConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IvschatLoggingConfigurationDestinationConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IvschatLoggingConfigurationDestinationConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCloudwatchLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationCloudwatchLogs\"}}]")]
        public virtual void PutCloudwatchLogs(aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationCloudwatchLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationCloudwatchLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFirehose", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationFirehose\"}}]")]
        public virtual void PutFirehose(aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationFirehose @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationFirehose)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationS3\"}}]")]
        public virtual void PutS3(aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationS3 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationS3)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudwatchLogs")]
        public virtual void ResetCloudwatchLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFirehose")]
        public virtual void ResetFirehose()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3")]
        public virtual void ResetS3()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationCloudwatchLogsOutputReference\"}")]
        public virtual aws.IvschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationCloudwatchLogsOutputReference CloudwatchLogs
        {
            get => GetInstanceProperty<aws.IvschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationCloudwatchLogsOutputReference>()!;
        }

        [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationFirehoseOutputReference\"}")]
        public virtual aws.IvschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationFirehoseOutputReference Firehose
        {
            get => GetInstanceProperty<aws.IvschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationFirehoseOutputReference>()!;
        }

        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationS3OutputReference\"}")]
        public virtual aws.IvschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationS3OutputReference S3
        {
            get => GetInstanceProperty<aws.IvschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationS3OutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogsInput", typeJson: "{\"fqn\":\"aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationCloudwatchLogs\"}", isOptional: true)]
        public virtual aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationCloudwatchLogs? CloudwatchLogsInput
        {
            get => GetInstanceProperty<aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationCloudwatchLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firehoseInput", typeJson: "{\"fqn\":\"aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationFirehose\"}", isOptional: true)]
        public virtual aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationFirehose? FirehoseInput
        {
            get => GetInstanceProperty<aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationFirehose?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3Input", typeJson: "{\"fqn\":\"aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationS3\"}", isOptional: true)]
        public virtual aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationS3? S3Input
        {
            get => GetInstanceProperty<aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationS3?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfiguration\"}", isOptional: true)]
        public virtual aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
