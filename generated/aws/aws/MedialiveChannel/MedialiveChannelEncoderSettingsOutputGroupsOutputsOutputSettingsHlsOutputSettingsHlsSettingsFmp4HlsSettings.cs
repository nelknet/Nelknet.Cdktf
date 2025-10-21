using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFmp4HlsSettings")]
    public class MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFmp4HlsSettings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFmp4HlsSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_rendition_sets MedialiveChannel#audio_rendition_sets}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "audioRenditionSets", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AudioRenditionSets
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timed_metadata_behavior MedialiveChannel#timed_metadata_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timedMetadataBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimedMetadataBehavior
        {
            get;
            set;
        }
    }
}
