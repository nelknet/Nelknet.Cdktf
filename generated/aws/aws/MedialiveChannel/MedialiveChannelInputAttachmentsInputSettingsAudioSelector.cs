using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsAudioSelector")]
    public class MedialiveChannelInputAttachmentsInputSettingsAudioSelector : aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsAudioSelector
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#name MedialiveChannel#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>selector_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#selector_settings MedialiveChannel#selector_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "selectorSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettings? SelectorSettings
        {
            get;
            set;
        }
    }
}
