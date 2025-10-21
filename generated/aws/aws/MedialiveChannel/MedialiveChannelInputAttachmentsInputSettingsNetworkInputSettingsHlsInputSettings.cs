using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsNetworkInputSettingsHlsInputSettings")]
    public class MedialiveChannelInputAttachmentsInputSettingsNetworkInputSettingsHlsInputSettings : aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsNetworkInputSettingsHlsInputSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#bandwidth MedialiveChannel#bandwidth}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bandwidth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Bandwidth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#buffer_segments MedialiveChannel#buffer_segments}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bufferSegments", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BufferSegments
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#retries MedialiveChannel#retries}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Retries
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#retry_interval MedialiveChannel#retry_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retryInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetryInterval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#scte35_source MedialiveChannel#scte35_source}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scte35Source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Scte35Source
        {
            get;
            set;
        }
    }
}
