using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettings")]
    public interface IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettings
    {
        /// <summary>archive_group_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#archive_group_settings MedialiveChannel#archive_group_settings}
        /// </remarks>
        [JsiiProperty(name: "archiveGroupSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ArchiveGroupSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>frame_capture_group_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#frame_capture_group_settings MedialiveChannel#frame_capture_group_settings}
        /// </remarks>
        [JsiiProperty(name: "frameCaptureGroupSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettings? FrameCaptureGroupSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>hls_group_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#hls_group_settings MedialiveChannel#hls_group_settings}
        /// </remarks>
        [JsiiProperty(name: "hlsGroupSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings? HlsGroupSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>media_package_group_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#media_package_group_settings MedialiveChannel#media_package_group_settings}
        /// </remarks>
        [JsiiProperty(name: "mediaPackageGroupSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettings? MediaPackageGroupSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>ms_smooth_group_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#ms_smooth_group_settings MedialiveChannel#ms_smooth_group_settings}
        /// </remarks>
        [JsiiProperty(name: "msSmoothGroupSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettings? MsSmoothGroupSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>multiplex_group_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#multiplex_group_settings MedialiveChannel#multiplex_group_settings}
        /// </remarks>
        [JsiiProperty(name: "multiplexGroupSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMultiplexGroupSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMultiplexGroupSettings? MultiplexGroupSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>rtmp_group_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#rtmp_group_settings MedialiveChannel#rtmp_group_settings}
        /// </remarks>
        [JsiiProperty(name: "rtmpGroupSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsRtmpGroupSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsRtmpGroupSettings? RtmpGroupSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>udp_group_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#udp_group_settings MedialiveChannel#udp_group_settings}
        /// </remarks>
        [JsiiProperty(name: "udpGroupSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsUdpGroupSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsUdpGroupSettings? UdpGroupSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettings")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>archive_group_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#archive_group_settings MedialiveChannel#archive_group_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "archiveGroupSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ArchiveGroupSettings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>frame_capture_group_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#frame_capture_group_settings MedialiveChannel#frame_capture_group_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "frameCaptureGroupSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettings\"}", isOptional: true)]
            public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettings? FrameCaptureGroupSettings
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettings?>();
            }

            /// <summary>hls_group_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#hls_group_settings MedialiveChannel#hls_group_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hlsGroupSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings\"}", isOptional: true)]
            public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings? HlsGroupSettings
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings?>();
            }

            /// <summary>media_package_group_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#media_package_group_settings MedialiveChannel#media_package_group_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mediaPackageGroupSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettings\"}", isOptional: true)]
            public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettings? MediaPackageGroupSettings
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettings?>();
            }

            /// <summary>ms_smooth_group_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#ms_smooth_group_settings MedialiveChannel#ms_smooth_group_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "msSmoothGroupSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettings\"}", isOptional: true)]
            public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettings? MsSmoothGroupSettings
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettings?>();
            }

            /// <summary>multiplex_group_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#multiplex_group_settings MedialiveChannel#multiplex_group_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "multiplexGroupSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMultiplexGroupSettings\"}", isOptional: true)]
            public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMultiplexGroupSettings? MultiplexGroupSettings
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMultiplexGroupSettings?>();
            }

            /// <summary>rtmp_group_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#rtmp_group_settings MedialiveChannel#rtmp_group_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rtmpGroupSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsRtmpGroupSettings\"}", isOptional: true)]
            public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsRtmpGroupSettings? RtmpGroupSettings
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsRtmpGroupSettings?>();
            }

            /// <summary>udp_group_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#udp_group_settings MedialiveChannel#udp_group_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "udpGroupSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsUdpGroupSettings\"}", isOptional: true)]
            public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsUdpGroupSettings? UdpGroupSettings
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsUdpGroupSettings?>();
            }
        }
    }
}
