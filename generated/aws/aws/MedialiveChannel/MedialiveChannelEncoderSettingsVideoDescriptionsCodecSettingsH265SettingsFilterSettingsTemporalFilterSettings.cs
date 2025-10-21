using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettingsTemporalFilterSettings")]
    public class MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettingsTemporalFilterSettings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettingsTemporalFilterSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#post_filter_sharpening MedialiveChannel#post_filter_sharpening}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "postFilterSharpening", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PostFilterSharpening
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#strength MedialiveChannel#strength}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "strength", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Strength
        {
            get;
            set;
        }
    }
}
