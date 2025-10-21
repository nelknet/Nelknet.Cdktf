using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings")]
    public class MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings
    {
        /// <summary>destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#destination MedialiveChannel#destination}
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsDestination\"}")]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsDestination Destination
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#ad_markers MedialiveChannel#ad_markers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adMarkers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AdMarkers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#base_url_content MedialiveChannel#base_url_content}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "baseUrlContent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BaseUrlContent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#base_url_content1 MedialiveChannel#base_url_content1}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "baseUrlContent1", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BaseUrlContent1
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#base_url_manifest MedialiveChannel#base_url_manifest}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "baseUrlManifest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BaseUrlManifest
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#base_url_manifest1 MedialiveChannel#base_url_manifest1}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "baseUrlManifest1", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BaseUrlManifest1
        {
            get;
            set;
        }

        private object? _captionLanguageMappings;

        /// <summary>caption_language_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#caption_language_mappings MedialiveChannel#caption_language_mappings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "captionLanguageMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsCaptionLanguageMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CaptionLanguageMappings
        {
            get => _captionLanguageMappings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsCaptionLanguageMappings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsCaptionLanguageMappings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _captionLanguageMappings = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#caption_language_setting MedialiveChannel#caption_language_setting}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "captionLanguageSetting", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CaptionLanguageSetting
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#client_cache MedialiveChannel#client_cache}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientCache", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientCache
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#codec_specification MedialiveChannel#codec_specification}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "codecSpecification", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CodecSpecification
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#constant_iv MedialiveChannel#constant_iv}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "constantIv", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConstantIv
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#directory_structure MedialiveChannel#directory_structure}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "directoryStructure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DirectoryStructure
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#discontinuity_tags MedialiveChannel#discontinuity_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "discontinuityTags", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DiscontinuityTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#encryption_type MedialiveChannel#encryption_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EncryptionType
        {
            get;
            set;
        }

        private object? _hlsCdnSettings;

        /// <summary>hls_cdn_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#hls_cdn_settings MedialiveChannel#hls_cdn_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hlsCdnSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? HlsCdnSettings
        {
            get => _hlsCdnSettings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _hlsCdnSettings = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#hls_id3_segment_tagging MedialiveChannel#hls_id3_segment_tagging}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hlsId3SegmentTagging", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HlsId3SegmentTagging
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#iframe_only_playlists MedialiveChannel#iframe_only_playlists}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iframeOnlyPlaylists", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IframeOnlyPlaylists
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#incomplete_segment_behavior MedialiveChannel#incomplete_segment_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "incompleteSegmentBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IncompleteSegmentBehavior
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#index_n_segments MedialiveChannel#index_n_segments}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "indexNSegments", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IndexNSegments
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_loss_action MedialiveChannel#input_loss_action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputLossAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InputLossAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#iv_in_manifest MedialiveChannel#iv_in_manifest}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ivInManifest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IvInManifest
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#iv_source MedialiveChannel#iv_source}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ivSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IvSource
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#keep_segments MedialiveChannel#keep_segments}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keepSegments", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? KeepSegments
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#key_format MedialiveChannel#key_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#key_format_versions MedialiveChannel#key_format_versions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyFormatVersions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyFormatVersions
        {
            get;
            set;
        }

        /// <summary>key_provider_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#key_provider_settings MedialiveChannel#key_provider_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyProviderSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettings? KeyProviderSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#manifest_compression MedialiveChannel#manifest_compression}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "manifestCompression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ManifestCompression
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#manifest_duration_format MedialiveChannel#manifest_duration_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "manifestDurationFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ManifestDurationFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#min_segment_length MedialiveChannel#min_segment_length}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minSegmentLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinSegmentLength
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#mode MedialiveChannel#mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#output_selection MedialiveChannel#output_selection}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outputSelection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OutputSelection
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#program_date_time MedialiveChannel#program_date_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "programDateTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProgramDateTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#program_date_time_clock MedialiveChannel#program_date_time_clock}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "programDateTimeClock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProgramDateTimeClock
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#program_date_time_period MedialiveChannel#program_date_time_period}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "programDateTimePeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ProgramDateTimePeriod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#redundant_manifest MedialiveChannel#redundant_manifest}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "redundantManifest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RedundantManifest
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#segment_length MedialiveChannel#segment_length}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "segmentLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SegmentLength
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#segments_per_subdirectory MedialiveChannel#segments_per_subdirectory}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "segmentsPerSubdirectory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SegmentsPerSubdirectory
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#stream_inf_resolution MedialiveChannel#stream_inf_resolution}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "streamInfResolution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StreamInfResolution
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timed_metadata_id3_frame MedialiveChannel#timed_metadata_id3_frame}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timedMetadataId3Frame", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimedMetadataId3Frame
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timed_metadata_id3_period MedialiveChannel#timed_metadata_id3_period}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timedMetadataId3Period", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TimedMetadataId3Period
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timestamp_delta_milliseconds MedialiveChannel#timestamp_delta_milliseconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timestampDeltaMilliseconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TimestampDeltaMilliseconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#ts_file_mode MedialiveChannel#ts_file_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tsFileMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TsFileMode
        {
            get;
            set;
        }
    }
}
