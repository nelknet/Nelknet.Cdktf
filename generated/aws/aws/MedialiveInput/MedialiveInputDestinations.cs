using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveInput
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveInput.MedialiveInputDestinations")]
    public class MedialiveInputDestinations : aws.MedialiveInput.IMedialiveInputDestinations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input#stream_name MedialiveInput#stream_name}.</summary>
        [JsiiProperty(name: "streamName", typeJson: "{\"primitive\":\"string\"}")]
        public string StreamName
        {
            get;
            set;
        }
    }
}
