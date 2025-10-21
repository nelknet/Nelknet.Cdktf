using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontRealtimeLogConfig
{
    [JsiiClass(nativeType: typeof(aws.CloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfigEndpointOutputReference), fullyQualifiedName: "aws.cloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfigEndpointOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudfrontRealtimeLogConfigEndpointOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudfrontRealtimeLogConfigEndpointOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudfrontRealtimeLogConfigEndpointOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontRealtimeLogConfigEndpointOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putKinesisStreamConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfigEndpointKinesisStreamConfig\"}}]")]
        public virtual void PutKinesisStreamConfig(aws.CloudfrontRealtimeLogConfig.ICloudfrontRealtimeLogConfigEndpointKinesisStreamConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontRealtimeLogConfig.ICloudfrontRealtimeLogConfigEndpointKinesisStreamConfig)}, new object[]{@value});
        }

        [JsiiProperty(name: "kinesisStreamConfig", typeJson: "{\"fqn\":\"aws.cloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfigEndpointKinesisStreamConfigOutputReference\"}")]
        public virtual aws.CloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfigEndpointKinesisStreamConfigOutputReference KinesisStreamConfig
        {
            get => GetInstanceProperty<aws.CloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfigEndpointKinesisStreamConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kinesisStreamConfigInput", typeJson: "{\"fqn\":\"aws.cloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfigEndpointKinesisStreamConfig\"}", isOptional: true)]
        public virtual aws.CloudfrontRealtimeLogConfig.ICloudfrontRealtimeLogConfigEndpointKinesisStreamConfig? KinesisStreamConfigInput
        {
            get => GetInstanceProperty<aws.CloudfrontRealtimeLogConfig.ICloudfrontRealtimeLogConfigEndpointKinesisStreamConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "streamTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StreamTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "streamType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfigEndpoint\"}", isOptional: true)]
        public virtual aws.CloudfrontRealtimeLogConfig.ICloudfrontRealtimeLogConfigEndpoint? InternalValue
        {
            get => GetInstanceProperty<aws.CloudfrontRealtimeLogConfig.ICloudfrontRealtimeLogConfigEndpoint?>();
            set => SetInstanceProperty(value);
        }
    }
}
