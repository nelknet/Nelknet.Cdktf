using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotTopicRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.iotTopicRule.IotTopicRuleCloudwatchAlarm")]
    public class IotTopicRuleCloudwatchAlarm : aws.IotTopicRule.IIotTopicRuleCloudwatchAlarm
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#alarm_name IotTopicRule#alarm_name}.</summary>
        [JsiiProperty(name: "alarmName", typeJson: "{\"primitive\":\"string\"}")]
        public string AlarmName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#state_reason IotTopicRule#state_reason}.</summary>
        [JsiiProperty(name: "stateReason", typeJson: "{\"primitive\":\"string\"}")]
        public string StateReason
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule#state_value IotTopicRule#state_value}.</summary>
        [JsiiProperty(name: "stateValue", typeJson: "{\"primitive\":\"string\"}")]
        public string StateValue
        {
            get;
            set;
        }
    }
}
