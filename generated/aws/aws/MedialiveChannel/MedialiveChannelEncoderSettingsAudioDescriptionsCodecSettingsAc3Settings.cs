using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsAc3Settings")]
    public class MedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsAc3Settings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsAc3Settings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#bitrate MedialiveChannel#bitrate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bitrate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Bitrate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#bitstream_mode MedialiveChannel#bitstream_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bitstreamMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BitstreamMode
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#drc_profile MedialiveChannel#drc_profile}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "drcProfile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DrcProfile
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#lfe_filter MedialiveChannel#lfe_filter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lfeFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LfeFilter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#metadata_control MedialiveChannel#metadata_control}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metadataControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MetadataControl
        {
            get;
            set;
        }
    }
}
