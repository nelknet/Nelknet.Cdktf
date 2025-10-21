using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettings")]
    public class MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#absent_input_audio_behavior MedialiveChannel#absent_input_audio_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "absentInputAudioBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AbsentInputAudioBehavior
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#arib MedialiveChannel#arib}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "arib", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Arib
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#arib_captions_pid MedialiveChannel#arib_captions_pid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "aribCaptionsPid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AribCaptionsPid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#arib_captions_pid_control MedialiveChannel#arib_captions_pid_control}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "aribCaptionsPidControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AribCaptionsPidControl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_buffer_model MedialiveChannel#audio_buffer_model}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "audioBufferModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AudioBufferModel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_frames_per_pes MedialiveChannel#audio_frames_per_pes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "audioFramesPerPes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AudioFramesPerPes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_pids MedialiveChannel#audio_pids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "audioPids", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AudioPids
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_stream_type MedialiveChannel#audio_stream_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "audioStreamType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AudioStreamType
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#buffer_model MedialiveChannel#buffer_model}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bufferModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BufferModel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#cc_descriptor MedialiveChannel#cc_descriptor}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ccDescriptor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CcDescriptor
        {
            get;
            set;
        }

        /// <summary>dvb_nit_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#dvb_nit_settings MedialiveChannel#dvb_nit_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dvbNitSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbNitSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbNitSettings? DvbNitSettings
        {
            get;
            set;
        }

        /// <summary>dvb_sdt_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#dvb_sdt_settings MedialiveChannel#dvb_sdt_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dvbSdtSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbSdtSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbSdtSettings? DvbSdtSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#dvb_sub_pids MedialiveChannel#dvb_sub_pids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dvbSubPids", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DvbSubPids
        {
            get;
            set;
        }

        /// <summary>dvb_tdt_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#dvb_tdt_settings MedialiveChannel#dvb_tdt_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dvbTdtSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbTdtSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbTdtSettings? DvbTdtSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#dvb_teletext_pid MedialiveChannel#dvb_teletext_pid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dvbTeletextPid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DvbTeletextPid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#ebif MedialiveChannel#ebif}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ebif", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ebif
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#ebp_audio_interval MedialiveChannel#ebp_audio_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ebpAudioInterval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EbpAudioInterval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#ebp_lookahead_ms MedialiveChannel#ebp_lookahead_ms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ebpLookaheadMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? EbpLookaheadMs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#ebp_placement MedialiveChannel#ebp_placement}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ebpPlacement", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EbpPlacement
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#ecm_pid MedialiveChannel#ecm_pid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ecmPid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EcmPid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#es_rate_in_pes MedialiveChannel#es_rate_in_pes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "esRateInPes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EsRateInPes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#etv_platform_pid MedialiveChannel#etv_platform_pid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "etvPlatformPid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EtvPlatformPid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#etv_signal_pid MedialiveChannel#etv_signal_pid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "etvSignalPid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EtvSignalPid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#fragment_time MedialiveChannel#fragment_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fragmentTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FragmentTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#klv MedialiveChannel#klv}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "klv", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Klv
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#klv_data_pids MedialiveChannel#klv_data_pids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "klvDataPids", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KlvDataPids
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#nielsen_id3_behavior MedialiveChannel#nielsen_id3_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nielsenId3Behavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NielsenId3Behavior
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#null_packet_bitrate MedialiveChannel#null_packet_bitrate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nullPacketBitrate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NullPacketBitrate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#pat_interval MedialiveChannel#pat_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "patInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PatInterval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#pcr_control MedialiveChannel#pcr_control}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pcrControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PcrControl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#pcr_period MedialiveChannel#pcr_period}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pcrPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PcrPeriod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#pcr_pid MedialiveChannel#pcr_pid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pcrPid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PcrPid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#pmt_interval MedialiveChannel#pmt_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pmtInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PmtInterval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#pmt_pid MedialiveChannel#pmt_pid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pmtPid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PmtPid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#program_num MedialiveChannel#program_num}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "programNum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ProgramNum
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#rate_mode MedialiveChannel#rate_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rateMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RateMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#scte27_pids MedialiveChannel#scte27_pids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scte27Pids", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Scte27Pids
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#scte35_control MedialiveChannel#scte35_control}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scte35Control", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Scte35Control
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#scte35_pid MedialiveChannel#scte35_pid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scte35Pid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Scte35Pid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#segmentation_markers MedialiveChannel#segmentation_markers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "segmentationMarkers", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SegmentationMarkers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#segmentation_style MedialiveChannel#segmentation_style}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "segmentationStyle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SegmentationStyle
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#segmentation_time MedialiveChannel#segmentation_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "segmentationTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SegmentationTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timed_metadata_behavior MedialiveChannel#timed_metadata_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timedMetadataBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimedMetadataBehavior
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timed_metadata_pid MedialiveChannel#timed_metadata_pid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timedMetadataPid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimedMetadataPid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#transport_stream_id MedialiveChannel#transport_stream_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transportStreamId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TransportStreamId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#video_pid MedialiveChannel#video_pid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "videoPid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VideoPid
        {
            get;
            set;
        }
    }
}
