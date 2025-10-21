using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsCodecSettings")]
    public class MedialiveChannelEncoderSettingsAudioDescriptionsCodecSettings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptionsCodecSettings
    {
        /// <summary>aac_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#aac_settings MedialiveChannel#aac_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "aacSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsAacSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsAacSettings? AacSettings
        {
            get;
            set;
        }

        /// <summary>ac3_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#ac3_settings MedialiveChannel#ac3_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ac3Settings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsAc3Settings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsAc3Settings? Ac3Settings
        {
            get;
            set;
        }

        /// <summary>eac3_atmos_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#eac3_atmos_settings MedialiveChannel#eac3_atmos_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eac3AtmosSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsEac3AtmosSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsEac3AtmosSettings? Eac3AtmosSettings
        {
            get;
            set;
        }

        /// <summary>eac3_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#eac3_settings MedialiveChannel#eac3_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eac3Settings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsEac3Settings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsEac3Settings? Eac3Settings
        {
            get;
            set;
        }

        /// <summary>mp2_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#mp2_settings MedialiveChannel#mp2_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mp2Settings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsMp2Settings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsMp2Settings? Mp2Settings
        {
            get;
            set;
        }

        /// <summary>pass_through_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#pass_through_settings MedialiveChannel#pass_through_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "passThroughSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsPassThroughSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsPassThroughSettings? PassThroughSettings
        {
            get;
            set;
        }

        /// <summary>wav_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#wav_settings MedialiveChannel#wav_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "wavSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsWavSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsWavSettings? WavSettings
        {
            get;
            set;
        }
    }
}
