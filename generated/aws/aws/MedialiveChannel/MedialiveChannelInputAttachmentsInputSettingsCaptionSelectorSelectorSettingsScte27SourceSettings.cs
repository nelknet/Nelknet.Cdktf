using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte27SourceSettings")]
    public class MedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte27SourceSettings : aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte27SourceSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#ocr_language MedialiveChannel#ocr_language}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ocrLanguage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OcrLanguage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#pid MedialiveChannel#pid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Pid
        {
            get;
            set;
        }
    }
}
