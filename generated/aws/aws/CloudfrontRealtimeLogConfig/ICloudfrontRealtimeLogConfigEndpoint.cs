using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontRealtimeLogConfig
{
    [JsiiInterface(nativeType: typeof(ICloudfrontRealtimeLogConfigEndpoint), fullyQualifiedName: "aws.cloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfigEndpoint")]
    public interface ICloudfrontRealtimeLogConfigEndpoint
    {
        /// <summary>kinesis_stream_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_realtime_log_config#kinesis_stream_config CloudfrontRealtimeLogConfig#kinesis_stream_config}
        /// </remarks>
        [JsiiProperty(name: "kinesisStreamConfig", typeJson: "{\"fqn\":\"aws.cloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfigEndpointKinesisStreamConfig\"}")]
        aws.CloudfrontRealtimeLogConfig.ICloudfrontRealtimeLogConfigEndpointKinesisStreamConfig KinesisStreamConfig
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_realtime_log_config#stream_type CloudfrontRealtimeLogConfig#stream_type}.</summary>
        [JsiiProperty(name: "streamType", typeJson: "{\"primitive\":\"string\"}")]
        string StreamType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontRealtimeLogConfigEndpoint), fullyQualifiedName: "aws.cloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfigEndpoint")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontRealtimeLogConfig.ICloudfrontRealtimeLogConfigEndpoint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>kinesis_stream_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_realtime_log_config#kinesis_stream_config CloudfrontRealtimeLogConfig#kinesis_stream_config}
            /// </remarks>
            [JsiiProperty(name: "kinesisStreamConfig", typeJson: "{\"fqn\":\"aws.cloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfigEndpointKinesisStreamConfig\"}")]
            public aws.CloudfrontRealtimeLogConfig.ICloudfrontRealtimeLogConfigEndpointKinesisStreamConfig KinesisStreamConfig
            {
                get => GetInstanceProperty<aws.CloudfrontRealtimeLogConfig.ICloudfrontRealtimeLogConfigEndpointKinesisStreamConfig>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_realtime_log_config#stream_type CloudfrontRealtimeLogConfig#stream_type}.</summary>
            [JsiiProperty(name: "streamType", typeJson: "{\"primitive\":\"string\"}")]
            public string StreamType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
