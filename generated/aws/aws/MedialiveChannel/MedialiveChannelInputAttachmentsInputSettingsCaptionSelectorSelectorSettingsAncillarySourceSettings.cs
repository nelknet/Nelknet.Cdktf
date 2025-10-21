using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAncillarySourceSettings")]
    public class MedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAncillarySourceSettings : aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAncillarySourceSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#source_ancillary_channel_number MedialiveChannel#source_ancillary_channel_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceAncillaryChannelNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SourceAncillaryChannelNumber
        {
            get;
            set;
        }
    }
}
