using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventTarget
{
    [JsiiByValue(fqn: "aws.cloudwatchEventTarget.CloudwatchEventTargetAppsyncTarget")]
    public class CloudwatchEventTargetAppsyncTarget : aws.CloudwatchEventTarget.ICloudwatchEventTargetAppsyncTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#graphql_operation CloudwatchEventTarget#graphql_operation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "graphqlOperation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GraphqlOperation
        {
            get;
            set;
        }
    }
}
