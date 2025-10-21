using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptions")]
    public class MedialiveChannelEncoderSettingsCaptionDescriptions : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsCaptionDescriptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#caption_selector_name MedialiveChannel#caption_selector_name}.</summary>
        [JsiiProperty(name: "captionSelectorName", typeJson: "{\"primitive\":\"string\"}")]
        public string CaptionSelectorName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#name MedialiveChannel#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#accessibility MedialiveChannel#accessibility}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessibility", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Accessibility
        {
            get;
            set;
        }

        /// <summary>destination_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#destination_settings MedialiveChannel#destination_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "destinationSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettings? DestinationSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#language_code MedialiveChannel#language_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "languageCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LanguageCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#language_description MedialiveChannel#language_description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "languageDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LanguageDescription
        {
            get;
            set;
        }
    }
}
