using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SesEventDestination
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sesEventDestination.SesEventDestinationKinesisDestination")]
    public class SesEventDestinationKinesisDestination : aws.SesEventDestination.ISesEventDestinationKinesisDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_event_destination#role_arn SesEventDestination#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_event_destination#stream_arn SesEventDestination#stream_arn}.</summary>
        [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}")]
        public string StreamArn
        {
            get;
            set;
        }
    }
}
