using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsEac3Settings")]
    public class MedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsEac3Settings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsEac3Settings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#attenuation_control MedialiveChannel#attenuation_control}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attenuationControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AttenuationControl
        {
            get;
            set;
        }

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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#dc_filter MedialiveChannel#dc_filter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dcFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DcFilter
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#lfe_control MedialiveChannel#lfe_control}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lfeControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LfeControl
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#lo_ro_center_mix_level MedialiveChannel#lo_ro_center_mix_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loRoCenterMixLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LoRoCenterMixLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#lo_ro_surround_mix_level MedialiveChannel#lo_ro_surround_mix_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loRoSurroundMixLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LoRoSurroundMixLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#lt_rt_center_mix_level MedialiveChannel#lt_rt_center_mix_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ltRtCenterMixLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LtRtCenterMixLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#lt_rt_surround_mix_level MedialiveChannel#lt_rt_surround_mix_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ltRtSurroundMixLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LtRtSurroundMixLevel
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#passthrough_control MedialiveChannel#passthrough_control}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "passthroughControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PassthroughControl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#phase_control MedialiveChannel#phase_control}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "phaseControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PhaseControl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#stereo_downmix MedialiveChannel#stereo_downmix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stereoDownmix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StereoDownmix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#surround_ex_mode MedialiveChannel#surround_ex_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "surroundExMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SurroundExMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#surround_mode MedialiveChannel#surround_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "surroundMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SurroundMode
        {
            get;
            set;
        }
    }
}
