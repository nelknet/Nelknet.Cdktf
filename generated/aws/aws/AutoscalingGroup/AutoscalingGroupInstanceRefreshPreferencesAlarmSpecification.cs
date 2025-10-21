using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiByValue(fqn: "aws.autoscalingGroup.AutoscalingGroupInstanceRefreshPreferencesAlarmSpecification")]
    public class AutoscalingGroupInstanceRefreshPreferencesAlarmSpecification : aws.AutoscalingGroup.IAutoscalingGroupInstanceRefreshPreferencesAlarmSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#alarms AutoscalingGroup#alarms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "alarms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Alarms
        {
            get;
            set;
        }
    }
}
