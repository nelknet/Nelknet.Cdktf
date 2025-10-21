using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettings")]
    public class MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettings
    {
        private object? _archiveGroupSettings;

        /// <summary>archive_group_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#archive_group_settings MedialiveChannel#archive_group_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "archiveGroupSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ArchiveGroupSettings
        {
            get => _archiveGroupSettings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _archiveGroupSettings = value;
            }
        }

        /// <summary>frame_capture_group_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#frame_capture_group_settings MedialiveChannel#frame_capture_group_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "frameCaptureGroupSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettings? FrameCaptureGroupSettings
        {
            get;
            set;
        }

        /// <summary>hls_group_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#hls_group_settings MedialiveChannel#hls_group_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hlsGroupSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings? HlsGroupSettings
        {
            get;
            set;
        }

        /// <summary>media_package_group_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#media_package_group_settings MedialiveChannel#media_package_group_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mediaPackageGroupSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettings? MediaPackageGroupSettings
        {
            get;
            set;
        }

        /// <summary>ms_smooth_group_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#ms_smooth_group_settings MedialiveChannel#ms_smooth_group_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "msSmoothGroupSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettings? MsSmoothGroupSettings
        {
            get;
            set;
        }

        /// <summary>multiplex_group_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#multiplex_group_settings MedialiveChannel#multiplex_group_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "multiplexGroupSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMultiplexGroupSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMultiplexGroupSettings? MultiplexGroupSettings
        {
            get;
            set;
        }

        /// <summary>rtmp_group_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#rtmp_group_settings MedialiveChannel#rtmp_group_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rtmpGroupSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsRtmpGroupSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsRtmpGroupSettings? RtmpGroupSettings
        {
            get;
            set;
        }

        /// <summary>udp_group_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#udp_group_settings MedialiveChannel#udp_group_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "udpGroupSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsUdpGroupSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsUdpGroupSettings? UdpGroupSettings
        {
            get;
            set;
        }
    }
}
