using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SesEventDestination
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sesEventDestination.SesEventDestinationSnsDestination")]
    public class SesEventDestinationSnsDestination : aws.SesEventDestination.ISesEventDestinationSnsDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_event_destination#topic_arn SesEventDestination#topic_arn}.</summary>
        [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
        public string TopicArn
        {
            get;
            set;
        }
    }
}
