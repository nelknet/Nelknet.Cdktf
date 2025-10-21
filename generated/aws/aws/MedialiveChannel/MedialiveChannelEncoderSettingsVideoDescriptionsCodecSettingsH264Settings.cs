using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264Settings")]
    public class MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264Settings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264Settings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#adaptive_quantization MedialiveChannel#adaptive_quantization}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adaptiveQuantization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdaptiveQuantization
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#afd_signaling MedialiveChannel#afd_signaling}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "afdSignaling", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AfdSignaling
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#buf_fill_pct MedialiveChannel#buf_fill_pct}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bufFillPct", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BufFillPct
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#buf_size MedialiveChannel#buf_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bufSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BufSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#color_metadata MedialiveChannel#color_metadata}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "colorMetadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ColorMetadata
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#entropy_encoding MedialiveChannel#entropy_encoding}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "entropyEncoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EntropyEncoding
        {
            get;
            set;
        }

        /// <summary>filter_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#filter_settings MedialiveChannel#filter_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filterSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettings? FilterSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#fixed_afd MedialiveChannel#fixed_afd}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fixedAfd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FixedAfd
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#flicker_aq MedialiveChannel#flicker_aq}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "flickerAq", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FlickerAq
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#force_field_pictures MedialiveChannel#force_field_pictures}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "forceFieldPictures", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ForceFieldPictures
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#framerate_control MedialiveChannel#framerate_control}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "framerateControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FramerateControl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#framerate_denominator MedialiveChannel#framerate_denominator}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "framerateDenominator", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FramerateDenominator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#framerate_numerator MedialiveChannel#framerate_numerator}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "framerateNumerator", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FramerateNumerator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#gop_b_reference MedialiveChannel#gop_b_reference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gopBReference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GopBReference
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#gop_closed_cadence MedialiveChannel#gop_closed_cadence}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gopClosedCadence", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GopClosedCadence
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#gop_num_b_frames MedialiveChannel#gop_num_b_frames}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gopNumBFrames", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GopNumBFrames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#gop_size MedialiveChannel#gop_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gopSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GopSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#gop_size_units MedialiveChannel#gop_size_units}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gopSizeUnits", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GopSizeUnits
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#level MedialiveChannel#level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Level
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#look_ahead_rate_control MedialiveChannel#look_ahead_rate_control}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lookAheadRateControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LookAheadRateControl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#max_bitrate MedialiveChannel#max_bitrate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxBitrate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxBitrate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#min_i_interval MedialiveChannel#min_i_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minIInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinIInterval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#num_ref_frames MedialiveChannel#num_ref_frames}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "numRefFrames", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NumRefFrames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#par_control MedialiveChannel#par_control}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ParControl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#par_denominator MedialiveChannel#par_denominator}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parDenominator", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ParDenominator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#par_numerator MedialiveChannel#par_numerator}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parNumerator", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ParNumerator
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#quality_level MedialiveChannel#quality_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "qualityLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? QualityLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#qvbr_quality_level MedialiveChannel#qvbr_quality_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "qvbrQualityLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? QvbrQualityLevel
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#scan_type MedialiveChannel#scan_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scanType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScanType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#scene_change_detect MedialiveChannel#scene_change_detect}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sceneChangeDetect", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SceneChangeDetect
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#slices MedialiveChannel#slices}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "slices", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Slices
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#softness MedialiveChannel#softness}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "softness", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Softness
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#spatial_aq MedialiveChannel#spatial_aq}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "spatialAq", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SpatialAq
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#subgop_length MedialiveChannel#subgop_length}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subgopLength", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubgopLength
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#syntax MedialiveChannel#syntax}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "syntax", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Syntax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#temporal_aq MedialiveChannel#temporal_aq}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "temporalAq", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TemporalAq
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timecode_insertion MedialiveChannel#timecode_insertion}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timecodeInsertion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimecodeInsertion
        {
            get;
            set;
        }
    }
}
