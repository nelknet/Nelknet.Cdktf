using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings")]
    public interface IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings
    {
        /// <summary>destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#destination MedialiveChannel#destination}
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsDestination\"}")]
        aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsDestination Destination
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#ad_markers MedialiveChannel#ad_markers}.</summary>
        [JsiiProperty(name: "adMarkers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AdMarkers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#base_url_content MedialiveChannel#base_url_content}.</summary>
        [JsiiProperty(name: "baseUrlContent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BaseUrlContent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#base_url_content1 MedialiveChannel#base_url_content1}.</summary>
        [JsiiProperty(name: "baseUrlContent1", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BaseUrlContent1
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#base_url_manifest MedialiveChannel#base_url_manifest}.</summary>
        [JsiiProperty(name: "baseUrlManifest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BaseUrlManifest
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#base_url_manifest1 MedialiveChannel#base_url_manifest1}.</summary>
        [JsiiProperty(name: "baseUrlManifest1", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BaseUrlManifest1
        {
            get
            {
                return null;
            }
        }

        /// <summary>caption_language_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#caption_language_mappings MedialiveChannel#caption_language_mappings}
        /// </remarks>
        [JsiiProperty(name: "captionLanguageMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsCaptionLanguageMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CaptionLanguageMappings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#caption_language_setting MedialiveChannel#caption_language_setting}.</summary>
        [JsiiProperty(name: "captionLanguageSetting", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CaptionLanguageSetting
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#client_cache MedialiveChannel#client_cache}.</summary>
        [JsiiProperty(name: "clientCache", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientCache
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#codec_specification MedialiveChannel#codec_specification}.</summary>
        [JsiiProperty(name: "codecSpecification", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CodecSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#constant_iv MedialiveChannel#constant_iv}.</summary>
        [JsiiProperty(name: "constantIv", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConstantIv
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#directory_structure MedialiveChannel#directory_structure}.</summary>
        [JsiiProperty(name: "directoryStructure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DirectoryStructure
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#discontinuity_tags MedialiveChannel#discontinuity_tags}.</summary>
        [JsiiProperty(name: "discontinuityTags", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DiscontinuityTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#encryption_type MedialiveChannel#encryption_type}.</summary>
        [JsiiProperty(name: "encryptionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EncryptionType
        {
            get
            {
                return null;
            }
        }

        /// <summary>hls_cdn_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#hls_cdn_settings MedialiveChannel#hls_cdn_settings}
        /// </remarks>
        [JsiiProperty(name: "hlsCdnSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HlsCdnSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#hls_id3_segment_tagging MedialiveChannel#hls_id3_segment_tagging}.</summary>
        [JsiiProperty(name: "hlsId3SegmentTagging", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HlsId3SegmentTagging
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#iframe_only_playlists MedialiveChannel#iframe_only_playlists}.</summary>
        [JsiiProperty(name: "iframeOnlyPlaylists", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IframeOnlyPlaylists
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#incomplete_segment_behavior MedialiveChannel#incomplete_segment_behavior}.</summary>
        [JsiiProperty(name: "incompleteSegmentBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IncompleteSegmentBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#index_n_segments MedialiveChannel#index_n_segments}.</summary>
        [JsiiProperty(name: "indexNSegments", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IndexNSegments
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_loss_action MedialiveChannel#input_loss_action}.</summary>
        [JsiiProperty(name: "inputLossAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InputLossAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#iv_in_manifest MedialiveChannel#iv_in_manifest}.</summary>
        [JsiiProperty(name: "ivInManifest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IvInManifest
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#iv_source MedialiveChannel#iv_source}.</summary>
        [JsiiProperty(name: "ivSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IvSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#keep_segments MedialiveChannel#keep_segments}.</summary>
        [JsiiProperty(name: "keepSegments", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? KeepSegments
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#key_format MedialiveChannel#key_format}.</summary>
        [JsiiProperty(name: "keyFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#key_format_versions MedialiveChannel#key_format_versions}.</summary>
        [JsiiProperty(name: "keyFormatVersions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyFormatVersions
        {
            get
            {
                return null;
            }
        }

        /// <summary>key_provider_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#key_provider_settings MedialiveChannel#key_provider_settings}
        /// </remarks>
        [JsiiProperty(name: "keyProviderSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettings? KeyProviderSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#manifest_compression MedialiveChannel#manifest_compression}.</summary>
        [JsiiProperty(name: "manifestCompression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManifestCompression
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#manifest_duration_format MedialiveChannel#manifest_duration_format}.</summary>
        [JsiiProperty(name: "manifestDurationFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManifestDurationFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#min_segment_length MedialiveChannel#min_segment_length}.</summary>
        [JsiiProperty(name: "minSegmentLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinSegmentLength
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#mode MedialiveChannel#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#output_selection MedialiveChannel#output_selection}.</summary>
        [JsiiProperty(name: "outputSelection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutputSelection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#program_date_time MedialiveChannel#program_date_time}.</summary>
        [JsiiProperty(name: "programDateTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProgramDateTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#program_date_time_clock MedialiveChannel#program_date_time_clock}.</summary>
        [JsiiProperty(name: "programDateTimeClock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProgramDateTimeClock
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#program_date_time_period MedialiveChannel#program_date_time_period}.</summary>
        [JsiiProperty(name: "programDateTimePeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ProgramDateTimePeriod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#redundant_manifest MedialiveChannel#redundant_manifest}.</summary>
        [JsiiProperty(name: "redundantManifest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RedundantManifest
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#segment_length MedialiveChannel#segment_length}.</summary>
        [JsiiProperty(name: "segmentLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SegmentLength
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#segments_per_subdirectory MedialiveChannel#segments_per_subdirectory}.</summary>
        [JsiiProperty(name: "segmentsPerSubdirectory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SegmentsPerSubdirectory
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#stream_inf_resolution MedialiveChannel#stream_inf_resolution}.</summary>
        [JsiiProperty(name: "streamInfResolution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StreamInfResolution
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timed_metadata_id3_frame MedialiveChannel#timed_metadata_id3_frame}.</summary>
        [JsiiProperty(name: "timedMetadataId3Frame", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimedMetadataId3Frame
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timed_metadata_id3_period MedialiveChannel#timed_metadata_id3_period}.</summary>
        [JsiiProperty(name: "timedMetadataId3Period", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TimedMetadataId3Period
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timestamp_delta_milliseconds MedialiveChannel#timestamp_delta_milliseconds}.</summary>
        [JsiiProperty(name: "timestampDeltaMilliseconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TimestampDeltaMilliseconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#ts_file_mode MedialiveChannel#ts_file_mode}.</summary>
        [JsiiProperty(name: "tsFileMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TsFileMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#destination MedialiveChannel#destination}
            /// </remarks>
            [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsDestination\"}")]
            public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsDestination Destination
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsDestination>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#ad_markers MedialiveChannel#ad_markers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "adMarkers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AdMarkers
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#base_url_content MedialiveChannel#base_url_content}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "baseUrlContent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BaseUrlContent
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#base_url_content1 MedialiveChannel#base_url_content1}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "baseUrlContent1", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BaseUrlContent1
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#base_url_manifest MedialiveChannel#base_url_manifest}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "baseUrlManifest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BaseUrlManifest
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#base_url_manifest1 MedialiveChannel#base_url_manifest1}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "baseUrlManifest1", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BaseUrlManifest1
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>caption_language_mappings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#caption_language_mappings MedialiveChannel#caption_language_mappings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "captionLanguageMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsCaptionLanguageMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CaptionLanguageMappings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#caption_language_setting MedialiveChannel#caption_language_setting}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "captionLanguageSetting", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CaptionLanguageSetting
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#client_cache MedialiveChannel#client_cache}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clientCache", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCache
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#codec_specification MedialiveChannel#codec_specification}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "codecSpecification", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CodecSpecification
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#constant_iv MedialiveChannel#constant_iv}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "constantIv", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConstantIv
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#directory_structure MedialiveChannel#directory_structure}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "directoryStructure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DirectoryStructure
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#discontinuity_tags MedialiveChannel#discontinuity_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "discontinuityTags", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DiscontinuityTags
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#encryption_type MedialiveChannel#encryption_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EncryptionType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>hls_cdn_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#hls_cdn_settings MedialiveChannel#hls_cdn_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hlsCdnSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HlsCdnSettings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#hls_id3_segment_tagging MedialiveChannel#hls_id3_segment_tagging}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hlsId3SegmentTagging", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HlsId3SegmentTagging
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#iframe_only_playlists MedialiveChannel#iframe_only_playlists}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "iframeOnlyPlaylists", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IframeOnlyPlaylists
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#incomplete_segment_behavior MedialiveChannel#incomplete_segment_behavior}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "incompleteSegmentBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IncompleteSegmentBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#index_n_segments MedialiveChannel#index_n_segments}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "indexNSegments", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IndexNSegments
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_loss_action MedialiveChannel#input_loss_action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inputLossAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InputLossAction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#iv_in_manifest MedialiveChannel#iv_in_manifest}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ivInManifest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IvInManifest
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#iv_source MedialiveChannel#iv_source}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ivSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IvSource
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#keep_segments MedialiveChannel#keep_segments}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keepSegments", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? KeepSegments
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#key_format MedialiveChannel#key_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keyFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#key_format_versions MedialiveChannel#key_format_versions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keyFormatVersions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyFormatVersions
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>key_provider_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#key_provider_settings MedialiveChannel#key_provider_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyProviderSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettings\"}", isOptional: true)]
            public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettings? KeyProviderSettings
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#manifest_compression MedialiveChannel#manifest_compression}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "manifestCompression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManifestCompression
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#manifest_duration_format MedialiveChannel#manifest_duration_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "manifestDurationFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManifestDurationFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#min_segment_length MedialiveChannel#min_segment_length}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minSegmentLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinSegmentLength
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#mode MedialiveChannel#mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#output_selection MedialiveChannel#output_selection}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outputSelection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutputSelection
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#program_date_time MedialiveChannel#program_date_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "programDateTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProgramDateTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#program_date_time_clock MedialiveChannel#program_date_time_clock}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "programDateTimeClock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProgramDateTimeClock
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#program_date_time_period MedialiveChannel#program_date_time_period}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "programDateTimePeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ProgramDateTimePeriod
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#redundant_manifest MedialiveChannel#redundant_manifest}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "redundantManifest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RedundantManifest
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#segment_length MedialiveChannel#segment_length}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "segmentLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SegmentLength
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#segments_per_subdirectory MedialiveChannel#segments_per_subdirectory}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "segmentsPerSubdirectory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SegmentsPerSubdirectory
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#stream_inf_resolution MedialiveChannel#stream_inf_resolution}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "streamInfResolution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StreamInfResolution
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timed_metadata_id3_frame MedialiveChannel#timed_metadata_id3_frame}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timedMetadataId3Frame", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimedMetadataId3Frame
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timed_metadata_id3_period MedialiveChannel#timed_metadata_id3_period}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timedMetadataId3Period", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TimedMetadataId3Period
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timestamp_delta_milliseconds MedialiveChannel#timestamp_delta_milliseconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timestampDeltaMilliseconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TimestampDeltaMilliseconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#ts_file_mode MedialiveChannel#ts_file_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tsFileMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TsFileMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
