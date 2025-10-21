using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioLanguageSelection")]
    public class MedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioLanguageSelection : aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioLanguageSelection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#language_code MedialiveChannel#language_code}.</summary>
        [JsiiProperty(name: "languageCode", typeJson: "{\"primitive\":\"string\"}")]
        public string LanguageCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#language_selection_policy MedialiveChannel#language_selection_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "languageSelectionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LanguageSelectionPolicy
        {
            get;
            set;
        }
    }
}
