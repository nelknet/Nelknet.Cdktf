using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265Settings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265Settings")]
    public interface IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265Settings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#bitrate MedialiveChannel#bitrate}.</summary>
        [JsiiProperty(name: "bitrate", typeJson: "{\"primitive\":\"number\"}")]
        double Bitrate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#framerate_denominator MedialiveChannel#framerate_denominator}.</summary>
        [JsiiProperty(name: "framerateDenominator", typeJson: "{\"primitive\":\"number\"}")]
        double FramerateDenominator
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#framerate_numerator MedialiveChannel#framerate_numerator}.</summary>
        [JsiiProperty(name: "framerateNumerator", typeJson: "{\"primitive\":\"number\"}")]
        double FramerateNumerator
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#adaptive_quantization MedialiveChannel#adaptive_quantization}.</summary>
        [JsiiProperty(name: "adaptiveQuantization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdaptiveQuantization
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#afd_signaling MedialiveChannel#afd_signaling}.</summary>
        [JsiiProperty(name: "afdSignaling", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AfdSignaling
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#alternative_transfer_function MedialiveChannel#alternative_transfer_function}.</summary>
        [JsiiProperty(name: "alternativeTransferFunction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AlternativeTransferFunction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#buf_size MedialiveChannel#buf_size}.</summary>
        [JsiiProperty(name: "bufSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BufSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#color_metadata MedialiveChannel#color_metadata}.</summary>
        [JsiiProperty(name: "colorMetadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ColorMetadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>color_space_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#color_space_settings MedialiveChannel#color_space_settings}
        /// </remarks>
        [JsiiProperty(name: "colorSpaceSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettings? ColorSpaceSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>filter_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#filter_settings MedialiveChannel#filter_settings}
        /// </remarks>
        [JsiiProperty(name: "filterSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettings? FilterSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#fixed_afd MedialiveChannel#fixed_afd}.</summary>
        [JsiiProperty(name: "fixedAfd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FixedAfd
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#flicker_aq MedialiveChannel#flicker_aq}.</summary>
        [JsiiProperty(name: "flickerAq", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FlickerAq
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#gop_closed_cadence MedialiveChannel#gop_closed_cadence}.</summary>
        [JsiiProperty(name: "gopClosedCadence", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? GopClosedCadence
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#gop_size MedialiveChannel#gop_size}.</summary>
        [JsiiProperty(name: "gopSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? GopSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#gop_size_units MedialiveChannel#gop_size_units}.</summary>
        [JsiiProperty(name: "gopSizeUnits", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GopSizeUnits
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#level MedialiveChannel#level}.</summary>
        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Level
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#look_ahead_rate_control MedialiveChannel#look_ahead_rate_control}.</summary>
        [JsiiProperty(name: "lookAheadRateControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LookAheadRateControl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#max_bitrate MedialiveChannel#max_bitrate}.</summary>
        [JsiiProperty(name: "maxBitrate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxBitrate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#min_i_interval MedialiveChannel#min_i_interval}.</summary>
        [JsiiProperty(name: "minIInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinIInterval
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#min_qp MedialiveChannel#min_qp}.</summary>
        [JsiiProperty(name: "minQp", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinQp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#mv_over_picture_boundaries MedialiveChannel#mv_over_picture_boundaries}.</summary>
        [JsiiProperty(name: "mvOverPictureBoundaries", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MvOverPictureBoundaries
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#mv_temporal_predictor MedialiveChannel#mv_temporal_predictor}.</summary>
        [JsiiProperty(name: "mvTemporalPredictor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MvTemporalPredictor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#par_denominator MedialiveChannel#par_denominator}.</summary>
        [JsiiProperty(name: "parDenominator", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ParDenominator
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#par_numerator MedialiveChannel#par_numerator}.</summary>
        [JsiiProperty(name: "parNumerator", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ParNumerator
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#profile MedialiveChannel#profile}.</summary>
        [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Profile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#qvbr_quality_level MedialiveChannel#qvbr_quality_level}.</summary>
        [JsiiProperty(name: "qvbrQualityLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? QvbrQualityLevel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#rate_control_mode MedialiveChannel#rate_control_mode}.</summary>
        [JsiiProperty(name: "rateControlMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RateControlMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#scan_type MedialiveChannel#scan_type}.</summary>
        [JsiiProperty(name: "scanType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScanType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#scene_change_detect MedialiveChannel#scene_change_detect}.</summary>
        [JsiiProperty(name: "sceneChangeDetect", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SceneChangeDetect
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#slices MedialiveChannel#slices}.</summary>
        [JsiiProperty(name: "slices", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Slices
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#tier MedialiveChannel#tier}.</summary>
        [JsiiProperty(name: "tier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Tier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#tile_height MedialiveChannel#tile_height}.</summary>
        [JsiiProperty(name: "tileHeight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TileHeight
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#tile_padding MedialiveChannel#tile_padding}.</summary>
        [JsiiProperty(name: "tilePadding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TilePadding
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#tile_width MedialiveChannel#tile_width}.</summary>
        [JsiiProperty(name: "tileWidth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TileWidth
        {
            get
            {
                return null;
            }
        }

        /// <summary>timecode_burnin_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timecode_burnin_settings MedialiveChannel#timecode_burnin_settings}
        /// </remarks>
        [JsiiProperty(name: "timecodeBurninSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsTimecodeBurninSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsTimecodeBurninSettings? TimecodeBurninSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timecode_insertion MedialiveChannel#timecode_insertion}.</summary>
        [JsiiProperty(name: "timecodeInsertion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimecodeInsertion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#treeblock_size MedialiveChannel#treeblock_size}.</summary>
        [JsiiProperty(name: "treeblockSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TreeblockSize
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265Settings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265Settings")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265Settings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#bitrate MedialiveChannel#bitrate}.</summary>
            [JsiiProperty(name: "bitrate", typeJson: "{\"primitive\":\"number\"}")]
            public double Bitrate
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#framerate_denominator MedialiveChannel#framerate_denominator}.</summary>
            [JsiiProperty(name: "framerateDenominator", typeJson: "{\"primitive\":\"number\"}")]
            public double FramerateDenominator
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#framerate_numerator MedialiveChannel#framerate_numerator}.</summary>
            [JsiiProperty(name: "framerateNumerator", typeJson: "{\"primitive\":\"number\"}")]
            public double FramerateNumerator
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#adaptive_quantization MedialiveChannel#adaptive_quantization}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "adaptiveQuantization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdaptiveQuantization
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#afd_signaling MedialiveChannel#afd_signaling}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "afdSignaling", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AfdSignaling
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#alternative_transfer_function MedialiveChannel#alternative_transfer_function}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "alternativeTransferFunction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AlternativeTransferFunction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#buf_size MedialiveChannel#buf_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bufSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BufSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#color_metadata MedialiveChannel#color_metadata}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "colorMetadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ColorMetadata
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>color_space_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#color_space_settings MedialiveChannel#color_space_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "colorSpaceSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettings\"}", isOptional: true)]
            public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettings? ColorSpaceSettings
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettings?>();
            }

            /// <summary>filter_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#filter_settings MedialiveChannel#filter_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filterSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettings\"}", isOptional: true)]
            public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettings? FilterSettings
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#fixed_afd MedialiveChannel#fixed_afd}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fixedAfd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FixedAfd
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#flicker_aq MedialiveChannel#flicker_aq}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "flickerAq", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FlickerAq
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#gop_closed_cadence MedialiveChannel#gop_closed_cadence}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gopClosedCadence", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? GopClosedCadence
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#gop_size MedialiveChannel#gop_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gopSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? GopSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#gop_size_units MedialiveChannel#gop_size_units}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gopSizeUnits", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GopSizeUnits
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#level MedialiveChannel#level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Level
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#look_ahead_rate_control MedialiveChannel#look_ahead_rate_control}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lookAheadRateControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LookAheadRateControl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#max_bitrate MedialiveChannel#max_bitrate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxBitrate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxBitrate
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#min_i_interval MedialiveChannel#min_i_interval}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minIInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinIInterval
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#min_qp MedialiveChannel#min_qp}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minQp", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinQp
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#mv_over_picture_boundaries MedialiveChannel#mv_over_picture_boundaries}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mvOverPictureBoundaries", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MvOverPictureBoundaries
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#mv_temporal_predictor MedialiveChannel#mv_temporal_predictor}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mvTemporalPredictor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MvTemporalPredictor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#par_denominator MedialiveChannel#par_denominator}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parDenominator", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ParDenominator
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#par_numerator MedialiveChannel#par_numerator}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parNumerator", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ParNumerator
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#profile MedialiveChannel#profile}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Profile
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#qvbr_quality_level MedialiveChannel#qvbr_quality_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "qvbrQualityLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? QvbrQualityLevel
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#rate_control_mode MedialiveChannel#rate_control_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rateControlMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RateControlMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#scan_type MedialiveChannel#scan_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scanType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScanType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#scene_change_detect MedialiveChannel#scene_change_detect}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sceneChangeDetect", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SceneChangeDetect
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#slices MedialiveChannel#slices}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "slices", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Slices
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#tier MedialiveChannel#tier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#tile_height MedialiveChannel#tile_height}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tileHeight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TileHeight
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#tile_padding MedialiveChannel#tile_padding}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tilePadding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TilePadding
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#tile_width MedialiveChannel#tile_width}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tileWidth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TileWidth
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timecode_burnin_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timecode_burnin_settings MedialiveChannel#timecode_burnin_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timecodeBurninSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsTimecodeBurninSettings\"}", isOptional: true)]
            public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsTimecodeBurninSettings? TimecodeBurninSettings
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsTimecodeBurninSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timecode_insertion MedialiveChannel#timecode_insertion}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timecodeInsertion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimecodeInsertion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#treeblock_size MedialiveChannel#treeblock_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "treeblockSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TreeblockSize
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
