using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelDestinationsMultiplexSettings")]
    public class MedialiveChannelDestinationsMultiplexSettings : aws.MedialiveChannel.IMedialiveChannelDestinationsMultiplexSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#multiplex_id MedialiveChannel#multiplex_id}.</summary>
        [JsiiProperty(name: "multiplexId", typeJson: "{\"primitive\":\"string\"}")]
        public string MultiplexId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#program_name MedialiveChannel#program_name}.</summary>
        [JsiiProperty(name: "programName", typeJson: "{\"primitive\":\"string\"}")]
        public string ProgramName
        {
            get;
            set;
        }
    }
}
