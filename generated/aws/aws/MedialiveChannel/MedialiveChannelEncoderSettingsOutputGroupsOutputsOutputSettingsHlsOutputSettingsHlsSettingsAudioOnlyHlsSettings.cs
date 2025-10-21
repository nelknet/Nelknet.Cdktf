using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettings")]
    public class MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_group_id MedialiveChannel#audio_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "audioGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AudioGroupId
        {
            get;
            set;
        }

        /// <summary>audio_only_image block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_only_image MedialiveChannel#audio_only_image}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "audioOnlyImage", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettingsAudioOnlyImage\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettingsAudioOnlyImage? AudioOnlyImage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_track_type MedialiveChannel#audio_track_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "audioTrackType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AudioTrackType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#segment_type MedialiveChannel#segment_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "segmentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SegmentType
        {
            get;
            set;
        }
    }
}
