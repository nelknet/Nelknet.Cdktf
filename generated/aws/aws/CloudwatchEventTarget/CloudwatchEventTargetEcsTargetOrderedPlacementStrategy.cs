using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventTarget
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchEventTarget.CloudwatchEventTargetEcsTargetOrderedPlacementStrategy")]
    public class CloudwatchEventTargetEcsTargetOrderedPlacementStrategy : aws.CloudwatchEventTarget.ICloudwatchEventTargetEcsTargetOrderedPlacementStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#type CloudwatchEventTarget#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#field CloudwatchEventTarget#field}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Field
        {
            get;
            set;
        }
    }
}
