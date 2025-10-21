using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventTarget
{
    [JsiiByValue(fqn: "aws.cloudwatchEventTarget.CloudwatchEventTargetDeadLetterConfig")]
    public class CloudwatchEventTargetDeadLetterConfig : aws.CloudwatchEventTarget.ICloudwatchEventTargetDeadLetterConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#arn CloudwatchEventTarget#arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Arn
        {
            get;
            set;
        }
    }
}
