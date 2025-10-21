using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings")]
    public class MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#capture_interval MedialiveChannel#capture_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "captureInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CaptureInterval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#capture_interval_units MedialiveChannel#capture_interval_units}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "captureIntervalUnits", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CaptureIntervalUnits
        {
            get;
            set;
        }
    }
}
