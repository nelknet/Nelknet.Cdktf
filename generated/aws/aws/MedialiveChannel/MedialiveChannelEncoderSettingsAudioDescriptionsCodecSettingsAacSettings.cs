using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsAacSettings")]
    public class MedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsAacSettings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsAacSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#bitrate MedialiveChannel#bitrate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bitrate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Bitrate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#coding_mode MedialiveChannel#coding_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "codingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CodingMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_type MedialiveChannel#input_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InputType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#profile MedialiveChannel#profile}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Profile
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#rate_control_mode MedialiveChannel#rate_control_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rateControlMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RateControlMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#raw_format MedialiveChannel#raw_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rawFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RawFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#sample_rate MedialiveChannel#sample_rate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SampleRate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#spec MedialiveChannel#spec}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "spec", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Spec
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#vbr_quality MedialiveChannel#vbr_quality}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vbrQuality", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VbrQuality
        {
            get;
            set;
        }
    }
}
