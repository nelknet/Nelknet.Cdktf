using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveInput
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveInput.MedialiveInputMediaConnectFlows")]
    public class MedialiveInputMediaConnectFlows : aws.MedialiveInput.IMedialiveInputMediaConnectFlows
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input#flow_arn MedialiveInput#flow_arn}.</summary>
        [JsiiProperty(name: "flowArn", typeJson: "{\"primitive\":\"string\"}")]
        public string FlowArn
        {
            get;
            set;
        }
    }
}
