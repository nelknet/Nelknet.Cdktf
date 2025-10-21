using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelCdiInputSpecification")]
    public class MedialiveChannelCdiInputSpecification : aws.MedialiveChannel.IMedialiveChannelCdiInputSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#resolution MedialiveChannel#resolution}.</summary>
        [JsiiProperty(name: "resolution", typeJson: "{\"primitive\":\"string\"}")]
        public string Resolution
        {
            get;
            set;
        }
    }
}
