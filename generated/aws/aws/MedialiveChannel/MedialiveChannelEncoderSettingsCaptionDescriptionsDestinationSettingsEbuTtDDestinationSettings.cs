using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsEbuTtDDestinationSettings")]
    public class MedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsEbuTtDDestinationSettings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsEbuTtDDestinationSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#copyright_holder MedialiveChannel#copyright_holder}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "copyrightHolder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CopyrightHolder
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#fill_line_gap MedialiveChannel#fill_line_gap}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fillLineGap", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FillLineGap
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#font_family MedialiveChannel#font_family}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fontFamily", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FontFamily
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#style_control MedialiveChannel#style_control}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "styleControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StyleControl
        {
            get;
            set;
        }
    }
}
