using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettings")]
    public class MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettings
    {
        /// <summary>destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#destination MedialiveChannel#destination}
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsDestination\"}")]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsDestination Destination
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#acquisition_point_id MedialiveChannel#acquisition_point_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "acquisitionPointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AcquisitionPointId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_only_timecode_control MedialiveChannel#audio_only_timecode_control}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "audioOnlyTimecodeControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AudioOnlyTimecodeControl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#certificate_mode MedialiveChannel#certificate_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#connection_retry_interval MedialiveChannel#connection_retry_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionRetryInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConnectionRetryInterval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#event_id MedialiveChannel#event_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eventId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EventId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#event_id_mode MedialiveChannel#event_id_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eventIdMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EventIdMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#event_stop_behavior MedialiveChannel#event_stop_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eventStopBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EventStopBehavior
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#filecache_duration MedialiveChannel#filecache_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "filecacheDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FilecacheDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#fragment_length MedialiveChannel#fragment_length}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fragmentLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FragmentLength
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#num_retries MedialiveChannel#num_retries}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "numRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NumRetries
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#restart_delay MedialiveChannel#restart_delay}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "restartDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RestartDelay
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#segmentation_mode MedialiveChannel#segmentation_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "segmentationMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SegmentationMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#send_delay_ms MedialiveChannel#send_delay_ms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sendDelayMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SendDelayMs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#sparse_track_type MedialiveChannel#sparse_track_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sparseTrackType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SparseTrackType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#stream_manifest_behavior MedialiveChannel#stream_manifest_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "streamManifestBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StreamManifestBehavior
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timestamp_offset MedialiveChannel#timestamp_offset}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timestampOffset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimestampOffset
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timestamp_offset_mode MedialiveChannel#timestamp_offset_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timestampOffsetMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimestampOffsetMode
        {
            get;
            set;
        }
    }
}
