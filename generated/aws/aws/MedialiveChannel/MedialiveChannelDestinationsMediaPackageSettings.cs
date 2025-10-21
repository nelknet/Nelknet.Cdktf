using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelDestinationsMediaPackageSettings")]
    public class MedialiveChannelDestinationsMediaPackageSettings : aws.MedialiveChannel.IMedialiveChannelDestinationsMediaPackageSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#channel_id MedialiveChannel#channel_id}.</summary>
        [JsiiProperty(name: "channelId", typeJson: "{\"primitive\":\"string\"}")]
        public string ChannelId
        {
            get;
            set;
        }
    }
}
