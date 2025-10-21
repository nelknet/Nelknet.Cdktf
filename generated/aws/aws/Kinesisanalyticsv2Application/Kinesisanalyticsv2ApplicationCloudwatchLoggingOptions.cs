using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesisanalyticsv2Application
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesisanalyticsv2Application.Kinesisanalyticsv2ApplicationCloudwatchLoggingOptions")]
    public class Kinesisanalyticsv2ApplicationCloudwatchLoggingOptions : aws.Kinesisanalyticsv2Application.IKinesisanalyticsv2ApplicationCloudwatchLoggingOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesisanalyticsv2_application#log_stream_arn Kinesisanalyticsv2Application#log_stream_arn}.</summary>
        [JsiiProperty(name: "logStreamArn", typeJson: "{\"primitive\":\"string\"}")]
        public string LogStreamArn
        {
            get;
            set;
        }
    }
}
