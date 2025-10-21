using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettings")]
    public class MedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettings : aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettings
    {
        /// <summary>output_rectangle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#output_rectangle MedialiveChannel#output_rectangle}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "outputRectangle", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettingsOutputRectangle\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettingsOutputRectangle? OutputRectangle
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#page_number MedialiveChannel#page_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pageNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PageNumber
        {
            get;
            set;
        }
    }
}
