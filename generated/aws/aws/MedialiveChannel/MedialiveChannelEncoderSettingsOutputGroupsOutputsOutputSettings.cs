using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettings")]
    public class MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettings
    {
        /// <summary>archive_output_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#archive_output_settings MedialiveChannel#archive_output_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "archiveOutputSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettings? ArchiveOutputSettings
        {
            get;
            set;
        }

        /// <summary>frame_capture_output_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#frame_capture_output_settings MedialiveChannel#frame_capture_output_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "frameCaptureOutputSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsFrameCaptureOutputSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsFrameCaptureOutputSettings? FrameCaptureOutputSettings
        {
            get;
            set;
        }

        /// <summary>hls_output_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#hls_output_settings MedialiveChannel#hls_output_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hlsOutputSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettings? HlsOutputSettings
        {
            get;
            set;
        }

        /// <summary>media_package_output_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#media_package_output_settings MedialiveChannel#media_package_output_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mediaPackageOutputSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsMediaPackageOutputSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsMediaPackageOutputSettings? MediaPackageOutputSettings
        {
            get;
            set;
        }

        /// <summary>ms_smooth_output_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#ms_smooth_output_settings MedialiveChannel#ms_smooth_output_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "msSmoothOutputSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsMsSmoothOutputSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsMsSmoothOutputSettings? MsSmoothOutputSettings
        {
            get;
            set;
        }

        /// <summary>multiplex_output_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#multiplex_output_settings MedialiveChannel#multiplex_output_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "multiplexOutputSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsMultiplexOutputSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsMultiplexOutputSettings? MultiplexOutputSettings
        {
            get;
            set;
        }

        /// <summary>rtmp_output_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#rtmp_output_settings MedialiveChannel#rtmp_output_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rtmpOutputSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettings? RtmpOutputSettings
        {
            get;
            set;
        }

        /// <summary>udp_output_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#udp_output_settings MedialiveChannel#udp_output_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "udpOutputSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettings? UdpOutputSettings
        {
            get;
            set;
        }
    }
}
