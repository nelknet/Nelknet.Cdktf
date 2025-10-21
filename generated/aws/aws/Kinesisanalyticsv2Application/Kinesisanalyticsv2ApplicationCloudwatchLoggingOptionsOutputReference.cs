using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesisanalyticsv2Application
{
    [JsiiClass(nativeType: typeof(aws.Kinesisanalyticsv2Application.Kinesisanalyticsv2ApplicationCloudwatchLoggingOptionsOutputReference), fullyQualifiedName: "aws.kinesisanalyticsv2Application.Kinesisanalyticsv2ApplicationCloudwatchLoggingOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Kinesisanalyticsv2ApplicationCloudwatchLoggingOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Kinesisanalyticsv2ApplicationCloudwatchLoggingOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected Kinesisanalyticsv2ApplicationCloudwatchLoggingOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Kinesisanalyticsv2ApplicationCloudwatchLoggingOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "cloudwatchLoggingOptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudwatchLoggingOptionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "logStreamArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogStreamArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "logStreamArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogStreamArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.kinesisanalyticsv2Application.Kinesisanalyticsv2ApplicationCloudwatchLoggingOptions\"}", isOptional: true)]
        public virtual aws.Kinesisanalyticsv2Application.IKinesisanalyticsv2ApplicationCloudwatchLoggingOptions? InternalValue
        {
            get => GetInstanceProperty<aws.Kinesisanalyticsv2Application.IKinesisanalyticsv2ApplicationCloudwatchLoggingOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
