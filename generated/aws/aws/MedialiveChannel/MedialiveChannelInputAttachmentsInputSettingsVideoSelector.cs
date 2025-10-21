using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsVideoSelector")]
    public class MedialiveChannelInputAttachmentsInputSettingsVideoSelector : aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsVideoSelector
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#color_space MedialiveChannel#color_space}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "colorSpace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ColorSpace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#color_space_usage MedialiveChannel#color_space_usage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "colorSpaceUsage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ColorSpaceUsage
        {
            get;
            set;
        }
    }
}
