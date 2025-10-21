using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontRealtimeLogConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfigEndpoint")]
    public class CloudfrontRealtimeLogConfigEndpoint : aws.CloudfrontRealtimeLogConfig.ICloudfrontRealtimeLogConfigEndpoint
    {
        /// <summary>kinesis_stream_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_realtime_log_config#kinesis_stream_config CloudfrontRealtimeLogConfig#kinesis_stream_config}
        /// </remarks>
        [JsiiProperty(name: "kinesisStreamConfig", typeJson: "{\"fqn\":\"aws.cloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfigEndpointKinesisStreamConfig\"}")]
        public aws.CloudfrontRealtimeLogConfig.ICloudfrontRealtimeLogConfigEndpointKinesisStreamConfig KinesisStreamConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_realtime_log_config#stream_type CloudfrontRealtimeLogConfig#stream_type}.</summary>
        [JsiiProperty(name: "streamType", typeJson: "{\"primitive\":\"string\"}")]
        public string StreamType
        {
            get;
            set;
        }
    }
}
