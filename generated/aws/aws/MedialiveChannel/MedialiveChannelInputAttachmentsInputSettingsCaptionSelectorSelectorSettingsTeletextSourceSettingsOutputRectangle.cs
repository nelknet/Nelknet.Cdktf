using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettingsOutputRectangle")]
    public class MedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettingsOutputRectangle : aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettingsOutputRectangle
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#height MedialiveChannel#height}.</summary>
        [JsiiProperty(name: "height", typeJson: "{\"primitive\":\"number\"}")]
        public double Height
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#left_offset MedialiveChannel#left_offset}.</summary>
        [JsiiProperty(name: "leftOffset", typeJson: "{\"primitive\":\"number\"}")]
        public double LeftOffset
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#top_offset MedialiveChannel#top_offset}.</summary>
        [JsiiProperty(name: "topOffset", typeJson: "{\"primitive\":\"number\"}")]
        public double TopOffset
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#width MedialiveChannel#width}.</summary>
        [JsiiProperty(name: "width", typeJson: "{\"primitive\":\"number\"}")]
        public double Width
        {
            get;
            set;
        }
    }
}
