using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsEmbeddedSourceSettings")]
    public class MedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsEmbeddedSourceSettings : aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsEmbeddedSourceSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#convert_608_to_708 MedialiveChannel#convert_608_to_708}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "convert608To708", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Convert608To708
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#scte20_detection MedialiveChannel#scte20_detection}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scte20Detection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Scte20Detection
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#source_608_channel_number MedialiveChannel#source_608_channel_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "source608ChannelNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Source608ChannelNumber
        {
            get;
            set;
        }
    }
}
