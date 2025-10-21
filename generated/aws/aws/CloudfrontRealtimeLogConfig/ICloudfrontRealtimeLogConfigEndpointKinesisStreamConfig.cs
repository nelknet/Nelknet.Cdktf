using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontRealtimeLogConfig
{
    [JsiiInterface(nativeType: typeof(ICloudfrontRealtimeLogConfigEndpointKinesisStreamConfig), fullyQualifiedName: "aws.cloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfigEndpointKinesisStreamConfig")]
    public interface ICloudfrontRealtimeLogConfigEndpointKinesisStreamConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_realtime_log_config#role_arn CloudfrontRealtimeLogConfig#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_realtime_log_config#stream_arn CloudfrontRealtimeLogConfig#stream_arn}.</summary>
        [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}")]
        string StreamArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontRealtimeLogConfigEndpointKinesisStreamConfig), fullyQualifiedName: "aws.cloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfigEndpointKinesisStreamConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontRealtimeLogConfig.ICloudfrontRealtimeLogConfigEndpointKinesisStreamConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_realtime_log_config#role_arn CloudfrontRealtimeLogConfig#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_realtime_log_config#stream_arn CloudfrontRealtimeLogConfig#stream_arn}.</summary>
            [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}")]
            public string StreamArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
