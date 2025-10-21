using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettings")]
    public class MedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettings
    {
        /// <summary>arib_destination_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#arib_destination_settings MedialiveChannel#arib_destination_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "aribDestinationSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsAribDestinationSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsAribDestinationSettings? AribDestinationSettings
        {
            get;
            set;
        }

        /// <summary>burn_in_destination_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#burn_in_destination_settings MedialiveChannel#burn_in_destination_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "burnInDestinationSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettings? BurnInDestinationSettings
        {
            get;
            set;
        }

        /// <summary>dvb_sub_destination_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#dvb_sub_destination_settings MedialiveChannel#dvb_sub_destination_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dvbSubDestinationSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsDvbSubDestinationSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsDvbSubDestinationSettings? DvbSubDestinationSettings
        {
            get;
            set;
        }

        /// <summary>ebu_tt_d_destination_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#ebu_tt_d_destination_settings MedialiveChannel#ebu_tt_d_destination_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ebuTtDDestinationSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsEbuTtDDestinationSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsEbuTtDDestinationSettings? EbuTtDDestinationSettings
        {
            get;
            set;
        }

        /// <summary>embedded_destination_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#embedded_destination_settings MedialiveChannel#embedded_destination_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "embeddedDestinationSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedDestinationSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedDestinationSettings? EmbeddedDestinationSettings
        {
            get;
            set;
        }

        /// <summary>embedded_plus_scte20_destination_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#embedded_plus_scte20_destination_settings MedialiveChannel#embedded_plus_scte20_destination_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "embeddedPlusScte20DestinationSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedPlusScte20DestinationSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedPlusScte20DestinationSettings? EmbeddedPlusScte20DestinationSettings
        {
            get;
            set;
        }

        /// <summary>rtmp_caption_info_destination_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#rtmp_caption_info_destination_settings MedialiveChannel#rtmp_caption_info_destination_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rtmpCaptionInfoDestinationSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsRtmpCaptionInfoDestinationSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsRtmpCaptionInfoDestinationSettings? RtmpCaptionInfoDestinationSettings
        {
            get;
            set;
        }

        /// <summary>scte20_plus_embedded_destination_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#scte20_plus_embedded_destination_settings MedialiveChannel#scte20_plus_embedded_destination_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scte20PlusEmbeddedDestinationSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsScte20PlusEmbeddedDestinationSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsScte20PlusEmbeddedDestinationSettings? Scte20PlusEmbeddedDestinationSettings
        {
            get;
            set;
        }

        /// <summary>scte27_destination_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#scte27_destination_settings MedialiveChannel#scte27_destination_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scte27DestinationSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsScte27DestinationSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsScte27DestinationSettings? Scte27DestinationSettings
        {
            get;
            set;
        }

        /// <summary>smpte_tt_destination_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#smpte_tt_destination_settings MedialiveChannel#smpte_tt_destination_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "smpteTtDestinationSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsSmpteTtDestinationSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsSmpteTtDestinationSettings? SmpteTtDestinationSettings
        {
            get;
            set;
        }

        /// <summary>teletext_destination_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#teletext_destination_settings MedialiveChannel#teletext_destination_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "teletextDestinationSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsTeletextDestinationSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsTeletextDestinationSettings? TeletextDestinationSettings
        {
            get;
            set;
        }

        /// <summary>ttml_destination_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#ttml_destination_settings MedialiveChannel#ttml_destination_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ttmlDestinationSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsTtmlDestinationSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsTtmlDestinationSettings? TtmlDestinationSettings
        {
            get;
            set;
        }

        /// <summary>webvtt_destination_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#webvtt_destination_settings MedialiveChannel#webvtt_destination_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "webvttDestinationSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsWebvttDestinationSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsWebvttDestinationSettings? WebvttDestinationSettings
        {
            get;
            set;
        }
    }
}
