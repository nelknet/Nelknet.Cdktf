using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsEac3AtmosSettings")]
    public class MedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsEac3AtmosSettings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsEac3AtmosSettings
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#dialnorm MedialiveChannel#dialnorm}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dialnorm", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Dialnorm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#drc_line MedialiveChannel#drc_line}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "drcLine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DrcLine
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#drc_rf MedialiveChannel#drc_rf}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "drcRf", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DrcRf
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#height_trim MedialiveChannel#height_trim}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "heightTrim", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HeightTrim
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#surround_trim MedialiveChannel#surround_trim}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "surroundTrim", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SurroundTrim
        {
            get;
            set;
        }
    }
}
