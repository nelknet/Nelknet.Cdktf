using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsMsSmoothOutputSettings")]
    public class MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsMsSmoothOutputSettings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsMsSmoothOutputSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#h265_packaging_type MedialiveChannel#h265_packaging_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "h265PackagingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? H265PackagingType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#name_modifier MedialiveChannel#name_modifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nameModifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NameModifier
        {
            get;
            set;
        }
    }
}
