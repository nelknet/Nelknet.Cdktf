using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsTtmlDestinationSettings")]
    public class MedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsTtmlDestinationSettings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsTtmlDestinationSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#style_control MedialiveChannel#style_control}.</summary>
        [JsiiProperty(name: "styleControl", typeJson: "{\"primitive\":\"string\"}")]
        public string StyleControl
        {
            get;
            set;
        }
    }
}
