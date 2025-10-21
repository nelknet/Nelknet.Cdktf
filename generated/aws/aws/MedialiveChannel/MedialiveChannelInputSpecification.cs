using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelInputSpecification")]
    public class MedialiveChannelInputSpecification : aws.MedialiveChannel.IMedialiveChannelInputSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#codec MedialiveChannel#codec}.</summary>
        [JsiiProperty(name: "codec", typeJson: "{\"primitive\":\"string\"}")]
        public string Codec
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_resolution MedialiveChannel#input_resolution}.</summary>
        [JsiiProperty(name: "inputResolution", typeJson: "{\"primitive\":\"string\"}")]
        public string InputResolution
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#maximum_bitrate MedialiveChannel#maximum_bitrate}.</summary>
        [JsiiProperty(name: "maximumBitrate", typeJson: "{\"primitive\":\"string\"}")]
        public string MaximumBitrate
        {
            get;
            set;
        }
    }
}
